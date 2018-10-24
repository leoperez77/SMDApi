'♥ versión: 586, 6-oct.-2017 07:11
Imports Microsoft.Win32
Imports System.Windows.Forms
Imports System.Web
Imports System
Imports System.Diagnostics
Imports System.IO
Public Class Datos
    Private Shared TomarIp3 As Boolean = False
    Private Shared UsarSegundaIp As Boolean = False
    Private Shared IpServicio As String = ""
    Private Shared PregunteDirectorioXML As Boolean = True
    Private Shared Sub Asignar_WS2(CualNodo As String)
        System.Net.ServicePointManager.CertificatePolicy = New TrustAllCertificatePolicy()

        Dim Prox1 As New Proxy_SMD
        With Prox1
            If .Certific = -1 Then
                .Certific = ValD(GetSett("Conecc", "Certif", 0))
            End If

            If .Certific = 1 Then
                CualNodo = CualNodo.Replace("http://", "https://")
            End If

            Ws2.Url = CualNodo 'Certif & "://190.85.68.202/smsws/smdws.asmx"


            If .Si = -1 Then
                .Si = ValD(GetSett("Conecc", "proxy_si", 0))
                If .Si = 1 Then
                    .DirURL = GetSett("Conecc", "proxy_dir", "")
                    .Puerto = GetSett("Conecc", "proxy_puerto", "")
                End If
            End If

            If .User_Si = -1 Then
                .User_Si = ValD(GetSett("Conecc", "proxy_usuario_si", 0))
                If .User_Si = 1 Then
                    .Usuario = GetSett("Conecc", "proxy_usuario", "")
                    .Clave = GetSett("Conecc", "proxy_clave", "")
                End If
            End If



            'solo para la parte de Proxy setting
            Try
                Dim proxyobj As New System.Net.WebProxy
                If .Si = 1 And .DirURL <> "" Then
                    proxyobj = New System.Net.WebProxy(.DirURL, Convert.ToInt32(.Puerto))
                End If
                If .User_Si = 1 And .Usuario <> "" Then 'viene
                    Dim Cre As New System.Net.NetworkCredential
                    Cre.UserName = .Usuario
                    Cre.Password = .Clave
                    'proxyobj = System.Net.WebProxy.GetDefaultProxy
                    proxyobj.Credentials = Cre
                    Ws2.Proxy = proxyobj
                End If

            Catch ex As Exception
                MsgBox("Error en Proxy de nodo 1: " & ex.Message)
                Exit Sub
            End Try
        End With
    End Sub
    Private Shared Sub Medir_Consumo(ByVal Ds As DataSet)

        Try
            If PreguntarConsumo Then
                PreguntarConsumo = False
                If ValD(GetSett("ctrl", "med", "0")) = 1 Then
                    SiMedirConsumo = True
                Else
                    SiMedirConsumo = False
                End If
            End If

            If Not SiMedirConsumo Then Exit Sub

            Grabar_Consumo(Len(Ds.GetXml()))

        Catch
        End Try

    End Sub
    Private Shared Function traerotrp() As Integer
        'Dim xxx As Integer = 278
        Dim xxx As Integer = 271 '2012-11-20
        Dim recp As Integer = 540

        Return ValD(xxx.ToString & recp.ToString) + 4


    End Function
    Private Shared Sub Cambiar_Nodo()
        If MarcaExterna = "" Or TomarIp3 Then Exit Sub
        If GetSetting("sysw", "sysw", MarcaExterna, "") = "" Then Exit Sub


        UsarSegundaIp = Not UsarSegundaIp
        DebugJD("cambiando a nodo contingencia: " & UsarSegundaIp.ToString)
        EntroWS = False
        DemeNodo()

    End Sub
    Public Shared Function Convierta_IP(MarcaExt As String)
        Select Case LCase(MarcaExt)
            Case "col", "3"
                Return "http://190.85.68.202/smsws/smdws.asmx"
            Case "local"
                Return "http://localhost/smdws/smdws.asmx"
            Case "local2"
                Return "http://190.145.38.246/smdws/smdws.asmx" 'local2 en DMS
            Case "pro"
                Return "http://190.248.68.26:1000/smdws/smdws.asmx" 'Profesional
            Case "zuñ"
                Return "http://186.1.181.246/smdws/smdws.asmx" 'Zuñiga
            Case "bes"
                Return "http://181.48.14.234:3023/Advance/smdws.asmx" 'best en bogota
            Case "eti"
                Return "http://190.145.23.194:9872/smdws/smdws.asmx" 'Eticos
            Case Else
                Return MarcaExt
        End Select

    End Function
    Public Shared Sub DemeNodo()
        If EntroWS Then Exit Sub
        EntroWS = True

        System.Net.ServicePointManager.CertificatePolicy = New TrustAllCertificatePolicy()
        'System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.ServicePointManager

        'saber que Pais soy yo como usuario de ADVANCE
        IdPais = ValD(GetSett("Ayuda", "Pais", "1"))


        With Prox
            If .Certific = -1 Then
                .Certific = ValD(GetSett("Conecc", "Certif", 0))
            End If
            Dim Certif As String
            If .Certific = 1 Then
                Certif = "https" 'requiere certificado seguro
            Else
                Certif = "http"
            End If

            Dim CualIP As String
            'If Strings.Len(MarcaExterna) < 9 Then
            '    CualIP = Convierta_IP(MarcaExterna)
            'Else
            '    CualIP = GetSetting("sysw", "sysw", "ip2", "")
            'End If

            If TomarIp3 Then
                CualIP = GetSetting("sysw", "sysw", "ip4", "")
            Else
                If UsarSegundaIp And MarcaExterna <> "" Then 'para intentar con la ip alternativa, solo si marca externa tiene algo
                    CualIP = GetSetting("sysw", "sysw", MarcaExterna, "")
                    If CualIP = "" Then
                        CualIP = GetSetting("sysw", "sysw", "ip2", "")
                    End If
                Else 'sino coger la que se asigno desde login de advance
                    CualIP = GetSetting("sysw", "sysw", "ip2", "")
                End If

                If CualIP = "local" Or CualIP = "local2" Then
                    CualIP = Datos.Convierta_IP(MarcaExterna)
                Else
                    If GetSetting("sysw", "sysw", "ip4", "") <> "" Then
                        IpServicio = GetSetting("sysw", "sysw", "ip4", "")
                        CualIP = IpServicio
                        SaveSetting("sysw", "sysw", "ip4", "") 'limpiarla para que no quede pegada
                    End If
                End If

                'triquito para cuando viene de servicio, use la misma ip
                If UsarSegundaIp And IpServicio <> "" Then
                    CualIP = IpServicio
                End If
            End If


            CualIP = Replace(CualIP, "http://", Certif & "://")
            If CualIP <> "" Then 'esto es para intergrupo y nodos distintos a col
                Ws.Url = CualIP
            Else 'para dms y el resto
                Ws.Url = Certif & "://190.85.68.202/smsws/smdws.asmx" '
            End If

            'If Not Ws.Url.Contains("190.85.68.202") Then
            '    If My.Computer.Name = "VAIO-DUO-JD" Then
            '        Mensaje("Estoy en: " & Ws.Url.ToString)
            '    End If
            'End If

            If .Si = -1 Then
                .Si = ValD(GetSett("Conecc", "proxy_si", 0))
                If .Si = 1 Then
                    .DirURL = GetSett("Conecc", "proxy_dir", "")
                    .Puerto = GetSett("Conecc", "proxy_puerto", "")
                End If
            End If

            If .User_Si = -1 Then
                .User_Si = ValD(GetSett("Conecc", "proxy_usuario_si", 0))
                If .User_Si = 1 Then
                    .Usuario = GetSett("Conecc", "proxy_usuario", "")
                    .Clave = GetSett("Conecc", "proxy_clave", "")
                End If
            End If

        End With

        DebugJD("ws.url=" & Ws.Url)

        'solo para la parte de Proxy setting
        Try
            With Prox
                Dim proxyobj As New System.Net.WebProxy
                If .Si = 1 And .DirURL <> "" Then
                    proxyobj = New System.Net.WebProxy(.DirURL, Convert.ToInt32(.Puerto))
                End If
                If .User_Si = 1 And .Usuario <> "" Then 'viene
                    Dim Cre As New System.Net.NetworkCredential
                    Cre.UserName = .Usuario
                    Cre.Password = .Clave
                    'proxyobj = System.Net.WebProxy.GetDefaultProxy
                    proxyobj.Credentials = Cre
                    Ws.Proxy = proxyobj
                End If
            End With

        Catch ex As Exception
            MsgBox("Error en Proxy: " & ex.Message)

        End Try

    End Sub
    Public Shared Function NoEntrar() As Boolean
        'If traerotrp() <> renglones And traerotrp() + 157000 <> renglones Then
        If traerotrp() <> renglones And traerotrp() + 164000 <> renglones Then
            Mensaje("Acceso a la DLL no está permitido.")
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function BuscarIpFija() As String
        If NoEntrar() Then
            Return "local"
        End If

        Static IpFija As String = ""
        If IpFija <> "" Then Return IpFija


        IpFija = GetSett("Conecc", "ipfija", "")
        If IpFija <> "" Then 'guardarla para engañar la del instalador
            If Strings.Left(IpFija, 5) <> "local" Then
                IpFija = "ipf" 'IpFija
            End If
        Else
            IpFija = GetSetting("sysw", "sysw", "name", "")
        End If
        Dim Ip2 = IpFija

        'si trae la clave de local

        'EstoyEnMenuPpal = True

        If Not EstoyEnMenuPpal Then
            Dim Cual As String = "0"
            DebugJD("Entró preguntar nodo: Formula: " & (traerotrp() + 157000 = renglones).ToString & ", desdefuente: " & DesdeFuente.ToString & ", soyservicio: " & SoyServicio.ToString)
            If traerotrp() + 157000 = renglones Or DesdeFuente Then
                'el class8 es para darlo a todo mundo cuando lo necesite, el wit5 a nadie, solo JD
                Dim Puede As Boolean = False
                Dim dms As String = "DMS S.A."
                Dim sysc As String = "syscom"

                'esta clave se obtiene en el programa de subir versión, link clave
                If ValD(GetSetting(dms, sysc, "class8", 0)) = _
                    (DateAndTime.Month(Now) + DateAndTime.Year(Now)) * DateAndTime.Day(Now()) + (DateAndTime.Month(Now) * DateAndTime.Year(Now)) Then
                    Puede = True
                Else
                    If ValD(GetSetting(dms, sysc, "wit5", 0)) = 1 Then 'si está marcado como super Juan Diego
                        Puede = True
                    End If
                End If

                Cual = "1"
                If Puede Then 'negada para todos los programadores
                    Cual = "2"
                End If
            ElseIf SoyServicio Then
                Cual = "2"
            End If

            If Cual <> "0" Then
                Pantalla_Splash(True)

                Dim Opc99 As String = GetSett("ppal", "ultcual_serv", "No hay")
                Dim UltCual = GetSett("ppal", "ultcual_real", "2")


                Dim Ult As String = GetSett("ppal", "ultcual", "local")
                If Ult = "" Then Ult = "local"

                If Cual = "1" Or Strings.Left(IpFija, 5) = "local" Then
                    'Cual = InputBoxDMS(My.Application.Info.Title, "Con qué Datos desea Trabajar?", True, UltCual, New Object() {New Object() {"1", "Local", "2", "Pruebas (local2)", "5", "Profesional", "99", "Ultimo: " & Opc99}})
                    'estos nombres ninguno puede tener más de 8 caracteres
                    Cual = InputBoxDMS(My.Application.Info.Title,
                                       "Con qué Datos desea Trabajar?", True, UltCual,
                                       New Object() {New Object() {"local", "PC actual",
                                                                   "local2", "Copia de Col",
                                                                   "pro", "Profesional",
                                                                   "zuñ", "Zúñiga Vives",
                                                                   "bes", "Best bogotá",
                                                                   "eti", "Eticos",
                                                                   "ult", "Ultimo usado=" & Ult
                                                                  }}) ', "99", "Ultimo: " & Opc99}})
                Else
                    Cual = InputBoxDMS(My.Application.Info.Title, "Con qué Datos desea Trabajar?", True, UltCual,
                                       New Object() {New Object() {"local", "Local",
                                                                   "local2", "Pruebas (local2)",
                                                                   "3", "Producción (" & IpFija & ")",
                                                                   "col", "DMS S.A.",
                                                                   "pro", "Profesional",
                                                                   "zuñ", "Zúñiga Vives",
                                                                   "bes", "Best bogotá",
                                                                   "eti", "Eticos",
                                                                   "ult", "Ultimo usado=" & Ult
                                                                  }}) ', "99", "Ultimo: " & Opc99}})
                End If

                SaveSett("ppal", "ultcual_real", Cual)

                If Cual = "ult" Then
                    'recuperar último
                    Cual = Ult
                    SaveSett("ppal", "ultcual_aut", "1") 'activar siguiente pantalla
                Else
                    SaveSett("ppal", "ultcual_aut", "0") 'desactivar siguiente pantalla
                End If
                SaveSett("ppal", "ultcual", Cual)

                IpFija = Cual

                If Cual = "col" Then
                    If DesdeFuente Then
                        Cual = 3
                        IpFija = "3"
                    Else
                        IpFija = "col"
                    End If
                End If

                'pone la ip que va a leer
                Dim TexIP As String = Datos.Convierta_IP(IpFija)
                SaveSetting("sysw", "sysw", "ip4", TexIP)
                TomarIp3 = True

                'Select Case Cual
                '    Case "1"
                '        IpFija = "local"
                '    Case 2
                '        IpFija = "local2"
                '    Case "4"
                '        If DesdeFuente Then
                '            Cual = 3
                '        Else
                '            IpFija = "4"
                '        End If
                '    Case "5"
                '        IpFija = "local3"
                '    Case "6"
                '        IpFija = "local4"
                '    Case "7"
                '        IpFija = "local5"

                '    Case ""
                '        IpFija = ""
                'End Select

                'guardar ultimo

            End If
        End If

        Return IpFija


    End Function


    Public Shared Sub Abrir_Nodo_1(ByRef Dt As DataTable, ByVal Sql As String)
        'If MarcaExterna <> "" Then
        '    Datos.Abrir(Dt, Sql)
        '    Exit Sub
        'End If

        Dim Ds As New DataSet
        Datos.Abrir_Nodo_1(Ds, Sql)
        If Ds.Tables.Count > 0 Then
            Dt = Ds.Tables(0).Copy
        End If

    End Sub
    Public Shared Sub Abrir_Nodo_1(ByRef Ds As DataSet, ByVal Sql As String)
        'abrir el servidor propio de Advance

        System.Net.ServicePointManager.CertificatePolicy = New TrustAllCertificatePolicy()

        Dim Prox1 As New Proxy_SMD
        With Prox1
            If .Certific = -1 Then
                .Certific = ValD(GetSett("Conecc", "Certif", 0))
            End If

            Dim Certif As String = "http"
            If .Certific = 1 Then
                Certif = "https" 'por el momento se deja fijo pues con "s" no está funcionando en todas partes
            End If

            Ws2.Url = Certif & "://190.85.68.202/smsws/smdws.asmx"


            If .Si = -1 Then
                .Si = ValD(GetSett("Conecc", "proxy_si", 0))
                If .Si = 1 Then
                    .DirURL = GetSett("Conecc", "proxy_dir", "")
                    .Puerto = GetSett("Conecc", "proxy_puerto", "")
                End If
            End If

            If .User_Si = -1 Then
                .User_Si = ValD(GetSett("Conecc", "proxy_usuario_si", 0))
                If .User_Si = 1 Then
                    .Usuario = GetSett("Conecc", "proxy_usuario", "")
                    .Clave = GetSett("Conecc", "proxy_clave", "")
                End If
            End If



            'solo para la parte de Proxy setting
            Try
                Dim proxyobj As New System.Net.WebProxy
                If .Si = 1 And .DirURL <> "" Then
                    proxyobj = New System.Net.WebProxy(.DirURL, Convert.ToInt32(.Puerto))
                End If
                If .User_Si = 1 And .Usuario <> "" Then 'viene
                    Dim Cre As New System.Net.NetworkCredential
                    Cre.UserName = .Usuario
                    Cre.Password = .Clave
                    'proxyobj = System.Net.WebProxy.GetDefaultProxy
                    proxyobj.Credentials = Cre
                    Ws2.Proxy = proxyobj
                End If

            Catch ex As Exception
                MsgBox("Error en Proxy de nodo 1: " & ex.Message)
                Exit Sub
            End Try
        End With

        Ds = Ws2.GetDataset(Sql, CodAplica2)

        Medir_Consumo(Ds)

    End Sub
    ''' <summary>
    ''' Abrir un Dt a partir de una instrucción de Sql
    ''' </summary>
    ''' <param name="Dt"></param>
    ''' <param name="Sql"></param>
    ''' <remarks></remarks>
    Public Shared Sub Abrir(ByRef Dt As DataTable, ByVal Sql As String)
        If Datos.NoEntrar() Then Exit Sub

        Datos.DemeNodo()

        Dim Ds As DataSet
        Try
            'Dt = Ws.GetDataset2(Haga1(True, Sql), Haga1(True, CodAplica2)).Tables(0).Copy
            Ds = Ws.GetDataset2(Haga1(True, Sql), Haga1(True, CodAplica2))

        Catch ex As Exception
            DebugJD("1:" & ex.Message)
            Cambiar_Nodo()
            'Dt = Ws.GetDataset2(Haga1(True, Sql), Haga1(True, CodAplica2)).Tables(0).Copy
            Ds = Ws.GetDataset2(Haga1(True, Sql), Haga1(True, CodAplica2))

        End Try

        If Ds.Tables.Count > 0 Then
            Dt = Ds.Tables(0).Copy
        Else
            Dt = Nothing
        End If

        If SiMedirConsumo Then
            'Dim Ds2 As New DataSet
            'Ds2.Tables.Add(Dt)
            Medir_Consumo(Ds)
        End If


    End Sub
    Public Shared Sub Abrir(ByRef Ds As DataSet, ByVal Sql As String)
        If Datos.NoEntrar() Then Exit Sub
        'Debug.Print(Sql & " --> " & Now)

        Datos.DemeNodo()

        Try
            Ds = Ws.GetDataset2(Haga1(True, Sql), Haga1(True, CodAplica2))

        Catch ex As Exception
            DebugJD("2:" & ex.Message)
            Cambiar_Nodo()
            Ds = Ws.GetDataset2(Haga1(True, Sql), Haga1(True, CodAplica2))
        End Try

        Medir_Consumo(Ds)

    End Sub
    Public Shared Sub Abrir(ByRef Dt As DataTable, ByVal NombreSP As String, ByVal p1 As String, Optional ByVal p2 As String = "", Optional ByVal p3 As String = "", Optional ByVal p4 As String = "", Optional ByVal p5 As String = "", Optional ByVal p6 As String = "", Optional ByVal p7 As String = "", Optional ByVal p8 As String = "", Optional ByVal p9 As String = "", Optional ByVal p10 As String = "", Optional ByVal p11 As String = "", Optional ByVal p12 As String = "", Optional ByVal p13 As String = "", Optional ByVal p14 As String = "", Optional ByVal p15 As String = "", Optional ByVal p16 As String = "", Optional ByVal p17 As String = "", Optional ByVal p18 As String = "", Optional ByVal p19 As String = "", Optional ByVal p20 As String = "")
        'Abrir(Dt, ConviertaParametros(NombreSP, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20))


        If Datos.NoEntrar() Then Exit Sub


        'Debug.Print(NombreSP & " --> " & Now)

        Dim Ds As DataSet

        Datos.DemeNodo()


        Try
            Ds = Ws.GetDsFromSp2(Haga1(True, NombreSP), Haga1(True, CodAplica2), New String() {"", p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20})

        Catch ex As Exception
            DebugJD("3:" & ex.Message)
            Cambiar_Nodo()
            Ds = Ws.GetDsFromSp2(Haga1(True, NombreSP), Haga1(True, CodAplica2), New String() {"", p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20})
        End Try

        Medir_Consumo(Ds)

        If Ds.Tables.Count = 0 Then
            Dt = Nothing
            Exit Sub
        End If

        Dt = Ds.Tables(0)

    End Sub

    Public Shared Sub Ejecutar(ByVal TextoEjecutar As String)
        If NoEntrar() Then Exit Sub

        'Debug.Print(TextoEjecutar & " --> " & Now)
        If TextoEjecutar = "" Then Exit Sub

        DemeNodo()

        Try
            Ws.Exec2(Haga1(True, TextoEjecutar), Haga1(True, CodAplica2))

        Catch ex As Exception
            DebugJD("4:" & ex.Message)
            Cambiar_Nodo()
            Ws.Exec2(Haga1(True, TextoEjecutar), Haga1(True, CodAplica2))

        End Try

        If SiMedirConsumo Then Grabar_Consumo(Len(TextoEjecutar))


    End Sub
    Public Shared Sub Ejecutar(ByVal NombreStoredProc As String, ByVal p1 As String, Optional ByVal p2 As String = "°", Optional ByVal p3 As String = "°", Optional ByVal p4 As String = "°", Optional ByVal p5 As String = "°", Optional ByVal p6 As String = "°", Optional ByVal p7 As String = "°", Optional ByVal p8 As String = "°", Optional ByVal p9 As String = "°", Optional ByVal p10 As String = "°", Optional ByVal p11 As String = "°", Optional ByVal p12 As String = "°", Optional ByVal p13 As String = "°", Optional ByVal p14 As String = "°", Optional ByVal p15 As String = "°", Optional ByVal p16 As String = "°", Optional ByVal p17 As String = "°", Optional ByVal p18 As String = "°", Optional ByVal p19 As String = "°", Optional ByVal p20 As String = "°")
        If NoEntrar() Then Exit Sub
        Debug.Print(NombreStoredProc & " --> " & Now)

        p1 = ConviertaWS(p1)
        p2 = ConviertaWS(p2)
        p3 = ConviertaWS(p3)
        p4 = ConviertaWS(p4)
        p5 = ConviertaWS(p5)
        p6 = ConviertaWS(p6)
        p7 = ConviertaWS(p7)
        p8 = ConviertaWS(p8)
        p9 = ConviertaWS(p9)
        p10 = ConviertaWS(p10)
        p11 = ConviertaWS(p11)
        p12 = ConviertaWS(p12)
        p13 = ConviertaWS(p13)
        p14 = ConviertaWS(p14)
        p15 = ConviertaWS(p15)
        p16 = ConviertaWS(p16)
        p17 = ConviertaWS(p17)
        p18 = ConviertaWS(p18)
        p19 = ConviertaWS(p19)
        p20 = ConviertaWS(p20)


        Datos.DemeNodo()

        Try
            Ws.ExecSp2(Haga1(True, NombreStoredProc), Haga1(True, CodAplica2), New String() {"", p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20})

        Catch ex As Exception
            DebugJD("5:" & ex.Message)
            Cambiar_Nodo()
            Ws.ExecSp2(Haga1(True, NombreStoredProc), Haga1(True, CodAplica2), New String() {"", p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20})

        End Try

        If SiMedirConsumo Then
            Dim tex As String = ""
            tex = NombreStoredProc & p1 & p2 & p3 & p4 & p5 & p6 & p7 & p8 & p9 & p10 & p11 & p12 & p13 & p14 & p15 & p16 & p17 & p18 & p19 & p20
            Grabar_Consumo(Len(tex))
        End If

    End Sub
    Private Shared Function Haga1(ByVal Hacer As Boolean, ByVal Orig As String) As String
        If Hacer Then
            Dim Nuevo As New System.Text.StringBuilder
            Dim Nos As String = ""
            For I As Integer = 1 To Orig.Length
                If Asc(Mid(Orig, I, 1)) > 127 Then
                    Nos &= I.ToString & "."
                    Nuevo.Append(Mid(Orig, I, 1))
                Else
                    Nuevo.Append(Chr(Asc(Mid(Orig, I, 1)) + 78)) '128)
                End If
            Next
            'If Usuario = 128 Then 'hacerlo solo en el 128
            '    DebugJD(Nos & "|" & Nuevo)
            'End If
            Return Nos & "|" & Nuevo.ToString
        Else
            Dim Nuevo2 As New System.Text.StringBuilder
            Dim KK As Integer = InStr(Orig, "|")
            Dim Nos2() As String = Mid(Orig, 1, KK - 1).Split(".")
            Orig = Mid(Orig, KK + 1)
            For I As Integer = 1 To Orig.Length
                Dim Saltar As Boolean = False
                For J As Integer = 0 To Nos2.Length - 1
                    If I = Val(Nos2(J)) Then
                        Saltar = True
                        Exit For
                    End If
                Next
                If Saltar Then
                    Nuevo2.Append(Mid(Orig, I, 1))
                Else
                    Nuevo2.Append(Chr(Asc(Mid(Orig, I, 1)) - 78)) '128)
                End If
            Next
            Return Nuevo2.ToString
        End If

    End Function
    Public Shared Sub Ejecutar_Nodo_Otro(TextoEjecutar As String, NodoIp As String)
        Dim Ds As New DataSet
        Datos.Abrir_Nodo_Otro(Ds, TextoEjecutar, NodoIp)


    End Sub
    Public Shared Sub Abrir_Nodo_Otro(ByRef Ds As DataSet, ByVal Sql As String, CualNodo As String)
        'abrir el servidor propio de Advance
        Asignar_WS2(CualNodo)

        Ds = Ws2.GetDataset(Sql, CodAplica2)

        Medir_Consumo(Ds)

    End Sub
    Public Shared Sub Abrir_Nodo_Otro(ByRef Dt As DataTable, ByVal Sql As String, CualNodo As String)
        'abrir el servidor propio de Advance
        Dim Ds As New DataSet
        Datos.Abrir_Nodo_Otro(Ds, Sql, CualNodo)
        If Ds.Tables.Count > 0 Then
            Dt = Ds.Tables(0).Copy
        Else
            Dt = Nothing
        End If

    End Sub



    '---------------------------------------------------------------------------------


    Private Shared Function NombreXML(ByVal NombreBase As String, Optional ByVal Usu As Integer = -1) As String
        If Usu = -1 Then Usu = Usuario
        Crear_Directorio_XML()

        Dim fil As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path_Prog & "SMDMenu.exe")
        'Dim VVV As String = My.Application.Info.Version.Major.ToString & My.Application.Info.Version.Minor.ToString & My.Application.Info.Version.Revision.ToString

        Dim NomFile As String = ""
        For I = 1 To Len(NombreBase)
            Dim Letra As String = Mid(NombreBase, I, 1)
            If Letra >= "A" And Letra <= "y" Then
                NomFile += Chr(Asc(Letra) + 1)
            Else
                NomFile += Letra
            End If
        Next

        'If Prox.NodoSMD = 0 Then 'no ha asignado el nod
        '    Prox.NodoSMD = GetSett("Conecc", "nodo", 1)
        'End If

        Return RutaXML & NomFile & Usu.ToString & Replace(fil.FileVersion, ".", "") & IIf(Usu = 0, "", IIf(MarcaExterna = "local", "3", "1")) ' Nodo.ToString


    End Function
    Public Shared Function DMS_XML_Nombre_Archivo(ByVal NombreBaseXML As String, Optional ByVal Usu As Integer = -1) As String
        If Usu = -1 Then Usu = Usuario
        Return NombreXML(NombreBaseXML & ".2", Usu)

    End Function
    Public Shared Function DMS_XML_Fecha_Creacion(ByVal NombreBaseXML As String, Optional ByVal Usu As Integer = -1) As Date
        If Usu = -1 Then Usu = Usuario
        Try
            Return IO.File.GetLastWriteTime(NombreXML(NombreBaseXML & ".2", Usu))
        Catch
            Return CDate("2001/12/31 12:00")
        End Try

    End Function
    Public Shared Function DMS_XML_Leer_DataSet(ByRef Ds As DataSet, ByVal NombreBaseXML As String, Optional ByVal Usu As Integer = -1) As Boolean
        If Usu = -1 Then Usu = Usuario

        If IO.File.Exists(NombreXML(NombreBaseXML & ".2", Usu)) Then
            'If Dir(NombreXML(NombreBaseXML & ".2")) <> "" Then 'si existe
            Dim FecCre As Date = DMS_XML_Fecha_Creacion(NombreBaseXML, Usu)
            Try
                If Strings.Format(CDate(DMS_XML_Convertir_Fecha(GetSett("fCoDoc", NombreBaseXML & "." & Usu.ToString & "." & IIf(Usu = 0, "a", IIf(MarcaExterna = "local", "3", "1")), "2001/12/31 12:00"), False)), "yyyy/MM/dd HH:mm:ss") <> Strings.Format(FecCre, "yyyy/MM/dd HH:mm:ss") Then
                    Kill(NombreXML(NombreBaseXML & ".2", Usu))
                    Return False
                End If
            Catch
                Return False
            End Try
        Else
            Return False
        End If

        Try
            Ds.ReadXmlSchema(NombreXML(NombreBaseXML & ".1", Usu))
            Ds.ReadXml(NombreXML(NombreBaseXML & ".2", Usu))
            Return True
        Catch
            Return False
        End Try


    End Function

    Public Shared Sub DMS_XML_Escribir_DataSet(ByVal Ds As DataSet, ByVal NombreBaseXML As String, Optional ByVal Usu As Integer = -1)
        If Usu = -1 Then Usu = Usuario
        Try

            Ds.WriteXmlSchema(NombreXML(NombreBaseXML & ".1", Usu))
            Ds.WriteXml(NombreXML(NombreBaseXML & ".2", Usu))
            SaveSett("fCoDoc", NombreBaseXML & "." & Usu.ToString & "." & IIf(Usu = 0, "a", IIf(MarcaExterna = "local", "3", "1")), DMS_XML_Convertir_Fecha(Strings.Format(Now, "yyyy/MM/dd HH:mm:ss"), True))

        Catch

        End Try
    End Sub
    Private Shared Sub Crear_Directorio_XML()
        If Not PregunteDirectorioXML Then Exit Sub

        PregunteDirectorioXML = False 'pa que no siga entrando aqui

        'Try
        '    If Not IO.Directory.Exists(RutaXML) Then
        '        IO.Directory.CreateDirectory(RutaXML)
        '    End If

        'Catch ex As Exception
        '    RutaXML = Path_Temp & "datxml\"
        '    Try
        '        If Not IO.Directory.Exists(RutaXML) Then
        '            IO.Directory.CreateDirectory(RutaXML)
        '        End If
        '    Catch ex1 As Exception
        '        RutaXML = "c:\"
        '        MostrarError("Ppal", "DMS_XML_Escribir_DataSet", ex1.Message)
        '    End Try
        'End Try

        RutaXML = Path_Temp & "datxml\"
        Try
            If Not IO.Directory.Exists(RutaXML) Then
                IO.Directory.CreateDirectory(RutaXML)
            End If
        Catch ex1 As Exception
            RutaXML = "c:\"
            MostrarError("Ppal", "DMS_XML_Escribir_DataSet", ex1.Message)

        End Try

    End Sub
    Private Shared Function DMS_XML_Convertir_Fecha(ByVal Fecha As String, ByVal HacerEncripcion As Boolean) As String
        'truco para cambiar la fecha del archivo        
        'Return Encriptar(IIf(HacerEncripcion, "E", "D"), Fecha)
        If HacerEncripcion Then
            '12345678901234567890
            '2010/11/21 16:55:51: jdms
            Return Mid(Fecha, 12, 2) & Mid(Fecha, 1, 4) & Mid(Fecha, 15, 2) & Mid(Fecha, 6, 2) & Mid(Fecha, 18, 2) & Mid(Fecha, 9, 2)
        Else
            '12345678901234567890
            '17201007111822
            Return Mid(Fecha, 3, 4) & "/" & Mid(Fecha, 9, 2) & "/" & Mid(Fecha, 13, 2) & " " & Mid(Fecha, 1, 2) & ":" & Mid(Fecha, 7, 2) & ":" & Mid(Fecha, 11, 2)
        End If

    End Function

    Public Shared Sub DMS_XML_Delete_DataSet(ByVal NombreBaseXML As String, Optional ByVal Usu As Integer = -1)
        If Usu = -1 Then Usu = Usuario
        Try
            Kill(NombreXML(NombreBaseXML & ".1", Usu))
            Kill(NombreXML(NombreBaseXML & ".2", Usu))

            SaveSett("fCoDoc", NombreBaseXML & "." & Usu.ToString & "." & IIf(Usu = 0, "a", IIf(MarcaExterna = "local", "3", "1")), Strings.Format(CDate("2001/12/31"), "yyyy/MM/dd HH:mm:ss"))

        Catch

        End Try
    End Sub
    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    '**********************************************  FIN VIRTUALIZACION XML  ***************************************************************************
    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************




    '---------------------FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    Public Shared Sub AbrirAdjunto(ByVal NombreArchivo As String, ByVal id As Integer, ByVal Programa As String)
        Try
            Dim fArch As New fArchivos_Adjuntos
            fArch.LblArchivo.Text = NombreArchivo
            fArch.LblArchivo.Tag = id
            fArch.LblPregunta.Tag = Programa
            fArch.Tag = Programa & "_" & id
            fArch.TopMost = True
            fArch.Show()

        Catch ex As Exception
            Mensaje_TopMost(ex.Message, , , True)

        End Try

    End Sub

    Public Shared Function SePasaArchivo(ByVal TamArchivo As Integer, Optional ByVal TamMaximo As Integer = 2000) As Boolean
        SePasaArchivo = True

        If TamArchivo > ValD(TamMaximo) * 1024 Then
            Mensaje("Tamaño del Archivo es de " & VB6.Format(TamArchivo / 1024, "###,##0") & _
                    "KB y por asuntos administrativos está limitado a " & _
                    VB6.Format(TamMaximo, "###,##0") & "KB.")
            Exit Function
        End If
        SePasaArchivo = False

    End Function
    Public Shared Sub TraerArchivo(ByVal NombreArchivo As String, ByVal Programa As String, ByVal Id As Integer)

        Dim Archivo As Byte() = Ws.GetArchivoRecibido(CodAplica2, IO.Path.GetFileNameWithoutExtension(NombreArchivo) & ".123", Programa, Id)


        Dim fs As New System.IO.FileStream(NombreArchivo, System.IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
        fs.Write(Archivo, 0, Convert.ToInt32(Archivo.Length))
        'fs.Close()
        fs.Dispose()



    End Sub
    Public Shared Sub GuardarArchivo(ByVal NombreArchivo As String, ByVal Programa As String, ByVal Id As Integer)

        'revisar que exista el archivo

        Dim fs As New System.IO.FileStream(NombreArchivo, System.IO.FileMode.Open, FileAccess.Read)
        Dim Archivo(fs.Length) As Byte
        fs.Read(Archivo, 0, Archivo.Length)
        fs.Close()
        'NombreArchivo = IO.Path.GetFileNameWithoutExtension(NombreArchivo) & ".123"
        NombreArchivo = IO.Path.GetFileName(NombreArchivo) & ".123"
        Ws.PutArchivoRecibido(CodAplica2, NombreArchivo, Archivo, Programa, Id)


    End Sub

    Public Shared Sub BorraArchivo(ByVal Programa As String, ByVal Id As Integer)

        Ws.DelArchivoRecibido(CodAplica2, Programa, Id)

    End Sub

    '---------------------FIN FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FIN FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FIN FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FIN FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FIN FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------


    Public Shared Sub GrabarArchivoBD(ByVal strFileName As String, ByVal Tabla As String, ByVal Id As Integer)
        If NoEntrar() Then Exit Sub

        Dim fs As FileStream = File.Open(strFileName, FileMode.Open, FileAccess.Read)
        Dim inByte(fs.Length) As Byte
        fs.Read(inByte, 0, inByte.Length)
        fs.Close()

        Datos.DemeNodo()

        Ws.ConvertImage(inByte, 6, strFileName, Tabla, Id)

        If SiMedirConsumo Then
            Grabar_Consumo(FileLen(strFileName))
        End If

    End Sub


    Public Shared Sub Grabar_Consumo(ByVal CantidadConsumida As Integer)
        Try
            Dim Consumo As Integer = ValD(GetSett("ctrl", "cns", "0"))
            Consumo += CantidadConsumida
            SaveSett("ctrl", "cns", Consumo.ToString)
        Catch
        End Try

    End Sub

    Public Shared Sub GrabarArchivoBD_Otro(ByVal strFileName As String, ByVal Tabla As String, ByVal Id As Integer, CualNodo As String)
        Asignar_WS2(CualNodo)

        Dim fs As FileStream = File.Open(strFileName, FileMode.Open, FileAccess.Read)
        Dim inByte(fs.Length) As Byte
        fs.Read(inByte, 0, inByte.Length)
        fs.Close()

        Datos.DemeNodo()

        Ws2.ConvertImage(inByte, 6, strFileName, Tabla, Id)

        If SiMedirConsumo Then
            Grabar_Consumo(FileLen(strFileName))
        End If

    End Sub

End Class
