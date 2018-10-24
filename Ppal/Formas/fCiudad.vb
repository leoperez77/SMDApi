' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 647, 24-abr.-2018 12:31
' Version: 641, 4-abr.-2018 12:52
' Version: 638, 20-mar.-2018 12:16
' Version: 637, 13-mar.-2018 12:42
' Version: 627, 20-feb.-2018 13:29
' Version: 610, 28-dic.-2017 13:49
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fCiudad
	Public IdCliente As Integer = 0
	Public IdCiudad As Integer = 0

	Public SoloCiudadBodega As Boolean = False
	Public ValorMinimo As Double
	Public Porcentaje As Double

	Dim IdCiudad_Out As Integer = 0

	Private Sub fCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_Idioma(Me, Me)

		If CbPais_Pais.Items.Count > 0 Then
			GoTo Saltar
		End If

		Try
			If Fin(DtPais) Then
				SiReloj()
				Abrir(DtPais, "Exec GetCotClientePais " & Numero_Empresa)
				NoReloj()
			End If

			Llene_Combo5(CbPais_Pais, DtPais2, "id", "descripcion", "id_cot_cliente_pais is null", , "(No Aplica)", 0)

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "fCiudad_Load", ex.Message)
			Me.Hide()

		End Try

Saltar:

		Try
			If IdCiudad = 0 Then
				SiReloj()
				Dim DtInfoCli As New DataTable
				Abrir(DtInfoCli, "select id_cot_cliente_pais from cot_cliente where id=" & IdCliente)
				IdCiudad = ValD(Gdf(DtInfoCli, "id_cot_cliente_pais"))
				NoReloj()
			End If

			Pantalla_Grande(False)

			Dim Depto As Integer = ValD(Obtenga_Dato(DtPais2, "id=" & IdCiudad, "id_cot_cliente_pais"))
			Dim Pais As Integer = ValD(Obtenga_Dato(DtPais2, "id=" & Depto, "id_cot_cliente_pais"))
			PongaIndex(CbPais_Pais, Pais)
			PongaIndex(CbPais_Depto, Depto)
			CbPais_Ciudad.DMSPongaIndex(IdCiudad)

			CbPais_Ciudad.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "fCiudad_Load-2", ex.Message)
			Me.Hide()

		End Try

		'jdms 610
		If SoloCiudadBodega And CbPais_Ciudad.DMSTraerId > 0 Then
			LblAyuda.Visible = True
			CbPais_Pais.Enabled = False
			CbPais_Depto.Enabled = False
		Else
			LblAyuda.Visible = False
		End If

	End Sub
	Private Function DtPais2() As DataTable
		Return Filtrar_DataTable(DtPais, "codigo not like '%.%'")

	End Function

	Private Sub CmdAceptar_Click(sender As Object, e As EventArgs) Handles CmdAceptar.Click
		If CbPais_Ciudad.DMSTraerId <= 0 Then
			Mensaje("Seleccione ciudad")
			CbPais_Ciudad.Focus()
			Exit Sub
		End If

		If Grd.Grid.DataSource IsNot Nothing Then
			If LblCuenta.Tag = "" Then
				Mensaje("Seleccione cuenta del grid")
				Exit Sub
			End If
		End If

		Me.Tag = IIf(IdCiudad_Out > 0, IdCiudad_Out, CbPais_Ciudad.DMSTraerId)

		Me.Hide()

	End Sub

	Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
		LblCuenta.Tag = ""
		Me.Tag = 0
		Me.Hide()

	End Sub

	Private Sub CbPais_Pais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbPais_Pais.SelectedIndexChanged
		CbPais_Depto.Items.Clear()
		CbPais_Ciudad.ComboBox1.DataSource = Nothing
		If TraerId(CbPais_Pais) = 0 Then Exit Sub

		Llene_Combo5(CbPais_Depto, DtPais2, "id", "descripcion", "id_cot_cliente_pais=" & TraerId(CbPais_Pais).ToString)

	End Sub

	Private Sub CbPais_Depto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbPais_Depto.SelectedIndexChanged
		IdCiudad_Out = 0

		CbPais_Ciudad.ComboBox1.DataSource = Nothing

		If TraerId(CbPais_Depto) = 0 Then Exit Sub

		'jdms 610
		If SoloCiudadBodega Then
			'ver cual es el código de la ciudad que viene
			Dim CodCiudad As String = Obtenga_Dato(DtPais2, "id_cot_cliente_pais=" & TraerId(CbPais_Depto) & " And id=" & IdCiudad, "codigo")

			CbPais_Ciudad.DMSLlene_Combo(DtPais2, "id", "descripcion", "id_cot_cliente_pais=" & TraerId(CbPais_Depto) & " and codigo = '" & CodCiudad & "' and id_con_cta is null")
		Else
			CbPais_Ciudad.DMSLlene_Combo(DtPais2, "id", "descripcion", "id_cot_cliente_pais=" & TraerId(CbPais_Depto) & " and id_con_cta is null")
		End If

	End Sub
	Private Sub Pantalla_Grande(EsGrande As Boolean)
		If EsGrande Then
			Me.Size = New Point(569, 418)
		Else
			Me.Size = New Point(403, 187)
		End If

		Grd.Grid.DataSource = Nothing

		ValorMinimo = 0
		Porcentaje = 0

	End Sub

	Private Sub CbPais_Ciudad_DMSSelectIndex(Sender As Object, Id As Integer) Handles CbPais_Ciudad.DMSSelectIndex
		LblCuenta.Text = "" 'jdms 637
		LblCuenta.Tag = "" 'jdms 637

		IdCiudad_Out = 0

		Dim CodCiudad As String = "" & Obtenga_Dato(DtPais, "id=" & Id, "codigo")
		If CodCiudad = "" Then Exit Sub
		Dim NomCiudad As String = "" & Obtenga_Dato(DtPais, "id=" & Id, "descripcion")

		'Dim Dt As DataTable = Filtrar_DataTable(DtPais, "id_cot_cliente_pais=" & TraerId(CbPais_Depto) & " and codigo like '" & CodCiudad & ".%'")
		Dim Dt As DataTable = Filtrar_DataTable(DtPais, "id_cot_cliente_pais=" & TraerId(CbPais_Depto) & " and codigo = '" & CodCiudad & "' and id_con_cta is not null", "descripcion")
		If Fin(Dt) Then
			Pantalla_Grande(False)
			Exit Sub
		End If

		Pantalla_Grande(True)

		'pasar a un nuevo datatable con menos datos
		'Dim DtN As New DataTable
		'DtN.Columns.Add("id")
		'DtN.Columns.Add("descripcion")
		'DtN.Columns.Add("cuenta")
		'DtN.Columns.Add("des_cuenta")
		'DtN.Columns.Add("porcentaje")
		'DtN.Columns.Add("valor_minimo")
		'For Each Fi As DataRow In Dt.Rows
		'	DtN.Rows.Add(Fi("id"), Fi("descripcion"), Fi("cuenta"), Fi("des_cuenta"), Fi("porcentaje"), Fi("valor_minimo"))
		'Next

		Grd.DMSLlene_Grid(Dt, "id", ColOcultas:=New Object() {"id", "id_cot_cliente_pais", "id_con_cta", "codigo"}) ', ColMoneda:=New Object() {"valor_minimo"})

		Grd.Grid.ClearSelection()


	End Sub


	Private Sub Grd_DMSCellClick2(Sender As Object, ValorColDevolver As Object, e As DataGridViewCellEventArgs) Handles Grd.DMSCellClick2
		'jdms 637: obtener la cuenta contable, si la hay
		Dim Dt2 As DataTable = Filtrar_DataTable(DtPais, "id=" & ValorColDevolver)
		Dim Fi As DataRow = Dt2.Rows(0)

		Dim Cta() As String = Fi("cuenta").ToString.Split(" ")

		LblCuenta.Tag = Cta(0).Trim

		IdCiudad_Out = ValD(ValorColDevolver)

		LblCuenta.Text = LblCuenta.Tag & " " & Fi("descripcion")

		ValorMinimo = ValD(Fi("valor_minimo"))
		Porcentaje = ValD(Fi("porcentaje"))

	End Sub

	Private Sub fCiudad_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
		Grd.Grid.ClearSelection()

	End Sub

	Private Sub Grd_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles Grd.DMSTraerValor
		CmdAceptar.PerformClick()

	End Sub
End Class