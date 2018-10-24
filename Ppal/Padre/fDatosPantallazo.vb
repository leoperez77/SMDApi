' Version: 683, 23-ago.-2018 12:40
' Version: 675, 14-ago.-2018 18:45
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fDatosPantallazo

	Private Sub fDatosPantallazo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Text = Idi(Me.Text, "Save print screen")
		Recorrer_Controles_Idioma(Me, Me)

		If UsuarioOriginal > 0 And MarcaExterna <> "local" And UsuarioOriginal <> Usuario Then
			GrpDonde.Visible = True
			OptMiCuenta.Checked = True
		Else
			GrpDonde.Visible = False
			OptBDCliente.Checked = True
		End If

	End Sub
	Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Tag = 0
        Me.Hide()

    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles CmdGuardar.Click
        Me.Tag = 1
        Me.Hide()

       

    End Sub

    Private Sub LnkVerPant_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkVerPant.LinkClicked
        Me.Tag = 0
        Me.Hide()

        'AbrirPrograma("0290", "-1")
        Ejecute_Proceso(Path_Prog & "SMDMenu.exe", """" & -15 & """")

    End Sub

    Private Sub fDatosPantallazo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.TopMost = True
        TxtExplica.Focus()

    End Sub
End Class