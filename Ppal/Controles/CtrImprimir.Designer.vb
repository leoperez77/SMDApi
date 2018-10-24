<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrImprimir
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
        Me.OptImpr = New System.Windows.Forms.RadioButton()
        Me.OptMail = New System.Windows.Forms.RadioButton()
        Me.OptNinguna = New System.Windows.Forms.RadioButton()
        Me.OptVer = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChkCruzar = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptImpr
        '
        Me.OptImpr.AutoSize = True
        Me.OptImpr.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptImpr.Location = New System.Drawing.Point(2, 0)
        Me.OptImpr.Name = "OptImpr"
        Me.OptImpr.Size = New System.Drawing.Size(57, 16)
        Me.OptImpr.TabIndex = 41
        Me.OptImpr.TabStop = True
        Me.OptImpr.Text = "Imprimir"
        Me.OptImpr.UseVisualStyleBackColor = True
        '
        'OptMail
        '
        Me.OptMail.AutoSize = True
        Me.OptMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptMail.Location = New System.Drawing.Point(2, 19)
        Me.OptMail.Name = "OptMail"
        Me.OptMail.Size = New System.Drawing.Size(66, 16)
        Me.OptMail.TabIndex = 42
        Me.OptMail.TabStop = True
        Me.OptMail.Text = "email/chat"
        Me.OptMail.UseVisualStyleBackColor = True
        '
        'OptNinguna
        '
        Me.OptNinguna.AutoSize = True
        Me.OptNinguna.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptNinguna.Location = New System.Drawing.Point(67, 19)
        Me.OptNinguna.Name = "OptNinguna"
        Me.OptNinguna.Size = New System.Drawing.Size(45, 16)
        Me.OptNinguna.TabIndex = 43
        Me.OptNinguna.TabStop = True
        Me.OptNinguna.Text = "Nada"
        Me.OptNinguna.UseVisualStyleBackColor = True
        '
        'OptVer
        '
        Me.OptVer.AutoSize = True
        Me.OptVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptVer.Location = New System.Drawing.Point(67, 0)
        Me.OptVer.Name = "OptVer"
        Me.OptVer.Size = New System.Drawing.Size(38, 16)
        Me.OptVer.TabIndex = 44
        Me.OptVer.TabStop = True
        Me.OptVer.Text = "Ver"
        Me.OptVer.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ChkCruzar)
        Me.Panel1.Controls.Add(Me.OptNinguna)
        Me.Panel1.Controls.Add(Me.OptVer)
        Me.Panel1.Controls.Add(Me.OptImpr)
        Me.Panel1.Controls.Add(Me.OptMail)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(117, 57)
        Me.Panel1.TabIndex = 45
        '
        'ChkCruzar
        '
        Me.ChkCruzar.AutoSize = True
        Me.ChkCruzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCruzar.Location = New System.Drawing.Point(2, 39)
        Me.ChkCruzar.Name = "ChkCruzar"
        Me.ChkCruzar.Size = New System.Drawing.Size(96, 16)
        Me.ChkCruzar.TabIndex = 45
        Me.ChkCruzar.TabStop = True
        Me.ChkCruzar.Text = "Cruzar al terminar"
        Me.ChkCruzar.UseVisualStyleBackColor = True
        Me.ChkCruzar.Visible = False
        '
        'CtrImprimir
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CtrImprimir"
        Me.Size = New System.Drawing.Size(117, 57)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents OptImpr As System.Windows.Forms.RadioButton
    Public WithEvents OptMail As System.Windows.Forms.RadioButton
    Public WithEvents OptNinguna As System.Windows.Forms.RadioButton
    Public WithEvents OptVer As System.Windows.Forms.RadioButton
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents ChkCruzar As System.Windows.Forms.RadioButton

End Class
