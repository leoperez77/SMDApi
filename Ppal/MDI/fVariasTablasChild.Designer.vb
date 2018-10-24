<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fVariasTablasChild
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
        Me.GridDms1 = New SMDPpal.GridDms()
        Me.SuspendLayout()
        '
        'GridDms1
        '
        Me.GridDms1.DMSCopiarDt = True
        Me.GridDms1.DMSTituloDelInforme = ""
        Me.GridDms1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDms1.Location = New System.Drawing.Point(0, 0)
        Me.GridDms1.Name = "GridDms1"
        Me.GridDms1.Size = New System.Drawing.Size(768, 336)
        Me.GridDms1.TabIndex = 0
        '
        'fVariasTablasChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 336)
        Me.Controls.Add(Me.GridDms1)
        Me.Name = "fVariasTablasChild"
        Me.Text = "fUnaTabla"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents GridDms1 As SMDPpal.GridDms
End Class
