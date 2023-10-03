Public Class FormClientes
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        FormEditarClientes.Show()

        FormEditarClientes.TBDni.Text = DGVClientes.CurrentRow.Cells(0).Value.ToString
        FormEditarClientes.TBNombre.Text = DGVClientes.CurrentRow.Cells(1).Value.ToString
        FormEditarClientes.TBApellido.Text = DGVClientes.CurrentRow.Cells(2).Value.ToString
        FormEditarClientes.TBTelefono.Text = DGVClientes.CurrentRow.Cells(3).Value.ToString
        FormEditarClientes.TBDireccion.Text = DGVClientes.CurrentRow.Cells(4).Value.ToString
        FormEditarClientes.CBProvincia.Text = DGVClientes.CurrentRow.Cells(5).Value.ToString
        FormEditarClientes.TBCorreo.Text = DGVClientes.CurrentRow.Cells(6).Value.ToString
        FormEditarClientes.TBCPostal.Text = DGVClientes.CurrentRow.Cells(7).Value.ToString

        BtnAgregar.Enabled = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        FormAgregarClientes.Show()

        BtnAgregar.Enabled = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim confirmar As MsgBoxResult = MsgBox("Desea elminar este registro?", MsgBoxStyle.YesNo)
        If confirmar = MsgBoxResult.Yes Then
            DGVClientes.Rows.Remove(DGVClientes.CurrentRow)
            MsgBox("Se elimino correctamente", MsgBoxStyle.OkOnly, "Eliminar")
        End If
    End Sub
End Class