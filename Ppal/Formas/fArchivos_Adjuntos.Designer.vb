<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fArchivos_Adjuntos
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblArchivo = New System.Windows.Forms.Label
        Me.LblPregunta = New System.Windows.Forms.Label
        Me.CmdAbrir = New System.Windows.Forms.Button
        Me.CmdGuardar = New System.Windows.Forms.Button
        Me.CmdCancelar = New System.Windows.Forms.Button
        Me.LblProc = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Archivo:"
        '
        'LblArchivo
        '
        Me.LblArchivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblArchivo.Location = New System.Drawing.Point(64, 13)
        Me.LblArchivo.Name = "LblArchivo"
        Me.LblArchivo.Size = New System.Drawing.Size(238, 69)
        Me.LblArchivo.TabIndex = 1
        Me.LblArchivo.Text = "Nombre Archivo"
        '
        'LblPregunta
        '
        Me.LblPregunta.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LblPregunta.AutoSize = True
        Me.LblPregunta.Location = New System.Drawing.Point(64, 95)
        Me.LblPregunta.Name = "LblPregunta"
        Me.LblPregunta.Size = New System.Drawing.Size(222, 13)
        Me.LblPregunta.TabIndex = 2
        Me.LblPregunta.Text = "Desea abrir archivo o guardarlo en el equipo?"
        '
        'CmdAbrir
        '
        Me.CmdAbrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdAbrir.Location = New System.Drawing.Point(12, 13)
        Me.CmdAbrir.Name = "CmdAbrir"
        Me.CmdAbrir.Size = New System.Drawing.Size(75, 23)
        Me.CmdAbrir.TabIndex = 3
        Me.CmdAbrir.Text = "Abrir"
        Me.CmdAbrir.UseVisualStyleBackColor = True
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdGuardar.Location = New System.Drawing.Point(95, 13)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.CmdGuardar.TabIndex = 4
        Me.CmdGuardar.Text = "Guardar"
        Me.CmdGuardar.UseVisualStyleBackColor = True
        '
        'CmdCancelar
        '
        Me.CmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdCancelar.Location = New System.Drawing.Point(178, 13)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.CmdCancelar.TabIndex = 5
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.UseVisualStyleBackColor = True
        '
        'LblProc
        '
        Me.LblProc.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LblProc.AutoSize = True
        Me.LblProc.ForeColor = System.Drawing.Color.Red
        Me.LblProc.Location = New System.Drawing.Point(89, 167)
        Me.LblProc.Name = "LblProc"
        Me.LblProc.Size = New System.Drawing.Size(172, 13)
        Me.LblProc.TabIndex = 6
        Me.LblProc.Text = "Descargando archivo de Internet..."
        Me.LblProc.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmdAbrir)
        Me.Panel1.Controls.Add(Me.CmdGuardar)
        Me.Panel1.Controls.Add(Me.CmdCancelar)
        Me.Panel1.Location = New System.Drawing.Point(40, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 49)
        Me.Panel1.TabIndex = 7
        '
        'fArchivos_Adjuntos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(350, 189)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblProc)
        Me.Controls.Add(Me.LblPregunta)
        Me.Controls.Add(Me.LblArchivo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fArchivos_Adjuntos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abrir archivo"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblArchivo As System.Windows.Forms.Label
    Friend WithEvents LblPregunta As System.Windows.Forms.Label
    Friend WithEvents CmdAbrir As System.Windows.Forms.Button
    Friend WithEvents CmdGuardar As System.Windows.Forms.Button
    Friend WithEvents CmdCancelar As System.Windows.Forms.Button
    Friend WithEvents LblProc As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
