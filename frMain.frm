VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frMain 
   BackColor       =   &H00FFFFFF&
   Caption         =   "Yuzu 非官方安装器 By 是一刀斩哒"
   ClientHeight    =   6045
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   10380
   BeginProperty Font 
      Name            =   "微软雅黑"
      Size            =   12
      Charset         =   134
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frMain.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   6045
   ScaleWidth      =   10380
   StartUpPosition =   3  '窗口缺省
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   7800
      Top             =   360
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton btnUpdate 
      Caption         =   "更新现有模拟器"
      Height          =   615
      Left            =   7920
      TabIndex        =   19
      Top             =   5040
      Width           =   1935
   End
   Begin VB.CommandButton btnDelYes 
      Caption         =   "是"
      Height          =   615
      Left            =   5160
      TabIndex        =   18
      Top             =   5040
      Width           =   1935
   End
   Begin VB.CommandButton btnDelNo 
      Caption         =   "否"
      Height          =   615
      Left            =   7920
      TabIndex        =   17
      Top             =   5040
      Width           =   1935
   End
   Begin VB.CommandButton btnInstall4 
      Caption         =   "下一步"
      Height          =   615
      Left            =   7920
      TabIndex        =   14
      Top             =   5040
      Width           =   1935
   End
   Begin VB.ComboBox Combo2 
      Height          =   435
      Left            =   2280
      Sorted          =   -1  'True
      TabIndex        =   13
      Text            =   "Combo2"
      Top             =   3120
      Width           =   2535
   End
   Begin VB.CommandButton btnInstall3 
      Caption         =   "下一步"
      Height          =   615
      Left            =   7920
      TabIndex        =   12
      Top             =   5040
      Width           =   1935
   End
   Begin VB.CommandButton btnBrowse2 
      Caption         =   "浏览"
      Height          =   375
      Left            =   9000
      TabIndex        =   11
      Top             =   3120
      Width           =   855
   End
   Begin VB.TextBox txtKeys 
      ForeColor       =   &H00404040&
      Height          =   435
      IMEMode         =   3  'DISABLE
      Left            =   2280
      TabIndex        =   10
      Text            =   "txtKeys"
      Top             =   3120
      Width           =   6495
   End
   Begin VB.CommandButton btnInstall2 
      Caption         =   "下一步"
      Height          =   615
      Left            =   7920
      TabIndex        =   9
      Top             =   5040
      Width           =   1935
   End
   Begin VB.ComboBox Combo1 
      Height          =   435
      Left            =   2280
      TabIndex        =   8
      Text            =   "Combo1"
      Top             =   3120
      Width           =   2535
   End
   Begin VB.CommandButton btnBrowse 
      Caption         =   "浏览"
      Height          =   375
      Left            =   9000
      TabIndex        =   5
      Top             =   3120
      Width           =   855
   End
   Begin VB.TextBox txtInstallFolder 
      ForeColor       =   &H00404040&
      Height          =   435
      IMEMode         =   3  'DISABLE
      Left            =   2280
      TabIndex        =   4
      Text            =   "txtInstallFolder"
      Top             =   3120
      Width           =   6495
   End
   Begin VB.CommandButton btnInstall 
      Caption         =   "开始安装"
      Height          =   615
      Left            =   7920
      TabIndex        =   3
      Top             =   4200
      Width           =   1935
   End
   Begin YuzuInstaller.ucDownload ucDownload1 
      Height          =   375
      Left            =   9960
      TabIndex        =   0
      Top             =   5520
      Width           =   375
      _ExtentX        =   661
      _ExtentY        =   661
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
      Caption         =   "2021 是一刀斩哒"
      ForeColor       =   &H00404040&
      Height          =   375
      Left            =   360
      TabIndex        =   20
      Top             =   5280
      Width           =   4455
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "正在获取模拟器最新版本号，请稍候 ..."
      ForeColor       =   &H00404040&
      Height          =   975
      Left            =   2280
      TabIndex        =   16
      Top             =   2160
      Width           =   7455
   End
   Begin VB.Label lblProgBar 
      BackStyle       =   0  'Transparent
      Height          =   375
      Left            =   2280
      TabIndex        =   15
      Top             =   3120
      Width           =   7575
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "正在获取模拟器最新版本号，请稍候 ..."
      ForeColor       =   &H00404040&
      Height          =   975
      Left            =   2280
      TabIndex        =   7
      Top             =   960
      Width           =   7455
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "将模拟器安装到 ..."
      ForeColor       =   &H00404040&
      Height          =   495
      Left            =   2280
      TabIndex        =   6
      Top             =   2640
      Width           =   7455
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "By 是一刀斩哒"
      BeginProperty Font 
         Name            =   "微软雅黑"
         Size            =   15
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00808080&
      Height          =   615
      Left            =   2280
      TabIndex        =   2
      Top             =   960
      Width           =   7455
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Yuzu Early Access 非官方安装器"
      BeginProperty Font 
         Name            =   "微软雅黑"
         Size            =   18
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   615
      Left            =   2280
      TabIndex        =   1
      Top             =   360
      Width           =   7455
   End
   Begin VB.Image Image1 
      Height          =   1560
      Left            =   360
      Picture         =   "frMain.frx":54AA
      Stretch         =   -1  'True
      Top             =   360
      Width           =   1560
   End
