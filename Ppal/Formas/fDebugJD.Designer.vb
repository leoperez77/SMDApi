<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDebugJD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fDebugJD))
        Me.TxtDebug = New System.Windows.Forms.TextBox()
        Me.ChkDetener = New System.Windows.Forms.CheckBox()
        Me.LnkDetener = New System.Windows.Forms.LinkLabel()
        Me.LnkLimpiar = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LnkFiltro = New System.Windows.Forms.LinkLabel()
        Me.LnkFuente = New System.Windows.Forms.LinkLabel()
        Me.LblSize = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtDebug
        '
        Me.TxtDebug.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDebug.BackColor = System.Drawing.Color.White
        Me.TxtDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDebug.Location = New System.Drawing.Point(0, 22)
        Me.TxtDebug.Multiline = True
        Me.TxtDebug.Name = "TxtDebug"
        Me.TxtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDebug.Size = New System.Drawing.Size(412, 290)
        Me.TxtDebug.TabIndex = 59
        '
        'ChkDetener
        '
        Me.ChkDetener.AutoSize = True
        Me.ChkDetener.Location = New System.Drawing.Point(7, 3)
        Me.ChkDetener.Name = "ChkDetener"
        Me.ChkDetener.Size = New System.Drawing.Size(59, 17)
        Me.ChkDetener.TabIndex = 60
        Me.ChkDetener.Text = "Pausar"
        Me.ChkDetener.UseVisualStyleBackColor = True
        '
        'LnkDetener
        '
        Me.LnkDetener.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LnkDetener.AutoSize = True
        Me.LnkDetener.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkDetener.Location = New System.Drawing.Point(326, 3)
        Me.LnkDetener.Name = "LnkDetener"
        Me.LnkDetener.Size = New System.Drawing.Size(80, 13)
        Me.LnkDetener.TabIndex = 61
        Me.LnkDetener.TabStop = True
        Me.LnkDetener.Text = "Detener Debug"
        '
        'LnkLimpiar
        '
        Me.LnkLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LnkLimpiar.AutoSize = True
        Me.LnkLimpiar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkLimpiar.Location = New System.Drawing.Point(247, 3)
        Me.LnkLimpiar.Name = "LnkLimpiar"
        Me.LnkLimpiar.Size = New System.Drawing.Size(40, 13)
        Me.LnkLimpiar.TabIndex = 62
        Me.LnkLimpiar.TabStop = True
        Me.LnkLimpiar.Text = "Limpiar"
        '
        'Timer1
        '
        '
        'LnkFiltro
        '
        Me.LnkFiltro.AutoSize = True
        Me.LnkFiltro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkFiltro.Location = New System.Drawing.Point(71, 4)
        Me.LnkFiltro.Name = "LnkFiltro"
        Me.LnkFiltro.Size = New System.Drawing.Size(29, 13)
        Me.LnkFiltro.TabIndex = 63
        Me.LnkFiltro.TabStop = True
        Me.LnkFiltro.Text = "Filtro"
        '
        'LnkFuente
        '
        Me.LnkFuente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LnkFuente.AutoSize = True
        Me.LnkFuente.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkFuente.Location = New System.Drawing.Point(160, 4)
        Me.LnkFuente.Name = "LnkFuente"
        Me.LnkFuente.Size = New System.Drawing.Size(40, 13)
        Me.LnkFuente.TabIndex = 64
        Me.LnkFuente.TabStop = True
        Me.LnkFuente.Text = "Fuente"
        '
        'LblSize
        '
        Me.LblSize.AutoSize = True
        Me.LblSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSize.Location = New System.Drawing.Point(141, 36)
        Me.LblSize.Name = "LblSize"
        Me.LblSize.Size = New System.Drawing.Size(37, 20)
        Me.LblSize.TabIndex = 65
        Me.LblSize.Text = "size"
        Me.LblSize.Visible = False
        '
        'fDebugJD
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(412, 314)
        Me.Controls.Add(Me.LblSize)
        Me.Controls.Add(Me.LnkFuente)
        Me.Controls.Add(Me.LnkFiltro)
        Me.Controls.Add(Me.LnkLimpiar)
        Me.Controls.Add(Me.LnkDetener)
        Me.Controls.Add(Me.ChkDetener)
        Me.Controls.Add(Me.TxtDebug)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fDebugJD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Debug"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDebug As System.Windows.Forms.TextBox
    Friend WithEvents ChkDetener As System.Windows.Forms.CheckBox
    Friend WithEvents LnkDetener As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkLimpiar As System.Windows.Forms.LinkLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LnkFiltro As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkFuente As System.Windows.Forms.LinkLabel
    Friend WithEvents LblSize As System.Windows.Forms.Label
End Class
