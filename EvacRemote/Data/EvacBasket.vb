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


Public Class Basket
    Private _parent As frmMain = Nothing
    Private _Basket As BasketHeader
    Private _session As UnitOfWork
    Public Sub New(ByVal session As Session, ByVal parent As frmMain, ByVal iContact As Integer)
        ParentFormMain = parent
        _session = session
        _Basket = _session.FindObject(Of BasketHeader)(CriteriaOperator.Parse("_division = ?", iDivison))
        If _Basket Is Nothing Then
            _Basket = New BasketHeader(_session)
        Else
            ParentFormMain.BasketEnabled(True)
        End If
    End Sub

    Public Property ParentFormMain() As frmMain
        Get
            Return _parent
        End Get
        Set(ByVal value As frmMain)
            If (Not Object.Equals(_parent, Nothing)) Then
                Return
            End If
            _parent = value
        End Set
    End Property
    Public ReadOnly Property Items() As XPCollection(Of BasketItem)
        Get
            Return _Basket.Items
        End Get
    End Property

    Public Sub AddItem(ByVal iProduct As Integer, ByVal iQty As Integer)
        Dim bNew As Boolean = True
        For Each oLine As BasketItem In _Basket.Items
            If oLine.Product = iProduct Then
                oLine.Qty += iQty
                bNew = False
                Exit For
            End If
        Next
        If bNew = True Then
            Dim oProduct = _session.FindObject(Of Product)(CriteriaOperator.Parse("productId = ?", iProduct))
            Dim oLine As New BasketItem(_session)
            oLine.Product = iProduct
            oLine.Reference = oProduct.name
            oLine.Description = oProduct.description
            oLine.Qty = iQty
            _Basket.Items.Add(oLine)
        End If
        ParentFormMain.BasketEnabled(True)
    End Sub
