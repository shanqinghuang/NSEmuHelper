<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits MaterialSkin.Controls.MaterialForm

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Tabs = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabMain = New System.Windows.Forms.TabPage()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.lblRyujinxFirmware = New System.Windows.Forms.Label()
        Me.lblRyujinx2 = New System.Windows.Forms.Label()
        Me.lblRyujinx = New System.Windows.Forms.Label()
        Me.picRyujinx = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWelcomeMessage = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.lblYuzuFirmware = New System.Windows.Forms.Label()
        Me.lblYuzu2 = New System.Windows.Forms.Label()
        Me.lblYuzu = New System.Windows.Forms.Label()
        Me.picYuzu = New System.Windows.Forms.PictureBox()
        Me.TabYuzu = New System.Windows.Forms.TabPage()
        Me.TabAbout = New System.Windows.Forms.TabPage()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialButton3 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.imgTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.TabConfig = New System.Windows.Forms.TabPage()
        Me.TabRyujinx = New System.Windows.Forms.TabPage()
        Me.MaterialCard5 = New MaterialSkin.Controls.MaterialCard()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblYuzuConfig = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtYuzuPath = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Tabs.SuspendLayout()
        Me.TabMain.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        CType(Me.picRyujinx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.picYuzu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAbout.SuspendLayout()
        Me.MaterialCard3.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        Me.TabConfig.SuspendLayout()
        Me.MaterialCard5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabMain)
        Me.Tabs.Controls.Add(Me.TabYuzu)
        Me.Tabs.Controls.Add(Me.TabRyujinx)
        Me.Tabs.Controls.Add(Me.TabConfig)
        Me.Tabs.Controls.Add(Me.TabAbout)
        Me.Tabs.Depth = 0
        Me.Tabs.HotTrack = True
        Me.Tabs.ImageList = Me.imgTabs
        Me.Tabs.Location = New System.Drawing.Point(2, 66)
        Me.Tabs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Tabs.MouseState = MaterialSkin.MouseState.HOVER
        Me.Tabs.Multiline = True
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(786, 382)
        Me.Tabs.TabIndex = 0
        '
        'TabMain
        '
        Me.TabMain.BackColor = System.Drawing.Color.White
        Me.TabMain.Controls.Add(Me.MaterialCard4)
        Me.TabMain.Controls.Add(Me.Label1)
        Me.TabMain.Controls.Add(Me.lblWelcomeMessage)
        Me.TabMain.Controls.Add(Me.MaterialCard1)
        Me.TabMain.ImageKey = "home.png"
        Me.TabMain.Location = New System.Drawing.Point(4, 24)
        Me.TabMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabMain.Size = New System.Drawing.Size(778, 354)
        Me.TabMain.TabIndex = 0
        Me.TabMain.Text = "首页"
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.lblRyujinxFirmware)
        Me.MaterialCard4.Controls.Add(Me.lblRyujinx2)
        Me.MaterialCard4.Controls.Add(Me.lblRyujinx)
        Me.MaterialCard4.Controls.Add(Me.picRyujinx)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(534, 133)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.Size = New System.Drawing.Size(234, 101)
        Me.MaterialCard4.TabIndex = 4
        '
        'lblRyujinxFirmware
        '
        Me.lblRyujinxFirmware.AutoSize = True
        Me.lblRyujinxFirmware.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblRyujinxFirmware.Location = New System.Drawing.Point(94, 67)
        Me.lblRyujinxFirmware.Name = "lblRyujinxFirmware"
        Me.lblRyujinxFirmware.Size = New System.Drawing.Size(45, 21)
        Me.lblRyujinxFirmware.TabIndex = 3
        Me.lblRyujinxFirmware.Text = "固件:"
        '
        'lblRyujinx2
        '
        Me.lblRyujinx2.AutoSize = True
        Me.lblRyujinx2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblRyujinx2.Location = New System.Drawing.Point(94, 12)
        Me.lblRyujinx2.Name = "lblRyujinx2"
        Me.lblRyujinx2.Size = New System.Drawing.Size(113, 21)
        Me.lblRyujinx2.TabIndex = 1
        Me.lblRyujinx2.Text = "Ryujinx 模拟器"
        '
        'lblRyujinx
        '
        Me.lblRyujinx.AutoSize = True
        Me.lblRyujinx.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblRyujinx.Location = New System.Drawing.Point(94, 39)
        Me.lblRyujinx.Name = "lblRyujinx"
        Me.lblRyujinx.Size = New System.Drawing.Size(81, 21)
        Me.lblRyujinx.TabIndex = 2
        Me.lblRyujinx.Text = "当前状态: "
        '
        'picRyujinx
        '
        Me.picRyujinx.Image = Global.NSEmuHelper.My.Resources.Resources.ryujinx
        Me.picRyujinx.Location = New System.Drawing.Point(10, 10)
        Me.picRyujinx.Name = "picRyujinx"
        Me.picRyujinx.Size = New System.Drawing.Size(77, 79)
        Me.picRyujinx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRyujinx.TabIndex = 0
        Me.picRyujinx.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "本工具可以帮您方便地安装和管理 NS 模拟器。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "您还没有安装模拟器，现在就安装或者从本地导入吧！"
        '
        'lblWelcomeMessage
        '
        Me.lblWelcomeMessage.AutoSize = True
        Me.lblWelcomeMessage.Depth = 0
        Me.lblWelcomeMessage.Font = New System.Drawing.Font("HarmonyOS Sans SC", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblWelcomeMessage.Location = New System.Drawing.Point(78, 12)
        Me.lblWelcomeMessage.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblWelcomeMessage.Name = "lblWelcomeMessage"
        Me.lblWelcomeMessage.Size = New System.Drawing.Size(178, 19)
        Me.lblWelcomeMessage.TabIndex = 4
        Me.lblWelcomeMessage.Text = "欢迎使用 NS 模拟器助手!"
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.lblYuzuFirmware)
        Me.MaterialCard1.Controls.Add(Me.lblYuzu2)
        Me.MaterialCard1.Controls.Add(Me.lblYuzu)
        Me.MaterialCard1.Controls.Add(Me.picYuzu)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(534, 14)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(234, 101)
        Me.MaterialCard1.TabIndex = 3
        '
        'lblYuzuFirmware
        '
        Me.lblYuzuFirmware.AutoSize = True
        Me.lblYuzuFirmware.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblYuzuFirmware.Location = New System.Drawing.Point(94, 67)
        Me.lblYuzuFirmware.Name = "lblYuzuFirmware"
        Me.lblYuzuFirmware.Size = New System.Drawing.Size(45, 21)
        Me.lblYuzuFirmware.TabIndex = 3
        Me.lblYuzuFirmware.Text = "固件:"
        '
        'lblYuzu2
        '
        Me.lblYuzu2.AutoSize = True
        Me.lblYuzu2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblYuzu2.Location = New System.Drawing.Point(94, 12)
        Me.lblYuzu2.Name = "lblYuzu2"
        Me.lblYuzu2.Size = New System.Drawing.Size(96, 21)
        Me.lblYuzu2.TabIndex = 1
        Me.lblYuzu2.Text = "Yuzu 模拟器"
        '
        'lblYuzu
        '
        Me.lblYuzu.AutoSize = True
        Me.lblYuzu.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblYuzu.Location = New System.Drawing.Point(94, 39)
        Me.lblYuzu.Name = "lblYuzu"
        Me.lblYuzu.Size = New System.Drawing.Size(81, 21)
        Me.lblYuzu.TabIndex = 2
        Me.lblYuzu.Text = "当前状态: "
        '
        'picYuzu
        '
        Me.picYuzu.Image = CType(resources.GetObject("picYuzu.Image"), System.Drawing.Image)
        Me.picYuzu.Location = New System.Drawing.Point(12, 10)
        Me.picYuzu.Name = "picYuzu"
        Me.picYuzu.Size = New System.Drawing.Size(72, 79)
        Me.picYuzu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYuzu.TabIndex = 0
        Me.picYuzu.TabStop = False
        '
        'TabYuzu
        '
        Me.TabYuzu.BackColor = System.Drawing.Color.White
        Me.TabYuzu.ImageKey = "yuzu.png"
        Me.TabYuzu.Location = New System.Drawing.Point(4, 24)
        Me.TabYuzu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabYuzu.Name = "TabYuzu"
        Me.TabYuzu.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabYuzu.Size = New System.Drawing.Size(778, 354)
        Me.TabYuzu.TabIndex = 1
        Me.TabYuzu.Text = "Yuzu"
        '
        'TabAbout
        '
        Me.TabAbout.BackColor = System.Drawing.Color.White
        Me.TabAbout.Controls.Add(Me.MaterialCard3)
        Me.TabAbout.Controls.Add(Me.MaterialCard2)
        Me.TabAbout.ImageKey = "about.png"
        Me.TabAbout.Location = New System.Drawing.Point(4, 24)
        Me.TabAbout.Name = "TabAbout"
        Me.TabAbout.Size = New System.Drawing.Size(778, 354)
        Me.TabAbout.TabIndex = 2
        Me.TabAbout.Text = "关于"
        '
        'MaterialCard3
        '
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.MaterialButton3)
        Me.MaterialCard3.Controls.Add(Me.MaterialButton1)
        Me.MaterialCard3.Controls.Add(Me.MaterialButton2)
        Me.MaterialCard3.Controls.Add(Me.Label2)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(459, 16)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(308, 343)
        Me.MaterialCard3.TabIndex = 2
        '
        'MaterialButton3
        '
        Me.MaterialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton3.Depth = 0
        Me.MaterialButton3.HighEmphasis = True
        Me.MaterialButton3.Icon = Global.NSEmuHelper.My.Resources.Resources.qq
        Me.MaterialButton3.Location = New System.Drawing.Point(20, 139)
        Me.MaterialButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton3.Name = "MaterialButton3"
        Me.MaterialButton3.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton3.Size = New System.Drawing.Size(72, 36)
        Me.MaterialButton3.TabIndex = 4
        Me.MaterialButton3.Text = "QQ"
        Me.MaterialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton3.UseAccentColor = False
        Me.MaterialButton3.UseVisualStyleBackColor = True
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Global.NSEmuHelper.My.Resources.Resources.github
        Me.MaterialButton1.Location = New System.Drawing.Point(20, 91)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(104, 36)
        Me.MaterialButton1.TabIndex = 3
        Me.MaterialButton1.Text = "GitHub"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.HighEmphasis = True
        Me.MaterialButton2.Icon = Global.NSEmuHelper.My.Resources.Resources.bilibili
        Me.MaterialButton2.Location = New System.Drawing.Point(20, 43)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton2.Size = New System.Drawing.Size(102, 36)
        Me.MaterialButton2.TabIndex = 2
        Me.MaterialButton2.Text = "Bilibili"
        Me.MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton2.UseAccentColor = False
        Me.MaterialButton2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "你可以通过以下方式联系我："
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.lblAbout)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(78, 15)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(361, 343)
        Me.MaterialCard2.TabIndex = 1
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Location = New System.Drawing.Point(17, 14)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(280, 210)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.Text = resources.GetString("lblAbout.Text")
        '
        'imgTabs
        '
        Me.imgTabs.ImageStream = CType(resources.GetObject("imgTabs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgTabs.TransparentColor = System.Drawing.Color.Transparent
        Me.imgTabs.Images.SetKeyName(0, "home.png")
        Me.imgTabs.Images.SetKeyName(1, "yuzu.png")
        Me.imgTabs.Images.SetKeyName(2, "ryujinx.png")
        Me.imgTabs.Images.SetKeyName(3, "config.png")
        Me.imgTabs.Images.SetKeyName(4, "about.png")
        '
        'TabConfig
        '
        Me.TabConfig.BackColor = System.Drawing.Color.White
        Me.TabConfig.Controls.Add(Me.MaterialCard5)
        Me.TabConfig.ImageKey = "config.png"
        Me.TabConfig.Location = New System.Drawing.Point(4, 24)
        Me.TabConfig.Name = "TabConfig"
        Me.TabConfig.Size = New System.Drawing.Size(778, 354)
        Me.TabConfig.TabIndex = 3
        Me.TabConfig.Text = "设置"
        '
        'TabRyujinx
        '
        Me.TabRyujinx.BackColor = System.Drawing.Color.White
        Me.TabRyujinx.ImageKey = "ryujinx.png"
        Me.TabRyujinx.Location = New System.Drawing.Point(4, 24)
        Me.TabRyujinx.Name = "TabRyujinx"
        Me.TabRyujinx.Size = New System.Drawing.Size(778, 354)
        Me.TabRyujinx.TabIndex = 4
        Me.TabRyujinx.Text = "Ryujinx"
        '
        'MaterialCard5
        '
        Me.MaterialCard5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard5.Controls.Add(Me.txtYuzuPath)
        Me.MaterialCard5.Controls.Add(Me.Label3)
        Me.MaterialCard5.Controls.Add(Me.lblYuzuConfig)
        Me.MaterialCard5.Controls.Add(Me.PictureBox1)
        Me.MaterialCard5.Depth = 0
        Me.MaterialCard5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard5.Location = New System.Drawing.Point(82, 16)
        Me.MaterialCard5.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard5.Name = "MaterialCard5"
        Me.MaterialCard5.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard5.Size = New System.Drawing.Size(251, 342)
        Me.MaterialCard5.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblYuzuConfig
        '
        Me.lblYuzuConfig.AutoSize = True
        Me.lblYuzuConfig.Location = New System.Drawing.Point(41, 19)
        Me.lblYuzuConfig.Name = "lblYuzuConfig"
        Me.lblYuzuConfig.Size = New System.Drawing.Size(60, 15)
        Me.lblYuzuConfig.TabIndex = 2
        Me.lblYuzuConfig.Text = "Yuzu 设置"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "安装路径"
        '
        'txtYuzuPath
        '
        Me.txtYuzuPath.AnimateReadOnly = False
        Me.txtYuzuPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtYuzuPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtYuzuPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtYuzuPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtYuzuPath.Depth = 0
        Me.txtYuzuPath.Font = New System.Drawing.Font("HarmonyOS Sans SC", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtYuzuPath.HideSelection = True
        Me.txtYuzuPath.LeadingIcon = Nothing
        Me.txtYuzuPath.Location = New System.Drawing.Point(17, 83)
        Me.txtYuzuPath.MaxLength = 32767
        Me.txtYuzuPath.MouseState = MaterialSkin.MouseState.OUT
        Me.txtYuzuPath.Name = "txtYuzuPath"
        Me.txtYuzuPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtYuzuPath.PrefixSuffixText = Nothing
        Me.txtYuzuPath.ReadOnly = False
        Me.txtYuzuPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYuzuPath.SelectedText = ""
        Me.txtYuzuPath.SelectionLength = 0
        Me.txtYuzuPath.SelectionStart = 0
        Me.txtYuzuPath.ShortcutsEnabled = True
        Me.txtYuzuPath.Size = New System.Drawing.Size(178, 48)
        Me.txtYuzuPath.TabIndex = 4
        Me.txtYuzuPath.TabStop = False
        Me.txtYuzuPath.Text = "MaterialTextBox21"
        Me.txtYuzuPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtYuzuPath.TrailingIcon = Nothing
        Me.txtYuzuPath.UseSystemPasswordChar = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 449)
        Me.Controls.Add(Me.Tabs)
        Me.DrawerShowIconsWhenHidden = True
        Me.DrawerTabControl = Me.Tabs
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(3, 80, 3, 4)
        Me.Sizable = False
        Me.Text = "NS 模拟器助手"
        Me.Tabs.ResumeLayout(False)
        Me.TabMain.ResumeLayout(False)
        Me.TabMain.PerformLayout()
        Me.MaterialCard4.ResumeLayout(False)
        Me.MaterialCard4.PerformLayout()
        CType(Me.picRyujinx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        CType(Me.picYuzu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAbout.ResumeLayout(False)
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        Me.TabConfig.ResumeLayout(False)
        Me.MaterialCard5.ResumeLayout(False)
        Me.MaterialCard5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tabs As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabMain As TabPage
    Friend WithEvents TabYuzu As TabPage
    Friend WithEvents imgTabs As ImageList
    Friend WithEvents picYuzu As PictureBox
    Friend WithEvents lblYuzu As Label
    Friend WithEvents lblYuzu2 As Label
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblYuzuFirmware As Label
    Friend WithEvents lblWelcomeMessage As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TabAbout As TabPage
    Friend WithEvents lblAbout As Label
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton3 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblRyujinxFirmware As Label
    Friend WithEvents lblRyujinx2 As Label
    Friend WithEvents lblRyujinx As Label
    Friend WithEvents picRyujinx As PictureBox
    Friend WithEvents TabConfig As TabPage
    Friend WithEvents TabRyujinx As TabPage
    Friend WithEvents MaterialCard5 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblYuzuConfig As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtYuzuPath As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label3 As Label
End Class
