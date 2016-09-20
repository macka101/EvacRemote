Imports System.Data.Odbc
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo

Imports EvacRemote.GlobalVariables
Imports DevExpress.Xpo
Imports Esso.Data
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering

Public Class ContactList
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
        Dim _companyView As XPView = New XPView(_session, GetType(Contact))
        _companyView.AddProperty("Oid", "Oid")
        _companyView.AddProperty("Divname", "Division.Divname")
        '      _companyView.AddProperty("Contact", "Forename + ' ' + Surname")
        _companyView.AddProperty("Address1", "Address.Address1")
        _companyView.AddProperty("Address2", "Address.Address2")
        _companyView.AddProperty("Address3", "Address.Address3")
        _companyView.AddProperty("Address4", "Address.Address4")
        _companyView.AddProperty("PostCode", "Address.PostCode")

        '        _authorisationView.Criteria = CriteriaOperator.Parse("Status= ? and AuthorisationDate is null", eAuthorisationStatus.Active)
        Dim sortCollection As SortingCollection = New SortingCollection()
        '     sortCollection.Add(New SortProperty("Divname", SortingDirection.Ascending))
        sortCollection.Add(New SortProperty("Contact", SortingDirection.Ascending))

        _companyView.Sorting = sortCollection
        grdCompanies.DataSource = _companyView
        If current >= 0 Then
            If current < vw_Companies.RowCount Then
                vw_Companies.FocusedRowHandle = current
            End If
        End If

        _Loaded = True
    End Sub

    Public Sub New(ByVal session As Session, ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = session
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub GridView1_Click(sender As Object, e As EventArgs)
        ViewContact()
    End Sub
    Private Sub ViewContact()
        If CurrentContact IsNot Nothing Then
            _currentContact = CurrentContact
            ParentFormMain.SelectPage(frmMain.ePage.ContactDetail)
        End If

    End Sub
    Private ReadOnly Property CurrentContact() As Contact
        Get
            If vw_Companies.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            Return _session.FindObject(Of Contact)(CriteriaOperator.Parse("Oid = ?", CurrentOid))
        End Get

    End Property
    Private ReadOnly Property CurrentOid() As Guid
        Get
            If vw_Companies.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            If vw_Companies.Columns("OID") IsNot Nothing Then
                Return DirectCast(vw_Companies.GetRowCellValue(vw_Companies.FocusedRowHandle, "OID"), Guid)
            Else
                Return DirectCast(vw_Companies.GetRowCellValue(vw_Companies.FocusedRowHandle, "Oid"), Guid)
            End If
        End Get
    End Property
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


    Private Sub btnFind_Click(sender As Object, e As EventArgs)
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


    Private Sub vw_Companies_DoubleClick(sender As Object, e As EventArgs) Handles vw_Companies.DoubleClick
        ViewContact()
    End Sub
End Class
