' Version: 681, 20-ago.-2018 20:08
Public Class TextBoxMultilineaDMS
    Public Event DMSF1()
    Public Event DMSValidated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event DMSTextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public Sub DMSAsignarTexto(ByVal Texto As String)
        TextBox1.Text = Texto
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
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

    Private Sub TextBox1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Validated
        RaiseEvent DMSValidated(Me, e)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        RaiseEvent DMSTextChanged(Me, e)
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        Buscar()
    End Sub

    Private Sub Buscar(Optional ByVal F3 As Boolean = False)
        Try
            If TextBox1.Text.Length = 0 Then MsgBox("No hay información para hacer la búsqueda") : Exit Sub
            Dim Frm As New fResultBuscarTextBox
            Frm.TextBox1.Text = TextBox1.Text.Substring(TextBox1.SelectionStart, TextBox1.SelectionLength).Trim
            Frm.TextoOriginal(TextBox1)
            Frm.TopMost = True
            If F3 And Frm.TextBox1.Text <> "" Then
                Frm.Buscar()

            Else
                Frm.ShowDialog()

            End If

        Catch ex As Exception

        End Try
    End Sub

	Private Sub TextBoxMultilineaDMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_ContextMenuStrip(ContextMenuStrip1)

	End Sub
End Class
