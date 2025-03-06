Imports System.Transactions

Public Class ctrlActivities

    Private isNew As Boolean
    Private mdlAct As Activities
    Private mdlVes As Vessels
    Private mdlVesAct As VesselActivities

    Private frmAA As frmActivity

    Private dc As dbActivitiesDataContext

    Sub New()
        isNew = True

        dc = New dbActivitiesDataContext
        mdlAct = New Activities(dc)
        mdlVes = New Vessels(dc)
        mdlVesAct = New VesselActivities(dc)

        frmAA = New frmActivity(Me)

        loadCombos()

        With frmAA
            .action = "Created"
            .Show()
        End With
    End Sub

    Sub New(ByVal id As Integer)
        isNew = False

        dc = New dbActivitiesDataContext
        mdlVesAct = New VesselActivities(id, dc)

        mdlAct = New Activities(mdlVesAct.activity_id, dc)
        mdlVes = New Vessels(mdlVesAct.vessel_id, dc)

        frmAA = New frmActivity(Me)

        loadCombos()

        With frmAA
            .dateAct.EditValue = mdlVesAct.date_activity
            .lueVessel.EditValue = mdlVes.vessel_id
            .cbLoc.EditValue = mdlVesAct.location
            .lueAct.EditValue = mdlAct.activity_id
            .txtLat.Value = mdlVesAct.latitude
            .txtLong.Value = mdlVesAct.longitude
            .txtDec.Text = mdlVesAct.description
            .Text = "Save Info"
            .LabelControl1.Text = "Save Info"
            .btnCreate.Text = "Save"
            .action = "Saved"
            .Show()
        End With
    End Sub

    Sub Save()
        Using ts As New TransactionScope()
            Try
                With mdlVesAct
                    .activity_id = CInt(frmAA.lueAct.EditValue)
                    .vessel_id = CInt(frmAA.lueVessel.EditValue)
                    .location = frmAA.cbLoc.Text
                    .date_activity = CDate(frmAA.dateAct.EditValue)
                    .longitude = CDec(frmAA.txtLong.EditValue)
                    .latitude = CDec(frmAA.txtLat.EditValue)
                    .description = frmAA.txtDec.Text
                    If isNew Then
                        .Add()
                    Else
                        .Save()
                    End If
                End With

                ts.Complete()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Sub loadCombos()
        loadComboVessel(frmAA.lueVessel)
        loadComboActivities(frmAA.lueAct)
        loadComboLocation(frmAA.cbLoc)
    End Sub
End Class
