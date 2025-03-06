Public Class Activities
    Public activity_id As Integer
    Public activity_name As String
    Public date_created As Date?

    Private dc As dbActivitiesDataContext

    Sub New(ByRef dc_ As dbActivitiesDataContext)
        dc = dc_
    End Sub

    Sub New(ByVal activity_id_ As Integer, ByRef dc_ As dbActivitiesDataContext)
        dc = dc_

        Dim e = From i In dc.tbl_activities Where i.activity_id = activity_id_ Select i

        For Each i In e
            Me.activity_id = activity_id_
            activity_name = i.activity_name
            date_created = CDate(i.date_created)
        Next
    End Sub
End Class
