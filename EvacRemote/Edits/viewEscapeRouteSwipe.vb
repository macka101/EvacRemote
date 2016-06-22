Imports DevExpress.Xpo
Imports Esso.Data

Public Class viewEscapeRouteSwipe
    Private _parent As frmMain = Nothing
    Private _viewStairwaySwipe As SurveySwipe = Nothing
    Private _EscapeRoute As EscapeRoute
    Private _session As UnitOfWork

    Private editValueChangedDelegate As EventHandler

    Private freadOnly As Boolean = False
    Private _binding As Boolean = False
    Private _changed As Boolean = False

    Public Property ParentMain() As frmMain
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
    Public Property ParentSurvey() As SurveySwipe
        Get
            Return _viewStairwaySwipe
        End Get
        Set(ByVal value As SurveySwipe)
            If (Not Object.Equals(_viewStairwaySwipe, Nothing)) Then
                Return
            End If
            _viewStairwaySwipe = value
        End Set
    End Property
    Public Sub Initdata()

    End Sub

    Public Sub New(ByVal parent As frmMain, ByRef pForm As SurveySwipe, ByRef pStairCase As EscapeRoute)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _viewStairwaySwipe = pForm
        _session = pStairCase.Session
        _EscapeRoute = pStairCase
        ' Add any initialization after the InitializeComponent() call.
        teLocation.Text = _EscapeRoute.Location
        teFloors.Text = _EscapeRoute.NoFloors
        cbeStairwayType.EditValue = _EscapeRoute.Type
        icbNosing.EditValue = _EscapeRoute.Nosing
        cbePitch.EditValue = _EscapeRoute.Angle
        CBEGoing.EditValue = _EscapeRoute.Going

        Misc.CreateNosingImageComboBox(icbNosing.Properties, Nothing)

        AddHandler teLocation.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teFloors.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbeStairwayType.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler icbNosing.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbeThread.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbePitch.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler CBEGoing.EditValueChanged, AddressOf edit_EditValueChanged

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
        _EscapeRoute.Location = teLocation.Text
        _EscapeRoute.NoFloors = teFloors.Text
        _EscapeRoute.Type = cbeStairwayType.EditValue
        _EscapeRoute.Nosing = icbNosing.EditValue
        _EscapeRoute.Angle = cbePitch.EditValue
        _EscapeRoute.Going = CBEGoing.EditValue
        _EscapeRoute.Save()
        _EscapeRoute.Session.CommitTransaction()
        ParentSurvey.RefreshStairWell()
        ParentMain.HideStairCase()
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
        ParentMain.ViewFloor(Me, CurrentFloor)

        'If CurrentFloor IsNot Nothing Then
        '    Using frmFloor As New viewFloorSwipe(_session, CurrentFloor)
        '        frmFloor.Parent = frmMain.MainPnl
        '        frmFloor.Dock = DockStyle.Fill
        '        frmFloor.Initdata()
        '        Me.Visible = False
        '        frmFloor.Visible = True
        '    End Using
        '    Me.Visible = True
        'End If
    End Sub

    Private Sub InitFloors(ByVal required As Integer)
        If required > _EscapeRoute.Floors.Count Then
            For i As Integer = _EscapeRoute.Floors.Count + 1 To required
                Dim _floor As New Floor(_session)
                _floor.Building = _EscapeRoute.Building
                _floor.Floor = String.Format("Floor {0}", i)
                _floor.Type = "Fire Exit"
                _floor.Save()
                _EscapeRoute.Floors.Add(_floor)
            Next
        ElseIf required < _EscapeRoute.Floors.Count Then
            While required < _EscapeRoute.Floors.Count
                Dim dfloor = _EscapeRoute.Floors(_EscapeRoute.Floors.Count - 1)
                dfloor.Delete()
            End While
        End If
        Me.gridFloors.DataSource = _EscapeRoute.Floors
    End Sub

    Private Sub teFloors_Validated(sender As Object, e As EventArgs) Handles teFloors.Validated
        InitFloors(teFloors.EditValue)
    End Sub
End Class
