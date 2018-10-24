' Version: 615, 23-ene.-2018 13:32
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fImageList

    Public Sub LlenarImage2()
        If ImageList2.Images.Count = 0 Then
            SiReloj()
            For I As Integer = 0 To ImageList1.Images.Count - 1
                ImageList2.Images.Add(ImageList1.Images(I))
            Next
            NoReloj()
        End If


    End Sub
End Class