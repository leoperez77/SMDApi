' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
<System.ComponentModel.DefaultEvent("DMSCheckIndex")> _
Public Class CheckListBoxDMS
    Public Event DMSCheckIndex(ByVal Sender As Object, ByVal id As Integer, ByVal ValorCheck As Boolean, ByRef NuevoValor As CheckState)


    Public Function DMSPongaIndex(ByVal IdInicial As Integer) As Integer
        Lst1.SelectedValue = IdInicial
        Lst1.SetItemChecked(Lst1.SelectedIndex, True)

    End Function

    Public Sub DMSLlene_Lst(ByVal Dt As DataTable, ByVal NombreId As String, ByVal NombreDes As String)
        Lst1.DataSource = Dt
        Lst1.DisplayMember = NombreDes
        Lst1.ValueMember = NombreId
    End Sub
    Public Function DmsTraerIds() As String
        Dim Ids As String = ""
        For I = 0 To Lst1.CheckedItems.Count - 1
            Dim Dr As DataRowView = Lst1.CheckedItems(I)
            If I > 0 Then
                Ids &= ","
            End If
            Ids &= Dr.Row(Lst1.ValueMember)
        Next
        Return Ids
    End Function

    Public Sub TodosNinguno(ByVal Valor As Boolean)
        For I As Integer = 0 To Lst1.Items.Count - 1
            Lst1.SetItemChecked(I, Valor)
        Next
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click

        Lst1.SelectedValue = Buscar(Lst1.DataSource, Lst1.DisplayMember, Lst1.ValueMember)

        If Lst1.SelectedIndex < 0 Then Exit Sub
        Lst1.SetItemChecked(Lst1.SelectedIndex, True)
        Lst1.Focus()

    End Sub


    Private Sub ContarLineasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContarLineasToolStripMenuItem.Click
        Mensaje(ContarLineasDt(Lst1.DataSource))

    End Sub




    Private Sub Lst1_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles Lst1.ItemCheck

        Dim Dr As DataRowView = Lst1.Items(e.Index)
        RaiseEvent DMSCheckIndex(Me, Dr.Row(Lst1.ValueMember), Lst1.GetItemChecked(Lst1.SelectedIndex), e.NewValue)
    End Sub

    Private Sub MarcarTodosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcarTodosToolStripMenuItem.Click
        TodosNinguno(True)
    End Sub

    Private Sub DesmarcarTodosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesmarcarTodosToolStripMenuItem.Click
        TodosNinguno(False)
    End Sub

	Private Sub CheckListBoxDMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_ContextMenuStrip(ContextMenuStrip1)

	End Sub
End Class
