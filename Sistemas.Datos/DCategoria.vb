Imports Sistema.Entidades
Imports System.Data.SqlClient
Public Class DCategoria
    Inherits Conexion

    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("categoria_listar", MyBase.conn)
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
    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("buscar_categoria", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
            MyBase.conn.Open()
            Resultado = comando.ExecuteReader()
            tabla.Load(Resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Seleccionar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("categoria_seleccionar", MyBase.conn)
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
    Public Sub insertar(Obj As Categoria)
        Try
            Dim comando As New SqlCommand("categoria_insertar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub Actualizar(obj As Categoria)
        Try
            Dim comando As New SqlCommand("categoria_actualizar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = obj.IdCategoria
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub Eliminar(Id As Integer)
        Try
            Dim comando As New SqlCommand("categoria_eliminar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Desactivar(Id As Integer)
        Try
            Dim comando As New SqlCommand("categoria_desac", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Activar(Id As Integer)
        Try
            Dim comando As New SqlCommand("categoria_activa", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
