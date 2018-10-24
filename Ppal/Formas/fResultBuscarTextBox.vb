' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
Public Class fResultBuscarTextBox
    Dim Texto As New Object
    Dim Index As Integer = 0
    Public Sub TextoOriginal(ByRef Text As Object)
        Texto = Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Buscar()
    End Sub

    Public Sub Buscar()
        Try
            ChkAtras.Checked = GetSetting("DMS S.A. SmdAsp", Me.Name, "Atras", ChkAtras.Checked)

            Dim aBuscar As String = ""
            Dim Elemento As String = ""
            If Not ChkMMT.Checked Then
                aBuscar = SinTildes(Texto.Text.ToLower())
                Elemento = SinTildes(TextBox1.Text.ToLower())
            Else
                aBuscar = Texto.Text
                Elemento = TextBox1.Text
            End If
            If Elemento = "" Then Exit Sub
            If Index > aBuscar.Length Then
                Index = 0
            End If
            If ChkAtras.Checked Then

                Index = Texto.SelectionStart
                For i As Integer = Index To 0 Step -1
                    If i - Elemento.Length < 0 Then
                        Texto.SelectionStart = aBuscar.Length
                        Texto.SelectionLength = 0
                        MsgBox("No encontró el texto")
                        If Not Me.Visible Then
                            Me.ShowDialog()
                        End If
                        Exit For
                    End If

                    If aBuscar.Substring(i - Elemento.Length, Elemento.Length).Contains(Elemento) Then
                        Texto.SelectionStart = i - Elemento.Length
                        Texto.SelectionLength = Elemento.Length
                        Me.Close()
                        Exit For
                    End If

                Next
            Else
                Index = Texto.SelectionStart + Texto.SelectionLength
                If Index >= aBuscar.Length Then
                    Index = 0
                End If
                For i As Integer = Index To aBuscar.Length - 1
                    If i + Elemento.Length > aBuscar.Length - 1 Then

                        Texto.SelectionStart = 0
                        Texto.SelectionLength = 0

                        MsgBox("No encontró el texto")
                        If Not Me.Visible Then
                            Me.ShowDialog()
                        End If
                        Exit For

                    End If
                    If aBuscar.Substring(i, Elemento.Length).Contains(Elemento) Then
                        Texto.SelectionStart = i
                        Texto.SelectionLength = Elemento.Length

                        Me.Close()
                        Exit For
                    End If

                Next
            End If
            Texto.Focus()
            Texto.ScrollToCaret()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub fResultBuscarTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ChkAtras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAtras.CheckedChanged
        SaveSetting("DMS S.A. SmdAsp", Me.Name, "Atras", ChkAtras.Checked)
    End Sub

    Private Sub fResultBuscarTextBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		ChkAtras.Checked = GetSetting("DMS S.A. SmdAsp", Me.Name, "Atras", ChkAtras.Checked)

	End Sub
End Class