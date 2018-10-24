<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fServer
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fServer))
		Me.Button1 = New SMDPpal.BotonEstandar()
		Me.TxtClave = New System.Windows.Forms.TextBox()
		Me.Button2 = New SMDPpal.BotonEstandar()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtServer = New System.Windows.Forms.TextBox()
		Me.TxtBase = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TxtUser = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.ChkOcultar = New System.Windows.Forms.CheckBox()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(248, 0)
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.White
		Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.ForeColor = System.Drawing.Color.White
		Me.Button1.Location = New System.Drawing.Point(9, 156)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(124, 43)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Usar esta conexión directa"
		Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TxtClave
		'
		Me.TxtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtClave.Location = New System.Drawing.Point(77, 97)
		Me.TxtClave.Name = "TxtClave"
		Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TxtClave.Size = New System.Drawing.Size(180, 20)
		Me.TxtClave.TabIndex = 3
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.White
		Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.ForeColor = System.Drawing.Color.White
		Me.Button2.Location = New System.Drawing.Point(142, 156)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(124, 43)
		Me.Button2.TabIndex = 5
		Me.Button2.Text = "Continuar con el WebService"
		Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(9, 103)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(34, 13)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Clave"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(9, 23)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(46, 13)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Servidor"
		'
		'TxtServer
		'
		Me.TxtServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtServer.Location = New System.Drawing.Point(77, 19)
		Me.TxtServer.Name = "TxtServer"
		Me.TxtServer.Size = New System.Drawing.Size(180, 20)
		Me.TxtServer.TabIndex = 0
		'
		'TxtBase
		'
		Me.TxtBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtBase.Location = New System.Drawing.Point(77, 45)
		Me.TxtBase.Name = "TxtBase"
		Me.TxtBase.Size = New System.Drawing.Size(180, 20)
		Me.TxtBase.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(9, 49)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(62, 13)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "Base Datos"
		'
		'TxtUser
		'
		Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtUser.Location = New System.Drawing.Point(77, 71)
		Me.TxtUser.Name = "TxtUser"
		Me.TxtUser.Size = New System.Drawing.Size(180, 20)
		Me.TxtUser.TabIndex = 2
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(9, 75)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(43, 13)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Usuario"
		'
		'ChkOcultar
		'
		Me.ChkOcultar.AutoSize = True
		Me.ChkOcultar.Location = New System.Drawing.Point(95, 133)
		Me.ChkOcultar.Name = "ChkOcultar"
		Me.ChkOcultar.Size = New System.Drawing.Size(131, 17)
		Me.ChkOcultar.TabIndex = 10
		Me.ChkOcultar.Text = "Ocultar en está sesión"
		Me.ChkOcultar.UseVisualStyleBackColor = True
		'
		'fServer
		'
		Me.AcceptButton = Me.Button1
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.CancelButton = Me.Button2
		Me.ClientSize = New System.Drawing.Size(269, 211)
		Me.ControlBox = False
		Me.Controls.Add(Me.ChkOcultar)
		Me.Controls.Add(Me.TxtUser)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.TxtBase)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TxtServer)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.TxtClave)
		Me.Controls.Add(Me.Button1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.HelpButton = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "fServer"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Conexión a Servidor de Datos"
		Me.TopMost = True
		Me.Controls.SetChildIndex(Me.Button1, 0)
		Me.Controls.SetChildIndex(Me.TxtClave, 0)
		Me.Controls.SetChildIndex(Me.Button2, 0)
		Me.Controls.SetChildIndex(Me.Label1, 0)
		Me.Controls.SetChildIndex(Me.Label2, 0)
		Me.Controls.SetChildIndex(Me.TxtServer, 0)
		Me.Controls.SetChildIndex(Me.Label3, 0)
		Me.Controls.SetChildIndex(Me.TxtBase, 0)
		Me.Controls.SetChildIndex(Me.Label4, 0)
		Me.Controls.SetChildIndex(Me.TxtUser, 0)
		Me.Controls.SetChildIndex(Me.ChkOcultar, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtServer As System.Windows.Forms.TextBox
    Friend WithEvents TxtBase As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As SMDPpal.BotonEstandar
    Friend WithEvents Button2 As SMDPpal.BotonEstandar
    Friend WithEvents ChkOcultar As System.Windows.Forms.CheckBox
End Class
