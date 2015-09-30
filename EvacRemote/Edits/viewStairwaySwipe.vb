Imports DevExpress.Xpo

Public Class viewEscapeRouteSwipe
    Private _parent As frmMain = Nothing
    Private _viewStairwaySwipe As SurveySwipe = Nothing
    Private _StairCase As EscapeRoute
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

        If pStairCase Is Nothing Then
            _StairCase = New EscapeRoute(_session)
        Else

        End If
        _StairCase = pStairCase
        ' Add any initialization after the InitializeComponent() call.
        teReference.Text = _StairCase.NoFloors
        cbeStairwayType.EditValue = _StairCase.Type
        icbNosing.EditValue = _StairCase.Nosing
        cbePitch.EditValue = _StairCase.Angle
        CBEGoing.EditValue = _StairCase.Going
        teNotes.Text = _StairCase.Notes

        Misc.CreateNosingImageComboBox(icbNosing.Properties, Nothing)

        AddHandler teReference.EditValueChanged, AddressOf edit_EditValueChanged
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
        teReference.ReadOnly = [ReadOnly]

    End Sub
    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        _StairCase.NoFloors = teReference.Text
        _StairCase.Type = cbeStairwayType.EditValue
        _StairCase.Nosing = icbNosing.EditValue
        _StairCase.Angle = cbePitch.EditValue
        _StairCase.Going = CBEGoing.EditValue
        _StairCase.Notes = teNotes.Text
        _StairCase.Save()
        _StairCase.Session.CommitTransaction()
        ParentSurvey.RefreshStairWell()
        ParentMain.HideStairCase()
    End Sub
    Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If [ReadOnly] = False And _binding = False Then
            _changed = True
        End If
    End Sub
End Class
