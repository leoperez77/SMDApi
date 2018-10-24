'♥ versión: 586, 6-oct.-2017 07:11
Public Class AdvanceNuevaForm
    Private m_WindowState As FormWindowState = FormWindowState.Normal
    Private m_FormSizeAndLocation As Rectangle = Rectangle.Empty
    Private m_MousePressed As Boolean = False
    Private m_oldX As Integer, m_oldY As Integer


    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim crtparam As CreateParams = MyBase.CreateParams
            crtparam.Style = crtparam.Style And Not &HC00000
            Return crtparam
        End Get
    End Property


    'Property DMSUsaF5() As Boolean
    '    Get
    '        Return _UsaF5
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _UsaF5 = value
    '        If _UsaF5 Then
    '            CmdActualizar.Text &= " F5"
    '        Else
    '            CmdActualizar.Text = CmdActualizar.Text.Replace(" F5", "")
    '        End If
    '    End Set
    'End Property

#Region "Movimiento de la forma"


    Private Sub JDMS_Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles JDMS_Panel1.MouseMove, JDMS_Titulo.MouseMove

        If m_MousePressed = True AndAlso m_WindowState <> FormWindowState.Maximized Then
            Dim TS As Point = Me.PointToScreen(e.Location)

            Me.Location = New Point(Me.Location.X + (TS.X - m_oldX), Me.Location.Y + (TS.Y - m_oldY))
            m_oldX = TS.X
            m_oldY = TS.Y
        End If
    End Sub



    Private Sub JDMS_Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles JDMS_Panel1.MouseDown, JDMS_Titulo.MouseDown
        Dim TS As Point = Me.PointToScreen(e.Location)
        m_oldX = TS.X
        m_oldY = TS.Y
        m_MousePressed = True
    End Sub

    Private Sub JDMS_Panel1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles JDMS_Panel1.MouseUp, JDMS_Titulo.MouseUp
        m_MousePressed = False
    End Sub

    Private Sub JDMS_CerrarForma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JDMS_CerrarForma.Click
        Me.Close()

    End Sub

    Private Sub JDMS_CmdMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JDMS_CmdMaximizar.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            Me.JDMS_CmdMaximizar.Text = "◘"
        Else
            Me.WindowState = FormWindowState.Normal
            Me.JDMS_CmdMaximizar.Text = "□"
        End If
    End Sub

    Private Sub JDMS_CmdMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JDMS_CmdMinimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub JDMS_Panel1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JDMS_Panel1.DoubleClick, JDMS_Titulo.DoubleClick
        If Not JDMS_CmdMaximizar.Visible Then
            Exit Sub
        End If
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal

        End If
    End Sub


#End Region

    Private Sub AdvanceNuevaForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        JDMS_Panel1.BackColor = Color.SkyBlue
        'Me.Opacity = 1

    End Sub


    Private Sub AdvanceNuevaForm_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        JDMS_Panel1.BackColor = Color.Gray
        'Me.Opacity = 0.8

    End Sub

    Private Sub AdvanceNuevaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.JDMS_Icono.Image = Me.Icon.ToBitmap
        Me.JDMS_Titulo.Text = Me.Text
        'Me.JDMS_CerrarForma.Visible = Me.ControlBox 'no se puede pues siempre está en False
        Me.JDMS_CmdMaximizar.Visible = Me.MaximizeBox
        Me.JDMS_CmdMinimizar.Visible = Me.MinimizeBox

    End Sub

    Private Sub JDMS_Icono_Click(sender As Object, e As EventArgs) Handles JDMS_Icono.Click
        'If fAdvNewOpc Is Nothing Then
        '    fAdvNewOpc = New AdvanceNuevaForm_opc
        'End If

        'fAdvNewOpc.fOrig = Me
        'fAdvNewOpc.Show()


    End Sub
  

End Class
