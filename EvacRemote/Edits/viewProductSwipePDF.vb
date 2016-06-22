Imports EvacRemote.GlobalVariables
Imports Esso.Data


Public Class viewProductSwipePDF
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
        If Not _product.datasheet Is Nothing Then
            PdfViewer1.LoadDocument(SupportFilesDirectory & Misc.PDF_FOLDER & _product.datasheet)
            PdfViewer1.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel
        Else
            PdfViewer1.Visible = False
        End If
        '  peImage.Image = Image.FromFile("Evac-Chair-300H_thumb_254.jpg")
        ' AxWindowsMediaPlayer1.URL = "split.avi"
        'AxWindowsMediaPlayer1.Ctlcontrols.play()
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
