Public Class fGraficas_Instalar

    Private Sub LnkMS_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkMS.LinkClicked
        LnkMS.LinkVisited = True
        AbrirLink("http://www.microsoft.com/downloads/details.aspx?FamilyID=130f7986-bf49-4fe5-9ca8-910ae6ea442c&displaylang=en")

        Me.Tag = "S"
        Me.Close()

    End Sub

    Private Sub LnkDMS_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkDMS.LinkClicked
        LnkDMS.LinkVisited = True
        AbrirLink("http://www.mensajeriacorporativa.com/mschart.EXE")

        Me.Tag = "S"
        Me.Close()

    End Sub

    Private Sub LnkDetalles_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkDetalles.LinkClicked
        Mensaje(LnkDetalles.Tag)

    End Sub

    Private Sub LnkFrame_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkFrame.LinkClicked
        LnkFrame.LinkVisited = True
        AbrirLink("http://www.mensajeriacorporativa.com/dotnetfx35setup.exe")

        Me.Tag = "S"
        Me.Close()


    End Sub
End Class