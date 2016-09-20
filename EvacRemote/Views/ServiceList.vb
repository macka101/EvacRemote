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

Public Class ServiceList
    Private _Loaded As Boolean = False
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

        Dim current As Integer = vw_Service.FocusedRowHandle
        Dim _serviceView As XPView = New XPView(_session, GetType(EvacService))
        _serviceView.AddProperty("Oid", "Oid")
        _serviceView.AddProperty("ServiceDate", "ServiceDate")
        '      _companyView.AddProperty("Contact", "Forename + ' ' + Surname")

        '        _authorisationView.Criteria = CriteriaOperator.Parse("Status= ? and AuthorisationDate is null", eAuthorisationStatus.Active)
        Dim sortCollection As SortingCollection = New SortingCollection()
        '     sortCollection.Add(New SortProperty("Divname", SortingDirection.Ascending))
        sortCollection.Add(New SortProperty("ServiceDate", SortingDirection.Descending))

        _serviceView.Sorting = sortCollection
        grdService.DataSource = _serviceView
        If current >= 0 Then
            If current < vw_Service.RowCount Then
                vw_Service.FocusedRowHandle = current
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
        ViewService()
    End Sub
    Private Sub ViewService()
        If CurrentService IsNot Nothing Then
            _currentService = CurrentService
            ParentFormMain.SelectPage(frmMain.ePage.ServiceDetail)
        End If

    End Sub
    Private ReadOnly Property CurrentService() As EvacService
        Get
            If vw_Service.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            Return _session.FindObject(Of EvacService)(CriteriaOperator.Parse("Oid = ?", CurrentOid))
        End Get

    End Property
    Private ReadOnly Property CurrentOid() As Guid
        Get
            If vw_Service.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            If vw_Service.Columns("OID") IsNot Nothing Then
                Return DirectCast(vw_Service.GetRowCellValue(vw_Service.FocusedRowHandle, "OID"), Guid)
            Else
                Return DirectCast(vw_Service.GetRowCellValue(vw_Service.FocusedRowHandle, "Oid"), Guid)
            End If
        End Get
    End Property

    Private Sub vw_Companies_DoubleClick(sender As Object, e As EventArgs) Handles vw_Service.DoubleClick
        ViewService()
    End Sub

  
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        _currentService = Nothing
        ParentFormMain.SelectPage(frmMain.ePage.ServiceDetail)
    End Sub
End Class
