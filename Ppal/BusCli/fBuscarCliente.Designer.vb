<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fBuscarCliente
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fBuscarCliente))
		Me.TxtCli = New System.Windows.Forms.TextBox()
		Me.CmdBuscar = New SMDPpal.BotonEstandar()
		Me.LblBus = New System.Windows.Forms.Label()
		Me.CmdRegresar = New SMDPpal.BotonEstandar()
		Me.LnkPlaca = New System.Windows.Forms.LinkLabel()
		Me.PnlPOS = New System.Windows.Forms.Panel()
		Me.Button25 = New SMDPpal.BotonEstandar()
		Me.Button26 = New SMDPpal.BotonEstandar()
		Me.Button27 = New SMDPpal.BotonEstandar()
		Me.Button28 = New SMDPpal.BotonEstandar()
		Me.Button29 = New SMDPpal.BotonEstandar()
		Me.Button30 = New SMDPpal.BotonEstandar()
		Me.Button31 = New SMDPpal.BotonEstandar()
		Me.Button32 = New SMDPpal.BotonEstandar()
		Me.Button17 = New SMDPpal.BotonEstandar()
		Me.Button18 = New SMDPpal.BotonEstandar()
		Me.Button19 = New SMDPpal.BotonEstandar()
		Me.Button20 = New SMDPpal.BotonEstandar()
		Me.Button21 = New SMDPpal.BotonEstandar()
		Me.Button22 = New SMDPpal.BotonEstandar()
		Me.Button23 = New SMDPpal.BotonEstandar()
		Me.Button24 = New SMDPpal.BotonEstandar()
		Me.Button16 = New SMDPpal.BotonEstandar()
		Me.Button15 = New SMDPpal.BotonEstandar()
		Me.Button14 = New SMDPpal.BotonEstandar()
		Me.Button13 = New SMDPpal.BotonEstandar()
		Me.Button12 = New SMDPpal.BotonEstandar()
		Me.Button11 = New SMDPpal.BotonEstandar()
		Me.Button10 = New SMDPpal.BotonEstandar()
		Me.Button9 = New SMDPpal.BotonEstandar()
		Me.Button5 = New SMDPpal.BotonEstandar()
		Me.Button6 = New SMDPpal.BotonEstandar()
		Me.Button7 = New SMDPpal.BotonEstandar()
		Me.Button8 = New SMDPpal.BotonEstandar()
		Me.Button3 = New SMDPpal.BotonEstandar()
		Me.Button4 = New SMDPpal.BotonEstandar()
		Me.Button2 = New SMDPpal.BotonEstandar()
		Me.Button1 = New SMDPpal.BotonEstandar()
		Me.LnkModif = New System.Windows.Forms.LinkLabel()
		Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
		Me.CmdCancel = New SMDPpal.BotonEstandar()
		Me.LnkUltimo = New System.Windows.Forms.LinkLabel()
		Me.ChkDireccion = New System.Windows.Forms.CheckBox()
		Me.PicLogo = New System.Windows.Forms.PictureBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.PnlOpciones = New System.Windows.Forms.Panel()
		Me.LnkCols = New System.Windows.Forms.LinkLabel()
		Me.OptProv = New System.Windows.Forms.CheckBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.CbOrden = New System.Windows.Forms.ComboBox()
		Me.LblTimer = New System.Windows.Forms.Label()
		Me.ChkContactoPpal = New System.Windows.Forms.CheckBox()
		Me.LnkOpciones = New System.Windows.Forms.LinkLabel()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.Grd = New System.Windows.Forms.DataGridView()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PnlPOS.SuspendLayout()
		CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.PnlOpciones.SuspendLayout()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(681, 0)
		'
		'TxtCli
		'
		Me.TxtCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtCli.Location = New System.Drawing.Point(6, 21)
		Me.TxtCli.MaxLength = 40
		Me.TxtCli.Name = "TxtCli"
		Me.TxtCli.Size = New System.Drawing.Size(218, 20)
		Me.TxtCli.TabIndex = 0
		'
		'CmdBuscar
		'
		Me.CmdBuscar.BackColor = System.Drawing.Color.White
		Me.CmdBuscar.BackgroundImage = CType(resources.GetObject("CmdBuscar.BackgroundImage"), System.Drawing.Image)
		Me.CmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdBuscar.ForeColor = System.Drawing.Color.White
		Me.CmdBuscar.Location = New System.Drawing.Point(4, 44)
		Me.CmdBuscar.Name = "CmdBuscar"
		Me.CmdBuscar.Size = New System.Drawing.Size(57, 23)
		Me.CmdBuscar.TabIndex = 1
		Me.CmdBuscar.Text = "Buscar"
		Me.CmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdBuscar.UseVisualStyleBackColor = True
		'
		'LblBus
		'
		Me.LblBus.AutoSize = True
		Me.LblBus.ForeColor = System.Drawing.SystemColors.ControlDark
		Me.LblBus.Location = New System.Drawing.Point(3, 4)
		Me.LblBus.Name = "LblBus"
		Me.LblBus.Size = New System.Drawing.Size(79, 13)
		Me.LblBus.TabIndex = 2
		Me.LblBus.Text = "Texto a Buscar"
		'
		'CmdRegresar
		'
		Me.CmdRegresar.BackColor = System.Drawing.Color.White
		Me.CmdRegresar.BackgroundImage = CType(resources.GetObject("CmdRegresar.BackgroundImage"), System.Drawing.Image)
		Me.CmdRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdRegresar.ForeColor = System.Drawing.Color.White
		Me.CmdRegresar.Location = New System.Drawing.Point(68, 44)
		Me.CmdRegresar.Name = "CmdRegresar"
		Me.CmdRegresar.Size = New System.Drawing.Size(75, 23)
		Me.CmdRegresar.TabIndex = 4
		Me.CmdRegresar.Text = "Regresar"
		Me.CmdRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdRegresar.UseVisualStyleBackColor = True
		'
		'LnkPlaca
		'
		Me.LnkPlaca.AutoSize = True
		Me.LnkPlaca.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkPlaca.Location = New System.Drawing.Point(159, 23)
		Me.LnkPlaca.Name = "LnkPlaca"
		Me.LnkPlaca.Size = New System.Drawing.Size(103, 13)
		Me.LnkPlaca.TabIndex = 110
		Me.LnkPlaca.TabStop = True
		Me.LnkPlaca.Text = "Búsqueda con items"
		Me.LnkPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'PnlPOS
		'
		Me.PnlPOS.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.PnlPOS.Controls.Add(Me.Button25)
		Me.PnlPOS.Controls.Add(Me.Button26)
		Me.PnlPOS.Controls.Add(Me.Button27)
		Me.PnlPOS.Controls.Add(Me.Button28)
		Me.PnlPOS.Controls.Add(Me.Button29)
		Me.PnlPOS.Controls.Add(Me.Button30)
		Me.PnlPOS.Controls.Add(Me.Button31)
		Me.PnlPOS.Controls.Add(Me.Button32)
		Me.PnlPOS.Controls.Add(Me.Button17)
		Me.PnlPOS.Controls.Add(Me.Button18)
		Me.PnlPOS.Controls.Add(Me.Button19)
		Me.PnlPOS.Controls.Add(Me.Button20)
		Me.PnlPOS.Controls.Add(Me.Button21)
		Me.PnlPOS.Controls.Add(Me.Button22)
		Me.PnlPOS.Controls.Add(Me.Button23)
		Me.PnlPOS.Controls.Add(Me.Button24)
		Me.PnlPOS.Controls.Add(Me.Button16)
		Me.PnlPOS.Controls.Add(Me.Button15)
		Me.PnlPOS.Controls.Add(Me.Button14)
		Me.PnlPOS.Controls.Add(Me.Button13)
		Me.PnlPOS.Controls.Add(Me.Button12)
		Me.PnlPOS.Controls.Add(Me.Button11)
		Me.PnlPOS.Controls.Add(Me.Button10)
		Me.PnlPOS.Controls.Add(Me.Button9)
		Me.PnlPOS.Controls.Add(Me.Button5)
		Me.PnlPOS.Controls.Add(Me.Button6)
		Me.PnlPOS.Controls.Add(Me.Button7)
		Me.PnlPOS.Controls.Add(Me.Button8)
		Me.PnlPOS.Controls.Add(Me.Button3)
		Me.PnlPOS.Controls.Add(Me.Button4)
		Me.PnlPOS.Controls.Add(Me.Button2)
		Me.PnlPOS.Controls.Add(Me.Button1)
		Me.PnlPOS.Location = New System.Drawing.Point(27, 0)
		Me.PnlPOS.Name = "PnlPOS"
		Me.PnlPOS.Size = New System.Drawing.Size(647, 304)
		Me.PnlPOS.TabIndex = 111
		'
		'Button25
		'
		Me.Button25.BackColor = System.Drawing.Color.White
		Me.Button25.BackgroundImage = CType(resources.GetObject("Button25.BackgroundImage"), System.Drawing.Image)
		Me.Button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button25.ForeColor = System.Drawing.Color.White
		Me.Button25.Location = New System.Drawing.Point(5, 232)
		Me.Button25.Name = "Button25"
		Me.Button25.Size = New System.Drawing.Size(75, 72)
		Me.Button25.TabIndex = 24
		Me.Button25.Text = "Button25"
		Me.Button25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button25.UseVisualStyleBackColor = True
		'
		'Button26
		'
		Me.Button26.BackColor = System.Drawing.Color.White
		Me.Button26.BackgroundImage = CType(resources.GetObject("Button26.BackgroundImage"), System.Drawing.Image)
		Me.Button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button26.ForeColor = System.Drawing.Color.White
		Me.Button26.Location = New System.Drawing.Point(84, 232)
		Me.Button26.Name = "Button26"
		Me.Button26.Size = New System.Drawing.Size(75, 72)
		Me.Button26.TabIndex = 25
		Me.Button26.Text = "Button26"
		Me.Button26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button26.UseVisualStyleBackColor = True
		'
		'Button27
		'
		Me.Button27.BackColor = System.Drawing.Color.White
		Me.Button27.BackgroundImage = CType(resources.GetObject("Button27.BackgroundImage"), System.Drawing.Image)
		Me.Button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button27.ForeColor = System.Drawing.Color.White
		Me.Button27.Location = New System.Drawing.Point(165, 232)
		Me.Button27.Name = "Button27"
		Me.Button27.Size = New System.Drawing.Size(75, 72)
		Me.Button27.TabIndex = 26
		Me.Button27.Text = "Button27"
		Me.Button27.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button27.UseVisualStyleBackColor = True
		'
		'Button28
		'
		Me.Button28.BackColor = System.Drawing.Color.White
		Me.Button28.BackgroundImage = CType(resources.GetObject("Button28.BackgroundImage"), System.Drawing.Image)
		Me.Button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button28.ForeColor = System.Drawing.Color.White
		Me.Button28.Location = New System.Drawing.Point(246, 232)
		Me.Button28.Name = "Button28"
		Me.Button28.Size = New System.Drawing.Size(75, 72)
		Me.Button28.TabIndex = 27
		Me.Button28.Text = "Button28"
		Me.Button28.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button28.UseVisualStyleBackColor = True
		'
		'Button29
		'
		Me.Button29.BackColor = System.Drawing.Color.White
		Me.Button29.BackgroundImage = CType(resources.GetObject("Button29.BackgroundImage"), System.Drawing.Image)
		Me.Button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button29.ForeColor = System.Drawing.Color.White
		Me.Button29.Location = New System.Drawing.Point(327, 232)
		Me.Button29.Name = "Button29"
		Me.Button29.Size = New System.Drawing.Size(75, 72)
		Me.Button29.TabIndex = 28
		Me.Button29.Text = "Button29"
		Me.Button29.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button29.UseVisualStyleBackColor = True
		'
		'Button30
		'
		Me.Button30.BackColor = System.Drawing.Color.White
		Me.Button30.BackgroundImage = CType(resources.GetObject("Button30.BackgroundImage"), System.Drawing.Image)
		Me.Button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button30.ForeColor = System.Drawing.Color.White
		Me.Button30.Location = New System.Drawing.Point(408, 232)
		Me.Button30.Name = "Button30"
		Me.Button30.Size = New System.Drawing.Size(75, 72)
		Me.Button30.TabIndex = 29
		Me.Button30.Text = "Button30"
		Me.Button30.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button30.UseVisualStyleBackColor = True
		'
		'Button31
		'
		Me.Button31.BackColor = System.Drawing.Color.White
		Me.Button31.BackgroundImage = CType(resources.GetObject("Button31.BackgroundImage"), System.Drawing.Image)
		Me.Button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button31.ForeColor = System.Drawing.Color.White
		Me.Button31.Location = New System.Drawing.Point(489, 232)
		Me.Button31.Name = "Button31"
		Me.Button31.Size = New System.Drawing.Size(75, 72)
		Me.Button31.TabIndex = 30
		Me.Button31.Text = "Button31"
		Me.Button31.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button31.UseVisualStyleBackColor = True
		'
		'Button32
		'
		Me.Button32.BackColor = System.Drawing.Color.White
		Me.Button32.BackgroundImage = CType(resources.GetObject("Button32.BackgroundImage"), System.Drawing.Image)
		Me.Button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button32.ForeColor = System.Drawing.Color.White
		Me.Button32.Location = New System.Drawing.Point(570, 232)
		Me.Button32.Name = "Button32"
		Me.Button32.Size = New System.Drawing.Size(75, 72)
		Me.Button32.TabIndex = 31
		Me.Button32.Text = "Button32"
		Me.Button32.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button32.UseVisualStyleBackColor = True
		'
		'Button17
		'
		Me.Button17.BackColor = System.Drawing.Color.White
		Me.Button17.BackgroundImage = CType(resources.GetObject("Button17.BackgroundImage"), System.Drawing.Image)
		Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button17.ForeColor = System.Drawing.Color.White
		Me.Button17.Location = New System.Drawing.Point(5, 156)
		Me.Button17.Name = "Button17"
		Me.Button17.Size = New System.Drawing.Size(75, 72)
		Me.Button17.TabIndex = 16
		Me.Button17.Text = "Button17"
		Me.Button17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button17.UseVisualStyleBackColor = True
		'
		'Button18
		'
		Me.Button18.BackColor = System.Drawing.Color.White
		Me.Button18.BackgroundImage = CType(resources.GetObject("Button18.BackgroundImage"), System.Drawing.Image)
		Me.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button18.ForeColor = System.Drawing.Color.White
		Me.Button18.Location = New System.Drawing.Point(84, 156)
		Me.Button18.Name = "Button18"
		Me.Button18.Size = New System.Drawing.Size(75, 72)
		Me.Button18.TabIndex = 17
		Me.Button18.Text = "Button18"
		Me.Button18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button18.UseVisualStyleBackColor = True
		'
		'Button19
		'
		Me.Button19.BackColor = System.Drawing.Color.White
		Me.Button19.BackgroundImage = CType(resources.GetObject("Button19.BackgroundImage"), System.Drawing.Image)
		Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button19.ForeColor = System.Drawing.Color.White
		Me.Button19.Location = New System.Drawing.Point(165, 156)
		Me.Button19.Name = "Button19"
		Me.Button19.Size = New System.Drawing.Size(75, 72)
		Me.Button19.TabIndex = 18
		Me.Button19.Text = "Button19"
		Me.Button19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button19.UseVisualStyleBackColor = True
		'
		'Button20
		'
		Me.Button20.BackColor = System.Drawing.Color.White
		Me.Button20.BackgroundImage = CType(resources.GetObject("Button20.BackgroundImage"), System.Drawing.Image)
		Me.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button20.ForeColor = System.Drawing.Color.White
		Me.Button20.Location = New System.Drawing.Point(246, 156)
		Me.Button20.Name = "Button20"
		Me.Button20.Size = New System.Drawing.Size(75, 72)
		Me.Button20.TabIndex = 19
		Me.Button20.Text = "Button20"
		Me.Button20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button20.UseVisualStyleBackColor = True
		'
		'Button21
		'
		Me.Button21.BackColor = System.Drawing.Color.White
		Me.Button21.BackgroundImage = CType(resources.GetObject("Button21.BackgroundImage"), System.Drawing.Image)
		Me.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button21.ForeColor = System.Drawing.Color.White
		Me.Button21.Location = New System.Drawing.Point(327, 156)
		Me.Button21.Name = "Button21"
		Me.Button21.Size = New System.Drawing.Size(75, 72)
		Me.Button21.TabIndex = 20
		Me.Button21.Text = "Button21"
		Me.Button21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button21.UseVisualStyleBackColor = True
		'
		'Button22
		'
		Me.Button22.BackColor = System.Drawing.Color.White
		Me.Button22.BackgroundImage = CType(resources.GetObject("Button22.BackgroundImage"), System.Drawing.Image)
		Me.Button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button22.ForeColor = System.Drawing.Color.White
		Me.Button22.Location = New System.Drawing.Point(408, 156)
		Me.Button22.Name = "Button22"
		Me.Button22.Size = New System.Drawing.Size(75, 72)
		Me.Button22.TabIndex = 21
		Me.Button22.Text = "Button22"
		Me.Button22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button22.UseVisualStyleBackColor = True
		'
		'Button23
		'
		Me.Button23.BackColor = System.Drawing.Color.White
		Me.Button23.BackgroundImage = CType(resources.GetObject("Button23.BackgroundImage"), System.Drawing.Image)
		Me.Button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button23.ForeColor = System.Drawing.Color.White
		Me.Button23.Location = New System.Drawing.Point(489, 156)
		Me.Button23.Name = "Button23"
		Me.Button23.Size = New System.Drawing.Size(75, 72)
		Me.Button23.TabIndex = 22
		Me.Button23.Text = "Button23"
		Me.Button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button23.UseVisualStyleBackColor = True
		'
		'Button24
		'
		Me.Button24.BackColor = System.Drawing.Color.White
		Me.Button24.BackgroundImage = CType(resources.GetObject("Button24.BackgroundImage"), System.Drawing.Image)
		Me.Button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button24.ForeColor = System.Drawing.Color.White
		Me.Button24.Location = New System.Drawing.Point(570, 156)
		Me.Button24.Name = "Button24"
		Me.Button24.Size = New System.Drawing.Size(75, 72)
		Me.Button24.TabIndex = 23
		Me.Button24.Text = "Button24"
		Me.Button24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button24.UseVisualStyleBackColor = True
		'
		'Button16
		'
		Me.Button16.BackColor = System.Drawing.Color.White
		Me.Button16.BackgroundImage = CType(resources.GetObject("Button16.BackgroundImage"), System.Drawing.Image)
		Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button16.ForeColor = System.Drawing.Color.White
		Me.Button16.Location = New System.Drawing.Point(570, 79)
		Me.Button16.Name = "Button16"
		Me.Button16.Size = New System.Drawing.Size(75, 72)
		Me.Button16.TabIndex = 8
		Me.Button16.Text = "Button16"
		Me.Button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button16.UseVisualStyleBackColor = True
		'
		'Button15
		'
		Me.Button15.BackColor = System.Drawing.Color.White
		Me.Button15.BackgroundImage = CType(resources.GetObject("Button15.BackgroundImage"), System.Drawing.Image)
		Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button15.ForeColor = System.Drawing.Color.White
		Me.Button15.Location = New System.Drawing.Point(489, 79)
		Me.Button15.Name = "Button15"
		Me.Button15.Size = New System.Drawing.Size(75, 72)
		Me.Button15.TabIndex = 9
		Me.Button15.Text = "Button15"
		Me.Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button15.UseVisualStyleBackColor = True
		'
		'Button14
		'
		Me.Button14.BackColor = System.Drawing.Color.White
		Me.Button14.BackgroundImage = CType(resources.GetObject("Button14.BackgroundImage"), System.Drawing.Image)
		Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button14.ForeColor = System.Drawing.Color.White
		Me.Button14.Location = New System.Drawing.Point(408, 79)
		Me.Button14.Name = "Button14"
		Me.Button14.Size = New System.Drawing.Size(75, 72)
		Me.Button14.TabIndex = 10
		Me.Button14.Text = "Button14"
		Me.Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button14.UseVisualStyleBackColor = True
		'
		'Button13
		'
		Me.Button13.BackColor = System.Drawing.Color.White
		Me.Button13.BackgroundImage = CType(resources.GetObject("Button13.BackgroundImage"), System.Drawing.Image)
		Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button13.ForeColor = System.Drawing.Color.White
		Me.Button13.Location = New System.Drawing.Point(327, 79)
		Me.Button13.Name = "Button13"
		Me.Button13.Size = New System.Drawing.Size(75, 72)
		Me.Button13.TabIndex = 11
		Me.Button13.Text = "Button13"
		Me.Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button13.UseVisualStyleBackColor = True
		'
		'Button12
		'
		Me.Button12.BackColor = System.Drawing.Color.White
		Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
		Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button12.ForeColor = System.Drawing.Color.White
		Me.Button12.Location = New System.Drawing.Point(246, 79)
		Me.Button12.Name = "Button12"
		Me.Button12.Size = New System.Drawing.Size(75, 72)
		Me.Button12.TabIndex = 12
		Me.Button12.Text = "Button12"
		Me.Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button12.UseVisualStyleBackColor = True
		'
		'Button11
		'
		Me.Button11.BackColor = System.Drawing.Color.White
		Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
		Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button11.ForeColor = System.Drawing.Color.White
		Me.Button11.Location = New System.Drawing.Point(165, 79)
		Me.Button11.Name = "Button11"
		Me.Button11.Size = New System.Drawing.Size(75, 72)
		Me.Button11.TabIndex = 13
		Me.Button11.Text = "Button11"
		Me.Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button11.UseVisualStyleBackColor = True
		'
		'Button10
		'
		Me.Button10.BackColor = System.Drawing.Color.White
		Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
		Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button10.ForeColor = System.Drawing.Color.White
		Me.Button10.Location = New System.Drawing.Point(84, 79)
		Me.Button10.Name = "Button10"
		Me.Button10.Size = New System.Drawing.Size(75, 72)
		Me.Button10.TabIndex = 14
		Me.Button10.Text = "Button10"
		Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button10.UseVisualStyleBackColor = True
		'
		'Button9
		'
		Me.Button9.BackColor = System.Drawing.Color.White
		Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
		Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button9.ForeColor = System.Drawing.Color.White
		Me.Button9.Location = New System.Drawing.Point(5, 79)
		Me.Button9.Name = "Button9"
		Me.Button9.Size = New System.Drawing.Size(75, 72)
		Me.Button9.TabIndex = 15
		Me.Button9.Text = "Button9"
		Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button9.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.BackColor = System.Drawing.Color.White
		Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
		Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button5.ForeColor = System.Drawing.Color.White
		Me.Button5.Location = New System.Drawing.Point(327, 3)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(75, 72)
		Me.Button5.TabIndex = 7
		Me.Button5.Text = "Button5"
		Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.BackColor = System.Drawing.Color.White
		Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
		Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button6.ForeColor = System.Drawing.Color.White
		Me.Button6.Location = New System.Drawing.Point(408, 3)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(75, 72)
		Me.Button6.TabIndex = 6
		Me.Button6.Text = "Button6"
		Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button6.UseVisualStyleBackColor = True
		'
		'Button7
		'
		Me.Button7.BackColor = System.Drawing.Color.White
		Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
		Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button7.ForeColor = System.Drawing.Color.White
		Me.Button7.Location = New System.Drawing.Point(489, 3)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(75, 72)
		Me.Button7.TabIndex = 5
		Me.Button7.Text = "Button7"
		Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button7.UseVisualStyleBackColor = True
		'
		'Button8
		'
		Me.Button8.BackColor = System.Drawing.Color.White
		Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
		Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button8.ForeColor = System.Drawing.Color.White
		Me.Button8.Location = New System.Drawing.Point(570, 3)
		Me.Button8.Name = "Button8"
		Me.Button8.Size = New System.Drawing.Size(75, 72)
		Me.Button8.TabIndex = 4
		Me.Button8.Text = "Button8"
		Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button8.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.White
		Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
		Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.ForeColor = System.Drawing.Color.White
		Me.Button3.Location = New System.Drawing.Point(165, 3)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 72)
		Me.Button3.TabIndex = 3
		Me.Button3.Text = "Button3"
		Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.White
		Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
		Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.ForeColor = System.Drawing.Color.White
		Me.Button4.Location = New System.Drawing.Point(246, 3)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(75, 72)
		Me.Button4.TabIndex = 2
		Me.Button4.Text = "Button4"
		Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.White
		Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.ForeColor = System.Drawing.Color.White
		Me.Button2.Location = New System.Drawing.Point(84, 3)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 72)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "Button2"
		Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.White
		Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.ForeColor = System.Drawing.Color.White
		Me.Button1.Location = New System.Drawing.Point(5, 3)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 72)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Button1"
		Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button1.UseVisualStyleBackColor = True
		'
		'LnkModif
		'
		Me.LnkModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkModif.AutoSize = True
		Me.LnkModif.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkModif.Location = New System.Drawing.Point(290, 21)
		Me.LnkModif.Name = "LnkModif"
		Me.LnkModif.Size = New System.Drawing.Size(90, 13)
		Me.LnkModif.TabIndex = 9
		Me.LnkModif.TabStop = True
		Me.LnkModif.Text = "Modificar Tercero"
		'
		'LinkLabel2
		'
		Me.LinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LinkLabel2.AutoSize = True
		Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel2.Location = New System.Drawing.Point(290, 3)
		Me.LinkLabel2.Name = "LinkLabel2"
		Me.LinkLabel2.Size = New System.Drawing.Size(79, 13)
		Me.LinkLabel2.TabIndex = 8
		Me.LinkLabel2.TabStop = True
		Me.LinkLabel2.Text = "Nuevo Tercero"
		'
		'CmdCancel
		'
		Me.CmdCancel.BackColor = System.Drawing.Color.White
		Me.CmdCancel.BackgroundImage = CType(resources.GetObject("CmdCancel.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancel.ForeColor = System.Drawing.Color.White
		Me.CmdCancel.Location = New System.Drawing.Point(153, 44)
		Me.CmdCancel.Name = "CmdCancel"
		Me.CmdCancel.Size = New System.Drawing.Size(73, 23)
		Me.CmdCancel.TabIndex = 112
		Me.CmdCancel.Text = "Cancelar"
		Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancel.UseVisualStyleBackColor = True
		'
		'LnkUltimo
		'
		Me.LnkUltimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkUltimo.AutoSize = True
		Me.LnkUltimo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkUltimo.Location = New System.Drawing.Point(290, 40)
		Me.LnkUltimo.Name = "LnkUltimo"
		Me.LnkUltimo.Size = New System.Drawing.Size(73, 13)
		Me.LnkUltimo.TabIndex = 114
		Me.LnkUltimo.TabStop = True
		Me.LnkUltimo.Text = "Ultimo Creado"
		'
		'ChkDireccion
		'
		Me.ChkDireccion.AutoSize = True
		Me.ChkDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkDireccion.Location = New System.Drawing.Point(18, 18)
		Me.ChkDireccion.Name = "ChkDireccion"
		Me.ChkDireccion.Size = New System.Drawing.Size(80, 16)
		Me.ChkDireccion.TabIndex = 115
		Me.ChkDireccion.Text = "Ver Dirección"
		Me.ChkDireccion.UseVisualStyleBackColor = True
		'
		'PicLogo
		'
		Me.PicLogo.BackColor = System.Drawing.Color.White
		Me.PicLogo.Location = New System.Drawing.Point(223, 26)
		Me.PicLogo.Name = "PicLogo"
		Me.PicLogo.Size = New System.Drawing.Size(87, 73)
		Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PicLogo.TabIndex = 116
		Me.PicLogo.TabStop = False
		Me.PicLogo.Visible = False
		'
		'Panel1
		'
		Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Panel1.Controls.Add(Me.PnlOpciones)
		Me.Panel1.Controls.Add(Me.LnkOpciones)
		Me.Panel1.Controls.Add(Me.TxtCli)
		Me.Panel1.Controls.Add(Me.CmdBuscar)
		Me.Panel1.Controls.Add(Me.LblBus)
		Me.Panel1.Controls.Add(Me.CmdRegresar)
		Me.Panel1.Controls.Add(Me.CmdCancel)
		Me.Panel1.Location = New System.Drawing.Point(3, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(697, 73)
		Me.Panel1.TabIndex = 118
		'
		'PnlOpciones
		'
		Me.PnlOpciones.Controls.Add(Me.LnkCols)
		Me.PnlOpciones.Controls.Add(Me.OptProv)
		Me.PnlOpciones.Controls.Add(Me.LnkPlaca)
		Me.PnlOpciones.Controls.Add(Me.Label2)
		Me.PnlOpciones.Controls.Add(Me.LnkModif)
		Me.PnlOpciones.Controls.Add(Me.CbOrden)
		Me.PnlOpciones.Controls.Add(Me.LinkLabel2)
		Me.PnlOpciones.Controls.Add(Me.LnkUltimo)
		Me.PnlOpciones.Controls.Add(Me.LblTimer)
		Me.PnlOpciones.Controls.Add(Me.ChkDireccion)
		Me.PnlOpciones.Controls.Add(Me.ChkContactoPpal)
		Me.PnlOpciones.Location = New System.Drawing.Point(230, 0)
		Me.PnlOpciones.Name = "PnlOpciones"
		Me.PnlOpciones.Size = New System.Drawing.Size(451, 74)
		Me.PnlOpciones.TabIndex = 119
		Me.PnlOpciones.Visible = False
		'
		'LnkCols
		'
		Me.LnkCols.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkCols.AutoSize = True
		Me.LnkCols.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkCols.Location = New System.Drawing.Point(290, 59)
		Me.LnkCols.Name = "LnkCols"
		Me.LnkCols.Size = New System.Drawing.Size(134, 13)
		Me.LnkCols.TabIndex = 121
		Me.LnkCols.TabStop = True
		Me.LnkCols.Text = "Columnas predeterminadas"
		'
		'OptProv
		'
		Me.OptProv.AutoSize = True
		Me.OptProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.OptProv.Location = New System.Drawing.Point(18, 3)
		Me.OptProv.Name = "OptProv"
		Me.OptProv.Size = New System.Drawing.Size(112, 16)
		Me.OptProv.TabIndex = 124
		Me.OptProv.Text = "Ver solo proveedores"
		Me.OptProv.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
		Me.Label2.Location = New System.Drawing.Point(18, 56)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(87, 13)
		Me.Label2.TabIndex = 123
		Me.Label2.Text = "Orden resultados"
		'
		'CbOrden
		'
		Me.CbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbOrden.FormattingEnabled = True
		Me.CbOrden.Items.AddRange(New Object() {"(Predeterminado)", "Nit", "Empresa", "tel_1", "Vendedor", "Direccion", "Contacto_ppal"})
		Me.CbOrden.Location = New System.Drawing.Point(111, 52)
		Me.CbOrden.Name = "CbOrden"
		Me.CbOrden.Size = New System.Drawing.Size(126, 21)
		Me.CbOrden.TabIndex = 122
		'
		'LblTimer
		'
		Me.LblTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblTimer.BackColor = System.Drawing.Color.Red
		Me.LblTimer.Location = New System.Drawing.Point(198, 2)
		Me.LblTimer.Name = "LblTimer"
		Me.LblTimer.Size = New System.Drawing.Size(7, 9)
		Me.LblTimer.TabIndex = 120
		Me.LblTimer.Visible = False
		'
		'ChkContactoPpal
		'
		Me.ChkContactoPpal.AutoSize = True
		Me.ChkContactoPpal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkContactoPpal.Location = New System.Drawing.Point(18, 34)
		Me.ChkContactoPpal.Name = "ChkContactoPpal"
		Me.ChkContactoPpal.Size = New System.Drawing.Size(99, 16)
		Me.ChkContactoPpal.TabIndex = 119
		Me.ChkContactoPpal.Text = "Ver Contacto Ppal"
		Me.ChkContactoPpal.UseVisualStyleBackColor = True
		'
		'LnkOpciones
		'
		Me.LnkOpciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkOpciones.AutoSize = True
		Me.LnkOpciones.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkOpciones.Location = New System.Drawing.Point(136, 4)
		Me.LnkOpciones.Name = "LnkOpciones"
		Me.LnkOpciones.Size = New System.Drawing.Size(52, 13)
		Me.LnkOpciones.TabIndex = 125
		Me.LnkOpciones.TabStop = True
		Me.LnkOpciones.Text = "Opciones"
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
		Me.SplitContainer1.Location = New System.Drawing.Point(2, 76)
		Me.SplitContainer1.Name = "SplitContainer1"
		Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.Grd)
		Me.SplitContainer1.Panel1.Controls.Add(Me.PicLogo)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.PnlPOS)
		Me.SplitContainer1.Size = New System.Drawing.Size(700, 433)
		Me.SplitContainer1.SplitterDistance = 125
		Me.SplitContainer1.TabIndex = 119
		'
		'Grd
		'
		Me.Grd.AllowDrop = True
		Me.Grd.AllowUserToAddRows = False
		Me.Grd.AllowUserToDeleteRows = False
		Me.Grd.AllowUserToOrderColumns = True
		Me.Grd.AllowUserToResizeRows = False
		Me.Grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.Grd.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Grd.Location = New System.Drawing.Point(0, 0)
		Me.Grd.MultiSelect = False
		Me.Grd.Name = "Grd"
		Me.Grd.ReadOnly = True
		Me.Grd.RowHeadersVisible = False
		Me.Grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.Grd.Size = New System.Drawing.Size(700, 125)
		Me.Grd.TabIndex = 118
		Me.Grd.Visible = False
		'
		'Timer1
		'
		Me.Timer1.Interval = 500
		'
		'fBuscarCliente
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.CancelButton = Me.CmdCancel
		Me.ClientSize = New System.Drawing.Size(702, 511)
		Me.ControlBox = False
		Me.Controls.Add(Me.SplitContainer1)
		Me.Controls.Add(Me.Panel1)
		Me.MinimizeBox = False
		Me.Name = "fBuscarCliente"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Buscar Terceros"
		Me.Controls.SetChildIndex(Me.Panel1, 0)
		Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PnlPOS.ResumeLayout(False)
		CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.PnlOpciones.ResumeLayout(False)
		Me.PnlOpciones.PerformLayout()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.ResumeLayout(False)
		CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents TxtCli As System.Windows.Forms.TextBox
    Friend WithEvents LblBus As System.Windows.Forms.Label
    Friend WithEvents LnkPlaca As System.Windows.Forms.LinkLabel
    Friend WithEvents PnlPOS As System.Windows.Forms.Panel
    Friend WithEvents LnkModif As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkUltimo As System.Windows.Forms.LinkLabel
    Friend WithEvents ChkDireccion As System.Windows.Forms.CheckBox
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ChkContactoPpal As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblTimer As System.Windows.Forms.Label
    Friend WithEvents CmdBuscar As SMDPpal.BotonEstandar
    Friend WithEvents CmdRegresar As SMDPpal.BotonEstandar
    Friend WithEvents Button5 As SMDPpal.BotonEstandar
    Friend WithEvents Button6 As SMDPpal.BotonEstandar
    Friend WithEvents Button7 As SMDPpal.BotonEstandar
    Friend WithEvents Button8 As SMDPpal.BotonEstandar
    Friend WithEvents Button3 As SMDPpal.BotonEstandar
    Friend WithEvents Button4 As SMDPpal.BotonEstandar
    Friend WithEvents Button2 As SMDPpal.BotonEstandar
    Friend WithEvents Button1 As SMDPpal.BotonEstandar
    Friend WithEvents Button16 As SMDPpal.BotonEstandar
    Friend WithEvents Button15 As SMDPpal.BotonEstandar
    Friend WithEvents Button14 As SMDPpal.BotonEstandar
    Friend WithEvents Button13 As SMDPpal.BotonEstandar
    Friend WithEvents Button12 As SMDPpal.BotonEstandar
    Friend WithEvents Button11 As SMDPpal.BotonEstandar
    Friend WithEvents Button10 As SMDPpal.BotonEstandar
    Friend WithEvents Button9 As SMDPpal.BotonEstandar
    Friend WithEvents Button17 As SMDPpal.BotonEstandar
    Friend WithEvents Button18 As SMDPpal.BotonEstandar
    Friend WithEvents Button19 As SMDPpal.BotonEstandar
    Friend WithEvents Button20 As SMDPpal.BotonEstandar
    Friend WithEvents Button21 As SMDPpal.BotonEstandar
    Friend WithEvents Button22 As SMDPpal.BotonEstandar
    Friend WithEvents Button23 As SMDPpal.BotonEstandar
    Friend WithEvents Button24 As SMDPpal.BotonEstandar
    Friend WithEvents Button25 As SMDPpal.BotonEstandar
    Friend WithEvents Button26 As SMDPpal.BotonEstandar
    Friend WithEvents Button27 As SMDPpal.BotonEstandar
    Friend WithEvents Button28 As SMDPpal.BotonEstandar
    Friend WithEvents Button29 As SMDPpal.BotonEstandar
    Friend WithEvents Button30 As SMDPpal.BotonEstandar
    Friend WithEvents Button31 As SMDPpal.BotonEstandar
    Friend WithEvents Button32 As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancel As SMDPpal.BotonEstandar
    Friend WithEvents Grd As System.Windows.Forms.DataGridView
    Friend WithEvents LnkCols As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbOrden As System.Windows.Forms.ComboBox
    Friend WithEvents LnkOpciones As System.Windows.Forms.LinkLabel
    Friend WithEvents OptProv As System.Windows.Forms.CheckBox
    Friend WithEvents PnlOpciones As System.Windows.Forms.Panel
End Class
