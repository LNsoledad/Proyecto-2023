Public Class FormRealizarBackUp
    Private Sub PBMinim2_Click(sender As Object, e As EventArgs) Handles PBMinim2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PBCerrar2_Click(sender As Object, e As EventArgs) Handles PBCerrar2.Click
        Me.Close()
    End Sub
End Class