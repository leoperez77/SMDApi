<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fAdvanceOpciones
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fAdvanceOpciones))
		Me.LblIdUser = New System.Windows.Forms.Label()
		Me.LblPrueba = New System.Windows.Forms.Label()
		Me.LblEmpresa = New System.Windows.Forms.Label()
		Me.LblUsuAdv = New System.Windows.Forms.Label()
		Me.LblNodoAdvance = New System.Windows.Forms.Label()
		Me.LblVerAdv = New System.Windows.Forms.Label()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.JDMS_LblCerrar = New System.Windows.Forms.Label()
		Me.JDMS_LblCambiarLogo = New System.Windows.Forms.Label()
		Me.CmdReportes = New SMDPpal.BotonEstandar()
		Me.CmdLeameManual = New SMDPpal.BotonEstandar()
		Me.CmdImprimaPant = New SMDPpal.BotonEstandar()
		Me.CmdMisPermisos = New SMDPpal.BotonEstandar()
		Me.CmdObjetos = New SMDPpal.BotonEstandar()
		Me.LblTitulo = New System.Windows.Forms.Label()
		Me.JDMS_Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.LblIngles = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'LblIdUser
		'
		Me.LblIdUser.BackColor = System.Drawing.Color.Transparent
		Me.LblIdUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblIdUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblIdUser.ForeColor = System.Drawing.Color.White
		Me.LblIdUser.Location = New System.Drawing.Point(88, 91)
		Me.LblIdUser.Name = "LblIdUser"
		Me.LblIdUser.Size = New System.Drawing.Size(66, 18)
		Me.LblIdUser.TabIndex = 18
		Me.LblIdUser.Text = "25430"
		Me.LblIdUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ToolTip1.SetToolTip(Me.LblIdUser, "Id de este usuario")
		'
		'LblPrueba
		'
		Me.LblPrueba.AutoSize = True
		Me.LblPrueba.BackColor = System.Drawing.Color.Transparent
		Me.LblPrueba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblPrueba.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblPrueba.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.LblPrueba.Location = New System.Drawing.Point(12, 39)
		Me.LblPrueba.Name = "LblPrueba"
		Me.LblPrueba.Size = New System.Drawing.Size(42, 14)
		Me.LblPrueba.TabIndex = 17
		Me.LblPrueba.Text = "Prueba"
		Me.LblPrueba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LblEmpresa
		'
		Me.LblEmpresa.BackColor = System.Drawing.Color.Transparent
		Me.LblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblEmpresa.ForeColor = System.Drawing.Color.White
		Me.LblEmpresa.Location = New System.Drawing.Point(88, 108)
		Me.LblEmpresa.Name = "LblEmpresa"
		Me.LblEmpresa.Size = New System.Drawing.Size(137, 18)
		Me.LblEmpresa.TabIndex = 15
		Me.LblEmpresa.Text = "servitractor"
		Me.LblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblUsuAdv
		'
		Me.LblUsuAdv.BackColor = System.Drawing.Color.Transparent
		Me.LblUsuAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblUsuAdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblUsuAdv.ForeColor = System.Drawing.Color.White
		Me.LblUsuAdv.Location = New System.Drawing.Point(88, 75)
		Me.LblUsuAdv.Name = "LblUsuAdv"
		Me.LblUsuAdv.Size = New System.Drawing.Size(142, 18)
		Me.LblUsuAdv.TabIndex = 3
		Me.LblUsuAdv.Text = "juan.machuca@dms.ms"
		Me.LblUsuAdv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblNodoAdvance
		'
		Me.LblNodoAdvance.BackColor = System.Drawing.Color.Transparent
		Me.LblNodoAdvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblNodoAdvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblNodoAdvance.ForeColor = System.Drawing.Color.Blue
		Me.LblNodoAdvance.Location = New System.Drawing.Point(88, 125)
		Me.LblNodoAdvance.Name = "LblNodoAdvance"
		Me.LblNodoAdvance.Size = New System.Drawing.Size(81, 18)
		Me.LblNodoAdvance.TabIndex = 1
		Me.LblNodoAdvance.Text = "col"
		Me.LblNodoAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblVerAdv
		'
		Me.LblVerAdv.BackColor = System.Drawing.Color.Transparent
		Me.LblVerAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblVerAdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblVerAdv.ForeColor = System.Drawing.Color.White
		Me.LblVerAdv.Location = New System.Drawing.Point(175, 126)
		Me.LblVerAdv.Name = "LblVerAdv"
		Me.LblVerAdv.Size = New System.Drawing.Size(55, 18)
		Me.LblVerAdv.TabIndex = 12
		Me.LblVerAdv.Text = "14.1.295"
		Me.LblVerAdv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'JDMS_LblCerrar
		'
		Me.JDMS_LblCerrar.BackColor = System.Drawing.Color.Transparent
		Me.JDMS_LblCerrar.ForeColor = System.Drawing.Color.White
		Me.JDMS_LblCerrar.Location = New System.Drawing.Point(209, 40)
		Me.JDMS_LblCerrar.Name = "JDMS_LblCerrar"
		Me.JDMS_LblCerrar.Size = New System.Drawing.Size(21, 13)
		Me.JDMS_LblCerrar.TabIndex = 20
		Me.JDMS_LblCerrar.Text = "X"
		Me.JDMS_LblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ToolTip1.SetToolTip(Me.JDMS_LblCerrar, "Ocultar")
		'
		'JDMS_LblCambiarLogo
		'
		Me.JDMS_LblCambiarLogo.BackColor = System.Drawing.Color.Transparent
		Me.JDMS_LblCambiarLogo.ForeColor = System.Drawing.Color.White
		Me.JDMS_LblCambiarLogo.Location = New System.Drawing.Point(162, 40)
		Me.JDMS_LblCambiarLogo.Name = "JDMS_LblCambiarLogo"
		Me.JDMS_LblCambiarLogo.Size = New System.Drawing.Size(22, 13)
		Me.JDMS_LblCambiarLogo.TabIndex = 22
		Me.JDMS_LblCambiarLogo.Text = "<->"
		Me.JDMS_LblCambiarLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ToolTip1.SetToolTip(Me.JDMS_LblCambiarLogo, "Cambiar posición = Shift-F10")
		'
		'CmdReportes
		'
		Me.CmdReportes.BackColor = System.Drawing.Color.White
		Me.CmdReportes.BackgroundImage = CType(resources.GetObject("CmdReportes.BackgroundImage"), System.Drawing.Image)
		Me.CmdReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdReportes.ForeColor = System.Drawing.Color.White
		Me.CmdReportes.Location = New System.Drawing.Point(99, 167)
		Me.CmdReportes.Name = "CmdReportes"
		Me.CmdReportes.Size = New System.Drawing.Size(38, 35)
		Me.CmdReportes.TabIndex = 27
		Me.CmdReportes.Text = "Rep"
		Me.CmdReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.ToolTip1.SetToolTip(Me.CmdReportes, "Reportes de este programa")
		Me.CmdReportes.UseVisualStyleBackColor = False
		'
		'CmdLeameManual
		'
		Me.CmdLeameManual.BackColor = System.Drawing.Color.White
		Me.CmdLeameManual.BackgroundImage = CType(resources.GetObject("CmdLeameManual.BackgroundImage"), System.Drawing.Image)
		Me.CmdLeameManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdLeameManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdLeameManual.ForeColor = System.Drawing.Color.White
		Me.CmdLeameManual.Location = New System.Drawing.Point(54, 167)
		Me.CmdLeameManual.Name = "CmdLeameManual"
		Me.CmdLeameManual.Size = New System.Drawing.Size(38, 35)
		Me.CmdLeameManual.TabIndex = 26
		Me.CmdLeameManual.Text = "?"
		Me.CmdLeameManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.ToolTip1.SetToolTip(Me.CmdLeameManual, "Leame y Manual")
		Me.CmdLeameManual.UseVisualStyleBackColor = False
		'
		'CmdImprimaPant
		'
		Me.CmdImprimaPant.BackColor = System.Drawing.Color.White
		Me.CmdImprimaPant.BackgroundImage = CType(resources.GetObject("CmdImprimaPant.BackgroundImage"), System.Drawing.Image)
		Me.CmdImprimaPant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdImprimaPant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdImprimaPant.ForeColor = System.Drawing.Color.White
		Me.CmdImprimaPant.Location = New System.Drawing.Point(9, 167)
		Me.CmdImprimaPant.Name = "CmdImprimaPant"
		Me.CmdImprimaPant.Size = New System.Drawing.Size(38, 35)
		Me.CmdImprimaPant.TabIndex = 25
		Me.CmdImprimaPant.Text = "Imp"
		Me.CmdImprimaPant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.ToolTip1.SetToolTip(Me.CmdImprimaPant, "Imprimir pantalla")
		Me.CmdImprimaPant.UseVisualStyleBackColor = False
		'
		'CmdMisPermisos
		'
		Me.CmdMisPermisos.BackColor = System.Drawing.Color.White
		Me.CmdMisPermisos.BackgroundImage = CType(resources.GetObject("CmdMisPermisos.BackgroundImage"), System.Drawing.Image)
		Me.CmdMisPermisos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdMisPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdMisPermisos.ForeColor = System.Drawing.Color.White
		Me.CmdMisPermisos.Location = New System.Drawing.Point(189, 167)
		Me.CmdMisPermisos.Name = "CmdMisPermisos"
		Me.CmdMisPermisos.Size = New System.Drawing.Size(38, 35)
		Me.CmdMisPermisos.TabIndex = 24
		Me.CmdMisPermisos.Text = "Mis"
		Me.CmdMisPermisos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.ToolTip1.SetToolTip(Me.CmdMisPermisos, "Mis permisos")
		Me.CmdMisPermisos.UseVisualStyleBackColor = False
		'
		'CmdObjetos
		'
		Me.CmdObjetos.BackColor = System.Drawing.Color.White
		Me.CmdObjetos.BackgroundImage = CType(resources.GetObject("CmdObjetos.BackgroundImage"), System.Drawing.Image)
		Me.CmdObjetos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdObjetos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdObjetos.ForeColor = System.Drawing.Color.White
		Me.CmdObjetos.Location = New System.Drawing.Point(144, 167)
		Me.CmdObjetos.Name = "CmdObjetos"
		Me.CmdObjetos.Size = New System.Drawing.Size(38, 35)
		Me.CmdObjetos.TabIndex = 23
		Me.CmdObjetos.Text = "Obj"
		Me.CmdObjetos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.ToolTip1.SetToolTip(Me.CmdObjetos, "Modificar objetos de la pantalla")
		Me.CmdObjetos.UseVisualStyleBackColor = False
		'
		'LblTitulo
		'
		Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
		Me.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblTitulo.ForeColor = System.Drawing.Color.White
		Me.LblTitulo.Location = New System.Drawing.Point(8, 144)
		Me.LblTitulo.Name = "LblTitulo"
		Me.LblTitulo.Size = New System.Drawing.Size(222, 18)
		Me.LblTitulo.TabIndex = 21
		Me.LblTitulo.Text = "1901 Items"
		Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'JDMS_Timer1
		'
		Me.JDMS_Timer1.Interval = 7000
		'
		'LblIngles
		'
		Me.LblIngles.BackColor = System.Drawing.Color.Gray
		Me.LblIngles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblIngles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.LblIngles.Location = New System.Drawing.Point(5, 77)
		Me.LblIngles.Name = "LblIngles"
		Me.LblIngles.Size = New System.Drawing.Size(77, 67)
		Me.LblIngles.TabIndex = 28
		Me.LblIngles.Text = "USER:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ID:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Company:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NODE:"
		'
		'fAdvanceOpciones
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.SystemColors.MenuBar
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(236, 212)
		Me.Controls.Add(Me.LblIngles)
		Me.Controls.Add(Me.CmdReportes)
		Me.Controls.Add(Me.CmdLeameManual)
		Me.Controls.Add(Me.CmdImprimaPant)
		Me.Controls.Add(Me.CmdMisPermisos)
		Me.Controls.Add(Me.CmdObjetos)
		Me.Controls.Add(Me.JDMS_LblCambiarLogo)
		Me.Controls.Add(Me.LblTitulo)
		Me.Controls.Add(Me.JDMS_LblCerrar)
		Me.Controls.Add(Me.LblIdUser)
		Me.Controls.Add(Me.LblPrueba)
		Me.Controls.Add(Me.LblVerAdv)
		Me.Controls.Add(Me.LblEmpresa)
		Me.Controls.Add(Me.LblUsuAdv)
		Me.Controls.Add(Me.LblNodoAdvance)
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.KeyPreview = True
		Me.Name = "fAdvanceOpciones"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.TransparencyKey = System.Drawing.SystemColors.MenuBar
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LblUsuAdv As System.Windows.Forms.Label
    Friend WithEvents LblNodoAdvance As System.Windows.Forms.Label
    Friend WithEvents LblVerAdv As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LblEmpresa As System.Windows.Forms.Label
    Friend WithEvents LblPrueba As System.Windows.Forms.Label
    Friend WithEvents LblIdUser As System.Windows.Forms.Label
    Friend WithEvents JDMS_LblCerrar As System.Windows.Forms.Label
    Public WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents JDMS_Timer1 As System.Windows.Forms.Timer
    Friend WithEvents JDMS_LblCambiarLogo As System.Windows.Forms.Label
    Friend WithEvents CmdObjetos As BotonEstandar
    Friend WithEvents CmdMisPermisos As BotonEstandar
    Friend WithEvents CmdImprimaPant As BotonEstandar
    Friend WithEvents CmdLeameManual As BotonEstandar
    Friend WithEvents CmdReportes As BotonEstandar
	Friend WithEvents LblIngles As Label
End Class
