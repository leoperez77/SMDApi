<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fLote_Serial
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtNotas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrdLote = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCant = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cmd_Actualizar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbLote = New System.Windows.Forms.ComboBox()
        CType(Me.GrdLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(477, 32)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 8
        Me.CmdOk.Text = "Adicionar"
        Me.CmdOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lote/Serial"
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(302, 6)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(248, 20)
        Me.TxtFecha.TabIndex = 3
        '
        'TxtNotas
        '
        Me.TxtNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNotas.Location = New System.Drawing.Point(178, 32)
        Me.TxtNotas.MaxLength = 50
        Me.TxtNotas.Name = "TxtNotas"
        Me.TxtNotas.Size = New System.Drawing.Size(258, 20)
        Me.TxtNotas.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Notas"
        '
        'GrdLote
        '
        Me.GrdLote.AllowUserToAddRows = False
        Me.GrdLote.AllowUserToDeleteRows = False
        Me.GrdLote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrdLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdLote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.lote, Me.cantidad, Me.fecha_vencimiento, Me.notas})
        Me.GrdLote.Location = New System.Drawing.Point(15, 68)
        Me.GrdLote.MultiSelect = False
        Me.GrdLote.Name = "GrdLote"
        Me.GrdLote.ReadOnly = True
        Me.GrdLote.RowHeadersVisible = False
        Me.GrdLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdLote.Size = New System.Drawing.Size(537, 260)
        Me.GrdLote.TabIndex = 9
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'lote
        '
        Me.lote.DataPropertyName = "lote"
        Me.lote.HeaderText = "Lote/Serial"
        Me.lote.Name = "lote"
        Me.lote.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'fecha_vencimiento
        '
        Me.fecha_vencimiento.DataPropertyName = "fecha_vencimiento"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.fecha_vencimiento.DefaultCellStyle = DataGridViewCellStyle2
        Me.fecha_vencimiento.HeaderText = "Fecha Vencimiento"
        Me.fecha_vencimiento.Name = "fecha_vencimiento"
        Me.fecha_vencimiento.ReadOnly = True
        '
        'notas
        '
        Me.notas.DataPropertyName = "notas"
        Me.notas.HeaderText = "Notas"
        Me.notas.Name = "notas"
        Me.notas.ReadOnly = True
        '
        'TxtCant
        '
        Me.TxtCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCant.Location = New System.Drawing.Point(77, 33)
        Me.TxtCant.Name = "TxtCant"
        Me.TxtCant.Size = New System.Drawing.Size(54, 20)
        Me.TxtCant.TabIndex = 5
        Me.TxtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad"
        '
        'Cmd_Actualizar
        '
        Me.Cmd_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Actualizar.Location = New System.Drawing.Point(449, 334)
        Me.Cmd_Actualizar.Name = "Cmd_Actualizar"
        Me.Cmd_Actualizar.Size = New System.Drawing.Size(89, 33)
        Me.Cmd_Actualizar.TabIndex = 10
        Me.Cmd_Actualizar.Text = "Regresar"
        Me.Cmd_Actualizar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(234, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Vencimiento"
        '
        'CbLote
        '
        Me.CbLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbLote.FormattingEnabled = True
        Me.CbLote.Location = New System.Drawing.Point(77, 6)
        Me.CbLote.Name = "CbLote"
        Me.CbLote.Size = New System.Drawing.Size(151, 21)
        Me.CbLote.TabIndex = 1
        '
        'fLote_Serial
        '
        Me.AcceptButton = Me.CmdOk
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(564, 379)
        Me.Controls.Add(Me.CbLote)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.Cmd_Actualizar)
        Me.Controls.Add(Me.TxtCant)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GrdLote)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNotas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "fLote_Serial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lote"
        CType(Me.GrdLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdOk As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtNotas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrdLote As System.Windows.Forms.DataGridView
    Friend WithEvents TxtCant As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_vencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents notas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cmd_Actualizar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbLote As System.Windows.Forms.ComboBox
End Class
