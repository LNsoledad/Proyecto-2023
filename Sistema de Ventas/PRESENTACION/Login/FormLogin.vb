Public Class FormLogin
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If (Me.TBNUsuario.Text = "admin") And (Me.TBContrasenia.Text = "admin") Then

            FormPrincipal.Show()
            'Me.Close()

        ElseIf (Me.TBNUsuario.Text = "vendedor") And (Me.TBContrasenia.Text = "vendedor") Then

            FormPrincipal.Show()

            FormPrincipal.BtnProductos.Enabled = False
            FormPrincipal.BtnUsuarios.Enabled = False

        ElseIf (Me.TBNUsuario.Text = "usuario") And (Me.TBContrasenia.Text = "usuario") Then

            FormPrincipal.Show()

            FormPrincipal.BtnClientes.Enabled = False
            FormPrincipal.BtnProductos.Enabled = False
            FormPrincipal.BtnUsuarios.Enabled = False
            FormPrincipal.BtnVenta.Enabled = False

        Else
            MsgBox("Usuario no encontrado")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

End Class