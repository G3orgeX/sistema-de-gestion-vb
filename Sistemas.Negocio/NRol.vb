Imports Sistemas.Datos
Public Class NRol
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DRol
            Dim Tabla As DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
