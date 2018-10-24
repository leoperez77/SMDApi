' Version: 682, 22-ago.-2018 13:18
'♥ versión: 586, 6-oct.-2017 07:11
Public Class ConfRN
    Public Shared NumPrograma As String

    Public Shared Sub Agregar(ReglaNumero As Integer, Optional LLave As String = "", Optional Predeterminado As String = "0", Optional Explicacion As String = "")
        If DtRNTit Is Nothing Then
			Abrir(DtRNTit, "select id,titulo=" & IIf(LenguajeAdvance = 1, "ISNULL(titulo_ingles, titulo)", "titulo") & ",descripcion=" & IIf(LenguajeAdvance = 1, "ISNULL(ingles, descripcion)", "descripcion") & ",tipo_regla from dbo.reglas")
		End If

        Dim titulo As String = "" & Obtenga_Dato(DtRNTit, "id=" & ReglaNumero, "titulo")

        'primero buscar la explicación en la llave
        If Explicacion = "" And LLave <> "" Then
            Dim expli As String = "" & Obtenga_Dato(DtRNTit, "id=" & ReglaNumero, "descripcion")
            Dim ini As Integer = InStr(LCase(expli), "[" & LCase(LLave) & "]")
            If ini > 0 Then
                Dim ini2 As Integer = ini + LLave.Length + 2
                Dim fin As Integer = InStr(ini2, expli, "[")
                If fin > 0 Then
                    Explicacion = Mid(expli, ini2, fin - ini2).ToString.Trim 'pasa el resto
                Else
                    Explicacion = Mid(expli, ini2).ToString.Trim 'pasa el resto
                End If
            End If
        End If

        If Explicacion = "" Then
            Explicacion = "" & Obtenga_Dato(DtRNTit, "id=" & ReglaNumero, "descripcion")
        End If
        Dim Valor As String
        Valor = ReglaDeNegocio(ReglaNumero, LLave, "")
        DtRN.Rows.Add(ReglaNumero, titulo, LLave, Valor, Explicacion, Predeterminado)


    End Sub
    Public Shared Function Iniciar(QueProgramaNumero As String)
        NumPrograma = QueProgramaNumero

        'inicializar
        DtRN = New DataTable
        DtRN.Columns.Add("Rn", System.Type.GetType("System.Int32"))

        DtRN.Columns.Add("Titulo")
        DtRN.Columns.Add("Llave")
        DtRN.Columns.Add("Valor")
        DtRN.Columns.Add("Descripcion")
        DtRN.Columns.Add("Predet")

        If NoPuede4(ValD(NumPrograma), 8500, , False) Then
            Return "1"
        End If

        Return GetSett("fconf" & MarcaExterna & "-" & Numero_Empresa, NumPrograma, "")

    End Function
    Public Shared Sub MostrarPantalla(Obligar As Boolean)
        Dim abrir As String = GetSett("fconf" & MarcaExterna & "-" & Numero_Empresa, NumPrograma, "")

        If abrir = "1" And Not Obligar Then
            Exit Sub
        End If

        'si no tiene permiso salir
        If NoPuede4(ValD(NumPrograma), 8500, , Obligar) Then
            Exit Sub
        End If

        Dim fRe As New fReglasNegocio
        fRe.Tag = NumPrograma
        fRe.ChAbrir.Checked = abrir = ""
        fRe.TopMost = Not Obligar 'para que solo sea topmost cuando entre desde el inicio y no cuando es llamada con el link del programa
        fRe.ShowDialog()

        If fRe.Modifico And Obligar Then
            Mensaje("Para tomar los cambios cierre el programa " & NumPrograma & " y vuelva a ingresar")
        End If

        If Not Obligar Then
            SiReloj(fBusIt)
        End If

    End Sub

End Class
