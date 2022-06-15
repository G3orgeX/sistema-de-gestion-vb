Imports Sistemas
Imports Sistemas.Negocio
Public Class Frmrol
    Private Sub Formato()
        Dgvlistado.Columns(0).Width = 100
        Dgvlistado.Columns(1).Width = 100
        Dgvlistado.Columns(0).HeaderText = "ID"
        Dgvlistado.Columns(1).HeaderText = "NOMBRE"

    End Sub
    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NRol
            Dgvlistado.DataSource = Neg.Listar()
            LblTotal.Text = "Total Registros: " & Dgvlistado.DataSource.Rows.count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Frmrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub
End Class