<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fVarios
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
        Me.CmdAplicar = New SMDPpal.BotonEstandar()
        Me.CmdQuitar = New SMDPpal.BotonEstandar()
        Me.CmdCancel = New SMDPpal.BotonEstandar()
        Me.CamposAdicionales1 = New SMDPpal.CamposAdicionales()
        Me.SuspendLayout()
        '
        'CmdAplicar
        '
        Me.CmdAplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdAplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAplicar.Location = New System.Drawing.Point(529, 443)
        Me.CmdAplicar.Name = "CmdAplicar"
        Me.CmdAplicar.Size = New System.Drawing.Size(96, 23)
        Me.CmdAplicar.TabIndex = 1
        Me.CmdAplicar.Tag = "1"
        Me.CmdAplicar.Text = "Aplicar Filtros"
        Me.CmdAplicar.UseVisualStyleBackColor = True
        '
        'CmdQuitar
        '
        Me.CmdQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdQuitar.Location = New System.Drawing.Point(631, 443)
        Me.CmdQuitar.Name = "CmdQuitar"
        Me.CmdQuitar.Size = New System.Drawing.Size(75, 23)
        Me.CmdQuitar.TabIndex = 2
        Me.CmdQuitar.Tag = "0"
        Me.CmdQuitar.Text = "Quitar Filtros"
        Me.CmdQuitar.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancel.Location = New System.Drawing.Point(712, 443)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.CmdCancel.TabIndex = 3
        Me.CmdCancel.Text = "Cancelar"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CamposAdicionales1
        '
        Me.CamposAdicionales1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CamposAdicionales1.DMSPrograma = "1901"
        Me.CamposAdicionales1.DMSTabla = "ite"
        Me.CamposAdicionales1.Location = New System.Drawing.Point(12, 7)
        Me.CamposAdicionales1.MaximumSize = New System.Drawing.Size(766, 423)
        Me.CamposAdicionales1.MinimumSize = New System.Drawing.Size(766, 423)
        Me.CamposAdicionales1.Name = "CamposAdicionales1"
        Me.CamposAdicionales1.Size = New System.Drawing.Size(766, 423)
        Me.CamposAdicionales1.TabIndex = 0
        '
        'fVarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.CmdCancel
        Me.ClientSize = New System.Drawing.Size(790, 472)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdQuitar)
        Me.Controls.Add(Me.CmdAplicar)
        Me.Controls.Add(Me.CamposAdicionales1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fVarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Campos Varios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CamposAdicionales1 As SMDPpal.CamposAdicionales
    Friend WithEvents CmdAplicar As System.Windows.Forms.Button
    Friend WithEvents CmdQuitar As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
End Class
