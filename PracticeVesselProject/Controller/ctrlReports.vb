Public Class ctrlReports

    Public mdlAct As Activities
    Public mdlVes As Vessels
    Public mdlVesAct As VesselActivities
    Public frmRep As frmReport

    Private dc As dbActivitiesDataContext

    Sub New()

        dc = New dbActivitiesDataContext

        mdlAct = New Activities(dc)
        mdlVes = New Vessels(dc)
        mdlVesAct = New VesselActivities(dc)

        frmRep = New frmReport(Me)

        populateGrid()

        With frmRep
            hideColumns(.GridView1)
            .GridView1.ShowCustomization()
            .Show()
        End With
    End Sub

    Sub hideColumns(ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
        For Each col As DevExpress.XtraGrid.Columns.GridColumn In gridView.Columns
            col.Visible = False
        Next
    End Sub

    Sub populateGrid()

        Dim va = New VesselActivities(dc).GetRows()
        Dim vess = (From v In dc.tbl_vessels Select v).ToList()
        Dim act = (From v In dc.tbl_activities Select v).ToList()

        Dim vaq = From i In va
                  Select ControlID = i.vessel_activities_id,
                        ActivityName = i.GetActivity(act).activity_name,
                        DateActivity = i.date_activity,
                        Location = i.location,
                        Latitude = i.latitude,
                        Longitude = i.longitude,
                        VesselName = i.GetVessel(vess).vessel_name,
                        Description = i.description

        frmRep.GridControl1.DataSource = vaq

    End Sub
End Class
