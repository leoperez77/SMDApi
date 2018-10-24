' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
Public Class CDigitalizacion
    Public Shared Sub Subir_Archivo_Digital(Origen As String, Destino As String, Optional ProducirPlano As Boolean = False)
        If ProducirPlano Then 'este para desocupar el ftp con un archivo de 1kb
            Origen = "c:\smd_files\vacio.txt"
            If Not IO.File.Exists(Origen) Then
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(Origen, True)
                file.Close()
            End If
        End If

        Dim TxtUsuarioFTP As String = ReglaDeNegocio(180, "usuario", "")
        Dim TxtClaveFTP As String = ReglaDeNegocio(180, "clave", "")
        Dim RutaFTP As String = ReglaDeNegocio(180, "ruta", "") & "/" & MarcaExterna & Numero_Empresa
        'My.Computer.Network.UploadFile(LblRuta.Text & TxtArchivo.Text, RutaFTP & "/" & NumeroID.ToString & TxtArchivo.Text, TxtUsuarioFTP, TxtClaveFTP, True, 50000, FileIO.UICancelOption.DoNothing)
        My.Computer.Network.UploadFile(Origen, RutaFTP & "/" & Destino, TxtUsuarioFTP, TxtClaveFTP, False, 50000)

    End Sub

    Public Shared Function Abrir_Archivo_Digital(IdArchivo As Integer, NombreArchivo As String, Optional SoloGrabar As Boolean = False) As String


        If Not SoloGrabar Then
            If Not Pregunte("Seguro abrir este archivo?", , "Digitalizador") Then
                Return ""
            End If
        End If


        Dim Ima As New DataTable

        SiReloj()

        'si ya está guardado, saltar
        Dim ArchivoGuardar As String = Path_Temp & "dg" & IdArchivo.ToString & "_" & NombreArchivo
        If IO.File.Exists(ArchivoGuardar) Then
            GoTo Virtualizado
        End If


        Try
            Abrir(Ima, "GetDigitalizacionImagen " & IdArchivo.ToString)
            If Fin(Ima) Then
                Mensaje("Archivo No existe")
                Return ""
            End If
            If Gdf(Ima, "imagen") Is System.DBNull.Value Then
                If ReglaDeNegocio(180, "usar_ftp", "0") = "1" Then
                    GoTo Desde_Ftp
                End If

                NoReloj()
                Mensaje("Archivo está vacío. Vuelva a escanearlo")
                Return ""
            End If

        Catch ex As Exception
            NoReloj()
			MostrarError("Ppal", "Abrir_Archivo_Digital: Abrir", ex.Message)
			Return ""
		End Try

		Try
			SalvarFoto(CType(Gdf(Ima, "imagen"), Byte()), ArchivoGuardar, "")

		Catch ex As Exception
			NoReloj()
			MostrarError("Ppal", "Abrir_Archivo_Digital: Salvar", ex.Message)
			Return ""
		End Try

Virtualizado:
		If Not SoloGrabar Then
			AbrirArchivo(ArchivoGuardar)
		End If

		NoReloj()

		Return ArchivoGuardar

Desde_Ftp:
		Try
			Dim TxtUsuarioFTP As String = ReglaDeNegocio(180, "usuario", "")
			Dim TxtClaveFTP As String = ReglaDeNegocio(180, "clave", "")
			Dim RutaFTP As String = ReglaDeNegocio(180, "ruta", "") & "/" & MarcaExterna & Numero_Empresa
			'My.Computer.Network.DownloadFile(RutaFTP & "/" & IdArchivo.ToString & NombreArchivo, ArchivoGuardar, TxtUsuarioFTP, TxtClaveFTP) ', True, 50000, True)
			My.Computer.Network.DownloadFile(RutaFTP & "/" & IdArchivo.ToString, ArchivoGuardar, TxtUsuarioFTP, TxtClaveFTP) ', True, 50000, True)

		Catch ex As Exception
			NoReloj()
			MostrarError("Ppal", "Abrir_Archivo_Digital: Ftp", ex.Message)
			Return ""

        End Try
        GoTo Virtualizado

    End Function
End Class
