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
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace RichEditAPISample.CodeExamples
    Friend Class ExportActions

        Private Shared Sub SaveImageFromRange(ByVal document As Document)
'            #Region "#SaveImageFromRange"
            document.LoadDocument("Grimm.docx", DevExpress.XtraRichEdit.DocumentFormat.OpenXml)
            Dim docRange As DocumentRange = document.Paragraphs(2).Range
            Dim docImageColl As ReadOnlyDocumentImageCollection = document.Images.Get(docRange)
            If docImageColl.Count > 0 Then
                Dim myImage As DevExpress.Office.Utils.OfficeImage = docImageColl(0).Image
                Dim image As System.Drawing.Image = myImage.NativeImage
                Dim imageName As String = String.Format("Image_at_pos_{0}.png", docRange.Start.ToInt())
                image.Save(imageName)
                System.Diagnostics.Process.Start("explorer.exe", "/select," & imageName)
            End If
'            #End Region ' #SaveImageFromRange
        End Sub

        Private Shared Sub ExportRangeToHtml(ByVal document As Document)
'            #Region "#ExportRangeToHtml"
            document.LoadDocument("Grimm.docx", DevExpress.XtraRichEdit.DocumentFormat.OpenXml)
            ' Get the range for three paragraphs.
            Dim r As DocumentRange = document.CreateRange(document.Paragraphs(0).Range.Start, document.Paragraphs(0).Range.Length + document.Paragraphs(1).Range.Length + document.Paragraphs(2).Range.Length)
            ' Export to HTML.
            Dim htmlText As String = document.GetHtmlText(r, Nothing)
            System.IO.File.WriteAllText("test.html", htmlText)
            ' Show the result in a browser window.
            System.Diagnostics.Process.Start("test.html")
'            #End Region ' #ExportRangeToHtml
        End Sub

        Private Shared Sub ExportRangeToPlainText(ByVal document As Document)
'            #Region "#ExportRangeToPlainText"
            document.LoadDocument("Grimm.docx", DevExpress.XtraRichEdit.DocumentFormat.OpenXml)
            Dim plainText As String = document.GetText(document.Paragraphs(2).Range)
            System.Windows.Forms.MessageBox.Show(plainText)
'            #End Region ' #ExportRangeToPlainText
        End Sub
    End Class
End Namespace
