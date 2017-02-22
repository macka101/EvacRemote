Imports System.Drawing.Printing
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports Esso.Data
Imports NonPersistedViews

Public Class xptSurveyProducts
    Dim _session As New UnitOfWork

    Private Sub xptSurveyQuote_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Dim filter As CriteriaOperator
        filter = CriteriaOperator.Parse("Oid = ? ", Me.SurveyId.Value)
        Dim pSurvey As New XPCollection(Of EvacSurvey)(_session, filter)
        DataSource = pSurvey

        Dim pProducts As New XPCollection(Of SurveyProducts)(_session, filter)
        Me.DetailReport.DataSource = pProducts

    End Sub
End Class