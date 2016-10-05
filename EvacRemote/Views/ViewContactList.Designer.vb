<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewContactList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewContactList))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnSetCurrent = New DevExpress.XtraEditors.SimpleButton()
        Me.grdCompanies = New DevExpress.XtraGrid.GridControl()
        Me.vw_Companies = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDivname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xolContact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPostCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.SIContact = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.lciContacts = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciSetCurrent = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.grdCompanies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_Companies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciSetCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnSetCurrent)
        Me.LayoutControl1.Controls.Add(Me.grdCompanies)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(914, 181, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(659, 419)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
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
        'grdCompanies
        '
        Me.grdCompanies.Location = New System.Drawing.Point(12, 54)
        Me.grdCompanies.MainView = Me.vw_Companies
        Me.grdCompanies.Name = "grdCompanies"
        Me.grdCompanies.ShowOnlyPredefinedDetails = True
        Me.grdCompanies.Size = New System.Drawing.Size(635, 353)
        Me.grdCompanies.TabIndex = 4
        Me.grdCompanies.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vw_Companies})
        '
        'vw_Companies
        '
        Me.vw_Companies.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colDivname, Me.xolContact, Me.colAddress1, Me.colAddress2, Me.colAddress3, Me.colAddress4, Me.colPostCode})
        Me.vw_Companies.GridControl = Me.grdCompanies
        Me.vw_Companies.Name = "vw_Companies"
        Me.vw_Companies.OptionsBehavior.AllowIncrementalSearch = True
        Me.vw_Companies.OptionsBehavior.Editable = False
        Me.vw_Companies.OptionsFind.AlwaysVisible = True
        Me.vw_Companies.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.vw_Companies.OptionsView.ShowGroupPanel = False
        '
        'colOid
        '
        Me.colOid.Caption = "Oid"
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'colDivname
        '
        Me.colDivname.Caption = "Division"
        Me.colDivname.FieldName = "Divname"
        Me.colDivname.Name = "colDivname"
        Me.colDivname.Visible = True
        Me.colDivname.VisibleIndex = 0
        '
        'xolContact
        '
        Me.xolContact.Caption = "Contact"
        Me.xolContact.FieldName = "Contact"
        Me.xolContact.Name = "xolContact"
        Me.xolContact.Visible = True
        Me.xolContact.VisibleIndex = 1
        '
        'colAddress1
        '
        Me.colAddress1.Caption = "Address1"
        Me.colAddress1.FieldName = "Address1"
        Me.colAddress1.Name = "colAddress1"
        Me.colAddress1.Visible = True
        Me.colAddress1.VisibleIndex = 2
        '
        'colAddress2
        '
        Me.colAddress2.Caption = "Address2"
        Me.colAddress2.FieldName = "Address2"
        Me.colAddress2.Name = "colAddress2"
        Me.colAddress2.Visible = True
        Me.colAddress2.VisibleIndex = 3
        '
        'colAddress3
        '
        Me.colAddress3.Caption = "Address3"
        Me.colAddress3.FieldName = "Address3"
        Me.colAddress3.Name = "colAddress3"
        Me.colAddress3.Visible = True
        Me.colAddress3.VisibleIndex = 4
        '
        'colAddress4
        '
        Me.colAddress4.Caption = "Address4"
        Me.colAddress4.FieldName = "Address4"
        Me.colAddress4.Name = "colAddress4"
        Me.colAddress4.Visible = True
        Me.colAddress4.VisibleIndex = 5
        '
        'colPostCode
        '
        Me.colPostCode.Caption = "PostCode"
        Me.colPostCode.FieldName = "PostCode"
        Me.colPostCode.Name = "colPostCode"
        Me.colPostCode.Visible = True
        Me.colPostCode.VisibleIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.SIContact, Me.lciContacts, Me.lciSetCurrent})
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
        Me.lciContacts.Control = Me.grdCompanies
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
        Me.lciSetCurrent.Control = Me.btnSetCurrent
        Me.lciSetCurrent.CustomizationFormText = "lciSetCurrent"
        Me.lciSetCurrent.Location = New System.Drawing.Point(593, 0)
        Me.lciSetCurrent.Name = "lciSetCurrent"
        Me.lciSetCurrent.Size = New System.Drawing.Size(46, 42)
        Me.lciSetCurrent.TextSize = New System.Drawing.Size(0, 0)
        Me.lciSetCurrent.TextVisible = False
        '
        'ContactList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ContactList"
        Me.Size = New System.Drawing.Size(659, 419)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.grdCompanies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_Companies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciContacts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciSetCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnSetCurrent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdCompanies As DevExpress.XtraGrid.GridControl
    Friend WithEvents vw_Companies As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SIContact As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lciContacts As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciSetCurrent As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDivname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPostCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xolContact As DevExpress.XtraGrid.Columns.GridColumn

End Class
