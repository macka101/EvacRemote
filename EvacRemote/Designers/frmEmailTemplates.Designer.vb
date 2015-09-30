' Developer Express Code Central Example:
' How to implement mail merge in a RichEditControl
' 
' This example illustrates an older approach to implement mail merge in the
' RichEditControl.
' To learn about a newer and more convenient approach to
' master-detail mail merge
' (https://documentation.devexpress.com/#WindowsForms/CustomDocument16044), refer
' to How to automatically create mail-merge documents using the Snap Document
' Server
' (https://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E5078).
' 
' In
' this example, the ArrayList that is generated at runtime is used as a data
' source that supplies mail merge data to the document. The tab control on the
' form contains a Ribbon UI
' (https://documentation.devexpress.com/#WindowsForms/CustomDocument9551) and two
' RichEditControl instances (one of them is used to construct a document template,
' and the other displays the mail merge result).
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1680

Imports Microsoft.VisualBasic
Imports System
Partial Public Class frmEmailTemplates
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmailTemplates))
        Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
        Dim ReduceOperation1 As DevExpress.XtraBars.Ribbon.ReduceOperation = New DevExpress.XtraBars.Ribbon.ReduceOperation()
        Me.stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
        Me.galleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
        Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
        Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
        Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
        Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
        Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
        Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
        Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
        Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
        Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
        Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
        Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
        Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
        Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
        Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
        Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
        Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
        Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
        Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
        Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
        Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
        Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
        Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
        Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
        Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
        Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
        Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
        Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
        Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
        Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
        Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
        Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
        Me.insertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
        Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
        Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
        Me.toggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
        Me.mergeToNewDocumentItem = New DevExpress.XtraBars.BarButtonItem()
        Me.mergeToFileItem = New DevExpress.XtraBars.BarButtonItem()
        Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
        Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
        Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
        Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
        Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
        Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
        Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
        Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
        Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
        Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
        Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
        Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
        Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
        Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
        Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
        Me.changeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
        Me.makeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
        Me.makeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
        Me.toggleTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
        Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
        Me.barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
        Me.barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
        Me.barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
        Me.changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
        Me.setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
        Me.setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
        Me.setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
        Me.showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
        Me.addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
        Me.removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
        Me.addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
        Me.removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
        Me.changeParagraphBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem()
        Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
        Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
        Me.barButtonGroup8 = New DevExpress.XtraBars.BarButtonGroup()
        Me.barButtonGroup9 = New DevExpress.XtraBars.BarButtonGroup()
        Me.barButtonGroup10 = New DevExpress.XtraBars.BarButtonGroup()
        Me.barButtonGroup11 = New DevExpress.XtraBars.BarButtonGroup()
        Me.barButtonGroup12 = New DevExpress.XtraBars.BarButtonGroup()
        Me.barButtonGroup13 = New DevExpress.XtraBars.BarButtonGroup()
        Me.barButtonGroup14 = New DevExpress.XtraBars.BarButtonGroup()
        Me.InsertPageBreakItem21 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem2()
        Me.InsertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
        Me.InsertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
        Me.InsertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
        Me.InsertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
        Me.InsertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
        Me.EditPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
        Me.EditPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
        Me.InsertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
        Me.InsertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
        Me.InsertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem()
        Me.InsertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
        Me.ChangeSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem()
        Me.SetNormalSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem()
        Me.SetNarrowSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem()
        Me.SetModerateSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem()
        Me.SetWideSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem()
        Me.ShowPageMarginsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem()
        Me.ChangeSectionPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem()
        Me.SetPortraitPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem()
        Me.SetLandscapePageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem()
        Me.ChangeSectionPaperKindItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem()
        Me.ChangeSectionColumnsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem()
        Me.SetSectionOneColumnItem1 = New DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem()
        Me.SetSectionTwoColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem()
        Me.SetSectionThreeColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem()
        Me.ShowColumnsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem()
        Me.InsertBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertBreakItem()
        Me.InsertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
        Me.InsertColumnBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertColumnBreakItem()
        Me.InsertSectionBreakNextPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem()
        Me.InsertSectionBreakEvenPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem()
        Me.InsertSectionBreakOddPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem()
        Me.ChangeSectionLineNumberingItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem()
        Me.SetSectionLineNumberingNoneItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem()
        Me.SetSectionLineNumberingContinuousItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem()
        Me.SetSectionLineNumberingRestartNewPageItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem()
        Me.SetSectionLineNumberingRestartNewSectionItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem()
        Me.ToggleParagraphSuppressLineNumbersItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem()
        Me.ShowLineNumberingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem()
        Me.ChangePageColorItem1 = New DevExpress.XtraRichEdit.UI.ChangePageColorItem()
        Me.bbiDataSource = New DevExpress.XtraBars.BarEditItem()
        Me.iceDataSource = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
        Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
        Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
        Me.clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
        Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
        Me.paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
        Me.editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
        Me.mailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
        Me.mailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
        Me.rpgDataSource = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.InsertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
        Me.PagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
        Me.TablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
        Me.IllustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
        Me.LinksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
        Me.HeaderFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
        Me.TextRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
        Me.SymbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
        Me.PageLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage()
        Me.PageSetupRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup()
        Me.PageBackgroundRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup()
        Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
        Me.showFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem()
        Me.showEditStyleFormItem1 = New DevExpress.XtraRichEdit.UI.ShowEditStyleFormItem()
        Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iceDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stylesRibbonPageGroup1
        '
        Me.stylesRibbonPageGroup1.Glyph = CType(resources.GetObject("stylesRibbonPageGroup1.Glyph"), System.Drawing.Image)
        Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeStyleItem1)
        Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
        '
        'galleryChangeStyleItem1
        '
        '
        '
        '
        Me.galleryChangeStyleItem1.Gallery.ColumnCount = 10
        Me.galleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
        Me.galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
        Me.galleryChangeStyleItem1.Id = 39
        Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AutoSizeItems = True
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.clearFormattingItem1, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleNumberingListItem1, Me.toggleBulletedListItem1, Me.toggleMultiLevelListItem1, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.toggleShowWhitespaceItem1, Me.showParagraphFormItem1, Me.insertMergeFieldItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleViewMergedDataItem1, Me.mergeToNewDocumentItem, Me.mergeToFileItem, Me.changeStyleItem1, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.barButtonGroup2, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.barButtonGroup3, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.toggleTextCaseItem1, Me.barButtonGroup4, Me.barButtonGroup5, Me.barButtonGroup6, Me.barButtonGroup7, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.changeParagraphBackColorItem1, Me.findItem1, Me.replaceItem1, Me.galleryChangeStyleItem1, Me.barButtonGroup8, Me.barButtonGroup9, Me.barButtonGroup10, Me.barButtonGroup11, Me.barButtonGroup12, Me.barButtonGroup13, Me.barButtonGroup14, Me.InsertPageBreakItem21, Me.InsertTableItem1, Me.InsertPictureItem1, Me.InsertFloatingPictureItem1, Me.InsertBookmarkItem1, Me.InsertHyperlinkItem1, Me.EditPageHeaderItem1, Me.EditPageFooterItem1, Me.InsertPageNumberItem1, Me.InsertPageCountItem1, Me.InsertTextBoxItem1, Me.InsertSymbolItem1, Me.ChangeSectionPageMarginsItem1, Me.SetNormalSectionPageMarginsItem1, Me.SetNarrowSectionPageMarginsItem1, Me.SetModerateSectionPageMarginsItem1, Me.SetWideSectionPageMarginsItem1, Me.ShowPageMarginsSetupFormItem1, Me.ChangeSectionPageOrientationItem1, Me.SetPortraitPageOrientationItem1, Me.SetLandscapePageOrientationItem1, Me.ChangeSectionPaperKindItem1, Me.ChangeSectionColumnsItem1, Me.SetSectionOneColumnItem1, Me.SetSectionTwoColumnsItem1, Me.SetSectionThreeColumnsItem1, Me.ShowColumnsSetupFormItem1, Me.InsertBreakItem1, Me.InsertPageBreakItem1, Me.InsertColumnBreakItem1, Me.InsertSectionBreakNextPageItem1, Me.InsertSectionBreakEvenPageItem1, Me.InsertSectionBreakOddPageItem1, Me.ChangeSectionLineNumberingItem1, Me.SetSectionLineNumberingNoneItem1, Me.SetSectionLineNumberingContinuousItem1, Me.SetSectionLineNumberingRestartNewPageItem1, Me.SetSectionLineNumberingRestartNewSectionItem1, Me.ToggleParagraphSuppressLineNumbersItem1, Me.ShowLineNumberingFormItem1, Me.ChangePageColorItem1, Me.bbiDataSource})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 89
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.fileRibbonPage1, Me.homeRibbonPage1, Me.mailingsRibbonPage1, Me.InsertRibbonPage1, Me.PageLayoutRibbonPage1})
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1, Me.iceDataSource})
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.Size = New System.Drawing.Size(792, 142)
        Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
        '
        'fileNewItem1
        '
        Me.fileNewItem1.Glyph = CType(resources.GetObject("fileNewItem1.Glyph"), System.Drawing.Image)
        Me.fileNewItem1.Id = 0
        Me.fileNewItem1.LargeGlyph = CType(resources.GetObject("fileNewItem1.LargeGlyph"), System.Drawing.Image)
        Me.fileNewItem1.Name = "fileNewItem1"
        '
        'fileOpenItem1
        '
        Me.fileOpenItem1.Glyph = CType(resources.GetObject("fileOpenItem1.Glyph"), System.Drawing.Image)
        Me.fileOpenItem1.Id = 1
        Me.fileOpenItem1.LargeGlyph = CType(resources.GetObject("fileOpenItem1.LargeGlyph"), System.Drawing.Image)
        Me.fileOpenItem1.Name = "fileOpenItem1"
        '
        'fileSaveItem1
        '
        Me.fileSaveItem1.Glyph = CType(resources.GetObject("fileSaveItem1.Glyph"), System.Drawing.Image)
        Me.fileSaveItem1.Id = 2
        Me.fileSaveItem1.LargeGlyph = CType(resources.GetObject("fileSaveItem1.LargeGlyph"), System.Drawing.Image)
        Me.fileSaveItem1.Name = "fileSaveItem1"
        '
        'fileSaveAsItem1
        '
        Me.fileSaveAsItem1.Glyph = CType(resources.GetObject("fileSaveAsItem1.Glyph"), System.Drawing.Image)
        Me.fileSaveAsItem1.Id = 3
        Me.fileSaveAsItem1.LargeGlyph = CType(resources.GetObject("fileSaveAsItem1.LargeGlyph"), System.Drawing.Image)
        Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
        '
        'quickPrintItem1
        '
        Me.quickPrintItem1.Glyph = CType(resources.GetObject("quickPrintItem1.Glyph"), System.Drawing.Image)
        Me.quickPrintItem1.Id = 4
        Me.quickPrintItem1.LargeGlyph = CType(resources.GetObject("quickPrintItem1.LargeGlyph"), System.Drawing.Image)
        Me.quickPrintItem1.Name = "quickPrintItem1"
        '
        'printItem1
        '
        Me.printItem1.Glyph = CType(resources.GetObject("printItem1.Glyph"), System.Drawing.Image)
        Me.printItem1.Id = 5
        Me.printItem1.LargeGlyph = CType(resources.GetObject("printItem1.LargeGlyph"), System.Drawing.Image)
        Me.printItem1.Name = "printItem1"
        '
        'printPreviewItem1
        '
        Me.printPreviewItem1.Glyph = CType(resources.GetObject("printPreviewItem1.Glyph"), System.Drawing.Image)
        Me.printPreviewItem1.Id = 6
        Me.printPreviewItem1.LargeGlyph = CType(resources.GetObject("printPreviewItem1.LargeGlyph"), System.Drawing.Image)
        Me.printPreviewItem1.Name = "printPreviewItem1"
        '
        'undoItem1
        '
        Me.undoItem1.Glyph = CType(resources.GetObject("undoItem1.Glyph"), System.Drawing.Image)
        Me.undoItem1.Id = 7
        Me.undoItem1.LargeGlyph = CType(resources.GetObject("undoItem1.LargeGlyph"), System.Drawing.Image)
        Me.undoItem1.Name = "undoItem1"
        '
        'redoItem1
        '
        Me.redoItem1.Glyph = CType(resources.GetObject("redoItem1.Glyph"), System.Drawing.Image)
        Me.redoItem1.Id = 8
        Me.redoItem1.LargeGlyph = CType(resources.GetObject("redoItem1.LargeGlyph"), System.Drawing.Image)
        Me.redoItem1.Name = "redoItem1"
        '
        'changeFontNameItem1
        '
        Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
        Me.changeFontNameItem1.Id = 9
        Me.changeFontNameItem1.Name = "changeFontNameItem1"
        Me.changeFontNameItem1.Width = 150
        '
        'repositoryItemFontEdit1
        '
        Me.repositoryItemFontEdit1.AutoHeight = False
        Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
        '
        'changeFontSizeItem1
        '
        Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
        Me.changeFontSizeItem1.Id = 10
        Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
        '
        'repositoryItemRichEditFontSizeEdit1
        '
        Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
        Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl1
        Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
        '
        'richEditControl1
        '
        Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richEditControl1.EnableToolTips = True
        Me.richEditControl1.Location = New System.Drawing.Point(0, 142)
        Me.richEditControl1.MenuManager = Me.ribbonControl1
        Me.richEditControl1.Name = "richEditControl1"
        Me.richEditControl1.Options.CopyPaste.MaintainDocumentSectionSettings = False
        Me.richEditControl1.Options.Fields.UpdateDocVariablesBeforeCopy = True
        Me.richEditControl1.Options.Fields.UpdateDocVariablesBeforePrint = True
        Me.richEditControl1.Options.Fields.UseCurrentCultureDateTimeFormat = False
        Me.richEditControl1.Options.MailMerge.KeepLastParagraph = False
        Me.richEditControl1.Size = New System.Drawing.Size(792, 397)
        Me.richEditControl1.TabIndex = 3
        Me.richEditControl1.Text = "richEditControl1"
        '
        'changeFontColorItem1
        '
        Me.changeFontColorItem1.Glyph = CType(resources.GetObject("changeFontColorItem1.Glyph"), System.Drawing.Image)
        Me.changeFontColorItem1.Id = 11
        Me.changeFontColorItem1.LargeGlyph = CType(resources.GetObject("changeFontColorItem1.LargeGlyph"), System.Drawing.Image)
        Me.changeFontColorItem1.Name = "changeFontColorItem1"
        '
        'changeFontBackColorItem1
        '
        Me.changeFontBackColorItem1.Glyph = CType(resources.GetObject("changeFontBackColorItem1.Glyph"), System.Drawing.Image)
        Me.changeFontBackColorItem1.Id = 12
        Me.changeFontBackColorItem1.LargeGlyph = CType(resources.GetObject("changeFontBackColorItem1.LargeGlyph"), System.Drawing.Image)
        Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
        '
        'toggleFontBoldItem1
        '
        Me.toggleFontBoldItem1.Glyph = CType(resources.GetObject("toggleFontBoldItem1.Glyph"), System.Drawing.Image)
        Me.toggleFontBoldItem1.Id = 13
        Me.toggleFontBoldItem1.LargeGlyph = CType(resources.GetObject("toggleFontBoldItem1.LargeGlyph"), System.Drawing.Image)
        Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
        '
        'toggleFontItalicItem1
        '
        Me.toggleFontItalicItem1.Glyph = CType(resources.GetObject("toggleFontItalicItem1.Glyph"), System.Drawing.Image)
        Me.toggleFontItalicItem1.Id = 14
        Me.toggleFontItalicItem1.LargeGlyph = CType(resources.GetObject("toggleFontItalicItem1.LargeGlyph"), System.Drawing.Image)
        Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
        '
        'fontSizeIncreaseItem1
        '
        Me.fontSizeIncreaseItem1.Glyph = CType(resources.GetObject("fontSizeIncreaseItem1.Glyph"), System.Drawing.Image)
        Me.fontSizeIncreaseItem1.Id = 21
        Me.fontSizeIncreaseItem1.LargeGlyph = CType(resources.GetObject("fontSizeIncreaseItem1.LargeGlyph"), System.Drawing.Image)
        Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
        '
        'fontSizeDecreaseItem1
        '
        Me.fontSizeDecreaseItem1.Glyph = CType(resources.GetObject("fontSizeDecreaseItem1.Glyph"), System.Drawing.Image)
        Me.fontSizeDecreaseItem1.Id = 22
        Me.fontSizeDecreaseItem1.LargeGlyph = CType(resources.GetObject("fontSizeDecreaseItem1.LargeGlyph"), System.Drawing.Image)
        Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
        '
        'clearFormattingItem1
        '
        Me.clearFormattingItem1.Glyph = CType(resources.GetObject("clearFormattingItem1.Glyph"), System.Drawing.Image)
        Me.clearFormattingItem1.Id = 23
        Me.clearFormattingItem1.LargeGlyph = CType(resources.GetObject("clearFormattingItem1.LargeGlyph"), System.Drawing.Image)
        Me.clearFormattingItem1.Name = "clearFormattingItem1"
        '
        'toggleParagraphAlignmentLeftItem1
        '
        Me.toggleParagraphAlignmentLeftItem1.Glyph = CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.Glyph"), System.Drawing.Image)
        Me.toggleParagraphAlignmentLeftItem1.Id = 25
        Me.toggleParagraphAlignmentLeftItem1.LargeGlyph = CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.LargeGlyph"), System.Drawing.Image)
        Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
        '
        'toggleParagraphAlignmentCenterItem1
        '
        Me.toggleParagraphAlignmentCenterItem1.Glyph = CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.Glyph"), System.Drawing.Image)
        Me.toggleParagraphAlignmentCenterItem1.Id = 26
        Me.toggleParagraphAlignmentCenterItem1.LargeGlyph = CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.LargeGlyph"), System.Drawing.Image)
        Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
        '
        'toggleParagraphAlignmentRightItem1
        '
        Me.toggleParagraphAlignmentRightItem1.Glyph = CType(resources.GetObject("toggleParagraphAlignmentRightItem1.Glyph"), System.Drawing.Image)
        Me.toggleParagraphAlignmentRightItem1.Id = 27
        Me.toggleParagraphAlignmentRightItem1.LargeGlyph = CType(resources.GetObject("toggleParagraphAlignmentRightItem1.LargeGlyph"), System.Drawing.Image)
        Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
        '
        'toggleParagraphAlignmentJustifyItem1
        '
        Me.toggleParagraphAlignmentJustifyItem1.Glyph = CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.Glyph"), System.Drawing.Image)
        Me.toggleParagraphAlignmentJustifyItem1.Id = 28
        Me.toggleParagraphAlignmentJustifyItem1.LargeGlyph = CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.LargeGlyph"), System.Drawing.Image)
        Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
        '
        'toggleNumberingListItem1
        '
        Me.toggleNumberingListItem1.Glyph = CType(resources.GetObject("toggleNumberingListItem1.Glyph"), System.Drawing.Image)
        Me.toggleNumberingListItem1.Id = 29
        Me.toggleNumberingListItem1.LargeGlyph = CType(resources.GetObject("toggleNumberingListItem1.LargeGlyph"), System.Drawing.Image)
        Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
        '
        'toggleBulletedListItem1
        '
        Me.toggleBulletedListItem1.Glyph = CType(resources.GetObject("toggleBulletedListItem1.Glyph"), System.Drawing.Image)
        Me.toggleBulletedListItem1.Id = 30
        Me.toggleBulletedListItem1.LargeGlyph = CType(resources.GetObject("toggleBulletedListItem1.LargeGlyph"), System.Drawing.Image)
        Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
        '
        'toggleMultiLevelListItem1
        '
        Me.toggleMultiLevelListItem1.Glyph = CType(resources.GetObject("toggleMultiLevelListItem1.Glyph"), System.Drawing.Image)
        Me.toggleMultiLevelListItem1.Id = 31
        Me.toggleMultiLevelListItem1.LargeGlyph = CType(resources.GetObject("toggleMultiLevelListItem1.LargeGlyph"), System.Drawing.Image)
        Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
        '
        'decreaseIndentItem1
        '
        Me.decreaseIndentItem1.Glyph = CType(resources.GetObject("decreaseIndentItem1.Glyph"), System.Drawing.Image)
        Me.decreaseIndentItem1.Id = 32
        Me.decreaseIndentItem1.LargeGlyph = CType(resources.GetObject("decreaseIndentItem1.LargeGlyph"), System.Drawing.Image)
        Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
        '
        'increaseIndentItem1
        '
        Me.increaseIndentItem1.Glyph = CType(resources.GetObject("increaseIndentItem1.Glyph"), System.Drawing.Image)
        Me.increaseIndentItem1.Id = 33
        Me.increaseIndentItem1.LargeGlyph = CType(resources.GetObject("increaseIndentItem1.LargeGlyph"), System.Drawing.Image)
        Me.increaseIndentItem1.Name = "increaseIndentItem1"
        '
        'toggleShowWhitespaceItem1
        '
        Me.toggleShowWhitespaceItem1.Glyph = CType(resources.GetObject("toggleShowWhitespaceItem1.Glyph"), System.Drawing.Image)
        Me.toggleShowWhitespaceItem1.Id = 34
        Me.toggleShowWhitespaceItem1.LargeGlyph = CType(resources.GetObject("toggleShowWhitespaceItem1.LargeGlyph"), System.Drawing.Image)
        Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
        '
        'showParagraphFormItem1
        '
        Me.showParagraphFormItem1.Glyph = CType(resources.GetObject("showParagraphFormItem1.Glyph"), System.Drawing.Image)
        Me.showParagraphFormItem1.Id = 35
        Me.showParagraphFormItem1.LargeGlyph = CType(resources.GetObject("showParagraphFormItem1.LargeGlyph"), System.Drawing.Image)
        Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
        '
        'insertMergeFieldItem1
        '
        Me.insertMergeFieldItem1.Glyph = CType(resources.GetObject("insertMergeFieldItem1.Glyph"), System.Drawing.Image)
        Me.insertMergeFieldItem1.Id = 36
        Me.insertMergeFieldItem1.LargeGlyph = CType(resources.GetObject("insertMergeFieldItem1.LargeGlyph"), System.Drawing.Image)
        Me.insertMergeFieldItem1.Name = "insertMergeFieldItem1"
        '
        'showAllFieldCodesItem1
        '
        Me.showAllFieldCodesItem1.Glyph = CType(resources.GetObject("showAllFieldCodesItem1.Glyph"), System.Drawing.Image)
        Me.showAllFieldCodesItem1.Id = 37
        Me.showAllFieldCodesItem1.LargeGlyph = CType(resources.GetObject("showAllFieldCodesItem1.LargeGlyph"), System.Drawing.Image)
        Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
        '
        'showAllFieldResultsItem1
        '
        Me.showAllFieldResultsItem1.Glyph = CType(resources.GetObject("showAllFieldResultsItem1.Glyph"), System.Drawing.Image)
        Me.showAllFieldResultsItem1.Id = 38
        Me.showAllFieldResultsItem1.LargeGlyph = CType(resources.GetObject("showAllFieldResultsItem1.LargeGlyph"), System.Drawing.Image)
        Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
        '
        'toggleViewMergedDataItem1
        '
        Me.toggleViewMergedDataItem1.Glyph = CType(resources.GetObject("toggleViewMergedDataItem1.Glyph"), System.Drawing.Image)
        Me.toggleViewMergedDataItem1.Id = 39
        Me.toggleViewMergedDataItem1.LargeGlyph = CType(resources.GetObject("toggleViewMergedDataItem1.LargeGlyph"), System.Drawing.Image)
        Me.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
        '
        'mergeToNewDocumentItem
        '
        Me.mergeToNewDocumentItem.Caption = "Merge to New Document"
        Me.mergeToNewDocumentItem.Id = 40
        Me.mergeToNewDocumentItem.Name = "mergeToNewDocumentItem"
        '
        'mergeToFileItem
        '
        Me.mergeToFileItem.Caption = "Merge to File"
        Me.mergeToFileItem.Id = 41
        Me.mergeToFileItem.Name = "mergeToFileItem"
        '
        'changeStyleItem1
        '
        Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
        Me.changeStyleItem1.Id = 2
        Me.changeStyleItem1.Name = "changeStyleItem1"
        '
        'repositoryItemRichEditStyleEdit1
        '
        Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
        Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl1
        Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
        '
        'pasteItem1
        '
        Me.pasteItem1.Id = 13
        Me.pasteItem1.Name = "pasteItem1"
        '
        'cutItem1
        '
        Me.cutItem1.Id = 14
        Me.cutItem1.Name = "cutItem1"
        '
        'copyItem1
        '
        Me.copyItem1.Id = 15
        Me.copyItem1.Name = "copyItem1"
        '
        'pasteSpecialItem1
        '
        Me.pasteSpecialItem1.Id = 16
        Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
        '
        'barButtonGroup1
        '
        Me.barButtonGroup1.Id = 6
        Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1)
        Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
        Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1)
        Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1)
        Me.barButtonGroup1.Name = "barButtonGroup1"
        Me.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
        '
        'barButtonGroup2
        '
        Me.barButtonGroup2.Id = 7
        Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontBoldItem1)
        Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontItalicItem1)
        Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontUnderlineItem1)
        Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleUnderlineItem1)
        Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontStrikeoutItem1)
        Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleStrikeoutItem1)
        Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSuperscriptItem1)
        Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSubscriptItem1)
        Me.barButtonGroup2.Name = "barButtonGroup2"
        Me.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
        '
        'toggleFontUnderlineItem1
        '
        Me.toggleFontUnderlineItem1.Id = 17
        Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
        '
        'toggleFontDoubleUnderlineItem1
        '
        Me.toggleFontDoubleUnderlineItem1.Id = 18
        Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
        '
        'toggleFontStrikeoutItem1
        '
        Me.toggleFontStrikeoutItem1.Id = 19
        Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
        '
        'toggleFontDoubleStrikeoutItem1
        '
        Me.toggleFontDoubleStrikeoutItem1.Id = 20
        Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
        '
        'toggleFontSuperscriptItem1
        '
        Me.toggleFontSuperscriptItem1.Id = 21
        Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
        '
        'toggleFontSubscriptItem1
        '
        Me.toggleFontSubscriptItem1.Id = 22
        Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
        '
        'barButtonGroup3
        '
        Me.barButtonGroup3.Id = 8
        Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1)
        Me.barButtonGroup3.ItemLinks.Add(Me.changeFontBackColorItem1)
        Me.barButtonGroup3.Name = "barButtonGroup3"
        Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
        '
        'changeTextCaseItem1
        '
        Me.changeTextCaseItem1.Id = 23
        Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1)})
        Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
        '
        'makeTextUpperCaseItem1
        '
        Me.makeTextUpperCaseItem1.Id = 24
        Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
        '
        'makeTextLowerCaseItem1
        '
        Me.makeTextLowerCaseItem1.Id = 25
        Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
        '
        'toggleTextCaseItem1
        '
        Me.toggleTextCaseItem1.Id = 26
        Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
        '
        'barButtonGroup4
        '
        Me.barButtonGroup4.Id = 9
        Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1)
        Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1)
        Me.barButtonGroup4.ItemLinks.Add(Me.toggleMultiLevelListItem1)
        Me.barButtonGroup4.Name = "barButtonGroup4"
        Me.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
        '
        'barButtonGroup5
        '
        Me.barButtonGroup5.Id = 10
        Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1)
        Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1)
        Me.barButtonGroup5.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
        Me.barButtonGroup5.Name = "barButtonGroup5"
        Me.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
        '
        'barButtonGroup6
        '
        Me.barButtonGroup6.Id = 11
        Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1)
        Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1)
        Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1)
        Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1)
        Me.barButtonGroup6.Name = "barButtonGroup6"
        Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
        '
        'barButtonGroup7
        '
        Me.barButtonGroup7.Id = 12
        Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphLineSpacingItem1)
        Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1)
        Me.barButtonGroup7.Name = "barButtonGroup7"
        Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
        '
        'changeParagraphLineSpacingItem1
        '
        Me.changeParagraphLineSpacingItem1.Id = 27
        Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)})
        Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
        '
        'setSingleParagraphSpacingItem1
        '
        Me.setSingleParagraphSpacingItem1.Id = 28
        Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
        '
        'setSesquialteralParagraphSpacingItem1
        '
        Me.setSesquialteralParagraphSpacingItem1.Id = 29
        Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
        '
        'setDoubleParagraphSpacingItem1
        '
        Me.setDoubleParagraphSpacingItem1.Id = 30
        Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
        '
        'showLineSpacingFormItem1
        '
        Me.showLineSpacingFormItem1.Id = 31
        Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
        '
        'addSpacingBeforeParagraphItem1
        '
        Me.addSpacingBeforeParagraphItem1.Id = 32
        Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
        '
        'removeSpacingBeforeParagraphItem1
        '
        Me.removeSpacingBeforeParagraphItem1.Id = 33
        Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
        '
        'addSpacingAfterParagraphItem1
        '
        Me.addSpacingAfterParagraphItem1.Id = 34
        Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
        '
        'removeSpacingAfterParagraphItem1
        '
        Me.removeSpacingAfterParagraphItem1.Id = 35
        Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
        '
        'changeParagraphBackColorItem1
        '
        Me.changeParagraphBackColorItem1.Id = 36
        Me.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
        '
        'findItem1
        '
        Me.findItem1.Id = 37
        Me.findItem1.Name = "findItem1"
        '
        'replaceItem1
        '
        Me.replaceItem1.Id = 38
        Me.replaceItem1.Name = "replaceItem1"
        '
        'barButtonGroup8
        '
        Me.barButtonGroup8.Id = 40
        Me.barButtonGroup8.ItemLinks.Add(Me.changeFontNameItem1)
        Me.barButtonGroup8.ItemLinks.Add(Me.changeFontSizeItem1)
        Me.barButtonGroup8.ItemLinks.Add(Me.fontSizeIncreaseItem1)
        Me.barButtonGroup8.ItemLinks.Add(Me.fontSizeDecreaseItem1)
        Me.barButtonGroup8.Name = "barButtonGroup8"
        Me.barButtonGroup8.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
        '
        'barButtonGroup9
        '
        Me.barButtonGroup9.Id = 41
        Me.barButtonGroup9.ItemLinks.Add(Me.toggleFontBoldItem1)
        Me.barButtonGroup9.ItemLinks.Add(Me.toggleFontItalicItem1)
        Me.barButtonGroup9.ItemLinks.Add(Me.toggleFontUnderlineItem1)
        Me.barButtonGroup9.ItemLinks.Add(Me.toggleFontDoubleUnderlineItem1)
        Me.barButtonGroup9.ItemLinks.Add(Me.toggleFontStrikeoutItem1)
        Me.barButtonGroup9.ItemLinks.Add(Me.toggleFontDoubleStrikeoutItem1)
        Me.barButtonGroup9.ItemLinks.Add(Me.toggleFontSuperscriptItem1)
        Me.barButtonGroup9.ItemLinks.Add(Me.toggleFontSubscriptItem1)
        Me.barButtonGroup9.Name = "barButtonGroup9"
        Me.barButtonGroup9.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
        '
        'barButtonGroup10
        '
        Me.barButtonGroup10.Id = 42
        Me.barButtonGroup10.ItemLinks.Add(Me.changeFontColorItem1)
        Me.barButtonGroup10.ItemLinks.Add(Me.changeFontBackColorItem1)
        Me.barButtonGroup10.Name = "barButtonGroup10"
        Me.barButtonGroup10.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
        '
        'barButtonGroup11
        '
        Me.barButtonGroup11.Id = 43
        Me.barButtonGroup11.ItemLinks.Add(Me.toggleBulletedListItem1)
        Me.barButtonGroup11.ItemLinks.Add(Me.toggleNumberingListItem1)
        Me.barButtonGroup11.ItemLinks.Add(Me.toggleMultiLevelListItem1)
        Me.barButtonGroup11.Name = "barButtonGroup11"
        Me.barButtonGroup11.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
        '
        'barButtonGroup12
        '
        Me.barButtonGroup12.Id = 44
        Me.barButtonGroup12.ItemLinks.Add(Me.decreaseIndentItem1)
        Me.barButtonGroup12.ItemLinks.Add(Me.increaseIndentItem1)
        Me.barButtonGroup12.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
        Me.barButtonGroup12.Name = "barButtonGroup12"
        Me.barButtonGroup12.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
        '
        'barButtonGroup13
        '
        Me.barButtonGroup13.Id = 45
        Me.barButtonGroup13.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1)
        Me.barButtonGroup13.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1)
        Me.barButtonGroup13.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1)
        Me.barButtonGroup13.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1)
        Me.barButtonGroup13.Name = "barButtonGroup13"
        Me.barButtonGroup13.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
        '
        'barButtonGroup14
        '
        Me.barButtonGroup14.Id = 46
        Me.barButtonGroup14.ItemLinks.Add(Me.changeParagraphLineSpacingItem1)
        Me.barButtonGroup14.ItemLinks.Add(Me.changeParagraphBackColorItem1)
        Me.barButtonGroup14.Name = "barButtonGroup14"
        Me.barButtonGroup14.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
        '
        'InsertPageBreakItem21
        '
        Me.InsertPageBreakItem21.Id = 47
        Me.InsertPageBreakItem21.Name = "InsertPageBreakItem21"
        '
        'InsertTableItem1
        '
        Me.InsertTableItem1.Id = 48
        Me.InsertTableItem1.Name = "InsertTableItem1"
        '
        'InsertPictureItem1
        '
        Me.InsertPictureItem1.Id = 49
        Me.InsertPictureItem1.Name = "InsertPictureItem1"
        '
        'InsertFloatingPictureItem1
        '
        Me.InsertFloatingPictureItem1.Id = 50
        Me.InsertFloatingPictureItem1.Name = "InsertFloatingPictureItem1"
        '
        'InsertBookmarkItem1
        '
        Me.InsertBookmarkItem1.Id = 51
        Me.InsertBookmarkItem1.Name = "InsertBookmarkItem1"
        '
        'InsertHyperlinkItem1
        '
        Me.InsertHyperlinkItem1.Id = 52
        Me.InsertHyperlinkItem1.Name = "InsertHyperlinkItem1"
        '
        'EditPageHeaderItem1
        '
        Me.EditPageHeaderItem1.Id = 53
        Me.EditPageHeaderItem1.Name = "EditPageHeaderItem1"
        '
        'EditPageFooterItem1
        '
        Me.EditPageFooterItem1.Id = 54
        Me.EditPageFooterItem1.Name = "EditPageFooterItem1"
        '
        'InsertPageNumberItem1
        '
        Me.InsertPageNumberItem1.Id = 55
        Me.InsertPageNumberItem1.Name = "InsertPageNumberItem1"
        '
        'InsertPageCountItem1
        '
        Me.InsertPageCountItem1.Id = 56
        Me.InsertPageCountItem1.Name = "InsertPageCountItem1"
        '
        'InsertTextBoxItem1
        '
        Me.InsertTextBoxItem1.Id = 57
        Me.InsertTextBoxItem1.Name = "InsertTextBoxItem1"
        '
        'InsertSymbolItem1
        '
        Me.InsertSymbolItem1.Id = 58
        Me.InsertSymbolItem1.Name = "InsertSymbolItem1"
        '
        'ChangeSectionPageMarginsItem1
        '
        Me.ChangeSectionPageMarginsItem1.Id = 59
        Me.ChangeSectionPageMarginsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetNormalSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetNarrowSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetModerateSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetWideSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ShowPageMarginsSetupFormItem1, True)})
        Me.ChangeSectionPageMarginsItem1.Name = "ChangeSectionPageMarginsItem1"
        '
        'SetNormalSectionPageMarginsItem1
        '
        Me.SetNormalSectionPageMarginsItem1.Id = 60
        Me.SetNormalSectionPageMarginsItem1.Name = "SetNormalSectionPageMarginsItem1"
        '
        'SetNarrowSectionPageMarginsItem1
        '
        Me.SetNarrowSectionPageMarginsItem1.Id = 61
        Me.SetNarrowSectionPageMarginsItem1.Name = "SetNarrowSectionPageMarginsItem1"
        '
        'SetModerateSectionPageMarginsItem1
        '
        Me.SetModerateSectionPageMarginsItem1.Id = 62
        Me.SetModerateSectionPageMarginsItem1.Name = "SetModerateSectionPageMarginsItem1"
        '
        'SetWideSectionPageMarginsItem1
        '
        Me.SetWideSectionPageMarginsItem1.Id = 63
        Me.SetWideSectionPageMarginsItem1.Name = "SetWideSectionPageMarginsItem1"
        '
        'ShowPageMarginsSetupFormItem1
        '
        Me.ShowPageMarginsSetupFormItem1.Id = 64
        Me.ShowPageMarginsSetupFormItem1.Name = "ShowPageMarginsSetupFormItem1"
        '
        'ChangeSectionPageOrientationItem1
        '
        Me.ChangeSectionPageOrientationItem1.Id = 65
        Me.ChangeSectionPageOrientationItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetPortraitPageOrientationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetLandscapePageOrientationItem1)})
        Me.ChangeSectionPageOrientationItem1.Name = "ChangeSectionPageOrientationItem1"
        '
        'SetPortraitPageOrientationItem1
        '
        Me.SetPortraitPageOrientationItem1.Id = 66
        Me.SetPortraitPageOrientationItem1.Name = "SetPortraitPageOrientationItem1"
        '
        'SetLandscapePageOrientationItem1
        '
        Me.SetLandscapePageOrientationItem1.Id = 67
        Me.SetLandscapePageOrientationItem1.Name = "SetLandscapePageOrientationItem1"
        '
        'ChangeSectionPaperKindItem1
        '
        Me.ChangeSectionPaperKindItem1.Id = 68
        Me.ChangeSectionPaperKindItem1.Name = "ChangeSectionPaperKindItem1"
        '
        'ChangeSectionColumnsItem1
        '
        Me.ChangeSectionColumnsItem1.Id = 69
        Me.ChangeSectionColumnsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionOneColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionTwoColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionThreeColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ShowColumnsSetupFormItem1, True)})
        Me.ChangeSectionColumnsItem1.Name = "ChangeSectionColumnsItem1"
        '
        'SetSectionOneColumnItem1
        '
        Me.SetSectionOneColumnItem1.Id = 70
        Me.SetSectionOneColumnItem1.Name = "SetSectionOneColumnItem1"
        '
        'SetSectionTwoColumnsItem1
        '
        Me.SetSectionTwoColumnsItem1.Id = 71
        Me.SetSectionTwoColumnsItem1.Name = "SetSectionTwoColumnsItem1"
        '
        'SetSectionThreeColumnsItem1
        '
        Me.SetSectionThreeColumnsItem1.Id = 72
        Me.SetSectionThreeColumnsItem1.Name = "SetSectionThreeColumnsItem1"
        '
        'ShowColumnsSetupFormItem1
        '
        Me.ShowColumnsSetupFormItem1.Id = 73
        Me.ShowColumnsSetupFormItem1.Name = "ShowColumnsSetupFormItem1"
        '
        'InsertBreakItem1
        '
        Me.InsertBreakItem1.Id = 74
        Me.InsertBreakItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.InsertPageBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.InsertColumnBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.InsertSectionBreakNextPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.InsertSectionBreakEvenPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.InsertSectionBreakOddPageItem1)})
        Me.InsertBreakItem1.Name = "InsertBreakItem1"
        '
        'InsertPageBreakItem1
        '
        Me.InsertPageBreakItem1.Id = 75
        Me.InsertPageBreakItem1.Name = "InsertPageBreakItem1"
        '
        'InsertColumnBreakItem1
        '
        Me.InsertColumnBreakItem1.Id = 76
        Me.InsertColumnBreakItem1.Name = "InsertColumnBreakItem1"
        '
        'InsertSectionBreakNextPageItem1
        '
        Me.InsertSectionBreakNextPageItem1.Id = 77
        Me.InsertSectionBreakNextPageItem1.Name = "InsertSectionBreakNextPageItem1"
        '
        'InsertSectionBreakEvenPageItem1
        '
        Me.InsertSectionBreakEvenPageItem1.Id = 78
        Me.InsertSectionBreakEvenPageItem1.Name = "InsertSectionBreakEvenPageItem1"
        '
        'InsertSectionBreakOddPageItem1
        '
        Me.InsertSectionBreakOddPageItem1.Id = 79
        Me.InsertSectionBreakOddPageItem1.Name = "InsertSectionBreakOddPageItem1"
        '
        'ChangeSectionLineNumberingItem1
        '
        Me.ChangeSectionLineNumberingItem1.Id = 80
        Me.ChangeSectionLineNumberingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionLineNumberingNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionLineNumberingContinuousItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionLineNumberingRestartNewPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionLineNumberingRestartNewSectionItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleParagraphSuppressLineNumbersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ShowLineNumberingFormItem1, True)})
        Me.ChangeSectionLineNumberingItem1.Name = "ChangeSectionLineNumberingItem1"
        '
        'SetSectionLineNumberingNoneItem1
        '
        Me.SetSectionLineNumberingNoneItem1.Id = 81
        Me.SetSectionLineNumberingNoneItem1.Name = "SetSectionLineNumberingNoneItem1"
        '
        'SetSectionLineNumberingContinuousItem1
        '
        Me.SetSectionLineNumberingContinuousItem1.Id = 82
        Me.SetSectionLineNumberingContinuousItem1.Name = "SetSectionLineNumberingContinuousItem1"
        '
        'SetSectionLineNumberingRestartNewPageItem1
        '
        Me.SetSectionLineNumberingRestartNewPageItem1.Id = 83
        Me.SetSectionLineNumberingRestartNewPageItem1.Name = "SetSectionLineNumberingRestartNewPageItem1"
        '
        'SetSectionLineNumberingRestartNewSectionItem1
        '
        Me.SetSectionLineNumberingRestartNewSectionItem1.Id = 84
        Me.SetSectionLineNumberingRestartNewSectionItem1.Name = "SetSectionLineNumberingRestartNewSectionItem1"
        '
        'ToggleParagraphSuppressLineNumbersItem1
        '
        Me.ToggleParagraphSuppressLineNumbersItem1.Id = 85
        Me.ToggleParagraphSuppressLineNumbersItem1.Name = "ToggleParagraphSuppressLineNumbersItem1"
        '
        'ShowLineNumberingFormItem1
        '
        Me.ShowLineNumberingFormItem1.Id = 86
        Me.ShowLineNumberingFormItem1.Name = "ShowLineNumberingFormItem1"
        '
        'ChangePageColorItem1
        '
        Me.ChangePageColorItem1.Id = 87
        Me.ChangePageColorItem1.Name = "ChangePageColorItem1"
        '
        'bbiDataSource
        '
        Me.bbiDataSource.Caption = "Data Source"
        Me.bbiDataSource.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiDataSource.Edit = Me.iceDataSource
        Me.bbiDataSource.Id = 88
        Me.bbiDataSource.Name = "bbiDataSource"
        Me.bbiDataSource.Width = 100
        '
        'iceDataSource
        '
        Me.iceDataSource.AutoHeight = False
        Me.iceDataSource.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.iceDataSource.Name = "iceDataSource"
        '
        'fileRibbonPage1
        '
        Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.commonRibbonPageGroup1})
        Me.fileRibbonPage1.Name = "fileRibbonPage1"
        '
        'commonRibbonPageGroup1
        '
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
        Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
        '
        'homeRibbonPage1
        '
        Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.clipboardRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.paragraphRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.editingRibbonPageGroup1})
        Me.homeRibbonPage1.Name = "homeRibbonPage1"
        ReduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
        ReduceOperation1.Group = Me.stylesRibbonPageGroup1
        ReduceOperation1.ItemLinkIndex = 0
        ReduceOperation1.ItemLinksCount = 0
        ReduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
        Me.homeRibbonPage1.ReduceOperations.Add(ReduceOperation1)
        '
        'clipboardRibbonPageGroup1
        '
        Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteItem1)
        Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.cutItem1)
        Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.copyItem1)
        Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteSpecialItem1)
        Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
        '
        'fontRibbonPageGroup1
        '
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup8)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup9)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup10)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeTextCaseItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.clearFormattingItem1)
        Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
        '
        'paragraphRibbonPageGroup1
        '
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup11)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup12)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup13)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup14)
        Me.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
        '
        'editingRibbonPageGroup1
        '
        Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1)
        Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1)
        Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
        '
        'mailingsRibbonPage1
        '
        Me.mailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.mailMergeRibbonPageGroup1, Me.rpgDataSource})
        Me.mailingsRibbonPage1.Name = "mailingsRibbonPage1"
        '
        'mailMergeRibbonPageGroup1
        '
        Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.insertMergeFieldItem1)
        Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
        Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
        Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.toggleViewMergedDataItem1)
        Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
        '
        'rpgDataSource
        '
        Me.rpgDataSource.ItemLinks.Add(Me.bbiDataSource)
        Me.rpgDataSource.Name = "rpgDataSource"
        Me.rpgDataSource.Text = "DataSource"
        '
        'InsertRibbonPage1
        '
        Me.InsertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PagesRibbonPageGroup1, Me.TablesRibbonPageGroup1, Me.IllustrationsRibbonPageGroup1, Me.LinksRibbonPageGroup1, Me.HeaderFooterRibbonPageGroup1, Me.TextRibbonPageGroup1, Me.SymbolsRibbonPageGroup1})
        Me.InsertRibbonPage1.Name = "InsertRibbonPage1"
        '
        'PagesRibbonPageGroup1
        '
        Me.PagesRibbonPageGroup1.AllowTextClipping = False
        Me.PagesRibbonPageGroup1.ItemLinks.Add(Me.InsertPageBreakItem21)
        Me.PagesRibbonPageGroup1.Name = "PagesRibbonPageGroup1"
        '
        'TablesRibbonPageGroup1
        '
        Me.TablesRibbonPageGroup1.AllowTextClipping = False
        Me.TablesRibbonPageGroup1.ItemLinks.Add(Me.InsertTableItem1)
        Me.TablesRibbonPageGroup1.Name = "TablesRibbonPageGroup1"
        '
        'IllustrationsRibbonPageGroup1
        '
        Me.IllustrationsRibbonPageGroup1.ItemLinks.Add(Me.InsertPictureItem1)
        Me.IllustrationsRibbonPageGroup1.ItemLinks.Add(Me.InsertFloatingPictureItem1)
        Me.IllustrationsRibbonPageGroup1.Name = "IllustrationsRibbonPageGroup1"
        '
        'LinksRibbonPageGroup1
        '
        Me.LinksRibbonPageGroup1.ItemLinks.Add(Me.InsertBookmarkItem1)
        Me.LinksRibbonPageGroup1.ItemLinks.Add(Me.InsertHyperlinkItem1)
        Me.LinksRibbonPageGroup1.Name = "LinksRibbonPageGroup1"
        '
        'HeaderFooterRibbonPageGroup1
        '
        Me.HeaderFooterRibbonPageGroup1.ItemLinks.Add(Me.EditPageHeaderItem1)
        Me.HeaderFooterRibbonPageGroup1.ItemLinks.Add(Me.EditPageFooterItem1)
        Me.HeaderFooterRibbonPageGroup1.ItemLinks.Add(Me.InsertPageNumberItem1)
        Me.HeaderFooterRibbonPageGroup1.ItemLinks.Add(Me.InsertPageCountItem1)
        Me.HeaderFooterRibbonPageGroup1.Name = "HeaderFooterRibbonPageGroup1"
        '
        'TextRibbonPageGroup1
        '
        Me.TextRibbonPageGroup1.Glyph = CType(resources.GetObject("TextRibbonPageGroup1.Glyph"), System.Drawing.Image)
        Me.TextRibbonPageGroup1.ItemLinks.Add(Me.InsertTextBoxItem1)
        Me.TextRibbonPageGroup1.Name = "TextRibbonPageGroup1"
        '
        'SymbolsRibbonPageGroup1
        '
        Me.SymbolsRibbonPageGroup1.AllowTextClipping = False
        Me.SymbolsRibbonPageGroup1.ItemLinks.Add(Me.InsertSymbolItem1)
        Me.SymbolsRibbonPageGroup1.Name = "SymbolsRibbonPageGroup1"
        '
        'PageLayoutRibbonPage1
        '
        Me.PageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PageSetupRibbonPageGroup1, Me.PageBackgroundRibbonPageGroup1})
        Me.PageLayoutRibbonPage1.Name = "PageLayoutRibbonPage1"
        '
        'PageSetupRibbonPageGroup1
        '
        Me.PageSetupRibbonPageGroup1.ItemLinks.Add(Me.ChangeSectionPageMarginsItem1)
        Me.PageSetupRibbonPageGroup1.ItemLinks.Add(Me.ChangeSectionPageOrientationItem1)
        Me.PageSetupRibbonPageGroup1.ItemLinks.Add(Me.ChangeSectionPaperKindItem1)
        Me.PageSetupRibbonPageGroup1.ItemLinks.Add(Me.ChangeSectionColumnsItem1)
        Me.PageSetupRibbonPageGroup1.ItemLinks.Add(Me.InsertBreakItem1)
        Me.PageSetupRibbonPageGroup1.ItemLinks.Add(Me.ChangeSectionLineNumberingItem1)
        Me.PageSetupRibbonPageGroup1.Name = "PageSetupRibbonPageGroup1"
        '
        'PageBackgroundRibbonPageGroup1
        '
        Me.PageBackgroundRibbonPageGroup1.AllowTextClipping = False
        Me.PageBackgroundRibbonPageGroup1.ItemLinks.Add(Me.ChangePageColorItem1)
        Me.PageBackgroundRibbonPageGroup1.Name = "PageBackgroundRibbonPageGroup1"
        '
        'ribbonStatusBar1
        '
        Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 539)
        Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
        Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
        Me.ribbonStatusBar1.Size = New System.Drawing.Size(792, 27)
        '
        'richEditBarController1
        '
        Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
        Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
        Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
        Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
        Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
        Me.richEditBarController1.BarItems.Add(Me.printItem1)
        Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
        Me.richEditBarController1.BarItems.Add(Me.undoItem1)
        Me.richEditBarController1.BarItems.Add(Me.redoItem1)
        Me.richEditBarController1.BarItems.Add(Me.changeFontNameItem1)
        Me.richEditBarController1.BarItems.Add(Me.changeFontSizeItem1)
        Me.richEditBarController1.BarItems.Add(Me.changeFontColorItem1)
        Me.richEditBarController1.BarItems.Add(Me.changeFontBackColorItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontBoldItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontItalicItem1)
        Me.richEditBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
        Me.richEditBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
        Me.richEditBarController1.BarItems.Add(Me.clearFormattingItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleNumberingListItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleBulletedListItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
        Me.richEditBarController1.BarItems.Add(Me.decreaseIndentItem1)
        Me.richEditBarController1.BarItems.Add(Me.increaseIndentItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
        Me.richEditBarController1.BarItems.Add(Me.showParagraphFormItem1)
        Me.richEditBarController1.BarItems.Add(Me.insertMergeFieldItem1)
        Me.richEditBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
        Me.richEditBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleViewMergedDataItem1)
        Me.richEditBarController1.BarItems.Add(Me.changeStyleItem1)
        Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
        Me.richEditBarController1.BarItems.Add(Me.cutItem1)
        Me.richEditBarController1.BarItems.Add(Me.copyItem1)
        Me.richEditBarController1.BarItems.Add(Me.pasteSpecialItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
        Me.richEditBarController1.BarItems.Add(Me.changeTextCaseItem1)
        Me.richEditBarController1.BarItems.Add(Me.makeTextUpperCaseItem1)
        Me.richEditBarController1.BarItems.Add(Me.makeTextLowerCaseItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleTextCaseItem1)
        Me.richEditBarController1.BarItems.Add(Me.showFontFormItem1)
        Me.richEditBarController1.BarItems.Add(Me.changeParagraphLineSpacingItem1)
        Me.richEditBarController1.BarItems.Add(Me.setSingleParagraphSpacingItem1)
        Me.richEditBarController1.BarItems.Add(Me.setSesquialteralParagraphSpacingItem1)
        Me.richEditBarController1.BarItems.Add(Me.setDoubleParagraphSpacingItem1)
        Me.richEditBarController1.BarItems.Add(Me.showLineSpacingFormItem1)
        Me.richEditBarController1.BarItems.Add(Me.addSpacingBeforeParagraphItem1)
        Me.richEditBarController1.BarItems.Add(Me.removeSpacingBeforeParagraphItem1)
        Me.richEditBarController1.BarItems.Add(Me.addSpacingAfterParagraphItem1)
        Me.richEditBarController1.BarItems.Add(Me.removeSpacingAfterParagraphItem1)
        Me.richEditBarController1.BarItems.Add(Me.changeParagraphBackColorItem1)
        Me.richEditBarController1.BarItems.Add(Me.showEditStyleFormItem1)
        Me.richEditBarController1.BarItems.Add(Me.findItem1)
        Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
        Me.richEditBarController1.BarItems.Add(Me.galleryChangeStyleItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertPageBreakItem21)
        Me.richEditBarController1.BarItems.Add(Me.InsertTableItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertPictureItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertFloatingPictureItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertBookmarkItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertHyperlinkItem1)
        Me.richEditBarController1.BarItems.Add(Me.EditPageHeaderItem1)
        Me.richEditBarController1.BarItems.Add(Me.EditPageFooterItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertPageNumberItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertPageCountItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertTextBoxItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertSymbolItem1)
        Me.richEditBarController1.BarItems.Add(Me.ChangeSectionPageMarginsItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetNormalSectionPageMarginsItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetNarrowSectionPageMarginsItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetModerateSectionPageMarginsItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetWideSectionPageMarginsItem1)
        Me.richEditBarController1.BarItems.Add(Me.ShowPageMarginsSetupFormItem1)
        Me.richEditBarController1.BarItems.Add(Me.ChangeSectionPageOrientationItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetPortraitPageOrientationItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetLandscapePageOrientationItem1)
        Me.richEditBarController1.BarItems.Add(Me.ChangeSectionPaperKindItem1)
        Me.richEditBarController1.BarItems.Add(Me.ChangeSectionColumnsItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetSectionOneColumnItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetSectionTwoColumnsItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetSectionThreeColumnsItem1)
        Me.richEditBarController1.BarItems.Add(Me.ShowColumnsSetupFormItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertBreakItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertPageBreakItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertColumnBreakItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertSectionBreakNextPageItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertSectionBreakEvenPageItem1)
        Me.richEditBarController1.BarItems.Add(Me.InsertSectionBreakOddPageItem1)
        Me.richEditBarController1.BarItems.Add(Me.ChangeSectionLineNumberingItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetSectionLineNumberingNoneItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetSectionLineNumberingContinuousItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetSectionLineNumberingRestartNewPageItem1)
        Me.richEditBarController1.BarItems.Add(Me.SetSectionLineNumberingRestartNewSectionItem1)
        Me.richEditBarController1.BarItems.Add(Me.ToggleParagraphSuppressLineNumbersItem1)
        Me.richEditBarController1.BarItems.Add(Me.ShowLineNumberingFormItem1)
        Me.richEditBarController1.BarItems.Add(Me.ChangePageColorItem1)
        Me.richEditBarController1.Control = Me.richEditControl1
        '
        'showFontFormItem1
        '
        Me.showFontFormItem1.Id = -1
        Me.showFontFormItem1.Name = "showFontFormItem1"
        '
        'showEditStyleFormItem1
        '
        Me.showEditStyleFormItem1.Id = -1
        Me.showEditStyleFormItem1.Name = "showEditStyleFormItem1"
        '
        'ribbonPageGroup2
        '
        Me.ribbonPageGroup2.ItemLinks.Add(Me.changeFontNameItem1)
        Me.ribbonPageGroup2.ItemLinks.Add(Me.changeFontSizeItem1)
        Me.ribbonPageGroup2.ItemLinks.Add(Me.changeFontColorItem1)
        Me.ribbonPageGroup2.ItemLinks.Add(Me.changeFontBackColorItem1)
        Me.ribbonPageGroup2.ItemLinks.Add(Me.toggleFontBoldItem1)
        Me.ribbonPageGroup2.ItemLinks.Add(Me.toggleFontItalicItem1)
        Me.ribbonPageGroup2.ItemLinks.Add(Me.fontSizeIncreaseItem1)
        Me.ribbonPageGroup2.ItemLinks.Add(Me.fontSizeDecreaseItem1)
        Me.ribbonPageGroup2.ItemLinks.Add(Me.clearFormattingItem1)
        Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
        Me.ribbonPageGroup2.Text = "Font"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.printItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.undoItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.redoItem1)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "Common"
        '
        'frmEmailTemplates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.richEditControl1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Controls.Add(Me.ribbonStatusBar1)
        Me.Name = "frmEmailTemplates"
        Me.Text = "Form1"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iceDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
    Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
    Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
    Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
    Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
    Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
    Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
    Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
    Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
    Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
    Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
    Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
    Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
    Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
    Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
    Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
    Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
    Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
    Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
    Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
    Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
    Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
    Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
    Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
    Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
    Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
    Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
    Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
    Private showParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
    Private insertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
    Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
    Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
    Private toggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
    Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
    Private WithEvents mergeToNewDocumentItem As DevExpress.XtraBars.BarButtonItem
    Private WithEvents mergeToFileItem As DevExpress.XtraBars.BarButtonItem
    Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
    Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
    Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private mailingsRibbonPage1 As DevExpress.XtraRichEdit.UI.MailingsRibbonPage
    Private mailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup
    Private changeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem
    Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
    Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
    Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
    Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
    Private pasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
    Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
    Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
    Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
    Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
    Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
    Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
    Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
    Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
    Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
    Private changeTextCaseItem1 As DevExpress.XtraRichEdit.UI.ChangeTextCaseItem
    Private makeTextUpperCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem
    Private makeTextLowerCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem
    Private toggleTextCaseItem1 As DevExpress.XtraRichEdit.UI.ToggleTextCaseItem
    Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
    Private barButtonGroup5 As DevExpress.XtraBars.BarButtonGroup
    Private barButtonGroup6 As DevExpress.XtraBars.BarButtonGroup
    Private barButtonGroup7 As DevExpress.XtraBars.BarButtonGroup
    Private changeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
    Private setSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
    Private setSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
    Private setDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
    Private showLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
    Private addSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
    Private removeSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
    Private addSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
    Private removeSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
    Private changeParagraphBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem
    Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
    Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
    Private showFontFormItem1 As DevExpress.XtraRichEdit.UI.ShowFontFormItem
    Private showEditStyleFormItem1 As DevExpress.XtraRichEdit.UI.ShowEditStyleFormItem
    Private galleryChangeStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem
    Private barButtonGroup8 As DevExpress.XtraBars.BarButtonGroup
    Private barButtonGroup9 As DevExpress.XtraBars.BarButtonGroup
    Private barButtonGroup10 As DevExpress.XtraBars.BarButtonGroup
    Private barButtonGroup11 As DevExpress.XtraBars.BarButtonGroup
    Private barButtonGroup12 As DevExpress.XtraBars.BarButtonGroup
    Private barButtonGroup13 As DevExpress.XtraBars.BarButtonGroup
    Private barButtonGroup14 As DevExpress.XtraBars.BarButtonGroup
    Private fileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
    Private commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
    Private homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
    Private clipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
    Private fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
    Private paragraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
    Private stylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
    Private editingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
    Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents InsertPageBreakItem21 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem2
    Friend WithEvents InsertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
    Friend WithEvents InsertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
    Friend WithEvents InsertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
    Friend WithEvents InsertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
    Friend WithEvents InsertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
    Friend WithEvents EditPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
    Friend WithEvents EditPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
    Friend WithEvents InsertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
    Friend WithEvents InsertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
    Friend WithEvents InsertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem
    Friend WithEvents InsertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
    Friend WithEvents ChangeSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem
    Friend WithEvents SetNormalSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem
    Friend WithEvents SetNarrowSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem
    Friend WithEvents SetModerateSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem
    Friend WithEvents SetWideSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem
    Friend WithEvents ShowPageMarginsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem
    Friend WithEvents ChangeSectionPageOrientationItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem
    Friend WithEvents SetPortraitPageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem
    Friend WithEvents SetLandscapePageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem
    Friend WithEvents ChangeSectionPaperKindItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem
    Friend WithEvents ChangeSectionColumnsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem
    Friend WithEvents SetSectionOneColumnItem1 As DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem
    Friend WithEvents SetSectionTwoColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem
    Friend WithEvents SetSectionThreeColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem
    Friend WithEvents ShowColumnsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem
    Friend WithEvents InsertBreakItem1 As DevExpress.XtraRichEdit.UI.InsertBreakItem
    Friend WithEvents InsertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
    Friend WithEvents InsertColumnBreakItem1 As DevExpress.XtraRichEdit.UI.InsertColumnBreakItem
    Friend WithEvents InsertSectionBreakNextPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem
    Friend WithEvents InsertSectionBreakEvenPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem
    Friend WithEvents InsertSectionBreakOddPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem
    Friend WithEvents ChangeSectionLineNumberingItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem
    Friend WithEvents SetSectionLineNumberingNoneItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem
    Friend WithEvents SetSectionLineNumberingContinuousItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem
    Friend WithEvents SetSectionLineNumberingRestartNewPageItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem
    Friend WithEvents SetSectionLineNumberingRestartNewSectionItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem
    Friend WithEvents ToggleParagraphSuppressLineNumbersItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem
    Friend WithEvents ShowLineNumberingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem
    Friend WithEvents ChangePageColorItem1 As DevExpress.XtraRichEdit.UI.ChangePageColorItem
    Friend WithEvents bbiDataSource As DevExpress.XtraBars.BarEditItem
    Friend WithEvents iceDataSource As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents rpgDataSource As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents InsertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
    Friend WithEvents PagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
    Friend WithEvents TablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
    Friend WithEvents IllustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
    Friend WithEvents LinksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
    Friend WithEvents HeaderFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
    Friend WithEvents TextRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TextRibbonPageGroup
    Friend WithEvents SymbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
    Friend WithEvents PageLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage
    Friend WithEvents PageSetupRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup
    Friend WithEvents PageBackgroundRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup
End Class


