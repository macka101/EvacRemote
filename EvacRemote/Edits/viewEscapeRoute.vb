Imports DevExpress.Xpo
Imports Esso.Data

Public Class viewEscapeRoute
    Private _parent As frmMain = Nothing
    Private _session As UnitOfWork

    Private editValueChangedDelegate As EventHandler

    Private freadOnly As Boolean = False
    Private _binding As Boolean = False
    Private _changed As Boolean = False
    Private _loaded As Boolean = False
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
        Misc.CreateNosingImageComboBox(icbNosing.Properties, Nothing)

        AddHandler teLocation.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teFloors.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbeStairwayType.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler icbNosing.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbeThread.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbePitch.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler CBEGoing.EditValueChanged, AddressOf edit_EditValueChanged
    End Sub
    Public Sub Initdata()
        teLocation.Text = _currentEscapeRoute.Location
        teFloors.Text = _currentEscapeRoute.NoFloors
        cbeStairwayType.EditValue = _currentEscapeRoute.Type
        icbNosing.EditValue = _currentEscapeRoute.Nosing
        cbePitch.EditValue = _currentEscapeRoute.Angle
        CBEGoing.EditValue = _currentEscapeRoute.Going
        _loaded = True
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
        _currentEscapeRoute.Location = teLocation.Text
        _currentEscapeRoute.NoFloors = teFloors.Text
        _currentEscapeRoute.Type = cbeStairwayType.EditValue
        _currentEscapeRoute.Nosing = icbNosing.EditValue
        _currentEscapeRoute.Angle = cbePitch.EditValue
        _currentEscapeRoute.Going = CBEGoing.EditValue
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
            _currentFloor = CurrentFloor
            ParentFormMain.SelectPage(frmMain.ePage.FloorDetail)
        End If
    End Sub

    Private Sub InitFloors(ByVal required As Integer)
        If required > _currentEscapeRoute.Floors.Count Then
            For i As Integer = _currentEscapeRoute.Floors.Count + 1 To required
                Dim _floor As New Floor(_session)
                _floor.Building = _currentEscapeRoute.Building
                _floor.Floor = String.Format("Floor {0}", i)
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
