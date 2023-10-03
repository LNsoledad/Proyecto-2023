Public Class FormPrincipal

    Private Sub FormPpal_Iniciar(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '***********************************************************************************
    'Funciones complementarias
    Public Sub PanelContenido(ByVal Formulario As Form)


        PnlCentral.Controls.Clear()
        Formulario.TopLevel = False
        Formulario.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Formulario.Dock = DockStyle.Fill
        PnlCentral.Controls.Add(Formulario)
        Formulario.Show()

        For Each cajatexto In Formulario.Controls
            If TypeOf (cajatexto) Is TextBox Then
                cajatexto.Clear()
            End If
        Next


    End Sub

    '***********************************************************************************
    'Botones Minimizar, Maximizar, Restaurar, Cerrar'

    Private Sub PBMinim2_Click_1(sender As Object, e As EventArgs) Handles PBMinim2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PBRestaurar2_Click_1(sender As Object, e As EventArgs) Handles PBRestaurar2.Click
        WindowState = FormWindowState.Normal
        PBMaxim2.Visible = True
        PBRestaurar2.Visible = False
    End Sub

    Private Sub PBMaxim2_Click_1(sender As Object, e As EventArgs) Handles PBMaxim2.Click
        WindowState = FormWindowState.Maximized
        PBMaxim2.Visible = False
        PBRestaurar2.Visible = True
    End Sub

    Private Sub PBCerrar2_Click_1(sender As Object, e As EventArgs) Handles PBCerrar2.Click
        Application.Exit()
    End Sub

    'Botones del Menú

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click

        PanelContenido(FormClientes)
    End Sub

    Private Sub BtnVenta_Click(sender As Object, e As EventArgs) Handles BtnVenta.Click
        PanelContenido(FormVentasConTab)
    End Sub
    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click

        PanelContenido(FormProductos)
    End Sub
    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click

        PanelContenido(FormUsuario)
    End Sub
    Private Sub Btnreporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click

        PanelContenido(FormReportes)
    End Sub
    Private Sub BtnBackUp_Click(sender As Object, e As EventArgs) Handles BtnBackUp.Click

        PanelContenido(FormRealizarBackUp)
    End Sub
    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

End Class