' Version: 660, 5-jul.-2018 12:55
'♥ versión: 586, 6-oct.-2017 07:11
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMaestro
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMaestro))
		Me.Grd = New System.Windows.Forms.DataGridView()
		Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Modifico = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.CmdBorrar = New SMDPpal.BotonEstandar()
		Me.CmdAgregar = New SMDPpal.BotonEstandar()
		Me.txtDescripcion = New System.Windows.Forms.TextBox()
		Me.CmdOk = New SMDPpal.BotonEstandar()
		Me.CmdCancelar = New SMDPpal.BotonEstandar()
		Me.CmdNuevo = New SMDPpal.BotonEstandar()
		Me.PnlDesp = New System.Windows.Forms.Panel()
		Me.LnkExportar = New System.Windows.Forms.LinkLabel()
		Me.LblID = New System.Windows.Forms.Label()
		Me.PnlCb = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.CbPadre = New System.Windows.Forms.ComboBox()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PnlDesp.SuspendLayout()
		Me.PnlCb.SuspendLayout()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(488, 0)
		'
		'Grd
		'
		Me.Grd.AllowUserToAddRows = False
		Me.Grd.AllowUserToDeleteRows = False
		Me.Grd.AllowUserToResizeRows = False
		Me.Grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.Grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.Grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Descripcion, Me.Modifico})
		Me.Grd.Location = New System.Drawing.Point(15, 68)
		Me.Grd.MultiSelect = False
		Me.Grd.Name = "Grd"
		Me.Grd.ReadOnly = True
		Me.Grd.RowHeadersVisible = False
		Me.Grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.Grd.Size = New System.Drawing.Size(463, 282)
		Me.Grd.TabIndex = 4
		'
		'Id
		'
		Me.Id.HeaderText = "Id"
		Me.Id.Name = "Id"
		Me.Id.ReadOnly = True
		Me.Id.Visible = False
		'
		'Descripcion
		'
		Me.Descripcion.HeaderText = "Descripcion"
		Me.Descripcion.Name = "Descripcion"
		Me.Descripcion.ReadOnly = True
		'
		'Modifico
		'
		Me.Modifico.HeaderText = "Modifico"
		Me.Modifico.Name = "Modifico"
		Me.Modifico.ReadOnly = True
		Me.Modifico.Visible = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(63, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Descripción"
		'
		'CmdBorrar
		'
		Me.CmdBorrar.BackColor = System.Drawing.Color.White
		Me.CmdBorrar.BackgroundImage = CType(resources.GetObject("CmdBorrar.BackgroundImage"), System.Drawing.Image)
		Me.CmdBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdBorrar.Enabled = False
		Me.CmdBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdBorrar.ForeColor = System.Drawing.Color.White
		Me.CmdBorrar.Location = New System.Drawing.Point(86, 36)
		Me.CmdBorrar.Name = "CmdBorrar"
		Me.CmdBorrar.Size = New System.Drawing.Size(60, 26)
		Me.CmdBorrar.TabIndex = 3
		Me.CmdBorrar.Text = "&Borrar"
		Me.CmdBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdBorrar.UseVisualStyleBackColor = True
		'
		'CmdAgregar
		'
		Me.CmdAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdAgregar.BackColor = System.Drawing.Color.White
		Me.CmdAgregar.BackgroundImage = CType(resources.GetObject("CmdAgregar.BackgroundImage"), System.Drawing.Image)
		Me.CmdAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdAgregar.ForeColor = System.Drawing.Color.White
		Me.CmdAgregar.Location = New System.Drawing.Point(385, 36)
		Me.CmdAgregar.Name = "CmdAgregar"
		Me.CmdAgregar.Size = New System.Drawing.Size(93, 26)
		Me.CmdAgregar.TabIndex = 2
		Me.CmdAgregar.Text = "A&gregar"
		Me.CmdAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdAgregar.UseVisualStyleBackColor = True
		'
		'txtDescripcion
		'
		Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtDescripcion.Location = New System.Drawing.Point(78, 10)
		Me.txtDescripcion.MaxLength = 50
		Me.txtDescripcion.Multiline = True
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(400, 20)
		Me.txtDescripcion.TabIndex = 1
		'
		'CmdOk
		'
		Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdOk.BackColor = System.Drawing.Color.White
		Me.CmdOk.BackgroundImage = CType(resources.GetObject("CmdOk.BackgroundImage"), System.Drawing.Image)
		Me.CmdOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdOk.ForeColor = System.Drawing.Color.White
		Me.CmdOk.Location = New System.Drawing.Point(308, 356)
		Me.CmdOk.Name = "CmdOk"
		Me.CmdOk.Size = New System.Drawing.Size(73, 26)
		Me.CmdOk.TabIndex = 5
		Me.CmdOk.Text = "&Actualizar"
		Me.CmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdOk.UseVisualStyleBackColor = True
		'
		'CmdCancelar
		'
		Me.CmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdCancelar.BackColor = System.Drawing.Color.White
		Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancelar.ForeColor = System.Drawing.Color.White
		Me.CmdCancelar.Location = New System.Drawing.Point(394, 356)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(73, 26)
		Me.CmdCancelar.TabIndex = 6
		Me.CmdCancelar.Text = "&Cancelar"
		Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancelar.UseVisualStyleBackColor = True
		'
		'CmdNuevo
		'
		Me.CmdNuevo.BackColor = System.Drawing.Color.White
		Me.CmdNuevo.BackgroundImage = CType(resources.GetObject("CmdNuevo.BackgroundImage"), System.Drawing.Image)
		Me.CmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdNuevo.ForeColor = System.Drawing.Color.White
		Me.CmdNuevo.Location = New System.Drawing.Point(18, 36)
		Me.CmdNuevo.Name = "CmdNuevo"
		Me.CmdNuevo.Size = New System.Drawing.Size(60, 26)
		Me.CmdNuevo.TabIndex = 7
		Me.CmdNuevo.Text = "&Nuevo"
		Me.CmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdNuevo.UseVisualStyleBackColor = True
		'
		'PnlDesp
		'
		Me.PnlDesp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PnlDesp.Controls.Add(Me.LnkExportar)
		Me.PnlDesp.Controls.Add(Me.LblID)
		Me.PnlDesp.Controls.Add(Me.Label1)
		Me.PnlDesp.Controls.Add(Me.txtDescripcion)
		Me.PnlDesp.Controls.Add(Me.CmdNuevo)
		Me.PnlDesp.Controls.Add(Me.CmdAgregar)
		Me.PnlDesp.Controls.Add(Me.CmdCancelar)
		Me.PnlDesp.Controls.Add(Me.CmdBorrar)
		Me.PnlDesp.Controls.Add(Me.CmdOk)
		Me.PnlDesp.Controls.Add(Me.Grd)
		Me.PnlDesp.Location = New System.Drawing.Point(3, 3)
		Me.PnlDesp.Name = "PnlDesp"
		Me.PnlDesp.Size = New System.Drawing.Size(498, 388)
		Me.PnlDesp.TabIndex = 0
		'
		'LnkExportar
		'
		Me.LnkExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.LnkExportar.AutoSize = True
		Me.LnkExportar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkExportar.Location = New System.Drawing.Point(15, 363)
		Me.LnkExportar.Name = "LnkExportar"
		Me.LnkExportar.Size = New System.Drawing.Size(33, 13)
		Me.LnkExportar.TabIndex = 10
		Me.LnkExportar.TabStop = True
		Me.LnkExportar.Text = "Excel"
		'
		'LblID
		'
		Me.LblID.AutoSize = True
		Me.LblID.Location = New System.Drawing.Point(225, 43)
		Me.LblID.Name = "LblID"
		Me.LblID.Size = New System.Drawing.Size(21, 13)
		Me.LblID.TabIndex = 9
		Me.LblID.Text = "ID:"
		'
		'PnlCb
		'
		Me.PnlCb.Controls.Add(Me.Label2)
		Me.PnlCb.Controls.Add(Me.CbPadre)
		Me.PnlCb.Location = New System.Drawing.Point(4, 3)
		Me.PnlCb.Name = "PnlCb"
		Me.PnlCb.Size = New System.Drawing.Size(498, 43)
		Me.PnlCb.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(61, 14)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(37, 13)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Marca"
		'
		'CbPadre
		'
		Me.CbPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbPadre.FormattingEnabled = True
		Me.CbPadre.Location = New System.Drawing.Point(128, 11)
		Me.CbPadre.Name = "CbPadre"
		Me.CbPadre.Size = New System.Drawing.Size(253, 21)
		Me.CbPadre.TabIndex = 123
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitContainer1.IsSplitterFixed = True
		Me.SplitContainer1.Location = New System.Drawing.Point(2, 2)
		Me.SplitContainer1.Name = "SplitContainer1"
		Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.PnlCb)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.PnlDesp)
		Me.SplitContainer1.Size = New System.Drawing.Size(505, 448)
		Me.SplitContainer1.SplitterDistance = 46
		Me.SplitContainer1.TabIndex = 2
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.Visible = False
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.Width = 460
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.HeaderText = "Modifico"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		Me.DataGridViewTextBoxColumn3.Visible = False
		'
		'fMaestro
		'
		Me.AcceptButton = Me.CmdAgregar
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(509, 452)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MinimumSize = New System.Drawing.Size(256, 270)
		Me.Name = "fMaestro"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Categorias"
		Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PnlDesp.ResumeLayout(False)
		Me.PnlDesp.PerformLayout()
		Me.PnlCb.ResumeLayout(False)
		Me.PnlCb.PerformLayout()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Grd As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modifico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlDesp As System.Windows.Forms.Panel
    Friend WithEvents PnlCb As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Public WithEvents CbPadre As System.Windows.Forms.ComboBox
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents CmdBorrar As SMDPpal.BotonEstandar
    Friend WithEvents CmdAgregar As SMDPpal.BotonEstandar
    Friend WithEvents CmdOk As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
    Friend WithEvents CmdNuevo As SMDPpal.BotonEstandar
    Friend WithEvents LnkExportar As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
