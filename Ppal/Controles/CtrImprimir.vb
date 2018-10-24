' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 679, 16-ago.-2018 21:01
' Version: 679, 16-ago.-2018 20:01
'♥ versión: 586, 6-oct.-2017 07:11
Public Class CtrImprimir
	Dim _NombreForma As String = "Ninguna"
	Dim _VerCruzar As Boolean = False

    Private Sub CtrImprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Recorrer_Controles_Idioma(Me, Me)
		DMSTraerDefault()

	End Sub
    Property DMSNombreForma() As String
        Get
            Return _NombreForma
        End Get
        Set(ByVal value As String)
            _NombreForma = value
        End Set
    End Property
    Property DMSVerOpcionCruzar() As Boolean
        Get
            Return _VerCruzar
        End Get
        Set(ByVal value As Boolean)
            _VerCruzar = value
        End Set
    End Property
    Public Sub DMSTraerDefault()
        Dim Cual As String = ValD(GetSetting(DiegoSet, "opcimprimir", DMSNombreForma, "3"))
        If Cual = "0" Then
            OptImpr.Checked = True
        ElseIf Cual = "1" Then
            OptVer.Checked = True
        ElseIf Cual = "2" Then
            OptMail.Checked = True
        ElseIf Cual = "3" Then
            OptNinguna.Checked = True
        Else
            ChkCruzar.Checked = True
        End If

        If DMSVerOpcionCruzar Then
            ChkCruzar.Visible = True
            'If GetSett("opccruzar", DMSNombreForma, "1") = "1" Then
            '    ChkCruzar.Checked = True
            'End If
        Else
            If ChkCruzar.Checked Then
                OptVer.Checked = True
            End If
            OptImpr.Top = 10
            OptVer.Top = 10
            OptMail.Top = 31
            OptNinguna.Top = 31
        End If

    End Sub
    Public Function DMSImprimir() As Integer
        If OptNinguna.Checked Then 'nada
            Return 0
        ElseIf OptImpr.Checked Then 'impr
            Return 1
        ElseIf OptVer.Checked Then 'ver
            Return 2
        ElseIf OptMail.Checked Then 'ver
            Return 3
        Else
            Return 4 'cruzar
        End If

    End Function

    Private Sub OptMail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptMail.CheckedChanged, OptVer.CheckedChanged, OptNinguna.CheckedChanged, OptImpr.CheckedChanged
        Dim Cual As String = "3"
        If OptImpr.Checked Then
            Cual = "0"
        ElseIf OptVer.Checked Then
            Cual = "1"
        ElseIf OptMail.Checked Then
            Cual = "2"
        ElseIf OptNinguna.Checked Then
            Cual = "3"
        Else
            Cual = "4" 'cruzar
        End If
        SaveSetting(DiegoSet, "opcimprimir", DMSNombreForma, Cual)

    End Sub

    'Private Sub ChkCruzar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCruzar.CheckedChanged
    '    SaveSetting(DiegoSet, "opccruzar", DMSNombreForma, IIf(ChkCruzar.Checked, "1", "0"))

    'End Sub

End Class
