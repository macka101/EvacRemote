<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportProducts
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SpreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.lblDetails = New DevExpress.XtraEditors.LabelControl()
        Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton()
        Me.pg_Progress = New DevExpress.XtraEditors.ProgressBarControl()
        Me.txtfileName = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciFile = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciImport = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciSheet = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.pg_Progress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciSheet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SpreadsheetControl1)
        Me.LayoutControl1.Controls.Add(Me.btnImport)
        Me.LayoutControl1.Controls.Add(Me.lblDetails)
        Me.LayoutControl1.Controls.Add(Me.btnBrowse)
        Me.LayoutControl1.Controls.Add(Me.pg_Progress)
        Me.LayoutControl1.Controls.Add(Me.txtfileName)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(8, 8)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(993, 462)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SpreadsheetControl1
        '
        Me.SpreadsheetControl1.Location = New System.Drawing.Point(12, 55)
        Me.SpreadsheetControl1.Name = "SpreadsheetControl1"
        Me.SpreadsheetControl1.Size = New System.Drawing.Size(969, 369)
        Me.SpreadsheetControl1.TabIndex = 14
        Me.SpreadsheetControl1.Text = "SpreadsheetControl1"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(12, 428)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(105, 22)
        Me.btnImport.StyleController = Me.LayoutControl1
        Me.btnImport.TabIndex = 13
        Me.btnImport.Text = "Import"
        '
        'lblDetails
        '
        Me.lblDetails.Location = New System.Drawing.Point(12, 38)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(66, 13)
        Me.lblDetails.StyleController = Me.LayoutControl1
        Me.lblDetails.TabIndex = 11
        Me.lblDetails.Text = "LabelControl1"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(926, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(55, 22)
        Me.btnBrowse.StyleController = Me.LayoutControl1
        Me.btnBrowse.TabIndex = 10
        Me.btnBrowse.Text = "..."
        '
        'pg_Progress
        '
        Me.pg_Progress.Location = New System.Drawing.Point(121, 428)
        Me.pg_Progress.Name = "pg_Progress"
        Me.pg_Progress.Size = New System.Drawing.Size(860, 18)
        Me.pg_Progress.StyleController = Me.LayoutControl1
        Me.pg_Progress.TabIndex = 8
        '
        'txtfileName
        '
        Me.txtfileName.Location = New System.Drawing.Point(68, 12)
        Me.txtfileName.Name = "txtfileName"
        Me.txtfileName.Size = New System.Drawing.Size(854, 20)
        Me.txtfileName.StyleController = Me.LayoutControl1
        Me.txtfileName.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciFile, Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.lciImport, Me.lciSheet})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(993, 462)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lciFile
        '
        Me.lciFile.Control = Me.txtfileName
        Me.lciFile.CustomizationFormText = "Import File"
        Me.lciFile.Location = New System.Drawing.Point(0, 0)
        Me.lciFile.Name = "lciFile"
        Me.lciFile.Size = New System.Drawing.Size(914, 26)
        Me.lciFile.Text = "Import File"
        Me.lciFile.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lciFile.TextSize = New System.Drawing.Size(51, 13)
        Me.lciFile.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.pg_Progress
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(109, 416)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(864, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnBrowse
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(914, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(59, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.lblDetails
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(973, 17)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'lciImport
        '
        Me.lciImport.Control = Me.btnImport
        Me.lciImport.CustomizationFormText = "lciImport"
        Me.lciImport.Location = New System.Drawing.Point(0, 416)
        Me.lciImport.Name = "lciImport"
        Me.lciImport.Size = New System.Drawing.Size(109, 26)
        Me.lciImport.TextSize = New System.Drawing.Size(0, 0)
        Me.lciImport.TextVisible = False
        '
        'lciSheet
        '
        Me.lciSheet.Control = Me.SpreadsheetControl1
        Me.lciSheet.CustomizationFormText = "lciSheet"
        Me.lciSheet.Location = New System.Drawing.Point(0, 43)
        Me.lciSheet.Name = "lciSheet"
        Me.lciSheet.Size = New System.Drawing.Size(973, 373)
        Me.lciSheet.TextSize = New System.Drawing.Size(0, 0)
        Me.lciSheet.TextVisible = False
        '
        'frmMImportHospitalEstimates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 505)
        Me.Controls.Add(Me.LayoutControl1)
        Me.MinimumSize = New System.Drawing.Size(106, 106)
        Me.Name = "frmMImportHospitalEstimates"
        Me.Text = "Import Estimates"
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.pg_Progress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciSheet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lblDetails As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pg_Progress As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents txtfileName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciFile As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lciImport As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SpreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents lciSheet As DevExpress.XtraLayout.LayoutControlItem
End Class
