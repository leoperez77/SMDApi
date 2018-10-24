' Version: 626, 16-feb.-2018 12:38
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCtaDestinos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCtaDestinos))
        Me.CmdOK = New SMDPpal.BotonEstandar()
        Me.LnkRet0 = New System.Windows.Forms.LinkLabel()
        Me.LblTit0 = New System.Windows.Forms.Label()
        Me.LblRet0 = New System.Windows.Forms.TextBox()
        Me.LnkNuevoCli = New System.Windows.Forms.LinkLabel()
        Me.GrdCli = New SMDPpal.GridDms()
        Me.TxtDestino = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdCancelar = New SMDPpal.BotonEstandar()
        Me.CmdActualizar = New SMDPpal.BotonEstandar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LstDelCli = New System.Windows.Forms.ListBox()
        Me.LblQue = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnlCuentas = New System.Windows.Forms.Panel()
        Me.LblCentro = New System.Windows.Forms.LinkLabel()
        Me.TxtCentro = New System.Windows.Forms.TextBox()
        Me.LnkRefres = New System.Windows.Forms.LinkLabel()
        Me.LnkEditar = New System.Windows.Forms.LinkLabel()
        Me.ChkInactivo = New System.Windows.Forms.CheckBox()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.LblCod = New System.Windows.Forms.Label()
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCuentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicPuntoAdv
        '
        Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicPuntoAdv.Location = New System.Drawing.Point(559, 0)
        '
        'CmdOK
        '
        Me.CmdOK.BackColor = System.Drawing.Color.White
        Me.CmdOK.BackgroundImage = CType(resources.GetObject("CmdOK.BackgroundImage"), System.Drawing.Image)
        Me.CmdOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdOK.ForeColor = System.Drawing.Color.White
        Me.CmdOK.Location = New System.Drawing.Point(480, 19)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(77, 43)
        Me.CmdOK.TabIndex = 7
        Me.CmdOK.Text = "Adicionar cuenta"
        Me.CmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdOK.UseVisualStyleBackColor = False
        '
        'LnkRet0
        '
        Me.LnkRet0.AutoSize = True
        Me.LnkRet0.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LnkRet0.LinkColor = System.Drawing.Color.Black
        Me.LnkRet0.Location = New System.Drawing.Point(67, 21)
        Me.LnkRet0.Name = "LnkRet0"
        Me.LnkRet0.Size = New System.Drawing.Size(85, 13)
        Me.LnkRet0.TabIndex = 101
        Me.LnkRet0.TabStop = True
        Me.LnkRet0.Text = "Cuenta contable"
        '
        'LblTit0
        '
        Me.LblTit0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblTit0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTit0.Location = New System.Drawing.Point(261, 19)
        Me.LblTit0.Name = "LblTit0"
        Me.LblTit0.Size = New System.Drawing.Size(213, 20)
        Me.LblTit0.TabIndex = 3
        Me.LblTit0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblRet0
        '
        Me.LblRet0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRet0.Location = New System.Drawing.Point(153, 19)
        Me.LblRet0.MaxLength = 30
        Me.LblRet0.Name = "LblRet0"
        Me.LblRet0.Size = New System.Drawing.Size(100, 20)
        Me.LblRet0.TabIndex = 2
        '
        'LnkNuevoCli
        '
        Me.LnkNuevoCli.AutoSize = True
        Me.LnkNuevoCli.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkNuevoCli.Location = New System.Drawing.Point(435, 75)
        Me.LnkNuevoCli.Name = "LnkNuevoCli"
        Me.LnkNuevoCli.Size = New System.Drawing.Size(39, 13)
        Me.LnkNuevoCli.TabIndex = 8
        Me.LnkNuevoCli.TabStop = True
        Me.LnkNuevoCli.Text = "Nueva"
        '
        'GrdCli
        '
        Me.GrdCli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCli.DMSCopiarDt = True
        Me.GrdCli.DMSTituloDelInforme = ""
        Me.GrdCli.Location = New System.Drawing.Point(13, 106)
        Me.GrdCli.Name = "GrdCli"
        Me.GrdCli.Size = New System.Drawing.Size(544, 206)
        Me.GrdCli.TabIndex = 9
        '
        'TxtDestino
        '
        Me.TxtDestino.Location = New System.Drawing.Point(161, 38)
        Me.TxtDestino.MaxLength = 300
        Me.TxtDestino.Name = "TxtDestino"
        Me.TxtDestino.Size = New System.Drawing.Size(393, 20)
        Me.TxtDestino.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Descripción"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdCancelar
        '
        Me.CmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCancelar.BackColor = System.Drawing.Color.White
        Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
        Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancelar.ForeColor = System.Drawing.Color.White
        Me.CmdCancelar.Location = New System.Drawing.Point(480, 327)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(75, 31)
        Me.CmdCancelar.TabIndex = 5
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        'CmdActualizar
        '
        Me.CmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdActualizar.BackColor = System.Drawing.Color.White
        Me.CmdActualizar.BackgroundImage = CType(resources.GetObject("CmdActualizar.BackgroundImage"), System.Drawing.Image)
        Me.CmdActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdActualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdActualizar.ForeColor = System.Drawing.Color.White
        Me.CmdActualizar.Location = New System.Drawing.Point(342, 327)
        Me.CmdActualizar.Name = "CmdActualizar"
        Me.CmdActualizar.Size = New System.Drawing.Size(113, 31)
        Me.CmdActualizar.TabIndex = 4
        Me.CmdActualizar.Text = "Actualizar"
        Me.CmdActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdActualizar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(1, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(567, 6)
        Me.Label2.TabIndex = 0
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LstDelCli
        '
        Me.LstDelCli.FormattingEnabled = True
        Me.LstDelCli.Location = New System.Drawing.Point(197, 165)
        Me.LstDelCli.Name = "LstDelCli"
        Me.LstDelCli.Size = New System.Drawing.Size(74, 43)
        Me.LstDelCli.TabIndex = 10
        Me.LstDelCli.Visible = False
        '
        'LblQue
        '
        Me.LblQue.BackColor = System.Drawing.Color.Gainsboro
        Me.LblQue.Location = New System.Drawing.Point(161, 8)
        Me.LblQue.Name = "LblQue"
        Me.LblQue.Size = New System.Drawing.Size(393, 21)
        Me.LblQue.TabIndex = 0
        Me.LblQue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(8, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 152
        Me.PictureBox1.TabStop = False
        '
        'PnlCuentas
        '
        Me.PnlCuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCuentas.Controls.Add(Me.LblCentro)
        Me.PnlCuentas.Controls.Add(Me.TxtCentro)
        Me.PnlCuentas.Controls.Add(Me.LstDelCli)
        Me.PnlCuentas.Controls.Add(Me.LnkRefres)
        Me.PnlCuentas.Controls.Add(Me.LnkRet0)
        Me.PnlCuentas.Controls.Add(Me.GrdCli)
        Me.PnlCuentas.Controls.Add(Me.CmdCancelar)
        Me.PnlCuentas.Controls.Add(Me.CmdActualizar)
        Me.PnlCuentas.Controls.Add(Me.LnkNuevoCli)
        Me.PnlCuentas.Controls.Add(Me.LblRet0)
        Me.PnlCuentas.Controls.Add(Me.LblTit0)
        Me.PnlCuentas.Controls.Add(Me.Label2)
        Me.PnlCuentas.Controls.Add(Me.CmdOK)
        Me.PnlCuentas.Location = New System.Drawing.Point(8, 102)
        Me.PnlCuentas.Name = "PnlCuentas"
        Me.PnlCuentas.Size = New System.Drawing.Size(570, 369)
        Me.PnlCuentas.TabIndex = 6
        '
        'LblCentro
        '
        Me.LblCentro.AutoSize = True
        Me.LblCentro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LblCentro.LinkColor = System.Drawing.Color.Black
        Me.LblCentro.Location = New System.Drawing.Point(67, 45)
        Me.LblCentro.Name = "LblCentro"
        Me.LblCentro.Size = New System.Drawing.Size(67, 13)
        Me.LblCentro.TabIndex = 102
        Me.LblCentro.TabStop = True
        Me.LblCentro.Text = "Centro costo"
        '
        'TxtCentro
        '
        Me.TxtCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCentro.Location = New System.Drawing.Point(153, 42)
        Me.TxtCentro.Name = "TxtCentro"
        Me.TxtCentro.Size = New System.Drawing.Size(321, 20)
        Me.TxtCentro.TabIndex = 5
        '
        'LnkRefres
        '
        Me.LnkRefres.AutoSize = True
        Me.LnkRefres.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkRefres.Location = New System.Drawing.Point(153, 75)
        Me.LnkRefres.Name = "LnkRefres"
        Me.LnkRefres.Size = New System.Drawing.Size(94, 13)
        Me.LnkRefres.TabIndex = 6
        Me.LnkRefres.TabStop = True
        Me.LnkRefres.Text = "Refrescar cuentas"
        '
        'LnkEditar
        '
        Me.LnkEditar.AutoSize = True
        Me.LnkEditar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkEditar.Location = New System.Drawing.Point(18, 65)
        Me.LnkEditar.Name = "LnkEditar"
        Me.LnkEditar.Size = New System.Drawing.Size(34, 13)
        Me.LnkEditar.TabIndex = 104
        Me.LnkEditar.TabStop = True
        Me.LnkEditar.Text = "Editar"
        '
        'ChkInactivo
        '
        Me.ChkInactivo.AutoSize = True
        Me.ChkInactivo.Location = New System.Drawing.Point(380, 64)
        Me.ChkInactivo.Name = "ChkInactivo"
        Me.ChkInactivo.Size = New System.Drawing.Size(102, 17)
        Me.ChkInactivo.TabIndex = 153
        Me.ChkInactivo.Text = "Destino inactivo"
        Me.ChkInactivo.UseVisualStyleBackColor = True
        '
        'TxtCod
        '
        Me.TxtCod.Location = New System.Drawing.Point(161, 62)
        Me.TxtCod.MaxLength = 300
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(199, 20)
        Me.TxtCod.TabIndex = 156
        Me.TxtCod.Visible = False
        '
        'LblCod
        '
        Me.LblCod.AutoSize = True
        Me.LblCod.Location = New System.Drawing.Point(92, 65)
        Me.LblCod.Name = "LblCod"
        Me.LblCod.Size = New System.Drawing.Size(40, 13)
        Me.LblCod.TabIndex = 157
        Me.LblCod.Text = "Código"
        Me.LblCod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblCod.Visible = False
        '
        'fCtaDestinos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CmdCancelar
        Me.ClientSize = New System.Drawing.Size(580, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.LblCod)
        Me.Controls.Add(Me.ChkInactivo)
        Me.Controls.Add(Me.LnkEditar)
        Me.Controls.Add(Me.PnlCuentas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblQue)
        Me.Controls.Add(Me.TxtDestino)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fCtaDestinos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "fCtaDestinos"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtDestino, 0)
        Me.Controls.SetChildIndex(Me.LblQue, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.PnlCuentas, 0)
        Me.Controls.SetChildIndex(Me.LnkEditar, 0)
        Me.Controls.SetChildIndex(Me.ChkInactivo, 0)
        Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
        Me.Controls.SetChildIndex(Me.LblCod, 0)
        Me.Controls.SetChildIndex(Me.TxtCod, 0)
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCuentas.ResumeLayout(False)
        Me.PnlCuentas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents CmdOK As SMDPpal.BotonEstandar
    Friend WithEvents LnkRet0 As System.Windows.Forms.LinkLabel
    Friend WithEvents LblTit0 As System.Windows.Forms.Label
    Friend WithEvents LblRet0 As System.Windows.Forms.TextBox
    Friend WithEvents LnkNuevoCli As System.Windows.Forms.LinkLabel
    Friend WithEvents GrdCli As SMDPpal.GridDms
    Friend WithEvents TxtDestino As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
    Friend WithEvents CmdActualizar As SMDPpal.BotonEstandar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LstDelCli As System.Windows.Forms.ListBox
    Friend WithEvents LblQue As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PnlCuentas As System.Windows.Forms.Panel
    Friend WithEvents LnkEditar As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkRefres As System.Windows.Forms.LinkLabel
    Friend WithEvents LblCentro As System.Windows.Forms.LinkLabel
    Friend WithEvents TxtCentro As System.Windows.Forms.TextBox
    Friend WithEvents ChkInactivo As CheckBox
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents LblCod As System.Windows.Forms.Label
End Class
