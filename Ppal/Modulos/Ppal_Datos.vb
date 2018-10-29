' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 675, 14-ago.-2018 18:45
' Version: 650, 7-may.-2018 12:42
' Version: 649, 2-may.-2018 12:48
' Version: 624, 12-feb.-2018 12:32
' Version: 622, 8-feb.-2018 20:05
'♥ versión: 586, 6-oct.-2017 07:11
Imports Microsoft.Win32
Imports System.Windows.Forms
Imports System.Web
Imports System
Imports System.Diagnostics
Imports System.IO


'Version: 68X, 2X-oct.-2018 XX:XX
'Librerías requeridas para el acceso al web Api
Imports Newtonsoft.Json
Imports SMDApi.Client
Imports System.Threading.Tasks
Public Module Ppal_Datos
    'Dim ConexionDirecta As Boolean = True 'debe ser asi: true
    Public IPAdv As String = "190.85.68.202"
    Public TomarIp3 As Boolean = False
    Dim UsarSegundaIp As Boolean = False
    Public SiMedirConsumo As Boolean = False
    Public PreguntarConsumo As Boolean = True
    Public HoraInicialConsumo As Date
    Dim PregunteDirectorioXML As Boolean = True
    Dim IpServicio As String = ""
    Public EstoyEnMenuPpal As Boolean = False
    Dim DtIps As DataTable
    Public VarJD As String = ""
    Public DsUsoEspecial As DataSet
    Public TiempoIniciEspecial As DateTime

#Region "Variables acceso WebApi"

    Public PuertoPruebas As String = "62914" 'En modo local el api corre en un puerto específico
    Public urlApi As String = ""
    Public UsarApi As Boolean = True   'Se usará el servicio web existente por defecto
    Public DevolverXml As Boolean = False
    Public SiempreXml As Boolean = False 'Por defecto se devolverá JSON
    Public strToken As String 'Cadena que contiene el token sin serializar
    Public Token As SMDApi.DTO.Token 'Objeto Token una vez serializado
    Public ClaveUsuario As String
    Public WebApi As ApiService
#End Region

#Region "Funciones WebApi"

    'Si la url del api no se ha asignado la asigna basándose en la dirección del servicio web
    Private Sub AsignarUrlApi()
        If (urlApi = "") Then
            Dim url = DemeNodo()
            Dim host = ""
            If (url <> "") Then
                Dim cuantos As Int16 = 0
                For index = 0 To url.Length
                    If url(index) = "/" Then
                        cuantos = cuantos + 1
                        If (cuantos = 3) Then
                            host = url.Substring(0, index)
                            If (PuertoPruebas <> "") Then
                                host = host + ":" + PuertoPruebas
                            End If
                            Exit For
                        End If
                    End If
                Next
            End If
            urlApi = host
            WebApi = New ApiService(urlApi)
            WebApi.Usuario = Usuario
            WebApi.Clave = "123"
            'Params.UrlApi = urlApi

        End If
    End Sub

