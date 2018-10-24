' Version: 681, 20-ago.-2018 20:08
' Version: 650, 7-may.-2018 12:42
'♥ versión: 586, 6-oct.-2017 07:11
Public Class PrtOT
    Public Shared Sub Imprimir_Orden_Taller(Id As Integer, OpcionImprimir As Integer, Sw As Integer)
        If Id = 0 Then
            Mensaje("No hay documento para imprimir")
            Exit Sub
        End If

        Try
			Dim Ds1 As New DataSet
			If OpcionImprimir > 0 Then
				Imprima_Documento(Ds1, Nothing, Nothing, Numero_Empresa, Sw, Id, 2, NuevoImprimir:=OpcionImprimir)
			End If
			'jdms 650: segunda impresión
			ClaseCertif.Imprimir_Certificado_Compra(-1, Nothing, Ds1, Id, Sw)
			'/jdms 650


		Catch ex As Exception
			MostrarError("PrtOT", "Imprimir_Orden_Taller", ex.Message)

		End Try



    End Sub
End Class
