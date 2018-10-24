' Version: 683, 23-ago.-2018 12:40
'♥ versión: 586, 6-oct.-2017 07:11
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fUsuarioServicio
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fUsuarioServicio))
		Me.LstEmpresa = New System.Windows.Forms.ListBox()
		Me.TxtUser = New System.Windows.Forms.TextBox()
		Me.CmdCancel = New SMDPpal.BotonEstandar()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtEmp = New System.Windows.Forms.TextBox()
		Me.CmdBuscar = New SMDPpal.BotonEstandar()
		Me.CmdSalir = New SMDPpal.BotonEstandar()
		Me.CmdUltima = New SMDPpal.BotonEstandar()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TxtInicial = New System.Windows.Forms.TextBox()
		Me.CbEmp = New System.Windows.Forms.ListBox()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.LnkBorrar = New System.Windows.Forms.LinkLabel()
		Me.LnkMis = New System.Windows.Forms.LinkLabel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.ChkIgnorarPermisos = New System.Windows.Forms.CheckBox()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.ChkIngles = New System.Windows.Forms.CheckBox()
		Me.LnkUltima = New System.Windows.Forms.LinkLabel()
		Me.ChkPru = New System.Windows.Forms.CheckBox()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(551, 0)
		'
		'LstEmpresa
		'
		Me.LstEmpresa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LstEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LstEmpresa.FormattingEnabled = True
		Me.LstEmpresa.Location = New System.Drawing.Point(1, 31)
		Me.LstEmpresa.Name = "LstEmpresa"
		Me.LstEmpresa.Size = New System.Drawing.Size(295, 186)
		Me.LstEmpresa.Sorted = True
		Me.LstEmpresa.TabIndex = 2
		'
		'TxtUser
		'
		Me.TxtUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtUser.Location = New System.Drawing.Point(12, 239)
		Me.TxtUser.MaxLength = 250
		Me.TxtUser.Name = "TxtUser"
		Me.TxtUser.Size = New System.Drawing.Size(281, 20)
		Me.TxtUser.TabIndex = 3
		Me.TxtUser.Text = "dms"
		'
		'CmdCancel
		'
		Me.CmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.CmdCancel.BackgroundImage = CType(resources.GetObject("CmdCancel.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancel.ForeColor = System.Drawing.Color.White
		Me.CmdCancel.Location = New System.Drawing.Point(327, 230)
		Me.CmdCancel.Name = "CmdCancel"
		Me.CmdCancel.Size = New System.Drawing.Size(51, 40)
		Me.CmdCancel.TabIndex = 2
		Me.CmdCancel.Text = "DMS"
		Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancel.UseVisualStyleBackColor = False
		'
		'LinkLabel1
		'
		Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel1.Location = New System.Drawing.Point(9, 221)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(43, 13)
		Me.LinkLabel1.TabIndex = 8
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "Usuario"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(4, 9)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(48, 13)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Empresa"
		'
		'TxtEmp
		'
		Me.TxtEmp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtEmp.Location = New System.Drawing.Point(57, 6)
		Me.TxtEmp.MaxLength = 20
		Me.TxtEmp.Name = "TxtEmp"
		Me.TxtEmp.Size = New System.Drawing.Size(179, 20)
		Me.TxtEmp.TabIndex = 0
		'
		'CmdBuscar
		'
		Me.CmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdBuscar.BackColor = System.Drawing.Color.White
		Me.CmdBuscar.BackgroundImage = CType(resources.GetObject("CmdBuscar.BackgroundImage"), System.Drawing.Image)
		Me.CmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdBuscar.ForeColor = System.Drawing.Color.White
		Me.CmdBuscar.Location = New System.Drawing.Point(239, 5)
		Me.CmdBuscar.Name = "CmdBuscar"
		Me.CmdBuscar.Size = New System.Drawing.Size(54, 23)
		Me.CmdBuscar.TabIndex = 1
		Me.CmdBuscar.Text = "Buscar"
		Me.CmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdBuscar.UseVisualStyleBackColor = True
		'
		'CmdSalir
		'
		Me.CmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdSalir.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.CmdSalir.BackgroundImage = CType(resources.GetObject("CmdSalir.BackgroundImage"), System.Drawing.Image)
		Me.CmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdSalir.ForeColor = System.Drawing.Color.White
		Me.CmdSalir.Location = New System.Drawing.Point(327, 275)
		Me.CmdSalir.Name = "CmdSalir"
		Me.CmdSalir.Size = New System.Drawing.Size(51, 40)
		Me.CmdSalir.TabIndex = 3
		Me.CmdSalir.Text = "Cerrar"
		Me.CmdSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdSalir.UseVisualStyleBackColor = False
		'
		'CmdUltima
		'
		Me.CmdUltima.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdUltima.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.CmdUltima.BackgroundImage = CType(resources.GetObject("CmdUltima.BackgroundImage"), System.Drawing.Image)
		Me.CmdUltima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdUltima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdUltima.ForeColor = System.Drawing.Color.White
		Me.CmdUltima.Location = New System.Drawing.Point(327, 22)
		Me.CmdUltima.Name = "CmdUltima"
		Me.CmdUltima.Size = New System.Drawing.Size(51, 40)
		Me.CmdUltima.TabIndex = 1
		Me.CmdUltima.Text = "Abrir"
		Me.CmdUltima.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdUltima.UseVisualStyleBackColor = False
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(9, 268)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(46, 13)
		Me.Label3.TabIndex = 12
		Me.Label3.Text = "Id Inicial"
		'
		'TxtInicial
		'
		Me.TxtInicial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtInicial.Location = New System.Drawing.Point(56, 264)
		Me.TxtInicial.MaxLength = 20
		Me.TxtInicial.Name = "TxtInicial"
		Me.TxtInicial.Size = New System.Drawing.Size(237, 20)
		Me.TxtInicial.TabIndex = 11
		'
		'CbEmp
		'
		Me.CbEmp.FormattingEnabled = True
		Me.CbEmp.Location = New System.Drawing.Point(1, 1)
		Me.CbEmp.Name = "CbEmp"
		Me.CbEmp.Size = New System.Drawing.Size(296, 290)
		Me.CbEmp.Sorted = True
		Me.CbEmp.TabIndex = 0
		'
		'TabControl1
		'
		Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Location = New System.Drawing.Point(3, 1)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(307, 315)
		Me.TabControl1.TabIndex = 0
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.CbEmp)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(299, 289)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Ultimas Empresas"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.TxtEmp)
		Me.TabPage2.Controls.Add(Me.Label3)
		Me.TabPage2.Controls.Add(Me.Label2)
		Me.TabPage2.Controls.Add(Me.TxtInicial)
		Me.TabPage2.Controls.Add(Me.CmdBuscar)
		Me.TabPage2.Controls.Add(Me.TxtUser)
		Me.TabPage2.Controls.Add(Me.LinkLabel1)
		Me.TabPage2.Controls.Add(Me.LstEmpresa)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(299, 289)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Buscar"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'LnkBorrar
		'
		Me.LnkBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkBorrar.AutoSize = True
		Me.LnkBorrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkBorrar.Location = New System.Drawing.Point(327, 99)
		Me.LnkBorrar.Name = "LnkBorrar"
		Me.LnkBorrar.Size = New System.Drawing.Size(35, 13)
		Me.LnkBorrar.TabIndex = 6
		Me.LnkBorrar.TabStop = True
		Me.LnkBorrar.Text = "Borrar"
		'
		'LnkMis
		'
		Me.LnkMis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkMis.AutoSize = True
		Me.LnkMis.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkMis.Location = New System.Drawing.Point(327, 72)
		Me.LnkMis.Name = "LnkMis"
		Me.LnkMis.Size = New System.Drawing.Size(47, 13)
		Me.LnkMis.TabIndex = 5
		Me.LnkMis.TabStop = True
		Me.LnkMis.Text = "Mis Emp"
		'
		'PictureBox1
		'
		Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(180, 304)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 1
		Me.PictureBox1.TabStop = False
		'
		'ChkIgnorarPermisos
		'
		Me.ChkIgnorarPermisos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ChkIgnorarPermisos.Checked = True
		Me.ChkIgnorarPermisos.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ChkIgnorarPermisos.Location = New System.Drawing.Point(321, 123)
		Me.ChkIgnorarPermisos.Name = "ChkIgnorarPermisos"
		Me.ChkIgnorarPermisos.Size = New System.Drawing.Size(61, 32)
		Me.ChkIgnorarPermisos.TabIndex = 7
		Me.ChkIgnorarPermisos.Text = "Ignorar Perm"
		Me.ChkIgnorarPermisos.UseVisualStyleBackColor = True
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.ChkIngles)
		Me.SplitContainer1.Panel2.Controls.Add(Me.LnkUltima)
		Me.SplitContainer1.Panel2.Controls.Add(Me.ChkPru)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CmdUltima)
		Me.SplitContainer1.Panel2.Controls.Add(Me.ChkIgnorarPermisos)
		Me.SplitContainer1.Panel2.Controls.Add(Me.LnkBorrar)
		Me.SplitContainer1.Panel2.Controls.Add(Me.LnkMis)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CmdSalir)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CmdCancel)
		Me.SplitContainer1.Size = New System.Drawing.Size(572, 317)
		Me.SplitContainer1.SplitterDistance = 181
		Me.SplitContainer1.TabIndex = 8
		'
		'ChkIngles
		'
		Me.ChkIngles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ChkIngles.Location = New System.Drawing.Point(321, 188)
		Me.ChkIngles.Name = "ChkIngles"
		Me.ChkIngles.Size = New System.Drawing.Size(63, 17)
		Me.ChkIngles.TabIndex = 10
		Me.ChkIngles.Text = "Inglés"
		Me.ChkIngles.UseVisualStyleBackColor = True
		'
		'LnkUltima
		'
		Me.LnkUltima.AutoSize = True
		Me.LnkUltima.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkUltima.Location = New System.Drawing.Point(326, 212)
		Me.LnkUltima.Name = "LnkUltima"
		Me.LnkUltima.Size = New System.Drawing.Size(52, 13)
		Me.LnkUltima.TabIndex = 9
		Me.LnkUltima.TabStop = True
		Me.LnkUltima.Text = "Ultima JD"
		'
		'ChkPru
		'
		Me.ChkPru.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ChkPru.Location = New System.Drawing.Point(321, 152)
		Me.ChkPru.Name = "ChkPru"
		Me.ChkPru.Size = New System.Drawing.Size(61, 32)
		Me.ChkPru.TabIndex = 8
		Me.ChkPru.Text = "Ws pru"
		Me.ChkPru.UseVisualStyleBackColor = True
		'
		'fUsuarioServicio
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.White
		Me.CancelButton = Me.CmdCancel
		Me.ClientSize = New System.Drawing.Size(572, 317)
		Me.ControlBox = False
		Me.Controls.Add(Me.SplitContainer1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(700, 2500)
		Me.MinimizeBox = False
		Me.Name = "fUsuarioServicio"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Usuario de Servicio"
		Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage2.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.Panel2.PerformLayout()
		Me.SplitContainer1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents LstEmpresa As System.Windows.Forms.ListBox
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtEmp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtInicial As System.Windows.Forms.TextBox
    Friend WithEvents CbEmp As System.Windows.Forms.ListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LnkMis As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkBorrar As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ChkIgnorarPermisos As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ChkPru As System.Windows.Forms.CheckBox
    Friend WithEvents CmdCancel As SMDPpal.BotonEstandar
    Friend WithEvents CmdBuscar As SMDPpal.BotonEstandar
    Friend WithEvents CmdSalir As SMDPpal.BotonEstandar
    Friend WithEvents CmdUltima As SMDPpal.BotonEstandar
    Friend WithEvents LnkUltima As System.Windows.Forms.LinkLabel
	Friend WithEvents ChkIngles As CheckBox
End Class
