' Version: 694, 28-sep.-2018 12:57
' Version: 687, 5-sep.-2018 13:13
' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 21:33
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 679, 16-ago.-2018 21:01
' Version: 678, 16-ago.-2018 14:15
' Version: 677, 15-ago.-2018 13:39
' Version: 676, 14-ago.-2018 22:29
' Version: 675, 14-ago.-2018 18:45
' Version: 669, 24-jul.-2018 07:54
' Version: 665, 16-jul.-2018 13:20
' Version: 647, 24-abr.-2018 12:31
' Version: 636, 9-mar.-2018 13:03
' Version: 632, 1-mar.-2018 13:22
' Version: 625, 14-feb.-2018 12:31
' Version: 622, 8-feb.-2018 20:05
' Version: 621, 8-feb.-2018 12:41
' Version: 601, 29-nov.-2017 12:05
' Version: 593, 27-oct.-2017 09:31
'♥ versión: 586, 6-oct.-2017 07:11
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.IO

Public Module GlobalesVarios
	Public ColActual As String 'SGQ-664
	Dim fBusCli As New fBuscarCliente

	Public Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As POINTAPI) As Integer
	Public Structure POINTAPI
		Dim X As Integer
		Dim Y As Integer
	End Structure
	Public EstadoActual As Short = -1

	Public fDestiModal As fDestinos

	Public Const NombreArchivoLogoSMD = "logosmd.jpg" 'poner aquí el nombre del logo, cada vez que cambie el logo en fLogin, aumentar un numerito en este nombre

	'esta variable se debe prenbder en el load de algunos programas y apagarla en shown
	Public EvitarPrenderReloj As Boolean = False
	'Public EstoyEnSplash As Boolean = False

	Public DtDigPreg As New DataTable
	'Public CargoItemsDesdeBD As Boolean = False
	Public DtGruDig As New DataTable
	Public DtUsu As New DataTable
	Public DtUsuUsu As New DataTable
	Public DtProg As New DataTable
	Public DtProgPerm As New DataTable
	Public DtTributario As New DataTable
	Public DtMeses As New DataTable

	Public PosicionPantalla As Point
	'Public FaltaTraducir As Boolean = False

	'Public fRelojito As New fMostrarSonido
	'Public fRelojito As New fSplash
	'Public fRel As New fMostrarSonido
	Public fSpl As New fSplash
	Public IgnorarEfectos As Boolean = False
	Public ContinuarAdvance As Boolean = False
	Public JuntarMensajes As Boolean = False
	Public TamañoEmoticos As Short = 2
	Public IgnorarMensajesUrgentes As Boolean = False
	Public fUltimaPantallaMensaje As Form
	Public ItemBuscado As String = ""
	Public IdCotizaInicial As String = ""
	Public ProgInicial As String = ""
	Public IgnorarPermisosUsuarioServicio As Boolean = False
	Public SilenciarVoz As Short = 0

	Public DtTalla As New DataTable
	Public DtColor As New DataTable
	Public DtUsuCli As New DataTable


	Public DtLicAddIn As New DataTable
	Public DtTipoPago As New DataTable
	Public DtVenceDemo As New DataTable
	Public DtPuntosDef As New DataTable
	Public DtPrecios As New DataTable
	Public DtTipoPerfil As New DataTable
	Public DtInformes As New DataTable
	Public DtClaseVeh As New DataTable
	Public DtServicioVeh As New DataTable
	Public DtTipPerfil As New DataTable
	Public DtCli As New DataTable
	Public DtCtaAfe As New DataTable

	Public DtCtaRet As DataTable

	'Public DtCliDesconectado As New DataTable
	Public FmtDesconectado As New DataTable
	Public DtIvasDesconectado As New DataTable
	Public DtTributarioDesconectado As New DataTable
	Public DtUltimoDesconectado As DataTable

	Public DtClienteItem As New DataTable
	Public DtVend As New DataTable
	Public DtListas As New DataTable
	Public DtPermisos As New DataTable
	Public DtSw As New DataTable
	Public DtZona As New DataTable
	Public DtTipo As New DataTable
	Public DtItem As New DataTable
	Public DtItemSustitutos As New DataTable
	Public DtItemCampos As New DataTable
	Public DtListasFijas As New DataTable
	Public DtCategorias As New DataTable
	Public DtTipoRetItem As DataTable
	Public DtProveedores As New DataTable

	Public DtBancos As New DataTable
	Public DtItemLotes As New DataTable
	'Public DtListasFac As DataTable
	Public DtItemPrereq As New DataTable
	Public DtItemCod As New DataTable
	Public DtItemEstruc As New DataTable
	Public DtCta As New DataTable
	Public DtCtaTit As New DataTable
	Public DtFormaPago As New DataTable
	Public DtBilletes As New DataTable
	'Public DtReciboConcepto As New DataTable
	'Public dtConceptos As New DataTable

	'Public DtLicFac As New DataTable
	'Public DtLicTaller As New DataTable
	'Public DtLicCartera As New DataTable
	'Public DtLicCRM As New DataTable
	Public DtDescu As DataTable
	Public DtItemSub5 As DataTable
	Public DtCotizacionEstado As New DataTable
	Public DtBodegas As New DataTable
	Public DtTitPantalla As New DataTable
	Public DtEmp As New DataTable
	Public DtCco As New DataTable
	Public DtPais As New DataTable
	Public DtBodegasPerm As New DataTable
	Public DtActTipos As New DataTable
	Public DtEventosTipos As New DataTable
	Public DtMesas As New DataTable
	Public SQL As String = ""

	'Public FechaHoy As DateTime

	Public DtEstados As New DataTable
	Public DtTipoTributario As New DataTable
	Public DtActividades As New DataTable
	Public DtOrigenes As New DataTable
	Public DtContCargos As New DataTable
	Public DtBancos_e As New DataTable
	Public DtBancos_e_Tipo As New DataTable
	Public DtBancos_e_Concep As New DataTable
	Public DtContProfesiones As New DataTable
	Public FormatoImp As New DataTable
	Public FormatoImpSw As New DataTable
	Public DtCotGrupos As New DataTable
	Public DtCotGruposConta As New DataTable
	Public DtCotIva As New DataTable
	Public DtUnidades As DataTable
	Public DtCotIva2 As DataTable

	Public DtVehMarca As New DataTable
	Public DtVehLinea As New DataTable
	Public DtVehModelo As New DataTable
	Public EvitarRelojArena As Boolean = False
	Public DtColores As New DataTable
	Public IncluirVendidosAnulados As Boolean = False
	'SGQ-x: Destino por línea
	Public UsaDestinosItem As Boolean
	Public IdCenBod As Integer
	'/SGQ-x: Destino por línea
	Public Function pppp(appp As Object) As Boolean
		If GetSetting("DMS S.A.", "fC", "relojare", "0") = "1" Then
			EvitarRelojArena = True
		Else
			'por si está caido o es desarrollo
			Ejecute_Proceso(Path_Prog & "RelojAdv.exe")
		End If
		SiReloj(fBusIt)


		'para el sistema desconectado
		If GetSett("Conecc", "express", "0") = "1" Then
			EstoyDesconectadoNuevo = True
		End If

		Dim Idio As String = ValD(GetSetting("DMS S.A.", "relojito", "lang", "0"))
		LenguajeAdvance = 0
		If Idio = "1" Then 'es ingles
			LenguajeAdvance = 1
			Montar_Idi(DtIdioma)
		End If


		SaveSett("ulttem", My.Application.Info.AssemblyName, "") 'para limpiar el exe en memoria
		Tomar_IP_Advance()

		'If My.Application.Info.ProductName = "SMDNotas" Then

		'End If


		'para la configuración regional correcta
		'If EstaEnLista(Usuario, 2, 25, 34, 99, 128, 3172, 1675, 14, 106, 107, 65, 73, 33, 1665, 98, 58, 4224, 95, 4863) Then
		'    System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-US")
		'End If

		'validación de moneda
		If Strings.Format(10005 / 2, "#,##0.00") <> "5,002.50" Or Not FormatoMoneda(10005 / 2, DigitosDespuesDelPunto:=2).Contains("5,002.50") Then
			Try
				System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-US")
			Catch
			End Try
			If Strings.Format(10005 / 2, "#,##0.00") <> "5,002.50" Or Not FormatoMoneda(10005 / 2, DigitosDespuesDelPunto:=2).Contains("5,002.50") Then
				Mensaje("Configuración regional errada. Utilice los números al estilo US, es decir, la coma para separar miles y el punto para separar decimales.  Corrija su configuración e intente de nuevo")
				Return False
			End If
		End If

		'NoReloj(fBusIt)
		'Pantalla_Splash()

		'MarcaExterna = BuscarIpFija()
		'If MarcaExterna = "" Then
		'    Return False
		'End If

		If My.Application.Info.AssemblyName <> "SMDAlertas" And My.Application.Info.AssemblyName <> "SubirVersion" Then
			If appp.CommandLineArgs.Count <> 2 Then 'para preguntar usuario servicio
				If appp.CommandLineArgs.Count <> 10 Then 'no usuario servicio
					Pantalla_Splash(True)
					Mensaje("Esta aplicación solo debe ser llamada desde Advance")
					Return False
				End If
			End If
		End If


		'--------------------------------------------------------------
		If appp.CommandLineArgs.Count > 2 Then 'para preguntar
			Usuario = ValD(appp.CommandLineArgs(0).ToString)
			Nodo = ValD(appp.CommandLineArgs(1).ToString) 'esto ya no se necesita para nada
			Numero_Empresa = ValD(appp.CommandLineArgs(2).ToString)
			Sector_Empresa = ValD(appp.CommandLineArgs(3).ToString)
			IdCotizaInicial = appp.CommandLineArgs(4).ToString
			Nit_Empresa = appp.CommandLineArgs(5).ToString
			ProgInicial = appp.CommandLineArgs(6).ToString
			MiCodigo = appp.CommandLineArgs(7).ToString
			MiEmpresa = appp.CommandLineArgs(8).ToString
			SoyServicio = ValD(appp.CommandLineArgs(9).ToString)

			DebugJD("Recibo parametros: " & DMScr() &
				"0=" & Usuario.ToString & DMScr() &
				"1=" & Nodo.ToString & DMScr() &
				"2=" & Numero_Empresa.ToString & DMScr() &
				"3=" & Sector_Empresa.ToString & DMScr() &
				"4=" & IdCotizaInicial.ToString & DMScr() &
				"5=" & Nit_Empresa.ToString & DMScr() &
				"6=" & ProgInicial.ToString & DMScr() &
				"7=" & MiCodigo.ToString & DMScr() &
				"8=" & MiEmpresa.ToString & DMScr() &
				"9=" & SoyServicio.ToString)
		End If

		'--------------------------------------------------------------
		MarcaExterna = BuscarIpFija()

		'Mensaje("serv:" & SoyServicio)
		If MarcaExterna = "" Then
			Return False
		End If
		If MarcaExterna = "col" And SoyServicio <> 2 Then 'jdms 622 para excluir el nuevo sistema de multiempresa
			SoyServicio = 0
		End If
		If MarcaExterna = "3" Then
			MarcaExterna = "col"
		End If

		'la última
		'If MarcaExterna = "5" Then
		'    MarcaExterna = "col"
		'    SoyServicio = 0
		'End If

		'--------------------------------------------------------------


		'usuarios de servicio
		UsuarioOriginal = Usuario

		'TRUCO JD: 28-nov-13
		'If MarcaExterna <> "col" And MarcaExterna <> "local" And DesdeFuente = False Then
		'    SoyServicio = 0
		'End If

		'If (IdCotizaInicial = "" Or IdCotizaInicial = "0") And SoyServicio > 0 Then
		DebugJD("GlobalesVarios: Marca: " & MarcaExterna & ", URL: " & Ppal.Ws.Url)

		'ESTO ERA PARA QUE NO PREGUNTARA EL NODO, PERO NO SE PUEDE
		'If SoyServicio > 0 And (IdCotizaInicial = "" Or IdCotizaInicial = "0" Or Left(IdCotizaInicial, 1) = "*") Then 'solo entra si no trae numero inicial


		'Mensaje("serv2:" & SoyServicio)
		If SoyServicio > 0 Then 'solo entra si no trae numero inicial

			If Entrar_Usuario_Servicio(IdCotizaInicial, ProgInicial) = False Then
				If appp.CommandLineArgs.Count = 2 Or Usuario = 0 Then
					Pantalla_Splash(True)
					Return False
				End If
			End If
		End If

		DebugJD("IdCotizaInicial GlobalesVarios: " & IdCotizaInicial.ToString)

		If IdCotizaInicial = " " Then IdCotizaInicial = ""


		Return True

	End Function
	Public Sub Empezar_Cerrado_Forma(FormaCerrar As Form)
		Try
			PosicionPantalla = FormaCerrar.Location
			FormaCerrar.Opacity = 0.5
			FormaCerrar.Enabled = False
			HagaEventos()
		Catch ex As Exception
		End Try

	End Sub
	Public Function ContarLineasDt(ByVal dt As DataTable) As Integer

		Return dt.Rows.Count


	End Function
	Public Function EsIngles() As String
		Return Chr(160)

	End Function
	Public Function ClienteNoValido(IdCli As Integer, RazonSocial As String, Optional Mostrar As Boolean = True) As Boolean
		Try
			If DtUsuCli.Rows.Count = 0 Then
				Return False
			Else
				If Obtenga_Dato(DtUsuCli, "id_cot_cliente=" & IdCli.ToString, "id_cot_cliente") Is System.DBNull.Value Then
					If Mostrar Then
						Mensaje_TopMost("Usted solo puede hacer documentos a ciertos clientes fijos y " & RazonSocial & " no está en su lista de clientes")
					End If
					Return True
				Else
					Return False
				End If
			End If
		Catch ex As Exception
			Return False

		End Try

	End Function
	Public Function Opcion_Abrir_Documento(Optional ByVal TextoAdi As String = "") As String
		Dim UltNum As Integer = 0
		If IsNumeric(TextoAdi) Then
			If ValD(TextoAdi) = 0 Then
				TextoAdi = ""
			Else
				UltNum = ValD(TextoAdi)
				TextoAdi = "- " & Idi("Ingrese U para abrir último") & " ID=" & UltNum
			End If
		End If
		Dim Num As String = Inputbox2(Idi("Opciones para abrir un documento") &
									  ":" & DMScr(2) & "- " &
									  Idi("Entre Id del documento que desea abrir") & DMScr() & "- " &
									  Idi("Entre 0 para buscar") & DMScr() &
									  "- " & Idi("Presione ESC para cancelar") &
									  IIf(TextoAdi = "", "", vbNewLine & DMScr() & TextoAdi) & DMScr(2), "Abrir un documento")

		If UCase(Num) = "U" Then
			Return UltNum
		End If

		If Num <> "0" And Num <> "" Then
			Num = ValD(Num)
			If Not IsNumeric(Num) Then
				Mensaje("Número inválido")
				Num = ""
			ElseIf Math.Abs(ValD(Num)) > 2147483647 Then
				Mensaje("Número muy grande")
				Num = ""
			ElseIf ValD(Num) < 0 Then
				Mensaje("Número no puede ser negativo")
				Num = ""
			End If
		End If
		Return Num


	End Function

	Public Function Filtrar_DataTable(ByVal dt As DataTable, ByVal filter As String, Optional ByVal sort As String = "") As DataTable
		Dim rows As DataRow()
		Dim dtNew As DataTable
		dtNew = dt.Clone()
		rows = dt.Select(filter, sort)
		For Each dr As DataRow In rows
			dtNew.ImportRow(dr)
		Next
		Return dtNew
	End Function
	Public Sub Validar_Combo_KeyDown(ByVal Combo As ComboBox)
		Try

			Combo.DroppedDown = False

		Catch

		End Try

	End Sub
	Public Function Buscar_Texto_Combo(ByRef Combo As ComboBox) As Integer
		Try
			Dim Val As Integer = -1
			Dim DtTemp As DataTable = Combo.DataSource
			For i As Integer = 0 To DtTemp.Rows.Count - 1
				If Combo.Text.ToUpper = DtTemp.Rows(i).Item(Combo.DisplayMember).ToString.ToUpper Then
					Val = i
					Exit For
				End If
			Next

			If Val = -1 Then
				Combo.Text = ""
			End If

			Return Val

		Catch ex As Exception
			Try
				Dim Val As Integer = -1
				For i As Integer = 0 To Combo.Items.Count - 1
					If Combo.Text.ToUpper = Combo.Items(i).ToString.ToUpper Then
						Val = i
						Exit For
					End If
				Next

				Return Val

			Catch ex1 As Exception
				Return -1

			End Try

		End Try

	End Function
	Public Function SinTildes(ByVal Texto As String) As String

		Texto = Replace(Texto, "á", "a")
		Texto = Replace(Texto, "é", "e")
		Texto = Replace(Texto, "í", "i")
		Texto = Replace(Texto, "ó", "o")
		Texto = Replace(Texto, "ú", "u")
		Texto = Replace(Texto, "Á", "A")
		Texto = Replace(Texto, "É", "E")
		Texto = Replace(Texto, "Í", "I")
		Texto = Replace(Texto, "Ó", "O")
		Texto = Replace(Texto, "Ú", "U")

		Return Texto

	End Function
	Public Sub Copiar_Exel2(ByVal Grd As DataGridView)
		Try
			If Grd.Rows.Count = 0 Or Grd.Visible = False Then
				Mensaje("No hay nada para copiar actualmente")
				Exit Sub
			End If
			Reloj(True)
			Dim Texto As String = ""

			Dim I As Integer

			For j = 0 To Grd.ColumnCount - 1
				Try
					If Not Grd.Columns(j).Visible Then
						Continue For
					End If
					Texto = Texto & QuiteBasura("" & Grd.Columns(j).HeaderText) & Chr(9)
				Catch ex As Exception
				End Try
			Next
			Texto = Texto & DMScr()

			For I = 0 To Grd.Rows.Count - 1
				If Grd.Rows(I).Visible Then
					For j = 0 To Grd.ColumnCount - 1
						If Grd.Columns(j).Visible Then
							Try
								Texto = Texto & QuiteBasura("" & Grd.Rows(I).Cells(j).Value.ToString) & Chr(9)
							Catch ex As Exception
								Texto = Texto & Chr(9)
							End Try
						End If
					Next
					Texto = Texto & DMScr()
				End If
			Next
			My.Computer.Clipboard.SetText(Texto)

			Reloj(False)

			Mensaje("Abra el programa donde desea pegar esta información y presione Ctrl-V (o clic en Editar y Pegar)")


		Catch ex As Exception
			Mensaje("No fue posible copiar el texto: " & ex.Message & EsIngles())

			Reloj(False)

		End Try

	End Sub
	Public Function PidaUsuarios(ByVal Titulo As String,
							 ByVal Usuarios As String,
							 ByVal UsuNoValida As String,
							 ByVal QueSoy As String,
							 ByVal Propietario As Integer,
							 ByVal DtUsuarios As DataTable,
							 Optional ByVal NoLinkTodos As Boolean = True,
							 Optional ByVal NoLinkNinguno As Boolean = False,
							 Optional ByVal SoloUnUsuario As Boolean = False) As String
		Dim fFe As New fUsuarios
		fFe.Text = Idi(Titulo)
		fFe.Propietario = Propietario
		fFe.Tag = QueSoy
		fFe.SoloUnUsuario = SoloUnUsuario

		fFe.LLene_Usuarios(DtUsuarios, Usuarios, UsuNoValida, NoLinkTodos, NoLinkNinguno)
		fFe.ShowDialog()
		Return fFe.Tag

	End Function

	Public Function PidaClave() As Boolean
		Dim fCla As New fClave
		If Mid(SMDPpal.SQL, 1, 2) = "/*" Then 'clave fija
			fCla.ClaveFija = Mid(SMDPpal.SQL, 3)
		End If
		fCla.ShowDialog()
		If ValD(fCla.Tag) = 1 Then
			Return True
		Else
			Return False
		End If

	End Function

	Public Function Copiar_Exel(ByVal grid As DataGridView, Optional ByVal NombreArchivo As String = "", Optional ByVal TituloInforme As String = "") As String
		'Dim Excel As Object
		'Dim Libro As Object
		Try

			'If grid.Rows.Count = 0 Then
			'    MsgBox("No hay datos para exportar a excel") : Exit Sub
			'End If

			'Dim Resp As Integer
			'If NombreArchivo = "" Then
			'    Resp = PregunteCancel("Desea abrir estos datos en Excel (responda N para copiarlos al portapapeles)?")
			'    If Resp = MsgBoxResult.Cancel Then Exit Sub
			'    If Resp = MsgBoxResult.No Then
			'        Copiar_Exel2(grid)
			'        Exit Sub
			'    End If
			'End If


			Dim fCop As New fCopiarExcel
			fCop.Grid = grid
			fCop.NombreArchivo = NombreArchivo
			fCop.TituloInforme = TituloInforme
			fCop.ShowDialog()
			If fCop.CmdCancelar.Tag = "S" Then
				Return "N"
			Else
				Return ""
			End If

			'SiReloj()

			'Dim TyExcel As Type = Type.GetTypeFromProgID("Excel.Application")

			'If TyExcel Is Nothing Then Copiar_Exel2(grid) : Exit Sub
			'Dim Obj_Hoja As Object
			'Dim i As Integer, j As Integer
			'Excel = CreateObject("Excel.Application")
			'Libro = Excel.Workbooks.Add
			'Obj_Hoja = Libro.ActiveSheet()



			''Hoja activa   
			'Obj_Hoja = Excel.ActiveSheet

			'' Recorre el Datagrid 
			'Dim iCol As Integer = 0
			'Dim FilaTitulo As Integer = 7
			'Dim n_Filas As Integer = grid.Rows.Count
			'For i = 0 To grid.Columns.Count - 1
			'    If grid.Columns(i).Visible Then
			'        iCol = iCol + 1
			'        'Caption de la columna   
			'        If iCol = 1 Then
			'            Dim Tit1 As String = MiEmpresaNombre
			'            Dim Tit2 As String = FormatoFecha(Now, True)
			'            Dim Tit3 As String = TituloInforme
			'            Dim Tit4 As String = ""
			'            Dim Tit5 As String = ""
			'            Dim JI As Integer = InStr(TituloInforme, ")")
			'            If JI > 0 Then
			'                Tit3 = Trim(Mid(TituloInforme, JI + 1)) 'titulo reporte + parametros
			'                Tit4 = Trim(Mid(TituloInforme, 1, JI)) 'programa
			'                Dim J2 As Integer = InStr(Tit3, "(")
			'                If J2 > 0 Then
			'                    Tit5 = Trim(Mid(Tit3, J2))
			'                    Tit3 = Trim(Mid(Tit3, 1, J2 - 1))
			'                End If
			'            End If
			'            Obj_Hoja.Cells(1, 1) = "Empresa" : Obj_Hoja.Cells(1, 2) = ": " & Tit1
			'            Obj_Hoja.Cells(2, 1) = "Fecha" : Obj_Hoja.Cells(2, 2) = ": " & Tit2
			'            Obj_Hoja.cells(1, 1).font.bold = True
			'            Obj_Hoja.cells(2, 1).font.bold = True
			'            FilaTitulo = 4
			'            If Tit3 <> "" Then
			'                Obj_Hoja.Cells(3, 1) = "Reporte" : Obj_Hoja.Cells(3, 2) = ": " & Tit3
			'                Obj_Hoja.cells(3, 1).font.bold = True
			'                FilaTitulo = 5
			'                If Tit4 <> "" Then
			'                    Obj_Hoja.Cells(4, 1) = "Programa" : Obj_Hoja.Cells(4, 2) = ": " & Tit4
			'                    Obj_Hoja.cells(4, 1).font.bold = True
			'                    FilaTitulo = 6
			'                    If Tit5 <> "" Then
			'                        Obj_Hoja.Cells(5, 1) = "Parámetros" : Obj_Hoja.Cells(5, 2) = ": " & Tit5
			'                        Obj_Hoja.cells(5, 1).font.bold = True
			'                        FilaTitulo = 7
			'                    End If
			'                End If
			'            End If
			'        End If

			'        Obj_Hoja.Cells(FilaTitulo, iCol) = grid.Columns(i).HeaderText
			'        Dim Fila As Integer = FilaTitulo + 1
			'        For j = 0 To n_Filas - 1
			'            'asigna el valor a la celda del Excel 
			'            If grid.Rows(j).Visible Then
			'                Try
			'                    Obj_Hoja.Cells(Fila, iCol) = grid.Rows(j).Cells(i).Value.ToString
			'                    Fila += 1
			'                Catch 'ex As Exception

			'                End Try
			'            End If
			'        Next
			'    End If
			'Next
			''Obj_Hoja.Rows(1).Font.Bold = True
			''Obj_Hoja.Rows(2).Font.Bold = True
			''Obj_Hoja.Rows(3).Font.Bold = True
			''Obj_Hoja.Rows(4).Font.Bold = True
			''Obj_Hoja.Rows(5).Font.Bold = True
			''Obj_Hoja.Rows(6).Font.Bold = True
			'Obj_Hoja.Rows(FilaTitulo).Font.Bold = True
			''Autoajustamos   
			'Obj_Hoja.Columns("A:ZZ").AutoFit()
			''asas = Obj_Excel
			''Libro = Obj_Libro
			''Ponemos la aplicación excel visible   

			''If NombreArchivo = "" Then
			''    Excel.Visible = True
			''Else
			''    Excel.Visible = False
			''End If

			'NoReloj()

			'If NombreArchivo <> "" Then
			'    Excel.Visible = False
			'    If IO.File.Exists(NombreArchivo) Then
			'        IO.File.Delete(NombreArchivo)
			'    End If
			'    Dim xlText As Long
			'    xlText = -4143

			'    Libro.SaveAs(NombreArchivo, xlText, , , , , , , , , , True)
			'    Excel.Quit()
			'Else
			'    Excel.Visible = True
			'End If

			'Libro = Nothing
			''Process.Start(NombreArchivo)
		Catch ex As Exception
			NoReloj()
			Mensaje("Operación no pudo ser completada: " & ex.Message & EsIngles())
			Return "N"

		End Try

	End Function
	''' <summary>
	'''  poner reloj viejo
	''' malo
	''' </summary>
	''' <param name="Que"></param>
	''' <remarks></remarks>
	Public Sub Reloj(Optional ByVal Que As Boolean = True)
		If Que = True Then
			If Not EvitarPrenderReloj Then
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
			End If
		Else
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		End If
		'System.Windows.Forms.Application.DoEvents()

	End Sub
	''' <summary>
	''' poner reloj si no esta puesto y quitarlo si fue puesto por mi
	''' ejemplo:
	''' Dim HayReloj = SiRelojCond() 'poner el relo si no está puesto
	''' Abrir(dd, Algo)
	''' SiRelojCond(HayReloj) 'quitar el reloj si yo lo acabé de poner
	''' </summary>
	''' <param name="QueHacer"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function SiRelojCond(Optional QueHacer As Short = 0) As Short
		Try
			If EvitarRelojArena Then
				Return 1
			End If

			If QueHacer = 1 Then 'yolo prendi, apagarlo
				NoReloj()
				Return 9
			ElseIf QueHacer = 2 Then 'el reloj no es mio, no aparglo
				Exit Function
			End If

			Dim pren = GetSetting("DMS S.A.", "relojito", "ent", 0)
			If pren = 1 Then 'ya está prendido
				Return 2 ' yo no lo prendí
			End If

			SiReloj() 'prenderlo

			Return 1 'indicar que fue prendido por mi

		Catch
		End Try

	End Function


	Public Sub SiReloj(Optional ByVal forma As Form = Nothing)
		If EvitarPrenderReloj Then
			Exit Sub
		End If

		If EvitarRelojArena Then
			'Dim Mouse As New POINTAPI
			'GetCursorPos(Mouse)
			'fRel.Left = Mouse.X
			'fRel.Top = Mouse.Y
			'fRel.Show()
			Exit Sub
		End If


		'Dim RR = GetSetting("DMS S.A.", "relojito", "ent", 1)
		''DebugJD("RR:" & RR)
		'If ValD(RR) = 1 Then 'ya está prendido
		'    Exit Sub
		'End If

		Try

			'Dim Mouse As New POINTAPI

			'If SoyHandHeld() Then
			'    fRelojito.StartPosition = FormStartPosition.CenterScreen
			'Else
			'    GetCursorPos(Mouse)
			'    fRelojito.Left = Mouse.X
			'    fRelojito.Top = Mouse.Y
			'End Ifc

			'Dim Estoy As Boolean = False
			'For Each _Process As Process In Process.GetProcessesByName(Path_Prog & "RelojAdv.exe")
			'    Estoy = True
			'    Exit For
			'Next
			'If Not Estoy Then
			'    Ejecute_Proceso(Path_Prog & "RelojAdv.exe")
			'End If

			'Dim Mouse As New POINTAPI


			If forma Is fBusIt Then 'para que no lo apague
				EvitarPrenderReloj = True
				SaveSetting("DMS S.A.", "relojito", "evi", "1")
			End If

			SaveSetting("DMS S.A.", "relojito", "ent", 1)



			''EjecReloj(Path_Prog & "RelojAdv.exe", "1")

			''Shell((Path_Prog & "RelojAdv.exe 1",  AppWinStyle.MaximizedFocus, True)

			'Shell(Path_Prog & "RelojAdv.exe 1", AppWinStyle.NormalNoFocus)


			'fRelojito.CambiarTamaño()
			'fRelojito.Show()

			'HagaEventos()
		Catch ex As Exception

		End Try

	End Sub
	'Private Sub EjecReloj(ByVal NombreProceso As String, Optional ByVal Argumentos As String = "")
	'    Dim Pro As New Process
	'    Pro.StartInfo.FileName = NombreProceso
	'    If Argumentos <> "" Then
	'        Pro.StartInfo.Arguments = Argumentos
	'    End If
	'    'Pro.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
	'    'Pro.StartInfo.CreateNoWindow = True
	'    Pro.StartInfo.UseShellExecute = True
	'    Pro.Start()

	'End Sub
	Public Sub NoReloj(Optional ByVal forma As Form = Nothing)
		If EvitarRelojArena Then
			'fRel.Hide()
			Exit Sub
		End If


		If GetSetting("DMS S.A.", "relojito", "evi", 0) = "1" Then
			EvitarPrenderReloj = True
		End If

		If forma Is fBusIt Then 'truco para quitar esta condición
			EvitarPrenderReloj = False
			SaveSetting("DMS S.A.", "relojito", "evi", "0")
		End If

		If EvitarPrenderReloj Then
			Exit Sub
		End If


		Try
			If forma IsNot Nothing Then
				forma.UseWaitCursor = False
			End If

			SaveSetting("DMS S.A.", "relojito", "ent", 0)
			'Ejecute_Proceso(Path_Prog & "RelojAdv.exe")
			'EjecReloj(Path_Prog & "RelojAdv.exe", "0")
			'Shell(Path_Prog & "RelojAdv.exe 0", AppWinStyle.NormalNoFocus)


			Reloj(False)

		Catch ex As Exception

		End Try

	End Sub
	Private Function QuiteBasura(ByVal Texto As String) As String
		Dim Tex As String = Texto
		Tex = Replace(Tex, Chr(9), " ")
		Tex = Replace(Tex, Chr(13), " ")
		Tex = Replace(Tex, Chr(10), " ")

		Return Tex

	End Function
	Public Sub Click_Derecho_Grid(ByVal Grid As DataGridView, ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
		If Grid.MultiSelect Then Exit Sub 'truco solo para 0250

		Try
			If e.Button = Windows.Forms.MouseButtons.Right Then
				Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)
				If hti.Type = DataGridViewHitTestType.Cell Then
					ColActual = Grid.Columns(hti.ColumnIndex).Name 'SGQ-664
					If Not Grid.Rows(hti.RowIndex).Selected Then
						Grid.ClearSelection()
						'Grid.Rows(hti.RowIndex).Selected = True
						'Grid.Columns(hti.ColumnIndex).Selected = True
						Grid.Rows(hti.RowIndex).Cells(hti.ColumnIndex).Selected = True
					End If
				End If
			End If

		Catch ex As Exception

		End Try

	End Sub

	Public Sub HagaEventos()
		Try
			System.Windows.Forms.Application.DoEvents()

		Catch ex As Exception

		End Try

	End Sub
	Public Function TraerFilaDT(ByVal Dt As DataTable, ByVal Filtro As String)
		Dim Fila As Integer = 0

		Dim rows As DataRow()
		rows = Dt.Select(Filtro)
		For Each Dr As DataRow In Dt.Rows
			If Dr Is rows(0) Then
				Fila = Dt.Rows.IndexOf(Dr)
				Exit For

			End If
		Next
		Return Fila


	End Function
	Public Function CrearPDF(ByVal NombreArchivo As String, ByVal TextoRTF As RichTextBox) As Boolean

		Try
			Dim result As Boolean = False
			Dim Rp As New Rpn

			Rpn.RpsSetLicenseKey("8HVD0-4K3T0-C76L1")

			Dim asa As Object = Rp.UserPassword
			result = Rp.RpsWriteToFile(NombreArchivo, Rp.RpsConvertBuffer(TextoRTF.Rtf))
			If Not result Then
				Throw New Exception
			End If
			Return True

		Catch ex As Exception 'este error se produce porque la foto esta siendo utilizada en otro proceso
			Mensaje("No logró crear el PDF: " & ex.Message & EsIngles())
			Return False

		End Try

	End Function






	Public Sub GuardarFechaHoy(ByVal FechaHoy As DateTime)
		Try
			SaveSett(DiegoSet, "rec20", Strings.Format(FechaHoy, "yyyy/MM/dd"))
		Catch
		End Try

	End Sub
	Public Sub Mensaje(ByVal TextoMensaje As String, Optional ByVal Titulo As String = "", Optional ByVal ImagenNumero As Integer = 0)
		If EstoyEnPregunta Then
			Exit Sub
		End If

		'      If Titulo = "" Then
		'	'Titulo = "DMS Advance" ' My.Application.Info.Title
		'	If LenguajeAdvance = 1 Then
		'		Titulo = My.Application.Info.Description
		'	Else
		'		Titulo = My.Application.Info.Title
		'	End If

		'End If

		Mensaje_TopMost(TextoMensaje, Titulo, , , , , , , , ImagenNumero)

		'EstoyEnPregunta = True
		'MsgBox(TextoMensaje, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, Titulo)
		'EstoyEnPregunta = False

	End Sub
	Public Function Serializar_Texto(ByVal GuardarRespuestaSI_NombreForma As String, ByVal GuardarRespuestaNO_NombreForma As String, ByVal Texto As String) As String
		Dim Suma As Integer = 0
		Dim Lng As Integer = 0
		For I As Integer = 1 To Texto.Length
			If Asc(Mid(Texto, I, 1)) > 32 And Asc(Mid(Texto, I, 1)) < 128 Then
				Suma += Asc(Mid(Texto, I, 1))
				Lng += 1
			End If
		Next

		'Return IIf(GuardarRespuestaSI_NombreForma <> "", GuardarRespuestaSI_NombreForma, GuardarRespuestaNO_NombreForma) & "-" & Texto.Length.ToString & "-" & Suma.ToString
		Return IIf(GuardarRespuestaSI_NombreForma <> "", GuardarRespuestaSI_NombreForma, GuardarRespuestaNO_NombreForma) & "-" & Lng.ToString & "-" & Suma.ToString

	End Function
	Public Sub AsignarImagenPrograma(ByRef PictureBox1 As PictureBox, ByVal ImagenNumero As Integer)
		Try
			Dim Fo As String
			PictureBox1.Image = Nothing
			PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

			'intentar con imagen de la empresa
			Fo = Path_Temp & "im_" & Strings.Format(ImagenNumero, "0000") & Numero_Empresa.ToString & ".jpg"
			If Dir(Fo, FileAttribute.Archive) = "" Then 'si la imagen no existe
				Fo = Path_Temp & "im_" & Strings.Format(ImagenNumero, "0000") & ".jpg"
				If Dir(Fo, FileAttribute.Archive) = "" Then 'si la imagen no existe
					Fo = Path_Temp & NombreArchivoLogoSMD
				End If
			End If

			Try 'este por velocidad de proceso
				PictureBox1.Image = System.Drawing.Image.FromFile(Fo)
			Catch
			End Try

			'por si acaso, también asignamos la localización
			PictureBox1.ImageLocation = Fo


			'probar con la estándar

		Catch ex As Exception

		End Try

	End Sub
	Public Sub AsignarImagenPrograma(ByRef Boton As Button, ByVal ImagenNumero As Integer)
		Try
			Dim Pic As New PictureBox
			AsignarImagenPrograma(Pic, ImagenNumero)
			Boton.Image = Pic.Image

		Catch ex As Exception

		End Try

	End Sub


	Public Function Mensaje_TopMost(ByVal TextoMensaje As String, Optional ByVal Titulo As String = "", Optional ByVal BotonReiniciar As Boolean = False, Optional ByVal EnviarDMS As Boolean = False,
									Optional ByVal Centrado As Boolean = False, Optional ByVal EsPregunta As Boolean = False, Optional ByVal TieneCancel As Boolean = False,
									Optional ByVal GuardarRespuestaSI_NombreForma As String = "", Optional ByVal GuardarRespuestaNO_NombreForma As String = "", Optional ByVal ImagenNumero As Integer = 0,
									Optional ByVal HabilitarAutorizacionElectronica As Integer = 0,
									Optional ByVal NumeroPermiso As Integer = 0,
									Optional Compleja As Short = 0) As String

		Mensaje_TopMost = ""


		If ProcesandoReporteProgramado Then
			Return "SI" 'por si es una pregunta
		End If

		TextoMensaje = Idi(TextoMensaje)

		If fSpl.Visible Then 'si está visible el splash, quitarlo
			Pantalla_Splash(True) 'quitarlo
		End If
		'apagar posible splash, que viene desde el menú que es otro exe
		SaveSetting("DMS S.A.", "fC", "spl", "1")

		'If Form.ActiveForm IsNot Nothing Then
		'    MsgBox(Form.ActiveForm.Name)
		'End If

		If EstoyEnPregunta Then
			Try
				fUltimaPantallaMensaje.TopMost = True
			Catch
			End Try
			If EsPregunta Then
				Return "NO"
			Else
				Return ""
			End If
		End If

		'If Titulo = "" Then
		'    Titulo = My.Application.Info.Title
		'End If

		If LenguajeAdvance = 1 Then
			Titulo = My.Application.Info.Description
		Else
			Titulo = My.Application.Info.Title
		End If

		Try
			Dim fMen As New fMensaje
			If ImagenNumero > 0 Then
				AsignarImagenPrograma(fMen.PictureBox1, ImagenNumero)
				AsignarImagenPrograma(fMen.PictureBox2, ImagenNumero)
				'Try
				'    Dim Fo As String = Path_Temp & "im_" & Strings.Format(ImagenNumero, "0000") & ".jpg"
				'    If Dir(Fo, FileAttribute.Archive) <> "" Then 'si la imagen existe
				'        fMen.PictureBox1.Image = Nothing
				'        fMen.PictureBox2.Image = Nothing
				'        fMen.PictureBox1.ImageLocation = Fo
				'        fMen.PictureBox2.ImageLocation = Fo
				'        fMen.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
				'        fMen.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
				'    End If
				'Catch
				'End Try
			End If

			If GuardarRespuestaSI_NombreForma <> "" Or GuardarRespuestaNO_NombreForma <> "" Then
				Dim RespuGua As String = GetSetting("DMS S.A. Preg", Usuario.ToString, Serializar_Texto(GuardarRespuestaSI_NombreForma, GuardarRespuestaNO_NombreForma, TextoMensaje), "")
				If RespuGua <> "" Then
					Return RespuGua
				End If
				fMen.ChkNoVolver.Visible = True
				If Not EstoyEnPregunta Then
					fMen.ChkNoVolver.Text = Idi("No mostrar más")
				End If
			End If
			fMen.GuardarNO_NombreForma = GuardarRespuestaNO_NombreForma
			fMen.GuardarSI_NombreForma = GuardarRespuestaSI_NombreForma
			fUltimaPantallaMensaje = fMen
			fMen.ShowIcon = False
			'fMen.CmdReiniciar.Visible = BotonReiniciar
			fMen.LnkEnviar.Visible = EnviarDMS
			fMen.LnkAutorizacion.Visible = HabilitarAutorizacionElectronica <> 0
			fMen.CodigoPrograma = HabilitarAutorizacionElectronica
			fMen.NumeroPermiso = NumeroPermiso
			fMen.Txt.Text = TextoMensaje
			If TextoMensaje.Length > 200 Then
				fMen.Txt.Font = fMen.ChkNoVolver.Font
			End If
			'fMen.Txt.TextAlign = IIf(Centrado, HorizontalAlignment.Center, HorizontalAlignment.Left)
			'fMen.LblTex.TextAlign = IIf(Centrado, ContentAlignment.MiddleCenter, ContentAlignment.MiddleLeft)
			fMen.Text = Titulo

			fMen.PnlSiNo.Visible = EsPregunta

			fMen.CmdCancelar.Visible = TieneCancel
			If TieneCancel Then
				fMen.CancelButton = fMen.CmdCancelar
			End If

			fMen.PnlNormal.Visible = Not EsPregunta
			If EsPregunta Then
				'fMen.AcceptButton = fMen.CmdSi
				'fMen.CancelButton = fMen.CmdNo
				'fMen.SplitContainer1.Panel1Collapsed = True
				fMen.PictureBox1.Visible = False
			Else
				fMen.PnlNormal.Location = fMen.PnlSiNo.Location
				fMen.PnlNormal.Size = fMen.PnlSiNo.Size
				'fMen.SplitContainer1.Panel2Collapsed = True
				fMen.PictureBox2.Visible = False
			End If

			fMen.PnlRespCompleja.Visible = False



RepitaCompleja:
			If Compleja > 0 Then
				'fMen.CmdAcepResp.Tag = CInt(Rnd() * 1000) 'si
				fMen.TxtResp.Tag = CInt(Rnd() * 1000) 'no
				'probar con los segundos, creo que es más random que el del sistema
				fMen.CmdAcepResp.Tag = CInt(Strings.Format(Now, "ss") * 10) + Strings.Format(Now, "ss") 'si


				If fMen.CmdAcepResp.Tag = fMen.TxtResp.Tag Then GoTo RepitaCompleja 'si quedaron iguales, volver a intentar
				fMen.PnlRespCompleja.Visible = True
				fMen.PnlRespCompleja.Location = fMen.PnlSiNo.Location
				fMen.PnlSiNo.Visible = False
				fMen.AcceptButton = fMen.CmdAcepResp
				If Compleja = 1 Then
					fMen.Txt.Text = fMen.Txt.Text.Replace("%s%", fMen.CmdAcepResp.Tag)
					fMen.Txt.Text = fMen.Txt.Text.Replace("%n%", fMen.TxtResp.Tag)
					'fMen.Txt.Text += " Responda SI ingresando " & fMen.CmdAcepResp.Tag & " y responda NO ingresando " & fMen.TxtResp.Tag
				Else
					fMen.Txt.Text += IIf(Mid(fMen.Txt.Text, Len(fMen.Txt.Text), 1) = ".", "", ".") & " Para continuar ingrese el número " & fMen.CmdAcepResp.Tag
				End If
				fMen.TxtResp.Focus()
			End If

			fMen.Txt.SelectionStart = 0

			EstoyEnPregunta = True
			fMen.ShowDialog()
			EstoyEnPregunta = False
			Return fMen.Tag

		Catch ex As Exception
			EstoyEnPregunta = False
			Mensaje(TextoMensaje)
			Return ""
		End Try

	End Function

	Public Function FechaHoyAsignada() As DateTime

		Try
			Dim Fec As String = GetSett(DiegoSet, "rec20", Strings.Format(Now, "yyyy/MM/dd"))
			If FechaSinHora(CDate(Fec)) <> FechaSinHora(Now) Then
				'tocó ir a la base de datos
				Dim DtFec As New DataTable
				Abrir(DtFec, "GetFechaServidor")
				GuardarFechaHoy(Gdf(DtFec, "fecha"))
				Fec = VB6.Format(Gdf(DtFec, "fecha"))
				TimeOfDay = Gdf(DtFec, "fecha") 'corregir la fecha hora del PC
			End If
			Return FechaSinHora(CDate(Fec))

		Catch
			Return FechaSinHora(Now)

		End Try


	End Function
	'Public Sub Asigne_FechaHoy()
	'    Dim Fec As String = Obtenga_Dato(DtPermisos, "id_programas=-1", "programa")
	'    Fec = Replace(Fec, ".", "/")
	'    FechaHoy = CDate(Strings.Format(CDate(Fec), "yyyy/MM/dd"))


	'End Sub
	Public Sub Abrir_Cliente(ByVal IdCli As Integer, ByVal Conta As Integer, Optional ByVal Modal As Boolean = False)
		AbrirPrograma("0150", IdCli)

	End Sub

	'    Public Sub Haga_Buscar_Cliente(ByRef IdCliente As Integer, ByRef RazonSocial As String, ByRef IdContacto As Integer, ByRef Nombre As String, Optional ByRef IdZona As Integer = 0, Optional ByRef IdZonaSub As Integer = 0)

	'Repita:

	'        Buscar_Cliente(Numero_Empresa, Sector_Empresa, IdCliente, RazonSocial, IdContacto, Nombre, IdZona, IdZonaSub)
	'        If IdCliente = 0 Then Exit Sub
	'        If IdCliente < 0 And IdContacto < 0 Then 'modificar
	'            Abrir_Cliente(IdCliente * -1, IdContacto, True)
	'            GoTo Repita
	'        End If
	'        If IdCliente < 0 And IdContacto = 0 Then 'crear
	'            Abrir_Cliente(0, 0, True)
	'            GoTo Repita
	'        End If


	'    End Sub

	Public Sub Haga_Buscar_Cliente(ByRef IdCliente As Integer,
								   ByRef RazonSocial As String,
								   ByRef IdContacto As Integer,
								   ByRef Nombre As String,
								   Optional ByRef IdZona As Integer = 0,
								   Optional ByRef IdZonaSub As Integer = 0,
								   Optional ByRef Nit As String = "",
								   Optional ByRef IdActividad As Integer = 0,
								   Optional ByRef IdPerfil As Integer = 0,
								   Optional ByVal Soy_0150 As Boolean = False,
								   Optional ByVal Destino As Short = 0,
								   Optional ByVal AceptaAnulados As Boolean = False,
								   Optional ByRef IdTipoTributario As Integer = 0
								   )

Repita:

		Buscar_Cliente(Numero_Empresa, Sector_Empresa, IdCliente, RazonSocial, IdContacto, Nombre, IdZona, IdZonaSub, Nit, IdActividad, IdPerfil, Soy_0150, Destino, AceptaAnulados, IdTipoTributario)
		If IdCliente = 0 Then Exit Sub
		If IdCliente < 0 And IdContacto < 0 Then 'modificar
			Abrir_Cliente(IdCliente * -1, IdContacto, True)
			GoTo Repita
		End If
		If IdCliente < 0 And IdContacto = 0 Then 'crear
			Abrir_Cliente(0, 0, True)
			GoTo Repita
		End If


	End Sub

	Public Sub Buscar_Cliente(ByVal Numero_Empresa As Integer,
							  ByVal Sector_Empresa As Integer,
							  ByRef IdCli As Integer,
							  ByRef RazonSocial As String,
							  ByRef IdContacto As Integer,
							  ByRef Nombre As String,
							  Optional ByRef IdZona As Integer = 0,
							  Optional ByRef IdZonaSub As Integer = 0,
							  Optional ByRef Nit As String = "",
							  Optional ByRef IdActividad As Integer = 0,
							  Optional ByRef IdPerfil As Integer = 0,
							  Optional ByVal Soy_0150 As Boolean = False,
							  Optional ByVal Destino As Short = 0,
							  Optional ByVal AceptaAnulados As Boolean = False,
							  Optional ByRef IdTipoTributario As Integer = 0
							  )

		'Static fBusCli As New fBuscarCliente
		'If IdCli = -1 Then
		'    Try
		'        Dim DDD As DataTable = fBusCli.Grd.DataSource
		'        DDD.Rows.Clear()
		'        fBusCli.Grd.DataSource = DDD
		'        fBusCli.Grd.Refresh()
		'    Catch
		'    End Try
		'    IdCli = 0
		'End If
		If IdCli = -1 Then
			Try
				fBusCli.Grd.Visible = False
				'fBusCli.DtCli2.Rows.Clear()
				'fBusCli.GridDms1.Grid.DataSource = fBusCli.DtCli2
			Catch
			End Try
			IdCli = 0
		End If

		If fBusCli.IdCon_Out <> fBusCli.IdCon_Out_Ant Then
			Try
				fBusCli.Grd.Visible = False
				'fBusCli.DtCli2.Rows.Clear()
				'fBusCli.GridDms1.Grid.DataSource = fBusCli.DtCli2
			Catch
			End Try
		End If
		fBusCli.IdCon_Out_Ant = fBusCli.IdCon_Out

		fBusCli.LinkLabel2.Visible = Not Soy_0150
		fBusCli.LnkModif.Visible = Not Soy_0150

		fBusCli.Numero_Empresa = Numero_Empresa
		fBusCli.Sector_Empresa = Sector_Empresa
		fBusCli.IdCon_Out = IdContacto
		fBusCli.Destino = Destino
		fBusCli.AceptaAnulados = AceptaAnulados

		IdCli = 0
		RazonSocial = ""
		IdContacto = 0
		Nombre = ""

		Try
			fBusCli.ShowDialog()

		Catch ex As Exception 'si sale error cerrarlo y abrirlo
			Mensaje("Pantalla de Búsqueda ya está abierta")
			Exit Sub

		End Try


		IdCli = fBusCli.IdCli_Out
		RazonSocial = fBusCli.Razon_Out
		IdContacto = fBusCli.IdCon_Out
		Nombre = fBusCli.Nombre_Out
		IdZona = fBusCli.Zona_Out
		IdZonaSub = fBusCli.Zona_Sub_Out
		IdActividad = fBusCli.Actividad_Out
		IdPerfil = fBusCli.Perfil_Out
		IdTipoTributario = fBusCli.Tipo_Tributario_Out
		Nit = fBusCli.Nit_Out

	End Sub

	Public Function PermisosBodega(ByVal CbBod As ComboBox) As String
		If CbBod.SelectedIndex < 0 Then
			Return "Seleccione una Bodega"
		End If

		Dim IDID As Integer
		If CbBod.DataSource IsNot Nothing Then 'esto por si viene de un cobo de dms
			IDID = ValD(CbBod.SelectedValue)
		Else
			IDID = TraerId(CbBod)
		End If

		'VER SI LA BODEGA ESTÁ ACTIVA
		If ValD(Obtenga_Dato(DtBodegas, "id=" & IDID.ToString, "anulada")) <> 0 Then
			Return "La Bodega que pretende usar NO ESTÁ ACTIVA"
		End If


		'jdms 669: nuevo permiso 20 del menu id=622
		If NoPuede4("10199", 20, MostrarMensaje:=False) Then
			'ver si el usuario puede hacer doctos en esta bodega
			If ValD(Obtenga_Dato(DtBodegasPerm, "id_cot_bodega=" & IDID.ToString, "id_cot_bodega")) = 0 Then
				Return "Este usuario no tiene autorización para trabajar con la bodega " & CbBod.Text
			End If
		End If

		Return ""

	End Function


	Public Sub Chatear(ByVal ConQuien As Integer, Optional TextoCargar As String = "")


		If ConQuien = Usuario Then
			Mensaje("Es usted mismo")
			Exit Sub
		End If

		Try
			Ejecute_Proceso(Path_Prog & "SMDMenu.exe", """" & ConQuien.ToString & IIf(TextoCargar <> "", "°" & TextoCargar.Replace("""", "'"), "") & """")
			'Dim Pro1 As New Process
			'Pro1.StartInfo.Arguments = """" & ConQuien.ToString & IIf(TextoCargar <> "", "°" & TextoCargar.Replace("""", "'"), "") & """"
			'Pro1.StartInfo.FileName = Path_Prog & "SMDMenu.exe"

			'Pro1.StartInfo.ErrorDialog = True
			'Pro1.Start()

		Catch ex As Exception
			Mensaje(ex.Message)

		End Try

	End Sub

	Public Sub AdicioneSql(ByVal TextoSql As String)
		If SQL <> "" Then SQL += " And "
		SQL += TextoSql

	End Sub
	Public Sub HS(ByVal Texto As String)
		SQL += Texto

	End Sub
	Public Sub Cargar_Categorias()
		Try
			If DtCategorias.Rows.Count = 0 Then
				Abrir(DtCategorias, "GetCotItemCategoria " & Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Categorias", ex.Message, True)

		End Try
	End Sub
	Public Sub Cargar_Tipo_Ret_item()
		Try
			If DtTipoRetItem Is Nothing Then
				Abrir(DtTipoRetItem, "GetCotItemRet")
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Tipo_Ret_item", ex.Message, True)

		End Try
	End Sub
	Public Sub Cargar_Listas()
		Try
			If DtListas.Rows.Count = 0 Then
				Abrir(DtListas, "Exec GetCotItemListas " & Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Listas", ex.Message, True)

		End Try
	End Sub

	Public Sub Cargar_Tallas()
		Try
			If DtTalla.Rows.Count = 0 Then
				Dim Ds As New DataSet
				Abrir(Ds, "GetCotTallas " & Numero_Empresa.ToString)
				DtTalla = Ds.Tables(0).Copy
				DtColor = Ds.Tables(1).Copy
			End If

		Catch ex As Exception
			MostrarError("Globales", "Cargar_Tallas", ex.Message)

		End Try

	End Sub

	Public Sub Cargar_Tipos()
		Try
			If DtTipo.Rows.Count = 0 Then
				Abrir(DtTipo, "Exec GetCotTipos " & Numero_Empresa & "," & Usuario)
				'Abrir(DtTipo, "Exec " & GetCotTipos & " " & Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("Globales", "Cargar_Tipos", ex.Message)

		End Try
	End Sub
	Public Sub Cargar_Items(Optional ByVal Refrescar As Boolean = False)

		Dim Re As String = ValD(ReglaDeNegocio(122, "realtime", "0"))
		If ValD(Re) < 0 Or ValD(Re) > 2 Then
			RealTime = 0
		Else
			RealTime = ValD(Re)
		End If

		DebugJD("Cargar_Items")


		If Refrescar Then '99=refrescar siempre
			DMS_XML_Delete_DataSet("items")
			DtItem.Rows.Clear()
		End If

		If DtItem.Rows.Count > 0 Then Exit Sub
		If RealTime > 0 And Not Refrescar And DtItem.Columns.Count > 0 Then Exit Sub

		'por el momento ponemos en desconectado que siempre refresque items
		If EstoyDesconectadoNuevo Then
			DMS_XML_Delete_DataSet("items")
			DtItem.Rows.Clear()
		End If

		'hacer esto en esta posición
		Dim RegIt As String = ValD(ReglaDeNegocio(122, "refrescar", "0"))
		If (ValD(RegIt) <= 0 Or ValD(RegIt) > 30) And ValD(RegIt) <> 99 Then
			RegIt = "7" 'default
		End If


		If RegIt = "99" And RealTime = 0 Then
			If SoyServicio Then
				Dim Fec As DateTime = DMS_XML_Fecha_Creacion("items")
				If Fec <> CDate("2001/12/31 12:00") Then 'es porque si existe el archivo
					Dim dias As String = DateDiff(DateInterval.Day, Now, Fec)
					If Not Pregunte("Usuario Servicio: Según la RN#122 debe volver a cargar los ítems, desea hacerlo?" & DMScr(2) & "Fecha de ítems virtualizados: " & FormatoFecha(Fec, True, True) & " (" & dias & " días)") Then
						GoTo Siga_Sin
					End If
				End If
			End If

			DMS_XML_Delete_DataSet("items")
			DtItem.Rows.Clear()
		End If

Siga_Sin:
		Dim DsItem As New DataSet

		HistoriaCargueItems = ""

		DatoDevolver = "JD"

		'Try

		'    'fBusIt.Haga_Leer_Items_New(True)
		'    If DMS_XML_Leer_DataSet(DsItem, "items") Then
		'        If RealTime Then 'arrancar la tabla en limpio por ser realtiem
		'            fBusIt.Mover_Tablas_Items(DsItem)
		'            fBusIt.BckLeerItems.RunWorkerAsync(Refrescar)
		'            If Not Fin(DtItem) Then
		'                'truco para que quede con una fila
		'                Dim dtt As DataTable = DtItem.Copy
		'                dtt.Rows.Clear()
		'                dtt.ImportRow(DtItem.Rows(0))
		'                DtItem.Rows.Clear()
		'                DtItem.ImportRow(dtt.Rows(0))
		'            End If
		'        Else
		'            fBusIt.Mover_Tablas_Items(DsItem)
		'            HistoriaCargueItems += "Cargue XML"
		'            'truco para volver a leer el XML cada 7 días pero en Back
		'            Dim FecUltXML As String = GetSett("GlobalesVarios", "xmlitem" & Numero_Empresa, "1950/12/31")
		'            If IsDate(FecUltXML) Then
		'                If DateDiff(DateInterval.Day, CDate(FecUltXML), Now) > ValD(RegIt) And ValD(RegIt) <> 99 Then 'mas de una semana
		'                    'ahora, con calma leer los items para actualizar XML y los datatables
		'                    If SoyServicio Then
		'                        If Pregunte("Servicio: Lleva " & RegIt & " sin recargar los items. Desea volver a cargarlos?") Then
		'                            GoTo Siga_Sin_2
		'                        End If
		'                    End If
		'                    fBusIt.BckLeerItems.RunWorkerAsync(Refrescar)
		'                End If
		'            End If
		'        End If
		'    Else
		'        'como dió error, leer los items pero de frente
		'        HistoriaCargueItems += "Arranca XML" & DMScr()
		'        fBusIt.Haga_Leer_Items_New(True, Refrescar)
		'    End If

		'Catch ex As Exception
		'End Try

		Try

			'fBusIt.Haga_Leer_Items_New(True)
			Dim Leer As Boolean = False
			If RealTime > 0 Then
				Leer = True
			Else
				If DMS_XML_Leer_DataSet(DsItem, "items") Then
					fBusIt.Mover_Tablas_Items(DsItem)
					HistoriaCargueItems += "Cargue XML"
					'truco para volver a leer el XML cada 7 días pero en Back
					Dim FecUltXML As String = GetSett("GlobalesVarios", "xmlitem" & Numero_Empresa, "1950/12/31")
					If IsDate(FecUltXML) Then
						If DateDiff(DateInterval.Day, CDate(FecUltXML), Now) > ValD(RegIt) And ValD(RegIt) <> 99 Then 'mas de una semana
							'ahora, con calma leer los items para actualizar XML y los datatables
							If SoyServicio Then
								If Pregunte("Servicio: Lleva " & RegIt & " sin recargar los items. Desea volver a cargarlos?") Then
									GoTo Siga_Sin_2
								End If
							End If
							fBusIt.BckLeerItems.RunWorkerAsync(Refrescar)
						End If
					End If
				Else
					Leer = True
				End If
			End If

			'como dió error, leer los items pero de frente
			If Leer Then
				HistoriaCargueItems += "Arranca XML" & DMScr()
				fBusIt.Haga_Leer_Items_New(True, Refrescar)
			End If

		Catch ex As Exception
		End Try



Siga_Sin_2:
		DatoDevolver = ""

		'If RealTime And Not Refrescar Then
		'    If Not Fin(DtItem) Then
		'        'truco para que quede con una fila
		'        Dim dtt As DataTable = DtItem.Copy
		'        dtt.Rows.Clear()
		'        dtt.ImportRow(DtItem.Rows(0))
		'        DtItem.Rows.Clear()
		'        DtItem.ImportRow(dtt.Rows(0))
		'    End If
		'End If


	End Sub
	Public Sub Cargar_Lotes()

		If DtItemLotes.Rows.Count = 0 Then
			Abrir(DtItemLotes, "Exec GetCotItemLotesTodos " & Numero_Empresa.ToString)
		End If
	End Sub

	Public Sub Cargar_Cuentas()

		If DtCta.Rows.Count = 0 Then
			Dim HayReloj As Short = SiRelojCond()

			Dim Ds As New DataSet
			Abrir(Ds, "Exec GetConCuentas " & Numero_Empresa.ToString & DMScr() &
					  "Exec GetConCuentasVentana " & Numero_Empresa.ToString & ",''" & DMScr() &
					  "Exec GetConCtaGruSub " & Numero_Empresa)

			DtCta = Ds.Tables(0).Copy
			DtCtaTit = Ds.Tables(1).Copy
			DtCtaAfe = Ds.Tables(2).Copy
			DtCotGruposConta = Ds.Tables(3)

			SiRelojCond(HayReloj)

		End If

	End Sub
	Public Sub Cargar_Forma_Pago()
		DebugJD("Cargar_Forma_Pago")
		Try
			If DtFormaPago.Rows.Count = 0 Then
				Abrir(DtFormaPago, "Exec GetCotFormaPago " & Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Forma_Pago", ex.Message, True)

		End Try
	End Sub
	Public Function ObtengaNumeroObjeto(ByVal Objeto As Object) As Integer
		If IsNumeric(Mid(Objeto.name, Len(Objeto.name) - 1, 2)) Then
			Return Mid(Objeto.name, Len(Objeto.name) - 1, 2)
		Else
			Return Mid(Objeto.name, Len(Objeto.name), 1)
		End If

	End Function
	Public Sub Cargar_Cotizacion_Estado()
		DebugJD("Cargar_Cotizacion_Estado")

		Try
			If DtCotizacionEstado.Rows.Count = 0 Then
				Abrir(DtCotizacionEstado, "GetCotCotizacionEstado " & Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Cotizacion_Estado", ex.Message, True)

		End Try
	End Sub
	Public Function ValidarLic() As Boolean
		ValidarLic = False
		If ValD(GetSett("ctrl", "files", 0)) = 0 Then
			Mensaje("Su Empresa no tiene activado el sistema para envío de archivos a través de Advance")
			Exit Function
		End If
		If ValD(GetSett("ctrl", "per", 0)) = 0 Then
			Mensaje("Para utilizar esta opción debe tener asignado el permiso #4 del programa de Mensajería. Solicite a su administrador de Advance dicho permiso.")
			Exit Function
		End If
		'If Grid.Rows.Count = 0 Then
		'    Mensaje("No hay datos para exportar a excel") : Exit Function
		'End If

		Cargar_Usuarios()

		ValidarLic = True
	End Function
	Public Sub Cargar_Usuarios()
		Try
			If DtUsu.Rows.Count > 0 Then Exit Sub

			'If DtUsuUsu.Rows.Count = 0 Then
			'	Dim Dsu As New DataSet
			'	If DMS_XML_Leer_DataSet(Dsu, "usuario_usu") Then
			'		DtUsuUsu = Dsu.Tables(0).Copy
			'	End If
			'End If

			'Dim Ds As New DataSet
			'If DMS_XML_Leer_DataSet(Ds, "usuario") Then
			'	DtUsu = Ds.Tables(0).Copy
			'Else
			Abrir(DtUsu, "GetListaUsuariosTotal6 " &
				  Numero_Empresa.ToString & "," &
				  Sector_Empresa.ToString & "," &
				  Usuario.ToString & ",0,0,0,0" & "," &
				  "0," &
				  "0," &
				  LenguajeAdvance
				  )
			'no hacerlo pues solo pasa en servicio dms
			'Ds.Tables.Add(DtUsu)
			'DMS_XML_Escribir_DataSet(Ds, "usuario")
			'End If

			'If Fin(DtUsu) Then
			'	Mensaje("Debe reiniciar el advance para refrescar los usuarios")
			'	Exit Sub
			'End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Usuarios", ex.Message)

		End Try

	End Sub
	Public Sub Cargar_Act_Tipos()
		Try
			If DtActTipos.Rows.Count = 0 Then
				Abrir(DtActTipos, "GetCotActTipos " & Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Act_Tipos", ex.Message, True)

		End Try
	End Sub
	Public Sub Cargar_Eventos_Tipos()
		Try
			If DtEventosTipos.Rows.Count = 0 Then
				Abrir(DtEventosTipos, GetCotEventosTipos, Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Eventos_Tipos", ex.Message, True)

		End Try
	End Sub
	Public Sub Cargar_Zonas()
		'no poner try aqui

		If DtZona.Rows.Count = 0 Then
			Abrir(DtZona, "GetCotZonas", Numero_Empresa.ToString)
		End If

	End Sub
	Public Function SoyEmpresaHija() As Boolean
		If EmpresaMadre <> Numero_Empresa And EmpresaMadre <> 0 Then
			Mensaje("Está opción solo puede ser usada desde la empresa principal: " & EmpresaMadre.ToString)
			Return True
		End If
		Return False

	End Function
	Public Sub Cargar_ContCargos()


		Try
			If DtContCargos.Rows.Count = 0 Then
				Abrir(DtContCargos, "GetCotCargos", Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_ContCargos", ex.Message, True)

		End Try
	End Sub
	Public Sub Cargar_Vendedores()
		Try
			If DtVend.Rows.Count = 0 Then
				Abrir(DtVend, "GetCotVendedores2", Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Vendedores", ex.Message, True)

		End Try
	End Sub
	Public Sub Cargar_estados()
		Try
			If DtEstados.Rows.Count = 0 Then
				Abrir(DtEstados, "GetCotEstados", Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_estados", ex.Message, True)

		End Try
	End Sub
	Public Sub Cargar_Formatos_Impresion()
		Try
			If FormatoImp.Rows.Count = 0 Then
				SiReloj()
				Dim Ds As New DataSet
				Abrir(Ds, "Exec GetCotCotizacionFormatos2 " & Numero_Empresa.ToString)
				FormatoImp = Ds.Tables(0).Copy
				FormatoImpSw = Ds.Tables(1).Copy
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Formatos_Impresion", ex.Message, True)

		End Try
		NoReloj()

	End Sub
	Public Sub Cargar_Actividades()
		Try
			If DtActividades.Rows.Count = 0 Then
				Abrir(DtActividades, "GetCotActividades", Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Actividades", ex.Message, True)

		End Try
	End Sub
	Public Sub Cargar_Origenes()
		Try
			If DtOrigenes.Rows.Count = 0 Then
				Abrir(DtOrigenes, "GetCotOrigenes", Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("Globales", "Cargar_Origenes", ex.Message)

		End Try
	End Sub
	Public Sub Cargar_ContProfesiones()
		Try
			If DtContProfesiones.Rows.Count = 0 Then
				Abrir(DtContProfesiones, "GetCotProfesiones", Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_ContProfesiones", ex.Message)

		End Try
	End Sub
	'Public Sub Cargar_Conceptos_Ingresos()
	'    Try
	'        If DtReciboConcepto.Rows.Count = 0 Then
	'            Abrir(DtReciboConcepto, "GetCotReciboConcepto " & Numero_Empresa.ToString)
	'        End If

	'    Catch ex As Exception
	'        MostrarError("GlobalesVarios", "Cargar_Conceptos_Ingresos", ex.Message & EsIngles)

	'    End Try
	'End Sub
	'Public Sub MostrarError(ByVal Ex As Exception, Optional ByVal MostrarEnPantalla As Boolean = True)
	'    MostrarErrorGrabando(String_Version(), Usuario, "CRM: " & Ex.StackTrace.ToString)

	'    If MostrarEnPantalla Then
	'        Mensaje("Operación no fue completada con éxito. Intente nuevamente")
	'    End If


	'End Sub
	'Public Sub MostrarErrorNuevo(ByVal ex) 'MostrarError(ByVal NombreForma As String, ByVal NombreParrafo As String, ByVal TextoError As String, Optional ByVal MostrarEnPantalla As Boolean = True)
	'    MostrarErrorGrabando(String_Version(), Usuario, My.Application.Info.Title & " (" & NombreForma & ")", NombreParrafo, TextoError)

	'    If MostrarEnPantalla Then
	'        Mensaje("Operación no fue completada con éxito. Intente nuevamente" & DMScr(2) & TextoError)
	'    End If


	'End Sub
	Public Function VersionEntera(ByVal Version As String)
		Try
			Dim ss() = Split(Version, ".")
			Dim Reto As String = ""
			Reto += Strings.Format(ValD(ss(0)), "00")
			Reto += Strings.Format(ValD(ss(1)), "000")
			Reto += Strings.Format(ValD(ss(3)), "0000")
			Return Reto

		Catch ex As Exception
			Return Replace(Version, ".", "")
		End Try

	End Function

	Public Function String_Version() As Integer
		Return ValD(Strings.Format(My.Application.Info.Version.Major, "00") & Strings.Format(My.Application.Info.Version.Minor, "000") & Strings.Format(My.Application.Info.Version.Revision, "0000"))

	End Function
	Public Function String_Version_Editada() As String
		'Return VB6.Format(My.Application.Info.Version.Major, "0") & "." & VB6.Format(My.Application.Info.Version.Minor, "0") & "." & VB6.Format(My.Application.Info.Version.Revision, "0")
		'Application.ExecutablePath
		Dim fil As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
		'Dim fil As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path_Prog & "\SMDMenu.exe")
		'Return Strings.Format(fil.FileMajorPart, "0") & "." & Strings.Format(fil.FileMinorPart, "0") & "." & Strings.Format(fil.FilePrivatePart, "0")
		Return fil.FileMajorPart.ToString & "." & fil.FileMinorPart.ToString & "." & fil.FilePrivatePart.ToString

	End Function
	'Public Function String_Version_Menu() As String
	'    Dim fil As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path_Prog & "\SMDMenu.exe")
	'    'Return Strings.Format(fil.FileMajorPart, "0") & "." & Strings.Format(fil.FileMinorPart, "0") & "." & Strings.Format(fil.FilePrivatePart, "0")
	'    Return fil.FileMajorPart.ToString & "." & fil.FileMinorPart.ToString & "." & fil.FilePrivatePart.ToString
	'    'Return fil.ProductVersion

	'End Function
	Public Function FormatoVersion(ByVal Version As Integer) As String
		'110010075
		Try
			Dim Tex As String = Version.ToString
			Tex = Tex.Substring(0, 2) + "." + ValD(Tex.Substring(2, 3)).ToString + "." + ValD(Tex.Substring(5, 4)).ToString
			Return Tex
		Catch ex As Exception
			Return Version.ToString
		End Try

	End Function
	Public Sub Buscar_Foto_Item(ByVal IdItem As Integer, ByVal PicItem As PictureBox)


		Try
			PicItem.ImageLocation = ""

			Dim Foto As String
			Foto = Path_Temp & "i" & IdItem.ToString & ".jpg"
			If System.IO.File.Exists(Foto) Then
				'CmdVerFoto.Visible = False
				PicItem.ImageLocation = Foto
				PicItem.Tag = IdItem
				Exit Sub
			End If

			'CmdVerFoto.Visible = True


		Catch ex As Exception
			Mensaje("Error buscando foto: " & ex.Message & EsIngles())

		End Try

		Reloj(False)

	End Sub
	Public Function SoyAutomotriz(Optional ByVal AceptaTaller As Boolean = False) As Boolean
		If Not Regla_SoyAutomotriz_16() Then
			If AceptaTaller And Regla_SoyTaller_15() Then Return True
			Mensaje("Programa exclusivo del sector automotriz")
			Return False
		Else
			Return True
		End If

	End Function
	Public Sub Cargar_Grupos()
		If DtCotGrupos.Rows.Count = 0 Then
			Abrir(DtCotGrupos, "GetCotGrupos " & Numero_Empresa.ToString)
		End If
		If DtBodegas.Rows.Count = 0 Then
			Cargar_Bodegas()
		End If

	End Sub
	Public Sub Cargar_Grupos_Conta()
		If DtCotGruposConta.Rows.Count = 0 Then
			Abrir(DtCotGruposConta, "GetConCtaGruSub " & Numero_Empresa.ToString)
		End If

	End Sub

	Public Sub Cargar_Ivas()
		If DtCotIva.Rows.Count = 0 Then
			Abrir(DtCotIva, GetCotIvas, Numero_Empresa.ToString)
		End If

	End Sub
	Public Sub Cargar_Veh_Modelos(Optional ByVal Refrescar As Boolean = False)
		If Refrescar Then
			DMS_XML_Delete_DataSet("lineasveh")
			DtVehMarca.Rows.Clear()
		End If

		If DtVehMarca.Rows.Count > 0 Then Exit Sub

		Dim Ds As New DataSet

		Try
			If DMS_XML_Leer_DataSet(Ds, "lineasveh") Then
				fBusIt.Mover_Tablas_Lineas(Ds)
				fBusIt.BckLeerLineasColores.RunWorkerAsync()
			Else
				fBusIt.Haga_Leer_Lineas()
			End If
		Catch ex As Exception
		End Try

	End Sub
	Public Sub Cargar_Colores()
		If DtColores.Rows.Count = 0 Then
			Abrir(DtColores, "GetVehColores " & Numero_Empresa.ToString)
		End If


	End Sub

	Public Sub Historia_Item(ByVal IdItem As Integer, ByVal CodigoItem As String)
		Mensaje("Esta función no hace nada")

		'If IdItem = 0 Then
		'    Mensaje("Seleccione un item")
		'    Exit Sub
		'End If

		'Ventana("Exec GetCotItemHistoria " & IdItem.ToString, "Historia de " & CodigoItem, False)

	End Sub

	Public Function Filtro_Sector(ByVal Codigo As String) As String
		Dim Nue As String
		Nue = UCase(Trim(SinComillas(Codigo)))
		Return Nue

		'realmente esto se usaba era en placas, ya no
		'If Regla_SoyAutomotriz_16() Or Regla_SoyTaller_15() Then
		'    Dim Nue2 As String = ""
		'    For I As Integer = 1 To Len(Nue)
		'        If (Mid(Nue, I, 1) >= "0" And Mid(Nue, I, 1) <= "9") Or (Mid(Nue, I, 1) >= "A" And Mid(Nue, I, 1) <= "Z") Then
		'            Nue2 += Mid(Nue, I, 1)
		'        End If
		'    Next
		'    Return Nue2
		'Else
		'    Return Nue
		'End If

	End Function

	Public Sub Traiga_Foto_Item(ByVal PicFoto As PictureBox, ByVal IdItem As Integer)
		Try
			Dim Foto As String
			Foto = Path_Temp & "i" & IdItem.ToString & ".jpg"

			SiReloj()
			Dim Ima As New DataTable
			Abrir(Ima, GetImagen, IdItem.ToString, "cot_item", "imagen")
			PicFoto.ImageLocation = ""
			If Gdf(Ima, 0, "imagen") IsNot System.DBNull.Value Then
				SalvarFoto(CType(Gdf(Ima, 0, "imagen"), Byte()), Foto, "")
				'Dim Pic1 As New PictureBox
				'Pic1.Image = New System.Drawing.Bitmap(Foto)
				'Pic1.ImageLocation = Foto
				'PicItem.Image = New System.Drawing.Bitmap(Foto)
				'PicFoto.Image = Pic1.Image
				PicFoto.ImageLocation = Foto
				'Pic1.Image = Nothing 'esto se hace para que el archivo de la foto no quede ocupado

			End If

		Catch ex As Exception
			Mensaje("Error buscando foto: " & ex.Message & EsIngles())

		End Try

		NoReloj()

	End Sub
	Public Sub Cargar_Centros()
		Try
			If DtCco.Rows.Count = 0 Then
				Abrir(DtCco, "GetConCco " & Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Centros", ex.Message, True)

		End Try
	End Sub
	Public Sub Cargar_Bodegas()
		Try
			If DtBodegas.Rows.Count = 0 Then
				Abrir(DtBodegas, "GetCotBodegas " & Numero_Empresa.ToString & "," & Usuario.ToString)
			End If

		Catch ex As Exception
			MostrarError("GlobalesVarios", "Cargar_Bodegas", ex.Message, True)

		End Try
	End Sub

	Public Function ArreglarReturnsImprimir(ByVal TextoOrigen As String) As String
		'para pasar a word
		Try
			Dim Tex As String
			'primero quitar el cr+lf
			Tex = Replace(TextoOrigen, Chr(13) + Chr(10), Chr(10))
			'ahora ponerlo
			Tex = Replace(TextoOrigen, Chr(10), "\par" & DMScr())
			Return Tex

		Catch ex As Exception
			Return TextoOrigen

		End Try

	End Function

	Public Function AbrirOpcion() As Boolean
		If Pregunte("Desea Abrir esta opción (Responda N para refrescar datos)?") Then
			Return True
		Else
			Return False
		End If


	End Function
	Public Sub Cargar_Tipos_Perfil()
		If DtTipoPerfil.Rows.Count = 0 Then
			Abrir(DtTipoPerfil, "Exec GetCotTipoPerfil " & Numero_Empresa.ToString)
		End If

	End Sub
	Public Sub Cargar_Clases_y_Servicios()
		If DtClaseVeh.Rows.Count = 0 Or DtServicioVeh.Rows.Count = 0 Then
			Try
				Dim ds As New DataSet
				Abrir(ds, "GetVehClaseServicio " & Numero_Empresa)
				DtClaseVeh = ds.Tables(0)
				DtServicioVeh = ds.Tables(1)

			Catch ex As Exception
				MostrarError("GlobalesVarios", "", ex.Message)
			End Try

		End If

	End Sub
	Public Sub Cargar_Digitalizacion_Preg()
		Try
			If DtDigPreg.Rows.Count = 0 Then
				Abrir(DtDigPreg, "Exec GetDigitalizacionPreg_Todas " & Numero_Empresa.ToString)
				'Abrir(DtTipo, "Exec " & GetCotTipos & " " & Numero_Empresa.ToString)
			End If

		Catch ex As Exception
			MostrarError("Globales", "Cargar_Tipos", ex.Message)

		End Try
	End Sub

	'JFG-569 Esto se trae desde Globales de Compras para ser utilizado en el 1106
	Public Function Excluir_Tipo(IdTipo As Integer, MostrarMensaje As Boolean) As Boolean
		Dim TiposEx As String = "," & ReglaDeNegocio(102, "exclu", "").Replace(" ", "") & ","
		If TiposEx.Contains("," & IdTipo & ",") Then
			If MostrarMensaje Then
				Mensaje("Tipo de documento no requiere presupuesto")
			End If
			Return True
		Else
			Return False
		End If

	End Function
	Public Function Buscar_Presup() As String
		Try
			SiReloj()
			Dim dt As New DataTable
			Abrir(dt, "GetComPresup_ventana " & Numero_Empresa)
			NoReloj()

			If Fin(dt) Then
				Mensaje("No hay datos para mostrar")
				Return ""
			Else
				Dim Pr As String = Ventana(dt, "Presupuesto", True, "codigo")
				Return Pr
			End If
		Catch ex As Exception
			NoReloj()
			MostrarError("Globales", "Buscar_Presup", ex.Message)
			Return ""
		End Try
	End Function
	'/JFG-569 Esto se trae desde Globales de Compras para ser utilizado en el 1106
	'SGQ-680: Destinos
	Public Sub LLenar_Destinos()
		If Not UsaDestinosItem Then
			Exit Sub
		End If

		Try
			Dim Ds As DataSet
			If DtDestinos Is Nothing Then
				GlobalesVarios.SQL = ""
				HS(ArmeSQL("Exec GetConDestinosHojas",
						   Numero_Empresa, qqNum))
				SiReloj()
				Abrir(Ds, GlobalesVarios.SQL)
				NoReloj()
				If Ds.Tables.Count > 0 Then
					DtDestinos = Ds.Tables(0)
					DtDestinosUnico = Ds.Tables(1)
				End If
			End If
		Catch ex As Exception
			NoReloj()
			MostrarError("GlobalesVarios", "Llenar_Destinos", ex.ToString)
		End Try
	End Sub
	'/SGQ-680: Destinos

	''' <summary>
	''' rml: 687 Devuelve la cadena formateada con Try/Catch dentro del SQL
	''' </summary>
	''' <param name="Query"></param>
	''' <returns></returns>
	Public Function Adv_SqlTryCatch(Query As String) As String
		Dim Sq As String = ""

		Sq &= "Begin Try" & DMScr()
		Sq &= "Begin Transaction" & DMScr()

		Sq &= Query & DMScr()

		Sq &= "Commit Transaction" & DMScr()
		Sq &= "End Try" & DMScr()
		Sq &= "Begin Catch" & DMScr()
		Sq &= "        Rollback transaction" & DMScr()
		Sq &= "   Declare @lin varchar(50)" & DMScr()
		Sq &= "   Declare @proc varchar(50)" & DMScr()
		Sq &= "   Declare @Mens varchar(500)" & DMScr()
		Sq &= "   Declare @advance_error varchar(MAX)" & DMScr()
		Sq &= "   Select  @proc=ERROR_PROCEDURE()," & DMScr()
		Sq &= "           @lin=ERROR_LINE()," & DMScr()
		Sq &= "           @Mens=ERROR_MESSAGE()" & DMScr()
		Sq &= "   set @advance_error=@lin+'-'+@proc+'-'+@Mens" & DMScr()
		Sq &= "   RAISERROR ( @advance_error,18,1)" & DMScr()
		Sq &= "End Catch"

		Return Sq

	End Function

End Module