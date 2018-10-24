' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
'♥ versión: 588, 12-oct.-2017 17:24
'♥ versión: 586, 6-oct.-2017 07:11
Public Class AdvanceForm

	'Dim _UsaLogo As Boolean = False
	'Dim _Tamaño As Short = 2
	'Public JDMS_Ya_Hizo_Idioma As Boolean = False

	Private Sub AdvanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  
        'DebugJD("entró load de " & Me.Text)

        'UsarLogoSobrepuesto = GetSetting("DMS S.A.", "fC", "ptoadvflota", "1") = "1"


        PicPuntoAdv.Visible = GetSetting("DMS S.A.", "fC", "ptoadvfl", "0") <> "1"
        UbiLogo = GetSetting("DMS S.A.", "fC", "ptoadv", "1")

		'If UsarLogoSobrepuesto Then
		'    PicPuntoAdv.Visible = False
		'    Marquelo()
		'Else
		'    UbiLogo = GetSetting("DMS S.A.", "fC", "ptoadv", "0")
		'End If

		'agrandarlo solo para el menu ppal
		If Me.Name = "fMenu" Then
			'PicPuntoAdv.Width *= 1.7
			'PicPuntoAdv.Height *= 1.7
			PicPuntoAdv.Visible = False
		Else
			Recorrer_Controles_Idioma(Me, Me)
		End If
	End Sub

    'Private Sub AdvanceForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    Marquelo()

    'End Sub


    'Private Sub Marquelo()
    '    Try
    '        If UsarLogoSobrepuesto Then
    '            AdvFormaActiva = Me
    '            'SaveSetting("DMS S.A.", "fC", "act_name", My.Application.Info.AssemblyName)
    '            SaveSetting("DMS S.A.", "fC", "act_name", My.Application.Info.AssemblyName & "/" & MarcaExterna & "/" & MiEmpresa & "/" & MiCodigo & "/" & Strings.Left(Me.Text, 20).Replace("/", " "))
    '            'SaveSetting("DMS S.A.", "fC", "act_meta", MarcaExterna & "/" & MiEmpresa & "/" & MiCodigo & "/" & Strings.Left(Me.Text, 15).Replace("/", " "))
    '        End If

    '    Catch ex As Exception

    '    End Try


    'End Sub


    Private Sub AdvanceForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'Try
        '    If UsarLogoSobrepuesto Then
        '    Else
        '        PicPuntoAdv.BringToFront()
        '        Ubicar_Loguito()
        '    End If

        '    Marquelo()

        'Catch
        'End Try
        Try
            PicPuntoAdv.BringToFront()
            Ubicar_Loguito()
            
        Catch
        End Try

    End Sub

    Private Sub AdvanceForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F10 And e.Shift Then
            SonarWAV("laser")
            Cambiar_Loguito()
            e.SuppressKeyPress = True 'solo en esta tecla evitar que pase al otro programa 
        ElseIf e.KeyCode = Keys.F11 And e.Shift = False And e.Control = False Then
            Abrir_Opc() 'se abre sin efectos visuales
        End If

    End Sub
    Private Sub Ubicar_Loguito()
        If UbiLogo = "0" Then
            PicPuntoAdv.Left = 0
            PicPuntoAdv.Top = Me.Height - PicPuntoAdv.Height - 40
            PicPuntoAdv.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
        Else
            PicPuntoAdv.Left = Me.Width - PicPuntoAdv.Width - 15
            PicPuntoAdv.Top = 0
            PicPuntoAdv.Anchor = AnchorStyles.Top + AnchorStyles.Right
        End If
        PicPuntoAdv.BringToFront()


    End Sub

    Public Sub Cambiar_Loguito()
        If UbiLogo = "1" Then
            SaveSetting("DMS S.A.", "fC", "ptoadv", "0")
            UbiLogo = "0"
        Else
            SaveSetting("DMS S.A.", "fC", "ptoadv", "1")
            UbiLogo = "1"
        End If
        Ubicar_Loguito()

    End Sub




    Private Sub PicPuntoAdv_Click(sender As Object, e As EventArgs) Handles PicPuntoAdv.Click

        'Posicion_Logo_Advance()


        Abrir_Opc()


    End Sub

    Public Sub Abrir_Opc()
        Ubicar_Loguito() 'programas como citas no lo ubican bien al principio
        Abrir_Punto_Advance(Me)
        Exit Sub

    End Sub




    Private Sub PicPuntoAdv_Paint(sender As Object, e As PaintEventArgs) Handles PicPuntoAdv.Paint
        Redondear_Foto(sender, 30)

    End Sub
End Class