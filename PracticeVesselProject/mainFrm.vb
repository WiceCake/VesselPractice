Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTab

Partial Public Class mainFrm
    Public ucList As New List(Of UserControl)

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub addTab(ByVal uc As UserControl, ByVal title As String)
        ucList.Add(uc)
        xtratab.TabPages.Add(title)
        uc.Parent = xtratab.TabPages(xtratab.TabPages.Count - 1)
        uc.Dock = DockStyle.Fill
        xtratab.TabPages(ucList.IndexOf(uc)).Show()
    End Sub

    Private Function inTabs(ByVal type As String) As Integer
        For i As Integer = 0 To ucList.Count - 1
            If ucList(i).GetType().Name = type Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim ctrl = New ctrlActivities()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim title = "Vessel Activities"
        Dim inTab = inTabs("ucAct")
        If inTab = -1 Then
            Dim uc As New ucAct(title)
            addTab(uc, title)
        Else
            xtratab.TabPages(inTab).Show()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim title = "Activity Reports"
        Dim inTab = inTabs("ucActR")
        If inTab = -1 Then
            Dim uc As New ucActR(title)
            addTab(uc, title)
        Else
            xtratab.TabPages(inTab).Show()
        End If
    End Sub

    Private Sub xtratab_CloseButtonClick(sender As Object, e As EventArgs) Handles xtratab.CloseButtonClick
        Dim arg As ClosePageButtonEventArgs = TryCast(e, ClosePageButtonEventArgs)
        TryCast(arg.Page, XtraTabPage).PageVisible = False
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim ctrl As New ctrlReports()
    End Sub
End Class
