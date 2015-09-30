Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class rptServiceReport
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal dataSession As UnitOfWork, pOid As Integer)
        Me.New()
        InitData(dataSession, pOid)
    End Sub
    Private Sub InitData(ByVal dataSession As UnitOfWork, pOid As Integer)
        Dim filter As CriteriaOperator
        filter = CriteriaOperator.Parse("ID = ? ", pOid)
        Dim pService As New XPCollection(Of EvacService)(dataSession, filter, New DevExpress.Xpo.SortProperty("[ServiceDate]", DevExpress.Xpo.DB.SortingDirection.Ascending))
        DataSource = pService
    End Sub
End Class