End
Attribute VB_Name = "frMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Declare Function SysReAllocString Lib "oleaut32.dll" (ByVal pBSTR As Long, Optional ByVal pszStrPtr As Long) As Long
Private Declare Sub CoTaskMemFree Lib "ole32.dll" (ByVal pv As Long)
Private Declare Sub InitCommonControls Lib "comctl32.dll" ()
Dim m_hProgBar As Long   ' hWnd
Dim m_dwPBLeft As Long   ' static x position when vertical
Dim m_dwPBTop As Long   ' static y position when horizontal
Public Function BStrFromLPWStr(lpWStr As Long) As String
SysReAllocString VarPtr(BStrFromLPWStr), lpWStr
End Function

Private Sub btnBrowse2_Click()
On Error Resume Next
CommonDialog1.DialogTitle = "选择 prod.keys 文件"
CommonDialog1.Filter = "NS 密钥|prod.keys"
CommonDialog1.ShowOpen
txtKeys.Text = CommonDialog1.FileName
End Sub

Private Sub btnBrowse_Click()
On Error Resume Next
Dim pChooseDir As New FileOpenDialog
Dim psiResult As IShellItem
Dim lpPath As Long, sPath As String
With pChooseDir
    .SetOptions FOS_PICKFOLDERS
    .SetTitle "选择 Yuzu 的安装文件夹"
    .Show Me.hWnd
    .GetResult psiResult
    If (psiResult Is Nothing) = False Then
        psiResult.GetDisplayName SIGDN_FILESYSPATH, lpPath
        If lpPath Then
            SysReAllocString VarPtr(sPath), lpPath
            CoTaskMemFree lpPath
        End If
    End If
End With
If BStrFromLPWStr(lpPath) <> "" Then txtInstallFolder.Text = BStrFromLPWStr(lpPath)
End Sub


Private Sub btnInstall_Click()
'start installation
Specs(1) = txtInstallFolder.Text
Label2.Visible = False
Label3.Visible = False
txtInstallFolder.Visible = False
btnBrowse.Visible = False
btnInstall.Visible = False
btnUpdate.Visible = False
Label6.Visible = False
MkDirs txtInstallFolder.Text
UpdateMode = False
Label1.Caption = "选择要安装的版本"
Label4.Visible = True
DoEvents
Dim Version As String
Version = GetDataStr("https://gh-rp.sydzy2.workers.dev/https://api.github.com/repos/pineappleea/pineapple-src/releases")
Version = Replace(Filter(Split(Replace(Version, Chr(34), ""), ","), "tag_name:EA-")(0), "tag_name:EA-", "")
Label4.Caption = "当前最新版本是 " & Version & "。" & vbCrLf & "你也可以手动输入版本号来安装。"
Combo1.Visible = True
Combo1.Clear
Combo1.AddItem Version
Combo1.AddItem "<自定义>"
Combo1.Text = Version
btnInstall2.Visible = True
btnInstall2.SetFocus
End Sub