#End Region


    Public Function Convierta_IP(MarcaExt As String)
        'pru jd 2013-12-04
        'SaveSett("Conecc", "ipfija", MarcaExt)

        Cargar_IPS()

        If DtIps Is Nothing Then 'si no encontró nada, suerte!!!
            Return MarcaExt
        End If
        If Fin(DtIps) Then
            Mensaje("No hay nada en DtIps en Convierta_IP")
            Return MarcaExt
        End If

        If MarcaExt = "3" Then MarcaExt = "col"
        Dim Dt As DataTable = Filtrar_DataTable(DtIps, "marca='" & LCase(MarcaExt) & "'")
        If Fin(Dt) Then
            Return MarcaExt
        Else
            If IsDBNull(Gdf(Dt, "ip2_publica")) Or IsDBNull(Gdf(Dt, "ip2")) Then 'si la 2 no es pública, coger la 1, o si la ip2 esta nula también
                Return Gdf(Dt, "ip1")
            Else
                Return "" & Gdf(Dt, "ip2")
            End If
        End If



    End Function
    'Cambiado a función que devuelve un string
    Public Function DemeNodo() As String
        Dim CualIP As String
        If EntroWS Then Exit Function
        EntroWS = True

        System.Net.ServicePointManager.CertificatePolicy = New TrustAllCertificatePolicy()
        'System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.ServicePointManager

        'saber que Pais soy yo como usuario de ADVANCE
        'se paso para Traer_Usuario_Clientes
        'IdPais = ValD(GetSett("Ayuda", "Pais", "1"))

        Dim EsPrueba As Boolean = False
        If SQL = "*pru*" Then
            EsPrueba = True
        Else
            'para saber si es prueba
            If GetSetting("sysw", "sysw", "wspru", "0") = "1" Then
                EsPrueba = True
            End If
        End If
        SQL = ""

        If EsPrueba Then
            Mensaje(Idi("ATENCIÓN: Recuerde que está entrando en una base de datos de PRUEBAS y no está trabajando con su información real.", "ATTENTION: Remember that you are entering a TEST database and you are not working with your real information."))
        End If
        With Prox
            If .Certific = -1 Then
                .Certific = ValD(GetSett("Conecc", "Certif", 0))
                SQL &= "Certif,"
            End If
            DebugJD("**Certific: " & .Certific)

            Dim Certif As String
            If .Certific = 1 Then
                Certif = "https" 'requiere certificado seguro
            Else
                Certif = "http"
            End If
            SQL &= Certif & ","




            CualIP = GetSett("Conecc", "ipfija", "")
            DebugJD("ppal_datos: cualip: " & CualIP)
            If TomarIp3 Then
                CualIP = GetSetting("sysw", "sysw", "ip4", "")
                DebugJD("ppal_datos: TomarIp3=True: " & CualIP)
            End If
            If CualIP = "" Or CualIP = "ipf" Then
                CualIP = GetSetting("sysw", "sysw", "ip", "")
                DebugJD("ppal_datos: ultima opc: " & CualIP)
            End If


            CualIP = Replace(CualIP, "http://", Certif & "://")
            If CualIP <> "" Then 'esto es para intergrupo y nodos distintos a col
                SQL &= "if8,"
                Ws.Url = CualIP
            Else 'para dms y el resto
                SQL &= "if9,"
                Ws.Url = Certif & "://" & IPAdv & "/smsws/smdws.asmx" '
            End If

            If DesdeFuente Then
                If Ws.Url <> "http://localhost/smdws/smdws.asmx" And PreguntarLocal And UCase(ArchivoSinPath(Application.ExecutablePath)) <> "SMDMENU.EXE" Then
                    If Pregunte("Desea obtener las IPS de su BD Local?", "Ips", "ppal_datos") Then
                        Ws.Url = "http://localhost/smdws/smdws.asmx"
                    End If
                    PreguntarLocal = False
                End If
            End If
            'If Not Ws.Url.Contains(IPAdv) Then
            '    If My.Computer.Name = "VAIO-DUO-JD" Then
            '        Mensaje("Estoy en: " & Ws.Url.ToString)
            '    End If
            'End If

            'JDMS: 2013-11-20
            If MarcaExterna <> "col" And Ws.Url.Contains(IPAdv) And MarcaExterna <> "" Then
                Mensaje("IP inválida, se cambiará a Local")
                MarcaExterna = "local"
                Ws.Url = "http://localhost/smdws/smdws.asmx"
            End If

            If .Si = -1 Then
                SQL &= "if10,"
                .Si = ValD(GetSett("Conecc", "proxy_si", 0))
                If .Si = 1 Then
                    SQL &= "if11,"
                    .DirURL = GetSett("Conecc", "proxy_dir", "")
                    .Puerto = GetSett("Conecc", "proxy_puerto", "")
                End If
            End If

            If .User_Si = -1 Then
                SQL &= "if12,"
                .User_Si = ValD(GetSett("Conecc", "proxy_usuario_si", 0))
                If .User_Si = 1 Then
                    SQL &= "if13,"
                    .Usuario = GetSett("Conecc", "proxy_usuario", "")
                    .Clave = GetSett("Conecc", "proxy_clave", "")
                End If
            End If

        End With
        'Ws.Timeout = 240000
        'jdms: 5-ago-2014: milton dice que con -1 queda infinito, para eticos
        Ws.Timeout = -1


        'solo para la parte de Proxy setting
        Try
            With Prox
                Dim proxyobj As New System.Net.WebProxy
                If .Si = 1 And .DirURL <> "" Then
                    SQL &= "if14,"
                    proxyobj = New System.Net.WebProxy(.DirURL, Convert.ToInt32(.Puerto))
                End If
                If .User_Si = 1 And .Usuario <> "" Then 'viene
                    SQL &= "if15,"
                    Dim Cre As New System.Net.NetworkCredential
                    Cre.UserName = .Usuario
                    Cre.Password = .Clave
                    'proxyobj = System.Net.WebProxy.GetDefaultProxy
                    proxyobj.Credentials = Cre
                    Ws.Proxy = proxyobj
                End If
            End With

        Catch ex As Exception
            MsgBox("Error en Proxy: " & ex.Message & EsIngles())

        End Try

        If EsPrueba Then
            Dim i2 As Integer = InStr(Ws.Url, "smd")
            If i2 > 0 Then
                For k As Integer = i2 To Ws.Url.ToString.Length
                    If Mid(Ws.Url, k, 1) = "/" Then 'terminó
                        Dim tt As String = Mid(Ws.Url, i2, k - i2 + 1)
                        Ws.Url = Ws.Url.Replace(tt, tt.Replace("/", "") & "_pru/")
                        DebugJD("ppal_datos pruebas: ws.url=" & Ws.Url)
                        Exit For
                    End If
                Next
            End If
        End If
        DebugJD("ppal_datos: ws.url=" & Ws.Url)
        SQL &= DMScr() & Ws.Url
        Return CualIP
    End Function

    Public Function NoEntrar() As Boolean
        'If traerotrp() <> renglones And traerotrp() + 157000 <> renglones Then
        If traerotrp() <> renglones And traerotrp() + 164000 <> renglones Then
            Mensaje("Acceso a la DLL no está permitido.")
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub MergeDMS(ByRef DtDestino As DataTable, ByVal DtOrigen As DataTable)
        DtDestino.Merge(DtOrigen)

        'todo esto hacia abajo lo probé y no mejora la velocidad cuando el numero de columnas es distinto

        'If DtDestino Is Nothing Then
        '    DtDestino = DtOrigen.Copy
        '    Exit Sub
        'End If

        'If DtDestino.Rows.Count = 0 And DtDestino.Columns.Count = 0 Then
        '    DtDestino = DtOrigen.Copy
        '    Exit Sub
        'End If

        ''igualar columnas
        'For Each Coco As DataColumn In DtOrigen.Columns
        '    If Not DtDestino.Columns.Contains(Coco.ColumnName) Then
        '        Dim cc As New DataColumn
        '        cc.ColumnName = Coco.ColumnName
        '        cc.DataType = Coco.DataType
        '        DtDestino.Columns.Add(cc)

        '    End If
        'Next

        'For Each Fi As DataRow In DtOrigen.Rows
        '    DtDestino.ImportRow(Fi)
        'Next

        ''If DtDestino.Columns.Count <> DtOrigen.Columns.Count Then
        ''    DtDestino.Merge(DtOrigen)
        ''Else
        ''    For Each Fi As DataRow In DtOrigen.Rows
        ''        DtDestino.ImportRow(Fi)
        ''    Next
        ''End If


    End Sub


