Imports Sistema.Entidades
Imports Sistemas
Public Class FrmUsuario
    Private Sub Formato()
        DGVListado.Columns(0).Visible = False
        DGVListado.Columns(2).Visible = False '
        DGVListado.Columns(0).Width = 100 'idusuario
        DGVListado.Columns(1).Width = 80 'idrol
        DGVListado.Columns(3).Width = 120 'rol.nombre
        DGVListado.Columns(4).Width = 120 'nombre
        DGVListado.Columns(5).Width = 100 'tipo doc
        DGVListado.Columns(6).Width = 100 'num doc
        DGVListado.Columns(7).Width = 120 'domicilio
        DGVListado.Columns(8).Width = 100 'telefono
        DGVListado.Columns(9).Width = 120 'email
        DGVListado.Columns(10).Width = 100 'estado

        DGVListado.Columns.Item("seleccionar").Visible = False
        BtnDesactivar.Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        ChBSeleccionar.CheckState = False
    End Sub
    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NUsuario
            DGVListado.DataSource = Neg.Listar()
            LBLTotal.Text = "Total usuarios: " & DGVListado.DataSource.Rows.count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NUsuario
            Dim Valor As String
            Valor = Txtvalor.Text
            DGVListado.DataSource = Neg.Buscar(Valor)
            LBLTotal.Text = "Total usuarios Encontrados: " & DGVListado.DataSource.Rows.count
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
        TxtNumDoc.Text = ""
        TxtDireccion.Text = ""
        TxtTelefono.Text = ""
        TxtNombre.Text = ""
        TxtClave.Text = ""
        TxtEmail.Text = ""
    End Sub

    Private Sub Cargar_rol()
        Try
            Dim Neg As New Negocio.NRol
            CboRol.DataSource = Neg.Listar
            CboRol.ValueMember = "idrol"
            CboRol.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.Cargar_rol()
    End Sub

    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BTNInsertar_Click(sender As Object, e As EventArgs) Handles BTNInsertar.Click
        Try
            If Me.ValidateChildren = True And CboRol.Text <> "" And TxtNombre.Text <> "" And TxtEmail.Text <> "" And TxtClave.Text <> "" Then
                Dim obj As New Entidades.Usuarios
                Dim neg As New Negocio.NUsuario

                obj.Idrol = CboRol.SelectedValue
                obj.Nombre = TxtNombre.Text
                obj.TipoDocumento = CboTipodoc.Text
                obj.NumDocumento = TxtNumDoc.Text
                obj.Direccion = TxtDireccion.Text
                obj.Telefono = TxtTelefono.Text
                obj.Email = TxtEmail.Text
                obj.Clave = TxtClave.Text
                If (neg.insertar(obj)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                Else
                    MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro incorrecto")
                End If
            Else
                MsgBox("Rellene por favor todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
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

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If Me.ValidateChildren = True And CboRol.Text <> "" And TxtNombre.Text <> "" And TxtEmail.Text <> "" Then
                Dim obj As New Entidades.Usuarios
                Dim neg As New Negocio.NUsuario

                obj.Idusuario = TxtId.Text
                obj.Idrol = CboRol.SelectedValue
                obj.Nombre = TxtNombre.Text
                obj.TipoDocumento = CboTipodoc.Text
                obj.NumDocumento = TxtNumDoc.Text
                obj.Direccion = TxtDireccion.Text
                obj.Telefono = TxtTelefono.Text
                obj.Email = TxtEmail.Text
                obj.Clave = TxtClave.Text
                If (neg.Actualizar(obj)) Then
                    MsgBox("Se ha actualizado correctamente", vbOKOnly + vbInformation, "Actualizacion correcta")
                Else
                    MsgBox("No se ha podido Actualizar", vbOKOnly + vbCritical, "Actualizacion incorrecta")
                End If
            Else
                MsgBox("Rellene por favor todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
            End If
            Me.Listar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGVListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListado.CellDoubleClick
        Try
            TxtId.Text = DGVListado.SelectedCells(1).Value
            CboRol.SelectedValue = DGVListado.SelectedCells(2).Value
            TxtNombre.Text = DGVListado.SelectedCells(4).Value
            CboTipodoc.Text = DGVListado.SelectedCells(5).Value
            TxtNumDoc.Text = DGVListado.SelectedCells(6).Value
            TxtDireccion.Text = DGVListado.SelectedCells(7).Value
            TxtTelefono.Text = DGVListado.SelectedCells(8).Value
            TxtEmail.Text = DGVListado.SelectedCells(9).Value

            BTNInsertar.Visible = False
            BtnActualizar.Visible = True
            TabGeneral.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGVListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListado.CellContentClick
        If e.ColumnIndex = DGVListado.Columns.Item("seleccionar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = DGVListado.Rows(e.RowIndex).Cells("seleccionar")
            chkcell.Value = Not chkcell.Value
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

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (MsgBox("Esta seguro de eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Elimiar registros") = vbYes) Then
            Try
                Dim neg As New Negocio.NUsuario
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

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        If (MsgBox("Esta seguro de Activar los Registros Seleccionados?", vbYesNo + vbQuestion, "Activar registros") = vbYes) Then
            Try
                Dim neg As New Negocio.NUsuario
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

    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        If (MsgBox("Esta seguro de Desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Desactivar registros") = vbYes) Then
            Try
                Dim neg As New Negocio.NUsuario
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