Imports Newtonsoft.Json.Linq
Module NSEmuHelperModule
    'Public AppPath As String = Application.StartupPath
    Public AppPath As String = "C:\Users\yidaozhan\source\repos\NSEmuHelper"
    Public Config As New ConfigFilePattern
    Public MainUILoaded As Boolean = False
    Public ConfigUILoaded As Boolean = False
    Public GitHubSources As New Newtonsoft.Json.Linq.JObject
    Public GitHubSourceUrl As String

    Public Const FIREFOX_USER_AGENT As String = "Mozilla/5.0 (X11; Linux x86_64; rv:102.0) Gecko/20100101 Firefox/102.0"
    Public Const GITHUB_PUBLIC_TOKEN As String = "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"
    Public Function XHRGet(Url As String) As String
        With New MSXML2.ServerXMLHTTP30
            .open("GET", Url, True)
            .setRequestHeader("User-Agent", FIREFOX_USER_AGENT)
            .send()
            .waitForResponse(60)
            Select Case .status
                Case 200
                    Return .responseText
                Case 404
                    MsgBox("HTTP 错误：404 Not Found")
                    End
                Case 503
                    '留待备用
                Case Else
                    MsgBox("HTTP 错误：" & .status & " " & .statusText)
                    End
            End Select
        End With
        Return 0
    End Function
    Public Function GitHubAPI(Url As String) As String
        With New MSXML2.ServerXMLHTTP30
            If Config.GitHubAPIProxy Then
                .open("GET", Config.CloudflareProxyPrefix & Url, True)
            Else
                .open("GET", Url, True)
            End If
            .setRequestHeader("User-Agent", "NSEmuHelper/" & Application.ProductVersion)
            .setRequestHeader("Authorization", GITHUB_PUBLIC_TOKEN)
            .send()
            .waitForResponse(60)
            Select Case .status
                Case 200
                    Return .responseText
                Case 404
                    MsgBox("HTTP 错误：404 Not Found")
                    End
                Case 503
                    '留待备用
                Case Else
                    MsgBox("HTTP 错误：" & .status & " " & .statusText)
                    End
            End Select
        End With
        Return 0
    End Function
End Module

Module LatestVersion
    Function YuzuEarlyAccess() As String
        MsgBox(Application.ProductVersion)
        Dim objJson As JObject = JObject.Parse(GitHubAPI("https://api.github.com/repos/pineappleea/pineapple-src/releases"))
        Try
            Return Replace(objJson(2)("tag_name"), "EA-", "")
        Catch
            MsgBox("GitHub API 调用超出限制，请等一会重试")
            End
        End Try
    End Function
End Module