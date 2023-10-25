Public Class FormAgregarEmpleado
    Private Sub PBMinim2_Click(sender As Object, e As EventArgs) Handles PBMinim2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PBCerrar2_Click(sender As Object, e As EventArgs) Handles PBCerrar2.Click
        Me.Close()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        TBDniEmp.Clear()
        TBNombreEmp.Clear()
        TBApellidoEmp.Clear()

        TBTelefonoEmp.Clear()
        TBDireccionEmp.Clear()
        CBProvincia.Text = ""
        TBfechaIngEmp.Clear()
        CBTurnoEmp.Text = ""
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        FormEmpleado.DGVEmpleado.Rows.Add(TBDniEmp.Text, TBNombreEmp.Text, TBApellidoEmp.Text, TBTelefonoEmp.Text, TBDireccionEmp.Text, CBProvincia.Text, TBfechaIngEmp.Text, CBTurnoEmp.Text)

        FormEmpleado.BtnAgregar.Enabled = True
        FormEmpleado.BtnEditar.Enabled = True
        FormEmpleado.BtnEliminar.Enabled = True

        Me.Close()
    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        FormEmpleado.BtnAgregar.Enabled = True
        FormEmpleado.BtnEditar.Enabled = True
        FormEmpleado.BtnEliminar.Enabled = True

        Me.Close()
    End Sub

    '****Validaciones de Campo*****'
    'Private Sub TBDniEmp_TextChanged(sender As Object, e As EventArgs) Handles TBDniEmp.TextChanged
    Private Sub TBDniEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDniEmp.KeyPress
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

    'Private Sub TBNombreEmp_TextChanged(sender As Object, e As EventArgs) Handles TBNombreEmp.TextChanged
    'validarSoloLetras(e)
    Private Sub TBNombreEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreEmp.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar letras")
        End If
    End Sub

    'Private Sub TBApellidoEmp_TextChanged(sender As Object, e As EventArgs) Handles TBApellidoEmp.TextChanged
    Private Sub TBApellidoEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellidoEmp.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar letras")
        End If
    End Sub

    ' Private Sub TBTelefonoEmp_TextChanged(sender As Object, e As EventArgs) Handles TBTelefonoEmp.TextChanged
    'validarSoloNumeros(e)
    Private Sub TBTelefonoEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelefonoEmp.KeyPress
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

    Private Sub TBDireccionEmp_TextChanged(sender As Object, e As EventArgs) Handles TBDireccionEmp.TextChanged
        'validarNumerosYLetras1(e)
    End Sub

    Private Sub TBfechaIngEmp_TextChanged(sender As Object, e As EventArgs) Handles TBfechaIngEmp.TextChanged

    End Sub

    Private Sub TBNombreEmp_TextChanged(sender As Object, e As EventArgs) Handles TBNombreEmp.TextChanged

    End Sub
End Class