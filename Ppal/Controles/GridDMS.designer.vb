' Version: 675, 14-ago.-2018 18:45
' Version: 668, 23-jul.-2018 13:18
' Version: 665, 16-jul.-2018 13:20
' Version: 661, 10-jul.-2018 13:27
' Version: 597, 14-nov.-2017 14:55
'♥ versión: 586, 6-oct.-2017 07:11
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridDms
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.Grid = New System.Windows.Forms.DataGridView()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdOtrasOpciones0 = New System.Windows.Forms.ToolStripMenuItem()
		Me.Separador0 = New System.Windows.Forms.ToolStripSeparator()
		Me.CmdOtrasOpciones = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdOtrasOpciones2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdOtrasOpciones3 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdVerVerticalmente = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.CmdEnviarMail = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdEnviarUsuario = New System.Windows.Forms.ToolStripMenuItem()
		Me.CopiarExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdImprimir = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdPonerSombras = New System.Windows.Forms.ToolStripMenuItem()
		Me.CmdRefrescarSeparador = New System.Windows.Forms.ToolStripSeparator()
		Me.CmdRefrescar = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PequeñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GrandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EnumerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AjustarColumnasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CambiarAltoDeFilas = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.OpcionesColumna = New System.Windows.Forms.ToolStripMenuItem()
		Me.OcultarColumna = New System.Windows.Forms.ToolStripMenuItem()
		Me.CambiarTitulo = New System.Windows.Forms.ToolStripMenuItem()
		Me.GuardarPersonalizacion = New System.Windows.Forms.ToolStripMenuItem()
		Me.BorrarPersonalizacion = New System.Windows.Forms.ToolStripMenuItem()
		Me.LblNegrilla = New System.Windows.Forms.Label()
		Me.MyPrintDocument = New System.Drawing.Printing.PrintDocument()
		CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Grid
		'
		Me.Grid.AllowUserToAddRows = False
		Me.Grid.AllowUserToDeleteRows = False
		Me.Grid.AllowUserToOrderColumns = True
		Me.Grid.AllowUserToResizeRows = False
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.Grid.ContextMenuStrip = Me.ContextMenuStrip1
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.Grid.DefaultCellStyle = DataGridViewCellStyle2
		Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Grid.Location = New System.Drawing.Point(0, 0)
		Me.Grid.MultiSelect = False
		Me.Grid.Name = "Grid"
		Me.Grid.ReadOnly = True
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.Grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.Grid.RowHeadersVisible = False
		Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.Grid.ShowCellErrors = False
		Me.Grid.ShowRowErrors = False
		Me.Grid.Size = New System.Drawing.Size(240, 180)
		Me.Grid.TabIndex = 0
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.CmdOtrasOpciones0, Me.Separador0, Me.CmdOtrasOpciones, Me.CmdOtrasOpciones2, Me.CmdOtrasOpciones3, Me.CmdVerVerticalmente, Me.ToolStripSeparator3, Me.CmdEnviarMail, Me.CmdEnviarUsuario, Me.CopiarExcelToolStripMenuItem, Me.CmdImprimir, Me.ToolStripSeparator4, Me.BuscarToolStripMenuItem, Me.CmdPonerSombras, Me.CmdRefrescarSeparador, Me.CmdRefrescar, Me.ToolStripSeparator1, Me.EliminarToolStripMenuItem, Me.DeshacerToolStripMenuItem, Me.ToolStripSeparator2, Me.ZoomToolStripMenuItem, Me.EnumerarToolStripMenuItem, Me.AjustarColumnasToolStripMenuItem, Me.CambiarAltoDeFilas, Me.ToolStripSeparator5, Me.OpcionesColumna, Me.GuardarPersonalizacion, Me.BorrarPersonalizacion})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(202, 530)
		'
		'AbrirToolStripMenuItem
		'
		Me.AbrirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
		Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.AbrirToolStripMenuItem.Text = "Abrir"
		'
		'CmdOtrasOpciones0
		'
		Me.CmdOtrasOpciones0.Name = "CmdOtrasOpciones0"
		Me.CmdOtrasOpciones0.Size = New System.Drawing.Size(201, 22)
		Me.CmdOtrasOpciones0.Text = "opcion libre 0..."
		Me.CmdOtrasOpciones0.Visible = False
		'
		'Separador0
		'
		Me.Separador0.Name = "Separador0"
		Me.Separador0.Size = New System.Drawing.Size(198, 6)
		Me.Separador0.Visible = False
		'
		'CmdOtrasOpciones
		'
		Me.CmdOtrasOpciones.ForeColor = System.Drawing.Color.Green
		Me.CmdOtrasOpciones.Name = "CmdOtrasOpciones"
		Me.CmdOtrasOpciones.Size = New System.Drawing.Size(201, 22)
		Me.CmdOtrasOpciones.Text = "opcion libre 1..."
		Me.CmdOtrasOpciones.Visible = False
		'
		'CmdOtrasOpciones2
		'
		Me.CmdOtrasOpciones2.ForeColor = System.Drawing.Color.Maroon
		Me.CmdOtrasOpciones2.Name = "CmdOtrasOpciones2"
		Me.CmdOtrasOpciones2.Size = New System.Drawing.Size(201, 22)
		Me.CmdOtrasOpciones2.Text = "opcion libre 2..."
		Me.CmdOtrasOpciones2.Visible = False
		'
		'CmdOtrasOpciones3
		'
		Me.CmdOtrasOpciones3.Checked = True
		Me.CmdOtrasOpciones3.CheckState = System.Windows.Forms.CheckState.Checked
		Me.CmdOtrasOpciones3.ForeColor = System.Drawing.Color.Navy
		Me.CmdOtrasOpciones3.Name = "CmdOtrasOpciones3"
		Me.CmdOtrasOpciones3.Size = New System.Drawing.Size(201, 22)
		Me.CmdOtrasOpciones3.Text = "opcion libre 3..."
		Me.CmdOtrasOpciones3.Visible = False
		'
		'CmdVerVerticalmente
		'
		Me.CmdVerVerticalmente.Name = "CmdVerVerticalmente"
		Me.CmdVerVerticalmente.Size = New System.Drawing.Size(201, 22)
		Me.CmdVerVerticalmente.Text = "Ver fila verticalmente"
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(198, 6)
		'
		'CmdEnviarMail
		'
		Me.CmdEnviarMail.Name = "CmdEnviarMail"
		Me.CmdEnviarMail.Size = New System.Drawing.Size(201, 22)
		Me.CmdEnviarMail.Text = "Enviar por e-mail"
		'
		'CmdEnviarUsuario
		'
		Me.CmdEnviarUsuario.Name = "CmdEnviarUsuario"
		Me.CmdEnviarUsuario.Size = New System.Drawing.Size(201, 22)
		Me.CmdEnviarUsuario.Text = "Enviar por chat"
		'
		'CopiarExcelToolStripMenuItem
		'
		Me.CopiarExcelToolStripMenuItem.Name = "CopiarExcelToolStripMenuItem"
		Me.CopiarExcelToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.CopiarExcelToolStripMenuItem.Text = "Abrir en  Excel"
		'
		'CmdImprimir
		'
		Me.CmdImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.CmdImprimir.Name = "CmdImprimir"
		Me.CmdImprimir.Size = New System.Drawing.Size(201, 22)
		Me.CmdImprimir.Text = "Imprimir"
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		Me.ToolStripSeparator4.Size = New System.Drawing.Size(198, 6)
		'
		'BuscarToolStripMenuItem
		'
		Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
		Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.BuscarToolStripMenuItem.Text = "Buscar"
		'
		'CmdPonerSombras
		'
		Me.CmdPonerSombras.Name = "CmdPonerSombras"
		Me.CmdPonerSombras.Size = New System.Drawing.Size(201, 22)
		Me.CmdPonerSombras.Text = "Poner sombras"
		'
		'CmdRefrescarSeparador
		'
		Me.CmdRefrescarSeparador.Name = "CmdRefrescarSeparador"
		Me.CmdRefrescarSeparador.Size = New System.Drawing.Size(198, 6)
		'
		'CmdRefrescar
		'
		Me.CmdRefrescar.Name = "CmdRefrescar"
		Me.CmdRefrescar.Size = New System.Drawing.Size(201, 22)
		Me.CmdRefrescar.Text = "Refrescar datos Grid"
		Me.CmdRefrescar.Visible = False
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(198, 6)
		'
		'EliminarToolStripMenuItem
		'
		Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
		Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.EliminarToolStripMenuItem.Text = "Eliminar"
		'
		'DeshacerToolStripMenuItem
		'
		Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
		Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.DeshacerToolStripMenuItem.Text = "Deshacer"
		Me.DeshacerToolStripMenuItem.Visible = False
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(198, 6)
		'
		'ZoomToolStripMenuItem
		'
		Me.ZoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PequeñoToolStripMenuItem, Me.NormalToolStripMenuItem, Me.GrandeToolStripMenuItem})
		Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
		Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.ZoomToolStripMenuItem.Text = "Zoom"
		'
		'PequeñoToolStripMenuItem
		'
		Me.PequeñoToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
		Me.PequeñoToolStripMenuItem.Name = "PequeñoToolStripMenuItem"
		Me.PequeñoToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
		Me.PequeñoToolStripMenuItem.Text = "Pequeño"
		'
		'NormalToolStripMenuItem
		'
		Me.NormalToolStripMenuItem.Checked = True
		Me.NormalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.NormalToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
		Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
		Me.NormalToolStripMenuItem.Text = "Normal"
		'
		'GrandeToolStripMenuItem
		'
		Me.GrandeToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
		Me.GrandeToolStripMenuItem.Name = "GrandeToolStripMenuItem"
		Me.GrandeToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
		Me.GrandeToolStripMenuItem.Text = "Grande"
		'
		'EnumerarToolStripMenuItem
		'
		Me.EnumerarToolStripMenuItem.Name = "EnumerarToolStripMenuItem"
		Me.EnumerarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.EnumerarToolStripMenuItem.Text = "Enumerar"
		'
		'AjustarColumnasToolStripMenuItem
		'
		Me.AjustarColumnasToolStripMenuItem.Checked = True
		Me.AjustarColumnasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.AjustarColumnasToolStripMenuItem.Name = "AjustarColumnasToolStripMenuItem"
		Me.AjustarColumnasToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
		Me.AjustarColumnasToolStripMenuItem.Text = "Ajustar Columnas"
		'
		'CambiarAltoDeFilas
		'
		Me.CambiarAltoDeFilas.Name = "CambiarAltoDeFilas"
		Me.CambiarAltoDeFilas.Size = New System.Drawing.Size(201, 22)
		Me.CambiarAltoDeFilas.Text = "Cambiar alto de las filas"
		'
		'ToolStripSeparator5
		'
		Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
		Me.ToolStripSeparator5.Size = New System.Drawing.Size(198, 6)
		'
		'OpcionesColumna
		'
		Me.OpcionesColumna.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OcultarColumna, Me.CambiarTitulo})
		Me.OpcionesColumna.Name = "OpcionesColumna"
		Me.OpcionesColumna.Size = New System.Drawing.Size(201, 22)
		Me.OpcionesColumna.Tag = "Opciones columna: "
		Me.OpcionesColumna.Text = "Opciones columna"
		'
		'OcultarColumna
		'
		Me.OcultarColumna.Name = "OcultarColumna"
		Me.OcultarColumna.Size = New System.Drawing.Size(150, 22)
		Me.OcultarColumna.Text = "Ocultar"
		'
		'CambiarTitulo
		'
		Me.CambiarTitulo.Name = "CambiarTitulo"
		Me.CambiarTitulo.Size = New System.Drawing.Size(150, 22)
		Me.CambiarTitulo.Text = "Cambiar título"
		'
		'GuardarPersonalizacion
		'
		Me.GuardarPersonalizacion.BackColor = System.Drawing.Color.White
		Me.GuardarPersonalizacion.ForeColor = System.Drawing.Color.Black
		Me.GuardarPersonalizacion.Name = "GuardarPersonalizacion"
		Me.GuardarPersonalizacion.Size = New System.Drawing.Size(201, 22)
		Me.GuardarPersonalizacion.Text = "Guardar personalización"
		'
		'BorrarPersonalizacion
		'
		Me.BorrarPersonalizacion.BackColor = System.Drawing.Color.White
		Me.BorrarPersonalizacion.ForeColor = System.Drawing.Color.Black
		Me.BorrarPersonalizacion.Name = "BorrarPersonalizacion"
		Me.BorrarPersonalizacion.Size = New System.Drawing.Size(201, 22)
		Me.BorrarPersonalizacion.Text = "Borrar personalización"
		'
		'LblNegrilla
		'
		Me.LblNegrilla.AutoSize = True
		Me.LblNegrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblNegrilla.Location = New System.Drawing.Point(185, 54)
		Me.LblNegrilla.Name = "LblNegrilla"
		Me.LblNegrilla.Size = New System.Drawing.Size(50, 13)
		Me.LblNegrilla.TabIndex = 1
		Me.LblNegrilla.Text = "Negrilla"
		Me.LblNegrilla.Visible = False
		'
		'MyPrintDocument
		'
		'
		'GridDms
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Controls.Add(Me.LblNegrilla)
		Me.Controls.Add(Me.Grid)
		Me.Name = "GridDms"
		Me.Size = New System.Drawing.Size(240, 180)
		CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PequeñoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrandeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnumerarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents AjustarColumnasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents CambiarAltoDeFilas As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents LblNegrilla As System.Windows.Forms.Label
	Friend WithEvents CmdRefrescar As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CmdRefrescarSeparador As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents CmdEnviarMail As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents CmdEnviarUsuario As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CmdVerVerticalmente As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents CmdOtrasOpciones As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents CmdOtrasOpciones2 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents CmdOtrasOpciones3 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents CmdOtrasOpciones0 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents Separador0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OpcionesColumna As ToolStripMenuItem
	Friend WithEvents OcultarColumna As ToolStripMenuItem
	Friend WithEvents CambiarTitulo As ToolStripMenuItem
	Friend WithEvents GuardarPersonalizacion As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
	Public WithEvents BorrarPersonalizacion As ToolStripMenuItem
	Friend WithEvents MyPrintDocument As Printing.PrintDocument
	Friend WithEvents CmdImprimir As ToolStripMenuItem
	Friend WithEvents DeshacerToolStripMenuItem As ToolStripMenuItem
	Public WithEvents CmdPonerSombras As ToolStripMenuItem
End Class
