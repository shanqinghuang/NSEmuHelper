VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmYuzuConfig 
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
   Icon            =   "frmYuzuConfig.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4920
   ScaleWidth      =   6540
   Begin VB.CommandButton btnBrowse 
      Caption         =   "浏览"
      Height          =   375
      Left            =   5400
      TabIndex        =   11
      Top             =   3240
      Width           =   975
   End
   Begin VB.TextBox txtDataFolder 
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   10.5
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      IMEMode         =   3  'DISABLE
      Left            =   120
      TabIndex        =   10
      Text            =   "<请点击“浏览”>"
      Top             =   3240
      Width           =   5175
   End
   Begin VB.CheckBox Checks 
      BackColor       =   &H80000005&
      Caption         =   "否"
      Height          =   420
      Index           =   0
      Left            =   2520
      TabIndex        =   8
      Top             =   2760
      Width           =   735
   End
   Begin VB.ComboBox cbFirmware 
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   10.5
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   420
      Left            =   1560
      TabIndex        =   7
      Text            =   "Combo1"
      Top             =   1680
      Width           =   2295
   End
   Begin VB.CommandButton btnSave 
      Caption         =   "保存"
      Height          =   495
      Left            =   3240
      TabIndex        =   5
      Top             =   4200
      Width           =   1455
   End
   Begin VB.CommandButton btnCancel 
      Caption         =   "取消"
      Height          =   495
      Left            =   4920
      TabIndex        =   4
      Top             =   4200
      Width           =   1455
   End
   Begin VB.TextBox txtVersion 
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   10.5
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      IMEMode         =   3  'DISABLE
      Left            =   4080
      TabIndex        =   3
      Text            =   "加载中 ..."
      Top             =   960
      Width           =   1695
   End
   Begin MSComctlLib.ImageCombo ImageCombo1 
      Height          =   435
      Left            =   1560
      TabIndex        =   2
      Top             =   960
      Width           =   2295
      _ExtentX        =   4048
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
            Picture         =   "frmYuzuConfig.frx":54AA
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmYuzuConfig.frx":A964
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "自定义数据文件夹："
      Height          =   495
      Index           =   3
      Left            =   120
      TabIndex        =   9
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
      TabIndex        =   6
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
Attribute VB_Name = "frmYuzuConfig"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public IsMissing As Boolean, YuzuPreDataFolder As String
Attribute YuzuPreDataFolder.VB_VarUserMemId = 1073938432

Private Sub btnBrowse_Click()
    txtDataFolder.Text = ChooseDir("自定义数据文件夹", Me)
    If txtDataFolder.Text = YuzuInstallFolder & "\user" Then
        txtDataFolder.Text = "<请点击“浏览”>"
        btnBrowse.Visible = False
        txtDataFolder.Visible = False
        Checks(0).Value = 0
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
        If ImageCombo1.SelectedItem.key = "EA" Then
            YuzuBranch = "预先测试版"
        Else
            YuzuBranch = "主线版"
        End If
        YuzuVersion = txtVersion.Text
        YuzuFirmware = cbFirmware.Text
        WriteIni "Yuzu", "Version", YuzuVersion, YuzuInstallFolder & "\YuzuConfig.ini"
        WriteIni "Yuzu", "Branch", YuzuBranch, YuzuInstallFolder & "\YuzuConfig.ini"
        WriteIni "Yuzu", "Firmware", YuzuFirmware, YuzuInstallFolder & "\YuzuConfig.ini"

        If IsMissing = False Then
            If Checks(0).Value = 0 Then
                YuzuCustomDataFolder = "False"
            Else
                If txtDataFolder.Text = "<请点击“浏览”>" Then
                    YuzuCustomDataFolder = "False"
                Else
                    YuzuCustomDataFolder = txtDataFolder.Text
                End If
            End If
            If YuzuCustomDataFolder = YuzuInstallFolder & "\user" Then YuzuCustomDataFolder = "False"
            MoveYuzuDataFolder
            WriteIni "Yuzu", "CustomDataFolder", YuzuCustomDataFolder, YuzuInstallFolder & "\YuzuConfig.ini"
        Else
            YuzuCustomDataFolder = "False"
            WriteIni "Yuzu", "CustomDataFolder", YuzuCustomDataFolder, YuzuInstallFolder & "\YuzuConfig.ini"
        End If
        If IsMissing Then
            Unload frmManage
            frmMain.Show
        Else
            frmManage.Show
        End If

        If IsMissing = True Then
            '迁移数据相关
            Dim fso As Object
            If Dir$(Environ("AppData") & "\yuzu", vbDirectory) <> "" Then
                'appdata存在
                If Dir$(YuzuInstallFolder & "\user", vbDirectory) <> "" Then
                Else
                    'user不存在
                    Set fso = CreateObject("Scripting.FileSystemObject")    '创建FSO
                    Set folder = fso.GetFolder(Environ("AppData") & "\yuzu")
                    folder.Move YuzuInstallFolder & "\user"
                    Set folder = Nothing
                    Set fso = Nothing
                    MsgBox "之前的模拟器数据存放在 C 盘，已经自动迁移到模拟器文件夹。", vbOKOnly + vbInformation, "提示"
                End If
            End If

        End If
        Unload Me
    End If
