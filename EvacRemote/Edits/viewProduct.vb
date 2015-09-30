
Public Class viewProduct
    Private _parent As frmMain = Nothing

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
        PdfViewer1.LoadDocument(".\Files\PDF\1-300.pdf")
        PdfViewer1.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
        '  peImage.Image = Image.FromFile("Evac-Chair-300H_thumb_254.jpg")
        ' AxWindowsMediaPlayer1.URL = "split.avi"
        'AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Public Sub New(ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        ParentFormMain.HideProduct()
    End Sub
End Class
