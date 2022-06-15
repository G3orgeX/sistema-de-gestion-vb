Imports Sistema.Entidades
Imports System.IO
Imports Sistemas

Public Class FrmArticulo
    Private RutaOrigen As String
    Private RutaDestino As String
    Private Directorio As String = "C:\Users\D4vid\OneDrive\Escritorio\Nuevo Proyecto vb\Sismtema\"
    Private Sub FrmArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.Cargar_categoria()
    End Sub
    Private Sub Formato()
        DGVListado.Columns(0).Visible = False
        DGVListado.Columns(2).Visible = False 'idcategoria
        DGVListado.Columns(0).Width = 100 'idarticulo
        DGVListado.Columns(1).Width = 100 'idca
        DGVListado.Columns(3).Width = 100
        DGVListado.Columns(4).Width = 100
        DGVListado.Columns(5).Width = 150 'nombre
        DGVListado.Columns(6).Width = 100 'stock
        DGVListado.Columns(7).Width = 100 'estado
        DGVListado.Columns(8).Width = 200
        DGVListado.Columns(9).Width = 100
        DGVListado.Columns(10).Width = 100

        DGVListado.Columns.Item("seleccionar").Visible = False
        BtnDesactivar.Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        ChBSeleccionar.CheckState = False
    End Sub
    Private Sub Listar()
        Try
            Dim Neg As New Sistemas.Negocio.NArticulo
            DGVListado.DataSource = Neg.Listar_articulo()
            LBLTotal.Text = "Total articulos: " & DGVListado.DataSource.Rows.count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NArticulo
            Dim Valor As String
            Valor = Txtvalor.Text
            DGVListado.DataSource = Neg.Buscar_articulo(Valor)
            LBLTotal.Text = "Total Articulos Encontrados: " & DGVListado.DataSource.Rows.count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Limpiar()
        BTNInsertar.Visible = True
        BtnActualizar.Visible = False
        Txtvalor.Text = ""
        TxtId.Text = ""
        TxtCodigo.Text = ""
        TxtStock.Text = ""
        TxtPrecioventa.Text = ""
        TxtNombre.Text = ""
        TxtDescripcion.Text = ""
        TxtImagen.Text = ""
        Picimagen.Image = Nothing
        RutaOrigen = ""
    End Sub

    Private Sub Cargar_categoria()
        Try
            Dim Neg As New Negocio.NCategoria
            CboCategoria.DataSource = Neg.seleccionar
            CboCategoria.ValueMember = "idcategoria"
            CboCategoria.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BTNInsertar_Click(sender As Object, e As EventArgs) Handles BTNInsertar.Click
        Try
            If Me.ValidateChildren = True And CboCategoria.Text <> "" And TxtNombre.Text <> "" And TxtStock.Text <> "" And TxtPrecioventa.Text <> "" Then
                Dim obj As New Entidades.Articulos
                Dim neg As New Negocio.NArticulo

                obj.Idcategoria = CboCategoria.SelectedValue
                obj.Nombre = TxtNombre.Text
                obj.Codigo = TxtCodigo.Text
                obj.Precioventas = TxtPrecioventa.Text
                obj.Descripcion = TxtDescripcion.Text
                obj.Imagen = TxtImagen.Text
                If (neg.insertar_articulo(obj)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                    If (TxtImagen.Text <> "") Then
                        RutaDestino = Directorio& & TxtImagen.Text
                        File.Copy(RutaOrigen, RutaDestino)
                    Else
                        MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro incorrecto")
                    End If
                Else
                    MsgBox("Rellene por favor todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
                End If
            End If
            Me.Listar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNCancelar_Click(sender As Object, e As EventArgs) Handles BTNCancelar.Click
        Me.Limpiar()
        TabGeneral.SelectedIndex = 0
    End Sub

    Private Sub TxtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre de la categoria, este dato es obligatorio")
        End If
    End Sub
    'ingreso a la parte de ABM
    Private Sub DGVListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListado.CellDoubleClick
        Try
            TxtId.Text = DGVListado.SelectedCells.Item(1).Value
            CboCategoria.SelectedValue = DGVListado.SelectedCells.Item(2).Value
            TxtNombre.Text = DGVListado.SelectedCells.Item(5).Value
            TxtStock.Text = DGVListado.SelectedCells.Item(7).Value
            TxtPrecioventa.Text = DGVListado.SelectedCells.Item(6).Value
            TxtDescripcion.Text = DGVListado.SelectedCells.Item(8).Value
            Dim imagen As String
            imagen = DGVListado.SelectedCells.Item(9).Value
            If (imagen <> "") Then
                Picimagen.Image = Image.FromFile(Directorio & imagen)
                TxtImagen.Text = imagen
            Else
                Picimagen.Image = Nothing
                TxtImagen.Text = ""
            End If
            BTNInsertar.Visible = False
            BtnActualizar.Visible = True
            TabGeneral.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If Me.ValidateChildren = True And TxtNombre.Text <> "" And TxtId.Text <> "" Then
                Dim obj As New Entidades.Articulos
                Dim neg As New Negocio.NArticulo

                obj.Idarticulo = TxtId.Text
                obj.Idcategoria = CboCategoria.SelectedValue
                obj.Codigo = TxtCodigo.Text
                obj.Nombre = TxtNombre.Text
                obj.Precioventas = TxtPrecioventa.Text
                obj.Stock = TxtStock.Text
                obj.Imagen = TxtImagen.Text
                obj.Descripcion = TxtDescripcion.Text
                If (neg.Actualizar_articulo(obj)) Then
                    MsgBox("Se ha Actualizado correctamente", vbOKOnly + vbInformation, "Actualizacion correcta")
                    If (TxtImagen.Text <> "" And RutaOrigen <> "") Then
                        RutaDestino = Directorio & TxtImagen.Text
                        File.Copy(RutaOrigen, RutaDestino)

                        Me.Listar()
                    Else
                        MsgBox("No se ha podido Actualizar", vbOKOnly + vbCritical, "Actualizacion incorrecta")
                    End If
                Else
                    MsgBox("Rellene por favor todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ChBSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChBSeleccionar.CheckedChanged
        If ChBSeleccionar.CheckState = CheckState.Checked Then
            DGVListado.Columns.Item("seleccionar").Visible = True
            BtnEliminar.Visible = True
            BtnActivar.Visible = True
            BtnDesactivar.Visible = True
        Else
            DGVListado.Columns.Item("seleccionar").Visible = False
            BtnDesactivar.Visible = False
            BtnEliminar.Visible = False
            BtnActivar.Visible = False

        End If
    End Sub

    Private Sub DGVListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListado.CellContentClick
        If e.ColumnIndex = DGVListado.Columns.Item("seleccionar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = DGVListado.Rows(e.RowIndex).Cells("seleccionar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    'boton eliminar
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (MsgBox("Esta seguro de eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Elimiar registros") = vbYes) Then
            Try
                Dim neg As New Negocio.NArticulo
                For Each row As DataGridViewRow In DGVListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Dim img As String = Convert.ToString(row.Cells("Imagen").Value)
                        neg.Eliminar_articulo(onekey)
                        File.Delete(Directorio & img)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Boton Activar
    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        If (MsgBox("Esta seguro de Activar los Registros Seleccionados?", vbYesNo + vbQuestion, "Activar registros") = vbYes) Then
            Try
                Dim neg As New Negocio.NArticulo
                For Each row As DataGridViewRow In DGVListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        neg.Activar(onekey)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Boton Desactivar
    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        If (MsgBox("Esta seguro de Desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Desactivar registros") = vbYes) Then
            Try
                Dim neg As New Negocio.NArticulo
                For Each row As DataGridViewRow In DGVListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        neg.Desactivar_articulo(onekey)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Btncargarimagen_Click(sender As Object, e As EventArgs) Handles Btncargarimagen.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Image Files(*.jpg, *jpeg, *.jpe, *.jfif, *.png) |*.jpg; *.jpeg; *.jpe; *.jfif; *.png  "
        If file.ShowDialog() = DialogResult.OK Then
            Picimagen.Image = Image.FromFile(file.FileName)
            RutaOrigen = file.FileName
            TxtImagen.Text = file.FileName.Substring(file.FileName.LastIndexOf("\") + 1)
        End If
    End Sub


End Class