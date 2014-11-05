<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim ClockStyleData1 As DevComponents.DotNetBar.Controls.ClockStyleData = New DevComponents.DotNetBar.Controls.ClockStyleData
        Dim ColorData1 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData
        Dim ColorData2 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData
        Dim ColorData3 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData
        Dim ClockHandStyleData1 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData
        Dim ColorData4 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData
        Dim ColorData5 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData
        Dim ClockHandStyleData2 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData
        Dim ColorData6 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData
        Dim ClockHandStyleData3 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData
        Dim ColorData7 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData
        Dim ColorData8 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCalculadora = New System.Windows.Forms.PictureBox
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.btnNavegador = New DevComponents.DotNetBar.LabelX
        Me.btnStart = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlStart = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX
        Me.btnDesligar = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.pnlNavegador = New System.Windows.Forms.Panel
        Me.Navegador1 = New S.O._VBC_APPLICATION_EXAMPLE.navegador
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX
        Me.btnNavegadorMaximizar = New DevComponents.DotNetBar.LabelX
        Me.btnNavegadorFechar = New DevComponents.DotNetBar.LabelX
        Me.Relogio = New DevComponents.DotNetBar.Controls.AnalogClockControl
        Me.tmrData = New System.Windows.Forms.Timer(Me.components)
        Me.Calculator1 = New DevComponents.Editors.Calculator
        Me.pnlCalculadora = New System.Windows.Forms.Panel
        Me.btnCalculadoraMinimizar = New DevComponents.DotNetBar.LabelX
        Me.btnCalculadoraMaximizar = New DevComponents.DotNetBar.LabelX
        Me.Panel1.SuspendLayout()
        CType(Me.btnCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStart.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlNavegador.SuspendLayout()
        Me.pnlCalculadora.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCalculadora)
        Me.Panel1.Controls.Add(Me.LabelX10)
        Me.Panel1.Controls.Add(Me.LabelX12)
        Me.Panel1.Controls.Add(Me.LabelX8)
        Me.Panel1.Controls.Add(Me.LabelX9)
        Me.Panel1.Controls.Add(Me.LabelX6)
        Me.Panel1.Controls.Add(Me.btnNavegador)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.LabelX4)
        Me.Panel1.Controls.Add(Me.LabelX3)
        Me.Panel1.Controls.Add(Me.LabelX2)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 509)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1052, 40)
        Me.Panel1.TabIndex = 0
        '
        'btnCalculadora
        '
        Me.btnCalculadora.Image = Global.S.O._VBC_APPLICATION_EXAMPLE.My.Resources.Resources.calculadora_icon
        Me.btnCalculadora.Location = New System.Drawing.Point(216, 4)
        Me.btnCalculadora.Name = "btnCalculadora"
        Me.btnCalculadora.Size = New System.Drawing.Size(37, 35)
        Me.btnCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnCalculadora.TabIndex = 31
        Me.btnCalculadora.TabStop = False
        '
        'LabelX10
        '
        Me.LabelX10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(261, 5)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(37, 35)
        Me.LabelX10.Symbol = ""
        Me.LabelX10.SymbolSize = 22.0!
        Me.LabelX10.TabIndex = 21
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX12
        '
        Me.LabelX12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(304, 5)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(37, 35)
        Me.LabelX12.Symbol = ""
        Me.LabelX12.SymbolSize = 22.0!
        Me.LabelX12.TabIndex = 19
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX8
        '
        Me.LabelX8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(175, 5)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(37, 35)
        Me.LabelX8.Symbol = ""
        Me.LabelX8.SymbolSize = 22.0!
        Me.LabelX8.TabIndex = 18
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX9
        '
        Me.LabelX9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(89, 5)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(37, 35)
        Me.LabelX9.Symbol = ""
        Me.LabelX9.SymbolSize = 25.0!
        Me.LabelX9.TabIndex = 17
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX6
        '
        Me.LabelX6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(132, 5)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(37, 35)
        Me.LabelX6.Symbol = ""
        Me.LabelX6.SymbolSize = 22.0!
        Me.LabelX6.TabIndex = 16
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnNavegador
        '
        Me.btnNavegador.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.btnNavegador.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnNavegador.Location = New System.Drawing.Point(46, 4)
        Me.btnNavegador.Name = "btnNavegador"
        Me.btnNavegador.Size = New System.Drawing.Size(37, 35)
        Me.btnNavegador.Symbol = ""
        Me.btnNavegador.SymbolSize = 25.0!
        Me.btnNavegador.TabIndex = 15
        Me.btnNavegador.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        '
        '
        Me.btnStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnStart.Location = New System.Drawing.Point(0, 1)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(36, 39)
        Me.btnStart.Symbol = ""
        Me.btnStart.SymbolSize = 30.0!
        Me.btnStart.TabIndex = 30
        Me.btnStart.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX4
        '
        Me.LabelX4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(944, 11)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(28, 23)
        Me.LabelX4.Symbol = ""
        Me.LabelX4.SymbolSize = 15.0!
        Me.LabelX4.TabIndex = 12
        '
        'LabelX3
        '
        Me.LabelX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(910, 11)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(28, 23)
        Me.LabelX3.Symbol = ""
        Me.LabelX3.SymbolSize = 15.0!
        Me.LabelX3.TabIndex = 12
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(978, 11)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(28, 23)
        Me.LabelX2.Symbol = ""
        Me.LabelX2.SymbolSize = 15.0!
        Me.LabelX2.TabIndex = 12
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(1012, 11)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(28, 23)
        Me.LabelX1.Symbol = ""
        Me.LabelX1.SymbolSize = 15.0!
        Me.LabelX1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.S.O._VBC_APPLICATION_EXAMPLE.My.Resources.Resources.Recycle_Bin_Empty_64
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pnlStart
        '
        Me.pnlStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlStart.Controls.Add(Me.Panel2)
        Me.pnlStart.Controls.Add(Me.LabelX5)
        Me.pnlStart.Controls.Add(Me.LabelX19)
        Me.pnlStart.Controls.Add(Me.LabelX18)
        Me.pnlStart.Controls.Add(Me.LabelX15)
        Me.pnlStart.Controls.Add(Me.LabelX17)
        Me.pnlStart.Controls.Add(Me.LabelX16)
        Me.pnlStart.Location = New System.Drawing.Point(0, 304)
        Me.pnlStart.Name = "pnlStart"
        Me.pnlStart.Size = New System.Drawing.Size(445, 205)
        Me.pnlStart.TabIndex = 23
        Me.pnlStart.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LabelX21)
        Me.Panel2.Controls.Add(Me.LabelX14)
        Me.Panel2.Controls.Add(Me.btnDesligar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(445, 36)
        Me.Panel2.TabIndex = 38
        '
        'LabelX21
        '
        Me.LabelX21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX21.Location = New System.Drawing.Point(293, 8)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(28, 23)
        Me.LabelX21.Symbol = ""
        Me.LabelX21.SymbolSize = 22.0!
        Me.LabelX21.TabIndex = 31
        '
        'LabelX14
        '
        Me.LabelX14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(351, 3)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(37, 35)
        Me.LabelX14.Symbol = ""
        Me.LabelX14.SymbolSize = 22.0!
        Me.LabelX14.TabIndex = 31
        Me.LabelX14.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnDesligar
        '
        Me.btnDesligar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.btnDesligar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnDesligar.Location = New System.Drawing.Point(408, 3)
        Me.btnDesligar.Name = "btnDesligar"
        Me.btnDesligar.Size = New System.Drawing.Size(37, 35)
        Me.btnDesligar.Symbol = ""
        Me.btnDesligar.SymbolSize = 22.0!
        Me.btnDesligar.TabIndex = 31
        Me.btnDesligar.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX5
        '
        Me.LabelX5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(362, 55)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(60, 60)
        Me.LabelX5.Symbol = ""
        Me.LabelX5.SymbolSize = 45.0!
        Me.LabelX5.TabIndex = 37
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX19
        '
        Me.LabelX19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Location = New System.Drawing.Point(23, 55)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(60, 60)
        Me.LabelX19.Symbol = ""
        Me.LabelX19.SymbolSize = 45.0!
        Me.LabelX19.TabIndex = 31
        Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX18
        '
        Me.LabelX18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Location = New System.Drawing.Point(178, 55)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(65, 60)
        Me.LabelX18.Symbol = ""
        Me.LabelX18.SymbolSize = 45.0!
        Me.LabelX18.TabIndex = 32
        Me.LabelX18.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX15
        '
        Me.LabelX15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(23, 130)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(71, 60)
        Me.LabelX15.Symbol = ""
        Me.LabelX15.SymbolSize = 45.0!
        Me.LabelX15.TabIndex = 35
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX17
        '
        Me.LabelX17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Location = New System.Drawing.Point(102, 55)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(60, 60)
        Me.LabelX17.Symbol = ""
        Me.LabelX17.SymbolSize = 45.0!
        Me.LabelX17.TabIndex = 33
        Me.LabelX17.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX16
        '
        Me.LabelX16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Location = New System.Drawing.Point(272, 55)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(65, 60)
        Me.LabelX16.Symbol = ""
        Me.LabelX16.SymbolSize = 45.0!
        Me.LabelX16.TabIndex = 34
        Me.LabelX16.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'pnlNavegador
        '
        Me.pnlNavegador.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pnlNavegador.BackgroundImage = Global.S.O._VBC_APPLICATION_EXAMPLE.My.Resources.Resources.navegador_bar
        Me.pnlNavegador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlNavegador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNavegador.Controls.Add(Me.Navegador1)
        Me.pnlNavegador.Controls.Add(Me.LabelX20)
        Me.pnlNavegador.Controls.Add(Me.btnNavegadorMaximizar)
        Me.pnlNavegador.Controls.Add(Me.btnNavegadorFechar)
        Me.pnlNavegador.Location = New System.Drawing.Point(114, 16)
        Me.pnlNavegador.Name = "pnlNavegador"
        Me.pnlNavegador.Size = New System.Drawing.Size(351, 30)
        Me.pnlNavegador.TabIndex = 39
        Me.pnlNavegador.Visible = False
        '
        'Navegador1
        '
        Me.Navegador1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Navegador1.Location = New System.Drawing.Point(0, 28)
        Me.Navegador1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Navegador1.Name = "Navegador1"
        Me.Navegador1.Size = New System.Drawing.Size(349, 0)
        Me.Navegador1.TabIndex = 39
        '
        'LabelX20
        '
        Me.LabelX20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.Location = New System.Drawing.Point(253, 5)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(28, 23)
        Me.LabelX20.Symbol = ""
        Me.LabelX20.SymbolSize = 15.0!
        Me.LabelX20.TabIndex = 31
        '
        'btnNavegadorMaximizar
        '
        Me.btnNavegadorMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.btnNavegadorMaximizar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnNavegadorMaximizar.Location = New System.Drawing.Point(287, -2)
        Me.btnNavegadorMaximizar.Name = "btnNavegadorMaximizar"
        Me.btnNavegadorMaximizar.Size = New System.Drawing.Size(37, 35)
        Me.btnNavegadorMaximizar.Symbol = ""
        Me.btnNavegadorMaximizar.SymbolSize = 15.0!
        Me.btnNavegadorMaximizar.TabIndex = 31
        Me.btnNavegadorMaximizar.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnNavegadorFechar
        '
        Me.btnNavegadorFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.btnNavegadorFechar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnNavegadorFechar.Location = New System.Drawing.Point(323, -2)
        Me.btnNavegadorFechar.Name = "btnNavegadorFechar"
        Me.btnNavegadorFechar.Size = New System.Drawing.Size(37, 35)
        Me.btnNavegadorFechar.Symbol = ""
        Me.btnNavegadorFechar.SymbolSize = 15.0!
        Me.btnNavegadorFechar.TabIndex = 31
        Me.btnNavegadorFechar.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Relogio
        '
        Me.Relogio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Relogio.BackColor = System.Drawing.Color.Transparent
        Me.Relogio.ClockStyle = DevComponents.DotNetBar.Controls.eClockStyles.Custom
        ColorData1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        ColorData1.BorderWidth = 0.01!
        ColorData1.BrushSBSScale = 1.0!
        ColorData1.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData1.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ColorData1.Color2 = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer))
        ClockStyleData1.BezelColor = ColorData1
        ColorData2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData2.BorderWidth = 0.01!
        ColorData2.BrushSBSScale = 1.0!
        ColorData2.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData2.Color2 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ClockStyleData1.CapColor = ColorData2
        ColorData3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(161, Byte), Integer))
        ColorData3.BorderWidth = 0.01!
        ColorData3.BrushAngle = 45.0!
        ColorData3.BrushSBSScale = 1.0!
        ColorData3.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData3.Color1 = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer))
        ColorData3.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ClockStyleData1.FaceColor = ColorData3
        ClockStyleData1.GlassAngle = -20
        ColorData4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData4.BorderWidth = 0.01!
        ColorData4.BrushSBSScale = 1.0!
        ColorData4.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData4.Color2 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ClockHandStyleData1.HandColor = ColorData4
        ClockHandStyleData1.Length = 0.55!
        ClockHandStyleData1.Width = 0.015!
        ClockStyleData1.HourHandStyle = ClockHandStyleData1
        ColorData5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ColorData5.BorderWidth = 0.01!
        ColorData5.BrushSBSScale = 1.0!
        ColorData5.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData5.Color1 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(154, Byte), Integer))
        ColorData5.Color2 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(154, Byte), Integer))
        ClockStyleData1.LargeTickColor = ColorData5
        ColorData6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData6.BorderWidth = 0.01!
        ColorData6.BrushSBSScale = 1.0!
        ColorData6.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData6.Color2 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ClockHandStyleData2.HandColor = ColorData6
        ClockHandStyleData2.Length = 0.8!
        ClockHandStyleData2.Width = 0.01!
        ClockStyleData1.MinuteHandStyle = ClockHandStyleData2
        ClockStyleData1.NumberFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        ColorData7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData7.BorderWidth = 0.01!
        ColorData7.BrushSBSScale = 1.0!
        ColorData7.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ColorData7.Color2 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(138, Byte), Integer))
        ClockHandStyleData3.HandColor = ColorData7
        ClockHandStyleData3.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style2
        ClockHandStyleData3.Length = 0.8!
        ClockHandStyleData3.Width = 0.005!
        ClockStyleData1.SecondHandStyle = ClockHandStyleData3
        ColorData8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ColorData8.BorderWidth = 0.01!
        ColorData8.BrushSBSScale = 1.0!
        ColorData8.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData8.Color1 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(154, Byte), Integer))
        ColorData8.Color2 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(154, Byte), Integer))
        ClockStyleData1.SmallTickColor = ColorData8
        ClockStyleData1.Style = DevComponents.DotNetBar.Controls.eClockStyles.Custom
        Me.Relogio.ClockStyleData = ClockStyleData1
        Me.Relogio.Location = New System.Drawing.Point(891, 16)
        Me.Relogio.Name = "Relogio"
        Me.Relogio.Size = New System.Drawing.Size(149, 149)
        Me.Relogio.TabIndex = 40
        Me.Relogio.Text = "AnalogClockControl1"
        Me.Relogio.Value = New Date(2014, 10, 31, 23, 23, 1, 652)
        '
        'tmrData
        '
        Me.tmrData.Enabled = True
        Me.tmrData.Interval = 1
        '
        'Calculator1
        '
        Me.Calculator1.AutoSize = True
        Me.Calculator1.Location = New System.Drawing.Point(-1, 28)
        Me.Calculator1.Name = "Calculator1"
        Me.Calculator1.Size = New System.Drawing.Size(190, 211)
        Me.Calculator1.Text = "Calculator1"
        '
        'pnlCalculadora
        '
        Me.pnlCalculadora.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pnlCalculadora.BackgroundImage = Global.S.O._VBC_APPLICATION_EXAMPLE.My.Resources.Resources.calculadora_bar
        Me.pnlCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlCalculadora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCalculadora.Controls.Add(Me.btnCalculadoraMinimizar)
        Me.pnlCalculadora.Controls.Add(Me.Calculator1)
        Me.pnlCalculadora.Controls.Add(Me.btnCalculadoraMaximizar)
        Me.pnlCalculadora.Location = New System.Drawing.Point(481, 16)
        Me.pnlCalculadora.Name = "pnlCalculadora"
        Me.pnlCalculadora.Size = New System.Drawing.Size(189, 30)
        Me.pnlCalculadora.TabIndex = 40
        Me.pnlCalculadora.Visible = False
        '
        'btnCalculadoraMinimizar
        '
        Me.btnCalculadoraMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.btnCalculadoraMinimizar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnCalculadoraMinimizar.Location = New System.Drawing.Point(127, 4)
        Me.btnCalculadoraMinimizar.Name = "btnCalculadoraMinimizar"
        Me.btnCalculadoraMinimizar.Size = New System.Drawing.Size(28, 23)
        Me.btnCalculadoraMinimizar.Symbol = ""
        Me.btnCalculadoraMinimizar.SymbolSize = 15.0!
        Me.btnCalculadoraMinimizar.TabIndex = 31
        '
        'btnCalculadoraMaximizar
        '
        Me.btnCalculadoraMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.btnCalculadoraMaximizar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnCalculadoraMaximizar.Location = New System.Drawing.Point(161, -2)
        Me.btnCalculadoraMaximizar.Name = "btnCalculadoraMaximizar"
        Me.btnCalculadoraMaximizar.Size = New System.Drawing.Size(37, 35)
        Me.btnCalculadoraMaximizar.Symbol = ""
        Me.btnCalculadoraMaximizar.SymbolSize = 15.0!
        Me.btnCalculadoraMaximizar.TabIndex = 31
        Me.btnCalculadoraMaximizar.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BackgroundImage = Global.S.O._VBC_APPLICATION_EXAMPLE.My.Resources.Resources.background_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1052, 549)
        Me.Controls.Add(Me.pnlStart)
        Me.Controls.Add(Me.pnlCalculadora)
        Me.Controls.Add(Me.pnlNavegador)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Relogio)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "S.O. VBC APPLICATION EXAMPLE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStart.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlNavegador.ResumeLayout(False)
        Me.pnlCalculadora.ResumeLayout(False)
        Me.pnlCalculadora.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnNavegador As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnStart As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents pnlStart As System.Windows.Forms.Panel
    Friend WithEvents btnDesligar As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents pnlNavegador As System.Windows.Forms.Panel
    Friend WithEvents btnNavegadorMaximizar As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnNavegadorFechar As DevComponents.DotNetBar.LabelX
    Friend WithEvents Navegador1 As S.O._VBC_APPLICATION_EXAMPLE.navegador
    Friend WithEvents Relogio As DevComponents.DotNetBar.Controls.AnalogClockControl
    Friend WithEvents tmrData As System.Windows.Forms.Timer
    Friend WithEvents Calculator1 As DevComponents.Editors.Calculator
    Friend WithEvents pnlCalculadora As System.Windows.Forms.Panel
    Friend WithEvents btnCalculadoraMinimizar As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCalculadoraMaximizar As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCalculadora As System.Windows.Forms.PictureBox
End Class
