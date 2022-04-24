Attribute VB_Name = "hardcodedReadme"
Sub Readme()
    MsgBox "NS 模拟器助手 " & Version & " 之用前必读" & vbCrLf & vbCrLf & _
         " ------------------------------------------ " & vbCrLf & vbCrLf & "本工具提供 NS 模拟器的安装、更新以及密钥、固件等资源的管理功能。" & vbCrLf & _
           "其中的固件文件版权属于任天堂。  Nintendo Switch 等为任天堂的商标。本工具及 Yuzu、Ryujinx 模拟器并不隶属于任天堂。" & vbCrLf & vbCrLf & _
           "如在下载时遇到网络问题卡加载，请在本工具的设置中切换另一个下载源或更换网络环境后重试。" & vbCrLf & _
           "本工具虽然使用 Visual Basic 这门上古编程语言编写，但不保证在 Windows 7 上完美运行，所以建议使用 Windows 10 系统。" & vbCrLf & _
           "如遇到不能解决的问题，可以在本工具的开源仓库提出 issue，或在 设置 - 关于 中找到作者的联系方式。" & vbCrLf & _
           "本工具是开源软件，可以在 设置 - 关于 - 谢志 中找到本工具使用的开源代码以及本工具的源码，也欢迎给本工具贡献代码。" & vbCrLf & _
           "本工具使用阿里云盘和几个云函数平台提供高速下载服务，但不一定稳定，如果希望本工具一直稳定提供高速下载，欢迎捐赠服务器。" & vbCrLf & vbCrLf & _
           "2021-2022 是一刀斩哒" _
         , vbExclamation, "NS 模拟器助手 " & Version & " 之用前必读"
    WriteIni "Tool", "ReadmeCompleted", "Yes", App.Path & "\Config.ini"
End Sub

Sub ForceAnnouncement()
    Dim Announcement As String
    Announcement = GetDataStr2(AnnouncementUrl)
    MsgBox Announcement, vbOKOnly, "NS模拟器助手 - 公告"
End Sub
