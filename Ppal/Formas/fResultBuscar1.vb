' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 619, 5-feb.-2018 12:54
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fResultBuscar1

	Public Dt As New DataTable
	Public CampoBuscar As String
	Public TextoBuscar As String = ""
	Public CampoId As String
	Dim Cargando As Boolean = True
	Private Sub fResultBuscar1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Me.Width = GetSett(Me.Name, "tam_w", Me.Width)
		If Me.Width < 200 Then
			Me.Width = 200
		End If
		Me.Height = GetSett(Me.Name, "tam_h", Me.Height)
		If Me.Height < 200 Then
			Me.Height = 200
		End If

		Cargando = False

	End Sub
	Private Sub fResultBuscar1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
		If Cargando Then Exit Sub

		SaveSett(Me.Name, "tam_w", Me.Width)
		SaveSett(Me.Name, "tam_h", Me.Height)

	End Sub

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


		Me.Tag = LstResult.SelectedValue
		Me.Close()

	End Sub
	Private Sub Haga_Buscar()
		Try

			Dim TextoBuscar2 As String = LCase(TxtBuscar.Text.Trim)

			Reloj()
			Dim DtSintildes As DataTable = Dt.Copy
			For I = 0 To DtSintildes.Rows.Count - 1
				DtSintildes.Rows(I).Item(CampoBuscar) = SinTildes(DtSintildes.Rows(I).Item(CampoBuscar))
			Next

			Dim DtTemp As DataTable = Filtrar_DataTable(DtSintildes, CampoBuscar & " like '" & IIf(OptTodo.Checked, "*", "") & SinTildes(TextoBuscar2) & "*'")

			LstResult.DataSource = DtTemp
			LstResult.DisplayMember = CampoBuscar
			LstResult.ValueMember = CampoId

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
		Catch ex As Exception

		End Try

	End Sub

	Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
		If TabControl1.SelectedTab Is TbResult Then
			CmdAceptar.Text = "Regresar"
			Haga_Buscar()
		Else
			CmdAceptar.Text = "Buscar"
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

		If TextoBuscar <> "" Then
			TxtBuscar.Text = TextoBuscar
			TextoBuscar = ""
			Haga_Buscar()
		End If

	End Sub


	Private Sub TabControl1_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl1.Selecting
		If TxtBuscar.Text.Trim = "" Then
			Mensaje("Entre texto a buscar")
			TxtBuscar.Focus()
			e.Cancel = True
		End If

	End Sub

End Class