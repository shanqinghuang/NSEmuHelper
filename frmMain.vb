Imports MaterialSkin, Newtonsoft.Json '第三方库
Imports Newtonsoft.Json.Linq


Public Class frmMain

    Public IsInstalling As Boolean = False
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
        GitHubSources = JObject.Parse(My.Resources.GitHubSources)
        For Each GitHubSource In GitHubSources
            cbGitHubSource.Items.Add(GitHubSource.Value("name"))
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
        For Each GitHubSource In GitHubSources
            If GitHubSource.Key = Config.GitHubSource Then
                cbGitHubSource.SelectedItem = GitHubSource.Value("name")
                Exit For
            End If
        Next
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
    '设置
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
    Private Sub cbGitHubSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGitHubSource.SelectedIndexChanged
        If Not ConfigUILoaded Then Exit Sub
        MsgBox(cbGitHubSource.SelectedItem.ToString)
        For Each GitHubSource In GitHubSources
            Debug.Print(GitHubSource.Value("name"))
            If GitHubSource.Value("name") = cbGitHubSource.SelectedItem.ToString Then
                Config.GitHubSource = GitHubSource.Key
                WriteConfig()
                Exit For
            End If
        Next
    End Sub

    Private Sub Tabs_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles Tabs.Selecting
        If IsInstalling Then e.Cancel = True
    End Sub

    Private Sub btnInstallYuzu_Click(sender As Object, e As EventArgs) Handles btnInstallYuzu.Click
        IsInstalling = True
        Tabs.SelectedTab = Tabs.TabPages(3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(LatestVersion.YuzuEarlyAccess())
    End Sub
End Class
