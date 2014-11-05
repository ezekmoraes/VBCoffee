Public Class frmLoading

    Private Sub CircularProgress1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loading.ValueChanged

    End Sub

    Private Sub frmLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor.Hide()
        Loading.Top = (Me.Height - Loading.Height) / 2
        Loading.Left = (Me.Width - Loading.Width) / 2
    End Sub

    Private Sub tmrLoading_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoading.Tick
        If Not Loading.Value = 100 Then
            Loading.Value += 1
        Else
            Me.Hide()
            Cursor.Show()
            tmrLoading.Stop()
        End If
    End Sub
End Class