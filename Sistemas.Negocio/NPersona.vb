Imports Sistema.Entidades
Imports Sistemas.Datos
Public Class NPersona
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DPersona
            Dim Tabla As DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Listar_Proveedores() As DataTable
        Try
            Dim Datos As New DPersona
            Dim Tabla As DataTable
            Tabla = Datos.Listar_Proveedores()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function Listar_clientes() As DataTable
        Try
            Dim Datos As New DPersona
            Dim Tabla As DataTable
            Tabla = Datos.Listar_Clientes()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function Buscar(valor As String) As DataTable
        Try
            Dim Datos As New DPersona
            Dim Tabla As DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar_Clientes(valor As String) As DataTable
        Try
            Dim Datos As New DPersona
            Dim Tabla As DataTable
            Tabla = Datos.Buscar_Clientes(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar_Proveedores(valor As String) As DataTable
        Try
            Dim Datos As New DPersona
            Dim Tabla As DataTable
            Tabla = Datos.Buscar_Proveedores(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function insertar(Obj As Personas) As Boolean
        Try
            Dim Datos As New DPersona
            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Actualizar(Obj As Personas) As Boolean
        Try
            Dim Datos As New DPersona
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Eliminar(ID As Integer) As Boolean
        Try
            Dim Datos As New DPersona
            Datos.Eliminar(ID)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
