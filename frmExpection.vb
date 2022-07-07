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
        MaterialMultiLineTextBox21.Text = Message
        Me.Show()
    End Sub
    Private Sub frmExpection_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Height = Me.Height - 111
        Refresh()
    End Sub
End Class