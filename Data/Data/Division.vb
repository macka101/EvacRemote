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
        <Size(120)> _
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
        <Size(20)> _
        Public Property oprano() As String
            Get
                Return _oprano
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("oprano", _oprano, value)
            End Set
        End Property
        Private _phone As String
        <Size(30)> _
        Public Property Phone() As String
            Get
                Return _phone
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Phone", _phone, value)
            End Set
        End Property
        Private _notepad As String
        <Size(SizeAttribute.Unlimited)> _
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
        Public Property ContNo() As Integer
            Get
                Return _contno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ContNo", _contno, value)
            End Set
        End Property
        Private _divno As Integer
        Public Property DivNo() As Integer
            Get
                Return _divno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("DivNo", _divno, value)
            End Set
        End Property
        Private _division As Division
        Public Property Division() As Division
            Get
                Return _division
            End Get
            Set(ByVal value As Division)
                SetPropertyValue(Of Division)("Division", _division, value)
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
        Public Property Forename() As String
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
        <PersistentAlias("isnull(Forename,'') + ' ' + isnull(Surname,'')")>
        Public ReadOnly Property SearchName() As String
            Get
                Return CType(EvaluateAlias("SearchName"), String)
            End Get
        End Property
        '<PersistentAlias("ContNo = 0 or DivNo = 0")>
        'Public ReadOnly Property ValidContact() As Integer
        '    Get
        '        Return CType(EvaluateAlias("ValidContact"), Integer)
        '    End Get
        'End Property
        Public ReadOnly Property FullName() As String
            Get
                Return GetFullName(Forename, Surname, Nothing)
            End Get
        End Property
        Public ReadOnly Property TitledName() As String
            Get
                Return GetFullName(Title, Forename, Surname)
            End Get
        End Property
        Public ReadOnly Property FullNameSorting() As String
            Get
                Return GetFullName(Surname, Title, Forename)
            End Get
        End Property
        Public Shared Function GetFullName(ByVal first As String, ByVal second As String, ByVal third As String) As String
            Dim ret As String
            If Object.Equals(first, Nothing) Then
                ret = String.Empty
            Else
                ret = first.Trim()
            End If
            Dim secondTrim As String
            If Object.Equals(second, Nothing) Then
                secondTrim = String.Empty
            Else
                secondTrim = second.Trim()
            End If
            If secondTrim.Length <> 0 Then
                If ret.Length = 0 Then
                    ret &= (String.Empty) & secondTrim
                Else
                    ret &= (" ") & secondTrim
                End If
            End If
            Dim thirdTrim As String
            If Object.Equals(third, Nothing) Then
                thirdTrim = String.Empty
            Else
                thirdTrim = third.Trim()
            End If
            If thirdTrim.Length <> 0 Then
                If ret.Length = 0 Then
                    ret &= (String.Empty) & thirdTrim
                Else
                    ret &= (" ") & thirdTrim
                End If
            End If
            Return ret
        End Function
        Public ReadOnly Property FullAddressLine() As String
            Get
                Return GetFullAddressLine()
            End Get
        End Property
        Public ReadOnly Property FullAddressBlock() As String
            Get
                Return GetFullAddressBlock()
            End Get
        End Property
        Public Function GetFullAddressLine() As String
            Dim ret As String = String.Empty
            If Address.Address1 IsNot Nothing And Address.Address1 IsNot String.Empty Then
                ret = String.Format("{0}", Address.Address1)
            End If
            If Address.Address2 IsNot Nothing And Address.Address2 IsNot String.Empty Then
                ret = String.Format("{0}, {1}", ret, Address.Address2)
            End If
            If Address.Address3 IsNot Nothing And Address.Address3 IsNot String.Empty Then
                ret = String.Format("{0}, {1}", ret, Address.Address3)
            End If
            If Address.Address4 IsNot Nothing And Address.Address4 IsNot String.Empty Then
                ret = String.Format("{0}, {1}", ret, Address.Address4)
            End If
            If Address.PostCode IsNot Nothing And Address.PostCode IsNot String.Empty Then
                ret = String.Format("{0}, {1}", ret, Address.PostCode)
            End If
            Return ret
        End Function
        Public Function GetFullAddressBlock() As String
            Dim ret As String = String.Empty
            If Address.Address1 IsNot Nothing And Address.Address1 IsNot String.Empty Then
                ret = String.Format("{0}", Address.Address1)
            End If
            If Address.Address2 IsNot Nothing And Address.Address2 IsNot String.Empty Then
                ret = String.Format("{0}{1}{2}", ret, vbCrLf, Address.Address2)
            End If
            If Address.Address3 IsNot Nothing And Address.Address3 IsNot String.Empty Then
                ret = String.Format("{0}{1}{2}", ret, vbCrLf, Address.Address3)
            End If
            If Address.Address4 IsNot Nothing And Address.Address4 IsNot String.Empty Then
                ret = String.Format("{0}{1}{2}", ret, vbCrLf, Address.Address4)
            End If
            If Address.PostCode IsNot Nothing And Address.PostCode IsNot String.Empty Then
                ret = String.Format("{0}{1}{2}", ret, vbCr, Address.PostCode)
            End If
            Return ret
        End Function
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