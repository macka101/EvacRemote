Public Enum eField
    'General 
    StairwayType = 10
    Nosing = 20
    Tread = 30
    Pitch = 40
    Going = 50
    'Ibex
    BackRest = 1000
    BrakeMechanism = 1005
    Fasteners = 1010
    HandGrips = 1015
    PatientStraps = 1020
    PlugsCaps = 1025
    Telescopic = 1030
    WheelPulleys = 1035
    'Evac
    SpringClips = 2000
    SeatRivets = 2005
    PaddingSeat = 2010
    FrontHandle = 2015
    RearHandle = 2020
    HammockCondition = 2025
    KickstandGasSpring = 2030
    RotationBelts = 2035
    SkiAssemblyRollers = 2040
    SpindlePosition = 2045
    SafetyBelt = 2050
    SeatFrame = 2055
    KickstandBolt = 2060
    KickstandGas = 2065
    StabiliserRivets = 2070
    Closure = 2075
End Enum
Public Enum ProductType
    Chair = 1
    Ibex = 2
End Enum
Public Enum eTaskType
    Maintenance = 0
    Survey = 1
    Training = 2
End Enum

Public Enum eTaskStatus
    InProgress = 1
    NotStarted = 2
    Deferred = 3
    Priority = 4
    Urgent = 5
    Completed = 6
End Enum

Public Enum eAccessType
    [Public]
    [Private]
    Other
End Enum

Public Enum eRouteType
    FireExit
    [Protected]
    Other
End Enum

Public Enum eIntExt
    Internal
    External
End Enum

Public Enum eNosing
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
Public Enum eAngle
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