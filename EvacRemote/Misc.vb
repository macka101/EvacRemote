Imports System.Data.Odbc
Imports System.IO
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports EvacRemote.EvacTask
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.Helpers
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class GlobalVariables
    Public Shared SupportFilesDirectory As String = Nothing
End Class




Module Misc
    Public cn As OdbcConnection

    Public iCont As Integer = 0
    Public iDivison As Integer = 0

    Public gCurrentDivision As Division
    Public gCurrentBuilding As Building
    Public gCurrentStairwell As EscapeRoute
    Public gCurrentAsset As Asset

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

    Public currentADUser As System.DirectoryServices.AccountManagement.UserPrincipal

    Public Function OpenConnection() As OdbcConnection

        Dim sConnection As String = "DSN=PSCRM 6 Default;UID=DBA;PWD=prospect"

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

End Module
