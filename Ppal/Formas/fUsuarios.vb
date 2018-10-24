' Version: 684, 24-ago.-2018 16:56
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 661, 10-jul.-2018 13:27
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fUsuarios
	Public Propietario As Integer
	Public SoloUnUsuario As Boolean = False

	Public Sub LLene_Usuarios(ByVal DtUsuarios As DataTable,
							  ByVal UsuariosSeleccionados As String,
							  ByVal UsuQueNovalida As String,
							  Optional ByVal NoLinkTodos As Boolean = True,
							  Optional ByVal NoLinkNinguno As Boolean = False)

		DemeNodo()
		UsuariosDMS1.DMSQuitar_Links(NoLinkTodos, NoLinkNinguno)
		UsuariosDMS1.DMSLLene_Usuarios(DtUsuarios)
		UsuariosDMS1.DMSSeleccionar_Usuarios(UsuariosSeleccionados)
		UsuariosDMS1.Tag = UsuQueNovalida
		If UsuariosSeleccionados <> "" Then
			UsuariosDMS1.ChkSeleccionados.Checked = True
		Else
			UsuariosDMS1.ChkSeleccionados.Checked = False
		End If
	End Sub


	Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click

		Me.Tag = UsuariosDMS1.DMSTraerIds

		Me.Close()

	End Sub

	Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
		Me.Tag = "0"
		Me.Close()
	End Sub


	Private Sub UsuariosDMS1_DMSCheckIndex(ByVal Sender As System.Object, ByVal id As System.Int32, ByVal ValorCheck As System.Boolean, ByRef NuevoValor As System.Windows.Forms.CheckState) Handles UsuariosDMS1.DMSCheckIndex
		If NuevoValor = CheckState.Unchecked Then Exit Sub
		Dim Usu As String() = ("" & UsuariosDMS1.Tag).ToString.Split(",")

		If SoloUnUsuario Then
			If UsuariosDMS1.DMSTraerIds.Split(",").Length >= 1 And UsuariosDMS1.DMSTraerIds <> "" Then
				Mensaje("Solo puede seleccionar un usuario.")
				NuevoValor = CheckState.Unchecked
				Exit Sub
			End If
		End If

		If Propietario = id Then
			Mensaje("El usuario es el propietario")
			NuevoValor = CheckState.Unchecked
			Exit Sub
		End If

		For I = 0 To Usu.Length - 1
			If id = ValD(Usu(I)) Then
				Mensaje("El usuario ya se encuentra en " & Me.Tag)
				NuevoValor = CheckState.Unchecked
			End If
		Next
	End Sub

	Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

		'Dim Existe As Boolean = False
		'Try
		'    Existe = e.Argument(4)
		'Catch
		'    Existe = False
		'End Try

		EnviarArchivoUsuario(ValD(e.Argument(0)), e.Argument(1), e.Argument(2), e.Argument(3), e.Argument(4))

	End Sub

	Private Sub EnviarArchivoUsuario(ByVal UsuarioDestino As Integer, ByVal Archivo As String, ByVal Grid As DataGridView, ByVal TextoChat As String, Optional ExisteArchivo As Boolean = False)
		Dim paso As String = "1"

		Try
			Dim Dt As New DataTable

			paso = "2"

			If Not ExisteArchivo Then
				If Copiar_Exel(Grid, Archivo, Me.Text) = "N" Then
					Exit Sub
				End If
			End If

			paso = "3"

			Dim Tamaño As Integer = My.Computer.FileSystem.GetFileInfo(Archivo).Length


			Abrir(Dt, "PutDatosArchivo2 " & Numero_Empresa.ToString & "," & Usuario.ToString & "," & UsuarioDestino & ",'" & IO.Path.GetFileName(Archivo) & "'," & Tamaño.ToString)

			If Not ValidacionEnvio(ValD(Gdf(Dt, "bytes_enviados")), Archivo) Then
				Exit Sub
			End If

			paso = "4"

			Dim NumeroID As Integer = ValD("" & Gdf(Dt, "ultimo"))

			Dim DirectorioActual As String = My.Computer.FileSystem.CurrentDirectory
			'If YaEstaElArchivo <> "" Then
			'	My.Computer.FileSystem.CurrentDirectory = RutaDelArchivo(Archivo)
			'Else
			'	My.Computer.FileSystem.CurrentDirectory = Path_Temp
			'End If
			My.Computer.FileSystem.CurrentDirectory = RutaDelArchivo(Archivo)


			paso = "5"

			GrabarArchivoBD(IO.Path.GetFileName(Archivo), "archivos", NumeroID)

			Mensajeria_DMS(UsuarioDestino, vbNewLine & IIf(TextoChat = "", "Archivo enviado desde Advance:", TextoChat) & DMScr(2) & "   - Nombre: " & IO.Path.GetFileName(Archivo) & DMScr() & "   - Tamaño: " & Tamaño & " bytes" & DMScr() & "   - www.smd.ar" & NumeroID.ToString & "-" & Tamaño & DMScr(), Usuario)

			If SiMedirConsumo Then
				Grabar_Consumo(Tamaño)
			End If

			paso = "6"

			My.Computer.FileSystem.CurrentDirectory = DirectorioActual

			SonarWAV("OK")

		Catch ex As Exception
			Mensaje_TopMost("Operación falló paso: " & paso & ", " & ex.Message & EsIngles(), , , True)

		End Try

		If IO.File.Exists(Archivo) Then
			Try
				Kill(Archivo)
			Catch
			End Try
		End If


	End Sub
	Public Function ValidacionEnvio(ByVal ArchivoMaximo As Integer, ByVal NombreArchivo As String) As Boolean
		ValidacionEnvio = False

		Dim Tamaño As Integer = My.Computer.FileSystem.GetFileInfo(NombreArchivo).Length

		If Tamaño > ValD(GetSett("ctrl", "max", 0)) Then
			Mensaje("Este archivo tiene " & Tamaño.ToString & " bytes y no puede ser mayor a " & ArchivoMaximo.ToString & " bytes")
			Exit Function
		End If
		If ArchivoMaximo > ValD(GetSett("ctrl", "files", 0)) Then
			Mensaje("Cantidad de bytes enviados ha superado el presupuesto de este mes para esta Empresa. No se pueden enviar más archivos por este mes. Puede solicitar ampliación de presupuesto a DMS")
			Exit Function
		End If
		If Len(IO.Path.GetFileName(NombreArchivo)) > 100 Then
			Mensaje("Nombre de Archivo máximo de 100 caracteres")
			Exit Function
		End If
		ValidacionEnvio = True
	End Function

	Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
		Me.Close()

	End Sub

End Class