' Version: 681, 20-ago.-2018 20:08
' Version: 603, 5-dic.-2017 19:15
' Version: 592, 25-oct.-2017 19:06
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fPedirDestinos
    Public IdCuenta As Integer = 0
    Public IdCentro As Integer = 0
    Public D1 As Integer = 0
    Public D2 As Integer = 0
    Public D3 As Integer = 0
    Public D4 As Integer = 0
    Private Sub fPedirDestinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If DtDestinos Is Nothing Then
            Try
                SiReloj()
                Abrir(DtDestinos, "GetConDestinos " & Numero_Empresa)
                NoReloj()
            Catch ex As Exception
                NoReloj()
				MostrarError(Me.Name, "fPedirDestinos_Load", ex.Message)

			End Try
		End If

		'mostrar nombres
		Mostrar_Destino(LnkDestino1, LblDestino1)
		Mostrar_Destino(LnkDestino2, LblDestino2)
		Mostrar_Destino(LnkDestino3, LblDestino3)
		Mostrar_Destino(LnkDestino4, LblDestino4)
		'/mostrar nombres

		PnlDest1.Visible = D1 = 1
		PnlDest2.Visible = D2 = 1
		PnlDest3.Visible = D3 = 1
		PnlDest4.Visible = D4 = 1

		If ReglaDeNegocio(146, "destinos", "0") = "1" Then 'destino simple
			PnlDest1.Location = PnlDest2.Location
			PnlDest2.Left = -5000
			PnlDest3.Left = -5000
			PnlDest4.Left = -5000
			LnkDestino1.Text = "Destino (F1)"
		End If

		'limpiar obligatorio
		If D1 = 0 Then
			LblDestino1.Tag = 0
		End If
		If D2 = 0 Then
			LblDestino2.Tag = 0
		End If
		If D3 = 0 Then
			LblDestino3.Tag = 0
		End If
		If D4 = 0 Then
			LblDestino4.Tag = 0
		End If

	End Sub
	Private Sub Mostrar_Destino(ByRef Lnk As LinkLabel, ByRef LblDest As Label)
		If ValD(Lnk.Tag) > 0 Then
			LblDest.Text = "" & Obtenga_Dato(DtDestinos, "id=" & ValD(Lnk.Tag), "descripcion")
			'TODO:Mejorar
			If LblDest.Text = "" Then
				Try
					SiReloj()
					LblDest.Text = "" & Obtenga_Dato("select descripcion from con_destinos where id=" & ValD(Lnk.Tag), "", "descripcion")
					NoReloj()
				Catch ex As Exception
					NoReloj()
					MostrarError(Me.Name, "Mostrar_Destino", ex.Message)
				End Try
			End If
		Else
			LblDest.Text = ""
		End If
	End Sub
	Private Sub LnkDestino_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkDestino1.LinkClicked, LnkDestino2.LinkClicked, LnkDestino3.LinkClicked, LnkDestino4.LinkClicked
		Try
			Dim NumDest As String = Strings.Mid(sender.name, 11, 1)
			Dim desti As String = ClaseDestinos.Seleccione_Destino(ValD(sender.Tag), IdCuenta, NumDest, IdCentro)
			Dim labelDest As Label = DirectCast(Me.Controls.Find("LblDestino" & NumDest, True)(0), Label)

			If desti <> "" Then
				Dim dd() As String = desti.Split("|")
				If ValD(dd(2)) > 0 And IdCuenta > 0 Then
					Mensaje("Destino no es afectable. No puede ser un destino padre")
					Exit Sub
				End If
				sender.Tag = dd(0)
				labelDest.Text = dd(1)
			Else
				sender.Tag = ""
				labelDest.Text = ""
			End If
			CmdAceptar.Focus()

		Catch ex As Exception
			Mensaje(ex.Message)

		End Try

    End Sub


    Private Function Validar_Cuentas() As String
        If IdCuenta = 0 Then
            Return ""
        End If

        If PnlDest1.Visible And ValD(LnkDestino1.Tag) = 0 Then
            Return ("Falta dimensión 1")
        End If
        If PnlDest2.Visible And ValD(LnkDestino2.Tag) = 0 Then
            Return ("Falta dimensión 2")
        End If
        If PnlDest3.Visible And ValD(LnkDestino3.Tag) = 0 Then
            Return ("Falta dimensión 3")
        End If
        If PnlDest4.Visible And ValD(LnkDestino4.Tag) = 0 Then
            Return ("Falta dimensión 4")
        End If


        Return ""

    End Function
    Private Sub CmdAceptar_Click(sender As Object, e As EventArgs) Handles CmdAceptar.Click, CmdCancelar.Click

        Dim TexErr As String = Validar_Cuentas()


        If sender Is CmdAceptar Then
            If TexErr <> "" Then
                Mensaje(TexErr)
            Else
                Me.Tag = 1
                Me.Close()
            End If
            Exit Sub
        Else 'presionó cancelar
            If TexErr <> "" Then
                Me.Tag = -1
            Else
                Me.Tag = ""
            End If
            Me.Close()
            Exit Sub
        End If




    End Sub

    Private Sub fPedirDestinos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            If PnlDest1.Visible Then LnkDestino_LinkClicked(LnkDestino1, Nothing)
        ElseIf e.KeyCode = Keys.F2 Then
            If PnlDest2.Visible Then LnkDestino_LinkClicked(LnkDestino2, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            If PnlDest3.Visible Then LnkDestino_LinkClicked(LnkDestino3, Nothing)
        ElseIf e.KeyCode = Keys.F4 Then
            If PnlDest4.Visible Then LnkDestino_LinkClicked(LnkDestino4, Nothing)
        ElseIf e.KeyCode = Keys.F5 Then
            CmdAceptar_Click(CmdAceptar, New EventArgs)
        End If

    End Sub
End Class