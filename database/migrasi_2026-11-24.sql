-- =====================================================================
-- Migrasi database toko_roti_roti - 24 November 2026
-- Untuk database versi lama (masih punya tabel kontak_pelanggan dan
-- kategori produk Cake / Kue Basah / Kue Kering).
--
-- Kalau mau database baru dari nol, import database/toko_roti_roti.sql saja,
-- tidak perlu menjalankan file ini.
--
-- Cara pakai (phpMyAdmin): pilih database toko_roti_roti -> tab Import -> pilih file ini.
-- Cara pakai (terminal):   mysql -u root toko_roti_roti < database/migrasi_2026-11-24.sql
-- =====================================================================

-- 1. Email dan No. HP pindah jadi kolom di tabel pelanggan
--    (satu pelanggan cukup satu email dan satu nomor HP).
ALTER TABLE pelanggan
  ADD COLUMN IF NOT EXISTS email VARCHAR(100) NULL AFTER alamat_pengiriman,
  ADD COLUMN IF NOT EXISTS no_hp VARCHAR(20) NULL AFTER email;

-- 2. Salin kontak lama ke kolom baru, lalu hapus tabel kontak_pelanggan.
--    No. HP diambil dari kontak bertipe Telepon (atau WhatsApp kalau tidak ada Telepon).
--    Prosedur sementara dipakai supaya langkah ini aman dilewati
--    kalau tabel kontak_pelanggan sudah tidak ada.
DROP PROCEDURE IF EXISTS migrasi_kontak_pelanggan;
DELIMITER //
CREATE PROCEDURE migrasi_kontak_pelanggan()
BEGIN
  IF EXISTS (SELECT 1 FROM information_schema.tables
             WHERE table_schema = DATABASE() AND table_name = 'kontak_pelanggan') THEN
    UPDATE pelanggan p
    SET p.email = COALESCE(p.email, (
          SELECT k.nilai_kontak FROM kontak_pelanggan k
          WHERE k.id_pelanggan = p.id_pelanggan AND k.tipe_kontak = 'Email'
          ORDER BY k.id_kontak LIMIT 1)),
        p.no_hp = COALESCE(p.no_hp, (
          SELECT k.nilai_kontak FROM kontak_pelanggan k
          WHERE k.id_pelanggan = p.id_pelanggan AND k.tipe_kontak IN ('Telepon', 'WhatsApp')
          ORDER BY (k.tipe_kontak = 'Telepon') DESC, k.id_kontak LIMIT 1));
    DROP TABLE kontak_pelanggan;
  END IF;
END //
DELIMITER ;
CALL migrasi_kontak_pelanggan();
DROP PROCEDURE migrasi_kontak_pelanggan;

-- 3. Kategori produk cukup 4: Kue, Roti, Jajan Basah, Jajan Kering.
UPDATE produk SET kategori = CASE kategori
    WHEN 'Cake'       THEN 'Kue'
    WHEN 'Kue Basah'  THEN 'Jajan Basah'
    WHEN 'Kue Kering' THEN 'Jajan Kering'
    ELSE kategori
  END;

ALTER TABLE produk MODIFY kategori VARCHAR(30) NOT NULL;
ALTER TABLE produk DROP CONSTRAINT IF EXISTS chk_produk_kategori;
ALTER TABLE produk
  ADD CONSTRAINT chk_produk_kategori CHECK (kategori IN ('Kue', 'Roti', 'Jajan Basah', 'Jajan Kering'));
