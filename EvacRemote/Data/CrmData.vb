Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel

<Persistent("Division")> _
Public Class Division
    Inherits XPLiteObject
    <Key, Persistent> _
    Public divno As Integer
    Public compno As Integer
    Public divname As String
    Public addrno As Integer
    Public oprano As String
    Public phone As String
    Public fax As String
    Public employees As String
    Public turnovercd As String
    Public sic As String
    Public opcompany As String
    Public account_mgr As String
    Public website As String
    Public notepad As String
    Public StatusFlag As String
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
End Class
