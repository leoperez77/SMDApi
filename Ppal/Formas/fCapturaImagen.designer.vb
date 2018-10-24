'♥ versión: 586, 6-oct.-2017 07:11
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCapturaImagen
    Inherits AdvanceForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCapturaImagen))
        Me.ToolFoto = New System.Windows.Forms.ToolStrip()
        Me.CmdAbrir = New System.Windows.Forms.ToolStripButton()
        Me.CmdSalvar = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.ToolStripLabel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CmdCancelar = New SMDPpal.BotonEstandar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolFoto.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicPuntoAdv
        '
        Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicPuntoAdv.Location = New System.Drawing.Point(533, 0)
        '
        'ToolFoto
        '
        Me.ToolFoto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolFoto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdAbrir, Me.CmdSalvar, Me.Label3})
        Me.ToolFoto.Location = New System.Drawing.Point(0, 0)
        Me.ToolFoto.Name = "ToolFoto"
        Me.ToolFoto.Size = New System.Drawing.Size(554, 25)
        Me.ToolFoto.TabIndex = 3
        Me.ToolFoto.Text = "ToolStrip1"
        '
        'CmdAbrir
        '
        Me.CmdAbrir.Image = CType(resources.GetObject("CmdAbrir.Image"), System.Drawing.Image)
        Me.CmdAbrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdAbrir.Name = "CmdAbrir"
        Me.CmdAbrir.Size = New System.Drawing.Size(96, 22)
        Me.CmdAbrir.Text = "Abrir Imagen"
        '
        'CmdSalvar
        '
        Me.CmdSalvar.Enabled = False
        Me.CmdSalvar.Image = CType(resources.GetObject("CmdSalvar.Image"), System.Drawing.Image)
        Me.CmdSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdSalvar.Name = "CmdSalvar"
        Me.CmdSalvar.Size = New System.Drawing.Size(101, 22)
        Me.CmdSalvar.Text = "Salvar Imagen"
        '
        'Label3
        '
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 22)
        Me.Label3.Text = "Imagen Original"
        Me.Label3.Visible = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "JPEG Files|*.jpg"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivos JPEG|*.jpg"
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.Color.White
        Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
        Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancelar.ForeColor = System.Drawing.Color.White
        Me.CmdCancelar.Location = New System.Drawing.Point(48, 53)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(63, 27)
        Me.CmdCancelar.TabIndex = 5
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancelar.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TrackBar1.Location = New System.Drawing.Point(0, 489)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(554, 45)
        Me.TrackBar1.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(326, 401)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(552, 462)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 464)
        Me.Panel1.TabIndex = 6
        '
        'fCapturaImagen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CmdCancelar
        Me.ClientSize = New System.Drawing.Size(554, 534)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ToolFoto)
        Me.Name = "fCapturaImagen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura de Imagen"
        Me.Controls.SetChildIndex(Me.ToolFoto, 0)
        Me.Controls.SetChildIndex(Me.PictureBox3, 0)
        Me.Controls.SetChildIndex(Me.CmdCancelar, 0)
        Me.Controls.SetChildIndex(Me.TrackBar1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolFoto.ResumeLayout(False)
        Me.ToolFoto.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolFoto As System.Windows.Forms.ToolStrip
    Friend WithEvents CmdAbrir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmdSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
End Class
