<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SurveySwipe
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
        Me.lueBuilding = New DevExpress.XtraEditors.LookUpEdit()
        Me.teStairwells = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.vw_EscapeRoute = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdStairwells = New DevExpress.XtraGrid.GridControl()
        Me.vw_Stairwells = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.icbHeritage = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.icbAccess = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.teEscapeRoutes = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciAccess = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciHeritage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEscapeRoutes = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEscapeRouteGrid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.grdEscapeRoute = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciStairWells = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciBuilding = New DevExpress.XtraLayout.LayoutControlItem()
        Me.colEscapeRoute = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntExt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFloors = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.lueBuilding.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teStairwells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_EscapeRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdStairwells, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_Stairwells, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icbHeritage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icbAccess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teEscapeRoutes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciHeritage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEscapeRoutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEscapeRouteGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEscapeRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciStairWells, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.lueBuilding)
        Me.LayoutControl1.Controls.Add(Me.teStairwells)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.grdStairwells)
        Me.LayoutControl1.Controls.Add(Me.icbHeritage)
        Me.LayoutControl1.Controls.Add(Me.icbAccess)
        Me.LayoutControl1.Controls.Add(Me.teEscapeRoutes)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(941, 166, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(916, 486)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'lueBuilding
        '
        Me.lueBuilding.Location = New System.Drawing.Point(83, 12)
        Me.lueBuilding.Name = "lueBuilding"
        Me.lueBuilding.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.lueBuilding.Size = New System.Drawing.Size(821, 20)
        Me.lueBuilding.StyleController = Me.LayoutControl1
        Me.lueBuilding.TabIndex = 28
        '
        'teStairwells
        '
        Me.teStairwells.Location = New System.Drawing.Point(795, 36)
        Me.teStairwells.Name = "teStairwells"
        Me.teStairwells.Size = New System.Drawing.Size(109, 20)
        Me.teStairwells.StyleController = Me.LayoutControl1
        Me.teStairwells.TabIndex = 27
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 60)
        Me.GridControl1.MainView = Me.vw_EscapeRoute
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(444, 414)
        Me.GridControl1.TabIndex = 26
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vw_EscapeRoute})
        '
        'vw_EscapeRoute
        '
        Me.vw_EscapeRoute.GridControl = Me.GridControl1
        Me.vw_EscapeRoute.Name = "vw_EscapeRoute"
        '
        'grdStairwells
        '
        Me.grdStairwells.Location = New System.Drawing.Point(460, 60)
        Me.grdStairwells.MainView = Me.vw_Stairwells
        Me.grdStairwells.Name = "grdStairwells"
        Me.grdStairwells.Size = New System.Drawing.Size(444, 414)
        Me.grdStairwells.TabIndex = 24
        Me.grdStairwells.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vw_Stairwells})
        '
        'vw_Stairwells
        '
        Me.vw_Stairwells.GridControl = Me.grdStairwells
        Me.vw_Stairwells.Name = "vw_Stairwells"
        '
        'icbHeritage
        '
        Me.icbHeritage.Location = New System.Drawing.Point(456, 36)
        Me.icbHeritage.Name = "icbHeritage"
        Me.icbHeritage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.icbHeritage.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("No", "No", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yes", "Yes", -1)})
        Me.icbHeritage.Size = New System.Drawing.Size(81, 20)
        Me.icbHeritage.StyleController = Me.LayoutControl1
        Me.icbHeritage.TabIndex = 23
        '
        'icbAccess
        '
        Me.icbAccess.Location = New System.Drawing.Point(83, 36)
        Me.icbAccess.Name = "icbAccess"
        Me.icbAccess.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.icbAccess.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Public", "Public", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Private", "Private", -1)})
        Me.icbAccess.Size = New System.Drawing.Size(298, 20)
        Me.icbAccess.StyleController = Me.LayoutControl1
        Me.icbAccess.TabIndex = 22
        '
        'teEscapeRoutes
        '
        Me.teEscapeRoutes.Location = New System.Drawing.Point(612, 36)
        Me.teEscapeRoutes.Name = "teEscapeRoutes"
        Me.teEscapeRoutes.Size = New System.Drawing.Size(108, 20)
        Me.teEscapeRoutes.StyleController = Me.LayoutControl1
        Me.teEscapeRoutes.TabIndex = 21
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciAccess, Me.lciHeritage, Me.lciEscapeRoutes, Me.lciEscapeRouteGrid, Me.grdEscapeRoute, Me.lciStairWells, Me.lciBuilding})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(916, 486)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lciAccess
        '
        Me.lciAccess.Control = Me.icbAccess
        Me.lciAccess.Location = New System.Drawing.Point(0, 24)
        Me.lciAccess.Name = "lciAccess"
        Me.lciAccess.Size = New System.Drawing.Size(373, 24)
        Me.lciAccess.Text = "Access"
        Me.lciAccess.TextSize = New System.Drawing.Size(68, 13)
        '
        'lciHeritage
        '
        Me.lciHeritage.Control = Me.icbHeritage
        Me.lciHeritage.Location = New System.Drawing.Point(373, 24)
        Me.lciHeritage.Name = "lciHeritage"
        Me.lciHeritage.Size = New System.Drawing.Size(156, 24)
        Me.lciHeritage.Text = "Heritage"
        Me.lciHeritage.TextSize = New System.Drawing.Size(68, 13)
        '
        'lciEscapeRoutes
        '
        Me.lciEscapeRoutes.Control = Me.teEscapeRoutes
        Me.lciEscapeRoutes.Location = New System.Drawing.Point(529, 24)
        Me.lciEscapeRoutes.Name = "lciEscapeRoutes"
        Me.lciEscapeRoutes.Size = New System.Drawing.Size(183, 24)
        Me.lciEscapeRoutes.Text = "EscapeRoutes"
        Me.lciEscapeRoutes.TextSize = New System.Drawing.Size(68, 13)
        '
        'lciEscapeRouteGrid
        '
        Me.lciEscapeRouteGrid.Control = Me.grdStairwells
        Me.lciEscapeRouteGrid.Location = New System.Drawing.Point(448, 48)
        Me.lciEscapeRouteGrid.Name = "lciEscapeRouteGrid"
        Me.lciEscapeRouteGrid.Size = New System.Drawing.Size(448, 418)
        Me.lciEscapeRouteGrid.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEscapeRouteGrid.TextVisible = False
        '
        'grdEscapeRoute
        '
        Me.grdEscapeRoute.Control = Me.GridControl1
        Me.grdEscapeRoute.Location = New System.Drawing.Point(0, 48)
        Me.grdEscapeRoute.Name = "grdEscapeRoute"
        Me.grdEscapeRoute.Size = New System.Drawing.Size(448, 418)
        Me.grdEscapeRoute.TextSize = New System.Drawing.Size(0, 0)
        Me.grdEscapeRoute.TextVisible = False
        '
        'lciStairWells
        '
        Me.lciStairWells.Control = Me.teStairwells
        Me.lciStairWells.Location = New System.Drawing.Point(712, 24)
        Me.lciStairWells.Name = "lciStairWells"
        Me.lciStairWells.Size = New System.Drawing.Size(184, 24)
        Me.lciStairWells.Text = "Stair Wells"
        Me.lciStairWells.TextSize = New System.Drawing.Size(68, 13)
        '
        'lciBuilding
        '
        Me.lciBuilding.Control = Me.lueBuilding
        Me.lciBuilding.Location = New System.Drawing.Point(0, 0)
        Me.lciBuilding.Name = "lciBuilding"
        Me.lciBuilding.Size = New System.Drawing.Size(896, 24)
        Me.lciBuilding.TextSize = New System.Drawing.Size(68, 13)
        '
        'colEscapeRoute
        '
        Me.colEscapeRoute.Caption = "EscapeRoute"
        Me.colEscapeRoute.FieldName = "EscapeRoute"
        Me.colEscapeRoute.Name = "colEscapeRoute"
        Me.colEscapeRoute.Visible = True
        Me.colEscapeRoute.VisibleIndex = 0
        '
        'colType
        '
        Me.colType.Caption = "Type"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 1
        '
        'colIntExt
        '
        Me.colIntExt.Caption = "IntExt"
        Me.colIntExt.FieldName = "IntExt"
        Me.colIntExt.Name = "colIntExt"
        Me.colIntExt.Visible = True
        Me.colIntExt.VisibleIndex = 2
        '
        'colFloors
        '
        Me.colFloors.Caption = "Floors"
        Me.colFloors.FieldName = "Floors"
        Me.colFloors.Name = "colFloors"
        Me.colFloors.Visible = True
        Me.colFloors.VisibleIndex = 3
        '
        'SurveySwipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "SurveySwipe"
        Me.Size = New System.Drawing.Size(916, 486)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.lueBuilding.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teStairwells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_EscapeRoute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdStairwells, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_Stairwells, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icbHeritage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icbAccess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teEscapeRoutes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciHeritage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEscapeRoutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEscapeRouteGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEscapeRoute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciStairWells, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents teEscapeRoutes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciEscapeRoutes As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents icbHeritage As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents icbAccess As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents lciAccess As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciHeritage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colEscapeRoute As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntExt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFloors As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdStairwells As DevExpress.XtraGrid.GridControl
    Friend WithEvents vw_Stairwells As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lciEscapeRouteGrid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents vw_EscapeRoute As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdEscapeRoute As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents teStairwells As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciStairWells As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lueBuilding As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciBuilding As DevExpress.XtraLayout.LayoutControlItem

End Class
