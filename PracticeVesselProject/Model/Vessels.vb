Public Class Vessels
    Public vessel_id As Integer
    Public vessel_name, vessel_class As String
    Public date_created As Date?

    Private dc As dbActivitiesDataContext

    Sub New(ByRef dc_ As dbActivitiesDataContext)
        dc = dc_
    End Sub

    Sub New(ByVal vessel_id_ As Integer, ByRef dc_ As dbActivitiesDataContext)
        dc = dc_

        Dim e = From i In dc.tbl_vessels Where i.vessel_id = vessel_id_ Select i

        For Each i In e
            Me.vessel_id = vessel_id_
            vessel_class = i.vessel_class
            vessel_name = i.vessel_name
            date_created = CDate(i.date_created)
        Next
    End Sub
End Class
