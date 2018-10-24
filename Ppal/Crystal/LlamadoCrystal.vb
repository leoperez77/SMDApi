' Version: 685, 28-ago.-2018 12:08
' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 679, 16-ago.-2018 21:01
' Version: 679, 16-ago.-2018 20:01
' Version: 678, 16-ago.-2018 14:15
' Version: 659, 27-jun.-2018 13:25
' Version: 653, 16-may.-2018 12:43
' Version: 603, 5-dic.-2017 19:15
'♥ versión: 586, 6-oct.-2017 07:11
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Module LlamadoCrystal
	Dim DtFeRe As DataTable
	Dim FactorMoneda = 0 'no poner tipo a ver que pasa
	Dim TxtImpresoAnt As String = ""
	Dim TxtImpreso As String = ""
	'Dim IdFormato As String = ""
	Dim IdFormatoAnt As Integer = 0
	Dim DsTodo As New DataSet
	Dim DtEnc As New DataTable
	'Dim CualId As Integer
	Dim CualSW As Integer
	Public FormaOrigenVentaCrystal As Form = Nothing

	'public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long

	'Public Sub ImprimaArchivo(NombreArchivo As String)
	'    On Error Resume Next
	'    ShellExecute(0, "print", NombreArchivo, vbNullString, vbNullString, 1)

	'End Sub
	'Public Function TengoUltimaVersionCrystal(Mostrar As Boolean) As Boolean
	'    If MarcaExterna = "local" Then
	'        Return True
	'    End If

	'    Dim VersionEsperada As String = GetSett("Ayuda", "crystal" & MarcaExterna, "")
	'    If VersionEsperada = "" Then
	'        'Mensaje("No puedo verificar su versión de Crystal.  Reinicie Advance e intente de nuevo")
	'        'Return False
	'    Else

	'        Dim ControlCrys As String = Trim(ReglaDeNegocio(93, , Path_Prog & "report\")) 'ruta de crystal
	'        If ControlCrys = "" Then
	'            ControlCrys = Path_Prog & "report\"
	'        End If

	'        ReglaDeNegocio(93, , Path_Prog & "report\") 'ruta de crystal
	'        Try
	'            If Right(ControlCrys, 1) <> "\" Then
	'                ControlCrys &= "\"
	'            End If
	'            Dim fil As FileVersionInfo = FileVersionInfo.GetVersionInfo(ControlCrys & "SMDCrystal.exe")
	'            Dim VerAct As String = VersionEntera(fil.FileVersion).ToString
	'            If VerAct < VersionEsperada Then
	'                If Mostrar Then
	'                    Mensaje("Su versión de reportes " & VerAct & " es inferior a la versión esperada " & VersionEsperada & ". Actualice su versión de reportes por el menu, ayuda, actualizar, reportes")
	'                End If
	'                Return False
	'            End If

	'        Catch ex As Exception
	'            Mensaje_TopMost("No pude verificar versión de reportes de Crystal: " & DMScr() & ex.Message & EsIngles)
	'            Return False
	'        End Try
	'    End If

	'    Return True


	'End Function
	Public Sub Haga_Reporte2(ByVal TituloForma As String,
							ByVal NuevoImprimir As Integer,
							ByVal ReporteFileNameOrig As String,
							Optional DtEnc As DataTable = Nothing,
							Optional TituloCrystal As String = "")

		Haga_Reporte(TituloForma, NuevoImprimir, ReporteFileNameOrig,, DtEnc, TituloCrystal)



	End Sub


	Public Sub Haga_Reporte(ByVal TituloForma As String,
							ByVal NuevoImprimir As Integer,
							ByVal ReporteFileNameOrig As String,
							Optional CrystalView As CrystalDecisions.Windows.Forms.CrystalReportViewer = Nothing,
							Optional DtEnc As DataTable = Nothing,
							Optional TituloCrystal As String = "")
		'no tocar

		Dim ReporteFileName As String = Obtenga_Nombre_Reporte(ReporteFileNameOrig, True)
		If ReporteFileName = "" Then Exit Sub

		'If Not TengoUltimaVersionCrystal(True) Then
		'    Exit Sub
		'End If


		Try
			'Dim TiempoIni As DateTime = Now

			Dim Rsr As New CrystalDecisions.CrystalReports.Engine.ReportDocument

			'si el nombre viene con path, dejarlo así, de lo contrario agregar directorio reportes

			Dim TexAudi As String = ""

			Rsr.Load(ReporteFileName)

			'TituloForma += "(Cry: " & DateDiff(DateInterval.Second, TiempoIni, Now).ToString & "s)"
			Dim Repitio As Boolean = False
			Dim Impresora As Integer = 1

