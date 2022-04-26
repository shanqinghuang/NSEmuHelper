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
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "yuzu"
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
      Left            =   2260
      TabIndex        =   7
      Top             =   3800
      Width           =   1695
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "yuzu"
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
      Left            =   2260
      TabIndex        =   6
      Top             =   2350
      Width           =   1695
   End
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
      Left            =   1080
      TabIndex        =   5
      Top             =   4920
      Width           =   4095
   End
   Begin VB.Label Labels 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "高效全能的 NS 模拟器安装管理工具"
      ForeColor       =   &H80000015&
      Height          =   375
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
      Height          =   615
      Index           =   3
      Left            =   120
      TabIndex        =   3
      Top             =   120
      Width           =   5055
   End
   Begin VB.Label Labels 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "请选择要管理的模拟器"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   14.25
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   2
      Left            =   120
      TabIndex        =   2
      Top             =   1200
      Width           =   5055
   End
   Begin VB.Image Images 
      Height          =   810
      Index           =   1
      Left            =   1320
      Picture         =   "frmMain.frx":6556
      Stretch         =   -1  'True
      Top             =   3360
      Width           =   810
   End
   Begin VB.Image Images 
      Height          =   840
      Index           =   0
      Left            =   1320
      Picture         =   "frmMain.frx":7027
      Stretch         =   -1  'True
      Top             =   2040
      Width           =   825
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
      Left            =   2245
      TabIndex        =   1
      Top             =   3240
      Width           =   1455
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "Yuzu"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   18
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Index           =   0
      Left            =   2200
      TabIndex        =   0
      Top             =   1920
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
    Labels(5).Caption = "2021-2022 是一刀斩哒" & vbCrLf & "版本 " & Version
    If FirstActivate = False Then
        '判断是否第一次显示主窗口
        If GetIni("Tool", "ReadmeCompleted", App.Path & "\Config.ini") <> "Yes" Then hardcodedReadme.Readme    '弹readme
        '公告
        Dim LastAnnounceDay As Integer
        If GetIni("Tool", "LastAnnounceDay", App.Path & "\Config.ini") <> "" Then
            LastAnnounceDay = CInt(GetIni("Tool", "LastAnnounceDay", App.Path & "\Config.ini"))
        Else
            LastAnnounceDay = 0
        End If
        LastAnnounceDay = Day(Now) - LastAnnounceDay
        If LastAnnounceDay <> 1 And LastAnnounceDay <> 0 And LastAnnounceDay <> 2 And LastAnnounceDay <> 3 Then    '四天一次
            If AutoCheckForUpdate Then    '检查更新
                CheckUpdate (True)
            End If

            Dim Announcement As String, AnnouncementCache As String
            Announcement = GetDataStr2(AnnouncementUrl)
            AnnouncementCache = ""
            If CheckFileExists(App.Path & "\.AnnoucementCache.txt") Then
                Open App.Path & "\.AnnoucementCache.txt" For Input As #18
                Input #18, AnnouncementCache
                Close #18
            End If
            If AnnouncementCache <> Announcement Then
                MsgBox Announcement, vbOKOnly, "NS模拟器助手 - 公告"
                Open App.Path & "\.AnnoucementCache.txt" For Output As #18
                Print #18, Announcement
                Close #18
            End If
            WriteIni "Tool", "LastAnnounceDay", CStr(Day(Now)), App.Path & "\Config.ini"
        End If
    End If
    FirstActivate = True
End Sub

