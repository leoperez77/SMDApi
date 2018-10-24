' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fEspera
    Public fCtrl As CtrlPegarArchivos
    Dim Conta As Double = 0
    Dim EmpiezaRetrazo As DateTime
    Dim Retrazo As Boolean = False



	Private Sub fEspera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_Idioma(Me, Me)


		Timer1.Start()

	End Sub
	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Label1.Text = Now
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            Conta += Timer1.Interval / 1000 'ya que el interval el 200 , cada 5 veces suma 1
            ProgressBar1.Value = CInt(Conta)
        Else
            If Not Retrazo Then
                Retrazo = True
                EmpiezaRetrazo = Now
            Else
                If DateDiff(DateInterval.Second, EmpiezaRetrazo, Now) > 5 Then
                    LblTardar.Text = "Proceso demorado " & Strings.Format(Now, "HH:mm:ss")
                    LblTardar.Visible = True
                End If
            End If
        End If

        Label1.Text = fCtrl.TextoProgreso

        HagaEventos()

    End Sub


  
End Class