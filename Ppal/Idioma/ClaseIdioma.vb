' Version: 695, 4-oct.-2018 12:56
' Version: 687, 5-sep.-2018 13:13
' Version: 684, 25-ago.-2018 20:17
' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 21-ago.-2018 10:37
' Version: 681, 20-ago.-2018 21:33
' Version: 681, 20-ago.-2018 20:08
Public Class ClaseIdioma


	Public Sub Recorrer_Idioma_Clase(ByVal Control1 As Object, fOrig As Object)

		If TypeOf Control1 Is Form Or
			TypeOf Control1 Is AdvanceForm Then
			Haga_MenuStrip(Control1)
		End If


		'jdms 682: esto no se hace
		'If TypeOf Control1 Is Form Then
		'	Control1.text = Idi(Control1.text)
		'End If


		'para que no lo haga dos veces: después
		'If TypeOf Control1 Is AdvanceForm Then

		'End If

		'Recorremos con un ciclo for each cada control que hay en la colección Controls
		For Each contHijo As Object In Control1.Controls
			'para pruebas de debug
			'If contHijo.name = "Label5" Then
			'	Dim jdj = 0
			'End If



			'exclusiones
			If contHijo.Name = "PicPuntoAdv" Then
				Continue For
			End If
			'exclusiones
			If TypeOf contHijo Is RichTextBox Then
				Continue For
			End If

			'no poner para que si haga los toolTipText
			'If TypeOf contHijo Is BotonActualizar Or
			'	TypeOf contHijo Is BotonEstandar Then
			'	Continue For
			'End If

			If TypeOf contHijo Is Label Or
			   TypeOf contHijo Is LinkLabel Then
				Dim Nom1 As String = contHijo.name.ToString.ToLower
				If Nom1.Contains("mail") Or
					Nom1 = "lblcargo" Or
					Nom1 = "txtmostrar" Or
					Nom1 = "lblemp" Then
					Continue For
				End If
			End If

			'If contHijo.Name = "LblFont0" Then
			'	Dim kd = 0
			'End If

			Dim TieneHijo As Boolean = False ' contHijo.HasChildren

			'If TypeOf contHijo Is MenuStrip Then
			'	Dim jjj = 0
			'End If

			If TypeOf contHijo Is Panel Or
				TypeOf contHijo Is TabControl Or
				TypeOf contHijo Is GroupBox Or
				TypeOf contHijo Is MenuStrip Or
				TypeOf contHijo Is ToolStrip Or
				TypeOf contHijo Is ToolStripContainer Or
				TypeOf contHijo Is ToolStripContentPanel Or
				TypeOf contHijo Is TableLayoutPanel Or
				TypeOf contHijo Is SplitContainer Or
				TypeOf contHijo Is SplitterPanel Then
				TieneHijo = True
			End If

			'los que no usan texto
			Dim UsaTexto As Boolean = False
			'If TypeOf contHijo Is TextBox Or
			'TypeOf contHijo Is BotonActualizar Or
			If TypeOf contHijo Is Label Or
				TypeOf contHijo Is LinkLabel Or
				TypeOf contHijo Is GroupBox Or
				TypeOf contHijo Is Button Or
				TypeOf contHijo Is BotonEstandar Or
				TypeOf contHijo Is RadioButton Or
				TypeOf contHijo Is CheckBox Or
				TypeOf contHijo Is AdvanceForm Or
				TypeOf contHijo Is TabPage Then
				UsaTexto = True
			End If


			'excepciones

			'If TypeOf contHijo Is BotonActualizar Then
			'	Dim kk = 0
			'End If
			'If UsaTexto Then
			'	If contHijo.Text.Trim = "" Then
			'		Continue For
			'	End If
			'End If
			'Preguntamos si el control tiene uno o mas controles dentro de l mismo con la propiedad 'HasChildren'
			'Si el control tiene 1 o más controles, entonces llamamos al procedimiento de forma recursiva, para que siga
			'recorriendo los demás controles
			If TieneHijo Then
				Recorrer_Controles_Idioma(contHijo, fOrig)
			End If

			If contHijo.Name = "" Then 'si no tiene nombre, es el Panel de un spliter, saltarlo
				Continue For
			End If

			If TypeOf contHijo Is DataGridView Then
				Traducir_Grid(contHijo)
			End If

			Try
				Dim TootipAdv As String = fOrig.ToolTipAdvance.GetToolTip(contHijo)
				If TootipAdv <> "" Then
					fOrig.ToolTipAdvance.SetToolTip(contHijo, Idi(TootipAdv))
				End If
			Catch
			End Try

			'para los iconos del chat
			'Try
			'	If TypeOf contHijo Is ToolStripButton Then
			'		contHijo.ToolTipText = Idi(contHijo.ToolTipText)
			'	End If

			'Catch ex As Exception

			'End Try


			If Not UsaTexto Then
				Continue For
			End If

			'Aqui va la lógica de lo queramos hacer, en mi ejemplo, voy a pintar de color azul el fondo de todos los controles
			Try

				'If TypeOf contHijo Is BotonActualizar Then

				'	Dim btt As BotonActualizar
				'	btt = contHijo
				'	btt.CmdActualizar.Text = Idi(btt.CmdActualizar.Text)
				'	contHijo = btt

				'Else
				'End If

				contHijo.Text = Idi(contHijo.Text)
				If contHijo.Text.Trim = "" Then
					Continue For
				End If



				'DtCampos.Rows.Add(Prefijo & contHijo.Name,
				'				  IIf(Texto = "", "(sin texto)", Texto), "",
				'				  TootipAdv,
				'				  contHijo.Left,
				'				  contHijo.Top,
				'				  contHijo.Width,
				'				  contHijo.Height,
				'				  Padre,
				'				  "",'ocultar
				'				  System.Drawing.ColorTranslator.ToOle(contHijo.ForeColor),'fore_color
				'				  System.Drawing.ColorTranslator.ToOle(contHijo.BackColor),'back_color
				'				  contHijo.Font.Name,
				'				  contHijo.Font.Size,
				'				  IIf(contHijo.Font.Bold, 1, 0),
				'				  IIf(contHijo.Font.Italic, 1, 0),
				'				  "",'fecha
				'				  "", 'usuario
				'				  "", 'resaltar renglon con negro
				'				  "" 'resaltar renglón con verde
				'				  )



			Catch ex As Exception
			End Try

		Next



	End Sub
	Public Sub Traducir_Grid_Clase(Grd As DataGridView)
		Try
			If Not Grd.ColumnHeadersVisible Then Exit Sub
			If LenguajeAdvance = 1 Then
				Traducir_Columnas(Grd)
			End If
		Catch ex As Exception

		End Try
	End Sub
	Private Sub Traducir_Columnas(Grd As DataGridView)
		For J = 0 To Grd.Columns.Count - 1
			If Grd.Columns(J).Visible Then
				Grd.Columns(J).HeaderText = Idi(Grd.Columns(J).HeaderText)
			End If
		Next

	End Sub

	Private Sub Haga_MenuStrip(ByVal Control1 As Form)

		'For Each c As Object In Control1.components.Components

		'	If TypeOf c Is ContextMenuStrip Then
		'		Recorrer_MenuContextual(c)

		'		'	Dim n As ContextMenuStrip
		'		'	n = DirectCast(c, ContextMenuStrip)
		'		'	Dim SS As String = ""
		'		'	For Each c2 In n.Items
		'		'		If TypeOf c2 Is ToolStripSeparator Then
		'		'			Continue For
		'		'		End If
		'		'		If c2.DropDownItems.Count > 0 Then
		'		'			Sq &= "Grupo: " & c2.name & ": " & c2.Text
		'		'			RecorrerMenuContextual(c2.DropDownItems)
		'		'		Else
		'		'			sq &= c2.Text & DMScr()
		'		'		End If
		'		'	Next

		'		'	'For Each c2 As ToolStripMenuItem In n.Items
		'		'	'Next
		'	End If

		'	'este nunca se encuentra
		'	'If TypeOf c Is MenuStrip Then
		'	'	RecorrerMenu(c)
		'	'End If


		'Next

		'se pueban dos nombrea
		Dim ctx As MenuStrip = Nothing
		Try
			ctx = DirectCast(Control1.Controls.Find("MenuStrip", True)(0), MenuStrip)

		Catch
			Try
				ctx = DirectCast(Control1.Controls.Find("MenuStrip1", True)(0), MenuStrip)

			Catch

			End Try


		End Try

		If ctx IsNot Nothing Then
			Recorrer_Menu(ctx)
		End If
	End Sub
	''' <summary>
	''' Este se usa para traducir los menus flotantes
	''' </summary>
	''' <param name="pMenu"></param>
	Public Sub Recorrer_MenuContextual(ByRef pMenu As ContextMenuStrip)
		Dim oToolStripMenuItem As Object ' ToolStripMenuItem
		Try
			For Each oToolStripMenuItem In pMenu.Items
				If TypeOf oToolStripMenuItem Is ToolStripSeparator Then
					Continue For
				End If

				If oToolStripMenuItem.DropDownItems.Count > 0 Then
					oToolStripMenuItem.Text = Idi(oToolStripMenuItem.Text)
					Recorrer_Submenu(oToolStripMenuItem.DropDownItems)
				Else
					'exclusiones
					If TypeOf oToolStripMenuItem Is ToolStripMenuItem Then
						Dim Nom1 As String = oToolStripMenuItem.name.ToString.ToLower
						If Nom1.StartsWith("ult") Or
							Nom1.StartsWith("abi") Then
							Continue For
						End If

					End If

					oToolStripMenuItem.Text = Idi(oToolStripMenuItem.Text)
					'MsgBox(oToolStripMenuItem.Name & ": " & oToolStripMenuItem.Text)
				End If
			Next

		Catch ex As Exception
			Throw New System.Exception(System.String.Concat("Nro. Error(", Err.Number.ToString, ") - ", ex.Message, vbCrLf, ex.StackTrace, vbCrLf))
		Finally
			oToolStripMenuItem = Nothing : GC.Collect()
		End Try
	End Sub

	Private Sub Recorrer_Submenu(ByVal oSubmenuItems As Windows.Forms.ToolStripItemCollection)
		Dim oToolStripItem As Windows.Forms.ToolStripItem

		Try
			For Each oToolStripItem In oSubmenuItems
				If oToolStripItem.GetType Is GetType(Windows.Forms.ToolStripMenuItem) Then
					oToolStripItem.Text = Idi(oToolStripItem.Text)
					oToolStripItem.ToolTipText = Idi(oToolStripItem.ToolTipText)
					If CType(oToolStripItem, Windows.Forms.ToolStripMenuItem).DropDownItems.Count > 0 Then
						Recorrer_Submenu(CType(oToolStripItem, Windows.Forms.ToolStripMenuItem).DropDownItems)
						'Else
						'	oToolStripItem.Text = Idi(oToolStripItem.Text)
					End If
				End If
			Next

		Catch ex As Exception
			Throw New System.Exception(System.String.Concat("Nro. Error(", Err.Number.ToString, ") - ", ex.Message, vbCrLf, ex.StackTrace, vbCrLf))
		Finally
			oToolStripItem = Nothing : GC.Collect()
		End Try
	End Sub
	'barra de herramientas
	Public Sub Recorrer_ToolStrip(ByVal oSubmenuItems As Windows.Forms.ToolStrip)
		'Dim oToolStripItem As Windows.Forms.ToolStripItem
		Dim oToolStripItem As Object

		Try
			For Each oToolStripItem In oSubmenuItems.Items
				If oToolStripItem.GetType Is GetType(Windows.Forms.ToolStripMenuItem) Then
					If CType(oToolStripItem, Windows.Forms.ToolStripMenuItem).DropDownItems.Count > 0 Then
						oToolStripItem.Text = Idi(oToolStripItem.Text)
						Recorrer_Submenu(CType(oToolStripItem, Windows.Forms.ToolStripMenuItem).DropDownItems)
					Else

						oToolStripItem.Text = Idi(oToolStripItem.Text.Trim)
						Try
							If TypeOf oToolStripItem Is ToolStripButton Then
								oToolStripItem.ToolTipText = Idi(oToolStripItem.ToolTipText)
							End If

						Catch ex As Exception

						End Try

					End If
				End If

				If oToolStripItem.GetType Is GetType(Windows.Forms.ToolStripDropDownButton) Then
					If CType(oToolStripItem, Windows.Forms.ToolStripDropDownButton).DropDown.Items.Count > 0 Then
						oToolStripItem.Text = Idi(oToolStripItem.Text)
						oToolStripItem.ToolTipText = Idi(oToolStripItem.ToolTipText)
						Recorrer_Submenu(CType(oToolStripItem, Windows.Forms.ToolStripDropDownButton).DropDown.Items)
					Else

						oToolStripItem.Text = Idi(oToolStripItem.Text.Trim)
						Try
							If TypeOf oToolStripItem Is ToolStripButton Then
								oToolStripItem.ToolTipText = Idi(oToolStripItem.ToolTipText)
							End If

						Catch ex As Exception

						End Try

					End If
				End If

				If TypeOf oToolStripItem Is ToolStripItem Then
					If oToolStripItem.Text.Trim <> "" Then
						oToolStripItem.Text = Idi(oToolStripItem.Text.Trim)
					End If
				End If
				If TypeOf oToolStripItem Is ToolStripButton Then
					oToolStripItem.ToolTipText = Idi(oToolStripItem.ToolTipText)
				End If

			Next

		Catch ex As Exception
			Throw New System.Exception(System.String.Concat("Nro. Error(", Err.Number.ToString, ") - ", ex.Message, vbCrLf, ex.StackTrace, vbCrLf))
		Finally
			oToolStripItem = Nothing : GC.Collect()
		End Try
	End Sub
	Private Sub Recorrer_Menu(ByRef pMenu As MenuStrip)
		Dim oToolStripMenuItem As ToolStripMenuItem
		Try
			For Each oToolStripMenuItem In pMenu.Items
				If oToolStripMenuItem.DropDownItems.Count > 0 Then
					oToolStripMenuItem.Text = Idi(oToolStripMenuItem.Text)
					Recorrer_Submenu(oToolStripMenuItem.DropDownItems)
				Else
					oToolStripMenuItem.Text = Idi(oToolStripMenuItem.Text)
				End If
			Next

		Catch ex As Exception
			Throw New System.Exception(System.String.Concat("Nro. Error(",
			Err.Number.ToString, ") - ", ex.Message, vbCrLf, ex.StackTrace,
			vbCrLf))
		Finally
			oToolStripMenuItem = Nothing : GC.Collect()
		End Try
	End Sub



	Public Function Convierta_Idioma(TextoEspañol As String, Optional TextoIngles As String = "") As String
		Dim HacerExcepciones As Boolean = True
		If TextoIngles = "\" Then
			HacerExcepciones = False
			TextoIngles = ""
		End If

		'si el programa manda la traducción especifica
		If TextoIngles <> "" Then
			Return TextoIngles.Replace(EsIngles, "") & EsIngles()
		End If

		'si ya viene traducida, sacarlo
		If TextoEspañol.Contains(EsIngles) Then
			'Return TextoEspañol.Replace(CharMarca, "")
			Return TextoEspañol
		End If


		TextoEspañol = Strings.Left(TextoEspañol.Replace("'", "''").Replace(DMScr(), "^"), 300).Trim
		If Not TextoEspañol.Contains("http:") Then
			TextoEspañol = Strings.Left(TextoEspañol.Replace("&", ""), 300)
		End If

		If TextoEspañol = "" Then
			Return TextoEspañol
		End If

		Dim TextoSinTildes = SinTildes(TextoEspañol)

		'si no, buscarla en la base de datos en memoria con llave
		Dim Dr As DataRow = DtIdioma.Rows.Find(Strings.Left(TextoSinTildes, 300))

		If Dr IsNot Nothing Then
			Return Dr("ingles") & EsIngles() ' & IIf(AgregarMarca, CharMarca, "")
		End If


		'definir si verdaderamente es numérico
		Dim EsNumerico As Boolean = False
		If IsNumeric(Strings.Left(TextoEspañol, 1)) And IsNumeric(Strings.Right(TextoEspañol, 1)) Then
			EsNumerico = True
		End If

		'EXCLUSIONES
		Dim Nom1 As String = TextoEspañol.ToLower
		If Nom1.StartsWith("label") Or
			Nom1.StartsWith("c:\") Or
			Nom1.StartsWith("\\") Or
			Nom1.StartsWith("lbl") Or
			Nom1.StartsWith("linkLabel") Or
			Nom1.StartsWith("linkLabel") Or
			Nom1.StartsWith("toolstrip") Or
			Nom1.StartsWith("button") Or
			EsNumerico Or
			TextoEspañol.Contains("14.1.") Or
			TextoEspañol.Contains("®") Or
			Nom1.Contains("system.web.") Or
			TextoEspañol.Length < 3 Or
			TextoEspañol.Trim = "" Or
			TextoEspañol = "..." Then

			If HacerExcepciones Then
				Return TextoEspañol
			End If

		End If
		'/EXCLUSIONES

		'Guardar instrucción para que JDMS la ejecute en todos los nodos
		Try
			Dim FaltaEsta As Boolean = True
			Dim Archi As String = "c:\smd_files\idioma.txt"
			If IO.File.Exists(Archi) Then
				Dim objReader As New IO.StreamReader(Archi)
				Dim sLine As String = ""
				Do
					sLine = objReader.ReadLine()
					If Not sLine Is Nothing Then
						If sLine = TextoSinTildes Then
							FaltaEsta = False
							Exit Do
						End If
					End If
				Loop Until sLine Is Nothing
				objReader.Close()
			End If
			'si no lo encontré lo agrego
			If FaltaEsta Then
				Using sw As IO.StreamWriter = IO.File.AppendText(Archi)
					'sw.WriteLine(Sq & "--" & My.Application.Info.Title & ": " & Now)
					sw.WriteLine(TextoSinTildes)
					sw.Close()
					SaveSetting("DMS S.A.", "relojito", "lang_gr", 1)
				End Using
			End If

		Catch ex As Exception
		End Try

		Return TextoEspañol & EsIngles() 'se le agrega esto para que no entre más a la rutina de Idioma


	End Function


	Public Sub Montar_Idioma_Clase(Dt As DataTable)

		Try
			DtIdioma = Dt
			Dim DD As New DataSet
			Dim XMLIdioma As String = "c:\smd_files\traducciones"
			Dim GrabarXML As Boolean = True

			If Fin(DtIdioma) Then
				If IO.File.Exists(XMLIdioma) Then
					DD.ReadXmlSchema(XMLIdioma & ".1")
					DD.ReadXml(XMLIdioma)
					DtIdioma = DD.Tables(0)
					GrabarXML = False
				Else
					Mensaje("a", "Error loading English pakage, It will try again from DB")
					Abrir(DtIdioma, "Exec dbo.GetIdioma ''")
					If Fin(DtIdioma) Then
						LenguajeAdvance = 0
						Mensaje("There are not lenguale data. Will be use Spanish")
						Exit Sub
					End If
				End If
			End If

			If GrabarXML Then
				DD.Tables.Add(DtIdioma.Copy)
				DD.WriteXml(XMLIdioma)
				DD.WriteXmlSchema(XMLIdioma & ".1")
				SaveSetting("DMS S.A.", "relojito", "langfec", FmtFecSQL(Now))
			End If

			Dim PrimaryKeyColumns(0) As DataColumn
			PrimaryKeyColumns(0) = DtIdioma.Columns("espanol")
			DtIdioma.PrimaryKey = PrimaryKeyColumns

		Catch ex As Exception
			LenguajeAdvance = 0
			MostrarError("GlobalesVarios", "Montar_Idioma", "Error in Languale: You have to work in spanis:" & DMScr(2) & ex.Message & EsIngles())

		End Try

	End Sub
End Class
