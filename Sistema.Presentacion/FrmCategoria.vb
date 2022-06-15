Imports Sistemas
Imports Sistemas.Negocio
Public Class FrmCategoria
    Private Sub Formato()
        DGVListado.Columns(0).Visible = False
        DGVListado.Columns(0).Width = 100
        DGVListado.Columns(1).Width = 100
        DGVListado.Columns(2).Width = 150
        DGVListado.Columns(3).Width = 400
        DGVListado.Columns(4).Width = 100

        DGVListado.Columns.Item("seleccionar").Visible = False
        BtnDesactivar.Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        ChBSeleccionar.CheckState = False
    End Sub
    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NCategoria
            DGVListado.DataSource = Neg.Listar()
            LBLTotal.Text = "Total Registros: " & DGVListado.DataSource.Rows.count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NCategoria
            Dim Valor As String
            Valor = Txtvalor.Text
            DGVListado.DataSource = Neg.Buscar(Valor)
            LBLTotal.Text = "Total Registros: " & DGVListado.DataSource.Rows.count
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
        TxtNombre.Text = ""
        TxtDescripcion.Text = ""

    End Sub

    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub

    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BTNInsertar_Click(sender As Object, e As EventArgs) Handles BTNInsertar.Click
        If Me.ValidateChildren = True And TxtNombre.Text <> "" Then
            Dim obj As New Entidades.Categoria
            Dim neg As New Negocio.NCategoria

            obj.Nombre = TxtNombre.Text
            obj.Descripcion = TxtDescripcion.Text
            If (neg.insertar(obj)) Then
                MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                Me.Listar()
            Else
                MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro incorrecto")
            End If
        Else
                MsgBox("Rellene por favor todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
        End If
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
        TxtId.Text = DGVListado.SelectedCells.Item(1).Value
        TxtNombre.Text = DGVListado.SelectedCells.Item(2).Value
        TxtDescripcion.Text = DGVListado.SelectedCells.Item(3).Value
        BTNInsertar.Visible = False
        BtnActualizar.Visible = True
        TabGeneral.SelectedIndex = 1
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Me.ValidateChildren = True And TxtNombre.Text <> "" And TxtId.Text <> "" Then
            Dim obj As New Entidades.Categoria
            Dim neg As New Negocio.NCategoria

            obj.IdCategoria = TxtId.Text
            obj.Nombre = TxtNombre.Text
            obj.Descripcion = TxtDescripcion.Text
            If (neg.Actualizar(obj)) Then
                MsgBox("Se ha Actualizado correctamente", vbOKOnly + vbInformation, "Actualizacion correcta")
                Me.Listar()
                TabGeneral.SelectedIndex = 0
            Else
                MsgBox("No se ha podido Actualizar", vbOKOnly + vbCritical, "Actualizacion incorrecta")
            End If
        Else
            MsgBox("Rellene por favor todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
        End If
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
                Dim neg As New Negocio.NCategoria
                For Each row As DataGridViewRow In DGVListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        neg.Eliminar(onekey)
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
                Dim neg As New Negocio.NCategoria
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
                Dim neg As New Negocio.NCategoria
                For Each row As DataGridViewRow In DGVListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        neg.Desactivar(onekey)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class