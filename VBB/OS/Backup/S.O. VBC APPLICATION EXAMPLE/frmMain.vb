Public Class frmMain
    Private Const WM_NCLBUTTONDOWN = &HA1
    Private Const HTCAPTION = 2

    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
                 (ByVal hwnd As Integer, ByVal wMsg As Integer, _
                  ByVal wParam As Integer, ByVal lParam As String) As Integer
    Private Declare Sub ReleaseCapture Lib "user32" ()

    Private Sub ctmclr_SelectedColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.BackColor = ctmclr.SelectedColor
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmStart.Close()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With pnlNavegador
            .Width = 800
            .Height = 500
            .Dock = DockStyle.Fill
        End With
        With pnlCalculadora
            .Width = 189
            .Height = 241
        End With
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        With pnlStart
            If .Visible = False Then
                .Visible = True
                .BringToFront()
            Else
                .Visible = False
            End If
        End With 
    End Sub

    Private Sub btnStart_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.MouseEnter
        btnStart.BackColor = Color.FromArgb(241, 196, 15)
    End Sub

    Private Sub btnStart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.MouseLeave
        btnStart.BackColor = Color.FromArgb(128, 255, 128)
    End Sub

    Private Sub btnDesligar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesligar.Click
        Close()
    End Sub

    Private Sub btnNavegador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavegador.Click
        With pnlNavegador
            If .Visible = False Then
                .Visible = True
                .BringToFront()
                Navegador1.WebBrowser1.Navigate("http://www.google.com.br")
            Else
                .Visible = False
            End If
        End With
    End Sub

    Private Sub pnlNavegador_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlNavegador.MouseMove
        Dim lHwnd As Int32
        lHwnd = pnlNavegador.Handle
        If lHwnd = 0 Then Exit Sub
        ReleaseCapture()
        SendMessage(lHwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private Sub btnMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavegadorMaximizar.Click
        If Not pnlNavegador.Dock = DockStyle.Fill Then
            pnlNavegador.Dock = DockStyle.Fill
        Else
            pnlNavegador.Dock = DockStyle.None
        End If
    End Sub

    Private Sub pnlNavegador_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlNavegador.DoubleClick
        If Not pnlNavegador.Dock = DockStyle.Fill Then
            pnlNavegador.Dock = DockStyle.Fill
        Else
            pnlNavegador.Dock = DockStyle.None
        End If
    End Sub

    Private Sub tmrData_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrData.Tick
        Relogio.Value = Now
    End Sub

    Private Sub btnNavegadorFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavegadorFechar.Click
        pnlNavegador.Visible = False
    End Sub

    Private Sub btnCalculadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculadora.Click
        With pnlCalculadora
            If Not .Visible = False Then
                .Visible = False
            Else
                .Visible = True
                .BringToFront()
            End If
        End With
    End Sub

    Private Sub btnCalculadoraMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculadoraMinimizar.Click
        pnlCalculadora.Visible = False
    End Sub

    Private Sub btnCalculadoraMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculadoraMaximizar.Click
        pnlCalculadora.Visible = False
    End Sub

    Private Sub pnlCalculadora_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlCalculadora.MouseMove
        Dim lHwnd As Int32
        lHwnd = pnlCalculadora.Handle
        If lHwnd = 0 Then Exit Sub
        ReleaseCapture()
        SendMessage(lHwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private Sub frmMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        pnlStart.Visible = False
    End Sub
End Class