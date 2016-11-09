<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssetServiceHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssetServiceHistory))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnNewService = New DevExpress.XtraEditors.SimpleButton()
        Me.grdServices = New DevExpress.XtraGrid.GridControl()
        Me.vw_Services = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lueProduct = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueFloor = New DevExpress.XtraEditors.LookUpEdit()
        Me.teDescription = New DevExpress.XtraEditors.TextEdit()
        Me.teNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.lueBuilding = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueEscapeRoute = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciBack = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lciBuilding = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEscapeRoute = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lciBarCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciFloor = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciProduct = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciNotes = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciServices = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colServiceDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPassed = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.grdServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_Services, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFloor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBuilding.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEscapeRoute.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEscapeRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFloor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnNewService)
        Me.LayoutControl1.Controls.Add(Me.grdServices)
        Me.LayoutControl1.Controls.Add(Me.lueProduct)
        Me.LayoutControl1.Controls.Add(Me.lueFloor)
        Me.LayoutControl1.Controls.Add(Me.teDescription)
        Me.LayoutControl1.Controls.Add(Me.teNotes)
        Me.LayoutControl1.Controls.Add(Me.picBack)
        Me.LayoutControl1.Controls.Add(Me.lueBuilding)
        Me.LayoutControl1.Controls.Add(Me.lueEscapeRoute)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(684, 156, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(922, 452)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnNewService
        '
        Me.btnNewService.Image = CType(resources.GetObject("btnNewService.Image"), System.Drawing.Image)
        Me.btnNewService.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNewService.Location = New System.Drawing.Point(823, 210)
        Me.btnNewService.Name = "btnNewService"
        Me.btnNewService.Size = New System.Drawing.Size(77, 38)
        Me.btnNewService.StyleController = Me.LayoutControl1
        Me.btnNewService.TabIndex = 62
        Me.btnNewService.Text = " "
        '
        'grdServices
        '
        Me.grdServices.Location = New System.Drawing.Point(72, 268)
        Me.grdServices.MainView = Me.vw_Services
        Me.grdServices.Name = "grdServices"
        Me.grdServices.ShowOnlyPredefinedDetails = True
        Me.grdServices.Size = New System.Drawing.Size(828, 172)
        Me.grdServices.TabIndex = 61
        Me.grdServices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vw_Services})
        '
        'vw_Services
        '
        Me.vw_Services.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colServiceDate, Me.colPassed})
        Me.vw_Services.GridControl = Me.grdServices
        Me.vw_Services.Name = "vw_Services"
        Me.vw_Services.OptionsBehavior.Editable = False
        Me.vw_Services.OptionsCustomization.AllowGroup = False
        Me.vw_Services.OptionsView.ShowGroupPanel = False
        '
        'lueProduct
        '
        Me.lueProduct.Location = New System.Drawing.Point(436, 46)
        Me.lueProduct.Name = "lueProduct"
        Me.lueProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueProduct.Size = New System.Drawing.Size(464, 20)
        Me.lueProduct.StyleController = Me.LayoutControl1
        Me.lueProduct.TabIndex = 60
        '
        'lueFloor
        '
        Me.lueFloor.Location = New System.Drawing.Point(718, 22)
        Me.lueFloor.Name = "lueFloor"
        Me.lueFloor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFloor.Size = New System.Drawing.Size(182, 20)
        Me.lueFloor.StyleController = Me.LayoutControl1
        Me.lueFloor.TabIndex = 59
        '
        'teDescription
        '
        Me.teDescription.Location = New System.Drawing.Point(152, 46)
        Me.teDescription.Name = "teDescription"
        Me.teDescription.Size = New System.Drawing.Size(238, 20)
        Me.teDescription.StyleController = Me.LayoutControl1
        Me.teDescription.TabIndex = 34
        '
        'teNotes
        '
        Me.teNotes.Location = New System.Drawing.Point(72, 86)
        Me.teNotes.Name = "teNotes"
        Me.teNotes.Size = New System.Drawing.Size(828, 120)
        Me.teNotes.StyleController = Me.LayoutControl1
        Me.teNotes.TabIndex = 13
        '
        'picBack
        '
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(20, 30)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(30, 402)
        Me.picBack.TabIndex = 4
        Me.picBack.TabStop = False
        '
        'lueBuilding
        '
        Me.lueBuilding.Location = New System.Drawing.Point(113, 22)
        Me.lueBuilding.Name = "lueBuilding"
        Me.lueBuilding.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)})
        Me.lueBuilding.Properties.NullText = ""
        Me.lueBuilding.Properties.PopupSizeable = False
        Me.lueBuilding.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lueBuilding.Size = New System.Drawing.Size(277, 20)
        Me.lueBuilding.StyleController = Me.LayoutControl1
        Me.lueBuilding.TabIndex = 35
        '
        'lueEscapeRoute
        '
        Me.lueEscapeRoute.Location = New System.Drawing.Point(465, 22)
        Me.lueEscapeRoute.Name = "lueEscapeRoute"
        Me.lueEscapeRoute.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEscapeRoute.Properties.NullText = ""
        Me.lueEscapeRoute.Properties.PopupSizeable = False
        Me.lueEscapeRoute.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lueEscapeRoute.Size = New System.Drawing.Size(220, 20)
        Me.lueEscapeRoute.StyleController = Me.LayoutControl1
        Me.lueEscapeRoute.TabIndex = 36
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciBack, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.lciBuilding, Me.lciEscapeRoute, Me.EmptySpaceItem4, Me.EmptySpaceItem3, Me.lciBarCode, Me.lciFloor, Me.lciProduct, Me.lciNotes, Me.lciServices, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(922, 452)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lciBack
        '
        Me.lciBack.Control = Me.picBack
        Me.lciBack.CustomizationFormText = "lciBack"
        Me.lciBack.Location = New System.Drawing.Point(0, 0)
        Me.lciBack.MinSize = New System.Drawing.Size(50, 24)
        Me.lciBack.Name = "lciBack"
        Me.lciBack.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 20, 10)
        Me.lciBack.Size = New System.Drawing.Size(50, 432)
        Me.lciBack.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciBack.TextSize = New System.Drawing.Size(0, 0)
        Me.lciBack.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(50, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 432)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(892, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(10, 432)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'lciBuilding
        '
        Me.lciBuilding.Control = Me.lueBuilding
        Me.lciBuilding.CustomizationFormText = "Building"
        Me.lciBuilding.Location = New System.Drawing.Point(60, 10)
        Me.lciBuilding.Name = "lciBuilding"
        Me.lciBuilding.Size = New System.Drawing.Size(322, 24)
        Me.lciBuilding.Text = "Building"
        Me.lciBuilding.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lciBuilding.TextSize = New System.Drawing.Size(36, 13)
        Me.lciBuilding.TextToControlDistance = 5
        '
        'lciEscapeRoute
        '
        Me.lciEscapeRoute.Control = Me.lueEscapeRoute
        Me.lciEscapeRoute.CustomizationFormText = "Location"
        Me.lciEscapeRoute.Location = New System.Drawing.Point(382, 10)
        Me.lciEscapeRoute.Name = "lciEscapeRoute"
        Me.lciEscapeRoute.Size = New System.Drawing.Size(295, 24)
        Me.lciEscapeRoute.Text = "Escape Route"
        Me.lciEscapeRoute.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lciEscapeRoute.TextSize = New System.Drawing.Size(66, 13)
        Me.lciEscapeRoute.TextToControlDistance = 5
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(60, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(832, 10)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(60, 198)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(751, 42)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'lciBarCode
        '
        Me.lciBarCode.Control = Me.teDescription
        Me.lciBarCode.CustomizationFormText = "Description"
        Me.lciBarCode.Location = New System.Drawing.Point(60, 34)
        Me.lciBarCode.Name = "lciBarCode"
        Me.lciBarCode.Size = New System.Drawing.Size(322, 24)
        Me.lciBarCode.Text = "BarCode"
        Me.lciBarCode.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lciBarCode.TextSize = New System.Drawing.Size(75, 20)
        Me.lciBarCode.TextToControlDistance = 5
        '
        'lciFloor
        '
        Me.lciFloor.Control = Me.lueFloor
        Me.lciFloor.Location = New System.Drawing.Point(677, 10)
        Me.lciFloor.Name = "lciFloor"
        Me.lciFloor.Size = New System.Drawing.Size(215, 24)
        Me.lciFloor.Text = "Floor"
        Me.lciFloor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lciFloor.TextSize = New System.Drawing.Size(24, 13)
        Me.lciFloor.TextToControlDistance = 5
        '
        'lciProduct
        '
        Me.lciProduct.Control = Me.lueProduct
        Me.lciProduct.Location = New System.Drawing.Point(382, 34)
        Me.lciProduct.Name = "lciProduct"
        Me.lciProduct.Size = New System.Drawing.Size(510, 24)
        Me.lciProduct.Text = "Product"
        Me.lciProduct.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lciProduct.TextSize = New System.Drawing.Size(37, 13)
        Me.lciProduct.TextToControlDistance = 5
        '
        'lciNotes
        '
        Me.lciNotes.Control = Me.teNotes
        Me.lciNotes.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lciNotes.CustomizationFormText = "Notes"
        Me.lciNotes.Location = New System.Drawing.Point(60, 58)
        Me.lciNotes.Name = "lciNotes"
        Me.lciNotes.Size = New System.Drawing.Size(832, 140)
        Me.lciNotes.Text = "Notes"
        Me.lciNotes.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciNotes.TextSize = New System.Drawing.Size(40, 13)
        '
        'lciServices
        '
        Me.lciServices.Control = Me.grdServices
        Me.lciServices.Location = New System.Drawing.Point(60, 240)
        Me.lciServices.Name = "lciServices"
        Me.lciServices.Size = New System.Drawing.Size(832, 192)
        Me.lciServices.Text = "Services"
        Me.lciServices.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciServices.TextSize = New System.Drawing.Size(40, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnNewService
        Me.LayoutControlItem1.Location = New System.Drawing.Point(811, 198)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(81, 42)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'colOid
        '
        Me.colOid.Caption = "Oid"
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'colServiceDate
        '
        Me.colServiceDate.Caption = "Service Date"
        Me.colServiceDate.FieldName = "ServiceDate"
        Me.colServiceDate.Name = "colServiceDate"
        Me.colServiceDate.Visible = True
        Me.colServiceDate.VisibleIndex = 0
        '
        'colPassed
        '
        Me.colPassed.Caption = "Pass/Fail"
        Me.colPassed.FieldName = "Passed"
        Me.colPassed.Name = "colPassed"
        Me.colPassed.Visible = True
        Me.colPassed.VisibleIndex = 1
        '
        'AssetChairService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "AssetChairService"
        Me.Size = New System.Drawing.Size(922, 452)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.grdServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_Services, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFloor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBuilding.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEscapeRoute.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEscapeRoute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFloor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents picBack As System.Windows.Forms.PictureBox
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciBack As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents teNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lciNotes As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents teDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciBarCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciBuilding As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciEscapeRoute As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents lueBuilding As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueEscapeRoute As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueFloor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciFloor As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lueProduct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciProduct As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents grdServices As DevExpress.XtraGrid.GridControl
    Friend WithEvents vw_Services As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lciServices As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnNewService As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServiceDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPassed As DevExpress.XtraGrid.Columns.GridColumn

End Class
