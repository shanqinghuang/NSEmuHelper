VERSION 5.00
Begin VB.Form frmImportRegistry 
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "从 Yuzu Tool 导入注册表"
   ClientHeight    =   3585
   ClientLeft      =   45
   ClientTop       =   390
   ClientWidth     =   6615
   BeginProperty Font 
      Name            =   "微软雅黑 Light"
      Size            =   12
      Charset         =   134
      Weight          =   290
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmImportRegistry.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3585
   ScaleWidth      =   6615
   StartUpPosition =   3  '窗口缺省
   Begin VB.CommandButton Command1 
      Caption         =   "下一步"
      Height          =   495
      Left            =   4800
      TabIndex        =   3
      Top             =   2880
      Width           =   1575
   End
   Begin VB.ComboBox Combo1 
      Height          =   435
      Left            =   1440
      TabIndex        =   2
      Text            =   "Combo1"
      Top             =   1680
      Width           =   3735
   End
   Begin VB.Label Labels 
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "仅支持 Yuzu Tool 4.6"
      Height          =   375
      Index           =   2
      Left            =   120
      TabIndex        =   4
      Top             =   3000
      Width           =   5295
   End
   Begin VB.Label Labels 
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "请选择要导入到 NS 模拟器助手的 Yuzu 版本。"
      Height          =   375
      Index           =   1
      Left            =   120
      TabIndex        =   1
      Top             =   600
      Width           =   5295
   End
   Begin VB.Label Labels 
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "从 Yuzu Tool 导入注册表"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   14.25
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   6255
   End
End
Attribute VB_Name = "frmImportRegistry"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub LoadRegistry()
Combo1.Clear
    Dim lhKey As Long
    Dim I As Long
    Dim sKeyName As String
    Dim lenKeyName As Long
    Dim tFT As FILETIME
    I = 0
    sKeyName = Space(1024)
    lenKeyName = 1024
    RegOpenKey HKEY_CURRENT_USER, "Software\YuzuTool", lhKey
    n = RegEnumKeyEx(lhKey, I, sKeyName, lenKeyName, 0, vbNullString, 0, tFT)
    Do Until n <> 0
        Combo1.AddItem Left(sKeyName, lenKeyName)
        Combo1.Text = Left(sKeyName, lenKeyName)
        lenKeyName = 1024
        I = I + 1
        n = RegEnumKeyEx(lhKey, I, sKeyName, lenKeyName, 0, vbNullString, 0, tFT)
    Loop
    RegCloseKey lhKey
End Sub

Private Sub LoadInstallFolder()
Dim wsh As Object, YuzuInstallFolder As String
Set wsh = CreateObject("WScript.Shell")
YuzuInstallFolder = wsh.RegRead("HKCU\Software\YuzuTool\" & Combo1.Text & "\InstallFolder")
WriteIni "Folder", "YuzuInstallFolder", YuzuInstallFolder, App.Path & "\Config.ini"
WriteIni "Yuzu", "Version", Combo1.Text, YuzuInstallFolder & "\YuzuConfig.ini"
WriteIni "Yuzu", "Branch", "预先测试版", YuzuInstallFolder & "\YuzuConfig.ini"
WriteIni "Yuzu", "Firmware", "13.2.1", YuzuInstallFolder & "\YuzuConfig.ini"
WriteIni "Yuzu", "CustomDataFolder", "False", YuzuInstallFolder & "\YuzuConfig.ini"
MsgBox "Yuzu Early Access " & Combo1.Text & " 已经导入到本工具！", vbInformation, "NS 模拟器助手"
End Sub

Private Sub Command1_Click()
        LoadInstallFolder
End Sub

Private Sub Form_Initialize()
InitCommonControls
End Sub

Private Sub Form_Load()
If CheckFileExists(App.Path & "\Config.ini") = False And CheckFileExists(App.Path & "\Config.Defaults.ini") = False Then
    MsgBox "请把本程序放到 NS 模拟器助手所在文件夹之后重试！"
    End
End If
If CheckFileExists(App.Path & "\Config.Defaults.ini") = True And CheckFileExists(App.Path & "\Config.ini") = False Then
'创建默认配置
Name App.Path & "\Config.Defaults.ini" As App.Path & "\Config.ini"
End If
LoadRegistry
End Sub
