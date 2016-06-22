Imports System.Data.Odbc
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo

Imports EvacRemote.GlobalVariables
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports Esso.Data

Public Class TaskListSwipe
    Private _Loaded As Boolean = False
    Private _Category As eTaskStatus = Nothing
    Dim _session As New UnitOfWork
    Dim xcTasks As XPCollection(Of Task)
    Dim tMaxDate As Date = DateTime.Today.AddDays(30)

    Private _parent As frmMain = Nothing
    Public ReadOnly Property Loaded As Boolean
        Get
            Return _Loaded
        End Get
    End Property
    Public ReadOnly Property CurrentCategoryLong As String
        Get
            Select Case CurrentCategory
                Case Nothing
                    Return "All Tasks"
                Case eTaskStatus.InProgress
                    Return "In Progess"
            End Select
            Return "Other"
        End Get
    End Property
    Public Property CurrentCategory As eTaskStatus
        Get
            Return _Category
        End Get
        Set(value As eTaskStatus)
            _Category = value
        End Set
    End Property
    Public Sub InitData()
        FetchData(eTaskStatus.InProgress)
        colStatus.ColumnEdit = Misc.CreateTaskStatusImageComboBox(GridControl1.RepositoryItems)
        colTaskType.ColumnEdit = Misc.CreateTaskTypeImageComboBox(GridControl1.RepositoryItems)
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
    Private Sub FetchData(pStatus As eTaskStatus)

        Dim filter As CriteriaOperator = Nothing
        Select Case pStatus
            Case Nothing
                filter = CriteriaOperator.Parse("User = ? and StartDate < ? ", _UserCode, tMaxDate)
            Case Else
                filter = CriteriaOperator.Parse("User = ? and StartDate < ? and TaskStatus = ? ", _UserCode, tMaxDate, pStatus)
        End Select

        xcTasks = New XPCollection(Of Task)(_session, filter, New DevExpress.Xpo.SortProperty("[StartDate]", DevExpress.Xpo.DB.SortingDirection.Ascending))
        GridControl1.BeginUpdate()
        GridControl1.DataSource = xcTasks
        GridControl1.EndUpdate()
    End Sub


    Private Sub tileAllItems_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tileEvacuationChairs.ItemClick
        FetchData(Nothing)
    End Sub

    Public Sub New(ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs)
        '  ParentFormMain.ViewProduct("300")
    End Sub



    Private Sub GridView1_MouseDown(sender As Object, e As MouseEventArgs)


        Dim filename As String = ""

    End Sub

    Private Sub tilHighPriority_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tilHighPriority.ItemClick
        FetchData(eTaskStatus.Priority)
    End Sub

    Private Sub tilCompleted_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tilCompleted.ItemClick
        FetchData(eTaskStatus.Completed)
    End Sub

    Private Sub tilDeferred_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tilDeferred.ItemClick
        FetchData(eTaskStatus.Deferred)
    End Sub

    Private Sub tilNotStarted_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tilNotStarted.ItemClick
        FetchData(eTaskStatus.InProgress)
    End Sub

    Private Sub tilInProgress_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tilInProgress.ItemClick
        FetchData(eTaskStatus.InProgress)
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick

    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Dim thisTask As Task = TryCast(GridView1.GetFocusedRow, Task)
        If Not thisTask Is Nothing Then
            iCont = thisTask.Contact
            iDivison = thisTask.Division

            '            If Debugger.IsAttached Then
            iDivison = 1
            'End If

            '     ParentFormMain.HtmlText = String.Format("CONTACT <color=47, 81, 165>{0} {1} ", oRow.Item("divname"), oRow.Item("contact"))
            ThisBasket = New Basket(_session, ParentFormMain, iDivison)
            ParentFormMain.SurveyEnabled(True)
            ParentFormMain.ServiceEnabled(True)
        End If
    End Sub
End Class
