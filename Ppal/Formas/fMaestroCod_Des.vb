' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fMaestroCod_Des
    Dim _PorcPut As String = ""
    Dim _PorcDel As String = ""
    Dim _SoyNumerico As Boolean = False
    Dim _ID_Padre As Integer = 0
    Dim Elimino As Boolean = False
    Dim DtOriginal As New DataTable

    Private Sub fMaestroCod_Des_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Nuevo()
    End Sub
#Region "Propiedades"
    Public Property DMSTitCod As String
        Get
            Return LblCodigo.Text
        End Get
        Set(ByVal value As String)
            LblCodigo.Text = value
            Grd.Columns("cod").HeaderText = value
        End Set
    End Property

    Public Property DMSTitDes As String
        Get
            Return LblDes.Text
        End Get
        Set(ByVal value As String)
            LblDes.Text = value
            Grd.Columns("descripcion").HeaderText = value
        End Set
    End Property

    Public Property DMSMaxCod As Integer
        Get
            Return TxtCod.MaxLength
        End Get
        Set(ByVal value As Integer)
            TxtCod.MaxLength = value
        End Set
    End Property

    Public Property DMSMaxDes As Integer
        Get
            Return TxtDescripcion.MaxLength
        End Get
        Set(ByVal value As Integer)
            TxtDescripcion.MaxLength = value
        End Set
    End Property

    Public Property DMSProcPut As String
        Get
            Return _PorcPut
        End Get
        Set(ByVal value As String)
            _PorcPut = value
        End Set
    End Property

    Public Property DMSProcDel As String
        Get
            Return _PorcDel
        End Get
        Set(ByVal value As String)
            _PorcDel = value
        End Set
    End Property

    Public Property DMSNomCampoCod As String
        Get
            Return Grd.Columns("cod").DataPropertyName
        End Get
        Set(ByVal value As String)
            Grd.Columns("cod").DataPropertyName = value
        End Set
    End Property

    Public Property DMSNomCampoDes As String
        Get
            Return Grd.Columns("descripcion").DataPropertyName
        End Get
        Set(ByVal value As String)
            Grd.Columns("descripcion").DataPropertyName = value
        End Set
    End Property

    Public Property DMSNomCampoIdPadre As String
        Get
            Return Grd.Columns("id_cam_padre").DataPropertyName
        End Get
        Set(ByVal value As String)
            Grd.Columns("id_cam_padre").DataPropertyName = value
        End Set
    End Property

    Public Property DMSAsignarDT As DataTable
        Get
            Return DtOriginal
        End Get
        Set(ByVal value As DataTable)
            DtOriginal = value
            Try
                DtOriginal.Columns.Add("modifico")
            Catch
            End Try
            Grd.DataSource = value
        End Set
    End Property

    Public Property DMSEstoyModificando As Integer
        Get
            Return ValD(TxtCod.Tag)
        End Get
        Set(ByVal value As Integer)

            TxtCod.Tag = value

        End Set
    End Property

    Public Property DMSSoyNumerico As Boolean
        Get
            Return _SoyNumerico
        End Get
        Set(ByVal value As Boolean)

            _SoyNumerico = value

        End Set
    End Property

    Public Property DMSIDPadre As Integer
        Get
            Return _ID_Padre
        End Get
        Set(ByVal value As Integer)

            _ID_Padre = value

        End Set
    End Property
