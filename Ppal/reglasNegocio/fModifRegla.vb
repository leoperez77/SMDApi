' Version: 683, 23-ago.-2018 12:40
' Version: 682, 22-ago.-2018 13:18
' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
Public Class fModifRegla

    Private Sub fModifRegla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Recorrer_Controles_Idioma(Me, Me)

		PnlSINO.Location = PnlTexto.Location

	End Sub
    Private Sub LnkAgrandar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkAgrandar.LinkClicked
        TxtTexto.Text = AmpliarTextBox(Me, TxtTexto)

    End Sub
    Private Sub CmdAdiRegla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdiRegla.Click
        'actualizar la regla
        Try
            SiReloj()

            Dim sql As String
            If TxtTexto.Text = "" Then
                'HS("Exec DelReglasEmp ")
                'HS(Numero_Empresa.ToString & ",")
                'HS(LblRegla.Tag & ",'" & LblLlave.Text & "'")
                'HS("," & Usuario)

                sql = ArmeSQL(
                "Exec DelReglasEmp",
                Numero_Empresa, qqNum,
                LblRegla.Tag, qqNum,
                LblLlave.Text, qqTex,
                Usuario, qqNum
                    )
            Else
                sql = ArmeSQL(
                "Exec PutReglasEmp",
                Numero_Empresa, qqNum,
                LblRegla.Tag, qqNum,
                TxtTexto.Text, qqTex,
                LblLlave.Text, qqTex,
                Usuario, qqNum
                    )
            End If

            sql &= ArmeSQL("exec GetReglasResp2",
                           Numero_Empresa, qqNum,
                           Usuario, qqNum,
                           "1", qqCon)

            'ejecuto y refresco de una vez
            Abrir(DtReglas, sql)
            Dim PrimaryKeyColumns(2) As DataColumn
            PrimaryKeyColumns(0) = DtReglas.Columns("id_reglas")
            PrimaryKeyColumns(1) = DtReglas.Columns("llave")
            DtReglas.PrimaryKey = PrimaryKeyColumns

            Ponga_Table()

            NoReloj()

            Me.Tag = TxtTexto.Text
            Me.Close()



        Catch ex As Exception
            NoReloj()
			MostrarError(Me.Name, "CmdAdiRegla_Click", ex.Message)

		End Try
    End Sub
    Private Sub Ponga_Table()


        'ya no se hace esto por que ahora estamos leyendo todo de nuevo
        'Dim Encontro As Boolean = False
        'For Each Fi As DataRow In DtReglas.Rows
        '    If Fi("id_reglas") = LblRegla.Tag Then
        '        If LCase("" & Fi("llave")) = LCase(LblLlave.Text) Then 'encontró
        '            Encontro = True
        '            If TxtTexto.Text = "" Then
        '                Fi("respuesta") = LblDefault.Text
        '            Else
        '                Fi("respuesta") = TxtTexto.Text
        '            End If
        '            Fi.AcceptChanges()
        '            Exit For
        '        End If
        '    End If
        'Next
        'If Not Encontro Then
        '    DtReglas.Rows.Add(LblRegla.Tag, LblLlave.Text, TxtTexto.Text, "2")
        'End If

    End Sub

    Private Sub LnkAudit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkAudit.LinkClicked
        Ventana("GetCotAuditoria_Reglas", "Auditoría Regla " & LblRegla.Tag, False, , Numero_Empresa.ToString, ValD(LblRegla.Tag), FmtFec("1980-01-01"), FmtFec("2050-12-31"))

    End Sub

    Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click
        Me.Tag = "&&&"
        Me.Close()

    End Sub

    Private Sub RdSi_CheckedChanged(sender As Object, e As EventArgs) Handles RdSi.CheckedChanged
        If RdSi.Checked Then
            TxtTexto.Text = 1
        Else
            TxtTexto.Text = 0
        End If
    End Sub

    Private Sub LblDefault_Click(sender As Object, e As EventArgs) Handles LblDefault.Click
        TxtTexto.Text = LblDefault.Text

    End Sub
End Class