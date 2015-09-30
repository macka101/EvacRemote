Imports EvacRemote.GlobalVariables
Imports DevExpress.XtraRichEdit


Public Class viewProductSwipeRTF
    Private _parent As frmMain = Nothing
    Private _product As Product = Nothing
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

    Public Sub Initdata()
        'InitializeRichEditControl()
        RichEditControl1.Options.Export.Html.CssPropertiesExportType = Export.Html.CssPropertiesExportType.Link
        RichEditControl1.Document.LoadDocument("Test.html", DocumentFormat.Html)
        ''        RichEditControl1.Document.Replace(uploads/image/products/EC300H.jpg
        ''        If _product.features IsNot String.Empty Then
        ''EvacRemote.ListActions.CreateBulletedList(RichEditControl1.Document, _product.features)
        ''       End If
        ''
        'RichEditControl1.Document.GetHtmlText(RichEditControl1.Document.Range, )
        'Dim objReader As New System.IO.StreamReader("Test.html")
        'WebBrowser1.DocumentText = objReader.ReadToEnd

    End Sub

    Private Sub InitializeRichEditControl()
        RichEditControl1.Options.Comments.Visibility = RichEditCommentVisibility.Visible
        RichEditControl1.Options.Comments.ShowAllAuthors = True
    End Sub
    Public Sub New(ByVal parent As frmMain, ByRef oRow As Product)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _product = oRow
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        ParentFormMain.HideProduct()
    End Sub
End Class
