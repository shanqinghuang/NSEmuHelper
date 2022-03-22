VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmConfig 
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Form1"
   ClientHeight    =   6705
   ClientLeft      =   45
   ClientTop       =   390
   ClientWidth     =   7425
   BeginProperty Font 
      Name            =   "微软雅黑 Light"
      Size            =   10.5
      Charset         =   134
      Weight          =   290
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmConfig.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6705
   ScaleWidth      =   7425
   StartUpPosition =   3  '窗口缺省
   Begin VB.CheckBox Checks 
      BackColor       =   &H80000005&
      Caption         =   "否"
      Height          =   420
      Index           =   1
      Left            =   5880
      TabIndex        =   16
      Top             =   4920
      Width           =   735
   End
   Begin VB.CommandButton btnAbout 
      Caption         =   "关于"
      Height          =   495
      Left            =   240
      TabIndex        =   14
      Top             =   5880
      Width           =   1455
   End
   Begin MSComctlLib.ImageCombo ImageCombo1 
      Height          =   435
      Left            =   240
      TabIndex        =   12
      Top             =   3600
      Width           =   6855
      _ExtentX        =   12091
      _ExtentY        =   767
      _Version        =   393216
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "微软雅黑 Light"
         Size            =   10.5
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Text            =   "ImageCombo1"
      ImageList       =   "ImageList1"
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   6480
      Top             =   4080
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
            Picture         =   "frmConfig.frx":54AA
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmConfig.frx":D850
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.CheckBox Checks 
      BackColor       =   &H80000005&
      Caption         =   "否"
      Height          =   420
      Index           =   0
      Left            =   5880
      TabIndex        =   11
      Top             =   4320
      Width           =   735
   End
   Begin VB.CommandButton btnCancel 
      Caption         =   "取消"
      Height          =   495
      Left            =   5640
      TabIndex        =   7
      Top             =   5880
      Width           =   1455
   End
   Begin VB.CommandButton btnSave 
      Caption         =   "保存"
      Default         =   -1  'True
      Height          =   495
      Left            =   3960
      TabIndex        =   0
      Top             =   5880
      Width           =   1455
   End
   Begin VB.CommandButton btnBrowse 
      Caption         =   "浏览"
      Height          =   420
      Index           =   1
      Left            =   5880
      TabIndex        =   6
      Top             =   2400
      Width           =   1215
   End
   Begin VB.TextBox CfgTexts 
      Height          =   420
      IMEMode         =   3  'DISABLE
      Index           =   1
      Left            =   240
      Locked          =   -1  'True
      TabIndex        =   5
      Text            =   "Text1"
      Top             =   2400
      Width           =   5415
   End
   Begin VB.CommandButton btnBrowse 
      Caption         =   "浏览"
      Height          =   420
      Index           =   0
      Left            =   5880
      TabIndex        =   3
      Top             =   960
      Width           =   1215
   End
   Begin VB.TextBox CfgTexts 
      Height          =   420
      IMEMode         =   3  'DISABLE
      Index           =   0
      Left            =   240
      Locked          =   -1  'True
      TabIndex        =   2
      Text            =   "Text1"
      Top             =   960
      Width           =   5415
   End
   Begin VB.Label Labels2 
      BackStyle       =   0  'Transparent
      Caption         =   "点此从 Ryuzu Tool 导入"
      ForeColor       =   &H8000000D&
      Height          =   375
      Index           =   2
      Left            =   2160
      TabIndex        =   17
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
      Height          =   375
      Index           =   4
      Left            =   720
      TabIndex        =   15
      Top             =   4920
      Width           =   4575
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   4
      Left            =   240
      Picture         =   "frmConfig.frx":1081E
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
      Height          =   375
      Index           =   3
      Left            =   720
      TabIndex        =   13
      Top             =   3120
      Width           =   4575
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   3
      Left            =   240
      Picture         =   "frmConfig.frx":12312
      Stretch         =   -1  'True
      Top             =   3120
      Width           =   375
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   2
      Left            =   240
      Picture         =   "frmConfig.frx":12CFB
      Stretch         =   -1  'True
      Top             =   4320
      Width           =   375
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "始终使用 CloudFlare 下载 Github 文件"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   12
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   720
      TabIndex        =   10
      Top             =   4320
      Width           =   4575
   End
   Begin VB.Label Labels2 
      BackStyle       =   0  'Transparent
      Caption         =   "不推荐存放在 C 盘"
      ForeColor       =   &H80000015&
      Height          =   375
      Index           =   1
      Left            =   240
      TabIndex        =   9
      Top             =   2040
      Width           =   3375
   End
   Begin VB.Label Labels2 
      BackStyle       =   0  'Transparent
      Caption         =   "不推荐存放在 C 盘，"
      ForeColor       =   &H80000015&
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   8
      Top             =   600
      Width           =   2055
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   1
      Left            =   240
      Picture         =   "frmConfig.frx":136E4
      Stretch         =   -1  'True
      Top             =   1680
      Width           =   375
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   0
      Left            =   240
      Picture         =   "frmConfig.frx":141B5
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
      Height          =   375
      Index           =   1
      Left            =   720
      TabIndex        =   4
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
      Height          =   375
      Index           =   0
      Left            =   720
      TabIndex        =   1
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
CfgTexts(Index).Text = ChooseDir(Labels(Index).Caption, Me)
End Sub

