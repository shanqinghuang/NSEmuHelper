Attribute VB_Name = "Module"
Public Specs(1 To 4) As String
Public CaptionBase As String
Public Status As Integer
Public UpdateMode As Boolean
Public Function CheckFileExists(FilePath As String) As Boolean
    On Error GoTo ERR
    If Len(FilePath) < 2 Then CheckFileExists = False: Exit Function
            If Dir$(FilePath, vbAllFileAttrib) <> vbNullString Then CheckFileExists = True
    Exit Function
ERR:
    CheckFileExists = False
End Function

Public Function MkDirs(ByVal PathIn As String) _
   As Boolean
   Dim nPos As Long
   MkDirs = True  'assume success
   If Right(PathIn, 1) <> "\" Then PathIn = PathIn + "\"
   nPos = InStr(1, PathIn, "\")

   Do While nPos > 0
       If Dir$(Left$(PathIn, nPos), vbDirectory) = "" Then
           On Error GoTo Failed
               MkDir Left$(PathIn, nPos)
           On Error GoTo 0
       End If
       nPos = InStr(nPos + 1, PathIn, "\")
   Loop

   Exit Function
Failed:
   MkDirs = False
End Function

Public Function GetDataStr(ByVal Url As String) As String
  On Error GoTo ERR:
  Dim XMLHTTP As Object
  Set XMLHTTP = CreateObject("Microsoft.XMLHTTP")
  XMLHTTP.Open "GET", Url, True
  XMLHTTP.send
  While XMLHTTP.ReadyState <> 4
  Sleep 10
    DoEvents
  Wend
    GetDataStr = XMLHTTP.ResponseText
  Set XMLHTTP = Nothing
  Exit Function
ERR:
  GetDataStr = ""
End Function

