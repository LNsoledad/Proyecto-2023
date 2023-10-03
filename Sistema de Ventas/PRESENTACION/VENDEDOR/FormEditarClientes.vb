Public Class FormEditarClientes
    Private Sub PBMinim2_Click(sender As Object, e As EventArgs) Handles PBMinim2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PBCerrar2_Click(sender As Object, e As EventArgs) Handles PBCerrar2.Click
        Me.Close()
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim indice As Integer

        indice = FormClientes.DGVClientes.CurrentRow.Index

        FormClientes.DGVClientes(0, indice).Value = TBDni().Text
        FormClientes.DGVClientes(1, indice).Value = TBNombre().Text
        FormClientes.DGVClientes(2, indice).Value = TBApellido().Text
        FormClientes.DGVClientes(3, indice).Value = TBTelefono().Text
        FormClientes.DGVClientes(4, indice).Value = TBDireccion().Text
        FormClientes.DGVClientes(5, indice).Value = CBProvincia().Text
        FormClientes.DGVClientes(6, indice).Value = TBCorreo().Text
        FormClientes.DGVClientes(7, indice).Value = TBCPostal().Text

        FormClientes.BtnAgregar.Enabled = True
        FormClientes.BtnEditar.Enabled = True
        FormClientes.BtnEliminar.Enabled = True
        Me.Close()
    End Sub

End Class