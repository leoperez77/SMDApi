'♥ versión: 586, 6-oct.-2017 07:11

Option Strict On

Imports System.Runtime.InteropServices

Namespace APIS
    Module WinAPI
        Public Const MAX_PATH As Integer = 260

        <DllImport("KERNEL32.DLL", EntryPoint:="GetLongPathNameW", SetLastError:=True, _
        CharSet:=CharSet.Unicode, ExactSpelling:=True, _
        CallingConvention:=CallingConvention.StdCall)> _
        Private Function GetLongPathName(ByVal lpszShortPath As String, ByVal lpszLongPath As String, ByVal cchBuffer As Integer) As Integer
            ' Devuelve el nombre largo de un nombre corto
        End Function

        Public Function GetLongFileName(ByVal sFileName As String) As String
            ' Convertir el nombre indicado en nombre largo
            Dim s As String = StrDup(MAX_PATH, Chr(0))
            Dim i As Integer = GetLongPathName(sFileName, s, s.Length)
            If i > MAX_PATH Then
                ' Se requiere m�s espacio
                s = StrDup(i, Chr(0))
                i = GetLongPathName(sFileName, s, s.Length)
            End If
            If i = 0 Then
                Return ""
            Else
                Return s.Substring(0, i)
            End If
        End Function

    End Module
End Namespace