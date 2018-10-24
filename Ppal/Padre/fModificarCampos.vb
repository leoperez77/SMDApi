' Version: 695, 4-oct.-2018 12:56
' Version: 694, 28-sep.-2018 12:57
' Version: 691, 17-sep.-2018 20:53
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 678, 16-ago.-2018 14:15
' Version: 675, 14-ago.-2018 18:45
'♥ versión: 588, 12-oct.-2017 17:24
'♥ versión: 587, 11-oct.-2017 11:31
'♥ versión: 587, 6-oct.-2017 18:54
'♥ versión: 586, 6-oct.-2017 07:11
'♥ versión: 586, 5-oct.-2017 21:44
Public Class fModificarCampos
	Dim DtCopiaCampos As DataTable
	Public fOrig As AdvanceForm
	Public Prog As String
	Public Prefijo As String
	Dim IdProg As Integer
	Dim NomFile As String
	Dim HuboCambios As Integer = 0
	Dim HuboEsta As Integer = 0

	Private Sub fModificarCampos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Recorrer_Controles_Idioma(Me, Me)

		Try
			NomFile = "c:\smd_files\" & Prog & "_campos.xml"

			Try
				If GetSett(Me.Name, "tam_w", "") = "" Then
					Me.CenterToScreen()
				Else
					Me.Width = GetSett(Me.Name, "tam_w", Me.Width)
					If Me.Width < 200 Then
						Me.Width = 200
					End If
					Me.Height = GetSett(Me.Name, "tam_h", Me.Height)
					If Me.Height < 200 Then
						Me.Height = 200
					End If
					Me.Left = GetSett(Me.Name, "pos_l", Me.Left)
					If Me.Left < -100 Then
						Me.Left = -100
					End If
					If Me.Left > 1000 Then
						Me.Left = 1000
					End If
					Me.Top = GetSett(Me.Name, "post_t", Me.Top)
					If Me.Top < -100 Then
						Me.Top = 0
					End If
					If Me.Top > 700 Then
						Me.Top = 700
					End If
				End If

			Catch
			End Try

			Grd.EliminarToolStripMenuItem.Text = Idi("Borrar este renglón")
			Grd.EliminarToolStripMenuItem.ForeColor = Color.Red

			Grd.AbrirToolStripMenuItem.Text = Idi("Modificar objeto")

			'Grd.CmdOtrasOpciones0.Text = "Copiar / Pegar"
			'Grd.CmdOtrasOpciones0.ForeColor = Color.Blue
			'Grd.CmdOtrasOpciones0.Visible = True

			Grd.Separador0.Visible = True

			Grd.CmdOtrasOpciones.Text = Idi("&Copiar Fuente y colores")
			Grd.CmdOtrasOpciones.ForeColor = Color.Blue
			Grd.CmdOtrasOpciones.Visible = True

			Grd.CmdOtrasOpciones2.Text = Idi("&Pegar")
			Grd.CmdOtrasOpciones2.ForeColor = Color.Blue
			Grd.CmdOtrasOpciones2.Visible = True


			Dim DtCampos As New DataTable
			DtCampos.Columns.Add("Objeto")
			DtCampos.Columns.Add("Default")
			DtCampos.Columns.Add("Nuevo texto")
			DtCampos.Columns.Add("Tooltip_adv")
			DtCampos.Columns.Add("posX")
			DtCampos.Columns.Add("posY")
			DtCampos.Columns.Add("tamX")
			DtCampos.Columns.Add("tamY")
			DtCampos.Columns.Add("Padre")
			DtCampos.Columns.Add("Ocultar")
			DtCampos.Columns.Add("fore_color")
			DtCampos.Columns.Add("back_color")
			DtCampos.Columns.Add("font_name")
			DtCampos.Columns.Add("font_size")
			DtCampos.Columns.Add("font_bold")
			DtCampos.Columns.Add("font_italic")
			DtCampos.Columns.Add("Fecha_hora")
			DtCampos.Columns.Add("Usuario")
			DtCampos.Columns.Add("!n")
			DtCampos.Columns.Add("!c")

			'===============================================================================================
			Recorrer_Controles(fOrig, DtCampos)
			'===============================================================================================

			DtCampos = Filtrar_DataTable(DtCampos, "", "objeto")

			DtCopiaCampos = DtCampos.Copy

		Catch ex As Exception
			MostrarError(Me.Name, "fModificarCampos_Load", ex.Message)
			Me.Close()
			Exit Sub
		End Try



	End Sub
	Private Sub Recorrer_Controles(ByVal Control1 As Control, ByRef DtCampos As DataTable)



		'Recorremos con un ciclo for each cada control que hay en la colección Controls
		For Each contHijo As Control In Control1.Controls
			'exclusiones
			If contHijo.Name = "PicPuntoAdv" Then
				Continue For
			End If

			Dim TieneHijo As Boolean = False ' contHijo.HasChildren


			If TypeOf contHijo Is Panel Or
				TypeOf contHijo Is TabControl Or
				TypeOf contHijo Is GroupBox Or
				TypeOf contHijo Is SplitContainer Or
				TypeOf contHijo Is ToolStripContainer Or
				TypeOf contHijo Is ToolStripContentPanel Or
				TypeOf contHijo Is TableLayoutPanel Or
				TypeOf contHijo Is SplitContainer Or
				TypeOf contHijo Is SplitterPanel Then
				TieneHijo = True
			End If

			'los que no usan texto
			Dim UsaTexto As Boolean = False
			If TypeOf contHijo Is TextBox Or
				TypeOf contHijo Is Label Or
				TypeOf contHijo Is LinkLabel Or
				TypeOf contHijo Is GroupBox Or
				TypeOf contHijo Is Button Or
				TypeOf contHijo Is BotonActualizar Or
				TypeOf contHijo Is BotonEstandar Or
				TypeOf contHijo Is RadioButton Or
				TypeOf contHijo Is CheckBox Or
				TypeOf contHijo Is TabPage Then
				UsaTexto = True
			End If

			'Preguntamos si el control tiene uno o mas controles dentro de l mismo con la propiedad 'HasChildren'
			'Si el control tiene 1 o más controles, entonces llamamos al procedimiento de forma recursiva, para que siga
			'recorriendo los demás controles
			If TieneHijo Then
				Recorrer_Controles(contHijo, DtCampos)
			End If

			If contHijo.Name = "" Then 'si no tiene nombre, es el Panel de un spliter, saltarlo
				Continue For
			End If

			'Aqui va la lógica de lo queramos hacer, en mi ejemplo, voy a pintar de color azul el fondo de todos los controles
			Try

				Dim Texto As String
				If UsaTexto Then
					If TypeOf contHijo Is BotonActualizar Then
						Dim Controlito As BotonActualizar = DirectCast(fOrig.Controls.Find(contHijo.Name, True)(0), BotonActualizar)
						Texto = Controlito.DMSText
					Else
						Texto = contHijo.Text
					End If
				Else
					Texto = "(No aplica)"
				End If

				Dim TootipAdv As String = fOrig.ToolTipAdvance.GetToolTip(contHijo)

				Dim Padre As String
				If contHijo.Parent Is fOrig Then
					Padre = ""
				Else
					Padre = contHijo.Parent.Name
				End If

				DtCampos.Rows.Add(Prefijo & contHijo.Name,
								  IIf(Texto = "", "(sin texto)", Texto), "",
								  TootipAdv,
								  contHijo.Left,
								  contHijo.Top,
								  contHijo.Width,
								  contHijo.Height,
								  Padre,
								  "",'ocultar
								  System.Drawing.ColorTranslator.ToOle(contHijo.ForeColor),'fore_color
								  System.Drawing.ColorTranslator.ToOle(contHijo.BackColor),'back_color
								  contHijo.Font.Name,
								  contHijo.Font.Size,
								  IIf(contHijo.Font.Bold, 1, 0),
								  IIf(contHijo.Font.Italic, 1, 0),
								  "",'fecha
								  "", 'usuario
								  "", 'resaltar renglon con negro
								  "" 'resaltar renglón con verde
								  )

			Catch ex As Exception
			End Try

		Next



	End Sub

	Private Sub Mostrar_Grid(Dt As DataTable, Optional UltimaColumna As String = "", Optional Primera As Integer = -1)
		Dim DtCampos As DataTable = DtCopiaCampos.Copy

		For Each Fi As DataRow In DtCampos.Rows
			Dim Dr() As DataRow = Dt.Select("campo='" & Fi("objeto") & "'")
			If Dr.Length = 0 Then
				Continue For
			End If

			Fi("!n") = 1
			Fi("nuevo texto") = "" & Dr(0)("titulo")
			Fi("usuario") = "" & Dr(0)("usuario")
			Fi("ocultar") = IIf(Dr(0)("ocultar") Is DBNull.Value, "", "Si")

			If Dr(0)("titulo_ant") IsNot DBNull.Value Then
				Fi("default") = "" & Dr(0)("titulo_ant")
			End If

			If Dr(0)("tooltip_adv") IsNot DBNull.Value Then
				Fi("tooltip_adv") = "" & Dr(0)("tooltip_adv")
			End If

			If Dr(0)("fecha_hora") IsNot DBNull.Value Then
				Fi("fecha_hora") = Strings.Format(Dr(0)("fecha_hora"), "yyyy-MM-dd HH:mm:ss")
			End If

			If Dr(0)("posx") IsNot DBNull.Value Then
				Fi("posx") = "*" & Dr(0)("posx")
			End If
			If Dr(0)("posy") IsNot DBNull.Value Then
				Fi("posy") = "*" & Dr(0)("posy")
			End If
			If Dr(0)("tamx") IsNot DBNull.Value Then
				Fi("tamx") = "*" & Dr(0)("tamx")
			End If
			If Dr(0)("tamy") IsNot DBNull.Value Then
				Fi("tamy") = "*" & Dr(0)("tamy")
			End If
			If Dr(0)("fore_color") IsNot DBNull.Value Then
				Fi("fore_color") = "*" & Dr(0)("fore_color")
			End If
			If Dr(0)("back_color") IsNot DBNull.Value Then
				Fi("back_color") = "*" & Dr(0)("back_color")
			End If
			If Dr(0)("font_name") IsNot DBNull.Value Then
				Fi("font_name") = "*" & Dr(0)("font_name")
			End If
			If Dr(0)("font_size") IsNot DBNull.Value Then
				Fi("font_size") = "*" & Dr(0)("font_size")
			End If

			If Dr(0)("font_bold") IsNot DBNull.Value Then
				Fi("font_bold") = "*" & Dr(0)("font_bold")
			End If


			If Dr(0)("font_italic") IsNot DBNull.Value Then
				Fi("font_italic") = "*" & Dr(0)("font_italic")
			End If


			Fi.AcceptChanges()

		Next

		Grd.Visible = False
		'=========================================================================================================
		'Grd.DMSLlene_Grid(Filtrar_DataTable(DtCampos, "", "objeto"), "objeto", MostrarEliminar:=False, ColOcultas:=New Object() {"font_name", "font_size", "font_bold", "font_italic", "fore_color", "back_color"})
		Grd.DMSLlene_Grid(Filtrar_DataTable(DtCampos, "", "objeto"), "objeto", MostrarEliminar:=True)
		'=========================================================================================================

		CCols.Mostrar_Columnas("0280", Grd.Grid)

		Grd.Grid.Columns("ocultar").Width = 50
		Grd.Grid.Columns("padre").Width = 50
		Grd.Grid.Columns("ocultar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		Grd.Grid.Columns("objeto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
		Grd.Grid.Columns("posX").Width = 45
		Grd.Grid.Columns("posY").Width = 45
		Grd.Grid.Columns("tamX").Width = 45
		Grd.Grid.Columns("tamY").Width = 45
		Grd.Grid.Columns("posX").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		Grd.Grid.Columns("posY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		Grd.Grid.Columns("tamX").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		Grd.Grid.Columns("tamY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		Grd.Grid.Columns("nuevo texto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
		Grd.Grid.Columns("tooltip_adv").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

		Grd.Grid.Columns("fecha_hora").Width = 100
		Grd.Grid.Columns("fore_color").Width = 45
		Grd.Grid.Columns("back_color").Width = 45

		'mostrar en la que estaba
		If UltimaColumna <> "" Then
			For Each ro As DataGridViewRow In Grd.Grid.Rows
				If ro.Cells("objeto").Value = UltimaColumna Then
					ro.Selected = True
					If Primera >= 0 Then
						Grd.Grid.FirstDisplayedScrollingRowIndex = Primera 'para garantizar que se vea en la pantalla
					Else
						Grd.Grid.FirstDisplayedScrollingRowIndex = ro.Index - IIf(ro.Index > 5, 5, ro.Index) 'para garantizar que se vea en la pantalla
					End If
					Exit For
				End If
			Next
		End If

		Grd.Visible = True

	End Sub
	Private Sub Grd_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles Grd.DMSTraerValor
		Try
			'Dim Primera As Integer = Grd.Grid.FirstDisplayedScrollingRowIndex
			Dim Fi As DataRow = Grd.DMSDevolverDt.DefaultView.Item(Grd.Grid.SelectedRows(0).Index).Row


			Dim fCp As New fCampito With {
				.Text = Idi("Modificar") & ": " & ValorColDevolver.ToString & " (" & Prog & ")",
				.IdProg = IdProg,
				.Prefijo = Prefijo,
				.Tag = ValorColDevolver.ToString
			}
			fCp.LblDatosForma.Text = Idi("Tamaño formulario: Ancho", "Form size: Width") & ": " & fOrig.Width & Idi(", Alto: ", ", Height: ") & fOrig.Height
			fCp.LblAnt.Text = "" & Fi("default")
			fCp.TxtTitulo.Text = "" & Fi("nuevo texto")
			fCp.TxtTitulo.Tag = "" & Fi("nuevo texto")
			fCp.TxtTool.Text = ArreglarReturns("" & Fi("tooltip_adv"))
			fCp.TxtTool.Tag = "" & Fi("tooltip_adv")
			fCp.ChkOculto.Checked = Fi("ocultar") = "Si"
			fCp.ChkOculto.Tag = Fi("ocultar") = "Si"
			fCp.FiOrig = Fi


			'If Strings.Left("" & Fi("tooltip_adv").ToString, 1) = "*" Then
			'	fCp.TxtTool.ForeColor = Color.Red
			'	fCp.TxtTool.Text = Strings.Mid(Fi("tooltip_adv"), 2)
			'Else
			'	fCp.TxtTool.Text = "" & Fi("tooltip_adv")
			'End If

			If Fi("posX").ToString.Contains("*") Then
				fCp.TxtPosX.ForeColor = Color.Red
			End If
			fCp.TxtPosX.Text = QA(Fi("posX"))
			If fCp.TxtPosX.Text = "-5000" Then
				fCp.TxtPosX.Visible = False
				fCp.LblPosXl.Visible = False
			End If


			If Fi("posy").ToString.Contains("*") Then
				fCp.TxtPosY.ForeColor = Color.Red
			End If
			fCp.TxtPosY.Text = QA(Fi("posY"))
			If fCp.TxtPosY.Text = "-1" Then
				fCp.TxtPosY.Visible = False
				fCp.LblPosYl.Visible = False
			End If

			If Fi("tamX").ToString.Contains("*") Then
				fCp.TxtTamX.ForeColor = Color.Red
			End If
			fCp.TxtTamX.Text = QA(Fi("tamX"))
			If fCp.TxtTamX.Text = "-1" Then
				fCp.TxtTamX.Visible = False
				fCp.LblTamXl.Visible = False
			End If

			If Fi("tamY").ToString.Contains("*") Then
				fCp.TxtTamY.ForeColor = Color.Red
			End If
			fCp.TxtTamY.Text = QA(Fi("tamY"))
			If fCp.TxtTamY.Text = "-1" Then
				fCp.TxtTamY.Visible = False
				fCp.LblTamYl.Visible = False
			End If

			If ValD(QA(Fi("fore_color"))) = -1 Then
				fCp.CmdColorLetra.Visible = False
				fCp.LnkColorDefault.Visible = False
			Else
				fCp.LblPrueba.ForeColor = System.Drawing.ColorTranslator.FromOle(QA(Fi("fore_color")))
			End If

			Try
				If QA(Fi("back_color")) = -1 Then
					fCp.CmdColorFondo.Visible = False
					fCp.LnkColorBackDefault.Visible = False
				Else
					fCp.LblPrueba.BackColor = System.Drawing.ColorTranslator.FromOle(QA(Fi("back_color")))
				End If

			Catch

			End Try

			If QA(Fi("font_name")) = "-1" Then
				fCp.CmdFuente.Visible = False
				fCp.LnkFuenteDefault.Visible = False
			Else
				fCp.LblPrueba.Font = VB6.FontChangeName(fCp.LblPrueba.Font, QA(Fi("font_name")))
				fCp.LblPrueba.Font = VB6.FontChangeSize(fCp.LblPrueba.Font, QA(Fi("font_size")))
				fCp.LblPrueba.Font = VB6.FontChangeBold(fCp.LblPrueba.Font, IIf(QA(Fi("font_bold")) = 1, True, False))
				fCp.LblPrueba.Font = VB6.FontChangeItalic(fCp.LblPrueba.Font, IIf(QA(Fi("font_italic")) = 1, True, False))
				fCp.ChkNegrilla.Checked = fCp.LblPrueba.Font.Bold
				fCp.ChkNegrilla.Tag = fCp.LblPrueba.Font.Bold
			End If



			If Fi("default") = "(No aplica)" Then
				fCp.Panel1.Enabled = False
			End If

			'===============================================================
			fCp.ShowDialog()
			'===============================================================
			If ValD(fCp.Tag) = 0 Then 'no tocó nada
				Exit Sub
			End If

			Dim Fila As Integer = Grd.Grid.SelectedRows(0).Index

			If ValD(fCp.Tag) = 2 Then 'borrar
				Borrar_Fila(Fila)
				Exit Sub
			End If

			'actualizar
			'Grd.Grid.DataSource = DtCampos
			'Grd.Grid.Rows(Fila).DefaultCellStyle.Font = LblNegrilla.Font
			'If Tm(Grd.Grid, "!c") = "1" Then 'rojo
			'	Grd.Grid.Rows(Fila).DefaultCellStyle.ForeColor = Color.Red
			'Else
			'	Grd.Grid.Rows(Fila).DefaultCellStyle.ForeColor = Color.Green
			'End If
			'Grd.Grid.Rows(Fila).Selected = True

			'para apagar el selected
			Grd.Grid.ClearSelection()


			HuboEsta += 1

			Me.Tag = 2 'requiere actualizar

			''quitar
			'If fCp.DtRetorno IsNot Nothing Then
			'	SiReloj()
			'	Mostrar_Grid(fCp.DtRetorno, ValorColDevolver, Primera)
			'	Me.Tag = 1
			'	NoReloj()
			'End If
		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "Grd_DMSTraerValor", ex.Message)

		End Try


	End Sub

	Private Sub CmdCancelar_Click(sender As Object, e As EventArgs)
		Me.Close()

	End Sub

	Private Sub fModificarCampos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
		Try
			Dim Ds As New DataSet
			SiReloj()
			Abrir(Ds, ArmeSQL("Exec GetProgramasTitUno",
							  Numero_Empresa, qqNum,
							  0, qqCon,
							  Prog, qqTex,
							  Prefijo, qqTex)
							)

			IdProg = Gdf(Ds.Tables(1), "id")


			'========================================================================
			Mostrar_Grid(Ds.Tables(0))
			'========================================================================

			Grd.Grid.ClearSelection()

			NoReloj()

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "fModificarCampos_Load", ex.Message)
			Me.Close()
			Exit Sub
		End Try

		If ReglaDeNegocio(143, "fabrica", "0") = "1" Then
			Mensaje("Nota: Puede hacer cambios y estos serán registrados, pero solo serán visibles para el usuario cuando apague la llave [fabrica] de la Rn#143")
		End If

	End Sub

	Private Sub Grd_DMSTraerValorOtro(Sender As Object, ValorColDevolver As Object) Handles Grd.DMSTraerValorOtro
		'copiar

		Dim Fi As DataRow = Grd.DMSDevolverDt.DefaultView.Item(Grd.Grid.SelectedRows(0).Index).Row

		Try
			SaveSett(Me.Name, "fore_color", Fi("fore_color"))
			SaveSett(Me.Name, "back_color", Fi("back_color"))
			SaveSett(Me.Name, "font_name", Fi("font_name"))
			SaveSett(Me.Name, "font_size", Fi("font_size"))
			SaveSett(Me.Name, "font_bold", Fi("font_bold"))
			SaveSett(Me.Name, "font_italic", Fi("font_italic"))
			SonarWAV("laser")

		Catch ex As Exception
			Mensaje(ex.Message)

		End Try
	End Sub
	Private Sub Grd_DMSTraerValorOtro2(Sender As Object, ValorColDevolver As Object) Handles Grd.DMSTraerValorOtro2
		'pegar
		Dim Fi As DataRow = Grd.DMSDevolverDt.DefaultView.Item(Grd.Grid.SelectedRows(0).Index).Row

		Try
			If GetSett(Me.Name, "fore_color", "") = "" Then
				Mensaje("Primero debe copiar")
				Exit Sub
			End If

			Fi("fore_color") = GetSett(Me.Name, "fore_color", Fi("fore_color"))
			Fi("back_color") = GetSett(Me.Name, "back_color", Fi("back_color"))
			Fi("font_name") = GetSett(Me.Name, "font_name", Fi("font_name"))
			Fi("font_size") = GetSett(Me.Name, "font_size", Fi("font_size"))
			Fi("font_bold") = GetSett(Me.Name, "font_bold", Fi("font_bold"))
			Fi("font_italic") = GetSett(Me.Name, "font_italic", Fi("font_italic"))
			If Fi("!c") = "" Then
				If Fi("!n") = "" Then 'no tenía definiciones
					Fi("!c") = 2 '=azul: 
				Else
					Fi("!c") = 3 '=verde: modificando existente
				End If
			End If
			Fi("!n") = 1
			Fi.AcceptChanges()
			'Grd.Grid.DataSource = DtCampos
			HuboEsta += 1

			Me.Tag = 2

			SonarWAV("ok")

		Catch ex As Exception
			Mensaje(ex.Message)

		End Try

	End Sub



	Private Function No_Salir() As Boolean
		If ValD(Me.Tag) = 2 Then
			If Pregunte("Tiene " & HuboEsta & " cambio" & IIf(HuboEsta > 1, "s", "") & " sin actualizar." & DMScr(2) & "Desea salir sin salvar?") Then
				Return False
			Else
				Return True
			End If
		Else
			Return False
		End If

	End Function

	Private Sub fModificarCampos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		If No_Salir() Then
			e.Cancel = True
			Exit Sub
		End If
		Me.Tag = 0

		SaveSett(Me.Name, "tam_w", Me.Width)
		SaveSett(Me.Name, "tam_h", Me.Height)
		SaveSett(Me.Name, "pos_l", Me.Left)
		SaveSett(Me.Name, "post_t", Me.Top)

	End Sub

	Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click
		If No_Salir() Then
			Exit Sub
		End If

		If HuboCambios > 0 Then
			If ReglaDeNegocio(143, "fabrica", "0") <> "1" Then

				'Mensaje("Nota: Verá los cambios cuando reingrese a este formulario")
				'3) VentanitaWEB: Mostrar la ventana si tiene el permiso
				VentanitaWEB.MostrarVentanaWeb(New FormCollection, fOrig, Nothing, "<center><h1>Nota: Verá " & HuboCambios & " cambio" & IIf(HuboCambios = 1, "", "s") & " cuando reingrese a este formulario", 2)
				'/3) VentanitaWEB: Mostrar la ventana si tiene el permis


				Try
					SiReloj()
					'volver a leer todos los títulos
					Abrir(DtTitPantalla, "Exec GetProgramasTit " & Numero_Empresa)

					NoReloj()

				Catch ex As Exception
					NoReloj()
					MostrarError(Me.Name, "CmdObjetos_Click", ex.Message)
				End Try
			End If

		End If

		Me.Tag = 0
		Me.Close()

	End Sub

	Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles CmdActualizar.Click, CmdSalvar.Click

		Dim Dt As DataTable = Filtrar_DataTable(Grd.DMSDevolverDt, "[!c] in('1','2','3')")
		If Fin(Dt) Then
			If sender Is CmdActualizar Then
				If Pregunte("No hay cambios para actualizar. Desea salir?") Then
					CmdSalir.PerformClick()
					Exit Sub
				End If
			End If
			Exit Sub
		End If

		Dim Sq As String = ""

		SiReloj()

		HuboCambios += Dt.Rows.Count


		Try

			For Each Fi As DataRow In Dt.Rows
				If Fi("!c") = "1" Then 'borrar campo
					'DelProgramasTitUno
					Sq &= ArmeSQL("Exec DelProgramasTitUno",
								 Numero_Empresa, qqNum,
								 Usuario, qqNum,
								 IdProg, qqNum,
								 Fi("objeto"), qqTex
								 )
				Else
					Sq &= ArmeSQL("exec PutProgramasTitUnoCompleto",
									 Numero_Empresa, qqNum,
									 Usuario, qqNum,
									 IdProg, qqNum,
									 Fi("objeto"), qqTex,
									 Prefijo, qqTex,
									 Fi("nuevo texto"), qqTex,
									 Fi("default"), qqTex,
									 IIf(Fi("ocultar") <> "", 1, 0), qqNum,
									 VR(Fi("posx")), qqNum,
									 VR(Fi("posy")), qqNum,
									 VR(Fi("tamx")), qqNum,
									 VR(Fi("tamy")), qqNum,
									 VR(Fi("fore_color")), qqNum,
									 VR(Fi("back_color")), qqNum,
									 VR(Fi("Font_Name")), qqTex,
									 VR(Fi("Font_Size")), qqNum,
									 VR(Fi("Font_bold")), qqNum,
									 VR(Fi("Font_italic")), qqNum,
									 Fi("tooltip_adv"), qqTex
)
				End If

			Next

			'devolver al programa
			If sender Is CmdSalvar Then
				Sq &= ArmeSQL("EXEC GetProgramasTitUno",
					Numero_Empresa, qqNum,
					IdProg, qqNum,
					"", qqTex,
					Prefijo, qqTex)
			End If


			Abrir(Dt, Sq)

			Me.Tag = 0
			HuboEsta = 0

			SonarWAV("OK")

			If sender Is CmdSalvar Then
				Mostrar_Grid(Dt, "", 0)
				Grd.Grid.ClearSelection()
				NoReloj()
			Else
				NoReloj()
				CmdSalir.PerformClick()
				Exit Sub
			End If



		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "CmdOk_Click", ex.Message)
			Exit Sub
		End Try

	End Sub
	Private Function VR(Valor) As String
		If Valor.ToString.Contains("*") Then
			Return QA(Valor)
		Else
			Return "-2"
		End If

	End Function
	Private Function QA(Contenido As String) As String
		Return Contenido.Replace("*", "")

	End Function


	Private Sub Grd_DMSTraerValorEliminar(Sender As Object, ValorColDevolver As Object, Fila As Integer) Handles Grd.DMSTraerValorEliminar
		Borrar_Fila(Fila)


	End Sub
	Public Sub Borrar_Fila(Fila)
		Dim Fi As DataRow = Grd.DMSDevolverDt.DefaultView.Item(Fila).Row
		If Fi("!c") = "1" Then
			Mensaje("Campo ya fue eliminado")
			Exit Sub
		End If
		If Fi("!n") <> "1" Then
			Mensaje("Campo no tiene definiciones")
			Exit Sub
		End If

		Fi("!c") = 1 '=rojo 
		Fi.AcceptChanges()
		'Grd.Grid.DataSource = DtCampos
		'Grd.Grid.Rows(Fila).DefaultCellStyle.ForeColor = Color.Red

		Me.Tag = 2
		SonarWAV("laser")
		HuboEsta += 1

		Grd.Grid.ClearSelection()

	End Sub

	Private Sub LnkAudit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkAudit.LinkClicked
		Ventana("GetCotAuditoria 144," & IdProg & "," & Numero_Empresa, "Auditoría programa " & Prog)

	End Sub

	Private Sub LnkEliminar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkEliminar.LinkClicked
		Dim Cua As Integer = Filtrar_DataTable(Grd.DMSDevolverDt, "!n='1'").Rows.Count

		If Cua = 0 Then
			Mensaje("No hay nada para borrar")
			Exit Sub
		End If


		Try
			If Not Pregunte("Seguro de eliminar todas las definiciones de este formulario?") Then
				Exit Sub
			End If


			Dim Sq As String = ""

			Sq &= ArmeSQL("exec DelProgramasTitUno",
						 Numero_Empresa, qqNum,
						 Usuario, qqNum,
						 IdProg, qqNum)



			'devolver al programa
			Sq &= ArmeSQL("EXEC GetProgramasTitUno",
				Numero_Empresa, qqNum,
				IdProg, qqNum,
				"", qqTex,
				Prefijo, qqTex)


			Dim Dt As New DataTable
			Abrir(Dt, Sq)

			Me.Tag = 0

			SonarWAV("OK")
			HuboCambios += Cua

			Mostrar_Grid(Dt, "", 0)
			Grd.Grid.ClearSelection()
			NoReloj()

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "Borrar_Todo", ex.Message)
			Exit Sub
		End Try

	End Sub

	Private Sub LnkExportar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkExportar.LinkClicked
		If ValD(Me.Tag) = 2 Then
			Mensaje("Primero actualice o descarte los cambios que tiene en pantalla")
			Exit Sub
		End If

		Try
			Dim Ds As New DataSet
			SiReloj()
			Abrir(Ds, ArmeSQL("Exec GetProgramasTitUnoExport",
							  Numero_Empresa, qqNum,
							  Prog, qqTex,
							  Prefijo, qqTex)
							)

			Ds.WriteXml(NomFile)

			NoReloj()

			Mensaje(NomFile & DMScr(2) & "Registros exportados: " & Ds.Tables(0).Rows.Count, "Archivo ha sido producido")

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "Exportar_Campos:" & NomFile, ex.Message)
			Exit Sub
		End Try

	End Sub

	Private Sub LnkImportar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkImportar.LinkClicked
		If ValD(Me.Tag) = 2 Then
			Mensaje("Primero actualice o descarte los cambios que tiene en pantalla")
			Exit Sub
		End If

		Try
			If Not IO.File.Exists(NomFile) Then
				Mensaje(Idi("No existe archivo exportado") & ": " & NomFile)
				Exit Sub
			End If

			Dim Ds As New DataSet
			Ds.ReadXml(NomFile)


			If Fin(Ds.Tables(0)) Then
				Mensaje("Archivo totalmente vacío")
				Exit Sub
			End If

			Dim dt As DataTable = Filtrar_DataTable(Ds.Tables(0), "codigo='" & Prog & "'")

			If Fin(dt) Then
				Mensaje("Archivo no contiene campos para este programa, pertenece al programa: " & Gdf(Ds.Tables(0), "codigo"))
				Exit Sub
			End If
			Dim Registros As Integer = dt.Rows.Count

