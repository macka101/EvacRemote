Imports System.Windows.Forms
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Diagnostics
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Snap
Imports Microsoft.VisualBasic
Imports DevExpress.Xpo.DB
Imports System.Drawing.Printing
Imports DevExpress.Pdf
Imports System.Drawing
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports System.Collections.Generic
Imports DevExpress.XtraBars
Imports System.Reflection
Imports System.ComponentModel
Imports Microsoft.VisualBasic.FileIO

Public Enum eDatevalue
    FirstDayLastMonth
    FirstDayThisMonth
    FirstOfDayWeek
    FirstDayNextMonth
    LastDayLastMonth
    LastDayThisMonth
    LastDayNextMonth
End Enum
Public Enum fileType
    PDF = 1
    XLS = 2
    XLSX = 3
End Enum

Public Module SharedMisc

    Public Function GetFileName(ByVal pType As fileType) As String

        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.FileName = ""
        If pType = fileType.XLS Then
            openFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*"
        ElseIf pType = fileType.XLSX Then
            openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        ElseIf pType = fileType.PDF Then
            openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
        End If

        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Return openFileDialog1.FileName
        Else
            Return Nothing
        End If

    End Function
    Public Function GetExcelDataSet(sfilepath As String) As DataSet

        Dim sconnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & sfilepath & "; Extended Properties='Excel 8.0; HDR=Yes; IMEX=1'"
        Dim oledbConn As OleDbConnection = New OleDbConnection(sconnectionString)
        Dim ds As New DataSet

        Try

            oledbConn.Open()

            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn)
            Dim oleda As OleDbDataAdapter = New OleDbDataAdapter()

            oleda.SelectCommand = cmd

            oleda.Fill(ds, "Import")

            For Each oCol As DataColumn In ds.Tables(0).Columns
                oCol.ColumnName = oCol.ColumnName.Trim
            Next


        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message.ToString(), "Error")

        Finally

            ' Close connection

            oledbConn.Close()

        End Try

        Return ds

    End Function
    Public Sub LoadFile(ByVal pFile As String)
        If File.Exists(pFile) Then
            Dim myProcess As System.Diagnostics.Process = New System.Diagnostics.Process
            myProcess.StartInfo.FileName = pFile
            myProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            myProcess.Start()
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, pFile & " not Available", "Warning", MessageBoxButtons.OK)
        End If
    End Sub

    Public Sub ExportPivotViewtoXLSx(ByRef pGrid As PivotGridControl)
        Dim saveDialog As Windows.Forms.SaveFileDialog = New Windows.Forms.SaveFileDialog()
        saveDialog.Filter = "Excel files (*.XLSX)|.XLSX"
        saveDialog.FilterIndex = 1
        saveDialog.InitialDirectory = GetMyDocumentsDir()
        saveDialog.RestoreDirectory = True
        If Not pGrid.Tag Is Nothing Then
            saveDialog.FileName = CStr(pGrid.Tag)
        Else
            saveDialog.FileName = "Export"
        End If
        '    saveDialog.FileName = "Export" & "." & saveDialog.DefaultExt
        'Do export if the end user presses OK
        If System.Windows.Forms.DialogResult.OK = saveDialog.ShowDialog() Then
            pGrid.ExportToXlsx(saveDialog.FileName)
            Dim processproperties As New ProcessStartInfo
            processproperties.FileName = saveDialog.FileName
            processproperties.WindowStyle = ProcessWindowStyle.Maximized
            Dim myProcess As Process = Process.Start(processproperties)
        End If
    End Sub
    Public Sub ExportViewtoXLSx(ByRef vGrid As GridView)
        Dim saveDialog As Windows.Forms.SaveFileDialog = New Windows.Forms.SaveFileDialog()
        saveDialog.Filter = "Excel files (*.XLSX)|.XLSX"
        saveDialog.FilterIndex = 1
        saveDialog.InitialDirectory = GetMyDocumentsDir()
        saveDialog.RestoreDirectory = True
        If vGrid.ViewCaption = "" Then
            saveDialog.FileName = "Export"
        Else
            saveDialog.FileName = vGrid.ViewCaption
        End If

        'Do export if the end user presses OK
        If System.Windows.Forms.DialogResult.OK = saveDialog.ShowDialog() Then
            vGrid.ExportToXlsx(saveDialog.FileName)
            Dim processproperties As New ProcessStartInfo
            processproperties.FileName = saveDialog.FileName
            processproperties.WindowStyle = ProcessWindowStyle.Maximized
            Dim myProcess As Process = Process.Start(processproperties)
        End If
    End Sub
    Public Function GetHomeDir() As String
        Return Environment.GetEnvironmentVariable("USERPROFILE")
    End Function
    Public Function GetMyDocumentsDir() As String
        Return Environment.GetFolderPath(Environment.SpecialFolder.Personal)
    End Function
    Public Function GetEnvTempDir() As String
        Return Environment.GetEnvironmentVariable("TEMP")
    End Function
    Public Function GetTempDir() As String
        Return System.IO.Path.GetTempPath()
    End Function
    Public Function GetTempFile() As String
        Return System.IO.Path.GetTempFileName()
    End Function


    Public Function GetDate(pDate As Date, pValue As eDatevalue) As Date
        Select Case pValue
            Case eDatevalue.FirstDayLastMonth
                Return New Date(pDate.Year, pDate.Month, 1).AddMonths(-1)
            Case eDatevalue.FirstOfDayWeek
                Return pDate.AddDays(-1 * (pDate.DayOfWeek - DayOfWeek.Monday))
            Case eDatevalue.FirstDayThisMonth
                Return New Date(pDate.Year, pDate.Month, 1)
            Case eDatevalue.FirstDayNextMonth
                Return New Date(pDate.Year, pDate.Month, 1).AddMonths(1)
            Case eDatevalue.LastDayLastMonth
                Return New Date(pDate.Year, pDate.Month, 1).AddDays(-1)
            Case eDatevalue.LastDayThisMonth
                '                Return New Date(pDate.Year, pDate.Month, 1).AddMonths(1)
            Case eDatevalue.LastDayNextMonth
                Return New Date(pDate.Year, pDate.Month, 1).AddMonths(3).AddDays(-1)
        End Select
    End Function

    Public Sub PopulateInstalledPrintersCombo(cmb As DevExpress.XtraEditors.Repository.RepositoryItemComboBox)
        ' Add list of installed printers found to the combo box. 
        ' The pkInstalledPrinters string will be used to provide the display string. 
        Dim i As Integer
        Dim pkInstalledPrinters As String

        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
            cmb.Items.Add(pkInstalledPrinters)
        Next
    End Sub
    Public ReadOnly Property DefaultPrinterName() As String
        Get
            Dim ps As New PrinterSettings()
            Return ps.PrinterName
        End Get
    End Property


    Public Function PDFMergeTemplate(pDocument As String, xp As XPBaseCollection)
        Dim outfileName As String = GetTempFile()

        Using _session As New UnitOfWork

            Dim templatesrv As RichEditDocumentServer = New RichEditDocumentServer()
            templatesrv.LoadDocumentTemplate(pDocument, DocumentFormat.Rtf)

            Dim mergeOptions As MailMergeOptions = templatesrv.CreateMailMergeOptions()
            mergeOptions.MergeMode = MergeMode.NewSection

            mergeOptions.DataSource = xp

            Dim docServer As RichEditDocumentServer = New RichEditDocumentServer()
            docServer.CreateNewDocument(False)

            templatesrv.MailMerge(mergeOptions, docServer.Document)

            Dim x = docServer.Document.Length


            outfileName = Path.ChangeExtension(outfileName, "pdf")
            Dim fsOut As FileStream = File.Open(outfileName, FileMode.Create)
            docServer.ExportToPdf(fsOut)
            fsOut.Close()

        End Using
        Return outfileName
    End Function
    'Public Function PDFMerge(ByVal files As List(Of String)) As String
    '    Dim outfileName As String = GetTempFile()
    '    outfileName = Path.ChangeExtension(outfileName, "pdf")
    '    Dim pdfDocumentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()

    '    For i As Integer = 0 To files.Count - 1
    '        If i = 0 Then
    '            pdfDocumentProcessor.LoadDocument(files(i))
    '        Else
    '            pdfDocumentProcessor.AppendDocument(files(i))
    '        End If
    '    Next
    '    pdfDocumentProcessor.SaveDocument(outfileName)
    '    Return outfileName
    'End Function
    'Public Sub PdfPrint(pPrinter As String, pDocument As String)
    '    Dim docServer As New PdfDocumentProcessor()
    '    docServer.LoadDocument(pDocument)
    '    Dim ps As New PrinterSettings
    '    ps.PrinterName = pPrinter
    '    'docServer.Print(ps)

    'End Sub
    Public Function TrimString2Length(ByVal pString As String, ByVal iMax As Integer) As String
        If pString Is Nothing Then
            Return ""
        End If
        If iMax > pString.Trim.Length Then
            Return pString.Trim
        Else
            Return pString.Substring(0, iMax)
        End If
    End Function

End Module
