' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
<System.ComponentModel.DefaultEvent("DMSSelectIndex")>
Public Class ListBoxDMS
	Public Event DMSSelectIndex(ByVal Sender As Object, ByVal Id As Integer)
	Public Event DMSDoubleClick(ByVal Sender As Object, ByVal Id As Integer)
	Dim DtOriginal As New DataTable

	Public Function DMSPongaIndex(ByVal IdInicial As Integer) As Integer
		ListBox1.SelectedValue = IdInicial
	End Function
	Public Function DMSTraerTexto() As String
		Return "" & ListBox1.Text

	End Function
	Public Function DMSTraerId() As Integer
		Return ValD("" & ListBox1.SelectedValue)
	End Function
	Public Function DMSSelectedIndex() As Integer
		Return ListBox1.SelectedIndex

	End Function
	Public Sub DMSLlene_Lst(ByVal Dt As DataTable,
						   ByVal CampoId As String,
						   ByVal CampoMostrar As String,
						   Optional ByVal ClausulaWhere As String = "",
						   Optional ByVal CampoOrdenamiento As String = "",
						   Optional ByVal TextoIdCero As String = "",
						   Optional ByVal IdInicial As Integer = -1)

		RemoveHandler ListBox1.SelectedValueChanged, AddressOf ListBox1_SelectedValueChanged

		Dt = Filtrar_DataTable(Dt, ClausulaWhere, CampoOrdenamiento)

		If TextoIdCero <> "" Then
			Dim Row As DataRow = Dt.NewRow()
			With Row
				Row.Item(CampoMostrar) = TextoIdCero
				Row.Item(CampoId) = 0
			End With

			Dt.Rows.InsertAt(Row, 0)
		End If
		DtOriginal = Dt
		ListBox1.DataSource = Dt
		ListBox1.DisplayMember = CampoMostrar
		ListBox1.ValueMember = CampoId


		If IdInicial <> -1 Then
			ListBox1.SelectedValue = IdInicial
		Else
			ListBox1.SelectedIndex = -1
		End If

		AddHandler ListBox1.SelectedValueChanged, AddressOf ListBox1_SelectedValueChanged
	End Sub
	Public Sub DMSLimpiarSeleccion()
		ListBox1.ClearSelected()
	End Sub

	Private Sub ListBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
		If ListBox1.DataSource.rows.count = 0 Then Exit Sub
		RaiseEvent DMSSelectIndex(Me, DMSTraerId())
	End Sub


	Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click

		Dim Index As Integer = Buscar(ListBox1.DataSource, ListBox1.DisplayMember, ListBox1.ValueMember)
		If Index <= 0 Then Exit Sub
		ListBox1.SelectedValue = Index
		ListBox1.Focus()
	End Sub

	Private Sub ContarLineasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContarLineasToolStripMenuItem.Click
		Mensaje(ContarLineasDt(ListBox1.DataSource))
	End Sub

	Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
		RaiseEvent DMSDoubleClick(Me, DMSTraerId)

	End Sub

	Private Sub ListBoxDMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_ContextMenuStrip(ContextMenuStrip1)

	End Sub
End Class
