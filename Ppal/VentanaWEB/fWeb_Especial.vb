'♥ versión: 586, 6-oct.-2017 07:11
Public Class fWeb_Especial
	Dim CerrarVentana As Boolean = False
	Public FormaLlamadora As Form
	Public Seccion As String = ""
	Public SegundosVisible As Integer = 6
	Private Sub fWeb_Especial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		VentanitaWEB.CerrarVentanaWEB = False
		Timer1.Tag = 0

		Timer1.Start()

	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		'12=6 segundos
		If Timer1.Tag > SegundosVisible * 2 Or VentanitaWEB.CerrarVentanaWEB Then
			Me.Close()
		Else
			Timer1.Tag += 1
		End If

	End Sub

	Private Sub fWeb_Especial_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
		Static ActivoVentana As Integer = 0
		ActivoVentana += 1
		If ActivoVentana > 1 Then
			Timer1.Stop()
			CerrarVentana = True
		End If

	End Sub

	Private Sub fWeb_Especial_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
		If CerrarVentana Then
			Me.Close()
		End If

	End Sub

	Private Sub fWeb_Especial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		SaveSetting("DMS S.A.", "web_esp", FormaLlamadora.Name & Seccion, Me.Width & "," & Me.Height)

	End Sub


End Class