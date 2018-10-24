' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 655, 1-jun.-2018 12:53
' Version: 601, 29-nov.-2017 12:05
' Version: 590, 18-oct.-2017 18:37
Public Class fFormasPagoVentas
    'LFAA: 583 Formas de pago ventas
    Public Sql As String
    Public DtFormasPagoValor As New DataTable
    Dim DtFormasPago As New DataTable
    Dim Dr As DataRow

    Private Sub fFormasPagoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try
			'Lleno los combos, la grilla, calculo los valores y pongo el foco en el control TxtValorPagar
			Llenar_Datos()
			Sql = ArmeSQL("exec GetCotValoresFormasPagoSRI ", 0, qqNum, 0, qqNum)
			If Fin(DtFormasPagoValor) Then
				SiReloj()
				Abrir(DtFormasPagoValor, Sql)
				Cargar_Grid()
				NoReloj()
			End If
			Calcular_Valores()
			TxtValorPagar.Focus()
			'RegistroFormaPago = True
		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "fFormasPagoVentas_Load", ex.Message)
		End Try
	End Sub
	Private Sub Llenar_Datos()
		Try
			Sql = ArmeSQL("exec GetCotFormasPagoSRI ", "")
			SiReloj()
			Abrir(DtFormasPago, Sql)
			If Fin(DtFormasPago) Then
				Mensaje("No se encontraron datos en la consulta")
				Exit Sub
			End If
			CbFormaPago.DMSLlene_Combo(DtFormasPago, "id", "descripcion")
			CbFormaPago.ComboBox1.SelectedIndex = 0
			'CbFormaPago.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			CbUnidad.SelectedIndex = 0
			NoReloj()
		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "Llenar_Datos", ex.Message)
		End Try
	End Sub
	Private Sub Cargar_Grid()
		Try
			Grd.DMSLlene_Grid(DtFormasPagoValor, "id",
												 ColOcultas:={"id", "id_cot_cotizacion", "id_cot_notas_deb_cre"},
												 ColMoneda:={"valor"})
		Catch ex As Exception
			MostrarError(Me.Name, "Cargar_Grid", ex.Message)
		End Try
	End Sub

	Public Sub Encerar_Controles()
		Try
			TxtValorPagar.Text = ""
			TxtPlazo.Text = ""
			CbUnidad.SelectedIndex = 0
		Catch ex As Exception
			MostrarError(Me.Name, "Encerar_Controles", ex.Message)
		End Try
	End Sub

	Private Sub Calcular_Valores()
		Try
			Dim calculoTotal As Double = 0
			For Each Row As DataRow In DtFormasPagoValor.Rows
				calculoTotal += ValD(Row("valor"))
			Next
			LblPagado.Text = FormatoMoneda(calculoTotal, False, False) 'JFG-655 Se Quitan los Decimales
		Catch ex As Exception
			MostrarError(Me.Name, "Calcular_Valores", ex.Message)
		End Try
	End Sub

	Public Function Ingresar_Valores(TipoDocumento As String) As String
		Try
			Sql = ""
			'Armo el sql para inserción con cada una de las filas del DataTable
			For Each Row As DataRow In DtFormasPagoValor.Rows
				Sql &= ArmeSQL("exec PutCotValoresFormasPagoSRI @id, ",
														 TipoDocumento, qqNum,
														 ValD(Row("id")), qqNum,
														 ValD(Row("valor")), qqNum,
														 ValD(Row("plazo")), qqNum,
														 Row("unidad"), qqTex)
			Next
			'RegistroFormaPago = False
			Return Sql
		Catch ex As Exception
			MostrarError(Me.Name, "Ingresar_Valores", ex.Message)
			Return Nothing
		End Try
	End Function

	Public Sub Ingresar_Valores2(id As Integer, TipoDocumento As String)
		Try
			Sql = ""
			'Armo el sql para inserción con cada una de las filas del DataTable y ejecuto la instrucción
			For Each Row As DataRow In DtFormasPagoValor.Rows
				Sql &= ArmeSQL("exec PutCotValoresFormasPagoSRI ", id, qqNum,
														 TipoDocumento, qqNum,
														 ValD(Row("id")), qqNum,
														 ValD(Row("valor")), qqNum,
														 ValD(Row("plazo")), qqNum,
														 Row("unidad"), qqTex)
			Next
			Ejecutar(Sql)
			'RegistroFormaPago = False
		Catch ex As Exception
			MostrarError(Me.Name, "Ingresar_Valores2", ex.Message)
		End Try
	End Sub

	Public Sub Eliminar_Valores(id As Integer, TipoDocumento As String)
		Try
			Sql = ""
			'Armo el sql para inserción con cada una de las filas del DataTable y ejecuto la instrucción
			Sql &= ArmeSQL("exec DelCotValoresFormasPagoSRI ", id, qqNum,
														 TipoDocumento, qqNum)
			Ejecutar(Sql)
			'RegistroFormaPago = False
		Catch ex As Exception
			MostrarError(Me.Name, "Ingresar_Valores2", ex.Message)
		End Try
	End Sub

	Private Sub Eliminar_Fila(sender As Object, e As EventArgs)
		Try
			If Fin(DtFormasPagoValor) Then Exit Sub
			Dr = DtFormasPagoValor.Rows.Item(Grd.Grid.CurrentRow.Index)
			DtFormasPagoValor.Rows.Remove(Dr)
			Cargar_Grid()
			Calcular_Valores()
			Encerar_Controles()
			CmdOk.Tag = -1
			If ValD(LblValorDocumento.Text) = ValD(LblPagado.Text) Then
				CmdConti_Click(sender, e)
			Else
				TxtValorPagar.Focus()
			End If
		Catch ex As Exception
			MostrarError(Me.Name, "Eliminar_Fila", ex.Message)
		End Try
	End Sub
	Private Sub CmdNueva_Click(sender As Object, e As EventArgs) Handles CmdNueva.Click
		Try
			Encerar_Controles()
			CmdOk.Tag = -1
		Catch ex As Exception
			MostrarError(Me.Name, "CmdNueva_Click", ex.Message)
		End Try
	End Sub

	Private Sub CmdOk_Click(sender As Object, e As EventArgs) Handles CmdOk.Click
		Try
			If (CmdOk.Tag = -1 Or CmdOk.Tag Is Nothing) And ValD(LblValorDocumento.Text) = ValD(LblPagado.Text) Then
				CmdConti_Click(sender, e)
				Exit Sub
			End If
			'Validaciones
			If CbFormaPago.DMSTraerId <= 0 Then
				Mensaje("Falta forma de pago")
				CbFormaPago.Focus()
				Exit Sub
			End If
			If ValD(TxtValorPagar.Text) <= 0 Then
				Mensaje("Ingrese valor a pagar")
				TxtValorPagar.Focus()
				Exit Sub
			End If
			If ValD(TxtPlazo.Text) <= 0 Then
				Mensaje("Ingrese plazo")
				TxtPlazo.Focus()
				Exit Sub
			End If
			If CmdOk.Tag = -1 Or CmdOk.Tag Is Nothing Then
				If Not Fin(Filtrar_DataTable(DtFormasPagoValor, "id=" & ValD(CbFormaPago.DMSTraerId))) Then
					Mensaje("La forma de pago ya ha sido añadida")
					CbFormaPago.Focus()
					Exit Sub
				End If
			End If
			'Añado las filas al DataTable
			If CmdOk.Tag = -1 Or CmdOk.Tag Is Nothing Then
				Dr = DtFormasPagoValor.NewRow
			Else
				Dr = DtFormasPagoValor.Rows.Item(Grd.Grid.CurrentRow.Index)
			End If
			Dr.Item("id") = ValD(CbFormaPago.DMSTraerId())
			Dr.Item("descripcion") = CbFormaPago.DMSTraerTexto
			Dr.Item("valor") = ValD(TxtValorPagar.Text)
			Dr.Item("plazo") = ValD(TxtPlazo.Text)
			Dr.Item("unidad") = CbUnidad.Text
			If CmdOk.Tag = -1 Or CmdOk.Tag Is Nothing Then
				DtFormasPagoValor.Rows.Add(Dr)
				DtFormasPagoValor.AcceptChanges()
			End If
			'LLeno la grilla, calculo el valor pagado y encero los controles
			Cargar_Grid()
			Calcular_Valores()
			Encerar_Controles()
			CmdOk.Tag = -1
			'Compruebo si el valor del documento es igual al pagado y dependiendo de eso llamo al botón CmdConti o regreso el foco al control TxtValorPagar
			If ValD(LblValorDocumento.Text) = ValD(LblPagado.Text) Then
				CmdConti_Click(sender, e)
			Else
				TxtValorPagar.Focus()
			End If
		Catch ex As Exception
			MostrarError(Me.Name, "CmdOk_Click", ex.Message)
		End Try
	End Sub

	Private Sub Editar_Fila()
		Try
			If Fin(DtFormasPagoValor) Then Exit Sub
			CbFormaPago.DMSPongaIndex(ValD(Tm(Grd.Grid, "id")))
			TxtValorPagar.Text = Tm(Grd.Grid, "valor")
			TxtPlazo.Text = Tm(Grd.Grid, "plazo")
			CbUnidad.Text = Tm(Grd.Grid, "unidad")
			CmdOk.Tag = Grd.Grid.CurrentRow.Index
		Catch ex As Exception
			MostrarError(Me.Name, "Editar_Fila", ex.Message)
		End Try
	End Sub

	Private Sub CmdConti_Click(sender As Object, e As EventArgs) Handles CmdConti.Click
		Try
			'Valido el valor total contra el valor pagado
			If ValD(LblValorDocumento.Text) <> ValD(LblPagado.Text) Then
				Mensaje("El valor pagado debe ser igual al valor del documento")
				TxtValorPagar.Focus()
				Exit Sub
			Else
				Me.Tag = "S"
			End If
			Me.Close()
		Catch ex As Exception
			MostrarError(Me.Name, "CmdConti_Click", ex.Message)
		End Try
	End Sub

	Private Sub LblValorDocumento_Click(sender As Object, e As EventArgs) Handles LblValorDocumento.Click
		Try
			TxtValorPagar.Text = FormatoMoneda(ValD(LblValorDocumento.Text) - ValD(LblPagado.Text), False, False)
		Catch ex As Exception
			MostrarError(Me.Name, "LblValorDocumento_Click", ex.Message)
		End Try
	End Sub

	Private Sub TxtValorPagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValorPagar.KeyPress, TxtPlazo.KeyPress
		SoloNumeros(e)
	End Sub

	Private Sub TxtValorPagar_Leave(sender As Object, e As EventArgs) Handles TxtValorPagar.Leave
		If Not IsNumeric(sender.Text) Then
			sender.Text = ""
			Exit Sub
		End If
		sender.Text = FormatoMoneda(ValD(sender.Text), False, False)
	End Sub

	Private Sub Grd_DMSTraerValorEliminar(Sender As Object, ValorColDevolver As Object, Fila As Integer) Handles Grd.DMSTraerValorEliminar
		Try
			Eliminar_Fila(Sender, New EventArgs)
		Catch ex As Exception
			MostrarError(Me.Name, "Grd_DMSTraerValorEliminar", ex.Message)
		End Try
	End Sub

	Private Sub Grd_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles Grd.DMSTraerValor
		Try
			Editar_Fila()
		Catch ex As Exception
			MostrarError(Me.Name, "Grd_DMSTraerValor", ex.Message)
		End Try

    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Tag = 0
    End Sub
    '/LFAA: 583 Formas de pago ventas
End Class