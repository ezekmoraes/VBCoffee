<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Loading = New DevComponents.DotNetBar.Controls.CircularProgress
        Me.tmrLoading = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Loading
        '
        '
        '
        '
        Me.Loading.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Loading.FocusCuesEnabled = False
        Me.Loading.Location = New System.Drawing.Point(12, 12)
        Me.Loading.Name = "Loading"
        Me.Loading.PieBorderDark = System.Drawing.Color.Transparent
        Me.Loading.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.Loading.ProgressColor = System.Drawing.Color.White
        Me.Loading.ProgressText = "f"
        Me.Loading.ProgressTextVisible = True
        Me.Loading.Size = New System.Drawing.Size(133, 82)
        Me.Loading.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.Loading.TabIndex = 0
        '
        'tmrLoading
        '
        Me.tmrLoading.Enabled = True
        Me.tmrLoading.Interval = 30
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(161, 108)
        Me.Controls.Add(Me.Loading)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmLoading"
        Me.Text = "S.O. VBC APPLICATION EXAMPLE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Loading As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents tmrLoading As System.Windows.Forms.Timer
End Class
