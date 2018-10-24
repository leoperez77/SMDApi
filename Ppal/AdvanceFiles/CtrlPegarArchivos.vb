' Version: 685, 28-ago.-2018 12:08
' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 678, 16-ago.-2018 14:15
' Version: 675, 14-ago.-2018 18:45
'♥ versión: 586, 6-oct.-2017 07:11
Public Class CtrlPegarArchivos
    Public Event DMSModificoArchivos(IdFile As Integer, Nombre_File As String)
    Public Event DMSMoverArchivo(IdFile As Integer)


    Dim MarcaExterna As String = ""
    Public Usuario As Integer = 0

    Dim fEs As fEspera

    Dim LstDel As New ListBox
    Dim LstDelArch As New ListBox
    Dim TxtUsuarioFTP As String
    Dim TxtClaveFTP As String
    Dim RutaFTP As String
    Public DMSAplicacion As String = ""
    Public DMSNumeroPrograma As String = ""
    Public TocoAlgo As Boolean = False
    Public PermiteModificar As Boolean = True
    Dim UsarFtp As Boolean = False
    Dim EvitarMensaje As Boolean = False
    Dim Usar_Nodo_1 As Boolean = False
    Public TextoProgreso As String = ""
    'Dim Cancelar As Boolean = False

    Public Permi_3000 As Short = 3000
    Public Permi_3001 As Short = 3001
    Public Numero_Empresa As Integer = SMDPpal.Numero_Empresa 'para que se pueda redefinir, help desk p.e.







    Private Sub CtrlPegarArchivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'LnkAdicionar.Text = Idi(LnkAdicionar.Text)
		Recorrer_Controles_Idioma(Me, Me)

		'no se pone nada aqui..todo se pone abajo en: Iniciar_Advance_Files
		Esconder_PicLogo(False)


	End Sub

	Public Sub Iniciar_Advance_Files(Palabra_Aplicacion As String, NumeroPrograma As String, Optional Ftp_Nodo_Col As Boolean = False)
		MarcaExterna = SMDPpal.MarcaExterna
		If Usuario = 0 Then
			Usuario = SMDPpal.Usuario
		End If

		If Palabra_Aplicacion = "hd" Or Palabra_Aplicacion = "hd-r" Or Usuario = 1 Then
			Numero_Empresa = 1 'todo helpdesk es empresa 1
		End If


		Limpiar_Archivos()


		DMSAplicacion = Palabra_Aplicacion
		DMSNumeroPrograma = NumeroPrograma

		Grd.CmdOtrasOpciones0.Text = Idi("Guardar en mi PC como...")
		Grd.CmdOtrasOpciones0.Visible = True
		Grd.Separador0.Visible = True
		Grd.CmdOtrasOpciones.Text = Idi("Ver Log del archivo")
		Grd.CmdOtrasOpciones.Visible = True
		Grd.CmdOtrasOpciones2.Text = "Enviar link del archivo por chat"
		Grd.CmdOtrasOpciones2.Visible = True

		Try
			Progreso("Iniciando...")

			LblStatus.Visible = False
			LblStatus.Dock = DockStyle.Fill

			'truco para Helpdesk trabaje en nodo col
			Dim ree As Integer = 180
			Usar_Nodo_1 = False
			If Ftp_Nodo_Col Then
				ree = -180
				Usar_Nodo_1 = True
			End If
			TxtUsuarioFTP = ReglaDeNegocio(ree, "usuario3", "")
			TxtClaveFTP = ReglaDeNegocio(ree, "clave3", "")
			RutaFTP = ReglaDeNegocio(ree, "ruta3", "") & "/" & MarcaExterna & Numero_Empresa
			UsarFtp = ReglaDeNegocio(ree, "usar_ftp3", "0") <> "1"
			'para que no envíe el mensaje a JD
			EvitarMensaje = ReglaDeNegocio(ree, "evitar_men", "0") = "1"

			'para el icono del archivo
			Dim GrdFoto = New System.Windows.Forms.DataGridViewImageColumn()
			Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
			'GrdFoto.DataPropertyName = "icono"
			DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle43.Padding = New System.Windows.Forms.Padding(3)

			GrdFoto.DefaultCellStyle = DataGridViewCellStyle43
			GrdFoto.HeaderText = ""
			GrdFoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
			GrdFoto.Name = "icono"
			GrdFoto.ReadOnly = True

			Try
				Grd.Grid.Rows.Clear()
				Grd.Grid.Columns.Clear()

			Catch ex As Exception

			End Try



			Grd.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {GrdFoto})

			Grd.Grid.Columns("icono").DisplayIndex = 0
			'/para el icono del archivo


			''para nuevo
			'Dim Dt As New DataTable
			'Dt.Columns.Add("archivo", System.Type.GetType("System.String"))
			'Dt.Columns.Add("tamano", System.Type.GetType("System.Int32"))
			'Dt.Columns.Add("fecha", System.Type.GetType("System.String"))
			'Dt.Columns.Add("id", System.Type.GetType("System.Int32"))
			''/para nuevo

			'Mostrar_Archivos(Dt)

			Progreso("")

		Catch ex As Exception
			Progreso("")
			MostrarError(Me.Name, "Iniciar_Advance_Files", ex.Message)

		End Try
	End Sub
	Public Sub LnkAdicionar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkAdicionar.LinkClicked
		'If Cancelar Then
		'    Cancelar = False
		'    Exit Sub
		'End If

		If Not Hay_DMSAplicacion() Then
			Exit Sub
		End If

		Try

			Try
				OpenFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString
			Catch ex As Exception
			End Try

			Dim result As DialogResult = OpenFileDialog1.ShowDialog()


			If (result <> DialogResult.OK) Then
				Exit Sub
			End If

			Enviar_Archivo(OpenFileDialog1.FileName)



		Catch ex As Exception
			MostrarError(Me.Name, "LnkAdicionar_LinkClicked", ex.Message)
			Exit Sub
		End Try


	End Sub
	Private Sub Progreso(Texto As String)
		If Texto = "" Then
			LblStatus.Visible = False
		Else
			LblStatus.Text = Texto
			LblStatus.Visible = True
			LblStatus.BringToFront()
		End If
		HagaEventos()

	End Sub
	Private Sub Enviar_Archivo(NombreFile As String)
		If Not Hay_DMSAplicacion() Then
			Exit Sub
		End If
		If Not PermiteModificar Then
			Mensaje("Documento NO es modificable. No se permite adicionar archivos")
			Exit Sub
		End If

		If UsarFtp Then
			Mensaje("Para usar esta opción debe activar la llave [usar_ftp3] de la Rn#180")
			Exit Sub
		End If

		'verificar permisos
		If Permi_3000 <> -1 Then
			If NoPuede4(DMSNumeroPrograma, Permi_3000, , True, "Archivo: " & NombreFile) Then
				Exit Sub
			End If
		End If

		If Len(ArchivoSinPath(NombreFile)) > 250 Then
			Mensaje("Nombre de Archivo máximo de 250 caracteres")
			Exit Sub
		End If





		'solo la primera vez y cuando está creando registro nuevo para poder pintar el grid
		If Grd.DMSDevolverDt Is Nothing Then
			Try
				SiReloj()
				Dim Dt2 As New DataTable
				'solo para los nombres de campos
				Abrir_Nodo_Otro(Dt2, "GetArchivosAplicacion '**',0", Convierta_IP(MarcaExterna)) 'dummy, no debe devolver nada
				Mostrar_Archivos(Dt2)
				NoReloj()
			Catch ex As Exception
				NoReloj()
				MostrarError(Me.Name, "Enviar_Archivo", ex.Message)
				Exit Sub
			End Try
		End If
		'/solo la primera vez y cuando está creando registro nuevo


		Dim dt As DataTable = Grd.DMSDevolverDt
		Dim Contenido As String = ""
		Dim Posicion As Integer = 0
		Dim IdId As Object = Obtenga_Dato(dt, "archivo='" & ArchivoSinPath(NombreFile) & "'", "id")
		If IdId IsNot DBNull.Value Then
			If ValD(IdId) > 0 Then
				Dim ConteTemp As String = "" & Obtenga_Dato(dt, "id=" & IdId, "contiene")
				If Pregunte("Archivo ya existe, desea actualizarlo?" & IIf(ConteTemp <> "", DMScr(2) & "Archivo: " & ConteTemp, "")) Then
					If NoPuede4(DMSNumeroPrograma, Permi_3001, , False) And Permi_3001 <> -1 Then
						Mensaje("No tiene permiso para actualizar")
						Exit Sub
					Else
						Posicion = ValD(Obtenga_Dato(dt, "id=" & IdId, "posicion"))
						If Posicion = 0 Then
							Posicion = IdId
						End If
						Contenido = ConteTemp 'no se puede cambiar, se arriesga
						Grd_DMSTraerValorEliminar(Grd, IdId, -1) 'para que no dispare la modifcación
						dt = Grd.DMSDevolverDt
					End If
				Else
					Exit Sub
				End If
			Else
				Mensaje("Archivo ya fue agregado y no ha actualizado")
				Exit Sub
			End If
		End If

