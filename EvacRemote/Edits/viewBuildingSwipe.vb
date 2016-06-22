Imports Esso.Data

Public Class viewBuildingSwipe
    Private _parent As frmMain = Nothing
    Private _building As Building
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

        teReference.Text = _building.Location
        meDetails.Text = _building.Details
    End Sub

    Public Sub New(ByVal parent As frmMain, pBuilding As Building)

        ' This call is required by the designer.
        InitializeComponent()
        _building = pBuilding
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        _building.Save()

    End Sub
End Class
