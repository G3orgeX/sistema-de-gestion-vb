Public Class Ingreso
    Private _Idingreso As Integer
    Private _Idproveedor As Integer
    Private _Idusuario As Integer
    Private _Tipocomprobante As String
    Private _Seriecomprobante As String
    Private _Numcomprobante As String
    Private _Fecha As Date
    Private _Impuesto As Decimal
    Private _Total As Decimal
    Private _Estado As Boolean

    Public Property Idingreso As Integer
        Get
            Return _Idingreso
        End Get
        Set(value As Integer)
            _Idingreso = value
        End Set
    End Property

    Public Property Idproveedor As Integer
        Get
            Return _Idproveedor
        End Get
        Set(value As Integer)
            _Idproveedor = value
        End Set
    End Property

    Public Property Idusuario As Integer
        Get
            Return _Idusuario
        End Get
        Set(value As Integer)
            _Idusuario = value
        End Set
    End Property

    Public Property Tipocomprobante As String
        Get
            Return _Tipocomprobante
        End Get
        Set(value As String)
            _Tipocomprobante = value
        End Set
    End Property

    Public Property Seriecomprobante As String
        Get
            Return _Seriecomprobante
        End Get
        Set(value As String)
            _Seriecomprobante = value
        End Set
    End Property

    Public Property Numcomprobante As String
        Get
            Return _Numcomprobante
        End Get
        Set(value As String)
            _Numcomprobante = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Impuesto As Decimal
        Get
            Return _Impuesto
        End Get
        Set(value As Decimal)
            _Impuesto = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _Total
        End Get
        Set(value As Decimal)
            _Total = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _Estado
        End Get
        Set(value As Boolean)
            _Estado = value
        End Set
    End Property
End Class
