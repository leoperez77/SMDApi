' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 655, 1-jun.-2018 12:53
' Version: 652, 10-may.-2018 12:48
' Version: 650, 7-may.-2018 12:42
Public Class ClaseCertif
	Public Shared Sub Imprimir_Certificado_Compra(HacerCertificado As Short,
												  FormaLlamadora As Form,
												  Ds1 As DataSet,
												  Id As Long,
												  Sw As Short,
												  Optional Impuesto As Double = 0)
		If HacerCertificado = 0 Then Exit Sub
		If HacerCertificado > 0 And Impuesto = 0 Then
			Exit Sub
		End If

		Dim NombreFormato As String = ""
		If HacerCertificado = -1 Then 'significa segunda impresión
			Dim Segu As String = ReglaDeNegocio(142, "segunda_sw" & Sw, "0")
			If ValD(Segu) < 1 Or ValD(Segu) > 5 Then
				Exit Sub
			End If
			HacerCertificado = ValD(Segu)
			NombreFormato = ReglaDeNegocio(142, "segunda_fmt_sw" & Sw, "")
			If NombreFormato = "" Then
				Mensaje(Idi("No imprime segundo formato: Tiene activa la llave") & " [segunda_sw" & Sw & "] RN#142, " & Idi("pero no tiene definido el formato de impresión") & " [segunda_fmt_sw" & Sw & "]")
				Exit Sub
			End If
		Else 'certificado última validación
			'verificar cuenta contable
			Dim Cuentas As String = ReglaDeNegocio(102, "certif_ctas", "").Replace(" ", "")
			If Cuentas <> "" Then
				Dim DtCtas As New DataTable
				Abrir(DtCtas, "GetConCtasUnDoc " & Sw & "," & Id & ",'" & Cuentas & "'")
				If Fin(DtCtas) Then 'no está la cuenta, ENTONCES NO PRODUCIR EL CERTIFICADO
					Exit Sub
				End If
			End If
			'/verificar cuenta contable
		End If



		'el -1603 en empresa significa que es certificado

		'Ds1.Tables(1).Rows.Clear()
		'Ds1.Tables(1).Rows.Add("certif", Now, -1, IIf(EsCompra, "d_compra_certif.rpt", "d_nota_certif"))
		'0 - No producir
		'1 - Ver por pantalla el certificado 
		'2 - Imprimir el certificado 
		'3 - Enviar por eMail el certificado
		'4 - Ver y Enviar
		'5 - Imprimir y enviar
		Dim Imp As Short = 3 'mail
		If HacerCertificado = 1 Or HacerCertificado = 4 Then
			Imp = 2
		ElseIf HacerCertificado = 2 Or HacerCertificado = 5 Then
			Imp = 1
		End If

		Imprima_Documento(Ds1, FormaLlamadora, Nothing, Numero_Empresa, Sw, Id, Imp, NuevoImprimir:=Imp, CargarDatos:=Ds1.Tables.Count = 0, EsCertificado:=True, NombreFormato:=NombreFormato) 'mail

		If HacerCertificado = 4 Or HacerCertificado = 5 Then
			Imprima_Documento(Ds1, FormaLlamadora, Nothing, Numero_Empresa, Sw, Id, Imp, NuevoImprimir:=3, CargarDatos:=False, EsCertificado:=True, NombreFormato:=NombreFormato) 'imprimir directo
		End If



	End Sub

	Public Shared Function Verificar_Producir_Certificado(Certificado As Short,
												IdTrib As Integer,
												IdBodega As Integer,
												Optional MostrarMens As Boolean = True) As Short
		If ValD(Certificado) = 0 Then
			Return 0
		End If

		Dim Result As Short = Certificado
		If ReglaDeNegocio(102, "certif_tip", "") <> "" Then
			Dim TiposEx As String = "," & ReglaDeNegocio(102, "certif_tip", "").Replace(" ", "") & ","
			If Not TiposEx.Contains("," & IdTrib & ",") Then
				Result = 0
			End If
		End If

		If ReglaDeNegocio(102, "certif_bod", "") <> "" Then
			Dim Bods As String = "," & ReglaDeNegocio(102, "certif_bod", "").Replace(" ", "") & ","
			If Not Bods.Contains("," & IdBodega & ",") Then
				Result = 0
			End If
		End If



		If MostrarMens Then
			NoReloj()
			If Result = 0 Then
				Mensaje("ATENCIÓN: Este tercero debería producir CERTIFICADO pero por la llave [certif_tip] o [certif_bod] de la RN#102, no lo producirá")
			Else
				Dim Explica As String = ""
				Select Case Certificado
					Case 1 : Explica = "Ver por pantalla el certificado"
					Case 2 : Explica = "Imprimir el certificado"
					Case 3 : Explica = "Enviar por eMail el certificado"
					Case 4 : Explica = "Ver y Enviar"
					Case 5 : Explica = "Imprimir y enviar"
				End Select

				Mensaje(Idi("Atención: Tenga en cuenta que va a producir CERTIFICADO para este proveedor." & DMScr(2) & "Cuando actualice el documento, el certificado usará esta opción:") & DMScr(2) & Idi(Explica))
			End If
		End If

		Return Result

	End Function
End Class
