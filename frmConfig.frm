VERSION 5.00
Begin VB.Form frmConfig 
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Form1"
   ClientHeight    =   5265
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
   ScaleHeight     =   5265
   ScaleWidth      =   7425
   StartUpPosition =   3  '窗口缺省
   Begin VB.CheckBox Checks 
      BackColor       =   &H80000005&
      Caption         =   "否"
      Height          =   420
      Index           =   0
      Left            =   5880
      TabIndex        =   12
      Top             =   3120
      Width           =   735
   End
   Begin VB.CommandButton btnCancel 
      Caption         =   "取消"
      Height          =   495
      Left            =   5640
      TabIndex        =   7
      Top             =   4560
      Width           =   1455
   End
   Begin VB.CommandButton btnSave 
      Caption         =   "保存"
      Height          =   495
      Left            =   3960
      TabIndex        =   6
      Top             =   4560
      Width           =   1455
   End
   Begin VB.CommandButton btnBrowse 
      Caption         =   "浏览"
      Height          =   375
      Index           =   1
      Left            =   5880
      TabIndex        =   5
      Top             =   2400
      Width           =   1215
   End
   Begin VB.TextBox CfgTexts 
      Height          =   420
      IMEMode         =   3  'DISABLE
      Index           =   1
      Left            =   240
      Locked          =   -1  'True
      TabIndex        =   4
      Text            =   "Text1"
      Top             =   2400
      Width           =   5415
   End
   Begin VB.CommandButton btnBrowse 
      Caption         =   "浏览"
      Height          =   375
      Index           =   0
      Left            =   5880
      TabIndex        =   2
      Top             =   960
      Width           =   1215
   End
   Begin VB.TextBox CfgTexts 
      Height          =   420
      IMEMode         =   3  'DISABLE
      Index           =   0
      Left            =   240
      Locked          =   -1  'True
      TabIndex        =   1
      Text            =   "Text1"
      Top             =   960
      Width           =   5415
   End
   Begin VB.Label Labels2 
      BackStyle       =   0  'Transparent
      Caption         =   "可能会减缓下载速度"
      ForeColor       =   &H80000015&
      Height          =   375
      Index           =   2
      Left            =   240
      TabIndex        =   11
      Top             =   3480
      Width           =   3375
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   2
      Left            =   240
      Picture         =   "frmConfig.frx":54AA
      Stretch         =   -1  'True
      Top             =   3120
      Width           =   375
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "始终使用 CloudFlare Workers 下载文件"
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
      Top             =   3120
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
      Caption         =   "不推荐存放在 C 盘"
      ForeColor       =   &H80000015&
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   8
      Top             =   600
      Width           =   3375
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   1
      Left            =   240
      Picture         =   "frmConfig.frx":5E93
      Stretch         =   -1  'True
      Top             =   1680
      Width           =   375
   End
   Begin VB.Image Images 
      Height          =   360
      Index           =   0
      Left            =   240
      Picture         =   "frmConfig.frx":6964
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
      TabIndex        =   3
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
Private Sub btnBrowse_Click(Index As Integer)
CfgTexts(Index).Text = ChooseDir(Labels(Index).Caption, Me)
End Sub

Private Sub btnCancel_Click()
Unload Me
End Sub

Private Sub btnSave_Click()
'保存设置
YuzuInstallFolder = CfgTexts(0).Text
RyujinxInstallFolder = CfgTexts(1).Text
If Checks(0).Value = 1 Then
    AlwaysUseCloudFlare = "True"
Else
    AlwaysUseCloudFlare = "False"
End If
WriteIniBase64 "Folder", "YuzuInstallFolder", YuzuInstallFolder, App.Path & "\Config.ini"
WriteIniBase64 "Folder", "RyujinxInstallFolder", RyujinxInstallFolder, App.Path & "\Config.ini"
WriteIni "Network", "AlwaysUseCloudFlare", AlwaysUseCloudFlare, App.Path & "\Config.ini"
Unload Me
End Sub


Private Sub Checks_Click(Index As Integer)
If Checks(Index).Value = 1 Then
    Checks(Index).Caption = "是"
Else
    Checks(Index).Caption = "否"
End If
End Sub

Private Sub Form_Load()
Me.Caption = "NS模拟器助手 - 设置"
'加载设置
CfgTexts(0).Text = YuzuInstallFolder
CfgTexts(1).Text = RyujinxInstallFolder
If AlwaysUseCloudFlare = "True" Then
    Checks(Index).Value = 1
Else
    Checks(Index).Value = 0
End If

End Sub


Private Sub Form_Initialize()
InitCommonControls
End Sub
