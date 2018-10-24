' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
Public Module ModuloPadre
    Public fAdvOpc As fAdvanceOpciones
    Public fDpAdv As fDatosPantallazo
    'Public fAdvNewOpc As fDatosPantallazo

    Public UbiLogo As String
	Public AdvFormaActiva As AdvanceForm

	'Public UsarLogoSobrepuesto As Boolean = False

	'Public Function FormaYaEstaAbierta2(ByRef Formas As FormCollection, _icono As Icon, ByVal NombreForma As String, ByVal TagForma As String) As Boolean
	'    Dim I As Integer

	'    For I = Formas.Count - 1 To 0 Step -1
	'        If LCase(Formas.Item(I).Name) = "°" & LCase(NombreForma) Then
	'            Dim Este
	'            If Formas.Item(I).Tag Is Nothing Then
	'                Este = ""
	'            Else
	'                Este = Formas.Item(I).Tag.ToString
	'            End If
	'            If Este = TagForma Then
	'                MostrarForma2(Formas, _icono, Formas.Item(I))
	'                Return True
	'            End If
	'        End If
	'    Next I

	'    Return False

	'End Function
	Public Function FormaYaEstaAbierta3(ByRef Formas As FormCollection, Icono As Icon, ByVal NombreForma As String, ByVal TagForma As String) As Boolean
		If Formas Is Nothing Then
			Return False
		End If
		If Formas.Count = 0 Then
			Return False
		End If

		Dim I As Integer

        For I = Formas.Count - 1 To 0 Step -1
            'If LCase(Formas.Item(I).Name) = "°" & LCase(NombreForma) Then
            If LCase(Formas.Item(I).Name) = LCase(NombreForma) Then
                Dim Este
                If Formas.Item(I).Tag Is Nothing Then
                    Este = ""
                Else
                    Este = Formas.Item(I).Tag.ToString
                End If
                If Este = TagForma Then
                    If Formas.Item(I).Name <> "fRecordatorio" Then 'los recordatorios del menú no se vuelven a levantar
                        MostrarForma3(Icono, Formas.Item(I))
                    End If
                    Return True
                End If
            End If
        Next I

        Return False

    End Function
	Public Sub Abrir_Punto_Advance(Optional FormaLlamadora As AdvanceForm = Nothing, Optional Pto As String = "1")
		SaveSetting("DMS S.A.", "syscom", "ptoadv", 0)


		If FormaLlamadora IsNot Nothing Then
			AdvFormaActiva = FormaLlamadora
		End If

		If AdvFormaActiva Is Nothing Then
			Exit Sub
		End If

		'If AdvFormaActiva.Name = "fMenu" Then
		'    MsgBox("soy menu")
		'End If

		'If Pto = "2" Then 'para que lo oculte: funcionamiento: pasa el mouse por encima del punto advance=muestra fAdvOpc, haga clic en el punto Advance=manda 2 a este programa y oculta las opciones y pone el foco
		'    Try
		'        fAdvOpc.Hide()
		'        'AdvFormaActiva.Show()
		'    Catch
		'    End Try
		'    Exit Sub
		'End If


		Try
			If fAdvOpc.Visible Then 'para sacarlo
				'SendKeys.Send("%{TAB}")
				fAdvOpc.Hide()
				AdvFormaActiva.Activate()
				Exit Sub
			End If
		Catch
		End Try


		Try
			If AdvFormaActiva.Modal = True Then
				AdvFormaActiva.BringToFront()
			Else
				If AdvFormaActiva.WindowState = FormWindowState.Minimized Then
					AdvFormaActiva.WindowState = FormWindowState.Normal
				End If
				'AdvFormaActiva.Show()
				'AdvFormaActiva.BringToFront()
				'AdvFormaActiva.Activate()
				AdvFormaActiva.TopMost = True
				HagaEventos()
				AdvFormaActiva.TopMost = False
			End If
		Catch
		End Try


		If fAdvOpc Is Nothing Then
			fAdvOpc = New fAdvanceOpciones
		End If

		Try
			If FormaLlamadora.Name = "fMenu" Or FormaLlamadora.Name = "fChat" Then
				fAdvOpc.CmdObjetos.Enabled = False
			Else
				'aqui viene el prefijo para la personalización de las ventas
				fAdvOpc.CmdObjetos.Tag = AdvFormaActiva.PicPuntoAdv.Tag.ToString
				fAdvOpc.CmdObjetos.Enabled = True
			End If

		Catch
		End Try



		Dim Ajuste As Integer = 0 'ajuste para posición
		If AdvFormaActiva.WindowState = FormWindowState.Maximized Then
			Ajuste = 10
		End If


		If UbiLogo = "0" Then
			fAdvOpc.Top = AdvFormaActiva.Top + AdvFormaActiva.Height - fAdvOpc.Height - Ajuste
			fAdvOpc.Left = AdvFormaActiva.Left + Ajuste
		Else
			fAdvOpc.Top = AdvFormaActiva.Top + Ajuste
			fAdvOpc.Left = AdvFormaActiva.Left + AdvFormaActiva.Width - fAdvOpc.Width - Ajuste
		End If




		'fAdvOpc.Location = AdvFormaActiva.Location
		'fAdvOpc.Left += 10
		'fAdvOpc.Top += 10
		'fAdvOpc.LnkCambiar.Visible = False

		fAdvOpc.fOrig = AdvFormaActiva

		fAdvOpc.LblTitulo.Text = AdvFormaActiva.Text


		Try
			If AdvFormaActiva.Modal = True Then
				AdvFormaActiva.TopMost = False
				fAdvOpc.TopMost = True
				fAdvOpc.ShowDialog()
			Else
				AdvFormaActiva.TopMost = False
				fAdvOpc.Show()
				fAdvOpc.TopMost = True

			End If


		Catch ex As Exception

			MsgBox("Esta opción no se puede llamar en este momento", MsgBoxStyle.Information)
		End Try
	End Sub

	'Public Sub MostrarForma2(ByRef Formas As FormCollection,
	'                        _icono As Icon,
	'                        ByRef Forma As Form,
	'                        Optional ByVal TipoDialogo As Boolean = False,
	'                        Optional ByVal TituloPrograma As String = "",
	'                        Optional MostrarIcono As Boolean = True)
	'    Try
	'        Dim frm As fPadre

	'        If Forma.Name.Contains("°") Then
	'            frm = Forma
	'            Forma = frm.MdiChildren(0)
	'        Else
	'            'DebugJD("forma_name=" & Forma.Name)
	'            If Not EstaEnLista(Forma.Name, "fCotiza", "fCompra", "fOrden") Then
	'                If FormaYaEstaAbierta3(Formas, _icono, Forma.Name, Forma.Tag) Then
	'                    NoReloj()
	'                    Exit Sub
	'                End If
	'            End If
	'            frm = New fPadre
	'            'frm.lblTitulo.BackColor = Color.Red
	'            frm.Name = "°" & Forma.Name
	'            If TypeOf Forma Is fHijo Then
	'                frm.FormBorderStyle = DirectCast(Forma, fHijo).FormBorderStyle
	'            Else
	'                frm.FormBorderStyle = Forma.FormBorderStyle
	'            End If

	'            Forma.FormBorderStyle = Windows.Forms.FormBorderStyle.None
	'            Dim _si As Size = Forma.Size
	'            Forma.MdiParent = frm

	'            'frm.StartPosition = Forma.StartPosition
	'            frm.MinimizeBox = Forma.MinimizeBox
	'            frm.MinimumSize = Forma.MinimumSize
	'            frm.MaximumSize = Forma.MaximumSize
	'            frm.MaximizeBox = Forma.MaximizeBox
	'            frm.Tag = Forma.Tag 'prueba jd
	'            frm.Size = _si

	'            frm.Panel1.Visible = True
	'        End If

	'        If TipoDialogo Then
	'            Forma.ShowDialog()
	'            Exit Sub
	'        End If

	'        frm.StartPosition = Forma.StartPosition

	'        If Forma.Name <> "fMenu" Then
	'            frm.Show()
	'            HagaEventos()
	'        End If


	'        'If ComparaIconos(Forma.Icon.ToBitmap, fBusIt.Icon.ToBitmap) Then
	'        If Forma.Icon Is fBusIt.Icon Then
	'            frm.Icono.Image = _icono.ToBitmap
	'            frm.Icon = _icono
	'        Else
	'            frm.Icono.Image = Forma.Icon.ToBitmap
	'            frm.Icon = Forma.Icon
	'        End If
	'        If Not MostrarIcono Then
	'            frm.Icono.Visible = False
	'            frm.lblTitulo.Left = frm.Icono.Left
	'        End If
	'        frm.Text = Forma.Text
	'        If frm.WindowState = FormWindowState.Minimized Then
	'            frm.WindowState = FormWindowState.Normal
	'        End If

	'        frm.BringToFront()

	'        frm.Focus()

	'        If TituloPrograma <> "" Then
	'            Forma.Text = TituloForma(TituloPrograma, Forma)
	'            frm.lblTitulo.Tag = Forma.Text
	'        End If
	'        frm.Icono.Tag = TituloForma("-1", Forma)
	'        If SoyHandHeld() Then
	'            frm.WindowState = FormWindowState.Maximized
	'        End If


	'        If Forma.Name <> "fMenu" Then
	'            Forma.Show()
	'        End If
	'        Forma.ControlBox = False
	'        Forma.ShowInTaskbar = False
	'        Forma.Dock = DockStyle.Fill
	'        If Forma.Name <> "fMenu" Then
	'            Forma.Select()
	'        Else
	'            'JD: pongo este por que en el menú se queda pegado
	'            frm.cmdCerrar.Enabled = False
	'        End If

	'        frm.Panel1.Visible = False
	'        'JD: pongo este por que en el menú se queda pegado

	'    Catch ex As Exception
	'        'se quita este mensaje pues es muy molesto y pasa mucho
	'        'MostrarError(Forma.Name, "MostrarForma2", ex.Message & EsIngles)

	'    End Try


	'End Sub

	'Private Function ComparaIconos(bm1 As Bitmap, bm2 As Bitmap) As Boolean

	'    ' Make a difference image.
	'    Dim wid As Integer = Math.Min(bm1.Width, bm2.Width)
	'    Dim hgt As Integer = Math.Min(bm1.Height, bm2.Height)
	'    Dim bm3 As New Bitmap(wid, hgt)

	'    ' Create the difference image.
	'    Dim are_identical As Boolean = True
	'    Dim eq_color As Color = Color.White
	'    Dim ne_color As Color = Color.Red
	'    For x As Integer = 0 To wid - 1
	'        For y As Integer = 0 To hgt - 1
	'            If bm1.GetPixel(x, y).Equals(bm2.GetPixel(x, _
	'                y)) Then
	'                bm3.SetPixel(x, y, eq_color)
	'            Else
	'                bm3.SetPixel(x, y, ne_color)
	'                are_identical = False
	'            End If
	'        Next y
	'    Next x

	'    If (bm1.Width <> bm2.Width) OrElse (bm1.Height <> bm2.Height) Then are_identical = False

	'    bm1.Dispose()
	'    bm2.Dispose()

	'    Return are_identical
	'End Function

End Module