#End Region

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.Close()
    End Sub



    Private Sub Nuevo()

        LblID.Text = "ID:"
        TxtDescripcion.Tag = ""
        TxtDescripcion.ResetText()
        DMSEstoyModificando = -1
        TxtCod.ResetText()
        CmdAgregar.Text = "&Agregar"
        CmdAgregar.Tag = ""
        'LnkEliminar .Enabled = False
        TxtCod.Focus()
    End Sub

    Private Enum DMS_Modifico As Integer
        Nada = 0
        Nuevo = 1
        Modifico = 2
        elimino = 3
    End Enum

    Private Sub CmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAgregar.Click
        If Not Valida() Then Exit Sub
        Haga_Ok()
    End Sub

    Private Function Valida() As Boolean
        Dim Mens As String = ""

        If TxtCod.Text.Trim = "" Then
			Mensaje("Debe digitar código")
			Return False
        End If

        If TxtDescripcion.Text.Trim = "" Then
            Mensaje("Debe digitar descripción")
            Return False
        End If

        If DmsBuscarEnDT(DtOriginal, DMSNomCampoCod & "='" & TxtCod.Text.Trim & "'", DMSEstoyModificando) And TxtCod.Text.Trim <> "" Then
            Mens &= "Ya existe el " & DMSTitCod & DMScr()
        End If
        If DmsBuscarEnDT(DtOriginal, DMSNomCampoDes & "='" & TxtDescripcion.Text.Trim & "'", DMSEstoyModificando) And TxtDescripcion.Text.Trim <> "" Then
            Mens &= "Ya existe la " & DMSTitDes & DMScr()
        End If


        If Mens <> "" Then
            Mensaje(Mens)
            Return False
        End If
        Return True
    End Function

    Private Function DmsBuscarEnDT(ByVal DT As DataTable, ByVal Criterio As String, ByVal Fila As Integer) As Boolean
        Dim DR() As DataRow = DT.Select(Criterio)
        If DR.Length = 0 Then
            Return False
        End If
        Dim iRowIndex As Integer
        For i = 0 To DT.Rows.Count - 1
            If DT.Rows(i).Equals(DR(0)) Then
                iRowIndex = i
                Exit For
            End If
        Next
        If iRowIndex = Fila Then
            Return False
        End If
        If DR.Length > 0 Then
            Return True
        End If

    End Function


    Private Sub Haga_Ok()
        Dim Dr As DataRow
        Dim Que As Integer = DMS_Modifico.Nuevo
        If DMSEstoyModificando < 0 Then 'nuevo
            Dr = DtOriginal.Rows.Add
        Else 'modificando
            Dr = DtOriginal.DefaultView.Item(DMSEstoyModificando).Row
            Que = DMS_Modifico.Modifico
        End If

        Dr.Item(DMSNomCampoCod) = TxtCod.Text.Trim
        Dr.Item(DMSNomCampoDes) = TxtDescripcion.Text.Trim
        Dr.Item("modifico") = Que

        Nuevo()

    End Sub

    Private Sub Grd_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grd.CellDoubleClick
        Editar_Renglon()
    End Sub
    Private Sub Editar_Renglon()
        DMSEstoyModificando = Grd.SelectedRows(0).Index
        Dim Dr As DataRow = DtOriginal.DefaultView.Item(DMSEstoyModificando).Row

        LblID.Text = "ID: " & ValD(Dr.Item("id"))
        TxtCod.Text = Dr.Item(DMSNomCampoCod)
        TxtDescripcion.Text = Dr.Item(DMSNomCampoDes)
        CmdAgregar.Text = "&Modificar"
        TxtCod.Focus()
    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If NoEstoyEnLinea() Then Exit Sub

        If Not Pregunte("Seguro de Actualizar?", , Me.Name, , 4) Then Exit Sub
        SiReloj()
        Actualizar()
        NoReloj()
    End Sub

    Private Sub Actualizar()
        GlobalesVarios.SQL = ""
        For Each Dr As DataRow In DtOriginal.Rows
            If ValD(Dr.Item("modifico")) = DMS_Modifico.Nada Then
                Continue For
                'ElseIf ValD(Dr.Item("modifico")) = DMS_Modifico.elimino Then 'elimino
                '    HS("exec " & DMSProcDel & " ")
                '    HS(ValD(Dr.Item("id")))
                '    HS(vbNewLine)
            ElseIf EstaEnLista(ValD(Dr.Item("modifico")), DMS_Modifico.Modifico, DMS_Modifico.Nuevo) Then 'hacer put
                HS("exec " & DMSProcPut & " ")
                HS(Numero_Empresa.ToString & ",")
                HS(ValD(Dr.Item("id")) & ",")
                HS("'" & Dr.Item(DMSNomCampoCod) & "',")
                HS("'" & Dr.Item(DMSNomCampoDes) & "'")
                If DMSIDPadre > 0 Then
                    HS("," & ValD(DMSIDPadre) & "")
                End If
                HS(vbNewLine)

            End If

        Next
        Try

            If GlobalesVarios.SQL <> "" Then
                Ejecutar(GlobalesVarios.SQL)
                Me.Tag = 1
            End If
            Me.Close()
            SonarWAV("ok")

        Catch ex As Exception
			MostrarError(Me.Name, "Actualizar", ex.Message)
		End Try

    End Sub

    Private Sub LnkNuevo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkNuevo.LinkClicked
        Nuevo()
    End Sub

    Private Sub LnkEliminar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkEliminar.LinkClicked
        Eliminar()
    End Sub

    Private Sub Eliminar()
        If DMSEstoyModificando < 0 Then
            Mensaje("Debe estar Modificando.")
            Exit Sub
        End If


        Try
            GlobalesVarios.SQL = ""
            Dim Dr As DataRow = DtOriginal.DefaultView.Item(DMSEstoyModificando).Row
			If Not Pregunte(Idi("Seguro de eliminar") & " " & Dr.Item(DMSNomCampoCod) & "?", , , , 3) Then Exit Sub

			If DMSEstoyModificando >= 0 Then
                HS("exec " & DMSProcDel & " ")
                HS(ValD(Dr.Item("id")))
                If DMSIDPadre > 0 Then
                    HS("," & ValD(DMSIDPadre) & "")
                End If
                HS(vbNewLine)
                Ejecutar(GlobalesVarios.SQL)
            End If

            Grd.SelectedRows(0).Height = 3
            Dr.Item("modifico") = DMS_Modifico.Nada
            'Dr.Delete()

            Nuevo()
            Elimino = True
            SonarWAV("ok")
        Catch ex As Exception
            Mensaje("No se puede eliminar porque ya fue utilizado.")
        End Try
    End Sub

    Private Sub TxtCod_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCod.Validated
        If Not DMSSoyNumerico Then Exit Sub

        If TxtCod.Text.Trim = "" Then Exit Sub

        If Not IsNumeric(TxtCod.Text.Trim) Then
			Mensaje("Debe ser Numérico.")
			TxtCod.ResetText()
        End If

    End Sub

    Private Sub fMaestroCod_Des_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Elimino Then
            Me.Tag = 1
        End If
    End Sub
End Class