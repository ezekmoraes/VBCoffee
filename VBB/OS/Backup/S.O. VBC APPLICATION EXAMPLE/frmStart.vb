Public Class frmStart

    Private Sub frmStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlLogin.Top = (Me.Height - pnlLogin.Height) / 2
        pnlLogin.Left = (Me.Width - pnlLogin.Width) / 2
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        If Not txtNome.Text = Nothing Then
            nome_do_usuário = txtNome.Text
            frmLoading.ShowDialog()
            frmMain.Show()
            Me.Hide()
        End If
    End Sub
End Class
