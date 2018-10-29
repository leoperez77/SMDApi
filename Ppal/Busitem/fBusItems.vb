' Version: 684, 25-ago.-2018 20:17
' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 21-ago.-2018 10:37
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 670, 26-jul.-2018 12:55
' Version: 661, 10-jul.-2018 13:27
' Version: 655, 1-jun.-2018 12:53
' Version: 654, 24-may.-2018 13:05
' Version: 648, 26-abr.-2018 12:37
' Version: 638, 20-mar.-2018 12:16
' Version: 606, 14-dic.-2017 13:05
' Version: 600, 27-nov.-2017 18:45
' Version: 599, 22-nov.-2017 12:55
' Version: 597, 14-nov.-2017 14:55
' Version: 596, 9-nov.-2017 19:28
' Version: 595, 8-nov.-2017 08:03
' Version: 595, 7-nov.-2017 15:15
' Version: 595, 7-nov.-2017 11:14
'♥ versión: 586, 6-oct.-2017 07:11



Public Class fBusItems
    Public IdBod As Integer = 0
    Dim Mayores As Double
    Dim Cargando As Boolean = True
    Dim DsItem As New DataSet
    Dim DsLin As New DataSet
    Dim Ini As DateTime
    Dim MaxI As Integer = 5000 'máximo de líneas que trae de stock
    Dim DtSto As New DataTable
    Dim DtSto2 As New DataTable
    Dim MySql As String = ""
    Dim BodegaPromocion As String = ""
    Public lblPrecioNro As Integer = 0
    Public lblPrecioID As Integer = 0
    Public UsarCant As Boolean = False
    Public Cliente As Integer = 0
    Public DtItemSalamanca As DataTable
    Dim fVa As fVarios
    Dim SiVarios As Boolean = False
    Dim PorceDescu As Double = 0
    Dim PrecioMasIva As Boolean = False
    Dim CuantosHay As Integer
    Dim BusquedaNueva As Boolean = False



    Private Function DtItem() As DataTable
        If Fin(DtItemSalamanca) Then
            Return SMDPpal.DtItem
        Else
            Return DtItemSalamanca
        End If

    End Function

    Private Sub fBusItems_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Not TxtBuscarItem.Focused And Not BusquedaNueva Then
                TxtBuscarItem.Focus()
            Else
                CmdCancelar_Click(CmdCancelar, Nothing)
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            LnkAvanzado_LinkClicked(LnkAvanzado, Nothing)
        End If

    End Sub

    Private Sub fBusItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Recorrer_Controles_Idioma(me, me)

        'no va nada en el Load, todo está en el shown
        If Cliente > 0 Then
            BusquedaNueva = ReglaDeNegocio(122, "nuevosistema", "0") = "1"
        End If
        LblMas.Visible = BusquedaNueva


    End Sub

    Private Sub fBusItems_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If ChkLimpiar.Checked And ValD(ChkLimpiar.Tag) = 0 Then
            TxtBuscarItem.Text = ""
            CbGrupo.DMSPongaIndex(0)
            CbSubgrupo.DMSPongaIndex(0)
            CbTalla.DMSPongaIndex(0)
            CbGener.DMSPongaIndex(0)
            CbProv.DMSPongaIndex(0)
            TxtBuscarItem.Focus()
        Else
            If GrdBus.Rows.Count > 0 Then
                Foco_Grid()
            Else
                TxtBuscarItem.Focus()
            End If
        End If

    End Sub
    Private Sub Foco_Grid()
        If BusquedaNueva Then
            GrdNue.Focus()
        Else
            GrdBus.Focus()
        End If

    End Sub
    Private Sub HandHeld()
        TxtBuscarItem.Width = 90
        CmdBuscar.Left = 137
        CmdModificar.Left = 190
        CmdModificar.Width = 28

        LnkAvanzado.Visible = False
        LnkAbrir.Visible = False
        LblStock.Visible = False
        LnkExcel.Visible = False
        CmdCancelar.Visible = False
        PicItem.Visible = False
        ChkOcultarPrecio.Visible = False

        CbBod.Width = 179
        CbGrupo.Width = 179
        CbSubgrupo.Width = 179

        LblNegrilla.Visible = False
        LinkLabel1.Visible = False

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub GrdBus_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdBus.CellClick
        If e.RowIndex < 0 Then Exit Sub


        Try
            If GrdBus.Columns(e.ColumnIndex).Index = GrdBus.Columns("tiene_imagen").Index Then 'click en imagen
                SiReloj()
                Traiga_Foto_Item(PicItem, Tm(GrdBus, "id"))
                PicItem.Tag = Tm(GrdBus, "id")
                NoReloj()

                'Dim pic As New PictureBox
                'pic.Image = PicItem.Image
                ''AbrirImagen("cot_item", 0, 0, 0, pic, False)
                'AbrirImagen("cot_item", Tm(GrdBus, "id"), 100000, 1500, pic, False)
            ElseIf GrdBus.Columns(e.ColumnIndex).Index = GrdBus.Columns("neto").Index Then 'click en precio
                If Mid(Tm(GrdBus, "neto"), 1, 4) = "Clic" Then 'buscar precio 
                    SiReloj()

                    'sistema anterior a 3-nov-2017
                    'Try
                    '	Dim DT As New DataTable

                    '	Abrir(DT, "select costo_promedio=avg(case when i.maneja_lotes is null then v.costo_promedio else -1 end) from v_cot_item_stock_tot_real v join cot_item i on i.id=v.id_cot_item where v.id_cot_item=" & Tm(GrdBus, "id").ToString)
                    '	'Mensaje("ID:" & Tm(GrdBus, "id") & ", bod=" & Tm(GrdBus, "bodega"))
                    '	If Not Fin(DT) Then
                    '		If Gdf(DT, "costo_promedio") = -1 Then
                    '			Tm2(GrdBus, "neto", GrdBus.SelectedRows(0).Index, "N/D")
                    '			Mensaje_TopMost("No puede calcular el precio pues éste depende del Lote o serial que seleccione", GuardarRespuestaSI_NombreForma:=Me.Name)
                    '		Else
                    '			Dim Factor = ValD(Mid(Tm(GrdBus, "neto"), 5))
                    '			Factor = 1 + (1 / ((100 - ValD(Factor)) / ValD(Factor)))

                    '			If ChkPrecioCaja.Checked Then
                    '				Dim CanCaja As Integer = 1
                    '				Dim PIC As Integer = InStr(Tm(GrdBus, "und"), " x")
                    '				If PIC > 0 Then
                    '					CanCaja = ValD(Mid(Tm(GrdBus, "und"), PIC + 2))
                    '				End If
                    '				Factor *= CanCaja
                    '			End If

                    '			Tm2(GrdBus, "neto", GrdBus.SelectedRows(0).Index, FormatoMoneda(Gdf(DT, "costo_promedio") * Factor, True, True))
                    '		End If
                    '	Else
                    '		Tm2(GrdBus, "neto", GrdBus.SelectedRows(0).Index, "No hay")
                    '	End If
                    'Catch ex As Exception
                    '	MostrarError(Me.Name, "GrdBus_CellClick", ex.Message & EsIngles)
                    'End Try

                    'JDMS 595: nuevo sistema
                    Dim Dtpr As DataTable = ClasePrecios.ObtengaPrecioItem(
                                          Tm(GrdBus, "codigo"),
                                          IdBod,
                                          lblPrecioID,
                                          False,
                                          False,
                                          Cliente,
                                          -1,
                                          -1
                                          )            '/nueva rutina de precio, mandamos el costo ultimo en negativo para que lo busque en la base de datos
                    '



                    If Fin(Dtpr) Then
                        Exit Sub
                    End If
                    If Dtpr.Columns.Contains("error") Then
                        Exit Sub
                    End If

                    Dim C_Pre As String = ""
                    Dim C_Des As String = ""

                    C_Pre = FormatoMoneda(ValD(Gdf(Dtpr, "precio")))
                    Tm2(GrdBus, "neto", GrdBus.SelectedRows(0).Index, C_Pre)
                    '/JDMS 595: nuevo sistema


                    NoReloj()

                End If

            End If

        Catch ex As Exception
            NoReloj()
            Mensaje("Intente más tarde")

        End Try


    End Sub
    Private Sub GrdBus_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdBus.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        If Me.Tag = "consulta" Then
            AbraItem()
        Else
            CmdModificar_Click(CmdModificar, New EventArgs)
        End If

    End Sub

    Private Sub CmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdModificar.Click
        If Me.Tag = "consulta" Then
            Me.Close()
            Exit Sub
        End If


        If BusquedaNueva Then
            GoTo HagaNueva
        End If

        If GrdBus.Rows.Count = 0 And (TxtBuscarItem.Text <> "" Or TxtCod.Text <> "") Then
            CmdBuscar_Click(CmdBuscar, New EventArgs)
            Exit Sub
        End If

        If GrdBus.Rows.Count = 0 Then
            ItemBuscado = ""
            Me.Hide()
        Else
            If GrdBus.SelectedRows.Count = 0 Then
                GrdBus.Rows(0).Selected = True
            End If
            ItemBuscado = Tm(GrdBus, "codigo")
            CbBod.Tag = ValD(Tm(GrdBus, "bodega"))
            Me.Hide()
        End If

        Exit Sub

