' Version: 681, 20-ago.-2018 20:08
' Version: 675, 14-ago.-2018 18:45
' Version: 668, 23-jul.-2018 13:18
'♥ versión: 586, 6-oct.-2017 07:11
Public Class CGrid
	''' <summary>
	''' Copia un grid completo en otro vacío
	''' </summary>
	''' <param name="GrdOrigen">Grid original</param>
	''' <param name="GrdDestino">Grid destino</param>
	''' <remarks></remarks>
	Public Sub Copiar_Grid(ByVal GrdOrigen As DataGridView, ByRef GrdDestino As DataGridView)
		GrdDestino.Rows.Clear()
		GrdDestino.Columns.Clear()

		For I As Integer = 0 To GrdOrigen.Columns.Count - 1
			Dim Colu As DataGridViewColumn = GrdOrigen.Columns(I).Clone
			GrdDestino.Columns.Add(Colu)
		Next
		Dim Valores() As String = {}
		ReDim Valores(GrdOrigen.ColumnCount)
		For I As Integer = 0 To GrdOrigen.Rows.Count - 1
			Dim row As DataGridViewRow = GrdOrigen.Rows(I)
			Dim Ndx As Integer = 0
			Dim Si As Boolean = False
			For Ndx = 0 To GrdOrigen.ColumnCount - 1
				If row.Cells(Ndx).Value Is System.DBNull.Value Then
					Valores(Ndx) = ""
				Else
					Valores(Ndx) = row.Cells(Ndx).Value
				End If
				If Valores(Ndx) <> "" Then
					Si = True
				End If
			Next
			If Si Then
				GrdDestino.Rows.Add(Valores)
			End If
		Next

	End Sub
	''' <summary>
	''' Selecciona la fila de un grid y la deja visible
	''' </summary>
	''' <param name="Grd">Nombre del grid</param>
	''' <param name="NombreCampo">Nombre del campo para buscar la fila</param>
	''' <param name="ValorCampo">Contenido del campo</param>
	''' <remarks></remarks>
	Public Sub Seleccionar_Fila(Grd As DataGridView, NombreCampo As String, ValorCampo As String)

		Try
			For I As Integer = 0 To Grd.Rows.Count - 1
				If Tm(Grd, NombreCampo, I) = ValorCampo Then
					Grd.Rows(I).Selected = True
					Grd.FirstDisplayedScrollingRowIndex = I
					Exit For
				End If
			Next

		Catch ex As Exception

		End Try

	End Sub

End Class
