Imports System.Data.Odbc
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
            ConnectionHelper.ConnectionString = "XpoProvider=MSSqlServer;data source=EVAC2K8;initial catalog=EvacRemote;User Id=jmolloy;Password=6A33%7rq;"
            ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema)
        ElseIf Environment.MachineName = "JOHN-PC" Then
            ConnectionHelper.ConnectionString = "XpoProvider=MSSqlServer;data source=EVAC2K8;integrated security=SSPI;initial catalog=evacremote"
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
                Console.Write("Users UpTo Date. ")
            Else
                Console.Write(String.Format("Users            ({0:D5}) ", dsUsers.Tables(0).Rows.Count))
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
                Next
            End If
            SetSetting("UserTable", DateTime.Now)
            Console.WriteLine("")
            SyncUsers = True
        Else
            Console.WriteLine("Cannot Access User table")
            SyncUsers = False
        End If
    End Function
    Private Function SyncCompanies() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork
        Dim _Sync As String = GetSetting("CompanyTable")
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
            Console.Write(String.Format("Companies ({0:D5}) ", dsCompanies.Tables(0).Rows.Count))
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
        Console.WriteLine("")
    End Function
    Private Function SyncDivisions() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork
        Dim _Sync As String = GetSetting("DivisionTable")
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
            Console.Write(String.Format("Divisions ({0:D5}) ", dsCompanies.Tables(0).Rows.Count))
            iCounter = 0
            iTop = Console.CursorTop
            iLeft = Console.CursorLeft
            For Each orow As DataRow In dsCompanies.Tables(0).Rows
                Dim xCompany As Division = _session.FindObject(Of Division)(CriteriaOperator.Parse("Divno= ?", orow.Item("divno")))
                If xCompany Is Nothing Then
                    xCompany = New Division(_session)
                    xCompany.Divno = orow.Item("divno")
                    xCompany.Compno = orow.Item("compno")
                    xCompany.Divname = orow.Item("divname").ToString
                    xCompany.Phone = orow.Item("phone").ToString
                    xCompany.oprano = orow.Item("oprano").ToString
                    xCompany.Notepad = orow.Item("notepad").ToString
                    xCompany.StatusFlag = orow.Item("StatusFlag")
                    xCompany.Save()
                Else
                    xCompany.Divname = orow.Item("divname").ToString
                    xCompany.Phone = orow.Item("phone").ToString
                    xCompany.oprano = orow.Item("oprano").ToString
                    xCompany.Notepad = orow.Item("notepad").ToString
                    xCompany.StatusFlag = orow.Item("StatusFlag")
                    xCompany.Save()
                End If
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
        Console.WriteLine("")
    End Function
    Private Function SyncContacts() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork
        Dim _Sync As String = GetSetting("ContactTable")
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
            Console.Write(String.Format("Contacts ({0:D5}) ", dsContacts.Tables(0).Rows.Count))
            iCounter = 0
            iTop = Console.CursorTop
            iLeft = Console.CursorLeft
            For Each orow As DataRow In dsContacts.Tables(0).Rows
                Dim xContact As Contact = _session.FindObject(Of Contact)(CriteriaOperator.Parse("Contno= ?", orow.Item("divno")))
                If xContact Is Nothing Then
                    xContact = New Contact(_session)
                    xContact.Contno = orow.Item("contno")
                    xContact.Divno = orow.Item("divno")
                    xContact.Surname = GetValueorNull(orow, "surname")
                    xContact.forename = GetValueorNull(orow, "forename")
                    xContact.Title = GetValueorNull(orow, "title")
                    xContact.Salutation = GetValueorNull(orow, "salutation")
                    xContact.Addrno = GetValueorNull(orow, "addrno")
                    xContact.Email = GetValueorNull(orow, "email")
                    xContact.JobTitle = GetValueorNull(orow, "jobtitle")
                    xContact.Phone = GetValueorNull(orow, "primephone")
                    xContact.Notepad = GetValueorNull(orow, "notepad")
                    xContact.StatusFlag = GetValueorNull(orow, "StatusFlag")
                    xContact.Save()
                Else
                    xContact.Surname = GetValueorNull(orow, "surname")
                    xContact.forename = GetValueorNull(orow, "forename")
                    xContact.Title = GetValueorNull(orow, "title")
                    xContact.Salutation = GetValueorNull(orow, "salutation")
                    xContact.Addrno = GetValueorNull(orow, "addrno")
                    xContact.Email = GetValueorNull(orow, "email")
                    xContact.JobTitle = GetValueorNull(orow, "jobtitle")
                    xContact.Phone = GetValueorNull(orow, "primephone")
                    xContact.Notepad = GetValueorNull(orow, "notepad")
                    xContact.StatusFlag = GetValueorNull(orow, "StatusFlag")
                    xContact.Save()
                End If
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
        Console.WriteLine("")
    End Function
    Private Function GetValueorNull(ByRef dr As DataRow, ByRef _field As String) As Object
        If Not dr.IsNull(_field) Then
            Return dr.Item(_field)
        Else
            Return Nothing
        End If



    End Function
End Module
