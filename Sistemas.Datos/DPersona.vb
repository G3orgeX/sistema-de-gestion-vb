Imports Sistema.Entidades
Imports System.Data.SqlClient
Public Class DPersona
    Inherits Conexion
    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("Persona_Listar", MyBase.conn)
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
    'listar Proveedores 
    Public Function Listar_Proveedores() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("Persona_listar_Proveedores", MyBase.conn)
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

    'Listar CLIENTES 

    Public Function Listar_Clientes() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("Persona_listar_Clientes", MyBase.conn)
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
            Dim comando As New SqlCommand("Persona_Buscar", MyBase.conn)
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

    'BUSCAR CLIENTES
    Public Function Buscar_Clientes(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("Persona_Buscar_Clientes", MyBase.conn)
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

    'Buscar PROVEEDORES 
    Public Function Buscar_Proveedores(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("Persona_Buscar_Proveedores", MyBase.conn)
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

    'INSERTAR PERSONAS
    Public Sub Insertar(Obj As Personas)
        Try
            Dim comando As New SqlCommand("Persona_insertar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = Obj.TipoPersona
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            comando.Parameters.Add("@Tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento
            comando.Parameters.Add("@Num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento
            comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion
            comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub Eliminar(Id As Integer)
        Try
            Dim comando As New SqlCommand("Persona_Eliminar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idpersona", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Actualizar(obj As Personas)
        Try
            Dim comando As New SqlCommand("Persona_Actualizar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@Idpersona", SqlDbType.Int).Value = obj.IdPersona
            comando.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = obj.TipoPersona
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre
            comando.Parameters.Add("@Tipo_documento", SqlDbType.VarChar).Value = obj.TipoDocumento
            comando.Parameters.Add("@Num_Documento", SqlDbType.VarChar).Value = obj.NumDocumento
            comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = obj.Direccion
            comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = obj.Telefono
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = obj.Email
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class
