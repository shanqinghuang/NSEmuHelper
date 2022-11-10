Imports MaterialSkin

Public Class frmExpection
    Private Sub frmExpection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With SkinManager
            .AddFormToManage(Me)
            .Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Orange500, Primary.Orange700, Primary.Orange900, Accent.DeepOrange700, TextShade.WHITE)
        End With
    End Sub

    Sub ShowMessage(Message As String)
        MaterialMultiLineTextBox21.Text = ""
        If Message.Contains("Http") Then
            MaterialMultiLineTextBox21.Text &= "出现网络错误，请在设置中更换下载源之后重试。" & vbCrLf
        End If
        If Message.Contains("127.0.0.1") Then
            MaterialMultiLineTextBox21.Text &= "出现 DNS 解析错误，请更换您系统的 DNS。" & vbCrLf
        End If
        MaterialMultiLineTextBox21.Text &= "--- 崩溃报告如下 ---" & vbCrLf & Message
        Me.Show()
    End Sub
    Private Sub frmExpection_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Height = Me.Height - 111
        Refresh()
    End Sub
End Class