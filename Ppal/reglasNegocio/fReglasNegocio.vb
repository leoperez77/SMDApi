' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
' Version: 678, 16-ago.-2018 14:15
' Version: 640, 3-abr.-2018 13:06
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fReglasNegocio

    Public Modifico As Boolean = False

    Private Sub fReglasNegocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Configuración programa " & Me.Tag
    End Sub
    Private Sub fReglasNegocio_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		Recorrer_Controles_Idioma(Me, Me)


		Mostrar_Grid()

		NoReloj(fBusIt)

	End Sub

	Private Sub Grd_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles Grd.DMSTraerValor
		Me.TopMost = False 'se quita y ya no se vuelve a poner
		If Grd.Grid.SelectedRows.Count = 0 Then Exit Sub

		If ValD(Tm(Grd.Grid, "Rn")) = 0 Then Exit Sub

		If NoPuede4(ValD(Me.Tag), 8501) Then
			Exit Sub
		End If


		Dim ValorRegla As String = Tm(Grd.Grid, "valor")
		Dim regla As Integer = ValD(Tm(Grd.Grid, "Rn"))
		Dim llave As String = Tm(Grd.Grid, "llave")
		Dim descrip As String = Tm(Grd.Grid, "descripcion")
		Dim titulo As String = "" & Obtenga_Dato(DtRNTit, "id=" & regla, "titulo")
		Dim tipo_regla As Short = ValD(Obtenga_Dato(DtRNTit, "id=" & regla, "tipo_regla"))

		Dim EsCompuesta As Boolean = False
		If llave.Contains("?") Then
			EsCompuesta = True
			Try
				SiReloj()
				Dim dty As New DataTable
				Abrir(dty, "select llave,respuesta from reglas_emp where id_emp=" & Numero_Empresa & " and id_reglas=" & regla & " and isnull(llave,'') like '" & llave.Replace("?", "") & "%' order by llave,respuesta")
				NoReloj()

				Dim llave2 As String = ""
				If Not Fin(dty) Then
					llave2 = Ventana(dty, "Seleccione la llave o presione ESC para hacer una nueva", True, "llave")
					If llave2 <> "" Then
						llave = llave2
						ValorRegla = Obtenga_Dato(dty, "llave='" & llave & "'", "respuesta")
					End If
				End If

				If llave2 = "" Then
					llave2 = Inputbox2(descrip, "Valor de " & llave).ToString.Trim
					If llave2 = "" Then
						Exit Sub
					End If
					llave = llave.Replace("?", llave2)
				End If
			Catch ex As Exception
				NoReloj()
				MostrarError(Me.Name, "", ex.Message)
				Exit Sub
			End Try
		End If


		Dim fMod As New fModifRegla
		fMod.Text = Idi("Regla de negocio") & " " & regla & IIf(llave <> "", ", " & llave, "")
		fMod.LblTtitulo.Text = titulo
		fMod.LblRegla.Text = descrip
		fMod.LblRegla.Tag = regla
		fMod.TxtDespRegla.Text = ArreglarReturns("" & Obtenga_Dato(DtRNTit, "id=" & regla, "descripcion"))

		fMod.TxtTexto.Text = ValorRegla
		fMod.LblDefault.Text = Tm(Grd.Grid, "predet")
		If tipo_regla = 1 Then 'si/no
			If ValD(ValorRegla) = 1 Then
				fMod.RdSi.Checked = True
			Else
				fMod.RdNo.Checked = True
			End If
		End If

		fMod.PnlTexto.Visible = tipo_regla > 1
		fMod.PnlSINO.Visible = tipo_regla = 1

		fMod.LblTitLlave.Visible = llave <> ""
		fMod.LblLlave.Visible = llave <> ""
		fMod.LblLlave.Text = llave & EsIngles()
		fMod.ShowDialog()

		If fMod.Tag <> "&&&" And Not EsCompuesta Then
			Tm2(Grd.Grid, "valor", Grd.Grid.SelectedRows(0).Index, fMod.Tag)
			Modifico = True
		End If

	End Sub

	Private Sub Mostrar_Grid()
		'quitar duplicados
		DtRN = Filtrar_DataTable(DtRN, "", "rn,llave")
		Dim DtCopia As DataTable = DtRN.Copy
		DtCopia.Rows.Clear()

		Dim Ant As String = ""
		For Each Fi As DataRow In DtRN.Rows
			If "" & Fi("titulo") <> Ant Or Ant = "" Then
				Ant = "" & Fi("titulo")
				DtCopia.Rows.Add(Fi("rn"), "", "", "zzz", "    " & Fi("rn") & " - " & Fi("titulo"))
			Else
				Fi("titulo") = ""
				Fi.AcceptChanges()
			End If
		Next

		'DtRN.Merge(DtCopia)
		MergeDMS(DtRN, DtCopia)

		DtRN = Filtrar_DataTable(DtRN, "", "rn,llave,valor desc")
		'limpiar los títutlos bien
		For Each Fi As DataRow In DtRN.Rows
			If "" & Fi("valor") = "zzz" Then
				Fi("valor") = DBNull.Value
				Fi("rn") = DBNull.Value
				Fi.AcceptChanges()
			End If
		Next


		Grd.DMSLlene_Grid(DtRN, "Rn", MostrarEliminar:=False, ColOcultas:=New Object() {"rn", "titulo"})

		For Each Row As DataGridViewRow In Grd.Grid.Rows 'limpiar
			If ValD(Row.Cells("rn").Value) = 0 Then
				Row.DefaultCellStyle.Font = LblEncabezado.Font
			End If
		Next

		Try
			Grd.Grid.Columns("rn").Width = 30
			Grd.Grid.Columns("llave").Width = 100
			Grd.Grid.Columns("titulo").Width = 100
			Grd.Grid.Columns("descripcion").Width = 500
			Grd.Grid.Columns("valor").Width = 80
			Grd.Grid.Columns("predet").Width = 80

		Catch ex As Exception
			MostrarError(Me.Name, "Mostrar_Grid", ex.Message)

		End Try


        Dim ColCual As Short = 1
        For Each Row As DataGridViewRow In Grd.Grid.Rows 'limpiar
            If Strings.Left(Row.Cells("descripcion").Value, 1) = " " Then
                If ColCual = 0 Then
                    ColCual = 1
                Else
                    ColCual = 0
                End If
            End If

            If ColCual = 0 Then
                Row.DefaultCellStyle.BackColor = Color.Azure
            Else
                Row.DefaultCellStyle.BackColor = Color.PowderBlue
            End If
        Next

        Grd.Grid.ClearSelection()

    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()

    End Sub

    Private Sub ChAbrir_CheckedChanged(sender As Object, e As EventArgs) Handles ChAbrir.CheckedChanged
        SaveSett("fconf" & MarcaExterna & "-" & Numero_Empresa, Me.Tag, IIf(ChAbrir.Checked, "", "1"))

    End Sub

    Private Sub CmdCancel2_Click(sender As Object, e As EventArgs) Handles CmdCancel2.Click
        ChAbrir.Checked = False
        Me.Close()

    End Sub
End Class