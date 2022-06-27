<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngreso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BTNBuscar = New System.Windows.Forms.Button()
        Me.Txtvalor = New System.Windows.Forms.TextBox()
        Me.DGVListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarArticulo = New System.Windows.Forms.Button()
        Me.TxtCodigoArticulo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtTotalImpuesto = New System.Windows.Forms.TextBox()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboTipocomprobante = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarProv = New System.Windows.Forms.Button()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.TxtIdproveedor = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNInsertar = New System.Windows.Forms.Button()
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ChBSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.TabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(2, 17)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(899, 507)
        Me.TabGeneral.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BTNBuscar)
        Me.TabPage1.Controls.Add(Me.Txtvalor)
        Me.TabPage1.Controls.Add(Me.DGVListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(891, 481)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BTNBuscar
        '
        Me.BTNBuscar.Location = New System.Drawing.Point(480, 3)
        Me.BTNBuscar.Name = "BTNBuscar"
        Me.BTNBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscar.TabIndex = 2
        Me.BTNBuscar.Text = "Buscar"
        Me.BTNBuscar.UseVisualStyleBackColor = True
        '
        'Txtvalor
        '
        Me.Txtvalor.Location = New System.Drawing.Point(3, 7)
        Me.Txtvalor.Name = "Txtvalor"
        Me.Txtvalor.Size = New System.Drawing.Size(470, 20)
        Me.Txtvalor.TabIndex = 1
        '
        'DGVListado
        '
        Me.DGVListado.AllowUserToAddRows = False
        Me.DGVListado.AllowUserToDeleteRows = False
        Me.DGVListado.AllowUserToOrderColumns = True
        Me.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DGVListado.Location = New System.Drawing.Point(0, 25)
        Me.DGVListado.Name = "DGVListado"
        Me.DGVListado.ReadOnly = True
        Me.DGVListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVListado.Size = New System.Drawing.Size(891, 354)
        Me.DGVListado.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.TxtId)
        Me.TabPage2.Controls.Add(Me.BTNCancelar)
        Me.TabPage2.Controls.Add(Me.BTNInsertar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(891, 481)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnBuscarArticulo)
        Me.GroupBox2.Controls.Add(Me.TxtCodigoArticulo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.TxtTotalImpuesto)
        Me.GroupBox2.Controls.Add(Me.TxtSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DgvDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(833, 288)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'BtnBuscarArticulo
        '
        Me.BtnBuscarArticulo.Location = New System.Drawing.Point(392, 36)
        Me.BtnBuscarArticulo.Name = "BtnBuscarArticulo"
        Me.BtnBuscarArticulo.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarArticulo.TabIndex = 9
        Me.BtnBuscarArticulo.Text = "Buscar"
        Me.BtnBuscarArticulo.UseVisualStyleBackColor = True
        '
        'TxtCodigoArticulo
        '
        Me.TxtCodigoArticulo.Location = New System.Drawing.Point(83, 39)
        Me.TxtCodigoArticulo.Name = "TxtCodigoArticulo"
        Me.TxtCodigoArticulo.Size = New System.Drawing.Size(303, 20)
        Me.TxtCodigoArticulo.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-1, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Codigo Articulo"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(625, 263)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 6
        '
        'TxtTotalImpuesto
        '
        Me.TxtTotalImpuesto.Location = New System.Drawing.Point(625, 232)
        Me.TxtTotalImpuesto.Name = "TxtTotalImpuesto"
        Me.TxtTotalImpuesto.ReadOnly = True
        Me.TxtTotalImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalImpuesto.TabIndex = 5
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(625, 200)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtSubTotal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(541, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(541, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Impuesto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(541, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SubTotal"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AllowUserToAddRows = False
        Me.DgvDetalle.AllowUserToOrderColumns = True
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Location = New System.Drawing.Point(0, 65)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalle.Size = New System.Drawing.Size(825, 129)
        Me.DgvDetalle.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboTipocomprobante)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarProv)
        Me.GroupBox1.Controls.Add(Me.TxtProveedor)
        Me.GroupBox1.Controls.Add(Me.TxtIdproveedor)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtSerie)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 125)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "cabecera"
        '
        'CboTipocomprobante
        '
        Me.CboTipocomprobante.FormattingEnabled = True
        Me.CboTipocomprobante.Items.AddRange(New Object() {"Factura A", "Factura B", "Factura C", "Recibo", "Remito", "Ticket"})
        Me.CboTipocomprobante.Location = New System.Drawing.Point(83, 62)
        Me.CboTipocomprobante.Name = "CboTipocomprobante"
        Me.CboTipocomprobante.Size = New System.Drawing.Size(88, 21)
        Me.CboTipocomprobante.TabIndex = 18
        '
        'BtnBuscarProv
        '
        Me.BtnBuscarProv.Location = New System.Drawing.Point(474, 29)
        Me.BtnBuscarProv.Name = "BtnBuscarProv"
        Me.BtnBuscarProv.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarProv.TabIndex = 17
        Me.BtnBuscarProv.Text = "..."
        Me.BtnBuscarProv.UseVisualStyleBackColor = True
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Location = New System.Drawing.Point(178, 32)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.ReadOnly = True
        Me.TxtProveedor.Size = New System.Drawing.Size(289, 20)
        Me.TxtProveedor.TabIndex = 16
        '
        'TxtIdproveedor
        '
        Me.TxtIdproveedor.Location = New System.Drawing.Point(84, 33)
        Me.TxtIdproveedor.Name = "TxtIdproveedor"
        Me.TxtIdproveedor.ReadOnly = True
        Me.TxtIdproveedor.Size = New System.Drawing.Size(87, 20)
        Me.TxtIdproveedor.TabIndex = 15
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(7, 70)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(70, 13)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Comprobante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Proveedor (*)"
        '
        'TxtSerie
        '
        Me.TxtSerie.Location = New System.Drawing.Point(177, 63)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(243, 20)
        Me.TxtSerie.TabIndex = 2
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(311, 6)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 6
        Me.TxtId.Visible = False
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(336, 458)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTNCancelar.TabIndex = 5
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNInsertar
        '
        Me.BTNInsertar.Location = New System.Drawing.Point(184, 458)
        Me.BTNInsertar.Name = "BTNInsertar"
        Me.BTNInsertar.Size = New System.Drawing.Size(75, 23)
        Me.BTNInsertar.TabIndex = 4
        Me.BTNInsertar.Text = "Insertar"
        Me.BTNInsertar.UseVisualStyleBackColor = True
        '
        'LBLTotal
        '
        Me.LBLTotal.AutoSize = True
        Me.LBLTotal.Location = New System.Drawing.Point(652, 534)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(31, 13)
        Me.LBLTotal.TabIndex = 13
        Me.LBLTotal.Text = "Total"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'ChBSeleccionar
        '
        Me.ChBSeleccionar.AutoSize = True
        Me.ChBSeleccionar.Location = New System.Drawing.Point(113, 530)
        Me.ChBSeleccionar.Name = "ChBSeleccionar"
        Me.ChBSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChBSeleccionar.TabIndex = 14
        Me.ChBSeleccionar.Text = "Seleccionar"
        Me.ChBSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnAnular
        '
        Me.BtnAnular.Location = New System.Drawing.Point(317, 524)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(122, 23)
        Me.BtnAnular.TabIndex = 17
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'FrmIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 547)
        Me.Controls.Add(Me.TabGeneral)
        Me.Controls.Add(Me.LBLTotal)
        Me.Controls.Add(Me.ChBSeleccionar)
        Me.Controls.Add(Me.BtnAnular)
        Me.Name = "FrmIngreso"
        Me.Text = "Ingreso"
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BTNBuscar As Button
    Friend WithEvents Txtvalor As TextBox
    Friend WithEvents DGVListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtIdproveedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BTNCancelar As Button
    Friend WithEvents BTNInsertar As Button
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents Nombre As Label
    Friend WithEvents LBLTotal As Label
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents ChBSeleccionar As CheckBox
    Friend WithEvents BtnAnular As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CboTipocomprobante As ComboBox
    Friend WithEvents BtnBuscarProv As Button
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtTotalImpuesto As TextBox
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents BtnBuscarArticulo As Button
    Friend WithEvents TxtCodigoArticulo As TextBox
    Friend WithEvents Label5 As Label
End Class
