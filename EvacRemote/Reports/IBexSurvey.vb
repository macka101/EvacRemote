Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class IBexSurvey
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal dataSession As UnitOfWork, pOid As Integer)
        Me.New()
        InitData(dataSession, pOid)
    End Sub
    Private Sub InitData(ByVal dataSession As UnitOfWork, pOid As Integer)
        Dim filter As CriteriaOperator
        filter = CriteriaOperator.Parse("Id = ? ", pOid)
        Dim pClient As New XPCollection(Of EvacService)(dataSession, filter, New DevExpress.Xpo.SortProperty("[CompanyName]", DevExpress.Xpo.DB.SortingDirection.Ascending))
        DataSource = pClient


    End Sub
End Class