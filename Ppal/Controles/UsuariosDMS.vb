' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 675, 14-ago.-2018 18:45
'♥ versión: 586, 6-oct.-2017 07:11
<System.ComponentModel.DefaultEvent("DMSCheckIndex")> _
Public Class UsuariosDMS
    Public Event DMSCheckIndex(ByVal Sender As Object, ByVal id As Integer, ByVal ValorCheck As Boolean, ByRef NuevoValor As CheckState)
    Dim _Grupo As Boolean = True
    Dim DtUsu As New DataTable
    Public Function DMSListCount() As Integer
        Return Lst1.Items.Count

    End Function

    Public Property DMSClic_Grupo() As Boolean
        Get
            Return _Grupo
        End Get
        Set(ByVal value As Boolean)
            _Grupo = value
        End Set
    End Property

    Public Sub DMSLLene_Usuarios(ByVal dt As DataTable)
        DtUsu = dt
        If DtUsu.Rows.Count = 0 Then Exit Sub

        Mostrar_Usuarios(Lst1, RadioButton1.Checked)
    End Sub
    Public Sub DmsChekeo_Usuarios(ByVal Todos As Boolean)
        For I As Integer = 0 To Lst1.Items.Count - 1
            Lst1.SetItemChecked(I, Todos)
        Next
    End Sub


    'Public Sub DMSSeleccionar_Usuarios(ByVal Ids As String)
    '    RemoveHandler Lst1.ItemCheck, AddressOf Lst1_ItemCheck
    '    If Ids = "" Then Exit Sub
    '    Dim Id() As String = Ids.Split(",")

    '    For I = 0 To Id.Length - 1
    '        For J = 0 To Lst1.Items.Count - 1
    '            Try
    '                Dim algo As DataDescription
    '                algo = Lst1.Items(J)
    '                If Not IsNumeric(algo.Data) Then Continue For
    '                If algo.Data = Id(I) Then

    '                    Lst1.SetItemChecked(J, True)
    '                    Exit For
    '                End If
    '            Catch

    '            End Try
    '        Next
    '    Next

    '    AddHandler Lst1.ItemCheck, AddressOf Lst1_ItemCheck

    'End Sub
    Public Sub DMSSeleccionar_Usuarios(ByVal Ids As String)
        For J = 0 To Lst1.Items.Count - 1
            Lst1.SetItemChecked(J, False)
        Next

        If Ids = "" Then Exit Sub
        Dim Id() As String = Ids.Split(",")
        RemoveHandler Lst1.ItemCheck, AddressOf Lst1_ItemCheck


        For I = 0 To Id.Length - 1
            For J = 0 To Lst1.Items.Count - 1
                Try
                    Dim algo As DataDescription
                    algo = Lst1.Items(J)
                    If Not IsNumeric(algo.Data) Then Continue For
                    If algo.Data = Id(I) Then

                        Lst1.SetItemChecked(J, True)
                        Exit For
                    End If
                Catch

                End Try
            Next
        Next

        AddHandler Lst1.ItemCheck, AddressOf Lst1_ItemCheck

    End Sub

    Public Sub DMSQuitar_Links(Optional ByVal Todos As Boolean = False, Optional ByVal Ninguno As Boolean = False)
        If Todos Then
            LnkTodos.Visible = False
        End If

        If Ninguno Then
            LnkNinguno.Visible = False
        End If
    End Sub


    Public Function DMSTraerIds() As String
        Dim Ids As String = ""
        For I As Integer = 0 To Lst1.Items.Count - 1 'lista de usuarios
            If Lst1.GetItemChecked(I) = True Then 'que esté chekeado
                If RadioButton1.Checked Or Trim(Mid(Lst1.Items(I).ToString, 1, 8)) = "" Then 'que no sea un grupo
                    Ids &= TraerId(Lst1, I).ToString & ","

                End If
            End If
        Next
        If Ids <> "" Then
            Ids = Ids.Substring(0, Ids.Length - 1)
        End If
        Return Ids
    End Function



    Public Sub Mostrar_Usuarios(ByVal CHkList As CheckedListBox, Optional ByVal Check As Boolean = True)
        Try

            'guardar los que tiene seleccionados
            Dim Lst As New ListBox
            Lst.Items.Clear()


            For I As Integer = 0 To CHkList.CheckedItems.Count - 1
                Dim algo As DataDescription
                algo = CHkList.CheckedItems(I)
                If Not IsNumeric(algo.Data) Then Continue For
                Lst.Items.Add(algo.Data.ToString)
            Next

            CargarLista(CHkList, Check)


            For I As Integer = 0 To Lst.Items.Count - 1
                Dim Verificador As Integer = 1
                If Lst.Items(I) < 0 Then 'Si es negativo es en cita positivo desde menu
                    Verificador = -1
                End If

                For J As Integer = 0 To CHkList.Items.Count - 1
                    Dim algo As DataDescription
                    algo = CHkList.Items(J)
                    If Not IsNumeric(algo.Data) Then Continue For
                    If algo.Data = ValD(Lst.Items(I)) * Verificador Then
                        CHkList.Items(J).data = algo.Data * Verificador
                        CHkList.SetItemChecked(J, True)
                        Exit For
                    End If
                Next
            Next


            'If ChkSeleccionados.Checked Then
            '    ChkSeleccionados.Checked = False
            '    ChkSeleccionados.Checked = True
            'End If
            'If ChkSeleccionados.Checked Then
            '    haga_seleccion()
            'End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Lst1_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lst1.SelectedValueChanged
        If RadioButton1.Checked Then Exit Sub

        'es un item, no es cabeza de grupo ni de subgrupo
        If Mid(Lst1.Text, 8, 1) = " " And Mid(Lst1.Text, 9, 1) <> "" Then Exit Sub

        Dim Marcar As Boolean = Lst1.GetItemChecked(Lst1.SelectedIndex)

        If Marcar And _Grupo = False Then
            Lst1.SetItemChecked(Lst1.SelectedIndex, False)
            Exit Sub
        End If

        'determinar si es grupo o subgrupo
        Dim EsGrupo As Boolean = False
        If Mid(Lst1.Text, 1, 1) <> " " Then
            EsGrupo = True
        Else
            EsGrupo = False
        End If



        For I As Integer = Lst1.SelectedIndex + 1 To Lst1.Items.Count - 1
            If EsGrupo Then
                If Mid(Lst1.Items(I).ToString, 1, 1) <> " " Then
                    Exit For 'ya terminó
                End If
                Lst1.SetItemChecked(I, Marcar)
            Else

                If Mid(Lst1.Items(I).ToString, 5, 1) <> " " Then
                    Exit For 'ya terminó
                End If
                Lst1.SetItemChecked(I, Marcar)
            End If
        Next


    End Sub
    Private Sub Guarde_Indices()
        If Me.Tag = "S" Then
            Dim cual As String = DMSTraerIds()
            SaveSett(Me.Name, "ult", cual)
        End If

    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        'ChkSeleccionados.Checked = False

        Mostrar_Usuarios(Lst1, True)

        If ChkSeleccionados.Checked Then
            ChkSeleccionados.Checked = False
            ChkSeleccionados.Checked = True
        End If
    End Sub
    Private Sub ChkOnLine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkOnLine.CheckedChanged
        'ChkSeleccionados.Checked = False

        Mostrar_Usuarios(Lst1, RadioButton1.Checked)
    End Sub


    Public Sub CargarLista(ByRef Lst1 As CheckedListBox, ByVal Listado As Boolean)



        Try
            Dim OnL As New DataTable
            If ChkOnLine.Checked Then
                SiReloj()
                Abrir(OnL, "GetUsuariosOnLineBasica " & Numero_Empresa.ToString)
                NoReloj()
            End If

            Dim Dr() As DataRow
            If Listado Then
                Dr = DtUsu.Select("tipo=2", "nombre")
            Else
                Dr = DtUsu.Select("tipo=2", "nombre_grupo,nombre_subgrupo,nombre")
            End If

            Dim GruAnt As String = ""
            Dim SubAnt As String = ""

            Lst1.Items.Clear()

            Dim i As Integer = 0
            For Each row As DataRow In Dr
                If ChkOnLine.Checked Then
                    If Obtenga_Dato(OnL, "id=" & row.Item("id").ToString, "id") Is DBNull.Value Then
                        Continue For
                    End If
                End If

                If Listado Then
                    Lst1.Items.Add(New DataDescription(row.Item("id"), Trim(row.Item("nombre")) & " (" & row.Item("codigo_usuario") & ")"))
                Else

                    If GruAnt <> row.Item("nombre_grupo") Then
                        Lst1.Items.Add(New DataDescription(row.Item("nombre_grupo"), row.Item("nombre_grupo")))
                        i = i + 1

                        GruAnt = row.Item("nombre_grupo")
                        SubAnt = ""
                    End If
                    If SubAnt <> row.Item("nombre_subgrupo") Then
                        Lst1.Items.Add(New DataDescription(row.Item("nombre_subgrupo"), "    " & row.Item("nombre_subgrupo")))
                        i = i + 1
                        SubAnt = row.Item("nombre_subgrupo")
                    End If
                    Lst1.Items.Add(New DataDescription(row.Item("id"), "        " & Trim(row.Item("nombre")) & " (" & row.Item("codigo_usuario") & ")"))

                End If

                i = i + 1
            Next

        Catch ex As Exception
            NoReloj()


        End Try



    End Sub



    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        'ChkSeleccionados.Checked = False
        Mostrar_Usuarios(Lst1, False)

        If ChkSeleccionados.Checked Then
            ChkSeleccionados.Checked = False
            ChkSeleccionados.Checked = True
        End If

    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click, LblBuscar.Click
        Dim DtUsu2 As DataTable = Filtrar_DataTable(DtUsu, "tipo=2")

        Dim Id As Integer = Buscar(DtUsu2, "nombre", "id")
        If Id > 0 Then
            For I = 0 To Lst1.Items.Count - 1
                Try
                    If TraerId(Lst1, I) = Id Then
                        Lst1.SetItemChecked(I, True)
                        Lst1.SelectedIndex = I
                        Exit For
                    End If
                Catch ex As Exception

                End Try

            Next
        End If

        Lst1.Focus()
    End Sub


    Private Sub Lst1_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles Lst1.ItemCheck

        Dim algo As DataDescription = Lst1.Items(e.Index)
        If ValD(algo.Data) = 0 Then Exit Sub
        RaiseEvent DMSCheckIndex(Me, algo.Data, Lst1.GetItemChecked(e.Index), e.NewValue)



    End Sub
    'Private Sub Lst1_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles Lst1.ItemCheck

    '    Dim algo As DataDescription = Lst1.Items(e.Index)
    '    RaiseEvent DMSCheckIndex(Me, algo.Data, Lst1.GetItemChecked(e.Index), e.NewValue)
    'End Sub

    Private Sub ChkSeleccionados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSeleccionados.CheckedChanged
        Dim Ids As String = DMSTraerIds()
        If Ids = "" Then
            If ChkSeleccionados.Checked Then
                'Mensaje_TopMost("No hay usuarios seleccionados")
                ChkSeleccionados.Checked = False
                Exit Sub
            End If
        End If

        Dim Filtro As String = ""

        If ChkSeleccionados.Checked Then
            Filtro = "id in(" & Ids & ")"
        End If

        Dim DtTemp As DataTable = Filtrar_DataTable(DtUsu, Filtro)
        Dim DtusuTemp As DataTable = DtUsu.Copy
        DMSLLene_Usuarios(DtTemp)

        If Ids <> "" Then
            DMSSeleccionar_Usuarios(Ids)
        End If

        DtUsu = DtusuTemp.Copy


    End Sub
    Private Sub LnkTodos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkTodos.LinkClicked
        Ponga_Quite(True)
        Guarde_Indices()

    End Sub

    Private Sub LnkNinguno_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkNinguno.LinkClicked
        Ponga_Quite(False)

    End Sub
    Public Sub Ponga_Quite(ByVal Poner As Boolean)
        For I As Integer = 0 To Lst1.Items.Count - 1
            Lst1.SetItemChecked(I, Poner)
        Next

    End Sub

    Private Sub LnkUlt_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkUlt.LinkClicked
        Dim cual As String = GetSett(Me.Name, "ult", "")
        If cual = "" Then Exit Sub

        ChkOnLine.Checked = False

        DMSSeleccionar_Usuarios(cual)

        If ChkSeleccionados.Checked Then
            ChkSeleccionados.Checked = False
        End If
        ChkSeleccionados.Checked = True

    End Sub

    Private Sub Lst1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Lst1.MouseUp
        Guarde_Indices()

    End Sub

	Private Sub UsuariosDMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_Idioma(Me, Me)
		Recorrer_Controles_ContextMenuStrip(ContextMenuStrip1)

	End Sub
End Class
