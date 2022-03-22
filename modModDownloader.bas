Attribute VB_Name = "modModDownloader"
Public Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
Public Declare Function WritePrivateProfileString Lib "kernel32" Alias _
                                                  "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpString As Any, ByVal lpFileName As String) As Long
Public Declare Function GetPrivateProfileString Lib "kernel32" Alias _
                                                "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long
Public Declare Function SysReAllocString Lib "oleaut32.dll" (ByVal pBSTR As Long, Optional ByVal pszStrPtr As Long) As Long
Public Declare Sub CoTaskMemFree Lib "ole32.dll" (ByVal pv As Long)
Public Declare Sub InitCommonControls Lib "comctl32.dll" ()


Public YuzuInstallFolder As String, ModFolder As String, LocalTitles As String
Attribute ModFolder.VB_VarUserMemId = 1073741824
Attribute LocalTitles.VB_VarUserMemId = 1073741824
Public Const TitleXmlUrl = "https://www.githubs.cn/raw-githubusercontent/amakvana/YuzuModDownloader/main/assets/GameTitleIDs.xml"
Public Const ModsUrl = "https://www.githubs.cn/raw-githubusercontent/wiki/yuzu-emu/yuzu/Switch-Mods.md"


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

Public Sub XCopy(From As String, Destination As String)
    With CreateObject("WScript.Shell")
        .Run "cmd /c xcopy /e /i /y " & Chr(34) & From & Chr(34) & " " & Chr(34) & Destination & Chr(34), 0, True
    End With
End Sub

Public Sub OpenLink(Url As String)
    Shell "cmd /c start " & Chr(34) & " " & Chr(34) & " " & Chr(34) & Url & Chr(34), vbNormalFocus
End Sub

Public Function CheckFileExists(FilePath As String) As Boolean
'检查文件是否存在
    On Error GoTo Err
    If Len(FilePath) < 2 Then CheckFileExists = False: Exit Function
    If Dir$(FilePath, vbAllFileAttrib) <> vbNullString Then CheckFileExists = True
    Exit Function
Err:
    CheckFileExists = False
End Function

Public Function Translate(SourceText As String) As String
    Dim xhr As Object, iter As Variant, Dest As String
    Set xhr = CreateObject("MSXML2.XMLHTTP")
    xhr.open "GET", "https://fanyi.youdao.com/translate?&doctype=json&type=AUTO&i=" & SourceText
    xhr.send
    Do Until xhr.readyState = 4
        DoEvents
        Sleep 10
    Loop
    Dim oJson As Object
    Set oJson = JSON.parse(xhr.responseText)
    Set xhr = Nothing
    For Each iter In oJson("translateResult")(1)
        Dest = Dest & " " & iter("tgt")
    Next iter
    Translate = Dest
End Function
