﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim TileItemElement16 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement17 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement18 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement19 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement20 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement15 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim TileItemElement21 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.mainTileBar = New DevExpress.XtraBars.Navigation.TileBar()
        Me.tileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.contactsTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.productsTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.DiaryTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.tileBarService = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.surveyTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.ServiceTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.basketTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarGroup1 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.dashboardTileBarItem = New DevExpress.XtraBars.Navigation.TileBarItem()
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
        Me.mainTileBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.mainTileBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.mainTileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.mainTileBar.Groups.Add(Me.tileBarGroup2)
        Me.mainTileBar.Groups.Add(Me.tileBarService)
        Me.mainTileBar.Groups.Add(Me.TileBarGroup1)
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
        Me.tileBarGroup2.Items.Add(Me.contactsTileBarItem)
        Me.tileBarGroup2.Items.Add(Me.productsTileBarItem)
        Me.tileBarGroup2.Items.Add(Me.DiaryTileBarItem)
        Me.tileBarGroup2.Name = "tileBarGroup2"
        '
        'contactsTileBarItem
        '
        Me.contactsTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.contactsTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement16.Image = CType(resources.GetObject("TileItemElement16.Image"), System.Drawing.Image)
        TileItemElement16.Text = "Contacts"
        Me.contactsTileBarItem.Elements.Add(TileItemElement16)
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
        TileItemElement17.Image = CType(resources.GetObject("TileItemElement17.Image"), System.Drawing.Image)
        TileItemElement17.Text = "Products"
        Me.productsTileBarItem.Elements.Add(TileItemElement17)
        Me.productsTileBarItem.Id = 3
        Me.productsTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.productsTileBarItem.Name = "productsTileBarItem"
        '
        'DiaryTileBarItem
        '
        Me.DiaryTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.DiaryTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement18.Image = CType(resources.GetObject("TileItemElement18.Image"), System.Drawing.Image)
        TileItemElement18.Text = "Diary"
        Me.DiaryTileBarItem.Elements.Add(TileItemElement18)
        Me.DiaryTileBarItem.Id = 1
        Me.DiaryTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.DiaryTileBarItem.Name = "DiaryTileBarItem"
        '
        'tileBarService
        '
        Me.tileBarService.Items.Add(Me.surveyTileBarItem)
        Me.tileBarService.Items.Add(Me.ServiceTileBarItem)
        Me.tileBarService.Items.Add(Me.basketTileBarItem)
        Me.tileBarService.Name = "tileBarService"
        Me.tileBarService.Text = "Service"
        '
        'surveyTileBarItem
        '
        Me.surveyTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.surveyTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement19.Image = CType(resources.GetObject("TileItemElement19.Image"), System.Drawing.Image)
        TileItemElement19.Text = "Survey"
        Me.surveyTileBarItem.Elements.Add(TileItemElement19)
        Me.surveyTileBarItem.Id = 6
        Me.surveyTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.surveyTileBarItem.Name = "surveyTileBarItem"
        '
        'ServiceTileBarItem
        '
        Me.ServiceTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.ServiceTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement20.Image = Global.EvacRemote.My.Resources.Resources.bookmark_32x32
        TileItemElement20.Text = "Service"
        Me.ServiceTileBarItem.Elements.Add(TileItemElement20)
        Me.ServiceTileBarItem.Id = 7
        Me.ServiceTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.ServiceTileBarItem.Name = "ServiceTileBarItem"
        '
        'basketTileBarItem
        '
        Me.basketTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.basketTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.basketTileBarItem.AppearanceItem.Normal.Options.UseBackColor = True
        Me.basketTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement15.Image = CType(resources.GetObject("TileItemElement15.Image"), System.Drawing.Image)
        TileItemElement15.Text = "Basket"
        Me.basketTileBarItem.Elements.Add(TileItemElement15)
        Me.basketTileBarItem.Id = 5
        Me.basketTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.basketTileBarItem.Name = "basketTileBarItem"
        '
        'TileBarGroup1
        '
        Me.TileBarGroup1.Items.Add(Me.dashboardTileBarItem)
        Me.TileBarGroup1.Name = "TileBarGroup1"
        '
        'dashboardTileBarItem
        '
        Me.dashboardTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.dashboardTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.dashboardTileBarItem.AppearanceItem.Normal.Options.UseBackColor = True
        Me.dashboardTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement21.Image = CType(resources.GetObject("TileItemElement21.Image"), System.Drawing.Image)
        TileItemElement21.Text = "Synchronize"
        Me.dashboardTileBarItem.Elements.Add(TileItemElement21)
        Me.dashboardTileBarItem.Id = 0
        Me.dashboardTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.dashboardTileBarItem.Name = "dashboardTileBarItem"
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
    Private WithEvents DiaryTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Private WithEvents tileBarService As DevExpress.XtraBars.Navigation.TileBarGroup
    Private WithEvents productsTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Private WithEvents contactsTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Private WithEvents surveyTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents MainPnl As DevExpress.XtraEditors.PanelControl
    Public WithEvents basketTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents ServiceTileBarItem As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarGroup1 As DevExpress.XtraBars.Navigation.TileBarGroup
End Class
