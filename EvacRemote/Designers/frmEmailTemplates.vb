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
Imports DevExpress.XtraBars
Imports DevExpress.XtraRichEdit
#Region "#usings"
Imports DevExpress.XtraRichEdit.API.Native
#End Region ' #usings
Imports DevExpress.XtraTab
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Partial Public Class frmEmailTemplates
    Inherits Form
    Private _session As Session
    Public Sub New(ByVal session As Session)
        InitializeComponent()
        ribbonControl1.SelectedPage = mailingsRibbonPage1
        richEditControl1.LoadDocument("EmailTemplates\Standard.rtf", DocumentFormat.Rtf)
        '			#Region "#setdatasource"
        _session = session
        richEditControl1.Options.MailMerge.DataSource = MergeDataUser(session)
        richEditControl1.Options.MailMerge.ViewMergedData = True

    End Sub

    Private Sub mergeToFileItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles mergeToFileItem.ItemClick
        Dim myMergeOptions As MailMergeOptions = richEditControl1.Document.CreateMailMergeOptions()
        myMergeOptions.DataSource = MergeDataUser(_session)
        myMergeOptions.FirstRecordIndex = 1
        myMergeOptions.LastRecordIndex = 1
        myMergeOptions.MergeMode = MergeMode.NewSection

        Dim fileDialog As New SaveFileDialog()
        fileDialog.Filter = "MS Word 2007 documents (*.docx)|*.docx|All files (*.*)|*.*"
        fileDialog.FilterIndex = 1
        fileDialog.RestoreDirectory = True

        fileDialog.ShowDialog()
        Dim fName As String = fileDialog.FileName
        If fName <> "" Then
            richEditControl1.Document.MailMerge(myMergeOptions, fileDialog.FileName, DocumentFormat.OpenXml)
        End If
        System.Diagnostics.Process.Start(fileDialog.FileName)
    End Sub
    Public Function MergeDataUser(ByVal session As Session) As XPDataView
        Dim sSql As String = "SELECT [usercode], [username], [emailaddr], [Group], [directphone], [directfax], [jobtitle] "
        sSql = sSql + String.Format(" FROM [User] where [usercode] =  '{0}'", _UserCode)

        Dim dv As New XPDataView()
        Dim data As SelectedData = session.ExecuteQueryWithMetadata(sSql)
        For Each row As SelectStatementResultRow In data.ResultSet(0).Rows
            dv.AddProperty(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
        Next
        dv.LoadData(New SelectedData(data.ResultSet(1)))
        Return dv
    End Function
    Private Sub iceDataSource_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles iceDataSource.SelectedValueChanged

    End Sub
End Class
