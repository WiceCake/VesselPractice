Public Class ucBase
    Public title As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        refreshData()
    End Sub


    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        refreshData()
    End Sub

    Overridable Sub refreshData()

    End Sub

End Class
