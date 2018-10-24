<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMensaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMensaje))
        Me.LnkEnviar = New System.Windows.Forms.LinkLabel()
        Me.PnlSiNo = New System.Windows.Forms.Panel()
        Me.CmdCancelar = New SMDPpal.BotonEstandar()
        Me.CmdNo = New SMDPpal.BotonEstandar()
        Me.CmdSi = New SMDPpal.BotonEstandar()
        Me.PnlNormal = New System.Windows.Forms.Panel()
        Me.LnkAutorizacion = New System.Windows.Forms.LinkLabel()
        Me.CmdAceptar = New SMDPpal.BotonEstandar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblComplemento = New System.Windows.Forms.Label()
        Me.Txt = New System.Windows.Forms.RichTextBox()
        Me.ChkNoVolver = New System.Windows.Forms.CheckBox()
        Me.PnlRespCompleja = New System.Windows.Forms.Panel()
        Me.CmdAcepResp = New SMDPpal.BotonEstandar()
        Me.TxtResp = New System.Windows.Forms.TextBox()
        Me.LblSemaforo = New System.Windows.Forms.Label()
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSiNo.SuspendLayout()
        Me.PnlNormal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlRespCompleja.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicPuntoAdv
        '
        Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicPuntoAdv.Location = New System.Drawing.Point(534, 0)
        '
        'LnkEnviar
        '
        Me.LnkEnviar.AutoSize = True
        Me.LnkEnviar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkEnviar.Location = New System.Drawing.Point(180, 14)
        Me.LnkEnviar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LnkEnviar.Name = "LnkEnviar"
        Me.LnkEnviar.Size = New System.Drawing.Size(31, 13)
        Me.LnkEnviar.TabIndex = 1
        Me.LnkEnviar.TabStop = True
        Me.LnkEnviar.Text = "DMS"
        '
        'PnlSiNo
        '
        Me.PnlSiNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSiNo.BackColor = System.Drawing.Color.White
        Me.PnlSiNo.Controls.Add(Me.CmdCancelar)
        Me.PnlSiNo.Controls.Add(Me.CmdNo)
        Me.PnlSiNo.Controls.Add(Me.CmdSi)
        Me.PnlSiNo.Location = New System.Drawing.Point(217, 279)
        Me.PnlSiNo.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlSiNo.Name = "PnlSiNo"
        Me.PnlSiNo.Size = New System.Drawing.Size(335, 54)
        Me.PnlSiNo.TabIndex = 0
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
        Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancelar.ForeColor = System.Drawing.Color.White
        Me.CmdCancelar.Location = New System.Drawing.Point(253, 12)
        Me.CmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(79, 28)
        Me.CmdCancelar.TabIndex = 2
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancelar.UseVisualStyleBackColor = False
        Me.CmdCancelar.Visible = False
        '
        'CmdNo
        '
        Me.CmdNo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CmdNo.BackgroundImage = CType(resources.GetObject("CmdNo.BackgroundImage"), System.Drawing.Image)
        Me.CmdNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdNo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNo.ForeColor = System.Drawing.Color.White
        Me.CmdNo.Location = New System.Drawing.Point(176, 12)
        Me.CmdNo.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdNo.Name = "CmdNo"
        Me.CmdNo.Size = New System.Drawing.Size(64, 28)
        Me.CmdNo.TabIndex = 1
        Me.CmdNo.Text = "No"
        Me.CmdNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdNo.UseVisualStyleBackColor = False
        '
        'CmdSi
        '
        Me.CmdSi.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CmdSi.BackgroundImage = CType(resources.GetObject("CmdSi.BackgroundImage"), System.Drawing.Image)
        Me.CmdSi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdSi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSi.ForeColor = System.Drawing.Color.White
        Me.CmdSi.Location = New System.Drawing.Point(97, 12)
        Me.CmdSi.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSi.Name = "CmdSi"
        Me.CmdSi.Size = New System.Drawing.Size(64, 28)
        Me.CmdSi.TabIndex = 0
        Me.CmdSi.Text = "Si"
        Me.CmdSi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdSi.UseVisualStyleBackColor = False
        '
        'PnlNormal
        '
        Me.PnlNormal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlNormal.BackColor = System.Drawing.Color.White
        Me.PnlNormal.Controls.Add(Me.LnkAutorizacion)
        Me.PnlNormal.Controls.Add(Me.CmdAceptar)
        Me.PnlNormal.Controls.Add(Me.LnkEnviar)
        Me.PnlNormal.Location = New System.Drawing.Point(217, 186)
        Me.PnlNormal.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlNormal.Name = "PnlNormal"
        Me.PnlNormal.Size = New System.Drawing.Size(335, 42)
        Me.PnlNormal.TabIndex = 2
        '
        'LnkAutorizacion
        '
        Me.LnkAutorizacion.AutoSize = True
        Me.LnkAutorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkAutorizacion.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkAutorizacion.Location = New System.Drawing.Point(4, 14)
        Me.LnkAutorizacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LnkAutorizacion.Name = "LnkAutorizacion"
        Me.LnkAutorizacion.Size = New System.Drawing.Size(154, 16)
        Me.LnkAutorizacion.TabIndex = 3
        Me.LnkAutorizacion.TabStop = True
        Me.LnkAutorizacion.Text = "Solicitar Autorización"
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CmdAceptar.BackgroundImage = CType(resources.GetObject("CmdAceptar.BackgroundImage"), System.Drawing.Image)
        Me.CmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAceptar.ForeColor = System.Drawing.Color.White
        Me.CmdAceptar.Location = New System.Drawing.Point(225, 6)
        Me.CmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.Size = New System.Drawing.Size(100, 28)
        Me.CmdAceptar.TabIndex = 2
        Me.CmdAceptar.Text = "Aceptar"
        Me.CmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(13, 54)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(67, 191)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'LblComplemento
        '
        Me.LblComplemento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComplemento.ForeColor = System.Drawing.Color.Green
        Me.LblComplemento.Location = New System.Drawing.Point(224, 0)
        Me.LblComplemento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblComplemento.Name = "LblComplemento"
        Me.LblComplemento.Size = New System.Drawing.Size(324, 17)
        Me.LblComplemento.TabIndex = 4
        Me.LblComplemento.Text = "versión y usuario"
        Me.LblComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt
        '
        Me.Txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt.BackColor = System.Drawing.Color.White
        Me.Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt.Location = New System.Drawing.Point(217, 54)
        Me.Txt.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt.Name = "Txt"
        Me.Txt.ReadOnly = True
        Me.Txt.Size = New System.Drawing.Size(331, 212)
        Me.Txt.TabIndex = 5
        Me.Txt.Text = ""
        '
        'ChkNoVolver
        '
        Me.ChkNoVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkNoVolver.AutoSize = True
        Me.ChkNoVolver.BackColor = System.Drawing.Color.White
        Me.ChkNoVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNoVolver.Location = New System.Drawing.Point(25, 312)
        Me.ChkNoVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkNoVolver.Name = "ChkNoVolver"
        Me.ChkNoVolver.Size = New System.Drawing.Size(129, 17)
        Me.ChkNoVolver.TabIndex = 3
        Me.ChkNoVolver.Text = "No volver a preguntar"
        Me.ChkNoVolver.UseVisualStyleBackColor = False
        Me.ChkNoVolver.Visible = False
        '
        'PnlRespCompleja
        '
        Me.PnlRespCompleja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlRespCompleja.Controls.Add(Me.CmdAcepResp)
        Me.PnlRespCompleja.Controls.Add(Me.TxtResp)
        Me.PnlRespCompleja.Location = New System.Drawing.Point(218, 228)
        Me.PnlRespCompleja.Name = "PnlRespCompleja"
        Me.PnlRespCompleja.Size = New System.Drawing.Size(333, 51)
        Me.PnlRespCompleja.TabIndex = 6
        '
        'CmdAcepResp
        '
        Me.CmdAcepResp.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CmdAcepResp.BackgroundImage = CType(resources.GetObject("CmdAcepResp.BackgroundImage"), System.Drawing.Image)
        Me.CmdAcepResp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdAcepResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAcepResp.ForeColor = System.Drawing.Color.White
        Me.CmdAcepResp.Location = New System.Drawing.Point(253, 10)
        Me.CmdAcepResp.Name = "CmdAcepResp"
        Me.CmdAcepResp.Size = New System.Drawing.Size(75, 34)
        Me.CmdAcepResp.TabIndex = 2
        Me.CmdAcepResp.Text = "Aceptar"
        Me.CmdAcepResp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdAcepResp.UseVisualStyleBackColor = False
        '
        'TxtResp
        '
        Me.TxtResp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtResp.Location = New System.Drawing.Point(168, 18)
        Me.TxtResp.Name = "TxtResp"
        Me.TxtResp.Size = New System.Drawing.Size(74, 20)
        Me.TxtResp.TabIndex = 1
        Me.TxtResp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblSemaforo
        '
        Me.LblSemaforo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblSemaforo.BackColor = System.Drawing.Color.DodgerBlue
        Me.LblSemaforo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblSemaforo.Location = New System.Drawing.Point(-2, 326)
        Me.LblSemaforo.Name = "LblSemaforo"
        Me.LblSemaforo.Size = New System.Drawing.Size(11, 8)
        Me.LblSemaforo.TabIndex = 12
        Me.LblSemaforo.Text = " "
        '
        'fMensaje
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(555, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblSemaforo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PnlRespCompleja)
        Me.Controls.Add(Me.PnlNormal)
        Me.Controls.Add(Me.ChkNoVolver)
        Me.Controls.Add(Me.Txt)
        Me.Controls.Add(Me.LblComplemento)
        Me.Controls.Add(Me.PnlSiNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fMensaje"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mensaje"
        Me.TopMost = True
        Me.Controls.SetChildIndex(Me.PnlSiNo, 0)
        Me.Controls.SetChildIndex(Me.LblComplemento, 0)
        Me.Controls.SetChildIndex(Me.Txt, 0)
        Me.Controls.SetChildIndex(Me.ChkNoVolver, 0)
        Me.Controls.SetChildIndex(Me.PnlNormal, 0)
        Me.Controls.SetChildIndex(Me.PnlRespCompleja, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox2, 0)
        Me.Controls.SetChildIndex(Me.LblSemaforo, 0)
        Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSiNo.ResumeLayout(False)
        Me.PnlNormal.ResumeLayout(False)
        Me.PnlNormal.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlRespCompleja.ResumeLayout(False)
        Me.PnlRespCompleja.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LnkEnviar As System.Windows.Forms.LinkLabel
    Friend WithEvents PnlSiNo As System.Windows.Forms.Panel
    Friend WithEvents PnlNormal As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblComplemento As System.Windows.Forms.Label
    Friend WithEvents Txt As System.Windows.Forms.RichTextBox
    Friend WithEvents ChkNoVolver As System.Windows.Forms.CheckBox
    Friend WithEvents LnkAutorizacion As System.Windows.Forms.LinkLabel
    Friend WithEvents PnlRespCompleja As System.Windows.Forms.Panel
    Friend WithEvents TxtResp As System.Windows.Forms.TextBox
    Friend WithEvents CmdAceptar As SMDPpal.BotonEstandar
    Friend WithEvents CmdNo As SMDPpal.BotonEstandar
    Friend WithEvents CmdSi As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
    Friend WithEvents CmdAcepResp As SMDPpal.BotonEstandar
    Friend WithEvents LblSemaforo As System.Windows.Forms.Label
End Class
