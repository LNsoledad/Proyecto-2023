Public Class FormEditarEmpleado
    Private Sub PBMinim2_Click(sender As Object, e As EventArgs) Handles PBMinim2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PBCerrar2_Click(sender As Object, e As EventArgs) Handles PBCerrar2.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim indice As Integer
        indice = FormEmpleado.DGVEmpleado.CurrentRow.Index


        FormEmpleado.DGVEmpleado(0, indice).Value = TBDniEmp().Text
        FormEmpleado.DGVEmpleado(1, indice).Value = TBNombreE().Text
        FormEmpleado.DGVEmpleado(2, indice).Value = TBApellidoE().Text
        FormEmpleado.DGVEmpleado(3, indice).Value = TBTelefonoEmp().Text
        FormEmpleado.DGVEmpleado(4, indice).Value = TBDireccionEmp().Text
        FormEmpleado.DGVEmpleado(5, indice).Value = CBProvincia().Text
        FormEmpleado.DGVEmpleado(6, indice).Value = TBfechaIngEmp().Text
        FormEmpleado.DGVEmpleado(7, indice).Value = CBTurnoEmp().Text

        FormEmpleado.BtnAgregar.Enabled = True
        FormEmpleado.BtnEditar.Enabled = True
        FormEmpleado.BtnEliminar.Enabled = True
        Me.Close()
    End Sub
    '******Validaciones de los campos*****'
    ' Private Sub TBDniEmp_TextChanged(sender As Object, e As EventArgs) Handles TBDniEmp.TextChanged
    Private Sub TBDniEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDniEmp.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores numéricos")
        End If
    End Sub

    ' Private Sub TBNombreE_TextChanged(sender As Object, e As EventArgs) Handles TBNombreE.TextChanged
    Private Sub TBNombreEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreE.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar letras")
        End If
    End Sub

    'Private Sub TBApellidoE_TextChanged(sender As Object, e As EventArgs) Handles TBApellidoE.TextChanged
    Private Sub TBApellidoEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellidoE.KeyPress
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

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        FormClientes.BtnAgregar.Enabled = True
        FormClientes.BtnEditar.Enabled = True
        FormClientes.BtnEliminar.Enabled = True

        Me.Close()
    End Sub
End Class