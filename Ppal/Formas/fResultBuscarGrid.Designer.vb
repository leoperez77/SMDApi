<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fResultBuscarGrid
    Inherits AdvanceForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fResultBuscarGrid))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabsPrincipal = New System.Windows.Forms.TabControl()
        Me.TabBuscar = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlCol = New System.Windows.Forms.Panel()
        Me.CmdNinguno = New SMDPpal.BotonEstandar()
        Me.CbColumnas = New System.Windows.Forms.CheckedListBox()
        Me.CmdTodos = New SMDPpal.BotonEstandar()
        Me.ChkTodasCol = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabResultado = New System.Windows.Forms.TabPage()
        Me.GrdResultado = New System.Windows.Forms.DataGridView()
        Me.CmdCancelar = New SMDPpal.BotonEstandar()
        Me.CmdAceptar = New SMDPpal.BotonEstandar()
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabsPrincipal.SuspendLayout()
        Me.TabBuscar.SuspendLayout()
        Me.PnlCol.SuspendLayout()
        Me.TabResultado.SuspendLayout()
        CType(Me.GrdResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicPuntoAdv
        '
        Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicPuntoAdv.Location = New System.Drawing.Point(303, 0)
        '
        'TabsPrincipal
        '
        Me.TabsPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabsPrincipal.Controls.Add(Me.TabBuscar)
        Me.TabsPrincipal.Controls.Add(Me.TabResultado)
        Me.TabsPrincipal.Location = New System.Drawing.Point(4, 6)
        Me.TabsPrincipal.Name = "TabsPrincipal"
        Me.TabsPrincipal.SelectedIndex = 0
        Me.TabsPrincipal.Size = New System.Drawing.Size(318, 279)
        Me.TabsPrincipal.TabIndex = 0
        Me.TabsPrincipal.TabStop = False
        '
        'TabBuscar
        '
        Me.TabBuscar.Controls.Add(Me.Label1)
        Me.TabBuscar.Controls.Add(Me.PnlCol)
        Me.TabBuscar.Controls.Add(Me.ChkTodasCol)
        Me.TabBuscar.Controls.Add(Me.TextBox1)
        Me.TabBuscar.Location = New System.Drawing.Point(4, 22)
        Me.TabBuscar.Name = "TabBuscar"
        Me.TabBuscar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabBuscar.Size = New System.Drawing.Size(310, 253)
        Me.TabBuscar.TabIndex = 0
        Me.TabBuscar.Text = "Texto a Buscar"
        Me.TabBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entre el texto que desea buscar"
        '
        'PnlCol
        '
        Me.PnlCol.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCol.Controls.Add(Me.CmdNinguno)
        Me.PnlCol.Controls.Add(Me.CbColumnas)
        Me.PnlCol.Controls.Add(Me.CmdTodos)
        Me.PnlCol.Location = New System.Drawing.Point(20, 71)
        Me.PnlCol.Name = "PnlCol"
        Me.PnlCol.Size = New System.Drawing.Size(267, 182)
        Me.PnlCol.TabIndex = 3
        '
        'CmdNinguno
        '
        Me.CmdNinguno.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdNinguno.BackColor = System.Drawing.Color.White
        Me.CmdNinguno.BackgroundImage = CType(resources.GetObject("CmdNinguno.BackgroundImage"), System.Drawing.Image)
        Me.CmdNinguno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdNinguno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNinguno.ForeColor = System.Drawing.Color.White
        Me.CmdNinguno.Location = New System.Drawing.Point(136, 156)
        Me.CmdNinguno.Name = "CmdNinguno"
        Me.CmdNinguno.Size = New System.Drawing.Size(57, 23)
        Me.CmdNinguno.TabIndex = 2
		Me.CmdNinguno.Text = "Ninguno"
		Me.CmdNinguno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdNinguno.UseVisualStyleBackColor = True
        '
        'CbColumnas
        '
        Me.CbColumnas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbColumnas.CheckOnClick = True
        Me.CbColumnas.FormattingEnabled = True
        Me.CbColumnas.Location = New System.Drawing.Point(3, 3)
        Me.CbColumnas.Name = "CbColumnas"
        Me.CbColumnas.Size = New System.Drawing.Size(261, 139)
        Me.CbColumnas.TabIndex = 0
        '
        'CmdTodos
        '
        Me.CmdTodos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdTodos.BackColor = System.Drawing.Color.White
        Me.CmdTodos.BackgroundImage = CType(resources.GetObject("CmdTodos.BackgroundImage"), System.Drawing.Image)
        Me.CmdTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdTodos.ForeColor = System.Drawing.Color.White
        Me.CmdTodos.Location = New System.Drawing.Point(73, 156)
        Me.CmdTodos.Name = "CmdTodos"
        Me.CmdTodos.Size = New System.Drawing.Size(57, 23)
        Me.CmdTodos.TabIndex = 1
		Me.CmdTodos.Text = "Todos"
		Me.CmdTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdTodos.UseVisualStyleBackColor = True
        '
        'ChkTodasCol
        '
        Me.ChkTodasCol.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ChkTodasCol.AutoSize = True
        Me.ChkTodasCol.Location = New System.Drawing.Point(77, 52)
        Me.ChkTodasCol.Name = "ChkTodasCol"
        Me.ChkTodasCol.Size = New System.Drawing.Size(120, 17)
        Me.ChkTodasCol.TabIndex = 2
        Me.ChkTodasCol.Text = "Todas las columnas"
        Me.ChkTodasCol.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.Location = New System.Drawing.Point(77, 26)
        Me.TextBox1.MaxLength = 100
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TabResultado
        '
        Me.TabResultado.Controls.Add(Me.GrdResultado)
        Me.TabResultado.Location = New System.Drawing.Point(4, 22)
        Me.TabResultado.Name = "TabResultado"
        Me.TabResultado.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResultado.Size = New System.Drawing.Size(310, 253)
        Me.TabResultado.TabIndex = 1
        Me.TabResultado.Text = "Resultados"
        Me.TabResultado.UseVisualStyleBackColor = True
        '
        'GrdResultado
        '
        Me.GrdResultado.AllowUserToAddRows = False
        Me.GrdResultado.AllowUserToDeleteRows = False
        Me.GrdResultado.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdResultado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdResultado.DefaultCellStyle = DataGridViewCellStyle2
        Me.GrdResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdResultado.Location = New System.Drawing.Point(3, 3)
        Me.GrdResultado.MultiSelect = False
        Me.GrdResultado.Name = "GrdResultado"
        Me.GrdResultado.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdResultado.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GrdResultado.RowHeadersVisible = False
        Me.GrdResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdResultado.Size = New System.Drawing.Size(304, 247)
        Me.GrdResultado.StandardTab = True
        Me.GrdResultado.TabIndex = 0
        '
        'CmdCancelar
        '
        Me.CmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdCancelar.BackColor = System.Drawing.Color.White
        Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
        Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancelar.ForeColor = System.Drawing.Color.White
        Me.CmdCancelar.Location = New System.Drawing.Point(31, 291)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(78, 28)
        Me.CmdCancelar.TabIndex = 2
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancelar.UseVisualStyleBackColor = True
        '
        'CmdAceptar
        '
        Me.CmdAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdAceptar.BackColor = System.Drawing.Color.White
        Me.CmdAceptar.BackgroundImage = CType(resources.GetObject("CmdAceptar.BackgroundImage"), System.Drawing.Image)
        Me.CmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAceptar.ForeColor = System.Drawing.Color.White
        Me.CmdAceptar.Location = New System.Drawing.Point(217, 291)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.Size = New System.Drawing.Size(78, 28)
        Me.CmdAceptar.TabIndex = 1
        Me.CmdAceptar.Text = "Buscar"
        Me.CmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdAceptar.UseVisualStyleBackColor = True
        '
        'fResultBuscarGrid
        '
        Me.AcceptButton = Me.CmdAceptar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.CmdCancelar
        Me.ClientSize = New System.Drawing.Size(324, 349)
        Me.ControlBox = False
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.TabsPrincipal)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(227, 365)
        Me.Name = "fResultBuscarGrid"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar dentro del Grid"
        Me.Controls.SetChildIndex(Me.TabsPrincipal, 0)
        Me.Controls.SetChildIndex(Me.CmdCancelar, 0)
        Me.Controls.SetChildIndex(Me.CmdAceptar, 0)
        Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabsPrincipal.ResumeLayout(False)
        Me.TabBuscar.ResumeLayout(False)
        Me.TabBuscar.PerformLayout()
        Me.PnlCol.ResumeLayout(False)
        Me.TabResultado.ResumeLayout(False)
        CType(Me.GrdResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabsPrincipal As System.Windows.Forms.TabControl
    Friend WithEvents TabBuscar As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabResultado As System.Windows.Forms.TabPage
    Friend WithEvents ChkTodasCol As System.Windows.Forms.CheckBox
    Friend WithEvents GrdResultado As System.Windows.Forms.DataGridView
    Friend WithEvents CbColumnas As System.Windows.Forms.CheckedListBox
    Friend WithEvents PnlCol As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
    Friend WithEvents CmdNinguno As SMDPpal.BotonEstandar
    Friend WithEvents CmdTodos As SMDPpal.BotonEstandar
    Friend WithEvents CmdAceptar As SMDPpal.BotonEstandar
End Class
