Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel

Public Class Product
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
    Dim fproductId As Integer
    Dim fmicrositeId As Integer
    Public Property micrositeId() As Integer
        Get
            Return fmicrositeId
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)("micrositeId", fmicrositeId, value)
        End Set
    End Property
    Private flanguageCode As String
    <Size(10)> _
    Public Property languageCode() As String
        Get
            Return flanguageCode
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("languageCode", flanguageCode, value)
        End Set
    End Property
    Private fname As String
    <Size(50)> _
    Public Property name() As String
        Get
            Return fname
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("name", fname, value)
        End Set
    End Property
    Private fshortDescription As String
    <Size(250)> _
    Public Property shortDescription() As String
        Get
            Return fshortDescription
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("shortDescription", fshortDescription, value)
        End Set
    End Property
    Private fdescription As String
    <Size(400)> _
    Public Property description() As String
        Get
            Return fdescription
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("description", fdescription, value)
        End Set
    End Property
    Private ffeatures As String
    <Size(2000)> _
    Public Property features() As String
        Get
            Return ffeatures
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("features", ffeatures, value)
        End Set
    End Property
    Private fincludes As String
    <Size(2000)> _
    Public Property includes() As String
        Get
            Return fincludes
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("includes", fincludes, value)
        End Set
    End Property
    Private fheight As String
    <Size(50)> _
    Public Property height() As String
        Get
            Return fheight
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("height", fheight, value)
        End Set
    End Property
    Private fwidth As String
    <Size(50)> _
    Public Property width() As String
        Get
            Return fwidth
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("width", fwidth, value)
        End Set
    End Property
    Private fdepth As String
    <Size(50)> _
    Public Property depth() As String
        Get
            Return fdepth
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("depth", fdepth, value)
        End Set
    End Property
    Private fweight As String
    <Size(50)> _
    Public Property weight() As String
        Get
            Return fweight
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("weight", fweight, value)
        End Set
    End Property
    Private floadCapacity As String
    <Size(50)> _
    Public Property loadCapacity() As String
        Get
            Return floadCapacity
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("loadCapacity", floadCapacity, value)
        End Set
    End Property
    Private fvideo As String
    <Size(255)> _
    Public Property video() As String
        Get
            Return fvideo
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("video", fvideo, value)
        End Set
    End Property
    Private fcertificate As String
    <Size(255)> _
    Public Property certificate() As String
        Get
            Return fcertificate
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("certificate", fcertificate, value)
        End Set
    End Property
    Private fimage As String
    <Size(255)> _
    Public Property image() As String
        Get
            Return fimage
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("image", fimage, value)
        End Set
    End Property
    Private faccessory As Boolean
    Public Property accessory() As Boolean
        Get
            Return faccessory
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("accessory", faccessory, value)
        End Set
    End Property
    Private fvideoBase As String
    <Size(255)> _
    Public Property videoBase() As String
        Get
            Return fvideoBase
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("videoBase", fvideoBase, value)
        End Set
    End Property
    Private fproductCode As String
    <Size(15)> _
    Public Property productCode() As String
        Get
            Return fproductCode
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("productCode", fproductCode, value)
        End Set
    End Property
    Private fevacAid As Boolean
    Public Property evacAid() As Boolean
        Get
            Return fevacAid
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("evacAid", fevacAid, value)
        End Set
    End Property
    Private fdisplayOrder As Integer
    Public Property displayOrder() As Integer
        Get
            Return fdisplayOrder
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)("displayOrder", fdisplayOrder, value)
        End Set
    End Property
    Private fvisible As Boolean
    Public Property visible() As Boolean
        Get
            Return fvisible
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("visible", fvisible, value)
        End Set
    End Property
    Private fstairclimber As Boolean
    Public Property stairclimber() As Boolean
        Get
            Return fstairclimber
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("stairclimber", fstairclimber, value)
        End Set
    End Property
    Private fbuildingmanagement As Boolean
    Public Property buildingmanagement() As Boolean
        Get
            Return fbuildingmanagement
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("buildingmanagement", fbuildingmanagement, value)
        End Set
    End Property
    Private fdatasheet As String
    <Size(50)> _
    Public Property datasheet() As String
        Get
            Return fdatasheet
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("datasheet", fdatasheet, value)
        End Set
    End Property
End Class
