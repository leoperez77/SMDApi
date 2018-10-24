' Version: 681, 20-ago.-2018 20:08
Public Module Modulo_Recorrer

	Public Sub RecorrerControlesJDMS(ByVal oContenedor As Object)
		'Dim oCtr As Control
		Try
			For Each oCtr As Object In oContenedor.components.Components
				'For Each oCtr As Object In oContenedor.Controls
				If TypeOf oCtr Is FlowLayoutPanel Or
					TypeOf oCtr Is GroupBox Or
					TypeOf oCtr Is Panel Or
					TypeOf oCtr Is SplitContainer Or
					TypeOf oCtr Is SplitterPanel Or
					TypeOf oCtr Is TabControl Or
					TypeOf oCtr Is SplitterPanel Or
					TypeOf oCtr Is ToolStripContentPanel Or
					TypeOf oCtr Is ToolStripContainer Or
					TypeOf oCtr Is TableLayoutPanel Then
					'MsgBox(oCtr.Name)
					RecorrerControlesJDMS(oCtr)
				End If
				If TypeOf oCtr Is MenuStrip Then
					RecorrerMenu(oCtr)
				End If
				If TypeOf oCtr Is ToolStrip Then
					RecorreToolStrip(oCtr)
				End If
				If TypeOf oCtr Is ContextMenuStrip Then
					RecorrerMenuContextual(oCtr)
				End If
			Next
		Catch ex As Exception
			Throw New System.Exception(System.String.Concat("Nro. Error(",
			Err.Number.ToString, ") - ", ex.Message, vbCrLf, ex.StackTrace,
			vbCrLf))
		End Try
	End Sub

	Public Sub RecorreToolStrip(ByRef pToolStrip As Windows.Forms.ToolStrip)
		'Dim oToolStripButton As Windows.Forms.ToolStripButton
		Try
			For Each Obj As Object In pToolStrip.Items
				If TypeOf Obj Is ToolStripButton Or
					TypeOf Obj Is ToolStripItem Then
					MsgBox("boton: " & Obj.Text)
				End If
				If TypeOf Obj Is ToolStripSeparator Then
					'MsgBox("separador")
				End If
				If TypeOf Obj Is MenuStrip Then
					MsgBox("Menú: " & Obj.text)
					RecorrerMenu(Obj)
				End If

			Next

		Catch ex As Exception
			Throw New System.Exception(System.String.Concat("Nro. Error(", Err.Number.ToString, ") - ", ex.Message, vbCrLf, ex.StackTrace, vbCrLf))
		Finally
			GC.Collect()
		End Try
	End Sub

	Public Sub RecorrerMenuContextual(ByRef pMenu As ContextMenuStrip)
		Dim oToolStripMenuItem As Object ' ToolStripMenuItem
		Try
			For Each oToolStripMenuItem In pMenu.Items
				If TypeOf oToolStripMenuItem Is ToolStripSeparator Then
					Continue For
				End If

				If oToolStripMenuItem.DropDownItems.Count > 0 Then
					MsgBox(oToolStripMenuItem.Text)
					RecorrerSubmenu(oToolStripMenuItem.DropDownItems)
				Else
					oToolStripMenuItem.Text = Idioma(oToolStripMenuItem.Text)
					'MsgBox(oToolStripMenuItem.Name & ": " & oToolStripMenuItem.Text)
				End If
			Next

		Catch ex As Exception
			Throw New System.Exception(System.String.Concat("Nro. Error(", Err.Number.ToString, ") - ", ex.Message, vbCrLf, ex.StackTrace, vbCrLf))
		Finally
			oToolStripMenuItem = Nothing : GC.Collect()
		End Try
	End Sub

	Public Sub RecorrerMenu(ByRef pMenu As MenuStrip)
		Dim oToolStripMenuItem As ToolStripMenuItem
		Try
			For Each oToolStripMenuItem In pMenu.Items
				If oToolStripMenuItem.DropDownItems.Count > 0 Then
					MsgBox(oToolStripMenuItem.Text)
					RecorrerSubmenu(oToolStripMenuItem.DropDownItems)
				Else
					MsgBox(oToolStripMenuItem.Text)
				End If
			Next

		Catch ex As Exception
			Throw New System.Exception(System.String.Concat("Nro. Error(",
			Err.Number.ToString, ") - ", ex.Message, vbCrLf, ex.StackTrace,
			vbCrLf))
		Finally
			oToolStripMenuItem = Nothing : GC.Collect()
		End Try
	End Sub

	Private Sub RecorrerSubmenu(ByVal oSubmenuItems As Windows.Forms.ToolStripItemCollection)
		Dim oToolStripItem As Windows.Forms.ToolStripItem

		Try
			For Each oToolStripItem In oSubmenuItems
				If oToolStripItem.GetType Is
				GetType(Windows.Forms.ToolStripMenuItem) Then
					If CType(oToolStripItem, Windows.Forms.ToolStripMenuItem).DropDownItems.Count > 0 Then
						MsgBox(oToolStripItem.Text)
						RecorrerSubmenu(CType(oToolStripItem,
						Windows.Forms.ToolStripMenuItem).DropDownItems)
					Else
						MsgBox(oToolStripItem.Text)
					End If
				End If
			Next

		Catch ex As Exception
			Throw New System.Exception(System.String.Concat("Nro. Error(", Err.Number.ToString, ") - ", ex.Message, vbCrLf, ex.StackTrace, vbCrLf))
		Finally
			oToolStripItem = Nothing : GC.Collect()
		End Try
	End Sub




	Public Sub Nuevo_Recorrer(uForm As Form)
		'For Each c As Control In uForm.components.Components

		'	If TypeOf c Is ContextMenuStrip Then

		'		Dim n As ContextMenuStrip
		'		n = DirectCast(c, ContextMenuStrip)

		'		For Each c2 As ToolStripMenuItem In n.Items
		'			MsgBox(c2.Text)
		'		Next
		'	End If

		'Next
	End Sub




End Module
