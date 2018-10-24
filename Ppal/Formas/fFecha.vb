' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fFecha

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click
        If SplitContainer1.Panel1Collapsed = False Then
            If TxtAsunto.Text.Trim = "" Then
                Mensaje("Entre asunto")
                TxtAsunto.Focus()
                Exit Sub
            End If
            If Strings.Format(Mes.SelectionStart.Date, "yyyyMMdd") < Strings.Format(Now, "yyyyMMdd") Then
                Mensaje("No puede ser menor que la fecha")
                Exit Sub
            End If
            If Strings.Format(Mes.SelectionStart.Date, "yyyyMMdd") = Strings.Format(Now, "yyyyMMdd") And Strings.Format(CbHora.Value, "HH:mm") < Strings.Format(Now, "HH:mm") Then
                Mensaje("No puede ser menor que la hora actual")
                Exit Sub
            End If
            If Mes.SelectionStart.Date > DateAdd(DateInterval.Month, 24, FechaHoyAsignada) Then
                Mensaje("No puede ser mayor a 2 años")
                Exit Sub
            End If
        End If

        If CbHora.Visible Then
            Me.Tag = Strings.Format(Mes.SelectionStart.Date, "yyyy/MM/dd") & " " & CbHora.Text & IIf(TxtAsunto.Text <> "", "|", "") & TxtAsunto.Text
        Else
            Me.Tag = Strings.Format(Mes.SelectionStart.Date, "yyyy/MM/dd") & IIf(TxtAsunto.Text <> "", "|", "") & TxtAsunto.Text
        End If
        Me.Close()

    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.Tag = ""
        Me.Close()

    End Sub

    Private Sub fFecha_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


		If Strings.Left(Me.Text, 1) = "*" Then
			Me.Text = Strings.Mid(Me.Text, 2)
			TxtAsunto.Focus()
		Else
			SplitContainer1.Panel1Collapsed = True
            Me.Height = 267
        End If

		Recorrer_Controles_Idioma(Me, Me)
		Me.Text = Idi(Me.Text)

		CbHora.Value = CDate(Strings.Format(DateAdd(DateInterval.Hour, 1, Now), "yyyy/MM/dd HH") & ":00")




    End Sub
End Class