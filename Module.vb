Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Module NSEmuHelperModule
    'Public AppPath As String = Application.StartupPath
    Public AppPath As String = "C:\Users\yidaozhan\source\repos\NSEmuHelper"
    Public Config As New ConfigFilePattern
    Public MainUILoaded As Boolean = False
    Public ConfigUILoaded As Boolean = False
    Public GitHubSources As New Newtonsoft.Json.Linq.JObject
    Public GitHubSourceUrl As String

    'Public Const FIREFOX_USER_AGENT As String = "Mozilla/5.0 (X11; Linux x86_64; rv:102.0) Gecko/20100101 Firefox/102.0"
    Public Const GITHUB_PUBLIC_TOKEN As String = "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"
    Public Async Function HTTPGetAsync(Url As String) As Task(Of String)
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
        Dim MyClient As New HttpClient, Response As HttpResponseMessage
        MyClient.DefaultRequestHeaders.Add("User-Agent", "NSEmuHelper/" & Application.ProductVersion)
        Try
            Response = Await MyClient.GetAsync(Url)
        Catch QWQExpection As Exception
            frmExpection.ShowMessage(QWQExpection.ToString)
            Return 255
        End Try
        Select Case Response.StatusCode
            Case 200
                Return (Await Response.Content.ReadAsStringAsync)
            Case 404
                frmExpection.ShowMessage("HTTP 错误：404 Not Found")
                End
            Case 503
                '留待备用
            Case Else
                MsgBox("HTTP 错误：" & Response.StatusCode & " " & Response.ReasonPhrase)
                End
        End Select
        Return 0
    End Function
    Public Async Function GitHubAPI(Url As String) As Task(Of String)
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
        Dim MyClient As New HttpClient, Response As HttpResponseMessage
        MyClient.DefaultRequestHeaders.Add("User-Agent", "NSEmuHelper/" & Application.ProductVersion)
        MyClient.DefaultRequestHeaders.Add("Authorization", GITHUB_PUBLIC_TOKEN)
        Try
            If Config.GitHubAPIProxy Then
                Response = Await MyClient.GetAsync(New Uri(Config.CloudflareProxyPrefix & Url))
            Else
                Response = Await MyClient.GetAsync(New Uri(Url))
            End If
        Catch QWQExpection As Exception
            frmExpection.ShowMessage(QWQExpection.ToString)
            Return 255
        End Try
        Select Case Response.StatusCode
            Case 200
                Debug.Print("GitHub API Request Completed")
                Return (Await Response.Content.ReadAsStringAsync)
            Case 404
                frmExpection.ShowMessage("HTTP 错误：404 Not Found")
                End
            Case 503
                '留待备用
            Case Else
                MsgBox("HTTP 错误：" & Response.StatusCode & " " & Response.ReasonPhrase)
                End
        End Select
        Return 0
    End Function

End Module

Module LatestVersion
    Async Function YuzuEarlyAccess() As Task(Of String)
        Try
            Return Replace(JsonConvert.DeserializeObject(Await GitHubAPI("https://api.github.com/repos/pineappleea/pineapple-src/releases"))(2)("tag_name"), "EA-", "")
        Catch QWQExpection As Exception
            frmExpection.ShowMessage("可能的解决方案：GitHub API 调用超出限制，请等一会重试。" & vbCrLf & "详细报错：" & QWQExpection.Message)
            End
        End Try
    End Function
    Async Function YuzuMainline() As Task(Of String)
        Try
            Return Replace(JsonConvert.DeserializeObject(Await GitHubAPI("https://api.github.com/repos/yuzu-emu/yuzu-mainline/releases/latest"))("tag_name"), "mainline-0-", "")
        Catch QWQExpection As Exception
            frmExpection.ShowMessage("可能的解决方案：GitHub API 调用超出限制，请等一会重试。" & vbCrLf & "详细报错：" & QWQExpection.Message)
            End
        End Try
    End Function
    Async Function Ryujinx() As Task(Of String)
        Try
            Return JsonConvert.DeserializeObject(Await GitHubAPI("https://api.github.com/repos/Ryujinx/release-channel-master/releases/latest"))("tag_name")
        Catch QWQExpection As Exception
            frmExpection.ShowMessage("可能的解决方案：GitHub API 调用超出限制，请等一会重试。" & vbCrLf & "详细报错：" & QWQExpection.Message)
            End
        End Try
    End Function
End Module