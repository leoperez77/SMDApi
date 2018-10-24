' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
' Version: 679, 16-ago.-2018 21:01
' Version: 679, 16-ago.-2018 20:01
' Version: 673, 3-ago.-2018 14:58
'♥ versión: 586, 6-oct.-2017 07:11
<System.ComponentModel.DefaultEvent("DMSAsignoCliente")> _
Public Class LblCliente

    Public Event DMSAsignoCliente(IdCliente As Integer,
                                  RazonSocial As String,
                                  IdContacto As Integer,
                                  Nombre As String,
                                  IdZona As Integer,
                                  IdZonaSub As Integer,
                                  Nit As String,
                                  IdActivdad As Integer,
                                  IdPerfil As Integer,
                                  IdTipoTributario As Integer
                                  )

    Public Event DMSAsignoContactoSolito(IdContacto As Integer, Nombre As String)
    Public Event DMSEnter()
    Public Event DMSValidated()
    'Public DtOtroProg As DataTable

    Dim _PideContacto As Boolean = True
    Dim _EsProveedor As Boolean = False
    Dim _VerNit As Boolean = False 'OJO: debe ser False
    Dim _Limpiar As Boolean = False
    Public Contac As Integer = 0
    Public Codigo As String = "" 'SGQ-673

    Public Property DMSLimpiar() As Boolean
        Get
            Return _Limpiar
        End Get
        Set(ByVal value As Boolean)
            _Limpiar = value
        End Set
    End Property

    Public Property DMSVerNit() As Boolean
        Get
            Return _VerNit
        End Get
        Set(ByVal value As Boolean)
            _VerNit = value
        End Set
    End Property
    Public Property DMSEsProveedor() As Boolean
        Get
            Return _EsProveedor
        End Get
        Set(ByVal value As Boolean)
            _EsProveedor = value
        End Set
    End Property

    Property DMSPideContacto() As Boolean
        Get
            Return _PideContacto
        End Get
        Set(ByVal value As Boolean)
            _PideContacto = value
        End Set
    End Property

    Dim _Titulo As String = "Tercero"
    Property DMSTituloTercero() As String
        Get
            Return _Titulo
        End Get
        Set(ByVal value As String)
            _Titulo = value
        End Set
    End Property
    Public Sub DMSPongaBuscar()
        DMSBuscar_Tercero()

    End Sub

    Public Sub DMSAsigneCliente(IdCli As Integer, RazonSocial As String, Optional IdCon As Integer = 0, Optional Nombre As String = "", Optional Nit As String = "")
        LblCli.Text = RazonSocial
        LblCli.Tag = IdCli
        Me.Tag = IdCli 'por si acaso
        LblContacto.Text = Nombre
        LblContacto.Tag = IdCon
        LblNit.Text = Nit
        LblSigla.Text = ""

        If IdCli = 0 Then Exit Sub

        If DMSVerNit And Nit = "" Then
            Try
                Dim Dt As New DataTable
                Abrir(Dt, "select nit,url from cot_cliente where id=" & IdCli.ToString)
                LblNit.Text = Gdf(Dt, "nit")
                LblSigla.Text = "" & Gdf(Dt, "url")
            Catch
            End Try
        End If
        If IdCon > 0 And Nombre = "" Then
            Try
                Dim Dt As New DataTable
                Abrir(Dt, "select nombre from cot_cliente_contacto where id=" & IdCon.ToString)
                LblContacto.Text = Gdf(Dt, "nombre")
            Catch
            End Try
        End If

    End Sub

    Public Sub DMSPongaClienteCreado_0150()
        If DMSTraerID() <> 0 Then
            Exit Sub
        End If

        If GetSett(DiegoSet, "int.cli", "") = "" Then
            Exit Sub
        End If

        Try
            Dim Raz = GetSett(DiegoSet, "int.cli", "")
            Dim Idc = GetSett(DiegoSet, "int.cli.id", 0)
            Dim Idcon = GetSett(DiegoSet, "int.cli.id2", 0)
            Dim NomCon = GetSett(DiegoSet, "int.cli.nomc", "")
            Dim Nit = GetSett(DiegoSet, "int.cli.nit", "")
            DMSAsigneCliente(Idc, Raz, Idcon, NomCon, Nit)

        Catch ex As Exception

        End Try


        SaveSett(DiegoSet, "int.cli", "")



    End Sub
    Public Sub DMSLimpieClienteContacto()
        LblCli.Text = ""

        Limpie_Resto()

        
    End Sub
    Private Sub Limpie_Resto()
        LblCli.Tag = ""
        LblSigla.Text = ""
        Me.Tag = "" 'por si acaso
        LblContacto.Text = ""
        LblContacto.Tag = ""
        LblNit.Text = ""
        LblNit.Tag = ""

    End Sub
    Public Function DMSTraerID() As Integer
        Return ValD(LblCli.Tag)

    End Function
    Public Function DMSTraerIDContacto() As Integer
        Return ValD(LblContacto.Tag)

    End Function
    Public Function DMSTraerTexto() As String
        Return LblCli.Text

    End Function
    Public Function DMSTraerNombreContacto() As String
        Return LblContacto.Text

    End Function
    Private Sub LblCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

		DMSponga_Quite_Contacto()

		LnkCliente.Text = DMSTituloTercero

		Recorrer_Controles_Idioma(Me, Me)

	End Sub
    Public Sub DMSponga_Quite_Contacto()
        If DMSPideContacto Or DMSVerNit Then
            Me.Height = 38
            If DMSPideContacto = False Then
                'Label1.Visible = False
                LblContacto.Visible = False
                LblBuscarCont.Visible = False
                LblNit.Visible = True
                'LblNit.Left = Me.Width - LblNit.Width - 2
                'LblNit.TextAlign = ContentAlignment.MiddleRight
            Else
                LblContacto.Visible = True
                LblBuscarCont.Visible = True
                LblNit.Visible = True
            End If
        Else
            Me.Height = 20
        End If

    End Sub
    Private Sub LblCli_Enter(sender As System.Object, e As System.EventArgs) Handles LblCli.Enter
        RaiseEvent DMSEnter()
        If Me.Enabled = False Then Exit Sub


        LblCli.BackColor = Color.Yellow
        'LblCli.SelectAll()

    End Sub

    Private Sub LblCli_TextChanged(sender As System.Object, e As System.EventArgs) Handles LblCli.TextChanged
        LnkUlt.Visible = LblCli.Text = ""

        Limpie_Resto()

    End Sub

    Public Sub LblCli_Validated(sender As System.Object, e As System.EventArgs) Handles LblCli.Validated
        LblCli.BackColor = Color.White
        If ValD(LblCli.Tag) > 0 Then GoTo Salir
        If LblCli.Text.Trim = "" And Contac = 0 Then GoTo Salir

        Dim Dt As New DataTable
        'Dim Where As String = ""
        If IsNumeric(LblCli.Text) Then
            If ValD(LblCli.Text) > 99999999999999 Then
                Mensaje("Número muy grande, máximo 14 dígitos")
                GoTo Salir
            End If
            'Where = " And c.nit='" & ValD(LblCli.Text) & "'"
        Else
            'Where = " And ((c.razon_social like '" & LblCli.Text.Replace("'", "''") & "%') or (c.nit = '" & LblCli.Text.Replace("'", "''") & "'))"
        End If


        SiReloj()
        Abrir(Dt, "Exec GetCotClientesBasicoMasContactos9Nuevo " & Numero_Empresa &
         "," & IIf(DMSPideContacto, 1, 0) &
         ",'" & LblCli.Text.Replace("'", "''") & "'," & Contac & "," & IIf(DMSEsProveedor, 1, 0)
         )
        NoReloj()

        'volver a inicializar para evitar problemas
        Contac = 0

        If Dt.Rows.Count = 0 Then
            'buscar por dentro
            Dim T As String = LblCli.Text
            LblCli.Text = ""
            If T <> "" Then 'truco feo
                Dim mt As String = "Tercero no existe: " & T & IIf(DMSEsProveedor, DMScr(2) & "Nota: Puede que no esté marcado como proveedor en el 0150", "")
                If ValD(T) = 0 Then
                    Mensaje(mt)
                Else
                    If Pregunte(mt & DMScr(2) & "Desea crearlo?") Then
                        AbrirPrograma("0150", ValD(T) * -1) 'para que sea nit
                    End If
                End If

            End If
            'LblCli.SelectAll()
            LblCli.Focus()
            GoTo Salir
        ElseIf Dt.Rows.Count > 1 Then
            'limpiar datos para no repetir cliente
            If DMSPideContacto Then
                Dim RazAnt As String = ""
                For Each Fi As DataRow In Dt.Rows
                    If RazAnt <> Fi("razon_social") Then
                        RazAnt = Fi("razon_social")
                    Else
                        Fi("razon_social") = ""
                        Fi("nit") = ""
                    End If
                Next
            End If
            Dim cu As String = Ventana(Dt, "Seleccione tercero", True, "fila", New Object() {"r2", "fila", "id", "id_cot_zona", "id_cot_zona_sub", "id_cot_cliente_actividad", "id_cot_cliente_perfil", "id_cot_cliente_tipo", "id_cot_cliente_contacto"})
            If cu = "" Then
                LblCli.Text = ""
                LblCli.Focus()
                GoTo Salir
            End If
            Dt = Filtrar_DataTable(Dt, "fila=" & ValD(cu).ToString)
        End If
        LblCli.Text = Gdf(Dt, "r2")
        LblCli.Tag = Gdf(Dt, "id")
        LblSigla.Visible = False
        If Gdf(Dt, "url") IsNot DBNull.Value Then
            LblSigla.Visible = True
            LblSigla.Text = Gdf(Dt, "url")
        End If

        Me.Tag = Gdf(Dt, "id")
        LblNit.Text = Gdf(Dt, "nit")
        If DMSPideContacto Then
            LblContacto.Text = "" & Gdf(Dt, "nombre")
            LblContacto.Tag = ValD(Gdf(Dt, "id_cot_cliente_contacto"))
        End If
        Codigo = Gdf(Dt, "codigo").ToString 'SGQ-673
        GuardarUlt(Gdf(Dt, "id"), ValD(LblContacto.Tag))

        RaiseEvent DMSAsignoCliente(ValD(Gdf(Dt, "id")), Gdf(Dt, "razon_social"), 0, "", ValD(Gdf(Dt, "id_cot_zona")), ValD(Gdf(Dt, "id_cot_zona_sub")), "" & Gdf(Dt, "nit"), ValD(Gdf(Dt, "id_cot_cliente_actividad")), ValD(Gdf(Dt, "id_cot_cliente_perfil")), ValD(Gdf(Dt, "id_tipo_tributario")))

Salir:
        RaiseEvent DMSValidated()

    End Sub
    Private Sub GuardarUlt(Cli, Conta)
        SaveSett(Me.Name, "ultcli" & Numero_Empresa.ToString & MarcaExterna, Cli)
        If Conta > 0 Then
            SaveSett(Me.Name, "ultcon" & Numero_Empresa.ToString & MarcaExterna, Conta)
        End If

    End Sub
    Private Sub LblCli_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles LblCli.KeyDown
        If e.KeyCode = Keys.F1 Then
            e.SuppressKeyPress = True
            DMSBuscar_Tercero()
        End If
    End Sub

    Public Sub DMSBuscar_Tercero()

        Try
            Dim IdCliente As Integer = IIf(DMSLimpiar, -1, 0)
            Dim RazonSocial As String = ""
            Dim IdContacto As Integer = IIf(DMSPideContacto, -1, 0)
            Dim Nombre As String = ""
            Dim Nit As String = ""
            Dim IdTipoTributario As Integer = 0
            Dim IdZonaSub As Integer = 0
            Dim IdZona As Integer = 0
            Dim IdActivdad As Integer = 0
            Dim IdPerfil As Integer = 0
            Dim IdUsuario As Integer = 0

            Haga_Buscar_Cliente(IdCliente, RazonSocial, IdContacto, Nombre, IdZona, IdZonaSub, Nit, IdActivdad, IdPerfil, , IIf(DMSEsProveedor, 1, 0), , IdTipoTributario)
            If IdCliente = 0 Then Exit Sub
            Try
                Dim raz() As String = RazonSocial.Split(Chr(0))
                LblCli.Text = raz(0)
                LblSigla.Text = raz(1)
            Catch
                LblCli.Text = RazonSocial
                LblSigla.Text = ""
            End Try
            LblCli.Tag = IdCliente
            LblContacto.Text = Nombre
            LblContacto.Tag = IdContacto
            LblNit.Text = Nit

            Me.Tag = IdCliente

            GuardarUlt(IdCliente, IdContacto)

            RaiseEvent DMSAsignoCliente(IdCliente,
                                        RazonSocial,
                                        IdContacto,
                                        Nombre,
                                        IdZona,
                                        IdZonaSub,
                                        Nit,
                                        IdActivdad,
                                        IdPerfil,
                                        IdTipoTributario)

        Catch ex As Exception
            NoReloj()
            If ex.Message.Contains("modal") Then
                Mensaje("Ya tiene la pantalla de búsqueda abierta")
            Else
				MostrarError(Me.Name, "Buscar_Tercero", ex.Message)
			End If

		End Try

	End Sub

	Private Sub LblBuscar_Click(sender As System.Object, e As System.EventArgs) Handles LblBuscar.Click, LnkCliente.Click
		RaiseEvent DMSEnter()
		If Me.Enabled = False Then Exit Sub

		DMSBuscar_Tercero()

	End Sub

	Private Sub LblBuscarCont_Click(sender As System.Object, e As System.EventArgs) Handles LblBuscarCont.Click
		RaiseEvent DMSEnter()
		If Me.Enabled = False Then Exit Sub

		Try
			If ValD(LblCli.Tag) = 0 Then
				DMSBuscar_Tercero()
			Else
				SiReloj()
				Dim Dt As New DataTable
				Abrir(Dt, "GetCotClienteContactosVentana " & ValD(LblCli.Tag))

				NoReloj()

				If Fin(Dt) Then
					Mensaje("No hay contactos")
					Exit Sub
				End If

				Dim cu As String = Ventana(Dt, "Seleccione contacto", True, "id", New Object() {"id"})
				If cu = "" Then
					If Pregunte("Desea limpiar el contacto?") Then
						LblContacto.Text = ""
						LblContacto.Tag = 0
					End If
					Exit Sub
				End If
				Dt = Filtrar_DataTable(Dt, "id=" & ValD(cu))
				LblContacto.Text = Gdf(Dt, "nombre")
				LblContacto.Tag = Gdf(Dt, "id")
				GuardarUltCon(Gdf(Dt, "id"))


				RaiseEvent DMSAsignoContactoSolito(Gdf(Dt, "id"), Gdf(Dt, "nombre"))
			End If

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "", ex.Message)

		End Try
    End Sub

    
    Private Sub LnkUlt_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkUlt.LinkClicked
        Dim Cli = GetSett(Me.Name, "ultcli" & Numero_Empresa.ToString & MarcaExterna, "")
        Contac = ValD(GetSett(Me.Name, "ultcon" & Numero_Empresa.ToString & MarcaExterna, 0))

        If Cli <> "" Then
            LblCli.Text = ValD(Cli) * -1
            LblCli_Validated(LblCli, New EventArgs)
        End If

        Contac = 0

    End Sub
    Private Sub GuardarUltCon(Cont)
        SaveSett(Me.Name, "ultcon" & Numero_Empresa.ToString & MarcaExterna, Cont)

    End Sub

    Private Sub LblSigla_Click(sender As Object, e As EventArgs) Handles LblSigla.Click
        LblSigla.Visible = False

    End Sub

   
End Class
