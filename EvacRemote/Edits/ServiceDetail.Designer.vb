<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiceDetail))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SignatureBox1 = New EvacRemote.SignatureBox()
        Me.btnConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNewStairWell = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_assets = New DevExpress.XtraGrid.GridControl()
        Me.view_Assets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAssetId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstalled = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lciAssets = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.lciAddAsset = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.grid_assets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.view_Assets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciAddAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SignatureBox1)
        Me.LayoutControl1.Controls.Add(Me.btnConfirm)
        Me.LayoutControl1.Controls.Add(Me.btnNewStairWell)
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
        'SignatureBox1
        '
        Me.SignatureBox1.Image = CType(resources.GetObject("SignatureBox1.Image"), System.Drawing.Bitmap)
        Me.SignatureBox1.Location = New System.Drawing.Point(111, 454)
        Me.SignatureBox1.Name = "SignatureBox1"
        Me.SignatureBox1.Size = New System.Drawing.Size(793, 20)
        Me.SignatureBox1.TabIndex = 16
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(839, 428)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(65, 22)
        Me.btnConfirm.StyleController = Me.LayoutControl1
        Me.btnConfirm.TabIndex = 15
        Me.btnConfirm.Text = "Confirm"
        '
        'btnNewStairWell
        '
        Me.btnNewStairWell.Image = CType(resources.GetObject("btnNewStairWell.Image"), System.Drawing.Image)
        Me.btnNewStairWell.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNewStairWell.Location = New System.Drawing.Point(858, 12)
        Me.btnNewStairWell.Name = "btnNewStairWell"
        Me.btnNewStairWell.Size = New System.Drawing.Size(46, 38)
        Me.btnNewStairWell.StyleController = Me.LayoutControl1
        Me.btnNewStairWell.TabIndex = 14
        '
        'grid_assets
        '
        Me.grid_assets.Cursor = System.Windows.Forms.Cursors.Default
        Me.grid_assets.Location = New System.Drawing.Point(52, 54)
        Me.grid_assets.MainView = Me.view_Assets
        Me.grid_assets.Name = "grid_assets"
        Me.grid_assets.ShowOnlyPredefinedDetails = True
        Me.grid_assets.Size = New System.Drawing.Size(852, 370)
        Me.grid_assets.TabIndex = 13
        Me.grid_assets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.view_Assets})
        '
        'view_Assets
        '
        Me.view_Assets.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAssetId, Me.colBarCode, Me.colProduct, Me.colInstalled})
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
        'colProduct
        '
        Me.colProduct.Caption = "Product"
        Me.colProduct.FieldName = "Product"
        Me.colProduct.Name = "colProduct"
        Me.colProduct.Visible = True
        Me.colProduct.VisibleIndex = 1
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
        Me.colInstalled.VisibleIndex = 2
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.lciAssets, Me.SimpleLabelItem3, Me.lciAddAsset, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(916, 486)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(40, 416)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lciAssets
        '
        Me.lciAssets.Control = Me.grid_assets
        Me.lciAssets.CustomizationFormText = "lciAssets"
        Me.lciAssets.Location = New System.Drawing.Point(40, 42)
        Me.lciAssets.Name = "lciAssets"
        Me.lciAssets.Size = New System.Drawing.Size(856, 374)
        Me.lciAssets.TextSize = New System.Drawing.Size(0, 0)
        Me.lciAssets.TextVisible = False
        '
        'SimpleLabelItem3
        '
        Me.SimpleLabelItem3.AllowHotTrack = False
        Me.SimpleLabelItem3.CustomizationFormText = "LabelSimpleLabelItem3"
        Me.SimpleLabelItem3.Location = New System.Drawing.Point(40, 0)
        Me.SimpleLabelItem3.Name = "SimpleLabelItem3"
        Me.SimpleLabelItem3.Size = New System.Drawing.Size(806, 42)
        Me.SimpleLabelItem3.Text = "Service Details"
        Me.SimpleLabelItem3.TextSize = New System.Drawing.Size(96, 13)
        '
        'lciAddAsset
        '
        Me.lciAddAsset.Control = Me.btnNewStairWell
        Me.lciAddAsset.CustomizationFormText = "LayoutControlItem3"
        Me.lciAddAsset.Location = New System.Drawing.Point(846, 0)
        Me.lciAddAsset.Name = "lciAddAsset"
        Me.lciAddAsset.Size = New System.Drawing.Size(50, 42)
        Me.lciAddAsset.TextSize = New System.Drawing.Size(0, 0)
        Me.lciAddAsset.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnConfirm
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(827, 416)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(69, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 416)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(827, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SignatureBox1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 442)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(896, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(96, 13)
        '
        'ServiceDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ServiceDetail"
        Me.Size = New System.Drawing.Size(916, 486)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.grid_assets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.view_Assets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciAssets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciAddAsset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnNewStairWell As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_assets As DevExpress.XtraGrid.GridControl
    Friend WithEvents view_Assets As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAssetId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBarCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstalled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lciAssets As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lciAddAsset As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SignatureBox1 As EvacRemote.SignatureBox
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

End Class
