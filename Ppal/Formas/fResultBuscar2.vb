' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fResultBuscar2
	'Public Lst As New CheckedListBox
	Public Lst As New Object

	Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
		Me.Tag = ""
		Me.Close()

	End Sub

	Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click, LstResult.DoubleClick
		If TabControl1.SelectedTab Is TbBuscar Then
			TabControl1.SelectedTab = TbResult
			Exit Sub
		End If

		If LstResult.SelectedIndex < 0 Then
			Mensaje("Seleccione alguno")
			Exit Sub
		End If


		Me.Tag = TraerId(LstResult)
		Me.Close()

	End Sub
	Private Sub Haga_Buscar()
		If TxtBuscar.Text.Trim = "" Then
			Mensaje("Entre texto a buscar")
			TabControl1.SelectedTab = TbBuscar
			TxtBuscar.Focus()
			Exit Sub
		End If

		Dim TextoBuscar2 As String = LCase(TxtBuscar.Text.Trim)

		Reloj()

		For I As Integer = 0 To Lst.Items.Count - 1
			If LCase(Lst.Items(I).ToString) Like IIf(OptTodo.Checked, "*", "") & TextoBuscar2 & "*" Then
				LstResult.Items.Add(Lst.Items(I))
			End If
		Next

		NoReloj(Me)

		If LstResult.Items.Count > 0 Then
			LstResult.SelectedIndex = 0
			TabControl1.SelectedTab = TbResult
		Else
			Mensaje("Texto no encontrado")
			'TabControl1.SelectedTab = TbBuscar
			'TxtBuscar.SelectAll()
			'TxtBuscar.Focus()
		End If

	End Sub

	Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
		If TabControl1.SelectedTab Is TbResult Then
			Haga_Buscar()
		End If

	End Sub

	Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged, RadioButton2.CheckedChanged, OptTodo.CheckedChanged
		Try
			LstResult.DataSource = Nothing

		Catch ex As Exception

		End Try

	End Sub

	Private Sub fResultBuscar_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
		TabControl1.SelectedTab = TbBuscar
		TxtBuscar.Focus()

	End Sub

End Class