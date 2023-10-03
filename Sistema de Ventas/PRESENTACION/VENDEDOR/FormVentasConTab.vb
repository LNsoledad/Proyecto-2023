Public Class FormVentasConTab
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs)
        FormEditarClientes.Show()

        FormEditarClientes.TBNombre.Text = DGVVenta.CurrentRow.Cells(0).Value.ToString
        FormEditarClientes.TBApellido.Text = DGVVenta.CurrentRow.Cells(1).Value.ToString
        FormEditarClientes.TBDni.Text = DGVVenta.CurrentRow.Cells(2).Value.ToString
        FormEditarClientes.TBTelefono.Text = DGVVenta.CurrentRow.Cells(3).Value.ToString
        FormEditarClientes.TBDireccion.Text = DGVVenta.CurrentRow.Cells(4).Value.ToString
        FormEditarClientes.CBProvincia.Text = DGVVenta.CurrentRow.Cells(6).Value.ToString
        FormEditarClientes.TBCorreo.Text = DGVVenta.CurrentRow.Cells(5).Value.ToString
        FormEditarClientes.TBCPostal.Text = DGVVenta.CurrentRow.Cells(7).Value.ToString

        BtnRegistrarVenta.Enabled = False

        BtnCancelarVenta.Enabled = False
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs)
        FormAgregarClientes.Show()

        BtnRegistrarVenta.Enabled = False

        BtnCancelarVenta.Enabled = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs)
        Dim confirmar As MsgBoxResult = MsgBox("Desea elminar este registro?", MsgBoxStyle.YesNo)
        If confirmar = MsgBoxResult.Yes Then
            DGVVenta.Rows.Remove(DGVVenta.CurrentRow)
            MsgBox("Se elimino correctamente", MsgBoxStyle.OkOnly, "Eliminar")
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        FormAgregarClientes.Show()
    End Sub

    Private Sub limpiarFormVenta()

        TBVendedor.Clear()
        TBDniCuit.Clear()
        TBSr.Clear()
        CBTipo.Text = ""
        CBCategoria.Text = ""
        TBDescripcion.Clear()
        NUDCantidad.Value = 0
        TBImporteRecibido.Clear()

    End Sub

    Private Sub limpiarNuevoItem()
        CBCategoria.Text = ""
        TBDescripcion.Clear()
        NUDCantidad.Value = 0
    End Sub

    Private Sub reiniciarLabels()
        Me.LblImp.Text = "$0.-"
        Me.LblIv.Text = "$0.-"
        Me.LblTot.Text = "$0.-"
        Me.LblVuelto.Text = "$0.-"
    End Sub

    Private Sub BtnAgregarItem_Click(sender As Object, e As EventArgs) Handles BtnAgregarItem.Click
        Dim item As Integer
        Dim canti As Integer
        Dim precioU As Integer
        Dim subto As Integer
        Dim arrayImporte(12) As Integer

        item = 0
        canti = Convert.ToInt32(NUDCantidad.Value)
        precioU = Int(300)
        subto = canti * precioU
        'indice = DGVVenta.CurrentRow.Index + 1

        DGVVenta.Rows.Add((item + 1).ToString, CBCategoria.Text, TBDescripcion.Text,
                           canti.ToString, precioU.ToString, subto.ToString)

        Me.LblImp.Text = "$ " & subto & ".-"
        Me.LblIv.Text = "$ " & (subto * 0.21) & ".-"
        Me.LblTot.Text = "$ " & (subto * 1.21) & ".-"

        limpiarNuevoItem()

    End Sub

    Private Sub BtnRegistrarVenta_Click(sender As Object, e As EventArgs) Handles BtnRegistrarVenta.Click
        Dim item As Integer = 0

        DGVResumenVentas.Rows.Add((item + 1).ToString, CBTipo.Text, LblNroFactura.Text,
                                 TBSr.Text, TBDniCuit.Text, DTPFechaVenta.Text, LblTot.Text,
                                 TBVendedor.Text)

        MsgBox("La venta se registró correctamente", MsgBoxStyle.OkOnly, "Venta Registrada")

        limpiarFormVenta()
        reiniciarLabels()
        DGVVenta.Rows.Clear()
    End Sub

    Private Sub TBImporteRecibido_TextChanged(sender As Object, e As EventArgs) Handles TBImporteRecibido.TextChanged
        Dim recibido As Integer
        Dim total As Integer
        Dim vuelto As Integer

        recibido = Val(Me.TBImporteRecibido.Text)
        total = Val(Me.LblTot.Text)

        vuelto = recibido - total

        Me.LblVuelto.Text = "$ " & vuelto & ".-"


    End Sub

    Private Sub BtnEliminarItem_Click(sender As Object, e As EventArgs) Handles BtnEliminarItem.Click
        Dim confirmar As MsgBoxResult = MsgBox("Desea eliminar este item?", MsgBoxStyle.YesNo)
        If confirmar = MsgBoxResult.Yes Then
            DGVVenta.Rows.Remove(DGVVenta.CurrentRow)
            MsgBox("Se elimino item correctamente", MsgBoxStyle.OkOnly, "Eliminar")
        End If
    End Sub

    Private Sub BtnCancelarVenta_Click(sender As Object, e As EventArgs) Handles BtnCancelarVenta.Click
        Me.Show()
        MsgBox("Venta cancelada correctamente", MsgBoxStyle.OkOnly, "Venta Cancelada")

        limpiarFormVenta()
        reiniciarLabels()
    End Sub

    Private Sub BtnAnularVenta_Click(sender As Object, e As EventArgs) Handles BtnAnularVenta.Click
        Dim confirmar As MsgBoxResult = MsgBox("Desea anular esta venta?", MsgBoxStyle.YesNo)
        If confirmar = MsgBoxResult.Yes Then
            DGVResumenVentas.Rows.Remove(DGVResumenVentas.CurrentRow)
            MsgBox("Se anuló venta correctamente", MsgBoxStyle.OkOnly, "Venta Anulada")
        End If

        DGVResumenVentas.Rows.Clear()
    End Sub
End Class