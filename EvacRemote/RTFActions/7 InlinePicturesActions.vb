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
    Friend Class InlinePicturesActions
        Private Shared Sub ImageFromFile(ByVal document As Document)
'            #Region "#ImageFromFile"
            Dim pos As DocumentPosition = document.Range.Start
            document.Images.Insert(pos, DocumentImageSource.FromFile("beverages.png"))
'            #End Region ' #ImageFromFile
        End Sub

        Private Shared Sub ImageCollection(ByVal document As Document)
'            #Region "#ImageCollection"
            document.LoadDocument("Grimm.docx", DevExpress.XtraRichEdit.DocumentFormat.OpenXml)
            Dim images As ReadOnlyDocumentImageCollection = document.Images
            ' If the width of an image exceeds 50 millimeters, 
            ' the image is scaled proportionally to half its size.
            For i As Integer = 0 To images.Count - 1
                If images(i).Size.Width > DevExpress.Office.Utils.Units.MillimetersToDocumentsF(50) Then
                    images(i).ScaleX /= 2
                    images(i).ScaleY /= 2
                End If
            Next i
'            #End Region ' #ImageCollection
        End Sub

        Private Shared Sub SaveImageToFile(ByVal document As Document)
'            #Region "#SaveImageToFile"
            document.LoadDocument("MovieRentals.docx", DevExpress.XtraRichEdit.DocumentFormat.OpenXml)
            Dim myRange As DocumentRange = document.CreateRange(0,100)
            Dim images As ReadOnlyDocumentImageCollection = document.Images.Get(myRange)
            If images.Count > 0 Then
                Dim myImage As DevExpress.Office.Utils.OfficeImage = images(0).Image
                Dim image As System.Drawing.Image = myImage.NativeImage
                Dim imageName As String = String.Format("Image_at_pos_{0}.png", images(0).Range.Start.ToInt())
                image.Save(imageName)
                System.Diagnostics.Process.Start("explorer.exe", "/select," & imageName)
            End If
'            #End Region ' #SaveImageToFile
        End Sub
    End Class
End Namespace
