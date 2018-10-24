' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 678, 16-ago.-2018 14:15
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fWeb

 

    Private Sub fWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Me.Top = 0
		Me.Height = Screen.PrimaryScreen.WorkingArea.Height - 30

        Asignar_Logo(PictureBox1, PictureBox1)

    End Sub

	Private Sub LnkChat_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkChat.LinkClicked

		If sender.tag = "" Then
			Mensaje("Este documento no tiene hipervínculo para enviar por chat. Consulte con DMS")
			Exit Sub
		End If

		Dim Texto As String = "Favor observar este tema de la documentación de Advance: " & DMScr() & "www.smd.da" & LnkChat.Tag ' ValorColDevolver
		Clipboard.SetText(Texto)

		Mensaje("Abra el chat a quien desea enviarlo y pegue con Ctrl-V." & DMScr(2) & "Texto copiado en el portapapeles:" & DMScr(2) & Texto)


		'Mensaje(sender.tag)

		'Cargar_Usuarios()

		'Dim Usu As String = PidaUsuarios("Seleccione Usuario(s) para enviar link.", "", "", "", 0, Filtrar_DataTable(DtUsu, "tipo=2 and id<>" & Usuario), False, False, False)
		'If Usu = "" Or Usu = "0" Then
		'	Mensaje("No seleccionó ningun usuario")
		'	Exit Sub
		'End If

		'Dim Coment As String = InputBox2("Comentario para enviar con el link (ingrese -1 para cancelar)?", "Comentario opcional", Me.Text)
		'If Coment = "-1" Then
		'	Exit Sub
		'End If
		'If Coment <> "" Then
		'	Coment = DMScr(2) & Coment & DMScr()
		'End If

		'Try
		'SiReloj()

		'Dim Texto As String = "Documentación Advance: " & Coment & DMScr(2) & "   - www.smd.da" & LnkChat.Tag ' ValorColDevolver
		'Dim Sql As String = ""
		'Dim Datos() As String = Usu.Split(",")
		'For I As Integer = 0 To Datos.Length - 1
		'	Sql &= ArmeSQL("Exec PutMensajes", Usuario, qqNum, Datos(I), qqNum, Texto, qqTex)
		'Next
		'Ejecutar(Sql)

		'NoReloj()
		'SonarWAV("OK")

		'Catch ex As Exception
		'	NoReloj()
		'	MostrarError(Me.Name, "Grd_DMSTraerValorOtro2", ex.Message & EsIngles)

		'End Try



	End Sub



	'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
	'    SendKeys.Send("^+F")

	'End Sub

	'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
	'    WebBrowser1.Focus()
	'    SendKeys.Send("^F")

	'    SonarWAV("OK")

	'End Sub
End Class