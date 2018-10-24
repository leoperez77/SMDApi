' Version: 680, 17-ago.-2018 13:24
'♥ versión: 586, 6-oct.-2017 07:11
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fFormatoImpresion
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fFormatoImpresion))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.CmdAceptar = New SMDPpal.BotonEstandar()
		Me.Grd = New System.Windows.Forms.DataGridView()
		Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.LnkRefrescar = New System.Windows.Forms.LinkLabel()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(441, 0)
		'
		'CmdAceptar
		'
		Me.CmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdAceptar.BackColor = System.Drawing.Color.White
		Me.CmdAceptar.BackgroundImage = CType(resources.GetObject("CmdAceptar.BackgroundImage"), System.Drawing.Image)
		Me.CmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdAceptar.ForeColor = System.Drawing.Color.White
		Me.CmdAceptar.Location = New System.Drawing.Point(285, 364)
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(169, 28)
		Me.CmdAceptar.TabIndex = 1
		Me.CmdAceptar.Text = "Producir Documento"
		Me.CmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdAceptar.UseVisualStyleBackColor = True
		'
		'Grd
		'
		Me.Grd.AllowUserToAddRows = False
		Me.Grd.AllowUserToDeleteRows = False
		Me.Grd.AllowUserToOrderColumns = True
		Me.Grd.AllowUserToResizeRows = False
		Me.Grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.Grd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.Grd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.Grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.Grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.descripcion, Me.fecha})
		Me.Grd.Location = New System.Drawing.Point(6, 6)
		Me.Grd.MultiSelect = False
		Me.Grd.Name = "Grd"
		Me.Grd.ReadOnly = True
		Me.Grd.RowHeadersVisible = False
		Me.Grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.Grd.Size = New System.Drawing.Size(450, 353)
		Me.Grd.TabIndex = 86
		'
		'id
		'
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.id.DefaultCellStyle = DataGridViewCellStyle2
		Me.id.FillWeight = 10.0!
		Me.id.HeaderText = "id"
		Me.id.Name = "id"
		Me.id.ReadOnly = True
		Me.id.Visible = False
		'
		'descripcion
		'
		Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.descripcion.DefaultCellStyle = DataGridViewCellStyle3
		Me.descripcion.HeaderText = "Descripción"
		Me.descripcion.Name = "descripcion"
		Me.descripcion.ReadOnly = True
		'
		'fecha
		'
		Me.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle4.Format = "yyyy/MM/ dd HH:mm"
		DataGridViewCellStyle4.NullValue = Nothing
		Me.fecha.DefaultCellStyle = DataGridViewCellStyle4
		Me.fecha.FillWeight = 60.0!
		Me.fecha.HeaderText = "Ult. Actualización"
		Me.fecha.Name = "fecha"
		Me.fecha.ReadOnly = True
		'
		'LnkRefrescar
		'
		Me.LnkRefrescar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.LnkRefrescar.AutoSize = True
		Me.LnkRefrescar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkRefrescar.Location = New System.Drawing.Point(33, 373)
		Me.LnkRefrescar.Name = "LnkRefrescar"
		Me.LnkRefrescar.Size = New System.Drawing.Size(53, 13)
		Me.LnkRefrescar.TabIndex = 89
		Me.LnkRefrescar.TabStop = True
		Me.LnkRefrescar.Text = "Refrescar"
		'
		'fFormatoImpresion
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(462, 395)
		Me.Controls.Add(Me.LnkRefrescar)
		Me.Controls.Add(Me.Grd)
		Me.Controls.Add(Me.CmdAceptar)
		Me.MinimizeBox = False
		Me.Name = "fFormatoImpresion"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Formato a usar"
		Me.Controls.SetChildIndex(Me.CmdAceptar, 0)
		Me.Controls.SetChildIndex(Me.Grd, 0)
		Me.Controls.SetChildIndex(Me.LnkRefrescar, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Grd As System.Windows.Forms.DataGridView
    Friend WithEvents LnkRefrescar As System.Windows.Forms.LinkLabel
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmdAceptar As SMDPpal.BotonEstandar
End Class
