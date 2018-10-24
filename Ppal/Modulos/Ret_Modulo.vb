' Version: 681, 20-ago.-2018 20:08
' Version: 652, 10-may.-2018 12:48
' Version: 636, 9-mar.-2018 13:03
' Version: 628, 23-feb.-2018 12:35
' Version: 609, 26-dic.-2017 13:04
'♥ versión: 586, 6-oct.-2017 07:11
Public Module Ret_Modulo
	Public Ret1(6) As Double
	Public TitRet(5) As String
	Public DtTributItem As New DataTable
	Dim CualReteIvaBase As String
	Dim TxtSubtotal As Double
	Dim vSubTot As Double
	Dim vIva As Double

	Public Sub Ret_Inicie(ByVal Forma As Form)
		TitRet(0) = ReglaDeNegocio(3, "ret1", "")
		TitRet(1) = ReglaDeNegocio(3, "ret2", "")
		TitRet(2) = ReglaDeNegocio(3, "ret3", "")
		TitRet(3) = ReglaDeNegocio(3, "ret4", "")
		TitRet(4) = ReglaDeNegocio(3, "ret5", "")
		TitRet(5) = ReglaDeNegocio(3, "ret6", "")

		If Forma Is Nothing Then
			Exit Sub
		End If

		For J As Integer = 1 To 2
			For I As Integer = 1 To 6
				Dim Adi As String = ""
				If J = 2 Then Adi = I.ToString
				Try
					Dim t1 As TextBox = DirectCast(Forma.Controls.Find("TxtRet" & I.ToString & Adi, True)(0), TextBox)
					Dim l1 As Label = DirectCast(Forma.Controls.Find("LblRet" & I.ToString & Adi, True)(0), Label)

					l1.Text = TitRet(I - 1)
					If l1.Text.Trim = "" Then
						t1.Visible = False
						t1.Tag = "N" 'para que no lo vuelva a prender
					End If
				Catch
				End Try
			Next
		Next

	End Sub
	Public Function Ret_Haga_Retenciones(ByVal ValSubTot As Double,
										 ByVal ValIva As Double,
										 Optional BaseAprox As Integer = 0,
										 Optional Exento As Boolean = False,
										 Optional ProtegerRet As Boolean = False,
										 Optional factor As Decimal = 1,
										 Optional NueR1 As Decimal = 0,
										 Optional NueR2 As Decimal = 0,
										 Optional NueR3 As Decimal = 0,
										 Optional NueR4 As Decimal = 0,
										 Optional NueR5 As Decimal = 0,
										 Optional NueR6 As Decimal = 0
										 ) As Double
		If Exento Then
			If ReglaDeNegocio(102, "si_ret", "0") = "1" Then 'JDMS 609, regla nueva, MAFE, condor
				Exento = False
			End If
		End If


		Asigne_Cual_es_Retfte_Retiva()
		CualReteIvaBase = ReglaDeNegocio(3, "retivabase", "0")

		TxtSubtotal = 0

		'rml: 20170512
		'vSubTot = ValSubTot
		'vIva = ValIva
		vSubTot = ValSubTot * factor
		vIva = ValIva * factor
		'/rml

		Dim RetProtege = Ret1(CualEsRetFte) 'se protege
		Dim IVAProtege = Ret1(CualEsRetIva) 'se protege
		For I As Integer = 1 To 6
			Ret1(I) = 0
		Next

		If Exento Then
			Return TxtSubtotal
		End If

		If ProtegerRet Then
			Ret1(CualEsRetFte) = RetProtege 'devuelvo la guardada
			Ret1(CualEsRetIva) = IVAProtege 'devuelvo la guardada
		End If

		'jdms 628
		Dim NR(6) As Decimal
		NR(1) = NueR1
		NR(2) = NueR2
		NR(3) = NueR3
		NR(4) = NueR4
		NR(5) = NueR5
		NR(6) = NueR6

		If DtTributario.Rows.Count > 0 Then
			For I As Integer = 1 To 6
				Ret_Sume_Ret(I,
							 Ret1(I),
							 ValD("" & Gdf(DtTributario, "p_ret" & I.ToString)),
							 ValD("" & Gdf(DtTributario, "t_ret" & I.ToString)),
							 ValD("" & Gdf(DtTributario, "m_ret" & I.ToString)),
							 BaseAprox,
							 ProtegerRet,
							 NR(I))
			Next
		End If

		Return TxtSubtotal

	End Function

	Private Sub Ret_Sume_Ret(ByVal Cual As Integer,
							 ByRef Retencion As Double,
							 ByVal PorcentajeRet As Double,
							 ByVal TipoRet As Integer,
							 ByVal MinimoValor As Double,
							 BaseAprox As Integer,
							 ProtegerRet As Boolean,
							 NueRet As Decimal)

		Dim ValorUsar = ValD(vSubTot)
		Dim BaseComparable = ValD(vSubTot)


		'especial para retención iva
		If CualEsRetIva = Cual Then
			ValorUsar = ValD(vIva)  'calcular sobre valor iva
			If CualReteIvaBase <> "1" Then
				BaseComparable = ValD(vIva) 'comparar con el subtotal, este es el default
			End If
		End If

		'jdms 628: no mover: poner nueva retención ingresada por pantalla
		If NueRet <> 0 Then
			Retencion = NueRet
			If ValD(TipoRet) = 4 Then
				'la pongo negativa de forma obligada con el ABS
				'Retencion = Retencion * -1
				Retencion = Math.Abs(Retencion) * -1
				TxtSubtotal = ValD(TxtSubtotal) + Retencion
			End If
		Else
			If ValD(PorcentajeRet) > 0 And ValD(TipoRet) > 1 And BaseComparable >= MinimoValor Then
				If ProtegerRet And (Cual = CualEsRetFte Or Cual = CualEsRetIva) Then 'no tocarla de a mucho
					If BaseAprox <> 0 Then
						Retencion = Aproximar(Retencion, BaseAprox)
					End If
				Else
					If BaseAprox <> 0 Then
						Retencion = Aproximar(ValD(ValorUsar) * ValD(PorcentajeRet) / 100, BaseAprox)
					Else
						Retencion = ValD(ValorUsar) * ValD(PorcentajeRet) / 100
					End If
				End If



				If ValD(TipoRet) = 4 Then
					'la pongo negativa de forma obligada con el ABS
					'Retencion = Retencion * -1
					Retencion = Math.Abs(Retencion) * -1
					TxtSubtotal = ValD(TxtSubtotal) + Retencion
				End If
			End If
		End If




	End Sub
	Public Sub Leer_Conceptos_Ret()
		'este es el que usar ecuador con el formulario y el anexo
		If DtConcepRet Is Nothing Then
			Dim Habia = SiRelojCond()
			Abrir(DtConcepRet, "GetCotConceptosRet " & Numero_Empresa)
			SiRelojCond(Habia)
		End If

	End Sub

	Public Function Ret_Mostrar_Explicacion_Tributaria()
		Try
			If DtTributario.Rows.Count = 0 Then
				Return "No hay definición tributaria"
			Else
				Dim Texto As String = ""
				For I As Integer = 1 To 6
					If ValD(Gdf(DtTributario, "p_ret" & I.ToString)) > 0 Then
						'Dim Lbl As Label = DirectCast(Me.Controls.Find("LblRet" & I.ToString, True)(0), Label)

						Texto &= ReglaDeNegocio(3, "ret" & I.ToString, "") & ": " & ValD(Gdf(DtTributario, "p_ret" & I.ToString)) & "%"
						Select Case ValD(Gdf(DtTributario, "t_ret" & I.ToString))
							Case 0 : Texto &= ", No hace nada"
							Case 1 : Texto &= ", uso libre"
							Case 2 : Texto &= ", Contabilizar"
							Case 4 : Texto &= ", Contab y Descontar"
						End Select
						If ValD(Gdf(DtTributario, "m_ret" & I.ToString)) > 0 Then
							Texto &= ", Valor mínimo " & FormatoMoneda(ValD(Gdf(DtTributario, "m_ret" & I.ToString)))
						End If
						Texto &= vbNewLine
					End If

				Next
				If ValD(CualEsRetIva) > 0 Then
					Texto &= "Campo retiva: " & CualEsRetIva & DMScr()
				End If
				Return Texto
			End If

		Catch ex As Exception
			MostrarError("Ppal", "Mostrar_Explicacion_Tributaria", ex.Message)
			Return "error"
		End Try

	End Function

End Module
