﻿Imports DevExpress.Xpo
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.Helpers
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors
Imports Esso.Data
Imports DevExpress.Utils

Public Class AssetServiceHistory
    Private _parent As frmMain = Nothing

    Private _session As UnitOfWork
    Private xpOptions As XPCollection(Of FieldOption)

    Private _binding As Boolean = False
    Private _changed As Boolean = False

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
    Public Sub Initdata()
        InitEditors()
        _changed = False
        _binding = True

        lueBuilding.EditValue = _currentAsset.Building
        lueEscapeRoute.EditValue = _currentAsset.EscapeRoute
        lueFloor.EditValue = _currentAsset.Floor
        lueProduct.EditValue = _currentAsset.Product

        grdServices.DataSource = _currentAsset.ChairServices

        teNotes.Text = _currentAsset.Notes

    End Sub

    Public Sub New(ByVal session As UnitOfWork, ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = session
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub SaveData()
        _currentAsset.Building = lueBuilding.EditValue
        _currentAsset.EscapeRoute = lueEscapeRoute.EditValue
        _currentAsset.Floor = lueFloor.EditValue
        _currentAsset.Product = lueProduct.EditValue
        _currentAsset.Notes = teNotes.Text
        _currentAsset.Save()
        _currentAsset.Session.CommitTransaction()
    End Sub


    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        If Not DxValidationProvider1.Validate() Then
            XtraMessageBox.Show("Please supply missing information.", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If _changed = True Then
            Dim _save As DialogResult = XtraMessageBox.Show(Me, "Save Changes?", "Save", MessageBoxButtons.YesNoCancel)
            If _save = DialogResult.Cancel Then
                Exit Sub
            End If
            If _save = DialogResult.Yes Then
                SaveData()
            Else
                _currentAsset.Reload()
            End If
        End If
        _parent.SelectPage(frmMain.ePage.ServiceDetail)
    End Sub
    Private Sub InitEditors()
        CreateBuildingLookUpEdit(_session, lueBuilding.Properties, Nothing, False, _currentDivision.Oid)
        'CreateEscapeRouteLookUpEdit(_session, lueEscapeRoute.Properties, Nothing, False, CurrentBuilding.Oid)
        CreateProductLookUpEdit(_session, lueProduct.Properties, Nothing)
        AddHandler lueBuilding.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler lueEscapeRoute.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teBarCode.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler lueProduct.EditValueChanged, AddressOf edit_EditValueChanged

    End Sub
    Private ReadOnly Property CurrentBuilding() As Building
        Get
            If Object.Equals(lueBuilding.EditValue, Nothing) Then
                Return Nothing
            End If
            Return TryCast(lueBuilding.EditValue, Building)
        End Get
    End Property
    Private ReadOnly Property CurrentEscapeRoute() As EscapeRoute
        Get
            If Object.Equals(lueEscapeRoute.EditValue, Nothing) Then
                Return Nothing
            End If
            Return TryCast(lueEscapeRoute.EditValue, EscapeRoute)
        End Get
    End Property
    Private Sub lueBuilding_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles lueBuilding.ButtonClick
        If e.Button.Kind = ButtonPredefines.Plus Then
            Dim _building As New Building(_session)
            _building.Location = String.Format("Building {0}", _currentDivision.Buildings.Count + 1)
            _building.Heritage = "No"
            _building.Access = "Private"
            _building.Save()
            _session.CommitChanges()
            '  xpBuildings.Add(_building)

            CreateBuildingLookUpEdit(_session, lueBuilding.Properties, Nothing, False, _currentDivision.Oid)

            lueBuilding.EditValue = _building
            _currentAsset.Building = _building
        ElseIf e.Button.Kind = ButtonPredefines.Delete Then
        End If
    End Sub

    Private Sub lueBuilding_EditValueChanged(sender As Object, e As EventArgs) Handles lueBuilding.EditValueChanged

        CreateEscapeRouteLookUpEdit(_session, lueEscapeRoute.Properties, Nothing, CurrentBuilding.Oid)
    End Sub

    Private Sub lueEscapeRoute_EditValueChanged(sender As Object, e As EventArgs) Handles lueEscapeRoute.EditValueChanged
        CreateFloorLookUpEdit(_session, lueFloor.Properties, Nothing, TryCast(lueEscapeRoute.EditValue, EscapeRoute).Oid)
    End Sub

    Private ReadOnly Property CurrentService() As ChairService
        Get
            If Object.Equals(vw_Services, Nothing) OrElse vw_Services.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            Return TryCast(vw_Services.GetRow(vw_Services.FocusedRowHandle), ChairService)
        End Get
    End Property

    Private Sub vw_Services_Click(sender As Object, e As EventArgs) Handles vw_Services.Click
        If CurrentService IsNot Nothing Then
            _currentChairservice = CurrentService
            ParentFormMain.SelectPage(frmMain.ePage.AssetChairService)
            vw_Services.RefreshData()
        End If
    End Sub

    Private Sub lueEscapeRoute_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles lueEscapeRoute.ButtonClick
        If e.Button.Kind = ButtonPredefines.Plus Then
            Dim _escapeRoute As New EscapeRoute(_session)
            _escapeRoute.Location = String.Format("EscapeRoute {0}", CurrentBuilding.EscapeRoutes.Count + 1)
            _escapeRoute.Building = CurrentBuilding
            _escapeRoute.NoFloors = 0
            _escapeRoute.Save()
            _session.CommitChanges()

            CreateEscapeRouteLookUpEdit(_session, lueEscapeRoute.Properties, Nothing, CurrentBuilding.Oid)
            lueEscapeRoute.EditValue = _escapeRoute
            _currentAsset.EscapeRoute = _escapeRoute
        ElseIf e.Button.Kind = ButtonPredefines.Delete Then
        End If
    End Sub

    Private Sub lueBuilding_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles lueBuilding.ProcessNewValue
        Dim _name As String = e.DisplayValue.ToString
        If XtraMessageBox.Show(Me, "Update Building Name ?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim _building As Building = TryCast(lueBuilding.EditValue, Building)
            _building.Location = lueBuilding.Text
            _building.Save()
            _session.CommitChanges()
            e.Handled = True
        End If
    End Sub

    Private Sub lueEscapeRoute_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles lueEscapeRoute.ProcessNewValue
        Dim _name As String = e.DisplayValue.ToString
        If XtraMessageBox.Show(Me, "Update Escapre Route Name?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim _escapeRoute As EscapeRoute = TryCast(lueEscapeRoute.EditValue, EscapeRoute)
            _escapeRoute.Location = lueEscapeRoute.Text
            _escapeRoute.Save()
            _session.CommitChanges()
            _currentAsset.EscapeRoute = _escapeRoute
            e.Handled = True
        End If
    End Sub

    Private Sub lueFloor_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles lueFloor.ButtonClick
        If e.Button.Kind = ButtonPredefines.Plus Then
            Dim _floor As New Floor(_session)
            _floor.Location = String.Format("Floor {0}", CurrentEscapeRoute.Floors.Count + 1)
            _floor.Building = CurrentBuilding
            _floor.EscapeRoute = CurrentEscapeRoute
            _floor.Save()
            _session.CommitChanges()
            CreateFloorLookUpEdit(_session, lueFloor.Properties, Nothing, CurrentEscapeRoute.Oid)
            lueFloor.EditValue = _floor
            _currentAsset.Floor = _floor
        ElseIf e.Button.Kind = ButtonPredefines.Delete Then
        End If
    End Sub

    Private Sub lueFloor_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles lueFloor.ProcessNewValue
        Dim _name As String = e.DisplayValue.ToString
        If XtraMessageBox.Show(Me, "Update Floor Name ?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim _floor As Floor = TryCast(lueFloor.EditValue, Floor)
            _floor.Location = _name
            _floor.Save()
            _session.CommitChanges()
            _currentAsset.Floor = _floor
            e.Handled = True
        End If
    End Sub
    Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If _binding = False Then
            _changed = True
        End If
    End Sub
End Class
