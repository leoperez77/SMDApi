'♥ versión: 586, 6-oct.-2017 07:11
Public Class fInputBoxDMS

    Private Sub fInputBoxDMS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If SoyHandHeld() Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub


    'Private Sub Grid_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
    '    Mensaje("Un solo clic")

    'End Sub
    Private Sub Grid_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Me.Tag = "S"
        Me.Hide()

    End Sub

    Private Sub fInputBoxDMS_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.Tag = "C"
            Me.Hide()
        End If

    End Sub




    Private Sub fInputBoxDMS_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Try
            Grid.Rows(Grid.Tag).Selected = True
        Catch
            Grid.ClearSelection()
        End Try

    End Sub

    Private Sub LnkSeleccionar_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkSeleccionar.LinkClicked
        Seleccionar()

    End Sub
    Private Sub Seleccionar()
        If Grid.SelectedRows.Count = 0 Then
            Mensaje("Seleccione alguna opción")
            Exit Sub
        End If

        Me.Tag = "S"
        Me.Hide()

    End Sub
    Private Sub CmdCancelar_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CmdCancelar.LinkClicked
        Me.Tag = "C"
        Me.Hide()

    End Sub

    Private Sub LnkSeleccionar_Enter(sender As System.Object, e As System.EventArgs) Handles LnkSeleccionar.Enter, CmdCancelar.Enter
        Grid.Focus()

    End Sub


    Private Sub fInputBoxDMS_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            e.SuppressKeyPress = True
            Seleccionar()
        End If

    End Sub
End Class