<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fReglasNegocio
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fReglasNegocio))
		Me.LblEncabezado = New System.Windows.Forms.Label()
		Me.ChAbrir = New System.Windows.Forms.CheckBox()
		Me.Grd = New SMDPpal.GridDms()
		Me.CmdCancel = New SMDPpal.BotonEstandar()
		Me.CmdCancel2 = New SMDPpal.BotonEstandar()
		Me.SuspendLayout()
		'
		'LblEncabezado
		'
		Me.LblEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblEncabezado.Location = New System.Drawing.Point(30, 0)
		Me.LblEncabezado.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
		Me.LblEncabezado.Name = "LblEncabezado"
		Me.LblEncabezado.Size = New System.Drawing.Size(926, 50)
		Me.LblEncabezado.TabIndex = 1
		Me.LblEncabezado.Text = "Haga doble clic en la regla que desee modificar. "
		Me.LblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ChAbrir
		'
		Me.ChAbrir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.ChAbrir.AutoSize = True
		Me.ChAbrir.Checked = True
		Me.ChAbrir.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ChAbrir.Location = New System.Drawing.Point(33, 624)
		Me.ChAbrir.Name = "ChAbrir"
		Me.ChAbrir.Size = New System.Drawing.Size(197, 17)
		Me.ChAbrir.TabIndex = 3
		Me.ChAbrir.Text = "Abrir siempre al iniciar este programa"
		Me.ChAbrir.UseVisualStyleBackColor = True
		'
		'Grd
		'
		Me.Grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Grd.DMSCopiarDt = True
		Me.Grd.DMSTituloDelInforme = ""
		Me.Grd.Location = New System.Drawing.Point(30, 53)
		Me.Grd.Name = "Grd"
		Me.Grd.Size = New System.Drawing.Size(926, 546)
		Me.Grd.TabIndex = 0
		'
		'CmdCancel
		'
		Me.CmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdCancel.BackColor = System.Drawing.Color.White
		Me.CmdCancel.BackgroundImage = CType(resources.GetObject("CmdCancel.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancel.ForeColor = System.Drawing.Color.White
		Me.CmdCancel.Location = New System.Drawing.Point(552, 615)
		Me.CmdCancel.Name = "CmdCancel"
		Me.CmdCancel.Size = New System.Drawing.Size(192, 32)
		Me.CmdCancel.TabIndex = 4
		Me.CmdCancel.Text = "Cerrar y mostrar de nuevo"
		Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancel.UseVisualStyleBackColor = False
		'
		'CmdCancel2
		'
		Me.CmdCancel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdCancel2.BackColor = System.Drawing.Color.White
		Me.CmdCancel2.BackgroundImage = CType(resources.GetObject("CmdCancel2.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancel2.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancel2.ForeColor = System.Drawing.Color.White
		Me.CmdCancel2.Location = New System.Drawing.Point(750, 615)
		Me.CmdCancel2.Name = "CmdCancel2"
		Me.CmdCancel2.Size = New System.Drawing.Size(208, 32)
		Me.CmdCancel2.TabIndex = 5
		Me.CmdCancel2.Text = "Cerrar y no mostrar más"
		Me.CmdCancel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancel2.UseVisualStyleBackColor = False
		'
		'fReglasNegocio
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.CmdCancel
		Me.ClientSize = New System.Drawing.Size(984, 661)
		Me.ControlBox = False
		Me.Controls.Add(Me.CmdCancel2)
		Me.Controls.Add(Me.CmdCancel)
		Me.Controls.Add(Me.ChAbrir)
		Me.Controls.Add(Me.LblEncabezado)
		Me.Controls.Add(Me.Grd)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.MinimumSize = New System.Drawing.Size(584, 443)
		Me.Name = "fReglasNegocio"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Configuración"
		Me.TopMost = True
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Grd As SMDPpal.GridDms
    Friend WithEvents LblEncabezado As System.Windows.Forms.Label
    Friend WithEvents ChAbrir As System.Windows.Forms.CheckBox
    Friend WithEvents CmdCancel As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancel2 As SMDPpal.BotonEstandar
End Class
