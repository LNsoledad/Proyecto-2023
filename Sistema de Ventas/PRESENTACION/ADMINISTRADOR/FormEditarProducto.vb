Public Class FormEditarProducto
    Private Sub PBMinim2_Click(sender As Object, e As EventArgs) Handles PBMinim2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PBCerrar2_Click(sender As Object, e As EventArgs) Handles PBCerrar2.Click
        Me.Close()
    End Sub


    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs)
        TBDescripcion.Clear()
        CBCategoria.Text = ""
        TBPrecioCosto.Clear()
        TBPrecioVenta.Clear()
        TBStock.Clear()
    End Sub


    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Dim indice As Integer

        indice = FormProductos.DGVProductos.CurrentRow.Index

        FormProductos.DGVProductos(0, indice).Value = TBDescripcion().Text
        FormProductos.DGVProductos(1, indice).Value = CBCategoria().Text
        FormProductos.DGVProductos(2, indice).Value = TBPrecioCosto().Text
        FormProductos.DGVProductos(3, indice).Value = TBPrecioVenta().Text
        FormProductos.DGVProductos(4, indice).Value = TBStock().Text
        FormProductos.DGVProductos(5, indice).Value = TBStockMinimo().Text
        FormProductos.DGVProductos(6, indice).Value = TBCBarra().Text

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

    Private Sub TBCBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCBarra.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores numéricos")
        End If
    End Sub

End Class