' Version: 684, 25-ago.-2018 20:17
' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
' Version: 674, 9-ago.-2018 12:39
' Version: 640, 3-abr.-2018 13:06
' Version: 626, 16-feb.-2018 12:38
' Version: 604, 7-dic.-2017 18:14
' Version: 603, 5-dic.-2017 19:15
' Version: 593, 27-oct.-2017 09:31
' Version: 592, 25-oct.-2017 19:06
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fCtaDestinos
    Dim EsF1 As Boolean = False
    Public FechaControl As DateTime
    Public IdProducido As Integer = 0
    Public Modif As Boolean = False
    Public Dimension As Integer = 0
    Dim SoloCentros As Boolean
    Public TamDestino As Integer 'SGQ-626: Destino Aut
    Public Guardo As Boolean 'SGQ-640: Garantizando que se guardó

    Private Sub fCtaDestinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiReloj()

		SoloCentros = ReglaDeNegocio(146, "destinos_cen", "0") = "1"



		Try
            'Cargar_Tipo_Ret_item()

            'Llene_Combo5(CbTipoRet, DtTipoRetItem, "id", "descripcion")
            Dim Sq As String = ""
            Sq &= "GetConCtaDestinos " & IIf(Modif, Me.Tag, 0) & DMScr()
            If DtCco.Rows.Count = 0 Then
                Sq &= "Exec GetConCco " & Numero_Empresa.ToString & DMScr()
            End If

            Dim ds As New DataSet
            Abrir(ds, Sq)

            If DtCco.Rows.Count = 0 Then
                DtCco = ds.Tables(1)
            End If


            Haga_Grid_Cli(ds.Tables(0))

			If SoloCentros Then
				LnkRet0.Visible = False
				LblRet0.Visible = False
				LblTit0.Visible = False
				LnkRefres.Visible = False
				CmdOK.Text = "Adicionar centro"
				LblCentro.Visible = True
				TxtCentro.Visible = True
			End If

		Catch ex As Exception
            NoReloj()
			MostrarError(Me.Name, "fTributarioItem_Load", ex.Message)
			Me.Close()
			Exit Sub
		End Try

		GrdCli.Tag = -1

		NoReloj()
	End Sub

	Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles CmdOK.Click
		If Not SoloCentros Then
			If ReglaDeNegocio(146, "destinos_ctr", "0") <> "1" Then
				Mensaje("Para crea cuentas aquí, debe activar la llave [destinos_ctr] de la Rn#146")
				Exit Sub
			End If

			If LblRet0.Text = "" Or ValD(LblRet0.Tag) = 0 Then
				Mensaje(Idi("Falta") & " " & LnkRet0.Text)
				Exit Sub
			End If
		End If

		If TxtCentro.Visible And ValD(TxtCentro.Tag) = 0 Then
			Mensaje("Falta centro")
			TxtCentro.Focus()
			Exit Sub
		End If


		''ingresar la ope
		If GrdCli.Tag = -1 Then
			For I As Integer = 0 To GrdCli.Grid.Rows.Count - 1
				If ValD(Tm(GrdCli.Grid, "id_con_cta", I)) = ValD(LblRet0.Tag) And
					ValD(Tm(GrdCli.Grid, "id_con_cco", I)) = ValD(TxtCentro.Tag) Then
					Mensaje("Ya existe")
					Exit Sub
				End If
			Next
		End If

		Dim DtTemp As DataTable = GrdCli.Grid.DataSource

		'Inserta una nueva fila al datatable temporal
		Dim fi As DataRow
		If GrdCli.Tag = -1 Then
			fi = DtTemp.Rows.Add
			GrdCli.Tag = DtTemp.Rows.Count - 1
		Else
			fi = DtTemp.Rows(GrdCli.Tag)
		End If
		fi("modif") = 1


		fi("id_con_cta") = ValD(LblRet0.Tag)
		fi("codigo") = LblRet0.Text
		fi("descripcion") = LblTit0.Text
		fi("centro") = TxtCentro.Text
		fi("id_con_cco") = ValD(TxtCentro.Tag)


		fi.AcceptChanges()

		Haga_Grid_Cli(DtTemp)

		'posicionar renglón
		'Grd.DMSMostrar_Fila_Seleccionada(Grd.Grid, "codigo", TxtCod.Text, 5)
		GrdCli.Grid.Rows(GrdCli.Tag).Selected = True
		If GrdCli.Tag >= 4 Then
			GrdCli.Grid.FirstDisplayedScrollingRowIndex = GrdCli.Tag - 4 'el 4 es para que deje 4 líneas arriba
		End If


		'hacer nuevo, de último
		Nuevo_Cli_Tempario()
		LblRet0.Focus()


	End Sub
	Private Sub Nuevo_Cli_Tempario()
		GrdCli.Tag = -1
		LblRet0.Text = ""
		TxtCentro.Text = ""
		TxtCentro.Tag = ""

		CmdOK.Text = "Adicionar"
		'CbTipoRet.SelectedIndex = -1
		'TxtRet.Text = ""
		'TxtMinimo.Text = ""
		'LblRet0.Text = ""
		'LblRet1.Text = ""


	End Sub
	Private Sub LnkNuevoCli_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkNuevoCli.LinkClicked
		Nuevo_Cli_Tempario()
		LblRet0.Focus()

	End Sub

	Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles CmdActualizar.Click
		If Falta_Licencia("1054") Then
			Exit Sub
		End If


		If Modif Then
			If NoPuede4("0108", 150) Then
				Exit Sub
			End If
		Else
			If NoPuede4("0108", 100) Then
				Exit Sub
			End If
		End If
		If TxtDestino.Text.Trim = "" Then
			Mensaje("Falta descripción destino")
			Exit Sub
		End If

		'SGQ-626: Destino Aut
		Dim Nombre As String = TxtDestino.Text
		If TxtCod.Visible Then
			If TxtCod.Text <> TxtCod.Tag And TxtCod.Tag <> "" Then
				If Not Pregunte("El código de destino que pretende crear no corresponde al sugerido por el sistema: " & TxtCod.Tag & " ¿Seguro de continuar?") Then Exit Sub
			End If
			If TxtCod.Text <> "" Then
				Nombre = TxtCod.Text.PadRight(TamDestino, " ") & " " & TxtDestino.Text
			End If
		End If
		'/SGQ-626: Destino Aut

		Dim Sq As String = ""
		Sq &= "Begin Try" & DMScr()
		Sq &= "BEGIN TRANSACTION" & DMScr()

		'hacer lo del nombre
		'SGQ-626: Ahora la descripción es con la variable Nombre
		If Modif Then
			Sq &= ArmeSQL("exec PutConDestinoModif",
					   Numero_Empresa, qqNum,
					   Usuario, qqNum,
					   Me.Tag, qqNum,
					   Nombre, qqTex,
					   ValD(PictureBox1.Tag), qqNum,
					   FechaControl, qqFeh,
					   IIf(GrdCli.Grid.Rows.Count > 0 And Not SoloCentros, 1, 0), qqNum,
					   ChkInactivo.Checked, qqBol
					   )
			Sq &= "Declare @id int=" & Me.Tag & DMScr()
		Else
			Sq &= ArmeSQL("exec PutConDestino",
			   Numero_Empresa, qqNum,
			   Usuario, qqNum,
			   Me.Tag, qqNum,
			   Nombre, qqTex,
			   ValD(PictureBox1.Tag), qqNum,
			   FechaControl, qqFeh,
			   ChkInactivo.Checked, qqBol
			   )
			Sq &= "Declare @id int" & DMScr()
			Sq &= "Select @id=max(id) from con_destinos where id_emp=" & Numero_Empresa & DMScr()
		End If

		'refrescar tabla de destinos
		Sq &= "exec GetConDestinos " & Numero_Empresa & DMScr()

		'hacer las cuentas
		If Modif Then
			For I As Integer = 0 To LstDelCli.Items.Count - 1
				Dim valores() As String = LstDelCli.Items(I).ToString.Split(",")
				Sq &= (ArmeSQL("exec PutConCtaDestinos",
						"@id", qqCon,
						valores(0), qqNum,
						1, qqNum,
						valores(1), qqNum
						)
					)
			Next
		End If

		For Each Fi As DataRow In Filtrar_DataTable(GrdCli.Grid.DataSource, "modif is not null").Rows
			Sq &= ArmeSQL("exec PutConCtaDestinos",
						"@id", qqCon,
						Fi("id_con_cta"), qqNum,
						0, qqNum,
						Fi("id_con_cco"), qqNum
						)
		Next

		'SGQ-626: Desplegar arbol en nueva tabla
		If UsaDestinosItem Then
			'SGQ-674
			'Sq &= "Declare @id_padre int" & DMScr()
			'Sq &= "Exec GetConDestinosPadre @id_padre out,@id" & DMScr()
			'Sq &= ArmeSQL("@Exec PutConDestinosDet",
			'          "@id_con_destinos", "@id_padre", qqCon)
			If Modif Then
				Sq &= ArmeSQL("@Exec PutConDestinosDet",
							  "@id_con_destinos", "@id", qqCon)
			Else
				Sq &= ArmeSQL("@Exec PutConDestinosDet2",
							  "@id_con_destinos", "@id", qqCon)
			End If
			'/SGQ-674
		End If
		'/SGQ-626: Desplegar arbol en nueva tabla

		Sq &= "Commit Transaction" & DMScr()
		Sq &= "End Try" & DMScr()
		Sq &= "Begin Catch" & DMScr()
		Sq &= "  ROLLBACK TRANSACTION" & DMScr()
		Sq &= "  select error=left(ERROR_MESSAGE(),1000)" & DMScr()
		Sq &= "  Return" & DMScr()
		Sq &= "End Catch" & DMScr()



		Dim dt As New DataTable
		Dim ds As New DataSet
		Try
			SiReloj()

			Abrir(ds, Sq)
			dt = ds.Tables(0)

			NoReloj()

			If dt.Columns.Contains("error") Then
				Me.Tag = ""
				MostrarError(Me.Name, "CmdActualizar_Click", Gdf(dt, "error"))
				Me.Close()
				Exit Sub
			End If

			FechaControl = Gdf(dt, "fecha_modif")
			If Not Modif Then
				IdProducido = Gdf(dt, "id")
			End If

			'refrescar la tabla
			DtDestinos = ds.Tables(1)

			SonarWAV("ok")
			TxtDestino.Text = Nombre 'SGQ-626: Para que refresque el arbol al salir de aqui
			Guardo = True 'SGQ-640: Garantizando que se guardó
		Catch ex As Exception
			NoReloj()
			Me.Tag = ""
			MostrarError(Me.Name, "CmdActualizar_Click", ex.Message)
			Me.Close()
			Exit Sub
		End Try

		Me.Tag = TxtDestino.Text

		Me.Close()

	End Sub

	Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click
		Me.Tag = ""
		Me.Close()

	End Sub
	Private Sub Haga_Grid_Cli(Dt As DataTable)
		GrdCli.DMSLlene_Grid(Dt, "id_con_cta", ColOcultas:=New Object() {"modif", "id_con_cta", "id_con_destinos", "id_con_cco"})

		If SoloCentros Then
			GrdCli.Grid.Columns("codigo").Visible = False
			GrdCli.Grid.Columns("descripcion").Visible = False
		End If
	End Sub

	Private Sub LblRet0_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LblRet0.KeyDown
		If e.KeyCode = Keys.F1 Then
			EsF1 = True
			e.SuppressKeyPress = True
			LblRet0_Validated(sender, New EventArgs)
			EsF1 = False
			'Else
			'    If e.KeyCode = Keys.Enter Then
			'        CmdActualizar_Click(CmdActualizar, New EventArgs)
			'    End If
		End If

	End Sub

	Private Sub LblRet0_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblRet0.TextChanged
		Dim t1 As Label = DirectCast(Me.Controls.Find("LblTit" & Mid(sender.name, Len(sender.name), 1), True)(0), Label)
		t1.Text = ""

	End Sub


	Private Sub LblRet0_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblRet0.Validated

		Dim t1 As Label = DirectCast(Me.Controls.Find("LblTit" & Mid(sender.name, Len(sender.name), 1), True)(0), Label)
		Validar_Cuenta(sender, t1)
		'If LblRet0.Text = "" Then
		'    LblRet0.Focus()
		'End If

	End Sub
	Private Sub Validar_Cuenta(ByVal Sender As System.Object, ByVal t1 As Label)
		Sender.text = SinComillas(Sender.text.trim)
		If Sender.text.trim = "" And Not EsF1 Then
			EsF1 = False
			Sender.tag = 0
			Exit Sub
		End If



		'Dim Dr() As DataRow
		'Dr = DtCta.Select("codigo='" & Sender.text & "'")
		'If Dr.Length = 0 Then
		'    Mensaje("Cuenta NO existe")
		'    Sender.text = ""
		'    Sender.tag = 0
		'    Sender.focus()

		'    Exit Sub
		'End If
		Dim Id As Integer = 0, Descri As String = ""
		Sender.text = BuscarCuentaContable(Sender.Text, , Id, Descri)
		Sender.Tag = Id
		t1.Text = Descri

		If ValD(Sender.tag) > 0 Then 'si la encontró validar destinos
			Dim Dt As DataTable = Filtrar_DataTable(DtCtaAfe, "codigo='" & Sender.text & "'")
			If Fin(Dt) Then
				Mensaje("No existe cuenta")
				LblRet0.Text = ""
				Sender.focus()
			Else
				If Dimension > 0 Then
					If ValD(Gdf(Dt, "d" & Dimension.ToString)) = 0 Then
						Mensaje(Idi("Cuenta NO está definida en la dimensión") & " " & Dimension)
						LblRet0.Text = ""
						Sender.focus()
					End If
				End If
				TxtCentro.Visible = ValD(Gdf(Dt, "cco")) = 1
				LblCentro.Visible = ValD(Gdf(Dt, "cco")) = 1

			End If
			'If ValD("" & Dr(0).Item("afe")) <> 1 Then
			'    Mensaje("Cuenta no es afectable")
			'    Sender.text = ""
			'    Sender.tag = 0
			'    Sender.focus()
			'    Exit Sub
			'End If
			'Sender.tag = Dr(0).Item("id")
			't1.Text = Nombre_Cuenta_Largo(Dr(0).Item("id"))
		End If

	End Sub

	Private Sub GrdCli_DMSTraerValorEliminar(Sender As Object, ValorColDevolver As Object, Fila As Integer) Handles GrdCli.DMSTraerValorEliminar

		Dim DtTemp As DataTable = GrdCli.Grid.DataSource
		Dim fi As DataRow
		fi = DtTemp.Rows(GrdCli.Grid.SelectedRows(0).Index)
		LstDelCli.Items.Add(fi("id_con_cta") & "," & ValD(fi("id_con_cco")))


		fi.Delete()
		fi.AcceptChanges()


		Haga_Grid_Cli(DtTemp)


		GrdCli.Grid.ClearSelection()

		'hacer nuevo, de último
		Nuevo_Cli_Tempario()

	End Sub

	Private Sub GrdCli_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles GrdCli.DMSTraerValor
		Mensaje("No se puede editar la cuenta, solo se puede eliminar")

		'la edición está perfecta, la quito solo por que podrían cambiar de cuenta, entonces quedarían ambas
		'If GrdCli.Grid.SelectedRows.Count = 0 Then
		'    Exit Sub
		'End If
		'Dim DtTemp As DataTable = GrdCli.Grid.DataSource
		'Dim Fi As DataRow = DtTemp.DefaultView.Item(GrdCli.Grid.SelectedRows(0).Index).Row

		'Try
		'    Nuevo_Cli_Tempario()

		'    'no cambiar orden

		'    'no cambiar orden
		'    GrdCli.Tag = GrdCli.Grid.SelectedRows(0).Index
		'    LblRet0.Text = "" & Fi("codigo")
		'    LblRet0.Tag = ValD(Fi("id_con_cta"))
		'    LblTit0.Text = "" & Fi("descripcion")


		'    CmdOK.Text = "Modificar"

		'Catch ex As Exception
		'    MostrarError(Me.Name, "GrdCli_DMSTraerValor", ex.Message & EsIngles)

		'End Try

	End Sub

	Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
		Dim fEsc As New fEscogerImagen
		fEsc.Tag = PictureBox1.Tag
		fEsc.ShowDialog()

		If ValD(fEsc.Tag) > 0 Then
			PictureBox1.Image = fImg.ImageList1.Images(CInt(ValD(fEsc.Tag)))
			PictureBox1.Tag = ValD(fEsc.Tag)
		End If
	End Sub

	Private Sub LnkEditar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkEditar.LinkClicked
		PictureBox1_Click(PictureBox1, New EventArgs)

	End Sub

	Private Sub LnkRefres_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkRefres.LinkClicked
		Try
			If Not Pregunte("Seguro de refrescar cuentas contables en memoria?") Then
				Exit Sub
			End If

			SiReloj()
			Abrir(DtCtaAfe, "Exec GetConCuentasVentana " & Numero_Empresa.ToString & ",''")
			NoReloj()

			SonarWAV("ok")

		Catch ex As Exception
			NoReloj()

			MostrarError(Me.Name, "LnkRefres_LinkClicked", ex.Message)

		End Try
	End Sub

	Private Sub TxtCentro_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCentro.KeyDown
		If e.KeyCode = Keys.F1 Then
			Dim Dis As Integer
			Dim Cen As Integer
			VentanaCentrosCostos(Dis, 0, 0, Cen)
			If Dis = -1 Or Cen = 0 Then Exit Sub
			TxtCentro.Text = "(" & Cen & ")"
			TxtCentro_Validated(TxtCentro, New EventArgs)

			CmdOK.Focus()

		End If
	End Sub
	Private Sub TxtCentro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCentro.TextChanged
		TxtCentro.Tag = ""

	End Sub
	Private Sub TxtCentro_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCentro.Validated
		If sender.Text.Trim = "" Then Exit Sub
		If ValD(sender.Tag) > 0 Then Exit Sub

		Try
			'primero intentar con el código
			Dim DtTemp As DataTable = Filtrar_DataTable(DtCco, "codigo = '" & sender.Text.Trim & "'")
			If DtTemp.Rows.Count = 0 Then
				DtTemp = Filtrar_DataTable(DtCco, "descripcion like '%" & sender.Text.Trim & "%'")
				If DtTemp.Rows.Count > 1 Then
					Buscar_Centro(sender, sender.Text)
					Exit Sub
				End If
			End If
			If DtTemp.Rows.Count = 1 Then
				'esta muestra el nombre con todos los niveles, la otra solo en centro
				'sender.Text = Gdf(DtTemp, "descripcion")
				sender.Text = Gdf(DtTemp, "centro")
				sender.Tag = Gdf(DtTemp, "id").ToString
			End If

			If ValD(sender.tag) = 0 And sender.text <> "" Then
				Mensaje("Centro no existe")
				sender.focus()
				Exit Sub
			End If

		Catch ex As Exception
			sender.text = ""
			sender.tag = ""
			Mensaje(ex.Message)
			sender.focus()

        End Try


    End Sub

    Private Sub Buscar_Centro(TxtCentro As TextBox, ByVal Inicio As String)
        If Inicio = "0" Then Inicio = ""
        Dim DtTemp As DataTable = Filtrar_DataTable(DtCco, "descripcion like '%" & Inicio & "%'")
        Dim id As Integer = ValD(Ventana(DtTemp, "Seleccione Centro de costos", , "id", New Object() {"id"}))
        If id = 0 Then
            TxtCentro.Focus()
            Exit Sub
        Else
            DtTemp = Filtrar_DataTable(DtTemp, "id=" & id)
            TxtCentro.Text = Gdf(DtTemp, "descripcion")
            TxtCentro.Tag = id.ToString
        End If

    End Sub

End Class