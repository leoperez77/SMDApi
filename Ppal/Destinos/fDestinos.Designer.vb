<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fDestinos
	Inherits SMDPpal.AdvanceForm

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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fDestinos))
		Me.TreeView1 = New System.Windows.Forms.TreeView()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ToolDevolver = New System.Windows.Forms.ToolStripMenuItem()
		Me.TollAdi = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolEdi = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolEli = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolPosicion = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolMovto = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.TxtBuscar = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GrdBus = New SMDPpal.GridDms()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.LblMensaje = New System.Windows.Forms.Label()
		Me.CmdCancelar = New SMDPpal.BotonEstandar()
		Me.CmdAmpliar = New System.Windows.Forms.Button()
		Me.ChkAbuelo = New System.Windows.Forms.CheckBox()
		Me.LnkVerTree = New System.Windows.Forms.LinkLabel()
		Me.ChkInac = New System.Windows.Forms.CheckBox()
		Me.LnkExpandir = New System.Windows.Forms.LinkLabel()
		Me.CmdDestiCta = New SMDPpal.BotonEstandar()
		Me.CmdCancelar2 = New SMDPpal.BotonEstandar()
		Me.PnlMover = New System.Windows.Forms.Panel()
		Me.CmdCancelarMover = New SMDPpal.BotonEstandar()
		Me.CmdMover = New SMDPpal.BotonEstandar()
		Me.LblExplica = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ChkOcultarIDS = New System.Windows.Forms.CheckBox()
		Me.LnkVerAuditoria = New System.Windows.Forms.LinkLabel()
		Me.CmdBusque = New SMDPpal.BotonEstandar()
		Me.LnkRefrescar = New System.Windows.Forms.LinkLabel()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.PnlMover.SuspendLayout()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(769, 0)
		'
		'TreeView1
		'
		Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip1
		Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TreeView1.HideSelection = False
		Me.TreeView1.Location = New System.Drawing.Point(0, 0)
		Me.TreeView1.Name = "TreeView1"
		Me.TreeView1.ShowNodeToolTips = True
		Me.TreeView1.Size = New System.Drawing.Size(441, 501)
		Me.TreeView1.TabIndex = 4
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolDevolver, Me.TollAdi, Me.ToolEdi, Me.ToolEli, Me.ToolStripSeparator1, Me.ToolPosicion, Me.ToolStripMenuItem2, Me.ToolMovto})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(218, 170)
		'
		'ToolDevolver
		'
		Me.ToolDevolver.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ToolDevolver.Name = "ToolDevolver"
		Me.ToolDevolver.Size = New System.Drawing.Size(217, 22)
		Me.ToolDevolver.Text = "Devolver destino (ENTER)"
		'
		'TollAdi
		'
		Me.TollAdi.Name = "TollAdi"
		Me.TollAdi.ShortcutKeys = System.Windows.Forms.Keys.F4
		Me.TollAdi.Size = New System.Drawing.Size(217, 22)
		Me.TollAdi.Text = "Adicionar..."
		'
		'ToolEdi
		'
		Me.ToolEdi.Name = "ToolEdi"
		Me.ToolEdi.ShortcutKeys = System.Windows.Forms.Keys.F2
		Me.ToolEdi.Size = New System.Drawing.Size(217, 22)
		Me.ToolEdi.Text = "Editar..."
		'
		'ToolEli
		'
		Me.ToolEli.Name = "ToolEli"
		Me.ToolEli.Size = New System.Drawing.Size(217, 22)
		Me.ToolEli.Text = "Eliminar"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(214, 6)
		'
		'ToolPosicion
		'
		Me.ToolPosicion.Name = "ToolPosicion"
		Me.ToolPosicion.Size = New System.Drawing.Size(217, 22)
		Me.ToolPosicion.Text = "Cambiar posición del nodo"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(214, 6)
		'
		'ToolMovto
		'
		Me.ToolMovto.Name = "ToolMovto"
		Me.ToolMovto.Size = New System.Drawing.Size(217, 22)
		Me.ToolMovto.Text = "Consultar movimiento"
		'
		'ImageList1
		'
		Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
		Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
		'
		'TxtBuscar
		'
		Me.TxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtBuscar.Location = New System.Drawing.Point(7, 154)
		Me.TxtBuscar.Name = "TxtBuscar"
		Me.TxtBuscar.Size = New System.Drawing.Size(156, 20)
		Me.TxtBuscar.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(7, 137)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(94, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Texto/ID a buscar"
		'
		'GrdBus
		'
		Me.GrdBus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GrdBus.DMSCopiarDt = True
		Me.GrdBus.DMSTituloDelInforme = ""
		Me.GrdBus.Location = New System.Drawing.Point(7, 180)
		Me.GrdBus.Name = "GrdBus"
		Me.GrdBus.Size = New System.Drawing.Size(331, 318)
		Me.GrdBus.TabIndex = 5
		Me.GrdBus.Visible = False
		'
		'SplitContainer1
		'
		Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.LblMensaje)
		Me.SplitContainer1.Panel1.Controls.Add(Me.CmdCancelar)
		Me.SplitContainer1.Panel1.Controls.Add(Me.CmdAmpliar)
		Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.ChkAbuelo)
		Me.SplitContainer1.Panel2.Controls.Add(Me.LnkVerTree)
		Me.SplitContainer1.Panel2.Controls.Add(Me.ChkInac)
		Me.SplitContainer1.Panel2.Controls.Add(Me.LnkExpandir)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CmdDestiCta)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CmdCancelar2)
		Me.SplitContainer1.Panel2.Controls.Add(Me.PnlMover)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
		Me.SplitContainer1.Panel2.Controls.Add(Me.ChkOcultarIDS)
		Me.SplitContainer1.Panel2.Controls.Add(Me.LnkVerAuditoria)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CmdBusque)
		Me.SplitContainer1.Panel2.Controls.Add(Me.LnkRefrescar)
		Me.SplitContainer1.Panel2.Controls.Add(Me.GrdBus)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TxtBuscar)
		Me.SplitContainer1.Size = New System.Drawing.Size(790, 503)
		Me.SplitContainer1.SplitterDistance = 443
		Me.SplitContainer1.TabIndex = 6
		'
		'LblMensaje
		'
		Me.LblMensaje.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.LblMensaje.BackColor = System.Drawing.SystemColors.Control
		Me.LblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblMensaje.Location = New System.Drawing.Point(48, 133)
		Me.LblMensaje.Name = "LblMensaje"
		Me.LblMensaje.Size = New System.Drawing.Size(347, 270)
		Me.LblMensaje.TabIndex = 16
		Me.LblMensaje.Text = "2000." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No se muestra el árbol por asuntos de velocidad." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si desea ver los des" &
	"tinos en árbol, haga clic en [Ver árbol de nodos]"
		Me.LblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'CmdCancelar
		'
		Me.CmdCancelar.BackColor = System.Drawing.Color.White
		Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancelar.ForeColor = System.Drawing.Color.White
		Me.CmdCancelar.Location = New System.Drawing.Point(212, 77)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(75, 39)
		Me.CmdCancelar.TabIndex = 2
		Me.CmdCancelar.Text = "Cancelar"
		Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancelar.UseVisualStyleBackColor = False
		'
		'CmdAmpliar
		'
		Me.CmdAmpliar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdAmpliar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.CmdAmpliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdAmpliar.Location = New System.Drawing.Point(395, 29)
		Me.CmdAmpliar.Name = "CmdAmpliar"
		Me.CmdAmpliar.Size = New System.Drawing.Size(23, 40)
		Me.CmdAmpliar.TabIndex = 5
		Me.CmdAmpliar.Tag = ""
		Me.CmdAmpliar.Text = "◄"
		Me.CmdAmpliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.CmdAmpliar.UseVisualStyleBackColor = True
		'
		'ChkAbuelo
		'
		Me.ChkAbuelo.AutoSize = True
		Me.ChkAbuelo.ForeColor = System.Drawing.Color.Teal
		Me.ChkAbuelo.Location = New System.Drawing.Point(112, 135)
		Me.ChkAbuelo.Name = "ChkAbuelo"
		Me.ChkAbuelo.Size = New System.Drawing.Size(51, 17)
		Me.ChkAbuelo.TabIndex = 16
		Me.ChkAbuelo.Text = "Abue"
		Me.ToolTipAdvance.SetToolTip(Me.ChkAbuelo, "Ver abuelo y padre del nodo")
		Me.ChkAbuelo.UseVisualStyleBackColor = True
		'
		'LnkVerTree
		'
		Me.LnkVerTree.AutoSize = True
		Me.LnkVerTree.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkVerTree.Location = New System.Drawing.Point(142, 40)
		Me.LnkVerTree.Name = "LnkVerTree"
		Me.LnkVerTree.Size = New System.Drawing.Size(96, 13)
		Me.LnkVerTree.TabIndex = 15
		Me.LnkVerTree.TabStop = True
		Me.LnkVerTree.Text = "Ver árbol de nodos"
		Me.LnkVerTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ToolTipAdvance.SetToolTip(Me.LnkVerTree, "Cragar los nodos y mostrarlos en el árbol")
		'
		'ChkInac
		'
		Me.ChkInac.AutoSize = True
		Me.ChkInac.Location = New System.Drawing.Point(172, 11)
		Me.ChkInac.Name = "ChkInac"
		Me.ChkInac.Size = New System.Drawing.Size(99, 17)
		Me.ChkInac.TabIndex = 14
		Me.ChkInac.Text = "Incluir inactivos"
		Me.ToolTipAdvance.SetToolTip(Me.ChkInac, "Muestra en el árbol los destinos inactivos en color rojo")
		Me.ChkInac.UseVisualStyleBackColor = True
		'
		'LnkExpandir
		'
		Me.LnkExpandir.AutoSize = True
		Me.LnkExpandir.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkExpandir.Location = New System.Drawing.Point(17, 97)
		Me.LnkExpandir.Name = "LnkExpandir"
		Me.LnkExpandir.Size = New System.Drawing.Size(71, 13)
		Me.LnkExpandir.TabIndex = 13
		Me.LnkExpandir.TabStop = True
		Me.LnkExpandir.Text = "Mostrar todos"
		Me.ToolTipAdvance.SetToolTip(Me.LnkExpandir, "Muestra todos los nodos cargados en el árbol")
		'
		'CmdDestiCta
		'
		Me.CmdDestiCta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdDestiCta.BackColor = System.Drawing.Color.White
		Me.CmdDestiCta.BackgroundImage = CType(resources.GetObject("CmdDestiCta.BackgroundImage"), System.Drawing.Image)
		Me.CmdDestiCta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdDestiCta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdDestiCta.ForeColor = System.Drawing.Color.White
		Me.CmdDestiCta.Location = New System.Drawing.Point(250, 140)
		Me.CmdDestiCta.Name = "CmdDestiCta"
		Me.CmdDestiCta.Size = New System.Drawing.Size(88, 37)
		Me.CmdDestiCta.TabIndex = 12
		Me.CmdDestiCta.Text = "Destinos de la cuenta"
		Me.CmdDestiCta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdDestiCta.UseVisualStyleBackColor = False
		'
		'CmdCancelar2
		'
		Me.CmdCancelar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdCancelar2.BackColor = System.Drawing.Color.White
		Me.CmdCancelar2.BackgroundImage = CType(resources.GetObject("CmdCancelar2.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancelar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancelar2.ForeColor = System.Drawing.Color.White
		Me.CmdCancelar2.Location = New System.Drawing.Point(220, 91)
		Me.CmdCancelar2.Name = "CmdCancelar2"
		Me.CmdCancelar2.Size = New System.Drawing.Size(110, 25)
		Me.CmdCancelar2.TabIndex = 11
		Me.CmdCancelar2.Text = "Cancelar"
		Me.CmdCancelar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancelar2.UseVisualStyleBackColor = False
		'
		'PnlMover
		'
		Me.PnlMover.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.PnlMover.BackColor = System.Drawing.Color.LemonChiffon
		Me.PnlMover.Controls.Add(Me.CmdCancelarMover)
		Me.PnlMover.Controls.Add(Me.CmdMover)
		Me.PnlMover.Controls.Add(Me.LblExplica)
		Me.PnlMover.Location = New System.Drawing.Point(7, 225)
		Me.PnlMover.Name = "PnlMover"
		Me.PnlMover.Size = New System.Drawing.Size(336, 224)
		Me.PnlMover.TabIndex = 9
		Me.PnlMover.Visible = False
		'
		'CmdCancelarMover
		'
		Me.CmdCancelarMover.BackColor = System.Drawing.Color.White
		Me.CmdCancelarMover.BackgroundImage = CType(resources.GetObject("CmdCancelarMover.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancelarMover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancelarMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancelarMover.ForeColor = System.Drawing.Color.White
		Me.CmdCancelarMover.Location = New System.Drawing.Point(162, 170)
		Me.CmdCancelarMover.Name = "CmdCancelarMover"
		Me.CmdCancelarMover.Size = New System.Drawing.Size(96, 39)
		Me.CmdCancelarMover.TabIndex = 6
		Me.CmdCancelarMover.Text = "Cancelar"
		Me.CmdCancelarMover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancelarMover.UseVisualStyleBackColor = False
		'
		'CmdMover
		'
		Me.CmdMover.BackColor = System.Drawing.Color.White
		Me.CmdMover.BackgroundImage = CType(resources.GetObject("CmdMover.BackgroundImage"), System.Drawing.Image)
		Me.CmdMover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdMover.ForeColor = System.Drawing.Color.White
		Me.CmdMover.Location = New System.Drawing.Point(60, 170)
		Me.CmdMover.Name = "CmdMover"
		Me.CmdMover.Size = New System.Drawing.Size(96, 39)
		Me.CmdMover.TabIndex = 5
		Me.CmdMover.Text = "Mover"
		Me.CmdMover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdMover.UseVisualStyleBackColor = False
		'
		'LblExplica
		'
		Me.LblExplica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblExplica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblExplica.Location = New System.Drawing.Point(2, 2)
		Me.LblExplica.Name = "LblExplica"
		Me.LblExplica.Size = New System.Drawing.Size(331, 153)
		Me.LblExplica.TabIndex = 4
		Me.LblExplica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label2.BackColor = System.Drawing.Color.Maroon
		Me.Label2.Location = New System.Drawing.Point(0, 126)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(339, 4)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "     "
		'
		'ChkOcultarIDS
		'
		Me.ChkOcultarIDS.AutoSize = True
		Me.ChkOcultarIDS.Location = New System.Drawing.Point(20, 11)
		Me.ChkOcultarIDS.Name = "ChkOcultarIDS"
		Me.ChkOcultarIDS.Size = New System.Drawing.Size(143, 17)
		Me.ChkOcultarIDS.TabIndex = 7
		Me.ChkOcultarIDS.Text = "Ocultar ID de cada nodo"
		Me.ToolTipAdvance.SetToolTip(Me.ChkOcultarIDS, "No muestra el ID de cada nodo")
		Me.ChkOcultarIDS.UseVisualStyleBackColor = True
		'
		'LnkVerAuditoria
		'
		Me.LnkVerAuditoria.AutoSize = True
		Me.LnkVerAuditoria.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkVerAuditoria.Location = New System.Drawing.Point(17, 67)
		Me.LnkVerAuditoria.Name = "LnkVerAuditoria"
		Me.LnkVerAuditoria.Size = New System.Drawing.Size(68, 13)
		Me.LnkVerAuditoria.TabIndex = 6
		Me.LnkVerAuditoria.TabStop = True
		Me.LnkVerAuditoria.Text = "Ver auditoría"
		'
		'CmdBusque
		'
		Me.CmdBusque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdBusque.BackColor = System.Drawing.Color.White
		Me.CmdBusque.BackgroundImage = CType(resources.GetObject("CmdBusque.BackgroundImage"), System.Drawing.Image)
		Me.CmdBusque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdBusque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdBusque.ForeColor = System.Drawing.Color.White
		Me.CmdBusque.Location = New System.Drawing.Point(169, 140)
		Me.CmdBusque.Name = "CmdBusque"
		Me.CmdBusque.Size = New System.Drawing.Size(75, 35)
		Me.CmdBusque.TabIndex = 1
		Me.CmdBusque.Text = "Buscar"
		Me.CmdBusque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdBusque.UseVisualStyleBackColor = False
		'
		'LnkRefrescar
		'
		Me.LnkRefrescar.AutoSize = True
		Me.LnkRefrescar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkRefrescar.Location = New System.Drawing.Point(17, 40)
		Me.LnkRefrescar.Name = "LnkRefrescar"
		Me.LnkRefrescar.Size = New System.Drawing.Size(85, 13)
		Me.LnkRefrescar.TabIndex = 3
		Me.LnkRefrescar.TabStop = True
		Me.LnkRefrescar.Text = "Refrescar nodos"
		Me.LnkRefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'fDestinos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.CmdCancelar
		Me.ClientSize = New System.Drawing.Size(790, 503)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "fDestinos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Seleccione destino"
		Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.Panel2.PerformLayout()
		Me.SplitContainer1.ResumeLayout(False)
		Me.PnlMover.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
	Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents TollAdi As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolEdi As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolEli As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents GrdBus As SMDPpal.GridDms
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
	Friend WithEvents LnkRefrescar As System.Windows.Forms.LinkLabel
	Friend WithEvents ToolDevolver As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
	Friend WithEvents CmdBusque As SMDPpal.BotonEstandar
	Friend WithEvents LnkVerAuditoria As System.Windows.Forms.LinkLabel
	Friend WithEvents ChkOcultarIDS As System.Windows.Forms.CheckBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolMovto As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolPosicion As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PnlMover As System.Windows.Forms.Panel
	Friend WithEvents LblExplica As System.Windows.Forms.Label
	Friend WithEvents CmdCancelarMover As SMDPpal.BotonEstandar
	Friend WithEvents CmdMover As SMDPpal.BotonEstandar
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
	Friend WithEvents CmdAmpliar As System.Windows.Forms.Button
	Friend WithEvents CmdCancelar2 As SMDPpal.BotonEstandar
	Friend WithEvents CmdDestiCta As SMDPpal.BotonEstandar
	Friend WithEvents LnkExpandir As System.Windows.Forms.LinkLabel
	Friend WithEvents ChkInac As CheckBox
	Friend WithEvents LnkVerTree As LinkLabel
	Friend WithEvents LblMensaje As Label
	Friend WithEvents ChkAbuelo As CheckBox
End Class
