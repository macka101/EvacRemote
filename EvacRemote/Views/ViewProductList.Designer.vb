<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProductList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewProductList))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.grdProducts = New DevExpress.XtraGrid.GridControl()
        Me.vw_Products = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShortDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.SIProduct = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.lciContacts = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.grdProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_Products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnImport)
        Me.LayoutControl1.Controls.Add(Me.grdProducts)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(914, 181, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(659, 419)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnImport
        '
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnImport.Location = New System.Drawing.Point(594, 12)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(53, 38)
        Me.btnImport.StyleController = Me.LayoutControl1
        Me.btnImport.TabIndex = 5
        Me.btnImport.Text = " "
        '
        'grdProducts
        '
        Me.grdProducts.Location = New System.Drawing.Point(12, 54)
        Me.grdProducts.MainView = Me.vw_Products
        Me.grdProducts.Name = "grdProducts"
        Me.grdProducts.ShowOnlyPredefinedDetails = True
        Me.grdProducts.Size = New System.Drawing.Size(635, 353)
        Me.grdProducts.TabIndex = 4
        Me.grdProducts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vw_Products})
        '
        'vw_Products
        '
        Me.vw_Products.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colProductCode, Me.colShortDescription})
        Me.vw_Products.GridControl = Me.grdProducts
        Me.vw_Products.Name = "vw_Products"
        Me.vw_Products.OptionsBehavior.AllowIncrementalSearch = True
        Me.vw_Products.OptionsBehavior.Editable = False
        Me.vw_Products.OptionsFind.AlwaysVisible = True
        Me.vw_Products.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.vw_Products.OptionsView.ShowGroupPanel = False
        '
        'colOid
        '
        Me.colOid.Caption = "Oid"
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'colProductCode
        '
        Me.colProductCode.Caption = "ProductCode"
        Me.colProductCode.FieldName = "ProductCode"
        Me.colProductCode.Name = "colProductCode"
        Me.colProductCode.OptionsColumn.FixedWidth = True
        Me.colProductCode.Visible = True
        Me.colProductCode.VisibleIndex = 0
        Me.colProductCode.Width = 120
        '
        'colShortDescription
        '
        Me.colShortDescription.Caption = "Description"
        Me.colShortDescription.FieldName = "Description"
        Me.colShortDescription.Name = "colShortDescription"
        Me.colShortDescription.Visible = True
        Me.colShortDescription.VisibleIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.SIProduct, Me.lciContacts, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(659, 419)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'SIProduct
        '
        Me.SIProduct.AllowHotTrack = False
        Me.SIProduct.AllowHtmlStringInCaption = True
        Me.SIProduct.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIProduct.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.SIProduct.AppearanceItemCaption.Options.UseFont = True
        Me.SIProduct.AppearanceItemCaption.Options.UseForeColor = True
        Me.SIProduct.CustomizationFormText = "CURRENT CONTACT <color=47, 81, 165>"
        Me.SIProduct.Location = New System.Drawing.Point(0, 0)
        Me.SIProduct.Name = "SIProduct"
        Me.SIProduct.Size = New System.Drawing.Size(582, 42)
        Me.SIProduct.Text = "Products"
        Me.SIProduct.TextSize = New System.Drawing.Size(74, 25)
        '
        'lciContacts
        '
        Me.lciContacts.Control = Me.grdProducts
        Me.lciContacts.CustomizationFormText = "Contacts"
        Me.lciContacts.Location = New System.Drawing.Point(0, 42)
        Me.lciContacts.Name = "lciContacts"
        Me.lciContacts.Size = New System.Drawing.Size(639, 357)
        Me.lciContacts.Text = "Contacts"
        Me.lciContacts.TextSize = New System.Drawing.Size(0, 0)
        Me.lciContacts.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnImport
        Me.LayoutControlItem1.Location = New System.Drawing.Point(582, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(57, 42)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'ProductList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ProductList"
        Me.Size = New System.Drawing.Size(659, 419)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.grdProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_Products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciContacts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdProducts As DevExpress.XtraGrid.GridControl
    Friend WithEvents vw_Products As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SIProduct As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lciContacts As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShortDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

End Class
