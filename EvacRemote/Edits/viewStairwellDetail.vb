Imports DevExpress.Xpo
Imports Esso.Data

Public Class viewStairWellDetail
    Private _Loaded As Boolean = False

    Private _parent As frmMain = Nothing
    Private _viewStairwaySwipe As ServiceDetail = Nothing

    Private _session As UnitOfWork

    Private editValueChangedDelegate As EventHandler

    Private freadOnly As Boolean = False
    Private _binding As Boolean = False
    Private _changed As Boolean = False
    Public ReadOnly Property Loaded As Boolean
        Get
            Return _Loaded
        End Get
    End Property

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
    Public Sub Initdata()

    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = session
        ' Add any initialization after the InitializeComponent() call.

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = session
        '  _Floor = pFloor
        ' Add any initialization after the InitializeComponent() call.
        teFloor.Text = _currentStairwell.Floor
        cbeStairwayType.EditValue = _currentStairwell.Type
        icbNosing.EditValue = _currentStairwell.Nosing
        cbePitch.EditValue = _currentStairwell.Pitch
        CBEGoing.EditValue = _currentStairwell.Going
        teNotes.Text = _currentStairwell.Notes

        Misc.CreateNosingImageComboBox(icbNosing.Properties, Nothing)

        AddHandler teFloor.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbeStairwayType.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler icbNosing.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbeThread.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbePitch.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler CBEGoing.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teNotes.EditValueChanged, AddressOf edit_EditValueChanged
        _Loaded = True

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
        _currentStairwell.Floor = teFloor.Text
        _currentStairwell.Type = cbeStairwayType.EditValue
        _currentStairwell.Nosing = icbNosing.EditValue
        _currentStairwell.Pitch = cbePitch.EditValue
        _currentStairwell.Going = CBEGoing.EditValue
        _currentStairwell.Notes = teNotes.Text
        _currentStairwell.Save()
        _currentStairwell.Session.CommitTransaction()
        ParentMain.HideFloor()
    End Sub
    Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If [ReadOnly] = False And _binding = False Then
            _changed = True
        End If
    End Sub
End Class
