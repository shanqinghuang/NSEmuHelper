VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{A5E8A7E4-5CB9-46EB-8987-15503F7E5563}#34.0#0"; "yfui.ocx"
Begin VB.Form frmConfig 
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "设置"
   ClientHeight    =   6630
   ClientLeft      =   45
   ClientTop       =   390
   ClientWidth     =   7350
   BeginProperty Font 
      Name            =   "微软雅黑 Light"
      Size            =   10.5
      Charset         =   134
      Weight          =   290
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H80000008&
   Icon            =   "frmConfig.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6630
   ScaleWidth      =   7350
   StartUpPosition =   3  '窗口缺省
   Begin YFUI.YFCheckBox Checks 
      Height          =   375
      Left            =   5880
      TabIndex        =   17
      Top             =   4920
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      Caption         =   "YFCheckBox1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   9
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      DownColor       =   14014426
      FocusColor      =   16761716
      EnabledColor    =   14014426
      DisabledColor   =   14014426
      HighColor       =   13224910
      SelColor        =   16761716
      Style           =   1
   End
   Begin YFUI.YFComboBox cbMirror 
      Height          =   375
      Left            =   240
      TabIndex        =   15
      Tag             =   "W"
      Top             =   3600
      Width           =   6855
      _ExtentX        =   12091
      _ExtentY        =   661
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   9
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   2039583
      EnabledColor    =   14014426
      ItemFocusColor  =   14014426
      Radius          =   3
   End
   Begin YFUI.YFTextBox cfgTexts 
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   13
      Tag             =   "W"
      Top             =   960
      Width           =   5535
      _ExtentX        =   9763
      _ExtentY        =   661
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   9
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   2039583
      EnabledColor    =   14014426
      Radius          =   3
   End
   Begin YFUI.YFButton btnAbout 
      Height          =   495
      Left            =   240
      TabIndex        =   8
      Tag             =   "T"
      Top             =   5880
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   873
      Caption         =   "关于"
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
      Data            =   "frmConfig.frx":54AA
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   2040
      Top             =   5880
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   2
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmConfig.frx":54C2
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmConfig.frx":D868
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin YFUI.YFButton btnCancel 
      Cancel          =   -1  'True
      Height          =   495
      Left            =   5640
      TabIndex        =   9
      Tag             =   "T"
      Top             =   5880
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   873
      Caption         =   "取消"
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
      Data            =   "frmConfig.frx":10836
   End
   Begin YFUI.YFButton btnSave 
      Height          =   495
      Left            =   3960
      TabIndex        =   10
      Tag             =   "T"
      Top             =   5880
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   873
      Caption         =   "保存"
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
      Data            =   "frmConfig.frx":1084E
   End
   Begin YFUI.YFButton btnBrowse 
      Height          =   375
      Index           =   0
      Left            =   5880
      TabIndex        =   11
      Top             =   960
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      Caption         =   "浏览"
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
      Data            =   "frmConfig.frx":10866
   End
   Begin YFUI.YFButton btnBrowse 
      Default         =   -1  'True
      Height          =   375
      Index           =   1
      Left            =   5880
      TabIndex        =   12
      Top             =   2400
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      Caption         =   "浏览"
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
      Data            =   "frmConfig.frx":1087E
   End
   Begin YFUI.YFTextBox cfgTexts 
      Height          =   375
      Index           =   1
      Left            =   240
      TabIndex        =   14
      Tag             =   "W"
      Top             =   2400
      Width           =   5535
      _ExtentX        =   9763
      _ExtentY        =   661
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   9
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   2039583
      EnabledColor    =   14014426
   End
   Begin YFUI.YFComboBox Combo1 
      Height          =   375
      Left            =   5880
      TabIndex        =   16
      Tag             =   "W"
      Top             =   4320
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   9
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   2039583
      EnabledColor    =   14014426
      ItemFocusColor  =   14014426
      Radius          =   3
   End
   Begin VB.Label Labels2 
      BackStyle       =   0  'Transparent
      Caption         =   "点此从 Yuzu Tool 导入"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   9
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H004D0000&
      Height          =   375
      Index           =   2
      Left            =   1920
      TabIndex        =   7
      Top             =   600
      Width           =   2295
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "自动检查本工具更新"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H001F1F1F&
      Height          =   375
      Index           =   4
      Left            =   720
      TabIndex        =   6
      Top             =   4920
      Width           =   4575
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   4
      Left            =   240
      Picture         =   "frmConfig.frx":10896
      Stretch         =   -1  'True
      Top             =   4920
      Width           =   375
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "下载 / 更新镜像源"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H001F1F1F&
      Height          =   375
      Index           =   3
      Left            =   720
      TabIndex        =   5
      Top             =   3120
      Width           =   4575
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   3
      Left            =   240
      Picture         =   "frmConfig.frx":1238A
      Stretch         =   -1  'True
      Top             =   3120
      Width           =   375
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   2
      Left            =   240
      Picture         =   "frmConfig.frx":12D73
      Stretch         =   -1  'True
      Top             =   4320
      Width           =   375
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "CloudFlare 代理模式"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H001F1F1F&
      Height          =   375
      Index           =   2
      Left            =   720
      TabIndex        =   4
      Top             =   4320
      Width           =   4575
   End
   Begin VB.Label Labels2 
      BackStyle       =   0  'Transparent
      Caption         =   "不推荐存放在 C 盘"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   9
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000015&
      Height          =   375
      Index           =   1
      Left            =   240
      TabIndex        =   3
      Top             =   2040
      Width           =   3375
   End
   Begin VB.Label Labels2 
      BackStyle       =   0  'Transparent
      Caption         =   "不推荐存放在 C 盘，"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   9
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000015&
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   2
      Top             =   600
      Width           =   2055
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   1
      Left            =   240
      Picture         =   "frmConfig.frx":1375C
      Stretch         =   -1  'True
      Top             =   1680
      Width           =   375
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   0
      Left            =   240
      Picture         =   "frmConfig.frx":1422D
      Stretch         =   -1  'True
      Top             =   240
      Width           =   375
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "Ryujinx 模拟器安装位置"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H001F1F1F&
      Height          =   375
      Index           =   1
      Left            =   720
      TabIndex        =   1
      Top             =   1680
      Width           =   3375
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "Yuzu 模拟器安装位置"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H001F1F1F&
      Height          =   375
      Index           =   0
      Left            =   720
      TabIndex        =   0
      Top             =   240
      Width           =   3375
   End
