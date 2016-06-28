<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement9 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement10 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.mainTileBar = New DevExpress.XtraBars.Navigation.TileBar()
        Me.tileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.dashboardTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.tasksTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.scheduleTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.tileBarService = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.contactsTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.productsTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.surveyTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.basketTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.ServiceTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.tbiSnapReports = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.tbiEmailTemplates = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.MainPnl = New DevExpress.XtraEditors.PanelControl()
        CType(Me.MainPnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainTileBar
        '
        Me.mainTileBar.AllowDrag = False
        Me.mainTileBar.AllowSelectedItem = True
        Me.mainTileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.mainTileBar.AppearanceGroupText.Options.UseForeColor = True
        Me.mainTileBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.mainTileBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.mainTileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.mainTileBar.Groups.Add(Me.tileBarGroup2)
        Me.mainTileBar.Groups.Add(Me.tileBarService)
        Me.mainTileBar.Location = New System.Drawing.Point(0, 0)
        Me.mainTileBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mainTileBar.MaxId = 10
        Me.mainTileBar.Name = "mainTileBar"
        Me.mainTileBar.Padding = New System.Windows.Forms.Padding(26, 3, 26, 3)
        Me.mainTileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.mainTileBar.SelectedItem = Me.basketTileBarItem
        Me.mainTileBar.SelectionBorderWidth = 2
        Me.mainTileBar.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.mainTileBar.Size = New System.Drawing.Size(1230, 118)
        Me.mainTileBar.TabIndex = 2
        Me.mainTileBar.Text = "tileBar1"
        '
        'tileBarGroup2
        '
        Me.tileBarGroup2.Items.Add(Me.dashboardTileBarItem)
        Me.tileBarGroup2.Items.Add(Me.tasksTileBarItem)
        Me.tileBarGroup2.Items.Add(Me.scheduleTileBarItem)
        Me.tileBarGroup2.Name = "tileBarGroup2"
        '
        'dashboardTileBarItem
        '
        Me.dashboardTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.dashboardTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.dashboardTileBarItem.AppearanceItem.Normal.Options.UseBackColor = True
        Me.dashboardTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement1.Image = CType(resources.GetObject("TileItemElement1.Image"), System.Drawing.Image)
        TileItemElement1.Text = "Synchronize"
        Me.dashboardTileBarItem.Elements.Add(TileItemElement1)
        Me.dashboardTileBarItem.Id = 0
        Me.dashboardTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.dashboardTileBarItem.Name = "dashboardTileBarItem"
        '
        'tasksTileBarItem
        '
        Me.tasksTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.tasksTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement2.Image = CType(resources.GetObject("TileItemElement2.Image"), System.Drawing.Image)
        TileItemElement2.Text = "Tasks"
        Me.tasksTileBarItem.Elements.Add(TileItemElement2)
        Me.tasksTileBarItem.Id = 1
        Me.tasksTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.tasksTileBarItem.Name = "tasksTileBarItem"
        '
        'scheduleTileBarItem
        '
        Me.scheduleTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.scheduleTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.scheduleTileBarItem.AppearanceItem.Normal.Options.UseBackColor = True
        Me.scheduleTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement3.Image = Global.EvacRemote.My.Resources.Resources.Calendar
        TileItemElement3.Text = "Schedule"
        Me.scheduleTileBarItem.Elements.Add(TileItemElement3)
        Me.scheduleTileBarItem.Id = 2
        Me.scheduleTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.scheduleTileBarItem.Name = "scheduleTileBarItem"
        '
        'tileBarService
        '
        Me.tileBarService.Items.Add(Me.contactsTileBarItem)
        Me.tileBarService.Items.Add(Me.productsTileBarItem)
        Me.tileBarService.Items.Add(Me.surveyTileBarItem)
        Me.tileBarService.Items.Add(Me.basketTileBarItem)
        Me.tileBarService.Items.Add(Me.ServiceTileBarItem)
        Me.tileBarService.Items.Add(Me.tbiSnapReports)
        Me.tileBarService.Items.Add(Me.tbiEmailTemplates)
        Me.tileBarService.Name = "tileBarService"
        Me.tileBarService.Text = "Service"
        '
        'contactsTileBarItem
        '
        Me.contactsTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.contactsTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement4.Image = CType(resources.GetObject("TileItemElement4.Image"), System.Drawing.Image)
        TileItemElement4.Text = "Contacts"
        Me.contactsTileBarItem.Elements.Add(TileItemElement4)
        Me.contactsTileBarItem.Id = 4
        Me.contactsTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.contactsTileBarItem.Name = "contactsTileBarItem"
        '
        'productsTileBarItem
        '
        Me.productsTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.productsTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.productsTileBarItem.AppearanceItem.Normal.Options.UseBackColor = True
        Me.productsTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement5.Image = CType(resources.GetObject("TileItemElement5.Image"), System.Drawing.Image)
        TileItemElement5.Text = "Products"
        Me.productsTileBarItem.Elements.Add(TileItemElement5)
        Me.productsTileBarItem.Id = 3
        Me.productsTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.productsTileBarItem.Name = "productsTileBarItem"
        '
        'surveyTileBarItem
        '
        Me.surveyTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.surveyTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement6.Image = CType(resources.GetObject("TileItemElement6.Image"), System.Drawing.Image)
        TileItemElement6.Text = "Survey"
        Me.surveyTileBarItem.Elements.Add(TileItemElement6)
        Me.surveyTileBarItem.Id = 6
        Me.surveyTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.surveyTileBarItem.Name = "surveyTileBarItem"
        '
        'basketTileBarItem
        '
        Me.basketTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.basketTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.basketTileBarItem.AppearanceItem.Normal.Options.UseBackColor = True
        Me.basketTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement7.Image = CType(resources.GetObject("TileItemElement7.Image"), System.Drawing.Image)
        TileItemElement7.Text = "Basket"
        Me.basketTileBarItem.Elements.Add(TileItemElement7)
        Me.basketTileBarItem.Id = 5
        Me.basketTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.basketTileBarItem.Name = "basketTileBarItem"
        '
        'ServiceTileBarItem
        '
        Me.ServiceTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.ServiceTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement8.Image = Global.EvacRemote.My.Resources.Resources.bookmark_32x32
        TileItemElement8.Text = "Service"
        Me.ServiceTileBarItem.Elements.Add(TileItemElement8)
        Me.ServiceTileBarItem.Id = 7
        Me.ServiceTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.ServiceTileBarItem.Name = "ServiceTileBarItem"
        '
        'tbiSnapReports
        '
        Me.tbiSnapReports.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement9.Text = "Reps"
        Me.tbiSnapReports.Elements.Add(TileItemElement9)
        Me.tbiSnapReports.Id = 8
        Me.tbiSnapReports.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium
        Me.tbiSnapReports.Name = "tbiSnapReports"
        '
        'tbiEmailTemplates
        '
        Me.tbiEmailTemplates.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement10.Text = "Email"
        Me.tbiEmailTemplates.Elements.Add(TileItemElement10)
        Me.tbiEmailTemplates.Id = 9
        Me.tbiEmailTemplates.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium
        Me.tbiEmailTemplates.Name = "tbiEmailTemplates"
        '
        'MainPnl
        '
        Me.MainPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPnl.Location = New System.Drawing.Point(0, 118)
        Me.MainPnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MainPnl.Name = "MainPnl"
        Me.MainPnl.Size = New System.Drawing.Size(1230, 499)
        Me.MainPnl.TabIndex = 3
        '
        'frmMain
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 617)
        Me.Controls.Add(Me.MainPnl)
        Me.Controls.Add(Me.mainTileBar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MainPnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents mainTileBar As DevExpress.XtraBars.Navigation.TileBar
    Private WithEvents tileBarGroup2 As DevExpress.XtraBars.Navigation.TileBarGroup
    Private WithEvents dashboardTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Private WithEvents tasksTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Private WithEvents scheduleTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Private WithEvents tileBarService As DevExpress.XtraBars.Navigation.TileBarGroup
    Private WithEvents productsTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Private WithEvents contactsTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Private WithEvents surveyTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents MainPnl As DevExpress.XtraEditors.PanelControl
    Public WithEvents basketTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents ServiceTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents tbiSnapReports As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents tbiEmailTemplates As DevExpress.XtraBars.Navigation.TileBarItem
End Class
