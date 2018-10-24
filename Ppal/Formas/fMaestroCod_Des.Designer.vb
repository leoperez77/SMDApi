<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMaestroCod_Des
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMaestroCod_Des))
        Me.PnlDesp = New System.Windows.Forms.Panel()
        Me.LnkEliminar = New System.Windows.Forms.LinkLabel()
        Me.LnkNuevo = New System.Windows.Forms.LinkLabel()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblDes = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.CmdAgregar = New SMDPpal.BotonEstandar()
        Me.CmdCancelar = New SMDPpal.BotonEstandar()
        Me.CmdOk = New SMDPpal.BotonEstandar()
        Me.Grd = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cam_padre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modifico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDesp.SuspendLayout()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicPuntoAdv
        '
        Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicPuntoAdv.Location = New System.Drawing.Point(490, 0)
        '
        'PnlDesp
        '
        Me.PnlDesp.Controls.Add(Me.LnkEliminar)
        Me.PnlDesp.Controls.Add(Me.LnkNuevo)
        Me.PnlDesp.Controls.Add(Me.LblCodigo)
        Me.PnlDesp.Controls.Add(Me.TxtCod)
        Me.PnlDesp.Controls.Add(Me.LblID)
        Me.PnlDesp.Controls.Add(Me.LblDes)
        Me.PnlDesp.Controls.Add(Me.TxtDescripcion)
        Me.PnlDesp.Controls.Add(Me.CmdAgregar)
        Me.PnlDesp.Controls.Add(Me.CmdCancelar)
        Me.PnlDesp.Controls.Add(Me.CmdOk)
        Me.PnlDesp.Controls.Add(Me.Grd)
        Me.PnlDesp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlDesp.Location = New System.Drawing.Point(0, 0)
        Me.PnlDesp.Name = "PnlDesp"
        Me.PnlDesp.Size = New System.Drawing.Size(511, 347)
        Me.PnlDesp.TabIndex = 0
        '
        'LnkEliminar
        '
        Me.LnkEliminar.AutoSize = True
        Me.LnkEliminar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkEliminar.Location = New System.Drawing.Point(84, 66)
        Me.LnkEliminar.Name = "LnkEliminar"
        Me.LnkEliminar.Size = New System.Drawing.Size(43, 13)
        Me.LnkEliminar.TabIndex = 13
        Me.LnkEliminar.TabStop = True
        Me.LnkEliminar.Text = "Eliminar"
        '
        'LnkNuevo
        '
        Me.LnkNuevo.AutoSize = True
        Me.LnkNuevo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkNuevo.Location = New System.Drawing.Point(26, 66)
        Me.LnkNuevo.Name = "LnkNuevo"
        Me.LnkNuevo.Size = New System.Drawing.Size(39, 13)
        Me.LnkNuevo.TabIndex = 12
        Me.LnkNuevo.TabStop = True
        Me.LnkNuevo.Text = "Nuevo"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Location = New System.Drawing.Point(12, 9)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.LblCodigo.TabIndex = 0
        Me.LblCodigo.Text = "Codigo"
        '
        'TxtCod
        '
        Me.TxtCod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCod.Location = New System.Drawing.Point(78, 6)
        Me.TxtCod.MaxLength = 50
        Me.TxtCod.Multiline = True
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(103, 20)
        Me.TxtCod.TabIndex = 1
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(225, 66)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(21, 13)
        Me.LblID.TabIndex = 4
        Me.LblID.Text = "ID:"
        '
        'LblDes
        '
        Me.LblDes.AutoSize = True
        Me.LblDes.Location = New System.Drawing.Point(12, 35)
        Me.LblDes.Name = "LblDes"
        Me.LblDes.Size = New System.Drawing.Size(63, 13)
        Me.LblDes.TabIndex = 2
        Me.LblDes.Text = "Descripción"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcion.Location = New System.Drawing.Point(78, 32)
        Me.TxtDescripcion.MaxLength = 50
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(413, 20)
        Me.TxtDescripcion.TabIndex = 3
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
        Me.CmdAgregar.Location = New System.Drawing.Point(398, 59)
        Me.CmdAgregar.Name = "CmdAgregar"
        Me.CmdAgregar.Size = New System.Drawing.Size(93, 26)
        Me.CmdAgregar.TabIndex = 5
        Me.CmdAgregar.Text = "A&gregar"
        Me.CmdAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdAgregar.UseVisualStyleBackColor = True
        '
        'CmdCancelar
        '
        Me.CmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCancelar.BackColor = System.Drawing.Color.White
        Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
        Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancelar.ForeColor = System.Drawing.Color.White
        Me.CmdCancelar.Location = New System.Drawing.Point(407, 315)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(73, 26)
        Me.CmdCancelar.TabIndex = 11
        Me.CmdCancelar.Text = "&Cancelar"
        Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancelar.UseVisualStyleBackColor = True
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.BackColor = System.Drawing.Color.White
        Me.CmdOk.BackgroundImage = CType(resources.GetObject("CmdOk.BackgroundImage"), System.Drawing.Image)
        Me.CmdOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdOk.ForeColor = System.Drawing.Color.White
        Me.CmdOk.Location = New System.Drawing.Point(321, 315)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(73, 26)
        Me.CmdOk.TabIndex = 10
        Me.CmdOk.Text = "&Actualizar"
        Me.CmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdOk.UseVisualStyleBackColor = True
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
        Me.Grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.cod, Me.Descripcion, Me.id_cam_padre, Me.Modifico})
        Me.Grd.Location = New System.Drawing.Point(15, 91)
        Me.Grd.MultiSelect = False
        Me.Grd.Name = "Grd"
        Me.Grd.ReadOnly = True
        Me.Grd.RowHeadersVisible = False
        Me.Grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grd.Size = New System.Drawing.Size(476, 218)
        Me.Grd.TabIndex = 8
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'cod
        '
        Me.cod.HeaderText = "Codigo"
        Me.cod.Name = "cod"
        Me.cod.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'id_cam_padre
        '
        Me.id_cam_padre.HeaderText = "id_cam_padre"
        Me.id_cam_padre.Name = "id_cam_padre"
        Me.id_cam_padre.ReadOnly = True
        Me.id_cam_padre.Visible = False
        '
        'Modifico
        '
        Me.Modifico.DataPropertyName = "modifico"
        Me.Modifico.HeaderText = "Modifico"
        Me.Modifico.Name = "Modifico"
        Me.Modifico.ReadOnly = True
        Me.Modifico.Visible = False
        '
        'fMaestroCod_Des
        '
        Me.AcceptButton = Me.CmdAgregar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(511, 347)
        Me.Controls.Add(Me.PnlDesp)
        Me.Name = "fMaestroCod_Des"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "fMaestroCod_Des"
        Me.Controls.SetChildIndex(Me.PnlDesp, 0)
        Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDesp.ResumeLayout(False)
        Me.PnlDesp.PerformLayout()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlDesp As System.Windows.Forms.Panel
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents LblDes As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Grd As System.Windows.Forms.DataGridView
    Friend WithEvents LnkEliminar As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkNuevo As System.Windows.Forms.LinkLabel
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cam_padre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modifico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmdAgregar As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
    Friend WithEvents CmdOk As SMDPpal.BotonEstandar
End Class
