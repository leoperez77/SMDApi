' Version: 695, 4-oct.-2018 12:56
' Version: 686, 30-ago.-2018 12:33
' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 676, 14-ago.-2018 22:29
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fUsuarioServicio
    Dim IdEmp As Integer = 0
    '-------
    Public Numero_Empresa As Integer
    Public Nodo As Integer
    Public Usuario As Integer
    Public IdCotizaInicial As String
    Public Sector_Empresa As Integer
    Public Nit_Empresa As String
    Dim g_emp_nom(50) As String
    Dim g_emp(50) As String
    Dim g_user(50) As String
    Dim Ds As New DataSet
    Dim DiegoSet2 As String
    Dim Marca2 As String = ""

    Private Sub fUsuarioServicio_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        CbEmp.Focus()

    End Sub

	Private Sub fUsuarioServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		ChkIngles.Visible = LenguajeAdvance = 1
		ChkIngles.Checked = LenguajeAdvance = 1

		If SoyHandHeld() Then
			SplitContainer1.Panel1Collapsed = True
			Me.FormBorderStyle = Forms.FormBorderStyle.FixedToolWindow
			Me.WindowState = FormWindowState.Maximized

		End If
		'Try
		'    Nodo = ValD(GetSett("Conecc", "nodo", 1))
		'Catch
		'    Nodo = 1
		'End Try
		'If Nodo > 4 Then 'buscar primeros datos en nodo 1
		'    SaveSett("Conecc", "nodo", "1")
		'End If

		AsignarImagenPrograma(PictureBox1, 8)

		'MarcaExterna = BuscarIpFija()

		CbEmp.BackColor = ColorSegunMarca()

		'para que use esta ip

		If MarcaExterna <> "col" And MarcaExterna <> "3" Then
			Marca2 = MarcaExterna
			If Marca2 = "local2" Then Marca2 = "otroloc"
		End If

		DiegoSet2 = Me.Name ' & IIf(Nodo = 1, "", Nodo.ToString)

		Dim UltEmp As String = GetSett(DiegoSet2, "ultem" & MarcaExterna, "")
		Try
			For I As Integer = 1 To 50
				Dim N As String
				If I = 1 Then N = "" Else N = (I - 1).ToString
				g_emp(I) = GetSett(DiegoSet2, "emp" & Marca2 & N, "")
				If g_emp(I) = "" Then Continue For 'llenar combo

				g_emp_nom(I) = GetSett(DiegoSet2, "emp_nom" & Marca2 & N, "")
				g_user(I) = GetSett(DiegoSet2, "user" & Marca2 & N, "")
				CbEmp.Items.Add(New DataDescription(g_emp(I), g_emp_nom(I) & " (" & g_user(I) & ")"))
			Next
			For I As Integer = 0 To CbEmp.Items.Count - 1
				If TraerId(CbEmp, I) = ValD(UltEmp) Then
					CbEmp.SelectedIndex = I
					Exit For
				End If
			Next
			If CbEmp.Items.Count > 0 And CbEmp.SelectedIndex < 0 Then
				CbEmp.SelectedIndex = 0
			End If

			If CbEmp.Items.Count = 0 Then
				TabControl1.SelectedTab = TabPage2
			End If

		Catch ex As Exception

		End Try
		Try


			IdEmp = GetSett(DiegoSet2, "emp" & Marca2, Numero_Empresa)

			CbEmp.Focus()

		Catch ex As Exception

		End Try


		Dim Ali As String = GetSett("Conecc", "alias", "")
		Me.Text = "(" & IIf(Ali <> "", Ali, MarcaExterna) & ") " & My.Application.Info.Title & ", Versión " & String_Version_Editada()

		'para que entre derecho
		If DesdeFuente Then
			If GetSetting("DMS S.A.", "fC", "fteder", "") = "S" Then
				SaveSett("ppal", "ultcual_aut", "1") 'activar siguiente pantalla
			End If
		End If


		If GetSett("ppal", "ultcual_aut", "0") = "1" Then
			CmdUltima_Click(CmdUltima, New EventArgs)
		End If


	End Sub

	Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        SoyServicio = 0 'para que no se vea como servicio user
        Me.Tag = ""
        Me.Close()

    End Sub

	Private Sub IniciarApl(Optional ByVal EsExterno As Boolean = False)
		If ChkIngles.Checked Then
			LenguajeAdvance = 1
		Else
			LenguajeAdvance = 0
		End If

		Try
			If LstEmpresa.SelectedIndex < 0 Then
				Mensaje("Haga click en empresa")
				LstEmpresa.Focus()
				Exit Sub
			End If

			TxtUser.Text = Replace(TxtUser.Text, "'", "")

			If TxtUser.Text.Trim = "" Then
				Mensaje("Entre usuario")
				TxtUser.Focus()
				Exit Sub
			End If

			'If LCase(TxtUser.Text.Trim) = "juandiego" Or LCase(TxtUser.Text.Trim) = "jdms" Then
			'    Mensaje("Usuario restringido")
			'    Exit Sub
			'End If

			'-----COMIENZA PROCESO--------
			IdEmp = TraerId(LstEmpresa)
			'DebugJD("Marcaexterna: " & MarcaExterna & ", idemp: " & IdEmp)
			'If IdEmp = 1 And Strings.Left(MarcaExterna, 5) <> "local" Then
			If IdEmp = 1 And (MarcaExterna = "col" Or MarcaExterna = "3") Then
				If ValD(GetSetting("DMS S.A.", "syscom", "wit5", 0)) <> 1 Then 'solo juan diego
					Mensaje("No puede hacer esto con DMS S.A.")
					Exit Sub
				End If
			End If

			'Dim Dr() As DataRow
			'Dr = Emp.Select("id=" & IdEmp.ToString)

			Dim DtDat As New DataTable


			Leer_Datos()

			'DebugJD("usuarios servicio: " & UsuarioOriginal.ToString & ", usuario: " & Usuario.ToString)



			If Ds.Tables(1).Rows.Count = 0 And Usuario > 0 And Strings.Left(MarcaExterna, 5) <> "local" Then
				Dim ancho_factor As String = GetSetting("DMS S.A.", "relojito", "ancho", "0")

				If UsuarioOriginal = 2 Or UsuarioOriginal = 128 Or UsuarioOriginal = 5340 Or (MarcaExterna = "drx" And SoyServicio) Or ancho_factor = "1" Then 'se incluye a leo pérez
					'Mensaje("Usted NO está autorizado para entrar como usuario de servicio a esta Empresa. Por ser JDMS se le permitirá")
				Else
					Mensaje(Idi("Usted", "You") & " (idusu=" & UsuarioOriginal.ToString & ") " & Idi("NO está autorizado para entrar como usuario de servicio a esta Empresa") & ": " & DMScr(2) & LstEmpresa.Text & " (id=" & IdEmp.ToString & ")")
					TxtUser.Focus()
					Exit Sub
				End If
			End If

			DtDat = Ds.Tables(0).Copy

			If Fin(DtDat) Then
				Mensaje("Usuario no existe en esta empresa")
				TxtUser.Focus()
				Exit Sub
			End If


			Dim Mens As String = ""
			If ValD(Gdf(DtDat, "anulado")) = 1 Then
				Mens += "Empresa bloqueada" & DMScr(2)
			End If
			If Gdf(DtDat, "vencido") IsNot System.DBNull.Value Then
				Mens += Idi("Licencia vencida desde") & " " & FormatoFecha(Gdf(DtDat, "vencido")) & DMScr(2)
			End If
			If Mens <> "" Then
				If Not Pregunte(Idi("Nota Informativa de") & " " & LstEmpresa.Text & ":" & DMScr(2) & Mens & DMScr(2) & Idi("Desea continuar?")) Then
					Exit Sub
				End If
			End If

			'para recordar usuario por empresa
			'SaveSett(DiegoSet2, "user" & IdEmp.ToString, TxtUser.Text)
			'para solo el ultimo

			If EsExterno Then
				Salvar_Todo(LstEmpresa.Text,
							IdEmp.ToString,
							TxtUser.Text)
			End If
			SaveSett(DiegoSet2, "ultem" & MarcaExterna, IdEmp.ToString)

			'para saber el EXE en qué empresa está abierto
			Dim Ali As String = GetSett("Conecc", "alias", "")
			SaveSett("ulttem", My.Application.Info.AssemblyName, IIf(Ali <> "", Ali, MarcaExterna) & " - " & LstEmpresa.Text)

			SiReloj(fBusIt)

			Entrar_Crm(Gdf(DtDat, "id_emp_servidor").ToString, "" & Gdf(DtDat, "nodo"), IdEmp, TxtUser.Text, Gdf(DtDat, "id_usuario"), Gdf(DtDat, "sector"), Gdf(DtDat, "nit"), Gdf(DtDat, "codigo_empresa").ToString)



		Catch ex As Exception
			Mensaje(ex.Message)

		End Try

	End Sub
	Private Sub Salvar_Todo(ByVal p_emp_nom, ByVal p_emp, ByVal p_user)
		g_emp_nom(0) = p_emp_nom
		g_emp(0) = p_emp
		g_user(0) = p_user

		'Try
		'    DeleteSetting(DiegoSet, Me.Name)
		'Catch
		'End Try

		For I As Integer = 1 To 50
			If I > 0 Then
				'If ValD(g_emp(0)) = ValD(g_emp(I)) Or g_emp(I) = "" Then Exit Sub
				If ValD(g_emp(0)) = ValD(g_emp(I)) Then Exit Sub
			End If
		Next

		For I As Integer = 0 To 50

			Dim N As String
			If I = 0 Then N = "" Else N = I.ToString

			SaveSett(DiegoSet2, "emp_nom" & Marca2 & N, g_emp_nom(I))
			SaveSett(DiegoSet2, "emp" & Marca2 & N, g_emp(I))
			SaveSett(DiegoSet2, "user" & Marca2 & N, g_user(I))
		Next

	End Sub
	Private Sub Entrar_Crm(ByVal IdServidor As Integer, ByVal IdNodo As String, ByVal IdEmp As Integer, ByVal User As String, ByVal IdUser As Integer, ByVal SectorEmp As Integer, ByVal nit As String, ByVal CodEmp As String)
		'If MarcaExterna <> "local" Then
		'    SaveSett("Conecc", "nodo", IdServidor)
		'    SaveSett("Conecc", "nodotex", IdNodo)
		'    'If ValD(IdServidor) <> 1 Then 'cambiar de nodo
		'    Ppal.EntroWS = False
		'    'Ppal.Prox.NodoSMD = IdServidor
		'    Ppal.Prox.TextoNodo = "" & IdNodo
		'    'Nodo = Ppal.Prox.NodoSMD
		'    'End If
		'End If

		'validar usuario en bd
		Try
			Dim DD As New DataTable
			Abrir(DD, "GetDatosNet5_Servicio '" & CodEmp & "','" & User & "'")

			Numero_Empresa = Gdf(DD, "id_emp")
			Usuario = Gdf(DD, "id_usu")

		Catch ex As Exception
			Numero_Empresa = IdEmp
			Usuario = IdUser
		End Try

		MiCodigo = User
		MiEmpresa = CodEmp
		MiEmpresaNombre = CodEmp
		IdCotizaInicial = TxtInicial.Text
		Nodo = IdServidor
		Sector_Empresa = SectorEmp
		Nit_Empresa = nit

		IgnorarPermisosUsuarioServicio = ChkIgnorarPermisos.Checked

		Me.Tag = "S"
		Me.Close()


	End Sub
	Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		If LstEmpresa.SelectedIndex < 0 Then
			Mensaje("Busque una Empresa primero")
			Exit Sub
		End If

		If ChkPru.Checked Then
			SQL = "*pru*" 'para usar el webservice con _pru
			EntroWS = False
		End If

		Try
			TxtUser.Text = LCase(Trim(Ventana("GetUsuariosCodigo", "Usuarios", True, "codigo_usuario", TraerId(LstEmpresa).ToString)))

		Catch ex As Exception
			Mensaje("No pude buscar usuarios: " & ex.Message & EsIngles())
		End Try


	End Sub

	Private Sub LstEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpresa.SelectedIndexChanged
		TxtUser.Text = "dms"

	End Sub

	Private Sub CmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBuscar.Click
		Try
			SiReloj()

			If ChkPru.Checked Then
				SQL = "*pru*" 'para usar el webservice con _pru
				EntroWS = False
			End If

			Dim Emp As New DataTable

			Abrir(Emp, "GetCotEmpresasLicenciadas2 '" & Replace(TxtEmp.Text.Trim, "'", "''") & "'")

			NoReloj()

			If Fin(Emp) Then
				Mensaje("No encontró nada con ese criterio")
				TxtEmp.Focus()
				TxtEmp.SelectAll()
				Exit Sub
			End If

			Llene_Combo5(LstEmpresa, Emp, "id", "nombre_empresa")

			PongaIndex(LstEmpresa, IdEmp)
			If LstEmpresa.SelectedIndex < 0 Then
				LstEmpresa.SelectedIndex = 0
			End If

			Reloj(False)

			LstEmpresa.Focus()
			'If LstEmpresa.Items.Count = 1 Then
			'    'solo es este, meterlo derecho
			'    OK_Click(OK, New EventArgs)
			'End If

		Catch ex As Exception
			NoReloj()

			Mensaje("Error: " & ex.Message & EsIngles())

		End Try

	End Sub



	Private Sub CmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalir.Click
		Pantalla_Splash(True)
		Me.Tag = "N"
		Me.Close()

	End Sub
	Private Sub Copiar_Empresa()
		Dim J As Integer = TraerId(CbEmp)
		For I As Integer = 1 To 50
			If J = ValD(g_emp(I)) Then
				J = -I
				Exit For
			End If
		Next
		If J > 0 Then
			Mensaje("no encontró empresa en memoria ram")
			Exit Sub
		End If

		J = VABS(J)

		LstEmpresa.Items.Clear()
		LstEmpresa.Items.Add(New DataDescription(g_emp(J), g_emp_nom(J)))
		LstEmpresa.SelectedIndex = 0
		TxtUser.Text = g_user(J)

	End Sub
	Private Sub CmdUltima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdUltima.Click
		'para recordar en el menu de nodo
		SaveSett("ppal", "ultcual_serv", "(" & MarcaExterna & ") " & LstEmpresa.Text & " (" & TxtUser.Text & ")")

		If ChkPru.Checked Then
			SQL = "*pru*" 'para usar el webservice con _pru
			EntroWS = False
		End If

		If TabControl1.SelectedTab Is TabPage2 Then
			IniciarApl(True)
		Else
			If CbEmp.SelectedIndex < 0 Then Exit Sub

			Copiar_Empresa()
			IniciarApl()

		End If

	End Sub

	Private Sub TxtEmp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEmp.GotFocus
		Me.AcceptButton = CmdBuscar

	End Sub



	Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
		LnkBorrar.Visible = TabControl1.SelectedTab IsNot TabPage2

		If TabControl1.SelectedTab Is TabPage2 Then
			TxtEmp.Focus()
		End If

	End Sub

	Private Sub CbEmp_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbEmp.DoubleClick

		CmdUltima_Click(CmdUltima, New EventArgs)

	End Sub

	Private Sub CbEmp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbEmp.SelectedIndexChanged
		If CbEmp.SelectedIndex < 0 Then Exit Sub

		Copiar_Empresa()

	End Sub


	Private Sub LnkMis_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkMis.LinkClicked
		Try
			Dim Dt As New DataTable
			Abrir_Nodo_1(Dt, "GetEmpresasUsuarioServicio " & IIf(UsuarioOriginal = 0, 2, UsuarioOriginal).ToString)
			Llene_Combo5(LstEmpresa, Dt, "id_emp", "nombre_empresa")

			TabControl1.SelectedTab = TabPage2

		Catch ex As Exception
			Mensaje("intente mas tarde: " & ex.Message & EsIngles())

		End Try

	End Sub

	Private Sub LnkBorrar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkBorrar.LinkClicked

		If CbEmp.SelectedIndex < 0 Then Exit Sub
		If Not Pregunte("Seguro de borrar esta empresa de su lista?", , , , 3) Then Exit Sub

		Try
			Dim Id As Integer = TraerId(CbEmp)
			'borrar de memoria
			For I As Integer = 1 To 50
				If Id = ValD(g_emp(I)) Then
					g_emp(I) = ""
					Exit For
				End If
			Next

			'borrar del regedit
			For I As Integer = 1 To 50
				Dim N As String
				If I = 1 Then N = "" Else N = (I - 1).ToString
				Dim Id2 As Integer = ValD(GetSett(DiegoSet2, "emp" & Marca2 & N, ""))
				If Id2 = 0 Then Continue For 'llenar combo
				If Id = Id2 Then
					DeleteSetting(DiegoSet, Me.Name, "emp" & Marca2 & N)
					Exit For
				End If
			Next

			CbEmp.Items.Remove(CbEmp.Items(CbEmp.SelectedIndex))

			'CbEmp.Items.Remove(CbEmp)
			'CbEmp.Refresh()


		Catch ex As Exception
			Mensaje("No logró borrar: " & ex.Message & EsIngles())

		End Try

    End Sub

    Private Sub LstEmpresa_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpresa.DoubleClick
        CmdUltima_Click(CmdUltima, New EventArgs)

        'IniciarApl()

    End Sub

    Private Sub TxtEmp_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEmp.Leave
        Me.AcceptButton = CmdUltima

    End Sub
    Private Sub Leer_Datos()
        Abrir(Ds, _
            "Exec GetCotEmpresasLicenciadasDatos " & IdEmp.ToString & ",'" & TxtUser.Text.Trim & "'" & DMScr())
        '"Exec GetUsuarioServicio " & IdEmp.ToString & "," & UsuarioOriginal.ToString)

        Dim Dt As New DataTable
        If Ds.Tables(0).Rows.Count > 0 And Strings.Left(MarcaExterna, 5) <> "local" Then
            Abrir_Nodo_1(Dt, "Exec GetUsuarioServicio 0," & UsuarioOriginal & ",'" & Ds.Tables(0).Rows(0).Item("codigo_empresa") & "'")
        End If
        Dt.TableName = "nodocol"
        Ds.Tables.Add(Dt)

    End Sub

    Private Sub fUsuarioServicio_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        NoReloj(fBusIt)

        Me.AcceptButton = CmdUltima

    End Sub

    Private Sub LnkUltima_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkUltima.LinkClicked
        If NomEquipo <> "VAIO-JD" And NomEquipo <> "WIN10-JD" Then
            Mensaje("Opción ULT es inválida (solo JD)")
            Exit Sub
        End If
        'recuperar último
        SaveSett("ppal", "ultcual_aut", "1") 'activar siguiente pantalla
        CmdUltima_Click(CmdUltima, New EventArgs)

    End Sub

    Private Sub TxtEmp_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtEmp.KeyDown
        If e.KeyCode = Keys.Return Then
            CmdBuscar_Click(CmdBuscar, New EventArgs)
        End If
    End Sub
End Class