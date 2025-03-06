Imports System.Transactions

Public Class ctrlActivities

    Private isNew As Boolean
    Private mdlAct As Activities
    Private mdlVes As Vessels
    Private mdlVesAct As VesselActivities

    Private frmAA As frmAddActivity

    Private dc As dbActivitiesDataContext

    Sub New()
        isNew = True

        dc = New dbActivitiesDataContext
        mdlAct = New Activities(dc)
        mdlVes = New Vessels(dc)
        mdlVesAct = New VesselActivities(dc)

        frmAA = New frmAddActivity(Me)

        loadCombos()

        With frmAA
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
                    .date_created = Date.Now()
                    .date_updated = Date.Now()
                    .Add()
                End With

                ts.Complete()
            Catch ex As Exception
                MessageBox.Show("Error: ", ex.Message)
            End Try
        End Using
    End Sub

    Sub loadCombos()
        loadComboVessel(frmAA.lueVessel)
        loadComboActivities(frmAA.lueAct)
        loadComboLocation(frmAA.cbLoc)
    End Sub
End Class
