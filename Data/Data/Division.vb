Imports System
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
        Public Property divno() As Integer
            Get
                Return _divno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("divno", _divno, value)
            End Set
        End Property
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
        Private _address As Address
        Public Property Address() As Address
            Get
                Return _address
            End Get
            Set(ByVal value As Address)
                SetPropertyValue(Of Address)("CreatedBy", _address, value)
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
    Public Class Contact
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
        Private _contno As Integer
        Public Property contno() As Integer
            Get
                Return _contno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("contno", _contno, value)
            End Set
        End Property
        Private _company As Company
        Public Property Company() As Company
            Get
                Return _company
            End Get
            Set(ByVal value As Company)
                SetPropertyValue(Of Company)("Company", _company, value)
            End Set
        End Property
        Private _divno As Integer
        Public Property divno() As Integer
            Get
                Return _divno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("divno", _divno, value)
            End Set
        End Property
        Private _division As Division
        Public Property Division() As Division
            Get
                Return _Division
            End Get
            Set(ByVal value As Division)
                SetPropertyValue(Of Division)("Divno", _Division, value)
            End Set
        End Property
        Private _surname As String
        <Size(30)>
        Public Property Surname() As String
            Get
                Return _surname
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Surname", _surname, value)
            End Set
        End Property
        Private _forename As String
        <Size(20)>
        Public Property forename() As String
            Get
                Return _forename
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("forename", _forename, value)
            End Set
        End Property
        Private _title As String
        <Size(20)>
        Public Property Title() As String
            Get
                Return _title
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Title", _title, value)
            End Set
        End Property
        Private _salutation As String
        <Size(60)>
        Public Property Salutation() As String
            Get
                Return _salutation
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Salutation", _salutation, value)
            End Set
        End Property
        Private _jobTitle As String
        <Size(60)>
        Public Property JobTitle() As String
            Get
                Return _jobTitle
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("JobTitle", _jobTitle, value)
            End Set
        End Property
        Private _Phone As String
        <Size(30)>
        Public Property Phone() As String
            Get
                Return _Phone
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Phone", _Phone, value)
            End Set
        End Property
        Private _email As String
        <Size(120)>
        Public Property Email() As String
            Get
                Return _email
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Email", _email, value)
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
        <Size(1)>
        Public Property StatusFlag() As String
            Get
                Return _statusFlag
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("StatusFlag", _statusFlag, value)
            End Set
        End Property
        Private _address As Address
        Public Property Address() As Address
            Get
                Return _address
            End Get
            Set(ByVal value As Address)
                SetPropertyValue(Of Address)("CreatedBy", _address, value)
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