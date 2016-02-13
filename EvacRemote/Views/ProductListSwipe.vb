Imports System.Data.Odbc
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Imports EvacRemote.GlobalVariables
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Card
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.Utils

Public Class ProductListSwipe
    Private _Loaded As Boolean = False
    Private _Category As String = "Evac"
    Dim dsProducts As New DataSet
    Dim Session As New UnitOfWork
    Private _parent As frmMain = Nothing
    Public ReadOnly Property Loaded As Boolean
        Get
            Return _Loaded
        End Get
    End Property
    Public ReadOnly Property CurrentCategoryLong As String
        Get
            Select Case CurrentCategory
                Case "CHAIRS"
                    Return "Evacuation Chairs"
                Case "ACCS"
                    Return "Accessories"
                Case "CLIMBERS"
                    Return "Static Climbers"
            End Select
            Return "Other"
        End Get
    End Property
    Public Property CurrentCategory As String
        Get
            Return _Category
        End Get
        Set(value As String)
            _Category = value
        End Set
    End Property
    Public Sub InitData()
        FetchData("CHAIRS")
        colProduct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        colProduct.AppearanceHeader.Font = New Font(colProduct.AppearanceHeader.Font, FontStyle.Bold)
        'LayoutView1.CardOptionsView.ShowCardCaption()
        colProduct.AppearanceHeader.BackColor = Color.Red
        colProduct.AppearanceHeader.BackColor2 = Color.Red
        colProduct.AppearanceHeader.ForeColor = Color.White
        colProduct.AppearanceHeader.Options.UseFont = True
        colProduct.AppearanceHeader.Options.UseTextOptions = True
    End Sub
    Public Property ParentFormMain() As frmMain
        Get
            Return _parent
        End Get
        Set(ByVal value As frmMain)
            If (Not Object.Equals(_parent, Nothing)) Then
                Return
            End If
            _parent = value
        End Set
    End Property
    Private Sub FetchData(pCategory As String)

        Dim filter As CriteriaOperator = Nothing
        Select Case pCategory
            Case "CHAIRS"
                filter = CriteriaOperator.Parse("evacAid =0 and accessory = 0 and stairclimber = 0 and  buildingmanagement=0")
            Case "ACCS"
                filter = CriteriaOperator.Parse("accessory = 1 ")
            Case "ACCS"
                filter = CriteriaOperator.Parse("evacAid = 1 ")
            Case "CLIMBERS"
                filter = CriteriaOperator.Parse("stairclimber = 1 ")
        End Select

        Dim xpc As New XPCollection(Of Product)(Session, filter, New SortProperty("productId", DevExpress.Xpo.DB.SortingDirection.Ascending))

        CurrentCategory = pCategory

        GridControl1.DataSource = xpc

        SIProducts.Text = String.Format("PRODUCT <color=47, 81, 165>{0}", CurrentCategoryLong)
    End Sub

    Private Sub tileAccessories_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tileAccessories.ItemClick
        FetchData("ACCS")
    End Sub

    Private Sub tileEvacuationChairs_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tileEvacuationChairs.ItemClick
        FetchData("CHAIRS")
    End Sub

    Public Sub New(ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        '        ParentFormMain.ViewProduct("300")
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If GridControl1.MainView Is LayoutView1 Then
            GridControl1.MainView = GridView1
        Else
            GridControl1.MainView = LayoutView1
        End If
    End Sub



    Private Sub LayoutView1_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles LayoutView1.CustomUnboundColumnData
        If e.IsGetData Then
            Dim oRow As Product = DirectCast(LayoutView1.DataSource, IList)(e.ListSourceRowIndex)
            Dim prodref As String = oRow.productCode
            Dim imageref As String = oRow.image
            Dim datasheet As String = oRow.datasheet
            Dim view As GridView = TryCast(sender, GridView)
            If e.Column.Tag.ToString = "MEDIUMIMAGE" Then
                Try
                    If IO.File.Exists(SupportFilesDirectory & Misc.MEDIUM_IMAGES_FOLDER & imageref) Then
                        e.Value = Image.FromFile(SupportFilesDirectory & Misc.MEDIUM_IMAGES_FOLDER & imageref)
                    Else
                        e.Value = My.Resources.Missing
                    End If
                Catch
                    e.Value = My.Resources.Missing
                End Try
            ElseIf e.Column.Tag.ToString = "DATASHEET" Then
                If IO.File.Exists(SupportFilesDirectory & Misc.PDF_FOLDER & datasheet) Then
                    e.Value = My.Resources.Acrobat_red_32x32
                Else
                    e.Value = My.Resources.blank_32x32
                End If
            ElseIf e.Column.Tag.ToString = "VIDEO" Then
                If IO.File.Exists(SupportFilesDirectory & Misc.VIDEO_FOLDER & prodref) Then
                    e.Value = My.Resources.Video_32x32
                Else
                    e.Value = My.Resources.blank_32x32
                End If
            ElseIf e.Column.Tag.ToString = "LARGEIMAGE" Then

                If IO.File.Exists(SupportFilesDirectory & Misc.LARGE_IMAGES_FOLDER & imageref) Then
                    e.Value = My.Resources.Picture_32x32
                Else
                    e.Value = My.Resources.blank_32x32
                End If
            ElseIf e.Column.Tag.ToString = "ORDER" Then
                If iCont > 0 Then
                    e.Value = My.Resources.icon_buy_32
                Else
                    e.Value = My.Resources.blank_32x32
                End If

            End If
        End If

    End Sub


    Private Sub GridView1_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData
        If e.IsGetData Then
            Dim oRow As Product = CurrentProduct
            Dim prodref As String = oRow.productCode
            Dim view As GridView = TryCast(sender, GridView)
            If e.Column.Tag.ToString = "SMALLIMAGE" Then
                Try
                    If IO.File.Exists(SupportFilesDirectory & Misc.SMALL_IMAGES_FOLDER & oRow.image) Then
                        e.Value = Image.FromFile(SupportFilesDirectory & Misc.SMALL_IMAGES_FOLDER & oRow.image)
                    Else
                        e.Value = My.Resources.blank_32x32
                    End If
                Catch
                    e.Value = My.Resources.blank_32x32
                End Try
            ElseIf e.Column.Tag.ToString = "PDF" Then
                If IO.File.Exists(SupportFilesDirectory & Misc.PDF_FOLDER & prodref & ".pdf") Then
                    e.Value = My.Resources.Acrobat_red_32x32
                Else
                    e.Value = My.Resources.blank_32x32
                End If
            ElseIf e.Column.Tag.ToString = "VIDEO" Then
                If IO.File.Exists(SupportFilesDirectory & Misc.VIDEO_FOLDER & prodref & ".avi") Then
                    e.Value = My.Resources.Video_32x32
                Else
                    e.Value = My.Resources.blank_32x32
                End If
            ElseIf e.Column.Tag.ToString = "MEDIUMIMAGE" Then
                If IO.File.Exists(SupportFilesDirectory & Misc.MEDIUM_IMAGES_FOLDER & prodref & ".jpg") Then
                    e.Value = My.Resources.Picture_32x32
                Else
                    e.Value = My.Resources.blank_32x32
                End If
            ElseIf e.Column.Tag.ToString = "ORDER" Then
                If iCont > 0 Then
                    e.Value = My.Resources.icon_buy_32
                Else
                    e.Value = My.Resources.blank_32x32
                End If
            End If
        End If
    End Sub


    Private Sub GridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles GridView1.MouseDown
        Dim hi As GridHitInfo = GridView1.CalcHitInfo(New Point(e.X, e.Y))
        Dim filename As String = ""
        If hi.HitTest = GridHitTest.RowCell And e.Button = Windows.Forms.MouseButtons.Left Then
            Dim oRow As Product = CurrentProduct
            If hi.Column.Tag.ToString = "ORDER" Then
                '    Basket.Add(New OrderLine(Basket.Count + 1, oRow.productCode, oRow.description, 1))
            End If
            If hi.Column.Tag.ToString = "PDF" Then
                filename = SupportFilesDirectory & Misc.PDF_FOLDER & oRow.datasheet
            End If
            If hi.Column.Tag.ToString = "LARGEIMAGE" Then
                ParentFormMain.ViewProductRTF(oRow)
                'filename = SupportFilesDirectory & Misc.LARGE_IMAGES_FOLDER & filename & ".jpg"
            End If
            If hi.Column.Tag.ToString = "VIDEO" Then
                filename = SupportFilesDirectory & Misc.VIDEO_FOLDER & filename & ".avi"
            End If

            If IO.File.Exists(filename) Then

                Dim ProcessProperties As New ProcessStartInfo
                ProcessProperties.FileName = filename
                ProcessProperties.WindowStyle = ProcessWindowStyle.Normal

                Using myProcess As Process = New Process
                    Process.Start(ProcessProperties)
                End Using
            End If
        End If
    End Sub

    Private Sub LayoutView1_MouseDown(sender As Object, e As MouseEventArgs) Handles LayoutView1.MouseDown


    End Sub

    Private Sub LayoutView1_MouseUp(sender As Object, e As MouseEventArgs) Handles LayoutView1.MouseUp
        Dim hi As LayoutViewHitInfo = LayoutView1.CalcHitInfo(New Point(e.X, e.Y))
        Dim filename As String = ""
        If hi.HitTest = LayoutViewHitTest.FieldCaption Or hi.HitTest = LayoutViewHitTest.FieldValue And e.Button = Windows.Forms.MouseButtons.Left Then
            Dim oRow As Product = CurrentProduct
            If oRow IsNot Nothing Then
                If hi.Column.Tag.ToString = "ORDER" Then
                    '  ThisBasket.AddItem(oRow.productId, 1)
                End If
                If hi.Column.Tag.ToString = "DATASHEET" Then
                    filename = SupportFilesDirectory & Misc.PDF_FOLDER & oRow.datasheet
                End If
                If hi.Column.Tag.ToString = "LARGEIMAGE" Then
                    filename = SupportFilesDirectory & Misc.LARGE_IMAGES_FOLDER & oRow.image
                End If
                If hi.Column.Tag.ToString = "MEDIUMIMAGE" Then
                    If e.Button = Windows.Forms.MouseButtons.Left Then
                        ParentFormMain.ViewProductRTF(oRow)
                    ElseIf e.Button = Windows.Forms.MouseButtons.Middle Then
                        ParentFormMain.ViewProductWeb(oRow)
                    Else

                        ParentFormMain.ViewProductWeb(oRow)
                    End If
                    filename = "" ' SupportFilesDirectory & Misc.MEDIUM_IMAGES_FOLDER & oRow.image
                End If
                If hi.Column.Tag.ToString = "VIDEO" Then
                    filename = SupportFilesDirectory & Misc.VIDEO_FOLDER & filename & ".avi"
                End If
                If IO.File.Exists(filename) Then

                    Dim ProcessProperties As New ProcessStartInfo
                    ProcessProperties.FileName = filename
                    ProcessProperties.WindowStyle = ProcessWindowStyle.Normal

                    Using myProcess As Process = New Process
                        Process.Start(ProcessProperties)
                    End Using
                End If
            End If
        End If
    End Sub

    Private Sub tilStairClimbers_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tilStairClimbers.ItemClick
        FetchData("CLIMBERS")
    End Sub
    Protected ReadOnly Property CurrentView() As ColumnView
        Get
            Return TryCast(GridControl1.MainView, ColumnView)
        End Get
    End Property
    Private ReadOnly Property CurrentProduct() As Product
        Get
            If Object.Equals(CurrentView, Nothing) OrElse CurrentView.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            Return TryCast(CurrentView.GetRow(CurrentView.FocusedRowHandle), Product)
        End Get
    End Property

    Private Sub LayoutView1_CustomDrawCardCaption(sender As Object, e As DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomDrawCardCaptionEventArgs) Handles LayoutView1.CustomDrawCardCaption
        'Dim info As Product = TryCast(LayoutView1.GetRow(e.RowHandle), Product)
        'e.CardCaption = info.productCode
        'e.Handled = False

    End Sub


    Private Sub LayoutView1_CustomDrawCardFieldCaption(sender As Object, e As RowCellCustomDrawEventArgs) Handles LayoutView1.CustomDrawCardFieldCaption
        'If e.Column.VisibleIndex < 3 And e.Column.VisibleIndex > 0 Then
        '    Dim view As CardView = CType(sender, CardView)
        '    Dim isFocused As Boolean = e.RowHandle = view.FocusedRowHandle
        '    ' A brush to draw the background of the card caption.
        '    Dim backBrush As Brush
        '    If isFocused Then
        '        backBrush = e.Cache.GetGradientBrush(e.Bounds, Color.LavenderBlush, Color.Navy, _
        '          Drawing2D.LinearGradientMode.Vertical)
        '    Else
        '        backBrush = e.Cache.GetGradientBrush(e.Bounds, Color.Cornsilk, Color.DarkKhaki, _
        '          Drawing2D.LinearGradientMode.Vertical)
        '    End If
        '    ' A brush to draw the text.
        '    Dim foreBrush = IIf(isFocused, Brushes.White, Brushes.Chocolate)
        '    Dim r As Rectangle = e.Bounds
        '    ' Draw a 3D border.
        '    ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner)
        '    r.Inflate(-1, -1)
        '    ' Fill the background.
        '    e.Graphics.FillRectangle(backBrush, r)
        '    r.Inflate(-2, 0)
        '    ' Draw the text.
        '    e.Appearance.DrawString(e.Cache, view.GetCardCaption(e.RowHandle), r, foreBrush)
        '    ' Default painting is not required.
        '    e.Handled = True

        'End If
    End Sub


    Private Sub ToolTipController1_GetActiveObjectInfo(sender As Object, e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles ToolTipController1.GetActiveObjectInfo
        Dim info As ToolTipControlInfo = Nothing
        'If e.SelectedControl Is GridControl1 Then
        '    Return
        'End If
        Dim view As LayoutView = TryCast(GridControl1.GetViewAt(e.ControlMousePosition), LayoutView)
        Dim hi As LayoutViewHitInfo = view.CalcHitInfo(e.ControlMousePosition)
        If hi.InFieldValue Then
            Dim o As Object = hi.HitTest.ToString() + hi.HitField.ToString()
            Dim text As String = String.Format("Size is Width {0} Height {0}", hi.HitField.Bounds.Width, hi.HitField.Bounds.Width)
            info = New ToolTipControlInfo(o, text)
        End If
        e.Info = info


        'GridView view = gridControl1.GetViewAt(e.ControlMousePosition) as GridView;
        'GridHitInfo info = view.CalcHitInfo(e.ControlMousePosition);
        'if (!info.InRowCell) return;
        '//if (info.Column== this.gridColumnCollege) //Alway return false
        'if (info.Column.VisibleIndex == this.gridColumnCollege.VisibleIndex)
        '{
        '  string text = "ToolTip - " + view.GetRowCellDisplayText(info.RowHandle, info.Column);
        '  string cellKey = info.RowHandle.ToString() + " - " + info.Column.ToString();
        '  e.Info = new DevExpress.Utils.ToolTipControlInfo(cellKey, text);
        '}
    End Sub


    Private Sub WEBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WEBToolStripMenuItem.Click
        Dim oRow As Product = CurrentProduct
        ParentFormMain.ViewProductWeb(oRow)

    End Sub

    Private Sub WinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WinToolStripMenuItem.Click
        Dim oRow As Product = CurrentProduct
        ParentFormMain.ViewProductWin(oRow)

    End Sub

    Private Sub RTFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RTFToolStripMenuItem.Click
        Dim oRow As Product = CurrentProduct
        ParentFormMain.ViewProductRTF(oRow)
    End Sub
End Class
