' Version: 694, 28-sep.-2018 12:57
' Version: 691, 17-sep.-2018 20:53
' Version: 690, 13-sep.-2018 12:20
' Version: 689, 12-sep.-2018 13:17
' Version: 689, 12-sep.-2018 13:11
' Version: 684, 25-ago.-2018 20:17
' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 678, 16-ago.-2018 14:15
' Version: 665, 16-jul.-2018 13:20
' Version: 660, 5-jul.-2018 12:55
' Version: 655, 1-jun.-2018 12:53
' Version: 641, 4-abr.-2018 12:52
' Version: 637, 13-mar.-2018 12:42
' Version: 635, 6-mar.-2018 07:29
' Version: 634, 2-mar.-2018 18:51
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fFormaPago
    Public Sql As String = ""
    Public SoyEgreso As Boolean = False
    Public NumeroPrograma As String = ""
    Public IdCliente As Integer = 0
    Dim Consig_TC As Integer = ValD(ReglaDeNegocio(90, "TC", "0"))
    Dim Consig_TD As Integer = ValD(ReglaDeNegocio(90, "TD", "0"))
    Public Posfechado As Boolean = False
    Public SinCopago As Double = 0
    Public SinCopago_Doc As String
    Public MezclaCreditoContado As Short = 0
    Public EsContEspecial As Short = 0 'JFG:2017-05-13 Contribuyente Especial Ecuador activa Comprobantes de retención
    Dim DtTipoFiltrado As New DataTable
    'LFAA: 634
    Dim fFTerUAFE As fInfExtUAFE
    '/LFAA: 634

    Private Sub fFormaPago_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        TxtPrecio.Focus()

    End Sub

    Private Sub fFormaPago_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try


            If e.KeyCode >= Keys.F1 And e.KeyCode <= Keys.F9 Then
                LstForma.SelectedIndex = e.KeyCode - 112
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub fFormaPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		PnlStore.Location = PnlDoc.Location


		'AsignarImagenPrograma(CmdEfe, 1024)
		'AsignarImagenPrograma(CmdChe, 1025)
		'AsignarImagenPrograma(CmdDeb, 1026)
		'AsignarImagenPrograma(CmdCre, 1027)
		'AsignarImagenPrograma(CmdTransfer, 1028)
		'AsignarImagenPrograma(CmdBono, 1029)
		'AsignarImagenPrograma(CmdOk, 1030)

		'LFAA: 634 Se prende el link dependiendo si es ecuador
		If ReglaDeNegocio(171, "ecuador", "0") = "1" Then
            LnkPagoTerceros.Visible = True
        Else
            LnkPagoTerceros.Visible = False
        End If
        '/LFAA: 634 Se prende el link dependiendo si es ecuador

        If Falta_Licencia("1029", False) Then
            DebugJD("No licencia para posfechados")
            PnlFechaConsig.Enabled = False
            LblLicPosfe.Visible = True
        End If

        Cargar_Datos()

        'LFAA: 635 - Se carga la lista de formas de pago tomando en cuenta la regla de negocio para exclusión
        Dim FpExcluir As String = ""
        'SGQ-664
        'FpExcluir = ReglaDeNegocio(165, "fp_excluir", "0")
        FpExcluir = ReglaDeNegocio(165, "fp_excluir", "")
        '/SGQ-664

        'Llene_Combo5(LstForma, DtTipoFiltrado, "id", "descripcion")
        If FpExcluir.ToString <> "" Then
			Llene_Combo5(LstForma, DtTipoFiltrado, "id", "descripcion", "id not in(" & FpExcluir & ")")
			'Se desabilitan los botones
			If FpExcluir.Contains("1") Then
                CmdEfe.Enabled = False
            End If
            If FpExcluir.Contains("2") Then
                CmdChe.Enabled = False
            End If
            If FpExcluir.Contains("3") Then
                CmdDeb.Enabled = False
            End If
            If FpExcluir.Contains("4") Then
                CmdCre.Enabled = False
            End If
            If FpExcluir.Contains("5") Then
                CmdTransfer.Enabled = False
            End If
            If FpExcluir.Contains("6") Then
                CmdBono.Enabled = False
            End If
        Else
			Llene_Combo5(LstForma, DtTipoFiltrado, "id", "descripcion")
		End If
        '/LFAA: 635 - Se carga la lista de formas de pago tomando en cuenta la regla de negocio para exclusión

        Dim NueCol As Boolean = True
        For I As Integer = 0 To DtBancos.Columns.Count - 1
            If LCase(DtBancos.Columns(I).ColumnName) = "calculada" Then
                NueCol = False
                Exit For
            End If
        Next
        If NueCol Then
            Dim DtColumn As New DataColumn("Calculada", GetType(System.String), "nombre + ' ' + isnull('('+[Cuenta Bancaria]+')','')")
            DtBancos.Columns.Add(DtColumn)
        End If

        'JFG-636 Solo mostrar los bancos sin cuenta contable
        Dim filtro As String = ""
        Dim filtro2 As String = ""
        If ReglaDeNegocio(165, "ban_sin_cuenta", 0) = "1" Then
            'JFG-640 Se cambia el filtro, solo bancos que no tienen banca electronica, y los que si tienen en el banco que recibe
            'filtro = "isnull(id_con_cta,0) = 0"
            'filtro2 = "isnull(id_con_cta,0) <> 0"
            filtro = "id_tes_bancos_e is null"
            filtro2 = "id_tes_bancos_e is not null"
            '/JFG-640 Se cambia el filtro, solo bancos que no tienen banca electronica, y los que si tienen en el banco que recibe
        End If

		'JFG-636 Solo mostrar los bancos sin cuenta contable

		cbBancos.DMSLlene_Combo(DtBancos, "id", "Calculada", filtro, , "No aplica", 0, , True) 'JFG-636 filtro

		cbBancosConsig.DMSLlene_Combo(DtBancos, "id", "Calculada", filtro2, , , , True) 'JFG-636 filtro2

        'obligatorio
        CmdNueva_Click(CmdNueva, New EventArgs)
        'obligado
        TxtPrecio.Tag = ""

        'obligatorio
        Sumar_Pago() 'solo por si volvió a entrar

        'LblPropina.Visible = Regla_SoyRestaurante_17()
        'TxtPropina.Visible = Regla_SoyRestaurante_17()
        'Grd.Columns("propina").Visible = Regla_SoyRestaurante_17()

        Try
            If Posfechado Then
                LstForma.SelectedIndex = 1
                LnkPosfe.Visible = False
            Else
                LstForma.SelectedIndex = 0
            End If
        Catch ex As Exception
        End Try


        'meter el valor que se resta para que el cliente solo pague el copago
        MeterBonoCopago()


    End Sub
    Private Sub MeterBonoCopago()
        If SinCopago = 0 Then Exit Sub
        If Grd.Rows.Count > 0 Then Exit Sub

        'If Grd.Rows.Count > 0 Then Exit Sub 'ya lo hizo

        PongaIndex(LstForma, 6) 'ponmense fijo bono
        TxtPrecio.Text = SinCopago
        TxtDoc.Text = SinCopago_Doc
        CmdOk_Click(CmdOk, New EventArgs)

    End Sub
    Public Sub Cargar_Datos()
        TxtFechaConsig.Value = FechaHoyAsignada()

        If DtTipoPago.Rows.Count = 0 Then
            Abrir(DtTipoPago, "Exec GetCotTipoPago " & Numero_Empresa.ToString)
        End If

        'JFG:2017-05-16 Filtra: 0= Normal, excluye Comprobante de retención, 1= Incluye Comprobante de retención, 3=solo Comprobante de retención
        If EsContEspecial = 3 Then
            DtTipoFiltrado = Filtrar_DataTable(DtTipoPago, "id = 30")
        ElseIf EsContEspecial = 0 Then
            DtTipoFiltrado = Filtrar_DataTable(DtTipoPago, "id <> 30")
        Else
            DtTipoFiltrado = DtTipoPago
        End If

        If DtBilletes.Rows.Count > 0 Then
            If Not Mostrar_Fotos_Billetes() Then 'si no hay fotos, cargarlas
                Cargar_Fotos_Billetes()
            End If
        End If

    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click

        Try
            TxtPrecio_Leave(TxtPrecio, New EventArgs)

            If Not IsNumeric(TxtPrecio.Text) Then 'salir del sistema
                If Grd.Rows.Count = 0 Then
                    Pagar_Resto()
                    TxtPrecio.Focus()
                    Exit Sub
                End If
                Salga_Sistema()
                Exit Sub
            End If

            If ValD(TxtPrecio.Text) <= 0 Then
                Mensaje("Entre valor")
                TxtPrecio.Focus()
            End If
            If Not PnlDoc.Visible Then
                TxtDoc.Text = ""
                TxtNot.Text = ""
                TxtIva.Text = ""
                cbBancos.DMSPongaIndex(0)
            End If

            If cbBancos.DMSTraerId > 0 And TxtDoc.Text = "" Then
                Mensaje("Entre numero de documento")
                TxtDoc.Focus()
                Exit Sub
            End If

            'If ReglaDeNegocio(165, "tc", "0") = "1" And (TraerId(LstForma) = 4) Then 
            If ReglaDeNegocio(165, "tc", "0") = "1" And EstaEnLista(TraerId(LstForma), 3, 4) Then 'JFG-567 Se incluye 3 = TD
                If cbBancos.DMSTraerId <= 0 Then 'transferencia
                    Mensaje("Entre el banco de la tarjeta. [tc] Rn#165")
                    cbBancos.Focus()
                    Exit Sub
                End If
                If ValD(TxtDoc.Text) <= 0 Then
                    Mensaje(Label1.Text & " debe ser númerico. [tc] Rn#165")
                    TxtDoc.Focus()
                    Exit Sub
                End If
                If ValD(TxtNot.Text) <= 0 Then
                    Mensaje(Label2.Text & " debe ser númerico. [tc] Rn#165")
                    TxtNot.Focus()
                    Exit Sub
                End If
            End If


            If (TraerId(LstForma) = 5 Or TraerId(LstForma) = 40) And cbBancosConsig.DMSTraerId <= 0 Then 'transferencia 'LFAA: 635 Se coloca la nueva forma de transferencia/cheque 40
                Mensaje("Entre el banco donde recibe la transferencia")
                cbBancosConsig.Focus()
                Exit Sub
            End If

            'validar store
            If TraerId(LstForma) = 8 Then 'transferencia
                If LblStoreTipo.Text = "" Then
                    Mensaje("Seleccione el Recibo o Devolución a aplicar")
                    Cargar_Store()
                    Exit Sub
                End If
                If ValD(TxtPrecio.Text) > ValD(LblStoreSaldo.Text) Then
                    Mensaje("Valor del documento Crédito es menor que el valor que pretende pagar")
                    Exit Sub
                End If
                'que no esté repetida
                For K As Integer = 0 To Grd.Rows.Count - 1
                    If ValD(Tm(Grd, "store_id_cot_tipo", K)) = ValD(LblStoreTipo.Tag) And ValD(Tm(Grd, "store_id", K)) = ValD(LblStoreID.Text) Then 'se encontró uno igual
                        If K <> ValD(CmdOk.Tag) Then
                            Mensaje("Documento duplicado, ya fue ingresado")
                            Exit Sub
                        Else
                            Exit For
                        End If
                    End If
                Next
            End If

            If TraerId(LstForma) = 2 Then 'transferencia
                If cbBancos.DMSTraerId <= 0 Then
                    Mensaje("Entre banco")
                    Exit Sub
                End If
            End If

            If TraerId(LstForma) = 3 And Consig_TD <> 0 Then 'td
                If cbBancosConsig.DMSTraerId <= 0 Then 'transferencia
                    Mensaje("Entre el banco donde consigna la tarjeta")
                    cbBancosConsig.Focus()
                    Exit Sub
                End If
            End If
            If TraerId(LstForma) = 4 And Consig_TC <> 0 Then 'td
                If cbBancosConsig.DMSTraerId <= 0 Then 'transferencia
                    Mensaje("Entre el banco donde consigna la tarjeta")
                    cbBancosConsig.Focus()
                    Exit Sub
                End If
            End If


            Dim I As Integer
            If ValD(CmdOk.Tag) >= 0 Then
                I = ValD(CmdOk.Tag)
            Else
                Grd.Rows.Add()
                I = Grd.Rows.Count - 1
            End If

            Grd.Rows(I).Cells("id").Value = TraerId(LstForma)
            Grd.Rows(I).Cells("forma").Value = LstForma.Text
            Grd.Rows(I).Cells("valor").Value = TxtPrecio.Text
            Grd.Rows(I).Cells("cambio").Value = 0 'al salir corrige este dato
            Grd.Rows(I).Cells("iva").Value = TxtIva.Text
            'Grd.Rows(I).Cells("propina").Value = TxtPropina.Text
            Grd.Rows(I).Cells("documento").Value = TxtDoc.Text
            Grd.Rows(I).Cells("notas").Value = TxtNot.Text
            Grd.Rows(I).Cells("banco").Value = IIf(cbBancos.DMSTraerId = 0, "", cbBancos.DMSTraerTexto)
            Grd.Rows(I).Cells("id_banco").Value = cbBancos.DMSTraerId
            Grd.Rows(I).Cells("id_banco_consig").Value = cbBancosConsig.DMSTraerId
            Grd.Rows(I).Cells("id_posfe").Value = ValD(LnkPosfe.Tag)

            If PnlFechaConsig.Visible And PnlFechaConsig.Enabled Then
                Grd.Rows(I).Cells("fecha_consig").Value = TxtFechaConsig.Value
            Else
                Grd.Rows(I).Cells("fecha_consig").Value = ""
            End If

            If PnlStore.Visible Then
                Grd.Rows(I).Cells("store_tipo").Value = LblStoreTipo.Text
                Grd.Rows(I).Cells("store_id_cot_tipo").Value = LblStoreTipo.Tag
                Grd.Rows(I).Cells("store_id").Value = LblStoreID.Text
                Grd.Rows(I).Cells("store_saldo").Value = LblStoreSaldo.Text
                Grd.Rows(I).Cells("notas").Value = "Sw" & LblStoreID.Tag & "/" & LblStoreID.Text
            End If

            'LFAA: 634 Coloco la información de UAFE para pago de terceros
            If fFTerUAFE Is Nothing Then
                Grd.Rows(I).Cells("tip_ide_ter").Value = ""
                Grd.Rows(I).Cells("ide_ter").Value = ""
                Grd.Rows(I).Cells("nombres_ter").Value = ""
            Else
                If fFTerUAFE.TxtIdentificacion.Text.ToString <> "" Then
                    Grd.Rows(I).Cells("tip_ide_ter").Value = ValD(TraerId(fFTerUAFE.CmbTipo))
                    Grd.Rows(I).Cells("ide_ter").Value = fFTerUAFE.TxtIdentificacion.Text
                    Grd.Rows(I).Cells("nombres_ter").Value = fFTerUAFE.TxtNombres.Text
                Else
                    Grd.Rows(I).Cells("tip_ide_ter").Value = ""
                    Grd.Rows(I).Cells("ide_ter").Value = ""
                    Grd.Rows(I).Cells("nombres_ter").Value = ""
                End If
            End If
            '/LFAA: 634 Coloco la información de UAFE para pago terceros

            TxtDoc.Tag = TxtDoc.Text 'para que el 1106 lo coja
            Sumar_Pago()

            CmdNueva_Click(CmdNueva, New EventArgs)

        Catch ex As Exception

        End Try


    End Sub
    Private Sub Salga_Sistema()
        If MezclaCreditoContado = 1 Then
            If Grd.Rows.Count <> 1 Then
                Mensaje("Cuando está mezclando crédito y contado, solo puede usar una forma de pago")
                Exit Sub
            End If
        End If

        Try
            'validar que esté completa la forma de pago
            If LblValorPagar.Visible Then
                'esto se comenta pues da menos de un centavo
                'If ValD(LblPagado.Text) < ValD(LblValorPagar.Text) + ValD(TxtPropina.Text) + ValD(LblAjuste.Text) Then
                If ValD(LblPendiente.Text) > 0 Then
                    Mensaje("No ha terminado de pagar, faltan " & LblPendiente.Text)
                    TxtPrecio.Focus()
                    Exit Sub
                End If
            End If

            'validar devuelta
            If ValD(LblPendiente.Text) < 0 And LblValorPagar.Visible Then 'hay cambio supuestamente
                Dim Efe As Double = 0 'determinar efectivo
                Dim Mayor As Double = -1 'determinar mayor efectivo
                Dim Renglon As Integer = -1
                For I = 0 To Grd.Rows.Count - 1
                    Dim RecibeCambio As Boolean = ReglaDeNegocio(141, "cambio" & ValD(Tm(Grd, "id", I)).ToString, "0") = "1"

                    If ValD("" & Obtenga_Dato(DtTipoPago, "id=" & Tm(Grd, "id", I).ToString, "pide_docto")) = 0 Or RecibeCambio Then 'es efectivo, para que la consignación reciba cambio
                        Efe = Efe + ValD(Tm(Grd, "valor", I))
                        If ValD(Tm(Grd, "valor")) > Mayor Then
                            Mayor = ValD(Tm(Grd, "valor")) 'este es el nuevo mayor
                            Renglon = I
                        End If
                    End If
                Next
                If Efe < ValD(LblPendiente.Tag) Then
                    Mensaje("Valor del cambio no puede ser mayor que el efectivo entregado")
                    Exit Sub
                End If
                If ValD(LblPendiente.Tag) > Mayor Then 'si el cambio no alcanza en ninguno de los efectivos recibidos, rechazarlo
                    Mensaje("Ninguno de los renglones donde ingreso efectivo alcanzar para guardar el valor del cambio")
                    Exit Sub
                End If
                If Renglon >= 0 Then
                    'meter el cambio
                    Grd.Rows(Renglon).Cells("cambio").Value = LblPendiente.Tag
                End If
            End If

            'armar la instrucción de SQL para insertar forma de pago
            Sql = ""
            'If ValD(LblPendiente.Text) < 0 Then 'hay cambio
            '    Sql += "Exec PutCotMeterCambio @Id," & ValDMS(ValD(LblPendiente.Tag))
            'Else
            '    Sql += "Exec PutCotMeterCambio @Id,0"
            'End If
            TxtPropina.Tag = TxtPropina.Text
            LblAjuste.Tag = LblAjuste.Text
            Sql += vbNewLine

            If SoyEgreso Then
                Sql += "Exec DelTesEgreso_Pago @Id" & DMScr()
                For I = 0 To Grd.Rows.Count - 1
                    Dim fff As String
                    If Tm(Grd, "fecha_consig", I) = "" Then
                        fff = ""
                    Else
                        fff = FmtFecSQL(FechaSinHora(Tm(Grd, "fecha_consig", I)))
                    End If

                    Sql += "Exec PutTesEgreso_Pago @Id," & Tm(Grd, "id", I).ToString & "," & ValDMS(ValD(Tm(Grd, "valor", I))) & "," & ValDMS(ValD(Tm(Grd, "iva", I))) & ",'" & SinComillas(Tm(Grd, "documento", I)) & "','" & SinComillas(Tm(Grd, "notas", I)) & "'," & ValD(Tm(Grd, "id_banco", I)).ToString & "," & ValD(Tm(Grd, "id_banco_consig", I)).ToString & ",'" & fff & "'" & DMScr()
                    TxtPropina.Tag = "0" 'para que solo se vaya una vez la propina
                    LblAjuste.Tag = "0"
                Next
            Else 'recibo caja
                Sql += "Exec DelCotCotizacion_Pago @Id" & DMScr()
                Dim comprobante As Boolean = False 'JFG:2017-05-16
                For I = 0 To Grd.Rows.Count - 1
                    Dim fff As String
                    If Tm(Grd, "fecha_consig", I) = "" Then
                        fff = ""
                    Else
                        fff = FmtFecSQL(FechaSinHora(Tm(Grd, "fecha_consig", I)))
                    End If

                    Sql += "Exec PutCotCotizacion_Pago " & Numero_Empresa &
                        ",@Id," &
                        Tm(Grd, "id", I).ToString & "," &
                        ValDMS(ValD(Tm(Grd, "valor", I))) &
                        "," & ValDMS(ValD(Tm(Grd, "iva", I))) &
                        "," & ValDMS(ValD(Tm(Grd, "cambio", I))) &
                        ",'" & SinComillas(Tm(Grd, "documento", I)) &
                        "','" & SinComillas(Tm(Grd, "notas", I)) &
                        "'," & ValDMS(ValD(TxtPropina.Tag) + ValD(LblAjuste.Tag)) &
                        "," & ValD(Tm(Grd, "id_banco", I)).ToString &
                        "," & ValD(Tm(Grd, "id_banco_consig", I)).ToString &
                        ",'" & fff &
                        "'," & Usuario.ToString &
                        "," & ValD(Tm(Grd, "store_id_cot_tipo", I)).ToString &
                        "," & ValD(Tm(Grd, "store_id", I)).ToString &
                        "," & MezclaCreditoContado &
                        "," & ValD(Tm(Grd, "id_posfe", I)).ToString &
                        "," & ValD(Tm(Grd, "tip_ide_ter", I)).ToString &  'LFAA: 634 Se coloca la información de UAF para pago de terceros
                        ",'" & Tm(Grd, "ide_ter", I).ToString & "'" &  'LFAA: 634 Se coloca la información de UAF para pago de terceros
                        ",'" & Tm(Grd, "nombres_ter", I).ToString & "'" &   'LFAA: 634 Se coloca la información de UAF para pago de terceros
                    DMScr()

                    TxtPropina.Tag = "0" 'para que solo se vaya una vez la propina
                    LblAjuste.Tag = "0"

                    '16-oct-2014: control para detectar error en valor del cambio, se puede quitar una vez se descubra el problema
                    If ValD(Tm(Grd, "valor", I)) = ValD(Tm(Grd, "cambio", I)) And ValD(LblValorPagar.Text) <> 0 Then
                        'SiReloj()
                        'Try
                        '    Abrir_Nodo_1(New DataSet, "Exec PutMensajes 1,2,'Trató de ingresar cambio igual a valor, emp=" & MiEmpresa & ", user=" & MiCodigo & "'")
                        'Catch ex As Exception
                        'End Try
                        'NoReloj()
                        Mensaje("Informe a DMS sobre este problema, valor de cambio igual a valor, intente de nuevo")
                        Me.Close()
                        Exit Sub
                    End If
                    '/16-oct-2014: control para detectar error en valor del cambio, se puede quitar una vez se descubra el problema
                    'JFG:2017-05-14 Para saber si se ingreso tipo de pago comprobante de retención
                    If ValD(Tm(Grd, "id", I)) = 30 Then
                        comprobante = True
                    End If

                Next
                'JFG:2017-05-14 Si es comprobante de retenciòn para que el 1106 lo coja
                If comprobante Then
                    EsContEspecial = 2
                Else
                    EsContEspecial = 0
                End If
                '/JFG:2017-05-14
            End If
            Sql += vbNewLine


            Me.Tag = "S"
            Me.Close()

        Catch ex As Exception

        End Try

    End Sub


    Private Sub TxtPrecio_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPrecio.Leave

        If Not IsNumeric(sender.Text) Then
            sender.Text = ""
            Exit Sub
        End If

		'sender.Text = FormatCurrency(ValD(sender.Text))
		sender.Text = FormatoMoneda(ValD(sender.Text)) 'JFG-655 evitar aprox en formatomoneda

	End Sub

    Private Sub CmdNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNueva.Click
        Try

            'LFAA: 634
            fFTerUAFE = Nothing
            '/LFAA: 634

            TxtPrecio.Text = TxtPrecio.Tag
            TxtDoc.Text = ""
            TxtNot.Text = ""
            TxtIva.Text = ""
            'TxtPropina.Text = ""
            If Posfechado Then
                LstForma.SelectedIndex = 1
            Else
                LstForma.SelectedIndex = 0
                cbBancos.DMSPongaIndex(0)
                cbBancosConsig.DMSPongaIndex(0)
            End If

            LnkPosfe.Tag = ""
            PnlDoc.Enabled = True

            CmdOk.Text = "Aceptar"
            CmdOk.Tag = -1

            TxtPrecio.Focus()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Grd_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grd.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        Editar()

    End Sub
    Private Sub Editar()
        Try
            If ValD(Tm(Grd, "id")) = 6 And SinCopago <> 0 Then 'no modificar sin copago
                Mensaje("Este renglón no es modificable")
                Exit Sub
            End If

            PongaIndex(LstForma, Tm(Grd, "id"))
            TxtPrecio.Text = Tm(Grd, "valor")
            TxtDoc.Text = Tm(Grd, "documento")
            TxtIva.Text = Tm(Grd, "iva")
            'TxtPropina.Text = Tm(Grd, "propina")
            TxtNot.Text = Tm(Grd, "notas")
            cbBancos.DMSPongaIndex(ValD(Tm(Grd, "id_banco")))
            cbBancosConsig.DMSPongaIndex(ValD(Tm(Grd, "id_banco_consig")))
            If Tm(Grd, "fecha_consig") <> "" Then
                TxtFechaConsig.Value = Tm(Grd, "fecha_consig")
            End If

            LblStoreTipo.Text = Tm(Grd, "store_tipo")
            LblStoreTipo.Tag = Tm(Grd, "store_id_cot_tipo")
            LblStoreID.Text = Tm(Grd, "store_id")
            LblStoreSaldo.Text = Tm(Grd, "store_saldo")

            LnkPosfe.Tag = Tm(Grd, "id_posfe")

            'LFAA: 634 Se recupera la información de pago de terceros para UAFE
            fFTerUAFE = Nothing
            fFTerUAFE = New fInfExtUAFE
            fFTerUAFE.CargarCombo()
            fFTerUAFE.CmbTipo.SelectedIndex = ValD(Tm(Grd, "tip_ide_ter")) - 1
            fFTerUAFE.TxtIdentificacion.Text = Tm(Grd, "ide_ter")
            fFTerUAFE.TxtNombres.Text = Tm(Grd, "nombres_ter")
            '/LFAA: 634 Se recupera la información de pago de terceros para UAFE

            If ValD(LnkPosfe.Tag) > 0 Then
                PnlDoc.Enabled = False
            End If

			CmdOk.Text = "Modificar"
			CmdOk.Tag = Grd.SelectedRows(0).Index 'para saber qué renglón está modificando

            TxtPrecio.SelectAll()
            TxtPrecio.Focus()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub LnkEditar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkEditar.LinkClicked
        If Grd.Rows.Count = 0 Then Exit Sub

        Editar()

    End Sub

    Private Sub LnkEliminar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkEliminar.LinkClicked
        Borrar_Renglon()

    End Sub
    Private Sub Borrar_Renglon()
        If Grd.Rows.Count = 0 Then Exit Sub

        If ValD(Tm(Grd, "id")) = 6 And SinCopago <> 0 Then 'no modificar sin copago
            Mensaje("Este renglón no es modificable")
            Exit Sub
        End If

        Grd.Rows.RemoveAt(Grd.SelectedRows(0).Index)

        Sumar_Pago()

        CmdNueva_Click(CmdNueva, New EventArgs)

    End Sub
    Public Sub Sumar_Pago()
        Try
            Dim Tot As Double = 0
            For I As Integer = 0 To Grd.Rows.Count - 1
                Tot = Tot + ValD(Tm(Grd, "valor", I))
            Next
            LblPagado.Text = FormatoMoneda(Tot)
            LblPendiente.Text = FormatoMoneda(ValD(LblValorPagar.Text) + ValD(TxtPropina.Text) + ValD(LblAjuste.Text) - Tot, , True)
            If ValD(LblPendiente.Text) < 0 Then
                LblPorPagar.Text = "Cambio"
                LblPendiente.ForeColor = LblFontRojo.ForeColor
                LblPendiente.Tag = FormatoMoneda(ValD(LblPendiente.Text) * -1)
            Else
                LblPorPagar.Text = "Por Pagar"
                LblPendiente.ForeColor = LblFontNegro.ForeColor
                LblPendiente.Tag = LblPendiente.Text
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Pagar_Resto()
        Try
            If ValD(LblPendiente.Text) <= 0 Then Exit Sub

            TxtPrecio.Text = LblPendiente.Text
            If LstForma.SelectedIndex = 0 Then
                CmdOk_Click(CmdOk, New EventArgs)
            Else
                TxtDoc.Focus()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmdEfe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEfe.Click, CmdDeb.Click, CmdCre.Click, CmdChe.Click, CmdTransfer.Click, CmdBono.Click
        Try
            'LFAA: 635 Se realiza la validación de los botones
            Dim FpExcluir As String = ""
            Dim IdFP As String = ""

            'SGQ-664
            'FpExcluir = ReglaDeNegocio(165, "fp_excluir", "0")
            FpExcluir = ReglaDeNegocio(165, "fp_excluir", "")
            '/SGQ-664

            If FpExcluir <> "" Then
                If FpExcluir.Contains((ValD(sender.tag)) + 1).ToString Then
                    Mensaje("Forma de pago deshabilitada")
                    Exit Sub
                Else
                    IdFP = (sender.tag + 1).ToString
                    If ValD(sender.tag) = 0 Then
                        If Not FpExcluir.Contains(IdFP) Then
                            LstForma.Text = "Efectivo"
                        End If
                    End If
                    If ValD(sender.tag) = 1 Then
                        If Not FpExcluir.Contains(IdFP) Then
                            LstForma.Text = "Cheque"
                        End If
                    End If
                    If ValD(sender.tag) = 2 Then
                        If Not FpExcluir.Contains(IdFP) Then
                            LstForma.Text = "Tarjeta Debito"
                        End If
                    End If
                    If ValD(sender.tag) = 3 Then
                        If Not FpExcluir.Contains(IdFP) Then
                            LstForma.Text = "Tarjeta Credito"
                        End If
                    End If
                    If ValD(sender.tag) = 4 Then
                        If Not FpExcluir.Contains(IdFP) Then
                            LstForma.Text = "Transferencia o Consig"
                        End If
                    End If
                    If ValD(sender.tag) = 5 Then
                        If Not FpExcluir.Contains(IdFP) Then
                            LstForma.Text = "Bono"
                        End If
                    End If
                End If
            Else
                LstForma.SelectedIndex = ValD(sender.tag)
                TxtPrecio.Focus()
            End If
            'LstForma.SelectedIndex = ValD(sender.tag)
            'TxtPrecio.Focus()
            '/LFAA: 635 Se realia la validación de los botones
        Catch ex As Exception

        End Try

    End Sub

	Private Sub LstForma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstForma.SelectedIndexChanged
		LblIdForma.Text = TraerId(LstForma)
		If TraerId(LstForma) = 8 And IdCliente = 0 Then
			Mensaje("Esta forma de pago no está disponible para este programa.  Solo en ventas")
			LstForma.SelectedIndex = 0
			Exit Sub
		End If

		If LstForma.SelectedIndex <> 1 Then 'cheque
			LnkPosfe.Tag = "" 'limpiar este campo
		End If

		Dim ManejaDoc As Boolean = IIf(Val("" & Obtenga_Dato(DtTipoPago, "id=" & TraerId(LstForma).ToString, "pide_docto")) = 1, True, False)

		PnlDoc.Visible = ManejaDoc
		PnlStore.Visible = False
		LblStoreID.Text = ""
		LblStoreSaldo.Text = ""
		LblStoreTipo.Text = ""

		PnlBilletes.Visible = TraerId(LstForma) = 1

		'SGQ-660: Para otras formas de pago
		'PnlConsig.Visible = EstaEnLista(TraerId(LstForma), 3, 4, 5, 40) 'LFAA: 635 Se coloca la nueva forma de pago transferencia/cheque 40
		PnlConsig.Visible = EstaEnLista(TraerId(LstForma), 3, 4, 5, 40) Or EstaEnLista(TraerId(LstForma), ReglaDeNegocio("165", "banco_fp5", "0").Split(",")) 'LFAA: 635 Se coloca la nueva forma de pago transferencia/cheque 40
		'/SGQ-660: Para otras formas de pago
		PnlConsig.Enabled = True

		If TraerId(LstForma) = 3 Then 'td
			If Consig_TD > 0 Then
				PnlConsig.Enabled = False
				cbBancosConsig.DMSPongaIndex(Consig_TD)
			ElseIf Consig_TD = 0 Then
				PnlConsig.Visible = False
				cbBancosConsig.DMSPongaIndex(-1)
			End If
		ElseIf TraerId(LstForma) = 4 Then 'tc
			If Consig_TC > 0 Then
				PnlConsig.Enabled = False
				cbBancosConsig.DMSPongaIndex(Consig_TC)
			ElseIf Consig_TC = 0 Then
				PnlConsig.Visible = False
				cbBancosConsig.DMSPongaIndex(Consig_TC)
			End If
		ElseIf TraerId(LstForma) = 8 Then 'Store Credit
			PnlStore.Visible = True
			'2015-11-12: le quito esto para que pueda aceptar varias
			'If Grd.Rows.Count = 0 Then
			'    Cargar_Store()
			'End If
			Cargar_Store()
		End If

		'todas las formas de pago tendrán esta posibilidad
		'PnlFechaConsig.Visible = TraerId(LstForma) = 2 Or TraerId(LstForma) = 5
		PnlFechaConsig.Visible = True

		LnkPosfe.Visible = False
		If LstForma.SelectedIndex = 1 And Not Posfechado Then 'cheque
			LnkPosfe.Visible = True
		End If

		TxtPrecio.Focus()

	End Sub
	Private Sub Cargar_Store()
        LblStoreTipo.Text = ""
        LblStoreID.Text = ""
        LblStoreSaldo.Text = ""


        Try
            SiReloj()
            Dim Dt As New DataTable
            Abrir(Dt, "GetCotStoreCreditDisponible " & IdCliente.ToString)
            NoReloj()
            Dim Doc As String = Ventana(Dt, "Seleccione documento", True, "llave", New Object() {"llave", "id_cot_tipo"})
            If Doc <> "" Then
                Dim Dt2 As New DataTable
                Dt2 = Filtrar_DataTable(Dt, "llave='" & Doc & "'")

                LblStoreTipo.Text = Gdf(Dt2, "tipo")
                LblStoreTipo.Tag = Gdf(Dt2, "id_cot_tipo")
                LblStoreID.Text = Gdf(Dt2, "id")
                LblStoreID.Tag = Gdf(Dt2, "sw")
				LblStoreSaldo.Text = FormatoMoneda(Gdf(Dt2, "saldo"), True, True) 'JFG-655 FormatoMoneda sin decimales
				Meta_Store()
			End If
        Catch ex As Exception
			MostrarError(Me.Name, "Cargar_Store", ex.Message)
		End Try

		NoReloj()

	End Sub

	Private Sub TxtPropina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPropina.Click
		Dim Valor As String = Inputbox2("Valor Propina", , TxtPropina.Text)
		If Not IsNumeric(Valor) Then
			Exit Sub
		End If
		If ValD(TxtPropina.Text) <> ValD(Valor) Then
			TxtPropina.Text = FormatoMoneda(Valor)
			LblAjuste.Text = "0"
			Sumar_Pago()
		End If

	End Sub

	Private Sub Cargar_Fotos_Billetes()
		Try

			Dim Dt As New DataTable
			Abrir(Dt, "Exec GetCotBilletes " & Numero_Empresa.ToString)
			For I As Integer = 0 To Dt.Rows.Count - 1
				If Gdf(Dt, I, "imagen") IsNot System.DBNull.Value Then
					Dim Foto As String = Path_Temp & "b" & Gdf(Dt, I, "id_pais").ToString & "_" & Gdf(Dt, I, "valor").ToString & ".jpg"
					SalvarFoto(CType(Gdf(Dt, I, "imagen"), Byte()), Foto, "")
				End If
			Next

			Mostrar_Fotos_Billetes()

		Catch ex As Exception

		End Try



	End Sub
	Private Function Mostrar_Fotos_Billetes() As Boolean
		Dim Encontro As Boolean = False

		Try
			For I As Integer = 0 To DtBilletes.Rows.Count - 1
				Dim Foto As String = Path_Temp & "b" & Gdf(DtBilletes, I, "id_pais").ToString & "_" & Gdf(DtBilletes, I, "valor").ToString & ".jpg"
				If Dir(Foto, FileAttribute.Archive) <> "" Then
					Dim Pic As PictureBox = DirectCast(Me.Controls.Find("PictureBox" & I.ToString, True)(0), PictureBox)
					Pic.ImageLocation = Foto
					'Dim Lbl As Label = DirectCast(Me.Controls.Find("LTit" & I.ToString, True)(0), Label)
					'Lbl.Text = FormatoMoneda(Gdf(DtBilletes, I, "valor"), False, False, 0)
					'Lbl.Tag = Gdf(DtBilletes, I, "valor")
					'Lbl.Visible = True
					Pic.Tag = Gdf(DtBilletes, I, "valor")
					Pic.Visible = True
					Encontro = True
				Else
					Return False
				End If
			Next

			Return Encontro

		Catch ex As Exception
			Return False

		End Try
	End Function

	Private Sub PictureBox0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox0.Click, PictureBox7.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox3.Click, PictureBox2.Click, PictureBox1.Click, PictureBox8.Click, PictureBox9.Click, PictureBox10.Click, PictureBox11.Click, PictureBox12.Click, PictureBox13.Click, PictureBox14.Click, PictureBox15.Click
		Try
			'Dim Lbl As Label = DirectCast(Me.Controls.Find("LTit" & ObtengaNumeroObjeto(sender).ToString, True)(0), Label)
			TxtPrecio.Text = FormatoMoneda(ValD(TxtPrecio.Text) + sender.Tag)
			Try
				'My.Computer.Audio.Play(Path_Prog & "product.wav", AudioPlayMode.Background)
				SonarWAV("product")
			Catch ex As Exception
				Beep()
			End Try

		Catch ex As Exception

		End Try



	End Sub


	Private Sub LnkSaldo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkSaldo.LinkClicked
		If cbBancos.DMSTraerId <= 0 Then
			Mensaje("Banco")
			Exit Sub
		End If

		If ValD(LnkSaldo.Tag) = 0 Then
			Mensaje("Desde este programa no se puede consultar saldo de cuentas")
			Exit Sub
		End If

		Dim Cta As String = "" & Obtenga_Dato(DtBancos, "id=" & cbBancos.DMSTraerId.ToString, "cuenta")

		If NoPuede4(NumeroPrograma, ValD(LnkSaldo.Tag), , , "Saldo de la cuenta " & Cta) Then
			Exit Sub
		End If

		Try
			SiReloj()

			Dim Dt As New DataTable
			Abrir(Dt, "GetConSaldoCuenta " & Numero_Empresa.ToString & ",'" & Cta & "'," & Year(FechaHoyAsignada).ToString & "," & Month(FechaHoyAsignada) & ",1")
			NoReloj()

			If Not Fin(Dt) Then
				Mensaje("Saldo: " & FormatoMoneda(Gdf(Dt, "saldo"), True, True))
			Else
				Mensaje("Cuenta no existe")
			End If
		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "LnkSaldo_LinkClicked", ex.Message)

		End Try

	End Sub

	Private Sub LnkBuscarStore_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkBuscarStore.LinkClicked
		'Muy importante esto
		If Val(CmdOk.Tag) >= 0 Then 'para que lo deje ingresar de nuevo
			Grd.Rows.RemoveAt(Grd.Rows(0).Index)
			Sumar_Pago()
			CmdOk.Tag = -1
		End If

		Cargar_Store()

	End Sub

	Private Sub LblStoreSaldo_Click(sender As System.Object, e As System.EventArgs) Handles LblStoreSaldo.Click
		Meta_Store()

	End Sub
	Private Sub Meta_Store()
		If ValD(LblStoreSaldo.Text) > ValD(LblPendiente.Text) Then
			TxtPrecio.Text = LblPendiente.Text
		Else
			TxtPrecio.Text = LblStoreSaldo.Text
		End If

		CmdOk_Click(CmdOk, New EventArgs)

	End Sub

	Private Sub LblPendiente_Click(sender As System.Object, e As System.EventArgs) Handles LblPendiente.Click
		Pagar_Resto()

	End Sub

	Private Sub CmdConti_Click(sender As Object, e As EventArgs) Handles CmdConti.Click
		Salga_Sistema()
		'LFAA: 634
		fFTerUAFE = Nothing
		'/LFAA: 634
	End Sub

	Private Sub LnkPosfe_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkPosfe.LinkClicked
		Try
			SiReloj()
			Dim Dt As New DataTable
			Abrir(Dt, "Exec GetCotRecibosPosfe " & IdCliente)

			NoReloj()

			If Fin(Dt) Then
				Mensaje("Cliente no tiene recibos posfechados")
				Exit Sub
			End If

			Dim IdRec As String
			IdRec = Ventana(Dt, "Recibos posfechados", True, "id_cot_recibo_pago")
			If IdRec = "" Then
				Exit Sub
			End If

			Dim Dt2 As DataTable = Filtrar_DataTable(Dt, "id_cot_recibo_pago=" & IdRec)

			TxtPrecio.Text = FormatoMoneda(Gdf(Dt2, "valor"))
			cbBancos.DMSPongaIndex(Gdf(Dt2, "id_tes_bancos"))
			TxtFechaConsig.Value = Gdf(Dt2, "fecha_consig")
			TxtDoc.Text = "" & Gdf(Dt2, "documento")
			TxtNot.Text = "" & Gdf(Dt2, "notas")


			PnlDoc.Enabled = False
			LnkPosfe.Tag = IdRec


		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "LnkPosfe_LinkClicked", ex.Message)

		End Try
	End Sub
	'LFAA: 634 Se llama a la pantalla de pago 
	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkPagoTerceros.LinkClicked
		Try
			If fFTerUAFE Is Nothing Then
				fFTerUAFE = New fInfExtUAFE
				fFTerUAFE.CargarCombo()
			End If
			MostrarForma3(Me.Icon, fFTerUAFE, True, "UAFE - Pago de terceros")
		Catch ex As Exception
			MostrarError(Me.Name, "LinkLabel1_LinkClicked", ex.Message)
		End Try
    End Sub

	'/LFAA: 634 Se llama a la pantalla de pago
End Class