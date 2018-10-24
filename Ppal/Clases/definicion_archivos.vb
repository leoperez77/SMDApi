' Version: 684, 24-ago.-2018 16:56
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 620, 7-feb.-2018 13:08
'♥ versión: 586, 6-oct.-2017 07:11
Imports System.IO
Public Class DefArch
    Public Shared Function Validar_Archivo_Importar(QuePrograma As String, ByRef dtdet As DataTable, ByRef Separador As String, ByRef Sr As System.IO.StreamReader, Nombre_Plano As String, Origen As Short) As Boolean
        Dim Archivo As String = ""
        Dim dtenc As DataTable

        Try
            If DtFmtImp Is Nothing Then
                SiReloj()
                Abrir(DtFmtImp, "GetFmtDefiniciones " & Numero_Empresa)
                NoReloj()
            End If

            'escoger un formato
            Dim Cual As String = Ventana(Filtrar_DataTable(DtFmtImp.Tables(0), "programa='" & QuePrograma & "'", "id_enc"), "Formato", True, "id_enc", New Object() {"id_enc", "programa", "tipo_archivo", "separador", "ubicacion"})
            If Cual = "" Then
                Return False
            End If

            dtenc = Filtrar_DataTable(DtFmtImp.Tables(0), "id_enc=" & Cual)
            dtdet = Filtrar_DataTable(DtFmtImp.Tables(1), "id_enc=" & Cual, "id_det")

            'definir si se toma de FTP o del disco
            If Origen = 3 Then
                Archivo = TomarArchivoFtp(Nombre_Plano, False)
                If Archivo = "" Then
                    Mensaje("No consiguió archivo por FTP")
                    Return False
                End If
                If FileLen(Archivo) = 0 Then
                    Mensaje("Archivo ya fue importado o está vacío")
                    Return False
                End If

                GoTo Saltar
            End If

			'mostrar los campos
			Dim Campos As String = ""
			For Each Fi As DataRow In Filtrar_DataTable(DtFmtImp.Tables(1), "id_enc=" & Cual, "campo_nro").Rows
				Campos &= Fi("campo_nro") & ": " & Fi("nombre_campo") & ", tipo: " & Fi("tipo_dato") & DMScr()
			Next
			If Not Pregunte("El archivo debe contener los siguientes campos:" & DMScr(2) & Campos & DMScr(2) & "Seguro de continuar?") Then
				Return False
			End If

			Dim OpenFileDialog1 As New OpenFileDialog
            OpenFileDialog1.Filter = "Archivos|*.*"
            If Gdf(dtenc, "ubicacion") IsNot DBNull.Value Then
                OpenFileDialog1.InitialDirectory = Gdf(dtenc, "ubicacion")
            End If

            Dim result As DialogResult = OpenFileDialog1.ShowDialog()
            If (result <> DialogResult.OK) Then
                Return False
            End If

            Archivo = OpenFileDialog1.FileName

        Catch ex As Exception
            NoReloj()
			Mensaje(ex.Message)
			Return False
		End Try


Saltar:

		SiReloj()

		Try


			Try
				Sr = New System.IO.StreamReader(Archivo)
			Catch ex As Exception
				NoReloj()
				Mensaje("Validación: Error abriendo archivo texto: " & ex.Message & EsIngles())
				Return False
			End Try

			Dim line As String
			line = Sr.ReadLine()
			Dim NL As Integer = 0

			Separador = "" & Gdf(dtenc, "separador")
			If Separador = "" Then
				Separador = ","
			End If

			'revisar cada línea
			Do Until line Is Nothing
				NL += 1

				Dim s() As String = Split(line, Separador)

				If s.Length <> dtdet.Rows.Count Then
					NoReloj()
					Sr.Close()
					Mensaje(Idi("Validación: Error en fila") & " " & NL & ": " & Idi("Cantidad de campos") & ": " & s.Length & ", " & Idi("campos esperados") & " " & dtdet.Rows.Count)
					Return False
				End If

				line = Sr.ReadLine()
			Loop

			Sr.Close()

			'para que siga el programa llamador
			Sr = New System.IO.StreamReader(Archivo)

		Catch ex As Exception
			NoReloj()
			Mensaje("Validación: " & ex.Message & EsIngles())
			Return False

		End Try



		NoReloj()

		Return True

	End Function
	Public Shared Function TomarArchivoFtp(NomFile As String, BorrarArchivo As Boolean, Optional SubirArchivo As Boolean = False) As String
		Dim EmpAnt As Integer = Numero_Empresa
		Try
			SiReloj()

			Numero_Empresa = 1
			Dim Ftp = ReglaDeNegocio(184, "ftp", "")
			Dim Ruta = ReglaDeNegocio(184, "ruta", "")
			Dim UsuarioFTP = ReglaDeNegocio(184, "ftp_usu", "")
			Dim ClaveFTP = ReglaDeNegocio(184, "ftp_cla", "")
			Numero_Empresa = EmpAnt

			'Dim dd As New DataTable
			'Abrir(dd, "Exec GetReglasRespUna 1,184") 'se buscan los usuarios autorizados en la empresa 1 del mismo nodo
			'NoReloj()

			'If Fin(dd) Then
			'    Return ""
			'End If

			'Dim Ftp = "" & Obtenga_Dato(dd, "llave='ftp'", "respuesta")
			If Ftp = "" Then
				NoReloj()
				Mensaje("No tiene definido ftp RN#184 emp=1")
				Return ""
			End If

			'Dim Ruta = "" & Obtenga_Dato(dd, "llave='ruta'", "respuesta")
			If Strings.Right(Ruta, 1) <> "/" Then
				Ruta &= "/"
			End If
			Ruta &= NomFile '"compra.txt"

			'Dim UsuarioFTP = "" & Obtenga_Dato(dd, "llave='ftp_usu'", "respuesta")
			'Dim ClaveFTP = "" & Obtenga_Dato(dd, "llave='ftp_cla'", "respuesta")

			Dim Archivo As String = "c:\SMD_files\" & NomFile

			If Not SubirArchivo Then
				If IO.File.Exists(Archivo) Then
					Try
						IO.File.Delete(Archivo)
					Catch ex As Exception
						Mensaje(Idi("No pudo eliminar el archivo") & " " & Archivo & ", " & Idi("ciérrelo y vuelva a intentar") & DMScr(2) & ex.Message & EsIngles())
						Return ""
					End Try
				End If
			End If


			If BorrarArchivo Then
				Dim Writer As StreamWriter
				Writer = New StreamWriter(Archivo)
				Writer.Write("")
				Writer.Close()
			End If

			If BorrarArchivo Or SubirArchivo Then
				My.Computer.Network.UploadFile(Archivo, Ftp & Ruta, UsuarioFTP, ClaveFTP, False, 50000)
			Else
				My.Computer.Network.DownloadFile(Ftp & Ruta, Archivo, UsuarioFTP, ClaveFTP, False, 90000, True)
			End If



			Return Archivo 'para que sepa que es FTP

		Catch ex As Exception
			Numero_Empresa = EmpAnt
			NoReloj()
			MostrarError("Validar_Archivo_Importar", "TomarArchivoFtp", DMScr() & "Archivo: " & NomFile & DMScr(2) & ex.Message & EsIngles())

		End Try


        Return ""


    End Function
End Class
