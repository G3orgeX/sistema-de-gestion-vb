Imports Sistemas
Public Class FrmIngreso
    Private Dt_Detalle As DataTable
    Private Sub FrmIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.Crear_tabla_detalle()
    End Sub
    Private Sub Formato()
        DGVListado.Columns(0).Visible = False
        DGVListado.Columns(2).Visible = False 'idcategoria
        DGVListado.Columns(0).Width = 100 'idarticulo
        DGVListado.Columns(1).Width = 60 'idca
        DGVListado.Columns(3).Width = 150
        DGVListado.Columns(4).Width = 150
        DGVListado.Columns(5).Width = 100 'nombre
        DGVListado.Columns(6).Width = 70 'stock
        DGVListado.Columns(7).Width = 70 'estado
        DGVListado.Columns(8).Width = 60
        DGVListado.Columns(9).Width = 100
        DGVListado.Columns(10).Width = 100
        DGVListado.Columns(11).Width = 100

        DGVListado.Columns.Item("seleccionar").Visible = False
        BtnAnular.Visible = False
        ChBSeleccionar.CheckState = False
    End Sub
    Private Sub Listar()
        Try
            Dim Neg As New Negocio.Ningreso
            DGVListado.DataSource = Neg.Listar()
            LBLTotal.Text = "Total articulos: " & DGVListado.DataSource.Rows.count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.Ningreso
            Dim Valor As String
            Valor = Txtvalor.Text
            DGVListado.DataSource = Neg.Buscar(Valor)
            LBLTotal.Text = "Total Articulos Encontrados: " & DGVListado.DataSource.Rows.count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Limpiar()
        BTNInsertar.Visible = True
        Txtvalor.Text = ""
        TxtId.Text = ""
        TxtIdproveedor.Text = ""
        TxtSerie.Text = ""
    End Sub
    Private Sub Crear_tabla_detalle()
        Me.Dt_Detalle = New DataTable("Detalle")
        Me.Dt_Detalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"))
        Me.Dt_Detalle.Columns.Add("codigo", System.Type.GetType("System.String"))
        Me.Dt_Detalle.Columns.Add("articulo", System.Type.GetType("System.String"))
        Me.Dt_Detalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"))
        Me.Dt_Detalle.Columns.Add("precio", System.Type.GetType("System.Decimal"))
        Me.Dt_Detalle.Columns.Add("importe", System.Type.GetType("System.Decimal"))
        DgvDetalle.DataSource = Me.Dt_Detalle
        DgvDetalle.Columns(0).Visible = False
        DgvDetalle.Columns(1).HeaderText = "Codigo"
        DgvDetalle.Columns(1).Width = 100
        DgvDetalle.Columns(2).HeaderText = "Articulo"
        DgvDetalle.Columns(2).Width = 200
        DgvDetalle.Columns(3).HeaderText = "CANTIDAD"
        DgvDetalle.Columns(3).Width = 100
        DgvDetalle.Columns(4).HeaderText = "PRECIO"
        DgvDetalle.Columns(4).Width = 100
        DgvDetalle.Columns(5).HeaderText = "IMPORTE"
        DgvDetalle.Columns(5).Width = 100

        DgvDetalle.Columns(1).ReadOnly = True
        DgvDetalle.Columns(2).ReadOnly = True
        DgvDetalle.Columns(5).ReadOnly = True
    End Sub
    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnBuscarProv_Click(sender As Object, e As EventArgs) Handles BtnBuscarProv.Click
        FrmProveedor_ingreso.ShowDialog()
        TxtIdproveedor.Text = Variables_Provedor.IdProveedor
        TxtProveedor.Text = Variables_Provedor.Nombre_Proveedor
    End Sub
End Class
