' Version: 695, 4-oct.-2018 12:56
' Version: 684, 25-ago.-2018 20:17
' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 610, 28-dic.-2017 13:49
' Version: 608, 21-dic.-2017 13:15
' Version: 607, 18-dic.-2017 13:01
' Version: 602, 1-dic.-2017 12:55
' Version: 601, 29-nov.-2017 12:05
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fFind_Exp

    Public DsOrigen As DataSet 'DataSet de origen, trae las tablas, campos y datos
    Dim DsArchivos As DataSet 'Trae todas las definiciones guardadas para el reporte
    Dim DtArchivos As DataTable 'todos los Encabezados
    Dim DtTablas As DataTable 'Todos las Tablas
    Dim DtTablasTemp As DataTable 'Temporal de Tablas de la definición cargada en pantalla
    Dim DtTablasBorrar As New DataTable 'Tablas que se van a borrar
    Dim DtCampos As DataTable 'Todos los Campos
    Dim DtCamposTemp As DataTable 'Temporal de Campos de la definiciòn cargada en pantalla
    Dim DtCamposGuardar As DataTable 'Campos que se van a guardar
    Dim DtCamposBorrar As New DataTable 'Campos que se van a borrar

    Private Sub fFind_Exp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_Idioma(Me, Me)

		AsignarImagenPrograma(PicInicio, 8)
		AsignarImagenPrograma(PicNuevo, 1033)
		AsignarImagenPrograma(PicEliminar, 2100)
		AsignarImagenPrograma(PicExportar, 2099)

		Cargar_tablas()

		CbJust.SelectedIndex = 0

	End Sub

	Private Sub Cargar_tablas()
		Dim i As Integer = 0
		Try
			For Each Tabl As DataTable In DsOrigen.Tables
				LstTablas1.Items.Add(i & " - " & Tabl.TableName)
				i = i + 1
			Next

			Llenar_Grid()

			GrdTablas.DMSLlene_Grid(DtTablasTemp, "id", False, {"id", "id_informes_archivo_plano"})
			GrdTablas.Grid.ClearSelection()

			GrdCampos.DMSLlene_Grid(DtCamposTemp, "id", False, {"id", "id_informes_archivo_plano_tablas", "tabla", "justificado", "id_informes_archivo_plano"})
			GrdCampos.Grid.Columns("campo").Width = 66
			GrdCampos.Grid.Columns("posicion").Width = 78
			GrdCampos.Grid.Columns("longitud").Width = 78
			GrdCampos.Grid.Columns("relleno").Width = 78
			GrdCampos.Grid.Columns("justificado").Width = 80
			GrdTablas.Grid.ClearSelection()

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "Cargar_tablas", ex.Message)

		End Try
	End Sub

	Private Sub Llenar_Grid()

		SiReloj()
		Abrir(DsArchivos, "Exec GetInformesArchivoPlano " & Numero_Empresa & "," & Me.Tag)
		NoReloj()
		DtArchivos = DsArchivos.Tables(0)
		DtTablas = DsArchivos.Tables(1)
		DtTablasTemp = Filtrar_DataTable(DtTablas, "id = -1")
		DtCampos = DsArchivos.Tables(2)
		DtCamposTemp = Filtrar_DataTable(DtCampos, "id = -1")
		DtCamposGuardar = Filtrar_DataTable(DtCampos, "id = -1")

		GrdFormatos.DMSLlene_Grid(DtArchivos, "id", False, {"id_informes"})
		GrdFormatos.Grid.Columns("id").Width = 70
		GrdFormatos.Grid.Columns("descripcion").Width = 120
		GrdFormatos.Grid.Columns("nombre").Width = 120
		GrdFormatos.Grid.Columns("notas").Width = 300

		LblMensaje.Visible = GrdFormatos.Grid.Rows.Count = 0

	End Sub

	Private Sub LstTablas1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstTablas1.SelectedIndexChanged

		If LstTablas1.SelectedIndex < 0 Then
			Exit Sub
		End If

		Dim Tabl As DataTable = DsOrigen.Tables(LstTablas1.SelectedIndex)
		Dim i As Integer = 0

		LstColumnas1.Items.Clear()
		For Each Co As DataColumn In Tabl.Columns
			LstColumnas1.Items.Add(i & " - " & Co.ColumnName)
			i = i + 1
		Next
		PnlCampos.Enabled = False
		Limpiar_Tabla()
		Limpiar_Campo()

	End Sub

	Private Sub LstTablas1_DoubleClick(sender As Object, e As EventArgs) Handles LstTablas1.MouseDoubleClick


		Dim Tabl As DataTable = DsOrigen.Tables(LstTablas1.SelectedIndex)
		GrbTipo.Text = "Tipo - " & DsOrigen.Tables(LstTablas1.SelectedIndex).TableName
		GrbTipo.Enabled = True
		CmdAdicTabla.Enabled = True
		CmdAdicTabla.Text = "Adicionar Tabla"
		LstColumnas1.Tag = Nothing
		CmdAdicTabla.Tag = ValD(LstTablas1.SelectedIndex)
		LstColumnas1.Enabled = True
		GrdCampos.Grid.DataSource = Filtrar_DataTable(DtCamposTemp, "id = -1")

		If GrdTablas.Grid.Rows.Count > 0 Then
			For Each fi As DataGridViewRow In GrdTablas.Grid.Rows
				If fi.Cells("tabla").Value = LstTablas1.SelectedIndex Then

					fi.Selected = True

					If Tm(GrdTablas.Grid, "separador").ToString <> "" Then
						RbSeparador.Checked = True
						TxtSeparador.Text = Tm(GrdTablas.Grid, "separador")

					Else
						RbPlano.Checked = True
						TxtSeparador.Text = ""
					End If

					CmdAdicTabla.Text = "Modificar"
					LstColumnas1.Tag = ValD(Tm(GrdTablas.Grid, "id"))
					CmdElimTabla.Enabled = True
					PnlCampos.Enabled = True

					Dim Dt As DataTable = Filtrar_DataTable(DtCamposTemp, "tabla = " & Tm(GrdTablas.Grid, "tabla"))

					GrdCampos.Grid.DataSource = Dt
					If Not Fin(Dt) Then
						For Each fi2 As DataRow In Dt.Rows
							LstColumnas1.SetSelected(fi2("campo"), True)
						Next
					End If
					Exit Sub

				End If
			Next
			'For i As Integer = 0 To GrdTablas.Grid.Rows.Count - 1
			'    If GrdTablas.Grid.Rows(i).Cells("tabla").Value = LstTablas1.SelectedIndex Then

			'        GrdTablas.Grid.Rows(i).Selected = True

			'        If ValD(Tm(GrdTablas.Grid, "separador")) > 0 Then
			'            RbSeparador.Checked = True
			'            TxtSeparador.Text = Tm(GrdTablas.Grid, "separador")

			'        Else
			'            RbPlano.Checked = True
			'            TxtSeparador.Text = ""
			'        End If

			'        CmdAdicTabla.Text = "Modificar"
			'        LstColumnas1.Tag = ValD(Tm(GrdTablas.Grid, "id"))
			'        CmdElimTabla.Enabled = True
			'        PnlCampos.Enabled = True

			'        Dim dt As DataTable = Filtrar_DataTable(DtCamposTemp, "tabla = " & Tm(GrdTablas.Grid, "tabla"))

			'        GrdCampos.Grid.DataSource = dt
			'        If Not Fin(dt) Then
			'            For Each fi As DataRow In dt.Rows
			'                LstColumnas1.SetSelected(fi("campo"), True)
			'            Next
			'        End If
			'        Exit Sub
			'    End If
			'Next
		End If

	End Sub

	Private Sub GrdTablas_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles GrdTablas.DMSTraerValor

		LstTablas1.SetSelected(Tm(GrdTablas.Grid, "tabla"), True)
		LstTablas1_DoubleClick(Sender, New EventArgs)

	End Sub


	Private Sub RbPlano_CheckedChanged(sender As Object, e As EventArgs) Handles RbPlano.CheckedChanged

		If RbPlano.Checked Then
			pnlSeparador.Visible = False
			TxtSeparador.Text = ""
		Else
			pnlSeparador.Visible = True
			pnlSeparador.BringToFront()
			TxtSeparador.Focus()
		End If

	End Sub

	Private Sub CmdElimTabla_Click(sender As Object, e As EventArgs) Handles CmdElimTabla.MouseClick

		If GrdTablas.Grid.Rows.Count > 0 Then

			If Not Pregunte("Desea elminiar esta tabla y todos sus campos de este formato de Archivo?", "Atención") Then
				Exit Sub
			Else

				For Each fi As DataRow In DtTablasTemp.Rows
					If fi("tabla") = LstTablas1.SelectedIndex Then
						If DtTablasBorrar.Rows.Count = 0 Then
							Dim id As New DataColumn("id")
							id.DataType = GetType(Integer)
							DtTablasBorrar.Columns.Add(id)
						End If
						DtCamposTemp = Filtrar_DataTable(DtCamposTemp, "tabla <> " & LstTablas1.SelectedIndex)
						If ValD(fi("id")) <> 0 Then
							DtTablasBorrar.Rows.Add(fi("id"))
						End If
						DtTablasTemp.Rows.Remove(fi)
						Limpiar_Campo()
						Limpiar_Tabla()
						Exit For
					End If
				Next


			End If

			'For i As Integer = 0 To GrdTablas.Grid.Rows.Count - 1
			'    If GrdTablas.Grid.Rows(i).Cells("tabla").Value = ValD(CmdAdicTabla.Tag) Then
			'            tabla = ValD(GrdTablas.Grid.Rows(i).Cells("id").Value)
			'            DtTablasTemp.Rows.RemoveAt(i)
			'        If DtTablasBorrar.Rows.Count = 0 Then
			'            Dim id As New DataColumn("id")
			'            id.DataType = GetType(Integer)
			'            DtTablasBorrar.Columns.Add(id)
			'        End If
			'        DtTablasBorrar.Rows.Add(tabla)
			'        Dim j As Integer = DtCamposTemp.Rows.Count - 1
			'        For k As Integer = 0 To DtCamposTemp.Rows.Count - 1
			'            If ValD(DtCamposTemp.Rows(j).Item("tabla")) = ValD(CmdAdicTabla.Tag) Then
			'                DtCamposTemp.Rows.RemoveAt(j)
			'            End If
			'            j = j - 1
			'        Next
			'        Limpiar_Campo()
			'        Limpiar_Tabla()
			'        Exit Sub
			'    End If
			'Next
		End If

	End Sub

	Private Sub GrdTablas_DMSTraerValorEliminar(Sender As Object, ValorColDevolver As Object, Fila As Integer) Handles GrdTablas.DMSTraerValorEliminar
		LstTablas1.SelectedIndex = Tm(GrdTablas.Grid, "tabla")
		CmdAdicTabla.Tag = Tm(GrdTablas.Grid, "tabla")
		CmdElimTabla_Click(Sender, New EventArgs)
	End Sub

	Private Sub CmdAdicTabla_Click(sender As Object, e As EventArgs) Handles CmdAdicTabla.MouseClick

		If RbSeparador.Checked Then
			If TxtSeparador.Text = "" Or TxtSeparador.Text.Length <> 1 Then
				Mensaje("Ingrese un Caracter para separarar los campos ")
				Exit Sub
			End If
		End If

		If GrdTablas.Grid.Rows.Count > 0 Then
			For i As Integer = 0 To GrdTablas.Grid.Rows.Count - 1
				If GrdTablas.Grid.Rows(i).Cells("tabla").Value = ValD(CmdAdicTabla.Tag) Then
					DtTablasTemp.Rows.RemoveAt(i)
				End If
			Next
		End If

		DtTablasTemp.Rows.Add(ValD(LstColumnas1.Tag), ValD(LblId.Text), LstTablas1.SelectedIndex, TxtSeparador.Text)
		Limpiar_Tabla()

	End Sub


	Private Sub LstColumnas1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstColumnas1.SelectedIndexChanged


		txtPosicion.Text = ""
		TxtLongCampo.Text = ""
		TxtRelleno.Text = ""
		CbJust.SelectedIndex = 0
		CmdAdicCampo.Enabled = True
		CmdAdicCampo.Text = "Adicionar"
		LblCampo.Text = "Campo: " & LstColumnas1.SelectedItem.ToString
		PnlCampos2.Enabled = True
		CmdAdicCampo.Tag = Nothing
		ChkAgrupa.Checked = False 'JFG-607

		If GrdCampos.Grid.Rows.Count > 0 Then

			For Each fi As DataGridViewRow In GrdCampos.Grid.Rows
				If fi.Cells("campo").Value = LstColumnas1.SelectedIndex Then

					fi.Selected = True

					txtPosicion.Text = Tm(GrdCampos.Grid, "posicion").ToString
					TxtLongCampo.Text = Tm(GrdCampos.Grid, "longitud").ToString
					TxtRelleno.Text = Tm(GrdCampos.Grid, "relleno").ToString
					CbJust.SelectedIndex = ValD(Tm(GrdCampos.Grid, "justificado"))
					CmdAdicCampo.Text = "Modificar"
					CmdAdicCampo.Tag = ValD(Tm(GrdCampos.Grid, "id"))
					CmdElimCampo.Enabled = True
					ChkAgrupa.Checked = IIf(Tm(GrdCampos.Grid, "agrupa") = "", False, True) 'JFG-607

					Exit Sub

				End If
			Next

			'For i As Integer = 0 To GrdCampos.Grid.Rows.Count - 1
			'    If GrdCampos.Grid.Rows(i).Cells("campo").Value = LstColumnas1.SelectedIndex Then

			'        GrdCampos.Grid.Rows(i).Selected = True

			'        txtPosicion.Text = Tm(GrdCampos.Grid, "posicion").ToString
			'        TxtLongCampo.Text = Tm(GrdCampos.Grid, "longitud").ToString
			'        TxtRelleno.Text = Tm(GrdCampos.Grid, "relleno").ToString
			'        CbJust.SelectedIndex = ValD(Tm(GrdCampos.Grid, "justificado"))
			'        CmdAdicCampo.Text = "Modificar"
			'        CmdAdicCampo.Tag = ValD(Tm(GrdCampos.Grid, "id"))
			'        CmdElimCampo.Enabled = True

			'        Exit Sub
			'    End If
			'Next
		End If

	End Sub

	Private Sub GrdCampos_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles GrdCampos.DMSTraerValor

		LstColumnas1.SetSelected(Tm(GrdCampos.Grid, "campo"), True)

	End Sub


	Private Sub CmdAdicCampo_Click(sender As Object, e As EventArgs) Handles CmdAdicCampo.MouseClick

		If LstColumnas1.SelectedIndex < 0 Then
			Mensaje("Seleccione el Campo que desea incluir")
			Exit Sub
		End If

		If ValD(TxtLongCampo.Text) = 0 Then
			Mensaje("Ingrese la Longitud del Campo")
			Exit Sub
		End If

		'JFG-607 Si ya existe campo de agrupación para la tabla y viene seleccionado, muestra mensaje y se sale
		Dim dt As DataTable
		If Not Fin(DtCamposTemp) And ChkAgrupa.Checked = True Then
			dt = Filtrar_DataTable(DtCamposTemp, "tabla=" & LstTablas1.SelectedIndex & " and isnull(agrupa,0) = 1")
		End If
		If Not Fin(dt) Then
			Mensaje("Ya existe un campo de agrupación para esta tabla")
			Exit Sub
		End If
		'JFG-607 Si ya existe campo de agrupación para la tabla y viene seleccionado, muestra mensaje y se sale

		If GrdCampos.Grid.Rows.Count > 0 Then
			For Each fi As DataRow In DtCamposTemp.Rows
				If fi("campo") = LstColumnas1.SelectedIndex And fi("tabla") = LstTablas1.SelectedIndex Then
					For Each fi2 As DataRow In DtCamposGuardar.Rows
						If fi2("campo") = LstColumnas1.SelectedIndex And fi2("tabla") = LstTablas1.SelectedIndex Then
							DtCamposGuardar.Rows.Remove(fi2)
							Exit For
						End If
					Next
					DtCamposTemp.Rows.Remove(fi)
					Exit For
				End If
			Next
		End If


		DtCamposTemp.Rows.Add(ValD(CmdAdicCampo.Tag), ValD(LstColumnas1.Tag), ValD(LstColumnas1.SelectedIndex), ValD(txtPosicion.Text), ValD(TxtLongCampo.Text), TxtRelleno.Text, ValD(CbJust.SelectedIndex), ValD(LstTablas1.SelectedIndex), IIf(ValD(CbJust.SelectedIndex) > 0, "Derecha", "Izquierda"), ValD(LblId.Text), ChkAgrupa.CheckState) 'JFG-607
		DtCamposGuardar.Rows.Add(ValD(CmdAdicCampo.Tag), ValD(LstColumnas1.Tag), ValD(LstColumnas1.SelectedIndex), ValD(txtPosicion.Text), ValD(TxtLongCampo.Text), TxtRelleno.Text, ValD(CbJust.SelectedIndex), ValD(LstTablas1.SelectedIndex), IIf(ValD(CbJust.SelectedIndex) > 0, "Derecha", "Izquierda"), ValD(LblId.Text), ChkAgrupa.CheckState) 'JFG-607

		DtCamposTemp = Filtrar_DataTable(DtCamposTemp, "", "tabla, campo")
		DtCamposGuardar = Filtrar_DataTable(DtCamposGuardar, "", "tabla, campo")

		Limpiar_Campo()

	End Sub

	Private Sub CmdElimCampo_Click(sender As Object, e As EventArgs) Handles CmdElimCampo.MouseClick

		If GrdCampos.Grid.Rows.Count > 0 Then
			For Each fi As DataRow In DtCamposTemp.Rows
				If fi("campo") = LstColumnas1.SelectedIndex And fi("tabla") = LstTablas1.SelectedIndex Then
					If DtCamposBorrar.Rows.Count = 0 Then

						Dim id As New DataColumn("id")
						id.DataType = GetType(Integer)
						DtCamposBorrar.Columns.Add(id)
					End If
					If ValD(fi("id")) <> 0 Then
						DtCamposBorrar.Rows.Add(ValD(fi("id")))
					End If
					DtCamposTemp.Rows.Remove(fi)
					Exit For
				End If
			Next
		End If

		Limpiar_Campo()

	End Sub

	Private Sub GrdCampos_DMSTraerValorEliminar(Sender As Object, ValorColDevolver As Object, Fila As Integer) Handles GrdCampos.DMSTraerValorEliminar
		LstColumnas1.SetSelected(Tm(GrdCampos.Grid, "campo"), True)
		CmdElimCampo_Click(Sender, New EventArgs)
	End Sub

	Private Function Hacer_Encabezado() As String

		Dim sql As String = ArmeSQL("exec PutInformesArchivoPlano @idplano out, ",
											LblId.Text, qqNum,
											Numero_Empresa, qqNum,
											Me.Tag, qqNum,
											TxtDescripcion.Text, qqTex,
											TxtNombre.Text, qqTex,
											TxtNotas.Text, qqTex
											)

		Return sql

	End Function

	Private Function Hacer_Tablas() As String

		If DtTablasTemp Is Nothing Then Return ""

		If DtTablasTemp.Rows.Count = 0 Then Return ""

		Dim sql As String = ""
		For Each fi As DataRow In DtTablasTemp.Rows
			sql &= ArmeSQL("exec PutInformesArchivoPlanoTablas @idTabla out, ",
																	"@idplano", qqCon,
																	fi("id"), qqNum,
																	fi("tabla"), qqNum,
																	fi("separador"), qqTex
																	)

			sql &= Hacer_Campos(ValD(fi("tabla")))

		Next

		Return sql

	End Function

	Private Function Borrar() As String

		Dim sql As String = ""

		If DtTablasBorrar.Rows.Count > 0 Then
			For Each fi As DataRow In DtTablasBorrar.Rows
				sql &= "exec DelInformesArchivoPlanoTablas " & ValD(fi("id")) & DMScr()
			Next
		End If

		If DtCamposBorrar.Rows.Count > 0 Then
			For Each fi As DataRow In DtCamposBorrar.Rows
				sql &= "exec DelInformesArchivoPlanoCampos " & ValD(fi("id")) & DMScr()
			Next
		End If

		Return sql

	End Function

	Private Function Hacer_Campos(ByVal tabla As Integer) As String

		If DtCamposGuardar Is Nothing Then Return ""

		If DtCamposGuardar.Rows.Count = 0 Then Return ""

		Dim dt As DataTable = Filtrar_DataTable(DtCamposGuardar, "tabla =" & tabla)

		Dim sql = ""
		If Not Fin(dt) Then
			For Each fi As DataRow In dt.Rows
				sql &= ArmeSQL("exec PutInformesArchivoPlanoCampos @idtabla, ",
															fi("id"), qqNum,
															fi("campo"), qqNum,
															fi("posicion"), qqNum,
															fi("longitud"), qqTex,
															fi("relleno"), qqTex,
															fi("justificado"), qqNum,
															fi("agrupa"), qqBol 'JFG-607
															)
			Next
		End If

		Return sql

	End Function

	Private Sub Limpiar()

		LblId.Text = ""
		TxtDescripcion.Text = ""
		TxtNombre.Text = ""
		TxtNotas.Text = ""

		LstTablas1.ClearSelected()
		DtTablasTemp.Clear()
		DtTablasBorrar.Clear()
		GrdTablas.Grid.DataSource = DtTablasTemp
		GrbTipo.Enabled = False
		TxtSeparador.Text = ""
		CmdAdicTabla.Text = "Adicionar"
		CmdAdicTabla.Enabled = False
		CmdAdicTabla.Tag = Nothing

		LstColumnas1.Tag = Nothing
		LstColumnas1.Items.Clear()
		DtCamposTemp.Clear()
		DtCamposGuardar.Clear()
		DtCamposBorrar.Clear()
		GrdCampos.Grid.DataSource = DtCamposTemp
		TxtLongCampo.Text = ""
		txtPosicion.Text = ""
		TxtRelleno.Text = ""
		CbJust.SelectedIndex = 0
		ChkAgrupa.Checked = False 'JFG-607

		CmdGuardar.Text = Idi("Guardar")

	End Sub

	Private Sub Limpiar_Tabla()

		GrdTablas.Grid.DataSource = DtTablasTemp
		GrbTipo.Enabled = False
		GrbTipo.Text = "Tipo"
		TxtSeparador.Text = ""
		CmdAdicTabla.Text = "Adicionar"
		CmdAdicTabla.Tag = Nothing
		CmdAdicTabla.Enabled = False
		CmdElimTabla.Enabled = False
		LstColumnas1.Tag = Nothing
		GrbTipo.Enabled = False
		CmdElimTabla.Enabled = False

	End Sub

	Private Sub Limpiar_Campo()
		Dim Dt As DataTable = Filtrar_DataTable(DtCamposTemp, "tabla = " & ValD(LstTablas1.SelectedIndex))
		GrdCampos.Grid.DataSource = Dt
		TxtLongCampo.Text = ""
		txtPosicion.Text = ""
		TxtRelleno.Text = ""
		CbJust.SelectedIndex = 0
		CmdAdicCampo.Tag = Nothing
		CmdAdicCampo.Enabled = False
		CmdElimCampo.Enabled = False
		LblCampo.Text = "Campo:  "
		PnlCampos2.Enabled = False
		ChkAgrupa.Checked = False 'JFG-607
	End Sub


	Private Function Crear_Archivo(ByVal fileName As String, ByVal DsOrigen As DataSet) As Boolean

		If (fileName = "") Then
			Mensaje("No se a especificado el nombre de Archivo")
			Return False
		End If
		If DtCamposTemp Is Nothing Or Fin(DtCamposTemp) Then
			Mensaje("No hay información para generar el Archivo")
			Return False
		End If

		If IO.File.Exists(fileName) Then
			If IO.File.Exists(fileName) Then
				If Not Pregunte("Ya existe un archivo de texto con el mismo nombre." & DMScr() & "Desea sobrescribirlo?",) Then
					Return False
				End If
			End If
		End If

		Dim sw As System.IO.StreamWriter

		Try

			Dim campo As String = ""
			Dim linea As String = ""
			Dim datos As String = ""
			Dim separador As String = ""

			Dim DtAgrupa As DataTable = Filtrar_DataTable(DtCamposTemp, "tabla = 0 and agrupa = true")
			Dim EncaAgrupa As Integer
			If Not Fin(DtAgrupa) Then
				EncaAgrupa = Gdf(DtAgrupa, "campo")
			End If
			Dim EncaAgrupaDato As String

			If Fin(DtAgrupa) Or DsOrigen.Tables.Count = 1 Then

				For i As Integer = 0 To DsOrigen.Tables.Count - 1

					For j As Integer = 0 To DsOrigen.Tables(i).Rows.Count - 1

						For Each fi As DataRow In DtCamposTemp.Rows

							If i = fi("tabla") Then
								campo = DsOrigen.Tables(fi("tabla")).Rows(j).Item(fi("campo")).ToString
								campo = Mid(campo, IIf(ValD(fi("posicion")) = 0, 1, ValD(fi("posicion"))), campo.ToString.Length)

								If ValD(fi("justificado")) = 0 Then
									campo = campo.PadRight(ValD(fi("longitud")), fi("relleno").ToString)
								Else
									campo = campo.PadLeft(ValD(fi("longitud")), fi("relleno").ToString)
								End If

								separador = Gdf(Filtrar_DataTable(DtTablasTemp, "tabla = " & i), "separador").ToString

								linea &= campo & separador

							End If
						Next

						If separador <> "" Then
							linea = Mid(linea, 1, linea.ToString.Length - 1)
						End If

						datos &= linea & DMScr()
						campo = ""
						linea = ""
						separador = ""

					Next
				Next
			Else

				Dim DtEncabezado As DataTable = Filtrar_DataTable(DtCamposTemp, "tabla = 0")
				If Fin(DtEncabezado) Then
					Mensaje("La tabla de encabezado no esta incluida para hacer agrupación")
					Return False
				End If


				Dim DtDetalle As DataTable = Filtrar_DataTable(DtCamposTemp, "tabla <> 0")
				Dim DtDetalleAgrupado As DataTable
				Dim DetAgrupa As Integer
				Dim DetAgrupaDato As String
				Dim dt As DataTable

				For f As Integer = 0 To DsOrigen.Tables(0).Rows.Count - 1
					For Each fi As DataRow In DtEncabezado.Rows

						campo = DsOrigen.Tables(fi("tabla")).Rows(f).Item(fi("campo")).ToString
						campo = Mid(campo, IIf(ValD(fi("posicion")) = 0, 1, ValD(fi("posicion"))), campo.ToString.Length)

						If ValD(fi("justificado")) = 0 Then
							campo = campo.PadRight(ValD(fi("longitud")), fi("relleno").ToString)
						Else
							campo = campo.PadLeft(ValD(fi("longitud")), fi("relleno").ToString)
						End If

						dt = Filtrar_DataTable(DtTablasTemp, "tabla = " & f)
						If Not Fin(dt) Then
							separador = Gdf(dt, "separador").ToString
						Else
							separador = ""
						End If

						linea &= campo & separador

						If separador <> "" Then
							linea = Mid(linea, 1, linea.ToString.Length - 1)
						End If

					Next

					datos &= linea & DMScr()
					campo = ""
					linea = ""
					separador = ""
					EncaAgrupaDato = DsOrigen.Tables(0).Rows(f).Item(EncaAgrupa).ToString

					For i As Integer = 1 To DsOrigen.Tables.Count - 1

						DtDetalleAgrupado = Filtrar_DataTable(DtDetalle, "tabla = " & i & " and agrupa = True")
						If Not Fin(DtDetalleAgrupado) Then
							DetAgrupa = Gdf(DtDetalleAgrupado, "campo")
						Else
							DetAgrupa = -1
						End If

						For j As Integer = 0 To DsOrigen.Tables(i).Rows.Count - 1

							If DetAgrupa <> -1 Then
								DetAgrupaDato = DsOrigen.Tables(i).Rows(j).Item(DetAgrupa).ToString
							Else
								DetAgrupaDato = EncaAgrupaDato
							End If

							For Each fi2 As DataRow In DtDetalle.Rows

								If i = fi2("tabla") And DetAgrupaDato = EncaAgrupaDato Then
									campo = DsOrigen.Tables(fi2("tabla")).Rows(j).Item(fi2("campo")).ToString
									campo = Mid(campo, IIf(ValD(fi2("posicion")) = 0, 1, ValD(fi2("posicion"))), campo.ToString.Length)

									If ValD(fi2("justificado")) = 0 Then
										campo = campo.PadRight(ValD(fi2("longitud")), fi2("relleno").ToString)
									Else
										campo = campo.PadLeft(ValD(fi2("longitud")), fi2("relleno").ToString)
									End If

									separador = Gdf(Filtrar_DataTable(DtTablasTemp, "tabla = " & i), "separador").ToString

									linea &= campo & separador

								End If

							Next

							If linea <> "" And DetAgrupaDato = EncaAgrupaDato Then
								If separador <> "" Then
									linea = Mid(linea, 1, linea.ToString.Length - 1)
								End If
								datos &= linea & DMScr()
							End If

							campo = ""
							linea = ""
							separador = ""

						Next
					Next
				Next



			End If

			datos = datos.ToString.Trim

			sw = New System.IO.StreamWriter(fileName)
			sw.Write(datos)
			sw.Close()
			Return True

		Catch ex As Exception
			sw = Nothing
			MostrarError(Me.Name, "Crear_Archivo", ex.Message)
			Return False
		End Try

	End Function

	Private Sub CmdGuardar_DMSClick(Sender As Object) Handles CmdGuardar.DMSClick

		If TxtDescripcion.Text = "" Then
			Mensaje("Ingrese la Descripción")
			Exit Sub
		End If

		If TxtNombre.Text = "" Then
			Mensaje("Ingrese el Nombre del Archivo")
			Exit Sub
		End If

		Dim sql As String = ""

		sql &= "Begin Try" & DMScr()
		sql &= "Begin Transaction" & DMScr()
		sql &= "Declare @IdPlano int" & DMScr()
		sql &= "Declare @IdTabla int" & DMScr()

		sql &= Borrar()

		sql &= Hacer_Encabezado()

		sql &= Hacer_Tablas()

		sql &= "Commit Transaction" & DMScr()
		sql &= "End Try" & DMScr()
		sql &= "Begin Catch" & DMScr()
		sql &= "   Declare @proc varchar(150)" & DMScr()
		sql &= "   Declare @lin int" & DMScr()
		sql &= "   Declare @mens varchar(200)" & DMScr()
		sql &= "   Declare @tex varchar(300)" & DMScr()
		sql &= "   Rollback transaction" & DMScr()
		sql &= "   Select  @proc=ERROR_PROCEDURE()," & DMScr()
		sql &= "           @lin=ERROR_LINE()," & DMScr()
		sql &= "           @Mens=ERROR_MESSAGE()" & DMScr()
		sql &= "   set @tex=cast(@lin as varchar) +' - '+@proc+' - '+@Mens" & DMScr()
		sql &= "   RAISERROR ( @tex,16,1)" & DMScr()
		sql &= "End Catch" & DMScr() & DMScr()

		Dim dt As New DataTable

		Try

			SiReloj()
			Abrir(dt, sql)
			NoReloj()
			Llenar_Grid()

		Catch ex As Exception

			NoReloj()
			If ex.Message.Contains("duplicada") Then
				Mensaje("La descripción ingresada ya existe")
				Exit Sub
			End If
			MostrarError(Me.Name, "CmdGuardar_Click", ex.Message)
			Exit Sub

		End Try

		'  PongaIndex(CbArchivos, -1)
		'  CbArchivos.Text = ""
		Limpiar()
		TabControl.SelectedTab = TbFormatos
		SonarWAV("ok")

	End Sub

	Private Sub GrdFormatos_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles GrdFormatos.DMSTraerValor

		Cargar_Formato(ValorColDevolver)
		TabControl.SelectedTab = TbCreacion

	End Sub

	Private Sub PicEliminar_Click(sender As Object, e As EventArgs) Handles PicEliminar.Click
		Dim id As Integer = 0
		If TabControl.SelectedTab Is TbCreacion Then
			If LblId.Text = "" Then
				Mensaje("Debe cargar un formato para eliminar")
				Exit Sub
			Else
				id = ValD(LblId.Text)
			End If
		Else
			If GrdFormatos.Grid.SelectedRows(0).Index < 0 Then
				Mensaje("Debe seleccionar un formato en el grid para eliminar")
				Exit Sub
			Else
				id = ValD(Tm(GrdFormatos.Grid, "id"))
			End If
		End If

		If Not Pregunte("Esta seguro que desea Eliminar este formato?", "Atención") Then
			Exit Sub
		Else
			Try

				SiReloj()
				Dim dt As New DataTable
				Abrir(dt, "Exec DelInformesArchivoPlano " & id)
				NoReloj()
				Limpiar()
				Llenar_Grid()
				SonarWAV("ok")

			Catch ex As Exception
				NoReloj()
				MostrarError(Me.Name, "ElimArchivo_Click", ex.Message)
			End Try
		End If
	End Sub

	Private Sub PicNuevo_Click(sender As Object, e As EventArgs) Handles PicNuevo.Click

		Limpiar()
		If TabControl.SelectedTab Is TbFormatos Then
			TabControl.SelectedIndex = 1
		End If

	End Sub

	Private Sub PicExportar_Click(sender As Object, e As EventArgs) Handles PicExportar.Click

		If TabControl.SelectedTab Is TbCreacion Then
			If LblId.Text = "" Then
				Mensaje("Debe cargar un formato para exportar")
				Exit Sub
			End If
		Else
			If GrdFormatos.Grid.SelectedRows(0).Index < 0 Then
				Mensaje("Debe seleccionar un formato en el grid para exportar")
				Exit Sub
			Else
				Cargar_Formato(ValD(Tm(GrdFormatos.Grid, "id")))
			End If
		End If

		Dim sf As New SaveFileDialog

		sf.Filter = "Archivo de texto(*.txt)|*.txt;"
		sf.FileName = TxtNombre.Text & ".txt"

		Dim Ruta As String = sf.FileName
		sf.Dispose()

		If Crear_Archivo(Ruta, DsOrigen) Then
			Mensaje("Archivo Generado Exitosamente")
		Else
			Mensaje("Se presento un error al crear el archivo", "Atención")
		End If
	End Sub

	Private Sub Cargar_Formato(ByVal id As Integer)

		If ValD(id) = 0 Then Exit Sub

		Dim Dt As DataTable = Filtrar_DataTable(DtArchivos, "id = " & ValD(id))
		LblId.Text = ValD(Gdf(Dt, "id"))
		TxtDescripcion.Text = Gdf(Dt, "descripcion").ToString
		TxtNombre.Text = Gdf(Dt, "nombre").ToString
		TxtNotas.Text = Gdf(Dt, "notas").ToString
		CmdGuardar.Text = "Modificar"

		DtTablasTemp = Filtrar_DataTable(DtTablas, "id_informes_archivo_plano = " & ValD(id))
        GrdTablas.Grid.DataSource = DtTablasTemp

        For Each fi As DataRow In DtTablasTemp.Rows
            LstTablas1.SetSelected(fi("tabla"), True)
        Next

        DtCamposTemp = Filtrar_DataTable(DtCampos, "id_informes_archivo_plano = " & ValD(id))

    End Sub

End Class