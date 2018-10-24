' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckListBoxDMS
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
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.MarcarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DesmarcarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ContarLineasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Lst1 = New System.Windows.Forms.CheckedListBox()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarToolStripMenuItem, Me.ToolStripSeparator1, Me.MarcarTodosToolStripMenuItem, Me.DesmarcarTodosToolStripMenuItem, Me.ToolStripSeparator2, Me.ContarLineasToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 104)
		'
		'BuscarToolStripMenuItem
		'
		Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
		Me.BuscarToolStripMenuItem.ShortcutKeyDisplayString = ""
		Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.BuscarToolStripMenuItem.Text = "Buscar"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
		'
		'MarcarTodosToolStripMenuItem
		'
		Me.MarcarTodosToolStripMenuItem.Name = "MarcarTodosToolStripMenuItem"
		Me.MarcarTodosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.MarcarTodosToolStripMenuItem.Text = "Marcar Todos"
		'
		'DesmarcarTodosToolStripMenuItem
		'
		Me.DesmarcarTodosToolStripMenuItem.Name = "DesmarcarTodosToolStripMenuItem"
		Me.DesmarcarTodosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.DesmarcarTodosToolStripMenuItem.Text = "Desmarcar Todos"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(162, 6)
		'
		'ContarLineasToolStripMenuItem
		'
		Me.ContarLineasToolStripMenuItem.Name = "ContarLineasToolStripMenuItem"
		Me.ContarLineasToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.ContarLineasToolStripMenuItem.Text = "Contar Lineas"
		'
		'Lst1
		'
		Me.Lst1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Lst1.CheckOnClick = True
		Me.Lst1.ContextMenuStrip = Me.ContextMenuStrip1
		Me.Lst1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Lst1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lst1.FormattingEnabled = True
		Me.Lst1.Location = New System.Drawing.Point(0, 0)
		Me.Lst1.Name = "Lst1"
		Me.Lst1.Size = New System.Drawing.Size(141, 157)
		Me.Lst1.TabIndex = 13
		'
		'CheckListBoxDMS
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.Lst1)
		Me.Name = "CheckListBoxDMS"
		Me.Size = New System.Drawing.Size(141, 157)
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContarLineasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Lst1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents MarcarTodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesmarcarTodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
