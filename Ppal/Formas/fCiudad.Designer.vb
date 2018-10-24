<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCiudad
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCiudad))
		Me.CmdAceptar = New SMDPpal.BotonEstandar()
		Me.CmdCancel = New SMDPpal.BotonEstandar()
		Me.PnlPais = New System.Windows.Forms.Panel()
		Me.CbPais_Ciudad = New SMDPpal.ComboDMS()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.Label35 = New System.Windows.Forms.Label()
		Me.Label34 = New System.Windows.Forms.Label()
		Me.CbPais_Depto = New System.Windows.Forms.ComboBox()
		Me.CbPais_Pais = New System.Windows.Forms.ComboBox()
		Me.LblAyuda = New System.Windows.Forms.Label()
		Me.Grd = New SMDPpal.GridDms()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LblCuenta = New System.Windows.Forms.Label()
		Me.PnlPais.SuspendLayout()
		Me.SuspendLayout()
		'
		'CmdAceptar
		'
		Me.CmdAceptar.BackColor = System.Drawing.Color.White
		Me.CmdAceptar.BackgroundImage = CType(resources.GetObject("CmdAceptar.BackgroundImage"), System.Drawing.Image)
		Me.CmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdAceptar.ForeColor = System.Drawing.Color.White
		Me.CmdAceptar.Location = New System.Drawing.Point(143, 74)
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(101, 38)
		Me.CmdAceptar.TabIndex = 0
		Me.CmdAceptar.Text = "Aceptar"
		Me.CmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdAceptar.UseVisualStyleBackColor = False
		'
		'CmdCancel
		'
		Me.CmdCancel.BackColor = System.Drawing.Color.White
		Me.CmdCancel.BackgroundImage = CType(resources.GetObject("CmdCancel.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancel.ForeColor = System.Drawing.Color.White
		Me.CmdCancel.Location = New System.Drawing.Point(246, 74)
		Me.CmdCancel.Name = "CmdCancel"
		Me.CmdCancel.Size = New System.Drawing.Size(112, 38)
		Me.CmdCancel.TabIndex = 5
		Me.CmdCancel.Text = "Usar ciudad del cliente"
		Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancel.UseVisualStyleBackColor = False
		'
		'PnlPais
		'
		Me.PnlPais.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.PnlPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlPais.Controls.Add(Me.CbPais_Ciudad)
		Me.PnlPais.Controls.Add(Me.LinkLabel1)
		Me.PnlPais.Controls.Add(Me.Label35)
		Me.PnlPais.Controls.Add(Me.LblAyuda)
		Me.PnlPais.Controls.Add(Me.Label34)
		Me.PnlPais.Controls.Add(Me.CbPais_Depto)
		Me.PnlPais.Controls.Add(Me.CmdCancel)
		Me.PnlPais.Controls.Add(Me.CmdAceptar)
		Me.PnlPais.Controls.Add(Me.CbPais_Pais)
		Me.PnlPais.Location = New System.Drawing.Point(6, 18)
		Me.PnlPais.Name = "PnlPais"
		Me.PnlPais.Size = New System.Drawing.Size(363, 117)
		Me.PnlPais.TabIndex = 44
		'
		'CbPais_Ciudad
		'
		Me.CbPais_Ciudad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.CbPais_Ciudad.Location = New System.Drawing.Point(63, 47)
		Me.CbPais_Ciudad.Name = "CbPais_Ciudad"
		Me.CbPais_Ciudad.Size = New System.Drawing.Size(297, 21)
		Me.CbPais_Ciudad.TabIndex = 3
		'
		'LinkLabel1
		'
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel1.Location = New System.Drawing.Point(4, 5)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(29, 13)
		Me.LinkLabel1.TabIndex = 0
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "País"
		'
		'Label35
		'
		Me.Label35.AutoSize = True
		Me.Label35.Location = New System.Drawing.Point(4, 50)
		Me.Label35.Name = "Label35"
		Me.Label35.Size = New System.Drawing.Size(40, 13)
		Me.Label35.TabIndex = 4
		Me.Label35.Text = "Ciudad"
		Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label34
		'
		Me.Label34.AutoSize = True
		Me.Label34.Location = New System.Drawing.Point(4, 27)
		Me.Label34.Name = "Label34"
		Me.Label34.Size = New System.Drawing.Size(36, 13)
		Me.Label34.TabIndex = 2
		Me.Label34.Text = "Depto"
		Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'CbPais_Depto
		'
		Me.CbPais_Depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbPais_Depto.FormattingEnabled = True
		Me.CbPais_Depto.Location = New System.Drawing.Point(63, 24)
		Me.CbPais_Depto.Name = "CbPais_Depto"
		Me.CbPais_Depto.Size = New System.Drawing.Size(295, 21)
		Me.CbPais_Depto.TabIndex = 2
		'
		'CbPais_Pais
		'
		Me.CbPais_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbPais_Pais.FormattingEnabled = True
		Me.CbPais_Pais.Location = New System.Drawing.Point(63, 1)
		Me.CbPais_Pais.Name = "CbPais_Pais"
		Me.CbPais_Pais.Size = New System.Drawing.Size(295, 21)
		Me.CbPais_Pais.TabIndex = 1
		'
		'LblAyuda
		'
		Me.LblAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAyuda.ForeColor = System.Drawing.Color.Maroon
		Me.LblAyuda.Location = New System.Drawing.Point(5, 74)
		Me.LblAyuda.Name = "LblAyuda"
		Me.LblAyuda.Size = New System.Drawing.Size(133, 38)
		Me.LblAyuda.TabIndex = 45
		Me.LblAyuda.Text = "Solo muestra las ciudades asignadas a la bodega actual. Rn#102 [ciudad_bod]"
		Me.LblAyuda.Visible = False
		'
		'Grd
		'
		Me.Grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Grd.DMSCopiarDt = True
		Me.Grd.DMSTituloDelInforme = ""
		Me.Grd.Location = New System.Drawing.Point(7, 176)
		Me.Grd.Name = "Grd"
		Me.Grd.Size = New System.Drawing.Size(366, 119)
		Me.Grd.TabIndex = 46
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(7, 160)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(110, 13)
		Me.Label1.TabIndex = 47
		Me.Label1.Text = "Seleccione la cuenta "
		'
		'LblCuenta
		'
		Me.LblCuenta.AutoSize = True
		Me.LblCuenta.ForeColor = System.Drawing.Color.Maroon
		Me.LblCuenta.Location = New System.Drawing.Point(177, 160)
		Me.LblCuenta.Name = "LblCuenta"
		Me.LblCuenta.Size = New System.Drawing.Size(41, 13)
		Me.LblCuenta.TabIndex = 48
		Me.LblCuenta.Text = "Cuenta"
		'
		'fCiudad
		'
		Me.AcceptButton = Me.CmdAceptar
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.CmdCancel
		Me.ClientSize = New System.Drawing.Size(378, 299)
		Me.ControlBox = False
		Me.Controls.Add(Me.LblCuenta)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Grd)
		Me.Controls.Add(Me.PnlPais)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "fCiudad"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Seleccione ciudad (RN#102 [ciudad])"
		Me.TopMost = True
		Me.PnlPais.ResumeLayout(False)
		Me.PnlPais.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents CmdAceptar As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancel As SMDPpal.BotonEstandar
    Friend WithEvents PnlPais As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
	Friend WithEvents CbPais_Depto As System.Windows.Forms.ComboBox
	Friend WithEvents CbPais_Pais As System.Windows.Forms.ComboBox
	Friend WithEvents CbPais_Ciudad As ComboDMS
	Friend WithEvents LblAyuda As Label
	Friend WithEvents Grd As GridDms
	Friend WithEvents Label1 As Label
	Public WithEvents LblCuenta As Label
End Class
