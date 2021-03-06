﻿Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Esso.Data

    Public Class Division
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
        Private _divno As Integer
        <Indexed>
        Public Property DivNo() As Integer
            Get
                Return _divno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("DivNo", _divno, value)
            End Set
        End Property
        Private _compno As Integer
        <Association("Division-Company")>
        Public Property CompNo() As Integer
            Get
                Return _compno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("CompNo", _compno, value)
            End Set
        End Property
        Private _divname As String
        <Size(120)>
        Public Property Divname() As String
            Get
                Return _divname
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Divname", _divname, value)
            End Set
        End Property
        Private _addrno As Integer
        Public Property AddrNo() As Integer
            Get
                Return _addrno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("AddrNo", _addrno, value)
            End Set
        End Property
        Private _oprano As String
        <Size(20)>
        Public Property oprano() As String
            Get
                Return _oprano
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("oprano", _oprano, value)
            End Set
        End Property
        Private _phone As String
        <Size(30)>
        Public Property Phone() As String
            Get
                Return _phone
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Phone", _phone, value)
            End Set
        End Property
        Private _notepad As String
        <Size(SizeAttribute.Unlimited)>
        Public Property Notepad() As String
            Get
                Return _notepad
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Notepad", _notepad, value)
            End Set
        End Property
        Private _statusFlag As String
        <Size(1), Indexed>
        Public Property StatusFlag() As String
            Get
                Return _statusFlag
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("StatusFlag", _statusFlag, value)
            End Set
        End Property
        <Association("Division-Buildings")>
        Public ReadOnly Property Buildings() As XPCollection(Of Building)
            Get
                Return GetCollection(Of Building)("Buildings")
            End Get
        End Property
        <Association("Division-Assets")>
        Public ReadOnly Property Assets() As XPCollection(Of Asset)
            Get
                Return GetCollection(Of Asset)("Assets")
            End Get
        End Property
        Private _lastupdatedtimestamp As Date
        <Indexed(Unique:=False)>
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