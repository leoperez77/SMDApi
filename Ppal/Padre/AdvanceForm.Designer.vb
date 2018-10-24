<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvanceForm
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvanceForm))
		Me.PicPuntoAdv = New System.Windows.Forms.PictureBox()
		Me.ToolTipAdvance = New System.Windows.Forms.ToolTip(Me.components)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.PicPuntoAdv.BackColor = System.Drawing.Color.White
		Me.PicPuntoAdv.Cursor = System.Windows.Forms.Cursors.Help
		Me.PicPuntoAdv.Image = CType(resources.GetObject("PicPuntoAdv.Image"), System.Drawing.Image)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(66, 51)
		Me.PicPuntoAdv.Name = "PicPuntoAdv"
		Me.PicPuntoAdv.Size = New System.Drawing.Size(22, 22)
		Me.PicPuntoAdv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PicPuntoAdv.TabIndex = 4
		Me.PicPuntoAdv.TabStop = False
		'
		'AdvanceForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(150, 126)
		Me.Controls.Add(Me.PicPuntoAdv)
		Me.KeyPreview = True
		Me.Name = "AdvanceForm"
		Me.Text = "Advance Form"
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Public WithEvents PicPuntoAdv As System.Windows.Forms.PictureBox
	Public WithEvents ToolTipAdvance As ToolTip
End Class
