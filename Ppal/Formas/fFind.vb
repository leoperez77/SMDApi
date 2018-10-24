' Version: 687, 5-sep.-2018 13:13
' Version: 684, 24-ago.-2018 16:56
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 668, 23-jul.-2018 13:18
' Version: 667, 19-jul.-2018 12:57
' Version: 666, 17-jul.-2018 13:12
' Version: 650, 7-may.-2018 12:42
' Version: 649, 2-may.-2018 12:48
'♥ versión: 586, 6-oct.-2017 07:11
Imports Microsoft.Win32
Public Class fFind
	Dim Dt As New DataTable
	Dim Ds As New DataSet
	Public Sql As String = ""
	Public P1 As String = ""
	Public P2 As String = ""
	Public P3 As String = ""
	Public P4 As String = ""
	Public P5 As String = ""
	Public P6 As String = ""
	Public P7 As String = ""
	Public P8 As String = ""
	Public P9 As String = ""
	Public P10 As String = ""
	Public P11 As String = ""
	Public P12 As String = ""
	Public P13 As String = ""
	Public P14 As String = ""
	Public P15 As String = ""
	Public P16 As String = ""
	Public P17 As String = ""
	Public P18 As String = ""
	Public P19 As String = ""
	Public P20 As String = ""
	'Public SQLInstruccion As String = ""

	Public NombreCampoRegresar As String = ""
	Public DatoSeleccionar As String = ""
	Public AvisarConFilas As Integer = 0
	Dim Salir As Boolean = False
	Dim TiempoIni As DateTime
	Public IgnoreModal As Boolean = False
	Public DsJD As DataSet



	Private Sub HacerConsulta_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles HacerConsulta.DoWork

		'procesar ppal
		Salir = False

		TiempoIni = Now

		'truco para mandar el ID del reporte para exportar a archivo plano
		If P19 <> "" Then
			CopiarPlano.Tag = P19
		End If

		If DsJD IsNot Nothing Then
			TiempoIni = TiempoIniciEspecial
			Ds = DsJD.Copy
			DsJD = Nothing
			Exit Sub
		End If

		Try
			If P1 <> "" Then
				Abrir(Dt, Sql, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15, P16, P17, P18, P19, P20)
			Else
				Abrir(Ds, Sql)
			End If


		Catch ex As Exception
			Mensaje_TopMost("Error procesando la consulta: " & DMScr(2) & ex.Message & EsIngles(), , , True)
			Salir = True
		End Try

	End Sub

	Private Sub HacerConsulta_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles HacerConsulta.RunWorkerCompleted
		If Salir Then
			Me.Close()
			Exit Sub
		End If


		LblTiempo.Text = HaceCuantoTiempo(TiempoIni, Now)


		PicLogo.Visible = False

		Try
			If P1 = "" Then
				If Ds.Tables.Count = 0 Then 'engañarlo
					Dim ddd As New DataTable
					ddd.Columns.Add("Campo")
					ddd.Rows.Add("No devolvió información")
					Ds.Tables.Add(ddd)
				End If
				Dt = Ds.Tables(0).Copy
				If Ds.Tables.Count > 1 Then
					QueConsulta.Visible = True
					LblQueConsulta.Visible = True
					QueConsulta.Text = CmdConsulta_1.Text
					CmdConsulta_1.Visible = True
					CmdConsulta_2.Visible = True

					Lbl100.Text = "Atención: En esta pantalla hay varias consultas. Haga clic frente al texto 'Mostrando Consulta:' (en la parte superior de la pantalla) para seleccionar la consulta deseada"
					Pnl100.Visible = True

					If Ds.Tables.Count > 2 Then
						CmdConsulta_3.Visible = True
						If Ds.Tables.Count > 3 Then
							CmdConsulta_4.Visible = True
							If Ds.Tables.Count > 4 Then
								CmdConsulta_5.Visible = True
								If Ds.Tables.Count > 5 Then
									CmdConsulta_6.Visible = True
									If Ds.Tables.Count > 6 Then
										CmdConsulta_7.Visible = True
										If Ds.Tables.Count > 7 Then
											CmdConsulta_8.Visible = True
											If Ds.Tables.Count > 8 Then
												CmdConsulta_9.Visible = True
												If Ds.Tables.Count > 9 Then
													CmdConsulta_10.Visible = True
													If Ds.Tables.Count > 10 Then
														CmdConsulta_11.Visible = True
														If Ds.Tables.Count > 11 Then
															CmdConsulta_12.Visible = True
															If Ds.Tables.Count > 12 Then
																CmdConsulta_13.Visible = True
																If Ds.Tables.Count > 13 Then
																	CmdConsulta_14.Visible = True
																	If Ds.Tables.Count > 14 Then
																		CmdConsulta_15.Visible = True
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If

					'ver si tiene títulos de consulta
					If Ds.Tables(0).Columns(0).ColumnName = "titulo_consulta" Then
						Try
							CmdConsulta_1.Visible = False
							CmdConsulta_2.Text = Ds.Tables(0).Rows(0).Item(0)
							QueConsulta.Text = CmdConsulta_2.Text
							Dt = Ds.Tables(1).Copy
							CmdConsulta_3.Text = Ds.Tables(0).Rows(1).Item(0)
							CmdConsulta_4.Text = Ds.Tables(0).Rows(2).Item(0)
							CmdConsulta_5.Text = Ds.Tables(0).Rows(3).Item(0)
							CmdConsulta_6.Text = Ds.Tables(0).Rows(4).Item(0)
							CmdConsulta_7.Text = Ds.Tables(0).Rows(5).Item(0)
							CmdConsulta_8.Text = Ds.Tables(0).Rows(6).Item(0)
							CmdConsulta_9.Text = Ds.Tables(0).Rows(7).Item(0)
							CmdConsulta_10.Text = Ds.Tables(0).Rows(8).Item(0)
							CmdConsulta_11.Text = Ds.Tables(0).Rows(9).Item(0)
							CmdConsulta_12.Text = Ds.Tables(0).Rows(10).Item(0)
							CmdConsulta_13.Text = Ds.Tables(0).Rows(11).Item(0)
							CmdConsulta_14.Text = Ds.Tables(0).Rows(12).Item(0)
							CmdConsulta_15.Text = Ds.Tables(0).Rows(13).Item(0)
						Catch 'seguro da error, pero no importa, es intencional

						End Try
					End If

				End If
			End If

			'GridDms1.DMSLlene_Grid(Dt, NombreCampoRegresar, TrueInstruccion)
			GridDms1.DMSLlene_Grid(Dt, NombreCampoRegresar, True)

			LblAviso.Visible = False
			GridDms1.Visible = True
			'BtnCopiar.Enabled = True
			If Me.WindowState = FormWindowState.Minimized Then
				Me.WindowState = FormWindowState.Normal
			End If


			Me.Show()


			If AvisarConFilas > 0 And Dt.Rows.Count > 0 Then
				If Dt.Rows.Count >= AvisarConFilas Then
					'Mensaje("Atención: Esta consulta está diseñada para mostrar un máximo de " & AvisarConFilas.ToString & " filas de resultados.  En la base de datos hay más información que no está siendo mostrada en este momento")
					Lbl100.Text = Idi("Atención: Esta consulta está diseñada para mostrar un máximo de") & " " & AvisarConFilas.ToString & " " & Idi("filas de resultados.  En la base de datos hay más información que no está siendo mostrada en este momento")
					Pnl100.Visible = True
				End If
			End If

			If Dt.Rows.Count = 0 Then
				Lbl100.Text = Idi("No encontró información para mostrar")
				Pnl100.Visible = True
			End If

		Catch ex As Exception
			Mensaje(ex.Message)

		End Try

		NoReloj(Me)

		'CmdRefrescar.Visible = True
		ToolStrip1.Enabled = True
		GridDms1.Visible = True


	End Sub


	'Private Sub G1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles G1.CellDoubleClick
	'    If e.RowIndex < 0 Then Exit Sub

	'    SeleccionarySalir()

	'End Sub
	'Private Sub SeleccionarySalir()
	'    If NombreCampoRegresar = "" Then Exit Sub

	'    Try
	'        DatoDevolver = ""
	'        'DatoDevolver = G1.SelectedRows(0).Cells(NombreCampoRegresar).Value.ToString
	'        DatoDevolver = GridDms1.d.SelectedRows(0).Cells(NombreCampoRegresar).Value.ToString

	'    Catch ex As Exception

	'    Finally
	'        Me.Dispose()
	'    End Try

	'End Sub

	Private Sub fFind_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		'If HacerConsulta.CancellationPending = True Then
		'End If
		If HacerConsulta.IsBusy Then
			HacerConsulta.CancelAsync()
		End If
	End Sub
	Private Sub fFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Recorrer_Controles_ToolStrip(ToolStrip1)

		If SoyHandHeld() Then
			Me.WindowState = FormWindowState.Maximized
		End If

		If GridDms1.Grid.Rows.Count = 0 Then
			Asignar_Logo(GridDms1, PicLogo)
		End If

		'CmdRefrescar.Visible = False
		If Me.Modal = False And IgnoreModal = False Then
			ToolStrip1.Enabled = False
			GridDms1.Visible = False
		End If

		If P1 <> "" Or Sql = "" Then 'quiere decir que tiene parametros
			CmdRefrescar.Enabled = False 'no dejar refrescar
		End If

		'If GraficarToolStripButton.Enabled = False Then
		'    GraficarToolStripButton.Visible = False
		'End If

		DatoDevolver = ""
		CmdCancel.Left = -5000
		GridDms1.Focus()

		'jdms 666
		GridDms1.DMSPersonalizarGrid = False


		'TODO: Ver que esto no sea problema
		GridDms1.Grid.ClearSelection()

		If DatoSeleccionar <> "" And NombreCampoRegresar <> "" Then
			For I As Integer = 0 To GridDms1.Grid.Rows.Count - 1
				If Tm(GridDms1.Grid, NombreCampoRegresar, I) = DatoSeleccionar Then
					GridDms1.Grid.Rows(I).Selected = True
					If I >= 10 Then
						GridDms1.Grid.FirstDisplayedScrollingRowIndex = I - 4 'el 4 es para que deje 4 líneas arriba
					End If
					Exit For
				End If
			Next
		End If

		'jdms 668: alternar colores
		GridDms1.Grid.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight
		GridDms1.CmdPonerSombras.Text = "Quitar sombras"


		If GridDms1.Grid.Rows.Count < 250 Then 'si son poquitas filas, pintarlas
			For I As Integer = 0 To GridDms1.Grid.Rows.Count - 1
				'jdms 668: alternar colores
				'If Int(I / 2) * 2 = I Then
				'	GridDms1.Grid.Rows(I).DefaultCellStyle.BackColor = Color.LightCyan
				'End If
				Try
					If GridDms1.Grid.Tag = "1" Then
						Dim cc As Color = Color.Black

						If GridDms1.Grid.Rows(I).Cells("marca").Value = "col" Then
							cc = Color.Red
						End If
						If GridDms1.Grid.Rows(I).Cells("marca").Value = "local" Then
							cc = Color.Orange
						End If
						If GridDms1.Grid.Rows(I).Cells("marca").Value = "3" Then
							cc = Color.Magenta
						End If
						If GridDms1.Grid.Rows(I).Cells("marca").Value = "zzz" Then
							cc = Color.Blue
						End If
						If cc <> Color.Black Then
							GridDms1.Grid.Rows(I).DefaultCellStyle.Font = LblNegro.Font
							GridDms1.Grid.Rows(I).DefaultCellStyle.ForeColor = cc
						End If
					End If
				Catch

				End Try
			Next
		End If

	End Sub

	Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
		If HacerConsulta.IsBusy Then
			HacerConsulta.CancelAsync()
		End If

		DatoDevolver = ""

		Me.Dispose()

	End Sub

	'Private Sub G1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
	'    If e.KeyCode = Keys.Return Then
	'        SeleccionarySalir()
	'    End If

	'End Sub



	Private Sub LnkCerrar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkCerrar.LinkClicked
		Pnl100.Visible = False

	End Sub


	Private Sub GridDms1_DMSTraerValor(ByVal Sender As Object, ByVal ValorColDevolver As System.String) Handles GridDms1.DMSTraerValor
		If NombreCampoRegresar = "" Then Exit Sub

		Try
			'DatoDevolver = ""
			'DatoDevolver = G1.SelectedRows(0).Cells(NombreCampoRegresar).Value.ToString

			DatoDevolver = ValorColDevolver

		Catch ex As Exception

		Finally
			Me.Dispose()
		End Try
	End Sub

	Private Sub CmdConsulta_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdConsulta_1.Click, CmdConsulta_8.Click, CmdConsulta_7.Click, CmdConsulta_6.Click, CmdConsulta_5.Click, CmdConsulta_4.Click, CmdConsulta_3.Click, CmdConsulta_2.Click,
											CmdConsulta_9.Click,
											CmdConsulta_10.Click,
											CmdConsulta_11.Click,
											CmdConsulta_12.Click,
											CmdConsulta_13.Click,
											CmdConsulta_14.Click,
											CmdConsulta_15.Click
		SiReloj()

		Dim I As Integer = ValD(sender.tag)
		GridDms1.DMSLlene_Grid(Ds.Tables(I), NombreCampoRegresar, True)
		QueConsulta.Text = sender.text
		Pnl100.Visible = False

		NoReloj()

	End Sub

	'Private Sub CmdConsulta_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
	'    GridDms1.DMSLlene_Grid(Ds.Tables(1), , True)
	'    QueConsulta.Text = sender.text

	'End Sub

	'Private Sub CmdConsulta_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
	'    GridDms1.DMSLlene_Grid(Ds.Tables(2), , True)
	'    QueConsulta.Text = sender.text

	'End Sub

	'Private Sub CmdConsulta_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
	'    GridDms1.DMSLlene_Grid(Ds.Tables(3), , True)
	'    QueConsulta.Text = sender.text

	'End Sub
	'Private Sub CmdConsulta_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
	'    GridDms1.DMSLlene_Grid(Ds.Tables(4), , True)
	'    QueConsulta.Text = sender.text

	'End Sub

	'Private Sub CmdConsulta_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
	'    GridDms1.DMSLlene_Grid(Ds.Tables(5), , True)
	'    QueConsulta.Text = sender.text

	'End Sub

	'Private Sub CmdConsulta_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
	'    GridDms1.DMSLlene_Grid(Ds.Tables(6), , True)
	'    QueConsulta.Text = sender.text

	'End Sub

	'Private Sub CmdConsulta_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
	'    GridDms1.DMSLlene_Grid(Ds.Tables(7), , True)
	'    QueConsulta.Text = sender.text

	'End Sub


	Private Sub CmdRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRegresar.Click
		CmdCancel_Click(CmdRegresar, New EventArgs)

	End Sub



	Private Sub CmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRefrescar.Click
		If Not Pregunte("Seguro de refrescar los datos?", , Me.Name, , 4) Then Exit Sub

		Try
			'SiReloj(Me)
			ToolStrip1.Enabled = False
			GridDms1.Visible = False
			LblAviso.Visible = True
			PicLogo.Visible = True
			HagaEventos()

			'CmdRefrescar.Visible = False
			HacerConsulta.RunWorkerAsync()
		Catch ex As Exception
			Mensaje(ex.Message)

		End Try

	End Sub

	Private Sub PicLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicLogo.Click
		PicLogo.Visible = False

	End Sub

	Private Sub CmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdImprimir.Click

		GridDms1.ExportarExcel()

	End Sub

	Private Sub CmdMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdMail.Click
		GridDms1.EnviarMail()

	End Sub

	Private Sub CmdChat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdChat.Click
		GridDms1.EnviarPorChat()

	End Sub



	Private Sub LblProcedure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblProcedure.Click
		If Not PidaClave() Then Exit Sub

		Mensaje(LblProcedure.Tag)

	End Sub

	Private Sub fFind_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
		GridDms1.Visible = True
		ToolStrip1.Enabled = True

	End Sub

	'Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, ee As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
	'    If Not Pregunte("Desea imprimir este grid?", , Me.Name) Then Exit Sub

	'    PrintDocument1.Print()

	'End Sub
	'Dim i As Integer = 0
	'Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
	'    ' Definimos la fuente que vamos a usar para imprimir
	'    ' en este caso Arial de 10
	'    Dim printFont As System.Drawing.Font = New Font("Arial", 8)
	'    Dim topMargin As Double = e.MarginBounds.Top
	'    Dim yPos As Double = 0
	'    Dim linesPerPage As Double = 0
	'    Dim count As Integer = 0
	'    Dim texto As String = ""
	'    Dim row As System.Windows.Forms.DataGridViewRow

	'    ' Calculamos el número de líneas que caben en cada página
	'    linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)

	'    ' Imprimimos las cabeceras
	'    Dim header As DataGridViewHeaderCell
	'    For Each column As DataGridViewColumn In GridDms1.Grid.Columns
	'        If column.Visible Then
	'            header = column.HeaderCell
	'            texto += vbTab + header.FormattedValue.ToString()
	'        End If
	'    Next

	'    yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
	'    e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
	'    ' Dejamos una línea de separación
	'    count += 2

	'    ' Recorremos las filas del DataGridView hasta que llegemos
	'    ' a las líneas que nos caben en cada página o al final del grid.
	'    While count < linesPerPage AndAlso i < GridDms1.Grid.Rows.Count
	'        row = GridDms1.Grid.Rows(i)
	'        texto = ""
	'        For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
	'            If celda.Visible Then
	'                'Comprobamos que la celda tenga algún valor, en caso de 
	'                'permitir añadir filas esto es muy importante
	'                If celda.Value IsNot Nothing Then
	'                    texto += vbTab + celda.Value.ToString()
	'                End If
	'            End If
	'        Next

	'        ' Calculamos la posición en la que se escribe la línea
	'        yPos = topMargin + (count * printFont.GetHeight(e.Graphics))

	'        ' Escribimos la línea con el objeto Graphics
	'        e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
	'        ' Incrementamos los contadores
	'        count += 1
	'        i += 1
	'    End While

	'    ' Una vez fuera del bucle comprobamos si nos quedan más filas
	'    ' por imprimir, si quedan saldrán en la siguente página
	'    If i < GridDms1.Grid.Rows.Count Then
	'        e.HasMorePages = True
	'    Else
	'        ' si llegamos al final, se establece HasMorePages a
	'        ' false para que se acabe la impresión
	'        e.HasMorePages = False
	'        ' Es necesario poner el contador a 0 porque, por ejemplo si se hace
	'        ' una impresión desde PrintPreviewDialog, se vuelve disparar este
	'        ' evento como si fuese la primera vez, y si i está con el valor de la
	'        ' última fila del grid no se imprime nada
	'        i = 0
	'    End If
	'End Sub

	Private Sub CmdAceptar_Click(sender As Object, e As EventArgs) Handles CmdAceptar.Click
		If NombreCampoRegresar = "" Then Exit Sub

		Try
			DatoDevolver = ""
			For Each ro As DataGridViewRow In GridDms1.Grid.SelectedRows
				DatoDevolver &= ro.Cells("id").Value & ","
			Next
			DatoDevolver = Strings.Mid(DatoDevolver, 1, Len(DatoDevolver) - 1)

		Catch ex As Exception

		Finally
			Me.Dispose()
		End Try
	End Sub

	Private Sub CmdVerTodas_Click(sender As Object, e As EventArgs) Handles CmdVerTodas.Click

		MostrarMDI.Mostrar_MDI_Dataset(Ds, Me.Text, Me.Icon)


	End Sub

	Private Sub CopiarPlano_Click(sender As Object, e As EventArgs) Handles CopiarPlano.Click
		Dim Ffi As New fFind_Exp
		Ffi.DsOrigen = Ds
		Ffi.Tag = CopiarPlano.Tag
		Ffi.Show()


	End Sub
End Class