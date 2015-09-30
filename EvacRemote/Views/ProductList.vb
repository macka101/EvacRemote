Imports System.Data.Odbc
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo

Public Class ProductList
    Private _Loaded As Boolean = False
    Private _Category As String = "Evac"
    Dim dsProducts As New DataSet
    Private _parent As frmMain = Nothing
    Public ReadOnly Property Loaded As Boolean
        Get
            Return _Loaded
        End Get
    End Property
    Public ReadOnly Property CurrentCategoryLong As String
        Get
            Select Case CurrentCategory
                Case "Evac"
                    Return "Evacuation Chairs"
                Case "Accs"
                    Return "Accessories"
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
        FetchData("Evac")
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
        Dim xpc As New XPCollection(Of vw_Products)(session, filter, New SortProperty("id", DevExpress.Xpo.DB.SortingDirection.Ascending))

        dsProducts.Clear()
        CurrentCategory = pCategory
        Dim str As String = "SELECT proditem.prodref, proditem.proddesc, proditem.prodsell, proditem.memo FROM proditem"
        str = str + String.Format(" where proditem.webcatalog = 1 and proditem.prodcateg = '{0}'", CurrentCategory)
        Dim da As New OdbcDataAdapter(str, cn)
        da.Fill(dsProducts, "Products")
        GridControl1.DataSource = dsProducts.Tables(0)
        GridView1.Columns(0).Caption = "Reference"
        GridView1.Columns(1).Caption = "Description"
        GridView1.Columns(2).Caption = "Price"

        SIProducts.Text = String.Format("PRODUCT <color=47, 81, 165>{0}", CurrentCategoryLong)
    End Sub

    Private Sub tileAccessories_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tileAccessories.ItemClick
        FetchData("ACCS")
    End Sub

    Private Sub tileEvacuationChairs_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tileEvacuationChairs.ItemClick
        FetchData("Evac")
    End Sub

    Public Sub New(ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        '  ParentFormMain.ViewProduct("300")
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If GridControl1.MainView Is LayoutView1 Then
            GridControl1.MainView = GridView1
        Else
            GridControl1.MainView = LayoutView1
        End If
    End Sub




    Private Sub LayoutView1_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles LayoutView1.CustomUnboundColumnData
        Dim ImageDir As String = Application.StartupPath & "\Files\"
        If e.IsGetData Then
            Dim oRow As DataRowView = DirectCast(LayoutView1.DataSource, IList)(e.ListSourceRowIndex)
            Dim prodref As String = oRow.Item(0).ToString.Substring(0, 5)
            Dim view As GridView = TryCast(sender, GridView)
            If e.Column.FieldName = "Image" Then

                ImageDir = ImageDir & "Images\"
                Try
                    If IO.File.Exists(ImageDir & prodref & ".jpg") Then
                        e.Value = Image.FromFile(ImageDir & prodref & ".jpg")
                    Else
                        e.Value = Image.FromFile(ImageDir & "missing.png")
                    End If
                Catch
                    e.Value = Image.FromFile(ImageDir & "missing.png")
                End Try
            ElseIf e.Column.FieldName = "PDF" Then
                ImageDir = ImageDir & "PDF\"
                If IO.File.Exists(ImageDir & prodref & ".pdf") Then
                    riPDF.Buttons.Item(0).Visible = True
                Else
                    riPDF.Buttons.Item(0).Visible = False
                End If
            ElseIf e.Column.FieldName = "VIDEO" Then
                ImageDir = ImageDir & "VIDEO\"
                If IO.File.Exists(ImageDir & prodref & ".avi") Then
                    riVideo.Buttons.Item(0).Visible = True
                Else
                    riVideo.Buttons.Item(0).Visible = False
                End If
            ElseIf e.Column.FieldName = "LARGEIMAGE" Then
                ImageDir = ImageDir & "LARGEIMAGE\"
                If IO.File.Exists(ImageDir & prodref & ".jpg") Then
                    riImage.Buttons.Item(0).Visible = True
                Else
                    riImage.Buttons.Item(0).Visible = False
                End If
            End If
        End If

    End Sub

    Private Sub LayoutView1_CardClick(sender As Object, e As DevExpress.XtraGrid.Views.Layout.Events.CardClickEventArgs) Handles LayoutView1.CardClick
        Dim ImageDir As String = Application.StartupPath & "\Files\"
        Dim hi As LayoutViewHitInfo = sender.CalcHitInfo(e.Location)
        Dim filename As String = ""
        If hi.HitTest = LayoutViewHitTest.FieldCaption Or hi.HitTest = LayoutViewHitTest.FieldValue Then
            Dim oRow As DataRowView = LayoutView1.GetFocusedRow
            filename = oRow.Item(0).ToString.Substring(0, 5)
            If hi.Column.FieldName = "PDF" Then
                filename = "FILES\PDF\" & filename & ".PDF"
            End If
            If hi.Column.FieldName = "LARGEIMAGE" Then
                filename = "FILES\IMAGES\" & filename & ".jpg"
            End If
            If hi.Column.FieldName = "VIDEO" Then
                filename = "FILES\VIDEO\" & filename & ".avi"
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
End Class
Friend Class SwipeEnabledView
    Inherits GridView
    'Protected Overrides Function CheckAllowGestures(ByVal point As System.Drawing.Point) As DevExpress.Utils.Gesture.GestureAllowArgs()
    '    Return base.CheckAllowGestures(point)
    'End Function
    Protected Overrides Sub OnSwipeLeft(ByVal rowHandle As Integer)
        MessageBox.Show("SwipeLeft " + rowHandle.ToString())
    End Sub
    Protected Overrides Sub OnSwipeRight(ByVal rowHandle As Integer)
        MessageBox.Show("SwipeRight " + rowHandle.ToString())
    End Sub
    Protected Overrides ReadOnly Property AllowSwipeLeft() As Boolean
        Get
            Return True
        End Get
    End Property
    Protected Overrides ReadOnly Property AllowSwipeRight() As Boolean
        Get
            Return True
        End Get
    End Property
End Class