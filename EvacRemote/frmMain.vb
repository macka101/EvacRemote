Imports System.Data.Odbc
Imports EvacRemote.GlobalVariables
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports Esso.Data
Imports DevExpress.XtraEditors

Public Class frmMain

    Dim _DiarySchedule As ViewDiarySchedule
    Dim _ContactList As ViewContactList
    Dim _ContactDetail As ContactDetail

    Dim _ProductList As ViewProductList
    Dim _ProductDetail As ProductDetail

    Dim _Basket As ViewBasketList

    Dim _SurveyList As ViewSurveyList
    Dim _SurveyDetail As SurveyDetail
    Dim _EscapeRoute As viewEscapeRoute
    Dim _FloorDetail As viewFloor

    Dim _ServiceList As ViewServiceList
    Dim _ServiceDetail As ServiceDetail
    Dim _AssetServiceChair As AssetServiceChair

    Dim _ViewEscapeRoute As viewEscapeRoute
    Dim _ViewFloor As viewFloor
    '    Dim _ViewServiceChair As AssetServiceChair
    Dim _ViewServiceIbex As viewAssetSwipeIbex

    Dim _ViewProductWeb As viewProductSwipeWeb
    Dim _ViewProductRTF As viewProductSwipeRTF

    Dim _Tasks As TaskListSwipe

    Public dataSession As UnitOfWork = Nothing


    Public Enum ePage
        None = 0
        ContactList = 1
        ContactDetail = 2
        SurveyList = 3
        SurveyDetail = 4
        FloorDetail = 5
        ProductList = 6
        ProductDetail = 7
        ServiceList = 8
        ServiceDetail = 9
        EscapeRoute = 10
        DiarySchedule = 11
        AssetServiceChair = 12
    End Enum

    Public _CurrentPage As ePage = ePage.None
    Public _PreviousPage As ePage = ePage.None

    Private Sub tasksTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles DiaryTileBarItem.ItemClick
        SelectPage(ePage.DiarySchedule)
    End Sub

    Private Sub dashboardTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles dashboardTileBarItem.ItemClick
        Using frmsysnc As New FrmSyncronize(False, False)
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
        SelectPage(ePage.ProductList)
    End Sub
    Public Sub ViewContactDetail(_contact As Contact)
        If _ContactDetail Is Nothing Then
            _ContactDetail = New ContactDetail(Me)
        End If

        _ContactDetail.Parent = Me.MainPnl
        _ContactDetail.Dock = DockStyle.Fill
        _ContactDetail.Initdata(dataSession, _contact)

        SelectPage(ePage.ContactDetail)
        _ContactList.Visible = False
        _ContactDetail.Visible = True
    End Sub
    Public Sub SelectPage(_page As ePage)
        Select Case _CurrentPage
            Case ePage.ContactList
                _ContactList.Visible = False
            Case ePage.DiarySchedule
                _DiarySchedule.Visible = False
            Case ePage.ContactDetail
                _ContactDetail.Visible = False
            Case ePage.ProductList
                _ProductList.Visible = False
            Case ePage.SurveyList
                _SurveyList.Visible = False
            Case ePage.SurveyDetail
                _SurveyDetail.Visible = False
            Case ePage.ServiceList
                _ServiceList.Visible = False
            Case ePage.ServiceDetail
                _ServiceDetail.Visible = False
            Case ePage.EscapeRoute
                _EscapeRoute.Visible = False
        End Select

        Select Case _page
            Case ePage.ContactList
                If _ContactList Is Nothing Then
                    _ContactList = New ViewContactList(dataSession, Me)
                End If
                _ContactList.Parent = Me.MainPnl
                _ContactList.Dock = DockStyle.Fill

                _ContactList.InitData()

                BasketEnabled(False)
                SurveyEnabled(False)
                ServiceEnabled(False)
                _ContactList.Visible = True
            Case ePage.DiarySchedule
                If _DiarySchedule Is Nothing Then
                    _DiarySchedule = New ViewDiarySchedule(dataSession, Me)
                End If
                _DiarySchedule.Parent = Me.MainPnl
                _DiarySchedule.Dock = DockStyle.Fill

                _DiarySchedule.InitData()

                _DiarySchedule.Visible = True
            Case ePage.ContactDetail
                If _ContactDetail Is Nothing Then
                    _ContactDetail = New ContactDetail(Me)
                End If
                _ContactDetail.Initdata(dataSession, _currentContact)
                _ContactDetail.Parent = Me.MainPnl
                _ContactDetail.Dock = DockStyle.Fill
                _ContactDetail.Visible = True
                BasketEnabled(True)
                SurveyEnabled(True)
                ServiceEnabled(True)
            Case ePage.ProductList
                If _ProductList Is Nothing Then
                    _ProductList = New ViewProductList(dataSession, Me)
                End If
                _ProductList.Parent = Me.MainPnl
                _ProductList.Dock = DockStyle.Fill

                _ProductList.InitData()

                BasketEnabled(False)
                SurveyEnabled(False)
                ServiceEnabled(False)
                _ProductList.Visible = True
            Case ePage.SurveyList
                If _SurveyList Is Nothing Then
                    _SurveyList = New ViewSurveyList(dataSession, Me)
                End If
                _SurveyList.Parent = Me.MainPnl
                _SurveyList.Dock = DockStyle.Fill

                _SurveyList.InitData()

                BasketEnabled(False)
                SurveyEnabled(False)
                ServiceEnabled(False)
                _SurveyList.Visible = True
            Case ePage.SurveyDetail
                If _SurveyDetail Is Nothing Then
                    _SurveyDetail = New SurveyDetail(dataSession, Me)
                End If
                _SurveyDetail.Parent = Me.MainPnl
                _SurveyDetail.Dock = DockStyle.Fill

                _SurveyDetail.Initdata()

                _SurveyDetail.Visible = True
            Case ePage.EscapeRoute
                If _EscapeRoute Is Nothing Then
                    _EscapeRoute = New viewEscapeRoute(dataSession, Me)
                End If
                _EscapeRoute.Parent = Me.MainPnl
                _EscapeRoute.Dock = DockStyle.Fill

                _EscapeRoute.Initdata()

                _EscapeRoute.Visible = True
            Case ePage.FloorDetail
                If _FloorDetail Is Nothing Then
                    _FloorDetail = New viewFloor(dataSession, Me)
                End If
                _FloorDetail.Parent = Me.MainPnl
                _FloorDetail.Dock = DockStyle.Fill

                _FloorDetail.Initdata()

                _FloorDetail.Visible = True

            Case ePage.ServiceList
                If _ServiceList Is Nothing Then
                    _ServiceList = New ViewServiceList(dataSession, Me)
                End If
                _ServiceList.Parent = Me.MainPnl
                _ServiceList.Dock = DockStyle.Fill

                _ServiceList.InitData()

                BasketEnabled(False)
                SurveyEnabled(False)
                ServiceEnabled(False)
                _ServiceList.Visible = True
            Case ePage.ServiceDetail
                If _ServiceDetail Is Nothing Then
                    _ServiceDetail = New ServiceDetail(dataSession, Me)
                End If
                _ServiceDetail.Parent = Me.MainPnl
                _ServiceDetail.Dock = DockStyle.Fill

                _ServiceDetail.Initdata()

                _ServiceDetail.Visible = True
            Case ePage.AssetServiceChair
                If _AssetServiceChair Is Nothing Then
                    _AssetServiceChair = New AssetServiceChair(dataSession, Me)
                End If
                _AssetServiceChair.Parent = Me.MainPnl
                _AssetServiceChair.Dock = DockStyle.Fill

                _AssetServiceChair.Initdata()

                _AssetServiceChair.Visible = True
                'Case ePage.StairWell
                '    If _StairwellDetail Is Nothing Then
                '        _StairwellDetail = New viewStairWellDetail(dataSession, Me)
                '    End If
                '    _StairwellDetail.Parent = Me.MainPnl
                '    _StairwellDetail.Dock = DockStyle.Fill
                '    If _StairwellDetail.Loaded = False Then
                '        _StairwellDetail.Initdata()
                '    End If
                '    _StairwellDetail.Visible = True
        End Select


        _CurrentPage = _page
    End Sub
    Public Sub HideContact()
        _ContactDetail.Visible = False
        _ContactList.Visible = True
        '_Products.Visible = True
    End Sub
    Public Sub ViewProductRTF(ByRef oRow As Product)
        If _ViewProductRTF Is Nothing Then
            _ViewProductRTF = New viewProductSwipeRTF(Me, oRow)
        End If

        _ViewProductRTF.Parent = Me.MainPnl
        _ViewProductRTF.Dock = DockStyle.Fill
        _ViewProductRTF.Initdata()
        _ProductList.Visible = False
        _ViewProductRTF.Visible = True
    End Sub
    Public Sub ViewProductWeb(ByRef oRow As Product)
        If _ViewProductWeb Is Nothing Then
            _ViewProductWeb = New viewProductSwipeWeb(Me, oRow)
        End If

        _ViewProductWeb.Parent = Me.MainPnl
        _ViewProductWeb.Dock = DockStyle.Fill
        _ViewProductWeb.Initdata()
        _ProductList.Visible = False
        _ViewProductWeb.Visible = True
    End Sub
 
    Public Sub HideStairCase()
        _ViewEscapeRoute.Visible = False
        '_Survey.Visible = True
    End Sub


    Public Sub ViewServiceChair(pForm As ViewServiceList, pAsset As Asset)
        'If _ViewServiceChair Is Nothing Then
        '    _ViewServiceChair = New viewAssetSwipeChair(dataSession, Me, pForm, pAsset)
        'End If

        '_ViewServiceChair.Parent = Me.MainPnl
        '_ViewServiceChair.Dock = DockStyle.Fill
        '_ViewServiceChair.Initdata()
        '_Service.Visible = False
        '_ViewServiceChair.Visible = True
    End Sub
    Public Sub ViewServiceIbex(pForm As ViewServiceList, pAsset As Asset)
        'If _ViewServiceIbex Is Nothing Then
        '    _ViewServiceIbex = New viewAssetSwipeIbex(Me, pForm, pAsset)
        'End If

        '_ViewServiceIbex.Parent = Me.MainPnl
        '_ViewServiceIbex.Dock = DockStyle.Fill
        '_ViewServiceIbex.Initdata()
        '_Service.Visible = False
        '_ViewServiceIbex.Visible = True
    End Sub

    Private Sub customersTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles contactsTileBarItem.ItemClick
        SelectPage(ePage.ContactList)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If SQLHelper.IsSQLExpressInstalled = False Then
        '    Application.Exit()
        'End If
        'ConnectionHelper.ConnectionString = "XpoProvider=MSSqlServer;data source=willow.evacchair.co.uk;initial catalog=willow;User Id=willow;Password=6A33%7rq;"
        'ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema)
        'Dim uow As New UnitOfWork
        'uow.UpdateSchema()

        'If Environment.MachineName = "JOHN-PC2" Then
        '    ConnectionHelper.ConnectionString = "XpoProvider=MSSqlServer;data source=EVAC2K8;initial catalog=EvacRemote;User Id=jmolloy;Password=6A33%7rq;"
        '    ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema)
        'ElseIf Environment.MachineName = "JOHN-PC2" Then
        '    ConnectionHelper.ConnectionString = "XpoProvider=MSSqlServer;data source=EVAC2K8;integrated security=SSPI;initial catalog=evacremote"
        '    ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema)
        'Else

        Misc.InstallUpdateSyncWithInfo()


        ConnectionHelper.ConnectionString = "XpoProvider=MSSqlServer;data source=.\SQLEXPRESS;integrated security=SSPI;initial catalog=Willow"

        ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists)
        'End If

        'OpenConnection()
        '        currentADUser = System.DirectoryServices.AccountManagement.UserPrincipal.Current
        '       Dim domainAndUserName As String = Environment.UserDomainName & "\" & Environment.UserName


        dataSession = New UnitOfWork(XpoDefault.DataLayer)
        '  Dim sSql As String = String.Format(" SELECT usercode FROM user_intlogin where winusername = '{0}' ", domainAndUserName)
        '_UserCode = dataSession.ExecuteScalar(sSql)
        If _UserCode Is Nothing Or Debugger.IsAttached Then
            _UserCode = "MH"
        End If
        SupportFilesDirectory = FindsSupportDirectory()
        ConnectionHelper.CheckForInitialRecords(dataSession)
        ConnectionHelper.Login(dataSession, _UserCode)
        BasketEnabled(False)
        SurveyEnabled(False)
        ServiceEnabled(False)
        SelectPage(ePage.ContactList)

    End Sub

    Private Sub mainTileBar_Click(sender As Object, e As EventArgs) Handles mainTileBar.Click
        Dim x = 1
    End Sub

    Private Sub basketTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles basketTileBarItem.ItemClick
        'If _Basket Is Nothing Then
        '    _Basket = New BasketList(Me)
        'End If

        '_Basket.Parent = Me.MainPnl
        '_Basket.Dock = DockStyle.Fill
        '_Basket.InitData()
        'If Not _Survey Is Nothing Then
        '    _Survey.Visible = False
        'End If
        'If Not _ProductList Is Nothing Then
        '    _ProductList.Visible = False
        'End If
        'If Not _Tasks Is Nothing Then
        '    _Tasks.Visible = False
        'End If
        'If Not _ContactList Is Nothing Then
        '    _ContactList.Visible = False
        'End If
        '_Basket.Visible = True
    End Sub

    Private Sub surveyTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles surveyTileBarItem.ItemClick
        SelectPage(ePage.SurveyList)
    End Sub

    Private Sub ServiceTileBarItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles ServiceTileBarItem.ItemClick
        SelectPage(ePage.ServiceList)
    End Sub

    'Private Sub tbiSnapReports_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tbiSnapReports.ItemClick
    '    Using fSnap As New frmSnapDesigner()
    '        fSnap.ShowDialog()
    '    End Using

    'End Sub

    Private Sub tbiEmailTemplates_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        Using frmEmail As New frmEmailTemplates(dataSession)
            frmEmail.ShowDialog()
        End Using
    End Sub

    Private Sub scheduleTileBarItem_ItemClick(sender As Object, e As TileItemEventArgs)
        XtraMessageBox.Show("Not Yet Impletmented", "Warning", MessageBoxButtons.OK)
    End Sub
End Class