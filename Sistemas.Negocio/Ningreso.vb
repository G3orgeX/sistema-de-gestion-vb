Imports Sistemas.Datos
Imports Sistema.Entidades
Public Class Ningreso
    Public Function Listar() As DataTable
        Try
            Dim Datos As New Dingreso
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
            Dim Datos As New Dingreso
            Dim Tabla As DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function insertar(Obj As Ingreso, det As DataTable) As Boolean
        Try
            Dim Datos As New Dingreso
            Datos.insertar(Obj, det)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Desactivar(ID As Integer) As Boolean
        Try
            Dim Datos As New Dingreso
            Datos.Anular_ingreso(ID)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
