Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraReports.UI.PivotGrid
Imports Esso.Data

Public Class rptSurveyProductsPivot
    Dim _session As New UnitOfWork


    Private Sub XpCollection1_ResolveSession(sender As Object, e As ResolveSessionEventArgs)
    End Sub

    Private Sub rptSurveyPivot_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint

    End Sub
End Class