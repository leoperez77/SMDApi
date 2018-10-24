' Version: 684, 25-ago.-2018 20:17
' Version: 650, 7-may.-2018 12:42
' Version: 596, 9-nov.-2017 19:28
' Version: 595, 8-nov.-2017 08:03
' Version: 595, 7-nov.-2017 15:15
' Version: 595, 7-nov.-2017 11:14
'♥ versión: 586, 6-oct.-2017 07:11
Public Class BotonEstandar
    Inherits Button
	Dim ya As Boolean = False

	'Private Sub BotonEstandar_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
	'	Me.BackgroundImage = Global.SMDPpal.My.Resources.over
	'End Sub

	'Private Sub BotonEstandar_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
	'	Me.BackgroundImage = Global.SMDPpal.My.Resources.reposo

	'End Sub


	Private Sub BotonEstandar_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
		If ya Then Exit Sub
		ya = True
		Imagen_Ene()

	End Sub

	Private Sub BotonEstandar_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged
		Imagen_Ene()

	End Sub
	Private Sub Imagen_Ene()
		If Me.Enabled Then
			Me.BackgroundImage = Global.SMDPpal.My.Resources.reposo
			Me.ForeColor = Color.White
		Else
			Me.BackgroundImage = Nothing
			Me.ForeColor = Color.Black
		End If

	End Sub

	Private Sub BotonEstandar_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
		sender.text = Idi(sender.text)

	End Sub
End Class
