' Version: 680, 17-ago.-2018 13:24
'♥ versión: 586, 6-oct.-2017 07:11
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonedaDMS
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
		Me.LnkTasa = New System.Windows.Forms.LinkLabel()
		Me.LblTasa = New System.Windows.Forms.Label()
		Me.CbMoneda = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(4, 6)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(46, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Moneda"
		'
		'LnkTasa
		'
		Me.LnkTasa.AutoSize = True
		Me.LnkTasa.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LnkTasa.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkTasa.LinkColor = System.Drawing.Color.Blue
		Me.LnkTasa.Location = New System.Drawing.Point(170, 8)
		Me.LnkTasa.Name = "LnkTasa"
		Me.LnkTasa.Size = New System.Drawing.Size(31, 13)
		Me.LnkTasa.TabIndex = 2
		Me.LnkTasa.TabStop = True
		Me.LnkTasa.Text = "Tasa"
		'
		'LblTasa
		'
		Me.LblTasa.BackColor = System.Drawing.SystemColors.Control
		Me.LblTasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblTasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblTasa.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LblTasa.Location = New System.Drawing.Point(215, 6)
		Me.LblTasa.Name = "LblTasa"
		Me.LblTasa.Size = New System.Drawing.Size(82, 18)
		Me.LblTasa.TabIndex = 3
		Me.LblTasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'CbMoneda
		'
		Me.CbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbMoneda.FormattingEnabled = True
		Me.CbMoneda.Location = New System.Drawing.Point(53, 3)
		Me.CbMoneda.Name = "CbMoneda"
		Me.CbMoneda.Size = New System.Drawing.Size(111, 21)
		Me.CbMoneda.TabIndex = 1
		'
		'MonedaDMS
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Azure
		Me.Controls.Add(Me.CbMoneda)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.LnkTasa)
		Me.Controls.Add(Me.LblTasa)
		Me.Name = "MonedaDMS"
		Me.Size = New System.Drawing.Size(302, 26)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LnkTasa As System.Windows.Forms.LinkLabel
    Friend WithEvents LblTasa As System.Windows.Forms.Label
    Friend WithEvents CbMoneda As System.Windows.Forms.ComboBox

End Class
