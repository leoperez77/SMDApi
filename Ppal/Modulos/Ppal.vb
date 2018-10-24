' Version: 694, 28-sep.-2018 12:57
' Version: 691, 17-sep.-2018 20:53
' Version: 690, 13-sep.-2018 12:20
' Version: 689, 12-sep.-2018 13:31
' Version: 689, 12-sep.-2018 13:17
' Version: 689, 12-sep.-2018 13:11
' Version: 688, 11-sep.-2018 13:13
' Version: 687, 5-sep.-2018 13:13
' Version: 685, 28-ago.-2018 12:08
' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 21-ago.-2018 10:37
' Version: 681, 20-ago.-2018 21:33
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 679, 16-ago.-2018 21:01
' Version: 679, 16-ago.-2018 20:01
' Version: 678, 16-ago.-2018 14:15
' Version: 677, 15-ago.-2018 13:39
' Version: 676, 14-ago.-2018 22:29
' Version: 675, 14-ago.-2018 18:45
' Version: 661, 10-jul.-2018 13:27
' Version: 656, 5-jun.-2018 12:37
' Version: 655, 1-jun.-2018 12:53
' Version: 653, 16-may.-2018 12:43
' Version: 650, 7-may.-2018 12:42
' Version: 649, 2-may.-2018 12:48
' Version: 645, 17-abr.-2018 12:53
' Version: 645, 17-abr.-2018 12:40
' Version: 643, 10-abr.-2018 13:18
' Version: 641, 4-abr.-2018 12:52
' Version: 640, 3-abr.-2018 13:06
' Version: 637, 13-mar.-2018 12:42
' Version: 636, 9-mar.-2018 13:03
' Version: 632, 1-mar.-2018 13:22
' Version: 628, 23-feb.-2018 12:35
' Version: 624, 12-feb.-2018 12:32
' Version: 622, 8-feb.-2018 20:05
' Version: 621, 8-feb.-2018 12:41
' Version: 619, 5-feb.-2018 12:54
' Version: 618, 1-feb.-2018 13:56
' Version: 616, 25-ene.-2018 12:32
' Version: 599, 22-nov.-2017 12:55
' Version: 597, 14-nov.-2017 14:55
' Version: 594, 1-nov.-2017 12:36
' Version: 590, 18-oct.-2017 18:37
'♥ versión: 588, 12-oct.-2017 17:24
'♥ versión: 587, 11-oct.-2017 11:31
'♥ versión: 586, 6-oct.-2017 07:11
'♥ versión: 586, 6-oct.-2017 06:57
'♥ versión: 586, 5-oct.-2017 21:44
Imports Microsoft.Win32
Imports System.Windows.Forms
Imports System.Web
Imports System
Imports System.Diagnostics
Imports System.IO


Public Module Ppal

#Region "Variables para Proxy y Nodo"
	Public Prox As New Proxy_SMD
	'Dim NodoSMD As Integer = 0
	'Dim Proxy_Si As Short = -1
	'Dim Proxy_User_Si As Short = -1
	'Dim Proxy_Dir As String = ""
	'Dim Proxy_Puerto As String = ""
	'Dim Proxy_Usuario As String = ""
	'Dim Proxy_Clave As String = ""
#End Region



