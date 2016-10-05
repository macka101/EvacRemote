Imports EvacRemote.GlobalVariables
Imports DevExpress.XtraRichEdit
Imports Esso.Data


Public Class ProductDetail
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
    Private Sub InitEditors()
        RichTextControlHelper.PlainSetup(rtcFullDetails, False)
    End Sub
    Public Sub Initdata()
        InitEditors()

        'InitializeRichEditControl()
        ''        RichEditControl1.Document.Replace(uploads/image/products/EC300H.jpg
        ''        If _product.features IsNot String.Empty Then
        ''EvacRemote.ListActions.CreateBulletedList(RichEditControl1.Document, _product.features)
        ''       End If
        ''
        'RichEditControl1.Document.GetHtmlText(RichEditControl1.Document.Range, )
        'Dim objReader As New System.IO.StreamReader("Test.html")
        'WebBrowser1.DocumentText = objReader.ReadToEnd
        teProductCode.Text = _product.ProductCode
        teDescription.Text = _product.Description
        rtcFullDetails.RtfText = _product.Datasheet
    End Sub

    Public Sub New(ByRef Product As Product)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _product = Product
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click

    End Sub
End Class
