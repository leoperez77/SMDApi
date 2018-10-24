<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fFind
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fFind))
		Me.HacerConsulta = New System.ComponentModel.BackgroundWorker()
		Me.LblAviso = New System.Windows.Forms.Label()
		Me.CmdCancel = New SMDPpal.BotonEstandar()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.CmdImprimir = New System.Windows.Forms.ToolStripButton()
		Me.CmdChat = New System.Windows.Forms.ToolStripButton()
		Me.CmdMail = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
		Me.CmdRefrescar = New System.Windows.Forms.ToolStripMenuItem()
		Me.LblProcedure = New System.Windows.Forms.ToolStripMenuItem()
		Me.LblTiempo = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CopiarPlano = New System.Windows.Forms.ToolStripMenuItem()
		Me.LblQueConsulta = New System.Windows.Forms.ToolStripLabel()
		Me.QueConsulta = New System.Windows.Forms.ToolStripDropDownButton()
		Me.CmdConsulta_1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_3 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_4 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_5 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_6 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_7 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_8 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_9 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_10 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_11 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_12 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_13 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_14 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdConsulta_15 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdVerTodas = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdRegresar = New System.Windows.Forms.ToolStripButton()
		Me.CmdAceptar = New System.Windows.Forms.ToolStripButton()
		Me.Pnl100 = New System.Windows.Forms.Panel()
		Me.LblGrande = New System.Windows.Forms.Label()
		Me.LblNormal = New System.Windows.Forms.Label()
		Me.LblPeq = New System.Windows.Forms.Label()
		Me.LblAzul = New System.Windows.Forms.Label()
		Me.LblNegro = New System.Windows.Forms.Label()
		Me.LnkCerrar = New System.Windows.Forms.LinkLabel()
		Me.Lbl100 = New System.Windows.Forms.Label()
		Me.PicLogo = New System.Windows.Forms.PictureBox()
		Me.GridDms1 = New SMDPpal.GridDms()
		Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ToolStrip1.SuspendLayout()
		Me.Pnl100.SuspendLayout()
		CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(663, 0)
		'
		'HacerConsulta
		'
		Me.HacerConsulta.WorkerSupportsCancellation = True
		'
		'LblAviso
		'
		Me.LblAviso.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.LblAviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAviso.Location = New System.Drawing.Point(205, 145)
		Me.LblAviso.Name = "LblAviso"
		Me.LblAviso.Size = New System.Drawing.Size(271, 145)
		Me.LblAviso.TabIndex = 1
		Me.LblAviso.Text = "La consulta está siendo realizada en segundo plano.  Puede hacer otras actividade" &
	"s mientras este proceso termina"
		Me.LblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.LblAviso.Visible = False
		'
		'CmdCancel
		'
		Me.CmdCancel.BackColor = System.Drawing.Color.White
		Me.CmdCancel.BackgroundImage = CType(resources.GetObject("CmdCancel.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancel.ForeColor = System.Drawing.Color.White
		Me.CmdCancel.Location = New System.Drawing.Point(190, 55)
		Me.CmdCancel.Name = "CmdCancel"
		Me.CmdCancel.Size = New System.Drawing.Size(75, 23)
		Me.CmdCancel.TabIndex = 4
		Me.CmdCancel.Text = "Cancelar"
		Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancel.UseVisualStyleBackColor = True
		'
		'ToolStrip1
		'
		Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdImprimir, Me.CmdChat, Me.CmdMail, Me.ToolStripDropDownButton1, Me.LblQueConsulta, Me.QueConsulta, Me.CmdRegresar, Me.CmdAceptar})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(684, 25)
		Me.ToolStrip1.TabIndex = 3
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'CmdImprimir
		'
		Me.CmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.CmdImprimir.ForeColor = System.Drawing.Color.Blue
		Me.CmdImprimir.Image = CType(resources.GetObject("CmdImprimir.Image"), System.Drawing.Image)
		Me.CmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CmdImprimir.Name = "CmdImprimir"
		Me.CmdImprimir.Size = New System.Drawing.Size(23, 22)
		Me.CmdImprimir.Text = "Imprimir"
		Me.CmdImprimir.ToolTipText = "Imprimir exportando a Excel"
		'
		'CmdChat
		'
		Me.CmdChat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.CmdChat.Image = CType(resources.GetObject("CmdChat.Image"), System.Drawing.Image)
		Me.CmdChat.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CmdChat.Name = "CmdChat"
		Me.CmdChat.Size = New System.Drawing.Size(23, 22)
		Me.CmdChat.Text = "ToolStripButton2"
		Me.CmdChat.ToolTipText = "Enviar por chat"
		'
		'CmdMail
		'
		Me.CmdMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.CmdMail.Image = CType(resources.GetObject("CmdMail.Image"), System.Drawing.Image)
		Me.CmdMail.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CmdMail.Name = "CmdMail"
		Me.CmdMail.Size = New System.Drawing.Size(23, 22)
		Me.CmdMail.Text = "ToolStripButton1"
		Me.CmdMail.ToolTipText = "Enviar por email"
		'
		'ToolStripDropDownButton1
		'
		Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdRefrescar, Me.LblProcedure, Me.LblTiempo, Me.ImprimirToolStripMenuItem, Me.CopiarPlano})
		Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.Black
		Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
		Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
		Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(42, 22)
		Me.ToolStripDropDownButton1.Text = "Más"
		'
		'CmdRefrescar
		'
		Me.CmdRefrescar.ForeColor = System.Drawing.Color.Green
		Me.CmdRefrescar.Name = "CmdRefrescar"
		Me.CmdRefrescar.Size = New System.Drawing.Size(159, 22)
		Me.CmdRefrescar.Text = "Refrescar"
		'
		'LblProcedure
		'
		Me.LblProcedure.Name = "LblProcedure"
		Me.LblProcedure.Size = New System.Drawing.Size(159, 22)
		Me.LblProcedure.Text = "Sql"
		'
		'LblTiempo
		'
		Me.LblTiempo.Enabled = False
		Me.LblTiempo.Name = "LblTiempo"
		Me.LblTiempo.Size = New System.Drawing.Size(159, 22)
		Me.LblTiempo.Text = "Tempo"
		'
		'ImprimirToolStripMenuItem
		'
		Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
		Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
		Me.ImprimirToolStripMenuItem.Text = "Imprimir"
		Me.ImprimirToolStripMenuItem.Visible = False
		'
		'CopiarPlano
		'
		Me.CopiarPlano.Name = "CopiarPlano"
		Me.CopiarPlano.Size = New System.Drawing.Size(159, 22)
		Me.CopiarPlano.Text = "Exportar a Plano"
		'
		'LblQueConsulta
		'
		Me.LblQueConsulta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.LblQueConsulta.Name = "LblQueConsulta"
		Me.LblQueConsulta.Size = New System.Drawing.Size(118, 22)
		Me.LblQueConsulta.Text = "Mostrando Consulta:"
		Me.LblQueConsulta.Visible = False
		'
		'QueConsulta
		'
		Me.QueConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.QueConsulta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdConsulta_1, Me.CmdConsulta_2, Me.CmdConsulta_3, Me.CmdConsulta_4, Me.CmdConsulta_5, Me.CmdConsulta_6, Me.CmdConsulta_7, Me.CmdConsulta_8, Me.CmdConsulta_9, Me.CmdConsulta_10, Me.CmdConsulta_11, Me.CmdConsulta_12, Me.CmdConsulta_13, Me.CmdConsulta_14, Me.CmdConsulta_15, Me.CmdVerTodas})
		Me.QueConsulta.ForeColor = System.Drawing.Color.Blue
		Me.QueConsulta.Image = CType(resources.GetObject("QueConsulta.Image"), System.Drawing.Image)
		Me.QueConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.QueConsulta.Name = "QueConsulta"
		Me.QueConsulta.Size = New System.Drawing.Size(123, 22)
		Me.QueConsulta.Text = "Consulta que desea"
		Me.QueConsulta.Visible = False
		'
		'CmdConsulta_1
		'
		Me.CmdConsulta_1.Name = "CmdConsulta_1"
		Me.CmdConsulta_1.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_1.Tag = "0"
		Me.CmdConsulta_1.Text = "Consulta 1"
		Me.CmdConsulta_1.Visible = False
		'
		'CmdConsulta_2
		'
		Me.CmdConsulta_2.Name = "CmdConsulta_2"
		Me.CmdConsulta_2.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_2.Tag = "1"
		Me.CmdConsulta_2.Text = "Consulta 2"
		Me.CmdConsulta_2.Visible = False
		'
		'CmdConsulta_3
		'
		Me.CmdConsulta_3.Name = "CmdConsulta_3"
		Me.CmdConsulta_3.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_3.Tag = "2"
		Me.CmdConsulta_3.Text = "Consulta 3"
		Me.CmdConsulta_3.Visible = False
		'
		'CmdConsulta_4
		'
		Me.CmdConsulta_4.Name = "CmdConsulta_4"
		Me.CmdConsulta_4.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_4.Tag = "3"
		Me.CmdConsulta_4.Text = "Consulta 4"
		Me.CmdConsulta_4.Visible = False
		'
		'CmdConsulta_5
		'
		Me.CmdConsulta_5.Name = "CmdConsulta_5"
		Me.CmdConsulta_5.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_5.Tag = "4"
		Me.CmdConsulta_5.Text = "Consulta 5"
		Me.CmdConsulta_5.Visible = False
		'
		'CmdConsulta_6
		'
		Me.CmdConsulta_6.Name = "CmdConsulta_6"
		Me.CmdConsulta_6.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_6.Tag = "5"
		Me.CmdConsulta_6.Text = "Consulta 6"
		Me.CmdConsulta_6.Visible = False
		'
		'CmdConsulta_7
		'
		Me.CmdConsulta_7.Name = "CmdConsulta_7"
		Me.CmdConsulta_7.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_7.Tag = "6"
		Me.CmdConsulta_7.Text = "Consulta 7"
		Me.CmdConsulta_7.Visible = False
		'
		'CmdConsulta_8
		'
		Me.CmdConsulta_8.Name = "CmdConsulta_8"
		Me.CmdConsulta_8.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_8.Tag = "7"
		Me.CmdConsulta_8.Text = "Consulta 8"
		Me.CmdConsulta_8.Visible = False
		'
		'CmdConsulta_9
		'
		Me.CmdConsulta_9.Name = "CmdConsulta_9"
		Me.CmdConsulta_9.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_9.Tag = "8"
		Me.CmdConsulta_9.Text = "Consulta 9"
		Me.CmdConsulta_9.Visible = False
		'
		'CmdConsulta_10
		'
		Me.CmdConsulta_10.Name = "CmdConsulta_10"
		Me.CmdConsulta_10.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_10.Tag = "9"
		Me.CmdConsulta_10.Text = "Consulta 10"
		Me.CmdConsulta_10.Visible = False
		'
		'CmdConsulta_11
		'
		Me.CmdConsulta_11.Name = "CmdConsulta_11"
		Me.CmdConsulta_11.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_11.Tag = "10"
		Me.CmdConsulta_11.Text = "Consulta 11"
		Me.CmdConsulta_11.Visible = False
		'
		'CmdConsulta_12
		'
		Me.CmdConsulta_12.Name = "CmdConsulta_12"
		Me.CmdConsulta_12.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_12.Tag = "11"
		Me.CmdConsulta_12.Text = "Consulta 12"
		Me.CmdConsulta_12.Visible = False
		'
		'CmdConsulta_13
		'
		Me.CmdConsulta_13.Name = "CmdConsulta_13"
		Me.CmdConsulta_13.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_13.Tag = "12"
		Me.CmdConsulta_13.Text = "Consulta 13"
		Me.CmdConsulta_13.Visible = False
		'
		'CmdConsulta_14
		'
		Me.CmdConsulta_14.Name = "CmdConsulta_14"
		Me.CmdConsulta_14.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_14.Tag = "13"
		Me.CmdConsulta_14.Text = "Consulta 14"
		Me.CmdConsulta_14.Visible = False
		'
		'CmdConsulta_15
		'
		Me.CmdConsulta_15.Name = "CmdConsulta_15"
		Me.CmdConsulta_15.Size = New System.Drawing.Size(163, 22)
		Me.CmdConsulta_15.Tag = "14"
		Me.CmdConsulta_15.Text = "Consulta 15"
		Me.CmdConsulta_15.Visible = False
		'
		'CmdVerTodas
		'
		Me.CmdVerTodas.ForeColor = System.Drawing.Color.Blue
		Me.CmdVerTodas.Name = "CmdVerTodas"
		Me.CmdVerTodas.Size = New System.Drawing.Size(163, 22)
		Me.CmdVerTodas.Text = "Ver todas en MDI"
		'
		'CmdRegresar
		'
		Me.CmdRegresar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.CmdRegresar.Image = CType(resources.GetObject("CmdRegresar.Image"), System.Drawing.Image)
		Me.CmdRegresar.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CmdRegresar.Name = "CmdRegresar"
		Me.CmdRegresar.Size = New System.Drawing.Size(57, 22)
		Me.CmdRegresar.Text = "Cancelar"
		Me.CmdRegresar.Visible = False
		'
		'CmdAceptar
		'
		Me.CmdAceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.CmdAceptar.ForeColor = System.Drawing.Color.Red
		Me.CmdAceptar.Image = CType(resources.GetObject("CmdAceptar.Image"), System.Drawing.Image)
		Me.CmdAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(148, 22)
		Me.CmdAceptar.Text = "Regresar múltiples valores"
		Me.CmdAceptar.Visible = False
		'
		'Pnl100
		'
		Me.Pnl100.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Pnl100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Pnl100.Controls.Add(Me.LblGrande)
		Me.Pnl100.Controls.Add(Me.LblNormal)
		Me.Pnl100.Controls.Add(Me.LblPeq)
		Me.Pnl100.Controls.Add(Me.LblAzul)
		Me.Pnl100.Controls.Add(Me.LblNegro)
		Me.Pnl100.Controls.Add(Me.LnkCerrar)
		Me.Pnl100.Controls.Add(Me.Lbl100)
		Me.Pnl100.Location = New System.Drawing.Point(176, 169)
		Me.Pnl100.Name = "Pnl100"
		Me.Pnl100.Size = New System.Drawing.Size(339, 228)
		Me.Pnl100.TabIndex = 2
		Me.Pnl100.Visible = False
		'
		'LblGrande
		'
		Me.LblGrande.AutoSize = True
		Me.LblGrande.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblGrande.Location = New System.Drawing.Point(151, 146)
		Me.LblGrande.Name = "LblGrande"
		Me.LblGrande.Size = New System.Drawing.Size(84, 20)
		Me.LblGrande.TabIndex = 3
		Me.LblGrande.Text = "LblGrande"
		Me.LblGrande.Visible = False
		'
		'LblNormal
		'
		Me.LblNormal.AutoSize = True
		Me.LblNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblNormal.Location = New System.Drawing.Point(151, 121)
		Me.LblNormal.Name = "LblNormal"
		Me.LblNormal.Size = New System.Drawing.Size(54, 13)
		Me.LblNormal.TabIndex = 2
		Me.LblNormal.Text = "LblNormal"
		Me.LblNormal.Visible = False
		'
		'LblPeq
		'
		Me.LblPeq.AutoSize = True
		Me.LblPeq.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblPeq.Location = New System.Drawing.Point(147, 108)
		Me.LblPeq.Name = "LblPeq"
		Me.LblPeq.Size = New System.Drawing.Size(27, 7)
		Me.LblPeq.TabIndex = 1
		Me.LblPeq.Text = "LblPeq"
		Me.LblPeq.Visible = False
		'
		'LblAzul
		'
		Me.LblAzul.AutoSize = True
		Me.LblAzul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAzul.ForeColor = System.Drawing.Color.Blue
		Me.LblAzul.Location = New System.Drawing.Point(112, 212)
		Me.LblAzul.Name = "LblAzul"
		Me.LblAzul.Size = New System.Drawing.Size(45, 13)
		Me.LblAzul.TabIndex = 5
		Me.LblAzul.Text = "Label1"
		Me.LblAzul.Visible = False
		'
		'LblNegro
		'
		Me.LblNegro.AutoSize = True
		Me.LblNegro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblNegro.Location = New System.Drawing.Point(30, 212)
		Me.LblNegro.Name = "LblNegro"
		Me.LblNegro.Size = New System.Drawing.Size(45, 13)
		Me.LblNegro.TabIndex = 6
		Me.LblNegro.Text = "Label1"
		Me.LblNegro.Visible = False
		'
		'LnkCerrar
		'
		Me.LnkCerrar.AutoSize = True
		Me.LnkCerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkCerrar.Location = New System.Drawing.Point(286, 203)
		Me.LnkCerrar.Name = "LnkCerrar"
		Me.LnkCerrar.Size = New System.Drawing.Size(41, 13)
		Me.LnkCerrar.TabIndex = 4
		Me.LnkCerrar.TabStop = True
		Me.LnkCerrar.Text = "Ocultar"
		'
		'Lbl100
		'
		Me.Lbl100.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Lbl100.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lbl100.ForeColor = System.Drawing.Color.Gray
		Me.Lbl100.Location = New System.Drawing.Point(7, 13)
		Me.Lbl100.Name = "Lbl100"
		Me.Lbl100.Size = New System.Drawing.Size(325, 177)
		Me.Lbl100.TabIndex = 0
		Me.Lbl100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'PicLogo
		'
		Me.PicLogo.BackColor = System.Drawing.Color.White
		Me.PicLogo.Location = New System.Drawing.Point(427, 74)
		Me.PicLogo.Name = "PicLogo"
		Me.PicLogo.Size = New System.Drawing.Size(192, 140)
		Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PicLogo.TabIndex = 42
		Me.PicLogo.TabStop = False
		Me.PicLogo.Visible = False
		'
		'GridDms1
		'
		Me.GridDms1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GridDms1.AutoSize = True
		Me.GridDms1.DMSCopiarDt = True
		Me.GridDms1.DMSTituloDelInforme = ""
		Me.GridDms1.Location = New System.Drawing.Point(0, 25)
		Me.GridDms1.Name = "GridDms1"
		Me.GridDms1.Size = New System.Drawing.Size(684, 437)
		Me.GridDms1.TabIndex = 0
		'
		'fFind
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.CancelButton = Me.CmdCancel
		Me.ClientSize = New System.Drawing.Size(684, 464)
		Me.Controls.Add(Me.LblAviso)
		Me.Controls.Add(Me.Pnl100)
		Me.Controls.Add(Me.PicLogo)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.CmdCancel)
		Me.Controls.Add(Me.GridDms1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MinimizeBox = False
		Me.Name = "fFind"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Resultados"
		Me.Controls.SetChildIndex(Me.GridDms1, 0)
		Me.Controls.SetChildIndex(Me.CmdCancel, 0)
		Me.Controls.SetChildIndex(Me.ToolStrip1, 0)
		Me.Controls.SetChildIndex(Me.PicLogo, 0)
		Me.Controls.SetChildIndex(Me.Pnl100, 0)
		Me.Controls.SetChildIndex(Me.LblAviso, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.Pnl100.ResumeLayout(False)
		Me.Pnl100.PerformLayout()
		CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents HacerConsulta As System.ComponentModel.BackgroundWorker
    Friend WithEvents LblAviso As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Pnl100 As System.Windows.Forms.Panel
    Friend WithEvents LnkCerrar As System.Windows.Forms.LinkLabel
    Friend WithEvents Lbl100 As System.Windows.Forms.Label
    Friend WithEvents LblNegro As System.Windows.Forms.Label
    Friend WithEvents LblAzul As System.Windows.Forms.Label
    Friend WithEvents LblPeq As System.Windows.Forms.Label
    Friend WithEvents LblGrande As System.Windows.Forms.Label
    Friend WithEvents LblNormal As System.Windows.Forms.Label
    Friend WithEvents GridDms1 As GridDms
    Friend WithEvents QueConsulta As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CmdConsulta_1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsulta_2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsulta_3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsulta_4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsulta_5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsulta_6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblQueConsulta As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CmdRegresar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmdConsulta_7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsulta_8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
    Friend WithEvents CmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmdChat As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmdMail As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CmdRefrescar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblProcedure As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblTiempo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdCancel As SMDPpal.BotonEstandar
    Friend WithEvents CmdConsulta_9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsulta_10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsulta_11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsulta_12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsulta_13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsulta_14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsulta_15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmdVerTodas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarPlano As System.Windows.Forms.ToolStripMenuItem
End Class
