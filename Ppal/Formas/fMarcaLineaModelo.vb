' Version: 684, 25-ago.-2018 20:17
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 21-ago.-2018 10:37
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fMarcaLineaModelo



    Private Sub fMarcaLineaModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Llene_Combos()

	End Sub
    Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click
        Me.Tag = ""
        Me.Hide()

    End Sub

    Public Sub Llene_Combos()
        If CbMarca.Items.Count > 0 Then Exit Sub

        SiReloj()

        Try
            If DtVehMarca.Rows.Count = 0 Then
                Cargar_Veh_Modelos()
                Cargar_Colores()
            End If

            ponga_marcas()



        Catch ex As Exception
			MostrarError(Me.Name, "llene_combos", ex.Message)

		End Try


        NoReloj()

    End Sub

    Private Sub Ponga_Marcas()
        Dim Marcas As String = ReglaDeNegocio(134, "marcas", "")
        If Marcas <> "" Then
            Marcas = "id_veh_marca in(" & Marcas & ")"
        End If
		Llene_Combo5(CbMarca, DtVehMarca, "id_veh_marca", "marca", Marcas, "marca", "Todas", 0, False)

	End Sub
	Private Sub CbMarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbMarca.SelectedIndexChanged
		CbLinea.Items.Clear()
		CbModelo.Items.Clear()


		LblIDMarca.Text = TraerId(CbMarca)
		LblIDMarca.Visible = ValD(LblIDMarca.Text) > 0

		If CbMarca.SelectedIndex < 0 Then Exit Sub

		Llene_Combo5(CbLinea, DtVehLinea, "id_veh_linea", "linea", "id_veh_marca=" & TraerId(CbMarca), "linea", "Todas", 0, False)

	End Sub
	Private Sub CbLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbLinea.SelectedIndexChanged

		LblIDLin.Text = TraerId(CbLinea)
		LblIDLin.Visible = ValD(LblIDLin.Text) > 0

		CbModelo.Items.Clear()

		If CbLinea.SelectedIndex < 0 Then Exit Sub

		Llene_Combo5(CbModelo, DtVehModelo, "id_veh_linea_modelo", "modelo", "id_veh_linea=" & TraerId(CbLinea), "modelo", "Todos", 0, False)

	End Sub

    Private Sub CmdAceptar_Click(sender As Object, e As EventArgs) Handles CmdAceptar.Click
        Me.Tag = 1
        Me.Hide()

    End Sub
End Class