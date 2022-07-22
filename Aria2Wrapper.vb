Imports System.Text.RegularExpressions

Public Class Aria2
    Public WithEvents Aria2Timer As New Timer

    Public Aria2Process As New Process
    Public Property Url As String
    Public Property SaveFolder As String
    Public Property SaveFileName As String
    Public Property Splits As Short = 2
    Public Property Connections As Short = 4
    Public Property OtherFlags As String = ""
    Public Property Started As Boolean = False
    Public Property Finished As Boolean = False
    Public Property DownloadPercentage As Integer = 0
    Public Property DownloadSpeed As String = "0KiB/s"
    Public Property ETA As String = ""
    Public Sub StartDownload()
        With Aria2Process
            .StartInfo.FileName = AppPath & "\Modules\aria2c.exe"
            .StartInfo.Arguments = "--split=" & Splits & " --max-connection-per-server=" & Connections & " --dir=""" & SaveFolder & """ --out=""" & SaveFileName & """ --continue=true " & OtherFlags & " """ & Url & """"
            .StartInfo.UseShellExecute = False
            .StartInfo.RedirectStandardOutput = True
            .StartInfo.RedirectStandardError = True
            .StartInfo.CreateNoWindow = True
            .Start()
        End With
        Aria2Timer.Interval = 100
        Aria2Timer.Enabled = True
        Started = True
    End Sub
    Private Sub Aria2Timer_Tick(sender As Object, e As EventArgs) Handles Aria2Timer.Tick '刷新
        Try
            Dim OutputLine As String = Aria2Process.StandardOutput.ReadLine
            If OutputLine.Contains("%") Then DownloadPercentage = CInt(New Regex("\(.*?\%\)").Match(OutputLine).ToString.Replace("(", "").Replace("%)", "").Trim)
            If OutputLine.Contains("DL:") Then DownloadSpeed = New Regex("DL\:.*? ").Match(OutputLine).ToString.Replace("DL:", "").Trim
            If OutputLine.Contains("ETA:") Then ETA = New Regex("ETA\:.*?\]").Match(OutputLine).ToString.Replace("ETA:", "").Replace("]", "").Trim
            If OutputLine.Contains("completed.") Then
                Finished = True
                Aria2Timer.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
