VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{A5E8A7E4-5CB9-46EB-8987-15503F7E5563}#34.0#0"; "yfui.ocx"
Begin VB.Form frmRyujinxConfig 
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "frmYuzuConfig"
   ClientHeight    =   4920
   ClientLeft      =   5625
   ClientTop       =   3120
   ClientWidth     =   6540
   BeginProperty Font 
      Name            =   "微软雅黑 Light"
      Size            =   12
      Charset         =   134
      Weight          =   290
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmRyujinxConfig.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4920
   ScaleWidth      =   6540
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   1200
      Top             =   120
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
            Picture         =   "frmRyujinxConfig.frx":54AA
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmRyujinxConfig.frx":A964
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin YFUI.YFComboBox ImageCombo1 
      Height          =   375
      Left            =   1560
      TabIndex        =   4
      Tag             =   "W"
      Top             =   960
      Width           =   2895
      _ExtentX        =   5106
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
   Begin YFUI.YFTextBox txtVersion 
      Height          =   375
      Left            =   4560
      TabIndex        =   5
      Tag             =   "W"
      Top             =   960
      Width           =   1815
      _ExtentX        =   3201
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
   Begin YFUI.YFComboBox cbFirmware 
      Height          =   375
      Left            =   1560
      TabIndex        =   6
      Tag             =   "W"
      Top             =   1680
      Width           =   2895
      _ExtentX        =   5106
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
   Begin YFUI.YFCheckBox Checks 
      Height          =   255
      Left            =   2280
      TabIndex        =   7
      Top             =   2820
      Width           =   855
      _ExtentX        =   1508
      _ExtentY        =   450
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
   Begin YFUI.YFTextBox txtDataFolder 
      Height          =   375
      Left            =   120
      TabIndex        =   8
      Tag             =   "W"
      Top             =   3240
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   661
      Tip             =   "<请点击“浏览”>"
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
      Text            =   "<请点击“浏览”>"
   End
   Begin YFUI.YFButton btnBrowse 
      Default         =   -1  'True
      Height          =   375
      Left            =   5280
      TabIndex        =   9
      Top             =   3240
      Width           =   1095
      _ExtentX        =   1931
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
      Data            =   "frmRyujinxConfig.frx":307FE
   End
   Begin YFUI.YFButton btnCancel 
      Cancel          =   -1  'True
      Height          =   495
      Left            =   4920
      TabIndex        =   10
      Tag             =   "T"
      Top             =   4200
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
      Data            =   "frmRyujinxConfig.frx":30816
   End
   Begin YFUI.YFButton btnSave 
      Height          =   495
      Left            =   3240
      TabIndex        =   11
      Tag             =   "T"
      Top             =   4200
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
      Data            =   "frmRyujinxConfig.frx":3082E
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "自定义数据文件夹："
      Height          =   495
      Index           =   3
      Left            =   120
      TabIndex        =   3
      Top             =   2760
      Width           =   2415
   End
   Begin VB.Image Image1 
      Height          =   735
      Left            =   5640
      Stretch         =   -1  'True
      Top             =   120
      Width           =   735
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "固件版本："
      Height          =   495
      Index           =   2
      Left            =   120
      TabIndex        =   2
      Top             =   1680
      Width           =   1695
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "模拟器版本："
      Height          =   495
      Index           =   1
      Left            =   120
      TabIndex        =   1
      Top             =   960
      Width           =   1695
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "Label1"
      Height          =   735
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   6255
   End
End
Attribute VB_Name = "frmRyujinxConfig"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public IsMissing As Boolean, RyujinxPreDataFolder As String
Attribute RyujinxPreDataFolder.VB_VarUserMemId = 1073938432

Private Sub btnBrowse_Click()
    txtDataFolder.Text = ChooseDir("自定义数据文件夹", Me)
    If txtDataFolder.Text = RyujinxInstallFolder & "\portable" Then
        txtDataFolder.Text = "<请点击“浏览”>"
        btnBrowse.Visible = False
        txtDataFolder.Visible = False
        Checks.Value = False
        MsgBox "自定义数据文件夹不能和默认数据文件夹一样！", vbOKOnly + vbExclamation, "错误"
    End If
End Sub

Private Sub btnCancel_Click()
    If IsMissing Then
        Unload frmManage
        frmMain.Show
    Else
        frmManage.Show
    End If
    Unload Me
