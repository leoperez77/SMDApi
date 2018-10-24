<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fBusItems
	Inherits AdvanceForm

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fBusItems))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.CmdModificar = New SMDPpal.BotonEstandar()
		Me.GrdBus = New System.Windows.Forms.DataGridView()
		Me.Cua = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Und = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.precio_sin_iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Dscto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Neto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.generico = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.grupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.subgrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.promocion = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tiene_imagen = New System.Windows.Forms.DataGridViewLinkColumn()
		Me.reservado = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Bodega = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TxtBuscarItem = New System.Windows.Forms.TextBox()
		Me.LblItem = New System.Windows.Forms.Label()
		Me.OptTodos = New System.Windows.Forms.RadioButton()
		Me.OptUsados = New System.Windows.Forms.RadioButton()
		Me.OptNuevos = New System.Windows.Forms.RadioButton()
		Me.CbModelo = New System.Windows.Forms.ComboBox()
		Me.CbLinea = New System.Windows.Forms.ComboBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.CbMarca = New System.Windows.Forms.ComboBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.LblFont = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.PicItem = New System.Windows.Forms.PictureBox()
		Me.LnkRefrescar = New System.Windows.Forms.LinkLabel()
		Me.LnkAbrir = New System.Windows.Forms.LinkLabel()
		Me.LnkAvanzado = New System.Windows.Forms.LinkLabel()
		Me.LblNegrilla = New System.Windows.Forms.Label()
		Me.LnkExcel = New System.Windows.Forms.LinkLabel()
		Me.LblStock = New System.Windows.Forms.LinkLabel()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.CmdBuscar = New SMDPpal.BotonEstandar()
		Me.BckLeerLineasColores = New System.ComponentModel.BackgroundWorker()
		Me.BackTraerStock = New System.ComponentModel.BackgroundWorker()
		Me.LblMensaje = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Pnl500 = New System.Windows.Forms.Panel()
		Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.ChkStock = New System.Windows.Forms.CheckBox()
		Me.ChkOcultarPrecio = New System.Windows.Forms.CheckBox()
		Me.TxtBuscarItem2 = New System.Windows.Forms.TextBox()
		Me.TxtCod = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.ChkPromo = New System.Windows.Forms.CheckBox()
		Me.ChkPrecioCaja = New System.Windows.Forms.CheckBox()
		Me.LnkVarios = New System.Windows.Forms.LinkLabel()
		Me.TxtDcto = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.TxtAlterna = New System.Windows.Forms.TextBox()
		Me.ChkTodos = New System.Windows.Forms.CheckBox()
		Me.ChkLimpiar = New System.Windows.Forms.CheckBox()
		Me.ChkLineaGen = New System.Windows.Forms.CheckBox()
		Me.CbTalla = New SMDPpal.ComboDMS()
		Me.CbGener = New SMDPpal.ComboDMS()
		Me.CbBod = New SMDPpal.ComboDMS()
		Me.CbProv = New SMDPpal.ComboDMS()
		Me.CbSubgrupo = New SMDPpal.ComboDMS()
		Me.CbGrupo = New SMDPpal.ComboDMS()
		Me.BckLeerItems = New System.ComponentModel.BackgroundWorker()
		Me.CbTama = New System.Windows.Forms.ComboBox()
		Me.ChkReal = New System.Windows.Forms.CheckBox()
		Me.PnlProc = New System.Windows.Forms.Panel()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.ChkSoloInicial = New System.Windows.Forms.CheckBox()
		Me.ChkPrinAct = New System.Windows.Forms.CheckBox()
		Me.CmdAnchoPred = New System.Windows.Forms.LinkLabel()
		Me.PnlOpciones = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.LnkOcultar = New System.Windows.Forms.LinkLabel()
		Me.PnlContenido = New System.Windows.Forms.GroupBox()
		Me.OptTempario = New System.Windows.Forms.RadioButton()
		Me.OptVehiculos = New System.Windows.Forms.RadioButton()
		Me.OptTempYVeh = New System.Windows.Forms.RadioButton()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.CmdCancelar = New SMDPpal.BotonEstandar()
		Me.CmdMostrarPrecios = New System.Windows.Forms.Button()
		Me.GrdNue = New SMDPpal.GridDms()
		Me.LblMas = New System.Windows.Forms.Label()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GrdBus, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		CType(Me.PicItem, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Pnl500.SuspendLayout()
		Me.PnlProc.SuspendLayout()
		Me.PnlOpciones.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.PnlContenido.SuspendLayout()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(963, 0)
		'
		'CmdModificar
		'
		Me.CmdModificar.BackColor = System.Drawing.Color.White
		Me.CmdModificar.BackgroundImage = CType(resources.GetObject("CmdModificar.BackgroundImage"), System.Drawing.Image)
		Me.CmdModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdModificar.ForeColor = System.Drawing.Color.White
		Me.CmdModificar.Location = New System.Drawing.Point(399, 15)
		Me.CmdModificar.Name = "CmdModificar"
		Me.CmdModificar.Size = New System.Drawing.Size(68, 24)
		Me.CmdModificar.TabIndex = 11
		Me.CmdModificar.Text = "Regresar"
		Me.CmdModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdModificar.UseVisualStyleBackColor = True
		'
		'GrdBus
		'
		Me.GrdBus.AllowUserToAddRows = False
		Me.GrdBus.AllowUserToDeleteRows = False
		Me.GrdBus.AllowUserToOrderColumns = True
		Me.GrdBus.AllowUserToResizeRows = False
		Me.GrdBus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.GrdBus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.GrdBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.GrdBus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cua, Me.id, Me.codigo, Me.Descripcion, Me.Und, Me.precio_sin_iva, Me.Dscto, Me.Neto, Me.iva, Me.linea, Me.generico, Me.grupo, Me.subgrupo, Me.promocion, Me.proveedor, Me.tiene_imagen, Me.reservado, Me.estado, Me.Bodega})
		DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.GrdBus.DefaultCellStyle = DataGridViewCellStyle11
		Me.GrdBus.Location = New System.Drawing.Point(3, 56)
		Me.GrdBus.MultiSelect = False
		Me.GrdBus.Name = "GrdBus"
		Me.GrdBus.ReadOnly = True
		DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.GrdBus.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
		Me.GrdBus.RowHeadersVisible = False
		Me.GrdBus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.GrdBus.Size = New System.Drawing.Size(978, 408)
		Me.GrdBus.StandardTab = True
		Me.GrdBus.TabIndex = 9
		Me.GrdBus.Visible = False
		'
		'Cua
		'
		Me.Cua.FillWeight = 20.0!
		Me.Cua.HeaderText = "Cua"
		Me.Cua.Name = "Cua"
		Me.Cua.ReadOnly = True
		Me.Cua.Width = 35
		'
		'id
		'
		Me.id.HeaderText = "id"
		Me.id.Name = "id"
		Me.id.ReadOnly = True
		Me.id.Visible = False
		'
		'codigo
		'
		Me.codigo.FillWeight = 10.0!
		Me.codigo.HeaderText = "Código"
		Me.codigo.Name = "codigo"
		Me.codigo.ReadOnly = True
		Me.codigo.Width = 70
		'
		'Descripcion
		'
		Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.Descripcion.HeaderText = "Descripción"
		Me.Descripcion.MinimumWidth = 70
		Me.Descripcion.Name = "Descripcion"
		Me.Descripcion.ReadOnly = True
		'
		'Und
		'
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Und.DefaultCellStyle = DataGridViewCellStyle2
		Me.Und.HeaderText = "U/M"
		Me.Und.Name = "Und"
		Me.Und.ReadOnly = True
		Me.Und.Width = 55
		'
		'precio_sin_iva
		'
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle3.Format = "C2"
		Me.precio_sin_iva.DefaultCellStyle = DataGridViewCellStyle3
		Me.precio_sin_iva.HeaderText = "Precio"
		Me.precio_sin_iva.Name = "precio_sin_iva"
		Me.precio_sin_iva.ReadOnly = True
		Me.precio_sin_iva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.precio_sin_iva.Width = 75
		'
		'Dscto
		'
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.Dscto.DefaultCellStyle = DataGridViewCellStyle4
		Me.Dscto.HeaderText = "Dscto"
		Me.Dscto.Name = "Dscto"
		Me.Dscto.ReadOnly = True
		Me.Dscto.Width = 50
		'
		'Neto
		'
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		Me.Neto.DefaultCellStyle = DataGridViewCellStyle5
		Me.Neto.HeaderText = "Neto"
		Me.Neto.Name = "Neto"
		Me.Neto.ReadOnly = True
		Me.Neto.Width = 75
		'
		'iva
		'
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle6.NullValue = Nothing
		Me.iva.DefaultCellStyle = DataGridViewCellStyle6
		Me.iva.HeaderText = "%Iva"
		Me.iva.Name = "iva"
		Me.iva.ReadOnly = True
		Me.iva.Width = 50
		'
		'linea
		'
		Me.linea.HeaderText = "Línea"
		Me.linea.Name = "linea"
		Me.linea.ReadOnly = True
		Me.linea.Visible = False
		'
		'generico
		'
		Me.generico.HeaderText = "Genérico"
		Me.generico.Name = "generico"
		Me.generico.ReadOnly = True
		Me.generico.Visible = False
		'
		'grupo
		'
		Me.grupo.HeaderText = "Grupo"
		Me.grupo.Name = "grupo"
		Me.grupo.ReadOnly = True
		Me.grupo.Visible = False
		'
		'subgrupo
		'
		Me.subgrupo.HeaderText = "Subgrupo"
		Me.subgrupo.Name = "subgrupo"
		Me.subgrupo.ReadOnly = True
		Me.subgrupo.Visible = False
		'
		'promocion
		'
		DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.promocion.DefaultCellStyle = DataGridViewCellStyle7
		Me.promocion.HeaderText = "Promo"
		Me.promocion.Name = "promocion"
		Me.promocion.ReadOnly = True
		Me.promocion.Width = 40
		'
		'proveedor
		'
		Me.proveedor.HeaderText = "Proveedor"
		Me.proveedor.Name = "proveedor"
		Me.proveedor.ReadOnly = True
		Me.proveedor.Width = 217
		'
		'tiene_imagen
		'
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.tiene_imagen.DefaultCellStyle = DataGridViewCellStyle8
		Me.tiene_imagen.HeaderText = "Foto"
		Me.tiene_imagen.Name = "tiene_imagen"
		Me.tiene_imagen.ReadOnly = True
		Me.tiene_imagen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.tiene_imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.tiene_imagen.Width = 30
		'
		'reservado
		'
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.reservado.DefaultCellStyle = DataGridViewCellStyle9
		Me.reservado.HeaderText = "Res"
		Me.reservado.Name = "reservado"
		Me.reservado.ReadOnly = True
		Me.reservado.Width = 30
		'
		'estado
		'
		DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.estado.DefaultCellStyle = DataGridViewCellStyle10
		Me.estado.HeaderText = "Sta"
		Me.estado.Name = "estado"
		Me.estado.ReadOnly = True
		Me.estado.Width = 30
		'
		'Bodega
		'
		Me.Bodega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.Bodega.HeaderText = "Bod"
		Me.Bodega.Name = "Bodega"
		Me.Bodega.ReadOnly = True
		Me.Bodega.Visible = False
		Me.Bodega.Width = 40
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(18, 42)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(36, 13)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Grupo"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(18, 66)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(32, 13)
		Me.Label5.TabIndex = 15
		Me.Label5.Text = "Subg"
		'
		'TxtBuscarItem
		'
		Me.TxtBuscarItem.BackColor = System.Drawing.SystemColors.Window
		Me.TxtBuscarItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtBuscarItem.Location = New System.Drawing.Point(66, 18)
		Me.TxtBuscarItem.Name = "TxtBuscarItem"
		Me.TxtBuscarItem.Size = New System.Drawing.Size(91, 20)
		Me.TxtBuscarItem.TabIndex = 0
		'
		'LblItem
		'
		Me.LblItem.AutoSize = True
		Me.LblItem.Location = New System.Drawing.Point(23, 21)
		Me.LblItem.Name = "LblItem"
		Me.LblItem.Size = New System.Drawing.Size(40, 13)
		Me.LblItem.TabIndex = 0
		Me.LblItem.Text = "Buscar"
		'
		'OptTodos
		'
		Me.OptTodos.AutoSize = True
		Me.OptTodos.Checked = True
		Me.OptTodos.Location = New System.Drawing.Point(81, 86)
		Me.OptTodos.Name = "OptTodos"
		Me.OptTodos.Size = New System.Drawing.Size(55, 17)
		Me.OptTodos.TabIndex = 10
		Me.OptTodos.TabStop = True
		Me.OptTodos.Text = "Todos"
		Me.OptTodos.UseVisualStyleBackColor = True
		'
		'OptUsados
		'
		Me.OptUsados.AutoSize = True
		Me.OptUsados.Location = New System.Drawing.Point(234, 84)
		Me.OptUsados.Name = "OptUsados"
		Me.OptUsados.Size = New System.Drawing.Size(61, 17)
		Me.OptUsados.TabIndex = 9
		Me.OptUsados.Text = "Usados"
		Me.OptUsados.UseVisualStyleBackColor = True
		'
		'OptNuevos
		'
		Me.OptNuevos.AutoSize = True
		Me.OptNuevos.Location = New System.Drawing.Point(150, 86)
		Me.OptNuevos.Name = "OptNuevos"
		Me.OptNuevos.Size = New System.Drawing.Size(62, 17)
		Me.OptNuevos.TabIndex = 8
		Me.OptNuevos.Text = "Nuevos"
		Me.OptNuevos.UseVisualStyleBackColor = True
		'
		'CbModelo
		'
		Me.CbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CbModelo.ForeColor = System.Drawing.Color.Black
		Me.CbModelo.FormattingEnabled = True
		Me.CbModelo.Location = New System.Drawing.Point(65, 55)
		Me.CbModelo.Name = "CbModelo"
		Me.CbModelo.Size = New System.Drawing.Size(236, 21)
		Me.CbModelo.TabIndex = 5
		'
		'CbLinea
		'
		Me.CbLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CbLinea.ForeColor = System.Drawing.Color.Black
		Me.CbLinea.FormattingEnabled = True
		Me.CbLinea.Location = New System.Drawing.Point(65, 31)
		Me.CbLinea.Name = "CbLinea"
		Me.CbLinea.Size = New System.Drawing.Size(236, 21)
		Me.CbLinea.TabIndex = 3
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(5, 33)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(35, 13)
		Me.Label7.TabIndex = 2
		Me.Label7.Text = "Línea"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'CbMarca
		'
		Me.CbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CbMarca.ForeColor = System.Drawing.Color.Black
		Me.CbMarca.FormattingEnabled = True
		Me.CbMarca.Location = New System.Drawing.Point(65, 7)
		Me.CbMarca.Name = "CbMarca"
		Me.CbMarca.Size = New System.Drawing.Size(236, 21)
		Me.CbMarca.TabIndex = 1
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.ForeColor = System.Drawing.Color.Black
		Me.Label15.Location = New System.Drawing.Point(5, 10)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(37, 13)
		Me.Label15.TabIndex = 0
		Me.Label15.Text = "Marca"
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Panel1
		'
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.OptTodos)
		Me.Panel1.Controls.Add(Me.OptUsados)
		Me.Panel1.Controls.Add(Me.OptNuevos)
		Me.Panel1.Controls.Add(Me.LblFont)
		Me.Panel1.Controls.Add(Me.CbMarca)
		Me.Panel1.Controls.Add(Me.CbModelo)
		Me.Panel1.Controls.Add(Me.Label15)
		Me.Panel1.Controls.Add(Me.CbLinea)
		Me.Panel1.Controls.Add(Me.Label7)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Location = New System.Drawing.Point(319, 91)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(313, 108)
		Me.Panel1.TabIndex = 26
		Me.Panel1.Visible = False
		'
		'LblFont
		'
		Me.LblFont.AutoSize = True
		Me.LblFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblFont.Location = New System.Drawing.Point(103, 21)
		Me.LblFont.Name = "LblFont"
		Me.LblFont.Size = New System.Drawing.Size(112, 20)
		Me.LblFont.TabIndex = 40
		Me.LblFont.Text = "Tamaño Grid"
		Me.LblFont.Visible = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(5, 58)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(42, 13)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Modelo"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PicItem
		'
		Me.PicItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicItem.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PicItem.Location = New System.Drawing.Point(907, 0)
		Me.PicItem.Name = "PicItem"
		Me.PicItem.Size = New System.Drawing.Size(50, 50)
		Me.PicItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PicItem.TabIndex = 33
		Me.PicItem.TabStop = False
		'
		'LnkRefrescar
		'
		Me.LnkRefrescar.AutoSize = True
		Me.LnkRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LnkRefrescar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkRefrescar.Location = New System.Drawing.Point(137, 320)
		Me.LnkRefrescar.Name = "LnkRefrescar"
		Me.LnkRefrescar.Size = New System.Drawing.Size(81, 13)
		Me.LnkRefrescar.TabIndex = 29
		Me.LnkRefrescar.TabStop = True
		Me.LnkRefrescar.Text = "Refrescar Items"
		'
		'LnkAbrir
		'
		Me.LnkAbrir.AutoSize = True
		Me.LnkAbrir.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkAbrir.Location = New System.Drawing.Point(332, 320)
		Me.LnkAbrir.Name = "LnkAbrir"
		Me.LnkAbrir.Size = New System.Drawing.Size(31, 13)
		Me.LnkAbrir.TabIndex = 13
		Me.LnkAbrir.TabStop = True
		Me.LnkAbrir.Text = "1901"
		'
		'LnkAvanzado
		'
		Me.LnkAvanzado.AutoSize = True
		Me.LnkAvanzado.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkAvanzado.Location = New System.Drawing.Point(647, 21)
		Me.LnkAvanzado.Name = "LnkAvanzado"
		Me.LnkAvanzado.Size = New System.Drawing.Size(73, 13)
		Me.LnkAvanzado.TabIndex = 11
		Me.LnkAvanzado.TabStop = True
		Me.LnkAvanzado.Text = "Opciones (F3)"
		Me.LnkAvanzado.Visible = False
		'
		'LblNegrilla
		'
		Me.LblNegrilla.AutoSize = True
		Me.LblNegrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblNegrilla.ForeColor = System.Drawing.Color.Gray
		Me.LblNegrilla.Location = New System.Drawing.Point(87, 40)
		Me.LblNegrilla.Name = "LblNegrilla"
		Me.LblNegrilla.Size = New System.Drawing.Size(29, 12)
		Me.LblNegrilla.TabIndex = 35
		Me.LblNegrilla.Text = "Items"
		'
		'LnkExcel
		'
		Me.LnkExcel.AutoSize = True
		Me.LnkExcel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkExcel.Location = New System.Drawing.Point(448, 320)
		Me.LnkExcel.Name = "LnkExcel"
		Me.LnkExcel.Size = New System.Drawing.Size(33, 13)
		Me.LnkExcel.TabIndex = 14
		Me.LnkExcel.TabStop = True
		Me.LnkExcel.Text = "Excel"
		'
		'LblStock
		'
		Me.LblStock.AutoSize = True
		Me.LblStock.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LblStock.Location = New System.Drawing.Point(390, 320)
		Me.LblStock.Name = "LblStock"
		Me.LblStock.Size = New System.Drawing.Size(31, 13)
		Me.LblStock.TabIndex = 12
		Me.LblStock.TabStop = True
		Me.LblStock.Text = "1907"
		'
		'LinkLabel1
		'
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel1.Location = New System.Drawing.Point(245, 320)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(60, 13)
		Me.LinkLabel1.TabIndex = 39
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "Estadística"
		'
		'CmdBuscar
		'
		Me.CmdBuscar.BackColor = System.Drawing.Color.White
		Me.CmdBuscar.BackgroundImage = CType(resources.GetObject("CmdBuscar.BackgroundImage"), System.Drawing.Image)
		Me.CmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdBuscar.ForeColor = System.Drawing.Color.White
		Me.CmdBuscar.Location = New System.Drawing.Point(347, 15)
		Me.CmdBuscar.Name = "CmdBuscar"
		Me.CmdBuscar.Size = New System.Drawing.Size(51, 24)
		Me.CmdBuscar.TabIndex = 10
		Me.CmdBuscar.Text = "Buscar"
		Me.CmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdBuscar.UseVisualStyleBackColor = True
		'
		'BckLeerLineasColores
		'
		'
		'BackTraerStock
		'
		Me.BackTraerStock.WorkerSupportsCancellation = True
		'
		'LblMensaje
		'
		Me.LblMensaje.ForeColor = System.Drawing.Color.Red
		Me.LblMensaje.Location = New System.Drawing.Point(25, 16)
		Me.LblMensaje.Name = "LblMensaje"
		Me.LblMensaje.Size = New System.Drawing.Size(255, 47)
		Me.LblMensaje.TabIndex = 42
		Me.LblMensaje.Text = "Solo carga stock de 5000"
		Me.LblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(18, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(35, 13)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Stock"
		'
		'Pnl500
		'
		Me.Pnl500.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Pnl500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Pnl500.Controls.Add(Me.LblMensaje)
		Me.Pnl500.Controls.Add(Me.LinkLabel2)
		Me.Pnl500.Location = New System.Drawing.Point(300, 168)
		Me.Pnl500.Name = "Pnl500"
		Me.Pnl500.Size = New System.Drawing.Size(302, 91)
		Me.Pnl500.TabIndex = 27
		Me.Pnl500.Visible = False
		'
		'LinkLabel2
		'
		Me.LinkLabel2.AutoSize = True
		Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel2.Location = New System.Drawing.Point(254, 73)
		Me.LinkLabel2.Name = "LinkLabel2"
		Me.LinkLabel2.Size = New System.Drawing.Size(41, 13)
		Me.LinkLabel2.TabIndex = 43
		Me.LinkLabel2.TabStop = True
		Me.LinkLabel2.Text = "Ocultar"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(1, 54)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(56, 13)
		Me.Label6.TabIndex = 17
		Me.Label6.Text = "Proveedor"
		'
		'ChkStock
		'
		Me.ChkStock.AutoSize = True
		Me.ChkStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkStock.Location = New System.Drawing.Point(62, 100)
		Me.ChkStock.Name = "ChkStock"
		Me.ChkStock.Size = New System.Drawing.Size(161, 17)
		Me.ChkStock.TabIndex = 15
		Me.ChkStock.Text = "Solo mostrar items con stock"
		Me.ChkStock.UseVisualStyleBackColor = True
		'
		'ChkOcultarPrecio
		'
		Me.ChkOcultarPrecio.AutoSize = True
		Me.ChkOcultarPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkOcultarPrecio.Location = New System.Drawing.Point(62, 157)
		Me.ChkOcultarPrecio.Name = "ChkOcultarPrecio"
		Me.ChkOcultarPrecio.Size = New System.Drawing.Size(93, 17)
		Me.ChkOcultarPrecio.TabIndex = 18
		Me.ChkOcultarPrecio.Text = "Ocultar Precio"
		Me.ChkOcultarPrecio.UseVisualStyleBackColor = True
		'
		'TxtBuscarItem2
		'
		Me.TxtBuscarItem2.BackColor = System.Drawing.SystemColors.Window
		Me.TxtBuscarItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtBuscarItem2.Location = New System.Drawing.Point(179, 17)
		Me.TxtBuscarItem2.Name = "TxtBuscarItem2"
		Me.TxtBuscarItem2.Size = New System.Drawing.Size(64, 20)
		Me.TxtBuscarItem2.TabIndex = 1
		'
		'TxtCod
		'
		Me.TxtCod.BackColor = System.Drawing.SystemColors.Window
		Me.TxtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtCod.Location = New System.Drawing.Point(273, 17)
		Me.TxtCod.Name = "TxtCod"
		Me.TxtCod.Size = New System.Drawing.Size(68, 20)
		Me.TxtCod.TabIndex = 2
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(247, 20)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(26, 13)
		Me.Label8.TabIndex = 4
		Me.Label8.Text = "Cod"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(164, 21)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(12, 13)
		Me.Label9.TabIndex = 2
		Me.Label9.Text = "y"
		'
		'ChkPromo
		'
		Me.ChkPromo.AutoSize = True
		Me.ChkPromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkPromo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.ChkPromo.Location = New System.Drawing.Point(62, 138)
		Me.ChkPromo.Name = "ChkPromo"
		Me.ChkPromo.Size = New System.Drawing.Size(168, 17)
		Me.ChkPromo.TabIndex = 17
		Me.ChkPromo.Text = "Mostrar Bodega de promoción"
		Me.ChkPromo.UseVisualStyleBackColor = True
		'
		'ChkPrecioCaja
		'
		Me.ChkPrecioCaja.AutoSize = True
		Me.ChkPrecioCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkPrecioCaja.Location = New System.Drawing.Point(62, 119)
		Me.ChkPrecioCaja.Name = "ChkPrecioCaja"
		Me.ChkPrecioCaja.Size = New System.Drawing.Size(165, 17)
		Me.ChkPrecioCaja.TabIndex = 16
		Me.ChkPrecioCaja.Text = "Mostrar Precio y Stock x Caja"
		Me.ChkPrecioCaja.UseVisualStyleBackColor = True
		'
		'LnkVarios
		'
		Me.LnkVarios.AutoSize = True
		Me.LnkVarios.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkVarios.Location = New System.Drawing.Point(408, 277)
		Me.LnkVarios.Name = "LnkVarios"
		Me.LnkVarios.Size = New System.Drawing.Size(103, 13)
		Me.LnkVarios.TabIndex = 23
		Me.LnkVarios.TabStop = True
		Me.LnkVarios.Text = "Fltrar Campos Varios"
		'
		'TxtDcto
		'
		Me.TxtDcto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtDcto.Location = New System.Drawing.Point(318, 275)
		Me.TxtDcto.Name = "TxtDcto"
		Me.TxtDcto.Size = New System.Drawing.Size(40, 20)
		Me.TxtDcto.TabIndex = 25
		Me.TxtDcto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.ForeColor = System.Drawing.Color.Red
		Me.Label10.Location = New System.Drawing.Point(318, 259)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(38, 13)
		Me.Label10.TabIndex = 24
		Me.Label10.Text = "%Dcto"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(1, 6)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(35, 13)
		Me.Label11.TabIndex = 9
		Me.Label11.Text = "Línea"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(1, 30)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(50, 13)
		Me.Label12.TabIndex = 13
		Me.Label12.Text = "Genérico"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(471, 20)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(40, 13)
		Me.Label13.TabIndex = 60
		Me.Label13.Text = "Alterna"
		'
		'TxtAlterna
		'
		Me.TxtAlterna.BackColor = System.Drawing.SystemColors.Window
		Me.TxtAlterna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtAlterna.Location = New System.Drawing.Point(511, 17)
		Me.TxtAlterna.MaxLength = 20
		Me.TxtAlterna.Name = "TxtAlterna"
		Me.TxtAlterna.Size = New System.Drawing.Size(68, 20)
		Me.TxtAlterna.TabIndex = 59
		'
		'ChkTodos
		'
		Me.ChkTodos.AutoSize = True
		Me.ChkTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkTodos.Location = New System.Drawing.Point(62, 252)
		Me.ChkTodos.Name = "ChkTodos"
		Me.ChkTodos.Size = New System.Drawing.Size(101, 17)
		Me.ChkTodos.TabIndex = 42
		Me.ChkTodos.Text = "Incluir Anulados"
		Me.ChkTodos.UseVisualStyleBackColor = True
		'
		'ChkLimpiar
		'
		Me.ChkLimpiar.AutoSize = True
		Me.ChkLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkLimpiar.Location = New System.Drawing.Point(62, 271)
		Me.ChkLimpiar.Name = "ChkLimpiar"
		Me.ChkLimpiar.Size = New System.Drawing.Size(127, 17)
		Me.ChkLimpiar.TabIndex = 41
		Me.ChkLimpiar.Text = "Limpiar filtros al entrar"
		Me.ChkLimpiar.UseVisualStyleBackColor = True
		'
		'ChkLineaGen
		'
		Me.ChkLineaGen.AutoSize = True
		Me.ChkLineaGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkLineaGen.Location = New System.Drawing.Point(62, 214)
		Me.ChkLineaGen.Name = "ChkLineaGen"
		Me.ChkLineaGen.Size = New System.Drawing.Size(165, 17)
		Me.ChkLineaGen.TabIndex = 62
		Me.ChkLineaGen.Text = "Ver Línea, Genérico y grupos"
		Me.ChkLineaGen.UseVisualStyleBackColor = True
		'
		'CbTalla
		'
		Me.CbTalla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.CbTalla.Location = New System.Drawing.Point(61, 3)
		Me.CbTalla.Name = "CbTalla"
		Me.CbTalla.Size = New System.Drawing.Size(236, 21)
		Me.CbTalla.TabIndex = 4
		'
		'CbGener
		'
		Me.CbGener.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.CbGener.Location = New System.Drawing.Point(61, 27)
		Me.CbGener.Name = "CbGener"
		Me.CbGener.Size = New System.Drawing.Size(236, 21)
		Me.CbGener.TabIndex = 6
		'
		'CbBod
		'
		Me.CbBod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.CbBod.Location = New System.Drawing.Point(61, 15)
		Me.CbBod.Name = "CbBod"
		Me.CbBod.Size = New System.Drawing.Size(236, 21)
		Me.CbBod.TabIndex = 3
		'
		'CbProv
		'
		Me.CbProv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.CbProv.Location = New System.Drawing.Point(61, 51)
		Me.CbProv.Name = "CbProv"
		Me.CbProv.Size = New System.Drawing.Size(236, 21)
		Me.CbProv.TabIndex = 8
		'
		'CbSubgrupo
		'
		Me.CbSubgrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.CbSubgrupo.Location = New System.Drawing.Point(61, 63)
		Me.CbSubgrupo.Name = "CbSubgrupo"
		Me.CbSubgrupo.Size = New System.Drawing.Size(236, 21)
		Me.CbSubgrupo.TabIndex = 7
		'
		'CbGrupo
		'
		Me.CbGrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.CbGrupo.Location = New System.Drawing.Point(61, 39)
		Me.CbGrupo.Name = "CbGrupo"
		Me.CbGrupo.Size = New System.Drawing.Size(236, 21)
		Me.CbGrupo.TabIndex = 5
		'
		'BckLeerItems
		'
		'
		'CbTama
		'
		Me.CbTama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbTama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CbTama.ForeColor = System.Drawing.Color.Black
		Me.CbTama.FormattingEnabled = True
		Me.CbTama.Items.AddRange(New Object() {"Pequeño", "Mediano", "Grande"})
		Me.CbTama.Location = New System.Drawing.Point(555, 274)
		Me.CbTama.Name = "CbTama"
		Me.CbTama.Size = New System.Drawing.Size(77, 21)
		Me.CbTama.TabIndex = 12
		'
		'ChkReal
		'
		Me.ChkReal.AutoSize = True
		Me.ChkReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkReal.Location = New System.Drawing.Point(62, 195)
		Me.ChkReal.Name = "ChkReal"
		Me.ChkReal.Size = New System.Drawing.Size(156, 17)
		Me.ChkReal.TabIndex = 63
		Me.ChkReal.Text = "Ver stock sin restar pedidos"
		Me.ChkReal.UseVisualStyleBackColor = True
		'
		'PnlProc
		'
		Me.PnlProc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PnlProc.Controls.Add(Me.Label14)
		Me.PnlProc.Location = New System.Drawing.Point(519, 12)
		Me.PnlProc.Name = "PnlProc"
		Me.PnlProc.Size = New System.Drawing.Size(51, 31)
		Me.PnlProc.TabIndex = 44
		Me.PnlProc.Visible = False
		'
		'Label14
		'
		Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.Label14.Location = New System.Drawing.Point(0, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(51, 31)
		Me.Label14.TabIndex = 0
		Me.Label14.Text = "Procesando consulta..."
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ChkSoloInicial
		'
		Me.ChkSoloInicial.AutoSize = True
		Me.ChkSoloInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkSoloInicial.Location = New System.Drawing.Point(62, 233)
		Me.ChkSoloInicial.Name = "ChkSoloInicial"
		Me.ChkSoloInicial.Size = New System.Drawing.Size(167, 17)
		Me.ChkSoloInicial.TabIndex = 64
		Me.ChkSoloInicial.Text = "Buscar solo descripción inicial"
		Me.ChkSoloInicial.UseVisualStyleBackColor = True
		'
		'ChkPrinAct
		'
		Me.ChkPrinAct.AutoSize = True
		Me.ChkPrinAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkPrinAct.Location = New System.Drawing.Point(62, 176)
		Me.ChkPrinAct.Name = "ChkPrinAct"
		Me.ChkPrinAct.Size = New System.Drawing.Size(166, 17)
		Me.ChkPrinAct.TabIndex = 65
		Me.ChkPrinAct.Text = "También en ""principio activo"""
		Me.ChkPrinAct.UseVisualStyleBackColor = True
		'
		'CmdAnchoPred
		'
		Me.CmdAnchoPred.AutoSize = True
		Me.CmdAnchoPred.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.CmdAnchoPred.Location = New System.Drawing.Point(508, 320)
		Me.CmdAnchoPred.Name = "CmdAnchoPred"
		Me.CmdAnchoPred.Size = New System.Drawing.Size(79, 13)
		Me.CmdAnchoPred.TabIndex = 66
		Me.CmdAnchoPred.TabStop = True
		Me.CmdAnchoPred.Text = "Column/default"
		'
		'PnlOpciones
		'
		Me.PnlOpciones.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.PnlOpciones.BackColor = System.Drawing.Color.Linen
		Me.PnlOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlOpciones.Controls.Add(Me.Panel2)
		Me.PnlOpciones.Controls.Add(Me.LnkOcultar)
		Me.PnlOpciones.Controls.Add(Me.PnlContenido)
		Me.PnlOpciones.Controls.Add(Me.ChkTodos)
		Me.PnlOpciones.Controls.Add(Me.LnkRefrescar)
		Me.PnlOpciones.Controls.Add(Me.LnkAbrir)
		Me.PnlOpciones.Controls.Add(Me.Label16)
		Me.PnlOpciones.Controls.Add(Me.Label10)
		Me.PnlOpciones.Controls.Add(Me.LnkVarios)
		Me.PnlOpciones.Controls.Add(Me.TxtDcto)
		Me.PnlOpciones.Controls.Add(Me.ChkLimpiar)
		Me.PnlOpciones.Controls.Add(Me.Panel1)
		Me.PnlOpciones.Controls.Add(Me.CmdAnchoPred)
		Me.PnlOpciones.Controls.Add(Me.LnkExcel)
		Me.PnlOpciones.Controls.Add(Me.LblStock)
		Me.PnlOpciones.Controls.Add(Me.ChkPrinAct)
		Me.PnlOpciones.Controls.Add(Me.LinkLabel1)
		Me.PnlOpciones.Controls.Add(Me.Label4)
		Me.PnlOpciones.Controls.Add(Me.ChkSoloInicial)
		Me.PnlOpciones.Controls.Add(Me.Label5)
		Me.PnlOpciones.Controls.Add(Me.ChkLineaGen)
		Me.PnlOpciones.Controls.Add(Me.Label1)
		Me.PnlOpciones.Controls.Add(Me.CbGrupo)
		Me.PnlOpciones.Controls.Add(Me.ChkOcultarPrecio)
		Me.PnlOpciones.Controls.Add(Me.CbSubgrupo)
		Me.PnlOpciones.Controls.Add(Me.CbBod)
		Me.PnlOpciones.Controls.Add(Me.CbTama)
		Me.PnlOpciones.Controls.Add(Me.ChkPromo)
		Me.PnlOpciones.Controls.Add(Me.ChkReal)
		Me.PnlOpciones.Controls.Add(Me.ChkPrecioCaja)
		Me.PnlOpciones.Controls.Add(Me.ChkStock)
		Me.PnlOpciones.Location = New System.Drawing.Point(158, 104)
		Me.PnlOpciones.Name = "PnlOpciones"
		Me.PnlOpciones.Size = New System.Drawing.Size(654, 341)
		Me.PnlOpciones.TabIndex = 67
		Me.PnlOpciones.Visible = False
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.CbProv)
		Me.Panel2.Controls.Add(Me.CbTalla)
		Me.Panel2.Controls.Add(Me.CbGener)
		Me.Panel2.Controls.Add(Me.Label11)
		Me.Panel2.Controls.Add(Me.Label12)
		Me.Panel2.Controls.Add(Me.Label6)
		Me.Panel2.Location = New System.Drawing.Point(323, 10)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(300, 75)
		Me.Panel2.TabIndex = 69
		'
		'LnkOcultar
		'
		Me.LnkOcultar.AutoSize = True
		Me.LnkOcultar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkOcultar.Location = New System.Drawing.Point(605, 320)
		Me.LnkOcultar.Name = "LnkOcultar"
		Me.LnkOcultar.Size = New System.Drawing.Size(41, 13)
		Me.LnkOcultar.TabIndex = 68
		Me.LnkOcultar.TabStop = True
		Me.LnkOcultar.Text = "Ocultar"
		'
		'PnlContenido
		'
		Me.PnlContenido.Controls.Add(Me.OptTempario)
		Me.PnlContenido.Controls.Add(Me.OptVehiculos)
		Me.PnlContenido.Controls.Add(Me.OptTempYVeh)
		Me.PnlContenido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.PnlContenido.Location = New System.Drawing.Point(319, 204)
		Me.PnlContenido.Name = "PnlContenido"
		Me.PnlContenido.Size = New System.Drawing.Size(315, 44)
		Me.PnlContenido.TabIndex = 67
		Me.PnlContenido.TabStop = False
		Me.PnlContenido.Text = "Contenido"
		Me.PnlContenido.Visible = False
		'
		'OptTempario
		'
		Me.OptTempario.AutoSize = True
		Me.OptTempario.Location = New System.Drawing.Point(235, 22)
		Me.OptTempario.Name = "OptTempario"
		Me.OptTempario.Size = New System.Drawing.Size(69, 17)
		Me.OptTempario.TabIndex = 13
		Me.OptTempario.Text = "Tempario"
		Me.OptTempario.UseVisualStyleBackColor = True
		'
		'OptVehiculos
		'
		Me.OptVehiculos.AutoSize = True
		Me.OptVehiculos.Location = New System.Drawing.Point(151, 21)
		Me.OptVehiculos.Name = "OptVehiculos"
		Me.OptVehiculos.Size = New System.Drawing.Size(71, 17)
		Me.OptVehiculos.TabIndex = 12
		Me.OptVehiculos.Text = "Vehiculos"
		Me.OptVehiculos.UseVisualStyleBackColor = True
		'
		'OptTempYVeh
		'
		Me.OptTempYVeh.AutoSize = True
		Me.OptTempYVeh.Checked = True
		Me.OptTempYVeh.Location = New System.Drawing.Point(45, 21)
		Me.OptTempYVeh.Name = "OptTempYVeh"
		Me.OptTempYVeh.Size = New System.Drawing.Size(98, 17)
		Me.OptTempYVeh.TabIndex = 11
		Me.OptTempYVeh.TabStop = True
		Me.OptTempYVeh.Text = "Todos (sin veh)"
		Me.OptTempYVeh.UseVisualStyleBackColor = True
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(564, 258)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(46, 13)
		Me.Label16.TabIndex = 27
		Me.Label16.Text = "Tamaño"
		'
		'CmdCancelar
		'
		Me.CmdCancelar.BackColor = System.Drawing.Color.White
		Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancelar.ForeColor = System.Drawing.Color.White
		Me.CmdCancelar.Location = New System.Drawing.Point(835, 14)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(66, 24)
		Me.CmdCancelar.TabIndex = 68
		Me.CmdCancelar.Text = "Cancelar"
		Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancelar.UseVisualStyleBackColor = True
		'
		'CmdMostrarPrecios
		'
		Me.CmdMostrarPrecios.BackColor = System.Drawing.Color.Green
		Me.CmdMostrarPrecios.ForeColor = System.Drawing.Color.White
		Me.CmdMostrarPrecios.Location = New System.Drawing.Point(581, 14)
		Me.CmdMostrarPrecios.Name = "CmdMostrarPrecios"
		Me.CmdMostrarPrecios.Size = New System.Drawing.Size(66, 27)
		Me.CmdMostrarPrecios.TabIndex = 70
		Me.CmdMostrarPrecios.Tag = "-1"
		Me.CmdMostrarPrecios.Text = "Precios"
		Me.ToolTipAdvance.SetToolTip(Me.CmdMostrarPrecios, "Clic para mostrar precios cuando " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "se basan en el promedio")
		Me.CmdMostrarPrecios.UseVisualStyleBackColor = False
		Me.CmdMostrarPrecios.Visible = False
		'
		'GrdNue
		'
		Me.GrdNue.DMSCopiarDt = True
		Me.GrdNue.DMSTituloDelInforme = ""
		Me.GrdNue.Location = New System.Drawing.Point(26, 92)
		Me.GrdNue.Name = "GrdNue"
		Me.GrdNue.Size = New System.Drawing.Size(55, 49)
		Me.GrdNue.TabIndex = 71
		Me.GrdNue.Visible = False
		'
		'LblMas
		'
		Me.LblMas.AutoSize = True
		Me.LblMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblMas.ForeColor = System.Drawing.Color.Gray
		Me.LblMas.Location = New System.Drawing.Point(66, 2)
		Me.LblMas.Name = "LblMas"
		Me.LblMas.Size = New System.Drawing.Size(97, 12)
		Me.LblMas.TabIndex = 72
		Me.LblMas.Text = "Use + para compuesta"
		Me.LblMas.Visible = False
		'
		'fBusItems
		'
		Me.AcceptButton = Me.CmdBuscar
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(984, 468)
		Me.Controls.Add(Me.LblMas)
		Me.Controls.Add(Me.PnlOpciones)
		Me.Controls.Add(Me.GrdNue)
		Me.Controls.Add(Me.CmdMostrarPrecios)
		Me.Controls.Add(Me.CmdCancelar)
		Me.Controls.Add(Me.PnlProc)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.TxtAlterna)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.TxtCod)
		Me.Controls.Add(Me.LblNegrilla)
		Me.Controls.Add(Me.TxtBuscarItem2)
		Me.Controls.Add(Me.Pnl500)
		Me.Controls.Add(Me.CmdBuscar)
		Me.Controls.Add(Me.LnkAvanzado)
		Me.Controls.Add(Me.PicItem)
		Me.Controls.Add(Me.CmdModificar)
		Me.Controls.Add(Me.GrdBus)
		Me.Controls.Add(Me.TxtBuscarItem)
		Me.Controls.Add(Me.LblItem)
		Me.MinimizeBox = False
		Me.Name = "fBusItems"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Buscar Items"
		Me.Controls.SetChildIndex(Me.LblItem, 0)
		Me.Controls.SetChildIndex(Me.TxtBuscarItem, 0)
		Me.Controls.SetChildIndex(Me.GrdBus, 0)
		Me.Controls.SetChildIndex(Me.CmdModificar, 0)
		Me.Controls.SetChildIndex(Me.PicItem, 0)
		Me.Controls.SetChildIndex(Me.LnkAvanzado, 0)
		Me.Controls.SetChildIndex(Me.CmdBuscar, 0)
		Me.Controls.SetChildIndex(Me.Pnl500, 0)
		Me.Controls.SetChildIndex(Me.TxtBuscarItem2, 0)
		Me.Controls.SetChildIndex(Me.LblNegrilla, 0)
		Me.Controls.SetChildIndex(Me.TxtCod, 0)
		Me.Controls.SetChildIndex(Me.Label8, 0)
		Me.Controls.SetChildIndex(Me.Label9, 0)
		Me.Controls.SetChildIndex(Me.TxtAlterna, 0)
		Me.Controls.SetChildIndex(Me.Label13, 0)
		Me.Controls.SetChildIndex(Me.PnlProc, 0)
		Me.Controls.SetChildIndex(Me.CmdCancelar, 0)
		Me.Controls.SetChildIndex(Me.CmdMostrarPrecios, 0)
		Me.Controls.SetChildIndex(Me.GrdNue, 0)
		Me.Controls.SetChildIndex(Me.PnlOpciones, 0)
		Me.Controls.SetChildIndex(Me.LblMas, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GrdBus, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.PicItem, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Pnl500.ResumeLayout(False)
		Me.Pnl500.PerformLayout()
		Me.PnlProc.ResumeLayout(False)
		Me.PnlOpciones.ResumeLayout(False)
		Me.PnlOpciones.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.PnlContenido.ResumeLayout(False)
		Me.PnlContenido.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents TxtBuscarItem As System.Windows.Forms.TextBox
	Friend WithEvents LblItem As System.Windows.Forms.Label
	Friend WithEvents CbLinea As System.Windows.Forms.ComboBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents CbMarca As System.Windows.Forms.ComboBox
	Friend WithEvents Label15 As System.Windows.Forms.Label
	Friend WithEvents CbModelo As System.Windows.Forms.ComboBox
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents LnkRefrescar As System.Windows.Forms.LinkLabel
	Friend WithEvents PicItem As System.Windows.Forms.PictureBox
	Friend WithEvents LnkAvanzado As System.Windows.Forms.LinkLabel
	Friend WithEvents LblNegrilla As System.Windows.Forms.Label
	Friend WithEvents OptTodos As System.Windows.Forms.RadioButton
	Friend WithEvents OptUsados As System.Windows.Forms.RadioButton
	Friend WithEvents OptNuevos As System.Windows.Forms.RadioButton
	Friend WithEvents LnkExcel As System.Windows.Forms.LinkLabel
	Friend WithEvents LblStock As System.Windows.Forms.LinkLabel
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents LnkAbrir As System.Windows.Forms.LinkLabel
	Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
	Public WithEvents BckLeerLineasColores As System.ComponentModel.BackgroundWorker
	Friend WithEvents BackTraerStock As System.ComponentModel.BackgroundWorker
	Friend WithEvents LblMensaje As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Pnl500 As System.Windows.Forms.Panel
	Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents ChkStock As System.Windows.Forms.CheckBox
	Friend WithEvents ChkOcultarPrecio As System.Windows.Forms.CheckBox
	Friend WithEvents TxtBuscarItem2 As System.Windows.Forms.TextBox
	Friend WithEvents TxtCod As System.Windows.Forms.TextBox
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents GrdBus As System.Windows.Forms.DataGridView
	Friend WithEvents ChkPromo As System.Windows.Forms.CheckBox
	Friend WithEvents ChkPrecioCaja As System.Windows.Forms.CheckBox
	Friend WithEvents LnkVarios As System.Windows.Forms.LinkLabel
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents TxtDcto As System.Windows.Forms.TextBox
	Public WithEvents CbBod As SMDPpal.ComboDMS
	Public WithEvents CbGrupo As SMDPpal.ComboDMS
	Public WithEvents CbSubgrupo As SMDPpal.ComboDMS
	Public WithEvents CbProv As SMDPpal.ComboDMS
	Public WithEvents CbTalla As SMDPpal.ComboDMS
	Public WithEvents CbGener As SMDPpal.ComboDMS
	Friend WithEvents Label11 As System.Windows.Forms.Label
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents TxtAlterna As System.Windows.Forms.TextBox
	Friend WithEvents ChkLineaGen As System.Windows.Forms.CheckBox
	Friend WithEvents BckLeerItems As System.ComponentModel.BackgroundWorker
	Public WithEvents CmdModificar As SMDPpal.BotonEstandar
	Friend WithEvents CmdBuscar As SMDPpal.BotonEstandar
	Friend WithEvents CbTama As System.Windows.Forms.ComboBox
	Friend WithEvents LblFont As System.Windows.Forms.Label
	Friend WithEvents ChkReal As System.Windows.Forms.CheckBox
	Friend WithEvents PnlProc As System.Windows.Forms.Panel
	Friend WithEvents Label14 As System.Windows.Forms.Label
	Friend WithEvents ChkSoloInicial As System.Windows.Forms.CheckBox
	Friend WithEvents ChkPrinAct As System.Windows.Forms.CheckBox
	Public WithEvents CmdAnchoPred As System.Windows.Forms.LinkLabel
	Friend WithEvents ChkLimpiar As System.Windows.Forms.CheckBox
	Friend WithEvents ChkTodos As System.Windows.Forms.CheckBox
	Friend WithEvents PnlOpciones As System.Windows.Forms.Panel
	Friend WithEvents Label16 As System.Windows.Forms.Label
	Friend WithEvents PnlContenido As System.Windows.Forms.GroupBox
	Public WithEvents OptTempario As System.Windows.Forms.RadioButton
	Friend WithEvents LnkOcultar As System.Windows.Forms.LinkLabel
	Public WithEvents CmdCancelar As SMDPpal.BotonEstandar
	Friend WithEvents CmdMostrarPrecios As Button
	Friend WithEvents Panel2 As Panel
	Public WithEvents GrdNue As GridDms
	Friend WithEvents LblMas As Label
	Friend WithEvents Cua As DataGridViewTextBoxColumn
	Friend WithEvents id As DataGridViewTextBoxColumn
	Friend WithEvents codigo As DataGridViewTextBoxColumn
	Friend WithEvents Descripcion As DataGridViewTextBoxColumn
	Friend WithEvents Und As DataGridViewTextBoxColumn
	Friend WithEvents precio_sin_iva As DataGridViewTextBoxColumn
	Friend WithEvents Dscto As DataGridViewTextBoxColumn
	Friend WithEvents Neto As DataGridViewTextBoxColumn
	Friend WithEvents iva As DataGridViewTextBoxColumn
	Friend WithEvents linea As DataGridViewTextBoxColumn
	Friend WithEvents generico As DataGridViewTextBoxColumn
	Friend WithEvents grupo As DataGridViewTextBoxColumn
	Friend WithEvents subgrupo As DataGridViewTextBoxColumn
	Friend WithEvents promocion As DataGridViewTextBoxColumn
	Friend WithEvents proveedor As DataGridViewTextBoxColumn
	Friend WithEvents tiene_imagen As DataGridViewLinkColumn
	Friend WithEvents reservado As DataGridViewTextBoxColumn
	Friend WithEvents estado As DataGridViewTextBoxColumn
	Friend WithEvents Bodega As DataGridViewTextBoxColumn
	Public WithEvents OptTempYVeh As RadioButton
	Public WithEvents OptVehiculos As RadioButton
End Class
