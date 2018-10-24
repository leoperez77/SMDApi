'♥ versión: 586, 6-oct.-2017 07:11
Public Class fBuscarCliente
    Public DtCli2 As New DataTable
    Const MaxBot As Short = 32
    Dim IdCon(MaxBot) As Integer
    Dim NomCon(MaxBot) As String
    Dim MontoMesas As Boolean = False
    Dim DtMesas As New DataTable

    Public Sector_Empresa As Integer
    Public Numero_Empresa As Integer

    Dim Sql As String = ""

    Public IdCli_Out As Integer
    Public Razon_Out As String = ""
    Public IdCon_Out As Integer
    Public IdCon_Out_Ant As Integer = -1
    Public Nombre_Out As String = ""
    Public Zona_Out As Integer = 0
    Public Zona_Sub_Out As Integer = 0
    Public Actividad_Out As Integer = 0
    Public Perfil_Out As Integer = 0
    Public Tipo_Tributario_Out As Integer = 0
    Public Nit_Out As String = ""
    Public Destino As Short = 0
    Public AceptaAnulados As Boolean = False
    'Public FormaRegresar As Form

    Dim HaySigla As Boolean = False


    Private Sub fBusCli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If SoyHandHeld() Then
            Me.FormBorderStyle = Forms.FormBorderStyle.FixedToolWindow
            Me.WindowState = FormWindowState.Maximized
        End If

        If DtCli2.Rows.Count = 0 Then
            GridDms1.Grid.DataSource = DtCli2
        End If

        If GridDms1.Grid.Rows.Count = 0 Then
            Asignar_Logo(GridDms1.Grid, PicLogo)
        Else
            Exit Sub
        End If

        HaySigla = Pruebas.ReglaDeNegocio(111, "url-sigla", "0") = "1"

        If Regla_SoyRestaurante_17() Then
            Ponga_Favoritos_Mesas()
        End If

        If DtMesas.Rows.Count = 0 Then 'si no hay mesas
            SplitContainer1.Panel2Collapsed = True
            'PnlPOS.Visible = False
            'Grd.Height = Grd.Height + PnlPOS.Height
        End If

        Try
            CbDestinos.Items.Clear()
            CbDestinos.Items.Add("(Todos)")
            CbDestinos.Items.Add("Proveedores")
            CbDestinos.SelectedIndex = Destino
            CbDestinos.Enabled = Destino = 0 'solo cuando sean todos se puede cambiar
        Catch ex As Exception
            CbDestinos.SelectedIndex = 0
        End Try

        Try
            ChkContactoPpal.Checked = GetSett(Me.Name, "contactoppal", False)
            ChkDireccion.Checked = GetSett(Me.Name, "direcc", False)
        Catch
        End Try

        TxtCli.Text = GetSett(Me.Name, "ultbus" & Numero_Empresa.ToString & MarcaExterna, "")

      
        Habilitar_Regresar()



        TxtCli.Tag = ""
        TxtCli.SelectAll()
        TxtCli.Focus()

    End Sub
    Private Sub Habilitar_Regresar()
        CmdRegresar.Enabled = GridDms1.Grid.Rows.Count > 0

    End Sub
    Private Sub Ponga_Favoritos_Mesas()
        Try
            If MontoMesas Then Exit Sub

            MontoMesas = True

            Reloj()

            Abrir(DtMesas, "GetCotMesas " & Numero_Empresa.ToString)

            Reloj(False)

            If DtMesas.Rows.Count = 0 Then
                'Mensaje("Para que en los botones aparezcan las mesas, anteponga un guión (-) al nombre de cada mesa")
                Exit Sub
            End If

            For I As Integer = 1 To MaxBot
                Dim Boton As Button = DirectCast(Me.Controls.Find("Button" & I.ToString, True)(0), Button)
                Boton.Visible = False
                'Boton.Text = ""
                'Boton.Tag = ""
            Next

            For I As Integer = 0 To DtMesas.Rows.Count - 1
                If I = MaxBot Then 'solo 16 mesas por el momento
                    Exit For
                End If

                Dim Boton As Button = DirectCast(Me.Controls.Find("Button" & (I + 1).ToString, True)(0), Button)
                Boton.Visible = True
                Boton.Text = Gdf(DtMesas, I, "razon_social")
                Boton.Tag = Gdf(DtMesas, I, "id_cot_cliente")
                IdCon(I + 1) = Gdf(DtMesas, I, "id_cot_cliente_contacto")
                NomCon(I + 1) = Gdf(DtMesas, I, "nombre")
            Next

        Catch ex As Exception

        End Try

    End Sub
    Public Sub AdicioneSql(ByVal TextoSql As String)
        If SQL <> "" Then SQL = SQL & " And "
        SQL = SQL & TextoSql

    End Sub

    Private Sub CmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBuscar.Click
        If TxtCli.Text.Trim = "" Then
            'Mensaje("Entre parte del nit, nombre o razón social")
            TxtCli.Focus()
            Exit Sub
        End If

        If InStr(TxtCli.Text, "'") > 0 Then
            Mensaje("No puede incluir el caracter ' en el texto")
            Exit Sub
        End If

        Dim Bus As String = TxtCli.Text '"" 'Replace(TxtCli.Text, "'", "''")
        If Mid(TxtCli.Text, 1, 2) = "//" Then 'es descrip item
            Bus = Mid(Bus, 3)
        End If
        Dim Co() As String

        If Bus <> "" Then
            Sql = ""
            Co = Split(Bus, "&")
            For Each cn As String In Co
                If Mid(TxtCli.Text, 1, 2) = "//" Then 'es descrip item
                    AdicioneSql("(ct.placa like ''%" & cn.Trim & "%'')")
                Else
                    AdicioneSql("(c.razon_social" & IIf(HaySigla, "+IsNull(c.url,'''')", "") & "+IsNull(t.nombre,'''')+IsNull(t.tel_1,'''')+IsNull(c.tel_1,'''')+IsNull(t.cedula,'''')+IsNull(c.nit,'''') like ''%" & cn.Trim & "%'')")
                End If
            Next
            Bus = Sql
        End If
        If Mid(TxtCli.Text, 1, 2) = "//" Then 'es descrip item
            Bus = "//" & Bus
        End If
        If Len(Bus) > 600 Then 'por poner algun control
            Mensaje("Longitud de búsqueda debe ser menor")
            TxtCli.SelectAll()
            TxtCli.Focus()
            Exit Sub
        End If

        SiReloj(Me)
        'con grid dms
        Dim SqlIns As String = "exec GetCotClientesBasicoMasContactos9 " & Numero_Empresa.ToString & ",0,'" & Bus & "',0,0,0," & IIf(ChkDireccion.Checked, "1", "0") & "," & IdCon_Out.ToString & "," & CbDestinos.SelectedIndex.ToString & "," & IIf(AceptaAnulados, "1", "0") & "," & IIf(ChkContactoPpal.Checked, "1", "0")
        Try
            Abrir(DtCli2, SqlIns)
        Catch ex As Exception
            NoReloj(Me)
            Mensaje_TopMost("No logró traer datos: " & ex.Message, , , True)
            Exit Sub
        End Try
        GridDms1.DMSLlene_Grid(DtCli2, "id", ColOcultas:=New Object() {
                                                                    "id",
                                                                    "blo",
                                                                    IIf(HaySigla, "", "Sigla"),
                                                                    IIf(IdCon_Out = 0, "contacto", ""),
                                                                    IIf(IdCon_Out = 0, "tel_con", ""),
                                                                    IIf(ChkContactoPpal.Checked, "", "contacto_ppal"),
                                                                    IIf(ChkDireccion.Checked, "", "direccion"),
                                                                    "id_cot_cliente_contacto",
                                                                    "id_cot_zona_sub",
                                                                    "id_cot_zona",
                                                                    "id_usuario_vendedor",
                                                                    "des_estado",
                                                                    "id_cot_cliente_actividad",
                                                                    "id_cot_cliente_perfil",
                                                                    "id_tipo_tributario",
                                                                    "precio_costo"
                                                                },
                                                            MostrarEliminar:=False,
                                                            SeleccionarPrimeraFila:=False
                                                            )
        For I As Integer = 0 To GridDms1.Grid.Rows.Count - 1
            If Tm(GridDms1.Grid, "blo", I) <> "" Then
                If ValD(Tm(GridDms1.Grid, "blo", I)) = 2 Then
                    GridDms1.Grid.Rows(I).DefaultCellStyle.ForeColor = Color.Red
                Else
                    GridDms1.Grid.Rows(I).DefaultCellStyle.ForeColor = Color.Green
                End If
            End If
        Next

        '/con grid dms



        PicLogo.Visible = False

        If DtCli2.Rows.Count > 0 Then
            SaveSett(Me.Name, "ultbus" & Numero_Empresa.ToString & MarcaExterna, TxtCli.Text)
        End If

        'Grd.Focus()
        'TxtCli.SelectAll()
        TxtCli.Tag = TxtCli.Text
        TxtCli.Text = ""
        TxtCli.Focus()

        Habilitar_Regresar()


        NoReloj(Me)

    End Sub

    Private Sub CmdRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRegresar.Click
        If GridDms1.Grid.SelectedRows.Count = 0 And GridDms1.Grid.RowCount > 0 Then
            GridDms1.Grid.Rows(0).Selected = True
        End If

        If GridDms1.Grid.SelectedRows.Count = 0 Then
            'Mensaje("Seleccione algún cliente")
            Cancelar()
            Exit Sub
        End If

        'IdCli_Out = Gdf(DtCli2, GridDms1.grid.SelectedRows(0).Index, "id")
        'IdCon_Out = ValD("" & Gdf(DtCli2, GridDms1.grid.SelectedRows(0).Index, "id_cot_cliente_contacto"))
        'Razon_Out = Gdf(DtCli2, GridDms1.grid.SelectedRows(0).Index, "razon_social")
        'Nombre_Out = Gdf(DtCli2, GridDms1.grid.SelectedRows(0).Index, "nombre_contacto")
        'Zona_Out = Gdf(DtCli2, GridDms1.grid.SelectedRows(0).Index, "id_cot_zona")
        'Zona_Sub_Out = Gdf(DtCli2, GridDms1.grid.SelectedRows(0).Index, "id_cot_zona_sub")
        'Actividad_Out = ValD(Gdf(DtCli2, GridDms1.grid.SelectedRows(0).Index, "id_cot_cliente_actividad"))
        'Perfil_Out = ValD(Gdf(DtCli2, GridDms1.grid.SelectedRows(0).Index, "id_cot_cliente_perfil"))
        'Nit_Out = ValD("" & Gdf(DtCli2, GridDms1.grid.SelectedRows(0).Index, "nit"))

        IdCli_Out = Tm(GridDms1.Grid, "id")
        IdCon_Out = ValD(Tm(GridDms1.Grid, "id_cot_cliente_contacto"))
        Razon_Out = Tm(GridDms1.Grid, "empresa")
        Nombre_Out = Tm(GridDms1.Grid, "contacto")
        Zona_Out = ValD(Tm(GridDms1.Grid, "id_cot_zona"))
        Zona_Sub_Out = ValD(Tm(GridDms1.Grid, "id_cot_zona_sub"))
        Actividad_Out = ValD(Tm(GridDms1.Grid, "id_cot_cliente_actividad"))
        Perfil_Out = ValD(Tm(GridDms1.Grid, "id_cot_cliente_perfil"))
        Tipo_Tributario_Out = ValD(Tm(GridDms1.Grid, "id_tipo_tributario"))
        Nit_Out = Tm(GridDms1.Grid, "nit")

        Me.Hide()

        'If FormaRegresar IsNot Nothing Then
        '    FormaRegresar.Show()
        'End If

    End Sub


    Private Sub Grd_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Exit Sub

        CmdRegresar_Click(CmdRegresar, New EventArgs)

    End Sub

    Private Sub Grd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        e.SuppressKeyPress = True

        If e.KeyCode = Keys.Return Then
            CmdRegresar_Click(CmdRegresar, New EventArgs)
        End If
    End Sub

    Private Sub fBusCli_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        TxtCli.SelectAll()
        TxtCli.Focus()

    End Sub


    Private Sub fBusCli_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TxtCli.SelectAll()
        TxtCli.Focus()

    End Sub

    Private Sub Cancelar()
        IdCli_Out = 0
        IdCon_Out = 0

        Me.Tag = 0
        Me.Hide()

    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        SaveSett(DiegoSet, "int.cli", "")

        Timer1.Start()
        LblTimer.Visible = True

        AbrirPrograma("0150", ".")


        'IdCli_Out = -1
        'IdCon_Out = 0

        'Me.Hide()

    End Sub

    Private Sub LnkModif_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkModif.LinkClicked
        If GridDms1.Grid.SelectedRows.Count = 0 Then
            Mensaje("Seleccione algún cliente")
            Exit Sub
        End If

        SiReloj()

        AbrirPrograma("0150", Tm(GridDms1.Grid, "id"))

        NoReloj()

        'IdCli_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "id") * -1
        'IdCon_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "id_cot_cliente_contacto") * -1
        'Razon_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "razon_social")
        'Nombre_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "nombre_contacto")

        'Me.Hide()

    End Sub

    Private Sub LnkPlaca_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkPlaca.LinkClicked
        Dim Placa As String = InputBox("Escriba parte de la descripción del item o de su código:" & DMScr(2) & "El sistema mostrará todos los clientes que tengan documentos cuyos items contengan este texto en su descripción o código (en Vehículos la Placa) o en el campo Placa de la Oportunidad. Igualmente mostrará clientes que tengan vehículos con dicho texto en descripción o placa").Trim
        If Placa = "" Then Exit Sub

        TxtCli.Text = "//" & Placa
        CmdBuscar_Click(CmdBuscar, New EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, PnlPOS.Click, Button32.Click, Button31.Click, Button30.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button19.Click, Button18.Click, Button17.Click
        If ValD(sender.tag) = 0 Then Exit Sub

        Try
            Dim Pos As Integer
            If IsNumeric(Mid(sender.name, Len(sender.name) - 1, 2)) Then
                Pos = Mid(sender.name, Len(sender.name) - 1, 2)
            Else
                Pos = Mid(sender.name, Len(sender.name), 1)
            End If

            TxtCli.Text = sender.text
            CmdBuscar_Click(CmdBuscar, New EventArgs)
            CmdRegresar_Click(CmdRegresar, New EventArgs)

            'Try
            '    If Grd.DataSource IsNot Nothing Then
            '        Grd.DataSource = Nothing
            '    Else
            '        Grd.Rows.Clear()
            '    End If
            'Catch
            'End Try

            'If Grd.Rows.Count = 0 Then
            '    Grd.Rows.Add()
            'End If
            'Grd.Rows(0).Cells("id").Value = ValD(sender.tag)
            'Grd.Rows(0).Cells("razon_social").Value = sender.text
            'Grd.Rows(0).Cells("id_cot_cliente_contacto").Value = IdCon(Pos)
            'Grd.Rows(0).Cells("nombre_contacto").Value = NomCon(Pos)

            'CmdRegresar_Click(CmdRegresar, New EventArgs)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub TxtCli_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCli.KeyDown
        Try
            If e.KeyCode = Keys.Down Then
                If GridDms1.Grid.SelectedRows(0).Index < GridDms1.Grid.Rows.Count - 1 Then
                    GridDms1.Grid.Rows(GridDms1.Grid.SelectedRows(0).Index + 1).Selected = True
                End If
                e.SuppressKeyPress = True
            ElseIf e.KeyCode = Keys.Up Then
                If GridDms1.Grid.SelectedRows(0).Index > 0 Then
                    GridDms1.Grid.Rows(GridDms1.Grid.SelectedRows(0).Index - 1).Selected = True
                End If
                e.SuppressKeyPress = True
            ElseIf e.KeyCode = Keys.Return Then
                e.SuppressKeyPress = True
                If GridDms1.Grid.Rows.Count > 0 And TxtCli.Text = "" Then
                    CmdRegresar_Click(CmdRegresar, New EventArgs)
                Else
                    CmdBuscar_Click(CmdBuscar, New EventArgs)
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TxtCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCli.TextChanged
        Try
            'Grd.DataSource = Nothing
        Catch
        End Try

    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Cancelar()

    End Sub

    Private Sub LnkUltimo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkUltimo.LinkClicked
        TxtCli.Text = GetSett(DiegoSet, "int.cli", "")
        CmdBuscar_Click(CmdBuscar, New EventArgs)

    End Sub

    Private Sub ChkDireccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDireccion.CheckedChanged
        SaveSett(Me.Name, "direcc", ChkDireccion.Checked)

        TxtCli.Focus()
        GridDms1.Grid.Columns("direccion").Visible = ChkDireccion.Checked
        If ChkDireccion.Checked Then
            If GridDms1.Grid.Rows.Count > 0 Then
                TxtCli.Text = TxtCli.Tag
                CmdBuscar_Click(CmdBuscar, New EventArgs)
            End If
        End If

    End Sub

    Private Sub Grd_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PicLogo.Size = GridDms1.Grid.Size

    End Sub

    Private Sub CbDestinos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbDestinos.SelectedIndexChanged
        TxtCli.Text = TxtCli.Tag

        CmdBuscar_Click(Nothing, New EventArgs)

    End Sub

    Private Sub ChkContactoPpal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkContactoPpal.CheckedChanged
        SaveSett(Me.Name, "contactoppal", ChkContactoPpal.Checked)

        TxtCli.Focus()
        GridDms1.Grid.Columns("contacto_ppal").Visible = ChkContactoPpal.Checked
        If ChkContactoPpal.Checked Then
            If GridDms1.Grid.Rows.Count > 0 Then
                TxtCli.Text = TxtCli.Tag
                CmdBuscar_Click(CmdBuscar, New EventArgs)
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim Cli As String = GetSett(DiegoSet, "int.cli", "")
        If Cli <> "" Then
            Timer1.Stop()
            LblTimer.Visible = False
            If Cli <> "..." Then 'abortar
                TxtCli.Text = Cli
                CmdBuscar_Click(CmdBuscar, New EventArgs)
            End If
        End If

    End Sub

    Private Sub GridDms1_DMSTraerValor(Sender As System.Object, ValorColDevolver As System.Object) Handles GridDms1.DMSTraerValor
        CmdRegresar_Click(CmdRegresar, New EventArgs)

    End Sub
End Class