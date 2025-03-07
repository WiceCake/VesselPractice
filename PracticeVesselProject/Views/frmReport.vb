Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks

Public Class frmReport

    Private ctrlR As ctrlReports

    Sub New(ByRef ctrl As ctrlReports)

        InitializeComponent()

        ctrlR = ctrl
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ' Create a new printing system and link
        Dim printSystem As New PrintingSystem()
        Dim printLink As New PrintableComponentLink(printSystem)

        ' Assign the GridControl to be printed
        printLink.Component = GridControl1

        ' Set print settings
        printLink.PaperKind = System.Drawing.Printing.PaperKind.A4 ' Set paper size
        printLink.Landscape = True ' Set to landscape mode

        ' Add a big title before the grid
        AddHandler printLink.CreateReportHeaderArea, AddressOf PrintBigTitle

        ' Generate document and show preview
        printLink.CreateDocument()
        printLink.ShowPreview()
    End Sub

    Private Sub PrintBigTitle(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs)
        Dim brick As DevExpress.XtraPrinting.TextBrick
        brick = e.Graph.DrawString("My Report", Color.Navy, New RectangleF(0, 0, 500, 100), DevExpress.XtraPrinting.BorderSide.None)
        brick.Font = New Font("Arial", 60)
    End Sub




End Class