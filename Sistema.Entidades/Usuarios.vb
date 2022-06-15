Public Class Usuarios
    Private _Idusuario As Integer
    Private _Idrol As Integer
    Private _Nombre As String
    Private _TipoDocumento As String
    Private _NumDocumento As String
    Private _Direccion As String
    Private _Telefono As String
    Private _Email As String
    Private _clave As String
    Private _estado As Boolean
    Private _Rol As String

    Public Property Idusuario As Integer
        Get
            Return _Idusuario
        End Get
        Set(value As Integer)
            _Idusuario = value
        End Set
    End Property

    Public Property Idrol As Integer
        Get
            Return _Idrol
        End Get
        Set(value As Integer)
            _Idrol = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property TipoDocumento As String
        Get
            Return _TipoDocumento
        End Get
        Set(value As String)
            _TipoDocumento = value
        End Set
    End Property

    Public Property NumDocumento As String
        Get
            Return _NumDocumento
        End Get
        Set(value As String)
            _NumDocumento = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _clave
        End Get
        Set(value As String)
            _clave = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property
    Public Property Rol As String
        Get
            Return _Rol
        End Get
        Set(value As String)
            _Rol = value
        End Set
    End Property
End Class
