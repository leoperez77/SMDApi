<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fResultBuscar1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fResultBuscar1))
		Me.LstResult = New System.Windows.Forms.ListBox()
		Me.CmdAceptar = New SMDPpal.BotonEstandar()
		Me.CmdCancel = New SMDPpal.BotonEstandar()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TbBuscar = New System.Windows.Forms.TabPage()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.OptTodo = New System.Windows.Forms.RadioButton()
		Me.TxtBuscar = New System.Windows.Forms.TextBox()
		Me.TbResult = New System.Windows.Forms.TabPage()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabControl1.SuspendLayout()
		Me.TbBuscar.SuspendLayout()
		Me.TbResult.SuspendLayout()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(219, 0)
		'
		'LstResult
		'
		Me.LstResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LstResult.FormattingEnabled = True
		Me.LstResult.Location = New System.Drawing.Point(5, 4)
		Me.LstResult.Name = "LstResult"
		Me.LstResult.Size = New System.Drawing.Size(196, 121)
		Me.LstResult.TabIndex = 0
		'
		'CmdAceptar
		'
		Me.CmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CmdAceptar.BackColor = System.Drawing.Color.White
		Me.CmdAceptar.BackgroundImage = CType(resources.GetObject("CmdAceptar.BackgroundImage"), System.Drawing.Image)
		Me.CmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdAceptar.ForeColor = System.Drawing.Color.White
		Me.CmdAceptar.Location = New System.Drawing.Point(153, 169)
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(75, 23)
		Me.CmdAceptar.TabIndex = 1
		Me.CmdAceptar.Text = "Buscar"
		Me.CmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdAceptar.UseVisualStyleBackColor = True
		'
		'CmdCancel
		'
		Me.CmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.CmdCancel.BackColor = System.Drawing.Color.White
		Me.CmdCancel.BackgroundImage = CType(resources.GetObject("CmdCancel.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancel.ForeColor = System.Drawing.Color.White
		Me.CmdCancel.Location = New System.Drawing.Point(27, 169)
		Me.CmdCancel.Name = "CmdCancel"
		Me.CmdCancel.Size = New System.Drawing.Size(75, 23)
		Me.CmdCancel.TabIndex = 2
		Me.CmdCancel.Text = "Cancelar"
		Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancel.UseVisualStyleBackColor = True
		'
		'TabControl1
		'
		Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TabControl1.Controls.Add(Me.TbBuscar)
		Me.TabControl1.Controls.Add(Me.TbResult)
		Me.TabControl1.Location = New System.Drawing.Point(12, 7)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(216, 156)
		Me.TabControl1.TabIndex = 0
		'
		'TbBuscar
		'
		Me.TbBuscar.Controls.Add(Me.RadioButton2)
		Me.TbBuscar.Controls.Add(Me.OptTodo)
		Me.TbBuscar.Controls.Add(Me.TxtBuscar)
		Me.TbBuscar.Location = New System.Drawing.Point(4, 22)
		Me.TbBuscar.Name = "TbBuscar"
		Me.TbBuscar.Padding = New System.Windows.Forms.Padding(3)
		Me.TbBuscar.Size = New System.Drawing.Size(208, 130)
		Me.TbBuscar.TabIndex = 0
		Me.TbBuscar.Text = "Texto a Buscar"
		Me.TbBuscar.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(39, 86)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(137, 17)
		Me.RadioButton2.TabIndex = 3
		Me.RadioButton2.Text = "Solo desde el comienzo"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'OptTodo
		'
		Me.OptTodo.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.OptTodo.AutoSize = True
		Me.OptTodo.Checked = True
		Me.OptTodo.Location = New System.Drawing.Point(39, 63)
		Me.OptTodo.Name = "OptTodo"
		Me.OptTodo.Size = New System.Drawing.Size(134, 17)
		Me.OptTodo.TabIndex = 2
		Me.OptTodo.TabStop = True
		Me.OptTodo.Text = "Buscar en todo el texto"
		Me.OptTodo.UseVisualStyleBackColor = True
		'
		'TxtBuscar
		'
		Me.TxtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.TxtBuscar.Location = New System.Drawing.Point(27, 33)
		Me.TxtBuscar.Name = "TxtBuscar"
		Me.TxtBuscar.Size = New System.Drawing.Size(154, 20)
		Me.TxtBuscar.TabIndex = 1
		'
		'TbResult
		'
		Me.TbResult.Controls.Add(Me.LstResult)
		Me.TbResult.Location = New System.Drawing.Point(4, 22)
		Me.TbResult.Name = "TbResult"
		Me.TbResult.Padding = New System.Windows.Forms.Padding(3)
		Me.TbResult.Size = New System.Drawing.Size(208, 130)
		Me.TbResult.TabIndex = 1
		Me.TbResult.Text = "Resultados"
		Me.TbResult.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(24, 17)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(157, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Entre el texto que desea buscar"
		'
		'fResultBuscar1
		'
		Me.AcceptButton = Me.CmdAceptar
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.CancelButton = Me.CmdCancel
		Me.ClientSize = New System.Drawing.Size(240, 196)
		Me.ControlBox = False
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.CmdCancel)
		Me.Controls.Add(Me.CmdAceptar)
		Me.Name = "fResultBuscar1"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Buscar"
		Me.Controls.SetChildIndex(Me.CmdAceptar, 0)
		Me.Controls.SetChildIndex(Me.CmdCancel, 0)
		Me.Controls.SetChildIndex(Me.TabControl1, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabControl1.ResumeLayout(False)
		Me.TbBuscar.ResumeLayout(False)
		Me.TbBuscar.PerformLayout()
		Me.TbResult.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents LstResult As System.Windows.Forms.ListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TbBuscar As System.Windows.Forms.TabPage
    Friend WithEvents TbResult As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents OptTodo As System.Windows.Forms.RadioButton
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents CmdAceptar As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancel As SMDPpal.BotonEstandar
End Class