Private Sub btnInstall2_Click()
btnInstall2.Visible = False
'step 2
Combo1.Visible = False
Specs(2) = "https://hub.fastgit.org/PineappleEA/pineapple-src/releases/download/EA-" & CStr(CInt(Combo1.Text)) & "/Windows-Yuzu-EA-" & CStr(CInt(Combo1.Text)) & ".7z"
If UpdateMode Then
btnInstall4_Click
Else
Label1.Caption = "安装密钥"
Label4.Caption = "请选择你在群文件中下载的 keys（密钥）文件。" & vbCrLf & "它的文件名是 prod.keys 。"
txtKeys.Text = "<请点击“浏览”>"
txtKeys.Visible = True
btnBrowse2.Visible = True
btnInstall3.Visible = True
End If
End Sub

Private Sub btnInstall3_Click()
If Right(txtKeys.Text, 4) <> "keys" Then
MsgBox "请选择 prod.keys 文件。", vbCritical + vbOKOnly, "错误"
Else
btnInstall3.Visible = False
'step 3
Specs(3) = txtKeys.Text
txtKeys.Visible = False
btnBrowse2.Visible = False
Label1.Caption = "选择固件版本号"
Label4.Caption = "正在获取固件列表，请稍候 ..."
Dim FirmwareVersionArr() As String
FirmwareVersionArr = Split(Replace(Replace(Join(Filter(Split(Replace(Replace(GetDataStr("https://gh-rp.sydzy2.workers.dev/https://archive.org/download/nintendo-switch-global-firmwares/nintendo-switch-global-firmwares_files.xml"), Chr(34), ""), " ", ""), vbLf), ".zip"), vbCrLf), "<filename=Firmware", ""), ".zipsource=original>", ""), vbCrLf)
Label4.Caption = "固件版本号需要等于或小于密钥版本号。"
Combo2.Clear
Dim i As Integer
For i = 0 To (UBound(FirmwareVersionArr) - LBound(FirmwareVersionArr))
Combo2.AddItem FirmwareVersionArr(i)
Next
Combo2.Visible = True
Combo2.Text = "13.1.0"
btnInstall4.Visible = True
btnInstall4.SetFocus
End If
End Sub

Private Sub btnInstall4_Click()
btnInstall4.Visible = False
'step 4
Specs(4) = "https://download.sydzy.workers.dev/api/download?url=https://archive.org/download/nintendo-switch-global-firmwares/Firmware " & Combo2.Text & ".zip"
Combo2.Visible = False
Label1.Caption = "正在安装模拟器"
Label4.Caption = "安装时间可能需要十几分钟，请耐心等候 ..."
Label5.Visible = True
CaptionBase = "正在下载模拟器 ... (1/5)"
Label5.Caption = CaptionBase & vbCrLf & "准备下载 ..."
    PBarLoad 1, Me.hWnd, lblProgBar.Left \ Screen.TwipsPerPixelX, lblProgBar.Top \ Screen.TwipsPerPixelY, lblProgBar.Width \ Screen.TwipsPerPixelX, lblProgBar.Height \ Screen.TwipsPerPixelY
    PBarSetRange 1, 0, 100
    PBarSetPos 1, 0
    'download emulator
    'specs(1) install folder
    'specs(2) emulator url
    'specs(3) keys
    'specs(4) firmware url
    If CheckFileExists(Specs(1) & "\Yuzu.7z") Then
    Else
  ucDownload1.DownloadFile Specs(2), Specs(1) & "\Yuzu.7z"
  DoEvents
  Status = 0
  Do Until Status = 100
  Sleep 100
  DoEvents
  Loop
  Sleep 5000
  DoEvents
  End If
  
If UpdateMode = False Then
CaptionBase = "正在下载固件 ... (2/5)"
Label5.Caption = CaptionBase & vbCrLf & "准备下载 ..."
    If CheckFileExists(Specs(1) & "\Firmware.zip") Then
    Else
  ucDownload1.DownloadFile Specs(4), Specs(1) & "\Firmware.zip"
  Sleep 200
  Status = 0
  PBarSetPos 1, 0
  Do Until Status = 100
  Sleep 100
  DoEvents
  Loop
  Sleep 5000
  End If

