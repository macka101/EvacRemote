Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.LookAndFeel
Imports Esso.Data

Public Class ViewServiceDetail


    Private xpBuildings As XPCollection(Of Building)
    Private xpStairWells As XPCollection(Of EscapeRoute)
    Private xpAssets As XPCollection(Of Asset)

    Private _parent As frmMain = Nothing
    Private _session As UnitOfWork
    Private bNewBuilding As Boolean = False
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
    Public Sub InitEditors()
        AddHandler dteServiceDate.EditValueChanged, AddressOf edit_EditValueChanged
    End Sub
    Public Sub Initdata()

        '        xpBuildings = New XPCollection(Of Building)(_session, (CriteriaOperator.Parse("Division = ?", iDivison)), New DevExpress.Xpo.SortProperty("[Building]", DevExpress.Xpo.DB.SortingDirection.Ascending))
        '       xpStairWells = New XPCollection(Of EscapeRoute)(_session, (CriteriaOperator.Parse("Division = ?", iDivison)), New DevExpress.Xpo.SortProperty("[Floor]", DevExpress.Xpo.DB.SortingDirection.Ascending))
        '      xpAssets = New XPCollection(Of Asset)(_session, (CriteriaOperator.Parse("Division = ?", iDivison)), New DevExpress.Xpo.SortProperty("[Product]", DevExpress.Xpo.DB.SortingDirection.Ascending))
        InitEditors()
        _changed = False
        _binding = True

        dteServiceDate.DateTime = _currentService.ServiceDate
        grid_assets.DataSource = _currentDivision.Assets
        _binding = False
        LayoutControl1.FocusHelper.FocusFirstInGroup(LayoutControlGroup1, False)

    End Sub
    Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If _binding = False Then
            _changed = True
        End If
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = session
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private ReadOnly Property CurrentAsset() As Asset
        Get
            If Object.Equals(view_Assets, Nothing) OrElse view_Assets.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            Return TryCast(view_Assets.GetRow(view_Assets.FocusedRowHandle), Asset)
        End Get
    End Property
    Public Sub RefreshAsset()
        xpAssets.Reload()
    End Sub

    Private Sub view_Assets_Click(sender As Object, e As EventArgs) Handles view_Assets.Click
        If CurrentAsset IsNot Nothing Then
            _currentAsset = CurrentAsset
            ParentFormMain.SelectPage(frmMain.ePage.AssetServiceHistory)

            '   If CurrentAsset.ProductType = ProductType.Chair Then
            '  ParentFormMain.ViewServiceChair(Me, gCurrentAsset)
            'else
            ' ParentFormMain.ViewServiceIbex(Me, gCurrentAsset)
            'End If

            view_Assets.RefreshData()
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        '     Dim pservice = _session.GetObjectByKey(Of EvacService)(2)
        Using frmSig As New frmSignature(_currentService)
            frmSig.ShowDialog()
        End Using

        _currentService.Save()
        _session.CommitChanges()
        Cursor.Current = Cursors.WaitCursor
        Dim report As XtraReport = Nothing

        '  report = New rptServiceReport(_session, 2)

        Cursor.Current = Cursors.Default
        Using printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreviewDialog()
            printTool.ShowRibbonPreview(UserLookAndFeel.Default)
        End Using
    End Sub

    Private Sub btnNewStairWell_Click(sender As Object, e As EventArgs)
        _currentAsset = New Asset(_session)
        ParentFormMain.SelectPage(frmMain.ePage.AssetChairService)
    End Sub
    Private Sub SaveData()
        _currentService.ServiceDate = dteServiceDate.DateTime
        _currentService.Save()
        _session.CommitChanges()
    End Sub
    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click

        If _changed = True Then
            Dim _save As DialogResult = XtraMessageBox.Show(Me, "Save Changes?", "Save", MessageBoxButtons.YesNoCancel)
            If _save = DialogResult.Cancel Then
                Exit Sub
            End If
            If _save = DialogResult.Yes Then
                SaveData()
            Else
                _currentService.Reload()
            End If
        End If
        ParentFormMain.SelectPage(frmMain.ePage.ContactDetail)
    End Sub
End Class
