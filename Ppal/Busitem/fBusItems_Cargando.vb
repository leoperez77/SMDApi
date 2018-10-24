'♥ versión: 586, 6-oct.-2017 07:11
Public Class fBusItems_Cargando

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    Timer1.Enabled = False
    '    Me.Hide()
    '    HagaEventos()


    'End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        'Timer1.Enabled = False
        If Me.Tag = "S" Then
            Mensaje(Label1.Text)
        End If
        Me.Hide()
        HagaEventos()

    End Sub

    Private Sub fBusItems_Cargando_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AsignarImagenPrograma(PictureBox1, 4)

    End Sub
End Class