Repetir:
			Dim Que As String = Inputbox2("Cómo desea hacer la importación:" & DMScr(2) & "1 = Borrar definición actual e importar" & DMScr() &
																						 "2 = Importar solo objetos nuevos",
																						 "Registros en archivo a importar: " & Registros)
			If Que = "" Then
				Exit Sub
			End If
			If Que <> "1" And Que <> "2" Then
				Mensaje("Opción inválida")
				GoTo Repetir
			End If

			'If Not Pregunte("Seguro de importar archivo (" & dt.Rows.Count & " registros) reemplazando las definiciones actuales?") Then
			'	Exit Sub
			'End If

			Dim Sq As String = ""

			If Que = "1" Then
				Sq &= ArmeSQL("exec DelProgramasTitUno",
							 Numero_Empresa, qqNum,
							 Usuario, qqNum,
							 IdProg, qqNum)
			End If


			For Each Fi As DataRow In dt.Rows
				Sq &= ArmeSQL("exec PutProgramasTitUnoImport",
							  Numero_Empresa, qqNum,
							  Usuario, qqNum,
							  IdProg, qqNum,
							  Fi("campo"), qqTex,
							  Fi("titulo"), qqTex,
							  Fi("titulo_ant"), qqTex,
							  Fi("posx"), qqNum,
							  Fi("posy"), qqNum,
							  Fi("tamx"), qqNum,
							  Fi("tamy"), qqNum,
							  Fi("fore_color"), qqNum,
							  Fi("back_color"), qqNum,
							  Fi("ocultar"), qqNum,
							  Fi("font_name"), qqTex,
							  Fi("font_size"), qqNum,
							  Fi("font_bold"), qqNum,
							  Fi("font_italic"), qqNum
							  )
			Next

			Sq &= ArmeSQL("EXEC GetProgramasTitUno",
							Numero_Empresa, qqNum,
							IdProg, qqNum,
							Prefijo, qqTex)

			Sq &= ArmeSQL("Exec PutCotAuditoria",
						  144, qqNum,
						  Numero_Empresa, qqNum,
						  Usuario, qqNum,
						  IdProg, qqNum,
						  "Importó " & Registros & " campos", qqTex
						  )


			Dim DtRe As New DataTable
			Abrir(DtRe, Sq)

			Mostrar_Grid(DtRe, 0, Grd.Grid.FirstDisplayedScrollingRowIndex)
			Me.Tag = 0
			HuboCambios += dt.Rows.Count


			SonarWAV("OK")

			NoReloj()


		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "Importar_Campos:" & NomFile, ex.Message)
			Exit Sub
		End Try


	End Sub

	Private Sub fModificarCampos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
		If e.KeyCode = Keys.F5 Then
			If e.Control Then
				CmdSalvar.PerformClick()
			Else
				CmdActualizar.PerformClick()
			End If
		End If

	End Sub

	Private Sub LnkVerTodasColumnas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkVerTodasColumnas.LinkClicked
		CCols.Cambiar_Columnas("0280", Grd.Grid)

	End Sub

End Class