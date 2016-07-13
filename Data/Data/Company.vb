Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Esso.Data
    Public Class Company
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
        Private _compno As Integer
        <Association("Division-Company")>
        Public Property compno() As Integer
            Get
                Return _compno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("compno", _compno, value)
            End Set
        End Property
        Private _compname As String
        <Size(120)>
        Public Property Compname() As String
            Get
                Return _compname
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Compname", _compname, value)
            End Set
        End Property
        Private _statusFlag As String
        <Size(1)>
        Public Property StatusFlag() As String
            Get
                Return _statusFlag
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("StatusFlag", _statusFlag, value)
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