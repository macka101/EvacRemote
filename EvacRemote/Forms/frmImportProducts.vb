Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports System.Data
Imports System
Imports System.IO
Imports System.Drawing
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors.Controls
Imports System.Globalization
Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Helpers
Imports DevExpress.XtraSpreadsheet
Imports Esso.Data

Public Class frmImportProducts

    Private iOid As Integer = -1
    Private iType As Integer = -1
    Private iDescription As Integer = -1
    Private iDefault As Integer = -1
    Private iHeritage As Integer = -1
    Private iBedBound As Integer = -1
    Private iPublic As Integer = -1
    Private iBarriatric As Integer = -1
    Private iNarrowStairs As Integer = -1
    Private iSteepStairs As Integer = -1
    Private iSchool As Integer = -1
    Private iCollegeUniversity As Integer = -1
    Private iShallowStairs As Integer = -1
    Private iTightTurning As Integer = -1
    Private iUnevenGround As Integer = -1
    Private iComplexDisability As Integer = -1
    Private iHorizontal As Integer = -1
    Private iSmallStorage As Integer = -1
    Private iBedAccess As Integer = -1
    Private iMisuse As Integer = -1
    Private iUpstairs As Integer = -1
    Private iSpiral As Integer = -1
    Private iPlastic As Integer = -1
    Private iMovingHangling As Integer = -1

    Private ws As Worksheet
    Private iRows As Integer
    Private iCols As Integer

    Dim _Product As Product

    Dim _session As UnitOfWork
    Dim sfilename As String = String.Empty

    Private sourceUri As String
    Private sourceFormat As DocumentFormat


    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        sfilename = GetFileName(fileType.XLSX)
        'now we have a handle on the filepath we can pass it to a dataclass
        If sfilename = Nothing Then
            Exit Sub
        End If

        txtfileName.Text = sfilename
        SpreadsheetControl1.LoadDocument(sfilename)
        FindProductColumns()
        SpreadsheetControl1.Document.Worksheets.ActiveWorksheet = SpreadsheetControl1.Document.Worksheets(0)

    End Sub
    Private Sub FindProductColumns()

        ws = SpreadsheetControl1.Document.Worksheets(0)
        SpreadsheetControl1.Document.Worksheets.ActiveWorksheet = ws
        iRows = ws.Rows.LastUsedIndex
        iCols = ws.Columns.LastUsedIndex

        lblDetails.Text = String.Format("Rows {0}", SpreadsheetControl1.ActiveWorksheet.Rows.LastUsedIndex)

        iOid = -1
        iType = -1
        iDescription = -1
        iDefault = -1
        iHeritage = -1
        iBedBound = -1
        iPublic = -1
        iBarriatric = -1
        iNarrowStairs = -1
        iSteepStairs = -1
        iSchool = -1
        iCollegeUniversity = -1
        iShallowStairs = -1
        iTightTurning = -1
        iUnevenGround = -1
        iComplexDisability = -1
        iHorizontal = -1
        iSmallStorage = -1
        iBedAccess = -1
        iMisuse = -1
        iUpstairs = -1
        iSpiral = -1
        iPlastic = -1
        iMovingHangling = -1

        Dim iFound As Boolean = False
        Dim i As Integer
        'Find Columns
        For i = 0 To iCols
            If ws.Cells(0, i).Value.IsText Then
                iFound = False

                Select Case ws.Cells(0, i).Value.TextValue.ToUpper
                    Case "Part Number".ToUpper
                        iOid = i
                        iFound = True
                    Case "Type".ToUpper
                        iType = i
                        iFound = True
                    Case "Default".ToUpper
                        iDefault = i
                        iFound = True
                    Case "Description".ToUpper
                        iDescription = i
                        iFound = True
                    Case "Heritage ".ToUpper
                        iHeritage = i
                        iFound = True
                    Case "Bed Bound".ToUpper
                        iBedBound = i
                        iFound = True
                    Case "Public".ToUpper
                        iPublic = i
                        iFound = True
                    Case "Barriatric".ToUpper
                        iBarriatric = i
                        iFound = True
                    Case "Narrow Stairs".ToUpper
                        iNarrowStairs = i
                        iFound = True
                    Case "Steep Stairs".ToUpper
                        iSteepStairs = i
                        iFound = True
                    Case "School".ToUpper
                        iSchool = i
                        iFound = True
                    Case "College/University".ToUpper
                        iCollegeUniversity = i
                        iFound = True
                    Case "Shallow Stairs".ToUpper
                        iShallowStairs = i
                        iFound = True
                    Case "Tight turning".ToUpper
                        iTightTurning = i
                        iFound = True
                    Case "Uneven Ground".ToUpper
                        iUnevenGround = i
                        iFound = True
                    Case "Complex Disability".ToUpper
                        iComplexDisability = i
                        iFound = True
                    Case "Horizontal".ToUpper
                        iHorizontal = i
                        iFound = True
                    Case "Small Storage".ToUpper
                        iSmallStorage = i
                        iFound = True
                    Case "Bed Access".ToUpper
                        iBedAccess = i
                        iFound = True
                    Case "Mis-use".ToUpper
                        iMisuse = i
                        iFound = True
                    Case "Upstairs".ToUpper
                        iUpstairs = i
                        iFound = True
                    Case "Spiral".ToUpper
                        iSpiral = i
                        iFound = True
                    Case "Plastic".ToUpper
                        iPlastic = i
                        iFound = True
                    Case "Moving and Handling".ToUpper
                        iMovingHangling = i
                        iFound = True

                End Select
            End If
            If iFound = True Then
                ws.Cells(0, i).Font.Color = Color.LightGreen
            Else
                ws.Cells(0, i).Font.Color = Color.Red
            End If
        Next
        If iType = -1 Or iOid = -1 Then
            XtraMessageBox.Show("Cannot Find Required Columns ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

    End Sub
    Private Sub btnImport_Click(sender As System.Object, e As System.EventArgs) Handles btnImport.Click
        Import()
    End Sub
    Private Sub Import()
        If XtraMessageBox.Show("Begin Import", "Import", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If
        UpdateAddProducts()
    End Sub
    Private Sub UpdateAddProducts()
        Dim sCode As String = ""
        Dim sType As String = ""
        Dim i As Integer = 0

        pg_Progress.Properties.Maximum = ws.Rows.LastUsedIndex
        pg_Progress.Properties.Step = 1
        ws.ScrollTo(0, 0)
        For i = 1 To ws.Rows.LastUsedIndex
            If i > 10 Then
                ws.ScrollToRow(i - 9)
            End If
            Dim _code As String = ws.Cells(i, iOid).Value.TextValue
            If _code = String.Empty Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Empty Row Found Stopping Import")
                Exit For
            End If

            _Product = _session.FindObject(Of Product)(CriteriaOperator.Parse("ProductCode = ?", _code))
            If _Product Is Nothing Then
                _Product = New Product(_session)
                _Product.ProductCode = _code
            End If


            If iType > 0 Then
                If Not ws.Cells(i, iType).Value.IsEmpty Then
                    If ws.Cells(i, iType).Value.TextValue = "A" Then
                        _Product.accessory = True
                    Else
                        _Product.accessory = False
                    End If
                End If
            End If
            If iDescription > 0 Then
                If Not ws.Cells(i, iDescription).Value.IsEmpty Then
                    _Product.Description = ws.Cells(i, iDescription).Value.TextValue
                End If
            End If
            If iDefault > 0 Then
                If Not ws.Cells(i, iDefault).Value.IsEmpty Then
                    If ws.Cells(i, iDefault).Value.IsNumeric Then
                        _Product.RatingDefault = CInt(ws.Cells(i, iDefault).Value.NumericValue)
                    End If
                End If
            End If

            If iHeritage > 0 Then
                If Not ws.Cells(i, iHeritage).Value.IsEmpty Then
                    If ws.Cells(i, iHeritage).Value.IsNumeric Then
                        _Product.RatingHeritage = CInt(ws.Cells(i, iHeritage).Value.NumericValue)
                    End If
                End If
            End If

            If iBedBound > 0 Then
                If Not ws.Cells(i, iBedBound).Value.IsEmpty Then
                    If ws.Cells(i, iBedBound).Value.IsNumeric Then
                        _Product.RatingBedBound = CInt(ws.Cells(i, iBedBound).Value.NumericValue)
                    End If
                End If
            End If

            If iPublic > 0 Then
                If Not ws.Cells(i, iPublic).Value.IsEmpty Then
                    If ws.Cells(i, iPublic).Value.IsNumeric Then
                        _Product.RatingPublic = CInt(ws.Cells(i, iPublic).Value.NumericValue)
                    End If
                End If
            End If

            If iBarriatric > 0 Then
                If Not ws.Cells(i, iBarriatric).Value.IsEmpty Then
                    If ws.Cells(i, iBarriatric).Value.IsNumeric Then
                        _Product.RatingBarriatric = CInt(ws.Cells(i, iBarriatric).Value.NumericValue)
                    End If
                End If
            End If

            If iNarrowStairs > 0 Then
                If Not ws.Cells(i, iNarrowStairs).Value.IsEmpty Then
                    If ws.Cells(i, iNarrowStairs).Value.IsNumeric Then
                        _Product.RatingNarrowStairs = CInt(ws.Cells(i, iNarrowStairs).Value.NumericValue)
                    End If
                End If
            End If

            If iSteepStairs > 0 Then
                If Not ws.Cells(i, iSteepStairs).Value.IsEmpty Then
                    If ws.Cells(i, iSteepStairs).Value.IsNumeric Then
                        _Product.RatingSteepStairs = CInt(ws.Cells(i, iSteepStairs).Value.NumericValue)
                    End If
                End If
            End If

            If iSchool > 0 Then
                If Not ws.Cells(i, iSchool).Value.IsEmpty Then
                    If ws.Cells(i, iSchool).Value.IsNumeric Then
                        _Product.RatingSchool = CInt(ws.Cells(i, iSchool).Value.NumericValue)
                    End If
                End If
            End If

            If iCollegeUniversity > 0 Then
                If Not ws.Cells(i, iCollegeUniversity).Value.IsEmpty Then
                    If ws.Cells(i, iCollegeUniversity).Value.IsNumeric Then
                        _Product.RatingCollegeUniversity = CInt(ws.Cells(i, iCollegeUniversity).Value.NumericValue)
                    End If
                End If
            End If

            If iShallowStairs > 0 Then
                If Not ws.Cells(i, iShallowStairs).Value.IsEmpty Then
                    If ws.Cells(i, iShallowStairs).Value.IsNumeric Then
                        _Product.RatingShallowStairs = CInt(ws.Cells(i, iShallowStairs).Value.NumericValue)
                    End If
                End If
            End If

            If iTightTurning > 0 Then
                If Not ws.Cells(i, iTightTurning).Value.IsEmpty Then
                    If ws.Cells(i, iTightTurning).Value.IsNumeric Then
                        _Product.RatingTightTurning = CInt(ws.Cells(i, iTightTurning).Value.NumericValue)
                    End If
                End If
            End If

            If iUnevenGround > 0 Then
                If Not ws.Cells(i, iUnevenGround).Value.IsEmpty Then
                    If ws.Cells(i, iUnevenGround).Value.IsNumeric Then
                        _Product.RatingUnevenGround = CInt(ws.Cells(i, iUnevenGround).Value.NumericValue)
                    End If
                End If
            End If
            If iComplexDisability > 0 Then
                If Not ws.Cells(i, iComplexDisability).Value.IsEmpty Then
                    If ws.Cells(i, iComplexDisability).Value.IsNumeric Then
                        _Product.RatingComplexDisability = CInt(ws.Cells(i, iComplexDisability).Value.NumericValue)
                    End If
                End If
            End If

            If iHorizontal > 0 Then
                If Not ws.Cells(i, iHorizontal).Value.IsEmpty Then
                    If ws.Cells(i, iHorizontal).Value.IsNumeric Then
                        _Product.RatingHorizontal = CInt(ws.Cells(i, iHorizontal).Value.NumericValue)
                    End If
                End If
            End If

            If iSmallStorage > 0 Then
                If Not ws.Cells(i, iSmallStorage).Value.IsEmpty Then
                    If ws.Cells(i, iSmallStorage).Value.IsNumeric Then
                        _Product.RatingSmallStorage = CInt(ws.Cells(i, iSmallStorage).Value.NumericValue)
                    End If
                End If
            End If
            If iBedAccess > 0 Then
                If Not ws.Cells(i, iBedAccess).Value.IsEmpty Then
                    If ws.Cells(i, iBedAccess).Value.IsNumeric Then
                        _Product.RatingBedAccess = CInt(ws.Cells(i, iBedAccess).Value.NumericValue)
                    End If
                End If
            End If

            If iMisuse > 0 Then
                If Not ws.Cells(i, iMisuse).Value.IsEmpty Then
                    If ws.Cells(i, iMisuse).Value.IsNumeric Then
                        _Product.RatingMisuse = CInt(ws.Cells(i, iMisuse).Value.NumericValue)
                    End If
                End If
            End If

            If iUpstairs > 0 Then
                If Not ws.Cells(i, iUpstairs).Value.IsEmpty Then
                    If ws.Cells(i, iUpstairs).Value.IsNumeric Then
                        _Product.RatingUpstairs = CInt(ws.Cells(i, iUpstairs).Value.NumericValue)
                    End If
                End If
            End If

            If iSpiral > 0 Then
                If Not ws.Cells(i, iSpiral).Value.IsEmpty Then
                    If ws.Cells(i, iSpiral).Value.IsNumeric Then
                        _Product.RatingSpiral = CInt(ws.Cells(i, iSpiral).Value.NumericValue)
                    End If
                End If
            End If

            If iPlastic > 0 Then
                If Not ws.Cells(i, iPlastic).Value.IsEmpty Then
                    If ws.Cells(i, iPlastic).Value.IsNumeric Then
                        _Product.RatingPlastic = CInt(ws.Cells(i, iPlastic).Value.NumericValue)
                    End If
                End If
            End If
            If iMovingHangling > 0 Then
                If Not ws.Cells(i, iMovingHangling).Value.IsEmpty Then
                    If ws.Cells(i, iMovingHangling).Value.IsNumeric Then
                        _Product.RatingMovingHangling = CInt(ws.Cells(i, iMovingHangling).Value.NumericValue)
                    End If
                End If
            End If
            _Product.Save()
            _session.CommitChanges()
            pg_Progress.PerformStep()
            pg_Progress.Refresh()
        Next
        ws.ScrollToRow(1)
    End Sub

    Private Function GetCellTextValue(cell As Cell, Propercase As Boolean) As String
        Dim ret As String = Nothing
        If Not cell.Value.IsEmpty Then
            If cell.Value.IsNumeric Then
                ret = cell.Value.NumericValue
            Else
                ret = cell.Value.TextValue.Trim
            End If
            If Propercase = True Then
                ret = StrConv(ret, VbStrConv.ProperCase)
            End If
        End If
        Return ret
    End Function

    Public Sub New(ByVal psession As DevExpress.Xpo.UnitOfWork)

        ' This call is required by the designer.
        InitializeComponent()
        _session = psession
        ' Add any initialization after the InitializeComponent() call.
        lblDetails.Text = ""
    End Sub

End Class