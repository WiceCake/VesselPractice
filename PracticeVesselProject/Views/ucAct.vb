Imports System.Text

Public Class ucAct
    Inherits ucBase

    Sub New(ByVal title As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MyBase.title = title
        MyBase.indexField = "vessel_activities_id"
        LabelControl1.Text = title
    End Sub

    Public Overrides Sub refreshData()


        Dim dc As New dbActivitiesDataContext

        Dim bv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView = TryCast(GridControl1.MainView, DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)

        Dim va = New VesselActivities(dc).GetByDate(CDate(dFrom.EditValue), CDate(dTo.EditValue))
        Dim vess = (From v In dc.tbl_vessels Select v).ToList()
        Dim act = (From v In dc.tbl_activities Select v).ToList()

        If bv Is Nothing Then
            bv = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
            GridControl1.MainView = bv
        End If

        GridControl1.ForceInitialize()

        Dim vaq = From i In va
                  Select i.vessel_activities_id,
                        ID = i.vessel_activities_id,
                        ActivityName = i.GetActivity(act).activity_name,
                        DateActivity = i.date_activity,
                        Location = i.location,
                        Latitude = i.latitude,
                        Longitude = i.longitude,
                        VesselName = i.GetVessel(vess).vessel_name,
                        Description = i.description

        GridControl1.DataSource = vaq

        editGrid(bv)

    End Sub

    Public Overrides Sub LoadRecord(ByVal recordID As Integer)
        Dim ca As New ctrlActivities(recordID)
        refreshData()
    End Sub

    Sub editGrid(bandedView As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)

        bandedView.PopulateColumns()
        bandedView.RefreshData()
        bandedView.ClearGrouping()
        bandedView.Bands.Clear()

        Dim activityBand = New DevExpress.XtraGrid.Views.BandedGrid.GridBand With {.Caption = "Activities"}
        Dim locationBand = New DevExpress.XtraGrid.Views.BandedGrid.GridBand With {.Caption = "Location & Coordinates"}
        Dim otherBand = New DevExpress.XtraGrid.Views.BandedGrid.GridBand With {.Caption = "Other Information"}

        AddToBand(bandedView, activityBand, "ID", "ID")
        AddToBand(bandedView, activityBand, "ActivityName", "Activity Name")
        AddToBand(bandedView, activityBand, "DateActivity", "Date of Activity")
        AddToBand(bandedView, locationBand, "Location", "Location")
        AddToBand(bandedView, locationBand, "Latitude", "Latitude")
        AddToBand(bandedView, locationBand, "Longitude", "Longitude")
        AddToBand(bandedView, otherBand, "VesselName", "Vessel Name")
        AddToBand(bandedView, otherBand, "Description", "Description")

        For Each col As DevExpress.XtraGrid.Columns.GridColumn In bandedView.Columns
            col.Visible = True
        Next

        bandedView.Bands.AddRange({activityBand, locationBand, otherBand})

        bandedView.ExpandAllGroups()
        bandedView.BestFitColumns()
        bandedView.OptionsBehavior.Editable = False
        bandedView.OptionsSelection.EnableAppearanceFocusedRow = True
    End Sub

    Sub AddToBand(ByRef view As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView,
                  ByRef band As DevExpress.XtraGrid.Views.BandedGrid.GridBand,
                  ByVal fieldName As String, ByVal caption As String)
        Dim col As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn = TryCast(view.Columns(fieldName), DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn)

        If col IsNot Nothing Then
            col.Caption = caption
            band.Columns.Add(col)
        End If
    End Sub

End Class
