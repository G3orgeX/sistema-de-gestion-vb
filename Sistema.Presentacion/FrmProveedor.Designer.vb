<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedor
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
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.ChBSeleccionar = New System.Windows.Forms.CheckBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumDoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboTipodoc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BTNBuscar = New System.Windows.Forms.Button()
        Me.Txtvalor = New System.Windows.Forms.TextBox()
        Me.DGVListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Labe = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Lbidcategoria = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNInsertar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(229, 425)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 21
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'LBLTotal
        '
        Me.LBLTotal.AutoSize = True
        Me.LBLTotal.Location = New System.Drawing.Point(734, 431)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(31, 13)
        Me.LBLTotal.TabIndex = 19
        Me.LBLTotal.Text = "Total"
        '
        'ChBSeleccionar
        '
        Me.ChBSeleccionar.AutoSize = True
        Me.ChBSeleccionar.Location = New System.Drawing.Point(89, 431)
        Me.ChBSeleccionar.Name = "ChBSeleccionar"
        Me.ChBSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChBSeleccionar.TabIndex = 20
        Me.ChBSeleccionar.Text = "Seleccionar"
        Me.ChBSeleccionar.UseVisualStyleBackColor = True
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(129, 281)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(184, 20)
        Me.TxtEmail.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email "
        '
        'TxtNumDoc
        '
        Me.TxtNumDoc.Location = New System.Drawing.Point(129, 141)
        Me.TxtNumDoc.Name = "TxtNumDoc"
        Me.TxtNumDoc.Size = New System.Drawing.Size(184, 20)
        Me.TxtNumDoc.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Numero Documento"
        '
        'CboTipodoc
        '
        Me.CboTipodoc.FormattingEnabled = True
        Me.CboTipodoc.Items.AddRange(New Object() {"Pasaporte", "Libreta Civica", "Cedula ", "Carnet", "DNI", "CUIT"})
        Me.CboTipodoc.Location = New System.Drawing.Point(129, 96)
        Me.CboTipodoc.Name = "CboTipodoc"
        Me.CboTipodoc.Size = New System.Drawing.Size(130, 21)
        Me.CboTipodoc.TabIndex = 21
        Me.CboTipodoc.Text = "DNI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Tipo Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Telefono"
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(0, 2)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(913, 405)
        Me.TabGeneral.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BTNBuscar)
        Me.TabPage1.Controls.Add(Me.Txtvalor)
        Me.TabPage1.Controls.Add(Me.DGVListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(905, 379)
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
        Me.Txtvalor.Location = New System.Drawing.Point(0, 5)
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
        Me.DGVListado.Size = New System.Drawing.Size(905, 354)
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
        Me.TabPage2.Controls.Add(Me.TxtEmail)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.TxtNumDoc)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.CboTipodoc)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Labe)
        Me.TabPage2.Controls.Add(Me.TxtTelefono)
        Me.TabPage2.Controls.Add(Me.TxtDireccion)
        Me.TabPage2.Controls.Add(Me.Lbidcategoria)
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.TxtId)
        Me.TabPage2.Controls.Add(Me.BTNCancelar)
        Me.TabPage2.Controls.Add(Me.BTNInsertar)
        Me.TabPage2.Controls.Add(Me.TxtNombre)
        Me.TabPage2.Controls.Add(Me.Nombre)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(905, 379)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Labe
        '
        Me.Labe.AutoSize = True
        Me.Labe.Location = New System.Drawing.Point(22, 194)
        Me.Labe.Name = "Labe"
        Me.Labe.Size = New System.Drawing.Size(55, 13)
        Me.Labe.TabIndex = 18
        Me.Labe.Text = "Direccion "
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(129, 231)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(130, 20)
        Me.TxtTelefono.TabIndex = 17
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(129, 187)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(184, 20)
        Me.TxtDireccion.TabIndex = 16
        '
        'Lbidcategoria
        '
        Me.Lbidcategoria.AutoSize = True
        Me.Lbidcategoria.Location = New System.Drawing.Point(14, 46)
        Me.Lbidcategoria.Name = "Lbidcategoria"
        Me.Lbidcategoria.Size = New System.Drawing.Size(0, 13)
        Me.Lbidcategoria.TabIndex = 9
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(148, 341)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 7
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(306, 24)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 6
        Me.TxtId.Visible = False
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(229, 341)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTNCancelar.TabIndex = 5
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNInsertar
        '
        Me.BTNInsertar.Location = New System.Drawing.Point(148, 341)
        Me.BTNInsertar.Name = "BTNInsertar"
        Me.BTNInsertar.Size = New System.Drawing.Size(75, 23)
        Me.BTNInsertar.TabIndex = 4
        Me.BTNInsertar.Text = "Insertar"
        Me.BTNInsertar.UseVisualStyleBackColor = True
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(129, 50)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(243, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(22, 57)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(57, 13)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Nombre (*)"
        '
        'FrmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(913, 469)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.LBLTotal)
        Me.Controls.Add(Me.ChBSeleccionar)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmProveedor"
        Me.Text = "Proveedores"
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEliminar As Button
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents LBLTotal As Label
    Friend WithEvents ChBSeleccionar As CheckBox
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BTNBuscar As Button
    Friend WithEvents Txtvalor As TextBox
    Friend WithEvents DGVListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumDoc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CboTipodoc As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Labe As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Lbidcategoria As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BTNCancelar As Button
    Friend WithEvents BTNInsertar As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Nombre As Label
End Class
