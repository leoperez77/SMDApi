' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 619, 5-feb.-2018 12:54
'♥ versión: 586, 6-oct.-2017 07:11
<System.ComponentModel.DefaultEvent("DMSSelectIndex")> _
Public Class ComboDMS
    Public Event DMSSelectIndex(ByVal Sender As Object, ByVal Id As Integer)
	Dim DtOriginal As New DataTable
	Dim TextoBus As String = ""

	Public Function DMSSelectedIndex() As Integer
        Return ComboBox1.SelectedIndex

    End Function
    Public Function DMSTraerTexto() As String
        Return "" & ComboBox1.Text

    End Function
    Public Function DMSTraerId() As Integer
        Return ValD("" & ComboBox1.SelectedValue)
    End Function

    'Public Function DMSTraerId() As Integer
    '    If ComboBox1.SelectedIndex < 0 Then
    '        Return ValD("" & ComboBox1.SelectedIndex)
    '    End If
    '    Return ValD("" & ComboBox1.SelectedValue)

    'End Function

    Public Function DMSPongaIndex(ByVal IdInicial As Integer) As Integer
        ComboBox1.SelectedValue = IdInicial
    End Function
    Public Sub DMSLlene_Combo(ByVal Dt As DataTable, _
                           ByVal CampoId As String, _
                           ByVal CampoMostrar As String, _
                           Optional ByVal ClausulaWhere As String = "", _
                           Optional ByVal CampoOrdenamiento As String = "", _
                           Optional ByVal TextoIdCero As String = "", _
                           Optional ByVal IdInicial As Integer = -1, _
                           Optional ByVal AutoCompletar As Boolean = True, _
                           Optional ByVal EsDropDownList As Boolean = True)

        RemoveHandler ComboBox1.SelectionChangeCommitted, AddressOf ComboBox1_SelectionChangeCommitted
        RemoveHandler ComboBox1.SelectedValueChanged, AddressOf ComboBox1_SelectedValueChanged

        'JDMS: 15-AGO-2013 lo quito por que creo que no sirve para nada
        'If EsDropDownList Then
        '    ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        'Else
        '    ComboBox1.DropDownStyle = ComboBoxStyle.DropDown
        'End If

        'Dt = Filtrar_DataTable(Dt, ClausulaWhere, CampoOrdenamiento)
        'usar -1 para que no ordene
        Dt = Filtrar_DataTable(Dt, ClausulaWhere, IIf(CampoOrdenamiento = "-1", "", IIf(CampoOrdenamiento = "", CampoMostrar, CampoOrdenamiento)))

        If TextoIdCero <> "" Then
            Dim Row As DataRow = Dt.NewRow()
            With Row
				Row.Item(CampoMostrar) = Idi(TextoIdCero)
				Row.Item(CampoId) = 0
            End With

            Dt.Rows.InsertAt(Row, 0)
        End If
        DtOriginal = Dt
        ComboBox1.DataSource = Dt
        ComboBox1.DisplayMember = CampoMostrar
        ComboBox1.ValueMember = CampoId


        If IdInicial <> -1 Then
            ComboBox1.SelectedValue = IdInicial
        Else
            ComboBox1.SelectedIndex = -1
        End If
        If AutoCompletar Then
            'ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End If
        AddHandler ComboBox1.SelectionChangeCommitted, AddressOf ComboBox1_SelectionChangeCommitted
        AddHandler ComboBox1.SelectedValueChanged, AddressOf ComboBox1_SelectedValueChanged

    End Sub


    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
		If e.KeyCode = Keys.F1 Then
			If ComboBox1.SelectedIndex < 0 Then
				TextoBus = ComboBox1.Text
			End If
			LblBuscar_Click(LblBuscar, New EventArgs)
		ElseIf e.KeyCode = Keys.Enter Then
			'JDMS: 15-ago-2013: lo quito por que no se para qué sirve
			'Else
			'    Validar_Combo_KeyDown(ComboBox1)
		End If
        If ComboBox1.DropDownStyle = ComboBoxStyle.DropDown Then
            Validar_Combo_KeyDown(ComboBox1)
        End If
    End Sub

    'Private Sub ComboBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Leave
    '    Dim Index As Integer = Buscar_Texto_Combo(ComboBox1)
    '    If Index < 0 Then Exit Sub
    '    ComboBox1.SelectedIndex = Index
    'End Sub

    Private Sub ComboBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Leave
        Dim Index As Integer = Buscar_Texto_Combo(ComboBox1)
        'If Index < 0 Then Exit Sub
        ComboBox1.SelectedIndex = Index
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        If ComboBox1.SelectedValue Is Nothing Then Exit Sub

        If ComboBox1.SelectedValue.GetType Is GetType(DataRowView) Then Exit Sub

        If ComboBox1.DataSource.rows.count = 0 Then Exit Sub
        Validar_Combo_KeyDown(ComboBox1)

        RaiseEvent DMSSelectIndex(Me, DMSTraerId())
    End Sub


    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        If ComboBox1.DataSource.rows.count = 0 Then Exit Sub
        'RaiseEvent DMSSelectIndex(Me, DMSTraerId())
    End Sub


    'Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click

    '    Dim Index As Integer = Buscar(ComboBox1.DataSource, ComboBox1.DisplayMember, ComboBox1.ValueMember)
    '    If Index <= 0 Then Exit Sub
    '    ComboBox1.SelectedValue = Index
    '    ComboBox1.Focus()
    'End Sub

    'Private Sub ContarLineasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContarLineasToolStripMenuItem.Click
    '    Mensaje(ContarLineasDt(ComboBox1.DataSource))
    'End Sub


    Private Sub LblBuscar_Click(sender As System.Object, e As System.EventArgs) Handles LblBuscar.Click
		Dim Index As Integer = Buscar(ComboBox1.DataSource, ComboBox1.DisplayMember, ComboBox1.ValueMember, TextoBus)
		ComboBox1.Focus()
        If Index <= 0 Then Exit Sub
        ComboBox1.SelectedValue = Index

    End Sub
End Class
