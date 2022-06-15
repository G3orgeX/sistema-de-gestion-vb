Imports Sistemas.Datos
Imports Sistema.Entidades
Public Class NCategoria
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DCategoria
            Dim Tabla As DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function Buscar(valor As String) As DataTable
        Try
            Dim Datos As New DCategoria
            Dim Tabla As DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function seleccionar() As DataTable
        Try
            Dim Datos As New DCategoria
            Dim Tabla As DataTable
            Tabla = Datos.Seleccionar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function insertar(Obj As Categoria) As Boolean
        Try
            Dim Datos As New DCategoria
            Datos.insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Actualizar(Obj As Categoria) As Boolean
        Try
            Dim Datos As New DCategoria
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Eliminar(ID As Integer) As Boolean
        Try
            Dim Datos As New DCategoria
            Datos.Eliminar(ID)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Desactivar(ID As Integer) As Boolean
        Try
            Dim Datos As New DCategoria
            Datos.Desactivar(ID)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Activar(Id As Integer) As Boolean
        Try
            Dim Datos As New DCategoria
            Datos.Activar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
