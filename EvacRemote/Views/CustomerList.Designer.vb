<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerList))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.tePostCode = New DevExpress.XtraEditors.TextEdit()
        Me.teName = New DevExpress.XtraEditors.TextEdit()
        Me.btnSetCurrent = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.SIContact = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.lciContacts = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciSetCurrent = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPostCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciFind = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.tePostCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciSetCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPostCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnFind)
        Me.LayoutControl1.Controls.Add(Me.tePostCode)
        Me.LayoutControl1.Controls.Add(Me.teName)
        Me.LayoutControl1.Controls.Add(Me.btnSetCurrent)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(914, 181, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(659, 419)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(568, 54)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(79, 22)
        Me.btnFind.StyleController = Me.LayoutControl1
        Me.btnFind.TabIndex = 8
        Me.btnFind.Text = "&Find"
        '
        'tePostCode
        '
        Me.tePostCode.Location = New System.Drawing.Point(480, 54)
        Me.tePostCode.Name = "tePostCode"
        Me.tePostCode.Size = New System.Drawing.Size(84, 20)
        Me.tePostCode.StyleController = Me.LayoutControl1
        Me.tePostCode.TabIndex = 7
        '
        'teName
        '
        Me.teName.Location = New System.Drawing.Point(90, 54)
        Me.teName.Name = "teName"
        Me.teName.Size = New System.Drawing.Size(308, 20)
        Me.teName.StyleController = Me.LayoutControl1
        Me.teName.TabIndex = 6
        '
        'btnSetCurrent
        '
        Me.btnSetCurrent.Enabled = False
        Me.btnSetCurrent.Image = CType(resources.GetObject("btnSetCurrent.Image"), System.Drawing.Image)
        Me.btnSetCurrent.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSetCurrent.Location = New System.Drawing.Point(605, 12)
        Me.btnSetCurrent.MaximumSize = New System.Drawing.Size(42, 38)
        Me.btnSetCurrent.MinimumSize = New System.Drawing.Size(42, 38)
        Me.btnSetCurrent.Name = "btnSetCurrent"
        Me.btnSetCurrent.Size = New System.Drawing.Size(42, 38)
        Me.btnSetCurrent.StyleController = Me.LayoutControl1
        Me.btnSetCurrent.TabIndex = 5
        Me.btnSetCurrent.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 80)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(635, 327)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.SIContact, Me.lciContacts, Me.lciSetCurrent, Me.lciName, Me.lciPostCode, Me.lciFind})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(659, 419)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'SIContact
        '
        Me.SIContact.AllowHotTrack = False
        Me.SIContact.AllowHtmlStringInCaption = True
        Me.SIContact.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIContact.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.SIContact.AppearanceItemCaption.Options.UseFont = True
        Me.SIContact.AppearanceItemCaption.Options.UseForeColor = True
        Me.SIContact.CustomizationFormText = "CURRENT CONTACT <color=47, 81, 165>"
        Me.SIContact.Location = New System.Drawing.Point(0, 0)
        Me.SIContact.Name = "SimpleLabelItem1"
        Me.SIContact.Size = New System.Drawing.Size(593, 42)
        Me.SIContact.Text = "Contacts"
        Me.SIContact.TextSize = New System.Drawing.Size(73, 25)
        '
        'lciContacts
        '
        Me.lciContacts.Control = Me.GridControl1
        Me.lciContacts.CustomizationFormText = "Contacts"
        Me.lciContacts.Location = New System.Drawing.Point(0, 68)
        Me.lciContacts.Name = "lciContacts"
        Me.lciContacts.Size = New System.Drawing.Size(639, 331)
        Me.lciContacts.Text = "Contacts"
        Me.lciContacts.TextSize = New System.Drawing.Size(0, 0)
        Me.lciContacts.TextVisible = False
        '
        'lciSetCurrent
        '
        Me.lciSetCurrent.Control = Me.btnSetCurrent
        Me.lciSetCurrent.CustomizationFormText = "lciSetCurrent"
        Me.lciSetCurrent.Location = New System.Drawing.Point(593, 0)
        Me.lciSetCurrent.Name = "lciSetCurrent"
        Me.lciSetCurrent.Size = New System.Drawing.Size(46, 42)
        Me.lciSetCurrent.TextSize = New System.Drawing.Size(0, 0)
        Me.lciSetCurrent.TextVisible = False
        '
        'lciName
        '
        Me.lciName.Control = Me.teName
        Me.lciName.CustomizationFormText = "Name"
        Me.lciName.Location = New System.Drawing.Point(0, 42)
        Me.lciName.Name = "lciName"
        Me.lciName.Size = New System.Drawing.Size(390, 26)
        Me.lciName.Text = "Name"
        Me.lciName.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lciName.TextSize = New System.Drawing.Size(73, 13)
        Me.lciName.TextToControlDistance = 5
        '
        'lciPostCode
        '
        Me.lciPostCode.Control = Me.tePostCode
        Me.lciPostCode.CustomizationFormText = "Post Code"
        Me.lciPostCode.Location = New System.Drawing.Point(390, 42)
        Me.lciPostCode.Name = "lciPostCode"
        Me.lciPostCode.Size = New System.Drawing.Size(166, 26)
        Me.lciPostCode.Text = "Post Code"
        Me.lciPostCode.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lciPostCode.TextSize = New System.Drawing.Size(73, 13)
        Me.lciPostCode.TextToControlDistance = 5
        '
        'lciFind
        '
        Me.lciFind.Control = Me.btnFind
        Me.lciFind.CustomizationFormText = "LayoutControlItem3"
        Me.lciFind.Location = New System.Drawing.Point(556, 42)
        Me.lciFind.Name = "lciFind"
        Me.lciFind.Size = New System.Drawing.Size(83, 26)
        Me.lciFind.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lciFind.TextSize = New System.Drawing.Size(0, 0)
        Me.lciFind.TextToControlDistance = 0
        Me.lciFind.TextVisible = False
        '
        'CustomerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "CustomerList"
        Me.Size = New System.Drawing.Size(659, 419)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.tePostCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciContacts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciSetCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPostCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnSetCurrent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SIContact As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lciContacts As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciSetCurrent As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tePostCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciPostCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciFind As DevExpress.XtraLayout.LayoutControlItem

End Class
