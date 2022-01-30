Attribute VB_Name = "Module1"
'函数声明
Public Declare Function WritePrivateProfileString Lib "kernel32" Alias _
"WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpString As Any, ByVal lpFileName As String) As Long
Public Declare Function GetPrivateProfileString Lib "kernel32" Alias _
"GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long
Public Declare Function SysReAllocString Lib "oleaut32.dll" (ByVal pBSTR As Long, Optional ByVal pszStrPtr As Long) As Long
Public Declare Sub CoTaskMemFree Lib "ole32.dll" (ByVal pv As Long)
Public Declare Sub InitCommonControls Lib "comctl32.dll" ()

'公共变量常量
Public Const Version As String = "Beta 0.2.7"
Public Const InternalVersion As String = "b0.2.7"
Public Const InternalConfigFileVersion As String = "v3"


'配置设置
Public YuzuInstallFolder As String, RyujinxInstallFolder As String, AlwaysUseCloudFlare As Boolean, CloudFlareReverseProxyUrl As String, DownloadSource As String
Public YuzuVersion As String, YuzuBranch As String, YuzuFirmware As String, YuzuCustomDataFolder As String
Public RyujinxVersion As String, RyujinxBranch As String, RyujinxFirmware As String, RyujinxCustomDataFolder As String
Public AliyundriveDomain As String, AutoCheckForUpdate As Boolean, ConfigFileVersion As String
Public InstallMode As Integer

'下载链接暂存
Public AsyncReads(0 To 1) As String

Public Function BStrFromLPWStr(lpWStr As Long) As String
SysReAllocString VarPtr(BStrFromLPWStr), lpWStr
End Function

Public Function ChooseDir(ByVal frmTitle As String, onForm As Object) As String
'oleexp 选择目录
On Error Resume Next
Dim pChooseDir As New FileOpenDialog
Dim psiResult As IShellItem
Dim lpPath As Long, sPath As String
With pChooseDir
    .SetOptions FOS_PICKFOLDERS
    .SetTitle frmTitle
    .Show onForm.hWnd
    .GetResult psiResult
    If (psiResult Is Nothing) = False Then
        psiResult.GetDisplayName SIGDN_FILESYSPATH, lpPath
        If lpPath Then
            SysReAllocString VarPtr(sPath), lpPath
            CoTaskMemFree lpPath
        End If
    End If
End With
If BStrFromLPWStr(lpPath) <> "" Then ChooseDir = BStrFromLPWStr(lpPath)
End Function

Public Function ChooseFile(ByVal frmTitle As String, ByVal fileDescription As String, ByVal fileFilter As String, ByVal onForm As Variant) As String
'oleexp 选择文件
On Error Resume Next
Dim pChoose As New FileOpenDialog
Dim psiResult As IShellItem
Dim lpPath As Long, sPath As String
Dim tFilt() As COMDLG_FILTERSPEC
ReDim tFilt(0)
tFilt(0).pszName = fileDescription
tFilt(0).pszSpec = fileFilter
With pChoose
    .SetFileTypes UBound(tFilt) + 1, VarPtr(tFilt(0))
    .SetTitle frmTitle
    .SetOptions FOS_FILEMUSTEXIST + FOS_DONTADDTORECENT
    .Show onForm
    .GetResult psiResult
    If (psiResult Is Nothing) = False Then
        psiResult.GetDisplayName SIGDN_FILESYSPATH, lpPath
        If lpPath Then
            SysReAllocString VarPtr(sPath), lpPath
            CoTaskMemFree lpPath
        End If
    End If
End With
If BStrFromLPWStr(lpPath) <> "" Then ChooseFile = BStrFromLPWStr(lpPath)
End Function

Public Function CheckFileExists(FilePath As String) As Boolean
'检查文件夹是否存在
    On Error GoTo Err
    If Len(FilePath) < 2 Then CheckFileExists = False: Exit Function
            If Dir$(FilePath, vbAllFileAttrib) <> vbNullString Then CheckFileExists = True
    Exit Function
Err:
    CheckFileExists = False
End Function

Public Function GetDataStr(ByVal Url As String) As String
'xhr get 字符串
  On Error GoTo Err:
  Dim XMLHTTP As Object
  Set XMLHTTP = CreateObject("Microsoft.XMLHTTP")
  XMLHTTP.Open "GET", Url, True
  XMLHTTP.send
  While XMLHTTP.readyState <> 4
  Sleep 10
    DoEvents
  Wend
    GetDataStr = XMLHTTP.responseText
  Set XMLHTTP = Nothing
  Exit Function
Err:
  GetDataStr = ""
End Function

