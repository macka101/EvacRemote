Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Esso.Data
    Public Class CentralDiary
        Inherits XPCustomObject
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        <Persistent("Oid"), Key(True), Browsable(False), MemberDesignTimeVisibility(False)>
        Private _Oid As Guid = Guid.Empty
        <PersistentAlias("_Oid"), Browsable(False)>
        Public ReadOnly Property Oid() As Guid
            Get
                Return _Oid
            End Get
        End Property
        Protected Overrides Sub OnSaving()
            MyBase.OnSaving()
            If Not (TypeOf Session Is NestedUnitOfWork) AndAlso Session.IsNewObject(Me) Then
                _Oid = XpoDefault.NewGuid()
            End If
            If Session.IsNewObject(Me) And CreatedBy Is Nothing Then
                CreatedBy = ConnectionHelper.GetCurrentUser(Session)
                CreatedAt = DateTime.Now
            End If
            ModifiedBy = ConnectionHelper.GetCurrentUser(Session)
            ModifiedAt = DateTime.Now
        End Sub
        Private _centraldiaryno As Integer
        Public Property CentralDiaryNo() As Integer
            Get
                Return _centraldiaryno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("CentralDiaryNo", _centraldiaryno, value)
            End Set
        End Property
        Private _appType As Integer
        Public Property AppType() As Integer
            Get
                Return _appType
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("AppType", _appType, value)
            End Set
        End Property
        Private _leadno As Integer
        Public Property Leadno() As String
            Get
                Return _leadno
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Leadno", _leadno, value)
            End Set
        End Property
        Private _noOfChairs As Integer
        Public Property NoOfChairs() As Integer
            Get
                Return _noOfChairs
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("NoOfChairs", _noOfChairs, value)
            End Set
        End Property
        Private _bookedDate As DateTime
        Public Property BookedDate() As DateTime
            Get
                Return _bookedDate
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("BookedDate", _bookedDate, value)
            End Set
        End Property
        Private _endDate As DateTime
        Public Property EndDate() As DateTime
            Get
                Return _endDate
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("EndDate", _endDate, value)
            End Set
        End Property
        Private _allDay As Boolean
        Public Property AllDay() As Boolean
            Get
                Return _allDay
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("AllDay", _allDay, value)
            End Set
        End Property
        Private _subject As String
        <Size(100)>
        Public Property Subject() As String
            Get
                Return _subject
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Subject", _subject, value)
            End Set
        End Property
        Private _appLocation As String
        <Size(8)>
        Public Property AppLocation() As String
            Get
                Return _appLocation
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("AppLocation", _appLocation, value)
            End Set
        End Property
        Private _appDescription As String
        <Size(SizeAttribute.Unlimited)>
         Public Property AppDescription() As String
            Get
                Return _appDescription
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("AppDescription", _appDescription, value)
            End Set
        End Property
        Private _appStatus As Integer
        Public Property AppStatus() As Integer
            Get
                Return _appStatus
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("AppStatus", _appStatus, value)
            End Set
        End Property
        Private _label As Integer
        Public Property Label() As Integer
            Get
                Return _label
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Label", _label, value)
            End Set
        End Property
        Private _userId As Integer
        Public Property UserId() As Integer
            Get
                Return _userId
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("UserId", _userId, value)
            End Set
        End Property
        Private _outlookEntryID As String
        <Size(250)>
        Public Property OutlookEntryID() As String
            Get
                Return _outlookEntryID
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("OutlookEntryID", _outlookEntryID, value)
            End Set
        End Property
        Private _note As String
        <Size(500)>
        Public Property Note() As String
            Get
                Return _note
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Note", _note, value)
            End Set
        End Property
        Private _lastupdatedtimestamp As Date
        <Indexed(Unique:=False)> _
        Public Property lastupdatedtimestamp() As Date
            Get
                Return _lastupdatedtimestamp
            End Get
            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("lastupdatedtimestamp", _lastupdatedtimestamp, value)
            End Set
        End Property
        Private fcreatedBy As User
        Public Property CreatedBy() As User
            Get
                Return fcreatedBy
            End Get
            Set(ByVal value As User)
                SetPropertyValue(Of User)("CreatedBy", fcreatedBy, value)
            End Set
        End Property
        Private fcreatedAt As DateTime
        Public Property CreatedAt() As DateTime
            Get
                Return fcreatedAt
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("CreatedAt", fcreatedAt, value)
            End Set
        End Property
        Private fmodifiedBy As User
        <MergeCollisionBehavior(OptimisticLockingReadMergeBehavior.Ignore)>
        Public Property ModifiedBy() As User
            Get
                Return fmodifiedBy
            End Get
            Set(ByVal value As User)
                SetPropertyValue(Of User)("ModifiedBy", fmodifiedBy, value)
            End Set
        End Property
        Private fmodifiedAt As DateTime
        <MergeCollisionBehavior(OptimisticLockingReadMergeBehavior.Ignore)>
        Public Property ModifiedAt() As DateTime
            Get
                Return fmodifiedAt
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("ModifiedAt", fmodifiedAt, value)
            End Set
        End Property
    End Class

End Namespace