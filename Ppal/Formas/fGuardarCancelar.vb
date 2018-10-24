' Version: 683, 23-ago.-2018 12:40
' Version: 680, 17-ago.-2018 13:24
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fGuardarCancelar

    Private Sub BotonEstandar3_Click(sender As Object, e As EventArgs) Handles CmdGuardar.Click, CmdNoGuardar.Click, CmdCancelar.Click
        Me.Tag = sender.tag
        Me.Hide()

    End Sub

    Private Sub fGuardarCancelar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_Idioma(Me, Me)

		Me.TopMost = True

	End Sub

    Private Sub fGuardarCancelar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If UCase(e.KeyChar) = "G" Then
            BotonEstandar3_Click(CmdGuardar, New EventArgs)
        ElseIf UCase(e.KeyChar) = "N" Then
            BotonEstandar3_Click(CmdNoGuardar, New EventArgs)
        ElseIf UCase(e.KeyChar) = "C" Then
            BotonEstandar3_Click(CmdCancelar, New EventArgs)
        End If
    End Sub
End Class