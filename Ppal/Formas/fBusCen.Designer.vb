<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fBusCen
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fBusCen))
		Me.LstDis = New System.Windows.Forms.ListBox()
		Me.LstGru = New System.Windows.Forms.ListBox()
		Me.LstSub = New System.Windows.Forms.ListBox()
		Me.LstCen = New System.Windows.Forms.ListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LblGru = New System.Windows.Forms.Label()
		Me.LblSub = New System.Windows.Forms.Label()
		Me.LblCen = New System.Windows.Forms.Label()
		Me.CmdRegresar = New SMDPpal.BotonEstandar()
		Me.CmdCancelar = New SMDPpal.BotonEstandar()
		Me.TxtLibre2 = New System.Windows.Forms.TextBox()
		Me.TxtLibre1 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.CbRango = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(714, 0)
		'
		'LstDis
		'
		Me.LstDis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.LstDis.FormattingEnabled = True
		Me.LstDis.Location = New System.Drawing.Point(12, 30)
		Me.LstDis.Name = "LstDis"
		Me.LstDis.Size = New System.Drawing.Size(175, 173)
		Me.LstDis.Sorted = True
		Me.LstDis.TabIndex = 0
		Me.LstDis.Tag = "197"
		'
		'LstGru
		'
		Me.LstGru.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.LstGru.FormattingEnabled = True
		Me.LstGru.Location = New System.Drawing.Point(193, 30)
		Me.LstGru.Name = "LstGru"
		Me.LstGru.Size = New System.Drawing.Size(175, 225)
		Me.LstGru.Sorted = True
		Me.LstGru.TabIndex = 1
		Me.LstGru.Tag = "376"
		Me.LstGru.Visible = False
		'
		'LstSub
		'
		Me.LstSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.LstSub.FormattingEnabled = True
		Me.LstSub.Location = New System.Drawing.Point(374, 30)
		Me.LstSub.Name = "LstSub"
		Me.LstSub.Size = New System.Drawing.Size(175, 225)
		Me.LstSub.Sorted = True
		Me.LstSub.TabIndex = 2
		Me.LstSub.Tag = "557"
		Me.LstSub.Visible = False
		'
		'LstCen
		'
		Me.LstCen.FormattingEnabled = True
		Me.LstCen.Location = New System.Drawing.Point(555, 30)
		Me.LstCen.Name = "LstCen"
		Me.LstCen.Size = New System.Drawing.Size(175, 225)
		Me.LstCen.Sorted = True
		Me.LstCen.TabIndex = 3
		Me.LstCen.Tag = "741"
		Me.LstCen.Visible = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(108, 13)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Distrito o Sección"
		'
		'LblGru
		'
		Me.LblGru.AutoSize = True
		Me.LblGru.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblGru.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.LblGru.Location = New System.Drawing.Point(195, 9)
		Me.LblGru.Name = "LblGru"
		Me.LblGru.Size = New System.Drawing.Size(41, 13)
		Me.LblGru.TabIndex = 5
		Me.LblGru.Text = "Grupo"
		Me.LblGru.Visible = False
		'
		'LblSub
		'
		Me.LblSub.AutoSize = True
		Me.LblSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.LblSub.Location = New System.Drawing.Point(375, 9)
		Me.LblSub.Name = "LblSub"
		Me.LblSub.Size = New System.Drawing.Size(61, 13)
		Me.LblSub.TabIndex = 6
		Me.LblSub.Text = "Subgrupo"
		Me.LblSub.Visible = False
		'
		'LblCen
		'
		Me.LblCen.AutoSize = True
		Me.LblCen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblCen.ForeColor = System.Drawing.SystemColors.WindowText
		Me.LblCen.Location = New System.Drawing.Point(557, 9)
		Me.LblCen.Name = "LblCen"
		Me.LblCen.Size = New System.Drawing.Size(44, 13)
		Me.LblCen.TabIndex = 7
		Me.LblCen.Text = "Centro"
		Me.LblCen.Visible = False
		'
		'CmdRegresar
		'
		Me.CmdRegresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.CmdRegresar.BackColor = System.Drawing.Color.White
		Me.CmdRegresar.BackgroundImage = CType(resources.GetObject("CmdRegresar.BackgroundImage"), System.Drawing.Image)
		Me.CmdRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdRegresar.ForeColor = System.Drawing.Color.White
		Me.CmdRegresar.Location = New System.Drawing.Point(289, 262)
		Me.CmdRegresar.Name = "CmdRegresar"
		Me.CmdRegresar.Size = New System.Drawing.Size(75, 33)
		Me.CmdRegresar.TabIndex = 8
		Me.CmdRegresar.Text = "Regresar"
		Me.CmdRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdRegresar.UseVisualStyleBackColor = True
		'
		'CmdCancelar
		'
		Me.CmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.CmdCancelar.BackColor = System.Drawing.Color.White
		Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancelar.ForeColor = System.Drawing.Color.White
		Me.CmdCancelar.Location = New System.Drawing.Point(370, 262)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(75, 33)
		Me.CmdCancelar.TabIndex = 9
		Me.CmdCancelar.Text = "Cancelar"
		Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancelar.UseVisualStyleBackColor = True
		'
		'TxtLibre2
		'
		Me.TxtLibre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtLibre2.Location = New System.Drawing.Point(128, 233)
		Me.TxtLibre2.MaxLength = 50
		Me.TxtLibre2.Name = "TxtLibre2"
		Me.TxtLibre2.Size = New System.Drawing.Size(49, 20)
		Me.TxtLibre2.TabIndex = 30
		Me.TxtLibre2.Visible = False
		'
		'TxtLibre1
		'
		Me.TxtLibre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtLibre1.Location = New System.Drawing.Point(76, 233)
		Me.TxtLibre1.MaxLength = 50
		Me.TxtLibre1.Name = "TxtLibre1"
		Me.TxtLibre1.Size = New System.Drawing.Size(49, 20)
		Me.TxtLibre1.TabIndex = 29
		Me.TxtLibre1.Visible = False
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(0, 236)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 13)
		Me.Label2.TabIndex = 31
		Me.Label2.Text = "Cen Inf/Sup"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Label2.Visible = False
		'
		'CbRango
		'
		Me.CbRango.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbRango.FormattingEnabled = True
		Me.CbRango.Items.AddRange(New Object() {"Sin rangos", "Grupo", "Subgrupo", "Centro"})
		Me.CbRango.Location = New System.Drawing.Point(65, 206)
		Me.CbRango.Name = "CbRango"
		Me.CbRango.Size = New System.Drawing.Size(115, 21)
		Me.CbRango.TabIndex = 32
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(9, 209)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(54, 13)
		Me.Label3.TabIndex = 33
		Me.Label3.Text = "Rango de"
		'
		'fBusCen
		'
		Me.AcceptButton = Me.CmdRegresar
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.CancelButton = Me.CmdCancelar
		Me.ClientSize = New System.Drawing.Size(735, 301)
		Me.ControlBox = False
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.CbRango)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TxtLibre2)
		Me.Controls.Add(Me.TxtLibre1)
		Me.Controls.Add(Me.CmdCancelar)
		Me.Controls.Add(Me.CmdRegresar)
		Me.Controls.Add(Me.LblCen)
		Me.Controls.Add(Me.LblSub)
		Me.Controls.Add(Me.LblGru)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.LstCen)
		Me.Controls.Add(Me.LstSub)
		Me.Controls.Add(Me.LstGru)
		Me.Controls.Add(Me.LstDis)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "fBusCen"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Seleccione Centro de Costo"
		Me.Controls.SetChildIndex(Me.LstDis, 0)
		Me.Controls.SetChildIndex(Me.LstGru, 0)
		Me.Controls.SetChildIndex(Me.LstSub, 0)
		Me.Controls.SetChildIndex(Me.LstCen, 0)
		Me.Controls.SetChildIndex(Me.Label1, 0)
		Me.Controls.SetChildIndex(Me.LblGru, 0)
		Me.Controls.SetChildIndex(Me.LblSub, 0)
		Me.Controls.SetChildIndex(Me.LblCen, 0)
		Me.Controls.SetChildIndex(Me.CmdRegresar, 0)
		Me.Controls.SetChildIndex(Me.CmdCancelar, 0)
		Me.Controls.SetChildIndex(Me.TxtLibre1, 0)
		Me.Controls.SetChildIndex(Me.TxtLibre2, 0)
		Me.Controls.SetChildIndex(Me.Label2, 0)
		Me.Controls.SetChildIndex(Me.CbRango, 0)
		Me.Controls.SetChildIndex(Me.Label3, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblGru As System.Windows.Forms.Label
    Friend WithEvents LblSub As System.Windows.Forms.Label
    Friend WithEvents LblCen As System.Windows.Forms.Label
    Public WithEvents LstDis As System.Windows.Forms.ListBox
    Public WithEvents LstGru As System.Windows.Forms.ListBox
    Public WithEvents LstSub As System.Windows.Forms.ListBox
    Public WithEvents LstCen As System.Windows.Forms.ListBox
    Friend WithEvents TxtLibre2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLibre1 As System.Windows.Forms.TextBox
    Friend WithEvents CmdRegresar As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
    Friend WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents CbRango As ComboBox
	Public WithEvents Label3 As Label
End Class
