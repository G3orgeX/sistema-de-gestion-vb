Imports Sistemas.Datos
Imports Sistema.Entidades
Public Class NUsuario
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DUsuario
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
            Dim Datos As New DUsuario
            Dim Tabla As DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Login(Email As String, Clave As String) As Usuarios
        Try
            Dim Usuario As New Usuarios
            Dim Datos As New DUsuario
            Dim Tabla As DataTable
            Tabla = Datos.Login(Email, Clave)
            If (Tabla.Rows.Count > 0) Then
                Usuario.Idusuario = Tabla.Rows(0).Item(0).ToString
                Usuario.Idrol = Tabla.Rows(0).ItemArray(1).ToString
                Usuario.Rol = Tabla.Rows(0).Item(2).ToString
                Usuario.Nombre = Tabla.Rows(0).Item(3).ToString
                Usuario.Estado = Tabla.Rows(0).Item(4).ToString
                Return Usuario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function insertar(Obj As Usuarios) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Actualizar(Obj As Usuarios) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Eliminar(ID As Integer) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Eliminar(ID)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Desactivar(ID As Integer) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Desactivar(ID)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Activar(Id As Integer) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Activar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
