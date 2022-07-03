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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.lblRyujinxFirmware = New System.Windows.Forms.Label()
        Me.lblRyujinx2 = New System.Windows.Forms.Label()
        Me.lblRyujinx = New System.Windows.Forms.Label()
        Me.picRyujinx = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.lblYuzuFirmware = New System.Windows.Forms.Label()
        Me.lblYuzu2 = New System.Windows.Forms.Label()
        Me.lblYuzu = New System.Windows.Forms.Label()
        Me.picYuzu = New System.Windows.Forms.PictureBox()
        Me.TabYuzu = New System.Windows.Forms.TabPage()
        Me.lblYuzuInfo = New System.Windows.Forms.Label()
        Me.lblYuzuVersion = New MaterialSkin.Controls.MaterialLabel()
        Me.picYuzuBranch = New System.Windows.Forms.PictureBox()
        Me.TabRyujinx = New System.Windows.Forms.TabPage()
        Me.TabInstall = New System.Windows.Forms.TabPage()
        Me.TabMods = New System.Windows.Forms.TabPage()
        Me.TabConfig = New System.Windows.Forms.TabPage()
        Me.MaterialCard7 = New MaterialSkin.Controls.MaterialCard()
        Me.cbColorScheme = New MaterialSkin.Controls.MaterialComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        Me.cbGitHubSource = New MaterialSkin.Controls.MaterialComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaterialCard5 = New MaterialSkin.Controls.MaterialCard()
        Me.txtRyujinxPath = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtYuzuPath = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblYuzuConfig = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabAbout = New System.Windows.Forms.TabPage()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialButton3 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.imgTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.MaterialCard8 = New MaterialSkin.Controls.MaterialCard()
        Me.Tabs.SuspendLayout()
        Me.TabMain.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        CType(Me.picRyujinx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.picYuzu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabYuzu.SuspendLayout()
        CType(Me.picYuzuBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConfig.SuspendLayout()
        Me.MaterialCard7.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAbout.SuspendLayout()
        Me.MaterialCard3.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        Me.MaterialCard8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabMain)
        Me.Tabs.Controls.Add(Me.TabYuzu)
        Me.Tabs.Controls.Add(Me.TabRyujinx)
        Me.Tabs.Controls.Add(Me.TabInstall)
        Me.Tabs.Controls.Add(Me.TabMods)
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
        Me.TabMain.Controls.Add(Me.MaterialLabel1)
        Me.TabMain.Controls.Add(Me.MaterialCard4)
        Me.TabMain.Controls.Add(Me.Label1)
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
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(83, 11)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(190, 21)
        Me.MaterialLabel1.TabIndex = 6
        Me.MaterialLabel1.Text = "欢迎使用 NS 模拟器助手！"
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
        Me.TabYuzu.Controls.Add(Me.MaterialCard8)
        Me.TabYuzu.Controls.Add(Me.lblYuzuInfo)
        Me.TabYuzu.Controls.Add(Me.lblYuzuVersion)
        Me.TabYuzu.ImageKey = "yuzu.png"
        Me.TabYuzu.Location = New System.Drawing.Point(4, 24)
        Me.TabYuzu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabYuzu.Name = "TabYuzu"
        Me.TabYuzu.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabYuzu.Size = New System.Drawing.Size(778, 354)
        Me.TabYuzu.TabIndex = 1
        Me.TabYuzu.Text = "Yuzu"
        '
        'lblYuzuInfo
        '
        Me.lblYuzuInfo.AutoSize = True
        Me.lblYuzuInfo.Location = New System.Drawing.Point(78, 40)
        Me.lblYuzuInfo.Name = "lblYuzuInfo"
        Me.lblYuzuInfo.Size = New System.Drawing.Size(67, 15)
        Me.lblYuzuInfo.TabIndex = 2
        Me.lblYuzuInfo.Text = "lblYuzuInfo"
        '
        'lblYuzuVersion
        '
        Me.lblYuzuVersion.AutoSize = True
        Me.lblYuzuVersion.Depth = 0
        Me.lblYuzuVersion.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblYuzuVersion.Location = New System.Drawing.Point(83, 11)
        Me.lblYuzuVersion.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblYuzuVersion.Name = "lblYuzuVersion"
        Me.lblYuzuVersion.Size = New System.Drawing.Size(132, 21)
        Me.lblYuzuVersion.TabIndex = 1
        Me.lblYuzuVersion.Text = "Yuzu 版本 xxx 开摆"
        '
        'picYuzuBranch
        '
        Me.picYuzuBranch.Image = Global.NSEmuHelper.My.Resources.Resources.yuzu
        Me.picYuzuBranch.Location = New System.Drawing.Point(17, 8)
        Me.picYuzuBranch.Name = "picYuzuBranch"
        Me.picYuzuBranch.Size = New System.Drawing.Size(108, 122)
        Me.picYuzuBranch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYuzuBranch.TabIndex = 0
        Me.picYuzuBranch.TabStop = False
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
        'TabInstall
        '
        Me.TabInstall.BackColor = System.Drawing.Color.White
        Me.TabInstall.ImageKey = "briefcase-download.png"
        Me.TabInstall.Location = New System.Drawing.Point(4, 24)
        Me.TabInstall.Name = "TabInstall"
        Me.TabInstall.Size = New System.Drawing.Size(778, 354)
        Me.TabInstall.TabIndex = 5
        Me.TabInstall.Text = "安装"
        '
        'TabMods
        '
        Me.TabMods.BackColor = System.Drawing.Color.White
        Me.TabMods.ImageKey = "puzzle.png"
        Me.TabMods.Location = New System.Drawing.Point(4, 24)
        Me.TabMods.Name = "TabMods"
        Me.TabMods.Size = New System.Drawing.Size(778, 354)
        Me.TabMods.TabIndex = 6
        Me.TabMods.Text = "模组"
        '
        'TabConfig
        '
        Me.TabConfig.BackColor = System.Drawing.Color.White
        Me.TabConfig.Controls.Add(Me.MaterialCard7)
        Me.TabConfig.Controls.Add(Me.MaterialCard6)
        Me.TabConfig.Controls.Add(Me.MaterialCard5)
        Me.TabConfig.ImageKey = "config.png"
        Me.TabConfig.Location = New System.Drawing.Point(4, 24)
        Me.TabConfig.Name = "TabConfig"
        Me.TabConfig.Size = New System.Drawing.Size(778, 354)
        Me.TabConfig.TabIndex = 3
        Me.TabConfig.Text = "设置"
        '
        'MaterialCard7
        '
        Me.MaterialCard7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard7.Controls.Add(Me.cbColorScheme)
        Me.MaterialCard7.Controls.Add(Me.PictureBox3)
        Me.MaterialCard7.Controls.Add(Me.Label6)
        Me.MaterialCard7.Controls.Add(Me.Label7)
        Me.MaterialCard7.Depth = 0
        Me.MaterialCard7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard7.Location = New System.Drawing.Point(557, 16)
        Me.MaterialCard7.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard7.Name = "MaterialCard7"
        Me.MaterialCard7.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard7.Size = New System.Drawing.Size(205, 342)
        Me.MaterialCard7.TabIndex = 5
        '
        'cbColorScheme
        '
        Me.cbColorScheme.AutoResize = False
        Me.cbColorScheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbColorScheme.Depth = 0
        Me.cbColorScheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbColorScheme.DropDownHeight = 174
        Me.cbColorScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColorScheme.DropDownWidth = 121
        Me.cbColorScheme.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbColorScheme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbColorScheme.FormattingEnabled = True
        Me.cbColorScheme.IntegralHeight = False
        Me.cbColorScheme.ItemHeight = 43
        Me.cbColorScheme.Items.AddRange(New Object() {"青色", "橙色", "青色 (夜间)"})
        Me.cbColorScheme.Location = New System.Drawing.Point(17, 88)
        Me.cbColorScheme.MaxDropDownItems = 4
        Me.cbColorScheme.MouseState = MaterialSkin.MouseState.OUT
        Me.cbColorScheme.Name = "cbColorScheme"
        Me.cbColorScheme.Size = New System.Drawing.Size(171, 49)
        Me.cbColorScheme.StartIndex = 0
        Me.cbColorScheme.TabIndex = 6
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.NSEmuHelper.My.Resources.Resources.hammer_wrench
        Me.PictureBox3.Location = New System.Drawing.Point(12, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "颜色主题"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "工具设置"
        '
        'MaterialCard6
        '
        Me.MaterialCard6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard6.Controls.Add(Me.cbGitHubSource)
        Me.MaterialCard6.Controls.Add(Me.PictureBox2)
        Me.MaterialCard6.Controls.Add(Me.Label4)
        Me.MaterialCard6.Controls.Add(Me.Label5)
        Me.MaterialCard6.Depth = 0
        Me.MaterialCard6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard6.Location = New System.Drawing.Point(319, 16)
        Me.MaterialCard6.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard6.Name = "MaterialCard6"
        Me.MaterialCard6.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.Size = New System.Drawing.Size(205, 342)
        Me.MaterialCard6.TabIndex = 5
        '
        'cbGitHubSource
        '
        Me.cbGitHubSource.AutoResize = False
        Me.cbGitHubSource.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbGitHubSource.Depth = 0
        Me.cbGitHubSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbGitHubSource.DropDownHeight = 174
        Me.cbGitHubSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGitHubSource.DropDownWidth = 121
        Me.cbGitHubSource.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbGitHubSource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbGitHubSource.FormattingEnabled = True
        Me.cbGitHubSource.IntegralHeight = False
        Me.cbGitHubSource.ItemHeight = 43
        Me.cbGitHubSource.Location = New System.Drawing.Point(17, 89)
        Me.cbGitHubSource.MaxDropDownItems = 4
        Me.cbGitHubSource.MouseState = MaterialSkin.MouseState.OUT
        Me.cbGitHubSource.Name = "cbGitHubSource"
        Me.cbGitHubSource.Size = New System.Drawing.Size(171, 49)
        Me.cbGitHubSource.StartIndex = 0
        Me.cbGitHubSource.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NSEmuHelper.My.Resources.Resources.wan
        Me.PictureBox2.Location = New System.Drawing.Point(17, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "模拟器下载源"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "网络设置"
        '
        'MaterialCard5
        '
        Me.MaterialCard5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard5.Controls.Add(Me.txtRyujinxPath)
        Me.MaterialCard5.Controls.Add(Me.Label8)
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
        Me.MaterialCard5.Size = New System.Drawing.Size(205, 342)
        Me.MaterialCard5.TabIndex = 0
        '
        'txtRyujinxPath
        '
        Me.txtRyujinxPath.AnimateReadOnly = False
        Me.txtRyujinxPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtRyujinxPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtRyujinxPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtRyujinxPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRyujinxPath.Depth = 0
        Me.txtRyujinxPath.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtRyujinxPath.HideSelection = True
        Me.txtRyujinxPath.LeadingIcon = Nothing
        Me.txtRyujinxPath.Location = New System.Drawing.Point(17, 185)
        Me.txtRyujinxPath.MaxLength = 32767
        Me.txtRyujinxPath.MouseState = MaterialSkin.MouseState.OUT
        Me.txtRyujinxPath.Name = "txtRyujinxPath"
        Me.txtRyujinxPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRyujinxPath.PrefixSuffixText = Nothing
        Me.txtRyujinxPath.ReadOnly = False
        Me.txtRyujinxPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRyujinxPath.SelectedText = ""
        Me.txtRyujinxPath.SelectionLength = 0
        Me.txtRyujinxPath.SelectionStart = 0
        Me.txtRyujinxPath.ShortcutsEnabled = True
        Me.txtRyujinxPath.Size = New System.Drawing.Size(171, 48)
        Me.txtRyujinxPath.TabIndex = 6
        Me.txtRyujinxPath.TabStop = False
        Me.txtRyujinxPath.Text = "MaterialTextBox21"
        Me.txtRyujinxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtRyujinxPath.TrailingIcon = Nothing
        Me.txtRyujinxPath.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Ryujinx 安装路径"
        '
        'txtYuzuPath
        '
        Me.txtYuzuPath.AnimateReadOnly = False
        Me.txtYuzuPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtYuzuPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtYuzuPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtYuzuPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtYuzuPath.Depth = 0
        Me.txtYuzuPath.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtYuzuPath.HideSelection = True
        Me.txtYuzuPath.LeadingIcon = Nothing
        Me.txtYuzuPath.Location = New System.Drawing.Point(17, 89)
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
        Me.txtYuzuPath.Size = New System.Drawing.Size(171, 48)
        Me.txtYuzuPath.TabIndex = 4
        Me.txtYuzuPath.TabStop = False
        Me.txtYuzuPath.Text = "MaterialTextBox21"
        Me.txtYuzuPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtYuzuPath.TrailingIcon = Nothing
        Me.txtYuzuPath.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Yuzu 安装路径"
        '
        'lblYuzuConfig
        '
        Me.lblYuzuConfig.AutoSize = True
        Me.lblYuzuConfig.Location = New System.Drawing.Point(42, 19)
        Me.lblYuzuConfig.Name = "lblYuzuConfig"
        Me.lblYuzuConfig.Size = New System.Drawing.Size(67, 15)
        Me.lblYuzuConfig.TabIndex = 2
        Me.lblYuzuConfig.Text = "模拟器设置"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NSEmuHelper.My.Resources.Resources.nintendo_switch
        Me.PictureBox1.Location = New System.Drawing.Point(17, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
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
        Me.MaterialButton3.Size = New System.Drawing.Size(71, 36)
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
        Me.MaterialButton1.Size = New System.Drawing.Size(103, 36)
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
        Me.MaterialButton2.Size = New System.Drawing.Size(101, 36)
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
        Me.lblAbout.Size = New System.Drawing.Size(280, 180)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.Text = "NS 模拟器助手 —— 简单高效的 NS 模拟器管理工具" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "版本 2.0.0 Beta 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "© 2022 是一刀斩哒" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "本程序使用了以下开源项目" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- rc" &
    "lone" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Aria2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Newtonsoft.Json" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- MaterialSkin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Powered by Visual Basic .NET" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ".NET Framework 4.5"
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
        Me.imgTabs.Images.SetKeyName(5, "briefcase-download.png")
        Me.imgTabs.Images.SetKeyName(6, "puzzle.png")
        '
        'MaterialCard8
        '
        Me.MaterialCard8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard8.Controls.Add(Me.picYuzuBranch)
        Me.MaterialCard8.Depth = 0
        Me.MaterialCard8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard8.Location = New System.Drawing.Point(619, 18)
        Me.MaterialCard8.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard8.Name = "MaterialCard8"
        Me.MaterialCard8.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.Size = New System.Drawing.Size(142, 138)
        Me.MaterialCard8.TabIndex = 3
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
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_40
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
        Me.TabYuzu.ResumeLayout(False)
        Me.TabYuzu.PerformLayout()
        CType(Me.picYuzuBranch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConfig.ResumeLayout(False)
        Me.MaterialCard7.ResumeLayout(False)
        Me.MaterialCard7.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard6.ResumeLayout(False)
        Me.MaterialCard6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard5.ResumeLayout(False)
        Me.MaterialCard5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAbout.ResumeLayout(False)
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        Me.MaterialCard8.ResumeLayout(False)
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
    Friend WithEvents Label3 As Label
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtYuzuPath As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard7 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtRyujinxPath As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label8 As Label
    Friend WithEvents cbColorScheme As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cbGitHubSource As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents TabInstall As TabPage
    Friend WithEvents TabMods As TabPage
    Friend WithEvents picYuzuBranch As PictureBox
    Friend WithEvents lblYuzuVersion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblYuzuInfo As Label
    Friend WithEvents MaterialCard8 As MaterialSkin.Controls.MaterialCard
End Class
