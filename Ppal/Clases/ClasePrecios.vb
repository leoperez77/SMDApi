' Version: 687, 5-sep.-2018 13:13
' Version: 681, 20-ago.-2018 20:08
' Version: 673, 3-ago.-2018 14:58
' Version: 647, 24-abr.-2018 12:31
' Version: 645, 17-abr.-2018 12:53
' Version: 645, 17-abr.-2018 12:40
' Version: 639, 22-mar.-2018 12:39
' Version: 636, 9-mar.-2018 13:03
' Version: 632, 1-mar.-2018 13:22
' Version: 630, 24-feb.-2018 12:28
' Version: 602, 1-dic.-2017 12:55
' Version: 601, 30-nov.-2017 10:51
' Version: 596, 9-nov.-2017 19:28
' Version: 595, 8-nov.-2017 08:03
' Version: 595, 7-nov.-2017 15:15
' Version: 595, 7-nov.-2017 11:14
'♥ versión: 586, 6-oct.-2017 07:11

Public Class ClasePrecios


	Public Shared Function TotalDocumento(
											Tasa As Double,
											Excento As Boolean,
											AproximarCuantoBodega As Short,
											PropinaPorcen As Double,
											SumaPropina As Double,
											TablaTributariaCliente As DataTable,
											TablaItemsDocumento As DataTable) As DataTable

		DtTributario = TablaTributariaCliente

		Static Item_Ajuste_Cod As String
		Static SiAprox As Boolean
		Static NoAproxIVA As Boolean
		If Item_Ajuste_Cod Is Nothing Then
			Item_Ajuste_Cod = ReglaDeNegocio(108, "item", "")
			SiAprox = ReglaDeNegocio(110, "vta", "0") = "1"
			'para que el iva lo deje con centavos
			NoAproxIVA = ReglaDeNegocio(110, "ex_iva", "0") = "1"
			DebugJD("NoAproxIVA:" & NoAproxIVA.ToString)
		End If

		Dim TotTot As Double = 0
		Dim TotSub As Double = 0
		Dim TotDescu As Double = 0
		Dim TotDescu2 As Double = 0
		Dim TotIva As Double = 0
		Dim TotIva3 As Double = 0
		Dim TotIva4 As Double = 0
		Dim TotIva2 As Double = 0
		Dim ExcluirAjuste As Double = 0

		Dim LblTotLineas As Integer = 0
		Dim LblTotCant As Double = 0

		Dim RetPorItem As Boolean = ReglaDeNegocio(177, "ret_item_vta", "0") = "1"
		If RetPorItem Then
			If DtRetxItem Is Nothing Then
				DtRetxItem = New DataTable
				DtRetxItem.Columns.Add("id_ret_fte", System.Type.GetType("System.Int32"))
				DtRetxItem.Columns.Add("ret_fte")
				DtRetxItem.Columns.Add("valor")
			End If
			DtRetxItem.Rows.Clear()
		End If



		For Each Fi As DataRow In TablaItemsDocumento.Rows

			LblTotLineas += 1
			LblTotCant += ValD(Fi("cantidad"))

			'esto se hizo para taller nada más
			If Excento Then
				Fi("iva") = 0
				Fi("iva3") = 0
				Fi("iva4") = 0
			End If

			'quitar el descuento escalonado al precio
			If ValD(Fi("descu_escal")) < 0 Then 'si es menor a cero es por que es descuento en valor
				Fi("precio") += ValD(Fi("descu_escal"))
			ElseIf ValD(Fi("descu_escal")) > 0 Then 'descuento en %
				Fi("precio") *= (1 - ValD(Fi("descu_escal")) / 100)
			End If

			Dim PreLis As Double

			PreLis = ValD(Fi("precio_lista"))
			If PreLis = 0 Then
				PreLis = ValD(Fi("precio")) 'precio digitado
			End If

			If Fi("codigo") = Item_Ajuste_Cod Then 'sumar excluir
				ExcluirAjuste += Fi("precio")
			End If

			If Regla_PrecioConIva_14() Then
				If ValD(Fi("precio")) < PreLis Then
					Dim EsteDescu As Double = (ValD(PreLis) - ValD(Fi("precio"))) * ValD(Fi("cantidad"))
					TotDescu += EsteDescu
					Dim IvaFact = (1 + ValD(Fi("iva") / 100)) * (1 + ValD(Fi("iva3") / 100)) * (1 + ValD(Fi("iva4") / 100))
					Dim Vtemp As Double = (ValD(PreLis) * ValD(Fi("cantidad")) - EsteDescu) / IvaFact
					'TotSub += ((ValD(PreLis) * ValD(Fi("cantidad")))) / (1 + ValD(Fi("iva") / 100))
					TotSub += Vtemp + EsteDescu
					TotIva += Vtemp * (ValD(Fi("iva")) / 100)
					TotIva3 += Vtemp * (ValD(Fi("iva3")) / 100)
					TotIva4 += Vtemp * (ValD(Fi("iva4")) / 100)
				Else 'esta línea sumarla sobre el total
					TotSub += (ValD(Fi("precio")) * ValD(Fi("cantidad"))) / (1 + ValD(Fi("iva") / 100))
					'TotIva += (ValD(PreLis) * ValD(Fi("cantidad"))) - (ValD(PreLis) * ValD(Fi("cantidad"))) / (1 + (ValD(Fi("iva")) / 100))
					TotIva += (ValD(Fi("precio")) - (ValD(Fi("precio")) / (1 + (ValD(Fi("iva")) / 100)))) * ValD(Fi("cantidad"))
					TotIva3 += (ValD(Fi("precio")) - (ValD(Fi("precio")) / (1 + (ValD(Fi("iva3")) / 100)))) * ValD(Fi("cantidad"))
					TotIva4 += (ValD(Fi("precio")) - (ValD(Fi("precio")) / (1 + (ValD(Fi("iva4")) / 100)))) * ValD(Fi("cantidad"))
				End If
			Else
				If ValD(Fi("precio")) < PreLis Then
					TotDescu += (ValD(PreLis) - ValD(Fi("precio"))) * ValD(Fi("cantidad"))
					TotSub += (ValD(PreLis) * ValD(Fi("cantidad")))
				Else 'esta línea sumarla sobre el total
					TotSub += (ValD(Fi("precio")) * ValD(Fi("cantidad")))
				End If

				Dim Iva2 As Double = 0
				If TablaItemsDocumento.Columns.Contains("iva2") Then
					'TotIva2 += ValD(Fi("precio")) * ValD(Fi("cantidad")) * (ValD(Fi("iva2")) / 100)
					'esto se hizo para taller nada más
					If Excento Then
						Fi("iva2") = 0
					End If

					TotIva2 += ValD(Fi("iva2"))
					Iva2 = ValD(Fi("iva2"))
				End If

				TotIva += (ValD(Fi("precio")) * ValD(Fi("cantidad")) + Iva2) * (ValD(Fi("iva")) / 100)
				TotIva3 += (ValD(Fi("precio")) * ValD(Fi("cantidad")) + Iva2) * (ValD(Fi("iva3")) / 100)
				TotIva4 += (ValD(Fi("precio")) * ValD(Fi("cantidad")) + Iva2) * (ValD(Fi("iva4")) / 100)
			End If

			If RetPorItem Then
				Dim Ret_Fte As Double = ValD(Fi("ret_fte")) 'ValD(Obtenga_Dato_Item(Fi("codigo"), "ret_fte"))
				Dim Id_Ret_Fte As Integer = ValD(Fi("id_ret_fte")) 'ValD(Obtenga_Dato_Item(Fi("codigo"), "ret_fte"))

				Dim Vv = ValD(Fi("precio")) * ValD(Fi("cantidad"))

				Dim Esta As Boolean = False
				For Each Fir As DataRow In DtRetxItem.Rows
					If ValD(Fir("id_ret_fte")) = Id_Ret_Fte Then
						Fir("valor") += ValD(Vv)
						Fir.AcceptChanges()
						Esta = True
						Exit For
					End If
				Next
				If Not Esta Then
					DtRetxItem.Rows.Add(Id_Ret_Fte, Ret_Fte, ValD(Vv))
				End If
			End If

			'TotTot = TotTot + ValD(fi( "total"))

		Next

		'APROXIMACIONES
		'TODO: 7-jun-11 quitar esto o dejarlo, probar con ana
		If SiAprox And Not NoAproxIVA Then
			TotIva = Aproximar(TotIva, 1)
			TotIva3 = Aproximar(TotIva3, 1)
			TotIva4 = Aproximar(TotIva4, 1)
			TotIva2 = Aproximar(TotIva2, 1)
			'TotIva = Math.Truncate(TotIva)
		End If

		'le quito el ajuste de servitractor, 8-oct-2016
		TotSub += ExcluirAjuste

		TotTot = TotSub - TotDescu + TotIva + TotIva2 + TotIva3 + TotIva4


		'hacer parte juridica y tributaria
		'Dim ValRet = Ret_Haga_Retenciones(TotSub - TotDescu - ExcluirAjuste, TotIva, IIf(SiAprox, 1, 0), Excento)
		Dim ValRet = Ret_Haga_Retenciones(TotSub - TotDescu, TotIva, IIf(SiAprox, 1, 0), Excento)

		If RetPorItem And Ret1(1) <> 0 Then
			'comparar con el mínimo
			If Not Fin(DtTributItem) Then
				For Each Fi As DataRow In DtRetxItem.Rows
					'Dim Mini As Double = ValD(Obtenga_Dato(DtTributItem, "id_cot_item_tipo_ret=" & ValD(Fi("id_ret_fte")), "minimo"))
					Dim Mini As Double = ValD(Obtenga_Dato(DtTributItem, "id=" & ValD(Fi("id_ret_fte")), "minimo"))

					Fi("ret_fte") = ValD(Obtenga_Dato(DtTributItem, "id=" & ValD(Fi("id_ret_fte")), "porcentaje")) 'JFG-673 Se actualiza el porcentaje por si cambió

					If Fi("valor") < Mini Then
						Fi("valor") = 0

						Fi.AcceptChanges()
					End If
				Next
			End If

			Dim Ret = 0
			For Each Fi As DataRow In DtRetxItem.Rows
				Ret += Fi("valor") * Fi("ret_fte") / 100
			Next
			Ret1(1) = Ret
			ValRet = Ret_Haga_Retenciones(TotSub - TotDescu, TotIva, IIf(SiAprox, 1, 0), Excento, True)
		End If


		'terminar de montar ret item


		TotTot += ValRet


		'2012/03/11: JDMS: aproximo el valor total
		Dim Ajuste As Double = 0
		If AproximarCuantoBodega > 0 And Tasa = 1 Then 'solo si la tasa es mayor 1 o menos. Se pone por que la conversión a otras monedas trabaja mal
			Dim ValorTotal As Double = Aproximar(TotTot, CShort(AproximarCuantoBodega))
			Ajuste = ValorTotal - ValD(TotTot)
			TotTot = ValorTotal
		End If



		'calcular el total mas propina y ajuste
		Dim PropinaValor As Double
		If SumaPropina < 0 Then 'esto sucede cuando estoy visualizando una venta
			'PropinaValor = (TotTot * ValD(PropinaPorcen) / 100)
			'a partir de hoy la propina sobre el subtotal, bellapasta: 7-nov-2014
			PropinaValor = ((TotSub - TotDescu) * ValD(PropinaPorcen) / 100)
		Else
			PropinaValor = SumaPropina
		End If


		Dim Dt As New DataTable
		Dt.Columns.Add("TotTot", System.Type.GetType("System.Double"))
		Dt.Columns.Add("TotIva", System.Type.GetType("System.Double"))
		Dt.Columns.Add("TotIva2", System.Type.GetType("System.Double"))
		Dt.Columns.Add("TotSub", System.Type.GetType("System.Double"))
		Dt.Columns.Add("TotAntesIva", System.Type.GetType("System.Double"))
		Dt.Columns.Add("TotDescu", System.Type.GetType("System.Double"))
		Dt.Columns.Add("TotCan", System.Type.GetType("System.Double"))
		Dt.Columns.Add("TotLin", System.Type.GetType("System.Int32"))
		Dt.Columns.Add("ValRet", System.Type.GetType("System.Double"))
		Dt.Columns.Add("Ajuste", System.Type.GetType("System.Double"))
		Dt.Columns.Add("PropinaValor", System.Type.GetType("System.Double"))
		Dt.Columns.Add("TotIva3", System.Type.GetType("System.Double"))
		Dt.Columns.Add("TotIva4", System.Type.GetType("System.Double"))
		Dt.Rows.Add(TotTot, TotIva, TotIva2, TotSub, TotSub - TotDescu, TotDescu, LblTotCant, LblTotLineas, ValRet, Ajuste, PropinaValor, TotIva3, TotIva4)

		Return Dt

	End Function
	Public Shared Function ObtengaPrecioItem(CodItem As String,
									  IdBod As Integer,
									  IdPrecioNro As Integer,
									  ClienteCosto As Boolean,
									  Optional MuchosDatos As Boolean = False,
									  Optional IdCli As Integer = 0,
									  Optional CostoPromedio As Double = -1,
									  Optional CostoUltimo As Double = -1,
									  Optional Emergencia As Boolean = False
									) As DataTable




		'NOTA MUY IMPORTANTE
		'NOTA MUY IMPORTANTE
		'NOTA MUY IMPORTANTE
		'NOTA MUY IMPORTANTE
		'
		'
		'JDMS: 11 de Agosto de 2017
		'Si hace cambios en esta rutina, debe cambiar también la lógica del SP GetCotPrecioItem y del reporte 2554
		'
		'
		'NOTA MUY IMPORTANTE
		'NOTA MUY IMPORTANTE
		'NOTA MUY IMPORTANTE
		'NOTA MUY IMPORTANTE

		'cuadrar la bodega
		Dim VengoDeBusquedaItems As Boolean = False
		Dim FuePrecioDePromedio As Boolean = False
		If IdBod < 0 Then
			VengoDeBusquedaItems = True
			IdBod = Math.Abs(IdBod)
		End If


		'JDMS 595
		If DtItem.Rows.Count = 0 Then
			Cargar_Items()
		End If


		If DtPrecios.Rows.Count = 0 Then
			Abrir(DtPrecios, "Exec GetCotItemCategoriaListasTodas " & Numero_Empresa)
		End If

		'determinar factor emergencia por si acaso
		Dim FactorEmerg As Double = 0
		If Emergencia Then
			Dim Porce As String = 0
			Porce = ReglaDeNegocio(142, "emergencia", 0)
			If ValD(Porce) > 0 And ValD(Porce) <= 100 Then
				FactorEmerg = ValD(Porce)
			End If
		End If


		Dim Dt As New DataTable
		Dim UsarPrecioFijo As Boolean


		'Dim Excento As Boolean
		Dim NegarLogistica As Boolean = False
		Dim Precio As Decimal = 0
		Dim Explica As String = ""

		Dim UsarListaPrecios As Boolean = ReglaDeNegocio(74, , "0") = "1"
		If UsarListaPrecios And IdPrecioNro = 0 Then 'no dejarlo pasar
			Dt.Columns.Add("error")
			Dt.Rows.Add("El cliente debe tener una lista de precios")
			Return Dt
		End If


		Dim Dr As DataRow = DtItem.Rows.Find(CodItem)


		If Dr Is Nothing Then
			Dt.Columns.Add("error")
			Dt.Rows.Add("Item no existe")
			Return Dt
		End If
		Dim IdItem As Integer = ValD(Dr("id"))
		UsarPrecioFijo = ValD(Dr("usar_precio_fijo")) = 1
		'Excento = ValD(Dr("excento")) = 1


		'dado que el ultimo costo está en cada bodega, debemos leer la bodega con el último costo
		Try
			If CostoUltimo < 0 Then 'viene de busitem para que lo busque, pues si viene del 13 ya trae el costo de la bodega correcto
				If DtItemCosBod Is Nothing Then
					'Abrir(DtItemCosBod, "Select id_cot_bodega,id_cot_item,costo_compra from cot_item_bodega where id_cot_bodega=" & IdBod)
					Abrir(DtItemCosBod, "Select id_cot_bodega,id_cot_item,costo_compra=costo_compra*(1-(ultimo_dcto_compra/100)) from cot_item_bodega where id_cot_bodega=" & IdBod)
					Dim PrimaryKeyColumns(0) As DataColumn
					PrimaryKeyColumns(0) = DtItemCosBod.Columns("id_cot_bodega,id_cot_item")
					DtItemCosBod.PrimaryKey = PrimaryKeyColumns
				Else
					If Obtenga_Dato(DtItemCosBod, "id_cot_bodega=" & IdBod, "id_cot_item") Is DBNull.Value Then
						Dim dtc As New DataTable
						'Abrir(dtc, "Select id_cot_item,id_cot_bodega,costo_compra from cot_item_bodega where id_cot_bodega=" & IdBod)
						Abrir(dtc, "Select id_cot_item,id_cot_bodega,costo_compra=costo_compra*(1-(ultimo_dcto_compra/100)) from cot_item_bodega where id_cot_bodega=" & IdBod)
						'DtItemCosBod.Merge(dtc)
						MergeDMS(DtItemCosBod, dtc)
					End If
				End If
				'traer el costo de la bodega
				Dim coscos As Double = ValD(Obtenga_Dato(DtItemCosBod, "id_cot_bodega=" & IdBod & " and id_cot_item=" & IdItem, "costo_compra"))
				If coscos > 0 Then
					CostoUltimo = coscos
				Else 'sino tiene en esta bodega, coger el que traia negativo convirtiéndolo
					CostoUltimo *= -1
				End If
			End If
		Catch ex As Exception
			MostrarError("ClasePrecios", "ObtengaPrecioItem:Buscar costo ultimo", ex.Message)
		End Try
		'/dado que el ultimo costo está en cada bodega, debemos leer la bodega con el último costo


		Dim CostoUsado As String = "No"
		Dim FactorUsado As String = "No"
		Static Item_Ajuste_Cod As String
		If Item_Ajuste_Cod Is Nothing Then
			Item_Ajuste_Cod = ReglaDeNegocio(108, "item", "")
		End If
		If CodItem = Item_Ajuste_Cod Then
			Precio = 0
			GoTo Saltar
		End If

		If CostoUltimo = -1 Then
			CostoUltimo = ValD(Dr("ultimo_costo"))
		End If

		If ClienteCosto Then
			Explica &= "ClienteCosto,"
			Precio = CostoUltimo
			CostoUsado = CostoUltimo
			GoTo Saltar
		End If




		'obtener precio
		Dim Cate As Integer = 0
		Dim CostoUsar As Double = 0
		If (IdPrecioNro = -1 Or (IdPrecioNro > 0 And UsarListaPrecios)) And
		   (CostoUltimo > 0 Or CostoPromedio > 0 Or ValD(Dr("precio")) > 0) And
		   (Not UsarPrecioFijo) _
		Then

			Dim Factor As Double = 1 'para sumarle el iva al costo
			'If Not Excento And (Sector_Empresa = Sector.Pos_Generico Or Regla_SoyRestaurante_17()) Then
			If IdPrecioNro > 0 Then 'buscar el precio
				'por item en lugar de categoría
				Dim TexSQ = " And id_cot_item_listas=" & IdPrecioNro
				Dim Fac As String = ""
				Dim Faccc As Double = 0
				Dim DtE() As DataRow
				DtE = DtPrecios.Select("id_cot_item=" & IdItem & " and id_cot_bodega=" & IdBod & TexSQ)
				Dim TipoCosto As String = ""
				If DtE.Length > 0 Then
					Explica &= "ItemCateg+Bod,"
					Faccc = DtE(0)("factor")
					Busque_Emergencia(Emergencia, Faccc, ValD(DtE(0)("factor_emerg")))
					'If Emergencia Then
					'    If ValD(DtE(0)("factor_emerg")) = 0 Then DtE(0)("factor_emerg") = FactorEmerg
					'    If ValD(DtE(0)("factor_emerg")) > 0 Then Faccc = ValD(DtE(0)("factor_emerg"))
					'End If
					TipoCosto = ValD(DtE(0)("tipo"))
				Else
					DtE = DtPrecios.Select("id_cot_item=" & IdItem & " and id_cot_bodega is null" & TexSQ)
					If DtE.Length > 0 Then
						Explica &= "ItemCategTodBod,"
						Faccc = DtE(0)("factor")
						Busque_Emergencia(Emergencia, Faccc, ValD(DtE(0)("factor_emerg")))
						TipoCosto = ValD(DtE(0)("tipo"))
					Else
						'normal: categoría
						TexSQ &= " and id_cot_item_categoria=" & ValD(Dr("id_cot_item_categoria"))
						DtE = DtPrecios.Select("id_cot_bodega=" & IdBod & TexSQ)
						If DtE.Length > 0 Then
							Explica &= "Categ+Bod,"
							TipoCosto = ValD(DtE(0)("tipo"))
							Faccc = DtE(0)("factor")
							Busque_Emergencia(Emergencia, Faccc, ValD(DtE(0)("factor_emerg")))
						Else
							Explica &= "CategTodBod,"
							DtE = DtPrecios.Select("id_cot_bodega is null" & TexSQ)
							If DtE.Length > 0 Then
								Faccc = ValD(DtE(0)("factor"))
								Busque_Emergencia(Emergencia, Faccc, ValD(DtE(0)("factor_emerg")))
								TipoCosto = ValD(DtE(0)("tipo"))
							End If
						End If
					End If
				End If

				Fac = ValD(Faccc) * IIf(ValD(TipoCosto) = 1, -1, 1)

				If ValD(Fac) <> 0 Then
					Factor = ValD(Fac)
					Cate = ValD(Dr("id_cot_item_categoria"))
				End If

				Dim TipCos As String = ""
				'producir el verdadero factor
				Dim SobreCostoUltimo As Boolean = True
				If Factor < 0 Then 'costo promedio
					SobreCostoUltimo = False
					Factor = Factor * -1
					TipCos = "Fac/CosProm,"
				End If

				'truco para los costos iguales
				If Factor = 0.0001 And (TipoCosto = "0" Or TipoCosto = "1") Then
					Factor = 1 'cesar pidió: caso profesional cuando se quiere que sea el mismo costo
				Else
					If Factor >= 1 Then 'costo último
						Factor = 1 + (1 / ((100 - ValD(Factor)) / ValD(Factor)))
					End If
				End If
				'/truco para los costos iguales


				CostoUsar = CostoUltimo
				If SobreCostoUltimo = False Then
					'obtener el cos.prom
					If EstaEnLista(ValD(Dr("maneja_stock")), TipoStock.ControlaStock, TipoStock.AceptaStockNegativos) _
						And Not UsarPrecioFijo _
					Then
						If CostoPromedio = -1 Then
							If VengoDeBusquedaItems Then
								FuePrecioDePromedio = True
								CostoPromedio = 1
							Else
								Dim Ds As New DataSet
								Abrir(Ds, "Exec GetCotItemStockSimple4 " & IdBod & "," & IdItem.ToString & ",0,0,0,0,0")
								CostoPromedio = ValD(Gdf(Ds.Tables(0), "costo"))
							End If
						End If
					End If

					If CostoPromedio > 0 Then
						CostoUsar = CostoPromedio
					End If
				Else
					'Explica &= "Fac/CosUlt,"
				End If


				If Factor < 1 Then 'es precio
					If Factor = 0.9999 Then Factor = 1
					If Factor = 0.0001 Then Factor = 0 'cesar pidió
					CostoUsar = ValD(Dr("precio"))
					TipCos = "Fac/Precio,"
				End If

				If TipCos = "" Then TipCos = "Fac/CosUlt,"
				Explica &= TipCos

			Else
				'MaxDcto = -1 'quitar el descuento por ser costo
				Factor = 1
				CostoUsar = CostoUltimo
			End If
			CostoUsado = CostoUsar
			Precio = ValD(CostoUsar) * Factor
			FactorUsado = Factor
		Else
			Cate = 1
			Explica &= "PreFijoItem,"
			Precio = ValD(Dr("precio"))
			'esto no va, pues el else no lol tiene
			'If Regla_PrecioConIva_14() Then
			'    Precio = Precio / (1 + ValD(Dr("porcentaje")) / 100)
			'    Explica &= "Iva Incl,"
			'End If
			If Precio < 0 Then 'es tempario
				Dim DrBod() As DataRow
				DrBod = DtBodegas.Select("id=" & IdBod)
				Dim ValorHora As Double = 0
				If DrBod.Length > 0 Then
					ValorHora = ValD(DrBod(0)("valor_hora"))
				End If

				Explica = "Tempario " & Math.Abs(Precio) & " h"
				Dim VV As String = ValD(ReglaDeNegocio(106, "cli" & IdCli, "0"))
				If ValD(VV) > 0 Then
					ValorHora = ValD(VV)
				End If

				Precio = ValD(ValorHora) * Math.Abs(Precio) 'en el precio vienen las horas, entonces se multiplica

				GoTo Saltar2
			End If

		End If


		'la lista fija, segunda TAB del 0118
		If IdPrecioNro > 0 And
		   UsarListaPrecios And
		   Not UsarPrecioFijo Then
			'buscar este item en la lista del cliente para ver si tiene precio asignado en la bodega actual
			Dim DP As DataTable = Filtrar_DataTable(DtListasFijas, "id_cot_item=" & IdItem & " And id_cot_bodega=" & IdBod & " And id_cot_item_listas=" & IdPrecioNro)
			If Fin(DP) Then 'sino, buscarlo en todas las bodegas
				DP = Filtrar_DataTable(DtListasFijas, "id_cot_item=" & IdItem & " And id_cot_bodega is null And id_cot_item_listas=" & IdPrecioNro)
			End If
			If Not Fin(DP) Then
				If ValD(Gdf(DP, "precio")) > 0 Then
					NegarLogistica = Not IsDBNull(Gdf(DP, "negar"))
					Precio = ValD(Gdf(DP, "precio"))
					Explica = "PrecioFijoLista," 'se borra todo el explica
					CostoUsado = "No"
					FactorUsado = "No"
					Cate = 1
				End If
			End If
		End If

