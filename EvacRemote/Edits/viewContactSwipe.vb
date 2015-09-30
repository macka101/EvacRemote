Imports System.Devices.Geolocation


Public Class viewContactSwipe
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


    End Sub

    Public Sub New(ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        ParentFormMain.HideContact()
    End Sub

    Private Sub pciCurrent_Click(sender As Object, e As EventArgs) Handles pciCurrent.Click
        'set as Current

    End Sub
End Class
