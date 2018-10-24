<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDatosPantallazo
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
		Me.TxtExplica = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.LblProg = New System.Windows.Forms.Label()
		Me.LblRef = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.CmdCancel = New System.Windows.Forms.Button()
		Me.CmdGuardar = New System.Windows.Forms.Button()
		Me.LnkVerPant = New System.Windows.Forms.LinkLabel()
		Me.OptPublica = New System.Windows.Forms.RadioButton()
		Me.OptPrivada = New System.Windows.Forms.RadioButton()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.ChkVentanaActiva = New System.Windows.Forms.RadioButton()
		Me.GrpDonde = New System.Windows.Forms.GroupBox()
		Me.OptBDCliente = New System.Windows.Forms.RadioButton()
		Me.OptMiCuenta = New System.Windows.Forms.RadioButton()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GrpDonde.SuspendLayout()
		Me.SuspendLayout()
		'
		'TxtExplica
		'
		Me.TxtExplica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtExplica.Location = New System.Drawing.Point(75, 64)
		Me.TxtExplica.MaxLength = 250
		Me.TxtExplica.Multiline = True
		Me.TxtExplica.Name = "TxtExplica"
		Me.TxtExplica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TxtExplica.Size = New System.Drawing.Size(272, 102)
		Me.TxtExplica.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(7, 66)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(61, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Explicación"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(7, 9)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(55, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Programa:"
		'
		'LblProg
		'
		Me.LblProg.AutoSize = True
		Me.LblProg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblProg.Location = New System.Drawing.Point(72, 9)
		Me.LblProg.Name = "LblProg"
		Me.LblProg.Size = New System.Drawing.Size(60, 13)
		Me.LblProg.TabIndex = 5
		Me.LblProg.Text = "Programa"
		'
		'LblRef
		'
		Me.LblRef.AutoSize = True
		Me.LblRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblRef.Location = New System.Drawing.Point(72, 30)
		Me.LblRef.Name = "LblRef"
		Me.LblRef.Size = New System.Drawing.Size(73, 13)
		Me.LblRef.TabIndex = 7
		Me.LblRef.Text = "Referencia:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(7, 30)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(62, 13)
		Me.Label5.TabIndex = 6
		Me.Label5.Text = "Referencia:"
		'
		'CmdCancel
		'
		Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancel.Location = New System.Drawing.Point(271, 311)
		Me.CmdCancel.Name = "CmdCancel"
		Me.CmdCancel.Size = New System.Drawing.Size(75, 23)
		Me.CmdCancel.TabIndex = 9
		Me.CmdCancel.Text = "Cancelar"
		Me.CmdCancel.UseVisualStyleBackColor = True
		'
		'CmdGuardar
		'
		Me.CmdGuardar.Location = New System.Drawing.Point(190, 311)
		Me.CmdGuardar.Name = "CmdGuardar"
		Me.CmdGuardar.Size = New System.Drawing.Size(75, 23)
		Me.CmdGuardar.TabIndex = 10
		Me.CmdGuardar.Text = "Guardar"
		Me.CmdGuardar.UseVisualStyleBackColor = True
		'
		'LnkVerPant
		'
		Me.LnkVerPant.AutoSize = True
		Me.LnkVerPant.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkVerPant.Location = New System.Drawing.Point(19, 316)
		Me.LnkVerPant.Name = "LnkVerPant"
		Me.LnkVerPant.Size = New System.Drawing.Size(133, 13)
		Me.LnkVerPant.TabIndex = 11
		Me.LnkVerPant.TabStop = True
		Me.LnkVerPant.Text = "Ver mis pantallazos (Menú)"
		'
		'OptPublica
		'
		Me.OptPublica.AutoSize = True
		Me.OptPublica.Checked = True
		Me.OptPublica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.OptPublica.Location = New System.Drawing.Point(27, 20)
		Me.OptPublica.Name = "OptPublica"
		Me.OptPublica.Size = New System.Drawing.Size(132, 17)
		Me.OptPublica.TabIndex = 12
		Me.OptPublica.TabStop = True
		Me.OptPublica.Text = "Personas que yo invite"
		Me.OptPublica.UseVisualStyleBackColor = True
		'
		'OptPrivada
		'
		Me.OptPrivada.AutoSize = True
		Me.OptPrivada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.OptPrivada.Location = New System.Drawing.Point(27, 43)
		Me.OptPrivada.Name = "OptPrivada"
		Me.OptPrivada.Size = New System.Drawing.Size(60, 17)
		Me.OptPrivada.TabIndex = 13
		Me.OptPrivada.Text = "Solo yo"
		Me.OptPrivada.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.OptPrivada)
		Me.GroupBox1.Controls.Add(Me.OptPublica)
		Me.GroupBox1.Location = New System.Drawing.Point(15, 186)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(165, 63)
		Me.GroupBox1.TabIndex = 14
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Quién puede ver esta imagen"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.RadioButton1)
		Me.GroupBox2.Controls.Add(Me.ChkVentanaActiva)
		Me.GroupBox2.Location = New System.Drawing.Point(198, 186)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(151, 63)
		Me.GroupBox2.TabIndex = 0
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Tamaño de la imagen"
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.RadioButton1.Location = New System.Drawing.Point(25, 42)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(101, 17)
		Me.RadioButton1.TabIndex = 15
		Me.RadioButton1.Text = "Toda la pantalla"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'ChkVentanaActiva
		'
		Me.ChkVentanaActiva.AutoSize = True
		Me.ChkVentanaActiva.Checked = True
		Me.ChkVentanaActiva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.ChkVentanaActiva.Location = New System.Drawing.Point(25, 19)
		Me.ChkVentanaActiva.Name = "ChkVentanaActiva"
		Me.ChkVentanaActiva.Size = New System.Drawing.Size(98, 17)
		Me.ChkVentanaActiva.TabIndex = 14
		Me.ChkVentanaActiva.TabStop = True
		Me.ChkVentanaActiva.Text = "Ventana Activa"
		Me.ChkVentanaActiva.UseVisualStyleBackColor = True
		'
		'GrpDonde
		'
		Me.GrpDonde.Controls.Add(Me.OptBDCliente)
		Me.GrpDonde.Controls.Add(Me.OptMiCuenta)
		Me.GrpDonde.Location = New System.Drawing.Point(66, 255)
		Me.GrpDonde.Name = "GrpDonde"
		Me.GrpDonde.Size = New System.Drawing.Size(247, 40)
		Me.GrpDonde.TabIndex = 15
		Me.GrpDonde.TabStop = False
		Me.GrpDonde.Text = "Donde guardar la imagen"
		'
		'OptBDCliente
		'
		Me.OptBDCliente.AutoSize = True
		Me.OptBDCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.OptBDCliente.Location = New System.Drawing.Point(129, 17)
		Me.OptBDCliente.Name = "OptBDCliente"
		Me.OptBDCliente.Size = New System.Drawing.Size(118, 17)
		Me.OptBDCliente.TabIndex = 15
		Me.OptBDCliente.Text = "En la BD del cliente"
		Me.OptBDCliente.UseVisualStyleBackColor = True
		'
		'OptMiCuenta
		'
		Me.OptMiCuenta.AutoSize = True
		Me.OptMiCuenta.Checked = True
		Me.OptMiCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.OptMiCuenta.Location = New System.Drawing.Point(34, 19)
		Me.OptMiCuenta.Name = "OptMiCuenta"
		Me.OptMiCuenta.Size = New System.Drawing.Size(69, 17)
		Me.OptMiCuenta.TabIndex = 14
		Me.OptMiCuenta.TabStop = True
		Me.OptMiCuenta.Text = "En mi BD"
		Me.OptMiCuenta.UseVisualStyleBackColor = True
		'
		'fDatosPantallazo
		'
		Me.AcceptButton = Me.CmdGuardar
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.CmdCancel
		Me.ClientSize = New System.Drawing.Size(358, 346)
		Me.ControlBox = False
		Me.Controls.Add(Me.GrpDonde)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.LnkVerPant)
		Me.Controls.Add(Me.CmdGuardar)
		Me.Controls.Add(Me.CmdCancel)
		Me.Controls.Add(Me.LblRef)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.LblProg)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TxtExplica)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "fDatosPantallazo"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Guardar pantalla"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GrpDonde.ResumeLayout(False)
		Me.GrpDonde.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TxtExplica As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblProg As System.Windows.Forms.Label
    Friend WithEvents LblRef As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents CmdGuardar As System.Windows.Forms.Button
    Friend WithEvents LnkVerPant As System.Windows.Forms.LinkLabel
    Friend WithEvents OptPublica As System.Windows.Forms.RadioButton
    Friend WithEvents OptPrivada As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ChkVentanaActiva As System.Windows.Forms.RadioButton
    Friend WithEvents GrpDonde As System.Windows.Forms.GroupBox
    Friend WithEvents OptBDCliente As System.Windows.Forms.RadioButton
    Friend WithEvents OptMiCuenta As System.Windows.Forms.RadioButton
End Class
