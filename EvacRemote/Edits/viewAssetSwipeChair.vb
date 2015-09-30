Imports DevExpress.Xpo
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.Helpers
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors

Public Class viewAssetSwipeChair
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
        InitEditors()
        teDescription.Text = _Asset.Product
        cbeBuilding.EditValue = _Asset.Building
        cbeLocation.EditValue = _Asset.Division
        teNotes.Text = _Asset.Notes
    End Sub

    Public Sub New(ByRef session As UnitOfWork, ByVal parent As frmMain, ByRef pForm As ServiceSwipe, ByRef pAsset As Asset)

        ' This call is required by the designer.
        InitializeComponent()
        _session = session
        _parent = parent
        _viewServiceSwipe = pForm

        If pAsset Is Nothing Then
            _Asset = New Asset(_session)
        Else
            _Asset = pAsset
        End If
        Initdata()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        If Not DxValidationProvider1.Validate() Then
            XtraMessageBox.Show("Please supply missing information.", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        _Asset.Product = teDescription.Text
        _Asset.Building = cbeBuilding.EditValue
        _Asset.Division = cbeLocation.EditValue
        _Asset.Notes = teNotes.Text
        _Asset.Save()
        _Asset.Session.CommitTransaction()
        ParentService.RefreshAsset()
        ParentMain.HideServiceChair()
    End Sub
    Private Sub InitEditors()
        If xpOptions Is Nothing Then
            xpOptions = New XPCollection(Of FieldOption)(_session, Nothing, New DevExpress.Xpo.SortProperty("[ID]", DevExpress.Xpo.DB.SortingDirection.Ascending))

            For Each xOption As FieldOption In xpOptions
                Select Case xOption.ServiceField
                    Case eServiceFields.SpringClips
                        icbSpringClips.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.SeatRivets
                        icbSeatRivets.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.PaddingSeat
                        icbPaddingSeat.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.FrontHandle
                        icbFrontHandle.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.RearHandle
                        icbRearHandle.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.HammockCondition
                        icbHammockCondition.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.KickstandGasSpring
                        icbKickstandGasSpring.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.RotationBelts
                        icbRotationBelts.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.SkiAssemblyRollers
                        icbSkiAssemblyRollers.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.SpindlePosition
                        icbSpindlePosition.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.SafetyBelt
                        icbSafetyBelt.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.SeatFrame
                        icbSeatFrame.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.KickstandBolt
                        icbKickstandBolt.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.KickstandGas
                        icbKickstandGas.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.StabiliserRivets
                        icbStabiliserRivets.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                    Case eServiceFields.Closure
                        icbClosure.Properties.Items.Add(New ImageComboBoxItem(xOption.Description, xOption.ID))
                End Select
            Next
        End If
    End Sub

    Private Sub tsSpringClips_Toggled(sender As Object, e As EventArgs) Handles tsSpringClips.Toggled
        If CBool(tsSpringClips.EditValue) = True And icbSpringClips.Properties.Items.Count > 0 Then
            icbSpringClips.Enabled = True
            DxValidationProvider1.SetValidationRule(icbSpringClips, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbSpringClips.Enabled = False
            DxValidationProvider1.SetValidationRule(icbSpringClips, Nothing)
        End If
    End Sub

    Private Sub tsPaddingSeat_Toggled(sender As Object, e As EventArgs) Handles tsPaddingSeat.Toggled
        If CBool(tsPaddingSeat.EditValue) = True And icbPaddingSeat.Properties.Items.Count > 0 Then
            icbPaddingSeat.Enabled = True
            DxValidationProvider1.SetValidationRule(icbPaddingSeat, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbPaddingSeat.Enabled = False
            DxValidationProvider1.SetValidationRule(icbPaddingSeat, Nothing)
        End If
    End Sub

    Private Sub tsRearHandle_Toggled(sender As Object, e As EventArgs) Handles tsRearHandle.Toggled
        If CBool(tsRearHandle.EditValue) = True And icbRearHandle.Properties.Items.Count > 0 Then
            icbRearHandle.Enabled = True
            DxValidationProvider1.SetValidationRule(icbRearHandle, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbRearHandle.Enabled = False
            DxValidationProvider1.SetValidationRule(icbRearHandle, Nothing)
        End If
    End Sub

    Private Sub tsKickstandGasSpring_Toggled(sender As Object, e As EventArgs) Handles tsKickstandGasSpring.Toggled
        If CBool(tsKickstandGasSpring.EditValue) = True And icbKickstandGasSpring.Properties.Items.Count > 0 Then
            icbKickstandGasSpring.Enabled = True
            DxValidationProvider1.SetValidationRule(icbKickstandGasSpring, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbKickstandGasSpring.Enabled = False
            DxValidationProvider1.SetValidationRule(icbKickstandGasSpring, Nothing)
        End If
    End Sub

    Private Sub tsSkiAssemblyRollers_Toggled(sender As Object, e As EventArgs) Handles tsSkiAssemblyRollers.Toggled
        If CBool(tsSkiAssemblyRollers.EditValue) = True And icbSkiAssemblyRollers.Properties.Items.Count > 0 Then
            icbSkiAssemblyRollers.Enabled = True
            DxValidationProvider1.SetValidationRule(icbSkiAssemblyRollers, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbSkiAssemblyRollers.Enabled = False

            DxValidationProvider1.SetValidationRule(icbSkiAssemblyRollers, Nothing)
        End If
    End Sub

    Private Sub tsSafetyBelt_Toggled(sender As Object, e As EventArgs) Handles tsSafetyBelt.Toggled
        If CBool(tsSafetyBelt.EditValue) = True And icbSafetyBelt.Properties.Items.Count > 0 Then
            icbSafetyBelt.Enabled = True
            DxValidationProvider1.SetValidationRule(icbSafetyBelt, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbSafetyBelt.Enabled = False
            DxValidationProvider1.SetValidationRule(icbSafetyBelt, Nothing)

        End If
    End Sub

    Private Sub tsKickstandBolt_Toggled(sender As Object, e As EventArgs) Handles tsKickstandBolt.Toggled
        If CBool(tsKickstandBolt.EditValue) = True And icbKickstandBolt.Properties.Items.Count > 0 Then
            icbKickstandBolt.Enabled = True
            DxValidationProvider1.SetValidationRule(icbKickstandBolt, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbKickstandBolt.Enabled = False
            DxValidationProvider1.SetValidationRule(icbKickstandBolt, Nothing)

        End If
    End Sub

    Private Sub tsStabiliserRivets_Toggled(sender As Object, e As EventArgs) Handles tsStabiliserRivets.Toggled
        If CBool(tsStabiliserRivets.EditValue) = True And icbStabiliserRivets.Properties.Items.Count > 0 Then
            icbStabiliserRivets.Enabled = True
            DxValidationProvider1.SetValidationRule(icbStabiliserRivets, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbStabiliserRivets.Enabled = False
            DxValidationProvider1.SetValidationRule(icbStabiliserRivets, Nothing)

        End If
    End Sub

    Private Sub tsSeatRivets_Toggled(sender As Object, e As EventArgs) Handles tsSeatRivets.Toggled
        If CBool(tsSeatRivets.EditValue) = True And icbSeatRivets.Properties.Items.Count > 0 Then
            icbSeatRivets.Enabled = True
            DxValidationProvider1.SetValidationRule(icbSeatRivets, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbSeatRivets.Enabled = False
            DxValidationProvider1.SetValidationRule(icbSeatRivets, Nothing)

        End If
    End Sub

    Private Sub tsFrontHandle_Toggled(sender As Object, e As EventArgs) Handles tsFrontHandle.Toggled
        If CBool(tsFrontHandle.EditValue) = True And icbFrontHandle.Properties.Items.Count > 0 Then
            icbFrontHandle.Enabled = True
            DxValidationProvider1.SetValidationRule(icbFrontHandle, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbFrontHandle.Enabled = False
            DxValidationProvider1.SetValidationRule(icbFrontHandle, Nothing)

        End If
    End Sub

    Private Sub tsHammockCondition_Toggled(sender As Object, e As EventArgs) Handles tsHammockCondition.Toggled
        If CBool(tsHammockCondition.EditValue) = True And icbHammockCondition.Properties.Items.Count > 0 Then
            icbHammockCondition.Enabled = True
            DxValidationProvider1.SetValidationRule(icbHammockCondition, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbHammockCondition.Enabled = False
            DxValidationProvider1.SetValidationRule(icbHammockCondition, Nothing)
        End If
    End Sub

    Private Sub tsRotationBelts_Toggled(sender As Object, e As EventArgs) Handles tsRotationBelts.Toggled
        If CBool(tsRotationBelts.EditValue) = True And icbRotationBelts.Properties.Items.Count > 0 Then
            icbRotationBelts.Enabled = True
            DxValidationProvider1.SetValidationRule(icbRotationBelts, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbRotationBelts.Enabled = False
            DxValidationProvider1.SetValidationRule(icbRotationBelts, Nothing)
        End If
    End Sub

    Private Sub tsSpindlePosition_Toggled(sender As Object, e As EventArgs) Handles tsSpindlePosition.Toggled
        If CBool(tsSpindlePosition.EditValue) = True And icbSpindlePosition.Properties.Items.Count > 0 Then
            icbSpindlePosition.Enabled = True
            DxValidationProvider1.SetValidationRule(icbSpindlePosition, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbSpindlePosition.Enabled = False
            DxValidationProvider1.SetValidationRule(icbSpindlePosition, Nothing)

        End If
    End Sub

    Private Sub tsSeatFrame_Toggled(sender As Object, e As EventArgs) Handles tsSeatFrame.Toggled
        If CBool(tsSeatFrame.EditValue) = True And icbSeatFrame.Properties.Items.Count > 0 Then
            icbSeatFrame.Enabled = True
            DxValidationProvider1.SetValidationRule(icbSeatFrame, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbSeatFrame.Enabled = False
            DxValidationProvider1.SetValidationRule(icbSeatFrame, Nothing)
        End If
    End Sub

    Private Sub tsKickstandGas_Toggled(sender As Object, e As EventArgs) Handles tsKickstandGas.Toggled
        If CBool(tsKickstandGas.EditValue) = True And icbKickstandGas.Properties.Items.Count > 0 Then
            icbKickstandGas.Enabled = True
            DxValidationProvider1.SetValidationRule(icbKickstandGas, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbKickstandGas.Enabled = False
            DxValidationProvider1.SetValidationRule(icbKickstandGas, Nothing)
        End If
    End Sub

    Private Sub tsClosure_Toggled(sender As Object, e As EventArgs) Handles tsClosure.Toggled
        If CBool(tsClosure.EditValue) = True And icbClosure.Properties.Items.Count > 0 Then
            icbClosure.Enabled = True
            DxValidationProvider1.SetValidationRule(icbClosure, ValidationRulesHelper.RuleIsNotBlank)
        Else
            icbClosure.Enabled = False
            DxValidationProvider1.SetValidationRule(icbClosure, Nothing)
        End If
    End Sub
End Class
