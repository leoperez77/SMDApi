<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPedirDestinos
    Inherits SMDPpal.AdvanceForm

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fPedirDestinos))
		Me.PnlDest1 = New System.Windows.Forms.Panel()
		Me.LnkDestino1 = New System.Windows.Forms.LinkLabel()
		Me.LblDestino1 = New System.Windows.Forms.Label()
		Me.PnlDest4 = New System.Windows.Forms.Panel()
		Me.LnkDestino4 = New System.Windows.Forms.LinkLabel()
		Me.LblDestino4 = New System.Windows.Forms.Label()
		Me.PnlDest3 = New System.Windows.Forms.Panel()
		Me.LnkDestino3 = New System.Windows.Forms.LinkLabel()
		Me.LblDestino3 = New System.Windows.Forms.Label()
		Me.PnlDest2 = New System.Windows.Forms.Panel()
		Me.LnkDestino2 = New System.Windows.Forms.LinkLabel()
		Me.LblDestino2 = New System.Windows.Forms.Label()
		Me.CmdAceptar = New SMDPpal.BotonEstandar()
		Me.CmdCancelar = New SMDPpal.BotonEstandar()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PnlDest1.SuspendLayout()
		Me.PnlDest4.SuspendLayout()
		Me.PnlDest3.SuspendLayout()
		Me.PnlDest2.SuspendLayout()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(534, 0)
		'
		'PnlDest1
		'
		Me.PnlDest1.BackColor = System.Drawing.Color.Azure
		Me.PnlDest1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlDest1.Controls.Add(Me.LnkDestino1)
		Me.PnlDest1.Controls.Add(Me.LblDestino1)
		Me.PnlDest1.Location = New System.Drawing.Point(14, 8)
		Me.PnlDest1.Name = "PnlDest1"
		Me.PnlDest1.Size = New System.Drawing.Size(520, 26)
		Me.PnlDest1.TabIndex = 254
		Me.PnlDest1.Visible = False
		'
		'LnkDestino1
		'
		Me.LnkDestino1.AutoSize = True
		Me.LnkDestino1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkDestino1.LinkColor = System.Drawing.Color.Blue
		Me.LnkDestino1.Location = New System.Drawing.Point(7, 5)
		Me.LnkDestino1.Name = "LnkDestino1"
		Me.LnkDestino1.Size = New System.Drawing.Size(86, 13)
		Me.LnkDestino1.TabIndex = 260
		Me.LnkDestino1.TabStop = True
		Me.LnkDestino1.Text = "Dimensión 1 (F1)"
		'
		'LblDestino1
		'
		Me.LblDestino1.BackColor = System.Drawing.Color.White
		Me.LblDestino1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblDestino1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDestino1.ForeColor = System.Drawing.Color.Blue
		Me.LblDestino1.Location = New System.Drawing.Point(99, 2)
		Me.LblDestino1.Name = "LblDestino1"
		Me.LblDestino1.Size = New System.Drawing.Size(414, 19)
		Me.LblDestino1.TabIndex = 261
		Me.LblDestino1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PnlDest4
		'
		Me.PnlDest4.BackColor = System.Drawing.Color.Azure
		Me.PnlDest4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlDest4.Controls.Add(Me.LnkDestino4)
		Me.PnlDest4.Controls.Add(Me.LblDestino4)
		Me.PnlDest4.Location = New System.Drawing.Point(14, 92)
		Me.PnlDest4.Name = "PnlDest4"
		Me.PnlDest4.Size = New System.Drawing.Size(520, 26)
		Me.PnlDest4.TabIndex = 264
		Me.PnlDest4.Visible = False
		'
		'LnkDestino4
		'
		Me.LnkDestino4.AutoSize = True
		Me.LnkDestino4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkDestino4.LinkColor = System.Drawing.Color.Maroon
		Me.LnkDestino4.Location = New System.Drawing.Point(7, 5)
		Me.LnkDestino4.Name = "LnkDestino4"
		Me.LnkDestino4.Size = New System.Drawing.Size(86, 13)
		Me.LnkDestino4.TabIndex = 260
		Me.LnkDestino4.TabStop = True
		Me.LnkDestino4.Text = "Dimensión 4 (F4)"
		'
		'LblDestino4
		'
		Me.LblDestino4.BackColor = System.Drawing.Color.White
		Me.LblDestino4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblDestino4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDestino4.ForeColor = System.Drawing.Color.Maroon
		Me.LblDestino4.Location = New System.Drawing.Point(99, 2)
		Me.LblDestino4.Name = "LblDestino4"
		Me.LblDestino4.Size = New System.Drawing.Size(414, 19)
		Me.LblDestino4.TabIndex = 261
		Me.LblDestino4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PnlDest3
		'
		Me.PnlDest3.BackColor = System.Drawing.Color.Azure
		Me.PnlDest3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlDest3.Controls.Add(Me.LnkDestino3)
		Me.PnlDest3.Controls.Add(Me.LblDestino3)
		Me.PnlDest3.Location = New System.Drawing.Point(14, 64)
		Me.PnlDest3.Name = "PnlDest3"
		Me.PnlDest3.Size = New System.Drawing.Size(520, 26)
		Me.PnlDest3.TabIndex = 263
		Me.PnlDest3.Visible = False
		'
		'LnkDestino3
		'
		Me.LnkDestino3.AutoSize = True
		Me.LnkDestino3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkDestino3.LinkColor = System.Drawing.Color.Green
		Me.LnkDestino3.Location = New System.Drawing.Point(7, 5)
		Me.LnkDestino3.Name = "LnkDestino3"
		Me.LnkDestino3.Size = New System.Drawing.Size(86, 13)
		Me.LnkDestino3.TabIndex = 260
		Me.LnkDestino3.TabStop = True
		Me.LnkDestino3.Text = "Dimensión 3 (F3)"
		'
		'LblDestino3
		'
		Me.LblDestino3.BackColor = System.Drawing.Color.White
		Me.LblDestino3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblDestino3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDestino3.ForeColor = System.Drawing.Color.Green
		Me.LblDestino3.Location = New System.Drawing.Point(99, 2)
		Me.LblDestino3.Name = "LblDestino3"
		Me.LblDestino3.Size = New System.Drawing.Size(414, 19)
		Me.LblDestino3.TabIndex = 261
		Me.LblDestino3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PnlDest2
		'
		Me.PnlDest2.BackColor = System.Drawing.Color.Azure
		Me.PnlDest2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlDest2.Controls.Add(Me.LnkDestino2)
		Me.PnlDest2.Controls.Add(Me.LblDestino2)
		Me.PnlDest2.Location = New System.Drawing.Point(14, 36)
		Me.PnlDest2.Name = "PnlDest2"
		Me.PnlDest2.Size = New System.Drawing.Size(520, 26)
		Me.PnlDest2.TabIndex = 262
		Me.PnlDest2.Visible = False
		'
		'LnkDestino2
		'
		Me.LnkDestino2.AutoSize = True
		Me.LnkDestino2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkDestino2.LinkColor = System.Drawing.Color.Red
		Me.LnkDestino2.Location = New System.Drawing.Point(7, 5)
		Me.LnkDestino2.Name = "LnkDestino2"
		Me.LnkDestino2.Size = New System.Drawing.Size(86, 13)
		Me.LnkDestino2.TabIndex = 260
		Me.LnkDestino2.TabStop = True
		Me.LnkDestino2.Text = "Dimensión 2 (F2)"
		'
		'LblDestino2
		'
		Me.LblDestino2.BackColor = System.Drawing.Color.White
		Me.LblDestino2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblDestino2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDestino2.ForeColor = System.Drawing.Color.Red
		Me.LblDestino2.Location = New System.Drawing.Point(99, 2)
		Me.LblDestino2.Name = "LblDestino2"
		Me.LblDestino2.Size = New System.Drawing.Size(414, 19)
		Me.LblDestino2.TabIndex = 261
		Me.LblDestino2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'CmdAceptar
		'
		Me.CmdAceptar.BackColor = System.Drawing.Color.White
		Me.CmdAceptar.BackgroundImage = CType(resources.GetObject("CmdAceptar.BackgroundImage"), System.Drawing.Image)
		Me.CmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdAceptar.ForeColor = System.Drawing.Color.White
		Me.CmdAceptar.Location = New System.Drawing.Point(180, 124)
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(101, 27)
		Me.CmdAceptar.TabIndex = 255
		Me.CmdAceptar.Text = "Aceptar (F5)"
		Me.CmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdAceptar.UseVisualStyleBackColor = False
		'
		'CmdCancelar
		'
		Me.CmdCancelar.BackColor = System.Drawing.Color.White
		Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancelar.ForeColor = System.Drawing.Color.White
		Me.CmdCancelar.Location = New System.Drawing.Point(299, 124)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(91, 27)
		Me.CmdCancelar.TabIndex = 256
		Me.CmdCancelar.Text = "Cancelar (ESC)"
		Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancelar.UseVisualStyleBackColor = False
		'
		'fPedirDestinos
		'
		Me.AcceptButton = Me.CmdAceptar
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.CmdCancelar
		Me.ClientSize = New System.Drawing.Size(555, 155)
		Me.ControlBox = False
		Me.Controls.Add(Me.PnlDest4)
		Me.Controls.Add(Me.PnlDest3)
		Me.Controls.Add(Me.CmdCancelar)
		Me.Controls.Add(Me.PnlDest2)
		Me.Controls.Add(Me.CmdAceptar)
		Me.Controls.Add(Me.PnlDest1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "fPedirDestinos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Destinos"
		Me.Controls.SetChildIndex(Me.PnlDest1, 0)
		Me.Controls.SetChildIndex(Me.CmdAceptar, 0)
		Me.Controls.SetChildIndex(Me.PnlDest2, 0)
		Me.Controls.SetChildIndex(Me.CmdCancelar, 0)
		Me.Controls.SetChildIndex(Me.PnlDest3, 0)
		Me.Controls.SetChildIndex(Me.PnlDest4, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PnlDest1.ResumeLayout(False)
		Me.PnlDest1.PerformLayout()
		Me.PnlDest4.ResumeLayout(False)
		Me.PnlDest4.PerformLayout()
		Me.PnlDest3.ResumeLayout(False)
		Me.PnlDest3.PerformLayout()
		Me.PnlDest2.ResumeLayout(False)
		Me.PnlDest2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents PnlDest1 As System.Windows.Forms.Panel
    Friend WithEvents PnlDest4 As System.Windows.Forms.Panel
    Friend WithEvents PnlDest3 As System.Windows.Forms.Panel
    Friend WithEvents PnlDest2 As System.Windows.Forms.Panel
    Friend WithEvents CmdAceptar As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
    Public WithEvents LblDestino4 As System.Windows.Forms.Label
    Public WithEvents LblDestino3 As System.Windows.Forms.Label
    Public WithEvents LblDestino2 As System.Windows.Forms.Label
    Public WithEvents LblDestino1 As System.Windows.Forms.Label
    Public WithEvents LnkDestino4 As System.Windows.Forms.LinkLabel
    Public WithEvents LnkDestino3 As System.Windows.Forms.LinkLabel
    Public WithEvents LnkDestino2 As System.Windows.Forms.LinkLabel
    Public WithEvents LnkDestino1 As System.Windows.Forms.LinkLabel
End Class
