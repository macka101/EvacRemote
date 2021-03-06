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

Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports System

Namespace RichEditAPISample.CodeExamples
    Public NotInheritable Class RangeActions

        Private Sub New()
        End Sub

        Private Shared Sub SelectTextInRange(ByVal document As Document)
'            #Region "#SelectTextInRange"
            document.LoadDocument("Grimm.docx", DocumentFormat.OpenXml)
            Dim myStart As DocumentPosition = document.CreatePosition(69)
            Dim myRange As DocumentRange = document.CreateRange(myStart, 216)
            document.Selection = myRange
'            #End Region ' #SelectTextInRange
        End Sub

        Private Shared Sub InsertTextAtCaretPosition(ByVal document As Document)
'            #Region "#InsertTextAtCaretPosition"
            Dim pos As DocumentPosition = document.CaretPosition
            Dim doc As SubDocument = pos.BeginUpdateDocument()
            doc.InsertText(pos, " INSERTED TEXT ")
            pos.EndUpdateDocument(doc)
'            #End Region ' #InsertTextAtCaretPosition
        End Sub

        Private Shared Sub InsertTextInRange(ByVal document As Document)
'            #Region "#InsertTextInRange"
            document.AppendText("ABCDEFGH")
            Dim r1 As DocumentRange = document.CreateRange(1, 3)
            Dim pos1 As DocumentPosition = document.CreatePosition(2)
            Dim r2 As DocumentRange = document.InsertText(pos1, ">>NewText<<")
            Dim s1 As String = String.Format("Range r1 starts at {0}, ends at {1}", r1.Start, r1.End)
            Dim s2 As String = String.Format("Range r2 starts at {0}, ends at {1}", r2.Start, r2.End)
            document.Paragraphs.Append()
            document.AppendText(s1)
            document.Paragraphs.Append()
            document.AppendText(s2)
'            #End Region ' #InsertTextInRange
        End Sub

        Private Shared Sub AppendTextToRange(ByVal document As Document)
'            #Region "#AppendTextToRange"
            document.AppendText("abcdefgh")
            Dim r1 As DocumentRange = document.AppendText("X")
            Dim s1 As String = String.Format("Range r1 starts at {0}, ends at {1}", r1.Start, r1.End)
            document.AppendText("Y")
            document.AppendText("Z")
            Dim s2 As String = String.Format("Currently range r1 starts at {0}, ends at {1}", r1.Start, r1.End)
            document.Paragraphs.Append()
            document.AppendText(s1)
            document.Paragraphs.Append()
            document.AppendText(s2)
'            #End Region ' #AppendTextToRange
        End Sub

        Private Shared Sub CopyAndPasteRange(ByVal document As Document)
'            #Region "#CopyAndPasteRange"
            document.LoadDocument("Grimm.docx", DocumentFormat.OpenXml)
            Dim myRange As DocumentRange = document.Paragraphs(0).Range
            document.Copy(myRange)
            document.Paste(DocumentFormat.PlainText)
'            #End Region ' #CopyAndPasteRange
        End Sub

        Private Shared Sub AppendToParagraph(ByVal document As Document)
'            #Region "#AppendToParagraph"
            document.BeginUpdate()
            document.AppendText("First Paragraph" & ControlChars.Lf & "Second Paragraph" & ControlChars.Lf & "Third Paragraph")
            document.EndUpdate()
            Dim pos As DocumentPosition = document.CaretPosition
            Dim doc As SubDocument = pos.BeginUpdateDocument()
            Dim par As Paragraph = doc.Paragraphs.Get(pos)
            Dim newPos As DocumentPosition = doc.CreatePosition(par.Range.End.ToInt() - 1)
            doc.InsertText(newPos, "<<Appended to Paragraph End>>")
            pos.EndUpdateDocument(doc)
'            #End Region ' #AppendToParagraph
        End Sub


    End Class
End Namespace
