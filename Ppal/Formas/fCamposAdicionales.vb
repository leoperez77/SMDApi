' Version: 684, 25-ago.-2018 20:17
' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fCamposAdicionales
    Dim DtOpciones As New DataTable

	Private Sub fCamposAdicionales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		CbTipoDato.Items.Clear()
		CbTipoDato.Items.Add(Idi("(Seleccione tipo de dato)"))
		CbTipoDato.Items.Add("1 - " & Idi("Valor monetario"))
		CbTipoDato.Items.Add("2 - " & Idi("Texto"))
		CbTipoDato.Items.Add("3 - " & Idi("Fecha"))
		CbTipoDato.Items.Add("4 - " & Idi("Si/No"))
		CbTipoDato.Items.Add("5 - " & Idi("Numérico con decimales"))
		CbTipoDato.Items.Add("6 - " & Idi("Numérico entero"))
		CbTipoDato.Items.Add("7 - " & Idi("Opción múltiple"))

		PnlCombo.Location = Grd.Location
		PnlFecha.Location = Grd.Location
        PnlTexto.Location = Grd.Location
        PnlNegativo.Location = Grd.Location

        PnlCombo.Size = Grd.Size
        PnlFecha.Size = Grd.Size
        PnlTexto.Size = Grd.Size
        PnlNegativo.Size = Grd.Size


        CbTipoDato.SelectedIndex = 0

        Try
            Dim Ds As New DataSet
            Abrir(Ds, "exec GetCotItemCamDef " & Numero_Empresa.ToString & ",'" & Me.Tag & "'")

		Mostrar_Grid(Ds)

        Catch ex As Exception
			MostrarError(Me.Name, "fCamposAdicionales_Load", ex.Message)

		End Try


	End Sub
	Private Sub Mostrar_Grid(Ds As DataSet)
		Grd.DMSLlene_Grid(Ds.Tables(0), "id", ColOcultas:=New Object() {"anulado", "id", "id_emp", "programa", "tipo_dato", "longitud", "requerido", "acepta_negativo", "fecha_mayor_hoy", "fecha_menor_hoy", "fecha_inferior", "fecha_superior"})

		DtOpciones = Ds.Tables(1)

	End Sub
	Private Sub CmdOK_Click(sender As System.Object, e As System.EventArgs) Handles CmdOK.Click
		'validar
		If CbTipoDato.SelectedIndex <= 0 Then
			Mensaje("Seleccione tipo de dato")
			CbTipoDato.Focus()
			Exit Sub
		End If

		Dim Tipo As Integer = Strings.Left(CbTipoDato.Text, 1)

		If ValD(TxtNro.Text) < 1 Or ValD(TxtNro.Text) > 20 Then
			Mensaje("Campo Nro inválido")
			TxtNro.Focus()
			Exit Sub
		End If

		If TxtTitulo.Text.Trim = "" Then
			Mensaje("Título")
			TxtTitulo.Focus()
			Exit Sub
		End If

		If Tipo = 2 Then 'texto
			If ValD(TxtLongitud.Text) < 1 Or ValD(TxtLongitud.Text) > 5000 Then
				Mensaje("Longitud del texto debe ser entre 1 y 5000")
				TxtLongitud.Focus()
				Exit Sub
			End If
		End If

		If Tipo = 7 Then 'combos, verificar que no haya datos repetidos
			If LstMult.Items.Count = 0 Then
				Mensaje("Ingrese datos de opción múltiple")
				Exit Sub
			End If
		End If

		For I As Integer = 0 To Grd.Grid.Rows.Count - 1
			If ValD(Tm(Grd.Grid, "nro", I)) = ValD(TxtNro.Text) And ValD(CmdOK.Tag) <> ValD(Tm(Grd.Grid, "nro", I)) Then
				Mensaje("Renglón ya existe")
				Exit Sub
			End If

		Next
		'/validar

		'actualizar
		Try
			SiReloj()


			'hacer sql
			Dim Sq As String = ""
			Sq += "Exec PutCotItemCamDef "
			Sq += Numero_Empresa.ToString
			Sq += "," & Usuario.ToString
			Sq += ",'" & Me.Tag & "'"
			Sq += "," & ValD(TxtNro.Tag).ToString
			Sq += "," & TxtNro.Text
			Sq += "," & CbTipoDato.SelectedIndex.ToString
			Sq += "," & IIf(ChkAnulado.Checked, "1", "0")
			Sq += "," & IIf(ChkRequerido.Checked, "1", "0")
			Sq += "," & IIf(ChkNegativo.Checked, "1", "0")
			Sq += "," & ValD(TxtLongitud.Text).ToString
			Sq += ",'" & TxtTitulo.Text.Replace("'", "''") & "'"
			Sq += ",'" & IIf(ChkFechaMinima.Checked, FmtFecSQL(FechaSinHora(TxtFecMin.Value)), "") & "'"
			Sq += ",'" & IIf(ChkFechaMaxima.Checked, FmtFecSQL(FechaSinHora(TxtFecMax.Value)), "") & "'"
			Sq += "," & IIf(ChkFechaMaximoHoy.Checked, "1", "0")
			Sq += "," & IIf(ChkFechaMinimaHoy.Checked, "1", "0")
			Sq += DMScr()

			'obtener el id producido
			Sq += "Declare @Id int" & DMScr()
			If ValD(TxtNro.Tag) > 0 Then
				Sq += "set @Id=" & ValD(TxtNro.Tag).ToString & DMScr()
			Else
				Sq += "select @Id=max(id) from cot_item_cam_def where id_emp=" & Numero_Empresa.ToString & DMScr()
			End If

			If Tipo = 7 Then 'combo
				For J As Integer = 0 To LstMult.Items.Count - 1
					Sq += "Exec PutCotItemCamDefCombo "
					Sq += "@id"
					Sq += "," & TraerId(LstMult, J).ToString
					Sq += ",'" & LstMult.Items(J).ToString.Replace("'", "''") & "'"
					Sq += DMScr()
				Next

				'los de borrar
				For J As Integer = 0 To LstDel.Items.Count - 1
					Sq += "Exec PutCotItemCamDefCombo "
					Sq += "@id"
					Sq += "," & (LstDel.Items(J) * -1).ToString
					Sq += ",''"
					Sq += DMScr()
				Next
			End If

			Sq += "exec GetCotItemCamDef " & Numero_Empresa.ToString & ",'" & Me.Tag & "'"
			Sq += DMScr()

			Dim Ds As New DataSet
			Abrir(Ds, Sq)

			Mostrar_Grid(Ds)

			For I As Integer = 0 To Grd.Grid.Rows.Count - 1
				If ValD(Tm(Grd.Grid, "nro", I)) = ValD(TxtNro.Text) Then
					Grd.Grid.Rows(I).Selected = True
					Exit For
				End If
			Next

			SonarWAV("ok")

		Catch ex As Exception
			If InStr(ex.Message, "FK_cot_item_cam_cot_item_cam_combo") > 0 Then
				Mensaje("No puede actualizar pues está borrando opciones que están siendo usadas")
			Else
				MostrarError(Me.Name, "CmdOK_Click", ex.Message)
			End If
			NoReloj()
			Exit Sub

		End Try
		'/actualizar
		NoReloj()

		'al final
		Nueva_Linea()


	End Sub
	Private Sub Nueva_Linea()
		CmdOK.Text = "Adicionar"
		CmdOK.Tag = 0

		TxtNro.Text = ""
		TxtNro.Tag = 0
		TxtTitulo.Text = ""

		CbTipoDato.SelectedIndex = 0
		CbTipoDato.Enabled = True

		ChkAnulado.Checked = False

		ChkMinCualquiera.Checked = True
		ChkMaxCualquiera.Checked = True

		ChkRequerido.Checked = False
		ChkNegativo.Checked = False
		PnlNegativo.Visible = False

		ChkFechaMaximoHoy.Checked = False
		ChkFechaMinimaHoy.Checked = False
		PnlFecha.Visible = False

		ChkFechaMinima.Checked = False
		ChkFechaMaxima.Checked = False

		PnlTexto.Visible = False
		TxtLongitud.Text = ""

		PnlCombo.Visible = False
		TxtMultipleTex.Text = ""
		TxtMultipleTex.Tag = 0
		LstMult.Items.Clear()
		LstDel.Items.Clear()

		'TxtNro.Enabled = True
		TxtNro.Focus()

	End Sub

	Private Sub CbTipoDato_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbTipoDato.SelectedIndexChanged
		If CbTipoDato.SelectedIndex <= 0 Then Exit Sub

		Dim Tipo As Integer = Strings.Left(CbTipoDato.Text, 1)

		PnlNegativo.Visible = EstaEnLista(Tipo, 1, 5, 6)

		PnlFecha.Visible = Tipo = 3
		PnlTexto.Visible = Tipo = 2
		PnlCombo.Visible = Tipo = 7

		If Tipo = 7 Then
			TxtMultipleTex.Focus()
		ElseIf Tipo = 2 Then
			If TxtLongitud.Text = "" Then TxtLongitud.Text = "30"
			TxtLongitud.Focus()
		End If

	End Sub



	Private Sub LstMult_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstMult.SelectedIndexChanged
		If LstMult.SelectedIndex < 0 Then
			Exit Sub
		End If

		TxtMultipleTex.Text = LstMult.Text
		TxtMultipleTex.Tag = TraerId(LstMult)

	End Sub

	Private Sub CmdMultipleAdi_Click(sender As System.Object, e As System.EventArgs) Handles CmdMultipleAdi.Click
		If TxtMultipleTex.Text.Trim = "" Then
			Mensaje("Ingrese texto")
			TxtMultipleTex.Focus()
			Exit Sub
		End If


		'verificar duplicado
		For I As Integer = 0 To LstMult.Items.Count - 1
			If LstMult.Items(I).ToString = TxtMultipleTex.Text Then
				If I <> LstMult.SelectedIndex Then
					Mensaje("Texto ya existe en las opciones")
					Exit Sub
				End If
			End If
		Next
		'/verificar duplicado

		If LstMult.SelectedIndex >= 0 Then
			LstMult.Items.RemoveAt(LstMult.SelectedIndex)
		End If

		LstMult.Items.Add(New DataDescription(ValD(TxtMultipleTex.Tag), TxtMultipleTex.Text))

		Nuevo_Combo()


	End Sub
	Private Sub Nuevo_Combo()
		LstMult.SelectedIndex = -1
		TxtMultipleTex.Text = ""
		TxtMultipleTex.Tag = 0
		TxtMultipleTex.Focus()

	End Sub
	Private Sub Grd_DMSTraerValor(Sender As System.Object, ValorColDevolver As System.Object) Handles Grd.DMSTraerValor
		Nueva_Linea()

		TxtNro.Text = Tm(Grd.Grid, "nro").ToString
		TxtNro.Tag = Tm(Grd.Grid, "id").ToString

		CbTipoDato.SelectedIndex = ValD(Tm(Grd.Grid, "tipo_dato"))
		TxtTitulo.Text = Tm(Grd.Grid, "titulo").ToString
		TxtLongitud.Text = "" & Tm(Grd.Grid, "longitud").ToString

		ChkRequerido.Checked = Tm(Grd.Grid, "requerido") <> ""
		ChkNegativo.Checked = Tm(Grd.Grid, "acepta_negativo") <> ""
		ChkFechaMaximoHoy.Checked = Tm(Grd.Grid, "fecha_mayor_hoy") <> ""
		ChkFechaMinimaHoy.Checked = Tm(Grd.Grid, "fecha_menor_hoy") <> ""

		ChkAnulado.Checked = Tm(Grd.Grid, "anulado") <> ""

		If Tm(Grd.Grid, "fecha_inferior") <> "" Then
			ChkFechaMinima.Checked = True
			TxtFecMin.Value = Tm(Grd.Grid, "fecha_inferior")
		End If
		If Tm(Grd.Grid, "fecha_superior") <> "" Then
			ChkFechaMaxima.Checked = True
			TxtFecMax.Value = Tm(Grd.Grid, "fecha_superior")
		End If

		If ValD(Tm(Grd.Grid, "tipo_dato")) = 7 Then 'combo
			Llene_Combo5(LstMult, DtOpciones, "id", "descripcion", "nro=" & Tm(Grd.Grid, "nro"))
		End If

		CbTipoDato.Enabled = ValD(Tm(Grd.Grid, "regs")) = 0

		CmdOK.Text = "Modificar"
		CmdOK.Tag = Tm(Grd.Grid, "nro") 'renglon original

		'TxtNro.Enabled = False

	End Sub

	Private Sub LnkNuevo_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkNuevo.LinkClicked
		Nueva_Linea()

	End Sub

	Private Sub Grd_DMSCellClick(Sender As System.Object, ValorColDevolver As System.Object) Handles Grd.DMSCellClick
		Nueva_Linea()

	End Sub

	Private Sub LnkEliminar_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkEliminar.LinkClicked
		If ValD(CmdOK.Tag) = 0 Then
			Mensaje("Debe estar editando el renglón")
			Exit Sub
		End If

		If ValD(Tm(Grd.Grid, "regs")) > 0 Then
			Mensaje("No puede eliminar pues está siendo usado en " & Tm(Grd.Grid, "regs") & " registros.  Debe limpiar este campo de los registros donde está siendo usado para poder eliminarlo")
			Exit Sub
		End If

		If Not Pregunte("Seguro de eliminar campo?", , Me.Name) Then
			Exit Sub
		End If


		SiReloj()

		Try
			Dim Sq As String = ""
			Sq += "Exec DelCotItemCamDef "
			Sq += Numero_Empresa.ToString
			Sq += "," & Usuario.ToString
			Sq += ",'" & Me.Tag & "'"
			Sq += "," & ValD(TxtNro.Tag).ToString
			Sq += DMScr()

			Sq += "exec GetCotItemCamDef " & Numero_Empresa.ToString & ",'" & Me.Tag & "'"
			Sq += DMScr()

			Dim Ds As New DataSet
			Abrir(Ds, Sq)

			Nueva_Linea()
			Mostrar_Grid(Ds)

			SonarWAV("ok")

		Catch ex As Exception
			If InStr(ex.Message, "FK_cot_item_cam_cot_item_cam_def") > 0 Then
				Mensaje("No puede borrar este campo pues está siendo usado")
			Else
				MostrarError(Me.Name, "LnkEliminar_LinkClicked", ex.Message)
			End If

        End Try

        NoReloj()

    End Sub


    Private Sub CmdMultipleDel_Click(sender As System.Object, e As System.EventArgs) Handles CmdMultipleDel.Click
        If LstMult.Items.Count = 0 Then Exit Sub

        If ValD(TxtMultipleTex.Tag) > 0 Then
            LstDel.Items.Add(TxtMultipleTex.Tag)
        End If

        If LstMult.SelectedIndex <> -1 Then LstMult.Items.RemoveAt(LstMult.SelectedIndex)

        'SonarWAV("ok")

        Nuevo_Combo()

    End Sub

    Private Sub ChkFechaMinimaHoy_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkFechaMinimaHoy.CheckedChanged
        'ChkFechaMinima.Visible = Not ChkFechaMinimaHoy.Checked
        'TxtFecMin.Visible = False ' Not ChkFechaMinimaHoy.Checked

        If ChkFechaMinimaHoy.Checked Then
            ChkFechaMinima.Checked = False
        End If

    End Sub
    Private Sub ChkFechaMinima_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkFechaMinima.CheckedChanged
        TxtFecMin.Visible = ChkFechaMinima.Checked

    End Sub

    Private Sub ChkFechaMaxima_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkFechaMaxima.CheckedChanged
        TxtFecMax.Visible = ChkFechaMaxima.Checked

    End Sub

    Private Sub ChkFechaMaximoHoy_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkFechaMaximoHoy.CheckedChanged
        'ChkFechaMaxima.Visible = Not ChkFechaMaximoHoy.Checked
        'TxtFecMax.Visible = False ' not chkfechamaximohoy.checked

        If ChkFechaMaximoHoy.Checked Then
            ChkFechaMaxima.Checked = False
        End If

    End Sub

End Class