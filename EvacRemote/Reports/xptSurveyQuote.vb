Imports System.Drawing.Printing
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports Esso.Data

Public Class xptSurveyQuote
    Dim _session As New UnitOfWork

    Private Sub xptSurveyQuote_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Dim filter As CriteriaOperator
        filter = CriteriaOperator.Parse("Oid = ? ", Me.SurveyId.Value)
        Dim pSurvey As New XPCollection(Of EvacSurvey)(_session, filter)
        DataSource = pSurvey
    End Sub
End Class