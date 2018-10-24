' Version: 694, 28-sep.-2018 12:57
' Version: 691, 17-sep.-2018 20:53
' Version: 690, 13-sep.-2018 12:20
' Version: 687, 5-sep.-2018 13:13
' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 661, 10-jul.-2018 13:27
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fCopiarExcel
	Public Grid As DataGridView
	Public NombreArchivo As String = ""
	Public TituloInforme As String = ""


	Private Sub fCopiarExcel_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
		CopiandoExcel()

	End Sub
	Private Sub CopiandoExcel()
		If Grid.Rows.Count = 0 Then
			MsgBox("No hay datos para exportar a excel")
			Me.Close()
			Exit Sub
		End If




		Dim Excel As Object
		Dim Libro As Object

		Try

			'SiReloj()

			Dim TyExcel As Type = Type.GetTypeFromProgID("Excel.Application")

			Dim UsarCSV As Boolean = False
			If TyExcel Is Nothing Then
				UsarCSV = True
				Mensaje("ATENCIÓN: Su PC no tiene Excel instalado, se usará formato CSV")
			Else
				If Not Pregunte("Desea usar formato XLS de Excel?" & DMScr(2) & "Nota: responda No para usar formato CSV que es más rápido") Then
					UsarCSV = True
				End If
			End If

			If UsarCSV Then
				'Mensaje("No se logró abrir Excel.  Intente copiando al portapapeles")
				'Me.Close()
				'Exit Sub
				Exportar_Plano_Excel()
				Me.Close()
				Exit Sub
			End If
			TyExcel = Nothing

			Dim Resp As Integer
			If NombreArchivo = "" Then
				Resp = PregunteCancel("Desea abrir estos datos en Excel (responda N para copiarlos al portapapeles)?")
				If Resp = MsgBoxResult.Cancel Then
					Me.Close()
					Exit Sub
				End If
				If Resp = MsgBoxResult.No Then
					Me.Close()
					HagaEventos()
					Copiar_Exel2(Grid)
					Exit Sub
				End If
			End If


			Dim Obj_Hoja As Object
			Dim i As Integer, j As Integer
			Excel = CreateObject("Excel.Application")
			Libro = Excel.Workbooks.Add
			Obj_Hoja = Libro.ActiveSheet()



			'Hoja activa   
			Obj_Hoja = Excel.ActiveSheet

			' Recorre el Datagrid 
			Dim iCol As Integer = 0
			Dim FilaTitulo As Integer = 7
			Dim n_Filas As Integer = Grid.Rows.Count

			ProgressBar1.Maximum = Grid.Columns.Count
			For i = 0 To Grid.Columns.Count - 1
				ProgressBar1.Value = i + 1
				HagaEventos()

				If CmdCancelar.Tag = "S" Then
					Me.Close()
					Exit Sub
				End If

				If Grid.Columns(i).Visible Then
					iCol = iCol + 1
					'Caption de la columna   
					If iCol = 1 Then
						Dim Tit1 As String = MiEmpresaNombre
						Dim Tit2 As String = FormatoFecha(Now, True)
						Dim Tit3 As String = TituloInforme
						Dim Tit4 As String = ""
						Dim Tit5 As String = ""
						Dim JI As Integer = InStr(TituloInforme, ")")
						If JI > 0 Then
							Tit3 = Trim(Mid(TituloInforme, JI + 1)) 'titulo reporte + parametros
							Tit4 = Trim(Mid(TituloInforme, 1, JI)) 'programa
							Dim J2 As Integer = InStr(Tit3, "(")
							If J2 > 0 Then
								Tit5 = Trim(Mid(Tit3, J2))
								Tit3 = Trim(Mid(Tit3, 1, J2 - 1))
							End If
						End If
						Obj_Hoja.Cells(1, 1) = "Empresa" : Obj_Hoja.Cells(1, 2) = ": " & Tit1
						Obj_Hoja.Cells(2, 1) = "Fecha" : Obj_Hoja.Cells(2, 2) = ": " & Tit2
						Obj_Hoja.cells(1, 1).font.bold = True
						Obj_Hoja.cells(2, 1).font.bold = True
						FilaTitulo = 4
						If Tit3 & Tit4 <> "" Then
							If Tit3 <> "" Then
								Obj_Hoja.Cells(3, 1) = "Reporte" : Obj_Hoja.Cells(3, 2) = ": " & Tit3
								Obj_Hoja.cells(3, 1).font.bold = True
							End If
							FilaTitulo = 5
							If Tit4 <> "" Then
								Obj_Hoja.Cells(4, 1) = "Programa" : Obj_Hoja.Cells(4, 2) = ": " & Tit4
								Obj_Hoja.cells(4, 1).font.bold = True
								FilaTitulo = 6
								If Tit5 <> "" Then
									Obj_Hoja.Cells(5, 1) = "Parámetros" : Obj_Hoja.Cells(5, 2) = ": " & Tit5
									Obj_Hoja.cells(5, 1).font.bold = True
									FilaTitulo = 7
								End If
							End If
						End If
					End If

					Obj_Hoja.Cells(FilaTitulo, iCol) = Grid.Columns(i).HeaderText
					Dim Fila As Integer = FilaTitulo + 1
					For j = 0 To n_Filas - 1
						'asigna el valor a la celda del Excel 
						If Grid.Rows(j).Visible Then
							Try
								Obj_Hoja.Cells(Fila, iCol) = "" & Grid.Rows(j).Cells(i).Value.ToString
								Fila += 1
							Catch 'ex As Exception
								Fila += 1
							End Try
						End If
					Next
				End If
			Next
			'Obj_Hoja.Rows(1).Font.Bold = True
			'Obj_Hoja.Rows(2).Font.Bold = True
			'Obj_Hoja.Rows(3).Font.Bold = True
			'Obj_Hoja.Rows(4).Font.Bold = True
			'Obj_Hoja.Rows(5).Font.Bold = True
			'Obj_Hoja.Rows(6).Font.Bold = True
			Obj_Hoja.Rows(FilaTitulo).Font.Bold = True
			'Autoajustamos   
			Obj_Hoja.Columns("A:ZZ").AutoFit()
			'asas = Obj_Excel
			'Libro = Obj_Libro
			'Ponemos la aplicación excel visible   

			'If NombreArchivo = "" Then
			'    Excel.Visible = True
			'Else
			'    Excel.Visible = False
			'End If

			NoReloj()

			If NombreArchivo <> "" Then
				'Excel.Visible = False
				If IO.File.Exists(NombreArchivo) Then
					IO.File.Delete(NombreArchivo)
				End If
				Dim xlText As Long
				xlText = -4143


				Libro.SaveAs(NombreArchivo, xlText, , , , , , , , , , True)
				Excel.Quit()
			Else
				'Dim xlText As Long
				'xlText = -4143
				'Dim Archivo As String = Path_Temp & "Advance_" & Strings.Format(Date.Now, "yyyyMMddHHmmss") & ".xls"
				'Libro.SaveAs(Archivo, xlText, , , , , , , , , , True)
				Excel.Visible = True
				'    Excel.quit()
				'    Process.Start(Archivo)
			End If

			Libro = Nothing

			'Process.Start(NombreArchivo)
			Me.Close()


		Catch ex As Exception
			NoReloj()
			Mensaje("Operación no pudo ser completada: " & ex.Message & EsIngles())
			Me.Close()

		End Try

	End Sub

	Private Sub Exportar_Plano_Excel()
		Dim Dt As New DataTable

		If Grid.DataSource Is Nothing Then
			'rml: 690
			Dim DtGrd As New DataTable
			'1. Recorre las columnas del grid para crearlas en el datatable
			For Each c As DataGridViewColumn In Grid.Columns
				DtGrd.Columns.Add(New System.Data.DataColumn(c.Name)) ', System.Type.GetType("System.String")))
			Next
			'2. Recorre las filas del grid para llenar el datatable
			For Each f As DataGridViewRow In Grid.Rows
				Dim Dr As DataRow = DtGrd.NewRow()
				For i = 0 To DtGrd.Columns.Count - 1
					'Dr.Item(i) = "" & DirectCast(f.Cells.Item(i).Value, String)
					Dr.Item(i) = f.Cells.Item(i).Value
				Next
				DtGrd.Rows.Add(Dr)
			Next
			'3. Asigna el nuevo datatable
			Dt = DtGrd
		Else
			Dt = Grid.DataSource
		End If

		'Dim Dt As DataTable = Grid.DataSource
		'/rml: 690

		If Dt.Rows.Count = 0 Then
			MsgBox("No hay datos para exportar a excel")
			Exit Sub
		End If


		'NombreArchivo = NombreArchivo.Replace(".xls", ".csv")
		Dim Abrirlo As Boolean = False
		If NombreArchivo = "" Then
			NombreArchivo = Path_Temp & "Advance_" & Strings.Format(Date.Now, "yyyyMMddHHmmss") & ".csv"
			Abrirlo = True
		End If

		SiReloj()

		Dim Sr As System.IO.StreamWriter

		Try
			Sr = New System.IO.StreamWriter(NombreArchivo)
		Catch ex As Exception
			NoReloj()
			Mensaje_TopMost("Error abriendo archivo texto: " & NombreArchivo & DMScr(2) & ex.Message & EsIngles())
			Exit Sub
		End Try


		Dim Tex As String = ""
		For J As Integer = 0 To Dt.Columns.Count - 1

			Tex &= Dt.Columns(J).ColumnName & ","
		Next
		Tex = Mid(Tex, 1, Tex.Length - 1)
		Sr.WriteLine(Tex)


		Dim Ciclos As Integer = 0

		Ciclos += 1



		Try

			'títulos

			'datos
			ProgressBar1.Maximum = Dt.Rows.Count
			ProgressBar1.Value = 0


			For Each Fi As DataRow In Dt.Rows 'I As Integer = 0 To Dt.Rows.Count - 1
				'Threading.Thread.Sleep(500)
				Try
					ProgressBar1.Value += 1
				Catch
				End Try

				HagaEventos()

				If CmdCancelar.Tag = "S" Then
					Me.Close()
					Exit Sub
				End If


				Tex = ""
				For J As Integer = 0 To Dt.Columns.Count - 1

					Dim Tex2 As String
					If Fi(J) Is DBNull.Value Then
						Tex &= ","
						Continue For
					End If
					If Dt.Columns(J).DataType Is System.Type.GetType("System.Boolean") Then
						If Fi(J) IsNot DBNull.Value Then
							If Fi(J) = True Then
								Tex2 = "1"
							Else
								Tex2 = "0"
							End If
						Else
							Tex2 = ""
						End If
					ElseIf Dt.Columns(J).DataType Is System.Type.GetType("System.DateTime") Then
						'Tex2 = Fi(J).ToString("yyyy/MM/dd HH:mm:ss")
						Tex2 = Strings.Format(Fi(J), "yyyy/MM/dd")
					Else
						'Tex2 = Fi(J).ToString.Replace("""", """""").Replace(DMScr, " ")
						Tex2 = Fi(J).ToString.Replace("""", """""")
					End If


					If Tex2.Contains(",") Then
						Tex2 = """" & Tex2 & """"
					End If
					Tex &= Tex2 & ","
				Next
				Tex = Mid(Tex, 1, Tex.Length - 1)
				Sr.WriteLine(Tex)
			Next


		Catch ex As Exception
			NoReloj()

			MostrarError(Me.Name, "Exportar_Plano_Excel", ex.Message)
			Exit Sub

		End Try

		Sr.Close()

		NoReloj()

		If Abrirlo Then
			Dim Pro As New Process
			Pro.StartInfo.FileName = NombreArchivo
			Pro.Start()
		End If



	End Sub

	Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
		If Not Pregunte("Seguro de cancelar exportación?") Then
			Exit Sub
		End If

		CmdCancelar.Tag = "S"
		Me.Close()

	End Sub

	Private Sub fCopiarExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Text = Idi(Me.Text)


	End Sub
End Class