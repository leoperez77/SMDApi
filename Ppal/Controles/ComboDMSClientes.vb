' Version: 681, 20-ago.-2018 20:08
'♥ versión: 586, 6-oct.-2017 07:11
Imports System.ComponentModel

Public Class ComboDMSClientes
    Public Event DMSSelectIndex(ByVal Sender As Object, ByVal Id As Integer)
    Dim DtOriginal As New DataTable
    Dim _Titulo As String = "(Seleccione cliente/tercero)"
    Dim _Buscar As Boolean = True
    Dim _VerContactos As Boolean = False
    Dim _Destino As Integer = 0
    Public ContactoId As Integer = 0
    Public ContactoNombre As String = ""

    Public Function DMSTraerTexto() As String
        Return "" & ComboBox1.Text

    End Function
    Property DMSTituloCliente() As String
        Get
            Return _Titulo
        End Get
        Set(ByVal value As String)
            _Titulo = value
        End Set
    End Property
    Property DMSUsaBuscar() As Boolean
        Get
            Return _Buscar
        End Get
        Set(ByVal value As Boolean)
            _Buscar = value
        End Set
    End Property
    Property DMSVerContactos() As Boolean
        Get
            Return _VerContactos
        End Get
        Set(ByVal value As Boolean)
            _VerContactos = value
        End Set
    End Property

    <Description("Incluir en el combo 0=todos, 1=proveedores"), Browsable(True)> _
    Public Property DMSDestino() As Integer
        Get
            Return _Destino
        End Get
        Set(ByVal value As Integer)
            _Destino = value
        End Set
    End Property

    Private Sub ComboDMSClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargue_Combo()

    End Sub
    Private Sub Cargue_Combo()
        If ComboBox1.Items.Count > 0 Then Exit Sub

        If _Buscar Then
            ComboBox1.Items.Add(New DataDescription(0, _Titulo))
            ComboBox1.Items.Add(New DataDescription(-2, "[Buscar...]"))
            PongaIndexVB(ComboBox1, 0)
        End If
        'ComboBox1.SelectedIndex = 0

    End Sub
    Private Sub CbCli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If TraerId(ComboBox1) >= 0 Then
            RaiseEvent DMSSelectIndex(Me, DMSTraerId())
            Exit Sub
        End If
        'If ComboBox1.SelectedIndex <> 1 Then  'buscar
        '    RaiseEvent DMSSelectIndex(Me, DMSTraerId())
        '    Exit Sub
        'End If

        Dim IdCliente As Integer = 0
        Dim RazonSocial As String = ""
        Dim IdContacto As Integer = IIf(_VerContactos, -1, 0)
        Dim Nombre As String = ""

        Haga_Buscar_Cliente(IdCliente, RazonSocial, IdContacto, Nombre, , , , , , , _Destino)
        If IdCliente = 0 Then
            ComboBox1.SelectedIndex = 0
            Exit Sub
        End If

        ContactoId = IdContacto
        ContactoNombre = Nombre

        DMSAdicionar_Tercero(IdCliente, RazonSocial)



    End Sub
    Public Sub DMSAdicionar_Tercero(ByVal IdTercero As Integer, ByVal NombreTercero As String)
        If _VerContactos = True Then 'solo cargar un cliente
            ComboBox1.Items.Clear()
        End If

        Cargue_Combo()

        PongaIndex(ComboBox1, IdTercero)
        If ComboBox1.SelectedIndex <= 0 Then
            ComboBox1.Items.Add(New DataDescription(IdTercero, NombreTercero))
            PongaIndex(ComboBox1, IdTercero)
        End If
    End Sub
    Public Function DMSTraerId() As Integer
        If ComboBox1.SelectedIndex < 0 Then
            Return 0
        End If


        Dim Mue As DataDescription
        Mue = ComboBox1.Items(ComboBox1.SelectedIndex)
        Return Mue.Data


    End Function

    Public Function DMSPongaIndex(ByVal IdInicial As Integer) As Integer
        PongaIndex(ComboBox1, IdInicial)
        'ComboBox1.SelectedValue = IdInicial
    End Function
    Public Sub DMSPongaTodos()
        If _VerContactos = True Then 'solo cargar un cliente
            ComboBox1.Items.Clear()
            Cargue_Combo()
        End If

        ComboBox1.SelectedIndex = 0

    End Sub
    Public Sub DMSPongaBuscar()
        ComboBox1.SelectedIndex = 0
        ComboBox1.SelectedIndex = 1

    End Sub


    Private Sub LblBuscar_Click(sender As System.Object, e As System.EventArgs) Handles LblBuscar.Click
        DMSPongaBuscar()

    End Sub

    Private Sub ComboBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.F1 Then
            DMSPongaBuscar()
        End If
    End Sub
End Class
