' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 639, 22-mar.-2018 12:39
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fAccesorios
    Public DtEscogidos As New DataTable
    Private Sub fAccesorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try
			SiReloj()
			Dim Dt As New DataTable
			Abrir(Dt, "GetVehAccesorios " & Me.Tag)
			NoReloj()

			If Fin(Dt) Then
				Me.Tag = "-1"
				Me.Close()
				Exit Sub
			End If

			Haga_Grid(Dt)




		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "fAccesorios_Load", ex.Message)

		End Try
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Tag = "-1"
        Me.Close()

    End Sub

    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles CmdOK.Click
        If CmdOK.Tag <> "" Then
            Mensaje(CmdOK.Tag)
            'CmdCancel.PerformClick()
            Exit Sub
        End If

        Dim Dt As DataTable = Filtrar_DataTable(Grd.DMSDevolverDt, "isnull(inc,false) = true")
        If Fin(Dt) Then
            Mensaje("No ha incluido ningún ítem. Si ese es el caso, haga clic en Cancelar")
            Exit Sub
        End If

        DtEscogidos.Rows.Clear()
        If DtEscogidos.Columns.Count = 0 Then
            DtEscogidos.Columns.Add("codigo")
            DtEscogidos.Columns.Add("cantidad")
        End If
        For Each Fi As DataRow In Dt.Rows
            DtEscogidos.Rows.Add(Fi("codigo"), Fi("cantidad"))
        Next
        Me.Tag = 1
        Me.Close()

    End Sub

    Private Sub ChkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTodos.CheckedChanged
        Dim Dt As DataTable = Grd.Grid.DataSource

        For Each Fi As DataRow In Dt.Rows
            If ChkTodos.Checked Then
                Fi("inc") = True
            Else
				Fi("inc") = DBNull.Value
			End If
            Fi.AcceptChanges()
        Next

        Haga_Grid(Dt)


    End Sub

    Private Sub Haga_Grid(Dt As DataTable)
        For Each Fi As DataRow In DtEscogidos.Rows
            Dim Dr() As DataRow
            Dr = Dt.Select("id_cot_item_sus=" & Fi("id_cot_item"), "")
            Dr(0)("inc") = True
            Dr(0).AcceptChanges()
        Next
        DtEscogidos.Rows.Clear() 'solo se usa para la primera vez


        Grd.DMSLlene_Grid(Dt, "id_cot_item_sus", ColOcultas:=New Object() {"id_cot_item_sus"}, ColModificables:=New Object() {"inc"}, MostrarEliminar:=False)


        Grd.Grid.Columns("inc").Width = 30
        Grd.Grid.Columns("codigo").Width = 100
        Grd.Grid.Columns("descripcion").Width = 250
        Grd.Grid.Columns("cantidad").Width = 60
        Grd.Grid.ClearSelection()



    End Sub
End Class