Public Function GetDataStr2(ByVal Url As String) As String
'server xhr get 字符串 (for github)
  On Error GoTo Err:
  Dim XMLHTTP As Object
  Set XMLHTTP = CreateObject("MSXML2.ServerXMLHTTP.6.0")
  XMLHTTP.Open "GET", Url, False
  XMLHTTP.setRequestHeader "User-Agent", "NSEmuHelper " & InternalVersion
  XMLHTTP.setRequestHeader "Authorization", "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" ' github oauth token
  XMLHTTP.send
  While XMLHTTP.Status <> 200
    frmYuzuInstaller.Caption = XMLHTTP.Status
    Sleep 10
    DoEvents
  Wend
    GetDataStr2 = XMLHTTP.responseText
  Set XMLHTTP = Nothing
  Exit Function
Err:
  GetDataStr2 = ""
End Function

Public Function GetYuzuVersion() As String
'获取 Yuzu Early Access 版本号
On Error GoTo ExitEA
Dim TmpEA As String
TmpEA = GetDataStr2(CloudFlareReverseProxyUrl & "/https://api.github.com/repos/pineappleea/pineapple-src/releases")
TmpEA = Replace(Replace(TmpEA, Chr(34), ""), " ", "")
TmpEA = Filter(Split(TmpEA, ","), "tag_name:EA")(0)
GetYuzuVersion = Split(TmpEA, "EA-")(1)
Exit Function
ExitEA:
MsgBox "Github API 调用超出限制，请等一会重试，或者使用阿里云盘下载源。", vbCritical + vbOKOnly
GetYuzuVersion = "错误"
End Function

Public Function GetYuzuMLVersion() As String
'获取 Yuzu 主线版版本号
On Error GoTo ExitEA
Dim TmpML As String
TmpML = GetDataStr2(CloudFlareReverseProxyUrl & "/https://api.github.com/repos/yuzu-emu/yuzu-mainline/releases")
TmpML = Replace(Replace(TmpML, Chr(34), ""), " ", "")
TmpML = Filter(Split(TmpML, ","), "tag_name:mainline")(0)
GetYuzuMLVersion = Split(TmpML, "mainline-0-")(1)
Exit Function
ExitEA:
MsgBox "Github API 调用超出限制，请等一会重试，或者使用阿里云盘下载源。", vbCritical + vbOKOnly
GetYuzuMLVersion = "错误"
End Function

Public Function GetYuzuVersionAli() As String
'获取 Yuzu Early Access 版本号 阿里云盘
Dim TmpEAAli As String
Do Until TmpEAAli <> ""
    TmpEAAli = GetDataStr2("https://" & AliyundriveDomain & "/ns_emu_helper/YuzuEAMirror/?json")
Loop
TmpEAAli = Replace(Replace(Join(Filter(Split(TmpEAAli, Chr(34)), "windows-yuzu-ea-"), vbCrLf), "windows-yuzu-ea-", ""), ".7z", "")
GetYuzuVersionAli = TmpEAAli
End Function

Public Function GetYuzuMLVersionAli() As String
'获取 Yuzu 主线版版本号 阿里云盘
Dim TmpMLAli As String
Do Until TmpMLAli <> ""
    TmpMLAli = GetDataStr2("https://" & AliyundriveDomain & "/ns_emu_helper/YuzuMainlineMirror/?json")
Loop
TmpMLAli = Replace(Replace(Join(Filter(Split(Replace(TmpMLAli, Chr(34), ""), ","), "name:yuzu-windows-msvc-"), vbCrLf), "name:yuzu-windows-msvc-", ""), ".7z", "")
GetYuzuMLVersionAli = TmpMLAli
End Function

Public Function GetRyujinxVersion() As String
'获取 Ryujinx 版本号
On Error GoTo RetryML
Dim TmpML As String
RetryML:
TmpML = GetDataStr2(CloudFlareReverseProxyUrl & "/https://api.github.com/repos/Ryujinx/release-channel-master/releases/latest")
TmpML = Replace(Replace(TmpML, Chr(34), ""), " ", "")
TmpML = Filter(Split(TmpML, ","), "tag_name:")(0)
GetRyujinxVersion = Replace(Replace(Replace(TmpML, "tag_name:", ""), vbCrLf, ""), vbLf, "")
End Function

Public Function GetRyujinxVersionAli() As String
'获取 Ryujinx 版本号 阿里云盘
Dim TmpMLAli As String
Do Until TmpMLAli <> ""
    TmpMLAli = GetDataStr2("https://" & AliyundriveDomain & "/ns_emu_helper/RyujinxMainlineMirror/?json")
Loop
TmpMLAli = Replace(Replace(Join(Filter(Split(Replace(TmpMLAli, Chr(34), ""), ","), "name:ryujinx-"), vbCrLf), "name:ryujinx-", ""), "-win_x64.zip", "")
GetRyujinxVersionAli = TmpMLAli
End Function

