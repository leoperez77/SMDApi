' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
Public Class CamposAdicionales
    Public Event DMSTocoAlgo()

    Public TocoAlgo As Boolean = False
    Public IgnorarPermisos As Boolean = False

    Dim DtCamposVarios As DataTable
    Dim _Programa As String = ""
    Dim _Tabla As String = ""

    Dim TablaIDS(19) As Integer

    ''' <summary>
    ''' Programa donde está ubicado este control en este momento
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Poner número de programa</remarks>
    Property DMSPrograma() As String
        Get
            Return _Programa
        End Get
        Set(ByVal value As String)
            _Programa = value
        End Set

    End Property
    ''' <summary>
    ''' Tabla donde van los datos: ite, cli, not, cot
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property DMSTabla() As String
        Get
            Return _Tabla
        End Get
        Set(ByVal value As String)
            _Tabla = value
        End Set

    End Property
    Private Sub CamposAdicionales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Numero_Empresa = 0 Then Exit Sub


        DMSCargar_Campos()

    End Sub
    Public Sub DMSCargar_Campos(Optional Obligar As Boolean = False)
        If Numero_Empresa = 0 Then Exit Sub
        If DMSPrograma = "" Then Exit Sub

        If DtCamposVarios IsNot Nothing And Obligar = False Then
            Exit Sub
        End If

        For I As Integer = 1 To 20
            Dim Lbl As Label = DirectCast(Controls.Find("LblTitulo" & I.ToString, True)(0), Label)
            Dim Txt As TextBox = DirectCast(Controls.Find("TxtCampo" & I.ToString, True)(0), TextBox)
            Dim Com As SMDPpal.ComboDMS = DirectCast(Controls.Find("ComboBox" & I.ToString, True)(0), SMDPpal.ComboDMS)
            Lbl.Visible = False
            Txt.Visible = False
            Com.Visible = False
        Next

        'nuevo
        Me.Enabled = Not NoPuede4(Strings.Left(DMSPrograma, 5).Trim, 1500, , False) Or IgnorarPermisos

        DtCamposVarios = New DataTable
        Dim DtCombos As New DataTable
        Dim Ds As New DataSet

        'Abrir(DtCamposVarios, "Select nro,id,titulo,tipo_dato,longitud,requerido from cot_item_cam_def where id_emp=" & Numero_Empresa.ToString & " and programa='" & DMSPrograma & "' Order by nro")
        Abrir(Ds, "Exec GetCotItemCamDef " & Numero_Empresa.ToString & ",'" & DMSPrograma & "'")
        DtCamposVarios = Ds.Tables(0)
        DtCombos = Ds.Tables(1)

        Dim SoloUnaFila As Boolean = Filtrar_DataTable(DtCamposVarios, "nro>10").Rows.Count = 0

        Dim Ini As Integer = 8
        Dim Ini2 As Integer = 8
        For Each Campo As DataRow In DtCamposVarios.Rows
            If IsDBNull(Campo.Item("anulado")) = False Then
                Continue For
            End If

            Dim Lbl As Label = DirectCast(Controls.Find("LblTitulo" & Campo.Item("nro").ToString, True)(0), Label)
            Dim Txt As TextBox = DirectCast(Controls.Find("TxtCampo" & Campo.Item("nro").ToString, True)(0), TextBox)
            Dim Com As SMDPpal.ComboDMS = DirectCast(Controls.Find("ComboBox" & Campo.Item("nro").ToString, True)(0), SMDPpal.ComboDMS)
            Lbl.Text = Campo.Item("titulo") & IIf(IsDBNull(Campo.Item("requerido")), "", " *")
            Lbl.Tag = Campo.Item("id")
            Lbl.Visible = True
            Txt.Visible = True

            Txt.Tag = Campo.Item("tipo_dato")

            If Campo.Item("nro") > 10 Then
                Ini = Ini2
            End If
            Lbl.Top = Ini
            Txt.Top = Ini

            Txt.TextAlign = HorizontalAlignment.Left
            Txt.Height = 20
            Txt.Width = 234

            If Campo.Item("tipo_dato") = 2 Then
                Txt.MaxLength = ValD(Campo.Item("longitud"))
                If ValD(Campo.Item("longitud")) > 60 Then 'hacerlo más grande
                    Txt.Multiline = True
                    Txt.Height *= 3
                    Txt.ScrollBars = ScrollBars.Vertical
                    If SoloUnaFila Then
                        Txt.Width *= 2
                    End If
                End If
            ElseIf Campo.Item("tipo_dato") = 4 Then 'si o no
                Txt.MaxLength = 1
                Txt.Width = 35
                Txt.TextAlign = HorizontalAlignment.Center
            ElseIf Campo.Item("tipo_dato") = 7 Then 'combo
                Com.Location = Txt.Location
                Com.Width = Txt.Width
                Txt.Visible = False
                Com.Visible = True
                Com.Tag = "S"
                Dim IniID As Integer = Com.DMSTraerId
                Com.DMSLlene_Combo(DtCombos, "id", "descripcion", "nro=" & Campo.Item("nro").ToString, "descripcion", "(N/A)", IniID, True, True)
            Else
                Txt.MaxLength = 30
                Txt.Width /= 1.5
                Txt.TextAlign = HorizontalAlignment.Center
            End If

            'If Campo.Item("tipo_dato") = 3 Then 'fecha
            '    Dim TxtFec As New DateTimePicker
            '    TxtFec.Location = Txt.Location
            '    TxtFec.Name = "TxtCampo" & Campo.Item("nro").ToString
            '    Me.Controls.Remove(Txt)
            '    Me.Controls.Add(TxtFec)
            'End If

            If Campo.Item("nro") > 10 Then
                Ini2 += Txt.Height + 7
            Else
                Ini += Txt.Height + 7
            End If
        Next


    End Sub

    Private Sub LnkAdministrar_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkAdministrar.LinkClicked
        If DMSPrograma = "" Then
            Mensaje("Error de DMS: Falta ingresar DMSPrograma")
            Exit Sub
        End If




        SiReloj()

        DMSCargar_Campos(True)

        SonarWAV("ok")

        NoReloj()

    End Sub
    Public Sub DMSLimpiar()

        For I As Integer = 1 To 20
            TablaIDS(I - 1) = 0
            Dim Txt As TextBox = DirectCast(Controls.Find("TxtCampo" & I.ToString, True)(0), TextBox)
            Dim Com As SMDPpal.ComboDMS = DirectCast(Controls.Find("ComboBox" & I.ToString, True)(0), SMDPpal.ComboDMS)
            Txt.Text = ""
            Com.DMSPongaIndex(0)
        Next

        TocoAlgo = False

        'nuevo
        Me.Enabled = Not NoPuede4(Strings.Left(DMSPrograma, 5).Trim, 1500, , False) Or IgnorarPermisos

    End Sub

    Public Sub DMSMostrarDatos(Dt As DataTable)
        DMSCargar_Campos()

        DMSLimpiar()

        For Each Campo As DataRow In Dt.Rows
            TablaIDS(Campo.Item("nro") - 1) = Campo.Item("id")

            Dim Txt As TextBox = DirectCast(Controls.Find("TxtCampo" & Campo.Item("nro").ToString, True)(0), TextBox)
            Dim Com As SMDPpal.ComboDMS = DirectCast(Controls.Find("ComboBox" & Campo.Item("nro").ToString, True)(0), SMDPpal.ComboDMS)

            If Not IsDBNull(Campo.Item("valor")) Then
                Txt.Text = ValD(Campo.Item("valor"))
            ElseIf Not IsDBNull(Campo.Item("fecha")) Then
                Txt.Text = Campo.Item("fecha")
            ElseIf Not IsDBNull(Campo.Item("id_cot_item_cam_combo")) Then
                Com.DMSPongaIndex(Campo.Item("id_cot_item_cam_combo"))
            Else
                Txt.Text = "" & Campo.Item("contenido")
            End If
            TxtCampo1_Validated(Txt, New EventArgs)
        Next

        Me.Enabled = Not NoPuede4(Strings.Left(DMSPrograma, 5).Trim, 1501, , False) Or IgnorarPermisos

        TocoAlgo = False

    End Sub
    Public Function DMSLeerDatosSQL(Id As Integer) As String
        Return DMScr() & "Exec GetCotItemCam '" & DMSTabla & "'," & Id.ToString & DMScr()


    End Function
    Public Function DMSValidarDatos(Optional Mostrar As Boolean = True) As Boolean
        DMSCargar_Campos()

        Dim Men As String = ""
        For I As Integer = 1 To 20
            Dim Lbl As Label = DirectCast(Controls.Find("LblTitulo" & I.ToString, True)(0), Label)

            If ValD(Lbl.Tag) = 0 Then
                Continue For
            End If


            Dim Dt As DataTable = Filtrar_DataTable(DtCamposVarios, "id=" & Lbl.Tag)
            If Fin(Dt) Then Continue For
            If IsDBNull(Gdf(Dt, "anulado")) = False Then
                Continue For
            End If

            Dim Com As SMDPpal.ComboDMS = DirectCast(Controls.Find("ComboBox" & I.ToString, True)(0), SMDPpal.ComboDMS)
            Dim Txt As TextBox = DirectCast(Controls.Find("TxtCampo" & I.ToString, True)(0), TextBox)

            'validar requerido
            If Strings.Right(Lbl.Text, 2) = " *" Then
                If Com.Tag = "S" Then 'está presente, en lugar del text box
                    If Com.DMSTraerId = 0 Then 'no ha seleccionado nada
						Men += Lbl.Text & " (" & Idi("Requerido") & ")" & DMScr()
					End If
				Else
					If Txt.Text = "" Then
						Men += Lbl.Text & DMScr()
					End If
				End If
			End If

			'validar numéricos
			If EstaEnLista(Gdf(Dt, "tipo_dato"), 1, 5, 6) And Txt.Text <> "" Then 'fecha
				If IsDBNull(Gdf(Dt, "acepta_negativo")) = True Then
					If ValD(Txt.Text) < 0 Then
						Men += Lbl.Text & " (" & Idi("No puede ser negativo") & ")" & DMScr()
					End If
				End If
				If Gdf(Dt, "tipo_dato") = 6 Then
					If Int(ValD(Txt.Text)) <> ValD(Txt.Text) Then
						Men += Lbl.Text & " (" & Idi("Debe ser entero") & ")" & DMScr()
					End If
				End If
			End If

			'validar fechas
			If Gdf(Dt, "tipo_dato") = 3 And Txt.Text <> "" Then 'fecha
				If Not IsDate(Txt.Text) Then
					Men += Lbl.Text & " --> " & Idi("No es una fecha válida") & " " & Txt.Text & DMScr()
					Continue For
				ElseIf IsDBNull(Gdf(Dt, "fecha_inferior")) = False Then
					If CDate(Txt.Text) < FechaSinHora(Gdf(Dt, "fecha_inferior")) Then
						Men += Lbl.Text & " --> " & Idi("No puede ser menor") & " " & FormatoFecha(Gdf(Dt, "fecha_inferior")) & DMScr()
					End If
				End If

				If IsDBNull(Gdf(Dt, "fecha_superior")) = False Then
					If CDate(Txt.Text) > FechaSinHora(Gdf(Dt, "fecha_superior")) Then
						Men += Lbl.Text & " --> " & Idi("No puede ser mayor") & " " & FormatoFecha(Gdf(Dt, "fecha_superior")) & DMScr()
					End If
				End If
				If IsDBNull(Gdf(Dt, "fecha_mayor_hoy")) = False Then
					If CDate(Txt.Text) > FechaSinHora(FechaHoyAsignada) Then
						Men += Lbl.Text & " --> " & Idi("No puede ser mayor a hoy") & ": " & FormatoFecha(FechaHoyAsignada) & DMScr()
					End If
				End If
				If IsDBNull(Gdf(Dt, "fecha_menor_hoy")) = False Then
					If CDate(Txt.Text) < FechaSinHora(FechaHoyAsignada) Then
						Men += Lbl.Text & " --> " & Idi("No puede ser menor a hoy") & ": " & FormatoFecha(FechaHoyAsignada) & DMScr()
					End If
				End If
			End If

			'validar número

		Next

		If Men <> "" Then
			If Mostrar Then
				Mensaje(Idi("Validación de datos") & ":" & DMScr(2) & Men)
			End If
            Return False
        Else
            Return True
        End If

    End Function
    Private Sub TxtCampo1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtCampo1.TextChanged, TxtCampo2.TextChanged, TxtCampo3.TextChanged, TxtCampo4.TextChanged, TxtCampo5.TextChanged, TxtCampo6.TextChanged, TxtCampo7.TextChanged, TxtCampo8.TextChanged, TxtCampo9.TextChanged, TxtCampo10.TextChanged, TxtCampo11.TextChanged, TxtCampo12.TextChanged, TxtCampo13.TextChanged, TxtCampo14.TextChanged, TxtCampo15.TextChanged, TxtCampo16.TextChanged, TxtCampo17.TextChanged, TxtCampo18.TextChanged, TxtCampo19.TextChanged, TxtCampo20.TextChanged
        TocoAlgo = True

        'forma nueva
        RaiseEvent DMSTocoAlgo()

    End Sub

    Private Sub TxtCampo1_Validated(sender As System.Object, e As System.EventArgs) Handles TxtCampo1.Validated, TxtCampo2.Validated, TxtCampo3.Validated, TxtCampo4.Validated, TxtCampo5.Validated, TxtCampo6.Validated, TxtCampo7.Validated, TxtCampo8.Validated, TxtCampo9.Validated, TxtCampo10.Validated, TxtCampo11.Validated, TxtCampo12.Validated, TxtCampo13.Validated, TxtCampo14.Validated, TxtCampo15.Validated, TxtCampo16.Validated, TxtCampo17.Validated, TxtCampo18.Validated, TxtCampo19.Validated, TxtCampo20.Validated

        sender.text = Trim(sender.text)
        If sender.text = "" Then Exit Sub

        Dim Msg As String = ""

        Select Case sender.tag
            Case 1 'money
                sender.text = FormatoMoneda(ValD(sender.text), False, True)
                Msg = "Valor Inválido"
            Case 3 'fecha sin hora
                sender.text = FormatoFecha(sender.text, False, False)
                Msg = "Fecha Inválida"
            Case 4
                sender.text = UCase(sender.text)
                If sender.text <> "S" And sender.text <> "N" Then
                    sender.text = ""
                End If
                Msg = "Entre S o N"
            Case 5, 6 'numéricos
                If ValD(sender.text) = 0 Then
                    sender.text = ""
                Else
                    sender.text = ValD(sender.text)
                End If
                Msg = "Número Inválido"

        End Select

        If sender.text = "" Then
            If Msg <> "" Then
                Mensaje(Msg)
            End If
            sender.focus()
        End If


    End Sub

    Public Function DMSHagaSQL_Actualizar(DatoID As String) As String

        Dim Sq As String = ""

        For I As Integer = 1 To 20
            Dim Lbl As Label = DirectCast(Controls.Find("LblTitulo" & I.ToString, True)(0), Label)
            If ValD(Lbl.Tag) > 0 Then 'si está usado
                Dim Com As SMDPpal.ComboDMS = DirectCast(Controls.Find("ComboBox" & I.ToString, True)(0), SMDPpal.ComboDMS)
                Dim Txt As TextBox = DirectCast(Controls.Find("TxtCampo" & I.ToString, True)(0), TextBox)
                Dim CamConte As String = ""
                Dim CamValor As String = "0"
                Dim CamFecha As String = ""
                Dim CamCombo As String = "0"
                Dim TexBus As String = ""
                If EstaEnLista(Txt.Tag, 1, 5, 6) Then
                    CamValor = ValDMS(ValD(Txt.Text))
                    TexBus = CamValor
                ElseIf EstaEnLista(Txt.Tag, 3) And Txt.Text <> "" Then
                    CamFecha = FmtFecSQL(Txt.Text)
                    TexBus = CamFecha
                ElseIf EstaEnLista(Txt.Tag, 7) Then
                    CamCombo = Com.DMSTraerId.ToString
                    TexBus = CamCombo
                Else
                    CamConte = Txt.Text
                    TexBus = CamConte
                End If

                If DatoID = "-1" Then 'viene de busitem
                    If CamConte <> "" Or CamValor <> "0" Or CamFecha <> "" Or CamCombo <> "0" Then
                        Sq &= "Exec GetBuscarVarios " & Numero_Empresa.ToString & "," & Usuario.ToString & "," & Lbl.Tag.ToString & ",'" & TexBus.Replace("'", "''") & "'" & IIf(Sq = "", ",1", "") & DMScr()
                    End If
                Else
                    Sq &= "Exec PutCotItemCam " & Numero_Empresa.ToString & "," & Usuario.ToString & ",'" & DMSTabla & "'," & TablaIDS(I - 1).ToString & "," & DatoID & "," & Lbl.Tag.ToString & "," & Txt.Tag.ToString & ",'" & CamConte.Replace("'", "''") & "'," & CamValor & ",'" & CamFecha & "'," & CamCombo & DMScr()
                End If

            End If
        Next

        If Sq <> "" Then
            If Falta_Licencia("1035", False) Then
                Mensaje("Atención: No tiene licencia para el producto 1035 de Advance, Campos Adicionales. No va a grabar dicha información")
                Return ""
            End If
        End If

        Return Sq


    End Function

    Private Sub ComboBox1_DMSSelectIndex(Sender As System.Object, Id As System.Int32) Handles ComboBox1.DMSSelectIndex, ComboBox2.DMSSelectIndex, ComboBox3.DMSSelectIndex, ComboBox4.DMSSelectIndex, ComboBox5.DMSSelectIndex, ComboBox6.DMSSelectIndex, ComboBox7.DMSSelectIndex, ComboBox8.DMSSelectIndex, ComboBox9.DMSSelectIndex, ComboBox10.DMSSelectIndex, ComboBox11.DMSSelectIndex, ComboBox12.DMSSelectIndex, ComboBox13.DMSSelectIndex, ComboBox14.DMSSelectIndex, ComboBox15.DMSSelectIndex, ComboBox16.DMSSelectIndex, ComboBox17.DMSSelectIndex, ComboBox18.DMSSelectIndex, ComboBox19.DMSSelectIndex, ComboBox20.DMSSelectIndex
        'forma antigua
        TocoAlgo = True


        'forma nueva
        RaiseEvent DMSTocoAlgo()


    End Sub
End Class
