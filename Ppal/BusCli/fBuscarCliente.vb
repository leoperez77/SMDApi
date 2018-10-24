' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
' Version: 678, 16-ago.-2018 14:15
' Version: 616, 25-ene.-2018 12:32
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fBuscarCliente
    Dim Cargando As Boolean = False

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


    'Dim HaySigla As Boolean = False


    Private Sub fBusCli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If SoyHandHeld() Then
            Me.FormBorderStyle = Forms.FormBorderStyle.FixedToolWindow
            Me.WindowState = FormWindowState.Maximized
        End If

		Me.Text = Idi(Me.Text)

		If DtCli2.Rows.Count = 0 Then
			Grd.DataSource = DtCli2
		End If

		If Grd.Rows.Count = 0 Then
			Asignar_Logo(Grd, PicLogo)
			Grd.Visible = False
		Else
			Grd.Visible = True
			Exit Sub
		End If

		Cargando = True

		Try
			Dim ord As String = GetSett(Me.Name, "orden", "")
			If ord = "" Then
				CbOrden.SelectedIndex = 0
			Else
				CbOrden.Text = ord
			End If

		Catch ex As Exception

		End Try

		'HaySigla = ReglaDeNegocio(111, "url-sigla", "0") = "1"

		If Regla_SoyRestaurante_17() Then
			Ponga_Favoritos_Mesas()
		End If

		If DtMesas.Rows.Count = 0 Then 'si no hay mesas
			SplitContainer1.Panel2Collapsed = True
			'PnlPOS.Visible = False
			'Grd.Height = Grd.Height + PnlPOS.Height
		End If

		Try
			If Destino = 1 Then
				OptProv.Checked = True
			End If
			OptProv.Enabled = Destino = 0 'solo cuando sean todos se puede cambiar
		Catch ex As Exception
			OptProv.Checked = False
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
		CmdRegresar.Enabled = Grd.Rows.Count > 0

	End Sub
	Private Sub Ponga_Favoritos_Mesas()
		Try
			If MontoMesas Then Exit Sub

			MontoMesas = True

			SiReloj()

			Abrir(DtMesas, "GetCotMesas " & Numero_Empresa.ToString)

			NoReloj()

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
			NoReloj()

		End Try

	End Sub
	Public Sub AdicioneSql(ByVal TextoSql As String)
		If Sql <> "" Then Sql = Sql & " And "
		Sql = Sql & TextoSql

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
			Bus = Bus.Replace("+", "&")
			Co = Bus.Split("&")
			If Co.Length = 1 Then
				Co = Bus.Split("+")
			End If

			For Each cn As String In Co
				If Mid(TxtCli.Text, 1, 2) = "//" Then 'es descrip item
					AdicioneSql("(ct.placa like ''%" & cn.Trim & "%'')")
				Else
					'AdicioneSql("(c.razon_social" & IIf(HaySigla, "+IsNull(c.url,'''')", "") & "+IsNull(t.nombre,'''')+IsNull(t.tel_1,'''')+IsNull(c.tel_1,'''')+IsNull(t.cedula,'''')+IsNull(c.nit,'''') like ''%" & cn.Trim & "%'')")
					'juan felipe pidió para droservicio adicionar la búsqueda por zona
					'AdicioneSql("(c.razon_social" & IIf(HaySigla, "+IsNull(c.url,'''')", "") & "+IsNull(t.nombre,'''')+IsNull(t.tel_1,'''')+IsNull(c.tel_1,'''')+IsNull(z.descripcion,'''')+IsNull(s.descripcion,'''')+IsNull(t.cedula,'''')+IsNull(c.nit,'''')+IsNull(c.codigo,'''') like ''%" & cn.Trim & "%'')")
					AdicioneSql("(c.razon_social+IsNull(c.url,'''')+IsNull(t.nombre,'''')+IsNull(t.tel_1,'''')+IsNull(c.tel_1,'''')+IsNull(z.descripcion,'''')+IsNull(s.descripcion,'''')+IsNull(t.cedula,'''')+IsNull(c.nit,'''')+IsNull(c.codigo,'''') like ''%" & cn.Trim & "%'')")
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
		Dim SqlIns As String = "exec GetCotClientesBasicoMasContactos9 " & Numero_Empresa.ToString & ",0,'" & Bus & "',0,0,0," & IIf(ChkDireccion.Checked, "1", "0") & "," & IdCon_Out.ToString & "," & IIf(OptProv.Checked, 1, 0) & "," & IIf(AceptaAnulados, "1", "0") & "," & IIf(ChkContactoPpal.Checked, "1", "0")

		'Mensaje("marca:" & MarcaExterna & ":" & DMScr(2) & SqlIns) '//jd

		Try
			Abrir(DtCli2, SqlIns)
		Catch ex As Exception
			NoReloj(Me)
			Mensaje_TopMost(Idi("No logró traer datos") & ": " & ex.Message & EsIngles(), , , True)
			Exit Sub
        End Try



        'Ventana(DtCli2, "") '//jd

        Cargando = True

        Try
            If CbOrden.SelectedIndex > 0 Then
                DtCli2 = Filtrar_DataTable(DtCli2, "", CbOrden.Text)
            End If
        Catch
        End Try

        Grd.DataSource = DtCli2
        'Apague("id")
        Apague("blo")
        'If HaySigla = False Then Apague("Sigla")
        If IdCon_Out > 0 Then Apague("contacto")
        If IdCon_Out > 0 Then Apague("tel_con")
        If ChkContactoPpal.Checked = False Then Apague("contacto_ppal")
        If ChkDireccion.Checked = False Then
            Apague("direccion")
            Apague("dir_con")
        End If
        Apague("id_cot_cliente_contacto")
        Apague("id_cot_zona_sub")
        Apague("id_cot_zona")
        Apague("id_usuario_vendedor")
        Apague("des_estado")
        Apague("id_cot_cliente_actividad")
        Apague("id_cot_cliente_perfil")
        Apague("id_tipo_tributario")
        Apague("precio_costo")


		Grd.Visible = True

		Traducir_Grid(Grd)


		For I As Integer = 0 To Grd.Rows.Count - 1
            If Tm(Grd, "blo", I) <> "" Then
                If ValD(Tm(Grd, "blo", I)) = 2 Then
                    Grd.Rows(I).DefaultCellStyle.ForeColor = Color.Red
                Else
                    Grd.Rows(I).DefaultCellStyle.ForeColor = Color.Green
                End If
            End If
        Next

        '/con grid dms

        'poner orden de columnas
        For I As Integer = 0 To Grd.ColumnCount - 1
            Try
                Dim Anch As Integer = GetSett(Me.Name, "dp" & Strings.Format(I, "000"), -1)
                If Anch >= 0 Then
                    Grd.Columns(I).DisplayIndex = Anch
                End If
                Anch = GetSett(Me.Name, "cl" & Grd.Columns(I).Name, -1)
                If Anch >= 0 Then
                    Grd.Columns(I).Width = Anch
                End If

            Catch ex As Exception

            End Try
        Next

        Cargando = False

        PicLogo.Visible = False

        'Mensaje("Filas:" & DtCli2.Rows.Count) '//jd


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
    Private Sub Apague(NombreCol As String)
        If Grd.Columns.Contains(NombreCol) Then
            Grd.Columns(NombreCol).Visible = False
        End If

    End Sub
    Private Sub CmdRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRegresar.Click
        If Grd.SelectedRows.Count = 0 And Grd.RowCount > 0 Then
            Grd.Rows(0).Selected = True
        End If

        If Grd.SelectedRows.Count = 0 Then
            'Mensaje("Seleccione algún cliente")
            Cancelar()
            Exit Sub
        End If

        'IdCli_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "id")
        'IdCon_Out = ValD("" & Gdf(DtCli2, Grd.SelectedRows(0).Index, "id_cot_cliente_contacto"))
        'Razon_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "razon_social")
        'Nombre_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "nombre_contacto")
        'Zona_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "id_cot_zona")
        'Zona_Sub_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "id_cot_zona_sub")
        'Actividad_Out = ValD(Gdf(DtCli2, Grd.SelectedRows(0).Index, "id_cot_cliente_actividad"))
        'Perfil_Out = ValD(Gdf(DtCli2, Grd.SelectedRows(0).Index, "id_cot_cliente_perfil"))
        'Nit_Out = ValD("" & Gdf(DtCli2, Grd.SelectedRows(0).Index, "nit"))

        IdCli_Out = Tm(Grd, "id")
        IdCon_Out = ValD(Tm(Grd, "id_cot_cliente_contacto"))
        Razon_Out = Tm(Grd, "empresa") & Chr(0) & Tm(Grd, "sigla")
        Nombre_Out = Tm(Grd, "contacto")
        Zona_Out = ValD(Tm(Grd, "id_cot_zona"))
        Zona_Sub_Out = ValD(Tm(Grd, "id_cot_zona_sub"))
        Actividad_Out = ValD(Tm(Grd, "id_cot_cliente_actividad"))
        Perfil_Out = ValD(Tm(Grd, "id_cot_cliente_perfil"))
        Tipo_Tributario_Out = ValD(Tm(Grd, "id_tipo_tributario"))
        Nit_Out = Tm(Grd, "nit")

        SaveSett(DiegoSet, "int.cli", "")

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

        Cargando = False

    End Sub

    Private Sub Cancelar()
        IdCli_Out = 0
        IdCon_Out = 0

        Me.Tag = 0

        SaveSett(DiegoSet, "int.cli", "")

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
        If Grd.SelectedRows.Count = 0 Then
            Mensaje("Seleccione algún cliente")
            Exit Sub
        End If

        SiReloj()

        AbrirPrograma("0150", Tm(Grd, "id"))

        NoReloj()

        'IdCli_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "id") * -1
        'IdCon_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "id_cot_cliente_contacto") * -1
        'Razon_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "razon_social")
        'Nombre_Out = Gdf(DtCli2, Grd.SelectedRows(0).Index, "nombre_contacto")

        'Me.Hide()

    End Sub

    Private Sub LnkPlaca_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkPlaca.LinkClicked
		Dim Placa As String = Inputbox2("Escriba parte de la descripción del item o de su código:" & DMScr(2) & "El sistema mostrará todos los clientes que tengan documentos cuyos items contengan este texto en su descripción o código (en Vehículos la Placa) o en el campo Placa de la Oportunidad. Igualmente mostrará clientes que tengan vehículos con dicho texto en descripción o placa").Trim
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
                If Grd.SelectedRows(0).Index < Grd.Rows.Count - 1 Then
                    Grd.Rows(Grd.SelectedRows(0).Index + 1).Selected = True
                End If
                e.SuppressKeyPress = True
            ElseIf e.KeyCode = Keys.Up Then
                If Grd.SelectedRows(0).Index > 0 Then
                    Grd.Rows(Grd.SelectedRows(0).Index - 1).Selected = True
                End If
                e.SuppressKeyPress = True
            ElseIf e.KeyCode = Keys.Return Then
                e.SuppressKeyPress = True
                If Grd.Rows.Count > 0 And TxtCli.Text = "" Then
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
        If Cargando Then Exit Sub

        SaveSett(Me.Name, "direcc", ChkDireccion.Checked)

        TxtCli.Focus()
        Try
            Grd.Columns("direccion").Visible = ChkDireccion.Checked
            Grd.Columns("dir_con").Visible = ChkDireccion.Checked

        Catch ex As Exception
            'If ChkDireccion.Checked Then
            '    ChkDireccion.Checked = False
            '    Exit Sub
            'End If
            Exit Sub
        End Try

        If ChkDireccion.Checked Then
            If Grd.Rows.Count > 0 Then
                TxtCli.Text = TxtCli.Tag
                CmdBuscar_Click(CmdBuscar, New EventArgs)
            End If
        End If

    End Sub

    Private Sub Grd_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PicLogo.Size = Grd.Size

    End Sub

    Private Sub CbDestinos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Cargando Then Exit Sub

        TxtCli.Text = TxtCli.Tag

        CmdBuscar_Click(Nothing, New EventArgs)

    End Sub

    Private Sub ChkContactoPpal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkContactoPpal.CheckedChanged
        If Cargando Then Exit Sub

        SaveSett(Me.Name, "contactoppal", ChkContactoPpal.Checked)

        TxtCli.Focus()

        Try
            Grd.Columns("contacto_ppal").Visible = ChkContactoPpal.Checked
            Grd.Columns("contacto_ppal").Visible = ChkContactoPpal.Checked

        Catch ex As Exception
            'If ChkContactoPpal.Checked Then
            '    ChkContactoPpal.Checked = False
            '    Exit Sub
            'End If
            Exit Sub
        End Try

        If ChkContactoPpal.Checked Then
            If Grd.Rows.Count > 0 Then
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



    Private Sub Grd_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Grd.CellDoubleClick
        CmdRegresar_Click(CmdRegresar, New EventArgs)

    End Sub



    Private Sub LnkCols_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkCols.LinkClicked
        'CCols.Cambiar_Columnas("1150", GrdRec)


        If Not Pregunte("Esta opción pone el ancho y posición de las columnas del grid con su valor predeterminado.  Desea hacerlo ahora?") Then
            Exit Sub
        End If

        Cargando = True

        For I As Integer = 0 To Grd.ColumnCount - 1
            Try
                DeleteSetting(DiegoSet, Me.Name, "orden")

                Dim Anch As Integer = GetSett(Me.Name, "cl" & Grd.Columns(I).Name, -1)
                If Anch >= 0 Then
                    DeleteSetting(DiegoSet, Me.Name, "cl" & Grd.Columns(I).Name)
                End If
                Dim Campito As String = GetSett(Me.Name, "dp" & Strings.Format(I, "000"), "")
                If Campito <> "" Then
                    DeleteSetting(DiegoSet, Me.Name, "dp" & Strings.Format(I, "000"))
                End If
            Catch ex As Exception

            End Try
        Next

        'Mensaje("Columnas han sido reestablecidas.  Salga del programa y vuelva a entrar para ver el resultado")
        DtCli2.Rows.Clear()
        Grd.DataSource = Nothing
        Me.Close()

    End Sub
    Private Sub Grd_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles Grd.SortCompare
        If IsNumeric(e.CellValue1.ToString()) Then
            e.SortResult = System.Decimal.Compare(ValD(e.CellValue1.ToString()), ValD(e.CellValue2.ToString()))
        Else
            e.SortResult = System.String.Compare(e.CellValue1.ToString(), e.CellValue2.ToString())
        End If
        e.Handled = True

    End Sub

    Private Sub Grd_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles Grd.ColumnWidthChanged
        If Cargando Then Exit Sub

        SaveSett(Me.Name, "cl" & e.Column.Name, e.Column.Width)

    End Sub
    Private Sub Grd_ColumnDisplayIndexChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles Grd.ColumnDisplayIndexChanged


        If Cargando Then Exit Sub

        For I As Integer = 0 To Grd.Columns.Count - 1
            SaveSett(Me.Name, "dp" & Strings.Format(I, "000"), Grd.Columns(I).DisplayIndex)
        Next
        'SaveSett(Me.Name, "dp1150" & e.Column.Name, e.Column.DisplayIndex)

    End Sub

    'Private Sub Grd_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grd.ColumnHeaderMouseClick
    '    Mensaje(Grd.Columns(e.ColumnIndex).Name)


    'End Sub

    Private Sub CbOrden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbOrden.SelectedIndexChanged
        If Cargando Then Exit Sub

        SaveSett(Me.Name, "orden", CbOrden.Text)

        TxtCli.Text = TxtCli.Tag

        CmdBuscar_Click(CmdBuscar, New EventArgs)

    End Sub

    Private Sub LnkOpciones_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkOpciones.LinkClicked
        PnlOpciones.Visible = PnlOpciones.Visible = False
    End Sub

    Private Sub fBuscarCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveSett(DiegoSet, "int.cli", "")

    End Sub
End Class