Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Office.NumberConverters
Imports System.Globalization

Public Class RichTextControlHelper
    Private Shared _richTextEdit As RichEditControl
    'Public Sub New(RichTextEdit As RichEditControl)
    '    _richTextEdit = RichTextEdit
    'End Sub
    'Public Sub New(RichTextEdit As RichEditControl, pain As Boolean)
    '    _richTextEdit = RichTextEdit
    '    PlainSetup(_richTextEdit, True)
    'End Sub
    Public Shared Sub PlainSetup(RichTextEdit As RichEditControl, Autocorrect As Boolean)
        _richTextEdit = RichTextEdit
        _richTextEdit.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden
        _richTextEdit.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden
        _richTextEdit.ActiveViewType = RichEditViewType.Simple
        '        RichTextEdit.Views.SimpleView.Padding = DevExpress.XtraRichEdit.API.Native
        _richTextEdit.Document.Text = String.Empty
        _richTextEdit.Document.BeginUpdate()
        _richTextEdit.Document.DefaultCharacterProperties.FontSize = 12
        _richTextEdit.Document.Sections(0).Margins.Top = 0
        _richTextEdit.Document.Sections(0).Margins.Left = 5
        _richTextEdit.Document.Sections(0).Margins.Right = 5
        _richTextEdit.Document.Sections(0).LineNumbering.CountBy = 1
        _richTextEdit.Document.Sections(0).LineNumbering.RestartType = LineNumberingRestart.Continuous
        _richTextEdit.Document.EndUpdate()
        If Autocorrect = True Then
            AddHandler _richTextEdit.AutoCorrect, AddressOf RichTextControlHelper.AutoCorrect
        End If
    End Sub
    Private Shared Sub AutoCorrect(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.AutoCorrectEventArgs)

        Dim info As AutoCorrectInfo = e.AutoCorrectInfo

        e.AutoCorrectInfo = Nothing


        If info.Text.Length <= 0 Then
            Return
        End If
        Do
            If Not info.DecrementStartPosition() Then
                Return
            End If

            If IsSeparator(info.Text(0)) Then
                Return
            End If

            If info.Text(0) = "%"c Then
                Dim replaceString As String = AutoCorrectOptions(info.Text)
                If Not String.IsNullOrEmpty(replaceString) Then
                    info.ReplaceWith = replaceString
                    e.AutoCorrectInfo = info
                End If
                Return
            End If
        Loop

    End Sub

    Private Shared Function AutoCorrectOptions(ByVal name As String) As String
        name = name.ToLower()

        If name.Length >= 2 AndAlso name.Chars(0) = "%"c Then 'AndAlso name.EndsWith("%") Then
            Dim value As Integer = Nothing
            If Integer.TryParse(name.Substring(1, name.Length - 2), value) Then
                Dim converter As OrdinalBasedNumberConverter = OrdinalBasedNumberConverter.CreateConverter(DevExpress.Office.NumberConverters.NumberingFormat.CardinalText, LanguageId.English)
                Return converter.ConvertNumber(value)
            End If
        End If

        Select Case name
            Case "%c"
                Return "Consultant "
            Case "%h"
                Return "Hospital "
            Case "%s"
                Return "Secretary "
            Case "%o"
                Return "OutPatient Dept "
            Case "%d"
                Return Date.Now.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern) & " "
            Case "%t"
                Return Date.Now.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern) & " "
            Case Else
                Return String.Empty
        End Select
    End Function
    Private Shared Function IsSeparator(ByVal ch As Char) As Boolean
        Return ch <> "%"c AndAlso (ch = ControlChars.Cr OrElse ch = ControlChars.Lf OrElse Char.IsPunctuation(ch) OrElse Char.IsSeparator(ch) OrElse Char.IsWhiteSpace(ch))
    End Function
End Class
