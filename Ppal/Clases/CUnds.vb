' Version: 694, 28-sep.-2018 12:57
'♥ versión: 586, 6-oct.-2017 07:11
Public Class CUnds
	Public Shared Function FormatearUND(Sender, Optional Cua = 16) As String
		If Sender = 0 Then
			Return ""
		End If

		Dim Res As String = ""
		Res = ValD(Sender).ToString("#0." & Strings.StrDup(Cua, "0"))
		Dim J As Integer = -1
		For I As Integer = Len(Res) To 1 Step -1
			If Mid(Res, I, 1) <> "0" And Mid(Res, I, 1) <> "," And Mid(Res, I, 1) <> "." Then
				J = I
				Exit For
			End If
			If Mid(Res, I, 1) = "," Or Mid(Res, I, 1) = "." Then
				J = I - 1
				Exit For
			End If
		Next
		If J > 0 Then
			Res = Mid(Res, 1, J)
		End If
		'If Strings.Left(Res, Len(Res)) = "," Or Strings.Left(Res, Len(Res)) = "." Then
		'    Res = Mid(Res, 1, J)
		'End If
		Return Res



	End Function
	Public Shared Sub LlenarComboUND(CbUnd As ComboBox, DtI As DataTable, Optional SoloCajas As Boolean = False, Optional EsCompra As Boolean = False)
		Dim IndexCompra As Integer = -1

		CbUnd.Items.Clear()
		If Fin(DtI) Then Exit Sub

		Dim Farmacia As Boolean
		Farmacia = ReglaDeNegocio(153, "farmacia", "0") = "1"

		If Not SoloCajas Then
			If IsDBNull(Gdf(DtI, "idu1")) Then
				CbUnd.Items.Add(New DataDescription(1, "Und=1"))
			Else
				If Farmacia Then
					Dim canu = ValD(Gdf(DtI, "und_cant")) 'truco pa los ítems que no tiene cantidad en la und 0
					If ValD(canu) = 0 Then canu = 1
					CbUnd.Items.Add(New DataDescription(Gdf(DtI, "idu1"), Gdf(DtI, "desu1") & "=" & canu))
					IndexCompra = 0
				Else
					CbUnd.Items.Add(New DataDescription(Gdf(DtI, "idu1"), Gdf(DtI, "desu1") & "=1"))
				End If
			End If
		End If

		If ValD(Gdf(DtI, "und_cant")) > 0 And ValD(Gdf(DtI, "idu2")) > 0 Then
			If Farmacia Then
				CbUnd.Items.Add(New DataDescription(Gdf(DtI, "idu2"), Gdf(DtI, "desu2").Replace("=", "-") & "=1"))
			Else
				CbUnd.Items.Add(New DataDescription(Gdf(DtI, "idu2"), Gdf(DtI, "desu2").Replace("=", "-") & "=" & FormatearUND(ValD(Gdf(DtI, "und_cant")), 4)))
				IndexCompra = CbUnd.Items.Count - 1
			End If
		End If


		If Not SoloCajas Then
			If ValD(Gdf(DtI, "und_cant3")) > 0 And ValD(Gdf(DtI, "idu3")) Then
				CbUnd.Items.Add(New DataDescription(Gdf(DtI, "idu3"), Gdf(DtI, "desu3").Replace("=", "-") & "=" & FormatearUND(ValD(Gdf(DtI, "und_cant3")), 16)))
			End If
			If ValD(Gdf(DtI, "und_cant4")) > 0 And ValD(Gdf(DtI, "idu4")) Then
				CbUnd.Items.Add(New DataDescription(Gdf(DtI, "idu4"), Gdf(DtI, "desu4").Replace("=", "-") & "=" & FormatearUND(ValD(Gdf(DtI, "und_cant4")), 16)))
			End If
		End If

		If CbUnd.Items.Count > 0 Then 'asignar la u/m de compra
			If EsCompra And IndexCompra > 0 Then
				CbUnd.SelectedIndex = IndexCompra
			Else
				CbUnd.SelectedIndex = 0
			End If
		Else 'por las últimas
			CbUnd.Items.Add(New DataDescription(1, "Und=1"))
			CbUnd.SelectedIndex = 0
		End If


	End Sub
	Public Shared Function ObtengaCant(CbUnd As ComboBox, Optional Cant As Double = 1) As Double
		If CbUnd.SelectedIndex < 0 Then
			Return 0
		End If
		Dim Ini As Short = InStr(CbUnd.Text, "=")

		Dim Farmacia As Boolean
		Farmacia = ReglaDeNegocio(153, "farmacia", "0") = "1"

		If Farmacia Then
			Dim Ini2 As Short = 0
			Ini2 = InStr(CbUnd.Items(0).ToString, "=")
			Dim can As Integer = 0
			can = ValD(Mid(CbUnd.Items(0).ToString, Ini2 + 1))

			Return 1 / can * ValD(Mid(CbUnd.Text, Ini + 1)) * Cant
			'Return 1 / ValD(Mid(CbUnd.Text, Ini + 1)) * Cant
		Else
			Return ValD(Mid(CbUnd.Text, Ini + 1)) * Cant
		End If

	End Function
	Public Shared Function ObtengaNombre(CbUnd As ComboBox) As String
		If CbUnd.SelectedIndex < 0 Then
			Return ""
		End If
		Dim Ini As Short = InStr(CbUnd.Text, "=")

		Return Strings.Left(CbUnd.Text, Ini - 1)

	End Function

	'Public Shared Sub PongaIndex(CbUnd As ComboBox, Und As String)
	'    If Und = "" Then
	'        CbUnd.SelectedIndex = 0
	'        Exit Sub
	'    End If
	'    For I As Integer = 0 To CbUnd.Items.Count - 1
	'        If UCase(Mid(CbUnd.Items(I), 1, Len(Und))) = UCase(Und) Then
	'            CbUnd.SelectedIndex = I
	'            Exit Sub
	'        End If
	'    Next

	'End Sub

	Public Shared Function Buscar_Item_Principio_Activo(Bodega As Integer, Optional BuscarFijo As String = "") As String
		Dim Buscar As String = GetSett(DiegoSet, "ultprincipio", "")
		Dim Result As String = ""

