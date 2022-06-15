Imports System.Data.SqlClient
Public Class DRol
    Inherits Conexion
    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("rol_listar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Resultado = comando.ExecuteReader()
            tabla.Load(Resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
