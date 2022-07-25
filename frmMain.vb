Imports System.IO
Imports MaterialSkin, Newtonsoft.Json '第三方库
Imports Newtonsoft.Json.Linq
Imports IWshRuntimeLibrary


Public Class frmMain

    Private Declare Function GetWineVersion Lib "ntdll.dll" Alias "wine_get_version" () As String
    Public LockTab As Boolean = False
    Dim IgnoreLockTab As Boolean = False
    Dim InstallStep As Integer = 0
    Dim InstallProperties As Dictionary(Of String, Object)
    Dim InstallingEmulator As String

    '安装时候用的临时变量
    '还没有qwq
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SystemCheck()
        IntegrityCheck()
        '样式
        For Each Control In {lblYuzu, lblYuzu2, lblYuzuFirmware, lblRyujinx, lblRyujinx2, lblRyujinxFirmware, lblYuzuConfig}
            Control.Font = SkinManager.getFontByType(MaterialSkinManager.fontType.Subtitle1)
        Next

        '加载配置文件
        If My.Computer.FileSystem.FileExists(AppPath & "\Config.json") = False Then
            'MsgBox("配置文件不存在，将使用默认设置。", vbCritical)
            My.Computer.FileSystem.WriteAllText(AppPath & "\Config.json", JsonConvert.SerializeObject(New ConfigFilePattern), False)
        End If
        Config = JsonConvert.DeserializeObject(Of ConfigFilePattern)(My.Computer.FileSystem.ReadAllText(AppPath & "\Config.json"))

        '加载 GitHub 下载源
        DownloadSources = JObject.Parse(My.Resources.DownloadSources)
        For Each GitHubSource In DownloadSources
            cbDownloadSource.Items.Add(GitHubSource.Value("name"))
        Next

        '主面板
        RefreshForm()
        RefreshMain()
        MainUILoaded = True
    End Sub
    Private Sub Tabs_Selected(sender As Object, e As TabControlEventArgs) Handles Tabs.Selected
        Select Case e.TabPage.Name
            Case "TabMain"
                Me.Text = "NS 模拟器助手"
                RefreshMain()
            Case "TabYuzu"
                Me.Text = "NS 模拟器助手 - Yuzu 管理"
                RefreshYuzu()
            Case "TabRyujinx"
                Me.Text = "NS 模拟器助手 - Ryujinx 管理"
            Case "TabInstall"
                Me.Text = "NS 模拟器助手 - 安装模拟器"
            Case "TabMods"
                Me.Text = "NS 模拟器助手 - Yuzu 模组管理"
            Case "TabConfig"
                Me.Text = "NS 模拟器助手 - 设置"
                RefreshConfig()
            Case "TabAbout"
                Me.Text = "NS 模拟器助手 - 关于"
        End Select
    End Sub
    Private Sub RefreshForm()
        With SkinManager
            .AddFormToManage(Me)
            Select Case Config.ColorScheme
                Case "IndigoLight"
                    .Theme = MaterialSkinManager.Themes.LIGHT
                    SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Primary.Indigo800, TextShade.WHITE)
                Case "OrangeLight"
                    .Theme = MaterialSkinManager.Themes.LIGHT
                    SkinManager.ColorScheme = New ColorScheme(Primary.Orange500, Primary.Orange700, Primary.Orange900, Accent.DeepOrange700, TextShade.WHITE)
                Case "IndigoDark"
                    .Theme = MaterialSkinManager.Themes.DARK
                    SkinManager.ColorScheme = New ColorScheme(Primary.Indigo600, Primary.Indigo800, Primary.Indigo200, Primary.Indigo900, TextShade.WHITE)
            End Select
        End With
    End Sub
    Private Sub RefreshMain()
        If Config.YuzuVersion = "" Then
            lblYuzu.Text = "尚未安装"
            lblYuzuFirmware.Text = ""
        Else
            Select Case Config.YuzuBranch
                Case "EarlyAccess"
                    lblYuzu.Text = "预先测试版 " & Config.YuzuVersion
                Case "Mainline"
                    lblYuzu.Text = "主线版 " & Config.YuzuVersion
            End Select
            lblYuzuFirmware.Text = "固件 " & Config.YuzuFirmwareVersion
        End If
        If Config.RyujinxVersion = "" Then
            lblRyujinx.Text = "尚未安装"
            lblRyujinxFirmware.Text = ""
        Else
            lblRyujinx.Text = Config.RyujinxVersion
            lblRyujinxFirmware.Text = Config.RyujinxFirmwareVersion
        End If
    End Sub
    Private Sub RefreshYuzu()
        '处理旧版配置文件
        If Config.YuzuVersion = "" Then
            If My.Computer.FileSystem.FileExists(Config.YuzuPath & "\YuzuConfig.ini") Then
                Dim OldYuzuConfig As IniParser.Model.IniData
                With New IniParser.FileIniDataParser
                    OldYuzuConfig = .ReadFile(Config.YuzuPath & "\YuzuConfig.ini")
                End With
                Config.YuzuVersion = OldYuzuConfig.Item("Yuzu").Item("Version")
                Config.YuzuFirmwareVersion = OldYuzuConfig.Item("Yuzu").Item("Firmware")
                If OldYuzuConfig.Item("Yuzu").Item("CustomDataFolder") = "False" Then
                    Config.YuzuDataFolder = ""
                Else
                    Config.YuzuDataFolder = OldYuzuConfig.Item("Yuzu").Item("CustomDataFolder")
                End If
                '这个ini库不支持gbk，只能用字符数量来判断了qwq
                Select Case OldYuzuConfig.Item("Yuzu").Item("Branch").Length
                    Case 10
                        Config.YuzuBranch = "EarlyAccess"
                    Case 6
                        Config.YuzuBranch = "Mainline"
                End Select
                WriteConfig()
                My.Computer.FileSystem.DeleteFile(Config.YuzuPath & "\YuzuConfig.ini")
            ElseIf My.Computer.FileSystem.FileExists(Config.YuzuPath & "\yuzu.exe") Then
                Shell(Config.YuzuPath & "\yuzu.exe", vbHidden)
                Threading.Thread.Sleep(500)
                For Each OpenedProcess As Process In Process.GetProcesses()
                    If InStr(OpenedProcess.MainWindowTitle, "yuzu") Then
                        OpenedProcess.Kill()
                        If InStr(OpenedProcess.MainWindowTitle, "Early Access") Then
                            Config.YuzuBranch = "EarlyAccess"
                            Config.YuzuVersion = OpenedProcess.MainWindowTitle.Replace("yuzu Early Access ", "")
                        Else
                            Config.YuzuBranch = "Mainline"
                            Config.YuzuVersion = OpenedProcess.MainWindowTitle.Replace("yuzu ", "")
                        End If
                        Config.YuzuFirmwareVersion = "未知"
                        WriteConfig()
                        Exit For
                    End If
                Next
            End If
        End If
        If Config.YuzuVersion = "" Or Not My.Computer.FileSystem.FileExists(Config.YuzuPath & "\yuzu.exe") Then
            lblYuzuVersion.Text = "Yuzu 模拟器尚未安装"
            lblYuzuInfo.Text = "点击右下角的安装按钮，现在安装吧！"
            btnInstallYuzu.Show()
        Else
            Select Case Config.YuzuBranch
                Case "EarlyAccess"
                    lblYuzuVersion.Text = "Yuzu 预先测试版 (Early Access) " & Config.YuzuVersion
                    picYuzuBranch.Image = My.Resources.yuzu
                Case "Mainline"
                    lblYuzuVersion.Text = "Yuzu 主线版 (Mainline) " & Config.YuzuVersion
                    picYuzuBranch.Image = My.Resources.yuzu_mainline
            End Select
            lblYuzuInfo.Text = "固件 " & Config.YuzuFirmwareVersion
            If Config.YuzuDataFolder <> "" Then
                lblYuzuInfo.Text &= vbCrLf & "数据文件夹: " & Config.YuzuDataFolder
            End If
        End If
    End Sub
    Private Sub RefreshConfig()
        ConfigUILoaded = False
        txtYuzuPath.Text = Config.YuzuPath
        txtRyujinxPath.Text = Config.RyujinxPath
        Select Case Config.ColorScheme
            Case "IndigoLight"
                cbColorScheme.SelectedItem = "青色"
            Case "OrangeLight"
                cbColorScheme.SelectedItem = "橙色"
            Case "IndigoDark"
                cbColorScheme.SelectedItem = "青色 (夜间)"
        End Select
        'github
        For Each GitHubSource In DownloadSources
            If GitHubSource.Key = Config.DownloadSource Then
                cbDownloadSource.SelectedItem = GitHubSource.Value("name")
                Exit For
            End If
        Next
        checkProxyGitHubAPI.Checked = Config.GitHubAPIProxy
        ConfigUILoaded = True
    End Sub
    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs) Handles MaterialButton3.Click
        InputBox("群号", , "867575912")
    End Sub '群
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Process.Start("https://github.com/YidaozhanYa")
    End Sub 'GitHub
    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Process.Start("https://space.bilibili.com/485832788")
    End Sub 'Bilibili
    Private Sub cbColorScheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColorScheme.SelectedIndexChanged
        If Not ConfigUILoaded Then Exit Sub
        Select Case cbColorScheme.SelectedItem
            Case "青色"
                Config.ColorScheme = "IndigoLight"
            Case "橙色"
                Config.ColorScheme = "OrangeLight"
            Case "青色 (夜间)"
                Config.ColorScheme = "IndigoDark"
        End Select
        WriteConfig()
        RefreshForm()
        Refresh()
    End Sub
    Private Sub txtYuzuPath_Click(sender As Object, e As EventArgs) Handles txtYuzuPath.Click
        With New FolderBrowserDialog
            .Description = "选择 Yuzu 模拟器的安装文件夹"
            .ShowDialog()
            If .SelectedPath <> "" Then
                Config.YuzuPath = .SelectedPath
                RefreshConfig()
                WriteConfig()
            End If
        End With
    End Sub
    Private Sub txtRyujinxPath_Click(sender As Object, e As EventArgs) Handles txtRyujinxPath.Click
        With New FolderBrowserDialog
            .Description = "选择 Ryujinx 模拟器的安装文件夹"
            .ShowDialog()
            If .SelectedPath <> "" Then
                Config.RyujinxPath = .SelectedPath
                RefreshConfig()
                WriteConfig()
            End If
        End With
    End Sub
    Private Sub WriteConfig()
        My.Computer.FileSystem.WriteAllText(AppPath & "\Config.json", JsonConvert.SerializeObject(Config), False)
    End Sub
    Private Sub cbDownloadSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDownloadSource.SelectedIndexChanged
        If Not ConfigUILoaded Then Exit Sub
        MsgBox("下载源已更改为 " & cbDownloadSource.SelectedItem.ToString)
        For Each GitHubSource In DownloadSources
            Debug.Print(GitHubSource.Value("name"))
            If GitHubSource.Value("name") = cbDownloadSource.SelectedItem.ToString Then
                Config.DownloadSource = GitHubSource.Key
                WriteConfig()
                Exit For
            End If
        Next
    End Sub
    Private Sub Tabs_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles Tabs.Selecting
        If e.TabPageIndex = 3 And IgnoreLockTab = False Then e.Cancel = True
        If LockTab Then e.Cancel = True
    End Sub
    Private Sub btnInstallYuzu_Click(sender As Object, e As EventArgs) Handles btnInstallYuzu.Click
        IgnoreLockTab = True
        Tabs.SelectedTab = Tabs.TabPages(3)
        LockTab = True
        IgnoreLockTab = False
        InstallingEmulator = "Yuzu"
        YuzuPrepareInstall()
        YuzuRefreshInstall()
    End Sub
    Private Sub btnExitInstall_Click(sender As Object, e As EventArgs) Handles btnExitInstall.Click
        If frmMaterialMsgBox.YesNoBox("是否要取消安装？") = vbYes Then
            LockTab = False
            Tabs.SelectedTab = Tabs.TabPages(0)
            InstallStep = 0
        End If
    End Sub

    Private Sub YuzuRefreshInstall(Optional Previous As Boolean = False)
        If Previous = True Then
            '上一步
            Select Case InstallStep
                Case 2
                    Call YuzuPostInstallStep2(True)
                    InstallStep = 1
                    YuzuInstallStep1()
                Case 3
                    Call YuzuPostInstallStep3(True)
                    InstallStep = 2
                    YuzuInstallStep2()
            End Select
        Else
            '下一步
            Select Case InstallStep
                Case 0
                    InstallStep = 1
                    YuzuInstallStep1()
                Case 1
                    YuzuPostInstallStep1()
                    InstallStep = 2
                    YuzuInstallStep2()
                Case 2
                    If YuzuPostInstallStep2() Then
                        InstallStep = 3
                        YuzuInstallStep3()
                    End If
                Case 3
                    If YuzuPostInstallStep3() Then
                        InstallStep = 4
                        YuzuInstallProgress()
                    End If
            End Select
        End If
    End Sub
    Private Sub YuzuPrepareInstall()
        If Config.YuzuPath = "D:\Yuzu" Then
            If frmMaterialMsgBox.YesNoBox("当前模拟器安装目录为默认的 D:\Yuzu，请确认是否安装到此文件夹？") = vbNo Then
                LockTab = False
                Tabs.SelectedTab = Tabs.TabPages(0)
                InstallStep = 0
            End If
        End If
        CreateDirectory(Config.YuzuPath)
    End Sub
    Private Async Sub YuzuInstallStep1()
        InstallProperties = New Dictionary(Of String, Object)
        comboBranch.Show()
        txtVersion.Show()
        comboBranch.Enabled = False
        btnNextStep.Enabled = False '加载时暂时禁用按钮
        btnPreviousStep.Enabled = False
        InstallTitle.Text = "步骤 1 - 选择模拟器版本"
        InstallMessage.Text = "Yuzu 模拟器分两个分支：预先测试版和主线版。" & vbCrLf & "使用预先测试版可以体验到更多新功能，" & vbCrLf & "主线版比预先测试版落后几个版本，版本号也不同，" & vbCrLf & "比预先测试版更稳定。"
        Application.DoEvents()
        txtVersion.Text = Await LatestVersion.YuzuEarlyAccess
        comboBranch.Enabled = True
        btnNextStep.Enabled = True
    End Sub

    Private Sub YuzuPostInstallStep1()
        Select Case comboBranch.SelectedItem
            Case "预先测试版"
                SetProperty("Branch", "EarlyAccess")
            Case "主线版"
                SetProperty("Branch", "Mainline")
        End Select
        SetProperty("Version", txtVersion.Text.Replace(" ", ""))
        comboBranch.Hide()
        txtVersion.Hide()
    End Sub

    Private Sub YuzuInstallStep2()
        btnPreviousStep.Enabled = True
        txtKeySelector.Show()
        btnDownloadKeys.Show()
        InstallTitle.Text = "步骤 2 - 选择密钥 (Keys) 文件"
        InstallMessage.Text = "NS 模拟器需要密钥才能运行游戏。" & vbCrLf & "你可以在贴吧或相关的交流群获取密钥文件，" & vbCrLf & "或点击下面的链接以下载。"
    End Sub

    Private Function YuzuPostInstallStep2(Optional ForceTrue As Boolean = False) As Boolean
        If (txtKeySelector.Text <> "双击选择密钥文件 ..." And txtKeySelector.Text <> "") Or ForceTrue Then
            txtKeySelector.Hide()
            btnDownloadKeys.Hide()
            SetProperty("Keys", txtKeySelector.Text)
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub YuzuInstallStep3()
        btnFirmwareOnline.Show()
        btnFirmwareLocal.Show()
        txtFirmware.Show()
        comboFirmware.Show()
        lblFirmwareTip.Show()
        InstallTitle.Text = "步骤 3 - 安装固件"
        InstallMessage.Text = "在 Yuzu 中，虽然不安装固件就可以运行游戏，" & vbCrLf & "但游戏内会无法显示文字，在游玩过程中也可能崩溃，" & vbCrLf & "所以需要安装固件。"
        btnFirmwareOnline.Select()
    End Sub
    Private Function YuzuPostInstallStep3(Optional ForceTrue As Boolean = False) As Boolean
        Select Case btnFirmwareOnline.Checked
            Case True
                btnFirmwareOnline.Hide()
                btnFirmwareLocal.Hide()
                txtFirmware.Hide()
                comboFirmware.Hide()
                lblFirmwareTip.Hide()
                btnNextStep.Hide()
                btnPreviousStep.Hide()
                SetProperty("FirmwareMode", "Online")
                SetProperty("FirmwareVersion", comboFirmware.Text)
                Return True
            Case False
                If (txtFirmware.Text <> "双击选择固件包 ..." And txtFirmware.Text <> "") Or ForceTrue Then
                    btnFirmwareOnline.Hide()
                    btnFirmwareLocal.Hide()
                    txtFirmware.Hide()
                    comboFirmware.Hide()
                    lblFirmwareTip.Hide()
                    btnNextStep.Hide()
                    btnPreviousStep.Hide()
                    SetProperty("FirmwareMode", "Local")
                    SetProperty("FirmwareVersion", comboFirmware.Text)
                    SetProperty("FirmwarePath", txtFirmware.Text)
                    Return True
                Else
                    Return False
                End If
        End Select
    End Function
    Private Async Sub YuzuInstallProgress()
        Select Case InstallProperties("Branch")
            Case "EarlyAccess"
                InstallTitle.Text = "正在安装 Yuzu 预先测试版 " & InstallProperties("Version")
            Case "Mainline"
                InstallTitle.Text = "正在安装 Yuzu 主线版 " & InstallProperties("Version")
        End Select
        InstallMessage.Text = "安装可能需要几分钟，请喝杯茶并耐心等待。" & vbCrLf & "根据您的网络质量，安装速度会有所不同。"
        ProgressMajor.Show()
        ProgressMajor.Maximum = 100
        ProgressMinor.Show()
        ProgressMinor.Maximum = 100
        '创建临时文件夹
        CreateDirectory(Config.YuzuPath & "\tmp")
        CreateDirectory(Config.YuzuPath & "\tmp\fw")
        lblInstallProgress.Text = "正在准备安装 ... "
        lblInstallProgress.Show()

        lblInstallProgress.Text = "正在下载模拟器 ... "

        '创建 URL
        Dim YuzuDownloadUrl As String, YuzuFolderName As String
        Select Case DownloadSources(Config.DownloadSource)("type").ToString
            Case "github"
                Select Case InstallProperties("Branch")
                    Case "EarlyAccess"
                        YuzuFolderName = "yuzu-windows-msvc-early-access"
                        YuzuDownloadUrl = DownloadSources(Config.DownloadSource)("url").ToString &
                                          "/pineappleEA/pineapple-src/releases/download/EA-" & InstallProperties("Version") &
                                          "/Windows-Yuzu-EA-" & InstallProperties("Version") & ".7z"
                    Case "Mainline"
                        YuzuFolderName = "yuzu-windows-msvc"
                        '从github api获取具体文件url
                        Dim ghapi As JObject = JObject.Parse(Await GitHubAPI("https://api.github.com/repos/yuzu-emu/yuzu-mainline/releases/tags/mainline-0-1100"))
                        For Each ReleaseAsset As JObject In ghapi.Item("assets")
                            ReleaseAsset.CreateReader()
                            If ReleaseAsset.Item("browser_download_url").Contains("windows-msvc") And ReleaseAsset.Item("browser_download_url").Contains("7z") Then
                                YuzuDownloadUrl = ReleaseAsset.Item("browser_download_url").ToString.Replace("https://github.com", DownloadSources(Config.DownloadSource)("url").ToString)
                                Exit For
                            End If
                        Next
                End Select
            Case "onemanager"
                '云盘
                Select Case InstallProperties("Branch")
                    Case "EarlyAccess"
                        YuzuFolderName = "yuzu-windows-msvc-early-access"
                        YuzuDownloadUrl = DownloadSources(Config.DownloadSource)("url").ToString & "YuzuEarlyAccess/Windows-Yuzu-EA-" & InstallProperties("Version") & ".7z"
                    Case "Mainline"
                        YuzuFolderName = "yuzu-windows-msvc"
                        YuzuDownloadUrl = DownloadSources(Config.DownloadSource)("url").ToString & "YuzuMainline/yuzu-windows-msvc-" & InstallProperties("Version") & ".7z"
                End Select
        End Select

        '创建aria2下载对象并且下载模拟器
        With New Aria2
            .Url = YuzuDownloadUrl
            .SaveFolder = Config.YuzuPath & "\tmp"
            .SaveFileName = "Yuzu.7z"
            .StartDownload()
            Do Until .Finished
                Threading.Thread.Sleep(50)
                lblInstallProgress.Text = "正在下载模拟器 ... (" & .DownloadSpeed & "/s " & .DownloadPercentage & "% 剩余" & .ETA & ")"
                ProgressMajor.Value = Int(.DownloadPercentage / 3)
                ProgressMinor.Value = .DownloadPercentage
                Application.DoEvents()
            Loop
        End With

        lblInstallProgress.Text = "模拟器下载完成！"
        ProgressMajor.Value = 33


        '固件
        Select Case InstallProperties("FirmwareMode")
            Case "Local"
                '本地
                'skip
            Case "Online"
                '创建aria2下载对象并且下载固件
                With New Aria2
                    If Config.DownloadSource = "US3" Then
                        .Url = DownloadSources("US3")("url").ToString & "NSFirmware/Firmware_" & InstallProperties("FirmwareVersion") & ".zip"
                    Else
                        .Url = DownloadSources("OneDrive")("url").ToString
                    End If
                    .SaveFolder = Config.YuzuPath & "\tmp"
                    .SaveFileName = "Firmware.zip"
                    .StartDownload()
                    Do Until .Finished
                        Threading.Thread.Sleep(50)
                        lblInstallProgress.Text = "正在下载固件 ... (" & .DownloadSpeed & "/s " & .DownloadPercentage & "% 剩余" & .ETA & ")"
                        ProgressMajor.Value = Int(.DownloadPercentage / 3) + 33
                        ProgressMinor.Value = .DownloadPercentage
                        Application.DoEvents()
                    Loop
                End With
                While My.Computer.FileSystem.FileExists(Config.YuzuPath & "\tmp\Firmware.zip.aria2")
                    Threading.Thread.Sleep(100)
                    Application.DoEvents()
                End While
                lblInstallProgress.Text = "正在比对固件 MD5 校验码 ..."
                If MD5Sums(Config.YuzuPath & "\tmp\Firmware.zip") <> Await GetFirmwareMD5(InstallProperties("FirmwareVersion")) Then
                    MsgBox("固件包 MD5 校验码错误，请尝试重新安装模拟器！", vbCritical + vbOKOnly)
                    End
                End If

        End Select

        lblInstallProgress.Text = "固件下载完成！"
        ProgressMajor.Value = 66

        '解压缩
        lblInstallProgress.Text = "正在解压模拟器 ..."
        With New SevenZipWrapper
            .Extract(Config.YuzuPath & "\tmp\Yuzu.7z", Config.YuzuPath & "\tmp")
            While .Finished = False
                Threading.Thread.Sleep(50)
                lblInstallProgress.Text = "正在解压缩模拟器 ... (" & .PercentDone & "%)"
                ProgressMinor.Value = .PercentDone
                ProgressMajor.Value = Int(.PercentDone / 6) + 66
                Application.DoEvents()
            End While
            ProgressMinor.Value = 100
            ProgressMajor.Value = 83
        End With

        lblInstallProgress.Text = "正在安装模拟器 ..."
        FileIO.FileSystem.MoveDirectory(Config.YuzuPath & "\tmp\" & YuzuFolderName, Config.YuzuPath, True)
        For Each TarballFile In Directory.GetFiles(Config.YuzuPath, "*.xz")
            System.IO.File.Delete(TarballFile)
        Next

        Select Case InstallProperties("FirmwareMode")
            Case "Online"
                '解压缩
                lblInstallProgress.Text = "正在解压固件 ..."
                With New SevenZipWrapper
                    .Extract(Config.YuzuPath & "\tmp\Firmware.zip", Config.YuzuPath & "\tmp")
                    While .Finished = False
                        Threading.Thread.Sleep(50)
                        lblInstallProgress.Text = "正在解压固件 ... (" & .PercentDone & "%)"
                        ProgressMinor.Value = .PercentDone
                        ProgressMajor.Value = Int(.PercentDone / 6) + 66
                        Application.DoEvents()
                    End While
                    ProgressMinor.Value = 100
                    ProgressMajor.Value = 100
                End With

                ProgressMinor.Value = 0
                lblInstallProgress.Text = "正在安装固件 ..."
                CreateDirectory(Config.YuzuPath & "\user")
                CreateDirectory(Config.YuzuPath & "\user\nand")
                CreateDirectory(Config.YuzuPath & "\user\nand\system")
                CreateDirectory(Config.YuzuPath & "\user\nand\system\Contents")
                CreateDirectory(Config.YuzuPath & "\user\nand\system\Contents\registered")
                FileIO.FileSystem.MoveDirectory(Config.YuzuPath & "\tmp\fw", Config.YuzuPath & "\user\nand\system\Contents\registered", True)
            Case "Local"
                '解压缩
                lblInstallProgress.Text = "正在解压并安装固件 ..."
                CreateDirectory(Config.YuzuPath & "\user")
                CreateDirectory(Config.YuzuPath & "\user\nand")
                CreateDirectory(Config.YuzuPath & "\user\nand\system")
                CreateDirectory(Config.YuzuPath & "\user\nand\system\Contents")
                CreateDirectory(Config.YuzuPath & "\user\nand\system\Contents\registered")
                With New SevenZipWrapper
                    .Extract(InstallProperties("FirmwarePath"), Config.YuzuPath & "\user\nand\system\Contents\registered")
                    While .Finished = False
                        Threading.Thread.Sleep(50)
                        lblInstallProgress.Text = "正在解压并安装固件 ... (" & .PercentDone & "%)"
                        ProgressMinor.Value = .PercentDone
                        ProgressMajor.Value = Int(.PercentDone / 6) + 66
                        Application.DoEvents()
                    End While
                    ProgressMinor.Value = 100
                    ProgressMajor.Value = 100
                End With
        End Select
        CreateDirectory(Config.YuzuPath & "\user\keys")
        FileSystem.FileCopy(InstallProperties("Keys"), Config.YuzuPath & "\user\keys\prod.keys")

        If Not My.Computer.FileSystem.FileExists(Environment.GetEnvironmentVariable("WinDir") & "\System32\msvcp140_atomic_wait.dll") Then
            lblInstallProgress.Text = "系统中缺少 MSVC 2019 运行库，正在补全 ..."
            With New Aria2
                .Url = "https://aka.ms/vs/17/release/VC_redist.x64.exe"
                .SaveFolder = Config.YuzuPath & "\tmp"
                .SaveFileName = "vcruntime.exe"
                .StartDownload()
                Do Until .Finished
                    Threading.Thread.Sleep(50)
                    lblInstallProgress.Text = "正在下载 MSVC 2019 运行库 ... (" & .DownloadSpeed & "/s " & .DownloadPercentage & "% 剩余" & .ETA & ")"
                    ProgressMinor.Value = .DownloadPercentage
                    Application.DoEvents()
                Loop
            End With
            With New Process
                .StartInfo.FileName = Config.YuzuPath & "\tmp\vcruntime.exe"
                .StartInfo.Arguments = "/quiet"
                .Start()
                .WaitForExit()
            End With
        End If

        ProgressMajor.Hide()
        ProgressMinor.Hide()
        lblInstallProgress.Hide()

        Select Case InstallProperties("Branch")
            Case "EarlyAccess"
                InstallTitle.Text = "Yuzu 预先测试版 " & InstallProperties("Version") & " 安装完成!"
            Case "Mainline"
                InstallTitle.Text = "Yuzu 主线版 " & InstallProperties("Version") & " 安装完成!"
        End Select
        InstallMessage.Text = "现在可以启动模拟器享受游戏了！" & vbCrLf & vbCrLf & "也可以创建桌面快捷方式，以便下次游玩。"
        btnInstallLaunchYuzu.Show()
        btnInstallShortcutYuzu.Show()
        btnInstallComplete.Show()
        btnExitInstall.Hide()

        Config.YuzuBranch = InstallProperties("Branch")
        Config.YuzuFirmwareVersion = InstallProperties("FirmwareVersion")
        WriteConfig()
    End Sub
    Private Async Sub comboBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBranch.SelectedIndexChanged
        txtVersion.Enabled = False
        btnNextStep.Enabled = False '加载时暂时禁用按钮
        Select Case InstallingEmulator
            Case "Yuzu"
                Select Case comboBranch.SelectedItem
                    Case "预先测试版"
                        picInstall.Image = My.Resources.yuzu
                        txtVersion.Text = Await LatestVersion.YuzuEarlyAccess
                    Case "主线版"
                        picInstall.Image = My.Resources.yuzu_mainline
                        txtVersion.Text = Await LatestVersion.YuzuMainline
                End Select
        End Select
        txtVersion.Enabled = True
        btnNextStep.Enabled = True
    End Sub

    Private Sub btnNextStep_Click(sender As Object, e As EventArgs) Handles btnNextStep.Click
        '下一步
        Select Case InstallingEmulator
            Case "Yuzu"
                YuzuRefreshInstall()
        End Select
    End Sub

    Private Sub btnPreviousStep_Click(sender As Object, e As EventArgs) Handles btnPreviousStep.Click
        '上一步
        Select Case InstallingEmulator
            Case "Yuzu"
                YuzuRefreshInstall(True)
        End Select
    End Sub

    Private Sub txtKeySelector_DoubleClick(sender As Object, e As EventArgs) Handles txtKeySelector.DoubleClick
        '弹出密钥选择框
        With New OpenFileDialog
            .InitialDirectory = AppPath
            .Title = "选择密钥 (prod.keys) 文件"
            .DefaultExt = "keys"
            .Filter = "NS 系统密钥文件|prod.keys"
            .CheckFileExists = True
            .CheckPathExists = True
            .ShowDialog()
            txtKeySelector.Text = .FileName
        End With
    End Sub

    Private Sub SetProperty(ByVal Key As String, ByVal Value As Object)
        If InstallProperties.ContainsKey(Key) Then
            InstallProperties(Key) = Value
        Else
            InstallProperties.Add(Key, Value)
        End If
    End Sub ' 懒人改字典

    Private Sub checkProxyGitHubAPI_CheckedChanged(sender As Object, e As EventArgs) Handles checkProxyGitHubAPI.CheckedChanged
        Config.GitHubAPIProxy = checkProxyGitHubAPI.Checked
        WriteConfig()
    End Sub

    Private Sub btnDownloadKeys_Click(sender As Object, e As EventArgs) Handles btnDownloadKeys.Click
        MsgBox("文件提取码：1034" & vbCrLf & "本资源转载自吾爱模拟论坛，不属于 NS 模拟器助手", vbInformation)
        Process.Start("https://url30.ctfile.com/d/32848130-44496748-b13e91")
    End Sub

    Private Sub txtFirmware_Click(sender As Object, e As EventArgs) Handles txtFirmware.Click
        '弹出固件选择框
        With New OpenFileDialog
            .InitialDirectory = AppPath
            .Title = "选择固件压缩包"
            .DefaultExt = "zip"
            .Filter = "ZIP 固件包|*.zip|7Z 固件包|*.7z"
            .CheckFileExists = True
            .CheckPathExists = True
            .ShowDialog()
            txtFirmware.Text = .FileName
            '判断固件包版本
            If .FileName.Contains("Firmware ") Then
                comboFirmware.Text = System.IO.Path.GetFileName(.FileName).Replace("Firmware ", "").Replace(".7z", "").Replace(".zip", "")
            ElseIf .FileName.Contains("Firmware_") Then
                comboFirmware.Text = System.IO.Path.GetFileName(.FileName).Replace("Firmware_", "").Replace(".7z", "").Replace(".zip", "")
            ElseIf .FileName.Contains("registered-") Then
                comboFirmware.Text = System.IO.Path.GetFileName(.FileName).Replace("registered-", "").Replace(".7z", "").Replace(".zip", "")
            End If
        End With
    End Sub

    Private Async Sub btnFirmwareOnline_CheckedChanged(sender As Object, e As EventArgs) Handles btnFirmwareOnline.CheckedChanged
        If btnFirmwareOnline.Checked Then
            lblFirmwareTip.Text = "选择要安装的固件版本"
            comboFirmware.Text = "加载中 ..."
            comboFirmware.Enabled = False
            txtFirmware.Enabled = False
            btnFirmwareLocal.Enabled = False
            btnFirmwareOnline.Enabled = False
            btnNextStep.Enabled = False
            btnPreviousStep.Enabled = False
            comboFirmware.Items.Clear()
            For Each VersionItem As String In Await GetMirrorFirmwareList()
                comboFirmware.Items.Add(VersionItem)
            Next
            comboFirmware.Text = comboFirmware.Items(0).ToString
            comboFirmware.Enabled = True
            txtFirmware.Enabled = True
            btnFirmwareLocal.Enabled = True
            btnFirmwareOnline.Enabled = True
            btnNextStep.Enabled = True
            btnPreviousStep.Enabled = True
        End If
    End Sub

    Private Async Sub btnFirmwareLocal_CheckedChanged(sender As Object, e As EventArgs) Handles btnFirmwareLocal.CheckedChanged
        If btnFirmwareLocal.Checked Then
            lblFirmwareTip.Text = "选择压缩包内的固件版本"
            comboFirmware.Text = "加载中 ..."
            comboFirmware.Enabled = False
            txtFirmware.Enabled = False
            btnFirmwareLocal.Enabled = False
            btnFirmwareOnline.Enabled = False
            btnNextStep.Enabled = False
            btnPreviousStep.Enabled = False
            comboFirmware.Items.Clear()
            For Each VersionItem As String In Await GetFullFirmwareList()
                comboFirmware.Items.Add(VersionItem)
            Next
            comboFirmware.Text = comboFirmware.Items(0).ToString
            comboFirmware.Enabled = True
            txtFirmware.Enabled = True
            btnFirmwareLocal.Enabled = True
            btnFirmwareOnline.Enabled = True
            btnNextStep.Enabled = True
            btnPreviousStep.Enabled = True
        End If
    End Sub

    Private Sub IntegrityCheck()
        If Not My.Computer.FileSystem.FileExists(AppPath & "\Modules\aria2c.exe") Then
            MsgBox("未找到多线程下载器模块 (aria2c.exe)，程序无法启动。" & vbCrLf & "重新安装 NS 模拟器助手，" &
                vbCrLf & "或手动将 aria2c.exe 放入 Modules 文件夹可以解决问题。" & vbCrLf & vbCrLf & "请不要把这个问题反馈给作者。", vbCritical)
            End
        End If
        If Not My.Computer.FileSystem.FileExists(AppPath & "\Modules\aria2c.exe") Then
            MsgBox("未找到解压缩模块 (7z.dll)，程序无法启动。" & vbCrLf & "重新安装 NS 模拟器助手，" &
                vbCrLf & "或手动将 64 位的 7z.dll 放入 Modules 文件夹可以解决问题。" & vbCrLf & vbCrLf & "请不要把这个问题反馈给作者。", vbCritical)
            End
        End If
    End Sub

    Private Sub SystemCheck()
        Try
            MsgBox("检测到 Wine " & GetWineVersion & "。" & vbCrLf & "Wine 运行模拟器的效率很低，会闪退，且对 .NET Framework 不完美支持，会导致本软件崩溃。" & vbCrLf & "如要安装 NS 模拟器，请使用发行版自带的包管理器，或下载 Flatpak / AppImage 版模拟器。", vbCritical)
            End
        Catch ex As Exception
            'Just run normally!
        End Try
        If Not Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion").GetValue("ProductName").ToString.StartsWith("Windows 1") Then
            MsgBox("Yuzu 和 Ryujinx 的最新版本都已不支持 Windows 7 及更低版本的操作系统，" & vbCrLf & "所以不建议在此操作系统中安装。" & vbCrLf & vbCrLf & "请升级您的系统版本。", vbCritical)
            End
        End If
        If Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion").GetValue("ProductName").ToString.StartsWith("Windows 10") _
            And CInt(Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion").GetValue("ReleaseId")) < 1809 Then
            MsgBox("Yuzu 和 Ryujinx 的最新版本都已不支持 Windows 10 1809 以下版本，" & vbCrLf & "所以不建议在此操作系统中安装。" & vbCrLf & vbCrLf & "请升级您的系统版本。", vbCritical)
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("测试版本不代表最终品质")
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Shell("cmd /c taskkill /f /im aria2.exe", vbHide)
        End
    End Sub

    Private Sub btnInstallComplete_Click(sender As Object, e As EventArgs) Handles btnInstallComplete.Click
        FileIO.FileSystem.DeleteDirectory(Config.YuzuPath & "\tmp", FileIO.DeleteDirectoryOption.DeleteAllContents)
        LockTab = False
        Tabs.SelectedTab = Tabs.TabPages(0)
        InstallStep = 0
    End Sub

    Private Sub btnInstallLaunch_Click(sender As Object, e As EventArgs) Handles btnInstallLaunchYuzu.Click
        Shell(Config.YuzuPath & "\yuzu.exe")
    End Sub

    Private Sub btnInstallShortcut_Click(sender As Object, e As EventArgs) Handles btnInstallShortcutYuzu.Click
        Dim WshShell As WshShell = New WshShell()
        Dim ShortcutPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim Shortcut As IWshShortcut = CType(WshShell.CreateShortcut(ShortcutPath & "Yuzu.lnk"), IWshShortcut)
        Shortcut.TargetPath = Config.YuzuPath & "\yuzu.exe"
        Shortcut.WorkingDirectory = Config.YuzuPath
        Shortcut.Description = "Yuzu 模拟器"
        Shortcut.Save()
    End Sub
End Class
