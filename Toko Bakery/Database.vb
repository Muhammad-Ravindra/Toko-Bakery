Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Namespace TokoRotiVB
    Friend NotInheritable Class Database
        Private Sub New()
        End Sub

        Public Shared Function CreateConnection() As MySqlConnection
            If String.IsNullOrWhiteSpace(AppSession.ConnectionString) Then
                Throw New InvalidOperationException("Sesi database belum aktif. Silakan login kembali.")
            End If
            Return New MySqlConnection(AppSession.ConnectionString)
        End Function

        Public Shared Function Query(sql As String, ParamArray parameters As MySqlParameter()) As DataTable
            Using connection As MySqlConnection = CreateConnection()
                Using command As New MySqlCommand(sql, connection)
                    If parameters IsNot Nothing AndAlso parameters.Length > 0 Then command.Parameters.AddRange(parameters)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        Return table
                    End Using
                End Using
            End Using
        End Function

        Public Shared Function Execute(sql As String, ParamArray parameters As MySqlParameter()) As Integer
            Using connection As MySqlConnection = CreateConnection()
                connection.Open()
                Using command As New MySqlCommand(sql, connection)
                    If parameters IsNot Nothing AndAlso parameters.Length > 0 Then command.Parameters.AddRange(parameters)
                    Return command.ExecuteNonQuery()
                End Using
            End Using
        End Function

        Public Shared Function Scalar(sql As String, ParamArray parameters As MySqlParameter()) As Object
            Using connection As MySqlConnection = CreateConnection()
                connection.Open()
                Using command As New MySqlCommand(sql, connection)
                    If parameters IsNot Nothing AndAlso parameters.Length > 0 Then command.Parameters.AddRange(parameters)
                    Return command.ExecuteScalar()
                End Using
            End Using
        End Function
    End Class
End Namespace
