' Version: 684, 25-ago.-2018 20:17
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 21-ago.-2018 10:37
' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fBusVeh

    Private Sub fBusVeh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GrdSeriales.Grid.DataSource Is Nothing Then
            TabControl1.TabPages.Remove(TbVins)
        End If

        Cargar_Items()

        Llene_Combos()

        NoReloj()

    End Sub
    Public Sub Llene_Combos()
        If CbColor_Interno.Items.Count > 0 Then Exit Sub

        SiReloj()

        Try
            CbNuevo.SelectedIndex = 0
            CbStock.SelectedIndex = 0

            Cargar_Colores()

            If DtVehMarca.Rows.Count = 0 Then
                Cargar_Veh_Modelos()
                Cargar_Colores()
            End If

            ponga_marcas()


			Llene_Combo5(CbColor_interno, DtColores, "id", "descripcion", , , "Todos", 0)
			Llene_Combo5(CbColor_externo, DtColores, "id", "descripcion", , , "Todos", 0)


			If DtPais.Rows.Count = 0 Then
				Dim Ds As New DataSet
				Abrir(Ds,
				  "Exec GetCotClientePais " & Numero_Empresa & DMScr() &
				 "")
				'"Exec GetCotCiudades " & Numero_Empresa.ToString & ",1" & DMScr() &
				DtPais = Ds.Tables(0).Copy
				'DtCi = Ds.Tables(1).Copy
			End If

			Llene_Combo5(CbPais_Pais, DtPais, "id", "descripcion", "id_cot_cliente_pais is null", , "(No Aplica)", 0)


			Dim bodtag As String = "" 'no todas
			If ReglaDeNegocio(149, "usu" & Usuario.ToString, "0") = "1" Or DtBodegas.Rows.Count = DtBodegasPerm.Rows.Count Then
				bodtag = "S" 'todas
			End If
			CbBod.DMSLlene_Combo(DtBodegas, "id", "descripcion", "IsNull(anulada,0)=0" & IIf(bodtag = "S", "", " and permitida=1"), , "Todas las bodegas", BodegaUsuario)


			Cargar_Clases_y_Servicios()

			Llene_Combo5(CbClase, DtClaseVeh, "id", "descripcion", , , "Todas", 0)
			Llene_Combo5(CbServicio, DtServicioVeh, "id", "descripcion", , , "Todos", 0)


		Catch ex As Exception
			MostrarError(Me.Name, "llene_combos", ex.Message)

		End Try


		NoReloj()

	End Sub

	Private Sub Ponga_Marcas()
		Dim Marcas As String = ReglaDeNegocio(134, "marcas", "")
		If Marcas <> "" Then
			Marcas = "id_veh_marca in(" & Marcas & ")"
		End If
		Llene_Combo5(CbMarca, DtVehMarca, "id_veh_marca", "marca", Marcas, "marca", "Todas", 0, False)

	End Sub
	Private Sub CbMarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbMarca.SelectedIndexChanged
		CbLinea.Items.Clear()
		CbModelo.Items.Clear()


		LblIDMarca.Text = TraerId(CbMarca)
		LblIDMarca.Visible = ValD(LblIDMarca.Text) > 0

		If CbMarca.SelectedIndex < 0 Then Exit Sub

		Llene_Combo5(CbLinea, DtVehLinea, "id_veh_linea", "linea", "id_veh_marca=" & TraerId(CbMarca), "linea", "Todas", 0, False)

	End Sub
	Private Sub CbLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbLinea.SelectedIndexChanged

		LblIDLin.Text = TraerId(CbLinea)
		LblIDLin.Visible = ValD(LblIDLin.Text) > 0

		CbModelo.Items.Clear()

		If CbLinea.SelectedIndex < 0 Then Exit Sub

		Llene_Combo5(CbModelo, DtVehModelo, "id_veh_linea_modelo", "modelo", "id_veh_linea=" & TraerId(CbLinea), "modelo", "Todos", 0, False)

	End Sub
	Private Sub CbModelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbModelo.SelectedIndexChanged

		LblIDMod.Text = TraerId(CbModelo)
		LblIDMod.Visible = ValD(LblIDMod.Text) > 0


		'If CbModelo.SelectedIndex < 0 Then Exit Sub

		'Llene_Combo5(CbAño, DtItem, "id", "ano", "id_veh_linea_modelo=" & TraerId(CbModelo), "ano", "Todos", 0, False)





	End Sub





	Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) Handles CmdBuscar.Click

		If ChkFechaVence.Checked Then
			If FechaSinHora(TxtFecSup.Value) < FechaSinHora(TxtFecInf.Value) Then
				Mensaje("Fecha vence seguro superior debe ser mayor o igual a la inferior")
				Exit Sub
			End If
		End If

		TxtPlaca.Text = TxtPlaca.Text.Trim.Replace("'", "")
		TxtDescripcion.Text = TxtDescripcion.Text.Trim.Replace("'", "")
		TxtVIN.Text = TxtVIN.Text.Trim.Replace("'", "")
		TxtMotor.Text = TxtMotor.Text.Trim.Replace("'", "")
		TxtChasis.Text = TxtChasis.Text.Trim.Replace("'", "")
		TxtLicTransito.Text = TxtLicTransito.Text.Trim.Replace("'", "")


		Try
			SiReloj()

			Dim Dt As New DataTable
			Dim Sq As String = ""
			'Sq &= "GetVehSeriales " 'aqui es total sin bodega
			Sq &= "GetVehSeriales_Bod " 'aqui solo la bodega pedida o todas
			Sq &= Numero_Empresa & ","
			Sq &= CbBod.DMSTraerId & ","
			Sq &= ValD(TxtModAno.Tag) & ","
			Sq &= TraerId(CbMarca) & ","
			Sq &= TraerId(CbLinea) & ","
			Sq &= TraerId(CbModelo) & ","
			Sq &= IIf(ChkBuscarVIN.Checked, 1, 0) & ","
			Sq &= IIf(ChkTotales.Checked, 1, 0) & ","
			Sq &= IIf(ChkVacios.Checked, 1, 0) & ","
			Sq &= "'" & TxtPlaca.Text & "',"
			Sq &= "'" & TxtDescripcion.Text & "',"
			Sq &= TraerId(CbPais_Ciudad) & ","
			Sq &= TraerId(CbClase) & ","
			Sq &= TraerId(CbServicio) & ","
			Sq &= TraerId(CbColor_externo) & ","
			Sq &= TraerId(CbColor_interno) & ","
			Sq &= ValD(TxtAñoInf.Text) & ","
			Sq &= ValD(TxtAñoSup.Text) & ","
			Sq &= CbNuevo.SelectedIndex & ","
			Sq &= CbStock.SelectedIndex & ","
			Sq &= ValDMS(ValD(TxtPresupuesto.Text)) & ","
			Sq &= ValDMS(ValD(TxtPresupuestoMaximo.Text)) & ","
			Sq &= "'" & TxtVIN.Text & "',"
			Sq &= "'" & TxtMotor.Text & "',"
			Sq &= "'" & TxtChasis.Text & "',"
			Sq &= "'" & TxtLicTransito.Text & "',"
			Sq &= LblPropietario.DMSTraerIDContacto & ","
			Sq &= LblAseguradora.DMSTraerID & ","
			If ChkFechaVence.Checked Then
				Sq &= "'" & FmtFecSQL(FechaSinHora(TxtFecInf.Value)) & "',"
				Sq &= "'" & FmtFecSQL(FechaSinHora(TxtFecSup.Value) & " 23:59:59") & "'"
			Else
				Sq &= "'',"
				Sq &= "'',"
			End If
			Sq &= ValD(TxtKmMin.Text) & ","
			Sq &= ValD(TxtKmMax.Text) '& ","




			Abrir(Dt, Sq)

			If Fin(Dt) Then
				NoReloj()
				Mensaje("No encontró resultados")
				Exit Sub
			End If

			If Not TabControl1.TabPages.Contains(TbVins) Then
				TabControl1.TabPages.Add(TbVins)
			End If


			TabControl1.SelectedTab = TbVins

			'limpiar datos solo cuando hay totales
			Dim OcultarDes As String = ""
			If ChkTotales.Checked Then
				OcultarDes = "descripcion"
				For Each Fi As DataRow In Dt.Rows
					If IsDBNull(Fi("id_vin")) Then
						Fi("color") = Fi("descripcion")
					Else
						Fi("color") = "     " & Fi("color")
					End If
				Next
			End If


			'GrdSeriales.DMSLlene_Grid(Dt, NombreColDevolver:="modelo_ano", MostrarEliminar:=False, ColOcultas:=New Object() {"vin", "id_veh_linea", "id", "id_vin", "modelo_ano", "fecha_creacion", "notas", OcultarDes})
			'no ocultar columnas pues el software de "Columnas" no trabajará bien
			GrdSeriales.DMSLlene_Grid(Dt, NombreColDevolver:="modelo_ano", MostrarEliminar:=False, ColOcultas:=New Object() {OcultarDes})

			CCols.Mostrar_Columnas("2098" & IIf(ChkBuscarVIN.Checked, "", "S"), GrdSeriales.Grid)

			Pintar_Totales()


			GrdSeriales.Grid.ClearSelection()

		Catch ex As Exception
			MostrarError(Me.Name, "CmdBuscar_Click", ex.Message)

		End Try

		NoReloj()
	End Sub
	Private Sub Pintar_Totales()
		Try
			If ChkTotales.Checked Then
				GrdSeriales.DMSQuitarSort() 'no se puede hacer sort pues tiene totales
				For Each ro As DataGridViewRow In GrdSeriales.Grid.Rows
					If "" & ro.Cells("vin").Value = "" Then 'es total de modelo-año
						'ro.DefaultCellStyle.BackColor = Color.Red
						ro.DefaultCellStyle.Font = ChkTotales.Font
					End If
				Next
			End If
		Catch ex As Exception

		End Try

	End Sub
	Private Sub GrdSeriales_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles GrdSeriales.DMSTraerValor
		'TxtCodigo.Text = GrdItem.Grid.Tag 'aqui está el código
		'TxtCodigo_Validated(TxtCodigo, New EventArgs)


		'TxtVIN.Text = Tm(GrdSeriales.Grid, "vin")
		'TxtVIN_Validated(TxtVIN, New EventArgs)

		'TabControl1.SelectedTab = TbCrear
		Regresar_Con_Dato()

	End Sub

	Private Sub Regresar_Con_Dato()

		GrdSeriales.Tag = Tm(GrdSeriales.Grid, "modelo_ano")

		If GrdSeriales.Grid.Columns.Contains("id_vin") Then
			If ValD(Tm(GrdSeriales.Grid, "id_vin")) > 0 Then 'si tiene vin, concatenarlo
				GrdSeriales.Tag &= "|" & Tm(GrdSeriales.Grid, "vin") & "|" & Tm(GrdSeriales.Grid, "id_vin")
			End If
		End If


		Me.Close()

	End Sub

	Private Sub CbPais_Pais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbPais_Pais.SelectedIndexChanged
		CbPais_Depto.Items.Clear()
		CbPais_Ciudad.Items.Clear()
		If TraerId(CbPais_Pais) = 0 Then Exit Sub

		Llene_Combo5(CbPais_Depto, DtPais, "id", "descripcion", "id_cot_cliente_pais=" & TraerId(CbPais_Pais), , "Todos", 0)

	End Sub

	Private Sub CbPais_Depto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbPais_Depto.SelectedIndexChanged
		CbPais_Ciudad.Items.Clear()
		If TraerId(CbPais_Depto) = 0 Then Exit Sub

		Llene_Combo5(CbPais_Ciudad, DtPais, "id", "descripcion", "id_cot_cliente_pais=" & TraerId(CbPais_Depto), , "Todas", 0)

	End Sub

	Private Sub TxtAñoInf_Validated(sender As Object, e As EventArgs) Handles TxtAñoInf.Validated, TxtAñoSup.Validated
		If ValD(sender.text) < 0 Or ValD(sender.text) > Year(Now) + 2 Then
			Mensaje("Año inválido")
			sender.clear()
		End If

	End Sub

	Private Sub CbNuevo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNuevo.SelectedIndexChanged
		TxtKmMin.Visible = CbNuevo.SelectedIndex <> 1
		TxtKmMax.Visible = CbNuevo.SelectedIndex <> 1
		LblKim.Visible = CbNuevo.SelectedIndex <> 1

		If CbNuevo.SelectedIndex = 1 Then 'nuevos
			TxtKmMin.Clear()
			TxtKmMax.Clear()
		End If

	End Sub

	Private Sub TxtPresupuesto_Validated(sender As Object, e As EventArgs) Handles TxtPresupuesto.Validated, TxtPresupuestoMaximo.Validated
		If Not IsNumeric(sender.text) Then
			sender.clear()
		Else
			If ValD(sender.text) < 0 Or ValD(sender.text) > 10000000000 Then 'máximo 10 mil millones
				sender.clear()
			Else
				sender.text = FormatoMoneda(sender.text)
			End If
		End If


	End Sub

	Private Sub TxtModAno_TextChanged(sender As Object, e As EventArgs) Handles TxtModAno.TextChanged
		LblDesModAno.Text = ""
		TxtModAno.Tag = ""

	End Sub

	Private Sub TxtModAno_Validated(sender As Object, e As EventArgs) Handles TxtModAno.Validated
		If LblDesModAno.Text <> "" Then Exit Sub
		If TxtModAno.Text.Trim = "" Then Exit Sub
		ConseguirItem(TxtModAno.Text)
		If TxtModAno.Text.Trim = "" Then
			Mensaje("Modelo año no existe")
			TxtModAno.Clear()
			TxtModAno.Focus()
			Exit Sub
		End If



		Dim It As DataRow = DtItem.Rows.Find(TxtModAno.Text)
		If ValD(It("id_veh_ano")) = 0 Then
			Mensaje("Este no es un modelo-año")
			TxtModAno.Clear()
			TxtModAno.Focus()
			Exit Sub
		End If

		TxtModAno.Tag = It("id")
		LblDesModAno.Text = It("descripcion")

	End Sub


	Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
		LblPropietario.DMSLimpieClienteContacto()

	End Sub

	Private Sub LnkNueva_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkNueva.LinkClicked
		PongaIndex(CbMarca, 0)
		TxtModAno.Clear()
		LblPropietario.DMSLimpieClienteContacto()
		LblAseguradora.DMSLimpieClienteContacto()
		TxtPlaca.Clear()
		TxtDescripcion.Clear()
		TxtVIN.Clear()
		TxtMotor.Clear()
		TxtChasis.Clear()
		PongaIndex(CbColor_externo, 0)
		PongaIndex(CbColor_interno, 0)
		PongaIndex(CbClase, 0)
		PongaIndex(CbServicio, 0)
		CbNuevo.SelectedIndex = 0
		CbStock.SelectedIndex = 0
		ChkVacios.Checked = False

		PongaIndex(CbPais_Pais, 0)
		TxtKmMin.Clear()
		TxtKmMax.Clear()
		TxtAñoInf.Clear()
		TxtAñoSup.Clear()
		TxtPresupuesto.Clear()
		TxtPresupuestoMaximo.Clear()
		TxtLicTransito.Clear()
		ChkFechaVence.Checked = False


		TabControl1.SelectedTab = TbBuscar

		TabControl1.TabPages.Remove(TbVins)


		CbMarca.Focus()
		TxtPlaca.Focus()



	End Sub
	Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
		LblAseguradora.DMSLimpieClienteContacto()

	End Sub

	Private Sub ChkFechaVence_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFechaVence.CheckedChanged
		PnlRangoFechas.Visible = ChkFechaVence.Checked

	End Sub

	Private Sub fBusVeh_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
		Pintar_Totales()

		If ChkBuscarVIN.Checked Then
			TxtPlaca.Focus()
		Else
			TxtModAno.Focus()
		End If

	End Sub

	Private Sub TxtPlaca_Validated(sender As Object, e As EventArgs) Handles TxtPlaca.Validated
		TxtPlaca.Text = Filtro_Sector(TxtPlaca.Text)

	End Sub

	Private Sub TxtBusPlaca_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPlaca.KeyDown
		If e.KeyCode = Keys.Enter Then
			CmdBuscar.PerformClick()
		End If

	End Sub

	Private Sub ChkBuscarVIN_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBuscarVIN.CheckedChanged
		ChkVacios.Visible = Not ChkBuscarVIN.Checked
		If ChkBuscarVIN.Checked Then
			ChkVacios.Checked = False
		End If

		ChkTotales.Checked = False

		PnlVeh.Visible = ChkBuscarVIN.Checked
		ChkTotales.Visible = ChkBuscarVIN.Checked
		TxtPlaca.Focus()

	End Sub

	Private Sub fBusVeh_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
		If e.KeyCode = Keys.Escape Then
			e.SuppressKeyPress = True
			If TabControl1.SelectedTab Is TbVins Then
				TabControl1.SelectedTab = TbBuscar
			Else
				GrdSeriales.Tag = ""
				Me.Close()
			End If
			Exit Sub
		ElseIf e.KeyCode = Keys.Enter Then
			e.SuppressKeyPress = True
			If TabControl1.SelectedTab Is TbVins Then

				If GrdSeriales.Grid.SelectedRows.Count = 0 And GrdSeriales.Grid.Rows.Count > 0 Then 'si no tiene nada seleccionado seleccionar la primera
					GrdSeriales.Grid.Rows(0).Selected = True
				End If
				If GrdSeriales.Grid.SelectedRows.Count > 0 Then
					Regresar_Con_Dato()
				End If
			Else
				CmdBuscar.PerformClick()
			End If
		End If

	End Sub

	Private Sub LnkCols_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkCols.LinkClicked
		CCols.Cambiar_Columnas("2098" & IIf(ChkBuscarVIN.Checked, "", "S"), GrdSeriales.Grid)

	End Sub



	Private Sub ChkTotales_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTotales.CheckedChanged
		TxtPlaca.Focus()

	End Sub

	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

		Try

			SiReloj()

			GrdSeriales.Grid.DataSource = Nothing

			Dim dt As New DataTable
			Abrir(dt, "GetVehBuscar2002 " & Numero_Empresa & "," & TraerId(CbMarca) & "," & TraerId(CbLinea) & "," & TraerId(CbModelo))
			NoReloj()
			If Fin(dt) Then
				Mensaje("No encontró datos")
				Exit Sub
			End If

			TxtModAno.Text = Ventana(dt, "Búsqueda modelo-año", True, "modelo_ano")
			TxtModAno_Validated(TxtModAno, New EventArgs)
			TxtModAno.Focus()

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "CmdCargarModAno_Click", ex.Message)

		End Try



	End Sub

	Private Sub LnkMarca_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkMarca.LinkClicked
		Try
			If Pregunte("Desea refrescar Marcas, Líneas, Modelos y Colores?" & DMScr(2) & "Nota: Utilice el programa 2001 o 4181 para creación") Then
				SiReloj()
				fBusIt.Haga_Leer_Lineas()
				Ponga_Marcas()
				SonarWAV("OK")
			End If

		Catch ex As Exception
			MostrarError(Me.Name, "LnkMarca_LinkClicked", ex.Message)

		End Try

        NoReloj()
    End Sub
End Class