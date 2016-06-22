Imports System.Data.Odbc
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo

Imports EvacRemote.GlobalVariables
Imports DevExpress.Xpo
Imports Esso.Data
Imports DevExpress.Xpo.DB

Public Class CompanyList
    Private _Loaded As Boolean = False
    Private _Category As String = "Evac"
    Private _session As UnitOfWork
    Private _parent As frmMain = Nothing
    Public ReadOnly Property Loaded As Boolean
        Get
            Return _Loaded
        End Get
    End Property
    Public Sub InitData()
        teName.Focus()
        FetchData()
    End Sub
    Public Property ParentFormMain() As frmMain
        Get
            Return _parent
        End Get
        Set(ByVal value As frmMain)
            If (Not Object.Equals(_parent, Nothing)) Then
                Return
            End If
            _parent = value
        End Set
    End Property
    Private Sub FetchData()

        Dim current As Integer = vw_Companies.FocusedRowHandle
        Dim _companyView As XPView = New XPView(_session, GetType(Company))
        _companyView.AddProperty("Oid", "Oid")
        _companyView.AddProperty("Compname", "Compname")
        _companyView.AddProperty("Address1", "Address.Address1")
        _companyView.AddProperty("Address2", "Address.Address2")
        _companyView.AddProperty("Address3", "Address.Address3")
        _companyView.AddProperty("Address4", "Address.Address4")
        _companyView.AddProperty("PostCode", "Address.PostCode")

        '        _authorisationView.Criteria = CriteriaOperator.Parse("Status= ? and AuthorisationDate is null", eAuthorisationStatus.Active)
        Dim sortCollection As SortingCollection = New SortingCollection()
        sortCollection.Add(New SortProperty("Oid", SortingDirection.Ascending))
        _companyView.Sorting = sortCollection
        grdCompanies.DataSource = _companyView
        If current >= 0 Then
            If current < vw_Companies.RowCount Then
                vw_Companies.FocusedRowHandle = current
            End If
        End If

        Dim xpCompanies As XPCollection(Of Company) = New XPCollection(Of Company)(_session, Nothing, New DevExpress.Xpo.SortProperty("[Compname]", DevExpress.Xpo.DB.SortingDirection.Ascending))
        grdCompanies.DataSource = xpCompanies
        _Loaded = True
    End Sub

    Public Sub New(ByVal session As Session, ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = New UnitOfWork
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs)
        ParentFormMain.ViewContact("300")
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs)

        Dim oRow As DataRowView = vw_Companies.GetFocusedRow
        ParentFormMain.ViewContact(oRow.Item("contno"))

    End Sub

    Private Sub btnSetCurrent_Click(sender As Object, e As EventArgs) Handles btnSetCurrent.Click
        Dim oRow As DataRowView = vw_Companies.GetFocusedRow
        If oRow IsNot Nothing Then
            iCont = oRow.Item("contno")
            iDivison = oRow.Item("divno")
            SIContact.Text = String.Format("CONTACT <color=47, 81, 165>{0} {1} ", oRow.Item("divname"), oRow.Item("contact"))
            ParentFormMain.HtmlText = SIContact.Text.Trim
            ThisBasket = New Basket(_session, ParentFormMain, oRow.Item("contno"))
            ParentFormMain.SurveyEnabled(True)
        End If
    End Sub


    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            btnSetCurrent.Enabled = False
            FetchData()
            btnSetCurrent.Enabled = True
            btnSetCurrent.Visible = True
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub teName_KeyDown(sender As Object, e As KeyEventArgs) Handles teName.KeyDown
        If e.KeyCode = Keys.Return Then
            FetchData()
        End If

    End Sub
End Class
