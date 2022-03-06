VERSION 5.00
Object = "{A5E8A7E4-5CB9-46EB-8987-15503F7E5563}#34.0#0"; "yfui.ocx"
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
   Begin YFUI.YFButton btnLog 
      Height          =   495
      Left            =   240
      TabIndex        =   3
      Tag             =   "T"
      Top             =   2040
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   873
      Caption         =   "查看日志"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   2039583
      DownColor       =   16185594
      DownBorderColor =   14014426
      FocusColor      =   16185594
      FocusBorderColor=   13882840
      EnabledColor    =   16185594
      EnabledBorderColor=   14014426
      DisabledBorderColor=   14014426
      HighColor       =   15988473
      HighBorderColor =   15132905
      Radius          =   3
      Data            =   "frmManage.frx":54AA
   End
   Begin YFUI.YFButton btnShortcut 
      Height          =   495
      Left            =   1920
      TabIndex        =   4
      Tag             =   "T"
      Top             =   2040
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   873
      Caption         =   "快捷方式"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   2039583
      DownColor       =   16185594
      DownBorderColor =   14014426
      FocusColor      =   16185594
      FocusBorderColor=   13882840
      EnabledColor    =   16185594
      EnabledBorderColor=   14014426
      DisabledBorderColor=   14014426
      HighColor       =   15988473
      HighBorderColor =   15132905
      Radius          =   3
      Data            =   "frmManage.frx":54C2
   End
   Begin YFUI.YFButton btnSaves 
      Height          =   495
      Left            =   3600
      TabIndex        =   5
      Tag             =   "T"
      Top             =   2040
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   873
      Caption         =   "存档目录"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   2039583
      DownColor       =   16185594
      DownBorderColor =   14014426
      FocusColor      =   16185594
      FocusBorderColor=   13882840
      EnabledColor    =   16185594
      EnabledBorderColor=   14014426
      DisabledBorderColor=   14014426
      HighColor       =   15988473
      HighBorderColor =   15132905
      Radius          =   3
      Data            =   "frmManage.frx":54DA
   End
   Begin YFUI.YFButton btnSaveSettings 
      Height          =   495
      Left            =   5280
      TabIndex        =   6
      Tag             =   "T"
      Top             =   2040
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   873
      Caption         =   "相关设置"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   2039583
      DownColor       =   16185594
      DownBorderColor =   14014426
      FocusColor      =   16185594
      FocusBorderColor=   13882840
      EnabledColor    =   16185594
      EnabledBorderColor=   14014426
      DisabledBorderColor=   14014426
      HighColor       =   15988473
      HighBorderColor =   15132905
      Radius          =   3
      Data            =   "frmManage.frx":54F2
   End
   Begin YFUI.YFButton btnUpdate 
      Height          =   495
      Left            =   240
      TabIndex        =   7
      Tag             =   "T"
      Top             =   2760
      Width           =   3135
      _ExtentX        =   5530
      _ExtentY        =   873
      Caption         =   "更新模拟器或更换版本"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   2039583
      DownColor       =   16185594
      DownBorderColor =   14014426
      FocusColor      =   16185594
      FocusBorderColor=   13882840
      EnabledColor    =   16185594
      EnabledBorderColor=   14014426
      DisabledBorderColor=   14014426
      HighColor       =   15988473
      HighBorderColor =   15132905
      Radius          =   3
      Data            =   "frmManage.frx":550A
   End
   Begin YFUI.YFButton btnFirmware 
      Height          =   495
      Left            =   3600
      TabIndex        =   8
      Tag             =   "T"
      Top             =   2760
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   873
      Caption         =   "更新固件"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   2039583
      DownColor       =   16185594
      DownBorderColor =   14014426
      FocusColor      =   16185594
      FocusBorderColor=   13882840
      EnabledColor    =   16185594
      EnabledBorderColor=   14014426
      DisabledBorderColor=   14014426
      HighColor       =   15988473
      HighBorderColor =   15132905
      Radius          =   3
      Data            =   "frmManage.frx":5522
   End
   Begin YFUI.YFButton btnKey 
      Height          =   495
      Left            =   5280
      TabIndex        =   9
      Tag             =   "T"
      Top             =   2760
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   873
      Caption         =   "更换密钥"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   2039583
      DownColor       =   16185594
      DownBorderColor =   14014426
      FocusColor      =   16185594
      FocusBorderColor=   13882840
      EnabledColor    =   16185594
      EnabledBorderColor=   14014426
      DisabledBorderColor=   14014426
      HighColor       =   15988473
      HighBorderColor =   15132905
      Radius          =   3
      Data            =   "frmManage.frx":553A
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "数据文件夹："
      ForeColor       =   &H001F1F1F&
      Height          =   375
      Index           =   2
      Left            =   1440
      TabIndex        =   2
      Top             =   960
      Width           =   5295
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "固件版本："
      ForeColor       =   &H001F1F1F&
      Height          =   375
      Index           =   1
      Left            =   1440
      TabIndex        =   1
      Top             =   600
      Width           =   5295
   End
   Begin VB.Image Images 
      Height          =   975
      Index           =   0
      Left            =   240
      Picture         =   "frmManage.frx":5552
      Stretch         =   -1  'True
      Top             =   240
      Width           =   975
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "模拟器版本："
      ForeColor       =   &H001F1F1F&
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
Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Public IsYuzu As Boolean

