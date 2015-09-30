Imports DevExpress.Xpo

Public Class EvacTask

    Enum eTaskType
        Maintenance = 0
        Survey = 1
        Training = 2
    End Enum

    Enum eTaskStatus
        InProgress = 1
        NotStarted = 2
        Deferred = 3
        Priority = 4
        Urgent = 5
        Completed = 6
    End Enum

    Enum eAccessType
        [Public]
        [Private]
        Other
    End Enum

    Enum eRouteType
        FireExit
        [Protected]
        Other
    End Enum

    Enum eIntExt
        Internal
        External
    End Enum

    Enum eNosing
        None
        Aluminium
        Carpet
        Plastic
        Rubber
        StainlessSteel
        Vinyl
        Tile
        Terrazzo
    End Enum
    Enum eAngle
        Twenty = 20
        TwentyTwo = 22
        TwentyFour = 24
        TwentySix = 26
        TwentyEight = 28
        Thirty = 30
        ThirtyTwo = 32
        ThirtyFour = 34
        ThirtySix = 36
        ThirtyEight = 38
        Fourty = 40
        FourtTwo = 42
        FourtFour = 44
        FourtSix = 46
        FourtEight = 48
        Fifty = 50
    End Enum

    Public Class UserTask
        Inherits XPCustomObject
        Private ID_Renamed As Integer

        Private notes_Renamed As String
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Private _ID As Integer
        <Persistent, Key(True)> _
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property
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
        <Size(50)> _
        Public Property Subject() As String
            Get
                Return _subject
            End Get
            Set(value As String)
                _subject = value
            End Set
        End Property
        Private _postCode As String
        <Size(10)> _
        Public Property Postcode() As String
            Get
                Return _postCode
            End Get
            Set(value As String)
                _postCode = value
            End Set
        End Property
        <Size(SizeAttribute.Unlimited)> _
        Public Property Details() As String
            Get
                Return notes_Renamed
            End Get
            Set(value As String)
                notes_Renamed = value
            End Set
        End Property
    End Class
End Class
