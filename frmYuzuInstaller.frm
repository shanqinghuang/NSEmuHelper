VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{48E59290-9880-11CF-9754-00AA00C00908}#1.0#0"; "MSINET.OCX"
Begin VB.Form frmYuzuInstaller 
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "安装 Yuzu"
   ClientHeight    =   5085
   ClientLeft      =   5625
   ClientTop       =   4485
   ClientWidth     =   8760
   BeginProperty Font 
      Name            =   "微软雅黑 Light"
      Size            =   12
      Charset         =   134
      Weight          =   290
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmYuzuInstaller.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5085
   ScaleWidth      =   8760
   Begin VB.ComboBox ComboVersion 
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
      Left            =   4080
      TabIndex        =   20
      Text            =   "Combo1"
      Top             =   2520
      Width           =   1695
   End
   Begin VB.CommandButton btnShortcut 
      Caption         =   "创建桌面快捷方式"
      Height          =   555
      Left            =   240
      TabIndex        =   18
      Top             =   4320
      Width           =   2775
   End
   Begin VB.CommandButton btnDelNo 
      Caption         =   "否"
      Height          =   555
      Left            =   7080
      TabIndex        =   17
      Top             =   4320
      Width           =   1455
   End
   Begin VB.CommandButton btnDelYes 
      Caption         =   "是"
      Height          =   555
      Left            =   5280
      TabIndex        =   16
      Top             =   4320
      Width           =   1455
   End
   Begin InetCtlsObjects.Inet Inet1 
      Left            =   840
      Top             =   4320
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
   End
   Begin NSEmuHelper.ucDownload ucDownload1 
      Height          =   255
      Left            =   0
      TabIndex        =   15
      Top             =   4800
      Width           =   615
      _ExtentX        =   1085
      _ExtentY        =   450
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
      Left            =   3120
      TabIndex        =   12
      Text            =   "Combo1"
      Top             =   3120
      Width           =   4095
   End
   Begin VB.OptionButton opFirmware 
      BackColor       =   &H80000005&
      Caption         =   "在线下载"
      Height          =   375
      Index           =   1
      Left            =   1320
      TabIndex        =   11
      Top             =   3120
      Width           =   1455
   End
   Begin VB.OptionButton opFirmware 
      BackColor       =   &H80000005&
      Caption         =   "本地选择"
      Height          =   375
      Index           =   0
      Left            =   1320
      TabIndex        =   10
      Top             =   2520
      Value           =   -1  'True
      Width           =   1455
   End
   Begin VB.TextBox txtFirmware 
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
      Left            =   3120
      TabIndex        =   9
      Text            =   "<请点击“浏览”，之后在下方选择版本号>"
      Top             =   2520
      Width           =   4095
   End
   Begin VB.TextBox txtKey 
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
      Left            =   1560
      TabIndex        =   8
      Text            =   "<请点击“浏览”>"
      Top             =   2520
      Width           =   5655
   End
   Begin VB.CommandButton btnBrowse 
      Caption         =   "浏览"
      Height          =   375
      Left            =   7560
      TabIndex        =   7
      Top             =   2520
      Width           =   975
   End
   Begin VB.CommandButton btnNextStep 
      Caption         =   "下一步"
      Height          =   555
      Left            =   7080
      TabIndex        =   6
      Top             =   4320
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
      TabIndex        =   5
      Text            =   "加载中 ..."
      Top             =   2520
      Width           =   1695
   End
   Begin MSComctlLib.ImageList ImageList2 
      Left            =   6120
      Top             =   3840
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   256
      ImageHeight     =   256
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   2
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmYuzuInstaller.frx":54AA
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmYuzuInstaller.frx":6FAE
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   7320
      Top             =   1320
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
            Picture         =   "frmYuzuInstaller.frx":B911
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmYuzuInstaller.frx":10DCB
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.ImageCombo ImageCombo1 
      Height          =   435
      Left            =   1560
      TabIndex        =   0
      Top             =   2520
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
   Begin VB.Label lblProgBar 
      BackStyle       =   0  'Transparent
      Height          =   375
      Left            =   120
      TabIndex        =   19
      Top             =   3120
      Width           =   8535
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "indicator2"
      Height          =   495
      Index           =   5
      Left            =   120
      TabIndex        =   14
      Top             =   2520
      Width           =   8415
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "indicator1"
      Height          =   495
      Index           =   4
      Left            =   120
      TabIndex        =   13
      Top             =   2040
      Width           =   8415
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "模拟器版本："
      Height          =   495
      Index           =   3
      Left            =   120
      TabIndex        =   4
      Top             =   2520
      Width           =   2175
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "Steps"
      Height          =   975
      Index           =   2
      Left            =   120
      TabIndex        =   3
      Top             =   1200
      Width           =   6615
   End
   Begin VB.Image Image1 
      Height          =   1215
      Left            =   7320
      Stretch         =   -1  'True
      Top             =   240
      Width           =   1215
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "Steps"
      BeginProperty Font 
         Name            =   "微软雅黑 Light"
         Size            =   15.75
         Charset         =   134
         Weight          =   290
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   1
      Left            =   120
      TabIndex        =   2
      Top             =   600
      Width           =   6975
   End
   Begin VB.Label Labels 
      BackStyle       =   0  'Transparent
      Caption         =   "安装 Yuzu"
      Height          =   495
      Index           =   0
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   3735
   End