Private Sub btnFirmware_Click()
    InstallMode = 3
    If IsYuzu Then
        frmYuzuInstaller.Show
    Else
        frmRyujinxInstaller.Show
    End If
    frmManage.Hide
End Sub

Private Sub btnKey_Click()
    On Error Resume Next
    Dim KeyFile As String
    If IsYuzu Then
        KeyFile = ChooseFile("选择密钥文件 (prod.keys)", "NS 密钥文件", "prod.keys", frmManage.hwnd)
        If KeyFile = "" Then Exit Sub
        Kill YuzuInstallFolder & "\user\keys\prod.keys"
        FileCopy KeyFile, YuzuInstallFolder & "\user\keys\prod.keys"
        MsgBox "Yuzu 密钥文件更新 / 替换成功！", vbOKOnly + vbInformation, "提示"
        Exit Sub
    Else
        KeyFile = ChooseFile("选择密钥文件 (prod.keys)", "NS 密钥文件", "prod.keys", frmManage.hwnd)
        If KeyFile = "" Then Exit Sub
        Kill RyujinxInstallFolder & "\portable\system\prod.keys"
        FileCopy KeyFile, RyujinxInstallFolder & "\portable\system\prod.keys"
        MsgBox "Ryujinx 密钥文件更新 / 替换成功！", vbOKOnly + vbInformation, "提示"
        Exit Sub
    End If
End Sub


Private Sub btnSaveSettings_Click()
    If IsYuzu Then
        frmYuzuConfig.IsMissing = False
        frmYuzuConfig.Show
    Else
        frmRyujinxConfig.IsMissing = False
        frmRyujinxConfig.Show
    End If
End Sub

Private Sub btnShortcut_Click()
    Dim nPath As String, sh, ShortCut
    If IsYuzu Then
        On Error Resume Next
        Set sh = CreateObject("wscript.shell")    '
        nPath = sh.RegRead("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders\Desktop")    '获取当前用户的桌面目录
        If Right(nPath, 1) <> "" Then nPath = nPath & "\"
        ShortF = nPath & "Yuzu.lnk"
        Set ShortCut = sh.CreateShortcut(ShortF)    '开始创建快捷方式对象
        ShortCut.TargetPath = YuzuInstallFolder & "\yuzu.exe"    '快捷方式指向的目标文件，写完整路径
        ShortCut.Save
        MsgBox "Yuzu 快捷方式创建成功！", vbOKOnly + vbInformation, "提示"
    Else
        On Error Resume Next
        Set sh = CreateObject("wscript.shell")    '
        nPath = sh.RegRead("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders\Desktop")    '获取当前用户的桌面目录
        If Right(nPath, 1) <> "" Then nPath = nPath & "\"
        ShortF = nPath & "Ryujinx.lnk"
        Set ShortCut = sh.CreateShortcut(ShortF)    '开始创建快捷方式对象
        ShortCut.TargetPath = RyujinxInstallFolder & "\Ryujinx.exe"    '快捷方式指向的目标文件，写完整路径
        ShortCut.Save
        MsgBox "Ryujinx 快捷方式创建成功！", vbOKOnly + vbInformation, "提示"
    End If
