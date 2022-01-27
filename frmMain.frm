VERSION 5.00
Begin VB.Form frmMain 
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "NS 模拟器助手 v1"
   ClientHeight    =   5595
   ClientLeft      =   45
   ClientTop       =   390
   ClientWidth     =   5325
   BeginProperty Font 
      Name            =   "微软雅黑 Light"
      Size            =   10.5
      Charset         =   134
      Weight          =   290
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5595
   ScaleWidth      =   5325
   StartUpPosition =   3  '窗口缺省
   Begin VB.Image Images 
      Appearance      =   0  'Flat
      Height          =   495
      Index           =   2
      Left            =   120
      Picture         =   "frmMain.frx":54AA
      Stretch         =   -1  'True
      Top             =   4920
      Width           =   555
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "2021-2022 是一刀斩哒"
      ForeColor       =   &H80000015&
      Height          =   735
      Index           =   5
      Left            =   3000
      TabIndex        =   5
      Top             =   5160
      Width           =   4095
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "Development build"
      ForeColor       =   &H80000015&
      Height          =   735
      Index           =   4
      Left            =   960
      TabIndex        =   4
      Top             =   720
      Width           =   4095
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "NS 模拟器助手"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   21.75
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Index           =   3
      Left            =   960
      TabIndex        =   3
      Top             =   120
      Width           =   3495
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "请选择要管理的模拟器"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   15.75
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Index           =   2
      Left            =   1080
      TabIndex        =   2
      Top             =   1920
      Width           =   3375
   End
   Begin VB.Image Images 
      Height          =   1200
      Index           =   1
      Left            =   3000
      Picture         =   "frmMain.frx":6556
      Stretch         =   -1  'True
      Top             =   2520
      Width           =   1200
   End
   Begin VB.Image Images 
      Height          =   1200
      Index           =   0
      Left            =   960
      Picture         =   "frmMain.frx":7027
      Stretch         =   -1  'True
      Top             =   2520
      Width           =   1200
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "Ryujinx"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   21.75
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Index           =   1
      Left            =   2880
      TabIndex        =   1
      Top             =   3840
      Width           =   1455
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "Yuzu"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   21.75
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Index           =   0
      Left            =   1080
      TabIndex        =   0
      Top             =   3840
      Width           =   1095
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Initialize()
InitCommonControls
'加载配置
YuzuInstallFolder = GetIniBase64("Folder", "YuzuInstallFolder", App.Path & "\Config.ini")
RyujinxInstallFolder = GetIniBase64("Folder", "RyujinxInstallFolder", App.Path & "\Config.ini")
AlwaysUseCloudFlare = GetIni("Network", "AlwaysUseCloudFlare", App.Path & "\Config.ini")
CloudFlareReverseProxyUrl = GetIni("Network", "CloudFlareReverseProxyUrl", App.Path & "\Config.ini")
DownloadSource = GetIni("Network", "DownloadSource", App.Path & "\Config.ini")
End Sub

Private Sub Form_Load()
'窗口相关
Me.Caption = "NS模拟器助手 " & Version
Labels(4).Caption = "高效全能的 NS 模拟器辅助工具" & vbCrLf & Version
End Sub

Private Sub Form_Unload(Cancel As Integer)
End
End Sub

Private Sub Images_Click(Index As Integer)
'图片按钮被点击
If Index = 2 Then
    frmConfig.Show
Else
    If Index = 0 Then
        'Yuzu
        frmManage.IsYuzu = True
        If CheckFileExists(YuzuInstallFolder & "\yuzu.exe") = False Then
            If MsgBox("Yuzu 模拟器没有安装，是否现在安装模拟器？", vbYesNo, "Yuzu 未找到") = vbYes Then
                InstallMode = 1
                frmYuzuInstaller.Show
                Me.Hide
            End If
        Else
            Load frmManage
            frmManage.Show
            Me.Hide
        End If
    Else
        'Ryujinx
        MsgBox "暂未支持 Ryujinx，请等待下个版本。"
        End
        frmManage.IsYuzu = False
        Load frmManage
        frmManage.Show
        Me.Hide
    End If
End If
End Sub

