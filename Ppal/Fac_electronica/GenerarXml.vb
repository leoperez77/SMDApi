' Version: 686, 30-ago.-2018 12:33
' Version: 685, 28-ago.-2018 12:08
' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
' Version: 677, 15-ago.-2018 13:39
' Version: 673, 3-ago.-2018 14:58
Imports System
'Imports System.IO
'Imports System.Collections

Public Class GenerarXml

    Public Ruta As String = ReglaDeNegocio(170, "ftp", "")
    Public DirF As String = ReglaDeNegocio(170, "dir_fac", "")
    Public Usu As String = ReglaDeNegocio(170, "ftp_usu", "")
    Public Cla As String = ReglaDeNegocio(170, "ftp_cla", "")
    Dim LocalPath As String = "C:\SMD_FILES\fac_electronica\"

    Public WithEvents transfer As SecureFileTransfer

    Dim Ds As New DataSet

    Public Function Generar_Archivo(Id As Integer) As Boolean
        Try
            Dim Sq As String = ""
            Sq &= ArmeSQL("exec sp_fe_factura_encabezado", Id, qqNum)
            Sq &= ArmeSQL("exec sp_fe_factura_encabezado_adicional", Id, qqNum)
            Sq &= ArmeSQL("exec sp_fe_factura_detalle", Id, qqNum)
            Sq &= ArmeSQL("exec sp_fe_factura_detalle_adicional", Id, qqNum)
            Sq &= ArmeSQL("exec sp_fe_factura_impuesto ", Id, qqNum)
            SiReloj()
            Abrir(Ds, Sq)
            NoReloj()

            If Fin(Ds.Tables(0)) Then
				Mensaje(Idi("El documento NO ha sido procesado como F.E") & ": " & Id)
				Return False
			End If
			Dim i As Integer = 0

			Ds.Tables(0).TableName = "factura_encabezado"
			Ds.Tables(1).TableName = "factura_encabezado_adicional"
			Ds.Tables(2).TableName = "factura_detalle"
			Ds.Tables(3).TableName = "factura_detalle_adicional"
			Ds.Tables(4).TableName = "factura_impuesto"

			Dim Cad As String = ""
			Dim Hizo_algo As Boolean = False
			Dim Id_doc As Integer = 0

			Cad &= Haga_Cadena("?xml version=""1.0"" encoding=""UTF-8""?", , False)
			'Cad &= Haga_Cadena("ArrayOfDocumento xmlns=""http://tempuri.org/"" xmlnsxsi = ""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd = ""http://www.w3.org/2001/XMLSchema""", , False)
			Cad &= Haga_Cadena("ArrayOfDocumento",, False)
			Cad &= Haga_Cadena("Documento", , False)

			'Encabezado del documento
			For Each fi As DataRow In Ds.Tables("factura_encabezado").Rows
				Id_doc = fi("IdDocumento")
				Cad &= Haga_Cadena("Id", fi("Id"))
				Cad &= Haga_Cadena("Cabecera", , False)
				Cad &= Haga_Cadena("TipoTransaccion", "" & fi("TipoTransaccion"))
				Cad &= Haga_Cadena("Clasificacion", "" & fi("Clasificacion"))
				Cad &= Haga_Cadena("IdDocumento", "" & fi("IdDocumento"))
				Cad &= Haga_Cadena("DistribucionDocumento", "" & fi("DistribucionDocumento"))
				Cad &= Haga_Cadena("Tipo", "" & fi("Tipo"))
				Cad &= Haga_Cadena("Numero", "" & fi("Numero"))
				Cad &= Haga_Cadena("FechaEmision", "" & fi("FechaEmision"))
				Cad &= Haga_Cadena("FechaVencimiento", "" & fi("FechaVencimiento"))
				Cad &= Haga_Cadena("Observaciones01", "" & fi("Observaciones01"))
				Cad &= Haga_Cadena("Observaciones02", "" & fi("Observaciones02"))
				Cad &= Haga_Cadena("Moneda", "COP")
				Cad &= Haga_Cadena("FormaPago", "" & fi("FormaPago"))
				Cad &= Haga_Cadena("Vendedor", "" & fi("Vendedor"))
				Cad &= Haga_Cadena("Bodega", "" & fi("Bodega"))
				Cad &= Haga_Cadena("DesBodega", "" & fi("DesBodega"))
                'Cad &= Haga_Cadena("CabeceraAdicional1", "" & fi("CabeceraAdicional1")) 
                'Cad &= Haga_Cadena("CabeceraAdicional2", "" & fi("CabeceraAdicional2")) 
                ' Cambio el nombre para que lo reconozca carvajal: MFCH: 686
                Cad &= Haga_Cadena("CaberaAdicional1", "" & fi("CaberaAdicional1"))
                Cad &= Haga_Cadena("CaberaAdicional2", "" & fi("CaberaAdicional2"))
                Hizo_algo = True
			Next
            ' Cabera Adicionales : MFCH: 686
            Cad &= Haga_Cadena("CaberaAdicionales", , False)
            'Cabecera Adicional
            'Cad &= Haga_Cadena("CabeceraAdicional", , False)
            'For Each fi As DataRow In Ds.Tables("factura_detalle_adicional").Rows 
            For Each fi As DataRow In Ds.Tables("factura_encabezado_adicional").Rows
                'Asocio el SP correcto MFCH: 686
                Cad &= Haga_Cadena("CabeceraAdicional", , False)
                Cad &= Haga_Cadena("Valor", "" & fi("valor"))
                Cad &= Haga_Cadena("Campo", "" & fi("campo"))
                Cad &= Haga_Cadena("/CabeceraAdicional", , False)
            Next
            'Cad &= Haga_Cadena("/CabeceraAdicional", , False) 
            Cad &= Haga_Cadena("/CabeceraAdicional", , False)
            Cad &= Haga_Cadena("/CaberaAdicionales", , False)
            Cad &= Haga_Cadena("/Cabecera", , False)
            '/Cabera Adicionales : MFCH: 686

            'Informacion Emisor
            Cad &= Haga_Cadena("InformacionEmisor", , False)
			For Each fi As DataRow In Ds.Tables("factura_encabezado").Rows
				Cad &= Haga_Cadena("EmisorTipoDocumento", "" & fi("EmisorTipoDocumento"))
				Cad &= Haga_Cadena("EmisorNumeroDocumento", "" & fi("EmisorNumeroDocumento"))
				Cad &= Haga_Cadena("EmisorDigitoVerificacion", "" & fi("EmisorDigitoVerificacion"))
				Cad &= Haga_Cadena("EmisorRazonSocial", "" & fi("EmisorRazonSocial"))
				Cad &= Haga_Cadena("EmisorRazonComercial", "" & fi("EmisorRazonComercial"))
				Cad &= Haga_Cadena("EmisorDireccion", "" & fi("EmisorDireccion"))
				Cad &= Haga_Cadena("EmisorDepartamento", "" & fi("EmisorDepartamento"))
				Cad &= Haga_Cadena("EmisorCiudad", "" & fi("EmisorCiudad"))
				Cad &= Haga_Cadena("EmisorPais", "" & fi("EmisorPais"))
				Cad &= Haga_Cadena("EmisorTipoRegimen", "" & fi("EmisorTipoRegimen"))
			Next
			Cad &= Haga_Cadena("/InformacionEmisor", , False)

			'Contacto Emisor
			Cad &= Haga_Cadena("ContactoEmisor", , False)
			For Each fi As DataRow In Ds.Tables("factura_encabezado").Rows
				Cad &= Haga_Cadena("ContEmisorNombres", "" & fi("ContEmisorNombres"))
				Cad &= Haga_Cadena("ContEmisorApellido1", "" & fi("ContEmisorApellido1"))
				Cad &= Haga_Cadena("ContEmisorApellido2", "" & fi("ContEmisorApellido2"))
				Cad &= Haga_Cadena("ContEmisorArea", "" & fi("ContEmisorArea"))
				Cad &= Haga_Cadena("ContEmisorCargo", "" & fi("ContEmisorCargo"))
				Cad &= Haga_Cadena("ContEmisorTelefono", "" & fi("ContEmisorTelefono"))
				Cad &= Haga_Cadena("ContEmisorEmail", "" & fi("ContEmisorEmail"))
			Next
			Cad &= Haga_Cadena("/ContactoEmisor", , False)

			'Información Cliente
			Cad &= Haga_Cadena("InformacionCliente", , False)
			For Each fi As DataRow In Ds.Tables("factura_encabezado").Rows
				Cad &= Haga_Cadena("ClienteTipoDocumento", "" & fi("ClienteTipoDocumento"))
				Cad &= Haga_Cadena("ClienteNombresNatural", "" & fi("ClienteNombresNatural"))
				Cad &= Haga_Cadena("ClienteApellido1Natural", "" & fi("ClienteApellido1Natural"))
				Cad &= Haga_Cadena("ClienteApellido2Natural", "" & fi("ClienteApellido2Natural"))
				Cad &= Haga_Cadena("ClienteNumeroDocumento", "" & fi("ClienteNumeroDocumento"))
				Cad &= Haga_Cadena("ClienteDigitoVerificacion", "" & fi("ClienteDigitoVerificacion"))
				Cad &= Haga_Cadena("ClienteRazonSocial", "" & fi("ClienteRazonSocial"))
				Cad &= Haga_Cadena("ClienteRazonComercial", "" & fi("ClienteRazonComercial"))
				Cad &= Haga_Cadena("ClienteDireccion", "" & fi("ClienteDireccion"))
				Cad &= Haga_Cadena("ClienteDepartamento", "" & fi("ClienteDepartamento"))
				Cad &= Haga_Cadena("ClienteCiudad", "" & fi("ClienteCiudad"))
				Cad &= Haga_Cadena("ClientePais", "" & fi("ClientePais"))
				Cad &= Haga_Cadena("CienteTipoPersoneria", "" & fi("CienteTipoPersoneria"))
				Cad &= Haga_Cadena("ClienteTipoRegimen", "" & fi("ClienteTipoRegimen"))
			Next
			Cad &= Haga_Cadena("/InformacionCliente", , False)

			'Contacto Cliente
			Cad &= Haga_Cadena("ContactoCliente", , False)
			For Each fi As DataRow In Ds.Tables("factura_encabezado").Rows
				Cad &= Haga_Cadena("ContClienteNombres", "" & fi("ContClienteNombres"))
				Cad &= Haga_Cadena("ContClienteApellido1", "" & fi("ContClienteApellido1"))
				Cad &= Haga_Cadena("ContClienteApellido2", "" & fi("ContClienteApellido2"))
				Cad &= Haga_Cadena("ContClienteArea", "" & fi("ContClienteArea"))
				Cad &= Haga_Cadena("ContClienteCargo", "" & fi("ContClienteCargo"))
				Cad &= Haga_Cadena("ContClienteTelefono", "" & fi("ContClienteTelefono"))
				Cad &= Haga_Cadena("ContClienteEmail", "" & fi("ContClienteEmail"))
			Next
			Cad &= Haga_Cadena("/ContactoCliente", , False)

			'Detalles
			Cad &= Haga_Cadena("Detalles", , False)
			For Each fi As DataRow In Ds.Tables("factura_detalle").Rows
				Cad &= Haga_Cadena("Detalle", , False)
				Cad &= Haga_Cadena("DetallePedido", "" & fi("DetallePedido"))
				Cad &= Haga_Cadena("DetalleCodigo", "" & fi("DetalleCodigo"))
				Cad &= Haga_Cadena("DetalleNombre", "" & fi("DetalleNombre"))
				Cad &= Haga_Cadena("DetalleCantidad", "" & fi("DetalleCantidad"))
				Cad &= Haga_Cadena("DetalleUnidadMedida", "" & fi("DetalleUnidadMedida"))
				Cad &= Haga_Cadena("DetallePrecioUnitario", "" & fi("DetallePrecioUnitario"))
				Cad &= Haga_Cadena("DetalleValorBruto", "" & fi("DetalleValorBruto"))
				Cad &= Haga_Cadena("DetalleValorNeto", "" & fi("DetalleValorNeto"))
				Cad &= Haga_Cadena("DetallePorcentajeDescuento", "" & fi("DetallePorcentajeDescuento"))
				Cad &= Haga_Cadena("DetalleValorDescuento", "" & fi("DetalleValorDescuento"))
				Cad &= Haga_Cadena("DetallePorcentajeImpuesto", "" & fi("DetallePorcentajeImpuesto"))
				Cad &= Haga_Cadena("DetalleValorImpuesto", "" & fi("DetalleValorImpuesto"))
				Cad &= Haga_Cadena("DetalleClaseTrabajo", "" & fi("DetalleClaseTrabajo"))
				Cad &= Haga_Cadena("DetalleTiempo", "" & fi("DetalleTiempo"))
				Cad &= Haga_Cadena("DetalleClaseOperacion", "" & fi("DetalleClaseOperacion"))
				Cad &= Haga_Cadena("DetalleCodOperario", "" & fi("DetalleCodOperario"))
				Cad &= Haga_Cadena("DetalleNombreOperario", "" & fi("DetalleNombreOperario"))
				Cad &= Haga_Cadena("DetallePorcenApliDeducible", "" & fi("DetallePorcenApliDeducible"))
				Cad &= Haga_Cadena("DetalleAdicional1", "" & fi("DetalleAdicional1"))
				Cad &= Haga_Cadena("DetalleAdicional2", "" & fi("DetalleAdicional2"))

				'Detalles Adicionales
				Cad &= Haga_Cadena("DetalleAdicional", , False)
				For Each adi As DataRow In Ds.Tables("factura_detalle_adicional").Select("id=" & fi("id"))
					Cad &= Haga_Cadena("Valor", "" & adi("valor"))
					Cad &= Haga_Cadena("Campo", "" & adi("campo"))
				Next
				Cad &= Haga_Cadena("/DetalleAdicional", , False)

				Cad &= Haga_Cadena("/Detalle", , False)
			Next
			Cad &= Haga_Cadena("/Detalles", , False)

			'Impuestos
			Cad &= Haga_Cadena("Impuestos", , False)
			For Each fi As DataRow In Ds.Tables("factura_impuesto").Rows
				Cad &= Haga_Cadena("Impuesto", , False)
				Cad &= Haga_Cadena("ImpuestoCodigo", "" & fi("ImpuestoCodigo"))
				Cad &= Haga_Cadena("ImpuestoDescripcion", "" & fi("ImpuestoDescripcion"))
				Cad &= Haga_Cadena("ImpuestoBase", "" & fi("ImpuestoBase"))
				Cad &= Haga_Cadena("ImpuestoPorcentaje", "" & fi("ImpuestoPorcentaje"))
				Cad &= Haga_Cadena("ImpuestoValor", "" & fi("ImpuestoValor"))
				Cad &= Haga_Cadena("/Impuesto", , False)
			Next
			Cad &= Haga_Cadena("/Impuestos", , False)

			'Total
			Cad &= Haga_Cadena("Total", , False)
			For Each fi As DataRow In Ds.Tables("factura_encabezado").Rows
				Cad &= Haga_Cadena("TotalBruto", "" & fi("TotalBruto"))
				Cad &= Haga_Cadena("TotalDescuentos", "" & fi("TotalDescuentos"))
				Cad &= Haga_Cadena("TotalBase", "" & fi("TotalBase"))
				Cad &= Haga_Cadena("TotalIva", "" & fi("TotalIva"))
				Cad &= Haga_Cadena("TotalRetencionFuente", "" & fi("TotalRetencionFuente"))
				Cad &= Haga_Cadena("TotalRetencionIca", "" & fi("TotalRetencionIca"))
				Cad &= Haga_Cadena("TotalImpoconsumo", "" & fi("TotalImpoconsumo"))
				Cad &= Haga_Cadena("TotalGeneral", "" & fi("TotalGeneral"))
				Cad &= Haga_Cadena("TotalManoObra", "" & fi("TotalManoObra"))
				Cad &= Haga_Cadena("TotalRepuestos", "" & fi("TotalRepuestos"))
				Cad &= Haga_Cadena("TotalTrabajosExternos", "" & fi("TotalTrabajosExternos"))
				Cad &= Haga_Cadena("TotalVentaGravada", "" & fi("TotalVentaGravada"))

			Next
			Cad &= Haga_Cadena("/Total", , False)

			'Autorización
			Cad &= Haga_Cadena("Autorizacion", , False)
			For Each fi As DataRow In Ds.Tables("factura_encabezado").Rows
				Cad &= Haga_Cadena("NumeroAutorizacion", "" & fi("NumeroAutorizacion"))
				Cad &= Haga_Cadena("FechaInicial", "" & fi("FechaInicial"))
				Cad &= Haga_Cadena("FechaFinal", "" & fi("FechaFinal"))
				Cad &= Haga_Cadena("Prefijo", "" & fi("Prefijo"))
				Cad &= Haga_Cadena("NumeroInicial", "" & fi("NumeroInicial"))
				Cad &= Haga_Cadena("NumeroFinal", "" & fi("NumeroFinal"))
			Next
			Cad &= Haga_Cadena("/Autorizacion", , False)

			'Doc Modifica
			Cad &= Haga_Cadena("Doc_Modifica", , False)
			For Each fi As DataRow In Ds.Tables("factura_encabezado").Rows
				Cad &= Haga_Cadena("Doc_Modifica_Prefijo", "" & fi("Doc_Modifica_Prefijo"))
				Cad &= Haga_Cadena("Doc_Modifica_NumeroAutorizacion", "" & fi("Doc_Modifica_NumeroAutorizacion"))
				Cad &= Haga_Cadena("Doc_Modifica_Tipo", "" & fi("Doc_Modifica_Tipo"))
				Cad &= Haga_Cadena("Doc_Modifica_Numero", "" & fi("Doc_Modifica_Numero"))
				Cad &= Haga_Cadena("Doc_Modifica_Fecha", "" & fi("Doc_Modifica_Fecha"))
				Cad &= Haga_Cadena("Doc_Modifica_Concepto", "" & fi("Doc_Modifica_Concepto"))
				Cad &= Haga_Cadena("Doc_Modifica_Cufe", "" & fi("Doc_Modifica_Cufe"))
			Next

			Cad &= Haga_Cadena("/Doc_Modifica", , False)
			Cad &= Haga_Cadena("/Documento", , False)
			Cad &= Haga_Cadena("/ArrayOfDocumento", , False)

			NoReloj()

			If Hizo_algo Then

				'Si no existe la carpeta de archivos planos se crea.
				If Not IO.Directory.Exists(LocalPath) Then
					IO.Directory.CreateDirectory(LocalPath)
				End If

                Dim Archivo As String = LocalPath & "F_" & Id_doc.ToString.PadLeft(10, "0") & ".xml"
                Dim advance_plano = New System.IO.StreamWriter(Archivo, False, System.Text.Encoding.Default)

                'Escribe en el archivo plano
                advance_plano.WriteLine(Cad)
				advance_plano.Close()

				If IO.File.Exists(Archivo) Then
					'Marca el registro como procesado en la base de datos puente
					Ejecutar(ArmeSQL("exec PutCotProcesa_FE",
									 Id_doc, qqNum)
									)
					Return True
				Else
					Return False
				End If

			End If

		Catch ex As Exception
			NoReloj()
			MostrarError("GenerarXml", "Generar_Archivo", ex.ToString)
			Return False
		End Try

	End Function

	Private Function Haga_Cadena(pEtiqueta As String, Optional pValor As String = "", Optional EsReg As Boolean = True) As String
		If pValor = "" And Not EsReg Then
			Return "<" & pEtiqueta & ">" & DMScr()
		Else
			Return "<" & pEtiqueta & ">" & pValor & "</" & pEtiqueta & ">" & DMScr()
		End If
	End Function

	Public Function Exportar_Xml(Id As Integer,
								 Optional SubirFTP As Boolean = False,
								 Optional ShowMsg As Boolean = False) As Boolean
		Dim obj As New GenerarXml
		If Not obj.Generar_Archivo(Id) Then
			If ShowMsg Then
				Mensaje(Idi("No se ha producido el archivo XML correpondiente al documento") & ": " & Id)
			End If
			Return False
		Else
			If ReglaDeNegocio(170, "activar", "0") <> "1" Then
				If ShowMsg Then
					Mensaje("Debe definir la llave [activar=1] de la Rn#170")
				End If
				Return False
			End If

			Dim MsgErr As String = ""
			If Ruta = "" Then MsgErr &= "Defina la ruta del sitio FTP, Rn#170, llave: ftp" & DMScr()
			If Usu = "" Then MsgErr &= "Defina el usuario del sitio FTP, Rn#170, llave: ftp_usu" & DMScr()
			If Cla = "" Then MsgErr &= "Defina la clave del sitio FTP, Rn#170, llave: ftp_cla" & DMScr()

			If MsgErr <> "" And ShowMsg Then
				Mensaje("ERROR: " & DMScr() & MsgErr)
				Return False
			End If

			Try

				If SubirFTP Then 'Exportar al FTP
					'Ejemplo para probar conexión (Datos del Condor)
					'transfer = New SecureFileTransfer("fecolab.cen.biz", 22, "DMS_FECO", "dmsfe+2018")

					transfer = New SecureFileTransfer(hostname:=Ruta,
													  port:=22,
													  username:=Usu,
													  password:=Cla)

					Dim LocalFile As String = "F_" & Id.ToString.PadLeft(10, "0") & ".xml"

					If transfer.putFile(LocalPath.ToString.Trim & LocalFile.ToString.Trim, DirF.ToString.Trim & "/F_" & Id.ToString.PadLeft(10, "0") & ".xml") Then
						If ShowMsg Then
							Mensaje(LocalFile & " " & Idi("ha sido transmitido al sitio FTP") & ": " & Ruta)
						End If
                    End If
                End If

                Return True

            Catch ex As Exception
                Return False
                NoReloj()
                MostrarError("fConsola_Fe", "Exportar_Xml", ex.ToString)
            End Try
        End If

    End Function
End Class