Repita:
		If Contenido = "" Then 'para que no lo haga cuando está eliminando
			Dim fPr As New fPregContenido
			fPr.PicLogo.Image = PicLogo.Image
			fPr.LblFile.Text = NombreFile & DMScr() & "Tamaño: " & Devolver_Tamaño(FileLen(NombreFile)) & " KB"
			'si es ftp se permite 10 veces mas

			fPr.ShowDialog()
			If fPr.Tag = "-1" Then
				Exit Sub
			End If

			Contenido = fPr.Tag
		End If

		If Contenido <> "" Then
			If Obtenga_Dato(dt, "contiene='" & Contenido & "'", "id") IsNot DBNull.Value Then
				Mensaje("Este contenido ya se encuentra en el grid, debe usar otro contenido o dejarlo en blanco")
				GoTo Repita
			End If
		End If


		Dim ArchivoMaximo As Integer = GetSett("ctrl", "max", 0)


		Progreso("Analizando...")

		Dim Tamaño As Integer
		Dim File_Size As Integer

		Dim NombreArchivo As String

		'tamaño sin empaquetado
		Tamaño = FileLen(NombreFile)
		If LCase(Strings.Right(NombreFile, 8)) <> ".dms.zip" Then
			NombreFile = Empaquetar(NombreFile)
		End If

		Progreso("")

		Try
			'tamaño empaquetado
			File_Size = FileLen(NombreFile)

			Dim maxfile As Integer = 51200000  ' ArchivoMaximo * 10
			If Tamaño > maxfile Then
				Mensaje(Idi("Este archivo tiene") & " " & Strings.Format((Tamaño / 1024), "0.00") & " kb " & Idi("y no puede ser mayor a") & " " & Strings.Format((maxfile / 1024), "0.00") & " kb")
				Exit Sub
			End If

			NombreArchivo = ArchivoSinPath(NombreFile)

			'If Not Pregunte("Seguro de enviar este archivo (Tamaño: " & Tamaño.ToString & " bytes)?" & DMScr(2) & NOMBREFILE) Then Exit Sub

		Catch ex As Exception
			'MostrarError(Me.Name, "EnviarArchivo", ex.Message & EsIngles)
			Mensaje(Idi("No se pudo enviar archivo") & ": " & ex.Message & EsIngles())
			Exit Sub
		End Try

		If NombreArchivo = "" Then
			Mensaje("No seleccionó archivo")
			Exit Sub
		End If


		'adicionar al grid
		Try
			Grd.Visible = True
			ChkHeaders.Visible = True
			Esconder_PicLogo(True)

			Dim NomFile As String = NombreArchivo.Replace(".dms.zip", "")

			'-----------------------------------------------------------------------------------------------------------------------------
			Dim Pos2 As Integer = Grd.Grid.Rows.Count + 1500000000
			If Posicion > 0 Then
				Pos2 = Posicion
			End If
			dt.Rows.Add(NomFile, IIf(Contenido = "", NomFile, Contenido), Tamaño, Devolver_Tamaño(Tamaño), File_Size, Devolver_Tamaño(File_Size), Now, "Mi", Grd.Grid.Rows.Count * -1, 0, "", Posicion, Pos2)
			'-----------------------------------------------------------------------------------------------------------------------------


			Dim Fila As Integer = Grd.Grid.Rows.Count - 1
			If Posicion > 0 Then
				Mostrar_Archivos(Filtrar_DataTable(dt, "", "pos2"))
				'para saber que fila quedó y poder hacwerla visible
				For I As Integer = 0 To Grd.Grid.Rows.Count - 1
					If Tm(Grd.Grid, "pos2", I) = Posicion Then
						Fila = I
						Exit For
					End If
				Next
			Else
				Grd.Grid.DataSource = dt
				'poner icono
				Grd.Grid.Rows(Fila).Cells("icono").Value = Ponga_Icono(NomFile)

			End If
			'solo para recuperar la posición
			Grd.Grid.Rows(Fila).Selected = True
			If Fila > 2 Then
				Grd.Grid.FirstDisplayedScrollingRowIndex = Fila - 2 'el 4 es para que deje 2 líneas arriba
			End If
			TocoAlgo = True

			RaiseEvent DMSModificoArchivos(Fila, NomFile)


		Catch ex As Exception

		End Try
		'Abrir(Dt, "PutDatosArchivo2", NumEmp.ToString, UsuFrom.ToString, LblPara.Tag, LblArchivo.Tag, LblTamaño.Text)

	End Sub
	Private Function Ponga_Icono(Archivo As String) As Image
		Dim dd() As String = Archivo.Split(".")
		Dim Cual As Integer = -1
		Select Case LCase(dd(dd.Length - 1)) 'tomar la ultima parte que es la extensión
			Case "doc", "docm", "docx", "docx", "rtf"
				Cual = 0
			Case "xl", "xla", "xlb", "xlc", "xld", "xlk", "xll", "xlm", "xls", "xlsx", "xlsb", "xlshtml", "xlsm", "xlt", "xlv", "xlw", "xlw"
				Cual = 1
			Case "pdf"
				Cual = 2
			Case "gif"
				Cual = 4
			Case "png"
				Cual = 5
			Case "sql"
				Cual = 6
			Case "txt", "log"
				Cual = 7
			Case "mov", "avi", "mpeg", "mpg", "asf", "div", "dvd", "qt", "qtl", "rpm", "smk", "vm", "wmv", "wob"
				Cual = 8
			Case "mp3", "mp4", "wav", "wma", "ogg", "ra", "aac", "ac3"
				Cual = 9
			Case "jpg", "jpeg", "bmp", "tif", "tiff", "ico", "raw", "xcf", "eps", "pcx", "pict", "dng", "wmp", "psb", "ico"
				Cual = 10
			Case "ppt", "pps", "pptx"
				Cual = 11
			Case "exe"
				Cual = 12
			Case "zip", "rar", "ace", "arj", "tar", "taz"
				Cual = 13
			Case "htm", "html"
				Cual = 14
			Case "rpt"
				Cual = 15
			Case "psd"
				Cual = 16
			Case Else
				Cual = 3 'todos los demás
		End Select

		Return ImageList1.Images(Cual)

	End Function
	Public Sub Limpiar_Archivos()
		LstDel.Items.Clear()
		LstDelArch.Items.Clear()
		Grd.Grid.DataSource = Nothing
		Grd.Visible = False
		ChkHeaders.Visible = False
		Esconder_PicLogo(False)
		TocoAlgo = False
		PermiteModificar = True

	End Sub
	Public Sub Subir_Archivos(CualID As Long, Optional SoloBorrar As Boolean = False)
		'esto es lo más importante
		If Not Hay_DMSAplicacion() Then
			Exit Sub
		End If
		If Not TocoAlgo Then
			Exit Sub
		End If

		'If Falta_Licencia("1006", True) Then
		'    Exit Sub
		'End If

		'Progreso("Procesando archivos......")
		'SiReloj()

		Dim DTF As DataTable = Filtrar_DataTable(Grd.DMSDevolverDt, "id<=0", "id desc")


		'estadisticas
		Dim BytesPorSegundo As Double = ValD(GetSetting("DMS S.A.", "estadis", "subir", 2000))
		If BytesPorSegundo < 0 Or BytesPorSegundo > 200000000 Then
			BytesPorSegundo = 5000
		End If
		Dim Segundos As Long = 0
		Dim TotalBytes As Long = 0
		Try
			If BytesPorSegundo > 0 Then
				For Each Fi As DataRow In DTF.Rows
					TotalBytes += Fi("file_size")
				Next
				TotalBytes += LstDel.Items.Count * 20000 'para los borrados, equivale como a 20kb
				Segundos = TotalBytes / BytesPorSegundo
				If Segundos <= 0 Then
					Segundos = 1
				End If
			End If
		Catch ex As Exception
		End Try




		BackgroundWorker1.RunWorkerAsync(New Object() {CualID, SoloBorrar, TotalBytes})


		fEs = New fEspera
		fEs.fCtrl = Me
		fEs.PicLogo.Image = PicLogo.Image
		fEs.ProgressBar1.Value = 0
		fEs.ProgressBar1.Maximum = Segundos
		fEs.ShowDialog()

	End Sub
	Private Function Devolver_Tamaño(TamañoBytes As Long) As String
		Try
			Dim TexSize As String = TamañoBytes / 1024
			If ValD(TexSize) < 1 Then
				TexSize = 1
			Else
				TexSize = Strings.Format(ValD(TexSize), "0")
			End If
			Return TexSize

		Catch ex As Exception
			Return TamañoBytes & " err"
		End Try



	End Function
	Private Sub CtrlPegarArchivos_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
		If e.Data.GetDataPresent("FileName", False) Then
			Try
				Dim Tex As New TextBox
				Tex.Lines = CType(e.Data.GetData("FileName", False), String())
				Tex.Text = APIS.GetLongFileName(Tex.Text)
				Enviar_Archivo(Tex.Text)

			Catch ex As Exception
				Mensaje(Idi("Solo archivos. No pase carpetas") & DMScr(2) & ex.Message & EsIngles())
			End Try
		End If
	End Sub

	Private Sub CtrlPegarArchivos_DragOver(sender As Object, e As DragEventArgs) Handles MyBase.DragOver
		e.Effect = DragDropEffects.Copy

	End Sub

	Private Sub Refrescar_Iconos()
		Try
			For Each ro As DataGridViewRow In Grd.Grid.Rows
				ro.Cells("icono").Value = Ponga_Icono(ro.Cells("archivo").Value)

				'ro.Cells("size").Value = Devolver_Tamaño(ValD(ro.Cells("tamano").Value))
			Next

		Catch
		End Try

	End Sub
	Private Sub Esconder_PicLogo(Esconder As Boolean)
		If Esconder Then
			PicLogo.Location = New Point(2, 0)
			PicLogo.Size = New Point(28, 22)
			PicLogo.Anchor = AnchorStyles.Left + AnchorStyles.Top
		Else
			PicLogo.Location = Grd.Location
			PicLogo.Size = Grd.Size
			PicLogo.Anchor = Grd.Anchor
		End If
		PicLogo.BringToFront()

	End Sub
	Public Sub Mostrar_Archivos(Dt As DataTable)
		If Dt.Columns.Count = 0 Then
			Exit Sub
		End If

		Grd.Visible = True
		ChkHeaders.Visible = True
		Grd.Grid.ColumnHeadersVisible = True
		Esconder_PicLogo(True)

		Grd.Grid.RowTemplate.Height = 35

		Dim apl As String = "aplicacion" 'truco para ver si la esconde
		If DMSAplicacion = "*" Then
			apl = ""
		End If
		Grd.DMSLlene_Grid(Dt, "id", ColOcultas:=New Object() {"programa", "tamano", "file_size", "size2", apl, "posicion", "pos2", "clave"})
		'Grd.DMSQuitarSort()

		'para cuando es llamado desde el chat
		If Me.Visible = False Then
			Exit Sub
		End If
		'/para cuando es llamado desde el chat


		Refrescar_Iconos()


		Try
			Grd.Grid.ColumnHeadersVisible = ChkHeaders.Checked 'no quitar
			Grd.Grid.BackgroundColor = Color.White
			Grd.Grid.CellBorderStyle = DataGridViewCellBorderStyle.None
			Grd.Grid.Columns("icono").Width = 30
			'Grd.Grid.Columns("icono").HeaderText = "Tipo"
			Grd.Grid.Columns("icono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Grd.Grid.Columns("icono").AutoSizeMode = DataGridViewAutoSizeColumnMode.None

			Grd.Grid.Columns("contiene").Width = IIf(Grd.Width > 130, 130, Grd.Width)
			Grd.Grid.Columns("contiene").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

			Grd.Grid.Columns("archivo").Width = 120
			Grd.Grid.Columns("archivo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

			'Grd.Grid.Columns("archivo").Visible = False
			'Grd.Grid.Columns("archivo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

			Grd.Grid.Columns("size kb").Width = 80
			Grd.Grid.Columns("size kb").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Grd.Grid.Columns("size kb").AutoSizeMode = DataGridViewAutoSizeColumnMode.None

			Grd.Grid.Columns("size2").Width = 80
			Grd.Grid.Columns("size2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Grd.Grid.Columns("size2").AutoSizeMode = DataGridViewAutoSizeColumnMode.None

			Grd.Grid.Columns("aplicacion").Width = 80
			Grd.Grid.Columns("aplicacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Grd.Grid.Columns("aplicacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.None

			Grd.Grid.Columns("fecha").Width = 100
			Grd.Grid.Columns("fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Grd.Grid.Columns("fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.None

			Grd.Grid.Columns("subido x").Width = 70
			Grd.Grid.Columns("subido x").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

			Grd.Grid.Columns("id").Width = 60
			Grd.Grid.Columns("id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Grd.Grid.Columns("id").AutoSizeMode = DataGridViewAutoSizeColumnMode.None

			Grd.Grid.ColumnHeadersVisible = ChkHeaders.Checked 'deben quedar ambos
		Catch ex As Exception

		End Try

		Grd.Grid.ClearSelection()

		If Grd.Grid.Rows.Count = 0 Then
			Grd.Visible = False
			ChkHeaders.Visible = False
			Esconder_PicLogo(False)
		End If

	End Sub

	Public Sub Grd_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles Grd.DMSTraerValor
		'If Not Hay_DMSAplicacion() Then
		'    Exit Sub
		'End If
		If Falta_Licencia("1006", True) Then
			Exit Sub
		End If

		Dim NomSin As String = Tm(Grd.Grid, "archivo") & ".dms.zip"
		Dim Nom As String = Path_Temp & ValorColDevolver & "_" & NomSin
		Dim Destino As String = Path_Temp & Tm(Grd.Grid, "archivo")

		Dim AplicacionTemp As String = Tm(Grd.Grid, "aplicacion")
		If AplicacionTemp = "" Then
			AplicacionTemp = DMSAplicacion
		End If

		Progreso("Descargando:" & DMScr() & Tm(Grd.Grid, "archivo") & DMScr() & Tm(Grd.Grid, "size kb") & " KB" & DMScr(2) & Idi("Favor esperar..."))

		If ValorColDevolver <= 0 Then 'es nuevo
			If Not IO.File.Exists(Destino) Then 'ver si existe el descomprimido
				Desempaquetar(Path_Temp, Path_Temp & NomSin)
			End If
			GoTo Abrir_Arch
		End If



		'si ya está, no volver a bajarlo
		If IO.File.Exists(Nom) Then 'si existe el zip es por que es unico
			If IO.File.Exists(Destino) Then 'ver si existe el descomprimido
				GoTo Abrir_Arch
			End If
		End If


		'recibir con ftp
		Try
			SiReloj()

			If IO.File.Exists(Nom) Then
				Try
					Kill(Nom)
				Catch ex As Exception
				End Try
			End If

Repita:
			Dim FileOrigen As String = MarcaExterna & "_" & AplicacionTemp & "_" & ValorColDevolver & "_" & NomSin
			Try
				My.Computer.Network.DownloadFile(RutaFTP & "/" & FileOrigen, Nom, TxtUsuarioFTP, TxtClaveFTP, False, 5000, True) ', True, 50000, True)

			Catch ex As Exception
				Progreso(ex.Message)
				If ex.Message.Contains("(550)") Then
					MostrarError(Me.Name, DMScr() & "Advance-Files: Bajando", "No existe el directorio de FTP o Archivo:" & DMScr(2) & "Directorio:" & DMScr() & RutaFTP & DMScr() & "Archivo:" & DMScr() & FileOrigen & DMScr(2) & "Informe a su administrador")
				Else
					If Pregunte("Desea reintentar?" & DMScr(2) & ex.Message & EsIngles(), "Error bajando archivo") Then
						GoTo Repita
					End If
				End If

				Progreso("")
				NoReloj()
				Exit Sub

			End Try

			Desempaquetar(Path_Temp, Nom)

			NoReloj()

		Catch ex As Exception
			Progreso("")
			NoReloj()
			MostrarError(Me.Name, "Grd_DMSTraerValor", ex.Message)
			Exit Sub
		End Try

Abrir_Arch:
		'dejar auditoria, solo si existe ya 
		If ValorColDevolver > 0 Then
			Try
				SiReloj()
				Ejecutar_Nodo_Otro(ArmeSQL("exec PutArchivosAplicacionLog",
											Usuario, qqNum,
											ValorColDevolver, qqNum,
											2, qqNum), Convierta_IP(MarcaExterna))

				NoReloj()

			Catch ex As Exception
				NoReloj()
				MostrarError(Me.Name, "", ex.Message)
				'que siga de todas formas
			End Try
		End If
		'/dejar auditoria, solo si existe ya 


		'-----------------------------------------------------------------------------
		If Sender Is Nothing Then 'significa guardar como
			Guardar_Como(Destino)
		Else
			AbrirArchivo(Destino)
		End If
		'-----------------------------------------------------------------------------

		Progreso("")


	End Sub
	Private Sub Guardar_Como(ByVal ArchivoGuardar)
		Try


			SaveFileDialog1.FileName = ArchivoSinPath(ArchivoGuardar)
			If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
				FileCopy(ArchivoGuardar, SaveFileDialog1.FileName)
				SonarWAV("OK")
			End If

		Catch ex As Exception
			Mensaje("Error: " & ex.Message & EsIngles())

		End Try

	End Sub

	Private Sub Grd_DMSTraerValorEliminar(Sender As Object, ValorColDevolver As Object, Fila As Integer) Handles Grd.DMSTraerValorEliminar
		If Not Hay_DMSAplicacion() Then
			Exit Sub
		End If

		If Not PermiteModificar Then
			Mensaje("Documento NO es modificable. No se permite eliminar archivos")

			Exit Sub
		End If

		Try
			Grd.Grid.ColumnHeadersVisible = True

			If ValorColDevolver > 0 Then 'no es nuevo
				'verificar permisos
				Dim archi As String = "" & Obtenga_Dato(Grd.DMSDevolverDt, "id=" & ValorColDevolver, "archivo")
				If Permi_3001 <> -1 Then
					If NoPuede4(DMSNumeroPrograma, Permi_3001, , True, "Archivo: " & archi) Then
						Exit Sub
					End If
				End If

				LstDel.Items.Add(ValorColDevolver)
				LstDelArch.Items.Add(archi)
				TocoAlgo = True
			End If

			If Fila >= 0 Then 'no lo haga cuando está actualizando el archivo para evitar que el 0215 actualice automáticamente
				RaiseEvent DMSModificoArchivos(ValorColDevolver, Tm(Grd.Grid, "archivo"))
			End If

			'nueva y mejor forma de borrar
			Dim dt As DataTable = Filtrar_DataTable(Grd.DMSDevolverDt, "id<>" & ValorColDevolver)
			Mostrar_Archivos(dt)

			Grd.Grid.ClearSelection()




		Catch ex As Exception
			MostrarError(Me.Name, "Grd_DMSTraerValorEliminar", ex.Message)

		End Try


	End Sub

	Public Function HagaSQL(NombreId As String) As String
		If Not Hay_DMSAplicacion() Then
			Return ""
		End If
		If Not TocoAlgo Then
			Return ""
		End If

		'solo para que no grabe
		If Falta_Licencia("1006", True) Then
			'para limpiarlo
			'Dim dt As DataTable = Grd.DMSDevolverDt
			'dt.Rows.Clear()
			'Grd.Grid.DataSource = dt
			TocoAlgo = False
			Return ""
		End If

		Dim Tex As String = ""

		'los de borrar
		For I As Integer = 0 To LstDel.Items.Count - 1
			Tex &= ArmeSQL("Exec PutArchivosAplicacion",
			   Numero_Empresa, qqNum,
			   Usuario, qqNum,
			   DMSAplicacion, qqTex,
			   DMSNumeroPrograma, qqNum,
			   NombreId, qqCon,
			   "", qqTex,
			   ValD(LstDel.Items(I).ToString) * -1, qqNum)
		Next

		'los nuevos
		Dim Letras As String = "abcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()_-+=abc"

		For Each Fi As DataRow In Filtrar_DataTable(Grd.DMSDevolverDt, "id<=0", "id desc").Rows
			Rnd()
			Dim clave As String = ""
			Try
				For I As Integer = 1 To 6
					Dim num As Short = (Rnd(1) * 100) / 2
					clave &= Strings.Mid(Letras, num, 1)
				Next

			Catch ex As Exception
				clave = "abcdef"
			End Try

			Tex &= ArmeSQL("Exec PutArchivosAplicacion",
						   Numero_Empresa, qqNum,
						   Usuario, qqNum,
						   DMSAplicacion, qqTex,
						   DMSNumeroPrograma, qqNum,
						   NombreId, qqCon,
						   Fi("archivo"), qqTex,
						   Fi("tamano"), qqNum,
						   Fi("contiene"), qqTex,
						   Fi("file_size"), qqNum,
						   Fi("posicion"), qqNum,
						   clave, qqTex
						   )
		Next


		Return Tex & DMScr()


	End Function

	Public Function HagaSQL_Borrar_Todo(NombreId As String) As String
		If Not Hay_DMSAplicacion() Then
			Return ""
		End If

		Dim dt As New DataTable
		Try
			Abrir_Nodo_Otro(dt, ArmeSQL("GetArchivosAplicacion",
										DMSAplicacion, qqTex,
										NombreId, qqTex),
										Convierta_IP(MarcaExterna)) 'dumy

		Catch ex As Exception
			Return ""
		End Try

		Dim Tex As String = ""

		LstDel.Items.Clear()
		LstDelArch.Items.Clear()

		'los viejos solo pa borrarlos
		For Each Fi As DataRow In dt.Rows
			Tex &= ArmeSQL("Exec PutArchivosAplicacion",
						   Numero_Empresa, qqNum,
						   Usuario, qqNum,
						   DMSAplicacion, qqTex,
						   DMSNumeroPrograma, qqNum,
						   NombreId, qqCon,
						   "", qqTex,
						   Fi("id") * -1, qqNum)

			LstDel.Items.Add(Fi("id"))
			LstDelArch.Items.Add(Fi("archivo"))

		Next

		'toca borrar el ftp de una vez
		If Tex <> "" Then
			TocoAlgo = True
			Subir_Archivos(NombreId, True)
		End If


		Return Tex & DMScr()


	End Function

	Private Function Hay_DMSAplicacion() As Boolean
		If DMSAplicacion = "*" Then  'para salida diferente
			Mensaje("Operación no válida sobre estos datos")
			Return False
		End If
		If DMSAplicacion = "" Then
			Mensaje("Informe a DMS que debe definir DMSAplicacion en el Load de su programa")
			Return False
		Else
			Return True
		End If


	End Function

	Private Sub PicLogo_Click(sender As Object, e As EventArgs) Handles PicLogo.Click

		LnkAdicionar_LinkClicked(LnkAdicionar, Nothing)

	End Sub


	Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
		TextoProgreso = Idi("Iniciando digitalización...")

		Try
			Dim CualID As Long = e.Argument(0)
			Dim SoloBorrar As Boolean = e.Argument(1)
			Dim TotalBytes As Long = e.Argument(2)

			If SoloBorrar Then
				GoTo Borrado
			End If

			'ahra ver cules son los que vamos a subir
			Dim DTF As DataTable = Filtrar_DataTable(Grd.DMSDevolverDt, "id<=0", "id desc")
			If Fin(DTF) Then
				GoTo Borrado
			End If


			'primero leer los ids que quedaron en archivo_aplicacion
			Dim DtIds As New DataTable
			Abrir_Nodo_Otro(DtIds, ArmeSQL("exec GetArchivosAplicacion",
								 DMSAplicacion, qqTex,
								 CualID, qqNum
								 ), Convierta_IP(MarcaExterna)
							 )



			'estadisticas
			'Dim TiempoTotal As String = "Sin estimar"
			'Dim BytesPorSegundo As Double = ValD(GetSetting("DMS S.A.", "estadis", "subir", 0))
			'Try
			'    If BytesPorSegundo > 0 Then
			'        Dim TotalBytes As Long = 0
			'        For Each Fi As DataRow In DTF.Rows
			'            TotalBytes += Fi("tamano")
			'        Next
			'        Dim Segundos As Long = TotalBytes / BytesPorSegundo
			'        Dim NuevaHora As DateTime = DateAdd(DateInterval.Second, Segundos, Now)
			'        TiempoTotal = HaceCuantoTiempo(Now, NuevaHora)
			'    End If
			'Catch ex As Exception
			'    TiempoTotal = "err estimando"
			'End Try
			'TiempoTotal &= ", inicia: " & Strings.Format(Now, "HH:mm:ss")
			'/estadisticas
			Dim Hacer_estadistica As Boolean = True
			Dim Ini As DateTime = Now
			Dim TotalSubido As Long = 0
			Dim Conta As Integer = 0
			For Each Fi As DataRow In DTF.Rows
				Dim NumeroID As Integer = ValD(Obtenga_Dato(DtIds, "archivo='" & Fi("archivo") & "'", "id"))
				If NumeroID = 0 Then
					Mensaje(Idi("No encontré el archivo a subir") & ": " & Fi("archivo"))
					Continue For
				End If
				Dim Archivo_Real As String = Fi("archivo") & ".dms.zip"
				Dim ArchivoGuardar As String = MarcaExterna & "_" & DMSAplicacion & "_" & NumeroID & "_" & Archivo_Real



				Conta += 1
				TotalSubido += ValD(Fi("tamano"))
				TextoProgreso = Idi("Digitalizando") & " " & Conta & " / " & DTF.Rows.Count & DMScr() & Fi("archivo") & DMScr() & Fi("size kb") & " KB"

Reintentar1:
				Try
					My.Computer.Network.UploadFile(Path_Temp & Archivo_Real, RutaFTP & "/" & ArchivoGuardar, TxtUsuarioFTP, TxtClaveFTP, False, 5000)

					'mandar mensaje a JD
					If Not EvitarMensaje Then
						Try
							Ejecutar_Nodo_Otro(ArmeSQL("exec PutMensajeSubioFile", IIf(MarcaExterna = "col", Usuario, 1), qqNum, ArchivoGuardar.Replace(".dms.zip", ""), qqTex, Fi("size kb"), qqNum, Usuario, qqNum, MiNombre, qqTex, RutaFTP, qqTex), Convierta_IP("col"))
						Catch
						End Try
					End If
					'/mandar mensaje a JD

				Catch ex As Exception
					Hacer_estadistica = False
					fEs.Timer1.Stop()

					If ex.Message.Contains("(550)") Then
						Ejecutar_Nodo_Otro("update archivos_aplicacion set anulado=1 where id=" & NumeroID, Convierta_IP(MarcaExterna))
						MostrarError(Me.Name, DMScr() & "Advance-Files: Subiendo", "No existe el directorio de FTP:" & DMScr(2) & RutaFTP & DMScr(2) & "Informe a su administrador")
					Else
						If Pregunte("Desea reintentar?" & DMScr(2) & ex.Message & EsIngles(), "Error subiendo archivo") Then
							fEs.Timer1.Start()
							GoTo Reintentar1
						Else
							'borrar el archivo
							Try
								Ejecutar_Nodo_Otro("update archivos_aplicacion set anulado=1 where id=" & NumeroID, Convierta_IP(MarcaExterna))
							Catch
							End Try
							fEs.Timer1.Start()
						End If

					End If

				End Try
			Next
			'producir estádistica
			Try
				If TotalSubido > 5000 And Hacer_estadistica Then
					Dim BytesPorSegundo As Integer = Math.Round(TotalSubido / DateDiff(DateInterval.Second, Ini, Now), 0)
					SaveSetting("DMS S.A.", "estadis", "subir", BytesPorSegundo)
				End If
			Catch ex As Exception
			End Try


Borrado:
			'borrar del ftp
			If LstDel.Items.Count > 0 Then
				Dim Origen As String = "c:\smd_files\vacio.txt"
				If Not IO.File.Exists(Origen) Then
					Dim file As System.IO.StreamWriter
					file = My.Computer.FileSystem.OpenTextFileWriter(Origen, True)
					file.Close()
				End If
				For I As Integer = 0 To LstDel.Items.Count - 1
					Dim Archivo_Real As String = LstDelArch.Items(I).ToString
					Dim ArchivoGuardar As String = MarcaExterna & "_" & DMSAplicacion & "_" & LstDel.Items(I).ToString & "_" & Archivo_Real & ".dms.zip"
					TextoProgreso = "Borrando:" & DMScr() & Archivo_Real
					'Reintentar:
					Try
						My.Computer.Network.UploadFile(Origen, RutaFTP & "/" & ArchivoGuardar, TxtUsuarioFTP, TxtClaveFTP, False, 5000)
					Catch ex As Exception
						'If Pregunte("Desea reintentar?" & DMScr(2) & ex.Message & EsIngles, "Error subiendo archivo") Then
						'    GoTo Reintentar
						'End If
					End Try
				Next
			End If
			'Progreso("")

			TextoProgreso = "Fin"

			NoReloj()

		Catch ex As Exception
			'Progreso("")
			NoReloj()
			TextoProgreso = ex.Message
			MostrarError(Me.Name, "Subir_Archivos", ex.Message)

		End Try


	End Sub

	Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
		'Progreso("")
		If TextoProgreso = "Fin" Then
			SonarWAV("laser")
		End If
		fEs.Close()

	End Sub

	Private Sub ChkHeaders_CheckedChanged(sender As Object, e As EventArgs) Handles ChkHeaders.CheckedChanged
		Grd.Grid.ColumnHeadersVisible = ChkHeaders.Checked 'no quitar

		Grd.Grid.Columns("size2").Visible = ChkHeaders.Checked
	End Sub

	Private Sub Grd_DMSOrdenarColumna(Sender As Object, e As EventArgs) Handles Grd.DMSOrdenarColumna
		Refrescar_Iconos()

	End Sub


	'Private Sub LnkAdicionar_MouseDown(sender As Object, e As MouseEventArgs) Handles LnkAdicionar.MouseDown
	'    If e.Button = Forms.MouseButtons.Right Then
	'        Cancelar = True
	'        If Grd.Grid.Columns("size2").Visible Then
	'            Grd.Grid.Columns("size2").Visible = False
	'        Else
	'            Grd.Grid.Columns("size2").Visible = True
	'        End If

	'    End If
	'End Sub

	Private Sub Grd_DMSTraerValorOtro(Sender As Object, ValorColDevolver As Object) Handles Grd.DMSTraerValorOtro
		'Mensaje("ver lo g de " & ValorColDevolver)
		If ValorColDevolver <= 0 Then
			Mensaje("Primero debe actualizar")
			Exit Sub
		End If

		Ventana(ArmeSQL("GetArchivosAplicacionLog",
							0, qqNum,
							0, qqNum,
							"2015/12/31", qqFec,
							"2015/12/31", qqFec,
							ValorColDevolver, qqNum),
						"Log de archivo", True)


	End Sub
	Private Sub Grd_DMSTraerValorOtro2(Sender As Object, ValorColDevolver As Object) Handles Grd.DMSTraerValorOtro2
		If ValorColDevolver <= 0 Then
			Mensaje("Primero debe actualizar")
			Exit Sub
		End If

		Cargar_Usuarios()

		Dim Usu As String = PidaUsuarios("Seleccione Usuario que desea enviarle el archivo.", "", "", "", 0, Filtrar_DataTable(DtUsu, "tipo=2 and id<>" & Usuario), False, False, False)
		If Usu = "" Or Usu = "0" Then
			Mensaje("No seleccionó ningun usuario")
			Exit Sub
		End If

		Dim Coment As String = Inputbox2("Comentario para enviar con el archivo (ingrese -1 para cancelar)?", "Comentario opcional")
		If Coment = "-1" Then
			Exit Sub
		End If
		If Coment <> "" Then
			Coment = DMScr(2) & Coment & DMScr()
		End If

		Try
			SiReloj()

			Dim Clave As String = "" & Tm(Grd.Grid, "clave")

			Dim Texto As String = "Advance-Files: " & Coment & DMScr() & "   - Nombre: " & Tm(Grd.Grid, "archivo") & DMScr() & "   - Tamaño: " & Tm(Grd.Grid, "tamano") & " KB" & DMScr() & "   - www.smd.fi" & Clave ' ValorColDevolver
			Dim Sql As String = ""
			Dim Datos() As String = Usu.Split(",")
			For I As Integer = 0 To Datos.Length - 1
				Sql &= ArmeSQL("Exec PutMensajes", Usuario, qqNum, Datos(I), qqNum, Texto, qqTex)
			Next
			Ejecutar(Sql)

			NoReloj()
			SonarWAV("OK")

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "Grd_DMSTraerValorOtro2", ex.Message)

		End Try


    End Sub

    Private Sub Grd_DMSTraerValorOtro3(Sender As Object, ValorColDevolver As Object) Handles Grd.DMSTraerValorOtro3
        RaiseEvent DMSMoverArchivo(ValD(ValorColDevolver))

    End Sub

    Private Sub Grd_DMSTraerValorOtro0(Sender As Object, ValorColDevolver As Object) Handles Grd.DMSTraerValorOtro0
        Grd_DMSTraerValor(Nothing, ValorColDevolver)

    End Sub
End Class
