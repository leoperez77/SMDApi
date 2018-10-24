<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LblCliente
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
		Me.LblBuscar = New System.Windows.Forms.Label()
		Me.LblCli = New System.Windows.Forms.TextBox()
		Me.LnkCliente = New System.Windows.Forms.Label()
		Me.LblContacto = New System.Windows.Forms.Label()
		Me.LblBuscarCont = New System.Windows.Forms.Label()
		Me.PnlCli = New System.Windows.Forms.Panel()
		Me.LnkUlt = New System.Windows.Forms.LinkLabel()
		Me.LblNit = New System.Windows.Forms.Label()
		Me.LblSigla = New System.Windows.Forms.Label()
		Me.PnlCli.SuspendLayout()
		Me.SuspendLayout()
		'
		'LblBuscar
		'
		Me.LblBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblBuscar.BackColor = System.Drawing.SystemColors.Control
		Me.LblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblBuscar.Location = New System.Drawing.Point(302, 2)
		Me.LblBuscar.Name = "LblBuscar"
		Me.LblBuscar.Size = New System.Drawing.Size(14, 16)
		Me.LblBuscar.TabIndex = 216
		Me.LblBuscar.Text = "♣"
		'
		'LblCli
		'
		Me.LblCli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblCli.Location = New System.Drawing.Point(77, 0)
		Me.LblCli.MaxLength = 80
		Me.LblCli.Name = "LblCli"
		Me.LblCli.Size = New System.Drawing.Size(241, 20)
		Me.LblCli.TabIndex = 0
		'
		'LnkCliente
		'
		Me.LnkCliente.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LnkCliente.ForeColor = System.Drawing.Color.Blue
		Me.LnkCliente.Location = New System.Drawing.Point(0, 4)
		Me.LnkCliente.Name = "LnkCliente"
		Me.LnkCliente.Size = New System.Drawing.Size(73, 13)
		Me.LnkCliente.TabIndex = 217
		Me.LnkCliente.Text = "Tercero"
		Me.LnkCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LblContacto
		'
		Me.LblContacto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.LblContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblContacto.Location = New System.Drawing.Point(77, 21)
		Me.LblContacto.Name = "LblContacto"
		Me.LblContacto.Size = New System.Drawing.Size(241, 17)
		Me.LblContacto.TabIndex = 220
		Me.LblContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblBuscarCont
		'
		Me.LblBuscarCont.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblBuscarCont.BackColor = System.Drawing.SystemColors.Control
		Me.LblBuscarCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblBuscarCont.Location = New System.Drawing.Point(303, 22)
		Me.LblBuscarCont.Name = "LblBuscarCont"
		Me.LblBuscarCont.Size = New System.Drawing.Size(14, 14)
		Me.LblBuscarCont.TabIndex = 221
		Me.LblBuscarCont.Text = "♣"
		'
		'PnlCli
		'
		Me.PnlCli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PnlCli.Controls.Add(Me.LblBuscar)
		Me.PnlCli.Controls.Add(Me.LnkUlt)
		Me.PnlCli.Controls.Add(Me.LblCli)
		Me.PnlCli.Controls.Add(Me.LnkCliente)
		Me.PnlCli.Location = New System.Drawing.Point(0, 0)
		Me.PnlCli.Name = "PnlCli"
		Me.PnlCli.Size = New System.Drawing.Size(318, 20)
		Me.PnlCli.TabIndex = 222
		'
		'LnkUlt
		'
		Me.LnkUlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LnkUlt.AutoSize = True
		Me.LnkUlt.BackColor = System.Drawing.Color.White
		Me.LnkUlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LnkUlt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
		Me.LnkUlt.Location = New System.Drawing.Point(286, 1)
		Me.LnkUlt.Name = "LnkUlt"
		Me.LnkUlt.Size = New System.Drawing.Size(16, 16)
		Me.LnkUlt.TabIndex = 224
		Me.LnkUlt.TabStop = True
		Me.LnkUlt.Text = "●"
		'
		'LblNit
		'
		Me.LblNit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblNit.ForeColor = System.Drawing.Color.Black
		Me.LblNit.Location = New System.Drawing.Point(3, 22)
		Me.LblNit.Name = "LblNit"
		Me.LblNit.Size = New System.Drawing.Size(71, 12)
		Me.LblNit.TabIndex = 223
		Me.LblNit.Text = "Nit"
		Me.LblNit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblSigla
		'
		Me.LblSigla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblSigla.BackColor = System.Drawing.Color.BurlyWood
		Me.LblSigla.Location = New System.Drawing.Point(205, 23)
		Me.LblSigla.Name = "LblSigla"
		Me.LblSigla.Size = New System.Drawing.Size(95, 13)
		Me.LblSigla.TabIndex = 225
		'
		'LblCliente
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.BurlyWood
		Me.Controls.Add(Me.LblSigla)
		Me.Controls.Add(Me.LblNit)
		Me.Controls.Add(Me.PnlCli)
		Me.Controls.Add(Me.LblBuscarCont)
		Me.Controls.Add(Me.LblContacto)
		Me.Name = "LblCliente"
		Me.Size = New System.Drawing.Size(318, 38)
		Me.PnlCli.ResumeLayout(False)
		Me.PnlCli.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Public WithEvents LblCli As System.Windows.Forms.TextBox
    Public WithEvents LblContacto As System.Windows.Forms.Label
    Friend WithEvents LblBuscarCont As System.Windows.Forms.Label
    Public WithEvents LnkCliente As System.Windows.Forms.Label
    Public WithEvents LblBuscar As System.Windows.Forms.Label
    Public WithEvents PnlCli As System.Windows.Forms.Panel
    Public WithEvents LblNit As System.Windows.Forms.Label
    Friend WithEvents LnkUlt As System.Windows.Forms.LinkLabel
    Friend WithEvents LblSigla As System.Windows.Forms.Label

End Class
