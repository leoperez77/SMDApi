<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fFind_Exp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fFind_Exp))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TbFormatos = New System.Windows.Forms.TabPage()
        Me.LblMensaje = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PicInicio = New System.Windows.Forms.PictureBox()
        Me.GrdFormatos = New SMDPpal.GridDms()
        Me.TbCreacion = New System.Windows.Forms.TabPage()
        Me.PnlTablas = New System.Windows.Forms.Panel()
        Me.PnlCampos = New System.Windows.Forms.Panel()
        Me.PnlCampos2 = New System.Windows.Forms.Panel()
        Me.ChkAgrupa = New System.Windows.Forms.CheckBox()
        Me.txtPosicion = New System.Windows.Forms.TextBox()
        Me.TxtRelleno = New System.Windows.Forms.TextBox()
        Me.CmdElimCampo = New SMDPpal.BotonEstandar()
        Me.CmdAdicCampo = New SMDPpal.BotonEstandar()
        Me.LblCampo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtLongCampo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CbJust = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LstColumnas1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrdCampos = New SMDPpal.GridDms()
        Me.LstTablas1 = New System.Windows.Forms.ListBox()
        Me.CmdElimTabla = New SMDPpal.BotonEstandar()
        Me.CmdAdicTabla = New SMDPpal.BotonEstandar()
        Me.GrdTablas = New SMDPpal.GridDms()
        Me.GrbTipo = New System.Windows.Forms.GroupBox()
        Me.RbSeparador = New System.Windows.Forms.RadioButton()
        Me.RbPlano = New System.Windows.Forms.RadioButton()
        Me.pnlSeparador = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSeparador = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CmdGuardar = New SMDPpal.BotonActualizar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNotas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblId = New System.Windows.Forms.Label()
        Me.PicEliminar = New System.Windows.Forms.PictureBox()
        Me.PicNuevo = New System.Windows.Forms.PictureBox()
        Me.PicExportar = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.TbFormatos.SuspendLayout()
        CType(Me.PicInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbCreacion.SuspendLayout()
        Me.PnlTablas.SuspendLayout()
        Me.PnlCampos.SuspendLayout()
        Me.PnlCampos2.SuspendLayout()
        Me.GrbTipo.SuspendLayout()
        Me.pnlSeparador.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PicEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.TbFormatos)
        Me.TabControl.Controls.Add(Me.TbCreacion)
        Me.TabControl.Location = New System.Drawing.Point(3, 3)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(997, 495)
        Me.TabControl.TabIndex = 22
        '
        'TbFormatos
        '
        Me.TbFormatos.Controls.Add(Me.LblMensaje)
        Me.TbFormatos.Controls.Add(Me.Label6)
        Me.TbFormatos.Controls.Add(Me.PicInicio)
        Me.TbFormatos.Controls.Add(Me.GrdFormatos)
        Me.TbFormatos.Location = New System.Drawing.Point(4, 22)
        Me.TbFormatos.Name = "TbFormatos"
        Me.TbFormatos.Padding = New System.Windows.Forms.Padding(3)
        Me.TbFormatos.Size = New System.Drawing.Size(989, 469)
        Me.TbFormatos.TabIndex = 0
        Me.TbFormatos.Text = "Formatos"
        Me.TbFormatos.UseVisualStyleBackColor = True
        '
        'LblMensaje
        '
        Me.LblMensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMensaje.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblMensaje.Location = New System.Drawing.Point(417, 151)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(414, 159)
        Me.LblMensaje.TabIndex = 262
        Me.LblMensaje.Text = "No hay definiciones de formatos asociados a este reporte, haga clik en ""Nuevo"" o " &
    " vaya a la pestaña ""Definición"" para crearlos."
        Me.LblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblMensaje.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(321, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(607, 20)
        Me.Label6.TabIndex = 248
        Me.Label6.Text = "Formatos Creados  (Haga doble clik sobre el grid para cargar los formatos)"
        '
        'PicInicio
        '
        Me.PicInicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicInicio.Location = New System.Drawing.Point(16, 32)
        Me.PicInicio.Name = "PicInicio"
        Me.PicInicio.Size = New System.Drawing.Size(234, 419)
        Me.PicInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicInicio.TabIndex = 247
        Me.PicInicio.TabStop = False
        '
        'GrdFormatos
        '
        Me.GrdFormatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdFormatos.DMSCopiarDt = True
        Me.GrdFormatos.DMSTituloDelInforme = ""
        Me.GrdFormatos.Location = New System.Drawing.Point(270, 32)
        Me.GrdFormatos.Name = "GrdFormatos"
        Me.GrdFormatos.Size = New System.Drawing.Size(706, 419)
        Me.GrdFormatos.TabIndex = 52
        '
        'TbCreacion
        '
        Me.TbCreacion.Controls.Add(Me.PnlTablas)
        Me.TbCreacion.Controls.Add(Me.Panel1)
        Me.TbCreacion.Location = New System.Drawing.Point(4, 22)
        Me.TbCreacion.Name = "TbCreacion"
        Me.TbCreacion.Padding = New System.Windows.Forms.Padding(3)
        Me.TbCreacion.Size = New System.Drawing.Size(989, 469)
        Me.TbCreacion.TabIndex = 1
        Me.TbCreacion.Text = "Definición"
        Me.TbCreacion.UseVisualStyleBackColor = True
        '
        'PnlTablas
        '
        Me.PnlTablas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTablas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTablas.Controls.Add(Me.PnlCampos)
        Me.PnlTablas.Controls.Add(Me.LstTablas1)
        Me.PnlTablas.Controls.Add(Me.CmdElimTabla)
        Me.PnlTablas.Controls.Add(Me.CmdAdicTabla)
        Me.PnlTablas.Controls.Add(Me.GrdTablas)
        Me.PnlTablas.Controls.Add(Me.GrbTipo)
        Me.PnlTablas.Controls.Add(Me.Label5)
        Me.PnlTablas.Location = New System.Drawing.Point(2, 88)
        Me.PnlTablas.Name = "PnlTablas"
        Me.PnlTablas.Size = New System.Drawing.Size(985, 377)
        Me.PnlTablas.TabIndex = 54
        '
        'PnlCampos
        '
        Me.PnlCampos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCampos.Controls.Add(Me.PnlCampos2)
        Me.PnlCampos.Controls.Add(Me.LstColumnas1)
        Me.PnlCampos.Controls.Add(Me.Label4)
        Me.PnlCampos.Controls.Add(Me.GrdCampos)
        Me.PnlCampos.Enabled = False
        Me.PnlCampos.Location = New System.Drawing.Point(407, 3)
        Me.PnlCampos.Name = "PnlCampos"
        Me.PnlCampos.Size = New System.Drawing.Size(576, 371)
        Me.PnlCampos.TabIndex = 59
        '
        'PnlCampos2
        '
        Me.PnlCampos2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCampos2.Controls.Add(Me.ChkAgrupa)
        Me.PnlCampos2.Controls.Add(Me.txtPosicion)
        Me.PnlCampos2.Controls.Add(Me.TxtRelleno)
        Me.PnlCampos2.Controls.Add(Me.CmdElimCampo)
        Me.PnlCampos2.Controls.Add(Me.CmdAdicCampo)
        Me.PnlCampos2.Controls.Add(Me.LblCampo)
        Me.PnlCampos2.Controls.Add(Me.Label12)
        Me.PnlCampos2.Controls.Add(Me.Label2)
        Me.PnlCampos2.Controls.Add(Me.Label13)
        Me.PnlCampos2.Controls.Add(Me.TxtLongCampo)
        Me.PnlCampos2.Controls.Add(Me.Label14)
        Me.PnlCampos2.Controls.Add(Me.CbJust)
        Me.PnlCampos2.Controls.Add(Me.Label15)
        Me.PnlCampos2.Enabled = False
        Me.PnlCampos2.Location = New System.Drawing.Point(158, 22)
        Me.PnlCampos2.Name = "PnlCampos2"
        Me.PnlCampos2.Size = New System.Drawing.Size(415, 121)
        Me.PnlCampos2.TabIndex = 60
        '
        'ChkAgrupa
        '
        Me.ChkAgrupa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkAgrupa.AutoSize = True
        Me.ChkAgrupa.Location = New System.Drawing.Point(24, 100)
        Me.ChkAgrupa.Name = "ChkAgrupa"
        Me.ChkAgrupa.Size = New System.Drawing.Size(131, 17)
        Me.ChkAgrupa.TabIndex = 65
        Me.ChkAgrupa.Text = "Campo de Agrupación"
        Me.ChkAgrupa.UseVisualStyleBackColor = True
        '
        'txtPosicion
        '
        Me.txtPosicion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPosicion.Location = New System.Drawing.Point(104, 28)
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.Size = New System.Drawing.Size(100, 20)
        Me.txtPosicion.TabIndex = 9
        '
        'TxtRelleno
        '
        Me.TxtRelleno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtRelleno.Location = New System.Drawing.Point(299, 28)
        Me.TxtRelleno.Name = "TxtRelleno"
        Me.TxtRelleno.Size = New System.Drawing.Size(100, 20)
        Me.TxtRelleno.TabIndex = 11
        '
        'CmdElimCampo
        '
        Me.CmdElimCampo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdElimCampo.BackColor = System.Drawing.Color.White
        Me.CmdElimCampo.BackgroundImage = CType(resources.GetObject("CmdElimCampo.BackgroundImage"), System.Drawing.Image)
        Me.CmdElimCampo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdElimCampo.Enabled = False
        Me.CmdElimCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdElimCampo.ForeColor = System.Drawing.Color.White
        Me.CmdElimCampo.Location = New System.Drawing.Point(255, 97)
        Me.CmdElimCampo.Name = "CmdElimCampo"
        Me.CmdElimCampo.Size = New System.Drawing.Size(75, 23)
        Me.CmdElimCampo.TabIndex = 57
        Me.CmdElimCampo.Text = "Eliminar"
        Me.CmdElimCampo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdElimCampo.UseVisualStyleBackColor = False
        '
        'CmdAdicCampo
        '
        Me.CmdAdicCampo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdAdicCampo.BackColor = System.Drawing.Color.White
        Me.CmdAdicCampo.BackgroundImage = CType(resources.GetObject("CmdAdicCampo.BackgroundImage"), System.Drawing.Image)
        Me.CmdAdicCampo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdAdicCampo.Enabled = False
        Me.CmdAdicCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAdicCampo.ForeColor = System.Drawing.Color.White
        Me.CmdAdicCampo.Location = New System.Drawing.Point(332, 97)
        Me.CmdAdicCampo.Name = "CmdAdicCampo"
        Me.CmdAdicCampo.Size = New System.Drawing.Size(75, 23)
        Me.CmdAdicCampo.TabIndex = 58
        Me.CmdAdicCampo.Text = "Adicionar"
        Me.CmdAdicCampo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdAdicCampo.UseVisualStyleBackColor = False
        '
        'LblCampo
        '
        Me.LblCampo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblCampo.AutoSize = True
        Me.LblCampo.Location = New System.Drawing.Point(10, 3)
        Me.LblCampo.Name = "LblCampo"
        Me.LblCampo.Size = New System.Drawing.Size(49, 13)
        Me.LblCampo.TabIndex = 64
        Me.LblCampo.Text = "Campo:  "
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Posición Inicial"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Longitud"
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 60
        '
        'TxtLongCampo
        '
        Me.TxtLongCampo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtLongCampo.Location = New System.Drawing.Point(104, 60)
        Me.TxtLongCampo.Name = "TxtLongCampo"
        Me.TxtLongCampo.Size = New System.Drawing.Size(100, 20)
        Me.TxtLongCampo.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(222, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Rellenar con"
        '
        'CbJust
        '
        Me.CbJust.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbJust.FormattingEnabled = True
        Me.CbJust.Items.AddRange(New Object() {"Izquierda", "Derecha"})
        Me.CbJust.Location = New System.Drawing.Point(299, 60)
        Me.CbJust.Name = "CbJust"
        Me.CbJust.Size = New System.Drawing.Size(100, 21)
        Me.CbJust.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(222, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Justificado"
        '
        'LstColumnas1
        '
        Me.LstColumnas1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LstColumnas1.FormattingEnabled = True
        Me.LstColumnas1.Location = New System.Drawing.Point(10, 22)
        Me.LstColumnas1.Name = "LstColumnas1"
        Me.LstColumnas1.Size = New System.Drawing.Size(144, 342)
        Me.LstColumnas1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(9, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(257, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Seleccione de la lista para cargar un campo"
        '
        'GrdCampos
        '
        Me.GrdCampos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCampos.DMSCopiarDt = True
        Me.GrdCampos.DMSTituloDelInforme = ""
        Me.GrdCampos.Location = New System.Drawing.Point(158, 145)
        Me.GrdCampos.Name = "GrdCampos"
        Me.GrdCampos.Size = New System.Drawing.Size(405, 219)
        Me.GrdCampos.TabIndex = 51
        '
        'LstTablas1
        '
        Me.LstTablas1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LstTablas1.FormattingEnabled = True
        Me.LstTablas1.Location = New System.Drawing.Point(7, 25)
        Me.LstTablas1.Name = "LstTablas1"
        Me.LstTablas1.Size = New System.Drawing.Size(144, 342)
        Me.LstTablas1.TabIndex = 4
        '
        'CmdElimTabla
        '
        Me.CmdElimTabla.BackColor = System.Drawing.Color.White
        Me.CmdElimTabla.BackgroundImage = CType(resources.GetObject("CmdElimTabla.BackgroundImage"), System.Drawing.Image)
        Me.CmdElimTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdElimTabla.Enabled = False
        Me.CmdElimTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdElimTabla.ForeColor = System.Drawing.Color.White
        Me.CmdElimTabla.Location = New System.Drawing.Point(243, 123)
        Me.CmdElimTabla.Name = "CmdElimTabla"
        Me.CmdElimTabla.Size = New System.Drawing.Size(75, 23)
        Me.CmdElimTabla.TabIndex = 54
        Me.CmdElimTabla.Text = "Eliminar"
        Me.CmdElimTabla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdElimTabla.UseVisualStyleBackColor = False
        '
        'CmdAdicTabla
        '
        Me.CmdAdicTabla.BackColor = System.Drawing.Color.White
        Me.CmdAdicTabla.BackgroundImage = CType(resources.GetObject("CmdAdicTabla.BackgroundImage"), System.Drawing.Image)
        Me.CmdAdicTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdAdicTabla.Enabled = False
        Me.CmdAdicTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAdicTabla.ForeColor = System.Drawing.Color.White
        Me.CmdAdicTabla.Location = New System.Drawing.Point(320, 123)
        Me.CmdAdicTabla.Name = "CmdAdicTabla"
        Me.CmdAdicTabla.Size = New System.Drawing.Size(75, 23)
        Me.CmdAdicTabla.TabIndex = 55
        Me.CmdAdicTabla.Text = "Adicionar"
        Me.CmdAdicTabla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdAdicTabla.UseVisualStyleBackColor = False
        '
        'GrdTablas
        '
        Me.GrdTablas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdTablas.DMSCopiarDt = True
        Me.GrdTablas.DMSTituloDelInforme = ""
        Me.GrdTablas.Location = New System.Drawing.Point(154, 148)
        Me.GrdTablas.Name = "GrdTablas"
        Me.GrdTablas.Size = New System.Drawing.Size(241, 219)
        Me.GrdTablas.TabIndex = 57
        '
        'GrbTipo
        '
        Me.GrbTipo.Controls.Add(Me.RbSeparador)
        Me.GrbTipo.Controls.Add(Me.RbPlano)
        Me.GrbTipo.Controls.Add(Me.pnlSeparador)
        Me.GrbTipo.Enabled = False
        Me.GrbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbTipo.Location = New System.Drawing.Point(170, 24)
        Me.GrbTipo.Name = "GrbTipo"
        Me.GrbTipo.Size = New System.Drawing.Size(201, 93)
        Me.GrbTipo.TabIndex = 53
        Me.GrbTipo.TabStop = False
        Me.GrbTipo.Text = "Tipo "
        '
        'RbSeparador
        '
        Me.RbSeparador.AutoSize = True
        Me.RbSeparador.Location = New System.Drawing.Point(87, 20)
        Me.RbSeparador.Name = "RbSeparador"
        Me.RbSeparador.Size = New System.Drawing.Size(96, 17)
        Me.RbSeparador.TabIndex = 6
        Me.RbSeparador.Text = "Con Separador"
        Me.RbSeparador.UseVisualStyleBackColor = True
        '
        'RbPlano
        '
        Me.RbPlano.AutoSize = True
        Me.RbPlano.Checked = True
        Me.RbPlano.Location = New System.Drawing.Point(24, 20)
        Me.RbPlano.Name = "RbPlano"
        Me.RbPlano.Size = New System.Drawing.Size(52, 17)
        Me.RbPlano.TabIndex = 5
        Me.RbPlano.TabStop = True
        Me.RbPlano.Text = "Plano"
        Me.RbPlano.UseVisualStyleBackColor = True
        '
        'pnlSeparador
        '
        Me.pnlSeparador.Controls.Add(Me.Label1)
        Me.pnlSeparador.Controls.Add(Me.TxtSeparador)
        Me.pnlSeparador.Location = New System.Drawing.Point(24, 47)
        Me.pnlSeparador.Name = "pnlSeparador"
        Me.pnlSeparador.Size = New System.Drawing.Size(162, 34)
        Me.pnlSeparador.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Separador"
        '
        'TxtSeparador
        '
        Me.TxtSeparador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSeparador.Location = New System.Drawing.Point(71, 6)
        Me.TxtSeparador.MaxLength = 1
        Me.TxtSeparador.Name = "TxtSeparador"
        Me.TxtSeparador.Size = New System.Drawing.Size(38, 23)
        Me.TxtSeparador.TabIndex = 7
        Me.TxtSeparador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(5, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(287, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Haga doble clic sobre la lista para cargar la tabla"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CmdGuardar)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtDescripcion)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtNotas)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtNombre)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.LblId)
        Me.Panel1.Location = New System.Drawing.Point(2, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(985, 77)
        Me.Panel1.TabIndex = 53
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdGuardar.DMSImagenArriba = False
        Me.CmdGuardar.DMSText = "&Actualizar"
        Me.CmdGuardar.DMSUsaF5 = False
        Me.CmdGuardar.Location = New System.Drawing.Point(873, 13)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(102, 46)
        Me.CmdGuardar.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Descripción"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(112, 13)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(262, 20)
        Me.TxtDescripcion.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(385, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Explicación"
        '
        'TxtNotas
        '
        Me.TxtNotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNotas.Location = New System.Drawing.Point(451, 13)
        Me.TxtNotas.Multiline = True
        Me.TxtNotas.Name = "TxtNotas"
        Me.TxtNotas.Size = New System.Drawing.Size(308, 48)
        Me.TxtNotas.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Ruta/Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(112, 41)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(262, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(770, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Id: "
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LblId.Location = New System.Drawing.Point(795, 29)
        Me.LblId.MinimumSize = New System.Drawing.Size(50, 18)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(50, 18)
        Me.LblId.TabIndex = 34
        Me.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicEliminar
        '
        Me.PicEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PicEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicEliminar.Location = New System.Drawing.Point(300, 500)
        Me.PicEliminar.Name = "PicEliminar"
        Me.PicEliminar.Size = New System.Drawing.Size(45, 50)
        Me.PicEliminar.TabIndex = 62
        Me.PicEliminar.TabStop = False
        '
        'PicNuevo
        '
        Me.PicNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PicNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicNuevo.Location = New System.Drawing.Point(487, 500)
        Me.PicNuevo.Name = "PicNuevo"
        Me.PicNuevo.Size = New System.Drawing.Size(45, 50)
        Me.PicNuevo.TabIndex = 63
        Me.PicNuevo.TabStop = False
        '
        'PicExportar
        '
        Me.PicExportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PicExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicExportar.Location = New System.Drawing.Point(678, 500)
        Me.PicExportar.Name = "PicExportar"
        Me.PicExportar.Size = New System.Drawing.Size(45, 50)
        Me.PicExportar.TabIndex = 64
        Me.PicExportar.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(678, 550)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 263
        Me.Label11.Text = "Exportar"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(491, 550)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 13)
        Me.Label16.TabIndex = 264
        Me.Label16.Text = "Nuevo"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(301, 550)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 265
        Me.Label17.Text = "Eliminar"
        '
        'fFind_Exp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1002, 567)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PicExportar)
        Me.Controls.Add(Me.PicNuevo)
        Me.Controls.Add(Me.PicEliminar)
        Me.Controls.Add(Me.TabControl)
        Me.MinimumSize = New System.Drawing.Size(1018, 580)
        Me.Name = "fFind_Exp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar"
        Me.TabControl.ResumeLayout(False)
        Me.TbFormatos.ResumeLayout(False)
        Me.TbFormatos.PerformLayout()
        CType(Me.PicInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbCreacion.ResumeLayout(False)
        Me.PnlTablas.ResumeLayout(False)
        Me.PnlTablas.PerformLayout()
        Me.PnlCampos.ResumeLayout(False)
        Me.PnlCampos.PerformLayout()
        Me.PnlCampos2.ResumeLayout(False)
        Me.PnlCampos2.PerformLayout()
        Me.GrbTipo.ResumeLayout(False)
        Me.GrbTipo.PerformLayout()
        Me.pnlSeparador.ResumeLayout(False)
        Me.pnlSeparador.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicExportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TbFormatos As TabPage
    Friend WithEvents TbCreacion As TabPage
    Friend WithEvents PnlTablas As Panel
    Friend WithEvents PnlCampos As Panel
    Friend WithEvents LstColumnas1 As ListBox
    Friend WithEvents CmdElimCampo As BotonEstandar
    Friend WithEvents LblCampo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtLongCampo As TextBox
    Friend WithEvents CbJust As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CmdAdicCampo As BotonEstandar
    Friend WithEvents TxtRelleno As TextBox
    Friend WithEvents txtPosicion As TextBox
    Friend WithEvents GrdCampos As GridDms
    Friend WithEvents LstTablas1 As ListBox
    Friend WithEvents CmdElimTabla As BotonEstandar
    Friend WithEvents CmdAdicTabla As BotonEstandar
    Friend WithEvents GrdTablas As GridDms
    Friend WithEvents GrbTipo As GroupBox
    Friend WithEvents RbSeparador As RadioButton
    Friend WithEvents RbPlano As RadioButton
    Friend WithEvents pnlSeparador As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSeparador As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CmdGuardar As BotonActualizar
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNotas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LblId As Label
    Friend WithEvents GrdFormatos As GridDms
    Friend WithEvents Label6 As Label
    Friend WithEvents PicInicio As PictureBox
    Friend WithEvents LblMensaje As Label
    Friend WithEvents PicEliminar As PictureBox
    Friend WithEvents PicNuevo As PictureBox
    Friend WithEvents PicExportar As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents PnlCampos2 As Panel
    Friend WithEvents ChkAgrupa As CheckBox
End Class
