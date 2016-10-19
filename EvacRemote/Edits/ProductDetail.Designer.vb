<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductDetail
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xtbDetails = New DevExpress.XtraTab.XtraTabPage()
        Me.lciDetails = New DevExpress.XtraLayout.LayoutControl()
        Me.rtcFullDetails = New DevExpress.XtraRichEdit.RichEditControl()
        Me.teDescription = New DevExpress.XtraEditors.TextEdit()
        Me.teProductCode = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciProductCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciFullDetails = New DevExpress.XtraLayout.LayoutControlItem()
        Me.xtWeightings = New DevExpress.XtraTab.XtraTabPage()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciBack = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTabControl = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtbDetails.SuspendLayout()
        CType(Me.lciDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lciDetails.SuspendLayout()
        CType(Me.teDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teProductCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciProductCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFullDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.XtraTabControl1)
        Me.LayoutControl1.Controls.Add(Me.picBack)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(895, 419)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(63, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtbDetails
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 395)
        Me.XtraTabControl1.TabIndex = 7
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtbDetails, Me.xtWeightings})
        '
        'xtbDetails
        '
        Me.xtbDetails.Controls.Add(Me.lciDetails)
        Me.xtbDetails.Name = "xtbDetails"
        Me.xtbDetails.Size = New System.Drawing.Size(814, 367)
        Me.xtbDetails.Text = "Details"
        '
        'lciDetails
        '
        Me.lciDetails.Controls.Add(Me.rtcFullDetails)
        Me.lciDetails.Controls.Add(Me.teDescription)
        Me.lciDetails.Controls.Add(Me.teProductCode)
        Me.lciDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lciDetails.Location = New System.Drawing.Point(0, 0)
        Me.lciDetails.Name = "lciDetails"
        Me.lciDetails.Root = Me.LayoutControlGroup2
        Me.lciDetails.Size = New System.Drawing.Size(814, 367)
        Me.lciDetails.TabIndex = 0
        Me.lciDetails.Text = "LayoutControl2"
        '
        'rtcFullDetails
        '
        Me.rtcFullDetails.Location = New System.Drawing.Point(12, 36)
        Me.rtcFullDetails.Name = "rtcFullDetails"
        Me.rtcFullDetails.ReadOnly = True
        Me.rtcFullDetails.Size = New System.Drawing.Size(790, 319)
        Me.rtcFullDetails.TabIndex = 6
        '
        'teDescription
        '
        Me.teDescription.Location = New System.Drawing.Point(301, 12)
        Me.teDescription.Name = "teDescription"
        Me.teDescription.Properties.ReadOnly = True
        Me.teDescription.Size = New System.Drawing.Size(501, 20)
        Me.teDescription.StyleController = Me.lciDetails
        Me.teDescription.TabIndex = 5
        '
        'teProductCode
        '
        Me.teProductCode.Location = New System.Drawing.Point(80, 12)
        Me.teProductCode.Name = "teProductCode"
        Me.teProductCode.Properties.ReadOnly = True
        Me.teProductCode.Size = New System.Drawing.Size(149, 20)
        Me.teProductCode.StyleController = Me.lciDetails
        Me.teProductCode.TabIndex = 4
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciProductCode, Me.lciDescription, Me.lciFullDetails})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(814, 367)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'lciProductCode
        '
        Me.lciProductCode.Control = Me.teProductCode
        Me.lciProductCode.Location = New System.Drawing.Point(0, 0)
        Me.lciProductCode.Name = "lciProductCode"
        Me.lciProductCode.Size = New System.Drawing.Size(221, 24)
        Me.lciProductCode.Text = "Product Code"
        Me.lciProductCode.TextSize = New System.Drawing.Size(65, 13)
        '
        'lciDescription
        '
        Me.lciDescription.Control = Me.teDescription
        Me.lciDescription.Location = New System.Drawing.Point(221, 0)
        Me.lciDescription.Name = "lciDescription"
        Me.lciDescription.Size = New System.Drawing.Size(573, 24)
        Me.lciDescription.Text = "Description"
        Me.lciDescription.TextSize = New System.Drawing.Size(65, 13)
        '
        'lciFullDetails
        '
        Me.lciFullDetails.Control = Me.rtcFullDetails
        Me.lciFullDetails.Location = New System.Drawing.Point(0, 24)
        Me.lciFullDetails.Name = "lciFullDetails"
        Me.lciFullDetails.Size = New System.Drawing.Size(794, 323)
        Me.lciFullDetails.TextSize = New System.Drawing.Size(0, 0)
        Me.lciFullDetails.TextVisible = False
        '
        'xtWeightings
        '
        Me.xtWeightings.Name = "xtWeightings"
        Me.xtWeightings.Size = New System.Drawing.Size(814, 367)
        Me.xtWeightings.Text = "Weightings"
        '
        'picBack
        '
        Me.picBack.Image = Global.EvacRemote.My.Resources.Resources.returnButton
        Me.picBack.Location = New System.Drawing.Point(20, 30)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(31, 369)
        Me.picBack.TabIndex = 4
        Me.picBack.TabStop = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciBack, Me.lciTabControl})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(895, 419)
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
        Me.lciBack.Size = New System.Drawing.Size(51, 399)
        Me.lciBack.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciBack.TextSize = New System.Drawing.Size(0, 0)
        Me.lciBack.TextVisible = False
        '
        'lciTabControl
        '
        Me.lciTabControl.Control = Me.XtraTabControl1
        Me.lciTabControl.Location = New System.Drawing.Point(51, 0)
        Me.lciTabControl.Name = "lciTabControl"
        Me.lciTabControl.Size = New System.Drawing.Size(824, 399)
        Me.lciTabControl.TextSize = New System.Drawing.Size(0, 0)
        Me.lciTabControl.TextVisible = False
        '
        'ProductDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ProductDetail"
        Me.Size = New System.Drawing.Size(895, 419)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtbDetails.ResumeLayout(False)
        CType(Me.lciDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lciDetails.ResumeLayout(False)
        CType(Me.teDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teProductCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciProductCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFullDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents picBack As System.Windows.Forms.PictureBox
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciBack As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtbDetails As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lciDetails As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents rtcFullDetails As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents teDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teProductCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciProductCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciFullDetails As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents xtWeightings As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lciTabControl As DevExpress.XtraLayout.LayoutControlItem

End Class
