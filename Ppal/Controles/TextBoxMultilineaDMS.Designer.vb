<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextBoxMultilineaDMS
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
		Me.components = New System.ComponentModel.Container()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TextBox1
		'
		Me.TextBox1.AcceptsReturn = True
		Me.TextBox1.AcceptsTab = True
		Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
		Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TextBox1.Location = New System.Drawing.Point(0, 0)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(163, 75)
		Me.TextBox1.TabIndex = 0
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 26)
		'
		'BuscarToolStripMenuItem
		'
		Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
		Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
		Me.BuscarToolStripMenuItem.Text = "Buscar"
		'
		'TextBoxMultilineaDMS
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Controls.Add(Me.TextBox1)
		Me.Name = "TextBoxMultilineaDMS"
		Me.Size = New System.Drawing.Size(163, 75)
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Public WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
