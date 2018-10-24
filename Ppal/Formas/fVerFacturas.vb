' Version: 695, 4-oct.-2018 12:56
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 650, 7-may.-2018 12:42
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fVerFacturas
    Public DtFac As DataTable
    Public NombreSp As String = ""
    Public ProgramaLlama As String = "2035"
    Public Sw As Short = 1

    Private Sub fVerFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Text = Idi(Me.Text)

		Try
			If DtFac Is Nothing Then
				SiReloj()
				Abrir(DtFac, NombreSp)
				NoReloj()
			End If
			GrdFac.DMSLlene_Grid(DtFac, "id", MostrarEliminar:=False)
			GrdFac.Grid.Columns("id").Width = 60

		Catch ex As Exception
			NoReloj()
			MostrarError(Me.Name, "fVerFacturas_Load", ex.Message)
			Me.Close()
			Exit Sub

		End Try

	End Sub

	Private Sub GridDms1_DMSTraerValor(Sender As Object, ValorColDevolver As Object) Handles GrdFac.DMSTraerValor
		CmdImprimir_Click(CmdImprimir, New EventArgs)

	End Sub

	Private Sub CmdImprimir_Click(sender As Object, e As EventArgs) Handles CmdImprimir.Click
		Dim Paso As String = "1"
		Try
			If NoPuede4(ProgramaLlama, 800) Then
				Exit Sub
			End If

			Paso = "2"
			If GrdFac.Grid.SelectedRows.Count = 0 Then
				Mensaje("Seleccione factura")
				Exit Sub
			End If

			Paso = "3"
			Dim IdDoc As Integer = ValD(Tm(GrdFac.Grid, "id"))


			Paso = "4"
			Dim Ds1 As New DataSet
			If CtrImprimir1.DMSImprimir > 0 Then
				Paso = "5"
				Imprima_Documento(Ds1, Me, Nothing, Numero_Empresa, Sw, IdDoc, 2, MostrarFormato:=ChkFormato.Checked, NuevoImprimir:=CtrImprimir1.DMSImprimir, EsCopia:=Not ChkOriginal.Checked)
			End If

			'jdms 650: segunda impresión
			ClaseCertif.Imprimir_Certificado_Compra(-1, Me, Ds1, IdDoc, Sw)
			'/jdms 650

		Catch ex As Exception
			MostrarError(Me.Name, "CmdImprimir_Click: paso: " & Paso, ex.Message)

		End Try


    End Sub

    Private Sub ChkOriginal_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOriginal.CheckedChanged
        If ChkOriginal.Checked Then
            If NoPuede4("1104", 700) Then
                ChkOriginal.Checked = False
                Exit Sub
            End If
        End If

    End Sub

    Private Sub ChkFormato_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFormato.CheckedChanged
        If ChkFormato.Checked Then
            If NoPuede4("1104", 23) Then
                ChkFormato.Checked = False
                Exit Sub
            End If
        End If

    End Sub

    Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click
        Me.Close()

    End Sub
End Class