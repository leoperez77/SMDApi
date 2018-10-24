' Version: 685, 28-ago.-2018 12:08
' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 678, 16-ago.-2018 14:15
' Version: 675, 14-ago.-2018 18:45
' Version: 668, 23-jul.-2018 13:18
' Version: 667, 19-jul.-2018 12:57
' Version: 666, 17-jul.-2018 13:12
' Version: 665, 16-jul.-2018 13:20
' Version: 663, 12-jul.-2018 12:54
' Version: 662, 11-jul.-2018 13:06
' Version: 661, 10-jul.-2018 13:27
' Version: 597, 14-nov.-2017 14:55
'♥ versión: 587, 11-oct.-2017 11:31
'♥ versión: 586, 6-oct.-2017 07:11
Imports System.Text
Imports System.IO
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
'Imports System.EnterpriseServices

<System.ComponentModel.DefaultEvent("DMSTraerValor")>
Public Class GridDms
	Dim w_NombreColDevolver As String = ""
	Dim w_ContadorLineas As Boolean = False
	Dim w_ColOcultas As Array = Nothing
	Dim w_ColModificables As Array = Nothing
	Dim w_ColMoneda As Array = Nothing
	Dim w_ColForzar As Array = Nothing
	Dim w_Lineas As Boolean = True
	Dim w_MostrarAbrir As Boolean = True
	Dim w_MostrarEliminar As Boolean = True
	Dim w_ColMaxLen As ArrayList = Nothing
	Dim w_SQLRefrescar As String = ""

	Dim MyDataGridViewPrinter As DataGridViewPrinter

	'Public TituloInforme As String = ""

	Public Event DMSOrdenarColumna(ByVal Sender As Object, ByVal e As EventArgs)
	Public Event DMSMouseUp(IniciaSel As Integer, CuantasSel As Integer)
	Public Event DMSMouseDown()
	Public DMSPersonalizarGrid As Boolean = True

	Public Event DMSTraerValor(ByVal Sender As Object, ByVal ValorColDevolver As Object)
	Public Event DMSTraerValorOtro(ByVal Sender As Object, ByVal ValorColDevolver As Object)
	Public Event DMSTraerValorOtro2(ByVal Sender As Object, ByVal ValorColDevolver As Object)
	Public Event DMSTraerValorOtro3(ByVal Sender As Object, ByVal ValorColDevolver As Object)
	Public Event DMSTraerValorOtro0(ByVal Sender As Object, ByVal ValorColDevolver As Object)
	Public Event DMSCellClick(ByVal Sender As Object, ByVal ValorColDevolver As Object)
	Public Event DMSCellClick2(ByVal Sender As Object, ByVal ValorColDevolver As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
	Public Event DMSTraerValorEliminar(ByVal Sender As Object, ByVal ValorColDevolver As Object, ByVal Fila As Integer)
	Public Event DMSEntrarEdicionCelda(ByVal Sender As Object,
									   ByVal NombreCol As String,
									   ByRef ValorCelda As Object,
									   ByVal ColDevolver As Integer,
									   ByVal e As DataGridViewCellCancelEventArgs
									   )

	Public Event DMSSalidaEdicionCelda(ByVal Sender As Object, ByVal NombreCol As String,
									   ByRef ValorCelda As Object,
									   ByVal ColDevolver As Integer)
	Public Event DMSUltimaCelda(ByVal Sender As Object, ByVal e As EventArgs)
	'Public Event DMSRefrescar(ByVal Sender As Object, ByVal e As EventArgs)

	Dim NombreCol As String
	Dim Fila As Integer = 0
	Dim Col As Integer = 0
	Dim OrdenCol As Integer = 0
	Dim ActivarSetingCol As Boolean = False

	Public DtEliminados As New DataTable
	Dim Eliminados As New ArrayList
	Dim MaxLen As New ArrayList
	Dim YaEntre As Boolean = False
	Dim Tam As Integer = 0
	Dim _DMSCopiarDt As Boolean = True
	Dim _DMSTituloDelInforme As String = ""
	Dim YaEstaElArchivo As String = ""

	Public Property DMSCopiarDt() As Boolean
		Get
			Return _DMSCopiarDt
		End Get
		Set(ByVal value As Boolean)
			_DMSCopiarDt = value
		End Set
	End Property
	Public Property DMSTituloDelInforme() As String
		Get
			Return _DMSTituloDelInforme
		End Get
		Set(ByVal value As String)
			_DMSTituloDelInforme = value
		End Set
	End Property


	Public Sub DMSOrdenarxColumna(ByVal NombreCol As String, ByVal Orden As System.ComponentModel.ListSortDirection)
		Grid.Sort(Grid.Columns(NombreCol), Orden)
	End Sub


	Public Function DMSDevolverValorCelda(Optional ByVal NombreColumna As String = "") As Object
		If Not ValidarSeleccion() Then
			Return Nothing
		Else
			Return Grid.Rows(Grid.CurrentCell.RowIndex).Cells(IIf(NombreColumna = "", NombreCol, NombreColumna)).Value
		End If
	End Function
	Public Sub DMSMostrar_Fila_Seleccionada(Grid As DataGridView, CampoComparar As String, ValorComparar As VariantType, Optional CantidadLineas As Integer = 4)

		Try
			For I As Integer = 0 To Grid.Rows.Count - 1
				If Tm(Grid, CampoComparar, I) = ValorComparar Then
					Grid.Rows(I).Selected = True
					Grid.FirstDisplayedScrollingRowIndex = I - CantidadLineas 'el 4 es para que deje 4 líneas arriba
					Exit For
				End If
			Next
		Catch
		End Try

	End Sub
	Public Sub DMSMostrar_Fila_Seleccionada2(CampoComparar As String, TextoComparar As String, Optional CantidadLineas As Integer = 4)
		Try
			For Each Fi As DataGridViewRow In Grid.Rows
				If Fi.Cells(CampoComparar).Value.ToString = TextoComparar Then
					Fi.Selected = True
					Grid.FirstDisplayedScrollingRowIndex = Fi.Index - IIf(CantidadLineas < Fi.Index, CantidadLineas, 0) 'el 4 es para que deje 4 líneas arriba
					Exit For
				End If
			Next

		Catch ex As Exception

		End Try

	End Sub

	Private Function ValidarSeleccion() As Boolean
		Dim Mens As String = ""
		If Grid.Rows.Count > 0 Then
			If Grid.CurrentCell Is Nothing And Grid.SelectedRows.Count = 0 Then
				Mens &= "Debe seleccionar un fila"
			End If
		Else
			Mens &= "No hay filas en el grid"
		End If

		If Mens <> "" Then
			MsgBox(Mens)
		Else
			Return True
		End If
	End Function


	Public Function DMSDevolverFilaSeleccionada() As Integer
		Grid.Focus()
		If Grid.RowCount = 0 Then Return -1
		Return Grid.CurrentCell.RowIndex
	End Function

	Dim NoEntreDiseno As Boolean = False
	Public Sub DMSAgregarCol(ByVal Columna As DataGridViewColumn)

		NoEntreDiseno = True
		If Not Grid.Columns.Contains(Columna.Name) Then
			Grid.Columns.Add(Columna)

		End If


	End Sub
	Public Sub DMSAgregarCol(ByVal NombreColumna As String, ByVal HeaderColumna As String)
		Grid.Columns.Add(NombreColumna, HeaderColumna)
	End Sub

	Public Function DMSDevolverDtEliminados() As DataTable
		Return DtEliminados
	End Function
	Public Function DMSDevolverDt() As DataTable
		Return Grid.DataSource
	End Function
	Public Sub DMSSeleccionarFila(ByVal Fila As Integer)

		Grid.Rows(Fila).Selected = True
		Try
			Grid.CurrentCell = Grid.Rows(Fila).Cells(Grid.CurrentCell.ColumnIndex)
		Catch ex As Exception

		End Try
	End Sub
	Public Sub DMSTitulo_Campo(Campo As String, Optional Titulo As String = "", Optional Ancho As Integer = -1, Optional Alineacion As Short = -1, Optional EsVisible As Boolean = True)
		Try
			Titulo = Idi(Titulo)

			If Not Grid.Columns.Contains(Campo) Then Exit Sub

			If Ancho >= 0 Then
				Try
					Grid.Columns(Campo).Width = Ancho
				Catch
				End Try
			End If
			Grid.Columns(Campo).HeaderText = IIf(Titulo = "", Campo, Titulo)
			If Alineacion > 0 Then
				Dim Ali As DataGridViewContentAlignment
				Select Case Alineacion
					Case 1 : Ali = DataGridViewContentAlignment.MiddleLeft
					Case 2 : Ali = DataGridViewContentAlignment.MiddleCenter
					Case Else : Ali = DataGridViewContentAlignment.MiddleRight
				End Select
				Grid.Columns(Campo).HeaderCell.Style.Alignment = Ali
				Grid.Columns(Campo).DefaultCellStyle.Alignment = Ali
				Grid.Columns(Campo).Visible = EsVisible
			End If

		Catch ex As Exception

		End Try

	End Sub


	Public Sub DMSLlene_Grid(ByVal Dt As DataTable,
							 Optional ByVal NombreColDevolver As String = "",
							 Optional ByVal ContadorLineas As Boolean = False,
							 Optional ByVal ColOcultas As Array = Nothing,
							 Optional ByVal ColModificables As Array = Nothing,
							 Optional ByVal ColMoneda As Array = Nothing,
							 Optional ByVal ColForzar As Array = Nothing,
							 Optional ByVal Lineas As Boolean = True,
							 Optional ByVal MostrarAbrir As Boolean = True,
							 Optional ByVal MostrarEliminar As Boolean = True,
							 Optional ByVal ColMaxLen As ArrayList = Nothing,
							 Optional ByVal SQLRefrescar As String = "",
							 Optional ByVal AjustarColumnas As Boolean = False,
							 Optional ByVal OcultarOpcionesEnviar As Boolean = False,
							 Optional ByVal SeleccionarPrimeraFila As Boolean = True,
							 Optional ByVal ColWrap As Array = Nothing
							 )

		Try
			RemoveHandler Grid.ColumnWidthChanged, AddressOf Grid_ColumnWidthChanged 'SGQ-664
			RemoveHandler Grid.ColumnDisplayIndexChanged, AddressOf Grid_ColumnDisplayIndexChanged 'SGQ-664

			Grid.DataSource = Nothing


			CmdEnviarUsuario.Visible = Not OcultarOpcionesEnviar
			CmdEnviarMail.Visible = Not OcultarOpcionesEnviar

			EnumerarToolStripMenuItem.Enabled = True
			'JDMS 3-NOV-2010 'para poder mandar por parametros que ajuste las columnas obligatoriamente
			If AjustarColumnas Then
				AjustarColumnasToolStripMenuItem.Tag = 1
			End If

			'para refrescar
			w_NombreColDevolver = NombreColDevolver
			w_ContadorLineas = ContadorLineas
			w_ColOcultas = ColOcultas
			w_ColModificables = ColModificables
			w_ColMoneda = ColMoneda
			w_ColForzar = ColForzar
			w_Lineas = Lineas
			w_MostrarAbrir = MostrarAbrir
			w_MostrarEliminar = MostrarEliminar
			w_ColMaxLen = ColMaxLen
			w_SQLRefrescar = SQLRefrescar
			'fin refrescar

			RemoveHandler Grid.CellValueChanged, AddressOf Grid_CellValueChanged
			Eliminados = New ArrayList
			DtEliminados = New DataTable
			Dim Fila As Integer = 0
			Grid.Focus()

			If DMSCopiarDt Then
				Grid.DataSource = Dt.Copy
			Else
				Grid.DataSource = Dt
			End If


			If Grid.CurrentCell IsNot Nothing Then
				Fila = Val("" & Grid.CurrentCell.RowIndex)
				Grid.CurrentCell.Selected = True
			ElseIf Grid.RowCount > 0 Then
				Try
					Grid.CurrentCell = Grid.Rows(0).Cells(0)
				Catch ex As Exception

				End Try
			End If
			NombreCol = NombreColDevolver

			AbrirToolStripMenuItem.Visible = MostrarAbrir
			ToolStripSeparator3.Visible = MostrarAbrir

			If NombreColDevolver = "" Then
				AbrirToolStripMenuItem.Visible = False
				EliminarToolStripMenuItem.Visible = False
				ToolStripSeparator3.Visible = False
			End If



			ToolStripSeparator1.Visible = MostrarEliminar
			'ToolStripSeparator2.Visible = MostrarEliminar
			EliminarToolStripMenuItem.Visible = MostrarEliminar

			'lo quito porque no se como usarlo, jd 27-oct-2016
			DeshacerToolStripMenuItem.Visible = False ' MostrarEliminar

			CmdRefrescarSeparador.Visible = SQLRefrescar <> ""
			CmdRefrescar.Visible = SQLRefrescar <> ""
			'CmdRefrescar.Enabled = SQLRefrescar <> ""

			For J = 0 To Grid.Columns.Count - 1
				Grid.Columns(J).Visible = True
				If LenguajeAdvance = 1 Then
					Try
						Grid.Columns(J).HeaderText = Idi(Grid.Columns(J).HeaderText)
					Catch
					End Try
				End If
			Next

			If ContadorLineas Then
				Contador()
			Else
				Grid.RowHeadersVisible = False
			End If

			If ColForzar IsNot Nothing Then
				If ColForzar.Length > 0 Then
					For I = 0 To ColForzar.Length - 1
						Try
							Grid.Columns(ColForzar(I).ToString).Frozen = True
						Catch
						End Try
					Next
				End If
			End If


			'esta es la forma ideal de recorrer los arrays
			If ColOcultas IsNot Nothing Then
				If ColOcultas.Length > 0 Then
					'si la primera es un * entonces ocultar todas y solo mostrar las de la lista
					Dim Hacer As Boolean = False
					If ColOcultas(0).ToString = "*" Then
						Hacer = True
						'ocultar tadas primeramente
						For I = 0 To Grid.Columns.Count - 1
							Try
								Grid.Columns(I).Visible = False
							Catch
							End Try
						Next
					End If
					'mostrar/ocultar
					For I = 0 To ColOcultas.Length - 1
						Try
							If ColOcultas(I).ToString <> "" Then
								Grid.Columns(ColOcultas(I).ToString).Visible = Hacer
							End If
						Catch
						End Try
					Next
				End If
			End If

			'columnas que se puede partir el renglón
			If ColWrap IsNot Nothing Then
				If ColWrap.Length > 0 Then
					Dim EstiloW As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
					EstiloW.WrapMode = System.Windows.Forms.DataGridViewTriState.True
					'esta es la forma ideal de recorrer los arrays
					For I = 0 To ColWrap.Length - 1
						Try
							Grid.Columns(ColWrap(I).ToString).DefaultCellStyle = EstiloW
						Catch
						End Try
						'For J = 0 To Grid.Columns.Count - 1
						'    If Grid.Columns(J).Name.ToLower = ColWrap(I).ToString.ToLower Then
						'        Grid.Columns(J).DefaultCellStyle = EstiloW
						'    End If
						'Next
					Next
					Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
					'CambiarAltoDeFilas.Checked = True
					'Grid.AllowUserToResizeRows = True
				End If
			End If

			For J = 0 To Grid.Columns.Count - 1
				Grid.Columns(J).DefaultCellStyle.BackColor = Grid.DefaultCellStyle.BackColor
			Next

			DisenoCeldas()
			If ColModificables IsNot Nothing Then
				If ColModificables.Length > 0 Then
					Grid.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
					Grid.ReadOnly = False

					For I = 0 To ColModificables.Length - 1
						For J = 0 To Grid.Columns.Count - 1
							If I = 0 Then
								Grid.Columns(J).ReadOnly = True
							End If
							If SinTildes(Grid.Columns(J).Name).ToLower = SinTildes(ColModificables(I).ToString).ToLower Then
								Grid.Columns(J).DefaultCellStyle.BackColor = Color.PapayaWhip
								'Grid.Columns(J).DefaultCellStyle.SelectionBackColor = Color.Tan

								Grid.Columns(J).ReadOnly = False
							End If
						Next
					Next
					AddHandler Grid.CurrentCellChanged, AddressOf Grid_CurrentCellChanged
				End If

			Else
				Grid.ReadOnly = True
			End If

			'TODO: ver si se justifica quitar las lineas
			If Not Lineas Then
				Grid.CellBorderStyle = DataGridViewCellBorderStyle.None
			ElseIf Grid.CellBorderStyle = DataGridViewCellBorderStyle.None Then
				Grid.CellBorderStyle = DataGridViewCellBorderStyle.Single
			End If

			ValidarEnumaracion()
			'Grid.ClearSelection()

			If PequeñoToolStripMenuItem.Checked Then
				Grid.Font = PequeñoToolStripMenuItem.Font
			End If
			If NormalToolStripMenuItem.Checked Then
				Grid.Font = Me.Font
			End If
			If GrandeToolStripMenuItem.Checked Then
				Grid.Font = GrandeToolStripMenuItem.Font
			End If


			For I = 0 To Dt.Columns.Count - 1
				If Dt.Columns(I).DataType Is System.Type.GetType("System.Decimal") Then
					'If LCase(Dt.Columns(I).ColumnName) Like "*precio*" Or LCase(Dt.Columns(I).ColumnName) Like "*valor*" Or LCase(Dt.Columns(I).ColumnName) Like "*costo*" Then
					'    Grid.Columns(I).DefaultCellStyle.Format = "C"
					'Else
					'    Grid.Columns(I).DefaultCellStyle.Format = "N"
					'End If
					Grid.Columns(I).DefaultCellStyle.Format = "N"
					Grid.Columns(I).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
					'ElseIf Dt.Columns(I).DataType Is System.Type.GetType("System.DateTime") Then
					'    Grid.Columns(I).DefaultCellStyle.Format = "d-MMM-yyyy HH:mm:ss"
					'    Grid.Columns(I).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				ElseIf Dt.Columns(I).DataType Is System.Type.GetType("System.DateTime") Or
						Dt.Columns(I).DataType Is System.Type.GetType("System.Int16") Or
						Dt.Columns(I).DataType Is System.Type.GetType("System.Int32") _
						Then
					Grid.Columns(I).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				End If
			Next

			If ColMoneda IsNot Nothing Then
				If ColMoneda.Length > 0 Then

					For I = 0 To ColMoneda.Length - 1
						For J = 0 To Grid.Columns.Count - 1
							Dim NomCol As String = ColMoneda(I).ToString.ToLower
							Dim FmtM As String = "C"
							If Strings.Left(NomCol, 1) = "*" Then 'sin centavos
								FmtM = "C0"
								NomCol = Strings.Mid(NomCol, 2)
							ElseIf Strings.Left(NomCol, 1) = "!" Then 'con 4 decimales
								FmtM = "C4"
								NomCol = Strings.Mid(NomCol, 2)
							End If
							If Grid.Columns(J).Name.ToLower = NomCol Then
								'Grid.Columns(J).DefaultCellStyle.Format = "$$$,$$$,$$0.00" '  FmtM ' "C"
								Grid.Columns(J).DefaultCellStyle.Format = FmtM ' "C"
								Exit For
							End If
						Next
					Next
				End If

			End If
			AddHandler Grid.CellValueChanged, AddressOf Grid_CellValueChanged


			DMSAjustarColumnas(AjustarColumnasToolStripMenuItem.Checked)
			If Fila > Grid.Rows.Count - 1 Then
				Fila = 0
			End If
			If Fila > 0 Then

				Grid.Rows(Fila).Selected = True
				Try
					Grid.CurrentCell = Grid.Rows(Fila).Cells(Grid.CurrentCell.ColumnIndex)
				Catch ex As Exception

				End Try
				RemoveHandler Grid.CurrentCellChanged, AddressOf Grid_CurrentCellChanged
				Try
					Grid.CurrentCell.Selected = True
				Catch ex As Exception

				End Try
				AddHandler Grid.CurrentCellChanged, AddressOf Grid_CurrentCellChanged

			End If

			If ColMaxLen IsNot Nothing Then
				MaxLen = ColMaxLen
			End If

			LeerOrdenColumnas()

			'no hacer esto, daño 1000 programas
			'Grid.ClearSelection()

			Grid.Focus()
			ActivarSetingCol = True

			'TODO. Probar esto
			'For I As Integer = 0 To Grid.Rows.Count - 1
			'    If Grid.Rows(I).Height > 50 Then Grid.Rows(I).Height = 50
			'Next


			If SeleccionarPrimeraFila = False Then
				Try
					Grid.ClearSelection()
					'Grid.SelectedRows(0).Selected = False
				Catch
				End Try
			End If

			'SGQ-664
			AddHandler Grid.ColumnWidthChanged, AddressOf Grid_ColumnWidthChanged
			AddHandler Grid.ColumnDisplayIndexChanged, AddressOf Grid_ColumnDisplayIndexChanged
			'/SGQ-664

			'If FilasDeColores Then
			'    For I As Integer = 0 To Grid.Rows.Count - 1
			'        If Int(I / 2) * 2 = I Then
			'            Grid.Rows(I).DefaultCellStyle.BackColor = Color.LightCyan
			'        End If
			'    Next
			'End If

		Catch ex As Exception
			Throw ex
		End Try

	End Sub

	Public Sub DMSCelda_Estilo_Boton(NombreColumna As String)
		'If ValD(Celda.Value) <> 0 Then
		'    Celda.Style.BackColor = Color.Gray
		'    Celda.Style.ForeColor = Color.White

		'End If
		Dim di As Integer = Grid.Columns(NombreColumna).DisplayIndex
		Dim Estaba_visible As Boolean = Grid.Columns(NombreColumna).Visible

		'Grid.Columns(NombreColumna).Visible = False
		Grid.Columns.Remove(NombreColumna)

		Dim ColumnButon As New DataGridViewButtonColumn
		ColumnButon.DataPropertyName = NombreColumna 'Propiedad por la que enlaza
		ColumnButon.Name = NombreColumna 'Propiedad por la que enlaza
		ColumnButon.Text = ColumnButon.DataPropertyName 'Valor del property
		ColumnButon.HeaderText = NombreColumna 'Texto del Header Nombre de la columna
		'Grd.Grid.Columns.AddRange(ColumnButon) 'AÃ±ade la columna boton a el grid
		Grid.Columns.Insert(di, ColumnButon) 'AÃ±ade la columna boton a el grid
		Grid.Columns(NombreColumna).Visible = Estaba_visible


	End Sub


	Private Sub Contador()

		If Grid.Rows.Count = 0 Then Exit Sub

		Grid.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		Dim I As Integer = 0
		For J = 0 To Grid.RowCount - 1
			If Grid.Rows(J).Visible Then
				I += 1
				Grid.Rows(J).HeaderCell.Value = I.ToString
			End If
		Next
		Grid.RowHeadersWidth = 10 + (Grid.Rows(Grid.RowCount - 1).HeaderCell.Value.ToString.Length + 1) * 20

		Grid.Refresh()
	End Sub

	Private Sub Grid_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellValueChanged
		Try
			Grid.Focus()
			If e.ColumnIndex < 0 Or e.RowIndex < 0 Then Exit Sub
			If Grid.CurrentCell.GetType Is GetType(DataGridViewCheckBoxCell) Then
				RaiseEvent DMSSalidaEdicionCelda(Me, Grid.Columns(e.ColumnIndex).Name,
									  Grid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value,
									  Grid.Rows(Grid.CurrentCell.RowIndex).Cells(NombreCol).Value)
			End If

		Catch 'ex As Exception

		End Try


	End Sub

	Public Sub DmsDevuelva()
		If Grid.SelectedRows.Count = 0 Then
			RaiseEvent DMSTraerValor(Me, "" & Grid.Rows(Grid.CurrentCell.RowIndex).Cells(NombreCol).Value)
		Else
			RaiseEvent DMSTraerValor(Me, "" & Grid.SelectedRows(0).Cells(NombreCol).Value)
		End If

	End Sub
	Private Sub Grid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
		If e.RowIndex < 0 Then Exit Sub
		If Not Grid.IsCurrentCellInEditMode Then
			If NombreCol <> "" Then
				DmsDevuelva()
			End If
		End If
	End Sub

	Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click

		If NombreCol <> "" Then
			DmsDevuelva()
			'RaiseEvent DMSTraerValor(Me, Grid.Rows(Grid.CurrentCell.RowIndex).Cells(NombreCol).Value)
		End If
	End Sub

	Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
		'If NombreCol <> "" Then
		'    Dim Fila As Integer = 0
		'    If Grid.CurrentCell Is Nothing Then
		'        Fila = Grid.SelectedRows(0).Index
		'    Else
		'        Fila = Grid.CurrentCell.RowIndex
		'    End If
		'    RaiseEvent DMSTraerValorEliminar(Me, Grid.Rows(Fila).Cells(NombreCol).Value, _
		'                                     Fila)
		'End If

		If Grid.SelectedRows.Count > 0 Then
			RaiseEvent DMSTraerValorEliminar(Me, "" & Grid.SelectedRows(0).Cells(NombreCol).Value, Grid.CurrentCell.RowIndex)
		End If

	End Sub

	Private Sub CopiarExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarExcelToolStripMenuItem.Click
		ExportarExcel()
	End Sub
	Public Sub ExportarExcel()
		If Not ValidarLic() Then Exit Sub
		Copiar_Exel(Grid, , DMSTituloDelInforme)

	End Sub
	Private Sub Grid_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseDown
		Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)
		If hti.Type = DataGridViewHitTestType.Cell Then
			AbrirToolStripMenuItem.Enabled = True
			EliminarToolStripMenuItem.Enabled = True
		Else
			AbrirToolStripMenuItem.Enabled = False
			EliminarToolStripMenuItem.Enabled = False
		End If

		Click_Derecho_Grid(Grid, sender, e)

		'SGQ-664
		Try
			If Not IsNothing(ColActual) Then
				If Grid.Columns.Contains(ColActual) Then
					OpcionesColumna.Text = OpcionesColumna.Tag & Grid.Columns(ColActual).HeaderText
				End If
			End If
		Catch
		End Try
		'/SGQ-664

		Grid.Focus()
	End Sub

	Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
		Buscar_en_Grid(Grid)
	End Sub


	Private Sub Grid_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles Grid.CellBeginEdit

		CeldaActual = Grid.CurrentCell

		RaiseEvent DMSEntrarEdicionCelda(Me,
										 Grid.Columns(e.ColumnIndex).Name,
										 Grid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value,
										 ValD(Grid.Rows(Grid.CurrentCell.RowIndex).Cells(NombreCol).Value),
										 e)

	End Sub

	Private Sub Grid_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellEndEdit
		If Grid.CurrentCell.GetType Is GetType(DataGridViewCheckBoxCell) Then
			Exit Sub
		End If

		RaiseEvent DMSSalidaEdicionCelda(Me, Grid.Columns(e.ColumnIndex).Name,
										  Grid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value,
										 ValD("" & Grid.Rows(Grid.CurrentCell.RowIndex).Cells(NombreCol).Value))

		If Grid.Rows.Count - 1 = e.RowIndex Then
			Refrescar()
		End If
	End Sub

	Private Sub Grid_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Grid.DataError

		Dim TipoDato As Type = Grid.Rows(e.RowIndex).Cells(e.ColumnIndex).ValueType

		If TipoDato Is GetType(Integer) Or TipoDato Is GetType(Decimal) Then
			MsgBox("El valor debe ser numerico")
			'e.Cancel = False
		End If
		If TipoDato Is GetType(DateTime) Then
			MsgBox("El valor debe ser una fecha")
			'e.Cancel = False
		End If
	End Sub
	Private Function ArchivoCols() As String
		'Dim Arch String = "c:\smd_files\cols" &  ' & "_" & Usuario

		Dim LblArchivo As String = "c:\smd_files\cols\"
		If Dir(LblArchivo, FileAttribute.Directory) = "" Then
			Try
				MkDir(LblArchivo)
			Catch
			End Try
		End If

		Return LblArchivo & My.Application.Info.AssemblyName & "_" & Me.ParentForm.Name & "_" & Grid.Parent.Name

	End Function
	Private Sub DisenoCeldas()
		Try
			If NoEntreDiseno Then Exit Sub

			'SGQ-664
			Dim Ds As New DataSet
			Try
				If Not IsNothing(Me.ParentForm) Then
					'Dim ArchivoCols As String = "c:\smd_files\cols" & My.Application.Info.AssemblyName & "_" & Me.ParentForm.Name & "_" & Grid.Parent.Name ' & "_" & Usuario
					If Dir(ArchivoCols()) <> "" Then
						Ds.ReadXmlSchema(ArchivoCols() & ".1")
						Ds.ReadXml(ArchivoCols)
						BorrarPersonalizacion.ForeColor = Color.Blue
						BorrarPersonalizacion.Tag = 1
					End If
				End If
			Catch
			End Try
			'/SGQ-664

			For I = 0 To Grid.Columns.Count - 1
				Dim Nomc As String = Grid.Columns(I).Name

				'SGQ-664
				Try
					If Ds.Tables.Count > 0 Then
						For Each Dr As DataRow In Ds.Tables(0).Rows
							If Nomc = Dr("nombre") Then
								Grid.Columns(Nomc).Width = Dr("ancho")
								Grid.Columns(Nomc).Visible = Dr("visible") = 1
								Grid.Columns(Nomc).DisplayIndex = Dr("posicion")
								Grid.Columns(Nomc).HeaderText = Dr("titulo")
								Ds.Tables(0).Rows.Remove(Dr)
								Ds.Tables(0).AcceptChanges()
								Exit For
							End If
						Next
					End If
				Catch
				End Try

				'/SGQ-664

				Dim TipoDato As Type = Grid.Columns(I).ValueType
				If TipoDato Is GetType(String) Then
					Dim Tam As Integer = 0
					For J = 0 To Grid.Rows.Count - 1
						If Tam < Grid.Rows(J).Cells(I).Value.ToString.Length Then
							Tam = Grid.Rows(J).Cells(I).Value.ToString.Length
						End If
					Next
					If Tam > 5 Or Tam = 0 Then
						If Tam > 150 Then
							Grid.Columns(I).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
						Else
							'Grid.Columns(I).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

						End If
						Grid.Columns(I).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
					Else
						Grid.Columns(I).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
						Grid.Columns(I).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
					End If
				End If

				If TipoDato Is GetType(Integer) Then
					Grid.Columns(I).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
					Grid.Columns(I).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
				End If
				If TipoDato Is GetType(Decimal) Then
					Grid.Columns(I).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
					Grid.Columns(I).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
				End If
				If TipoDato Is GetType(DateTime) Then
					Grid.Columns(I).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
					Grid.Columns(I).DefaultCellStyle.Format = "yyyy.MM.dd HH:mm"
					If DirectCast(Grid.DataSource, DataTable).Rows.Count > 0 Then
						If Not DirectCast(Grid.DataSource, DataTable).Rows(0).Item(I) Is DBNull.Value Then
							If CDate(DirectCast(Grid.DataSource, DataTable).Rows(0).Item(Nomc)).Hour = 0 And CDate(DirectCast(Grid.DataSource, DataTable).Rows(0).Item(Nomc)).Minute = 0 And CDate(DirectCast(Grid.DataSource, DataTable).Rows(0).Item(Nomc)).Second = 0 Then
								Grid.Columns(I).DefaultCellStyle.Format = "yyyy.MM.dd"
							Else
								Grid.Columns(I).DefaultCellStyle.Format = "yyyy.MM.dd HH:mm"
							End If
						End If
					End If
					Grid.Columns(I).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
				End If

				Try
					Grid.Columns(I).Width = Grid.Columns(I).Width
					Grid.Columns(I).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
				Catch
				End Try
			Next
		Catch ex As Exception
			Throw ex
		End Try

	End Sub

	Private Sub Grid_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Fila = Grid.CurrentCellAddress.Y
		Col = Grid.CurrentCellAddress.X
		If Col < 0 Or Fila < 0 Then Exit Sub

		Grid.Rows(Fila).Cells(Col).Style.SelectionBackColor = Color.Yellow
		Grid.Rows(Fila).Cells(Col).Style.SelectionForeColor = Color.Black

		Dim UltimaCol As Integer = 0
		For I = 0 To Grid.Columns.Count - 1
			If I <> Col Then
				Grid.Rows(Fila).Cells(I).Style.SelectionBackColor = Grid.DefaultCellStyle.SelectionBackColor
			End If

			If Grid.Columns(I).Visible Then
				UltimaCol = I
			End If

		Next
		If CancelarCelda Then

			Refrescar()
			CancelarCelda = False
		End If
		If UltimaCol = Grid.CurrentCell.ColumnIndex And Grid.Rows.Count - 1 = Grid.CurrentCell.RowIndex Then
			RaiseEvent DMSUltimaCelda(sender, e)

		End If

	End Sub

	Private Sub EnumerarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnumerarToolStripMenuItem.Click
		SiReloj()
		DMSPonga_Numeros_Fila(Not EnumerarToolStripMenuItem.Checked)
		NoReloj()

	End Sub
	Public Sub DMSPonga_Numeros_Fila(Optional Estado As Boolean = True)
		EnumerarToolStripMenuItem.Checked = Estado
		ValidarEnumaracion()

	End Sub

	Private Sub ValidarEnumaracion()

		If EnumerarToolStripMenuItem.Checked Then
			Contador()
			Grid.RowHeadersVisible = True
		ElseIf EnumerarToolStripMenuItem.Enabled Then
			Grid.RowHeadersVisible = False
		End If
	End Sub

	Private Sub PequeñoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PequeñoToolStripMenuItem.Click
		PequeñoToolStripMenuItem.Checked = True
		NormalToolStripMenuItem.Checked = False
		GrandeToolStripMenuItem.Checked = False

		Grid.Font = PequeñoToolStripMenuItem.Font
	End Sub

	Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
		PequeñoToolStripMenuItem.Checked = False
		NormalToolStripMenuItem.Checked = True
		GrandeToolStripMenuItem.Checked = False

		Grid.Font = NormalToolStripMenuItem.Font

	End Sub

	Private Sub GrandeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrandeToolStripMenuItem.Click
		PequeñoToolStripMenuItem.Checked = False
		NormalToolStripMenuItem.Checked = False
		GrandeToolStripMenuItem.Checked = True

		Grid.Font = GrandeToolStripMenuItem.Font

	End Sub
	Private Sub AjustarColumnasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjustarColumnasToolStripMenuItem.Click

		DMSAjustarColumnas(Not AjustarColumnasToolStripMenuItem.Checked)

		'jdms 668
		'If AjustarColumnasToolStripMenuItem.Checked Then
		'	Grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
		'End If

	End Sub
	Public Sub DMSAjustarColumnas(Optional ByVal Condicion As Boolean = False)
		If AjustarColumnasToolStripMenuItem.Checked = Condicion And YaEntre Then Exit Sub

		If Condicion Then
			AjustarColumnasToolStripMenuItem.Checked = Condicion
		Else

			AjustarColumnasToolStripMenuItem.Checked = Condicion 'not AjustarColumnasToolStripMenuItem.Checked

		End If

		If ValD(AjustarColumnasToolStripMenuItem.Tag) = 0 Then 'hace la automática
			If Not YaEntre Then
				For Each Dc As DataGridViewColumn In Grid.Columns
					If Dc.Frozen Or Not Dc.Visible Then Continue For
					Tam += Dc.Width
				Next
				If Tam > Grid.Width And AjustarColumnasToolStripMenuItem.Checked Then
					AjustarColumnasToolStripMenuItem.Checked = False
				Else
					AjustarColumnasToolStripMenuItem.Checked = True
				End If
				YaEntre = True
			End If
		End If

		If AjustarColumnasToolStripMenuItem.Checked Then
			Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

			'Tipo = DataGridViewAutoSizeColumnMode.Fill
		Else
			Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
			'Tipo = DataGridViewAutoSizeColumnMode.None
		End If
		Grid.Refresh()

		'    YaEntre = True
		'End If

	End Sub

	'Private Sub AjustarColumnasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjustarColumnasToolStripMenuItem.Click

	'    DMSAjustarColumnas()

	'End Sub

	'Public Sub DMSAjustarColumnas(Optional ByVal Condicion As Boolean = False)
	'    If Condicion Then
	'        AjustarColumnasToolStripMenuItem.Checked = Condicion
	'    Else
	'        AjustarColumnasToolStripMenuItem.Checked = Not AjustarColumnasToolStripMenuItem.Checked

	'    End If

	'    Dim Tipo As New DataGridViewAutoSizeColumnMode

	'    If AjustarColumnasToolStripMenuItem.Checked Then
	'        Tipo = DataGridViewAutoSizeColumnMode.Fill
	'    Else
	'        Tipo = DataGridViewAutoSizeColumnMode.None
	'    End If
	'    For Each Dc As DataGridViewColumn In Grid.Columns
	'        If Dc.Frozen Or Not Dc.Visible Then Continue For
	'        Dc.AutoSizeMode = Tipo
	'    Next

	'End Sub


	Private Sub Grid_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Sorted
		SiReloj()

		For I = 0 To Eliminados.Count - 1
			For J = 0 To Grid.Rows.Count - 1
				If Grid.Rows(J).Cells(NombreCol).Value = Eliminados(I)(0) Then
					Grid.Rows(J).Visible = False
					Exit For
				End If
			Next
		Next
		ValidarEnumaracion()

		NoReloj()

		RaiseEvent DMSOrdenarColumna(sender, e)

	End Sub
	Private Sub Negrilla(ByVal Fila As Integer)
		Dim Hay As Boolean = False
		Dim Colu As String = ""
		Dim Cuales As New ArrayList
		For J = 0 To Grid.Columns.Count - 1
			If Mid(Grid.Columns(J).Name, 1, 1) = "!" Then
				Grid.Columns(J).Visible = False
				Hay = True
				Cuales.Add(J)
			End If
		Next J

		If Not Hay Then
			Exit Sub
		End If

		'TODO: probar
		'Grid.CellBorderStyle = DataGridViewCellBorderStyle.None

		Dim OcultarDetalle As Boolean = True
		'For I = 0 To Grid.Rows.Count - 1
		For J = 0 To Cuales.Count - 1
			Dim K As Integer = ValD(Cuales(J))
			Select Case Grid.Columns(K).Name
				Case "!n"
					If ValD("" & Grid.Rows(Fila).Cells("!n").Value) = 1 Then
						Grid.Rows(Fila).DefaultCellStyle.Font = LblNegrilla.Font
					End If
				Case "!c"
					Select Case ValD("" & Grid.Rows(Fila).Cells("!c").Value)
						Case "1" : Grid.Rows(Fila).DefaultCellStyle.ForeColor = Color.Red
						Case "2" : Grid.Rows(Fila).DefaultCellStyle.ForeColor = Color.Blue
						Case "3" : Grid.Rows(Fila).DefaultCellStyle.ForeColor = Color.Green
						Case "4" : Grid.Rows(Fila).DefaultCellStyle.ForeColor = Color.Black
					End Select
				Case "!d"
					If EnumerarToolStripMenuItem.Enabled Then

						Grid.RowHeadersVisible = True
						Grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
						OcultarDetalle = False
						If ValD("" & Grid.Rows(Fila).Cells("!d").Value) = 1 Then
							Grid.Rows(Fila).HeaderCell.Value = "+"
						Else
							If ValD("" & Grid.Rows(Fila).Cells("!d").Value) > 0 Then
								Grid.Rows(Fila).HeaderCell.Value = "+"
							Else
								Grid.Rows(Fila).HeaderCell.Value = ""
							End If
							Grid.Rows(Fila).Visible = False
						End If
					End If
			End Select
		Next
		'Next
		If Not OcultarDetalle And Grid.RowCount - 1 = Fila Then
			EnumerarToolStripMenuItem.Enabled = False
			DMSQuitarSort()
		End If
	End Sub

	'Private Sub Negrilla(ByVal aaa)
	'    Dim Hay As Boolean = False
	'    Dim Colu As String = ""
	'    Dim Cuales As New ArrayList
	'    For J = 0 To Grid.Columns.Count - 1
	'        If Mid(Grid.Columns(J).Name, 1, 1) = "!" Then
	'            Grid.Columns(J).Visible = False
	'            Hay = True
	'            Cuales.Add(J)
	'        End If
	'    Next J

	'    If Not Hay Then
	'        Exit Sub
	'    End If

	'    Grid.CellBorderStyle = DataGridViewCellBorderStyle.None
	'    Dim OcultarDetalle As Boolean = True
	'    For I = 0 To Grid.Rows.Count - 1
	'        For J = 0 To Cuales.Count - 1
	'            Dim K As Integer = ValD(Cuales(J))
	'            Select Case Grid.Columns(K).Name
	'                Case "!n"
	'                    If ValD("" & Grid.Rows(I).Cells("!n").Value) = 1 Then
	'                        Grid.Rows(I).DefaultCellStyle.Font = LblNegrilla.Font
	'                    End If
	'                Case "!c"
	'                    Select Case ValD("" & Grid.Rows(I).Cells("!c").Value)
	'                        Case "1" : Grid.Rows(I).DefaultCellStyle.ForeColor = Color.Red
	'                        Case "2" : Grid.Rows(I).DefaultCellStyle.ForeColor = Color.Blue
	'                        Case "3" : Grid.Rows(I).DefaultCellStyle.ForeColor = Color.Green
	'                    End Select
	'                Case "!d"
	'                    If EnumerarToolStripMenuItem.Enabled Then

	'                        Grid.RowHeadersVisible = True
	'                        Grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
	'                        OcultarDetalle = False
	'                        If ValD("" & Grid.Rows(I).Cells("!d").Value) = 1 Then
	'                            Grid.Rows(I).HeaderCell.Value = "+"
	'                        Else
	'                            If ValD("" & Grid.Rows(I).Cells("!d").Value) > 0 Then
	'                                Grid.Rows(I).HeaderCell.Value = "+"
	'                            Else
	'                                Grid.Rows(I).HeaderCell.Value = ""
	'                            End If
	'                            Grid.Rows(I).Visible = False
	'                        End If

	'                    End If
	'            End Select
	'        Next
	'    Next
	'    If Not OcultarDetalle Then
	'        EnumerarToolStripMenuItem.Enabled = False
	'        DMSQuitarSort()
	'    End If
	'End Sub

	Private Sub Grid_RowPrePaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles Grid.RowPrePaint
		Negrilla(e.RowIndex)

	End Sub


	Private Sub Grid_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.CurrentCellDirtyStateChanged

		If Grid.CurrentCell.GetType Is GetType(DataGridViewCheckBoxCell) Then
			Grid.CommitEdit(DataGridViewDataErrorContexts.Commit)
		End If

	End Sub


	Private Sub Grid_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseClick
		If e.Button = Windows.Forms.MouseButtons.Left Then Exit Sub
		If Grid.CurrentCell Is Nothing Then Exit Sub

		If Grid.CurrentCell.GetType Is GetType(DataGridViewComboBoxCell) Then
			Grid.EditMode = DataGridViewEditMode.EditOnEnter

			If Not Grid.CurrentCell.IsInEditMode Then
				Dim Key As New KeyEventArgs(Keys.Enter)
				Grid.CurrentCell.KeyEntersEditMode(Key)
			End If
		End If
		Grid.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
	End Sub

	Private Sub CambiarAltoDeFilas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarAltoDeFilas.Click
		CambiarAltoDeFilas.Checked = Not CambiarAltoDeFilas.Checked
		Grid.AllowUserToResizeRows = CambiarAltoDeFilas.Checked

	End Sub
	'nuevo---------------------------------------------
	Public Event DMSCambioLinea(ByVal Sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs)
	Public Event DMSKeyDown(ByVal Sender As Object,
						ByVal e As System.Windows.Forms.KeyEventArgs,
						ByVal NombreCol As String,
						ByRef ValorCelda As Object,
						ByVal ColDevolver As Integer)

	Public Event DMSKeyPress(ByVal Sender As Object,
						ByVal e As KeyPressEventArgs)
	Public Function DMSDevolverEliminadosConFila() As ArrayList
		Return Eliminados
	End Function

	Public Function DMSDevolverEliminados() As ArrayList
		Dim ArrayTemp As New ArrayList
		For I = 0 To Eliminados.Count - 1
			ArrayTemp.Add(Eliminados(I)(0))
		Next
		Return ArrayTemp
	End Function

	Private Sub Grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
		If Grid.MultiSelect Then Exit Sub '0250

		If Not Grid.Focus Or Grid.CurrentCell Is Nothing Then
			Exit Sub
		End If
		If e.KeyCode = Keys.Enter Then
			If Grid.CurrentCell Is Nothing Then Exit Sub
			If Grid.Rows(Grid.CurrentCell.RowIndex).Cells(Grid.CurrentCell.ColumnIndex).ReadOnly Then
				'If Grid.SelectedRows(0).Cells(Grid.CurrentCell.ColumnIndex).ReadOnly Then
				If NombreCol <> "" Then
					e.SuppressKeyPress = True
					DmsDevuelva()
				End If
			End If
		Else
			'jdms 598 lo quito para que funcione la nueva fBusItem
			'If Not Grid.Rows(Grid.CurrentCell.RowIndex).Cells(Grid.CurrentCell.ColumnIndex).ReadOnly Then

			RaiseEvent DMSKeyDown(Me, e,
									  Grid.Columns(Grid.CurrentCell.ColumnIndex).Name,
									  Grid.Rows(Grid.CurrentCell.RowIndex).Cells(Grid.CurrentCell.ColumnIndex).Value,
									  Grid.Rows(Grid.CurrentCell.RowIndex).Cells(NombreCol).Value)

			'End If
		End If
		Refrescar()

	End Sub

	Public Sub Refrescar()
		Try
			If Grid.Rows.Count = 0 Then Exit Sub

			'jdms 666: pongo esto para que no salte de línea cuando regreso al grid
			If Grid.SelectedRows.Count > 0 Then Exit Sub

			Dim Dgc As DataGridViewCell = Grid.CurrentCell
			Grid.ClearSelection()
			Grid.CurrentCell = Dgc
			Grid.CurrentCell.Selected = True

		Catch ex As Exception

		End Try
	End Sub

	Private WithEvents cellTextBox As DataGridViewTextBoxEditingControl

	Private Sub cellTextBox_KeyDown(
		ByVal sender As Object,
		ByVal e As System.Windows.Forms.KeyEventArgs) Handles cellTextBox.KeyDown

		RaiseEvent DMSKeyDown(Me, e,
										  Grid.Columns(Grid.CurrentCell.ColumnIndex).Name,
										  cellTextBox.Text,
										  Grid.Rows(Grid.CurrentCell.RowIndex).Cells(NombreCol).Value)




	End Sub
	Dim FilaActual As Integer = 0

	Private Sub Grid_RowStateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles Grid.RowStateChanged
		If FilaActual <> e.Row.Index And e.Row.Index >= 0 Then
			RaiseEvent DMSCambioLinea(sender, e)
			FilaActual = e.Row.Index
		End If

	End Sub

	Public Sub DMSPonerInvisibleLinea(ByVal Fila As Integer, Optional ByVal Nuevo As Boolean = False)
		Dim Id As Integer = Grid.Rows(Fila).Cells(NombreCol).Value
		Eliminados.Add(New Object() {Id, Fila})

		Dim cm As CurrencyManager = BindingContext(Grid.DataSource)
		If Not cm.IsBindingSuspended Then
			cm.SuspendBinding()
		End If
		If Nuevo Then
			If DtEliminados.Columns.Count = 0 Then
				DtEliminados = Grid.DataSource.clone
			End If
			Dim Dr As DataRow = Grid.DataSource.rows(Fila)
			DtEliminados.ImportRow(Dr)
			Grid.DataSource.rows(Fila).delete()
		Else
			Grid.Rows(Fila).Visible = False
		End If

		cm.ResumeBinding()
	End Sub

	Private Sub DeshacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeshacerToolStripMenuItem.Click

		If Eliminados.Count = 0 Then Exit Sub
		Dim Id As Integer = Eliminados(Eliminados.Count - 1)(0)
		Dim Fila As Integer = Eliminados(Eliminados.Count - 1)(1)
		If DtEliminados.Rows.Count = 0 Then

			For I = 0 To Grid.Rows.Count - 1
				If Grid.Rows(I).Cells(NombreCol).Value = Id And I = Fila Then
					Grid.Rows(I).Visible = True
					Exit For
				End If
			Next
		Else
			Dim Ar As Array = DirectCast(DtEliminados.Rows(DtEliminados.Rows.Count - 1), DataRow).ItemArray

			Dim Dr As DataRow = Grid.DataSource.NewRow()

			Dr.ItemArray = Ar


			Grid.DataSource.Rows.InsertAt(Dr, Fila)
			DtEliminados.Rows(DtEliminados.Rows.Count - 1).Delete()
		End If

		Eliminados.RemoveAt(Eliminados.Count - 1)
		Refrescar()
	End Sub
	Private Enum TipoMaxlen
		NombreCol = 0
		Max = 1
	End Enum
	Private Sub Grid_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Grid.EditingControlShowing
		e.CellStyle.BackColor = Color.White
		cellTextBox = TryCast(e.Control, DataGridViewTextBoxEditingControl)
		For I = 0 To MaxLen.Count - 1
			If MaxLen(I)(TipoMaxlen.NombreCol) = Grid.Columns(Grid.CurrentCell.ColumnIndex).Name Then
				cellTextBox.MaxLength = MaxLen(I)(TipoMaxlen.Max)
				Exit For
			End If
		Next

	End Sub

	Public Sub DMSQuitarSort()
		Quitar_Sort_Columnas(Grid)
		'For I = 0 To Grid.Columns.Count - 1
		'    Grid.Columns(I).SortMode = DataGridViewColumnSortMode.NotSortable
		'Next
	End Sub
	Public Sub DMSNoDesHacer()
		DeshacerToolStripMenuItem.Visible = False
	End Sub
	Public Sub DMSEnumerarGrid(ByVal Enumerar As Boolean)
		EnumerarToolStripMenuItem.Checked = Enumerar
		ValidarEnumaracion()

	End Sub

	Private CeldaActual As DataGridViewCell
	Private CancelarCelda As Boolean = False
	Public Sub DMSCancelarCelda()
		CancelarCelda = True
	End Sub

	'nuevo---------------------------------------------

	Private Sub CmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRefrescar.Click
		Try
			Dim Dt As New DataTable
			Abrir(Dt, w_SQLRefrescar)
			DMSLlene_Grid(Dt, w_NombreColDevolver, w_ContadorLineas, w_ColOcultas, w_ColModificables, w_ColMoneda, w_ColForzar, w_Lineas, w_MostrarAbrir, w_MostrarEliminar, w_ColMaxLen, w_SQLRefrescar)
		Catch ex As Exception
			Mensaje_TopMost(ex.Message, , , True)
		End Try


	End Sub

	'Private Sub GridDms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	'    '    Asignar_Logo(Grid, PicLogo)

	'End Sub

	Private Sub Grid_RowHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.RowHeaderMouseClick
		If Grid.MultiSelect Then Exit Sub 'para que el 0250 no entre por aqui

		'TODO: no se si alguien entre por aqui pues nadie usa rowhead
		If Not EstaEnLista(Grid.Rows(e.RowIndex).HeaderCell.Value, "+", "-") Then Exit Sub
		Dim Cual As Decimal = ValD(Grid.Rows(e.RowIndex).Cells("!d").Value)
		For I = e.RowIndex + 1 To Grid.Rows.Count - 1
			If ValD(Grid.Rows(I).Cells("!d").Value) = Cual Then Exit For
			Dim Examinar As Integer = VABS(Grid.Rows(I).Cells("!d").Value)
			If Examinar = 0 Then
				Examinar = Cual + 1
			End If
			If Grid.Rows(e.RowIndex).HeaderCell.Value.ToString = "+" Then
				If Examinar = Cual + 1 Then
					Grid.Rows(I).Visible = True
				End If
			ElseIf Grid.Rows(e.RowIndex).HeaderCell.Value = "-" Then
				If Examinar = Cual + 1 Then
					Grid.Rows(I).Visible = False
				End If
			End If
		Next
		If Grid.Rows(e.RowIndex).HeaderCell.Value.ToString = "+" Then
			Grid.Rows(e.RowIndex).HeaderCell.Value = "-"
		ElseIf Grid.Rows(e.RowIndex).HeaderCell.Value = "-" Then
			Grid.Rows(e.RowIndex).HeaderCell.Value = "+"
		End If
	End Sub


	Private Sub GridDms_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
		If Tam > Grid.Width Then
			If AjustarColumnasToolStripMenuItem.Checked Then
				DMSAjustarColumnas(False)
			End If
		ElseIf Not AjustarColumnasToolStripMenuItem.Checked Then
			DMSAjustarColumnas(True)
		End If
	End Sub


	Private Sub GuardarOrdenColumnas()
		'If Not Grid.Created Then Exit Sub

		'Dim Name_Cols As String = ""
		'For I = 0 To Grid.ColumnCount - 1
		'    If Not Grid.Columns(I).Visible Then Continue For
		'    Name_Cols &= Grid.Columns(I).Name.ToLower
		'    Name_Cols &= "|"
		'    Name_Cols &= Grid.Columns(I).DisplayIndex
		'    If I < Grid.Columns.Count - 1 Then
		'        Name_Cols &= ","
		'    End If
		'Next
		'If Name_Cols <> "" And GetSett(Me.Name, Me.Name & Usuario, "") <> Name_Cols Then SaveSett(Me.Name, Me.Name & Usuario, Name_Cols)

	End Sub

	Private Sub LeerOrdenColumnas()
		'Dim Name_Cols As String() = GetSett(Me.Name, Me.Name & Usuario, "").Split(",")
		'Try
		'    For I = 0 To Name_Cols.Length - 1
		'        Dim Column As String = Name_Cols(I).Split("|").GetValue(0)
		'        Grid.Columns(Column).DisplayIndex = Name_Cols(I).Split("|").GetValue(1)
		'    Next

		'Catch ex As Exception

		'End Try


	End Sub

	Public Sub EnviarMailExcel()
		Dim Archivo As String = Path_Temp & "Advance_" & Strings.Format(Date.Now, "yyyyMMddHHmmss") & ".xls"
		If Strings.Left(GlobalesVarios.SQL, 3) = "%e%" Then
			YaEstaElArchivo = Strings.Mid(GlobalesVarios.SQL, 4)
			Archivo = YaEstaElArchivo
			GlobalesVarios.SQL = ""
		Else
			YaEstaElArchivo = ""
		End If

		Try

			If YaEstaElArchivo = "" Then
				If Grid.Rows.Count = 0 Then
					Mensaje("No hay datos para exportar a excel") : Exit Sub
				End If
				If Copiar_Exel(Grid, Archivo, DMSTituloDelInforme) = "N" Then
					Exit Sub
				End If
			End If

			Dim CualUsu As String
			If DtUsu.Rows.Count = 0 Then
				CualUsu = "Usuario " & Usuario
			Else
				CualUsu = Obtenga_Dato(DtUsu, "id=" & Usuario, "nombre")
			End If

			Enviar_Mail("" & CualUsu,
						"",
						"",
						"",
						"(Advance) " & Me.Text,
						"Archivo enviado desde Advance v." & String_Version_Editada() & DMScr(2) &
						"Saludos," & DMScr(2) &
						"" & CualUsu,
						Archivo,
						"")

		Catch ex As Exception
			MostrarError(Me.Name, "EnviarMailExcel", ex.Message)
		End Try
		If IO.File.Exists(Archivo) Then
			Try
				Kill(Archivo)

			Catch

			End Try
		End If

	End Sub

	Private Sub CmdEnviarMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEnviarMail.Click
		EnviarMail()
	End Sub
	Public Sub EnviarMail()
		If Not ValidarLic() Then Exit Sub
		EnviarMailExcel()

	End Sub
	Private Sub CmdEnviarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEnviarUsuario.Click
		EnviarPorChat()
	End Sub

	Public Sub EnviarPorChat()
		If Strings.Left(GlobalesVarios.SQL, 3) = "%e%" Then
			YaEstaElArchivo = Strings.Mid(GlobalesVarios.SQL, 4)
			GlobalesVarios.SQL = ""
		Else
			YaEstaElArchivo = ""
		End If

		If Not ValidarLic() Then Exit Sub

		Dim Archivo As String = Path_Temp & "Advance_" & Strings.Format(Date.Now, "yyyyMMddHHmmss") & ".xls"
		If YaEstaElArchivo <> "" Then
			Archivo = YaEstaElArchivo
		Else
			If Grid.Rows.Count = 0 Then
				Mensaje("No hay datos para exportar") : Exit Sub
			End If
		End If

		Try

			Dim Usu As String = PidaUsuarios("Seleccione Usuario que desea enviarle el archivo.", "", "", "", 0, Filtrar_DataTable(DtUsu, "tipo=2 and id<>" & Usuario), , , True)
			If ValD(Usu) = 0 Then
				Mensaje("No seleccionó ningun usuario")
				Exit Sub
			End If

			Dim TexM As String = Strings.Left(Inputbox2("Texto a enviar en el chat (opcional)?", "Texto opcional", ""), 300)

			If Not Pregunte("Seguro de enviar este archivo a " & Obtenga_Dato(DtUsu, "id=" & Usu, "nombre") & "?" & DMScr(2) & TexM) Then
				Exit Sub
			End If


			Dim fFe As New fUsuarios
			fFe.BackgroundWorker1.RunWorkerAsync(New Object() {Usu, Archivo, Grid, TexM, YaEstaElArchivo <> ""})


		Catch ex As Exception
			MostrarError(Me.Name, "CmdEnviarUsuario_Click", ex.Message)
		End Try



	End Sub

	Private Sub Grid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellClick
		If e.RowIndex < 0 Then Exit Sub

		If Grid.RowTemplate.Height = 44 Then 'es un pos, touch
			If NombreCol <> "" Then
				DmsDevuelva()
				Exit Sub
			End If
		End If

		If Not Grid.IsCurrentCellInEditMode Then
			If NombreCol <> "" Then
				RaiseEvent DMSCellClick(Me, "" & Grid.Rows(Grid.CurrentCell.RowIndex).Cells(NombreCol).Value)
				'nuevo que devuelve e tmbién
				RaiseEvent DMSCellClick2(Me, "" & Grid.Rows(Grid.CurrentCell.RowIndex).Cells(NombreCol).Value, e)
			End If
		End If

	End Sub

	Private Sub Grid_AllowUserToOrderColumnsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.AllowUserToOrderColumnsChanged
		If Not ActivarSetingCol Then Exit Sub
		GuardarOrdenColumnas()

	End Sub



	Private Sub Grid_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
		If Grid.CurrentRow Is Nothing Then Exit Sub

		RaiseEvent DMSMouseUp(Grid.CurrentRow.Index - Grid.SelectedRows.Count + 1, Grid.SelectedRows.Count - 1)

	End Sub
	Private Sub Grid_MouseDown() Handles Grid.MouseDown
		RaiseEvent DMSMouseDown()

	End Sub

	'Private Sub MnuCopiar_Click(sender As Object, e As EventArgs) Handles MnuCopiar.Click



	'    Dim selectedRowCount As Integer = Grid.Rows.GetRowCount(DataGridViewElementStates.Selected)

	'    If selectedRowCount > 0 Then

	'        Dim sb As New System.Text.StringBuilder()

	'        Dim i As Integer
	'        For i = 0 To selectedRowCount - 1

	'            sb.Append("Row: ")
	'            sb.Append(Grid.SelectedRows(i).Index.ToString())
	'            sb.Append(Environment.NewLine)

	'        Next i

	'        sb.Append("Total: " + selectedRowCount.ToString())
	'        MessageBox.Show(sb.ToString(), "Selected Rows")

	'    End If
	'End Sub

	Private Sub CmdVerVerticalmente_Click(sender As Object, e As EventArgs) Handles CmdVerVerticalmente.Click
		Try
			If Grid.SelectedRows.Count = 0 Then
				Exit Sub
			End If

			Dim Sq As String = ""

			Dim fTex As New fTextBox

			For I As Integer = 0 To Grid.Columns.Count - 1
				If Grid.Columns(I).Visible Then
					Try
						If Sq = "" Then
							fTex.Text = Grid.Columns(I).Name & ": " & Grid.SelectedRows(0).Cells(I).Value
						End If
						Sq &= Grid.Columns(I).Name & ": " & Grid.SelectedRows(0).Cells(I).Value & DMScr()

					Catch

					End Try
				End If
			Next

			fTex.TextBox1.Text = Sq
			fTex.Size = New Point(600, 600)
			fTex.StartPosition = FormStartPosition.WindowsDefaultLocation
			fTex.TextBox1.ReadOnly = True
			fTex.ShowInTaskbar = True

			fTex.Show()
		Catch ex As Exception
			Mensaje("Error: " & ex.Message & EsIngles())

		End Try


		'Mensaje(Sq)

	End Sub

	Private Sub CmdOtrasOpciones_Click(sender As Object, e As EventArgs) Handles CmdOtrasOpciones.Click
		If NombreCol <> "" Then
			If Grid.SelectedRows.Count > 0 Then
				RaiseEvent DMSTraerValorOtro(Me, "" & Grid.SelectedRows(0).Cells(NombreCol).Value)
			End If
		End If

	End Sub
	Private Sub CmdOtrasOpciones2_Click(sender As Object, e As EventArgs) Handles CmdOtrasOpciones2.Click
		If NombreCol <> "" Then
			If Grid.SelectedRows.Count > 0 Then
				RaiseEvent DMSTraerValorOtro2(Me, "" & Grid.SelectedRows(0).Cells(NombreCol).Value)
			End If
		End If

	End Sub
	Private Sub CmdOtrasOpciones3_Click(sender As Object, e As EventArgs) Handles CmdOtrasOpciones3.Click
		If NombreCol <> "" Then
			If Grid.SelectedRows.Count > 0 Then
				RaiseEvent DMSTraerValorOtro3(Me, "" & Grid.SelectedRows(0).Cells(NombreCol).Value)
			End If
		End If

	End Sub
	Private Sub CmdOtrasOpciones0_Click(sender As Object, e As EventArgs) Handles CmdOtrasOpciones0.Click
		If NombreCol <> "" Then
			If Grid.SelectedRows.Count > 0 Then
				RaiseEvent DMSTraerValorOtro0(Me, "" & Grid.SelectedRows(0).Cells(NombreCol).Value)
			End If
		End If

	End Sub

	Private Sub Grid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Grid.KeyPress


		RaiseEvent DMSKeyPress(sender, e)


	End Sub
	Private Sub GuardarPersonalizacion_Click(sender As Object, e As EventArgs) Handles GuardarPersonalizacion.Click
		If Not DMSPersonalizarGrid Then
			Mensaje("Este grid está marcado para no guardar personalización")
			Exit Sub
		End If
		'SGQ-664
		Try
			Dim Dt As New DataTable
			Dt.Columns.Add("nombre")
			Dt.Columns.Add("ancho")
			Dt.Columns.Add("posicion")
			Dt.Columns.Add("visible")
			Dt.Columns.Add("titulo")

			For Each Dc As DataGridViewColumn In Grid.Columns
				Dt.Rows.Add({Dc.Name, Dc.Width, Dc.DisplayIndex, IIf(Dc.Visible, 1, 0), Dc.HeaderText})
			Next

			Dim Ds As New DataSet
			'Dim ArchivoCols As String = "c:\smd_files\cols" & My.Application.Info.AssemblyName & "_" & Me.ParentForm.Name & "_" & Grid.Parent.Name ' & "_" & Usuario
			Ds.Tables.Add(Dt)
			Ds.WriteXml(ArchivoCols)
			Ds.WriteXmlSchema(ArchivoCols() & ".1")
			GuardarPersonalizacion.ForeColor = Color.Black
			BorrarPersonalizacion.ForeColor = Color.Blue
			BorrarPersonalizacion.Tag = 1

			SonarWAV("OK")


		Catch ex As Exception
			MostrarError(Me.Name, "GuardarPersonalizacion_Click", ex.Message)
		End Try
	End Sub

	Private Sub BorrarPersonalizacion_Click(sender As Object, e As EventArgs) Handles BorrarPersonalizacion.Click
		'SGQ-664
		Try
			'Dim ArchivoCols As String = "c:\smd_files\cols" & My.Application.Info.AssemblyName & "_" & Me.ParentForm.Name & "_" & Grid.Parent.Name ' & "_" & Usuario
			If Dir(ArchivoCols) <> "" Then
				Kill(ArchivoCols)
			End If
			If Dir(ArchivoCols() & ".1") <> "" Then
				Kill(ArchivoCols() & ".1")
			End If
			Mensaje("Para volver al diseño predeterminado del grid, debe cargar nuevamente la información")
			GuardarPersonalizacion.ForeColor = Color.Black
			BorrarPersonalizacion.ForeColor = Color.Black
			BorrarPersonalizacion.Tag = Nothing

		Catch ex As Exception
			Mensaje("No se logró: " & ex.Message & EsIngles())

		End Try

	End Sub

	Private Sub Grid_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles Grid.ColumnWidthChanged
		'SGQ-664
		GuardarPersonalizacion.ForeColor = Color.Red
	End Sub

	Private Sub Grid_ColumnDisplayIndexChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles Grid.ColumnDisplayIndexChanged
		'SGQ-664
		GuardarPersonalizacion.ForeColor = Color.Red
	End Sub

	Private Sub CambiarTitulo_Click(sender As Object, e As EventArgs) Handles CambiarTitulo.Click
		'SGQ-664
		Try
			Dim Tit As String = Trim(Inputbox2("Ingrese el nuevo título",, Grid.Columns(ColActual).HeaderText))
			If Tit = "" Then Exit Sub
			Grid.Columns(ColActual).HeaderText = Tit
			GuardarPersonalizacion.ForeColor = Color.Red
		Catch
		End Try

	End Sub

	Private Sub OcultarColumna_Click(sender As Object, e As EventArgs) Handles OcultarColumna.Click
		'SGQ-664
		Try
			Grid.Columns(ColActual).Visible = False
			GuardarPersonalizacion.ForeColor = Color.Red
		Catch
		End Try

	End Sub

	Private Sub CmdImprimir_Click(sender As Object, e As EventArgs) Handles CmdImprimir.Click
		Imprima_Grid(Grid)



	End Sub
	Private Sub Imprima_Grid(ByVal Grd As DataGridView)
		If Not SetupThePrinting(Grd) Then
			Exit Sub
		End If

		'Grd.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
		'Grd.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark
		'Grd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
		'Grd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		'Grd.DefaultCellStyle.Font = New Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point)
		'Grd.DefaultCellStyle.BackColor = Color.Empty
		'Grd.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight
		'Grd.CellBorderStyle = DataGridViewCellBorderStyle.Single
		'Grd.GridColor = SystemColors.ControlDarkDark
		'Grd.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

		Dim MyPrintPreviewDialog As New PrintPreviewDialog()
		MyPrintPreviewDialog.Document = MyPrintDocument
		MyPrintPreviewDialog.ShowDialog()


	End Sub
	Private Function SetupThePrinting(ByVal Grd As DataGridView) As Boolean
		Dim MyPrintDialog As New PrintDialog()
		MyPrintDialog.AllowCurrentPage = False
		MyPrintDialog.AllowPrintToFile = False
		MyPrintDialog.AllowSelection = False
		MyPrintDialog.AllowSomePages = False
		MyPrintDialog.PrintToFile = False
		MyPrintDialog.ShowHelp = False
		MyPrintDialog.ShowNetwork = False

		'jdms 668: esto sucede cuando el llamador no está con Framework 4.0, no abre el diálogo
		If MyPrintDialog.ShowDialog() = DialogResult.Cancel Then
			If Not Pregunte("Seguro de producir el reporte?") Then
				Return False
			End If
		End If

		MyPrintDocument.DocumentName = DMSTituloDelInforme
		MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings
		MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
		MyPrintDocument.DefaultPageSettings.Margins.Bottom = 40
		MyPrintDocument.DefaultPageSettings.Margins.Right = 40
		MyPrintDocument.DefaultPageSettings.Margins.Left = 40
		MyPrintDocument.DefaultPageSettings.Margins.Top = 40

		'If MessageBox.Show("Do you want the report to be centered on the page", "InvoiceManager - Center on Page", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
		'	MyDataGridViewPrinter = New DataGridViewPrinter(grd, MyPrintDocument, True, True, TituloInforme, New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
		'Else
		MyDataGridViewPrinter = New DataGridViewPrinter(Grd, MyPrintDocument, False, True, DMSTituloDelInforme, New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
		Return True

		'End If
	End Function

	Private Sub MyPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles MyPrintDocument.PrintPage
		Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)
		If (more = True) Then
			e.HasMorePages = True
		End If
	End Sub

	Private Sub CmdPonerSombras_Click(sender As Object, e As EventArgs) Handles CmdPonerSombras.Click
		If Grid.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight Then
			Grid.AlternatingRowsDefaultCellStyle.BackColor = Color.White
			CmdPonerSombras.Text = Idi("Poner sombras")
		Else
			Grid.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight
			CmdPonerSombras.Text = Idi("Quitar sombras")
		End If

	End Sub

	Private Sub GridDms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'AbrirToolStripMenuItem.Text = Idi(AbrirToolStripMenuItem.Text)
		'CmdVerVerticalmente.Text = Idi(CmdVerVerticalmente.Text)
		'CmdEnviarMail.Text = Idi(CmdEnviarMail.Text)
		'CmdEnviarUsuario.Text = Idi(CmdEnviarUsuario.Text)
		'CmdImprimir.Text = Idi(CmdImprimir.Text)
		'BuscarToolStripMenuItem.Text = Idi(BuscarToolStripMenuItem.Text)
		'CmdPonerSombras.Text = Idi(CmdPonerSombras.Text)
		'CmdRefrescar.Text = Idi(CmdRefrescar.Text)
		'EliminarToolStripMenuItem.Text = Idi(EliminarToolStripMenuItem.Text)
		'DeshacerToolStripMenuItem.Text = Idi(DeshacerToolStripMenuItem.Text)
		'PequeñoToolStripMenuItem.Text = Idi(PequeñoToolStripMenuItem.Text)
		'GrandeToolStripMenuItem.Text = Idi(GrandeToolStripMenuItem.Text)
		'EnumerarToolStripMenuItem.Text = Idi(EnumerarToolStripMenuItem.Text)
		'AjustarColumnasToolStripMenuItem.Text = Idi(AjustarColumnasToolStripMenuItem.Text)
		'CambiarAltoDeFilas.Text = Idi(CambiarAltoDeFilas.Text)
		'OpcionesColumna.Text = Idi(OpcionesColumna.Text)
		'OpcionesColumna.Tag = OpcionesColumna.Text & ": "
		'OcultarColumna.Text = Idi(OcultarColumna.Text)
		'CambiarTitulo.Text = Idi(CambiarTitulo.Text)
		'GuardarPersonalizacion.Text = Idi(GuardarPersonalizacion.Text)
		'BorrarPersonalizacion.Text = Idi(BorrarPersonalizacion.Text)

		Recorrer_Controles_ContextMenuStrip(ContextMenuStrip1)

	End Sub
End Class
