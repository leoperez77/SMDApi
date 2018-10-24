' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 603, 5-dic.-2017 19:15
' Version: 593, 27-oct.-2017 09:31
' Version: 592, 25-oct.-2017 19:06
'♥ versión: 586, 6-oct.-2017 07:11
Public Class ClaseDestinos
	Public Shared Function Seleccione_Destino(Optional CualDestino As Integer = 0, Optional IdCuenta As Integer = 0, Optional Dimension As Integer = 1, Optional IdCentro As Integer = 0) As String
		If fDestiModal Is Nothing Then
			fDestiModal = New fDestinos
		End If

		fDestiModal.SoyModal = True
		fDestiModal.NodoInicial = CualDestino
		fDestiModal.IdCuenta = IdCuenta
		fDestiModal.IdCentro = IdCentro
		fDestiModal.Dimension = Dimension
		If IdCuenta > 0 Then
			Dim Cod As String = "" & Obtenga_Dato(DtCta, "id=" & IdCuenta, "codigo")
			Dim Des As String = "" & Obtenga_Dato(DtCta, "id=" & IdCuenta, "descripcion")
			fDestiModal.Text = "Destino para Cuenta: " & Cod & " - " & Des & " - Dim: " & Dimension
		Else
			fDestiModal.Text = "Seleccione destino" & " - Dim: " & Dimension
		End If
		'jdms 592: no reducir pantalla
		'fDestiModal.Reducir_Pantalla()
		fDestiModal.ShowDialog()

		If fDestiModal.Tag.ToString.Contains("|") Then
			Return fDestiModal.Tag
		Else
			Return ""
		End If


	End Function

	Public Shared Sub Haga_Destinos_General(ByRef TxtCuenta As TextBox,
											ByRef Dest1 As Integer,
											ByRef Dest2 As Integer,
											ByRef Dest3 As Integer,
											ByRef Dest4 As Integer,
											Optional MostrarNoDestinos As Boolean = False,
											Optional IdCentro As Integer = 0)
		If Fin(DtCta) Then
			Cargar_Cuentas()
		End If

		Dim d1 As Integer
		Dim d2 As Integer
		Dim d3 As Integer
		Dim d4 As Integer

		If TxtCuenta.Text = "*" Then 'reportes
			d1 = 1
			d2 = 1
			d3 = 1
			d4 = 1
			GoTo Saltar
		End If


		If TxtCuenta.Text = "" Then
			If MostrarNoDestinos Then
				Mensaje("Falta cuenta contable para buscar destino")
			End If
			Exit Sub
		End If

		If TxtCuenta.Text <> "NO" Then
			Dim Dt As DataTable = Filtrar_DataTable(DtCta, "codigo='" & TxtCuenta.Text & "'")
			If Fin(Dt) Then
				Mensaje(Idi("No existe cuenta en rutina Haga_Destinos_General") & ": " & TxtCuenta.Text)
				Exit Sub
			End If
			d1 = ValD(Gdf(Dt, "d1"))
			d2 = ValD(Gdf(Dt, "d2"))
			d3 = ValD(Gdf(Dt, "d3"))
			d4 = ValD(Gdf(Dt, "d4"))
		Else 'viene de inventarios
			d1 = 1
		End If


		If d1 + d2 + d3 + d4 = 0 Then
			Dest1 = 0
			Dest4 = 0
			Dest3 = 0
			Dest4 = 0
			If MostrarNoDestinos Then
				Mensaje("Cuenta no maneja destinos")
			End If
			Exit Sub
		End If

Saltar:
		Dim fPed As New fPedirDestinos
		If ReglaDeNegocio(146, "destinos", "0") = "1" Then 'destino simple
			If TxtCuenta.Text = "*" Then
				fPed.Text = "Seleccione destino simple"
			Else
				fPed.Text = "Destino simple " & TxtCuenta.Text
			End If
		Else
			If TxtCuenta.Text = "*" Then
				fPed.Text = "Seleccione destinos"
			Else
				fPed.Text = "Destinos para " & TxtCuenta.Text
			End If
		End If

		fPed.D1 = d1
		fPed.D2 = d2
		fPed.D3 = d3
		fPed.D4 = d4
		fPed.IdCuenta = ValD(TxtCuenta.Tag)
		fPed.IdCentro = IdCentro


		fPed.LnkDestino1.Tag = Dest1
		fPed.LnkDestino2.Tag = Dest2
		fPed.LnkDestino3.Tag = Dest3
		fPed.LnkDestino4.Tag = Dest4

		fPed.ShowDialog()

		If ValD(fPed.Tag) = 1 Then
			Dest1 = ValD(fPed.LnkDestino1.Tag)
			Dest2 = ValD(fPed.LnkDestino2.Tag)
			Dest3 = ValD(fPed.LnkDestino3.Tag)
			Dest4 = ValD(fPed.LnkDestino4.Tag)
		ElseIf ValD(fPed.Tag) = -1 Then 'presionó cancel y las cuentas no están bien
			TxtCuenta.Text = "" 'se borra la cuenta
			TxtCuenta.Focus()
		End If

	End Sub
End Class