CaptionBase = "正在下载字体等文件（Sysdata） ... (3/5)"
Label5.Caption = CaptionBase & vbCrLf & "准备下载 ..."
    If CheckFileExists(Specs(1) & "\Sysdata.zip") Then
    Else
  ucDownload1.DownloadFile "https://yidaozhan-pan-yidaozhanya.vercel.app/ali/%E6%9D%82%E4%B8%83%E6%9D%82%E5%85%AB/sysdata.zip", Specs(1) & "\Sysdata.zip"
  Status = 0
  Sleep 200
  DoEvents
  Do Until Status = 100
  Sleep 100
  DoEvents
  Loop
  Sleep 5000
  End If
End If
CaptionBase = "正在解压缩文件 ... (4/5)"
PBarUnload 1
Label5.Caption = CaptionBase
DoEvents
'extract emulator
With New cVszArchive
    .OpenArchive Specs(1) & "\Yuzu.7z"
    .Extract Specs(1)
End With
DoEvents
Shell "cmd /c xcopy /s /y " & Chr(34) & Specs(1) & "\yuzu-windows-msvc-early-access\*" & Chr(34) & " " & Chr(34) & Specs(1) & Chr(34), vbMinimizedNoFocus
Sleep 200
DoEvents
Shell "cmd /c rd /s /q " & Chr(34) & Specs(1) & "\yuzu-windows-msvc-early-access" & Chr(34), vbMinimizedNoFocus
DoEvents
Sleep 200
Shell "cmd /c cd " & Chr(34) & Specs(1) & Chr(34) & " && del /s /q yuzu-windows-msvc-source*", vbMinimizedNoFocus
'Kill Specs(1) & "\Yuzu.7z"
If UpdateMode = False Then
'extract sysdata
MkDirs Specs(1) & "\user\sysdata"
With New cVszArchive
    .OpenArchive Specs(1) & "\Sysdata.zip"
    .Extract Specs(1) & "\user\sysdata"
End With
DoEvents
'Kill Specs(1) & "\Sysdata.zip"
CaptionBase = "正在安装固件和密钥 ... (5/5)"
Label5.Caption = CaptionBase
DoEvents
'firmware
MkDirs Specs(1) & "\user\nand\system\Contents\registered"
MkDirs Specs(1) & "\FWTMP"
MkDirs Specs(1) & "\user\keys"
Dim FileName() As String, i As Long
DoEvents
With New cVszArchive
    .OpenArchive Specs(1) & "\Firmware.zip"
    .Extract Specs(1) & "\FWTMP"
End With
DoEvents

Dim fso As Object
Dim folder As Object
Dim file As Object
Set fso = CreateObject("scripting.filesystemobject") '创建FSO对象
Set folder = fso.GetFolder(Specs(1) & "\FWTMP")
For Each file In folder.Files '遍历根文件夹下的文件
MkDir Specs(1) & "\user\nand\system\Contents\registered\" & Replace(Replace(file, Specs(1) & "\FWTMP", ""), ".cnmt", "")
FileCopy file, Specs(1) & "\user\nand\system\Contents\registered\" & Replace(Replace(file, Specs(1) & "\FWTMP", ""), ".cnmt", "") & "\00"
Next
Set fso = Nothing
Set folder = Nothing
Shell "cmd /c rd /s /q " & Chr(34) & Specs(1) & "\FWTMP" & Chr(34), vbMinimizedNoFocus
FileCopy Specs(3), Specs(1) & "\user\keys\prod.keys"
'Kill Specs(1) & "\Firmware.zip"
'completed
End If
DoEvents
'MSVC
If CheckFileExists("C:\Windows\System32\MSVCP140_ATOMIC_WAIT.DLL") = False And CheckFileExists("C:\Windows\System32\msvcp140_atomic_wait.dll") = False Then
Label4.Caption = "系统中缺少MSVC2019运行库，正在安装 ..."
CaptionBase = ""
  ucDownload1.DownloadFile "https://aka.ms/vs/17/release/vc_redist.x64.exe", Specs(1) & "\VC2019.exe"
  Status = 0
  Sleep 200
  DoEvents
  Do Until Status = 100
  Sleep 100
  DoEvents
  Loop
  Sleep 500
  Shell Specs(1) & "\VC2019.exe"
