<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMarcaLineaModelo
    Inherits SMDPpal.AdvanceForm


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMarcaLineaModelo))
        Me.LnkMarca = New System.Windows.Forms.LinkLabel()
        Me.LblIDMod = New System.Windows.Forms.Label()
        Me.LblIDLin = New System.Windows.Forms.Label()
        Me.LblIDMarca = New System.Windows.Forms.Label()
        Me.CbMarca = New System.Windows.Forms.ComboBox()
        Me.CbModelo = New System.Windows.Forms.ComboBox()
        Me.CbLinea = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmdAceptar = New SMDPpal.BotonEstandar()
        Me.CmdCancelar = New SMDPpal.BotonEstandar()
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicPuntoAdv
        '
        Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicPuntoAdv.Location = New System.Drawing.Point(354, 0)
        '
        'LnkMarca
        '
        Me.LnkMarca.AutoSize = True
        Me.LnkMarca.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkMarca.Location = New System.Drawing.Point(10, 16)
        Me.LnkMarca.Name = "LnkMarca"
        Me.LnkMarca.Size = New System.Drawing.Size(37, 13)
        Me.LnkMarca.TabIndex = 179
        Me.LnkMarca.TabStop = True
        Me.LnkMarca.Text = "Marca"
        '
        'LblIDMod
        '
        Me.LblIDMod.AutoSize = True
        Me.LblIDMod.Location = New System.Drawing.Point(304, 64)
        Me.LblIDMod.Name = "LblIDMod"
        Me.LblIDMod.Size = New System.Drawing.Size(18, 13)
        Me.LblIDMod.TabIndex = 178
        Me.LblIDMod.Text = "ID"
        Me.LblIDMod.Visible = False
        '
        'LblIDLin
        '
        Me.LblIDLin.AutoSize = True
        Me.LblIDLin.Location = New System.Drawing.Point(304, 40)
        Me.LblIDLin.Name = "LblIDLin"
        Me.LblIDLin.Size = New System.Drawing.Size(18, 13)
        Me.LblIDLin.TabIndex = 177
        Me.LblIDLin.Text = "ID"
        Me.LblIDLin.Visible = False
        '
        'LblIDMarca
        '
        Me.LblIDMarca.AutoSize = True
        Me.LblIDMarca.Location = New System.Drawing.Point(304, 16)
        Me.LblIDMarca.Name = "LblIDMarca"
        Me.LblIDMarca.Size = New System.Drawing.Size(18, 13)
        Me.LblIDMarca.TabIndex = 176
        Me.LblIDMarca.Text = "ID"
        Me.LblIDMarca.Visible = False
        '
        'CbMarca
        '
        Me.CbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMarca.ForeColor = System.Drawing.Color.Black
        Me.CbMarca.FormattingEnabled = True
        Me.CbMarca.Location = New System.Drawing.Point(102, 12)
        Me.CbMarca.Name = "CbMarca"
        Me.CbMarca.Size = New System.Drawing.Size(196, 21)
        Me.CbMarca.TabIndex = 171
        '
        'CbModelo
        '
        Me.CbModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CbModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbModelo.ForeColor = System.Drawing.Color.Black
        Me.CbModelo.FormattingEnabled = True
        Me.CbModelo.Location = New System.Drawing.Point(102, 60)
        Me.CbModelo.Name = "CbModelo"
        Me.CbModelo.Size = New System.Drawing.Size(196, 21)
        Me.CbModelo.TabIndex = 173
        '
        'CbLinea
        '
        Me.CbLinea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CbLinea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbLinea.ForeColor = System.Drawing.Color.Black
        Me.CbLinea.FormattingEnabled = True
        Me.CbLinea.Location = New System.Drawing.Point(102, 36)
        Me.CbLinea.Name = "CbLinea"
        Me.CbLinea.Size = New System.Drawing.Size(196, 21)
        Me.CbLinea.TabIndex = 172
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 174
        Me.Label6.Text = "Línea"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 175
        Me.Label9.Text = "Modelo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.Color.White
        Me.CmdAceptar.BackgroundImage = CType(resources.GetObject("CmdAceptar.BackgroundImage"), System.Drawing.Image)
        Me.CmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAceptar.ForeColor = System.Drawing.Color.White
        Me.CmdAceptar.Location = New System.Drawing.Point(102, 94)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.Size = New System.Drawing.Size(94, 28)
        Me.CmdAceptar.TabIndex = 180
        Me.CmdAceptar.Text = "Aceptar"
        Me.CmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.Color.White
        Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
        Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancelar.ForeColor = System.Drawing.Color.White
        Me.CmdCancelar.Location = New System.Drawing.Point(202, 94)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(96, 28)
        Me.CmdCancelar.TabIndex = 181
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        'fMarcaLineaModelo
        '
        Me.AcceptButton = Me.CmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CmdCancelar
        Me.ClientSize = New System.Drawing.Size(375, 129)
        Me.ControlBox = False
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.LnkMarca)
        Me.Controls.Add(Me.LblIDMod)
        Me.Controls.Add(Me.LblIDLin)
        Me.Controls.Add(Me.LblIDMarca)
        Me.Controls.Add(Me.CbMarca)
        Me.Controls.Add(Me.CbModelo)
        Me.Controls.Add(Me.CbLinea)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fMarcaLineaModelo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "fMarcaLineaModelo"
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.CbLinea, 0)
        Me.Controls.SetChildIndex(Me.CbModelo, 0)
        Me.Controls.SetChildIndex(Me.CbMarca, 0)
        Me.Controls.SetChildIndex(Me.LblIDMarca, 0)
        Me.Controls.SetChildIndex(Me.LblIDLin, 0)
        Me.Controls.SetChildIndex(Me.LblIDMod, 0)
        Me.Controls.SetChildIndex(Me.LnkMarca, 0)
        Me.Controls.SetChildIndex(Me.CmdAceptar, 0)
        Me.Controls.SetChildIndex(Me.CmdCancelar, 0)
        Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LnkMarca As System.Windows.Forms.LinkLabel
    Friend WithEvents LblIDMod As System.Windows.Forms.Label
    Friend WithEvents LblIDLin As System.Windows.Forms.Label
    Friend WithEvents LblIDMarca As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmdAceptar As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
    Public WithEvents CbMarca As System.Windows.Forms.ComboBox
    Public WithEvents CbModelo As System.Windows.Forms.ComboBox
    Public WithEvents CbLinea As System.Windows.Forms.ComboBox
End Class
