' Version: 678, 16-ago.-2018 14:15
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fDebugJD
    Public Filtro As String = ""
    Private Sub fDebugJD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtDebug.Tag = ""
        TxtDebug.Text = ""

        Filtro = GetSett(Me.Name, "filtro", "")
        Poner_Filtro()

        Timer1.Start()

    End Sub

    Private Sub LnkDetener_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkDetener.LinkClicked
        MostrarDebug = "N"
        SaveSett("menu", "dbj", MostrarDebug)
        Me.Close()


    End Sub
 
    Private Sub LnkLimpiar_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkLimpiar.LinkClicked
        TxtDebug.Text = ""

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If VarJD = "" Then Exit Sub

        TxtDebug.Text &= VarJD
        VarJD = ""

        TxtDebug.SelectionStart = TxtDebug.Text.Length
        TxtDebug.ScrollToCaret()
        HagaEventos()

    End Sub

    Private Sub ChkDetener_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDetener.CheckedChanged
        Timer1.Enabled = Not ChkDetener.Checked

    End Sub

    Private Sub LnkFiltro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkFiltro.LinkClicked
		Filtro = Inputbox2("Filtro:", , Filtro)
		SaveSett(Me.Name, "filtro", Filtro)
        poner_filtro()


    End Sub
    Private Sub Poner_Filtro()
        LnkFiltro.Text = "Filtro"
        If Filtro <> "" Then
            LnkFiltro.Text &= "=" & Filtro
        End If

    End Sub

    Private Sub LnkFuente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkFuente.LinkClicked
        If TxtDebug.Font Is LblSize.Font Then
            TxtDebug.Font = LnkFuente.Font
        Else
            TxtDebug.Font = LblSize.Font
        End If


    End Sub
End Class