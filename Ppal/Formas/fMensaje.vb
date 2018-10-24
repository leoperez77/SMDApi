' Version: 695, 4-oct.-2018 12:56
' Version: 684, 25-ago.-2018 20:17
' Version: 683, 23-ago.-2018 12:40
' Version: 678, 16-ago.-2018 14:15
' Version: 675, 14-ago.-2018 18:45
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fMensaje
    Public GuardarSI_NombreForma As String = ""
    Public GuardarNO_NombreForma As String = ""
    'Dim QuiteReloj As Boolean = False
    Public CodigoPrograma As Integer = 0
    Public NumeroPermiso As Integer = 0

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click
        If ChkNoVolver.Checked And GuardarSI_NombreForma <> "" Then
            SaveSetting("DMS S.A. Preg", Usuario.ToString, Serializar_Texto(GuardarSI_NombreForma, GuardarNO_NombreForma, Txt.Text), "1")
        End If

        Me.Tag = ""
        Cerrar()

    End Sub
    Private Sub Cerrar()
        'If QuiteReloj Then
        '    fRelojito.Show()
        '    HagaEventos()
        'End If
        Me.Close()

    End Sub
    'Private Sub fMensaje_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    '    If PnlSiNo.Visible Then
    '        CmdSi.Focus()
    '    Else
    '        CmdAceptar.Focus()
    '    End If
    'End Sub
    Private Sub HandHeld()
        Me.Location = New Point(0, 0)
        'PnlNormal.Anchor = AnchorStyles.Left + AnchorStyles.Top
        'PnlSiNo.Anchor = AnchorStyles.Left + AnchorStyles.Top
        'PnlRespCompleja.Anchor = AnchorStyles.Left + AnchorStyles.Top
        LblComplemento.Visible = False

        Me.MinimumSize = New Size(0, 0)
        CmdSi.Size = New Size(53, 28)
        CmdSi.Location = New Point(9, 12)

        CmdNo.Size = New Size(53, 28)
        CmdNo.Location = New Point(73, 12)

        CmdCancelar.Size = New Size(61, 28)
        CmdCancelar.Location = New Point(142, 12)

        TxtResp.Location = New Point(51, 18)


        LnkAutorizacion.Location = New Point(4, 14)
        LnkAutorizacion.Text = "Autoriz"

        LnkEnviar.Location = New Point(51, 14)
        LnkEnviar.Text = "e/DMS"

        PnlSiNo.Height = 54
        PnlSiNo.Width = Me.Width
        PnlSiNo.Left = 0
        PnlSiNo.Top = Me.Height - PnlSiNo.Height - 60
        PnlSiNo.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right
        PnlNormal.Location = PnlSiNo.Location
        PnlNormal.Size = PnlSiNo.Size
        PnlNormal.Anchor = PnlSiNo.Anchor
        PnlRespCompleja.Location = PnlSiNo.Location
        PnlRespCompleja.Size = PnlSiNo.Size
        PnlRespCompleja.Anchor = PnlSiNo.Anchor

        CmdAcepResp.Left = 136
        CmdAceptar.Left = 136

        Txt.Location = New Point(0, 0)
        Txt.Height = Me.Height - PnlSiNo.Height - 70
        Txt.Width = Me.Width
        Txt.Font = ChkNoVolver.Font
        Txt.BorderStyle = BorderStyle.FixedSingle
        Txt.Anchor = AnchorStyles.Left + AnchorStyles.Top + AnchorStyles.Right + AnchorStyles.Bottom

        Me.FormBorderStyle = Forms.FormBorderStyle.FixedToolWindow
        Me.WindowState = FormWindowState.Maximized


    End Sub
    Private Sub fMensaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		If LenguajeAdvance = 1 Then
			CmdSi.Text = "Yes" & EsIngles()
			CmdCancelar.Text = "Cancel" & EsIngles()
			CmdAcepResp.Text = "Accept" & EsIngles()
			CmdAceptar.Text = "Accept" & EsIngles()
			LnkAutorizacion.Text = "Request authorization" & EsIngles()
			ChkNoVolver.Text = "Do not ask again" & EsIngles()
		End If

		PictureBox2.Size = PictureBox1.Size
		PictureBox2.Location = PictureBox1.Location

        If SoyHandHeld() Then
            HandHeld()
        End If

        'Try
        '    QuiteReloj = False
        '    If fRelojito.Visible Then
        '        fRelojito.Hide()
        '        QuiteReloj = True
        '    End If
        'Catch ex As Exception

        'End Try


        If PictureBox2.Image Is Nothing Then
            AsignarImagenPrograma(PictureBox2, 6)
        End If
        If PictureBox1.Image Is Nothing Then
            AsignarImagenPrograma(PictureBox1, 7)
        End If

        Me.Tag = ""
        LblComplemento.Text = InformacionComplemetariaAplicacion & " (" & Strings.Format(Now, "yyMMdd HH:mm") & ")"

        'If Len(Txt.Text) < 300 Then
        '    LblTex.Location = Txt.Location
        '    LblTex.Size = Txt.Size
        '    LblTex.Text = Txt.Text
        '    LblTex.Visible = True
        '    Txt.Visible = False
        'End If
    End Sub


    Private Sub LnkEnviar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkEnviar.LinkClicked
		'If Not Pregunte("Seguro de enviar este mensaje a DMS?") Then Exit Sub

		Me.Tag = ""

        Dim TexErr As String = LblComplemento.Text & DMScr() & Txt.Text
        'Mensajeria_DMS(2, TexErr, Usuario)

        'Ejecutar("PutError2 " & Usuario.ToString & ",'" & SinComillas(Strings.Left(TexErr, 450)) & "',1")
        Dim Ds As New DataSet
        Dim CU As Integer = 1
        If MarcaExterna = "col" Then
            CU = Usuario
        End If
        Abrir_Nodo_1(Ds, "PutError3 '" & SinComillas(Strings.Left(TexErr, 450)) & "',1," & CU.ToString)

        Cerrar()

    End Sub
    Private Sub CmdSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSi.Click
        Me.Tag = "SI"

        If ChkNoVolver.Checked And GuardarSI_NombreForma <> "" Then
            SaveSetting("DMS S.A. Preg", Usuario.ToString, Serializar_Texto(GuardarSI_NombreForma, GuardarSI_NombreForma, Txt.Text), Me.Tag)
        End If

        Cerrar()

    End Sub

    Private Sub CmdNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNo.Click
        Me.Tag = "NO"

        If ChkNoVolver.Checked And GuardarNO_NombreForma <> "" Then
            SaveSetting("DMS S.A. Preg", Usuario.ToString, Serializar_Texto(GuardarNO_NombreForma, GuardarNO_NombreForma, Txt.Text), Me.Tag)
        End If

        Cerrar()

    End Sub

    Private Sub fMensaje_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If PnlSiNo.Visible Then
			If e.KeyCode = Keys.S Or e.KeyCode = Keys.Y Then
				e.SuppressKeyPress = True
				CmdSi_Click(CmdSi, New EventArgs)
			ElseIf e.KeyCode = Keys.N Then
				e.SuppressKeyPress = True
                CmdNo_Click(CmdNo, New EventArgs)
            End If
        ElseIf PnlRespCompleja.Visible = False Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape Then
                e.SuppressKeyPress = True
                CmdAceptar_Click(CmdAceptar, New EventArgs)
                Exit Sub
            End If
        End If

    End Sub

    Private Sub fMensaje_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If PnlSiNo.Visible Then
            CmdSi.Focus()
        ElseIf PnlRespCompleja.Visible Then
            TxtResp.Focus()
        Else
            CmdAceptar.Focus()
        End If

    End Sub

    'Private Sub LblTex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTex.Click
    '    LblTex.Visible = False
    '    Txt.Visible = True

    'End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.Tag = "CA"
        Cerrar()

    End Sub

    Private Sub Txt_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles Txt.LinkClicked
        AbrirLink(e.LinkText)

    End Sub

    Private Sub LnkAutorizacion_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkAutorizacion.LinkClicked
        Me.TopMost = False

        Dim fAu As New fAutorizacionElectronica
        fAu.CodigoPrograma = CodigoPrograma
        fAu.NumeroPermiso = NumeroPermiso
        fAu.TextoMensaje = Txt.Text
        fAu.ShowDialog()

        If fAu.Tag = "S" Then
            Me.Tag = "S"
            Me.Close()
        End If

    End Sub

    Private Sub CmdAcepResp_Click(sender As System.Object, e As System.EventArgs) Handles CmdAcepResp.Click
        If ValD(TxtResp.Text) = CmdAcepResp.Tag Then 'si
            Me.Tag = "SI"

            If ChkNoVolver.Checked And GuardarSI_NombreForma <> "" Then
                SaveSetting("DMS S.A. Preg", Usuario.ToString, Serializar_Texto(GuardarSI_NombreForma, GuardarSI_NombreForma, Txt.Text), Me.Tag)
            End If

            Cerrar()

        ElseIf ValD(TxtResp.Text) = TxtResp.Tag Then 'no
            Me.Tag = "NO"

            If ChkNoVolver.Checked And GuardarNO_NombreForma <> "" Then
                SaveSetting("DMS S.A. Preg", Usuario.ToString, Serializar_Texto(GuardarNO_NombreForma, GuardarNO_NombreForma, Txt.Text), Me.Tag)
            End If

            Cerrar()
        Else
			MsgBox(Idi("Lea el texto y responda según las instrucciones"), MsgBoxStyle.Critical)
			TxtResp.Text = ""
            TxtResp.Focus()
        End If
    End Sub

    Private Sub LblSemaforo_Click(sender As Object, e As EventArgs) Handles LblSemaforo.Click
        Me.TopMost = False
        'Me.ShowInTaskbar = True
        LblSemaforo.Visible = False
        SonarWAV("laser")

    End Sub
End Class