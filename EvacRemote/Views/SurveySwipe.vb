Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Utils

Public Class SurveySwipe
    Private _Loaded As Boolean = False

    Private _parent As frmMain = Nothing
    Private _session As UnitOfWork
    Private _currentbuilding As Building
    Private bNewBuilding As Boolean = False
    Public ReadOnly Property Loaded As Boolean
        Get
            Return _Loaded
        End Get
    End Property
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

    Public Sub InitEditors()

        lueBuilding.Properties.DataSource = xpBuildings
        lueBuilding.Properties.DisplayMember = "Location"
        lueBuilding.Properties.NullText = String.Empty
        lueBuilding.Properties.Columns.Clear()
        lueBuilding.Properties.Columns.Add(New LookUpColumnInfo("Location"))
        lueBuilding.Properties.ShowHeader = False
        lueBuilding.Properties.DropDownRows = Math.Min(xpBuildings.Count, 9)
        lueBuilding.Properties.AllowDropDownWhenReadOnly = DefaultBoolean.False

    End Sub
    Public Sub Initdata()

        xpBuildings = New XPCollection(Of Building)(_session)
        xpEscapeRoutes = New XPCollection(Of EscapeRoute)(_session)
        xpFloors = New XPCollection(Of Asset)(_session)

        If xpBuildings.Count = 0 Then
            Dim nBuilding As New Building(_session)
            nBuilding.Location = String.Format("Building {0}", 1)
            nBuilding.Heritage = "No"
            nBuilding.Access = "Private"
            nBuilding.Save()
            _session.CommitChanges()
            xpBuildings.Add(nBuilding)

        End If
        InitEditors()
        lueBuilding.EditValue = xpBuildings.First

        ' colClient.ColumnEdit = Misc.CreateAccessTypeImageComboBox(grid_Buildings.RepositoryItems, True, True)
        LayoutControl1.FocusHelper.FocusFirstInGroup(LayoutControlGroup1, False)

        _Loaded = True
    End Sub

    Public Sub New(ByVal parent As frmMain, ByVal session As UnitOfWork)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = session
        ' Add any initialization after the InitializeComponent() call.
        LayoutControl1.FocusHelper.FocusFirstInGroup(LayoutControlGroup1, True)
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs)
        ParentFormMain.HideProduct()
    End Sub

    Public Sub RefreshStairWell()
        xpEscapeRoutes.Reload()
    End Sub

    'Private Sub view_Staircases_Click(sender As Object, e As EventArgs)
    '    If CurrentEscapeRoute IsNot Nothing Then
    '        ParentFormMain.ViewEscapeRoute(Me, CurrentEscapeRoute)
    '        _session.CommitChanges()
    '        vw_Stairwells.RefreshData()
    '    End If

    'End Sub

    Private ReadOnly Property CurrentBuilding() As Building
        Get
            If Object.Equals(lueBuilding.EditValue, Nothing) Then
                Return Nothing
            End If
            Return TryCast(lueBuilding.EditValue, Building)
        End Get
    End Property
    Private ReadOnly Property CurrentEscapeRoute() As EscapeRoute
        Get
            If Object.Equals(vw_EscapeRoute, Nothing) OrElse vw_EscapeRoute.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            Return TryCast(vw_EscapeRoute.GetRow(vw_EscapeRoute.FocusedRowHandle), EscapeRoute)
        End Get
    End Property

    Private Sub btnDeleteBuilding_Click(sender As Object, e As EventArgs)
        If CurrentBuilding IsNot Nothing Then
            CurrentBuilding.Delete()
            CurrentBuilding.Save()
            _session.CommitChanges()
        End If

    End Sub

    Private Sub btnNewStairWell_Click(sender As Object, e As EventArgs)
        Dim nStairWell As New EscapeRoute(_session)
        nStairWell.Building = CurrentBuilding
        ParentFormMain.ViewEscapeRoute(Me, nStairWell)
    End Sub

    Private Sub teEscapeRoutes_Validated(sender As Object, e As EventArgs) Handles teEscapeRoutes.Validated
        InitEscapeRoutes(teEscapeRoutes.EditValue)
    End Sub
    Private Sub InitEscapeRoutes(ByVal required As Integer)
        If required > CurrentBuilding.EscapeRoutes.Count Then
            For i As Integer = CurrentBuilding.EscapeRoutes.Count + 1 To required
                Dim _escaperoute As New EscapeRoute(_session)
                _escaperoute.Building = CurrentBuilding
                _escaperoute.Location = String.Format("Escape Route {0}", i)
                _escaperoute.Type = "Fire Exit"
                _escaperoute.NoFloors = 0
                _escaperoute.IntExt = "Internal"
                _escaperoute.Save()
                CurrentBuilding.EscapeRoutes.Add(_escaperoute)
            Next
        ElseIf required < CurrentBuilding.EscapeRoutes.Count Then
            While required < CurrentBuilding.EscapeRoutes.Count
                Dim dStairway = CurrentBuilding.EscapeRoutes(CurrentBuilding.EscapeRoutes.Count - 1)
                dStairway.Delete()
            End While
        End If
        Me.GrdEscapeRoutes.DataSource = CurrentBuilding.EscapeRoutes
    End Sub

    Private Sub lueBuilding_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles lueBuilding.ButtonClick
        If e.Button.Kind = ButtonPredefines.Plus Then
            Dim nBuilding As New Building(_session)
            nBuilding.Location = String.Format("Building {0}", xpBuildings.Count + 1)
            nBuilding.Heritage = "No"
            nBuilding.Access = "Private"
            nBuilding.Save()
            _session.CommitChanges()
            xpBuildings.Add(nBuilding)
            lueBuilding.Properties.DataSource = xpBuildings

            lueBuilding.EditValue = xpBuildings.Last
            lueBuilding.Properties.DropDownRows = Math.Min(xpBuildings.Count, 9)
        ElseIf e.Button.Kind = ButtonPredefines.DropDown Then

        ElseIf e.Button.Kind = ButtonPredefines.Delete Then
        End If
    End Sub

    Private Sub lueBuilding_EditValueChanged(sender As Object, e As EventArgs) Handles lueBuilding.EditValueChanged
        icbAccess.EditValue = CurrentBuilding.Access
        icbHeritage.EditValue = CurrentBuilding.Heritage
        teEscapeRoutes.EditValue = CurrentBuilding.EscapeRoutesNo
    End Sub

    'Private Sub teStairwells_EditValueChanged(sender As Object, e As EventArgs)
    '    InitEscapeRoutes(teStairwells.EditValue)
    'End Sub
    Private Sub InitStairways(ByVal required As Integer)
        If required > CurrentBuilding.Floors.Count Then
            For i As Integer = CurrentBuilding.Floors.Count + 1 To required
                Dim _stairWell As New Floor(_session)
                _stairWell.Building = CurrentBuilding
                _stairWell.Floor = String.Format("StairWell Route {0}", i)
                _stairWell.Type = "Fire Exit"
                '                _stairWell.IntExt = "Internal"
                _stairWell.Save()
                CurrentBuilding.Floors.Add(_stairWell)
            Next
        ElseIf required < CurrentBuilding.Floors.Count Then
            While required < CurrentBuilding.Floors.Count
                Dim dStairway = CurrentBuilding.Floors(CurrentBuilding.Floors.Count - 1)
                dStairway.Delete()
            End While
        End If
        Me.GrdEscapeRoutes.DataSource = CurrentBuilding.EscapeRoutes
    End Sub

    Private Sub GrdEscapeRoutes_Click(sender As Object, e As EventArgs) Handles GrdEscapeRoutes.Click
        System.Threading.Thread.Sleep(50)
        ParentFormMain.ViewEscapeRoute(Me, CurrentEscapeRoute)
    End Sub
    Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        'If _Loaded = False Then
        '    _changed = True
        'End If
    End Sub

   

    Private Sub lueBuilding_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles lueBuilding.ProcessNewValue
        Dim _building As Building = TryCast(lueBuilding.EditValue, Building)
        _building.Location = lueBuilding.Text
        _building.Save()
        _session.CommitChanges()
    End Sub
End Class
