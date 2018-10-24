' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fPregContenido

	Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click
		Me.Tag = "-1"
		Me.Close()

	End Sub

	Private Sub CmdAceptar_Click(sender As Object, e As EventArgs) Handles CmdAceptar.Click
		Me.Tag = TxtContenido.Text.TrimEnd
		Me.Close()

	End Sub

End Class