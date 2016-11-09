Imports DevExpress.Xpo
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.Helpers
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors
Imports Esso.Data
Imports DevExpress.Utils

Public Class AssetServiceHistory
    Private _parent As frmMain = Nothing
    Private _Loaded As Boolean = False

    Private _session As UnitOfWork
    Private xpOptions As XPCollection(Of FieldOption)
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
    Public Sub Initdata()
        InitEditors()

        lueBuilding.EditValue = _currentAsset.Building
        lueEscapeRoute.EditValue = _currentAsset.EscapeRoute
        lueFloor.EditValue = _currentAsset.Floor
        lueProduct.EditValue = _currentAsset.Product

        grdServices.DataSource = _currentAsset.ChairServices

        'tsSpringClips
        'tsSeatRivets
        'tsPaddingSeat
        'tsFrontHandle
        'tsRearHandle
        'tsHammockCondition
        'tsKickstandGasSpring
        'tsRotationBelts
        'tsSkiAssemblyRollers
        'tsSpindlePosition
        'tsSafetyBelt
        'tsSeatFrame
        'tsKickstandBolt
        'tsKickstandGas
        'tsStabiliserRivets
        'tsClosure

        teNotes.Text = _currentAsset.Notes

    End Sub

    Public Sub New(ByVal session As UnitOfWork, ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = session
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        If Not DxValidationProvider1.Validate() Then
            XtraMessageBox.Show("Please supply missing information.", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        _currentAsset.Building = lueBuilding.EditValue
        _currentAsset.EscapeRoute = lueEscapeRoute.EditValue
        _currentAsset.Floor = lueFloor.EditValue
        _currentAsset.Product = lueProduct.EditValue
        _currentAsset.Notes = teNotes.Text
        _currentAsset.Save()
        _currentAsset.Session.CommitTransaction()
        '    ParentService.RefreshAsset()
        _parent.SelectPage(frmMain.ePage.ServiceDetail)
    End Sub
    Private Sub InitEditors()
        CreateBuildingLookUpEdit(_session, lueBuilding.Properties, Nothing, _currentDivision.Oid)
        CreateProductLookUpEdit(_session, lueProduct.Properties, Nothing)

    End Sub
    Private Sub lueBuilding_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles lueBuilding.ButtonClick
        If e.Button.Kind = ButtonPredefines.Plus Then
            Dim nBuilding As New Building(_session)
            nBuilding.Location = String.Format("Building {0}", xpBuildings.Count + 1)
            nBuilding.Heritage = "No"
            nBuilding.Access = "Private"
            nBuilding.Save()
            _session.CommitChanges()
            xpBuildings.Add(nBuilding)
            lueBuilding.Properties.DataSource = xpBuildings

            lueBuilding.EditValue = xpBuildings.Last
            lueBuilding.Properties.DropDownRows = Math.Min(xpBuildings.Count, 9)
        ElseIf e.Button.Kind = ButtonPredefines.DropDown Then

        ElseIf e.Button.Kind = ButtonPredefines.Delete Then
        End If
    End Sub

    Private Sub lueBuilding_EditValueChanged(sender As Object, e As EventArgs) Handles lueBuilding.EditValueChanged

        CreateEscapeRouteLookUpEdit(_session, lueEscapeRoute.Properties, Nothing, TryCast(lueBuilding.EditValue, Building).Oid)
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
End Class
