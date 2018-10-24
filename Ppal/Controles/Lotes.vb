'♥ versión: 586, 6-oct.-2017 07:11
Public Class Lotes
    Dim _DtLotes As New DataTable
    Private Const FechaNula As DateTime = Nothing
    Private _SiCosto As Boolean = False
    Dim _Descripcion As String
    Public Event DMSIngresarVariosLotes(ByVal Dt As DataTable)
    Public Event DMSValidarCosto()


    Public Function DMSTraerId() As Integer
        If CbLotes.SelectedIndex < 0 Then
            Return 0
        End If

        Return ValD(TraerId(CbLotes))

    End Function
    Public Function DMSTraerTexto() As String
        Return "" & CbLotes.Text

    End Function

    Public Function DMSFecha_Lote() As DateTime
        If LblFechaVencimiento.Text = "" Then
            Return Nothing
        Else
            Return CDate(LblFechaVencimiento.Text)
        End If

    End Function


    Public Sub DMSPongaIndex(ByVal Id As Integer)
        PongaIndex(CbLotes, Id)
    End Sub


    Private Sub LnkNuevoLote_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkNuevoLote.LinkClicked
        If ValD(LnkNuevoLote.Tag) = 0 Then
            Mensaje("Opción solo para cuando es una entrada a inventario.")
            Exit Sub
        End If


        RaiseEvent DMSValidarCosto()
        If Not ValidaCosto Then Exit Sub

        Dim Flo As New fLote_Serial
        Flo.Tag = Maneja_Lotes
        Flo.Text = _Descripcion
        MostrarForma(Flo, True)

        _DtLotes = Flo.DMSDtLotesAgregados
        If _DtLotes.Rows.Count = 0 Then Exit Sub

        If _DtLotes.Rows.Count = 1 Then
            If ValD(Gdf(_DtLotes, "id")) = 0 Then
                DMSAgregarLote(ValD(Gdf(_DtLotes, "id")), Gdf(_DtLotes, "lote"), Gdf(_DtLotes, "cantidad"), , Gdf(_DtLotes, "notas"))
                CbLotes.SelectedIndex = CbLotes.Items.Count - 1
            Else
                PongaIndex(CbLotes, ValD(Gdf(_DtLotes, "id")))
            End If
            'Exit Sub
        End If
        RaiseEvent DMSIngresarVariosLotes(_DtLotes)

    End Sub

    Public Sub DMSAgregarLote(ByVal Id As Integer, _
                              ByVal Lote As String, _
                              ByVal Stock As Double, _
                              Optional ByVal Fecha_vencimiento As DateTime = FechaNula, _
                              Optional ByVal Notas As String = "")

        CbLotes.Items.Add(New DataDescription(Id, Lote & " (" & Stock & ")"))

    End Sub

    Public Sub DmsLLene_Lotes(ByVal Dt As DataTable, ByVal ManejaLotes As Integer, ByVal Descripcion As String, ByVal EsEntrada As Integer)
        CbLotes.Items.Clear()
        LblFechaVencimiento.Visible = False
        Maneja_Lotes = ManejaLotes
        _Descripcion = Descripcion
        LblNotas.Text = ""
        LnkNuevoLote.Tag = EsEntrada

        For I As Integer = 0 To Dt.Rows.Count - 1
            DMSAgregarLote(ValD(Gdf(Dt, I, "id_cot_item_lote")), Gdf(Dt, I, "lote").ToString, ValD(Gdf(Dt, I, "stock")))
        Next

    End Sub
    Private Sub CbLotes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbLotes.SelectedIndexChanged
        LblFechaVencimiento.Visible = False
        LblFechaVencimiento.Text = ""
        LblNotas.Text = ""
        LblStock.Text = "0"
        If DtItemLotes.Rows.Count > 0 Then
            Dim Fecha As Object = Obtenga_Dato(DtItemLotes, "id_cot_item_lote=" & TraerId(CbLotes), "fecha_vencimiento")
            If Fecha IsNot DBNull.Value Then
                LblFechaVencimiento.Visible = True
                LblFechaVencimiento.Text = CDate(Fecha).ToString("d-MMM-yyyy")
            End If

            LblNotas.Text = "" & Obtenga_Dato(DtItemLotes, "id_cot_item_lote=" & TraerId(CbLotes), "notas")
            LblStock.Text = ValD(Obtenga_Dato(DtItemLotes, "id_cot_item_lote=" & TraerId(CbLotes), "stock"))
        End If

    End Sub

#Region "Propiedades"

    Public ReadOnly Property DtLotes() As DataTable
        Get
            Return _DtLotes
        End Get
    End Property

    Public Property Maneja_Lotes As Integer
        Get
            Return Me.Tag
        End Get
        Set(ByVal value As Integer)
            Me.Tag = value
        End Set
    End Property

    Public Property ValidaCosto As Boolean
        Get
            Return _SiCosto
        End Get
        Set(ByVal value As Boolean)
            _SiCosto = value
        End Set
    End Property
#End Region


End Class
