VERSION 5.00
Begin VB.Form frmMain 
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "NS 模拟器助手 v1"
   ClientHeight    =   5925
   ClientLeft      =   45
   ClientTop       =   390
   ClientWidth     =   5370
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
   ScaleHeight     =   5925
   ScaleWidth      =   5370
   StartUpPosition =   3  '窗口缺省
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "Ryujinx模拟器介绍"
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
      Height          =   615
      Index           =   7
      Left            =   2000
      TabIndex        =   7
      Top             =   4230
      Width           =   3495
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "Yuzu模拟器介绍"
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
      Height          =   615
      Index           =   6
      Left            =   2000
      TabIndex        =   6
      Top             =   2800
      Width           =   3015
   End
   Begin VB.Line Line1 
      BorderColor     =   &H8000000A&
      X1              =   600
      X2              =   4800
      Y1              =   1320
      Y2              =   1320
   End
   Begin VB.Image Images 
      Height          =   825
      Index           =   1
      Left            =   1040
      Picture         =   "frmMain.frx":54AA
      Stretch         =   -1  'True
      ToolTipText     =   "Ryujinx"
      Top             =   3800
      Width           =   795
   End
   Begin VB.Image Images 
      Appearance      =   0  'Flat
      Height          =   495
      Index           =   2
      Left            =   120
      Picture         =   "frmMain.frx":5F7B
      Stretch         =   -1  'True
      ToolTipText     =   "模拟器助手设置"
      Top             =   5280
      Width           =   555
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "2021-2022 是一刀斩哒"
      ForeColor       =   &H80000015&
      Height          =   735
      Index           =   5
      Left            =   1080
      TabIndex        =   5
      Top             =   5520
      Width           =   4095
   End
   Begin VB.Label Labels 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "高效全能的 NS 模拟器辅助工具"
      ForeColor       =   &H80000015&
      Height          =   495
      Index           =   4
      Left            =   120
      TabIndex        =   4
      Top             =   720
      Width           =   5055
   End
   Begin VB.Label Labels 
      Alignment       =   2  'Center
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
      ForeColor       =   &H001F1F1F&
      Height          =   615
      Index           =   3
      Left            =   120
      TabIndex        =   3
      Top             =   120
      Width           =   5175
   End
   Begin VB.Label Labels 
      Alignment       =   2  'Center
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
      ForeColor       =   &H001F1F1F&
      Height          =   615
      Index           =   2
      Left            =   240
      TabIndex        =   2
      Top             =   1560
      Width           =   4935
   End
   Begin VB.Image Images 
      Height          =   860
      Index           =   0
      Left            =   1000
      Picture         =   "frmMain.frx":7027
      Stretch         =   -1  'True
      ToolTipText     =   "Yuzu"
      Top             =   2400
      Width           =   860
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
      ForeColor       =   &H001F1F1F&
      Height          =   615
      Index           =   1
      Left            =   2000
      TabIndex        =   1
      Top             =   3680
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
      ForeColor       =   &H001F1F1F&
      Height          =   615
      Index           =   0
      Left            =   2000
      TabIndex        =   0
      Top             =   2280
      Width           =   1095
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Activate()
    Labels(5).Alignment = 1
    'Labels(5).Caption = Version & " By 是一刀斩哒" & vbCrLf & "本工具非Yuzu Tool, 反馈问题不要找错人"
    Labels(5).Caption = Version & " By 是一刀斩哒"
    If FirstActivate = False Then
        If AutoCheckForUpdate Then
            CheckUpdate (True)
            FirstActivate = True
        End If
    End If
End Sub

