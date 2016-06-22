Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Esso.Data
    Public Class Address
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
        Private _addrno As Integer
        Public Property addrno() As Integer
            Get
                Return _addrno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("addrno", _addrno, value)
            End Set
        End Property
        Private _Address1 As String
        <Size(30)>
        Public Property Address1() As String
            Get
                Return _Address1
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address1", _Address1, value)
            End Set
        End Property
        <Size(30)>
        Private _Address2 As String
        Public Property Address2() As String
            Get
                Return _Address2
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address2", _Address2, value)
            End Set
        End Property
        <Size(30)>
        Private _Address3 As String
        Public Property Address3() As String
            Get
                Return _Address3
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address3", _Address3, value)
            End Set
        End Property
        <Size(30)>
        Private _Address4 As String
        Public Property Address4() As String
            Get
                Return _Address4
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address4", _Address4, value)
            End Set
        End Property
        <Size(10)>
        Private _postcode As String
        Public Property PostCode() As String
            Get
                Return _postcode
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PostCode", _postcode, value)
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