<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucClientSelector
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
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.teName = New DevExpress.XtraEditors.TextEdit()
        Me.lciSearch = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tePostCode = New DevExpress.XtraEditors.TextEdit()
        Me.lciPostCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lciList = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnSelect = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePostCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPostCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnSelect)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.btnFind)
        Me.LayoutControl1.Controls.Add(Me.tePostCode)
        Me.LayoutControl1.Controls.Add(Me.teName)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(419, 206, 250, 350)
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = True
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = True
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = True
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LayoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LayoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(623, 435)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.CustomizationFormText = "Root"
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciSearch, Me.lciPostCode, Me.LayoutControlItem3, Me.lciList, Me.LayoutControlItem5, Me.EmptySpaceItem1})
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(623, 435)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'teName
        '
        Me.teName.Location = New System.Drawing.Point(62, 12)
        Me.teName.Name = "teName"
        Me.teName.Size = New System.Drawing.Size(275, 20)
        Me.teName.StyleController = Me.LayoutControl1
        Me.teName.TabIndex = 4
        '
        'lciSearch
        '
        Me.lciSearch.Control = Me.teName
        Me.lciSearch.CustomizationFormText = "Name"
        Me.lciSearch.Location = New System.Drawing.Point(0, 0)
        Me.lciSearch.Name = "lciSearch"
        Me.lciSearch.Size = New System.Drawing.Size(329, 26)
        Me.lciSearch.Text = "Name"
        Me.lciSearch.TextSize = New System.Drawing.Size(46, 13)
        '
        'tePostCode
        '
        Me.tePostCode.Location = New System.Drawing.Point(391, 12)
        Me.tePostCode.Name = "tePostCode"
        Me.tePostCode.Size = New System.Drawing.Size(111, 20)
        Me.tePostCode.StyleController = Me.LayoutControl1
        Me.tePostCode.TabIndex = 5
        '
        'lciPostCode
        '
        Me.lciPostCode.Control = Me.tePostCode
        Me.lciPostCode.CustomizationFormText = "PostCode"
        Me.lciPostCode.Location = New System.Drawing.Point(329, 0)
        Me.lciPostCode.Name = "lciPostCode"
        Me.lciPostCode.Size = New System.Drawing.Size(165, 26)
        Me.lciPostCode.Text = "PostCode"
        Me.lciPostCode.TextSize = New System.Drawing.Size(46, 13)
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(506, 12)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(105, 22)
        Me.btnFind.StyleController = Me.LayoutControl1
        Me.btnFind.TabIndex = 6
        Me.btnFind.Text = "Find"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnFind
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(494, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(109, 26)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 38)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(599, 359)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'lciList
        '
        Me.lciList.Control = Me.GridControl1
        Me.lciList.CustomizationFormText = "lciList"
        Me.lciList.Location = New System.Drawing.Point(0, 26)
        Me.lciList.Name = "lciList"
        Me.lciList.Size = New System.Drawing.Size(603, 363)
        Me.lciList.Text = "lciList"
        Me.lciList.TextSize = New System.Drawing.Size(0, 0)
        Me.lciList.TextVisible = False
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(490, 401)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(121, 22)
        Me.btnSelect.StyleController = Me.LayoutControl1
        Me.btnSelect.TabIndex = 8
        Me.btnSelect.Text = "Select"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnSelect
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(478, 389)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(125, 26)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 389)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(478, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'ucClientSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ucClientSelector"
        Me.Size = New System.Drawing.Size(623, 435)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePostCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPostCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnSelect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tePostCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciSearch As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciPostCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciList As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

End Class
