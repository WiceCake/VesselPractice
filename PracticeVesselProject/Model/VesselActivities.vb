Public Class VesselActivities
    Public vessel_activities_id, activity_id, vessel_id As Integer
    Public longitude, latitude As Decimal
    Public description, location As String
    Public date_activity, date_created, date_updated As Date?

    Private dc As dbActivitiesDataContext

    Sub New(ByRef dc_ As dbActivitiesDataContext)
        dc = dc_
    End Sub

    Sub New(ByVal vessel_act_id_ As Integer, ByRef dc_ As dbActivitiesDataContext)
        dc = dc_

        Dim e = From i In dc.tbl_vessel_activities Where i.vessel_act_id = vessel_act_id_ Select i

        For Each i In e
            Me.vessel_activities_id = vessel_act_id_
            vessel_id = CInt(i.vessel_id)
            activity_id = CInt(i.activity_id)
            location = i.location
            longitude = CDec(i.longitude)
            latitude = CDec(i.latitude)
            description = i.description
            date_activity = CDate(i.date_activity)
            date_created = CDate(i.date_created)
            date_updated = CDate(i.date_updated)
        Next
    End Sub

    Sub New(ByVal tva As tbl_vessel_activity, ByRef dc_ As dbActivitiesDataContext)
        dc = dc_

        Dim i = tva

        Me.vessel_activities_id = i.vessel_act_id
        vessel_id = CInt(i.vessel_id)
        activity_id = CInt(i.activity_id)
        location = i.location
        longitude = CDec(i.longitude)
        latitude = CDec(i.latitude)
        description = i.description
        date_activity = CDate(i.date_activity)
        date_created = CDate(i.date_created)
        date_updated = CDate(i.date_updated)
    End Sub

    Sub Add()
        Dim va As New tbl_vessel_activity

        With va
            .vessel_id = vessel_id
            .activity_id = activity_id
            .location = location
            .latitude = latitude
            .longitude = longitude
            .description = description
            .date_activity = date_activity
        End With

        dc.tbl_vessel_activities.InsertOnSubmit(va)
        dc.SubmitChanges()
        vessel_activities_id = va.vessel_act_id
    End Sub

    Sub Save()
        Dim va = From i In dc.tbl_vessel_activities Where i.vessel_act_id = vessel_activities_id Select i

        For Each i In va
            i.vessel_id = vessel_id
            i.activity_id = activity_id
            i.location = location
            i.latitude = latitude
            i.longitude = longitude
            i.description = description
            i.date_activity = date_activity
            dc.SubmitChanges()
        Next
    End Sub

    Function GetByDate(Optional ByVal startDate As Date = #1/1/1900#, Optional ByVal endDate As Date = Nothing) As List(Of VesselActivities)
        If endDate = Nothing Then
            endDate = Date.Now
        End If

        Dim vaList As New List(Of VesselActivities)

        Dim acts = From va In dc.tbl_vessel_activities
                   Where va.date_activity >= startDate.Date AndAlso va.date_activity <= endDate.Date
                   Select va

        For Each act In acts
            vaList.Add(New VesselActivities(act, dc))
        Next

        Return vaList
    End Function

    Function GetVessel(ByVal vs As List(Of tbl_vessel)) As tbl_vessel
        Return (From i In vs Where i.vessel_id = vessel_id Select i).FirstOrDefault()
    End Function

    Function GetActivity(ByVal vs As List(Of tbl_activity)) As tbl_activity
        Return (From i In vs Where i.activity_id = activity_id Select i).FirstOrDefault()
    End Function

End Class
