Imports Sistema.Entidades
Imports System.Data.SqlClient
Public Class Dingreso
    Inherits Conexion
    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("ingreso_listar", MyBase.conn)
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
            Dim comando As New SqlCommand("ingreso_buscar", MyBase.conn)
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
    Public Sub Anular_ingreso(Id As Integer)
        Try
            Dim comando As New SqlCommand("ingreso_anular", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idingreso", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub insertar(Obj As Ingreso, Det As DataTable)
        Try
            Dim comando As New SqlCommand("ingreso_insertar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idingreso", SqlDbType.Int).Value = Obj.Idingreso
            comando.Parameters("@idingreso").Direction = ParameterDirection.Output
            comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Obj.Idusuario
            comando.Parameters.Add("@idproveedor", SqlDbType.Int).Value = Obj.Idproveedor
            comando.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = Obj.Tipocomprobante
            comando.Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = Obj.Seriecomprobante
            comando.Parameters.Add("@num_comprobante", SqlDbType.VarChar).Value = Obj.Numcomprobante
            comando.Parameters.Add("@impuesto", SqlDbType.Decimal).Value = Obj.Impuesto
            comando.Parameters.Add("@total", SqlDbType.Decimal).Value = Obj.Total
            comando.Parameters.Add("@detalle", SqlDbType.Structured).Value = Det

            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class
