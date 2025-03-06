﻿Imports System.ComponentModel
Imports System.Text


Partial Public Class mainFrm
    Public ucList As New List(Of UserControl)

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub addTab(ByVal uc As UserControl, ByVal title As String)
        ucList.Add(uc)
        xtratab.TabPages.Add(title)
        uc.Parent = xtratab.TabPages(xtratab.TabPages.Count - 1)
        uc.Dock = DockStyle.Fill
        xtratab.TabPages(ucList.IndexOf(uc)).Show()
    End Sub

    Private Function inTabs(ByVal type As String) As Integer
        If ucList.Count = 0 Then
            Return -1
        End If

        Dim thisTab = ucList.Where(Function(x) x.GetType().ToString = "DIC." + type)
        If thisTab.Count = 0 Then
            Return -1
        End If

        Return ucList.IndexOf(thisTab.First)
    End Function

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim ctrl = New ctrlActivities()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim title = "Vessel Activities"
        Dim inTab = inTabs("ucAct")
        If inTab = -1 Then
            Dim uc As New ucAct(title)
            addTab(uc, title)
        Else
            xtratab.TabPages(inTab).Show()
        End If
    End Sub
End Class
