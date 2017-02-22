Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Esso.Data
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraReports.UI.PivotGrid

Public Class SurveyDetail

    Private _parent As frmMain = Nothing
    Private _session As UnitOfWork
    ' Private _currentbuilding As Building
    Private bNewBuilding As Boolean = False
    Private _binding As Boolean = False
    Private _changed As Boolean = False

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

        '     xpBuildings = _currentDivision.Buildings

        'xpEscapeRoutes = New XPCollection(Of EscapeRoute)(_session)
        'xpFloors = New XPCollection(Of Floor)(_session)

        CreateBuildingLookUpEdit(_session, lueBuilding.Properties, Nothing, False, _currentDivision.Oid)

        'lueBuilding.Properties.DataSource = xpBuildings
        'lueBuilding.Properties.DisplayMember = "Location"
        'lueBuilding.Properties.NullText = String.Empty
        'lueBuilding.Properties.Columns.Clear()
        'lueBuilding.Properties.Columns.Add(New LookUpColumnInfo("Location"))
        'lueBuilding.Properties.ShowHeader = False
        'If xpBuildings Is Nothing Then
        '    lueBuilding.Properties.DropDownRows = 9
        'Else
        '    lueBuilding.Properties.DropDownRows = Math.Min(xpBuildings.Count, 9)
        'End If

        'lueBuilding.Properties.AllowDropDownWhenReadOnly = DefaultBoolean.False

        AddHandler lueBuilding.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler icbAccess.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler icbHeritage.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler icbHospital.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler icbEducational.EditValueChanged, AddressOf edit_EditValueChanged

        AddHandler teEscapeRoutes.EditValueChanged, AddressOf edit_EditValueChanged

    End Sub
    Public Sub Initdata()
        _currentSurvey = _session.FindObject(Of EvacSurvey)(CriteriaOperator.Parse("Division = ?", _currentDivision.Oid))
        If _currentSurvey Is Nothing Then
            _currentSurvey = New EvacSurvey(_session)
            _currentSurvey.Division = _currentDivision
            _currentSurvey.Contact = _currentContact
            _currentSurvey.SurveyDate = DateTime.Today
            _currentSurvey.SurveyBy = _session.GetObjectByKey(Of User)(_user.Oid)
            _currentSurvey.Save()
            _session.CommitChanges()
        End If
        If _currentDivision.Buildings.Count = 0 Then
            _currentBuilding = New Building(_session)
            _currentBuilding.Division = _currentDivision
            _currentBuilding.Location = "Building 1"
            _currentBuilding.Heritage = "N"c
            _currentBuilding.Hospital = "N"c
            _currentBuilding.Educational = "N"c
            _currentBuilding.Access = "Private"
            _currentBuilding.EscapeRoutesNo = 0
            _currentBuilding.Save()
            _session.CommitChanges()
        End If
        InitEditors()
        _changed = False
        _binding = True

        lueBuilding.EditValue = _currentDivision.Buildings.First
        LayoutControl1.FocusHelper.FocusFirstInGroup(LayoutControlGroup1, False)

        _binding = False
    End Sub

    Public Sub New(ByVal session As UnitOfWork, ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = session


        ' Add any initialization after the InitializeComponent() call.
        LayoutControl1.FocusHelper.FocusFirstInGroup(LayoutControlGroup1, True)
    End Sub

    'Public Sub RefreshStairWell()
    '    xpEscapeRoutes.Reload()
    'End Sub

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
        '    ParentFormMain.ViewEscapeRoute(Me, nStairWell)
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
            Dim _building As New Building(_session)
            _building.Division = _currentDivision
            _building.Location = String.Format("Building {0}", _currentDivision.Buildings.Count + 1)
            _building.Heritage = "N"c
            _building.Hospital = "N"c
            _building.Educational = "N"c
            _building.Access = "Private"
            _building.Save()
            _session.CommitChanges()
            '   xpBuildings.Add(nBuilding)
            CreateBuildingLookUpEdit(_session, lueBuilding.Properties, Nothing, False, _currentDivision.Oid)

        ElseIf e.Button.Kind = ButtonPredefines.DropDown Then

        ElseIf e.Button.Kind = ButtonPredefines.Delete Then
        End If
    End Sub

    Private Sub lueBuilding_EditValueChanged(sender As Object, e As EventArgs) Handles lueBuilding.EditValueChanged
        If CurrentBuilding IsNot Nothing Then
            icbAccess.EditValue = CurrentBuilding.Access
            icbHeritage.EditValue = CurrentBuilding.Heritage
            icbHospital.EditValue = CurrentBuilding.Hospital
            icbEducational.EditValue = CurrentBuilding.Educational
            teEscapeRoutes.EditValue = CurrentBuilding.EscapeRoutesNo
            GrdEscapeRoutes.DataSource = CurrentBuilding.EscapeRoutes
        End If
    End Sub

    Private Sub InitStairways(ByVal required As Integer)
        If required > CurrentBuilding.Floors.Count Then
            For i As Integer = CurrentBuilding.Floors.Count + 1 To required
                Dim _stairWell As New Floor(_session)
                _stairWell.Building = CurrentBuilding
                _stairWell.Location = String.Format("StairWell Route {0}", i)
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
        '   ParentFormMain.ViewEscapeRoute(Me, CurrentEscapeRoute)
    End Sub
    Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If _binding = False Then
            _changed = True
        End If
    End Sub

    Private Sub lueBuilding_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles lueBuilding.ProcessNewValue
        Dim _name As String = e.DisplayValue.ToString
        If XtraMessageBox.Show(Me, "Update Building Name ?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim _building As Building = TryCast(lueBuilding.EditValue, Building)
            _building.Location = lueBuilding.Text
            _building.Save()
            _session.CommitChanges()
            e.Handled = True
        End If
    End Sub
    Private Sub SaveData()
        CurrentBuilding.Access = icbAccess.Text
        CurrentBuilding.Heritage = icbHeritage.EditValue
        CurrentBuilding.Hospital = icbHospital.EditValue
        CurrentBuilding.Educational = icbEducational.EditValue
        CurrentBuilding.EscapeRoutesNo = teEscapeRoutes.Text
        CurrentBuilding.Save()
        _session.CommitChanges()
        If _currentSurvey.SurveyBy Is Nothing Then
            _currentSurvey.SurveyBy = _session.GetObjectByKey(Of User)(_user.Oid)
            _currentSurvey.Save()
            _session.CommitChanges()
        End If
    End Sub

    Private Sub vw_EscapeRoute_Click(sender As Object, e As EventArgs) Handles vw_EscapeRoute.Click
        If CurrentEscapeRoute IsNot Nothing Then
            If _changed = True Then
                SaveData()
            End If
            _currentEscapeRoute = CurrentEscapeRoute
            ParentFormMain.SelectPage(frmMain.ePage.EscapeRoute)
        End If
    End Sub

    Private Sub btnPrintQuote_Click(sender As Object, e As EventArgs) Handles btnPrintQuote.Click
        If _changed = True Then
            Dim _save As DialogResult = XtraMessageBox.Show(Me, "Save Changes?", "Save", MessageBoxButtons.YesNoCancel)
            If _save = DialogResult.Cancel Then
                Exit Sub
            End If
            If _save = DialogResult.Yes Then
                SaveData()
            Else
                _currentSurvey.Reload()
            End If
        End If

        Dim _quoteDoc As New xptSurveyQuote
        _quoteDoc.RequestParameters = False
        _quoteDoc.Parameters(0).Value = _currentSurvey.Oid
        _quoteDoc.CreateDocument()


        Dim _productDoc As New xptSurveyProducts
        _productDoc.Parameters(0).Value = _currentSurvey.Oid
        _productDoc.CreateDocument()

        ' Add all pages of the 2nd report to the end of the 1st report. 
        _quoteDoc.Pages.AddRange(_productDoc.Pages)

        ' Reset all page numbers in the resulting document. 
        _quoteDoc.PrintingSystem.ContinuousPageNumbering = True

        Using printTool As New ReportPrintTool(_quoteDoc)
            printTool.ShowPreviewDialog()
        End Using

    End Sub


    Private Sub Picback_Click(sender As Object, e As EventArgs) Handles Picback.Click
        If _changed = True Then
            Dim _save As DialogResult = XtraMessageBox.Show(Me, "Save Changes?", "Save", MessageBoxButtons.YesNoCancel)
            If _save = DialogResult.Cancel Then
                Exit Sub
            End If
            If _save = DialogResult.Yes Then
                SaveData()
            Else
                _currentSurvey.Reload()
            End If
        End If
        ParentFormMain.SelectPage(frmMain.ePage.ContactDetail)
    End Sub
End Class
