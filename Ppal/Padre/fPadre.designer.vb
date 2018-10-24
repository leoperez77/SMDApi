'♥ versión: 586, 6-oct.-2017 07:11
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPadre
Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fPadre))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.CmdMax = New System.Windows.Forms.ToolStripButton()
        Me.cmdMin = New System.Windows.Forms.ToolStripButton()
        Me.CmdAyuda = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.aba = New System.Windows.Forms.Label()
        Me.Izq = New System.Windows.Forms.Label()
        Me.der = New System.Windows.Forms.Label()
        Me.arr = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Pnldegradado = New System.Windows.Forms.Panel()
        Me.Icono = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.ToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Pnldegradado.SuspendLayout()
        CType(Me.Icono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.AllowMerge = False
        Me.ToolStrip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip.CanOverflow = False
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdCerrar, Me.CmdMax, Me.cmdMin, Me.CmdAyuda})
        Me.ToolStrip.Location = New System.Drawing.Point(132, -1)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.ShowItemToolTips = False
        Me.ToolStrip.Size = New System.Drawing.Size(110, 22)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(23, 22)
        Me.cmdCerrar.Text = "Cerrar"
        '
        'CmdMax
        '
        Me.CmdMax.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmdMax.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdMax.Image = CType(resources.GetObject("CmdMax.Image"), System.Drawing.Image)
        Me.CmdMax.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdMax.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmdMax.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdMax.Name = "CmdMax"
        Me.CmdMax.Size = New System.Drawing.Size(28, 19)
        Me.CmdMax.Text = "Maximizar"
        '
        'cmdMin
        '
        Me.cmdMin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdMin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdMin.Image = CType(resources.GetObject("cmdMin.Image"), System.Drawing.Image)
        Me.cmdMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdMin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdMin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(26, 19)
        Me.cmdMin.Text = "Minimizar"
        '
        'CmdAyuda
        '
        Me.CmdAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdAyuda.Image = CType(resources.GetObject("CmdAyuda.Image"), System.Drawing.Image)
        Me.CmdAyuda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdAyuda.Name = "CmdAyuda"
        Me.CmdAyuda.Size = New System.Drawing.Size(23, 19)
        Me.CmdAyuda.Text = "ToolStripButton1"
        Me.CmdAyuda.ToolTipText = "Ayuda"
        '
        'aba
        '
        Me.aba.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.aba.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.aba.ForeColor = System.Drawing.Color.White
        Me.aba.Location = New System.Drawing.Point(0, 233)
        Me.aba.Margin = New System.Windows.Forms.Padding(0)
        Me.aba.Name = "aba"
        Me.aba.Size = New System.Drawing.Size(341, 4)
        Me.aba.TabIndex = 9
        Me.aba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Izq
        '
        Me.Izq.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Izq.Dock = System.Windows.Forms.DockStyle.Left
        Me.Izq.Location = New System.Drawing.Point(0, 0)
        Me.Izq.Margin = New System.Windows.Forms.Padding(0)
        Me.Izq.Name = "Izq"
        Me.Izq.Size = New System.Drawing.Size(4, 233)
        Me.Izq.TabIndex = 10
        '
        'der
        '
        Me.der.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.der.Dock = System.Windows.Forms.DockStyle.Right
        Me.der.Location = New System.Drawing.Point(337, 0)
        Me.der.Margin = New System.Windows.Forms.Padding(0)
        Me.der.Name = "der"
        Me.der.Size = New System.Drawing.Size(4, 233)
        Me.der.TabIndex = 11
        '
        'arr
        '
        Me.arr.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.arr.Dock = System.Windows.Forms.DockStyle.Top
        Me.arr.Location = New System.Drawing.Point(4, 0)
        Me.arr.Margin = New System.Windows.Forms.Padding(0)
        Me.arr.Name = "arr"
        Me.arr.Size = New System.Drawing.Size(333, 8)
        Me.arr.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 205)
        Me.Panel1.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(116, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Pnldegradado)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(4, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(333, 20)
        Me.Panel2.TabIndex = 17
        '
        'Pnldegradado
        '
        Me.Pnldegradado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnldegradado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Pnldegradado.Controls.Add(Me.Icono)
        Me.Pnldegradado.Controls.Add(Me.ToolStrip)
        Me.Pnldegradado.Controls.Add(Me.lblTitulo)
        Me.Pnldegradado.Location = New System.Drawing.Point(89, 0)
        Me.Pnldegradado.Name = "Pnldegradado"
        Me.Pnldegradado.Size = New System.Drawing.Size(250, 18)
        Me.Pnldegradado.TabIndex = 10
        '
        'Icono
        '
        Me.Icono.BackColor = System.Drawing.Color.Transparent
        Me.Icono.Location = New System.Drawing.Point(12, 1)
        Me.Icono.Name = "Icono"
        Me.Icono.Size = New System.Drawing.Size(17, 15)
        Me.Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icono.TabIndex = 7
        Me.Icono.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.AutoEllipsis = True
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(35, 2)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(50, 13)
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "Advance"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(6, -1)
        Me.Logo.MinimumSize = New System.Drawing.Size(10, 10)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(86, 29)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 9
        Me.Logo.TabStop = False
        '
        'fPadre
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(341, 237)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.arr)
        Me.Controls.Add(Me.der)
        Me.Controls.Add(Me.Izq)
        Me.Controls.Add(Me.aba)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "fPadre"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Pnldegradado.ResumeLayout(False)
        Me.Pnldegradado.PerformLayout()
        CType(Me.Icono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmdMax As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdMin As System.Windows.Forms.ToolStripButton
    Friend WithEvents aba As System.Windows.Forms.Label
    Friend WithEvents Izq As System.Windows.Forms.Label
    Friend WithEvents der As System.Windows.Forms.Label
    Friend WithEvents arr As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Icono As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Pnldegradado As System.Windows.Forms.Panel

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        
    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CmdAyuda As System.Windows.Forms.ToolStripButton
    Public WithEvents Logo As System.Windows.Forms.PictureBox
End Class
