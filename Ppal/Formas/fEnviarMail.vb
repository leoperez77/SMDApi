' Version: 694, 28-sep.-2018 12:57
' Version: 691, 17-sep.-2018 20:53
' Version: 684, 24-ago.-2018 16:56
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 678, 16-ago.-2018 14:15
'♥ versión: 586, 6-oct.-2017 07:11
Imports System.Net.Mail

Public Class fEnviarMail
	Public EnvioPorgramado As Boolean = False
	Public NumeroEmp As Integer = 0
	Public IdUsu As Integer = 0
	Public IdCli As Integer = 0
	Public IdCon As Integer = 0
	Public IdOpo As Integer = 0
	Public IdTabla As Integer = 0

	Private Sub fEnviarMail_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Guardar()

	End Sub

	Private Sub fEnviarMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Dim Masivo As Boolean = False
		If IdTabla < 0 Then
			Masivo = True
			If IdTabla <> -10 Then 'para dejarlo compatible con algo viejo
				IdTabla = Math.Abs(IdTabla)
			End If
		End If


		'traer settings
		LblErr.Location = TxtMensaje.Location
		LblErr.Size = TxtMensaje.Size

		Leer()

		'If Numero_Empresa = 1 And TxtServer.Text = "" Then
		'    TxtServer.Text = "mail.dms.com.co"
		'End If


		NoReloj(Me)

		If Masivo Then 'salga de una
			DebugJD("fEnviarMail_Load: entrando a eviar")
			CmdEnviar_Click(CmdEnviar, New EventArgs)
			Me.Close()
			Exit Sub
		End If

	End Sub
	Private Sub Guardar()
		Try
			SaveSett(Me.Name, "server", TxtServer.Text)
			SaveSett(Me.Name, "requiere", IIf(ChkRequiereAutenticacion.Checked, 1, 0))
			SaveSett(Me.Name, "mimail", TxtMiMail.Text)
			SaveSett(Me.Name, "demail", TxtDeMail.Text)
			SaveSett(Me.Name, "demailn", TxtDeNombre.Text)
			SaveSett(Me.Name, "guardarclave", IIf(ChkRecordar.Checked, 1, 0))
			SaveSett(Me.Name, "clave", TxtClave.Text)
			SaveSett(Me.Name, "puerto", TxtPuerto.Text)
			SaveSett(Me.Name, "ssl", IIf(ChkSsl.Checked, 1, 0))

		Catch ex As Exception

		End Try

	End Sub
	Private Sub Leer()
		Try
			TxtServer.Text = GetSett(Me.Name, "server", "")
			ChkRequiereAutenticacion.Checked = IIf(GetSett(Me.Name, "requiere", "0") = "0", False, True)
			TxtMiMail.Text = GetSett(Me.Name, "mimail", "")
			TxtDeMail.Text = GetSett(Me.Name, "demail", TxtDeMail.Tag)
			TxtDeNombre.Text = GetSett(Me.Name, "demailn", TxtDeNombre.Tag)
			ChkRecordar.Checked = IIf(GetSett(Me.Name, "guardarclave", "0") = "0", False, True)
			If ChkRecordar.Checked Then
				TxtClave.Text = GetSett(Me.Name, "clave", "")
			End If
			TxtPuerto.Text = GetSett(Me.Name, "puerto", "25")
			ChkSsl.Checked = IIf(GetSett(Me.Name, "ssl", "0") = "0", False, True)

		Catch ex As Exception

		End Try

	End Sub
	Private Sub CmdEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEnviar.Click


		Try
			If TxtServer.Text.Trim = "" Then
				Mensaje("Ingrese servidor de salida en pestaña Opciones")
				Exit Sub
			End If
			'otras validaciones
			If TxtDeMail.Text.Trim = "" Then
				Mensaje("Debe ingrersar su dirección de correo electrónico primero")
				TabControl1.SelectedTab = TabPage1
				TxtDeMail.Focus()
				'Me.TopMost = False
				'TxtDeMail.Text = InputBox2("Ingrese su correo electrónico")
				'If TxtDeMail.Text.Trim = "" Then Exit Sub
				Exit Sub
			End If
			If TxtParaMail.Text.Trim = "" Then
				Mensaje("Ingrese email de destinatario")
				Exit Sub
			End If
			If TxtAsunto.Text.Trim = "" Then
				Mensaje("Ingrese asunto")
				Exit Sub
			End If
			If ChkRequiereAutenticacion.Checked Then
				If TxtMiMail.Text.Trim = "" Then
					Mensaje("Ingrese nombre de cuenta en pestaña Opciones")
					Exit Sub
				End If
				If TxtPuerto.Text.Trim = "" Then
					Mensaje("Ingrese Puerto en pestaña Opciones")
					Exit Sub
				End If
			End If

			'If Usuario = 99 Then 'usuario automatico
			'    TxtMensaje.Text += DMScr(2) & "Favor NO responder este correo"
			'End If

			'después de validar guardar setting
			Guardar()

			CmdEnviar.Enabled = False
			LblErr.Text = "Enviando..."
			LblErr.Visible = True
			'Me.WindowState = FormWindowState.Minimized


			EnviarCorreo()


		Catch ex As Exception
			Mensaje("No se pudo enviar el correo:" & DMScr(2) & ex.ToString)

		End Try

	End Sub

	Private Sub ChkRequiereAutenticacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkRequiereAutenticacion.CheckedChanged
		GrpSesion.Enabled = ChkRequiereAutenticacion.Checked

	End Sub

	Private Sub Ver_Archivo()


		Try
			Me.TopMost = False
			Ejecute_Proceso(LnkVer.Tag.ToString)

		Catch ex As Exception
			Mensaje("No se pudo abrir el archivo: " & DMScr(2) & LnkVer.Tag.ToString & DMScr(2) & ex.Message & EsIngles())

		End Try

	End Sub

	Public Sub EnviarCorreo()
		If EnvioPorgramado Then
			Leer()
			TxtAsunto.Text = GetSett("fProgramador", "asunto", "")
		End If

		DebugJD("...enviando")
		Try
			LblErr.Visible = True
			LblErr.Text = "Enviando correo..."
			SiReloj(Me)


			Dim _Message As New System.Net.Mail.MailMessage()
			Dim _SMTP As New SmtpClient
			'si requiere autenticación
			If ChkRequiereAutenticacion.Checked Then
				_SMTP.Credentials = New System.Net.NetworkCredential(TxtMiMail.Text, TxtClave.Text)
				_SMTP.Host = TxtServer.Text
				_SMTP.Port = TxtPuerto.Text ' 587
				_SMTP.EnableSsl = ChkSsl.Checked
			Else 'si no requiere ELSE
				_SMTP.Host = TxtServer.Text
			End If

			' CONFIGURACION DEL MENSAJE
			'para
			Dim Correos As String() = TxtParaMail.Text.Trim.Split(";")
			For I = 0 To Correos.Length - 1
				If Correos(I).Trim.Length > 3 Then 'para asegurarse que venga un correo
					Dim a As New System.Net.Mail.MailAddress(Correos(I).Trim)
					_Message.[To].Add(a.Address.Trim) 'Cuenta de Correo al que se le quiere enviar el e-mail
				End If
			Next
			'copia
			Correos = TxtCC.Text.Trim.Split(";")
			If TxtCC.Text.Trim <> "" Then
				For I = 0 To Correos.Length - 1
					Dim a As New System.Net.Mail.MailAddress(Correos(I).Trim)
					_Message.CC.Add(a.Address.Trim) 'Cuenta de Correo al que se le quiere enviar el e-mail
				Next
			End If
			'copia oculta
			Correos = TxtCCo.Text.Trim.Split(";")
			If TxtCCo.Text.Trim <> "" Then
				For I = 0 To Correos.Length - 1
					Dim a As New System.Net.Mail.MailAddress(Correos(I).Trim)
					_Message.Bcc.Add(a.Address.Trim) 'Cuenta de Correo al que se le quiere enviar el e-mail
				Next
			End If
			' CONFIGURACION DEL MENSAJE
			_Message.From = New System.Net.Mail.MailAddress(TxtDeMail.Text, TxtDeNombre.Text, System.Text.Encoding.UTF8) 'Quien lo envía
			'_Message.From = New System.Net.Mail.MailAddress(TxtDeMail.Text, IIf(TxtDeNombre.Text <> TxtDeNombre.Tag, TxtDeNombre.Tag & " (" & TxtDeNombre.Text & ")", TxtDeNombre.Text), System.Text.Encoding.UTF8) 'Quien lo envía
			_Message.Subject = TxtAsunto.Text
			_Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
			_Message.Body = TxtMensaje.Text
			_Message.BodyEncoding = System.Text.Encoding.UTF8
			_Message.Priority = System.Net.Mail.MailPriority.High
			_Message.IsBodyHtml = False

			' ADICION DE DATOS ADJUNTOS
			If LnkVer.Tag.ToString <> "" Then
				Dim _Attachment As New System.Net.Mail.Attachment(LnkVer.Tag.ToString, System.Net.Mime.MediaTypeNames.Application.Octet)
				_Message.Attachments.Add(_Attachment)
			End If

			'ENVIO
			Try
				_SMTP.Send(_Message)

				'registrar el evento: si da error, ignorarlo
				Try
					If NumeroEmp > 0 And IdUsu > 0 And IdCli > 0 Then 'asegurarnos que si vengan datos para grabar evento de CRM
						'no cambiar la palabra "Envió" pues es fundamental para que el programa muestre el tipo de evento
						Dim Asuntico As String = "Envió de " & TxtDeNombre.Text & " (" & TxtDeMail.Text & "), para " & TxtParaNombre.Text & " (" & TxtParaMail.Text & "): " & TxtAsunto.Text
						Ejecutar("PutCotEventos4 " & NumeroEmp.ToString & "," & IdUsu.ToString & ",0,'" & Asuntico & "','" & FmtFecSQL("1950/12/31") & "',0," & IdCli.ToString & ",0," & IdCon.ToString & "," & IdOpo.ToString & ",0,0")
					End If
				Catch ex As Exception
				End Try
				CmdEnviar.Tag = ""

			Catch ex As System.Net.Mail.SmtpException
				CmdEnviar.Tag = ex.Message
				If EnvioPorgramado Then
					SaveSett("fProgramador", "error", ex.Message) 'por si acaso
				End If
			End Try

		Catch ex As Exception
			CmdEnviar.Tag = ex.Message
			LblErr.BackColor = Color.Red
			DebugJD("...enviando error: " & ex.Message & EsIngles())
			If EnvioPorgramado Then
				SaveSett("fProgramador", "error", ex.Message) 'por si acaso
			End If
		End Try

		NoReloj(Me)



		If CmdEnviar.Tag = "" Then 'terminó bien
			DebugJD("Terminó bien el envío")
			'dejar auditoría
			If IdTabla > 0 And IdOpo > 0 Then
				Dim fFi As New fBatch
				fFi.Auditoria_Imprimio(IdTabla, "eMail", IdOpo)
				fFi.Dispose()
			ElseIf Usuario = 99 Then 'dejar auditoria de usuario 99 evio email
				Dim fFi As New fBatch
				fFi.Auditoria_Imprimio(101, TxtParaMail.Text & ": " & TxtAsunto.Text, 0)
				fFi.Dispose()
			End If

			SonarWAV("ok")
			Me.Close()
			Exit Sub
		End If

		Try
			SonarWAV("error")
			'Mensaje("No se pudo enviar el correo para " & TxtParaNombre.Text & " por esta razón:" & DMScr(2) & CmdEnviar.Tag.ToString)
			LblErr.Text = CmdEnviar.Tag.ToString
			LblErr.Visible = True
			CmdEnviar.Enabled = True
			'Me.WindowState = FormWindowState.Normal

		Catch ex As Exception
			If EnvioPorgramado Then
				SaveSett("fProgramador", "error", ex.Message) 'por si acaso
			Else
				Mensaje(ex.Message & EsIngles())
			End If
			Me.Close()

		End Try


	End Sub


	Private Sub LnkVer_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkVer.LinkClicked
		If LnkVer.Tag.ToString = "" Then
			Mensaje("No hay archivo Adjunto")
			Exit Sub
		End If

		Ver_Archivo()

	End Sub

	Private Sub LblErr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblErr.Click
		LblErr.Visible = False

	End Sub

	Private Function BusqueMail()
		Try
			Me.TopMost = False

			Dim Criterio As String = Inputbox2("Escriba parte del nombre a buscar:")
			If Criterio = "" Then
				Return ""
			End If

			SiReloj()

			Dim Dt As New DataTable
			Abrir(Dt, "exec GetBuscarMail " & Numero_Empresa.ToString & ",'" & Criterio & "'")

			NoReloj()

			If Fin(Dt) Then
				Mensaje("No encontró resultados")
				Return ""
			End If

			Return Ventana(Dt, "Resultados de " & Criterio, , "email")


		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "CmdPara_Click", ex.Message)
			Return ""

		End Try

	End Function
	Private Sub CmdPara_Click(sender As System.Object, e As System.EventArgs) Handles CmdPara.Click
		Encuentre(TxtParaMail)

	End Sub

	Private Sub CmdCc_Click(sender As System.Object, e As System.EventArgs) Handles CmdCc.Click
		Encuentre(TxtCC)

	End Sub

	Private Sub CmdCco_Click(sender As System.Object, e As System.EventArgs) Handles CmdCco.Click
		Encuentre(TxtCCo)

	End Sub
	Private Sub Encuentre(Txt As TextBox)
		Dim Result = BusqueMail()
		If Result <> "" Then
			Txt.Text = Result
		End If

	End Sub

	Private Sub LnkChat_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkChat.LinkClicked
		Dim Archivo As String = LnkVer.Tag.ToString
		Try
			Me.TopMost = False
			If Not ValidarLic() Then Exit Sub

			Dim Usu As String = PidaUsuarios("Seleccione Usuario que desea enviarle el archivo.", "", "", "", 0, Filtrar_DataTable(DtUsu, "tipo=2 and id<>" & Usuario), , , True)
			If ValD(Usu) = 0 Then
				Mensaje("No seleccionó ningun usuario")
				Exit Sub
			End If

			Dim TexM As String = Strings.Left(Inputbox2("Texto a enviar en el chat (opcional)?", "Texto opcional", TxtAsunto.Text), 300)

			If Not Pregunte("Seguro de enviar este archivo a " & Obtenga_Dato(DtUsu, "id=" & Usu, "nombre") & "?" & DMScr(2) & TexM) Then
				Exit Sub
			End If


			Dim fFe As New fUsuarios
			fFe.BackgroundWorker1.RunWorkerAsync(New Object() {Usu, Archivo, New DataGridView, TexM, True})


			SonarWAV("ok")

			Me.Close()

		Catch ex As Exception
			MostrarError(Me.Name, "CmdEnviarUsuario_Click", ex.Message)
		End Try


	End Sub

	Public Sub Enviar_Chat_Programado()
		Dim paso As String = "1"
		Dim Archivo As String = LnkVer.Tag.ToString

		Dim Ch() As String = GetSett("fProgramador", "para_chat", "").ToString.Split(",")

		Dim DirectorioActual As String = My.Computer.FileSystem.CurrentDirectory

		TxtAsunto.Text = GetSett("fProgramador", "asunto", "")

		Try

			For Each QueUsu As String In Ch
				If QueUsu = "" Then
					Continue For
				End If

				Dim Dt As New DataTable

				paso = "2"


				paso = "3"

				Dim Tamaño As Integer = My.Computer.FileSystem.GetFileInfo(Archivo).Length


				Abrir(Dt, "PutDatosArchivo2 " & Numero_Empresa.ToString & "," & Usuario.ToString & "," & QueUsu & ",'" & IO.Path.GetFileName(Archivo) & "'," & Tamaño.ToString)

				paso = "4"

				Dim NumeroID As Integer = ValD("" & Gdf(Dt, "ultimo"))

				My.Computer.FileSystem.CurrentDirectory = RutaDelArchivo(Archivo)


				paso = "5"

				GrabarArchivoBD(IO.Path.GetFileName(Archivo), "archivos", NumeroID)

				Mensajeria_DMS(ValD(QueUsu), vbNewLine & TxtAsunto.Text & DMScr(2) & "   - Nombre: " & IO.Path.GetFileName(Archivo) & DMScr() & "   - Tamaño: " & Tamaño & " bytes" & DMScr() & "   - www.smd.ar" & NumeroID.ToString & "-" & Tamaño & DMScr(), Usuario)

				If SiMedirConsumo Then
					Grabar_Consumo(Tamaño)
				End If

				paso = "6"
			Next




		Catch ex As Exception
			'Mensaje_TopMost("Operación falló paso: " & paso & ", " & ex.Message & EsIngles(), , , True)

		End Try

		My.Computer.FileSystem.CurrentDirectory = DirectorioActual

	End Sub


End Class