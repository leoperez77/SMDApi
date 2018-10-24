'♥ versión: 586, 6-oct.-2017 07:11
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D

Public Class fPadre
    Dim PantNormal As Image
    Dim nodoble As Boolean = False
    Dim _colorDefault As Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(201, Byte), Integer))
    Dim _colorFuera As Color = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))


    Private _IsLoad As Boolean
    Public Property IsLoad() As Boolean
        Get
            Return _IsLoad
        End Get
        Set(ByVal value As Boolean)
            _IsLoad = value
        End Set
    End Property

    Private _down As Boolean
    Public Property down() As Boolean
        Get
            Return _down
        End Get
        Set(ByVal value As Boolean)
            _down = value
            If Not value Then
                resizeDir = ResizeDirection.None
            End If
        End Set
    End Property


    Private _Cerrar As Boolean
    Public Property Cerrar() As Boolean
        Get
            Return _Cerrar
        End Get
        Set(ByVal value As Boolean)
            _Cerrar = value
            If Not IsLoad Then
                Try
                    MyBase.Close()
                Catch
                End Try
            End If
        End Set
    End Property

    Private _FormBorderStyle As FormBorderStyle = MyBase.FormBorderStyle
    Public Shadows Property FormBorderStyle() As System.Windows.Forms.FormBorderStyle
        Get
            Return _FormBorderStyle
        End Get
        Set(ByVal value As System.Windows.Forms.FormBorderStyle)
            MyBase.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            If value <> Windows.Forms.FormBorderStyle.None Then
                _FormBorderStyle = value
            End If
        End Set
    End Property


    <DllImportAttribute("user32.dll")> _
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click ', Icono.DoubleClick
        Me.Close()
    End Sub

    Private Sub cmdMin_Click(sender As Object, e As EventArgs) Handles cmdMin.Click
        If Me.WindowState <> FormWindowState.Maximized Then
            _cliNormal = MyBase.Size
        End If
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub CmdMax_Click(sender As Object, e As EventArgs) Handles CmdMax.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            CmdMax.Image = PantNormal
        Else
            _cliNormal = MyBase.Size
            Me.WindowState = FormWindowState.Maximized
            CmdMax.Image = Global.SMDPpal.My.Resources.maximizada1
        End If
    End Sub

    'Public Shadows Property WindowState() As System.Windows.Forms.FormWindowState
    '    Get
    '        Return MyBase.WindowState
    '    End Get
    '    Set(ByVal value As System.Windows.Forms.FormWindowState)
    '        If value = FormWindowState.Maximized Then
    '            MyBase.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    '            MyBase.WindowState = value
    '            MyBase.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    '        Else
    '            MyBase.WindowState = value

    '        End If
    '    End Set
    'End Property
    'Private Sub CmdMax_Click(sender As Object, e As EventArgs) Handles CmdMax.Click
    '    If Me.WindowState = FormWindowState.Maximized Then
    '        Me.WindowState = FormWindowState.Normal
    '        CmdMax.Image = PantNormal
    '    Else
    '        _cliNormal = MyBase.Size
    '        Me.WindowState = FormWindowState.Maximized
    '        'CmdMax.Image = Global.SMDPpal.My.Resources.maximizada1
    '    End If
    'End Sub

    Dim _cli As New Size()
    Dim _cliNormal As New Size()
    Public Shadows Property WindowState() As System.Windows.Forms.FormWindowState
        Get
            Return MyBase.WindowState
        End Get
        Set(ByVal value As System.Windows.Forms.FormWindowState)
            If value = FormWindowState.Maximized Then
                MyBase.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

                MyBase.WindowState = value
                FormBorderStyle = Windows.Forms.FormBorderStyle.None
                If _cli.Height = 0 Then
                    _cli = MyBase.ClientSize
                    _cli.Width -= (Izq.Size.Width + der.Size.Width)
                    _cli.Height -= (aba.Size.Height + arr.Size.Height)
                End If
                If MaximumSize.Height = 0 And MaximumSize.Width = 0 Then
                    MaximumSize = _cli
                End If
            Else

                MyBase.Size = _cliNormal
                MyBase.WindowState = value
            End If
        End Set
    End Property


    Public Shadows Property MinimizeBox() As Boolean
        Get
            Return Me.cmdMin.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.cmdMin.Visible = value

        End Set
    End Property

    Public Shadows Property MaximizeBox() As Boolean
        Get
            Return Me.CmdMax.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.CmdMax.Visible = value

        End Set
    End Property
    Public Overrides Property Text() As String
        Get
            If lblTitulo IsNot Nothing Then
                Return lblTitulo.Text
            Else
                Return ""
            End If
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            lblTitulo.Text = value
            lblTitulo.Tag = value

        End Set
    End Property

    Public Sub QuitarCargando()
        If Cerrar Then
            Me.Close()
        End If
        IsLoad = False
        Panel1.Visible = False
    End Sub


    Private Const BorderWidth As Integer = 6
    Private _resizeDir As ResizeDirection = ResizeDirection.None

    Public Enum ResizeDirection
        None = 0
        Left = 1
        TopLeft = 2
        Top = 3
        TopRight = 4
        Right = 5
        BottomRight = 6
        Bottom = 7
        BottomLeft = 8
    End Enum

    Public Property resizeDir() As ResizeDirection

        Get
            If Me.Name = "°fMenu_Icon" Then Exit Property
            If _FormBorderStyle <> Windows.Forms.FormBorderStyle.Sizable And _FormBorderStyle <> Windows.Forms.FormBorderStyle.SizableToolWindow Then
                Return ResizeDirection.None
            End If
            Return _resizeDir
        End Get

        Set(ByVal value As ResizeDirection)
            If Me.Name = "°fMenu_Icon" Then Exit Property

            If down Then Exit Property

            _resizeDir = value

            If _FormBorderStyle <> Windows.Forms.FormBorderStyle.Sizable And _FormBorderStyle <> Windows.Forms.FormBorderStyle.SizableToolWindow Then
                value = ResizeDirection.None
            End If
            'Change cursor

            Select Case value
                Case ResizeDirection.Left
                    Me.Cursor = Cursors.SizeWE

                Case ResizeDirection.Right
                    Me.Cursor = Cursors.SizeWE

                Case ResizeDirection.Top
                    Me.Cursor = Cursors.SizeNS

                Case ResizeDirection.Bottom
                    Me.Cursor = Cursors.SizeNS

                Case ResizeDirection.BottomLeft
                    Me.Cursor = Cursors.SizeNESW

                Case ResizeDirection.TopRight
                    Me.Cursor = Cursors.SizeNESW

                Case ResizeDirection.BottomRight
                    Me.Cursor = Cursors.SizeNWSE

                Case ResizeDirection.TopLeft
                    Me.Cursor = Cursors.SizeNWSE

                Case Else
                    Me.Cursor = Cursors.Default
            End Select


        End Set
    End Property



    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTBORDER As Integer = 18
    Private Const HTBOTTOM As Integer = 15
    Private Const HTBOTTOMLEFT As Integer = 16
    Private Const HTBOTTOMRIGHT As Integer = 17
    Private Const HTCAPTION As Integer = 2
    Private Const HTLEFT As Integer = 10
    Private Const HTRIGHT As Integer = 11
    Private Const HTTOP As Integer = 12
    Private Const HTTOPLEFT As Integer = 13
    Private Const HTTOPRIGHT As Integer = 14



