Public Class FormEmpleado
    Private Sub FormEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        FormEditarEmpleado.Show()

        FormEditarEmpleado.TBDniEmp.Text = DGVEmpleado.CurrentRow.Cells(0).Value.ToString
        FormEditarEmpleado.TBNombreE.Text = DGVEmpleado.CurrentRow.Cells(1).Value.ToString
        FormEditarEmpleado.TBApellidoE.Text = DGVEmpleado.CurrentRow.Cells(2).Value.ToString
        FormEditarEmpleado.TBTelefonoEmp.Text = DGVEmpleado.CurrentRow.Cells(3).Value.ToString
        FormEditarEmpleado.TBDireccionEmp.Text = DGVEmpleado.CurrentRow.Cells(4).Value.ToString
        FormEditarEmpleado.CBProvincia.Text = DGVEmpleado.CurrentRow.Cells(5).Value.ToString
        FormEditarEmpleado.TBfechaIngEmp.Text = DGVEmpleado.CurrentRow.Cells(6).Value.ToString
        FormEditarEmpleado.CBTurnoEmp.Text = DGVEmpleado.CurrentRow.Cells(7).Value.ToString

        BtnAgregar.Enabled = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        FormAgregarEmpleado.Show()

        BtnAgregar.Enabled = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim confirmar As MsgBoxResult = MsgBox("Desea elminar este registro?", MsgBoxStyle.YesNo)
        If confirmar = MsgBoxResult.Yes Then
            DGVEmpleado.Rows.Remove(DGVEmpleado.CurrentRow)
            MsgBox("Se elimino correctamente", MsgBoxStyle.OkOnly, "Eliminar")
        End If
    End Sub


End Class