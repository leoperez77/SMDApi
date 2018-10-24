<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fCampito
	Inherits System.Windows.Forms.Form

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCampito))
		Me.CmdCancelar = New SMDPpal.BotonEstandar()
		Me.LblAnt = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtTitulo = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.ChkNegrilla = New System.Windows.Forms.CheckBox()
		Me.ChkOculto = New System.Windows.Forms.CheckBox()
		Me.CmdEliminarCampo = New System.Windows.Forms.Button()
		Me.TxtTamY = New System.Windows.Forms.TextBox()
		Me.LblTamYl = New System.Windows.Forms.Label()
		Me.TxtTamX = New System.Windows.Forms.TextBox()
		Me.LblTamXl = New System.Windows.Forms.Label()
		Me.TxtPosY = New System.Windows.Forms.TextBox()
		Me.LblPosYl = New System.Windows.Forms.Label()
		Me.TxtPosX = New System.Windows.Forms.TextBox()
		Me.LblPosXl = New System.Windows.Forms.Label()
		Me.CmdAceptar = New SMDPpal.BotonEstandar()
		Me.GrpLoc = New System.Windows.Forms.GroupBox()
		Me.LblDatosForma = New System.Windows.Forms.Label()
		Me.LblTamY = New System.Windows.Forms.Label()
		Me.LblTamX = New System.Windows.Forms.Label()
		Me.LblPosY = New System.Windows.Forms.Label()
		Me.LblPosX = New System.Windows.Forms.Label()
		Me.CmdFuente = New SMDPpal.BotonEstandar()
		Me.CmdColorLetra = New SMDPpal.BotonEstandar()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.LnkFuenteDefault = New System.Windows.Forms.Label()
		Me.LnkColorBackDefault = New System.Windows.Forms.Label()
		Me.LnkColorDefault = New System.Windows.Forms.Label()
		Me.CmdColorFondo = New SMDPpal.BotonEstandar()
		Me.LblPrueba = New System.Windows.Forms.Label()
		Me.DialogoColor = New System.Windows.Forms.ColorDialog()
		Me.DialogoFont = New System.Windows.Forms.FontDialog()
		Me.TxtTool = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.GrpLoc.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'CmdCancelar
		'
		Me.CmdCancelar.BackColor = System.Drawing.Color.White
		Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancelar.ForeColor = System.Drawing.Color.White
		Me.CmdCancelar.Location = New System.Drawing.Point(27, 334)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(104, 57)
		Me.CmdCancelar.TabIndex = 1
		Me.CmdCancelar.Text = "Cancelar"
		Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancelar.UseVisualStyleBackColor = False
		'
		'LblAnt
		'
		Me.LblAnt.BackColor = System.Drawing.Color.White
		Me.LblAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblAnt.Location = New System.Drawing.Point(22, 22)
		Me.LblAnt.Name = "LblAnt"
		Me.LblAnt.Size = New System.Drawing.Size(182, 36)
		Me.LblAnt.TabIndex = 28
		Me.LblAnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(19, 5)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(84, 13)
		Me.Label1.TabIndex = 29
		Me.Label1.Text = "Texto de default"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(19, 63)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(77, 13)
		Me.Label2.TabIndex = 33
		Me.Label2.Text = "Texto personal"
		'
		'TxtTitulo
		'
		Me.TxtTitulo.Location = New System.Drawing.Point(22, 82)
		Me.TxtTitulo.MaxLength = 80
		Me.TxtTitulo.Multiline = True
		Me.TxtTitulo.Name = "TxtTitulo"
		Me.TxtTitulo.Size = New System.Drawing.Size(182, 39)
		Me.TxtTitulo.TabIndex = 36
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.MintCream
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.TxtTitulo)
		Me.Panel1.Controls.Add(Me.LblAnt)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Location = New System.Drawing.Point(27, 10)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(218, 130)
		Me.Panel1.TabIndex = 37
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.MintCream
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel2.Controls.Add(Me.ChkNegrilla)
		Me.Panel2.Location = New System.Drawing.Point(473, 217)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(180, 100)
		Me.Panel2.TabIndex = 37
		'
		'ChkNegrilla
		'
		Me.ChkNegrilla.AutoSize = True
		Me.ChkNegrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkNegrilla.Location = New System.Drawing.Point(49, 38)
		Me.ChkNegrilla.Name = "ChkNegrilla"
		Me.ChkNegrilla.Size = New System.Drawing.Size(105, 17)
		Me.ChkNegrilla.TabIndex = 50
		Me.ChkNegrilla.Text = "Negrilla (bold)"
		Me.ChkNegrilla.UseVisualStyleBackColor = True
		'
		'ChkOculto
		'
		Me.ChkOculto.AutoSize = True
		Me.ChkOculto.Location = New System.Drawing.Point(183, 334)
		Me.ChkOculto.Name = "ChkOculto"
		Me.ChkOculto.Size = New System.Drawing.Size(259, 17)
		Me.ChkOculto.TabIndex = 38
		Me.ChkOculto.Text = "Ocultar este objeto. No será mostrado en pantalla"
		Me.ChkOculto.UseVisualStyleBackColor = True
		'
		'CmdEliminarCampo
		'
		Me.CmdEliminarCampo.BackColor = System.Drawing.Color.LightSalmon
		Me.CmdEliminarCampo.Location = New System.Drawing.Point(228, 358)
		Me.CmdEliminarCampo.Name = "CmdEliminarCampo"
		Me.CmdEliminarCampo.Size = New System.Drawing.Size(124, 33)
		Me.CmdEliminarCampo.TabIndex = 32
		Me.CmdEliminarCampo.Text = "Eliminar definición"
		Me.CmdEliminarCampo.UseVisualStyleBackColor = False
		'
		'TxtTamY
		'
		Me.TxtTamY.Location = New System.Drawing.Point(319, 72)
		Me.TxtTamY.MaxLength = 5
		Me.TxtTamY.Name = "TxtTamY"
		Me.TxtTamY.Size = New System.Drawing.Size(54, 20)
		Me.TxtTamY.TabIndex = 44
		Me.TxtTamY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'LblTamYl
		'
		Me.LblTamYl.AutoSize = True
		Me.LblTamYl.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LblTamYl.Location = New System.Drawing.Point(244, 75)
		Me.LblTamYl.Name = "LblTamYl"
		Me.LblTamYl.Size = New System.Drawing.Size(58, 13)
		Me.LblTamYl.TabIndex = 43
		Me.LblTamYl.Tag = ""
		Me.LblTamYl.Text = "Alto (tamY)"
		'
		'TxtTamX
		'
		Me.TxtTamX.Location = New System.Drawing.Point(319, 46)
		Me.TxtTamX.MaxLength = 5
		Me.TxtTamX.Name = "TxtTamX"
		Me.TxtTamX.Size = New System.Drawing.Size(54, 20)
		Me.TxtTamX.TabIndex = 42
		Me.TxtTamX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'LblTamXl
		'
		Me.LblTamXl.AutoSize = True
		Me.LblTamXl.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LblTamXl.Location = New System.Drawing.Point(244, 49)
		Me.LblTamXl.Name = "LblTamXl"
		Me.LblTamXl.Size = New System.Drawing.Size(71, 13)
		Me.LblTamXl.TabIndex = 41
		Me.LblTamXl.Tag = ""
		Me.LblTamXl.Text = "Ancho (tamX)"
		'
		'TxtPosY
		'
		Me.TxtPosY.Location = New System.Drawing.Point(109, 72)
		Me.TxtPosY.MaxLength = 5
		Me.TxtPosY.Name = "TxtPosY"
		Me.TxtPosY.Size = New System.Drawing.Size(54, 20)
		Me.TxtPosY.TabIndex = 40
		Me.TxtPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'LblPosYl
		'
		Me.LblPosYl.AutoSize = True
		Me.LblPosYl.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LblPosYl.Location = New System.Drawing.Point(21, 75)
		Me.LblPosYl.Name = "LblPosYl"
		Me.LblPosYl.Size = New System.Drawing.Size(67, 13)
		Me.LblPosYl.TabIndex = 39
		Me.LblPosYl.Tag = ""
		Me.LblPosYl.Text = "Arriba (posY)"
		'
		'TxtPosX
		'
		Me.TxtPosX.Location = New System.Drawing.Point(109, 46)
		Me.TxtPosX.MaxLength = 5
		Me.TxtPosX.Name = "TxtPosX"
		Me.TxtPosX.Size = New System.Drawing.Size(54, 20)
		Me.TxtPosX.TabIndex = 38
		Me.TxtPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'LblPosXl
		'
		Me.LblPosXl.AutoSize = True
		Me.LblPosXl.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LblPosXl.Location = New System.Drawing.Point(21, 49)
		Me.LblPosXl.Name = "LblPosXl"
		Me.LblPosXl.Size = New System.Drawing.Size(83, 13)
		Me.LblPosXl.TabIndex = 37
		Me.LblPosXl.Tag = ""
		Me.LblPosXl.Text = "Izquierda (posX)"
		'
		'CmdAceptar
		'
		Me.CmdAceptar.BackColor = System.Drawing.Color.White
		Me.CmdAceptar.BackgroundImage = CType(resources.GetObject("CmdAceptar.BackgroundImage"), System.Drawing.Image)
		Me.CmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdAceptar.ForeColor = System.Drawing.Color.White
		Me.CmdAceptar.Location = New System.Drawing.Point(473, 334)
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(180, 57)
		Me.CmdAceptar.TabIndex = 30
		Me.CmdAceptar.Text = "Aceptar"
		Me.CmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdAceptar.UseVisualStyleBackColor = False
		'
		'GrpLoc
		'
		Me.GrpLoc.BackColor = System.Drawing.Color.SeaShell
		Me.GrpLoc.Controls.Add(Me.LblDatosForma)
		Me.GrpLoc.Controls.Add(Me.LblTamY)
		Me.GrpLoc.Controls.Add(Me.LblTamX)
		Me.GrpLoc.Controls.Add(Me.LblPosY)
		Me.GrpLoc.Controls.Add(Me.LblPosX)
		Me.GrpLoc.Controls.Add(Me.TxtTamY)
		Me.GrpLoc.Controls.Add(Me.LblTamYl)
		Me.GrpLoc.Controls.Add(Me.LblPosXl)
		Me.GrpLoc.Controls.Add(Me.TxtTamX)
		Me.GrpLoc.Controls.Add(Me.TxtPosX)
		Me.GrpLoc.Controls.Add(Me.LblTamXl)
		Me.GrpLoc.Controls.Add(Me.LblPosYl)
		Me.GrpLoc.Controls.Add(Me.TxtPosY)
		Me.GrpLoc.Location = New System.Drawing.Point(27, 217)
		Me.GrpLoc.Name = "GrpLoc"
		Me.GrpLoc.Size = New System.Drawing.Size(433, 100)
		Me.GrpLoc.TabIndex = 40
		Me.GrpLoc.TabStop = False
		Me.GrpLoc.Text = "Cambie la posición y el tamaño del objeto"
		'
		'LblDatosForma
		'
		Me.LblDatosForma.AutoSize = True
		Me.LblDatosForma.ForeColor = System.Drawing.Color.Gray
		Me.LblDatosForma.Location = New System.Drawing.Point(170, 21)
		Me.LblDatosForma.Name = "LblDatosForma"
		Me.LblDatosForma.Size = New System.Drawing.Size(77, 13)
		Me.LblDatosForma.TabIndex = 52
		Me.LblDatosForma.Text = "Texto personal"
		'
		'LblTamY
		'
		Me.LblTamY.AutoSize = True
		Me.LblTamY.ForeColor = System.Drawing.Color.Blue
		Me.LblTamY.Location = New System.Drawing.Point(380, 75)
		Me.LblTamY.Name = "LblTamY"
		Me.LblTamY.Size = New System.Drawing.Size(35, 13)
		Me.LblTamY.TabIndex = 51
		Me.LblTamY.Tag = ""
		Me.LblTamY.Text = "Quitar"
		'
		'LblTamX
		'
		Me.LblTamX.AutoSize = True
		Me.LblTamX.ForeColor = System.Drawing.Color.Blue
		Me.LblTamX.Location = New System.Drawing.Point(379, 50)
		Me.LblTamX.Name = "LblTamX"
		Me.LblTamX.Size = New System.Drawing.Size(35, 13)
		Me.LblTamX.TabIndex = 50
		Me.LblTamX.Tag = ""
		Me.LblTamX.Text = "Quitar"
		'
		'LblPosY
		'
		Me.LblPosY.AutoSize = True
		Me.LblPosY.ForeColor = System.Drawing.Color.Blue
		Me.LblPosY.Location = New System.Drawing.Point(170, 75)
		Me.LblPosY.Name = "LblPosY"
		Me.LblPosY.Size = New System.Drawing.Size(35, 13)
		Me.LblPosY.TabIndex = 49
		Me.LblPosY.Tag = ""
		Me.LblPosY.Text = "Quitar"
		'
		'LblPosX
		'
		Me.LblPosX.AutoSize = True
		Me.LblPosX.ForeColor = System.Drawing.Color.Blue
		Me.LblPosX.Location = New System.Drawing.Point(169, 50)
		Me.LblPosX.Name = "LblPosX"
		Me.LblPosX.Size = New System.Drawing.Size(35, 13)
		Me.LblPosX.TabIndex = 48
		Me.LblPosX.Tag = ""
		Me.LblPosX.Text = "Quitar"
		'
		'CmdFuente
		'
		Me.CmdFuente.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.CmdFuente.BackgroundImage = CType(resources.GetObject("CmdFuente.BackgroundImage"), System.Drawing.Image)
		Me.CmdFuente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdFuente.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdFuente.ForeColor = System.Drawing.Color.White
		Me.CmdFuente.Location = New System.Drawing.Point(247, 83)
		Me.CmdFuente.Name = "CmdFuente"
		Me.CmdFuente.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdFuente.Size = New System.Drawing.Size(91, 27)
		Me.CmdFuente.TabIndex = 42
		Me.CmdFuente.Text = "Fuente"
		Me.CmdFuente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdFuente.UseVisualStyleBackColor = False
		'
		'CmdColorLetra
		'
		Me.CmdColorLetra.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.CmdColorLetra.BackgroundImage = CType(resources.GetObject("CmdColorLetra.BackgroundImage"), System.Drawing.Image)
		Me.CmdColorLetra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdColorLetra.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdColorLetra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdColorLetra.ForeColor = System.Drawing.Color.White
		Me.CmdColorLetra.Location = New System.Drawing.Point(247, 21)
		Me.CmdColorLetra.Name = "CmdColorLetra"
		Me.CmdColorLetra.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdColorLetra.Size = New System.Drawing.Size(91, 27)
		Me.CmdColorLetra.TabIndex = 41
		Me.CmdColorLetra.Text = "Color letra"
		Me.CmdColorLetra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdColorLetra.UseVisualStyleBackColor = False
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.SeaShell
		Me.GroupBox1.Controls.Add(Me.LnkFuenteDefault)
		Me.GroupBox1.Controls.Add(Me.LnkColorBackDefault)
		Me.GroupBox1.Controls.Add(Me.LnkColorDefault)
		Me.GroupBox1.Controls.Add(Me.CmdColorFondo)
		Me.GroupBox1.Controls.Add(Me.LblPrueba)
		Me.GroupBox1.Controls.Add(Me.CmdFuente)
		Me.GroupBox1.Controls.Add(Me.CmdColorLetra)
		Me.GroupBox1.Location = New System.Drawing.Point(251, 10)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(402, 129)
		Me.GroupBox1.TabIndex = 43
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Fuente y color"
		'
		'LnkFuenteDefault
		'
		Me.LnkFuenteDefault.AutoSize = True
		Me.LnkFuenteDefault.ForeColor = System.Drawing.Color.Blue
		Me.LnkFuenteDefault.Location = New System.Drawing.Point(344, 92)
		Me.LnkFuenteDefault.Name = "LnkFuenteDefault"
		Me.LnkFuenteDefault.Size = New System.Drawing.Size(35, 13)
		Me.LnkFuenteDefault.TabIndex = 49
		Me.LnkFuenteDefault.Tag = ""
		Me.LnkFuenteDefault.Text = "Quitar"
		'
		'LnkColorBackDefault
		'
		Me.LnkColorBackDefault.AutoSize = True
		Me.LnkColorBackDefault.ForeColor = System.Drawing.Color.Blue
		Me.LnkColorBackDefault.Location = New System.Drawing.Point(344, 61)
		Me.LnkColorBackDefault.Name = "LnkColorBackDefault"
		Me.LnkColorBackDefault.Size = New System.Drawing.Size(35, 13)
		Me.LnkColorBackDefault.TabIndex = 48
		Me.LnkColorBackDefault.Tag = ""
		Me.LnkColorBackDefault.Text = "Quitar"
		'
		'LnkColorDefault
		'
		Me.LnkColorDefault.AutoSize = True
		Me.LnkColorDefault.ForeColor = System.Drawing.Color.Blue
		Me.LnkColorDefault.Location = New System.Drawing.Point(344, 31)
		Me.LnkColorDefault.Name = "LnkColorDefault"
		Me.LnkColorDefault.Size = New System.Drawing.Size(35, 13)
		Me.LnkColorDefault.TabIndex = 47
		Me.LnkColorDefault.Tag = ""
		Me.LnkColorDefault.Text = "Quitar"
		'
		'CmdColorFondo
		'
		Me.CmdColorFondo.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.CmdColorFondo.BackgroundImage = CType(resources.GetObject("CmdColorFondo.BackgroundImage"), System.Drawing.Image)
		Me.CmdColorFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdColorFondo.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdColorFondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdColorFondo.ForeColor = System.Drawing.Color.White
		Me.CmdColorFondo.Location = New System.Drawing.Point(247, 52)
		Me.CmdColorFondo.Name = "CmdColorFondo"
		Me.CmdColorFondo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdColorFondo.Size = New System.Drawing.Size(91, 27)
		Me.CmdColorFondo.TabIndex = 46
		Me.CmdColorFondo.Text = "Color de fondo"
		Me.CmdColorFondo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdColorFondo.UseVisualStyleBackColor = False
		'
		'LblPrueba
		'
		Me.LblPrueba.BackColor = System.Drawing.SystemColors.Window
		Me.LblPrueba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblPrueba.Cursor = System.Windows.Forms.Cursors.Default
		Me.LblPrueba.ForeColor = System.Drawing.SystemColors.WindowText
		Me.LblPrueba.Location = New System.Drawing.Point(23, 34)
		Me.LblPrueba.Name = "LblPrueba"
		Me.LblPrueba.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LblPrueba.Size = New System.Drawing.Size(205, 62)
		Me.LblPrueba.TabIndex = 45
		Me.LblPrueba.Text = "Texto de Prueba"
		Me.LblPrueba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'DialogoFont
		'
		Me.DialogoFont.Color = System.Drawing.SystemColors.ControlText
		'
		'TxtTool
		'
		Me.TxtTool.Location = New System.Drawing.Point(251, 143)
		Me.TxtTool.MaxLength = 500
		Me.TxtTool.Multiline = True
		Me.TxtTool.Name = "TxtTool"
		Me.TxtTool.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TxtTool.Size = New System.Drawing.Size(402, 67)
		Me.TxtTool.TabIndex = 45
		'
		'Label3
		'
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label3.Location = New System.Drawing.Point(27, 143)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(225, 67)
		Me.Label3.TabIndex = 44
		Me.Label3.Text = "Tool Tip (texto explicativo encima del objeto)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nota: Para cambiar de renglón d" &
	"entro del tool tip, presione CTRL+Enter"
		'
		'fCampito
		'
		Me.AcceptButton = Me.CmdAceptar
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.CmdCancelar
		Me.ClientSize = New System.Drawing.Size(667, 406)
		Me.Controls.Add(Me.TxtTool)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.ChkOculto)
		Me.Controls.Add(Me.CmdEliminarCampo)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.CmdAceptar)
		Me.Controls.Add(Me.GrpLoc)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.CmdCancelar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "fCampito"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.TopMost = True
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.GrpLoc.ResumeLayout(False)
		Me.GrpLoc.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents CmdCancelar As BotonEstandar
	Friend WithEvents LblAnt As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TxtTitulo As TextBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents TxtTamY As TextBox
	Friend WithEvents LblTamYl As Label
	Friend WithEvents TxtTamX As TextBox
	Friend WithEvents LblTamXl As Label
	Friend WithEvents TxtPosY As TextBox
	Friend WithEvents LblPosYl As Label
	Friend WithEvents TxtPosX As TextBox
	Friend WithEvents LblPosXl As Label
	Friend WithEvents CmdAceptar As BotonEstandar
	Friend WithEvents CmdEliminarCampo As Button
	Friend WithEvents GrpLoc As GroupBox
	Public WithEvents CmdFuente As BotonEstandar
	Public WithEvents CmdColorLetra As BotonEstandar
	Friend WithEvents ChkOculto As CheckBox
	Friend WithEvents GroupBox1 As GroupBox
	Public WithEvents DialogoColor As ColorDialog
	Public WithEvents DialogoFont As FontDialog
	Public WithEvents LblPrueba As Label
	Public WithEvents CmdColorFondo As BotonEstandar
	Friend WithEvents LnkColorDefault As Label
	Friend WithEvents LnkColorBackDefault As Label
	Friend WithEvents LnkFuenteDefault As Label
	Friend WithEvents ChkNegrilla As CheckBox
	Friend WithEvents LblPosY As Label
	Friend WithEvents LblPosX As Label
	Friend WithEvents LblTamY As Label
	Friend WithEvents LblTamX As Label
	Friend WithEvents LblDatosForma As Label
	Friend WithEvents TxtTool As TextBox
	Friend WithEvents Label3 As Label
End Class
