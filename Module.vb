Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Xml
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Module NSEmuHelperModule
    'Public AppPath As String = Application.StartupPath
    Public AppPath As String = "C:\Users\yidaozhan\source\repos\NSEmuHelper"
    Public Config As New ConfigFilePattern
    Public MainUILoaded As Boolean = False
    Public ConfigUILoaded As Boolean = False
    Public DownloadSources As New Newtonsoft.Json.Linq.JObject

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
                MsgBox("发生错误")
            Case 503
                '留待备用
            Case Else
                MsgBox("HTTP 错误：" & Response.StatusCode & " " & Response.ReasonPhrase)
                End
        End Select
        Return 0
    End Function

    Public Async Function GetMirrorFirmwareList() As Task(Of ArrayList)
        Dim FirmwareList As New ArrayList, FirmwareJSON As JObject, FirmwareAPIURL As String
        If Config.DownloadSource = "US3" Then
            FirmwareAPIURL = DownloadSources("US3")("url").ToString
        Else
            FirmwareAPIURL = DownloadSources("OneDrive")("url").ToString
        End If
        FirmwareAPIURL &= "NSFirmware/?json"
        FirmwareJSON = JObject.Parse(Await HTTPGetAsync(FirmwareAPIURL))
        For Each VersionObject As JProperty In FirmwareJSON.Item("list")
            VersionObject.CreateReader()
            FirmwareList.Add(VersionObject.Value("name").ToString.Replace(".zip", "").Replace("Firmware_", ""))
        Next
        FirmwareList.Sort()
        FirmwareList.Reverse()
        Return FirmwareList
    End Function

    Public Async Function GetFullFirmwareList() As Task(Of ArrayList)
        Dim FirmwareList As New ArrayList, tmpFirmwareVersion As String
        Dim FirmwareXML As New XmlDocument
        FirmwareXML.LoadXml(Await HTTPGetAsync(Config.CloudflareProxyPrefix & "https://archive.org/download/nintendo-switch-global-firmwares/nintendo-switch-global-firmwares_files.xml"))
        Dim FirmwareNodeList As XmlNodeList = FirmwareXML.SelectNodes("/files/file")
        For Each FirmwareNode As XmlNode In FirmwareNodeList
            tmpFirmwareVersion = FirmwareNode.Attributes("name").Value
            If tmpFirmwareVersion.Contains(".zip") Then
                tmpFirmwareVersion = tmpFirmwareVersion.Replace("Firmware ", "").Replace(".zip", "")
                If CInt(tmpFirmwareVersion.Split(".")(0)) >= 10 Then
                    FirmwareList.Add(tmpFirmwareVersion)
                End If
            End If
        Next
        FirmwareList.Sort()
        FirmwareList.Reverse()
        Return FirmwareList
    End Function

    Public Async Function GetFirmwareMD5(FirmwareVersion As String) As Task(Of String)
        Dim MD5Text As String = Await HTTPGetAsync("https://archive.org/download/nintendo-switch-global-firmwares/Official%20Global%20Firmware%20MD5%20Hashs.txt")
        For Each Line As String In MD5Text.Replace(Chr(9), "/").Replace("Firmware ", "").Split(vbCrLf)
            If Line.Split("/")(0).Replace(vbLf, "") = FirmwareVersion Then Return Line.Split("/").Last
        Next
        Return 0
    End Function

    Public Function MD5Sums(FilePath As String)
        With System.Security.Cryptography.MD5.Create()
            Return BitConverter.ToString(.ComputeHash(File.OpenRead(FilePath))).Replace("-", "").ToLower
        End With
    End Function '算文件md5
    Public Sub CreateDirectory(FolderPath As String)
        Try
            If Not My.Computer.FileSystem.DirectoryExists(FolderPath) Then My.Computer.FileSystem.CreateDirectory(FolderPath)
        Catch ex As Exception
            frmExpection.ShowMessage(ex.Message)
            MsgBox("文件系统访问错误") '仅用于暂停程序
        End Try
    End Sub '懒人创建文件夹

    Public Enum EmulatorType
        Yuzu = 1
        Ryujinx = 2
        YuzuUpdate = 3
        YuzuFirmware = 4
        RyujinxUpdate = 5
        RyujinxFirmware = 6
    End Enum
