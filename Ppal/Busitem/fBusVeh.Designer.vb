<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fBusVeh
    'Inherits System.Windows.Forms.Form
    Inherits AdvanceForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fBusVeh))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TbBuscar = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CbBod = New SMDPpal.ComboDMS()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LnkMarca = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ChkVacios = New System.Windows.Forms.CheckBox()
        Me.ChkTotales = New System.Windows.Forms.CheckBox()
        Me.ChkBuscarVIN = New System.Windows.Forms.CheckBox()
        Me.PnlVeh = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CbColor_externo = New System.Windows.Forms.ComboBox()
        Me.CbStock = New System.Windows.Forms.ComboBox()
        Me.CbClase = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CbServicio = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PnlRangoFechas = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtFecSup = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtFecInf = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CbColor_interno = New System.Windows.Forms.ComboBox()
        Me.ChkFechaVence = New System.Windows.Forms.CheckBox()
        Me.TxtPlaca = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LblKim = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblAseguradora = New SMDPpal.LblCliente()
        Me.CbNuevo = New System.Windows.Forms.ComboBox()
        Me.TxtKmMin = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbPais_Pais = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbPais_Depto = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.CbPais_Ciudad = New System.Windows.Forms.ComboBox()
        Me.TxtLicTransito = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtKmMax = New System.Windows.Forms.TextBox()
        Me.TxtVIN = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtMotor = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblPropietario = New SMDPpal.LblCliente()
        Me.TxtChasis = New System.Windows.Forms.TextBox()
        Me.TxtPresupuestoMaximo = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtPresupuesto = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtAñoSup = New System.Windows.Forms.TextBox()
        Me.TxtAñoInf = New System.Windows.Forms.TextBox()
        Me.LblDesModAno = New System.Windows.Forms.Label()
        Me.TxtModAno = New System.Windows.Forms.TextBox()
        Me.LblIDMod = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblIDLin = New System.Windows.Forms.Label()
        Me.LblIDMarca = New System.Windows.Forms.Label()
        Me.CmdBuscar = New SMDPpal.BotonEstandar()
        Me.CbMarca = New System.Windows.Forms.ComboBox()
        Me.CbModelo = New System.Windows.Forms.ComboBox()
        Me.CbLinea = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbVins = New System.Windows.Forms.TabPage()
        Me.LnkCols = New System.Windows.Forms.LinkLabel()
        Me.GrdSeriales = New SMDPpal.GridDms()
        Me.LnkNueva = New System.Windows.Forms.LinkLabel()
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TbBuscar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlVeh.SuspendLayout()
        Me.PnlRangoFechas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TbVins.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicPuntoAdv
        '
        Me.PicPuntoAdv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicPuntoAdv.Location = New System.Drawing.Point(763, 0)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TbBuscar)
        Me.TabControl1.Controls.Add(Me.TbVins)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 528)
        Me.TabControl1.TabIndex = 156
        '
        'TbBuscar
        '
        Me.TbBuscar.Controls.Add(Me.Panel2)
        Me.TbBuscar.Location = New System.Drawing.Point(4, 22)
        Me.TbBuscar.Name = "TbBuscar"
        Me.TbBuscar.Padding = New System.Windows.Forms.Padding(3)
        Me.TbBuscar.Size = New System.Drawing.Size(776, 502)
        Me.TbBuscar.TabIndex = 0
        Me.TbBuscar.Text = "Buscar modelo-año"
        Me.TbBuscar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.CbBod)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.LnkMarca)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.ChkVacios)
        Me.Panel2.Controls.Add(Me.ChkTotales)
        Me.Panel2.Controls.Add(Me.ChkBuscarVIN)
        Me.Panel2.Controls.Add(Me.PnlVeh)
        Me.Panel2.Controls.Add(Me.TxtPresupuestoMaximo)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.TxtPresupuesto)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.TxtAñoSup)
        Me.Panel2.Controls.Add(Me.TxtAñoInf)
        Me.Panel2.Controls.Add(Me.LblDesModAno)
        Me.Panel2.Controls.Add(Me.TxtModAno)
        Me.Panel2.Controls.Add(Me.LblIDMod)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.LblIDLin)
        Me.Panel2.Controls.Add(Me.LblIDMarca)
        Me.Panel2.Controls.Add(Me.CmdBuscar)
        Me.Panel2.Controls.Add(Me.CbMarca)
        Me.Panel2.Controls.Add(Me.CbModelo)
        Me.Panel2.Controls.Add(Me.CbLinea)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(2, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(773, 493)
        Me.Panel2.TabIndex = 21
        '
        'CbBod
        '
        Me.CbBod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CbBod.Location = New System.Drawing.Point(514, 121)
        Me.CbBod.Name = "CbBod"
        Me.CbBod.Size = New System.Drawing.Size(246, 21)
        Me.CbBod.TabIndex = 171
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(423, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Bodega stock"
        '
        'LnkMarca
        '
        Me.LnkMarca.AutoSize = True
        Me.LnkMarca.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkMarca.Location = New System.Drawing.Point(17, 46)
        Me.LnkMarca.Name = "LnkMarca"
        Me.LnkMarca.Size = New System.Drawing.Size(37, 13)
        Me.LnkMarca.TabIndex = 170
        Me.LnkMarca.TabStop = True
        Me.LnkMarca.Text = "Marca"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(422, 46)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(63, 13)
        Me.LinkLabel1.TabIndex = 169
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Modelo año"
        '
        'ChkVacios
        '
        Me.ChkVacios.AutoSize = True
        Me.ChkVacios.Location = New System.Drawing.Point(450, 164)
        Me.ChkVacios.Name = "ChkVacios"
        Me.ChkVacios.Size = New System.Drawing.Size(310, 17)
        Me.ChkVacios.TabIndex = 168
        Me.ChkVacios.Text = "Solo mostrar modelos-año que no tengan vehículos creados"
        Me.ChkVacios.UseVisualStyleBackColor = True
        '
        'ChkTotales
        '
        Me.ChkTotales.AutoSize = True
        Me.ChkTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTotales.Location = New System.Drawing.Point(36, 181)
        Me.ChkTotales.Name = "ChkTotales"
        Me.ChkTotales.Size = New System.Drawing.Size(134, 17)
        Me.ChkTotales.TabIndex = 166
        Me.ChkTotales.Text = "Total x modelo-año"
        Me.ChkTotales.UseVisualStyleBackColor = True
        Me.ChkTotales.Visible = False
        '
        'ChkBuscarVIN
        '
        Me.ChkBuscarVIN.AutoSize = True
        Me.ChkBuscarVIN.Location = New System.Drawing.Point(17, 164)
        Me.ChkBuscarVIN.Name = "ChkBuscarVIN"
        Me.ChkBuscarVIN.Size = New System.Drawing.Size(95, 17)
        Me.ChkBuscarVIN.TabIndex = 165
        Me.ChkBuscarVIN.Text = "Buscar en VIN"
        Me.ChkBuscarVIN.UseVisualStyleBackColor = True
        '
        'PnlVeh
        '
        Me.PnlVeh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlVeh.Controls.Add(Me.Label16)
        Me.PnlVeh.Controls.Add(Me.Label21)
        Me.PnlVeh.Controls.Add(Me.CbColor_externo)
        Me.PnlVeh.Controls.Add(Me.CbStock)
        Me.PnlVeh.Controls.Add(Me.CbClase)
        Me.PnlVeh.Controls.Add(Me.Label22)
        Me.PnlVeh.Controls.Add(Me.Label14)
        Me.PnlVeh.Controls.Add(Me.CbServicio)
        Me.PnlVeh.Controls.Add(Me.Label13)
        Me.PnlVeh.Controls.Add(Me.PnlRangoFechas)
        Me.PnlVeh.Controls.Add(Me.Label24)
        Me.PnlVeh.Controls.Add(Me.CbColor_interno)
        Me.PnlVeh.Controls.Add(Me.ChkFechaVence)
        Me.PnlVeh.Controls.Add(Me.TxtPlaca)
        Me.PnlVeh.Controls.Add(Me.Label19)
        Me.PnlVeh.Controls.Add(Me.LinkLabel3)
        Me.PnlVeh.Controls.Add(Me.TxtDescripcion)
        Me.PnlVeh.Controls.Add(Me.LblKim)
        Me.PnlVeh.Controls.Add(Me.Label3)
        Me.PnlVeh.Controls.Add(Me.LblAseguradora)
        Me.PnlVeh.Controls.Add(Me.CbNuevo)
        Me.PnlVeh.Controls.Add(Me.TxtKmMin)
        Me.PnlVeh.Controls.Add(Me.GroupBox1)
        Me.PnlVeh.Controls.Add(Me.TxtLicTransito)
        Me.PnlVeh.Controls.Add(Me.Label7)
        Me.PnlVeh.Controls.Add(Me.TxtKmMax)
        Me.PnlVeh.Controls.Add(Me.TxtVIN)
        Me.PnlVeh.Controls.Add(Me.Label11)
        Me.PnlVeh.Controls.Add(Me.Label8)
        Me.PnlVeh.Controls.Add(Me.TxtMotor)
        Me.PnlVeh.Controls.Add(Me.LinkLabel2)
        Me.PnlVeh.Controls.Add(Me.Label10)
        Me.PnlVeh.Controls.Add(Me.LblPropietario)
        Me.PnlVeh.Controls.Add(Me.TxtChasis)
        Me.PnlVeh.Location = New System.Drawing.Point(5, 213)
        Me.PnlVeh.Name = "PnlVeh"
        Me.PnlVeh.Size = New System.Drawing.Size(768, 278)
        Me.PnlVeh.TabIndex = 165
        Me.PnlVeh.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Placa"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(17, 209)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 13)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Color externo"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbColor_externo
        '
        Me.CbColor_externo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbColor_externo.FormattingEnabled = True
        Me.CbColor_externo.Location = New System.Drawing.Point(109, 206)
        Me.CbColor_externo.Name = "CbColor_externo"
        Me.CbColor_externo.Size = New System.Drawing.Size(111, 21)
        Me.CbColor_externo.TabIndex = 12
        '
        'CbStock
        '
        Me.CbStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbStock.FormattingEnabled = True
        Me.CbStock.Items.AddRange(New Object() {"0 = Todos", "1 = Vehículos en existencia", "2 = Vehículos Disponibles", "3 = Vehículos con Pedidos", "4 = Vehículos sin Stock"})
        Me.CbStock.Location = New System.Drawing.Point(506, 5)
        Me.CbStock.Name = "CbStock"
        Me.CbStock.Size = New System.Drawing.Size(203, 21)
        Me.CbStock.TabIndex = 163
        '
        'CbClase
        '
        Me.CbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbClase.FormattingEnabled = True
        Me.CbClase.Location = New System.Drawing.Point(109, 230)
        Me.CbClase.Name = "CbClase"
        Me.CbClase.Size = New System.Drawing.Size(111, 21)
        Me.CbClase.TabIndex = 14
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(417, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 13)
        Me.Label22.TabIndex = 164
        Me.Label22.Text = "Existencia"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 257)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Servicio"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbServicio
        '
        Me.CbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbServicio.FormattingEnabled = True
        Me.CbServicio.Location = New System.Drawing.Point(109, 254)
        Me.CbServicio.Name = "CbServicio"
        Me.CbServicio.Size = New System.Drawing.Size(111, 21)
        Me.CbServicio.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Clase"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlRangoFechas
        '
        Me.PnlRangoFechas.Controls.Add(Me.Label17)
        Me.PnlRangoFechas.Controls.Add(Me.TxtFecSup)
        Me.PnlRangoFechas.Controls.Add(Me.Label12)
        Me.PnlRangoFechas.Controls.Add(Me.TxtFecInf)
        Me.PnlRangoFechas.Location = New System.Drawing.Point(73, 147)
        Me.PnlRangoFechas.Name = "PnlRangoFechas"
        Me.PnlRangoFechas.Size = New System.Drawing.Size(314, 29)
        Me.PnlRangoFechas.TabIndex = 162
        Me.PnlRangoFechas.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(164, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 150
        Me.Label17.Text = "Hasta"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFecSup
        '
        Me.TxtFecSup.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFecSup.Location = New System.Drawing.Point(204, 6)
        Me.TxtFecSup.Name = "TxtFecSup"
        Me.TxtFecSup.Size = New System.Drawing.Size(101, 20)
        Me.TxtFecSup.TabIndex = 149
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 148
        Me.Label12.Text = "Desde"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFecInf
        '
        Me.TxtFecInf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFecInf.Location = New System.Drawing.Point(43, 5)
        Me.TxtFecInf.Name = "TxtFecInf"
        Me.TxtFecInf.Size = New System.Drawing.Size(101, 20)
        Me.TxtFecInf.TabIndex = 14
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(226, 209)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(66, 13)
        Me.Label24.TabIndex = 50
        Me.Label24.Text = "Color interno"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbColor_interno
        '
        Me.CbColor_interno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbColor_interno.FormattingEnabled = True
        Me.CbColor_interno.Location = New System.Drawing.Point(301, 206)
        Me.CbColor_interno.Name = "CbColor_interno"
        Me.CbColor_interno.Size = New System.Drawing.Size(111, 21)
        Me.CbColor_interno.TabIndex = 13
        '
        'ChkFechaVence
        '
        Me.ChkFechaVence.AutoSize = True
        Me.ChkFechaVence.Location = New System.Drawing.Point(20, 128)
        Me.ChkFechaVence.Name = "ChkFechaVence"
        Me.ChkFechaVence.Size = New System.Drawing.Size(212, 17)
        Me.ChkFechaVence.TabIndex = 161
        Me.ChkFechaVence.Text = "Rango fechas vence seguro obligatorio"
        Me.ChkFechaVence.UseVisualStyleBackColor = True
        '
        'TxtPlaca
        '
        Me.TxtPlaca.Location = New System.Drawing.Point(105, 5)
        Me.TxtPlaca.MaxLength = 20
        Me.TxtPlaca.Name = "TxtPlaca"
        Me.TxtPlaca.Size = New System.Drawing.Size(90, 20)
        Me.TxtPlaca.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(13, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Descripción"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel3.Location = New System.Drawing.Point(271, 118)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(120, 13)
        Me.LinkLabel3.TabIndex = 160
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Todas las aseguradoras"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(105, 27)
        Me.TxtDescripcion.MaxLength = 20
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(90, 20)
        Me.TxtDescripcion.TabIndex = 8
        '
        'LblKim
        '
        Me.LblKim.AutoSize = True
        Me.LblKim.Location = New System.Drawing.Point(438, 240)
        Me.LblKim.Name = "LblKim"
        Me.LblKim.Size = New System.Drawing.Size(59, 13)
        Me.LblKim.TabIndex = 43
        Me.LblKim.Text = "KM inf/sup"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(226, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Nuevo/usado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAseguradora
        '
        Me.LblAseguradora.BackColor = System.Drawing.Color.SeaShell
        Me.LblAseguradora.DMSEsProveedor = False
        Me.LblAseguradora.DMSLimpiar = False
        Me.LblAseguradora.DMSPideContacto = False
        Me.LblAseguradora.DMSTituloTercero = "Aseguradora"
        Me.LblAseguradora.DMSVerNit = True
        Me.LblAseguradora.Location = New System.Drawing.Point(16, 77)
        Me.LblAseguradora.Name = "LblAseguradora"
        Me.LblAseguradora.Size = New System.Drawing.Size(380, 38)
        Me.LblAseguradora.TabIndex = 159
        '
        'CbNuevo
        '
        Me.CbNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNuevo.FormattingEnabled = True
        Me.CbNuevo.Items.AddRange(New Object() {"0 = Ambos", "1 = Nuevos", "2 = Usados"})
        Me.CbNuevo.Location = New System.Drawing.Point(301, 233)
        Me.CbNuevo.Name = "CbNuevo"
        Me.CbNuevo.Size = New System.Drawing.Size(111, 21)
        Me.CbNuevo.TabIndex = 16
        '
        'TxtKmMin
        '
        Me.TxtKmMin.Location = New System.Drawing.Point(507, 237)
        Me.TxtKmMin.Name = "TxtKmMin"
        Me.TxtKmMin.Size = New System.Drawing.Size(65, 20)
        Me.TxtKmMin.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CbPais_Pais)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CbPais_Depto)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.CbPais_Ciudad)
        Me.GroupBox1.Location = New System.Drawing.Point(430, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 119)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ciudad de la placa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Depto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbPais_Pais
        '
        Me.CbPais_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPais_Pais.FormattingEnabled = True
        Me.CbPais_Pais.Location = New System.Drawing.Point(76, 26)
        Me.CbPais_Pais.Name = "CbPais_Pais"
        Me.CbPais_Pais.Size = New System.Drawing.Size(203, 21)
        Me.CbPais_Pais.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "País"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbPais_Depto
        '
        Me.CbPais_Depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPais_Depto.FormattingEnabled = True
        Me.CbPais_Depto.Location = New System.Drawing.Point(76, 53)
        Me.CbPais_Depto.Name = "CbPais_Depto"
        Me.CbPais_Depto.Size = New System.Drawing.Size(203, 21)
        Me.CbPais_Depto.TabIndex = 18
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(27, 88)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(40, 13)
        Me.Label35.TabIndex = 44
        Me.Label35.Text = "Ciudad"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbPais_Ciudad
        '
        Me.CbPais_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPais_Ciudad.FormattingEnabled = True
        Me.CbPais_Ciudad.Location = New System.Drawing.Point(76, 80)
        Me.CbPais_Ciudad.Name = "CbPais_Ciudad"
        Me.CbPais_Ciudad.Size = New System.Drawing.Size(203, 21)
        Me.CbPais_Ciudad.TabIndex = 19
        '
        'TxtLicTransito
        '
        Me.TxtLicTransito.Location = New System.Drawing.Point(307, 5)
        Me.TxtLicTransito.MaxLength = 20
        Me.TxtLicTransito.Name = "TxtLicTransito"
        Me.TxtLicTransito.Size = New System.Drawing.Size(90, 20)
        Me.TxtLicTransito.TabIndex = 157
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "VIN"
        '
        'TxtKmMax
        '
        Me.TxtKmMax.Location = New System.Drawing.Point(578, 237)
        Me.TxtKmMax.Name = "TxtKmMax"
        Me.TxtKmMax.Size = New System.Drawing.Size(65, 20)
        Me.TxtKmMax.TabIndex = 21
        '
        'TxtVIN
        '
        Me.TxtVIN.Location = New System.Drawing.Point(105, 49)
        Me.TxtVIN.MaxLength = 50
        Me.TxtVIN.Name = "TxtVIN"
        Me.TxtVIN.Size = New System.Drawing.Size(90, 20)
        Me.TxtVIN.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(232, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 158
        Me.Label11.Text = "Lic / tránsito"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(232, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Motor"
        '
        'TxtMotor
        '
        Me.TxtMotor.Location = New System.Drawing.Point(307, 27)
        Me.TxtMotor.MaxLength = 50
        Me.TxtMotor.Name = "TxtMotor"
        Me.TxtMotor.Size = New System.Drawing.Size(90, 20)
        Me.TxtMotor.TabIndex = 10
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.Location = New System.Drawing.Point(652, 230)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(110, 13)
        Me.LinkLabel2.TabIndex = 156
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Todos los propietarios"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(232, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Chasis"
        '
        'LblPropietario
        '
        Me.LblPropietario.BackColor = System.Drawing.Color.SeaShell
        Me.LblPropietario.DMSEsProveedor = False
        Me.LblPropietario.DMSLimpiar = False
        Me.LblPropietario.DMSPideContacto = True
        Me.LblPropietario.DMSTituloTercero = "Propietario"
        Me.LblPropietario.DMSVerNit = True
        Me.LblPropietario.Location = New System.Drawing.Point(430, 189)
        Me.LblPropietario.Name = "LblPropietario"
        Me.LblPropietario.Size = New System.Drawing.Size(333, 38)
        Me.LblPropietario.TabIndex = 6
        '
        'TxtChasis
        '
        Me.TxtChasis.Location = New System.Drawing.Point(307, 49)
        Me.TxtChasis.MaxLength = 50
        Me.TxtChasis.Name = "TxtChasis"
        Me.TxtChasis.Size = New System.Drawing.Size(90, 20)
        Me.TxtChasis.TabIndex = 11
        '
        'TxtPresupuestoMaximo
        '
        Me.TxtPresupuestoMaximo.Location = New System.Drawing.Point(629, 95)
        Me.TxtPresupuestoMaximo.Name = "TxtPresupuestoMaximo"
        Me.TxtPresupuestoMaximo.Size = New System.Drawing.Size(111, 20)
        Me.TxtPresupuestoMaximo.TabIndex = 25
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(423, 98)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 13)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Precio inf/sup"
        '
        'TxtPresupuesto
        '
        Me.TxtPresupuesto.Location = New System.Drawing.Point(514, 95)
        Me.TxtPresupuesto.Name = "TxtPresupuesto"
        Me.TxtPresupuesto.Size = New System.Drawing.Size(111, 20)
        Me.TxtPresupuesto.TabIndex = 24
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(423, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Año inf/sup"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtAñoSup
        '
        Me.TxtAñoSup.Location = New System.Drawing.Point(572, 70)
        Me.TxtAñoSup.MaxLength = 4
        Me.TxtAñoSup.Name = "TxtAñoSup"
        Me.TxtAñoSup.Size = New System.Drawing.Size(52, 20)
        Me.TxtAñoSup.TabIndex = 23
        Me.TxtAñoSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtAñoInf
        '
        Me.TxtAñoInf.Location = New System.Drawing.Point(514, 69)
        Me.TxtAñoInf.MaxLength = 4
        Me.TxtAñoInf.Name = "TxtAñoInf"
        Me.TxtAñoInf.Size = New System.Drawing.Size(52, 20)
        Me.TxtAñoInf.TabIndex = 22
        Me.TxtAñoInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblDesModAno
        '
        Me.LblDesModAno.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblDesModAno.Location = New System.Drawing.Point(629, 42)
        Me.LblDesModAno.Name = "LblDesModAno"
        Me.LblDesModAno.Size = New System.Drawing.Size(132, 45)
        Me.LblDesModAno.TabIndex = 66
        Me.LblDesModAno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtModAno
        '
        Me.TxtModAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtModAno.Location = New System.Drawing.Point(514, 42)
        Me.TxtModAno.MaxLength = 20
        Me.TxtModAno.Name = "TxtModAno"
        Me.TxtModAno.Size = New System.Drawing.Size(109, 20)
        Me.TxtModAno.TabIndex = 3
        Me.TxtModAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblIDMod
        '
        Me.LblIDMod.AutoSize = True
        Me.LblIDMod.Location = New System.Drawing.Point(311, 94)
        Me.LblIDMod.Name = "LblIDMod"
        Me.LblIDMod.Size = New System.Drawing.Size(18, 13)
        Me.LblIDMod.TabIndex = 20
        Me.LblIDMod.Text = "ID"
        Me.LblIDMod.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Criterios combinados de Búsqueda de Vehículos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblIDLin
        '
        Me.LblIDLin.AutoSize = True
        Me.LblIDLin.Location = New System.Drawing.Point(311, 70)
        Me.LblIDLin.Name = "LblIDLin"
        Me.LblIDLin.Size = New System.Drawing.Size(18, 13)
        Me.LblIDLin.TabIndex = 19
        Me.LblIDLin.Text = "ID"
        Me.LblIDLin.Visible = False
        '
        'LblIDMarca
        '
        Me.LblIDMarca.AutoSize = True
        Me.LblIDMarca.Location = New System.Drawing.Point(311, 46)
        Me.LblIDMarca.Name = "LblIDMarca"
        Me.LblIDMarca.Size = New System.Drawing.Size(18, 13)
        Me.LblIDMarca.TabIndex = 18
        Me.LblIDMarca.Text = "ID"
        Me.LblIDMarca.Visible = False
        '
        'CmdBuscar
        '
        Me.CmdBuscar.BackColor = System.Drawing.Color.White
        Me.CmdBuscar.BackgroundImage = CType(resources.GetObject("CmdBuscar.BackgroundImage"), System.Drawing.Image)
        Me.CmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdBuscar.ForeColor = System.Drawing.Color.White
        Me.CmdBuscar.Location = New System.Drawing.Point(203, 152)
        Me.CmdBuscar.Name = "CmdBuscar"
        Me.CmdBuscar.Size = New System.Drawing.Size(200, 39)
        Me.CmdBuscar.TabIndex = 26
        Me.CmdBuscar.Text = "Buscar"
        Me.CmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdBuscar.UseVisualStyleBackColor = False
        '
        'CbMarca
        '
        Me.CbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMarca.ForeColor = System.Drawing.Color.Black
        Me.CbMarca.FormattingEnabled = True
        Me.CbMarca.Location = New System.Drawing.Point(109, 42)
        Me.CbMarca.Name = "CbMarca"
        Me.CbMarca.Size = New System.Drawing.Size(196, 21)
        Me.CbMarca.TabIndex = 0
        '
        'CbModelo
        '
        Me.CbModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CbModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbModelo.ForeColor = System.Drawing.Color.Black
        Me.CbModelo.FormattingEnabled = True
        Me.CbModelo.Location = New System.Drawing.Point(109, 90)
        Me.CbModelo.Name = "CbModelo"
        Me.CbModelo.Size = New System.Drawing.Size(196, 21)
        Me.CbModelo.TabIndex = 2
        '
        'CbLinea
        '
        Me.CbLinea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CbLinea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbLinea.ForeColor = System.Drawing.Color.Black
        Me.CbLinea.FormattingEnabled = True
        Me.CbLinea.Location = New System.Drawing.Point(109, 66)
        Me.CbLinea.Name = "CbLinea"
        Me.CbLinea.Size = New System.Drawing.Size(196, 21)
        Me.CbLinea.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Línea"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Modelo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TbVins
        '
        Me.TbVins.Controls.Add(Me.LnkCols)
        Me.TbVins.Controls.Add(Me.GrdSeriales)
        Me.TbVins.Location = New System.Drawing.Point(4, 22)
        Me.TbVins.Name = "TbVins"
        Me.TbVins.Size = New System.Drawing.Size(776, 502)
        Me.TbVins.TabIndex = 2
        Me.TbVins.Text = "VIN encontradas"
        Me.TbVins.UseVisualStyleBackColor = True
        '
        'LnkCols
        '
        Me.LnkCols.AutoSize = True
        Me.LnkCols.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkCols.Location = New System.Drawing.Point(8, 11)
        Me.LnkCols.Name = "LnkCols"
        Me.LnkCols.Size = New System.Drawing.Size(53, 13)
        Me.LnkCols.TabIndex = 101
        Me.LnkCols.TabStop = True
        Me.LnkCols.Text = "Columnas"
        '
        'GrdSeriales
        '
        Me.GrdSeriales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSeriales.DMSCopiarDt = True
        Me.GrdSeriales.DMSTituloDelInforme = ""
        Me.GrdSeriales.Location = New System.Drawing.Point(6, 35)
        Me.GrdSeriales.Name = "GrdSeriales"
        Me.GrdSeriales.Size = New System.Drawing.Size(766, 462)
        Me.GrdSeriales.TabIndex = 100
        '
        'LnkNueva
        '
        Me.LnkNueva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LnkNueva.AutoSize = True
        Me.LnkNueva.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkNueva.Location = New System.Drawing.Point(650, 5)
        Me.LnkNueva.Name = "LnkNueva"
        Me.LnkNueva.Size = New System.Drawing.Size(89, 13)
        Me.LnkNueva.TabIndex = 168
        Me.LnkNueva.TabStop = True
        Me.LnkNueva.Text = "Nueva búsqueda"
        '
        'fBusVeh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 528)
        Me.Controls.Add(Me.LnkNueva)
        Me.Controls.Add(Me.TabControl1)
        Me.MinimumSize = New System.Drawing.Size(771, 567)
        Me.Name = "fBusVeh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda de vehículos"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.LnkNueva, 0)
        Me.Controls.SetChildIndex(Me.PicPuntoAdv, 0)
        CType(Me.PicPuntoAdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TbBuscar.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PnlVeh.ResumeLayout(False)
        Me.PnlVeh.PerformLayout()
        Me.PnlRangoFechas.ResumeLayout(False)
        Me.PnlRangoFechas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TbVins.ResumeLayout(False)
        Me.TbVins.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TbBuscar As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdBuscar As SMDPpal.BotonEstandar
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtPlaca As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CbColor_interno As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CbServicio As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CbClase As System.Windows.Forms.ComboBox
    Friend WithEvents TxtKmMax As System.Windows.Forms.TextBox
    Friend WithEvents TxtKmMin As System.Windows.Forms.TextBox
    Friend WithEvents LblKim As System.Windows.Forms.Label
    Friend WithEvents TxtPresupuestoMaximo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CbColor_externo As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TxtPresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LblIDMod As System.Windows.Forms.Label
    Friend WithEvents LblIDLin As System.Windows.Forms.Label
    Friend WithEvents LblIDMarca As System.Windows.Forms.Label
    Friend WithEvents CbMarca As System.Windows.Forms.ComboBox
    Friend WithEvents CbModelo As System.Windows.Forms.ComboBox
    Friend WithEvents CbLinea As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TbVins As System.Windows.Forms.TabPage
    Friend WithEvents GrdSeriales As SMDPpal.GridDms
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents CbPais_Ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents CbPais_Depto As System.Windows.Forms.ComboBox
    Friend WithEvents CbPais_Pais As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAñoSup As System.Windows.Forms.TextBox
    Friend WithEvents TxtAñoInf As System.Windows.Forms.TextBox
    Friend WithEvents CbNuevo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblDesModAno As System.Windows.Forms.Label
    Friend WithEvents TxtModAno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtChasis As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtMotor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtVIN As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Public WithEvents LblPropietario As SMDPpal.LblCliente
    Friend WithEvents TxtLicTransito As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Public WithEvents LblAseguradora As SMDPpal.LblCliente
    Friend WithEvents ChkFechaVence As System.Windows.Forms.CheckBox
    Friend WithEvents PnlRangoFechas As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtFecSup As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtFecInf As System.Windows.Forms.DateTimePicker
    Friend WithEvents CbStock As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PnlVeh As System.Windows.Forms.Panel
    Friend WithEvents ChkBuscarVIN As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTotales As System.Windows.Forms.CheckBox
    Friend WithEvents LnkCols As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkNueva As System.Windows.Forms.LinkLabel
    Friend WithEvents ChkVacios As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkMarca As System.Windows.Forms.LinkLabel
    Public WithEvents CbBod As ComboDMS
    Friend WithEvents Label4 As Label
End Class
