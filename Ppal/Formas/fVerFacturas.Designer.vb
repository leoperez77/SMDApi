<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fVerFacturas
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fVerFacturas))
		Me.GrdFac = New SMDPpal.GridDms()
		Me.CtrImprimir1 = New SMDPpal.CtrImprimir()
		Me.CmdImprimir = New SMDPpal.BotonEstandar()
		Me.ChkFormato = New System.Windows.Forms.CheckBox()
		Me.ChkOriginal = New System.Windows.Forms.CheckBox()
		Me.CmdCancelar = New SMDPpal.BotonEstandar()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(627, 0)
		'
		'GrdFac
		'
		Me.GrdFac.DMSCopiarDt = True
		Me.GrdFac.DMSTituloDelInforme = ""
		Me.GrdFac.Location = New System.Drawing.Point(25, 28)
		Me.GrdFac.Name = "GrdFac"
		Me.GrdFac.Size = New System.Drawing.Size(624, 293)
		Me.GrdFac.TabIndex = 0
		'
		'CtrImprimir1
		'
		Me.CtrImprimir1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.CtrImprimir1.DMSNombreForma = "fVerFacturas"
		Me.CtrImprimir1.DMSVerOpcionCruzar = False
		Me.CtrImprimir1.Location = New System.Drawing.Point(230, 327)
		Me.CtrImprimir1.Name = "CtrImprimir1"
		Me.CtrImprimir1.Size = New System.Drawing.Size(117, 58)
		Me.CtrImprimir1.TabIndex = 12
		'
		'CmdImprimir
		'
		Me.CmdImprimir.BackColor = System.Drawing.Color.White
		Me.CmdImprimir.BackgroundImage = CType(resources.GetObject("CmdImprimir.BackgroundImage"), System.Drawing.Image)
		Me.CmdImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdImprimir.ForeColor = System.Drawing.Color.White
		Me.CmdImprimir.Location = New System.Drawing.Point(358, 337)
		Me.CmdImprimir.Name = "CmdImprimir"
		Me.CmdImprimir.Size = New System.Drawing.Size(104, 36)
		Me.CmdImprimir.TabIndex = 13
		Me.CmdImprimir.Text = "Hacer reporte"
		Me.CmdImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdImprimir.UseVisualStyleBackColor = False
		'
		'ChkFormato
		'
		Me.ChkFormato.AutoSize = True
		Me.ChkFormato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkFormato.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ChkFormato.Location = New System.Drawing.Point(12, 338)
		Me.ChkFormato.Name = "ChkFormato"
		Me.ChkFormato.Size = New System.Drawing.Size(120, 17)
		Me.ChkFormato.TabIndex = 149
		Me.ChkFormato.Text = "Seleccionar formato"
		Me.ChkFormato.UseVisualStyleBackColor = True
		'
		'ChkOriginal
		'
		Me.ChkOriginal.AutoSize = True
		Me.ChkOriginal.Location = New System.Drawing.Point(12, 360)
		Me.ChkOriginal.Name = "ChkOriginal"
		Me.ChkOriginal.Size = New System.Drawing.Size(89, 17)
		Me.ChkOriginal.TabIndex = 150
		Me.ChkOriginal.Text = "Como original"
		Me.ChkOriginal.UseVisualStyleBackColor = True
		'
		'CmdCancelar
		'
		Me.CmdCancelar.BackColor = System.Drawing.Color.White
		Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancelar.ForeColor = System.Drawing.Color.White
		Me.CmdCancelar.Location = New System.Drawing.Point(468, 337)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(104, 36)
		Me.CmdCancelar.TabIndex = 151
		Me.CmdCancelar.Text = "Cancelar"
		Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancelar.UseVisualStyleBackColor = False
		'
		'fVerFacturas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.CmdCancelar
		Me.ClientSize = New System.Drawing.Size(648, 389)
		Me.Controls.Add(Me.CmdCancelar)
		Me.Controls.Add(Me.ChkOriginal)
		Me.Controls.Add(Me.ChkFormato)
		Me.Controls.Add(Me.CmdImprimir)
		Me.Controls.Add(Me.CtrImprimir1)
		Me.Controls.Add(Me.GrdFac)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "fVerFacturas"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Factura(s) producida(s)"
		Me.Controls.SetChildIndex(Me.GrdFac, 0)
		Me.Controls.SetChildIndex(Me.CtrImprimir1, 0)
		Me.Controls.SetChildIndex(Me.CmdImprimir, 0)
		Me.Controls.SetChildIndex(Me.ChkFormato, 0)
		Me.Controls.SetChildIndex(Me.ChkOriginal, 0)
		Me.Controls.SetChildIndex(Me.CmdCancelar, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GrdFac As GridDms
    Friend WithEvents CtrImprimir1 As CtrImprimir
    Friend WithEvents CmdImprimir As BotonEstandar
    Friend WithEvents ChkFormato As CheckBox
    Friend WithEvents ChkOriginal As CheckBox
    Friend WithEvents CmdCancelar As BotonEstandar
End Class
