' Version: 694, 28-sep.-2018 12:57
' Version: 691, 17-sep.-2018 20:53
' Version: 690, 13-sep.-2018 12:20
' Version: 689, 12-sep.-2018 13:17
' Version: 689, 12-sep.-2018 13:11
' Version: 660, 5-jul.-2018 12:55
' Version: 636, 9-mar.-2018 13:03
' Version: 634, 2-mar.-2018 18:51
'♥ versión: 586, 6-oct.-2017 07:11
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fFormaPago
    Inherits AdvanceForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fFormaPago))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.TxtPrecio = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.CmdCancel = New SMDPpal.BotonEstandar()
		Me.Grd = New System.Windows.Forms.DataGridView()
		Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.forma = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.notas = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.cambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.id_banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.id_banco_consig = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.fecha_consig = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.store_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.store_id_cot_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.store_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.store_saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.id_posfe = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tip_ide_ter = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ide_ter = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.nombres_ter = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CmdNueva = New SMDPpal.BotonEstandar()
		Me.LnkEditar = New System.Windows.Forms.LinkLabel()
		Me.LnkEliminar = New System.Windows.Forms.LinkLabel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.LblPagado = New System.Windows.Forms.Label()
		Me.LblPorPagar = New System.Windows.Forms.Label()
		Me.LblValorPagar = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.LblFontRojo = New System.Windows.Forms.Label()
		Me.LblFontNegro = New System.Windows.Forms.Label()
		Me.CmdOk = New SMDPpal.BotonEstandar()
		Me.TxtPropina = New System.Windows.Forms.Label()
		Me.LblPropina = New System.Windows.Forms.Label()
		Me.LblAjuste = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.PnlPropina = New System.Windows.Forms.Panel()
		Me.PnlBilletes = New System.Windows.Forms.Panel()
		Me.PictureBox15 = New System.Windows.Forms.PictureBox()
		Me.PictureBox14 = New System.Windows.Forms.PictureBox()
		Me.PictureBox13 = New System.Windows.Forms.PictureBox()
		Me.PictureBox12 = New System.Windows.Forms.PictureBox()
		Me.PictureBox11 = New System.Windows.Forms.PictureBox()
		Me.PictureBox10 = New System.Windows.Forms.PictureBox()
		Me.PictureBox9 = New System.Windows.Forms.PictureBox()
		Me.PictureBox8 = New System.Windows.Forms.PictureBox()
		Me.PictureBox7 = New System.Windows.Forms.PictureBox()
		Me.PictureBox6 = New System.Windows.Forms.PictureBox()
		Me.PictureBox5 = New System.Windows.Forms.PictureBox()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.PictureBox0 = New System.Windows.Forms.PictureBox()
		Me.CmdCre = New SMDPpal.BotonEstandar()
		Me.CmdDeb = New SMDPpal.BotonEstandar()
		Me.CmdChe = New SMDPpal.BotonEstandar()
		Me.CmdEfe = New SMDPpal.BotonEstandar()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TxtIva = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TxtNot = New System.Windows.Forms.TextBox()
		Me.TxtDoc = New System.Windows.Forms.TextBox()
		Me.CmdTransfer = New SMDPpal.BotonEstandar()
		Me.LblBancoConsig = New System.Windows.Forms.Label()
		Me.PnlDoc = New System.Windows.Forms.Panel()
		Me.LnkSaldo = New System.Windows.Forms.LinkLabel()
		Me.cbBancos = New SMDPpal.ComboDMS()
		Me.LnkPosfe = New System.Windows.Forms.LinkLabel()
		Me.PnlConsig = New System.Windows.Forms.Panel()
		Me.cbBancosConsig = New SMDPpal.ComboDMS()
		Me.LblLicPosfe = New System.Windows.Forms.Label()
		Me.LstForma = New System.Windows.Forms.ComboBox()
		Me.CmdBono = New SMDPpal.BotonEstandar()
		Me.PnlFechaConsig = New System.Windows.Forms.Panel()
		Me.TxtFechaConsig = New System.Windows.Forms.DateTimePicker()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.PnlStore = New System.Windows.Forms.Panel()
		Me.LblStoreSaldo = New System.Windows.Forms.Label()
		Me.LnkBuscarStore = New System.Windows.Forms.LinkLabel()
		Me.LblStoreID = New System.Windows.Forms.Label()
		Me.LblStoreTipo = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.LblPendiente = New SMDPpal.BotonEstandar()
		Me.CmdConti = New SMDPpal.BotonEstandar()
		Me.LnkPagoTerceros = New System.Windows.Forms.LinkLabel()
		Me.LblIdForma = New System.Windows.Forms.Label()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PnlPropina.SuspendLayout()
		Me.PnlBilletes.SuspendLayout()
		CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox0, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PnlDoc.SuspendLayout()
		Me.PnlConsig.SuspendLayout()
		Me.PnlFechaConsig.SuspendLayout()
		Me.PnlStore.SuspendLayout()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(728, 0)
		'
		'TxtPrecio
		'
		Me.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtPrecio.Location = New System.Drawing.Point(325, 49)
		Me.TxtPrecio.Name = "TxtPrecio"
		Me.TxtPrecio.Size = New System.Drawing.Size(199, 22)
		Me.TxtPrecio.TabIndex = 2
		Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(209, 53)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(91, 16)
		Me.Label9.TabIndex = 17
		Me.Label9.Text = "Valor a Pagar"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'CmdCancel
		'
		Me.CmdCancel.BackColor = System.Drawing.Color.White
		Me.CmdCancel.BackgroundImage = CType(resources.GetObject("CmdCancel.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdCancel.ForeColor = System.Drawing.Color.White
		Me.CmdCancel.Location = New System.Drawing.Point(205, 237)
		Me.CmdCancel.Name = "CmdCancel"
		Me.CmdCancel.Size = New System.Drawing.Size(75, 89)
		Me.CmdCancel.TabIndex = 7
		Me.CmdCancel.Text = "Cancelar"
		Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancel.UseVisualStyleBackColor = True
		'
		'Grd
		'
		Me.Grd.AllowUserToAddRows = False
		Me.Grd.AllowUserToDeleteRows = False
		Me.Grd.AllowUserToResizeRows = False
		Me.Grd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.Grd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.Grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.Grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.forma, Me.valor, Me.iva, Me.documento, Me.notas, Me.cambio, Me.banco, Me.id_banco, Me.id_banco_consig, Me.fecha_consig, Me.store_tipo, Me.store_id_cot_tipo, Me.store_id, Me.store_saldo, Me.id_posfe, Me.tip_ide_ter, Me.ide_ter, Me.nombres_ter})
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.Grd.DefaultCellStyle = DataGridViewCellStyle2
		Me.Grd.Location = New System.Drawing.Point(15, 329)
		Me.Grd.MultiSelect = False
		Me.Grd.Name = "Grd"
		Me.Grd.ReadOnly = True
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.Grd.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.Grd.RowHeadersVisible = False
		Me.Grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.Grd.Size = New System.Drawing.Size(507, 117)
		Me.Grd.TabIndex = 6
		'
		'id
		'
		Me.id.HeaderText = "id"
		Me.id.Name = "id"
		Me.id.ReadOnly = True
		Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.id.Visible = False
		Me.id.Width = 330
		'
		'forma
		'
		Me.forma.DataPropertyName = "numero"
		Me.forma.HeaderText = "Forma Pago"
		Me.forma.Name = "forma"
		Me.forma.ReadOnly = True
		Me.forma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.forma.Width = 200
		'
		'valor
		'
		Me.valor.HeaderText = "Valor"
		Me.valor.Name = "valor"
		Me.valor.ReadOnly = True
		Me.valor.Width = 150
		'
		'iva
		'
		Me.iva.HeaderText = "Iva"
		Me.iva.Name = "iva"
		Me.iva.ReadOnly = True
		Me.iva.Visible = False
		Me.iva.Width = 50
		'
		'documento
		'
		Me.documento.HeaderText = "Docto"
		Me.documento.Name = "documento"
		Me.documento.ReadOnly = True
		Me.documento.Width = 50
		'
		'notas
		'
		Me.notas.HeaderText = "Notas"
		Me.notas.Name = "notas"
		Me.notas.ReadOnly = True
		Me.notas.Width = 140
		'
		'cambio
		'
		Me.cambio.HeaderText = "cambio"
		Me.cambio.Name = "cambio"
		Me.cambio.ReadOnly = True
		Me.cambio.Visible = False
		'
		'banco
		'
		Me.banco.HeaderText = "banco"
		Me.banco.Name = "banco"
		Me.banco.ReadOnly = True
		'
		'id_banco
		'
		Me.id_banco.HeaderText = "id_banco"
		Me.id_banco.Name = "id_banco"
		Me.id_banco.ReadOnly = True
		Me.id_banco.Visible = False
		'
		'id_banco_consig
		'
		Me.id_banco_consig.HeaderText = "id_banco_consig"
		Me.id_banco_consig.Name = "id_banco_consig"
		Me.id_banco_consig.ReadOnly = True
		Me.id_banco_consig.Visible = False
		'
		'fecha_consig
		'
		Me.fecha_consig.HeaderText = "Fec/Consig"
		Me.fecha_consig.Name = "fecha_consig"
		Me.fecha_consig.ReadOnly = True
		'
		'store_tipo
		'
		Me.store_tipo.HeaderText = "store_tipo"
		Me.store_tipo.Name = "store_tipo"
		Me.store_tipo.ReadOnly = True
		Me.store_tipo.Visible = False
		'
		'store_id_cot_tipo
		'
		Me.store_id_cot_tipo.HeaderText = "store_id_cot_tipo"
		Me.store_id_cot_tipo.Name = "store_id_cot_tipo"
		Me.store_id_cot_tipo.ReadOnly = True
		Me.store_id_cot_tipo.Visible = False
		'
		'store_id
		'
		Me.store_id.HeaderText = "store_id"
		Me.store_id.Name = "store_id"
		Me.store_id.ReadOnly = True
		Me.store_id.Visible = False
		'
		'store_saldo
		'
		Me.store_saldo.HeaderText = "store_saldo"
		Me.store_saldo.Name = "store_saldo"
		Me.store_saldo.ReadOnly = True
		Me.store_saldo.Visible = False
		'
		'id_posfe
		'
		Me.id_posfe.HeaderText = "id_posfe"
		Me.id_posfe.Name = "id_posfe"
		Me.id_posfe.ReadOnly = True
		'
		'tip_ide_ter
		'
		Me.tip_ide_ter.HeaderText = "tip_ide_ter"
		Me.tip_ide_ter.Name = "tip_ide_ter"
		Me.tip_ide_ter.ReadOnly = True
		'
		'ide_ter
		'
		Me.ide_ter.HeaderText = "ide_ter"
		Me.ide_ter.Name = "ide_ter"
		Me.ide_ter.ReadOnly = True
		'
		'nombres_ter
		'
		Me.nombres_ter.HeaderText = "nombres_ter"
		Me.nombres_ter.Name = "nombres_ter"
		Me.nombres_ter.ReadOnly = True
		'
		'CmdNueva
		'
		Me.CmdNueva.BackColor = System.Drawing.Color.White
		Me.CmdNueva.BackgroundImage = CType(resources.GetObject("CmdNueva.BackgroundImage"), System.Drawing.Image)
		Me.CmdNueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdNueva.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CmdNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdNueva.ForeColor = System.Drawing.Color.White
		Me.CmdNueva.Location = New System.Drawing.Point(282, 237)
		Me.CmdNueva.Name = "CmdNueva"
		Me.CmdNueva.Size = New System.Drawing.Size(74, 89)
		Me.CmdNueva.TabIndex = 8
		Me.CmdNueva.Text = "Nueva"
		Me.CmdNueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdNueva.UseVisualStyleBackColor = True
		'
		'LnkEditar
		'
		Me.LnkEditar.AutoSize = True
		Me.LnkEditar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkEditar.Location = New System.Drawing.Point(476, 305)
		Me.LnkEditar.Name = "LnkEditar"
		Me.LnkEditar.Size = New System.Drawing.Size(34, 13)
		Me.LnkEditar.TabIndex = 7
		Me.LnkEditar.TabStop = True
		Me.LnkEditar.Text = "Editar"
		'
		'LnkEliminar
		'
		Me.LnkEliminar.AutoSize = True
		Me.LnkEliminar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkEliminar.Location = New System.Drawing.Point(474, 281)
		Me.LnkEliminar.Name = "LnkEliminar"
		Me.LnkEliminar.Size = New System.Drawing.Size(43, 13)
		Me.LnkEliminar.TabIndex = 8
		Me.LnkEliminar.TabStop = True
		Me.LnkEliminar.Text = "Eliminar"
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(276, 480)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(71, 13)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "Total Pagado"
		'
		'LblPagado
		'
		Me.LblPagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.LblPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblPagado.Location = New System.Drawing.Point(350, 477)
		Me.LblPagado.Name = "LblPagado"
		Me.LblPagado.Size = New System.Drawing.Size(171, 21)
		Me.LblPagado.TabIndex = 13
		Me.LblPagado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LblPorPagar
		'
		Me.LblPorPagar.AutoSize = True
		Me.LblPorPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblPorPagar.Location = New System.Drawing.Point(218, 17)
		Me.LblPorPagar.Name = "LblPorPagar"
		Me.LblPorPagar.Size = New System.Drawing.Size(69, 16)
		Me.LblPorPagar.TabIndex = 12
		Me.LblPorPagar.Text = "Por Pagar"
		'
		'LblValorPagar
		'
		Me.LblValorPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.LblValorPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblValorPagar.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.LblValorPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblValorPagar.Location = New System.Drawing.Point(350, 453)
		Me.LblValorPagar.Name = "LblValorPagar"
		Me.LblValorPagar.Size = New System.Drawing.Size(171, 21)
		Me.LblValorPagar.TabIndex = 10
		Me.LblValorPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(276, 458)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(71, 13)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Valor a Pagar"
		'
		'LblFontRojo
		'
		Me.LblFontRojo.AutoSize = True
		Me.LblFontRojo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblFontRojo.ForeColor = System.Drawing.Color.Red
		Me.LblFontRojo.Location = New System.Drawing.Point(251, 401)
		Me.LblFontRojo.Name = "LblFontRojo"
		Me.LblFontRojo.Size = New System.Drawing.Size(75, 13)
		Me.LblFontRojo.TabIndex = 15
		Me.LblFontRojo.Text = "LblFontRojo"
		Me.LblFontRojo.Visible = False
		'
		'LblFontNegro
		'
		Me.LblFontNegro.AutoSize = True
		Me.LblFontNegro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblFontNegro.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LblFontNegro.Location = New System.Drawing.Point(113, 401)
		Me.LblFontNegro.Name = "LblFontNegro"
		Me.LblFontNegro.Size = New System.Drawing.Size(83, 13)
		Me.LblFontNegro.TabIndex = 16
		Me.LblFontNegro.Text = "LblFontNegro"
		Me.LblFontNegro.Visible = False
		'
		'CmdOk
		'
		Me.CmdOk.BackColor = System.Drawing.Color.White
		Me.CmdOk.BackgroundImage = CType(resources.GetObject("CmdOk.BackgroundImage"), System.Drawing.Image)
		Me.CmdOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdOk.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdOk.ForeColor = System.Drawing.Color.White
		Me.CmdOk.Image = CType(resources.GetObject("CmdOk.Image"), System.Drawing.Image)
		Me.CmdOk.Location = New System.Drawing.Point(359, 237)
		Me.CmdOk.Name = "CmdOk"
		Me.CmdOk.Size = New System.Drawing.Size(98, 89)
		Me.CmdOk.TabIndex = 6
		Me.CmdOk.Text = "Aceptar"
		Me.CmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdOk.UseVisualStyleBackColor = False
		'
		'TxtPropina
		'
		Me.TxtPropina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtPropina.Cursor = System.Windows.Forms.Cursors.Hand
		Me.TxtPropina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtPropina.Location = New System.Drawing.Point(76, 3)
		Me.TxtPropina.Name = "TxtPropina"
		Me.TxtPropina.Size = New System.Drawing.Size(140, 21)
		Me.TxtPropina.TabIndex = 27
		Me.TxtPropina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LblPropina
		'
		Me.LblPropina.AutoSize = True
		Me.LblPropina.Location = New System.Drawing.Point(5, 8)
		Me.LblPropina.Name = "LblPropina"
		Me.LblPropina.Size = New System.Drawing.Size(43, 13)
		Me.LblPropina.TabIndex = 26
		Me.LblPropina.Text = "Propina"
		'
		'LblAjuste
		'
		Me.LblAjuste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblAjuste.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.LblAjuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAjuste.Location = New System.Drawing.Point(76, 27)
		Me.LblAjuste.Name = "LblAjuste"
		Me.LblAjuste.Size = New System.Drawing.Size(140, 21)
		Me.LblAjuste.TabIndex = 29
		Me.LblAjuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(5, 30)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(36, 13)
		Me.Label7.TabIndex = 28
		Me.Label7.Text = "Ajuste"
		'
		'PnlPropina
		'
		Me.PnlPropina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.PnlPropina.Controls.Add(Me.LblAjuste)
		Me.PnlPropina.Controls.Add(Me.LblPropina)
		Me.PnlPropina.Controls.Add(Me.TxtPropina)
		Me.PnlPropina.Controls.Add(Me.Label7)
		Me.PnlPropina.Location = New System.Drawing.Point(15, 451)
		Me.PnlPropina.Name = "PnlPropina"
		Me.PnlPropina.Size = New System.Drawing.Size(230, 50)
		Me.PnlPropina.TabIndex = 32
		'
		'PnlBilletes
		'
		Me.PnlBilletes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PnlBilletes.Controls.Add(Me.PictureBox15)
		Me.PnlBilletes.Controls.Add(Me.PictureBox14)
		Me.PnlBilletes.Controls.Add(Me.PictureBox13)
		Me.PnlBilletes.Controls.Add(Me.PictureBox12)
		Me.PnlBilletes.Controls.Add(Me.PictureBox11)
		Me.PnlBilletes.Controls.Add(Me.PictureBox10)
		Me.PnlBilletes.Controls.Add(Me.PictureBox9)
		Me.PnlBilletes.Controls.Add(Me.PictureBox8)
		Me.PnlBilletes.Controls.Add(Me.PictureBox7)
		Me.PnlBilletes.Controls.Add(Me.PictureBox6)
		Me.PnlBilletes.Controls.Add(Me.PictureBox5)
		Me.PnlBilletes.Controls.Add(Me.PictureBox4)
		Me.PnlBilletes.Controls.Add(Me.PictureBox3)
		Me.PnlBilletes.Controls.Add(Me.PictureBox2)
		Me.PnlBilletes.Controls.Add(Me.PictureBox1)
		Me.PnlBilletes.Controls.Add(Me.PictureBox0)
		Me.PnlBilletes.Location = New System.Drawing.Point(530, 3)
		Me.PnlBilletes.Name = "PnlBilletes"
		Me.PnlBilletes.Size = New System.Drawing.Size(217, 500)
		Me.PnlBilletes.TabIndex = 33
		Me.PnlBilletes.Visible = False
		'
		'PictureBox15
		'
		Me.PictureBox15.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox15.Location = New System.Drawing.Point(110, 437)
		Me.PictureBox15.Name = "PictureBox15"
		Me.PictureBox15.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox15.TabIndex = 167
		Me.PictureBox15.TabStop = False
		Me.PictureBox15.Visible = False
		'
		'PictureBox14
		'
		Me.PictureBox14.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox14.Location = New System.Drawing.Point(110, 375)
		Me.PictureBox14.Name = "PictureBox14"
		Me.PictureBox14.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox14.TabIndex = 166
		Me.PictureBox14.TabStop = False
		Me.PictureBox14.Visible = False
		'
		'PictureBox13
		'
		Me.PictureBox13.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox13.Location = New System.Drawing.Point(110, 313)
		Me.PictureBox13.Name = "PictureBox13"
		Me.PictureBox13.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox13.TabIndex = 165
		Me.PictureBox13.TabStop = False
		Me.PictureBox13.Visible = False
		'
		'PictureBox12
		'
		Me.PictureBox12.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox12.Location = New System.Drawing.Point(110, 251)
		Me.PictureBox12.Name = "PictureBox12"
		Me.PictureBox12.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox12.TabIndex = 164
		Me.PictureBox12.TabStop = False
		Me.PictureBox12.Visible = False
		'
		'PictureBox11
		'
		Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox11.Location = New System.Drawing.Point(110, 189)
		Me.PictureBox11.Name = "PictureBox11"
		Me.PictureBox11.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox11.TabIndex = 163
		Me.PictureBox11.TabStop = False
		Me.PictureBox11.Visible = False
		'
		'PictureBox10
		'
		Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox10.Location = New System.Drawing.Point(110, 127)
		Me.PictureBox10.Name = "PictureBox10"
		Me.PictureBox10.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox10.TabIndex = 162
		Me.PictureBox10.TabStop = False
		Me.PictureBox10.Visible = False
		'
		'PictureBox9
		'
		Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox9.Location = New System.Drawing.Point(110, 65)
		Me.PictureBox9.Name = "PictureBox9"
		Me.PictureBox9.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox9.TabIndex = 161
		Me.PictureBox9.TabStop = False
		Me.PictureBox9.Visible = False
		'
		'PictureBox8
		'
		Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox8.Location = New System.Drawing.Point(110, 3)
		Me.PictureBox8.Name = "PictureBox8"
		Me.PictureBox8.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox8.TabIndex = 160
		Me.PictureBox8.TabStop = False
		Me.PictureBox8.Visible = False
		'
		'PictureBox7
		'
		Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox7.Location = New System.Drawing.Point(4, 437)
		Me.PictureBox7.Name = "PictureBox7"
		Me.PictureBox7.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox7.TabIndex = 158
		Me.PictureBox7.TabStop = False
		Me.PictureBox7.Visible = False
		'
		'PictureBox6
		'
		Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox6.Location = New System.Drawing.Point(4, 375)
		Me.PictureBox6.Name = "PictureBox6"
		Me.PictureBox6.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox6.TabIndex = 156
		Me.PictureBox6.TabStop = False
		Me.PictureBox6.Visible = False
		'
		'PictureBox5
		'
		Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox5.Location = New System.Drawing.Point(4, 313)
		Me.PictureBox5.Name = "PictureBox5"
		Me.PictureBox5.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox5.TabIndex = 154
		Me.PictureBox5.TabStop = False
		Me.PictureBox5.Visible = False
		'
		'PictureBox4
		'
		Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox4.Location = New System.Drawing.Point(4, 251)
		Me.PictureBox4.Name = "PictureBox4"
		Me.PictureBox4.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox4.TabIndex = 152
		Me.PictureBox4.TabStop = False
		Me.PictureBox4.Visible = False
		'
		'PictureBox3
		'
		Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox3.Location = New System.Drawing.Point(4, 189)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox3.TabIndex = 150
		Me.PictureBox3.TabStop = False
		Me.PictureBox3.Visible = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox2.Location = New System.Drawing.Point(4, 127)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 148
		Me.PictureBox2.TabStop = False
		Me.PictureBox2.Visible = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox1.Location = New System.Drawing.Point(4, 65)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 146
		Me.PictureBox1.TabStop = False
		Me.PictureBox1.Visible = False
		'
		'PictureBox0
		'
		Me.PictureBox0.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox0.Location = New System.Drawing.Point(4, 3)
		Me.PictureBox0.Name = "PictureBox0"
		Me.PictureBox0.Size = New System.Drawing.Size(103, 61)
		Me.PictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox0.TabIndex = 144
		Me.PictureBox0.TabStop = False
		Me.PictureBox0.Visible = False
		'
		'CmdCre
		'
		Me.CmdCre.BackColor = System.Drawing.Color.White
		Me.CmdCre.BackgroundImage = CType(resources.GetObject("CmdCre.BackgroundImage"), System.Drawing.Image)
		Me.CmdCre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCre.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CmdCre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCre.ForeColor = System.Drawing.Color.White
		Me.CmdCre.Location = New System.Drawing.Point(107, 100)
		Me.CmdCre.Name = "CmdCre"
		Me.CmdCre.Size = New System.Drawing.Size(89, 90)
		Me.CmdCre.TabIndex = 21
		Me.CmdCre.Tag = "3"
		Me.CmdCre.Text = "T/Crédito F4"
		Me.CmdCre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCre.UseVisualStyleBackColor = False
		'
		'CmdDeb
		'
		Me.CmdDeb.BackColor = System.Drawing.Color.White
		Me.CmdDeb.BackgroundImage = CType(resources.GetObject("CmdDeb.BackgroundImage"), System.Drawing.Image)
		Me.CmdDeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdDeb.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CmdDeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdDeb.ForeColor = System.Drawing.Color.White
		Me.CmdDeb.Location = New System.Drawing.Point(15, 100)
		Me.CmdDeb.Name = "CmdDeb"
		Me.CmdDeb.Size = New System.Drawing.Size(89, 90)
		Me.CmdDeb.TabIndex = 20
		Me.CmdDeb.Tag = "2"
		Me.CmdDeb.Text = "T/Débito F3"
		Me.CmdDeb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdDeb.UseVisualStyleBackColor = False
		'
		'CmdChe
		'
		Me.CmdChe.BackColor = System.Drawing.Color.White
		Me.CmdChe.BackgroundImage = CType(resources.GetObject("CmdChe.BackgroundImage"), System.Drawing.Image)
		Me.CmdChe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdChe.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CmdChe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdChe.ForeColor = System.Drawing.Color.White
		Me.CmdChe.Location = New System.Drawing.Point(107, 3)
		Me.CmdChe.Name = "CmdChe"
		Me.CmdChe.Size = New System.Drawing.Size(89, 90)
		Me.CmdChe.TabIndex = 19
		Me.CmdChe.Tag = "1"
		Me.CmdChe.Text = "Cheque F2"
		Me.CmdChe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdChe.UseVisualStyleBackColor = False
		'
		'CmdEfe
		'
		Me.CmdEfe.BackColor = System.Drawing.Color.White
		Me.CmdEfe.BackgroundImage = CType(resources.GetObject("CmdEfe.BackgroundImage"), System.Drawing.Image)
		Me.CmdEfe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdEfe.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CmdEfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdEfe.ForeColor = System.Drawing.Color.White
		Me.CmdEfe.Location = New System.Drawing.Point(15, 3)
		Me.CmdEfe.Name = "CmdEfe"
		Me.CmdEfe.Size = New System.Drawing.Size(89, 90)
		Me.CmdEfe.TabIndex = 18
		Me.CmdEfe.Tag = "0"
		Me.CmdEfe.Text = "Efectivo F1"
		Me.CmdEfe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdEfe.UseVisualStyleBackColor = False
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(8, 53)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(38, 13)
		Me.Label6.TabIndex = 6
		Me.Label6.Text = "Banco"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(201, 7)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(22, 13)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = "Iva"
		'
		'TxtIva
		'
		Me.TxtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtIva.Location = New System.Drawing.Point(229, 4)
		Me.TxtIva.Name = "TxtIva"
		Me.TxtIva.Size = New System.Drawing.Size(84, 20)
		Me.TxtIva.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 32)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Notas"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(7, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(51, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Doc/Che"
		'
		'TxtNot
		'
		Me.TxtNot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtNot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtNot.Location = New System.Drawing.Point(69, 28)
		Me.TxtNot.MaxLength = 100
		Me.TxtNot.Name = "TxtNot"
		Me.TxtNot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TxtNot.Size = New System.Drawing.Size(244, 20)
		Me.TxtNot.TabIndex = 2
		'
		'TxtDoc
		'
		Me.TxtDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtDoc.Location = New System.Drawing.Point(69, 5)
		Me.TxtDoc.MaxLength = 30
		Me.TxtDoc.Name = "TxtDoc"
		Me.TxtDoc.Size = New System.Drawing.Size(126, 20)
		Me.TxtDoc.TabIndex = 0
		'
		'CmdTransfer
		'
		Me.CmdTransfer.BackColor = System.Drawing.Color.White
		Me.CmdTransfer.BackgroundImage = CType(resources.GetObject("CmdTransfer.BackgroundImage"), System.Drawing.Image)
		Me.CmdTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdTransfer.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CmdTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdTransfer.ForeColor = System.Drawing.Color.White
		Me.CmdTransfer.Location = New System.Drawing.Point(15, 199)
		Me.CmdTransfer.Name = "CmdTransfer"
		Me.CmdTransfer.Size = New System.Drawing.Size(89, 90)
		Me.CmdTransfer.TabIndex = 36
		Me.CmdTransfer.Tag = "4"
		Me.CmdTransfer.Text = "Trans/Con F5"
		Me.CmdTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdTransfer.UseVisualStyleBackColor = False
		'
		'LblBancoConsig
		'
		Me.LblBancoConsig.AutoSize = True
		Me.LblBancoConsig.Location = New System.Drawing.Point(11, 7)
		Me.LblBancoConsig.Name = "LblBancoConsig"
		Me.LblBancoConsig.Size = New System.Drawing.Size(91, 13)
		Me.LblBancoConsig.TabIndex = 38
		Me.LblBancoConsig.Text = "Banco que recibe"
		'
		'PnlDoc
		'
		Me.PnlDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlDoc.Controls.Add(Me.LnkSaldo)
		Me.PnlDoc.Controls.Add(Me.cbBancos)
		Me.PnlDoc.Controls.Add(Me.Label6)
		Me.PnlDoc.Controls.Add(Me.TxtDoc)
		Me.PnlDoc.Controls.Add(Me.Label4)
		Me.PnlDoc.Controls.Add(Me.TxtNot)
		Me.PnlDoc.Controls.Add(Me.TxtIva)
		Me.PnlDoc.Controls.Add(Me.Label1)
		Me.PnlDoc.Controls.Add(Me.Label2)
		Me.PnlDoc.Location = New System.Drawing.Point(206, 86)
		Me.PnlDoc.Name = "PnlDoc"
		Me.PnlDoc.Size = New System.Drawing.Size(318, 80)
		Me.PnlDoc.TabIndex = 3
		'
		'LnkSaldo
		'
		Me.LnkSaldo.AutoSize = True
		Me.LnkSaldo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkSaldo.Location = New System.Drawing.Point(276, 53)
		Me.LnkSaldo.Name = "LnkSaldo"
		Me.LnkSaldo.Size = New System.Drawing.Size(34, 13)
		Me.LnkSaldo.TabIndex = 7
		Me.LnkSaldo.TabStop = True
		Me.LnkSaldo.Text = "Saldo"
		'
		'cbBancos
		'
		Me.cbBancos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbBancos.Location = New System.Drawing.Point(69, 51)
		Me.cbBancos.Margin = New System.Windows.Forms.Padding(4)
		Me.cbBancos.Name = "cbBancos"
		Me.cbBancos.Size = New System.Drawing.Size(201, 21)
		Me.cbBancos.TabIndex = 3
		'
		'LnkPosfe
		'
		Me.LnkPosfe.AutoSize = True
		Me.LnkPosfe.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkPosfe.Location = New System.Drawing.Point(423, 72)
		Me.LnkPosfe.Name = "LnkPosfe"
		Me.LnkPosfe.Size = New System.Drawing.Size(99, 13)
		Me.LnkPosfe.TabIndex = 8
		Me.LnkPosfe.TabStop = True
		Me.LnkPosfe.Text = "Buscar posfechado"
		'
		'PnlConsig
		'
		Me.PnlConsig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlConsig.Controls.Add(Me.cbBancosConsig)
		Me.PnlConsig.Controls.Add(Me.LblBancoConsig)
		Me.PnlConsig.Location = New System.Drawing.Point(206, 203)
		Me.PnlConsig.Name = "PnlConsig"
		Me.PnlConsig.Size = New System.Drawing.Size(317, 30)
		Me.PnlConsig.TabIndex = 5
		'
		'cbBancosConsig
		'
		Me.cbBancosConsig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.cbBancosConsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbBancosConsig.Location = New System.Drawing.Point(109, 3)
		Me.cbBancosConsig.Margin = New System.Windows.Forms.Padding(4)
		Me.cbBancosConsig.Name = "cbBancosConsig"
		Me.cbBancosConsig.Size = New System.Drawing.Size(204, 21)
		Me.cbBancosConsig.TabIndex = 0
		'
		'LblLicPosfe
		'
		Me.LblLicPosfe.AutoSize = True
		Me.LblLicPosfe.ForeColor = System.Drawing.Color.Gray
		Me.LblLicPosfe.Location = New System.Drawing.Point(116, 7)
		Me.LblLicPosfe.Name = "LblLicPosfe"
		Me.LblLicPosfe.Size = New System.Drawing.Size(179, 13)
		Me.LblLicPosfe.TabIndex = 1
		Me.LblLicPosfe.Text = "Cheques posf requiere licencia 1029"
		Me.LblLicPosfe.Visible = False
		'
		'LstForma
		'
		Me.LstForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.LstForma.FormattingEnabled = True
		Me.LstForma.Location = New System.Drawing.Point(15, 297)
		Me.LstForma.Name = "LstForma"
		Me.LstForma.Size = New System.Drawing.Size(159, 21)
		Me.LstForma.TabIndex = 41
		'
		'CmdBono
		'
		Me.CmdBono.BackColor = System.Drawing.Color.White
		Me.CmdBono.BackgroundImage = CType(resources.GetObject("CmdBono.BackgroundImage"), System.Drawing.Image)
		Me.CmdBono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdBono.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CmdBono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdBono.ForeColor = System.Drawing.Color.White
		Me.CmdBono.Location = New System.Drawing.Point(107, 199)
		Me.CmdBono.Name = "CmdBono"
		Me.CmdBono.Size = New System.Drawing.Size(89, 90)
		Me.CmdBono.TabIndex = 42
		Me.CmdBono.Tag = "5"
		Me.CmdBono.Text = "Bonos F6"
		Me.CmdBono.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdBono.UseVisualStyleBackColor = False
		'
		'PnlFechaConsig
		'
		Me.PnlFechaConsig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlFechaConsig.Controls.Add(Me.LblLicPosfe)
		Me.PnlFechaConsig.Controls.Add(Me.TxtFechaConsig)
		Me.PnlFechaConsig.Controls.Add(Me.Label8)
		Me.PnlFechaConsig.Location = New System.Drawing.Point(206, 169)
		Me.PnlFechaConsig.Name = "PnlFechaConsig"
		Me.PnlFechaConsig.Size = New System.Drawing.Size(317, 30)
		Me.PnlFechaConsig.TabIndex = 4
		Me.PnlFechaConsig.Visible = False
		'
		'TxtFechaConsig
		'
		Me.TxtFechaConsig.Location = New System.Drawing.Point(109, 3)
		Me.TxtFechaConsig.Name = "TxtFechaConsig"
		Me.TxtFechaConsig.Size = New System.Drawing.Size(201, 20)
		Me.TxtFechaConsig.TabIndex = 0
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(11, 7)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(87, 13)
		Me.Label8.TabIndex = 38
		Me.Label8.Text = "Fecha Consignar"
		'
		'PnlStore
		'
		Me.PnlStore.Controls.Add(Me.LblStoreSaldo)
		Me.PnlStore.Controls.Add(Me.LnkBuscarStore)
		Me.PnlStore.Controls.Add(Me.LblStoreID)
		Me.PnlStore.Controls.Add(Me.LblStoreTipo)
		Me.PnlStore.Controls.Add(Me.Label10)
		Me.PnlStore.Location = New System.Drawing.Point(146, 332)
		Me.PnlStore.Name = "PnlStore"
		Me.PnlStore.Size = New System.Drawing.Size(329, 100)
		Me.PnlStore.TabIndex = 43
		Me.PnlStore.Visible = False
		'
		'LblStoreSaldo
		'
		Me.LblStoreSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblStoreSaldo.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LblStoreSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblStoreSaldo.Location = New System.Drawing.Point(151, 50)
		Me.LblStoreSaldo.Name = "LblStoreSaldo"
		Me.LblStoreSaldo.Size = New System.Drawing.Size(118, 19)
		Me.LblStoreSaldo.TabIndex = 45
		Me.LblStoreSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LnkBuscarStore
		'
		Me.LnkBuscarStore.AutoSize = True
		Me.LnkBuscarStore.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkBuscarStore.Location = New System.Drawing.Point(28, 82)
		Me.LnkBuscarStore.Name = "LnkBuscarStore"
		Me.LnkBuscarStore.Size = New System.Drawing.Size(273, 13)
		Me.LnkBuscarStore.TabIndex = 44
		Me.LnkBuscarStore.TabStop = True
		Me.LnkBuscarStore.Text = "Buscar Créditos del Cliente (Devoluciones, Recibos, NC)"
		'
		'LblStoreID
		'
		Me.LblStoreID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblStoreID.Cursor = System.Windows.Forms.Cursors.Default
		Me.LblStoreID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblStoreID.Location = New System.Drawing.Point(61, 50)
		Me.LblStoreID.Name = "LblStoreID"
		Me.LblStoreID.Size = New System.Drawing.Size(84, 19)
		Me.LblStoreID.TabIndex = 3
		Me.LblStoreID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LblStoreTipo
		'
		Me.LblStoreTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblStoreTipo.Cursor = System.Windows.Forms.Cursors.Default
		Me.LblStoreTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblStoreTipo.Location = New System.Drawing.Point(61, 27)
		Me.LblStoreTipo.Name = "LblStoreTipo"
		Me.LblStoreTipo.Size = New System.Drawing.Size(208, 19)
		Me.LblStoreTipo.TabIndex = 2
		Me.LblStoreTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(81, 8)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(166, 13)
		Me.Label10.TabIndex = 1
		Me.Label10.Text = "Documento Crédito Seleccionado"
		'
		'LblPendiente
		'
		Me.LblPendiente.BackColor = System.Drawing.Color.White
		Me.LblPendiente.BackgroundImage = CType(resources.GetObject("LblPendiente.BackgroundImage"), System.Drawing.Image)
		Me.LblPendiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.LblPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LblPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblPendiente.ForeColor = System.Drawing.Color.White
		Me.LblPendiente.Location = New System.Drawing.Point(325, 3)
		Me.LblPendiente.Name = "LblPendiente"
		Me.LblPendiente.Size = New System.Drawing.Size(197, 45)
		Me.LblPendiente.TabIndex = 44
		Me.LblPendiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.LblPendiente.UseVisualStyleBackColor = True
		'
		'CmdConti
		'
		Me.CmdConti.BackColor = System.Drawing.Color.White
		Me.CmdConti.BackgroundImage = CType(resources.GetObject("CmdConti.BackgroundImage"), System.Drawing.Image)
		Me.CmdConti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdConti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdConti.ForeColor = System.Drawing.Color.White
		Me.CmdConti.Location = New System.Drawing.Point(463, 239)
		Me.CmdConti.Name = "CmdConti"
		Me.CmdConti.Size = New System.Drawing.Size(62, 32)
		Me.CmdConti.TabIndex = 45
		Me.CmdConti.Text = "Continuar"
		Me.CmdConti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdConti.UseVisualStyleBackColor = False
		'
		'LnkPagoTerceros
		'
		Me.LnkPagoTerceros.AutoSize = True
		Me.LnkPagoTerceros.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkPagoTerceros.Location = New System.Drawing.Point(323, 72)
		Me.LnkPagoTerceros.Name = "LnkPagoTerceros"
		Me.LnkPagoTerceros.Size = New System.Drawing.Size(73, 13)
		Me.LnkPagoTerceros.TabIndex = 46
		Me.LnkPagoTerceros.TabStop = True
		Me.LnkPagoTerceros.Text = "Pago terceros"
		'
		'LblIdForma
		'
		Me.LblIdForma.AutoSize = True
		Me.LblIdForma.ForeColor = System.Drawing.Color.Red
		Me.LblIdForma.Location = New System.Drawing.Point(176, 302)
		Me.LblIdForma.Name = "LblIdForma"
		Me.LblIdForma.Size = New System.Drawing.Size(18, 13)
		Me.LblIdForma.TabIndex = 47
		Me.LblIdForma.Text = "ID"
		Me.ToolTipAdvance.SetToolTip(Me.LblIdForma, "Id de la forma de pago")
		'
		'fFormaPago
		'
		Me.AcceptButton = Me.CmdOk
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.CancelButton = Me.CmdCancel
		Me.ClientSize = New System.Drawing.Size(749, 516)
		Me.ControlBox = False
		Me.Controls.Add(Me.LblIdForma)
		Me.Controls.Add(Me.LnkPagoTerceros)
		Me.Controls.Add(Me.LnkPosfe)
		Me.Controls.Add(Me.CmdConti)
		Me.Controls.Add(Me.LblPendiente)
		Me.Controls.Add(Me.PnlStore)
		Me.Controls.Add(Me.PnlFechaConsig)
		Me.Controls.Add(Me.CmdBono)
		Me.Controls.Add(Me.LstForma)
		Me.Controls.Add(Me.PnlConsig)
		Me.Controls.Add(Me.PnlDoc)
		Me.Controls.Add(Me.CmdTransfer)
		Me.Controls.Add(Me.PnlBilletes)
		Me.Controls.Add(Me.PnlPropina)
		Me.Controls.Add(Me.CmdCre)
		Me.Controls.Add(Me.CmdDeb)
		Me.Controls.Add(Me.CmdChe)
		Me.Controls.Add(Me.CmdEfe)
		Me.Controls.Add(Me.LblFontNegro)
		Me.Controls.Add(Me.LblFontRojo)
		Me.Controls.Add(Me.LblValorPagar)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.LblPorPagar)
		Me.Controls.Add(Me.LblPagado)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.LnkEliminar)
		Me.Controls.Add(Me.LnkEditar)
		Me.Controls.Add(Me.CmdNueva)
		Me.Controls.Add(Me.Grd)
		Me.Controls.Add(Me.CmdCancel)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.TxtPrecio)
		Me.Controls.Add(Me.CmdOk)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(500, 518)
		Me.Name = "fFormaPago"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Detalle del Pago"
		Me.Controls.SetChildIndex(Me.CmdOk, 0)
		Me.Controls.SetChildIndex(Me.TxtPrecio, 0)
		Me.Controls.SetChildIndex(Me.Label9, 0)
		Me.Controls.SetChildIndex(Me.CmdCancel, 0)
		Me.Controls.SetChildIndex(Me.Grd, 0)
		Me.Controls.SetChildIndex(Me.CmdNueva, 0)
		Me.Controls.SetChildIndex(Me.LnkEditar, 0)
		Me.Controls.SetChildIndex(Me.LnkEliminar, 0)
		Me.Controls.SetChildIndex(Me.Label3, 0)
		Me.Controls.SetChildIndex(Me.LblPagado, 0)
		Me.Controls.SetChildIndex(Me.LblPorPagar, 0)
		Me.Controls.SetChildIndex(Me.Label5, 0)
		Me.Controls.SetChildIndex(Me.LblValorPagar, 0)
		Me.Controls.SetChildIndex(Me.LblFontRojo, 0)
		Me.Controls.SetChildIndex(Me.LblFontNegro, 0)
		Me.Controls.SetChildIndex(Me.CmdEfe, 0)
		Me.Controls.SetChildIndex(Me.CmdChe, 0)
		Me.Controls.SetChildIndex(Me.CmdDeb, 0)
		Me.Controls.SetChildIndex(Me.CmdCre, 0)
		Me.Controls.SetChildIndex(Me.PnlPropina, 0)
		Me.Controls.SetChildIndex(Me.PnlBilletes, 0)
		Me.Controls.SetChildIndex(Me.CmdTransfer, 0)
		Me.Controls.SetChildIndex(Me.PnlDoc, 0)
		Me.Controls.SetChildIndex(Me.PnlConsig, 0)
		Me.Controls.SetChildIndex(Me.LstForma, 0)
		Me.Controls.SetChildIndex(Me.CmdBono, 0)
		Me.Controls.SetChildIndex(Me.PnlFechaConsig, 0)
		Me.Controls.SetChildIndex(Me.PnlStore, 0)
		Me.Controls.SetChildIndex(Me.LblPendiente, 0)
		Me.Controls.SetChildIndex(Me.CmdConti, 0)
		Me.Controls.SetChildIndex(Me.LnkPosfe, 0)
		Me.Controls.SetChildIndex(Me.LnkPagoTerceros, 0)
		Me.Controls.SetChildIndex(Me.LblIdForma, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PnlPropina.ResumeLayout(False)
		Me.PnlPropina.PerformLayout()
		Me.PnlBilletes.ResumeLayout(False)
		CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox0, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PnlDoc.ResumeLayout(False)
		Me.PnlDoc.PerformLayout()
		Me.PnlConsig.ResumeLayout(False)
		Me.PnlConsig.PerformLayout()
		Me.PnlFechaConsig.ResumeLayout(False)
		Me.PnlFechaConsig.PerformLayout()
		Me.PnlStore.ResumeLayout(False)
		Me.PnlStore.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LnkEditar As System.Windows.Forms.LinkLabel
    Friend WithEvents LblFontRojo As System.Windows.Forms.Label
    Friend WithEvents LblFontNegro As System.Windows.Forms.Label
    Friend WithEvents PnlBilletes As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox0 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Public WithEvents Grd As System.Windows.Forms.DataGridView
    Public WithEvents PnlPropina As System.Windows.Forms.Panel
    Public WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Public WithEvents LblPagado As System.Windows.Forms.Label
    Public WithEvents LblValorPagar As System.Windows.Forms.Label
    Public WithEvents PnlDoc As System.Windows.Forms.Panel
    Public WithEvents PnlConsig As System.Windows.Forms.Panel
    Public WithEvents cbBancos As ComboDMS
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents TxtIva As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TxtNot As System.Windows.Forms.TextBox
    Public WithEvents TxtDoc As System.Windows.Forms.TextBox
    Public WithEvents cbBancosConsig As ComboDMS
    Public WithEvents LblBancoConsig As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents LblPorPagar As System.Windows.Forms.Label
    Public WithEvents LblPropina As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents TxtPropina As System.Windows.Forms.Label
    Public WithEvents LblAjuste As System.Windows.Forms.Label
    Public WithEvents LnkEliminar As System.Windows.Forms.LinkLabel
    Public WithEvents LnkSaldo As System.Windows.Forms.LinkLabel
    Public WithEvents PnlFechaConsig As System.Windows.Forms.Panel
    Friend WithEvents TxtFechaConsig As System.Windows.Forms.DateTimePicker
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblLicPosfe As System.Windows.Forms.Label
    Friend WithEvents PnlStore As System.Windows.Forms.Panel
    Friend WithEvents LnkBuscarStore As System.Windows.Forms.LinkLabel
    Public WithEvents LblStoreID As System.Windows.Forms.Label
    Public WithEvents LblStoreTipo As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents LblStoreSaldo As System.Windows.Forms.Label
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Public WithEvents CmdOk As SMDPpal.BotonEstandar
    Public WithEvents CmdCancel As SMDPpal.BotonEstandar
    Public WithEvents CmdNueva As SMDPpal.BotonEstandar
    Public WithEvents LblPendiente As SMDPpal.BotonEstandar
    Friend WithEvents CmdConti As SMDPpal.BotonEstandar
    Public WithEvents LstForma As System.Windows.Forms.ComboBox
    Public WithEvents CmdEfe As SMDPpal.BotonEstandar
    Public WithEvents CmdChe As SMDPpal.BotonEstandar
    Public WithEvents CmdCre As SMDPpal.BotonEstandar
    Public WithEvents CmdDeb As SMDPpal.BotonEstandar
    Public WithEvents CmdTransfer As SMDPpal.BotonEstandar
    Public WithEvents CmdBono As SMDPpal.BotonEstandar
    Public WithEvents LnkPosfe As System.Windows.Forms.LinkLabel
    Public WithEvents LnkPagoTerceros As LinkLabel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents forma As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents iva As DataGridViewTextBoxColumn
    Friend WithEvents documento As DataGridViewTextBoxColumn
    Friend WithEvents notas As DataGridViewTextBoxColumn
    Friend WithEvents cambio As DataGridViewTextBoxColumn
    Friend WithEvents banco As DataGridViewTextBoxColumn
    Friend WithEvents id_banco As DataGridViewTextBoxColumn
    Friend WithEvents id_banco_consig As DataGridViewTextBoxColumn
    Friend WithEvents fecha_consig As DataGridViewTextBoxColumn
    Friend WithEvents store_tipo As DataGridViewTextBoxColumn
    Friend WithEvents store_id_cot_tipo As DataGridViewTextBoxColumn
    Friend WithEvents store_id As DataGridViewTextBoxColumn
    Friend WithEvents store_saldo As DataGridViewTextBoxColumn
    Friend WithEvents id_posfe As DataGridViewTextBoxColumn
    Friend WithEvents tip_ide_ter As DataGridViewTextBoxColumn
    Friend WithEvents ide_ter As DataGridViewTextBoxColumn
    Friend WithEvents nombres_ter As DataGridViewTextBoxColumn
	Public WithEvents LblIdForma As Label
End Class
