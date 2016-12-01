<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewServiceDetail
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkNoAccess = New DevExpress.XtraEditors.CheckEdit()
        Me.dteServiceDate = New DevExpress.XtraEditors.DateEdit()
        Me.btnComplete = New DevExpress.XtraEditors.SimpleButton()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.btnConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_assets = New DevExpress.XtraGrid.GridControl()
        Me.view_Assets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAssetId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuilding = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEscapeRoute = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFloor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstalled = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciAssets = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lciPicBack = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciServiceDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkNoAccess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteServiceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteServiceDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_assets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.view_Assets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPicBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciServiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnPrint)
        Me.LayoutControl1.Controls.Add(Me.chkNoAccess)
        Me.LayoutControl1.Controls.Add(Me.dteServiceDate)
        Me.LayoutControl1.Controls.Add(Me.btnComplete)
        Me.LayoutControl1.Controls.Add(Me.picBack)
        Me.LayoutControl1.Controls.Add(Me.btnConfirm)
        Me.LayoutControl1.Controls.Add(Me.grid_assets)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(684, 166, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(916, 486)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkNoAccess
        '
        Me.chkNoAccess.Location = New System.Drawing.Point(525, 12)
        Me.chkNoAccess.Name = "chkNoAccess"
        Me.chkNoAccess.Properties.Caption = "No Access"
        Me.chkNoAccess.Size = New System.Drawing.Size(157, 19)
        Me.chkNoAccess.StyleController = Me.LayoutControl1
        Me.chkNoAccess.TabIndex = 20
        '
        'dteServiceDate
        '
        Me.dteServiceDate.EditValue = Nothing
        Me.dteServiceDate.Location = New System.Drawing.Point(337, 12)
        Me.dteServiceDate.Name = "dteServiceDate"
        Me.dteServiceDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteServiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteServiceDate.Size = New System.Drawing.Size(184, 20)
        Me.dteServiceDate.StyleController = Me.LayoutControl1
        Me.dteServiceDate.TabIndex = 19
        '
        'btnComplete
        '
        Me.btnComplete.Location = New System.Drawing.Point(686, 12)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(137, 22)
        Me.btnComplete.StyleController = Me.LayoutControl1
        Me.btnComplete.TabIndex = 18
        Me.btnComplete.Text = "Sign Off"
        '
        'picBack
        '
        Me.picBack.Image = Global.EvacRemote.My.Resources.Resources.returnButton
        Me.picBack.Location = New System.Drawing.Point(20, 30)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(31, 436)
        Me.picBack.TabIndex = 17
        Me.picBack.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(703, 452)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(201, 22)
        Me.btnConfirm.StyleController = Me.LayoutControl1
        Me.btnConfirm.TabIndex = 15
        Me.btnConfirm.Text = "Confirm"
        '
        'grid_assets
        '
        Me.grid_assets.Cursor = System.Windows.Forms.Cursors.Default
        Me.grid_assets.Location = New System.Drawing.Point(63, 38)
        Me.grid_assets.MainView = Me.view_Assets
        Me.grid_assets.Name = "grid_assets"
        Me.grid_assets.ShowOnlyPredefinedDetails = True
        Me.grid_assets.Size = New System.Drawing.Size(841, 410)
        Me.grid_assets.TabIndex = 13
        Me.grid_assets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.view_Assets})
        '
        'view_Assets
        '
        Me.view_Assets.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAssetId, Me.colBarCode, Me.colBuilding, Me.colEscapeRoute, Me.colFloor, Me.colProduct, Me.colInstalled})
        Me.view_Assets.GridControl = Me.grid_assets
        Me.view_Assets.Name = "view_Assets"
        Me.view_Assets.OptionsBehavior.Editable = False
        Me.view_Assets.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.view_Assets.OptionsView.ShowGroupPanel = False
        '
        'colAssetId
        '
        Me.colAssetId.Caption = "ID"
        Me.colAssetId.FieldName = "ID"
        Me.colAssetId.Name = "colAssetId"
        '
        'colBarCode
        '
        Me.colBarCode.Caption = "BarCode"
        Me.colBarCode.FieldName = "BarCode"
        Me.colBarCode.Name = "colBarCode"
        Me.colBarCode.OptionsColumn.AllowSize = False
        Me.colBarCode.OptionsColumn.FixedWidth = True
        Me.colBarCode.Visible = True
        Me.colBarCode.VisibleIndex = 0
        Me.colBarCode.Width = 120
        '
        'colBuilding
        '
        Me.colBuilding.Caption = "Building"
        Me.colBuilding.FieldName = "Building.Location"
        Me.colBuilding.Name = "colBuilding"
        Me.colBuilding.Visible = True
        Me.colBuilding.VisibleIndex = 1
        '
        'colEscapeRoute
        '
        Me.colEscapeRoute.Caption = "EscapeRoute"
        Me.colEscapeRoute.FieldName = "EscapeRoute.Location"
        Me.colEscapeRoute.Name = "colEscapeRoute"
        Me.colEscapeRoute.Visible = True
        Me.colEscapeRoute.VisibleIndex = 2
        '
        'colFloor
        '
        Me.colFloor.Caption = "Floor"
        Me.colFloor.FieldName = "Floor.Location"
        Me.colFloor.Name = "colFloor"
        Me.colFloor.Visible = True
        Me.colFloor.VisibleIndex = 3
        '
        'colProduct
        '
        Me.colProduct.Caption = "Product"
        Me.colProduct.FieldName = "Product.Description"
        Me.colProduct.Name = "colProduct"
        Me.colProduct.Visible = True
        Me.colProduct.VisibleIndex = 4
        Me.colProduct.Width = 390
        '
        'colInstalled
        '
        Me.colInstalled.Caption = "Installed"
        Me.colInstalled.FieldName = "Installed"
        Me.colInstalled.Name = "colInstalled"
        Me.colInstalled.OptionsColumn.AllowSize = False
        Me.colInstalled.OptionsColumn.FixedWidth = True
        Me.colInstalled.Visible = True
        Me.colInstalled.VisibleIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciAssets, Me.SimpleLabelItem3, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.lciPicBack, Me.LayoutControlItem2, Me.lciServiceDate, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(916, 486)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lciAssets
        '
        Me.lciAssets.Control = Me.grid_assets
        Me.lciAssets.CustomizationFormText = "lciAssets"
        Me.lciAssets.Location = New System.Drawing.Point(51, 26)
        Me.lciAssets.Name = "lciAssets"
        Me.lciAssets.Size = New System.Drawing.Size(845, 414)
        Me.lciAssets.TextSize = New System.Drawing.Size(0, 0)
        Me.lciAssets.TextVisible = False
        '
        'SimpleLabelItem3
        '
        Me.SimpleLabelItem3.AllowHotTrack = False
        Me.SimpleLabelItem3.CustomizationFormText = "LabelSimpleLabelItem3"
        Me.SimpleLabelItem3.Location = New System.Drawing.Point(51, 0)
        Me.SimpleLabelItem3.Name = "SimpleLabelItem3"
        Me.SimpleLabelItem3.Size = New System.Drawing.Size(211, 26)
        Me.SimpleLabelItem3.Text = "Service Details"
        Me.SimpleLabelItem3.TextSize = New System.Drawing.Size(70, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnConfirm
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(691, 440)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(205, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(51, 440)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(640, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'lciPicBack
        '
        Me.lciPicBack.Control = Me.picBack
        Me.lciPicBack.Location = New System.Drawing.Point(0, 0)
        Me.lciPicBack.MinSize = New System.Drawing.Size(50, 24)
        Me.lciPicBack.Name = "lciPicBack"
        Me.lciPicBack.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 20, 10)
        Me.lciPicBack.Size = New System.Drawing.Size(51, 466)
        Me.lciPicBack.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciPicBack.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lciPicBack.TextSize = New System.Drawing.Size(0, 0)
        Me.lciPicBack.TextToControlDistance = 0
        Me.lciPicBack.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnComplete
        Me.LayoutControlItem2.Location = New System.Drawing.Point(674, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(141, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'lciServiceDate
        '
        Me.lciServiceDate.Control = Me.dteServiceDate
        Me.lciServiceDate.Location = New System.Drawing.Point(262, 0)
        Me.lciServiceDate.Name = "lciServiceDate"
        Me.lciServiceDate.Size = New System.Drawing.Size(251, 26)
        Me.lciServiceDate.Text = "ServiceDate"
        Me.lciServiceDate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lciServiceDate.TextSize = New System.Drawing.Size(58, 13)
        Me.lciServiceDate.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkNoAccess
        Me.LayoutControlItem3.Location = New System.Drawing.Point(513, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(161, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(827, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(77, 22)
        Me.btnPrint.StyleController = Me.LayoutControl1
        Me.btnPrint.TabIndex = 21
        Me.btnPrint.Text = "Print"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnPrint
        Me.LayoutControlItem4.Location = New System.Drawing.Point(815, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(81, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'ViewServiceDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ViewServiceDetail"
        Me.Size = New System.Drawing.Size(916, 486)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkNoAccess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteServiceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteServiceDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_assets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.view_Assets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciAssets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPicBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciServiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grid_assets As DevExpress.XtraGrid.GridControl
    Friend WithEvents view_Assets As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAssetId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBarCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstalled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lciAssets As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents btnConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents picBack As System.Windows.Forms.PictureBox
    Friend WithEvents lciPicBack As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkNoAccess As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dteServiceDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnComplete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciServiceDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colBuilding As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEscapeRoute As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFloor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
