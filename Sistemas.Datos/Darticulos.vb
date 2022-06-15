Imports System.Data.SqlClient
Imports Sistema.Entidades
Public Class Darticulos
    Inherits Conexion
    Public Function Listar_articulo() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("articulo_listar", MyBase.conn)
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
    Public Function Buscar_articulo(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("Articulo_buscar", MyBase.conn)
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
    Public Sub insertar_articulo(Obj As Articulos)
        Try
            Dim comando As New SqlCommand("articulo_insertar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.Idcategoria
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion
            comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.Codigo
            comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = Obj.Precioventas 
            comando.Parameters.Add("@stock", SqlDbType.Int).Value = Obj.Stock
            comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = Obj.Imagen
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub Actualizar(obj As Articulos)
        Try
            Dim comando As New SqlCommand("articulo_actualizar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = obj.Idarticulo
            comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = obj.Idcategoria
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion
            comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = obj.Codigo
            comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = obj.Precioventas
            comando.Parameters.Add("@stock", SqlDbType.VarChar).Value = obj.Stock
            comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = obj.Imagen
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub Eliminar(Id As Integer)
        Try
            Dim comando As New SqlCommand("articulo_eliminar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Desactivar(Id As Integer)
        Try
            Dim comando As New SqlCommand("articulo_desactivar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Activar(Id As Integer)
        Try
            Dim comando As New SqlCommand("articulo_activar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
