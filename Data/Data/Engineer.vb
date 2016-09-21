Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Esso.Data
    Public Class Engineer
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
        Private _engineerno As Integer
        Public Property EngineerNo() As Integer
            Get
                Return _engineerno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("EngineerNo", _engineerno, value)
            End Set
        End Property
        Private _engineerCode As String
        <Size(10)>
        Public Property EngineerCode() As String
            Get
                Return _engineerCode
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("EngineerCode", _engineerCode, value)
            End Set
        End Property   
        Private _engineer_name As String
        <Size(50)>
        Public Property EngineerName() As String
            Get
                Return _engineer_name
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("EngineerName", _engineer_name, value)
            End Set
        End Property
    End Class

End Namespace