Saltar:

		Explica &= "Fact: " & FactorUsado & ","
		If Explica <> "" Then
			Explica = Mid(Explica, 1, Explica.Length - 1)
		End If

Saltar2:
		'si no encontró el factor en el 0118
		If Emergencia Then
			Dim Porce As String = ReglaDeNegocio(142, "emergencia", 0)
			If ValD(Porce) > 0 And ValD(Porce) <= 100 Then
				Precio *= 1 + (ValD(Porce) / 100)
				Explica &= ", Emerg/Rn142"
			End If
		End If

		'devolver datos
		Dt.Columns.Add("precio")
		Dt.Columns.Add("negarlogistica")
		Dt.Columns.Add("cate")
		Dt.Columns.Add("explica")
		If MuchosDatos Then
			Dt.Columns.Add("id")
			Dt.Columns.Add("maneja_stock")
			Dt.Columns.Add("cos_ult")
			Dt.Columns.Add("cos_prom")
			Dt.Columns.Add("costo_usado")
			Dt.Columns.Add("factor")
			Dt.Rows.Add(Precio, NegarLogistica, Cate, Explica, IdItem, ValD(Dr("maneja_stock")), CostoUltimo, CostoPromedio, CostoUsado, FactorUsado)
		Else
			Dt.Rows.Add(Precio, NegarLogistica, Cate, Explica)
		End If

		'JDMS 595: truco para el precio cuando es basado en el promedio
		If FuePrecioDePromedio Then
			Dt.Columns.Add("pre_prom")
		End If
		'/JDMS 595: truco para el precio cuando es basado en el promedio

		Return Dt



	End Function

	Private Shared Sub Busque_Emergencia(ByRef Emergencia As Boolean, ByRef Faccc As Double, ByVal FactorEmergenciaActual As Double)
		If Not Emergencia Then Exit Sub

		''determinar factor emergencia por si acaso
		'Static FactorEmerg As Double = -1
		'If FactorEmerg = -1 Then
		'    Dim Porce As String = 0
		'    Porce = ReglaDeNegocio(142, "emergencia", 0)
		'    If ValD(Porce) > 0 And ValD(Porce) <= 100 Then
		'        FactorEmerg = ValD(Porce)
		'    Else
		'        FactorEmerg = 0
		'    End If
		'End If

		'si tiene factor emerg del 0118
		If FactorEmergenciaActual > 0 Then
			Faccc = FactorEmergenciaActual
			Emergencia = False 'para que no haga la de la RN
			'ElseIf FactorEmerg > 0 Then 'sino asignar el de la RN
			'    Faccc = FactorEmerg
		End If



	End Sub
	Public Shared Function NoCupoCredito(ProgramaOrigen As String,
										 IdCli As Integer,
										 NombreCliente As String,
										 DescripcionTipoDocto As String,
										 ValorTotalDocumento As Double,
										 ByRef TextoResultado As String,
										 ByRef Tot As Double,
										 ByRef Apl As Double,
										 ByRef Cup As Double,
										 ByRef Saldo As Double,
										 ByRef SaldoMax As Double,
										 ByRef ProblemaCupo As String,
										 ByRef ProblemaDocsVencidos As String
										 ) As Boolean
		TextoResultado = ""
		ProblemaCupo = ""
		ProblemaDocsVencidos = ""
		Tot = 0
		Apl = 0
		'no borrar
		'Cup = 0
		Saldo = 0
		SaldoMax = 0

		Dim DtCar As New DataTable

		Abrir(DtCar, "GetCotCarteraClienteSaldo_13 " & Numero_Empresa & "," & IdCli & "," & ValD(Cup))
		Cup = 0

		If Fin(DtCar) Then
			TextoResultado = "No hay datos de cartera"
			Return True
		End If
		If ValD(Gdf(DtCar, "cupo_credito")) < 0 Then
			Return False
		End If
		If ValD(Gdf(DtCar, "privado")) > 0 Then
			TextoResultado = "Cliente está bloqueado o anulado. Operación no puede ser terminada"
			Return True
		End If


		Cup = ValD(Gdf(DtCar, "cupo_credito"))
		Saldo = ValD(Gdf(DtCar, "saldo"))
		SaldoMax = ValD(Gdf(DtCar, "saldo_max"))

		If ProgramaOrigen <> "4103" Then
			If ValorTotalDocumento > Cup - Saldo Then
				ProblemaCupo = "Cupo insuficiente " & NombreCliente & ", falta " & FormatoMoneda(Tot - (Cup - Saldo)) & DMScr(2) & "Tipo: " & DescripcionTipoDocto & DMScr() & "Valor: " & FormatoMoneda(ValorTotalDocumento)
				Return True
			End If
			'ahora validar los documentos, solo si tiene saldo positivo
			If Saldo > 0 Then
				If SaldoMax > 0 Then
					ProblemaDocsVencidos = "Documentos Vencidos " & NombreCliente & ", valor " & FormatoMoneda(SaldoMax) & DMScr(2) & "Tipo: " & DescripcionTipoDocto & DMScr() & "Valor: " & FormatoMoneda(ValorTotalDocumento)
					Return True
				End If
			End If
		End If


		Return False


	End Function

	Public Shared Sub Haga_Logistica_Descuentos(FechaDocumento As Date,
												DescuFormaPago As Double,
												NegarLogistica As Boolean,
												Cantidad As Double,
												IdBodega As Integer,
												IdGrupoItem As Integer,
												IdSubgrupoItem As Integer,
												IdItem As Integer,
												IdZonaCliente As Integer,
												IdSubzonaCliente As Integer,
												IdCodicionPago As Integer,
												IdTipoDoc As Integer,
												IdActividadCliente As Integer,
												IdPerfilCliente As Integer,
												IdListaPrecio As Integer,
												IdCliente As Integer,
												NitCliente As String,
												IdProveedorItem As Integer,
												ByRef Out_Descuento As Double,
												ByRef Out_LogProceso As String,
												ByRef Out_Color As Short,
												ByRef Out_IdPromo As Integer,
												ByRef Out_CantDispo As Double,
												ByRef PasoError As Short,
												Optional ByRef DtDescu As DataTable = Nothing,
												Optional DtItemSub5 As DataTable = Nothing,
												Optional ByRef IgnorarCtrlUti As Boolean = False
												)

		PasoError = 1

		'de primero
		If DescuFormaPago > 0 Then
			Out_Descuento = DescuFormaPago
		End If


		If NegarLogistica Then
			Out_LogProceso = Idi("Logística negada")
			Exit Sub
		End If
		If ReglaDeNegocio(61, , "0") <> "0" Then
			Out_LogProceso = "RN#61<>0"
			Exit Sub
		End If

		'jdms 645
		'If DtDescu Is Nothing Then 'para la primera vez
		Dim YoPrendi = SiRelojCond() '645
		Dim DsPru As New DataSet
		If FechaActualizoDescuentos Is Nothing Or DtDescu Is Nothing Then
			FechaActualizoDescuentos = DateAdd(DateInterval.Year, -10, Now) 'poner una fecha fecha vieja para garantizar lectura
		End If
		Abrir(DsPru, ArmeSQL("Exec GetCotDescuento2",
							   Numero_Empresa, qqNum,
							   FechaActualizoDescuentos, qqFeh
							   )
							)
		If YoPrendi Then NoReloj() '645

		If Not DsPru.Tables(0).Columns.Contains("noactu") Then
			DtDescu = DsPru.Tables(0).Copy
			FechaActualizoDescuentos = DsPru.Tables(1).Rows(0).Item(0) 'actualizamos la última fecha
		End If
		'End If
		'/jdms 645

		If Fin(DtDescu) Then
			Exit Sub
		End If



		'para cargar los nuevos subgrupos sin tocar la lógica vieja
		Dim IdSub3 As Integer = 0
		Dim IdSub4 As Integer = 0
		Dim IdSub5 As Integer = 0
		Try
			Dim Its As DataTable = Filtrar_DataTable(DtItemSub5, "id_cot_item=" & IdItem)
			If Not Fin(Its) Then
				IdSub3 = ValD(Gdf(Its, "id_cot_grupo_sub3"))
				IdSub4 = ValD(Gdf(Its, "id_cot_grupo_sub4"))
				IdSub5 = ValD(Gdf(Its, "id_cot_grupo_sub5"))
			End If
		Catch ex As Exception

		End Try
		'/para cargar los nuevos subgrupos sin tocar la lógica vieja


		Dim Sq As String = ""

		Dim Canti As String
		If Cantidad <> 0 Then
			Canti = Cantidad
		Else
			'Canti = "1"
			Canti = "0" 'jdms 647: se pone en cero para que no afecte la logístca de descuentos
		End If
		Sq &= "(id_cot_bodega Is null Or id_cot_bodega=" & IdBodega & ") And "
		Sq &= "(id_cot_grupo Is null Or id_cot_grupo=" & IdGrupoItem & ") And "
		Sq &= "(id_cot_grupo_sub Is null Or id_cot_grupo_sub=" & IdSubgrupoItem & ") And "
		Sq &= "(id_cot_grupo_sub3 Is null Or id_cot_grupo_sub3=" & IdSub3 & ") And "
		Sq &= "(id_cot_grupo_sub4 Is null Or id_cot_grupo_sub4=" & IdSub4 & ") And "
		Sq &= "(id_cot_grupo_sub5 Is null Or id_cot_grupo_sub5=" & IdSub5 & ") And "
		Sq &= "(id_cot_item Is null Or id_cot_item=" & IdItem & ") And "
		Sq &= "(id_cot_zona Is null Or id_cot_zona=" & IdZonaCliente & ") And "
		Sq &= "(id_cot_zona_sub Is null Or id_cot_zona_sub=" & IdSubzonaCliente & ") And "
		Sq &= "(id_cot_forma_pago Is null Or id_cot_forma_pago=" & IdCodicionPago & ") And "
		Sq &= "(id_cot_tipo Is null Or id_cot_tipo=" & IdTipoDoc & ") And "
		Sq &= "(id_cot_cliente_actividad Is null Or id_cot_cliente_actividad=" & IdActividadCliente & ") And "
		Sq &= "(id_cot_cliente_perfil Is null Or id_cot_cliente_perfil=" & IdPerfilCliente & ") And "
		Sq &= "(id_cot_item_listas Is null Or id_cot_item_listas=" & IdListaPrecio & ") And "
		'Sq &= "(id_cot_cliente Is null Or id_cot_cliente=" & IdCliente & ") And "
		'639: agregamos el nit para herson y todos los demás
		Sq &= "(id_cot_cliente Is null Or id_cot_cliente=" & IdCliente & " or isnull(nit,'')='" & NitCliente & "') And "
		Sq &= "(id_cot_cliente_prov Is null Or id_cot_cliente_prov=" & IdProveedorItem & ") And "
		Sq &= "(cantidad Is null Or cantidad<=" & ValDMS(ValD(Canti)) & " or " & ValD(Canti) & "=0) And " 'jdms 647:para que muestre el descuento antes de entrar la cantidad
		Sq &= "(cantidad_gru Is null) And " 'excluir los que tienen cantidad en el grupo
		Sq &= "(cant_promo Is null Or disponible >= " & ValDMS(ValD(Canti)) & ")"
		PasoError = 2
		Dim DtLogistica As DataTable = Filtrar_DataTable(DtDescu, Sq, "descripcion")

		'control de cantidad en promosión
		Out_IdPromo = 0
		Out_CantDispo = 0
		Dim dt As DataTable = Filtrar_DataTable(DtLogistica, "cant_promo Is Not null")
		If dt.Rows.Count > 1 Then
			Mensaje("Cantidad en promoción no funcionará: El sistema no permite dos definiciones con cantidad en promoción. Corrija el 0170 y vuelva a intentarlo")
		ElseIf dt.Rows.Count = 1 Then
			Out_IdPromo = Gdf(dt, "id")
			Out_CantDispo = ValD(Gdf(dt, "disponible"))
			''If Not YaRefresco Then
			''    DtDescu = Nothing
			''    GoTo Repetir_Lectura
			'End If
		End If

		'TODO: probando a ver si se mejora lo de grupo
		'If Fin(DtLogistica) Then
		'    Out_Descuento = -2
		'    Exit Sub
		'End If

		PasoError = 3
		Sq = "" 'para el manejo del error abajo

		Dim Suma As Decimal = 100
		Dim Acum As Decimal = 0
		Dim MaxDes As Decimal = 0
		Dim DescripMax As String = ""
		Out_LogProceso = ""


		For Each Fi As DataRow In DtLogistica.Rows

			'validar el día de la semana para el descuento
			If Not IsDBNull(Fi("dias")) Then
				Dim Dias As String = Fi("dias").ToString
				Dim Hoy As Short = DatePart(DateInterval.Weekday, FechaDocumento, FirstDayOfWeek.Monday)
				If Mid(Dias, Hoy + 1, 1) = "0" Then Continue For 'este día no está seleccionado
			End If

			If ValD("" & Fi("tipo_descuento")) = 1 Then 'significa que solo tomarlo si es el máximo encontrado y no sumarlo a los otros
				Out_LogProceso += Chr(9) & "Evalúa Máximo -> " & Fi("descripcion") & ": " & ValD(Fi("porcentaje_descuento")).ToString & "% " & DMScr()
				If ValD(Fi("porcentaje_descuento")) > MaxDes Then
					MaxDes = ValD(Fi("porcentaje_descuento"))
					DescripMax = Fi("descripcion")
				End If
			Else
				Out_LogProceso += "+ " & Fi("descripcion") & ": " & ValD(Fi("porcentaje_descuento")).ToString & "% " & DMScr()
				Acum += ValD(Fi("porcentaje_descuento")) * (Suma / 100)
				Suma -= ValD(Fi("porcentaje_descuento")) * (Suma / 100)
			End If

			If ValD(Fi("ignorar_control_utilidad")) > 0 Then
				IgnorarCtrlUti = True
			End If
		Next

		PasoError = 4
		If MaxDes > 0 Then 'adicionar el máximo encontrado
			'Acum += MaxDes * (Suma / 100)'no sumar el m'aximo al promedio: Ximena
			If MaxDes > Acum Then
				Out_LogProceso += "+ (" & Idi("Máximo Encontrado") & ") " & DescripMax & ": " & ValD(MaxDes).ToString & "%, (acum=" & Acum & ")" & DMScr()
				Acum = MaxDes
			End If
			'Out_LogProceso += "+ (Máximo Encontrado) " & DescripMax & ": " & ValD(MaxDes).ToString & "%" & DMScr()
		End If

		PasoError = 5
		Out_Color = 1 'negro
		If Acum > 100 Then Acum = 100
		If Acum > 0 And Acum <= 100 Then
			Out_Descuento = ValD(Acum).ToString

			'computar el descuento de la forma de pago
			If DescuFormaPago > 0 Then
				If Out_Descuento > 0 Then
					Out_Descuento = (1 - (1 - ValD(Out_Descuento) / 100) * (1 - DescuFormaPago / 100)) * 100
				Else
					Out_Descuento = DescuFormaPago
				End If
			End If

			Out_Color = 2 'rojo
			Out_LogProceso += "= " & Idi("Descuento Total") & ": " & Out_Descuento & "%" & DMScr()
		End If

		If IgnorarCtrlUti Then
			Out_LogProceso += Idi("Ignora control utilidad") & DMScr()
		End If



		PasoError = 0 'paso bien

	End Sub



End Class
