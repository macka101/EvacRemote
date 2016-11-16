Imports System.Data.Odbc
Imports System.IO
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.Helpers
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.Xpo
Imports Esso.Data
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering
Imports System.Deployment.Application
Imports DevExpress.XtraGrid.Columns

Public Class GlobalVariables
    Public Shared SupportFilesDirectory As String = Nothing
End Class




Module Misc
    Public cn As OdbcConnection
    Public _offline As Boolean = False

    Public iCont As Integer = 0
    Public iDivison As Integer = 0

    Public _currentDivision As Division
    Public _currentContact As Contact
    Public _currentProduct As Product
    Public _currentSurvey As EvacSurvey
    Public _currentService As EvacService
    Public _currentChairservice As ChairService
    Public _currentFloor As Floor

    Public _currentBuilding As Building
    Public _currentEscapeRoute As EscapeRoute
    Public _currentAsset As Asset

    Public sContactName As String = ""

    Public Const SMALL_IMAGES_FOLDER As String = "\IMAGES\SMALL\"
    Public Const MEDIUM_IMAGES_FOLDER As String = "\IMAGES\MEDIUM\"
    Public Const LARGE_IMAGES_FOLDER As String = "\IMAGES\LARGE\"
    Public Const PDF_FOLDER As String = "\PDF\"
    Public Const VIDEO_FOLDER As String = "\VIDEO\"

    Public _UserId As Integer = -1
    Public _UserCode As String = ""
    Public _EngineerNo As Integer = 0
    Public _EngineerName As String = ""

    Public ThisBasket As Basket
    Public ChairsList As String = "'1-200','1-110','1-300H-MK4','1-300H-MK4-M','1-300-AMB','1-300-AMB-M','1-500','1-500-M','1-600H','1-600H-M','1-600-AMB','1-700H'"

    Public currentADUser As System.DirectoryServices.AccountManagement.UserPrincipal

    'Public xpBuildings As XPCollection(Of Building)
    'Public xpEscapeRoutes As XPCollection(Of EscapeRoute)
    'Public xpFloors As XPCollection(Of Floor)

    Public Function OpenConnection() As OdbcConnection

        Dim sConnection As String
        If _offline = False Then
            sConnection = "DSN=PSCRM 6 Default;UID=DBA;PWD=prospect"
        Else
            sConnection = "DSN=PSCRM 6 Default OffLine;UID=DBA;PWD=prospect"
        End If

        Try
            cn = New OdbcConnection(sConnection)
            cn.Open()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Application.Exit()
        End Try
        Return cn

    End Function
    Public Function FindsSupportDirectory() As String
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
        Dim sSupportDirectory As String = Nothing
        Dim d As DriveInfo
        For Each d In allDrives
            If d.IsReady = True Then
                Dim sDrive = d.Name + "EvacFiles"
                If Directory.Exists(sDrive) Then
                    sSupportDirectory = sDrive
                    Exit For
                End If
            End If
        Next
        Return sSupportDirectory
    End Function
    Public Function CreateEnumImageComboBox(Of TEnum)(ByVal container As DevExpress.XtraEditors.Container.EditorContainer, Optional ByVal displayTextConverter As Converter(Of TEnum, String) = Nothing) As RepositoryItemImageComboBox
        Return CreatEdit(Of RepositoryItemImageComboBox)(Nothing, If(container IsNot Nothing, container.RepositoryItems, Nothing), Sub(e) e.Items.AddEnum(Of TEnum)(displayTextConverter))
    End Function
    Public Function CreateEnumImageComboBox(Of TEnum)(Optional ByVal edit As RepositoryItemImageComboBox = Nothing, Optional ByVal collection As RepositoryItemCollection = Nothing, Optional ByVal displayTextConverter As Converter(Of TEnum, String) = Nothing) As RepositoryItemImageComboBox
        Return CreatEdit(Of RepositoryItemImageComboBox)(edit, collection, Sub(e) e.Items.AddEnum(Of TEnum)(displayTextConverter))
    End Function
    Public Function CreatEdit(Of TEdit As {RepositoryItem, New})(Optional ByVal edit As TEdit = Nothing, Optional ByVal collection As RepositoryItemCollection = Nothing, Optional ByVal initialize As Action(Of TEdit) = Nothing) As TEdit
        edit = If(edit, New TEdit())
        If collection IsNot Nothing Then
            collection.Add(edit)
        End If
        If initialize IsNot Nothing Then
            initialize(edit)
        End If

        Return edit
    End Function
    Public Function CreateBuildingLookUpEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection, ByVal key As Boolean, ByRef _division As Guid) As RepositoryItemLookUpEdit
        Return CreateBuildingLookUpEdit(session, Nothing, collection, key, _division)
    End Function
    Public Function CreateBuildingLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection, ByRef _division As Guid) As RepositoryItemLookUpEdit
        Return CreateBuildingLookUpEdit(session, edit, collection, False, _division)
    End Function
    Public Function CreateBuildingLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection, ByVal key As Boolean, ByRef _division As Guid) As RepositoryItemLookUpEdit
        Dim ret As RepositoryItemLookUpEdit
        If Object.Equals(edit, Nothing) Then
            ret = New RepositoryItemLookUpEdit()
        Else
            ret = edit
        End If
        If (Not Object.Equals(collection, Nothing)) Then
            collection.Add(ret)
        End If
        If key Then
            ret.ValueMember = "Oid"
        Else
            ret.ValueMember = "This"
        End If

        ret.DisplayMember = "Location"

        Dim filter As CriteriaOperator = Nothing
        filter = CriteriaOperator.Parse("Division = ? ", _division)

        ret.DataSource = New XPCollection(Of Building)(session, filter, New SortProperty("Location", DevExpress.Xpo.DB.SortingDirection.Ascending))
        ret.NullText = String.Empty
        ret.Columns.Clear()
        ret.Columns.Add(New LookUpColumnInfo("Location"))
        ret.AllowDropDownWhenReadOnly = DefaultBoolean.False
        ret.ShowHeader = False
        ret.DropDownRows = 10
        Return ret
    End Function

    Public Function CreateEscapeRouteLookUpEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection, ByVal key As Boolean, ByRef _building As Guid) As RepositoryItemLookUpEdit
        Return CreateEscapeRouteLookUpEdit(session, Nothing, collection, key, _building)
    End Function
    Public Function CreateEscapeRouteLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection, ByRef _building As Guid) As RepositoryItemLookUpEdit
        Return CreateEscapeRouteLookUpEdit(session, edit, collection, False, _building)
    End Function
    Public Function CreateEscapeRouteLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection, ByVal key As Boolean, ByRef _building As Guid) As RepositoryItemLookUpEdit
        Dim ret As RepositoryItemLookUpEdit
        If Object.Equals(edit, Nothing) Then
            ret = New RepositoryItemLookUpEdit()
        Else
            ret = edit
        End If
        If (Not Object.Equals(collection, Nothing)) Then
            collection.Add(ret)
        End If
        If key Then
            ret.ValueMember = "Oid"
        Else
            ret.ValueMember = "This"
        End If

        ret.DisplayMember = "Location"

        Dim filter As CriteriaOperator = Nothing
        filter = CriteriaOperator.Parse("Building = ? ", _building)

        ret.DataSource = New XPCollection(Of EscapeRoute)(session, filter, New SortProperty("Location", DevExpress.Xpo.DB.SortingDirection.Ascending))
        ret.NullText = String.Empty
        ret.Columns.Clear()
        ret.Columns.Add(New LookUpColumnInfo("Location"))
        ret.AllowDropDownWhenReadOnly = DefaultBoolean.False
        ret.ShowHeader = False
        ret.DropDownRows = 10
        Return ret
    End Function

    Public Function CreateFloorLookUpEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection, ByVal key As Boolean, ByRef _escapeRoute As Guid) As RepositoryItemLookUpEdit
        Return CreateFloorLookUpEdit(session, Nothing, collection, key, _escapeRoute)
    End Function
    Public Function CreateFloorLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection, ByRef _escapeRoute As Guid) As RepositoryItemLookUpEdit
        Return CreateFloorLookUpEdit(session, edit, collection, False, _escapeRoute)
    End Function
    Public Function CreateFloorLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection, ByVal key As Boolean, ByRef _escapeRoute As Guid) As RepositoryItemLookUpEdit
        Dim ret As RepositoryItemLookUpEdit
        If Object.Equals(edit, Nothing) Then
            ret = New RepositoryItemLookUpEdit()
        Else
            ret = edit
        End If
        If (Not Object.Equals(collection, Nothing)) Then
            collection.Add(ret)
        End If
        If key Then
            ret.ValueMember = "Oid"
        Else
            ret.ValueMember = "This"
        End If

        ret.DisplayMember = "Location"

        Dim filter As CriteriaOperator = Nothing
        filter = CriteriaOperator.Parse("EscapeRoute = ? ", _escapeRoute)

        ret.DataSource = New XPCollection(Of Floor)(session, filter, New SortProperty("Location", DevExpress.Xpo.DB.SortingDirection.Ascending))
        ret.NullText = String.Empty
        ret.Columns.Clear()
        ret.Columns.Add(New LookUpColumnInfo("Location"))
        ret.AllowDropDownWhenReadOnly = DefaultBoolean.False
        ret.ShowHeader = False
        ret.DropDownRows = 10
        Return ret
    End Function

    Public Function CreateFieldOptionGrid(ByVal session As Session, ByVal collection As RepositoryItemCollection, ByVal key As Boolean, _field As eField) As RepositoryItemGridLookUpEdit
        Return CreateFieldOptionGrid(session, Nothing, collection, key, _field)
    End Function
    Public Function CreateFieldOptionGrid(ByVal session As Session, ByVal edit As RepositoryItemGridLookUpEdit, ByVal collection As RepositoryItemCollection, _field As eField) As RepositoryItemGridLookUpEdit
        Return CreateFieldOptionGrid(session, edit, collection, False, _field)
    End Function
    Public Function CreateFieldOptionGrid(ByVal session As Session, ByVal edit As RepositoryItemGridLookUpEdit, ByVal collection As RepositoryItemCollection, ByVal key As Boolean, _field As eField) As RepositoryItemGridLookUpEdit
        Dim ret As RepositoryItemGridLookUpEdit
        If Object.Equals(edit, Nothing) Then
            ret = New RepositoryItemGridLookUpEdit()
        Else
            ret = edit
        End If
        If (Not Object.Equals(collection, Nothing)) Then
            collection.Add(ret)
        End If
        If key Then
            ret.ValueMember = "Oid"
        Else
            ret.ValueMember = "This"
        End If

        ret.DisplayMember = "Description"

        ret.DataSource = New XPCollection(Of FieldOption)(session, CriteriaOperator.Parse("Field = ? ", _field), New SortProperty("Description", DevExpress.Xpo.DB.SortingDirection.Ascending))
        ret.NullText = String.Empty
        ret.AllowDropDownWhenReadOnly = DefaultBoolean.False
        ret.PopulateViewColumns()
        For Each ocol As GridColumn In ret.View.Columns
            If ocol.FieldName <> "Description" Then
                ocol.Visible = False
            End If
        Next

        Return ret
    End Function



    Public Function CreateProductLookUpEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection, ByVal key As Boolean) As RepositoryItemLookUpEdit
        Return CreateProductLookUpEdit(session, Nothing, collection, key)
    End Function
    Public Function CreateProductLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection) As RepositoryItemLookUpEdit
        Return CreateProductLookUpEdit(session, edit, collection, False)
    End Function
    Public Function CreateProductLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection, ByVal key As Boolean) As RepositoryItemLookUpEdit
        Dim ret As RepositoryItemLookUpEdit
        If Object.Equals(edit, Nothing) Then
            ret = New RepositoryItemLookUpEdit()
        Else
            ret = edit
        End If
        If (Not Object.Equals(collection, Nothing)) Then
            collection.Add(ret)
        End If
        If key Then
            ret.ValueMember = "Oid"
        Else
            ret.ValueMember = "This"
        End If

        ret.DisplayMember = "Description"

        ret.DataSource = New XPCollection(Of Product)(session, Nothing, New SortProperty("ProductCode", DevExpress.Xpo.DB.SortingDirection.Ascending))
        ret.NullText = String.Empty
        ret.Columns.Clear()
        ret.Columns.Add(New LookUpColumnInfo("Description"))
        ret.AllowDropDownWhenReadOnly = DefaultBoolean.False
        ret.ShowHeader = False
        ret.DropDownRows = 20
        Return ret
    End Function

    Public Function CreateTaskTypeImageComboBox(ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
        Return CreateTaskTypeImageComboBox(Nothing, collection)
    End Function
    Public Function CreateTaskTypeImageComboBox(ByVal edit As RepositoryItemImageComboBox, ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
        Dim ret As RepositoryItemImageComboBox
        If Object.Equals(edit, Nothing) Then
            ret = New RepositoryItemImageComboBox()
        Else
            ret = edit
        End If
        If (Not Object.Equals(collection, Nothing)) Then
            collection.Add(ret)
        End If
        Dim arr As Array = System.Enum.GetValues(GetType(eTaskType))
        ret.Items.Clear()
        For Each status As eTaskType In arr
            ret.Items.Add(New ImageComboBoxItem(MasterDetailHelper.SplitPascalCaseString(status.ToString()), status, CInt(Fix(status))))
        Next status
        Return ret
    End Function
    Public Function CreateTaskStatusImageComboBox(ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
        Return CreateTaskStatusImageComboBox(Nothing, collection)
    End Function
    Public Function CreateTaskStatusImageComboBox(ByVal edit As RepositoryItemImageComboBox, ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
        Dim ret As RepositoryItemImageComboBox
        If Object.Equals(edit, Nothing) Then
            ret = New RepositoryItemImageComboBox()
        Else
            ret = edit
        End If
        If (Not Object.Equals(collection, Nothing)) Then
            collection.Add(ret)
        End If
        Dim arr As Array = System.Enum.GetValues(GetType(eTaskStatus))
        ret.Items.Clear()
        For Each status As eTaskStatus In arr
            ret.Items.Add(New ImageComboBoxItem(MasterDetailHelper.SplitPascalCaseString(status.ToString()), status, CInt(Fix(status))))
        Next status
        Return ret
    End Function
    Public Function CreateAccessTypeImageComboBox(ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
        Return CreateAccessTypeImageComboBox(Nothing, collection)
    End Function
    Public Function CreateAccessTypeImageComboBox(ByVal edit As RepositoryItemImageComboBox, ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
        Dim ret As RepositoryItemImageComboBox
        If Object.Equals(edit, Nothing) Then
            ret = New RepositoryItemImageComboBox()
        Else
            ret = edit
        End If
        If (Not Object.Equals(collection, Nothing)) Then
            collection.Add(ret)
        End If
        Dim arr As Array = System.Enum.GetValues(GetType(eAccessType))
        ret.Items.Clear()
        For Each status As eAccessType In arr
            ret.Items.Add(New ImageComboBoxItem(MasterDetailHelper.SplitPascalCaseString(status.ToString()), status, CInt(Fix(status))))
        Next status
        ret.AllowDropDownWhenReadOnly = DefaultBoolean.False
        Return ret
    End Function

    Public Function CreateNosingImageComboBox(ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
        Return CreateNosingImageComboBox(Nothing, collection)
    End Function
    Public Function CreateNosingImageComboBox(ByVal edit As RepositoryItemImageComboBox, ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
        Dim ret As RepositoryItemImageComboBox
        If Object.Equals(edit, Nothing) Then
            ret = New RepositoryItemImageComboBox()
        Else
            ret = edit
        End If
        If (Not Object.Equals(collection, Nothing)) Then
            collection.Add(ret)
        End If
        Dim arr As Array = System.Enum.GetValues(GetType(eNosing))
        ret.Items.Clear()
        For Each status As eNosing In arr
            ret.Items.Add(New ImageComboBoxItem(MasterDetailHelper.SplitPascalCaseString(status.ToString()), status, CInt(Fix(status))))
        Next status
        ret.AllowDropDownWhenReadOnly = DefaultBoolean.False
        Return ret
    End Function
    Public Sub CreateToggleSwitch(ByRef _switch As ToggleSwitch)
        _switch.Properties.OffText = "No"
        _switch.Properties.OnText = "Yes"
    End Sub
    Public Class OrderLine
        Private productID_Renamed As Integer
        Private code_Renamed As String
        Private description_Renamed As String
        Private qty_Renamed As Integer

        Public Sub New()
        End Sub

        Public ReadOnly Property ClientID() As Integer
            Get
                Return productID_Renamed
            End Get
        End Property
        Public Property code() As String
            Get
                Return code_Renamed
            End Get
            Set(value As String)
                code_Renamed = value
            End Set
        End Property
        Public Property Description() As String
            Get
                Return description_Renamed
            End Get
            Set(value As String)
                description_Renamed = value
            End Set
        End Property
        Public Property CompanyName() As Integer
            Get
                Return qty_Renamed
            End Get
            Set(value As Integer)
                qty_Renamed = value
            End Set
        End Property
    End Class

    Public Class ValidationRulesHelper
        Private Shared fruleIsNotBlank As ConditionValidationRule = Nothing
        Private Shared fruleGreaterOrEqualZero As ConditionValidationRule = Nothing
        Public Shared ReadOnly Property RuleIsNotBlank() As ConditionValidationRule
            Get
                If Object.Equals(fruleIsNotBlank, Nothing) Then
                    fruleIsNotBlank = New ConditionValidationRule()
                    fruleIsNotBlank.ConditionOperator = ConditionOperator.IsNotBlank
                    fruleIsNotBlank.ErrorText = ConstStrings.RuleIsNotBlankWarning
                    fruleIsNotBlank.ErrorType = ErrorType.Critical
                End If
                Return fruleIsNotBlank
            End Get
        End Property
        Public Shared ReadOnly Property RuleGreaterOrEqualZero() As ConditionValidationRule
            Get
                If Object.Equals(fruleGreaterOrEqualZero, Nothing) Then
                    fruleGreaterOrEqualZero = New ConditionValidationRule()
                    fruleGreaterOrEqualZero.ConditionOperator = ConditionOperator.GreaterOrEqual
                    fruleGreaterOrEqualZero.Value1 = 0
                    fruleGreaterOrEqualZero.ErrorText = ConstStrings.RuleGreaterOrEqualZeroWarning
                    fruleGreaterOrEqualZero.ErrorType = ErrorType.Critical
                End If
                Return fruleGreaterOrEqualZero
            End Get
        End Property
        Public Shared Function RuleGreaterOrEqual(ByVal value As Integer) As ConditionValidationRule
            Dim ret As New ConditionValidationRule()
            ret.ConditionOperator = ConditionOperator.GreaterOrEqual
            ret.Value1 = value
            ret.ErrorText = ConstStrings.RuleGreaterOrEqualZeroWarning
            ret.ErrorType = ErrorType.Critical
            Return ret
        End Function
    End Class

    Public Sub RecommendProduct(ByRef _session As UnitOfWork, ByRef _floor As Floor)
        Dim _bestmatch As Integer = 0
        Dim _bestproduct As Product = Nothing
        Dim _building As Building = _floor.Building
        Dim _escaperoute As EscapeRoute = _floor.EscapeRoute
        For Each _product As Product In New XPCollection(Of Product)(_session)
            Dim _matchcount As Integer = _product.RatingDefault

            If _building.Heritage = "Yes" And _product.RatingHeritage > 0 Then
                _matchcount += _product.RatingHeritage
            End If

            If _building.Access = "Public" And _product.RatingPublic > 0 Then
                _matchcount += _product.RatingPublic
            End If

            If _building.Access = "Public" And _product.RatingPublic > 0 Then
                _matchcount += _product.RatingPublic
            End If
            If _escaperoute.NarrowStairs = True And _product.RatingNarrowStairs > 0 Then
                _matchcount += _product.RatingNarrowStairs
            End If
            If _escaperoute.SteepStairs = True And _product.RatingSteepStairs > 0 Then
                _matchcount += _product.RatingSteepStairs
            End If
            If _escaperoute.TightTurning = True And _product.RatingTightTurning > 0 Then
                _matchcount += _product.RatingTightTurning
            End If
            If _escaperoute.UnevenGround = True And _product.RatingUnevenGround > 0 Then
                _matchcount += _product.RatingUnevenGround
            End If

            If _escaperoute.Horizontal = True And _product.RatingTightTurning > 0 Then
                _matchcount += _product.RatingTightTurning
            End If
            If _escaperoute.Misuse = True And _product.RatingMisuse > 0 Then
                _matchcount += _product.RatingMisuse
            End If
            If _escaperoute.Upstairs = True And _product.RatingUpstairs > 0 Then
                _matchcount += _product.RatingUpstairs
            End If
            If _escaperoute.Spiral = True And _product.RatingSpiral > 0 Then
                _matchcount += _product.RatingSpiral
            End If

            If _floor.BedBound = True And _product.RatingBedBound > 0 Then
                _matchcount += _product.RatingBedBound
            End If

            If _floor.Barriatric = True And _product.RatingBarriatric > 0 Then
                _matchcount += _product.RatingBarriatric
            End If
            If _floor.ComplexDisability = True And _product.RatingComplexDisability > 0 Then
                _matchcount += _product.RatingComplexDisability
            End If
            If _floor.SmallStorage = True And _product.RatingSmallStorage > 0 Then
                _matchcount += _product.RatingSmallStorage
            End If
            If _floor.BedAccess = True And _product.RatingBedAccess > 0 Then
                _matchcount += _product.RatingBedAccess
            End If

            If _floor.Misuse = True And _product.RatingMisuse > 0 Then
                _matchcount += _product.RatingBedAccess
            End If
            If _matchcount > _bestmatch Then
                _bestmatch = _matchcount
                _bestproduct = _product
            End If
        Next
        _floor.RecommendedProduct = _bestproduct
        If _floor.Product Is Nothing Then
            _floor.Product = _bestproduct
        End If

    End Sub
    Public Sub InstallUpdateSyncWithInfo()
        Dim info As UpdateCheckInfo = Nothing

        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                MessageBox.Show("The new version of the application cannot be downloaded at this time. " + ControlChars.Lf & ControlChars.Lf & "Please check your network connection, or try again later. Error: " + dde.Message)
                Return
            Catch ioe As InvalidOperationException
                MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " & ioe.Message)
                Return
            End Try

            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Dim dr As DialogResult = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MessageBox.Show("This application has detected a mandatory update from your current " & _
                        "version to version " & info.MinimumRequiredVersion.ToString() & _
                        ". The application will now install the update and restart.", _
                        "Update Available", MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
                End If

                If (doUpdate) Then
                    Try
                        AD.Update()
                        MessageBox.Show("The application has been upgraded, and will now restart.")
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        MessageBox.Show("Cannot install the latest version of the application. " & ControlChars.Lf & ControlChars.Lf & "Please check your network connection, or try again later.")
                        Return
                    End Try
                End If
            End If
        End If
    End Sub

End Module
