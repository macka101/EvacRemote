<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewProduct
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
        Me.components = New System.ComponentModel.Container()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.peImage = New DevExpress.XtraEditors.PictureEdit()
        Me.PdfViewer1 = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.teDescription = New DevExpress.XtraEditors.TextEdit()
        Me.teReference = New DevExpress.XtraEditors.TextEdit()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciBack = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPicture = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.peImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teReference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.peImage)
        Me.LayoutControl1.Controls.Add(Me.PdfViewer1)
        Me.LayoutControl1.Controls.Add(Me.teDescription)
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
        'peImage
        '
        Me.peImage.Location = New System.Drawing.Point(62, 60)
        Me.peImage.Name = "peImage"
        Me.peImage.Size = New System.Drawing.Size(565, 414)
        Me.peImage.StyleController = Me.LayoutControl1
        Me.peImage.TabIndex = 9
        '
        'PdfViewer1
        '
        Me.PdfViewer1.Location = New System.Drawing.Point(631, 12)
        Me.PdfViewer1.Name = "PdfViewer1"
        Me.PdfViewer1.Size = New System.Drawing.Size(273, 462)
        Me.PdfViewer1.TabIndex = 7
        '
        'teDescription
        '
        Me.teDescription.Location = New System.Drawing.Point(127, 36)
        Me.teDescription.Name = "teDescription"
        Me.teDescription.Size = New System.Drawing.Size(500, 20)
        Me.teDescription.StyleController = Me.LayoutControl1
        Me.teDescription.TabIndex = 6
        '
        'teReference
        '
        Me.teReference.Location = New System.Drawing.Point(127, 12)
        Me.teReference.Name = "teReference"
        Me.teReference.Size = New System.Drawing.Size(500, 20)
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
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciBack, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.lciDescription, Me.lciPicture})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(916, 486)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
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
        Me.lciBack.Text = "lciBack"
        Me.lciBack.TextSize = New System.Drawing.Size(0, 0)
        Me.lciBack.TextToControlDistance = 0
        Me.lciBack.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.teReference
        Me.LayoutControlItem2.CustomizationFormText = "Reference"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(50, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(569, 24)
        Me.LayoutControlItem2.Text = "Reference"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PdfViewer1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(619, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(277, 466)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'lciDescription
        '
        Me.lciDescription.Control = Me.teDescription
        Me.lciDescription.CustomizationFormText = "lciDescription"
        Me.lciDescription.Location = New System.Drawing.Point(50, 24)
        Me.lciDescription.Name = "lciDescription"
        Me.lciDescription.Size = New System.Drawing.Size(569, 24)
        Me.lciDescription.Text = "lciDescription"
        Me.lciDescription.TextSize = New System.Drawing.Size(62, 13)
        '
        'lciPicture
        '
        Me.lciPicture.Control = Me.peImage
        Me.lciPicture.CustomizationFormText = "lciPicture"
        Me.lciPicture.Location = New System.Drawing.Point(50, 48)
        Me.lciPicture.Name = "lciPicture"
        Me.lciPicture.Size = New System.Drawing.Size(569, 418)
        Me.lciPicture.Text = "lciPicture"
        Me.lciPicture.TextSize = New System.Drawing.Size(0, 0)
        Me.lciPicture.TextToControlDistance = 0
        Me.lciPicture.TextVisible = False
        '
        'viewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "viewProduct"
        Me.Size = New System.Drawing.Size(916, 486)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.peImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teReference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents PdfViewer1 As DevExpress.XtraPdfViewer.PdfViewer
    Friend WithEvents teDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teReference As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picBack As System.Windows.Forms.PictureBox
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciBack As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents peImage As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lciPicture As DevExpress.XtraLayout.LayoutControlItem

End Class
