Imports MaterialSkin, Newtonsoft.Json '第三方库
Imports Newtonsoft.Json.Linq


Public Class frmMain

    Public LockTab As Boolean = False
    Dim IgnoreLockTab As Boolean = False
    Dim InstallStep As Integer = 0
    Dim InstallProperties As Dictionary(Of String, Object)
    Dim InstallingEmulator As String
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Select Case InstallStep
            Case 0
                InstallStep = 1
                YuzuInstallStep1()
            Case 1
                YuzuPostInstallStep1()
                InstallStep = 2
                YuzuInstallStep2()
        End Select
    End Sub
    Private Sub YuzuPrepareInstall()
        If Config.YuzuPath = "D:\Yuzu" Then
            If frmMaterialMsgBox.YesNoBox("当前模拟器安装目录为默认的 D:\Yuzu，请确认是否安装到此文件夹？") = vbNo Then
                LockTab = False
                Tabs.SelectedTab = Tabs.TabPages(0)
                InstallStep = 0
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Config.YuzuPath) Then My.Computer.FileSystem.CreateDirectory(Config.YuzuPath)
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

    Private Async Sub YuzuInstallStep2()
        btnPreviousStep.Enabled = True
        txtKeySelector.Show()
        InstallTitle.Text = "步骤 2 - 选择密钥 (Keys) 文件"
        InstallMessage.Text = "NS 模拟器需要密钥才能运行游戏。" & vbCrLf & "你可以在贴吧或相关的交流群获取密钥文件。"

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
        '上一步
        Select Case InstallingEmulator
            Case "Yuzu"
                YuzuRefreshInstall()
        End Select
    End Sub

    Private Sub btnPreviousStep_Click(sender As Object, e As EventArgs) Handles btnPreviousStep.Click
        '下一步
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
End Class
