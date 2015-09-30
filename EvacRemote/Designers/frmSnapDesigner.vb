Imports DevExpress.Xpo


Public Class frmSnapDesigner

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked

        For Each oDb In Me.SnapControl1.Document.DataSources
            If oDb.DataSourceName = "EvacService" Then
                Exit Sub
            End If
        Next
        Dim session As New Session()
        Dim EvacService As XPCollection(Of EvacService) = New XPCollection(Of EvacService)(session)

        Me.SnapControl1.Document.BeginUpdateDataSource()
        Me.SnapControl1.Document.DataSources.Add("EvacService", EvacService)
        Me.SnapControl1.Document.EndUpdateDataSource()

    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        For Each oDb In Me.SnapControl1.Document.DataSources
            If oDb.DataSourceName = "IbexService" Then
                Exit Sub
            End If
        Next

        Dim session As New Session()
        Dim IbexService As XPCollection(Of IbexService) = New XPCollection(Of IbexService)(session)

        Me.SnapControl1.Document.BeginUpdateDataSource()
        Me.SnapControl1.Document.DataSources.Add("IbexService", IbexService)
        Me.SnapControl1.Document.EndUpdateDataSource()

    End Sub
End Class