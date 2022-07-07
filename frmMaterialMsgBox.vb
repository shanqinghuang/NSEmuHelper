Public Class frmMaterialMsgBox
    Dim IsOperated As Boolean = False
    Dim ReadyState As Integer = vbYes
    Sub MsgBox(Message As String)
        IsOperated = False
        btnOK.Show()
        btnYes.Hide()
        btnNo.Hide()
        MessageLabel.Text = Message
        Me.Show()
        Me.Activate()
        Do Until IsOperated = True
            Threading.Thread.Sleep(60)
            Application.DoEvents()
        Loop
        Me.Hide()
    End Sub
    Function YesNoBox(Message As String) As Integer
        IsOperated = False
        btnOK.Hide()
        btnYes.Show()
        btnNo.Show()
        MessageLabel.Text = Message
        Me.Show()
        Me.Activate()
        Do Until IsOperated = True
            Threading.Thread.Sleep(60)
            Application.DoEvents()
        Loop
        Me.Hide()
        Return ReadyState
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        IsOperated = True
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        ReadyState = vbNo
        IsOperated = True
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        ReadyState = vbYes
        IsOperated = True
    End Sub

    Private Sub frmMaterialMsgBox_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ReadyState = vbNo
        IsOperated = True
    End Sub
End Class