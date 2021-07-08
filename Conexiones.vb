Imports System.Web
Imports System.Data.SqlClient
Public Class Conexiones
    Private Shared _cnn As SqlClient.SqlConnection
    Private Shared _validar As String = "0"

    Public Shared Property Cnn As SqlConnection
        Get
            Return _cnn
        End Get
        Set(value As SqlConnection)
            _cnn = value
        End Set
    End Property

    Public Shared Property Validar As String
        Get
            Return _validar
        End Get
        Set(value As String)
            _validar = value
        End Set
    End Property

    Public Shared Sub AbrirConexion()
        Cnn = New SqlConnection("Server=localhost\SQLEXPRESS;Database=escuela;User Id=julio;Password=ciencia123;")
    End Sub
End Class
