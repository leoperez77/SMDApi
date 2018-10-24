'♥ versión: 586, 6-oct.-2017 07:11
Public Class fVerSonido

    Private Sub fVerSonido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.TransparencyKey = System.Drawing.Color.FromArgb(121, 121, 121)
        'Me.PictureBox1.Image = fSpl.LogoSMD.Image

        'Me.Size = PictureBox1.Size
        Me.TopMost = True

    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

End Class