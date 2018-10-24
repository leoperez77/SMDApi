'♥ versión: 586, 6-oct.-2017 07:11
Public Class fSplash
    Public SoyElMenu As Boolean = False

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'EstoyEnSplash = True

        Timer1.Tag += 1 'una decima de segundo más

        Me.TopMost = True

        If SoyElMenu Then
            If LblApl.Text = "..." Then 'no ha puesto el titulo aun
                LblApl.Text = GetSetting("DMS S.A.", "fC", "splt", "Advance")
                HagaEventos()
            End If
            If GetSetting("DMS S.A.", "fC", "spl", "0") = "1" Then 'si ya arrancó el módulo
                'Me.Hide()
                Ocultar()
                Exit Sub
            End If
        End If

        If Timer1.Tag > 400 Then 'cerrarlo a los 40 segundos, por si se quedó pegado
            Ocultar()
            Exit Sub
        End If

    End Sub



    Private Sub fSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'EstoyEnSplash = True
        'LblApl.Text = My.Application.Info.Title
        Me.FormBorderStyle = FormBorderStyle.None
        Me.TransparencyKey = System.Drawing.Color.FromArgb(121, 121, 121)

        'PicAplicacion.Tag = PicAplicacion.Image

        Ponga_Lite()

    End Sub
    Public Sub Ponga_Lite()
        Try
            If SoyAdvanceLite() Then
                LblLite.Visible = True
                'PicAplicacion.Image = LblLite.Image
            Else
                LblLite.Visible = False
                'PicAplicacion.Image = PicAplicacion.Tag
            End If

        Catch

        End Try

    End Sub
    'Public Sub CambiarTamaño()
    '    Try

    '        PicAplicacion.Visible = True
    '        LogoSMD.Visible = True
    '        Me.Size = PicAplicacion.Size
    '        'LblApl.Location = New Point(1, 59)
    '        'LblApl.BackColor = Color.White
    '        'LblApl.Size = New Point(178, 20)
    '        'LblApl.Font = Label2.Font
    '        'LblApl.BringToFront()

    '        LblApl.Visible = False

    '        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    '        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
    '    Catch ex As Exception
    '    End Try

    'End Sub
    Private Sub Ocultar()
        'EstoyEnSplash = False


        Timer1.Stop()
        Cierre_Ventana(Me, True)

    End Sub

    Private Sub LogoSMD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoSMD.Click, LnkOcultar.LinkClicked
        If ValD(Me.Tag) = -1 Then Exit Sub

        'Me.Hide()
        Ocultar()

    End Sub

    Private Sub LogoSMD_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Ocultar()

    End Sub
End Class