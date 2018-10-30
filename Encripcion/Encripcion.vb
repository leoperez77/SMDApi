Imports System.Configuration
Namespace SMDApi.Clases
    Public Class Encripcion
#Region "Variables y Constantes"
        Public Shared Conexion As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString 'Almacena la cadena de conexión hacia SQL
        Public Shared ClaveCnx As String = ConfigurationManager.AppSettings("TK") 'Almacena la clave para el acceso a los métodos del Web Service
        Public Shared ClaveCnx2 As String = ConfigurationManager.AppSettings("TK2") 'Almacena la clave para el acceso a los métodos del Web Service. Esta es The Key 2
        Public Shared CantidadEncDesenc As Integer = ConfigurationManager.AppSettings("Cuantos") 'Cantidad utilizada para la encriptación o dencriptación de los textos
        Public Shared AdivinePues As String = ConfigurationManager.AppSettings("AdivinePues") 'Esta variable se utiliza para encriptar o dencriptar las claves
        Public Shared TimeOut As Integer = ConfigurationManager.AppSettings("TimeOutSql") 'Tiempo de espera del SQL con el web Service
#End Region

#Region "Funciones para encriptar y desencriptar"

        Public Shared Function Encriptar(ByVal Encrip_o_Desencrip As String, ByVal Clave As String) As String
            If Encrip_o_Desencrip = "E" Then
                Return StrEncode(Clave, AdivinePues)
            Else
                Return StrDecode(Clave, AdivinePues)
            End If
        End Function

        ''' <summary>
        ''' Encripta la clave
        ''' </summary>
        ''' <param name="s"></param>
        ''' <param name="key"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Shared Function StrEncode(ByVal s As String, ByVal key As Long) As String
            Dim N As Long, I As Long, SS As String
            Dim k1 As Long, k2 As Long, k3 As Long, k4 As Long, T As Long
            Static saltvalue As String
            saltvalue = "    "

            For I = 1 To 4
                T = 100 * (1 + Asc(Mid(saltvalue, I, 1))) * Rnd() * (Date.Now.TimeOfDay.TotalSeconds + 1)
                Mid(saltvalue, I, 1) = Chr(T Mod 256)
            Next
            s = Mid(saltvalue, 1, 2) & s & Mid(saltvalue, 3, 2)

            N = Len(s)
            SS = Space(N)

            Dim sn(N) As Long

            k1 = 11 + (key Mod 233) : k2 = 7 + (key Mod 239)
            k3 = 5 + (key Mod 241) : k4 = 3 + (key Mod 251)

            For I = 1 To N : sn(I) = Asc(Mid(s, I, 1)) : Next I

            For I = 2 To N : sn(I) = sn(I) Xor sn(I - 1) Xor ((k1 * sn(I - 1)) Mod 256) : Next
            For I = N - 1 To 1 Step -1 : sn(I) = sn(I) Xor sn(I + 1) Xor (k2 * sn(I + 1)) Mod 256 : Next
            For I = 3 To N : sn(I) = sn(I) Xor sn(I - 2) Xor (k3 * sn(I - 1)) Mod 256 : Next
            For I = N - 2 To 1 Step -1 : sn(I) = sn(I) Xor sn(I + 2) Xor (k4 * sn(I + 1)) Mod 256 : Next
            For I = 1 To N : Mid(SS, I, 1) = Chr(sn(I)) : Next I

            StrEncode = SS
            saltvalue = Mid(SS, Len(SS) / 2, 4)

        End Function

        ''' <summary>
        ''' Desencripta la clave
        ''' </summary>
        ''' <param name="s"></param>
        ''' <param name="key"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Shared Function StrDecode(ByVal s As String, ByVal key As Long) As String
            If s = "" Then
                StrDecode = ""
                Exit Function
            End If

            Dim N As Long, I As Long, SS As String
            Dim k1 As Long, k2 As Long, k3 As Long, k4 As Long

            N = Len(s)
            SS = Space(N)

            Dim sn(N) As Long

            k1 = 11 + (key Mod 233) : k2 = 7 + (key Mod 239)
            k3 = 5 + (key Mod 241) : k4 = 3 + (key Mod 251)

            For I = 1 To N : sn(I) = Asc(Mid(s, I, 1)) : Next
            For I = 1 To N - 2 : sn(I) = sn(I) Xor sn(I + 2) Xor (k4 * sn(I + 1)) Mod 256 : Next
            For I = N To 3 Step -1 : sn(I) = sn(I) Xor sn(I - 2) Xor (k3 * sn(I - 1)) Mod 256 : Next
            For I = 1 To N - 1 : sn(I) = sn(I) Xor sn(I + 1) Xor (k2 * sn(I + 1)) Mod 256 : Next
            For I = N To 2 Step -1 : sn(I) = sn(I) Xor sn(I - 1) Xor (k1 * sn(I - 1)) Mod 256 : Next
            For I = 1 To N : Mid(SS, I, 1) = Chr(sn(I)) : Next I

            StrDecode = Mid(SS, 3, Len(SS) - 4)

        End Function

        ''' <summary>
        ''' Encripta o desencripta un texto
        ''' </summary>
        ''' <param name="Hacer"></param>
        ''' <param name="Orig"></param>
        ''' <param name="Cuantos"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function Haga1(ByVal Hacer As Boolean, ByVal Orig As String, Cuantos As Integer) As String
            If Hacer Then
                Dim Nuevo As String = ""
                Dim Nos As String = ""
                If Orig.Length <= Cuantos Then
                    Cuantos = Orig.Length
                End If
                For I As Integer = 1 To Cuantos
                    If Asc(Mid(Orig, I, 1)) > 127 Then
                        Nos &= I.ToString & "."
                        Nuevo &= Mid(Orig, I, 1)
                    Else
                        Nuevo &= Chr(Asc(Mid(Orig, I, 1)) + 78) ' 128)
                    End If
                Next
                Nuevo &= Orig.Substring(Cuantos)
                Return Nos & "|" & Nuevo
            Else
                Dim Nuevo2 As String = ""
                Dim NuevoSistema As Boolean = False
                If Orig.Substring(0, 1) = "~" Then
                    NuevoSistema = True
                    Orig = Orig.Substring(1)
                    If Orig.Length <= Cuantos Then
                        Cuantos = Orig.Length
                    End If
                End If

                Dim KK As Integer = InStr(Orig, "|")

                Dim Nos2() As String = Mid(Orig, 1, KK - 1).Split(".")
                Orig = Mid(Orig, KK + 1)

                If Not NuevoSistema Then
                    Cuantos = Orig.Length
                End If

                For I As Integer = 1 To Cuantos
                    Dim Saltar As Boolean = False
                    For J As Integer = 0 To Nos2.Length - 1
                        If I = Val(Nos2(J)) Then
                            Saltar = True
                            Exit For
                        End If
                    Next
                    If Saltar Then
                        Nuevo2 &= Mid(Orig, I, 1)
                    Else
                        Nuevo2 &= Chr(Asc(Mid(Orig, I, 1)) - 78) ' 128)
                    End If
                Next
                'truco juan diego
                If InStr(Nuevo2, "@@123@@") > 0 Then
                    Nuevo2 = ""
                End If
                Nuevo2 &= Orig.Substring(Cuantos)
                Return Nuevo2
            End If

        End Function

#End Region

    End Class
End Namespace
