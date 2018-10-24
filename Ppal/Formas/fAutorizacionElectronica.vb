' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
' Version: 678, 16-ago.-2018 14:15
' Version: 641, 4-abr.-2018 12:52
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fAutorizacionElectronica
    Public CodigoPrograma As Integer = 0
    Public NumeroPermiso As Integer = 0
    Public TextoMensaje As String = ""
    Dim DtAutorizadores As New DataTable
	Private Sub fAutorizacionElectronica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		If SoyHandHeld() Then
			Me.WindowState = FormWindowState.Maximized
		End If

		Me.Text = Idi(Me.Text)
		CmdEnviar.Text = Idi(CmdEnviar.Text, "Send Authorization Request")
		CmdEnviar.Tag = CmdEnviar.Text


		CmdEnviar.Text = CmdEnviar.Tag

		TxtClave.Tag = 0

		Montar_Usu()


	End Sub
	Private Sub CmdEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEnviar.Click
		If LstUsu.SelectedIndex < 0 Then
			LblSolicitud.Text = "Seleccione usuario"
			LblSolicitud.Visible = True
			Exit Sub
		End If


		'verificar clave del usuario
		If TxtClave.Text <> "" Then
			Try
				Dim Dtcla As New DataTable
				SiReloj()

				Abrir(Dtcla, "Select clave from usuario where id=" & TraerId(LstUsu))

				NoReloj()

				If Fin(Dtcla) Then
					MsgBox(Idi("Usuario no existe"), MsgBoxStyle.Critical)
				Else
					If UCase(TxtClave.Text) <> UCase(Encriptar("D", "" & Gdf(Dtcla, "clave"))) Then
						TxtClave.Tag += 1
						MsgBox(Idi("Clave inválida"), MsgBoxStyle.Information)
						If TxtClave.Tag > 2 Then
							TxtClave.Tag = 0
							For I = 1 To 10
								MsgBox(Idi("Muchos intentos, se registra auditoría") & ".  Mensaje " & I & " de 10", MsgBoxStyle.Critical)
							Next
							Me.Tag = "N"
							Me.Close()
							Exit Sub
						End If
						TxtClave.Text = ""
						TxtClave.Focus()
					Else
						Coja_Autoriz()
					End If
				End If
			Catch ex As Exception
				NoReloj()
				MostrarError(Me.Name, "CmdEnviar_Click:clave", ex.Message)

			End Try

			Exit Sub
		End If
		'verificar clave del usuario

		TxtClave.Enabled = False

		Try
			'limpiar sistema nuevo
			Ejecutar("Update usuario set autorizo=null where id=" & Usuario)

			Mensajeria_DMS(TraerId(LstUsu), "¬" & Idi("Favor Autorizar") & ": " & Strings.Left(TextoMensaje & IIf(TxtAdi.Text <> "", vbNewLine & TxtAdi.Text, ""), 450) & DMScr() & "autorizar=" & CodigoPrograma.ToString & "," & NumeroPermiso.ToString, Usuario)

			LblSolicitud.Text = LblSolicitud.Tag
			LblSolicitud.Visible = True
			Panel1.Enabled = False
			LblSeg.Tag = 0
			LblSeg.Text = ""
			LblSeg.Visible = True
			Timer1.Start()


		Catch ex As Exception
			LblSolicitud.Text = Idi("No logro hacer solicitud") & ": " & ex.Message & EsIngles()
			LblSolicitud.Visible = True
			MsgBox(LblSolicitud.Text, MsgBoxStyle.Information)

		End Try

	End Sub

	Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
		If Panel1.Enabled = False Then 'si ya fue enviada, cancelarla
			Try
				SiReloj()
				Mensajeria_DMS(TraerId(LstUsu), "*** " & Idi("Cancelada solicitud de Autorizar") & ": " & CodigoPrograma.ToString & "," & NumeroPermiso.ToString & " ***", Usuario)
				NoReloj()
			Catch ex As Exception
				NoReloj()
				MostrarError(Me.Name, "CmdCancelar_Click", ex.Message)
			End Try
		End If

		Me.Tag = "N"
		Me.Close()

	End Sub

	Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
		LblSeg.Tag += 1
		LblSeg.Text = LblSeg.Tag ' Strings.Format(LblSeg.Tag, "0.0")

		HagaEventos()

		'sistema viejo
		If GetSetting("DMS S.A.", "syscom", CodigoPrograma.ToString & "," & NumeroPermiso.ToString, "") <> "" Then
			DebugJD("*Autoriz: Viejo")
			Coja_Autoriz()
		End If
		'/sistema viejo

		'sistema nuevo
		If Not BackgroundWorker1.IsBusy Then
			BackgroundWorker1.RunWorkerAsync()
		End If
		'/sistema nuevo


	End Sub
	Private Sub Coja_Autoriz()
		Timer1.Stop()
		LblSeg.Visible = False

		DebugJD("Econtró autorización " & CodigoPrograma & "," & NumeroPermiso.ToString)
		Eliminar_Setting("DMS S.A.", "syscom", CodigoPrograma & "," & NumeroPermiso.ToString)
		Me.TopMost = False
		HagaEventos()

		If Me.Tag = "N" Then
			Me.Tag = "N"
			MsgBox(Idi("Autorización ha sido NEGADA por el usuario"), MsgBoxStyle.Information, Idi("Autorización Negada"))
		Else
			Me.Tag = "S"
		End If

		'MsgBox("voy a cerrar")
		Me.Close()
		'Me.Hide()

	End Sub

	Private Sub Montar_Usu()
		Try
			SiReloj()
			Dim Subg As Integer = ValD(GetSett("ele", "sub", "0"))
			Dim Cargo As Integer = ValD(GetSett("ele", "car", "0"))
			Abrir(DtAutorizadores, "exec GetAutorizadores " & Numero_Empresa.ToString & "," & Subg.ToString & "," & Cargo.ToString & "," & CodigoPrograma.ToString & "," & NumeroPermiso) 'JFG-640 NumeroPermiso para autoriaciones por permiso
			NoReloj()

			Llene_Combo5(LstUsu, DtAutorizadores, "id_usuario", "nombre", IIf(ChkVerTodos.Checked, "", "on_line=1"), "nombre", , , False)
			If LstUsu.Items.Count > 0 Then
				LstUsu.SelectedIndex = 0
			End If

		Catch ex As Exception
			NoReloj()
			LblSolicitud.Text = Idi("No logro hacer solicitud") & ": " & ex.Message & EsIngles()
			LblSolicitud.Visible = True

		End Try

	End Sub

	Private Sub ChkVerTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkVerTodos.CheckedChanged
		Montar_Usu()

	End Sub

	Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
		Try
			Dim Dt As New DataTable
			Abrir(Dt, "Select autorizo from usuario where id=" & Usuario & " And autorizo is not null")
			If Not Fin(Dt) Then
				If Gdf(Dt, "autorizo") = 0 Then 'no autorizó
					Me.Tag = "N" 'negar
				Else
					Me.Tag = "R" 'para indicar que encontró
				End If
			End If
		Catch ex As Exception

		End Try
	End Sub

	Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
		If Me.Tag = "R" Or Me.Tag = "N" Then
			DebugJD("*Autoriz: Nuevo")
			Coja_Autoriz()
		End If

	End Sub

	Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs) Handles TxtClave.TextChanged
		If TxtClave.Text <> "" Then
			CmdEnviar.Text = Idi("Autorizar con esta clave")
		Else
            CmdEnviar.Text = CmdEnviar.Tag
        End If
    End Sub

    Private Sub LstUsu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstUsu.SelectedIndexChanged
        TxtClave.Tag = 0
        TxtClave.Focus()

    End Sub
End Class