Imports DevExpress.Xpo
Imports Esso.Data

Public Class viewFloor
    Private _parent As frmMain = Nothing
    Private _session As UnitOfWork

    Private editValueChangedDelegate As EventHandler

    Private freadOnly As Boolean = False
    Private _binding As Boolean = False
    Private _changed As Boolean = False
    Private _loaded As Boolean = False

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

    Public ReadOnly Property Loaded As Boolean
        Get
            Return _loaded
        End Get
    End Property
    Public Sub InitEditors()
        Misc.CreateNosingImageComboBox(icbNosing.Properties, Nothing)

        AddHandler teFloor.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbeStairwayType.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler icbNosing.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbeThread.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbePitch.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler CBEGoing.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teNotes.EditValueChanged, AddressOf edit_EditValueChanged
    End Sub
    Public Sub Initdata()
        teFloor.Text = _currentFloor.Floor
        cbeStairwayType.EditValue = _currentFloor.Type
        icbNosing.EditValue = _currentFloor.Nosing
        cbePitch.EditValue = _currentFloor.Pitch
        CBEGoing.EditValue = _currentFloor.Going
        teNotes.Text = _currentFloor.Notes
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

    End Sub
    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        _currentFloor.Floor = teFloor.Text
        _currentFloor.Type = cbeStairwayType.EditValue
        _currentFloor.Nosing = icbNosing.EditValue
        _currentFloor.Pitch = cbePitch.EditValue
        _currentFloor.Going = CBEGoing.EditValue
        _currentFloor.Notes = teNotes.Text
        _currentFloor.Save()
        _session.CommitTransaction()
        ParentFormMain.SelectPage(frmMain.ePage.EscapeRoute)
    End Sub
    Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If [ReadOnly] = False And _binding = False Then
            _changed = True
        End If
    End Sub
End Class
