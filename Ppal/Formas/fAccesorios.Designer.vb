<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fAccesorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fAccesorios))
        Me.Grd = New SMDPpal.GridDms()
        Me.ChkTodos = New System.Windows.Forms.CheckBox()
        Me.CmdOK = New SMDPpal.BotonEstandar()
        Me.CmdCancel = New SMDPpal.BotonEstandar()
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicPuntoAdv
        '
        Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicPuntoAdv.Location = New System.Drawing.Point(636, 0)
        '
        'Grd
        '
        Me.Grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grd.DMSCopiarDt = True
        Me.Grd.DMSTituloDelInforme = ""
        Me.Grd.Location = New System.Drawing.Point(12, 33)
        Me.Grd.Name = "Grd"
        Me.Grd.Size = New System.Drawing.Size(633, 314)
        Me.Grd.TabIndex = 2
        '
        'ChkTodos
        '
        Me.ChkTodos.AutoSize = True
        Me.ChkTodos.Location = New System.Drawing.Point(12, 15)
        Me.ChkTodos.Name = "ChkTodos"
        Me.ChkTodos.Size = New System.Drawing.Size(107, 17)
        Me.ChkTodos.TabIndex = 3
        Me.ChkTodos.Text = "Todos / Ninguno"
        Me.ChkTodos.UseVisualStyleBackColor = True
        '
        'CmdOK
        '
        Me.CmdOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdOK.BackColor = System.Drawing.Color.White
        Me.CmdOK.BackgroundImage = CType(resources.GetObject("CmdOK.BackgroundImage"), System.Drawing.Image)
        Me.CmdOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdOK.ForeColor = System.Drawing.Color.White
        Me.CmdOK.Location = New System.Drawing.Point(205, 362)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(110, 36)
        Me.CmdOK.TabIndex = 4
        Me.CmdOK.Text = "Aceptar"
        Me.CmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdOK.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdCancel.BackColor = System.Drawing.Color.White
        Me.CmdCancel.BackgroundImage = CType(resources.GetObject("CmdCancel.BackgroundImage"), System.Drawing.Image)
        Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancel.ForeColor = System.Drawing.Color.White
        Me.CmdCancel.Location = New System.Drawing.Point(332, 362)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(110, 36)
        Me.CmdCancel.TabIndex = 5
        Me.CmdCancel.Text = "Cancelar"
        Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'fAccesorios
        '
        Me.AcceptButton = Me.CmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CmdCancel
        Me.ClientSize = New System.Drawing.Size(657, 410)
        Me.ControlBox = False
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.Grd)
        Me.Controls.Add(Me.ChkTodos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fAccesorios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Accesorios"
        Me.Controls.SetChildIndex(Me.ChkTodos, 0)
        Me.Controls.SetChildIndex(Me.Grd, 0)
        Me.Controls.SetChildIndex(Me.CmdOK, 0)
        Me.Controls.SetChildIndex(Me.CmdCancel, 0)
        Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grd As SMDPpal.GridDms
    Friend WithEvents ChkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents CmdOK As SMDPpal.BotonEstandar
    Friend WithEvents CmdCancel As SMDPpal.BotonEstandar
End Class