HagaNueva:
        If GrdNue.Grid.Rows.Count = 0 And (TxtBuscarItem.Text <> "" Or TxtCod.Text <> "") Then
            CmdBuscar_Click(CmdBuscar, New EventArgs)
            Exit Sub
        End If

        If GrdNue.Grid.Rows.Count = 0 Then
            ItemBuscado = ""
            Me.Hide()
        Else
            If GrdNue.Grid.SelectedRows.Count = 0 Then
                GrdNue.Grid.Rows(0).Selected = True
            End If
            ItemBuscado = Tm(GrdNue.Grid, "codigo")
            CbBod.Tag = CbBod.DMSTraerId
            Me.Hide()
        End If

    End Sub

    Private Sub CbGrupo_DMSSelectIndex(Sender As System.Object, Id As System.Int32) Handles CbGrupo.DMSSelectIndex
        'TxtBuscarItem.Text = ""
        CbSubgrupo.ComboBox1.DataSource = Nothing
        Limpiar()


        SaveSett(Me.Name, "gru", CbGrupo.DMSTraerId.ToString)

        'If CbGrupo.DMSTraerId > 0 Then
        '    CbGrupo.ComboBox1.Font = LblNegrilla.Font
        'Else
        '    CbGrupo.ComboBox1.Font = LblItem.Font
        'End If

        If CbGrupo.ComboBox1.SelectedIndex < 0 Then Exit Sub

        'Dim algo As DataDescription
        'algo = CbGrupo.SelectedItem

        CbSubgrupo.DMSLlene_Combo(QuiteDuplicados2(DtCotGrupos, "id_hijo", "des_hijo", "id_padre=" & CbGrupo.DMSTraerId), "id_hijo", "des_hijo", , , "Todos", 0)

        GrdBus.Rows.Clear()

        'CmdBuscar_Click(CmdBuscar, New EventArgs)
        'TxtBuscarItem.Focus()
        'TxtBuscarItem.SelectAll()


    End Sub

    Private Sub TxtBuscarItem_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBuscarItem.LostFocus
        TxtBuscarItem.Text = Trim(TxtBuscarItem.Text)

    End Sub
    Private Sub CbSubgrupo_DMSSelectIndex(Sender As System.Object, Id As System.Int32) Handles CbSubgrupo.DMSSelectIndex
        'TxtBuscarItem.Text = ""
        Limpiar()


        'If TraerId(CbSubgrupo) > 0 Then
        '    CbSubgrupo.ComboBox1.Font = LblNegrilla.Font
        'Else
        '    CbSubgrupo.ComboBox1.Font = LblItem.Font
        'End If


        If CbSubgrupo.ComboBox1.SelectedIndex < 0 Then Exit Sub
        'Haga_Buscar()
        GrdBus.Rows.Clear()
        GrdNue.Grid.DataSource = Nothing
        'CmdBuscar_Click(CmdBuscar, New EventArgs)

    End Sub
    Private Sub Obtenga_Precio(Row As DataRow, ByVal Prec As Double, ByRef C_Pre As String, ByRef C_Des As String, Bodeguita As Integer)

        If lblPrecioNro <= 0 Then Exit Sub

        Dim Cost As Double = ValD(Row("ultimo_costo")) * -1
        If Cost = 0 Then Cost = -1
        Dim Dtpr As DataTable = ClasePrecios.ObtengaPrecioItem(
                                          Row("codigo"),
                                          Bodeguita,
                                          lblPrecioID,
                                          False,
                                          False,
                                          Cliente,
                                          -1,
                                          Cost
                                          )            '/nueva rutina de precio, mandamos el costo ultimo en negativo para que lo busque en la base de datos
        '



        If Fin(Dtpr) Then
            Exit Sub
        End If
        If Dtpr.Columns.Contains("error") Then
            Exit Sub
        End If

        C_Des = ""
        If Prec <> 0 Then
            C_Des = (Prec - ValD(Gdf(Dtpr, "precio"))) / Prec * 100
        End If
        C_Des = Strings.Format(ValD(C_Des), "0.00")
        C_Pre = FormatoMoneda(ValD(Gdf(Dtpr, "precio")))

        If Dtpr.Columns.Contains("pre_prom") Then
            C_Pre = "*" 'significa que debe buscarlo de nuevo
        End If


    End Sub
    Private Sub Haga_Buscar()
        If Cargando Then Exit Sub
        'If DtItem.Rows.Count = 0 Then
        '    Exit Sub
        'End If

        If BackTraerStock.IsBusy Then
            Mensaje("La consulta está buscando stock en este momento, intente de nuevo en 10 segundos")
            Exit Sub
        End If

        Parte_Bodega()

        PnlProc.Visible = True
        Label14.Tag = "Procesando consulta..."
        Label14.Text = Label14.Tag
        HagaEventos()

        TxtBuscarItem2.Tag = TxtBuscarItem2.Text.Trim
        TxtCod.Tag = TxtCod.Text.Trim

        TxtBuscarItem.Text = TxtBuscarItem.Text.Trim
        TxtBuscarItem2.Text = TxtBuscarItem2.Tag
        TxtCod.Text = TxtCod.Tag

        If TxtBuscarItem.Text = "" And
            TxtCod.Text = "" And
            CbGrupo.DMSTraerId = 0 And
            SiVarios = False And
            CbTalla.DMSTraerId = 0 And
            TxtAlterna.Text = "" And
            CbGener.DMSTraerId = 0 And
            CbMarca.SelectedIndex < 0 Then
            Mensaje("Debe ingresar algún texto a buscar o un grupo o subgrupo o campos varios o genérico o línea")
            TxtBuscarItem.Focus()
            Exit Sub
        End If
        If InStr(TxtBuscarItem.Text, "'") > 0 Or InStr(TxtBuscarItem2.Text, "'") Or InStr(TxtCod.Text, "'") > 0 Then
            Mensaje("No puede incluir el caracter ' en el texto")
            Exit Sub
        End If
        If TxtAlterna.Text <> "" And SiVarios Then
            Mensaje("No puede usar campos varios y alterna al mismo tiempo en esta consulta")
            Exit Sub
        End If

        GrdBus.Columns("proveedor").Visible = CbProv.DMSTraerId = 0



        SiReloj(Me)

        Cargar_Items()

        'If lblPrecioNro > 0 Then
        '    If DtListasFac Is Nothing Then
        '        Abrir(DtListasFac, "select il.precio_nro,l.id_cot_item_categoria,l.id_cot_bodega,factor=case when l.factor=0.9999 then 1 else l.factor end,l.tipo from cot_item_categoria c join cot_item_categoria_listas l on l.id_cot_item_categoria=c.id join cot_item_listas il on il.id=l.id_cot_item_listas where c.id_emp=" & Numero_Empresa.ToString)
        '    End If
        'End If
        'TxtMas.Text = ""

        'Dim algo As DataDescription
        'algo = CbSubgrupo.SelectedItem

        PorceDescu = (1 - ValD(TxtDcto.Text) / 100)


        GlobalesVarios.SQL = ""

        'primero buscar los items de varios
        Dim DtI2 As New DataTable
        Dim Sq As String = ""
        Try
            If SiVarios Then
                Sq = fVa.CamposAdicionales1.DMSHagaSQL_Actualizar("-1")
                If Sq <> "" Then
                    Sq &= "Select top 1000 id_cot_item from cot_item_varios_tem where id_usuario=" & Usuario.ToString & DMScr()
                    Dim Dt2 As New DataTable
                    Abrir(Dt2, Sq)
                    'filtrar dtitem
                    Dim SS As New System.Text.StringBuilder
                    For Each Fi As DataRow In Dt2.Rows
                        SS.Append(Fi("id_cot_item") & ",")
                    Next
                    If SS.ToString <> "" Then
                        If RealTime > 0 Then
                            GlobalesVarios.SQL = "id in(" & Mid(SS.ToString, 1, SS.ToString.Length - 1) & ")"
                            DtI2 = Leer_De_BD()
                            GlobalesVarios.SQL = ""
                        Else
                            DtI2 = Filtrar_DataTable(DtItem, "id in(" & Mid(SS.ToString, 1, SS.ToString.Length - 1) & ")")
                        End If
                        If Fin(DtI2) Then
                            NoReloj()
                            Mensaje("No encontró resultados.  Revise los campos Varios")
                            Exit Sub
                        End If
                        If DtI2.Rows.Count = 1000 Then
                            Mensaje("Del filtro de campos adicionales, solo selecionó los primeros 1000 resultados.  Se sugiere utilizar filtros más complejos")
                        End If
                    Else
                        NoReloj()
                        Mensaje("No encontró nada en los campos varios")
                        Exit Sub
                    End If
                Else
                    NoReloj()
                    Mensaje("No encontró nada en los campos varios")
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MostrarError(Me.Name, "Haga_Buscar-Varios", ex.Message)
            NoReloj()
            Exit Sub
        End Try
        '/primero buscar los items de varios



        'segundo buscar las alternas
        Try
            If TxtAlterna.Text.Trim <> "" Then
                'Sq &= "Select top 1000 a.id_cot_item from cot_item_alt a join cot_item i on i.id_emp=" & Numero_Empresa & " and i.id=a.id_cot_item where a.codigo='" & TxtAlterna.Text.Replace("'", "''") & "'" & DMScr()
                'Dim Dt2 As New DataTable
                'Abrir(Dt2, Sq)
                Dim Dt2 As DataTable = Filtrar_DataTable(DtItemCod, "codigo='" & TxtAlterna.Text.Replace("'", "''") & "'")

                'filtrar dtitem
                Dim SS As New System.Text.StringBuilder
                For Each Fi As DataRow In Dt2.Rows
                    SS.Append(Fi("id") & ",")
                Next
                If SS.ToString <> "" Then
                    If RealTime > 0 Then
                        GlobalesVarios.SQL = "id in(" & Mid(SS.ToString, 1, SS.ToString.Length - 1) & ")"
                        DtI2 = Leer_De_BD()
                        GlobalesVarios.SQL = ""
                    Else
                        DtI2 = Filtrar_DataTable(DtItem, "id in(" & Mid(SS.ToString, 1, SS.ToString.Length - 1) & ")")
                    End If
                    If Fin(DtI2) Then
                        NoReloj()
                        Mensaje(Idi("No encontró resultados con esta alterna") & ": " & TxtAlterna.Text)
                        Exit Sub
                    End If
                Else
                    NoReloj()
                    Mensaje(Idi("No encontró resultados con esta alterna") & ": " & TxtAlterna.Text)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MostrarError(Me.Name, "Campos-Varios", ex.Message)
            NoReloj()
            Exit Sub
        End Try
        '/segundo buscar las alternas


        Try
            If Not ChkTodos.Checked Then
                AdicioneSql("IsNull(anulado,0)=0")
            End If

            If CbProv.DMSTraerId > 0 Then
                AdicioneSql("id_cot_cliente=" & CbProv.DMSTraerId.ToString)
            End If
            If CbGrupo.DMSTraerId > 0 Then
                AdicioneSql("id_cot_grupo=" & CbGrupo.DMSTraerId.ToString)
            End If
            If CbSubgrupo.DMSTraerId > 0 Then
                AdicioneSql("id_cot_grupo_sub=" & CbSubgrupo.DMSTraerId.ToString)
            End If

            If OptTempario.Checked Then
                AdicioneSql("precio<0")
            Else
                AdicioneSql("isnull(precio,0)>=0")
            End If

            If OptVehiculos.Checked Then
                AdicioneSql("isnull(id_veh_ano,0)>0")
            Else 'todos los demas casos no incluya veh
                AdicioneSql("isnull(id_veh_ano,0)=0")
            End If

            If OptNuevos.Checked Then
                AdicioneSql("IsNull(km,0)=0")
            End If
            If OptUsados.Checked Then
                AdicioneSql("IsNull(km,0)>0")
            End If

            If CbTalla.DMSTraerId > 0 Then
                AdicioneSql("id_cot_item_talla=" & CbTalla.DMSTraerId.ToString)
            End If
            If CbGener.DMSTraerId > 0 Then
                AdicioneSql("id_cot_item_color=" & CbGener.DMSTraerId.ToString)
            End If

            'veh
            'If TraerId(CbColor) > 0 Then
            '    AdicioneSql("id_veh_color=" & TraerId(CbColor).ToString)
            'End If
            If TraerId(CbModelo) > 0 Then
                AdicioneSql("id_veh_linea_modelo=" & TraerId(CbModelo).ToString)
            ElseIf TraerId(CbLinea) > 0 Then
                AdicioneSql("id_veh_linea=" & TraerId(CbLinea).ToString)
            ElseIf TraerId(CbMarca) > 0 Then
                AdicioneSql("id_veh_marca=" & TraerId(CbMarca).ToString)
            End If
            'fin veh

            Dim SqlPrinciAct As String = ""

            If TxtBuscarItem.Text <> "" Then

                If ChkPrinAct.Checked Then
                    'ir a la bd a trar los de principio activo
                    Dim Dtp As New DataTable
                    Try
                        Abrir(Dtp, "GetBusItemAdicional " & Numero_Empresa & ",'" & TxtBuscarItem.Text & "'")

                    Catch ex As Exception
                        NoReloj()
                        MostrarError(Me.Name, "Haga_buscar: principio act", ex.Message)
                        Exit Sub
                    End Try

                    If Not Fin(Dtp) Then
                        Dim ids As String = ""
                        For Each pp As DataRow In Dtp.Rows
                            If ids <> "" Then ids += ","
                            ids &= pp("id_cot_item").ToString
                        Next

                        SqlPrinciAct = "id in(" & ids & ")"

                    End If
                End If


                If ChkSoloInicial.Checked Then 'solo iniciando descripción
                    AdicioneSql("descripcion like '" & TxtBuscarItem.Text & "%'")
                Else
                    Dim Co() As String
                    TxtBuscarItem.Text = TxtBuscarItem.Text.Replace("+", "&")
                    Co = Split(SinComillas(TxtBuscarItem.Text & IIf(TxtBuscarItem2.Text <> "", "&" & TxtBuscarItem2.Text, "")), "&")
                    For Each cn As String In Co
                        AdicioneSql("(descripcion+codigo like '%" & cn.Trim & "%')")
                    Next
                End If
            End If


            If TxtCod.Text <> "" Then
                AdicioneSql("(codigo like '" & TxtCod.Text & "%')")
            End If


            'esta debe ser la última sql modificación
            If SqlPrinciAct <> "" Then
                If SQL <> "" Then SQL = "(" & SQL & ") or "
                SQL = SQL & SqlPrinciAct
            End If
            '/esta debe ser la última sql modificación

            Dim Dr() As DataRow
            Try
                If Not Fin(DtI2) Then
                    Dr = DtI2.Select(GlobalesVarios.SQL, "descripcion")
                Else
                    If RealTime > 0 Then
                        Dim Dt As DataTable = Leer_De_BD()
                        Dr = Dt.Select()
                        For Each Fi As DataRow In Dt.Rows
                            Try
                                DtItem.ImportRow(Fi)
                            Catch ex As Exception

                            End Try
                        Next
                    Else
                        Dr = DtItem.Select(GlobalesVarios.SQL, "descripcion")
                    End If
                    'Ventana(Filtrar_DataTable(DtItem, GlobalesVarios.SQL), "")
                End If
            Catch ex As Exception
                If InStr(ex.Message, "Like") > 0 Then
                    Mensaje("No puede usar % en el texto a buscar")
                Else
                    MostrarError(Me.Name, "Haga_Buscar-1", ex.Message, True)
                End If
                NoReloj(Me)
                Exit Sub
            End Try


            LblNegrilla.Text = Dr.Length.ToString & " items"

            GrdBus.Rows.Clear()
            GrdBus.Visible = False
            Dim It As String = ""

            For Each row As DataRow In Dr
                'If row("reservado") = 1 Then
                '    Dim I As Integer = 0
                'End If
                Dim Prec As Double
                Dim Prec2 As Double
                Dim Iva As String = ValD("" & row("porcentaje"))
                'If Regla_SoyRestaurante_17() Or Sector_Empresa = Sector.Pos_Generico Then

                Prec = row("precio")
                If Not Regla_PrecioConIva_14() Then
                    If PrecioMasIva Then
                        Prec *= (1 + row("porcentaje") / 100)
                        Iva += " *"
                    End If
                End If

                Prec2 = Prec 'guardarlo pa mas tardecito

                Dim Und As String = "" & row("und")
                If ValD(row("und_cant")) > 1 Then
                    If Und = "" Then
                        Und = "Caja"
                    End If
                    Und &= " x" & ValD(row("und_cant")).ToString
                    If ChkPrecioCaja.Checked Then
                        Prec = Prec * ValD(row("und_cant"))
                    End If
                End If

                'lo quito para dejarlo solo en de la lista de precios
                'Prec = Prec * PorceDescu

                If ValD("" & row("porcentaje")) = 0 Then
                    Iva = ""
                End If
                If ValD("" & row("maneja_stock")) = TipoStock.AceptaStockNegativos Then
                    Iva += " i"
                ElseIf ValD("" & row("maneja_stock")) = TipoStock.ControlaStock Then
                    Iva += " I"
                End If

                Dim NomProv As String = ""
                If CbProv.DMSTraerId = 0 Then
                    If row("id_cot_cliente") IsNot System.DBNull.Value Then
                        NomProv = "" & Obtenga_Dato(DtProveedores, "id=" & row("id_cot_cliente").ToString, "razon_social")
                    End If
                End If

                Dim NomLinea As String = ""
                Dim NomGen As String = ""
                Dim NomGru As String = ""
                Dim NomSub As String = ""
                If ChkLineaGen.Checked Then
                    NomLinea = "" & Obtenga_Dato(DtTalla, "id=" & ValD(row("id_cot_item_talla")).ToString, "descripcion")
                    NomGen = "" & Obtenga_Dato(DtColor, "id=" & ValD(row("id_cot_item_color")).ToString, "descripcion")
                    NomGru = "" & Obtenga_Dato(DtCotGrupos, "id_padre=" & ValD(row("id_cot_grupo")), "des_padre")
                    NomSub = "" & Obtenga_Dato(DtCotGrupos, "id_hijo=" & ValD(row("id_cot_grupo_sub")), "des_hijo")
                End If


                'precio según las listas
                Dim C_Pre As String = ""
                Dim C_Des As String = ""
                'JDMS 595: poner la bodega negativa para que no traiga precios cuando es promedio
                'Obtenga_Precio(row, Prec2, C_Pre, C_Des, IdBod)
                '************************************************************************************************************************************************************************************
                Obtenga_Precio(row, Prec2, C_Pre, C_Des, IdBod * CmdMostrarPrecios.Tag) 'si está chequedao traer cada precio
                '************************************************************************************************************************************************************************************

                If C_Pre = "*" Then
                    C_Pre = "Clic precio"
                    CmdMostrarPrecios.Visible = True
                Else
                    If ValD(row("und_cant")) > 1 And ChkPrecioCaja.Checked Then
                        C_Pre = ValD(C_Pre) * ValD(row("und_cant"))
                    End If
                    If PrecioMasIva Then
                        C_Pre = ValD(C_Pre) * (1 + row("porcentaje") / 100) 'para sumarle el iva
                    End If
                    C_Pre = FormatoMoneda(ValD(C_Pre))
                    If ValD(C_Pre) = 0 Then C_Pre = "" 'JDMS 654
                End If
                If ValD(C_Des) = 0 Then C_Des = ""

                'Label14.Text = Label14.Tag & DMScr() & row("codigo") & ", precioi: " & C_Pre
                'HagaEventos()

                'GrdBus.Visible = True
                '************************************************************************************************************************************************************************************
                GrdBus.Rows.Add((New Object() {"", row("id"), row("codigo"), row("descripcion"), Und, IIf(Prec = 0, DBNull.Value, Prec), C_Des, C_Pre, Iva, NomLinea, NomGen, NomGru, NomSub, IIf(Val("" & row("promocion")) = 1, "Si", ""), NomProv, IIf(row("hay_imagen") = 0, "", "Si"), IIf(row("reservado") = 0, "", "Si"), row("estado"), IdBod}))
                '************************************************************************************************************************************************************************************
                'GrdBus.ClearSelection()
                'GrdBus.FirstDisplayedScrollingRowIndex = GrdBus.Rows.Count - 1
                'HagaEventos()

                If Mayores <> 0 And Prec > Mayores Then
                    GrdBus.Rows(GrdBus.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Green
                End If

                'para el stock
                If IdBod > 0 Then
                    If GrdBus.Rows.Count < MaxI Then
                        It &= row("id").ToString & ","

                    End If
                End If
            Next

Saltar_Grid:
            GrdBus.Visible = True
            If GrdBus.Rows.Count > 0 Then
                GrdBus.FirstDisplayedScrollingRowIndex = 0
            End If

            If GrdBus.Rows.Count > 0 Then
                SaveSett(Me.Name, "ultbus" & Numero_Empresa.ToString & MarcaExterna, TxtBuscarItem.Text)
                SaveSett(Me.Name, "ultbus2" & Numero_Empresa.ToString & MarcaExterna, TxtBuscarItem2.Text)
                SaveSett(Me.Name, "ultbus3" & Numero_Empresa.ToString & MarcaExterna, TxtCod.Text)
            End If

            'traer el stock
            If It <> "" Then
                If GrdBus.Rows.Count >= MaxI Then
                    LblMensaje.Text = Idi("Solo carga el stock de las primeras") & " " & MaxI.ToString
                    Pnl500.Visible = True
                End If
                MySql = "Select s.id_cot_item,"
                MySql &= "ubica=u.ubicacion,"

                If ChkReal.Checked Then
                    MySql &= "stock=s.stock+isnull(s.pendiente,0),"
                Else
                    MySql &= "stock=s.stock,"
                End If
                MySql &= "s.pendiente "

                MySql &= " from v_cot_item_stock_real_sin_lote s" ' group by s.id_cot_item"
                'estos dos siguientes son solo para poder mostrar la ubicacion 1
                MySql &= " left join cot_item_bodega b on b.id_cot_item=s.id_cot_item and b.id_cot_bodega=s.id_cot_bodega"
                MySql &= " left join cot_item_ubicacion u on u.id=b.id_cot_item_ubicacion"
                MySql &= " where s.id_cot_bodega=" & IdBod & " And s.id_cot_item in(" & Mid(It, 1, It.Length - 1).ToString & ")" & DMScr()

                If BodegaPromocion <> "" And ChkPromo.Checked Then
                    MySql &= "Select s.id_cot_item,"
                    MySql &= "stock=s.stock,"
                    MySql &= "ubica=u.ubicacion"
                    If ChkReal.Checked Then
                        MySql &= "+isnull(s.pendiente,0)"
                    End If
                    MySql &= ",s.pendiente"
                    MySql &= ",s.id_cot_bodega"
                    MySql &= " from v_cot_item_stock_real_sin_lote s"
                    MySql &= " left join cot_item_bodega b on b.id_cot_item=s.id_cot_item and b.id_cot_bodega=s.id_cot_bodega"
                    MySql &= " left join cot_item_ubicacion u on u.id=b.id_cot_item_ubicacion"
                    MySql &= " where s.id_cot_bodega in(" & BodegaPromocion.ToString & ") And s.id_cot_item in(" & Mid(It, 1, It.Length - 1).ToString & ")" ' group by s.id_cot_item"
                End If

                If BackTraerStock.IsBusy Then
                    MySql = "1"
                    BackTraerStock.CancelAsync()
                    Mensaje("No puedo traer stock, sistema batch ocupado")
                Else
                    Label14.Text = "Consultando Stock..."
                    PnlProc.Visible = True
                    GrdBus.ForeColor = Color.Red
                    HagaEventos()
                    '************************************************************************************************************************************************************************************
                    BackTraerStock.RunWorkerAsync()
                    '************************************************************************************************************************************************************************************
                End If
            End If


        Catch ex As Exception
            'MostrarError(Me.Name, "Haga_Buscar-2", ex.Message, True)
            'MostrarError(Me.Name, "Haga_Buscar", ex.Message, True)

            Mensaje(Idi("Error en la búsqueda") & ": " & ex.Message & EsIngles())

        End Try



        NoReloj(Me)

        If GrdBus.Rows.Count > 0 Then
            Me.AcceptButton = CmdModificar
        Else
            Me.AcceptButton = CmdBuscar
        End If

    End Sub

    Private Sub Haga_Buscar_Nuevo()
        If Cargando Then Exit Sub
        'If DtItem.Rows.Count = 0 Then
        '    Exit Sub
        'End If


        PnlProc.Visible = True
        Label14.Tag = "Procesando consulta..."
        Label14.Text = Label14.Tag
        HagaEventos()

        TxtBuscarItem2.Tag = TxtBuscarItem2.Text.Trim
        TxtCod.Tag = TxtCod.Text.Trim

        TxtBuscarItem.Text = TxtBuscarItem.Text.Trim
        TxtBuscarItem2.Text = TxtBuscarItem2.Tag
        TxtCod.Text = TxtCod.Tag

        If TxtBuscarItem.Text = "" And
            TxtCod.Text = "" And
            CbGrupo.DMSTraerId = 0 Then
            Mensaje("Debe ingresar algún texto a buscar o un grupo o subgrupo")
            TxtBuscarItem.Focus()
            Exit Sub
        End If

        If CbBod.DMSTraerId = 0 Then
            Mensaje("Seleccione bodega")
            TxtBuscarItem.Focus()
            Exit Sub
        End If

        Try
            SiReloj(Me)



            'primero buscar los items de varios
            GrdNue.Visible = False
            Dim Dt As New DataTable
            Dim Sq As String = ArmeSQL("Exec Get2561",
                                        Numero_Empresa, qqNum,
                                        Usuario, qqNum,
                                        CbGrupo.DMSTraerId, qqNum,
                                        CbSubgrupo.DMSTraerId, qqNum,
                                        CbBod.DMSTraerId, qqNum,
                                        lblPrecioNro, qqNum,
                                        0, qqNum,
                                        0, qqNum,
                                        ChkStock.Checked, qqBol,
                                        TxtBuscarItem.Text, qqTex
                                       )

            '============================================================================================================
            Abrir(Dt, Sq)
            '============================================================================================================

            Dt.Columns.Add("cua")
            Dt.Columns("id_cot_bodega").ColumnName = "bodega" 'para engañar al 13

            GrdNue.DMSLlene_Grid(Dt, "id_cot_item", MostrarEliminar:=False, ColOcultas:=New Object() {"id_cot_item", "costo_ultimo", "costo_promedio", "explicacion", "explicacion_logistica", "id_usuario", "bodega", "negar_logistica", "fecfoto"})

            GrdNue.Grid.Columns("cua").DisplayIndex = 0


            Try
                GrdNue.Grid.Columns("cua").Width = 30
                GrdNue.Grid.Columns("cua").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                GrdNue.Grid.Columns("codigo").Width = 100
                GrdNue.Grid.Columns("descripcion").Width = 500

            Catch ex As Exception

            End Try

            GrdNue.Visible = True


            LblNegrilla.Text = Dt.Rows.Count & " items"

            If Dt.Rows.Count > 0 Then
                SaveSett(Me.Name, "ultbus" & Numero_Empresa.ToString & MarcaExterna, TxtBuscarItem.Text)
                SaveSett(Me.Name, "ultbus2" & Numero_Empresa.ToString & MarcaExterna, TxtBuscarItem2.Text)
                SaveSett(Me.Name, "ultbus3" & Numero_Empresa.ToString & MarcaExterna, TxtCod.Text)
            End If

            If Dt.Rows.Count > 0 Then
                Me.AcceptButton = CmdModificar
            Else
                Me.AcceptButton = CmdBuscar
            End If


            NoReloj(Me)
        Catch ex As Exception
            NoReloj()
            MostrarError(Me.Name, "Haga_Buscar_Nuevo", ex.Message)

        End Try



    End Sub

    Private Function Leer_De_BD() As DataTable
        Try
            Dim Dt As New DataTable
            Abrir(Dt, ArmeSQL("Exec GetCotItems9B",
                      Numero_Empresa, qqNum,
                      Regla_SoyAutomotriz_16, qqBol,
                      IncluirVendidosAnulados, qqBol,
                      Usuario, qqNum,
                      0, qqNum,
                      0, qqNum,
                      0, qqNum,
                      "", qqTex,
                      GlobalesVarios.SQL, qqTex))

            Return Dt

        Catch ex As Exception
            MostrarError(Me.Name, "Leer_De_BD", ex.Message)
            Return Nothing

        End Try

    End Function




    Private Sub GrdBus_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdBus.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            CmdModificar_Click(CmdModificar, New EventArgs)
        ElseIf UsarCant Then
            'evaluar a ver si presiono la tecla backespace
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Delete Then
                Try
                    If GrdBus.CurrentRow.Cells("cua").Value <> "" Then
                        If GrdBus.CurrentRow.Cells("cua").Value.ToString.Length = 1 Then
                            GrdBus.CurrentRow.Cells("cua").Value = ""
                        Else
                            GrdBus.CurrentRow.Cells("cua").Value = Mid(GrdBus.CurrentRow.Cells("cua").Value, 1, GrdBus.CurrentRow.Cells("cua").Value.ToString.Length - 1)
                        End If
                    End If
                Catch
                End Try
            End If
        End If

    End Sub
    Private Sub CbMarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbMarca.SelectedIndexChanged
        CbLinea.Items.Clear()
        CbModelo.Items.Clear()

        Limpiar()



        'If TraerId(CbMarca) > 0 Then
        '    CbMarca.Font = LblNegrilla.Font
        'Else
        '    CbMarca.Font = LblItem.Font
        'End If

        If CbMarca.SelectedIndex < 0 Then Exit Sub

        Llene_Combo5(CbLinea, DtVehLinea, "id_veh_linea", "linea", "id_veh_marca=" & TraerId(CbMarca), "linea", "Todas", 0, False)

    End Sub

    Private Sub CbLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbLinea.SelectedIndexChanged
        Limpiar()

        CbModelo.Items.Clear()

        'If TraerId(CbLinea) > 0 Then
        '    CbLinea.Font = LblNegrilla.Font
        'Else
        '    CbLinea.Font = LblItem.Font
        'End If

        If CbLinea.SelectedIndex < 0 Then Exit Sub

        Llene_Combo5(CbModelo, DtVehModelo, "id_veh_linea_modelo", "modelo", "id_veh_linea=" & TraerId(CbLinea), "modelo", "Todos", 0, False)

    End Sub

    Private Sub CbColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Limpiar()

        'If TraerId(CbColor) > 0 Then
        '    CbColor.Font = LblNegrilla.Font
        'Else
        '    CbColor.Font = LblItem.Font
        'End If

        'Haga_Buscar()

    End Sub

    'Private Sub TxtMas_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Mensaje(TxtMas.Text, "Descripción")

    'End Sub

    Private Sub CbModelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbModelo.SelectedIndexChanged
        Limpiar()

        'If TraerId(CbModelo) > 0 Then
        '    CbModelo.Font = LblNegrilla.Font
        'Else
        '    CbModelo.Font = LblItem.Font
        'End If

        'Haga_Buscar()

    End Sub

    Private Sub LnkRefrescar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkRefrescar.LinkClicked
        If Not Fin(DtItemSalamanca) Then
            Mensaje("No puede refrescar pues tiene activa la Rn#142 'itemlista'. Para refrescar reinicie Advance")
            Exit Sub
        End If

        If Not Pregunte("Desea refrescar los Items de la Base de Datos?") Then Exit Sub

        SiReloj(Me)


        Try
            Cargar_Items(True)

        Catch ex As Exception

        End Try
        'fCrm.Refrescar_Items()

        Haga_Buscar()

        NoReloj(Me)

        PnlProc.Visible = False

        TxtBuscarItem.Focus()

    End Sub


    Private Sub LnkAbrir_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkAbrir.LinkClicked
        AbraItem()

    End Sub
    Private Sub AbraItem()

        If GrdBus.SelectedRows.Count = 0 Then
            Mensaje("Haga click en algún item")
            Exit Sub
        End If

        Try
            'If Regla_SoyAutomotriz_16() Then
            '    If ValD("" & Obtenga_Dato(DtItem, "id=" & Tm(GrdBus, "id").ToString, "id_veh_ano")) > 0 Then
            '        Mensaje("No es posible entrar a crear vehículos por este programa")
            '        'Crear_Vehiculo(Tm(GrdBus, "codigo"))
            '        Exit Sub
            '    End If
            'End If

            Dim PPr As String = "1901"
            If ValD("" & Obtenga_Dato(DtItem, "id=" & Tm(GrdBus, "id").ToString, "id_veh_ano")) > 0 Then
                PPr = "2002"
            ElseIf ValD("" & Obtenga_Dato(DtItem, "id=" & Tm(GrdBus, "id").ToString, "precio")) < 0 Then
                PPr = "4101"
            End If
            AbrirPrograma(PPr, Tm(GrdBus, "codigo"))
            'If FormaYaEstaAbierta("fItem", Tm(GrdBus, "codigo")) Then Exit Sub

            'Dim fIte As New fItem
            'fIte.Tag = Tm(GrdBus, "codigo")
            'fIte.Show()

        Catch ex As Exception
            Mensaje("Operación inválida")

        End Try

    End Sub

    Private Sub ChkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTodos.CheckedChanged
        If RealTime > 0 Then
            IncluirVendidosAnulados = ChkTodos.Checked
            Exit Sub
        End If

        If IncluirVendidosAnulados Then
            Exit Sub 'pues ya cargo
        End If


        If Not Pregunte("Seguro de cargar items anulados (puede tardar)?", , Me.Name, , 4) Then Exit Sub

        Try
            HagaEventos()
            IncluirVendidosAnulados = True 'primera vez
            SiReloj(Me)
            Cargar_Items(True)
            Haga_Buscar()

        Catch ex As Exception
            Mensaje("Operación no fue completada.  Favor salir de CRM y volver a entrar")
        End Try

        NoReloj(Me)

    End Sub

    'Private Sub LnkCotizar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '    If GrdBus.Rows.Count = 0 Then
    '        Mensaje("Haga click en algún item")
    '        Exit Sub
    '    End If

    '    fCrm.Item = Tm(GrdBus, "codigo")
    '    fCrm.ItemDes = Tm(GrdBus, "descripcion")
    '    fCrm.Cotizar()

    'End Sub

    Private Sub GrdBus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrdBus.Click
        If GrdBus.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        If Tm(GrdBus, "tiene_imagen") <> "" Then
            Buscar_Foto_Item(Tm(GrdBus, "id"), PicItem)
        Else
            PicItem.Image = Nothing
        End If

    End Sub


    Private Sub PicItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicItem.Click

        Try
            Dim pic As New Windows.Forms.PictureBox
            pic.Image = PicItem.Image
            'AbrirImagen("cot_item", PicItem.Tag, 100000, 1500, pic, False)
            AbrirImagen("cot_item", PicItem.Tag, 100000, 1500, PicItem, False)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub LnkAvanzado_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkAvanzado.LinkClicked, LnkOcultar.LinkClicked

        PnlOpciones.Visible = Not PnlOpciones.Visible
        PnlOpciones.BringToFront()

    End Sub
    Private Sub Poner_Marcas()
        If Regla_SoyAutomotriz_16() Or Regla_SoyTaller_15() Then
            If DtVehMarca.Rows.Count = 0 Then
                Cargar_Veh_Modelos()
                Cargar_Colores()
            End If
        Else
            Exit Sub
        End If


        If CbMarca.Items.Count = 0 Then
            Dim Marcas As String = ReglaDeNegocio(134, "marcas", "")
            If Marcas <> "" Then
                Marcas = "id_veh_marca in(" & Marcas & ")"
            End If
            Llene_Combo5(CbMarca, DtVehMarca, "id_veh_marca", "marca", Marcas, "marca", "Todas", 0, False)
        End If

        Panel1.Visible = True
    End Sub


    Private Sub OptTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptTodos.CheckedChanged, OptUsados.CheckedChanged, OptNuevos.CheckedChanged
        Haga_Buscar()

    End Sub

    Private Sub LnkExcel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkExcel.LinkClicked
        Copiar_Exel(GrdBus, , Me.Text)

    End Sub

    Private Sub LblStock_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LblStock.LinkClicked

        If GrdBus.SelectedRows.Count = 0 Then
            Mensaje("Haga click en algún item")
            Exit Sub
        End If

        AbrirPrograma("1907", Tm(GrdBus, "codigo"))
        'fCrm.Mostrar_Consulta_Inv(Tm(GrdBus, "codigo"), BodegaUsuario)

    End Sub

    Private Sub fBusItems_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            ItemBuscado = ""
            Me.Hide()
            e.Cancel = 1
        End If

    End Sub

    Private Sub TxtBuscarItem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscarItem.KeyDown
        Dim Grd As DataGridView
        If BusquedaNueva Then
            Grd = GrdNue.Grid
        Else
            Grd = GrdBus
        End If

        Try
            If e.KeyCode = Keys.Down Then
                If Grd.SelectedRows(0).Index < Grd.Rows.Count - 1 Then
                    Grd.Focus()
                    Grd.Rows(Grd.SelectedRows(0).Index + 1).Selected = True
                End If
                e.SuppressKeyPress = True
            ElseIf e.KeyCode = Keys.Up Then
                If Grd.SelectedRows(0).Index > 0 Then
                    Grd.Focus()
                    Grd.Rows(Grd.SelectedRows(0).Index - 1).Selected = True
                End If
                e.SuppressKeyPress = True
            ElseIf e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                If Grd.Rows.Count > 0 Then
                    CmdModificar_Click(CmdModificar, New EventArgs)
                Else
                    CmdBuscar_Click(CmdBuscar, New EventArgs)
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub fBusItems_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        'esto no sirve para nada, el foco se queda en el grid
        If GrdBus.Rows.Count > 0 Or GrdNue.Grid.Rows.Count > 0 Then
            Foco_Grid()
        Else
            TxtBuscarItem.Focus()
        End If

    End Sub

    Private Sub BckLeerItems_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BckLeerItems.DoWork
        'Haga_Leer_Items(False)
        Dim Refrescar As Boolean = e.Argument(0)

        Haga_Leer_Items_New(False, Refrescar)

    End Sub
    Public Sub Haga_Leer_Lineas()
        Abrir(DsLin, "Exec GetVehModelos3 " & DMScr() &
        "Exec GetVehColores " & Numero_Empresa.ToString)

        Mover_Tablas_Lineas(DsLin)

        DMS_XML_Escribir_DataSet(DsLin, "lineasveh")

    End Sub
    Public Sub Mover_Tablas_Lineas(ByVal Ds As DataSet)
        DtVehMarca = Ds.Tables(0).Copy
        DtVehLinea = Ds.Tables(1).Copy
        DtVehModelo = Ds.Tables(2).Copy
        DtColores = Ds.Tables(3).Copy

    End Sub


    Public Sub Haga_Leer_Items_New(ByVal Mostrar As Boolean, ByVal Refrescar As Boolean)
        DevolverXml = True
        Dim fM As New fBusItems_Cargando
        If Mostrar Then
            If RealTime > 0 And Not Refrescar Then
                fM.Label1.Text = "RealTime, " & Idi("favor esperar") & "..."
            Else
                fM.Label1.Text = "Cargando items, " & Idi("favor esperar") & "..."
            End If
            fM.Show()
            HagaEventos()
        End If

        Ini = Now

        'ya no usar el if: siempre se debe cargar
        'truco para cargar los sustitutos
        'Dim Susti As String = ""
        'If ReglaDeNegocio(123, "", "0") = "1" Then 'tabla 6
        '    Susti &= "exec GetCotItemSusTodos " & Numero_Empresa.ToString & DMScr()
        'Else
        '    Susti &= "select top 0 1" & DMScr()
        'End If
        Dim Susti As String = "exec GetCotItemSusTodos " & Numero_Empresa.ToString & DMScr()

        'ya no usar el if: siempre se debe cargar
        'If ValD(ReglaDeNegocio(128, "1901", "0")) > 0 Then 'tabla 7: mimos campos adicionales de 1901 para control de estructuras en POS
        '    Susti &= "select va.* from cot_item i join v_campos_varios va on va.id_cot_item=i.id where i.id_emp=" & Numero_Empresa.ToString & DMScr()
        'Else
        '    Susti &= "select top 0 1" & DMScr()
        'End If

        'ya no se usa
        'If RealTime And Not Refrescar Then
        '    Susti &= "exec GetCotItemCamposVariosUno -1" & DMScr()
        'Else
        '    Susti &= "exec GetCotItemCamposVariosUno " & Numero_Empresa & DMScr()
        'End If
        Susti &= "exec GetCotItemCamposVariosUno -1" & DMScr() 'para engañarlo

        'ya no usar el if: siempre se debe cargar la lista asi no se use
        'usa listas de precios
        'If ReglaDeNegocio(74, , "0") = "1" Then
        '    Susti &= "select p.id_cot_item,p.id_cot_item_listas,p.precio,p.negar from cot_item i join cot_item_precios p on p.id_cot_item=i.id where i.id_emp=" & Numero_Empresa.ToString & DMScr()
        'Else
        '    Susti &= "select top 0 1" & DMScr()
        'End If

        'jdms 670: se quita si es realtime
        Susti &= "select p.id_cot_item,p.id_cot_bodega,p.id_cot_item_listas,p.precio,p.negar from cot_item i join cot_item_precios p on p.id_cot_item=i.id where i.id_emp=" & IIf(RealTime > 0, 0, Numero_Empresa) & DMScr()

        Dim Ids As String
        If RealTime > 0 And Not Refrescar Then
            'para que solo lea la estructura
            Ids = "Exec GetCotItems9B -1," & IIf(Regla_SoyAutomotriz_16, "1", "0") & "," & IIf(IncluirVendidosAnulados, 1, 0) & "," & Usuario.ToString & ",0,0,0" & DMScr() & "exec GetCotItemAlternas " & Numero_Empresa & "," & IIf(IncluirVendidosAnulados, 1, 0) & DMScr() &
                  "Exec GetCotItemPrereq 0" 'para que no cargue nada
        Else
            Ids = "Exec GetCotItemsSoloIds " & Numero_Empresa.ToString & "," & IIf(Regla_SoyAutomotriz_16, "1", "0") & "," & IIf(IncluirVendidosAnulados, 1, 0) & "," & Usuario.ToString & ",0" & DMScr() &
                  "Exec GetCotItemPrereq " & Numero_Empresa.ToString
        End If
        Try

            DebugJD("Leyendo Items")
            Abrir(DsItem, "set transaction isolation level read uncommitted" & DMScr() &
                          Ids & DMScr() &
                          "Exec GetCotGrupos " & Numero_Empresa.ToString & DMScr() &
                          "Exec GetCotItemCategoria " & Numero_Empresa.ToString & DMScr() &
                          "Exec GetCotItemsProveedores " & Numero_Empresa.ToString & DMScr() &
                          Susti & DMScr() &
                          "Exec GetCotItemComentariosTodos " & Numero_Empresa
                          )

            If RealTime > 0 And Not Refrescar Then
                GoTo Salte_Leer_Items
            End If

            Dim CantidadItems As Integer = ValD(GetSett("menu", "ci", "1000"))
            Dim CantidadPasadas = (DsItem.Tables(0).Rows.Count / CantidadItems)
            If Math.Truncate(CantidadPasadas) <> ValD(CantidadPasadas) Then
                CantidadPasadas = Math.Truncate(CantidadPasadas) + 1
            Else
                CantidadPasadas = Math.Truncate(CantidadPasadas)
            End If


            DebugJD("Fin Leer Items: " & DsItem.Tables(0).Rows.Count.ToString)
            DebugJD("Cantidad x Ciclo: " & CantidadItems.ToString & "=" & CantidadPasadas.ToString & " ciclos")

            'leer los items de a pedacitos
            Dim DtIds As DataTable = DsItem.Tables(0).Copy
            DsItem.Tables(0).Rows.Clear()

            Dim Pasada As Integer = 1
            For I As Integer = 0 To DtIds.Rows.Count - 1 Step CantidadItems
                Dim Ini As Integer = DtIds.Rows(I).Item("id")
                Dim Fin As Integer = I + (CantidadItems - 1)
                If Fin > DtIds.Rows.Count - 1 Then
                    Fin = DtIds.Rows.Count - 1
                End If
                Fin = DtIds.Rows(Fin).Item("id")

                DebugJD("...ciclo " & Pasada.ToString & ": Ini: " & Ini.ToString & ", Fin: " & Fin.ToString)
                Try
                    fM.Label1.Text = "Items Total: " & DtIds.Rows.Count.ToString & DMScr() & "Items x Ciclo: " & CantidadItems & DMScr() & "Ciclo " & Pasada.ToString & " de " & CantidadPasadas.ToString
                    HagaEventos()
                Catch
                End Try


                Dim Dt As New DataTable
                Abrir(Dt, "Exec GetCotItems9B " & Numero_Empresa.ToString & "," & IIf(Regla_SoyAutomotriz_16, "1", "0") & "," & IIf(IncluirVendidosAnulados, 1, 0) & "," & Usuario.ToString & ",0," & Ini.ToString & "," & Fin.ToString)
                'Abrir(Dt, "set transaction isolation level read uncommitted" & DMScr() & "Exec GetCotItems9B " & Numero_Empresa.ToString & "," & IIf(Regla_SoyAutomotriz_16, "1", "0") & ",0," & Usuario.ToString & ",0," & Ini.ToString & "," & Fin.ToString)
                'DsItem.Tables(0).Merge(Dt)
                MergeDMS(DsItem.Tables(0), Dt)
                Pasada += 1
            Next

Salte_Leer_Items:
            DebugJD("terminó cargar items")

            'mover las tablas
            Mover_Tablas_Items(DsItem)
            '/mover las tablas



            DMS_XML_Escribir_DataSet(DsItem, "items")
            'grabar la fecha de hoy para que dentro de 7 días cree de nuevo el XML
            SaveSett("GlobalesVarios", "xmlitem" & Numero_Empresa, Strings.Format(Now, "yyyy/MM/dd"))

            HistoriaCargueItems += "Fecha: " & FormatoFecha(Now, True) & DMScr() &
                                     "Tiempo: " & DateDiff(DateInterval.Second, Ini, Now).ToString & "s" & DMScr(2) &
                                   "Items: " & DtItem.Rows.Count.ToString & DMScr() &
                                     "Alternos: " & DtItemCod.Rows.Count.ToString & DMScr() &
                                     "Lotes: " & DtItemLotes.Rows.Count.ToString & DMScr() &
                                     "Grupos: " & DtCotGrupos.Rows.Count.ToString & DMScr()

            If Mostrar Then
                Try
                    fM.Label1.TextAlign = ContentAlignment.MiddleLeft
                    fM.Label1.Text = HistoriaCargueItems

                    HagaEventos()
                    fM.Hide()
                    'fM.Timer1.Start()

                Catch ex As Exception
                    DevolverXml = SiempreXml
                End Try
            End If

        Catch ex As Exception
            DebugJD("error cargando items: " & ex.Message & EsIngles())
            If Mostrar Then
                fM.Label1.Text = "Err: " & ex.Message & EsIngles()
            End If
        End Try


        DevolverXml = SiempreXml

    End Sub
    Public Sub Mover_Tablas_Items(DsItem As DataSet)
        SMDPpal.DtItem = DsItem.Tables(0).Copy
        Dim PrimaryKeyColumns(0) As DataColumn
        PrimaryKeyColumns(0) = DtItem.Columns("codigo")
        DtItem.PrimaryKey = PrimaryKeyColumns


        DtItemCod = DsItem.Tables(1).Copy
        DtItemPrereq = DsItem.Tables(2).Copy
        DtCotGrupos = DsItem.Tables(3).Copy
        DtCategorias = DsItem.Tables(4).Copy
        DtProveedores = DsItem.Tables(5).Copy
        DtItemSustitutos = DsItem.Tables(6).Copy
        DtItemCampos = DsItem.Tables(7).Copy

        DtListasFijas = DsItem.Tables(8).Copy
        DtItemComent = DsItem.Tables(9).Copy

    End Sub
    Public Sub Traer_Item_Real_Time(Codigo As String)
        If RealTime = 0 Then Exit Sub

        Codigo = SinComillas(Codigo)

        If RealTime = 2 Then 'virtualizar solo cuando está en 1, si es 2 lo obligo a leer
            DtItem.Rows.Clear()
            DtItemPrereq.Rows.Clear()
            DtListasFijas.Rows.Clear()
        End If

        Try
            'si ya existe, salirse
            Dim Dr As DataRow = DtItem.Rows.Find(Codigo)
            If Dr IsNot Nothing Then
                Exit Sub
            End If

        Catch ex As Exception

        End Try



        Try
            'traer el ítem de la bd
            SiReloj()
            'Susti &= "select va.* from cot_item i join v_campos_varios va on va.id_cot_item=i.id where i.id_emp=" & Numero_Empresa.ToString & DMScr()
            Dim Ds As New DataSet
            Dim sq As String = ArmeSQL(
                "Exec GetCotItems9B",
                    Numero_Empresa, qqNum,
                    Regla_SoyAutomotriz_16, qqBol,
                    IncluirVendidosAnulados, qqBol,
                    Usuario, qqNum,
                    "0", qqNum,
                    "0", qqNum,
                    "0", qqNum,
                    Codigo, qqTex
                )

            sq &= ArmeSQL(
                    "Exec GetCotItemPrereq",
                    Numero_Empresa, qqNum,
                    Codigo, qqTex
                    )

            'jdms 670: se agregan las listas de precios
            sq &= "select p.id_cot_item,p.id_cot_bodega,p.id_cot_item_listas,p.precio,p.negar " &
            "from cot_item i " &
            "join cot_item_precios p on p.id_cot_item=i.id " &
            "where i.id_emp=" & Numero_Empresa &
            " And i.codigo='" & Codigo & "'" &
            DMScr()




            'solo se usaba para el control de mimos, se quita por el momento
            'sq &= ArmeSQL("exec GetCotItemCamposVariosUno",
            '              Numero_Empresa, qqNum,
            '              Codigo, qqTex)

            'Abrir(Dt, "Exec GetCotItems9B " & Numero_Empresa.ToString & "," & IIf(Regla_SoyAutomotriz_16, "1", "0") & "," & IIf(IncluirVendidosAnulados, 1, 0) & "," & Usuario.ToString & ",0,0,0,'" & Codigo & "'")
            Abrir(Ds, sq)


            If Not Fin(Ds.Tables(0)) Then
                DtItem.ImportRow(Ds.Tables(0).Rows(0))
                For Each Fi As DataRow In Ds.Tables(1).Rows
                    DtItemPrereq.ImportRow(Fi)
                Next
                For Each Fi As DataRow In Ds.Tables(2).Rows
                    DtListasFijas.ImportRow(Fi)
                Next
            End If
            'If Not Fin(Ds.Tables(1)) Then
            '    DtItemCampos.ImportRow(Ds.Tables(1).Rows(0))
            'End If
            NoReloj()

        Catch ex As Exception
            NoReloj()
            MostrarError(Me.Name, "Traer_Item_Real_Time", ex.Message)

        End Try

    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Mensaje(HistoriaCargueItems & DMScr() &
                "Líneas: " & DtTalla.Rows.Count & DMScr() &
                "Genéricos: " & DtColor.Rows.Count)
    End Sub


    Private Sub CmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBuscar.Click

        'If RealTime Then
        '    If Not YaCargo Then
        '        If Not Pregunte("Para hacer la búsqueda de ítems, debe cargar los ítems en memoria, esto solo se hace una vez por sesión.  Seguro de continuar con el cargue?") Then
        '            ItemBuscado = ""
        '            Me.Hide()
        '            Exit Sub
        '        End If

        '        Cargar_Items(True)
        '        YaCargo = True
        '    End If
        'End If


        PnlOpciones.Visible = False
        HagaEventos()

        ChkLimpiar.Tag = 1


        '************************************************************************************************************************************************************************************
        If BusquedaNueva Then
            Haga_Buscar_Nuevo()
        Else
            Haga_Buscar()
        End If
        '************************************************************************************************************************************************************************************


        TxtBuscarItem.Focus()

        If BusquedaNueva Then
            If GrdNue.Grid.Rows.Count > 0 Then
                GrdNue.Focus()
                GrdNue.Grid.Rows(0).Selected = True
            End If
        Else
            If GrdBus.Rows.Count > 0 Then
                GrdBus.Focus()
                GrdBus.Rows(0).Selected = True
            End If
        End If

        If BackTraerStock.IsBusy = False Then
            PnlProc.Visible = False
        End If

        ChkLimpiar.Tag = 0

    End Sub

    Private Sub TxtBuscarItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarItem.TextChanged, TxtBuscarItem2.TextChanged, TxtCod.TextChanged, TxtDcto.TextChanged
        Limpiar()

        If sender Is TxtBuscarItem Then
            TxtBuscarItem2.Text = ""
            'por orden de cesar para profe no se limpia
            'TxtCod.Text = ""
        End If

        Me.AcceptButton = CmdBuscar

    End Sub
    Private Sub Limpiar()
        Try
            BackTraerStock.CancelAsync()
        Catch
        End Try

        GrdBus.Rows.Clear()
        GrdNue.Grid.DataSource = Nothing
        Pnl500.Visible = False
        PnlProc.Visible = False


    End Sub
    Private Sub TxtBuscarItem_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarItem.Enter
        'Me.AcceptButton = Nothing

    End Sub

    Private Sub TxtBuscarItem_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarItem.Leave
        'Me.AcceptButton = CmdModificar

    End Sub

    Private Sub BckLeerLineasColores_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BckLeerLineasColores.DoWork
        Haga_Leer_Lineas()

    End Sub

    Private Sub BackTraerStock_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackTraerStock.DoWork
        Try
            'If DtSto Is Nothing Then
            '    DtSto = New DataTable
            'End If

            Dim Ds As New DataSet

            Abrir(Ds, MySql)

            DtSto = Ds.Tables(0)
            If Ds.Tables.Count > 1 Then
                DtSto2 = Ds.Tables(1)
            Else
                DtSto2.Rows.Clear()
            End If


        Catch ex As Exception
            'MostrarError(Me.Name, "BackTraerStock_DoWork", ex.Message & EsIngles)

        End Try


    End Sub


    Private Sub CbBod_DMSSelectIndex(Sender As System.Object, Id As System.Int32) Handles CbBod.DMSSelectIndex
        Parte_Bodega()


    End Sub
    Private Sub Parte_Bodega()
        Limpiar()

        IdBod = CbBod.DMSTraerId

        GrdBus.Columns("stock").Visible = IdBod > 0
        GrdBus.Columns("ubica").Visible = IdBod > 0
        GrdBus.Columns("pendiente").Visible = IdBod > 0
        ChkStock.Visible = IdBod > 0
        ChkReal.Visible = IdBod > 0

        SaveSett(Me.Name, "nostock", IIf(IdBod = 0, 1, 0))

        BodegaPromocion = ReglaDeNegocio(125, IdBod.ToString, "0")

    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Pnl500.Visible = False


    End Sub


    Private Sub BackTraerStock_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackTraerStock.RunWorkerCompleted
        If MySql = "1" Then Exit Sub 'fue cancelado

        GrdBus.ForeColor = Color.Black

        Try
            'esto
            Dim GrC As New ListBox
            For I As Integer = 0 To GrdBus.Rows.Count - 1
                GrC.Items.Add(Tm(GrdBus, "id", I))
            Next
            Dim Cua As Integer = 0
            Dim K As Integer = -1
            For I As Integer = 0 To GrC.Items.Count - 1
                K += 1
                If MySql = "1" Then Exit Sub 'fue cancelado
                If K = MaxI Then
                    GrdBus.Rows(K).DefaultCellStyle.ForeColor = Color.Red
                    Exit For
                End If

                Cua += 1

                Dim Dr As New DataTable
                Dr = Filtrar_DataTable(DtItem, "id=" & Tm(GrdBus, "id", K))

                'jdms 638: si no maneja stock salrarlo
                If ValD(Gdf(Dr, "es_prepack")) = 1 Then
                    GrdBus.Rows(K).DefaultCellStyle.ForeColor = Color.Maroon
                End If

                If ValD(Gdf(Dr, "maneja_stock")) = 0 Then
                    Continue For
                End If
                '/jdms 638


                'Dim Sto As String = "" & Obtenga_Dato(DtSto, "id_cot_item=" & GrC.Items(I).ToString, "stock")
                Dim Dtss As DataTable = Filtrar_DataTable(DtSto, "id_cot_item=" & GrC.Items(I))
                Dim Sto As String = ""
                Dim Pen As String = ""
                If Not Fin(Dtss) Then
                    Sto = "" & Gdf(Dtss, "stock")
                    Pen = "" & Gdf(Dtss, "pendiente")
                End If

                GrdBus.Rows(K).Cells("pendiente").Value = IIf(ValD(Pen) = 0, "", ValD(Pen))
                If ValD(Sto) <> 0 Then
                    GrdBus.Rows(K).Cells("stock").Value = ValD(System.Math.Round(ValD(Sto) / IIf(ValD(Gdf(Dr, "und_cant")) > 1 And ChkPrecioCaja.Checked, ValD(Gdf(Dr, "und_cant")), 1), 2))
                ElseIf ValD(Sto) <= 0 And ChkStock.Checked Then 'quitar si no tiene stock
                    If ChkPromo.Checked = False Then
                        GrdBus.Rows(K).Visible = False
                        Cua -= 1
                    End If
                End If
                'mostrar ubicación
                GrdBus.Rows(K).Cells("ubica").Value = "" & Obtenga_Dato(DtSto, "id_cot_item=" & GrC.Items(I).ToString, "ubica")

                If ValD(Sto) <= 0 Then
                    GrdBus.Rows(K).DefaultCellStyle.ForeColor = Color.Gray
                End If

                If BodegaPromocion <> "" And ChkPromo.Checked Then
                    Dim St As DataTable = Filtrar_DataTable(DtSto2, "id_cot_item=" & GrC.Items(I).ToString)
                    If Not Fin(St) Then
                        For Each Fi As DataRow In St.Rows
                            'Dim Sto2 As String = "" & Obtenga_Dato(DtSto2, "id_cot_item=" & Tm(GrdBus, "id", I).ToString, "stock")
                            If ValD(Fi("stock")) > 0 Then
                                'insertar el otro renglon con la promoción y generar el precio y cuando le de regresar cambiar de bodega y no mostrar promoción en el 13
                                GrdBus.Rows.Insert(K, 1)
                                For J As Integer = 0 To GrdBus.Columns.Count - 1
                                    GrdBus.Rows(K).Cells(J).Value = GrdBus.Rows(K + 1).Cells(J).Value
                                Next
                                K += 1 'pasar al siguiente I
                                'GrdBus.Rows(I).Cells("descripcion").Style.ForeColor = ChkPromo.ForeColor
                                'GrdBus.Rows(I).DefaultCellStyle.ForeColor = ChkPromo.ForeColor

                                'poner el precio
                                Try
                                    Dim C_Pre As String = ""
                                    Dim C_Des As String = ""
                                    Dim Prec2 As Double = ValD(Tm(GrdBus, "precio_sin_iva", K))
                                    If ChkPrecioCaja.Checked And ValD(Gdf(Dr, "und_cant")) > 1 Then 'poner el precio por unidad de nuevo
                                        Prec2 /= ValD(Gdf(Dr, "und_cant"))
                                    End If
                                    Obtenga_Precio(Dr.Rows(0), Prec2, C_Pre, C_Des, Fi("id_cot_bodega"))
                                    If ChkPrecioCaja.Checked And ValD(Gdf(Dr, "und_cant")) > 1 Then 'poner el precio por unidad de nuevo
                                        C_Pre = FormatoMoneda(ValD(C_Pre) * ValD(Gdf(Dr, "und_cant")))
                                    End If


                                    GrdBus.Rows(K).Cells("dscto").Value = C_Des
                                    GrdBus.Rows(K).Cells("neto").Value = C_Pre

                                    GrdBus.Rows(K).Cells("stock").Value = ValD(System.Math.Round(ValD(Fi("stock")) / IIf(ValD(Gdf(Dr, "und_cant")) > 1 And ChkPrecioCaja.Checked, ValD(Gdf(Dr, "und_cant")), 1), 2))
                                    GrdBus.Rows(K).Cells("pendiente").Value = IIf(ValD(Fi("pendiente")) = 0, "", ValD(Fi("pendiente")))
                                    GrdBus.Rows(K).Cells("ubica").Value = "" & Fi("ubica")
                                    GrdBus.Rows(K).Cells("bodega").Value = Fi("id_cot_bodega")
                                    GrdBus.Rows(K).Cells("descripcion").Value = Chr(9) & "      " & Obtenga_Dato(DtBodegas, "id=" & Fi("id_cot_bodega"), "descripcion")

                                Catch ex As Exception
                                End Try
                            End If
                        Next
                    End If
                End If
            Next


            'esto es muy especial, solo cuando quieran ver las promociones y solo con stock
            'RML 648: Se quita esta condición pero la dejamos en observación pues es muy raro quitarla
            'If ChkPromo.Checked And ChkStock.Checked Then
            If ChkPromo.Checked Or ChkStock.Checked Then
                Dim Esco As Integer = Esconder_Sin_Stock()
                Cua -= Esco
            End If

            LblNegrilla.Text = Cua.ToString & " items"

            If BodegaPromocion <> "" And ChkPromo.Checked Then
                For Each RR As DataGridViewRow In GrdBus.Rows
                    If RR.Visible = False Then
                        Continue For
                    End If

                    If Mid(RR.Cells("descripcion").Value, 1, 1) = Chr(9) Then
                        'RR.Cells("descripcion").Style.ForeColor = ChkPromo.ForeColor
                        RR.DefaultCellStyle.ForeColor = ChkPromo.ForeColor
                    End If
                Next
            End If

        Catch ex As Exception

        End Try

        PnlProc.Visible = False

        'GrdBus.ClearSelection()

    End Sub
    Private Function Esconder_Sin_Stock() As Integer
        'primera pasada, esconder promociones
        For I As Integer = 0 To GrdBus.Rows.Count - 1
            If ValD(GrdBus.Rows(I).Cells("stock").Value) = 0 Then
                If Strings.Left(GrdBus.Rows(I).Cells("descripcion").Value, 1) = Chr(9) Then 'es una promoción, escoderla
                    GrdBus.Rows(I).Visible = False
                End If
            End If
        Next

        Dim Cua As Integer = 0

        'segunda pasada, esconder el resto
        For I As Integer = 0 To GrdBus.Rows.Count - 1
            If GrdBus.Rows(I).Visible = False Then Continue For

            If ValD(GrdBus.Rows(I).Cells("stock").Value) = 0 Then 'esta debe ser una madre, ver si tiene algo adentro
                Dim Esconder As Boolean = True
                For K As Integer = I + 1 To GrdBus.Rows.Count - 1
                    If Strings.Left(GrdBus.Rows(K).Cells("descripcion").Value, 1) = Chr(9) Then 'es una promoción, escoderla
                        If GrdBus.Rows(K).Visible = False Then
                            Continue For
                        Else
                            Esconder = False
                            Exit For 'no esconder
                        End If
                    Else
                        Esconder = True
                        Exit For
                    End If
                Next

                If Esconder Then 'es una promoción, escoderla
                    Cua += 1
                    GrdBus.Rows(I).Visible = False
                End If
            End If
        Next

        Return Cua

    End Function
    Private Sub ChkStock_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkStock.CheckedChanged, ChkReal.CheckedChanged, ChkSoloInicial.CheckedChanged
        Limpiar()

        SaveSett(Me.Name, "sinstock", ChkStock.Checked)

    End Sub
    Private Sub ChkPrinAct_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkPrinAct.CheckedChanged
        Limpiar()

        SaveSett(Me.Name, "princiact", ChkPrinAct.Checked)


    End Sub


    Private Sub ChkOcultarPrecio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkOcultarPrecio.CheckedChanged
        GrdBus.Columns("Precio_sin_iva").Visible = Not ChkOcultarPrecio.Checked
        GrdBus.Columns("dscto").Visible = Not ChkOcultarPrecio.Checked And lblPrecioNro > 0
        GrdBus.Columns("neto").Visible = Not ChkOcultarPrecio.Checked And lblPrecioNro > 0

        SaveSett(Me.Name, "ocultarprecio", ChkOcultarPrecio.Checked)

    End Sub


    Private Sub TxtBuscarItem2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscarItem2.KeyPress
        If TxtBuscarItem.Text.Trim = "" Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub ChkPromo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkPromo.CheckedChanged
        Limpiar()

        SaveSett(Me.Name, "mostrarpromo", ChkPromo.Checked)
        'GrdBus.Columns("bodega").Visible = ChkPromo.Checked

    End Sub

    Private Sub ChkPrecioCaja_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkPrecioCaja.CheckedChanged
        Limpiar()

        SaveSett(Me.Name, "preciocaja", ChkPrecioCaja.Checked)

    End Sub

    Private Sub LnkVarios_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkVarios.LinkClicked
        If fVa Is Nothing Then
            fVa = New fVarios
        End If
        fVa.ShowDialog()

        If ValD(fVa.Tag) = 1 Then
            LnkVarios.LinkColor = Color.Red
            SiVarios = True
        Else
            SiVarios = False
            LnkVarios.LinkColor = Color.Blue
        End If

    End Sub

    Private Sub GrdBus_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles GrdBus.KeyPress
        'entrar la cantidad
        If Not UsarCant Then Exit Sub
        Try
            If e.KeyChar >= "0" And e.KeyChar <= "9" Then
                GrdBus.CurrentRow.Cells("cua").Value &= e.KeyChar
            End If
        Catch
        End Try

    End Sub

    Private Sub TxtDcto_Validated(sender As System.Object, e As System.EventArgs) Handles TxtDcto.Validated
        If Not IsNumeric(TxtDcto.Text) Then
            TxtDcto.Text = ""
            Exit Sub
        End If
        TxtDcto.Text = ValD(TxtDcto.Text)
        If ValD(TxtDcto.Text) < 0 Or ValD(TxtDcto.Text) > 100 Then
            Mensaje("Descuento inválido")
            TxtDcto.Text = ""
            TxtDcto.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub CbTalla_DMSSelectIndex(Sender As System.Object, Id As System.Int32) Handles CbTalla.DMSSelectIndex, CbGener.DMSSelectIndex
        Limpiar()

    End Sub

    'Private Sub fBusItems_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        e.SuppressKeyPress = True
    '        If GrdBus.Rows.Count = 0 Then
    '            CmdBuscar_Click(CmdBuscar, New EventArgs)
    '        Else
    '            CmdModificar_Click(CmdModificar, New EventArgs)
    '        End If
    '    End If
    'End Sub

    Private Sub ChkLineaGen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkLineaGen.CheckedChanged
        GrdBus.Columns("linea").Visible = ChkLineaGen.Checked
        GrdBus.Columns("generico").Visible = ChkLineaGen.Checked
        GrdBus.Columns("grupo").Visible = ChkLineaGen.Checked
        GrdBus.Columns("subgrupo").Visible = ChkLineaGen.Checked
        If ChkLineaGen.Checked Then
            If DtTalla.Rows.Count = 0 Then
                SiReloj()
                Cargar_Tallas()
                NoReloj()
            End If
        End If
        Limpiar()
        SaveSett(Me.Name, "lingen", ChkLineaGen.Checked)

    End Sub

    Private Sub CbTama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTama.SelectedIndexChanged
        If CbTama.SelectedIndex = 2 Then
            GrdBus.Font = LblFont.Font
            GrdNue.Grid.Font = LblFont.Font
        ElseIf CbTama.SelectedIndex = 1 Then
            GrdBus.Font = LblItem.Font
            GrdNue.Grid.Font = LblItem.Font
        Else
            GrdBus.Font = LblNegrilla.Font
            GrdNue.Grid.Font = LblNegrilla.Font
        End If
        SaveSett(Me.Name, "font", CbTama.SelectedIndex)

    End Sub

    Private Sub GrdBus_ColumnDisplayIndexChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles GrdBus.ColumnDisplayIndexChanged


        If Cargando Then Exit Sub

        'SaveSett(Me.Name, "dp" & ProgramaOrigen & e.Column.Name, e.Column.DisplayIndex)
        For I As Integer = 0 To GrdBus.Columns.Count - 1
            SaveSett(Me.Name, "dp" & Strings.Format(I, "000"), GrdBus.Columns(I).DisplayIndex)
        Next

    End Sub

    Private Sub Grd_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles GrdBus.ColumnWidthChanged
        If Cargando Then Exit Sub

        SaveSett(Me.Name, "cl" & e.Column.Name, e.Column.Width)

    End Sub

    'Private Sub CmdAnchoPred_Click(sender As Object, e As EventArgs) Handles CmdAnchoPred.Click

    'End Sub

    Private Sub CmdAnchoPred_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CmdAnchoPred.LinkClicked
        If Not Pregunte("Esta opción pone el ancho y posición de las columnas del grid con su valor predeterminado.  Desea hacerlo ahora?") Then
            Exit Sub
        End If

        For I As Integer = 0 To GrdBus.ColumnCount - 1
            Try
                Dim Anch As Integer = GetSett(Me.Name, "cl" & GrdBus.Columns(I).Name, -1)
                If Anch >= 0 Then
                    DeleteSetting(DiegoSet, Me.Name, "cl" & GrdBus.Columns(I).Name)
                End If
                Anch = GetSett(Me.Name, "dp" & Strings.Format(I, "000"), -1)
                If Anch >= 0 Then
                    DeleteSetting(DiegoSet, Me.Name, "dp" & Strings.Format(I, "000"))
                End If
            Catch ex As Exception

            End Try
        Next

        Mensaje("Columnas han sido reestablecidas.  Salga del programa y vuelva a entrar para ver el resultado")

    End Sub

    Private Sub fBusItems_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        'esto estaba en el Load
        If SoyHandHeld() Then 'asumir handheld
            HandHeld()
        End If

        'PnlProc.Top = 0
        'PnlProc.Left = 0
        PnlProc.Dock = DockStyle.Top
        PnlProc.Height = GrdBus.Top
        PnlProc.BringToFront()




        Cargar_Items()
        Poner_Marcas()

        If ReglaDeNegocio(74, , "0") <> "1" Or lblPrecioNro = 0 Or IdBod = 0 Then
            GrdBus.Columns("dscto").Visible = False
            GrdBus.Columns("neto").Visible = False
        Else
            GrdBus.Columns("neto").HeaderText = "Lista #" & lblPrecioNro.ToString
        End If

        GrdBus.Columns("cua").Visible = UsarCant

        TxtBuscarItem.SelectAll()
        TxtBuscarItem.Focus()

        If Regla_SoyTaller_15() Or Regla_SoyAutomotriz_16() Then
            PnlContenido.Visible = True
        Else
            OptTempYVeh.Checked = True
        End If

        If CbGrupo.ComboBox1.Items.Count > 0 Then GoTo Saliendo

        'If GrdBus.RowCount > 0 Then Exit Sub
        If IncluirVendidosAnulados = True Then
            ChkTodos.Checked = True
        End If

        PrecioMasIva = ReglaDeNegocio(122, "preciomasiva", "0") = "1"

        Try
            ChkPrinAct.Checked = GetSett(Me.Name, "princiact", False)
            ChkStock.Checked = GetSett(Me.Name, "sinstock", False)
        Catch
        End Try

        If ReglaDeNegocio(122, "no_precio", "0") = 1 Then 'deshabilitar el campo
            ChkOcultarPrecio.Checked = True
            ChkOcultarPrecio.Enabled = False
            ChkOcultarPrecio.Text += " Rn#122"
        Else
            ChkOcultarPrecio.Checked = GetSett(Me.Name, "ocultarprecio", False)
        End If

        Mayores = ValD(ReglaDeNegocio(122, "mayores", "0"))

        ChkPromo.Checked = GetSett(Me.Name, "mostrarpromo", False)
        ChkLimpiar.Checked = GetSett(Me.Name, "limpiar", False)
        ChkPrecioCaja.Checked = GetSett(Me.Name, "preciocaja", False)
        ChkLineaGen.Checked = GetSett(Me.Name, "lingen", False)

        'tamaño letra del grid
        Try
            Dim tama As Integer = GetSett(Me.Name, "font", 1)
            CbTama.SelectedIndex = tama
        Catch
        End Try



        Me.Show()

        Try


            LnkAvanzado.Visible = True



            Cargar_Grupos()




            Dim GruIni As String = GetSett(Me.Name, "gru", "0")
            CbGrupo.DMSLlene_Combo(QuiteDuplicados(DtCotGrupos, "id_padre", "des_padre"), "id_padre", "des_padre", , , "Todos")
            CbGrupo.DMSPongaIndex(ValD(GruIni))
            If CbGrupo.ComboBox1.SelectedIndex < 0 Then
                Try
                    CbGrupo.DMSPongaIndex(0)
                Catch
                End Try
            End If


            'cargar proveedores
            CbProv.DMSLlene_Combo(DtProveedores, "id", "razon_social", , "razon_social", "Todos", 0)

            Cargar_Tallas()
            CbTalla.DMSLlene_Combo(DtTalla, "id", "descripcion", , "descripcion", "Todas", 0, , True)
            CbGener.DMSLlene_Combo(DtColor, "id", "descripcion", , "descripcion", "Todos", 0, True, False)

            Reloj(False)



        Catch ex As Exception
            Mensaje("Intente más tarde")
            Me.Close()

        End Try

        GrdBus.Columns("reservado").Visible = Regla_SoyAutomotriz_16()
        GrdBus.Columns.Add("Stock", "Stock")
        GrdBus.Columns("stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GrdBus.Columns("stock").Width = 50
        GrdBus.Columns.Add("pendiente", "Pendte")
        GrdBus.Columns("pendiente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GrdBus.Columns("pendiente").Width = 40

        GrdBus.Columns.Add("Ubica", "Ubica")
        GrdBus.Columns("ubica").Width = 50

        If IdBod = 0 Then
            IdBod = BodegaUsuario
        End If
        IdBod = IIf(ValD(GetSett(Me.Name, "nostock", 0)) = 1, 0, IdBod)

        Dim bodtag As String = "" 'no todas
        If ReglaDeNegocio(149, "usu" & Usuario.ToString, "0") = "1" Or DtBodegas.Rows.Count = DtBodegasPerm.Rows.Count Then
            bodtag = "S" 'todas
        End If
        CbBod.DMSLlene_Combo(DtBodegas, "id", "descripcion", "IsNull(anulada,0)=0" & IIf(bodtag = "S", "", " and permitida=1"), , "(No mostrar stock)", IdBod)
        Parte_Bodega()


        '---------------------------------------------
        TxtBuscarItem.SelectAll()
        TxtBuscarItem.Focus()



Saliendo:
        'orden de las columnas
        For I As Integer = 0 To GrdBus.ColumnCount - 1
            Try
                Dim Anch As Integer = GetSett(Me.Name, "dp" & Strings.Format(I, "000"), -1)
                If Anch >= 0 Then
                    GrdBus.Columns(I).DisplayIndex = Anch
                End If
                Anch = GetSett(Me.Name, "cl" & GrdBus.Columns(I).Name, -1)
                If Anch >= 0 Then
                    GrdBus.Columns(I).Width = Anch
                End If
            Catch ex As Exception
            End Try
        Next
        '/orden de las columnas


        '================================================================================================================
        If BusquedaNueva Then
            GrdNue.Visible = True
            GrdNue.Location = GrdBus.Location
            GrdNue.Size = GrdBus.Size
            GrdNue.Anchor = GrdBus.Anchor
            GrdBus.Visible = False

            ChkPromo.Visible = False
            ChkPrecioCaja.Visible = False
            ChkOcultarPrecio.Visible = False
            ChkPrinAct.Visible = False
            ChkReal.Visible = False
            ChkLineaGen.Visible = False
            ChkSoloInicial.Visible = False
            ChkTodos.Visible = False
            PnlContenido.Visible = False
            Label10.Visible = False
            TxtDcto.Visible = False
            Panel1.Visible = False
            Panel2.Visible = False
            LnkAvanzado.Visible = True
            LnkVarios.Visible = False
            Label9.Visible = False
            TxtBuscarItem2.Visible = False
            TxtCod.Visible = False
            Label8.Visible = False
            Label13.Visible = False
            TxtAlterna.Visible = False
            LnkExcel.Visible = False
            CmdAnchoPred.Visible = False
            LinkLabel1.Visible = False
            LnkRefrescar.Visible = False
            LnkAbrir.Visible = False
            LblStock.Visible = False
        End If
        '================================================================================================================

        Cargando = False

        'DebugJD("ite bus:" & ItemBuscado)
        If ItemBuscado <> "" Then
            TxtBuscarItem.Text = ItemBuscado
            'DebugJD("ite bus: entro: " & TxtBuscarItem.Text)
            If TxtBuscarItem.Text <> "" Then
                CmdBuscar_Click(CmdBuscar, New EventArgs)
                TxtBuscarItem.Focus()
                TxtBuscarItem.SelectAll()
            End If
        Else
            TxtBuscarItem.Text = GetSett(Me.Name, "ultbus" & Numero_Empresa.ToString & MarcaExterna, "")
            TxtBuscarItem2.Text = GetSett(Me.Name, "ultbus2" & Numero_Empresa.ToString & MarcaExterna, "")
            TxtCod.Text = GetSett(Me.Name, "ultbus3" & Numero_Empresa.ToString & MarcaExterna, "")
        End If
        '/esto estaba en el Load



        'final de todo
        If GrdBus.Rows.Count > 0 Or GrdNue.Grid.Rows.Count > 0 Then
            Foco_Grid()
        Else
            TxtBuscarItem.Focus()
        End If

    End Sub

    Private Sub ChkLimpiar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLimpiar.CheckedChanged
        SaveSett(Me.Name, "limpiar", ChkLimpiar.Checked)

    End Sub

    Private Sub OptTempario_CheckedChanged(sender As Object, e As EventArgs) Handles OptTempario.CheckedChanged, OptVehiculos.CheckedChanged
        Limpiar()

        GrdBus.Columns("Precio_sin_iva").Visible = Not OptTempario.Checked

        CbBod.Visible = Not OptTempario.Checked
        Label1.Visible = Not OptTempario.Checked
        ChkStock.Visible = Not OptTempario.Checked
        ChkReal.Visible = Not OptTempario.Checked
        ChkOcultarPrecio.Visible = Not OptTempario.Checked
        ChkStock.Checked = Not OptTempario.Checked
        ChkPromo.Visible = Not OptTempario.Checked

        If OptTempario.Checked Then
            IdBod = 0
            ChkPromo.Checked = False
        End If

        TxtBuscarItem.Focus()
    End Sub

    Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click
        ItemBuscado = ""
        Me.Hide()

    End Sub

    Private Sub CmdMostrarPrecios_Click(sender As Object, e As EventArgs) Handles CmdMostrarPrecios.Click
        If Not Pregunte("Seguro de ver los precios de los ítems encontrados en la búsqueda, sabiendo que es un proceso lento por que se basa en el costo promedio?", "Obtener precios", Me.Name) Then
            Exit Sub
        End If

        CuantosHay = GrdBus.Rows.Count


        CmdMostrarPrecios.Visible = False
        CmdMostrarPrecios.Tag = 1
        CmdBuscar.PerformClick()
        CmdMostrarPrecios.Tag = -1

    End Sub

    Private Sub GrdNue_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles GrdNue.DMSTraerValor

        If Me.Tag = "consulta" Then
            'AbraItem()
        Else
            CmdModificar_Click(CmdModificar, New EventArgs)
        End If

    End Sub

    Private Sub GrdNue_DMSKeyDown(Sender As Object, e As KeyEventArgs, NombreCol As String, ByRef ValorCelda As Object, ColDevolver As Integer) Handles GrdNue.DMSKeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            CmdModificar_Click(CmdModificar, New EventArgs)
        ElseIf UsarCant Then
            'evaluar a ver si presiono la tecla backespace
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Delete Then
                Try
                    If GrdNue.Grid.CurrentRow.Cells("cua").Value <> "" Then
                        If GrdNue.Grid.CurrentRow.Cells("cua").Value.ToString.Length = 1 Then
                            GrdNue.Grid.CurrentRow.Cells("cua").Value = ""
                        Else
                            GrdNue.Grid.CurrentRow.Cells("cua").Value = Mid(GrdNue.Grid.CurrentRow.Cells("cua").Value, 1, GrdNue.Grid.CurrentRow.Cells("cua").Value.ToString.Length - 1)
                        End If
                    End If
                Catch
                End Try
            End If
        End If

    End Sub

    Private Sub GrdNue_DMSKeyPress(Sender As Object, e As KeyPressEventArgs) Handles GrdNue.DMSKeyPress
        'entrar la cantidad
        If Not UsarCant Then Exit Sub
        Try
            If e.KeyChar >= "0" And e.KeyChar <= "9" Then
                GrdNue.Grid.CurrentRow.Cells("cua").Value &= e.KeyChar
            End If
        Catch
        End Try

    End Sub


End Class