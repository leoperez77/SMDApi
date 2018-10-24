<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextoBuscarCtrlB
	Inherits System.Windows.Forms.UserControl

	'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextoaBuscar = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(5, 6)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(123, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "F3 para buscar siguiente"
		'
		'TextoaBuscar
		'
		Me.TextoaBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextoaBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextoaBuscar.Location = New System.Drawing.Point(12, 23)
		Me.TextoaBuscar.Name = "TextoaBuscar"
		Me.TextoaBuscar.Size = New System.Drawing.Size(101, 22)
		Me.TextoaBuscar.TabIndex = 1
		'
		'TextoBuscarCtrlB
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.TextoaBuscar)
		Me.Controls.Add(Me.Label1)
		Me.Name = "TextoBuscarCtrlB"
		Me.Size = New System.Drawing.Size(130, 51)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Public WithEvents TextoaBuscar As TextBox
End Class
