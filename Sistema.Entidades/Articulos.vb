Imports System.sql.data.client
Public Class Articulos
    'propiedades de articulo
    Private _Idarticulo As Integer
    Private _Idcategoria As Integer
    Private _Nombre As String
    Private _Descripcion As String
    Private _Precioventas As Decimal
    Private _Stock As Integer
    Private _Imagen As String
    Private _Codigo As String
    Private _Estado As Boolean

    Public Property Idarticulo As Integer
        Get
            Return _Idarticulo
        End Get
        Set(value As Integer)
            _Idarticulo = value
        End Set
    End Property

    Public Property Idcategoria As Integer
        Get
            Return _Idcategoria
        End Get
        Set(value As Integer)
            _Idcategoria = value
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

    Public Property Precioventas As Decimal
        Get
            Return _Precioventas
        End Get
        Set(value As Decimal)
            _Precioventas = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _Stock
        End Get
        Set(value As Integer)
            _Stock = value
        End Set
    End Property


    Public Property Imagen As String
        Get
            Return _Imagen
        End Get
        Set(value As String)
            _Imagen = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
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

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property
End Class
