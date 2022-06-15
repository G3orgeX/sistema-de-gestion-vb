Imports Sistemas.Datos
Imports Sistema.Entidades
Public Class NArticulo
    Public Function Listar_articulo() As DataTable
        Try
            Dim Datos As New Darticulos
            Dim Tabla As DataTable
            Tabla = Datos.Listar_articulo()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function Buscar_articulo(valor As String) As DataTable
        Try
            Dim Datos As New Darticulos
            Dim Tabla As DataTable
            Tabla = Datos.Buscar_articulo(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function insertar_articulo(Obj As Articulos) As Boolean
        Try
            Dim Datos As New Darticulos
            Datos.insertar_articulo(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Actualizar_articulo(Obj As Articulos) As Boolean
        Try
            Dim Datos As New Darticulos
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Eliminar_articulo(ID As Integer) As Boolean
        Try
            Dim Datos As New Darticulos
            Datos.Eliminar(ID)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Desactivar_articulo(ID As Integer) As Boolean
        Try
            Dim Datos As New Darticulos
            Datos.Desactivar(ID)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Activar(Id As Integer) As Boolean
        Try
            Dim Datos As New Darticulos
            Datos.Activar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