Private Sub btnCancel_Click()
Unload frmAbout
Unload Me
End Sub

Private Sub btnSave_Click()
If InStr(CfgTexts(0).Text, "yuzu-windows-msvc-early-access") Then
    MsgBox "Yuzu 安装文件夹名为 yuzu-windows-msvc-early-access 会导致更新丢存档，请重命名该文件夹，或者不使用本工具。", vbCritical
    Exit Sub
End If
If InStr(CfgTexts(1).Text, "publish") Then
    MsgBox "Ryujinx 安装文件夹名为 publish 会导致更新丢存档，请重命名该文件夹，或者不使用本工具。", vbCritical
    Exit Sub
End If
'保存设置
YuzuInstallFolder = CfgTexts(0).Text
RyujinxInstallFolder = CfgTexts(1).Text
If Checks(0).Value = 1 Then
    AlwaysUseCloudFlare = True
Else
    AlwaysUseCloudFlare = False
End If
If Checks(1).Value = 1 Then
    AutoCheckForUpdate = True
Else
    AutoCheckForUpdate = False
End If
DownloadSource = ImageCombo1.SelectedItem.key
WriteIni "Folder", "YuzuInstallFolder", YuzuInstallFolder, App.Path & "\Config.ini"
WriteIni "Folder", "RyujinxInstallFolder", RyujinxInstallFolder, App.Path & "\Config.ini"
WriteIni "Network", "AlwaysUseCloudFlare", CStr(AlwaysUseCloudFlare), App.Path & "\Config.ini"
WriteIni "Network", "DownloadSource", DownloadSource, App.Path & "\Config.ini"
WriteIni "Tool", "AutoCheckForUpdate", CStr(AutoCheckForUpdate), App.Path & "\Config.ini"
Unload Me
End Sub


Private Sub Checks_Click(Index As Integer)
If Checks(Index).Value = 1 Then
    Checks(Index).Caption = "是"
Else
    Checks(Index).Caption = "否"
End If
End Sub

Private Sub Form_Activate()
'加载设置
CfgTexts(0).Text = YuzuInstallFolder
CfgTexts(1).Text = RyujinxInstallFolder
If AlwaysUseCloudFlare = "True" Then
    Checks(Index).Value = 1
Else
    Checks(Index).Value = 0
End If
If DownloadSource = "Aliyundrive" Then
    ImageCombo1.ComboItems(1).Selected = True
ElseIf DownloadSource = "Github" Then
    ImageCombo1.ComboItems(2).Selected = True
End If
Images(3).Picture = ImageList1.ListImages(ImageCombo1.SelectedItem.Index).Picture

If AutoCheckForUpdate Then Checks(1).Value = 1

btnSave.SetFocus
End Sub

Private Sub Form_Load()
Me.Caption = "NS模拟器助手 - 设置"
ImageCombo1.ComboItems.Clear
ImageCombo1.ComboItems.Add 1, "Aliyundrive", "阿里云盘 (速度更快，但保留版本少)", 1
ImageCombo1.ComboItems.Add 2, "Github", "Github / CloudFlare (速度慢，但保留全部版本)", 2
ImageCombo1.ComboItems(1).Selected = True
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
