<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.pnlLogin = New DevComponents.DotNetBar.PanelEx
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtNome = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnEntrar = New DevComponents.DotNetBar.ButtonX
        Me.pnlEnergia = New DevComponents.DotNetBar.PanelEx
        Me.btnClose = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.pnlLogin.SuspendLayout()
        Me.pnlEnergia.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLogin
        '
        Me.pnlLogin.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlLogin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlLogin.Controls.Add(Me.LabelX1)
        Me.pnlLogin.Controls.Add(Me.txtNome)
        Me.pnlLogin.Controls.Add(Me.btnEntrar)
        Me.pnlLogin.Location = New System.Drawing.Point(12, 13)
        Me.pnlLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(350, 187)
        Me.pnlLogin.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlLogin.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlLogin.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlLogin.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlLogin.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlLogin.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlLogin.Style.GradientAngle = 90
        Me.pnlLogin.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(47, 10)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(258, 53)
        Me.LabelX1.TabIndex = 6
        Me.LabelX1.Text = "Digite seu nome:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        '
        '
        Me.txtNome.Border.Class = "TextBoxBorder"
        Me.txtNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNome.FocusHighlightColor = System.Drawing.Color.White
        Me.txtNome.FocusHighlightEnabled = True
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtNome.Location = New System.Drawing.Point(47, 71)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(258, 25)
        Me.txtNome.TabIndex = 5
        '
        'btnEntrar
        '
        Me.btnEntrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEntrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEntrar.Location = New System.Drawing.Point(133, 121)
        Me.btnEntrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(87, 30)
        Me.btnEntrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "Entrar"
        '
        'pnlEnergia
        '
        Me.pnlEnergia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlEnergia.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlEnergia.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlEnergia.Controls.Add(Me.ButtonX3)
        Me.pnlEnergia.Controls.Add(Me.btnClose)
        Me.pnlEnergia.Location = New System.Drawing.Point(370, 147)
        Me.pnlEnergia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlEnergia.Name = "pnlEnergia"
        Me.pnlEnergia.Size = New System.Drawing.Size(94, 53)
        Me.pnlEnergia.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlEnergia.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlEnergia.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlEnergia.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlEnergia.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlEnergia.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlEnergia.Style.GradientAngle = 90
        Me.pnlEnergia.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Location = New System.Drawing.Point(50, 8)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(37, 37)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.btnClose.Symbol = ""
        Me.btnClose.TabIndex = 4
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(7, 8)
        Me.ButtonX3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(37, 37)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.TabIndex = 4
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(476, 213)
        Me.Controls.Add(Me.pnlEnergia)
        Me.Controls.Add(Me.pnlLogin)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmStart"
        Me.Text = "S.O. VBC APPLICATION EXAMPLE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlEnergia.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLogin As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNome As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnEntrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pnlEnergia As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX

End Class
