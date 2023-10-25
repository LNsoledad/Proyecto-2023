Public Class FormUsuario
    Dim indice As Integer

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        FormAgregarUsuario.Show()

        BtnAgregar.Enabled = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False

    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim confirmar As MsgBoxResult = MsgBox("Desea elminar este registro?", MsgBoxStyle.YesNo)
        If confirmar = MsgBoxResult.Yes Then
            DGVUsuarios.Rows.Remove(DGVUsuarios.CurrentRow)
            MsgBox("Se elimino correctamente", MsgBoxStyle.OkOnly, "Eliminar")
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        FormEditarUsuario.Show()

        FormEditarUsuario.TBDniU.Text = DGVUsuarios.CurrentRow.Cells(0).Value.ToString
        FormEditarUsuario.TBContraseniaU.Text = DGVUsuarios.CurrentRow.Cells(1).Value.ToString
        FormEditarUsuario.CBCargo.Text = DGVUsuarios.CurrentRow.Cells(2).Value.ToString
        FormEditarUsuario.TBNombreU.Text = DGVUsuarios.CurrentRow.Cells(3).Value.ToString
        FormEditarUsuario.TBApellidoU.Text = DGVUsuarios.CurrentRow.Cells(4).Value.ToString
        FormEditarUsuario.DTPFNacimiento.Text = DGVUsuarios.CurrentRow.Cells(5).Value.ToString
        FormEditarUsuario.TBTelefonoU.Text = DGVUsuarios.CurrentRow.Cells(6).Value.ToString
        FormEditarUsuario.TBDireccionU.Text = DGVUsuarios.CurrentRow.Cells(7).Value.ToString
        FormEditarUsuario.CBProvincia.Text = DGVUsuarios.CurrentRow.Cells(8).Value.ToString
        FormEditarUsuario.CBCiudad.Text = DGVUsuarios.CurrentRow.Cells(9).Value.ToString

        BtnAgregar.Enabled = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False

    End Sub

    Private Sub DGVUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUsuarios.CellContentClick


        indice = (DGVUsuarios.CurrentRow.Index)



        BtnAgregar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

End Class