﻿Imports System.Data.Odbc
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Module Sync
    Public cn As OdbcConnection
    Dim _lastSync As DateTime
    Dim iCounter As Integer = 0
    Dim iTop As Integer = 0
    Dim iLeft As Integer = 0

    Sub Main()
        If Environment.MachineName = "JOHN-PC2" Then
            ConnectionHelper.ConnectionString = "XpoProvider=MSSqlServer;data source=willow.evacchair.co.uk;initial catalog=Willow;User Id=Willow;Password=6A33%7rq;"
            ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema)
        ElseIf Environment.MachineName = "JOHN-PC" Then
            ConnectionHelper.ConnectionString = "XpoProvider=MSSqlServer;data source=willow.evacchair.co.uk;initial catalog=Willow;User Id=Willow;Password=6A33%7rq;"
            ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema)
        Else
            ConnectionHelper.ConnectionString = "XpoProvider=MSSqlServer;data source=JOHN-PC\SQLEXPRESS2008;integrated security=SSPI;initial catalog=evacremote"
            ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists)
        End If
        Using _session As New UnitOfWork
            ConnectionHelper.Login(_session, "DBA")
        End Using

        cn = New OdbcConnection("DSN=PSCRM 6 Default;UID=DBA;PWD=prospect")
        cn.Open()
        If SyncUsers() = True Then
            SyncAddresses()
            SyncCompanies()
            SyncDivisions()
            SyncContacts()
        End If
        cn.Close()

    End Sub

    Private Function SyncUsers() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork
        Dim _Sync As String = GetSetting("UserTable")
        Dim iRecords As Integer = GetRecordCount("user")

        Console.Write(String.Format("Users     ({0:D5}) ", iRecords))

        If Not String.IsNullOrWhiteSpace(_Sync) Then
            _lastSync = Convert.ToDateTime(_Sync)
        Else
            _lastSync = Convert.ToDateTime("1980-1-1")
        End If
        Str = String.Concat(Str, "SELECT usercode, username, emailaddr ")
        Str = String.Concat(Str, "FROM [user]")
        Str = String.Concat(Str, String.Format("where lastupdatedtimestamp > '{0:yyyy/MM/dd hh:mm}'", _lastSync))

        Dim da As New OdbcDataAdapter(Str, cn)
        Dim dsUsers = New DataSet
        da.Fill(dsUsers, "Results")

        If dsUsers.Tables.Count > 0 Then
            If dsUsers.Tables(0).Rows.Count = 0 Then
                Console.Write("UpTo Date. ")
            Else
                Console.Write(String.Format("Changed ({0:D5}) ", dsUsers.Tables(0).Rows.Count))
                iCounter = 0
                iTop = Console.CursorTop
                iLeft = Console.CursorLeft
                For Each orow As DataRow In dsUsers.Tables(0).Rows
                    Dim xuser As User = _session.FindObject(Of User)(CriteriaOperator.Parse("UserCode= ?", orow.Item("usercode")))
                    If xuser Is Nothing Then
                        xuser = New User(_session)
                        xuser.UserCode = orow.Item("usercode")
                        xuser.Email = GetValueorNull(orow, "emailaddr")
                        xuser.username = GetValueorNull(orow, "username")
                        xuser.Save()
                    Else
                        xuser.Email = GetValueorNull(orow, "emailaddr")
                        xuser.username = GetValueorNull(orow, "username")
                        xuser.Save()
                    End If
                    _session.CommitChanges()
                    iCounter = iCounter + 1
                    Console.SetCursorPosition(iLeft, iTop)
                    Console.Write("{0:D5}", iCounter)
                Next
            End If
            SetSetting("UserTable", DateTime.Now)
            Console.WriteLine(" Done.")
            SyncUsers = True
        Else
            Console.WriteLine("Cannot Access User table")
            SyncUsers = False
        End If
    End Function
    Private Function SyncAddresses() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork
        Dim _Sync As String = GetSetting("Addresses")
        Dim iRecords As Integer = GetREcordCount("Address")

        Console.Write(String.Format("Addresses ({0:D5})", iRecords))

        If Not String.IsNullOrWhiteSpace(_Sync) Then
            _lastSync = Convert.ToDateTime(_Sync)
        Else
            _lastSync = Convert.ToDateTime("1980-1-1")
        End If
        Str = "SELECT [addrno],[address1],[address2],[address3],[address4],[postcode] "
        Str = String.Concat(Str, "FROM [Address]")
        Str = String.Concat(Str, String.Format("where lastupdatedtimestamp > '{0:yyyy/MM/dd hh:mm}'", _lastSync))

        Dim da As New OdbcDataAdapter(Str, cn)
        Dim dsAddress = New DataSet
        da.Fill(dsAddress, "Results")

        If dsAddress.Tables.Count > 0 Then
            Console.Write(String.Format(" Changed ({0:D5}) ", dsAddress.Tables(0).Rows.Count))
            iCounter = 0
            iTop = Console.CursorTop
            iLeft = Console.CursorLeft
            Dim xAddress As Address
            For Each orow As DataRow In dsAddress.Tables(0).Rows
                xAddress = _session.FindObject(Of Address)(CriteriaOperator.Parse("addrno= ?", orow.Item("addrno")))
                If xAddress Is Nothing Then
                    xAddress = New Address(_session)
                    xAddress.addrno = orow.Item("addrno")
                End If
                xAddress.Address1 = GetValueorNull(orow, "address1")
                xAddress.Address2 = GetValueorNull(orow, "address2")
                xAddress.Address3 = GetValueorNull(orow, "address3")
                xAddress.Address4 = GetValueorNull(orow, "address4")
                xAddress.PostCode = GetValueorNull(orow, "PostCode")
                xAddress.Save()
                xAddress.Save()
                _session.CommitChanges()
                iCounter = iCounter + 1
                Console.SetCursorPosition(iLeft, iTop)
                Console.Write("{0:D5}", iCounter)
            Next
            SetSetting("Addresses", DateTime.Now)
            SyncAddresses = True
        Else
            Console.WriteLine("Cannot Access Address Table")
            SyncAddresses = False
        End If
        Console.WriteLine(" Done.")
    End Function

    Private Function SyncCompanies() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork
        Dim _Sync As String = GetSetting("CompanyTable")
        Dim iRecords As Integer = GetREcordCount("company")

        Console.Write(String.Format("Companies ({0:D5})", iRecords))

        If Not String.IsNullOrWhiteSpace(_Sync) Then
            _lastSync = Convert.ToDateTime(_Sync)
        Else
            _lastSync = Convert.ToDateTime("1980-1-1")
        End If
        Str = "SELECT [compno],[compname],[comptypecd],[StatusFlag] "
        Str = String.Concat(Str, "FROM [company]")
        Str = String.Concat(Str, String.Format("where lastupdatedtimestamp > '{0:yyyy/MM/dd hh:mm}'", _lastSync))

        Dim da As New OdbcDataAdapter(Str, cn)
        Dim dsCompanies = New DataSet
        da.Fill(dsCompanies, "Results")

        If dsCompanies.Tables.Count > 0 Then
            Console.Write(String.Format(" Changed ({0:D5}) ", dsCompanies.Tables(0).Rows.Count))
            iCounter = 0
            iTop = Console.CursorTop
            iLeft = Console.CursorLeft
            For Each orow As DataRow In dsCompanies.Tables(0).Rows
                Dim xCompany As Company = _session.FindObject(Of Company)(CriteriaOperator.Parse("Compno= ?", orow.Item("compno")))
                If xCompany Is Nothing Then
                    xCompany = New Company(_session)
                    xCompany.Compno = orow.Item("compno")
                    xCompany.Compname = GetValueorNull(orow, "compname")
                    xCompany.StatusFlag = GetValueorNull(orow, "StatusFlag")
                    xCompany.Save()
                Else
                    xCompany.Compname = GetValueorNull(orow, "compname")
                    xCompany.StatusFlag = GetValueorNull(orow, "StatusFlag")
                    xCompany.Save()
                End If
                _session.CommitChanges()
                iCounter = iCounter + 1
                Console.SetCursorPosition(iLeft, iTop)
                Console.Write("{0:D5}", iCounter)
            Next
            SetSetting("CompanyTable", DateTime.Now)
            SyncCompanies = True
        Else
            Console.WriteLine("Cannot Access Company Table")
            SyncCompanies = False
        End If
        Console.WriteLine(" Done.")
    End Function
    Private Function SyncDivisions() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork
        Dim _Sync As String = GetSetting("DivisionTable")

        Dim iRecords As Integer = GetREcordCount("division")
        Console.Write(String.Format("Divisions ({0:D5}) ", iRecords))

        If Not String.IsNullOrWhiteSpace(_Sync) Then
            _lastSync = Convert.ToDateTime(_Sync)
        Else
            _lastSync = Convert.ToDateTime("1980-1-1")
        End If
        Str = "SELECT divno, compno, divname, addrno, division.oprano, phone, notepad, StatusFlag "
        Str = String.Concat(Str, "FROM [division]")
        Str = String.Concat(Str, String.Format("where lastupdatedtimestamp > '{0:yyyy/MM/dd hh:mm}'", _lastSync))

        Dim da As New OdbcDataAdapter(Str, cn)
        Dim dsCompanies = New DataSet
        da.Fill(dsCompanies, "Results")

        If dsCompanies.Tables.Count > 0 Then
            Console.Write(String.Format("Changed ({0:D5}) ", dsCompanies.Tables(0).Rows.Count))
            iCounter = 0
            iTop = Console.CursorTop
            iLeft = Console.CursorLeft
            Dim xDivision As Division
            For Each orow As DataRow In dsCompanies.Tables(0).Rows
                xDivision = _session.FindObject(Of Division)(CriteriaOperator.Parse("Divno= ?", orow.Item("divno")))
                If xDivision Is Nothing Then
                    xDivision = New Division(_session)
                    xDivision.Divno = orow.Item("divno")
                    xDivision.Compno = orow.Item("compno")
                End If
                'xDivision.a.address = _session.FindObject(Of Address)(CriteriaOperator.Parse("addrno= ?", GetValueorNull(orow, "addrno")))
                xDivision.Divname = orow.Item("divname").ToString
                xDivision.Phone = orow.Item("phone").ToString
                xDivision.oprano = orow.Item("oprano").ToString
                xDivision.Notepad = orow.Item("notepad").ToString
                xDivision.StatusFlag = orow.Item("StatusFlag")
                xDivision.Save()
                _session.CommitChanges()
                iCounter = iCounter + 1
                Console.SetCursorPosition(iLeft, iTop)
                Console.Write("{0:D5}", iCounter)
            Next
            SetSetting("DivisionTable", DateTime.Now)
            SyncDivisions = True
        Else
            Console.WriteLine("Cannot Access Division Table")
            SyncDivisions = False
        End If
        Console.WriteLine(" Done.")
    End Function
    Private Function SyncContacts() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork
        Dim _Sync As String = GetSetting("ContactTable")

        Dim iRecords As Integer = GetREcordCount("Contact")
        Console.Write(String.Format("Contacts  ({0:D5}) ", iRecords))

        If Not String.IsNullOrWhiteSpace(_Sync) Then
            _lastSync = Convert.ToDateTime(_Sync)
        Else
            _lastSync = Convert.ToDateTime("1980-1-1")
        End If
        Str = "SELECT [contno],[divno],[surname],[forename],[title],[salutation],[addrno],[email],[notepad],[jobtitle],[primephone],[StatusFlag] "
        Str = String.Concat(Str, "FROM [Contact]")
        Str = String.Concat(Str, String.Format("where lastupdatedtimestamp > '{0:yyyy/MM/dd hh:mm}'", _lastSync))

        Dim da As New OdbcDataAdapter(Str, cn)
        Dim dsContacts = New DataSet
        da.Fill(dsContacts, "Results")

        If dsContacts.Tables.Count > 0 Then
            Console.Write(String.Format("Changed ({0:D5}) ", dsContacts.Tables(0).Rows.Count))
            iCounter = 0
            iTop = Console.CursorTop
            iLeft = Console.CursorLeft
            Dim xContact As Contact
            For Each orow As DataRow In dsContacts.Tables(0).Rows
                xContact = _session.FindObject(Of Contact)(CriteriaOperator.Parse("Contno= ?", orow.Item("divno")))
                If xContact Is Nothing Then
                    xContact = New Contact(_session)
                    xContact.Contno = orow.Item("contno")
                    xContact.Divno = orow.Item("divno")
                End If

                xContact.Surname = GetValueorNull(orow, "surname")
                xContact.forename = GetValueorNull(orow, "forename")
                xContact.Title = GetValueorNull(orow, "title")
                xContact.Salutation = GetValueorNull(orow, "salutation")
                xContact.Address = _session.FindObject(Of Address)(CriteriaOperator.Parse("addrno= ?", GetValueorNull(orow, "addrno")))
                xContact.Email = GetValueorNull(orow, "email")
                xContact.JobTitle = GetValueorNull(orow, "jobtitle")
                xContact.Phone = GetValueorNull(orow, "primephone")
                xContact.Notepad = GetValueorNull(orow, "notepad")
                xContact.StatusFlag = GetValueorNull(orow, "StatusFlag")
                xContact.Save()
                _session.CommitChanges()
                iCounter = iCounter + 1
                Console.SetCursorPosition(iLeft, iTop)
                Console.Write("{0:D5}", iCounter)
            Next
            SetSetting("ContactTable", DateTime.Now)
            SyncContacts = True
        Else
            Console.WriteLine("Cannot Access Contacts Table")
            SyncContacts = False
        End If
        Console.WriteLine(" Done.")
    End Function
    Private Function GetValueorNull(ByRef dr As DataRow, ByRef _field As String) As Object
        If Not dr.IsNull(_field) Then
            Return dr.Item(_field)
        Else
            Return Nothing
        End If
    End Function
    Private Function GetRecordCount(_table As String) As Integer
        Dim recordcount As New OdbcCommand()
        recordcount.CommandText = String.Format("select count(*) from [{0}]", _table)
        recordcount.CommandType = CommandType.Text
        recordcount.Connection = cn
        Dim x = recordcount.ExecuteScalar
        Return x

    End Function
End Module
