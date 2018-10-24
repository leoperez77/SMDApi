<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fConfigDigitalizacion
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
		Me.LblDatos = New System.Windows.Forms.Label()
		Me.LnkEstadistica = New System.Windows.Forms.LinkLabel()
		Me.LnkConfiguracion = New System.Windows.Forms.LinkLabel()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(263, 0)
		'
		'LblDatos
		'
		Me.LblDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblDatos.Location = New System.Drawing.Point(12, 10)
		Me.LblDatos.Name = "LblDatos"
		Me.LblDatos.Size = New System.Drawing.Size(260, 216)
		Me.LblDatos.TabIndex = 0
		Me.LblDatos.Text = "Label1"
		'
		'LnkEstadistica
		'
		Me.LnkEstadistica.AutoSize = True
		Me.LnkEstadistica.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkEstadistica.Location = New System.Drawing.Point(33, 240)
		Me.LnkEstadistica.Name = "LnkEstadistica"
		Me.LnkEstadistica.Size = New System.Drawing.Size(60, 13)
		Me.LnkEstadistica.TabIndex = 1
		Me.LnkEstadistica.TabStop = True
		Me.LnkEstadistica.Text = "Estadística"
		'
		'LnkConfiguracion
		'
		Me.LnkConfiguracion.AutoSize = True
		Me.LnkConfiguracion.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkConfiguracion.Location = New System.Drawing.Point(194, 240)
		Me.LnkConfiguracion.Name = "LnkConfiguracion"
		Me.LnkConfiguracion.Size = New System.Drawing.Size(72, 13)
		Me.LnkConfiguracion.TabIndex = 2
		Me.LnkConfiguracion.TabStop = True
		Me.LnkConfiguracion.Text = "Configuración"
		'
		'fConfigDigitalizacion
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(284, 262)
		Me.Controls.Add(Me.LnkConfiguracion)
		Me.Controls.Add(Me.LnkEstadistica)
		Me.Controls.Add(Me.LblDatos)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "fConfigDigitalizacion"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Configuración"
		Me.Controls.SetChildIndex(Me.LblDatos, 0)
		Me.Controls.SetChildIndex(Me.LnkEstadistica, 0)
		Me.Controls.SetChildIndex(Me.LnkConfiguracion, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LblDatos As System.Windows.Forms.Label
    Friend WithEvents LnkEstadistica As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkConfiguracion As System.Windows.Forms.LinkLabel
End Class
