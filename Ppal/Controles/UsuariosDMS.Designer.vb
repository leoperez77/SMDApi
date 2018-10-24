<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosDMS
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
		Me.Lst1 = New System.Windows.Forms.CheckedListBox()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.ChkSeleccionados = New System.Windows.Forms.CheckBox()
		Me.LnkTodos = New System.Windows.Forms.LinkLabel()
		Me.LnkNinguno = New System.Windows.Forms.LinkLabel()
		Me.ChkOnLine = New System.Windows.Forms.CheckBox()
		Me.LblBuscar = New System.Windows.Forms.Label()
		Me.LnkUlt = New System.Windows.Forms.LinkLabel()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Lst1
		'
		Me.Lst1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Lst1.CheckOnClick = True
		Me.Lst1.ContextMenuStrip = Me.ContextMenuStrip1
		Me.Lst1.FormattingEnabled = True
		Me.Lst1.Location = New System.Drawing.Point(3, 3)
		Me.Lst1.Name = "Lst1"
		Me.Lst1.Size = New System.Drawing.Size(165, 289)
		Me.Lst1.TabIndex = 7
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
		Me.BuscarToolStripMenuItem.ShortcutKeyDisplayString = ""
		Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
		Me.BuscarToolStripMenuItem.Text = "Buscar"
		'
		'RadioButton2
		'
		Me.RadioButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(101, 311)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
		Me.RadioButton2.TabIndex = 9
		Me.RadioButton2.Text = "Grupos"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Checked = True
		Me.RadioButton1.Location = New System.Drawing.Point(101, 294)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(59, 17)
		Me.RadioButton1.TabIndex = 8
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "Listado"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'ChkSeleccionados
		'
		Me.ChkSeleccionados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.ChkSeleccionados.AutoSize = True
		Me.ChkSeleccionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkSeleccionados.Location = New System.Drawing.Point(4, 332)
		Me.ChkSeleccionados.Name = "ChkSeleccionados"
		Me.ChkSeleccionados.Size = New System.Drawing.Size(100, 16)
		Me.ChkSeleccionados.TabIndex = 13
		Me.ChkSeleccionados.Text = "Ver seleccionados"
		Me.ChkSeleccionados.UseVisualStyleBackColor = True
		'
		'LnkTodos
		'
		Me.LnkTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.LnkTodos.AutoSize = True
		Me.LnkTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LnkTodos.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkTodos.Location = New System.Drawing.Point(2, 294)
		Me.LnkTodos.Name = "LnkTodos"
		Me.LnkTodos.Size = New System.Drawing.Size(30, 12)
		Me.LnkTodos.TabIndex = 14
		Me.LnkTodos.TabStop = True
		Me.LnkTodos.Text = "Todos"
		'
		'LnkNinguno
		'
		Me.LnkNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.LnkNinguno.AutoSize = True
		Me.LnkNinguno.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LnkNinguno.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkNinguno.Location = New System.Drawing.Point(47, 294)
		Me.LnkNinguno.Name = "LnkNinguno"
		Me.LnkNinguno.Size = New System.Drawing.Size(39, 12)
		Me.LnkNinguno.TabIndex = 15
		Me.LnkNinguno.TabStop = True
		Me.LnkNinguno.Text = "Ninguno"
		'
		'ChkOnLine
		'
		Me.ChkOnLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.ChkOnLine.AutoSize = True
		Me.ChkOnLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkOnLine.Location = New System.Drawing.Point(4, 317)
		Me.ChkOnLine.Name = "ChkOnLine"
		Me.ChkOnLine.Size = New System.Drawing.Size(73, 16)
		Me.ChkOnLine.TabIndex = 16
		Me.ChkOnLine.Text = "Ver On-Line"
		Me.ChkOnLine.UseVisualStyleBackColor = True
		'
		'LblBuscar
		'
		Me.LblBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblBuscar.BackColor = System.Drawing.SystemColors.Control
		Me.LblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblBuscar.Location = New System.Drawing.Point(136, 6)
		Me.LblBuscar.Name = "LblBuscar"
		Me.LblBuscar.Size = New System.Drawing.Size(14, 16)
		Me.LblBuscar.TabIndex = 17
		Me.LblBuscar.Text = "♣"
		'
		'LnkUlt
		'
		Me.LnkUlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkUlt.AutoSize = True
		Me.LnkUlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LnkUlt.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkUlt.Location = New System.Drawing.Point(121, 331)
		Me.LnkUlt.Name = "LnkUlt"
		Me.LnkUlt.Size = New System.Drawing.Size(37, 12)
		Me.LnkUlt.TabIndex = 18
		Me.LnkUlt.TabStop = True
		Me.LnkUlt.Text = "Ultimos"
		'
		'UsuariosDMS
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Controls.Add(Me.LnkUlt)
		Me.Controls.Add(Me.LblBuscar)
		Me.Controls.Add(Me.ChkOnLine)
		Me.Controls.Add(Me.ChkSeleccionados)
		Me.Controls.Add(Me.LnkNinguno)
		Me.Controls.Add(Me.LnkTodos)
		Me.Controls.Add(Me.Lst1)
		Me.Controls.Add(Me.RadioButton2)
		Me.Controls.Add(Me.RadioButton1)
		Me.Name = "UsuariosDMS"
		Me.Size = New System.Drawing.Size(171, 346)
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Lst1 As System.Windows.Forms.CheckedListBox
    Public WithEvents ChkSeleccionados As System.Windows.Forms.CheckBox
    Public WithEvents LnkTodos As System.Windows.Forms.LinkLabel
    Public WithEvents LnkNinguno As System.Windows.Forms.LinkLabel
    Public WithEvents ChkOnLine As System.Windows.Forms.CheckBox
    Friend WithEvents LblBuscar As System.Windows.Forms.Label
    Public WithEvents LnkUlt As System.Windows.Forms.LinkLabel

End Class
