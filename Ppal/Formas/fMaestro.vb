' Version: 684, 24-ago.-2018 16:56
' Version: 681, 20-ago.-2018 20:08
' Version: 660, 5-jul.-2018 12:55
' Version: 625, 14-feb.-2018 12:31
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fMaestro
    Dim Toco As Boolean = False

    Public IdCb As Integer = 0
    Public EsNumerico As Boolean = False
    Public NoMuestro As Boolean = False
    Public dtOriginal As New DataTable
    Public array As ArrayList
    Public StorePut As String
    Public StoreDel As String
    Public CampoDescripcion As String = "descripcion"
    Public NombreCampo As String = "Descripcion"
    Public CampoIdFiltro As String = ""
    Public CampoIdOri As String = ""
    Public CampoDesOri As String = ""

    Private Sub fMaestro_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Toco Then
            Dim Resp As Short
            Resp = PregunteCancel("Tiene datos sin actualizar, desea Actualizarlos antes de salir?")
            If Resp = MsgBoxResult.Cancel Then
                e.Cancel = 1
                Exit Sub
            End If
            If Resp = MsgBoxResult.Yes Then
                CmdOk_Click(CmdOk, New EventArgs)
            End If
        End If
    End Sub
    Private Sub FMaestro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		If ProgInicial = "0107" Then
			Label2.Text = "Tipo"
		End If

		If Not NoMuestro Then
            SplitContainer1.Panel1Collapsed = True
            Me.Size = PnlDesp.Size
        Else
            If IdCb > 0 Then
                CbPadre.Enabled = False
            Else
                array.Clear()
                AddHandler CbPadre.SelectedIndexChanged, AddressOf CbPadre_SelectedIndexChanged
            End If
            PongaIndex(CbPadre, IdCb)
        End If

        Grd.Rows.Clear()
        Label1.Text = NombreCampo
        Grd.Columns("descripcion").HeaderText = NombreCampo
        If array.Count = 0 Then Exit Sub
        For i As Integer = 0 To array.Count - 1
            Grd.Rows.Add(array.Item(i).data, array.Item(i).description)
        Next
        Grd.SelectedRows(0).Selected = False
        CmdNuevo_Click(sender, New EventArgs)
    End Sub




    Private Sub CmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAgregar.Click
        If NoMuestro Then
            If CbPadre.SelectedIndex < 0 Then
                Mensaje("Seleccione padre")
                CbPadre.Focus()
                Exit Sub
            End If
        End If


        txtDescripcion.Text = SinComillas(Trim(txtDescripcion.Text))
        If txtDescripcion.Text.Trim = "" Then Mensaje("Debe digitar " & NombreCampo) : PongaFoco(txtDescripcion) : Exit Sub
        If EsNumerico Then
            If Not IsNumeric(txtDescripcion.Text) Then Mensaje("Debe ser numerico") : PongaFoco(txtDescripcion) : Exit Sub
        End If

        Dim RenglonSel As Integer
        If ValD(CmdAgregar.Tag) = 0 Then
            Grd.Rows.Add("0", txtDescripcion.Text, "1")
            RenglonSel = Grd.Rows.Count - 1
        Else
            Grd.Rows(Grd.SelectedRows(0).Index).Cells(CampoDescripcion).Value = txtDescripcion.Text
            Grd.Rows(Grd.SelectedRows(0).Index).Cells("modifico").Value = "1"
            RenglonSel = Grd.SelectedRows(0).Index
        End If
        txtDescripcion.Text = ""
        txtDescripcion.Tag = ""
        CmdAgregar.Tag = ""

        Grd.FirstDisplayedScrollingRowIndex = RenglonSel
        Grd.Rows(RenglonSel).Selected = True

        CmdNuevo_Click(CmdNuevo, New EventArgs)

        Toco = True

        'Dim DataRow As DataGridViewRow = Grd.Rows(0)
        'If Grd.SelectedRows.Contains(DataRow) Then
        '    Grd.SelectedRows(0).Selected = False
        'End If


    End Sub

    Private Sub CmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBorrar.Click
        If Grd.SelectedRows(0).Index < 0 Then
            Mensaje("Seleccione uno")
            Exit Sub
        End If
        Grd.Rows(Grd.SelectedRows(0).Index).Visible = False
        Grd.Rows(Grd.SelectedRows(0).Index).Cells("modifico").Value = "0"
        CmdNuevo_Click(sender, New EventArgs)

        Toco = True

    End Sub


    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If NoEstoyEnLinea() Then Exit Sub

        Try
            SiReloj()
            Dim Sql As String = ""
            For i As Integer = 0 To Grd.RowCount - 1

                If Not Grd.Rows(i).Visible Then
                    If Tm(Grd, "id", i) > 0 Then 'si es vieja
                        Sql = Sql & "exec " & StoreDel & " '" & Tm(Grd, "id", i) & "'" & DMScr()
                    End If
                    Continue For
                End If

                'si la línea no fue tocada, saltarla
                If Tm(Grd, "modifico", i) = "" Then
                    Continue For
                End If
                If NoMuestro Then
                    Sql = Sql & "exec " & StorePut & " '" & Numero_Empresa.ToString & "','" & Usuario.ToString & "','" & _
                    Tm(Grd, "id", i) & "','" & _
                    TraerId(CbPadre).ToString & "','" & _
                    Tm(Grd, CampoDescripcion, i) & "'" & DMScr()
                Else
                    Sql = Sql & "exec " & StorePut & " '" & Numero_Empresa.ToString & "','" & Usuario.ToString & "','" & Tm(Grd, "id", i) & "','" & Tm(Grd, CampoDescripcion, i) & "'" & DMScr()
                End If

            Next

            If Sql <> "" Then
                Try
                    Ejecutar(Sql)
                    SonarWAV("ok")

                Catch ex As Exception
                    If InStr(ex.Message, " DELETE ") > 0 Then
                        Mensaje("No puede borrar registros que están siendo usados")
                    ElseIf InStr(ex.Message, " clave duplicada ") > 0 Then
                        Mensaje("No puede ingresar dos descripciones iguales")
                    Else
						Mensaje("No puede actualizar: " & ex.Message & EsIngles())
					End If
					Exit Sub
				End Try
			End If

			'ActualizoMaestro = True
			Toco = False
			Me.Close()

		Catch ex As Exception
			NoReloj()

			Mensaje("Intente más tarde: " & ex.Message & EsIngles())

		End Try
        NoReloj()
    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub CmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNuevo.Click
        'Dim DataRow As DataGridViewRow = Grd.Rows(0)
        'If Grd.SelectedRows.Contains(DataRow) Then
        '    Grd.SelectedRows(0).Selected = False
        'End If
        LblID.Text = "ID:"
        txtDescripcion.Tag = ""
        txtDescripcion.Text = ""
        CmdAgregar.Text = "&Agregar"
        CmdAgregar.Tag = ""
        CmdBorrar.Enabled = False

        txtDescripcion.Focus()
    End Sub

    Private Sub Grd_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grd.CellClick
        If Grd.RowCount = 0 Then Exit Sub
        txtDescripcion.Tag = Grd.Rows(Grd.SelectedRows(0).Index).Cells("id").Value.ToString
        LblID.Text = "ID: " & txtDescripcion.Tag.ToString
        txtDescripcion.Text = Grd.Rows(Grd.SelectedRows(0).Index).Cells(CampoDescripcion).Value.ToString
        CmdAgregar.Tag = 1
        CmdAgregar.Text = "&Modificar"
        txtDescripcion.Focus()
        txtDescripcion.SelectAll()
        CmdBorrar.Enabled = True


    End Sub


    Private Sub CbPadre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt As DataTable = Filtrar_DataTable(dtOriginal, CampoIdFiltro & " =" & TraerId(CbPadre))
        Dt = Hacer_DataTable_Id_Desc(Dt, CampoIdOri, CampoDesOri)
        If Grd.RowCount > 0 Then Grd.Rows.Clear()
        For i As Integer = 0 To Dt.Rows.Count - 1
            Grd.Rows.Add(Dt.Rows(i).Item("id"), Dt.Rows(i).Item("descripcion"))
        Next

    End Sub
    Private Function Hacer_DataTable_Id_Desc(ByVal dt As DataTable, ByVal CampoId As String, ByVal CampoDescrpcion As String) As DataTable
        Dim dtNew As New DataTable
        dtNew.Columns.Add("id")
        dtNew.Columns.Add("descripcion")
        Dim Descripcion As String = ""
        For Each dr As DataRow In dt.Rows
            If dr(CampoDescrpcion).ToString = "" & Descripcion Then
                Continue For
            End If
            dtNew.Rows.Add("" & dr(CampoId), "" & dr(CampoDescrpcion))
            Descripcion = dr(CampoDescrpcion)
        Next
        Return dtNew
    End Function

    Private Sub LnkExportar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkExportar.LinkClicked
        Copiar_Exel(Grd, , Me.Text)


    End Sub

	Private Sub CbPadre_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CbPadre.SelectedIndexChanged
		CmdNuevo_Click(CmdNuevo, Nothing)

	End Sub
End Class