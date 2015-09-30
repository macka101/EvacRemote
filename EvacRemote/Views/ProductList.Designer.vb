<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductList))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnView = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.LvProdRef = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.lvDescription = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.lvDetails = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.lvImage = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.lvVideo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.riVideo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.lvPDF = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.riPDF = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.lvLargeImage = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.riImage = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProdref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProddesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMemo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.layoutViewField_LayoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_LayoutViewColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_LayoutViewColumn3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_LayoutViewColumn4 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.item1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.layoutViewField_LayoutViewColumn1_2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_LayoutViewColumn2_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.item2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.layoutViewField_LayoutViewColumn1_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.item3 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTileControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hideButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnView.Location = New System.Drawing.Point(843, 12)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(46, 38)
        Me.btnView.StyleController = Me.LayoutControl1
        Me.btnView.TabIndex = 6
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GridControl1.Location = New System.Drawing.Point(234, 54)
        Me.GridControl1.LookAndFeel.TouchUI = True
        Me.GridControl1.MainView = Me.LayoutView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemHyperLinkEdit1, Me.riVideo, Me.riImage, Me.riPDF})
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(655, 504)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LayoutView1, Me.GridView1})
        '
        'LayoutView1
        '
        Me.LayoutView1.CardMinSize = New System.Drawing.Size(404, 457)
        Me.LayoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.LvProdRef, Me.lvDescription, Me.lvDetails, Me.lvImage, Me.lvVideo, Me.lvPDF, Me.lvLargeImage})
        Me.LayoutView1.GridControl = Me.GridControl1
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
        Me.LayoutView1.OptionsView.ShowCardCaption = False
        Me.LayoutView1.OptionsView.ShowCardExpandButton = False
        Me.LayoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.LayoutView1.OptionsView.ShowHeaderPanel = False
        Me.LayoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        '
        'LvProdRef
        '
        Me.LvProdRef.Caption = "Ref"
        Me.LvProdRef.FieldName = "prodref"
        Me.LvProdRef.LayoutViewField = Me.layoutViewField_LayoutViewColumn1
        Me.LvProdRef.Name = "LvProdRef"
        Me.LvProdRef.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.LvProdRef.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.LvProdRef.OptionsFilter.AllowAutoFilter = False
        Me.LvProdRef.OptionsFilter.AllowFilter = False
        '
        'lvDescription
        '
        Me.lvDescription.Caption = "Description"
        Me.lvDescription.FieldName = "proddesc"
        Me.lvDescription.LayoutViewField = Me.layoutViewField_LayoutViewColumn2
        Me.lvDescription.Name = "lvDescription"
        '
        'lvDetails
        '
        Me.lvDetails.Caption = "Details"
        Me.lvDetails.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.lvDetails.FieldName = "memo"
        Me.lvDetails.LayoutViewField = Me.layoutViewField_LayoutViewColumn3
        Me.lvDetails.Name = "lvDetails"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'lvImage
        '
        Me.lvImage.Caption = "Image"
        Me.lvImage.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.lvImage.FieldName = "Image"
        Me.lvImage.LayoutViewField = Me.layoutViewField_LayoutViewColumn4
        Me.lvImage.Name = "lvImage"
        Me.lvImage.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'lvVideo
        '
        Me.lvVideo.Caption = "Video"
        Me.lvVideo.ColumnEdit = Me.riVideo
        Me.lvVideo.FieldName = "VIDEO"
        Me.lvVideo.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_1
        Me.lvVideo.Name = "lvVideo"
        Me.lvVideo.OptionsFilter.AllowAutoFilter = False
        Me.lvVideo.OptionsFilter.AllowFilter = False
        Me.lvVideo.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[False]
        Me.lvVideo.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'riVideo
        '
        Me.riVideo.AutoHeight = False
        Me.riVideo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("riVideo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.riVideo.Name = "riVideo"
        Me.riVideo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'lvPDF
        '
        Me.lvPDF.Caption = "PDF"
        Me.lvPDF.ColumnEdit = Me.riPDF
        Me.lvPDF.FieldName = "PDF"
        Me.lvPDF.Image = CType(resources.GetObject("lvPDF.Image"), System.Drawing.Image)
        Me.lvPDF.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_2
        Me.lvPDF.Name = "lvPDF"
        Me.lvPDF.OptionsFilter.AllowAutoFilter = False
        Me.lvPDF.OptionsFilter.AllowFilter = False
        Me.lvPDF.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'riPDF
        '
        Me.riPDF.AutoHeight = False
        Me.riPDF.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("riPDF.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.riPDF.Name = "riPDF"
        Me.riPDF.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'lvLargeImage
        '
        Me.lvLargeImage.Caption = " "
        Me.lvLargeImage.ColumnEdit = Me.riImage
        Me.lvLargeImage.CustomizationCaption = "Image"
        Me.lvLargeImage.FieldName = "LARGEIMAGE"
        Me.lvLargeImage.Image = CType(resources.GetObject("lvLargeImage.Image"), System.Drawing.Image)
        Me.lvLargeImage.LayoutViewField = Me.layoutViewField_LayoutViewColumn2_1
        Me.lvLargeImage.Name = "lvLargeImage"
        Me.lvLargeImage.OptionsFilter.AllowAutoFilter = False
        Me.lvLargeImage.OptionsFilter.AllowFilter = False
        Me.lvLargeImage.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'riImage
        '
        Me.riImage.AutoHeight = False
        Me.riImage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("riImage.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.riImage.Name = "riImage"
        Me.riImage.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemHyperLinkEdit1.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemHyperLinkEdit1.Buttons1"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemHyperLinkEdit1.Buttons2"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProdref, Me.colProddesc, Me.colMemo, Me.colImage})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'colProdref
        '
        Me.colProdref.Caption = "Product"
        Me.colProdref.FieldName = "prodref"
        Me.colProdref.Name = "colProdref"
        Me.colProdref.Visible = True
        Me.colProdref.VisibleIndex = 0
        '
        'colProddesc
        '
        Me.colProddesc.Caption = "Description"
        Me.colProddesc.FieldName = "proddesc"
        Me.colProddesc.Name = "colProddesc"
        Me.colProddesc.Visible = True
        Me.colProddesc.VisibleIndex = 1
        '
        'colMemo
        '
        Me.colMemo.Caption = "Details"
        Me.colMemo.FieldName = "memo"
        Me.colMemo.Name = "colMemo"
        Me.colMemo.Visible = True
        Me.colMemo.VisibleIndex = 2
        '
        'colImage
        '
        Me.colImage.Caption = "Image"
        Me.colImage.FieldName = "colImage"
        Me.colImage.Name = "colImage"
        Me.colImage.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colImage.Visible = True
        Me.colImage.VisibleIndex = 3
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
        TileItemElement1.Text = "Evacuation Chairs"
        Me.tileEvacuationChairs.Elements.Add(TileItemElement1)
        Me.tileEvacuationChairs.Id = 0
        Me.tileEvacuationChairs.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileEvacuationChairs.Name = "tileEvacuationChairs"
        '
        'tilStairClimbers
        '
        TileItemElement2.Text = "StairClimbers"
        Me.tilStairClimbers.Elements.Add(TileItemElement2)
        Me.tilStairClimbers.Id = 1
        Me.tilStairClimbers.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tilStairClimbers.Name = "tilStairClimbers"
        '
        'tileAccessories
        '
        TileItemElement3.Text = "Accessories"
        Me.tileAccessories.Elements.Add(TileItemElement3)
        Me.tileAccessories.Id = 2
        Me.tileAccessories.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileAccessories.Name = "tileAccessories"
        '
        'tileCardiaid
        '
        TileItemElement4.Text = "CardiAid"
        Me.tileCardiaid.Elements.Add(TileItemElement4)
        Me.tileCardiaid.Id = 3
        Me.tileCardiaid.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileCardiaid.Name = "tileCardiaid"
        '
        'tileAids
        '
        TileItemElement5.Text = "Evacuation Aids"
        Me.tileAids.Elements.Add(TileItemElement5)
        Me.tileAids.Id = 4
        Me.tileAids.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileAids.Name = "tileAids"
        '
        'tileAirChair
        '
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
        Me.lciTileControl.TextToControlDistance = 0
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
        Me.SIProducts.Size = New System.Drawing.Size(831, 42)
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
        Me.lciProducts.TextToControlDistance = 0
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
        Me.LayoutControlItem1.Location = New System.Drawing.Point(831, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(50, 42)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CaptionImageVisible = False
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.GroupBordersVisible = False
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1, Me.layoutViewField_LayoutViewColumn2, Me.layoutViewField_LayoutViewColumn3, Me.layoutViewField_LayoutViewColumn4, Me.item1, Me.layoutViewField_LayoutViewColumn1_2, Me.layoutViewField_LayoutViewColumn2_1, Me.item2, Me.layoutViewField_LayoutViewColumn1_1, Me.item3})
        Me.LayoutViewCard1.Name = "layoutViewTemplateCard"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'layoutViewField_LayoutViewColumn1
        '
        Me.layoutViewField_LayoutViewColumn1.EditorPreferredWidth = 325
        Me.layoutViewField_LayoutViewColumn1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn1.Name = "layoutViewField_LayoutViewColumn1"
        Me.layoutViewField_LayoutViewColumn1.Size = New System.Drawing.Size(391, 24)
        Me.layoutViewField_LayoutViewColumn1.TextSize = New System.Drawing.Size(57, 13)
        Me.layoutViewField_LayoutViewColumn1.TextToControlDistance = 5
        '
        'layoutViewField_LayoutViewColumn2
        '
        Me.layoutViewField_LayoutViewColumn2.EditorPreferredWidth = 325
        Me.layoutViewField_LayoutViewColumn2.Location = New System.Drawing.Point(0, 24)
        Me.layoutViewField_LayoutViewColumn2.Name = "layoutViewField_LayoutViewColumn2"
        Me.layoutViewField_LayoutViewColumn2.Size = New System.Drawing.Size(391, 24)
        Me.layoutViewField_LayoutViewColumn2.TextSize = New System.Drawing.Size(57, 13)
        Me.layoutViewField_LayoutViewColumn2.TextToControlDistance = 5
        '
        'layoutViewField_LayoutViewColumn3
        '
        Me.layoutViewField_LayoutViewColumn3.EditorPreferredWidth = 387
        Me.layoutViewField_LayoutViewColumn3.Location = New System.Drawing.Point(0, 60)
        Me.layoutViewField_LayoutViewColumn3.Name = "layoutViewField_LayoutViewColumn3"
        Me.layoutViewField_LayoutViewColumn3.Size = New System.Drawing.Size(391, 105)
        Me.layoutViewField_LayoutViewColumn3.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutViewField_LayoutViewColumn3.TextSize = New System.Drawing.Size(57, 13)
        Me.layoutViewField_LayoutViewColumn3.TextToControlDistance = 5
        '
        'layoutViewField_LayoutViewColumn4
        '
        Me.layoutViewField_LayoutViewColumn4.EditorPreferredWidth = 387
        Me.layoutViewField_LayoutViewColumn4.Location = New System.Drawing.Point(0, 165)
        Me.layoutViewField_LayoutViewColumn4.MaxSize = New System.Drawing.Size(341, 220)
        Me.layoutViewField_LayoutViewColumn4.MinSize = New System.Drawing.Size(341, 220)
        Me.layoutViewField_LayoutViewColumn4.Name = "layoutViewField_LayoutViewColumn4"
        Me.layoutViewField_LayoutViewColumn4.Size = New System.Drawing.Size(391, 220)
        Me.layoutViewField_LayoutViewColumn4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.layoutViewField_LayoutViewColumn4.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn4.TextToControlDistance = 0
        Me.layoutViewField_LayoutViewColumn4.TextVisible = False
        '
        'item1
        '
        Me.item1.AllowHotTrack = False
        Me.item1.CustomizationFormText = "item1"
        Me.item1.Location = New System.Drawing.Point(0, 48)
        Me.item1.Name = "item1"
        Me.item1.Size = New System.Drawing.Size(391, 12)
        Me.item1.Text = "item1"
        Me.item1.TextSize = New System.Drawing.Size(0, 0)
        '
        'layoutViewField_LayoutViewColumn1_2
        '
        Me.layoutViewField_LayoutViewColumn1_2.EditorPreferredWidth = 69
        Me.layoutViewField_LayoutViewColumn1_2.Image = CType(resources.GetObject("layoutViewField_LayoutViewColumn1_2.Image"), System.Drawing.Image)
        Me.layoutViewField_LayoutViewColumn1_2.Location = New System.Drawing.Point(264, 395)
        Me.layoutViewField_LayoutViewColumn1_2.Name = "layoutViewField_LayoutViewColumn1_2"
        Me.layoutViewField_LayoutViewColumn1_2.Size = New System.Drawing.Size(73, 42)
        Me.layoutViewField_LayoutViewColumn1_2.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn1_2.TextToControlDistance = 0
        Me.layoutViewField_LayoutViewColumn1_2.TextVisible = False
        '
        'layoutViewField_LayoutViewColumn2_1
        '
        Me.layoutViewField_LayoutViewColumn2_1.EditorPreferredWidth = 60
        Me.layoutViewField_LayoutViewColumn2_1.Image = CType(resources.GetObject("layoutViewField_LayoutViewColumn2_1.Image"), System.Drawing.Image)
        Me.layoutViewField_LayoutViewColumn2_1.Location = New System.Drawing.Point(200, 395)
        Me.layoutViewField_LayoutViewColumn2_1.Name = "layoutViewField_LayoutViewColumn2_1"
        Me.layoutViewField_LayoutViewColumn2_1.Size = New System.Drawing.Size(64, 42)
        Me.layoutViewField_LayoutViewColumn2_1.TextLocation = DevExpress.Utils.Locations.[Default]
        Me.layoutViewField_LayoutViewColumn2_1.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn2_1.TextToControlDistance = 0
        Me.layoutViewField_LayoutViewColumn2_1.TextVisible = False
        '
        'item2
        '
        Me.item2.AllowHotTrack = False
        Me.item2.CustomizationFormText = "item2"
        Me.item2.Location = New System.Drawing.Point(0, 395)
        Me.item2.Name = "item2"
        Me.item2.Size = New System.Drawing.Size(200, 42)
        Me.item2.Text = "item2"
        Me.item2.TextSize = New System.Drawing.Size(0, 0)
        '
        'layoutViewField_LayoutViewColumn1_1
        '
        Me.layoutViewField_LayoutViewColumn1_1.EditorPreferredWidth = 50
        Me.layoutViewField_LayoutViewColumn1_1.Location = New System.Drawing.Point(337, 395)
        Me.layoutViewField_LayoutViewColumn1_1.Name = "layoutViewField_LayoutViewColumn1_1"
        Me.layoutViewField_LayoutViewColumn1_1.Size = New System.Drawing.Size(54, 42)
        Me.layoutViewField_LayoutViewColumn1_1.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn1_1.TextToControlDistance = 0
        Me.layoutViewField_LayoutViewColumn1_1.TextVisible = False
        '
        'item3
        '
        Me.item3.AllowHotTrack = False
        Me.item3.CustomizationFormText = "item3"
        Me.item3.Location = New System.Drawing.Point(0, 385)
        Me.item3.Name = "item3"
        Me.item3.Size = New System.Drawing.Size(391, 10)
        Me.item3.Text = "item3"
        Me.item3.TextSize = New System.Drawing.Size(0, 0)
        '
        'ProductList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ProductList"
        Me.Size = New System.Drawing.Size(901, 570)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riPDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTileControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hideButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LvProdRef As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents lvDescription As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents lvDetails As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents lvImage As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProdref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProddesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMemo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents lvPDF As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents lvLargeImage As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents lvVideo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents riVideo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents riPDF As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents riImage As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn4 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn2_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents item1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents item2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents item3 As DevExpress.XtraLayout.EmptySpaceItem

End Class