#Region "Virtualización"


    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    '**********************************************  VIRTUALIZACION XML  *******************************************************************************
    '**********************************************  13-NOV-2010 JDMS    *******************************************************************************
    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************

    Private Function NombreXML(ByVal NombreBase As String, Optional ByVal Usu As Integer = -1) As String
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
    Private Function traerotrp() As Integer
        'Dim xxx As Integer = 278
        Dim xxx As Integer = 271 '2012-11-20
        Dim recp As Integer = 540

        Return ValD(xxx.ToString & recp.ToString) + 5


    End Function
    Public Function DMS_XML_Nombre_Archivo(ByVal NombreBaseXML As String, Optional ByVal Usu As Integer = -1) As String
        If Usu = -1 Then Usu = Usuario
        Return NombreXML(NombreBaseXML & ".2", Usu)

    End Function
    Public Function DMS_XML_Fecha_Creacion(ByVal NombreBaseXML As String, Optional ByVal Usu As Integer = -1) As Date
        If Usu = -1 Then Usu = Usuario
        Try
            Dim Fec As DateTime = IO.File.GetLastWriteTime(NombreXML(NombreBaseXML & ".2", Usu))
            If Year(Fec) < 2001 Then
                Return CDate("2001/12/31 12:00")
            Else
                Return Fec
            End If
        Catch
            Return CDate("2001/12/31 12:00")
        End Try

    End Function
    Public Function DMS_XML_Leer_DataSet(ByRef Ds As DataSet, ByVal NombreBaseXML As String, Optional ByVal Usu As Integer = -1) As Boolean
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

    Public Sub DMS_XML_Escribir_DataSet(ByVal Ds As DataSet, ByVal NombreBaseXML As String, Optional ByVal Usu As Integer = -1)
        If Usu = -1 Then Usu = Usuario
        Try

            Ds.WriteXmlSchema(NombreXML(NombreBaseXML & ".1", Usu))
            Ds.WriteXml(NombreXML(NombreBaseXML & ".2", Usu))
            SaveSett("fCoDoc", NombreBaseXML & "." & Usu.ToString & "." & IIf(Usu = 0, "a", IIf(MarcaExterna = "local", "3", "1")), DMS_XML_Convertir_Fecha(Strings.Format(Now, "yyyy/MM/dd HH:mm:ss"), True))

        Catch

        End Try
    End Sub
    Private Sub Crear_Directorio_XML()
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
    Private Function DMS_XML_Convertir_Fecha(ByVal Fecha As String, ByVal HacerEncripcion As Boolean) As String
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

    Public Sub DMS_XML_Delete_DataSet(ByVal NombreBaseXML As String, Optional ByVal Usu As Integer = -1)
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
#End Region

    Private Sub Cargar_IPS()
        'lo quito porque desde fuente saca error
        'lo vuelvo a poner 28-oct-2016
        If DtIps IsNot Nothing Then Exit Sub

        'en desconectado no necesito IPS
        If EstoyDesconectadoNuevo Then Exit Sub

        Try
            'SiReloj()
            Dim IpFija As String = GetSett("Conecc", "ipfija", "")
            DtIps = New DataTable
            'If IpFija = "local" Or IpFija = "" Then
            '    Ppal.Ws.Url = "http://localhost/smdws/smdws.asmx"
            '    SaveSett("Conecc", "ipfija", "http://localhost/smdws/smdws.asmx")
            '    EntroWS = False
            'End If

            'truco jd 2013-12-04
            If IpFija = "" Then IpFija = "local"

            DebugJD("Cargar_IPS: IpFija: " & IpFija & ", URL: " & Ppal.Ws.Url)

            'quitamos desde fuente
            'If IpFija = "local" Or DesdeFuente Then
            'JDMS 20-Nov-2015: quito esto porque me da mucho problema.
            'lo vuelvo a poner , ago-6-2016
            If IpFija = "local" Then
                Try 'tratar primero con col
                    'truco 28-oct-2016
                    If GetSetting("sysw", "sysw", "name", "") = "local" And SMDPpal.SQL <> "*JUAN*" Then 'ese *JUAN* es un truco que uso en consultas SQL para poder usar las IPS reales ... nada mas para eso!!!
                        Abrir(DtIps, "GetIps")
                    Else
                        SMDPpal.SQL = ""
                        Abrir_Nodo_1(DtIps, "GetIps")
                    End If

                    'asi estaba antes de 28-oct-2016
                    'If GetSetting("sysw", "sysw", "usarlocal", "") = "1" Then 'es programador con acceso local
                    '    Abrir(DtIps, "GetIps")
                    'Else
                    '    Abrir_Nodo_1(DtIps, "GetIps")
                    'End If

                Catch ex As Exception 'tratar en la local""
                    DebugJD(ex.Message)
                    Abrir(DtIps, "GetIps")
                End Try
            Else
                Abrir_Nodo_1(DtIps, "GetIps")
            End If



            ''lo vuelvo a corregir
            ''lo quito de nuevo, ago-6-2016
            'If IpFija = "local" Then
            '    Try
            '        Abrir(DtIps, "GetIps")
            '    Catch ex As Exception 'tratar en la local
            '        DebugJD(ex.Message & EsIngles)
            '    End Try
            'Else
            '    Abrir_Nodo_1(DtIps, "GetIps")
            'End If







            'NoReloj()
            'si es el menu no activar esta opción
            If UCase(ArchivoSinPath(Application.ExecutablePath)) <> "SMDMENU.EXE" Then
                EntroWS = False
            End If
            PreguntarLocal = False
            DtIps.Rows.Add("  ult", "Ultimo Usado", GetSett("ppal", "ultcual", "local"), "")
            DtIps = Filtrar_DataTable(DtIps, "", "marca")
            DtIps.Rows(0).Item(0) = "ult"

        Catch ex As Exception
            Mensaje("No pudo abrir el Advance principal.  Debe estar conectado a Internet: " & ex.Message & EsIngles())
        End Try

    End Sub

    Public Function BuscarIpFija() As String
        If NoEntrar() Then
            Return "local"
        End If


        Static IpFija As String = ""
        If IpFija <> "" Then Return IpFija


        IpFija = GetSett("Conecc", "ipfija", "")
        If IpFija <> "" Then 'guardarla para engañar la del instalador
            'If Strings.Left(IpFija, 5) <> "local" Then
            '    IpFija = "ipf" 'IpFija
            'End If
        Else
            IpFija = GetSetting("sysw", "sysw", "name", "")
        End If
        Dim Ip2 = IpFija

        'ESTO ERA PARA QUE NO PREGUNTARA EL NODO, PERO NO SE PUEDE
        'If IdCotizaInicial <> "" And IdCotizaInicial <> "0" And Left(IdCotizaInicial, 1) <> "*" Then
        '    Return IpFija
        'End If
        If EstoyEnMenuPpal Then
            Return IpFija
        End If

        'si trae la clave de local

        'EstoyEnMenuPpal = True
