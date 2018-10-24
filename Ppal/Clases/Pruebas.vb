'♥ versión: 586, 6-oct.-2017 07:11
Public Class Pruebas
    Private Shared YaLeyoReglas As Boolean = False
    Public Shared Function ReglaDeNegocio(ByVal NumeroRegla As Integer, Optional ByVal Llave As String = "", Optional ByVal ValorPredeterminado As String = "") As String
        If GetSetting("DMS S.A.", "syscom", "refrn" & NumeroRegla.ToString, "0") = "1" Then 'debe refrescar
            Try
                YaLeyoReglas = False
                DtReglas.Rows.Clear()
                SaveSetting("DMS S.A.", "syscom", "refrn" & NumeroRegla.ToString, "")
            Catch
            End Try
        End If


        If Not YaLeyoReglas And DtReglas.Rows.Count = 0 Then
            DebugJD("Refrescó reglas")
            Abrir(DtReglas, "GetReglasResp " & Numero_Empresa.ToString)
            YaLeyoReglas = True
        End If

        Try
            Dim Dr() As DataRow
            Dr = DtReglas.Select("id_reglas=" & NumeroRegla & " And llave='" & Llave & "'")

            If Dr.Length = 0 Then 'no tiene valor asignado
                Return ValorPredeterminado
            End If

            Select Case Dr(0).Item("tipo_regla")
                Case 1 'verdad o falso
                    Return ValD("" & Dr(0).Item("respuesta")).ToString
                Case 2
                    Return "" & Dr(0).Item("respuesta")
                Case 3 'valor
                    Dim VJD As String = "" & Dr(0).Item("respuesta")
                    Dim CC As String = 5 / 2
                    If InStr(CC, ",") Then CC = "," Else CC = "."
                    VJD = VJD.Replace(".", CC)
                    VJD = VJD.Replace(",", CC)
                    If IsNumeric(VJD) Then
                        Return ValD(VJD).ToString
                    Else
                        Return "0"
                    End If
                Case 4 'fecha
                    Return Microsoft.VisualBasic.Strings.Format(CDate(Dr(0).Item("respuesta")), "yyyy/MM/dd HH:mm")
                Case Else
                    Return "" & Dr(0).Item("respuesta")
            End Select

        Catch
            Return ""

        End Try

    End Function

End Class