#Region " Moving & Resizing methods "

    Private Sub MoveForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub ResizeForm(ByVal direction As ResizeDirection)
        down = True
        Dim dir As Integer = -1
        Select Case direction
            Case ResizeDirection.Left
                dir = HTLEFT
            Case ResizeDirection.TopLeft
                dir = HTTOPLEFT
            Case ResizeDirection.Top
                dir = HTTOP
            Case ResizeDirection.TopRight
                dir = HTTOPRIGHT
            Case ResizeDirection.Right
                dir = HTRIGHT
            Case ResizeDirection.BottomRight
                dir = HTBOTTOMRIGHT
            Case ResizeDirection.Bottom
                dir = HTBOTTOM
            Case ResizeDirection.BottomLeft
                dir = HTBOTTOMLEFT
        End Select

        If dir <> -1 Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, dir, 0)
        End If
        down = False
    End Sub

#End Region

    Private Sub der_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles der.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And Me.WindowState <> FormWindowState.Maximized Then
            ResizeForm(resizeDir)
        End If
    End Sub

    Private Sub der_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles der.MouseMove
        If e.X <= 5 And e.X >= 0 And e.Y <= 5 And e.Y >= 0 Then
            resizeDir = ResizeDirection.TopRight
        Else
            resizeDir = ResizeDirection.Right
        End If

    End Sub


    Private Sub ToolStrip_MouseDown(sender As Object, e As MouseEventArgs) Handles ToolStrip.MouseDown, Panel2.MouseDown, lblTitulo.MouseDown, Icono.MouseDown, Pnldegradado.MouseDown, Logo.MouseDown
        If e.Clicks = 1 And e.Button = Windows.Forms.MouseButtons.Left And Me.WindowState <> FormWindowState.Maximized Then
            MoveForm()
        End If

    End Sub
    Private Sub ToolStrip_MouseMove(sender As Object, e As MouseEventArgs) Handles ToolStrip.MouseMove, lblTitulo.MouseDown, Panel2.MouseMove, Icono.MouseMove, Pnldegradado.MouseMove, Logo.MouseMove
        resizeDir = ResizeDirection.None
    End Sub

    Private Sub aba_MouseDown(sender As Object, e As MouseEventArgs) Handles aba.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And Me.WindowState <> FormWindowState.Maximized Then
            ResizeForm(resizeDir)
        End If
    End Sub

    Private Sub aba_MouseMove(sender As Object, e As MouseEventArgs) Handles aba.MouseMove
        If e.X <= 5 And e.X >= 0 And e.Y <= 5 And e.Y >= 0 Then
            resizeDir = ResizeDirection.BottomLeft
        ElseIf e.X <= aba.Size.Width And e.X >= aba.Size.Width - 5 And e.Y <= 5 And e.Y >= 0 Then
            resizeDir = ResizeDirection.BottomRight
        Else
            resizeDir = ResizeDirection.Bottom
        End If

    End Sub

    Private Sub Izq_MouseDown(sender As Object, e As MouseEventArgs) Handles Izq.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And Me.WindowState <> FormWindowState.Maximized Then
            ResizeForm(resizeDir)
        End If
    End Sub

    Private Sub Izq_MouseMove(sender As Object, e As MouseEventArgs) Handles Izq.MouseMove
        If e.X <= 5 And e.X >= 0 And e.Y <= 5 And e.Y >= 0 Then
            resizeDir = ResizeDirection.TopLeft
        Else
            resizeDir = ResizeDirection.Left
        End If

    End Sub

    Private Sub arr_MouseDown(sender As Object, e As MouseEventArgs) Handles arr.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left And Me.WindowState <> FormWindowState.Maximized Then
            ResizeForm(resizeDir)
        End If
    End Sub

    Private Sub arr_MouseMove(sender As Object, e As MouseEventArgs) Handles arr.MouseMove
        resizeDir = ResizeDirection.Top
    End Sub


    'New Size(_si.Width + frm.Izq.Size.Width + frm.der.Size.Width, _si.Height + frm.ToolStrip.Size.Height + frm.aba.Size.Height)
    Private _Size As Size = MyBase.Size
    Public Shadows Property Size() As Size
        Get
            Return _Size
        End Get
        Set(ByVal value As Size)
            _Size = New Size(value.Width + Izq.Size.Width + der.Size.Width, value.Height + ToolStrip.Size.Height + aba.Size.Height + arr.Size.Height)
            MyBase.Size = _Size
        End Set
    End Property

    Private _MinimumSize As Size = MyBase.MinimumSize
    Public Shadows Property MinimumSize() As Size
        Get
            Return _MinimumSize
        End Get
        Set(ByVal value As Size)
            If value.Height = 0 And value.Width = 0 Then
                _MinimumSize = New Size(50, 10)
            Else
                _MinimumSize = New Size(value.Width + Izq.Size.Width + der.Size.Width + 5, value.Height + ToolStrip.Size.Height + aba.Size.Height + arr.Size.Height + 5)

            End If
            MyBase.MinimumSize = _MinimumSize

        End Set
    End Property

    Private _MaximumSize As Size = MyBase.MaximumSize
    Public Shadows Property MaximumSize() As Size
        Get
            Return _MaximumSize
        End Get
        Set(ByVal value As Size)
            If value.Height = 0 And value.Width = 0 Then
                _MaximumSize = value
            Else
                _MaximumSize = New Size(value.Width + Izq.Size.Width + der.Size.Width + 5, value.Height + ToolStrip.Size.Height + aba.Size.Height + arr.Size.Height + 5)
            End If
            MyBase.MaximumSize = _MaximumSize

        End Set
    End Property

    Private Sub ToolStrip_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ToolStrip.MouseDoubleClick, Panel2.MouseDoubleClick, lblTitulo.MouseDoubleClick, Icono.MouseDoubleClick, Pnldegradado.MouseDoubleClick, Logo.MouseDoubleClick
        If nodoble Then
            nodoble = False
            Exit Sub
        End If
        If e.Button = Windows.Forms.MouseButtons.Left And Me.CmdMax.Visible Then
            CmdMax_Click(CmdMax, New EventArgs)
        End If
    End Sub

    Private Sub _MouseLeave(sender As Object, e As EventArgs) Handles Izq.MouseLeave, der.MouseLeave, arr.MouseLeave, aba.MouseLeave
        resizeDir = ResizeDirection.None
    End Sub


    Private Sub fPadre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Logo.ImageLocation = Path_Temp & NombreArchivoLogoSMD
        PantNormal = CmdMax.Image

    End Sub
    Dim bgGradient As LinearGradientBrush
    Dim totalRect As Rectangle


    Private Sub Pnldegradado_Paint(sender As Object, e As PaintEventArgs) Handles Pnldegradado.Paint

        'totalRect = New Rectangle(0, 0, Me.Width, Me.Height)
        'Dim _col As Color = _colorDefault
        'bgGradient = New LinearGradientBrush(totalRect, _col, Color.White, LinearGradientMode.Horizontal, True)
        'e.Graphics.FillRectangle(bgGradient, totalRect)

    End Sub

    Private Sub fPadre_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Activar(True)
        If boton IsNot Nothing Then
            boton.PerformClick()
        End If

        'If Me.WindowState <> FormWindowState.Minimized Then 'And Me.Focused Then
        '    Me.WindowState = FormWindowState.Minimized
        'End If

        'Try
        '    If Me.IsMdiContainer Then
        '        Me.MdiChildren(0).Visible = False
        '        Me.MdiChildren(0).Visible = True
        '        Me.MdiChildren(0).Activate()
        '    End If

        'Catch ex As Exception
        '    Me.MdiChildren(0).Visible = True

        'End Try
    End Sub

    Private Sub fPadre_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Activar(False)
    End Sub


    Private Sub Activar(_que As Boolean)
        Dim _col As Color
        If Me.Name = "°fMenu_Icon" Then
            Me.TopMost = True

            If EstaEnLista(EstadoActual, 2, 5, 6) Then
                _col = Color.Red
            Else
                _col = _colorDefault
            End If
        Else
            _col = IIf(_que, _colorDefault, _colorFuera)
        End If


        arr.BackColor = _col
        aba.BackColor = _col
        der.BackColor = _col
        Izq.BackColor = _col
        Pnldegradado.BackColor = _col
        Panel2.BackColor = _col
        lblTitulo.BackColor = _col
        ToolStrip.BackColor = _col
        Logo.BackColor = _col
        Icono.BackColor = _col

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel1.Visible = False

    End Sub

    Private _boton As ToolStripButton = Nothing
    Public Property boton() As ToolStripButton
        Get
            Return _boton
        End Get
        Set(ByVal value As ToolStripButton)
            _boton = value
        End Set
    End Property


    Private Sub cmdCerrar_MouseEnter(sender As Object, e As EventArgs) Handles cmdCerrar.MouseEnter, CmdMax.MouseEnter, cmdMin.MouseEnter
        boton = DirectCast(sender, ToolStripButton)


    End Sub
    Private Sub Icono_MouseEnter(sender As Object, e As EventArgs) Handles Icono.MouseEnter
        lblTitulo.Text = Parta()


    End Sub
    Private Function Parta() As String
        Try
            Dim Tx() As String = Icono.Tag.ToString.Split(",")
            'Return "[Usu: " & Tx(0) & "]   [Emp: " & Tx(1) & "]   [Vers: " & Tx(2) & "]   [Nodo: " & Tx(3) & "]"
            Return Tx(0) & "," & Tx(1) & "," & Tx(2) & "," & Tx(3)

        Catch
            Return ("No datos")
        End Try


    End Function
    Private Sub Icono_MouseLeave(sender As Object, e As EventArgs) Handles Icono.MouseLeave
        lblTitulo.Text = lblTitulo.Tag

    End Sub
    Private Sub cmdCerrar_MouseLeave(sender As Object, e As EventArgs) Handles cmdCerrar.MouseLeave, CmdMax.MouseLeave, cmdMin.MouseLeave
        boton = Nothing
    End Sub

    'p.StartFigure()
    '    p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
    '    p.AddLine(40, 0, Me.Width - 40, 0)
    '    p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
    '    p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
    '    p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
    '    p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
    '    p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
    '    p.CloseFigure()


    Dim rectan As Integer = 20
    Dim quitar As Integer = 7

    Private Sub fPadre_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Pintar()
    End Sub
    Private Sub Pintar()
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, quitar, rectan, rectan), 180, 90)

        p.AddLine(rectan, quitar, 17, quitar)
        p.AddLine(22, quitar, rectan + 42, 0)
        p.AddLine(rectan + 42, 0, rectan + 36, quitar)



        p.AddLine(rectan, quitar, Me.Width - rectan, quitar)
        p.AddArc(New Rectangle(Me.Width - rectan, quitar, rectan, rectan), -90, 90)
        p.AddLine(Me.Width, Me.Height - 5, Me.Width, Me.Height)
        p.AddLine(Me.Width, Me.Height, 0, Me.Height)
        p.AddLine(0, Me.Height, 0, rectan)
        p.CloseFigure()
        Me.Region = New Region(p)



    End Sub
    Private Sub fPadre_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Pintar()
    End Sub


    Private Sub Icono_DoubleClick(sender As Object, e As EventArgs) Handles Icono.DoubleClick


        Me.Close()

        nodoble = True

    End Sub

    Private Sub Logo_DoubleClick(sender As Object, e As EventArgs) Handles Logo.DoubleClick
        nodoble = True

        Shell(Path_Prog & "\" & "SMDMenu.exe")

    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked
        If e.ClickedItem IsNot CmdAyuda Then
            Exit Sub
            'Mensaje("Video o ayuda: " & Trim(Mid(lblTitulo.Text, 1, 5)))
        End If

        Dim EsReporte As Boolean = Application.ProductName = "reportes"

        If Me.Name = "°fLogin" Or Me.Name = "°fMenu" Then
            Mostrar_Ayuda(Me, "0000")
            Exit Sub
        End If

        Dim Que As String = ""
        If EsReporte Then
            Que = InputBoxDMS("Opciones de Ayuda", "Seleccione una opción:", True, 1, New Object() {New Object() {"1", "Video", "2", "Manual"}})
        Else
            Que = InputBoxDMS("Opciones de Ayuda", "Seleccione una opción:", True, 1, New Object() {New Object() {"1", "Video", "2", "Manual", "3", "Reportes"}})
        End If
        If Que = "" Then Exit Sub


        Try

            'para activar o desactivar el menú de reportes

            Dim Dt As New DataTable

            Dim CualLink As String = ""
            Dim Ini As Integer = InStr(lblTitulo.Text, " ")
            Dim Prog As String = Trim(Mid(lblTitulo.Text, 1, Ini - 1))

            If Not IsNumeric(Prog) Then
                Mensaje("No disponible")
                Exit Sub
            End If

            Select Case Que
                Case "1"
                    SiReloj()
                    Abrir(Dt, "Exec GetProgramaVideo2 '" & IIf(EsReporte, "-", "") & Prog & "'")
                    NoReloj()
                    If IsDBNull(Gdf(Dt, "video")) Then
                        Mensaje("Lo sentimos, este producto no tiene video por el momento")
                        Exit Sub
                    End If
                    AbrirLink(Gdf(Dt, "video"))

                Case "2"
                    AbrirLink(GetSett("Ayuda", "Pagina", "") & "/" & IIf(EsReporte, "rep", "") & Prog & ".html")

                Case "3"
                    SiReloj()
                    Abrir(Dt, "Exec GetProgramaReportes2 '" & Prog & "'")

                    NoReloj()

                    If Fin(Dt) Then
                        Mensaje("Este programa no tiene reportes asignados")
                        Exit Sub
                    End If
                    Dim Rep As String = Ventana(Dt, Prog, True, "reporte", , , New Object() {"explicacion"})
                    If Rep <> "" Then
                        Ppal.AbrirPrograma("0401", Rep)
                    End If

            End Select

        Catch ex As Exception

            NoReloj()
            MostrarError(Me.Name, "VideoExplicativoToolStripMenuItem_Click", ex.Message)

        End Try


    End Sub


    Private Sub CmdAyuda_MouseEnter(sender As Object, e As EventArgs) Handles CmdAyuda.MouseEnter
        boton = DirectCast(sender, ToolStripButton)
    End Sub

    Private Sub CmdAyuda_MouseLeave(sender As Object, e As EventArgs) Handles CmdAyuda.MouseLeave
        boton = Nothing

    End Sub

End Class
