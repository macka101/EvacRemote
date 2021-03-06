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
    Friend Class HeaderAndFooterActions
        Private Shared Sub ModifyHeader(ByVal document As Document)
'            #Region "#ModifyHeader"
            document.AppendSection()
            Dim firstSection As Section = document.Sections(0)
            ' Modify the header of the HeaderFooterType.First type.
            Dim myHeader As SubDocument = firstSection.BeginUpdateHeader(HeaderFooterType.First)
            Dim range As DocumentRange = myHeader.InsertText(myHeader.CreatePosition(0), " PAGE NUMBER ")
            Dim fld As Field = myHeader.Fields.Create(range.End, "PAGE \* ARABICDASH")
            myHeader.Fields.Update()
            firstSection.EndUpdateHeader(myHeader)
            ' Display the header of the HeaderFooterType.First type on the first page.
            firstSection.DifferentFirstPage = True
'            #End Region ' #ModifyHeader
        End Sub
    End Class
End Namespace
