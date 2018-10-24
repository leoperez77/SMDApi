<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fClave
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fClave))
		Me.Button1 = New SMDPpal.BotonEstandar()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Button2 = New SMDPpal.BotonEstandar()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(189, 0)
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.Control
		Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.ForeColor = System.Drawing.Color.White
		Me.Button1.Location = New System.Drawing.Point(31, 113)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 27)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Aceptar"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox1.Location = New System.Drawing.Point(59, 58)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBox1.Size = New System.Drawing.Size(100, 20)
		Me.TextBox1.TabIndex = 1
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.Control
		Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
		Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.ForeColor = System.Drawing.Color.White
		Me.Button2.Location = New System.Drawing.Point(112, 113)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 27)
		Me.Button2.TabIndex = 3
		Me.Button2.Text = "Cancelar"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(59, 42)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(100, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Entre la clave"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'fClave
		'
		Me.AcceptButton = Me.Button1
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.CancelButton = Me.Button2
		Me.ClientSize = New System.Drawing.Size(210, 158)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Button1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.HelpButton = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "fClave"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Entrar Clave"
		Me.Controls.SetChildIndex(Me.Button1, 0)
		Me.Controls.SetChildIndex(Me.TextBox1, 0)
		Me.Controls.SetChildIndex(Me.Button2, 0)
		Me.Controls.SetChildIndex(Me.Label1, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Button1 As BotonEstandar
	Friend WithEvents Button2 As BotonEstandar
End Class
