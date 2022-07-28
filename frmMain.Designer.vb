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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.btnYuzuChangeKey = New MaterialSkin.Controls.MaterialButton()
        Me.btnYuzuUpdateFirmware = New MaterialSkin.Controls.MaterialButton()
        Me.btnUpdateYuzu = New MaterialSkin.Controls.MaterialButton()
        Me.btnYuzuCheckUpdate = New MaterialSkin.Controls.MaterialButton()
        Me.btnLaunchYuzu = New MaterialSkin.Controls.MaterialButton()
        Me.btnInstallYuzu = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard8 = New MaterialSkin.Controls.MaterialCard()
        Me.picYuzuBranch = New System.Windows.Forms.PictureBox()
        Me.lblYuzuInfo = New System.Windows.Forms.Label()
        Me.lblYuzuVersion = New MaterialSkin.Controls.MaterialLabel()
        Me.TabRyujinx = New System.Windows.Forms.TabPage()
        Me.btnRyujinxChangeKey = New MaterialSkin.Controls.MaterialButton()
        Me.btnRyujinxUpdateFirmware = New MaterialSkin.Controls.MaterialButton()
        Me.btnUpdateRyujinx = New MaterialSkin.Controls.MaterialButton()
        Me.btnRyujinxCheckUpdate = New MaterialSkin.Controls.MaterialButton()
        Me.btnLaunchRyujinx = New MaterialSkin.Controls.MaterialButton()
        Me.btnInstallRyujinx = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard10 = New MaterialSkin.Controls.MaterialCard()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblRyujinxInfo = New System.Windows.Forms.Label()
        Me.lblRyujinxVersion = New MaterialSkin.Controls.MaterialLabel()
        Me.TabInstall = New System.Windows.Forms.TabPage()
        Me.btnInstallComplete = New MaterialSkin.Controls.MaterialButton()
        Me.btnInstallLaunch = New MaterialSkin.Controls.MaterialButton()
        Me.btnInstallShortcut = New MaterialSkin.Controls.MaterialButton()
        Me.lblInstallProgress = New System.Windows.Forms.Label()
        Me.ProgressMinor = New MaterialSkin.Controls.MaterialProgressBar()
        Me.ProgressMajor = New MaterialSkin.Controls.MaterialProgressBar()
        Me.txtFirmware = New MaterialSkin.Controls.MaterialTextBox2()
        Me.lblFirmwareTip = New System.Windows.Forms.Label()
        Me.btnFirmwareLocal = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnFirmwareOnline = New MaterialSkin.Controls.MaterialRadioButton()
        Me.comboFirmware = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnDownloadKeys = New MaterialSkin.Controls.MaterialButton()
        Me.txtKeySelector = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btnPreviousStep = New MaterialSkin.Controls.MaterialButton()
        Me.btnNextStep = New MaterialSkin.Controls.MaterialButton()
        Me.txtVersion = New MaterialSkin.Controls.MaterialTextBox2()
        Me.comboBranch = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialCard9 = New MaterialSkin.Controls.MaterialCard()
        Me.picInstall = New System.Windows.Forms.PictureBox()
        Me.btnExitInstall = New MaterialSkin.Controls.MaterialButton()
        Me.InstallMessage = New System.Windows.Forms.Label()
        Me.InstallTitle = New MaterialSkin.Controls.MaterialLabel()
        Me.TabMods = New System.Windows.Forms.TabPage()
        Me.TabConfig = New System.Windows.Forms.TabPage()
        Me.MaterialCard7 = New MaterialSkin.Controls.MaterialCard()
        Me.btnCheckUpdate = New MaterialSkin.Controls.MaterialButton()
        Me.cbColorScheme = New MaterialSkin.Controls.MaterialComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.checkProxyGitHubAPI = New MaterialSkin.Controls.MaterialCheckbox()
        Me.cbDownloadSource = New MaterialSkin.Controls.MaterialComboBox()
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
        Me.FormToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tabs.SuspendLayout()
        Me.TabMain.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        CType(Me.picRyujinx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.picYuzu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabYuzu.SuspendLayout()
        Me.MaterialCard8.SuspendLayout()
        CType(Me.picYuzuBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabRyujinx.SuspendLayout()
        Me.MaterialCard10.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabInstall.SuspendLayout()
        Me.MaterialCard9.SuspendLayout()
        CType(Me.picInstall, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabMain.Controls.Add(Me.Label10)
        Me.TabMain.Controls.Add(Me.Button1)
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(78, 321)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 15)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "测试版本不代表最终品质"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(675, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 48)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "测试用" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "请勿点击"
        Me.FormToolTip.SetToolTip(Me.Button1, "测试按钮")
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
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
        Me.TabYuzu.Controls.Add(Me.btnYuzuChangeKey)
        Me.TabYuzu.Controls.Add(Me.btnYuzuUpdateFirmware)
        Me.TabYuzu.Controls.Add(Me.btnUpdateYuzu)
        Me.TabYuzu.Controls.Add(Me.btnYuzuCheckUpdate)
        Me.TabYuzu.Controls.Add(Me.btnLaunchYuzu)
        Me.TabYuzu.Controls.Add(Me.btnInstallYuzu)
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
        'btnYuzuChangeKey
        '
        Me.btnYuzuChangeKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnYuzuChangeKey.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnYuzuChangeKey.Depth = 0
        Me.btnYuzuChangeKey.HighEmphasis = True
        Me.btnYuzuChangeKey.Icon = Nothing
        Me.btnYuzuChangeKey.Location = New System.Drawing.Point(271, 322)
        Me.btnYuzuChangeKey.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnYuzuChangeKey.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnYuzuChangeKey.Name = "btnYuzuChangeKey"
        Me.btnYuzuChangeKey.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnYuzuChangeKey.Size = New System.Drawing.Size(79, 36)
        Me.btnYuzuChangeKey.TabIndex = 26
        Me.btnYuzuChangeKey.Text = "更换密钥"
        Me.btnYuzuChangeKey.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnYuzuChangeKey.UseAccentColor = False
        Me.btnYuzuChangeKey.UseVisualStyleBackColor = True
        '
        'btnYuzuUpdateFirmware
        '
        Me.btnYuzuUpdateFirmware.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnYuzuUpdateFirmware.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnYuzuUpdateFirmware.Depth = 0
        Me.btnYuzuUpdateFirmware.HighEmphasis = True
        Me.btnYuzuUpdateFirmware.Icon = Nothing
        Me.btnYuzuUpdateFirmware.Location = New System.Drawing.Point(486, 322)
        Me.btnYuzuUpdateFirmware.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnYuzuUpdateFirmware.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnYuzuUpdateFirmware.Name = "btnYuzuUpdateFirmware"
        Me.btnYuzuUpdateFirmware.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnYuzuUpdateFirmware.Size = New System.Drawing.Size(79, 36)
        Me.btnYuzuUpdateFirmware.TabIndex = 25
        Me.btnYuzuUpdateFirmware.Text = "更新固件"
        Me.btnYuzuUpdateFirmware.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnYuzuUpdateFirmware.UseAccentColor = False
        Me.btnYuzuUpdateFirmware.UseVisualStyleBackColor = True
        '
        'btnUpdateYuzu
        '
        Me.btnUpdateYuzu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdateYuzu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnUpdateYuzu.Depth = 0
        Me.btnUpdateYuzu.HighEmphasis = True
        Me.btnUpdateYuzu.Icon = Nothing
        Me.btnUpdateYuzu.Location = New System.Drawing.Point(378, 322)
        Me.btnUpdateYuzu.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnUpdateYuzu.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUpdateYuzu.Name = "btnUpdateYuzu"
        Me.btnUpdateYuzu.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnUpdateYuzu.Size = New System.Drawing.Size(79, 36)
        Me.btnUpdateYuzu.TabIndex = 24
        Me.btnUpdateYuzu.Text = "切换版本"
        Me.btnUpdateYuzu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnUpdateYuzu.UseAccentColor = False
        Me.btnUpdateYuzu.UseVisualStyleBackColor = True
        '
        'btnYuzuCheckUpdate
        '
        Me.btnYuzuCheckUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnYuzuCheckUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnYuzuCheckUpdate.Depth = 0
        Me.btnYuzuCheckUpdate.HighEmphasis = True
        Me.btnYuzuCheckUpdate.Icon = Nothing
        Me.btnYuzuCheckUpdate.Location = New System.Drawing.Point(592, 322)
        Me.btnYuzuCheckUpdate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnYuzuCheckUpdate.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnYuzuCheckUpdate.Name = "btnYuzuCheckUpdate"
        Me.btnYuzuCheckUpdate.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnYuzuCheckUpdate.Size = New System.Drawing.Size(79, 36)
        Me.btnYuzuCheckUpdate.TabIndex = 23
        Me.btnYuzuCheckUpdate.Text = "检查更新"
        Me.btnYuzuCheckUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnYuzuCheckUpdate.UseAccentColor = False
        Me.btnYuzuCheckUpdate.UseVisualStyleBackColor = True
        '
        'btnLaunchYuzu
        '
        Me.btnLaunchYuzu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLaunchYuzu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnLaunchYuzu.Depth = 0
        Me.btnLaunchYuzu.HighEmphasis = True
        Me.btnLaunchYuzu.Icon = Nothing
        Me.btnLaunchYuzu.Location = New System.Drawing.Point(697, 322)
        Me.btnLaunchYuzu.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnLaunchYuzu.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLaunchYuzu.Name = "btnLaunchYuzu"
        Me.btnLaunchYuzu.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnLaunchYuzu.Size = New System.Drawing.Size(64, 36)
        Me.btnLaunchYuzu.TabIndex = 22
        Me.btnLaunchYuzu.Text = "启动"
        Me.btnLaunchYuzu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnLaunchYuzu.UseAccentColor = True
        Me.btnLaunchYuzu.UseVisualStyleBackColor = True
        '
        'btnInstallYuzu
        '
        Me.btnInstallYuzu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInstallYuzu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnInstallYuzu.Depth = 0
        Me.btnInstallYuzu.HighEmphasis = True
        Me.btnInstallYuzu.Icon = Nothing
        Me.btnInstallYuzu.Location = New System.Drawing.Point(697, 322)
        Me.btnInstallYuzu.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnInstallYuzu.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnInstallYuzu.Name = "btnInstallYuzu"
        Me.btnInstallYuzu.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnInstallYuzu.Size = New System.Drawing.Size(64, 36)
        Me.btnInstallYuzu.TabIndex = 4
        Me.btnInstallYuzu.Text = "安装"
        Me.btnInstallYuzu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnInstallYuzu.UseAccentColor = False
        Me.btnInstallYuzu.UseVisualStyleBackColor = True
        Me.btnInstallYuzu.Visible = False
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
        'picYuzuBranch
        '
        Me.picYuzuBranch.Image = Global.NSEmuHelper.My.Resources.Resources.yuzu_mainline
        Me.picYuzuBranch.Location = New System.Drawing.Point(17, 8)
        Me.picYuzuBranch.Name = "picYuzuBranch"
        Me.picYuzuBranch.Size = New System.Drawing.Size(108, 122)
        Me.picYuzuBranch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYuzuBranch.TabIndex = 0
        Me.picYuzuBranch.TabStop = False
        '
        'lblYuzuInfo
        '
        Me.lblYuzuInfo.AutoSize = True
        Me.lblYuzuInfo.Location = New System.Drawing.Point(78, 40)
        Me.lblYuzuInfo.Name = "lblYuzuInfo"
        Me.lblYuzuInfo.Size = New System.Drawing.Size(57, 15)
        Me.lblYuzuInfo.TabIndex = 2
        Me.lblYuzuInfo.Text = "Yuzu Info"
        '
        'lblYuzuVersion
        '
        Me.lblYuzuVersion.AutoSize = True
        Me.lblYuzuVersion.Depth = 0
        Me.lblYuzuVersion.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblYuzuVersion.Location = New System.Drawing.Point(83, 11)
        Me.lblYuzuVersion.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblYuzuVersion.Name = "lblYuzuVersion"
        Me.lblYuzuVersion.Size = New System.Drawing.Size(100, 21)
        Me.lblYuzuVersion.TabIndex = 1
        Me.lblYuzuVersion.Text = "Yuzu 版本 xxx "
        '
        'TabRyujinx
        '
        Me.TabRyujinx.BackColor = System.Drawing.Color.White
        Me.TabRyujinx.Controls.Add(Me.btnRyujinxChangeKey)
        Me.TabRyujinx.Controls.Add(Me.btnRyujinxUpdateFirmware)
        Me.TabRyujinx.Controls.Add(Me.btnUpdateRyujinx)
        Me.TabRyujinx.Controls.Add(Me.btnRyujinxCheckUpdate)
        Me.TabRyujinx.Controls.Add(Me.btnLaunchRyujinx)
        Me.TabRyujinx.Controls.Add(Me.btnInstallRyujinx)
        Me.TabRyujinx.Controls.Add(Me.MaterialCard10)
        Me.TabRyujinx.Controls.Add(Me.lblRyujinxInfo)
        Me.TabRyujinx.Controls.Add(Me.lblRyujinxVersion)
        Me.TabRyujinx.ImageKey = "ryujinx.png"
        Me.TabRyujinx.Location = New System.Drawing.Point(4, 24)
        Me.TabRyujinx.Name = "TabRyujinx"
        Me.TabRyujinx.Size = New System.Drawing.Size(778, 354)
        Me.TabRyujinx.TabIndex = 4
        Me.TabRyujinx.Text = "Ryujinx"
        '
        'btnRyujinxChangeKey
        '
        Me.btnRyujinxChangeKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRyujinxChangeKey.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnRyujinxChangeKey.Depth = 0
        Me.btnRyujinxChangeKey.HighEmphasis = True
        Me.btnRyujinxChangeKey.Icon = Nothing
        Me.btnRyujinxChangeKey.Location = New System.Drawing.Point(271, 322)
        Me.btnRyujinxChangeKey.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRyujinxChangeKey.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRyujinxChangeKey.Name = "btnRyujinxChangeKey"
        Me.btnRyujinxChangeKey.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnRyujinxChangeKey.Size = New System.Drawing.Size(79, 36)
        Me.btnRyujinxChangeKey.TabIndex = 34
        Me.btnRyujinxChangeKey.Text = "更换密钥"
        Me.btnRyujinxChangeKey.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnRyujinxChangeKey.UseAccentColor = False
        Me.btnRyujinxChangeKey.UseVisualStyleBackColor = True
        '
        'btnRyujinxUpdateFirmware
        '
        Me.btnRyujinxUpdateFirmware.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRyujinxUpdateFirmware.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnRyujinxUpdateFirmware.Depth = 0
        Me.btnRyujinxUpdateFirmware.HighEmphasis = True
        Me.btnRyujinxUpdateFirmware.Icon = Nothing
        Me.btnRyujinxUpdateFirmware.Location = New System.Drawing.Point(486, 322)
        Me.btnRyujinxUpdateFirmware.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRyujinxUpdateFirmware.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRyujinxUpdateFirmware.Name = "btnRyujinxUpdateFirmware"
        Me.btnRyujinxUpdateFirmware.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnRyujinxUpdateFirmware.Size = New System.Drawing.Size(79, 36)
        Me.btnRyujinxUpdateFirmware.TabIndex = 33
        Me.btnRyujinxUpdateFirmware.Text = "更新固件"
        Me.btnRyujinxUpdateFirmware.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnRyujinxUpdateFirmware.UseAccentColor = False
        Me.btnRyujinxUpdateFirmware.UseVisualStyleBackColor = True
        '
        'btnUpdateRyujinx
        '
        Me.btnUpdateRyujinx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdateRyujinx.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnUpdateRyujinx.Depth = 0
        Me.btnUpdateRyujinx.HighEmphasis = True
        Me.btnUpdateRyujinx.Icon = Nothing
        Me.btnUpdateRyujinx.Location = New System.Drawing.Point(378, 322)
        Me.btnUpdateRyujinx.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnUpdateRyujinx.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUpdateRyujinx.Name = "btnUpdateRyujinx"
        Me.btnUpdateRyujinx.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnUpdateRyujinx.Size = New System.Drawing.Size(79, 36)
        Me.btnUpdateRyujinx.TabIndex = 32
        Me.btnUpdateRyujinx.Text = "切换版本"
        Me.btnUpdateRyujinx.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnUpdateRyujinx.UseAccentColor = False
        Me.btnUpdateRyujinx.UseVisualStyleBackColor = True
        '
        'btnRyujinxCheckUpdate
        '
        Me.btnRyujinxCheckUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRyujinxCheckUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnRyujinxCheckUpdate.Depth = 0
        Me.btnRyujinxCheckUpdate.HighEmphasis = True
        Me.btnRyujinxCheckUpdate.Icon = Nothing
        Me.btnRyujinxCheckUpdate.Location = New System.Drawing.Point(592, 322)
        Me.btnRyujinxCheckUpdate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRyujinxCheckUpdate.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRyujinxCheckUpdate.Name = "btnRyujinxCheckUpdate"
        Me.btnRyujinxCheckUpdate.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnRyujinxCheckUpdate.Size = New System.Drawing.Size(79, 36)
        Me.btnRyujinxCheckUpdate.TabIndex = 31
        Me.btnRyujinxCheckUpdate.Text = "检查更新"
        Me.btnRyujinxCheckUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnRyujinxCheckUpdate.UseAccentColor = False
        Me.btnRyujinxCheckUpdate.UseVisualStyleBackColor = True
        '
        'btnLaunchRyujinx
        '
        Me.btnLaunchRyujinx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLaunchRyujinx.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnLaunchRyujinx.Depth = 0
        Me.btnLaunchRyujinx.HighEmphasis = True
        Me.btnLaunchRyujinx.Icon = Nothing
        Me.btnLaunchRyujinx.Location = New System.Drawing.Point(697, 322)
        Me.btnLaunchRyujinx.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnLaunchRyujinx.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLaunchRyujinx.Name = "btnLaunchRyujinx"
        Me.btnLaunchRyujinx.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnLaunchRyujinx.Size = New System.Drawing.Size(64, 36)
        Me.btnLaunchRyujinx.TabIndex = 30
        Me.btnLaunchRyujinx.Text = "启动"
        Me.btnLaunchRyujinx.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnLaunchRyujinx.UseAccentColor = True
        Me.btnLaunchRyujinx.UseVisualStyleBackColor = True
        '
        'btnInstallRyujinx
        '
        Me.btnInstallRyujinx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInstallRyujinx.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnInstallRyujinx.Depth = 0
        Me.btnInstallRyujinx.HighEmphasis = True
        Me.btnInstallRyujinx.Icon = Nothing
        Me.btnInstallRyujinx.Location = New System.Drawing.Point(697, 322)
        Me.btnInstallRyujinx.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnInstallRyujinx.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnInstallRyujinx.Name = "btnInstallRyujinx"
        Me.btnInstallRyujinx.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnInstallRyujinx.Size = New System.Drawing.Size(64, 36)
        Me.btnInstallRyujinx.TabIndex = 29
        Me.btnInstallRyujinx.Text = "安装"
        Me.btnInstallRyujinx.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnInstallRyujinx.UseAccentColor = False
        Me.btnInstallRyujinx.UseVisualStyleBackColor = True
        Me.btnInstallRyujinx.Visible = False
        '
        'MaterialCard10
        '
        Me.MaterialCard10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard10.Controls.Add(Me.PictureBox4)
        Me.MaterialCard10.Depth = 0
        Me.MaterialCard10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard10.Location = New System.Drawing.Point(619, 18)
        Me.MaterialCard10.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard10.Name = "MaterialCard10"
        Me.MaterialCard10.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard10.Size = New System.Drawing.Size(142, 138)
        Me.MaterialCard10.TabIndex = 28
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.NSEmuHelper.My.Resources.Resources.ryujinx
        Me.PictureBox4.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(125, 122)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'lblRyujinxInfo
        '
        Me.lblRyujinxInfo.AutoSize = True
        Me.lblRyujinxInfo.Location = New System.Drawing.Point(78, 40)
        Me.lblRyujinxInfo.Name = "lblRyujinxInfo"
        Me.lblRyujinxInfo.Size = New System.Drawing.Size(69, 15)
        Me.lblRyujinxInfo.TabIndex = 27
        Me.lblRyujinxInfo.Text = "Ryujinx Info"
        '
        'lblRyujinxVersion
        '
        Me.lblRyujinxVersion.AutoSize = True
        Me.lblRyujinxVersion.Depth = 0
        Me.lblRyujinxVersion.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblRyujinxVersion.Location = New System.Drawing.Point(83, 11)
        Me.lblRyujinxVersion.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblRyujinxVersion.Name = "lblRyujinxVersion"
        Me.lblRyujinxVersion.Size = New System.Drawing.Size(117, 21)
        Me.lblRyujinxVersion.TabIndex = 26
        Me.lblRyujinxVersion.Text = "Ryujinx 版本 xxx "
        '
        'TabInstall
        '
        Me.TabInstall.BackColor = System.Drawing.Color.White
        Me.TabInstall.Controls.Add(Me.btnInstallComplete)
        Me.TabInstall.Controls.Add(Me.btnInstallLaunch)
        Me.TabInstall.Controls.Add(Me.btnInstallShortcut)
        Me.TabInstall.Controls.Add(Me.lblInstallProgress)
        Me.TabInstall.Controls.Add(Me.ProgressMinor)
        Me.TabInstall.Controls.Add(Me.ProgressMajor)
        Me.TabInstall.Controls.Add(Me.txtFirmware)
        Me.TabInstall.Controls.Add(Me.lblFirmwareTip)
        Me.TabInstall.Controls.Add(Me.btnFirmwareLocal)
        Me.TabInstall.Controls.Add(Me.btnFirmwareOnline)
        Me.TabInstall.Controls.Add(Me.comboFirmware)
        Me.TabInstall.Controls.Add(Me.btnDownloadKeys)
        Me.TabInstall.Controls.Add(Me.txtKeySelector)
        Me.TabInstall.Controls.Add(Me.btnPreviousStep)
        Me.TabInstall.Controls.Add(Me.btnNextStep)
        Me.TabInstall.Controls.Add(Me.txtVersion)
        Me.TabInstall.Controls.Add(Me.comboBranch)
        Me.TabInstall.Controls.Add(Me.MaterialCard9)
        Me.TabInstall.Controls.Add(Me.btnExitInstall)
        Me.TabInstall.Controls.Add(Me.InstallMessage)
        Me.TabInstall.Controls.Add(Me.InstallTitle)
        Me.TabInstall.ImageKey = "briefcase-download.png"
        Me.TabInstall.Location = New System.Drawing.Point(4, 24)
        Me.TabInstall.Name = "TabInstall"
        Me.TabInstall.Size = New System.Drawing.Size(778, 354)
        Me.TabInstall.TabIndex = 5
        Me.TabInstall.Text = "安装"
        '
        'btnInstallComplete
        '
        Me.btnInstallComplete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInstallComplete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnInstallComplete.Depth = 0
        Me.btnInstallComplete.HighEmphasis = True
        Me.btnInstallComplete.Icon = Nothing
        Me.btnInstallComplete.Location = New System.Drawing.Point(87, 322)
        Me.btnInstallComplete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnInstallComplete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnInstallComplete.Name = "btnInstallComplete"
        Me.btnInstallComplete.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnInstallComplete.Size = New System.Drawing.Size(64, 36)
        Me.btnInstallComplete.TabIndex = 22
        Me.btnInstallComplete.Text = "返回"
        Me.btnInstallComplete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnInstallComplete.UseAccentColor = False
        Me.btnInstallComplete.UseVisualStyleBackColor = True
        Me.btnInstallComplete.Visible = False
        '
        'btnInstallLaunch
        '
        Me.btnInstallLaunch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInstallLaunch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnInstallLaunch.Depth = 0
        Me.btnInstallLaunch.HighEmphasis = True
        Me.btnInstallLaunch.Icon = Nothing
        Me.btnInstallLaunch.Location = New System.Drawing.Point(682, 322)
        Me.btnInstallLaunch.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnInstallLaunch.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnInstallLaunch.Name = "btnInstallLaunch"
        Me.btnInstallLaunch.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnInstallLaunch.Size = New System.Drawing.Size(64, 36)
        Me.btnInstallLaunch.TabIndex = 21
        Me.btnInstallLaunch.Text = "启动"
        Me.btnInstallLaunch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnInstallLaunch.UseAccentColor = False
        Me.btnInstallLaunch.UseVisualStyleBackColor = True
        Me.btnInstallLaunch.Visible = False
        '
        'btnInstallShortcut
        '
        Me.btnInstallShortcut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInstallShortcut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnInstallShortcut.Depth = 0
        Me.btnInstallShortcut.HighEmphasis = True
        Me.btnInstallShortcut.Icon = Nothing
        Me.btnInstallShortcut.Location = New System.Drawing.Point(528, 322)
        Me.btnInstallShortcut.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnInstallShortcut.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnInstallShortcut.Name = "btnInstallShortcut"
        Me.btnInstallShortcut.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnInstallShortcut.Size = New System.Drawing.Size(136, 36)
        Me.btnInstallShortcut.TabIndex = 20
        Me.btnInstallShortcut.Text = "创建桌面快捷方式"
        Me.btnInstallShortcut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnInstallShortcut.UseAccentColor = False
        Me.btnInstallShortcut.UseVisualStyleBackColor = True
        Me.btnInstallShortcut.Visible = False
        '
        'lblInstallProgress
        '
        Me.lblInstallProgress.AutoSize = True
        Me.lblInstallProgress.Location = New System.Drawing.Point(84, 205)
        Me.lblInstallProgress.Name = "lblInstallProgress"
        Me.lblInstallProgress.Size = New System.Drawing.Size(67, 15)
        Me.lblInstallProgress.TabIndex = 19
        Me.lblInstallProgress.Text = "安装提示捏"
        Me.lblInstallProgress.Visible = False
        '
        'ProgressMinor
        '
        Me.ProgressMinor.Depth = 0
        Me.ProgressMinor.Location = New System.Drawing.Point(87, 186)
        Me.ProgressMinor.MouseState = MaterialSkin.MouseState.HOVER
        Me.ProgressMinor.Name = "ProgressMinor"
        Me.ProgressMinor.Size = New System.Drawing.Size(508, 5)
        Me.ProgressMinor.TabIndex = 18
        Me.ProgressMinor.Visible = False
        '
        'ProgressMajor
        '
        Me.ProgressMajor.Depth = 0
        Me.ProgressMajor.Location = New System.Drawing.Point(87, 160)
        Me.ProgressMajor.MouseState = MaterialSkin.MouseState.HOVER
        Me.ProgressMajor.Name = "ProgressMajor"
        Me.ProgressMajor.Size = New System.Drawing.Size(508, 5)
        Me.ProgressMajor.TabIndex = 17
        Me.ProgressMajor.Visible = False
        '
        'txtFirmware
        '
        Me.txtFirmware.AnimateReadOnly = False
        Me.txtFirmware.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtFirmware.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtFirmware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtFirmware.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFirmware.Depth = 0
        Me.txtFirmware.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtFirmware.HideSelection = True
        Me.txtFirmware.LeadingIcon = Nothing
        Me.txtFirmware.Location = New System.Drawing.Point(205, 201)
        Me.txtFirmware.MaxLength = 32767
        Me.txtFirmware.MouseState = MaterialSkin.MouseState.OUT
        Me.txtFirmware.Name = "txtFirmware"
        Me.txtFirmware.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirmware.PrefixSuffixText = Nothing
        Me.txtFirmware.ReadOnly = False
        Me.txtFirmware.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFirmware.SelectedText = ""
        Me.txtFirmware.SelectionLength = 0
        Me.txtFirmware.SelectionStart = 0
        Me.txtFirmware.ShortcutsEnabled = True
        Me.txtFirmware.Size = New System.Drawing.Size(390, 48)
        Me.txtFirmware.TabIndex = 16
        Me.txtFirmware.TabStop = False
        Me.txtFirmware.Text = "双击选择固件包 ..."
        Me.txtFirmware.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFirmware.TrailingIcon = Nothing
        Me.txtFirmware.UseSystemPasswordChar = False
        Me.txtFirmware.Visible = False
        '
        'lblFirmwareTip
        '
        Me.lblFirmwareTip.AutoSize = True
        Me.lblFirmwareTip.Location = New System.Drawing.Point(406, 149)
        Me.lblFirmwareTip.Name = "lblFirmwareTip"
        Me.lblFirmwareTip.Size = New System.Drawing.Size(67, 15)
        Me.lblFirmwareTip.TabIndex = 15
        Me.lblFirmwareTip.Text = "固件提示捏"
        Me.lblFirmwareTip.Visible = False
        '
        'btnFirmwareLocal
        '
        Me.btnFirmwareLocal.AutoSize = True
        Me.btnFirmwareLocal.Depth = 0
        Me.btnFirmwareLocal.Location = New System.Drawing.Point(80, 206)
        Me.btnFirmwareLocal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFirmwareLocal.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.btnFirmwareLocal.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFirmwareLocal.Name = "btnFirmwareLocal"
        Me.btnFirmwareLocal.Ripple = True
        Me.btnFirmwareLocal.Size = New System.Drawing.Size(99, 37)
        Me.btnFirmwareLocal.TabIndex = 14
        Me.btnFirmwareLocal.TabStop = True
        Me.btnFirmwareLocal.Text = "本地安装"
        Me.btnFirmwareLocal.UseVisualStyleBackColor = True
        Me.btnFirmwareLocal.Visible = False
        '
        'btnFirmwareOnline
        '
        Me.btnFirmwareOnline.AutoSize = True
        Me.btnFirmwareOnline.Depth = 0
        Me.btnFirmwareOnline.Location = New System.Drawing.Point(80, 140)
        Me.btnFirmwareOnline.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFirmwareOnline.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.btnFirmwareOnline.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFirmwareOnline.Name = "btnFirmwareOnline"
        Me.btnFirmwareOnline.Ripple = True
        Me.btnFirmwareOnline.Size = New System.Drawing.Size(99, 37)
        Me.btnFirmwareOnline.TabIndex = 13
        Me.btnFirmwareOnline.TabStop = True
        Me.btnFirmwareOnline.Text = "在线安装"
        Me.btnFirmwareOnline.UseVisualStyleBackColor = True
        Me.btnFirmwareOnline.Visible = False
        '
        'comboFirmware
        '
        Me.comboFirmware.AutoResize = False
        Me.comboFirmware.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboFirmware.Depth = 0
        Me.comboFirmware.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.comboFirmware.DropDownHeight = 174
        Me.comboFirmware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboFirmware.DropDownWidth = 121
        Me.comboFirmware.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.comboFirmware.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.comboFirmware.FormattingEnabled = True
        Me.comboFirmware.IntegralHeight = False
        Me.comboFirmware.ItemHeight = 43
        Me.comboFirmware.Location = New System.Drawing.Point(205, 134)
        Me.comboFirmware.MaxDropDownItems = 4
        Me.comboFirmware.MouseState = MaterialSkin.MouseState.OUT
        Me.comboFirmware.Name = "comboFirmware"
        Me.comboFirmware.Size = New System.Drawing.Size(181, 49)
        Me.comboFirmware.StartIndex = 0
        Me.comboFirmware.TabIndex = 12
        Me.comboFirmware.Visible = False
        '
        'btnDownloadKeys
        '
        Me.btnDownloadKeys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDownloadKeys.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnDownloadKeys.Depth = 0
        Me.btnDownloadKeys.HighEmphasis = True
        Me.btnDownloadKeys.Icon = Nothing
        Me.btnDownloadKeys.Location = New System.Drawing.Point(471, 322)
        Me.btnDownloadKeys.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDownloadKeys.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDownloadKeys.Name = "btnDownloadKeys"
        Me.btnDownloadKeys.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnDownloadKeys.Size = New System.Drawing.Size(108, 36)
        Me.btnDownloadKeys.TabIndex = 11
        Me.btnDownloadKeys.Text = "下载密钥文件"
        Me.btnDownloadKeys.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnDownloadKeys.UseAccentColor = False
        Me.btnDownloadKeys.UseVisualStyleBackColor = True
        Me.btnDownloadKeys.Visible = False
        '
        'txtKeySelector
        '
        Me.txtKeySelector.AnimateReadOnly = False
        Me.txtKeySelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtKeySelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtKeySelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtKeySelector.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtKeySelector.Depth = 0
        Me.txtKeySelector.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtKeySelector.HideSelection = True
        Me.txtKeySelector.LeadingIcon = Nothing
        Me.txtKeySelector.Location = New System.Drawing.Point(87, 171)
        Me.txtKeySelector.MaxLength = 32767
        Me.txtKeySelector.MouseState = MaterialSkin.MouseState.OUT
        Me.txtKeySelector.Name = "txtKeySelector"
        Me.txtKeySelector.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKeySelector.PrefixSuffixText = Nothing
        Me.txtKeySelector.ReadOnly = False
        Me.txtKeySelector.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKeySelector.SelectedText = ""
        Me.txtKeySelector.SelectionLength = 0
        Me.txtKeySelector.SelectionStart = 0
        Me.txtKeySelector.ShortcutsEnabled = True
        Me.txtKeySelector.Size = New System.Drawing.Size(515, 48)
        Me.txtKeySelector.TabIndex = 10
        Me.txtKeySelector.TabStop = False
        Me.txtKeySelector.Text = "双击选择密钥文件 ..."
        Me.txtKeySelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtKeySelector.TrailingIcon = Nothing
        Me.txtKeySelector.UseSystemPasswordChar = False
        Me.txtKeySelector.Visible = False
        '
        'btnPreviousStep
        '
        Me.btnPreviousStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPreviousStep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnPreviousStep.Depth = 0
        Me.btnPreviousStep.HighEmphasis = True
        Me.btnPreviousStep.Icon = Nothing
        Me.btnPreviousStep.Location = New System.Drawing.Point(600, 322)
        Me.btnPreviousStep.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPreviousStep.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPreviousStep.Name = "btnPreviousStep"
        Me.btnPreviousStep.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnPreviousStep.Size = New System.Drawing.Size(64, 36)
        Me.btnPreviousStep.TabIndex = 9
        Me.btnPreviousStep.Text = "上一步"
        Me.btnPreviousStep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnPreviousStep.UseAccentColor = False
        Me.btnPreviousStep.UseVisualStyleBackColor = True
        '
        'btnNextStep
        '
        Me.btnNextStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNextStep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnNextStep.Depth = 0
        Me.btnNextStep.HighEmphasis = True
        Me.btnNextStep.Icon = Nothing
        Me.btnNextStep.Location = New System.Drawing.Point(682, 322)
        Me.btnNextStep.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNextStep.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNextStep.Name = "btnNextStep"
        Me.btnNextStep.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnNextStep.Size = New System.Drawing.Size(64, 36)
        Me.btnNextStep.TabIndex = 8
        Me.btnNextStep.Text = "下一步"
        Me.btnNextStep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnNextStep.UseAccentColor = False
        Me.btnNextStep.UseVisualStyleBackColor = True
        '
        'txtVersion
        '
        Me.txtVersion.AnimateReadOnly = False
        Me.txtVersion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtVersion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtVersion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVersion.Depth = 0
        Me.txtVersion.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtVersion.HideSelection = True
        Me.txtVersion.LeadingIcon = Nothing
        Me.txtVersion.Location = New System.Drawing.Point(286, 171)
        Me.txtVersion.MaxLength = 32767
        Me.txtVersion.MouseState = MaterialSkin.MouseState.OUT
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVersion.PrefixSuffixText = Nothing
        Me.txtVersion.ReadOnly = False
        Me.txtVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVersion.SelectedText = ""
        Me.txtVersion.SelectionLength = 0
        Me.txtVersion.SelectionStart = 0
        Me.txtVersion.ShortcutsEnabled = True
        Me.txtVersion.Size = New System.Drawing.Size(151, 48)
        Me.txtVersion.TabIndex = 7
        Me.txtVersion.TabStop = False
        Me.txtVersion.Text = "加载中 ..."
        Me.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtVersion.TrailingIcon = Nothing
        Me.txtVersion.UseSystemPasswordChar = False
        '
        'comboBranch
        '
        Me.comboBranch.AutoResize = False
        Me.comboBranch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboBranch.Depth = 0
        Me.comboBranch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.comboBranch.DropDownHeight = 174
        Me.comboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBranch.DropDownWidth = 121
        Me.comboBranch.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.comboBranch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.comboBranch.FormattingEnabled = True
        Me.comboBranch.IntegralHeight = False
        Me.comboBranch.ItemHeight = 43
        Me.comboBranch.Items.AddRange(New Object() {"预先测试版", "主线版"})
        Me.comboBranch.Location = New System.Drawing.Point(87, 170)
        Me.comboBranch.MaxDropDownItems = 4
        Me.comboBranch.MouseState = MaterialSkin.MouseState.OUT
        Me.comboBranch.Name = "comboBranch"
        Me.comboBranch.Size = New System.Drawing.Size(164, 49)
        Me.comboBranch.StartIndex = 0
        Me.comboBranch.TabIndex = 6
        '
        'MaterialCard9
        '
        Me.MaterialCard9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard9.Controls.Add(Me.picInstall)
        Me.MaterialCard9.Depth = 0
        Me.MaterialCard9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard9.Location = New System.Drawing.Point(619, 18)
        Me.MaterialCard9.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard9.Name = "MaterialCard9"
        Me.MaterialCard9.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard9.Size = New System.Drawing.Size(142, 138)
        Me.MaterialCard9.TabIndex = 5
        '
        'picInstall
        '
        Me.picInstall.Image = Global.NSEmuHelper.My.Resources.Resources.yuzu
        Me.picInstall.Location = New System.Drawing.Point(17, 8)
        Me.picInstall.Name = "picInstall"
        Me.picInstall.Size = New System.Drawing.Size(108, 122)
        Me.picInstall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInstall.TabIndex = 0
        Me.picInstall.TabStop = False
        '
        'btnExitInstall
        '
        Me.btnExitInstall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExitInstall.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnExitInstall.Depth = 0
        Me.btnExitInstall.HighEmphasis = True
        Me.btnExitInstall.Icon = Nothing
        Me.btnExitInstall.Location = New System.Drawing.Point(87, 322)
        Me.btnExitInstall.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExitInstall.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExitInstall.Name = "btnExitInstall"
        Me.btnExitInstall.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnExitInstall.Size = New System.Drawing.Size(79, 36)
        Me.btnExitInstall.TabIndex = 4
        Me.btnExitInstall.Text = "取消安装"
        Me.btnExitInstall.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnExitInstall.UseAccentColor = False
        Me.btnExitInstall.UseVisualStyleBackColor = True
        '
        'InstallMessage
        '
        Me.InstallMessage.Location = New System.Drawing.Point(84, 51)
        Me.InstallMessage.Name = "InstallMessage"
        Me.InstallMessage.Size = New System.Drawing.Size(518, 126)
        Me.InstallMessage.TabIndex = 3
        Me.InstallMessage.Text = "火星文"
        '
        'InstallTitle
        '
        Me.InstallTitle.AutoSize = True
        Me.InstallTitle.Depth = 0
        Me.InstallTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.InstallTitle.Location = New System.Drawing.Point(87, 18)
        Me.InstallTitle.MouseState = MaterialSkin.MouseState.HOVER
        Me.InstallTitle.Name = "InstallTitle"
        Me.InstallTitle.Size = New System.Drawing.Size(81, 21)
        Me.InstallTitle.TabIndex = 2
        Me.InstallTitle.Text = "安装大消息"
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
        Me.MaterialCard7.Controls.Add(Me.btnCheckUpdate)
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
        'btnCheckUpdate
        '
        Me.btnCheckUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCheckUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnCheckUpdate.Depth = 0
        Me.btnCheckUpdate.HighEmphasis = True
        Me.btnCheckUpdate.Icon = Nothing
        Me.btnCheckUpdate.Location = New System.Drawing.Point(108, 286)
        Me.btnCheckUpdate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCheckUpdate.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCheckUpdate.Name = "btnCheckUpdate"
        Me.btnCheckUpdate.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnCheckUpdate.Size = New System.Drawing.Size(79, 36)
        Me.btnCheckUpdate.TabIndex = 7
        Me.btnCheckUpdate.Text = "检查更新"
        Me.btnCheckUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCheckUpdate.UseAccentColor = False
        Me.btnCheckUpdate.UseVisualStyleBackColor = True
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
        Me.PictureBox3.Location = New System.Drawing.Point(17, 17)
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
        Me.MaterialCard6.Controls.Add(Me.Label9)
        Me.MaterialCard6.Controls.Add(Me.checkProxyGitHubAPI)
        Me.MaterialCard6.Controls.Add(Me.cbDownloadSource)
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "下载相关选项"
        '
        'checkProxyGitHubAPI
        '
        Me.checkProxyGitHubAPI.AutoSize = True
        Me.checkProxyGitHubAPI.Depth = 0
        Me.checkProxyGitHubAPI.Location = New System.Drawing.Point(12, 185)
        Me.checkProxyGitHubAPI.Margin = New System.Windows.Forms.Padding(0)
        Me.checkProxyGitHubAPI.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.checkProxyGitHubAPI.MouseState = MaterialSkin.MouseState.HOVER
        Me.checkProxyGitHubAPI.Name = "checkProxyGitHubAPI"
        Me.checkProxyGitHubAPI.ReadOnly = False
        Me.checkProxyGitHubAPI.Ripple = True
        Me.checkProxyGitHubAPI.Size = New System.Drawing.Size(179, 37)
        Me.checkProxyGitHubAPI.TabIndex = 7
        Me.checkProxyGitHubAPI.Text = "始终代理 GitHub API"
        Me.FormToolTip.SetToolTip(Me.checkProxyGitHubAPI, "始终使用 CloudFlare 反向代理 GitHub API")
        Me.checkProxyGitHubAPI.UseVisualStyleBackColor = True
        '
        'cbDownloadSource
        '
        Me.cbDownloadSource.AutoResize = False
        Me.cbDownloadSource.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbDownloadSource.Depth = 0
        Me.cbDownloadSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbDownloadSource.DropDownHeight = 174
        Me.cbDownloadSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDownloadSource.DropDownWidth = 121
        Me.cbDownloadSource.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbDownloadSource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbDownloadSource.FormattingEnabled = True
        Me.cbDownloadSource.IntegralHeight = False
        Me.cbDownloadSource.ItemHeight = 43
        Me.cbDownloadSource.Location = New System.Drawing.Point(17, 89)
        Me.cbDownloadSource.MaxDropDownItems = 4
        Me.cbDownloadSource.MouseState = MaterialSkin.MouseState.OUT
        Me.cbDownloadSource.Name = "cbDownloadSource"
        Me.cbDownloadSource.Size = New System.Drawing.Size(171, 49)
        Me.cbDownloadSource.StartIndex = 0
        Me.cbDownloadSource.TabIndex = 6
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
        Me.lblAbout.Size = New System.Drawing.Size(280, 165)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.Text = "NS 模拟器助手 —— 简单高效的 NS 模拟器管理工具" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "版本 2.0.0 Beta 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "© 2022 是一刀斩哒" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "本程序使用了以下开源项目" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- ar" &
    "ia2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Newtonsoft.Json" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- MaterialSkin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Powered by Visual Basic .NET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ".NET Fra" &
    "mework 4.5"
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
        Me.MaximizeBox = False
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
        Me.MaterialCard8.ResumeLayout(False)
        CType(Me.picYuzuBranch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabRyujinx.ResumeLayout(False)
        Me.TabRyujinx.PerformLayout()
        Me.MaterialCard10.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabInstall.ResumeLayout(False)
        Me.TabInstall.PerformLayout()
        Me.MaterialCard9.ResumeLayout(False)
        CType(Me.picInstall, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cbDownloadSource As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents TabInstall As TabPage
    Friend WithEvents TabMods As TabPage
    Friend WithEvents picYuzuBranch As PictureBox
    Friend WithEvents lblYuzuVersion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblYuzuInfo As Label
    Friend WithEvents MaterialCard8 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents btnInstallYuzu As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Button1 As Button
    Friend WithEvents InstallMessage As Label
    Friend WithEvents InstallTitle As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnExitInstall As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard9 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents picInstall As PictureBox
    Friend WithEvents comboBranch As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtVersion As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnPreviousStep As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnNextStep As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtKeySelector As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label9 As Label
    Friend WithEvents checkProxyGitHubAPI As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents btnCheckUpdate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnDownloadKeys As MaterialSkin.Controls.MaterialButton
    Friend WithEvents comboFirmware As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnFirmwareOnline As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txtFirmware As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents lblFirmwareTip As Label
    Friend WithEvents btnFirmwareLocal As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents ProgressMinor As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents ProgressMajor As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents lblInstallProgress As Label
    Friend WithEvents FormToolTip As ToolTip
    Friend WithEvents btnInstallLaunch As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnInstallShortcut As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnInstallComplete As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label10 As Label
    Friend WithEvents btnLaunchYuzu As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnYuzuCheckUpdate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUpdateYuzu As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnYuzuUpdateFirmware As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnRyujinxUpdateFirmware As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUpdateRyujinx As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnRyujinxCheckUpdate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnLaunchRyujinx As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnInstallRyujinx As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard10 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblRyujinxInfo As Label
    Friend WithEvents btnYuzuChangeKey As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnRyujinxChangeKey As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblRyujinxVersion As MaterialSkin.Controls.MaterialLabel
End Class
