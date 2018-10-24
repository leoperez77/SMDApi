' Version: 637, 13-mar.-2018 12:42
' Version: 633, 2-mar.-2018 13:14
' Version: 626, 16-feb.-2018 12:38
' Version: 620, 7-feb.-2018 13:08
' Version: 613, 15-ene.-2018 12:44
' Version: 612, 4-ene.-2018 12:14
' Version: 610, 28-dic.-2017 13:49
' Version: 598, 20-nov.-2017 12:34
' Version: 593, 27-oct.-2017 09:31
'♥ versión: 586, 6-oct.-2017 07:11
Imports System.IO
Imports System.Net
Imports System.Net.Sockets


Public Class ExpDocFTP

#Region "Variables para la conexion FTP"
    'Datos de conexion al FTP
    Dim url As String = ""
    Dim usr As String = ""
    Dim pwd As String = ""

    'Carpetas del sitio FTP
    Dim dir_fac As String = ""
    Dim dir_ndb As String = ""
    Dim dir_ncr As String = ""
    Dim dir_gre As String = ""
    Dim dir_ret As String = ""

    Dim sociedad As String = ""
    Dim establecimiento As String = ""
    Dim punto_emision As String = ""
    Dim desc_moneda As String = ""
    Dim Sql As String = ""

    Dim msg As String = ""

    Private _lista As String = ""

#End Region

#Region "Constantes para Tipos de Documentos: <ECUADOR>"
    Const id_factura_ecuador As String = "01"
    Const id_nota_credito_ecuador As String = "04"
    Const id_nota_debito_ecuador As String = "05"
    Const id_guia_remision As String = "06"
    Const id_comprobante_retencion As String = "07"
#End Region

#Region "Constantes para comodines en la contruccion de los archivos: <ECUADOR>"
    Const separador As String = ";"
    Const vacio As String = ""
    Const id_inicio_detalle_total_impuestos As String = "[IT"
    Const id_inicio_forma_pago As String = "[FP"
    Const id_inicio_impuesto As String = "[ID"
    Const id_fin As String = "]"
    Const id_inicio_detalle As String = "[DET"
    Const id_fin_detalle As String = "DET]"
    Const id_inicio_motivo As String = "[MOT"
    Const file_local As String = "C:\SMD_FILES\"