Public Function GetRyujinxLDNVersionAli() As String
'获取 Ryujinx LDN 版本号 阿里云盘
Dim TmpMLAli As String
Do Until TmpMLAli <> ""
    TmpMLAli = GetDataStr2("https://" & AliyundriveDomain & "/ns_emu_helper/RyujinxLDNMirror/?json")
Loop
TmpMLAli = Replace(Replace(Join(Filter(Split(Replace(TmpMLAli, Chr(34), ""), ","), "name:ryujinx-"), vbCrLf), "name:ryujinx-", ""), "-win_x64.zip", "")
GetRyujinxLDNVersionAli = TmpMLAli
End Function

Public Function MkDirs(ByVal PathIn As String) As Boolean
'连环套文件夹创建
   Dim nPos As Long
   MkDirs = True
   If Right(PathIn, 1) <> "\" Then PathIn = PathIn + "\"
   nPos = InStr(1, PathIn, "\")

   Do While nPos > 0
       If Dir$(Left$(PathIn, nPos), vbDirectory) = "" Then
           On Error GoTo Failed
               MkDir Left$(PathIn, nPos)
           On Error GoTo 0
       End If
       nPos = InStr(nPos + 1, PathIn, "\")
   Loop

   Exit Function
Failed:
   MkDirs = False
End Function


Public Function TestEmptyFolder(FolderName As String) As Boolean
'测试文件夹是否存在
On Error GoTo Err
RmDir (FolderName) '删除目录，如果出错表示不为空
MkDir (FolderName) '重新建目录
TestEmptyFolder = True
Exit Function
Err:
TestEmptyFolder = False
End Function

Public Sub CheckUpdate(Slient As Boolean)
'检查更新
'On Error GoTo ExitUpd
Dim Tmp As String, Tmp2 As String
If Slient Then
    Tmp = GetDataStr("https://api.github.com/repos/YidaozhanYa/NSEmuHelper/releases/latest")
Else
    Tmp = GetDataStr2(CloudFlareReverseProxyUrl & "/https://api.github.com/repos/YidaozhanYa/NSEmuHelper/releases/latest")
End If
Tmp = Replace(Tmp, Chr(34), "")
Tmp2 = Replace(Replace(Replace(Replace(Replace(Filter(Split(Tmp, ","), "body")(0), "}", ""), "\n", ""), "\r", vbCrLf), "#####", ""), "body:", "")
Tmp = Split(Filter(Split(Replace(Tmp, " ", ""), ","), "tag_name:")(0), "tag_name:")(1)
If Tmp <> InternalVersion Then
    '有更新！
    frmMain.Hide
    frmConfig.Hide
    frmAbout.Hide
    MsgBox "检测到更新！" & vbCrLf & vbCrLf & "当前版本：" & Version & vbCrLf & "最新版本：" & Tmp2, vbInformation
    OpenLink "https://pan.baidu.com/s/10ZS58nejQ5k43mfaJdv5ZQ?pwd=67d3"
    End
Else
    If Slient = False Then MsgBox Version & " 已经是最新版本。", vbInformation
End If
Exit Sub
ExitUpd:
If Slient = False Then
    MsgBox "检查更新失败，本小时 Github API 调用超出限制，请等一会重试。", vbCritical + vbOKOnly
End If
End Sub

Public Sub OpenLink(Url As String)
Shell "cmd /c start " & Chr(34) & " " & Chr(34) & " " & Chr(34) & Url & Chr(34), vbNormalFocus
End Sub

Public Sub XCopy(From As String, Destination As String)
    With CreateObject("WScript.Shell")
        .Run "cmd /c xcopy /e /i /y " & Chr(34) & From & Chr(34) & " " & Chr(34) & Destination & Chr(34), 0, True
    End With
End Sub

Public Sub ShellAndWait(pathFile As String)
    With CreateObject("WScript.Shell")
        .Run pathFile, 0, True
    End With
End Sub

Public Sub Unzip(ZipPath As String, UnzipTo As String)
ShellAndWait Chr(34) & App.Path & "\Dependencies\7z.exe" & Chr(34) & " x " & Chr(34) & ZipPath & Chr(34) & " -o" & Chr(34) & UnzipTo & Chr(34) & " -aoa"
End Sub

Public Function GetIni(strSection As String, strKey As String, INIFileName As String)
With New ClassINI
    .INIFileName = INIFileName
    GetIni = .GetIniKey(strSection, strKey)
End With
End Function

Public Sub WriteIni(strSection As String, strKey As String, strNewValue As String, INIFileName As String)
With New ClassINI
    .INIFileName = INIFileName
    .WriteIniKey strSection, strKey, strNewValue
End With
End Sub
