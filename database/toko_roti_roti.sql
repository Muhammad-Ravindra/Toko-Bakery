-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: toko_roti_roti
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `toko_roti_roti`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `toko_roti_roti` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `toko_roti_roti`;

--
-- Table structure for table `bundle`
--

DROP TABLE IF EXISTS `bundle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bundle` (
  `id_bundle` int(11) NOT NULL AUTO_INCREMENT,
  `nama_bundle` varchar(100) NOT NULL,
  PRIMARY KEY (`id_bundle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bundle`
--

LOCK TABLES `bundle` WRITE;
/*!40000 ALTER TABLE `bundle` DISABLE KEYS */;
/*!40000 ALTER TABLE `bundle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detail_bundle`
--

DROP TABLE IF EXISTS `detail_bundle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detail_bundle` (
  `id_detail_bundle` int(11) NOT NULL AUTO_INCREMENT,
  `id_bundle` int(11) NOT NULL,
  `id_produk` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  PRIMARY KEY (`id_detail_bundle`),
  KEY `id_bundle` (`id_bundle`),
  KEY `id_produk` (`id_produk`),
  CONSTRAINT `detail_bundle_ibfk_1` FOREIGN KEY (`id_bundle`) REFERENCES `bundle` (`id_bundle`) ON DELETE CASCADE,
  CONSTRAINT `detail_bundle_ibfk_2` FOREIGN KEY (`id_produk`) REFERENCES `produk` (`id_produk`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detail_bundle`
--

LOCK TABLES `detail_bundle` WRITE;
/*!40000 ALTER TABLE `detail_bundle` DISABLE KEYS */;
/*!40000 ALTER TABLE `detail_bundle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detail_pesanan`
--

DROP TABLE IF EXISTS `detail_pesanan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detail_pesanan` (
  `id_detail` int(11) NOT NULL AUTO_INCREMENT,
  `id_pesanan` int(11) NOT NULL,
  `id_produk` int(11) DEFAULT NULL,
  `id_bundle` int(11) DEFAULT NULL,
  `qty` int(11) NOT NULL DEFAULT 1,
  `harga_satuan` decimal(12,2) NOT NULL,
  `subtotal` decimal(12,2) NOT NULL,
  `catatan` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_detail`),
  KEY `fk_detail_pesanan` (`id_pesanan`),
  KEY `fk_detail_produk` (`id_produk`),
  KEY `fk_detail_bundle` (`id_bundle`),
  CONSTRAINT `fk_detail_bundle` FOREIGN KEY (`id_bundle`) REFERENCES `bundle` (`id_bundle`),
  CONSTRAINT `fk_detail_pesanan` FOREIGN KEY (`id_pesanan`) REFERENCES `pesanan` (`id_pesanan`),
  CONSTRAINT `fk_detail_produk` FOREIGN KEY (`id_produk`) REFERENCES `produk` (`id_produk`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detail_pesanan`
--

LOCK TABLES `detail_pesanan` WRITE;
/*!40000 ALTER TABLE `detail_pesanan` DISABLE KEYS */;
INSERT INTO `detail_pesanan` VALUES (1,1,3,NULL,4,5000.00,20000.00,NULL),(2,1,9,NULL,3,5000.00,15000.00,NULL);
/*!40000 ALTER TABLE `detail_pesanan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `karyawan`
--

DROP TABLE IF EXISTS `karyawan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `karyawan` (
  `id_karyawan` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(100) NOT NULL,
  `role` enum('Owner','Kasir') NOT NULL,
  PRIMARY KEY (`id_karyawan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `karyawan`
--

LOCK TABLES `karyawan` WRITE;
/*!40000 ALTER TABLE `karyawan` DISABLE KEYS */;
/*!40000 ALTER TABLE `karyawan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pelanggan`
--

DROP TABLE IF EXISTS `pelanggan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pelanggan` (
  `id_pelanggan` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(100) NOT NULL,
  `tipe` varchar(20) NOT NULL DEFAULT 'individu',
  `alamat_pengiriman` varchar(255) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `no_hp` varchar(20) DEFAULT NULL,
  `termin_hari` int(11) NOT NULL DEFAULT 0,
  `is_deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`id_pelanggan`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pelanggan`
--

LOCK TABLES `pelanggan` WRITE;
/*!40000 ALTER TABLE `pelanggan` DISABLE KEYS */;
INSERT INTO `pelanggan` VALUES (1,'Budi Santoso','individu','Jl. Merdeka No. 10, Jakarta','budi.santoso@gmail.com','081234567890',0,0),(2,'PT Maju Bersama','perusahaan','Jl. Sudirman Kav. 52, Jakarta','purchasing@majubersama.co.id','021-5551234',30,0),(3,'Siti Aminah','individu',NULL,NULL,'085798765432',7,0),(4,'CV Karya Abadi','perusahaan','Jl. Gatot Subroto No. 15, Bandung','admin@karyabadi.com','022-7778899',14,0),(5,'Andi Wijaya','individu','Jl. Pahlawan No. 8, Surabaya',NULL,'031-8887766',0,1);
/*!40000 ALTER TABLE `pelanggan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pembayaran`
--

DROP TABLE IF EXISTS `pembayaran`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pembayaran` (
  `id_bayar` int(11) NOT NULL AUTO_INCREMENT,
  `id_pesanan` int(11) NOT NULL,
  `id_karyawan` int(11) DEFAULT NULL,
  `tgl_bayar` date NOT NULL,
  `jumlah` decimal(12,2) NOT NULL,
  `metode` varchar(15) NOT NULL DEFAULT 'transfer',
  `jenis` varchar(15) NOT NULL DEFAULT 'DP',
  PRIMARY KEY (`id_bayar`),
  KEY `fk_bayar_pesanan` (`id_pesanan`),
  KEY `fk_pembayaran_kasir` (`id_karyawan`),
  CONSTRAINT `fk_bayar_pesanan` FOREIGN KEY (`id_pesanan`) REFERENCES `pesanan` (`id_pesanan`),
  CONSTRAINT `fk_pembayaran_kasir` FOREIGN KEY (`id_karyawan`) REFERENCES `karyawan` (`id_karyawan`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pembayaran`
--

LOCK TABLES `pembayaran` WRITE;
/*!40000 ALTER TABLE `pembayaran` DISABLE KEYS */;
INSERT INTO `pembayaran` VALUES (1,1,NULL,'2026-11-24',10000.00,'transfer','DP'),(2,1,NULL,'2026-11-24',20000.00,'transfer','DP');
/*!40000 ALTER TABLE `pembayaran` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pesanan`
--

DROP TABLE IF EXISTS `pesanan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pesanan` (
  `id_pesanan` int(11) NOT NULL AUTO_INCREMENT,
  `id_pelanggan` int(11) NOT NULL,
  `id_karyawan` int(11) DEFAULT NULL,
  `alamat_pengiriman` varchar(255) DEFAULT NULL,
  `tgl_pesan` date NOT NULL,
  `tgl_kirim` date DEFAULT NULL,
  `jam_kirim` time DEFAULT NULL,
  `sumber` varchar(20) NOT NULL DEFAULT 'WA',
  `total` decimal(12,2) NOT NULL DEFAULT 0.00,
  `dp` decimal(12,2) NOT NULL DEFAULT 0.00,
  `sisa` decimal(12,2) NOT NULL DEFAULT 0.00,
  `status_pesanan` varchar(20) NOT NULL DEFAULT 'BARU',
  `status_bayar` varchar(15) NOT NULL DEFAULT 'BELUM',
  `catatan` text DEFAULT NULL,
  PRIMARY KEY (`id_pesanan`),
  KEY `fk_pesanan_pelanggan` (`id_pelanggan`),
  KEY `fk_pesanan_admin` (`id_karyawan`),
  CONSTRAINT `fk_pesanan_admin` FOREIGN KEY (`id_karyawan`) REFERENCES `karyawan` (`id_karyawan`),
  CONSTRAINT `fk_pesanan_pelanggan` FOREIGN KEY (`id_pelanggan`) REFERENCES `pelanggan` (`id_pelanggan`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pesanan`
--

LOCK TABLES `pesanan` WRITE;
/*!40000 ALTER TABLE `pesanan` DISABLE KEYS */;
INSERT INTO `pesanan` VALUES (1,2,NULL,NULL,'2026-11-24','2026-11-26','09:50:12','Telepon',35000.00,30000.00,5000.00,'BARU','DP','Ngutang');
/*!40000 ALTER TABLE `pesanan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produk`
--

DROP TABLE IF EXISTS `produk`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produk` (
  `id_produk` int(11) NOT NULL AUTO_INCREMENT,
  `nama_produk` varchar(100) NOT NULL,
  `kategori` varchar(30) NOT NULL,
  `harga_jual` decimal(12,2) NOT NULL DEFAULT 0.00,
  `hpp` decimal(12,2) NOT NULL DEFAULT 0.00,
  `masa_simpan_jam` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_produk`),
  CONSTRAINT `chk_produk_kategori` CHECK (`kategori` in ('Kue','Roti','Jajan Basah','Jajan Kering'))
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produk`
--

LOCK TABLES `produk` WRITE;
/*!40000 ALTER TABLE `produk` DISABLE KEYS */;
INSERT INTO `produk` VALUES (1,'Lapis Legit Premium','Kue',350000.00,200000.00,120),(2,'Brownies Cokelat Fudge','Kue',75000.00,45000.00,72),(3,'Bolu Kukus Pandan','Jajan Basah',5000.00,2500.00,24),(4,'Croissant Butter','Roti',25000.00,15000.00,48),(5,'Cheesecake Blueberry','Kue',150000.00,90000.00,72),(6,'Donat Gula Klasik','Roti',8000.00,4000.00,24),(7,'Pia Kacang Hijau','Jajan Kering',6000.00,3500.00,720),(8,'Risoles Mayones','Jajan Basah',7000.00,4000.00,24),(9,'Klepon Gula Merah','Jajan Basah',5000.00,2500.00,12),(10,'Talam Ubi Ungu','Jajan Basah',6000.00,3500.00,24);
/*!40000 ALTER TABLE `produk` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `v_nota_transaksi`
--

DROP TABLE IF EXISTS `v_nota_transaksi`;
/*!50001 DROP VIEW IF EXISTS `v_nota_transaksi`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_nota_transaksi` AS SELECT
 1 AS `id_pesanan`,
  1 AS `tgl_pesan`,
  1 AS `tgl_kirim`,
  1 AS `jam_kirim`,
  1 AS `nama_pelanggan`,
  1 AS `tipe_pelanggan`,
  1 AS `nama_produk`,
  1 AS `qty`,
  1 AS `harga_satuan`,
  1 AS `subtotal`,
  1 AS `total`,
  1 AS `dp`,
  1 AS `sisa`,
  1 AS `status_pesanan`,
  1 AS `status_bayar`,
  1 AS `catatan` */;
SET character_set_client = @saved_cs_client;

--
-- Dumping routines for database 'toko_roti_roti'
--

--
-- Current Database: `toko_roti_roti`
--

USE `toko_roti_roti`;

--
-- Final view structure for view `v_nota_transaksi`
--

/*!50001 DROP VIEW IF EXISTS `v_nota_transaksi`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_nota_transaksi` AS select `p`.`id_pesanan` AS `id_pesanan`,`p`.`tgl_pesan` AS `tgl_pesan`,`p`.`tgl_kirim` AS `tgl_kirim`,`p`.`jam_kirim` AS `jam_kirim`,`pl`.`nama` AS `nama_pelanggan`,`pl`.`tipe` AS `tipe_pelanggan`,`pr`.`nama_produk` AS `nama_produk`,`d`.`qty` AS `qty`,`d`.`harga_satuan` AS `harga_satuan`,`d`.`subtotal` AS `subtotal`,`p`.`total` AS `total`,`p`.`dp` AS `dp`,`p`.`sisa` AS `sisa`,`p`.`status_pesanan` AS `status_pesanan`,`p`.`status_bayar` AS `status_bayar`,`p`.`catatan` AS `catatan` from (((`pesanan` `p` join `pelanggan` `pl` on(`p`.`id_pelanggan` = `pl`.`id_pelanggan`)) join `detail_pesanan` `d` on(`p`.`id_pesanan` = `d`.`id_pesanan`)) join `produk` `pr` on(`d`.`id_produk` = `pr`.`id_produk`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed
