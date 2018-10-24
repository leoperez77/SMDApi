' Version: 683, 23-ago.-2018 12:40
' Version: 680, 17-ago.-2018 13:24
' Version: 661, 10-jul.-2018 13:27
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fTextBox

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox1.Tag = TextBox1.Text
            Me.Hide()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If

    End Sub


    Private Sub fTextBox_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextBox1.SelectionStart = 0
        TextBox1.SelectionLength = 0

    End Sub

	Private Sub fTextBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Text = Idi(Me.Text)

	End Sub
End Class