End Sub

Private Sub btnSave_Click()
'保存设置
    If cbFirmware.Text <> "加载中 ..." Then
        RyujinxBranch = ImageCombo1.Text
        RyujinxVersion = txtVersion.Text
        RyujinxFirmware = cbFirmware.Text
        WriteIni "Ryujinx", "Version", RyujinxVersion, RyujinxInstallFolder & "\RyujinxConfig.ini"
        WriteIni "Ryujinx", "Branch", RyujinxBranch, RyujinxInstallFolder & "\RyujinxConfig.ini"
        WriteIni "Ryujinx", "Firmware", RyujinxFirmware, RyujinxInstallFolder & "\RyujinxConfig.ini"

        If IsMissing = False Then
            If Checks.Value = False Then
                RyujinxCustomDataFolder = "False"
            Else
                If txtDataFolder.Text = "<请点击“浏览”>" Then
                    RyujinxCustomDataFolder = "False"
                Else
                    RyujinxCustomDataFolder = txtDataFolder.Text
                End If
            End If
            If RyujinxCustomDataFolder = RyujinxInstallFolder & "\portable" Then RyujinxCustomDataFolder = "False"
            MoveRyujinxDataFolder
            WriteIni "Ryujinx", "CustomDataFolder", RyujinxCustomDataFolder, RyujinxInstallFolder & "\RyujinxConfig.ini"
        Else
            RyujinxCustomDataFolder = "False"
            WriteIni "Ryujinx", "CustomDataFolder", RyujinxCustomDataFolder, RyujinxInstallFolder & "\RyujinxConfig.ini"
        End If
        If IsMissing Then
            Unload frmManage
            frmMain.Show
        Else
            frmManage.Show
        End If

        '迁移数据相关
        Dim fso As Object
        If Dir$(Environ("AppData") & "\Ryujinx", vbDirectory) <> "" Then
            'appdata存在
            If Dir$(RyujinxInstallFolder & "\portable", vbDirectory) <> "" Then
            Else
                'user不存在
                Set fso = CreateObject("Scripting.FileSystemObject")    '创建FSO
                Set folder = fso.GetFolder(Environ("AppData") & "\Ryujinx")
                folder.Move RyujinxInstallFolder & "\portable"
                Set folder = Nothing
                Set fso = Nothing
                MsgBox "之前的模拟器数据存放在 C 盘，已经自动迁移到模拟器文件夹。", vbOKOnly + vbInformation, "提示"
            End If
        End If
        Unload Me
    End If
End Sub


Private Sub cbFirmware_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub Checks_Click()
'选框
    If Checks.Value = True Then
        btnBrowse.Visible = True: txtDataFolder.Visible = True
    Else
        btnBrowse.Visible = False: txtDataFolder.Visible = False
    End If
End Sub

