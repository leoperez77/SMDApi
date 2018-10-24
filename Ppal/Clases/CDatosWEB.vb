'♥ versión: 586, 6-oct.-2017 07:11
Public Class CDatosWEB
    Dim CodAplica2 As String = Obtenga_Aplica()
    Dim Prox As New Proxy_SMD
    Dim Ws As SMD.Ws = New SMD.Ws()
    Dim _Entro As Boolean = False
    Public Usuario As Integer
    Public Numero_Empresa As Integer
    Public MiCodigo As String

    Public Sub New()
        DemeNodoWeb()

    End Sub

    Private Property Entro As Boolean
        Get
            Return _Entro
        End Get
        Set(value As Boolean)
            _Entro = value
        End Set
    End Property

    Public Sub AbrirDatosWeb(ByRef Dt As DataTable, ByVal Sql As String)
        Dt = Ws.GetDataset2(Haga1(True, Sql), Haga1(True, CodAplica2)).Tables(0).Copy

    End Sub
    Public Sub AbrirDatosWeb(ByRef Ds As DataSet, ByVal Sql As String)
        Ds = Ws.GetDataset2(Haga1(True, Sql), Haga1(True, CodAplica2))

    End Sub

    Public Function ValD(ByVal ValorTexto As Object) As Decimal
        Dim Va As Decimal


        Try
            'If ValorTexto Is System.DBNull.Value Then
            '    ValorTexto = 0
            'End If
            'If Not IsNumeric(ValorTexto) Then ValorTexto = 0

            ValorTexto = ValorTexto.ToString

            Try
                Decimal.TryParse(ValorTexto, Globalization.NumberStyles.Any, Nothing, Va)
            Catch ex As Exception
                Double.TryParse(ValorTexto, Globalization.NumberStyles.Any, Nothing, Va)
            End Try

            Return Va

        Catch ex As Exception
            Va = 0
            Return Va

        End Try


    End Function
    Public Function Mensajeria_DMSWEB(ByRef Usuario_Destino As Integer, ByRef Mensaje As String, ByRef Usuario_Origen As Integer) As DataSet
        'Dim Mensa As String = vbNewLine & Replace(Mensaje, "'", "''")
        Dim Mensa As String = vbNewLine & Replace(Mensaje, "'", "''")
        Dim Eje As String = ""
        For I = 0 To 10 'maximo 10 mensajes
            If Mid(Mensa, (I * 500 + 1), 500).Trim = "" Then Exit For
            Eje += "Exec PutMensajes " & Usuario_Origen.ToString & "," & Usuario_Destino.ToString & "," & "'" & Mid(Mensa, (I * 500 + 1), 500).Trim & "'" & vbNewLine
        Next

        'envía y recibe
        Dim Ds As New DataSet
        AbrirDatosWeb(Ds, Eje & vbNewLine & _
                      "Exec GetMensajesWeb " & Usuario.ToString)

        Return Ds

    End Function
    Public Function Cargar_Usuarios() As DataSet
        Dim Ds As New DataSet
        AbrirDatosWeb(Ds, "exec GetUsuariosIdCodigoWeb " & Numero_Empresa.ToString & vbNewLine & _
                      "Exec GetMensajesWeb " & Usuario.ToString)

        Return Ds

    End Function
    Public Function Buscar_Mensajes_DMSWEB() As DataSet
        Dim Ds As New DataSet
        AbrirDatosWeb(Ds, "exec GetMensajesWeb " & Usuario.ToString)

        Return Ds

    End Function
    Public Sub EjecutarWEB(ByVal TextoEjecutar As String)

        Ws.Exec2(Haga1(True, TextoEjecutar), Haga1(True, CodAplica2))

    End Sub

    Private Sub DemeNodoWeb()
        If Entro Then Exit Sub
        Entro = True


        With Prox
            Ws.Url = "http://190.85.68.202/smsws/smdws.asmx"
        End With


        'solo para la parte de Proxy setting
        Try
            With Prox
                Dim proxyobj As New System.Net.WebProxy
                If .Si = 1 And .DirURL <> "" Then
                    proxyobj = New System.Net.WebProxy(.DirURL, Convert.ToInt32(.Puerto))
                End If
                If .User_Si = 1 And .Usuario <> "" Then 'viene
                    Dim Cre As New System.Net.NetworkCredential
                    Cre.UserName = .Usuario
                    Cre.Password = .Clave
                    'proxyobj = System.Net.WebProxy.GetDefaultProxy
                    proxyobj.Credentials = Cre
                    Ws.Proxy = proxyobj
                End If
            End With

        Catch ex As Exception
            MsgBox("Error en Proxy: " & ex.Message)

        End Try

    End Sub
    Private Function Haga1(ByVal Hacer As Boolean, ByVal Orig As String) As String
        If Hacer Then
            Dim Nuevo As String = ""
            Dim Nos As String = ""
            For I As Integer = 1 To Orig.Length
                If Asc(Mid(Orig, I, 1)) > 127 Then
                    Nos &= I.ToString & "."
                    Nuevo &= Mid(Orig, I, 1)
                Else
                    Nuevo &= Chr(Asc(Mid(Orig, I, 1)) + 78) '128)
                End If
            Next
            'If Usuario = 128 Then 'hacerlo solo en el 128
            '    DebugJD(Nos & "|" & Nuevo)
            'End If
            Return Nos & "|" & Nuevo
        Else
            Dim Nuevo2 As String = ""
            Dim KK As Integer = InStr(Orig, "|")
            Dim Nos2() As String = Mid(Orig, 1, KK - 1).Split(".")
            Orig = Mid(Orig, KK + 1)
            For I As Integer = 1 To Orig.Length
                Dim Saltar As Boolean = False
                For J As Integer = 0 To Nos2.Length - 1
                    If I = Val(Nos2(J)) Then
                        Saltar = True
                        Exit For
                    End If
                Next
                If Saltar Then
                    Nuevo2 &= Mid(Orig, I, 1)
                Else
                    Nuevo2 &= Chr(Asc(Mid(Orig, I, 1)) - 78) '128)
                End If
            Next
            Return Nuevo2
        End If

    End Function
    Private Function Obtenga_Aplica() As String
        '@$%dms.net0708

        Dim aaa As String = traerDato()

        If aaa = "" Then
            aaa = "jsjdkf&%&&27"
        Else
            aaa += "dms.netO7O8"
        End If

        Return aaa


    End Function
    Private Function traerDato()
        Return "@/(%$"

    End Function

End Class