#Region "Variables Generales"
	'jdms 645: fecha de ultima lectura de descuentos
	Public FechaActualizoDescuentos As Object = Nothing ' DateAdd(DateInterval.Year, -10, Now)

	'arrancar la hora 60 segundos antes
	Public UltimaHoraSonido As DateTime = DateAdd(DateInterval.Day, -1, Now)

	Public ProcesandoReporteProgramado As Boolean = False


	Public ClIdioma As ClaseIdioma

	'Public FormaPersonalizada As Boolean = False
	'Public UltProgramaPers As String = ""

	Public Const qqTex = "T"
	Public Const qqFeh = "F"
	Public Const qqFec = "G"
	Public Const qqNum = "N"
	Public Const qqBol = "B"
	Public Const qqCon = "C"

	Public RealTime As Short = 0
	Public YaCargo As Boolean = False

	Public LenguajeAdvance As Short = 0
	Public DtIdioma As DataTable

	Public fImg As New fImageList 'imagelist para toda la aplicación

	Public DtRN As DataTable
	Public DtRNTit As DataTable

	Public DtDestinos As DataTable
	Public DtDestinosUnico As DataTable

	Public CreandoSerial As String = ""

	Public CualEsRetFte As Integer
	Public CualEsRetIva As Integer
	Public CualEsRetIca As Integer

	Public DtItemComent As DataTable

	Public DtFmtImp As DataSet

	Public FormasNada As FormCollection
	Public fGuarCancel As fGuardarCancelar
	Public EstoyDesconectadoNuevo As Boolean = False
	'Public YaRefrescoPermisos As Boolean = False
	Dim YaLeyoReglas As Boolean = False
	Public DtItemCosBod As DataTable
	Public UsusAdmiVeh As Short = -1 'noquitar este -1
	Public MarcaExterna As String = ""
	Public MostrarDebug As String = ""
	Public EmpresaMadre As Integer
	'Public ReintentarSQL As Boolean = False

	Public fBC As fBusCen

	Public NomEquipo As String = SinComillas(My.Computer.Name)

	Public Const InfoContactoDMS As String = vbNewLine & vbNewLine & "Dynamic Modular System S.A., DMS S.A. ©" & vbNewLine & "Pbx. (57+4) 444-2280" & vbNewLine & "email: info@advance.ms" & vbNewLine & "Medellín - Colombia"
	Public fBusIt As New fBusItems
	Public fBusV As fBusVeh
	Public HistoriaCargueItems As String = ""
	Public InformacionComplemetariaAplicacion As String = ""
	Public PuntoDecimal As String = ""
	Public NoPuntoDecimal As String = ""

	Public RutaXML As String = Path_Temp & "datxml\" 'System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\sysdatenv\"
	'Public LetraDrive As String = GetSett("conecc", "drive", "c")
	Public EstoyEnPregunta As Boolean = False
	'Public PermiteDesconectado As Boolean = False
	'Public EstoyDesconectado As Boolean = False
	Public UltimaActualizacionDatosMemoria As DateTime = Now
	Public PaginaAyuda As String = ""
	Public IdPais As Integer = 1
	Public DatoDevolver As String = ""
	Public Sistema_Lifo_Fifo As String = "F"

	Public CodAplica2 As String = Obtenga_Aplica()
	'Private CodAplica22 As String = Encriptar("E", "@$%dms.net0708")
	'Public Ws As SMD.Ws = New SMD.Ws()
	'Public Ws2 As SMD.Ws = New SMD.Ws()
	Public Ws As SMD.smdws = New SMD.smdws()
	Public Ws2 As SMD.smdws = New SMD.smdws()
	Public EntroWS As Boolean = False
	Public PreguntarLocal As Boolean = True

	Public Const DiegoSet As String = "DMS S.A. SmdAsp"
	Public renglones As Integer = 0

	Public Numero_Empresa As Integer
	Public Sector_Empresa As Short
	Public Nit_Empresa As String
	Public Usuario As Integer
	Public UsuarioOriginal As Integer
	Public Nodo As Integer
	Public DesdeFuente As Boolean = False
	Public MiNombre As String = ""
	Public MiEmpresa As String = ""
	Public MiEmpresaNombre As String = GetSett("Ayuda", "Emp", "")
	Public MiCodigo As String = ""
	Public SoyServicio As Short = 1 'ojo: debe asumir servicio
	Public BodegaUsuario As Integer
	Public Path_Prog As String
	Public Path_Temp As String
	Public DtExe As New DataTable
	Public OtraParte As String = pongalaotra()
	Public DtConcepRet As DataTable

	Public DtReglas As New DataTable
	'Public Sub CambieLimpiar(ByVal Tex As RichTextBox)
	'    Dim Ini As Integer = InStr(Tex.Rtf, "@")
	'    If Ini = 0 Then Exit Sub

	'    Dim Empezando As Boolean = False
	'    For I As Integer = Ini To Len(Tex.Rtf)
	'        If Mid(Tex.Rtf, I, 1) = "@" Then
	'            Empezando = Not Empezando
	'            'If Empezando Then
	'            '    Empezando = False
	'            'End If
	'            Mid(Tex.Rtf, I, 1) = "."
	'        Else
	'            If Empezando Then
	'                Mid(Tex.Rtf, I, 1) = "."
	'            End If
	'        End If
	'    Next

	'End Sub

	Public Function ColorSegunMarca() As Color
		Select Case LCase(MarcaExterna)
			Case "local"
				Return Color.LightCyan
			Case "local2"
				Return Color.LightYellow
			Case "col"
				Return Color.White
			Case Else
				Return Color.Bisque
		End Select

		'If MarcaExterna = "local" Then
		'    'Me.BackColor = Color.LightCyan
		'    Return Color.LightCyan
		'ElseIf MarcaExterna = "local2" Then 'servidor jd
		'    Return Color.LightYellow
		'ElseIf MarcaExterna = "ipf" Then
		'    Return Color.LightGreen
		'Else
		'    Return Color.White
		'End If

	End Function
	Public Function SoyAdvanceLite() As Boolean
		Try
			Return GetSetting("sysw", "sysw", "tpe", "") = "1"
		Catch
			Return False
		End Try

	End Function

	''' <summary>
	''' Traduce los títulos de las columnas de un grid
	''' </summary>
	''' <param name="Grd"></param>
	Public Sub Traducir_Grid(Grd As DataGridView)
		If LenguajeAdvance <> 1 Then
			Exit Sub
		End If

		Asigne_ClIdi()

		ClIdioma.Traducir_Grid_Clase(Grd)

		'Try

		'	If LenguajeAdvance = 1 Then
		'		Dim cgrd As CGrid = New CGrid
		'		cgrd.Traducir_Columnas(Grd)
		'	End If
		'Catch ex As Exception

		'End Try
	End Sub
	Public Function ArmeSQL(ByVal StoreProcedure, ByVal ParamArray ListaDeValores()) As String
		Dim S As New System.Text.StringBuilder
		Dim UsaParam As Boolean = False

		If StoreProcedure <> "" Then
			If Strings.Left(StoreProcedure, 1) = "@" Then
				UsaParam = True
				StoreProcedure = Strings.Mid(StoreProcedure, 2)
			End If
			S.Append(StoreProcedure & " ")
		End If

		Try
			Dim JJ As Integer = 0
			Do Until JJ > ListaDeValores.Length - 2
				Dim Parame As String = ""
				If UsaParam Then
					Parame = ListaDeValores(JJ) & "="
					If Strings.Left(Parame, 1) <> "@" Then
						Parame = "@" & Parame
					End If
					JJ += 1
				End If

				Dim Campo As Object = ListaDeValores(JJ)
				Dim Resp As String = ""
				Select Case UCase(ListaDeValores(JJ + 1))
					Case qqFeh
						If Campo Is Nothing Then
							Resp = "''"
						Else
							If Not IsDate(Campo) Then
								Resp = "''"
							Else
								Resp = "'" & FmtFecSQL(CDate(Campo)) & "'"
							End If
						End If
					Case qqFec
						If Campo Is Nothing Then
							Resp = "''"
						Else
							If Not IsDate(Campo) Then
								Resp = "''"
							Else
								Resp = "'" & FmtFecSQL(FechaSinHora(CDate(Campo))) & "'"
							End If
						End If
					Case qqNum
						Resp = ValDMS(ValD(Campo))
					Case qqTex
						If Campo Is Nothing Then
							Resp = "''"
						Else
							Resp = "'" & Campo.ToString.Replace("'", "''") & "'"
						End If

					Case qqCon
						Resp = Campo
					Case qqBol
						If Campo Then
							Resp = "1"
						Else
							Resp = "0"
						End If
					Case Else
						MostrarError("Ppal", "ArmeSQL parametro inválido: " & ListaDeValores(JJ + 1), S.ToString)
						Return S.ToString
				End Select
				S.Append(Parame & Resp & ",")

				JJ += 2
			Loop


			Return Strings.Left(S.ToString, S.ToString.Length - 1) & DMScr()


		Catch ex As Exception
			MostrarError("Ppal", "ArmeSQL", S.ToString & DMScr(2) & ex.Message & EsIngles())

		End Try



		Try
			For I As Integer = 0 To ListaDeValores.Length - 2 Step 3

				Dim Campo As Object = ListaDeValores(I + 1)
				Dim Resp As String = ""
				Select Case UCase(ListaDeValores(I + 2))
					Case qqFeh
						If Campo Is Nothing Then
							Resp = "''"
						Else
							If Not IsDate(Campo) Then
								Resp = "''"
							Else
								Resp = "'" & FmtFecSQL(CDate(Campo)) & "'"
							End If
						End If
					Case qqFec
						If Campo Is Nothing Then
							Resp = "''"
						Else
							If Not IsDate(Campo) Then
								Resp = "''"
							Else
								Resp = "'" & FmtFecSQL(FechaSinHora(CDate(Campo))) & "'"
							End If
						End If
					Case qqNum
						Resp = ValDMS(ValD(Campo))
					Case qqTex
						If Campo Is Nothing Then
							Resp = "''"
						Else
							Resp = "'" & Campo.ToString.Replace("'", "''") & "'"
						End If

					Case qqCon
						Resp = Campo
					Case qqBol
						If Campo Then
							Resp = "1"
						Else
							Resp = "0"
						End If
					Case Else
						MostrarError("Ppal", "ArmeSQL parametro inválido: " & ListaDeValores(I + 1), S.ToString)
						Return S.ToString
				End Select
				S.Append(ListaDeValores(I) & "=" & Resp & ",")
			Next

		Catch ex As Exception
			MostrarError("Ppal", "ArmeSQL", S.ToString & DMScr(2) & ex.Message & EsIngles())
		End Try

		Return Strings.Left(S.ToString, S.ToString.Length - 1) & DMScr()


	End Function
	Public Function Mostrar_Tamaño_Bytes_Megas(TamañoBytes) As String
		Dim Tex As String

		If TamañoBytes >= 1073741824 Then
			Tex = (ValD(TamañoBytes) / 1073741824).ToString("#.#") & " GB"
		ElseIf TamañoBytes >= 1048576 Then
			Tex = (ValD(TamañoBytes) / 1048576).ToString("#.#") & " MB"
		ElseIf TamañoBytes >= 1024 Then
			Tex = (ValD(TamañoBytes) / 1024).ToString("#.#") & " KB"
		Else
			Tex = ValD(TamañoBytes).ToString("#,0") & " bytes"
		End If

		Return Tex

	End Function

	Public Function Usuario_Vendedor() As Integer
		'jdms 589
		Dim UsuVend1 As Integer = Usuario
		Dim DrV() As DataRow = DtVend.Select("id=" & Usuario & " and id_vend is not null")
		If DrV.Length > 0 Then
			UsuVend1 = DrV(0)("id_vend")
		End If
		Return UsuVend1

	End Function

	''' <summary>
	''' Parte el texto en el tamaño especificado y le agrega [...] en caso de que haya más texto
	''' </summary>
	''' <param name="Texto_a_Partir">Texto que desea partir</param>
	''' <param name="Tamaño">Primero n caracteres que desea devolver</param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function Partir_Texto(Texto_a_Partir As String, Tamaño As Integer) As String
		Try
			Dim Result As String = Strings.Left(Texto_a_Partir, Tamaño)
			If Result <> Texto_a_Partir Then
				Result += " [...]"
			End If
			Return Result
		Catch
			Return Texto_a_Partir
		End Try

	End Function


	Public Function Buscar_Modelo_Ano(IncluirVIN As Boolean) As String
		Try

			If fBusV Is Nothing Then
				fBusV = New fBusVeh
			End If

			fBusV.ChkBuscarVIN.Checked = IncluirVIN
			fBusV.GrdSeriales.Tag = ""
			fBusV.MinimizeBox = False
			fBusV.MaximizeBox = True
			fBusV.ShowDialog()

			Return fBusV.GrdSeriales.Tag


		Catch ex As Exception
			Mensaje("Ya tiene abierta la ventana de búsqueda.")

			Return ""

		End Try
	End Function


	Public Function Es_Punto_Advance() As Boolean
		'ya no se usa, quitarla cunado la borre de todos los instances
		Return False

		'Try
		'    'esto solo es para cuando hacen clic en el PuntoAdvance, venga al exe que corresponda y abra la forma activa
		'    Dim Pto As String = ValD(GetSetting("DMS S.A.", "syscom", "ptoadv", 0))
		'    If ValD(Pto) > 0 Then 'punto advance
		'        Abrir_Punto_Advance(Pto:=Pto)
		'        Return True
		'    End If
		'Catch
		'End Try

		'Return False

	End Function
	Public Sub ApagarCajas(Prog As String, TxtCaja As Object, TxtUnds As Object)
		TxtCaja.Enabled = ReglaDeNegocio(150, Prog, "0") <> "1"
		TxtUnds.Enabled = ReglaDeNegocio(150, Prog, "0") <> "1"

	End Sub
	Public Function DMSColor(Col1, Col2, Col3)
		Return System.Drawing.Color.FromArgb(CType(CType(Col1, Byte), Integer), CType(CType(Col2, Byte), Integer), CType(CType(Col3, Byte), Integer))


	End Function

	Public Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
		If Char.IsNumber(e.KeyChar) Then
			e.Handled = False
		ElseIf Char.IsControl(e.KeyChar) Then
			e.Handled = False
		ElseIf Char.IsPunctuation(e.KeyChar) Then
			e.Handled = False
		Else
			Mensaje("Este campo espera un dato de tipo numérico")
			e.Handled = True
		End If
	End Sub

	Public Sub Redondear_Foto(Sender As Object, Optional Porcentaje As Short = 20)
		'creamos un objeto de la clase GraphicsPath
		Dim figura As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath
		'manipulando las variables que se corresponden con los puntos x e y, el ancho y el alto de la figura, podemos variar su aspecto
		Dim x, y, ancho, alto As Integer
		'anchura y altura de la figura (círculo en este caso)
		Dim Porce = 1 - Porcentaje / 100
		ancho = Sender.Width * Porce
		alto = Sender.Width * Porce
		'posiciones x e y de la figura (centrada en el control PictureBox)
		x = (Sender.Width - ancho) / 2
		y = (Sender.Height - alto) / 2
		'usamos el método AddEllipse para conseguir la figura de un círculo,
		'que aplicaremos sobre el control PictureBox.
		figura.AddEllipse(New Rectangle(x, y, ancho, alto))
		'en el control PictureBox creamos una región que se corresponde
		'con la figura del objeto GraphicsPath
		Sender.Region = New Region(figura)

	End Sub

	''' <summary>
	''' Limpia código de items y cosas asi para que no lleven caracteres raros como por ejemplo CR, LF, ETC
	''' </summary>
	''' <param name="Codigo_a_Limpiar"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function Limpiar_Codigo(Codigo_a_Limpiar As String) As String
		Dim CodLimpio As String = ""
		For I As Integer = 1 To Codigo_a_Limpiar.Length
			If Asc(Strings.Mid(Codigo_a_Limpiar, I, 1)) >= 32 Then
				CodLimpio += Strings.Mid(Codigo_a_Limpiar, I, 1)
			End If
		Next
		Return CodLimpio

	End Function
	Public Function InventarioEstricto(Optional VerMensaje As Boolean = True) As Boolean
		If ReglaDeNegocio(120, "estricto", "0") = "1" Then
			If VerMensaje Then
				Mensaje("Según la Rn#120 'estricto', el inventario se maneja estrictamente en cuanto a fechas y modificaciones")
			End If
			Return True
		Else
			Return False
		End If


	End Function
	''' <summary>
	''' Muestra pantalla para preguntar si guardar, no guardar o cancelar
	''' </summary>
	''' <param name="TextoPregunta"></param>
	''' <returns>1=guarda 2=no guarda 3=cancelar</returns>
	''' <remarks></remarks>
	Public Function PregunteGuardarCancelar(TextoPregunta As String, Optional TituloVentana As String = "Advance") As Short
		If fGuarCancel Is Nothing Then
			fGuarCancel = New fGuardarCancelar
		End If

		fGuarCancel.LblPregunta.Text = Idi(TextoPregunta)
		fGuarCancel.Text = Idi(TituloVentana)
		fGuarCancel.ShowDialog()

		Return CShort(ValD(fGuarCancel.Tag))


	End Function
	Public Function NoLicenciaUsuario() As Boolean
		Try

			If GetSett("ctrl", "tl", "2") = "2" Then
				Mensaje("Su licencia de Advance es para 'Consultas'. Se requiere licencia 'Full User' para ingresar a este programa")
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			Return False

		End Try


	End Function
	Public Function SoyAdministradorNodoVehiculos() As Boolean
		'para determinar quien puede crear marcas, lineas, modelos y colores.
		If UsusAdmiVeh <> -1 Then
			GoTo Salir
		End If


		Try
			Dim DtAdminVeh As New DataTable
			SiReloj()
			Abrir(DtAdminVeh, "Select usus=e.respuesta	from reglas_emp e join reglas r on r.id=e.id_reglas where e.id_emp=1 And e.id_reglas=134 and e.llave='usus'")
			NoReloj()

			If Fin(DtAdminVeh) Then
				UsusAdmiVeh = 2
				GoTo Salir
			End If
			Dim Usus As String = "," & Gdf(DtAdminVeh, "usus").ToString.Trim.Replace(" ", "") & ","

			'si es administrador
			If Usus.Contains("," & Usuario.ToString & ",") Then
				UsusAdmiVeh = 1
				GoTo Salir
			Else
				UsusAdmiVeh = 0
				GoTo Salir
			End If

		Catch ex As Exception
			NoReloj()
			MostrarError("Ppal", "SoyAdministradorNodoVehiculos", ex.Message)
			Return False

		End Try

Salir:
		If UsusAdmiVeh = 1 Then
			Return True
		ElseIf UsusAdmiVeh = 2 Then
			Mensaje("No hay administrador del nodo para módulo de vehículos para crear tablas maestras (Marcas, Líneas, etc). Crearlo en Rn#134 'usus'")
			Return False
		Else
			Mensaje("Usted no es Administrador del nodo para Vehículos. Rn#134 'usus'")
			Return False
		End If

	End Function
	Public Function ReglaDeNegocio(ByVal NumeroRegla As Integer, Optional ByVal Llave As String = "", Optional ByVal ValorPredeterminado As String = "") As String
		'truco para leer reglas de la empresa 1 nada más
		'Dim Num_Emp As Integer = Numero_Empresa
		'If NumeroRegla < 0 Then
		'    Num_Emp = 1
		'    NumeroRegla = Math.Abs(NumeroRegla)
		'End If

		'significa que está trabajando en el FTP de col, p.e. Helpdesk
		Dim Nodo_Col As Boolean = False
		If NumeroRegla = -180 Then
			Nodo_Col = True
			NumeroRegla = Math.Abs(NumeroRegla)
		End If

		If GetSetting("DMS S.A.", "syscom", "refrn" & NumeroRegla.ToString, "0") = "1" Then 'debe refrescar
			Try
				YaLeyoReglas = False
				DtReglas.Rows.Clear()
				SaveSetting("DMS S.A.", "syscom", "refrn" & NumeroRegla.ToString, "")
			Catch
			End Try
		End If


		If Not YaLeyoReglas And DtReglas.Rows.Count = 0 Then
			DebugJD("Refrescó reglas")
			Abrir(DtReglas, "GetReglasResp2 " & Numero_Empresa & "," & Usuario.ToString & ",1" & DMScr())
			Dim PrimaryKeyColumns(2) As DataColumn
			PrimaryKeyColumns(0) = DtReglas.Columns("id_reglas")
			PrimaryKeyColumns(1) = DtReglas.Columns("llave")
			DtReglas.PrimaryKey = PrimaryKeyColumns
			YaLeyoReglas = True
		End If

Repita:
		Try
			Dim Dr As DataRow
			Dim KK(1) As Object
			KK(0) = NumeroRegla
			KK(1) = Llave
			Dr = DtReglas.Rows.Find(KK)

			'rutina anterior de reglas cuando no se cargaban todas en memoria: 24-ago-2017
			'If Dr Is Nothing Then 'no tiene valor asignado
			'    KK(1) = "~" 'ver si ya fue leido: este caracter se mete en la llave para indicar que ya fue leida toda esa llave
			'    Dr = DtReglas.Rows.Find(KK)
			'    If Dr Is Nothing Then
			'        Dim dd As New DataTable
			'        'leer toda esta llave
			'        Dim HayReloj = SiRelojCond()

			'        DebugJD("regla:" & NumeroRegla)


			'        If NumeroRegla <> 180 Then 'esta regla sobre el FTP solo se usa en la empresa = 1 de cada nodo
			'            Abrir(dd, "Exec GetReglasRespUna " & Numero_Empresa & "," & NumeroRegla)
			'        Else
			'            If Nodo_Col Then
			'                Abrir_Nodo_1(dd, "Exec GetReglasRespUna " & "1" & "," & NumeroRegla)
			'            Else
			'                Abrir(dd, "Exec GetReglasRespUna " & "1" & "," & NumeroRegla)
			'            End If
			'        End If

			'        DebugJD("Leer RN#" & NumeroRegla)
			'        SiRelojCond(HayReloj)
			'        DtReglas.Rows.Add(NumeroRegla, "~", DBNull.Value, 1)
			'        For Each fi As DataRow In dd.Rows
			'            Try 'por si ya está
			'                'meterla en el datatable
			'                DtReglas.Rows.Add(fi("id_reglas"), fi("llave"), fi("respuesta"), fi("tipo_regla"))
			'            Catch
			'            End Try
			'        Next
			'        GoTo Repita 'volver a intentar
			'    Else
			'        Return ValorPredeterminado
			'    End If
			'End If



			'rutina nueva de reglas cuando se cargan todas en memoria: 24-ago-2017
			If Dr Is Nothing Then 'no tiene valor asignado
				If NumeroRegla = 180 Then
					KK(1) = "~" 'ver si ya fue leido: este caracter se mete en la llave para indicar que ya fue leida toda esa llave
					Dr = DtReglas.Rows.Find(KK)
					If Dr Is Nothing Then
						Dim dd As New DataTable
						'leer toda esta llave
						Dim HayReloj = SiRelojCond()

						DebugJD("regla:" & NumeroRegla)


						If Nodo_Col Then
							Abrir_Nodo_1(dd, "Exec GetReglasRespUna " & "1" & "," & NumeroRegla)
						Else
							Abrir(dd, "Exec GetReglasRespUna " & "1" & "," & NumeroRegla)
						End If

						DebugJD("Leer RN#" & NumeroRegla)
						SiRelojCond(HayReloj)
						DtReglas.Rows.Add(NumeroRegla, "~", DBNull.Value, 1)
						For Each fi As DataRow In dd.Rows
							Try 'por si ya está
								'meterla en el datatable
								DtReglas.Rows.Add(fi("id_reglas"), fi("llave"), fi("respuesta"), fi("tipo_regla"))
							Catch
							End Try
						Next
						GoTo Repita 'volver a intentar
					End If
				Else
					Return ValorPredeterminado
				End If
			End If





			Select Case Dr("tipo_regla")
				Case 1 'verdad o falso
					Return ValD(Dr("respuesta")).ToString
				Case 2
					Return "" & Dr("respuesta")
				Case 3 'valor
					Dim VJD As String = "" & Dr("respuesta")
					Dim CC As String = 5 / 2
					If InStr(CC, ",") Then CC = "," Else CC = "."
					VJD = VJD.Replace(".", CC)
					VJD = VJD.Replace(",", CC)
					If IsNumeric(VJD) Then
						Return ValD(VJD).ToString
					Else
						Return "0"
					End If
				Case 4 'fecha
					Return Microsoft.VisualBasic.Strings.Format(CDate(Dr("respuesta")), "yyyy/MM/dd HH:mm")
				Case Else
					Return "" & Dr("respuesta")
			End Select

		Catch ex As Exception
			Return ""

		End Try

	End Function

	Public Sub ReglaDeNegocio_Reset(ByVal NumeroRegla As Integer)
		'truco para leer reglas de la empresa 1 nada más
		'Dim Num_Emp As Integer = Numero_Empresa
		'If NumeroRegla < 0 Then
		'    Num_Emp = 1
		'    NumeroRegla = Math.Abs(NumeroRegla)
		'End If

		'significa que está trabajando en el FTP de col, p.e. Helpdesk
		Try
			DtReglas = Filtrar_DataTable(DtReglas, "id_reglas<>" & NumeroRegla)

			'Dim Dr As DataRow
			'Dim KK(1) As Object
			'KK(0) = NumeroRegla
			'KK(1) = Llave
			'Dr = DtReglas.Rows.Find(KK)


			'If Dr IsNot Nothing Then 'no tiene valor asignado
			'    Dr.Delete()
			'    DtReglas.AcceptChanges()
			'End If

		Catch ex As Exception

		End Try

	End Sub

	Public Function SoyHandHeld()
		Return Screen.PrimaryScreen.WorkingArea.Height < 400 '650 '500

	End Function
	Public Function Verificar_Item_Institucional(TxtCod As TextBox, IdBod1 As Integer, Optional IdBod2 As Integer = 0, Optional MostrarMensaje As Boolean = True) As Boolean
		'agregar "-" al item institucional

		'si no maneja
		If ReglaDeNegocio(119, "bodinst", "") <> "1" Then
			Return True
		End If


		Dim Cb As Integer = IdBod1
		If IdBod1 <> IdBod2 And IdBod2 > 0 Then
			Cb = IdBod2
		End If

		Dim EsInst As Boolean = ValD(Obtenga_Dato(DtBodegas, "id=" & Cb.ToString, "tipo_bodega")) = 1

		If Strings.Right(TxtCod.Text, 1) <> "-" Then
			If EsInst Then
				TxtCod.Text &= "-"
			End If
		Else 'tiene el "-"
			If Not EsInst Then
				If MostrarMensaje Then
					Mensaje("Este item solo puede usarse en bodega institucional")
				End If
				TxtCod.Text = ""
				Return False
			End If
		End If

		Return True

	End Function
	'Public Function TamañoHandHeld() As Size
	'    Return New Size(240, 320)

	'End Function
	''' <summary>
	''' Poner todos los Achores a un objeto
	''' </summary>
	''' <param name="Objeto">Objeto a modificar los anchor, por ejemplo un Grid, o un Panel o un Groupbox</param>
	''' <remarks></remarks>
	Public Sub DmsAnchorTotal(ByRef Objeto As Object)
		Try
			Objeto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				Or System.Windows.Forms.AnchorStyles.Left) _
				Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Catch
		End Try

	End Sub
	Public Sub Desempaquetar(Path_Temp2 As String, Arch As String)
		Try
			'If IsNumeric(Strings.Left(Arch, 1)) Then
			'    Dim Ini As Integer = InStr(Arch, "_")
			'    If Ini > 0 Then
			'        Dim Verif As String = Mid(Arch, Ini + 1).ToString.Replace(".dms.zip", "")
			'        If IO.File.Exists(Verif) Then
			'            Kill(Verif)
			'        End If
			'    End If
			'End If

		Catch ex As Exception
			Mensaje("El archivo ya se encuentra abierto")
			Exit Sub
		End Try

		Try
			Using zip As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(Arch) 'si da error aqui, la locura, trato de abrirlo
				zip.ParallelDeflateThreshold = -1
				Try
					SiReloj()
					For Each Entry As Ionic.Zip.ZipEntry In zip
						Entry.Extract(Path_Temp2, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
					Next
					NoReloj()

				Catch ex As Exception
					NoReloj()

					If ex.Message.Contains("está siendo utilizado") Then
						Mensaje(Idi("Ya tiene abierto este archivo") & " " & Arch & DMScr(2) & Idi("Ciérrelo y vuelva a intentarlo"))
					Else
						Mensaje(Idi("No se logró descomprimir el archivo") & " " & Arch & DMScr(2) & ex.Message & EsIngles())
					End If
					Exit Sub
				End Try

			End Using
		Catch ex As Exception
			Mensaje("Problema con el archivo " & Arch & DMScr(2) & ex.Message & EsIngles())

		End Try

	End Sub
	Public Function Empaquetar(Archivo As String) As String
		'Try
		'    Dim Zip As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile
		'    Zip.AddFile(Archivo, "")

		'    Dim arch As String = Path_Temp & ArchivoSinPath(Archivo) & ".dms.zip"

		'    Try 'borrarlo
		'        Kill(arch)
		'    Catch
		'    End Try

		'    Zip.Save(arch)

		'    'si pasa bien, cambiar el nombre
		'    Return arch

		'Catch ex As Exception
		'    Return Archivo 'no se empaqueta

		'End Try


		Try
			SiReloj()

			'empaquetar
			Dim arch As String = Path_Temp & ArchivoSinPath(Archivo) & ".dms.zip"
			Using zip As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile()
				zip.AddFile(Archivo, "")
				'zip.AddFile("c:\temp\DMSTablas.exe", "")
				zip.Save(arch)
			End Using

			NoReloj()

			'si pasa bien, cambiar el nombre
			Return arch

		Catch ex As Exception
			NoReloj()

			Return Archivo 'no se empaqueta

		End Try


	End Function


	Public Sub VentanaCentrosCostos(ByRef IdDis As Integer, ByRef IdGru As Integer, ByRef IdSub As Integer, ByRef IdCen As Integer, Optional ByRef nIdDis As String = "", Optional ByRef nIdGru As String = "", Optional ByRef nIdSub As String = "", Optional ByRef nIdCen As String = "", Optional ByRef CenInf As String = "", Optional ByRef CenSup As String = "", Optional MostrarRangos As Boolean = False)
		If fBC Is Nothing Then
			fBC = New fBusCen
		End If

		fBC.Label2.Visible = MostrarRangos
		fBC.TxtLibre1.Visible = MostrarRangos
		fBC.TxtLibre2.Visible = MostrarRangos

		'jdms 641: para que no pida rango de centro de costo
		If IdDis = -2 Then
			IdDis = 0
			fBC.Label3.Visible = False
			fBC.CbRango.Visible = False
		End If
		fBC.ShowDialog()

		If fBC.Tag = -1 Then
			IdDis = -1
			Exit Sub
		End If

		IdDis = fBC.IdDis
		IdGru = fBC.IdGru
		IdSub = fBC.IdSub
		IdCen = fBC.IdCen

		nIdDis = fBC.LstDis.Text
		nIdGru = fBC.LstGru.Text
		nIdSub = fBC.LstSub.Text
		nIdCen = fBC.LstCen.Text

		CenInf = ""
		CenSup = ""
		If fBC.CbRango.SelectedIndex > 0 Then 'se le agrega | para indicar sobre quien aplica el rango: distrito, grupo, etc
			CenInf = "|" & fBC.CbRango.SelectedIndex & fBC.TxtLibre1.Text
			CenSup = fBC.TxtLibre2.Text
		End If
	End Sub

	Public Sub Ponga_Columna_Wrap(Grd As DataGridView, NombreColumna As String, Optional Poner As Boolean = True)
		Dim Estilo As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		If Poner Then
			Estilo.WrapMode = System.Windows.Forms.DataGridViewTriState.True
		Else
			Estilo.WrapMode = System.Windows.Forms.DataGridViewTriState.False
		End If
		Grd.Columns(NombreColumna).DefaultCellStyle = Estilo
		Grd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

	End Sub

	Public Sub Mostrar_Saldo_Tercero(IdCli As Object, Optional ByRef Grid As GridDms = Nothing)
		If ValD(IdCli) = 0 Then
			Mensaje("Selecccione Tercero")
			Exit Sub
		End If

		Dim Dt As New DataTable
		Abrir(Dt, "Exec GetCotCarteraClienteSaldoDetalle " & IdCli.ToString)
		If Fin(Dt) Then
			Mensaje("No hay información")
			Exit Sub
		End If

		If Grid Is Nothing Then
			Ventana(Dt, "Estadística", False)
		Else
			Grid.DMSLlene_Grid(Dt)
		End If

	End Sub
	Public Function DatosDesactualizados() As Boolean
		'saber si cambió de día
		If DateAndTime.Year(UltimaActualizacionDatosMemoria) <> DateAndTime.Year(Now) Or DateAndTime.Month(UltimaActualizacionDatosMemoria) <> DateAndTime.Month(Now) Or DateAndTime.Day(UltimaActualizacionDatosMemoria) <> DateAndTime.Day(Now) Then
			UltimaActualizacionDatosMemoria = Now
			Return True
		Else
			Return False
		End If

	End Function
	'Public Function Tercero_Anulado(ByVal BloqueadoAnulado As Object, Optional ByVal MostrarMensaje As Boolean = True) As Integer
	'    If ValD(BloqueadoAnulado) = 2 Then
	'        If MostrarMensaje Then
	'            Mensaje("Tercero se encuentra anulado. No puede ser usado")
	'        End If
	'        Return ValD(BloqueadoAnulado)
	'    Else
	'        Return ValD(BloqueadoAnulado)
	'    End If

	'End Function
	Public Function ObtengaIP() As String
		Return Ws.VerificarIP

	End Function
	Public Function Convierta_Minusculas(ByVal TextoOriginal As String, ByVal NumeroProgramaSubLlave As String) As String
		If TextoOriginal.Length < 2 Then
			Return TextoOriginal
		End If
		If ReglaDeNegocio(91, NumeroProgramaSubLlave, "0") <> "1" Then
			Return TextoOriginal
		End If

		'para evitar que la regla opere
		If Right(TextoOriginal, 1) = "@" Then
			TextoOriginal = Trim(Mid(TextoOriginal, 1, Len(TextoOriginal) - 1))
			Return TextoOriginal
		End If

		'convertir la primera a mayuscula por si acaso
		TextoOriginal = UCase(Mid(TextoOriginal, 1, 1)) & Mid(TextoOriginal, 2)

		'significa que es mayúscula la segunda la letra
		If Asc(Mid(TextoOriginal, 2, 1)) >= 65 And Asc(Mid(TextoOriginal, 2, 1)) <= 90 Then
			Return UCase(Mid(TextoOriginal, 1, 1)) & LCase(Mid(TextoOriginal, 2))
		Else
			Return TextoOriginal
		End If



	End Function
	Public Function OrdenTallerSigueActiva(Id As Integer, Optional MostrarMensaje As Boolean = True) As Boolean
		Dim tex As String = ""

		Try
			SiReloj()

			Dim dt As New DataTable
			Abrir(dt, "GetTalOrdenCliente " & Id)
			NoReloj()
			If Fin(dt) Then
				tex = "No existe orden taller"
			Else
				tex = "" & Gdf(dt, "result")
			End If
		Catch ex As Exception
			NoReloj()
			tex = "No pudo verificar estado de la orden: " & ex.Message & EsIngles()
		End Try

		If tex <> "" Then
			If MostrarMensaje Then
				Mensaje("Orden de Taller: " & Id & DMScr(2) & tex, "No puede continuar")
			End If
			Return False
		Else
			Return True
		End If


	End Function
	Public Function OtroUsuarioModifico(ByVal LblId As Integer,
										ByVal StoredP As String,
										ByVal FechaInicial As Date,
										Optional ByVal NombreFecha As String = "fecha_creacion",
										Optional ByVal ValidarMes As Boolean = True,
										Optional Sw As Integer = -123,
										Optional FechaMesCerrado As Date = Nothing,
										Optional IdBod As Short = 0
										) As Boolean
		Try
			'If LblId = 0 Then
			'    Return False
			'End If
			If Not IsDate(FechaMesCerrado) Then
				FechaMesCerrado = FechaInicial
			End If

			Dim Ds As New DataSet
			Dim DtCtr As New DataTable
			SiReloj()

			'si viene de una cotiza, quitar la validacion de mes
			If Sw = 0 Or Sw = 2 Or Sw = 46 Then
				ValidarMes = False
			End If

			Dim Mess As String = IIf(Sw = -567, 13, Month(FechaMesCerrado))

			'la validación del mes la hace cada stored procedure
			If ValidarMes Then
				Abrir(Ds, "Exec " & StoredP & " " & LblId.ToString & DMScr() &
						  "Exec GetAbrirCerrarMesUno " & Numero_Empresa.ToString & "," &
														Year(FechaMesCerrado).ToString & "," &
														Mess & "," &
														IdBod & "," &
														Sw &
														DMScr() &
						  "Exec GetConDoctoCierre " & Numero_Empresa.ToString & "," & Year(FechaMesCerrado).ToString)
			Else
				If LblId = 0 Then
					NoReloj()
					Return False
				End If
				Abrir(Ds, "Exec " & StoredP & " " & LblId.ToString)
			End If


			DtCtr = Ds.Tables(0).Copy


			NoReloj()
			If Not Fin(DtCtr) Then
				If Gdf(DtCtr, NombreFecha) IsNot System.DBNull.Value Then
					If Gdf(DtCtr, NombreFecha) <> FechaInicial Then
						Mensaje("Esta información no puede ser actualizada, pues fue modificada por otro usuario mientras estaba en esta pantalla. Haga clic en Nuevo o vuelva a cargar los datos")
						Return True
					End If
				End If
			End If

			If ValidarMes Then
				If Ds.Tables(1).Rows.Count > 0 Then 'el mes está cerrado
					Dim Texadi As String = ""
					If IdBod <> 0 Then
						Texadi = ", IdBod: " & IdBod
					End If
					If Sw <> 0 Then
						Texadi = ", SW: " & Sw
					End If
					Mensaje(Idi("El mes") & " " & Mess & " " & Idi("del año") & " " & Year(FechaMesCerrado).ToString & Texadi & " " & Idi("se encuentra cerrado.  No se permiten transacciones" & ". " & Idi("Puede solicitar a su administrador que abra nuevamente este mes (programa 1111) y volver a intentarlo sin necesidad de salir de este programa")))
					Return True
				End If

				If Sw <> -567 Then 'no es docto de cierre
					If Ds.Tables(2).Rows.Count > 0 Then 'el mes está cerrado
						Mensaje(Idi("El año") & " " & Year(FechaMesCerrado).ToString & " " & Idi("se encuentra cerrado.  No se permiten transacciones"))
						Return True
					End If
				End If
			End If


		Catch ex As Exception
			NoReloj()
			MostrarError("Ppal", "OtroUsuarioModifico", ex.Message)
			Return True
		End Try

		Return False

	End Function
	Public Sub Ejecute_Proceso(ByVal NombreProceso As String, Optional ByVal Argumentos As String = "")
		Dim Pro As New Process
		Pro.StartInfo.FileName = NombreProceso
		If Argumentos <> "" Then
			Pro.StartInfo.Arguments = Argumentos
		End If
		Pro.Start()

	End Sub
	Public Function Control_Modificacion_Docto(Tabla As String,
											   Id As String,
											   FechaCreacion As DateTime,
											   Optional sw As String = "",
											   Optional Mes13 As Boolean = False,
											   Optional FechaMesCerrado As String = "",
											   Optional IdBod As Integer = 0,
											   Optional HayItemInv As String = "" 'SGQ-640: validar cierre especial
											   ) As String
		'pasar a ppal
		If ValD(Id) = 0 And FechaMesCerrado = "" Then Return ""

		Return ArmeSQL("Exec GetCotControlModifico",
					   Numero_Empresa, qqNum,
					   Tabla, qqTex,
					   Id, qqNum,
					   FechaCreacion, qqFeh,
					   sw, qqNum,
					   Mes13, qqBol,
					   FechaMesCerrado, qqTex,
					   IdBod, qqNum,
					   HayItemInv, qqTex 'SGQ-640: validar cierre especial
					   ) & DMScr()

	End Function
	Public Function Ver_Error_Raise(TextoError As String, Optional VerMensaje As Boolean = True) As String
		Dim tex As String = ""
		If TextoError.Contains("***/") Then
			Try
				Dim Ini As Integer = InStr(TextoError, "***/")
				Dim Fin As Integer = InStr(TextoError, "\***")
				tex = Mid(TextoError, Ini + 5, Fin - Ini - 5)
			Catch ex As Exception
				Return TextoError
			End Try
		ElseIf TextoError.Contains("UNIQUE KEY") Then
			tex = Idi("Está tratando de actualizar una llave duplicada", "You are trying to update a duplicate key")
		ElseIf TextoError.Contains("DELETE") Then
			tex = Idi("Está tratando de eliminar un registro al que se hace referencia en otra tabla. Primero debe eliminar o cambiar la información de la otra tabla y después volver a intentar esta operación.", "You are trying to delete a record that is referenced in another table")
		End If


		If tex <> "" Then
			tex = Idi("Operación no completada por esta razón:", "Operation not completed:") & DMScr(2) & tex
			Try
				If VerMensaje Then
					NoReloj()
					Mensaje(tex, "Operación no completada")
					Return ""
				Else
					Return tex
				End If
			Catch ex As Exception
				Return TextoError
			End Try
		Else
			Return TextoError
		End If

	End Function

	Public Function MesCerrado(ByVal Fecha As Date,
							   Optional ByVal MostrarMensaje As Boolean = True,
							   Optional ByVal IdBod As Integer = 0,
							   Optional ByVal SW As Integer = 0)


		Dim Ano As Integer = Year(Fecha)
		Dim Mes As Integer = Month(Fecha)
		Dim esAnular As Boolean = False
		If DateAndTime.Month(Fecha) = 12 And DateAndTime.Day(Fecha) = 31 And DateAndTime.Hour(Fecha) = 23 And DateAndTime.Minute(Fecha) = 59 Then 'es cierre de año
			Mes = 13
			If DateAndTime.Second(Fecha) = 58 Then
				esAnular = True
			End If
		End If
		Try
			'esto por obligación se hace en línea: I'm sorry, JD
			Dim Dt As New DataSet
			SiReloj()
			Abrir(Dt, "exec GetAbrirCerrarMesUno " & Numero_Empresa.ToString & "," &
				  Ano.ToString & "," &
				  Mes.ToString & "," &
				  IdBod & "," &
				  SW &
				  DMScr() &
				  IIf(esAnular, "select top 0 1", "exec GetConDoctoCierre " & Numero_Empresa.ToString & "," & Ano.ToString))
			NoReloj()

			If Not Fin(Dt.Tables(1)) Then
				If MostrarMensaje Then
					Mensaje(Idi("El año") & " " & Year(Fecha).ToString & " " & Idi("se encuentra cerrado.  No se permiten transacciones"))
				End If
				Return True
			End If

			If Fin(Dt.Tables(0)) Then
				Return False
			Else
				If MostrarMensaje Then
					Mensaje(Idi("El mes") & " " & Month(Fecha).ToString & " " & Idi("del año") & " " & Year(Fecha).ToString & " " & Idi("se encuentra cerrado.  No se permiten transacciones") & ". " & Idi("Puede solicitar a su administrador que abra nuevamente este mes (programa 1111) y volver a intentarlo sin necesidad de salir de este programa"))
				End If
				Return True
			End If

		Catch ex As Exception
			NoReloj()
			Mensaje("No se pudo evaluar si el mes está o no cerrado: " & ex.Message & EsIngles())
			Return True
		End Try

	End Function
	'Public Function MesCerradoResult(ByVal Dt As DataTable, Optional MostrarMsg As Boolean = True) As Boolean
	'    'esto por obligación se hace en línea: I'm sorry, JD
	'    If Dt.Rows.Count = 1 And Dt.Columns(0).ColumnName = "result" Then
	'        SonarWAV("error")
	'        If MostrarMsg Then
	'            Mensaje(Gdf(Dt, "result"))
	'        End If
	'        Return True
	'    Else
	'        Return False
	'    End If

	'End Function
	Public Function BuscarProyectos() As String
		Static Texto As String = ""
		Texto = Trim(SinComillas(Inputbox2("Texto opcional a buscar dentro de Empresa, Nombre del proyecto, Descripción o Creador:", , Texto)))

		Dim Sql As String = "Exec GetProyectosBuscar " &
						Numero_Empresa.ToString & "," &
						"'" & Texto & "'"

		Try
			SiReloj()
			Dim Dt As New DataTable
			Abrir(Dt, Sql)
			NoReloj()

			Return Ventana(Dt, "Seleccione el Proyecto", True, "id", New Object() {"id_usuario_crea", "id_emp", "id_emp_cli", "id_usuario_responsable", "id_categoria", "id_proyectos_cla", "id_proyectos_status"})

		Catch ex As Exception
			Mensaje(ex.Message)
			NoReloj()
			Return ""
		End Try

		'

	End Function
	Public Function BuscarCuentaContable(Optional ByVal Inicio As String = "",
										 Optional ByVal SoloAceptarAfectables As Boolean = True,
										 Optional ByRef IdCuenta As Integer = 0,
										 Optional ByRef DescripcionCuenta As String = "") As String

		Dim es1101 As Boolean = False
		If Inicio.StartsWith("@") Then
			es1101 = True
			Inicio = Strings.Mid(Inicio, 2)
		End If

		Try
			If DtCtaAfe.Rows.Count = 0 Or es1101 Then
				SiReloj()
				Abrir(DtCtaAfe, "Exec GetConCuentasVentana " & Numero_Empresa.ToString & ",''," & IIf(es1101, 1, 0))
				NoReloj()
			End If

			If Inicio = "" Then
				Inicio = Inputbox2("Cuentas que empiecen por (0=Todas)?").Trim()
				If Inicio = "" Then
					Return ""
				End If
				If Inicio = "0" Then Inicio = ""
			End If

			Dim DtTemp As New DataTable
			If Inicio <> "" Then
				DtTemp = Filtrar_DataTable(DtCtaAfe, "codigo like '" & Inicio & "%'" & IIf(es1101, "", " and anulada is null"))
			Else
				DtTemp = Filtrar_DataTable(DtCtaAfe, IIf(es1101, "", "anulada is null"))
			End If

			If Fin(DtTemp) Then
				Mensaje("No encontró cuentas")
				Return ""
			End If

			Dim Cuenta As String = ""
			If DtTemp.Rows.Count > 1 Then 'solo si hay más de uno
				Cuenta = Ventana(DtTemp, "Cuenta", True, "codigo")
				If Cuenta = "" Then
					Return ""
				End If
			Else
				Cuenta = Gdf(DtTemp, "codigo")
			End If

			Dim Dt As DataTable = Filtrar_DataTable(DtCtaAfe, "codigo='" & Cuenta & "'")
			If SoloAceptarAfectables Then
				If "" & Gdf(Dt, "afe") <> "S" Then
					Mensaje("Cuenta NO es afectable")
					Return ""
				End If
			End If
			IdCuenta = ValD(Gdf(Dt, "id"))
			DescripcionCuenta = "" & Gdf(Dt, "descripcion")

			Return Cuenta

		Catch ex As Exception
			NoReloj()
			MostrarError("Ppal", "BuscarCuentaContable", ex.Message)
			Return ""
		End Try

	End Function
	Private Function pongalaotra() As String
		Asignar_Paths(Path_Prog, Path_Temp, DesdeFuente)

		Dim xasaa As String = "500"

		Return ValD(xasaa) + 45

	End Function
	Public Sub Ejecute_Impresora(ByVal NombreProceso As String)
		Try
			With New Process
				.StartInfo.Verb = "print"
				.StartInfo.CreateNoWindow = True
				.StartInfo.FileName = NombreProceso
				.Start()
				Try
					.WaitForExit(10000)
					.CloseMainWindow()
					.Close()
				Catch ex As Exception
				End Try

			End With

		Catch ex As Exception
			Mensaje_TopMost("No se pudo imprimir archivo " & NombreProceso & DMScr(2) & ex.Message & EsIngles())

		End Try

	End Sub
	Public Sub Titulos_Pantalla(ByVal Formita As Form, ByVal Programa1 As String)
		Try
			Dim Programa As String = Programa1
			Dim Prefijo As String = ""
			If InStr(Programa1, "|") > 0 Then
				Dim pp() As String = Programa1.Split("|")
				Programa = pp(0)
				Prefijo = LCase(pp(1)) & "_"
			End If

			Dim picPunto As PictureBox
			Try
				picPunto = DirectCast(Formita.Controls.Find("PicPuntoAdv", True)(0), PictureBox)
				picPunto.Tag = Prefijo

			Catch ex As Exception
			End Try

			If Fin(DtTitPantalla) Then
				Exit Sub
			End If

			Dim Dt As DataTable = Filtrar_DataTable(DtTitPantalla, "codigo='" & Programa & "'" & IIf(Prefijo <> "", " and campo like '" & Prefijo & "%'", ""))

			If Not Fin(Dt) Then
				Try
					picPunto.Image = fImg.ImageList1.Images(12)
				Catch ex As Exception

				End Try
			End If
			'UltProgramaPers = Programa1


			'poner la forma de advance
			Dim fAdv As AdvanceForm = DirectCast(Formita, AdvanceForm)

			For Each Fi As DataRow In Dt.Rows


				Try
					Dim Nombre_Campo As String = Fi("campo")
					If Prefijo <> "" Then
						Nombre_Campo = Nombre_Campo.Replace(Prefijo, "")
					End If

					Dim ctrls() As Control = Formita.Controls.Find(Nombre_Campo, True)
					If ctrls.Length = 0 Then
						Continue For
					End If

					If Fi("ocultar") IsNot DBNull.Value Then
						Try
							'para quitar un TAB
							If TypeOf ctrls(0) Is TabPage Then
								Dim Tabcontrolito As TabPage = DirectCast(Formita.Controls.Find(ctrls(0).Name, True)(0), TabPage)
								'Tabcito.TabPages.Remove(ctrls(0))
								'nueva forma de esconder el TAB, no se como volverlos a mostrar pero no lo necesito
								Dim TBC As TabControl
								TBC = ctrls(0).Parent
								Tabcontrolito.Parent = Nothing
								'Tabcontrolito.Parent = TBC

							Else
								ctrls(0).Visible = False
								ctrls(0).Left = -5000 'por si el programa lo prende
							End If
						Catch exjd As Exception
						End Try
					Else
						If TypeOf ctrls(0) Is BotonActualizar Then
							'Dim Controlito As BotonActualizar = DirectCast(Formita.Controls.Find(ctrls(0).Name, True)(0), BotonActualizar)
							'Controlito.DMSText = Fi("titulo")
							Dim btt As BotonActualizar
							btt = ctrls(0)
							btt.CmdActualizar.Text = Fi("titulo")
							ctrls(0) = btt
						Else
							If Fi("titulo") IsNot DBNull.Value Then
								ctrls(0).Text = Fi("titulo")
							End If
						End If

						Try
							If Fi("tooltip_adv") IsNot DBNull.Value Then
								fAdv.ToolTipAdvance.SetToolTip(ctrls(0), Fi("tooltip_adv"))
							End If
						Catch
						End Try
						'fAdv.ToolTipAdvance.GetToolTip(ctrls(0))

						'localización y tamaño
						Try
							If Fi("posx") IsNot DBNull.Value Then
								ctrls(0).Left = Fi("posx")
							End If
							If Fi("posy") IsNot DBNull.Value Then
								ctrls(0).Top = Fi("posy")
							End If
							If Fi("tamx") IsNot DBNull.Value Then
								ctrls(0).Width = Fi("tamx")
							End If
							If Fi("tamy") IsNot DBNull.Value Then
								ctrls(0).Height = Fi("tamy")
							End If

							'fuente y color
							If Fi("fore_color") IsNot DBNull.Value Then
								Try
									If TypeOf ctrls(0) Is LinkLabel Then
										Dim Lincito As LinkLabel = DirectCast(Formita.Controls.Find(ctrls(0).Name, True)(0), LinkLabel)
										Lincito.LinkColor = System.Drawing.ColorTranslator.FromOle(Fi("fore_color"))
									Else
										ctrls(0).ForeColor = System.Drawing.ColorTranslator.FromOle(Fi("fore_color"))
									End If
								Catch ex As Exception
								End Try
							End If
							If Fi("back_color") IsNot DBNull.Value Then
								Try
									ctrls(0).BackColor = System.Drawing.ColorTranslator.FromOle(Fi("back_color"))
								Catch ex As Exception
								End Try
							End If
							If Fi("font_name") IsNot DBNull.Value Then
								Try
									ctrls(0).Font = VB6.FontChangeName(ctrls(0).Font, Fi("font_name"))
								Catch ex As Exception
								End Try
							End If
							If Fi("font_size") IsNot DBNull.Value Then
								Try
									ctrls(0).Font = VB6.FontChangeSize(ctrls(0).Font, Fi("font_size"))
								Catch ex As Exception
								End Try
							End If
							If Fi("font_bold") IsNot DBNull.Value Then
								Try
									ctrls(0).Font = VB6.FontChangeBold(ctrls(0).Font, IIf(Fi("font_bold") = 1, True, False))
								Catch ex As Exception
								End Try
							End If
							If Fi("font_italic") IsNot DBNull.Value Then
								Try
									ctrls(0).Font = VB6.FontChangeItalic(ctrls(0).Font, IIf(Fi("font_italic") = 1, True, False))
								Catch ex As Exception
								End Try
							End If



						Catch ex As Exception
						End Try

					End If

					'Dim Lbl1 As Label = DirectCast(Formita.Controls.Find(Gdf(Dt, I, "campo"), True)(0), Label)
					'If Lbl1 IsNot Nothing Then
					'    Lbl1.Text = Gdf(Dt, I, "titulo")
					'    Continue For
					'End If

					'Dim LNk1 As LinkLabel = DirectCast(Formita.Controls.Find(Gdf(Dt, I, "campo"), True)(0), LinkLabel)
					'If LNk1 IsNot Nothing Then
					'    LNk1.Text = Gdf(Dt, I, "titulo")
					'    Continue For
					'End If

				Catch ex As Exception
					'este error no lo vamos a mostrar para que pueda programar campos que estén en formas llamadas desde el mismo programa: ejemplo: LogicaSync
					'Mensaje_TopMost("Atención: Informe al Administrador del Sistema que el Label " & Gdf(Dt, I, "campo") & " no se encuentra en este programa", EnviarDMS:=True)

				End Try

			Next


		Catch ex As Exception

		End Try


		'ahora poner el idioma
		'Recorrer_Controles_Idi(Formita, Formita)

	End Sub
	Public Sub Recorrer_Controles_Idioma(ByVal Control1 As Object, fOrig As Object)

		If LenguajeAdvance <> 1 Then
			Exit Sub
		End If

		Asigne_ClIdi()
		ClIdioma.Recorrer_Idioma_Clase(Control1, fOrig)

	End Sub
	Private Sub Asigne_ClIdi()
		If ClIdioma Is Nothing Then
			ClIdioma = New ClaseIdioma
		End If

	End Sub
	'Public Function Idi(TextoEspañol As String, Optional TextoIngles As String = "") As String
	'	If LenguajeAdvance <> 1 Or TextoEspañol = "" Then 'And FaltaTraducir Then
	'		Return TextoEspañol
	'	End If

	'	Asigne_ClIdi()

	'	Return ClIdioma.Convierta_Idi(TextoEspañol, TextoIngles)


	'End Function

	Public Function Idi(TextoEspañol As String, Optional TextoIngles As String = "") As String
		If LenguajeAdvance <> 1 Or TextoEspañol = "" Then 'And FaltaTraducir Then
			Return TextoEspañol
		End If
		If DtIdioma Is Nothing And TextoIngles = "" Then
			Return TextoEspañol
		End If

		Asigne_ClIdi()

		Return ClIdioma.Convierta_Idioma(TextoEspañol, TextoIngles)


	End Function
	Public Sub Montar_Idi(Dt As DataTable)
		Asigne_ClIdi()

		ClIdioma.Montar_Idioma_Clase(Dt)



	End Sub
	Public Sub Recorrer_Controles_ContextMenuStrip(ByVal Control1 As Object)

		If LenguajeAdvance <> 1 Then
			Exit Sub
		End If
		Asigne_ClIdi()

		ClIdioma.Recorrer_MenuContextual(Control1)

	End Sub
	'Public Sub Recorrer_Controles_ToolStrip(ByVal Control1 As Object)

	'	If LenguajeAdvance <> 1 Then
	'		Exit Sub
	'	End If

	'	Asigne_ClIdi()

	'	ClIdioma.Recorrer_MenuContextual(Control1)
	'	'ClIdioma.Recorrer_Submenu(Control1)

	'End Sub

	Public Sub Recorrer_Controles_ToolStrip(ByVal oSubmenuItems As Windows.Forms.ToolStrip)
		If LenguajeAdvance <> 1 Then
			Exit Sub
		End If

		Asigne_ClIdi()

		ClIdioma.Recorrer_ToolStrip(oSubmenuItems)

	End Sub
































	Public Sub Traiga_Datos_Menos_Importantes(Optional ByVal Refrescar As Boolean = False)
		Try
			Dim Dsu As New DataSet
			If DMS_XML_Leer_DataSet(Dsu, "noimportantes", 0) = False Or Refrescar Then
				Abrir(Dsu, "Exec GetProgramasPermisos " & LenguajeAdvance)
				DMS_XML_Escribir_DataSet(Dsu, "noimportantes", 0)
			End If

			DtProgPerm = Dsu.Tables(0).Copy 'tabla con nombres de programas y permisos

		Catch ex As Exception
			MostrarError("Ppal", "Traiga_Datos_Menos_Importantes", ex.Message)

		End Try

	End Sub
	Public Function VABS(ByVal Valor)
		If ValD(Valor) < 0 Then
			Return ValD(Valor) * -1
		Else
			Return ValD(Valor)
		End If
	End Function

	Public Sub Mensaje_ReglaNegocio(ByVal NumeroRegla As Integer, ByVal DescripcionDelProblema As String, Optional ByVal Titulo As String = "", Optional ByVal Llave As String = "")
		Mensaje_TopMost("""" & DescripcionDelProblema & """" & DMScr(2) & "Para hacer esta función, debe solicitar a su administrador del sistema que cambié el valor de la Regla de Negocio #" & NumeroRegla.ToString & IIf(Llave <> " en la llave '" & Llave & "'", "", ""), Titulo)

	End Sub


	Public Function Llamar_Maestro_Cod_Des(ByVal Prog As String,
							   ByRef Dt As DataTable,
							   ByVal StorePut As String,
							   ByVal StoreDel As String,
							   ByVal Titulo_Maestro As String,
							   ByVal MaxLenCod As Integer,
							   ByVal MaxLenDes As Integer,
							   ByVal TitCod As String,
							   ByVal TitDes As String,
							   ByVal NomCampoDtCod As String,
							   ByVal NomCampoDtDes As String,
							   ByVal VentanaModal As Boolean,
							   ByVal CodNumerico As Boolean,
							   Optional ByVal ID_padre As Integer = 0,
							   Optional ByVal NomCampoDtIdPadre As String = "") As Boolean
		Try

			Dim FMaes2 As New fMaestroCod_Des
			FMaes2.DMSProcPut = StorePut
			FMaes2.DMSProcDel = StoreDel
			FMaes2.DMSMaxCod = MaxLenCod
			FMaes2.DMSMaxDes = MaxLenDes
			FMaes2.DMSTitCod = TitCod
			FMaes2.DMSTitDes = TitDes

			FMaes2.DMSNomCampoCod = NomCampoDtCod
			FMaes2.DMSNomCampoDes = NomCampoDtDes
			FMaes2.DMSNomCampoIdPadre = NomCampoDtIdPadre

			FMaes2.DMSSoyNumerico = CodNumerico
			FMaes2.DMSIDPadre = ID_padre
			FMaes2.DMSAsignarDT = Dt.Copy

			FMaes2.Text = TituloForma(Prog) & " " & Titulo_Maestro
			Llamar_Maestro_Cod_Des = False
			If VentanaModal Then
				FMaes2.ShowDialog()
				If ValD(FMaes2.Tag) = 1 Then
					Llamar_Maestro_Cod_Des = True
				End If
			Else
				FMaes2.Show()
			End If

		Catch ex As Exception
			Mensajeria_DMS(99, "Llamar_Maestro2" & ex.Message & EsIngles(), Usuario)

		End Try
	End Function
	Public Sub Llamar_Maestro(ByRef Formas As FormCollection,
						  ByVal Prog As String, ByVal Combo As ComboBox, ByRef Dt As DataTable,
						  ByVal StorePut As String,
						  ByVal StoreDel As String,
						  ByVal Nom_maestro As String,
						  Optional ByVal Esnumerico As Boolean = False,
						  Optional ByVal NombreCampo As String = "descripcion",
						  Optional ByVal MostrarCb As Boolean = False,
						  Optional ByVal IDCb As Integer = 0,
						  Optional ByVal CampoIdFiltro As String = "",
						  Optional ByVal CampoIdOri As String = "",
						  Optional ByVal CampoDesOri As String = "",
						  Optional ByVal TamañoDes As Integer = 50)
		Try

			'truco para poder poner un título a esta ventana
			Dim TituloVentana As String = ""
			If Prog.Contains("|") Then
				Try
					Dim spl() As String = Prog.Split("|")
					Prog = spl(0)
					TituloVentana = spl(1)
				Catch
				End Try
			End If
			'/truco para poder poner un título a esta ventana


			'ActualizoMaestro = False
			If FormaYaEstaAbierta3(Formas, fSpl.Icon, "fMaestro", Prog) Then Exit Sub


			Dim FMaes As New fMaestro
			FMaes.Tag = Prog
			FMaes.txtDescripcion.MaxLength = TamañoDes

			FMaes.IdCb = IDCb
			FMaes.NoMuestro = MostrarCb
			For i As Integer = 0 To Combo.Items.Count - 1
				FMaes.CbPadre.Items.Add(Combo.Items(i))
			Next

			Dim Array As New ArrayList

			For i As Integer = 0 To Dt.Rows.Count - 1
				Array.Add(New DataDescription(Dt.Rows(i).Item(0), Dt.Rows(i).Item(1)))
			Next
			FMaes.CampoIdFiltro = CampoIdFiltro
			FMaes.CampoIdOri = CampoIdOri
			FMaes.CampoDesOri = CampoDesOri
			FMaes.dtOriginal = Dt
			FMaes.EsNumerico = Esnumerico

			FMaes.NombreCampo = NombreCampo
			FMaes.array = Array
			FMaes.StorePut = StorePut
			FMaes.StoreDel = StoreDel

			If TituloVentana <> "" Then
				FMaes.Text = TituloVentana
			Else
				FMaes.Text = TituloForma(Prog) '  & " " & Nom_maestro
			End If

			If Prog = "2001" Then
				MostrarForma3(FMaes.Icon, FMaes, True)
			Else
				MostrarForma3(FMaes.Icon, FMaes, , Prog)
			End If

			'FMaes.Show()
			'If ActualizoMaestro Then Dt.Rows.Clear()

		Catch ex As Exception
			Mensajeria_DMS(99, "Llamar_Maestro " & ex.Message & EsIngles(), Usuario)

		End Try
	End Sub
	'Public Sub Mensaje(ByVal TextoMensaje As String, Optional ByVal Titulo As String = "")
	'    If Titulo = "" Then
	'        Titulo = "Advance" ' My.Application.Info.Title
	'    End If

	'    MsgBox(TextoMensaje, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, Titulo)

	'End Sub
	'Public Function Mensaje_TopMost(ByVal TextoMensaje As String, Optional ByVal Titulo As String = "", Optional ByVal BotonReiniciar As Boolean = False) As String
	'    If Titulo = "" Then
	'        Titulo = My.Application.Info.Title
	'    End If

	'    Try
	'        Dim fMen As New fMensaje
	'        fMen.ShowIcon = False
	'        fMen.CmdReiniciar.Visible = BotonReiniciar
	'        fMen.Txt.Text = TextoMensaje
	'        fMen.Text = Titulo
	'        fMen.ShowDialog()
	'        Return fMen.Tag

	'    Catch ex As Exception
	'        Mensaje(TextoMensaje)
	'        Return ""
	'    End Try

	'End Function
	Public Sub Buscar_En_CheckedListBox(ByRef Lst As CheckedListBox)
		Try
			Dim fRes As New fResultBuscar2
			fRes.TopMost = True
			fRes.Lst = Lst

			fRes.ShowDialog()

			If ValD(fRes.Tag) > 0 Then
				For I = 0 To Lst.Items.Count - 1
					If TraerId(Lst, I) = ValD(fRes.Tag) Then
						Lst.SetItemChecked(I, True)
						Lst.SelectedIndex = I
						Exit For
					End If
				Next
			End If


		Catch ex As Exception
			Mensaje("Error buscando")

		End Try

	End Sub
	Public Sub Buscar_En_ListBox(ByRef Lst As ListBox)
		Try
			Dim fRes As New fResultBuscar2
			fRes.TopMost = True
			fRes.Lst = Lst

			fRes.ShowDialog()

			If ValD(fRes.Tag) > 0 Then
				For I = 0 To Lst.Items.Count - 1
					If TraerId(Lst, I) = ValD(fRes.Tag) Then
						Lst.SelectedIndex = I
						Exit For
					End If
				Next
			End If


		Catch ex As Exception
			Mensaje("Error buscando")

		End Try

	End Sub
	'Public Sub Buscar_en_Grid(ByRef Grd As DataGridView)
	'    Try
	'        If Grd.Rows.Count = 0 Then Mensaje("No hay información para hacer la búsqueda") : Exit Sub
	'        Dim Frm As New fResultBuscarGrid
	'        Frm.TopMost = True
	'        Frm.Grd = Grd
	'        Frm.ShowDialog()

	'        If ValD("" & Frm.Tag) > 0 Then
	'            If Not Grd.Rows(Val("" & Frm.Tag)).Displayed Then
	'                Grd.FirstDisplayedScrollingRowIndex = ValD("" & Frm.Tag)
	'            End If
	'            Grd.Rows(Val("" & Frm.Tag)).Selected = True
	'        End If
	'    Catch ex As Exception

	'    End Try


	'End Sub

	'Public Function TituloForma(Optional ByVal Programa As String = "", Optional ByVal Forma As Form = Nothing)

	'    'para cambiar algunos títulos de esta forma
	'    If Forma IsNot Nothing Then
	'        Titulos_Pantalla(Forma, Programa)
	'    End If

	'    Dim Ali As String = GetSett("Conecc", "alias", "")
	'    If Programa = "-1" Then
	'        Return LCase(MiCodigo) & "," & LCase(MiEmpresa) & "," & String_Version_Editada() & "," & IIf(MarcaExterna <> "", IIf(Ali <> "", Ali, MarcaExterna), "")
	'    End If

	'    Dim Nom As String = ""
	'    If Programa <> "" Then
	'        If My.Application.Info.ProductName = "reportes" Then
	'            Nom = " " & GetSetting("DMS S.A.", "NomRep", Programa, "")
	'        Else
	'            Nom = " " & GetSetting("DMS S.A.", "NomProg", Programa, "")
	'        End If
	'    End If

	'    InformacionComplemetariaAplicacion = "(" & LCase(MiCodigo) & "," & LCase(MiEmpresa) & "," & String_Version_Editada() & IIf(MarcaExterna <> "", "," & IIf(Ali <> "", Ali, MarcaExterna), "") & ")"

	'    Dim Resto As String = ""
	'    If Forma IsNot Nothing Then
	'        If Forma.IsMdiChild = False Then
	'            Resto = InformacionComplemetariaAplicacion
	'        End If
	'    End If
	'    Return Programa & IIf(Programa <> "", Nom & " ", "") & IIf(Ws.Url.Contains("_pru/"), " *pru*", "") & Resto


	'End Function
	Public Function TituloForma(Optional ByVal Programa1 As String = "", Optional ByVal Forma As Form = Nothing)
		Dim Programa As String = Programa1
		Dim Prefijo As String = ""
		If InStr(Programa1, "|") > 0 Then
			Dim pp() As String = Programa1.Split("|")
			Programa = pp(0)
			Prefijo = LCase(pp(1)) & "_"
		End If

		'para cambiar algunos títulos de esta forma
		'FormaPersonalizada = False
		'========================================================================================================================================================================
		If Forma IsNot Nothing Then
			Titulos_Pantalla(Forma, Programa1)
		End If
		'========================================================================================================================================================================

		Dim Ali As String = GetSett("Conecc", "alias", "")
		If Programa = "-1" Then
			Return LCase(MiCodigo) & "," & LCase(MiEmpresa) & "," & String_Version_Editada() & "," & IIf(MarcaExterna <> "", IIf(Ali <> "", Ali, MarcaExterna), "")
		End If

		Dim Nom As String = ""
		If Programa <> "" Then
			If My.Application.Info.ProductName = "reportes" Then
				Nom = " " & GetSetting("DMS S.A.", "NomRep", Programa, "")
			Else
				Nom = " " & GetSetting("DMS S.A.", "NomProg", Programa, "")
			End If
		End If

		InformacionComplemetariaAplicacion = "(" & LCase(MiCodigo) & "," & LCase(MiEmpresa) & "," & String_Version_Editada() & IIf(MarcaExterna <> "", "," & IIf(Ali <> "", Ali, MarcaExterna), "") & ")"


		'Dim RestoServi As String = ""
		'If SoyServicio Then
		'    RestoServi = " (" & MiCodigo & "/" & MiEmpresa & "/" & MarcaExterna & IIf(Ws.Url.Contains("_pru/"), " *Pru*", "") & ")"
		'End If

		'no cambiar la parte de personalizada pues se usa en otra parte
		Return Programa & IIf(Programa <> "", Nom, "") & " (" & MiCodigo & "/" & MiEmpresa & "/" & MarcaExterna & IIf(Ws.Url.Contains("_pru/"), " *Pru*", "") & ")" '& IIf(FormaPersonalizada, " (custom)", "")


	End Function


	'Public Enum Sector As Short
	'    General = 0
	'    Automotriz = 1
	'    Farmaceutico = 2
	'    Comercializador = 3
	'    Industria = 4
	'    Hotelero = 5
	'    Pos_Restaurantes = 6
	'    Pos_Generico = 7
	'    Taller_Automotriz = 8
	'    Taller_Generico = 9
	'End Enum

	Public Enum TipoStock As Short
		NoManejaInventario = 0
		AceptaStockNegativos = 1
		ControlaStock = 2
		Estructura = 3
		'ManejaSeriales = 4
	End Enum

#End Region

#Region "Parpadear Ventana"

	Public Const FLASHW_STOP As Integer = &H0
	Public Const FLASHW_CAPTION As Integer = &H1
	Public Const FLASHW_TRAY As Integer = &H2
	Public Const FLASHW_ALL As Integer = (FLASHW_CAPTION Or FLASHW_TRAY)
	Public Const FLASHW_TIMER As Integer = &H4
	Public Const FLASHW_TIMERNOFG As Integer = &HC
	<Runtime.InteropServices.DllImport("user32.dll")> Public Function FlashWindowEx(ByRef pfwi As FLASHWINFO) As Integer
	End Function
	<Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)> Structure FLASHWINFO
		Dim cbSize As Integer
		Dim hwnd As System.IntPtr
		Dim dwFlags As Integer
		Dim uCount As Integer
		Dim dwTimeout As Integer
	End Structure
	''' <summary>
	''' Poner a parpadear una ventana o quitar parpadeo
	''' </summary>
	''' <param name="Forma">Nombre de la Forma de Wondows</param>
	''' <param name="Estilo">0=No parpadear; 1=Parpadear; 2=Dejar fijo</param>
	''' <remarks></remarks>
	Public Sub Parpadear(ByVal Forma As Form, ByVal Estilo As Short)
		Dim FlashInfo As FLASHWINFO
		With FlashInfo
			.cbSize = Convert.ToUInt32(Runtime.InteropServices.Marshal.SizeOf(GetType(FLASHWINFO)))

			If Estilo = 1 Then 'activar
				.dwFlags = CType(FLASHW_ALL Or FLASHW_TIMER, Int32)
				.uCount = 20
			ElseIf Estilo = 2 Then
				.dwFlags = CType(FLASHW_TIMERNOFG, Int32)
			ElseIf Estilo = 0 Then
				.dwFlags = CType(FLASHW_STOP, Int32)
				.uCount = 0
			End If

			.hwnd = Forma.Handle
			.dwTimeout = 0
			'.uCount = 20
		End With
		FlashWindowEx(FlashInfo)

	End Sub
#End Region
	''' <summary>
	''' Abre ventana para buscar una imagen y guardarla (el programa la comprime automáticamente según el máximo tamaño permitido) en la base de datos segun sea el id suministrado y el nombre de la tabla
	''' </summary>
	''' <param name="NombreTabla">Nombre de la tabla donde va a guardar la imagen</param>
	''' <param name="IdRegistro">Número de ID de la fila para guardar imagen</param>
	''' <param name="TamañoMaximo">Tamaño máximo de la imagen que desea permitir guardar</param>
	''' <param name="Alto_y_Ancho">Alto y ancho de la imagen, un buen tamaño es 700</param>
	''' <param name="ImagenInicialParaMostrar">Imagen que debe aparecer en el picture cuando abra la ventana</param>
	''' <param name="Escritura">Permitir cambiar la imagen. False=solo visualizar imagen</param>
	''' <returns>Imagen para volver a mostrar ya actualizada en el programa llamador</returns>
	''' <remarks>By JDMS 8-sep-2008</remarks>
	Public Function AbrirImagen(ByVal NombreTabla As String,
								ByVal IdRegistro As Integer,
								ByVal TamañoMaximo As Integer,
								ByVal Alto_y_Ancho As Integer,
								ByVal ImagenInicialParaMostrar As PictureBox,
								ByVal Escritura As Boolean,
								Optional ByVal TituloVenta As String = "") As Image

		'si es de la tabla usuario, chatear
		If NombreTabla = "usuario" Then
			'por si no han hecho clic en el combo de vendedor
			If ImagenInicialParaMostrar.Tag Is Nothing Then
				Return Nothing
			End If

			Dim Idusu As String = ImagenInicialParaMostrar.Tag.ToString.Replace(MarcaExterna, "")
			Dim usuusu() As String = Idusu.Split("\")
			Idusu = usuusu(usuusu.Length - 1)
			Chatear(ValD(Idusu))
			Return Nothing
		End If
		If NombreTabla = "usuario1" Then
			NombreTabla = "usuario"
		End If

		If Not Escritura Then
			Dim NomFile As String = Path_Temp & "imagen_temp.jpg"
			Try
				Dim Bmp1 As New Bitmap(ImagenInicialParaMostrar.Image)

				Bmp1.Save(NomFile)

				Dim Pro As New Process
				Pro.StartInfo.FileName = NomFile
				Pro.Start()
				Return Nothing
			Catch ex As Exception
				'si sale error que haga sistema viejo
			End Try
		End If

		Dim fCap As New fCapturaImagen

		fCap.TamañoMaximo = TamañoMaximo
		fCap.Alto_y_Ancho = Alto_y_Ancho
		fCap.ToolFoto.Visible = Escritura
		fCap.PictureBox1.Image = ImagenInicialParaMostrar.Image
		fCap.NombreTabla = NombreTabla
		fCap.RecId = IdRegistro


		If TituloVenta <> "" Then fCap.Text = TituloVenta

		'If Not Escritura Then
		'    fCap.WindowState = FormWindowState.Maximized
		'End If

		If Escritura Then
			If Mid(TituloVenta, 1, 1) = "°" Then
				fCap.CmdAbrir.Tag = Mid(TituloVenta, 2)
			Else
				fCap.CmdAbrir.Tag = ""
			End If
			fCap.CmdAbrir_Click(fCap.CmdAbrir, New System.EventArgs)
			'fCap.ShowDialog()
			If fCap IsNot Nothing Then
				ImagenInicialParaMostrar.Image = fCap.PictureBox3.Image
				fCap.Dispose()
				If ImagenInicialParaMostrar.Image IsNot Nothing Then
					If IdRegistro <> Usuario And NombreTabla = "usuario" Then
						Mensajeria_DMS(IdRegistro, "Le informo que he cambiado su foto de Advance", Usuario)
					End If
				End If
			Else
				ImagenInicialParaMostrar.Image = Nothing
			End If


			Return ImagenInicialParaMostrar.Image
		Else
			fCap.Show()
			'fCap.ShowDialog()
			Return Nothing
		End If
	End Function
	''' <summary>
	''' Devuelve el campo Origen (para saber en que tabla está guardado) dependiendo del camp[o SW
	''' </summary>
	''' <param name="Sw">Ingrese el Sw que venga del documento</param>
	''' <returns>Origen al que pertenece</returns>
	Public Function Origen_del_SW(Sw) As Integer
		If EstaEnLista(Sw, 1, -1) Then
			Return 0
		ElseIf EstaEnLista(Sw, 5) Then
			Return 1
		ElseIf EstaEnLista(Sw, 21, 23) Then
			Return 2
		ElseIf EstaEnLista(Sw, 4, -4) Then
			Return 3
		ElseIf EstaEnLista(Sw, 6) Then
			Return 4
		ElseIf EstaEnLista(Sw, 31, 33) Then
			Return 5
		Else
			Return -1
		End If

	End Function
	Public Sub SalvarTamañoForma(ByRef CualForma As Form, Optional Salvar As Boolean = True)
		Try
			If Salvar Then
				If CualForma.WindowState = FormWindowState.Minimized Then
					Exit Sub
				End If
				If CualForma.WindowState = FormWindowState.Maximized Then
					SaveSett(CualForma.Name, "max", 1)
					Exit Sub
				End If

				SaveSett(CualForma.Name, "anc", CualForma.Width)
				SaveSett(CualForma.Name, "alt", CualForma.Height)
				SaveSett(CualForma.Name, "max", 0)
			Else
				CualForma.Width = GetSett(CualForma.Name, "anc", CualForma.Width)
				CualForma.Height = GetSett(CualForma.Name, "alt", CualForma.Height)
				If ValD(GetSett(CualForma.Name, "max", 0)) = 1 Then
					CualForma.WindowState = FormWindowState.Maximized
				End If
			End If

		Catch ex As Exception

		End Try


	End Sub
	''' <summary>
	''' Obtiene la foto del usuario en su última versión
	''' </summary>
	''' <param name="PicUsu">Destino de la foto</param>
	''' <param name="IdUsu">Id del usuario</param>
	''' <param name="Dt9">Datatable que contiene los ids de usuarios y la fecha_hora_cambio_foto</param>
	''' <remarks></remarks>
	Public Sub ObtengaFotoUsuario(ByRef PicUsu As PictureBox, ByVal IdUsu As Integer, ByVal Dt9 As DataTable)
		If IdUsu = 0 Then
			PicUsu.Visible = False
			Exit Sub
		End If
		PicUsu.Visible = True

		Try
			PicUsu.SizeMode = PictureBoxSizeMode.Zoom

			'Dim Fecha As String = "" & Obtenga_Dato(Dt9, "id=" & IdUsu.ToString, "fecha_hora_cambio_foto")


			'If Fecha = "" Then
			'    PicUsu.Image = Nothing
			'Else
			Dim Foto As String
			'Foto = Path_Temp & "f" & IdUsu.ToString & "_" & Strings.Format(CDate(Fecha), "yyyyMMddHHmmss").ToString + ".jpg"
			Foto = Path_Temp & "user\" & MarcaExterna & IdUsu
			If IO.File.Exists(Foto) Then 'la foto está en disco
				'PicUsu.Image = System.Drawing.Image.FromFile(Foto, False)
				PicUsu.Image = AsignarFotoUsuario(Foto)
			Else
				Dim Ima As New DataTable

				SiReloj()

				Abrir(Ima, "GetImagen", IdUsu, "usuario", "imagen")

				NoReloj()

				If Gdf(Ima, 0, "imagen") Is System.DBNull.Value Then
					PicUsu.Image = Nothing
				Else
					'Dim FotoBorrar As String
					'FotoBorrar = Path_Temp & "f" & IdUsu.ToString & "_*.*"
					SalvarFoto(CType(Gdf(Ima, 0, "imagen"), Byte()), Foto, "")
					PicUsu.Image = AsignarFotoUsuario(Foto)
					'If Dir(Foto, FileAttribute.Archive) <> "" Then 'la foto está en disco
					'    PicUsu.Image = System.Drawing.Image.FromFile(Foto, False)
					'End If
				End If
			End If
			PicUsu.Tag = Foto
			'End If

		Catch ex As Exception
			PicUsu.Image = Nothing
			NoReloj()

		End Try

	End Sub
	Public Sub Asigne_Cual_es_Retfte_Retiva()
		CualEsRetFte = ValD(ReglaDeNegocio(3, "retfte", "0"))
		If CualEsRetFte < 1 Or CualEsRetFte > 6 Then
			CualEsRetFte = 1
			'Mensaje("Se usará la retención 1 como Retención fuente. Modifique en Rn#3 'retfte'")
		End If

		CualEsRetIva = ValD(ReglaDeNegocio(3, "retiva", "0"))
		If CualEsRetIva < 1 Or CualEsRetIva > 6 Then
			CualEsRetIva = 3
			'Mensaje("Se usará la retención 3 como Retención IVA. Modifique en Rn#3 'retiva'")
		End If

		CualEsRetIca = ValD(ReglaDeNegocio(3, "retica", "0"))
		If CualEsRetIca < 1 Or CualEsRetIca > 6 Then
			CualEsRetIca = 2
			'Mensaje("Se usará la retención 3 como Retención IVA. Modifique en Rn#3 'retiva'")
		End If


	End Sub


	Public Function AsignarFotoUsuario(Archivo As String) As Image
		Try
			Dim fs As System.IO.FileStream
			fs = New System.IO.FileStream(Archivo, IO.FileMode.Open, IO.FileAccess.Read)
			Dim Img As Image = System.Drawing.Image.FromStream(fs)
			fs.Close()
			Return Img

		Catch ex As Exception
			Return Nothing

		End Try


	End Function

	''' <summary>
	''' Validar si el programa actual está en capacidad de Modificar documentos, según regla de negocio #85 con llave NúmeroPrograma
	''' </summary>
	''' <param name="NumeroDocto">Id del documento. Si es cero no hace la validación</param>
	''' <param name="NumeroPrograma">Programa que está evaluando. e.g. 1106, 1901, etc</param>
	''' <param name="MostrarMensaje">Responda True si desea que muestre el mensaje de negación</param>
	''' <returns>True cuando puede modificar, False cuando no puede modificar</returns>
	''' <remarks>By JDMS 8-sep-2008</remarks>
	Public Function DocumentoNoModificable(ByVal NumeroDocto As Object, ByVal NumeroPrograma As String, Optional ByVal MostrarMensaje As Boolean = True) As Boolean
		If ValD(NumeroDocto) = 0 Then 'cuando es nuevo no validar
			Return False
		End If

		If ReglaDeNegocio(85, NumeroPrograma, "0") = "0" Then
			If MostrarMensaje Then Mensaje(Idi("Este programa no está habilitado para modificar documentos.  Regla de Negocio #85, llave") & " " & NumeroPrograma)
			Return True
		Else
			Return False
		End If

	End Function
	''' <summary>
	''' Enviar un texto para que sea mostrado en la ventana de Debug de Advance cuando esté activada
	''' </summary>
	''' <param name="Texto">Texto que desea mostrar, cualquier cosa que desee reportar desde su programa hacia la ventana de debug especial de advance</param>
	''' <remarks>By JDMS 8-sep-2008</remarks>
	Public Sub DebugJD(ByVal Texto As String)

		If MostrarDebug = "N" Then
			Exit Sub
		ElseIf MostrarDebug = "" Then
			MostrarDebug = GetSett("menu", "dbj", "N")
		End If


		If MostrarDebug <> "S" Then
			Exit Sub
		End If


		Static fDebugJD As New fDebugJD

		Try
			If fDebugJD.Visible = False Then
				fDebugJD.Text = "Debug: " & My.Application.Info.Title
				fDebugJD.Show()
			End If

			If fDebugJD.Filtro <> "" Then
				If Not Texto.Contains(fDebugJD.Filtro) Then
					Exit Sub
				End If
			End If

			'If SoyServicio Or Usuario = 2 Or Usuario = 128 Then 'para que los sql solo se los muestre a jd y a los de servicio
			'    VarJD &= Strings.Format(Now, "HH:mm:ss") & ": " & Texto & DMScr()
			'Else
			'    If Left(Texto, 5) = "=ws=>" Then Exit Sub
			'End If

			VarJD &= Strings.Format(Now, "HH:mm:ss") & ": " & Texto & DMScr()



			'Try
			'    If fDebugJD.ChkDetener.Checked Then
			'        fDebugJD.TxtDebug.Tag += Strings.Format(Now, "hh:mm:ss") & ": " & Texto & DMScr()
			'    Else
			'        fDebugJD.TxtDebug.Text += fDebugJD.TxtDebug.Tag & Strings.Format(Now, "hh:mm:ss") & ": " & Texto & DMScr()
			'        fDebugJD.TxtDebug.Tag = ""
			'        fDebugJD.TxtDebug.SelectionStart = fDebugJD.TxtDebug.Text.Length
			'        fDebugJD.TxtDebug.ScrollToCaret()
			'        HagaEventos()
			'    End If
			'Catch ex As Exception
			'    fDebugJD.TxtDebug.Text = Strings.Format(Now, "hh:mm:ss") & ": " & ex.Message & EsIngles & DMScr()
			'End Try

		Catch ex As Exception

			'If Usuario = 6195 Then
			'    Mensaje("mostrardebug: " & ex.Message & EsIngles)
			'End If

		End Try
	End Sub
	Public Function DMScr(Optional CuantosRenglones As Integer = 1) As String
		Dim Tex As String = ""
		For I As Integer = 1 To CuantosRenglones
			Tex += vbNewLine
		Next
		Return Tex

	End Function
	''' <summary>
	''' Llena varios DataTables desde información virtualizada (XML) por el Menú de Advance la última vez que ingresó el usuario o la extrae de la BD si no existe.  Son los siguientes datos:
	''' DtUsuCli = Exec GetUsuarioClientesAsignados + Usuario: El o los clientes que están asignados a un usuario para ingresar al sistema y trabajar solo con ese cliente
	''' DtPermisos = Exec GetPermisosUsuario_Todos + Usuario: Carga todos los permisos del Usuario
	''' DtReglas = Exec GetReglasResp + Numero_Empresa: Reglas del Negocio
	''' BodegaUsuario = Exec GetCotBodegaUsuario + Usuario: Bodega ppal del usuario
	''' DtBodegasPerm = Exec GetCotBodegaUsuario_Permitidas + Usuario: Bodegas a las que el usuario tiene permiso
	''' DtTipo = Exec GetCotTipos + Numero_Empresa: Tipos de documentos
	''' DtBodegas = Exec GetCotBodegas + Numero_Empresa: Todas las bodegas
	''' DtTitPantalla = Exec GetProgramasTit + Numero_Empresa: Títulos de pantallas personalizados
	''' DtSw = Exec GetSw: Trae todos los SW
	''' </summary>
	''' <param name="CbCli">Puede enviar un Combo DMS Clientes para llenarlo con los clientes que puede trabajar el usuario</param>
	''' <remarks></remarks>
	Public Sub Traer_Usuario_Clientes(Optional ByVal CbCli As ComboDMSClientes = Nothing)
		DebugJD("1: Traer_Usuario_Clientes")
		Try
			If DtBodegas.Rows.Count = 0 Or DtSw.Rows.Count = 0 Then
				DebugJD("2: Traer_Usuario_Clientes")

				'DebugJD("Virtual: Traer_Usuario_Clientes, permisos y reglas")
				Dim Ds As New DataSet
				'If DMS_XML_Leer_DataSet(Ds, "usuario_clientes") = False Or SoyServicio > 0 Or Numero_Empresa = 491 Then 'la empresa de ecuador siempre debe volver a leer, pues el menu trajó otros distintos
				'DebugJD("On-Line: Traer_Usuario_Clientes, permisos y reglas")
				Abrir(Ds,
						  "Exec GetUsuarioClientesAsignados " & Usuario.ToString & DMScr() &
						  "Exec GetPermisosUsuario_Todos " & Usuario.ToString & DMScr() &
						  "Exec GetReglasResp2 " & Numero_Empresa & "," & Usuario.ToString & DMScr() &
						  "Exec GetCotBodegaUsuario " & Usuario.ToString & DMScr() &
						  "Exec GetCotBodegaUsuario_Permitidas " & Usuario.ToString & "," & Numero_Empresa & "," & IIf(IgnorarPermisosUsuarioServicio, 1, 0) & DMScr() &
						  "Exec GetCotTipos " & Numero_Empresa & "," & Usuario & DMScr() &
						  "Exec GetCotBodegas " & Numero_Empresa.ToString & "," & Usuario.ToString & "," & IIf(IgnorarPermisosUsuarioServicio, 1, 0) & DMScr() &
						  "Exec GetProgramasTit " & Numero_Empresa & DMScr() &
						  "Exec GetSw2 " & Numero_Empresa & DMScr() &
						  "select e.respuesta from reglas_emp e where e.id_emp=1 and e.id_reglas=126 and e.llave='" & Numero_Empresa.ToString & "'" &
						  "Select id_pais from emp where id=" & Numero_Empresa) 'empresa madre
				'no agregar tablas aqui sin arreglar flogin donde escribe "usuario_clientes"
				'DMS_XML_Escribir_DataSet(Ds, "usuario_clientes")
				'End If
				DtUsuCli = Ds.Tables(0).Copy
				DtPermisos = Ds.Tables(1).Copy

				DtReglas = Ds.Tables(2).Copy
				Dim PrimaryKeyColumns(2) As DataColumn
				PrimaryKeyColumns(0) = DtReglas.Columns("id_reglas")
				PrimaryKeyColumns(1) = DtReglas.Columns("llave")
				DtReglas.PrimaryKey = PrimaryKeyColumns

				If Not Fin(Ds.Tables(3)) Then
					BodegaUsuario = Ds.Tables(3).Rows(0).Item("id_cot_bodega")
				End If
				DtBodegasPerm = Ds.Tables(4).Copy
				DtTipo = Ds.Tables(5).Copy
				DtBodegas = Ds.Tables(6).Copy
				'estaba comentariado no se porque, lo vuelvo a poner
				DtTitPantalla = Ds.Tables(7).Copy
				DtSw = Ds.Tables(8).Copy

				'traducir sw
				If LenguajeAdvance = 1 Then
					For Each Fi As DataRow In DtSw.Rows
						Fi("descripcion") = Idi(Fi("descripcion"), "\")
					Next
				End If
				DebugJD("dtsw.rows=" & DtSw.Rows.Count.ToString)

				If Ds.Tables(9).Rows.Count > 0 Then
					EmpresaMadre = ValD(Ds.Tables(9).Rows(0).Item("respuesta"))
				End If
				If EmpresaMadre = 0 Then EmpresaMadre = Numero_Empresa
				'único sitio donde se captura el país
				'If Ds.Tables.Count > 10 Then
				If Fin(Ds.Tables(10)) Then
					Mensaje("No hay tabla pais en Traer_Usuario_Clientes")
				Else
					IdPais = ValD(Ds.Tables(10).Rows(0).Item("id_pais"))
				End If
				'End If

			End If
			DebugJD("3: Traer_Usuario_Clientes")

			'esto ya no se usa
			If DtUsuCli.Rows.Count > 0 And CbCli IsNot Nothing Then
				CbCli.DMSUsaBuscar = False
				For I As Integer = 0 To DtUsuCli.Rows.Count - 1
					CbCli.DMSAdicionar_Tercero(Gdf(DtUsuCli, I, "id_cot_cliente"), Gdf(DtUsuCli, I, "razon_social"))
				Next
				CbCli.DMSPongaIndex(Gdf(DtUsuCli, 0, "id_cot_cliente"))
			End If

		Catch ex As Exception
			MostrarError("Ppal", "Traer_Usuario_Clientes", ex.Message)
			DtUsuCli.Rows.Clear()
		End Try

	End Sub
	''' <summary>
	''' Pone el Logo de Advance en el espacio del grid antes de comenzar a trabajar
	''' </summary>
	''' <param name="ObjetoSobreponer">El objeto que va a tapar el logo, normalmente un grid</param>
	''' <param name="PicLogo">La imagen del logo</param>
	''' <remarks></remarks>
	Public Sub Asignar_Logo(ByVal ObjetoSobreponer As Object, ByRef PicLogo As PictureBox)
		Try
			PicLogo.Location = ObjetoSobreponer.Location
			PicLogo.Size = ObjetoSobreponer.size
			PicLogo.Anchor = ObjetoSobreponer.Anchor
			PicLogo.Dock = ObjetoSobreponer.dock
			PicLogo.ImageLocation = Path_Temp & NombreArchivoLogoSMD
			'PicLogo.Margin = New Padding(500)

			'PicLogo.Padding = New System.Windows.Forms.Padding(30)
			'PicLogo.Height = PicLogo.Height / 2
			'PicLogo.Width = PicLogo.Width / 2
			'PicLogo.Left = ObjetoSobreponer.Left + (ObjetoSobreponer.Width - PicLogo.Width) / 2
			'PicLogo.Top = ObjetoSobreponer.Top + (ObjetoSobreponer.Height - PicLogo.Height) / 2

			PicLogo.Visible = True
			HagaEventos()
		Catch ex As Exception
		End Try


		'Try
		'    PicLogo.ImageLocation = Path_Temp & NombreArchivoLogoSMD
		'    PicLogo.Size = ObjetoSobreponer.size
		'    PicLogo.Visible = True
		'    PicLogo.Height = PicLogo.Height / 2
		'    PicLogo.Width = PicLogo.Width / 2
		'    PicLogo.Left = ObjetoSobreponer.Left + (ObjetoSobreponer.Width - PicLogo.Width) / 2
		'    PicLogo.Top = ObjetoSobreponer.Top + (ObjetoSobreponer.Height - PicLogo.Height) / 2
		'    PicLogo.BringToFront()
		'    HagaEventos()
		'Catch ex As Exception
		'End Try


	End Sub
	Public Sub Asignar_Logo2(ByVal ObjetoSobreponer As Object, ByRef PicLogo As PictureBox, ByRef PanelContenedorLogo As Panel)
		Try
			PanelContenedorLogo.Location = ObjetoSobreponer.Location
			PanelContenedorLogo.Size = ObjetoSobreponer.Size
			PanelContenedorLogo.Anchor = ObjetoSobreponer.Anchor
			PanelContenedorLogo.Dock = ObjetoSobreponer.Dock
			PicLogo.ImageLocation = Path_Temp & NombreArchivoLogoSMD

			PanelContenedorLogo.Visible = True
			HagaEventos()
		Catch ex As Exception
		End Try



	End Sub
	''' <summary>
	''' Abre una página WEB sobre el objeto WebBowser
	''' </summary>
	''' <param name="TextoURL">Dirección de la página: e.g. www.dms.ms</param>
	''' <param name="Formas">Objeto Formas de windows</param>
	''' <param name="Titulo"></param>
	''' <remarks></remarks>
	Public Sub AbrirWeb(ByRef Formas As FormCollection,
						ByVal TextoURL As String,
						Optional ByVal Titulo As String = "",
						Optional LinkChat As String = "",
						Optional TextoHTML As String = "")
		Try
			'If LCase(Mid(TextoURL, 1, 7)) <> "http://" Then
			'    TextoURL = "http://" & TextoURL
			'End If
			If Titulo <> "" Then
				If FormaYaEstaAbierta3(Formas, Nothing, "fWeb", Titulo) Then Exit Sub
			End If

			Dim fW As New fWeb
			If LinkChat <> "" Then
				fW.LnkChat.Tag = LinkChat
			Else
				fW.LnkChat.Tag = ""
			End If
			fW.Tag = Titulo
			If TextoURL = "blanco" Then
				fW.WebBrowser1.Url = Nothing
			Else
				If TextoURL = "" Then
					fW.WebBrowser1.DocumentText = TextoHTML
				Else
					fW.WebBrowser1.Url = New Uri(TextoURL)
				End If

			End If
			If Titulo <> "" Then fW.Text = Titulo ' & " (" & fW.Text & ")"
			fW.Show()




		Catch ex As Exception
			'Mensaje("No se puede conectar a la página de Internet: " & ex.Message & EsIngles)

		End Try

	End Sub
	''' <summary>
	''' Abre una ventana nueva para escribir con mayor amplitud el contenido de un textbox
	''' </summary>
	''' <param name="Forma">Forma donde está el TextoBox</param>
	''' <param name="Txt">TextBox como tal. Ver ejemplo en 5502, notas de cada item</param>
	''' <returns>Devuelve el texto capturado en la nueva pantalla</returns>
	''' <remarks></remarks>
	Public Function AmpliarTextBox(ByVal Forma As Form, ByVal Txt As TextBox)

		Try
			Dim fTex As New fTextBox
			fTex.TextBox1.MaxLength = Txt.MaxLength

			Dim Mouse As New POINTAPI
			GetCursorPos(Mouse)
			fTex.Left = Mouse.X
			fTex.Top = Mouse.Y

			'fTex.Width = Txt.Width * 3
			'If fTex.Width + fTex.Left > Screen.PrimaryScreen.WorkingArea.Width Then
			'    fTex.Width = Txt.Width
			'End If

			fTex.TextBox1.Tag = Txt.Text
			fTex.TextBox1.Text = Txt.Text
			fTex.TextBox1.SelectionStart = fTex.TextBox1.TextLength
			fTex.ShowDialog()

			Return fTex.TextBox1.Tag

		Catch
			Return Txt.Text

		End Try

	End Function
	''' <summary>
	''' Poner o quitar la pantalla de Splash de Advance
	''' </summary>
	''' <param name="Cerrar">True: Cierra la ventana</param>
	''' <param name="SoyElMenu">True: Llamado desde el menú ppal de Advance</param>
	''' <param name="Texto">Texto para poner encima del splash: e.g. "Facturación"</param>
	''' <param name="UsarTimer">True=Activa el timer para que permanezca TOP mientras sea necesario</param>
	''' <remarks></remarks>
	Public Sub Pantalla_Splash(Optional ByVal Cerrar As Boolean = False, Optional ByVal SoyElMenu As Boolean = False, Optional ByVal Texto As String = "...", Optional ByVal UsarTimer As Boolean = True)
		If NoEntrar() Then
			Exit Sub
		End If

		MiNombre = GetSetting("DMS S.A.", "ctrl", "nomp", "")

		If Cerrar Then
			'nuevo cerrar
			NoReloj(fBusIt)
			'Exit Sub
		End If


		If Left(Texto, 1) = "°" Or Left(Texto, 1) = "|" Then 'para controlar status de ingreso a advance
			'fSpl.LblApl.Font.Bold = False
			fSpl.LblApl.Text = Mid(Texto, 2)
			If Left(Texto, 1) = "|" Then
				fSpl.LblApl.ForeColor = Color.Red
			Else
				fSpl.LblApl.ForeColor = Color.Orange
			End If

			fSpl.ProgressBar1.Visible = True
			If fSpl.ProgressBar1.Value < fSpl.ProgressBar1.Maximum Then
				fSpl.ProgressBar1.Value += 1
			End If
			HagaEventos()
			Exit Sub
		End If
		fSpl.ProgressBar1.Visible = False

		'esto por si acaso
		'se paso para Traer_Usuario_Clientes
		'IdPais = ValD(GetSett("Ayuda", "Pais", "1"))

		'22 de junio de 2010
		'MsgBox("SoyMenu: " & SoyElMenu.ToString & ", Cerrar: " & Cerrar.ToString)
		Try
			'Asignar_Paths(Path_Prog, Path_Temp, DesdeFuente)

			If Cerrar Then
				If SoyElMenu Then
					fSpl.Timer1.Stop()
					fSpl.Hide()
				Else
					SaveSetting("DMS S.A.", "fC", "spl", "1")
				End If
			ElseIf SoyElMenu Then
				SaveSetting("DMS S.A.", "fC", "spl", "0")
				fSpl.SoyElMenu = SoyElMenu
				'fSpl.LblApl.Visible = Not SoyElMenu
				fSpl.LblApl.Text = Texto
				SaveSetting("DMS S.A.", "fC", "splt", fSpl.LblApl.Text)
				'fSpl.TopMost = True
				fSpl.Timer1.Tag = -1
				If UsarTimer Then
					fSpl.Timer1.Tag = 0
					fSpl.Timer1.Start()
				End If

				If MiNombre <> "" Then
					fSpl.Label1.Text = Idi("Hola ", "Hello ") & PrimerNombre(MiNombre)
					fSpl.Label1.Visible = True
				End If

				'para que salga el pequeño
				'If My.Application.Info.AssemblyName <> "SMDMenu" Then
				'    'EstoyEnSplash = True
				'    fSpl.CambiarTamaño()
				'End If

				fSpl.Show()
			Else 'poner título
				SaveSetting("DMS S.A.", "fC", "splt", My.Application.Info.Title + " v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString + "." + My.Application.Info.Version.Revision.ToString)
			End If
			HagaEventos()
		Catch
		End Try
	End Sub
	''' <summary>
	''' Busca dentro de un DataGridView
	''' </summary>
	''' <param name="Grd">Nombre del Grid</param>
	''' <remarks></remarks>
	Public Sub Buscar_en_Grid(ByRef Grd As DataGridView)
		Try
			If Grd.Rows.Count = 0 Then Mensaje("No hay información para hacer la búsqueda") : Exit Sub
			Dim Frm As New fResultBuscarGrid
			Frm.TopMost = True
			Frm.Grd = Grd
			Frm.ShowDialog()

			If ValD(Frm.Tag) >= 0 Then
				If Not Grd.Rows(ValD(Frm.Tag)).Displayed Then
					Grd.FirstDisplayedScrollingRowIndex = ValD(Frm.Tag)
				End If
				Grd.Rows(ValD(Frm.Tag)).Selected = True
				Grd.CurrentCell = Grd.Rows(ValD(Frm.Tag)).Cells(Grd.CurrentCell.ColumnIndex)
				Grd.CurrentCell.Selected = True

			End If
		Catch ex As Exception

		End Try


	End Sub
	''' <summary>
	''' Busca dentro de un datatable
	''' </summary>
	''' <param name="Dt"></param>
	''' <param name="ColBuscar"></param>
	''' <param name="ColDevolver"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function Buscar(ByVal Dt As DataTable,
						   ByVal ColBuscar As String,
						   ByVal ColDevolver As String,
						   Optional TextoInicial As String = "") As Integer
		Try
			Dim fRes As New fResultBuscar1
			fRes.TopMost = True
			fRes.TextoBuscar = TextoInicial
			fRes.Dt = Dt
			fRes.CampoBuscar = ColBuscar
			fRes.CampoId = ColDevolver
			fRes.ShowDialog()




			Return ValD(fRes.Tag)



		Catch ex As Exception
			Mensaje("Error buscando")

		End Try
	End Function

	Public Function PrimerNombre(Nombre As String) As String
		Try
			Dim Nom2() As String = Nombre.Split(" ")
			Return UCase(Strings.Left(Nom2(0), 1)) & LCase(Strings.Mid(Nom2(0), 2))
		Catch
			Return Nombre
		End Try


	End Function

	Public Sub Cierre_Ventana(ByVal Forma As Form, Optional ByVal SoloOcular As Boolean = False)
		'Forma.ShowInTaskbar = False
		'HagaEventos()

		If Not SoloOcular Then
			Forma.Tag = "0"
			Forma.Enabled = False
		End If

		If IgnorarEfectos Then
			If SoloOcular Then
				Forma.Hide()
			Else
				Forma.Close()
			End If
			Exit Sub
		End If

		Dim fCerrar As New fCerrarVentana
		fCerrar.Forma = Forma
		fCerrar.SoloOcular = SoloOcular
		fCerrar.Show()

	End Sub
	''' <summary>
	''' Calcula la diferencia en tiempo entre dos fechas mostrando el resultado como un texto.
	''' </summary>
	''' <param name="FechaMenor">Fecha inferior</param>
	''' <param name="FechaMayor">Fecha mayor</param>
	''' <returns>Texto mostrando diferencia entre las dos fechas</returns>
	''' <remarks></remarks>
	Public Function HaceCuantoTiempo(ByVal FechaMenor As Date, ByVal FechaMayor As Date) As String

		Try
			Dim Segundos As Integer = DateDiff(DateInterval.Second, FechaMenor, FechaMayor)
			Dim Años As Integer = Segundos \ 31557600
			Dim Meses As Integer = (Segundos - (Años * 31557600)) \ 2629800
			Dim Dias As Integer = (Segundos - (Años * 31557600) - (Meses * 2629800)) \ 86400
			Dim Horas As Integer = (Segundos - (Años * 31557600) - (Meses * 2629800) - (Dias * 86400)) \ 3600
			Dim Minutos As Integer = (Segundos - (Años * 31557600) - (Meses * 2629800) - (Dias * 86400) - (Horas * 3600)) \ 60
			Dim Segu As Integer = (Segundos - (Años * 31557600) - (Meses * 2629800) - (Dias * 86400) - (Horas * 3600) - (Minutos * 60))
			Dim LblFalta2 As String = ""

			If Hour(FechaMenor) = 0 And Minute(FechaMenor) = 0 And Second(FechaMenor) = 0 And
			Hour(FechaMayor) = 0 And Minute(FechaMayor) = 0 And Second(FechaMayor) = 0 Then
				Horas = 0
				Minutos = 0
				Segu = 0
			End If

			LblFalta2 = ""
			If Años <> 0 Then
				LblFalta2 += Años.ToString & Idi(" año", " year") & IIf(Años = 1, ", ", "s, ")
			End If
			If Meses <> 0 Then
				LblFalta2 += Meses.ToString & Idi(" mes", " month") & IIf(Meses = 1, ", ", IIf(LenguajeAdvance = 1, "s, ", "es, "))
			End If
			If Dias <> 0 Then
				LblFalta2 += Dias.ToString & Idi(" día", " day") & IIf(Dias = 1, ", ", "s, ")
			End If
			If Horas <> 0 Then
				LblFalta2 += Horas.ToString & Idi(" hora", " hour") & IIf(Horas = 1, ", ", "s, ")
			End If
			If Minutos <> 0 Then
				LblFalta2 += Minutos.ToString & Idi(" minuto", " minute") & IIf(Minutos = 1, ", ", "s, ")
			End If
			If Segu <> 0 Then
				LblFalta2 += Segu.ToString & Idi(" segundo", " second") & IIf(Segu = 1, ", ", "s, ")
			End If
			If LblFalta2 <> "" Then
				LblFalta2 = LblFalta2.Substring(0, LblFalta2.Length - 2)
			Else
				LblFalta2 = Idi("Inmediato", "Righ now")
			End If


			Return LblFalta2

		Catch ex As Exception
			Return "(error)"

		End Try

	End Function

	''' <summary>
	''' Pregunta algo por pantalla y devuelve true o false
	''' </summary>
	''' <param name="TextoPregunta">Texto de la pregunta</param>
	''' <param name="TituloVentana">Título de la ventana</param>
	''' <param name="GuardarRespuestaSI_Forma_Name">Form.Name para que pueda recordar la respuesta Si</param>
	''' <param name="GuardarRespuestaNO_Forma_Name">Form.Name para que pueda recordar la respuesta No</param>
	''' <param name="ImagenNumero"># de imagen que desea mostrar al lado izquierdo. e.g. 3=Borrar algo, 4=Actualizar algo, 6=Interrogación... ver más en programa 0180</param>
	''' <param name="Compleja">0=No usar pregunta compleja; 1=preguntar si o no respondiendo con un número e ingresando %s% para si y %n% para no ; 2=entrar un número para poder continuar</param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function Pregunte(ByVal TextoPregunta As String, Optional ByVal TituloVentana As String = "", Optional ByVal GuardarRespuestaSI_Forma_Name As String = "", Optional ByVal GuardarRespuestaNO_Forma_Name As String = "", Optional ByVal ImagenNumero As Integer = 0, Optional Compleja As Short = 0) As Boolean

		'Return MsgBox(TextoPregunta, MsgBoxStyle.YesNo + MsgBoxStyle.Question, TituloVentana) = MsgBoxResult.Yes
		Return Mensaje_TopMost(TextoPregunta, TituloVentana, , , , True, , GuardarRespuestaSI_Forma_Name, GuardarRespuestaNO_Forma_Name, ImagenNumero, , , Compleja) = "SI"

	End Function
	''' <summary>
	''' Hace la pregunta ofreciando respuestas Si, No y Cancel
	''' </summary>
	''' <param name="TextoPregunta">Texto de la pregunta</param>
	''' <returns>Resultado: 
	''' 6=Si
	''' 7=No
	''' 2=Cancel
	''' </returns>
	''' <remarks></remarks>
	Public Function PregunteCancel(ByVal TextoPregunta As String) As Short
		If EstoyEnPregunta Then
			Return MsgBoxResult.Cancel
		End If

		Dim Result As String = Mensaje_TopMost(TextoPregunta, , , , , True, True)

		If Result = "SI" Then
			Return 6
		ElseIf Result = "NO" Then
			Return 7
		Else
			Return 2
		End If


	End Function
	''' <summary>
	''' Trae el stock de un item en todas las bodegas. Lo muestra por pantalla en un grid o lo devuelve en el grid entrado en los parámetros
	''' </summary>
	''' <param name="CodigoItem">Código del item</param>
	''' <param name="EsEstructura">True = Es una estructura</param>
	''' <param name="Grd">Grid opcional donde desea poner los resultados</param>
	''' <remarks></remarks>
	Public Sub Stock_Bodegas(ByVal CodigoItem As String, ByVal EsEstructura As Boolean, Optional ByVal Grd As GridDms = Nothing)
		If CodigoItem = "" Then
			Mensaje_TopMost("Entre un item")
			Exit Sub
		End If

		Try
			SiReloj()

			Dim DtI As New DataTable
			Dim Ds As New DataSet

			Abrir(Ds, "Exec GetCotItemStockVariasBodegas " & Numero_Empresa.ToString & ",'" & CodigoItem & "',0," & Usuario.ToString & "," & ReglaDeNegocio(51, , "0") & "," & IIf(EsEstructura, "1", "0"))

			NoReloj()

			'If Gdf(Ds.Tables(0), "permiso") = 0 Then
			'    Mensaje("No tiene permiso para el subgrupo de este item")
			'    Exit Sub
			'End If

			DtI = Ds.Tables(1).Copy

			If Fin(DtI) Then
				Mensaje_TopMost("Item no tiene stock en ninguna bodega")
			Else
				If Grd Is Nothing Then
					SQL = Ventana(DtI, "Stock de " & CodigoItem, True, "id", New Object() {"id"})
				Else
					Grd.DMSLlene_Grid(DtI)
				End If
			End If

		Catch ex As Exception
			NoReloj()
			Mensaje_TopMost("No logró obtener stock. Intente de nuevo:" & DMScr() & Err.Description, , , True)
		End Try

	End Sub
	'Public Function FechaVenceDemo() As Date
	'    Dim Fec As String = GetSett("Ayuda", "vcmto", "") 'guardo el dato para que lo tomen las aplicaciones
	'    If Fec = "" Then
	'        Fec = Strings.Format(Now, "yyyy/MM/dd")
	'    Else
	'        Fec = Encriptar("D", Fec)
	'    End If

	'    If IsDate(Fec) Then
	'        Return CDate(Fec)
	'    Else
	'        Return Now
	'    End If

	'End Function
	''' <summary>
	''' Saber si se tiene licencia para entra a un determinado producto
	''' </summary>
	''' <param name="CodigoAddOn">Código del producto de Advance</param>
	''' <param name="MostrarMensaje">True=Muestra mensaje informando si se tiene o no</param>
	''' <returns>True=Tiene licencia; False=No tiene licencia</returns>
	''' <remarks></remarks>
	Public Function Falta_Licencia(ByVal CodigoAddOn As String, Optional ByVal MostrarMensaje As Boolean = True) As Boolean

		Dim YaRepitio As Boolean = False

		DebugJD("** Validar licencia: " & CodigoAddOn)

		Dim Nom As New DataTable
		Dim CodigoAndTexto As String = ""

		'If DtLicAddIn.Rows.Count = 0 Then
		'    'Dim Ds As New DataSet
		'    'If DMS_XML_Leer_DataSet(Ds, "licencias", 0) = False Then
		'    '    MostrarError("Ppal", "Falta_Licencia", "No logró leer el xml de licencias")
		'    '    Return True
		'    'End If
		'    'DtLicAddIn = Ds.Tables(0).Copy
		'    'DtVenceDemo = Ds.Tables(1).Copy
		'End If

		'esto para que los usuarios de servicio no les pregunte nada de licencias
		'no hacer esto pues daña algunas pruebas del sistema de licenciamiento
		'If SoyServicio > 0 Then
		'    DebugJD("    licencia ok, soy_servicio")
		'    Return False
		'End If

		If DtLicAddIn.Rows.Count = 0 Then
			Dim Ds As New DataSet
			DebugJD("    Leyendo XML de licencias: " & MiEmpresa)
			If DMS_XML_Leer_DataSet(Ds, "licencias", 0) = False Then
				Abrir(Ds, "Exec GetTengoLicencia3 '" & MiEmpresa & "'")
				'If MarcaExterna = "local" Then
				'    Abrir(Ds, "Exec GetTengoLicencia3 '" & MiEmpresa & "'")
				'Else
				'    'siempre leer en dms
				'    Abrir_Nodo_1(Ds, "Exec GetTengoLicencia3 '" & MiEmpresa & "'")
				'End If
				DMS_XML_Escribir_DataSet(Ds, "licencias", 0)
			End If
			DtLicAddIn = Ds.Tables(0).Copy
			DtVenceDemo = Ds.Tables(1).Copy
		End If


Repita:
		Dim Resultado As Boolean = False

		If DtLicAddIn.Rows.Count = 0 Then
			DebugJD("    No encontró licencias")
			If MostrarMensaje Then
				Mensaje_TopMost("Informe a DMS que falta evaluar la licencia " & CodigoAddOn & " pues la tabla está vacía", , , True)
			End If
			Return True
		End If
		Dim Dt As DataTable = Filtrar_DataTable(DtLicAddIn, "codigo='" & CodigoAddOn & "'")


		If Fin(Dt) Then
			DebugJD("    No licencia")
			If MostrarMensaje Then CodigoAndTexto = Idi("Licencia no disponible en esta empresa",
														   "License not available in this company")
			Resultado = True
			GoTo Salir
		End If


		If ValD(Gdf(Dt, "cantidad")) = 0 Then 'no tiene licencia
			'If MostrarMensaje Then Mensaje_TopMost("Su Empresa no tiene Licencia para la aplicación " & CodigoAddOn & Ayu, "Aplicación " & CodigoAddOn, , True)
			If MostrarMensaje Then CodigoAndTexto = Idi("Licencia no está activada",
														   "License is not activated")
			Resultado = True
			GoTo Salir
		End If


		If ValD(Gdf(Dt, "demo")) <> 0 Then 'es demo
			DebugJD("    licencia demo")
			If Fin(DtVenceDemo) Then
				MostrarError("Ppal", "Falta_Licencia", "Error de Programador de ADVANCE: No cargó el datatable DtVenceDemo")
				If MostrarMensaje Then CodigoAndTexto = "Su Empresa no tiene definida fecha de vencimiento para el demo"
				Resultado = True
				GoTo Salir
			End If
			If Gdf(DtVenceDemo, "fecha_vencimiento_demo") Is System.DBNull.Value Then
				If MostrarMensaje Then CodigoAndTexto = "Su Empresa no tiene definida fecha de vencimiento para el demo"
				Resultado = True
				GoTo Salir
			End If
			If Gdf(DtVenceDemo, "fecha_vencimiento_demo") < FechaHoyAsignada() Then
				If MostrarMensaje Then CodigoAndTexto = Idi("Demostración finalizó en la fecha " & Gdf(DtVenceDemo, "fecha_vencimiento_demo"), "Demonstration finished")
				Resultado = True
				GoTo Salir
			End If
			If MostrarMensaje Then
				CodigoAndTexto = Idi("*** Aplicación en Demostración ***" & DMScr(2) & "Gracias por utilizar nuestros productos." & DMScr(2) & "Vencimiento: " & Gdf(DtVenceDemo, "fecha_vencimiento_demo") & DMScr() & "Faltan: " & DateDiff(DateInterval.Day, FechaHoyAsignada, Gdf(DtVenceDemo, "fecha_vencimiento_demo")) & " días",
										"*** Demonstration Application ***" & DMScr(2) & "Thanks for using our products." & DMScr(2) & "Expiration: " & Gdf(DtVenceDemo, "fecha_vencimiento_demo") & DMScr() & "Days left: " & DateDiff(DateInterval.Day, FechaHoyAsignada, Gdf(DtVenceDemo, "fecha_vencimiento_demo")))

			End If
		End If


Salir:
		DebugJD("    saliendo con: " & Resultado.ToString)

		If Resultado = True Then 'no tiene licencia
			If YaRepitio = False Then 'no ha reintentado
				YaRepitio = True
				Try
					Dim Ds As New DataSet
					'Abrir_Nodo_1(Ds, "Exec GetTengoLicencia3 '" & MiEmpresa & "'")
					Abrir(Ds, "Exec GetTengoLicencia3 '" & MiEmpresa & "'")
					DtLicAddIn = Ds.Tables(0).Copy
					DtVenceDemo = Ds.Tables(1).Copy
					DMS_XML_Escribir_DataSet(Ds, "licencias", 0)
					GoTo Repita
				Catch
				End Try
			End If
		End If

		If CodigoAndTexto <> "" Then
			CodigoAndTexto &= vbNewLine & DMScr() & "Código: " & CodigoAddOn
			Mensaje_TopMost(CodigoAndTexto, "Código: " & CodigoAddOn, , True)
		End If

		If (DesdeFuente Or SoyServicio = 1) And Resultado = True And MostrarMensaje Then
			If Pregunte("USUARIO DE SERVICIO: No tiene la licencia " & CodigoAddOn & ". Desea ignorar este control de licenciamiento?") Then
				Return False
			Else
				Return True
			End If
		Else
			Return Resultado
		End If

	End Function
	''' <summary>
	''' Busca el item del cliente
	''' </summary>
	''' <param name="IdCliente"></param>
	''' <param name="CodigoItem"></param>
	''' <param name="BuscarClienteItems"></param>
	''' <remarks></remarks>
	Public Sub ConseguirItemCliente(ByVal IdCliente As Integer, ByRef CodigoItem As String, ByVal BuscarClienteItems As Boolean)
		If BuscarClienteItems And DtClienteItem.Rows.Count = 0 Then
			Abrir(DtClienteItem, "Exec GetCotClienteItem " & IdCliente.ToString)
		End If
		If DtClienteItem.Rows.Count = 0 Then Exit Sub

		Dim CodEsp As String = "" & Obtenga_Dato(DtClienteItem, "codigo_cliente='" & UCase(SinComillas(Trim(CodigoItem))) & "'", "id_cot_item")
		If CodEsp <> "" Then
			CodEsp = "" & Obtenga_Dato(DtItem, "id=" & ValD(CodEsp).ToString, "codigo")
			If CodEsp <> "" Then
				CodigoItem = CodEsp
			End If
		End If

	End Sub
	Private Function BuscarItemBD(Codi As String) As Boolean
		If RealTime > 0 Then
			Return False 'ya lo buscó
		End If

		'esto es lo que se hace para agregar al DataTable un item que no estaba
		Try
			Dim Dt As New DataTable
			Abrir(Dt, "Exec GetCotItems9B " & Numero_Empresa.ToString & "," & IIf(Regla_SoyAutomotriz_16, "1", "0") & ",1," & Usuario.ToString & "," & ReglaDeNegocio(51, , "0") & ",0,0,'" & SinComillas(Codi) & "'")
			If Not Fin(Dt) Then
				'DtItem.Merge(Dt)
				MergeDMS(DtItem, Dt)

				Return True
			End If
		Catch ' ex As Exception
		End Try
		Return False

	End Function
	''' <summary>
	''' Trae un item de inventarios por su código principal o alterno. Si no existe lo busca dentro de la descripción
	''' </summary>
	''' <param name="CodigoItem">Código del item que desea buscar. O fracción de descripción a buscar</param>
	''' <param name="IdItem">Id del item encontrado. Dato de salida</param>
	''' <remarks></remarks>
	Public Sub ConseguirItem(ByRef CodigoItem As String, Optional ByRef IdItem As Integer = 0, Optional IdBodega As Integer = 0)
		CodigoItem = UCase(SinComillas(Trim(CodigoItem)))
		If CodigoItem = "" Then Exit Sub

		Dim Dr As DataRow

		fBusIt.Traer_Item_Real_Time(CodigoItem)


		Dr = DtItem.Rows.Find(CodigoItem)
		If Dr Is Nothing Then 'buscar en la tabla alterna
			Dim Dt As New DataTable
			Dt = Filtrar_DataTable(DtItemCod, "codigo='" & CodigoItem & "'")
			If Dt.Rows.Count = 0 Then
				'buscar en la BD
				If BuscarItemBD(CodigoItem) Then GoTo Saliendo 'se agregó a DtItem

				'buscar por descripcion tocó
				Dt = Filtrar_DataTable(DtItem, "descripcion like '%" & CodigoItem & "%'")
				If Fin(Dt) Then
					CodigoItem = ""
				Else
					ItemBuscado = CodigoItem
					CodigoItem = ConseguirItemVarios(Dt, False)
				End If
			ElseIf Dt.Rows.Count > 0 Then 'lo mas normal, encontro uno o más
				If Dt.Rows.Count = 1 Then
					CodigoItem = "" & Obtenga_Dato(DtItem, "id=" & Gdf(Dt, "id").ToString, "codigo")
				Else 'son varios alternos, escoger alguno
					Dim S3 As String = "id in("
					For K As Integer = 0 To Dt.Rows.Count - 1
						S3 += Gdf(Dt, K, "id").ToString & ","
					Next
					S3 = Mid(S3, 1, Len(S3) - 1) & ")" 'éstos son los ids de los alternos

					Dim d4 As New DataTable
					If IdBodega > 0 Then 'buscar en BD para traer stock
						Abrir(d4, "select i.codigo,stock=sum(v.stock) from cot_item i left join v_cot_item_stock_tot_real v on v.id_cot_item=i.id and v.id_cot_bodega=" & IdBodega & " where i." & S3 & " Group by i.codigo")
					Else
						Dim D3 As DataTable = Filtrar_DataTable(DtItem, S3, "codigo")
						d4.Columns.Add("codigo")
						d4.Columns.Add("descripcion")
						For K As Integer = 0 To D3.Rows.Count - 1
							d4.Rows.Add(Gdf(D3, K, "codigo"), Gdf(D3, K, "descripcion"))
						Next

					End If
					CodigoItem = Ventana(d4, "Seleccione un item", True, "codigo")
				End If
			Else 'hay varios debe escoger cual
				ItemBuscado = CodigoItem
				CodigoItem = ConseguirItemVarios(Dt, True)
			End If
		Else 'este es el caso más normal
			IdItem = Dr("id")
			Exit Sub
		End If

Saliendo:
		If CodigoItem <> "" Then
			IdItem = ValD(Obtenga_Dato(DtItem, "codigo='" & CodigoItem & "'", "id"))
		End If

		HagaEventos()


	End Sub
	Private Function ConseguirItemVarios(ByVal Dt As DataTable, ByVal EsAlterna As Boolean) As String
		'Dim Dt2 As New DataTable
		'Dt2.Columns.Add("Codigo", System.Type.GetType("System.String"))
		'Dt2.Columns.Add("Descripción", System.Type.GetType("System.String"))
		'Dt2.Columns.Add("Ayuda", System.Type.GetType("System.String"))
		'For I = 0 To Dt.Rows.Count - 1
		'    If I = 100 Then Exit For 'primeras 100
		'    Dim Dt3 As DataTable = Filtrar_DataTable(DtItem, "id=" & Gdf(Dt, I, "id").ToString)
		'    If Not Fin(Dt3) > 0 Then
		'        Dim Adi As String = ""
		'        If EsAlterna Then
		'            Adi = "" & Gdf(Dt, I, "adicional")
		'        End If
		'        Dt2.Rows.Add(Gdf(Dt3, "codigo"), Gdf(Dt3, "descripcion"), Adi)
		'    End If
		'Next
		'Dim Cual As String = Ventana(Dt2, "Hay varios items. Seleccione uno", True, "Codigo")
		'Return Cual

		'fBusIt.IdBod = TraerId(CbBod)
		fBusIt.ShowDialog()

		Return ItemBuscado
		'If ItemBuscado = "" Then
		'    TxtCod.Focus()
		'    Exit Function
		'End If


	End Function
	Public Function FormatoEnPDF(ByVal IdFormato As Integer)
		If ReglaDeNegocio(11, , "0") = "0" And ReglaDeNegocio(56, IdFormato.ToString, "0") = "0" Then
			Return True
		Else
			Return False
		End If

	End Function
	Public Sub PonerNumeroFilaGrid(ByRef Grd As DataGridView)

		Grd.RowHeadersVisible = True

		Grd.RowHeadersWidth = 50

		For i As Integer = 0 To Grd.RowCount - 1

			Grd.Rows(i).HeaderCell.Value = (i + 1).ToString

		Next

	End Sub
	Public Function No_Hay_Fila(Grd As DataGridView, Optional Mensa As String = "Seleccione fila") As Boolean
		If Grd.SelectedRows.Count = 0 Then
			If Mensa <> "" Then
				Mensaje(Mensa)
			End If
			Return True
		Else
			Return False
		End If

	End Function

	''' <summary>
	''' Busca varios valores en una variable.  Es como un IF con varios "OR"
	''' </summary>
	''' <param name="Dato_a_Comparar">Nombre de variable sobre la que va a buscar</param>
	''' <param name="ListaDeValores">Lista de los valores separados por comas. Ejemplo: If EstaEnLista(Dato,1,2,3,4) Then ... Si la variable Dato es 1 o 2 o 3 o 4 el resultado de la condición será True</param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function EstaEnLista(ByVal Dato_a_Comparar, ByVal ParamArray ListaDeValores()) As Boolean
		For I As Integer = 0 To ListaDeValores.Length - 1
			If Dato_a_Comparar = ListaDeValores(I) Then
				Return True
			End If
		Next
		Return False

	End Function
	Public Sub Pantalla_Splash_Condicional(ByVal NombreApl As String)
		Try
			Dim I As Integer = InStr(NombreApl, ".")
			Dim Prog As String = UCase(Mid(NombreApl, 1, I - 1))
			Dim myprocesses() As Process
			Dim myprocess As Process

			myprocesses = Process.GetProcesses
			For Each myprocess In myprocesses
				Dim Ap As String = UCase(myprocess.ProcessName)
				If Ap = Prog Then
					Exit Sub
				End If
			Next

			Pantalla_Splash(False, True)

		Catch
		End Try


	End Sub
	''' <summary>
	''' Abrir un programa desde cualquier otro programa
	''' </summary>
	''' <param name="ProgramaNumero">Número del programa. e.g. 1901</param>
	''' <param name="IdInicial">Valor inicial. Ejemplo: AbrirPrograma("1901", 12340): Abre el programa 1901 y trae el item id 12340</param>
	''' <remarks></remarks>
	Public Sub AbrirPrograma(ByVal ProgramaNumero As String, ByVal IdInicial As String)
		'Mensaje(MarcaExterna & ", ususer:" & SoyServicio)
		'If SoyServicio = 1 Then
		'    SaveSetting("sysw", "sysw", "ip4", Convierta_IP(MarcaExterna))
		'End If

		Try
			Dim Pro1 As New Process

			'Pantalla_Splash_Condicional(ExeName(ProgramaNumero))
			SiReloj(fBusIt)


			Dim UU As Integer = Usuario
			If SoyServicio And UsuarioOriginal > 0 Then
				UU = UsuarioOriginal
			End If

			Pro1.StartInfo.Arguments = """" & UU.ToString & """" & " " &
										"""" & "1" & """" & " " &
										"""" & Numero_Empresa.ToString & """" & " " &
										"""" & Sector_Empresa.ToString & """" & " " &
										"""" & IdInicial & """" & " " &
										"""" & IIf(Nit_Empresa = "", "0", Nit_Empresa) & """" &
										" """ & ProgramaNumero & """" & " " &
										"""" & MiCodigo & """" & " " &
										"""" & MiEmpresa & """" & " " &
										"""" & SoyServicio.ToString & """"


			Pro1.StartInfo.FileName = Path_Prog & ExeName(ProgramaNumero)
			Pro1.StartInfo.ErrorDialog = True
			Pro1.Start()

		Catch ex As Exception
			Mensaje("No logró abrir el módulo solicitado")

		End Try


	End Sub
	Private Function ExeName(ByVal Programa As String) As String
		If DtExe.Rows.Count = 0 Then
			Abrir(DtExe, "GetExes")
		End If

		Dim Exe As String = "" & Obtenga_Dato(DtExe, "codigo='" & Programa & "'", "nombre_exe")
		If Exe <> "" Then
			Return Exe
		End If

		Dim Prog As String = Mid(Programa, 1, 2)
		If Programa.Length > 4 Then
			Prog = Mid(Programa, 1, 3)
		End If

		Return Obtenga_Dato(DtExe, "codigo='" & Prog & "'", "nombre_exe")

		'Select Case Prog
		'    Case "01" : Return "DMSTablas.exe"
		'    Case "04" : Return "DMSReportes.exe"
		'    Case "18" : Return "DMSCartera.exe"
		'    Case "19" : Return "DMSInventarios.exe"
		'    Case "55" : Return "SMDCrm.exe"
		'    Case Else : Return ""
		'End Select

	End Function
	''' <summary>
	''' Pone como default la fila cero de un combo cuando solo tiene una fila
	''' </summary>
	''' <param name="Cb">Nombre del combobox</param>
	''' <remarks></remarks>
	Public Sub Ponga_Default_Combo(ByVal Cb As ComboBox)
		If Cb.Items.Count = 1 Then
			Cb.SelectedIndex = 0
		End If

	End Sub
	'Public Function Filtrar_DataTable(ByVal dt As DataTable, ByVal filter As String, Optional ByVal sort As String = "") As DataTable
	'    Dim rows As DataRow()
	'    Dim dtNew As DataTable
	'    dtNew = dt.Clone()
	'    rows = dt.Select(filter, sort)
	'    For Each dr As DataRow In rows
	'        dtNew.ImportRow(dr)
	'    Next
	'    Return dtNew
	'End Function


	Public Sub Asignar_Paths(ByRef Path_Prog As String, ByRef Path_Temp As String, ByRef DesdeFuente As Boolean)
		Path_Prog = My.Application.Info.DirectoryPath & "\"
		'If LCase(Mid(My.Application.Info.DirectoryPath, 1, 14)) = "y:\Dropbox\SMD\fuentes" Then
		'    Path_Prog = "y:\Dropbox\SMD\bin\"
		'    DesdeFuente = True
		'End If
		'If InStr(LCase(My.Application.Info.DirectoryPath), "fuentes") > 0 And (InStr(LCase(My.Application.Info.DirectoryPath), "smd.net") > 0 Or InStr(LCase(My.Application.Info.DirectoryPath), "dms.net") > 0) Then
		'    Path_Prog = "..\..\..\..\..\bin\"
		'    DesdeFuente = True
		'End If
		'If InStr(LCase(My.Application.Info.DirectoryPath), "fue") > 0 Then
		'    Path_Prog = "..\..\..\..\..\bin\"
		'    DesdeFuente = True
		'End If
		If My.Application.Info.DirectoryPath.Contains("2010") Then
			'Path_Prog = "..\..\..\..\..\bin\"
			Dim i As Integer = InStr(Path_Prog, "Fuentes")
			Path_Prog = Mid(Path_Prog, 1, i - 1) & "bin\"
			DesdeFuente = True
		ElseIf My.Application.Info.DirectoryPath.Contains("2099") Then
			'Path_Prog = "..\..\..\..\..\b99\"
			Dim i As Integer = InStr(Path_Prog, "Fuentes")
			Path_Prog = Mid(Path_Prog, 1, i - 1) & "b99\"
			DesdeFuente = True
		End If

		Try
			'Path_Temp = Environment.GetEnvironmentVariable("TEMP") & "\smd"
			Path_Temp = "c:\smd_files\temp"
			If Not IO.Directory.Exists(Path_Temp) Then
				'MkDir(Path_Temp)
				IO.Directory.CreateDirectory(Path_Temp)
			End If

			Path_Temp = Path_Temp & "\"

		Catch ex As Exception
			Path_Temp = My.Application.Info.DirectoryPath & "\Temp\"
			Mensaje(Idi("Informe a DMS que no pude crear directorio") & ": " & Path_Temp)
		End Try

		Try
			If Not IO.Directory.Exists(Path_Temp & "user") Then
				IO.Directory.CreateDirectory(Path_Temp & "user")
			End If

		Catch ex As Exception
			Mensaje("Informe a DMS que no pude crear directorio: " & Path_Temp & "user")
		End Try


	End Sub



	Private Function Haga_Multiempresa() As Boolean
		Dim TexM As String = DMScr(2) & Idi("Continúa con el mismo usuario y la misma empresa") & ": " & MiEmpresa & "/" & MiCodigo
		'determinar el prefijo de empresa
		'Dim Ini As Integer = InStr(MiEmpresa, "_")
		'If Ini = 0 Then
		'   Mensaje("Empresa no califica para multiempresa. Su código de empresa debe tener un '_'" & TexM)
		'   Return False
		'End If

		Dim CodEmp As String = GetSetting("sysw", "sysw", "empguar", "")
		Dim MarcaGuardada As String = GetSetting("sysw", "sysw", "marcguar", "")
		DebugJD("MarcaGuardada:" & MarcaGuardada & ", marcaexterna:" & MarcaExterna)

		If MarcaGuardada = MarcaExterna Then
			If CodEmp <> "" Then
				GoTo Saltar_Nodo
			Else
				Return False
			End If
		End If

		Try
			If MarcaGuardada = "" Then
				SiReloj()
				Dim Dt As New DataTable
				Abrir_Nodo_1(Dt, "GetEmpresas_MultiEmp '" & MiEmpresa & "'")
				If Fin(Dt) Then
					Mensaje(Idi("No hay empresas agrupadas para") & " " & MiEmpresa & TexM)
					Return False
				End If

				NoReloj(fBusIt)
				CodEmp = Ventana(Dt, Idi("Seleccione empresa en la que desea trabajar") & " (ESC = '" & MiEmpresa & "')", True, "codigo_empresa")

				If CodEmp = "" Then
					CodEmp = MiEmpresa
				End If
				MarcaExterna = Obtenga_Dato(Dt, "codigo_empresa='" & CodEmp & "'", "nodo") 'no cambia de nodo

				'guardarla
				SaveSetting("sysw", "sysw", "marcguar", MarcaExterna)
				SaveSetting("sysw", "sysw", "empguar", CodEmp)

				If CodEmp = "" Or CodEmp = MiEmpresa Then
					SiReloj(fBusIt)
					Return False
				End If
			Else
				MarcaExterna = MarcaGuardada
			End If


			Dim TexIP As String = Convierta_IP(MarcaExterna)
			SaveSetting("sysw", "sysw", "ip4", TexIP)
			EntroWS = False
			TomarIp3 = True
			DemeNodo()

		Catch ex As Exception
			NoReloj(fBusIt)
			MostrarError("Ppal", "Haga_Multiempresa: Nodo col", ex.Message)
			SiReloj(fBusIt)
			Return False
		End Try


Saltar_Nodo:
		Try
			SiReloj()
			Dim DD As New DataTable
			Abrir(DD, "GetDatosNet5_Servicio '" & CodEmp & "','" & MiCodigo & "'")
			NoReloj()

			If Fin(DD) Then
				Mensaje(Idi("No encontró su código de usuario en la empresa") & " '" & CodEmp & "'." & DMScr(2) & Idi("Ingrese a dicha empresa y cree el código de usuario") & " '" & MiCodigo & "'." & TexM)
				Return False
			End If

			Numero_Empresa = Gdf(DD, "id_emp")
			Usuario = Gdf(DD, "id_usu")
			If UsuarioOriginal = 0 Then
				UsuarioOriginal = Usuario
			End If
			MiEmpresa = CodEmp
			MiEmpresaNombre = CodEmp
			Nit_Empresa = Gdf(DD, "nit")
			IgnorarPermisosUsuarioServicio = False

			SiReloj(fBusIt)

		Catch ex As Exception
			NoReloj()
			Mensaje(ex.Message)
			Return False
		End Try




	End Function













	Public Function Entrar_Usuario_Servicio(ByRef IdInicial As String, ByVal ProgramaInicial As String) As Boolean
		DebugJD("ent_serv:" & SoyServicio & ", IdIni:" & IdInicial)
		If SoyServicio = 2 Then 'caso multiempresa

			If IdInicial = "" Then
				Return Haga_Multiempresa()
			Else
				Return False
			End If
		End If


		Dim fUs As New fUsuarioServicio
		If Usuario = 0 Then
			fUs.CmdCancel.Visible = False
		End If

		fUs.Numero_Empresa = Numero_Empresa
		'fUs.Nodo = Prox.NodoSMD
		fUs.Usuario = Usuario
		fUs.IdCotizaInicial = IdInicial
		fUs.TxtInicial.Text = IdInicial.ToString
		fUs.Sector_Empresa = Sector_Empresa
		fUs.Nit_Empresa = Nit_Empresa

		Dim HayPant As Boolean = False
		If fSpl.Visible Then
			HayPant = True
			Pantalla_Splash(True) 'cerrarla
		End If
		'---------------------------------------------------------------------
		fUs.ShowDialog()
		'---------------------------------------------------------------------
		If HayPant Then
			Pantalla_Splash() 'volver a abrirla
		End If

		DebugJD("salio usu serv: " & Ppal.Ws.Url)
		DebugJD("ipfija: " & GetSett("Conecc", "ipfija", ""))
		DebugJD("ip4: " & GetSetting("sysw", "sysw", "ip4", ""))


		'Ppal.EntroWS = False
		'Dim dt As New DataTable
		'Abrir(dt, "select top 1 id from cot_bodega")
		'DebugJD("leyo bodega: " & Ppal.Ws.Url)

		If fUs.Tag = "N" Then
			Usuario = 0
			Return False
		Else
			Numero_Empresa = fUs.Numero_Empresa
			Nodo = fUs.Nodo
			Usuario = fUs.Usuario
			If UsuarioOriginal = 0 Then
				UsuarioOriginal = Usuario
			End If
			IdInicial = fUs.IdCotizaInicial
			Sector_Empresa = fUs.Sector_Empresa
			Nit_Empresa = fUs.Nit_Empresa
			ProgramaInicial = ""
			If fUs.Tag = "" Then 'seguir con dms
				Return False
			Else
				Return True
			End If
		End If

	End Function
	''' <summary>
	''' Aproximar valores a una base dada. 
	''' Ejemplos:
	'''   Aproximar(25360,100)
	'''   resultado=$25,400
	'''   Aproximar(25325,100)
	'''   resultado=$25,300
	''' </summary>
	''' <param name="ValorAproximar">Valor a aproximar</param>
	''' <param name="BaseAproximacion"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function Aproximar(ByVal ValorAproximar As Double, ByVal BaseAproximacion As Short)

		If ValorAproximar = 0 Or BaseAproximacion = 0 Then
			Return ValorAproximar
		End If

		Dim NuevoValor As Double = Int(ValorAproximar / BaseAproximacion) * BaseAproximacion

		If ValorAproximar - NuevoValor > (BaseAproximacion / 2) Then
			NuevoValor += BaseAproximacion
		End If

		Return NuevoValor


	End Function
	Public Sub Llenar_Lotes(ByVal CbLote As ComboBox, ByVal Dt As DataTable)
		CbLote.Items.Clear()
		For I As Integer = 0 To Dt.Rows.Count - 1

			CbLote.Items.Add(New DataDescription(Gdf(Dt, I, "id_cot_item_lote"), Gdf(Dt, I, "lote") & IIf(Gdf(Dt, I, "stock") Is System.DBNull.Value, "", " (" & ValD(Gdf(Dt, I, "stock")) & ")")))
		Next

	End Sub
	Public Sub Llenar_Lotes_Nuevo(ByVal CbLote As ComboBox, ByVal Lote As String)
		CbLote.Items.Add(New DataDescription(0, Lote))
		CbLote.SelectedIndex = CbLote.Items.Count - 1

	End Sub
	''' <summary>
	''' Obtiene un dato de un DataTable
	''' </summary>
	''' <param name="DataTabla">Nombre del datatable</param>
	''' <param name="CriterioWhere">Instrucción Where de SQL</param>
	''' <param name="NombreCampoDevolver">Nombre del campo a devolver</param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function Obtenga_Dato(ByVal DataTabla As DataTable, ByVal CriterioWhere As String, ByVal NombreCampoDevolver As String)

		'devuelve un solo campo de un datatable

		Dim Dr() As DataRow
		Dr = DataTabla.Select(CriterioWhere)
		If Dr.Length = 0 Then
			Return System.DBNull.Value
		Else
			Return Dr(0).Item(NombreCampoDevolver)
		End If

	End Function
	Public Function Obtenga_Dato_Item(ByVal CodigoItem As String, ByVal NombreCampoDevolver As String)

		fBusIt.Traer_Item_Real_Time(CodigoItem)

		'devuelve un solo campo de un datatable

		Dim Dr As DataRow
		Dr = DtItem.Rows.Find(CodigoItem)
		If Dr Is Nothing Then
			Return System.DBNull.Value
		Else
			Return Dr(NombreCampoDevolver)
		End If

	End Function
	''' <summary>
	''' Obtiene un dato de un Store Procedure
	''' </summary>
	''' <param name="StoreProcedure">Nombre del procedimiento con sus parámetros</param>
	''' <param name="CriterioWhere">Instrucción Where de SQL</param>
	''' <param name="NombreCampoDevolver">Nombre del campo a devolver</param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function Obtenga_Dato(ByVal StoreProcedure As String, ByVal CriterioWhere As String, ByVal NombreCampoDevolver As String)

		Dim DataTabla As New DataTable
		Abrir(DataTabla, StoreProcedure)

		'devuelve un solo campo de un datatable

		Dim Dr() As DataRow
		Dr = DataTabla.Select(CriterioWhere)
		If Dr.Length = 0 Then
			Return System.DBNull.Value
		Else
			Return Dr(0).Item(NombreCampoDevolver)
		End If

	End Function
	''' <summary>
	''' Busca terceros con contacto o solo tercero
	''' </summary>
	''' <param name="Numero_Empresa">Numero empresa</param>
	''' <param name="Sector_Empresa">Sector de la empresa</param>
	''' <param name="IdCli">Id del tercero</param>
	''' <param name="RazonSocial">Razón social</param>
	''' <param name="IdContacto">Id del contacto</param>
	''' <param name="Nombre">Nombre contacto</param>
	''' <param name="IdZona">Id zona</param>
	''' <param name="IdZonaSub">Id subzona</param>
	''' <remarks></remarks>
	Public Sub Buscar_Cliente(ByVal Numero_Empresa As Integer, ByVal Sector_Empresa As Integer, ByRef IdCli As Integer, ByRef RazonSocial As String, ByRef IdContacto As Integer, ByRef Nombre As String, Optional ByRef IdZona As Integer = 0, Optional ByRef IdZonaSub As Integer = 0)
		Static fBusCli As New fBuscarCliente

		fBusCli.Numero_Empresa = Numero_Empresa
		fBusCli.Sector_Empresa = Sector_Empresa

		IdCli = 0
		RazonSocial = ""
		IdContacto = 0
		Nombre = ""

		fBusCli.ShowDialog()

		IdCli = fBusCli.IdCli_Out
		RazonSocial = fBusCli.Razon_Out
		IdContacto = fBusCli.IdCon_Out
		Nombre = fBusCli.Nombre_Out
		IdZona = fBusCli.Zona_Out
		IdZonaSub = fBusCli.Zona_Sub_Out

	End Sub
	'Public Sub Validar_Combo_KeyDown(ByVal Combo As ComboBox)
	'    Try

	'        Combo.DroppedDown = False

	'    Catch

	'    End Try

	'End Sub
	'Public Function Buscar_Texto_Combo(ByRef Combo As ComboBox) As Integer
	'    Try
	'        Dim Val As Integer = -1
	'        For i As Integer = 0 To Combo.Items.Count - 1
	'            If Combo.Text.ToUpper = Combo.Items(i).ToString.ToUpper Then
	'                Val = i
	'                Exit For
	'            End If
	'        Next

	'        Return Val

	'    Catch ex As Exception
	'        Return -1

	'    End Try

	'End Function
	''' <summary>
	''' Protege la comilla simple en un texto que se va a grabar en SQL
	''' </summary>
	''' <param name="TextoConPosiblesComillas">Texto original</param>
	''' <returns>Retorna el mismo texto pero con la comilla protegida</returns>
	''' <remarks></remarks>
	Public Function ProtejaComilla(ByVal TextoConPosiblesComillas As String) As String
		Try
			Return Replace(TextoConPosiblesComillas, "'", "''")
		Catch ex As Exception
			Return TextoConPosiblesComillas
		End Try

	End Function
	''' <summary>
	''' Enviar un mensaje a un usuario a través del chat Advance
	''' </summary>
	''' <param name="Usuario_Destino">Id del usuario destino</param>
	''' <param name="Mensaje">Mensaje a enviar</param>
	''' <param name="Usuario_Origen">Usuario de origen</param>
	''' <remarks></remarks>
	Public Sub Mensajeria_DMS(ByRef Usuario_Destino As Integer, ByRef Mensaje As String, ByRef Usuario_Origen As Integer)
		If NoEntrar() Then Exit Sub

		'truco para otro nodo
		Dim OtrNod As Boolean = False
		If Usuario_Origen < 0 Then
			OtrNod = True
			Usuario_Origen *= -1
		End If

		DebugJD("Enviando mensaje a usuario " & Usuario_Destino.ToString)

		'Dim Mensa As String = vbNewLine & Replace(Mensaje, "'", "''")
		Dim Mensa As String = vbNewLine & Replace(Mensaje, "'", "''")
		Dim Eje As String = ""
		For I = 0 To 10 'maximo 10 mensajes
			If Mid(Mensa, (I * 500 + 1), 500).Trim = "" Then Exit For
			If Usuario_Destino = 0 Then 'es mensaje para desarrolladores
				Eje += "Exec PutMensajes_Desarrollo " & Usuario_Origen.ToString & "," & "'" & Mid(Mensa, (I * 500 + 1), 500).Trim & "'" & DMScr()
			Else 'es normal
				Eje += "Exec PutMensajes " & Usuario_Origen.ToString & "," & Usuario_Destino.ToString & "," & "'" & Mid(Mensa, (I * 500 + 1), 500).Trim & "'" & DMScr()
			End If
		Next

		If OtrNod Then
			Abrir_Nodo_1(New DataSet, Eje)
		Else
			Ejecutar(Eje)
		End If

		DebugJD("  --> Mensaje Enviado")

	End Sub
	Public Sub EnviarMensajeEspecial(UsuarioOrigen As Integer, Categoria As Integer, TextoMensaje As String)

		Try
			Dim fb As New fBatch
			fb.Ejecutar_Algo_Batch("Exec PutMensajesEsp " & UsuarioOrigen.ToString & "," & Categoria.ToString & "," & "'" & TextoMensaje & "'")
			fb.Dispose()

		Catch ex As Exception

		End Try

	End Sub
	Public Function TraigaImagenFromDB(ByVal Id As Integer, ByVal NombreTabla As String, ByVal NombreCampo As String) As System.Drawing.Image
		If NoEntrar() Then Return Nothing

		'Mensaje("Voy a leer: " & Ppal.Ws.Url)

		Dim Dt As New DataTable
		Abrir(Dt, "GetImagen", Id.ToString, NombreTabla, NombreCampo)

		'Mensaje("sali de leer: " & Ppal.Ws.Url)

		If Dt.Rows.Count = 0 Then Return Nothing

		If Gdf(Dt, 0, NombreCampo) Is System.DBNull.Value Then
			Return Nothing
		Else
			'Try : Kill("temp_*.jpg") : Catch ex As Exception : End Try

			Dim Nomf As String = "temp_" & Strings.Format(Now, "yyMMddhhmmss") & ".jpg"
			SalvarFoto(CType(Gdf(Dt, 0, "imagen"), Byte()), Nomf, "temp_*.jpg")
			If Dir(Nomf, FileAttribute.Archive) <> "" Then 'la foto está en disco
				Return System.Drawing.Image.FromFile(Nomf, False)
			Else
				Return Nothing
			End If
		End If

	End Function
	'Public Sub MostrarErrorNuevo(ByVal Ex As Exception)
	'    'MostrarErrorGrabando(String_Version(), Usuario, Programa, Rutina, TextoError)

	'    Dim Asa() As String = Ex.StackTrace.Split(vbNewLine)
	'    Dim TexErr As String = Asa(Asa.Length - 1).Trim()
	'    If InStr(TexErr, "(") > 0 Then
	'        TexErr = Mid(TexErr, 1, InStr(TexErr, "(") - 1)
	'    End If

	'    TexErr = vbNewLine & TexErr & DMScr() & "Versión " & String_Version_Editada() & DMScr() & ex.Message & EsIngles

	'    Try
	'        Dim Dt As New DataTable
	'        Abrir(Dt, "PutError2", Usuario.ToString, TexErr)

	'        'If Gdf(Dt, 0, "id") = 0 And (Usuario = 2 Or Usuario = 128 Or Usuario = 99) Then 'no ignorar el error
	'        '    Mensaje("Ha sucedido un error." & DMScr(2) & TexErr)
	'        'End If
	'        If Gdf(Dt, 0, "id") = 0 Then
	'            Mensaje("Operación no fue completada con éxito. Intente nuevamente" & DMScr(2) & TexErr)
	'        End If

	'        Dt.Dispose()


	'    Catch ex1 As Exception

	'    End Try


	'End Sub
	''' <summary>
	''' Muestra un error y lo envía a DMS por el chat
	''' </summary>
	''' <param name="Programa">Nombre del programa que produce el error.  Form.Name</param>
	''' <param name="Rutina">Nombre de la Sub o Function donde sucedió el error</param>
	''' <param name="TextoError">Texto del error</param>
	''' <param name="NoUsar"></param>
	''' <remarks></remarks>
	Public Sub MostrarError(ByVal Programa As String, ByVal Rutina As String, ByVal TextoError As String, Optional ByVal NoUsar As Boolean = True)
		'MostrarErrorGrabando(0, Usuario, Programa, Rutina, TextoError)


		If NoEntrar() Then Exit Sub

		If Ver_Error_Raise(TextoError) = "" Then
			Exit Sub
		End If


		'sugerido por Milton: PARA SABER SI NO TIENE INTERNET
		'no funciona bien siempre, se quita
		'Dim Tex2 As String = ""
		'If My.Computer.Network.IsAvailable() Then 'si no hay red
		'    Try
		'        SiReloj()
		'        If My.Computer.Network.Ping("www.google.es", 500) = False Then
		'            Tex2 = "*** Falla de Internet ***" & DMScr(15) & TextoError
		'        End If

		'    Catch 'si no hay acceso a internet
		'        Tex2 = "*** Falla de Internet ***" & DMScr(15) & TextoError
		'    End Try
		'    NoReloj()

		'Else
		'    Tex2 = "*** No está conectado a Internet ***" & DMScr(15) & TextoError
		'End If
		'If Tex2 <> "" Then
		'    Mensaje_TopMost(Tex2, "Error de Internet")
		'    Exit Sub
		'End If
		'/sugerido por Milton

		Try
			Dim fil As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path_Prog & "SMDMenu.exe")

			'If MarcaExterna = "" Then
			'    MarcaExterna = BuscarIpFija()
			'End If
			'Dim Marca As String = GetSetting("sysw", "sysw", "name", "")
			'If Marca <> "" Then
			'    If GetSetting("sysw", "sysw", "ip2", "") = "" Then
			'        Marca = ""
			'    End If
			'Else
			'    Marca = Prox.NodoSMD.ToString
			'End If

			Dim EsPrueba As String = ""
			'If GetSetting("sysw", "sysw", "wspru", "0") = "1" Then
			'    EsPrueba = "*Pru*"
			'End If
			If Ws.Url.Contains("_pru") Then
				EsPrueba = "*Pru*"
			End If

			Dim TexErr As String = "www.smd.em." & MiEmpresa & "." & MiCodigo & " /N:" & MarcaExterna & EsPrueba & IIf(SoyServicio, "/US:" & NomEquipo, "") & DMScr() & My.Application.Info.Title.ToString & " " & String_Version_Editada() & "(" & fil.FileVersion & ")" & DMScr() & Programa & DMScr() & Rutina & DMScr() & TextoError

			If DesdeFuente Or MarcaExterna = "local" Then
				Mensaje_TopMost("Error" & DMScr(2) & TexErr)
			Else
				Try
					Dim Ds As New DataSet
					Dim CU As Integer = 1
					'si en colombia o esta desconectado conserver el usuario real
					If MarcaExterna = "col" Or EstoyDesconectadoNuevo Then
						CU = Usuario
					End If
					Abrir_Nodo_1(Ds, "PutError3 '" & Strings.Left(TexErr, 950).Replace("'", "''") & "',1," & CU.ToString)

					'End If
					SonarWAV("error")
					'If Gdf(Ds.Tables(0), 0, "id") = 0 Or EstaEnLista(Usuario, 2, 128, 34, 3172, 107) Then 'no ignorar el error
					'    Mensaje_TopMost("Ha sucedido un error." & DMScr(2) & TexErr)
					'End If
					'vamos a mostrar siempre el error, 18-ago-2016, jdms
					Mensaje_TopMost(Idi("Ha sucedido un error.", "An error has happened.") & DMScr(2) & TexErr)


				Catch ex As Exception
					Mensaje_TopMost("Ha sucedido un error." & DMScr(2) & TexErr)

				End Try

			End If

		Catch ex As Exception

		End Try

	End Sub
	''' <summary>
	''' Pide una fecha por pantalla
	''' </summary>
	''' <param name="Titulo">Título de la ventana</param>
	''' <param name="FechaInicial">Fecha default</param>
	''' <param name="MostrarHora">True: Captura la hora</param>
	''' <returns>Devuelve la fecha seleccionada</returns>
	''' <remarks></remarks>
	Public Function PidaFecha(ByVal Titulo As String, ByVal FechaInicial As Date, Optional ByVal MostrarHora As Boolean = False) As String
		Dim fFe As New fFecha
		fFe.Text = Titulo
		fFe.CbHora.Visible = MostrarHora
		fFe.LblHora.Visible = MostrarHora
		fFe.Mes.SelectionStart = FechaInicial
		fFe.CbHora.Text = Strings.Format(FechaInicial, "HH:mm")
		fFe.ShowDialog()
		Return fFe.Tag

	End Function
	'Public Sub MostrarErrorGrabando(ByVal Version As Integer, ByVal Usuario As Integer, ByVal Programa As String, ByVal Rutina As String, ByVal TextoError As String)

	'End Sub
	''' <summary>
	''' Hace un sonido
	''' ok=sonido de ok
	''' error=sonido de error
	''' </summary>
	''' <param name="FileSonido">Nombre del sonido. e.g. "OK", "error", etc</param>
	''' <param name="EsperarTerminar">True=Espere a que termine de sonar para continuar</param>
	''' <remarks></remarks>
	Public Sub SonarWAV(ByVal FileSonido As String, Optional ByVal EsperarTerminar As Boolean = False)
		Try
			If SilenciarVoz = 0 Then 'no la ha leido, entonces traerla la primera vez
				SilenciarVoz = GetSetting("DMS S.A.", "fC", "silvoz", 2) '2=no silenciar
			End If

			'Dim fVS As New fVerSonido
			'fVS.Show()

			If SilenciarVoz = 1 Then Exit Sub


			Dim Dife As Integer = DateDiff(DateInterval.Second, UltimaHoraSonido, Now)
			'DebugJD("Sonido 1: " & UltimaHoraSonido & ", now=" & Now & ", dife: " & Dife)

			If Dife < 2 Then
				'DebugJD("Sonido 2: " & Dife)
				Exit Sub
			End If

			UltimaHoraSonido = Now
			If LenguajeAdvance = 1 Then
				If File.Exists(Path_Prog & FileSonido & "_eng" & ".wav") Then
					FileSonido = FileSonido & "_eng"
				End If
			End If
			My.Computer.Audio.Play(Path_Prog & FileSonido & ".wav", IIf(EsperarTerminar, AudioPlayMode.WaitToComplete, AudioPlayMode.Background))

		Catch ex As Exception
			'If EstaEnLista(Usuario, 2, 128, 34, 3172, 107) Then
			'    Static YaMostro As Boolean = False
			'    If Not YaMostro Then
			'        YaMostro = True
			'        Mensaje("Sonido " & FileSonido & ": " & ex.Message & EsIngles)
			'    End If
			'End If

		End Try

	End Sub
	'Public Sub MostrarErrorGrabando(ByVal Version As Integer, ByVal Usuario As Integer, ByVal TextoError As String)
	'    If NoEntrar() Then Exit Sub
	'    Try
	'        Dim NueTexto As String
	'        If TextoError.Length > 200 Then
	'            NueTexto = Mid(TextoError, 1, 200) & DMScr() & "..." & DMScr() & Mid(TextoError, TextoError.Length - 80)
	'        Else
	'            NueTexto = TextoError
	'        End If
	'        Dim Dt As New DataTable
	'        Abrir(Dt, "PutError2", Usuario.ToString, "Ver." & Version.ToString & ": " & NueTexto)

	'        If Gdf(Dt, 0, "id") = 0 And (Usuario = 2 Or Usuario = 128 Or Usuario = 99) Then 'no ignorar el error
	'            Mensaje("Ha sucedido un error." & DMScr(2) & NueTexto)
	'        End If

	'        Dt.Dispose()


	'    Catch ex As Exception

	'    End Try

	'End Sub
	''' <summary>
	''' Garantiza que el nombre entrado sea un nombre de archivo válido según su sistema operacional
	''' </summary>
	''' <param name="NombreArchivo">Nombre del archivo a revisar</param>
	''' <returns>Devuelve un nombre de archivo válido quitando los caracteres inválidos</returns>
	''' <remarks></remarks>
	Public Function Garantice_Nombre_Archivo(ByVal NombreArchivo As String) As String
		Try
			Dim Tex As String = NombreArchivo
			Tex = Replace(Tex, "/", " ")
			Tex = Replace(Tex, "\", " ")
			Tex = Replace(Tex, ":", " ")
			Tex = Replace(Tex, "*", " ")
			Tex = Replace(Tex, "?", " ")
			Tex = Replace(Tex, """", " ")
			Tex = Replace(Tex, "<", " ")
			Tex = Replace(Tex, ">", " ")
			Tex = Replace(Tex, "|", " ")

			Return Tex


		Catch ex As Exception
			Return NombreArchivo

		End Try

	End Function
	''' <summary>
	''' Envía un email
	''' </summary>
	''' <param name="NombreFrom">Nombre del remitente</param>
	''' <param name="MailFrom">email del remitente</param>
	''' <param name="NombrePara">Nombre del destinatario</param>
	''' <param name="MailPara">email del destinatario</param>
	''' <param name="Asunto">Asunto</param>
	''' <param name="TextoCorreo">Texto del correo</param>
	''' <param name="ArchivoAdjunto">Opcional nombre del archivo adjunto</param>
	''' <param name="Cc">Con copia email</param>
	''' <param name="Cco">Copia oculta email</param>
	''' <param name="NumeroEmp">Número de la empresa</param>
	''' <param name="IdUsu">Id del usuario que envía</param>
	''' <param name="IdCli">Id del cliente destino del email</param>
	''' <param name="IdCon">Id del contacto destino</param>
	''' <param name="IdOpo">Id del documento adjunto para efectos de auditoría</param>
	''' <param name="IdTabla">Id de la tabla del documento adjunto para efectos de auditoría</param>
	''' <remarks></remarks>
	Public Sub Enviar_Mail(ByVal NombreFrom As String, ByVal MailFrom As String, ByVal NombrePara As String, ByVal MailPara As String,
						   ByVal Asunto As String, ByVal TextoCorreo As String, ByVal ArchivoAdjunto As String,
						   Optional ByVal Cc As String = "", Optional ByVal Cco As String = "",
						   Optional ByVal NumeroEmp As Integer = 0,
						   Optional ByVal IdUsu As Integer = 0,
						   Optional ByVal IdCli As Integer = 0,
						   Optional ByVal IdCon As Integer = 0,
						   Optional ByVal IdOpo As Integer = 0,
						   Optional ByVal IdTabla As Integer = 0)

		Dim Para2 As String = GetSett("fProgramador", "para", "") 'programados

		Try
			If NoEntrar() Then Exit Sub
			Dim fMail As New fEnviarMail

			fMail.LnkVer.Tag = ArchivoAdjunto
			fMail.TxtAsunto.Text = Asunto
			fMail.TxtCC.Text = Cc
			fMail.TxtCCo.Text = Cco
			fMail.TxtDeNombre.Tag = NombreFrom
			fMail.TxtDeMail.Tag = MailFrom
			fMail.TxtMensaje.Text = TextoCorreo
			fMail.TxtParaMail.Text = MailPara.Replace(",", ";")
			fMail.TxtParaNombre.Text = NombrePara

			fMail.Text = "Correo para " & NombrePara

			'datos para grabar el evento
			fMail.NumeroEmp = NumeroEmp
			fMail.IdUsu = IdUsu
			fMail.IdCli = IdCli
			fMail.IdCon = IdCon
			fMail.IdOpo = IdOpo
			fMail.IdTabla = IdTabla



			'ver si son reportes programados
			If Para2 <> "" Then
				Dim Ma As String = GetSett("fProgramador", "mail", "0") 'programados
				Dim Ch As String = GetSett("fProgramador", "chat", "0") 'programados
				If Ch = "1" Then
					fMail.Enviar_Chat_Programado()
				End If
				SaveSett("fProgramador", "para", "") 'por si acaso
				If Ma = "0" Then
					Exit Sub
				End If
				fMail.EnvioPorgramado = True
				fMail.TxtParaMail.Text = Para2
				fMail.EnviarCorreo()
			Else
				fMail.WindowState = FormWindowState.Normal
				fMail.TopMost = True
				fMail.ShowDialog()
			End If




		Catch ex As Exception
			If Para2 <> "" Then
				SaveSett("fProgramador", "error", ex.Message) 'por si acaso
			Else
				Mensaje(ex.Message)
			End If

		End Try


	End Sub

	Public Function EscalarImagen(ByVal PictuDestino As PictureBox, ByVal PictuOrigen As PictureBox, Optional ByVal HacerZoom As Boolean = False) As Image
		'esta función ya no se necesita, ahora se puede usar ZOOM en las propiedades de la imagen

		Try
			Dim Imagen As System.Drawing.Image = PictuOrigen.Image

			' Para calcular la escala
			Dim HScale As Double = PictuDestino.Width / Imagen.Width
			Dim VScale As Double = PictuDestino.Height / Imagen.Height

			Dim Escala As Double

			If (VScale >= HScale) Then
				Escala = HScale
			Else
				Escala = VScale
			End If


			' si la imagen es mas chica (ancho y alto ) que el picture .. se deja del tamaño real
			If Not HacerZoom Then
				If (Imagen.Width < PictuOrigen.Width) And (Imagen.Height < PictuOrigen.Height) Then
					Escala = 1
				End If
			End If

			Dim CallBack As New System.Drawing.Image.GetThumbnailImageAbort(AddressOf MycallBack)

			' retornar la imagen

			Return Imagen.GetThumbnailImage(
								(CInt(Imagen.Width * Escala)),
								(CInt(Imagen.Height * Escala)),
								 CallBack,
								 IntPtr.Zero)


		Catch ex As OutOfMemoryException
			'Debug.Print(ex.Message & EsIngles)
		End Try
		Return Nothing


	End Function
	Private Function MycallBack() As Boolean
		Return False
	End Function
	''' <summary>
	''' Abre el programa de correo ofreciendo el email dado aquí como destinatario
	''' </summary>
	''' <param name="To">emal destino</param>
	''' <param name="Subject">Asunto</param>
	''' <param name="Message">Mensaje</param>
	''' <remarks></remarks>
	Public Sub AbrirDefaultMail(ByVal [To] As String, Optional ByVal Subject As String = "", Optional ByVal Message As String = "")
		Try
			Dim psi As New ProcessStartInfo()
			psi.UseShellExecute = True
			psi.FileName = "mailto:" & HttpUtility.UrlEncode([To]) & IIf(Subject <> "", "?subject=" & Subject, "") & IIf(Message <> "", "&body=" & Message, "")
			Process.Start(psi)
		Catch ex As Exception
			Throw _
				New ApplicationException("Default mail client could not be started.", ex)
		End Try
	End Sub

	''' <summary>
	''' Extrae algo del setting
	''' </summary>
	''' <param name="Seccion">Sección</param>
	''' <param name="Llave">Llave</param>
	''' <param name="ValorDefault">Valor default</param>
	''' <returns>Valor encontrado</returns>
	''' <remarks></remarks>
	Public Function GetSett(ByVal Seccion As String, ByVal Llave As String, ByVal ValorDefault As String) As String

		Return GetSetting(DiegoSet, Seccion, Llave, ValorDefault)


	End Function

	''' <summary>
	''' Graba algo en el setting
	''' </summary>
	''' <param name="Seccion">Sección</param>
	''' <param name="Llave">Llave</param>
	''' <param name="Valor">Valor a grabar</param>
	''' <remarks></remarks>
	Public Sub SaveSett(ByVal Seccion As String, ByVal Llave As String, ByVal Valor As String)
		'If NoEntrar() Then Exit Sub

		Try
			SaveSetting(DiegoSet, Seccion, Llave, Valor)

		Catch

		End Try


	End Sub
	''' <summary>
	''' Muestra una forma bajo el estándar de Advance
	''' </summary>
	''' <param name="Forma">Forma</param>
	''' <param name="TipoDialogo">True=Tipo diálogo</param>
	''' <param name="TituloPrograma">Título del programa</param>
	''' <remarks></remarks>
	Public Sub MostrarForma(ByRef Forma As Form, Optional ByVal TipoDialogo As Boolean = False, Optional ByVal TituloPrograma As String = "")
		MostrarForma3(Forma.Icon, Forma, TipoDialogo, TituloPrograma)

		'Try
		'    If TituloPrograma <> "" Then
		'        Forma.Text = TituloForma(TituloPrograma, Forma)
		'    End If


		'    If SoyHandHeld() Then
		'        Forma.WindowState = FormWindowState.Maximized
		'    End If

		'    If TipoDialogo Then
		'        Forma.ShowDialog()
		'    Else
		'        Forma.Show()
		'        If Forma.WindowState = FormWindowState.Minimized Then
		'            Forma.WindowState = FormWindowState.Normal
		'        End If
		'        Forma.BringToFront()

		'        'TODO: esto lo quito por un tiempo: 12-oct-2012, jdms
		'        'TODO: esto lo vuelvo a poner por un tiempo: 10-mar-2012, jdms
		'        Forma.TopMost = True
		'        Forma.TopMost = False
		'        Forma.Focus()
		'        'Me.Show()
		'        'Me.Focus()

		'    End If

		'Catch ex As Exception
		'    Mensaje("No se pudo abrir la ventana: " & ex.Message & EsIngles)

		'End Try


	End Sub
	Public Sub MostrarForma3(IconoAplicacion As Icon, ByRef Forma As Form, Optional ByVal TipoDialogo As Boolean = False, Optional ByVal TituloPrograma As String = "")
		Try
			If TituloPrograma <> "" Then
				Forma.Text = TituloForma(TituloPrograma, Forma)
			End If

			If Forma.Icon Is fBusIt.Icon Then
				Forma.Icon = IconoAplicacion
			End If

			If SoyHandHeld() Then
				Forma.WindowState = FormWindowState.Maximized
			End If

			If TipoDialogo Then
				Forma.ShowDialog()
			Else
				Forma.Show()
				If Forma.WindowState = FormWindowState.Minimized Then
					Forma.WindowState = FormWindowState.Normal
				End If
				Forma.BringToFront()

				'TODO: esto lo quito por un tiempo: 12-oct-2012, jdms
				'TODO: esto lo vuelvo a poner por un tiempo: 10-mar-2012, jdms
				Forma.TopMost = True
				Forma.TopMost = False
				Forma.Focus()
				'Me.Show()
				'Me.Focus()

			End If

		Catch ex As Exception
			Mensaje("No se pudo abrir la ventana: " & ex.Message & EsIngles())

		End Try


	End Sub

	''' <summary>
	''' Controlar el tamaño de un texto RichTextBox
	''' </summary>
	''' <param name="TxtRich">Nombre del Rich</param>
	''' <param name="TamañoMaximoEnKB">Tamaño máximo deseado</param>
	''' <param name="Aplicacion">Nombre de la aplicación</param>
	''' <returns>Verdadero o falso</returns>
	''' <remarks></remarks>
	Public Function SePasa(ByRef TxtRich As RichTextBox, ByRef TamañoMaximoEnKB As Integer, ByRef Aplicacion As String) As Boolean
		Try
			Dim TamañoActual As Integer
			TamañoActual = TxtRich.Rtf.ToString.Length
			If TamañoActual > ValD(TamañoMaximoEnKB) * 1024 Then
				Dim Texto As String = "Tamaño del texto de " & Aplicacion & " es de " & Strings.Format(TamañoActual / 1024, "###,##0") & "KB y por asuntos administrativos está limitado a " & TamañoMaximoEnKB & "KB. Reduzca la cantidad de texto e intente de nuevo. No incluya gráficas dentro de este texto, pues consumen mucho espacio ya que no son comprimidas."
				If UsuarioOriginal = 2 Then
					If Not Pregunte(Texto & DMScr(2) & "Por ser JD podrá continuar.  Desea continuar así?") Then Return True
				Else
					Mensaje(Texto)
					Return True
				End If
			End If

			Return False

		Catch ex As Exception
			Mensaje("No se puede verificar tamaño del texto: " & ex.Message & EsIngles())
			Return True
		End Try


	End Function
	''' <summary>
	''' Controlar el tamaño de un texto
	''' </summary>
	''' <param name="Texto">Texto</param>
	''' <param name="TamañoMaximoEnKB">Tamaño máximo deseado</param>
	''' <param name="Aplicacion">Nombre de la aplicación</param>
	''' <returns>Verdadero o falso</returns>
	''' <remarks></remarks>
	Public Function SePasa(ByRef Texto As String, ByRef TamañoMaximoEnKB As Integer, ByRef Aplicacion As String) As Boolean
		Try
			Dim TamañoActual As Integer
			TamañoActual = Len(Texto)
			If TamañoActual > ValD(TamañoMaximoEnKB) * 1024 Then
				Mensaje(Idi("Tamaño del texto de") & " " & Idi(Aplicacion) & " = " & Strings.Format(TamañoActual / 1024, "###,##0") & "KB " & Idi("y por asuntos administrativos está limitado a") & " " & TamañoMaximoEnKB & "KB. " &
							Idi("Reduzca la cantidad de texto e intente de nuevo. No incluya gráficas dentro de este texto, pues consumen mucho espacio ya que no son comprimidas"))
				Return True
			End If

			Return False

		Catch ex As Exception
			Mensaje("No se puede verificar tamaño del texto: " & ex.Message & EsIngles())
			Return True
		End Try


	End Function
	''' <summary>
	''' Obsoleto: Extrae el primer dato de la primera fila del procedimiento almacenado. 
	''' Mejor usar Obtenga_Dato
	''' </summary>
	''' <param name="StoredProcedureName"></param>
	''' <param name="Par1"></param>
	''' <param name="Par2"></param>
	''' <param name="Par3"></param>
	''' <param name="Par4"></param>
	''' <param name="Par5"></param>
	''' <param name="Par6"></param>
	''' <param name="Par7"></param>
	''' <param name="Par8"></param>
	''' <param name="Par9"></param>
	''' <param name="Par10"></param>
	''' <param name="Par11"></param>
	''' <param name="Par12"></param>
	''' <param name="Par13"></param>
	''' <param name="Par14"></param>
	''' <param name="Par15"></param>
	''' <param name="Par16"></param>
	''' <param name="Par17"></param>
	''' <param name="Par18"></param>
	''' <param name="Par19"></param>
	''' <param name="Par20"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function Extraiga_Dato2(ByRef StoredProcedureName As String, Optional ByRef Par1 As String = "", Optional ByRef Par2 As String = "", Optional ByRef Par3 As String = "", Optional ByRef Par4 As String = "", Optional ByRef Par5 As String = "", Optional ByRef Par6 As String = "", Optional ByRef Par7 As String = "", Optional ByRef Par8 As String = "", Optional ByRef Par9 As String = "", Optional ByRef Par10 As String = "", Optional ByRef Par11 As String = "", Optional ByRef Par12 As String = "", Optional ByRef Par13 As String = "", Optional ByRef Par14 As String = "", Optional ByRef Par15 As String = "", Optional ByRef Par16 As String = "", Optional ByRef Par17 As String = "", Optional ByRef Par18 As String = "", Optional ByRef Par19 As String = "", Optional ByRef Par20 As String = "") As Object
		If NoEntrar() Then Return Nothing


		'no debe poner on-error aqui

		Dim Rec As New DataTable


		Abrir(Rec, StoredProcedureName, Par1, Par2, Par3, Par4, Par5, Par6, Par7, Par8, Par9, Par10, Par11, Par12, Par13, Par14, Par15, Par16, Par17, Par18, Par19, Par20)

		If Fin(Rec) Then
			Extraiga_Dato2 = System.DBNull.Value
		Else
			Extraiga_Dato2 = "" & Rec.Rows(0).Item(0).ToString
		End If

		Rec.Dispose()

		Exit Function

	End Function
	''' <summary>
	''' Obsoleto: Extrae el primer dato de la primera fila del procedimiento almacenado. 
	''' Mejor usar Obtenga_Dato
	''' </summary>
	''' <param name="Sql"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function ExtraigaDato(ByVal Sql As String)
		If NoEntrar() Then Return Nothing


		Dim Dt As DataTable = New DataTable
		Abrir(Dt, Sql)
		If Fin(Dt) Then
			Dt.Dispose()
			Return ""
		End If

		Return Dt.Rows(0).Item(0)

		Dt.Dispose()

	End Function


	''' <summary>
	''' Para validar cuando un comboBox NO tiene contenido, es decir está en -1 el ListIndex muestra en pantalla el mensaje enviado por parámetros y se queda en el campo
	''' </summary>
	''' <param name="TextoError">Texto ha mostrar si no ha seleccionado nada</param>
	''' <param name="Combo">Nombre del ComboBox</param>
	''' <returns>True=No tiene nada seleccionado</returns>
	''' <remarks></remarks>
	Public Function No_Hay_Combo(ByRef TextoError As String, ByRef Combo As ComboBox) As Boolean

		' JDMS OCT/06
		' 

		If Combo.SelectedIndex < 0 Then
			No_Hay_Combo = True
			If TextoError <> "" Then
				Mensaje(TextoError)
				Try : Combo.Focus() : Catch ex As Exception : End Try
			End If
			Return True
		End If

		Return False

	End Function
	''' <summary>
	''' Obsoleto: Poner el index en un combobox llenado al estilo vb6. Usar pongaIndex
	''' </summary>
	''' <param name="Cbo"></param>
	''' <param name="Dato_ItemData"></param>
	''' <remarks></remarks>
	Public Sub PongaIndexVB(ByRef Cbo As ComboBox, ByVal Dato_ItemData As Integer)

		'If Dato_ItemData = 0 Then
		'    Cbo.SelectedIndex = -1
		'    Exit Sub
		'End If

		Dim I As Integer

		For I = 0 To Cbo.Items.Count - 1
			Dim J As Integer = VB6.GetItemData(Cbo, I)
			If J = Dato_ItemData Then
				Cbo.SelectedIndex = I
				Exit Sub
			End If
		Next I

		Cbo.SelectedIndex = -1

	End Sub
	' ''' <summary>
	' ''' Llenar un ListBox a partir de un datatable
	' ''' </summary>
	' ''' <param name="Lst">Nombre del ListBox</param>
	' ''' <param name="Dt">Nombre del datatable</param>
	' ''' <param name="NombreId">Nombre del campo que servirá como ID para el listbox</param>
	' ''' <param name="NombreDes">Campo para la descripción</param>
	' ''' <param name="ClausulaWhere">Criterio de seleción SQL</param>
	' ''' <param name="CampoOrdenamiento">Ordenado por cuál campo</param>
	' ''' <remarks></remarks>
	'Public Sub Llene_ListBox(ByRef Lst As ListBox, ByVal Dt As DataTable, ByVal NombreId As String, ByVal NombreDes As String, Optional ByVal ClausulaWhere As String = "", Optional ByVal CampoOrdenamiento As String = "")

	'    Lst.Items.Clear()
	'    If Dt.Rows.Count = 0 Then Exit Sub

	'    Dim I As Integer = 0
	'    If ClausulaWhere <> "" Then
	'        Dim Dr() As DataRow
	'        If CampoOrdenamiento <> "" Then
	'            Dr = Dt.Select(ClausulaWhere, CampoOrdenamiento)
	'        Else
	'            Dr = Dt.Select(ClausulaWhere)
	'        End If

	'        For Each row As DataRow In Dr
	'            Lst.Items.Add(New DataDescription(row.Item(NombreId), row.Item(NombreDes)))
	'            I = I + 1
	'        Next
	'    Else
	'        For I = 0 To Dt.Rows.Count - 1
	'            Lst.Items.Add(New DataDescription(Dt.Rows(I).Item(NombreId), Dt.Rows(I).Item(NombreDes)))
	'        Next
	'    End If

	'End Sub

	Public Function QuiteDuplicados(DtOrig As DataTable, IdNom As String, DesNom As String) As DataTable
		Dim Ant As String = ""
		Dim Dt As New DataTable
		Dt.Columns.Add(IdNom)
		Dt.Columns.Add(DesNom)
		For Each Fi As DataRow In Filtrar_DataTable(DtOrig, "", DesNom).Rows
			If Ant <> Fi(DesNom) Then 'agregar este
				Ant = Fi(DesNom)
				Dt.Rows.Add(Fi(IdNom), Fi(DesNom))
			End If
		Next

		Return Dt

	End Function
	Public Function QuiteDuplicados2(DtOrig As DataTable, IdNom As String, DesNom As String, Optional ClausulaWhere As String = "") As DataTable
		Dim Ant As String = ""
		Dim Dt As New DataTable
		Dt.Columns.Add(IdNom)
		Dt.Columns.Add(DesNom)
		For Each Fi As DataRow In Filtrar_DataTable(DtOrig, ClausulaWhere, DesNom).Rows
			If Ant <> "" & Fi(DesNom) Then 'agregar este
				Ant = "" & Fi(DesNom)
				Dt.Rows.Add(Fi(IdNom), "" & Fi(DesNom))
			End If
		Next

		Return Dt

	End Function


	''' <summary>
	''' Llenar un combobox o un listbox a partir de un Datatable
	''' </summary>
	''' <param name="Combo">Nombre del combo o del list</param>
	''' <param name="Dt">Nombre del datatable</param>
	''' <param name="NombreId">Nombre del campo Id para cada fila</param>
	''' <param name="NombreDes">Campo para la descripción</param>
	''' <param name="ClausulaWhere">Criterio de selección SQL</param>
	''' <param name="CampoOrdenamiento">Campo para ordenamiento</param>
	''' <param name="TextoIdCero">Qué texto poner si usa Id=0</param>
	''' <param name="IdInicial">En cuál Id arrancar el combo o list</param>
	''' <param name="PermiteRepetir">Permite que haya datos repetidos o debe poner uno solo</param>
	''' <param name="MaximoFilasCargar">Cantidad máxima de filas a cargar</param>
	''' <remarks></remarks>
	Public Sub Llene_Combo5(ByRef Combo As Object, ByVal Dt As DataTable,
							ByVal NombreId As String, ByVal NombreDes As String,
							Optional ByVal ClausulaWhere As String = "",
							Optional ByVal CampoOrdenamiento As String = "",
							Optional ByVal TextoIdCero As String = "",
							Optional ByVal IdInicial As Integer = -1,
							Optional ByVal PermiteRepetir As Boolean = True,
							Optional ByVal MaximoFilasCargar As Integer = 0)

		Combo.Items.Clear()

		If TextoIdCero <> "" Then
			Combo.Items.Add(New DataDescription(0, Idi(TextoIdCero)))
			If IdInicial = 0 Then Combo.SelectedIndex = 0
			'Try
			'Catch ex As Exception 'este error sucede porque al poner la posición cero del combo, dispara el evento SelectedIndexChange el cual tiene cualquier error que es capturado en este lugar
			'End Try
		End If

		If Dt.Rows.Count = 0 Then Exit Sub

		Dim DesAnt As String = "@@#$%"

		Dim NombreDesVarios() As String = NombreDes.Split("+")
		If NombreDesVarios.Length > 1 Then PermiteRepetir = True

		Dim I As Integer = 0
		Dim Dr() As DataRow
		If CampoOrdenamiento <> "" Then
			Dr = Dt.Select(ClausulaWhere, CampoOrdenamiento)
		Else
			Dr = Dt.Select(ClausulaWhere)
		End If

		For Each row As DataRow In Dr
			If NombreId <> "" Then
				If row.Item(NombreId) Is DBNull.Value Then
					Continue For
				End If
			End If

			If PermiteRepetir Then
				Dim Campo As String = ""
				For I = 0 To NombreDesVarios.Length - 1
					If InStr(NombreDesVarios(I), "'") > 0 Then
						Campo &= Replace(NombreDesVarios(I), "'", "")
					Else
						Campo &= row.Item(NombreDesVarios(I))
					End If
				Next
				If NombreId <> "" Then
					Combo.Items.Add(New DataDescription(row.Item(NombreId).ToString, Campo))
				Else
					Combo.Items.Add(New DataDescription(0, Campo))
				End If
				I = I + 1
			Else
				If DesAnt <> row.Item(NombreDes).ToString Or PermiteRepetir Then
					If NombreId <> "" Then
						Combo.Items.Add(New DataDescription(row.Item(NombreId).ToString, row.Item(NombreDes)))
					Else
						Combo.Items.Add(New DataDescription(0, row.Item(NombreDes)))
					End If
					DesAnt = row.Item(NombreDes).ToString
					I = I + 1
				End If
			End If
			If MaximoFilasCargar > 0 And I = MaximoFilasCargar Then Exit For
		Next

		Try 'ignorar este posible error
			If IdInicial <> -1 Then
				Dim algo As DataDescription
				For I = 0 To Combo.Items.Count - 1
					algo = Combo.Items(I)
					If algo.Data = IdInicial Then
						Combo.SelectedIndex = I
						Exit For
					End If
				Next
			End If
		Catch
		End Try

	End Sub
	''' <summary>
	''' Obsoleto: Usar mejor llene_combo5
	''' </summary>
	''' <param name="Combo"></param>
	''' <param name="NombreTabla"></param>
	''' <param name="CampoIndice"></param>
	''' <param name="CampoMostrar"></param>
	''' <param name="ClausulaWhere"></param>
	''' <param name="CampoOrdenamiento"></param>
	''' <remarks></remarks>
	Public Sub Llene_Combo(ByRef Combo As ComboBox, ByVal NombreTabla As String, ByVal CampoIndice As String, ByVal CampoMostrar As String, Optional ByVal ClausulaWhere As String = "", Optional ByVal CampoOrdenamiento As String = "")

		Dim T As New DataTable

		Combo.Items.Clear()

		Dim Orden As String
		Orden = CampoMostrar

		If CampoOrdenamiento <> "" Then Orden = CampoOrdenamiento

		Dim Where As String
		Where = ""
		If ClausulaWhere <> "" Then
			Where = " Where " & ClausulaWhere & " "
		End If

		Abrir(T, "Select " & CampoIndice & "," & CampoMostrar & " From " & NombreTabla & Where & " Order By " & Orden)

		For I As Integer = 0 To T.Rows.Count - 1
			Combo.Items.Add(T.Rows(I).Item(1).ToString)
			VB6.SetItemData(Combo, I, T.Rows(I).Item(0))
		Next
		T.Dispose()

	End Sub
	''' <summary>
	''' Obsoleto: Usar mejor llene_combo5
	''' </summary>
	''' <param name="Combo"></param>
	''' <param name="Dt"></param>
	''' <param name="ClausulaWhere"></param>
	''' <param name="CampoOrdenamiento"></param>
	''' <remarks></remarks>
	Public Sub Llene_Combo(ByRef Combo As ComboBox, ByVal Dt As DataTable, Optional ByVal ClausulaWhere As String = "", Optional ByVal CampoOrdenamiento As String = "")

		Combo.Items.Clear()
		Dim I As Integer = 0
		If ClausulaWhere <> "" Then
			Dim Dr() As DataRow
			If CampoOrdenamiento <> "" Then
				Dr = Dt.Select(ClausulaWhere, CampoOrdenamiento)
			Else
				Dr = Dt.Select(ClausulaWhere)
			End If

			For Each row As DataRow In Dr
				'Combo.Items.Add(New DataDescription(row.Item(0), row.Item(1)))
				Combo.Items.Add(row.Item(1).ToString)
				VB6.SetItemData(Combo, I, row.Item(0))
				I = I + 1
			Next
		Else
			For I = 0 To Dt.Rows.Count - 1
				Combo.Items.Add(Dt.Rows(I).Item(1).ToString)
				VB6.SetItemData(Combo, I, Dt.Rows(I).Item(0))
			Next
		End If

	End Sub
	''' <summary>
	''' Obsoleto: Usar mejor llene_combo5
	''' </summary>
	''' <param name="Cb"></param>
	''' <param name="Sql"></param>
	''' <param name="IdInicial"></param>
	''' <remarks></remarks>
	Public Sub Llene_Combo(ByVal Cb As ComboBox, ByVal Sql As String, ByVal IdInicial As Integer)
		Dim Tabla As DataTable = New DataTable

		Abrir(Tabla, Sql)


		Cb.Items.Clear()

		Dim I As Integer
		For I = 0 To Tabla.Rows.Count - 1
			Cb.Items.Add(New DataDescription(Gdf(Tabla, I, "id"), Gdf(Tabla, I, "descripcion")))
		Next

		Tabla.Dispose()

		PongaIndex(Cb, IdInicial)


	End Sub
	''' <summary>
	''' Obsoleto: Usar mejor llene_combo5
	''' </summary>
	''' <param name="Cb"></param>
	''' <param name="Sql"></param>
	''' <param name="IdInicial"></param>
	''' <remarks></remarks>
	Public Sub Llene_Combo(ByVal Cb As CheckedListBox, ByVal Sql As String, ByVal IdInicial As Integer)
		Dim Tabla As DataTable = New DataTable

		Abrir(Tabla, Sql)


		Cb.Items.Clear()

		Dim I As Integer
		For I = 0 To Tabla.Rows.Count - 1
			Cb.Items.Add(New DataDescription(Gdf(Tabla, I, "id"), Gdf(Tabla, I, "descripcion")))
		Next

		Tabla.Dispose()

		PongaIndex(Cb, IdInicial)


	End Sub
	''' <summary>
	''' Obsoleto: Usar mejor llene_combo5
	''' </summary>
	''' <param name="Combo"></param>
	''' <param name="NombreStoredProcedure"></param>
	''' <param name="CampoIndice"></param>
	''' <param name="CampoMostrar"></param>
	''' <param name="P1"></param>
	''' <param name="P2"></param>
	''' <param name="P3"></param>
	''' <param name="P4"></param>
	''' <param name="P5"></param>
	''' <remarks></remarks>
	Public Sub Llene_Combo3(ByRef Combo As ComboBox, ByRef NombreStoredProcedure As String, ByRef CampoIndice As String, ByRef CampoMostrar As String, Optional ByRef P1 As String = "", Optional ByRef P2 As String = "", Optional ByRef P3 As String = "", Optional ByRef P4 As String = "", Optional ByRef P5 As String = "")

		Dim T As New DataTable

		Combo.Items.Clear()

		Dim Orden As String
		Orden = CampoMostrar


		Abrir(T, NombreStoredProcedure, P1, P2, P3, P4, P5)

		For I As Integer = 0 To T.Rows.Count - 1
			Combo.Items.Add(New DataDescription(T.Rows(I).Item(0), T.Rows(I).Item(1).ToString))
		Next
		T.Dispose()


	End Sub
	''' <summary>
	''' Obsoleto: Usar mejor llene_combo5
	''' </summary>
	''' <param name="Combo"></param>
	''' <param name="Dt"></param>
	''' <remarks></remarks>
	Public Sub Llene_Combo3(ByRef Combo As ComboBox, ByVal Dt As DataTable)


		Combo.Items.Clear()


		For I As Integer = 0 To Dt.Rows.Count - 1
			Combo.Items.Add(New DataDescription(Dt.Rows(I).Item(0), Dt.Rows(I).Item(1).ToString))
		Next
		Dt.Dispose()


	End Sub
	''' <summary>
	''' Para validar cuando un TextBox NO tiene contenido y debe ser algún texto, muestra en pantalla el mensaje enviado por parámetros y se queda en el campo
	''' </summary>
	''' <param name="TextoError">Texto de error para mostrar en pantalla</param>
	''' <param name="TxtCampo">Nombre del TextBox</param>
	''' <returns>true=No hay texto en el textbox</returns>
	''' <remarks></remarks>
	Public Function No_Hay_Texto(ByRef TextoError As String, ByRef TxtCampo As System.Windows.Forms.TextBox) As Boolean

		' JDMS OCT/06
		' 


		If TxtCampo.Text = "" Then
			If TextoError <> "" Then
				Mensaje(TextoError)
				Try : TxtCampo.Focus() : Catch ex As Exception : End Try
			End If
			Return True
		End If

		Return False

	End Function
	''' <summary>
	''' Obsoleto: usar llene_combo5
	''' </summary>
	''' <param name="Combo"></param>
	''' <param name="NombreStoredProcedure"></param>
	''' <param name="CampoIndice"></param>
	''' <param name="CampoMostrar"></param>
	''' <param name="P1"></param>
	''' <param name="P2"></param>
	''' <param name="P3"></param>
	''' <param name="P4"></param>
	''' <param name="P5"></param>
	''' <remarks></remarks>
	Public Sub Llene_Combo2(ByRef Combo As ComboBox, ByRef NombreStoredProcedure As String, ByRef CampoIndice As String, ByRef CampoMostrar As String, Optional ByRef P1 As String = "", Optional ByRef P2 As String = "", Optional ByRef P3 As String = "", Optional ByRef P4 As String = "", Optional ByRef P5 As String = "")

		Dim T As New DataTable

		Combo.Items.Clear()

		Dim Orden As String
		Orden = CampoMostrar


		Abrir(T, NombreStoredProcedure, P1, P2, P3, P4, P5)

		For I As Integer = 0 To T.Rows.Count - 1
			Combo.Items.Add(T.Rows(I).Item(1).ToString)
			VB6.SetItemData(Combo, I, T.Rows(I).Item(0))
		Next
		T.Dispose()


	End Sub

	'Public Function SinTildes(ByVal Texto As String) As String

	'    Texto = Replace(Texto, "á", "a")
	'    Texto = Replace(Texto, "é", "e")
	'    Texto = Replace(Texto, "í", "i")
	'    Texto = Replace(Texto, "ó", "o")
	'    Texto = Replace(Texto, "ú", "u")
	'    Texto = Replace(Texto, "Á", "A")
	'    Texto = Replace(Texto, "É", "E")
	'    Texto = Replace(Texto, "Í", "I")
	'    Texto = Replace(Texto, "Ó", "O")
	'    Texto = Replace(Texto, "Ú", "U")

	'    Return Texto

	'End Function
	Public Sub SalvarFoto(ByVal ImageArray As Byte(), ByVal Foto As String, ByVal FotoBorrar As String)
		If NoEntrar() Then Exit Sub
		Try
			If FotoBorrar <> "" Then
				Kill(FotoBorrar)
			End If

		Catch ex As Exception
			'no hacer nada
		End Try

		Try
			Dim ArraySize As New Integer
			ArraySize = ImageArray.GetUpperBound(0)
			'Dim fs As New System.IO.FileStream(Foto, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write)
			Dim fs As New System.IO.FileStream(Foto, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write)
			fs.Write(ImageArray, 0, Convert.ToInt32(ImageArray.Length))
			fs.Close()
			fs.Dispose()

		Catch ex As Exception 'este error se produce porque la foto esta siendo utilizada en otro proceso
			Debug.Print("No logró salvar imagen")

		End Try


	End Sub

	'Public Sub HagaEventos()
	'    Try
	'        System.Windows.Forms.Application.DoEvents()

	'    Catch ex As Exception

	'    End Try

	'End Sub
	''' <summary>
	''' Devuelve una fecha formateada
	''' </summary>
	''' <param name="Fecha">Nombre del campo donde viene la fecha</param>
	''' <param name="MostrarHoraMinutos">True=Mostrar la hora con los minutos</param>
	''' <param name="MostrarSegundos">True=Mostrar también los segundos</param>
	''' <returns>Devuelve fecha con el formato d-MMM-yyyy HH:mm:ss</returns>
	''' <remarks></remarks>
	Public Function FormatoFecha(ByVal Fecha As Object, Optional ByVal MostrarHoraMinutos As Boolean = False, Optional ByVal MostrarSegundos As Boolean = False) As String

		If IsDate(Fecha) = False Then
			Return ""
		End If

		Dim Resul As String = ""
		If MostrarHoraMinutos Then
			If MostrarSegundos Then
				Resul = Strings.Format(CDate(Fecha), "d-MMM-yyyy HH:mm:ss")
				If Strings.Right(Resul, 8) = "00:00:00" Then
					Resul = Trim(Replace(Resul, "00:00:00", ""))
				End If
			Else
				Resul = Strings.Format(CDate(Fecha), "d-MMM-yyyy HH:mm")
				If Strings.Right(Resul, 5) = "00:00" Then
					Resul = Trim(Replace(Resul, "00:00", ""))
				End If
			End If
			Return Resul
		Else
			Return Strings.Format(CDate(Fecha), "d-MMM-yyyy")
		End If
	End Function
	''' <summary>
	''' Para formatear fecha cuando va por parámetro
	''' </summary>
	''' <param name="Fecha"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function FmtFec(ByVal Fecha) As String
		If Not IsDate(Fecha) Then
			FmtFec = "1950/12/31"
		Else
			'FmtFec = VB6.Format(Fecha, "yyyy-mm-dd hh:mm:ss")
			FmtFec = Strings.Format(CDate(Fecha), "yyyy/MM/dd HH:mm:ss")
		End If

	End Function
	''' <summary>
	''' Se debe usar para enviar fechas en los procedimientos almacenados
	''' </summary>
	''' <param name="Fecha">Nombre campo de fecha</param>
	''' <returns>Devuelve la fecha formateada de tal forma que la entienda SQL Server sin problemas regionales</returns>
	''' <remarks></remarks>
	Public Function FmtFecSQL(ByVal Fecha) As String
		If Not IsDate(Fecha) Then
			FmtFecSQL = "19501231 00:00"
		Else
			'FmtFec = VB6.Format(Fecha, "yyyy-mm-dd hh:mm:ss")
			'FmtFecSQL = Strings.Format(Fecha, "yyyyMMdd HH:mm:ss")
			FmtFecSQL = Strings.Format(CDate(Fecha), "yyyyMMdd HH:mm:ss")
		End If

	End Function

	'Private Function ConviertaParametros(ByVal NombreSP As String, ByVal ParamArray ListaDeValores() As String) As String
	'    Dim Sql As String = NombreSP & " "

	'    For I As Integer = 0 To ListaDeValores.Length - 1
	'        If ListaDeValores(I) <> "" Then
	'            Sql += "'" & ListaDeValores(I) & "',"
	'        End If
	'    Next
	'    If ListaDeValores.Length > 0 Then
	'        Sql = Mid(Sql, 1, Sql.Length - 1)
	'    End If

	'    Return Sql

	'End Function
	''' <summary>
	''' Calcula el tiempo total de carga de un proceso
	''' </summary>
	''' <param name="TiempoInicial">Fecha inicial de cuando comenzó el proceso</param>
	''' <returns>Devuelve el tiempo consumido en segundos</returns>
	''' <remarks></remarks>
	Public Function Calcular_Tiempo_Carga(ByVal TiempoInicial As Date) As Double
		Try
			Dim stop_time As DateTime = Now
			Dim elapsed_time As TimeSpan
			elapsed_time = stop_time.Subtract(TiempoInicial)
			Return elapsed_time.TotalSeconds ' .ToString("0.000000")
		Catch
			Return 60
		End Try

	End Function

	''' <summary>
	''' Obsoleto: Usar solo procedimientos almacenados
	''' </summary>
	''' <param name="Id"></param>
	''' <param name="NombreTabla"></param>
	''' <param name="NombreCampoLlave"></param>
	''' <param name="Campos"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function Arme_Instruccion(ByRef Id As Integer, ByRef NombreTabla As String, ByRef NombreCampoLlave As String, ByVal ParamArray Campos() As Object) As String
		Dim Te As String
		Te = ""

		If Id > 0 Then
			Te = "Update " & NombreTabla & " Set "
			For I = 0 To UBound(Campos(0)) Step 2
				Te = Te & Campos(0)(I) & "=" & Campos(0)(I + 1) & ","
			Next I
			Te = Left(Te, Len(Te) - 1)
			Te = Te & " Where " & NombreCampoLlave & "=" & Id
		Else
			Te = "Insert " & NombreTabla & " ("
			For I = 0 To UBound(Campos(0)) Step 2
				Te = Te & Campos(0)(I) & ","
			Next I
			Te = Left(Te, Len(Te) - 1)
			Te = Te & ") Values ("
			For I = 0 To UBound(Campos(0)) Step 2
				Te = Te & Campos(0)(I + 1) & ","
			Next I
			Te = Left(Te, Len(Te) - 1)
			Te = Te & ")"
		End If

		Return Te

	End Function

	Public Function SinComillas(ByVal Dato As String) As String
		If Dato = "" Then
			Return Dato
		End If

		'este reemplaza la comilla por un apostrofe
		If IsNumeric(Dato) Then
			Return Dato
		End If

		Return Replace(Dato, "'", "`")


	End Function
	Public Function SinComillas2(ByVal Dato As String) As String
		'este deja la comilla pero la arregla para que pase el sql
		If IsNumeric(Dato) Then
			Return Dato
		End If

		Return Replace(Dato, "'", "''")


	End Function

	''' <summary>
	''' Seleccionar una opción similar al InputBox pero con validación y las opciones son mostradas en un Grid
	''' </summary>
	''' <param name="TituloVentana">Título de la ventana</param>
	''' <param name="TextoEncimaDeOpciones">Texto para ser mostrado encima de las diferentes opciones</param>
	''' <param name="PermiteCancel">Acepta o no que presionen la tecla ESC o Cancelar</param>
	''' <param name="ValorPredeterminado">Valor predeterminado</param>
	''' <param name="Campos">Objeto con lista de opciones y su descripción. Ejemplo: Dim Que As String = InputBoxDMS("Historia", "Seleccione Tipo de Historia", True, 1, New Object() {New Object() {"0", "Proceso", "1", "Vendido", "2", "Aplazado", "3", "Perdido", "4", "Anulado"}})</param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function InputBoxDMS(ByRef TituloVentana As String, ByRef TextoEncimaDeOpciones As String, ByRef PermiteCancel As Boolean, ByRef ValorPredeterminado As String, ByVal ParamArray Campos() As Object) As String


		On Error GoTo Hay

		Dim fInputBoxDMS As New fInputBoxDMS

		InputBoxDMS = ""
		Dim Cua, I, J As Short
		Dim Opciones(50) As String
		Dim Texto As String
		Texto = ""
		If TextoEncimaDeOpciones <> "" Then
			Texto = Idi(TextoEncimaDeOpciones) & DMScr(2)
		End If
		Cua = 0
		If Campos.Length > 0 Then
			fInputBoxDMS.Grid.Rows.Clear()
			For I = 0 To UBound(Campos(0)) Step 2
				'si no viene descripción, saltarlo
				If Campos(0)(I + 1) = "" Then Continue For

				Opciones(Cua) = Campos(0)(I)
				fInputBoxDMS.Grid.Rows.Add(Opciones(Cua), Idi(Campos(0)(I + 1)))

				If Opciones(Cua) = ValorPredeterminado Then
					fInputBoxDMS.Grid.Tag = fInputBoxDMS.Grid.Rows.Count - 1
				End If
				'Texto = Texto & Opciones(Cua) & " - " & Campos(0)(I + 1) & vbCrLf
				If Int(Cua / 2) * 2 = Cua Then
					fInputBoxDMS.Grid.Rows(Cua).DefaultCellStyle.BackColor = Color.LightCyan
				End If
				Cua = Cua + 1

			Next I

			Cua = Cua - 1
		End If

		fInputBoxDMS.LblEncima.Text = Texto
		fInputBoxDMS.CmdCancelar.Visible = PermiteCancel
		fInputBoxDMS.ControlBox = PermiteCancel
		fInputBoxDMS.Text = Idi(TituloVentana)

		Dim Resp As String = ""

Repita:
		fInputBoxDMS.ShowDialog()
		If fInputBoxDMS.Tag = "C" Then
			Resp = ""
			InputBoxDMS = ""
			Exit Function
		End If

		Resp = Tm(fInputBoxDMS.Grid, "opcion")
		If Cua > 0 Then
			For I = 0 To Cua
				If Resp = Opciones(I) Then
					J = 1
					Exit For
				End If
			Next I

			If J = 0 Then
				GoTo Repita
			End If
		End If

		InputBoxDMS = Resp

		Exit Function

Hay:
		Mensaje("Error en función InputBoxDMS: " & Err.Description)

		InputBoxDMS = ""

		Exit Function

	End Function
	''' <summary>
	''' Pregunta si el datatable no tiene filas
	''' </summary>
	''' <param name="Dt">Nombre datatable</param>
	''' <returns>Devuelve True si el datatable no tiene filas</returns>
	''' <remarks></remarks>
	Public Function Fin(ByVal Dt As DataTable) As Boolean
		If Dt Is Nothing Then
			Return True
		Else
			If Dt.Rows.Count = 0 Then
				Return True
			Else
				Return False
			End If
		End If



	End Function
	''' <summary>
	''' Le quita la hora a una fecha y la devuelve tipo Date
	''' </summary>
	''' <param name="FechaConHora">Nombre del campo de fecha que puede venir con hora</param>
	''' <returns>Devuelve la fecha si la hora</returns>
	''' <remarks></remarks>
	Public Function FechaSinHora(ByVal FechaConHora As Date) As Date
		Return CDate(Strings.Format(FechaConHora, "yyyy/MM/dd"))

	End Function
	''' <summary>
	''' Devuelve el contenido de un campo de una fila específica de un DataTable
	''' </summary>
	''' <param name="Dt">Nombre del datatable</param>
	''' <param name="NumeroFila">Número de fila donde está el campo</param>
	''' <param name="NombreCampo">Nombre del campo</param>
	''' <returns>Valor del campo. Puede ser nulo o cualquier tipo de dato</returns>
	''' <remarks></remarks>
	Public Function Gdf(ByVal Dt As DataTable, ByVal NumeroFila As Integer, ByVal NombreCampo As String)
		Return Dt.Rows(NumeroFila).Item(NombreCampo)

	End Function
	''' <summary>
	''' Devuelve el contenido de un campo de la fila cero (0) de un DataTable.
	''' </summary>
	''' <param name="Dt">Nombre del datatable</param>
	''' <param name="NombreCampo">Nombre del campo</param>
	''' <returns>Valor del campo. Puede ser nulo o cualquier tipo de dato</returns>
	''' <remarks>Se supone que se usa en una consulta que solo devuelve una fila com o la consulta de cualquier ID</remarks>
	Public Function Gdf(ByVal Dt As DataTable, ByVal NombreCampo As String)
		Return Dt.Rows(0).Item(NombreCampo)

	End Function
	Public Function ConviertaWS(ByVal Texto) As Object
		On Error Resume Next

		If Texto = "°" Then
			Return ""
		End If

		If Texto = "" Then
			Return "|°"
		Else
			Return Texto
		End If

	End Function
	'Public Function Pregunte(ByVal TextoPregunta As String) As Boolean
	'    Return MsgBox(TextoPregunta, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SMD") = MsgBoxResult.Yes

	'End Function
	'Public Function Pregunte(ByVal TextoPregunta As String, ByVal TituloVentana As String) As Boolean
	'    Return MsgBox(TextoPregunta, MsgBoxStyle.YesNo + MsgBoxStyle.Question, TituloVentana) = MsgBoxResult.Yes

	'End Function
	'Public Function PregunteCancel(ByVal TextoPregunta As String) As Short
	'    Return MsgBox(TextoPregunta, MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "SMD - Mobile")

	'End Function

	''' <summary>
	''' Para validar si el combobox tiene alguna fila seleccionada
	''' </summary>
	''' <param name="Cb">Nombre del combo</param>
	''' <param name="TextoError">Texto del error</param>
	''' <returns>Devuelve true si el combo no tiene algo seleccionado</returns>
	''' <remarks></remarks>
	Public Function NoHayCombo(ByVal Cb As ComboBox, ByVal TextoError As String) As Boolean
		If Cb.SelectedIndex < 0 Then
			If TextoError <> "" Then
				Mensaje(TextoError)
			End If
			Cb.Focus()
			Return True
		Else
			If GetItemData(Cb) = 0 Then
				If TextoError <> "" Then
					Mensaje(TextoError)
				End If
				Cb.Focus()
				Return True
			Else
				Return False
			End If
		End If

	End Function
	'Public Function NoHayTexto(ByVal Txt As TextBox, ByVal TextoError As String) As Boolean
	'    If Txt.Text = "" Then
	'        Mensaje(TextoError)
	'        Txt.Focus()
	'        Return True
	'    Else
	'        Return False
	'    End If

	'End Function
	''' <summary>
	''' Obsoleto
	''' </summary>
	''' <param name="Cb"></param>
	''' <param name="NumeroIndice"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function GetItemData(ByVal Cb As ComboBox, Optional ByVal NumeroIndice As Integer = -1) As Integer
		If Cb.SelectedIndex < 0 Then
			Return 0
		End If

		If Not IsNothing(Cb.DataSource) Then
			Return Cb.SelectedValue
		Else
			Dim Mue As DataDescription
			If NumeroIndice >= 0 Then
				Mue = Cb.Items(NumeroIndice)
			Else
				Mue = Cb.SelectedItem
			End If
			Return Mue.Data
		End If


	End Function
	''' <summary>
	''' Obsoleto
	''' </summary>
	''' <param name="Cb"></param>
	''' <param name="NumeroIndice"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function GetItemData(ByVal Cb As CheckedListBox, Optional ByVal NumeroIndice As Integer = -1) As Integer
		If Cb.SelectedIndex < 0 Then
			Return 0
		End If

		If Not IsNothing(Cb.DataSource) Then
			Return Cb.SelectedValue
		Else
			Dim Mue As DataDescription
			If NumeroIndice >= 0 Then
				Mue = Cb.Items(NumeroIndice)
			Else
				Mue = Cb.SelectedItem
			End If
			Return Mue.Data
		End If


	End Function
	'Public Function TraerId(ByVal Cb As ListBox, ByVal NumeroIndice As Integer) As Integer
	'    If Cb.SelectedIndex < 0 Then
	'        Return 0
	'    End If

	'    Dim Mue As DataDescription
	'    Mue = Cb.Items(NumeroIndice)
	'    Return Mue.Data


	'End Function
	''' <summary>
	''' Trae el Id de un combo o un listbox
	''' </summary>
	''' <param name="Cb">Nombre combobox o listbox</param>
	''' <param name="NumeroIndice">Opcional número de índice</param>
	''' <returns>Devuelve el Id del índice solicitado o de la posición seleccionada actualmente</returns>
	''' <remarks></remarks>
	Public Function TraerId(ByVal Cb As Object, Optional ByVal NumeroIndice As Integer = -1) As Integer

		If Cb.SelectedIndex < 0 And NumeroIndice = -1 Then
			Return 0
		End If

		If NumeroIndice = -1 Then NumeroIndice = Cb.SelectedIndex

		Dim Mue As DataDescription
		Mue = Cb.Items(NumeroIndice)
		Return Mue.Data


	End Function
	Public Function TraerId(ByVal Cb As ListBox, Optional ByVal NumeroIndice As Integer = -1) As Integer
		If Cb.SelectedIndex < 0 And NumeroIndice = -1 Then
			Return 0
		End If

		If NumeroIndice = -1 Then NumeroIndice = Cb.SelectedIndex

		Dim Mue As DataDescription
		Mue = Cb.Items(NumeroIndice)
		Return Mue.Data


	End Function
	'Public Function TraerId(ByVal Cb As CheckedListBox, ByVal NumeroIndice As Integer) As Integer
	'    If Cb.SelectedIndex < 0 Then
	'        Return 0
	'    End If

	'    Dim Mue As DataDescription
	'    Mue = Cb.Items(NumeroIndice)
	'    Return Mue.Data


	'End Function
	'Public Function ValD(ByVal ValorCualquiera As Object) As Double
	'    Return ValD(ValorCualquiera)

	'End Function



	'Public Function ValD(ByVal ValorTexto As Object) As Double
	''' <summary>
	''' Se usa para convertir cualquier objeto en un valor númerico tipo Double. No importa si es nulo o cualquier cosa
	''' </summary>
	''' <param name="ValorTexto">Valor a convertir, puede ser incluso nulo. Puede tener formato moneda</param>
	''' <returns>Devuelve el valor en tipo Double</returns>
	''' <remarks></remarks>
	Public Function ValD(ByVal ValorTexto As Object) As Double
		Dim Va As Double


		Try
			'If ValorTexto Is System.DBNull.Value Then
			'    ValorTexto = 0
			'End If
			If Not IsNumeric(ValorTexto) Then ValorTexto = 0

			'ValorTexto = ValorTexto.ToString
			Try 'nuevo truco para evitar que un valor muy pequeño se convierta en exponenciación
				Va = ValorTexto.ToString
				ValorTexto = Va

			Catch
				ValorTexto = ValorTexto.ToString

			End Try


			Double.TryParse(ValorTexto, Globalization.NumberStyles.Any, Nothing, Va)
			'Try
			'    Decimal.TryParse(ValorTexto, Globalization.NumberStyles.Any, Nothing, Va)
			'Catch ex As Exception
			'    Double.TryParse(ValorTexto, Globalization.NumberStyles.Any, Nothing, Va)
			'End Try

			Return Va

		Catch ex As Exception
			Va = 0
			Return Va

		End Try


		'Dim Va As Double


		'Try
		'    If ValorTexto Is System.DBNull.Value Then
		'        ValorTexto = "0"
		'    End If
		'    If Not IsNumeric(ValorTexto) Then ValorTexto = "0"

		'    'esto la estaba defecando
		'    'INTERPRETAR LA COMA Y EL PUNTO
		'    'If PuntoDecimal = "" Then
		'    '    If Strings.Format(5 / 2, "0.0") = "2,5" Then 'EL DECIMAL ES LA COMA
		'    '        PuntoDecimal = ","
		'    '        NoPuntoDecimal = "."
		'    '    Else
		'    '        PuntoDecimal = "."
		'    '        NoPuntoDecimal = ","
		'    '    End If
		'    'End If

		'    'reemplazar la como por punto o visceversa
		'    'Dim K As Integer = 0
		'    'For J As Integer = Len(ValorTexto.ToString) To 1 Step -1
		'    '    K += 1
		'    '    If K > 3 Then Exit For

		'    '    If Mid(ValorTexto.ToString, J, 1) = NoPuntoDecimal Then
		'    '        Mid(ValorTexto, J, 1) = PuntoDecimal
		'    '        Exit For
		'    '    End If
		'    'Next


		'    Double.TryParse(ValorTexto, Globalization.NumberStyles.Any, Nothing, Va)

		'    Return Va

		'Catch ex As Exception
		'    Va = 0
		'    Return Va

		'End Try



	End Function
	''' <summary>
	''' Copia un ComboBox sobre otro 
	''' </summary>
	''' <param name="ComboOrigen">Combo Origen</param>
	''' <param name="ComboDestino">Combo Destino</param>
	''' <param name="IdInicial">Id inicial para el nuevo combo, -2 para que copie combo sin ID</param>
	''' <param name="ExcluirCero">True=Excluir el Index 0</param>
	''' <remarks></remarks>
	Public Sub Copiar_Combo(ByRef ComboOrigen As ComboBox, ByRef ComboDestino As ComboBox, Optional ByVal IdInicial As Integer = -1, Optional ByVal ExcluirCero As Boolean = False)
		Dim algo As DataDescription

		ComboDestino.Items.Clear()

		Dim Ini As Integer = 0
		If ExcluirCero Then Ini = 1
		For I As Integer = Ini To ComboOrigen.Items.Count - 1
			If IdInicial = -2 Then
				ComboDestino.Items.Add(ComboOrigen.Items(I))
			Else
				algo = ComboOrigen.Items(I)
				ComboDestino.Items.Add(New DataDescription(algo.Data, algo.Description))
			End If
		Next

		If IdInicial >= 0 Then
			PongaIndex(ComboDestino, IdInicial)
		End If


	End Sub
	''' <summary>
	''' Asigna contenido a una celda de un grid
	''' </summary>
	''' <param name="Grd">Nombre del grid</param>
	''' <param name="ColumnaName">Nombre de la columna</param>
	''' <param name="Fila">Número de la fila</param>
	''' <param name="ContenidoCelda">Contenido asignado a la celda</param>
	''' <remarks>ejemplo</remarks>
	Public Sub Tm2(ByRef Grd As DataGridView, ByVal ColumnaName As String, ByVal Fila As Long, ByVal ContenidoCelda As Object)
		Try
			Grd.Rows(Fila).Cells(ColumnaName).Value = ContenidoCelda

		Catch ex As Exception

		End Try

	End Sub
	''' <summary>
	''' Extrae el dato de una celda de un grid de la posición actual
	''' </summary>
	''' <param name="Grd">Nombre del grid</param>
	''' <param name="ColumnaName">Nombre de la columna</param>
	''' <returns>Devuelve el contenido de la celda</returns>
	''' <remarks></remarks>
	Public Function Tm(ByVal Grd As DataGridView, ByVal ColumnaName As String)
		If Grd.SelectedRows.Count = 0 Then 'si no trae nada seleccionado
			Return ""
		End If
		If Grd.SelectedRows(0).Cells(ColumnaName).Value Is Nothing Then
			Return ""
		Else
			Return Grd.SelectedRows(0).Cells(ColumnaName).Value.ToString
		End If

	End Function
	''' <summary>
	''' Extrae el dato de una celda de un grid de la fila dada
	''' </summary>
	''' <param name="Grd">Nombre del grid</param>
	''' <param name="ColumnaName">Nombre de la columna</param>
	''' <param name="Fila">Número de la fila</param>
	''' <returns>Devuelve el contenido de la celda</returns>
	''' <remarks></remarks>
	Public Function Tm(ByVal Grd As DataGridView, ByVal ColumnaName As String, ByVal Fila As Long)
		If Grd.Rows(Fila).Cells(ColumnaName).Value Is Nothing Then
			Return ""
		Else
			Return Grd.Rows(Fila).Cells(ColumnaName).Value.ToString
		End If


	End Function
	''' <summary>
	''' Obsoleto
	''' </summary>
	''' <param name="Cb"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function GetItemDescripcion(ByVal Cb As ComboBox) As String
		If Cb.SelectedIndex < 0 Then
			Return ""
		End If

		Dim Mue As DataDescription
		Mue = Cb.SelectedItem
		Return Mue.Description

	End Function
	''' <summary>
	''' Se usa para arreglar los CrLf de un texto que se carga en un TextoBox multiline
	''' </summary>
	''' <param name="TextoOrigen"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function ArreglarReturns(ByVal TextoOrigen As String) As String
		Try
			Dim Tex As String
			'primero quitar el cr+lf
			Tex = Replace(TextoOrigen, Chr(13) + Chr(10), Chr(10))
			'ahora ponerlo
			Tex = Replace(Tex, Chr(10), Chr(13) + Chr(10))
			Return Tex

		Catch ex As Exception
			Return TextoOrigen

		End Try
	End Function
	''' <summary>
	''' Quitar la propiedad de Sort de todas las columnas de un grid
	''' </summary>
	''' <param name="Grd">Nombre del grid</param>
	''' <remarks></remarks>
	Public Sub Quitar_Sort_Columnas(ByVal Grd As DataGridView)
		For I As Integer = 0 To Grd.Columns.Count - 1
			Grd.Columns(I).SortMode = 0
		Next

	End Sub

	''' <summary>
	''' Abre una ventana mostrando un datatable. La ventana tiene un grid de DMS
	''' </summary>
	''' <param name="Dt1">Nombre del datatable</param>
	''' <param name="Titulo">Título de la ventana</param>
	''' <param name="VentanaModal">True = Modal tipo diálogo</param>
	''' <param name="NombreCampoRegresar">Nombre del campo para regresar a la pantalla origen en caso de doble clic</param>
	''' <param name="ColOcultas">Lista de columnas que deben estar ocultas</param>
	''' <param name="SqlInstruccion">Instrucción original para llenar el datatable en caso de Refresh</param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function Ventana(ByVal Dt1 As DataTable,
							ByVal Titulo As String,
							Optional ByVal VentanaModal As Boolean = True,
							Optional ByVal NombreCampoRegresar As String = "",
							Optional ByVal ColOcultas As Array = Nothing,
							Optional ByVal SqlInstruccion As String = "",
							Optional ByVal ColWrap As Array = Nothing
							)


		Dim fFin As New fFind

		'para que sea multiselect
		If Strings.Left(NombreCampoRegresar, 1) = "*" Then
			NombreCampoRegresar = Strings.Mid(NombreCampoRegresar, 2)
			fFin.GridDms1.Grid.MultiSelect = True
			fFin.CmdAceptar.Visible = True
		End If

		'para que haga una advertencia más grande
		If Strings.Left(Titulo, 1) = "*" Then
			Titulo = Idi(Strings.Mid(Titulo, 2))
			fFin.Pnl100.Visible = True
			fFin.Lbl100.Text = Titulo
		Else
			Titulo = Idi(Titulo)
		End If


		Dim DatoSeleccionar As String = "" 'toco hacerlo asi para no agregar otro parametro y tener que compilar todo
		Dim dd() As String = NombreCampoRegresar.Split("|")
		NombreCampoRegresar = dd(0)
		If dd.Length > 1 Then
			DatoSeleccionar = dd(1)
		End If

		fFin.LblProcedure.Tag = SqlInstruccion
		fFin.LblTiempo.Visible = False
		If SqlInstruccion = "pos" Then
			SqlInstruccion = ""
			fFin.GridDms1.Grid.RowTemplate.Height = 44 '*= 2
		End If
		fFin.GridDms1.DMSLlene_Grid(Dt1, NombreCampoRegresar, ContadorLineas:=True, ColOcultas:=ColOcultas, MostrarEliminar:=False, SQLRefrescar:=SqlInstruccion, ColWrap:=ColWrap)
		fFin.GridDms1.DMSTituloDelInforme = Titulo
		fFin.Text = Titulo
		'fFin.GraficarToolStripButton.Visible = False



		fFin.NombreCampoRegresar = NombreCampoRegresar
		fFin.DatoSeleccionar = DatoSeleccionar
		fFin.CmdRegresar.Visible = True
		If ColOcultas Is Nothing Then
			fFin.Sql = SqlInstruccion
		End If
		Reloj(False)
		fFin.PicLogo.Visible = False

		If Math.Round(Dt1.Rows.Count / 100, 0) * 100 = Dt1.Rows.Count And Dt1.Rows.Count > 0 Then
			fFin.Lbl100.Text = "Atención: Esta consulta está diseñada para mostrar un máximo de " & Dt1.Rows.Count.ToString & " filas de resultados.  En la base de datos hay más información que no está siendo mostrada en este momento"
			fFin.Pnl100.Visible = True
		End If
		If Dt1.Rows.Count = 0 Then
			fFin.Lbl100.Text = "No encontró información para mostrar"
			fFin.Pnl100.Visible = True
		End If


		If VentanaModal Then
			If NombreCampoRegresar = "marca" Then
				fFin.GridDms1.Grid.Tag = "1"
			End If

			'If NombreCampoRegresar = "marca" Then
			'    For I As Integer = 0 To fFin.GridDms1.Grid.Rows.Count - 1
			'        If Tm(fFin.GridDms1.Grid, "marca", I) = "col" Then
			'            fFin.GridDms1.Grid.Rows(I).DefaultCellStyle.Font = fFin.LblNegro.Font
			'        End If
			'    Next
			'End If
			fFin.IgnoreModal = False
			fFin.ShowDialog()
			Return DatoDevolver
		Else
			fFin.IgnoreModal = True
			fFin.MinimizeBox = True
			fFin.Show()
			Return ""
		End If


		'fFin.ShowDialog()
		'If VentanaModal Then
		'    fFin.ShowDialog()
		'Else
		'    fFin.Show()
		'End If
		'Return DatoDevolver

	End Function
	''' <summary>
	''' Obsoleto
	''' </summary>
	''' <param name="Sql"></param>
	''' <param name="Titulo"></param>
	''' <param name="VentanaModal"></param>
	''' <param name="NombreCampoRegresar"></param>
	''' <param name="P1"></param>
	''' <param name="P2"></param>
	''' <param name="P3"></param>
	''' <param name="P4"></param>
	''' <param name="P5"></param>
	''' <param name="P6"></param>
	''' <param name="P7"></param>
	''' <param name="P8"></param>
	''' <param name="P9"></param>
	''' <param name="P10"></param>
	''' <param name="P11"></param>
	''' <param name="P12"></param>
	''' <param name="P13"></param>
	''' <param name="P14"></param>
	''' <param name="P15"></param>
	''' <param name="P16"></param>
	''' <param name="P17"></param>
	''' <param name="P18"></param>
	''' <param name="P19"></param>
	''' <param name="P20"></param>
	''' <param name="SqlInstruccion"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function Ventana(ByVal Sql As String, ByVal Titulo As String, Optional ByVal VentanaModal As Boolean = True,
							Optional ByVal NombreCampoRegresar As String = "",
							Optional ByVal P1 As String = "",
							Optional ByVal P2 As String = "",
							Optional ByVal P3 As String = "",
							Optional ByVal P4 As String = "",
							Optional ByVal P5 As String = "",
							Optional ByVal P6 As String = "",
							Optional ByVal P7 As String = "",
							Optional ByVal P8 As String = "",
							Optional ByVal P9 As String = "",
							Optional ByVal P10 As String = "",
							Optional ByVal P11 As String = "",
							Optional ByVal P12 As String = "",
							Optional ByVal P13 As String = "",
							Optional ByVal P14 As String = "",
							Optional ByVal P15 As String = "",
							Optional ByVal P16 As String = "",
							Optional ByVal P17 As String = "",
							Optional ByVal P18 As String = "",
							Optional ByVal P19 As String = "",
							Optional ByVal P20 As String = "",
							Optional ByVal SqlInstruccion As String = "",
							Optional ByVal ColWrap As Array = Nothing
							)

		If NoEntrar() Then Return Nothing


		Dim Dt As DataTable = New DataTable

		Titulo = Idi(Titulo)

		Try

			Dim fFin As New fFind
			fFin.LblProcedure.Tag = Sql

			Dim P20e As String = P20
			If Mid(P20, 1, 1) = "|" Then
				P20e = ""
			End If

			fFin.Text = Titulo
			fFin.GridDms1.DMSTituloDelInforme = Titulo
			If VentanaModal Then
				SiReloj()
				Dim TiempoIni As DateTime = Now
				If P1 <> "" Then
					Abrir(Dt, Sql, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15, P16, P17, P18, P19, P20e)
				Else
					Abrir(Dt, Sql)
				End If
				NoReloj()

				If Fin(Dt) Then
					Mensaje(Idi("No encontro datos en la consulta") & " " & IIf(Usuario = 2, Sql, ""))
					Return ""
				End If

				fFin.LblTiempo.Text = HaceCuantoTiempo(TiempoIni, Now)

				fFin.P1 = P1 'solo para saber si es modal, truco
				fFin.GridDms1.DMSLlene_Grid(Dt, NombreCampoRegresar, ContadorLineas:=True, MostrarEliminar:=False, SQLRefrescar:=SqlInstruccion, ColWrap:=ColWrap)
				'fFin.G1.DataSource = Dt
				fFin.NombreCampoRegresar = NombreCampoRegresar
				Reloj(False)
				If Mid(P20, 1, 1) = "|" Then
					If Dt.Rows.Count >= ValD(Mid(P20, 2)) And Dt.Rows.Count > 0 Then
						'Mensaje("Atención: Esta consulta está diseñada para mostrar un máximo de " & ValD(Mid(P20, 2)).ToString & " filas de resultados.  En la base de datos hay más información que no está siendo mostrada en este momento")
						'fFin.Lbl100.Text = "Atención: Esta consulta está diseñada para mostrar un máximo de " & ValD(Mid(P20, 2)).ToString & " filas de resultados.  En la base de datos hay más información que no está siendo mostrada en este momento"
						fFin.Lbl100.Text = Idi("Atención: Esta consulta está diseñada para mostrar un máximo de") & " " & ValD(Mid(P20, 2)).ToString & " " & Idi("filas de resultados.  En la base de datos hay más información que no está siendo mostrada en este momento")
						fFin.Pnl100.Visible = True
					End If
				Else
					If Math.Round(Dt.Rows.Count / 100, 0) * 100 = Dt.Rows.Count And Dt.Rows.Count > 0 Then
						'fFin.Lbl100.Text = "Atención: Esta consulta está diseñada para mostrar un máximo de " & Dt.Rows.Count.ToString & " filas de resultados.  En la base de datos hay más información que no está siendo mostrada en este momento"
						fFin.Lbl100.Text = Idi("Atención: Esta consulta está diseñada para mostrar un máximo de") & " " & Dt.Rows.Count.ToString & " " & Idi("filas de resultados.  En la base de datos hay más información que no está siendo mostrada en este momento")
						fFin.Pnl100.Visible = True
					End If
				End If
				If Dt.Rows.Count = 0 Then
					fFin.Lbl100.Text = Idi("No encontró información para mostrar")
					fFin.Pnl100.Visible = True
				End If

				fFin.PicLogo.Visible = False
				fFin.ShowDialog()
				Return DatoDevolver
			Else
				fFin.MinimizeBox = True
				fFin.Sql = Sql
				fFin.P1 = P1
				fFin.P2 = P2
				fFin.P3 = P3
				fFin.P4 = P4
				fFin.P5 = P5
				fFin.P6 = P6
				fFin.P7 = P7
				fFin.P8 = P8
				fFin.P9 = P9
				fFin.P10 = P10
				fFin.P11 = P11
				fFin.P12 = P12
				fFin.P13 = P13
				fFin.P14 = P14
				fFin.P15 = P15
				fFin.P16 = P16
				fFin.P17 = P17
				fFin.P18 = P18
				fFin.P19 = P19
				fFin.P20 = P20e
				If Mid(P20, 1, 1) = "|" Then
					fFin.AvisarConFilas = ValD(Mid(P20, 2))
				Else
					fFin.AvisarConFilas = 0
				End If

				If NombreCampoRegresar <> "" Then
					fFin.NombreCampoRegresar = NombreCampoRegresar
				End If
				'fFin.SQLInstruccion = SqlInstruccion
				'fFin.BtnCopiar.Enabled = False
				If DsUsoEspecial IsNot Nothing Then
					fFin.DsJD = DsUsoEspecial.Copy
					DsUsoEspecial = Nothing
				End If
				fFin.HacerConsulta.RunWorkerAsync()
				fFin.LblAviso.Visible = True
				fFin.GridDms1.Visible = False
				fFin.PicLogo.Visible = False
				fFin.Show()

				Return ""
			End If



		Catch ex As Exception
			NoReloj()
			'MostrarError("Ppal", "Ventana", ex.Message)
			Mensaje("Error cargando la Consulta: " & ex.Message & EsIngles() & EsIngles())

		End Try

		Return ""

	End Function

	'Public Sub Reloj(Optional ByVal Que As Boolean = True)
	'    If Que = True Then
	'        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
	'    Else
	'        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	'    End If
	'    'System.Windows.Forms.Application.DoEvents()

	'End Sub
	'Public Sub NoReloj(Me)
	'    Reloj(False)

	'End Sub
	''' <summary>
	''' Función estandar para devolver el campo formateado en moneda
	''' </summary>
	''' <param name="ValorDelTexto">Valor origen</param>
	''' <param name="MostrarCero">True=Muestre valor si está en cero</param>
	''' <param name="AceptaNegativo">True=Muestre valor si es negativo</param>
	''' <param name="DigitosDespuesDelPunto">Cantidad de decimales después del punto. Default según configuración regional</param>
	''' <returns>Devuelve valor formateado en Moneda</returns>
	''' <remarks></remarks>
	Public Function FormatoMoneda(ByVal ValorDelTexto As Object,
								  Optional ByVal MostrarCero As Boolean = False,
								  Optional ByVal AceptaNegativo As Boolean = False,
								  Optional ByVal DigitosDespuesDelPunto As Integer = -1) As String

		Dim ValorTexto As String

		If ValorDelTexto Is System.DBNull.Value Then
			ValorTexto = ""
		Else
			ValorTexto = ValorDelTexto
		End If

		If Not IsNumeric(ValorTexto) Then
			Return ""
		End If
		If ValD(ValorTexto) = 0 And Not MostrarCero Then
			Return ""
		End If
		If ValD(ValorTexto) < 0 And Not AceptaNegativo Then
			Return ""
		End If

		If DigitosDespuesDelPunto >= 0 Then
			If DigitosDespuesDelPunto = 2 Then
				Return FormatCurrency(ValD(ValorTexto))
			Else
				Return FormatCurrency(ValD(ValorTexto), DigitosDespuesDelPunto)
			End If
		Else
			'JFG-655 Decimales definidos por la Rn#142 llave "evitar_aprox"
			'Return FormatCurrency(ValD(ValorTexto))
			Static DecimalesAprox As Integer = -1
			If DecimalesAprox = -1 Then
				DecimalesAprox = IIf(ValD(ReglaDeNegocio(142, "evitar_aprox", 0)) = 1, 4, 2)
			End If
			Return FormatCurrency(ValD(ValorTexto), DecimalesAprox)
			'JFG-655 Decimales definidos por la Rn#142/102 llave "evitar_aprox"
		End If

	End Function

	'Public Sub Ponga_Formato(ByVal Grd As DataGridView, ByVal ColumName As String)

	'    Try

	'        For Each row As DataGridViewRow In Grd.Rows
	'            If row.Cells(ColumName).Value.ToString <> "" Then
	'                row.Cells(ColumName).Value = FormatCurrency(row.Cells(ColumName).Value)
	'            End If
	'        Next

	'    Catch ex As Exception
	'        'Mensaje(ex.Message & EsIngles)
	'    End Try

	'End Sub


	''' <summary>
	''' Pone el combo en la fila que corresponda con el índice dado
	''' </summary>
	''' <param name="Cb">Nombre del combo</param>
	''' <param name="IdInicial">Id a buscar</param>
	''' <returns>No devuelve dato</returns>
	''' <remarks></remarks>
	Public Function PongaIndex(ByRef Cb As ComboBox, ByVal IdInicial As Integer) As Integer
		Dim II As Integer
		Dim Algo As DataDescription

		Try
			Cb.SelectedIndex = -1
		Catch
		End Try

		For II = 0 To Cb.Items.Count - 1
			Algo = Cb.Items(II)
			If Algo.Data = IdInicial Then 'encontrada
				Cb.SelectedIndex = II
				Exit For
			End If
		Next

	End Function
	''' <summary>
	''' Pone el CheckedListBox en la fila que corresponda con el índice dado y lo deja seleccionado
	''' </summary>
	''' <param name="Cb">Nombre del CheckedListBox</param>
	''' <param name="IdInicial">Id a buscar</param>
	''' <returns>No devuelve dato</returns>
	''' <remarks></remarks>
	Public Function PongaIndex(ByRef Cb As CheckedListBox, ByVal IdInicial As Integer) As Integer
		Dim II As Integer
		Dim Algo As DataDescription

		'Cb.SelectedIndex = -1

		For II = 0 To Cb.Items.Count - 1
			Algo = Cb.Items(II)
			If Algo.Data = IdInicial Then 'encontrada
				Cb.SetItemChecked(II, True)
				Exit For
			End If
		Next

	End Function
	''' <summary>
	''' Pone el ListBox en la fila que corresponda con el índice dado
	''' </summary>
	''' <param name="Cb">Nombre del ListBox</param>
	''' <param name="IdInicial">Id a buscar</param>
	''' <returns>No devuelve dato</returns>
	''' <remarks></remarks>
	Public Function PongaIndex(ByRef Cb As ListBox, ByVal IdInicial As Integer) As Integer
		Dim II As Integer
		Dim Algo As DataDescription

		'Cb.SelectedIndex = -1

		For II = 0 To Cb.Items.Count - 1
			Algo = Cb.Items(II)
			If Algo.Data = IdInicial Then 'encontrada
				Cb.SelectedIndex = II
				Exit For
			End If
		Next

	End Function
	''' <summary>
	''' Poner el foco en el control dado
	''' </summary>
	''' <param name="NombreControl">Nombre del control</param>
	''' <remarks></remarks>
	Public Sub PongaFoco(ByRef NombreControl As Windows.Forms.Control)
		Try
			NombreControl.Focus()

		Catch ex As Exception

		End Try
	End Sub

	Const Salt = True
	'Const theKey = 917857972
	Public Function Encriptar(ByVal Encrip_o_Desemcrip As String, ByVal Clave As String) As String
		If NoEntrar() Then Return ""
		'On Error GoTo Hay

		If Encrip_o_Desemcrip = "E" Then 'encriptar
			Encriptar = StrEncode(Clave, 917857972)
		Else
			Encriptar = StrDecode(Clave, 917857972)
		End If
		Exit Function

		'Hay:
		'        Mensaje("Clave del usuario con problemas.  Solicite a su administrador que le quite su clave poniendo el campo CLAVE2 de la tabla USUARIOS en NULL (por QUERY) o se la cambie por el Administrador de Permisos")
		'        Encriptar = "adivinepues"
	End Function


	'funciones para encriptar la clave
	Private Function StrEncode(ByVal s As String, ByVal key As Long) As String
		Dim N As Long, I As Long, SS As String
		Dim k1 As Long, k2 As Long, k3 As Long, k4 As Long, T As Long
		Static saltvalue As String
		saltvalue = "    "

		If Salt Then
			For I = 1 To 4
				T = 100 * (1 + Asc(Mid(saltvalue, I, 1))) * Rnd() * (Date.Now.TimeOfDay.TotalSeconds + 1)
				Mid(saltvalue, I, 1) = Chr(T Mod 256)
			Next
			s = Mid(saltvalue, 1, 2) & s & Mid(saltvalue, 3, 2)
		End If

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
	Private Function StrDecode(ByVal s As String, ByVal key As Long) As String
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



		'If Salt Then StrDecode = Mid(SS, 3, Len(SS) - 4) Else StrDecode = SS

		Try
			If Salt Then
				StrDecode = Mid(SS, 3, Len(SS) - 4)
			Else
				StrDecode = SS
			End If
		Catch
			If Salt And Len(SS) > 4 Then StrDecode = Mid(SS, 3, Len(SS) - 4) Else StrDecode = SS
		End Try

	End Function
	'Public Function FormaYaEstaAbierta(ByVal NombreForma As String, ByVal TagForma As String) As Boolean
	'    Dim I As Integer

	'    For I = My.Application.OpenForms.Count - 1 To 0 Step -1
	'        If My.Application.OpenForms.Item(I).Name = NombreForma Then
	'            If My.Application.OpenForms.Item(I).Tag = TagForma Then
	'                My.Application.OpenForms.Item(I).WindowState = System.Windows.Forms.FormWindowState.Normal
	'                My.Application.OpenForms.Item(I).Show()
	'                My.Application.OpenForms.Item(I).Focus()
	'                Return True
	'            End If
	'        End If
	'    Next I

	'    Return False

	'End Function

	''' <summary>
	''' Muestra la ayuda asociada a una Forma
	''' </summary>
	''' <param name="Forma">Nombre de la forma</param>
	''' <param name="NombreArchivo">Nombre del archivo</param>
	''' <remarks></remarks>
	Public Sub Mostrar_Ayuda(ByVal Forma As Form, Optional ByVal NombreArchivo As String = "") 'String, Optional ByVal Usuario As Integer = 1, Optional ByVal Modal As Boolean = False, Optional ByVal TituloVentana As String = "")


		'ayuda menos vieja
		Dim LinkPaginaAyuda As String = ""
		Try
			If PaginaAyuda = "" Then
				PaginaAyuda = GetSett("Ayuda", "Pagina", "")
			End If
			If NombreArchivo = "" Then
				NombreArchivo = Trim(Mid(Forma.Text, 1, 5))
				If Mid(NombreArchivo, 5, 1) = "(" Then NombreArchivo = Left(NombreArchivo, 3)
				If Mid(NombreArchivo, 4, 1) = "(" Then NombreArchivo = Left(NombreArchivo, 2)
			End If

			LinkPaginaAyuda = PaginaAyuda & "/" & NombreArchivo & ".html"

			AbrirLink(LinkPaginaAyuda)

			Exit Sub
		Catch ex As Exception
			Mensaje(ex.Message)
			Exit Sub
		End Try

		'Ayuda_Vieja:
		'        Reloj(True)

		'        Try
		'            Dim Dt As New DataTable
		'            Abrir(Dt, "GetLeameTexto", NombreForma, Usuario.ToString)

		'            If Fin(Dt) Then
		'                Mensaje("No existe ayuda para " & NombreForma)
		'                Exit Sub
		'            End If


		'            Dim fLea As New fLeame
		'            fLea.Tag = NombreForma
		'            fLea.UsuarioModifica = Usuario
		'            Try
		'                fLea.Txt.Rtf = "" & Gdf(Dt, 0, "explicacion")
		'            Catch ex As Exception
		'            End Try
		'            'fLeame.Txt.loc
		'            fLea.WindowState = FormWindowState.Normal

		'            If TituloVentana <> "" Then fLea.Text = TituloVentana

		'            Reloj(False)

		'            If Modal Then
		'                fLea.TopMost = True
		'                fLea.ShowDialog()
		'            Else
		'                fLea.Show()
		'            End If


		'            Dt.Dispose()

		'        Catch ex As Exception
		'            Mensaje("No se pudó abrir la ayuda: " & ex.Message & EsIngles)
		'            Reloj(False)

		'        End Try

	End Sub

	''' <summary>
	''' Convierte una imagen de un Button o un PictureBox en un icono para el icono de la forma
	''' </summary>
	''' <param name="Imagen">Imagen a convertir</param>
	''' <returns>Icono</returns>
	''' <remarks>Hecho por Juan Diego Machuca en 22-sep-2008</remarks>
	Public Function ConviertaIcono(ByVal Imagen As Image)
		Try
			Dim hBitmap As Bitmap = Imagen
			Dim hIcon As IntPtr = hBitmap.GetHicon()
			Return Icon.FromHandle(hIcon)

		Catch ex As Exception
			Return Nothing
		End Try


	End Function
	Public Sub AbrirArchivo(ByVal ArchivoGuardar)

		Try
			Ejecute_Proceso(ArchivoGuardar.Replace(EsIngles, ""))



		Catch ex As Exception
			Mensaje(Idi("No se pudo abrir el archivo") & ": " & DMScr(2) & ArchivoGuardar & DMScr(2) & ex.Message)

		End Try

	End Sub
	''' <summary>
	''' Valor para llevar a SQL Server en un script o procedimiento almacenado
	''' </summary>
	''' <param name="Valor"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function ValDMS(ByVal Valor As String) As String
		Dim Va As String = ""
		'If Not IsNumeric(Val(Valor)) Then
		'    Return "0"
		'End If

		If Strings.Format(5 / 2, "0.0") = "2,5" Then
			Va = Replace(Valor, ".", "")
			Va = Replace(Va, ",", ".")
			Return Va.ToString
		Else
			Va = Replace(Valor, ",", "")
			Return Va.ToString
		End If

	End Function
	Public Function Ortografia(ByVal Texto As String) As String
		Mensaje_TopMost("Disculpe: Corrector Ortográfico se encuentra deshabilitado en Advance")
		Return Texto


		'If Texto = "" Then Return ""


		'Try
		'    Dim Proteger As String = ""
		'    Proteger = Clipboard.GetText

		'    Dim esRichText As Boolean
		'    Dim RichTextBox1 As New RichTextBox
		'    Try
		'        RichTextBox1.Rtf = Texto
		'        esRichText = True
		'    Catch ex As Exception
		'        RichTextBox1.Text = Texto
		'        esRichText = False
		'    End Try


		'    Dim WordApp As Object
		'    WordApp = CreateObject("Word.Application")

		'    'añadimos un nuevo documento
		'    WordApp.Documents.AdD()
		'    ' copiamos al portapapeles todo el texto
		'    Clipboard.Clear()
		'    Clipboard.SetText(RichTextBox1.Rtf, TextDataFormat.Rtf)
		'    ' lo pegamos en Word
		'    WordApp.Selection.Paste()
		'    ' activamos el corrector ortografico
		'    WordApp.ActiveDocument.CheckSpelling()
		'    'volvemos a poner word invisible
		'    WordApp.Visible = True
		'    ' seleccionamos todo el texto corregido
		'    WordApp.ActiveDocument.Select()
		'    ' lo copiamos al portapapeles
		'    WordApp.Selection.Copy()

		'    ' pegamos el texto RTF del portapapeles
		'    If esRichText Then
		'        RichTextBox1.Rtf = Clipboard.GetText(TextDataFormat.Rtf)
		'    Else
		'        RichTextBox1.Text = Clipboard.GetText(TextDataFormat.Text)
		'    End If

		'    'cerramos el documento sin grabar
		'    WordApp.ActiveDocument.Close(False)
		'    'cerramos word
		'    WordApp.Quit()
		'    'liberamos el objeto
		'    WordApp = Nothing

		'    If esRichText Then
		'        Texto = RichTextBox1.Rtf
		'    Else
		'        Texto = RichTextBox1.Text
		'    End If

		'    Clipboard.SetText(Proteger)

		'    'Mensaje("Fin de la revisión ortográfica")

		'    Return Texto

		'Catch 'ex As Exception
		'    Return Texto

		'End Try

	End Function

	Public Function AbrirLink(ByVal NombrePagina As String) As String
		If NombrePagina = "" Then Return ""

		Try
			'System.Diagnostics.Process.Start("IExplore.exe", NombrePagina)
			System.Diagnostics.Process.Start(NombrePagina)


			'System.Diagnostics.Process.Start("file:///c:/smd_files/archivo.html")

			Return ""

		Catch ex As Exception
			Mensaje("No pudo abrir link: " & ex.Message & EsIngles())
			Return ex.Message

		End Try

	End Function
	Public Function ArchivoSinPath(ByVal NombreConPath As String) As String
		Try
			'For F As Integer = Len(NombreConPath) To 1 Step -1
			'    If Mid(NombreConPath, F, 1) = "\" Then
			'        Return Mid(NombreConPath, F + 1)
			'        Exit Function
			'    End If
			'Next

			'Return NombreConPath

			Return Path.GetFileName(NombreConPath)

		Catch ex As Exception
			Return NombreConPath

		End Try

	End Function
	Public Function RutaDelArchivo(ByVal NombreConPath As String) As String
		Dim J As Integer
		For I As Integer = Len(NombreConPath) To 1 Step -1
			If Mid(NombreConPath, I, 1) = "\" Then
				J = I
				Exit For
			End If
		Next
		Return Mid(NombreConPath, 1, J)

	End Function
#Region "Buscar texto"
	Public Sub Buscar_Texto(ByVal MyControls As Control)
		Try

			For Each MyControl As Control In MyControls.Controls
				If MyControl.Controls.Count > 0 Then
					Buscar_Texto(MyControl)
				Else
					If TypeOf MyControl Is TextBox Or TypeOf MyControl Is RichTextBox Then
						AddHandler MyControl.KeyDown, AddressOf Asignar_KeyDown
					End If
				End If
			Next
		Catch ex As Exception

		End Try
	End Sub
	Private Sub Key_Down(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
		Try
			If e.KeyCode = Keys.Escape Then
				Lost_Focus(sender, New EventArgs)
			End If

			If e.KeyCode <> Keys.Enter And e.KeyCode <> Keys.F3 Then Exit Sub

			Dim asa As Object = CType(sender, Control).Parent()
			'Dim asa As Object = CType(asa2, Control).Parent()

			Dim Index As Integer = asa.SelectionStart + asa.SelectionLength
			Dim aBuscar As String = asa.Text.ToLower
			Dim Elemento As String = CType(sender, Control).Text.ToLower
			If Index > aBuscar.Length Then
				Index = 0
			End If

			For i As Integer = Index To aBuscar.Length - 1
				If i + Elemento.Length > aBuscar.Length - 1 Then
					Index = 0
					Mensaje("No encontró el texto")
					Exit For
				End If
				If aBuscar.Substring(i, Elemento.Length).Contains(Elemento) Then
					asa.SelectionStart = i
					asa.SelectionLength = Elemento.Length
					Try
						asa.ScrollToCaret
					Catch
					End Try
					Exit For
				End If
			Next


			CType(sender, Control).Parent() = asa
			CType(sender, Control).Tag = "S"
			Lost_Focus(sender, New EventArgs)
		Catch ex As Exception

		End Try

	End Sub
	Public Sub Asignar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
		If e.KeyCode = Keys.B Or e.KeyCode = Keys.F Then
			If e.Control Then
				Asignar_Txt(CType(sender, Control), False)
			End If
		End If
		If e.KeyCode = Keys.F3 Then
			Asignar_Txt(CType(sender, Control), True)
		End If

	End Sub
	Private Sub Asignar_Txt(ByRef Control As Object, ByVal Buscar As Boolean)
		'Dim TexBus As New TextoBuscarCtrlB
		'AddHandler TexBus.TextoaBuscar.KeyDown, AddressOf Key_Down
		'AddHandler TexBus.TextoaBuscar.Leave, AddressOf Lost_Focus

		Dim TextoaBuscar As New TextBox
		AddHandler TextoaBuscar.KeyDown, AddressOf Key_Down
		AddHandler TextoaBuscar.Leave, AddressOf Lost_Focus
		Dim puntos As Point

		puntos.Y = (Control.Size.Height / 2) - (TextoaBuscar.Height / 2)
		puntos.X = (Control.Size.Width / 2) - (TextoaBuscar.Width / 2)
		TextoaBuscar.Location = puntos

		TextoaBuscar.Text = Control.text.substring(Control.SelectionStart, Control.SelectionLength).trim
		Control.Controls.Add(TextoaBuscar)
		TextoaBuscar.BringToFront()

		If Buscar Then
			If TextoaBuscar.Text.Trim <> "" Then

				Dim Key As New KeyEventArgs(Keys.Enter)

				Key_Down(TextoaBuscar, Key)

			End If
		End If
		TextoaBuscar.Focus()
	End Sub

	Private Sub Lost_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs)

		CType(sender, Control).Dispose()




	End Sub


#End Region

	Public Function Inputbox2(Prompt As String, Optional Title As String = "", Optional DefaultResponse As String = "", Optional XPos As Integer = -1, Optional YPos As Integer = -1) As String
		If Title = "" Then
			Title = IIf(LenguajeAdvance = 1, My.Application.Info.Description, My.Application.Info.Title)
		End If

		Return InputBox(Idi(Prompt), Idi(Title), DefaultResponse, XPos, YPos)

	End Function


	Public Sub Tratar_Instalar(ByVal Texto As String)
		If NoEntrar() Then Exit Sub
		Dim fGraI As New fGraficas_Instalar

		Try
			Dim reg As RegistryKey
			Dim Ruta As String

			Ruta = "SOFTWARE\Microsoft\NET Framework Setup\NDP\v3.5"
			reg = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, String.Empty)
			reg = reg.OpenSubKey(Ruta, RegistryKeyPermissionCheck.ReadSubTree)
			Dim ob As Object = reg.GetValue("Version")


			If ob < "3.5.30729.01" Then
				fGraI.LnkDetalles.Tag = Texto
				fGraI.PnlFrame.Visible = True
				fGraI.PnlFrame.Top = 0
				fGraI.ShowDialog()
			Else
				Ruta = "SOFTWARE\Microsoft\NET Framework Chart Setup\NDP\v3.5\1033"
				reg = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, String.Empty)
				reg = reg.OpenSubKey(Ruta, RegistryKeyPermissionCheck.ReadSubTree)

				If reg Is Nothing Then
					fGraI.LnkDetalles.Tag = Texto
					fGraI.PnlChat.Visible = True
					fGraI.PnlChat.Top = 0
					fGraI.ShowDialog()
				Else
					Mensaje("No se pudo mostrar la gráfica: " & Texto)
				End If
			End If


		Catch ex As Exception
			fGraI.LnkDetalles.Tag = Texto
			fGraI.PnlFrame.Visible = True
			fGraI.PnlFrame.Top = 0
			fGraI.ShowDialog()

		End Try

		If fGraI.Tag = "S" Then 'si va a instalar
			Try
				Ejecute_Proceso(My.Application.Info.DirectoryPath & "\SMDCrm.exe", "0")

			Catch ex As Exception
			End Try
		End If

	End Sub

	Private Function Obtenga_Aplica() As String
		'@$%dms.net0708

		Dim aaa As String = traerDato()

		If aaa = "" Then
			aaa = "jsjdkf&%&&27"
		Else
			'aaa += "dms.netO7O8"
			aaa += "dms.netO7A1"
		End If

		Return aaa


	End Function
	Private Function traerDato()
		Return "@/(%$"

	End Function
	'Public Function NoPuede3(ByVal PermisoNumero As Integer, ByVal DtPermisos As DataTable, _
	'                         Optional ByVal MostrarMensaje As Boolean = True, Optional ByVal Titulo As String = "") As Boolean
	'    Dim Dr() As DataRow
	'    Dr = DtPermisos.Select("id_opcion=" & PermisoNumero.ToString)
	'    If Dr.Length > 0 Then
	'        Return False
	'    End If

	'    If MostrarMensaje Then
	'        If Titulo <> "" Then
	'            Mensaje("Para utilizar " & Titulo & " debe tener permiso para la opción #" & PermisoNumero & ". Solicite a su administrador de SMD dicho permiso.")
	'        Else
	'            Mensaje("Usuario No autorizado para utilizar la opción #" & PermisoNumero)
	'        End If
	'    End If
	'    Return True

	'End Function


	Private Function CodAplicaRetorne(ByVal Programa As String) As String
		If Len(Programa) = 4 Then
			Return Left(Programa, 2)
		Else
			Return Left(Programa, 3)
		End If

	End Function
	Public Function NoPuede4(ByVal CodigoPrograma As String,
							 Optional ByVal PermisoNumero As Integer = 0,
							 Optional ByVal DtPermisosTabla As DataTable = Nothing,
							 Optional ByVal MostrarMensaje As Boolean = True,
							 Optional ByVal Titulo As String = "") As Boolean

		If DtPermisosTabla Is Nothing Then
			DtPermisosTabla = DtPermisos
		End If

		'truco para refrescar los permisos
		If GetSetting("DMS S.A.", "syscom", "refper" & CodAplicaRetorne(CodigoPrograma), "0") = "1" Or Fin(DtPermisosTabla) Then 'debe refrescar
			Try
				DebugJD("Refrescó permisos")
				Abrir(DtPermisos, "Exec GetPermisosUsuario_Todos " & Usuario.ToString & "," & LenguajeAdvance)
				DtPermisosTabla = DtPermisos
				SaveSetting("DMS S.A.", "syscom", "refper" & CodAplicaRetorne(CodigoPrograma), "")
			Catch
			End Try
		End If


		'truco usuario servicio
		If IgnorarPermisosUsuarioServicio Then
			Return False
		End If

		If DtPermisosTabla.Rows.Count > 0 Then
			Dim Dr() As DataRow
			Dr = DtPermisosTabla.Select("programa='" & CodigoPrograma & "' and IsNull(numero_permiso,0)=" & PermisoNumero.ToString)
			If Dr.Length > 0 Then
				Return False
			End If
		End If


		If MostrarMensaje Then
			If DtProgPerm.Rows.Count = 0 Then
				Traiga_Datos_Menos_Importantes(True)
			End If
			Dim NomPrograma As String = "" & Obtenga_Dato(DtProgPerm, "codigo='" & CodigoPrograma & "' and numero_permiso is null", "nombre_programa")
			Dim NomPermiso As String = ""
			If PermisoNumero > 0 Then
				NomPermiso = "" & Obtenga_Dato(DtProgPerm, "codigo='" & CodigoPrograma & "' and numero_permiso=" & PermisoNumero.ToString, "nombre_programa")
			End If


			Dim Respue As String = ""

			Eliminar_Setting("DMS S.A.", "syscom", CodigoPrograma & "," & PermisoNumero.ToString)


			If PermisoNumero = 0 Then
				Respue = Mensaje_TopMost(Idi("Usuario No autorizado para entrar al programa") & " " &
										 CodigoPrograma &
										 " - " & NomPrograma,
										 Titulo:="*** " & Idi("SIN PERMISO") & " ***",
										 HabilitarAutorizacionElectronica:=CodigoPrograma, NumeroPermiso:=PermisoNumero, ImagenNumero:=5)
			Else
				'Mensaje_TopMost("Para utilizar " & Titulo & " debe tener asignado el permiso #" & PermisoNumero & " del programa " & NomPrograma & ". Solicite a su administrador de Advance dicho permiso.", HabilitarAutorizacionElectronica:=True)
				Respue = Mensaje_TopMost(CodigoPrograma &
										 " - " &
										 NomPrograma & DMScr() &
										 "--> " &
										 PermisoNumero.ToString &
										 " - " & NomPermiso & DMScr(2) &
										 Idi(Titulo),
										 Titulo:="*** " &
										 Idi("SIN PERMISO") &
										 " ***", HabilitarAutorizacionElectronica:=CodigoPrograma, NumeroPermiso:=PermisoNumero, ImagenNumero:=5)
			End If
			If Respue <> "" Then
				Return False
			End If
		End If
		Return True

	End Function
	Public Sub Eliminar_Setting(ByVal Nombre As String, ByVal Seccion As String, ByVal Llave As String)

		Try
			DebugJD("Borrando setting " & Llave)
			DeleteSetting(Nombre, Seccion, Llave) 'limpiar la autorización posible

		Catch ex As Exception

		End Try

	End Sub
	'Public Function NoPuede4(ByVal CodigoPrograma As String, ByVal PermisoNumero As Integer, _
	'                         Optional ByVal MostrarMensaje As Boolean = True, Optional ByVal Titulo As String = "") As Boolean

	'    Return NoPuede4(CodigoPrograma, PermisoNumero, DtPermisos, MostrarMensaje, Titulo)
	'End Function

	Public Function Nombre_Cuenta_Largo(ByVal IdCuenta As String) As String
		If IdCuenta = "" Then
			Return ""
		End If


		Dim Dr() As DataRow
		Dr = DtCta.Select("id=" & ValD(IdCuenta).ToString)
		If Dr.Length = 0 Then
			SonarWAV("error")
			Mensaje("Cuenta No existe (Id=" & IdCuenta & ")")
			Return ""
		End If

		Dim Tit As Integer = Dr(0).Item("id_con_cta_tit")
		Dim Descri As String = Dr(0).Item("descripcion")


		Dr = DtCtaTit.Select("id=" & Tit.ToString)
		If Dr.Length = 0 Then
			'Mensaje("no existe cuenta id=" & IdCuenta)
			'Return "no existe cuenta id=" & IdCuenta
			Return ""
		End If

		Return Descri & DMScr(2) &
		IIf(Dr(0).Item("id_con_cta_tit_may") Is System.DBNull.Value, "", Obtenga_Dato(DtCtaTit, "id=" & ValD("" & Dr(0).Item("id_con_cta_tit_may")), "descripcion") & DMScr()) &
		IIf(Dr(0).Item("id_con_cta_tit_sub1") Is System.DBNull.Value, "", Obtenga_Dato(DtCtaTit, "id=" & ValD("" & Dr(0).Item("id_con_cta_tit_sub1")), "descripcion") & DMScr()) &
		IIf(Dr(0).Item("id_con_cta_tit_sub2") Is System.DBNull.Value, "", Obtenga_Dato(DtCtaTit, "id=" & ValD("" & Dr(0).Item("id_con_cta_tit_sub2")), "descripcion") & DMScr()) &
		IIf(Dr(0).Item("id_con_cta_tit_sub3") Is System.DBNull.Value, "", Obtenga_Dato(DtCtaTit, "id=" & ValD("" & Dr(0).Item("id_con_cta_tit_sub3")), "descripcion") & DMScr()) &
		IIf(Dr(0).Item("id_con_cta_tit_sub4") Is System.DBNull.Value, "", Obtenga_Dato(DtCtaTit, "id=" & ValD("" & Dr(0).Item("id_con_cta_tit_sub4")), "descripcion") & DMScr()) &
		IIf(Dr(0).Item("id_con_cta_tit_sub5") Is System.DBNull.Value, "", Obtenga_Dato(DtCtaTit, "id=" & ValD("" & Dr(0).Item("id_con_cta_tit_sub5")), "descripcion") & DMScr()) &
		Obtenga_Dato(DtCtaTit, "id=" & ValD("" & Dr(0).Item("id")), "descripcion")


	End Function


	'Public Function ReemDMS(ByVal Cadena As String, ByVal Anteriores() As String, ByVal Nuevos() As String) As String
	'    If Anteriores.Length <> Nuevos.Length Then Return ""
	'    Dim Length As Integer = Anteriores.Length

	'    For I = 0 To Length - 1
	'        Cadena = Cadena.Replace(Anteriores(I), Nuevos(I))
	'    Next
	'    Return Cadena
	'End Function

End Module


Public Class DataDescription
	Public Data As String
	Public Description As String
	Public Sub New(ByVal Newdata As String, ByVal NewDescription As String)
		Data = Newdata
		Description = NewDescription
	End Sub
	Public Overrides Function ToString() As String
		Return Description
	End Function

End Class

Public Class Proxy_SMD
	Private _Si As Short = -1
	Private _Certif As Short = -1
	Private _User_Si As Short = -1
	Private _DirURL As String = ""
	Private _Puerto As String = ""
	'Private _TextoNodo As String = ""
	Private _Usuario As String = ""
	Private _Clave As String = ""

	Property Si() As Short
		Get
			Si = _Si
		End Get
		Set(ByVal value As Short)
			_Si = value
		End Set
	End Property
	Property Certific() As Short
		Get
			Certific = _Certif
		End Get
		Set(ByVal value As Short)
			_Certif = value
		End Set
	End Property
	Property User_Si() As Short
		Get
			User_Si = _User_Si
		End Get
		Set(ByVal value As Short)
			_User_Si = value
		End Set
	End Property
	Property DirURL() As String
		Get
			DirURL = _DirURL
		End Get
		Set(ByVal value As String)
			_DirURL = value
		End Set
	End Property
	'Property TextoNodo() As String
	'    Get
	'        TextoNodo = _TextoNodo
	'    End Get
	'    Set(ByVal value As String)
	'        _TextoNodo = value
	'    End Set
	'End Property
	Property Puerto() As String
		Get
			Puerto = _Puerto
		End Get
		Set(ByVal value As String)
			_Puerto = value
		End Set
	End Property
	Property Usuario() As String
		Get
			Usuario = _Usuario
		End Get
		Set(ByVal value As String)
			_Usuario = value
		End Set
	End Property
	Property Clave() As String
		Get
			Clave = _Clave
		End Get
		Set(ByVal value As String)
			_Clave = value
		End Set
	End Property

End Class