<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fSplash))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblApl = New System.Windows.Forms.Label()
        Me.LogoSMD = New System.Windows.Forms.PictureBox()
        Me.LnkOcultar = New System.Windows.Forms.LinkLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblLite = New System.Windows.Forms.PictureBox()
        CType(Me.LogoSMD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblLite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(51, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hola"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Timer1
        '
        '
        'LblApl
        '
        Me.LblApl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LblApl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApl.ForeColor = System.Drawing.Color.Blue
        Me.LblApl.Location = New System.Drawing.Point(205, 267)
        Me.LblApl.Name = "LblApl"
        Me.LblApl.Size = New System.Drawing.Size(246, 20)
        Me.LblApl.TabIndex = 2
        Me.LblApl.Text = "..."
        Me.LblApl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LogoSMD
        '
        Me.LogoSMD.BackColor = System.Drawing.Color.Transparent
        Me.LogoSMD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoSMD.Image = CType(resources.GetObject("LogoSMD.Image"), System.Drawing.Image)
        Me.LogoSMD.Location = New System.Drawing.Point(0, 0)
        Me.LogoSMD.Name = "LogoSMD"
        Me.LogoSMD.Size = New System.Drawing.Size(497, 440)
        Me.LogoSMD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoSMD.TabIndex = 4
        Me.LogoSMD.TabStop = False
        '
        'LnkOcultar
        '
        Me.LnkOcultar.AutoSize = True
        Me.LnkOcultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LnkOcultar.ForeColor = System.Drawing.Color.White
        Me.LnkOcultar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkOcultar.LinkColor = System.Drawing.Color.White
        Me.LnkOcultar.Location = New System.Drawing.Point(231, 298)
        Me.LnkOcultar.Name = "LnkOcultar"
        Me.LnkOcultar.Size = New System.Drawing.Size(41, 13)
        Me.LnkOcultar.TabIndex = 5
        Me.LnkOcultar.TabStop = True
        Me.LnkOcultar.Text = "Ocultar"
        Me.LnkOcultar.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.Location = New System.Drawing.Point(130, 232)
        Me.ProgressBar1.Maximum = 13
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(242, 15)
        Me.ProgressBar1.TabIndex = 6
        Me.ProgressBar1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'LblLite
        '
        Me.LblLite.BackColor = System.Drawing.Color.White
        Me.LblLite.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblLite.Image = CType(resources.GetObject("LblLite.Image"), System.Drawing.Image)
        Me.LblLite.Location = New System.Drawing.Point(315, 110)
        Me.LblLite.Name = "LblLite"
        Me.LblLite.Size = New System.Drawing.Size(93, 37)
        Me.LblLite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LblLite.TabIndex = 53
        Me.LblLite.TabStop = False
        Me.LblLite.Visible = False
        '
        'fSplash
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(497, 440)
        Me.Controls.Add(Me.LblLite)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LnkOcultar)
        Me.Controls.Add(Me.LblApl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogoSMD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fSplash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advance..."
        CType(Me.LogoSMD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblLite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents LogoSMD As System.Windows.Forms.PictureBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LnkOcultar As System.Windows.Forms.LinkLabel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Public WithEvents LblApl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents LblLite As System.Windows.Forms.PictureBox
End Class
