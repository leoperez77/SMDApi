' Version: 655, 1-jun.-2018 12:53
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fColums
    Public GrdSug As DataGridView
    Private Sub CmdAplicarCols_Click(sender As System.Object, e As System.EventArgs) Handles CmdAplicarCols.Click
        Try
            Dim Dt As New DataTable
            Dt.Columns.Add("nombre")

            For I As Integer = 0 To GrdCols.Rows.Count - 1
                GrdSug.Columns(GrdCols.Rows(I).Cells("nombre").Value).visible = GrdCols.Rows(I).Cells("ver").Value
                If GrdCols.Rows(I).Cells("ver").Value = False Then 'copiar en archivo las ocultas nada más
                    Dt.Rows.Add(GrdCols.Rows(I).Cells("nombre").Value)
                End If
            Next

            Dim Ds As New DataSet
            Ds.Tables.Add(Dt)
            Ds.WriteXml("c:\smd_files\cols" & Me.Tag)
            Ds.WriteXmlSchema("c:\smd_files\cols" & Me.Tag & ".1")

            Me.Close()

        Catch ex As Exception
            MostrarError(Me.Name, "CmdAplicarCols_Click", ex.Message)

        End Try

    End Sub
    Private Sub GrdCols_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdCols.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex <> 0 Then Exit Sub

        If GrdCols.Rows(e.RowIndex).Cells(0).Value = True Then
            GrdCols.Rows(e.RowIndex).Cells(0).Value = False
        Else
            GrdCols.Rows(e.RowIndex).Cells(0).Value = True
        End If

        'hacerlo ya mismo
        GrdSug.Columns(GrdCols.Rows(e.RowIndex).Cells("nombre").Value).visible = GrdCols.Rows(e.RowIndex).Cells("ver").Value
        'If GrdCols.Rows(I).Cells("ver").Value = False Then 'copiar en archivo las ocultas nada más
        '    Dt.Rows.Add(GrdCols.Rows(I).Cells("nombre").Value)
        'End If

    End Sub
    Private Sub LnkPredeter_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkPredeter.LinkClicked
        Try
            Kill("c:\smd_files\cols" & Me.Tag & ".1")
            Kill("c:\smd_files\cols" & Me.Tag)

        Catch ex As Exception

        End Try

        Mensaje("Debe volver a cargar los datos para reflejar los resultados")

        Me.Close()


    End Sub

	Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click
		'ponerlas todas visibles
		'For I As Integer = 0 To GrdSug.Columns.Count - 1
		'    GrdSug.Columns(I).Visible = True
		'Next

		'CCols.Mostrar_Columnas(Me.Tag, GrdSug)

		Me.Close()

	End Sub
End Class