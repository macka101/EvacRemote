<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductListSwipe
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductListSwipe))
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnView = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colProduct = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvDescription = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvDetails = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.layoutViewField_LayoutViewColumn3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvOrder = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.riOrder = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.layoutViewField_LayoutViewColumn1_3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvImage = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.layoutViewField_LayoutViewColumn4 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvVideo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.riVideo = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.layoutViewField_LayoutViewColumn1_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvPDF = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.riPdf = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.layoutViewField_LayoutViewColumn1_2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvLargeImage = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.riSmallImage = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.layoutViewField_LayoutViewColumn2_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.riLargeImage = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProdref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProddesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMemo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSmallImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPDF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLargeImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVideo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup1 = New DevExpress.XtraEditors.TileGroup()
        Me.tileEvacuationChairs = New DevExpress.XtraEditors.TileItem()
        Me.tilStairClimbers = New DevExpress.XtraEditors.TileItem()
        Me.tileAccessories = New DevExpress.XtraEditors.TileItem()
        Me.tileCardiaid = New DevExpress.XtraEditors.TileItem()
        Me.tileAids = New DevExpress.XtraEditors.TileItem()
        Me.tileAirChair = New DevExpress.XtraEditors.TileItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciTileControl = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SIProducts = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.lciProducts = New DevExpress.XtraLayout.LayoutControlItem()
        Me.hideButton = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DataSet1 = New EvacRemote.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RTFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WEBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riSmallImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riLargeImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTileControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hideButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnView)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.TileControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(984, 179, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(901, 570)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnView
        '
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.Location = New System.Drawing.Point(811, 12)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(78, 38)
        Me.btnView.StyleController = Me.LayoutControl1
        Me.btnView.TabIndex = 6
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.XpCollection1
        Me.GridControl1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GridControl1.Location = New System.Drawing.Point(234, 54)
        Me.GridControl1.MainView = Me.LayoutView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1, Me.RepositoryItemMemoEdit1, Me.riPdf, Me.riVideo, Me.riSmallImage, Me.riLargeImage, Me.RepositoryItemCalcEdit1, Me.riOrder})
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(655, 504)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ToolTipController = Me.ToolTipController1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LayoutView1, Me.GridView1})
        '
        'XpCollection1
        '
        Me.XpCollection1.LoadingEnabled = False
        Me.XpCollection1.ObjectType = GetType(EvacRemote.Product)
        '
        'LayoutView1
        '
        Me.LayoutView1.Appearance.Card.BorderColor = System.Drawing.Color.IndianRed
        Me.LayoutView1.Appearance.Card.Options.UseBorderColor = True
        Me.LayoutView1.Appearance.CardCaption.BackColor = System.Drawing.Color.Black
        Me.LayoutView1.Appearance.CardCaption.BackColor2 = System.Drawing.Color.Black
        Me.LayoutView1.Appearance.CardCaption.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LayoutView1.Appearance.CardCaption.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LayoutView1.Appearance.CardCaption.ForeColor = System.Drawing.Color.White
        Me.LayoutView1.Appearance.CardCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.LayoutView1.Appearance.CardCaption.Options.UseBackColor = True
        Me.LayoutView1.Appearance.CardCaption.Options.UseBorderColor = True
        Me.LayoutView1.Appearance.CardCaption.Options.UseFont = True
        Me.LayoutView1.Appearance.CardCaption.Options.UseForeColor = True
        Me.LayoutView1.Appearance.FieldCaption.BackColor = System.Drawing.Color.White
        Me.LayoutView1.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.LayoutView1.Appearance.FieldCaption.Options.UseBackColor = True
        Me.LayoutView1.Appearance.FieldCaption.Options.UseForeColor = True
        Me.LayoutView1.Appearance.FieldValue.BackColor = System.Drawing.Color.White
        Me.LayoutView1.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black
        Me.LayoutView1.Appearance.FieldValue.Options.UseBackColor = True
        Me.LayoutView1.Appearance.FieldValue.Options.UseForeColor = True
        Me.LayoutView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LayoutView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.LayoutView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LayoutView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.LayoutView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.LayoutView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.LayoutView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.LayoutView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.LayoutView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.LayoutView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.LayoutView1.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.Black
        Me.LayoutView1.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.Black
        Me.LayoutView1.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutView1.Appearance.FocusedCardCaption.Options.UseBackColor = True
        Me.LayoutView1.Appearance.FocusedCardCaption.Options.UseBorderColor = True
        Me.LayoutView1.Appearance.FocusedCardCaption.Options.UseForeColor = True
        Me.LayoutView1.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LayoutView1.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LayoutView1.Appearance.HideSelectionCardCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.LayoutView1.Appearance.HideSelectionCardCaption.Options.UseBackColor = True
        Me.LayoutView1.Appearance.HideSelectionCardCaption.Options.UseBorderColor = True
        Me.LayoutView1.Appearance.HideSelectionCardCaption.Options.UseForeColor = True
        Me.LayoutView1.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.LayoutView1.Appearance.SelectedCardCaption.BorderColor = System.Drawing.Color.Red
        Me.LayoutView1.Appearance.SelectedCardCaption.ForeColor = System.Drawing.Color.Black
        Me.LayoutView1.Appearance.SelectedCardCaption.Options.UseBackColor = True
        Me.LayoutView1.Appearance.SelectedCardCaption.Options.UseBorderColor = True
        Me.LayoutView1.Appearance.SelectedCardCaption.Options.UseForeColor = True
        Me.LayoutView1.Appearance.SelectionFrame.BackColor = System.Drawing.Color.Red
        Me.LayoutView1.Appearance.SelectionFrame.Options.UseBackColor = True
        Me.LayoutView1.Appearance.SeparatorLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LayoutView1.Appearance.SeparatorLine.Options.UseBackColor = True
        Me.LayoutView1.Appearance.ViewBackground.BackColor = System.Drawing.Color.White
        Me.LayoutView1.Appearance.ViewBackground.Options.UseBackColor = True
        Me.LayoutView1.CardCaptionFormat = "Ref: {2}"
        Me.LayoutView1.CardMinSize = New System.Drawing.Size(399, 387)
        Me.LayoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colProduct, Me.lvDescription, Me.lvDetails, Me.lvOrder, Me.lvImage, Me.lvVideo, Me.lvPDF, Me.lvLargeImage})
        Me.LayoutView1.GridControl = Me.GridControl1
        Me.LayoutView1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1, Me.layoutViewField_LayoutViewColumn2, Me.layoutViewField_LayoutViewColumn3})
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.LayoutView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.LayoutView1.OptionsBehavior.AllowExpandCollapse = False
        Me.LayoutView1.OptionsBehavior.AllowRuntimeCustomization = False
        Me.LayoutView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.LayoutView1.OptionsBehavior.Editable = False
        Me.LayoutView1.OptionsCustomization.AllowFilter = False
        Me.LayoutView1.OptionsCustomization.AllowSort = False
        Me.LayoutView1.OptionsView.AllowHotTrackFields = False
        Me.LayoutView1.OptionsView.ShowCardExpandButton = False
        Me.LayoutView1.OptionsView.ShowCardLines = False
        Me.LayoutView1.OptionsView.ShowFieldHints = False
        Me.LayoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.LayoutView1.OptionsView.ShowHeaderPanel = False
        Me.LayoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
        Me.LayoutView1.PaintStyleName = "Flat"
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        '
        'colProduct
        '
        Me.colProduct.Caption = "Ref"
        Me.colProduct.FieldName = "productCode"
        Me.colProduct.LayoutViewField = Me.layoutViewField_LayoutViewColumn1
        Me.colProduct.Name = "colProduct"
        Me.colProduct.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colProduct.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colProduct.OptionsFilter.AllowAutoFilter = False
        Me.colProduct.OptionsFilter.AllowFilter = False
        Me.colProduct.Tag = "PRODREF"
        '
        'layoutViewField_LayoutViewColumn1
        '
        Me.layoutViewField_LayoutViewColumn1.EditorPreferredWidth = 325
        Me.layoutViewField_LayoutViewColumn1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn1.Name = "layoutViewField_LayoutViewColumn1"
        Me.layoutViewField_LayoutViewColumn1.Size = New System.Drawing.Size(519, 70)
        Me.layoutViewField_LayoutViewColumn1.TextSize = New System.Drawing.Size(57, 13)
        '
        'lvDescription
        '
        Me.lvDescription.Caption = "Description"
        Me.lvDescription.FieldName = "shortDescription"
        Me.lvDescription.LayoutViewField = Me.layoutViewField_LayoutViewColumn2
        Me.lvDescription.Name = "lvDescription"
        Me.lvDescription.Tag = "DESCRIPTION"
        '
        'layoutViewField_LayoutViewColumn2
        '
        Me.layoutViewField_LayoutViewColumn2.EditorPreferredWidth = 325
        Me.layoutViewField_LayoutViewColumn2.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn2.Name = "layoutViewField_LayoutViewColumn2"
        Me.layoutViewField_LayoutViewColumn2.Size = New System.Drawing.Size(519, 70)
        Me.layoutViewField_LayoutViewColumn2.TextSize = New System.Drawing.Size(57, 13)
        '
        'lvDetails
        '
        Me.lvDetails.Caption = "Details"
        Me.lvDetails.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.lvDetails.FieldName = "description"
        Me.lvDetails.LayoutViewField = Me.layoutViewField_LayoutViewColumn3
        Me.lvDetails.Name = "lvDetails"
        Me.lvDetails.Tag = "DETAILS"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'layoutViewField_LayoutViewColumn3
        '
        Me.layoutViewField_LayoutViewColumn3.EditorPreferredWidth = 387
        Me.layoutViewField_LayoutViewColumn3.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn3.MaxSize = New System.Drawing.Size(391, 112)
        Me.layoutViewField_LayoutViewColumn3.MinSize = New System.Drawing.Size(391, 112)
        Me.layoutViewField_LayoutViewColumn3.Name = "layoutViewField_LayoutViewColumn3"
        Me.layoutViewField_LayoutViewColumn3.Size = New System.Drawing.Size(519, 70)
        Me.layoutViewField_LayoutViewColumn3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.layoutViewField_LayoutViewColumn3.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutViewField_LayoutViewColumn3.TextSize = New System.Drawing.Size(57, 13)
        '
        'lvOrder
        '
        Me.lvOrder.Caption = "Order"
        Me.lvOrder.ColumnEdit = Me.riOrder
        Me.lvOrder.FieldName = "Order"
        Me.lvOrder.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_3
        Me.lvOrder.Name = "lvOrder"
        Me.lvOrder.Tag = "ORDER"
        Me.lvOrder.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        '
        'riOrder
        '
        Me.riOrder.Name = "riOrder"
        '
        'layoutViewField_LayoutViewColumn1_3
        '
        Me.layoutViewField_LayoutViewColumn1_3.EditorPreferredWidth = 99
        Me.layoutViewField_LayoutViewColumn1_3.Location = New System.Drawing.Point(0, 322)
        Me.layoutViewField_LayoutViewColumn1_3.MaxSize = New System.Drawing.Size(0, 50)
        Me.layoutViewField_LayoutViewColumn1_3.MinSize = New System.Drawing.Size(24, 26)
        Me.layoutViewField_LayoutViewColumn1_3.Name = "layoutViewField_LayoutViewColumn1_3"
        Me.layoutViewField_LayoutViewColumn1_3.Size = New System.Drawing.Size(107, 38)
        Me.layoutViewField_LayoutViewColumn1_3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.layoutViewField_LayoutViewColumn1_3.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn1_3.TextVisible = False
        '
        'lvImage
        '
        Me.lvImage.Caption = "Image"
        Me.lvImage.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.lvImage.FieldName = "Image"
        Me.lvImage.Image = CType(resources.GetObject("lvImage.Image"), System.Drawing.Image)
        Me.lvImage.LayoutViewField = Me.layoutViewField_LayoutViewColumn4
        Me.lvImage.Name = "lvImage"
        Me.lvImage.Tag = "MEDIUMIMAGE"
        Me.lvImage.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'layoutViewField_LayoutViewColumn4
        '
        Me.layoutViewField_LayoutViewColumn4.EditorPreferredWidth = 375
        Me.layoutViewField_LayoutViewColumn4.Image = CType(resources.GetObject("layoutViewField_LayoutViewColumn4.Image"), System.Drawing.Image)
        Me.layoutViewField_LayoutViewColumn4.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn4.Name = "layoutViewField_LayoutViewColumn4"
        Me.layoutViewField_LayoutViewColumn4.Size = New System.Drawing.Size(395, 322)
        Me.layoutViewField_LayoutViewColumn4.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn4.TextVisible = False
        '
        'lvVideo
        '
        Me.lvVideo.Caption = "Video"
        Me.lvVideo.ColumnEdit = Me.riVideo
        Me.lvVideo.FieldName = "VIDEO"
        Me.lvVideo.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_1
        Me.lvVideo.Name = "lvVideo"
        Me.lvVideo.OptionsColumn.AllowSize = False
        Me.lvVideo.OptionsColumn.FixedWidth = True
        Me.lvVideo.OptionsField.SortFilterButtonShowMode = DevExpress.XtraGrid.Views.Layout.SortFilterButtonShowMode.Nowhere
        Me.lvVideo.OptionsFilter.AllowAutoFilter = False
        Me.lvVideo.OptionsFilter.AllowFilter = False
        Me.lvVideo.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[False]
        Me.lvVideo.Tag = "VIDEO"
        Me.lvVideo.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'riVideo
        '
        Me.riVideo.Name = "riVideo"
        Me.riVideo.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        '
        'layoutViewField_LayoutViewColumn1_1
        '
        Me.layoutViewField_LayoutViewColumn1_1.EditorPreferredWidth = 73
        Me.layoutViewField_LayoutViewColumn1_1.Location = New System.Drawing.Point(314, 322)
        Me.layoutViewField_LayoutViewColumn1_1.MaxSize = New System.Drawing.Size(0, 50)
        Me.layoutViewField_LayoutViewColumn1_1.MinSize = New System.Drawing.Size(24, 26)
        Me.layoutViewField_LayoutViewColumn1_1.Name = "layoutViewField_LayoutViewColumn1_1"
        Me.layoutViewField_LayoutViewColumn1_1.Size = New System.Drawing.Size(81, 38)
        Me.layoutViewField_LayoutViewColumn1_1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.layoutViewField_LayoutViewColumn1_1.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn1_1.TextVisible = False
        '
        'lvPDF
        '
        Me.lvPDF.Caption = "DATASHEET"
        Me.lvPDF.ColumnEdit = Me.riPdf
        Me.lvPDF.FieldName = "PDF"
        Me.lvPDF.Image = CType(resources.GetObject("lvPDF.Image"), System.Drawing.Image)
        Me.lvPDF.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_2
        Me.lvPDF.Name = "lvPDF"
        Me.lvPDF.OptionsFilter.AllowAutoFilter = False
        Me.lvPDF.OptionsFilter.AllowFilter = False
        Me.lvPDF.Tag = "DATASHEET"
        Me.lvPDF.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        '
        'riPdf
        '
        Me.riPdf.Name = "riPdf"
        Me.riPdf.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        '
        'layoutViewField_LayoutViewColumn1_2
        '
        Me.layoutViewField_LayoutViewColumn1_2.EditorPreferredWidth = 94
        Me.layoutViewField_LayoutViewColumn1_2.Image = CType(resources.GetObject("layoutViewField_LayoutViewColumn1_2.Image"), System.Drawing.Image)
        Me.layoutViewField_LayoutViewColumn1_2.Location = New System.Drawing.Point(212, 322)
        Me.layoutViewField_LayoutViewColumn1_2.MaxSize = New System.Drawing.Size(0, 50)
        Me.layoutViewField_LayoutViewColumn1_2.MinSize = New System.Drawing.Size(24, 26)
        Me.layoutViewField_LayoutViewColumn1_2.Name = "layoutViewField_LayoutViewColumn1_2"
        Me.layoutViewField_LayoutViewColumn1_2.Size = New System.Drawing.Size(102, 38)
        Me.layoutViewField_LayoutViewColumn1_2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.layoutViewField_LayoutViewColumn1_2.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn1_2.TextVisible = False
        '
        'lvLargeImage
        '
        Me.lvLargeImage.Caption = " "
        Me.lvLargeImage.ColumnEdit = Me.riSmallImage
        Me.lvLargeImage.CustomizationCaption = "Image"
        Me.lvLargeImage.FieldName = "LARGEIMAGE"
        Me.lvLargeImage.Image = CType(resources.GetObject("lvLargeImage.Image"), System.Drawing.Image)
        Me.lvLargeImage.LayoutViewField = Me.layoutViewField_LayoutViewColumn2_1
        Me.lvLargeImage.Name = "lvLargeImage"
        Me.lvLargeImage.OptionsFilter.AllowAutoFilter = False
        Me.lvLargeImage.OptionsFilter.AllowFilter = False
        Me.lvLargeImage.Tag = "LARGEIMAGE"
        Me.lvLargeImage.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'riSmallImage
        '
        Me.riSmallImage.Name = "riSmallImage"
        Me.riSmallImage.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        '
        'layoutViewField_LayoutViewColumn2_1
        '
        Me.layoutViewField_LayoutViewColumn2_1.EditorPreferredWidth = 97
        Me.layoutViewField_LayoutViewColumn2_1.Image = CType(resources.GetObject("layoutViewField_LayoutViewColumn2_1.Image"), System.Drawing.Image)
        Me.layoutViewField_LayoutViewColumn2_1.Location = New System.Drawing.Point(107, 322)
        Me.layoutViewField_LayoutViewColumn2_1.MaxSize = New System.Drawing.Size(0, 50)
        Me.layoutViewField_LayoutViewColumn2_1.MinSize = New System.Drawing.Size(24, 26)
        Me.layoutViewField_LayoutViewColumn2_1.Name = "layoutViewField_LayoutViewColumn2_1"
        Me.layoutViewField_LayoutViewColumn2_1.Size = New System.Drawing.Size(105, 38)
        Me.layoutViewField_LayoutViewColumn2_1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.layoutViewField_LayoutViewColumn2_1.TextLocation = DevExpress.Utils.Locations.[Default]
        Me.layoutViewField_LayoutViewColumn2_1.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn2_1.TextVisible = False
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CaptionImageVisible = False
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn4, Me.layoutViewField_LayoutViewColumn1_2, Me.layoutViewField_LayoutViewColumn2_1, Me.layoutViewField_LayoutViewColumn1_1, Me.layoutViewField_LayoutViewColumn1_3})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'riLargeImage
        '
        Me.riLargeImage.Name = "riLargeImage"
        Me.riLargeImage.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'ToolTipController1
        '
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProdref, Me.colProddesc, Me.colMemo, Me.colSmallImage, Me.colPDF, Me.colLargeImage, Me.colVideo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 32
        '
        'colProdref
        '
        Me.colProdref.Caption = "Product"
        Me.colProdref.FieldName = "prodref"
        Me.colProdref.Name = "colProdref"
        Me.colProdref.OptionsColumn.ShowCaption = False
        Me.colProdref.Tag = "PRODREF"
        Me.colProdref.Visible = True
        Me.colProdref.VisibleIndex = 0
        '
        'colProddesc
        '
        Me.colProddesc.Caption = "Description"
        Me.colProddesc.FieldName = "proddesc"
        Me.colProddesc.Name = "colProddesc"
        Me.colProddesc.OptionsColumn.ShowCaption = False
        Me.colProddesc.Tag = "DESCRIPTION"
        Me.colProddesc.Visible = True
        Me.colProddesc.VisibleIndex = 1
        '
        'colMemo
        '
        Me.colMemo.Caption = "Details"
        Me.colMemo.FieldName = "memo"
        Me.colMemo.Name = "colMemo"
        Me.colMemo.OptionsColumn.ShowCaption = False
        Me.colMemo.Tag = "MEMO"
        Me.colMemo.Visible = True
        Me.colMemo.VisibleIndex = 2
        '
        'colSmallImage
        '
        Me.colSmallImage.Caption = "Image"
        Me.colSmallImage.ColumnEdit = Me.riSmallImage
        Me.colSmallImage.FieldName = "SMALLIMAGE"
        Me.colSmallImage.Name = "colSmallImage"
        Me.colSmallImage.OptionsColumn.AllowSize = False
        Me.colSmallImage.OptionsColumn.FixedWidth = True
        Me.colSmallImage.OptionsColumn.ShowCaption = False
        Me.colSmallImage.Tag = "SMALLIMAGE"
        Me.colSmallImage.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colSmallImage.Visible = True
        Me.colSmallImage.VisibleIndex = 3
        Me.colSmallImage.Width = 32
        '
        'colPDF
        '
        Me.colPDF.Caption = "PDF"
        Me.colPDF.ColumnEdit = Me.riPdf
        Me.colPDF.FieldName = "PDF"
        Me.colPDF.Name = "colPDF"
        Me.colPDF.OptionsColumn.AllowSize = False
        Me.colPDF.OptionsColumn.FixedWidth = True
        Me.colPDF.OptionsColumn.ShowCaption = False
        Me.colPDF.Tag = "PDF"
        Me.colPDF.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colPDF.Visible = True
        Me.colPDF.VisibleIndex = 4
        Me.colPDF.Width = 32
        '
        'colLargeImage
        '
        Me.colLargeImage.Caption = "LargeImage"
        Me.colLargeImage.FieldName = "LARGEIMAGE"
        Me.colLargeImage.Name = "colLargeImage"
        Me.colLargeImage.OptionsColumn.AllowSize = False
        Me.colLargeImage.OptionsColumn.FixedWidth = True
        Me.colLargeImage.OptionsColumn.ShowCaption = False
        Me.colLargeImage.Tag = "LARGEIMAGE"
        Me.colLargeImage.Visible = True
        Me.colLargeImage.VisibleIndex = 5
        Me.colLargeImage.Width = 32
        '
        'colVideo
        '
        Me.colVideo.Caption = "Video"
        Me.colVideo.ColumnEdit = Me.riVideo
        Me.colVideo.FieldName = "VIDEO"
        Me.colVideo.Name = "colVideo"
        Me.colVideo.OptionsColumn.AllowSize = False
        Me.colVideo.OptionsColumn.FixedWidth = True
        Me.colVideo.OptionsColumn.ShowCaption = False
        Me.colVideo.Tag = "VIDEO"
        Me.colVideo.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colVideo.Visible = True
        Me.colVideo.VisibleIndex = 6
        Me.colVideo.Width = 32
        '
        'TileControl1
        '
        Me.TileControl1.AllowDrag = False
        Me.TileControl1.AllowSelectedItem = True
        Me.TileControl1.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.TileControl1.AppearanceItem.Hovered.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TileControl1.AppearanceItem.Hovered.Options.UseBackColor = True
        Me.TileControl1.AppearanceItem.Hovered.Options.UseFont = True
        Me.TileControl1.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.TileControl1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.TileControl1.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TileControl1.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.TileControl1.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileControl1.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileControl1.AppearanceItem.Normal.Options.UseFont = True
        Me.TileControl1.AppearanceItem.Normal.Options.UseForeColor = True
        Me.TileControl1.AppearanceItem.Pressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.TileControl1.AppearanceItem.Pressed.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TileControl1.AppearanceItem.Pressed.Options.UseBackColor = True
        Me.TileControl1.AppearanceItem.Pressed.Options.UseFont = True
        Me.TileControl1.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TileControl1.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Transparent
        Me.TileControl1.AppearanceItem.Selected.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TileControl1.AppearanceItem.Selected.ForeColor = System.Drawing.Color.White
        Me.TileControl1.AppearanceItem.Selected.Options.UseBackColor = True
        Me.TileControl1.AppearanceItem.Selected.Options.UseBorderColor = True
        Me.TileControl1.AppearanceItem.Selected.Options.UseFont = True
        Me.TileControl1.AppearanceItem.Selected.Options.UseForeColor = True
        Me.TileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TileControl1.ColumnCount = 1
        Me.TileControl1.DragSize = New System.Drawing.Size(0, 0)
        Me.TileControl1.Groups.Add(Me.TileGroup1)
        Me.TileControl1.IndentBetweenItems = 5
        Me.TileControl1.ItemPadding = New System.Windows.Forms.Padding(7, 7, 7, 4)
        Me.TileControl1.ItemSize = 80
        Me.TileControl1.Location = New System.Drawing.Point(12, 54)
        Me.TileControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TileControl1.MaxId = 6
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileControl1.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.TileControl1.SelectedItem = Me.tileEvacuationChairs
        Me.TileControl1.Size = New System.Drawing.Size(190, 504)
        Me.TileControl1.TabIndex = 4
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup1
        '
        Me.TileGroup1.Items.Add(Me.tileEvacuationChairs)
        Me.TileGroup1.Items.Add(Me.tilStairClimbers)
        Me.TileGroup1.Items.Add(Me.tileAccessories)
        Me.TileGroup1.Items.Add(Me.tileCardiaid)
        Me.TileGroup1.Items.Add(Me.tileAids)
        Me.TileGroup1.Items.Add(Me.tileAirChair)
        Me.TileGroup1.Name = "TileGroup1"
        Me.TileGroup1.Text = "TileGroup1"
        '
        'tileEvacuationChairs
        '
        Me.tileEvacuationChairs.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.tileEvacuationChairs.AppearanceItem.Hovered.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.tileEvacuationChairs.AppearanceItem.Hovered.Options.UseBackColor = True
        Me.tileEvacuationChairs.AppearanceItem.Hovered.Options.UseFont = True
        Me.tileEvacuationChairs.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.tileEvacuationChairs.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.tileEvacuationChairs.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.tileEvacuationChairs.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tileEvacuationChairs.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileEvacuationChairs.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.tileEvacuationChairs.AppearanceItem.Normal.Options.UseFont = True
        Me.tileEvacuationChairs.AppearanceItem.Normal.Options.UseForeColor = True
        TileItemElement1.ImageBorderColor = System.Drawing.Color.Empty
        TileItemElement1.Text = "Evacuation Chairs"
        Me.tileEvacuationChairs.Elements.Add(TileItemElement1)
        Me.tileEvacuationChairs.Id = 0
        Me.tileEvacuationChairs.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileEvacuationChairs.Name = "tileEvacuationChairs"
        '
        'tilStairClimbers
        '
        TileItemElement2.ImageBorderColor = System.Drawing.Color.Empty
        TileItemElement2.Text = "StairClimbers"
        Me.tilStairClimbers.Elements.Add(TileItemElement2)
        Me.tilStairClimbers.Id = 1
        Me.tilStairClimbers.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tilStairClimbers.Name = "tilStairClimbers"
        '
        'tileAccessories
        '
        TileItemElement3.ImageBorderColor = System.Drawing.Color.Empty
        TileItemElement3.Text = "Accessories"
        Me.tileAccessories.Elements.Add(TileItemElement3)
        Me.tileAccessories.Id = 2
        Me.tileAccessories.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileAccessories.Name = "tileAccessories"
        '
        'tileCardiaid
        '
        TileItemElement4.ImageBorderColor = System.Drawing.Color.Empty
        TileItemElement4.Text = "CardiAid"
        Me.tileCardiaid.Elements.Add(TileItemElement4)
        Me.tileCardiaid.Id = 3
        Me.tileCardiaid.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileCardiaid.Name = "tileCardiaid"
        '
        'tileAids
        '
        TileItemElement5.ImageBorderColor = System.Drawing.Color.Empty
        TileItemElement5.Text = "Evacuation Aids"
        Me.tileAids.Elements.Add(TileItemElement5)
        Me.tileAids.Id = 4
        Me.tileAids.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileAids.Name = "tileAids"
        '
        'tileAirChair
        '
        TileItemElement6.ImageBorderColor = System.Drawing.Color.Empty
        TileItemElement6.Text = "Air+Chair"
        Me.tileAirChair.Elements.Add(TileItemElement6)
        Me.tileAirChair.Id = 5
        Me.tileAirChair.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileAirChair.Name = "tileAirChair"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciTileControl, Me.SIProducts, Me.lciProducts, Me.hideButton, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(901, 570)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lciTileControl
        '
        Me.lciTileControl.Control = Me.TileControl1
        Me.lciTileControl.CustomizationFormText = "lciTileControl"
        Me.lciTileControl.Location = New System.Drawing.Point(0, 42)
        Me.lciTileControl.MaxSize = New System.Drawing.Size(194, 0)
        Me.lciTileControl.MinSize = New System.Drawing.Size(104, 24)
        Me.lciTileControl.Name = "lciTileControl"
        Me.lciTileControl.Size = New System.Drawing.Size(194, 508)
        Me.lciTileControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciTileControl.Text = "lciTileControl"
        Me.lciTileControl.TextSize = New System.Drawing.Size(0, 0)
        Me.lciTileControl.TextVisible = False
        '
        'SIProducts
        '
        Me.SIProducts.AllowHotTrack = False
        Me.SIProducts.AllowHtmlStringInCaption = True
        Me.SIProducts.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.SIProducts.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.SIProducts.AppearanceItemCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SIProducts.AppearanceItemCaption.Options.UseFont = True
        Me.SIProducts.AppearanceItemCaption.Options.UseForeColor = True
        Me.SIProducts.CustomizationFormText = "PRODUCT <color=47, 81, 165>Categories"
        Me.SIProducts.Location = New System.Drawing.Point(0, 0)
        Me.SIProducts.Name = "SIProducts"
        Me.SIProducts.Size = New System.Drawing.Size(799, 42)
        Me.SIProducts.Text = "PRODUCT <color=47, 81, 165>Categories"
        Me.SIProducts.TextSize = New System.Drawing.Size(179, 25)
        '
        'lciProducts
        '
        Me.lciProducts.Control = Me.GridControl1
        Me.lciProducts.CustomizationFormText = "lciProducts"
        Me.lciProducts.Location = New System.Drawing.Point(222, 42)
        Me.lciProducts.Name = "lciProducts"
        Me.lciProducts.Size = New System.Drawing.Size(659, 508)
        Me.lciProducts.Text = "lciProducts"
        Me.lciProducts.TextSize = New System.Drawing.Size(0, 0)
        Me.lciProducts.TextVisible = False
        '
        'hideButton
        '
        Me.hideButton.AllowHotTrack = False
        Me.hideButton.ContentVisible = False
        Me.hideButton.CustomizationFormText = "LabelhideButton"
        Me.hideButton.Image = CType(resources.GetObject("hideButton.Image"), System.Drawing.Image)
        Me.hideButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.hideButton.Location = New System.Drawing.Point(194, 42)
        Me.hideButton.MaxSize = New System.Drawing.Size(28, 17)
        Me.hideButton.MinSize = New System.Drawing.Size(28, 17)
        Me.hideButton.Name = "hideButton"
        Me.hideButton.Size = New System.Drawing.Size(28, 508)
        Me.hideButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.hideButton.Text = "LabelhideButton"
        Me.hideButton.TextSize = New System.Drawing.Size(179, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnView
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(799, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(82, 42)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RTFToolStripMenuItem, Me.WEBToolStripMenuItem, Me.WinToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(99, 70)
        '
        'RTFToolStripMenuItem
        '
        Me.RTFToolStripMenuItem.Name = "RTFToolStripMenuItem"
        Me.RTFToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.RTFToolStripMenuItem.Text = "RTF"
        '
        'WEBToolStripMenuItem
        '
        Me.WEBToolStripMenuItem.Name = "WEBToolStripMenuItem"
        Me.WEBToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.WEBToolStripMenuItem.Text = "WEB"
        '
        'WinToolStripMenuItem
        '
        Me.WinToolStripMenuItem.Name = "WinToolStripMenuItem"
        Me.WinToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.WinToolStripMenuItem.Text = "Win"
        '
        'ProductListSwipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ProductListSwipe"
        Me.Size = New System.Drawing.Size(901, 570)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riPdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riSmallImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riLargeImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTileControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hideButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup1 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents tileEvacuationChairs As DevExpress.XtraEditors.TileItem
    Friend WithEvents tilStairClimbers As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileAccessories As DevExpress.XtraEditors.TileItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciTileControl As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SIProducts As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lciProducts As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents hideButton As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents tileCardiaid As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileAids As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileAirChair As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents colProduct As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents lvDescription As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents lvDetails As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents lvImage As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProdref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProddesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMemo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSmallImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents lvPDF As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents lvLargeImage As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents lvVideo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents riPdf As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents riVideo As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents riSmallImage As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents colPDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVideo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riLargeImage As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents colLargeImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lvOrder As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents riOrder As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents DataSet1 As EvacRemote.DataSet1
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn4 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn2_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RTFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WEBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
