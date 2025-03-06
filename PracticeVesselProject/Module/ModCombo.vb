Module ModCombo

    Public Sub setComboBox(ByRef cmb As DevExpress.XtraEditors.LookUpEdit, ByVal dataSource As Object, _
                           Optional ByVal column_id_name As String = Nothing, _
                           Optional ByVal column_name As String = Nothing)
        With cmb.Properties
            .DataSource = dataSource
            .DisplayMember = column_name
            .ValueMember = column_id_name
            .NullText = ""

            .Columns.Clear()
            .Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(column_name, column_name.Replace("_", " ")))
            .ShowHeader = False
            .ShowFooter = False
            .PopupWidth = cmb.Width
        End With
    End Sub

    Public Sub loadComboLocation(ByRef cmb As DevExpress.XtraEditors.ComboBoxEdit)
        cmb.Properties.Items.Add("Manila Port")
        cmb.Properties.Items.Add("Cebu Harbor")
        cmb.Properties.Items.Add("Davao Dockyard")
    End Sub

    Public Sub loadComboVessel(ByRef cmb As DevExpress.XtraEditors.LookUpEdit)
        Dim dc As New dbActivitiesDataContext

        Dim v = (From i In dc.tbl_vessels Select i.vessel_id, i.vessel_name).ToList()

        setComboBox(cmb, v, "vessel_id", "vessel_name")
    End Sub

    Public Sub loadComboActivities(ByRef cmb As DevExpress.XtraEditors.LookUpEdit)
        Dim dc As New dbActivitiesDataContext

        Dim v = (From i In dc.tbl_activities Select i.activity_id, i.activity_name).ToList()

        setComboBox(cmb, v, "activity_id", "activity_name")
    End Sub
End Module
