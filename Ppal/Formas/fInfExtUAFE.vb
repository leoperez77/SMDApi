' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 636, 9-mar.-2018 13:03
' Version: 635, 6-mar.-2018 07:29
' Version: 634, 2-mar.-2018 18:51
Public Class fInfExtUAFE
    'LFAA: 634
    Private Sub CmdAceptar_Click(sender As Object, e As EventArgs) Handles CmdAceptar.Click
        Try
            If CmbTipo.Text = "" Or TxtIdentificacion.Text = "" Or TxtNombres.Text = "" Then
                Mensaje("Debe completar la informaci�n")
                Exit Sub
            End If
            'LFAA: 635
            'Se valida la c�dula
            If CmbTipo.SelectedIndex = 0 And Len(TxtIdentificacion.Text) <> 10 Then
                Mensaje("La c�dula debe ser de 10 d�gitos")
                Exit Sub
            End If
            'Se valida el RUC
            If CmbTipo.SelectedIndex = 1 And Len(TxtIdentificacion.Text) <> 13 Then
                Mensaje("El RUC debe ser de 13 d�gitos")
                Exit Sub
            End If
            '/LFAA: 635
            Me.Hide()
        Catch ex As Exception
			MostrarError(Me.Name, "CmdAceptar_Click", ex.Message)
		End Try
	End Sub
	Public Sub CargarCombo()
		Try
			CmbTipo.Items.Clear()
			CmbTipo.Items.Add(New DataDescription(1, "C�dula"))
			CmbTipo.Items.Add(New DataDescription(2, "RUC"))
			CmbTipo.Items.Add(New DataDescription(3, "Pasaporte"))
			CmbTipo.Items.Add(New DataDescription(4, "An�logo"))
			CmbTipo.SelectedIndex = 0
		Catch ex As Exception
			MostrarError(Me.Name, "CargarCombo", ex.Message)
		End Try
	End Sub
	Private Sub fInfExtUAFE_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		Try
			CmbTipo.Text = ""
			TxtIdentificacion.Text = ""
			TxtNombres.Text = ""
		Catch ex As Exception
			MostrarError(Me.Name, "fInfExtUAFE_FormClosed", ex.Message)
		End Try
    End Sub

	'/LFAA: 634
End Class