Private Sub Form_Activate()
'加载设置和界面
    Debug.Print RyujinxCustomDataFolder
    If RyujinxCustomDataFolder = RyujinxInstallFolder & "\portable" Then
        RyujinxCustomDataFolder = "False"
        WriteIni "Ryujinx", "CustomDataFolder", RyujinxCustomDataFolder, RyujinxInstallFolder & "\RyujinxConfig.ini"
    End If

    If RyujinxCustomDataFolder = "False" Then
        Checks.Value = False
        btnBrowse.Visible = False
        txtDataFolder.Visible = False
    Else
        Checks.Value = True
        btnBrowse.Visible = True
        txtDataFolder.Visible = True
        txtDataFolder.Text = RyujinxCustomDataFolder
    End If
    If Left(RyujinxBranch, 3) = "LDN" Then
        Image1.Picture = frmRyujinxInstaller.ImageList2.ListImages(2).Picture
    Else
        Image1.Picture = frmRyujinxInstaller.ImageList2.ListImages(1).Picture
    End If
    'Unload frmRyujinxInstaller
    RyujinxPreDataFolder = RyujinxCustomDataFolder

    Me.Caption = "Ryujinx 模拟器相关设置"
    If IsMissing Then
        '没有RyujinxConfig.ini
        Labels(0).Caption = "该模拟器不是用本工具安装的，" & vbCrLf & "请先完善它的版本信息。"
        Labels(3).Visible = False
        Checks.Visible = False
        txtDataFolder.Visible = False
        btnBrowse.Visible = fase
        btnSave.Top = 2520
        btnCancel.Top = 2520
        Me.Height = 3650

        frmManage.Hide
        frmRyujinxConfig.SetFocus
    Else
        Labels(0).Caption = "Ryujinx 版本信息设置" & vbCrLf & "如果你手动更新了模拟器，可以在此更改版本信息。"
        btnSave.Top = 4200
        btnCancel.Top = 4200
        Me.Height = 5325
    End If
    ImageCombo1.Clear
    ImageCombo1.AddItem "主线版"
    ImageCombo1.AddItem "中文版"
    ImageCombo1.AddItem "LDN联机版"
    ImageCombo1.AddItem "Vulkan"
    cbFirmware.Text = "加载中 ..."

    DoEvents
    WindowList = ""
    Shell RyujinxInstallFolder & "\Ryujinx.exe"
    Dim tmpRyujinxName As String
    Do Until InStr(tmpRyujinxName, "Ryujinx Console") <> False
        '遍历所有窗口句柄
        Call EnumWindows(AddressOf EnumAllWindows, ByVal 0&)
        tmpRyujinxName = Join(Filter(Split(WindowList, vbCrLf), "Ryujinx Console"), vbCrLf)
        DoEvents
        Sleep 100
    Loop
    Shell "cmd /c taskkill /f /im Ryujinx.exe"
    tmpRyujinxName = Replace(tmpRyujinxName, "Ryujinx Console ", "")
    If InStr(tmpRyujinxName, "vulkan") Then
        ImageCombo1.Text = "Vulkan"
        txtVersion.Text = Replace(tmpRyujinxName, "-vulkan", "")
    ElseIf InStr(tmpRyujinxName, "ldn") Then
        ImageCombo1.Text = "LDN联机版"
        txtVersion.Text = tmpRyujinxName
    Else
        ImageCombo1.Text = "主线版"
        txtVersion.Text = tmpRyujinxName
    End If
    txtVersion.SetFocus

    Dim FirmwareVersionArr() As String
    If AlwaysUseCloudFlare = "Never" Then
        FirmwareVersionArr = Split(Replace(Replace(Join(Filter(Split(Replace(Replace(GetDataStr2("https://archive.org/download/nintendo-switch-global-firmwares/nintendo-switch-global-firmwares_files.xml"), Chr(34), ""), " ", ""), vbLf), ".zip"), vbCrLf), "<filename=Firmware", ""), ".zipsource=original>", ""), vbCrLf)
    Else
        FirmwareVersionArr = Split(Replace(Replace(Join(Filter(Split(Replace(Replace(GetDataStr2(CloudFlareReverseProxyUrl & "/https://archive.org/download/nintendo-switch-global-firmwares/nintendo-switch-global-firmwares_files.xml"), Chr(34), ""), " ", ""), vbLf), ".zip"), vbCrLf), "<filename=Firmware", ""), ".zipsource=original>", ""), vbCrLf)
    End If
    Dim I As Integer
    For I = 0 To (UBound(FirmwareVersionArr) - LBound(FirmwareVersionArr))
        cbFirmware.AddItem FirmwareVersionArr(I)
    Next
    If IsMissing Then
        cbFirmware.Text = "选择固件版本"
    Else
        cbFirmware.Text = RyujinxFirmware
    End If

End Sub

Private Sub Form_Initialize()
    InitCommonControls
End Sub

Private Sub ImageCombo1_Click()
    txtVersion.Text = "加载中 ..."
    If ImageCombo1.ListIndex = 2 Then
        Image1.Picture = frmRyujinxInstaller.ImageList2.ListImages(2).Picture
        Dim Tmp() As String
        Tmp = Split(GetRyujinxLDNVersionAli, vbCrLf)
        txtVersion.Text = Tmp(UBound(Tmp))
    Else
        Image1.Picture = frmRyujinxInstaller.ImageList2.ListImages(1).Picture
        txtVersion.Text = GetRyujinxVersion
    End If
    txtVersion.SetFocus
End Sub

Private Sub ImageCombo1_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub txtVersion_KeyPress(KeyAscii As Integer)
'只能输入数字
    If KeyAscii = 8 Or KeyAscii = 46 Then Exit Sub
    If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
