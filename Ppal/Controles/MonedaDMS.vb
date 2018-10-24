' Version: 683, 23-ago.-2018 12:40
' Version: 680, 17-ago.-2018 13:24
' Version: 678, 16-ago.-2018 14:15
'♥ versión: 586, 6-oct.-2017 07:11
Public Class MonedaDMS
    Dim TieneTasaDia As Boolean = False
    Dim CalcularTasa As Boolean = False

    'Propiedades de monedas
    Private _IdMoneda As Integer = 0
    Private _tasa As Decimal = 0
    Private _factor As Decimal = 0
    Private _signo As Integer = 0
    Private _programa As String = ""
    Private _fecha_cambio As DateTime = Date.Now
    Private _tasafija As Decimal = 0
    Private _hagacalculo As Boolean = False

    Public Property IdMoneda() As Integer
        Get
            Return _IdMoneda
        End Get
        Set(ByVal value As Integer)
            _IdMoneda = value
        End Set
    End Property

    Public Property Tasa() As Decimal
        Get
            Return _tasa
        End Get
        Set(ByVal value As Decimal)
            _tasa = value
        End Set
    End Property

    Public Property Factor() As Decimal
        Get
            Return _factor
        End Get
        Set(ByVal value As Decimal)
            _factor = value
        End Set
    End Property

    Public Property Signo() As Integer
        Get
            Return _signo
        End Get
        Set(ByVal value As Integer)
            _signo = value
        End Set
    End Property

    Public Property Programa() As String
        Get
            Return _programa
        End Get
        Set(ByVal value As String)
            _programa = value
        End Set
    End Property

    Public Property Fecha_cambio() As DateTime
        Get
            Return _fecha_cambio
        End Get
        Set(ByVal value As DateTime)
            _fecha_cambio = value
        End Set
    End Property

    Public Property Tasafija() As Decimal
        Get
            Return _tasafija
        End Get
        Set(ByVal value As Decimal)
            _tasafija = value
        End Set
    End Property

    Public Sub DMSTraigaDatosMoneda()
        IdMoneda = ValD(TraerId(CbMoneda))
        Tasa = ValD(LblTasa.Text)
        If ValD(LblTasa.Text) > 0 Then
            If Signo = 0 Then
                Factor = ValD(LblTasa.Text)
            Else
                Factor = 1 / ValD(LblTasa.Text)
            End If
        Else
            Factor = 1
        End If
    End Sub

    Public Property Hagacalculo() As Boolean
        Get
            Return _hagacalculo
        End Get
        Set(ByVal value As Boolean)
            _hagacalculo = value
        End Set
    End Property

    Public Sub DMSLimpiarMoneda()
        CbMoneda.SelectedIndex = -1
        LblTasa.Text = ""
        IdMoneda = 0
        Tasa = 0
        Factor = 0
        Signo = 0
        'Programa = ""
        Fecha_cambio = Date.Now
        Tasafija = 0
    End Sub

    Private Sub CbMoneda_Validated(sender As Object, e As EventArgs) Handles CbMoneda.Validated
        Hagacalculo = False
        If ValD(TraerId(CbMoneda)) > 0 Then
            Dim datos_moneda As Decimal() = Tasa_Dia()
            Signo = datos_moneda(1)
            Tasafija = datos_moneda(0)
            If ValD(datos_moneda(0)) > 0 Then
                LblTasa.Text = FormatoMoneda(ValD(datos_moneda(0)), False, False, 10)
            Else
                LblTasa.Text = FormatoMoneda(ValD(datos_moneda(2)), False, False, 10)
            End If
            Hagacalculo = True
        End If
    End Sub

    Public Sub DMSAsigneMoneda(fec As Date,
                               prg As String,
                               Optional Id As Integer = Nothing,
                               Optional valor_tasa As Decimal = Nothing
                               )
        DMS_CargarMonedas()
        If Val(Id) > 0 Then
            IdMoneda = Id
            PongaIndex(CbMoneda, IdMoneda)
            CbMoneda_Validated(IdMoneda, New EventArgs)
        End If
        If ValD(valor_tasa) > 0 Then
            Tasa = valor_tasa
            LblTasa.Text = FormatoMoneda(Tasa, False, False, 10)
        End If
        Fecha_cambio = fec
        Programa = prg
    End Sub

    Private Function Tasa_Dia() As Decimal()
        Try
            Dim Sql As String = ""
            Dim valores_tasa() As Decimal = {0, 0, 0}

            Sql = ArmeSQL("exec GetCotTasaMoneda",
                          ValD(TraerId(CbMoneda)), qqNum)
            Dim Ds As New DataSet
            Abrir(Ds, Sql)
            If Fin(Ds.Tables(1)) Then
                Return valores_tasa
            Else
                'Validar si la moneda tiene tasa fija
                valores_tasa = {ValD(Gdf(Ds.Tables(1), "tasa_fija")),
                               ValD(Gdf(Ds.Tables(1), "dividir")), 0}
            End If

            'Validacion de la tasa de cambio para el dia
            Dim Dt As New DataTable
            Sql = "fecha='" & Strings.Format(Fecha_cambio, "yyyy-MM-dd") & "'"
            Dt = Filtrar_DataTable(Ds.Tables(0), Sql)
            If Not Fin(Dt) Then
                'Validar si la moneda tiene tasa fija
                valores_tasa = {ValD(Gdf(Ds.Tables(1), "tasa_fija")),
                               ValD(Gdf(Ds.Tables(1), "dividir")),
                               ValD(Gdf(Dt, "tasa"))}
            End If

            Return valores_tasa

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Sub LnkTasa_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkTasa.LinkClicked
        If ValD(TraerId(CbMoneda)) = 0 Then
            Exit Sub
        End If

        If NoPuede4(Programa, 240) Then
            Exit Sub
        End If

        If ValD(Tasafija) > 0 Then
            If Pregunte("La moneda seleccionada maneja tasa fija" & DMScr() &
                        "Desea modificar la tasa?") Then
                AbrirPrograma("0130", ValD(TraerId(CbMoneda)))
                CbMoneda_Validated(ValD(TraerId(CbMoneda)), New EventArgs)
                Exit Sub
            End If
        End If

		Dim nueva_tasa As String = Inputbox2("Tasa de Cambio", "Entrada de la tasa de Cambio", Tasa)
		If IsNumeric(nueva_tasa) Then
            If nueva_tasa > 0 Then
                Dim Resp As Short
                Resp = PregunteCancel("Desea actualizar la tasa del día " & FechaSinHora(Fecha_cambio) & " para esta moneda?" & DMScr() & DMScr() &
                                      "Responda NO para modificarla en el documento sin afectar el maestro de monedas")
                If Resp = MsgBoxResult.Cancel Then
                    Exit Sub
                Else
                    If Resp = MsgBoxResult.No Then
                        If NoPuede4(Programa, 240) Then
                            Exit Sub
                        End If
                        Tasa = nueva_tasa
                        LblTasa.Text = FormatoMoneda(nueva_tasa, False, False, 10)
                    Else
                        LblTasa.Text = FormatoMoneda(nueva_tasa, False, False, 10)
                        Dim Sql As String = ArmeSQL("exec GetCotTasaMoneda",
                                                    ValD(TraerId(CbMoneda)), qqNum)
                        Dim Ds As New DataSet
                        Abrir(Ds, Sql)
                        Dim Dt As DataTable
                        Dt = Filtrar_DataTable(Ds.Tables(0), "fecha=" & "'" & Fecha_cambio.ToString & "'") 'JFG-569 Fecha_cambio
                        Dim modif As Integer = 0
                        If Fin(Dt) Then
                            modif = 0
                        Else
                            modif = Gdf(Dt, "id")
                        End If

                        Sql = ArmeSQL("exec PutCotTasaDia2",
                                      Numero_Empresa, qqNum,
                                      Usuario, qqNum,
                                      modif, qqNum,
                                      TraerId(CbMoneda), qqNum,
                                      Fecha_cambio, qqFec,
                                      ValD(LblTasa.Text), qqNum)
                        Ejecutar(Sql)
                        SonarWAV("ok")
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub DMS_CargarMonedas()
        If CbMoneda.Items.Count > 0 Then
            Exit Sub
        End If

        Dim Dt As New DataTable
        Abrir(Dt, "exec GetCotMonedas " & Numero_Empresa)
        Llene_Combo5(CbMoneda, Dt, "id", "descripcion")
    End Sub

    Private Sub CbMoneda_MouseClick(sender As Object, e As MouseEventArgs) Handles CbMoneda.MouseClick
        DMS_CargarMonedas()
    End Sub

	Private Sub MonedaDMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_Idioma(Me, Me)

	End Sub
End Class
