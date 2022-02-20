Attribute VB_Name = "modEnum"
Option Explicit
Public WindowList As String

' Brigns the specified window to the top
' of the Z-Order.
Public Declare Function BringWindowToTop _
    Lib "user32" ( _
        ByVal hwnd As Long) _
        As Long

' Enumerates all windows active on the
' the system until the last window has
' been reached.
Public Declare Function EnumWindows _
    Lib "user32" ( _
        ByVal lpEnumFunc As Long, _
        ByVal lParam As Long) _
        As Long

' Retrieves the window text (caption)
' from the specified window.
Public Declare Function GetWindowText _
    Lib "user32" _
    Alias "GetWindowTextA" ( _
        ByVal hwnd As Long, _
        ByVal lpString As String, _
        ByVal cch As Long) _
        As Long

' Returns the class name form which the
' the specified window was created from.
Public Declare Function GetClassName _
    Lib "user32" _
    Alias "GetClassNameA" ( _
        ByVal hwnd As Long, _
        ByVal lpClassName As String, _
        ByVal nMaxCount As Long) _
        As Long
        
' Determines if the specified window
' is minimized (iconic)
Public Declare Function IsIconic _
    Lib "user32" ( _
        ByVal hwnd As Long) _
        As Long

' Determines if the specified window
' handle is a valid handle.
Public Declare Function IsWindow _
    Lib "user32" ( _
        ByVal hwnd As Long) _
        As Long

' Determines if a window is visible on
' the system.
Public Declare Function IsWindowVisible _
    Lib "user32" ( _
        ByVal hwnd As Long) _
        As Long

' Posts a specified windows message into
' a window procedures message queue to be
' processed
Public Declare Function PostMessage _
    Lib "user32" _
    Alias "PostMessageA" ( _
        ByVal hwnd As Long, _
        ByVal wMsg As Long, _
        ByVal wParam As Long, _
        ByVal lParam As Long) _
        As Long

' Shows the specified window in a
' modal state specified by 'nCmdShow'
Public Declare Function ShowWindow _
    Lib "user32" ( _
        ByVal hwnd As Long, _
        ByVal nCmdShow As Long) _
        As Long

Public Const SW_NORMAL      As Long = 1             ' Shows the window in its normal state
Public Const SW_MAXIMIZE    As Long = 3             ' Shows the window in its maxmized state
Public Const SW_MINIMIZE    As Long = 6             ' Sets the windows state to minimized

Public Const WM_CLOSE       As Long = &H10          ' [Windows Message] Closes the target window

Public lvwListItem          As ListItem             ' ListView List Item object

Public Function EnumAllWindows(ByVal hwnd As Long, ByVal lParam As Long) As Long
    Dim lngReturn           As Long
    Dim strWindowName       As String * 256
    Dim strWindowClass      As String * 256
    
    lngReturn = GetWindowText(hwnd, strWindowName, 256)
    If lngReturn Then
        lngReturn = GetClassName(hwnd, strWindowClass, 256)
        'hwnd
        If InStr(strWindowName, "Default IME") = False And InStr(strWindowName, "MSCTFIME UI") = False Then WindowList = WindowList & Replace(strWindowName, Chr(0), "") & vbCrLf
        'strWindowClass
    End If
    EnumAllWindows = True
End Function

