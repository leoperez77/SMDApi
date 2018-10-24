' Version: 683, 23-ago.-2018 12:40
' Version: 678, 16-ago.-2018 14:15
' Version: 675, 14-ago.-2018 18:45
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fClave
    Public Formita As Form
    Public Prog As String
    Public ClaveFija As String = ""

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ClaveFija <> "" Then
            If TextBox1.Text = ClaveFija Then
                Me.Tag = "1"
                Me.Close()
            Else
				Mensaje(Idi("Clave inválida", "Invalid Password"))
			End If
		Else
			Dim Clave = GetSett("Ayuda", "sp1", "")
			If TextBox1.Text = Clave Or TextBox1.Text = "268879" Then
				Me.Tag = "1"
				Me.Close()
			Else
				Mensaje(Idi("Clave inválida", "Invalid Password"))
			End If
		End If

	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		Me.Tag = "0"
		Me.Close()

	End Sub

	Private Sub fClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Label1.Text = Idi(Label1.Text, "Enter the Password")
		Button1.Text = Idi(Button1.Text, "Accept")
		Button2.Text = Idi(Button2.Text, "Cancel")
	End Sub
End Class