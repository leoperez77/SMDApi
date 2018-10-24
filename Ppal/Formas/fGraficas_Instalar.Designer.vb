<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGraficas_Instalar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fGraficas_Instalar))
        Me.Label1 = New System.Windows.Forms.Label
        Me.LnkMS = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.LnkDMS = New System.Windows.Forms.LinkLabel
        Me.LnkDetalles = New System.Windows.Forms.LinkLabel
        Me.LnkFrame = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.PnlFrame = New System.Windows.Forms.Panel
        Me.PnlChat = New System.Windows.Forms.Panel
        Me.PnlFrame.SuspendLayout()
        Me.PnlChat.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'LnkMS
        '
        Me.LnkMS.AutoSize = True
        Me.LnkMS.Location = New System.Drawing.Point(34, 91)
        Me.LnkMS.Name = "LnkMS"
        Me.LnkMS.Size = New System.Drawing.Size(290, 13)
        Me.LnkMS.TabIndex = 1
        Me.LnkMS.TabStop = True
        Me.LnkMS.Text = "Instalar Microsoft Chart ahora (desde la página de Microsoft)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "o también puede"
        '
        'LnkDMS
        '
        Me.LnkDMS.AutoSize = True
        Me.LnkDMS.Location = New System.Drawing.Point(42, 159)
        Me.LnkDMS.Name = "LnkDMS"
        Me.LnkDMS.Size = New System.Drawing.Size(271, 13)
        Me.LnkDMS.TabIndex = 3
        Me.LnkDMS.TabStop = True
        Me.LnkDMS.Text = "Instalar Microsoft Chart ahora (desde la página de DMS)"
        '
        'LnkDetalles
        '
        Me.LnkDetalles.AutoSize = True
        Me.LnkDetalles.Location = New System.Drawing.Point(150, 215)
        Me.LnkDetalles.Name = "LnkDetalles"
        Me.LnkDetalles.Size = New System.Drawing.Size(45, 13)
        Me.LnkDetalles.TabIndex = 4
        Me.LnkDetalles.TabStop = True
        Me.LnkDetalles.Text = "Detalles"
        '
        'LnkFrame
        '
        Me.LnkFrame.AutoSize = True
        Me.LnkFrame.Location = New System.Drawing.Point(75, 102)
        Me.LnkFrame.Name = "LnkFrame"
        Me.LnkFrame.Size = New System.Drawing.Size(160, 13)
        Me.LnkFrame.TabIndex = 5
        Me.LnkFrame.TabStop = True
        Me.LnkFrame.Text = "Instalar Microsoft Framework 3.5"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(37, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 49)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Necesita el FrameWork 3.5 o superior. Si no lo tiene instalado aún, haga click en" & _
            " el link que se muestra a continuación:"
        '
        'PnlFrame
        '
        Me.PnlFrame.Controls.Add(Me.Label3)
        Me.PnlFrame.Controls.Add(Me.LnkFrame)
        Me.PnlFrame.Location = New System.Drawing.Point(13, 241)
        Me.PnlFrame.Name = "PnlFrame"
        Me.PnlFrame.Size = New System.Drawing.Size(354, 142)
        Me.PnlFrame.TabIndex = 7
        Me.PnlFrame.Visible = False
        '
        'PnlChat
        '
        Me.PnlChat.Controls.Add(Me.Label1)
        Me.PnlChat.Controls.Add(Me.LnkMS)
        Me.PnlChat.Controls.Add(Me.Label2)
        Me.PnlChat.Controls.Add(Me.LnkDMS)
        Me.PnlChat.Location = New System.Drawing.Point(13, 12)
        Me.PnlChat.Name = "PnlChat"
        Me.PnlChat.Size = New System.Drawing.Size(354, 191)
        Me.PnlChat.TabIndex = 8
        Me.PnlChat.Visible = False
        '
        'fGraficas_Instalar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(379, 233)
        Me.Controls.Add(Me.PnlChat)
        Me.Controls.Add(Me.PnlFrame)
        Me.Controls.Add(Me.LnkDetalles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "fGraficas_Instalar"
        Me.Text = "Instalar Graficación"
        Me.PnlFrame.ResumeLayout(False)
        Me.PnlFrame.PerformLayout()
        Me.PnlChat.ResumeLayout(False)
        Me.PnlChat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LnkMS As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LnkDMS As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkDetalles As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkFrame As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PnlFrame As System.Windows.Forms.Panel
    Friend WithEvents PnlChat As System.Windows.Forms.Panel
End Class
