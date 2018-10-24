' Version: 667, 19-jul.-2018 12:57
' Version: 666, 17-jul.-2018 13:12
'♥ versión: 586, 6-oct.-2017 07:11
Public Class CCols
    Public Shared Sub Mostrar_Columnas(Prog As String, Grd As DataGridView)

		'jdms 666 obsoleto
		'Try

		'	Dim Ds As New DataSet
		'	Ds.ReadXmlSchema("c:\smd_files\cols" & Prog & ".1")
		'	Ds.ReadXml("c:\smd_files\cols" & Prog)

		'	For Each Fi As DataRow In Ds.Tables(0).Rows
		'		Grd.Columns(Fi("nombre")).visible = False
		'	Next

		'Catch ex As Exception

		'End Try

	End Sub
	Public Shared Sub Cambiar_Columnas(Prog As String, Grd As DataGridView, Optional UltimaColumna As String = "")
		Mensaje("ATENCIÓN: Esta opción ya no trabaja en Advance. Haga clic derecho sobre la columna que deseee personalizar del grid'; cambie el ancho de las columnas, cambie la posición de la columna dentro del grid. Cuando termine de personalizar haga clic derecho y Guarde los cambios.")

		'Dim fCo As New fColums

		'fCo.GrdCols.Rows.Clear()

		'For I As Integer = 0 To Grd.Columns.Count - 1
		'	fCo.GrdCols.Rows.Add("", Grd.Columns(I).Name, Grd.Columns(I).HeaderText)
		'	If Grd.Columns(I).Visible Then
		'		fCo.GrdCols.Rows(fCo.GrdCols.Rows.Count - 1).Cells(0).Value = True
		'	Else
		'		fCo.GrdCols.Rows(fCo.GrdCols.Rows.Count - 1).Cells(0).Value = False
		'	End If
		'	If UltimaColumna <> "" Then
		'		If Grd.Columns(I).Name = UltimaColumna Then 'aqui termina
		'			Exit For
		'		End If
		'	End If
		'Next

		'fCo.Tag = Prog
		'fCo.GrdSug = Grd
		'fCo.ShowDialog()

	End Sub
End Class
