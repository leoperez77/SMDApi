<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBoxDMS
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
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ContarLineasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ListBox1
		'
		Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip1
		Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.IntegralHeight = False
		Me.ListBox1.Location = New System.Drawing.Point(0, 0)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(143, 132)
		Me.ListBox1.TabIndex = 0
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarToolStripMenuItem, Me.ToolStripSeparator1, Me.ContarLineasToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(147, 54)
		'
		'BuscarToolStripMenuItem
		'
		Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
		Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.BuscarToolStripMenuItem.Text = "Buscar"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
		'
		'ContarLineasToolStripMenuItem
		'
		Me.ContarLineasToolStripMenuItem.Name = "ContarLineasToolStripMenuItem"
		Me.ContarLineasToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.ContarLineasToolStripMenuItem.Text = "Contar Lineas"
		'
		'ListBoxDMS
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.ListBox1)
		Me.Name = "ListBoxDMS"
		Me.Size = New System.Drawing.Size(143, 132)
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContarLineasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
