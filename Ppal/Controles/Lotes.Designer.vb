<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lotes
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
        Me.CbLotes = New System.Windows.Forms.ComboBox()
        Me.LnkNuevoLote = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblFechaVencimiento = New System.Windows.Forms.Label()
        Me.LblNotas = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CbLotes
        '
        Me.CbLotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbLotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLotes.FormattingEnabled = True
        Me.CbLotes.Location = New System.Drawing.Point(68, 1)
        Me.CbLotes.Name = "CbLotes"
        Me.CbLotes.Size = New System.Drawing.Size(216, 21)
        Me.CbLotes.TabIndex = 156
        '
        'LnkNuevoLote
        '
        Me.LnkNuevoLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LnkNuevoLote.AutoSize = True
        Me.LnkNuevoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkNuevoLote.Location = New System.Drawing.Point(290, 5)
        Me.LnkNuevoLote.Name = "LnkNuevoLote"
        Me.LnkNuevoLote.Size = New System.Drawing.Size(76, 13)
        Me.LnkNuevoLote.TabIndex = 155
        Me.LnkNuevoLote.TabStop = True
        Me.LnkNuevoLote.Text = "Ingresar varios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "Lote/Serial"
        '
        'LblFechaVencimiento
        '
        Me.LblFechaVencimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFechaVencimiento.BackColor = System.Drawing.SystemColors.Control
        Me.LblFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFechaVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaVencimiento.ForeColor = System.Drawing.Color.Black
        Me.LblFechaVencimiento.Location = New System.Drawing.Point(189, 3)
        Me.LblFechaVencimiento.Name = "LblFechaVencimiento"
        Me.LblFechaVencimiento.Size = New System.Drawing.Size(76, 17)
        Me.LblFechaVencimiento.TabIndex = 158
        Me.LblFechaVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblFechaVencimiento.Visible = False
        '
        'LblNotas
        '
        Me.LblNotas.AutoSize = True
        Me.LblNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNotas.ForeColor = System.Drawing.Color.Gray
        Me.LblNotas.Location = New System.Drawing.Point(71, 28)
        Me.LblNotas.Name = "LblNotas"
        Me.LblNotas.Size = New System.Drawing.Size(50, 12)
        Me.LblNotas.TabIndex = 159
        Me.LblNotas.Text = "Notas Lote"
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStock.Location = New System.Drawing.Point(34, 28)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(10, 12)
        Me.LblStock.TabIndex = 160
        Me.LblStock.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 12)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Stock:"
        '
        'Lotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.LblNotas)
        Me.Controls.Add(Me.LblFechaVencimiento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbLotes)
        Me.Controls.Add(Me.LnkNuevoLote)
        Me.Name = "Lotes"
        Me.Size = New System.Drawing.Size(369, 45)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbLotes As System.Windows.Forms.ComboBox
    Friend WithEvents LnkNuevoLote As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblFechaVencimiento As System.Windows.Forms.Label
    Friend WithEvents LblNotas As System.Windows.Forms.Label
    Public WithEvents LblStock As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
