' Version: 694, 28-sep.-2018 12:57
' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 678, 16-ago.-2018 14:15
' Version: 675, 14-ago.-2018 18:45
' Version: 600, 27-nov.-2017 18:45
'♥ versión: 586, 6-oct.-2017 07:11
'♥ versión: 586, 5-oct.-2017 21:44
Public Class fAdvanceOpciones
	Public fOrig As AdvanceForm
	Dim fOrig2 As AdvanceForm
	Dim EsReporte As Boolean = Application.ProductName = "reportes"
	Dim DtCampos As DataTable


	Private Sub fAdvanceOpciones_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CmdLeameManual.Visible = True
        CmdReportes.Visible = True
        'CmdVideosAdv.Visible = True
        DebugJD("fOrig.Name=" & fOrig.Name)
        If fOrig.Name <> "fMenu" Then
            If Not IsNumeric(CualProg) Then
                CmdLeameManual.Visible = False
                CmdReportes.Visible = False
                'CmdVideosAdv.Visible = False
            Else
                CmdReportes.Visible = Not EsReporte
            End If
        End If
		If fOrig.Name = "fEstadistica_Armar" Then
			CmdObjetos.Visible = False
		End If


		LblNodoAdvance.Text = MarcaExterna
        If MarcaExterna = "local" Then
            LblNodoAdvance.ForeColor = Color.Cyan
        ElseIf MarcaExterna <> "col" Then
            LblNodoAdvance.ForeColor = Color.Orange
        Else
            LblNodoAdvance.ForeColor = Color.Blue
        End If

        LblEmpresa.Text = LCase(MiEmpresa)
        LblUsuAdv.Text = LCase(MiCodigo)
        LblIdUser.Text = Usuario
        LblVerAdv.Text = String_Version_Editada()
        LblPrueba.Visible = Ws.Url.Contains("_pru/")

        Me.TopMost = True

        JDMS_Timer1.Start()

    End Sub

    Private Sub fAdvanceOpciones_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        'fAdvOpc.Hide()
        Ocultar()
        'fOrig.Cambiar_Loguito()


        'Timer1.Stop()
        'ConEfectos = False
        'Me.Hide()

    End Sub
    Private Sub Ocultar()
        JDMS_Timer1.Stop()
        Me.Hide()

    End Sub
    Private Sub fAdvanceOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LblIngles.Visible = LenguajeAdvance = 1
		ToolTip1.SetToolTip(JDMS_LblCambiarLogo, Idi(ToolTip1.GetToolTip(JDMS_LblCambiarLogo), "Change position = Shift-F10"))
		ToolTip1.SetToolTip(JDMS_LblCerrar, Idi(ToolTip1.GetToolTip(JDMS_LblCerrar), "Hide"))
		CmdImprimaPant.Text = Idi(CmdImprimaPant.Text, "Prt")
		ToolTip1.SetToolTip(CmdImprimaPant, Idi(ToolTip1.GetToolTip(CmdImprimaPant), "Print screen"))
		ToolTip1.SetToolTip(CmdLeameManual, Idi(ToolTip1.GetToolTip(CmdLeameManual), "Readme and Manual"))
		ToolTip1.SetToolTip(CmdReportes, Idi(ToolTip1.GetToolTip(CmdReportes), "Reports of this program"))
		ToolTip1.SetToolTip(CmdObjetos, Idi(ToolTip1.GetToolTip(CmdObjetos), "Modify objects on the screen"))
		ToolTip1.SetToolTip(CmdMisPermisos, Idi(ToolTip1.GetToolTip(CmdMisPermisos), "My permissions"))
		CmdMisPermisos.Text = Idi(CmdMisPermisos.Text, "My")
		'CmdVideosAdv.Tag = CmdVideosAdv.Image


		'Dim objDraw As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath

		''Definimos la Elipse (con esto le damos una forma redonda al Formulario)
		'objDraw.AddEllipse(0, 0, Me.Width, Me.Height)
		'Me.Region = New Region(objDraw)

	End Sub

	Private Sub fAdvanceOpciones_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		'CmdManualAdv.Visible = True
		'CmdReportesAdv.Visible = True
		'CmdVideosAdv.Visible = True
		'DebugJD("fOrig.Name=" & fOrig.Name)
		'If fOrig.Name <> "fMenu" Then
		'    If Not IsNumeric(CualProg) Then
		'        CmdManualAdv.Visible = False
		'        CmdReportesAdv.Visible = False
		'        CmdVideosAdv.Visible = False
		'    Else
		'        CmdReportesAdv.Visible = Not EsReporte
		'    End If
		'End If


		'LblNodoAdvance.Text = MarcaExterna
		'LblEmpresa.Text = LCase(MiEmpresa)
		'LblUsuAdv.Text = LCase(MiCodigo)
		'LblIdUser.Text = Usuario
		'LblVerAdv.Text = String_Version_Editada()
		'LblPrueba.Visible = Ws.Url.Contains("_pru/")



	End Sub

	Private Sub fAdvanceOpciones_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
		If e.KeyCode = Keys.Escape Then
			e.SuppressKeyPress = True 'solo en esta tecla evitar que pase al otro programa 
			Cerrar()
		ElseIf e.KeyCode = Keys.F11 Then
			Imprimir_Pant()
		ElseIf e.KeyCode = Keys.F10 And e.Shift Then
			Cambiar_Pos()
		End If

	End Sub


	Private Sub Cerrar()
		fOrig.Activate()
		fOrig.TopMost = True

		Ocultar()

		fOrig.TopMost = False


	End Sub





	Private Sub Cambiar_Pos()
		fOrig.Cambiar_Loguito()
		Ocultar()

	End Sub
	Private Sub Imprimir_Pant()

		Dim EraTopMost As Boolean = False
		If Me.TopMost = True Then
			EraTopMost = True
			Me.TopMost = False
		End If

		If fDpAdv Is Nothing Then
			fDpAdv = New fDatosPantallazo
		End If

		fDpAdv.LblProg.Text = fOrig.Text
		fDpAdv.LblRef.Text = LblNodoAdvance.Text & "/" & LblEmpresa.Text & " " & LblVerAdv.Text
		fDpAdv.TxtExplica.Text = ""
		fDpAdv.ShowDialog()

		If ValD(fDpAdv.Tag) <> 1 Then
			Exit Sub 'cancelo
		End If

		Try

			Me.TopMost = False
			Ocultar()


			fOrig.BringToFront()
			fOrig.TopMost = True


			fOrig.PicPuntoAdv.Visible = False
			HagaEventos()

			Threading.Thread.Sleep(500)

			'HagaEventos()


			'-------------

			Dim objClipboard As IDataObject = Clipboard.GetDataObject()
			' método de IDataObject
			' devolver el portapapeles como mapa de bits

			Dim gr As Graphics = fOrig.CreateGraphics
			' Tamaño de lo que queremos copiar
			' En este caso el tamaño de la ventana principal

			Dim fSize As Size
			If fDpAdv.ChkVentanaActiva.Checked Then
				fSize = fOrig.Size
			Else
				fSize = Screen.PrimaryScreen.Bounds.Size
			End If



			' Creamos el bitmap con el área que vamos a capturar
			Dim bm As New Bitmap(fSize.Width, fSize.Height, gr)
			' Un objeto Graphics a partir del bitmap
			Dim gr2 As Graphics = Graphics.FromImage(bm)

			' Copiar todo el área de la pantalla
			If fDpAdv.ChkVentanaActiva.Checked Then
				gr2.CopyFromScreen(fOrig.Left, fOrig.Top, 0, 0, fSize)
			Else
				gr2.CopyFromScreen(0, 0, 0, 0, fSize)
			End If

			fOrig.PicPuntoAdv.Visible = True

			fOrig.TopMost = False
			If EraTopMost Then
				Me.TopMost = True
			End If

			SiReloj()

			Dim Nom As String = "ps__" & Strings.Format(Now, "yyyyMMddHHmmss") & ".jpg"
			bm.Save(Nom, System.Drawing.Imaging.ImageFormat.Jpeg)

			Try
				'definir donde grabar
				Dim Usu1 As Integer = Usuario
				Dim Nodito As String = MarcaExterna
				If fDpAdv.OptMiCuenta.Checked Then
					Usu1 = UsuarioOriginal
					Nodito = "col"
				End If

				'DebugJD("Usu orig:" & Usuario & ", nuevo:" & Usu1 & " --- Nodo orig:" & MarcaExterna & ", nuevo:" & Nodito)

				Dim Dt As New DataTable
				Abrir_Nodo_Otro(Dt, "PutPrtScrAdvance " & Usu1 & "," & IIf(fDpAdv.OptPrivada.Checked, "1", "0") & ",'" & fDpAdv.LblProg.Text.Replace("'", "''") & "','" & fDpAdv.LblRef.Text.Replace("'", "''") & "','" & fDpAdv.TxtExplica.Text.Replace("'", "''") & "'", Convierta_IP(Nodito))

				GrabarArchivoBD_Otro(Nom, "pantallazos", ValD(Gdf(Dt, "ultimo")), Convierta_IP(Nodito))

				'marcarlo como ultimo
				SaveSett("fC", "ultptadv", ValD(Gdf(Dt, "ultimo")))


				Try
					'borrar el archivo
					Kill(Nom)
				Catch ex As Exception

				End Try

				SonarWAV("ok")

			Catch ex As Exception
				NoReloj()
				MsgBox("Operación no completada:" & DMScr(2) & ex.Message & EsIngles(), MsgBoxStyle.Critical)
				Exit Sub

			End Try

			NoReloj()


		Catch ex As Exception

			NoReloj()
			MsgBox("Operación no completada:" & DMScr(2) & ex.Message & EsIngles(), MsgBoxStyle.Critical)

		End Try

		Exit Sub
	End Sub

	Private Function CualProg() As String
		Dim Prog As String = Strings.Left(fOrig.Text, 5).Trim
		If fOrig.Name = "fMenu" Then
			Prog = "0000"
		End If
		Return Prog

	End Function


	'Private Sub CmdVideosAdv_Click(sender As Object, e As EventArgs) Handles CmdVideosAdv.Click
	'    JDMS_Timer1.Stop()
	'    Me.Hide()

	'    SiReloj()

	'    Try
	'        Dim Dt As New DataTable
	'        Abrir(Dt, "Exec GetProgramaVideo2 '" & IIf(EsReporte, "-", "") & CualProg() & "'")
	'        NoReloj()

	'        If Not Fin(Dt) Then
	'            If IsDBNull(Gdf(Dt, "video")) Then
	'                MsgBox("Lo sentimos, este producto no tiene video por el momento", MsgBoxStyle.Exclamation)
	'                Exit Sub
	'            End If
	'            AbrirLink(Gdf(Dt, "video"))
	'        Else
	'            MsgBox("No hay video de este programa", MsgBoxStyle.Exclamation)
	'        End If

	'    Catch ex As Exception
	'        NoReloj()
	'        MsgBox("Operación no completada", MsgBoxStyle.Critical)

	'    End Try

	'End Sub



	'Private Sub fAdvanceOpciones_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
	'    MsgBox("MouseDown")

	'End Sub

	Private Sub JDMS_LblCerrar_Click(sender As Object, e As EventArgs) Handles JDMS_LblCerrar.Click
		Cerrar()

	End Sub

	Private Sub JDMS_LblCerrar_MouseEnter(sender As Object, e As EventArgs) Handles JDMS_LblCerrar.MouseEnter, JDMS_LblCambiarLogo.MouseEnter
		sender.forecolor = Color.Black
		sender.backcolor = Color.Red

	End Sub

	Private Sub JDMS_LblCerrar_MouseLeave(sender As Object, e As EventArgs) Handles JDMS_LblCerrar.MouseLeave, JDMS_LblCambiarLogo.MouseLeave
		sender.forecolor = Color.White
		sender.backcolor = Color.Transparent

	End Sub

	Private Sub LnkImprimaPant_MouseEnter(sender As Object, e As EventArgs)  ', CmdVideosAdv.MouseEnter
		sender.Image = sender.BackgroundImage

	End Sub

	Private Sub LnkImprimaPant_MouseLeave(sender As Object, e As EventArgs)  ', CmdVideosAdv.MouseLeave
		sender.Image = sender.Tag

	End Sub

	Private Sub fAdvanceOpciones_Click(sender As Object, e As EventArgs) Handles MyBase.Click
		Cerrar()

	End Sub

	Private Sub JDMS_Timer1_Tick(sender As Object, e As EventArgs) Handles JDMS_Timer1.Tick
		Ocultar()

	End Sub

	Private Sub JDMS_LblCambiarLogo_Click(sender As Object, e As EventArgs) Handles JDMS_LblCambiarLogo.Click
		Cambiar_Pos()

	End Sub

	Private Sub CmdObjetos_Click(sender As Object, e As EventArgs) Handles CmdObjetos.Click
		If NoPuede4("0280", 100) Then
			Exit Sub
		End If
		If ValD(CualProg()) = 0 Then
			Mensaje("No permitido en opciones del menú")
			Exit Sub
		End If



		'fMod.Height = fOrig.Height
		Dim fMod As New fModificarCampos With {
			.Icon = ConviertaIcono(fOrig.PicPuntoAdv.Image),
			.Text = Idi("Modificar objetos de") & " " & fOrig.Text,
			.Prog = CualProg(),
			.fOrig = fOrig,
			.Prefijo = CmdObjetos.Tag
		}
		'===========================================================================
		fMod.ShowDialog()
		'===========================================================================






	End Sub



	Private Sub CmdMisPermisos_Click(sender As Object, e As EventArgs) Handles CmdMisPermisos.Click
        If EsReporte Then
            Mensaje("Los reportes no tiene permisos excepto el de entrada al mismo y ud. ya lo tiene")
            Exit Sub
        End If

        Try
            SiReloj()
            Dim dt As New DataTable
            Dim prog = CualProg()
			Abrir(dt, "GetMisPermisos " & Usuario & ",'" & CualProg() & "'," & LenguajeAdvance)
			NoReloj()

            Ventana(dt, "Permisos del programa " & CualProg(), False)

        Catch ex As Exception
            NoReloj()
			MostrarError(Me.Name, "CmdMisPermisos_Click", ex.Message)
		End Try
    End Sub

    Private Sub CmdImprimaPant_Click(sender As Object, e As EventArgs) Handles CmdImprimaPant.Click
        Imprimir_Pant()

    End Sub

    Private Sub CmdLeameManual_Click(sender As Object, e As EventArgs) Handles CmdLeameManual.Click
        JDMS_Timer1.Stop()
        Me.Hide()

		'Dim que = InputBox2("1 = Ver 'léame'" & DMScr(1) & "2 = Ver manual")
		'If que <> 1 And que <> 2 Then
		'    Exit Sub
		'End If


		'If que = 1 Then
		'    NuevoLeame.Mostrar_Leame_Programa(FormasNada, CualProg(), IIf(EsReporte, 1, 0))
		'Else
		'    AbrirLink(GetSett("Ayuda", "Pagina", "") & "/" & IIf(EsReporte, "rep", "") & CualProg() & ".html")
		'End If

		NuevoLeame.Mostrar_Leame_Programa(FormasNada, CualProg(), IIf(EsReporte, 1, 0))


    End Sub

    Private Sub CmdReportes_Click(sender As Object, e As EventArgs) Handles CmdReportes.Click
        JDMS_Timer1.Stop()
        Me.Hide()

        SiReloj()

        Try
            Dim Dt As New DataTable

            Abrir(Dt, "Exec GetProgramaReportes2 '" & CualProg() & "'")

            NoReloj()

            If Fin(Dt) Then
                MsgBox("Este programa no tiene reportes asignados", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim Rep As String = Ventana(Dt, CualProg, True, "reporte", , , New Object() {"explicacion"})
            If Rep <> "" Then
                Ppal.AbrirPrograma("0401", Rep)
            End If

        Catch ex As Exception
            NoReloj()
            MsgBox("Operación no completada", MsgBoxStyle.Critical)

        End Try
    End Sub
End Class