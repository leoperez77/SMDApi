' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
Public Class MostrarMDI
    Public Shared Sub Mostrar_MDI_Dataset(Ds As DataSet, Titulo As String, Icono As Icon)

        Try
            Dim fVa As New fVariasTablasMDI

            Dim Hay As Short = SiRelojCond()


            For Each Tabl As DataTable In Ds.Tables
                If Not Fin(Tabl) Then
                    Dim ChildForm As New fVariasTablasChild
                    ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
                    ChildForm.MdiParent = fVa
                    ChildForm.GridDms1.DMSLlene_Grid(Tabl)
                    ChildForm.Text = Tabl.TableName
                    ChildForm.Show()
                    'Ventana(Tabl, Tabl.TableName & ": " & TxtID.Text, False)
                End If
            Next
            fVa.Text = Titulo
            fVa.Icon = Icono
            fVa.Show()
            fVa.LayoutMdi(MdiLayout.TileHorizontal)

            SiRelojCond(Hay)

        Catch ex As Exception
            NoReloj()
			MostrarError("MostrarMDI", "Mostrar_MDI_Dataset", ex.Message)

		End Try



    End Sub

End Class
