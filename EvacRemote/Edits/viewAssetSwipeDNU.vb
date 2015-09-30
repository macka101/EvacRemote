Imports DevExpress.Xpo

Public Class viewAssetSwipeDNU
    Private _parent As frmMain = Nothing
    Private _viewServiceSwipe As ServiceSwipe = Nothing
    Private _Asset As Asset
    Private _session As UnitOfWork
    Public Property ParentMain() As frmMain
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
    Public Property ParentService() As ServiceSwipe
        Get
            Return _viewServiceSwipe
        End Get
        Set(ByVal value As ServiceSwipe)
            If (Not Object.Equals(_viewServiceSwipe, Nothing)) Then
                Return
            End If
            _viewServiceSwipe = value
        End Set
    End Property
    Public Sub Initdata()

    End Sub

    Public Sub New(ByVal parent As frmMain, ByRef pForm As ServiceSwipe, ByRef pAsset As Asset)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _viewServiceSwipe = pForm

        If pAsset Is Nothing Then
            pAsset = New Asset(_session)
        Else

        End If
        _Asset = pAsset
        ' Add any initialization after the InitializeComponent() call.
        teDescription.Text = _Asset.Product
        cbeBuilding.EditValue = _Asset.Building
        cbeLocation.EditValue = _Asset.Division
        teNotes.Text = _Asset.Notes
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click

        _Asset.Product = teDescription.Text
        _Asset.Building = cbeBuilding.EditValue
        _Asset.Division = cbeLocation.EditValue
        Dim x = tsTbar.EditValue

        _Asset.Notes = teNotes.Text
        _Asset.Save()
        _Asset.Session.CommitTransaction()
        ParentService.RefreshAsset()
        ParentMain.HideServiceIbex()
    End Sub
End Class
