'♥ versión: 586, 6-oct.-2017 07:11
Public Class fHijo


    Private _Text As String = MyBase.Text
    Public Overrides Property Text() As String
        Get
            Return _Text
        End Get
        Set(ByVal value As String)
            _Text = value
            If Me.IsMdiChild Then
                DirectCast(Me.MdiParent, fPadre).Text = _Text
            End If

        End Set
    End Property

    'Public Shadows Property FormBorderStyle() As System.Windows.Forms.FormBorderStyle
    '    Get
    '        Return MyBase.FormBorderStyle
    '    End Get
    '    Set(ByVal value As System.Windows.Forms.FormBorderStyle)
    '        MyBase.FormBorderStyle = value
    '        If Me.IsMdiChild Then
    '            DirectCast(Me.MdiParent, fPadre).FormBorderStyle = value
    '        End If

    '    End Set
    'End Property

    Private _FormBorderStyle As System.Windows.Forms.FormBorderStyle
    Public Shadows Property FormBorderStyle() As System.Windows.Forms.FormBorderStyle
        Get
            If Me.IsMdiChild Then
                Return DirectCast(Me.MdiParent, fPadre).FormBorderStyle
            End If
            Return _FormBorderStyle
        End Get
        Set(ByVal value As System.Windows.Forms.FormBorderStyle)
            _FormBorderStyle = value
            If Me.IsMdiChild Then

                DirectCast(Me.MdiParent, fPadre).FormBorderStyle = value
            End If

        End Set
    End Property
    Public Shadows Sub Show()
        MyBase.Show()
        If Me.IsMdiChild Then
            DirectCast(Me.MdiParent, fPadre).Show()
        End If
    End Sub

    Public Shadows Sub Close()
        If Me.IsMdiChild Then
            DirectCast(Me.MdiParent, fPadre).Cerrar = True
        End If
    End Sub

    Public Shadows Sub Hide()
        If Me.IsMdiChild Then
            DirectCast(Me.MdiParent, fPadre).Hide()
        End If
    End Sub

    Private _Tag As Object = MyBase.Tag
    Public Shadows Property Tag() As Object
        Get
            Return _Tag
        End Get
        Set(ByVal value As Object)
            _Tag = value
            MyBase.Tag = value
            If Me.IsMdiChild Then
                DirectCast(Me.MdiParent, fPadre).Tag = _Tag
            End If

        End Set
    End Property

    Private _Size As Size = MyBase.Size
    Public Shadows Property Size() As Size
        Get
            Return _Size
        End Get
        Set(ByVal value As Size)
            _Size = value
            MyBase.Size = _Size
            If Me.IsMdiChild Then
                DirectCast(Me.MdiParent, fPadre).Size = _Size
            End If

        End Set
    End Property


    Private _WindowState As System.Windows.Forms.FormWindowState = MyBase.WindowState
    Public Shadows Property WindowState() As System.Windows.Forms.FormWindowState
        Get
            If Me.IsMdiChild Then
                Return DirectCast(Me.MdiParent, fPadre).WindowState()
            End If
            Return _WindowState

        End Get
        Set(ByVal value As System.Windows.Forms.FormWindowState)
            _WindowState = value

            If Me.IsMdiChild Then
                DirectCast(Me.MdiParent, fPadre).WindowState = _WindowState
            End If

        End Set
    End Property
    Public Shadows Property ShowInTaskbar() As Boolean
        Get
            Return MyBase.ShowInTaskbar
        End Get
        Set(ByVal value As Boolean)
            MyBase.ShowInTaskbar = value
            If Me.IsMdiChild Then
                DirectCast(Me.MdiParent, fPadre).ShowInTaskbar = value
            End If

        End Set
    End Property

    Public Shadows Property StartPosition() As System.Windows.Forms.FormStartPosition
        Get
            If Me.IsMdiChild Then
                Return DirectCast(Me.MdiParent, fPadre).StartPosition()
            End If
            Return MyBase.StartPosition
        End Get
        Set(ByVal value As System.Windows.Forms.FormStartPosition)

            MyBase.StartPosition = value
            If Me.IsMdiChild Then
                DirectCast(Me.MdiParent, fPadre).StartPosition = value
            End If

        End Set
    End Property

    'Private Sub fHijo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    If IsMdiChild Then
    '        IfDirectCast(Me.MdiParent, fPadre).GetType() Is GetType(fPadre) Then
    '            DirectCast(Me.MdiParent, fPadre).Close()
    '        End If
    '    End If

    'End Sub



    Private Sub fHijo_ParentChanged(sender As Object, e As EventArgs) Handles MyBase.ParentChanged
        Me.Tag = Me.Tag

    End Sub


    'Private Sub fHijo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'If Not IsMdiChild And My.Application.ApplicationContext.MainForm IsNot Nothing Then
    '    '    MostrarForma3( fmenu.icon, Me)
    '    'End If
    'End Sub

    Private Sub fHijo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If IsMdiChild Then
            If DirectCast(Me.MdiParent, fPadre).GetType() Is GetType(fPadre) Then
                DirectCast(Me.MdiParent, fPadre).QuitarCargando()
            End If
        End If
    End Sub


    Private Sub fHijo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsMdiChild Then
            DirectCast(Me.MdiParent, fPadre).IsLoad = True
        End If
    End Sub
End Class
