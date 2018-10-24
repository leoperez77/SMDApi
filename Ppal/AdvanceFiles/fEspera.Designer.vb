<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fEspera
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.LblTardar = New System.Windows.Forms.Label()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(118, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 89)
        Me.Label1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(306, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'PicLogo
        '
        Me.PicLogo.BackColor = System.Drawing.Color.White
        Me.PicLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicLogo.Location = New System.Drawing.Point(0, 25)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(116, 91)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLogo.TabIndex = 141
        Me.PicLogo.TabStop = False
        '
        'LblTardar
        '
        Me.LblTardar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTardar.ForeColor = System.Drawing.Color.Red
        Me.LblTardar.Location = New System.Drawing.Point(54, 4)
        Me.LblTardar.Name = "LblTardar"
        Me.LblTardar.Size = New System.Drawing.Size(185, 15)
        Me.LblTardar.TabIndex = 142
        Me.LblTardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblTardar.Visible = False
        '
        'fEspera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 117)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblTardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicLogo)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fEspera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Subiendo a la nube..."
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LblTardar As System.Windows.Forms.Label
End Class
