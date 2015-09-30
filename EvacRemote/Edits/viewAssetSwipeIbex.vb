Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls

Public Class viewAssetSwipeIbex
    Private _parent As frmMain = Nothing
    Private _viewServiceSwipe As ServiceSwipe = Nothing
    Private _Asset As Asset
    Private _session As UnitOfWork
    Private xpOptions As XPCollection(Of FieldOption)
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
    Public Property ParentService() As ServiceSwipe
        Get
            Return _viewServiceSwipe
        End Get
        Set(ByVal value As ServiceSwipe)
            If (Not Object.Equals(_viewServiceSwipe, Nothing)) Then
                Return
            End If
            _viewServiceSwipe = value
        End Set
    End Property
    Public Sub Initdata()

    End Sub

    Public Sub New(ByVal parent As frmMain, ByRef pForm As ServiceSwipe, ByRef pAsset As Asset)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _viewServiceSwipe = pForm

        If pAsset Is Nothing Then
            pAsset = New Asset(_session)
        Else

        End If
        _Asset = pAsset
        ' Add any initialization after the InitializeComponent() call.
        teDescription.Text = _Asset.Product
        cbeBuilding.EditValue = _Asset.Building
        cbeLocation.EditValue = _Asset.Division
        teNotes.Text = _Asset.Notes
        tsBackRest.EditValue = 1
        tsBrakeMechanism.EditValue = 1
        tsFasteners.EditValue = 1
        tsHandGrips.EditValue = 1
        tsWheelPulleys.EditValue = 1
        tsPass.EditValue = 1
        tsPatientStraps.EditValue = 1
        tsPlugsCaps.EditValue = 1
        tsTelescopic.EditValue = 1

    End Sub

    Private Sub InitEditors()
        If xpOptions Is Nothing Then
            xpOptions = New XPCollection(Of FieldOption)(_session, Nothing, New DevExpress.Xpo.SortProperty("[ID]", DevExpress.Xpo.DB.SortingDirection.Ascending))

            For Each xOption As FieldOption In xpOptions
                Select Case xOption.ServiceField
                    Case eServiceFields.BackRest
                        icbBackRest.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.BrakeMechanism
                        icbBrakeMechanism.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.BrakeMechanism
                        icbFasteners.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.HandGrips
                        icbHandGrips.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.PatientStraps
                        icbPatientStraps.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.PlugsCaps
                        icbPlugsCaps.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.WheelPulleys
                        icbWheelPulleys.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                End Select
            Next
        End If
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click

        _Asset.Product = teDescription.Text
        _Asset.Building = cbeBuilding.EditValue
        _Asset.Division = cbeLocation.EditValue
        Dim x = tsFasteners.EditValue

        _Asset.Notes = teNotes.Text
        _Asset.Save()
        _Asset.Session.CommitTransaction()
        ParentService.RefreshAsset()
        ParentMain.HideServiceIbex()
    End Sub

    Private Sub tsFasteners_Toggled(sender As Object, e As EventArgs) Handles tsFasteners.Toggled
        If CBool(tsFasteners.EditValue) = True And icbFasteners.Properties.Items.Count > 0 Then
            icbFasteners.Enabled = True
            DxValidationProvider1.SetValidationRule(icbFasteners, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbFasteners.Enabled = False
            DxValidationProvider1.SetValidationRule(icbFasteners, Nothing)

        End If
    End Sub

    Private Sub tsHandGrips_Toggled(sender As Object, e As EventArgs) Handles tsHandGrips.Toggled
        If CBool(tsHandGrips.EditValue) = True And icbHandGrips.Properties.Items.Count > 0 Then
            icbHandGrips.Enabled = True
            DxValidationProvider1.SetValidationRule(icbHandGrips, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbHandGrips.Enabled = False
            DxValidationProvider1.SetValidationRule(icbHandGrips, Nothing)

        End If
    End Sub

    Private Sub tsBackRest_Toggled(sender As Object, e As EventArgs) Handles tsBackRest.Toggled
        If CBool(tsBackRest.EditValue) = True And icbBackRest.Properties.Items.Count > 0 Then
            icbBackRest.Enabled = True
            DxValidationProvider1.SetValidationRule(icbBackRest, Nothing)
        Else
            icbBackRest.Enabled = False
            DxValidationProvider1.SetValidationRule(icbBackRest, ValidationRulesHelper.RuleIsNotBlank)
        End If
    End Sub
    Private Sub tsWheelPulleys_Toggled(sender As Object, e As EventArgs) Handles tsWheelPulleys.Toggled
        If CBool(tsWheelPulleys.EditValue) = True And icbWheelPulleys.Properties.Items.Count > 0 Then
            icbWheelPulleys.Enabled = True
            DxValidationProvider1.SetValidationRule(icbWheelPulleys, Nothing)
        Else
            icbWheelPulleys.Enabled = False
            DxValidationProvider1.SetValidationRule(icbWheelPulleys, ValidationRulesHelper.RuleIsNotBlank)
        End If
    End Sub

    Private Sub tsBrakeMechanism_Toggled(sender As Object, e As EventArgs) Handles tsBrakeMechanism.Toggled
        If CBool(tsBrakeMechanism.EditValue) = True And icbBrakeMechanism.Properties.Items.Count > 0 Then
            icbBrakeMechanism.Enabled = True
            DxValidationProvider1.SetValidationRule(icbBrakeMechanism, Nothing)
        Else
            icbBrakeMechanism.Enabled = False
            DxValidationProvider1.SetValidationRule(icbBrakeMechanism, ValidationRulesHelper.RuleIsNotBlank)
        End If
    End Sub

    Private Sub tsPlugsCaps_Toggled(sender As Object, e As EventArgs) Handles tsPlugsCaps.Toggled
        If CBool(tsPlugsCaps.EditValue) = True And icbPlugsCaps.Properties.Items.Count > 0 Then
            icbPlugsCaps.Enabled = True
            DxValidationProvider1.SetValidationRule(icbPlugsCaps, Nothing)
        Else
            icbPlugsCaps.Enabled = False
            DxValidationProvider1.SetValidationRule(icbPlugsCaps, ValidationRulesHelper.RuleIsNotBlank)
        End If
    End Sub

    Private Sub tsPatientStraps_Toggled(sender As Object, e As EventArgs) Handles tsPatientStraps.Toggled
        If CBool(tsPatientStraps.EditValue) = True And icbPatientStraps.Properties.Items.Count > 0 Then
            icbPatientStraps.Enabled = True
            DxValidationProvider1.SetValidationRule(icbPatientStraps, Nothing)
        Else
            icbPatientStraps.Enabled = False
            DxValidationProvider1.SetValidationRule(icbPatientStraps, ValidationRulesHelper.RuleIsNotBlank)
        End If
    End Sub

    Private Sub tsTelescopic_Toggled(sender As Object, e As EventArgs) Handles tsTelescopic.Toggled
        If CBool(tsTelescopic.EditValue) = True And icbTelescopic.Properties.Items.Count > 0 Then
            icbTelescopic.Enabled = True
            DxValidationProvider1.SetValidationRule(icbTelescopic, Nothing)
        Else
            icbTelescopic.Enabled = False
            DxValidationProvider1.SetValidationRule(icbTelescopic, ValidationRulesHelper.RuleIsNotBlank)
        End If
    End Sub
End Class