End
Attribute VB_Name = "frmYuzuInstaller"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public DownloadCompleted As Boolean, TitlePrefix As String
Attribute DownloadCompleted.VB_VarHelpID = -1
'1：纯净安装
'2：更新模拟器
'3：固件
Public iIsEarlyAccess As Boolean, iVersion As String, iKeyPath As String, iFirmwareOnline As Boolean, iFirmwarePath As String, iFirmwareVersion As String
'1：分支 True EA False Mainline
'2：版本号
Public CurrentStep As Integer, YuzuVersionName As String
Private Sub btnBrowse_Click()
Debug.Print CurrentStep
'浏览
Select Case CurrentStep
    Case 2
        txtKey.Text = ChooseFile("选择密钥文件 (prod.keys)", "NS 密钥文件", "*.keys", frmYuzuInstaller.hWnd)
    Case 3
        If opFirmware(0).Value Then
            txtFirmware.Text = ChooseFile("选择固件包 (zip 压缩文件)", "NS 固件包", "*.zip", frmYuzuInstaller.hWnd)
            If txtFirmware.Text <> "" Then
                Dim TmpName As String
                TmpName = Split(txtFirmware.Text, "\")(UBound(Split(txtFirmware.Text, "\")))
                If InStr(TmpName, "Firmware ") <> 0 Then
                    cbFirmware.Text = Replace(Replace(TmpName, ".zip", ""), "Firmware ", "")
                ElseIf InStr(TmpName, "Firmware_") <> 0 Then
                    cbFirmware.Text = Replace(Replace(TmpName, ".zip", ""), "Firmware_", "")
                ElseIf InStr(TmpName, "registered-") <> 0 Then
                    cbFirmware.Text = Replace(Replace(TmpName, ".zip", ""), "registered-", "")
                End If
            End If
        End If
    Case Else
        Exit Sub
End Select
End Sub


Private Sub btnNextStep_Click()
'下一步
If InstallMode = 1 Then
    Select Case CurrentStep
        Case 1
            Step2
        Case 2
            Step3
        Case 3
            Step4
        Case Else
            Exit Sub
    End Select
ElseIf InstallMode = 2 Then
    Step4
ElseIf InstallMode = 3 Then
    Step4
End If
End Sub

Private Sub btnShortcut_Click()
Dim nPath As String, sh, ShortCut
On Error Resume Next
Set sh = CreateObject("wscript.shell") '
nPath = sh.RegRead("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders\Desktop") '获取当前用户的桌面目录
If Right(nPath, 1) <> "" Then nPath = nPath & "\"
ShortF = nPath & "Yuzu.lnk"
Set ShortCut = sh.CreateShortcut(ShortF) '开始创建快捷方式对象
ShortCut.TargetPath = YuzuInstallFolder & "\yuzu.exe" '快捷方式指向的目标文件，写完整路径
ShortCut.Save
MsgBox "快捷方式创建成功！", vbOKOnly, "提示"
End Sub

Private Sub Form_Activate()
'加载
If InstallMode = 1 Then
    If YuzuInstallFolder = "D:\Yuzu" Then
        If MsgBox("当前模拟器安装目录为默认的 D:\Yuzu，请确认是否安装到此文件夹？" & vbCrLf & "点“否”以回到主界面，点击左下角的设置更改模拟器文件夹。" & vbCrLf & "你也可以把模拟器文件夹设为你已经装好的模拟器位置，程序会自动识别。", vbQuestion + vbYesNo, "确认吗？") = 7 Then
            frmMain.Show
            Unload Me
            Exit Sub
        End If
    End If
    TitlePrefix = "安装 Yuzu"
    Labels(0).Caption = TitlePrefix
    DoEvents
    CurrentStep = 1
    Step1
ElseIf InstallMode = 2 Then
    TitlePrefix = "更新 Yuzu"
    Labels(0).Caption = TitlePrefix
    DoEvents
    CurrentStep = 1
    Step1
ElseIf InstallMode = 3 Then
    TitlePrefix = "更新固件"
    Labels(0).Caption = TitlePrefix
    DoEvents
    CurrentStep = 3
    Step3
End If
If InstallMode <> 1 Then RemoveTemps

End Sub

Private Sub Step1()
'第一步
'界面
btnShortcut.Visible = False
btnDelYes.Visible = False
btnDelNo.Visible = False
Labels(4).Visible = False
Labels(5).Visible = False
cbFirmware.Visible = False
opFirmware(0).Visible = False
opFirmware(1).Visible = False
btnBrowse.Visible = False
txtFirmware.Visible = False
txtKey.Visible = False
txtVersion.Visible = True
ComboVersion.Visible = True
Image1.Picture = ImageList2.ListImages(1).Picture
If InstallMode = 1 Then
Me.Caption = TitlePrefix & " - Step 1"
    Labels(1).Caption = "Step 1 - 选择模拟器版本"
    Labels(2).Caption = "在安装模拟器之前，你需要先进行几步选择。" & vbCrLf & "如果追求最新功能，就使用预先测试版，如果追求稳定，就使用主线版。"
Else
    Me.Caption = TitlePrefix
    Labels(1).Caption = "选择模拟器版本"
    Labels(2).Caption = "请选择要更换到的模拟器版本。" & vbCrLf & "如果追求最新功能，就使用预先测试版，如果追求稳定，就使用主线版。"
End If
Labels(3).Caption = "模拟器版本："
ImageCombo1.ComboItems.Clear
ImageCombo1.ComboItems.Add 1, "EA", "预先测试版", 1
ImageCombo1.ComboItems.Add 2, "Mainline", "主线版", 2
ImageCombo1.ComboItems(1).Selected = True
If DownloadSource = "Github" Then
    txtVersion.Visible = True
    ComboVersion.Visible = False
    txtVersion.Text = GetYuzuVersion
    txtVersion.SetFocus
Else
    txtVersion.Visible = False
    ComboVersion.Visible = True
    Dim YuzuVersion() As String
    ComboVersion.Clear
    ComboVersion.Text = "加载中 ..."
    YuzuVersion = Split(GetYuzuVersionAli, vbCrLf)
    Dim I As Integer
    For I = 0 To (UBound(YuzuVersion) - LBound(YuzuVersion))
    ComboVersion.AddItem YuzuVersion(I)
    ComboVersion.Text = YuzuVersion(I)
    ComboVersion.SetFocus
    Next
End If
'确保文件夹存在
MkDirs YuzuInstallFolder
End Sub

Private Sub Step2()
On Error GoTo Step2Error
If DownloadSource = "Github" Then
    If txtVersion.Text = "加载中 ..." Then Exit Sub
    iVersion = txtVersion.Text
Else
    If ComboVersion.Text = "加载中 ..." Then Exit Sub
    iVersion = ComboVersion.Text
End If
CurrentStep = 2
'第二步
'设置第一步结果
If ImageCombo1.SelectedItem.Index = 1 Then
    iIsEarlyAccess = True
    YuzuVersionName = "yuzu-windows-msvc-early-access"
ElseIf ImageCombo1.SelectedItem.Index = 2 Then
    iIsEarlyAccess = False
    YuzuVersionName = "yuzu-windows-msvc"
Else
    Exit Sub
End If
'界面
ImageCombo1.Visible = False
txtVersion.Visible = False
ComboVersion.Visible = False
btnBrowse.Visible = True
txtKey.Visible = True
Me.Caption = TitlePrefix & " - Step 2"
Labels(1).Caption = "Step 2 - 选择密钥文件"
Labels(2).Caption = "NS 模拟器需要密钥 (Keys) 文件才能玩游戏。" & vbCrLf & "你可以在相关的群中找到它 (prod.keys)，并在这里打开。"
Labels(3).Caption = "密钥文件："

Exit Sub
Step2Error:
ImageCombo1.ComboItems(1).Selected = True
Exit Sub
End Sub

Private Sub Step3()
If InstallMode = 1 Then
If txtKey.Text = "<请点击“浏览”>" Or txtKey.Text = "" Then Exit Sub
CurrentStep = 3
'第三步
'设置第二步结果
iKeyPath = txtKey.Text
'界面
End If
ComboVersion.Visible = False
ImageCombo1.Visible = False
btnShortcut.Visible = False
btnDelYes.Visible = False
btnDelNo.Visible = False
Labels(4).Visible = False
Labels(5).Visible = False
cbFirmware.Visible = True
btnBrowse.Visible = True
cbFirmware.Visible = True
txtKey.Visible = False
txtFirmware.Visible = True
opFirmware(0).Visible = True
opFirmware(1).Visible = True
If InstallMode = 1 Then
    Me.Caption = TitlePrefix & " - Step 3"
    Labels(1).Caption = "Step 3 - 选择固件"
    Labels(2).Caption = "Yuzu 需要固件才能使大部分游戏正常运行。" & vbCrLf & "你可以在相关的群中找到固件包，或使用“在线下载”。" & vbCrLf & "固件版本需要小于等于密钥版本。"
ElseIf InstallMode = 3 Then
    If Left(YuzuBranch, 5) = "预先测试版" Then
        Image1.Picture = ImageList2.ListImages(1).Picture
    Else
        Image1.Picture = ImageList2.ListImages(2).Picture
    End If
    Me.Caption = TitlePrefix & " - 选择固件"
    Labels(1).Caption = "更新固件版本"
    Labels(2).Caption = "你可以在此更新或更换固件的版本。" & vbCrLf & "你可以在相关的群中找到固件包，或使用“在线下载”。" & vbCrLf & "固件版本需要小于等于密钥版本。"
End If
Labels(3).Caption = "固件包："
'----
cbFirmware.Clear
cbFirmware.Text = "加载中 ..."
Dim FirmwareVersionArr() As String
FirmwareVersionArr = Split(Replace(Replace(Join(Filter(Split(Replace(Replace(GetDataStr2(CloudFlareReverseProxyUrl & "/https://archive.org/download/nintendo-switch-global-firmwares/nintendo-switch-global-firmwares_files.xml"), Chr(34), ""), " ", ""), vbLf), ".zip"), vbCrLf), "<filename=Firmware", ""), ".zipsource=original>", ""), vbCrLf)
Dim I As Integer
For I = 0 To (UBound(FirmwareVersionArr) - LBound(FirmwareVersionArr))
cbFirmware.AddItem FirmwareVersionArr(I)
Next
cbFirmware.Text = "选择固件版本"
End Sub

Private Sub Step4()
Dim fso As Object, folder As Object
Set fso = CreateObject("scripting.filesystemobject") '创建FSO对象
'dependencies
    
On Error Resume Next
'第四步（开始安装）
If InstallMode = 1 Or InstallMode = 3 Then
    '上一步结果
    If cbFirmware.Text = "选择固件版本" Then Exit Sub
    If opFirmware(0).Value Then
        If txtFirmware.Text = "<请点击“浏览”，之后在下方选择版本号>" Or txtFirmware.Text = "" Then Exit Sub
        iFirmwareOnline = False
        iFirmwareVersion = cbFirmware.Text
        iFirmwarePath = txtFirmware.Text
    Else
        iFirmwareOnline = True
        iFirmwareVersion = cbFirmware.Text
        If DownloadSource = "Github" Then
            iFirmwarePath = CloudFlareReverseProxyUrl & "/https://archive.org/download/nintendo-switch-global-firmwares/Firmware " & cbFirmware.Text & ".zip"
        Else
            iFirmwarePath = "https://" & AliyundriveDomain & "/ns_emu_helper/NSFirmwareMirror/Firmware_" & cbFirmware.Text & ".zip"
        End If
        'Legacy reverse proxy for testing purpose, uncomment it when new reverse proxy is not work
        'iFirmwarePath = "https://download.sydzy.workers.dev/api/download?url=https://archive.org/download/nintendo-switch-global-firmwares/Firmware " & cbFirmware.Text & ".zip"
    End If
ElseIf InstallMode = 2 Then
    If DownloadSource = "Github" Then
        If txtVersion.Text = "加载中 ..." Then Exit Sub
        iVersion = txtVersion.Text
    Else
        If ComboVersion.Text = "加载中 ..." Then Exit Sub
        iVersion = ComboVersion.Text
    End If
    '设置第一步结果
    If ImageCombo1.SelectedItem.Index = 1 Then
        iIsEarlyAccess = True
        YuzuVersionName = "yuzu-windows-msvc-early-access"
    ElseIf ImageCombo1.SelectedItem.Index = 2 Then
        iIsEarlyAccess = False
        YuzuVersionName = "yuzu-windows-msvc"
    Else
        Exit Sub
    End If
End If

CurrentStep = 4
'界面
ImageCombo1.Visible = False
txtVersion.Visible = False
ComboVersion.Visible = False
cbFirmware.Visible = False
txtFirmware.Visible = False
opFirmware(0).Visible = False
opFirmware(1).Visible = False
Labels(3).Visible = False
btnNextStep.Visible = False
btnBrowse.Visible = False
Labels(4).Visible = True
Labels(5).Visible = True

Labels(2).Caption = "这可能需要十几分钟，你可以坐下来喝杯茶。" & vbCrLf & "根据网络状况和电脑性能，安装速度会有所不同。"
If InstallMode = 1 Then
    Me.Caption = "安装 Yuzu - 正在安装"
    If iIsEarlyAccess Then
        Labels(1).Caption = "正在安装 Yuzu 预先测试版 " & iVersion & " ..."
    Else
        Labels(1).Caption = "正在安装 Yuzu 主线版 " & iVersion & " ..."
    End If
ElseIf InstallMode = 2 Then
    Me.Caption = "更新 Yuzu - 正在安装"
    If iIsEarlyAccess Then
        Labels(1).Caption = "正在更新 Yuzu 到预先测试版 " & iVersion & " ..."
    Else
        Labels(1).Caption = "正在更新 Yuzu 到主线版 " & iVersion & " ..."
    End If
ElseIf InstallMode = 3 Then
    Me.Caption = "更新固件 - 正在安装"
    Labels(1).Caption = "正在安装固件 ..."
    GoTo FirmwareInstallation
End If

'生成模拟器下载链接
DoEvents
Labels(4).Caption = "准备安装 ..."
Labels(5).Caption = ""
iVersion = CStr(CInt(iVersion))
Dim YuzuUrl As String
If DownloadSource = "Github" Then
    If iIsEarlyAccess Then
        YuzuUrl = "https://github.com/PineappleEA/pineapple-src/releases/download/EA-" & iVersion & "/Windows-Yuzu-EA-" & iVersion & ".7z"
    Else
        '主线
        Dim TmpArr() As String
        TmpArr = Split(Replace(GetDataStr2(CloudFlareReverseProxyUrl & "/https://api.github.com/repos/yuzu-emu/yuzu-mainline/releases"), Chr(34), ""), ",")
        If Err.Number = 9 Then
            MsgBox "运行时错误 (9): 下标越界，可能是你的网络对 CloudFlare 的通信有问题。"
            End
        End If
        Dim I As Integer, j As Integer
        For I = LBound(TmpArr) To UBound(TmpArr)
            If TmpArr(I) = "tag_name:mainline-0-" & iVersion Then Exit For
        Next
        j = I
        For I = j To UBound(TmpArr)
            If InStr(TmpArr(I), ".7z") <> 0 Then
                Exit For
            End If
        Next
        YuzuUrl = "https://github.com/yuzu-emu/yuzu-mainline/releases/download/mainline-0-" & iVersion & "/" & Replace(TmpArr(I), "name:", "")
    End If
Else
    '阿里
    If iIsEarlyAccess Then
        YuzuUrl = "https://" & AliyundriveDomain & "/ns_emu_helper/YuzuEAMirror/Windows-Yuzu-EA-" & iVersion & ".7z"
    Else
        YuzuUrl = "https://" & AliyundriveDomain & "/ns_emu_helper/YuzuMainlineMirror/yuzu-windows-msvc-" & iVersion & ".7z"
    End If
End If

If CheckFileExists(YuzuInstallFolder & "\Yuzu.7z") = False Then
If DownloadSource = "Github" Then
    If AlwaysUseCloudFlare = False Then
        DoEvents
        'github连通性测试
        Labels(4).Caption = "正在测试 Github 连通性 ..."
        Labels(5).Caption = "如果 Github 不能连通，就使用 CloudFlare Workers。"
        Dim Tmp As String
        Tmp = "timeout"
        Inet1.Cancel
        Inet1.Protocol = icHTTPS
        Inet1.Url = "https://github.com/opensearch.xml"
        Inet1.RequestTimeout = 10
        Tmp = Inet1.OpenURL
        If Err.Number = 35761 Then
            Labels(4).Caption = "正在下载模拟器，使用 CloudFlare Workers ..."
            YuzuUrl = CloudFlareReverseProxyUrl & "\" & YuzuUrl
        Else
            If InStr(Tmp, "OpenSearchDescription") = 2 Then
                Labels(4).Caption = "正在下载模拟器，使用 Github ..."
            Else
                Labels(4).Caption = "正在下载模拟器，使用 CloudFlare Workers ..."
                YuzuUrl = CloudFlareReverseProxyUrl & "\" & YuzuUrl
            End If
        End If
        Labels(5).Caption = "准备下载 ..."
    Else
        YuzuUrl = CloudFlareReverseProxyUrl & "\" & YuzuUrl
    End If
Else
    Labels(4).Caption = "正在下载模拟器 ..."
End If
End If

DoEvents
'下载模拟器
If CheckFileExists(YuzuInstallFolder & "\Yuzu.7z") = False Then
    PBarLoad 1, Me.hWnd, lblProgBar.Left \ Screen.TwipsPerPixelX, lblProgBar.Top \ Screen.TwipsPerPixelY, lblProgBar.Width \ Screen.TwipsPerPixelX, lblProgBar.Height \ Screen.TwipsPerPixelY
    PBarSetRange 1, 0, 100
    PBarSetPos 1, 0
    AsyncReads(0) = YuzuUrl
    AsyncReads(1) = YuzuInstallFolder & "\Yuzu.7z"
    ucDownload1.DownloadFile AsyncReads(0), AsyncReads(1)
    DoEvents
    DownloadCompleted = False
    Do Until DownloadCompleted
        Sleep 100
        DoEvents
    Loop
    Sleep 2000
    DoEvents
    PBarUnload 1
End If

FirmwareInstallation:
If InstallMode = 1 Or InstallMode = 3 Then
    '下载固件
    DoEvents
    If CheckFileExists(YuzuInstallFolder & "\Firmware.zip") = False Then
        If iFirmwareOnline Then
            Labels(4).Caption = "正在下载固件，请耐心等待 ..."
            Labels(5).Caption = "准备下载 ..."
            PBarLoad 1, Me.hWnd, lblProgBar.Left \ Screen.TwipsPerPixelX, lblProgBar.Top \ Screen.TwipsPerPixelY, lblProgBar.Width \ Screen.TwipsPerPixelX, lblProgBar.Height \ Screen.TwipsPerPixelY
            PBarSetRange 1, 0, 100
            PBarSetPos 1, 0
            DoEvents
            AsyncReads(0) = iFirmwarePath
            AsyncReads(1) = YuzuInstallFolder & "\Firmware.zip"
            ucDownload1.DownloadFile AsyncReads(0), AsyncReads(1)
            DoEvents
            DownloadCompleted = False
            Do Until DownloadCompleted
                Sleep 100
                DoEvents
            Loop
            Sleep 2000
            DoEvents
            PBarUnload 1
            DoEvents
        Else
            Labels(4).Caption = "正在加载 ..."
            Labels(5).Caption = ""
            PBarUnload 1
            DoEvents
        End If
    End If
End If

If InstallMode = 1 Then
    DoEvents
    '下载 Sysdata (shared fonts)
    If CheckFileExists(YuzuInstallFolder & "\Sysdata.zip") = False Then
        Labels(4).Caption = "正在下载 Shared fonts ..."
        PBarLoad 1, Me.hWnd, lblProgBar.Left \ Screen.TwipsPerPixelX, lblProgBar.Top \ Screen.TwipsPerPixelY, lblProgBar.Width \ Screen.TwipsPerPixelX, lblProgBar.Height \ Screen.TwipsPerPixelY
        PBarSetRange 1, 0, 100
        PBarSetPos 1, 0
        AsyncReads(0) = "https://" & AliyundriveDomain & "/ali/%E6%9D%82%E4%B8%83%E6%9D%82%E5%85%AB/sysdata.zip"
        AsyncReads(1) = YuzuInstallFolder & "\Sysdata.zip"
        ucDownload1.DownloadFile AsyncReads(0), AsyncReads(1)
        DoEvents
        DownloadCompleted = False
        Do Until DownloadCompleted
            Sleep 100
            DoEvents
        Loop
        Sleep 2000
        PBarUnload 1
        DoEvents
    End If
End If

ReInstall:
If InstallMode = 1 Or InstallMode = 2 Then

    '删除旧版本
    If InstallMode = 2 Then
        Labels(4).Caption = "正在删除之前的模拟器 ..."
        Labels(5).Caption = ""
        DoEvents
        Shell "cmd /c rd /s /q " & Chr(34) & YuzuInstallFolder & "\plugins" & Chr(34), vbMinimizedNoFocus
        Shell "cmd /c cd " & Chr(34) & YuzuInstallFolder & Chr(34) & " && del /s /q *.tar.xz", vbMinimizedNoFocus
        DoEvents
        Shell "cmd /c del /s /q " & Chr(34) & YuzuInstallFolder & "\*.dll" & Chr(34)
        Shell "cmd /c del /s /q " & Chr(34) & YuzuInstallFolder & "\*.conf" & Chr(34)
        Shell "cmd /c del /s /q " & Chr(34) & YuzuInstallFolder & "\*.exe" & Chr(34)
        DoEvents
    End If
    '安装模拟器 解压
    Labels(4).Caption = "正在解压缩并安装模拟器 ..."
    Labels(5).Caption = ""
    PBarLoad 1, Me.hWnd, lblProgBar.Left \ Screen.TwipsPerPixelX, lblProgBar.Top \ Screen.TwipsPerPixelY, lblProgBar.Width \ Screen.TwipsPerPixelX, lblProgBar.Height \ Screen.TwipsPerPixelY
    PBarSetRange 1, 0, 100
    PBarSetPos 1, 100
    DoEvents
    Unzip YuzuInstallFolder & "\Yuzu.7z", YuzuInstallFolder
    PBarUnload 1
    DoEvents
    '复制文件
    Set folder = fso.GetFolder(YuzuInstallFolder & "\" & YuzuVersionName & "\plugins")
    folder.Move YuzuInstallFolder & "\plugins"
    'XCopy YuzuInstallFolder & "\" & YuzuVersionName & "\plugins", YuzuInstallFolder & "\plugins"
    fso.CopyFile YuzuInstallFolder & "\" & YuzuVersionName & "\*.*", YuzuInstallFolder & "\", True
    DoEvents
    Shell "cmd /c rd /s /q " & Chr(34) & YuzuInstallFolder & "\" & YuzuVersionName & "" & Chr(34), vbHide
    DoEvents
    Shell "cmd /c cd " & Chr(34) & YuzuInstallFolder & Chr(34) & " && del /s /q *.tar.xz", vbHide
    DoEvents
End If
    
If CheckFileExists(YuzuInstallFolder & "\yuzu.exe") Then
    GoTo ReInstall
    Labels(5).Caption = "解压失败，正在重新解压 ..."
End If
If InstallMode = 1 Then
    '安装密钥
    Labels(4).Caption = "正在安装密钥 ..."
    DoEvents
    MkDirs YuzuInstallFolder & "\user\keys"
    FileCopy iKeyPath, YuzuInstallFolder & "\user\keys\prod.keys"
End If

If InstallMode = 1 Or InstallMode = 3 Then
    If InstallMode = 3 Then
        Labels(4).Caption = "正在删除旧固件 ..."
        DoEvents
        Shell "cmd /c rd /s /q " & Chr(34) & YuzuInstallFolder & "\user\nand\system\Contents" & Chr(34), vbMinimizedNoFocus
        Sleep 10000
    End If
    '安装固件
        '文件夹
    Labels(4).Caption = "正在解压缩并安装固件包 ..."
    DoEvents
    MkDirs YuzuInstallFolder & "\user\nand\system\Contents\registered"
    DoEvents
        '解压
    PBarLoad 1, Me.hWnd, lblProgBar.Left \ Screen.TwipsPerPixelX, lblProgBar.Top \ Screen.TwipsPerPixelY, lblProgBar.Width \ Screen.TwipsPerPixelX, lblProgBar.Height \ Screen.TwipsPerPixelY
    PBarSetRange 1, 0, 100
    PBarSetPos 1, 0
    DoEvents
    If iFirmwareOnline Then
        Unzip YuzuInstallFolder & "\Firmware.zip", YuzuInstallFolder & "\user\nand\system\Contents\registered"
    Else
        Unzip iFirmwarePath, YuzuInstallFolder & "\user\nand\system\Contents\registered"
    End If
    PBarUnload 1
    DoEvents
End If

If InstallMode = 1 Then
    'sysdata
    Labels(4).Caption = "正在解压缩并安装 Shared fonts ..."
    MkDirs YuzuInstallFolder & "\user\sysdata"
    PBarLoad 1, Me.hWnd, lblProgBar.Left \ Screen.TwipsPerPixelX, lblProgBar.Top \ Screen.TwipsPerPixelY, lblProgBar.Width \ Screen.TwipsPerPixelX, lblProgBar.Height \ Screen.TwipsPerPixelY
    PBarSetRange 1, 0, 100
    PBarSetPos 1, 0
    DoEvents
    Unzip YuzuInstallFolder & "\Sysdata.zip", YuzuInstallFolder & "\user\sysdata"
    PBarUnload 1
    DoEvents
    DoEvents
    
    'MSVC
    If CheckFileExists("C:\Windows\System32\MSVCP140_ATOMIC_WAIT.DLL") = False And CheckFileExists("C:\Windows\System32\msvcp140_atomic_wait.dll") = False Then
        Labels(4).Caption = "系统中缺少MSVC2019运行库，正在安装 ..."
        If CheckFileExists(YuzuInstallFolder & "\VC2019.exe") = False Then
            Labels(5).Caption = "正在下载 MSVC 运行库 ..."
            PBarLoad 1, Me.hWnd, lblProgBar.Left \ Screen.TwipsPerPixelX, lblProgBar.Top \ Screen.TwipsPerPixelY, lblProgBar.Width \ Screen.TwipsPerPixelX, lblProgBar.Height \ Screen.TwipsPerPixelY
            PBarSetRange 1, 0, 100
            PBarSetPos 1, 0
            DoEvents
            ucDownload1.DownloadFile "https://aka.ms/vs/17/release/vc_redist.x64.exe", YuzuInstallFolder & "\VC2019.exe"
            DoEvents
            DownloadCompleted = False
            Do Until DownloadCompleted
                Sleep 100
                DoEvents
            Loop
            Sleep 1000
            PBarUnload 1
            DoEvents
        End If
        Labels(5).Caption = "正在安装 MSVC 运行库 ..."
        Shell YuzuInstallFolder & "\VC2019.exe /quiet"
        Labels(5).Caption = ""
    DoEvents
    End If
End If
'生成 ini 和配置
If InstallMode = 1 Then
    YuzuVersion = iVersion
    If iIsEarlyAccess Then
        YuzuBranch = "预先测试版"
    Else
        YuzuBranch = "主线版"
    End If
    YuzuFirmware = iFirmwareVersion
    WriteIni "Yuzu", "Version", YuzuVersion, YuzuInstallFolder & "\YuzuConfig.ini"
    WriteIni "Yuzu", "Branch", YuzuBranch, YuzuInstallFolder & "\YuzuConfig.ini"
    WriteIni "Yuzu", "Firmware", YuzuFirmware, YuzuInstallFolder & "\YuzuConfig.ini"
    MkDirs YuzuInstallFolder & "\user\nand\user\save\0000000000000000"
    YuzuCustomDataFolder = "False"
    WriteIni "Yuzu", "CustomDataFolder", "False", YuzuInstallFolder & "\YuzuConfig.ini"
ElseIf InstallMode = 2 Then
    YuzuVersion = iVersion
    If iIsEarlyAccess Then
        YuzuBranch = "预先测试版"
    Else
        YuzuBranch = "主线版"
    End If
    WriteIni "Yuzu", "Version", YuzuVersion, YuzuInstallFolder & "\YuzuConfig.ini"
    WriteIni "Yuzu", "Branch", YuzuBranch, YuzuInstallFolder & "\YuzuConfig.ini"
ElseIf InstallMode = 3 Then
    YuzuFirmware = iFirmwareVersion
    WriteIni "Yuzu", "Firmware", YuzuFirmware, YuzuInstallFolder & "\YuzuConfig.ini"
End If

'完成
If InstallMode = 1 Or InstallMode = 2 Then
    If iIsEarlyAccess Then
        Labels(1).Caption = "Yuzu 预先测试版 " & iVersion & " 安装完成！"
    Else
        Labels(1).Caption = "Yuzu 主线版 " & iVersion & " 安装完成！"
    End If
ElseIf InstallMode = 3 Then
    Labels(1).Caption = "Yuzu 固件 " & iFirmwareVersion & " 安装完成！"
End If
Labels(2).Caption = "是否要删除安装过程中产生的临时文件？"
Labels(4).Visible = False
Labels(5).Visible = False
btnDelYes.Visible = True
btnDelNo.Visible = True

        '释放内存
    Set fso = Nothing
    Set folder = Nothing
    Set file = Nothing
    
If InstallMode = 1 Then
    btnShortcut.Visible = True
End If

End Sub

Private Sub btnDelNo_Click()
Unload Me
End Sub

Private Sub btnDelYes_Click()
RemoveTemps
Unload Me
End Sub

Private Sub RemoveTemps()
'删除几个压缩包
On Error Resume Next
Kill YuzuInstallFolder & "\Yuzu.7z"
Kill YuzuInstallFolder & "\Firmware.zip"
Kill YuzuInstallFolder & "\Sysdata.zip"
Kill YuzuInstallFolder & "\VC2019.exe"
End Sub

Private Sub Form_Unload(Cancel As Integer)
If InstallMode = 1 Then
    frmMain.Show
Else
    frmManage.Show
End If
End Sub

Private Sub opFirmware_Click(Index As Integer)
'切换固件下载方式
Dim FirmwareVersionArr() As String
Dim I As Integer
If Index = 1 Then
    '在线
    txtFirmware.Visible = False
    btnBrowse.Visible = False
    cbFirmware.Top = 2520
    cbFirmware.Clear
    cbFirmware.Text = "加载中 ..."
    FirmwareVersionArr = Filter(Split(GetDataStr2("https://" & AliyundriveDomain & "/ns_emu_helper/NSFirmwareMirror/?json"), Chr(34)), "firmware_")
    For I = 0 To (UBound(FirmwareVersionArr) - LBound(FirmwareVersionArr))
        cbFirmware.AddItem Replace(Replace(FirmwareVersionArr(I), "firmware_", ""), ".zip", "")
    Next
    cbFirmware.Text = "选择固件版本"
Else
    '本地
    txtFirmware.Visible = True
    btnBrowse.Visible = True
    cbFirmware.Top = 3120
    cbFirmware.Clear
    cbFirmware.Text = "加载中 ..."
    FirmwareVersionArr = Split(Replace(Replace(Join(Filter(Split(Replace(Replace(GetDataStr2(CloudFlareReverseProxyUrl & "/https://archive.org/download/nintendo-switch-global-firmwares/nintendo-switch-global-firmwares_files.xml"), Chr(34), ""), " ", ""), vbLf), ".zip"), vbCrLf), "<filename=Firmware", ""), ".zipsource=original>", ""), vbCrLf)
    For I = 0 To (UBound(FirmwareVersionArr) - LBound(FirmwareVersionArr))
        cbFirmware.AddItem FirmwareVersionArr(I)
    Next
    cbFirmware.Text = "选择固件版本"
End If

End Sub


Private Sub ucDownload1_DownloadProgress(ByVal BytesRead As Long, ByVal BytesTotal As Long)
'刷新进度条
  Labels(5).Caption = Format(BytesRead / BytesTotal, "Percent") & " " & CStr(FormatNumber(BytesRead / 1048576, 2, vbTrue)) & "MB / " & CStr(FormatNumber(BytesTotal / 1048576, 2, vbTrue)) & "MB"
  PBarSetPos 1, CInt(BytesRead / BytesTotal * 100)
End Sub

Private Sub ucDownload1_DownloadFailed(ByVal Status As String, ByVal StatusCode As AsyncStatusCodeConstants)
' Visual Basic, F**K YOU!!!
' 干饭王, F**K YOU!!!
Labels(5).Caption = "下载失败，正在尝试使用备用下载 ..."
DoEvents
ShellAndWait Chr(34) & App.Path & "\Dependencies\curl.exe" & Chr(34) & " -fkL " & Chr(34) & AsyncReads(0) & Chr(34) & " -o " & Chr(34) & AsyncReads(1) & Chr(34)
DoEvents
Labels(5).Caption = "备用下载成功！"
DoEvents
DownloadCompleted = True
End Sub
Private Sub ucDownload1_DownloadComplete()
DownloadCompleted = True
End Sub


Private Sub ImageCombo1_Click()
Image1.Picture = ImageList2.ListImages(ImageCombo1.SelectedItem.Index).Picture
Dim YuzuVersion() As String
Dim I As Integer
If ImageCombo1.SelectedItem.Index = 1 Then
    If DownloadSource = "Github" Then
        txtVersion.SetFocus
        txtVersion.Text = "加载中 ..."
        txtVersion.Text = GetYuzuVersion
    Else
        ComboVersion.Clear
        ComboVersion.Text = "加载中 ..."
        YuzuVersion = Split(GetYuzuVersionAli, vbCrLf)
        For I = 0 To (UBound(YuzuVersion) - LBound(YuzuVersion))
        ComboVersion.AddItem YuzuVersion(I)
        ComboVersion.Text = YuzuVersion(I)
        Next
    End If
Else
    If DownloadSource = "Github" Then
        txtVersion.SetFocus
        txtVersion.Text = "加载中 ..."
        txtVersion.Text = GetYuzuMLVersion
    Else
        ComboVersion.Clear
        ComboVersion.Text = "加载中 ..."
        YuzuVersion = Split(GetYuzuMLVersionAli, vbCrLf)
        For I = 0 To (UBound(YuzuVersion) - LBound(YuzuVersion))
        ComboVersion.AddItem YuzuVersion(I)
        ComboVersion.Text = YuzuVersion(I)
        Next
    End If
End If
End Sub

Private Sub Form_Initialize()
InitCommonControls
End Sub

Private Sub txtVersion_KeyPress(KeyAscii As Integer)
'只能输入数字
If KeyAscii = 8 Then Exit Sub
If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
If Len(txtVersion.Text) >= 4 Then KeyAscii = 0
End Sub
