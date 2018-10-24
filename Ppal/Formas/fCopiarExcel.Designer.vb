<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCopiarExcel
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCopiarExcel))
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.CmdCancelar = New SMDPpal.BotonEstandar()
		Me.SuspendLayout()
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(12, 12)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(231, 23)
		Me.ProgressBar1.TabIndex = 0
		'
		'CmdCancelar
		'
		Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancelar.ForeColor = System.Drawing.Color.White
		Me.CmdCancelar.Location = New System.Drawing.Point(80, 47)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(94, 26)
		Me.CmdCancelar.TabIndex = 2
		Me.CmdCancelar.Text = "Cancelar"
		Me.CmdCancelar.UseVisualStyleBackColor = True
		'
		'fCopiarExcel
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(251, 76)
		Me.ControlBox = False
		Me.Controls.Add(Me.CmdCancelar)
		Me.Controls.Add(Me.ProgressBar1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "fCopiarExcel"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Exportando a Excel..."
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
	Friend WithEvents CmdCancelar As BotonEstandar
End Class
