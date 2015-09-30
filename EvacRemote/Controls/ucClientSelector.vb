Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Public Class ucClientSelector
    Private _session As UnitOfWork
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim sSql As String = "SELECT OID, ClaimDate, [Client],[Status],[FullName],[Vip],[DOB],PostCode,[PresentingCondition] FROM vw_ClaimDetail "

        Dim sWhere As String = String.Empty
        If Not teName.Text = String.Empty Then
            sWhere = sWhere + String.Format("{0} OID = {1}", IIf(sWhere = String.Empty, "where ", " and "), teName.Text.Trim)
        End If
        If Not tePostCode.Text = String.Empty Then
            sWhere = sWhere + String.Format("{0} PostCode Like '{1}%' ", IIf(sWhere = String.Empty, "where ", " and "), tePostCode.Text.Trim)
        End If

        If sWhere <> String.Empty Then
            sSql = sSql + sWhere
        End If
        Dim dv As New XPDataView()
        Dim data As SelectedData = _session.ExecuteQueryWithMetadata(sSql)
        For Each row As SelectStatementResultRow In data.ResultSet(0).Rows
            dv.AddProperty(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
        Next
        dv.LoadData(New SelectedData(data.ResultSet(1)))
        GridControl1.DataSource = dv

    End Sub

    Public Sub New(Session As Session)

        ' This call is required by the designer.
        InitializeComponent()
        _session = Session
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
