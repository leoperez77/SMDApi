<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManejoArchivos
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
		Me.LblArchivo = New System.Windows.Forms.TextBox()
		Me.LnkArchivoQuitar = New System.Windows.Forms.LinkLabel()
		Me.LnkArchivoAbrir = New System.Windows.Forms.LinkLabel()
		Me.LnkArchivo = New System.Windows.Forms.LinkLabel()
		Me.SuspendLayout()
		'
		'LblArchivo
		'
		Me.LblArchivo.AcceptsReturn = True
		Me.LblArchivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblArchivo.BackColor = System.Drawing.SystemColors.Window
		Me.LblArchivo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.LblArchivo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.LblArchivo.Location = New System.Drawing.Point(94, 5)
		Me.LblArchivo.MaxLength = 250
		Me.LblArchivo.Multiline = True
		Me.LblArchivo.Name = "LblArchivo"
		Me.LblArchivo.ReadOnly = True
		Me.LblArchivo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LblArchivo.Size = New System.Drawing.Size(68, 32)
		Me.LblArchivo.TabIndex = 27
		'
		'LnkArchivoQuitar
		'
		Me.LnkArchivoQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkArchivoQuitar.AutoSize = True
		Me.LnkArchivoQuitar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkArchivoQuitar.Location = New System.Drawing.Point(168, 14)
		Me.LnkArchivoQuitar.Name = "LnkArchivoQuitar"
		Me.LnkArchivoQuitar.Size = New System.Drawing.Size(35, 13)
		Me.LnkArchivoQuitar.TabIndex = 28
		Me.LnkArchivoQuitar.TabStop = True
		Me.LnkArchivoQuitar.Text = "Quitar"
		'
		'LnkArchivoAbrir
		'
		Me.LnkArchivoAbrir.AutoSize = True
		Me.LnkArchivoAbrir.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkArchivoAbrir.Location = New System.Drawing.Point(3, 23)
		Me.LnkArchivoAbrir.Name = "LnkArchivoAbrir"
		Me.LnkArchivoAbrir.Size = New System.Drawing.Size(67, 13)
		Me.LnkArchivoAbrir.TabIndex = 25
		Me.LnkArchivoAbrir.TabStop = True
		Me.LnkArchivoAbrir.Text = "Abrir Archivo"
		'
		'LnkArchivo
		'
		Me.LnkArchivo.AutoSize = True
		Me.LnkArchivo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkArchivo.Location = New System.Drawing.Point(3, 5)
		Me.LnkArchivo.Name = "LnkArchivo"
		Me.LnkArchivo.Size = New System.Drawing.Size(85, 13)
		Me.LnkArchivo.TabIndex = 26
		Me.LnkArchivo.TabStop = True
		Me.LnkArchivo.Text = "Adjuntar Archivo"
		'
		'ManejoArchivos
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Controls.Add(Me.LblArchivo)
		Me.Controls.Add(Me.LnkArchivoQuitar)
		Me.Controls.Add(Me.LnkArchivoAbrir)
		Me.Controls.Add(Me.LnkArchivo)
		Me.Name = "ManejoArchivos"
		Me.Size = New System.Drawing.Size(228, 40)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Public WithEvents LblArchivo As System.Windows.Forms.TextBox
    Friend WithEvents LnkArchivoQuitar As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkArchivoAbrir As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkArchivo As System.Windows.Forms.LinkLabel

End Class
