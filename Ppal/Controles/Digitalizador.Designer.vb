<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Digitalizador
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Digitalizador))
		Me.LnkAbrirArchivo = New System.Windows.Forms.LinkLabel()
		Me.LnkEditar = New System.Windows.Forms.LinkLabel()
		Me.LnkNuevoArchivo = New System.Windows.Forms.LinkLabel()
		Me.PnlEditar = New System.Windows.Forms.Panel()
		Me.CmdCancel = New SMDPpal.BotonEstandar()
		Me.LblTitulo = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TbBasica = New System.Windows.Forms.TabPage()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.CbCategoria = New System.Windows.Forms.ComboBox()
		Me.LblTamaño = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.CbClasificacion = New System.Windows.Forms.ComboBox()
		Me.TxtArchivo = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.CmdBuscar = New SMDPpal.BotonEstandar()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LblRuta = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TxtDescripcion = New System.Windows.Forms.TextBox()
		Me.TbAdicional = New System.Windows.Forms.TabPage()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.LblCampo6 = New System.Windows.Forms.Label()
		Me.LblCampo7 = New System.Windows.Forms.Label()
		Me.LblCampo8 = New System.Windows.Forms.Label()
		Me.LblCampo9 = New System.Windows.Forms.Label()
		Me.LblCampo10 = New System.Windows.Forms.Label()
		Me.LblCampo1 = New System.Windows.Forms.Label()
		Me.LblCampo2 = New System.Windows.Forms.Label()
		Me.LblCampo3 = New System.Windows.Forms.Label()
		Me.LblCampo4 = New System.Windows.Forms.Label()
		Me.LblCampo5 = New System.Windows.Forms.Label()
		Me.CbSiNo9 = New System.Windows.Forms.ComboBox()
		Me.CbSiNo8 = New System.Windows.Forms.ComboBox()
		Me.CbSiNo7 = New System.Windows.Forms.ComboBox()
		Me.CbSiNo10 = New System.Windows.Forms.ComboBox()
		Me.TxtCampo10 = New System.Windows.Forms.TextBox()
		Me.CbSiNo6 = New System.Windows.Forms.ComboBox()
		Me.TxtCampo9 = New System.Windows.Forms.TextBox()
		Me.TxtCampo8 = New System.Windows.Forms.TextBox()
		Me.TxtCampo6 = New System.Windows.Forms.TextBox()
		Me.TxtCampo7 = New System.Windows.Forms.TextBox()
		Me.CbSiNo4 = New System.Windows.Forms.ComboBox()
		Me.CbSiNo3 = New System.Windows.Forms.ComboBox()
		Me.CbSiNo2 = New System.Windows.Forms.ComboBox()
		Me.CbSiNo5 = New System.Windows.Forms.ComboBox()
		Me.TxtCampo5 = New System.Windows.Forms.TextBox()
		Me.CbSiNo1 = New System.Windows.Forms.ComboBox()
		Me.TxtCampo4 = New System.Windows.Forms.TextBox()
		Me.TxtCampo3 = New System.Windows.Forms.TextBox()
		Me.TxtCampo1 = New System.Windows.Forms.TextBox()
		Me.TxtCampo2 = New System.Windows.Forms.TextBox()
		Me.LnkBorrar = New System.Windows.Forms.LinkLabel()
		Me.LnkAbrir2 = New System.Windows.Forms.LinkLabel()
		Me.CmdActualizar = New SMDPpal.BotonEstandar()
		Me.LnkEnviar = New System.Windows.Forms.LinkLabel()
		Me.LnkAbrirPrograma = New System.Windows.Forms.LinkLabel()
		Me.LnkRegresar = New System.Windows.Forms.LinkLabel()
		Me.LnkConfig = New System.Windows.Forms.LinkLabel()
		Me.GrdDigi = New SMDPpal.GridDms()
		Me.PnlEditar.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.TbBasica.SuspendLayout()
		Me.TbAdicional.SuspendLayout()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.SuspendLayout()
		'
		'LnkAbrirArchivo
		'
		Me.LnkAbrirArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkAbrirArchivo.AutoSize = True
		Me.LnkAbrirArchivo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkAbrirArchivo.Location = New System.Drawing.Point(449, 6)
		Me.LnkAbrirArchivo.Name = "LnkAbrirArchivo"
		Me.LnkAbrirArchivo.Size = New System.Drawing.Size(28, 13)
		Me.LnkAbrirArchivo.TabIndex = 9
		Me.LnkAbrirArchivo.TabStop = True
		Me.LnkAbrirArchivo.Text = "Abrir"
		'
		'LnkEditar
		'
		Me.LnkEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkEditar.AutoSize = True
		Me.LnkEditar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkEditar.Location = New System.Drawing.Point(406, 6)
		Me.LnkEditar.Name = "LnkEditar"
		Me.LnkEditar.Size = New System.Drawing.Size(34, 13)
		Me.LnkEditar.TabIndex = 7
		Me.LnkEditar.TabStop = True
		Me.LnkEditar.Text = "Editar"
		'
		'LnkNuevoArchivo
		'
		Me.LnkNuevoArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkNuevoArchivo.AutoSize = True
		Me.LnkNuevoArchivo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkNuevoArchivo.Location = New System.Drawing.Point(358, 6)
		Me.LnkNuevoArchivo.Name = "LnkNuevoArchivo"
		Me.LnkNuevoArchivo.Size = New System.Drawing.Size(39, 13)
		Me.LnkNuevoArchivo.TabIndex = 6
		Me.LnkNuevoArchivo.TabStop = True
		Me.LnkNuevoArchivo.Text = "Nuevo"
		'
		'PnlEditar
		'
		Me.PnlEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PnlEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.PnlEditar.Controls.Add(Me.CmdCancel)
		Me.PnlEditar.Controls.Add(Me.LblTitulo)
		Me.PnlEditar.Controls.Add(Me.Panel1)
		Me.PnlEditar.Location = New System.Drawing.Point(4, 29)
		Me.PnlEditar.Name = "PnlEditar"
		Me.PnlEditar.Size = New System.Drawing.Size(476, 314)
		Me.PnlEditar.TabIndex = 10
		Me.PnlEditar.Visible = False
		'
		'CmdCancel
		'
		Me.CmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.CmdCancel.BackgroundImage = CType(resources.GetObject("CmdCancel.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancel.ForeColor = System.Drawing.Color.White
		Me.CmdCancel.Location = New System.Drawing.Point(448, 3)
		Me.CmdCancel.Name = "CmdCancel"
		Me.CmdCancel.Size = New System.Drawing.Size(23, 22)
		Me.CmdCancel.TabIndex = 17
		Me.CmdCancel.Text = "X"
		Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancel.UseVisualStyleBackColor = False
		'
		'LblTitulo
		'
		Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
		Me.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.LblTitulo.ForeColor = System.Drawing.Color.White
		Me.LblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.LblTitulo.Name = "LblTitulo"
		Me.LblTitulo.Size = New System.Drawing.Size(476, 16)
		Me.LblTitulo.TabIndex = 20
		Me.LblTitulo.Text = "Título"
		Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Panel1
		'
		Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel1.BackColor = System.Drawing.SystemColors.Control
		Me.Panel1.Controls.Add(Me.TabControl1)
		Me.Panel1.Controls.Add(Me.LnkBorrar)
		Me.Panel1.Controls.Add(Me.LnkAbrir2)
		Me.Panel1.Controls.Add(Me.CmdActualizar)
		Me.Panel1.Location = New System.Drawing.Point(6, 26)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(464, 282)
		Me.Panel1.TabIndex = 0
		'
		'TabControl1
		'
		Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TabControl1.Controls.Add(Me.TbBasica)
		Me.TabControl1.Controls.Add(Me.TbAdicional)
		Me.TabControl1.Location = New System.Drawing.Point(3, -1)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(448, 257)
		Me.TabControl1.TabIndex = 35
		'
		'TbBasica
		'
		Me.TbBasica.Controls.Add(Me.Label5)
		Me.TbBasica.Controls.Add(Me.CbCategoria)
		Me.TbBasica.Controls.Add(Me.LblTamaño)
		Me.TbBasica.Controls.Add(Me.Label6)
		Me.TbBasica.Controls.Add(Me.CbClasificacion)
		Me.TbBasica.Controls.Add(Me.TxtArchivo)
		Me.TbBasica.Controls.Add(Me.Label2)
		Me.TbBasica.Controls.Add(Me.CmdBuscar)
		Me.TbBasica.Controls.Add(Me.Label4)
		Me.TbBasica.Controls.Add(Me.Label1)
		Me.TbBasica.Controls.Add(Me.LblRuta)
		Me.TbBasica.Controls.Add(Me.Label3)
		Me.TbBasica.Controls.Add(Me.TxtDescripcion)
		Me.TbBasica.Location = New System.Drawing.Point(4, 22)
		Me.TbBasica.Name = "TbBasica"
		Me.TbBasica.Padding = New System.Windows.Forms.Padding(3)
		Me.TbBasica.Size = New System.Drawing.Size(440, 231)
		Me.TbBasica.TabIndex = 1
		Me.TbBasica.Text = "Información Básica"
		Me.TbBasica.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(65, 15)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(54, 13)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Categoría"
		'
		'CbCategoria
		'
		Me.CbCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbCategoria.FormattingEnabled = True
		Me.CbCategoria.Location = New System.Drawing.Point(125, 12)
		Me.CbCategoria.Name = "CbCategoria"
		Me.CbCategoria.Size = New System.Drawing.Size(266, 21)
		Me.CbCategoria.TabIndex = 0
		'
		'LblTamaño
		'
		Me.LblTamaño.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblTamaño.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.LblTamaño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblTamaño.Location = New System.Drawing.Point(325, 68)
		Me.LblTamaño.Name = "LblTamaño"
		Me.LblTamaño.Size = New System.Drawing.Size(66, 20)
		Me.LblTamaño.TabIndex = 2
		Me.LblTamaño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label6
		'
		Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(256, 72)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(63, 13)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Tamaño KB"
		'
		'CbClasificacion
		'
		Me.CbClasificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbClasificacion.FormattingEnabled = True
		Me.CbClasificacion.Location = New System.Drawing.Point(125, 214)
		Me.CbClasificacion.Name = "CbClasificacion"
		Me.CbClasificacion.Size = New System.Drawing.Size(266, 21)
		Me.CbClasificacion.TabIndex = 8
		'
		'TxtArchivo
		'
		Me.TxtArchivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtArchivo.Location = New System.Drawing.Point(125, 45)
		Me.TxtArchivo.Name = "TxtArchivo"
		Me.TxtArchivo.ReadOnly = True
		Me.TxtArchivo.Size = New System.Drawing.Size(266, 20)
		Me.TxtArchivo.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(7, 121)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(112, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Descripción (opcional)"
		'
		'CmdBuscar
		'
		Me.CmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdBuscar.BackColor = System.Drawing.Color.White
		Me.CmdBuscar.BackgroundImage = CType(resources.GetObject("CmdBuscar.BackgroundImage"), System.Drawing.Image)
		Me.CmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdBuscar.ForeColor = System.Drawing.Color.White
		Me.CmdBuscar.Location = New System.Drawing.Point(395, 43)
		Me.CmdBuscar.Name = "CmdBuscar"
		Me.CmdBuscar.Size = New System.Drawing.Size(32, 23)
		Me.CmdBuscar.TabIndex = 2
		Me.CmdBuscar.Text = "..."
		Me.CmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdBuscar.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(59, 218)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 13)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Clasificaión"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(21, 48)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(98, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Nombre de Archivo"
		'
		'LblRuta
		'
		Me.LblRuta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblRuta.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.LblRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblRuta.Location = New System.Drawing.Point(125, 95)
		Me.LblRuta.Name = "LblRuta"
		Me.LblRuta.Size = New System.Drawing.Size(266, 20)
		Me.LblRuta.TabIndex = 3
		Me.LblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.LblRuta.Visible = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(89, 99)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(30, 13)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Ruta"
		Me.Label3.Visible = False
		'
		'TxtDescripcion
		'
		Me.TxtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtDescripcion.Location = New System.Drawing.Point(125, 118)
		Me.TxtDescripcion.MaxLength = 250
		Me.TxtDescripcion.Multiline = True
		Me.TxtDescripcion.Name = "TxtDescripcion"
		Me.TxtDescripcion.Size = New System.Drawing.Size(266, 89)
		Me.TxtDescripcion.TabIndex = 4
		'
		'TbAdicional
		'
		Me.TbAdicional.Controls.Add(Me.SplitContainer1)
		Me.TbAdicional.Location = New System.Drawing.Point(4, 22)
		Me.TbAdicional.Name = "TbAdicional"
		Me.TbAdicional.Padding = New System.Windows.Forms.Padding(3)
		Me.TbAdicional.Size = New System.Drawing.Size(440, 231)
		Me.TbAdicional.TabIndex = 0
		Me.TbAdicional.Text = "Datos Adicionales"
		Me.TbAdicional.UseVisualStyleBackColor = True
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.LblCampo6)
		Me.SplitContainer1.Panel1.Controls.Add(Me.LblCampo7)
		Me.SplitContainer1.Panel1.Controls.Add(Me.LblCampo8)
		Me.SplitContainer1.Panel1.Controls.Add(Me.LblCampo9)
		Me.SplitContainer1.Panel1.Controls.Add(Me.LblCampo10)
		Me.SplitContainer1.Panel1.Controls.Add(Me.LblCampo1)
		Me.SplitContainer1.Panel1.Controls.Add(Me.LblCampo2)
		Me.SplitContainer1.Panel1.Controls.Add(Me.LblCampo3)
		Me.SplitContainer1.Panel1.Controls.Add(Me.LblCampo4)
		Me.SplitContainer1.Panel1.Controls.Add(Me.LblCampo5)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.CbSiNo9)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CbSiNo8)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CbSiNo7)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CbSiNo10)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TxtCampo10)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CbSiNo6)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TxtCampo9)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TxtCampo8)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TxtCampo6)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TxtCampo7)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CbSiNo4)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CbSiNo3)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CbSiNo2)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CbSiNo5)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TxtCampo5)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CbSiNo1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TxtCampo4)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TxtCampo3)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TxtCampo1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TxtCampo2)
		Me.SplitContainer1.Size = New System.Drawing.Size(434, 225)
		Me.SplitContainer1.SplitterDistance = 275
		Me.SplitContainer1.TabIndex = 34
		'
		'LblCampo6
		'
		Me.LblCampo6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblCampo6.Location = New System.Drawing.Point(4, 115)
		Me.LblCampo6.Name = "LblCampo6"
		Me.LblCampo6.Size = New System.Drawing.Size(267, 13)
		Me.LblCampo6.TabIndex = 33
		Me.LblCampo6.Text = "Campo 6"
		Me.LblCampo6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LblCampo7
		'
		Me.LblCampo7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblCampo7.Location = New System.Drawing.Point(4, 137)
		Me.LblCampo7.Name = "LblCampo7"
		Me.LblCampo7.Size = New System.Drawing.Size(267, 13)
		Me.LblCampo7.TabIndex = 34
		Me.LblCampo7.Text = "Campo 7"
		Me.LblCampo7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LblCampo8
		'
		Me.LblCampo8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblCampo8.Location = New System.Drawing.Point(4, 159)
		Me.LblCampo8.Name = "LblCampo8"
		Me.LblCampo8.Size = New System.Drawing.Size(267, 13)
		Me.LblCampo8.TabIndex = 35
		Me.LblCampo8.Text = "Campo 8"
		Me.LblCampo8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LblCampo9
		'
		Me.LblCampo9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblCampo9.Location = New System.Drawing.Point(4, 181)
		Me.LblCampo9.Name = "LblCampo9"
		Me.LblCampo9.Size = New System.Drawing.Size(267, 13)
		Me.LblCampo9.TabIndex = 36
		Me.LblCampo9.Text = "Campo 9"
		Me.LblCampo9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LblCampo10
		'
		Me.LblCampo10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblCampo10.Location = New System.Drawing.Point(4, 203)
		Me.LblCampo10.Name = "LblCampo10"
		Me.LblCampo10.Size = New System.Drawing.Size(267, 13)
		Me.LblCampo10.TabIndex = 37
		Me.LblCampo10.Text = "Campo 10"
		Me.LblCampo10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LblCampo1
		'
		Me.LblCampo1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblCampo1.Location = New System.Drawing.Point(3, 5)
		Me.LblCampo1.Name = "LblCampo1"
		Me.LblCampo1.Size = New System.Drawing.Size(267, 13)
		Me.LblCampo1.TabIndex = 24
		Me.LblCampo1.Text = "Campo 1"
		Me.LblCampo1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LblCampo2
		'
		Me.LblCampo2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblCampo2.Location = New System.Drawing.Point(3, 27)
		Me.LblCampo2.Name = "LblCampo2"
		Me.LblCampo2.Size = New System.Drawing.Size(267, 13)
		Me.LblCampo2.TabIndex = 26
		Me.LblCampo2.Text = "Campo 2"
		Me.LblCampo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LblCampo3
		'
		Me.LblCampo3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblCampo3.Location = New System.Drawing.Point(3, 49)
		Me.LblCampo3.Name = "LblCampo3"
		Me.LblCampo3.Size = New System.Drawing.Size(267, 13)
		Me.LblCampo3.TabIndex = 28
		Me.LblCampo3.Text = "Campo 3"
		Me.LblCampo3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LblCampo4
		'
		Me.LblCampo4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblCampo4.Location = New System.Drawing.Point(3, 71)
		Me.LblCampo4.Name = "LblCampo4"
		Me.LblCampo4.Size = New System.Drawing.Size(267, 13)
		Me.LblCampo4.TabIndex = 30
		Me.LblCampo4.Text = "Campo 4"
		Me.LblCampo4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LblCampo5
		'
		Me.LblCampo5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblCampo5.Location = New System.Drawing.Point(3, 93)
		Me.LblCampo5.Name = "LblCampo5"
		Me.LblCampo5.Size = New System.Drawing.Size(267, 13)
		Me.LblCampo5.TabIndex = 32
		Me.LblCampo5.Text = "Campo 5"
		Me.LblCampo5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'CbSiNo9
		'
		Me.CbSiNo9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbSiNo9.FormattingEnabled = True
		Me.CbSiNo9.Location = New System.Drawing.Point(3, 178)
		Me.CbSiNo9.Name = "CbSiNo9"
		Me.CbSiNo9.Size = New System.Drawing.Size(49, 21)
		Me.CbSiNo9.TabIndex = 16
		'
		'CbSiNo8
		'
		Me.CbSiNo8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbSiNo8.FormattingEnabled = True
		Me.CbSiNo8.Location = New System.Drawing.Point(3, 156)
		Me.CbSiNo8.Name = "CbSiNo8"
		Me.CbSiNo8.Size = New System.Drawing.Size(49, 21)
		Me.CbSiNo8.TabIndex = 14
		'
		'CbSiNo7
		'
		Me.CbSiNo7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbSiNo7.FormattingEnabled = True
		Me.CbSiNo7.Location = New System.Drawing.Point(3, 134)
		Me.CbSiNo7.Name = "CbSiNo7"
		Me.CbSiNo7.Size = New System.Drawing.Size(49, 21)
		Me.CbSiNo7.TabIndex = 12
		'
		'CbSiNo10
		'
		Me.CbSiNo10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbSiNo10.FormattingEnabled = True
		Me.CbSiNo10.Location = New System.Drawing.Point(3, 200)
		Me.CbSiNo10.Name = "CbSiNo10"
		Me.CbSiNo10.Size = New System.Drawing.Size(49, 21)
		Me.CbSiNo10.TabIndex = 18
		'
		'TxtCampo10
		'
		Me.TxtCampo10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtCampo10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtCampo10.Location = New System.Drawing.Point(54, 201)
		Me.TxtCampo10.MaxLength = 250
		Me.TxtCampo10.Name = "TxtCampo10"
		Me.TxtCampo10.Size = New System.Drawing.Size(99, 20)
		Me.TxtCampo10.TabIndex = 19
		'
		'CbSiNo6
		'
		Me.CbSiNo6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbSiNo6.FormattingEnabled = True
		Me.CbSiNo6.Location = New System.Drawing.Point(3, 112)
		Me.CbSiNo6.Name = "CbSiNo6"
		Me.CbSiNo6.Size = New System.Drawing.Size(49, 21)
		Me.CbSiNo6.TabIndex = 10
		'
		'TxtCampo9
		'
		Me.TxtCampo9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtCampo9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtCampo9.Location = New System.Drawing.Point(54, 179)
		Me.TxtCampo9.MaxLength = 250
		Me.TxtCampo9.Name = "TxtCampo9"
		Me.TxtCampo9.Size = New System.Drawing.Size(99, 20)
		Me.TxtCampo9.TabIndex = 17
		'
		'TxtCampo8
		'
		Me.TxtCampo8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtCampo8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtCampo8.Location = New System.Drawing.Point(54, 157)
		Me.TxtCampo8.MaxLength = 250
		Me.TxtCampo8.Name = "TxtCampo8"
		Me.TxtCampo8.Size = New System.Drawing.Size(99, 20)
		Me.TxtCampo8.TabIndex = 15
		'
		'TxtCampo6
		'
		Me.TxtCampo6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtCampo6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtCampo6.Location = New System.Drawing.Point(54, 113)
		Me.TxtCampo6.MaxLength = 250
		Me.TxtCampo6.Name = "TxtCampo6"
		Me.TxtCampo6.Size = New System.Drawing.Size(99, 20)
		Me.TxtCampo6.TabIndex = 11
		'
		'TxtCampo7
		'
		Me.TxtCampo7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtCampo7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtCampo7.Location = New System.Drawing.Point(54, 135)
		Me.TxtCampo7.MaxLength = 250
		Me.TxtCampo7.Name = "TxtCampo7"
		Me.TxtCampo7.Size = New System.Drawing.Size(99, 20)
		Me.TxtCampo7.TabIndex = 13
		'
		'CbSiNo4
		'
		Me.CbSiNo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbSiNo4.FormattingEnabled = True
		Me.CbSiNo4.Location = New System.Drawing.Point(3, 68)
		Me.CbSiNo4.Name = "CbSiNo4"
		Me.CbSiNo4.Size = New System.Drawing.Size(49, 21)
		Me.CbSiNo4.TabIndex = 6
		'
		'CbSiNo3
		'
		Me.CbSiNo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbSiNo3.FormattingEnabled = True
		Me.CbSiNo3.Location = New System.Drawing.Point(3, 46)
		Me.CbSiNo3.Name = "CbSiNo3"
		Me.CbSiNo3.Size = New System.Drawing.Size(49, 21)
		Me.CbSiNo3.TabIndex = 4
		'
		'CbSiNo2
		'
		Me.CbSiNo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbSiNo2.FormattingEnabled = True
		Me.CbSiNo2.Location = New System.Drawing.Point(3, 24)
		Me.CbSiNo2.Name = "CbSiNo2"
		Me.CbSiNo2.Size = New System.Drawing.Size(49, 21)
		Me.CbSiNo2.TabIndex = 2
		'
		'CbSiNo5
		'
		Me.CbSiNo5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbSiNo5.FormattingEnabled = True
		Me.CbSiNo5.Location = New System.Drawing.Point(3, 90)
		Me.CbSiNo5.Name = "CbSiNo5"
		Me.CbSiNo5.Size = New System.Drawing.Size(49, 21)
		Me.CbSiNo5.TabIndex = 8
		'
		'TxtCampo5
		'
		Me.TxtCampo5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtCampo5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtCampo5.Location = New System.Drawing.Point(54, 91)
		Me.TxtCampo5.MaxLength = 250
		Me.TxtCampo5.Name = "TxtCampo5"
		Me.TxtCampo5.Size = New System.Drawing.Size(99, 20)
		Me.TxtCampo5.TabIndex = 9
		'
		'CbSiNo1
		'
		Me.CbSiNo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbSiNo1.FormattingEnabled = True
		Me.CbSiNo1.Location = New System.Drawing.Point(3, 2)
		Me.CbSiNo1.Name = "CbSiNo1"
		Me.CbSiNo1.Size = New System.Drawing.Size(49, 21)
		Me.CbSiNo1.TabIndex = 0
		'
		'TxtCampo4
		'
		Me.TxtCampo4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtCampo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtCampo4.Location = New System.Drawing.Point(54, 69)
		Me.TxtCampo4.MaxLength = 250
		Me.TxtCampo4.Name = "TxtCampo4"
		Me.TxtCampo4.Size = New System.Drawing.Size(99, 20)
		Me.TxtCampo4.TabIndex = 7
		'
		'TxtCampo3
		'
		Me.TxtCampo3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtCampo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtCampo3.Location = New System.Drawing.Point(54, 47)
		Me.TxtCampo3.MaxLength = 250
		Me.TxtCampo3.Name = "TxtCampo3"
		Me.TxtCampo3.Size = New System.Drawing.Size(99, 20)
		Me.TxtCampo3.TabIndex = 5
		'
		'TxtCampo1
		'
		Me.TxtCampo1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtCampo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtCampo1.Location = New System.Drawing.Point(54, 3)
		Me.TxtCampo1.MaxLength = 250
		Me.TxtCampo1.Name = "TxtCampo1"
		Me.TxtCampo1.Size = New System.Drawing.Size(99, 20)
		Me.TxtCampo1.TabIndex = 1
		'
		'TxtCampo2
		'
		Me.TxtCampo2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtCampo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtCampo2.Location = New System.Drawing.Point(54, 25)
		Me.TxtCampo2.MaxLength = 250
		Me.TxtCampo2.Name = "TxtCampo2"
		Me.TxtCampo2.Size = New System.Drawing.Size(99, 20)
		Me.TxtCampo2.TabIndex = 3
		'
		'LnkBorrar
		'
		Me.LnkBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.LnkBorrar.AutoSize = True
		Me.LnkBorrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkBorrar.Location = New System.Drawing.Point(4, 263)
		Me.LnkBorrar.Name = "LnkBorrar"
		Me.LnkBorrar.Size = New System.Drawing.Size(43, 13)
		Me.LnkBorrar.TabIndex = 34
		Me.LnkBorrar.TabStop = True
		Me.LnkBorrar.Text = "Eliminar"
		'
		'LnkAbrir2
		'
		Me.LnkAbrir2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.LnkAbrir2.AutoSize = True
		Me.LnkAbrir2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkAbrir2.Location = New System.Drawing.Point(218, 263)
		Me.LnkAbrir2.Name = "LnkAbrir2"
		Me.LnkAbrir2.Size = New System.Drawing.Size(28, 13)
		Me.LnkAbrir2.TabIndex = 33
		Me.LnkAbrir2.TabStop = True
		Me.LnkAbrir2.Text = "Abrir"
		'
		'CmdActualizar
		'
		Me.CmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdActualizar.BackColor = System.Drawing.Color.White
		Me.CmdActualizar.BackgroundImage = CType(resources.GetObject("CmdActualizar.BackgroundImage"), System.Drawing.Image)
		Me.CmdActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdActualizar.ForeColor = System.Drawing.Color.White
		Me.CmdActualizar.Location = New System.Drawing.Point(374, 258)
		Me.CmdActualizar.Name = "CmdActualizar"
		Me.CmdActualizar.Size = New System.Drawing.Size(75, 23)
		Me.CmdActualizar.TabIndex = 0
		Me.CmdActualizar.Text = "Actualizar"
		Me.CmdActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdActualizar.UseVisualStyleBackColor = True
		'
		'LnkEnviar
		'
		Me.LnkEnviar.AutoSize = True
		Me.LnkEnviar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkEnviar.Location = New System.Drawing.Point(3, 6)
		Me.LnkEnviar.Name = "LnkEnviar"
		Me.LnkEnviar.Size = New System.Drawing.Size(37, 13)
		Me.LnkEnviar.TabIndex = 11
		Me.LnkEnviar.TabStop = True
		Me.LnkEnviar.Text = "Enviar"
		'
		'LnkAbrirPrograma
		'
		Me.LnkAbrirPrograma.AutoSize = True
		Me.LnkAbrirPrograma.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkAbrirPrograma.Location = New System.Drawing.Point(48, 6)
		Me.LnkAbrirPrograma.Name = "LnkAbrirPrograma"
		Me.LnkAbrirPrograma.Size = New System.Drawing.Size(76, 13)
		Me.LnkAbrirPrograma.TabIndex = 12
		Me.LnkAbrirPrograma.TabStop = True
		Me.LnkAbrirPrograma.Text = "Abrir Programa"
		'
		'LnkRegresar
		'
		Me.LnkRegresar.AutoSize = True
		Me.LnkRegresar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkRegresar.Location = New System.Drawing.Point(130, 6)
		Me.LnkRegresar.Name = "LnkRegresar"
		Me.LnkRegresar.Size = New System.Drawing.Size(50, 13)
		Me.LnkRegresar.TabIndex = 13
		Me.LnkRegresar.TabStop = True
		Me.LnkRegresar.Text = "Regresar"
		Me.LnkRegresar.Visible = False
		'
		'LnkConfig
		'
		Me.LnkConfig.AutoSize = True
		Me.LnkConfig.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkConfig.Location = New System.Drawing.Point(198, 6)
		Me.LnkConfig.Name = "LnkConfig"
		Me.LnkConfig.Size = New System.Drawing.Size(65, 13)
		Me.LnkConfig.TabIndex = 36
		Me.LnkConfig.TabStop = True
		Me.LnkConfig.Text = "Acerca de..."
		'
		'GrdDigi
		'
		Me.GrdDigi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GrdDigi.AutoSize = True
		Me.GrdDigi.DMSCopiarDt = True
		Me.GrdDigi.DMSTituloDelInforme = ""
		Me.GrdDigi.Location = New System.Drawing.Point(3, 29)
		Me.GrdDigi.Name = "GrdDigi"
		Me.GrdDigi.Size = New System.Drawing.Size(477, 314)
		Me.GrdDigi.TabIndex = 8
		'
		'Digitalizador
		'
		Me.AllowDrop = True
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Controls.Add(Me.LnkConfig)
		Me.Controls.Add(Me.PnlEditar)
		Me.Controls.Add(Me.LnkAbrirPrograma)
		Me.Controls.Add(Me.LnkEnviar)
		Me.Controls.Add(Me.LnkAbrirArchivo)
		Me.Controls.Add(Me.GrdDigi)
		Me.Controls.Add(Me.LnkEditar)
		Me.Controls.Add(Me.LnkNuevoArchivo)
		Me.Controls.Add(Me.LnkRegresar)
		Me.MinimumSize = New System.Drawing.Size(483, 347)
		Me.Name = "Digitalizador"
		Me.Size = New System.Drawing.Size(483, 347)
		Me.PnlEditar.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.TabControl1.ResumeLayout(False)
		Me.TbBasica.ResumeLayout(False)
		Me.TbBasica.PerformLayout()
		Me.TbAdicional.ResumeLayout(False)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.Panel2.PerformLayout()
		Me.SplitContainer1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LnkAbrirArchivo As System.Windows.Forms.LinkLabel
    Friend WithEvents PnlEditar As System.Windows.Forms.Panel
    Friend WithEvents LblRuta As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtArchivo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Public WithEvents GrdDigi As SMDPpal.GridDms
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LnkEnviar As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkAbrirPrograma As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkRegresar As System.Windows.Forms.LinkLabel
    Friend WithEvents CbClasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblCampo5 As System.Windows.Forms.Label
    Friend WithEvents TxtCampo5 As System.Windows.Forms.TextBox
    Friend WithEvents LblCampo4 As System.Windows.Forms.Label
    Friend WithEvents TxtCampo4 As System.Windows.Forms.TextBox
    Friend WithEvents LblCampo3 As System.Windows.Forms.Label
    Friend WithEvents TxtCampo3 As System.Windows.Forms.TextBox
    Friend WithEvents LblCampo2 As System.Windows.Forms.Label
    Friend WithEvents TxtCampo2 As System.Windows.Forms.TextBox
    Friend WithEvents LblCampo1 As System.Windows.Forms.Label
    Friend WithEvents TxtCampo1 As System.Windows.Forms.TextBox
    Friend WithEvents LnkBorrar As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkAbrir2 As System.Windows.Forms.LinkLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TbBasica As System.Windows.Forms.TabPage
    Friend WithEvents TbAdicional As System.Windows.Forms.TabPage
    Friend WithEvents CbSiNo1 As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CbSiNo4 As System.Windows.Forms.ComboBox
    Friend WithEvents CbSiNo3 As System.Windows.Forms.ComboBox
    Friend WithEvents CbSiNo2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbSiNo5 As System.Windows.Forms.ComboBox
    Friend WithEvents LblCampo6 As System.Windows.Forms.Label
    Friend WithEvents LblCampo7 As System.Windows.Forms.Label
    Friend WithEvents LblCampo8 As System.Windows.Forms.Label
    Friend WithEvents LblCampo9 As System.Windows.Forms.Label
    Friend WithEvents LblCampo10 As System.Windows.Forms.Label
    Friend WithEvents CbSiNo9 As System.Windows.Forms.ComboBox
    Friend WithEvents CbSiNo8 As System.Windows.Forms.ComboBox
    Friend WithEvents CbSiNo7 As System.Windows.Forms.ComboBox
    Friend WithEvents CbSiNo10 As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCampo10 As System.Windows.Forms.TextBox
    Friend WithEvents CbSiNo6 As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCampo9 As System.Windows.Forms.TextBox
    Friend WithEvents TxtCampo8 As System.Windows.Forms.TextBox
    Friend WithEvents TxtCampo6 As System.Windows.Forms.TextBox
    Friend WithEvents TxtCampo7 As System.Windows.Forms.TextBox
    Friend WithEvents LblTamaño As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LnkConfig As System.Windows.Forms.LinkLabel
    Friend WithEvents CbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmdBuscar As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancel As SMDPpal.BotonEstandar
    Friend WithEvents CmdActualizar As SMDPpal.BotonEstandar
    Public WithEvents LnkNuevoArchivo As LinkLabel
    Public WithEvents LnkEditar As LinkLabel
End Class
