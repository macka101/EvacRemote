Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel

Public Class Building
    Inherits XPCustomObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    <Persistent("Oid"), Key(True), Browsable(False), MemberDesignTimeVisibility(False)> _
    Private _Oid As Guid = Guid.Empty
    <PersistentAlias("_Oid"), Browsable(False)> _
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
    Private _access As String
    Private _heritage As String
    Private notes_Renamed As String
    Private _location As String
    Public Property Location() As String
        Get
            Return _location
        End Get
        Set(value As String)
            _location = value
        End Set
    End Property
    Public Property Access() As String
        Get
            Return _access
        End Get
        Set(value As String)
            _access = value
        End Set
    End Property
    Public Property Heritage() As String
        Get
            Return _heritage
        End Get
        Set(value As String)
            _heritage = value
        End Set
    End Property
    Private _escapeRoutesNo As Integer
    Public Property EscapeRoutesNo() As Integer
        Get
            Return _escapeRoutesNo
        End Get
        Set(value As Integer)
            _escapeRoutesNo = value
        End Set
    End Property
    <Association("Building-EscapeRoute")> _
    Public ReadOnly Property EscapeRoutes() As XPCollection(Of EscapeRoute)
        Get
            Return GetCollection(Of EscapeRoute)("EscapeRoutes")
        End Get
    End Property
    Private _stairwellsNo As Integer
    Public Property StairwellsNo() As Integer
        Get
            Return _stairwellsNo
        End Get
        Set(value As Integer)
            _stairwellsNo = value
        End Set
    End Property
    <Association("Building-Floor")> _
    Public ReadOnly Property Floors() As XPCollection(Of Floor)
        Get
            Return GetCollection(Of Floor)("Floors")
        End Get
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
    Public Overrides Function ToString() As String
        Return String.Format("{0}", Location)
    End Function
End Class
Public Class EscapeRoute
    Inherits XPCustomObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    <Persistent("Oid"), Key(True), Browsable(False), MemberDesignTimeVisibility(False)> _
    Private _Oid As Guid = Guid.Empty
    <PersistentAlias("_Oid"), Browsable(False)> _
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
    Private _building As Building
    <Association("Building-EscapeRoute")> _
    Public Property Building() As Building
        Get
            Return _building
        End Get
        Set(value As Building)
            SetPropertyValue(Of Building)("Building", _building, value)
        End Set
    End Property
    Private _location As String
    Public Property Location() As String
        Get
            Return _location
        End Get
        Set(value As String)
            SetPropertyValue(Of String)("Location", _location, value)
        End Set
    End Property
    Private _IntExt As String
    Public Property IntExt() As String
        Get
            Return _IntExt
        End Get
        Set(value As String)
            _IntExt = value
        End Set
    End Property
    Private _nofloors As Integer
    Public Property NoFloors() As Integer
        Get
            Return _nofloors
        End Get
        Set(value As Integer)
            _nofloors = value
        End Set
    End Property
    Private _type As String
    Public Property Type() As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property
    Private _nosing As String
    Public Property Nosing() As String
        Get
            Return _nosing
        End Get
        Set(value As String)
            _nosing = value
        End Set
    End Property
    Private _glass As String
    Public Property Glass() As String
        Get
            Return _glass
        End Get
        Set(value As String)
            SetPropertyValue(Of String)("Glass", _glass, value)
        End Set
    End Property
    Private _angle As String
    Public Property Angle() As String
        Get
            Return _angle
        End Get
        Set(value As String)
            SetPropertyValue(Of String)("Pitch", _angle, value)
        End Set
    End Property
    Private _width As String
    Public Property Width() As String
        Get
            Return _width
        End Get
        Set(value As String)
            SetPropertyValue(Of String)("Width", _width, value)
        End Set
    End Property
    Private _going As String
    Public Property Going() As String
        Get
            Return _going
        End Get
        Set(value As String)
            _going = value
        End Set
    End Property
    Private _notes As String
    Public Property Notes() As String
        Get
            Return _notes
        End Get
        Set(value As String)
            _notes = value
        End Set
    End Property
    <Association("EscapeRoute-Floor")> _
    Public ReadOnly Property Floors() As XPCollection(Of Floor)
        Get
            Return GetCollection(Of Floor)("Floors")
        End Get
    End Property
End Class
Public Class Floor
    Inherits XPCustomObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    <Persistent("Oid"), Key(True), Browsable(False), MemberDesignTimeVisibility(False)> _
    Private _Oid As Guid = Guid.Empty
    <PersistentAlias("_Oid"), Browsable(False)> _
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
    Private ID_Renamed As Integer
    Private _pitch As String
    Private _going As String
    Private _notes As String
    Private _escaperoute As EscapeRoute
    <Association("EscapeRoute-Floor")> _
    Public Property EscapeRoute() As EscapeRoute
        Get
            Return _escaperoute
        End Get
        Set(value As EscapeRoute)
            _escaperoute = value
        End Set
    End Property
    Private _building As Building
    <Association("Building-Floor")> _
    Public Property Building() As Building
        Get
            Return _building
        End Get
        Set(value As Building)
            _building = value
        End Set
    End Property
    Private _floor As String
    Public Property Floor() As String
        Get
            Return _floor
        End Get
        Set(value As String)
            _floor = value
        End Set
    End Property
    Private _type As String
    Public Property Type() As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property
    Private _nosing As String
    Public Property Nosing() As String
        Get
            Return _nosing
        End Get
        Set(value As String)
            _nosing = value
        End Set
    End Property
    Private _glass As String
    Public Property Glass() As String
        Get
            Return _glass
        End Get
        Set(value As String)
            _glass = value
        End Set
    End Property

    Public Property Pitch() As String
        Get
            Return _pitch
        End Get
        Set(value As String)
            SetPropertyValue(Of String)("Pitch", _pitch, value)
        End Set
    End Property

    Public Property Going() As String
        Get
            Return _going
        End Get
        Set(value As String)
            _going = value
        End Set
    End Property
    Public Property Notes() As String
        Get
            Return _notes
        End Get
        Set(value As String)
            _notes = value
        End Set
    End Property
End Class
