<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPregContenido
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fPregContenido))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TxtContenido = New System.Windows.Forms.TextBox()
		Me.CmdAceptar = New SMDPpal.BotonEstandar()
		Me.CmdCancelar = New SMDPpal.BotonEstandar()
		Me.LblFile = New System.Windows.Forms.Label()
		Me.PicLogo = New System.Windows.Forms.PictureBox()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(389, 0)
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(162, 65)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(186, 13)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Opcional: Qué contiene este archivo?"
		'
		'TxtContenido
		'
		Me.TxtContenido.Location = New System.Drawing.Point(165, 81)
		Me.TxtContenido.MaxLength = 50
		Me.TxtContenido.Name = "TxtContenido"
		Me.TxtContenido.Size = New System.Drawing.Size(224, 20)
		Me.TxtContenido.TabIndex = 6
		'
		'CmdAceptar
		'
		Me.CmdAceptar.BackColor = System.Drawing.Color.White
		Me.CmdAceptar.BackgroundImage = CType(resources.GetObject("CmdAceptar.BackgroundImage"), System.Drawing.Image)
		Me.CmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdAceptar.ForeColor = System.Drawing.Color.White
		Me.CmdAceptar.Location = New System.Drawing.Point(144, 137)
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(119, 38)
		Me.CmdAceptar.TabIndex = 7
		Me.CmdAceptar.Text = "Aceptar"
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
		Me.CmdCancelar.Location = New System.Drawing.Point(270, 137)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(119, 38)
		Me.CmdCancelar.TabIndex = 8
		Me.CmdCancelar.Text = "Cancelar"
		Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancelar.UseVisualStyleBackColor = False
		'
		'LblFile
		'
		Me.LblFile.BackColor = System.Drawing.Color.Linen
		Me.LblFile.Dock = System.Windows.Forms.DockStyle.Top
		Me.LblFile.Location = New System.Drawing.Point(0, 0)
		Me.LblFile.Name = "LblFile"
		Me.LblFile.Size = New System.Drawing.Size(410, 41)
		Me.LblFile.TabIndex = 9
		Me.LblFile.Text = "file"
		Me.LblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'PicLogo
		'
		Me.PicLogo.BackColor = System.Drawing.Color.White
		Me.PicLogo.Cursor = System.Windows.Forms.Cursors.Default
		Me.PicLogo.Location = New System.Drawing.Point(12, 65)
		Me.PicLogo.Name = "PicLogo"
		Me.PicLogo.Size = New System.Drawing.Size(104, 95)
		Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PicLogo.TabIndex = 140
		Me.PicLogo.TabStop = False
		'
		'fPregContenido
		'
		Me.AcceptButton = Me.CmdAceptar
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.CancelButton = Me.CmdCancelar
		Me.ClientSize = New System.Drawing.Size(410, 187)
		Me.ControlBox = False
		Me.Controls.Add(Me.CmdAceptar)
		Me.Controls.Add(Me.PicLogo)
		Me.Controls.Add(Me.LblFile)
		Me.Controls.Add(Me.CmdCancelar)
		Me.Controls.Add(Me.TxtContenido)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "fPregContenido"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Contenido"
		Me.TopMost = True
		Me.Controls.SetChildIndex(Me.Label1, 0)
		Me.Controls.SetChildIndex(Me.TxtContenido, 0)
		Me.Controls.SetChildIndex(Me.CmdCancelar, 0)
		Me.Controls.SetChildIndex(Me.LblFile, 0)
		Me.Controls.SetChildIndex(Me.PicLogo, 0)
		Me.Controls.SetChildIndex(Me.CmdAceptar, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtContenido As System.Windows.Forms.TextBox
    Friend WithEvents CmdAceptar As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
    Friend WithEvents LblFile As System.Windows.Forms.Label
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
End Class
