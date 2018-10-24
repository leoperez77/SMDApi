'♥ versión: 586, 6-oct.-2017 07:11
Public Class fVarios
    Public SQL As String = ""

    Private Sub CmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles CmdCancel.Click

        Me.Hide()

    End Sub

    Private Sub CmdAplicar_Click(sender As System.Object, e As System.EventArgs) Handles CmdAplicar.Click, CmdQuitar.Click
        Me.Tag = sender.tag
        If sender.tag = 1 Then
            Dim Sq As String = CamposAdicionales1.DMSHagaSQL_Actualizar("-1")
            If Sq = "" Then
                Mensaje("No ha ingresado ningún filtro. Haga click en Cancelar o en Quitar Filtros")
                Exit Sub
            End If
        End If
        Me.Hide()

    End Sub

End Class