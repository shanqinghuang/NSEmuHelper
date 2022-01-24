VERSION 5.00
Begin VB.Form frmManage 
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "管理窗体"
   ClientHeight    =   3495
   ClientLeft      =   45
   ClientTop       =   390
   ClientWidth     =   7035
   BeginProperty Font 
      Name            =   "微软雅黑 Light"
      Size            =   12
      Charset         =   134
      Weight          =   290
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmManage.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3495
   ScaleWidth      =   7035
   StartUpPosition =   3  '窗口缺省
   Begin VB.CommandButton btnSaveSettings 
      Caption         =   "相关设置"
      Height          =   495
      Left            =   5280
      TabIndex        =   8
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton btnShortcut 
      Caption         =   "快捷方式"
      Height          =   495
      Left            =   1920
      TabIndex        =   7
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton btnKey 
      Caption         =   "更换密钥"
      Height          =   495
      Left            =   5280
      TabIndex        =   6
      Top             =   2760
      Width           =   1455
   End
   Begin VB.CommandButton btnFirmware 
      Caption         =   "更新固件"
      Height          =   495
      Left            =   3600
      TabIndex        =   5
      Top             =   2760
      Width           =   1455
   End
   Begin VB.CommandButton btnUpdate 
      Caption         =   "更新模拟器或更换版本"
      Height          =   495
      Left            =   240
      TabIndex        =   4
      Top             =   2760
      Width           =   3135
   End
   Begin VB.CommandButton btnSaves 
      Caption         =   "存档目录"
      Height          =   495
      Left            =   3600
      TabIndex        =   3
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton btnLog 
      Caption         =   "查看日志"
      Height          =   495
      Left            =   240
      TabIndex        =   2
      Top             =   2040
      Width           =   1455
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "数据文件夹："
      Height          =   375
      Index           =   2
      Left            =   1440
      TabIndex        =   9
      Top             =   1200
      Width           =   5295
   End
   Begin VB.Image Images 
      Height          =   975
      Index           =   2
      Left            =   240
      Picture         =   "frmManage.frx":54AA
      Stretch         =   -1  'True
      Top             =   240
      Width           =   975
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "固件版本："
      Height          =   375
      Index           =   1
      Left            =   1440
      TabIndex        =   1
      Top             =   720
      Width           =   5295
   End
   Begin VB.Image Images 
      Height          =   975
      Index           =   1
      Left            =   240
      Picture         =   "frmManage.frx":9DFD
      Stretch         =   -1  'True
      Top             =   240
      Width           =   975
   End
   Begin VB.Image Images 
      Height          =   975
      Index           =   0
      Left            =   240
      Picture         =   "frmManage.frx":A8CE
      Stretch         =   -1  'True
      Top             =   240
      Width           =   975
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "模拟器版本："
      Height          =   375
      Index           =   0
      Left            =   1440
      TabIndex        =   0
      Top             =   240
      Width           =   5295
   End
End
Attribute VB_Name = "frmManage"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Public IsYuzu As Boolean

Private Sub btnFirmware_Click()
    frmYuzuInstaller.Show
    InstallMode = 3
    frmManage.Hide

End Sub

Private Sub btnKey_Click()
Dim KeyFile As String
KeyFile = ChooseFile("选择密钥文件 (prod.keys)", "NS 密钥文件", "prod.keys", frmManage.hWnd)
Kill YuzuInstallFolder & "\user\keys\prod.keys"
FileCopy KeyFile, YuzuInstallFolder & "\user\keys\prod.keys"
MsgBox "密钥文件替换/更新成功！", vbOKOnly + vbInformation, "提示"
End Sub


Private Sub btnSaveSettings_Click()
frmYuzuConfig.IsMissing = False
frmYuzuConfig.Show
End Sub

Private Sub btnShortcut_Click()
Dim nPath As String, sh, ShortCut
On Error Resume Next
Set sh = CreateObject("wscript.shell") '
nPath = sh.RegRead("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders\Desktop") '获取当前用户的桌面目录
If Right(nPath, 1) <> "" Then nPath = nPath & "\"
ShortF = nPath & "Yuzu.lnk"
Set ShortCut = sh.CreateShortcut(ShortF) '开始创建快捷方式对象
ShortCut.TargetPath = YuzuInstallFolder & "\yuzu.exe" '快捷方式指向的目标文件，写完整路径
ShortCut.Save
MsgBox "快捷方式创建成功！", vbOKOnly + vbInformation, "提示"
End Sub

Private Sub btnLog_Click()
ShellExecute Me.hWnd, "open", YuzuInstallFolder & "\user\log\yuzu_log.txt", vbNullString, vbNullString, vbNormalFocus
End Sub

Private Sub btnSaves_Click()
Shell "explorer.exe " & Chr(34) & YuzuInstallFolder & "\user\nand\user\save\0000000000000000" & Chr(34), vbNormalFocus
End Sub

Private Sub btnUpdate_Click()
    frmYuzuInstaller.Show
    InstallMode = 2
    frmManage.Hide
End Sub

Private Sub Form_Activate()
'窗口外观
Labels(2).Visible = False
If IsYuzu Then
    Me.Caption = "NS模拟器助手 " & Version & " - Yuzu 管理"
    Me.Icon = frmMain.Icon
Else
    Me.Caption = "NS模拟器助手 " & Version & " - Ryujinx 管理"
    Images(0).Visible = False
    Images(1).Visible = True
    Images(2).Visible = False
End If
'加载配置
If IsYuzu Then
    If CheckFileExists(YuzuInstallFolder & "\YuzuConfig.ini") = False Then
        frmYuzuConfig.IsMissing = True
        frmYuzuConfig.Show
    End If
    YuzuVersion = GetIni("Yuzu", "Version", YuzuInstallFolder & "\YuzuConfig.ini")
    YuzuBranch = GetIni("Yuzu", "Branch", YuzuInstallFolder & "\YuzuConfig.ini")
    If Left(YuzuBranch, 3) = "主线版" Then
        Images(0).Visible = False
        Images(1).Visible = False
        Images(2).Visible = True
    Else
        Images(0).Visible = True
        Images(1).Visible = False
        Images(2).Visible = False
    End If
    YuzuFirmware = GetIni("Yuzu", "Firmware", YuzuInstallFolder & "\YuzuConfig.ini")
    Labels(0).Caption = "模拟器版本：" & YuzuBranch
    Labels(0).Caption = Labels(0).Caption & " " & YuzuVersion
    Labels(1).Caption = "固件版本：" & YuzuFirmware
    YuzuCustomDataFolder = GetIni("Yuzu", "CustomDataFolder", YuzuInstallFolder & "\YuzuConfig.ini")
    If YuzuCustomDataFolder <> "False" Then
        Labels(2).Visible = True
        Labels(2).Caption = "数据文件夹：" & YuzuCustomDataFolder
    End If
Else
End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
frmMain.Show
End Sub


Private Sub Form_Initialize()
InitCommonControls
End Sub

