<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCamposAdicionales
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCamposAdicionales))
		Me.CmdOK = New SMDPpal.BotonEstandar()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TxtNro = New System.Windows.Forms.TextBox()
		Me.TxtTitulo = New System.Windows.Forms.TextBox()
		Me.CbTipoDato = New System.Windows.Forms.ComboBox()
		Me.ChkRequerido = New System.Windows.Forms.CheckBox()
		Me.PnlFecha = New System.Windows.Forms.Panel()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.ChkMaxCualquiera = New System.Windows.Forms.RadioButton()
		Me.TxtFecMax = New System.Windows.Forms.DateTimePicker()
		Me.ChkFechaMaxima = New System.Windows.Forms.RadioButton()
		Me.ChkFechaMaximoHoy = New System.Windows.Forms.RadioButton()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.ChkMinCualquiera = New System.Windows.Forms.RadioButton()
		Me.ChkFechaMinima = New System.Windows.Forms.RadioButton()
		Me.ChkFechaMinimaHoy = New System.Windows.Forms.RadioButton()
		Me.TxtFecMin = New System.Windows.Forms.DateTimePicker()
		Me.PnlCombo1 = New System.Windows.Forms.Panel()
		Me.LstDel = New System.Windows.Forms.ListBox()
		Me.LstMult = New System.Windows.Forms.ListBox()
		Me.CmdMultipleDel = New SMDPpal.BotonEstandar()
		Me.CmdMultipleAdi = New SMDPpal.BotonEstandar()
		Me.TxtMultipleTex = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.ChkNegativo = New System.Windows.Forms.CheckBox()
		Me.PnlTexto = New System.Windows.Forms.Panel()
		Me.TxtLongitud = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.LnkNuevo = New System.Windows.Forms.LinkLabel()
		Me.ChkAnulado = New System.Windows.Forms.CheckBox()
		Me.LnkEliminar = New System.Windows.Forms.LinkLabel()
		Me.PnlNegativo = New System.Windows.Forms.Panel()
		Me.PnlCombo = New System.Windows.Forms.Panel()
		Me.Grd = New SMDPpal.GridDms()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PnlFecha.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.PnlCombo1.SuspendLayout()
		Me.PnlTexto.SuspendLayout()
		Me.PnlNegativo.SuspendLayout()
		Me.PnlCombo.SuspendLayout()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(491, 0)
		'
		'CmdOK
		'
		Me.CmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.CmdOK.BackgroundImage = CType(resources.GetObject("CmdOK.BackgroundImage"), System.Drawing.Image)
		Me.CmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdOK.ForeColor = System.Drawing.Color.White
		Me.CmdOK.Location = New System.Drawing.Point(377, 2)
		Me.CmdOK.Name = "CmdOK"
		Me.CmdOK.Size = New System.Drawing.Size(108, 27)
		Me.CmdOK.TabIndex = 12
		Me.CmdOK.Text = "Adicionar"
		Me.CmdOK.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(14, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(60, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Campo Nro"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(39, 39)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 13)
		Me.Label2.TabIndex = 14
		Me.Label2.Text = "Título"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(5, 65)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(69, 13)
		Me.Label3.TabIndex = 13
		Me.Label3.Text = "Tipo de Dato"
		'
		'TxtNro
		'
		Me.TxtNro.Location = New System.Drawing.Point(80, 10)
		Me.TxtNro.MaxLength = 3
		Me.TxtNro.Name = "TxtNro"
		Me.TxtNro.Size = New System.Drawing.Size(57, 20)
		Me.TxtNro.TabIndex = 1
		Me.TxtNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TxtTitulo
		'
		Me.TxtTitulo.Location = New System.Drawing.Point(80, 36)
		Me.TxtTitulo.MaxLength = 50
		Me.TxtTitulo.Name = "TxtTitulo"
		Me.TxtTitulo.Size = New System.Drawing.Size(245, 20)
		Me.TxtTitulo.TabIndex = 2
		'
		'CbTipoDato
		'
		Me.CbTipoDato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbTipoDato.FormattingEnabled = True
		Me.CbTipoDato.Location = New System.Drawing.Point(80, 62)
		Me.CbTipoDato.Name = "CbTipoDato"
		Me.CbTipoDato.Size = New System.Drawing.Size(245, 21)
		Me.CbTipoDato.TabIndex = 3
		'
		'ChkRequerido
		'
		Me.ChkRequerido.AutoSize = True
		Me.ChkRequerido.Location = New System.Drawing.Point(224, 13)
		Me.ChkRequerido.Name = "ChkRequerido"
		Me.ChkRequerido.Size = New System.Drawing.Size(106, 17)
		Me.ChkRequerido.TabIndex = 4
		Me.ChkRequerido.Text = "Campo requerido"
		Me.ChkRequerido.UseVisualStyleBackColor = True
		'
		'PnlFecha
		'
		Me.PnlFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlFecha.Controls.Add(Me.GroupBox2)
		Me.PnlFecha.Controls.Add(Me.GroupBox1)
		Me.PnlFecha.Location = New System.Drawing.Point(34, 187)
		Me.PnlFecha.Name = "PnlFecha"
		Me.PnlFecha.Size = New System.Drawing.Size(227, 255)
		Me.PnlFecha.TabIndex = 8
		Me.PnlFecha.Visible = False
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.GroupBox2.Controls.Add(Me.ChkMaxCualquiera)
		Me.GroupBox2.Controls.Add(Me.TxtFecMax)
		Me.GroupBox2.Controls.Add(Me.ChkFechaMaxima)
		Me.GroupBox2.Controls.Add(Me.ChkFechaMaximoHoy)
		Me.GroupBox2.Location = New System.Drawing.Point(4, 139)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(217, 114)
		Me.GroupBox2.TabIndex = 17
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Fecha Superior"
		'
		'ChkMaxCualquiera
		'
		Me.ChkMaxCualquiera.AutoSize = True
		Me.ChkMaxCualquiera.Checked = True
		Me.ChkMaxCualquiera.Location = New System.Drawing.Point(19, 19)
		Me.ChkMaxCualquiera.Name = "ChkMaxCualquiera"
		Me.ChkMaxCualquiera.Size = New System.Drawing.Size(75, 17)
		Me.ChkMaxCualquiera.TabIndex = 5
		Me.ChkMaxCualquiera.TabStop = True
		Me.ChkMaxCualquiera.Text = "Cualquiera"
		Me.ChkMaxCualquiera.UseVisualStyleBackColor = True
		'
		'TxtFecMax
		'
		Me.TxtFecMax.Location = New System.Drawing.Point(5, 88)
		Me.TxtFecMax.Name = "TxtFecMax"
		Me.TxtFecMax.Size = New System.Drawing.Size(210, 20)
		Me.TxtFecMax.TabIndex = 5
		Me.TxtFecMax.Visible = False
		'
		'ChkFechaMaxima
		'
		Me.ChkFechaMaxima.AutoSize = True
		Me.ChkFechaMaxima.Location = New System.Drawing.Point(19, 61)
		Me.ChkFechaMaxima.Name = "ChkFechaMaxima"
		Me.ChkFechaMaxima.Size = New System.Drawing.Size(45, 17)
		Me.ChkFechaMaxima.TabIndex = 4
		Me.ChkFechaMaxima.Text = "Otra"
		Me.ChkFechaMaxima.UseVisualStyleBackColor = True
		'
		'ChkFechaMaximoHoy
		'
		Me.ChkFechaMaximoHoy.AutoSize = True
		Me.ChkFechaMaximoHoy.Location = New System.Drawing.Point(19, 40)
		Me.ChkFechaMaximoHoy.Name = "ChkFechaMaximoHoy"
		Me.ChkFechaMaximoHoy.Size = New System.Drawing.Size(44, 17)
		Me.ChkFechaMaximoHoy.TabIndex = 3
		Me.ChkFechaMaximoHoy.Text = "Hoy"
		Me.ChkFechaMaximoHoy.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.GroupBox1.Controls.Add(Me.ChkMinCualquiera)
		Me.GroupBox1.Controls.Add(Me.ChkFechaMinima)
		Me.GroupBox1.Controls.Add(Me.ChkFechaMinimaHoy)
		Me.GroupBox1.Controls.Add(Me.TxtFecMin)
		Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(220, 115)
		Me.GroupBox1.TabIndex = 16
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Fecha Inferior"
		'
		'ChkMinCualquiera
		'
		Me.ChkMinCualquiera.AutoSize = True
		Me.ChkMinCualquiera.Checked = True
		Me.ChkMinCualquiera.Location = New System.Drawing.Point(19, 19)
		Me.ChkMinCualquiera.Name = "ChkMinCualquiera"
		Me.ChkMinCualquiera.Size = New System.Drawing.Size(75, 17)
		Me.ChkMinCualquiera.TabIndex = 5
		Me.ChkMinCualquiera.TabStop = True
		Me.ChkMinCualquiera.Text = "Cualquiera"
		Me.ChkMinCualquiera.UseVisualStyleBackColor = True
		'
		'ChkFechaMinima
		'
		Me.ChkFechaMinima.AutoSize = True
		Me.ChkFechaMinima.Location = New System.Drawing.Point(19, 65)
		Me.ChkFechaMinima.Name = "ChkFechaMinima"
		Me.ChkFechaMinima.Size = New System.Drawing.Size(45, 17)
		Me.ChkFechaMinima.TabIndex = 4
		Me.ChkFechaMinima.Text = "Otra"
		Me.ChkFechaMinima.UseVisualStyleBackColor = True
		'
		'ChkFechaMinimaHoy
		'
		Me.ChkFechaMinimaHoy.AutoSize = True
		Me.ChkFechaMinimaHoy.Location = New System.Drawing.Point(19, 42)
		Me.ChkFechaMinimaHoy.Name = "ChkFechaMinimaHoy"
		Me.ChkFechaMinimaHoy.Size = New System.Drawing.Size(44, 17)
		Me.ChkFechaMinimaHoy.TabIndex = 3
		Me.ChkFechaMinimaHoy.Text = "Hoy"
		Me.ChkFechaMinimaHoy.UseVisualStyleBackColor = True
		'
		'TxtFecMin
		'
		Me.TxtFecMin.Location = New System.Drawing.Point(3, 89)
		Me.TxtFecMin.Name = "TxtFecMin"
		Me.TxtFecMin.Size = New System.Drawing.Size(215, 20)
		Me.TxtFecMin.TabIndex = 2
		Me.TxtFecMin.Visible = False
		'
		'PnlCombo1
		'
		Me.PnlCombo1.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.PnlCombo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlCombo1.Controls.Add(Me.LstDel)
		Me.PnlCombo1.Controls.Add(Me.LstMult)
		Me.PnlCombo1.Controls.Add(Me.CmdMultipleDel)
		Me.PnlCombo1.Controls.Add(Me.CmdMultipleAdi)
		Me.PnlCombo1.Controls.Add(Me.TxtMultipleTex)
		Me.PnlCombo1.Controls.Add(Me.Label5)
		Me.PnlCombo1.Location = New System.Drawing.Point(20, 18)
		Me.PnlCombo1.Name = "PnlCombo1"
		Me.PnlCombo1.Size = New System.Drawing.Size(226, 270)
		Me.PnlCombo1.TabIndex = 7
		'
		'LstDel
		'
		Me.LstDel.FormattingEnabled = True
		Me.LstDel.Location = New System.Drawing.Point(89, 178)
		Me.LstDel.Name = "LstDel"
		Me.LstDel.Size = New System.Drawing.Size(55, 17)
		Me.LstDel.Sorted = True
		Me.LstDel.TabIndex = 5
		Me.LstDel.Visible = False
		'
		'LstMult
		'
		Me.LstMult.FormattingEnabled = True
		Me.LstMult.Location = New System.Drawing.Point(3, 91)
		Me.LstMult.Name = "LstMult"
		Me.LstMult.Size = New System.Drawing.Size(218, 173)
		Me.LstMult.Sorted = True
		Me.LstMult.TabIndex = 3
		'
		'CmdMultipleDel
		'
		Me.CmdMultipleDel.BackColor = System.Drawing.SystemColors.Control
		Me.CmdMultipleDel.BackgroundImage = CType(resources.GetObject("CmdMultipleDel.BackgroundImage"), System.Drawing.Image)
		Me.CmdMultipleDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdMultipleDel.ForeColor = System.Drawing.Color.White
		Me.CmdMultipleDel.Location = New System.Drawing.Point(7, 52)
		Me.CmdMultipleDel.Name = "CmdMultipleDel"
		Me.CmdMultipleDel.Size = New System.Drawing.Size(61, 23)
		Me.CmdMultipleDel.TabIndex = 1
		Me.CmdMultipleDel.Text = "Eliminar"
		Me.CmdMultipleDel.UseVisualStyleBackColor = True
		'
		'CmdMultipleAdi
		'
		Me.CmdMultipleAdi.BackColor = System.Drawing.SystemColors.Control
		Me.CmdMultipleAdi.BackgroundImage = CType(resources.GetObject("CmdMultipleAdi.BackgroundImage"), System.Drawing.Image)
		Me.CmdMultipleAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdMultipleAdi.ForeColor = System.Drawing.Color.White
		Me.CmdMultipleAdi.Location = New System.Drawing.Point(156, 52)
		Me.CmdMultipleAdi.Name = "CmdMultipleAdi"
		Me.CmdMultipleAdi.Size = New System.Drawing.Size(62, 23)
		Me.CmdMultipleAdi.TabIndex = 2
		Me.CmdMultipleAdi.Text = "Ok"
		Me.CmdMultipleAdi.UseVisualStyleBackColor = True
		'
		'TxtMultipleTex
		'
		Me.TxtMultipleTex.Location = New System.Drawing.Point(5, 26)
		Me.TxtMultipleTex.MaxLength = 50
		Me.TxtMultipleTex.Name = "TxtMultipleTex"
		Me.TxtMultipleTex.Size = New System.Drawing.Size(214, 20)
		Me.TxtMultipleTex.TabIndex = 0
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(2, 10)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(73, 13)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Texto a incluir"
		'
		'ChkNegativo
		'
		Me.ChkNegativo.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.ChkNegativo.AutoSize = True
		Me.ChkNegativo.Location = New System.Drawing.Point(54, 26)
		Me.ChkNegativo.Name = "ChkNegativo"
		Me.ChkNegativo.Size = New System.Drawing.Size(104, 17)
		Me.ChkNegativo.TabIndex = 5
		Me.ChkNegativo.Text = "Acepta negativo"
		Me.ChkNegativo.UseVisualStyleBackColor = True
		'
		'PnlTexto
		'
		Me.PnlTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlTexto.Controls.Add(Me.TxtLongitud)
		Me.PnlTexto.Controls.Add(Me.Label4)
		Me.PnlTexto.Location = New System.Drawing.Point(300, 410)
		Me.PnlTexto.Name = "PnlTexto"
		Me.PnlTexto.Size = New System.Drawing.Size(190, 61)
		Me.PnlTexto.TabIndex = 6
		Me.PnlTexto.Visible = False
		'
		'TxtLongitud
		'
		Me.TxtLongitud.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TxtLongitud.Location = New System.Drawing.Point(112, 19)
		Me.TxtLongitud.MaxLength = 4
		Me.TxtLongitud.Name = "TxtLongitud"
		Me.TxtLongitud.Size = New System.Drawing.Size(57, 20)
		Me.TxtLongitud.TabIndex = 1
		Me.TxtLongitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(19, 23)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(87, 13)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Máxima Longitud"
		'
		'LnkNuevo
		'
		Me.LnkNuevo.AutoSize = True
		Me.LnkNuevo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkNuevo.Location = New System.Drawing.Point(424, 70)
		Me.LnkNuevo.Name = "LnkNuevo"
		Me.LnkNuevo.Size = New System.Drawing.Size(39, 13)
		Me.LnkNuevo.TabIndex = 10
		Me.LnkNuevo.TabStop = True
		Me.LnkNuevo.Text = "Nuevo"
		'
		'ChkAnulado
		'
		Me.ChkAnulado.AutoSize = True
		Me.ChkAnulado.Location = New System.Drawing.Point(149, 12)
		Me.ChkAnulado.Name = "ChkAnulado"
		Me.ChkAnulado.Size = New System.Drawing.Size(64, 17)
		Me.ChkAnulado.TabIndex = 9
		Me.ChkAnulado.Text = "Inactivo"
		Me.ChkAnulado.UseVisualStyleBackColor = True
		'
		'LnkEliminar
		'
		Me.LnkEliminar.AutoSize = True
		Me.LnkEliminar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkEliminar.Location = New System.Drawing.Point(424, 43)
		Me.LnkEliminar.Name = "LnkEliminar"
		Me.LnkEliminar.Size = New System.Drawing.Size(43, 13)
		Me.LnkEliminar.TabIndex = 11
		Me.LnkEliminar.TabStop = True
		Me.LnkEliminar.Text = "Eliminar"
		'
		'PnlNegativo
		'
		Me.PnlNegativo.Controls.Add(Me.ChkNegativo)
		Me.PnlNegativo.Location = New System.Drawing.Point(42, 93)
		Me.PnlNegativo.Name = "PnlNegativo"
		Me.PnlNegativo.Size = New System.Drawing.Size(212, 69)
		Me.PnlNegativo.TabIndex = 16
		Me.PnlNegativo.Visible = False
		'
		'PnlCombo
		'
		Me.PnlCombo.Controls.Add(Me.PnlCombo1)
		Me.PnlCombo.Location = New System.Drawing.Point(266, 99)
		Me.PnlCombo.Name = "PnlCombo"
		Me.PnlCombo.Size = New System.Drawing.Size(267, 306)
		Me.PnlCombo.TabIndex = 6
		Me.PnlCombo.Visible = False
		'
		'Grd
		'
		Me.Grd.DMSCopiarDt = True
		Me.Grd.DMSTituloDelInforme = ""
		Me.Grd.Location = New System.Drawing.Point(12, 93)
		Me.Grd.Name = "Grd"
		Me.Grd.Size = New System.Drawing.Size(494, 393)
		Me.Grd.TabIndex = 15
		'
		'fCamposAdicionales
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(512, 493)
		Me.Controls.Add(Me.PnlCombo)
		Me.Controls.Add(Me.PnlNegativo)
		Me.Controls.Add(Me.LnkEliminar)
		Me.Controls.Add(Me.ChkAnulado)
		Me.Controls.Add(Me.LnkNuevo)
		Me.Controls.Add(Me.PnlTexto)
		Me.Controls.Add(Me.PnlFecha)
		Me.Controls.Add(Me.ChkRequerido)
		Me.Controls.Add(Me.CbTipoDato)
		Me.Controls.Add(Me.TxtTitulo)
		Me.Controls.Add(Me.TxtNro)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.CmdOK)
		Me.Controls.Add(Me.Grd)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "fCamposAdicionales"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "fCamposVarios"
		Me.Controls.SetChildIndex(Me.Grd, 0)
		Me.Controls.SetChildIndex(Me.CmdOK, 0)
		Me.Controls.SetChildIndex(Me.Label1, 0)
		Me.Controls.SetChildIndex(Me.Label2, 0)
		Me.Controls.SetChildIndex(Me.Label3, 0)
		Me.Controls.SetChildIndex(Me.TxtNro, 0)
		Me.Controls.SetChildIndex(Me.TxtTitulo, 0)
		Me.Controls.SetChildIndex(Me.CbTipoDato, 0)
		Me.Controls.SetChildIndex(Me.ChkRequerido, 0)
		Me.Controls.SetChildIndex(Me.PnlFecha, 0)
		Me.Controls.SetChildIndex(Me.PnlTexto, 0)
		Me.Controls.SetChildIndex(Me.LnkNuevo, 0)
		Me.Controls.SetChildIndex(Me.ChkAnulado, 0)
		Me.Controls.SetChildIndex(Me.LnkEliminar, 0)
		Me.Controls.SetChildIndex(Me.PnlNegativo, 0)
		Me.Controls.SetChildIndex(Me.PnlCombo, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PnlFecha.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.PnlCombo1.ResumeLayout(False)
		Me.PnlCombo1.PerformLayout()
		Me.PnlTexto.ResumeLayout(False)
		Me.PnlTexto.PerformLayout()
		Me.PnlNegativo.ResumeLayout(False)
		Me.PnlNegativo.PerformLayout()
		Me.PnlCombo.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Grd As SMDPpal.GridDms
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents TxtNro As System.Windows.Forms.TextBox
	Friend WithEvents TxtTitulo As System.Windows.Forms.TextBox
	Friend WithEvents CbTipoDato As System.Windows.Forms.ComboBox
	Friend WithEvents ChkRequerido As System.Windows.Forms.CheckBox
	Friend WithEvents PnlFecha As System.Windows.Forms.Panel
	Friend WithEvents PnlCombo1 As System.Windows.Forms.Panel
	Friend WithEvents ChkNegativo As System.Windows.Forms.CheckBox
	Friend WithEvents TxtFecMax As System.Windows.Forms.DateTimePicker
	Friend WithEvents TxtFecMin As System.Windows.Forms.DateTimePicker
	Friend WithEvents PnlTexto As System.Windows.Forms.Panel
	Friend WithEvents TxtLongitud As System.Windows.Forms.TextBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents LstMult As System.Windows.Forms.ListBox
	Friend WithEvents TxtMultipleTex As System.Windows.Forms.TextBox
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents LnkNuevo As System.Windows.Forms.LinkLabel
	Friend WithEvents ChkAnulado As System.Windows.Forms.CheckBox
	Friend WithEvents LnkEliminar As System.Windows.Forms.LinkLabel
	Friend WithEvents LstDel As System.Windows.Forms.ListBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents ChkFechaMinima As System.Windows.Forms.RadioButton
	Friend WithEvents ChkFechaMinimaHoy As System.Windows.Forms.RadioButton
	Friend WithEvents ChkMinCualquiera As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents ChkMaxCualquiera As System.Windows.Forms.RadioButton
	Friend WithEvents ChkFechaMaxima As System.Windows.Forms.RadioButton
	Friend WithEvents ChkFechaMaximoHoy As System.Windows.Forms.RadioButton
	Friend WithEvents PnlNegativo As System.Windows.Forms.Panel
	Friend WithEvents PnlCombo As System.Windows.Forms.Panel
	Friend WithEvents CmdOK As BotonEstandar
	Friend WithEvents CmdMultipleDel As BotonEstandar
	Friend WithEvents CmdMultipleAdi As BotonEstandar
End Class
