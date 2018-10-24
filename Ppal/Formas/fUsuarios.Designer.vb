<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fUsuarios
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fUsuarios))
		Me.CmdCancelar = New SMDPpal.BotonEstandar()
		Me.CmdAceptar = New SMDPpal.BotonEstandar()
		Me.UsuariosDMS1 = New SMDPpal.UsuariosDMS()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(280, 0)
		'
		'CmdCancelar
		'
		Me.CmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancelar.ForeColor = System.Drawing.Color.White
		Me.CmdCancelar.Location = New System.Drawing.Point(173, 462)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(75, 23)
		Me.CmdCancelar.TabIndex = 5
		Me.CmdCancelar.Text = "Cancelar"
		Me.CmdCancelar.UseVisualStyleBackColor = True
		'
		'CmdAceptar
		'
		Me.CmdAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdAceptar.BackgroundImage = CType(resources.GetObject("CmdAceptar.BackgroundImage"), System.Drawing.Image)
		Me.CmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdAceptar.ForeColor = System.Drawing.Color.White
		Me.CmdAceptar.Location = New System.Drawing.Point(53, 462)
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(75, 23)
		Me.CmdAceptar.TabIndex = 4
		Me.CmdAceptar.Text = "Aceptar"
		Me.CmdAceptar.UseVisualStyleBackColor = True
		'
		'UsuariosDMS1
		'
		Me.UsuariosDMS1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.UsuariosDMS1.DMSClic_Grupo = True
		Me.UsuariosDMS1.Location = New System.Drawing.Point(4, 1)
		Me.UsuariosDMS1.Name = "UsuariosDMS1"
		Me.UsuariosDMS1.Size = New System.Drawing.Size(293, 451)
		Me.UsuariosDMS1.TabIndex = 6
		'
		'BackgroundWorker1
		'
		'
		'fUsuarios
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.CancelButton = Me.CmdCancelar
		Me.ClientSize = New System.Drawing.Size(301, 493)
		Me.ControlBox = False
		Me.Controls.Add(Me.UsuariosDMS1)
		Me.Controls.Add(Me.CmdCancelar)
		Me.Controls.Add(Me.CmdAceptar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Name = "fUsuarios"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Seleccione Usuarios"
		Me.Controls.SetChildIndex(Me.CmdAceptar, 0)
		Me.Controls.SetChildIndex(Me.CmdCancelar, 0)
		Me.Controls.SetChildIndex(Me.UsuariosDMS1, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Public WithEvents UsuariosDMS1 As SMDPpal.UsuariosDMS
	Friend WithEvents CmdCancelar As BotonEstandar
	Friend WithEvents CmdAceptar As BotonEstandar
End Class
