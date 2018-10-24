'♥ versión: 586, 6-oct.-2017 07:11
Public Module ModuloReglasDeNegocio
    Public Function Regla_PrecioConIva_14() As Boolean
        If ReglaDeNegocio(14, , "0") = "1" Then
            Return True
        Else
            Return (False)
        End If

    End Function
    Public Function Regla_SoyTaller_15() As Boolean
        If ReglaDeNegocio(15, , "0") = "1" Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function Regla_SoyAutomotriz_16() As Boolean
        If ReglaDeNegocio(16, , "0") = "1" Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function Regla_SoyRestaurante_17() As Boolean
        If ReglaDeNegocio(17, , "0") = "1" Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function Regla_SoyHotel_18() As Boolean
        If ReglaDeNegocio(18, , "0") = "1" Then
            Return True
        Else
            Return False
        End If

    End Function

End Module
