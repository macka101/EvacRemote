Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel

Public Class User
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
    Private _usercode As String
    <Size(3)>
    Public Property UserCode() As String
        Get
            Return _usercode
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("UserCode", _usercode, value)
        End Set
    End Property
    Private _username As String
    <Size(30)>
    Public Property username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("username", _username, value)
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
End Class
