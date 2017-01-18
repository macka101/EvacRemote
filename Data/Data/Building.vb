﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing

Namespace Esso.Data

    Public Class Building
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


        Private notes_Renamed As String

        Private _division As Division
        <Association("Division-Buildings")>
        Public Property Division() As Division
            Get
                Return _division
            End Get
            Set(value As Division)
                SetPropertyValue(Of Division)("Division", _division, value)
            End Set
        End Property
        Private _survey As EvacSurvey
        <Association("Survey-Buildings")>
        Public Property Survey() As EvacSurvey
            Get
                Return _survey
            End Get
            Set(value As EvacSurvey)
                SetPropertyValue(Of EvacSurvey)("Division", _survey, value)
            End Set
        End Property
        Private _location As String
        <Size(50)>
        Public Property Location() As String
            Get
                Return _location
            End Get
            Set(value As String)
                _location = value
            End Set
        End Property
        Private _access As String
        <Size(50)>
        Public Property Access() As String
            Get
                Return _access
            End Get
            Set(value As String)
                _access = value
            End Set
        End Property
        Private _heritage As String
        <Size(50)>
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
        <Association("Building-EscapeRoute")>
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
        <Association("Building-Floor")>
        Public ReadOnly Property Floors() As XPCollection(Of Floor)
            Get
                Return GetCollection(Of Floor)("Floors")
            End Get
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
        Public Overrides Function ToString() As String
            Return String.Format("{0}", Location)
        End Function
    End Class
    Public Class EscapeRoute
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
        Private _building As Building
        <Association("Building-EscapeRoute")>
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
                SetPropertyValue(Of Integer)("NoFloors", _nofloors, value)
            End Set
        End Property
        Private _type As String
        Public Property Type() As String
            Get
                Return _type
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("Type", _type, value)
            End Set
        End Property
        Private _stairwaytype As FieldOption
        Public Property StairWayType() As FieldOption
            Get
                Return _stairwaytype
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("StairWayType", _stairwaytype, value)
            End Set
        End Property
        Private _tread As FieldOption
        Public Property Tread() As FieldOption
            Get
                Return _tread
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("Tread", _tread, value)
            End Set
        End Property
        Private _nosing As FieldOption
        Public Property Nosing() As FieldOption
            Get
                Return _nosing
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("Nosing", _nosing, value)
            End Set
        End Property
        Private _glass As FieldOption
        Public Property Glass() As FieldOption
            Get
                Return _glass
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("Glass", _glass, value)
            End Set
        End Property
        Private _pitch As FieldOption
        Public Property Pitch() As FieldOption
            Get
                Return _pitch
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("Pitch", _pitch, value)
            End Set
        End Property
        Private _width As FieldOption
        Public Property Width() As FieldOption
            Get
                Return _width
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("Width", _width, value)
            End Set
        End Property
        Private _going As FieldOption
        Public Property Going() As FieldOption
            Get
                Return _going
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("Going", _going, value)
            End Set
        End Property
        Private _narrowStairs As Boolean
        Public Property NarrowStairs() As Boolean
            Get
                Return _narrowStairs
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("NarrowStairs", _narrowStairs, value)
            End Set
        End Property
        Private _steepStairs As Boolean
        Public Property SteepStairs() As Boolean
            Get
                Return _steepStairs
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("SteepStairs", _steepStairs, value)
            End Set
        End Property
        Private _shallowstairs As Boolean
        Public Property Shallowstairs() As Boolean
            Get
                Return _shallowstairs
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("Shallowstairs", _shallowstairs, value)
            End Set
        End Property
        Private _tightTurning As Boolean
        Public Property TightTurning() As Boolean
            Get
                Return _tightTurning
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("TightTurning", _tightTurning, value)
            End Set
        End Property
        Private _unevenGround As Boolean
        Public Property UnevenGround() As Boolean
            Get
                Return _unevenGround
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("UnevenGround", _unevenGround, value)
            End Set
        End Property
        Private _horizontal As Boolean
        Public Property Horizontal() As Boolean
            Get
                Return _horizontal
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("Horizontal", _horizontal, value)
            End Set
        End Property
        Private _misuse As Boolean
        Public Property Misuse() As Boolean
            Get
                Return _misuse
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("Misuse", _misuse, value)
            End Set
        End Property
        Private _upstairs As Boolean
        Public Property Upstairs() As Boolean
            Get
                Return _upstairs
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("Upstairs", _upstairs, value)
            End Set
        End Property
        Private _spiral As Boolean
        Public Property Spiral() As Boolean
            Get
                Return _spiral
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("Spiral", _spiral, value)
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
        <Association("EscapeRoute-Floor")>
        Public ReadOnly Property Floors() As XPCollection(Of Floor)
            Get
                Return GetCollection(Of Floor)("Floors")
            End Get
        End Property
        Public Overrides Function ToString() As String
            Return String.Format("{0}", Location)
        End Function
    End Class
    Public Class Floor
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
        Private ID_Renamed As Integer
        Private _notes As String
        Private _escaperoute As EscapeRoute
        <Association("EscapeRoute-Floor")>
        Public Property EscapeRoute() As EscapeRoute
            Get
                Return _escaperoute
            End Get
            Set(value As EscapeRoute)
                _escaperoute = value
            End Set
        End Property
        Private _building As Building
        <Association("Building-Floor")>
        Public Property Building() As Building
            Get
                Return _building
            End Get
            Set(value As Building)
                _building = value
            End Set
        End Property
        Private _Survey As EvacSurvey
        <Association("Survey-Floors")>
        Public Property Survey() As EvacSurvey
            Get
                Return _Survey
            End Get
            Set(value As EvacSurvey)
                _Survey = value
            End Set
        End Property
        Private _Location As String
        Public Property Location() As String
            Get
                Return _Location
            End Get
            Set(value As String)
                _Location = value
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
        Private _stairwaytype As FieldOption
        Public Property StairWayType() As FieldOption
            Get
                Return _stairwaytype
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("StairWayType", _stairwaytype, value)
            End Set
        End Property
        Private _tread As FieldOption
        Public Property Tread() As FieldOption
            Get
                Return _tread
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("Tread", _tread, value)
            End Set
        End Property
        Private _nosing As FieldOption
        Public Property Nosing() As FieldOption
            Get
                Return _nosing
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("Nosing", _nosing, value)
            End Set
        End Property
        Private _glass As FieldOption
        Public Property Glass() As FieldOption
            Get
                Return _glass
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("Glass", _glass, value)
            End Set
        End Property
        Private _pitch As FieldOption
        Public Property Pitch() As FieldOption
            Get
                Return _pitch
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("Pitch", _pitch, value)
            End Set
        End Property
        Private _width As FieldOption
        Public Property Width() As FieldOption
            Get
                Return _width
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("Width", _width, value)
            End Set
        End Property
        Private _going As FieldOption
        Public Property Going() As FieldOption
            Get
                Return _going
            End Get
            Set(value As FieldOption)
                SetPropertyValue(Of FieldOption)("Going", _going, value)
            End Set
        End Property
        Private _bedBound As Boolean
        Public Property BedBound() As Boolean
            Get
                Return _bedBound
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("BedBound", _bedBound, value)
            End Set
        End Property
        Private _barriatric As Boolean
        Public Property Barriatric() As Boolean
            Get
                Return _barriatric
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("Barriatric", _barriatric, value)
            End Set
        End Property
        Private _complexDisability As Boolean
        Public Property ComplexDisability() As Boolean
            Get
                Return _complexDisability
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("ComplexDisability", _complexDisability, value)
            End Set
        End Property
        Private _smallStorage As Boolean
        Public Property SmallStorage() As Boolean
            Get
                Return _smallStorage
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("SmallStorage", _smallStorage, value)
            End Set
        End Property
        Private _bedAccess As Boolean
        Public Property BedAccess() As Boolean
            Get
                Return _bedAccess
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("BedAccess", _bedAccess, value)
            End Set
        End Property
        Private _misuse As Boolean
        Public Property Misuse() As Boolean
            Get
                Return _misuse
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("Misuse", _misuse, value)
            End Set
        End Property
        Private _movingAndHandling As Boolean
        Public Property MovingAndHandling() As Boolean
            Get
                Return _movingAndHandling
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("MovingAndHandling", _movingAndHandling, value)
            End Set
        End Property
        Private _recommenedProduct As Product
        Public Property RecommendedProduct() As Product
            Get
                Return _recommenedProduct
            End Get
            Set(value As Product)
                _recommenedProduct = value
            End Set
        End Property
        Private _product As Product
        Public Property Product() As Product
            Get
                Return _product
            End Get
            Set(value As Product)
                _product = value
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
        Public Overrides Function ToString() As String
            Return String.Format("{0}", Location)
        End Function
    End Class
End Namespace