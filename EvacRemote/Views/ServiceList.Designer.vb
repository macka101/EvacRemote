<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiceList))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.grdService = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.vw_Service = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColDivision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colServiceDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSignature = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSigner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.SIService = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.lciContacts = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciSetCurrent = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.grdService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_Service, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciSetCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnNew)
        Me.LayoutControl1.Controls.Add(Me.grdService)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(914, 181, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(659, 419)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNew.Location = New System.Drawing.Point(605, 12)
        Me.btnNew.MaximumSize = New System.Drawing.Size(42, 38)
        Me.btnNew.MinimumSize = New System.Drawing.Size(42, 38)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(42, 38)
        Me.btnNew.StyleController = Me.LayoutControl1
        Me.btnNew.TabIndex = 5
        Me.btnNew.Visible = False
        '
        'grdService
        '
        Me.grdService.DataSource = Me.XpCollection1
        Me.grdService.Location = New System.Drawing.Point(12, 54)
        Me.grdService.MainView = Me.vw_Service
        Me.grdService.Name = "grdService"
        Me.grdService.ShowOnlyPredefinedDetails = True
        Me.grdService.Size = New System.Drawing.Size(635, 353)
        Me.grdService.TabIndex = 4
        Me.grdService.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vw_Service})
        '
        'XpCollection1
        '
        Me.XpCollection1.ObjectType = GetType(Esso.Data.EvacService)
        '
        'vw_Service
        '
        Me.vw_Service.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColDivision, Me.GridColumn2, Me.colServiceDate, Me.colSignature, Me.colSigner, Me.colNotes})
        Me.vw_Service.GridControl = Me.grdService
        Me.vw_Service.Name = "vw_Service"
        Me.vw_Service.OptionsBehavior.AllowIncrementalSearch = True
        Me.vw_Service.OptionsBehavior.Editable = False
        Me.vw_Service.OptionsFind.AlwaysVisible = True
        Me.vw_Service.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.vw_Service.OptionsView.ShowGroupPanel = False
        '
        'ColDivision
        '
        Me.ColDivision.FieldName = "Division!"
        Me.ColDivision.Name = "ColDivision"
        Me.ColDivision.Visible = True
        Me.ColDivision.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Division!Key"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'colServiceDate
        '
        Me.colServiceDate.FieldName = "ServiceDate"
        Me.colServiceDate.Name = "colServiceDate"
        Me.colServiceDate.Visible = True
        Me.colServiceDate.VisibleIndex = 2
        '
        'colSignature
        '
        Me.colSignature.FieldName = "Signature"
        Me.colSignature.Name = "colSignature"
        Me.colSignature.Visible = True
        Me.colSignature.VisibleIndex = 3
        '
        'colSigner
        '
        Me.colSigner.FieldName = "Signer"
        Me.colSigner.Name = "colSigner"
        Me.colSigner.Visible = True
        Me.colSigner.VisibleIndex = 4
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.SIService, Me.lciContacts, Me.lciSetCurrent})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(659, 419)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'SIService
        '
        Me.SIService.AllowHotTrack = False
        Me.SIService.AllowHtmlStringInCaption = True
        Me.SIService.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIService.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.SIService.AppearanceItemCaption.Options.UseFont = True
        Me.SIService.AppearanceItemCaption.Options.UseForeColor = True
        Me.SIService.CustomizationFormText = "CURRENT Service <color=47, 81, 165>"
        Me.SIService.Location = New System.Drawing.Point(0, 0)
        Me.SIService.Name = "SIService"
        Me.SIService.Size = New System.Drawing.Size(593, 42)
        Me.SIService.Text = "Services"
        Me.SIService.TextSize = New System.Drawing.Size(68, 25)
        '
        'lciContacts
        '
        Me.lciContacts.Control = Me.grdService
        Me.lciContacts.CustomizationFormText = "Contacts"
        Me.lciContacts.Location = New System.Drawing.Point(0, 42)
        Me.lciContacts.Name = "lciContacts"
        Me.lciContacts.Size = New System.Drawing.Size(639, 357)
        Me.lciContacts.Text = "Contacts"
        Me.lciContacts.TextSize = New System.Drawing.Size(0, 0)
        Me.lciContacts.TextVisible = False
        '
        'lciSetCurrent
        '
        Me.lciSetCurrent.Control = Me.btnNew
        Me.lciSetCurrent.CustomizationFormText = "lciSetCurrent"
        Me.lciSetCurrent.Location = New System.Drawing.Point(593, 0)
        Me.lciSetCurrent.Name = "lciSetCurrent"
        Me.lciSetCurrent.Size = New System.Drawing.Size(46, 42)
        Me.lciSetCurrent.TextSize = New System.Drawing.Size(0, 0)
        Me.lciSetCurrent.TextVisible = False
        '
        'ServiceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ServiceList"
        Me.Size = New System.Drawing.Size(659, 419)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.grdService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_Service, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciContacts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciSetCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdService As DevExpress.XtraGrid.GridControl
    Friend WithEvents vw_Service As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SIService As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lciContacts As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciSetCurrent As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents ColDivision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServiceDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignature As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSigner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn

End Class
