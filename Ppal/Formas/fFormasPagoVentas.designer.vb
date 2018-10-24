' Version: 601, 29-nov.-2017 12:05
' Version: 590, 18-oct.-2017 18:37
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fFormasPagoVentas
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fFormasPagoVentas))
		Me.LnkDocRef = New System.Windows.Forms.LinkLabel()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.TxtValorPagar = New System.Windows.Forms.TextBox()
		Me.PnlFormaPago = New System.Windows.Forms.Panel()
		Me.CmdConti = New SMDPpal.BotonEstandar()
		Me.LnkEliminar = New System.Windows.Forms.LinkLabel()
		Me.LnkEditar = New System.Windows.Forms.LinkLabel()
		Me.CmdNueva = New SMDPpal.BotonEstandar()
		Me.CmdCancel = New SMDPpal.BotonEstandar()
		Me.CmdOk = New SMDPpal.BotonEstandar()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TxtPlazo = New System.Windows.Forms.TextBox()
		Me.CbFormaPago = New SMDPpal.ComboDMS()
		Me.CbUnidad = New System.Windows.Forms.ComboBox()
		Me.LblContacto = New System.Windows.Forms.Label()
		Me.LblBancoConsig = New System.Windows.Forms.Label()
		Me.LblPagado = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Grd = New SMDPpal.GridDms()
		Me.LblValorDocumento = New System.Windows.Forms.Label()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PnlFormaPago.SuspendLayout()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(835, 0)
		Me.PicPuntoAdv.Margin = New System.Windows.Forms.Padding(4)
		'
		'LnkDocRef
		'
		Me.LnkDocRef.AutoSize = True
		Me.LnkDocRef.Enabled = False
		Me.LnkDocRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LnkDocRef.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkDocRef.Location = New System.Drawing.Point(186, 12)
		Me.LnkDocRef.Name = "LnkDocRef"
		Me.LnkDocRef.Size = New System.Drawing.Size(112, 16)
		Me.LnkDocRef.TabIndex = 11
		Me.LnkDocRef.TabStop = True
		Me.LnkDocRef.Text = "Valor Documento"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(186, 37)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(91, 16)
		Me.Label9.TabIndex = 23
		Me.Label9.Text = "Valor a Pagar"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxtValorPagar
		'
		Me.TxtValorPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtValorPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtValorPagar.Location = New System.Drawing.Point(304, 35)
		Me.TxtValorPagar.Name = "TxtValorPagar"
		Me.TxtValorPagar.Size = New System.Drawing.Size(137, 22)
		Me.TxtValorPagar.TabIndex = 0
		Me.TxtValorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'PnlFormaPago
		'
		Me.PnlFormaPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PnlFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnlFormaPago.Controls.Add(Me.CmdConti)
		Me.PnlFormaPago.Controls.Add(Me.LnkEliminar)
		Me.PnlFormaPago.Controls.Add(Me.LnkEditar)
		Me.PnlFormaPago.Controls.Add(Me.CmdNueva)
		Me.PnlFormaPago.Controls.Add(Me.CmdCancel)
		Me.PnlFormaPago.Controls.Add(Me.CmdOk)
		Me.PnlFormaPago.Controls.Add(Me.Label1)
		Me.PnlFormaPago.Controls.Add(Me.TxtPlazo)
		Me.PnlFormaPago.Controls.Add(Me.CbFormaPago)
		Me.PnlFormaPago.Controls.Add(Me.CbUnidad)
		Me.PnlFormaPago.Controls.Add(Me.LblContacto)
		Me.PnlFormaPago.Controls.Add(Me.LblBancoConsig)
		Me.PnlFormaPago.Location = New System.Drawing.Point(12, 72)
		Me.PnlFormaPago.Name = "PnlFormaPago"
		Me.PnlFormaPago.Size = New System.Drawing.Size(835, 76)
		Me.PnlFormaPago.TabIndex = 25
		'
		'CmdConti
		'
		Me.CmdConti.BackColor = System.Drawing.Color.White
		Me.CmdConti.BackgroundImage = CType(resources.GetObject("CmdConti.BackgroundImage"), System.Drawing.Image)
		Me.CmdConti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdConti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdConti.ForeColor = System.Drawing.Color.White
		Me.CmdConti.Location = New System.Drawing.Point(715, 7)
		Me.CmdConti.Name = "CmdConti"
		Me.CmdConti.Size = New System.Drawing.Size(76, 32)
		Me.CmdConti.TabIndex = 5
		Me.CmdConti.Text = "Continuar"
		Me.CmdConti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdConti.UseVisualStyleBackColor = False
		'
		'LnkEliminar
		'
		Me.LnkEliminar.AutoSize = True
		Me.LnkEliminar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkEliminar.Location = New System.Drawing.Point(715, 53)
		Me.LnkEliminar.Name = "LnkEliminar"
		Me.LnkEliminar.Size = New System.Drawing.Size(43, 13)
		Me.LnkEliminar.TabIndex = 9
		Me.LnkEliminar.TabStop = True
		Me.LnkEliminar.Text = "Eliminar"
		Me.LnkEliminar.Visible = False
		'
		'LnkEditar
		'
		Me.LnkEditar.AutoSize = True
		Me.LnkEditar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkEditar.Location = New System.Drawing.Point(715, 40)
		Me.LnkEditar.Name = "LnkEditar"
		Me.LnkEditar.Size = New System.Drawing.Size(34, 13)
		Me.LnkEditar.TabIndex = 8
		Me.LnkEditar.TabStop = True
		Me.LnkEditar.Text = "Editar"
		Me.LnkEditar.Visible = False
		'
		'CmdNueva
		'
		Me.CmdNueva.BackColor = System.Drawing.Color.White
		Me.CmdNueva.BackgroundImage = CType(resources.GetObject("CmdNueva.BackgroundImage"), System.Drawing.Image)
		Me.CmdNueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdNueva.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CmdNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdNueva.ForeColor = System.Drawing.Color.White
		Me.CmdNueva.Location = New System.Drawing.Point(525, 6)
		Me.CmdNueva.Name = "CmdNueva"
		Me.CmdNueva.Size = New System.Drawing.Size(89, 59)
		Me.CmdNueva.TabIndex = 6
		Me.CmdNueva.Text = "Nueva"
		Me.CmdNueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdNueva.UseVisualStyleBackColor = True
		'
		'CmdCancel
		'
		Me.CmdCancel.BackColor = System.Drawing.Color.White
		Me.CmdCancel.BackgroundImage = CType(resources.GetObject("CmdCancel.BackgroundImage"), System.Drawing.Image)
		Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdCancel.ForeColor = System.Drawing.Color.White
		Me.CmdCancel.Location = New System.Drawing.Point(430, 6)
		Me.CmdCancel.Name = "CmdCancel"
		Me.CmdCancel.Size = New System.Drawing.Size(89, 59)
		Me.CmdCancel.TabIndex = 7
		Me.CmdCancel.Text = "Cancelar"
		Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdCancel.UseVisualStyleBackColor = True
		'
		'CmdOk
		'
		Me.CmdOk.BackColor = System.Drawing.Color.White
		Me.CmdOk.BackgroundImage = CType(resources.GetObject("CmdOk.BackgroundImage"), System.Drawing.Image)
		Me.CmdOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CmdOk.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdOk.ForeColor = System.Drawing.Color.White
		Me.CmdOk.Location = New System.Drawing.Point(620, 6)
		Me.CmdOk.Name = "CmdOk"
		Me.CmdOk.Size = New System.Drawing.Size(89, 59)
		Me.CmdOk.TabIndex = 4
		Me.CmdOk.Text = "Aceptar"
		Me.CmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.CmdOk.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(223, 42)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(41, 13)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "Unidad"
		'
		'TxtPlazo
		'
		Me.TxtPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtPlazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtPlazo.Location = New System.Drawing.Point(98, 38)
		Me.TxtPlazo.MaxLength = 2
		Me.TxtPlazo.Name = "TxtPlazo"
		Me.TxtPlazo.Size = New System.Drawing.Size(97, 20)
		Me.TxtPlazo.TabIndex = 2
		'
		'CbFormaPago
		'
		Me.CbFormaPago.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.CbFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CbFormaPago.Location = New System.Drawing.Point(98, 9)
		Me.CbFormaPago.Margin = New System.Windows.Forms.Padding(4)
		Me.CbFormaPago.Name = "CbFormaPago"
		Me.CbFormaPago.Size = New System.Drawing.Size(325, 21)
		Me.CbFormaPago.TabIndex = 1
		'
		'CbUnidad
		'
		Me.CbUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.CbUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.CbUnidad.BackColor = System.Drawing.SystemColors.Window
		Me.CbUnidad.Cursor = System.Windows.Forms.Cursors.Default
		Me.CbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbUnidad.ForeColor = System.Drawing.SystemColors.WindowText
		Me.CbUnidad.Items.AddRange(New Object() {"Años", "Días", "Meses"})
		Me.CbUnidad.Location = New System.Drawing.Point(276, 37)
		Me.CbUnidad.Name = "CbUnidad"
		Me.CbUnidad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CbUnidad.Size = New System.Drawing.Size(147, 21)
		Me.CbUnidad.Sorted = True
		Me.CbUnidad.TabIndex = 3
		'
		'LblContacto
		'
		Me.LblContacto.AutoSize = True
		Me.LblContacto.Location = New System.Drawing.Point(13, 10)
		Me.LblContacto.Name = "LblContacto"
		Me.LblContacto.Size = New System.Drawing.Size(79, 13)
		Me.LblContacto.TabIndex = 0
		Me.LblContacto.Text = "Forma de Pago"
		'
		'LblBancoConsig
		'
		Me.LblBancoConsig.AutoSize = True
		Me.LblBancoConsig.Location = New System.Drawing.Point(13, 42)
		Me.LblBancoConsig.Name = "LblBancoConsig"
		Me.LblBancoConsig.Size = New System.Drawing.Size(33, 13)
		Me.LblBancoConsig.TabIndex = 2
		Me.LblBancoConsig.Text = "Plazo"
		'
		'LblPagado
		'
		Me.LblPagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblPagado.Location = New System.Drawing.Point(676, 298)
		Me.LblPagado.Name = "LblPagado"
		Me.LblPagado.Size = New System.Drawing.Size(171, 21)
		Me.LblPagado.TabIndex = 28
		Me.LblPagado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(602, 301)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(71, 13)
		Me.Label3.TabIndex = 27
		Me.Label3.Text = "Total Pagado"
		'
		'Grd
		'
		Me.Grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Grd.DMSCopiarDt = True
		Me.Grd.DMSTituloDelInforme = ""
		Me.Grd.Location = New System.Drawing.Point(12, 154)
		Me.Grd.Name = "Grd"
		Me.Grd.Size = New System.Drawing.Size(835, 141)
		Me.Grd.TabIndex = 29
		'
		'LblValorDocumento
		'
		Me.LblValorDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblValorDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblValorDocumento.Location = New System.Drawing.Point(304, 10)
		Me.LblValorDocumento.Name = "LblValorDocumento"
		Me.LblValorDocumento.Size = New System.Drawing.Size(137, 22)
		Me.LblValorDocumento.TabIndex = 30
		Me.LblValorDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'fFormasPagoVentas
		'
		Me.AcceptButton = Me.CmdOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.CmdCancel
		Me.ClientSize = New System.Drawing.Size(856, 328)
		Me.ControlBox = False
		Me.Controls.Add(Me.LblValorDocumento)
		Me.Controls.Add(Me.Grd)
		Me.Controls.Add(Me.LblPagado)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PnlFormaPago)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.TxtValorPagar)
		Me.Controls.Add(Me.LnkDocRef)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "fFormasPagoVentas"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Tag = "0"
		Me.Text = "Formas de Pago Ventas"
		Me.Controls.SetChildIndex(Me.LnkDocRef, 0)
		Me.Controls.SetChildIndex(Me.TxtValorPagar, 0)
		Me.Controls.SetChildIndex(Me.Label9, 0)
		Me.Controls.SetChildIndex(Me.PnlFormaPago, 0)
		Me.Controls.SetChildIndex(Me.Label3, 0)
		Me.Controls.SetChildIndex(Me.LblPagado, 0)
		Me.Controls.SetChildIndex(Me.Grd, 0)
		Me.Controls.SetChildIndex(Me.LblValorDocumento, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PnlFormaPago.ResumeLayout(False)
		Me.PnlFormaPago.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LnkDocRef As LinkLabel
    Public WithEvents Label9 As Label
    Public WithEvents TxtValorPagar As TextBox
    Public WithEvents PnlFormaPago As Panel
    Public WithEvents CbUnidad As ComboBox
    Friend WithEvents LblContacto As Label
    Public WithEvents LblBancoConsig As Label
    Public WithEvents CbFormaPago As ComboDMS
    Public WithEvents Label1 As Label
    Public WithEvents TxtPlazo As TextBox
    Friend WithEvents CmdConti As BotonEstandar
    Public WithEvents LnkEliminar As LinkLabel
    Friend WithEvents LnkEditar As LinkLabel
    Public WithEvents CmdNueva As BotonEstandar
    Public WithEvents CmdCancel As BotonEstandar
    Public WithEvents CmdOk As BotonEstandar
    Public WithEvents LblPagado As Label
    Public WithEvents Label3 As Label
    Friend WithEvents Grd As GridDms
    Public WithEvents LblValorDocumento As Label
End Class
