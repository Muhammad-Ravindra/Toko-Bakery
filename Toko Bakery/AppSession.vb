Imports System

Namespace TokoRotiVB
    Friend NotInheritable Class AppSession
        Private Sub New()
        End Sub

        Public Shared Property ConnectionString As String = String.Empty
        Public Shared Property Username As String = String.Empty
        Public Shared ReadOnly Property IsOwner As Boolean
            Get
                Return String.Equals(Username, "owner_toko_roti", StringComparison.OrdinalIgnoreCase)
            End Get
        End Property

        Public Shared Sub Clear()
            ConnectionString = String.Empty
            Username = String.Empty
        End Sub
    End Class
End Namespace