Private Sub Form_Initialize()
    InitCommonControls
    '加载配置
    ConfigFileVersion = ""
    If CheckFileExists(App.Path & "\Config.Defaults.ini") = False And CheckFileExists(App.Path & "\Config.ini") = False Then
        MsgBox "配置文件不存在，程序无法启动！", vbCritical
    End If
    If CheckFileExists(App.Path & "\Config.Defaults.ini") = True And CheckFileExists(App.Path & "\Config.ini") = False Then
        '创建默认配置
        Name App.Path & "\Config.Defaults.ini" As App.Path & "\Config.ini"
    End If
    YuzuInstallFolder = GetIni("Folder", "YuzuInstallFolder", App.Path & "\Config.ini")
    RyujinxInstallFolder = GetIni("Folder", "RyujinxInstallFolder", App.Path & "\Config.ini")
    CloudFlareReverseProxyUrl = GetIni("Network", "CloudFlareReverseProxyUrl", App.Path & "\Config.ini")
    DownloadSource = GetIni("Network", "DownloadSource", App.Path & "\Config.ini")
    AliyundriveDomain = GetIni("Network", "AliyundriveDomain", App.Path & "\Config.ini")
    If AliyundriveDomain = "yidaozhan-pan-yidaozhanya.vercel.app" Then
    'v3配置文件 懒得升级了
        AliyundriveDomain = "nsemuhelper.herokuapp.com"
    End If
    ConfigFileVersion = GetIni("Tool", "ConfigFileVersion", App.Path & "\Config.ini")
    If Left(GetIni("Network", "AlwaysUseCloudFlare", App.Path & "\Config.ini"), 4) = "True" Then
        AlwaysUseCloudFlare = True
    Else
        AlwaysUseCloudFlare = False
    End If
    If Left(GetIni("Tool", "AutoCheckForUpdate", App.Path & "\Config.ini"), 4) = "True" Then
        AutoCheckForUpdate = True
    Else
        AutoCheckForUpdate = False
    End If
    If ConfigFileVersion <> InternalConfigFileVersion Then
        If ConfigFileVersion = "" Then
            MsgBox "本次更新升级了配置文件，你需要重新打开程序，之后重新设置 Yuzu 和 Ryujinx 的路径。", vbExclamation
            WriteIni "Tool", "ConfigFileVersion", "v2", App.Path & "\Config.ini"
            WriteIni "Folder", "YuzuInstallFolder", "D:\Yuzu", App.Path & "\Config.ini"
            WriteIni "Folder", "RyujinxInstallFolder", "D:\Ryujinx", App.Path & "\Config.ini"
            End
        End If
        If ConfigFileVersion = "v2" Then
            MsgBox "本次更新升级了配置文件，你需要重新打开程序。", vbExclamation
            WriteIni "Tool", "ConfigFileVersion", "v3", App.Path & "\Config.ini"
            WriteIni "Network", "CloudFlareReverseProxyUrl", "https://rp.ydz1.gq", App.Path & "\Config.ini"
            End
        End If
    End If
End Sub

Private Sub Form_Load()
'窗口相关
    Me.Caption = "NS模拟器助手 " & Version
    Labels(6) = "注重模拟效率和游戏体验" & vbCrLf & "但在模拟精确度上略有欠缺"
    Labels(7) = "在模拟精确度和兼容性上更佳" & vbCrLf & "但模拟速度还需优化提升"
End Sub

Private Sub Form_Terminate()
    End
End Sub

Private Sub Form_Unload(Cancel As Integer)
    End
End Sub

Private Sub Images_Click(Index As Integer)
    Dim PopMsgBox As Integer
    '图片按钮被点击
    If Index = 2 Then
        frmConfig.Show
    Else
        If Index = 0 Then
            'Yuzu
            frmManage.IsYuzu = True
            If CheckFileExists(YuzuInstallFolder & "\yuzu.exe") = False Then
                If YuzuInstallFolder = "D:\Yuzu" Then
                    PopMsgBox = MsgBox("在默认的安装位置 D:\Yuzu 中没有找到 Yuzu 模拟器。" & vbCrLf & "点“是”以在该位置安装模拟器，" & vbCrLf & "你也可以在主界面的设置中选择现有的模拟器位置，" & "或者从 Ryuzu Tool 导入。", vbYesNo, "Yuzu 未找到")
                Else
                    PopMsgBox = MsgBox("在你选择的安装位置 " & YuzuInstallFolder & " 中没有找到 Yuzu 模拟器。" & vbCrLf & "点 “是” 以在该位置安装模拟器，" & vbCrLf & "也可以在主界面的设置中选择现有的模拟器位置，" & "或者从 Ryuzu Tool 导入。", vbYesNo, "Yuzu 未找到")
                End If
                If PopMsgBox = vbYes Then
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
            frmManage.IsYuzu = False
            If CheckFileExists(RyujinxInstallFolder & "\Ryujinx.exe") = False Then
                If RyujinxInstallFolder = "D:\Ryujinx" Then
                    PopMsgBox = MsgBox("在默认的安装位置 D:\Ryujinx 中没有找到 Ryujinx 模拟器。" & vbCrLf & "点“是”以在默认位置安装模拟器，" & vbCrLf & "你也可以在主界面的设置中选择现有的模拟器位置或者从 Ryuzu Tool 导入。", vbYesNo, "Ryujinx 未找到")
                Else
                    PopMsgBox = MsgBox("在你选择的安装位置 " & RyujinxInstallFolder & " 中没有找到 Ryujinx 模拟器。" & vbCrLf & "点 “是” 以在该位置安装模拟器，" & vbCrLf & "也可以在主界面的设置中选择现有的模拟器位置或者从 Ryuzu Tool 导入。", vbYesNo, "Ryujinx 未找到")
                End If
                If PopMsgBox = vbYes Then
                    InstallMode = 1
                    frmRyujinxInstaller.Show
                    Me.Hide
                End If
            Else
                Load frmManage
                frmManage.Show
                Me.Hide
            End If
        End If
    End If
End Sub

Private Sub Labels_Click(Index As Integer)
If Index = 0 Or Index = 6 Then
    Images_Click 0
ElseIf Index = 1 Or Index = 7 Then
    Images_Click 1
End If
End Sub
