<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fModificarCampos
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fModificarCampos))
		Me.LblNegrilla = New System.Windows.Forms.Label()
		Me.LnkAudit = New System.Windows.Forms.LinkLabel()
		Me.LnkExportar = New System.Windows.Forms.LinkLabel()
		Me.LnkEliminar = New System.Windows.Forms.LinkLabel()
		Me.LnkImportar = New System.Windows.Forms.LinkLabel()
		Me.LnkVerTodasColumnas = New System.Windows.Forms.LinkLabel()
		Me.CmdSalvar = New SMDPpal.BotonEstandar()
		Me.CmdSalir = New SMDPpal.BotonEstandar()
		Me.CmdActualizar = New SMDPpal.BotonEstandar()
		Me.Grd = New SMDPpal.GridDms()
		Me.SuspendLayout()
		'
		'LblNegrilla
		'
		Me.LblNegrilla.AutoSize = True
		Me.LblNegrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblNegrilla.Location = New System.Drawing.Point(12, 9)
		Me.LblNegrilla.Name = "LblNegrilla"
		Me.LblNegrilla.Size = New System.Drawing.Size(50, 13)
		Me.LblNegrilla.TabIndex = 4
		Me.LblNegrilla.Text = "Negrilla"
		Me.LblNegrilla.Visible = False
		'
		'LnkAudit
		'
		Me.LnkAudit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.LnkAudit.AutoSize = True
		Me.LnkAudit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkAudit.Location = New System.Drawing.Point(264, 541)
		Me.LnkAudit.Name = "LnkAudit"
		Me.LnkAudit.Size = New System.Drawing.Size(50, 13)
		Me.LnkAudit.TabIndex = 7
		Me.LnkAudit.TabStop = True
		Me.LnkAudit.Text = "Auditoría"
		'
		'LnkExportar
		'
		Me.LnkExportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.LnkExportar.AutoSize = True
		Me.LnkExportar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkExportar.Location = New System.Drawing.Point(264, 520)
		Me.LnkExportar.Name = "LnkExportar"
		Me.LnkExportar.Size = New System.Drawing.Size(46, 13)
		Me.LnkExportar.TabIndex = 10
		Me.LnkExportar.TabStop = True
		Me.LnkExportar.Text = "Exportar"
		'
		'LnkEliminar
		'
		Me.LnkEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.LnkEliminar.AutoSize = True
		Me.LnkEliminar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkEliminar.Location = New System.Drawing.Point(345, 541)
		Me.LnkEliminar.Name = "LnkEliminar"
		Me.LnkEliminar.Size = New System.Drawing.Size(67, 13)
		Me.LnkEliminar.TabIndex = 10
		Me.LnkEliminar.TabStop = True
		Me.LnkEliminar.Text = "Eliminar todo"
		'
		'LnkImportar
		'
		Me.LnkImportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.LnkImportar.AutoSize = True
		Me.LnkImportar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkImportar.Location = New System.Drawing.Point(345, 520)
		Me.LnkImportar.Name = "LnkImportar"
		Me.LnkImportar.Size = New System.Drawing.Size(45, 13)
		Me.LnkImportar.TabIndex = 11
		Me.LnkImportar.TabStop = True
		Me.LnkImportar.Text = "Importar"
		'
		'LnkVerTodasColumnas
		'
		Me.LnkVerTodasColumnas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.LnkVerTodasColumnas.AutoSize = True
		Me.LnkVerTodasColumnas.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkVerTodasColumnas.Location = New System.Drawing.Point(76, 535)
		Me.LnkVerTodasColumnas.Name = "LnkVerTodasColumnas"
		Me.LnkVerTodasColumnas.Size = New System.Drawing.Size(53, 13)
		Me.LnkVerTodasColumnas.TabIndex = 12
		Me.LnkVerTodasColumnas.TabStop = True
		Me.LnkVerTodasColumnas.Text = "Columnas"
		'
		'CmdSalvar
		'
		Me.CmdSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdSalvar.BackColor = System.Drawing.Color.White
		Me.CmdSalvar.BackgroundImage = CType(resources.GetObject("CmdSalvar.BackgroundImage"), System.Drawing.Image)
		Me.CmdSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdSalvar.ForeColor = System.Drawing.Color.White
		Me.CmdSalvar.Location = New System.Drawing.Point(540, 526)
		Me.CmdSalvar.Name = "CmdSalvar"
		Me.CmdSalvar.Size = New System.Drawing.Size(87, 30)
		Me.CmdSalvar.TabIndex = 9
		Me.CmdSalvar.Text = "Salvar"
		Me.CmdSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdSalvar.UseVisualStyleBackColor = False
		'
		'CmdSalir
		'
		Me.CmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.CmdSalir.BackColor = System.Drawing.Color.White
		Me.CmdSalir.BackgroundImage = CType(resources.GetObject("CmdSalir.BackgroundImage"), System.Drawing.Image)
		Me.CmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdSalir.ForeColor = System.Drawing.Color.White
		Me.CmdSalir.Location = New System.Drawing.Point(4, 526)
		Me.CmdSalir.Name = "CmdSalir"
		Me.CmdSalir.Size = New System.Drawing.Size(66, 30)
		Me.CmdSalir.TabIndex = 5
		Me.CmdSalir.Text = "Cerrar"
		Me.CmdSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdSalir.UseVisualStyleBackColor = False
		'
		'CmdActualizar
		'
		Me.CmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdActualizar.BackColor = System.Drawing.Color.White
		Me.CmdActualizar.BackgroundImage = CType(resources.GetObject("CmdActualizar.BackgroundImage"), System.Drawing.Image)
		Me.CmdActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdActualizar.ForeColor = System.Drawing.Color.White
		Me.CmdActualizar.Location = New System.Drawing.Point(634, 526)
		Me.CmdActualizar.Name = "CmdActualizar"
		Me.CmdActualizar.Size = New System.Drawing.Size(144, 30)
		Me.CmdActualizar.TabIndex = 2
		Me.CmdActualizar.Text = "Salvar y cerrar F5"
		Me.CmdActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdActualizar.UseVisualStyleBackColor = False
		'
		'Grd
		'
		Me.Grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Grd.DMSCopiarDt = True
		Me.Grd.DMSTituloDelInforme = ""
		Me.Grd.Location = New System.Drawing.Point(0, 0)
		Me.Grd.Name = "Grd"
		Me.Grd.Size = New System.Drawing.Size(786, 517)
		Me.Grd.TabIndex = 0
		'
		'fModificarCampos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(784, 561)
		Me.Controls.Add(Me.LnkVerTodasColumnas)
		Me.Controls.Add(Me.LnkImportar)
		Me.Controls.Add(Me.LnkEliminar)
		Me.Controls.Add(Me.LnkExportar)
		Me.Controls.Add(Me.CmdSalvar)
		Me.Controls.Add(Me.LnkAudit)
		Me.Controls.Add(Me.CmdSalir)
		Me.Controls.Add(Me.LblNegrilla)
		Me.Controls.Add(Me.CmdActualizar)
		Me.Controls.Add(Me.Grd)
		Me.KeyPreview = True
		Me.MinimizeBox = False
		Me.Name = "fModificarCampos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "campos"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Grd As GridDms
	Friend WithEvents CmdActualizar As BotonEstandar
	Friend WithEvents LblNegrilla As Label
	Friend WithEvents CmdSalir As BotonEstandar
	Friend WithEvents LnkAudit As LinkLabel
	Friend WithEvents CmdSalvar As BotonEstandar
	Friend WithEvents LnkExportar As LinkLabel
	Friend WithEvents LnkEliminar As LinkLabel
	Friend WithEvents LnkImportar As LinkLabel
	Friend WithEvents LnkVerTodasColumnas As LinkLabel
End Class
