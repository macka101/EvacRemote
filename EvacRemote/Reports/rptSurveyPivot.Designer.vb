<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptSurveyPivot
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SurveyId = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
        Me.fieldOid1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldEscapeRoute1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldBuilding1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldSurvey1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldLocation1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldType1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldStairWayType1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldTread1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldNosing1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldGlass1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldPitch1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldWidth1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldGoing1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldBedBound1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldBarriatric1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldComplexDisability1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldSmallStorage1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldBedAccess1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldMisuse1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldMovingAndHandling1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldRecommendedProduct1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldProduct1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldNotes1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldCreatedBy1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldCreatedAt1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldModifiedBy1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldModifiedAt1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldThis1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldLoading1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldClassInfo1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldSession1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldIsLoading1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldIsDeleted1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 30.20833!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5})
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 100.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.LightCoral
        Me.XrLabel5.Dpi = 100.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.ForeColor = System.Drawing.Color.Snow
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 37.5!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(616.8344!, 35.0!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.Text = "Survey Pivot"
        '
        'SurveyId
        '
        Me.SurveyId.Description = "SurveyId"
        Me.SurveyId.Name = "SurveyId"
        Me.SurveyId.Type = GetType(Integer)
        Me.SurveyId.ValueInfo = "0"
        '
        'XpCollection1
        '
        Me.XpCollection1.LoadingEnabled = False
        Me.XpCollection1.ObjectType = GetType(Esso.Data.EvacSurvey)
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
        Me.DetailReport.DataMember = "Floors"
        Me.DetailReport.DataSource = Me.XpCollection1
        Me.DetailReport.Dpi = 100.0!
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPivotGrid1})
        Me.Detail1.Dpi = 100.0!
        Me.Detail1.HeightF = 100.0!
        Me.Detail1.Name = "Detail1"
        '
        'XrPivotGrid1
        '
        Me.XrPivotGrid1.DataMember = "Floors"
        Me.XrPivotGrid1.DataSource = Me.XpCollection1
        Me.XrPivotGrid1.Dpi = 100.0!
        Me.XrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.fieldOid1, Me.fieldEscapeRoute1, Me.fieldBuilding1, Me.fieldSurvey1, Me.fieldLocation1, Me.fieldType1, Me.fieldStairWayType1, Me.fieldTread1, Me.fieldNosing1, Me.fieldGlass1, Me.fieldPitch1, Me.fieldWidth1, Me.fieldGoing1, Me.fieldBedBound1, Me.fieldBarriatric1, Me.fieldComplexDisability1, Me.fieldSmallStorage1, Me.fieldBedAccess1, Me.fieldMisuse1, Me.fieldMovingAndHandling1, Me.fieldRecommendedProduct1, Me.fieldProduct1, Me.fieldNotes1, Me.fieldCreatedBy1, Me.fieldCreatedAt1, Me.fieldModifiedBy1, Me.fieldModifiedAt1, Me.fieldThis1, Me.fieldLoading1, Me.fieldClassInfo1, Me.fieldSession1, Me.fieldIsLoading1, Me.fieldIsDeleted1})
        Me.XrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.XrPivotGrid1.Name = "XrPivotGrid1"
        Me.XrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3
        Me.XrPivotGrid1.OptionsView.ShowFilterHeaders = False
        Me.XrPivotGrid1.SizeF = New System.Drawing.SizeF(651.0!, 90.0!)
        '
        'fieldOid1
        '
        Me.fieldOid1.AreaIndex = 2
        Me.fieldOid1.FieldName = "Oid"
        Me.fieldOid1.Name = "fieldOid1"
        '
        'fieldEscapeRoute1
        '
        Me.fieldEscapeRoute1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldEscapeRoute1.AreaIndex = 0
        Me.fieldEscapeRoute1.FieldName = "EscapeRoute"
        Me.fieldEscapeRoute1.Name = "fieldEscapeRoute1"
        Me.fieldEscapeRoute1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldBuilding1
        '
        Me.fieldBuilding1.AreaIndex = 0
        Me.fieldBuilding1.FieldName = "Building"
        Me.fieldBuilding1.Name = "fieldBuilding1"
        '
        'fieldSurvey1
        '
        Me.fieldSurvey1.AreaIndex = 1
        Me.fieldSurvey1.FieldName = "Survey"
        Me.fieldSurvey1.Name = "fieldSurvey1"
        '
        'fieldLocation1
        '
        Me.fieldLocation1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldLocation1.AreaIndex = 1
        Me.fieldLocation1.FieldName = "Location"
        Me.fieldLocation1.Name = "fieldLocation1"
        '
        'fieldType1
        '
        Me.fieldType1.AreaIndex = 3
        Me.fieldType1.FieldName = "Type"
        Me.fieldType1.Name = "fieldType1"
        '
        'fieldStairWayType1
        '
        Me.fieldStairWayType1.AreaIndex = 4
        Me.fieldStairWayType1.FieldName = "StairWayType"
        Me.fieldStairWayType1.Name = "fieldStairWayType1"
        '
        'fieldTread1
        '
        Me.fieldTread1.AreaIndex = 5
        Me.fieldTread1.FieldName = "Tread"
        Me.fieldTread1.Name = "fieldTread1"
        '
        'fieldNosing1
        '
        Me.fieldNosing1.AreaIndex = 6
        Me.fieldNosing1.FieldName = "Nosing"
        Me.fieldNosing1.Name = "fieldNosing1"
        '
        'fieldGlass1
        '
        Me.fieldGlass1.AreaIndex = 7
        Me.fieldGlass1.FieldName = "Glass"
        Me.fieldGlass1.Name = "fieldGlass1"
        '
        'fieldPitch1
        '
        Me.fieldPitch1.AreaIndex = 8
        Me.fieldPitch1.FieldName = "Pitch"
        Me.fieldPitch1.Name = "fieldPitch1"
        '
        'fieldWidth1
        '
        Me.fieldWidth1.AreaIndex = 9
        Me.fieldWidth1.FieldName = "Width"
        Me.fieldWidth1.Name = "fieldWidth1"
        '
        'fieldGoing1
        '
        Me.fieldGoing1.AreaIndex = 10
        Me.fieldGoing1.FieldName = "Going"
        Me.fieldGoing1.Name = "fieldGoing1"
        '
        'fieldBedBound1
        '
        Me.fieldBedBound1.AreaIndex = 11
        Me.fieldBedBound1.FieldName = "BedBound"
        Me.fieldBedBound1.Name = "fieldBedBound1"
        '
        'fieldBarriatric1
        '
        Me.fieldBarriatric1.AreaIndex = 12
        Me.fieldBarriatric1.FieldName = "Barriatric"
        Me.fieldBarriatric1.Name = "fieldBarriatric1"
        '
        'fieldComplexDisability1
        '
        Me.fieldComplexDisability1.AreaIndex = 13
        Me.fieldComplexDisability1.FieldName = "ComplexDisability"
        Me.fieldComplexDisability1.Name = "fieldComplexDisability1"
        '
        'fieldSmallStorage1
        '
        Me.fieldSmallStorage1.AreaIndex = 14
        Me.fieldSmallStorage1.FieldName = "SmallStorage"
        Me.fieldSmallStorage1.Name = "fieldSmallStorage1"
        '
        'fieldBedAccess1
        '
        Me.fieldBedAccess1.AreaIndex = 15
        Me.fieldBedAccess1.FieldName = "BedAccess"
        Me.fieldBedAccess1.Name = "fieldBedAccess1"
        '
        'fieldMisuse1
        '
        Me.fieldMisuse1.AreaIndex = 16
        Me.fieldMisuse1.FieldName = "Misuse"
        Me.fieldMisuse1.Name = "fieldMisuse1"
        '
        'fieldMovingAndHandling1
        '
        Me.fieldMovingAndHandling1.AreaIndex = 17
        Me.fieldMovingAndHandling1.FieldName = "MovingAndHandling"
        Me.fieldMovingAndHandling1.Name = "fieldMovingAndHandling1"
        '
        'fieldRecommendedProduct1
        '
        Me.fieldRecommendedProduct1.AreaIndex = 18
        Me.fieldRecommendedProduct1.FieldName = "RecommendedProduct"
        Me.fieldRecommendedProduct1.Name = "fieldRecommendedProduct1"
        '
        'fieldProduct1
        '
        Me.fieldProduct1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldProduct1.AreaIndex = 0
        Me.fieldProduct1.FieldName = "Product"
        Me.fieldProduct1.Name = "fieldProduct1"
        '
        'fieldNotes1
        '
        Me.fieldNotes1.AreaIndex = 19
        Me.fieldNotes1.FieldName = "Notes"
        Me.fieldNotes1.Name = "fieldNotes1"
        '
        'fieldCreatedBy1
        '
        Me.fieldCreatedBy1.AreaIndex = 20
        Me.fieldCreatedBy1.FieldName = "CreatedBy"
        Me.fieldCreatedBy1.Name = "fieldCreatedBy1"
        '
        'fieldCreatedAt1
        '
        Me.fieldCreatedAt1.AreaIndex = 21
        Me.fieldCreatedAt1.FieldName = "CreatedAt"
        Me.fieldCreatedAt1.Name = "fieldCreatedAt1"
        '
        'fieldModifiedBy1
        '
        Me.fieldModifiedBy1.AreaIndex = 22
        Me.fieldModifiedBy1.FieldName = "ModifiedBy"
        Me.fieldModifiedBy1.Name = "fieldModifiedBy1"
        '
        'fieldModifiedAt1
        '
        Me.fieldModifiedAt1.AreaIndex = 23
        Me.fieldModifiedAt1.FieldName = "ModifiedAt"
        Me.fieldModifiedAt1.Name = "fieldModifiedAt1"
        '
        'fieldThis1
        '
        Me.fieldThis1.AreaIndex = 24
        Me.fieldThis1.FieldName = "This"
        Me.fieldThis1.Name = "fieldThis1"
        '
        'fieldLoading1
        '
        Me.fieldLoading1.AreaIndex = 25
        Me.fieldLoading1.FieldName = "Loading"
        Me.fieldLoading1.Name = "fieldLoading1"
        '
        'fieldClassInfo1
        '
        Me.fieldClassInfo1.AreaIndex = 26
        Me.fieldClassInfo1.FieldName = "ClassInfo"
        Me.fieldClassInfo1.Name = "fieldClassInfo1"
        '
        'fieldSession1
        '
        Me.fieldSession1.AreaIndex = 27
        Me.fieldSession1.FieldName = "Session"
        Me.fieldSession1.Name = "fieldSession1"
        '
        'fieldIsLoading1
        '
        Me.fieldIsLoading1.AreaIndex = 28
        Me.fieldIsLoading1.FieldName = "IsLoading"
        Me.fieldIsLoading1.Name = "fieldIsLoading1"
        '
        'fieldIsDeleted1
        '
        Me.fieldIsDeleted1.AreaIndex = 29
        Me.fieldIsDeleted1.FieldName = "IsDeleted"
        Me.fieldIsDeleted1.Name = "fieldIsDeleted1"
        '
        'rptSurveyPivot
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
        Me.DataSource = Me.XpCollection1
        Me.Margins = New System.Drawing.Printing.Margins(99, 100, 100, 100)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.SurveyId})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "16.1"
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SurveyId As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents fieldOid1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldEscapeRoute1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldBuilding1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldSurvey1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldLocation1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldType1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldStairWayType1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldTread1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldNosing1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldGlass1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldPitch1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldWidth1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldGoing1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldBedBound1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldBarriatric1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldComplexDisability1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldSmallStorage1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldBedAccess1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldMisuse1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldMovingAndHandling1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldRecommendedProduct1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldProduct1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldNotes1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldCreatedBy1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldCreatedAt1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldModifiedBy1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldModifiedAt1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldThis1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldLoading1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldClassInfo1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldSession1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldIsLoading1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldIsDeleted1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
End Class
