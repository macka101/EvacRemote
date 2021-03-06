﻿' Developer Express Code Central Example:
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
Imports System.Drawing

Namespace RichEditAPISample.CodeExamples
    Public NotInheritable Class FormattingActions

        Private Sub New()
        End Sub

        Private Shared Sub FormatText(ByVal document As Document)
'            #Region "#FormatText"
            document.BeginUpdate()
            document.AppendText("Normal" & ControlChars.Lf & "Formatted" & ControlChars.Lf & "Normal")
            document.EndUpdate()
            Dim range As DocumentRange = document.Paragraphs(1).Range
            Dim cp As CharacterProperties = document.BeginUpdateCharacters(range)
            cp.FontName = "Comic Sans MS"
            cp.FontSize = 18
            cp.ForeColor = Color.Blue
            cp.BackColor = Color.Snow
            cp.Underline = UnderlineType.DoubleWave
            cp.UnderlineColor = Color.Red
            document.EndUpdateCharacters(cp)
'            #End Region ' #FormatText
        End Sub

        Private Shared Sub FormatParagraph(ByVal document As Document)
'            #Region "#FormatParagraph"
            document.BeginUpdate()
            document.AppendText("Modified Paragraph" & ControlChars.Lf & "Normal" & ControlChars.Lf & "Normal")
            document.EndUpdate()
            Dim pos As DocumentPosition = document.Range.Start
            Dim range As DocumentRange = document.CreateRange(pos, 0)
            Dim pp As ParagraphProperties = document.BeginUpdateParagraphs(range)
            ' Center paragraph
            pp.Alignment = ParagraphAlignment.Center
            ' Set triple spacing
            pp.LineSpacingType = ParagraphLineSpacing.Multiple
            pp.LineSpacingMultiplier = 3
            ' Set left indent at 0.5".
            ' Default unit is 1/300 of an inch (a document unit).
            pp.LeftIndent = DevExpress.Office.Utils.Units.InchesToDocumentsF(0.5F)
            ' Set tab stop at 1.5"
            Dim tbiColl As TabInfoCollection = pp.BeginUpdateTabs(True)
            Dim tbi As New TabInfo()
            tbi.Alignment = TabAlignmentType.Center
            tbi.Position = DevExpress.Office.Utils.Units.InchesToDocumentsF(1.5F)
            tbiColl.Add(tbi)
            pp.EndUpdateTabs(tbiColl)
            document.EndUpdateParagraphs(pp)
'            #End Region ' #FormatParagraph
        End Sub
    End Class
End Namespace
