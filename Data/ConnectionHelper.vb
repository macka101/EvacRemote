'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace Esso.Data


    Public Class ConnectionHelper
        Public Shared ConnectionString As String = "XpoProvider=MSSqlServer;data source=EVAC-DATA;integrated security=SSPI;initial catalog=Willow"
        Public Shared _CurrentUser As User
        Public Shared Sub Connect(ByVal autoCreationOption As DB.AutoCreateOption)

            'Dim ds As DevExpress.Xpo.DB.InMemoryDataStore = New DevExpress.Xpo.DB.InMemoryDataStore()
            'XpoDefault.DataLayer = New SimpleDataLayer(ds)

            XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionString, autoCreationOption)
            XpoDefault.Session = Nothing



        End Sub
        Public Shared Function GetConnectionProvider(ByVal autoCreationOption As DB.AutoCreateOption) As DB.IDataStore
            Return XpoDefault.GetConnectionProvider(ConnectionString, autoCreationOption)
        End Function
        Public Shared Function GetConnectionProvider(ByVal autoCreationOption As DB.AutoCreateOption, ByRef objectsToDisposeOnDisconnect() As IDisposable) As DB.IDataStore
            Return XpoDefault.GetConnectionProvider(ConnectionString, autoCreationOption, objectsToDisposeOnDisconnect)
        End Function
        Public Shared Function GetDataLayer(ByVal autoCreationOption As DB.AutoCreateOption) As IDataLayer
            Return XpoDefault.GetDataLayer(ConnectionString, autoCreationOption)
        End Function
        Public Shared Function Login(_session As UnitOfWork, ByRef _user As User) As User
            _CurrentUser = _session.FindObject(Of User)(CriteriaOperator.Parse("UserCode= ?", _user.UserCode))
        End Function
        Public Shared Function GetCurrentUser(_session As UnitOfWork) As User
            Return _session.GetObjectByKey(Of User)(_CurrentUser.Oid)
        End Function
        Public Shared Sub CheckForInitialRecords(ByVal session As Session)
            Using saver As New UnitOfWork(session.DataLayer)
                saver.UpdateSchema()
                CheckForTables(saver)
                Try
                    saver.CommitChanges()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try

            End Using
        End Sub
        Private Shared Sub CheckForTables(ByVal session As Session)
            Try

                If ((Object.Equals(session.FindObject(Of FieldOption)(CriteriaOperator.Parse("ID =  ?", 1)), Nothing))) Then
                    Dim EObj As New FieldOption(session)
                    EObj.ID = 1
                    EObj.Field = eField.BackRest
                    EObj.Description = "Not Present"
                    EObj.Save()
                End If
                If ((Object.Equals(session.FindObject(Of FieldOption)(CriteriaOperator.Parse("ID =  ?", 2)), Nothing))) Then
                    Dim EObj As New FieldOption(session)
                    EObj.ID = 2
                    EObj.Field = eField.Fasteners
                    EObj.Description = "Not Present"
                    EObj.Save()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Sub
    End Class

End Namespace