<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSurveyList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSurveyList))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.grdSurveys = New DevExpress.XtraGrid.GridControl()
        Me.vw_Surveys = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDivname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xolContact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSurveyDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccess = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHeritage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEscapeRoutes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.SIService = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.lciContacts = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciSetCurrent = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcipicBack = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSurveys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_Surveys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciSetCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcipicBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.picBack)
        Me.LayoutControl1.Controls.Add(Me.btnNew)
        Me.LayoutControl1.Controls.Add(Me.grdSurveys)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(914, 181, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(659, 419)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'picBack
        '
        Me.picBack.Image = Global.EvacRemote.My.Resources.Resources.returnButton
        Me.picBack.Location = New System.Drawing.Point(20, 30)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(30, 369)
        Me.picBack.TabIndex = 6
        Me.picBack.TabStop = False
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
        'grdSurveys
        '
        Me.grdSurveys.Location = New System.Drawing.Point(62, 54)
        Me.grdSurveys.MainView = Me.vw_Surveys
        Me.grdSurveys.Name = "grdSurveys"
        Me.grdSurveys.ShowOnlyPredefinedDetails = True
        Me.grdSurveys.Size = New System.Drawing.Size(585, 353)
        Me.grdSurveys.TabIndex = 4
        Me.grdSurveys.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vw_Surveys})
        '
        'vw_Surveys
        '
        Me.vw_Surveys.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colDivname, Me.xolContact, Me.colSurveyDate, Me.colAccess, Me.colHeritage, Me.colEscapeRoutes})
        Me.vw_Surveys.GridControl = Me.grdSurveys
        Me.vw_Surveys.Name = "vw_Surveys"
        Me.vw_Surveys.OptionsBehavior.AllowIncrementalSearch = True
        Me.vw_Surveys.OptionsBehavior.Editable = False
        Me.vw_Surveys.OptionsFind.AlwaysVisible = True
        Me.vw_Surveys.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.vw_Surveys.OptionsView.ShowGroupPanel = False
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
        Me.colDivname.FieldName = "Division"
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
        'colSurveyDate
        '
        Me.colSurveyDate.Caption = "SurveyDate"
        Me.colSurveyDate.FieldName = "SurveyDate"
        Me.colSurveyDate.Name = "colSurveyDate"
        Me.colSurveyDate.Visible = True
        Me.colSurveyDate.VisibleIndex = 2
        '
        'colAccess
        '
        Me.colAccess.Caption = "Access"
        Me.colAccess.FieldName = "Access"
        Me.colAccess.Name = "colAccess"
        Me.colAccess.Visible = True
        Me.colAccess.VisibleIndex = 3
        '
        'colHeritage
        '
        Me.colHeritage.Caption = "Heritage"
        Me.colHeritage.FieldName = "Heritage"
        Me.colHeritage.Name = "colHeritage"
        Me.colHeritage.Visible = True
        Me.colHeritage.VisibleIndex = 4
        '
        'colEscapeRoutes
        '
        Me.colEscapeRoutes.Caption = "EscapeRoutes"
        Me.colEscapeRoutes.FieldName = "EscapeRoutes"
        Me.colEscapeRoutes.Name = "colEscapeRoutes"
        Me.colEscapeRoutes.Visible = True
        Me.colEscapeRoutes.VisibleIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.SIService, Me.lciContacts, Me.lciSetCurrent, Me.lcipicBack})
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
        Me.SIService.CustomizationFormText = "CURRENT CONTACT <color=47, 81, 165>"
        Me.SIService.Location = New System.Drawing.Point(50, 0)
        Me.SIService.Name = "SIService"
        Me.SIService.Size = New System.Drawing.Size(543, 42)
        Me.SIService.Text = "Surveys"
        Me.SIService.TextSize = New System.Drawing.Size(64, 25)
        '
        'lciContacts
        '
        Me.lciContacts.Control = Me.grdSurveys
        Me.lciContacts.CustomizationFormText = "Contacts"
        Me.lciContacts.Location = New System.Drawing.Point(50, 42)
        Me.lciContacts.Name = "lciContacts"
        Me.lciContacts.Size = New System.Drawing.Size(589, 357)
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
        'lcipicBack
        '
        Me.lcipicBack.Control = Me.picBack
        Me.lcipicBack.Location = New System.Drawing.Point(0, 0)
        Me.lcipicBack.MinSize = New System.Drawing.Size(50, 24)
        Me.lcipicBack.Name = "lcipicBack"
        Me.lcipicBack.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 20, 10)
        Me.lcipicBack.Size = New System.Drawing.Size(50, 399)
        Me.lcipicBack.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcipicBack.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lcipicBack.TextSize = New System.Drawing.Size(0, 0)
        Me.lcipicBack.TextToControlDistance = 0
        Me.lcipicBack.TextVisible = False
        '
        'ViewSurveyList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ViewSurveyList"
        Me.Size = New System.Drawing.Size(659, 419)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSurveys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_Surveys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciContacts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciSetCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcipicBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdSurveys As DevExpress.XtraGrid.GridControl
    Friend WithEvents vw_Surveys As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SIService As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lciContacts As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciSetCurrent As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDivname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xolContact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSurveyDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHeritage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEscapeRoutes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents picBack As System.Windows.Forms.PictureBox
    Friend WithEvents lcipicBack As DevExpress.XtraLayout.LayoutControlItem
End Class
