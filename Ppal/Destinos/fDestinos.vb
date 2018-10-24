' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 640, 3-abr.-2018 13:06
' Version: 626, 16-feb.-2018 12:38
' Version: 608, 21-dic.-2017 13:15
' Version: 603, 5-dic.-2017 19:15
' Version: 594, 1-nov.-2017 12:36
' Version: 593, 27-oct.-2017 09:31
' Version: 592, 25-oct.-2017 19:06
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fDestinos
	Private DsDest As System.Data.DataSet
	Dim Varios As String = ""
	Dim TexBuscar As String = ""
	Public SoyModal As Boolean = False
	Dim FechaControl As DateTime
	Dim NodoMover As TreeNode
	Public NodoInicial As Integer = 0
	Public IdCuenta As Integer = 0
	Public IdCentro As Integer = 0
	Public Dimension As Integer = 0

	Dim MuchosNodos As Boolean = False
	Dim CargoNodos As Boolean = False
	Dim CantMuchos As String
	Dim Cargando As Boolean = True
	Dim SoloCentros As Boolean

    Dim Buscando As Short = 0
    'SGQ-626: Codigo aut
    Dim CodAutDestino As Boolean
    Dim NumCerosDestino As Integer
    Dim TamDestino As Integer
    Dim MaxDesti As Integer
    Dim Cod As String
    Dim CodNext As String = ""
    Dim HayCodigo As Boolean
    '/SGQ-626: Codigo aut



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'If Me.Tag = 1 Then
		'	Exit Sub
		'End If
		Recorrer_Controles_Idioma(Me, Me)
		Recorrer_Controles_ContextMenuStrip(ContextMenuStrip1)

		Cargando = True

		CmdCancelar.Left = -1000




		Try
			ChkOcultarIDS.Checked = GetSetting("DMS S.A.", Me.Name, "verid", False)
		Catch
		End Try

		fImg.LlenarImage2()
		TreeView1.ImageList = fImg.ImageList2

		'JDMS 603
		SoloCentros = ReglaDeNegocio(146, "destinos_cen", "0") = "1"
		'SGQ-626: Codigo aut
		CodAutDestino = ReglaDeNegocio(146, "destino_aut", "0") = "1"
		NumCerosDestino = ValD(ReglaDeNegocio(146, "ceros_destino_aut", "3"))
		TamDestino = ValD(ReglaDeNegocio(146, "tam_destino_aut", "22"))
		UsaDestinosItem = ReglaDeNegocio(146, "destinos_item", "0") = "1"
		'/SGQ-626: Codigo aut

		'CrearDataSet()
		If DsDest IsNot Nothing And TreeView1.Nodes.Count > 0 Then
			'JDMS 603
			If SoloCentros Then
				Montar_Nodos(IIf(NodoInicial > 0, NodoInicial, ""))
			End If
			'/JDMS 603
			If NodoInicial > 0 Then
				BuscarNodo(TreeView1.Nodes(0), "", NodoInicial)
			End If
			Exit Sub
		End If


		CantMuchos = ValD(ReglaDeNegocio(146, "muchos_dest", 2000))
		LblMensaje.Tag = LblMensaje.Text

		ToolDevolver.Visible = SoyModal
		CmdCancelar.Visible = SoyModal
		If SoyModal Then
			Me.ControlBox = False
			CmdCancelar2.Text = "Regresar sin nodo"
		End If

		Montar_Nodos(IIf(NodoInicial > 0, NodoInicial, ""))

		Cargando = False

	End Sub
	Private Sub Montar_Nodos(Optional IdNodo As String = "", Optional Ds As DataSet = Nothing, Optional Todos As Boolean = False)
		Try

			SiReloj()

			If Ds IsNot Nothing Then
				DsDest = Ds
			Else
				Abrir(DsDest, ArmeSQL("GetConDestinos",
									  Numero_Empresa, qqNum,
									  ChkInac.Checked, qqBol,
									  Todos, qqBol
									  )
									 )
			End If

			MuchosNodos = DsDest.Tables(0).Rows.Count > ValD(CantMuchos) '2000
			LblMensaje.Text = LblMensaje.Tag.Replace("2000", "Hay " & ValD(Gdf(DsDest.Tables(1), "total_destinos")).ToString("#,#") & " destinos. Según RN#146 [muchos_dest] el máximo para arrancar con árbol es de " & ValD(CantMuchos).ToString("#,#"))

			LnkVerTree.Visible = Fin(DsDest.Tables(0))
			LblMensaje.Visible = Fin(DsDest.Tables(0))
			TreeView1.Visible = Not Fin(DsDest.Tables(0))
			CargoNodos = Not Fin(DsDest.Tables(0))

			'GrdDest.DataSource = DsDest.Tables(0)
			'GrdDest.Columns("id_padre").Visible = False
			'GrdDest.Columns("img").Visible = False
			'GrdDest.Columns("inactivo").Visible = False
			'GrdDest.Columns("dimension").Visible = False
			'GrdDest.Columns("id").Width = 40
			'GrdDest.Columns("descripcion").Width = 400

			FechaControl = Gdf(DsDest.Tables(1), "fecha_modif")
			TreeView1.Nodes.Clear()

			If Not Fin(DsDest.Tables(0)) Then
				TreeView1.Visible = False
				'==================================================================
				CrearNodosDelPadre(0, Nothing, IdNodo)
				'==================================================================
				TreeView1.Visible = True
			End If

			NoReloj()


		Catch ex As Exception
			MostrarError(Me.Name, "Montar_Nodos", ex.Message)

		End Try


	End Sub
	Private Sub Ponga_Color_Nodo(ByRef nuevoNodo As TreeNode, ByVal Dimension As Integer)

		Dim NueColor As Color = Color.Black
		Select Case Dimension
			Case 1 : NueColor = Color.Blue
			Case 2 : NueColor = Color.Red
			Case 3 : NueColor = Color.Green
			Case 4 : NueColor = Color.Maroon
		End Select
		nuevoNodo.ForeColor = NueColor

	End Sub
	Private Sub CrearNodosDelPadre(ByVal indicePadre As Integer, ByVal nodePadre As TreeNode, Optional IdNodo As String = "", Optional PrimeraVez As Boolean = True)


		Dim dataViewHijos As DataView

		' Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.
		dataViewHijos = New DataView(DsDest.Tables(0))

		dataViewHijos.RowFilter = "isnull(" & DsDest.Tables(0).Columns("id_padre").ColumnName & ",0)" & " = " & indicePadre.ToString()

		Dim YaHizoDestSimple As Boolean = False
		Dim DestSimple As Boolean = ReglaDeNegocio(146, "destinos", "0") = "1"

		' Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
		For Each dataRowCurrent As DataRowView In dataViewHijos
			'para cargar solo primer nivel
			If MuchosNodos Then
				If nodePadre IsNot Nothing Then
					If PrimeraVez Then
						If nodePadre.Level > 1 Then
							Continue For
						End If
					End If
				End If
			End If

			'JDMS 603
			If SoloCentros And IdCentro > 0 Then
				'buscar el centro o vacío
				Dim Dtcc As DataTable = Filtrar_DataTable(DsDest.Tables(2), "id_con_destinos=" & dataRowCurrent("id"))
				If Not Fin(Dtcc) Then
					'buscar el centro
					If Gdf(Dtcc, "id_con_cco") IsNot DBNull.Value Then
						'como tiene centros, se busca el actual
						Dim Dtc2 As DataTable = Filtrar_DataTable(Dtcc, "id_con_cco=" & IdCentro)
						If Fin(Dtc2) Then 'no lo encontró
							Continue For
						End If
					End If
				End If
			End If
			'/JDMS 603


			Dim nuevoNodo As New TreeNode
			nuevoNodo.Text = dataRowCurrent("descripcion").ToString().Trim() & Mostrar_ID(dataRowCurrent("id"))
			nuevoNodo.Name = dataRowCurrent("id").ToString

			nuevoNodo.ImageIndex = ValD(dataRowCurrent("img"))
			nuevoNodo.SelectedImageIndex = nuevoNodo.ImageIndex

			Ponga_Color_Nodo(nuevoNodo, ValD(dataRowCurrent("dimension")))

			If ValD(dataRowCurrent("inactivo")) = 1 Then
				nuevoNodo.ForeColor = Color.Red
			End If

			' si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
			' del primer nivel que no dependen de otro nodo.
			If nodePadre Is Nothing Then
				TreeView1.Nodes.Add(nuevoNodo)
			Else
				' se añade el nuevo nodo al nodo padre.
				If DestSimple And nodePadre.Level = 0 Then
					If Not YaHizoDestSimple Then
						YaHizoDestSimple = True
						nodePadre.Nodes.Add(nuevoNodo)
					End If
				Else
					nodePadre.Nodes.Add(nuevoNodo)
				End If

			End If


			If ValD(IdNodo) = ValD(dataRowCurrent("id")) Then
				TreeView1.SelectedNode = nuevoNodo
			End If

			' Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
			CrearNodosDelPadre(Int32.Parse(dataRowCurrent("id").ToString()), nuevoNodo, IdNodo)
		Next dataRowCurrent

	End Sub

	'Private Sub CrearDataSet()
	'    Dim tablaArbol As DataTable

	'    DsDest = New DataSet("DsDest")

	'    tablaArbol = DsDest.Tables.Add("TablaArbol")
	'    tablaArbol.Columns.Add("NombreNodo", GetType(String))
	'    tablaArbol.Columns.Add("IdentificadorNodo", GetType(Integer))
	'    tablaArbol.Columns.Add("IdentificadorPadre", GetType(Integer))

	'    InsertarDataRow("Nodo 1", 1, 0)
	'    InsertarDataRow("Nodo 1.1", 2, 1)
	'    InsertarDataRow("Nodo 1.1.1", 3, 2)
	'    InsertarDataRow("Nodo 1.1.2", 4, 2)
	'    InsertarDataRow("Nodo 1.1.2.1", 12, 4)
	'    InsertarDataRow("Nodo 1.1.2.2", 13, 4)
	'    InsertarDataRow("Nodo 1.2", 5, 1)

	'    InsertarDataRow("Nodo 2", 6, 0)
	'    InsertarDataRow("Nodo 2.1", 7, 6)
	'    InsertarDataRow("Nodo 2.2", 8, 6)

	'    InsertarDataRow("Nodo 3", 9, 0)
	'    InsertarDataRow("Nodo 3.1", 10, 9)
	'    InsertarDataRow("Nodo 3.2", 11, 9)

	'    InsertarDataRow("Nodo 200", 200, 0)
	'    InsertarDataRow("Nodo 200.A", 201, 200)
	'End Sub

	'Private Sub InsertarDataRow(ByVal column1 As String, ByVal column2 As Integer, ByVal column3 As Integer)
	'    Dim nuevaFila As DataRow

	'    nuevaFila = DsDest.Tables("TablaArbol").NewRow()

	'    nuevaFila("NombreNodo") = column1
	'    nuevaFila("IdentificadorNodo") = column2
	'    nuevaFila("IdentificadorPadre") = column3
	'    DsDest.Tables("TablaArbol").Rows.Add(nuevaFila)
	'End Sub


	'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
	'    Mensaje(TreeView1.SelectedNode.Index & DMScr() & TreeView1.SelectedNode.Name & DMScr() & TreeView1.SelectedNode.Level)

	'End Sub



	Private Sub RecorrerNodos(treeNode As TreeNode)
		Try
			'Si el nodo que recibimos tiene hijos se recorrerá
			'para luego verificar si esta o no checado
			For Each tn As TreeNode In treeNode.Nodes
				'Se Verifica si esta marcado...
				'If tn.Checked = True Then
				'    'Si esta marcado mostramos el texto del nodo
				'    MessageBox.Show(tb.Text)
				'End If
				Varios &= tn.Name & ","

				'Ahora hago verificacion a los hijos del nodo actual            
				'Esta iteración no acabara hasta llegar al ultimo nodo principal
				RecorrerNodos(tn)
			Next
		Catch ex As Exception
			MessageBox.Show(ex.ToString())
		End Try
	End Sub

	Private Sub TreeView1_MouseDown(sender As Object, e As MouseEventArgs) Handles TreeView1.MouseDown
		Dim p As New Point(e.X, e.Y)

		Dim Nodo As TreeNode = TreeView1.GetNodeAt(p)
		TreeView1.SelectedNode = Nodo

	End Sub

	Private Sub TollAdi_Click(sender As Object, e As EventArgs) Handles TollAdi.Click
		If TreeView1.SelectedNode Is Nothing Then
			Mensaje("Seleccione nodo base")
			Exit Sub
		End If

		If TreeView1.SelectedNode.Level = 0 Then
			Mensaje("No se pueden adicionar dimensiones")
			Exit Sub
		End If


		Crear_Modificar_Destino(False)


	End Sub
	Private Sub Crear_Modificar_Destino(Modif As Boolean)
		PnlMover.Visible = False

		Dim fCtas As New fCtaDestinos
		fCtas.Tag = TreeView1.SelectedNode.Name

		Dim ColorActual As Color = TreeView1.SelectedNode.ForeColor
		Dim ImgActual As Integer = TreeView1.SelectedNode.ImageIndex

		If TreeView1.SelectedNode.Level < 2 And Modif Then
			fCtas.PnlCuentas.Visible = False
		End If

		fCtas.FechaControl = FechaControl
		fCtas.Modif = Modif
		fCtas.Dimension = Dimension
		If Dimension = 0 Then 'traerla
			fCtas.Dimension = ValD(Obtenga_Dato(DsDest.Tables(0), "id=" & fCtas.Tag, "dimension"))
		End If

		'SGQ-626: Codigo Aut
		fCtas.LblCod.Visible = CodAutDestino
		fCtas.TxtCod.Visible = CodAutDestino
		fCtas.TamDestino = TamDestino
		'/SGQ-626: Codigo Aut

		If Modif Then

			Dim defa As String = TreeView1.SelectedNode.Text

			fCtas.ChkInactivo.Checked = ValD(Obtenga_Dato(DsDest.Tables(0), "id=" & fCtas.Tag, "inactivo")) = 1

			Dim ini As Integer = InStr(defa, "●")
			If ini > 0 Then
				defa = Strings.Mid(defa, 1, ini - 1).Trim
			End If

			'SGQ-626: Destino aut
			'fCtas.TxtDestino.Text = defa
			If CodAutDestino Then
				If ValD(Trim(Mid(defa, 1, TamDestino)).Replace(".", "")) > 0 Then 'Tiene código
					fCtas.TxtCod.Text = Trim(Mid(defa, 1, TamDestino))
					fCtas.TxtCod.Tag = fCtas.TxtCod.Text
					fCtas.TxtDestino.Text = Trim(Mid(defa, TamDestino))
				Else
					fCtas.TxtDestino.Text = defa
				End If
			Else
				fCtas.TxtDestino.Text = defa
			End If
			'/SGQ-626: Destino aut

			fCtas.LblQue.Text = "Modificar " & defa

		Else
			fCtas.LblQue.Text = "Nuevo destino"
			fCtas.PictureBox1.Image = fImg.ImageList1.Images(TreeView1.SelectedNode.ImageIndex)
			fCtas.PictureBox1.Tag = TreeView1.SelectedNode.ImageIndex
			'SGQ-626: Destino Aut
			Generar_Codigo_Aut(fCtas)
			'/SGQ-626: Destino Aut
		End If
		fCtas.PictureBox1.Image = fImg.ImageList1.Images(ImgActual)
		fCtas.PictureBox1.Tag = ImgActual

		fCtas.Guardo = False 'SGQ-640: Garantizando que se guardó
		MostrarForma3(Me.Icon, fCtas, True, "0108|fCtaDestinos")

		'SGQ-640: Garantizando que se guardó
		'If fCtas.Tag = "" Then
		If Not fCtas.Guardo Then
			'/SGQ-640: Garantizando que se guardó
			Exit Sub
		End If

		FechaControl = fCtas.FechaControl

		If Modif Then
			TreeView1.SelectedNode.Text = fCtas.TxtDestino.Text & Mostrar_ID(TreeView1.SelectedNode.Name)
			TreeView1.SelectedNode.ImageIndex = ValD(fCtas.PictureBox1.Tag)
			TreeView1.SelectedNode.SelectedImageIndex = ValD(fCtas.PictureBox1.Tag)
			TreeView1.SelectedNode.ForeColor = ColorActual
		Else
			Dim nuevoNodo As New TreeNode
			nuevoNodo.Text = fCtas.TxtDestino.Text & Mostrar_ID(fCtas.IdProducido)
			nuevoNodo.Name = fCtas.IdProducido
			nuevoNodo.ImageIndex = ValD(fCtas.PictureBox1.Tag)
			nuevoNodo.SelectedImageIndex = ValD(fCtas.PictureBox1.Tag)
			nuevoNodo.ForeColor = ColorActual
			' si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
			' del primer nivel que no dependen de otro nodo.
			If TreeView1.SelectedNode Is Nothing Then
				TreeView1.Nodes.Add(nuevoNodo)
			Else
				'se añade el nuevo nodo al nodo padre.
				TreeView1.SelectedNode.Nodes.Add(nuevoNodo)
			End If
			'SGQ-626: Destino automático
			If CodAutDestino Then
				DsDest.Tables(0).Rows.Add({fCtas.IdProducido, ValD(TreeView1.SelectedNode.Name), fCtas.TxtDestino.Text})
			End If
			'/SGQ-626: Destino automático
		End If

	End Sub
	Private Function Mostrar_ID(CualID) As String
		If ChkOcultarIDS.Checked Then
			Return ""
		Else
			Return " ●" & CualID
		End If

	End Function
	Private Sub ToolEdi_Click(sender As Object, e As EventArgs) Handles ToolEdi.Click
		If Not TreeView1.SelectedNode.IsSelected Then
			Mensaje("No hay nodo seleccionado")
			Exit Sub
		End If

		If TreeView1.SelectedNode.Level < 2 Then
			Mensaje("Nivel no es modificable")
			Exit Sub
		End If

		Crear_Modificar_Destino(True)




	End Sub

	Private Sub ToolEli_Click(sender As Object, e As EventArgs) Handles ToolEli.Click
		If Not TreeView1.SelectedNode.IsSelected Then
			Mensaje("No hay nodo seleccionado")
			Exit Sub
		End If
		If TreeView1.SelectedNode.Level < 2 Then
			Mensaje("No se puede eliminar este nodo")
			Exit Sub
		End If

		If NoPuede4("0108", 200, , , TreeView1.SelectedNode.Text) Then
			Exit Sub
		End If

		PnlMover.Visible = False

		Varios = TreeView1.SelectedNode.Name & ","
		RecorrerNodos(TreeView1.SelectedNode)
		If Varios <> "" Then
			Varios = Strings.Mid(Varios, 1, Varios.Length - 1)
		End If

		If Not Pregunte(Idi("Seguro de eliminar") & " " & TreeView1.SelectedNode.Text & "?" & DMScr(2) & Idi("Nota: También eliminará todos sus nodos internos si no tienen movimiento")) Then
			Exit Sub
		End If



		Try
			SiReloj()
			Dim Sq As String = ""
			Sq = ArmeSQL("exec DelConDestino",
						   Numero_Empresa, qqNum,
						   Usuario, qqNum,
						   Varios, qqTex,
						   FechaControl, qqFeh
		   )

			Dim dt As New DataTable

			Abrir(dt, Sq)

			FechaControl = Gdf(dt, "fecha_modif")

			NoReloj()

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "ToolEli_Click", ex.Message)
			Exit Sub
		End Try

		TreeView1.SelectedNode.Remove()

	End Sub

	Private Sub BuscarNodo(TreeNode As TreeNode, Tex As String, Optional IDbuscar As String = "")
		Try


			For Each tn As TreeNode In TreeNode.Nodes
				If IDbuscar <> "" Then
					If tn.Name = IDbuscar Then
						'TreeView1.ExpandAll()
						If Buscando = 0 Then
							TreeView1.SelectedNode = tn
							TreeView1.SelectedNode.EnsureVisible()
						Else
							Buscando = 2 'significa que encontró nodo
						End If


						'Dim NueColor As Color = Color.Black
						'Select Case Dimension
						'    Case 1 : NueColor = Color.Blue
						'    Case 2 : NueColor = Color.Red
						'    Case 3 : NueColor = Color.Green
						'    Case 4 : NueColor = Color.Maroon
						'End Select
						'TreeView1.SelectedNode.ForeColor = NueColor

						Exit Sub
					End If
				Else
					If LCase(tn.Text) Like "*" & Tex & "*" Then
						'TreeView1.SelectedNode = tn
						Varios &= tn.Name & ","
						'Exit Sub
					End If
				End If

				'Ahora hago verificacion a los hijos del nodo actual            
				'Esta iteración no acabara hasta llegar al ultimo nodo principal
				BuscarNodo(tn, Tex, IDbuscar)
			Next
		Catch ex As Exception
			MessageBox.Show(ex.ToString())
		End Try
	End Sub

	Private Sub GrdBus_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles GrdBus.DMSTraerValor
		'If CargoNodos Then
		'	BuscarNodo(TreeView1.Nodes(0), "", ValorColDevolver)
		'	TreeView1.Focus()
		'End If

		'If MuchosNodos Or Not CargoNodos Then
		GrdBus.Tag = ValorColDevolver & "|" & GrdBus.Grid.SelectedRows(0).Cells("nodo").Value
		ToolDevolver_Click(GrdBus, Nothing)
		'End If
	End Sub

	Private Sub LnkRefrescar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkRefrescar.LinkClicked
		Dim IdNodo As String = ""

		Try
			If TreeView1.SelectedNode.IsSelected Then
				IdNodo = TreeView1.SelectedNode.Name
			End If

		Catch ex As Exception

		End Try

		PnlMover.Visible = False

		Montar_Nodos(IdNodo)
		GrdBus.Visible = False
		TreeView1.Focus()

		SonarWAV("ok")

	End Sub

	Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
		If e.KeyCode = Keys.Enter Then
			If TxtBuscar.Text = "" Then
				ToolDevolver_Click(ToolDevolver, New EventArgs)
			Else
				CmdBusque.PerformClick()
			End If
		End If

	End Sub

	Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
		GrdBus.Visible = False

	End Sub

	Private Sub ToolDevolver_Click(sender As Object, e As EventArgs) Handles ToolDevolver.Click
		If Not SoyModal Then
			Exit Sub
		End If

		Dim IdNodo As Integer = 0
		Dim TexNodo As String = ""
		If sender.tag <> "" Then
			Dim Cmps() As String = sender.tag.ToString.Split("|")
			IdNodo = ValD(Cmps(0))
			TexNodo = Cmps(1)
		End If

		If IdNodo = 0 Then
			If Not TreeView1.SelectedNode.IsSelected Then
				Mensaje("No hay nodo seleccionado")
				Exit Sub
			End If
			IdNodo = TreeView1.SelectedNode.Name
			TexNodo = TreeView1.SelectedNode.Text
		End If

		'Mensaje(Obtenga_Dato(DtCta, "id=" & IdCuenta, "descripcion"))

		'ver si ha habido cambios por otro usuario
		Try
			SiReloj()
			Dim dt As New DataTable
			Abrir(dt, ArmeSQL("GetConDestinosControl",
								Numero_Empresa, qqNum,
								FechaControl, qqFeh,
								IdNodo, qqNum,
								IIf(SoloCentros, 0, IdCuenta), qqNum,
								Dimension, qqNum,
								IdCentro, qqNum
								)
							)

			NoReloj()

			If Gdf(dt, "resp") <> "" Then
				Mensaje(Gdf(dt, "resp"))
				Exit Sub
			End If

		Catch ex As Exception
			NoReloj()
			Mensaje("No se puede regresar: " & ex.Message & EsIngles())
			Exit Sub
		End Try

		'ver si tiene nodos adentro, para saber si es afectable
		'Varios = ""
		'If CargoNodos Then
		'	RecorrerNodos(TreeView1.SelectedNode)
		'End If

		Try
			'Me.Tag = IdNodo & "|" & TexNodo & "|" & IIf(Varios <> "", 1, 0)
			Me.Tag = IdNodo & "|" & TexNodo & "|0"
			Me.Hide()

		Catch ex As Exception

		End Try
	End Sub

	Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click, CmdCancelar2.Click
		If Not SoyModal Then
			Exit Sub
		End If

		Me.Tag = ""
		Me.Hide()

	End Sub

	Private Sub TreeView1_KeyDown(sender As Object, e As KeyEventArgs) Handles TreeView1.KeyDown
		If e.KeyCode = Keys.Enter Then
			ToolDevolver_Click(ToolDevolver, New EventArgs)
		End If

	End Sub


	Private Sub CmdBusque_Click(sender As Object, e As EventArgs) Handles CmdBusque.Click
		If TxtBuscar.Text = "" Then
			Exit Sub
		End If

		Try
			SiReloj()
			Dim Dt As New DataTable
			Abrir(Dt, ArmeSQL("GetConDestinoBuscar",
							  Numero_Empresa, qqNum,
							  TxtBuscar.Text, qqTex,
							  ChkInac.Checked, qqBol
							  )
					 )

			'para que solo muestre los destinos que hay en pantalla
			If CargoNodos Then
				For Each Fi As DataRow In Dt.Rows
					Buscando = 1
					BuscarNodo(TreeView1.Nodes(0), "", Fi("id"))
					If Buscando <> 2 Then 'no lo encontró
						Fi.Delete()
					End If
					Buscando = 0
				Next
			End If

			NoReloj()

			GrdBus.Visible = False
			'GrdBus.DMSLlene_Grid(Dt, "id", ColOcultas:=New Object() {"id"})

			GrdBus.DMSLlene_Grid(Dt, "id", ColOcultas:=New Object() {"abuelo", "padre"})
			ChkAbuelo.Checked = False
			GrdBus.Visible = True
			GrdBus.Grid.Columns("id").Width = 50


			If Dt.Rows.Count = 1 Then
				GrdBus_DMSCellClick2(GrdBus, GrdBus.Grid.SelectedRows(0).Cells("id").Value, Nothing)
				'GrdBus_DMSTraerValor(GrdBus, Gdf(Dt, "id"))
			Else
				GrdBus.Grid.ClearSelection()
			End If

		Catch ex As Exception
			Buscando = 0
			NoReloj()
			MostrarError(Me.Name, "ToolBus_Click", ex.Message)
			Exit Sub
		End Try

		'Varios = ""
		'BuscarNodo(TreeView1.SelectedNode, TexBuscar)

		'If Varios <> "" Then
		'    Varios = Strings.Mid(Varios, 1, Varios.Length - 1)
		'Else
		'    Mensaje("No encontró búsqueda")
		'    Exit Sub
		'End If

		'Dim Dt As DataTable = Filtrar_DataTable(DsDest.Tables(0), "id in(" & Varios & ")")
		'Dim Cual As String = ""
		'If Dt.Rows.Count > 1 Then
		'    Cual = Ventana(Dt, "", True, "id")
		'Else
		'    Cual = Gdf(Dt, "id")
		'End If

		'If Cual <> "" Then
		'    BuscarNodo(TreeView1.SelectedNode, "", Cual)
		'End If



	End Sub

	Private Sub fDestinos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
		'prueba
		If IdCuenta > 0 And Dimension > 0 And Not SoloCentros Then
			TreeView1.CollapseAll()
			CmdDestiCta_Click(CmdDestiCta, New EventArgs)
		End If

		'If NodoInicial > 0 Or IdCuenta > 0 Or Dimension > 0 Then
		'	TreeView1.Focus()
		'Else
		'	TxtBuscar.Focus()
		'End If

		'jdms 592: nueva forma de hacerlo
		'If TreeView1.SelectedNode IsNot Nothing Then
		'	TreeView1.Focus()
		'Else
		'	TxtBuscar.Focus()
		'End If
		'jdms 608: siempre foco aquí
		TxtBuscar.Focus()

		If SoloCentros Then
			TreeView1.ExpandAll()
		End If


		'If SplitContainer1.Panel2Collapsed = False Then
		'	TxtBuscar.Focus()
		'Else
		'	TreeView1.Focus()
		'End If
	End Sub

	Private Sub LnkVerAuditoria_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkVerAuditoria.LinkClicked
		If NoPuede4("0108", 300) Then
			Exit Sub
		End If

		Dim Sql As String = ""
		Sql &= "exec GetCotAuditoria "
		Sql &= "141"
		Sql &= "," & 0

		Sql &= "," & Numero_Empresa

		Dim DtAudit As New DataTable
		Abrir(DtAudit, Sql)

		Ventana(DtAudit, "Auditoría Destinos")
	End Sub


	Private Sub ToolMovto_Click(sender As Object, e As EventArgs) Handles ToolMovto.Click
		If NoPuede4("0108", 250) Then
			Exit Sub
		End If

		If Not TreeView1.SelectedNode.IsSelected Then
			Mensaje("No hay nodo seleccionado")
			Exit Sub
		End If


		Try
			SiReloj()
			Dim Sq As String = ""
			Sq = ArmeSQL("exec GetConDestinoMovtosUno",
					   TreeView1.SelectedNode.Name, qqNum
					   )
			Dim Dt As New DataTable
			Abrir(Dt, Sq)
			NoReloj()

			Ventana(Dt, "Movimiento " & TreeView1.SelectedNode.Text)

		Catch ex As Exception
			NoReloj()
			Mensaje("No se logró: " & ex.Message & EsIngles())
			Exit Sub

		End Try
	End Sub

	Private Sub ChkOcultarIDS_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOcultarIDS.CheckedChanged
		If Cargando Then Exit Sub

		SaveSetting("DMS S.A.", Me.Name, "verid", ChkOcultarIDS.Checked)

		LnkRefrescar_LinkClicked(LnkRefrescar, Nothing)

	End Sub

	Private Sub ToolPosicion_Click(sender As Object, e As EventArgs) Handles ToolPosicion.Click
		If NoPuede4("0108", 230) Then
			Exit Sub
		End If
		If Not TreeView1.SelectedNode.IsSelected Then
			Mensaje("No hay nodo seleccionado")
			Exit Sub
		End If
		If TreeView1.SelectedNode.Level < 2 Then
			Mensaje("Este nodo no puede moverse")
			Exit Sub
		End If
		If TreeView1.SelectedNode.PrevVisibleNode Is Nothing Then
			Mensaje("Este nodo no puede moverse")
			Exit Sub
		End If

		LblExplica.Text = "Haga clic en el nodo a donde desea moverlo" & DMScr(2) & "Nodo: " & TreeView1.SelectedNode.Text

		Ampliar_Pantalla()
		PnlMover.Visible = True
		CmdMover.Enabled = False

		NodoMover = TreeView1.SelectedNode


	End Sub

	Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
		If Not TreeView1.SelectedNode.IsSelected Then
			Exit Sub
		End If

		If PnlMover.Visible Then
			LblExplica.Text = "Desea mover el nodo?" & DMScr(2) & "Nodo: " & NodoMover.Text & DMScr(2) & "Mover a: " & TreeView1.SelectedNode.Text
			CmdMover.Enabled = True
			Exit Sub
		End If

		If MuchosNodos Then
			If TreeView1.SelectedNode.Level > 1 Then
				If TreeView1.SelectedNode.Nodes.Count = 0 Then
					CrearNodosDelPadre(Int32.Parse(TreeView1.SelectedNode.Name), TreeView1.SelectedNode, PrimeraVez:=False)
				End If
			End If
		End If


	End Sub

	Private Sub CmdCancelarMover_Click(sender As Object, e As EventArgs) Handles CmdCancelarMover.Click
		PnlMover.Visible = False

	End Sub

	Private Sub CmdMover_Click(sender As Object, e As EventArgs) Handles CmdMover.Click
		'moverlo

		Try
			SiReloj()

			Dim Sq As String = ArmeSQL("Exec PutConDestinoMover",
									 Numero_Empresa, qqNum,
									 Usuario, qqNum,
									 NodoMover.Name, qqNum,
									 TreeView1.SelectedNode.Name, qqNum,
									 FechaControl, qqFeh
									 )
			Dim Ds As New DataSet
			Abrir(Ds, Sq)

			PnlMover.Visible = False

			Montar_Nodos(NodoMover.Name, Ds)

			SonarWAV("OK")

			NoReloj()

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "CmdMover_Click", ex.Message)
			Exit Sub

		End Try

	End Sub

	Private Sub CmdAmpliar_Click(sender As Object, e As EventArgs) Handles CmdAmpliar.Click
		If SplitContainer1.Panel2Collapsed Then
			Ampliar_Pantalla()
		Else
			Reducir_Pantalla()
		End If

	End Sub
	Private Sub Ampliar_Pantalla()
		SplitContainer1.Panel2Collapsed = False
		CmdAmpliar.Text = "►"
		TxtBuscar.Focus()

	End Sub
	Public Sub Reducir_Pantalla()
		SplitContainer1.Panel2Collapsed = True
		CmdAmpliar.Text = "◄"
		TreeView1.Focus()

	End Sub

	Private Sub CmdDestiCta_Click(sender As Object, e As EventArgs) Handles CmdDestiCta.Click
		If Not CargoNodos Then
			Exit Sub
		End If

		If IdCuenta = 0 And Dimension = 0 Then
			Mensaje("No hay cuenta contable ni dimensión en esta ventana")
			Exit Sub
		End If

		If IdCuenta = 0 Then
			Exit Sub
		End If

		If Fin(DsDest.Tables(0)) Then
			Exit Sub
		End If

		Try
			SiReloj()

			Dim Dt As New DataTable
			Abrir(Dt, ArmeSQL("GetConDestinosCuales",
							  Numero_Empresa, qqNum,
							  IdCuenta, qqNum,
							  Dimension, qqNum
					)
				)

			GrdBus.Visible = True
			GrdBus.DMSLlene_Grid(Dt, "id", ColOcultas:=New Object() {"id"})

			If Dt.Rows.Count = 1 Then
				GrdBus_DMSTraerValor(GrdBus, Gdf(Dt, "id"))
			Else
				GrdBus.Grid.ClearSelection()
			End If

			'prueba
			For I As Integer = 0 To GrdBus.Grid.Rows.Count - 1
				BuscarNodo(TreeView1.Nodes(0), "", Tm(GrdBus.Grid, "id", I))
			Next

			NoReloj()

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "CmdDestiCta_Click", ex.Message)

		End Try
    End Sub

    Private Sub LnkExpandir_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkExpandir.LinkClicked
        TreeView1.ExpandAll()
        TreeView1.Focus()

    End Sub

    Private Sub ChkInac_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInac.CheckedChanged
        If ChkInac.Checked Then
            If NoPuede4("0108", 210) Then
                ChkInac.Checked = False
                Exit Sub
            End If
        End If

        ChkInac.Enabled = False
        LnkRefrescar_LinkClicked(Nothing, Nothing)
        ChkInac.Enabled = True

    End Sub

    Private Sub LnkVerTree_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkVerTree.LinkClicked
        LnkVerTree.Visible = False
        LblMensaje.Visible = False
        PnlMover.Visible = False

        Montar_Nodos(Todos:=True)
        GrdBus.Visible = False
        TreeView1.Focus()

        SonarWAV("ok")

    End Sub

    Private Sub GrdBus_DMSCellClick2(Sender As Object, ValorColDevolver As Object, e As DataGridViewCellEventArgs) Handles GrdBus.DMSCellClick2
        If CargoNodos Then
            BuscarNodo(TreeView1.Nodes(0), "", ValorColDevolver)
            TreeView1.Focus()
        End If

    End Sub

    Private Sub ChkAbuelo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAbuelo.CheckedChanged
        Try
            GrdBus.Grid.Columns("abuelo").Visible = ChkAbuelo.Checked
            GrdBus.Grid.Columns("padre").Visible = ChkAbuelo.Checked

        Catch ex As Exception

        End Try

    End Sub
    'SGQ-626: Destino Aut
    Private Sub Generar_Codigo_Aut(ByRef fCtas As fCtaDestinos)
        If CodAutDestino Then
            MaxDesti = 0 'SGQ-640: Reiniciar variable
            HayCodigo = ValD(TreeView1.SelectedNode.Text.Split(" ")(0).Replace(".", "")) > 0 'Si tiene codigo a la izquierda
            For Each Dr As DataRow In DsDest.Tables(0).Rows
                If ValD(Dr("id_padre")) = ValD(TreeView1.SelectedNode.Name) Then
                    If ValD(Dr("descripcion").Split(" ")(0).Replace(".", "")) > 0 Then
                        Cod = Mid(Dr("descripcion"), 1, InStr(Dr("descripcion"), " ") - 1)
                        If ValD(Cod.Replace(".", "")) > 0 Then 'Solo si en efecto vienen numeros
                            CodNext = Mid(Cod, 1, IIf(InStrRev(Dr("descripcion"), ".") > 0, InStrRev(Dr("descripcion"), ".") - 1, Len(Cod)))
                            If MaxDesti < ValD(Mid(Cod, 1 + InStrRev(Dr("descripcion"), "."))) Then
                                MaxDesti = ValD(Mid(Cod, 1 + InStrRev(Dr("descripcion"), ".")))
                            End If
                        End If
                    End If
                End If
            Next
            If CodNext = "" And HayCodigo Then 'Es el primer hijo
                CodNext = TreeView1.SelectedNode.Text.Split(" ")(0)
            End If
            MaxDesti += 1
            If HayCodigo Then
                CodNext = CodNext & "." & MaxDesti.ToString.PadLeft(NumCerosDestino, "0")
            Else
                CodNext = MaxDesti.ToString.PadLeft(NumCerosDestino, "0")
            End If
            fCtas.TxtCod.Text = CodNext
            fCtas.TxtCod.Tag = fCtas.TxtCod.Text
        End If
    End Sub
    '/SGQ-626: Destino Aut
End Class