Repetir:

        Dim Cual As String = "0"
        DebugJD("Entró preguntar nodo: Formula: " & (traerotrp() + 157000 = renglones).ToString & ", desdefuente: " & DesdeFuente.ToString & ", soyservicio: " & SoyServicio.ToString)
        If traerotrp() + 157000 = renglones Or DesdeFuente Then
            'el class8 es para darlo a todo mundo cuando lo necesite, el wit5 a nadie, solo JD
            Dim Puede As Boolean = False
            Dim dms As String = "DMS S.A."
            Dim sysc As String = "syscom"

            'esta clave se obtiene en el programa de subir versión, link clave
            If ValD(GetSetting(dms, sysc, "class8", 0)) =
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
        ElseIf SoyServicio = 1 Then
            Cual = "2"
        End If

        If Cual <> "0" Then
            Pantalla_Splash(True)

            Dim Opc99 As String = GetSett("ppal", "ultcual_serv", "No hay")
            Dim UltCual = GetSett("ppal", "ultcual_real", "2")


            Dim Ult As String = GetSett("ppal", "ultcual", "local")
            If Ult = "" Then Ult = "local"


            'truco para que entre derecho cuando es fuente, se programa en fC del menu ppal
            If DesdeFuente And IpFija <> "local" Then
                If GetSetting("DMS S.A.", "fC", "fteder", "") = "S" Then
                    Cual = "ult2"
                End If
            End If
            '/truco para que entre derecho cuando es fuente, se programa en fC del menu ppal


            'Cual = InputBoxDMS(My.Application.Info.Title, "Con qué Datos desea Trabajar?", True, UltCual, New Object() {New Object() {"1", "Local", "2", "Pruebas (local2)", "5", "Profesional", "99", "Ultimo: " & Opc99}})
            'estos nombres ninguno puede tener más de 8 caracteres
            If Cual <> "ult2" Then
                DebugJD("Ppal_Datos: IpFija: " & IpFija)
                If (IpFija = "col" Or DesdeFuente) And EstoyDesconectadoNuevo = False And IpFija <> "local" Then
                    Cargar_IPS()
                    Dim Ult2 = GetSett("ppal", "ultcual_real", Ult)
                    Dim UltUsa As String = GetSett("ppal", "ultcual_usa", "")
                    Dim Sq5 As String = ""
                    If UltUsa = "" Then
                        UltUsa = ","
                    Else
                        Dim uuu3() As String = UltUsa.Split(",")
                        Dim Conta As Short = 0
                        For u5 As Integer = uuu3.Length - 1 To 0 Step -1
                            If uuu3(u5) = "" Then Continue For
                            Conta += 1
                            If Conta > 10 Then Exit For
                            Sq5 &= "'" & uuu3(u5) & "',"
                        Next
                        If Sq5 <> "" Then
                            Sq5 = "marca in(" & Strings.Left(Sq5, Len(Sq5) - 1) & ",'zzz')"
                            DtIps.Rows.Add("zzz", "", "Mostrar todos")
                        End If
                    End If
                    NoReloj(fBusIt)
