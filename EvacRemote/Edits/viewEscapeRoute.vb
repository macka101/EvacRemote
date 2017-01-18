Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports Esso.Data

Public Class viewEscapeRoute
    Private _parent As frmMain = Nothing
    Private _session As UnitOfWork

    Private editValueChangedDelegate As EventHandler

    Private freadOnly As Boolean = False
    Private _binding As Boolean = False
    Private _changed As Boolean = False
    '   Private _loaded As Boolean = False
    'Public ReadOnly Property Loaded As Boolean
    '    Get
    '        Return _loaded
    '    End Get
    'End Property

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
        Misc.CreateFieldOptionGrid(_session, gleStairwayType.Properties, Nothing, False, eField.StairwayType)
        Misc.CreateFieldOptionGrid(_session, gleNosing.Properties, Nothing, False, eField.Nosing)
        Misc.CreateFieldOptionGrid(_session, gleTread.Properties, Nothing, False, eField.Tread)
        Misc.CreateFieldOptionGrid(_session, glePitch.Properties, Nothing, False, eField.Pitch)
        Misc.CreateFieldOptionGrid(_session, gleGoing.Properties, Nothing, False, eField.Going)

        Me.gridFloors.DataSource = _currentEscapeRoute.Floors

        AddHandler teLocation.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teFloors.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler gleStairwayType.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler gleNosing.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler gleTread.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler glePitch.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler gleGoing.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tgsUnEvenGround.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tgsHorizontal.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tgsMisuse.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tgsUpstairs.EditValueChanged, AddressOf edit_EditValueChanged

    End Sub
    Public Sub Initdata()
        InitEditors()
        _changed = False
        _binding = True
        teLocation.Text = _currentEscapeRoute.Location
        teFloors.Text = _currentEscapeRoute.NoFloors
        gleStairwayType.EditValue = _currentEscapeRoute.StairWayType
        gleTread.EditValue = _currentEscapeRoute.Tread
        gleNosing.EditValue = _currentEscapeRoute.Nosing
        glePitch.EditValue = _currentEscapeRoute.Pitch
        gleGoing.EditValue = _currentEscapeRoute.Going

        tgsUnEvenGround.EditValue = _currentEscapeRoute.UnevenGround
        tgsHorizontal.EditValue = _currentEscapeRoute.Horizontal
        tgsMisuse.EditValue = _currentEscapeRoute.Misuse
        tgsUpstairs.EditValue = _currentEscapeRoute.Upstairs
        _binding = False
        LayoutControl1.FocusHelper.FocusFirstInGroup(LayoutControlGroup1, True)
    End Sub

    Public Sub New(ByVal session As UnitOfWork, ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = session
        ' Add any initialization after the InitializeComponent() call.
        LayoutControl1.FocusHelper.FocusFirstInGroup(LayoutControlGroup1, True)
    End Sub

    Public Property [ReadOnly]() As Boolean
        Get
            Return freadOnly
        End Get
        Set(ByVal value As Boolean)
            freadOnly = value
            UpdateReadOnlyData()
        End Set
    End Property
    Private Sub UpdateReadOnlyData()
        If [ReadOnly] Then
            '  lciBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Else
            ' lciBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        End If
        teFloors.ReadOnly = [ReadOnly]

    End Sub
    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        If _changed = True Then
            Dim _save As DialogResult = XtraMessageBox.Show(Me, "Save Changes?", "Save", MessageBoxButtons.YesNoCancel)
            If _save = DialogResult.Cancel Then
                Exit Sub
            End If
            If _save = DialogResult.Yes Then
                SaveData()
            Else
                _currentEscapeRoute.Reload()
            End If
        End If
        ParentFormMain.SelectPage(frmMain.ePage.SurveyDetail)
    End Sub

    Private Sub SaveData()

        _currentEscapeRoute.Location = teLocation.Text
        _currentEscapeRoute.NoFloors = teFloors.Text
        _currentEscapeRoute.StairWayType = gleStairwayType.EditValue
        _currentEscapeRoute.Tread = gleTread.EditValue
        _currentEscapeRoute.Nosing = gleNosing.EditValue
        _currentEscapeRoute.Pitch = glePitch.EditValue
        _currentEscapeRoute.Going = gleGoing.EditValue

        _currentEscapeRoute.UnevenGround = tgsUnEvenGround.EditValue
        _currentEscapeRoute.Horizontal = tgsHorizontal.EditValue
        _currentEscapeRoute.Misuse = tgsMisuse.EditValue
        _currentEscapeRoute.Upstairs = tgsUpstairs.EditValue

        _currentEscapeRoute.Save()
        _session.CommitTransaction()

    End Sub
    Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If [ReadOnly] = False And _binding = False Then
            _changed = True
        End If
    End Sub
    Private ReadOnly Property CurrentFloor() As Floor
        Get
            If Object.Equals(vw_floors, Nothing) OrElse vw_floors.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            Return TryCast(vw_floors.GetRow(vw_floors.FocusedRowHandle), Floor)
        End Get
    End Property
    Private Sub gridFloors_Click(sender As Object, e As EventArgs) Handles gridFloors.Click
        If CurrentFloor IsNot Nothing Then
            If _changed = True Then
                Dim _save As DialogResult = XtraMessageBox.Show(Me, "Save Changes?", "Save", MessageBoxButtons.YesNoCancel)
                If _save = DialogResult.Cancel Then
                    Exit Sub
                End If
                If _save = DialogResult.Yes Then
                    SaveData()
                Else
                    _currentEscapeRoute.Reload()
                End If
            End If
            _currentFloor = CurrentFloor
            ParentFormMain.SelectPage(frmMain.ePage.FloorDetail)
        End If
    End Sub

    Private Sub InitFloors(ByVal required As Integer)
        If required > _currentEscapeRoute.Floors.Count Then
            For i As Integer = _currentEscapeRoute.Floors.Count + 1 To required
                Dim _floor As New Floor(_session)
                _floor.Building = _currentEscapeRoute.Building
                _floor.Location = String.Format("Floor {0}", i)
                _floor.Type = "Fire Exit"
                _floor.Save()
                _currentEscapeRoute.Floors.Add(_floor)
            Next
        ElseIf required < _currentEscapeRoute.Floors.Count Then
            While required < _currentEscapeRoute.Floors.Count
                Dim dfloor = _currentEscapeRoute.Floors(_currentEscapeRoute.Floors.Count - 1)
                dfloor.Delete()
            End While
        End If
        Me.gridFloors.DataSource = _currentEscapeRoute.Floors
    End Sub

    Private Sub teFloors_Validated(sender As Object, e As EventArgs) Handles teFloors.Validated
        InitFloors(teFloors.EditValue)
    End Sub
End Class