End Sub

Private Sub btnLog_Click()
    If IsYuzu Then
        ShellExecute Me.hwnd, "open", YuzuInstallFolder & "\user\log\yuzu_log.txt", vbNullString, vbNullString, vbNormalFocus
    Else
        Shell "explorer.exe " & Chr(34) & ryujinsintallfolder & "\Logs" & Chr(34), vbNormalFocus
    End If
End Sub

Private Sub btnSaves_Click()
    If IsYuzu Then
        Shell "explorer.exe " & Chr(34) & YuzuInstallFolder & "\user\nand\user\save\0000000000000000" & Chr(34), vbNormalFocus
    Else
        Shell "explorer.exe " & Chr(34) & RyujinxInstallFolder & "\portable\bis\user\save" & Chr(34), vbNormalFocus
    End If
End Sub

Private Sub btnUpdate_Click()
    InstallMode = 2
    If IsYuzu Then
        frmYuzuInstaller.Show
    Else
        frmRyujinxInstaller.Show
    End If
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
        Me.Icon = frmRyujinxInstaller.Icon
        Unload frmRyujinxInstaller
    End If
    '加载配置
    If IsYuzu Then
        If CheckFileExists(YuzuInstallFolder & "\YuzuConfig.ini") = False Then
            frmYuzuConfig.IsMissing = True
            frmYuzuConfig.Show
        Else
            YuzuVersion = GetIni("Yuzu", "Version", YuzuInstallFolder & "\YuzuConfig.ini")
            YuzuBranch = GetIni("Yuzu", "Branch", YuzuInstallFolder & "\YuzuConfig.ini")
            If Left(YuzuBranch, 3) = "主线版" Then
                Images(0).Picture = frmYuzuInstaller.ImageList2.ListImages(2).Picture
                Unload frmYuzuInstaller
            Else
                Images(0).Picture = frmYuzuInstaller.ImageList2.ListImages(1).Picture
                Unload frmYuzuInstaller
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
            DoEvents
        End If
    Else
        If CheckFileExists(RyujinxInstallFolder & "\RyujinxConfig.ini") = False Then
            frmRyujinxConfig.IsMissing = True
            frmRyujinxConfig.Show
        Else
            RyujinxVersion = GetIni("Ryujinx", "Version", RyujinxInstallFolder & "\RyujinxConfig.ini")
            RyujinxBranch = GetIni("Ryujinx", "Branch", RyujinxInstallFolder & "\RyujinxConfig.ini")
            If Left(RyujinxBranch, 3) = "LDN" Then
                Images(0).Picture = frmRyujinxInstaller.ImageList2.ListImages(2).Picture
                Unload frmRyujinxInstaller
            Else
                Images(0).Picture = frmRyujinxInstaller.ImageList2.ListImages(1).Picture
                Unload frmRyujinxInstaller
            End If
            RyujinxFirmware = GetIni("Ryujinx", "Firmware", RyujinxInstallFolder & "\RyujinxConfig.ini")
            Labels(0).Caption = "模拟器版本：" & RyujinxBranch
            Labels(0).Caption = Labels(0).Caption & " " & RyujinxVersion
            Labels(1).Caption = "固件版本：" & RyujinxFirmware
            RyujinxCustomDataFolder = GetIni("Ryujinx", "CustomDataFolder", RyujinxInstallFolder & "\RyujinxConfig.ini")
            If RyujinxCustomDataFolder <> "False" Then
                Labels(2).Visible = True
                Labels(2).Caption = "数据文件夹：" & RyujinxCustomDataFolder
            End If
            DoEvents
        End If
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
    frmMain.Show
End Sub


Private Sub Form_Initialize()
    InitCommonControls
End Sub
