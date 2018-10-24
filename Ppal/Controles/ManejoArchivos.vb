' Version: 683, 23-ago.-2018 12:40
' Version: 680, 17-ago.-2018 13:24
'♥ versión: 586, 6-oct.-2017 07:11
Public Class ManejoArchivos
    Dim YaAbrio As Boolean = False
    Dim Modifico As Boolean = False
    Dim EliminarArchivo As Boolean = False
    Dim Programa As String = ""
    Public WriteOnly Property DMSPrograma() As String
        Set(ByVal value As String)
            Programa = value
        End Set
    End Property


    Public Property DMSModifico() As Boolean
        Get
            Return Modifico
        End Get
        Set(ByVal value As Boolean)
            Modifico = value
        End Set
    End Property
 
    Public Property DMSEliminarArchivo() As Boolean
        Get
            Return EliminarArchivo
        End Get
        Set(ByVal value As Boolean)
            EliminarArchivo = value
        End Set
    End Property

    Public WriteOnly Property DMSSoloLectura() As Boolean
        Set(ByVal value As Boolean)
            LnkArchivo.Enabled = value
            LnkArchivoQuitar.Enabled = value
        End Set
    End Property


    Public Property DMSYaAbrio() As Boolean
        Get
            Return YaAbrio
        End Get
        Set(ByVal value As Boolean)
            YaAbrio = value
            If Not YaAbrio Then
                LnkArchivoAbrir.Tag = 0
            End If
        End Set
    End Property

    Public Property DMSNombreArchivo(Optional ByVal RutaCompleta As Boolean = True) As String
        Get
            If RutaCompleta Then
                Return LblArchivo.Tag
            Else
                Return LblArchivo.Text
            End If
        End Get
        Set(ByVal value As String)
            LblArchivo.Text = IO.Path.GetFileName(value)
            LblArchivo.Tag = value
        End Set
    End Property

    Private Sub LnkArchivoQuitar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkArchivoQuitar.LinkClicked
        LblArchivo.Text = ""
        EliminarArchivo = True
        Modifico = True
    End Sub
    Private Sub LnkArchivoAbrir_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkArchivoAbrir.LinkClicked
      
        If LblArchivo.Text = "" Then Mensaje("no hay archivo") : Exit Sub
        If ValD(Me.Tag) = 0 Then Mensaje("Solo si esta modificando.") : Exit Sub


        If YaAbrio Or ValD(LnkArchivoAbrir.Tag) = 1 Then
            AbrirLink(LblArchivo.Tag)
            Exit Sub
        End If


        Dim sav As New OpenFileDialog
        sav.Filter = "*" & IO.Path.GetExtension(LblArchivo.Text) & "|*" & IO.Path.GetExtension(LblArchivo.Text)
        sav.FileName = LblArchivo.Text


        Dim asa As DialogResult = sav.ShowDialog()
        If asa <> DialogResult.OK Then Exit Sub

        TraerArchivo(sav.FileName, Programa, ValD(Me.Tag))

 
        If LblArchivo.Text <> "" Then
            AbrirLink(sav.FileName)
            LblArchivo.Tag = sav.FileName
            YaAbrio = True
        End If



    End Sub


    Private Sub LnkArchivo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkArchivo.LinkClicked
        Dim Guardar As New SaveFileDialog
        Guardar.Title = "Escoja archivo que desea adjuntar"
        Guardar.OverwritePrompt = False
        Guardar.ShowDialog()

        If Guardar.FileName <> "" Then
            LblArchivo.Text = IO.Path.GetFileName(Guardar.FileName)
            LblArchivo.Tag = Guardar.FileName
        End If

        LnkArchivoAbrir.Tag = 1
        Guardar.Dispose()
        Modifico = True
    End Sub

	Private Sub ManejoArchivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_Idioma(Me, Me)

	End Sub
End Class
