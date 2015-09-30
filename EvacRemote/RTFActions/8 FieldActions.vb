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
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace RichEditAPISample.CodeExamples
    Friend Class FieldActions
        Private Shared Sub InsertField(ByVal document As Document)
'            #Region "#InsertField"
            document.BeginUpdate()
            document.Fields.Create(document.CaretPosition, "DATE")
            document.Fields.Update()
            document.EndUpdate()
'            #End Region ' #InsertField
        End Sub

        Private Shared Sub ModifyFieldCode(ByVal document As Document)
'            #Region "#ModifyFieldCode"
            document.BeginUpdate()
            document.Fields.Create(document.CaretPosition, "DATE")
            document.EndUpdate()
            For i As Integer = 0 To document.Fields.Count - 1
                Dim fieldCode As String = document.GetText(document.Fields(i).CodeRange)
                If fieldCode = "DATE" Then
                    Dim position As DocumentPosition = document.Fields(i).CodeRange.End
                    document.InsertText(position, "\@ ""M/d/yyyy h:mm am/pm""")
                End If
            Next i
            document.Fields.Update()
'            #End Region ' #ModifyFieldCode
        End Sub

        Private Shared Sub CreateFieldFromRange(ByVal document As Document)
'            #Region "#CreateFieldFromRange"
            document.BeginUpdate()
            document.AppendText("SYMBOL 0x54 \f Wingdings \s 24")
            document.EndUpdate()
            document.Fields.Create(document.Paragraphs(0).Range)
            document.Fields.Update()
'            #End Region ' #CreateFieldFromRange
        End Sub

        Private Shared Sub ShowFieldCodes(ByVal document As Document)
'            #Region "#ShowFieldCodes"
            document.LoadDocument("MailMergeSimple.docx", DevExpress.XtraRichEdit.DocumentFormat.OpenXml)
            For i As Integer = 0 To document.Fields.Count - 1
                document.Fields(i).ShowCodes = True
            Next i
'            #End Region ' #ShowFieldCodes
        End Sub


    End Class
End Namespace
