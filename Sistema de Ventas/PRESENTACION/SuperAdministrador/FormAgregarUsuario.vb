Public Class FormAgregarUsuario
    Private Sub PBMinim2_Click(sender As Object, e As EventArgs) Handles PBMinim2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PBCerrar2_Click(sender As Object, e As EventArgs) Handles PBCerrar2.Click
        Me.Close()
    End Sub
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

        TBUsuarioDni.Clear()
        TBContrasenia.Clear()
        CBCargo.Text = ""
        TBNombre.Clear()
        TBApellido.Clear()
        DTPFNacimiento.Text = ""
        TBTelefono.Clear()
        TBDireccion.Clear()
        CBProvincia.Text = ""
        CBCiudad.Text = ""

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        FormUsuario.BtnAgregar.Enabled = True
        FormUsuario.BtnEditar.Enabled = True
        FormUsuario.BtnEliminar.Enabled = True

        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        FormUsuario.DGVUsuarios.Rows.Add(TBDniU.Text, TBContrasenia.Text, CBCargo.Text, TBNombre.Text, TBApellido.Text, DTPFNacimiento.Text, TBTelefono.Text, TBDireccion.Text, CBProvincia.Text, CBCiudad.Text)

        FormUsuario.BtnAgregar.Enabled = True
        FormUsuario.BtnEditar.Enabled = True
        FormUsuario.BtnEliminar.Enabled = True

        Me.Close()
    End Sub

    '************************** Controles de los campos *************************************

    Private Sub TBUDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDniU.KeyPress
        validarSoloNumeros(e)
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
            MsgBox("Solo se puede ingresar letras")
        End If
    End Sub

    '************************** Autocompletar Ciudad *************************************

    Private Sub CBProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProvincia.SelectedIndexChanged
        If CBProvincia.Text = "3. Chaco" Then
            CBCiudad.Text = "Resistencia"
        ElseIf CBProvincia.Text = "6. Corrientes" Then
            CBCiudad.Text = "Corrientes"
        End If
    End Sub

End Class