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

        Misc.CreateFieldOptionGrid(_session, gleStairwayType.Properties, Nothing, False, eField.StairwayType)
        Misc.CreateFieldOptionGrid(_session, gleNosing.Properties, Nothing, False, eField.Nosing)
        Misc.CreateFieldOptionGrid(_session, gleTread.Properties, Nothing, False, eField.Tread)
        Misc.CreateFieldOptionGrid(_session, glePitch.Properties, Nothing, False, eField.Pitch)
        Misc.CreateFieldOptionGrid(_session, gleGoing.Properties, Nothing, False, eField.Going)

        Misc.CreateProductLookUpEdit(_session, lueRecomended.Properties, Nothing)
        Misc.CreateProductLookUpEdit(_session, lueChair.Properties, Nothing)

        Misc.CreateToggleSwitch(tgsBarriatric)
        Misc.CreateToggleSwitch(tgsBedAccess)
        Misc.CreateToggleSwitch(tgsBedBound)
        Misc.CreateToggleSwitch(tgsComplexDisability)
        Misc.CreateToggleSwitch(tgsMisuse)
        Misc.CreateToggleSwitch(tgsMovingHandling)
        Misc.CreateToggleSwitch(tgsSmallStorage)

        AddHandler teFloor.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler gleStairwayType.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler gleNosing.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler gleTread.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler glePitch.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler gleGoing.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teNotes.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tgsBedBound.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tgsBarriatric.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tgsComplexDisability.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tgsSmallStorage.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tgsBedAccess.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tgsMisuse.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tgsMovingHandling.EditValueChanged, AddressOf edit_EditValueChanged
    End Sub
    Public Sub Initdata()
        InitEditors()
        teFloor.Text = _currentFloor.Location
        gleStairwayType.EditValue = _currentFloor.StairWayType
        gleNosing.EditValue = _currentFloor.Nosing
        glePitch.EditValue = _currentFloor.Pitch
        gleGoing.EditValue = _currentFloor.Going
        gleTread.EditValue = _currentFloor.Tread
        lueChair.EditValue = _currentFloor.Product

        tgsBedBound.IsOn = _currentFloor.BedBound
        tgsBarriatric.IsOn = _currentFloor.Barriatric
        tgsComplexDisability.IsOn = _currentFloor.ComplexDisability
        tgsSmallStorage.IsOn = _currentFloor.SmallStorage
        tgsBedAccess.IsOn = _currentFloor.BedAccess
        tgsMisuse.IsOn = _currentFloor.Misuse
        tgsMovingHandling.IsOn = _currentFloor.MovingAndHandling

        lueRecomended.EditValue = _currentFloor.RecommendedProduct
        teNotes.Text = _currentFloor.Notes
    End Sub
    Private Sub SaveData()
        _currentFloor.Location = teFloor.Text
        _currentFloor.StairWayType = gleStairwayType.EditValue
        _currentFloor.Nosing = gleNosing.EditValue
        _currentFloor.Pitch = glePitch.EditValue
        _currentFloor.Tread = gleTread.EditValue
        _currentFloor.Going = gleGoing.EditValue
        _currentFloor.Product = lueChair.EditValue

        _currentFloor.BedBound = tgsBedBound.IsOn
        _currentFloor.Barriatric = tgsBarriatric.IsOn
        _currentFloor.ComplexDisability = tgsComplexDisability.IsOn
        _currentFloor.SmallStorage = tgsSmallStorage.IsOn
        _currentFloor.BedAccess = tgsBedAccess.IsOn
        _currentFloor.Misuse = tgsMisuse.IsOn
        _currentFloor.MovingAndHandling = tgsMovingHandling.IsOn


        _currentFloor.RecommendedProduct = lueRecomended.EditValue
        _currentFloor.Notes = teNotes.Text
        _currentFloor.Save()
        _session.CommitChanges()
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
        SaveData()
        ParentFormMain.SelectPage(frmMain.ePage.EscapeRoute)
    End Sub
    Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If [ReadOnly] = False And _binding = False Then
            _changed = True

            lueRecomended.EditValue = _currentFloor.RecommendedProduct
        End If
    End Sub

  
    Private Sub tgsBedBound_Validated(sender As Object, e As EventArgs) Handles tgsBedBound.Validated
        _currentFloor.BedBound = tgsBedBound.IsOn
        RecommendProduct(_session, _currentFloor)
    End Sub


    Private Sub tgsBarriatric_Validated(sender As Object, e As EventArgs) Handles tgsBarriatric.Validated
        _currentFloor.Barriatric = tgsBarriatric.IsOn
        RecommendProduct(_session, _currentFloor)
    End Sub

    Private Sub tgsComplexDisability_Validated(sender As Object, e As EventArgs) Handles tgsComplexDisability.Validated
        _currentFloor.ComplexDisability = tgsComplexDisability.IsOn
        RecommendProduct(_session, _currentFloor)
    End Sub

    Private Sub tgsSmallStorage_Validated(sender As Object, e As EventArgs) Handles tgsSmallStorage.Validated
        _currentFloor.SmallStorage = tgsSmallStorage.IsOn
        RecommendProduct(_session, _currentFloor)
    End Sub

    Private Sub tgsBedAccess_Validated(sender As Object, e As EventArgs) Handles tgsBedAccess.Validated
        _currentFloor.BedAccess = tgsBedAccess.IsOn
        RecommendProduct(_session, _currentFloor)
    End Sub

    Private Sub tgsMisuse_Validated(sender As Object, e As EventArgs) Handles tgsMisuse.Validated
        _currentFloor.Misuse = tgsMisuse.IsOn
        RecommendProduct(_session, _currentFloor)
    End Sub

    Private Sub tgsMovingHandling_Validated(sender As Object, e As EventArgs) Handles tgsMovingHandling.Validated
        _currentFloor.MovingAndHandling = tgsMovingHandling.IsOn
        RecommendProduct(_session, _currentFloor)
    End Sub
End Class
