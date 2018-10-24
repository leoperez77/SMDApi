' Version: 684, 25-ago.-2018 20:17
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 21-ago.-2018 10:37
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 641, 4-abr.-2018 12:52
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fBusCen
    Public DsCen As New DataSet
    Public IdDis As Integer = 0
    Public IdGru As Integer = 0
    Public IdSub As Integer = 0
    Public IdCen As Integer = 0


    Private Sub fBusCen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

		CbRango_SelectedIndexChanged(CbRango, New EventArgs)

		If LstDis.Items.Count > 0 Then
            Exit Sub
        End If

        CbRango.SelectedIndex = 0

        Me.Width = LstDis.Tag

        Try
            SiReloj()

            Montar_Centros()

			Llene_Combo5(LstDis, DsCen.Tables(0), "id", "descripcion", , , "Todos", 0)

			NoReloj()

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "fBusCen_Load", ex.Message)
			Me.Close()
			Exit Sub
		End Try

	End Sub
	Public Sub Montar_Centros()
		Abrir(DsCen, "Exec GetConTodosCentros " & Numero_Empresa)

	End Sub
	Private Sub CmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles CmdCancelar.Click
		Me.Tag = -1
		Me.Hide()

	End Sub

	Private Sub CmdRegresar_Click(sender As System.Object, e As System.EventArgs) Handles CmdRegresar.Click
		TxtLibre1.Text = TxtLibre1.Text.Replace("'", "")
		TxtLibre2.Text = TxtLibre2.Text.Replace("'", "")

		If TxtLibre1.Text = "" And TxtLibre2.Text = "" Then
			CbRango.SelectedIndex = 0 'por si acaso
		End If

		If CbRango.SelectedIndex > 0 Then
			LstDis.SelectedIndex = 0
		End If

		Me.Tag = 1
		Me.Hide()

	End Sub
	Private Sub Verificar_Izq()
		Try

			If Me.Width + Me.Left > Screen.PrimaryScreen.WorkingArea.Width Then
				Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
			End If
		Catch ex As Exception

		End Try
	End Sub

	Private Sub LstDis_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstDis.SelectedIndexChanged

		LstSub.Items.Clear()
		LstCen.Items.Clear()
		LblGru.Visible = False
		LstGru.Visible = False
		LstSub.Visible = False
		LblSub.Visible = False
		LstCen.Visible = False
		LblCen.Visible = False

		IdDis = TraerId(LstDis)
		Llene_Combo5(LstGru, DsCen.Tables(1), "id", "descripcion", "id_con_cco_dis=" & IdDis, , "Todos", 0)

		If LstGru.Items.Count > 1 Then
			Me.Width = LstGru.Tag
			LblGru.Visible = True
			LstGru.Visible = True
		Else
			Me.Width = LstDis.Tag
		End If

		Verificar_Izq()

	End Sub


	Private Sub LstGru_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstGru.SelectedIndexChanged
		'CbRango.SelectedIndex = 0

		LstCen.Items.Clear()
		LstSub.Visible = False
		LblSub.Visible = False
		LstCen.Visible = False
		LblCen.Visible = False

		IdGru = TraerId(LstGru)
		Llene_Combo5(LstSub, DsCen.Tables(2), "id", "descripcion", "id_con_cco_gru=" & IdGru, , "Todos", 0)

		If LstSub.Items.Count > 1 Then
			Me.Width = LstSub.Tag
			LblSub.Visible = True
			LstSub.Visible = True
		Else
			Me.Width = LstGru.Tag
		End If

		Verificar_Izq()

	End Sub

	Private Sub LstSub_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstSub.SelectedIndexChanged
		'CbRango.SelectedIndex = 0

		LstCen.Visible = False
		LblCen.Visible = False
		IdSub = TraerId(LstSub)

		Llene_Combo5(LstCen, DsCen.Tables(3), "id", "descripcion", "id_con_cco_gru_sub=" & IdSub, , "Todos", 0)

		If LstCen.Items.Count > 1 Then
            Me.Width = LstCen.Tag
            LblCen.Visible = True
            LstCen.Visible = True
        Else
            Me.Width = LstSub.Tag
        End If

        Verificar_Izq()

    End Sub

    Private Sub LstCen_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstCen.SelectedIndexChanged
        'CbRango.SelectedIndex = 0

        IdCen = TraerId(LstCen)

    End Sub

    Private Sub CbRango_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbRango.SelectedIndexChanged
        Label2.Visible = CbRango.SelectedIndex > 0
        TxtLibre1.Visible = CbRango.SelectedIndex > 0
        TxtLibre2.Visible = CbRango.SelectedIndex > 0
        Label2.Text = CbRango.Text & " i/s"

        If CbRango.SelectedIndex = 0 Then
            'TxtLibre1.Text = ""
            'TxtLibre2.Text = ""
        Else
            TxtLibre1.Focus()
        End If

    End Sub
End Class