End If

DoEvents
btnDelYes.Visible = True
btnDelNo.Visible = True
Label1.Caption = "安装完成！"
Label4.Caption = "是否要删除安装过程中产生的临时文件？"
Label5.Visible = False
btnDelYes.SetFocus
DoEvents
End Sub
Private Sub btnDelNo_Click()
End
End Sub

Private Sub btnDelYes_Click()
On Error Resume Next
Kill Specs(1) & "\Yuzu.7z"
Kill Specs(1) & "\Sysdata.zip"
Kill Specs(1) & "\Firmware.zip"
Kill Specs(1) & "\VC2019.exe"
End
End Sub

Private Sub btnUpdate_Click()
On Error Resume Next
'start installation
Specs(1) = txtInstallFolder.Text
Label2.Visible = False
Label3.Visible = False
txtInstallFolder.Visible = False
btnBrowse.Visible = False
btnInstall.Visible = False
btnUpdate.Visible = False
Label6.Visible = False
MkDirs txtInstallFolder.Text
Shell "cmd /c rd /s /q " & Chr(34) & Specs(1) & "\plugins" & Chr(34), vbMinimizedNoFocus
Shell "cmd /c cd " & Chr(34) & Specs(1) & Chr(34) & " && del /s /q yuzu-windows-msvc-source*", vbMinimizedNoFocus
Kill Specs(1) & "\avcodec-58.dll"
Kill Specs(1) & "\avutil-56.dll"
Kill Specs(1) & "\icudtl.dat"
Kill Specs(1) & "\libwinpthread-1.dll"
Kill Specs(1) & "\qt.conf"
Kill Specs(1) & "\SDL2.dll"
Kill Specs(1) & "\swscale-5.dll"
Kill Specs(1) & "\yuzu.exe"
Kill Specs(1) & "\yuzu-cmd.exe"
UpdateMode = True
Label1.Caption = "选择要安装的版本"
Label4.Visible = True
DoEvents
Dim Version As String
Version = GetDataStr("https://gh-rp.sydzy2.workers.dev/https://api.github.com/repos/pineappleea/pineapple-src/releases")
Version = Replace(Filter(Split(Replace(Version, Chr(34), ""), ","), "tag_name:EA-")(0), "tag_name:EA-", "")
Label4.Caption = "当前最新版本是 " & Version & "。" & vbCrLf & "你也可以手动输入版本号来安装。"
Combo1.Visible = True
Combo1.Clear
Combo1.AddItem Version
Combo1.AddItem "<自定义>"
Combo1.Text = Version
btnInstall2.Visible = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
End
End Sub
Private Sub Form_Initialize()
InitCommonControls
End Sub
 Private Sub ucDownload1_DownloadProgress(ByVal BytesRead As Long, ByVal BytesTotal As Long)
  Label5.Caption = CaptionBase & vbCrLf & Format(BytesRead / BytesTotal, "Percent") & " " & CStr(FormatNumber(BytesRead / 1048576, 2, vbTrue)) & "MB / " & CStr(FormatNumber(BytesTotal / 1048576, 2, vbTrue)) & "MB"
  Status = CInt(BytesRead / BytesTotal * 100)
  PBarSetPos 1, Status
End Sub

Private Sub ucDownload1_DownloadFailed(ByVal Status As String, ByVal StatusCode As AsyncStatusCodeConstants)
  Label5.Caption = "下载失败:" & Status
  Label5.ForeColor = RGB(255, 0, 0)
End Sub
Private Sub Form_Load()
Label4.Visible = False
Combo1.Visible = False
Combo2.Visible = False
txtKeys.Visible = False
btnInstall2.Visible = False
btnInstall3.Visible = False
btnInstall4.Visible = False
btnBrowse2.Visible = False
Label5.Visible = False
btnDelYes.Visible = False
btnDelNo.Visible = False
btnInstall.Visible = True
txtInstallFolder.Text = "D:\Yuzu"
End Sub


