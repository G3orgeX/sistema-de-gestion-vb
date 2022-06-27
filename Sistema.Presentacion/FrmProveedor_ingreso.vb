Imports Sistemas
Public Class FrmProveedor_ingreso
    Private Sub FrmProveedor_ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub
    Private Sub Formato()
        DGVListado.Columns(0).Visible = False
        DGVListado.Columns(0).Width = 100 'casilla seleccionar
        DGVListado.Columns(1).Width = 80 'id persona
        DGVListado.Columns(2).Width = 120 'tipopersona
        DGVListado.Columns(3).Width = 120 'nombre
        DGVListado.Columns(4).Width = 100 'tipo doc
        DGVListado.Columns(5).Width = 120 'num doc
        DGVListado.Columns(6).Width = 100 'domicilio
        DGVListado.Columns(7).Width = 100 'telefono
        DGVListado.Columns(8).Width = 120 'email

        DGVListado.Columns.Item("seleccionar").Visible = False
    End Sub
    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NPersona
            DGVListado.DataSource = Neg.Listar_Proveedores()
            LBLTotal.Text = "Total Registros: " & DGVListado.DataSource.Rows.count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NPersona
            Dim Valor As String
            Valor = Txtvalor.Text
            DGVListado.DataSource = Neg.Buscar_Proveedores(Valor)
            LBLTotal.Text = "Total registros Encontrados: " & DGVListado.DataSource.Rows.count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub DGVListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListado.CellDoubleClick
        Variables_Provedor.IdProveedor = DGVListado.SelectedCells.Item(1).Value
        Variables_Provedor.Nombre_Proveedor = DGVListado.SelectedCells.Item(3).Value
        Me.Close()
    End Sub
End Class