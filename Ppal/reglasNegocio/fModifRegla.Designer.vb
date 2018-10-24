<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fModifRegla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fModifRegla))
        Me.LnkAgrandar = New System.Windows.Forms.LinkLabel()
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.LblRegla = New System.Windows.Forms.Label()
        Me.PnlSINO = New System.Windows.Forms.Panel()
        Me.RdNo = New System.Windows.Forms.RadioButton()
        Me.RdSi = New System.Windows.Forms.RadioButton()
        Me.PnlTexto = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDefault = New System.Windows.Forms.Label()
        Me.LnkAudit = New System.Windows.Forms.LinkLabel()
        Me.CmdAdiRegla = New SMDPpal.BotonEstandar()
        Me.TxtDespRegla = New System.Windows.Forms.TextBox()
        Me.CmdCancelar = New SMDPpal.BotonEstandar()
        Me.LblTitLlave = New System.Windows.Forms.Label()
        Me.LblLlave = New System.Windows.Forms.Label()
        Me.LblTtitulo = New System.Windows.Forms.Label()
        Me.PnlSINO.SuspendLayout()
        Me.PnlTexto.SuspendLayout()
        Me.SuspendLayout()
        '
        'LnkAgrandar
        '
        Me.LnkAgrandar.AutoSize = True
        Me.LnkAgrandar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkAgrandar.Location = New System.Drawing.Point(404, 16)
        Me.LnkAgrandar.Name = "LnkAgrandar"
        Me.LnkAgrandar.Size = New System.Drawing.Size(50, 13)
        Me.LnkAgrandar.TabIndex = 3
        Me.LnkAgrandar.TabStop = True
        Me.LnkAgrandar.Text = "Agrandar"
        '
        'TxtTexto
        '
        Me.TxtTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTexto.Location = New System.Drawing.Point(13, 12)
        Me.TxtTexto.MaxLength = 5000
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(385, 22)
        Me.TxtTexto.TabIndex = 2
        '
        'LblRegla
        '
        Me.LblRegla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRegla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegla.Location = New System.Drawing.Point(82, 78)
        Me.LblRegla.Name = "LblRegla"
        Me.LblRegla.Size = New System.Drawing.Size(459, 48)
        Me.LblRegla.TabIndex = 4
        Me.LblRegla.Text = "Texto de la regla"
        Me.LblRegla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSINO
        '
        Me.PnlSINO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSINO.Controls.Add(Me.RdNo)
        Me.PnlSINO.Controls.Add(Me.RdSi)
        Me.PnlSINO.Location = New System.Drawing.Point(96, 334)
        Me.PnlSINO.Name = "PnlSINO"
        Me.PnlSINO.Size = New System.Drawing.Size(459, 58)
        Me.PnlSINO.TabIndex = 5
        Me.PnlSINO.Visible = False
        '
        'RdNo
        '
        Me.RdNo.AutoSize = True
        Me.RdNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdNo.Location = New System.Drawing.Point(262, 14)
        Me.RdNo.Name = "RdNo"
        Me.RdNo.Size = New System.Drawing.Size(99, 20)
        Me.RdNo.TabIndex = 1
        Me.RdNo.TabStop = True
        Me.RdNo.Text = "No (Falso)"
        Me.RdNo.UseVisualStyleBackColor = True
        '
        'RdSi
        '
        Me.RdSi.AutoSize = True
        Me.RdSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdSi.Location = New System.Drawing.Point(89, 14)
        Me.RdSi.Name = "RdSi"
        Me.RdSi.Size = New System.Drawing.Size(128, 20)
        Me.RdSi.TabIndex = 0
        Me.RdSi.TabStop = True
        Me.RdSi.Text = "Si (Verdadero)"
        Me.RdSi.UseVisualStyleBackColor = True
        '
        'PnlTexto
        '
        Me.PnlTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTexto.Controls.Add(Me.Label1)
        Me.PnlTexto.Controls.Add(Me.LblDefault)
        Me.PnlTexto.Controls.Add(Me.TxtTexto)
        Me.PnlTexto.Controls.Add(Me.LnkAgrandar)
        Me.PnlTexto.Location = New System.Drawing.Point(82, 125)
        Me.PnlTexto.Name = "PnlTexto"
        Me.PnlTexto.Size = New System.Drawing.Size(459, 61)
        Me.PnlTexto.TabIndex = 2
        Me.PnlTexto.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Predeterminado"
        '
        'LblDefault
        '
        Me.LblDefault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDefault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblDefault.Location = New System.Drawing.Point(103, 39)
        Me.LblDefault.Name = "LblDefault"
        Me.LblDefault.Size = New System.Drawing.Size(295, 16)
        Me.LblDefault.TabIndex = 95
        '
        'LnkAudit
        '
        Me.LnkAudit.AutoSize = True
        Me.LnkAudit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkAudit.Location = New System.Drawing.Point(129, 197)
        Me.LnkAudit.Name = "LnkAudit"
        Me.LnkAudit.Size = New System.Drawing.Size(50, 13)
        Me.LnkAudit.TabIndex = 89
        Me.LnkAudit.TabStop = True
        Me.LnkAudit.Text = "Auditoría"
        '
        'CmdAdiRegla
        '
        Me.CmdAdiRegla.BackColor = System.Drawing.Color.White
        Me.CmdAdiRegla.BackgroundImage = CType(resources.GetObject("CmdAdiRegla.BackgroundImage"), System.Drawing.Image)
        Me.CmdAdiRegla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdAdiRegla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAdiRegla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdiRegla.ForeColor = System.Drawing.Color.White
        Me.CmdAdiRegla.Location = New System.Drawing.Point(356, 192)
        Me.CmdAdiRegla.Name = "CmdAdiRegla"
        Me.CmdAdiRegla.Size = New System.Drawing.Size(89, 28)
        Me.CmdAdiRegla.TabIndex = 88
        Me.CmdAdiRegla.Text = "Adicionar"
        Me.CmdAdiRegla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdAdiRegla.UseVisualStyleBackColor = True
        '
        'TxtDespRegla
        '
        Me.TxtDespRegla.AcceptsReturn = True
        Me.TxtDespRegla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtDespRegla.BackColor = System.Drawing.Color.Linen
        Me.TxtDespRegla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDespRegla.Location = New System.Drawing.Point(82, 233)
        Me.TxtDespRegla.MaxLength = 500
        Me.TxtDespRegla.Multiline = True
        Me.TxtDespRegla.Name = "TxtDespRegla"
        Me.TxtDespRegla.ReadOnly = True
        Me.TxtDespRegla.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtDespRegla.Size = New System.Drawing.Size(489, 316)
        Me.TxtDespRegla.TabIndex = 90
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.Color.White
        Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
        Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancelar.ForeColor = System.Drawing.Color.White
        Me.CmdCancelar.Location = New System.Drawing.Point(452, 192)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(89, 28)
        Me.CmdCancelar.TabIndex = 91
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancelar.UseVisualStyleBackColor = True
        '
        'LblTitLlave
        '
        Me.LblTitLlave.AutoSize = True
        Me.LblTitLlave.Location = New System.Drawing.Point(227, 54)
        Me.LblTitLlave.Name = "LblTitLlave"
        Me.LblTitLlave.Size = New System.Drawing.Size(33, 13)
        Me.LblTitLlave.TabIndex = 92
        Me.LblTitLlave.Text = "Llave"
        '
        'LblLlave
        '
        Me.LblLlave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblLlave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLlave.Location = New System.Drawing.Point(263, 52)
        Me.LblLlave.Name = "LblLlave"
        Me.LblLlave.Size = New System.Drawing.Size(97, 19)
        Me.LblLlave.TabIndex = 93
        Me.LblLlave.Text = "Llave"
        Me.LblLlave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTtitulo
        '
        Me.LblTtitulo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.LblTtitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTtitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTtitulo.ForeColor = System.Drawing.Color.White
        Me.LblTtitulo.Location = New System.Drawing.Point(82, 9)
        Me.LblTtitulo.Name = "LblTtitulo"
        Me.LblTtitulo.Size = New System.Drawing.Size(459, 35)
        Me.LblTtitulo.TabIndex = 94
        Me.LblTtitulo.Text = "Título"
        Me.LblTtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fModifRegla
        '
        Me.AcceptButton = Me.CmdAdiRegla
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CmdCancelar
        Me.ClientSize = New System.Drawing.Size(632, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.PnlSINO)
        Me.Controls.Add(Me.LblTtitulo)
        Me.Controls.Add(Me.LblLlave)
        Me.Controls.Add(Me.LblTitLlave)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.TxtDespRegla)
        Me.Controls.Add(Me.LnkAudit)
        Me.Controls.Add(Me.CmdAdiRegla)
        Me.Controls.Add(Me.PnlTexto)
        Me.Controls.Add(Me.LblRegla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fModifRegla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificar regla"
        Me.PnlSINO.ResumeLayout(False)
        Me.PnlSINO.PerformLayout()
        Me.PnlTexto.ResumeLayout(False)
        Me.PnlTexto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LnkAgrandar As System.Windows.Forms.LinkLabel
    Friend WithEvents TxtTexto As System.Windows.Forms.TextBox
    Friend WithEvents LblRegla As System.Windows.Forms.Label
    Friend WithEvents PnlSINO As System.Windows.Forms.Panel
    Friend WithEvents RdNo As System.Windows.Forms.RadioButton
    Friend WithEvents RdSi As System.Windows.Forms.RadioButton
    Friend WithEvents PnlTexto As System.Windows.Forms.Panel
    Friend WithEvents LnkAudit As System.Windows.Forms.LinkLabel
    Friend WithEvents CmdAdiRegla As SMDPpal.BotonEstandar
    Friend WithEvents TxtDespRegla As System.Windows.Forms.TextBox
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
    Friend WithEvents LblTitLlave As System.Windows.Forms.Label
    Friend WithEvents LblLlave As System.Windows.Forms.Label
    Friend WithEvents LblTtitulo As System.Windows.Forms.Label
    Friend WithEvents LblDefault As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
