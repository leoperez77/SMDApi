' Version: 684, 24-ago.-2018 16:56
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fArchivos_Adjuntos

    Private Sub fArchivos_Adjuntos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    'Dim Abrir As New FolderBrowserDialog

    ''Abrir. = "Escoja Ruta donde desea Guardar el archivo"
    ''Abrir.OverwritePrompt = False
    '    Abrir.ShowDialog()

    '    If Not IO.Directory.Exists(Abrir.SelectedPath) Then
    '        Mensaje("Directorio no existe")
    '        Exit Sub
    '    End If

    'Dim Archivo As Byte() = TraerArchivo(Abrir.SelectedPath & "\" & LblArchivo.Text, "9001", ValD(Me.Tag))



    ''If LblArchivo.Text <> "" Then
    '    AbrirLink(Abrir.SelectedPath & LblArchivo.Text)
    ''End If







    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub CmdAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAbrir.Click
        Try
            Panel1.Enabled = False


            'Dim Temp As String = Environment.GetEnvironmentVariable("TEMP") & "\Archivos_Recibidos\"

            'If Not IO.Directory.Exists(Path_Temp) Then
            '    IO.Directory.CreateDirectory(Path_Temp)
            'End If

            If IO.File.Exists(Path_Temp & LblArchivo.Text) Then
                Kill(Path_Temp & LblArchivo.Text)
            End If

            LblProc.Visible = True
            HagaEventos()

            SiReloj(Me)
            TraerArchivo(Path_Temp & LblArchivo.Text, LblPregunta.Tag, LblArchivo.Tag)


            LblProc.Visible = False
            NoReloj(Me)
            Me.Hide()
            HagaEventos()

            AbrirLink(Path_Temp & LblArchivo.Text)

            Me.Close()


        Catch ex As Exception
            Panel1.Enabled = True
            NoReloj(Me)
            LblProc.Visible = False
			Mensaje_TopMost("Error: " & ex.Message & EsIngles(), , , True)

		End Try


	End Sub

	Private Sub CmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGuardar.Click
		Try
			Panel1.Enabled = False

			Dim Extension As String = IO.Path.GetExtension(LblArchivo.Text)

			Dim Abrir As New SaveFileDialog

			Abrir.DefaultExt = "|*" & Extension
			Abrir.Filter = "|*" & Extension

			Abrir.FileName = LblArchivo.Text

			If Abrir.ShowDialog = DialogResult.Cancel Then
				Exit Sub
			End If
			If Abrir.FileName = "" Then Exit Sub

			If IO.Path.GetExtension(Abrir.FileName) <> Extension Then
				Abrir.FileName &= "." & Extension
			End If

			LblProc.Visible = True
			HagaEventos()

			SiReloj(Me)

			TraerArchivo(Abrir.FileName, LblPregunta.Tag, LblArchivo.Tag)

			LblProc.Visible = False
			NoReloj(Me)
			Me.Hide()
			HagaEventos()

			AbrirLink(Abrir.FileName)

			Me.Close()

		Catch ex As Exception
			Panel1.Enabled = True
			NoReloj(Me)
			LblProc.Visible = False
			Mensaje_TopMost("Error: " & ex.Message & EsIngles(), , , True)

		End Try

    End Sub
End Class