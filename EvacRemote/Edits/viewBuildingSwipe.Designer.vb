<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewBuildingSwipe
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
        Me.meDetails = New DevExpress.XtraEditors.MemoEdit()
        Me.teReference = New DevExpress.XtraEditors.TextEdit()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciBack = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciBuildingName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDetails = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.meDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teReference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciBuildingName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.meDetails)
        Me.LayoutControl1.Controls.Add(Me.teReference)
        Me.LayoutControl1.Controls.Add(Me.picBack)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(916, 486)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'meDetails
        '
        Me.meDetails.Location = New System.Drawing.Point(62, 52)
        Me.meDetails.Name = "meDetails"
        Me.meDetails.Size = New System.Drawing.Size(842, 422)
        Me.meDetails.StyleController = Me.LayoutControl1
        Me.meDetails.TabIndex = 7
        '
        'teReference
        '
        Me.teReference.Location = New System.Drawing.Point(97, 12)
        Me.teReference.Name = "teReference"
        Me.teReference.Size = New System.Drawing.Size(807, 20)
        Me.teReference.StyleController = Me.LayoutControl1
        Me.teReference.TabIndex = 5
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
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciBack, Me.lciBuildingName, Me.lciDetails})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
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
        'lciBuildingName
        '
        Me.lciBuildingName.Control = Me.teReference
        Me.lciBuildingName.CustomizationFormText = "Reference"
        Me.lciBuildingName.Location = New System.Drawing.Point(50, 0)
        Me.lciBuildingName.Name = "lciBuildingName"
        Me.lciBuildingName.Size = New System.Drawing.Size(846, 24)
        Me.lciBuildingName.Text = "Name"
        Me.lciBuildingName.TextSize = New System.Drawing.Size(32, 13)
        '
        'lciDetails
        '
        Me.lciDetails.Control = Me.meDetails
        Me.lciDetails.CustomizationFormText = "Details"
        Me.lciDetails.Location = New System.Drawing.Point(50, 24)
        Me.lciDetails.Name = "lciDetails"
        Me.lciDetails.Size = New System.Drawing.Size(846, 442)
        Me.lciDetails.Text = "Details"
        Me.lciDetails.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciDetails.TextSize = New System.Drawing.Size(32, 13)
        '
        'viewBuildingSwipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "viewBuildingSwipe"
        Me.Size = New System.Drawing.Size(916, 486)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.meDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teReference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciBuildingName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents teReference As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picBack As System.Windows.Forms.PictureBox
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciBack As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciBuildingName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents meDetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lciDetails As DevExpress.XtraLayout.LayoutControlItem

End Class
