Imports System.Data.Odbc
Imports EvacRemote.GlobalVariables
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Public Class frmMain

    Dim _Contacts As CustomerList
    Dim _ViewContact As viewContactSwipe

    Dim _Basket As BasketList
    Dim _Survey As SurveySwipe
    Dim _Service As ServiceSwipe
    Dim _ViewEscapeRoute As viewEscapeRouteSwipe
    Dim _ViewFloor As viewFloorSwipe
    Dim _ViewServiceChair As viewAssetSwipeChair
    Dim _ViewServiceIbex As viewAssetSwipeIbex

    Dim _Products As ProductListSwipe
    Dim _ViewProductWeb As viewProductSwipeWeb
    Dim _ViewProductRTF As viewProductSwipeRTF
    Dim _ViewProductWin As viewProductSwipeWin

    Dim _Tasks As TaskListSwipe
    Dim _Schedule As ScheduleListSwipe

    Public dataSession As UnitOfWork = Nothing

    Private Sub tasksTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tasksTileBarItem.ItemClick
        If _Tasks Is Nothing Then
            _Tasks = New TaskListSwipe(Me)
        End If
        If Not _Basket Is Nothing Then
            _Basket.Visible = False
        End If
        If Not _Survey Is Nothing Then
            _Survey.Visible = False
        End If
        If Not _Contacts Is Nothing Then
            _Contacts.Visible = False
        End If
        If Not _Products Is Nothing Then
            _Products.Visible = False
        End If
        If Not _Schedule Is Nothing Then
            _Schedule.Visible = False
        End If
        _Tasks.Parent = Me.MainPnl
        _Tasks.Dock = DockStyle.Fill
        If _Tasks.Loaded = False Then
            _Tasks.InitData()
        End If
        _Tasks.Visible = True
    End Sub

    Private Sub dashboardTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles dashboardTileBarItem.ItemClick
        Using frmsysnc As New FrmSyncronize
            frmsysnc.ShowDialog()
        End Using
    End Sub
    Public Sub BasketEnabled(bEnabled As Boolean)
        basketTileBarItem.Enabled = bEnabled
        basketTileBarItem.Visible = bEnabled
    End Sub
    Public Sub SurveyEnabled(bEnabled As Boolean)
        surveyTileBarItem.Enabled = bEnabled
        surveyTileBarItem.Visible = bEnabled
    End Sub
    Public Sub ServiceEnabled(bEnabled As Boolean)
        ServiceTileBarItem.Enabled = bEnabled
        ServiceTileBarItem.Visible = bEnabled
    End Sub

    Private Sub productsTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles productsTileBarItem.ItemClick
        If _Products Is Nothing Then
            _Products = New ProductListSwipe(Me)
        End If
        _Products.Parent = Me.MainPnl
        _Products.Dock = DockStyle.Fill
        If _Products.Loaded = False Then
            _Products.InitData()
        End If
        If Not _Survey Is Nothing Then
            _Survey.Visible = False
        End If

        If Not _Basket Is Nothing Then
            _Basket.Visible = False
        End If
        If Not _Contacts Is Nothing Then
            _Contacts.Visible = False
        End If
        If Not _Tasks Is Nothing Then
            _Tasks.Visible = False
        End If
        If Not _Schedule Is Nothing Then
            _Schedule.Visible = False
        End If
        _Products.Visible = True
    End Sub
    Public Sub ViewContact(Preference As String)
        If _ViewContact Is Nothing Then
            _ViewContact = New viewContactSwipe(Me)
        End If

        _ViewContact.Parent = Me.MainPnl
        _ViewContact.Dock = DockStyle.Fill
        _ViewContact.Initdata()
        _Contacts.Visible = False
        _ViewContact.Visible = True
    End Sub
    Public Sub HideContact()
        _ViewProductWeb.Visible = False
        _Products.Visible = True
    End Sub
    Public Sub ViewProductRTF(ByRef oRow As Product)
        If _ViewProductRTF Is Nothing Then
            _ViewProductRTF = New viewProductSwipeRTF(Me, oRow)
        End If

        _ViewProductRTF.Parent = Me.MainPnl
        _ViewProductRTF.Dock = DockStyle.Fill
        _ViewProductRTF.Initdata()
        _Products.Visible = False
        _ViewProductRTF.Visible = True
    End Sub
    Public Sub ViewProductWeb(ByRef oRow As Product)
        If _ViewProductWeb Is Nothing Then
            _ViewProductWeb = New viewProductSwipeWeb(Me, oRow)
        End If

        _ViewProductWeb.Parent = Me.MainPnl
        _ViewProductWeb.Dock = DockStyle.Fill
        _ViewProductWeb.Initdata()
        _Products.Visible = False
        _ViewProductWeb.Visible = True
    End Sub
    Public Sub ViewProductWin(ByRef oRow As Product)
        If _ViewProductWin Is Nothing Then
            _ViewProductWin = New viewProductSwipeWin(Me, oRow)
        End If

        _ViewProductWin.Parent = Me.MainPnl
        _ViewProductWin.Dock = DockStyle.Fill
        _ViewProductWin.Initdata()
        _Products.Visible = False
        _ViewProductWin.Visible = True
    End Sub
    Public Sub HideProduct()
        If _ViewProductWeb IsNot Nothing Then
            _ViewProductWeb.Visible = False
        End If
        If _ViewProductRTF IsNot Nothing Then
            _ViewProductRTF.Visible = False
        End If
        If _ViewProductWin IsNot Nothing Then
            _ViewProductWin.Visible = False
        End If

        _Products.Visible = True
    End Sub
    Public Sub ViewEscapeRoute(ByRef pForm As SurveySwipe, ByRef pEscapeRoute As EscapeRoute)
        If _ViewEscapeRoute Is Nothing Then
            _ViewEscapeRoute = New viewEscapeRouteSwipe(Me, pForm, pEscapeRoute)
        End If

        _ViewEscapeRoute.Parent = Me.MainPnl
        _ViewEscapeRoute.Dock = DockStyle.Fill
        _ViewEscapeRoute.Initdata()
        _Survey.Visible = False
        _ViewEscapeRoute.Visible = True
    End Sub
    Public Sub HideStairCase()
        _ViewEscapeRoute.Visible = False
        _Survey.Visible = True
    End Sub
    Public Sub ViewFloor(ByRef pForm As viewEscapeRouteSwipe, ByRef pFloor As Floor)
        If _ViewFloor Is Nothing Then
            _ViewFloor = New viewFloorSwipe(Me, pForm, pFloor)
        End If

        _ViewFloor.Parent = Me.MainPnl
        _ViewFloor.Dock = DockStyle.Fill
        _ViewFloor.Initdata()
        pForm.Visible = False
        _ViewFloor.Visible = True
    End Sub
    Public Sub HideFloor()
        _ViewFloor.Visible = False
        _ViewEscapeRoute.Visible = True
    End Sub
    Public Sub ViewServiceChair(pForm As ServiceSwipe, pAsset As Asset)
        If _ViewServiceChair Is Nothing Then
            _ViewServiceChair = New viewAssetSwipeChair(dataSession, Me, pForm, pAsset)
        End If

        _ViewServiceChair.Parent = Me.MainPnl
        _ViewServiceChair.Dock = DockStyle.Fill
        _ViewServiceChair.Initdata()
        _Service.Visible = False
        _ViewServiceChair.Visible = True
    End Sub
    Public Sub ViewServiceIbex(pForm As ServiceSwipe, pAsset As Asset)
        If _ViewServiceIbex Is Nothing Then
            _ViewServiceIbex = New viewAssetSwipeIbex(Me, pForm, pAsset)
        End If

        _ViewServiceIbex.Parent = Me.MainPnl
        _ViewServiceIbex.Dock = DockStyle.Fill
        _ViewServiceIbex.Initdata()
        _Service.Visible = False
        _ViewServiceIbex.Visible = True
    End Sub
    Public Sub HideServiceChair()
        _ViewServiceChair.Visible = False
        _Service.Visible = True
    End Sub
    Public Sub HideServiceIbex()
        _ViewServiceIbex.Visible = False
        _Service.Visible = True
    End Sub
    Private Sub customersTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles customersTileBarItem.ItemClick
        If _Contacts Is Nothing Then
            _Contacts = New CustomerList(dataSession, Me)
        End If

        _Contacts.Parent = Me.MainPnl
        _Contacts.Dock = DockStyle.Fill
        If _Contacts.Loaded = False Then
            _Contacts.InitData()
        End If
        If Not _Survey Is Nothing Then
            _Survey.Visible = False
        End If

        If Not _Basket Is Nothing Then
            _Basket.Visible = False
        End If
        If Not _Products Is Nothing Then
            _Products.Visible = False
        End If
        If Not _Tasks Is Nothing Then
            _Tasks.Visible = False
        End If
        If Not _Schedule Is Nothing Then
            _Schedule.Visible = False
        End If
        _Contacts.Visible = True
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Debugger.IsAttached = False Then
            tbiSnapReports.Visible = False
            tbiEmailTemplates.Visible = False
        End If

        OpenConnection()
        currentADUser = System.DirectoryServices.AccountManagement.UserPrincipal.Current
        Dim domainAndUserName As String = Environment.UserDomainName & "\" & Environment.UserName


        dataSession = New UnitOfWork(XpoDefault.DataLayer)
        Dim sSql As String = String.Format(" SELECT usercode FROM user_intlogin where winusername = '{0}' ", domainAndUserName)
        '_UserCode = dataSession.ExecuteScalar(sSql)
        If _UserCode Is Nothing Or Debugger.IsAttached Then
            _UserCode = "MH"
        End If
        SupportFilesDirectory = FindsSupportDirectory()
        ConnectionHelper.CheckForInitialRecords(dataSession)
        BasketEnabled(False)
        SurveyEnabled(False)
        ServiceEnabled(False)
    End Sub


    Private Sub scheduleTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles scheduleTileBarItem.ItemClick
        If _Schedule Is Nothing Then
            _Schedule = New ScheduleListSwipe(Me)
        End If

        _Schedule.Parent = Me.MainPnl
        _Schedule.Dock = DockStyle.Fill
        If _Schedule.Loaded = False Then
            _Schedule.InitData()
        End If
        If Not _Survey Is Nothing Then
            _Survey.Visible = False
        End If

        If Not _Basket Is Nothing Then
            _Basket.Visible = False
        End If
        If Not _Products Is Nothing Then
            _Products.Visible = False
        End If
        If Not _Tasks Is Nothing Then
            _Tasks.Visible = False
        End If
        If Not _Contacts Is Nothing Then
            _Contacts.Visible = False
        End If
        _Schedule.Visible = True
    End Sub

    Private Sub mainTileBar_Click(sender As Object, e As EventArgs) Handles mainTileBar.Click
        Dim x = 1
    End Sub

    Private Sub basketTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles basketTileBarItem.ItemClick
        If _Basket Is Nothing Then
            _Basket = New BasketList(Me)
        End If

        _Basket.Parent = Me.MainPnl
        _Basket.Dock = DockStyle.Fill
        _Basket.InitData()
        If Not _Survey Is Nothing Then
            _Survey.Visible = False
        End If
        If Not _Schedule Is Nothing Then
            _Schedule.Visible = False
        End If
        If Not _Products Is Nothing Then
            _Products.Visible = False
        End If
        If Not _Tasks Is Nothing Then
            _Tasks.Visible = False
        End If
        If Not _Contacts Is Nothing Then
            _Contacts.Visible = False
        End If
        _Basket.Visible = True
    End Sub

    Private Sub surveyTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles surveyTileBarItem.ItemClick
        If _Survey Is Nothing Then
            _Survey = New SurveySwipe(Me, dataSession)
        End If

        _Survey.Parent = Me.MainPnl
        _Survey.Dock = DockStyle.Fill
        If _Survey.Loaded = False Then
            _Survey.Initdata()
        End If
        If Not _Basket Is Nothing Then
            _Basket.Visible = False
        End If
        If Not _Schedule Is Nothing Then
            _Schedule.Visible = False
        End If
        If Not _Products Is Nothing Then
            _Products.Visible = False
        End If
        If Not _Tasks Is Nothing Then
            _Tasks.Visible = False
        End If
        If Not _Contacts Is Nothing Then
            _Contacts.Visible = False
        End If
        _Survey.Visible = True
    End Sub

    Private Sub ServiceTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles ServiceTileBarItem.ItemClick
        If _Service Is Nothing Then
            _Service = New ServiceSwipe(Me, dataSession)
        End If

        _Service.Parent = Me.MainPnl
        _Service.Dock = DockStyle.Fill
        If _Service.Loaded = False Then
            _Service.Initdata()
        End If
        If Not _Basket Is Nothing Then
            _Basket.Visible = False
        End If
        If Not _Schedule Is Nothing Then
            _Schedule.Visible = False
        End If
        If Not _Products Is Nothing Then
            _Products.Visible = False
        End If
        If Not _Tasks Is Nothing Then
            _Tasks.Visible = False
        End If
        If Not _Contacts Is Nothing Then
            _Contacts.Visible = False
        End If
        If Not _Survey Is Nothing Then
            _Survey.Visible = False
        End If
        _Service.Visible = True
    End Sub

    Private Sub tbiSnapReports_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tbiSnapReports.ItemClick
        Using fSnap As New frmSnapDesigner()
            fSnap.ShowDialog()
        End Using

    End Sub

    Private Sub tbiEmailTemplates_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tbiEmailTemplates.ItemClick
        Using frmEmail As New frmEmailTemplates(dataSession)
            frmEmail.ShowDialog()
        End Using
    End Sub

End Class