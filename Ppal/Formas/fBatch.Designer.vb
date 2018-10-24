<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fBatch
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
        Me.EjecutarBatch = New System.ComponentModel.BackgroundWorker()
        Me.EjecutarBatchOtro = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'EjecutarBatch
        '
        '
        'EjecutarBatchOtro
        '
        '
        'fBatch
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(191, 101)
        Me.Name = "fBatch"
        Me.Text = "Ejecutar cualquier cosa Batch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EjecutarBatch As System.ComponentModel.BackgroundWorker
    Friend WithEvents EjecutarBatchOtro As System.ComponentModel.BackgroundWorker
End Class
