' Version: 695, 4-oct.-2018 12:56
' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 678, 16-ago.-2018 14:15
' Version: 655, 1-jun.-2018 12:53
' Version: 650, 7-may.-2018 12:42
' Version: 638, 20-mar.-2018 12:16
'♥ versión: 586, 6-oct.-2017 07:11
Public Module HacerImprimirDocumentos
    Dim FactorMoneda = 0 'no poner tipo a ver que pasa
    Dim TxtImpresoAnt As String = ""
    Dim TxtImpreso As String = ""
    Dim IdFormato As String = ""
    Dim IdFormatoAnt As Integer = 0
    Dim DsTodo As New DataSet
    Dim DtEnc As New DataTable
    Dim CualId As Integer
    Dim CualSW As Integer
	''' <summary>
	''' Imprime documentos de Advance
	''' </summary>
	''' <param name="DsTotalRegresa">Dataset donde regresa todos los datos cargados para la impresión en 7 tablas</param>
	''' <param name="Forma">Forma llamadora para manejo de reloj</param>
	''' <param name="Emp">Id de la empresa</param>
	''' <param name="QueSW">Sw del documento a imprimir</param>
	''' <param name="IDID">Id del docto</param>
	''' <param name="EnviarMail">Definir si imprime o envía email asi: 0: preguntar, 1: enviar email, 2: imprimir</param>
	''' <param name="MostrarFormato">Muestra la ventana para seleccionar formato así haya uno solo</param>
	''' <param name="CargarDatos">Carga los datos usando el procedure. Con false no carga los datos y toma el DsTotalRegresa como fuente de datos</param>
	''' <param name="RichTextDevolver">Ponga una variable tipo string con la letra S y la rutina devolverá el texto en formato RichText sin producir el archivo</param>
	''' <remarks>By JDMS 29-oct-2010</remarks>
	Public Sub Imprima_Documento(ByRef DsTotalRegresa As DataSet,
								 ByVal Forma As Form,
								 CrystalView As Object,
								 ByVal Emp As Integer,
								 ByVal QueSW As Integer,
								 ByVal IDID As Integer,
								 Optional ByVal EnviarMail As Short = 0,
								 Optional ByVal MostrarFormato As Boolean = False,
								 Optional ByVal CargarDatos As Boolean = True,
								 Optional ByRef RichTextDevolver As String = "",
								 Optional ByVal IdFormatoCliente As Integer = 0,
								 Optional ByVal VerPorPantalla As Boolean = False,
								 Optional ByRef NuevoImprimir As Integer = 0,
								 Optional ByRef RespuQue As Integer = 0,
								 Optional EsCopia As Boolean = False,
								 Optional EsCertificado As Boolean = False,
								 Optional NombreFormato As String = ""
															   ) 'As Integer

		CualId = IDID
		CualSW = QueSW


		'para que crystal use la pantalla actual
		FormaOrigenVentaCrystal = Forma


		If EnviarMail <> 3 And NuevoImprimir = 0 And RichTextDevolver <> "S" Then
			Dim Resp As String = "-1"
			Do Until ValD(Resp) >= 0 And ValD(Resp) <= 3
				'Resp = InputBox2("Escoja opción:" & DMScr(2) & "1 = Imprimir directo" & DMScr() & "2 = Ver por pantalla" & DMScr() & "3 = Enviar por email" & DMScr() & "0 = Ninguna" & DMScr() & "" & DMScr() & "", "Opciones de documento")
				NoReloj()
				Dim Ult As String = GetSett("impr", "ultimpr", "2")
				Resp = InputBoxDMS("Escoja opción de Imprimir", "Seleccione", False, Ult, New Object() {New Object() {"1", Idi("Imprimir directo"), "2", Idi("Ver por pantalla"), "3", Idi("Enviar por email"), "0", Idi("No imprimir")}})
				SaveSett("impr", "ultimpr", Resp)
			Loop
			If ValD(Resp) = 0 Then
				RespuQue = -1
				Exit Sub
				'Return -1
			End If
			NuevoImprimir = ValD(Resp)
		End If


		If NuevoImprimir = 1 Then 'imprimir
			EnviarMail = 2
			VerPorPantalla = False
		ElseIf NuevoImprimir = 2 Then 'ver
			EnviarMail = 2
			VerPorPantalla = True
		ElseIf NuevoImprimir = 3 Then 'email
			EnviarMail = 1
			VerPorPantalla = False
		ElseIf NuevoImprimir = 4 Then 'mail masivo
			EnviarMail = 4 'para que se tome como masivo en la rutina estandar de email
			NuevoImprimir = 3 'se deja de nuevo en 3 para no afectar nada más
			VerPorPantalla = False
		End If

		Try
			If CualId <= 0 Then
				NoReloj()
				Mensaje("Entre ID del documento")
				RespuQue = -1
				Exit Sub
			End If

			If RichTextDevolver <> "S" Then
				SiReloj(Forma)
			End If


			Dim Vali As New DataTable
			If CargarDatos Then
				If IdFormatoCliente <> 0 Then MostrarFormato = True 'para que respete el del cliente especial
				Abrir(DsTodo, ArmeSQL("exec GetFormatosImpresionSW",
										Numero_Empresa, qqNum,
										QueSW, qqNum,
										CualId, qqNum,
										Usuario, qqNum,
										MostrarFormato, qqBol
										)
								)

				Buscar_Taller()
				DsTotalRegresa = DsTodo
			Else
				DsTodo = DsTotalRegresa
			End If

			'jdms 650
			If EsCertificado And EstaEnLista(QueSW, 4, -4, 31, 33) Then
				If DsTodo.Tables(2).Columns.Contains("valor iva") And Not Fin(DsTodo.Tables(2)) Then
					If ValD(DsTodo.Tables(2).Rows(0).Item("valor iva")) <> 0 Then
						DsTodo.Tables(1).Rows.Clear()
						DsTodo.Tables(1).Rows.Add("certif", Now, -1, IIf(QueSW = 4 Or QueSW = -4, "d_compra_certif.rpt", "d_nota_certif"))
					End If
				End If
			End If
			If NombreFormato <> "" Then
				DsTodo.Tables(1).Rows.Clear()
				DsTodo.Tables(1).Rows.Add("segunda_impr", Now, -1, NombreFormato)
			End If
			'/jdms 650


			NoReloj(Forma)

			Vali = DsTodo.Tables(0).Copy
			If Gdn(Vali, "result") <> "" Then
				Mensaje(Gdn(Vali, "result"))
				RespuQue = -2
				Exit Sub
				'Return -2
			End If

			If EnviarMail = 3 Then 'salirse ya
				DsTotalRegresa = DsTodo
				RespuQue = 0
				Exit Sub
				'Return 0
			End If


			If IdFormatoCliente = 0 Then 'si el cliente no tiene formato especial asignado
				If DsTodo.Tables(1).Rows.Count = 0 Then
					Mensaje(Idi("No hay formatos para el sw de este documento") & ": " & CualSW.ToString)
					RespuQue = -2
					Exit Sub
					'Return -2
				ElseIf DsTodo.Tables(1).Rows.Count = 1 And MostrarFormato = False Then 'solo es uno, no preguntar
					IdFormato = DsTodo.Tables(1).Rows(0).Item("id")
				Else
					If RespuQue > 0 Then 'para la opcion del 1104 de imprimir muchos doctos
						IdFormato = RespuQue
					Else
						IdFormato = Ventana(DsTodo.Tables(1), "Seleccione Formato", True, "id") ', New Object() {"id", "result"})
					End If
				End If
			Else
				IdFormato = IdFormatoCliente
			End If

			If IdFormato = "" Then
				RespuQue = -3
				Exit Sub
				'Return -3
			End If


			If ValD(IdFormato) = 7 Then
				Mensaje("Es tirilla")
				RespuQue = ValD(IdFormato)
				Exit Sub
				'Return ValD(IdFormato)
			End If


			Dim FmtCrys As String = "" & Obtenga_Dato(DsTodo.Tables(1), "id=" & IdFormato.ToString, "crystal")

			DebugJD("FmtCrys: " & FmtCrys.ToString)

			If FmtCrys <> "" Then
				'probar lo de la imagen

				SiReloj()


				Try
					DebugJD("Nombres datatables")
					'OJO: Guardar el DataSet para crystal
					DsTodo.Tables(0).TableName = "result"
					DsTodo.Tables(1).TableName = "formatos"
					DsTodo.Tables(2).TableName = "enca"
					DsTodo.Tables(3).TableName = "items"
					DsTodo.Tables(4).TableName = "forma_pago"
					DsTodo.Tables(5).TableName = "cruce"
					DsTodo.Tables(6).TableName = "vehiculo"
					DsTodo.Tables(7).TableName = "emp"
					DsTodo.Tables(8).TableName = "det_consig"

					'cosa loca pa mostrar la consignacion anulada, quitar esto cuando el reporte esté bueno
					If QueSW = 42 And DsTodo.Tables(8).Rows.Count = 0 Then
						Try
							DsTodo.Tables(8).Rows.Add("Anulado", "Anulado", 0, 0, "Anulado", 0, "Anulado", 0, "", 0, 0, 0, 0)
						Catch
						End Try
					End If
					'/cosa loca pa mostrar la consignacion anulada

					'ver si tiene tasa: en cotiza, ped y fact
					If QueSW = 0 Or QueSW = 1 Or QueSW = 41 Then
						If DsTodo.Tables(2).Columns.Contains("tasa") Then
							If Math.Abs(ValD(Gdf(DsTodo.Tables(2), "tasa"))) > 1 Then
								If Not Pregunte("Este documento tiene moneda extranjera:" & DMScr(2) & "Moneda: " & Gdf(DsTodo.Tables(2), "moneda") & DMScr() & "Tasa: " & Math.Abs(ValD(Gdf(DsTodo.Tables(2), "tasa"))) & DMScr(2) & "Desea imprimir los valores en esta moneda?") Then
									DsTodo.Tables(2).Rows(0).Item("tasa") = 1 '*= -1
								End If
							End If
						End If
					End If
					'/ver si tiene tasa


					'de aqui para abajo son opcionales
					If DsTodo.Tables.Count > 9 Then 'se debe sumar la de logo que se hizo antes
						DsTodo.Tables(9).TableName = "imputa"
					End If
				Catch ex As Exception
					DebugJD("asignar tablas error: " & ex.Message & EsIngles())
					NoReloj()
					MostrarError("HacerImprimirDocumentos", "asignar tablas", ex.Message)
					RespuQue = -3
					Exit Sub
				End Try


				If DsTodo.Tables.Contains("logo") = False Then
					Try
						Dim Dtn As DataTable = Traiga_Logo_Crystal()
						If Dtn Is Nothing Then
							NoReloj()
							RespuQue = -3
							'jdms 638
							Exit Sub
						End If


						Dim Dc As New DataColumn()
						Dc.DataType = System.Type.GetType("System.String")
						Dc.ColumnName = "version"
						Dtn.Columns.Add(Dc)

						Dc = New DataColumn
						Dc.DataType = System.Type.GetType("System.String")
						Dc.ColumnName = "es_copia"
						Dtn.Columns.Add(Dc)


						Dim FechaHoraModif As String = Obtenga_Nombre_Reporte(FmtCrys, False, False, True)

						Dtn.Rows(0).Item("version") = "(" & LCase(MiCodigo) & "," & LCase(MiEmpresa) & "," & String_Version_Editada() & "," & MarcaExterna & ") (Rep. " & Replace(FmtCrys, ".rpt", "") & " " & FechaHoraModif & ")"
						Dtn.Rows(0).Item("es_copia") = IIf(EsCopia, "S", "")
						Dtn.TableName = "logo"

						DsTodo.Tables.Add(Dtn.Copy)
					Catch ex As Exception
						DebugJD("Logo error: " & ex.Message & EsIngles())
						NoReloj()
						MostrarError("HacerImprimirDocumentos", "Crystal logo", ex.Message)
						RespuQue = -3
						Exit Sub
						'Return -3
					End Try
				End If


				Try
					'convertir a SWS que son iguales
					Dim NuevoSw As String = ""
					If EstaEnLista(QueSW, -1, 0, 1, 2) Then
						NuevoSw = "1"
					ElseIf EstaEnLista(QueSW, 11, 12, 13, 14, 16, 17) Then
						NuevoSw = "12"
					ElseIf EstaEnLista(QueSW, 21, 23, 31, 33) Then
						NuevoSw = "21"
					ElseIf EstaEnLista(QueSW, -4, 4) Then
						NuevoSw = "4"
					ElseIf QueSW = 47 Then
						NuevoSw = "46"
					ElseIf EstaEnLista(QueSW, 50, -50) Then
						NuevoSw = 99
					Else
						NuevoSw = VABS(QueSW).ToString
					End If

					DebugJD("xml")
					DsTodo.WriteXml("c:\smd_files\d" & NuevoSw & ".xml", XmlWriteMode.WriteSchema)
					'DsTodo.WriteXmlSchema("c:\smd_files\d" & NuevoSw & ".xsd")

					DebugJD("llamar crys")
					'Ejecute_Proceso(Path_Prog & "SMDCrystal.exe", """" & "d" & FmtCrys & """ """ & CualId.ToString & """ """ & DsTodo.Tables(2).Rows(0).Item("Tipo Doc").ToString & " " & DsTodo.Tables(2).Rows(0).Item("Numero").ToString & " (" & CualId.ToString & ")""" & " " & """" & NuevoImprimir & """")
					'Ejecute_Proceso(Path_Prog & "SMDCrystal.exe", """" & "d" & FmtCrys & """ """ & CualId.ToString & """ """ & DsTodo.Tables(2).Rows(0).Item("Tipo Doc").ToString & " " & DsTodo.Tables(2).Rows(0).Item("Numero").ToString & " (" & CualId.ToString & ")""" & " " & """" & NuevoImprimir & """")
					Haga_Reporte(DsTodo.Tables(2).Rows(0).Item("Tipo Doc").ToString & " " & DsTodo.Tables(2).Rows(0).Item("Numero").ToString & " (" & CualId.ToString & ")",
								IIf(EnviarMail = 4, 4, NuevoImprimir),
								FmtCrys, CrystalView, DsTodo.Tables(2))
					NoReloj()
					If RespuQue = -10 Then 'para asignarlo para impresion masiva del 1104
						RespuQue = IdFormato
					Else
						RespuQue = 0
					End If
					Exit Sub
					'Return 0
				Catch ex As Exception
					NoReloj()
					MostrarError("HacerImprimirDocumentos", "Crystal llamado", ex.Message)
					RespuQue = -3
					Exit Sub
					'Return -3
				End Try
			End If


		Catch ex As Exception
			NoReloj(Forma)
			Mensaje_TopMost("No pudo definir el tipo del docto: " & ex.Message & EsIngles(), , , True)
			RespuQue = -1
			Exit Sub
			'Return -1
		End Try

		'leer el formato seleccionado
		If ValD(IdFormato) <> IdFormatoAnt Then
			Try
				Dim Fmt As New DataTable
				SiReloj(Forma)
				Abrir(Fmt, "GetCotCotizacionFormatosUno " & IdFormato)
				NoReloj(Forma)
				If Fin(Fmt) Then
					Mensaje("No encontré formato")
					RespuQue = -5
					Exit Sub
					'Return -5
				End If
				TxtImpresoAnt = "" & Gdn(Fmt, 0, "formato")
				IdFormatoAnt = ValD(IdFormato)

			Catch ex As Exception
				NoReloj(Forma)
				Mensaje_TopMost("No pudo traer formato de impresión: " & ex.Message & EsIngles(), , , True)
				RespuQue = -1
				Exit Sub
				'Return -1
			End Try
		End If



		If RichTextDevolver <> "S" Then
			SiReloj(Forma)
		End If

		TxtImpreso = TxtImpresoAnt

		Imprimir_Archivo()

		If RichTextDevolver = "S" Then 'devolver solo este string
			RichTextDevolver = TxtImpreso
		Else
			Terminar_Proceso(Forma, EnviarMail, VerPorPantalla)
		End If

		NoReloj(Forma)

		RespuQue = 0

		Exit Sub
		'Return 0
	End Sub
	Private Sub Buscar_Taller()
		If DsTodo.Tables.Count < 13 Then Exit Sub

		If DsTodo.Tables(13).Rows.Count <= 1 Then Exit Sub '2 o mas: hay mas de una salida dentro de la orden de taller

		Dim CuCu As String = Ventana(DsTodo.Tables(13), "DOCUMENTO DE TALLER: Escoja cual usar, presione ESC para TODO", True, "id")
		If ValD(CuCu) = 0 Then Exit Sub

		Dim DtUna As New DataTable 'aquí vienes los ID que debe quedar nada más
		Abrir(DtUna, "Select id=id_cot_cotizacion_item from tal_salidas_det where id_tal_salidas_enc=" & ValD(CuCu))
		For Each Fi As DataRow In DsTodo.Tables(3).Rows 'barrer los items
			If Obtenga_Dato(DtUna, "id=" & Fi("id_cot_cotizacion_item"), "id") Is DBNull.Value Then 'si no lo encuentro en la tabla a imprimir lo marco para quitar
				Fi.Delete()
			End If
		Next
		DsTodo.Tables(3).AcceptChanges()

		Dim Dt As New DataTable
		Dt = Filtrar_DataTable(DsTodo.Tables(13), "id=" & ValD(CuCu))

		DsTodo.Tables(13).Rows.Clear()
		DsTodo.Tables(13).Rows.Add()
		For I As Integer = 0 To Dt.Columns.Count - 1
			DsTodo.Tables(13).Rows(0).Item(I) = Dt.Rows(0).Item(I)
		Next



	End Sub
	Private Sub Imprimir_Archivo()
		'*********************************************************************************************************
		'comienzo de impresión
		'*********************************************************************************************************
		Try

			DtEnc = DsTodo.Tables(2).Copy

			Definir_Moneda()

			Inserte_Items()

			Inserte_Vehiculo_Encabezado()

			Inserte_Cheques()

			'Inserte_Consignacion()

			Inserte_Cruces()

			Inserte_Cartera()

			Inserte_Puntos()

			Inserte_Discriminacion_Iva()

			Inserte_Interes_Mora()

			Inserte_Imputacion()

			Inserte_Encabezado()



		Catch ex As Exception
			Mensaje("" & ex.Message & EsIngles())

		End Try

	End Sub
	Private Function Haga_Filtrar(ByVal Nuevo As String) As String
		Nuevo = Replace(Nuevo, "\", "\\")
		Nuevo = Replace(Nuevo, "}", "\}")
		Nuevo = Replace(Nuevo, "°", "\'b0")
		Nuevo = Replace(Nuevo, "¬", "\'ac")
		Return Nuevo

	End Function
	Private Sub Cambie(ByVal TextoOriginal As String, ByVal NuevoTexto As Object, Optional ByVal Filtrar As Boolean = True, Optional ByVal HacerReturns As Boolean = False)
		Dim Nuevo As String = ("" & NuevoTexto).ToString

		If Filtrar Then
			Nuevo = Haga_Filtrar(Nuevo)
		End If

		If HacerReturns Then
			Nuevo = ArreglarReturnsImprimir(Nuevo)
		End If

		TxtImpreso = Replace(TxtImpreso, TextoOriginal, Nuevo)


	End Sub
	Private Sub Cambie_Ret(ByVal Ret As Double, ByVal Cual As Integer)
		If Ret <> 0 Then
			Cambie("@TitR" & Cual.ToString & "@", ReglaDeNegocio(3, "ret" & Cual.ToString, "Ret" & Cual.ToString))
		Else
			Cambie("@TitR" & Cual.ToString & "@", "")
		End If

	End Sub
	Private Function ReplaceJD(ByVal Origen, ByVal Buscar, ByVal Cambiar) As String
		Dim Nuevo As String = Cambiar
		Nuevo = Haga_Filtrar(Nuevo)

		Return Replace(Origen, Buscar, Nuevo)

	End Function
	Private Sub Inserte_Items()
		Try

			'identificar comienzo de items
			'--------------- ITEMS ------------------------------------------
			Dim IniIte As Integer = InStr(1, TxtImpreso, "~")
			Dim FinIte As Integer = InStr(IniIte + 1, TxtImpreso, "~")
			Dim TexIte As String = ""
			Dim RenglonItem As String = ""
			If IniIte = 0 Or FinIte = 0 Then Exit Sub

			Dim DtI As New DataTable
			DtI = DsTodo.Tables(3).Copy

			TexIte = Mid(TxtImpreso, IniIte + 1, FinIte - IniIte - 1)
			Mid(TxtImpreso, IniIte, 1) = " "
			Mid(TxtImpreso, FinIte, 1) = " "
			Dim NueIte As String

			Dim TotCajas As Integer = 0
			Dim TotSueltas As Integer = 0

			For i As Integer = 0 To DtI.Rows.Count - 1
				NueIte = TexIte
				NueIte = ReplaceJD(NueIte, "@BodIte@", Gdn(DtI, i, "bodega"))
				NueIte = ReplaceJD(NueIte, "@Cod@", Gdn(DtI, i, "codigo"))
				NueIte = ReplaceJD(NueIte, "@Grupo@", Gdn(DtI, i, "grupo"))
				NueIte = ReplaceJD(NueIte, "@Subgrupo@", Gdn(DtI, i, "subgrupo"))
				NueIte = ReplaceJD(NueIte, "@Placa@", Gdn(DtI, i, "codigo"))
				If Gdn(DtI, i, "descripcion") = "." Then
					NueIte = ReplaceJD(NueIte, "@Des@", "")
				Else
					NueIte = ReplaceJD(NueIte, "@Des@", Gdn(DtI, i, "descripcion"))
				End If
				NueIte = ReplaceJD(NueIte, "@Lote@", "" & Gdn(DtI, i, "lote"))
				NueIte = ReplaceJD(NueIte, "@Nlote@", "" & Gdn(DtI, i, "nlote"))

				If Gdn(DtI, i, "vlote") Is System.DBNull.Value Then
					NueIte = ReplaceJD(NueIte, "@Vlote@", "")
				Else
					NueIte = ReplaceJD(NueIte, "@Vlote@", FormatoFecha(Gdn(DtI, i, "vlote")))
				End If
				NueIte = ReplaceJD(NueIte, "@Not@", "" & Gdn(DtI, i, "notas"))
				NueIte = ReplaceJD(NueIte, "@Can@", ValD(Gdn(DtI, i, "cantidad")))

				NueIte = ReplaceJD(NueIte, "@Und@", "" & Gdn(DtI, i, "und")) 'nombre unidad de medida para embalaje
				Dim Can_Und As Double = ValD(Gdn(DtI, i, "und_cant"))
				If Can_Und = 0 Then Can_Und = 1
				NueIte = ReplaceJD(NueIte, "@Uc@", Can_Und) 'cantidad en la U/M
				Dim Cajas As Integer = Int(ValD(Gdn(DtI, i, "cantidad")) / Can_Und)
				TotCajas += Cajas
				NueIte = ReplaceJD(NueIte, "@Cj@", Cajas) 'equivale a cuántas cajas
				Dim Sueltas As Integer = ValD(Gdn(DtI, i, "cantidad")) - (Cajas * Can_Und)
				TotSueltas += Sueltas
				NueIte = ReplaceJD(NueIte, "@Su@", Sueltas) 'unidades sueltas

				NueIte = ReplaceJD(NueIte, "@CanPed@", ValD(Gdn(DtI, i, "pedida")))
				NueIte = ReplaceJD(NueIte, "@CanDes@", ValD(Gdn(DtI, i, "despachada")))
				'aqui falta un dato que es la cantidad pendiente, pero se debe modificar el procedure pues debo es traer la cantidad acumulada despachada
				NueIte = ReplaceJD(NueIte, "@Serial@", "" & Gdn(DtI, i, "serial"))
				NueIte = ReplaceJD(NueIte, "@Ope@", "" & Gdn(DtI, i, "operario"))
				NueIte = ReplaceJD(NueIte, "@ManSto@", "" & Gdn(DtI, i, "maneja stock"))
				'si el precio de lista es menor que el precio real, significa que se entró un precio mayor, por tanto hacer truco para que no se vea un descuento negativo
				If Gdn(DtI, i, "precio lista") < Gdn(DtI, i, "precio cotizado") Or ValD(Gdn(DtI, i, "% dcto")) > 100 Then
					NueIte = ReplaceJD(NueIte, "@Pre@", FormatoMoneda(VALD2(Gdn(DtI, i, "precio cotizado")), True, True))
					NueIte = ReplaceJD(NueIte, "@Dct@", "")
				Else
					NueIte = ReplaceJD(NueIte, "@Pre@", FormatoMoneda(VALD2(Gdn(DtI, i, "precio lista"))))
					If ValD(Gdn(DtI, i, "% dcto")) = 0 Then
						NueIte = ReplaceJD(NueIte, "@Dct@", "")
					Else
						NueIte = ReplaceJD(NueIte, "@Dct@", ValD(Gdn(DtI, i, "% dcto")))
					End If
				End If
				NueIte = ReplaceJD(NueIte, "@CosUnd@", ValD(Gdn(DtI, i, "costo und")))
				NueIte = ReplaceJD(NueIte, "@Iva@", ValD(Gdn(DtI, i, "iva")))
				NueIte = ReplaceJD(NueIte, "@Tot@", FormatoMoneda(VALD2(Gdn(DtI, i, "total")), True, True))
				NueIte = ReplaceJD(NueIte, "@PreIva@", FormatoMoneda(VALD2(Gdn(DtI, i, "precio+iva")), True, True))
				NueIte = ReplaceJD(NueIte, "@Tne@", FormatoMoneda(VALD2(Gdn(DtI, i, "total neto")), True, True))
				NueIte = ReplaceJD(NueIte, "@Tnu@", FormatoMoneda(VALD2(Gdn(DtI, i, "total neto und")), True, True)) 'neto unitario
				RenglonItem = RenglonItem & NueIte & DMScr()

				'ver si agrega la estructura al documento, solo en forma informativa
				If ReglaDeNegocio(55, , "0") = "1" Then
					If Strings.Left(Gdn(DtI, i, "maneja stock"), 1) = "3" Then 'es estructura
						If DtItemEstruc.Rows.Count = 0 Then
							Abrir(DtItemEstruc, "GetCotItemsEstruc " & Numero_Empresa.ToString)
						End If
						Dim Dre() As DataRow
						Dre = DtItemEstruc.Select("id_cot_item=" & Gdn(DtI, i, "id").ToString, "codigo")
						For KK As Integer = 0 To Dre.Length - 1
							NueIte = TexIte
							'NueIte = ReplaceJD(NueIte, "@Cod@", Dre(KK).Item("codigo"))
							NueIte = ReplaceJD(NueIte, "@Cod@", "")
							NueIte = ReplaceJD(NueIte, "@Des@", Dre(KK).Item("descripcion"))
							NueIte = ReplaceJD(NueIte, "@Can@", ValD(Dre(KK).Item("cantidad") * Gdn(DtI, i, "cantidad")))
							NueIte = ReplaceJD(NueIte, "@Not@", "")
							NueIte = ReplaceJD(NueIte, "@Pre@", "")
							NueIte = ReplaceJD(NueIte, "@Dct@", "")
							NueIte = ReplaceJD(NueIte, "@Iva@", "")
							NueIte = ReplaceJD(NueIte, "@PreIva@", "")
							NueIte = ReplaceJD(NueIte, "@Tot@", "")
							NueIte = ReplaceJD(NueIte, "@Tne@", "")
							NueIte = ReplaceJD(NueIte, "@Tnu@", "")
							NueIte = ReplaceJD(NueIte, "@ManSto@", "")
							NueIte = ReplaceJD(NueIte, "@Grupo@", "")
							NueIte = ReplaceJD(NueIte, "@Subgrupo@", "")
							NueIte = ReplaceJD(NueIte, "@Lote@", "")
							NueIte = ReplaceJD(NueIte, "@Vlote@", "")
							RenglonItem = RenglonItem & NueIte & DMScr()
						Next
					End If
				End If
			Next
			Cambie(TexIte, RenglonItem, False)

			Cambie("@TotCj@", TotCajas)
			Cambie("@TotSu@", TotSueltas)

		Catch ex As Exception
			Mensaje_TopMost("Advertencia: Error Inserte_Items: " & ex.Message & EsIngles(), , , True)
		End Try

	End Sub
	Private Sub Definir_Moneda()
		FactorMoneda = 0
		If ValD(Gdn(DtEnc, "tasa")) <> 0 And ValD(Gdn(DtEnc, "tasa")) <> 1 Then 'tiene tasa
			If Pregunte("Desea imprimir valores en la moneda " & Gdn(DtEnc, "moneda") & " (responda N para utilizar moneda local)?") Then
				If ValD(Gdn(DtEnc, "tasa")) < 0 Then
					FactorMoneda = 1 / VABS(ValD(Gdn(DtEnc, "tasa")))
				Else
					FactorMoneda = ValD(Gdn(DtEnc, "tasa"))
				End If
			End If
		End If
		If FactorMoneda = 0 Then FactorMoneda = 1

	End Sub
	Private Sub Inserte_Vehiculo_Encabezado()
		'puede ser encabezado o de los items.  El procedure se encarga de traer cualquiera de los dos
		Try
			If DsTodo.Tables(6).Rows.Count = 0 Then
				Cambie("@Mot@", "")
				Cambie("@Cha@", "")
				Cambie("@Col@", "")
				Cambie("@Mar@", "")
				Cambie("@Lin@", "")
				Cambie("@Mod@", "")
				Cambie("@Km@", "")
				Cambie("@Car@", "")
				Cambie("@Ano@", "")
				Cambie("@Confi@", "")
				Cambie("@ClaseVeh@", "")
				Cambie("@Servicio@", "")
			Else
				Dim DtVeh As New DataTable
				DtVeh = DsTodo.Tables(6).Copy
				Cambie("@Mot@", "" & Gdn(DtVeh, "motor"))
				Cambie("@Cha@", "" & Gdn(DtVeh, "chasis"))
				Cambie("@Col@", "" & Gdn(DtVeh, "des_color"))
				Cambie("@Mar@", "" & Gdn(DtVeh, "des_marca"))
				Cambie("@Lin@", "" & Gdn(DtVeh, "des_linea"))
				Cambie("@Mod@", "" & Gdn(DtVeh, "des_modelo"))
				If Gdn(DtEnc, "km") Is System.DBNull.Value Then 'para saber si se imprime el del item encabezado en la orden o el item en los items del docto
					Cambie("@Km@", Gdn(DtVeh, "km"))
				Else
					Cambie("@Km@", Gdn(DtEnc, "km"))
				End If
				Cambie("@Car@", "" & Gdn(DtVeh, "des_item"))
				Cambie("@Ano@", "" & Gdn(DtVeh, "ano"))
				Cambie("@Confi@", Gdn(DtVeh, "notas"), , True)
				Cambie("@ClaseVeh@", Gdn(DtVeh, "clase"))
				Cambie("@Servicio@", Gdn(DtVeh, "servicio"))
			End If

		Catch ex As Exception
			Mensaje_TopMost("Advertencia: Error Inserte_Vehiculo_Encabezado: " & ex.Message & EsIngles(), , , True)
		End Try

	End Sub
	Private Sub Inserte_Cheques()
		Try
			Dim IniPag As Integer = InStr(1, TxtImpreso, "@p@")
			Dim FinPag As Integer = InStr(IniPag + 1, TxtImpreso, "@p@")
			Dim TexPag As String = ""
			Dim RenglonPag As String = ""
			If IniPag = 0 Or FinPag = 0 Then Exit Sub

			Dim Dtp As New DataTable
			Dtp = DsTodo.Tables(4).Copy
			TexPag = Mid(TxtImpreso, IniPag + 3, FinPag - IniPag - 3)
			Mid(TxtImpreso, IniPag, 3) = "   "
			Mid(TxtImpreso, FinPag, 3) = "   "
			Dim NuePag As String
			For i As Integer = 0 To Dtp.Rows.Count - 1
				NuePag = TexPag
				NuePag = ReplaceJD(NuePag, "@PgBanco@", "" & Gdn(Dtp, i, "banco"))
				NuePag = ReplaceJD(NuePag, "@PgForma@", "" & Gdn(Dtp, i, "forma"))
				NuePag = ReplaceJD(NuePag, "@PgValor@", FormatoMoneda(ValD(Gdn(Dtp, i, "valor")), True, True))
				NuePag = ReplaceJD(NuePag, "@PgIva@", FormatoMoneda(ValD(Gdn(Dtp, i, "iva")), True, True))
				NuePag = ReplaceJD(NuePag, "@PgDoc@", "" & Gdn(Dtp, i, "documento"))
				NuePag = ReplaceJD(NuePag, "@PgNotas@", "" & Gdn(Dtp, i, "notas"))
				RenglonPag = RenglonPag & NuePag & DMScr()
			Next
			Cambie(TexPag, RenglonPag, False)

			'por si no había forma de pago, limpiarla
			Cambie("@PgForma@", "")
			Cambie("@PgValor@", "")
			Cambie("@PgIva@", "")
			Cambie("@PgDoc@", "")
			Cambie("@PgNotas@", "")

		Catch ex As Exception
			Mensaje_TopMost("Advertencia: Error Inserte_Cheques: " & ex.Message & EsIngles(), , , True)
		End Try

	End Sub
	'Private Sub Inserte_Consignacion()
	'    Try
	'        Dim IniPag As Integer = InStr(1, TxtImpreso, "@n@")
	'        Dim FinPag As Integer = InStr(IniPag + 1, TxtImpreso, "@n@")
	'        Dim TexPag As String = ""
	'        Dim RenglonPag As String = ""
	'        If IniPag = 0 Or FinPag = 0 Then Exit Sub

	'        Dim Dtp As New DataTable
	'        Dtp = DsTodo.Tables(8).Copy
	'        TexPag = Mid(TxtImpreso, IniPag + 3, FinPag - IniPag - 3)
	'        Mid(TxtImpreso, IniPag, 3) = "   "
	'        Mid(TxtImpreso, FinPag, 3) = "   "
	'        Dim NuePag As String
	'        For i As Integer = 0 To Dtp.Rows.Count - 1
	'            NuePag = TexPag
	'            NuePag = ReplaceJD(NuePag, "@PgBanco@", Gdn(Dtp, i, "banco"))
	'            NuePag = ReplaceJD(NuePag, "@PgForma@", Gdn(Dtp, i, "forma"))
	'            NuePag = ReplaceJD(NuePag, "@PgValor@", FormatoMoneda(Gdn(Dtp, i, "valor"), True, True))
	'            NuePag = ReplaceJD(NuePag, "@PgIva@", FormatoMoneda(Gdn(Dtp, i, "iva"), True, True))
	'            NuePag = ReplaceJD(NuePag, "@PgDoc@", "" & Gdn(Dtp, i, "documento"))
	'            NuePag = ReplaceJD(NuePag, "@PgNotas@", "" & Gdn(Dtp, i, "notas"))
	'            For J As Integer = 1 To 6
	'                NuePag = ReplaceJD(NuePag, "@PgR" & J.ToString & "@", FormatoMoneda(Gdn(Dtp, i, "ret" & J.ToString), True, True))
	'            Next
	'            RenglonPag = RenglonPag & NuePag & DMScr()
	'        Next
	'        Cambie(TexPag, RenglonPag, False)

	'        'por si no había forma de pago, limpiarla
	'        Cambie("@PgBanco@", "")
	'        Cambie("@PgForma@", "")
	'        Cambie("@PgValor@", "")
	'        Cambie("@PgIva@", "")
	'        Cambie("@PgDoc@", "")
	'        Cambie("@PgNotas@", "")
	'        For J As Integer = 1 To 6
	'            Cambie("@PgR" & J.ToString & "@", "")
	'        Next

	'    Catch ex As Exception
	'        Mensaje_TopMost("Advertencia: Error Inserte_Consignacion: " & ex.Message & EsIngles, , , True)
	'    End Try

	'End Sub
	Private Sub Inserte_Cruces()
		Try
			Dim IniPag As Integer = InStr(1, TxtImpreso, "@c@")
			Dim FinPag As Integer = InStr(IniPag + 1, TxtImpreso, "@c@")
			Dim TexPag As String = ""
			Dim RenglonPag As String = ""
			If IniPag = 0 Or FinPag = 0 Then Exit Sub

			TexPag = Mid(TxtImpreso, IniPag + 3, FinPag - IniPag - 3)
			Mid(TxtImpreso, IniPag, 3) = "   "
			Mid(TxtImpreso, FinPag, 3) = "   "
			Dim NuePag As String
			Dim Cru As New DataTable
			Cru = DsTodo.Tables(5).Copy
			For I As Integer = 0 To Cru.Rows.Count - 1
				NuePag = TexPag
				NuePag = ReplaceJD(NuePag, "@FacTip@", Gdn(Cru, I, "tipo"))
				NuePag = ReplaceJD(NuePag, "@FacNum@", Gdn(Cru, I, "numero") & " (" & Gdn(Cru, I, "id") & ")")
				NuePag = ReplaceJD(NuePag, "@FacVal@", FormatoMoneda(Gdn(Cru, I, "total"), True, True))
				NuePag = ReplaceJD(NuePag, "@FacApl@", FormatoMoneda(Gdn(Cru, I, "aplicado"), True, True))
				NuePag = ReplaceJD(NuePag, "@FacDes@", FormatoMoneda(Val("" & Gdn(Cru, I, "descuento")), True, True))
				NuePag = ReplaceJD(NuePag, "@FacRet@", FormatoMoneda(Gdn(Cru, I, "retenciones"), True, True))
				For J As Integer = 1 To 6
					NuePag = ReplaceJD(NuePag, "@FacR" & J.ToString & "@", FormatoMoneda(Gdn(Cru, I, "ret" & J.ToString), True, True))
				Next
				'NuePag = ReplaceJD(NuePag, "@FacSal@", FormatoMoneda(gdn(Cru, I, "saldo"), True))
				RenglonPag = RenglonPag & NuePag & DMScr()
			Next
			Cambie(TexPag, RenglonPag, False)

			'los titulos
			For I = 1 To 6
				Cambie_Ret(1, I)
			Next

			'por si no había cruce, limpiarla
			Cambie("@FacTip@", "")
			Cambie("@FacNum@", "")
			Cambie("@FacVal@", "")
			Cambie("@FacApl@", "")
			Cambie("@FacDes@", "")
			Cambie("@FacRet@", "")
			Cambie("@FacSal@", "")

		Catch ex As Exception
			Mensaje_TopMost("Advertencia: Error Inserte_Cruces: " & ex.Message & EsIngles())
		End Try

		'---------------------------------------------------------



	End Sub
	Private Sub Inserte_Cartera()

		If InStr(TxtImpreso, "@q@") = 0 Then Exit Sub

		Try

			Dim IniCar As Integer = InStr(1, TxtImpreso, "@q@")
			Dim FinCar As Integer = InStr(IniCar + 1, TxtImpreso, "@q@")
			Dim TextoCar As String = ""
			Dim RenglonCar As String = ""
			If IniCar = 0 Or FinCar = 0 Then Exit Sub

			Dim DtCar As New DataTable
			'DtCar = DsTodo.Tables(5).Copy
			Abrir(DtCar, "Exec GetCotCarteraClienteBasica " & Gdn(DtEnc, "cliente_id").ToString)

			TextoCar = Mid(TxtImpreso, IniCar + 3, FinCar - IniCar - 3)
			Mid(TxtImpreso, IniCar, 3) = "   "
			Mid(TxtImpreso, FinCar, 3) = "   "
			Dim NueCar As String
			For I As Integer = 0 To DtCar.Rows.Count - 1
				NueCar = TextoCar
				NueCar = ReplaceJD(NueCar, "@CarBod@", "" & Gdn(DtCar, I, "bodega"))
				NueCar = ReplaceJD(NueCar, "@CarTip@", "" & Gdn(DtCar, I, "tipo"))
				NueCar = ReplaceJD(NueCar, "@CarNum@", "" & Gdn(DtCar, I, "numero"))
				NueCar = ReplaceJD(NueCar, "@CarVal@", FormatoMoneda(Gdn(DtCar, I, "valor"), True, True))
				NueCar = ReplaceJD(NueCar, "@CarApl@", FormatoMoneda(Gdn(DtCar, I, "aplicado"), True, True))
				NueCar = ReplaceJD(NueCar, "@CarSal@", FormatoMoneda(Gdn(DtCar, I, "saldo"), True, True))
				NueCar = ReplaceJD(NueCar, "@CarFec@", FormatoFecha(Gdn(DtCar, I, "fecha")))
				NueCar = ReplaceJD(NueCar, "@CarVen@", FormatoFecha(Gdn(DtCar, I, "vencimiento")))
				NueCar = ReplaceJD(NueCar, "@CarDia@", "" & Gdn(DtCar, I, "dias"))
				RenglonCar = RenglonCar & NueCar & DMScr()
			Next
			Cambie(TextoCar, RenglonCar, False)

			'por si no había forma de pago, limpiarla
			Cambie("@CarBod@", "")
			Cambie("@CarTip@", "")
			Cambie("@CarNum@", "")
			Cambie("@CarBod@", "")
			Cambie("@CarVal@", "")
			Cambie("@CarApl@", "")
			Cambie("@CarSal@", "")
			Cambie("@CarFec@", "")
			Cambie("@CarVen@", "")
			Cambie("@CarDia@", "")

		Catch ex As Exception
			Mensaje_TopMost("Advertencia: Error Inserte_Cartera: " & ex.Message & EsIngles())
		End Try
		'--------------- FIN CARTERA DEL CLIENTE ------------------------------------------

	End Sub
	Private Sub Inserte_Puntos()
		'--------------- puntos ------------------------------------------
		'If Not Falta_Licencia("1013", False) Then
		'    Try
		'        If Not Fin(DtPuntosDef) Then
		'            Cambie("@Pun@", CInt(ValD(LblTotalTotal.Text) / gdn(DtPuntosDef, "conversion")).ToString)
		'            Cambie("@PunTot@", PuntosAcumulados.ToString)
		'        End If
		'    Catch
		'    End Try
		'End If
		Cambie("@Pun@", "")
		Cambie("@PunTot@", "")
		'--------------- fin puntos ------------------------------------------

	End Sub
	Private Sub Inserte_Encabezado()
		Try
			Cambie("@IdFmt@", IdFormato)
			Cambie("@Empresa@", Gdn(DsTodo.Tables(7), "empresa"))
			Cambie("@Bod@", Gdn(DtEnc, "bodega"))
			Cambie("@BodDestino@", Gdn(DtEnc, "destino"))
			Cambie("@EmpDir@", "" & Gdn(DsTodo.Tables(7), "direccion"))
			Cambie("@EmpTel@", "" & Gdn(DsTodo.Tables(7), "telefonos"))
			Cambie("@BodDir@", "" & Gdn(DtEnc, "dir bodega"))
			Cambie("@BodTel@", "" & Gdn(DtEnc, "tel bodega"))
			Cambie("@BodPub@", Gdn(DtEnc, "publicidad"), , True)
			Cambie("@Id@", Strings.Format(Now, "yyMMddHHmm") & "-" & MarcaExterna & "-" & CualId.ToString)

			Cambie("@MiNit@", Gdn(DsTodo.Tables(7), "nit"))
			Cambie("@Operador@", Gdn(DtEnc, "nombre usuario"))
			Cambie("@CargoUsu@", "" & Gdn(DtEnc, "cargo usuario"))
			Cambie("@email_usuario@", Gdn(DtEnc, "eMail Usuario"))

			Cambie("@email@", "" & "" & Gdn(DtEnc, "eMail Vendedor"))
			Cambie("@TelVend@", "" & Gdn(DtEnc, "tel Vendedor"))
			Cambie("@ExtVend@", "" & Gdn(DtEnc, "ext Vendedor"))
			Cambie("@CelVend@", "" & Gdn(DtEnc, "cel Vendedor"))
			Cambie("@CargoVend@", "" & Gdn(DtEnc, "cargo vendedor"))

			Cambie("@Moneda@", Gdn(DtEnc, "moneda"))
			Cambie("@Tasa@", ValD(VABS(Gdn(DtEnc, "tasa"))))
			Cambie("@Clase@", Gdn(DtEnc, "clase"))

			Cambie("@Cliente@", Gdn(DtEnc, "cliente"))
			Cambie("@Proveedor@", Gdn(DtEnc, "cliente"))

			Cambie("@docref@", Gdn(DtEnc, "doc ref"))


			Cambie("@Nit@", "" & Gdn(DtEnc, "nit"))
			Cambie("@Digito@", IIf(Gdn(DtEnc, "digito") Is System.DBNull.Value, "", " - " & Gdn(DtEnc, "digito")))
			Cambie("@Zona@", "" & Gdn(DtEnc, "zona"))
			Cambie("@Subzona@", "" & Gdn(DtEnc, "subzona"))
			Cambie("@CupoTotal@", FormatoMoneda(ValD(Gdn(DtEnc, "cupo credito")), True, True))
			Cambie("@SaldoActual@", FormatoMoneda(ValD(Gdn(DtEnc, "saldo")), True, True))
			Cambie("@CupoDisponible@", FormatoMoneda(ValD(Gdn(DtEnc, "cupo credito")) - ValD(Gdn(DtEnc, "saldo")), True, True))
			Cambie("@Direccion@", "" & Gdn(DtEnc, "direccion"))
			Cambie("@Tel_1@", "" & Gdn(DtEnc, "tel 1"))
			Cambie("@Tel_2@", "" & Gdn(DtEnc, "tel 2"))
			Cambie("@TelContacto@", "" & Gdn(DtEnc, "tel contacto"))
			Cambie("@Cargo@", "" & Gdn(DtEnc, "cargo contacto"))
			Cambie("@email_contacto@", "" & "" & Gdn(DtEnc, "eMail Contacto"))
			'Cambie("@Tel_contacto@", "" & gdn(DtEnc, "tel contacto"))
			Cambie("@Cedula_contacto@", "" & "" & Gdn(DtEnc, "cedula"))
			Cambie("@Direccion_contacto@", IIf("" & Gdn(DtEnc, "dir contacto") <> "", "" & Gdn(DtEnc, "dir contacto"), "" & Gdn(DtEnc, "direccion")))

			Cambie("@NumCot@", Gdn(DtEnc, "numero"))
			Cambie("@Contacto@", Gdn(DtEnc, "contacto"))
			Cambie("@Tipo@", Gdn(DtEnc, "tipo doc"))
			Cambie("@TipoNotas@", Gdn(DtEnc, "notas_tipo1"), , True)
			Cambie("@TipoNotas2@", Gdn(DtEnc, "notas_tipo2"), , True)
			Cambie("@TipoNotas3@", Gdn(DtEnc, "notas_tipo3"), , True)
			Cambie("@Fecha@", Strings.Format(Gdn(DtEnc, "fecha doc"), "Long Date"))
			If Gdn(DtEnc, "Fecha Vcmto") Is System.DBNull.Value Then
				Cambie("@Vencimiento@", "")
			Else
				Cambie("@Vencimiento@", FormatoFecha(Gdn(DtEnc, "Fecha Vcmto")))
			End If

			If "" & Gdn(DtEnc, "tipo ant") <> "" Then
				Cambie("@DocOrig@", "Origen: " & Gdn(DtEnc, "tipo ant") & " - " & Gdn(DtEnc, "numero ant").ToString)
			Else
				Cambie("@DocOrig@", "")
			End If

			Cambie("@Sf@", Gdn(DtEnc, "Estado"))
			Cambie("@DiaValidez@", Gdn(DtEnc, "Dias validez"))
			Cambie("@Vend@", Gdn(DtEnc, "vendedor"))

			Cambie("@Placa@", Gdn(DtEnc, "placa"))
			Cambie("@Rombo@", Gdn(DtEnc, "rombo"))
			Cambie("@KmOrden@", Gdn(DtEnc, "km"))
			Cambie("@DesVeh@", Gdn(DtEnc, "vehiculo"))


			Cambie("@Autorizo@", Gdn(DtEnc, "autorizo"))

			Cambie("@Notas@", Gdn(DtEnc, "notas"), , True)
			Cambie("@FormaPago@", Gdn(DtEnc, "forma pago"))

			Cambie("@SubTotal@", FormatoMoneda(VALD2(Gdn(DtEnc, "subtotal")), True, True))
			Cambie("@Descuento@", FormatoMoneda(VALD2(Gdn(DtEnc, "descuento")), True, True))
			Cambie("@TotalSin@", FormatoMoneda(VALD2(Gdn(DtEnc, "subtotal")) - VALD2(Gdn(DtEnc, "descuento")), True, True))
			Cambie("@Iva@", FormatoMoneda(VALD2(Gdn(DtEnc, "Valor IVA")), True, True))
			Cambie("@Total@", FormatoMoneda(VALD2(Gdn(DtEnc, "valor total")), True, True))

			'los pedidos que utilizó, solo válido en facturas de despachos
			Dim Cuales As String = ""
			If Not Fin(DsTodo.Tables(3)) Then
				If Obtenga_Dato(DsTodo.Tables(3), "id_ped is not null", "id_ped") IsNot System.DBNull.Value Then
					Dim Ult As Integer = 0
					For I As Integer = 0 To DsTodo.Tables(3).Rows.Count - 1
						If ValD(Gdn(DsTodo.Tables(3), I, "id_ped")) > 0 Then
							If ValD(Gdn(DsTodo.Tables(3), I, "id_ped")) <> Ult Then
								If ValD(Gdn(DsTodo.Tables(3), I, "id_ped")) <> Ult Then
									Cuales += ValD(Gdn(DsTodo.Tables(3), I, "id_ped")).ToString & " "
								End If
								Ult = ValD(Gdn(DsTodo.Tables(3), I, "id_ped"))
							End If
						End If
					Next
				End If
			End If
			If Cuales <> "" Then
				Cambie("@IdPedido@", Cuales)
			Else
				Cambie("@IdPedido@", "")
			End If
			'fin los pedidos que utilizó

			For I As Integer = 1 To 6
				Cambie_Ret(ValD(Gdn(DtEnc, "ret" & I.ToString)), I)
				Cambie("@FacR" & I.ToString & "@", FormatoMoneda(VALD2(Gdn(DtEnc, "ret" & I.ToString)), False, True))
			Next
			'


			'aproximacion y propina
			'Dim PropinaPorcen As String = ValD("" & DrBod(0).Item("propina"))
			'Cambie("@Pr@", PropinaPorcen)
			'If fFp.Grd.Rows.Count > 0 Then 'ya tiene pago
			'    Cambie("@Vpr@", FormatoMoneda(vald2(fFp.TxtPropina.Text), True, True))
			'    Cambie("@Aju@", FormatoMoneda(vald2(fFp.LblAjuste.Text), True, True))
			'    Cambie("@Vtpr@", FormatoMoneda(vald2(ValD(fFp.TxtPropina.Text) + ValD(LblTotalTotal.Text)), True, True))
			'Else
			'    Cambie("@Vpr@", FormatoMoneda(vald2(LblPropina.Text), True, True))
			'    Cambie("@Aju@", FormatoMoneda(vald2(LblAjuste.Text), True, True))
			'    Cambie("@Vtpr@", FormatoMoneda(vald2(LblTotalMasPropina.Text), True, True))
			'End If

			Cambie("@Vpr@", "")
			Cambie("@Aju@", "")
			Cambie("@Vtpr@", "")

			Cambie("@CanTot@", ValD(Gdn(DtEnc, "cant tot")))
			Cambie("@LinTot@", ValD(Gdn(DtEnc, "cant lin")))

			'Cambie("@Cambio@", IIf(Val(LblCondicionPago.Tag) = 0, fFp.LblPendiente.Tag, "N/D"))
			Cambie("@Cambio@", "")

		Catch ex As Exception
			Mensaje_TopMost("Error en Inserte_Encabezado: " & ex.Message & EsIngles())

		End Try

	End Sub
	Private Sub Inserte_Discriminacion_Iva()
		Try
			If InStr(1, TxtImpreso, "@BaseIva@") <= 0 Then Exit Sub
			Dim TextoIva As String = ""
			Try
				Dim BaseIva As New DataTable
				Abrir(BaseIva, "GetCotBasesIva " & CualId.ToString)
				TextoIva = "Discriminación de Iva" & DMScr()
				For I As Integer = 0 To BaseIva.Rows.Count - 1
					If I > 0 Then TextoIva += vbNewLine
					TextoIva += CDbl(Gdn(BaseIva, I, "porcentaje_iva")).ToString & "% x "
					TextoIva += FormatoMoneda(Gdn(BaseIva, I, "base").ToString, True, True) & " = "
					TextoIva += FormatoMoneda(Gdn(BaseIva, I, "iva").ToString, True, True)
				Next

			Catch ex As Exception
			End Try
			Cambie("@BaseIva@", TextoIva, False, True)

		Catch ex As Exception
			Mensaje_TopMost("Advertencia: Error Inserte_Discriminacion_Iva: " & ex.Message & EsIngles(), , , True)

		End Try

	End Sub

	Private Sub Inserte_Interes_Mora()
		Try

			If InStr(TxtImpreso, "@IntMora@") = 0 And InStr(TxtImpreso, "@Total+Int@") = 0 Then Exit Sub

			Dim TotInt As Double = 0

			Dim TextoMora As String = ""
			TextoMora = FormatoMoneda(Gdn(DtEnc, "interes").ToString, True, True)
			TotInt = ValD(Gdn(DtEnc, "interes"))
			'Try
			'    Dim Mora As New DataTable
			'    Abrir(Mora, "GetCotInteresAcumulado " & CualId.ToString)
			'    If Not Fin(Mora) Then
			'        TextoMora = FormatoMoneda(Gdn(Mora, "total").ToString, True, True)
			'        TotInt = ValD(Gdn(Mora, "total"))
			'    Else
			'        TextoMora = FormatoMoneda(0, True, True)
			'    End If
			'Catch
			'End Try
			Cambie("@IntMora@", TextoMora)
			Cambie("@Total+Int@", FormatoMoneda(TotInt + VALD2(Gdn(DtEnc, "valor total")), True, True))

		Catch ex As Exception
			Mensaje_TopMost("Advertencia: Error Inserte_Interes_Mora: " & ex.Message & EsIngles(), , , True)

		End Try


	End Sub

	Private Sub Inserte_Imputacion()
		Try
			Dim IniPag As Integer = InStr(1, TxtImpreso, "@k@")
			Dim FinPag As Integer = InStr(IniPag + 1, TxtImpreso, "@k@")
			Dim TexPag As String = ""
			Dim RenglonPag As String = ""
			If IniPag = 0 Or FinPag = 0 Then Exit Sub


			Dim Dtp As DataTable = DsTodo.Tables(9).Copy()
			If Dtp.Rows.Count = 0 Then
				Abrir(Dtp, "GetConImputacionUnDocto " & CualSW.ToString & "," & CualId.ToString)
			End If

			'Dtp = DsTodo.Tables(6).Copy
			TexPag = Mid(TxtImpreso, IniPag + 3, FinPag - IniPag - 3)
			Mid(TxtImpreso, IniPag, 3) = "   "
			Mid(TxtImpreso, FinPag, 3) = "   "
			Dim NuePag As String
			Dim TotDeb As Double = 0
			Dim TotCre As Double = 0
			For i As Integer = 0 To Dtp.Rows.Count - 1
				NuePag = TexPag
				NuePag = ReplaceJD(NuePag, "@Cta@", "" & Gdn(Dtp, i, "cuenta"))
				NuePag = ReplaceJD(NuePag, "@DesCta@", "" & Gdn(Dtp, i, "descripcion"))
				NuePag = ReplaceJD(NuePag, "@DesCen@", "" & Gdn(Dtp, i, "centro"))
				NuePag = ReplaceJD(NuePag, "@Tercero@", "" & Gdn(Dtp, i, "tercero"))
				NuePag = ReplaceJD(NuePag, "@Base@", FormatoMoneda(Gdn(Dtp, i, "base"), True, True))
				NuePag = ReplaceJD(NuePag, "@ValDeb@", FormatoMoneda(Gdn(Dtp, i, "debito"), True, True))
				NuePag = ReplaceJD(NuePag, "@ValCre@", FormatoMoneda(Gdn(Dtp, i, "credito"), True, True))
				TotDeb += ValD(Gdn(Dtp, i, "debito"))
				TotCre += ValD(Gdn(Dtp, i, "credito"))
				RenglonPag = RenglonPag & NuePag & DMScr()
			Next
			Cambie(TexPag, RenglonPag, False)

			'por si no había forma de pago, limpiarla
			Cambie("@Cta@", "")
			Cambie("@DesCta@", "")
			Cambie("@DesCen@", "")
			Cambie("@Tercero@", "")
			Cambie("@Base@", "")
			Cambie("@ValDeb@", "")
			Cambie("@ValCre@", "")

			Cambie("@TotDeb@", FormatoMoneda(TotDeb, True, True))
			Cambie("@TotCre@", FormatoMoneda(TotCre, True, True))

		Catch ex As Exception
			Mensaje_TopMost("Advertencia: Error Inserte_Imputacion: " & ex.Message & EsIngles(), , , True)
		End Try

	End Sub



	Private Sub Terminar_Proceso(ByVal Forma As Form, ByVal EsMail As Short, ByVal VerPorPantalla As Boolean)
		Try
			Dim Path_Temp As String = System.IO.Path.GetTempPath()
			Dim MiNombreArch As String = Garantice_Nombre_Archivo("Sw" & CualSW.ToString & "_" & ValD(CualId).ToString & " " & Gdn(DtEnc, "cliente") & " " & Strings.Format(Now, "yyyyMMddHHmmss"))

			Dim Archivo As String

			Dim TexRTF As New RichTextBox
			TexRTF.Rtf = TxtImpreso
			If FormatoEnPDF(ValD(IdFormato)) Then
				Archivo = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString & "\" & MiNombreArch & ".pdf"
				If Not CrearPDF(Archivo, TexRTF) Then Exit Sub
			Else
				Archivo = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString & "\" & MiNombreArch & ".rtf"
				Try
					TexRTF.SaveFile(Archivo)
				Catch ex As Exception
					Mensaje(Idi("No se puede salvar el archivo por esta razón") & ": " & Archivo & DMScr(2) & ex.Message & EsIngles() & DMScr(2) & Idi("Solucione el problema e intente de nuevo"))
					Exit Sub
				End Try
			End If

			NoReloj(Forma)

			Dim fFi As New fBatch
			If EsMail = 2 Then 'no es un email
				Try
					If VerPorPantalla Then
						Ejecute_Proceso(Archivo)
					Else
						Ejecute_Impresora(Archivo)
					End If
					fFi.Auditoria_Imprimio(ValD(Gdn(DtEnc, "tabla")), "Imprimió (IdFmt=" & IdFormato & ")", ValD(CualId.ToString))
					fFi.Dispose()
				Catch ex As Exception
					Mensaje_TopMost("No se pudo abrir el archivo: " & DMScr(2) & Archivo & DMScr(2) & ex.Message & EsIngles())
				End Try
			Else
				Dim MailPara As String = ""
				Dim MailDe As String = ""
				MailPara = "" & Gdn(DtEnc, "eMail Contacto")
				MailDe = "" & Gdn(DtEnc, "eMail Usuario")
				If MailPara = "" Then
					MailPara = Mid(Trim(Inputbox2("El contacto " & Gdn(DtEnc, "contacto") & " del tercero " & Gdn(DtEnc, "cliente") & " no tiene correo electrónico. Favor entrar el correo que desea utilizar para este envío (quedará guardado en el contacto para próximas veces):")), 1, 80)
					If MailPara = "" Then Exit Sub
					If ValD(Gdn(DtEnc, "contacto_id")) > 0 Then
						Ejecutar(PutCotContactoMail, Gdn(DtEnc, "contacto_id"), MailPara) 'guardar el email pa la próxima
					End If
				End If
				Dim Asunto As String = ""
				Dim TexCorr As String = ""
				If CualSW = 0 Then
					Asunto = "Cotización de " & Gdn(DtEnc, "tipo doc") & "  (Id " & CualId.ToString & ")"
					TexCorr = "Atención" & DMScr() & Gdn(DtEnc, "contacto") & DMScr() & Gdn(DtEnc, "cliente") & DMScr(2) & "Según nuestras conversaciones, le adjunto la " & Asunto & DMScr(2) & "Con gusto estaré pendiente de cualquier comentario," & DMScr(2) & "Saludos," & DMScr(2) & Gdn(DtEnc, "vendedor") '& DMScr() & "" & gdn(Fmt, 1, "cargo_usuario") ' & DMScr() & "" & gdn(Fmt, 1, "email_usu")
				Else
					Asunto = "" & Gdn(DtEnc, "tipo doc") & "  (Id " & CualId.ToString & ")"
					TexCorr = "Atención" & DMScr() & Gdn(DtEnc, "contacto") & DMScr() & Gdn(DtEnc, "cliente") & DMScr(2) & "Adjunto " & Asunto & DMScr(2) & "Con gusto estaré pendiente de cualquier comentario," & DMScr(2) & "Saludos," & DMScr(2) & Gdn(DtEnc, "vendedor") '& DMScr() & "" & gdn(Fmt, 1, "cargo_usuario") ' & DMScr() & "" & gdn(Fmt, 1, "email_usu")
				End If
				NoReloj(Forma)
				'el IdTabla=-10 es para enviar el correo de una...masivo
				Enviar_Mail(
								ValD(Gdn(DtEnc, "vendedor")),
								"" & MailDe,
								"" & Gdn(DtEnc, "contacto"),
								MailPara,
								Asunto,
								TexCorr,
								Archivo,
								"", "", Numero_Empresa, Usuario, ValD(Gdn(DtEnc, "cliente_id")), ValD(Gdn(DtEnc, "contacto_id")), ValD(CualId.ToString), IIf(EsMail = 4, -10, 0))
			End If

		Catch ex As Exception
			Mensaje_TopMost("Error en Terminar_Proceso: " & ex.Message & EsIngles(), , , True)

		End Try

    End Sub
    Private Function VALD2(ByVal Valor As Object)
        Return ValD(Valor) * FactorMoneda

    End Function

    '------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------
    'funciones especiales quitadas de ppal para manejar el on-error
    Private Function Gdn(ByVal Dt As DataTable, ByVal NumeroFila As Integer, ByVal NombreCampo As String)
        Try
            Return Dt.Rows(NumeroFila).Item(NombreCampo)

        Catch ex As Exception
            Return "Err"

        End Try

    End Function
    Private Function Gdn(ByVal Dt As DataTable, ByVal NombreCampo As String)
        Try
            Return Gdn(Dt, 0, NombreCampo)
            'Return Dt.Rows(0).Item(NombreCampo)

        Catch ex As Exception
            Return "Err"

        End Try

    End Function
    '------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------


    Public Sub Imprima_Varios_Documentos(Progrma As String, Nombre_Sp As String, Optional Sw As Short = 1, Optional NumeroPermiso As Integer = 800)
        Dim fVer As New fVerFacturas
        fVer.DtFac = Nothing
        fVer.ProgramaLlama = Progrma
        fVer.NombreSp = Nombre_Sp
        fVer.Sw = Sw
        fVer.ShowDialog()

    End Sub


End Module
