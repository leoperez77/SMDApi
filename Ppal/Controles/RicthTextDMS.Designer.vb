<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RicthTextDMS
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
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'RichTextBox1
		'
		Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStrip1
		Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.ShowSelectionMargin = True
		Me.RichTextBox1.Size = New System.Drawing.Size(148, 148)
		Me.RichTextBox1.TabIndex = 0
		Me.RichTextBox1.Text = ""
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
		'RicthTextDMS
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.RichTextBox1)
		Me.Name = "RicthTextDMS"
		Me.Size = New System.Drawing.Size(148, 148)
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
