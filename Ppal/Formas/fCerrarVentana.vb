Public Class fCerrarVentana
    Public Forma As Form
    Public SoloOcular As Boolean = False

    Private Sub TimerCerrar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCerrar.Tick
        Try
            Forma.Opacity = Forma.Opacity - 0.02
            If Forma.Opacity < 0.01 Then
                If SoloOcular Then
                    Forma.Hide()
                    Forma.Opacity = 1
                Else
                    Forma.Close()
                End If
                Me.Close()
            End If

        Catch ex As Exception
            If SoloOcular Then
                Forma.Hide()
                Forma.Opacity = 1
            Else
                Forma.Close()
            End If
            Me.Close()

        End Try

    End Sub

    Private Sub fCerrarVentana_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Forma.Opacity = 0.9
        TimerCerrar.Start()

    End Sub
End Class