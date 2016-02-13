<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewEscapeRouteSwipe
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
        Me.gridFloors = New DevExpress.XtraGrid.GridControl()
        Me.vw_floors = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFloor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.teLocation = New DevExpress.XtraEditors.TextEdit()
        Me.icbNosing = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.CBEGoing = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbeThread = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbePitch = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbeStairwayType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.teFloors = New DevExpress.XtraEditors.TextEdit()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciBack = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciStairwayType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPitch = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciThread = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciGoing = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lciFloor = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciNosing = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciLocation = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciFloors = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.gridFloors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_floors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icbNosing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBEGoing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbeThread.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbePitch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbeStairwayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teFloors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciStairwayType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciThread, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciGoing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFloor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNosing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFloors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.gridFloors)
        Me.LayoutControl1.Controls.Add(Me.teLocation)
        Me.LayoutControl1.Controls.Add(Me.icbNosing)
        Me.LayoutControl1.Controls.Add(Me.CBEGoing)
        Me.LayoutControl1.Controls.Add(Me.cbeThread)
        Me.LayoutControl1.Controls.Add(Me.cbePitch)
        Me.LayoutControl1.Controls.Add(Me.cbeStairwayType)
        Me.LayoutControl1.Controls.Add(Me.teFloors)
        Me.LayoutControl1.Controls.Add(Me.picBack)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(971, 156, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(916, 486)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'gridFloors
        '
        Me.gridFloors.Location = New System.Drawing.Point(126, 180)
        Me.gridFloors.MainView = Me.vw_floors
        Me.gridFloors.Name = "gridFloors"
        Me.gridFloors.ShowOnlyPredefinedDetails = True
        Me.gridFloors.Size = New System.Drawing.Size(603, 294)
        Me.gridFloors.TabIndex = 16
        Me.gridFloors.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vw_floors})
        '
        'vw_floors
        '
        Me.vw_floors.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colFloor, Me.colType})
        Me.vw_floors.GridControl = Me.gridFloors
        Me.vw_floors.Name = "vw_floors"
        Me.vw_floors.OptionsBehavior.Editable = False
        '
        'colOid
        '
        Me.colOid.Caption = "Oid"
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'colFloor
        '
        Me.colFloor.Caption = "Floor"
        Me.colFloor.FieldName = "Floor"
        Me.colFloor.Name = "colFloor"
        Me.colFloor.Visible = True
        Me.colFloor.VisibleIndex = 0
        '
        'colType
        '
        Me.colType.Caption = "Type"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 1
        '
        'teLocation
        '
        Me.teLocation.EnterMoveNextControl = True
        Me.teLocation.Location = New System.Drawing.Point(202, 12)
        Me.teLocation.Name = "teLocation"
        Me.teLocation.Size = New System.Drawing.Size(527, 20)
        Me.teLocation.StyleController = Me.LayoutControl1
        Me.teLocation.TabIndex = 15
        '
        'icbNosing
        '
        Me.icbNosing.EnterMoveNextControl = True
        Me.icbNosing.Location = New System.Drawing.Point(202, 60)
        Me.icbNosing.Name = "icbNosing"
        Me.icbNosing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.icbNosing.Size = New System.Drawing.Size(527, 20)
        Me.icbNosing.StyleController = Me.LayoutControl1
        Me.icbNosing.TabIndex = 14
        '
        'CBEGoing
        '
        Me.CBEGoing.EnterMoveNextControl = True
        Me.CBEGoing.Location = New System.Drawing.Point(202, 132)
        Me.CBEGoing.Name = "CBEGoing"
        Me.CBEGoing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBEGoing.Properties.Items.AddRange(New Object() {"220", "230", "240", "250", "260", "270", "280", "290", "300"})
        Me.CBEGoing.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CBEGoing.Size = New System.Drawing.Size(527, 20)
        Me.CBEGoing.StyleController = Me.LayoutControl1
        Me.CBEGoing.TabIndex = 12
        '
        'cbeThread
        '
        Me.cbeThread.EnterMoveNextControl = True
        Me.cbeThread.Location = New System.Drawing.Point(202, 84)
        Me.cbeThread.Name = "cbeThread"
        Me.cbeThread.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbeThread.Properties.Items.AddRange(New Object() {"Glass", "Granite", "Marble", "Stainless Steel", "Stone", "Tile", "Terrazzo", "Wooden"})
        Me.cbeThread.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbeThread.Size = New System.Drawing.Size(527, 20)
        Me.cbeThread.StyleController = Me.LayoutControl1
        Me.cbeThread.TabIndex = 11
        '
        'cbePitch
        '
        Me.cbePitch.EnterMoveNextControl = True
        Me.cbePitch.Location = New System.Drawing.Point(202, 108)
        Me.cbePitch.Name = "cbePitch"
        Me.cbePitch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbePitch.Properties.Items.AddRange(New Object() {"20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40", "42", "44", "46", "48", "50"})
        Me.cbePitch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbePitch.Size = New System.Drawing.Size(527, 20)
        Me.cbePitch.StyleController = Me.LayoutControl1
        Me.cbePitch.TabIndex = 9
        '
        'cbeStairwayType
        '
        Me.cbeStairwayType.EnterMoveNextControl = True
        Me.cbeStairwayType.Location = New System.Drawing.Point(202, 36)
        Me.cbeStairwayType.Name = "cbeStairwayType"
        Me.cbeStairwayType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbeStairwayType.Properties.Items.AddRange(New Object() {"Closed Riser", "Kite", "Open Riser", "Helical", "Winder", "Short Straight", "Spiral with no Landing", "Straight with Landing", "Straight with no landing"})
        Me.cbeStairwayType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbeStairwayType.Size = New System.Drawing.Size(527, 20)
        Me.cbeStairwayType.StyleController = Me.LayoutControl1
        Me.cbeStairwayType.TabIndex = 8
        '
        'teFloors
        '
        Me.teFloors.EnterMoveNextControl = True
        Me.teFloors.Location = New System.Drawing.Point(202, 156)
        Me.teFloors.Name = "teFloors"
        Me.teFloors.Size = New System.Drawing.Size(527, 20)
        Me.teFloors.StyleController = Me.LayoutControl1
        Me.teFloors.TabIndex = 5
        '
        'picBack
        '
        Me.picBack.Image = Global.EvacRemote.My.Resources.Resources.returnButton
        Me.picBack.Location = New System.Drawing.Point(20, 30)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(30, 436)
        Me.picBack.TabIndex = 4
        Me.picBack.TabStop = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciBack, Me.lciStairwayType, Me.lciPitch, Me.lciThread, Me.lciGoing, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.lciFloor, Me.lciNosing, Me.lciLocation, Me.lciFloors})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(916, 486)
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
        Me.lciBack.Size = New System.Drawing.Size(50, 466)
        Me.lciBack.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciBack.TextSize = New System.Drawing.Size(0, 0)
        Me.lciBack.TextVisible = False
        '
        'lciStairwayType
        '
        Me.lciStairwayType.Control = Me.cbeStairwayType
        Me.lciStairwayType.CustomizationFormText = "Stairway Type"
        Me.lciStairwayType.Location = New System.Drawing.Point(114, 24)
        Me.lciStairwayType.Name = "lciStairwayType"
        Me.lciStairwayType.Size = New System.Drawing.Size(607, 24)
        Me.lciStairwayType.Text = "Stairway Type"
        Me.lciStairwayType.TextSize = New System.Drawing.Size(73, 13)
        '
        'lciPitch
        '
        Me.lciPitch.Control = Me.cbePitch
        Me.lciPitch.CustomizationFormText = "Pitch (degrees)"
        Me.lciPitch.Location = New System.Drawing.Point(114, 96)
        Me.lciPitch.Name = "lciPitch"
        Me.lciPitch.Size = New System.Drawing.Size(607, 24)
        Me.lciPitch.Text = "Pitch (degrees)"
        Me.lciPitch.TextSize = New System.Drawing.Size(73, 13)
        '
        'lciThread
        '
        Me.lciThread.Control = Me.cbeThread
        Me.lciThread.CustomizationFormText = "Thread"
        Me.lciThread.Location = New System.Drawing.Point(114, 72)
        Me.lciThread.Name = "lciThread"
        Me.lciThread.Size = New System.Drawing.Size(607, 24)
        Me.lciThread.Text = "Thread"
        Me.lciThread.TextSize = New System.Drawing.Size(73, 13)
        '
        'lciGoing
        '
        Me.lciGoing.Control = Me.CBEGoing
        Me.lciGoing.CustomizationFormText = "Going"
        Me.lciGoing.Location = New System.Drawing.Point(114, 120)
        Me.lciGoing.Name = "lciGoing"
        Me.lciGoing.Size = New System.Drawing.Size(607, 24)
        Me.lciGoing.Text = "Going"
        Me.lciGoing.TextSize = New System.Drawing.Size(73, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(50, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(64, 466)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(721, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(175, 466)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'lciFloor
        '
        Me.lciFloor.Control = Me.teFloors
        Me.lciFloor.CustomizationFormText = "Reference"
        Me.lciFloor.Location = New System.Drawing.Point(114, 144)
        Me.lciFloor.Name = "lciFloor"
        Me.lciFloor.Size = New System.Drawing.Size(607, 24)
        Me.lciFloor.Text = "Floors"
        Me.lciFloor.TextSize = New System.Drawing.Size(73, 13)
        '
        'lciNosing
        '
        Me.lciNosing.Control = Me.icbNosing
        Me.lciNosing.Location = New System.Drawing.Point(114, 48)
        Me.lciNosing.Name = "lciNosing"
        Me.lciNosing.Size = New System.Drawing.Size(607, 24)
        Me.lciNosing.Text = "Nosing"
        Me.lciNosing.TextSize = New System.Drawing.Size(73, 13)
        '
        'lciLocation
        '
        Me.lciLocation.Control = Me.teLocation
        Me.lciLocation.Location = New System.Drawing.Point(114, 0)
        Me.lciLocation.Name = "lciLocation"
        Me.lciLocation.Size = New System.Drawing.Size(607, 24)
        Me.lciLocation.Text = "Location"
        Me.lciLocation.TextSize = New System.Drawing.Size(73, 13)
        '
        'lciFloors
        '
        Me.lciFloors.Control = Me.gridFloors
        Me.lciFloors.Location = New System.Drawing.Point(114, 168)
        Me.lciFloors.Name = "lciFloors"
        Me.lciFloors.Size = New System.Drawing.Size(607, 298)
        Me.lciFloors.TextSize = New System.Drawing.Size(0, 0)
        Me.lciFloors.TextVisible = False
        '
        'viewEscapeRouteSwipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "viewEscapeRouteSwipe"
        Me.Size = New System.Drawing.Size(916, 486)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.gridFloors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_floors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icbNosing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBEGoing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbeThread.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbePitch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbeStairwayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teFloors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciStairwayType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciThread, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciGoing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFloor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNosing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFloors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents teFloors As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picBack As System.Windows.Forms.PictureBox
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciBack As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciFloor As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CBEGoing As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbeThread As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbePitch As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbeStairwayType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lciStairwayType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciPitch As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciThread As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciGoing As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents icbNosing As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents lciNosing As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents teLocation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciLocation As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gridFloors As DevExpress.XtraGrid.GridControl
    Friend WithEvents vw_floors As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lciFloors As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFloor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn

End Class
