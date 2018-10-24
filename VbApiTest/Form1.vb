Imports Newtonsoft.Json
Imports SMDApi.Client
Public Class Form1

    Private Sub SurroundingSub()

    End Sub
    Private Async Sub Ejecutar()
        Dim Command = New SMDApi.DTO.SqlCommand() With {
         .Sql = txtQuery.Text,
         .Type = 1
     }
        Dim res = Await ApiService.Post(Of SMDApi.DTO.SqlCommand)("api", "ds", Command)
        Dim ds As DataSet = JsonConvert.DeserializeObject(Of DataSet)(res.Result.ToString())
        Grid1.DataSource = ds.Tables(0)
        Grid1.Refresh()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ejecutar()
    End Sub
End Class
