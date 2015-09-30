' Developer Express Code Central Example:
' WinForms RichEditControl API
' 
' This example demonstrates how to use RichEditControl API to programmatically
' manage rich text documents.
' The application includes the RichEditControl (at
' the top) used to display and edit the code and another RichEditControl (at the
' bottom) which shows the result of code execution.
' You can modify the code and
' watch the result. The code is executed two seconds after it is modified. If an
' error occurs during compilation or execution, the code window background color
' turns to pink.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5219

Imports DevExpress.XtraRichEdit.API.Native
Imports System
Imports System.Linq

Namespace RichEditAPISample.CodeExamples
    Friend Class SearchAndReplaceActions
        Private Shared Sub FindSixLetterWords(ByVal document As Document)
'            #Region "#FindSixLetterWords"
            document.LoadDocument("Grimm.docx", DevExpress.XtraRichEdit.DocumentFormat.OpenXml)
            document.InsertSection(document.Range.Start)
            ' Specify a regular expression that will find all six letter words.
            Dim expr As New System.Text.RegularExpressions.Regex("\b\w{6}\b")
            Dim sixLetterWords As New System.Collections.Specialized.StringCollection()
            ' Perform the search.
            Dim found() As DocumentRange = document.FindAll(expr)
            For Each r As DocumentRange In found
                sixLetterWords.Add(document.GetText(r))
            Next r
            document.BeginUpdate()
            ' Insert an ordered list of non-repetitive words in the beginning of the document.
            Dim distinctWords = sixLetterWords.Cast(Of String)().Distinct().OrderByDescending(Function(s) s)
            For Each s In distinctWords
                document.InsertText(document.Range.Start, s.ToString() & Environment.NewLine)
            Next s
            document.EndUpdate()
'            #End Region ' #FindSixLetterWords
        End Sub

        Private Shared Sub FindDatesInSpecificFormat(ByVal document As Document)
'            #Region "#FindDatesInSpecificFormat"
            document.AppendText("12\14\2014" & Environment.NewLine)
            Dim result As IRegexSearchResult
            Dim pattern As String = "(?<mm>\d{2}).(?<dd>\d{2}).(?<yyyy>\d{4})"
            Dim myRegEx As New System.Text.RegularExpressions.Regex(pattern)

            result = document.StartSearch(myRegEx)
            If result.FindNext() Then
                Dim dayFound As String = result.Match.Groups(2).Value
                Dim monthFound As String = result.Match.Groups(1).Value
                Dim yearFound As String = result.Match.Groups(3).Value
                document.AppendText(String.Format("Found a date that is the {0} day of the {1} month of the {2} year.", dayFound, monthFound, yearFound))
            End If
'            #End Region ' #FindDatesInSpecificFormat
        End Sub

        Private Shared Sub RemoveBlankLines(ByVal document As Document)
'            #Region "#RemoveBlankLines"
            document.LoadDocument("Grimm.docx", DevExpress.XtraRichEdit.DocumentFormat.OpenXml)
            Dim pattern As String = "((?<=^)|(?<=\n))\n"
            Dim replacementString As String = String.Empty
            Dim myRegEx As New System.Text.RegularExpressions.Regex(pattern)
            Dim count As Integer = document.ReplaceAll(myRegEx, replacementString)
            System.Windows.Forms.MessageBox.Show(String.Format("{0} blank lines have been removed",count))
'            #End Region ' #RemoveBlankLines
        End Sub

        Private Shared Sub ChangeDateFormat(ByVal document As Document)
'            #Region "#ChangeDateFormat"
            document.AppendText("12\14\2014" & Environment.NewLine)
            Dim pattern As String = "(?<mm>\d{2}).(?<dd>\d{2}).(?<yyyy>\d{4})"
            Dim replacementString As String = "${yyyy}-${mm}-${dd} or ${dd}.${mm}.${yyyy}"
            Dim myRegEx As New System.Text.RegularExpressions.Regex(pattern)
            Dim count As Integer = document.ReplaceAll(myRegEx, replacementString)
            System.Windows.Forms.MessageBox.Show(String.Format("We've done {0} replacement(s).", count))
'            #End Region ' #ChangeDateFormat
        End Sub
    End Class
End Namespace
