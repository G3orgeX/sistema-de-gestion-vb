<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategoria
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
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNInsertar = New System.Windows.Forms.Button()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ChBSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActivar = New System.Windows.Forms.Button()
        Me.BtnDesactivar = New System.Windows.Forms.Button()
        Me.TabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(3, 12)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(800, 405)
        Me.TabGeneral.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BTNBuscar)
        Me.TabPage1.Controls.Add(Me.Txtvalor)
        Me.TabPage1.Controls.Add(Me.DGVListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 379)
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
        Me.DGVListado.Size = New System.Drawing.Size(792, 354)
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
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.TxtId)
        Me.TabPage2.Controls.Add(Me.BTNCancelar)
        Me.TabPage2.Controls.Add(Me.BTNInsertar)
        Me.TabPage2.Controls.Add(Me.TxtDescripcion)
        Me.TabPage2.Controls.Add(Me.TxtNombre)
        Me.TabPage2.Controls.Add(Me.Descripcion)
        Me.TabPage2.Controls.Add(Me.Nombre)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 379)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(191, 213)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 7
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(318, 11)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 6
        Me.TxtId.Visible = False
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(353, 213)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTNCancelar.TabIndex = 5
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNInsertar
        '
        Me.BTNInsertar.Location = New System.Drawing.Point(191, 213)
        Me.BTNInsertar.Name = "BTNInsertar"
        Me.BTNInsertar.Size = New System.Drawing.Size(75, 23)
        Me.BTNInsertar.TabIndex = 4
        Me.BTNInsertar.Text = "Insertar"
        Me.BTNInsertar.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(117, 133)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(311, 74)
        Me.TxtDescripcion.TabIndex = 3
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(117, 37)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(311, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Location = New System.Drawing.Point(46, 133)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.Descripcion.TabIndex = 1
        Me.Descripcion.Text = "Descripcion"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(43, 37)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(57, 13)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Nombre (*)"
        '
        'LBLTotal
        '
        Me.LBLTotal.AutoSize = True
        Me.LBLTotal.Location = New System.Drawing.Point(603, 424)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(31, 13)
        Me.LBLTotal.TabIndex = 1
        Me.LBLTotal.Text = "Total"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'ChBSeleccionar
        '
        Me.ChBSeleccionar.AutoSize = True
        Me.ChBSeleccionar.Location = New System.Drawing.Point(63, 424)
        Me.ChBSeleccionar.Name = "ChBSeleccionar"
        Me.ChBSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChBSeleccionar.TabIndex = 2
        Me.ChBSeleccionar.Text = "Seleccionar"
        Me.ChBSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(150, 420)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActivar
        '
        Me.BtnActivar.Location = New System.Drawing.Point(231, 420)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActivar.TabIndex = 4
        Me.BtnActivar.Text = "Activar"
        Me.BtnActivar.UseVisualStyleBackColor = True
        '
        'BtnDesactivar
        '
        Me.BtnDesactivar.Location = New System.Drawing.Point(312, 420)
        Me.BtnDesactivar.Name = "BtnDesactivar"
        Me.BtnDesactivar.Size = New System.Drawing.Size(75, 23)
        Me.BtnDesactivar.TabIndex = 5
        Me.BtnDesactivar.Text = "Desactivar"
        Me.BtnDesactivar.UseVisualStyleBackColor = True
        '
        'FrmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnDesactivar)
        Me.Controls.Add(Me.BtnActivar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.ChBSeleccionar)
        Me.Controls.Add(Me.LBLTotal)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmCategoria"
        Me.Text = "Categorias"
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DGVListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LBLTotal As Label
    Friend WithEvents BTNBuscar As Button
    Friend WithEvents Txtvalor As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BTNCancelar As Button
    Friend WithEvents BTNInsertar As Button
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Descripcion As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnDesactivar As Button
    Friend WithEvents BtnActivar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents ChBSeleccionar As CheckBox
End Class
