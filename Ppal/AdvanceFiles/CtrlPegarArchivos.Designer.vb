<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlPegarArchivos
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlPegarArchivos))
		Me.LnkAdicionar = New System.Windows.Forms.LinkLabel()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.LblStatus = New System.Windows.Forms.Label()
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.PicLogo = New System.Windows.Forms.PictureBox()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.ChkHeaders = New System.Windows.Forms.CheckBox()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.Grd = New SMDPpal.GridDms()
		CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LnkAdicionar
		'
		Me.LnkAdicionar.AutoSize = True
		Me.LnkAdicionar.BackColor = System.Drawing.Color.White
		Me.LnkAdicionar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LnkAdicionar.Location = New System.Drawing.Point(35, 4)
		Me.LnkAdicionar.Name = "LnkAdicionar"
		Me.LnkAdicionar.Size = New System.Drawing.Size(89, 13)
		Me.LnkAdicionar.TabIndex = 38
		Me.LnkAdicionar.TabStop = True
		Me.LnkAdicionar.Text = "Adicionar archivo"
		Me.LnkAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblStatus
		'
		Me.LblStatus.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.LblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LblStatus.ForeColor = System.Drawing.Color.Olive
		Me.LblStatus.Location = New System.Drawing.Point(32, 38)
		Me.LblStatus.Name = "LblStatus"
		Me.LblStatus.Size = New System.Drawing.Size(100, 23)
		Me.LblStatus.TabIndex = 40
		Me.LblStatus.Text = "Leyendo..."
		Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.LblStatus.Visible = False
		'
		'ImageList1
		'
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
		Me.ImageList1.Images.SetKeyName(0, "word2.jpeg")
		Me.ImageList1.Images.SetKeyName(1, "excel2.png")
		Me.ImageList1.Images.SetKeyName(2, "pdf2.png")
		Me.ImageList1.Images.SetKeyName(3, "archivo.jpeg")
		Me.ImageList1.Images.SetKeyName(4, "gif.jpeg")
		Me.ImageList1.Images.SetKeyName(5, "png.jpeg")
		Me.ImageList1.Images.SetKeyName(6, "sql.png")
		Me.ImageList1.Images.SetKeyName(7, "texto.jpeg")
		Me.ImageList1.Images.SetKeyName(8, "video.jpeg")
		Me.ImageList1.Images.SetKeyName(9, "voz.jpeg")
		Me.ImageList1.Images.SetKeyName(10, "jpg.jpeg")
		Me.ImageList1.Images.SetKeyName(11, "ppt2.png")
		Me.ImageList1.Images.SetKeyName(12, "exe2.png")
		Me.ImageList1.Images.SetKeyName(13, "zip.jpeg")
		Me.ImageList1.Images.SetKeyName(14, "html3.jpg")
		Me.ImageList1.Images.SetKeyName(15, "rpt.jpeg")
		Me.ImageList1.Images.SetKeyName(16, "psd.png")
		'
		'PicLogo
		'
		Me.PicLogo.BackColor = System.Drawing.Color.White
		Me.PicLogo.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
		Me.PicLogo.Location = New System.Drawing.Point(2, 0)
		Me.PicLogo.Name = "PicLogo"
		Me.PicLogo.Size = New System.Drawing.Size(28, 22)
		Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PicLogo.TabIndex = 139
		Me.PicLogo.TabStop = False
		'
		'BackgroundWorker1
		'
		Me.BackgroundWorker1.WorkerSupportsCancellation = True
		'
		'ChkHeaders
		'
		Me.ChkHeaders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ChkHeaders.AutoSize = True
		Me.ChkHeaders.Location = New System.Drawing.Point(124, 5)
		Me.ChkHeaders.Name = "ChkHeaders"
		Me.ChkHeaders.Size = New System.Drawing.Size(15, 14)
		Me.ChkHeaders.TabIndex = 140
		Me.ChkHeaders.UseVisualStyleBackColor = True
		Me.ChkHeaders.Visible = False
		'
		'Grd
		'
		Me.Grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Grd.BackColor = System.Drawing.Color.White
		Me.Grd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Grd.DMSCopiarDt = True
		Me.Grd.DMSTituloDelInforme = ""
		Me.Grd.Location = New System.Drawing.Point(-1, 22)
		Me.Grd.Name = "Grd"
		Me.Grd.Size = New System.Drawing.Size(158, 56)
		Me.Grd.TabIndex = 39
		Me.Grd.Visible = False
		'
		'CtrlPegarArchivos
		'
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.ChkHeaders)
		Me.Controls.Add(Me.LblStatus)
		Me.Controls.Add(Me.PicLogo)
		Me.Controls.Add(Me.LnkAdicionar)
		Me.Controls.Add(Me.Grd)
		Me.Name = "CtrlPegarArchivos"
		Me.Size = New System.Drawing.Size(157, 78)
		CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LnkAdicionar As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
    Public WithEvents Grd As SMDPpal.GridDms
    Friend WithEvents ChkHeaders As System.Windows.Forms.CheckBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Public WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Public WithEvents LblStatus As System.Windows.Forms.Label

End Class
