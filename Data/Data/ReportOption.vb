Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.ComponentModel

Namespace Esso.Data
    Public Class ReportOption
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
        Private _optno As Integer
        Public Property OptNo() As Integer
            Get
                Return _optno
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("OptNo", _optno, value)
            End Set
        End Property
        Private _text As String
        <Size(SizeAttribute.Unlimited)>
        Public Property Text() As String
            Get
                Return _text
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Text", _text, value)
            End Set
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
    End Class
End Namespace
