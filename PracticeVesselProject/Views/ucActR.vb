Imports DevExpress.XtraGrid
Imports DevExpress.XtraPivotGrid

Public Class ucActR
    Inherits ucBase

    Private pv As PivotGridControl

    Sub New(ByVal title As String)

        InitializeComponent()

        MyBase.title = title
        LabelControl1.Text = title

        RemoveLayout()
        ConvertToPivotGrid()
    End Sub

    Private Sub RemoveLayout()

        LayoutControl1.Remove(LayoutControlItem2, True)
        LayoutControl1.Remove(LayoutControlItem4, True)
        LayoutControl1.Remove(LayoutControlItem3, True)

    End Sub


    Private Sub ConvertToPivotGrid()

        If GridControl1 IsNot Nothing Then

            LayoutControl1.Remove(LayoutControlItem5, True)

            pv = New PivotGridControl() With {
                .DataSource = GetVesselActivitiesData()
            }

            pv.OptionsView.ShowColumnGrandTotals = False
            pv.OptionsView.ShowRowGrandTotals = False

            Dim fAct As New PivotGridField("Activities", PivotArea.RowArea)
            Dim fVes As New PivotGridField("Vessels", PivotArea.ColumnArea)
            Dim fCount As New PivotGridField("VesselAct", PivotArea.DataArea) With {
                .SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
            }

            pv.Fields.AddRange(New PivotGridField() {fAct, fVes, fCount})

            LayoutControl1.AddItem("test", pv)
            LayoutControlItem6.Height = 30
            LayoutControl1.Refresh()

            AddHandler pv.CustomCellDisplayText, AddressOf Pivot_CustomCellDisplayText
        End If
    End Sub

    Private Function GetVesselActivitiesData() As IEnumerable(Of Object)
        Dim dc = New dbActivitiesDataContext
        Dim va = New VesselActivities(dc).GetRows()
        Dim vessels = dc.tbl_vessels.ToList()
        Dim activities = dc.tbl_activities.ToList()

        Return (From i In va
                Select New With {
                    i.vessel_activities_id,
                    .Vessels = i.GetVessel(vessels).vessel_name,
                    .Activities = i.GetActivity(activities).activity_name,
                    .VesselAct = i.vessel_activities_id
                }).ToList()
    End Function


    Public Overrides Sub refreshData()
        pv.DataSource = GetVesselActivitiesData()
    End Sub

    Private Sub Pivot_CustomCellDisplayText(sender As Object, e As PivotCellDisplayTextEventArgs)
        If e.Value Is Nothing OrElse IsDBNull(e.Value) Then
            e.DisplayText = "0"
        End If
    End Sub
End Class
