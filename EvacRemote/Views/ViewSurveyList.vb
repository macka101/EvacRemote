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

Public Class ViewSurveyList
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

        Dim current As Integer = vw_Surveys.FocusedRowHandle
        Dim _surveyView As XPView = New XPView(_session, GetType(EvacService))
        _surveyView.AddProperty("Oid", "Oid")
        _surveyView.AddProperty("ServiceDate", "ServiceDate")
        '      _companyView.AddProperty("Contact", "Forename + ' ' + Surname")

        '        _authorisationView.Criteria = CriteriaOperator.Parse("Status= ? and AuthorisationDate is null", eAuthorisationStatus.Active)
        Dim sortCollection As SortingCollection = New SortingCollection()
        '     sortCollection.Add(New SortProperty("Divname", SortingDirection.Ascending))
        sortCollection.Add(New SortProperty("ServiceDate", SortingDirection.Descending))

        _surveyView.Sorting = sortCollection
        grdSurveys.DataSource = _surveyView
        If current >= 0 Then
            If current < vw_Surveys.RowCount Then
                vw_Surveys.FocusedRowHandle = current
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
        ViewSurvey()
    End Sub
    Private Sub ViewSurvey()
        If CurrentSurvey IsNot Nothing Then
            _currentSurvey = CurrentSurvey
            ParentFormMain.SelectPage(frmMain.ePage.SurveyDetail)
        End If

    End Sub
    Private ReadOnly Property CurrentSurvey() As EvacSurvey
        Get
            If vw_Surveys.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            Return _session.FindObject(Of EvacSurvey)(CriteriaOperator.Parse("Oid = ?", CurrentOid))
        End Get

    End Property
    Private ReadOnly Property CurrentOid() As Guid
        Get
            If vw_Surveys.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            If vw_Surveys.Columns("OID") IsNot Nothing Then
                Return DirectCast(vw_Surveys.GetRowCellValue(vw_Surveys.FocusedRowHandle, "OID"), Guid)
            Else
                Return DirectCast(vw_Surveys.GetRowCellValue(vw_Surveys.FocusedRowHandle, "Oid"), Guid)
            End If
        End Get
    End Property
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        _currentSurvey = New EvacSurvey(_session)
        _currentSurvey.Division = _currentDivision
        _currentSurvey.Contact = _currentContact
        ParentFormMain.SelectPage(frmMain.ePage.SurveyDetail)
    End Sub

    Private Sub vw_Surveys_DoubleClick(sender As Object, e As EventArgs) Handles vw_Surveys.DoubleClick
        ViewSurvey()
    End Sub
End Class
