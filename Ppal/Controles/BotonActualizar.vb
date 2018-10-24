' Version: 684, 25-ago.-2018 20:17
' Version: 683, 23-ago.-2018 12:40
' Version: 679, 16-ago.-2018 21:01
' Version: 679, 16-ago.-2018 20:01
'♥ versión: 586, 6-oct.-2017 07:11
<System.ComponentModel.DefaultEvent("DMSClick")>
Public Class BotonActualizar
	Dim _UsaF5 As Boolean = False
	Dim _ImagenArriba As Boolean = False
	Dim _Text As String = "&Actualizar"
	Public Event DMSClick(ByVal Sender As Object)

	Private Sub BotonActualizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		AsignarImagenPrograma(CmdActualizar, 1036)
		CmdActualizar.Text = Idi(DMSText)



	End Sub

	Private Sub CmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdActualizar.Click
		RaiseEvent DMSClick(Me)

	End Sub
	Property DMSUsaF5() As Boolean
		Get
			Return _UsaF5
		End Get
		Set(ByVal value As Boolean)
			_UsaF5 = value
			If _UsaF5 Then
				CmdActualizar.Text &= " F5"
			Else
				CmdActualizar.Text = CmdActualizar.Text.Replace(" F5", "")
			End If
		End Set
	End Property
	Property DMSImagenArriba() As Boolean
		Get
			Return _ImagenArriba
		End Get
		Set(ByVal value As Boolean)
			_ImagenArriba = value
			If _ImagenArriba Then
				CmdActualizar.ImageAlign = ContentAlignment.TopCenter
				CmdActualizar.TextAlign = ContentAlignment.BottomCenter
				CmdActualizar.TextImageRelation = TextImageRelation.ImageAboveText
			Else
				CmdActualizar.ImageAlign = ContentAlignment.MiddleLeft
				CmdActualizar.TextAlign = ContentAlignment.MiddleRight
				CmdActualizar.TextImageRelation = TextImageRelation.ImageBeforeText

			End If
		End Set
	End Property
	Property DMSText() As String
		Get
			Return _Text
		End Get
		Set(ByVal value As String)
			_Text = value
		End Set
	End Property

End Class
