<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fAutorizacionElectronica
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fAutorizacionElectronica))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.TxtClave = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ChkVerTodos = New System.Windows.Forms.CheckBox()
		Me.TxtAdi = New System.Windows.Forms.TextBox()
		Me.CmdEnviar = New SMDPpal.BotonEstandar()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LstUsu = New System.Windows.Forms.ListBox()
		Me.LblSolicitud = New System.Windows.Forms.Label()
		Me.CmdCancelar = New SMDPpal.BotonEstandar()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.LblSeg = New System.Windows.Forms.Label()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(420, 0)
		'
		'Panel1
		'
		Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel1.Controls.Add(Me.TxtClave)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.ChkVerTodos)
		Me.Panel1.Controls.Add(Me.TxtAdi)
		Me.Panel1.Controls.Add(Me.CmdEnviar)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.LstUsu)
		Me.Panel1.Location = New System.Drawing.Point(12, 12)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(424, 259)
		Me.Panel1.TabIndex = 0
		'
		'TxtClave
		'
		Me.TxtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtClave.Location = New System.Drawing.Point(284, 131)
		Me.TxtClave.Name = "TxtClave"
		Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TxtClave.Size = New System.Drawing.Size(133, 20)
		Me.TxtClave.TabIndex = 0
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(281, 115)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(34, 13)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Clave"
		'
		'Label2
		'
		Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(283, 7)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(136, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Texto explicativo (opcional)"
		'
		'ChkVerTodos
		'
		Me.ChkVerTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ChkVerTodos.AutoSize = True
		Me.ChkVerTodos.Location = New System.Drawing.Point(296, 229)
		Me.ChkVerTodos.Name = "ChkVerTodos"
		Me.ChkVerTodos.Size = New System.Drawing.Size(114, 17)
		Me.ChkVerTodos.TabIndex = 4
		Me.ChkVerTodos.Text = "Todos los usuarios"
		Me.ChkVerTodos.UseVisualStyleBackColor = True
		'
		'TxtAdi
		'
		Me.TxtAdi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtAdi.Location = New System.Drawing.Point(283, 23)
		Me.TxtAdi.MaxLength = 200
		Me.TxtAdi.Multiline = True
		Me.TxtAdi.Name = "TxtAdi"
		Me.TxtAdi.Size = New System.Drawing.Size(134, 83)
		Me.TxtAdi.TabIndex = 3
		'
		'CmdEnviar
		'
		Me.CmdEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdEnviar.BackColor = System.Drawing.Color.White
		Me.CmdEnviar.BackgroundImage = CType(resources.GetObject("CmdEnviar.BackgroundImage"), System.Drawing.Image)
		Me.CmdEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdEnviar.ForeColor = System.Drawing.Color.White
		Me.CmdEnviar.Location = New System.Drawing.Point(286, 164)
		Me.CmdEnviar.Name = "CmdEnviar"
		Me.CmdEnviar.Size = New System.Drawing.Size(131, 55)
		Me.CmdEnviar.TabIndex = 8
		Me.CmdEnviar.Tag = "Enviar Solicitud de Autorización"
		Me.CmdEnviar.Text = "Enviar Solicitud de Autorización"
		Me.CmdEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdEnviar.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(88, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Solicitar a quién?"
		'
		'LstUsu
		'
		Me.LstUsu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LstUsu.FormattingEnabled = True
		Me.LstUsu.Location = New System.Drawing.Point(5, 25)
		Me.LstUsu.Name = "LstUsu"
		Me.LstUsu.Size = New System.Drawing.Size(265, 225)
		Me.LstUsu.TabIndex = 0
		'
		'LblSolicitud
		'
		Me.LblSolicitud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblSolicitud.ForeColor = System.Drawing.Color.Red
		Me.LblSolicitud.Location = New System.Drawing.Point(3, 274)
		Me.LblSolicitud.Name = "LblSolicitud"
		Me.LblSolicitud.Size = New System.Drawing.Size(221, 32)
		Me.LblSolicitud.TabIndex = 3
		Me.LblSolicitud.Tag = "Solicitud Enviada... Esperando aprobación"
		Me.LblSolicitud.Text = "Solicitud Enviada... Esperando aprobación"
		Me.LblSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.LblSolicitud.Visible = False
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
		Me.CmdCancelar.Location = New System.Drawing.Point(298, 275)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(131, 30)
		Me.CmdCancelar.TabIndex = 9
		Me.CmdCancelar.Text = "Cancelar solicitud"
		Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancelar.UseVisualStyleBackColor = True
		'
		'Timer1
		'
		Me.Timer1.Interval = 1000
		'
		'LblSeg
		'
		Me.LblSeg.AutoSize = True
		Me.LblSeg.Location = New System.Drawing.Point(227, 285)
		Me.LblSeg.Name = "LblSeg"
		Me.LblSeg.Size = New System.Drawing.Size(55, 13)
		Me.LblSeg.TabIndex = 4
		Me.LblSeg.Text = "Segundos"
		Me.LblSeg.Visible = False
		'
		'BackgroundWorker1
		'
		'
		'fAutorizacionElectronica
		'
		Me.AcceptButton = Me.CmdEnviar
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.CancelButton = Me.CmdCancelar
		Me.ClientSize = New System.Drawing.Size(441, 311)
		Me.ControlBox = False
		Me.Controls.Add(Me.LblSeg)
		Me.Controls.Add(Me.LblSolicitud)
		Me.Controls.Add(Me.CmdCancelar)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "fAutorizacionElectronica"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Solicitar Autorizacion Electronica"
		Me.Controls.SetChildIndex(Me.Panel1, 0)
		Me.Controls.SetChildIndex(Me.CmdCancelar, 0)
		Me.Controls.SetChildIndex(Me.LblSolicitud, 0)
		Me.Controls.SetChildIndex(Me.LblSeg, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblSolicitud As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LstUsu As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ChkVerTodos As System.Windows.Forms.CheckBox
    Friend WithEvents TxtAdi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmdEnviar As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
    Friend WithEvents LblSeg As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
