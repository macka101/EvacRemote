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

    Public Class FieldOption
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
        Private _Id As Integer
        Public Property ID() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ID", _Id, value)
            End Set
        End Property
        Private _serviceField As eServiceFields
        Public Property ServiceField() As eServiceFields
            Get
                Return _serviceField
            End Get
            Set(ByVal value As eServiceFields)
                SetPropertyValue(Of eServiceFields)("ServiceField", _serviceField, value)
            End Set
        End Property
        Private _description As String
        Public Property Description() As String
            Get
                Return _description
            End Get
            Set(value As String)
                _description = value
            End Set
        End Property
    End Class

    Public Class Asset
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
        Private ID_Renamed As Integer
        Private barcode_Renamed As String
        Private product_Renamed As String
        Private installed_Renamed As Date
        Private notes_Renamed As String
        Private building_Renamed As Integer
        Private _productType As ProductType
        Public Property ProductType() As ProductType
            Get
                Return _productType
            End Get
            Set(ByVal value As ProductType)
                _productType = value
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
        Public Property Building() As Integer
            Get
                Return building_Renamed
            End Get
            Set(value As Integer)
                building_Renamed = value
            End Set
        End Property
        Public Property BarCode() As String
            Get
                Return barcode_Renamed
            End Get
            Set(value As String)
                barcode_Renamed = value
            End Set
        End Property
        Public Property Product() As String
            Get
                Return product_Renamed
            End Get
            Set(value As String)
                product_Renamed = value
            End Set
        End Property
        Public Property Installed() As Date
            Get
                Return installed_Renamed
            End Get
            Set(value As Date)
                installed_Renamed = value
            End Set
        End Property
        Private fLastServiced As Date?
        Public Property LastServiced() As Date?
            Get
                Return fLastServiced
            End Get
            Set(value As Date?)
                fLastServiced = value
            End Set
        End Property
        Public Property Notes() As String
            Get
                Return notes_Renamed
            End Get
            Set(value As String)
                notes_Renamed = value
            End Set
        End Property
    End Class
  

End Namespace