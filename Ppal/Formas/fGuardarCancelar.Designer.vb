<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGuardarCancelar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fGuardarCancelar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CmdCancelar = New SMDPpal.BotonEstandar()
        Me.CmdNoGuardar = New SMDPpal.BotonEstandar()
        Me.CmdGuardar = New SMDPpal.BotonEstandar()
        Me.LblPregunta = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CmdCancelar)
        Me.Panel1.Controls.Add(Me.CmdNoGuardar)
        Me.Panel1.Controls.Add(Me.CmdGuardar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 52)
        Me.Panel1.TabIndex = 0
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.Color.White
        Me.CmdCancelar.BackgroundImage = CType(resources.GetObject("CmdCancelar.BackgroundImage"), System.Drawing.Image)
        Me.CmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancelar.ForeColor = System.Drawing.Color.White
        Me.CmdCancelar.Location = New System.Drawing.Point(230, 13)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(82, 27)
        Me.CmdCancelar.TabIndex = 2
        Me.CmdCancelar.Tag = "3"
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        'CmdNoGuardar
        '
        Me.CmdNoGuardar.BackColor = System.Drawing.Color.White
        Me.CmdNoGuardar.BackgroundImage = CType(resources.GetObject("CmdNoGuardar.BackgroundImage"), System.Drawing.Image)
        Me.CmdNoGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdNoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNoGuardar.ForeColor = System.Drawing.Color.White
        Me.CmdNoGuardar.Location = New System.Drawing.Point(139, 13)
        Me.CmdNoGuardar.Name = "CmdNoGuardar"
        Me.CmdNoGuardar.Size = New System.Drawing.Size(82, 27)
        Me.CmdNoGuardar.TabIndex = 1
        Me.CmdNoGuardar.Tag = "2"
        Me.CmdNoGuardar.Text = "No guardar"
        Me.CmdNoGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdNoGuardar.UseVisualStyleBackColor = False
        '
        'CmdGuardar
        '
        Me.CmdGuardar.BackColor = System.Drawing.Color.White
        Me.CmdGuardar.BackgroundImage = CType(resources.GetObject("CmdGuardar.BackgroundImage"), System.Drawing.Image)
        Me.CmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdGuardar.ForeColor = System.Drawing.Color.White
        Me.CmdGuardar.Location = New System.Drawing.Point(49, 13)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(82, 27)
        Me.CmdGuardar.TabIndex = 0
        Me.CmdGuardar.Tag = "1"
        Me.CmdGuardar.Text = "Guardar"
        Me.CmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdGuardar.UseVisualStyleBackColor = False
        '
        'LblPregunta
        '
        Me.LblPregunta.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPregunta.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LblPregunta.Location = New System.Drawing.Point(0, 0)
        Me.LblPregunta.Name = "LblPregunta"
        Me.LblPregunta.Size = New System.Drawing.Size(356, 63)
        Me.LblPregunta.TabIndex = 1
        Me.LblPregunta.Text = "Label1"
        Me.LblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fGuardarCancelar
        '
        Me.AcceptButton = Me.CmdGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CmdCancelar
        Me.ClientSize = New System.Drawing.Size(356, 118)
        Me.Controls.Add(Me.LblPregunta)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fGuardarCancelar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Advance"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmdCancelar As SMDPpal.BotonEstandar
    Friend WithEvents CmdNoGuardar As SMDPpal.BotonEstandar
    Friend WithEvents CmdGuardar As SMDPpal.BotonEstandar
    Friend WithEvents LblPregunta As System.Windows.Forms.Label
End Class
