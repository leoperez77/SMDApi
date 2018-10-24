<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fFecha
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fFecha))
		Me.Mes = New System.Windows.Forms.MonthCalendar()
		Me.CmdAceptar = New SMDPpal.BotonEstandar()
		Me.CmdCancelar = New SMDPpal.BotonEstandar()
		Me.CbHora = New System.Windows.Forms.DateTimePicker()
		Me.LblHora = New System.Windows.Forms.Label()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.TxtAsunto = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(255, 0)
		'
		'Mes
		'
		Me.Mes.Location = New System.Drawing.Point(27, 2)
		Me.Mes.MaxSelectionCount = 1
		Me.Mes.Name = "Mes"
		Me.Mes.ShowWeekNumbers = True
		Me.Mes.TabIndex = 1
		'
		'CmdAceptar
		'
		Me.CmdAceptar.BackColor = System.Drawing.Color.White
		Me.CmdAceptar.BackgroundImage = CType(resources.GetObject("CmdAceptar.BackgroundImage"), System.Drawing.Image)
		Me.CmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdAceptar.ForeColor = System.Drawing.Color.White
		Me.CmdAceptar.Location = New System.Drawing.Point(27, 199)
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(81, 27)
		Me.CmdAceptar.TabIndex = 2
		Me.CmdAceptar.Text = "Aceptar"
		Me.CmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdAceptar.UseVisualStyleBackColor = True
		'
		'CmdCancelar
		'
		Me.CmdCancelar.BackColor = System.Drawing.Color.White
		Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancelar.ForeColor = System.Drawing.Color.White
		Me.CmdCancelar.Location = New System.Drawing.Point(147, 199)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(81, 27)
		Me.CmdCancelar.TabIndex = 3
		Me.CmdCancelar.Text = "Cancelar"
		Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancelar.UseVisualStyleBackColor = True
		'
		'CbHora
		'
		Me.CbHora.Cursor = System.Windows.Forms.Cursors.Default
		Me.CbHora.CustomFormat = "HH:mm"
		Me.CbHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.CbHora.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.CbHora.Location = New System.Drawing.Point(111, 170)
		Me.CbHora.Name = "CbHora"
		Me.CbHora.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CbHora.ShowUpDown = True
		Me.CbHora.Size = New System.Drawing.Size(65, 20)
		Me.CbHora.TabIndex = 29
		'
		'LblHora
		'
		Me.LblHora.AutoSize = True
		Me.LblHora.BackColor = System.Drawing.Color.Transparent
		Me.LblHora.Cursor = System.Windows.Forms.Cursors.Default
		Me.LblHora.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LblHora.Location = New System.Drawing.Point(61, 173)
		Me.LblHora.Name = "LblHora"
		Me.LblHora.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LblHora.Size = New System.Drawing.Size(30, 13)
		Me.LblHora.TabIndex = 28
		Me.LblHora.Text = "Hora"
		'
		'SplitContainer1
		'
		Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitContainer1.IsSplitterFixed = True
		Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
		Me.SplitContainer1.Name = "SplitContainer1"
		Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.TxtAsunto)
		Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.Mes)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CbHora)
		Me.SplitContainer1.Panel2.Controls.Add(Me.LblHora)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CmdAceptar)
		Me.SplitContainer1.Panel2.Controls.Add(Me.CmdCancelar)
		Me.SplitContainer1.Size = New System.Drawing.Size(275, 307)
		Me.SplitContainer1.SplitterDistance = 71
		Me.SplitContainer1.TabIndex = 30
		'
		'TxtAsunto
		'
		Me.TxtAsunto.AcceptsReturn = True
		Me.TxtAsunto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtAsunto.BackColor = System.Drawing.SystemColors.Window
		Me.TxtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtAsunto.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtAsunto.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtAsunto.Location = New System.Drawing.Point(12, 22)
		Me.TxtAsunto.MaxLength = 500
		Me.TxtAsunto.Multiline = True
		Me.TxtAsunto.Name = "TxtAsunto"
		Me.TxtAsunto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtAsunto.Size = New System.Drawing.Size(257, 43)
		Me.TxtAsunto.TabIndex = 6
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(9, 6)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(68, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Recordatorio"
		'
		'fFecha
		'
		Me.AcceptButton = Me.CmdAceptar
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.CancelButton = Me.CmdCancelar
		Me.ClientSize = New System.Drawing.Size(276, 309)
		Me.ControlBox = False
		Me.Controls.Add(Me.SplitContainer1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "fFecha"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Fecha"
		Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel1.PerformLayout()
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.Panel2.PerformLayout()
		Me.SplitContainer1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Mes As System.Windows.Forms.MonthCalendar
    Friend WithEvents CbHora As System.Windows.Forms.DateTimePicker
    Public WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TxtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents CmdAceptar As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
End Class
