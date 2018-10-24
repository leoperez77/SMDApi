<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BotonActualizar
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BotonActualizar))
		Me.CmdActualizar = New SMDPpal.BotonEstandar()
		Me.SuspendLayout()
		'
		'CmdActualizar
		'
		Me.CmdActualizar.BackColor = System.Drawing.Color.White
		Me.CmdActualizar.BackgroundImage = CType(resources.GetObject("CmdActualizar.BackgroundImage"), System.Drawing.Image)
		Me.CmdActualizar.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdActualizar.ForeColor = System.Drawing.Color.White
		Me.CmdActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.CmdActualizar.Location = New System.Drawing.Point(0, 0)
		Me.CmdActualizar.Name = "CmdActualizar"
		Me.CmdActualizar.Size = New System.Drawing.Size(102, 45)
		Me.CmdActualizar.TabIndex = 0
		Me.CmdActualizar.Text = "&Actualizar"
		Me.CmdActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.CmdActualizar.UseVisualStyleBackColor = False
		'
		'BotonActualizar
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Controls.Add(Me.CmdActualizar)
		Me.Name = "BotonActualizar"
		Me.Size = New System.Drawing.Size(102, 45)
		Me.ResumeLayout(False)

	End Sub

	Public WithEvents CmdActualizar As BotonEstandar
End Class
