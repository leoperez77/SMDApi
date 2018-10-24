<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fColums
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fColums))
		Me.LnkPredeter = New System.Windows.Forms.LinkLabel()
		Me.GrdCols = New System.Windows.Forms.DataGridView()
		Me.ver = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CmdAplicarCols = New SMDPpal.BotonEstandar()
		Me.CmdCancelar = New System.Windows.Forms.Button()
		CType(Me.GrdCols, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LnkPredeter
		'
		Me.LnkPredeter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkPredeter.AutoSize = True
		Me.LnkPredeter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkPredeter.Location = New System.Drawing.Point(209, 12)
		Me.LnkPredeter.Name = "LnkPredeter"
		Me.LnkPredeter.Size = New System.Drawing.Size(72, 13)
		Me.LnkPredeter.TabIndex = 9
		Me.LnkPredeter.TabStop = True
		Me.LnkPredeter.Text = "Poner Default"
		'
		'GrdCols
		'
		Me.GrdCols.AllowUserToAddRows = False
		Me.GrdCols.AllowUserToDeleteRows = False
		Me.GrdCols.AllowUserToOrderColumns = True
		Me.GrdCols.AllowUserToResizeRows = False
		Me.GrdCols.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GrdCols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.GrdCols.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ver, Me.nombre, Me.titulo})
		Me.GrdCols.Location = New System.Drawing.Point(0, 3)
		Me.GrdCols.Name = "GrdCols"
		Me.GrdCols.RowHeadersVisible = False
		Me.GrdCols.Size = New System.Drawing.Size(194, 557)
		Me.GrdCols.TabIndex = 8
		'
		'ver
		'
		Me.ver.HeaderText = "Ver"
		Me.ver.Name = "ver"
		Me.ver.ReadOnly = True
		Me.ver.Width = 30
		'
		'nombre
		'
		Me.nombre.HeaderText = "nombre"
		Me.nombre.Name = "nombre"
		Me.nombre.ReadOnly = True
		Me.nombre.Visible = False
		'
		'titulo
		'
		Me.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.titulo.HeaderText = "Título"
		Me.titulo.Name = "titulo"
		Me.titulo.ReadOnly = True
		'
		'CmdAplicarCols
		'
		Me.CmdAplicarCols.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdAplicarCols.BackColor = System.Drawing.Color.White
		Me.CmdAplicarCols.BackgroundImage = CType(resources.GetObject("CmdAplicarCols.BackgroundImage"), System.Drawing.Image)
		Me.CmdAplicarCols.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdAplicarCols.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdAplicarCols.ForeColor = System.Drawing.Color.White
		Me.CmdAplicarCols.Location = New System.Drawing.Point(206, 477)
		Me.CmdAplicarCols.Name = "CmdAplicarCols"
		Me.CmdAplicarCols.Size = New System.Drawing.Size(75, 37)
		Me.CmdAplicarCols.TabIndex = 10
		Me.CmdAplicarCols.Text = "Guardar Cambios"
		Me.CmdAplicarCols.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdAplicarCols.UseVisualStyleBackColor = True
		'
		'CmdCancelar
		'
		Me.CmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancelar.Location = New System.Drawing.Point(206, 520)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(75, 33)
		Me.CmdCancelar.TabIndex = 11
		Me.CmdCancelar.Text = "Cancelar"
		Me.CmdCancelar.UseVisualStyleBackColor = True
		'
		'fColums
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.CancelButton = Me.CmdCancelar
		Me.ClientSize = New System.Drawing.Size(292, 561)
		Me.ControlBox = False
		Me.Controls.Add(Me.CmdCancelar)
		Me.Controls.Add(Me.CmdAplicarCols)
		Me.Controls.Add(Me.LnkPredeter)
		Me.Controls.Add(Me.GrdCols)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.MinimumSize = New System.Drawing.Size(308, 300)
		Me.Name = "fColums"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Definir Columnas a Mostrar"
		CType(Me.GrdCols, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LnkPredeter As System.Windows.Forms.LinkLabel
    Friend WithEvents GrdCols As System.Windows.Forms.DataGridView
    Friend WithEvents CmdAplicarCols As SMDPpal.BotonEstandar
    Friend WithEvents ver As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents titulo As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CmdCancelar As Button
End Class
