Imports Sistemas
Public Class FrmLogin
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        End
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            Dim Email As String
            Dim Clave As String
            Dim obj As New Entidades.Usuarios
            Dim neg As New Negocio.NUsuario
            Email = TxtEmail.Text.Trim()
            Clave = TxtClave.Text.Trim()
            obj = neg.Login(Email, Clave)
            If (obj Is Nothing) Then
                MsgBox("No Existe ningun usuario con ese Email o clave", vbOKOnly + vbCritical, "Datos Incorrectos")
            Else
                If (obj.Estado = False) Then
                    MsgBox("El Usuario No esta Activo", vbOKOnly + vbCritical, "Usuario no tiene acceso")
                Else
                    Me.Hide()
                    FrmPrincipal.IdUsuario = obj.Idusuario
                    FrmPrincipal.IdRol = obj.Idrol
                    FrmPrincipal.Rol = obj.Rol
                    FrmPrincipal.Nombre = obj.Nombre
                    FrmPrincipal.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class