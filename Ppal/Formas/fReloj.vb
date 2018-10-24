'♥ versión: 586, 6-oct.-2017 07:11
Public Class fMostrarSonido

    Private Sub fReloj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'jd
        Me.Size = New Point(49, 49)

        Me.FormBorderStyle = FormBorderStyle.None
        Me.TransparencyKey = System.Drawing.Color.FromArgb(121, 121, 121)
        'Me.PictureBox1.Image = fSpl.LogoSMD.Image

        'Me.Size = PictureBox1.Size
        Me.TopMost = True


    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    Me.TopMost = True
    '    HagaEventos()

    'End Sub

    'Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
    '    Timer1.Stop()
    '    Me.Hide()

    'End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()

    End Sub
End Class