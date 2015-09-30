<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskListSwipe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskListSwipe))
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTaskType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPostCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnView = New DevExpress.XtraEditors.SimpleButton()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup1 = New DevExpress.XtraEditors.TileGroup()
        Me.tileEvacuationChairs = New DevExpress.XtraEditors.TileItem()
        Me.tilInProgress = New DevExpress.XtraEditors.TileItem()
        Me.tilNotStarted = New DevExpress.XtraEditors.TileItem()
        Me.tilDeferred = New DevExpress.XtraEditors.TileItem()
        Me.tilCompleted = New DevExpress.XtraEditors.TileItem()
        Me.tilHighPriority = New DevExpress.XtraEditors.TileItem()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciTileControl = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SIProducts = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.hideButton = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTasks = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTileControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hideButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.btnView)
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
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Location = New System.Drawing.Point(206, 54)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(683, 487)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTaskType, Me.colStatus, Me.colStartdate, Me.colSubject, Me.colPostCode})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'colTaskType
        '
        Me.colTaskType.Caption = "Task"
        Me.colTaskType.FieldName = "TaskType"
        Me.colTaskType.MaxWidth = 100
        Me.colTaskType.Name = "colTaskType"
        Me.colTaskType.Visible = True
        Me.colTaskType.VisibleIndex = 0
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "TaskStatus"
        Me.colStatus.MaxWidth = 100
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 1
        '
        'colStartdate
        '
        Me.colStartdate.Caption = "Date"
        Me.colStartdate.FieldName = "StartDate"
        Me.colStartdate.MaxWidth = 75
        Me.colStartdate.Name = "colStartdate"
        Me.colStartdate.Visible = True
        Me.colStartdate.VisibleIndex = 2
        '
        'colSubject
        '
        Me.colSubject.Caption = "Subject"
        Me.colSubject.FieldName = "Subject"
        Me.colSubject.Name = "colSubject"
        Me.colSubject.Visible = True
        Me.colSubject.VisibleIndex = 3
        '
        'colPostCode
        '
        Me.colPostCode.Caption = "PostCode"
        Me.colPostCode.FieldName = "Postcode"
        Me.colPostCode.MaxWidth = 75
        Me.colPostCode.Name = "colPostCode"
        Me.colPostCode.Visible = True
        Me.colPostCode.VisibleIndex = 4
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
        Me.TileControl1.MaxId = 7
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileControl1.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.TileControl1.SelectedItem = Me.tilInProgress
        Me.TileControl1.Size = New System.Drawing.Size(190, 504)
        Me.TileControl1.TabIndex = 4
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup1
        '
        Me.TileGroup1.Items.Add(Me.tileEvacuationChairs)
        Me.TileGroup1.Items.Add(Me.tilInProgress)
        Me.TileGroup1.Items.Add(Me.tilNotStarted)
        Me.TileGroup1.Items.Add(Me.tilDeferred)
        Me.TileGroup1.Items.Add(Me.tilCompleted)
        Me.TileGroup1.Items.Add(Me.tilHighPriority)
        Me.TileGroup1.Items.Add(Me.TileItem1)
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
        TileItemElement1.Image = Global.EvacRemote.My.Resources.Resources.AllTasks
        TileItemElement1.Text = "All Tasks"
        Me.tileEvacuationChairs.Elements.Add(TileItemElement1)
        Me.tileEvacuationChairs.Id = 0
        Me.tileEvacuationChairs.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileEvacuationChairs.Name = "tileEvacuationChairs"
        Me.tileEvacuationChairs.Tag = "ALLTASKS"
        '
        'tilInProgress
        '
        TileItemElement2.Image = Global.EvacRemote.My.Resources.Resources.InProgress
        TileItemElement2.Text = "In Progress"
        Me.tilInProgress.Elements.Add(TileItemElement2)
        Me.tilInProgress.Id = 1
        Me.tilInProgress.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tilInProgress.Name = "tilInProgress"
        Me.tilInProgress.Tag = "INPROGRESS"
        '
        'tilNotStarted
        '
        TileItemElement3.Image = Global.EvacRemote.My.Resources.Resources.NotStarted
        TileItemElement3.Text = "Not Started"
        Me.tilNotStarted.Elements.Add(TileItemElement3)
        Me.tilNotStarted.Id = 2
        Me.tilNotStarted.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tilNotStarted.Name = "tilNotStarted"
        Me.tilNotStarted.Tag = "NOTSTARTED"
        '
        'tilDeferred
        '
        TileItemElement4.Image = Global.EvacRemote.My.Resources.Resources.Deferred
        TileItemElement4.Text = "Deferred"
        Me.tilDeferred.Elements.Add(TileItemElement4)
        Me.tilDeferred.Id = 3
        Me.tilDeferred.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tilDeferred.Name = "tilDeferred"
        Me.tilDeferred.Tag = "DEFERRED"
        '
        'tilCompleted
        '
        TileItemElement5.Image = Global.EvacRemote.My.Resources.Resources.Completed
        TileItemElement5.Text = "Completed"
        Me.tilCompleted.Elements.Add(TileItemElement5)
        Me.tilCompleted.Id = 4
        Me.tilCompleted.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tilCompleted.Name = "tilCompleted"
        Me.tilCompleted.Tag = "COMPLETED"
        '
        'tilHighPriority
        '
        TileItemElement6.Image = Global.EvacRemote.My.Resources.Resources.HighPriority
        TileItemElement6.Text = "High Priority"
        Me.tilHighPriority.Elements.Add(TileItemElement6)
        Me.tilHighPriority.Id = 5
        Me.tilHighPriority.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tilHighPriority.Name = "tilHighPriority"
        Me.tilHighPriority.Tag = "HIGHPRIORITY"
        '
        'TileItem1
        '
        TileItemElement7.Image = Global.EvacRemote.My.Resources.Resources.Urgent
        TileItemElement7.Text = "Urgent"
        Me.TileItem1.Elements.Add(TileItemElement7)
        Me.TileItem1.Id = 6
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem1.Name = "TileItem1"
        Me.TileItem1.Tag = "URGENT"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciTileControl, Me.SIProducts, Me.hideButton, Me.LayoutControlItem1, Me.lciTasks})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(901, 570)
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
        Me.SIProducts.CustomizationFormText = "TASK <color=47, 81, 165>Categories"
        Me.SIProducts.Location = New System.Drawing.Point(0, 0)
        Me.SIProducts.Name = "SIProducts"
        Me.SIProducts.Size = New System.Drawing.Size(831, 42)
        Me.SIProducts.Text = "PRODUCT <color=47, 81, 165>Categories"
        Me.SIProducts.TextSize = New System.Drawing.Size(179, 25)
        '
        'hideButton
        '
        Me.hideButton.AllowHotTrack = False
        Me.hideButton.ContentVisible = False
        Me.hideButton.CustomizationFormText = "LabelhideButton"
        Me.hideButton.Image = CType(resources.GetObject("hideButton.Image"), System.Drawing.Image)
        Me.hideButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.hideButton.Location = New System.Drawing.Point(194, 533)
        Me.hideButton.MaxSize = New System.Drawing.Size(28, 17)
        Me.hideButton.MinSize = New System.Drawing.Size(28, 17)
        Me.hideButton.Name = "hideButton"
        Me.hideButton.Size = New System.Drawing.Size(687, 17)
        Me.hideButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.hideButton.TextSize = New System.Drawing.Size(179, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnView
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(831, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(50, 42)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'lciTasks
        '
        Me.lciTasks.Control = Me.GridControl1
        Me.lciTasks.CustomizationFormText = "lciTasks"
        Me.lciTasks.Location = New System.Drawing.Point(194, 42)
        Me.lciTasks.Name = "lciTasks"
        Me.lciTasks.Size = New System.Drawing.Size(687, 491)
        Me.lciTasks.TextSize = New System.Drawing.Size(0, 0)
        Me.lciTasks.TextVisible = False
        '
        'TaskListSwipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "TaskListSwipe"
        Me.Size = New System.Drawing.Size(901, 570)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTileControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hideButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup1 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents tileEvacuationChairs As DevExpress.XtraEditors.TileItem
    Friend WithEvents tilInProgress As DevExpress.XtraEditors.TileItem
    Friend WithEvents tilNotStarted As DevExpress.XtraEditors.TileItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciTileControl As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SIProducts As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents hideButton As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents tilDeferred As DevExpress.XtraEditors.TileItem
    Friend WithEvents tilCompleted As DevExpress.XtraEditors.TileItem
    Friend WithEvents tilHighPriority As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lciTasks As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents colTaskType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPostCode As DevExpress.XtraGrid.Columns.GridColumn

End Class
