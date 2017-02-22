<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class xptSurveyQuote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xptSurveyQuote))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrRichText3 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SurveyId = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText1})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 661.2501!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText1
        '
        Me.XrRichText1.Dpi = 100.0!
        Me.XrRichText1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(627.0001!, 641.2501!)
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
        'XpCollection1
        '
        Me.XpCollection1.LoadingEnabled = False
        Me.XpCollection1.ObjectType = GetType(Esso.Data.EvacSurvey)
        '
        'xptSurveyQuote
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataSource = Me.XpCollection1
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 310, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.SurveyId})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "16.2"
        Me.Watermark.Image = CType(resources.GetObject("xptSurveyQuote.Watermark.Image"), System.Drawing.Image)
        Me.Watermark.PageRange = "1"
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents SurveyId As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrRichText3 As DevExpress.XtraReports.UI.XRRichText
End Class
