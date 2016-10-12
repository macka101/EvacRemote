<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SurveyDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SurveyDetail))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnPrintQuote = New DevExpress.XtraEditors.SimpleButton()
        Me.lueBuilding = New DevExpress.XtraEditors.LookUpEdit()
        Me.GrdEscapeRoutes = New DevExpress.XtraGrid.GridControl()
        Me.vw_EscapeRoute = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CoESlOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEStype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESIntExt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESnofloors = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.icbHeritage = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.icbAccess = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.teEscapeRoutes = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciAccess = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciHeritage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEscapeRoutes = New DevExpress.XtraLayout.LayoutControlItem()
        Me.grdEscapeRoute = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciBuilding = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.colEscapeRoute = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntExt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFloors = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Picback = New System.Windows.Forms.PictureBox()
        Me.lciPicback = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.lueBuilding.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdEscapeRoutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_EscapeRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icbHeritage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icbAccess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teEscapeRoutes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciHeritage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEscapeRoutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEscapeRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPicback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Picback)
        Me.LayoutControl1.Controls.Add(Me.btnPrintQuote)
        Me.LayoutControl1.Controls.Add(Me.lueBuilding)
        Me.LayoutControl1.Controls.Add(Me.GrdEscapeRoutes)
        Me.LayoutControl1.Controls.Add(Me.icbHeritage)
        Me.LayoutControl1.Controls.Add(Me.icbAccess)
        Me.LayoutControl1.Controls.Add(Me.teEscapeRoutes)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(895, 167, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(916, 486)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnPrintQuote
        '
        Me.btnPrintQuote.Image = CType(resources.GetObject("btnPrintQuote.Image"), System.Drawing.Image)
        Me.btnPrintQuote.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPrintQuote.Location = New System.Drawing.Point(784, 12)
        Me.btnPrintQuote.Name = "btnPrintQuote"
        Me.btnPrintQuote.Size = New System.Drawing.Size(120, 38)
        Me.btnPrintQuote.StyleController = Me.LayoutControl1
        Me.btnPrintQuote.TabIndex = 29
        '
        'lueBuilding
        '
        Me.lueBuilding.EnterMoveNextControl = True
        Me.lueBuilding.Location = New System.Drawing.Point(133, 12)
        Me.lueBuilding.Name = "lueBuilding"
        Me.lueBuilding.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.lueBuilding.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lueBuilding.Size = New System.Drawing.Size(348, 20)
        Me.lueBuilding.StyleController = Me.LayoutControl1
        Me.lueBuilding.TabIndex = 28
        '
        'GrdEscapeRoutes
        '
        Me.GrdEscapeRoutes.Location = New System.Drawing.Point(62, 78)
        Me.GrdEscapeRoutes.MainView = Me.vw_EscapeRoute
        Me.GrdEscapeRoutes.Name = "GrdEscapeRoutes"
        Me.GrdEscapeRoutes.ShowOnlyPredefinedDetails = True
        Me.GrdEscapeRoutes.Size = New System.Drawing.Size(842, 396)
        Me.GrdEscapeRoutes.TabIndex = 26
        Me.GrdEscapeRoutes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vw_EscapeRoute})
        '
        'vw_EscapeRoute
        '
        Me.vw_EscapeRoute.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CoESlOid, Me.colESLocation, Me.colEStype, Me.colESIntExt, Me.colESnofloors})
        Me.vw_EscapeRoute.GridControl = Me.GrdEscapeRoutes
        Me.vw_EscapeRoute.Name = "vw_EscapeRoute"
        Me.vw_EscapeRoute.OptionsBehavior.Editable = False
        '
        'CoESlOid
        '
        Me.CoESlOid.Caption = "Oid"
        Me.CoESlOid.FieldName = "Oid"
        Me.CoESlOid.Name = "CoESlOid"
        '
        'colESLocation
        '
        Me.colESLocation.Caption = "Location"
        Me.colESLocation.FieldName = "Location"
        Me.colESLocation.Name = "colESLocation"
        Me.colESLocation.Visible = True
        Me.colESLocation.VisibleIndex = 0
        '
        'colEStype
        '
        Me.colEStype.Caption = "Type"
        Me.colEStype.FieldName = "Type"
        Me.colEStype.Name = "colEStype"
        Me.colEStype.Visible = True
        Me.colEStype.VisibleIndex = 1
        '
        'colESIntExt
        '
        Me.colESIntExt.Caption = "IntExt "
        Me.colESIntExt.FieldName = "IntExt"
        Me.colESIntExt.Name = "colESIntExt"
        Me.colESIntExt.Visible = True
        Me.colESIntExt.VisibleIndex = 2
        '
        'colESnofloors
        '
        Me.colESnofloors.Caption = "Floors"
        Me.colESnofloors.FieldName = "nofloors"
        Me.colESnofloors.Name = "colESnofloors"
        Me.colESnofloors.Visible = True
        Me.colESnofloors.VisibleIndex = 3
        '
        'icbHeritage
        '
        Me.icbHeritage.EnterMoveNextControl = True
        Me.icbHeritage.Location = New System.Drawing.Point(485, 54)
        Me.icbHeritage.Name = "icbHeritage"
        Me.icbHeritage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.icbHeritage.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("No", "No", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yes", "Yes", -1)})
        Me.icbHeritage.Size = New System.Drawing.Size(72, 20)
        Me.icbHeritage.StyleController = Me.LayoutControl1
        Me.icbHeritage.TabIndex = 23
        '
        'icbAccess
        '
        Me.icbAccess.EnterMoveNextControl = True
        Me.icbAccess.Location = New System.Drawing.Point(133, 54)
        Me.icbAccess.Name = "icbAccess"
        Me.icbAccess.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.icbAccess.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Public", "Public", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Private", "Private", -1)})
        Me.icbAccess.Size = New System.Drawing.Size(277, 20)
        Me.icbAccess.StyleController = Me.LayoutControl1
        Me.icbAccess.TabIndex = 22
        '
        'teEscapeRoutes
        '
        Me.teEscapeRoutes.EnterMoveNextControl = True
        Me.teEscapeRoutes.Location = New System.Drawing.Point(632, 54)
        Me.teEscapeRoutes.Name = "teEscapeRoutes"
        Me.teEscapeRoutes.Size = New System.Drawing.Size(98, 20)
        Me.teEscapeRoutes.StyleController = Me.LayoutControl1
        Me.teEscapeRoutes.TabIndex = 21
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciAccess, Me.lciHeritage, Me.lciEscapeRoutes, Me.grdEscapeRoute, Me.lciBuilding, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem1, Me.lciPicback})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(916, 486)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lciAccess
        '
        Me.lciAccess.Control = Me.icbAccess
        Me.lciAccess.Location = New System.Drawing.Point(50, 42)
        Me.lciAccess.Name = "lciAccess"
        Me.lciAccess.Size = New System.Drawing.Size(352, 24)
        Me.lciAccess.Text = "Access"
        Me.lciAccess.TextSize = New System.Drawing.Size(68, 13)
        '
        'lciHeritage
        '
        Me.lciHeritage.Control = Me.icbHeritage
        Me.lciHeritage.Location = New System.Drawing.Point(402, 42)
        Me.lciHeritage.Name = "lciHeritage"
        Me.lciHeritage.Size = New System.Drawing.Size(147, 24)
        Me.lciHeritage.Text = "Heritage"
        Me.lciHeritage.TextSize = New System.Drawing.Size(68, 13)
        '
        'lciEscapeRoutes
        '
        Me.lciEscapeRoutes.Control = Me.teEscapeRoutes
        Me.lciEscapeRoutes.Location = New System.Drawing.Point(549, 42)
        Me.lciEscapeRoutes.Name = "lciEscapeRoutes"
        Me.lciEscapeRoutes.Size = New System.Drawing.Size(173, 24)
        Me.lciEscapeRoutes.Text = "EscapeRoutes"
        Me.lciEscapeRoutes.TextSize = New System.Drawing.Size(68, 13)
        '
        'grdEscapeRoute
        '
        Me.grdEscapeRoute.Control = Me.GrdEscapeRoutes
        Me.grdEscapeRoute.Location = New System.Drawing.Point(50, 66)
        Me.grdEscapeRoute.Name = "grdEscapeRoute"
        Me.grdEscapeRoute.Size = New System.Drawing.Size(846, 400)
        Me.grdEscapeRoute.TextSize = New System.Drawing.Size(0, 0)
        Me.grdEscapeRoute.TextVisible = False
        '
        'lciBuilding
        '
        Me.lciBuilding.Control = Me.lueBuilding
        Me.lciBuilding.Location = New System.Drawing.Point(50, 0)
        Me.lciBuilding.Name = "lciBuilding"
        Me.lciBuilding.Size = New System.Drawing.Size(423, 42)
        Me.lciBuilding.Text = "Building"
        Me.lciBuilding.TextSize = New System.Drawing.Size(68, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(722, 42)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(174, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(473, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(299, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnPrintQuote
        Me.LayoutControlItem1.Location = New System.Drawing.Point(772, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(124, 42)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
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
        'Picback
        '
        Me.Picback.Image = Global.EvacRemote.My.Resources.Resources.returnButton
        Me.Picback.Location = New System.Drawing.Point(12, 12)
        Me.Picback.Name = "Picback"
        Me.Picback.Size = New System.Drawing.Size(46, 462)
        Me.Picback.TabIndex = 30
        Me.Picback.TabStop = False
        '
        'lciPicback
        '
        Me.lciPicback.Control = Me.Picback
        Me.lciPicback.Location = New System.Drawing.Point(0, 0)
        Me.lciPicback.MinSize = New System.Drawing.Size(50, 24)
        Me.lciPicback.Name = "lciPicback"
        Me.lciPicback.Size = New System.Drawing.Size(50, 466)
        Me.lciPicback.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciPicback.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lciPicback.TextSize = New System.Drawing.Size(0, 0)
        Me.lciPicback.TextToControlDistance = 0
        Me.lciPicback.TextVisible = False
        '
        'SurveyDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "SurveyDetail"
        Me.Size = New System.Drawing.Size(916, 486)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.lueBuilding.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdEscapeRoutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_EscapeRoute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icbHeritage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icbAccess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teEscapeRoutes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciHeritage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEscapeRoutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEscapeRoute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPicback, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GrdEscapeRoutes As DevExpress.XtraGrid.GridControl
    Friend WithEvents vw_EscapeRoute As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdEscapeRoute As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lueBuilding As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciBuilding As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CoESlOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEStype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESIntExt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESnofloors As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnPrintQuote As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Picback As System.Windows.Forms.PictureBox
    Friend WithEvents lciPicback As DevExpress.XtraLayout.LayoutControlItem

End Class
