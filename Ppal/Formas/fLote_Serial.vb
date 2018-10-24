'♥ versión: 586, 6-oct.-2017 07:11
Public Class fLote_Serial
    Dim _DtLotesAgregados As New DataTable
    Dim IdLote As Integer
    Private Sub fLote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DiseñoDtLote()

        CbLote.DataSource = DtItemLotes
        CbLote.DisplayMember = "lote"
        CbLote.ValueMember = "id_cot_item_lote"
        CbLote.SelectedIndex = -1
        'TxtFecha.Visible = ValD(Me.Tag) < 2

        TxtCant.Visible = ValD(Me.Tag) < 2
        Label3.Visible = ValD(Me.Tag) < 2

        GrdLote.Columns("cantidad").Visible = ValD(Me.Tag) < 2
        'GrdLote.Columns("fecha_vencimiento").Visible = ValD(Me.Tag) < 2

        Me.Tag = 0

        Nuevo()

    End Sub

    Private Sub DiseñoDtLote()
        If _DtLotesAgregados.Columns.Count = 0 Then
            _DtLotesAgregados.Columns.Add("id")
            _DtLotesAgregados.Columns.Add("lote")
            _DtLotesAgregados.Columns.Add("cantidad")
            _DtLotesAgregados.Columns.Add("fecha_vencimiento")
            _DtLotesAgregados.Columns.Add("notas")
        End If


        GrdLote.DataSource = _DtLotesAgregados

    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click

        Dim Mens As String = Valida()

        If Mens <> "" Then
            Mensaje(Mens)
            Exit Sub
        End If


        Agregar()

        Me.Tag = 1

    End Sub


    Private Sub Agregar()
        Try

            Dim Dr As DataRow

            If ValD(CmdOk.Tag) >= 0 Then
                Dr = _DtLotesAgregados.DefaultView.Item(ValD(CmdOk.Tag)).Row
            Else
                Dr = _DtLotesAgregados.Rows.Add()
            End If

            Dr.Item("id") = IdLote
            Dr.Item("lote") = CbLote.Text.Trim
            Dr.Item("cantidad") = IIf(ValD(TxtCant.Text.Trim) = 0, 1, ValD(TxtCant.Text.Trim))
            Dr.Item("fecha_vencimiento") = FechaSinHora(CDate(TxtFecha.Value))
            Dr.Item("notas") = TxtNotas.Text.Trim
            Nuevo()

        Catch ex As Exception
            MostrarError(Me.Name, "Agregar", ex.Message)
        End Try
    End Sub
    Private Function Valida() As String
        Valida = ""
        If CbLote.Text = "" Then Valida &= "Debe digitar el lote." & DMScr()
        If ValD(CmdOk.Tag) <> -1 Then Exit Function
        Dim Dr() As DataRow = _DtLotesAgregados.Select("lote='" & CbLote.Text.Trim & "'")
        If Dr.Length > 0 Then
            Valida &= "El lote ya fue ingresado" & DMScr()
        End If

    End Function


    Private Sub ValidaExistencia(ByVal Lote As String)

        IdLote = 0
        LimpiarDatos()
        If DtItemLotes.Rows.Count > 0 Then

            IdLote = ValD(Obtenga_Dato(DtItemLotes, "lote='" & Lote & "'", "id_cot_item_lote"))
            If IdLote > 0 Then
                OpcionPermitida(False)

            End If
        End If
    End Sub

    Private Sub Nuevo()
        CbLote.ResetText()
        LimpiarDatos()
        CbLote.Focus()
    End Sub
    Private Sub LimpiarDatos()


        TxtCant.ResetText()
        TxtFecha.ResetText()
        TxtNotas.ResetText()
        TxtFecha.Enabled = True
        TxtNotas.ReadOnly = False
        CmdOk.Tag = -1
        CbLote.Tag = ""


    End Sub

    Private Sub OpcionPermitida(ByVal Habilitar As Boolean)
        If Not Habilitar Then

            If Obtenga_Dato(DtItemLotes, "id_cot_item_lote=" & IdLote, "fecha_vencimiento") IsNot DBNull.Value Then

                TxtFecha.Value = CDate(Obtenga_Dato(DtItemLotes, "id_cot_item_lote=" & IdLote, "fecha_vencimiento"))

            End If
            TxtNotas.Text = "" & Obtenga_Dato(DtItemLotes, "id_cot_item_lote=" & IdLote, "notas")
            TxtCant.Focus()


        End If
        If IdLote > 0 Then
            TxtFecha.Enabled = False
            TxtNotas.ReadOnly = True
        End If


    End Sub


    Private Sub GrdLote_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdLote.CellClick
        Nuevo()
    End Sub

    Private Sub GrdLote_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdLote.CellDoubleClick
        Editar()
    End Sub

    Private Sub Editar()

        CmdOk.Tag = GrdLote.SelectedRows(0).Index

        Dim Dr As DataRow

        Dr = _DtLotesAgregados.DefaultView.Item(ValD(CmdOk.Tag)).Row

        IdLote = Dr.Item("id")
        CbLote.Text = Dr.Item("lote")
        TxtCant.Text = ValD(Dr.Item("cantidad"))
        If Dr.Item("fecha_vencimiento") IsNot DBNull.Value Then

            TxtFecha.Value = Dr.Item("fecha_vencimiento")
        End If
        TxtNotas.Text = Dr.Item("notas")


    End Sub

    Private Sub Cmd_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Actualizar.Click
        Me.Close()
    End Sub


    Public ReadOnly Property DMSDtLotesAgregados() As DataTable
        Get
            Return _DtLotesAgregados
        End Get
    End Property

    Private Sub CbLote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbLote.TextChanged
        CbLote.Text = CbLote.Text.ToUpper
        CbLote.SelectionStart = CbLote.Text.Length

    End Sub

    Private Sub CbLote_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbLote.Validated
        ValidaExistencia(CbLote.Text.Trim)
    End Sub

    Private Sub CbLote_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbLote.KeyDown
        CbLote.DroppedDown = False
    End Sub
End Class