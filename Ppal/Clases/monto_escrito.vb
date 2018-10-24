' Version: 659, 27-jun.-2018 13:25
'♥ versión: 586, 6-oct.-2017 07:11
Module monto_escrito
    Public Function Num_texto(Numero As Decimal, Moneda As String)
        Dim Texto
        Dim Millones
        Dim Miles
        Dim Cientos
        Dim Decimales
		Dim Cadena = ""
		Dim CadMillones
        Dim CadMiles
        Dim CadCientos
        Texto = Numero
        Texto = FormatNumber(Texto, 2)
        Texto = Right(Space(14) & Texto, 14)
        Millones = Mid(Texto, 1, 3)
        Miles = Mid(Texto, 5, 3)
        Cientos = Mid(Texto, 9, 3)
        Decimales = Mid(Texto, 13, 2)
        CadMillones = ConvierteCifra(Millones, 1)
        CadMiles = ConvierteCifra(Miles, 1)
        CadCientos = ConvierteCifra(Cientos, 0)
        If Trim(CadMillones) > "" Then
			If Trim(CadMillones) = "UN" Then
				Cadena = CadMillones & " MILLON"
			Else
				Cadena = CadMillones & " MILLONES"
            End If
        End If
        If Trim(CadMiles) > "" Then
            Cadena = Cadena & " " & CadMiles & " MIL"
        End If
        If Trim(CadMiles & CadCientos) = "UN" Then
            Cadena = Cadena & "UNO CON " & Decimales & "/100"
        Else
            If Miles & Cientos = "000000" Then
                Cadena = Cadena & " " & Trim(CadCientos) & " " & IIf(Moneda = "", "PESOS", Moneda) & " CON " & Decimales & " CTVOS"
            Else
                Cadena = Cadena & " " & Trim(CadCientos) & " " & IIf(Moneda = "", "PESOS", Moneda) & " CON " & Decimales & " CTVOS"
            End If
        End If
        Num_texto = Trim(Cadena)
    End Function

    Function ConvierteCifra(Texto, SW)
        Dim Centena
        Dim Decena
        Dim Unidad
        Dim txtCentena
        Dim txtDecena
        Dim txtUnidad
        Centena = Mid(Texto, 1, 1)
        Decena = Mid(Texto, 2, 1)
        Unidad = Mid(Texto, 3, 1)
        Select Case Centena
            Case "1"
                txtCentena = "CIEN"
                If Decena & Unidad <> "00" Then
                    txtCentena = "CIENTO"
                End If
            Case "2"
                txtCentena = "DOSCIENTOS"
            Case "3"
                txtCentena = "TRESCIENTOS"
            Case "4"
                txtCentena = "CUATROCIENTOS"
            Case "5"
                txtCentena = "QUINIENTOS"
            Case "6"
                txtCentena = "SEISCIENTOS"
            Case "7"
                txtCentena = "SETECIENTOS"
            Case "8"
                txtCentena = "OCHOCIENTOS"
            Case "9"
                txtCentena = "NOVECIENTOS"
        End Select

        Select Case Decena
            Case "1"
                txtDecena = "DIEZ"
                Select Case Unidad
                    Case "1"
                        txtDecena = "ONCE"
                    Case "2"
                        txtDecena = "DOCE"
                    Case "3"
                        txtDecena = "TRECE"
                    Case "4"
                        txtDecena = "CATORCE"
                    Case "5"
                        txtDecena = "QUINCE"
                    Case "6"
                        txtDecena = "DIECISEIS"
                    Case "7"
                        txtDecena = "DIECISIETE"
                    Case "8"
                        txtDecena = "DIECIOCHO"
                    Case "9"
                        txtDecena = "DIECINUEVE"
                End Select
            Case "2"
                txtDecena = "VEINTE"
                If Unidad <> "0" Then
                    txtDecena = "VEINTI"
                End If
            Case "3"
                txtDecena = "TREINTA"
                If Unidad <> "0" Then
                    txtDecena = "TREINTA Y "
                End If
            Case "4"
                txtDecena = "CUARENTA"
                If Unidad <> "0" Then
                    txtDecena = "CUARENTA Y "
                End If
            Case "5"
                txtDecena = "CINCUENTA"
                If Unidad <> "0" Then
                    txtDecena = "CINCUENTA Y "
                End If
            Case "6"
                txtDecena = "SESENTA"
                If Unidad <> "0" Then
                    txtDecena = "SESENTA Y "
                End If
            Case "7"
                txtDecena = "SETENTA"
                If Unidad <> "0" Then
                    txtDecena = "SETENTA Y "
                End If
            Case "8"
                txtDecena = "OCHENTA"
                If Unidad <> "0" Then
                    txtDecena = "OCHENTA Y "
                End If
            Case "9"
                txtDecena = "NOVENTA"
                If Unidad <> "0" Then
                    txtDecena = "NOVENTA Y "
                End If
        End Select

        If Decena <> "1" Then
            Select Case Unidad
                Case "1"
                    If SW Then
                        txtUnidad = "UN"
                    Else
                        txtUnidad = "UNO"
                    End If
                Case "2"
                    txtUnidad = "DOS"
                Case "3"
                    txtUnidad = "TRES"
                Case "4"
                    txtUnidad = "CUATRO"
                Case "5"
                    txtUnidad = "CINCO"
                Case "6"
                    txtUnidad = "SEIS"
                Case "7"
                    txtUnidad = "SIETE"
                Case "8"
                    txtUnidad = "OCHO"
                Case "9"
                    txtUnidad = "NUEVE"
            End Select
        End If
        ConvierteCifra = txtCentena & " " & txtDecena & txtUnidad
    End Function
End Module
