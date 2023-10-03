Public Class FormProductos
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        FormAgregarProducto.Show()

        BtnAgregar.Enabled = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        FormEditarProducto.Show()

        FormEditarProducto.TBDescripcion().Text = DGVProductos.CurrentRow.Cells(0).Value.ToString
        FormEditarProducto.CBCategoria().Text = DGVProductos.CurrentRow.Cells(1).Value.ToString
        FormEditarProducto.TBPrecioCosto().Text = DGVProductos.CurrentRow.Cells(2).Value.ToString
        FormEditarProducto.TBPrecioVenta().Text = DGVProductos.CurrentRow.Cells(3).Value.ToString
        FormEditarProducto.TBStock().Text = DGVProductos.CurrentRow.Cells(4).Value.ToString
        FormEditarProducto.TBStockMinimo().Text = DGVProductos.CurrentRow.Cells(5).Value.ToString
        FormEditarProducto.TBCBarra().Text = DGVProductos.CurrentRow.Cells(6).Value.ToString

        BtnAgregar.Enabled = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim confirmar As MsgBoxResult = MsgBox("Desea elminar este registro?", MsgBoxStyle.YesNo)
        If confirmar = MsgBoxResult.Yes Then
            DGVProductos.Rows.Remove(DGVProductos.CurrentRow)
            MsgBox("Se elimino correctamente", MsgBoxStyle.OkOnly, "Eliminar")
        End If
    End Sub
End Class