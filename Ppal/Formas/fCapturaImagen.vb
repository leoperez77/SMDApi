' Version: 684, 24-ago.-2018 16:56
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
'♥ versión: 586, 6-oct.-2017 07:11
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing
Imports System.Math
Public Class fCapturaImagen
    ' Declaraciones del API para 32 bits
    Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" _
        (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" _
        (ByVal hwnd As Integer, ByVal nIndex As Integer, _
         ByVal dwNewLong As Integer) As Integer
    Private Declare Function SetWindowPos Lib "user32" _
        (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, _
         ByVal X As Integer, ByVal Y As Integer, _
         ByVal cX As Integer, ByVal cY As Integer, _
         ByVal wFlags As Integer) As Integer
    '
    ' Constantes para usar con el API
    Const GWL_STYLE As Integer = (-16)
    Const WS_THICKFRAME As Integer = &H40000 ' Con borde redimensionable
    '
    Const SWP_DRAWFRAME As Integer = &H20
    Const SWP_NOMOVE As Integer = &H2
    Const SWP_NOSIZE As Integer = &H1
    Const SWP_NOZORDER As Integer = &H4
    Dim EstaOK As Boolean = False
    Public TamañoMaximo As Integer = 50000
    Public Alto_y_Ancho As Integer = 700

    Public NombreTabla As String
    Public RecId As Integer

    Dim SourceToImage As Bitmap
    Dim theFile As FileInfo
 

    Private DX, DY As Integer
    Private DX1, DY1 As Integer
    Dim TamanoOriginal As Point
    Dim Centro As Point

    Public Sub CmdAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAbrir.Click

        Try
            Dim FileName As String
            Dim result As DialogResult
            If CmdAbrir.Tag <> "" Then
                FileName = CmdAbrir.Tag
            Else
                'no ponemos PNG porque se ven mal
                result = OpenFileDialog1.ShowDialog()
                If (result <> DialogResult.OK) Then
                    Me.Hide()
                    Exit Sub
                End If
                FileName = OpenFileDialog1.FileName
            End If




            PictureBox1.Image = Nothing
            PictureBox3.Image = Nothing
            PictureBox1.Visible = True
            PictureBox3.Visible = False

            'Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            'Me.ActiveForm.SuspendLayout()


            'Generar un bitmap para el origen
            Dim SourceImage As Bitmap
            SourceImage = New Bitmap(FileName)

            ' Generar un bitmap para el resultado
            SourceToImage = New Bitmap(SourceImage.Width, SourceImage.Height)

            ' Generar un objeto Gráfico para el Bitmap resultante
            Dim gr_source As Graphics = Graphics.FromImage(SourceToImage)

            ' Copiar la imagen origen al Bitmap destino
            gr_source.DrawImage(SourceImage, 0, 0, _
                SourceToImage.Width, _
                SourceToImage.Height)

            'Muestra imagen origen
            PictureBox1.Image = CType(SourceToImage, Image)

            'Liberar recursos
            gr_source.Dispose()
            SourceImage.Dispose()

            Dim myFile As New FileInfo(FileName)

            Dim DetalleOrigen As String = ""
            DetalleOrigen = "Imagen " & SourceToImage.Width
            DetalleOrigen = DetalleOrigen & "x" & SourceToImage.Height & " px"
            DetalleOrigen = DetalleOrigen & ", Tamaño: " & CInt(myFile.Length / 1024).ToString & " kb"
            Label3.Text = DetalleOrigen


            CmdSalvar.Enabled = True
            CmdSalvar_Click(CmdSalvar, New System.EventArgs)


        Catch ex As Exception
			MsgBox("Error abriendo imagen: " & ex.Message & EsIngles())

		End Try


	End Sub

	Private Sub fCapturaImagen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Try
			If Not EstaOK Then
				If Dir("temp.jpg", FileAttribute.Archive) <> "" Then
					Kill("temp.jpg")
				End If
			End If

		Catch ex As Exception

		End Try
	End Sub

	Private Sub fCapturaImagen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		If SoyHandHeld() Then
			Me.FormBorderStyle = Forms.FormBorderStyle.FixedToolWindow
			Me.WindowState = FormWindowState.Maximized
		End If

		Label3.Text = ""
		CmdCancelar.Left = -5000
		TamanoOriginal = PictureBox1.Size
		Centro = Panel1.Size
		TrackBar1.Value = TrackBar1.Maximum / 4
		CambiarEstilo(PictureBox1)
		PictureBox1.Anchor = AnchorStyles.Left + AnchorStyles.Top
	End Sub

	Private Sub ObtenerResultado(ByVal Porcentaje As Short)
		Dim scale_factor As Single = 1
		If Alto_y_Ancho = 10001 Then 'truco jd para no tocar la imagen
			GoTo Saltar
		End If

		Dim NeedsHorizontalCrop As Boolean = True
		Dim NeedsVerticalCrop As Boolean = False

		'Determina si la imagen es Landscape o Portrait
		If SourceToImage.Height > SourceToImage.Width Then
			NeedsHorizontalCrop = False
			NeedsVerticalCrop = True
		End If

		'Determina si la imagen excede el ancho del PictureBox
		If SourceToImage.Width < Alto_y_Ancho Then
			NeedsHorizontalCrop = False
			If SourceToImage.Height > Alto_y_Ancho Then
				NeedsVerticalCrop = True
			End If
		End If

		'Calcula el Factor de Ajuste
		If SourceToImage.Width > 0 Then
			If NeedsHorizontalCrop = True Then
				' Obtiene el Factor de Ajuste
				scale_factor = Alto_y_Ancho / SourceToImage.Width
			End If
		End If

		If SourceToImage.Height > 0 Then
			If NeedsVerticalCrop = True Then
				' Obtiene el Factor de Ajuste
				scale_factor = Alto_y_Ancho / SourceToImage.Height
			End If
		End If

Saltar:
		' Generar un bitmap tmp para el resultado. Ajuste Proporcional
		Dim DestTmpImage As New Bitmap(
			CInt(SourceToImage.Width * scale_factor),
			CInt(SourceToImage.Height * scale_factor))

		' Generar un objeto Gráfico para el bitmap tmp resultante
		Dim gr_desttmp As Graphics = Graphics.FromImage(DestTmpImage)

		' Copiar la imagen origen al bitmap tmp destino
		gr_desttmp.DrawImage(SourceToImage, 0, 0,
			DestTmpImage.Width,
			DestTmpImage.Height)

		'Comprime y Guarda un Archivo Temporal para calcular su peso en Kb
		Try
			'fCapturarImagenB.SaveJPGWithCompressionSetting(DestTmpImage, "temp.jpg", Porcentaje) 'TrackBar1.Value)
			SaveJPGWithCompressionSetting(DestTmpImage, "temp.jpg", Porcentaje) 'TrackBar1.Value)
		Catch exc As Exception
			Mensaje("Error en imagen: " & exc.Message)

		End Try

		'PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage

		'La lectura del nuevo archivo no se puede hacer en forma directa y repetitiva
		'ya que está bloqueado por GDI+ la 1era vez que se lo utiliza,
		'por lo tanto resulta necesario resolver en varios pasos. 
		'Al efectuar el Dispose() se libera el recurso

		Dim DestImage As Bitmap

		DestImage = New Bitmap("temp.jpg")

		' Generar un bitmap para el resultado
		Dim DestToImage As New Bitmap(DestImage.Width, DestImage.Height)

		' Generar un objeto Grafico para el bitmap resultante
		Dim gr_dest As Graphics = Graphics.FromImage(DestToImage)

		' Copiar la imagen origen al bitmap destino
		gr_dest.DrawImage(DestImage, 0, 0,
			DestToImage.Width,
			DestToImage.Height)

		'Muestra imagen comprimida
		PictureBox3.Image = CType(DestToImage, Image)

		'Liberar recursos
		gr_dest.Dispose()
		DestImage.Dispose()

		'Dim theFile As New FileInfo("temp.jpg")
		theFile = New FileInfo("temp.jpg")


		'Dim DetalleDestino As String = ""
		'DetalleDestino = ""
		'DetalleDestino = "Ancho=" & DestTmpImage.Width & " px"
		'DetalleDestino = DetalleDestino & " - Alto=" & DestTmpImage.Height & " px"
		'DetalleDestino = DetalleDestino & vbCrLf & "(" & theFile.Length & " bytes)"
		'Label3.Text = DetalleDestino

		'PictureBox2.Visible = True


		gr_desttmp.Dispose()

		'BtnSave.Enabled = True

	End Sub

	Private Sub CmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalvar.Click
		Try
			SiReloj()


			For i As Integer = 100 To 1 Step -5
				ObtenerResultado(i)
				If theFile.Length <= TamañoMaximo Then 'si es mas de 50 mil bajarlo
					Debug.Print("Tamaño: " & theFile.Length.ToString)
					EstaOK = True
					Exit For
				End If
			Next

			If EstaOK Then 'si es mas de 50 mil bajarlo
				GrabarImagen("temp.jpg", NombreTabla, RecId)
			Else
				MsgBox("La imagen es muy grande, al comprimirla queda de " & theFile.Length & ". Para este caso SMD permite máximo " & TamañoMaximo.ToString & ". Achique la imagen original e intente de nuevo")
			End If
			NoReloj()

			Me.Hide()

		Catch ex As Exception
			NoReloj()

			Mensaje("No se pudo actualizar imagen: " & ex.Message & EsIngles())
			Me.Dispose()

		End Try

	End Sub

	Private Sub GrabarImagen(ByVal strFileName As String, ByVal Tabla As String, ByVal Id As Integer)
		Try
			Reloj(True)
			Dim fs As FileStream = File.Open(strFileName, FileMode.Open, FileAccess.Read)
			Dim inByte(fs.Length) As Byte
			fs.Read(inByte, 0, inByte.Length)
			fs.Close()

			'Mensaje("Grabando en: " & Ws.Url)

			'DemeNodo()

			If EstoyDesconectadoNuevo Then
				Desconectado.SaveImage(Tabla, Id, inByte)
			Else
				Ws.ConvertImage(inByte, 6, strFileName, Tabla, Id)
			End If



			'Mensaje("Grabé en: " & Ws.Url)

			Reloj(False)
		Catch ex As Exception
			Mensaje("No se pudo grabar imagen: " & ex.Message & EsIngles())
			Reloj(False)


        End Try

    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.Close()

    End Sub

    'Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    '    If PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage Then
    '        PictureBox1.SizeMode = PictureBoxSizeMode.Normal
    '    Else
    '        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    '    End If

    '    PictureBox1.Refresh()


    'End Sub
 
    Private Sub TrackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged
 
        If TrackBar1.Value = TrackBar1.Minimum Or TrackBar1.Value = TrackBar1.Maximum Or TrackBar1.Value = TrackBar1.Maximum / 4 Then Exit Sub
        CambiarEstilo(PictureBox1)
        Dim tamano As Point = PictureBox1.Size
        Dim X As Integer = (((TrackBar1.Value - 50) * TamanoOriginal.X) / 40) + TamanoOriginal.X
        Dim Y As Integer = (((TrackBar1.Value - 50) * TamanoOriginal.Y) / 40) + TamanoOriginal.Y
        tamano.X = X
        tamano.Y = Y
        PictureBox1.Size = tamano
        CambiarEstilo(PictureBox1)


        PictureBox1.Left = (Centro.X / 2) - (tamano.X / 2)
        PictureBox1.Top = (Centro.Y / 2) - (tamano.Y / 2)
    End Sub
    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        DX = e.X
        DY = e.Y
        If e.Button = MouseButtons.Left Then
            If CType(sender, Control).Tag < 0 Then
                Exit Sub
            Else
                'CType(sender, Control).BringToFront()
            End If
        Else

        End If
    End Sub

    'Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
    '    If e.Button = MouseButtons.Left Then

    '        If CType(sender, Control).Cursor = Cursors.SizeWE Then
    '            DX1 = e.X

    '        Else
    '            If e.X + CType(sender, Control).Left - DX > 0 Then
    '                CType(sender, Control).Left = e.X + CType(sender, Control).Left - DX
    '            Else
    '                CType(sender, Control).Left = 0
    '            End If

    '            If e.Y + CType(sender, Control).Top - DY > 0 Then
    '                CType(sender, Control).Top = e.Y + CType(sender, Control).Top - DY
    '            Else
    '                CType(sender, Control).Top = 0
    '            End If
    '        End If

    '    End If
    'End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = MouseButtons.Left Then
            PictureBox1.Anchor = AnchorStyles.Left + AnchorStyles.Top
            If CType(sender, Control).Cursor = Cursors.SizeWE Then
                DX1 = e.X

            Else
                If e.X + CType(sender, Control).Left + CType(sender, Control).Size.Width - DX > 0 Then
                    CType(sender, Control).Left = e.X + CType(sender, Control).Left - DX
                Else
                    CType(sender, Control).Left = 0
                End If

                If e.Y + CType(sender, Control).Top + CType(sender, Control).Size.Height - DY > 0 Then
                    CType(sender, Control).Top = e.Y + CType(sender, Control).Top - DY
                Else
                    CType(sender, Control).Top = 0
                End If

            End If

        End If
    End Sub

    Private Sub CambiarEstilo(ByVal aControl As Control)

        Dim Style As Integer

        Try
            Style = GetWindowLong(aControl.Handle.ToInt32, GWL_STYLE)
            If (Style And WS_THICKFRAME) = WS_THICKFRAME Then
                Style = Style Xor WS_THICKFRAME
            Else
                Style = Style Or WS_THICKFRAME
            End If
            SetWindowLong(aControl.Handle.ToInt32, GWL_STYLE, Style)
            SetWindowPos(aControl.Handle.ToInt32, Me.Handle.ToInt32, 0, 0, 0, 0, SWP_NOZORDER Or SWP_NOSIZE Or SWP_NOMOVE Or SWP_DRAWFRAME)
        Catch e As Exception

        End Try
    End Sub

 

 
    Private Sub PictureBox1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Resize
        'Dim puntos As Point = PictureBox1.Size
        'If puntos.X < PictureBox1.MinimumSize.Height Then
        '    puntos.X = PictureBox1.MinimumSize.Height
        'End If
        'If puntos.Y < PictureBox1.MinimumSize.Width Then
        '    puntos.Y = PictureBox1.MinimumSize.Width
        'End If
        'PictureBox1.Size = puntos
    End Sub
 
    Private Sub Panel1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.Resize
        Centro = Panel1.Size
        TrackBar1_ValueChanged(TrackBar1, New EventArgs)
    End Sub


    Public Shared Function GetEncoderInfo(ByVal mimeType As String) As ImageCodecInfo
        Dim j As Integer
        Dim encoders As ImageCodecInfo()
        encoders = ImageCodecInfo.GetImageEncoders()
        For j = 0 To encoders.Length
            If encoders(j).MimeType = mimeType Then
                Return encoders(j)
            End If
        Next j
        Return Nothing
    End Function

    Public Shared Sub SaveJPGWithCompressionSetting(ByVal image As Image, ByVal szFileName As String, ByVal lCompression As Long)
        Dim eps As EncoderParameters = New EncoderParameters(1)
        eps.Param(0) = New EncoderParameter(Encoder.Quality, lCompression)
        Dim ici As ImageCodecInfo = GetEncoderInfo("image/jpeg")
        Try
            image.Save(szFileName, ici, eps)
        Catch exc As Exception
            MsgBox("error en SaveJPGWithCompressionSetting: " & exc.Message)
        End Try
    End Sub


End Class