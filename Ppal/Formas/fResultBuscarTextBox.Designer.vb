<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fResultBuscarTextBox
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChkMMT = New System.Windows.Forms.CheckBox
        Me.ChkAtras = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(281, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar"
        '
        'ChkMMT
        '
        Me.ChkMMT.AutoSize = True
        Me.ChkMMT.Location = New System.Drawing.Point(16, 73)
        Me.ChkMMT.Name = "ChkMMT"
        Me.ChkMMT.Size = New System.Drawing.Size(217, 17)
        Me.ChkMMT.TabIndex = 2
        Me.ChkMMT.Text = "Coincidir mayúsculas, minúsculas y tildes"
        Me.ChkMMT.UseVisualStyleBackColor = True
        '
        'ChkAtras
        '
        Me.ChkAtras.AutoSize = True
        Me.ChkAtras.Location = New System.Drawing.Point(16, 114)
        Me.ChkAtras.Name = "ChkAtras"
        Me.ChkAtras.Size = New System.Drawing.Size(114, 17)
        Me.ChkAtras.TabIndex = 3
        Me.ChkAtras.Text = "Buscar hacia atrás"
        Me.ChkAtras.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(198, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fResultBuscarTextBox
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(309, 199)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChkAtras)
        Me.Controls.Add(Me.ChkMMT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "fResultBuscarTextBox"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "fResultBuscarTextBox"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkMMT As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAtras As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