Repetir:
		If BuscarFijo <> "" Then
			Buscar = BuscarFijo
		Else
			Buscar = Inputbox2(Result & "Ingrese parte del principio activo, concentración y/o forma farmacéutica (utilice + para búsqueda compuesta)",, Buscar).Trim
		End If

		If Buscar = "" Then
			Return ""
		End If

		Dim Bus() As String = Buscar.Split("+")
		If Bus.Length > 4 Then
			Result = Idi("MAXIMO 3 SIGNOS +") & DMScr(2)
			GoTo Repetir
		End If
		Dim Bus1 As String = ""
		Dim Bus2 As String = ""
		Dim Bus3 As String = ""
		Dim Bus4 As String = ""
		If Bus.Length > 0 Then
			Bus1 = Bus(0).Trim
		End If
		If Bus.Length > 1 Then
			Bus2 = Bus(1).Trim
		End If
		If Bus.Length > 2 Then
			Bus3 = Bus(2).Trim
		End If
		If Bus.Length > 3 Then
			Bus4 = Bus(3).Trim
		End If
		Try
			SiReloj()
			Dim Dt As New DataTable
			Abrir(Dt, ArmeSQL("GetCotItemsBuscarPrincipio",
				  Numero_Empresa, qqNum,
				  Bus1, qqTex,
				  Bus2, qqTex,
				  Bus3, qqTex,
				  Bus4, qqTex)
				  )

			NoReloj()

			If Fin(Dt) Then
				Result = "*** " & Idi("No encontró resultados") & " ***" & DMScr(2)
				If BuscarFijo <> "" Then
					Mensaje(Result)
					Return ""
				Else
					GoTo Repetir
				End If
			Else
				If BuscarFijo = "" Then
					SaveSett(DiegoSet, "ultprincipio", Buscar)
				End If

				Dim Cual As String
				If BuscarFijo = "" Then
					Cual = Ventana(Dt, "Seleccione grupo para ver ítems", True, "codigo")
				Else
					Cual = BuscarFijo
				End If


				If Cual = "" Then
					Return ""
				End If

				SiReloj()
				Abrir(Dt, ArmeSQL("GetCotItemsBuscarPrincipioItems",
				  Numero_Empresa, qqNum,
				  Cual, qqTex,
				  Bodega, qqNum)
				  )

				NoReloj()

				If Fin(Dt) Then
					Mensaje("No encontró items")
				Else
					If Bodega = 0 Then 'por si viene del sugerido
						Dt.Columns.Remove("stock")
					End If
					Return Ventana(Dt, IIf(BuscarFijo = "", Idi("Seleccione ítem"), Idi("Items de") & " " & Cual), True, "codigo")
				End If
			End If

		Catch ex As Exception
			NoReloj()
			MostrarError("CUnds", "Buscar_Item_Principio_Activo", ex.Message)

		End Try
	End Function
End Class
