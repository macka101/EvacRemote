Imports System.Data.Odbc
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo

Imports EvacRemote.GlobalVariables
Imports DevExpress.XtraScheduler

Public Class ScheduleListSwipe
    Private _Loaded As Boolean = False
    Private _Category As String = "TODAY"
    Dim dsContacts As New DataSet

    Private Const OutlookEntryIDFieldName As String = "OutlookEntryID"
    Public Const CustomFieldPropertyName As String = "UserID"
    Public Const OutlookUserPropertyName As String = "UserID"
    Private count As Integer = 0

    Private resourceColorSchemas As Dictionary(Of Object, SchedulerColorSchema) = New Dictionary(Of Object, SchedulerColorSchema)()

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
        _UserId = 1
        If _UserId = -1 Then
            Me.Engineer_locationsTableAdapter.Fill(Me.DataSet1.engineer_locations)
        Else
            Me.Engineer_locationsTableAdapter.FillBy(Me.DataSet1.engineer_locations, _UserId)
        End If

        'TODO: This line of code loads data into the 'DataSet1.lead_xtra' table. You can move, or remove it, as needed.
        If _UserId = -1 Then
            Me.Central_diaryTableAdapter1.Fill(Me.DataSet1.central_diary)
        Else
            Me.Central_diaryTableAdapter1.FillBy(Me.DataSet1.central_diary, _UserId)
        End If
        _Loaded = True
    End Sub

    Public Sub New(ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnDay_Click(sender As Object, e As EventArgs) Handles btnDay.Click
        SchedulerControl1.ActiveViewType = SchedulerViewType.Day
    End Sub

    Private Sub btnWeek_Click(sender As Object, e As EventArgs) Handles btnWeek.Click
        SchedulerControl1.ActiveViewType = SchedulerViewType.Week
    End Sub

    Private Sub btnMonth_Click(sender As Object, e As EventArgs) Handles btnMonth.Click
        SchedulerControl1.ActiveViewType = SchedulerViewType.Month
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        SchedulerControl1.GoToToday()
    End Sub
End Class
