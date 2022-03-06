VERSION 5.00
Object = "{A5E8A7E4-5CB9-46EB-8987-15503F7E5563}#34.0#0"; "yfui.ocx"
Begin VB.Form frmAbout 
   BackColor       =   &H80000005&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "关于我的应用程序"
   ClientHeight    =   4230
   ClientLeft      =   2340
   ClientTop       =   1935
   ClientWidth     =   5730
   ClipControls    =   0   'False
   BeginProperty Font 
      Name            =   "微软雅黑 Light"
      Size            =   12
      Charset         =   134
      Weight          =   290
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2919.621
   ScaleMode       =   0  'User
   ScaleWidth      =   5380.766
   ShowInTaskbar   =   0   'False
   Begin YFUI.YFButton Command1 
      Default         =   -1  'True
      Height          =   495
      Left            =   3840
      TabIndex        =   8
      Tag             =   "T"
      Top             =   3480
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   873
      Caption         =   "关闭"
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
      Data            =   "frmAbout.frx":0000
   End
   Begin YFUI.YFButton cmdUpdate 
      Height          =   495
      Left            =   2040
      TabIndex        =   9
      Tag             =   "T"
      Top             =   3480
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   873
      Caption         =   "检查更新"
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
      Data            =   "frmAbout.frx":0018
   End
   Begin YFUI.YFButton btnCredits 
      Height          =   495
      Left            =   240
      TabIndex        =   10
      Tag             =   "T"
      Top             =   3480
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   873
      Caption         =   "谢志"
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
      Data            =   "frmAbout.frx":0030
   End
   Begin VB.Label Label 
      BackStyle       =   0  'Transparent
      Caption         =   "QQ：模拟器交流群"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   10.5
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   375
      Index           =   3
      Left            =   3240
      TabIndex        =   7
      Top             =   2760
      Width           =   2295
   End
   Begin VB.Label Label 
      BackStyle       =   0  'Transparent
      Caption         =   "Github：YidaozhanYa"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   10.5
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   375
      Index           =   2
      Left            =   240
      TabIndex        =   6
      Top             =   2760
      Width           =   2295
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "联系我："
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   10.5
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   330
      Left            =   240
      TabIndex        =   5
      Top             =   2040
      Width           =   1245
   End
   Begin VB.Label Label 
      BackStyle       =   0  'Transparent
      Caption         =   "贴吧：是一刀斩哒"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   10.5
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   375
      Index           =   1
      Left            =   3240
      TabIndex        =   4
      Top             =   2400
      Width           =   2295
   End
   Begin VB.Label Label 
      BackStyle       =   0  'Transparent
      Caption         =   "Bilibili：是一刀斩哒"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   10.5
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   3
      Top             =   2400
      Width           =   2295
   End
   Begin VB.Image Images 
      Height          =   600
      Index           =   0
      Left            =   240
      Picture         =   "frmAbout.frx":0048
      Stretch         =   -1  'True
      Top             =   240
      Width           =   615
   End
   Begin VB.Label lblDescription 
      BackStyle       =   0  'Transparent
      Caption         =   "受到 Yuzu Tool 启发的 NS 模拟器 (Yuzu / Ryujinx) 一键安装 / 配置工具，使用 VB6 编写。"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   10.5
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   1050
      Left            =   240
      TabIndex        =   0
      Top             =   1200
      Width           =   5325
   End
   Begin VB.Label lblTitle 
      BackStyle       =   0  'Transparent
      Caption         =   "应用程序标题"
      ForeColor       =   &H00000000&
      Height          =   480
      Left            =   1080
      TabIndex        =   1
      Top             =   120
      Width           =   3885
   End
   Begin VB.Line Line1 
      BorderColor     =   &H00FFFFFF&
      BorderWidth     =   2
      Index           =   0
      X1              =   98.6
      X2              =   5309.398
      Y1              =   1697.936
      Y2              =   1697.936
   End
   Begin VB.Label lblVersion 
      BackStyle       =   0  'Transparent
      Caption         =   "版本"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   9
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   585
      Left            =   1080
      TabIndex        =   2
      Top             =   480
      Width           =   3885
   End
End
Attribute VB_Name = "frmAbout"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub btnCredits_Click()
MsgBox "-- NS模拟器助手 谢志 --" & vbCrLf & vbCrLf & _
    "本应用程序使用的开源项目有：" & vbCrLf & "- YFUI 扁平化控件库 by jy4977596491" & vbCrLf & "  http://www.vbgood.com/thread-776224-1-1.html" & vbCrLf & _
    "- VBJSON By Michael Glaser" & vbCrLf & "  http://www.ediy.co.nz/vbjson-json-parser-library-in-vb6-xidc55680.html" & vbCrLf & _
    "- EnumWindows v2 By Jenova" & vbCrLf & "  https://www.vbforums.com/showthread.php?445492-EnumWindows-Example" & vbCrLf & vbCrLf & _
    "本项目服务器使用的开源项目有：" & vbCrLf & _
    "- OneManager-php by 逸笙" & vbCrLf & "  https://github.com/qkqpttgf/OneManager-php" & vbCrLf & _
    "- 阿里云盘 CLI By wxy1343" & vbCrLf & "  https://github.com/wxy1343/aliyunpan" & vbCrLf & _
    vbCrLf & vbCrLf & _
    "本项目以 MIT 许可证开源，你可以在 https://github.com/YidaozhanYa/NSEmuHelper 找到源码。"
End Sub

Private Sub cmdUpdate_Click()
    CheckUpdate False
End Sub

Private Sub Command1_Click()
    Unload Me
End Sub

Private Sub Form_Load()
    Me.Icon = frmMain.Icon
    Me.Caption = "关于 " & App.Title
    lblVersion.Caption = "2022 是一刀斩哒" & vbCrLf & "版本 " & Version
    lblTitle.Caption = App.Title
End Sub

Private Sub Label_Click(Index As Integer)
    Select Case Index
    Case 0
        OpenLink "https://space.bilibili.com/485832788"
    Case 1
        OpenLink "https://tieba.baidu.com/home/main?id=tb.1.f6274ce2.uLblXrOenttfPybpAgmUcw"
    Case 2
        OpenLink "https://github.com/YidaozhanYa"
    Case 3
        MsgBox "867575912", vbOKOnly, "群号已复制到剪贴板。"
        Clipboard.SetText "867575912"
        Unload Me
    End Select
End Sub

