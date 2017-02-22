<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class xptSurveyProducts
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xptSurveyProducts))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrRichText3 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SurveyId = New DevExpress.XtraReports.Parameters.Parameter()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XpCollection2 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Dpi = 100.0!
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(627.0!, 25.0!)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10})
        Me.XrTableRow2.Dpi = 100.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Dpi = 100.0!
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "Product Code"
        Me.XrTableCell6.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Dpi = 100.0!
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "XrTableCell2"
        Me.XrTableCell7.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Dpi = 100.0!
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Text = "XrTableCell3"
        Me.XrTableCell8.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Dpi = 100.0!
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Text = "XrTableCell4"
        Me.XrTableCell9.Weight = 1.0R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Dpi = 100.0!
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Text = "XrTableCell5"
        Me.XrTableCell10.Weight = 1.0R
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText3, Me.XrRichText2})
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 310.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText3
        '
        Me.XrRichText3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Rtf", Nothing, "Contact.FullAddressBlock")})
        Me.XrRichText3.Dpi = 100.0!
        Me.XrRichText3.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.XrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 164.5417!)
        Me.XrRichText3.Name = "XrRichText3"
        Me.XrRichText3.SerializableRtfString = resources.GetString("XrRichText3.SerializableRtfString")
        Me.XrRichText3.SizeF = New System.Drawing.SizeF(351.0417!, 101.125!)
        Me.XrRichText3.StylePriority.UseFont = False
        '
        'XrRichText2
        '
        Me.XrRichText2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Rtf", Nothing, "Contact.FullName")})
        Me.XrRichText2.Dpi = 100.0!
        Me.XrRichText2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.XrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 129.1667!)
        Me.XrRichText2.Name = "XrRichText2"
        Me.XrRichText2.SerializableRtfString = resources.GetString("XrRichText2.SerializableRtfString")
        Me.XrRichText2.SizeF = New System.Drawing.SizeF(351.0417!, 22.91663!)
        Me.XrRichText2.StylePriority.UseFont = False
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SurveyId
        '
        Me.SurveyId.Description = "Parameter1"
        Me.SurveyId.Name = "SurveyId"
        Me.SurveyId.Type = GetType(System.Guid)
        Me.SurveyId.ValueInfo = "00000000-0000-0000-0000-000000000000"
        Me.SurveyId.Visible = False
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
        Me.DetailReport.DataSource = Me.XpCollection2
        Me.DetailReport.Dpi = 100.0!
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail1.Dpi = 100.0!
        Me.Detail1.HeightF = 25.0!
        Me.Detail1.Name = "Detail1"
        '
        'XrTable1
        '
        Me.XrTable1.Dpi = 100.0!
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(627.0!, 25.0!)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5})
        Me.XrTableRow1.Dpi = 100.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "productCode")})
        Me.XrTableCell1.Dpi = 100.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Description")})
        Me.XrTableCell2.Dpi = 100.0!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Quantity")})
        Me.XrTableCell3.Dpi = 100.0!
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "UnitPrice")})
        Me.XrTableCell4.Dpi = 100.0!
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalPrice")})
        Me.XrTableCell5.Dpi = 100.0!
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Weight = 1.0R
        '
        'XpCollection2
        '
        Me.XpCollection2.ObjectType = GetType(NonPersistedViews.SurveyProducts)
        '
        'XpCollection1
        '
        Me.XpCollection1.LoadingEnabled = False
        Me.XpCollection1.ObjectType = GetType(Esso.Data.EvacSurvey)
        '
        'xptSurveyProducts
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
        Me.DataSource = Me.XpCollection1
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 310, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.SurveyId})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "16.2"
        Me.Watermark.Image = CType(resources.GetObject("xptSurveyProducts.Watermark.Image"), System.Drawing.Image)
        Me.Watermark.PageRange = "1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents SurveyId As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XpCollection2 As DevExpress.Xpo.XPCollection
End Class