End
Attribute VB_Name = "frmConfig"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub btnAbout_Click()
    frmAbout.Show
End Sub

Private Sub btnBrowse_Click(Index As Integer)
    cfgTexts(Index).Text = ChooseDir(Labels(Index).Caption, Me)
End Sub

Private Sub btnCancel_Click()
    Unload frmAbout
    Unload Me
End Sub

Private Sub btnSave_Click()
    If InStr(cfgTexts(0).Text, "yuzu-windows-msvc-early-access") Then
        MsgBox "Yuzu 安装文件夹名为 yuzu-windows-msvc-early-access 会导致更新丢存档，请重命名该文件夹，或者不使用本工具。", vbCritical
        Exit Sub
    End If
    If InStr(cfgTexts(1).Text, "publish") Then
        MsgBox "Ryujinx 安装文件夹名为 publish 会导致更新丢存档，请重命名该文件夹，或者不使用本工具。", vbCritical
        Exit Sub
    End If
    '保存设置
    YuzuInstallFolder = cfgTexts(0).Text
    RyujinxInstallFolder = cfgTexts(1).Text
    Select Case Combo1.Text
        Case "始终使用"
            AlwaysUseCloudFlare = "True"
        Case "自动"
            AlwaysUseCloudFlare = "False"
        Case "排除GitHub"
            AlwaysUseCloudFlare = "GitHub"
        Case "永不使用"
            AlwaysUseCloudFlare = "Never"
    End Select
    If Checks.Value = True Then
        AutoCheckForUpdate = True
    Else
        AutoCheckForUpdate = False
    End If
    Select Case cbMirror.ListIndex
        Case 0
            DownloadSource = "Aliyundrive"
        Case 1
            DownloadSource = "GitHub"
    End Select
    WriteIni "Folder", "YuzuInstallFolder", YuzuInstallFolder, App.Path & "\Config.ini"
    WriteIni "Folder", "RyujinxInstallFolder", RyujinxInstallFolder, App.Path & "\Config.ini"
    WriteIni "Network", "AlwaysUseCloudFlare", CStr(AlwaysUseCloudFlare), App.Path & "\Config.ini"
    WriteIni "Network", "DownloadSource", DownloadSource, App.Path & "\Config.ini"
    WriteIni "Tool", "AutoCheckForUpdate", CStr(AutoCheckForUpdate), App.Path & "\Config.ini"
    Unload Me
End Sub




Private Sub cbMirror_Click()
    Images(3).Picture = ImageList1.ListImages((cbMirror.ListIndex + 1)).Picture
End Sub

Private Sub cbMirror_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub Form_Activate()
'加载设置
    cfgTexts(0).Text = YuzuInstallFolder
    cfgTexts(1).Text = RyujinxInstallFolder
    Select Case AlwaysUseCloudFlare
        Case "True"
            Combo1.Text = "始终使用"
        Case "False"
            Combo1.Text = "自动"
        Case "GitHub"
            Combo1.Text = "排除GitHub"
        Case "Never"
            Combo1.Text = "永不使用"
    End Select
    If DownloadSource = "Aliyundrive" Then
        cbMirror.Text = "阿里云盘 (速度更快，但只保留五个版本)"
    ElseIf DownloadSource = "GitHub" Then
        cbMirror.Text = "GitHub / CloudFlare (速度慢，但保留全部版本)"
    End If
    DoEvents
    Images(3).Picture = ImageList1.ListImages((cbMirror.ListIndex + 1)).Picture

    If AutoCheckForUpdate Then Checks(1).Value = 1

    btnSave.SetFocus
End Sub

Private Sub Form_Load()
    Me.Caption = "NS模拟器助手 - 设置"
    'cbMirror.Clear
    cbMirror.AddItem "阿里云盘 (速度更快，但只保留五个版本)"
    cbMirror.AddItem "GitHub / CloudFlare (速度慢，但保留全部版本)"
    cbMirror.Text = "阿里云盘 (速度更快，但只保留五个版本)"
    Combo1.Clear
    Combo1.AddItem "自动"
    Combo1.AddItem "始终使用"
    Combo1.AddItem "永不使用"
    Combo1.AddItem "排除GitHub"
End Sub

Private Sub Form_Initialize()
    InitCommonControls
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Unload frmAbout
End Sub

Private Sub ImageCombo1_Click()
    Images(3).Picture = ImageList1.ListImages(ImageCombo1.SelectedItem.Index).Picture

End Sub

Private Sub Labels2_Click(Index As Integer)
    If Index = 2 Then
        If CheckFileExists(App.Path & "\ImportRegistry.exe") Then
            Shell App.Path & "\ImportRegistry.exe", vbNormalFocus
            End
        Else
            MsgBox "ImportRegistry.exe 未找到，请重新安装本工具。", vbCritical, "文件未找到"
        End If
    End If
End Sub
