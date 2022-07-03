Imports MaterialSkin, Newtonsoft.Json '第三方库
Imports Newtonsoft.Json.Linq

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With SkinManager
            .AddFormToManage(Me)
            .Theme = MaterialSkinManager.Themes.LIGHT
            .ColorScheme = New ColorScheme(Primary.Orange500, Primary.Orange700, Primary.Orange900, Accent.DeepOrange700, TextShade.WHITE)
            'lblWelcomeMessage.Font = SkinManager.getFontByType(MaterialSkinManager.fontType.Body2)
        End With

        '样式
        For Each Control In {lblYuzu, lblYuzu2, lblYuzuFirmware, lblRyujinx, lblRyujinx2, lblRyujinxFirmware, lblYuzuConfig}
            Control.Font = SkinManager.getFontByType(MaterialSkinManager.fontType.Subtitle1)
        Next
        txtYuzuPath.Font = SkinManager.getFontByType(MaterialSkinManager.fontType.Body1)

        '加载配置文件
        If My.Computer.FileSystem.FileExists(AppPath & "\Config.json") = False Then
            MsgBox("配置文件不存在，将使用默认设置。", vbCritical)
            FSO.WriteAllText(AppPath & "\Config.json", JsonConvert.SerializeObject(New ConfigFilePattern), False)
        End If
        Config = JObject.Parse(FSO.ReadAllText(AppPath & "\Config.json"))

        '主面板
        RefreshMain()

    End Sub

    Private Sub Tabs_Selected(sender As Object, e As TabControlEventArgs) Handles Tabs.Selected
        Select Case e.TabPage.Name
            Case "TabMain"
                Me.Text = "NS 模拟器助手"
                RefreshMain()
            Case "TabYuzu"
                Me.Text = "NS 模拟器助手 - Yuzu 管理"
            Case "TabRyujinx"
                Me.Text = "NS 模拟器助手 - Ryujinx 管理"
            Case "TabConfig"
                Me.Text = "NS 模拟器助手 - 设置"
            Case "TabAbout"
                Me.Text = "NS 模拟器助手 - 关于"
        End Select
    End Sub

    Private Sub RefreshMain()
        If Config("YuzuVersion") = "" Then
            lblYuzu.Text = "尚未安装"
            lblYuzuFirmware.Text = ""
        End If
        If Config("RyujinxVersion") = "" Then
            lblRyujinx.Text = "尚未安装"
            lblRyujinxFirmware.Text = ""
        End If
    End Sub
    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs) Handles MaterialButton3.Click
        InputBox("群号", , "867575912")
    End Sub
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Process.Start("https://github.com/YidaozhanYa")
    End Sub
    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Process.Start("https://space.bilibili.com/485832788")
    End Sub

End Class