End Module


Module LatestVersion
    Async Function YuzuEarlyAccess() As Task(Of String)
        Select Case DownloadSources(Config.DownloadSource)("type")
            Case "github"
                Try
                    Return Replace(JsonConvert.DeserializeObject(Await GitHubAPI("https://api.github.com/repos/pineappleea/pineapple-src/releases"))(2)("tag_name"), "EA-", "")
                Catch QWQExpection As Exception
                    frmExpection.ShowMessage("可能的解决方案：GitHub API 调用超出限制，请等一会重试。" & vbCrLf & "详细报错：" & QWQExpection.Message)
                    End
                End Try
            Case "onemanager"
                Dim VersionNumbers As New ArrayList, VersionList As JObject
                VersionList = JObject.Parse(Await HTTPGetAsync(DownloadSources(Config.DownloadSource)("url").ToString & "YuzuEarlyAccess/?json"))
                For Each VersionObject As JProperty In VersionList.Item("list")
                    VersionObject.CreateReader()
                    VersionNumbers.Add(CInt(VersionObject.Value("name").ToString.Replace("Windows-Yuzu-EA-", "").Replace(".7z", "")))
                Next
                VersionNumbers.Sort()
                VersionNumbers.Reverse()
                Return VersionNumbers(0)
            Case Else
                MsgBox("无效的下载源！")
                End
        End Select
    End Function
    Async Function YuzuMainline() As Task(Of String)
        Select Case DownloadSources(Config.DownloadSource)("type")
            Case "github"
                Try
                    Return Replace(JsonConvert.DeserializeObject(Await GitHubAPI("https://api.github.com/repos/yuzu-emu/yuzu-mainline/releases/latest"))("tag_name"), "mainline-0-", "")
                Catch QWQExpection As Exception
                    frmExpection.ShowMessage("可能的解决方案：GitHub API 调用超出限制，请等一会重试。" & vbCrLf & "详细报错：" & QWQExpection.Message)
                    End
                End Try
            Case "onemanager"
                Dim VersionNumbers As New ArrayList, VersionList As JObject
                VersionList = JObject.Parse(Await HTTPGetAsync(DownloadSources(Config.DownloadSource)("url").ToString & "YuzuMainline/?json"))
                For Each VersionObject As JProperty In VersionList.Item("list")
                    VersionObject.CreateReader()
                    VersionNumbers.Add(CInt(VersionObject.Value("name").ToString.Replace("yuzu-windows-msvc-", "").Replace(".7z", "")))
                Next
                VersionNumbers.Sort()
                VersionNumbers.Reverse()
                Return VersionNumbers(0)
            Case Else
                MsgBox("无效的下载源！")
                End
        End Select
    End Function
    Async Function Ryujinx() As Task(Of String)
        Select Case DownloadSources(Config.DownloadSource)("type")
            Case "github"
                Try
                    Return JsonConvert.DeserializeObject(Await GitHubAPI("https://api.github.com/repos/Ryujinx/release-channel-master/releases/latest"))("tag_name")
                Catch QWQExpection As Exception
                    frmExpection.ShowMessage("可能的解决方案：GitHub API 调用超出限制，请等一会重试。" & vbCrLf & "详细报错：" & QWQExpection.Message)
                    End
                End Try
            Case "onemanager"
                Dim VersionNumbers As New ArrayList, VersionList As JObject
                VersionList = JObject.Parse(Await HTTPGetAsync(DownloadSources(Config.DownloadSource)("url").ToString & "Ryujinx/?json"))
                For Each VersionObject As JProperty In VersionList.Item("list")
                    VersionObject.CreateReader()
                    VersionNumbers.Add(CInt(VersionObject.Value("name").ToString.Replace("ryujinx-", "").Replace("-win_x64.zip", "")))
                Next
                VersionNumbers.Sort()
                VersionNumbers.Reverse()
                Return VersionNumbers(0)
            Case Else
                MsgBox("无效的下载源！")
                End
        End Select
    End Function

End Module