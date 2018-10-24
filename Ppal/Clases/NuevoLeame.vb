' Version: 681, 20-ago.-2018 20:08
' Version: 665, 16-jul.-2018 13:20
'♥ versión: 586, 6-oct.-2017 07:11
Public Class NuevoLeame
    Public Shared Sub Mostrar_Leame_Programa(ByRef Formas As FormCollection, CualId As String, Tipo As Short, Optional TituloOtros As String = "")
		Dim IdOrig As String = "P" & CualId & "|" & Tipo & "|" & Replace(TituloOtros, " ", "●")
		DebugJD("MLP:" & CualId & "," & Tipo & "," & TituloOtros)

		Try

			Dim Linea_Divisora As String = "<HR width=100% align=""left"">"

			If Tipo = 0 Then 'programa
				If EstaEnLista(CualId, "1301", "1302", "1303", "1304") Then
					If Not Pregunte("Desea ver el " & CualId & "? (Responda N para ver el 5502?") Then
						CualId = "5502"
					End If
				End If

				If CualId = "5510" Then
					CualId = "1306"
				End If

			End If

			SiReloj()

			Dim ds As New DataSet

			Dim sq As String = ""
			If TituloOtros = "" Then
				sq = "GetLeameTotal_un_Prog '" & CualId & "'," & Tipo & "," & Numero_Empresa & "," & Usuario & ",'" & MarcaExterna & "'"
			Else
				sq = "GetLeameTotal_un_Otros '" & TituloOtros & "'" & "," & Numero_Empresa & "," & Usuario & ",'" & MarcaExterna & "'," & Tipo
			End If

			'If MarcaExterna = "local" Then
			'    Abrir(ds, sq)
			'Else
			Abrir_Nodo_1(ds, sq)
			'End If

			If Fin(ds.Tables(1)) Then
				NoReloj()
				Mensaje("No encontró información sobre [Leame]")
				Exit Sub
			End If

			Dim Tex As String = ""

			Tex &= Gdf(ds.Tables(0), "head")
			Tex &= Gdf(ds.Tables(0), "font")
			Tex &= Gdf(ds.Tables(0), "titulo")
			Tex &= Linea_Divisora
			Tex &= "<A href=""#manual"">Ver manual del usuario</A>"
			Dim primera As Boolean = True
			Dim especial As String = ""
			Dim especial_fin As String = ""
			For Each ro As DataRow In ds.Tables(1).Rows
				If ro("titulo").ToString.Contains("Manual del Usuario") Then
					If Not primera Then
						Tex &= Linea_Divisora
						especial = "<p><span style=""color: blue;"">" & "<A name=""manual"">"
						especial_fin = "</A>" & "</span></p>"
					End If
				End If

				Tex &= especial & ro("titulo") & especial_fin & ro("texto")

				primera = False
				especial = ""
				especial_fin = ""
			Next

			Tex &= Gdf(ds.Tables(0), "cierre_font")

			'Dim file As System.IO.StreamWriter
			'file = My.Computer.FileSystem.OpenTextFileWriter("c:\smd_files\leame_prog.html", False)


			'file.WriteLine(Tex)
			'file.Close()

			NoReloj()

			'AbrirLink("file:///c:/smd_files/leame_prog.html")
			'AbrirWeb(Formas, "file:///c:/smd_files/leame_prog.html", Gdf(ds.Tables(0), "titulo_forma"), IdOrig)
			AbrirWeb(Formas, "", Gdf(ds.Tables(0), "titulo_forma"), IdOrig, Tex)

		Catch ex As Exception
			NoReloj()

			Mensaje(ex.Message)

		End Try
    End Sub
End Class
