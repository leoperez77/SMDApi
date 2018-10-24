' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 673, 3-ago.-2018 14:58
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fConfigDigitalizacion

	Private Sub LnkEstadistica_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkEstadistica.LinkClicked

		If NoPuede4("0110", 10, , False) Then
			If NoPuede4("0110", 80) Then Exit Sub
		End If

		Dim Dt As New DataTable
		SiReloj()

		Try
			Abrir(Dt, "GetDigitalizacionTotalConsumo " & Numero_Empresa.ToString)

			NoReloj()

			Ventana(Dt, "Consumo de digitalización")

		Catch ex As system.Exception
			MostrarError(Me.Name, "LnkDigi_LinkClicked", ex.Message)

		End Try

		NoReloj()

	End Sub

	Private Sub LnkConfiguracion_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkConfiguracion.LinkClicked
		If NoPuede4("0110", 10, , False) Then
			If NoPuede4("0110", 85) Then Exit Sub
		End If

	End Sub

End Class