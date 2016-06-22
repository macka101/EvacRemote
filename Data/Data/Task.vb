Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Esso.Data
    Public Class Task
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
        End Sub
        Private notes_Renamed As String
        Private _taskType As eTaskType
        Public Property TaskType() As eTaskType
            Get
                Return _taskType
            End Get
            Set(ByVal value As eTaskType)
                _taskType = value
            End Set
        End Property
        Private _taskStatus As eTaskStatus
        Public Property TaskStatus() As eTaskStatus
            Get
                Return _taskStatus
            End Get
            Set(ByVal value As eTaskStatus)
                _taskStatus = value
            End Set
        End Property
        Private _startDate As Date
        Public Property StartDate() As Date
            Get
                Return _startDate
            End Get
            Set(ByVal value As Date)
                _startDate = value
            End Set
        End Property
        Private _endDate As Date
        Public Property EndDate() As Date
            Get
                Return _endDate
            End Get
            Set(ByVal value As Date)
                _endDate = value
            End Set
        End Property
        Private _allDay As Integer
        Public Property AllDay() As Integer
            Get
                Return _allDay
            End Get
            Set(ByVal value As Integer)
                _allDay = value
            End Set
        End Property

        Private _contact As Integer
        Public Property Contact() As Integer
            Get
                Return _contact
            End Get
            Set(ByVal value As Integer)
                _contact = value
            End Set
        End Property
        Private _user As String
        Public Property User() As String
            Get
                Return _user
            End Get
            Set(ByVal value As String)
                _user = value
            End Set
        End Property
        Private _division As Integer
        Public Property Division() As Integer
            Get
                Return _division
            End Get
            Set(ByVal value As Integer)
                _division = value
            End Set
        End Property
        Private _subject As String
        <Size(50)>
        Public Property Subject() As String
            Get
                Return _subject
            End Get
            Set(value As String)
                _subject = value
            End Set
        End Property
        Private _postCode As String
        <Size(10)>
        Public Property Postcode() As String
            Get
                Return _postCode
            End Get
            Set(value As String)
                _postCode = value
            End Set
        End Property
        <Size(SizeAttribute.Unlimited)>
        Public Property Details() As String
            Get
                Return notes_Renamed
            End Get
            Set(value As String)
                notes_Renamed = value
            End Set
        End Property
    End Class
End Namespace