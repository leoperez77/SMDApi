<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fEnviarMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fEnviarMail))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDeNombre = New System.Windows.Forms.TextBox()
        Me.TxtCC = New System.Windows.Forms.TextBox()
        Me.TxtCCo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmdEnviar = New SMDPpal.BotonEstandar()
        Me.TxtDeMail = New System.Windows.Forms.TextBox()
        Me.TxtMensaje = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CmdCco = New SMDPpal.BotonEstandar()
        Me.CmdCc = New SMDPpal.BotonEstandar()
        Me.CmdPara = New SMDPpal.BotonEstandar()
        Me.LblErr = New System.Windows.Forms.Label()
        Me.TxtAsunto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtParaMail = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GrpSesion = New System.Windows.Forms.GroupBox()
        Me.ChkRecordar = New System.Windows.Forms.CheckBox()
        Me.ChkSsl = New System.Windows.Forms.CheckBox()
        Me.TxtPuerto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtMiMail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ChkRequiereAutenticacion = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtServer = New System.Windows.Forms.TextBox()
        Me.TxtParaNombre = New System.Windows.Forms.TextBox()
        Me.LnkVer = New System.Windows.Forms.LinkLabel()
        Me.LnkChat = New System.Windows.Forms.LinkLabel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GrpSesion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "De:"
        '
        'TxtDeNombre
        '
        Me.TxtDeNombre.Location = New System.Drawing.Point(93, 12)
        Me.TxtDeNombre.Name = "TxtDeNombre"
        Me.TxtDeNombre.Size = New System.Drawing.Size(157, 20)
        Me.TxtDeNombre.TabIndex = 6
        '
        'TxtCC
        '
        Me.TxtCC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCC.Location = New System.Drawing.Point(93, 66)
        Me.TxtCC.Name = "TxtCC"
        Me.TxtCC.Size = New System.Drawing.Size(327, 20)
        Me.TxtCC.TabIndex = 1
        '
        'TxtCCo
        '
        Me.TxtCCo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCCo.Location = New System.Drawing.Point(93, 92)
        Me.TxtCCo.Name = "TxtCCo"
        Me.TxtCCo.Size = New System.Drawing.Size(327, 20)
        Me.TxtCCo.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Mensaje:"
        '
        'CmdEnviar
        '
        Me.CmdEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdEnviar.BackColor = System.Drawing.Color.White
        Me.CmdEnviar.BackgroundImage = CType(resources.GetObject("CmdEnviar.BackgroundImage"), System.Drawing.Image)
        Me.CmdEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdEnviar.ForeColor = System.Drawing.Color.White
        Me.CmdEnviar.Location = New System.Drawing.Point(327, 434)
        Me.CmdEnviar.Name = "CmdEnviar"
        Me.CmdEnviar.Size = New System.Drawing.Size(108, 32)
        Me.CmdEnviar.TabIndex = 2
        Me.CmdEnviar.Text = "Enviar"
        Me.CmdEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdEnviar.UseVisualStyleBackColor = True
        '
        'TxtDeMail
        '
        Me.TxtDeMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDeMail.Location = New System.Drawing.Point(256, 12)
        Me.TxtDeMail.Name = "TxtDeMail"
        Me.TxtDeMail.Size = New System.Drawing.Size(164, 20)
        Me.TxtDeMail.TabIndex = 7
        '
        'TxtMensaje
        '
        Me.TxtMensaje.AcceptsReturn = True
        Me.TxtMensaje.AcceptsTab = True
        Me.TxtMensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMensaje.Location = New System.Drawing.Point(93, 146)
        Me.TxtMensaje.Multiline = True
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMensaje.Size = New System.Drawing.Size(327, 243)
        Me.TxtMensaje.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(434, 424)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CmdCco)
        Me.TabPage1.Controls.Add(Me.CmdCc)
        Me.TabPage1.Controls.Add(Me.CmdPara)
        Me.TabPage1.Controls.Add(Me.LblErr)
        Me.TabPage1.Controls.Add(Me.TxtAsunto)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TxtParaMail)
        Me.TabPage1.Controls.Add(Me.TxtMensaje)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtDeNombre)
        Me.TabPage1.Controls.Add(Me.TxtDeMail)
        Me.TabPage1.Controls.Add(Me.TxtCC)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TxtCCo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(426, 398)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Principal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CmdCco
        '
        Me.CmdCco.BackColor = System.Drawing.Color.White
        Me.CmdCco.BackgroundImage = CType(resources.GetObject("CmdCco.BackgroundImage"), System.Drawing.Image)
        Me.CmdCco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdCco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCco.ForeColor = System.Drawing.Color.White
        Me.CmdCco.Location = New System.Drawing.Point(14, 91)
        Me.CmdCco.Name = "CmdCco"
        Me.CmdCco.Size = New System.Drawing.Size(70, 23)
        Me.CmdCco.TabIndex = 15
        Me.CmdCco.Text = "Cco..."
        Me.CmdCco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCco.UseVisualStyleBackColor = True
        '
        'CmdCc
        '
        Me.CmdCc.BackColor = System.Drawing.Color.White
        Me.CmdCc.BackgroundImage = CType(resources.GetObject("CmdCc.BackgroundImage"), System.Drawing.Image)
        Me.CmdCc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdCc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCc.ForeColor = System.Drawing.Color.White
        Me.CmdCc.Location = New System.Drawing.Point(14, 64)
        Me.CmdCc.Name = "CmdCc"
        Me.CmdCc.Size = New System.Drawing.Size(70, 23)
        Me.CmdCc.TabIndex = 14
        Me.CmdCc.Text = "Cc..."
        Me.CmdCc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCc.UseVisualStyleBackColor = True
        '
        'CmdPara
        '
        Me.CmdPara.BackColor = System.Drawing.Color.White
        Me.CmdPara.BackgroundImage = CType(resources.GetObject("CmdPara.BackgroundImage"), System.Drawing.Image)
        Me.CmdPara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdPara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPara.ForeColor = System.Drawing.Color.White
        Me.CmdPara.Location = New System.Drawing.Point(14, 39)
        Me.CmdPara.Name = "CmdPara"
        Me.CmdPara.Size = New System.Drawing.Size(70, 23)
        Me.CmdPara.TabIndex = 4
        Me.CmdPara.Text = "Para..."
        Me.CmdPara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdPara.UseVisualStyleBackColor = True
        '
        'LblErr
        '
        Me.LblErr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblErr.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblErr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblErr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblErr.ForeColor = System.Drawing.Color.Black
        Me.LblErr.Location = New System.Drawing.Point(199, 236)
        Me.LblErr.Name = "LblErr"
        Me.LblErr.Size = New System.Drawing.Size(67, 45)
        Me.LblErr.TabIndex = 13
        Me.LblErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblErr.Visible = False
        '
        'TxtAsunto
        '
        Me.TxtAsunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAsunto.Location = New System.Drawing.Point(93, 119)
        Me.TxtAsunto.Name = "TxtAsunto"
        Me.TxtAsunto.Size = New System.Drawing.Size(327, 20)
        Me.TxtAsunto.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Asunto:"
        '
        'TxtParaMail
        '
        Me.TxtParaMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtParaMail.Location = New System.Drawing.Point(93, 39)
        Me.TxtParaMail.Name = "TxtParaMail"
        Me.TxtParaMail.Size = New System.Drawing.Size(327, 20)
        Me.TxtParaMail.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GrpSesion)
        Me.TabPage2.Controls.Add(Me.ChkRequiereAutenticacion)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.TxtServer)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(426, 398)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Opciones de Envío"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GrpSesion
        '
        Me.GrpSesion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrpSesion.Controls.Add(Me.ChkRecordar)
        Me.GrpSesion.Controls.Add(Me.ChkSsl)
        Me.GrpSesion.Controls.Add(Me.TxtPuerto)
        Me.GrpSesion.Controls.Add(Me.Label11)
        Me.GrpSesion.Controls.Add(Me.TxtClave)
        Me.GrpSesion.Controls.Add(Me.Label10)
        Me.GrpSesion.Controls.Add(Me.TxtMiMail)
        Me.GrpSesion.Controls.Add(Me.Label9)
        Me.GrpSesion.Enabled = False
        Me.GrpSesion.Location = New System.Drawing.Point(45, 140)
        Me.GrpSesion.Name = "GrpSesion"
        Me.GrpSesion.Size = New System.Drawing.Size(359, 172)
        Me.GrpSesion.TabIndex = 15
        Me.GrpSesion.TabStop = False
        Me.GrpSesion.Text = "Iniciar Sesión Usando"
        '
        'ChkRecordar
        '
        Me.ChkRecordar.AutoSize = True
        Me.ChkRecordar.Checked = True
        Me.ChkRecordar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkRecordar.Location = New System.Drawing.Point(282, 65)
        Me.ChkRecordar.Name = "ChkRecordar"
        Me.ChkRecordar.Size = New System.Drawing.Size(70, 17)
        Me.ChkRecordar.TabIndex = 19
        Me.ChkRecordar.Text = "Recordar"
        Me.ChkRecordar.UseVisualStyleBackColor = True
        '
        'ChkSsl
        '
        Me.ChkSsl.AutoSize = True
        Me.ChkSsl.Location = New System.Drawing.Point(99, 139)
        Me.ChkSsl.Name = "ChkSsl"
        Me.ChkSsl.Size = New System.Drawing.Size(176, 17)
        Me.ChkSsl.TabIndex = 18
        Me.ChkSsl.Text = "Usar Autenticación Segura (Ssl)"
        Me.ChkSsl.UseVisualStyleBackColor = True
        '
        'TxtPuerto
        '
        Me.TxtPuerto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPuerto.Location = New System.Drawing.Point(123, 88)
        Me.TxtPuerto.Name = "TxtPuerto"
        Me.TxtPuerto.Size = New System.Drawing.Size(80, 20)
        Me.TxtPuerto.TabIndex = 17
        Me.TxtPuerto.Text = "587"
        Me.TxtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Puerto"
        '
        'TxtClave
        '
        Me.TxtClave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtClave.Location = New System.Drawing.Point(123, 62)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(154, 20)
        Me.TxtClave.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Contraseña"
        '
        'TxtMiMail
        '
        Me.TxtMiMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMiMail.Location = New System.Drawing.Point(123, 36)
        Me.TxtMiMail.Name = "TxtMiMail"
        Me.TxtMiMail.Size = New System.Drawing.Size(230, 20)
        Me.TxtMiMail.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Nombre de Cuenta"
        '
        'ChkRequiereAutenticacion
        '
        Me.ChkRequiereAutenticacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkRequiereAutenticacion.AutoSize = True
        Me.ChkRequiereAutenticacion.Location = New System.Drawing.Point(144, 90)
        Me.ChkRequiereAutenticacion.Name = "ChkRequiereAutenticacion"
        Me.ChkRequiereAutenticacion.Size = New System.Drawing.Size(193, 17)
        Me.ChkRequiereAutenticacion.TabIndex = 14
        Me.ChkRequiereAutenticacion.Text = "Mi Servidor Requiere Autenticación"
        Me.ChkRequiereAutenticacion.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Servidor Salida SMTP"
        '
        'TxtServer
        '
        Me.TxtServer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtServer.Location = New System.Drawing.Point(144, 31)
        Me.TxtServer.Name = "TxtServer"
        Me.TxtServer.Size = New System.Drawing.Size(260, 20)
        Me.TxtServer.TabIndex = 11
        '
        'TxtParaNombre
        '
        Me.TxtParaNombre.Enabled = False
        Me.TxtParaNombre.Location = New System.Drawing.Point(135, 441)
        Me.TxtParaNombre.Name = "TxtParaNombre"
        Me.TxtParaNombre.Size = New System.Drawing.Size(70, 20)
        Me.TxtParaNombre.TabIndex = 1
        Me.TxtParaNombre.Visible = False
        '
        'LnkVer
        '
        Me.LnkVer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LnkVer.AutoSize = True
        Me.LnkVer.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkVer.Location = New System.Drawing.Point(28, 444)
        Me.LnkVer.Name = "LnkVer"
        Me.LnkVer.Size = New System.Drawing.Size(101, 13)
        Me.LnkVer.TabIndex = 0
        Me.LnkVer.TabStop = True
        Me.LnkVer.Text = "Ver Archivo Adjunto"
        '
        'LnkChat
        '
        Me.LnkChat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LnkChat.AutoSize = True
        Me.LnkChat.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkChat.Location = New System.Drawing.Point(241, 444)
        Me.LnkChat.Name = "LnkChat"
        Me.LnkChat.Size = New System.Drawing.Size(80, 13)
        Me.LnkChat.TabIndex = 4
        Me.LnkChat.TabStop = True
        Me.LnkChat.Text = "Enviar por Chat"
        '
        'fEnviarMail
        '
        Me.AcceptButton = Me.CmdEnviar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(441, 474)
        Me.Controls.Add(Me.LnkChat)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TxtParaNombre)
        Me.Controls.Add(Me.CmdEnviar)
        Me.Controls.Add(Me.LnkVer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fEnviarMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar Correo"
        Me.Controls.SetChildIndex(Me.LnkVer, 0)
        Me.Controls.SetChildIndex(Me.CmdEnviar, 0)
        Me.Controls.SetChildIndex(Me.TxtParaNombre, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.LnkChat, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GrpSesion.ResumeLayout(False)
        Me.GrpSesion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDeNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtCC As System.Windows.Forms.TextBox
    Friend WithEvents TxtCCo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtDeMail As System.Windows.Forms.TextBox
    Friend WithEvents TxtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtMiMail As System.Windows.Forms.TextBox
    Friend WithEvents ChkRequiereAutenticacion As System.Windows.Forms.CheckBox
    Friend WithEvents GrpSesion As System.Windows.Forms.GroupBox
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtPuerto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ChkSsl As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRecordar As System.Windows.Forms.CheckBox
    Friend WithEvents LblErr As System.Windows.Forms.Label
    Friend WithEvents TxtParaNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents LnkVer As System.Windows.Forms.LinkLabel
    Friend WithEvents TxtParaMail As System.Windows.Forms.TextBox
    Friend WithEvents LnkChat As System.Windows.Forms.LinkLabel
    Friend WithEvents CmdEnviar As SMDPpal.BotonEstandar
    Friend WithEvents CmdCco As SMDPpal.BotonEstandar
    Friend WithEvents CmdCc As SMDPpal.BotonEstandar
    Friend WithEvents CmdPara As SMDPpal.BotonEstandar
End Class
