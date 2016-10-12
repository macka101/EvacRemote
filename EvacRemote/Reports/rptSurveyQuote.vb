Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports Esso.Data

Public Class rptSurveyQuote
    Dim _session As New UnitOfWork

    Private Sub rptSurveyQuote_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint

        Dim filter As CriteriaOperator
        filter = CriteriaOperator.Parse("Oid = ? ", Me.SurveyId.Value)
        Dim pSurvey As New XPCollection(Of EvacSurvey)(_session, filter)
        DataSource = pSurvey

    End Sub
End Class