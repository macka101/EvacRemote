Imports DevExpress.Xpo
Imports Esso.Data

Public Class viewFloorSwipe
    Private _parent As frmMain = Nothing
    Private _viewStairwaySwipe As SurveySwipe = Nothing
    Private _Floor As Floor
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
    Public Sub Initdata()

    End Sub

    Public Sub New(ByVal parent As frmMain, ByRef pForm As viewEscapeRouteSwipe, ByRef pFloor As Floor)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = pFloor.Session
        _Floor = pFloor
        ' Add any initialization after the InitializeComponent() call.
        teFloor.Text = _Floor.Floor
        cbeStairwayType.EditValue = _Floor.Type
        icbNosing.EditValue = _Floor.Nosing
        cbePitch.EditValue = _Floor.Pitch
        CBEGoing.EditValue = _Floor.Going
        teNotes.Text = _Floor.Notes

        Misc.CreateNosingImageComboBox(icbNosing.Properties, Nothing)

        AddHandler teFloor.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbeStairwayType.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler icbNosing.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbeThread.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler cbePitch.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler CBEGoing.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teNotes.EditValueChanged, AddressOf edit_EditValueChanged
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
        _Floor.Floor = teFloor.Text
        _Floor.Type = cbeStairwayType.EditValue
        _Floor.Nosing = icbNosing.EditValue
        _Floor.Pitch = cbePitch.EditValue
        _Floor.Going = CBEGoing.EditValue
        _Floor.Notes = teNotes.Text
        _Floor.Save()
        _Floor.Session.CommitTransaction()
        ParentMain.HideFloor()
    End Sub
    Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If [ReadOnly] = False And _binding = False Then
            _changed = True
        End If
    End Sub
End Class
