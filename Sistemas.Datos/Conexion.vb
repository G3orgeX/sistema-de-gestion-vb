Imports System.Data.SqlClient
Public Class Conexion
    Private _Base As String
    Private _Usuario As String
    Private _Clave As String
    Private _Servidor As String
    Private _seguridad As Boolean = True
    Public conn As SqlConnection
    Public Property Base As String
        Get
            Return _Base
        End Get
        Set(value As String)
            _Base = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _Clave
        End Get
        Set(value As String)
            _Clave = value
        End Set
    End Property

    Public Property Servidor As String
        Get
            Return _Servidor
        End Get
        Set(value As String)
            _Servidor = value
        End Set
    End Property

    Public Property Seguridad As Boolean
        Get
            Return _seguridad
        End Get
        Set(value As Boolean)
            _seguridad = value
        End Set
    End Property
    Public Sub New()
        Me.Base = "dbsistemas"
        Me.Usuario = "sa"
        Me.Servidor = "LAPTOP-56VIU911"
        Me.Clave = "123456789"
        Me.conn = New SqlConnection(Crear_cadena)
    End Sub
    Public Function Crear_cadena() As String
        Dim cadena As String
        cadena = "Server= " & Me.Servidor & "; Database=" & Me.Base & ";"
        If Me.Seguridad Then
            cadena = cadena & "Integrated Security= SSPI"
        Else
            cadena = cadena & "User Id=" & Me.Usuario & "Password=" & Me.Clave
        End If
        Return cadena
    End Function
End Class
