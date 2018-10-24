' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
'♥ versión: 586, 6-oct.-2017 07:11
<System.ComponentModel.DefaultEvent("DMSAbrirEnPrograma")> _
Public Class Digitalizador
    Public Event DMSAbrirEnPrograma(Sw As Short, Id As Integer, ByVal IdId As Long, IdGru As Integer, IdGruSub As Integer, Tercero As String, Item As String, Tema As String)
    Public Event DMSTocoAlgo()

    Public NivelMaximo As Short = 0
    Public MaxiSize As String

    Public HizoAlgo As Boolean = False
    Public DebeActualizar As Boolean = False
    Public SalirRapido As Boolean = False

    Dim UltSQL As String = ""

    Dim DtGruSub As New DataTable
    Dim Toco = False
    Dim EstoyEnBusqueda As Boolean = False
    Dim DtResultGuardado As New DataTable
    Dim CualID As Integer
    Dim CualSW As Integer
    Dim CualSeq As Integer
    Dim IdSubGru As Integer
    Dim IdGru As Integer
    Dim IdTercero As Integer
    'Dim ProgramaNumero As String = "0110"
    Dim AcercaDe As String = ""
    Dim IdInicial2 As Integer
    Dim PrimeraFila As Integer = -1

    Dim PermAdicionar As Integer
    Dim PermModificar As Integer
    Dim PermEliminar As Integer


    Public Sub Datos_Iniciales()
        For I As Integer = 101 To 105
            If Not NoPuede4("0110", I, , False) Then
                NivelMaximo = I - 100
            End If
        Next

        MaxiSize = ValD(GetSett("ctrl", "max", "0")) * 2
        Dim Maxi2 As String = ValD(ReglaDeNegocio(100, "max", "0")) * 1024
        If ValD(Maxi2) > 0 Then
            If ValD(Maxi2) < ValD(MaxiSize) Then
                MaxiSize = ValD(Maxi2)
            End If
        End If

        If DtGruDig.Rows.Count = 0 Then
            Abrir(DtGruDig, "GetDigGrupos " & Numero_Empresa.ToString & "," & Usuario.ToString)
        End If



    End Sub
    ''' <summary>
    ''' Inicia el sistema de digitalización que presta sus servicios a cualquier programa de Advance
    ''' </summary>
    ''' <param name="Sw">Sw que desea usar.  Documentos de 1 a 100, Clientes 500, etc.</param>
    ''' <param name="Id">Id para trar los datos. Cero si es nuevo</param>
    ''' <param name="IdSubgrupo">Id del subgrupo</param>
    ''' <param name="DtResult">DataTable con resultados para programa 0110</param>
    ''' <param name="AcercaDeAyuda">A qué se refiere. e.g. Item, Tercero, Documento, etc.</param>
    ''' <param name="IdInicialMostrar">Cuando va a abrir una entidad como Tercero, Item. Documento, cual ID de digitalización arrancar seleccionado</param>
    ''' <param name="IdGrupo">Id del grupo</param>
    ''' <remarks></remarks>
    Public Sub MontarDigitalizados(Sw As Short, Id As Long, Optional IdSubgrupo As Integer = 0, Optional DtResult As DataTable = Nothing, Optional AcercaDeAyuda As String = "", Optional IdInicialMostrar As Integer = 0, Optional IdGrupo As Integer = 0, Optional IdTer As Integer = 0, Optional Seq As Integer = 0, Optional SoloRevision As Boolean = False)
        If CbClasificacion.Items.Count = 0 Then
            Llenar_Clasificacion(CbClasificacion, 0)

            Datos_Iniciales()
        End If

        DebeActualizar = False


        AcercaDe = AcercaDeAyuda
        IdInicial2 = IdInicialMostrar

        CualSW = Sw
        CualSeq = Seq
        CualID = Id
        IdSubGru = IdSubgrupo
        IdGru = IdGrupo
        IdTercero = IdTer


        Select Case Sw
            Case Is < 100 'todos los documentos como facturas hojas de negocio etc.
                PermAdicionar = 200
                PermModificar = 210
                PermEliminar = 220
            Case 500 'terceros
                PermAdicionar = 300
                PermModificar = 310
                PermEliminar = 320
            Case 520 'items
                PermAdicionar = 400
                PermModificar = 410
                PermEliminar = 420
            Case 540 'test
                PermAdicionar = 450
                PermModificar = 460
                PermEliminar = 470
            Case 550 'hojas de vida
                PermAdicionar = 600
                PermModificar = 610
                PermEliminar = 620
            Case 560 'importaciones
                PermAdicionar = 630
                PermModificar = 640
                PermEliminar = 650
            Case 5000 'gru
                PermAdicionar = 500
                PermModificar = 510
                PermEliminar = 520
        End Select

        Llenar_Categoria()

        'If CualSW <> 5000 Then 'si no es grupo subgrupo
        '    IdSubGru = 0
        '    IdGru = 0
        'End If


        If ValD(Sw) <> 0 Then
            If NoPuede4("0110") Then
                Me.Visible = False
                Exit Sub
            End If
            LnkAbrirPrograma.Visible = False
        Else
            LnkAbrirPrograma.Visible = True
        End If

        Cerrar_Panel()

        LnkNuevoArchivo.Visible = True
        LnkEditar.Visible = True
        EstoyEnBusqueda = False

        If SoloRevision Then
            LnkNuevoArchivo.Visible = False
            LnkEditar.Visible = False
        End If


        UltSQL = "exec GetDigitalizacion " & CualSW.ToString & "," & CualID.ToString & "," & IdSubGru.ToString & "," & Numero_Empresa.ToString & "," & IdTercero.ToString & "," & Usuario.ToString & "," & CualSeq.ToString

        Try
            If DtResult IsNot Nothing Then 'es una búsqueda
                DtResultGuardado = DtResult.Copy
                Poblar_Grid(DtResultGuardado, IdInicialMostrar)
                LnkNuevoArchivo.Visible = False
                EstoyEnBusqueda = True
                'LnkEditar.Visible = False
            ElseIf Id <> 0 Then
                Dim DtDatos As New DataTable
                Abrir(DtDatos, UltSQL)
                Poblar_Grid(DtDatos, IdInicialMostrar)
            Else
                GrdDigi.Grid.DataSource = Nothing
            End If

        Catch ex As Exception
			MostrarError(Me.Name, "MontarDigitalizados", ex.Message)

		End Try

		Toco = False

		'abrir automáticamente
		'If GrdDigi.Grid.Rows.Count = 0 Then
		'    Nuevo_Archivo()
		'ElseIf GrdDigi.Grid.Rows.Count = 1 Then
		'    If SoloRevision Then
		'        Abrir_Archivo()
		'        SalirRapido = True 'para que el llamador no se quede abierto
		'    End If
		'End If

		If GrdDigi.Grid.Rows.Count = 1 Then
			If SoloRevision Then
				Abrir_Archivo()
				SalirRapido = True 'para que el llamador no se quede abierto
			End If
		End If

	End Sub
	Public Sub Llenar_Clasificacion(CbClasificacion As ComboBox, Optional IdInicial As Integer = 0)
		CbClasificacion.Items.Add(New DataDescription("0", "0 - Normal"))
		CbClasificacion.Items.Add(New DataDescription("1", "1 - Restringido"))
		CbClasificacion.Items.Add(New DataDescription("2", "2 - Clasificado"))
		CbClasificacion.Items.Add(New DataDescription("3", "3 - Confidencial"))
		CbClasificacion.Items.Add(New DataDescription("4", "4 - Secreto"))
		CbClasificacion.Items.Add(New DataDescription("5", "5 - Ultrasecreto"))

		PongaIndex(CbClasificacion, IdInicial)


	End Sub
	Private Sub Campos_Opcionales()
		Cargar_Digitalizacion_Preg()

		Dim Dt As DataTable = Filtrar_DataTable(DtDigPreg, "id_digitalizacion_gru_sub=" & IdSubGru.ToString, "numero")

		'Dim Letra As String = ""
		'Dim Letra2 As String = ""
		'Dim Letra3 As String = ""
		'Select Case CualSW
		'    Case Is < 100 'documentos
		'        Letra = "d" & CualSW.ToString & "-" & IdSubGru.ToString
		'        Letra2 = "ds" & CualSW.ToString & "-" & IdSubGru.ToString
		'        Letra3 = "dr" & CualSW.ToString & "-" & IdSubGru.ToString
		'    Case 500 'terceros
		'        Letra = "t" & "-" & IdSubGru.ToString
		'        Letra2 = "ts" & "-" & IdSubGru.ToString
		'        Letra3 = "tr" & "-" & IdSubGru.ToString
		'    Case 520 'items
		'        Letra = "i" & "-" & IdSubGru.ToString
		'        Letra2 = "is" & "-" & IdSubGru.ToString
		'        Letra3 = "ir" & "-" & IdSubGru.ToString
		'    Case 5000
		'        Letra = "g" & IdGru.ToString
		'        Letra2 = "gs" & IdGru.ToString
		'        Letra3 = "gr" & IdGru.ToString
		'End Select

		For I As Integer = 1 To 10
			Dim Lbl As Label = DirectCast(Me.Controls.Find("LblCampo" & I.ToString, True)(0), Label)
			Dim Txt As TextBox = DirectCast(Me.Controls.Find("TxtCampo" & I.ToString, True)(0), TextBox)
			Dim Cb As ComboBox = DirectCast(Me.Controls.Find("CbSiNo" & I.ToString, True)(0), ComboBox)
			Lbl.Visible = False
			Txt.Visible = False
			Cb.Visible = False
		Next

		For I As Integer = 0 To Dt.Rows.Count - 1
			Dim Prg As Integer = Gdf(Dt, I, "numero")

			Dim Lbl As Label = DirectCast(Me.Controls.Find("LblCampo" & Prg.ToString, True)(0), Label)
			Dim Txt As TextBox = DirectCast(Me.Controls.Find("TxtCampo" & Prg.ToString, True)(0), TextBox)
			Dim Cb As ComboBox = DirectCast(Me.Controls.Find("CbSiNo" & Prg.ToString, True)(0), ComboBox)

			Lbl.Text = Gdf(Dt, I, "pregunta")
			Lbl.Visible = True
			Cb.Visible = ValD(Gdf(Dt, I, "usa_sino")) > 0
			Txt.Visible = ValD(Gdf(Dt, I, "usa_texto")) > 0


			Txt.Tag = IIf(ValD(Gdf(Dt, I, "usa_texto")) = 2, "1", "")

			Cb.Items.Clear()
			Cb.Items.Add("N/D")
			Cb.Items.Add("Si")
			Cb.Items.Add("No")
			Cb.Tag = IIf(ValD(Gdf(Dt, I, "usa_sino")), "1", "")

			Cb.SelectedIndex = 0
		Next

		If Not Fin(Dt) Then
			TabControl1.TabPages(1).Text = "Información Adicional"
		Else
			TabControl1.TabPages(1).Text = ""
		End If

	End Sub
	Private Sub Poblar_Grid(Dt As DataTable, Optional IdInicialMostrar As Integer = 0)
		GrdDigi.DMSLlene_Grid(Dt, "id", , New Object() {"sw", "id_digitalizacion_gru_sub", "id_digitalizacion_gru", "tamaño", "no_permi"}, MostrarEliminar:=False)
		If IdInicialMostrar <> 0 Then
			Dim cg As New CGrid
			cg.Seleccionar_Fila(GrdDigi.Grid, "id", IdInicialMostrar)
		End If

		If NoPuede4("0110", 10, , False) Then
			For I As Integer = 0 To Dt.Rows.Count - 1
				If Gdf(Dt, I, "no_permi") IsNot System.DBNull.Value Then 'no tiene permiso
					GrdDigi.Grid.Rows(I).DefaultCellStyle.ForeColor = Color.Orange
				End If
			Next
		End If



	End Sub
	Private Sub LnkNuevoArchivo_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkNuevoArchivo.LinkClicked
		Nuevo_Archivo()

	End Sub


	Private Sub Nuevo_Archivo()
		Campos_Opcionales()

		Limpiar()
		Apagar(True)

		LblTitulo.Text = "Nuevo"
		LnkBorrar.Enabled = False

		PrimeraFila = -1

		PnlEditar.Visible = True
		PnlEditar.BringToFront()


		Toco = False

		CmdBuscar_Click(CmdBuscar, New EventArgs)

		TxtDescripcion.Focus()


	End Sub
	Private Sub Apagar(Apagar As Boolean)
		LnkNuevoArchivo.Enabled = Not Apagar
		LnkEditar.Enabled = Not Apagar
		LnkAbrirArchivo.Enabled = Not Apagar
		GrdDigi.Enabled = Not Apagar

		If Apagar Then
			TabControl1.SelectedTab = TbBasica
		End If

	End Sub
	Private Sub Limpiar()
		LblRuta.Visible = False
		Label3.Visible = False
		LblTamaño.Text = ""
		LblTamaño.Tag = ""

		TxtArchivo.Text = ""
		LblRuta.Text = ""
		TxtDescripcion.Text = ""
		PnlEditar.Tag = ""

		'limpiar
		If TabControl1.TabPages.Contains(TbAdicional) Then
			For I As Integer = 1 To 10
				Dim Txt As TextBox = DirectCast(Me.Controls.Find("TxtCampo" & I.ToString, True)(0), TextBox)
				Dim Cb As ComboBox = DirectCast(Me.Controls.Find("CbSiNo" & I.ToString, True)(0), ComboBox)
				Txt.Text = ""
				If Cb.Items.Count > 0 Then
					Cb.SelectedIndex = 0
				End If
			Next
		End If

	End Sub

	Private Sub CmdBuscar_Click(sender As System.Object, e As System.EventArgs) Handles CmdBuscar.Click
		Static PrimeraVez As Boolean = True

		Dim OpenFileDialog1 As New OpenFileDialog
		Try
			If PrimeraVez Then
				OpenFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString
				PrimeraVez = False
			End If
		Catch ex As Exception
		End Try

		Dim result As DialogResult = OpenFileDialog1.ShowDialog()


		If (result <> DialogResult.OK) Then
			Exit Sub
		End If

		TxtArchivo.Text = ArchivoSinPath(OpenFileDialog1.FileName)
		LblRuta.Text = RutaDelArchivo(OpenFileDialog1.FileName)


		Habilitar_Ruta(LblRuta.Text & "\" & TxtArchivo.Text)


	End Sub
	Private Sub Habilitar_Ruta(Arch As String)
		LblTamaño.Tag = FileLen(Arch)
		LblTamaño.Text = Strings.Format(ValD(LblTamaño.Tag) / 1024, "0.00")


		LblRuta.Visible = True
		Label3.Visible = True

		TxtDescripcion.Focus()

		Toco = True

	End Sub
	Private Sub CmdActualizar_Click(sender As System.Object, e As System.EventArgs) Handles CmdActualizar.Click
		Dim UsarFTP As Boolean = ReglaDeNegocio(180, "usar_ftp", "0") = "1"
		If UsarFTP Then
			MaxiSize = ValD(ReglaDeNegocio(180, "max", 5120000))
		End If

		If TxtArchivo.Text = "" Then
			Mensaje("Entre nombre de archivo")
			Exit Sub
		End If
		If LblRuta.Text = "" And ValD(PnlEditar.Tag) = 0 Then
			Mensaje("Requiere ruta del archivo")
			Exit Sub
		End If

		If CbCategoria.SelectedIndex < 0 Then
			Mensaje("Seleccione categoría")
			Exit Sub
		End If

		'permiso para la categoria
		If NoPuede4("0110", 10, , False) Then
			If Obtenga_Dato(DtGruDig, "id_hijo=" & TraerId(CbCategoria).ToString, "no_permi") IsNot System.DBNull.Value Then
				Mensaje("No tiene permiso para ingresar en esta categoría")
				Exit Sub
			End If
		End If
		'If CualID = 0 and CualSW<> Then
		'    Mensaje("No pude digitalizar si no ha creado el registro padre.  Modifique la información por el programa " & ProgramaNumero & " e intente digitalizar de nuevo")
		'    Exit Sub
		'End If

		'ya no se usa, solo se maneja la cuota
		'If Falta_Licencia("1100") Then
		'    Exit Sub
		'End If


		If NoPuede4("0110", 10, , False) Then
			If ValD(PnlEditar.Tag) > 0 Then 'editando
				If NoPuede4("0110", PermModificar) Then
					Exit Sub
				End If
			Else
				If NoPuede4("0110", PermAdicionar) Then
					Exit Sub
				End If
			End If
		End If

		IdSubGru = TraerId(CbCategoria)


		Dim TexErr As String = ""
		Dim Pestaña As Short = 0
		If ReglaDeNegocio(100, "desreq", "0") = "1" Then 'descripción requerida
			If TxtDescripcion.Text = "" Then
				TexErr &= "Falta Descripción" & DMScr()
			End If
		End If
		For I = 1 To 10
			Dim Lbl As Label = DirectCast(Me.Controls.Find("LblCampo" & I.ToString, True)(0), Label)
			Dim Txt As TextBox = DirectCast(Me.Controls.Find("TxtCampo" & I.ToString, True)(0), TextBox)
			Dim Cb As ComboBox = DirectCast(Me.Controls.Find("CbSiNo" & I.ToString, True)(0), ComboBox)
			If ValD(Cb.Tag) = 1 And Cb.SelectedIndex = 0 Then
				TexErr &= "Falta " & Lbl.Text & " (SiNo)" & DMScr()
				Pestaña = 1
			End If
			If ValD(Txt.Tag) = 1 And Txt.Text = "" Then
				TexErr &= "Falta " & Lbl.Text & DMScr()
				Pestaña = 1
			End If
		Next
		If TexErr <> "" Then
			If Pestaña = 1 Then
				TabControl1.SelectedTab = TbAdicional
			End If
			Mensaje(TexErr)
			Exit Sub
		End If

		If Not Toco Then GoTo Salir

		If LblRuta.Text <> "" Then

			Try
				If ValD(LblTamaño.Tag) > ValD(MaxiSize) Then
					'Mensaje("Este archivo tiene " & Tamaño.ToString & " bytes y no puede ser mayor a " & GetSett("ctrl", "max", "0") & " bytes")
					Mensaje(Idi("Este archivo tiene") & " " & LblTamaño.Text & "KB " & Idi("y no puede ser mayor a") & " " & ValD(MaxiSize) / 1024 & "KB")
					Exit Sub
				End If

				If Len(TxtArchivo.Text) > 100 Then
					Mensaje("Nombre de Archivo máximo de 100 caracteres")
					Exit Sub
				End If

			Catch ex As Exception
				'MostrarError("Digitalizador", "EnviarArchivo", ex.Message & EsIngles)
				Mensaje("No se pudo digitalizar archivo: " & ex.Message & EsIngles())
				Exit Sub
			End Try
		End If




		If Not Pregunte("Seguro de digitalizar este archivo?", , "Digitalizador") Then
			Exit Sub
		End If

		SiReloj()

		HizoAlgo = True

		Dim NumeroID As Integer = 0

		Try
			Dim Ds As New DataSet
			Dim Sq As String = ""
			Dim IdDig As Integer = ValD(PnlEditar.Tag)
			Dim IdAnt As Integer = IdDig
			If IdDig > 0 And LblRuta.Text <> "" Then 'significa que está modificando la imagen, toes borrarla y volverla a crear
				Sq += "DelDigitalizacionImagen " & Numero_Empresa.ToString & "," & Usuario.ToString & "," & IdDig.ToString & "," & CualSW.ToString & "," & CualID.ToString & ",1," & IdSubGru.ToString & DMScr()
				IdDig = 0 'limpiarlo para q haga nuevo
			End If

			Sq += "Exec PutDigitalizacionDatos "
			Sq += IdDig.ToString
			Sq += "," & Numero_Empresa.ToString
			Sq += "," & Usuario.ToString
			Sq += "," & CualSW.ToString
			Sq += "," & CualID.ToString
			Sq += "," & ValD(LblTamaño.Tag).ToString
			Sq += ",'" & TxtArchivo.Text & "'"
			Sq += "," & IdSubGru.ToString
			Sq += "," & TraerId(CbClasificacion).ToString
			Sq += "," & CualSeq.ToString
			Sq += vbNewLine
			Sq += "declare @id int=" & IdDig.ToString & DMScr()
			If IdDig = 0 Then
				Sq += "select @id=max(id) from digitalizacion where sw=" & CualSW.ToString & " And id_emp=" & Numero_Empresa.ToString & DMScr()
			End If
			Sq += "declare @idid bigint=" & CualID.ToString & DMScr()
			If CualID = 0 Then
				Sq += "select @idid=max(id_id) from digitalizacion where sw=" & CualSW.ToString & " And id_emp=" & Numero_Empresa.ToString & DMScr()
			End If

			If TxtDescripcion.Text <> "" Then
				Sq += "exec PutDigitalizacionDet @id,0,0,'" & Replace(TxtDescripcion.Text, "'", "''") & "'" & DMScr()
			End If
			For I = 1 To 10
				Dim Txt As TextBox = DirectCast(Me.Controls.Find("TxtCampo" & I.ToString, True)(0), TextBox)
				Dim Cb As ComboBox = DirectCast(Me.Controls.Find("CbSiNo" & I.ToString, True)(0), ComboBox)
				Sq += "exec PutDigitalizacionDet @id," & I.ToString & "," & Cb.SelectedIndex.ToString & ",'" & Replace(Txt.Text, "'", "''") & "'" & DMScr()
			Next
			If EstoyEnBusqueda Or CualSW = 5000 Then
				Sq += "exec GetDigitalizacion " & CualSW.ToString & ",@idid," & IIf(CualSW = 5000, IdSubGru, 0).ToString & "," & Numero_Empresa.ToString & "," & IdTercero.ToString & "," & Usuario.ToString & "," & CualSeq.ToString & DMScr()
			Else
				Sq += UltSQL & DMScr()
			End If


			Abrir(Ds, Sq)
			If Fin(Ds.Tables(0)) Then
				Mensaje_TopMost("Error, no devolvió filas digitalización", , , True)
				Exit Sub
			End If

			If Ds.Tables(0).Columns.Contains("resultado") Then
				NoReloj()
				Mensaje(Ds.Tables(0).Rows(0).Item("resultado"))
				Exit Sub
			End If



			NumeroID = ValD("" & Gdf(Ds.Tables(0), "ultimo"))

			If UsarFTP Then
				Try
					If IdAnt > 0 And IdAnt <> NumeroID Then 'para borrar el viejo si es distinto
						CDigitalizacion.Subir_Archivo_Digital("", IdAnt.ToString, True)
					End If
					If LblRuta.Text <> "" Then
						CDigitalizacion.Subir_Archivo_Digital(LblRuta.Text & TxtArchivo.Text, NumeroID.ToString)
					End If

				Catch ex As Exception
					NoReloj()
					MostrarError("Digitalizador", "LnkNuevoArchivo_LinkClicked: Ftp", ex.Message)
					Exit Sub
				End Try
			End If


			Dim Dt As DataTable = Ds.Tables(1).Copy

			If ValD(PnlEditar.Tag) <> 0 And Not Fin(DtResultGuardado) Then

				'Dim Dt As DataTable = Filtrar_DataTable(DtResultGuardado, "id=" & ValD(PnlEditar.Tag).ToString) 'guardo actual
				Dim DtNue As DataTable = Filtrar_DataTable(Ds.Tables(1), "id=" & NumeroID.ToString) 'guardo nuevo
				If Not Fin(DtNue) Then
					Dim Dr As DataRow() = DtResultGuardado.Select("id=" & ValD(PnlEditar.Tag).ToString)
					If Dr.Length > 0 Then
						IdInicial2 = NumeroID
						Dr(0).Item("archivo") = DtNue.Rows(0).Item("archivo")
						Dr(0).Item("descripcion") = DtNue.Rows(0).Item("descripcion")
						Dr(0).Item("id") = DtNue.Rows(0).Item("id")
						Dr(0).Item("clasif") = DtNue.Rows(0).Item("clasif")
						Dr(0).Item("id_digitalizacion_gru_sub") = DtNue.Rows(0).Item("id_digitalizacion_gru_sub")
						If EstoyEnBusqueda Then
							Dt = DtResultGuardado.Copy
						End If
					End If
				End If
			End If

			Poblar_Grid(Dt)
			If PrimeraFila >= 0 Then
				Try
					Dim CG As New CGrid
					CG.Seleccionar_Fila(GrdDigi.Grid, "id", NumeroID.ToString)
					GrdDigi.Grid.FirstDisplayedScrollingRowIndex = PrimeraFila
				Catch
				End Try
			End If


			'For I As Integer = 0 To fAdm.GrdDigi.Grid.Rows.Count - 1
			'    If Tm(fAdm.GrdDigi.Grid, "id", I) = NumeroID Then
			'        fAdm.GrdDigi.Grid.Rows(I).Selected = True
			'        fAdm.GrdDigi.Grid.FirstDisplayedScrollingRowIndex = I
			'        Exit For
			'    End If
			'Next

		Catch ex As Exception
			NoReloj()
			MostrarError("Digitalizador", "LnkNuevoArchivo_LinkClicked: Put", ex.Message)
			Exit Sub
		End Try


		RaiseEvent DMSTocoAlgo()

		If LblRuta.Text = "" Then
			NoReloj()
			Cerrar_Panel()
			Exit Sub
		End If




		If Not UsarFTP Then
			Dim DirectorioActual As String = My.Computer.FileSystem.CurrentDirectory

			'pararse en el dir donde está el archivo
			My.Computer.FileSystem.CurrentDirectory = LblRuta.Text
			Try
				GrabarArchivoBD(TxtArchivo.Text, "digitalizacion", NumeroID)
			Catch ex As Exception
				NoReloj()
				If ex.Message.Contains("acceso al archivo") Then
					Mensaje("El archivo adjunto no quedó guardado posiblemente porque lo tiene abierto.  Cierre el archivo, borre este registro y vuelva a intentarlo.")
				Else
					Mensaje("El archivo adjunto no quedó guardado.  Borre este registro y vuelva a intentarlo." & DMScr(2) & "Mensaje de error:" & DMScr(2) & ex.Message & EsIngles())
				End If
				Cerrar_Panel()

				'MostrarError("Digitalizador", "LnkNuevoArchivo_LinkClicked: GrabarArchivoBD", ex.Message & EsIngles)
				Exit Sub
			End Try
			My.Computer.FileSystem.CurrentDirectory = DirectorioActual

		End If


		NoReloj()

Salir:
		Cerrar_Panel()




	End Sub
	Private Sub CmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles CmdCancel.Click
		Cerrar_Panel()

	End Sub
	Private Sub Cerrar_Panel()
		Apagar(False)
		PnlEditar.Visible = False

	End Sub

	Private Sub LnkEditar_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkEditar.LinkClicked
		If GrdDigi.Grid.Rows.Count = 0 Then
			Mensaje("No hay nada para modificar")
			Exit Sub
		End If

		If EsClasificado() Then
			Exit Sub
		End If

		CualSW = ValD(Tm(GrdDigi.Grid, "sw"))
		CualID = ValD(Tm(GrdDigi.Grid, "id_id"))
		IdSubGru = ValD(Tm(GrdDigi.Grid, "id_digitalizacion_gru_sub"))
		IdGru = ValD(Tm(GrdDigi.Grid, "id_digitalizacion_gru"))


		Llenar_Categoria()
		PongaIndex(CbCategoria, IdSubGru)

		Campos_Opcionales()

		Limpiar()
		Apagar(True)

		PrimeraFila = GrdDigi.Grid.FirstDisplayedScrollingRowIndex

		Try
			SiReloj()
			Dim Dt As New DataTable
			Abrir(Dt, "GetDigitalizacionDet " & ValD(Tm(GrdDigi.Grid, "id")).ToString)

			LblTitulo.Text = "Editando " & Tm(GrdDigi.Grid, "archivo")
			TxtArchivo.Text = Tm(GrdDigi.Grid, "archivo")
			LblTamaño.Text = Tm(GrdDigi.Grid, "tamaño kb")
			LblTamaño.Tag = Tm(GrdDigi.Grid, "tamaño")
			TxtDescripcion.Text = ""

			'llenar
			For I As Integer = 0 To Dt.Rows.Count - 1
				If Gdf(Dt, I, "numero") > 10 Then Exit Sub

				If I = 0 And Gdf(Dt, I, "numero") = 0 Then 'si trae descripcioón
					TxtDescripcion.Text = "" & Gdf(Dt, 0, "respuesta_texto")
					Continue For
				End If

				Dim Txt As TextBox = DirectCast(Me.Controls.Find("TxtCampo" & Gdf(Dt, I, "numero").ToString, True)(0), TextBox)
				Dim Cb As ComboBox = DirectCast(Me.Controls.Find("CbSiNo" & Gdf(Dt, I, "numero").ToString, True)(0), ComboBox)
				Txt.Text = "" & Gdf(Dt, I, "respuesta_texto")
				Try
					Cb.SelectedIndex = ValD(Gdf(Dt, I, "respuesta"))
				Catch
				End Try
			Next

			PongaIndex(CbClasificacion, ValD(Tm(GrdDigi.Grid, "clasif")))

			PnlEditar.Tag = ValD(Tm(GrdDigi.Grid, "id"))

			LnkBorrar.Enabled = True

			PnlEditar.Visible = True
			PnlEditar.BringToFront()


		Catch ex As Exception
			MostrarError(Me.Name, "LnkEditar_LinkClicked", ex.Message)

		End Try

		NoReloj()

		Toco = False

	End Sub
	Private Sub Llenar_Categoria()
		Dim Tex As String = ""
		If CualSW = 500 Then
			Tex = "Terceros"
		ElseIf CualSW = 520 Then 'items
			Tex = "Items"
		ElseIf CualSW = 540 Then 'Test de Software
			Tex = "Test"
		ElseIf CualSW = 550 Then 'hojas
			Tex = "Hojas"
		ElseIf CualSW = 560 Then 'importaciones
			Tex = "Import"
		ElseIf CualSW = 570 Then 'importaciones
			Tex = "Hoja/neg"
		ElseIf CualSW < 100 Then
			Tex = "Documentos"
		End If
		If Tex = "" Then
			Llene_Combo5(CbCategoria, DtGruDig, "id_hijo", "des_hijo", "id_padre=" & IdGru, , , IdSubGru)
		Else
			Llene_Combo5(CbCategoria, DtGruDig, "id_hijo", "des_hijo", "des_padre='" & Tex & "'", , , IdSubGru)
		End If
		If CbCategoria.Items.Count = 1 Then
			CbCategoria.SelectedIndex = 0
		End If

	End Sub
	Private Sub LnkAbrirArchivo_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkAbrirArchivo.LinkClicked
		Abrir_Archivo()


	End Sub
	Private Sub Abrir_Archivo()
		If GrdDigi.Grid.Rows.Count = 0 Then
			Mensaje("No hay nada para abrir")
			Exit Sub
		End If

		If EsClasificado() Then
			Exit Sub
		End If


		CDigitalizacion.Abrir_Archivo_Digital(Tm(GrdDigi.Grid, "id"), Tm(GrdDigi.Grid, "archivo"))

	End Sub
	Private Function EsClasificado() As Boolean
		If Not NoPuede4("0110", 10, , False) Then
			Return False
		End If

		'permiso de confidencialidad
		If ValD(Tm(GrdDigi.Grid, "clasif")) > 0 Then
			If NoPuede4("0110", ValD(Tm(GrdDigi.Grid, "clasif")) + 100, , , "Ver archivo " & Tm(GrdDigi.Grid, "archivo") & ", clasificacion " & Tm(GrdDigi.Grid, "clasif")) Then
				Return True
			End If
		End If

		If Tm(GrdDigi.Grid, "no_permi") = "1" Then
			Mensaje("Usuario no tiene permiso para ver documentos de esta categoría.")
			Return True
		End If

		Return False


	End Function
	'    Private Sub Abrir_Archivo_Digital()
	'        If GrdDigi.Grid.Rows.Count = 0 Then
	'            Mensaje("No hay nada para abrir")
	'            Exit Sub
	'        End If

	'        If Not Pregunte("Seguro abrir este archivo?", , "Digitalizador") Then
	'            Exit Sub
	'        End If

	'        Dim Ima As New DataTable

	'        SiReloj()

	'        'si ya está guardado, saltar
	'        Dim ArchivoGuardar As String = Path_Temp & "dg" & Tm(GrdDigi.Grid, "id").ToString & "_" & Tm(GrdDigi.Grid, "archivo")
	'        If IO.File.Exists(ArchivoGuardar) Then
	'            GoTo Virtualizado
	'        End If

	'        Try
	'            Abrir(Ima, "GetDigitalizacionImagen " & Tm(GrdDigi.Grid, "id").ToString)
	'            If Fin(Ima) Then
	'                Mensaje("Archivo No existe")
	'                Exit Sub
	'            End If
	'            If Gdf(Ima, "imagen") Is System.DBNull.Value Then
	'                NoReloj()
	'                Mensaje("Archivo está vacío. Vuelva a escanearlo")
	'                Exit Sub
	'            End If

	'        Catch ex As Exception
	'            MostrarError("Digitalizador", "LnkAbrirArchivo_LinkClicked: Abrir", ex.Message & EsIngles)
	'            NoReloj()
	'            Exit Sub
	'        End Try

	'        Try
	'            SalvarFoto(CType(Gdf(Ima, "imagen"), Byte()), ArchivoGuardar, "")

	'        Catch ex As Exception
	'            MostrarError("Digitalizador", "LnkAbrirArchivo_LinkClicked: Salvar", ex.Message & EsIngles)
	'            NoReloj()
	'            Exit Sub
	'        End Try

	'Virtualizado:
	'        AbrirArchivo(ArchivoGuardar)

	'        NoReloj()

	'    End Sub


	Private Sub GrdDigi_DMSTraerValor(Sender As System.Object, ValorColDevolver As System.Object) Handles GrdDigi.DMSTraerValor
		Abrir_Archivo()

	End Sub


	Private Sub Por_Chat(Usu As String, TexM As String)
		Try



			SiReloj()

			Mensajeria_DMS(ValD(Usu), TexM & DMScr(2) & "[dig=" & Tm(GrdDigi.Grid, "id").ToString & "]", Usuario)


		Catch ex As Exception
			MostrarError(Me.Name, "LnkEnviar_LinkClicked", ex.Message)

		End Try

		NoReloj()

	End Sub
	Private Sub Por_Mail(Texm As String)
		Dim Arch As String = CDigitalizacion.Abrir_Archivo_Digital(Tm(GrdDigi.Grid, "id"), Tm(GrdDigi.Grid, "archivo"), True)
		If Arch = "" Then Exit Sub

		Enviar_Mail("" & Obtenga_Dato(DtUsu, "id=" & Usuario, "nombre"),
			"",
			"",
			"",
			"(Advance Digitalización) " & Tm(GrdDigi.Grid, "archivo"),
			"Archivo enviado desde Advance v." & String_Version_Editada() & DMScr(2) & Texm & DMScr(2) &
			"Saludos," & DMScr(2) &
			"" & Obtenga_Dato(DtUsu, "id=" & Usuario, "nombre"),
			Arch,
             , , , Usuario)


	End Sub
	Private Sub LnkEnviar_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkEnviar.LinkClicked
		If GrdDigi.Grid.Rows.Count = 0 Then
			Mensaje("Haga click en el renglón que desea enviar")
			Exit Sub
		End If

		If EsClasificado() Then
			Exit Sub
		End If

		Dim Cual As String = InputBoxDMS("Enviar Archivo", "Seleccione opción", True, "1", New Object() {New Object() {"1", "Chat", "2", "eMail"}})
		If Cual = "" Then Exit Sub

		Dim Prg As String
		If EstoyEnBusqueda Then 'es búsqueda
			Prg = Tm(GrdDigi.Grid, "categoria") & ", " & Tm(GrdDigi.Grid, "tema") & ", " & Tm(GrdDigi.Grid, "tercero") & ", " & Tm(GrdDigi.Grid, "id_id").ToString
		Else
			Prg = AcercaDe
		End If
		Dim TexM As String = "*** Digitalización Documentos ***" & DMScr(2) & "Programa: " & Prg & DMScr() & "Archivo: " & Tm(GrdDigi.Grid, "archivo") & IIf("" & Tm(GrdDigi.Grid, "descripcion") <> "", vbNewLine & "Comentario: " & Tm(GrdDigi.Grid, "descripcion"), "")

		Try
			SiReloj()
			Cargar_Usuarios()
			NoReloj()

		Catch ex As Exception
			MostrarError(Me.Name, "LnkEnviar_LinkClicked", ex.Message)
			NoReloj()
			Exit Sub
		End Try

		If Cual = "1" Then

			Dim Usu As String = PidaUsuarios("Seleccione Usuario que desea enviarle el archivo.", "", "", "", 0, Filtrar_DataTable(DtUsu, "tipo=2 and id<>" & Usuario), , , True)
			If ValD(Usu) = 0 Then
				Mensaje("No seleccionó ningun usuario")
				Exit Sub
			End If
			If Not Pregunte("Seguro de enviar?" & DMScr(2) & TexM & DMScr() & "Destinatario: " & Obtenga_Dato(DtUsu, "id=" & Usu, "nombre") & "?", , Me.Name) Then
				Exit Sub
			End If
			Por_Chat(Usu, TexM)
		Else
			Por_Mail(TexM)
		End If



	End Sub

	Private Sub LnkAbrirPrograma_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkAbrirPrograma.LinkClicked
		If GrdDigi.Grid.Rows.Count = 0 Then
			Mensaje("Haga click en el renglón que desea abrir")
			Exit Sub
		End If

		LnkRegresar.Visible = True

		RaiseEvent DMSAbrirEnPrograma(CShort(ValD(Tm(GrdDigi.Grid, "sw"))), CShort(ValD(Tm(GrdDigi.Grid, "id"))), CLng(ValD(Tm(GrdDigi.Grid, "id_id"))), CInt(ValD(Tm(GrdDigi.Grid, "id_digitalizacion_gru"))), CInt(ValD(Tm(GrdDigi.Grid, "id_digitalizacion_gru_sub"))), Tm(GrdDigi.Grid, "tercero"), Tm(GrdDigi.Grid, "item"), Tm(GrdDigi.Grid, "tema"))

	End Sub

	Private Sub LnkRegresar_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkRegresar.LinkClicked
		LnkRegresar.Visible = False


		MontarDigitalizados(0, 0, , DtResultGuardado, , IdInicial2)


	End Sub

	Private Sub CbClasificacion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbClasificacion.SelectedIndexChanged
		If TraerId(CbClasificacion) > NivelMaximo Then
			Mensaje(Idi("Máximo nivel de clasificación que usted tiene es") & ": " & NivelMaximo.ToString)
			PongaIndex(CbClasificacion, NivelMaximo)
		Else
			Toco = True
		End If

	End Sub


	Private Sub LnkBorrar_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkBorrar.LinkClicked
		If NoPuede4("0110", 10, , False) Then
			If NoPuede4("0110", PermEliminar) Then
				Exit Sub
			End If
		End If

		If ValD(PnlEditar.Tag) = 0 Then
			Mensaje("No hay nada para eliminar")
			Exit Sub
		End If

		If Not Pregunte(Idi("Seguro de eliminar este archivo?") & DMScr(2) & Tm(GrdDigi.Grid, "archivo")) Then
			Exit Sub
		End If

		Dim Ima As New DataTable

		SiReloj()

		Try
			Abrir(Ima, "exec DelDigitalizacionImagen " & Numero_Empresa.ToString & "," & Usuario.ToString & "," & ValD(PnlEditar.Tag).ToString & "," & CualSW.ToString & "," & CualID.ToString & DMScr() &
				  UltSQL)

			'borrar archvivo del ftp
			Borrar_Archivo_Dig(ValD(PnlEditar.Tag))
			''para quitarlo de la búsqueda

			If Not Fin(DtResultGuardado) Then
				DtResultGuardado = Filtrar_DataTable(DtResultGuardado, "id<>" & ValD(PnlEditar.Tag).ToString)
				If EstoyEnBusqueda Then
					Ima = DtResultGuardado.Copy
				End If
			End If


			Poblar_Grid(Ima)


		Catch ex As Exception
			MostrarError("Digitalizador", "CmdEliminar_Click", ex.Message)
			NoReloj()
			Exit Sub
		End Try

		NoReloj()

		Cerrar_Panel()

		RaiseEvent DMSTocoAlgo()

	End Sub
	Private Sub Borrar_Archivo_Dig(IdFile)
		Try
			CDigitalizacion.Subir_Archivo_Digital("", IdFile.ToString, True)
			'Dim TxtUsuarioFTP As String = ReglaDeNegocio(180, "usuario", "")
			'Dim TxtClaveFTP As String = ReglaDeNegocio(180, "clave", "")
			'Dim RutaFTP As String = ReglaDeNegocio(180, "ruta", "")
			''My.Computer.Network.UploadFile(LblRuta.Text & TxtArchivo.Text, RutaFTP & "/" & NumeroID.ToString & TxtArchivo.Text, TxtUsuarioFTP, TxtClaveFTP, True, 50000, FileIO.UICancelOption.DoNothing)
			'My.Computer.Network.UploadFile("c:\smd_files\vacio.txt", RutaFTP & "/" & IdFile.ToString, TxtUsuarioFTP, TxtClaveFTP, False, 50000)

		Catch ex As Exception

		End Try

	End Sub
	Private Sub LnkAbrir2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkAbrir2.LinkClicked
		If IO.File.Exists(LblRuta.Text & "\" & TxtArchivo.Text) Then
			AbrirArchivo(LblRuta.Text & "\" & TxtArchivo.Text)
		Else
			If ValD(PnlEditar.Tag) > 0 Then
				Abrir_Archivo()
			Else
				Mensaje("Archivo No existe")
			End If
		End If

	End Sub



	Private Sub CbSiNo1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbSiNo1.SelectedIndexChanged, CbSiNo2.SelectedIndexChanged, CbSiNo3.SelectedIndexChanged, CbSiNo4.SelectedIndexChanged, CbSiNo5.SelectedIndexChanged, CbSiNo6.SelectedIndexChanged, CbSiNo7.SelectedIndexChanged, CbSiNo8.SelectedIndexChanged, CbSiNo9.SelectedIndexChanged, CbSiNo10.SelectedIndexChanged
		Toco = True

	End Sub

	Private Sub TxtCampo1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtCampo1.TextChanged, TxtCampo2.TextChanged, TxtCampo3.TextChanged, TxtCampo4.TextChanged, TxtCampo5.TextChanged, TxtCampo6.TextChanged, TxtCampo7.TextChanged, TxtCampo8.TextChanged, TxtCampo9.TextChanged, TxtCampo10.TextChanged, TxtDescripcion.TextChanged
		Toco = True

	End Sub



	Private Sub LnkConfig_LinkClicked_1(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkConfig.LinkClicked
		Dim fConfig As New fConfigDigitalizacion

		Try
			SiReloj()

			Dim DtLic As New DataTable
			Abrir(DtLic, "exec GetEmpresaPocosDatos " & Numero_Empresa.ToString)


			Dim T As String = ""
			T &= "Clasificación Máxima: " & NivelMaximo.ToString & DMScr()
			T &= "Máximo tamaño archivo: " & (MaxiSize / 1024).ToString & "KB" & DMScr()
			T &= "Cuota Digitalización: " & ValD(Gdf(DtLic, "cuota_dig")).ToString & "MB" & DMScr()
			T &= "Consumo Actual: " & ValD(Gdf(DtLic, "consumo")).ToString & "MB" & DMScr()
			T &= "Cantidad Archivos: " & ValD(Gdf(DtLic, "cant_archivos")).ToString & DMScr()
			T &= "Disponible: " & (ValD(Gdf(DtLic, "cuota_dig")) - ValD(Gdf(DtLic, "consumo"))).ToString & "MB"

			fConfig.LblDatos.Text = T

			NoReloj()

			fConfig.ShowDialog()

		Catch ex As Exception
			MostrarError(Me.Name, "LnkConfig_LinkClicked", ex.Message)

		End Try

		NoReloj()

	End Sub

	Private Sub CbCategoria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbCategoria.SelectedIndexChanged
		IdSubGru = TraerId(CbCategoria)

		Campos_Opcionales()

		Toco = True

	End Sub

	Private Sub Digitalizador_DragOver(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragOver
		If PnlEditar.Visible Then
			e.Effect = DragDropEffects.Copy
		End If

	End Sub

	Private Sub Digitalizador_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
		If PnlEditar.Visible Then
			If e.Data.GetDataPresent("FileName", False) Then
				Try
					Dim Tex As New TextBox
					Tex.Lines = CType(e.Data.GetData("FileName", False), String())
					Tex.Text = APIS.GetLongFileName(Tex.Text)
					TxtArchivo.Text = ArchivoSinPath(Tex.Text)
					LblRuta.Text = Replace(Tex.Text, TxtArchivo.Text, "")

					Habilitar_Ruta(Tex.Text)

					SonarWAV("phone")

				Catch ex As Exception
					Mensaje("No se logró enganchar el archivo")
				End Try
			End If
		End If

	End Sub

	Private Sub Digitalizador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_Idioma(Me, Me)

	End Sub
End Class