End Sub

Private Sub Checks_Click(index As Integer)
'选框
    If Checks(index).Value = 1 Then
        Checks(index).Caption = "是"
        If index = 0 Then btnBrowse.Visible = True: txtDataFolder.Visible = True
    Else
        Checks(index).Caption = "否"
        If index = 0 Then btnBrowse.Visible = False: txtDataFolder.Visible = False
    End If
End Sub

Private Sub Form_Activate()
    Debug.Print YuzuCustomDataFolder
    If YuzuCustomDataFolder = YuzuInstallFolder & "\user" Then
        YuzuCustomDataFolder = "False"
        WriteIni "Yuzu", "CustomDataFolder", YuzuCustomDataFolder, YuzuInstallFolder & "\YuzuConfig.ini"
    End If

    '加载设置和界面

    If YuzuCustomDataFolder = "False" Then
        Checks(0).Value = 0
        Checks(0).Caption = "否"
        btnBrowse.Visible = False
        txtDataFolder.Visible = False

        frmManage.Hide
        frmYuzuConfig.SetFocus
    Else
        Checks(0).Value = 1
        Checks(0).Caption = "是"
        btnBrowse.Visible = True
        txtDataFolder.Visible = True
        txtDataFolder.Text = YuzuCustomDataFolder
    End If
    If Left(YuzuBranch, 5) = "预先测试版" Then
        Image1.Picture = frmYuzuInstaller.ImageList2.ListImages(1).Picture
    Else
        Image1.Picture = frmYuzuInstaller.ImageList2.ListImages(2).Picture
    End If
    YuzuPreDataFolder = YuzuCustomDataFolder

    Me.Caption = "Yuzu 模拟器相关设置"
    If IsMissing Then
        '没有YuzuConfig.ini
        Labels(0).Caption = "该模拟器不是用本工具安装的，" & vbCrLf & "请先完善它的版本信息。"
        Labels(3).Visible = False
        Checks(0).Visible = False
        txtDataFolder.Visible = False
        btnBrowse.Visible = fase
        btnSave.Top = 2520
        btnCancel.Top = 2520
        Me.Height = 3650
    Else
        Labels(0).Caption = "Yuzu 版本信息设置" & vbCrLf & "如果你手动更新了模拟器，可以在此更改版本信息。"
        btnSave.Top = 4200
        btnCancel.Top = 4200
        Me.Height = 5325
    End If

    ImageCombo1.ComboItems.Clear
    ImageCombo1.ComboItems.Add 1, "EA", "预先测试版", 1
    ImageCombo1.ComboItems.Add 2, "Mainline", "主线版", 2
    ImageCombo1.ComboItems(1).Selected = True
    txtVersion.SetFocus

    cbFirmware.Text = "加载中 ..."

    DoEvents
    '没有config
    WindowList = ""
    Shell YuzuInstallFolder & "\yuzu.exe", vbHide
    Dim tmpYuzuName As String
    Do Until InStr(tmpYuzuName, "yuzu") <> False
        '遍历所有窗口句柄
        Call EnumWindows(AddressOf EnumAllWindows, ByVal 0&)
        tmpYuzuName = Join(Filter(Split(WindowList, vbCrLf), "yuzu"), vbCrLf)
        DoEvents
        Sleep 50
    Loop
    Shell "cmd /c taskkill /f /im yuzu.exe"
    tmpYuzuName = Replace(tmpYuzuName, "yuzu Early Access ", "")
    txtVersion.Text = tmpYuzuName

    Dim FirmwareVersionArr() As String
    FirmwareVersionArr = Split(Replace(Replace(Join(Filter(Split(Replace(Replace(GetDataStr2(CloudflareReverseProxyUrl & "/https://archive.org/download/nintendo-switch-global-firmwares/nintendo-switch-global-firmwares_files.xml"), Chr(34), ""), " ", ""), vbLf), ".zip"), vbCrLf), "<filename=Firmware", ""), ".zipsource=original>", ""), vbCrLf)
    Dim i As Integer
    For i = 0 To (UBound(FirmwareVersionArr) - LBound(FirmwareVersionArr))
        cbFirmware.AddItem FirmwareVersionArr(i)
    Next

    If IsMissing Then
        cbFirmware.Text = "选择固件版本"
    Else
        cbFirmware.Text = YuzuFirmware
    End If