End Class
<Persistent("vw_Products")> _
Public Class Product
    Inherits XPLiteObject
    Dim fproductId As Integer
    <Key, Persistent> _
    Public Property productId() As Integer
        Get
            Return fproductId
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)("productId", fproductId, value)
        End Set
    End Property
    Dim fmicrositeId As Integer
    Public Property micrositeId() As Integer
        Get
            Return fmicrositeId
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)("micrositeId", fmicrositeId, value)
        End Set
    End Property
    Dim flanguageCode As String
    <Size(10)> _
    Public Property languageCode() As String
        Get
            Return flanguageCode
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("languageCode", flanguageCode, value)
        End Set
    End Property
    Dim fname As String
    <Size(50)> _
    Public Property name() As String
        Get
            Return fname
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("name", fname, value)
        End Set
    End Property
    Dim fshortDescription As String
    <Size(250)> _
    Public Property shortDescription() As String
        Get
            Return fshortDescription
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("shortDescription", fshortDescription, value)
        End Set
    End Property
    Dim fdescription As String
    <Size(400)> _
    Public Property description() As String
        Get
            Return fdescription
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("description", fdescription, value)
        End Set
    End Property
    Dim ffeatures As String
    <Size(2000)> _
    Public Property features() As String
        Get
            Return ffeatures
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("features", ffeatures, value)
        End Set
    End Property
    Dim fincludes As String
    <Size(2000)> _
    Public Property includes() As String
        Get
            Return fincludes
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("includes", fincludes, value)
        End Set
    End Property
    Dim fheight As String
    <Size(50)> _
    Public Property height() As String
        Get
            Return fheight
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("height", fheight, value)
        End Set
    End Property
    Dim fwidth As String
    <Size(50)> _
    Public Property width() As String
        Get
            Return fwidth
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("width", fwidth, value)
        End Set
    End Property
    Dim fdepth As String
    <Size(50)> _
    Public Property depth() As String
        Get
            Return fdepth
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("depth", fdepth, value)
        End Set
    End Property
    Dim fweight As String
    <Size(50)> _
    Public Property weight() As String
        Get
            Return fweight
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("weight", fweight, value)
        End Set
    End Property
    Dim floadCapacity As String
    <Size(50)> _
    Public Property loadCapacity() As String
        Get
            Return floadCapacity
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("loadCapacity", floadCapacity, value)
        End Set
    End Property
    Dim fvideo As String
    <Size(255)> _
    Public Property video() As String
        Get
            Return fvideo
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("video", fvideo, value)
        End Set
    End Property
    Dim fcertificate As String
    <Size(255)> _
    Public Property certificate() As String
        Get
            Return fcertificate
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("certificate", fcertificate, value)
        End Set
    End Property
    Dim fimage As String
    <Size(255)> _
    Public Property image() As String
        Get
            Return fimage
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("image", fimage, value)
        End Set
    End Property
    Dim faccessory As Boolean
    Public Property accessory() As Boolean
        Get
            Return faccessory
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("accessory", faccessory, value)
        End Set
    End Property
    Dim fvideoBase As String
    <Size(255)> _
    Public Property videoBase() As String
        Get
            Return fvideoBase
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("videoBase", fvideoBase, value)
        End Set
    End Property
    Dim fproductCode As String
    <Size(15)> _
    Public Property productCode() As String
        Get
            Return fproductCode
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("productCode", fproductCode, value)
        End Set
    End Property
    Dim fevacAid As Boolean
    Public Property evacAid() As Boolean
        Get
            Return fevacAid
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("evacAid", fevacAid, value)
        End Set
    End Property
    Dim fdisplayOrder As Integer
    Public Property displayOrder() As Integer
        Get
            Return fdisplayOrder
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)("displayOrder", fdisplayOrder, value)
        End Set
    End Property
    Dim fvisible As Boolean
    Public Property visible() As Boolean
        Get
            Return fvisible
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("visible", fvisible, value)
        End Set
    End Property
    Dim fstairclimber As Boolean
    Public Property stairclimber() As Boolean
        Get
            Return fstairclimber
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("stairclimber", fstairclimber, value)
        End Set
    End Property
    Dim fbuildingmanagement As Boolean
    Public Property buildingmanagement() As Boolean
        Get
            Return fbuildingmanagement
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("buildingmanagement", fbuildingmanagement, value)
        End Set
    End Property
    Dim fdatasheet As String
    <Size(50)> _
    Public Property datasheet() As String
        Get
            Return fdatasheet
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("datasheet", fdatasheet, value)
        End Set
    End Property
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
End Class
Public Class BasketHeader
    Inherits XPCustomObject
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
    Private _division As Integer
    Public Property Division() As Integer
        Get
            Return _division
        End Get
        Set(ByVal value As Integer)
            _division = value
        End Set
    End Property
    Private _date As Date?
    Public Property OrderDate() As Date?
        Get
            Return _date
        End Get
        Set(ByVal value As Date?)
            _date = value
        End Set
    End Property
    <Association("BasketItem")> _
    Public ReadOnly Property Items() As XPCollection(Of BasketItem)
        Get
            Return GetCollection(Of BasketItem)("Items")
        End Get
    End Property
End Class
Public Class BasketItem
    Inherits XPCustomObject
    Private reference_Renamed As String
    Private description_Renamed As String
    Private qty_Renamed As Integer

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
    Private fBasket As BasketHeader
    <Association("BasketItem")> _
    Public Property Basket() As BasketHeader
        Get
            Return fBasket
        End Get
        Set(ByVal value As BasketHeader)
            SetPropertyValue(Of BasketHeader)("Basket", fBasket, value)
        End Set
    End Property
    Private _Product As Integer
    Public Property Product() As Integer
        Get
            Return _Product
        End Get
        Set(value As Integer)
            _Product = value
        End Set
    End Property
    Public Property Reference() As String
        Get
            Return reference_Renamed
        End Get
        Set(value As String)
            reference_Renamed = value
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
    Public Property Qty() As Integer
        Get
            Return qty_Renamed
        End Get
        Set(value As Integer)
            qty_Renamed = value
        End Set
    End Property
End Class