Repetir:
			Select Case NuevoImprimir
				Case 1
					Opcion_Imprimir(Rsr, Impresora)
					TexAudi = "Imprimió"
				Case 2
					If Impresora > 1 Then 'para la segunda impresión hacer nueva ventana
						Opcion_Ver(Rsr, TituloForma, Nothing)
					Else
						Opcion_Ver(Rsr, TituloForma, CrystalView)
					End If
					TexAudi = "Vió"

				Case 3
					Opcion_eMail(Rsr, TituloCrystal, DtEnc)
					TexAudi = "" 'esta debe salir del programa de email
				Case 4 'correo masivo
					Opcion_eMail(Rsr, TituloCrystal, DtEnc, True)
					TexAudi = "" 'esta debe salir del programa de email

				Case Else
					Mensaje_TopMost(Idi("No existe opción de imprimir") & ": " & NuevoImprimir.ToString, , , True)

			End Select

			If Not Repitio Then
				Repitio = True
				Dim Comanda As String = ReporteFileName.Replace(".rpt", "_comanda.rpt")
				If Dir(Comanda, FileAttribute.Archive) <> "" Then 'hay comanda, aqui podriamos cambiar de printer
					Rsr = New CrystalDecisions.CrystalReports.Engine.ReportDocument
					Rsr.Load(Comanda)
					Impresora = 2
					GoTo Repetir
				End If
			End If

			If TexAudi <> "" And Not Fin(DtEnc) Then
				Dim fFi As New fBatch
				fFi.Auditoria_Imprimio(ValD(Gdf(DtEnc, "tabla")), TexAudi, ValD(Gdf(DtEnc, "id")))
				fFi.Dispose()
			End If

		Catch ex As Exception
			Mensaje_TopMost("No se puede producir el reporte '" & ReporteFileNameOrig & "': " & ex.Message & EsIngles(), , , True)

		End Try


	End Sub

	''' <summary>
	''' JDMS, 24-Feb-2007
	''' Llamar esta rutina desde cualquier programa de Advance con o sin referencia a Crystal para imprimir o visualizar cualquier reporte de Advance
	''' </summary>
	''' <param name="SqlInstruccion">Texto con la instrucción de SQL que traerá los datos para formar las tablas en XML que después tomará Crystal Reports</param>
	''' <param name="NombreXMLconPath">Nombre con ruta completa del archivo XML que será tomado por Crystal. Ejemplo: c:\smd_files\r2365.xml. Nota: "c:\smd_files\" se considera fijo en Advance</param>
	''' <param name="NombreCrystalRPTsinPATH">Nombre del reporte físico de Cystal, sin su ruta. El reporte debe estar ubicado en "c:\smd_files\report\" o en la carpeta personal del cliente si está redefinido.</param>
	''' <param name="TituloReporte">T'tiulo del reporte</param>
	''' <param name="VerPorPantalla">Responda verdadero si desea que el reporte se muestre por pantalla, responda falso para que salga por impresión</param>
	''' <param name="EsCopia">Si es un documento, responda verdadero si está imprimiendo una copia</param>
	''' <remarks></remarks>
	Public Sub Imprima_Reporte_Libre(SqlInstruccion As String, NombreXMLconPath As String, NombreCrystalRPTsinPATH As String, TituloReporte As String, Optional VerPorPantalla As Boolean = True, Optional EsCopia As Boolean = False)

		Try

			SiReloj()
			Dim DsTodo As DataSet = New DataSet()
			Abrir(DsTodo, SqlInstruccion)

			'aqui se ponen los datos de la empresa
			Dim Dt2 As New DataTable
			Dt2.TableName = "emp"
			Dt2.Columns.Add("empresa", System.Type.GetType("System.String"))
			Dt2.Columns.Add("bodega", System.Type.GetType("System.String"))
			Dt2.Columns.Add("titulo", System.Type.GetType("System.String"))
			Dt2.Columns.Add("titulo_corto", System.Type.GetType("System.String"))

			Dim dr As DataRow
			dr = Dt2.NewRow()
			dr("empresa") = MiEmpresaNombre
			dr("bodega") = ""
			dr("titulo") = TituloReporte
			dr("titulo_corto") = TituloReporte
			Dt2.Rows.Add(dr)



			DsTodo.Tables.Add(Dt2)

			'logo
			Try
				Dim Dtn As DataTable = Traiga_Logo_Crystal()
				If Dtn Is Nothing Then
					GoTo Continuar
				End If


				Dim Dc As New DataColumn()
				Dc.DataType = System.Type.GetType("System.String")
				Dc.ColumnName = "version"
				Dtn.Columns.Add(Dc)

				Dc = New DataColumn
				Dc.DataType = System.Type.GetType("System.String")
				Dc.ColumnName = "es_copia"
				Dtn.Columns.Add(Dc)


				Dim FechaHoraModif As String = Obtenga_Nombre_Reporte(NombreCrystalRPTsinPATH, False, False, True)

				Dtn.Rows(0).Item("version") = "(" & LCase(MiCodigo) & "," & LCase(MiEmpresa) & "," & String_Version_Editada() & "," & MarcaExterna & ") (Rep. " & Replace(NombreCrystalRPTsinPATH, ".rpt", "") & " " & FechaHoraModif & ")"
				Dtn.Rows(0).Item("es_copia") = IIf(EsCopia, "S", "")
				Dtn.TableName = "logo"

				DsTodo.Tables.Add(Dtn.Copy)
			Catch ex As Exception
				NoReloj()
				MostrarError("Imprima_Reporte_Libre", "Crystal logo", ex.Message)
				Exit Sub
			End Try

Continuar:
			DsTodo.WriteXml(NombreXMLconPath, XmlWriteMode.WriteSchema)
			If Not DsTodo.Tables(0).Columns.Contains("tabla") Then
				DsTodo.Tables(0).Columns.Add("tabla")
			End If
			If Not DsTodo.Tables(0).Columns.Contains("id") Then
				DsTodo.Tables(0).Columns.Add("id")
			End If

			Haga_Reporte(TituloReporte, IIf(VerPorPantalla, 2, 1), NombreCrystalRPTsinPATH, , DsTodo.Tables(0), TituloReporte)
			NoReloj()

		Catch ex As Exception
			NoReloj()
			MostrarError("Imprima_Reporte_Libre", "LnkExtracto_LinkClicked", ex.Message)

		End Try


	End Sub

	Private Sub Actualizar_Reporte(ReporteFileNameOrig As String, ReporteDefault As String, ReporteCliente As String)
		Try
			ReporteFileNameOrig = ReporteFileNameOrig.Replace(".rpt", "") ' & ".rpt"

			If IO.File.Exists(ReporteCliente) Then 'si existe personalizado, no hacer nada
				Exit Sub
			End If

			Dim Actualiz As Boolean = False

			Dim FF As String = ""
			If DtFeRe IsNot Nothing Then
				FF = "" & Obtenga_Dato(DtFeRe, "nombre='" & ReporteFileNameOrig & ".rpt'", "fecha")
			End If


			If FF = "" Then
				DebugJD("Leyendo fecha reporte DB: " & ReporteFileNameOrig)
				Abrir(DtFeRe, "Select nombre,fecha from informes_fecha where nombre='" & ReporteFileNameOrig & ".rpt'")
				If Fin(DtFeRe) Then
					Exit Sub 'no está en la lista
				End If
				FF = Gdf(DtFeRe, "fecha")
			End If

			If IO.File.Exists(ReporteDefault) Then 'si existe, ver si se debe actualizar
				DebugJD("Existe " & ReporteDefault)
				Dim Fec As DateTime
				Fec = IO.File.GetLastWriteTime(ReporteDefault)
				If Fec < CDate(FF) Then
					Actualiz = True
				End If
			Else
				DebugJD("No Existe " & ReporteDefault)
				Actualiz = True
			End If

			DebugJD("Actualiz=" & Actualiz)

			If Actualiz Then 'actualizar reporte
				Dim fA As New fActuRep
				fA.Label1.Text &= DMScr() & ReporteFileNameOrig
				fA.Show()
				HagaEventos()

				Try
					Static DtUcl As DataTable
					If DtUcl Is Nothing Then
						Abrir(DtUcl, "Exec GetVersion5 802") 'es 802 pues aquí viene la ruta con http en lugar de ftp que es más facil para los usuarios
					End If
					'Try
					'    IO.File.Delete(ReporteDefault)
					'Catch ex As Exception
					'End Try
					Dim Tex As String = Replace(LCase(Gdf(DtUcl, "ruta_link")), "instalar_smd.net", "report/" & ReporteFileNameOrig & ".exe")

					DebugJD("DownLoadFile: " & Tex & DMScr() & "c:\smd_files\bin14\report\" & ReporteFileNameOrig & ".rpt")
					'My.Computer.Network.DownloadFile(Tex, "c:\smd_files\bin14\report\" & ReporteFileNameOrig & ".rpt", Gdf(DtUcl, "usuario"), Gdf(DtUcl, "clave"), False, 90000, True)
					My.Computer.Network.DownloadFile(Tex, ReporteDefault, Gdf(DtUcl, "usuario"), Gdf(DtUcl, "clave"), False, 90000, True)

					fA.Dispose()

				Catch ex As Exception
					fA.Dispose()

					MostrarError("LlamadoCrystal", "Actualizar_Reporte,1", ex.Message)

				End Try

			End If

		Catch ex As Exception

			MostrarError("LlamadoCrystal", "Actualizar_Reporte", ex.Message)

		End Try


	End Sub
	Public Function Obtenga_Nombre_Reporte(ReporteFileNameOrig As String, MostrarMensajeAusencia As Boolean, Optional EsPrueba As Boolean = False, Optional DevolverFechaHoraModif As Boolean = False) As String
		'este es el reporte cliente
		Dim ReporteCliente As String = ReglaDeNegocio(93, , "").Trim
		If ReporteCliente = "" Then 'si no tiene ninguno definido, intentamos con un por defecto
			ReporteCliente = Path_Prog & "report" & Numero_Empresa.ToString & "\"
		End If
		ReporteCliente &= IIf(Right(ReporteCliente, 1) = "\", "", "\") & ReporteFileNameOrig

		'el default
		Dim ReporteDefault As String = Path_Prog & "report\" & ReporteFileNameOrig

		'parte de ingles
		If LenguajeAdvance = 1 Then
			If IO.File.Exists(ReporteDefault.Replace(".rpt", "") & "_eng.rpt") Then 'ver si hay en inglés
				ReporteDefault = ReporteDefault.Replace(".rpt", "") & "_eng"
				ReporteFileNameOrig = ReporteFileNameOrig.Replace(".rpt", "") & "_eng"
			End If
			'parte de ingles
			If IO.File.Exists(ReporteCliente.Replace(".rpt", "") & "_eng.rpt") Then 'ver si hay en inglés
				ReporteCliente = ReporteCliente.Replace(".rpt", "") & "_eng"
			End If
		End If


		If LCase(Right(ReporteDefault, 4)) <> ".rpt" Then ReporteDefault &= ".rpt"
		If LCase(Right(ReporteCliente, 4)) <> ".rpt" Then ReporteCliente &= ".rpt"

		Actualizar_Reporte(ReporteFileNameOrig, ReporteDefault, ReporteCliente)

		DebugJD("Report default: " & ReporteDefault & ", cli: " & ReporteCliente)

		Dim Respuesta As String = ""
		If Not IO.File.Exists(ReporteCliente) Then 'no existe el de la empresa
			DebugJD("No existe rep cli")
			If Not IO.File.Exists(ReporteDefault) Then 'tampoco el estandar
				DebugJD("No existe rep def")
				If MostrarMensajeAusencia Then
					Mensaje_TopMost(ReporteDefault & ": " & Idi("Reporte no existe. Haga clic en el Menú Principal de Advance, Ayuda, Actualizar Advance, Reportes.  Después vuelva a intentar producir el reporte"))
				End If
				Respuesta = ""
			Else
				If EsPrueba Then
					Respuesta = "d" 'es default
				Else
					Respuesta = ReporteDefault
				End If
			End If
		Else
			If EsPrueba Then
				Respuesta = "c" 'es cliente
			Else
				Respuesta = ReporteCliente
			End If
		End If

		If DevolverFechaHoraModif Then
			Try
				Respuesta = Strings.Format(IO.File.GetLastWriteTime(Respuesta), "yyyyMMddHHmmss")
			Catch
				Respuesta = "error fecha"
			End Try
		End If

		Return Respuesta


		'Dim ReporteFileName As String = ReporteFileNameOrig
		'Dim ReporteFileName2 As String = ReporteFileNameOrig
		''si no tiene la ruta incluida, vamos a ponerla
		'If Not ReporteFileName.Contains("\") Then
		'    Dim Pth As String = ReglaDeNegocio(93, , Path_Prog)
		'    Dim Pth2 As String = Path_Prog
		'    If Right(Pth, 1) <> "\" Then Pth &= "\"
		'    ReporteFileName = Pth & ReporteFileName 'este es el de la empresa
		'    ReporteFileName2 = Path_Prog & "report\" & ReporteFileName2 'este es el estandar
		'End If

		'If LCase(Right(ReporteFileName, 4)) <> ".rpt" Then
		'    ReporteFileName &= ".rpt"
		'End If
		'If LCase(Right(ReporteFileName2, 4)) <> ".rpt" Then
		'    ReporteFileName2 &= ".rpt"
		'End If

		'If Not IO.File.Exists(ReporteFileName) Then 'no existe el de la empresa
		'    If Not IO.File.Exists(ReporteFileName2) Then 'tampoco el estandar
		'        If MostrarMensajeAusencia Then
		'            Mensaje_TopMost("Reporte " & ReporteFileName & " no existe. Haga clic en el Menú Principal de Advance, Ayuda, Actualizar Advance, Actualizar Reportes.  Después vuelva a intentar producir el reporte")
		'        End If
		'    Else
		'        Return ReporteFileName2
		'    End If
		'    Return ""
		'Else
		'    Return ReporteFileName
		'End If


	End Function
	Private Sub Opcion_Imprimir(ByVal Rsr As ReportDocument, Impresora As Integer)
		Dim fRep As New fCrystal


		fRep.Rsr = Rsr
		fRep.Imprimalo(Impresora)

		'fRep.CrystalReportViewer1.ReportSource = Rsr
		'fRep.CrystalReportViewer1.PrintReport()

	End Sub
	Private Sub Opcion_Ver(ByVal Rsr As ReportDocument, ByVal TituloForma As String, Optional CrystalView As CrystalDecisions.Windows.Forms.CrystalReportViewer = Nothing)
		If CrystalView IsNot Nothing Then
			CrystalView.ReportSource = Rsr
			CrystalView.DisplayStatusBar = False
			Exit Sub
		End If

		Dim fRep As New fCrystal
		fRep.Rsr = Rsr

		'fRep.CrystalReportViewer1.ReportSource = Rsr

		'fRep.Tag = Cual & TagForma
		fRep.Text = "(" & Strings.Format(My.Application.Info.Version.Major, "0") & "." & Strings.Format(My.Application.Info.Version.Minor, "0") & "." & Strings.Format(My.Application.Info.Version.Revision, "0") & ") " & TituloForma

		'fRep.WindowState = FormWindowState.Maximized
		fRep.BringToFront()
		fRep.Show()

		fRep.Focus()

	End Sub
	Private Sub Opcion_eMail(ByVal Rsr As ReportDocument,
							ByVal Titulo As String,
							Optional DtEnc As DataTable = Nothing,
							Optional Masivo As Boolean = False)

		Dim CrExportOptions As ExportOptions
		Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
		Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
		CrDiskFileDestinationOptions.DiskFileName = Path_Temp & "r" & Strings.Format(Now, "yyyyMMddHHmmss") & ".pdf"
		CrExportOptions = Rsr.ExportOptions
		With CrExportOptions
			.ExportDestinationType = ExportDestinationType.DiskFile
			.ExportFormatType = ExportFormatType.PortableDocFormat
			.DestinationOptions = CrDiskFileDestinationOptions
			.FormatOptions = CrFormatTypeOptions
		End With
		Rsr.Export()

		'---------------------------------------------------------------------------------------------

		Dim MailPara As String = ""
		Dim MailDe As String = ""
		Dim ClienteID As Integer = 0
		Dim ContactoID As Integer = 0
		Dim Asunto As String = Titulo
		Dim TexCorr As String = ""
		Dim CualID As Integer = 0
		Dim IdTabla As Integer = 0
		Dim Vended As Integer = 0
		Dim Contacto As String = ""
		If DtEnc IsNot Nothing Then
			Vended = ValD(Gdf(DtEnc, "vendedor"))
			Contacto = "" & Gdf(DtEnc, "contacto")
			MailPara = "" & Gdf(DtEnc, "eMail Contacto")
			MailDe = "" & Gdf(DtEnc, "eMail Usuario")
			ClienteID = ValD(Gdf(DtEnc, "cliente_id"))
			ContactoID = ValD(Gdf(DtEnc, "contacto_id"))
			CualID = ValD(Gdf(DtEnc, "id"))
			IdTabla = ValD(Gdf(DtEnc, "tabla"))
			If DtEnc.Columns.Contains("asunto") Then
				Asunto = "" & Gdf(DtEnc, "asunto")
			Else
				Asunto = "" & Gdf(DtEnc, "tipo doc") & IIf(ValD(Gdf(DtEnc, "numero")) > 0, " #" & ValD(Gdf(DtEnc, "numero")), "") & " (Id " & CualID.ToString & ")"
			End If
			TexCorr = "Atención" & DMScr() & Gdf(DtEnc, "contacto") & DMScr() & Gdf(DtEnc, "cliente") & DMScr(2) & "Adjunto " & Asunto & DMScr(2) & "Con gusto estaré pendiente de cualquier comentario," & DMScr(2) & "Saludos," & DMScr(2) & Gdf(DtEnc, "vendedor") '& DMScr() & "" & gdf(Fmt, 1, "cargo_usuario") ' & DMScr() & "" & gdf(Fmt, 1, "email_usu")
			If DtEnc.Columns.Contains("asunto") Then 'cuando es informe tecnico agregar estos daticos
				TexCorr &= DMScr() & "" & Gdf(DtEnc, "cargo_usuario") & DMScr() & MailDe
			End If

			If MailPara = "" Then
				MailPara = Mid(Trim(Inputbox2("El contacto " & Gdf(DtEnc, "contacto") & " del tercero " & Gdf(DtEnc, "cliente") & " no tiene correo electrónico. Favor entrar el correo que desea utilizar para este envío (será guardado para la próxima vez):")), 1, 80)
				If MailPara = "" Then Exit Sub
				If ValD(Gdf(DtEnc, "contacto_id")) > 0 Then
					Ejecutar(PutCotContactoMail, Gdf(DtEnc, "contacto_id"), MailPara) 'guardar el email pa la próxima
				End If
			End If
		End If

		'truco para que haga clic solito en el botón enviar
		If Masivo Then
			IdTabla = IdTabla * -1
			If IdTabla = 0 Then
				IdTabla = -10
			End If
		End If

		Enviar_Mail(
						Vended,
						"" & MailDe,
						Contacto,
						MailPara,
						Asunto,
						TexCorr,
						CrDiskFileDestinationOptions.DiskFileName,
						"", "", Numero_Empresa, Usuario, ClienteID, ContactoID, ValD(CualID.ToString), IdTabla)


		'---------------------------------------------------------------------------------------------


		'Enviar_Mail("", "", "", "", Titulo, "", CrDiskFileDestinationOptions.DiskFileName)


	End Sub

	Public Function Traiga_Logo_Crystal() As DataTable
		Dim Ds2 As New DataSet
		Try
			Ds2.ReadXml(Path_Temp & "logo" & Numero_Empresa.ToString & ".xml")
		Catch ex2 As Exception
			Try
				Ds2.ReadXml(Path_Temp & "logo1.xml")
			Catch ex As Exception
				Mensaje_TopMost("Empresa no tiene Logo definido en imagen #8 del programa 0280.  Informe a su administrador. No puede continuar.", , , True)
				Return Nothing
			End Try
		End Try

		'por si viene mas de un logo
		If Ds2.Tables(0).Rows.Count > 1 Then
			Do Until Ds2.Tables(0).Rows.Count = 1
				Ds2.Tables(0).Rows(1).Delete()
			Loop
		End If
		Return Ds2.Tables(0).Copy


	End Function

	Public Sub Llamar_Reporte_Crystal2(DsTodo As DataSet, NombreXML As String,
									   NomSt As String,
									   NombreCrystal As String,
									   Titulo As String,
									   CualEmpresa As String,
									   NombreBod As String,
									   Optional TituloCrystal As String = "",
									   Optional DtEnc As DataTable = Nothing,
									   Optional NuevoImpr As Integer = 2)



		Llamar_Reporte_Crystal(DsTodo:=DsTodo,
							   NombreXML:=NombreXML,
							   NomSt:=NomSt,
							   NombreCrystal:=NombreCrystal,
							   Titulo:=Titulo, CualEmpresa:=CualEmpresa,
							   NombreBod:=NombreBod,
							   TituloCrystal:=TituloCrystal,
							   DtEnc:=DtEnc,
							   NuevoImpr:=NuevoImpr)


	End Sub
	Public Sub Llamar_Reporte_Crystal(DsTodo As DataSet,
									  NombreXML As String,
									  NomSt As String,
									  NombreCrystal As String,
									  Titulo As String,
									  CualEmpresa As String,
									  NombreBod As String,
									  Optional TituloCrystal As String = "",
									  Optional CrystalView As CrystalDecisions.Windows.Forms.CrystalReportViewer = Nothing,
									  Optional DtEnc As DataTable = Nothing,
									  Optional NuevoImpr As Integer = 2
									  )
		'Dim DsTodo As New DataSet

		If Left(NomSt, 5) = "Exec " Then
			NomSt = "set transaction isolation level read uncommitted" & DMScr() & NomSt
		End If

		Try
			If DsTodo Is Nothing Then
				Abrir(DsTodo, NomSt)
			End If
		Catch ex As Exception
			MostrarError("LlamadoCrystal", "Abrir: Llamar_Reporte_Crystal", ex.Message)
			Exit Sub
		End Try

		Try
			If DsTodo.Tables.Contains("logo") = False Then
				'Dim Ds2 As New DataSet
				'Try
				'    Ds2.ReadXml(Path_Temp & "logo" & Numero_Empresa.ToString & ".xml")
				'Catch ex2 As Exception 'tratar con dms logo
				'    Try
				'        Ds2.ReadXml(Path_Temp & "logo1.xml")
				'    Catch ex As Exception
				'        Mensaje_TopMost("Empresa no tiene Logo definido en imagen #8 del programa 0180.  Informe a su administrador. No puede continuar.", , , True)
				'        Exit Sub
				'    End Try
				'End Try
				'agregar al Ds normal
				Dim Dtn As DataTable = Traiga_Logo_Crystal()
				If Dtn Is Nothing Then
					Exit Sub
				End If
				Dtn.TableName = "logo"
				DsTodo.Tables.Add(Dtn.Copy)
			End If

		Catch ex As Exception
			MostrarError("LlamadoCrystal", "Logo: Llamar_Reporte_Crystal", ex.Message)
			Exit Sub
		End Try

		Try
			If DsTodo.Tables.Contains("emp") = False Then
				Dim Dt As New DataTable
				Dim Dc As DataColumn
				Dc = New DataColumn()
				Dc.DataType = System.Type.GetType("System.String")
				Dc.ColumnName = "empresa"
				Dt.Columns.Add(Dc)

				Dc = New DataColumn()
				Dc.DataType = System.Type.GetType("System.String")
				Dc.ColumnName = "bodega"
				Dt.Columns.Add(Dc)

				Dc = New DataColumn()
				Dc.DataType = System.Type.GetType("System.String")
				Dc.ColumnName = "titulo"
				Dt.Columns.Add(Dc)

				Dc = New DataColumn()
				Dc.DataType = System.Type.GetType("System.String")
				Dc.ColumnName = "titulo_corto"
				Dt.Columns.Add(Dc)

				Dim FechaHoraModif As String = Obtenga_Nombre_Reporte(NombreCrystal, False, False, True)

				Dt.Rows.Add(CualEmpresa, NombreBod, Titulo & " (" & LCase(MiCodigo) & "," & LCase(MiEmpresa) & "," & String_Version_Editada() & "," & MarcaExterna & ") (Rep." & FechaHoraModif & ")", TituloCrystal)

				Dt.TableName = "emp"
				DsTodo.Tables.Add(Dt.Copy)
			End If

		Catch ex As Exception
			MostrarError("LlamadoCrystal", "llenar: Llamar_Reporte_Crystal", ex.Message)
			Exit Sub
		End Try

		Try
			DsTodo.WriteXml("c:\smd_files\" & NombreXML & ".xml", XmlWriteMode.WriteSchema)

			If NombreCrystal = "" Then
				Mensaje(Idi("El reporte de Crystal no existe. Archivo creado") & ": " & NombreXML & ".xml")
			Else
				If DtEnc IsNot Nothing Then 'para enviar por email programa 1155 por el momento: 8-ago-2012
					Haga_Reporte(Titulo, 3, NombreCrystal, CrystalView, DtEnc)
				Else
					Haga_Reporte(Titulo, NuevoImpr, NombreCrystal, CrystalView, , TituloCrystal)
				End If
			End If
		Catch ex As Exception
			MostrarError("LlamadoCrystal", "Producir: Llamar_Reporte_Crystal", ex.Message)
		End Try



	End Sub



End Module
