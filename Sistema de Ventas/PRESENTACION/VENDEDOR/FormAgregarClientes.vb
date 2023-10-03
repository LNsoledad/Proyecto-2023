Public Class FormAgregarClientes
    Private Sub PBMinim2_Click(sender As Object, e As EventArgs) Handles PBMinim2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PBCerrar2_Click(sender As Object, e As EventArgs) Handles PBCerrar2.Click
        Me.Close()
    End Sub
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        TBNombre.Clear()
        TBApellido.Clear()
        TBDni.Clear()
        TBTelefono.Clear()
        TBDireccion.Clear()
        CBProvincia.Text = ""
        TBCorreo.Clear()
        TBCPostal.Clear()
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        FormClientes.DGVClientes.Rows.Add(TBDni.Text, TBNombre.Text, TBApellido.Text, TBTelefono.Text, TBDireccion.Text, CBProvincia.Text, TBCorreo.Text, TBCPostal.Text)

        FormClientes.BtnAgregar.Enabled = True
        FormClientes.BtnEditar.Enabled = True
        FormClientes.BtnEliminar.Enabled = True

        Me.Close()
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        FormClientes.BtnAgregar.Enabled = True
        FormClientes.BtnEditar.Enabled = True
        FormClientes.BtnEliminar.Enabled = True

        Me.Close()
    End Sub
    '************************** Controles de los campos *************************************

    Private Sub TBDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDni.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores numéricos")
        End If
    End Sub

    Private Sub TBNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar letras")
        End If
    End Sub

    Private Sub TBApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar letras")
        End If
    End Sub

    Private Sub TBTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores numéricos")
        End If
    End Sub

    '************************** Autocompletar Ciudad y CP *************************************

    Private Sub CBProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProvincia.SelectedIndexChanged
        If CBProvincia.Text = "3. Chaco" Then
            TBCPostal.Text = "3500"
        ElseIf CBProvincia.Text = "6. Corrientes" Then

            TBCPostal.Text = "3400"
        End If
    End Sub

End Class