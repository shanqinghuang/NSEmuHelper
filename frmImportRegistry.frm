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
   Begin VB.ComboBox Combo2 
      Height          =   435
      Left            =   720
      TabIndex        =   4
      Text            =   "Combo1"
      Top             =   1680
      Width           =   1695
   End
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
      Left            =   2640
      TabIndex        =   2
      Text            =   "Combo1"
      Top             =   1680
      Width           =   3255
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
      Caption         =   "从 Yuzu Tool 导入模拟器"
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
Private Sub LoadRegistryYuzuTool()
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
        Combo1.Text = "Yuzu 预先测试版 " & Left(sKeyName, lenKeyName)
        Combo1.AddItem Combo1.Text
        lenKeyName = 1024
        I = I + 1
        n = RegEnumKeyEx(lhKey, I, sKeyName, lenKeyName, 0, vbNullString, 0, tFT)
    Loop
    RegCloseKey lhKey
End Sub
Private Sub LoadRegistryRyuzuTool()
Combo1.Clear
Dim wsh As Object, YuzuInstallFolder As String
Set wsh = CreateObject("WScript.Shell")
Combo1.Text = "Yuzu 预先测试版 " & wsh.RegRead("HKCU\Software\RyuzuTool\Yuzu\Version")
Combo1.AddItem Combo1.Text
Combo1.AddItem "Ryujinx " & wsh.RegRead("HKCU\Software\RyuzuTool\Ryujinx\Version")
End Sub

Private Sub ImportFromYuzuTool()
Dim wsh As Object, YuzuInstallFolder As String
Set wsh = CreateObject("WScript.Shell")
YuzuInstallFolder = wsh.RegRead("HKCU\Software\YuzuTool\" & Replace(Combo1.Text, "Yuzu 预先测试版 ", "") & "\InstallFolder")
WriteIni "Folder", "YuzuInstallFolder", YuzuInstallFolder, App.Path & "\Config.ini"
WriteIni "Yuzu", "Version", Replace(Combo1.Text, "Yuzu 预先测试版 ", ""), YuzuInstallFolder & "\YuzuConfig.ini"
WriteIni "Yuzu", "Branch", "预先测试版", YuzuInstallFolder & "\YuzuConfig.ini"
WriteIni "Yuzu", "Firmware", "13.2.1", YuzuInstallFolder & "\YuzuConfig.ini"
WriteIni "Yuzu", "CustomDataFolder", "False", YuzuInstallFolder & "\YuzuConfig.ini"
MsgBox Combo1.Text & " 已经导入到本工具！", vbInformation, "NS 模拟器助手"
End Sub
Private Sub ImportFromRyuzuTool()
Dim wsh As Object
Set wsh = CreateObject("WScript.Shell")
If Left(Combo1.Text, 4) = "Yuzu" Then
    Dim YuzuInstallFolder As String, YuzuBranch As String, YuzuFirmware As String
    YuzuInstallFolder = wsh.RegRead("HKCU\Software\RyuzuTool\Yuzu\InstallFolder")
    WriteIni "Folder", "YuzuInstallFolder", YuzuInstallFolder, App.Path & "\Config.ini"
    WriteIni "Yuzu", "Version", Replace(Combo1.Text, "Yuzu 预先测试版 ", ""), YuzuInstallFolder & "\YuzuConfig.ini"
    YuzuBranch = wsh.RegRead("HKCU\Software\RyuzuTool\Yuzu\EA")
    If YuzuBranch = "True" Then
        YuzuBranch = "预先测试版"
    Else
        YuzuBranch = "主线版"
    End If
    WriteIni "Yuzu", "Branch", YuzuBranch, YuzuInstallFolder & "\YuzuConfig.ini"
    YuzuFirmware = wsh.RegRead("HKCU\Software\RyuzuTool\Yuzu\Firmver")
    WriteIni "Yuzu", "Firmware", YuzuFirmware, YuzuInstallFolder & "\YuzuConfig.ini"
    WriteIni "Yuzu", "CustomDataFolder", "False", YuzuInstallFolder & "\YuzuConfig.ini"
    MsgBox Combo1.Text & " 已经导入到本工具！", vbInformation, "NS 模拟器助手"
Else
    Dim RyujinxInstallFolder As String, RyujinxFirmware As String, RyujinxBranch As String
    RyujinxInstallFolder = wsh.RegRead("HKCU\Software\RyuzuTool\Ryujinx\InstallFolder")
    WriteIni "Folder", "RyujinxInstallFolder", RyujinxInstallFolder, App.Path & "\Config.ini"
    WriteIni "Ryujinx", "Version", Replace(Combo1.Text, "Ryujinx ", ""), RyujinxInstallFolder & "\RyujinxConfig.ini"
    Select Case wsh.RegRead("HKCU\Software\RyuzuTool\Ryujinx\MCL")
        Case "EN"
        RyujinxBranch = "主线版"
        Case "CN"
        RyujinxBranch = "中文版"
        Case Else
        RyujinxBranch = "主线版"
    End Select
    WriteIni "Ryujinx", "Branch", RyujinxBranch, RyujinxInstallFolder & "\RyujinxConfig.ini"
    RyujinxFirmware = wsh.RegRead("HKCU\Software\RyuzuTool\Ryujinx\Firmver")
    WriteIni "Ryujinx", "Firmware", RyujinxFirmware, RyujinxInstallFolder & "\RyujinxConfig.ini"
    WriteIni "Ryujinx", "CustomDataFolder", "False", RyujinxInstallFolder & "\RyujinxConfig.ini"
    MsgBox Combo1.Text & " 已经导入到本工具！", vbInformation, "NS 模拟器助手"
End If
End
End Sub

Private Sub Combo2_Click()
If Combo2.Text = "Yuzu Tool" Then
    Labels(0).Caption = "从 Yuzu Tool 导入模拟器"
    Labels(1).Caption = "请选择要导入到 NS 模拟器助手的 Yuzu 版本。"
    LoadRegistryYuzuTool
Else
    Labels(0).Caption = "从 Ryuzu Tool 导入模拟器"
    Labels(1).Caption = "请选择要导入到 NS 模拟器助手的模拟器。"
    LoadRegistryRyuzuTool
End If
Me.Caption = Labels(0).Caption
End Sub

Private Sub Command1_Click()
If Combo2.Text = "Yuzu Tool" Then
    ImportFromYuzuTool
Else
    ImportFromRyuzuTool
End If
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
Combo2.Clear
Combo2.AddItem "Yuzu Tool"
Combo2.AddItem "Ryuzu Tool"
Combo2.Text = "Yuzu Tool"
LoadRegistryYuzuTool
End Sub