End Sub


Private Sub Form_Initialize()
    InitCommonControls
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If IsMissing Then
        frmMain.Show
    Else
        frmManage.Show
    End If
End Sub

Private Sub ImageCombo1_Click()
    Image1.Picture = frmYuzuInstaller.ImageList2.ListImages(ImageCombo1.SelectedItem.index).Picture
    txtVersion.SetFocus
    txtVersion.Text = "加载中 ..."
    If ImageCombo1.SelectedItem.index = 1 Then
        txtVersion.Text = GetYuzuVersion
    Else
        txtVersion.Text = GetYuzuMLVersion
    End If
End Sub

Private Sub txtVersion_KeyPress(KeyAscii As Integer)
'只能输入数字
    If KeyAscii = 8 Then
        Exit Sub
    Else
        If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
        If Len(txtVersion.Text) >= 4 Then KeyAscii = 0
    End If
End Sub

Private Sub MoveYuzuDataFolder()
    On Error GoTo MoveFailed2
    Dim fso As Object, folder As Object
    '迁移 Yuzu 数据文件夹
    'YuzuPreDataFolder 前数据文件夹
    If YuzuPreDataFolder = YuzuCustomDataFolder Then Exit Sub
    If YuzuPreDataFolder = "False" Or YuzuPreDataFolder = "<请点击“浏览”>" Then YuzuPreDataFolder = YuzuInstallFolder & "\user"
    If YuzuCustomDataFolder = "False" Or YuzuCustomDataFolder = "<请点击“浏览”>" Then YuzuCustomDataFolder = YuzuInstallFolder & "\user"
    If TestEmptyFolder(YuzuCustomDataFolder) = False Then
        MsgBox "新的数据文件夹为:" & YuzuCustomDataFolder & vbCrLf & "这个文件夹非空，迁移失败！" & vbCrLf & "请清空该文件夹之后再试。", vbOKOnly + vbCritical, "错误"
        GoTo MoveFailed
    End If
    If YuzuCustomDataFolder <> YuzuInstallFolder & "\user" Then
        '新文件夹空了，继续迁移
        '移动内容
        Set fso = CreateObject("Scripting.FileSystemObject")    '创建FSO
        Set folder = fso.GetFolder(YuzuPreDataFolder)
        RmDir YuzuCustomDataFolder
        folder.Move YuzuCustomDataFolder
        Set folder = Nothing
        Set fso = Nothing
        '创建符号链接
        Shell "cmd /c mklink /d /j " & Chr(34) & YuzuInstallFolder & "\user" & Chr(34) & " " & Chr(34) & YuzuCustomDataFolder & Chr(34)
    Else
        '迁移回 User 文件夹
        Shell "cmd /c rmdir " & Chr(34) & YuzuInstallFolder & "\user" & Chr(34)    ' 删除旧的符号链接
        '移动内容
        Set fso = CreateObject("Scripting.FileSystemObject")    '创建FSO
        Set folder = fso.GetFolder(YuzuPreDataFolder)
        RmDir YuzuInstallFolder & "\user"
        folder.Move YuzuInstallFolder & "\user"
        Set folder = Nothing
        Set fso = Nothing
    End If
    MsgBox "数据文件夹迁移成功！" & vbCrLf & vbCrLf & "从 " & YuzuPreDataFolder & "，" & vbCrLf & "迁移到了 " & YuzuCustomDataFolder & "。", vbOKOnly + vbInformation, "提示"
    Exit Sub

MoveFailed:
    If YuzuPreDataFolder = YuzuInstallFolder & "\user" Then YuzuPreDataFolder = "False"
    If YuzuCustomDataFolder = YuzuInstallFolder & "\user" Then YuzuCustomDataFolder = "False"
    YuzuCustomDataFolder = YuzuPreDataFolder
    WriteIni "Yuzu", "CustomDataFolder", YuzuCustomDataFolder, YuzuInstallFolder & "\YuzuConfig.ini"
    Exit Sub

MoveFailed2:
    MsgBox "迁移失败，发生了未知错误。" & vbCrLf & "运行时错误 " & CStr(Err.Number) & "：" & Err.Description, vbOKOnly + vbCritical, "错误"
    If YuzuPreDataFolder = YuzuInstallFolder & "\user" Then YuzuPreDataFolder = "False"
    If YuzuCustomDataFolder = YuzuInstallFolder & "\user" Then YuzuCustomDataFolder = "False"
    YuzuCustomDataFolder = YuzuPreDataFolder
    WriteIni "Yuzu", "CustomDataFolder", YuzuCustomDataFolder, YuzuInstallFolder & "\YuzuConfig.ini"
    Exit Sub
End Sub
