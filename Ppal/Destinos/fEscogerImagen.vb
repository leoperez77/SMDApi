'♥ versión: 586, 6-oct.-2017 07:11
Public Class fEscogerImagen

    Private Sub fEscogerImagen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmdCancelar.Left = -500
        CmdAceptar.Left = -500
        'Dim Img As ImageList
        'Img = fDestiModal.ImageList1
        'Img.ImageSize = New Point(32, 32)

        ListView1.LargeImageList = fImg.ImageList1

        For I As Integer = 0 To fImg.ImageList1.Images.Count - 1
            ListView1.Items.Add(I.ToString, I)
            If I = ValD(Me.Tag) Then
                ListView1.Items(I).Selected = True
                ListView1.Items(I).EnsureVisible()
                ListView1.FocusedItem = ListView1.Items(I)
            End If
        Next

        Me.Tag = ""

    End Sub

    Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click
        Me.Tag = ""
        Me.Close()

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick, CmdAceptar.Click

        Me.Tag = ListView1.SelectedItems(0).Index
        Me.Close()

    End Sub

   
End Class