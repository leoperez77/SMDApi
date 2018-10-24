<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvanceNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvanceNew))
        Me.JDMS_Panel1 = New System.Windows.Forms.Panel()
        Me.JDMS_Titulo = New System.Windows.Forms.Label()
        Me.JDMS_PnlBotones = New System.Windows.Forms.Panel()
        Me.JDMS_CmdMinimizar = New System.Windows.Forms.Button()
        Me.JDMS_CerrarForma = New System.Windows.Forms.Button()
        Me.JDMS_CmdMaximizar = New System.Windows.Forms.Button()
        Me.JDMS_Icono = New System.Windows.Forms.PictureBox()
        Me.JDMS_Panel1.SuspendLayout()
        Me.JDMS_PnlBotones.SuspendLayout()
        CType(Me.JDMS_Icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JDMS_Panel1
        '
        Me.JDMS_Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.JDMS_Panel1.BackgroundImage = CType(resources.GetObject("JDMS_Panel1.BackgroundImage"), System.Drawing.Image)
        Me.JDMS_Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.JDMS_Panel1.Controls.Add(Me.JDMS_Titulo)
        Me.JDMS_Panel1.Controls.Add(Me.JDMS_PnlBotones)
        Me.JDMS_Panel1.Controls.Add(Me.JDMS_Icono)
        Me.JDMS_Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.JDMS_Panel1.Location = New System.Drawing.Point(0, 0)
        Me.JDMS_Panel1.Name = "JDMS_Panel1"
        Me.JDMS_Panel1.Size = New System.Drawing.Size(535, 25)
        Me.JDMS_Panel1.TabIndex = 5004
        '
        'JDMS_Titulo
        '
        Me.JDMS_Titulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JDMS_Titulo.Location = New System.Drawing.Point(109, 0)
        Me.JDMS_Titulo.Name = "JDMS_Titulo"
        Me.JDMS_Titulo.Size = New System.Drawing.Size(359, 22)
        Me.JDMS_Titulo.TabIndex = 5004
        Me.JDMS_Titulo.Text = "Titulo"
        Me.JDMS_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'JDMS_PnlBotones
        '
        Me.JDMS_PnlBotones.Controls.Add(Me.JDMS_CmdMinimizar)
        Me.JDMS_PnlBotones.Controls.Add(Me.JDMS_CerrarForma)
        Me.JDMS_PnlBotones.Controls.Add(Me.JDMS_CmdMaximizar)
        Me.JDMS_PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.JDMS_PnlBotones.Location = New System.Drawing.Point(470, 0)
        Me.JDMS_PnlBotones.Name = "JDMS_PnlBotones"
        Me.JDMS_PnlBotones.Size = New System.Drawing.Size(65, 25)
        Me.JDMS_PnlBotones.TabIndex = 5006
        '
        'JDMS_CmdMinimizar
        '
        Me.JDMS_CmdMinimizar.Cursor = System.Windows.Forms.Cursors.Default
        Me.JDMS_CmdMinimizar.FlatAppearance.BorderSize = 0
        Me.JDMS_CmdMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.JDMS_CmdMinimizar.Location = New System.Drawing.Point(2, 0)
        Me.JDMS_CmdMinimizar.Name = "JDMS_CmdMinimizar"
        Me.JDMS_CmdMinimizar.Size = New System.Drawing.Size(19, 21)
        Me.JDMS_CmdMinimizar.TabIndex = 5000
        Me.JDMS_CmdMinimizar.Tag = ""
        Me.JDMS_CmdMinimizar.Text = "__"
        Me.JDMS_CmdMinimizar.UseVisualStyleBackColor = True
        '
        'JDMS_CerrarForma
        '
        Me.JDMS_CerrarForma.FlatAppearance.BorderSize = 0
        Me.JDMS_CerrarForma.Location = New System.Drawing.Point(46, 0)
        Me.JDMS_CerrarForma.Name = "JDMS_CerrarForma"
        Me.JDMS_CerrarForma.Size = New System.Drawing.Size(19, 21)
        Me.JDMS_CerrarForma.TabIndex = 5002
        Me.JDMS_CerrarForma.Text = "Χ"
        Me.JDMS_CerrarForma.UseVisualStyleBackColor = True
        '
        'JDMS_CmdMaximizar
        '
        Me.JDMS_CmdMaximizar.FlatAppearance.BorderSize = 0
        Me.JDMS_CmdMaximizar.Location = New System.Drawing.Point(24, 0)
        Me.JDMS_CmdMaximizar.Name = "JDMS_CmdMaximizar"
        Me.JDMS_CmdMaximizar.Size = New System.Drawing.Size(19, 21)
        Me.JDMS_CmdMaximizar.TabIndex = 5001
        Me.JDMS_CmdMaximizar.Text = "□"
        Me.JDMS_CmdMaximizar.UseVisualStyleBackColor = True
        '
        'JDMS_Icono
        '
        Me.JDMS_Icono.Location = New System.Drawing.Point(81, 0)
        Me.JDMS_Icono.Name = "JDMS_Icono"
        Me.JDMS_Icono.Size = New System.Drawing.Size(26, 23)
        Me.JDMS_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.JDMS_Icono.TabIndex = 1
        Me.JDMS_Icono.TabStop = False
        '
        'AdvanceNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.JDMS_Panel1)
        Me.Name = "AdvanceNew"
        Me.JDMS_Panel1.ResumeLayout(False)
        Me.JDMS_PnlBotones.ResumeLayout(False)
        CType(Me.JDMS_Icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents JDMS_Panel1 As System.Windows.Forms.Panel
    Friend WithEvents JDMS_Titulo As System.Windows.Forms.Label
    Friend WithEvents JDMS_PnlBotones As System.Windows.Forms.Panel
    Friend WithEvents JDMS_CmdMinimizar As System.Windows.Forms.Button
    Friend WithEvents JDMS_CerrarForma As System.Windows.Forms.Button
    Friend WithEvents JDMS_CmdMaximizar As System.Windows.Forms.Button
    Friend WithEvents JDMS_Icono As System.Windows.Forms.PictureBox
End Class
