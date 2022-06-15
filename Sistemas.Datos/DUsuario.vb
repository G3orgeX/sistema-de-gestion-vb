Imports Sistema.Entidades
Imports System.Data.SqlClient
Public Class DUsuario
    Inherits Conexion
    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("usuario_listar", MyBase.conn)
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
            Dim comando As New SqlCommand("Usuario_buscar", MyBase.conn)
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

    Public Function Login(Email As String, Clave As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("Usuario_login", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Email
            comando.Parameters.Add("@Clave", SqlDbType.VarChar).Value = Clave
            MyBase.conn.Open()
            Resultado = comando.ExecuteReader()
            tabla.Load(Resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Sub Insertar(Obj As Usuarios)
        Try
            Dim comando As New SqlCommand("Usuario_insertar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.Idrol
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            comando.Parameters.Add("@Tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento
            comando.Parameters.Add("@Num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento
            comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion
            comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email
            comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Obj.Clave
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub Actualizar(obj As Usuarios)
        Try
            Dim comando As New SqlCommand("Usuario_actualizar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@Idusuario", SqlDbType.Int).Value = obj.Idusuario
            comando.Parameters.Add("@idrol", SqlDbType.Int).Value = obj.Idrol
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre
            comando.Parameters.Add("@Tipo_documento", SqlDbType.VarChar).Value = obj.TipoDocumento
            comando.Parameters.Add("@Num_Documento", SqlDbType.VarChar).Value = obj.NumDocumento
            comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = obj.Direccion
            comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = obj.Telefono
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = obj.Email
            comando.Parameters.Add("@Clave", SqlDbType.VarChar).Value = obj.Clave
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub Eliminar(Id As Integer)
        Try
            Dim comando As New SqlCommand("Usuario_eliminar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Desactivar(Id As Integer)
        Try
            Dim comando As New SqlCommand("Usuario_Desactivar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Activar(Id As Integer)
        Try
            Dim comando As New SqlCommand("Usuario_Activar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
