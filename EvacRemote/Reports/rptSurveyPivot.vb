Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports Esso.Data

Public Class rptSurveyPivot
    Dim _session As New UnitOfWork

    Private Sub Detail_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Detail.BeforePrint
        Dim filter As CriteriaOperator
        filter = CriteriaOperator.Parse("Oid = ? ", Me.SurveyId.Value)
        Dim pSurvey As New XPCollection(Of EvacSurvey)(_session, filter)
        DataSource = pSurvey
    End Sub

    Private Sub XpCollection1_ResolveSession(sender As Object, e As ResolveSessionEventArgs) Handles XpCollection1.ResolveSession
        e.Session = _session
    End Sub
End Class