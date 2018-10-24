<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fWeb
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fWeb))
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.LnkChat = New System.Windows.Forms.LinkLabel()
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicPuntoAdv
		'
		Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PicPuntoAdv.Location = New System.Drawing.Point(821, 0)
		'
		'WebBrowser1
		'
		Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
		Me.WebBrowser1.Location = New System.Drawing.Point(0, 41)
		Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.WebBrowser1.ScriptErrorsSuppressed = True
		Me.WebBrowser1.Size = New System.Drawing.Size(842, 521)
		Me.WebBrowser1.TabIndex = 12
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.White
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
		Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(842, 37)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 13
		Me.PictureBox1.TabStop = False
		'
		'LnkChat
		'
		Me.LnkChat.AutoSize = True
		Me.LnkChat.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkChat.Location = New System.Drawing.Point(8, 11)
		Me.LnkChat.Name = "LnkChat"
		Me.LnkChat.Size = New System.Drawing.Size(79, 13)
		Me.LnkChat.TabIndex = 14
		Me.LnkChat.TabStop = True
		Me.LnkChat.Text = "Enviar por chat"
		'
		'fWeb
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(842, 562)
		Me.Controls.Add(Me.LnkChat)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.WebBrowser1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "fWeb"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Web - Advance"
		Me.Controls.SetChildIndex(Me.WebBrowser1, 0)
		Me.Controls.SetChildIndex(Me.PictureBox1, 0)
		Me.Controls.SetChildIndex(Me.LnkChat, 0)
		Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
		CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Public WithEvents WebBrowser1 As WebBrowser
	Public WithEvents PictureBox1 As PictureBox
	Public WithEvents LnkChat As LinkLabel
End Class
