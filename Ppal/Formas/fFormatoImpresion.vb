' Version: 683, 23-ago.-2018 12:40
' Version: 681, 20-ago.-2018 20:08
' Version: 680, 17-ago.-2018 13:24
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fFormatoImpresion
    Public IdFormato As Integer = 0
    Public IdUnico As Integer = 0
    Public FormatoVehiculo As Integer = -9
    Public CualSw As Integer = 0

    Private Sub fFormatoImpresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Me.Tag = ""

		IdFormato = 0

        Cargar_Formatos_Impresion()

        Cargar_Archivos()

        If Grd.Rows.Count = 1 Then
            CmdAceptar_Click(CmdAceptar, New EventArgs)
            Me.Close()
            Exit Sub
        End If

        NoReloj(Me)

    End Sub
    Private Sub Cargar_Archivos()
        Try

            Cargar_Formatos_Impresion()

            Dim Dr() As DataRow
            If IdUnico > 0 Then
                Dr = FormatoImp.Select("id=" & IdUnico.ToString & " Or publico=1", "descripcion")
            Else
                If Not FormatoVehiculo Then 'todos
                    Dim Cual As String = "IsNull(publico,0)<>2"
                    If Regla_SoyAutomotriz_16() Or Regla_SoyTaller_15() Then
                        Cual = ""
                    End If
                    Dr = FormatoImp.Select(Cual, "descripcion")
                Else
                    Dr = FormatoImp.Select("publico=2", "descripcion")
                End If
            End If
            Grd.Rows.Clear()
            For Each row As DataRow In Dr
                'ver si está en la tabla de tipos
                If FormatoVehiculo Or Obtenga_Dato(FormatoImpSw, "id_cot_cotizacion_formatos=" & row.Item("id").ToString & " And sw=" & CualSw.ToString, "sw") IsNot System.DBNull.Value Then
                    Grd.Rows.Add(row.Item("id"), row.Item("descripcion"), row.Item("fecha"))
                    'Grd.Rows.Add(row.Item("id"), row.Item("descripcion"), row.Item("fecha"), row.Item("tamano"))
                End If
            Next

        Catch ex As Exception
			Mensaje(ex.Message)

		End Try

	End Sub
	Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click
		If Grd.Rows.Count = 0 Then
			Mensaje("No hay formatos")
			Exit Sub
		End If

		Reloj()

		'Me.Tag = Tm(Grd, "id")
		IdFormato = Tm(Grd, "id")

		Me.Close()


	End Sub


	Private Sub LnkEliminar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
		If Grd.Rows.Count = 0 Then
			Mensaje("Formato")
			Exit Sub
		End If
		If Not Pregunte(Idi("Seguro de eliminar") & " " & Tm(Grd, "descripcion") & "?", , , , 3) Then
			Exit Sub
		End If

		If Tm(Grd, "id") = 1 Then
			Mensaje("Este formato No es modificable")
			Exit Sub
		End If

		SiReloj()

		Try
			Ejecutar(DelCotCotizacionFormato, Numero_Empresa.ToString, Usuario.ToString, Tm(Grd, "id").ToString)

			FormatoImp.Rows.Clear()
			Cargar_Archivos()

		Catch ex As Exception
			Mensaje("El formato no se puede borrar pues está siendo usado por alguna campaña")

			'MostrarError(Me.Name, "", ex.Message & EsIngles)
			'MostrarError(Me.Name, "LnkEliminar_LinkClicked", ex.Message & EsIngles)

		End Try

        NoReloj()


    End Sub

    Private Sub LnkRefrescar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkRefrescar.LinkClicked
        FormatoImp.Rows.Clear()
        Cargar_Archivos()

    End Sub

    Private Sub Grd_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grd.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        CmdAceptar_Click(CmdAceptar, New EventArgs)

    End Sub

End Class