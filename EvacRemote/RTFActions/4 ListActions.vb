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

Class ListActions
    Public Shared Sub CreateBulletedList(ByVal document As Document, ByVal sList As String)

        document.BeginUpdate()
        ' Define an abstract list that is the pattern for lists used in the document.
        Dim list As AbstractNumberingList = document.AbstractNumberingLists.Add()
        list.NumberingType = NumberingType.Bullet

        ' Specify parameters for each list level.

        Dim level As ListLevel = list.Levels(0)
        level.ParagraphProperties.LeftIndent = 100
        level.CharacterProperties.FontName = "Symbol"
        level.DisplayFormatString = New String(ChrW(&HB7), 1)

        level.DisplayFormatString = "*"

        level = list.Levels(1)
        level.ParagraphProperties.LeftIndent = 250
        level.CharacterProperties.FontName = "Symbol"
        level.DisplayFormatString = New String(ChrW(&H6F), 1)

        level.ParagraphProperties.BackColor = Color.Red
        level.ParagraphStyle.FontSize = 12
        level.ParagraphStyle.ForeColor = Color.White

        level.DisplayFormatString = "*"

        level = list.Levels(2)
        level.ParagraphProperties.LeftIndent = 450
        level.CharacterProperties.FontName = "Symbol"
        level.DisplayFormatString = New String(ChrW(&HB7), 1)

        ' Create a list for use in the document. It is based on a previously defined abstract list with ID = 0.
        document.NumberingLists.Add(0)
        document.EndUpdate()
        sList = sList.Replace("  ", "&")
        Dim words As String() = sList.Split(New Char() {"&"c})
        Dim word As String
        If words.Length > 1 Then
            For Each word In words
                document.AppendText(word & ControlChars.Lf)
            Next
        Else
            document.AppendText(sList)
        End If

        ' Convert all paragraphs to list items.
        document.BeginUpdate()
        Dim paragraphs As ParagraphCollection = document.Paragraphs
        For Each pgf As Paragraph In paragraphs
            pgf.ListIndex = 0
            pgf.ListLevel = 1
        Next pgf
        document.EndUpdate()
        '            #End Region ' #CreateBulletedList
    End Sub


    Private Shared Sub CreateNumberedList(ByVal document As Document, ByVal ListOptions As String)
        '            #Region "#CreateNumberedList"
        document.BeginUpdate()
        ' Define an abstract list that is the pattern for lists used in the document.
        Dim list As AbstractNumberingList = document.AbstractNumberingLists.Add()
        list.NumberingType = NumberingType.MultiLevel

        ' Specify parameters for each list level.

        Dim level As ListLevel = list.Levels(0)
        level.ParagraphProperties.LeftIndent = 150
        level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
        level.ParagraphProperties.FirstLineIndent = 75
        level.Start = 1
        level.NumberingFormat = NumberingFormat.Decimal
        level.DisplayFormatString = "{0}"

        level = list.Levels(1)
        level.ParagraphProperties.LeftIndent = 300
        level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
        level.ParagraphProperties.FirstLineIndent = 150
        level.Start = 1
        level.NumberingFormat = NumberingFormat.DecimalEnclosedParenthses
        level.DisplayFormatString = "{0}→{1}"

        level = list.Levels(2)
        level.ParagraphProperties.LeftIndent = 450
        level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
        level.ParagraphProperties.FirstLineIndent = 220
        level.Start = 1
        level.NumberingFormat = NumberingFormat.LowerRoman
        level.DisplayFormatString = "{0}→{1}→{2}"

        ' Create a list for use in the document. It is based on a previously defined abstract list with ID = 0.
        document.NumberingLists.Add(0)
        document.EndUpdate()

        document.AppendText("Line one" & ControlChars.Lf & "Line two" & ControlChars.Lf & "Line three" & ControlChars.Lf & "Line four")
        ' Convert all paragraphs to list items of level 0.
        document.BeginUpdate()
        Dim paragraphs As ParagraphCollection = document.Paragraphs
        For Each pgf As Paragraph In paragraphs
            pgf.ListIndex = 0
            pgf.ListLevel = 0
        Next pgf
        ' Specify a different level for a certain paragraph.
        document.Paragraphs(1).ListLevel = 1
        document.EndUpdate()
        '            #End Region ' #CreateNumberedList
    End Sub

End Class

