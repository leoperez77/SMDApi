' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fBatch
    Dim Sql As String = ""
    Dim NodoIp As String = ""

    Public Sub Auditoria_Imprimio(ByVal IdTabla As Integer, ByVal Texto As String, ByVal IdId As Integer)
        Sql = "Exec PutCotAuditoria " & IdTabla.ToString & "," & Numero_Empresa.ToString & "," & Usuario.ToString & "," & IdId.ToString & ",'" & Texto.Replace("'", "''") & "'"
        EjecutarBatch.RunWorkerAsync()


    End Sub

    Public Sub Ejecutar_Algo_Batch(ByVal TextoSQl As String)
        Sql = TextoSQl
        EjecutarBatch.RunWorkerAsync()

    End Sub
    Public Sub Ejecutar_Algo_Batch_Otro(ByVal TextoSQl As String, NodIP As String)
        Sql = TextoSQl
        NodoIp = NodIP
        Try
            EjecutarBatchOtro.RunWorkerAsync()

        Catch ex As Exception
			MostrarError(Me.Name, "Ejecutar_Algo_Batch_Otro", ex.Message)

		End Try

    End Sub

    Private Sub EjecutarBatch_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles EjecutarBatch.DoWork
        Try
            Ejecutar(Sql)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub EjecutarBatch_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles EjecutarBatch.RunWorkerCompleted
        Try
            Me.Dispose()

        Catch
            Me.Close()

        End Try

    End Sub

    Private Sub EjecutarBatchOtro_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles EjecutarBatchOtro.DoWork
        Try
            Dim Ds As New DataSet
            Abrir_Nodo_Otro(Ds, Sql, NodoIp)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub EjecutarBatchOtro_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles EjecutarBatchOtro.RunWorkerCompleted
        Try
            Me.Dispose()

        Catch
            Me.Close()

        End Try
    End Sub
End Class