#End Region

    Dim archivo As String = ""
    Dim id_documento As Integer
    Dim tipo_formato As Integer

    ''' <summary>
    ''' Carga el conetido de la carpeta que acaba de procesar
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Lista() As String
        Get
            Return _lista
        End Get
        Set(ByVal value As String)
            _lista = value
        End Set
    End Property

    ''' <summary>
    ''' Generador de archivos planos desde transact sql
    ''' </summary>
    ''' <param name="id_documento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Generar_Plano_Factura(id_documento As Integer) As Boolean
        Try
            If Not Tipo_Valido(id_documento, 1) Then
                Return False
            End If
            Depurar_Planos(True)
            If ReglaDeNegocio(171, "ecuador", "0") = "1" Then

                Dim archivo As String = Generar_Factura_Ecuador(id_documento)
                Sql = ArmeSQL("Exec PutCotCotizacionMasFTP",
                                  id_documento, qqNum, 'Id
                                  Numero_Empresa, qqNum, 'Emp
                                  0, qqNum, 'Status
                                  IIf(Mid(archivo, 1, 3) = "***", "N", "S"), qqTex, 'Arc. plano
                                  "C:\SMD_FILES\" & archivo, qqTex,
                                  0, qqNum)
                SiReloj()
                Ejecutar(Sql)
                NoReloj()

                If Mid(archivo, 1, 3) <> "***" Then
                    listarFTP(url & dir_fac, usr, pwd)
                    Return True
                Else
                    Mensaje("No se generó el documento electrónico")
                    Return False
                End If

            Else
                'Codigo para Colombia

            End If
        Catch ex As Exception
            Mensaje("No logré exportar documento electrónico" & DMScr(2) & ex.ToString, "Exportación de documento electrónico")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' RML: 2016/06/30
    ''' Referencia: Archivo Excel DocumentosElectronicos.xlsx, hoja: EstructuraFactura
    ''' </summary>
    ''' <param name="id_documento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Generar_Plano_Devolucion(id_documento As Integer) As Boolean
        Try
            If Not Tipo_Valido(id_documento, -1) Then
                Return False
            End If
            Depurar_Planos(True)
            If ReglaDeNegocio(171, "ecuador", "0") = "1" Then
                Dim archivo As String = Generar_Devolucion_Ecuador(id_documento)
                If archivo <> "" Then
                    Sql = ArmeSQL("Exec PutCotCotizacionMasFTP",
                                  id_documento, qqNum, 'Id
                                  Numero_Empresa, qqNum, 'Emp
                                  0, qqNum, 'Status
                                  "S", qqTex, 'Arc. plano
                                  "C:\SMD_FILES\" & archivo, qqTex,
                                  0, qqNum)
                    Ejecutar(Sql)
                    listarFTP(url & dir_fac, usr, pwd)
                    Return True
                Else
                    Mensaje("No se genero el documento electronico")
                    Return False
                End If
            Else
                'Aqui va codigo para Colombia
            End If
            Return True
        Catch ex As Exception
            Mensaje("No logré exportar documento electrónico" & DMScr(2) & ex.ToString, "Exportación de documento electrónico")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' RML: 2017/04/21
    ''' </summary>
    ''' <param name="id_documento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Generar_Plano_Guia(id_documento As Integer) As Boolean
        Try
            If Not Tipo_Valido(id_documento, 44) Then
                Return False
            End If

            Depurar_Planos(True)
            If ReglaDeNegocio(171, "ecuador", "0") = "1" Then
                Dim archivo As String = Generar_Guia_Ecuador(id_documento)
                If archivo <> "" Then
                    Sql = ArmeSQL("Exec PutCotCotizacionMasFTP",
                                  id_documento, qqNum, 'Id
                                  Numero_Empresa, qqNum, 'Emp
                                  0, qqNum, 'Status
                                  "S", qqTex, 'Arc. plano
                                  "C:\SMD_FILES\" & archivo, qqTex,
                                  1, qqNum,
                                  1, qqNum)
                    Ejecutar(Sql)
                    listarFTP(url & dir_fac, usr, pwd)
                    Return True
                Else
                    Mensaje("No se genero el documento electronico")
                    Return False
                End If
            End If
            Return False
        Catch ex As Exception
            Mensaje("No logré exportar documento electrónico" & DMScr(2) & ex.ToString, "Exportación de documento electrónico")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' RML: 2017/04/21
    ''' </summary>
    ''' <param name="id_documento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Generar_Plano_NotaDeb(id_documento As Integer) As String
        Try
            If Not Tipo_Valido(id_documento, 21) Then
                Return False
            End If

            Depurar_Planos(True)
            If ReglaDeNegocio(171, "ecuador", "0") = "1" Then
                Dim archivo As String = Generar_Nota_Ecuador_Deb(id_documento)
                If archivo <> "" Then
                    Sql = ArmeSQL("Exec PutCotCotizacionMasFTP",
                                  id_documento, qqNum, 'Id
                                  Numero_Empresa, qqNum, 'Emp
                                  0, qqNum, 'Status
                                  "S", qqTex, 'Arc. plano
                                  "C:\SMD_FILES\" & archivo, qqTex,
                                  0, qqNum)
                    Ejecutar(Sql)
                    listarFTP(url & dir_fac, usr, pwd)
                    Return archivo
                Else
                    Mensaje("No se genero el documento electronico")
                    Return ""
                End If
            End If
            Return ""
        Catch ex As Exception
            Mensaje("No logré exportar documento electrónico" & DMScr(2) & ex.ToString, "Exportación de documento electrónico")
            Return ""
        End Try
    End Function

    Public Function Generar_Plano_NotaCre(id_documento As Integer) As String
        Try
            If Not Tipo_Valido(id_documento, 21) Then
                Return False
            End If

            Depurar_Planos(True)
            If ReglaDeNegocio(171, "ecuador", "0") = "1" Then
                Dim archivo As String = Generar_Nota_Ecuador_Cre(id_documento)
                If archivo <> "" Then
                    Sql = ArmeSQL("Exec PutCotCotizacionMasFTP",
                                  id_documento, qqNum, 'Id
                                  Numero_Empresa, qqNum, 'Emp
                                  0, qqNum, 'Status
                                  "S", qqTex, 'Arc. plano
                                  "C:\SMD_FILES\" & archivo, qqTex,
                                  0, qqNum)
                    Ejecutar(Sql)
                    listarFTP(url & dir_fac, usr, pwd)
                    Return archivo
                Else
                    Mensaje("No se genero el documento electronico")
                    Return ""
                End If
            End If
            Return ""
        Catch ex As Exception
            Mensaje("No logré exportar documento electrónico" & DMScr(2) & ex.ToString, "Exportación de documento electrónico")
            Return ""
        End Try
    End Function

    Public Function Generar_Comprobante_Retencion(id_documento) As Boolean
        If Not Tipo_Valido(id_documento, 21) Then
            Return False
        End If

        Depurar_Planos(True)

        If Not Datos_Conexion("Ret") Then
            Mensaje(msg)
            Return False
        End If

        Try
            'Carga el documento seleccionado
            SiReloj()
            Dim Ds As New DataSet
            Dim Sql As String = ArmeSQL("Exec GetConNotasDC_rete",
                                        Numero_Empresa, qqNum, 'empresa
                                        id_documento, qqNum)        'usu
            Abrir(Ds, Sql)
            If Ds.Tables.Count = 0 Then
                NoReloj()
                Return False
            End If
            If Fin(Ds.Tables(0)) Then
                NoReloj()
                Return False
            End If

            Dim archivo As String = Gdf(Ds.Tables(1), "archivo")
            If archivo <> "" Then
                Dim DtPlano As New DataTable
                DtPlano = Ds.Tables(0)
                Dim texto As String = ""
                Dim advance_plano = New System.IO.StreamWriter(file_local & archivo, False, System.Text.Encoding.UTF8)
                For Each fi As DataRow In DtPlano.Rows
                    texto &= fi("dato")
                Next
                'Escribe en el archivo plano
                advance_plano.WriteLine(texto)
                advance_plano.Close()
            End If

            If File.Exists("C:\SMD_FILES\" & archivo) Then
                Dim archivo_destino As String = url & dir_ret & "/" & archivo
                My.Computer.Network.UploadFile("C:\SMD_FILES\" & archivo, archivo_destino, usr, pwd)
                Sql = ArmeSQL("Exec PutCotCotizacionMasFTP",
                                  id_documento, qqNum, 'Id
                                  Numero_Empresa, qqNum, 'Emp
                                  0, qqNum, 'Status
                                  "N", qqTex, 'Arc. plano
                                  "C:\SMD_FILES\" & archivo, qqTex,
                                  1, qqNum)
                Ejecutar(Sql)
                NoReloj()
                Return True
            Else
                NoReloj()
                Return False
            End If

        Catch ex As Exception
            NoReloj()
            Return False
        End Try

    End Function

    Private Function Generar_Nota_Ecuador_Deb(id_documento) As String
        If Not Datos_Conexion("Ndb") Then
            Mensaje(msg, "Exportación documento electrónico")
            Return ""
        End If

        Try
            'Carga el documento seleccionado
            SiReloj()
            Dim Ds As New DataSet
            Dim Sql As String = ArmeSQL("Exec PutCotExp_ND_Ecu",
                                        Numero_Empresa, qqNum, 'empresa
                                        id_documento, qqNum,   'id docto
                                        Usuario, qqNum)        'usu
            Abrir(Ds, Sql)
            If Fin(Ds.Tables(1)) Then
                NoReloj()
                Return ""
            End If

            Dim archivo As String = Gdf(Ds.Tables(0), "archivo")
            If archivo <> "" Then
                Dim DtPlano As New DataTable
                DtPlano = Ds.Tables(1)
                If Fin(DtPlano) Then
                    Return ""
                End If
                Dim texto As String = ""
                Dim advance_plano = New System.IO.StreamWriter(file_local & archivo, False, System.Text.Encoding.UTF8)
                For Each fi As DataRow In DtPlano.Rows
                    texto &= fi("dato")
                Next
                'Escribe en el archivo plano
                advance_plano.WriteLine(texto)
                advance_plano.Close()
            End If

            If File.Exists("C:\SMD_FILES\" & archivo) Then
                Try
                    Dim archivo_destino As String = url & dir_fac & "/" & archivo
                    My.Computer.Network.UploadFile("C:\SMD_FILES\" & archivo, archivo_destino, usr, pwd)
                    NoReloj()
                    Return archivo
                Catch ex As Exception
                    Return ""
                End Try
            Else
                NoReloj()
                Return ""
            End If

        Catch ex As Exception
            NoReloj()
            Mensaje("No logré exportar documento electrónico" & DMScr(2) & ex.ToString, "Exportación de documento electrónico")
            Return ""
        End Try

    End Function

    Private Function Generar_Nota_Ecuador_Cre(id_documento) As String
        If Not Datos_Conexion("Ncr") Then
            Mensaje(msg, "Exportación documento electrónico")
            Return ""
        End If

        Try
            'Carga el documento seleccionado
            SiReloj()
            Dim Ds As New DataSet
            Dim Sql As String = ArmeSQL("Exec PutCotExp_NC_Ecu",
                                        Numero_Empresa, qqNum, 'empresa
                                        id_documento, qqNum,   'id docto
                                        Usuario, qqNum)        'usu
            Abrir(Ds, Sql)
            If Fin(Ds.Tables(1)) Then
                NoReloj()
                Return ""
            End If

            Dim archivo As String = Gdf(Ds.Tables(0), "archivo")
            If archivo <> "" Then
                Dim DtPlano As New DataTable
                DtPlano = Ds.Tables(1)
                If Fin(DtPlano) Then
                    Return ""
                End If
                Dim texto As String = ""
                Dim advance_plano = New System.IO.StreamWriter(file_local & archivo, False, System.Text.Encoding.UTF8)
                For Each fi As DataRow In DtPlano.Rows
                    texto &= fi("dato")
                Next
                'Escribe en el archivo plano
                advance_plano.WriteLine(texto)
                advance_plano.Close()
            End If

            If File.Exists("C:\SMD_FILES\" & archivo) Then
                Try
                    Dim archivo_destino As String = url & dir_fac & "/" & archivo
                    My.Computer.Network.UploadFile("C:\SMD_FILES\" & archivo, archivo_destino, usr, pwd)
                    NoReloj()
                    Return archivo
                Catch ex As Exception
                    Return ""
                End Try
            Else
                NoReloj()
                Return ""
            End If

        Catch ex As Exception
            NoReloj()
            Mensaje("No logré exportar documento electrónico" & DMScr(2) & ex.ToString, "Exportación de documento electrónico")
            Return ""
        End Try

    End Function


    Private Function Generar_Factura_Ecuador(id_documento) As String
        If Not Datos_Conexion("Fac") Then
            Mensaje(msg, "Exportación documento electrónico")
            Return ""
        End If

        'If Not Validar_Sitio_FTP(dir_fac, usr, pwd) Then
        '    Mensaje("El sitio: " & url & " es inaccesible, verifique la url y las credenciales para conectar Rn#170 Llaves(ftp, usu, pwd).")
        '    Return ""
        'End If

        Try
            'Carga el documento seleccionado
            Dim Ds As New DataSet
            Dim Sql As String = ArmeSQL("Exec PutCotExp_Fe_Ecu",
                                        Numero_Empresa, qqNum, 'empresa
                                        id_documento, qqNum,   'id docto
                                        Usuario, qqNum)        'usu
            SiReloj()
            Abrir(Ds, Sql)
            NoReloj()

            If Ds.Tables.Count = 0 Then
                Return ""
            End If

            If Fin(Ds.Tables(0)) Then
                Return ""
            End If

            Dim archivo As String = Gdf(Ds.Tables(0), "archivo")

            If archivo = "" Then
                Return ""
            End If

            Dim DtPlano As New DataTable
            DtPlano = Ds.Tables(1)
            If Fin(DtPlano) Then
                Return ""
            End If
            Dim texto As String = ""
            Dim advance_plano = New System.IO.StreamWriter(file_local & archivo, False, System.Text.Encoding.UTF8)
            For Each fi As DataRow In DtPlano.Rows
                texto &= fi("dato")
            Next
            'Escribe en el archivo plano
            advance_plano.WriteLine(texto)
            advance_plano.Close()

            If File.Exists("C:\SMD_FILES\" & archivo) Then
                Try
                    Dim archivo_destino As String = url & dir_fac & "/" & archivo
                    My.Computer.Network.UploadFile("C:\SMD_FILES\" & archivo, archivo_destino, usr, pwd)
                    NoReloj()
                    Return archivo
                Catch ex As Exception
                    Return "***" & archivo
                End Try
            Else
                Return "***"
            End If

        Catch ex As Exception
            NoReloj()
            Mensaje("No logré exportar documento electrónico" & DMScr(2) & ex.ToString, "Exportación de documento electrónico")
            Return ""
        End Try

    End Function

    Private Function Generar_Devolucion_Ecuador(id_documento) As String
        If Not Datos_Conexion("Ncr") Then
            Mensaje(msg)
            Return ""
        End If

        'If Not Validar_Sitio_FTP(dir_fac, usr, pwd) Then
        '    Mensaje("El sitio: " & url & " es inaccesible, verifique la url y las credenciales para conectar Rn#170 Llaves(ftp, usu, pwd).")
        '    Return ""
        'End If

        Try
            'Carga el documento seleccionado
            SiReloj()
            Dim Ds As New DataSet
            Dim Sql As String = ArmeSQL("Exec PutCotExp_Fe_Ecu",
                                        Numero_Empresa, qqNum, 'empresa
                                        id_documento, qqNum,   'id docto
                                        Usuario, qqNum)        'usu
            Abrir(Ds, Sql)
            If Fin(Ds.Tables(1)) Then
                NoReloj()
                Return ""
            End If

            Dim archivo As String = Gdf(Ds.Tables(0), "archivo")
            If archivo <> "" Then
                Dim DtPlano As New DataTable
                DtPlano = Ds.Tables(1)
                Dim texto As String = ""
                Dim advance_plano = New System.IO.StreamWriter(file_local & archivo, False, System.Text.Encoding.UTF8)
                For Each fi As DataRow In DtPlano.Rows
                    texto &= fi("dato")
                Next
                'Escribe en el archivo plano
                advance_plano.WriteLine(texto)
                advance_plano.Close()
            End If

            If File.Exists("C:\SMD_FILES\" & archivo) Then
                Try
                    Dim archivo_destino As String = url & dir_ncr & "/" & archivo
                    My.Computer.Network.UploadFile("C:\SMD_FILES\" & archivo, archivo_destino, usr, pwd)
                    NoReloj()
                    Return archivo
                Catch ex As Exception
                    Return ""
                End Try
            Else
                NoReloj()
                Return ""
            End If

        Catch ex As Exception
            NoReloj()
            Mensaje("No logré exportar documento electrónico" & DMScr(2) & ex.ToString, "Exportación de documento electrónico")
            Return ""
        End Try

    End Function

    'Public Function Generar_Devolucion_Ecuador_Ant(id_documento As Integer) As String
    '    If Not Datos_Conexion("Ndb") Then
    '        Return ""
    '    End If

    '    Try
    '        SiReloj()

    '        Dim Sql As String = ""
    '        Dim Ds As New DataSet

    '        'Carga los datos de la factura asociada a la devolucion
    '        Sql &= ArmeSQL("Exec GetDatosDevFac",
    '                       id_documento, qqNum)
    '        Sql &= DMScr()
    '        Sql &= ArmeSQL("Exec GetFe_Enc",
    '                       Numero_Empresa, qqNum,
    '                       id_documento, qqNum)
    '        Abrir(Ds, Sql)
    '        If Fin(Ds.Tables(0)) Then
    '            NoReloj()
    '            Return ""
    '        End If
    '        If Fin(Ds.Tables(1)) Then
    '            NoReloj()
    '            Return ""
    '        End If
    '        If ValD(Gdf(Ds.Tables(0), "Id_fac")) = 0 Then
    '            NoReloj()
    '            Return ""
    '        End If

    '        Dim DtCru As New DataTable
    '        Dim DtEnc As New DataTable
    '        Dim DtDet As New DataTable
    '        Dim DtEyv As New DataTable
    '        DtCru = Ds.Tables(0).Copy
    '        DtEnc = Ds.Tables(1).Copy
    '        DtDet = Ds.Tables(2).Copy
    '        DtEyv = Ds.Tables(4).Copy

    '        'Lectura secuencial del documento detalles para armar el plano
    '        Dim advance_plano As New Object
    '        Dim texto As String = ""

    '        'A. Procesa el encabezado del documento
    '        For Each enc As DataRow In DtEnc.Rows
    '            'Busca punto de emision por tipo de documento
    '            If Replace(Gdf(DtEnc, "PuntoEmision"), ";", "") = "" Then
    '                NoReloj()
    '                Return ""
    '            End If
    '            'Nombre del archivo a exportar
    '            Dim campo As String = Mid(Gdf(DtEnc, "FechaDocumento").ToString, 1, Gdf(DtEnc, "FechaDocumento").ToString.Length - 1)
    '            archivo = sociedad & "_" & establecimiento & "_" & Replace(Gdf(DtEnc, "PuntoEmision"), ";", "") & "_" &
    '                      Mid(campo, 1, 2).ToString.PadLeft(2, "0") &
    '                      Mid(campo, 4, 2).ToString.PadLeft(2, "0") &
    '                      Mid(campo, 7, 4).ToString &
    '                      Now.ToString("HHmmss") & ".txt"
    '            advance_plano = New System.IO.StreamWriter(file_local & archivo, False, System.Text.Encoding.UTF8)
    '            'Exporta el encabezado
    '            For Each col As DataColumn In DtEnc.Columns
    '                texto &= enc(col.ColumnName)
    '            Next
    '        Next
    '        'B. Procesa los detalles del documento
    '        For Each det As DataRow In DtDet.Rows
    '            For Each col As DataColumn In DtDet.Columns
    '                texto &= det(col.ColumnName)
    '            Next
    '        Next
    '        'C. Procesa Etiquetas y Valores mas monto escrito
    '        For Each eyv As DataRow In DtEyv.Rows
    '            For Each col As DataColumn In DtEyv.Columns
    '                texto &= eyv(col.ColumnName)
    '            Next
    '        Next

    '        'Escribe en el archivo plano
    '        advance_plano.WriteLine(texto)
    '        advance_plano.Close()

    '        NoReloj()

    '        If File.Exists(file_local & archivo) Then
    '            Dim archivo_destino As String = url & dir_ncr & "/" & archivo
    '            If File.Exists(file_local & archivo) Then My.Computer.Network.UploadFile(file_local & archivo, archivo_destino, usr, pwd)
    '            Return url & dir_ncr & "Archivo: " & archivo & " Ok!"
    '        Else
    '            Return ""
    '        End If

    '    Catch ex As Exception
    '        NoReloj()
    '        MostrarError("ExpDocFTP", "Generar_Devolucion_Ecuador", ex.ToString)
    '        Return ""
    '    End Try

    'End Function

    'JFG: 2017-04-01 Guias de Remisión
    Private Function Generar_Guia_Ecuador(id_documento) As String
        If Not Datos_Conexion("Gre") Then
            Return ""
        End If

        Try
            'Carga el documento seleccionado
            SiReloj()
            Dim Ds As New DataSet
            Dim Sql As String = ArmeSQL("Exec GetFe_guia",
                                        Numero_Empresa, qqNum,
                                        id_documento, qqNum)
            Abrir(Ds, Sql)
            If Fin(Ds.Tables(0)) Then
                NoReloj()
                Return ""
            End If
            'Control del numero de tablas para exportar en el proceso de facturación electrónica
            If Ds.Tables.Count <> 4 Then
                NoReloj()
                Return ""
            End If

            Dim DtEnc As New DataTable
            Dim DtDet As New DataTable
            Dim DtAdi As New DataTable 'JFG-555 Adicionales

            DtEnc = Ds.Tables(0).Copy
            DtDet = Ds.Tables(1).Copy
            DtAdi = Ds.Tables(2).Copy

            'Lectura secuencial del documento detalles para armar el plano
            Dim advance_plano As New Object
            Dim texto As String = ""

            'A. Procesa el encabezado del documento
            For Each enc As DataRow In DtEnc.Rows
                'Busca punto de emision por tipo de documento
                If Replace(Gdf(DtEnc, "Punto de Emision"), ";", "") = "" Then
                    NoReloj()
                    Return ""
                End If
                'Nombre del archivo a exportar
                Dim campo As String = Mid(Gdf(DtEnc, "Fecha Inicio").ToString, 1, Gdf(DtEnc, "Fecha Inicio").ToString.Length - 1)
                archivo = sociedad & "_" & establecimiento & "_" & Replace(Gdf(DtEnc, "Punto de Emision"), ";", "") & "_" &
                          Mid(campo, 1, 2).ToString.PadLeft(2, "0") &
                          Mid(campo, 4, 2).ToString.PadLeft(2, "0") &
                          Mid(campo, 7, 4).ToString &
                          Now.ToString("HHmmss") & ".txt"
                advance_plano = New System.IO.StreamWriter(file_local & archivo, False, System.Text.Encoding.UTF8)
                'Exporta el encabezado
                For Each col As DataColumn In DtEnc.Columns
                    texto &= enc(col.ColumnName)
                Next
            Next
            'B. Procesa los detalles del documento
            For Each det As DataRow In DtDet.Rows
                For Each col As DataColumn In DtDet.Columns
                    texto &= det(col.ColumnName)
                Next
            Next
            'JFG-555 Leer adiionales
            For Each adi As DataRow In DtAdi.Rows
                For Each col As DataColumn In DtAdi.Columns
                    texto &= adi(col.ColumnName)
                Next
            Next
            '/JFG-555 Leer adicionales

            'Escribe en el archivo plano
            advance_plano.WriteLine(texto)
            advance_plano.Close()

            NoReloj()

            If File.Exists(file_local & archivo) Then
                Dim archivo_destino As String = url & "/" & dir_gre & "/" & archivo
                If File.Exists(file_local & archivo) Then My.Computer.Network.UploadFile(file_local & archivo, archivo_destino, usr, pwd)
                Return url & dir_gre & "Archivo: " & archivo & " Ok!"
            Else
                Return ""
            End If

        Catch ex As Exception
            NoReloj()
            Mensaje("No logré exportar documento electrónico" & DMScr(2) & ex.ToString, "Exportación de documento electrónico")
            Return ""
        End Try

    End Function
    '/JFG

    Private Function Datos_Conexion(tipo) As Boolean
        Try
            'Validacion de las credenciales de conexion al sitio FTP
            url = ReglaDeNegocio(170, "ftp")
            Dim proceso_error As Boolean = False
            If url = "" Then
                msg &= "Debe definir la URL del sitio FTP Rn#170, Ftp"
                proceso_error = True
            End If
            usr = ReglaDeNegocio(170, "ftp_usu")
            If usr = "" Then
                msg &= "Debe definir el usuario habilitado para ingresar al sitio FTP Rn#170, Ftp_usu"
                proceso_error = True
            End If
            pwd = ReglaDeNegocio(170, "ftp_cla")
            If pwd = "" Then
                msg &= "Debe definir clave del usuario habilitado para ingresar al sitio FTP Rn#170, Ftp_cla"
                proceso_error = True
            End If

            Select Case tipo
                Case "Fac"
                    dir_fac = ReglaDeNegocio(170, "dir_fac")
                    If dir_fac = "" Then
                        msg &= "Debe definir la ruta de la carpeta de facturas FTP Rn#170, dir_fac"
                        proceso_error = True
                    End If
                Case "Ncr"
                    dir_ncr = ReglaDeNegocio(170, "dir_ncr")
                    If dir_ncr = "" Then
                        msg &= "Debe definir la ruta de la carpeta de notas credito FTP Rn#170, dir_ncr "
                        Return False
                    End If
                Case "Ndb"
                    dir_ndb = ReglaDeNegocio(170, "dir_ndb")
                    If dir_ndb = "" Then
                        msg &= "Debe definir la ruta de la carpeta de notas debito FTP Rn#170, dir_ndb "
                        Return False
                    End If
                Case "Gre"
                    dir_gre = ReglaDeNegocio(170, "dir_gre")
                    If dir_gre = "" Then
                        msg &= "Debe definir la ruta de la carpeta de guias de remision FTP Rn#170, dir_gre "
                        Return False
                    End If
                Case "Ret"
                    dir_ret = ReglaDeNegocio(170, "dir_ret")
                    If dir_ret = "" Then
                        msg &= "Debe definir la ruta de la carpeta de comprobante de retencion FTP Rn#170, dir_ret "
                        Return False
                    End If

            End Select

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Quita guiones, comas y puntos al nit
    ''' </summary>
    ''' <param name="dato"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function FormatoRuc(dato As String) As String
        Try
            Dim tiene_guion As Integer = 0
            tiene_guion = InStr(dato, "-")
            If tiene_guion > 0 Then
                dato = Mid(dato, 1, tiene_guion - 1)
            Else
                dato = dato
            End If
            dato = Replace(dato, ",", "")
            dato = Replace(dato, ".", "")

            If Not IsNumeric(dato) Then
                Return Nothing
            End If

            Return dato

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function DosDecimales(valor As Decimal)
        Return valor.ToString("N2")
    End Function

    Private Function Validar_Sitio_FTP(ByVal dir As String, ByVal usr As String, ByVal pwd As String) As Boolean
        Try
            If Mid(url, 1, url.ToString.Length - 1) <> "/" Then
                url &= "/"
            End If
            Dim request As FtpWebRequest = DirectCast(WebRequest.Create(url & dir), FtpWebRequest)
            request.Method = WebRequestMethods.Ftp.ListDirectory
            request.Credentials = New NetworkCredential(usr, pwd)
            Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Function listarFTP(ByVal dir As String, ByVal usr As String, ByVal pwd As String) As String
        Try
            Dim Dirlist As New List(Of String)

            If Mid(url, 1, url.ToString.Length - 1) <> "/" Then
                url &= "/"
            End If

            Dim request As FtpWebRequest = DirectCast(WebRequest.Create(url & dir), FtpWebRequest)
            request.Method = WebRequestMethods.Ftp.ListDirectory
            request.Credentials = New NetworkCredential(usr, pwd)
            Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
            Dim responseStream As Stream = response.GetResponseStream
            Lista = ""
            Using reader As New StreamReader(responseStream)
                Do While reader.Peek <> -1
                    Lista &= reader.ReadLine & "&"
                Loop
            End Using
            response.Close()
            Return Lista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
	Public Sub Depurar_Planos(Optional Aut As Boolean = False)
		Try
			Dim dias As Integer = ValD(ReglaDeNegocio(171, "dias_alma", "0"))
			If dias = 0 Then
				Exit Sub
			End If


			Dim Directorio As String = "C:\SMD_FILES\"
			Dim Fecha As DateTime = DateTime.Now
			Dim Hizo As Boolean = False

			For Each Archivo As String In My.Computer.FileSystem.GetFiles(Directorio, FileIO.SearchOption.SearchTopLevelOnly)
				If Strings.Mid(Archivo, 1, 17) <> "C:\SMD_FILES\ADVA" Then Continue For
				Dim Fecha_Archivo As DateTime = My.Computer.FileSystem.GetFileInfo(Archivo).LastWriteTime
				'Dim Diferencia = (CType(Fecha, DateTime) - CType(Fecha_Archivo, DateTime)).TotalDays
				Dim Diferencia = (Fecha - Fecha_Archivo).TotalDays
				If Diferencia >= dias Then
					File.Delete(Archivo)
					Hizo = True
				End If
			Next
			If hizo And Not Aut Then Mensaje("La depuracion de archivos ha sido realizada exitosamente")
		Catch ex As Exception
			MostrarError("ExpDocFTP", "Depurar_Planos", ex.ToString)
		End Try
	End Sub
    Private Function Tipo_Valido(Id As Integer, sw As Integer) As Boolean
        Try
            Dim Dt As New DataTable
            SiReloj()
            Abrir(Dt, ArmeSQL("Exec GetDocValidoFTP",
                           Id, qqNum,
                           sw, qqNum
                         )
             )
            NoReloj()
            If Fin(Dt) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MostrarError("ExpDocFTP", "Tipo_Valido", ex.ToString)
            Return False
        End Try
    End Function
End Class
