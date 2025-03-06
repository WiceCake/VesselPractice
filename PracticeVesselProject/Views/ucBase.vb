Public Class ucBase
    Public title As String
    Public indexField As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        refreshData()
    End Sub

    Private Sub GridControl1_Load(sender As Object, e As EventArgs) Handles GridControl1.Load
        refreshData()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        refreshData()
    End Sub

    Private Sub GridControl1_MouseDoubleClick(sender As Object, e As EventArgs) Handles GridControl1.MouseDoubleClick
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(GridControl1.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)

        If view Is Nothing Then
            view = TryCast(GridControl1.FocusedView, DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)
        End If

        If view.SelectedRowsCount > 0 Then
            Dim retVal As Integer = CInt(view.GetRowCellValue(view.FocusedRowHandle, indexField))
            LoadRecord(retVal)
        End If
    End Sub

    Overridable Sub refreshData()

    End Sub

    Overridable Sub LoadRecord(ByVal recordID As Integer)

    End Sub
End Class
