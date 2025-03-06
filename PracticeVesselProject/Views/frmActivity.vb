Imports DevExpress.XtraEditors
Imports System.Text
Public Class frmActivity
    Private ctrlA As ctrlActivities
    Public action As String

    Sub New(ByRef ctrl As ctrlActivities)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ctrlA = ctrl
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim actDate = validateField(dateAct)
        Dim vessel = validateField(lueVessel)
        Dim activity = validateField(lueAct)
        Dim location = validateField(cbLoc)
        Dim latitude = validateField(txtLat)
        Dim longitude = validateField(txtLong)

        If actDate AndAlso vessel AndAlso activity AndAlso location AndAlso latitude AndAlso _
            longitude Then
            ctrlA.Save()
            successCreateMessage(action)
            Me.Close()
        Else
            Dim builder As New StringBuilder
            If Not actDate Then builder.Append("Activity Date").AppendLine()
            If Not vessel Then builder.Append("Vessel").AppendLine()
            If Not activity Then builder.Append("Activity").AppendLine()
            If Not location Then builder.Append("Location").AppendLine()
            If Not latitude Then builder.Append("Latitude").AppendLine()
            If Not longitude Then builder.Append("Longitude").AppendLine()
            Dim fields As String = builder.ToString()
            requiredMessage(fields)
        End If
    End Sub
End Class