'♥ versión: 586, 6-oct.-2017 07:11
Public Class CFinanciera

    Public Shared Function ValorCuota(ValorCredito As Decimal, InteresMes As Decimal, Cuotas As Short) As Decimal

        Try
            Dim v_cuota_mes As Decimal

            If InteresMes = 0 Then
                v_cuota_mes = ValorCredito / Cuotas
            Else
                v_cuota_mes = (InteresMes / 100) * ValorCredito / (1 - (1 + (InteresMes / 100)) ^ -Cuotas)
            End If

            Return v_cuota_mes

        Catch ex As Exception
            Return 0
        End Try


    End Function
End Class
