' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 601, 29-nov.-2017 12:05
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fResultBuscarGrid
    Public Grd As New DataGridView

    Private Sub fBuscarGrd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Try
			Dim Col As New DataGridViewColumn
			ChkTodasCol.Checked = True
			For I = 0 To Grd.ColumnCount - 1
				'GrdResultado.Columns.Add(Grd.Columns(I).Name, Grd.Columns(I).HeaderText)

				'If Grd.Columns(I).Name = "imagen" Then
				'    Continue For
				'End If

				Col = Grd.Columns(I).Clone
				GrdResultado.Columns.Add(Col)
				'Dim aaa As New DataGridViewColumn
				'aaa.Name = Col.Name
				'GrdResultado.Columns.Add(aaa)
				'GrdResultado.Columns.Add(Grd.Columns(I).Name, Grd.Columns(I).Name)

				If Grd.Columns(I).HeaderText <> "" And Grd.Columns(I).Visible Then
					CbColumnas.Items.Add(New DataDescription(Grd.Columns(I).Name, Grd.Columns(I).HeaderText))
				End If
			Next


		Catch ex As Exception

		End Try
    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.Tag = -1
        Me.Close()
    End Sub

    Private Sub CmdNinguno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNinguno.Click
        For I As Integer = 0 To CbColumnas.Items.Count - 1
            CbColumnas.SetItemChecked(I, False)
        Next
    End Sub

    Private Sub CmdTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTodos.Click
        For I As Integer = 0 To CbColumnas.Items.Count - 1
            CbColumnas.SetItemChecked(I, True)
        Next
    End Sub
    Private Sub Buscar()
        If TextBox1.Text.Trim = "" Then
            Mensaje("Entre texto a buscar")
            TextBox1.Focus()
            Exit Sub
        End If
        If Not ChkTodasCol.Checked And CbColumnas.CheckedItems.Count = 0 Then
            ChkTodasCol.Checked = True
        End If
        Try
            SiReloj()

            GrdResultado.Rows.Clear()
            Dim Texto2 As String = "*" & TextBox1.Text.Trim.ToLower & "*"
            For I = 0 To Grd.Rows.Count - 1
                ''por el problema del 1102, ximena
                'Try
                '    If Grd.Rows(I).DefaultCellStyle.Font.Bold Then
                '        Continue For
                '    End If
                'Catch
                'End Try

                Try

                    For J = 0 To CbColumnas.Items.Count - 1
                        If Not ChkTodasCol.Checked And Not CbColumnas.GetItemChecked(J) Then Continue For

                        'If Grd.Columns(J).Name = "imagen" Then
                        '    Continue For
                        'End If

                        Dim Texto As String = "" & SinTildes(CStr(Grd.Rows(I).Cells(CbColumnas.Items(J).data).value.ToString.ToLower))

                        'If Grd.Rows(I).Cells(J).Style.Alignment = DataGridViewContentAlignment.BottomCenter Then

                        'End If

                        'If Texto.IndexOf(SinTildes(TextBox1.Text.Trim.ToLower)) >= 0 Then
                        If Texto Like Texto2 Then
                            Dim Index As Integer = GrdResultado.Rows.Add()
                            For K = 0 To Grd.Columns.Count - 1
                                Try

                                    Dim Datico As String = "" & Grd.Rows(I).Cells(K).Value
                                    GrdResultado.Rows(Index).Cells(K).Value = Datico
                                Catch
                                End Try
                            Next
                            GrdResultado.Rows(Index).Tag = I
                            Exit For
                        End If
                    Next

                Catch ex As Exception
                End Try
            Next

            NoReloj()

            If GrdResultado.Rows.Count = 0 Then
                Mensaje("Texto no encontrado")
                TabsPrincipal.SelectedTab = TabBuscar
            Else
                TabsPrincipal.SelectedTab = TabResultado
            End If
            TabsPrincipal.Refresh()
        Catch ex As Exception
            NoReloj()

			'Mensaje(ex.Message & EsIngles)

		End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabsPrincipal.SelectedIndexChanged
        If TabsPrincipal.SelectedTab Is TabResultado Then
            CmdAceptar.Text = "Regresar"
            'TabsPrincipal.SelectedTab = TabBuscar
            'solo con cli en el botón
            'Buscar()
        Else
            CmdAceptar.Text = "Buscar"

        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Buscar()
        End If
    End Sub

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click
        Aceptar()
    End Sub
    Private Sub Aceptar()
        If TabsPrincipal.SelectedTab Is TabBuscar Then
            Buscar()
        ElseIf TabsPrincipal.SelectedTab Is TabResultado Then
            Me.Tag = GrdResultado.SelectedRows(0).Tag
            'Me.Tag = GrdResultado.SelectedRows(0).Index
            Me.Close()
        End If

    End Sub
    Private Sub ChkTodasCol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTodasCol.CheckedChanged
        If ChkTodasCol.Checked Then
            PnlCol.Visible = False
        Else
            PnlCol.Visible = True
        End If
    End Sub

    Private Sub GrdResultado_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdResultado.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        Aceptar()
    End Sub

    Private Sub GrdResultado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdResultado.KeyDown
        If e.KeyCode = Keys.Enter Then
            Aceptar()
        End If
    End Sub



    Private Sub GrdResultado_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles GrdResultado.DataError
        'Mensaje("error")

    End Sub
End Class