End Sub

Private Sub MoveRyujinxDataFolder()
    On Error GoTo MoveFailed2
    Dim fso As Object, folder As Object
    '迁移 Ryujinx 数据文件夹
    'RyujinxPreDataFolder 前数据文件夹
    If RyujinxPreDataFolder = RyujinxCustomDataFolder Then Exit Sub
    If RyujinxPreDataFolder = "False" Or RyujinxPreDataFolder = "<请点击“浏览”>" Then RyujinxPreDataFolder = RyujinxInstallFolder & "\portable"
    If RyujinxCustomDataFolder = "False" Or RyujinxCustomDataFolder = "<请点击“浏览”>" Then RyujinxCustomDataFolder = RyujinxInstallFolder & "\portable"
    If TestEmptyFolder(RyujinxCustomDataFolder) = False Then
        MsgBox "新的数据文件夹为:" & RyujinxCustomDataFolder & vbCrLf & "这个文件夹非空，迁移失败！" & vbCrLf & "请清空该文件夹之后再试。", vbOKOnly + vbCritical, "错误"
        GoTo MoveFailed
    End If
    If RyujinxCustomDataFolder <> RyujinxInstallFolder & "\portable" Then
        '新文件夹空了，继续迁移
        '移动内容
        Set fso = CreateObject("Scripting.FileSystemObject")    '创建FSO
        Set folder = fso.GetFolder(RyujinxPreDataFolder)
        RmDir RyujinxCustomDataFolder
        folder.Move RyujinxCustomDataFolder
        Set folder = Nothing
        Set fso = Nothing
        '创建符号链接
        Shell "cmd /c mklink /d /j " & Chr(34) & RyujinxInstallFolder & "\portable" & Chr(34) & " " & Chr(34) & RyujinxCustomDataFolder & Chr(34)
    Else
        '迁移回 portable 文件夹
        Shell "cmd /c rmdir " & Chr(34) & RyujinxInstallFolder & "\portable" & Chr(34)    ' 删除旧的符号链接
        '移动内容
        Set fso = CreateObject("Scripting.FileSystemObject")    '创建FSO
        Set folder = fso.GetFolder(RyujinxPreDataFolder)
        RmDir RyujinxInstallFolder & "\portable"
        folder.Move RyujinxInstallFolder & "\portable"
        Set folder = Nothing
        Set fso = Nothing
    End If
    MsgBox "数据文件夹迁移成功！" & vbCrLf & vbCrLf & "从 " & RyujinxPreDataFolder & "，" & vbCrLf & "迁移到了 " & RyujinxCustomDataFolder & "。", vbOKOnly + vbInformation, "提示"
    Exit Sub

MoveFailed:
    If RyujinxPreDataFolder = RyujinxInstallFolder & "\portable" Then RyujinxPreDataFolder = "False"
    If RyujinxCustomDataFolder = RyujinxInstallFolder & "\portable" Then RyujinxCustomDataFolder = "False"
    RyujinxCustomDataFolder = RyujinxPreDataFolder
    WriteIni "Ryujinx", "CustomDataFolder", RyujinxCustomDataFolder, RyujinxInstallFolder & "\RyujinxConfig.ini"
    Exit Sub

MoveFailed2:
    MsgBox "迁移失败，发生了未知错误。" & vbCrLf & "运行时错误 " & CStr(Err.Number) & "：" & Err.Description, vbOKOnly + vbCritical, "错误"
    If RyujinxPreDataFolder = RyujinxInstallFolder & "\portable" Then RyujinxPreDataFolder = "False"
    If RyujinxCustomDataFolder = RyujinxInstallFolder & "\portable" Then RyujinxCustomDataFolder = "False"
    RyujinxCustomDataFolder = RyujinxPreDataFolder
    WriteIni "Ryujinx", "CustomDataFolder", RyujinxCustomDataFolder, RyujinxInstallFolder & "\RyujinxConfig.ini"
    Exit Sub
End Sub

Private Function TestEmptyFolder(FolderName As String) As Boolean
    On Error GoTo Err
    RmDir (FolderName)    '删除目录，如果出错表示不为空
    MkDir (FolderName)    '重新建目录
    TestEmptyFolder = True
    Exit Function
Err:
    TestEmptyFolder = False
End Function
