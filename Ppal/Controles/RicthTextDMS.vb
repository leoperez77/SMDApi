' Version: 684, 24-ago.-2018 16:56
' Version: 681, 20-ago.-2018 20:08
Public Class RicthTextDMS
    Public Sub DMSAsignarRtf(ByVal Rtf As String, ByVal SoloLectura As Boolean)
        RichTextBox1.ReadOnly = SoloLectura
        Try
            RichTextBox1.Rtf = Rtf
        Catch ex As Exception
            RichTextBox1.Text = Rtf
        End Try

    End Sub



    Private Sub RichTextBox1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        If e.LinkText = "" Then Exit Sub

        Try
            System.Diagnostics.Process.Start(e.LinkText)
       
        Catch ex As Exception
			MsgBox("No pudo abrir link: " & ex.Message & EsIngles())
		End Try
    End Sub

    Public Event DMSF1()
    Public Event DMSValidated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event DMSTextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

 
    Private Sub RichTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyDown
        If e.KeyCode = Keys.F1 Then
            RaiseEvent DMSF1()
        End If
        If ((e.KeyCode = Keys.F Or e.KeyCode = Keys.B) And e.Control = True) Then
            Buscar()
        End If
        If e.KeyCode = Keys.F3 Then

            Buscar(True)

        End If
    End Sub

    Private Sub RichTextBox1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.Validated
        RaiseEvent DMSValidated(Me, e)
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        RaiseEvent DMSTextChanged(Me, e)
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        Buscar()
    End Sub

    Private Sub Buscar(Optional ByVal F3 As Boolean = False)
        Try
            If RichTextBox1.Text.Length = 0 Then MsgBox("No hay información para hacer la búsqueda") : Exit Sub
            Dim Frm As New fResultBuscarTextBox
            Frm.TextBox1.Text = RichTextBox1.Text.Substring(RichTextBox1.SelectionStart, RichTextBox1.SelectionLength).Trim

            Frm.TextoOriginal(RichTextBox1)
            Frm.TopMost = True
            If F3 And Frm.TextBox1.Text <> "" Then
                Frm.Buscar()

            Else
                Frm.ShowDialog()

            End If

        Catch ex As Exception

        End Try
    End Sub

	Private Sub RicthTextDMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_ContextMenuStrip(ContextMenuStrip1)

	End Sub
End Class
