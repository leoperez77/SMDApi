' Version: 684, 24-ago.-2018 16:56
'♥ versión: 586, 6-oct.-2017 07:11
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Text
Imports Microsoft.ApplicationBlocks.Data
Public Class Desconectado


    Public Shared Conexion As String


    Public Shared Function GetDatasetCE(Sql As String) As DataSet
        'If Verificar_Conex() = False Then
        '    Return Nothing
        'End If

        'esta es la función principal usada para leer y ejecutar cosas en la base de datos local
        Verificar_Conex()

        Return SqlHelper.ExecuteDataset(Desconectado.Conexion, CommandType.Text, Sql)

    End Function



    Public Shared Function GetDsFromSp2(ByVal Sp As String, ByVal Params() As String) As DataSet
        'esta se usa por compatiblidad para cosas casi obsoletas
        Verificar_Conex()

        Dim Cuantos As Integer

        For i As Integer = 1 To 20
            If Params(i) <> "" Then
                Cuantos = Cuantos + 1
            End If
        Next

        Dim ds As New DataSet

        If (Cuantos > 0) Then
            Dim x(Cuantos - 1) As SqlParameter
            For i As Integer = 1 To Cuantos
                x(i - 1) = New SqlParameter

                'Los parametros vacios no se pueden usar, se asume un missing, con |° marcamos un param vacio
                If Params(i) = "|°" Then
                    x(i - 1).Value = ""
                Else
                    x(i - 1).Value = Params(i)


                End If
            Next
            ds = SqlHelper.ExecuteDataset(Desconectado.Conexion, Sp, x)
        Else
            ds = SqlHelper.ExecuteDataset(Desconectado.Conexion, CommandType.Text, Sp)
        End If


        Return ds

    End Function



    Private Shared Sub Verificar_Conex()
		'        If Desconectado.Conexion IsNot Nothing Then
		'            Return True
		'        End If
		'        Dim Intentos As Integer = 0



		'        Dim Server As String = GetSett("Conecc", "express_serv", "")
		'        Dim BD As String = GetSett("Conecc", "express_bd", "")
		'        Dim UU As String = GetSett("Conecc", "express_user", "")
		'        Dim CC As String = GetSett("Conecc", "express_clave", "")


		'Repetir:
		'        'IniciarConexion("vaio-jd\sqlexpress", "advance_express", "sa", "diego95")
		'        Try
		'            Desconectado.Conexion = "Data Source=" + Server + ";Initial Catalog=" + BD + ";User ID=" + UU + ";Password=" + CC

		'            'probar la conexión
		'            SqlHelper.ExecuteDataset(Desconectado.Conexion, CommandType.Text, "select top 0 1")



		'        Catch ex As Exception
		'            Intentos += 1
		'            If Intentos <= 4 Then
		'                If Pregunte("No logró conectarse al sistema desconectado: " & ex.Message & EsIngles & DMScr(2) & "Desea intentar de nuevo?") Then
		'                    Desconectado.Conexion = Nothing
		'                    GoTo Repetir
		'                End If
		'            End If

		'            Return False
		'        End Try


		'        Return True

		If Desconectado.Conexion IsNot Nothing Then
            Exit Sub
        End If

        Dim Intentos As Integer = 0



        Dim Server As String = GetSett("Conecc", "express_serv", "")
        Dim BD As String = GetSett("Conecc", "express_bd", "")
        Dim UU As String = GetSett("Conecc", "express_user", "")
        Dim CC As String = GetSett("Conecc", "express_clave", "")


        Desconectado.Conexion = "Data Source=" + Server + ";Initial Catalog=" + BD + ";User ID=" + UU + ";Password=" + CC

        'probar la conexión
        SqlHelper.ExecuteDataset(Desconectado.Conexion, CommandType.Text, "select top 0 1")


    End Sub


    Public Shared Sub SaveImage(ByVal Tabla As String, ByVal Id As Integer, ByVal oImage() As Byte)

        Dim sRet As String = ""
        Dim nRet As Integer = 0
        Dim nNewID As Integer = 0

        Dim oConn As SqlConnection = New SqlConnection()

        Try

            oConn.ConnectionString = Desconectado.Conexion
            oConn.Open()

            Dim oCmd As SqlCommand = New SqlCommand("dbo.SalvarImagen", oConn)

            oCmd.CommandType = CommandType.StoredProcedure

            oCmd.Parameters.Add(New SqlParameter("@IdImagen", SqlDbType.Int, 0))
            oCmd.Parameters.Add(New SqlParameter("@Imagen", SqlDbType.Image, 2147483647))
            oCmd.Parameters.Add(New SqlParameter("@NombreTabla", SqlDbType.VarChar, 80))

            oCmd.Parameters("@IdImagen").Value = Id
            oCmd.Parameters("@Imagen").Value = oImage
            oCmd.Parameters("@NombreTabla").Value = Tabla
            oCmd.ExecuteNonQuery()

        Catch e As Exception
            Throw
        Finally
            If oConn.State = ConnectionState.Open Then
                oConn.Close()
            End If
        End Try

    End Sub


    Public Shared Function Actualizar_Local(Dt As DataTable, Imagen As Object) As Integer
        'Aqui se actualiza la bd local cada tabla encontrada en la real segun fecha_modif
        Actualizar_Local = 0 'para contar

        'cuales son la tablas especiales donde no hay ID y solo se hace Insert
        'cot_forma_pago_cuotas no se incluye pues aunque siempre se inserta, si tiene ID y queremos que quede igual en la local
        'las tablas que tengan ID no identity hay que excluirlas donde arma el comando de Insert.
        Dim TablaEspecial As Boolean = EstaEnLista(Dt.TableName, "usuario_perm2", _
                                                                 "usuario_perm_informes", _
                                                                 "usuario_subgrupo_perm", _
                                                                 "usuario_subgrupo_perm_informes", _
                                                                 "usuario_bodega", _
                                                                 "v_cot_item_stock_real", _
                                                                 "cot_cliente_item", _
                                                                 "cot_item_estruc", _
                                                                 "cot_item_alt", _
                                                                 "cot_item_categoria_listas", _
                                                                 "emp_lic2", _
                                                                 "reglas_emp" _
                                                                 ) ', "cot_forma_pago_cuotas")
        '/cuales son la tablas especiales donde no hay ID y solo se hace Insert



        'traer las columnas de la base de datos local pues puede tener menos columnas
        Dim Dsl As New DataSet
        Dim DtC As DataTable
        Dsl = Desconectado.GetDatasetCE("select top 0 * from " & Dt.TableName)
        DtC = Dsl.Tables(0)
        DtC.TableName = Dt.TableName

        'armar las dos posibles instruciones
        Dim InsertCommand As String = Desconectado.BuildInsertSQL(DtC, TablaEspecial)
        Dim UpdateCommand As String = Desconectado.BuildUpdateSQL(DtC)
        '/traer las columnas de la base de datos local pues puede tener menos columnas

        Dim conn As System.Data.SqlClient.SqlConnection
        conn = New System.Data.SqlClient.SqlConnection(Desconectado.Conexion)
        conn.Open()

        Dim ICommand As New System.Data.SqlClient.SqlCommand()
        ICommand.Connection = conn
        ICommand.CommandText = InsertCommand
        Dim UCommand As New System.Data.SqlClient.SqlCommand()
        UCommand.Connection = conn
        UCommand.CommandText = UpdateCommand


        For Each column As DataColumn In DtC.Columns
            'para insertar
            Dim myparam As New SqlParameter()
            myparam.ParameterName = "@" + column.ColumnName
            ICommand.Parameters.Add(myparam)

            'para modificar
            Dim myparam2 As New SqlParameter()
            myparam2.ParameterName = "@" + column.ColumnName
            UCommand.Parameters.Add(myparam2)
        Next

        'desmarcar tablas especiales
        If Dt.TableName = "v_cot_item_stock_real" Then
            TablaEspecial = False 'para que pueda comparar bien
        End If
        '/desmarcar tablas especiales

        For Each Fi As DataRow In Dt.Rows
            Dim NoExisteAun As Boolean
            'hay tablas esclavas de otras que no usan ID, siempre son borradas entonces solo se deben crear
            If TablaEspecial Then
                NoExisteAun = True
            Else
                'definir si existe para modificar o para insertar
                Dim SqEsp As String
                'cambia el sql para esta tabla
                If Dt.TableName = "v_cot_item_stock_real" Then
                    SqEsp = "select id_cot_item from " & Dt.TableName & " where id_cot_bodega=" & Fi("id_cot_bodega") & " And id_cot_item=" & Fi("id_cot_item") & " And id_cot_item_lote=" & Fi("id_cot_item_lote")
                Else
                    SqEsp = "select id from " & Dt.TableName & " where id=" & Fi("id")
                End If

                Dim dsTemp As DataSet
                dsTemp = Desconectado.GetDatasetCE(sqesp)
                NoExisteAun = Fin(dsTemp.Tables(0))
                '/definir si existe para modificar o para insertar
            End If



            ' AgregarFilas, revisando por cada columna
            For Each column As DataColumn In DtC.Columns
                'este IF se hace por que el sistema no es capaz con imagenes en nulo entonces le metemos una imagen cualquiera traida desde el menú
                If column.DataType.Name = "Byte[]" Then
                    If Fi(column.ColumnName) Is DBNull.Value Then
                        Fi(column.ColumnName) = Imagen
                    End If
                End If

                If NoExisteAun Then 'asignar para INSERT
                    ICommand.Parameters("@" & column.ColumnName).Value = Fi(column.ColumnName)
                Else 'asignar para UPDATE
                    UCommand.Parameters("@" & column.ColumnName).Value = Fi(column.ColumnName)
                End If
            Next
            If NoExisteAun Then
                Actualizar_Local += 1 'estos son los nuevos
                ICommand.ExecuteNonQuery()
            Else
                UCommand.ExecuteNonQuery()
            End If
        Next

        Return Actualizar_Local

    End Function

    Private Shared Function NoIncluir(Tabla As String, Campo As String) As Boolean
        'aqui van todos los casos que deben ser excluidos, como las columnas calculadas

        'If Tabla = "cot_cliente" And Campo = "id_cot_cliente_contacto" Then 'cuando creo el cliente aun no he creado contactos
        '    Return True
        'End If
        'If Tabla = "emp" And EstaEnLista("id_usuario", "id_usuario_crea") Then 'porque cuando creo la empresa aun no tengo usuarios
        '    Return True
        'End If
        If Tabla = "cot_tipo" And EstaEnLista("numero_inf") Then 'porque este numero es actualizado directamente para hacer el siguiente
            Return True
        End If
        If Tabla = "cot_unidades" And Campo = "des2" Then 'columna calculada
            Return True
        End If

        Return False

    End Function

    Private Shared Function BuildInsertSQL(table As DataTable, TablaEspecial As Boolean) As String
        'tablas que tengan ID pero no sea indetity
        If table.TableName = "reglas" Then
            TablaEspecial = True
        End If

        'Dim sql As New StringBuilder("EXEC sp_msforeachtable ""ALTER TABLE " + table.TableName + " NOCHECK CONSTRAINT all""")
        Dim sql As New StringBuilder("")
        'si la tabla no tiene id identity no hacer este control
        If Not TablaEspecial Then
            sql.Append("; SET IDENTITY_INSERT " + table.TableName + " ON")
        End If
        sql.Append("; INSERT INTO " + table.TableName + " (")

        Dim values As New StringBuilder("VALUES (")
        Dim bFirst As Boolean = True
        Dim identityType As String = Nothing

        For Each column As DataColumn In table.Columns
            If NoIncluir(table.TableName, column.ColumnName) Then Continue For

            If bFirst Then
                bFirst = False
            Else
                sql.Append(", ")
                values.Append(", ")
            End If

            sql.Append(column.ColumnName)
            'values.Append(column.ColumnName);
            values.Append("@" + column.ColumnName)

        Next
        sql.Append(") ")
        sql.Append(values.ToString())
        sql.Append(")")

        'sql.Append("; EXEC sp_msforeachtable ""ALTER TABLE " + table.TableName + " CHECK CONSTRAINT all""")

        'volver a activar el identity
        If Not TablaEspecial Then
            sql.Append("; SET IDENTITY_INSERT " + table.TableName + " OfF")
        End If

        Return sql.ToString()


    End Function

    Private Shared Function BuildUpdateSQL(table As DataTable) As String
        Dim Pk As String = "id"
        Dim sql As New StringBuilder("UPDATE " + table.TableName + " SET ")

        Dim bFirst As Boolean = True
        Dim bIdentity As Boolean = False
        Dim identityType As String = Nothing


        'armar cada columna
        For Each column As DataColumn In table.Columns
            If NoIncluir(table.TableName, column.ColumnName) Then Continue For

            If column.ColumnName.ToLower() <> Pk Then
                sql.Append(column.ColumnName + " = @" + column.ColumnName + ", ")
            End If
        Next
        '/armar cada columna

        sql.Remove(sql.Length - 2, 2)
        'esta tabla de stock tiene tratamiento especial pues no vamos a borrarla, solo insert u update
        If table.TableName = "v_cot_item_stock_real" Then
            sql.Append(" Where id_cot_bodega=@id_cot_bodega and id_cot_item=@id_cot_item and id_cot_item_lote=@id_cot_item_lote")
        Else
            sql.Append(" Where " & Pk & "=@" & Pk)
        End If

        'terminando, habilitar las relaciones
        'sql.Append("; EXEC sp_msforeachtable ""ALTER TABLE " + table.TableName + " CHECK CONSTRAINT all""")

        'TABLAS CON MANEJO ESPECIAL
        'permisos programas usuarios, se borran sus permisos pues después vienen nuevos. No se pueden dejar pues no habría forma de borrarlos (los que se le quiten en la real)
        If table.TableName = "usuario" Then
            sql.Append("; Delete c from usuario f join usuario_perm2 c on c.id_usuario=f.id where f.id=@id")
            'permisos informes usuarios, se borran sus permisos pues después vienen nuevos. No se pueden dejar pues no habría forma de borrarlos (los que se le quiten en la real)
            sql.Append("; Delete c from usuario f join usuario_perm_informes c on c.id_usuario=f.id where f.id=@id")
            sql.Append("; Delete c from usuario f join usuario_bodega c on c.id_usuario=f.id where f.id=@id")
        End If
        'items de cada cliente
        If table.TableName = "cot_cliente" Then
            sql.Append("; Delete c from cot_cliente f join cot_cliente_item c on c.id_cot_cliente=f.id where f.id=@id")
        End If
        'permisos programas roles
        If table.TableName = "usuario_subgrupo" Then
            sql.Append("; Delete c from usuario_subgrupo f join usuario_subgrupo_perm c on c.id_usuario_subgrupo=f.id where f.id=@id")
            'reportes permisos roll
            sql.Append("; Delete c from usuario_subgrupo f join usuario_subgrupo_perm_informes c on c.id_usuario_subgrupo=f.id where f.id=@id")
        End If
        'cuotas de las formas de pago, se deben borrar pues serán creadas nuevamente
        If table.TableName = "cot_forma_pago" Then
            sql.Append("; Delete c from cot_forma_pago f join cot_forma_pago_cuotas c on c.id_cot_forma_pago=f.id where f.id=@id")
        End If
        'tablas que dependen de la fecha del item
        If table.TableName = "cot_item" Then
            sql.Append("; Delete c from cot_item f join cot_item_estruc c on c.id_cot_item=f.id where f.id=@id")
            sql.Append("; Delete c from cot_item f join cot_item_alt c on c.id_cot_item=f.id where f.id=@id")
            'esta se hace aqui aun cuando tengo ID identity, para controlar los borrados.
            sql.Append("; Delete c from cot_item f join cot_item_precios c on c.id_cot_item=f.id where f.id=@id")
        End If
        'listas de precios por categoria
        If table.TableName = "cot_item_categoria" Then
            sql.Append("; Delete c from cot_item_categoria f join cot_item_categoria_listas c on c.id_cot_item_categoria=f.id where f.id=@id")
        End If
        'reglas
        If table.TableName = "reglas" Then
            sql.Append("; Delete c from reglas f join reglas_emp c on c.id_reglas=f.id where f.id=@id")
        End If
        'licencias
        If table.TableName = "emp" Then
            sql.Append("; Delete c from emp f join emp_lic2 c on c.id_emp=f.id where f.id=@id")
        End If

        '/TABLAS CON MANEJO ESPECIAL

        Return sql.ToString()


    End Function

End Class


