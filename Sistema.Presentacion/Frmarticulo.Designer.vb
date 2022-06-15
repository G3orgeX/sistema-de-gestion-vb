<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulo
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
        Me.BtnDesactivar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.ChBSeleccionar = New System.Windows.Forms.CheckBox()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnActivar = New System.Windows.Forms.Button()
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNInsertar = New System.Windows.Forms.Button()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.BTNBuscar = New System.Windows.Forms.Button()
        Me.Txtvalor = New System.Windows.Forms.TextBox()
        Me.DGVListado = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPrecioventa = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btncargarimagen = New System.Windows.Forms.Button()
        Me.TxtImagen = New System.Windows.Forms.TextBox()
        Me.Picimagen = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbidcategoria = New System.Windows.Forms.Label()
        Me.CboCategoria = New System.Windows.Forms.ComboBox()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Picimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnDesactivar
        '
        Me.BtnDesactivar.Location = New System.Drawing.Point(309, 418)
        Me.BtnDesactivar.Name = "BtnDesactivar"
        Me.BtnDesactivar.Size = New System.Drawing.Size(75, 23)
        Me.BtnDesactivar.TabIndex = 11
        Me.BtnDesactivar.Text = "Desactivar"
        Me.BtnDesactivar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(147, 418)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 9
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'ChBSeleccionar
        '
        Me.ChBSeleccionar.AutoSize = True
        Me.ChBSeleccionar.Location = New System.Drawing.Point(60, 422)
        Me.ChBSeleccionar.Name = "ChBSeleccionar"
        Me.ChBSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChBSeleccionar.TabIndex = 8
        Me.ChBSeleccionar.Text = "Seleccionar"
        Me.ChBSeleccionar.UseVisualStyleBackColor = True
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'BtnActivar
        '
        Me.BtnActivar.Location = New System.Drawing.Point(228, 418)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActivar.TabIndex = 10
        Me.BtnActivar.Text = "Activar"
        Me.BtnActivar.UseVisualStyleBackColor = True
        '
        'LBLTotal
        '
        Me.LBLTotal.AutoSize = True
        Me.LBLTotal.Location = New System.Drawing.Point(600, 422)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(31, 13)
        Me.LBLTotal.TabIndex = 7
        Me.LBLTotal.Text = "Total"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(47, 350)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 7
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(304, 46)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 6
        Me.TxtId.Visible = False
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(224, 353)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTNCancelar.TabIndex = 5
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNInsertar
        '
        Me.BTNInsertar.Location = New System.Drawing.Point(143, 350)
        Me.BTNInsertar.Name = "BTNInsertar"
        Me.BTNInsertar.Size = New System.Drawing.Size(75, 23)
        Me.BTNInsertar.TabIndex = 4
        Me.BTNInsertar.Text = "Insertar"
        Me.BTNInsertar.UseVisualStyleBackColor = True
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(115, 208)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(290, 127)
        Me.TxtDescripcion.TabIndex = 3
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(115, 112)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(243, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Location = New System.Drawing.Point(39, 210)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.Descripcion.TabIndex = 1
        Me.Descripcion.Text = "Descripcion"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(38, 115)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(57, 13)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Nombre (*)"
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TxtPrecioventa)
        Me.TabPage2.Controls.Add(Me.TxtStock)
        Me.TabPage2.Controls.Add(Me.TxtCodigo)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Btncargarimagen)
        Me.TabPage2.Controls.Add(Me.TxtImagen)
        Me.TabPage2.Controls.Add(Me.Picimagen)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Lbidcategoria)
        Me.TabPage2.Controls.Add(Me.CboCategoria)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Precio venta (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Stock (*)"
        '
        'TxtPrecioventa
        '
        Me.TxtPrecioventa.Location = New System.Drawing.Point(115, 182)
        Me.TxtPrecioventa.Name = "TxtPrecioventa"
        Me.TxtPrecioventa.Size = New System.Drawing.Size(184, 20)
        Me.TxtPrecioventa.TabIndex = 17
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(115, 148)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(184, 20)
        Me.TxtStock.TabIndex = 16
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(115, 78)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(243, 20)
        Me.TxtCodigo.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Codigo"
        '
        'Btncargarimagen
        '
        Me.Btncargarimagen.Location = New System.Drawing.Point(679, 47)
        Me.Btncargarimagen.Name = "Btncargarimagen"
        Me.Btncargarimagen.Size = New System.Drawing.Size(75, 23)
        Me.Btncargarimagen.TabIndex = 13
        Me.Btncargarimagen.Text = "..."
        Me.Btncargarimagen.UseVisualStyleBackColor = True
        '
        'TxtImagen
        '
        Me.TxtImagen.Enabled = False
        Me.TxtImagen.Location = New System.Drawing.Point(497, 49)
        Me.TxtImagen.Name = "TxtImagen"
        Me.TxtImagen.Size = New System.Drawing.Size(176, 20)
        Me.TxtImagen.TabIndex = 12
        '
        'Picimagen
        '
        Me.Picimagen.Location = New System.Drawing.Point(455, 126)
        Me.Picimagen.Name = "Picimagen"
        Me.Picimagen.Size = New System.Drawing.Size(283, 127)
        Me.Picimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picimagen.TabIndex = 11
        Me.Picimagen.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(452, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Imagen"
        '
        'Lbidcategoria
        '
        Me.Lbidcategoria.AutoSize = True
        Me.Lbidcategoria.Location = New System.Drawing.Point(37, 49)
        Me.Lbidcategoria.Name = "Lbidcategoria"
        Me.Lbidcategoria.Size = New System.Drawing.Size(62, 13)
        Me.Lbidcategoria.TabIndex = 9
        Me.Lbidcategoria.Text = "Categoria(*)"
        '
        'CboCategoria
        '
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.Location = New System.Drawing.Point(114, 46)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(179, 21)
        Me.CboCategoria.TabIndex = 8
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(0, 10)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(800, 405)
        Me.TabGeneral.TabIndex = 6
        '
        'FrmArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnDesactivar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.ChBSeleccionar)
        Me.Controls.Add(Me.BtnActivar)
        Me.Controls.Add(Me.LBLTotal)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmArticulo"
        Me.Text = "Articulos"
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Picimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGeneral.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDesactivar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents ChBSeleccionar As CheckBox
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents BtnActivar As Button
    Friend WithEvents LBLTotal As Label
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BTNBuscar As Button
    Friend WithEvents Txtvalor As TextBox
    Friend WithEvents DGVListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BTNCancelar As Button
    Friend WithEvents BTNInsertar As Button
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Descripcion As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents Lbidcategoria As Label
    Friend WithEvents CboCategoria As ComboBox
    Friend WithEvents Btncargarimagen As Button
    Friend WithEvents TxtImagen As TextBox
    Friend WithEvents Picimagen As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPrecioventa As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label2 As Label
End Class
