<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fInfExtUAFE
    Inherits AdvanceForm

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fInfExtUAFE))
		Me.PnlDoc = New System.Windows.Forms.Panel()
		Me.CmbTipo = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TxtIdentificacion = New System.Windows.Forms.TextBox()
		Me.TxtNombres = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.CmdAceptar = New SMDPpal.BotonEstandar()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PnlDoc.SuspendLayout()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(552, 0)
		'
		'PnlDoc
		'
		Me.PnlDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlDoc.Controls.Add(Me.CmbTipo)
		Me.PnlDoc.Controls.Add(Me.Label6)
		Me.PnlDoc.Controls.Add(Me.TxtIdentificacion)
		Me.PnlDoc.Controls.Add(Me.TxtNombres)
		Me.PnlDoc.Controls.Add(Me.Label1)
		Me.PnlDoc.Controls.Add(Me.Label2)
		Me.PnlDoc.Location = New System.Drawing.Point(12, 12)
		Me.PnlDoc.Name = "PnlDoc"
		Me.PnlDoc.Size = New System.Drawing.Size(481, 80)
		Me.PnlDoc.TabIndex = 5
		'
		'CmbTipo
		'
		Me.CmbTipo.FormattingEnabled = True
		Me.CmbTipo.Location = New System.Drawing.Point(115, 4)
		Me.CmbTipo.Name = "CmbTipo"
		Me.CmbTipo.Size = New System.Drawing.Size(100, 21)
		Me.CmbTipo.TabIndex = 0
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(8, 52)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(101, 13)
		Me.Label6.TabIndex = 6
		Me.Label6.Text = "Nombres Completos"
		'
		'TxtIdentificacion
		'
		Me.TxtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtIdentificacion.Location = New System.Drawing.Point(115, 26)
		Me.TxtIdentificacion.MaxLength = 20
		Me.TxtIdentificacion.Name = "TxtIdentificacion"
		Me.TxtIdentificacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TxtIdentificacion.Size = New System.Drawing.Size(100, 20)
		Me.TxtIdentificacion.TabIndex = 1
		'
		'TxtNombres
		'
		Me.TxtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtNombres.Location = New System.Drawing.Point(115, 48)
		Me.TxtNombres.MaxLength = 200
		Me.TxtNombres.Name = "TxtNombres"
		Me.TxtNombres.Size = New System.Drawing.Size(361, 20)
		Me.TxtNombres.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(28, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Tipo"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 30)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(70, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Identificación"
		'
		'CmdAceptar
		'
		Me.CmdAceptar.BackColor = System.Drawing.Color.White
		Me.CmdAceptar.BackgroundImage = CType(resources.GetObject("CmdAceptar.BackgroundImage"), System.Drawing.Image)
		Me.CmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdAceptar.ForeColor = System.Drawing.Color.White
		Me.CmdAceptar.Location = New System.Drawing.Point(499, 30)
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(66, 38)
		Me.CmdAceptar.TabIndex = 3
		Me.CmdAceptar.Text = "Aceptar"
		Me.CmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdAceptar.UseVisualStyleBackColor = False
		'
		'fInfExtUAFE
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(573, 103)
		Me.Controls.Add(Me.CmdAceptar)
		Me.Controls.Add(Me.PnlDoc)
		Me.Name = "fInfExtUAFE"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "UAFE - Pago de terceros"
		Me.Controls.SetChildIndex(Me.PnlDoc, 0)
		Me.Controls.SetChildIndex(Me.CmdAceptar, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PnlDoc.ResumeLayout(False)
		Me.PnlDoc.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Public WithEvents PnlDoc As Panel
    Public WithEvents Label6 As Label
    Public WithEvents TxtIdentificacion As TextBox
    Public WithEvents TxtNombres As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents Label2 As Label
    Friend WithEvents CmdAceptar As BotonEstandar
    Friend WithEvents CmbTipo As ComboBox
End Class
