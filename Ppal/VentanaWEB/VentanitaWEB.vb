' Version: 600, 27-nov.-2017 18:45
'♥ versión: 586, 6-oct.-2017 07:11
Public Class VentanitaWEB
	Public Shared CerrarVentanaWEB As Boolean = False

	''' <summary>
	''' Con esta rutina se muestra la ventana WEB con datos traidos de un SP preferiblemente con formato HTML.
	''' Ejemplo: ver el SP GetCotDatosItemWeb que es llamado por el 5502
	''' </summary>
	''' <param name="Formas">Parámetro obligatorio para saber si ya está abierta la ventanita WEB</param>
	''' <param name="FormaLlamadora">Form que hace el llamado, nomalmente se escribe "Me"</param>
	''' <param name="DtTexto">Datatable que trae una sola columna y un solo registro con todo el resultado a mostrar</param>
	''' <param name="TituloVentana">Título que desea mostrar en la ventana</param>
	''' <param name="SegundosVisible">En cuántos segundos después de mostrada desea que se oculte la ventana WEB</param>
	Public Shared Sub MostrarVentanaWeb(ByRef Formas As FormCollection, FormaLlamadora As Form, DtTexto As DataTable, TituloVentana As String, Optional SegundosVisible As Integer = 6)
		Dim PonerFoco As Boolean = False
		If DtTexto Is Nothing Then
			DtTexto = New DataTable
			DtTexto.Columns.Add("msg")
			DtTexto.Rows.Add(TituloVentana)
			TituloVentana = "Mensaje informativo"
			PonerFoco = True
		End If
		If Fin(DtTexto) Then
			Exit Sub
		End If

		If FormaYaEstaAbierta3(Formas, Nothing, "fWeb_Especial", TituloVentana) Then Exit Sub
		Dim fWebChi As New fWeb_Especial
		fWebChi.Tag = TituloVentana
		fWebChi.Text = TituloVentana
		fWebChi.FormaLlamadora = FormaLlamadora
		fWebChi.Seccion = DtTexto.Columns(0).ColumnName

		Try
			Dim Tamaño() As String = GetSetting("DMS S.A.", "web_esp", FormaLlamadora.Name & fWebChi.Seccion, fWebChi.Width & "," & fWebChi.Height).ToString.Split(",")
			fWebChi.Width = Tamaño(0)
			fWebChi.Height = Tamaño(1)
		Catch
		End Try

		'para ubicarlo en la esquina inferior derecha
		Dim PosX = FormaLlamadora.Left + FormaLlamadora.Width - fWebChi.Width
		Dim PosY = FormaLlamadora.Top + FormaLlamadora.Height - fWebChi.Height

		fWebChi.Location = New Point(PosX, PosY)


		'Dim file As System.IO.StreamWriter
		'file = My.Computer.FileSystem.OpenTextFileWriter("c:\smd_files\item.html", False)
		'file.WriteLine(TextoHTML)
		'file.Close()

		'fW.WebBrowser1.Url = New Uri("file:///c:/smd_files/item.html")
		fWebChi.WebBrowser1.DocumentText = "" & DtTexto.Rows(0).Item(0)

		fWebChi.SegundosVisible = SegundosVisible

		fWebChi.Show()

		If Not PonerFoco Then
			FormaLlamadora.Focus()
		End If

	End Sub
End Class
