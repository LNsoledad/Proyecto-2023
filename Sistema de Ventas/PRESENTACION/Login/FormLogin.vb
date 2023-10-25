Public Class FormLogin
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If (Me.TBNUsuario.Text = "admin") And (Me.TBContrasenia.Text = "admin") Then

            FormPrincipal.Show()
            FormPrincipal.BtnClientes.Enabled = False
            FormPrincipal.BtnReporte.Enabled = False
            FormPrincipal.BtnUsuarios.Enabled = False
            FormPrincipal.BtnVenta.Enabled = False
            FormPrincipal.BtnBackUp.Enabled = False
            'Me.Close()

        ElseIf (Me.TBNUsuario.Text = "vendedor") And (Me.TBContrasenia.Text = "vendedor") Then

            FormPrincipal.Show()
            FormPrincipal.BtnReporte.Enabled = False
            FormPrincipal.BtnUsuarios.Enabled = False
            'FormPrincipal.BtnVenta.Enabled = False
            FormPrincipal.BtnBackUp.Enabled = False
            FormPrincipal.BtnUsuarios.Enabled = False
            FormPrincipal.BtnEmpleados.Enabled = False


        ElseIf (Me.TBNUsuario.Text = "superadmin") And (Me.TBContrasenia.Text = "super") Then

            FormPrincipal.Show()

            FormPrincipal.BtnClientes.Enabled = False
            FormPrincipal.BtnProductos.Enabled = False
            FormPrincipal.BtnReporte.Enabled = False
            FormPrincipal.BtnVenta.Enabled = False
            FormPrincipal.BtnEmpleados.Enabled = False

        ElseIf (Me.TBNUsuario.Text = "supervisor") And (Me.TBContrasenia.Text = "super") Then

            FormPrincipal.Show()
            FormPrincipal.BtnClientes.Enabled = False
            FormPrincipal.BtnProductos.Enabled = False
            FormPrincipal.BtnBackUp.Enabled = False
            FormPrincipal.BtnVenta.Enabled = False
            FormPrincipal.BtnEmpleados.Enabled = False
            FormPrincipal.BtnUsuarios.Enabled = False

        Else
            MsgBox("Usuario no encontrado")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub TBNUsuario_TextChanged(sender As Object, e As EventArgs) Handles TBNUsuario.TextChanged

    End Sub
End Class