Repita_IP:
                    Dim Sq6 As String = Sq5
                    If Cual = "1" Or Strings.Left(IpFija, 5) = "local" Then
                        If Sq6 <> "" Then Sq6 &= " And "
                        Sq6 &= "marca<>'col' and marca<>'3'"
                    End If
                    Cual = Ventana(Filtrar_DataTable(DtIps, Sq6), My.Application.Info.Title & ", Versión " & String_Version_Editada(), True, "marca|" & Ult2)
                    If Cual = "zzz" Then
                        Sq5 = ""
                        GoTo Repita_IP
                    End If

                    If Cual <> "" Then
                        SiReloj(fBusIt)
                    End If

                    'guardar esta
                    UltUsa = UltUsa.Replace("," & Cual & ",", ",") 'quitarla primero
                    UltUsa &= Cual & "," 'adicionar
                    SaveSett("ppal", "ultcual_usa", UltUsa) 'guardar
                Else
                    Cual = IpFija
                End If
            End If


            If IpFija <> "col" And Cual = "col" Then
                Mensaje("Opción inválida. No puede entrar a col estando en otro nodo: " & IpFija)
                GoTo Repetir
            End If

            SaveSett("ppal", "ultcual_real", IIf(Cual = "ult2", "ult", Cual))

            If Cual = "ult" Or Cual = "ult2" Then
                If Cual = "ult" Then 'solo "ult" valida equipo de jd, no ult2..Cuando quiera habilitar a Ricardo, suficiente con que ponga en fC la opción del equipo de él o un comando para quitar y para poner esta opción
                    If Not EstaEnLista(NomEquipo, "VAIO-JD", "WIN10-JD", "ASUS-RML") Then
                        Mensaje("Opción ULT es inválida (solo JD)")
                        GoTo Repetir
                    End If
                End If
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
            DebugJD("BuscarIpFija: IpFija=" & IpFija)

            Dim TexIP As String = Convierta_IP(IpFija)
            DebugJD("TexIP: " & TexIP)

            If TexIP <> "ipf" Then
                DebugJD("BuscarIpFija: TomarIp3=True")
                SaveSetting("sysw", "sysw", "ip4", TexIP)
                TomarIp3 = True
            End If



        End If

        Return IpFija


    End Function


    Public Sub Abrir_Nodo_1(ByRef Dt As DataTable, ByVal Sql As String)
        'If MarcaExterna <> "" Then
        '    Abrir(Dt, Sql)
        '    Exit Sub
        'End If

        'truco para limpiar caracteres que dan error de HTTP. Descubierto el 17-feb-2015
        Sql = Sql.Replace(Chr(31), "")

        Dim Ds As New DataSet
        If EstoyDesconectadoNuevo Then
            DebugJD("=ws=> " & Sql)
            Ds = Desconectado.GetDatasetCE(Sql)
        Else
            Abrir_Nodo_1(Ds, Sql)
        End If

        If Ds.Tables.Count > 0 Then
            Dt = Ds.Tables(0).Copy
        End If

    End Sub
    Public Sub Abrir_Nodo_1(ByRef Ds As DataSet, ByVal Sql As String)
        'truco para limpiar caracteres que dan error de HTTP. Descubierto el 17-feb-2015
        Sql = Sql.Replace(Chr(31), "")

        If EstoyDesconectadoNuevo Then
            DebugJD("=ws=> " & Sql)
            Ds = Desconectado.GetDatasetCE(Sql)
            Exit Sub
        End If

        'abrir el servidor propio de Advance
        System.Net.ServicePointManager.CertificatePolicy = New TrustAllCertificatePolicy()

        Dim Certif As String = "http"
        Dim Prox1 As New Proxy_SMD
        With Prox1
            If .Certific = -1 Then
                .Certific = ValD(GetSett("Conecc", "Certif", 0))
            End If

            If .Certific = 1 Then
                Certif = "https"
            End If

            Ws2.Url = Certif & "://" & IPAdv & "/smsws/smdws.asmx"


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
                MsgBox("Error en Proxy de nodo 1: " & ex.Message & EsIngles())
                Exit Sub
            End Try
        End With


        DebugJD("=ws=> " & Sql)
        Ds = Ws2.GetDataset(Sql, CodAplica2)

        Medir_Consumo(Ds)

    End Sub
    Public Sub Tomar_IP_Advance()
        Dim ipp As String = GetSetting("sysw", "sysw", "ipadv", "")
        If ipp <> "" Then
            IPAdv = ipp
        End If

    End Sub
    'Private Sub Cambie_URL(ByRef ww As SMDPpal.SMD.Ws)
    '    If ww.Url.Contains("190.85.68.202") Then 'cambiar a la IP alternativa cuando es "col"
    '        ww.Url = ww.Url.Replace("190.85.68.202", "190.248.158.230")
    '    ElseIf ww.Url.Contains("190.248.158.230") Then
    '        ww.Url = ww.Url.Replace("190.248.158.230", "190.85.68.202")
    '    End If

    'End Sub
    ''' <summary>
    ''' Abrir un Dt a partir de una instrucción de Sql
    ''' </summary>
    ''' <param name="Dt"></param>
    ''' <param name="Sql"></param>
    ''' <remarks></remarks>
    Public Sub Abrir(ByRef Dt As DataTable, ByVal Sql As String)
        If NoEntrar() Then Exit Sub

        'Dim Conex As System.Data.SqlClient.SqlConnection

        'If ConexionDirecta Then
        '    Dim ds1 As New DataSet
        '    Dim Hizo As Boolean = HagaDirecto(ds1, Sql)
        '    If Hizo Then
        '        Dt = ds1.Tables(0).Copy
        '        Exit Sub
        '    End If
        'End If

        'truco para limpiar caracteres que dan error de HTTP. Descubierto el 17-feb-2015
        Sql = Sql.Replace(Chr(31), "")

        Dim Ds As DataSet
        DebugJD("=ws=> " & Sql)

        If EstoyDesconectadoNuevo Then
            Ds = Desconectado.GetDatasetCE(Sql)
        Else
            If UsarApi Then
                AsignarUrlApi()

                Dim Command = New SMDApi.DTO.SqlCommand() With {
                    .Sql = Sql,
                    .Type = 1
                }
                If Not DevolverXml Then
                    Dim res = WebApi.PostSync(Of SMDApi.DTO.SqlCommand)("api", "ds", Command)
                    Ds = WebApi.DeserializeDs(res.Result.ToString())
                Else
                    Ds = WebApi.PostSyncX(Of SMDApi.DTO.SqlCommand)("api", "dsx", Command)
                End If
            Else
                DemeNodo()
                Ds = Ws.GetDataset2(Haga1(True, Sql), Haga1(True, CodAplica2))
            End If



        End If


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
    'Private Function HagaDirecto(ByRef Dt As DataSet, ByVal Sql As String, Optional EsEjecutar As Boolean = False) As Boolean
    '    If Usuario = 0 Then
    '        Return False
    '    End If

    '    Static EntrarServ As Short = -1
    '    If SoyServicio And EntrarServ = -1 Then
    '        'ver si el usuario está en la lista
    '        Dim Ds As New DataSet
    '        'reglas_emp re on re.id_emp=e.id and re.id_reglas=156 and re.llave='u' + cast(u.id as varchar)
    '        Ds = Ws.GetDataset2(Haga1(True, "select re.respuesta from reglas_emp re where re.id_emp=" & Numero_Empresa & " and re.id_reglas=156 and re.llave='u" & Usuario & "'"), Haga1(True, CodAplica2))
    '        If Fin(Ds.Tables(0)) Then
    '            EntrarServ = 0
    '        Else
    '            EntrarServ = ValD(Gdf(Ds.Tables(0), "respuesta"))
    '        End If
    '    End If

    '    If GetSett("Ayuda", "ususper", "0") <> "1" And EntrarServ <> 1 Then 'no está
    '        ConexionDirecta = False
    '        Return False
    '    End If


    '    Static DtDirectos As DataTable
    '    If DtDirectos Is Nothing Then 'leer todas las reeglas de la 156
    '        Dim Ds As New DataSet
    '        Ds = Ws.GetDataset2(Haga1(True, "select llave,respuesta from reglas_emp where id_emp=" & Numero_Empresa & " And id_reglas=156"), Haga1(True, CodAplica2))
    '        DtDirectos = Ds.Tables(0).Copy
    '    End If

    '    'buscar cada regla en el SQL actual
    '    Dim Dt2 As DataTable = Filtrar_DataTable(DtDirectos, "llave like 'p%'")
    '    Dim Encontro As Boolean = False
    '    For Each Fi As DataRow In Dt2.Rows
    '        If InStr(LCase(Sql), LCase(Fi!respuesta)) > 0 Then
    '            Encontro = True
    '        End If
    '    Next

    '    'si no hay nada parecido siga normal
    '    If Not Encontro Then
    '        Return False
    '    End If

    '    Static fSe As New fServer

    '    If Not fSe.ChkOcultar.Checked Then
    '        Dim Servidor As String = "" & Obtenga_Dato(DtDirectos, "llave='server'", "respuesta")
    '        If Servidor <> "" Then
    '            fSe.TxtServer.Text = Servidor
    '            fSe.TxtServer.Visible = False
    '        End If

    '        Dim Basedatos As String = "" & Obtenga_Dato(DtDirectos, "llave='database'", "respuesta")
    '        If Basedatos <> "" Then
    '            fSe.TxtBase.Text = Basedatos
    '            fSe.TxtBase.Visible = False
    '        End If

    '        Dim CodUsuario As String = "" & Obtenga_Dato(DtDirectos, "llave='user'", "respuesta")
    '        If CodUsuario <> "" Then
    '            fSe.TxtUser.Text = CodUsuario
    '            fSe.TxtUser.Visible = False
    '        End If

    '        Dim PassUsuario As String = "" & Obtenga_Dato(DtDirectos, "llave='clave'", "respuesta")
    '        If PassUsuario <> "" Then
    '            fSe.TxtClave.Text = PassUsuario
    '            fSe.TxtClave.Visible = False
    '        End If

    '        If Servidor = "" Or Basedatos = "" Or CodUsuario = "" Or PassUsuario = "" Then
    '            fSe.ShowDialog()
    '            If fSe.Tag = "0" Then
    '                'Mensaje("Ignora conexión directa y continua con el WebService de forma normal")
    '                Return False
    '            End If
    '        End If
    '    End If


    '    'guardar el estado de esta variable
    '    Dim Ocul As Boolean = fSe.ChkOcultar.Checked
    '    fSe.ChkOcultar.Checked = False

    '    'abrir base de datos
    '    'ahora si ejecutar la instrucción
    '    'Dim Conex As System.Data.SqlClient.SqlConnection
    '    Dim Conex As New System.Data.SqlClient.SqlConnection("Server=" & fSe.TxtServer.Text & ";Database=" & fSe.TxtBase.Text & ";User ID=" & fSe.TxtUser.Text & ";Password=" & fSe.TxtClave.Text) ' & ";Connect Timeout=20000000")

    '    'traer datos
    '    Dim Sqlc As New System.Data.SqlClient.SqlDataAdapter(Sql, Conex)

    '    'pasarlos al dataset
    '    Dt = New DataSet
    '    Sqlc.Fill(Dt)
    '    Sqlc.Dispose()

    '    'si terminó bien, devolver el estado de esta variable
    '    fSe.ChkOcultar.Checked = Ocul

    '    Return True

    'End Function
    Public Sub Abrir(ByRef Ds As DataSet, ByVal Sql As String)
        If NoEntrar() Then Exit Sub
        'Debug.Print(Sql & " --> " & Now)

        Sql = Sql.Replace(Chr(31), "")

        DebugJD("=ws=> " & Sql)
        If EstoyDesconectadoNuevo Then
            If Left(Sql, 2) <> "!!" Then 'significa que tratar de leer de internet normal.  Para ver si ya está conectado
                Ds = Desconectado.GetDatasetCE(Sql)
                Exit Sub 'no importa que no mida el consumo
            End If
            Sql = Mid(Sql, 3)
        End If

        If UsarApi Then
            AsignarUrlApi()

            Dim Command = New SMDApi.DTO.SqlCommand() With {
                    .Sql = Sql,
                    .Type = 1
                }
            If Not DevolverXml Then
                Dim res = WebApi.PostSync(Of SMDApi.DTO.SqlCommand)("api", "ds", Command)
                Ds = WebApi.DeserializeDs(res.Result.ToString())
            Else
                Ds = WebApi.PostSyncX(Of SMDApi.DTO.SqlCommand)("api", "dsx", Command)
            End If
        Else
            DemeNodo()
            Ds = Ws.GetDataset2(Haga1(True, Sql), Haga1(True, CodAplica2))
        End If


        Medir_Consumo(Ds)

    End Sub

    Public Function NoEstoyEnLinea() As Boolean
        If EstoyDesconectadoNuevo Then
            Mensaje("*** SISTEMA DESCONECTADO ***" & DMScr(2) & "No es posible crear o modificar este tipo de información en modo desconectado.  Debe hacerlo cuando esté conectado a sus datos definitivos", "Sistema desconectado")
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub Abrir(ByRef Dt As DataTable, ByVal NombreSP As String, ByVal p1 As String, Optional ByVal p2 As String = "", Optional ByVal p3 As String = "", Optional ByVal p4 As String = "", Optional ByVal p5 As String = "", Optional ByVal p6 As String = "", Optional ByVal p7 As String = "", Optional ByVal p8 As String = "", Optional ByVal p9 As String = "", Optional ByVal p10 As String = "", Optional ByVal p11 As String = "", Optional ByVal p12 As String = "", Optional ByVal p13 As String = "", Optional ByVal p14 As String = "", Optional ByVal p15 As String = "", Optional ByVal p16 As String = "", Optional ByVal p17 As String = "", Optional ByVal p18 As String = "", Optional ByVal p19 As String = "", Optional ByVal p20 As String = "")
        'Abrir(Dt, ConviertaParametros(NombreSP, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20))


        If NoEntrar() Then Exit Sub


        'Debug.Print(NombreSP & " --> " & Now)
        'truco para limpiar caracteres que dan error de HTTP. Descubierto el 17-feb-2015
        NombreSP = NombreSP.Replace(Chr(31), "")

        Dim Ds As DataSet

        If EstoyDesconectadoNuevo Then
            'If NombreSP.ToLower = "getimagen" Then 'si es este, hacer de cuenta que no encontró nada
            '    Dt = Nothing
            'Else
            '    Mensaje("en desconectado no se pueda usar " & NombreSP & ". Informe a DMS")
            'End If
            Ds = Desconectado.GetDsFromSp2(NombreSP, New String() {"", p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20})
        Else


            If UsarApi Then
                AsignarUrlApi()

                Dim params = New String() {"", p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20}
                Dim mSql = NombreSP & " "

                Dim Cuantos As Integer

                For i As Integer = 1 To 20
                    If params(i) <> "" Then
                        Cuantos = Cuantos + 1
                    End If
                Next

                For j As Integer = 1 To Cuantos
                    mSql = mSql & $"'{params(j)}',"
                Next

                If (mSql.Substring(mSql.Length - 1) = ",") Then
                    mSql = mSql.Substring(0, mSql.Length - 1)
                End If

                Dim Command = New SMDApi.DTO.SqlCommand() With {
                    .Sql = SQL,
                    .Type = 1
                }
                If Not DevolverXml Then
                    Dim res = WebApi.PostSync(Of SMDApi.DTO.SqlCommand)("api", "ds", Command)
                    Ds = WebApi.DeserializeDs(res.Result.ToString())
                Else
                    Ds = WebApi.PostSyncX(Of SMDApi.DTO.SqlCommand)("api", "dsx", Command)
                End If
            Else
                DemeNodo()
                DebugJD("=ws=> " & NombreSP)
                Ds = Ws.GetDsFromSp2(Haga1(True, NombreSP), Haga1(True, CodAplica2), New String() {"", p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20})
            End If



        End If



        Medir_Consumo(Ds)

        If Ds.Tables.Count = 0 Then
            Dt = Nothing
            Exit Sub
        End If

        Dt = Ds.Tables(0)

    End Sub
    'Private Sub Cambiar_Nodo()
    '    If MarcaExterna = "" Or TomarIp3 Then Exit Sub
    '    If GetSetting("sysw", "sysw", MarcaExterna, "") = "" Then Exit Sub


    '    UsarSegundaIp = Not UsarSegundaIp
    '    DebugJD("cambiando a nodo contingencia: " & UsarSegundaIp.ToString)
    '    EntroWS = False
    '    DemeNodo()

    'End Sub

    Public Sub Ejecutar(ByVal TextoEjecutar As String)
        If NoEntrar() Then Exit Sub

        'truco para limpiar caracteres que dan error de HTTP. Descubierto el 17-feb-2015
        TextoEjecutar = TextoEjecutar.Replace(Chr(31), "")
        If TextoEjecutar = "" Then Exit Sub

        DebugJD("=ws=> " & TextoEjecutar)

        If EstoyDesconectadoNuevo Then
            Desconectado.GetDatasetCE(TextoEjecutar)
        Else
            If UsarApi Then
                AsignarUrlApi()

                Dim Command = New SMDApi.DTO.SqlCommand() With {
                .Sql = TextoEjecutar,
                .Type = 1
                }
                Dim res = WebApi.PostSync(Of SMDApi.DTO.SqlCommand)("api", "ex", Command)
            Else
                DemeNodo()
                Ws.Exec2(Haga1(True, TextoEjecutar), Haga1(True, CodAplica2))
            End If

        End If


        If SiMedirConsumo Then Grabar_Consumo(Len(TextoEjecutar))


    End Sub
    Public Sub Ejecutar(ByVal NombreStoredProc As String, ByVal p1 As String, Optional ByVal p2 As String = "°", Optional ByVal p3 As String = "°", Optional ByVal p4 As String = "°", Optional ByVal p5 As String = "°", Optional ByVal p6 As String = "°", Optional ByVal p7 As String = "°", Optional ByVal p8 As String = "°", Optional ByVal p9 As String = "°", Optional ByVal p10 As String = "°", Optional ByVal p11 As String = "°", Optional ByVal p12 As String = "°", Optional ByVal p13 As String = "°", Optional ByVal p14 As String = "°", Optional ByVal p15 As String = "°", Optional ByVal p16 As String = "°", Optional ByVal p17 As String = "°", Optional ByVal p18 As String = "°", Optional ByVal p19 As String = "°", Optional ByVal p20 As String = "°")
        If NoEntrar() Then Exit Sub

        'If EstoyDesconectadoNuevo Then
        '    Mensaje("en desconectado no se pueda usar " & NombreStoredProc & ". Informe a DMS")
        '    Exit Sub
        'End If

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




        'truco para limpiar caracteres que dan error de HTTP. Descubierto el 17-feb-2015
        NombreStoredProc = NombreStoredProc.Replace(Chr(31), "")

        DebugJD("=ws=> " & NombreStoredProc)
        If EstoyDesconectadoNuevo Then
            Desconectado.GetDsFromSp2(NombreStoredProc, New String() {"", p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20})
        Else
            If UsarApi Then
                AsignarUrlApi()

                Dim params = New String() {"", p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20}
                Dim mSql = NombreStoredProc & " "

                Dim Cuantos As Integer

                For i As Integer = 1 To 20
                    If params(i) <> "" Then
                        Cuantos = Cuantos + 1
                    End If
                Next

                For j As Integer = 1 To Cuantos
                    mSql = mSql & $"'{params(j)}',"
                Next

                If (mSql.Substring(mSql.Length - 1) = ",") Then
                    mSql = mSql.Substring(0, mSql.Length - 1)
                End If

                Dim Command = New SMDApi.DTO.SqlCommand() With {
                    .Sql = mSql,
                    .Type = 1
                }

                Dim res = WebApi.PostSync(Of SMDApi.DTO.SqlCommand)("api", "ex", Command)
            Else
                DemeNodo()
                Ws.ExecSp2(Haga1(True, NombreStoredProc), Haga1(True, CodAplica2), New String() {"", p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20})
            End If
        End If


        If SiMedirConsumo Then
            Dim tex As String = ""
            tex = NombreStoredProc & p1 & p2 & p3 & p4 & p5 & p6 & p7 & p8 & p9 & p10 & p11 & p12 & p13 & p14 & p15 & p16 & p17 & p18 & p19 & p20
            Grabar_Consumo(Len(tex))
        End If

    End Sub
    Private Function Haga1(ByVal Hacer As Boolean, ByVal Orig As String) As String
        If Hacer Then
            Dim Nuevo As New System.Text.StringBuilder
            Dim Nos As String = ""
            Dim Especial As String = ""
            For I As Integer = 1 To Orig.Length
                If I > 100 Then
                    Nuevo.Append(Mid(Orig, I))
                    Especial = "~"
                    Exit For
                End If
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
            Return Especial & Nos & "|" & Nuevo.ToString
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

    '---------------------FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    Public Sub AbrirAdjunto(ByVal NombreArchivo As String, ByVal id As Integer, ByVal Programa As String)
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

    Public Function SePasaArchivo(ByVal TamArchivo As Integer, Optional ByVal TamMaximo As Integer = 2000) As Boolean
        SePasaArchivo = True

        If TamArchivo > ValD(TamMaximo) * 1024 Then
            Mensaje("Tamaño del Archivo es de " & Strings.Format(TamArchivo / 1024, "###,##0") &
                    "KB y por asuntos administrativos está limitado a " &
                    Strings.Format(TamMaximo, "###,##0") & "KB.")
            Exit Function
        End If
        SePasaArchivo = False

    End Function
    Public Sub TraerArchivo(ByVal NombreArchivo As String, ByVal Programa As String, ByVal Id As Integer)

        Dim Archivo As Byte() = Ws.GetArchivoRecibido(CodAplica2, IO.Path.GetFileNameWithoutExtension(NombreArchivo) & ".123", Programa, Id)


        Dim fs As New System.IO.FileStream(NombreArchivo, System.IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
        fs.Write(Archivo, 0, Convert.ToInt32(Archivo.Length))
        'fs.Close()
        fs.Dispose()



    End Sub
    Public Sub GuardarArchivo(ByVal NombreArchivo As String, ByVal Programa As String, ByVal Id As Integer)

        'revisar que exista el archivo

        Dim fs As New System.IO.FileStream(NombreArchivo, System.IO.FileMode.Open, FileAccess.Read)
        Dim Archivo(fs.Length) As Byte
        fs.Read(Archivo, 0, Archivo.Length)
        fs.Close()
        'NombreArchivo = IO.Path.GetFileNameWithoutExtension(NombreArchivo) & ".123"
        NombreArchivo = IO.Path.GetFileName(NombreArchivo) & ".123"
        Ws.PutArchivoRecibido(CodAplica2, NombreArchivo, Archivo, Programa, Id)


    End Sub

    Public Sub BorraArchivo(ByVal Programa As String, ByVal Id As Integer)

        Ws.DelArchivoRecibido(CodAplica2, Programa, Id)

    End Sub

    '---------------------FIN FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FIN FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FIN FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FIN FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------
    '---------------------FIN FUNCIONES PARA SUBIR ARCHIVOS AL SERVIDOR -------------------------------



    Public Sub GrabarArchivoBD(ByVal strFileName As String, ByVal Tabla As String, ByVal Id As Integer)
        If NoEntrar() Then Exit Sub

        Dim fs As FileStream = File.Open(strFileName, FileMode.Open, FileAccess.Read)
        Dim inByte(fs.Length) As Byte
        fs.Read(inByte, 0, inByte.Length)
        fs.Close()

        DemeNodo()

        Ws.ConvertImage(inByte, 6, strFileName, Tabla, Id)

        If SiMedirConsumo Then
            Grabar_Consumo(FileLen(strFileName))
        End If

    End Sub

    Private Sub Medir_Consumo(ByVal Ds As DataSet)

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
    Public Sub Grabar_Consumo(ByVal CantidadConsumida As Integer)
        Try
            Dim Consumo As Integer = ValD(GetSett("ctrl", "cns", "0"))
            Consumo += CantidadConsumida
            SaveSett("ctrl", "cns", Consumo.ToString)
        Catch
        End Try

    End Sub

    Public Sub GrabarArchivoBD_Otro(ByVal strFileName As String, ByVal Tabla As String, ByVal Id As Integer, CualNodo As String)
        Asignar_WS2(CualNodo)

        Dim fs As FileStream = File.Open(strFileName, FileMode.Open, FileAccess.Read)
        Dim inByte(fs.Length) As Byte
        fs.Read(inByte, 0, inByte.Length)
        fs.Close()

        DemeNodo()

        Ws2.ConvertImage(inByte, 6, strFileName, Tabla, Id)

        If SiMedirConsumo Then
            Grabar_Consumo(FileLen(strFileName))
        End If

    End Sub
    Public Sub Ejecutar_Nodo_Otro(TextoEjecutar As String, NodoIp As String)
        Dim Ds As New DataSet
        TextoEjecutar = TextoEjecutar.Replace(Chr(31), "")

        If EstoyDesconectadoNuevo Then
            Desconectado.GetDatasetCE(TextoEjecutar)
        Else
            Abrir_Nodo_Otro(Ds, TextoEjecutar, NodoIp)
        End If



    End Sub
    Public Sub Abrir_Nodo_Otro(ByRef Ds As DataSet, ByVal Sql As String, CualNodo As String)
        'truco para limpiar caracteres que dan error de HTTP. Descubierto el 17-feb-2015
        Sql = Sql.Replace(Chr(31), "")

        DebugJD("=ws=> " & Sql)

        If EstoyDesconectadoNuevo Then
            Ds = Desconectado.GetDatasetCE(Sql)
        Else
            'abrir el servidor propio de Advance
            Asignar_WS2(CualNodo)
            Ds = Ws2.GetDataset(Sql, CodAplica2)
        End If


        Medir_Consumo(Ds)

    End Sub
    Public Sub Abrir_Nodo_Otro(ByRef Dt As DataTable, ByVal Sql As String, CualNodo As String)
        'truco para limpiar caracteres que dan error de HTTP. Descubierto el 17-feb-2015
        Sql = Sql.Replace(Chr(31), "")

        'abrir el servidor propio de Advance
        Dim Ds As New DataSet


        If EstoyDesconectadoNuevo Then
            Ds = Desconectado.GetDatasetCE(Sql)
        Else
            'abrir el servidor propio de Advance
            Abrir_Nodo_Otro(Ds, Sql, CualNodo)
        End If

        If Ds.Tables.Count > 0 Then
            Dt = Ds.Tables(0).Copy
        Else
            Dt = Nothing
        End If

    End Sub

    Public Sub Abrir_Nodo_Otro_Solo_Lectura(ByRef Ds As DataSet, ByVal Sql As String, CualNodo As String, SoloLectura As Boolean)
        Sql = Sql.Replace(Chr(31), "")

        If EstoyDesconectadoNuevo Then
            Ds = Desconectado.GetDatasetCE(Sql)
        Else
            'abrir el servidor propio de Advance
            Asignar_WS2(CualNodo)

            Ds = Ws2.AbrirSQLConsultas(Sql, IIf(SoloLectura, 2, 1), CodAplica2)
        End If


        Medir_Consumo(Ds)


    End Sub
    Private Sub Asignar_WS2(CualNodo As String)
        System.Net.ServicePointManager.CertificatePolicy = New TrustAllCertificatePolicy()


        'determinar si es prueba
        Dim EsPrueba As Boolean = SQL = "*pru*"
        SQL = "" 'quito la prueba como lo hace demenodo

        Dim Prox1 As New Proxy_SMD
        With Prox1
            If .Certific = -1 Then
                .Certific = ValD(GetSett("Conecc", "Certif", 0))
            End If

            If .Certific = 1 Then
                CualNodo = CualNodo.Replace("http://", "https://")
            End If

            Ws2.Url = CualNodo 'Certif & "://" & IPAdv & "/smsws/smdws.asmx"


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

                If EsPrueba Then
                    Dim i2 As Integer = InStr(Ws2.Url, "smd")
                    If i2 > 0 Then
                        For k As Integer = i2 To Ws2.Url.ToString.Length
                            If Mid(Ws2.Url, k, 1) = "/" Then 'terminó
                                Dim tt As String = Mid(Ws2.Url, i2, k - i2 + 1)
                                Ws2.Url = Ws2.Url.Replace(tt, tt.Replace("/", "") & "_pru/")
                                DebugJD("ppal_datos pruebas: ws.url=" & Ws2.Url)
                                Exit For
                            End If
                        Next
                    End If
                End If




            Catch ex As Exception
                MsgBox("Error en Proxy de nodo 1: " & ex.Message & EsIngles())
                Exit Sub
            End Try
        End With
    End Sub


    'Public Sub AbrirInf(ByRef Ds As DataSet, ByVal Sql As String, Ascii As Boolean)
    '    If NoEntrar() Then Exit Sub
    '    'Debug.Print(Sql & " --> " & Now)

    '    Sql = Sql.Replace(Chr(31), "")

    '    DebugJD("=ws=> " & Sql)
    '    If EstoyDesconectadoNuevo Then
    '        If Left(Sql, 2) <> "!!" Then 'significa que tratar de leer de internet normal.  Para ver si ya está conectado
    '            Ds = Desconectado.GetDatasetCE(Sql)
    '            Exit Sub 'no importa que no mida el consumo
    '        End If
    '        Sql = Mid(Sql, 3)
    '    End If

    '    DemeNodo()

    '    Dim x As Byte()

    '    If Ascii Then
    '        x = Ws.GetDatasetInf2(Sql, CodAplica2)
    '    Else
    '        x = Ws.GetDatasetInf(Sql, CodAplica2)
    '    End If


    '    Using memInput As Stream = New MemoryStream(x)
    '        Using input As New ZipInputStream(memInput)
    '            Dim entry As ZipEntry = input.GetNextEntry()

    '            Dim newBytes As Byte() = New Byte(entry.Size - 1) {}
    '            Dim count As Integer = input.Read(newBytes, 0, newBytes.Length)

    '            Dim xmlString As String

    '            If Ascii Then
    '                xmlString = System.Text.ASCIIEncoding.ASCII.GetString(newBytes)
    '            Else
    '                xmlString = System.Text.UnicodeEncoding.Unicode.GetString(newBytes)
    '            End If

    '            Ds = New DataSet
    '            Ds.ReadXml(New System.Xml.XmlTextReader(New StringReader(xmlString)))

    '        End Using
    '    End Using


    '    Medir_Consumo(Ds)

    'End Sub

End Module