Private Sub Form_Initialize()
    InitCommonControls
    '加载配置
    ConfigFileVersion = ""
    If CheckFileExists(App.Path & "\Config.Defaults.ini") = False And CheckFileExists(App.Path & "\Config.ini") = False Then
        MsgBox "配置文件不存在，程序无法启动！", vbCritical    '直接闪退
        End
    End If
    If CheckFileExists(App.Path & "\Config.Defaults.ini") = True And CheckFileExists(App.Path & "\Config.ini") = False Then
        '创建默认配置
        Name App.Path & "\Config.Defaults.ini" As App.Path & "\Config.ini"
    End If
    YuzuInstallFolder = GetIni("Folder", "YuzuInstallFolder", App.Path & "\Config.ini")
    RyujinxInstallFolder = GetIni("Folder", "RyujinxInstallFolder", App.Path & "\Config.ini")
    CloudflareReverseProxyUrl = GetIni("Network", "CloudflareReverseProxyUrl", App.Path & "\Config.ini")
    DownloadSource = GetIni("Network", "DownloadSourceNext", App.Path & "\Config.ini") '更换新的下载源机制
    'AliyundriveDomain = GetIni("Network", "AliyundriveDomain", App.Path & "\Config.ini")
    If DownloadSource = "" Then
        DownloadSource = "Heroku"
        AliyundriveDomain = "https://nsemuhelper.herokuapp.com"
        WriteIni "Network", "DownloadSourceNext", "Heroku", App.Path & "\Config.ini"
    End If
    Select Case DownloadSource
        Case "Heroku": AliyundriveDomain = "https://nsemuhelper.herokuapp.com"
        Case "Azure": AliyundriveDomain = "http://azure.yidaozhan.ga:5678"
        Case "Vercel": AliyundriveDomain = "https://pan.yidaozhan.ga/ns_emu_helper"
        Case "Replit": AliyundriveDomain = "https://onemanager-nsemuhelper.yidaozhanyaqwq.repl.co"
    End Select
    If AliyundriveDomain = "yidaozhan-pan-yidaozhanya.vercel.app" Then
        'v3配置文件 懒得升级了
        AliyundriveDomain = "https://nsemuhelper.herokuapp.com"
    End If
    ConfigFileVersion = GetIni("Tool", "ConfigFileVersion", App.Path & "\Config.ini")
    If Left(GetIni("Network", "AlwaysUseCloudflare", App.Path & "\Config.ini"), 4) = "True" Then
        AlwaysUseCloudflare = True
    Else
        AlwaysUseCloudflare = False
    End If
    If Left(GetIni("Tool", "AutoCheckForUpdate", App.Path & "\Config.ini"), 4) = "True" Then
        AutoCheckForUpdate = True
    Else
        AutoCheckForUpdate = False
    End If
    AnnouncementUrl = ""
    AnnouncementUrl = GetIni("Tool", "AnnouncementUrl", App.Path & "\Config.ini")
    If AnnouncementUrl = "" Then
        '允许自定义公告url
        WriteIni "Tool", "AnnouncementUrl", "https://blog.yidaozhan.ga/nsemuhelper.txt", App.Path & "\Config.ini"
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
            WriteIni "Network", "CloudflareReverseProxyUrl", "https://rp.ydz1.gq", App.Path & "\Config.ini"
            End
        End If
    End If
End Sub

Private Sub Form_Load()
'窗口相关
    Me.Caption = "NS模拟器助手 " & Version
    Labels(6) = "即柚子模拟器" & vbCrLf & "全速畅玩大部分游戏"
    Labels(7) = "即龙神模拟器" & vbCrLf & "兼容性好且功能强大"
End Sub

Private Sub Form_Terminate()
    End
End Sub

Private Sub Form_Unload(Cancel As Integer)
    End
End Sub

Private Sub Images_Click(index As Integer)
    Dim PopMsgBox As Integer
    '图片按钮被点击
    If index = 2 Then
        frmConfig.Show
    Else
        If index = 0 Then
            'Yuzu
            frmManage.IsYuzu = True
            If CheckFileExists(YuzuInstallFolder & "\yuzu.exe") = False Then
                If YuzuInstallFolder = "D:\Yuzu" Then
                    PopMsgBox = MsgBox("在默认的安装位置 D:\Yuzu 中没有找到 Yuzu 模拟器。" & vbCrLf & "点“是”以在该位置安装模拟器，" & vbCrLf & "你也可以在主界面的设置中选择现有的模拟器位置，" & "或者从 Yuzu Tool 4.6 导入。", vbYesNo, "Yuzu 未找到")
                Else
                    PopMsgBox = MsgBox("在你选择的安装位置 " & YuzuInstallFolder & " 中没有找到 Yuzu 模拟器。" & vbCrLf & "点 “是” 以在该位置安装模拟器，" & vbCrLf & "也可以在主界面的设置中选择现有的模拟器位置，" & "或者从 Yuzu Tool 4.6 导入。", vbYesNo, "Yuzu 未找到")
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
                    PopMsgBox = MsgBox("在默认的安装位置 D:\Ryujinx 中没有找到 Ryujinx 模拟器。" & vbCrLf & "点“是”以在默认位置安装模拟器，" & vbCrLf & "你也可以在主界面的设置中选择现有的模拟器位置。", vbYesNo, "Ryujinx 未找到")
                Else
                    PopMsgBox = MsgBox("在你选择的安装位置 " & RyujinxInstallFolder & " 中没有找到 Ryujinx 模拟器。" & vbCrLf & "点 “是” 以在该位置安装模拟器，" & vbCrLf & "也可以在主界面的设置中选择现有的模拟器位置。", vbYesNo, "Ryujinx 未找到")
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

Private Sub Labels_Click(index As Integer)
    If index = 0 Then Images_Click (0)
    If index = 1 Then Images_Click (1)
End Sub
