Public Class FormEditarUsuario
    Private Sub PBMinim2_Click(sender As Object, e As EventArgs) Handles PBMinim2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PBCerrar2_Click(sender As Object, e As EventArgs) Handles PBCerrar2.Click
        Me.Close()
    End Sub


    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

        TBDniU.Clear()
        TBContraseniaU.Clear()
        CBCargo.Text = ""
        TBNombreU.Clear()
        TBApellidoU.Clear()
        DTPFNacimiento.Text = ""
        TBTelefonoU.Clear()
        TBDireccionU.Clear()
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

        Dim indice As Integer

        indice = FormUsuario.DGVUsuarios.CurrentRow.Index

        FormUsuario.DGVUsuarios(0, indice).Value = TBDniU().Text
        FormUsuario.DGVUsuarios(1, indice).Value = TBContraseniaU().Text
        FormUsuario.DGVUsuarios(2, indice).Value = CBCargo().Text
        FormUsuario.DGVUsuarios(3, indice).Value = TBNombreU().Text
        FormUsuario.DGVUsuarios(4, indice).Value = TBApellidoU().Text
        FormUsuario.DGVUsuarios(5, indice).Value = DTPFNacimiento().Text
        FormUsuario.DGVUsuarios(6, indice).Value = TBTelefonoU().Text
        FormUsuario.DGVUsuarios(7, indice).Value = TBDireccionU().Text
        FormUsuario.DGVUsuarios(8, indice).Value = CBProvincia().Text
        FormUsuario.DGVUsuarios(9, indice).Value = CBCiudad().Text

        FormUsuario.BtnAgregar.Enabled = True
        FormUsuario.BtnEditar.Enabled = True
        FormUsuario.BtnEliminar.Enabled = True

        Me.Close()
    End Sub





    '************************** Autocompletar Ciudad*************************************

    Private Sub CBProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProvincia.SelectedIndexChanged
        If CBProvincia.Text = "3. Chaco" Then
            CBCiudad.Text = "Resistencia"
        ElseIf CBProvincia.Text = "6. Corrientes" Then
            CBCiudad.Text = "Corrientes"
        End If
    End Sub
    '************************** Controles de los campos *************************************

    Private Sub TBDireccionU_TextChanged(sender As Object, e As EventArgs) Handles TBDireccionU.TextChanged
        'validarSoloNumeros(e)
    End Sub
    'Private Sub TBNombreU_TextChanged(sender As Object, e As EventArgs) Handles TBNombreU.TextChanged
    Private Sub TBNombreU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreU.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar letras")
        End If
    End Sub

    'Private Sub TBApellidoU_TextChanged(sender As Object, e As EventArgs) Handles TBApellidoU.TextChanged
    Private Sub TBApellidoU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellidoU.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar letras")
        End If
    End Sub

    'Private Sub TBTelefonoU_TextChanged(sender As Object, e As EventArgs) Handles TBTelefonoU.TextChanged
    Private Sub TBTelefonoU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelefonoU.KeyPress
        'validarSoloNumeros(e)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores numéricos")
        End If
    End Sub

    Private Sub CBCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCargo.SelectedIndexChanged

    End Sub

    Private Sub TBDniU_TextChanged(sender As Object, e As EventArgs) Handles TBDniU.TextChanged

    End Sub
End Class