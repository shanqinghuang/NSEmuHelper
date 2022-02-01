Attribute VB_Name = "ModuleImportRegistry"
Public Declare Sub InitCommonControls Lib "comctl32.dll" ()
Public Declare Function RegOpenKey Lib "advapi32.dll" Alias "RegOpenKeyA" (ByVal hKey As Long, _
ByVal lpSubKey As String, phkResult As Long) As Long
Public Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Long) As Long
Public Declare Function RegEnumKeyEx Lib "advapi32.dll" Alias "RegEnumKeyExA" (ByVal hKey As Long, ByVal dwIndex As Long, ByVal lpName As String, lpcbName As Long, ByVal lpReserved As Long, ByVal lpClass As String, lpcbClass As Long, lpftLastWriteTime As FILETIME) As Long

' 注册表关键字根类型...
Public Enum KeyRoot
HKEY_CLASSES_ROOT = &H80000000
HKEY_CURRENT_USER = &H80000001
HKEY_LOCAL_MACHINE = &H80000002
HKEY_USERS = &H80000003
HKEY_PERFORMANCE_DATA = &H80000004
HKEY_CURRENT_CONFIG = &H80000005
HKEY_DYN_DATA = &H80000006
End Enum
Public Type FILETIME ' 8 Bytes
dwLowDateTime As Long
dwHighDateTime As Long
End Type

Public Function CheckFileExists(FilePath As String) As Boolean
'检查文件夹是否存在
    On Error GoTo Err
    If Len(FilePath) < 2 Then CheckFileExists = False: Exit Function
            If Dir$(FilePath, vbAllFileAttrib) <> vbNullString Then CheckFileExists = True
    Exit Function
Err:
    CheckFileExists = False
End Function

Public Function GetIni(strSection As String, strKey As String, INIFileName As String)
With New ClassINI
    .INIFileName = INIFileName
    GetIni = .GetIniKey(strSection, strKey)
End With
End Function

Public Sub WriteIni(strSection As String, strKey As String, strNewValue As String, INIFileName As String)
With New ClassINI
    .INIFileName = INIFileName
    .WriteIniKey strSection, strKey, strNewValue
End With
End Sub

