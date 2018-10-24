' Version: 678, 16-ago.-2018 14:15
'♥ versión: 586, 6-oct.-2017 07:11
Imports CrystalDecisions.CrystalReports.Engine

Public Class fCrystal
    Public Rsr As ReportDocument
    Dim Pintado As Integer = 0
    Public dms_Localizacion As New Point(0, 0)
    Public dms_Size As New Point(0, 0)


    Private Sub fCrystal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If SoyHandHeld() Then
            Me.FormBorderStyle = Forms.FormBorderStyle.FixedToolWindow
            Me.WindowState = FormWindowState.Maximized
        End If

        CrystalReportViewer1.ReportSource = Rsr
        'CrystalReportViewer1.PrintReport()

        'para que quede del mismo tamaño que la forma llamadora
        If FormaOrigenVentaCrystal IsNot Nothing Then
            Me.Location = FormaOrigenVentaCrystal.Location
            Me.Size = FormaOrigenVentaCrystal.Size
            FormaOrigenVentaCrystal = Nothing
        End If


        Me.TopMost = False
        PnlEspere.BringToFront()

        HagaEventos()

        'Timer1.Start()

    End Sub
    Public Sub Imprimalo(Optional Impresora As Integer = 1)
        'antes de 2013-01-06
        'CrystalReportViewer1.ReportSource = Rsr
        'CrystalReportViewer1.PrintReport()

        'despues de 2013-01-06
        'CrystalReportViewer1.ReportSource = Rsr
        Dim dialog As New PrintDialog
        'dialog.UseEXDialog = True
        'dialog.AllowSomePages = True

        'Dim objRpt As ReportDocument = CType(Me.CrystalReportViewer1.ReportSource, ReportDocument)
        Dim objRpt As ReportDocument = CType(Rsr, ReportDocument)
		'objRpt.PrintOptions.PrinterName = dialog.PrinterSettings.PrinterName
		'Static Nombre As String
		'If Nombre Is Nothing Then
		'    Nombre = GetSett("Impresora", "nombre", dialog.PrinterSettings.PrinterName)
		'    Nombre = InputBox2("Nombre de la Impresora:", , Nombre)
		'    SaveSett("Impresora", "nombre", Nombre)
		'End If

		Dim Prt As String = GetSetting("DMS S.A.", "fC", "prt" & Impresora.ToString, "")
        objRpt.PrintOptions.PrinterName = IIf(Prt = "", dialog.PrinterSettings.PrinterName, Prt)
        objRpt.PrintToPrinter(1, False, 0, 0)



    End Sub

    'Private Sub CrystalReportViewer1_Layout(sender As Object, e As System.Windows.Forms.LayoutEventArgs) Handles CrystalReportViewer1.Layout
    '    DebugJD("CrystalReportViewer1_Layout")

    'End Sub

    'Private Sub CrystalReportViewer1_Load(sender As Object, e As System.EventArgs) Handles CrystalReportViewer1.Load
    '    DebugJD("CrystalReportViewer1_Load")

    'End Sub

    Private Sub CrystalReportViewer1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles CrystalReportViewer1.Paint
        Pintado += 1
        DebugJD("CrystalReportViewer1_Paint: " & Pintado.ToString)

        If Pintado > 1 Then
            PnlEspere.Visible = False
        End If
    End Sub
    'Private Sub CrystalReportViewer1_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer1.VisibleChanged
    '    Dim i = 1

    'End Sub

    'Private Sub CrystalReportViewer1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles CrystalReportViewer1.Paint
    '    PnlEspere.Visible = False

    'End Sub

    'Private Sub CrystalReportViewer1_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer1.VisibleChanged
    '    DebugJD("CrystalReportViewer1_VisibleChanged")
    '    PnlEspere.Visible = False

    'End Sub

End Class