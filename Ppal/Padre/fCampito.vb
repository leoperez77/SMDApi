' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 678, 16-ago.-2018 14:15
' Version: 675, 14-ago.-2018 18:45
'♥ versión: 588, 12-oct.-2017 17:24
'♥ versión: 586, 6-oct.-2017 07:11
'♥ versión: 586, 5-oct.-2017 21:44
Public Class fCampito
	Public FiOrig As DataRow

	Public IdProg As Integer
	Public Prefijo As String
	Dim Cargando As Boolean = True

	Dim Font_Name As String = "-2"
	Dim Font_Bold As Short = -2
	Dim Font_Size As Double = -2
	Dim Font_Italic As Short = -2

	Private Sub fCampito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_Idioma(Me, Me)

		Cargando = True

	End Sub
	Private Sub fCampito_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		Cargando = False

	End Sub

	Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click
		Me.Tag = 0
		Me.Close()

	End Sub

	'Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles CmdActualizar.Click
	'	If NoPuede4("0280", 100) Then
	'		Exit Sub
	'	End If

	'	If TxtTitulo.Text = TxtTitulo.Tag Then
	'		Mensaje("No ha hecho cambios")
	'		Exit Sub
	'	End If

	'	'Dim Nuevo As String
	'	'Nuevo = InputBox2("Ingrese nuevo texto personal (-1 para borrar el texto):", "Cambiar texto", TxtTitulo.Text)
	'	'If Nuevo = "" Then
	'	'	Exit Sub
	'	'End If
	'	'If ValD(Nuevo) = -1 Then
	'	'	TxtTitulo.Text = ""
	'	'Else
	'	'	TxtTitulo.Text = Nuevo
	'	'End If

	'	'If TxtTitulo.Text = "" Then
	'	'	Mensaje("Si no desea texto, mejor usar la opción Ocultar")
	'	'	Exit Sub
	'	'End If

	'	Dim Dt As New DataTable


	'	Try
	'		SiReloj()
	'		Abrir(Dt, ArmeSQL("exec PutProgramasTitUno",
	'						 Numero_Empresa.ToString, qqNum,
	'						 Usuario, qqNum,
	'						 IdProg, qqNum,
	'						 Me.Tag, qqTex,
	'						 TxtTitulo.Text, qqTex,
	'						 Prefijo, qqTex,
	'						 LblAnt.Text, qqTex
	'						)
	'				)

	'		SonarWAV("OK")
	'		NoReloj()

	'	Catch ex As Exception
	'		NoReloj()
	'		MostrarError(Me.Name, "CmdOk_Click", ex.Message & EsIngles)
	'		Exit Sub
	'	End Try


	'	DtRetorno = Dt

	'	Me.Close()

	'End Sub


	'Private Sub CmdActuOcultar_Click(sender As Object, e As EventArgs) Handles CmdActuOcultar.Click
	'	If NoPuede4("0280", 100) Then
	'		Exit Sub
	'	End If



	'	Dim Dt As New DataTable

	'	Try
	'		SiReloj()
	'		Abrir(Dt, ArmeSQL("exec PutProgramasTitUnoOcultar",
	'						 Numero_Empresa.ToString, qqNum,
	'						 Usuario, qqNum,
	'						 IdProg, qqNum,
	'						 Me.Tag, qqTex,
	'						 CmdActuOcultar.Tag, qqCon,
	'						 Prefijo, qqTex
	'						  )
	'						)
	'		SonarWAV("OK")
	'		NoReloj()

	'	Catch ex As Exception
	'		NoReloj()
	'		MostrarError(Me.Name, "CmdOk_Click", ex.Message & EsIngles)
	'		Exit Sub
	'	End Try


	'	DtRetorno = Dt

	'	Me.Close()

	'End Sub

	Private Sub CmdEliminarCampo_Click(sender As Object, e As EventArgs) Handles CmdEliminarCampo.Click

		Me.Tag = 2
		Me.Close()



	End Sub




	Private Sub CmdAceptar_Click(sender As Object, e As EventArgs) Handles CmdAceptar.Click
		If NoPuede4("0280", 100) Then
			Exit Sub
		End If

		If TxtTitulo.Text = TxtTitulo.Tag And
			TxtTool.Tag = TxtTool.Text And
			ChkOculto.Tag = ChkOculto.Checked And
			ChkNegrilla.Tag = ChkNegrilla.Checked And
			ValD(CmdColorLetra.Tag) = 0 And
			ValD(CmdColorFondo.Tag) = 0 And
			ValD(CmdFuente.Tag) = 0 And
			ValD(TxtPosX.Tag) = 0 And
			ValD(TxtPosY.Tag) = 0 And
			ValD(TxtTamX.Tag) = 0 And
			ValD(TxtTamY.Tag) = 0 Then
			Mensaje("No ha hecho cambios")
			Exit Sub
		End If




		'este es el mejor punto para hacerlo
		If ChkNegrilla.Tag <> ChkNegrilla.Checked Then
			Font_Bold = IIf(LblPrueba.Font.Bold, 1, 0)
		End If


		FiOrig("nuevo texto") = TxtTitulo.Text
		FiOrig("tooltip_adv") = TxtTool.Text

		If ChkOculto.Checked Then
			FiOrig("ocultar") = "Si"
		Else
			FiOrig("ocultar") = ""
		End If

		FiOrig("posX") = IIf(ValD(TxtPosX.Tag) = 1, "*", "") & ValD(TxtPosX.Text)
		FiOrig("posy") = IIf(ValD(TxtPosY.Tag) = 1, "*", "") & ValD(TxtPosY.Text)
		FiOrig("tamX") = IIf(ValD(TxtTamX.Tag) = 1, "*", "") & ValD(TxtTamX.Text)
		FiOrig("tamY") = IIf(ValD(TxtTamY.Tag) = 1, "*", "") & ValD(TxtTamY.Text)
		If ValD(CmdColorLetra.Tag) <> 0 Then
			FiOrig("fore_color") = "*" & CmdColorLetra.Tag
		End If
		If ValD(CmdColorFondo.Tag) <> 0 Then
			FiOrig("back_color") = "*" & CmdColorFondo.Tag
		End If
		If Font_Name <> "-2" Then
			FiOrig("font_name") = "*" & Font_Name
		End If
		If Font_Size <> -2 Then
			FiOrig("font_size") = "*" & Font_Size
		End If
		If Font_Bold <> -2 Then
			FiOrig("font_bold") = "*" & Font_Bold
		End If
		If Font_Italic <> -2 Then
			FiOrig("font_italic") = "*" & Font_Italic
		End If

		FiOrig("fecha_hora") = Now
		FiOrig("usuario") = "Tú"


		If FiOrig("!c") = "" Then 'si no hay color aun
			If FiOrig("!n") = "" Then 'no tenía definiciones
				FiOrig("!c") = 2 '=azul: 
			Else
				FiOrig("!c") = 3 '=verde: modificando existente
			End If
		End If

		FiOrig("!n") = 1 '=fue modificado y negrita
		FiOrig.AcceptChanges()

		Me.Tag = 1
		Me.Close()

	End Sub

	Private Sub TxtPosX_TextChanged(sender As Object, e As EventArgs) Handles TxtPosX.TextChanged, TxtPosY.TextChanged, TxtTamX.TextChanged, TxtTamY.TextChanged
		If Cargando Then Exit Sub

		sender.forecolor = Color.Red
		sender.tag = 1

	End Sub

	Private Sub LblPosX_Click(sender As Object, e As EventArgs) Handles LblPosX.Click, LblPosY.Click, LblTamX.Click, LblTamY.Click
		Dim Txt As TextBox = DirectCast(Me.Controls.Find("Txt" & Strings.Mid(sender.Name, 4), True)(0), TextBox)
		If Txt.Visible Then
			sender.tag = Txt.Text
			Txt.Text = -1
			Txt.Visible = False
			Txt.Tag = 1 'por si acaso
			SonarWAV("laser")
			'Else
			'	Txt.Text = sender.tag
			'	Txt.Visible = True
			'	Txt.Tag = "" 'para desactivar el cambio
		End If
		sender.visible = False


	End Sub

	Private Sub ChkOculto_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOculto.CheckedChanged
		If Cargando Then Exit Sub

		If ChkOculto.Checked = ChkOculto.Tag Then
			sender.forecolor = Color.Black
		Else
			sender.forecolor = Color.Red
		End If

	End Sub


	Private Sub CmdColorLetra_Click_1(sender As Object, e As EventArgs) Handles CmdColorLetra.Click
		DialogoColor.Color = LblPrueba.ForeColor
		DialogoColor.AnyColor = True
		DialogoColor.AllowFullOpen = True

		Dim r As Integer = DialogoColor.ShowDialog()
		If r = 2 Then Exit Sub


		LblPrueba.ForeColor = DialogoColor.Color
		CmdColorLetra.Tag = System.Drawing.ColorTranslator.ToOle(DialogoColor.Color)

	End Sub

	Private Sub CmdColorFondo_Click(sender As Object, e As EventArgs) Handles CmdColorFondo.Click
		DialogoColor.Color = LblPrueba.BackColor
		DialogoColor.AnyColor = True
		DialogoColor.AllowFullOpen = True

		Dim r As Integer = DialogoColor.ShowDialog()
		If r = 2 Then Exit Sub

		LblPrueba.BackColor = DialogoColor.Color
		CmdColorFondo.Tag = System.Drawing.ColorTranslator.ToOle(DialogoColor.Color)

	End Sub

	Private Sub LnkColorDefault_Click(sender As Object, e As EventArgs) Handles LnkColorDefault.Click
		CmdColorLetra.Tag = -1
		CmdColorLetra.Visible = False
		LblPrueba.ForeColor = Label2.ForeColor
		sender.visible = False

	End Sub

	Private Sub LnkColorBackDefault_Click(sender As Object, e As EventArgs) Handles LnkColorBackDefault.Click
		CmdColorFondo.Tag = -1
		CmdColorFondo.Visible = False
		LblPrueba.BackColor = Color.White
		sender.visible = False

	End Sub

	Private Sub CmdFuente_Click(sender As Object, e As EventArgs) Handles CmdFuente.Click
		DialogoFont.Font = VB6.FontChangeName(DialogoFont.Font, LblPrueba.Font.Name)
		DialogoFont.Font = VB6.FontChangeSize(DialogoFont.Font, LblPrueba.Font.SizeInPoints)
		DialogoFont.Font = VB6.FontChangeItalic(DialogoFont.Font, LblPrueba.Font.Italic)
		DialogoFont.Font = VB6.FontChangeBold(DialogoFont.Font, LblPrueba.Font.Bold)
		DialogoFont.ShowEffects = False
		Dim r As Integer = DialogoFont.ShowDialog()
		If r = 2 Then Exit Sub


		CmdFuente.Tag = 1

		If LblPrueba.Font.Name <> DialogoFont.Font.Name Then
			LblPrueba.Font = VB6.FontChangeName(LblPrueba.Font, DialogoFont.Font.Name)
			Font_Name = LblPrueba.Font.Name
		End If

		If LblPrueba.Font.Size <> DialogoFont.Font.Size Then
			LblPrueba.Font = VB6.FontChangeSize(LblPrueba.Font, DialogoFont.Font.Size)
			Font_Size = LblPrueba.Font.Size
		End If

		If LblPrueba.Font.Bold <> DialogoFont.Font.Bold Then
			'LblPrueba.Font = VB6.FontChangeBold(LblPrueba.Font, DialogoFont.Font.Bold)
			ChkNegrilla.Checked = DialogoFont.Font.Bold
			Font_Bold = IIf(LblPrueba.Font.Bold, 1, 0)
		End If

		If LblPrueba.Font.Italic <> DialogoFont.Font.Italic Then
			LblPrueba.Font = VB6.FontChangeItalic(LblPrueba.Font, DialogoFont.Font.Italic)
			Font_Italic = IIf(LblPrueba.Font.Italic, 1, 0)
		End If


	End Sub

	Private Sub LnkFuenteDefault_Click(sender As Object, e As EventArgs) Handles LnkFuenteDefault.Click
		CmdFuente.Tag = 1

		CmdFuente.Visible = False
		LblPrueba.Font = Label2.Font
		Font_Name = "-1"
		ChkNegrilla.Visible = False
		Font_Bold = -1
		Font_Size = -1
		Font_Italic = -1
		sender.visible = False


	End Sub

	Private Sub ChkNegrilla_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNegrilla.CheckedChanged

		LblPrueba.Font = VB6.FontChangeBold(LblPrueba.Font, ChkNegrilla.Checked)

	End Sub

End Class