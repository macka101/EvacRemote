Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel

Public Class Division
    Inherits XPObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Private _divno As Integer
    Public Property Divno() As Integer
        Get
            Return _divno
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)("Divno", _divno, value)
        End Set
    End Property
    Private _divname As String
    Public Property Divname() As String
        Get
            Return _divname
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("Divname", _divname, value)
        End Set
    End Property
    Private _divaddr1 As String
    Public Property Address1() As String
        Get
            Return _divaddr1
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("Address1", _divaddr1, value)
        End Set
    End Property


End Class
