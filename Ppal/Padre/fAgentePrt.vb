'♥ versión: 586, 6-oct.-2017 07:11
Public Class fAgentePrt
    Public FormaActiva As Form

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Hay As String = GetSett("fC", "act_prt", "0")
        If Hay <> "1" Then
            Exit Sub
        End If


        If FormaActiva Is Nothing Then
            Exit Sub
        End If

        If Strings.Mid(GetSett("fC", "act_name", ""), 1, 10).Trim <> Strings.Mid(FormaActiva.Text, 1, 10).Trim Then
            Exit Sub
        End If


        NoReloj()

        SaveSett("fC", "act_prt", "0")


        Try
            'FormaActiva.TopMost = True
            If FormaActiva.Modal = True Then
                FormaActiva.BringToFront()
            Else
                If FormaActiva.WindowState = FormWindowState.Minimized Then
                    FormaActiva.WindowState = FormWindowState.Normal
                End If
                FormaActiva.Show()
                FormaActiva.BringToFront()
            End If
        Catch
        End Try


        If fAdvOpc Is Nothing Then
            fAdvOpc = New fAdvanceOpciones
        End If

        fAdvOpc.Location = FormaActiva.Location
        fAdvOpc.Left += 10
        fAdvOpc.Top += 10
        fAdvOpc.LnkCambiar.Visible = False

        fAdvOpc.fOrig = FormaActiva

        fAdvOpc.LblTitulo.Text = FormaActiva.Text

        'FormaActiva.TopMost = False

        Try
            If FormaActiva.Modal = True Then
                fAdvOpc.TopMost = True
                fAdvOpc.ShowDialog()
            Else
                fAdvOpc.Show()

            End If


        Catch ex As Exception

            MsgBox("Esta opción no se puede llamar en este momento", MsgBoxStyle.Information)
        End Try

    End Sub
End Class