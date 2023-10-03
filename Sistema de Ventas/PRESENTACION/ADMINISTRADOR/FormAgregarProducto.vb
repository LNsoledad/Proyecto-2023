Public Class FormAgregarProducto
    Private Sub PBMinim2_Click(sender As Object, e As EventArgs) Handles PBMinim2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PBCerrar2_Click(sender As Object, e As EventArgs) Handles PBCerrar2.Click
        Me.Close()
    End Sub


    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        TBDescripcion.Clear()
        CBCategoria.Text = ""
        TBPrecioCosto.Clear()
        TBPrecioVenta.Clear()
        TBStock.Clear()
        TBStockMinimo.Clear()
        TBCodigoBarra.Clear()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        FormProductos.DGVProductos.Rows.Add(TBDescripcion.Text, CBCategoria.Text, TBPrecioCosto.Text, TBPrecioVenta.Text, TBStock.Text, TBStockMinimo.Text, TBCodigoBarra.Text)

        FormProductos.BtnAgregar.Enabled = True
        FormProductos.BtnEditar.Enabled = True
        FormProductos.BtnEliminar.Enabled = True

        Me.Close()
    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        FormProductos.BtnAgregar.Enabled = True
        FormProductos.BtnEditar.Enabled = True
        FormProductos.BtnEliminar.Enabled = True

        Me.Close()
    End Sub

    '************************** Controles de los campos *************************************

    Private Sub TBDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDescripcion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar letras")
        End If
    End Sub

    Private Sub TBPrecioCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPrecioCosto.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores numéricos")
        End If
    End Sub

    Private Sub TBPrecioVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPrecioVenta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores numéricos")
        End If
    End Sub

    Private Sub TBStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBStock.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores numéricos")
        End If
    End Sub

    Private Sub TBStockMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBStockMinimo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores numéricos")
        End If
    End Sub

    Private Sub TBCodigoBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCodigoBarra.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores numéricos")
        End If
    End Sub

    Private Sub CBCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCategoria.SelectedIndexChanged

    End Sub
End Class