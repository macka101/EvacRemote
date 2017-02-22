﻿Imports System.Data.Odbc
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports Esso.Data
Imports System.Timers

Module Sync
    Public cn As OdbcConnection
    Dim _lastSync As DateTime
    Dim iCounter As Integer = 0
    Dim iTop As Integer = 0
    Dim iLeft As Integer = 0
    Dim iTimerTop As Integer = 0
    Dim iTimerLeft As Integer = 0

    Dim _timer1 As New Timer
    Dim _startTime As DateTime
    Dim _ResetAll As Boolean = False
    Dim _ResetUser As Boolean = True
    Dim _ResetAddress As Boolean = False
    Dim _ResetCompany As Boolean = False
    Dim _ResetDivision As Boolean = False
    Dim _ResetContact As Boolean = False
    Dim _ResetDiary As Boolean = False


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
            Dim _user = _session.FindObject(Of User)(CriteriaOperator.Parse("UserCode = ?", "DBA"))
            ConnectionHelper.Login(_session, _user)
            _session.UpdateSchema()
        End Using

        cn = New OdbcConnection("DSN=PSCRM 6 Default;UID=DBA;PWD=prospect")
        ' cn = New OdbcConnection("DSN=PSCRM 6 Demonstration;UID=DBA;PWD=prospect")
        cn.Open()
        _startTime = DateTime.Now
        Console.Write(String.Format("Started {0:hh:mm}", DateTime.Now))
        iTimerTop = Console.CursorTop
        iTimerLeft = Console.CursorLeft
        Console.WriteLine("")
        _timer1.Interval = 1000
        AddHandler _timer1.Elapsed, AddressOf UpdateTimer

        _timer1.Start() 'Timer starts functioning

        If SyncUsers() = True Then
            SyncReportOptions()
            SyncEngineers()
            SyncAddresses()
            SyncCompanies()
            SyncDivisions()
            SyncContacts()
            SyncDiary()
        End If
        _timer1.Stop()
        cn.Close()

    End Sub
    Private Sub SyncReportOptions()
        Dim _reportOption As ReportOption
        Dim _session As New UnitOfWork

        _reportOption = _session.FindObject(Of ReportOption)(CriteriaOperator.Parse("OptNo= 1"))
        If _reportOption Is Nothing Then
            _reportOption = New ReportOption(_session)
            _reportOption.Optno = 1
            _reportOption.Text = "Our survey has highlighted your building/s as being either heritage or listed.  Due to the sensitive nature of your building we have selected products and storage solutions that allow you to provide emergency evacuation solutions whilst allowing the building to be unaffected."
            _reportOption.Save()
        End If
        _reportOption = _session.FindObject(Of ReportOption)(CriteriaOperator.Parse("OptNo= 1"))
        If _reportOption Is Nothing Then
            _reportOption = New ReportOption(_session)
            _reportOption.Optno = 2
            _reportOption.Text = "Within the healthcare sector organisations often operate on a progressive horizontal evacuation procedure which ultimately could require the use of a stair case to fully evacuate the building totally.  A mix of seated chair evacuation and fully horizontal evacuation equipment could be required, to allow total coverage of the conditions you might encounter."
            _reportOption.Save()
        End If
        _reportOption = _session.FindObject(Of ReportOption)(CriteriaOperator.Parse("OptNo= 1"))
        If _reportOption Is Nothing Then
            _reportOption = New ReportOption(_session)
            _reportOption.Optno = 3
            _reportOption.Text = "Due to the unique evacuation situations faced in educational environments we have selected equipment that will provide evacuation solutions suitable for all body sizes.  By selecting equipment that has been hand built with your particular situation in mind you can be confident your chairs will be a reliable partner in your emergency evacuation planning."
            _reportOption.Save()
        End If
        _session.CommitChanges()
    End Sub

    Private Function SyncUsers() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork
        Dim iRecords As Integer = GetRecordCount("user")

        Console.Write(String.Format("Users     ({0:D5}) ", iRecords))

        _lastSync = _session.ExecuteScalar("SELECT max([lastupdatedtimestamp])  FROM [Willow].[dbo].[User]")

        If _lastSync = DateTime.MinValue Or _ResetUser = True Then
            _lastSync = Convert.ToDateTime("1980-1-1")
        End If

        Str = String.Concat(Str, "SELECT [user].usercode, username, emailaddr, lastupdatedtimestamp,directphone,winusername ")
        Str = String.Concat(Str, "FROM [user] ")
        Str = String.Concat(Str, "left outer Join user_intlogin ON [user].usercode = user_intlogin.usercode ")
        Str = String.Concat(Str, String.Format("where lastupdatedtimestamp > '{0:yyyy/MM/dd HH:mm}' order by lastupdatedtimestamp", _lastSync))

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
                        xuser.winusername = GetValueorNull(orow, "winusername")
                        xuser.directphone = GetValueorNull(orow, "directphone")

                    Else
                        xuser.Email = GetValueorNull(orow, "emailaddr")
                        xuser.username = GetValueorNull(orow, "username")
                        xuser.winusername = GetValueorNull(orow, "winusername")
                        xuser.directphone = GetValueorNull(orow, "directphone")
                    End If
                    xuser.lastupdatedtimestamp = orow.Item("lastupdatedtimestamp")
                    xuser.Save()
                    _session.CommitChanges()

                    iCounter = iCounter + 1
                    Console.SetCursorPosition(iLeft, iTop)
                    Console.Write("{0:D5}", iCounter)
                Next
            End If
            Console.WriteLine(" Done." & Microsoft.VisualBasic.Strings.StrDup(40, " "))
            SyncUsers = True
        Else
            Console.WriteLine("Cannot Access User table")
            SyncUsers = False
        End If
    End Function
    Private Function SyncEngineers() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork
        Dim iRecords As Integer = GetRecordCount("engineer_locations")

        Console.Write(String.Format("Engineers ({0:D5}) ", iRecords))

        Str = String.Concat(Str, "SELECT * ")
        Str = String.Concat(Str, "FROM [engineer_locations] ")

        Dim da As New OdbcDataAdapter(Str, cn)
        Dim dsEngineers = New DataSet
        da.Fill(dsEngineers, "Results")

        If dsEngineers.Tables.Count > 0 Then
            If dsEngineers.Tables(0).Rows.Count = 0 Then
                Console.Write("UpTo Date. ")
            Else
                Console.Write(String.Format("Changed ({0:D5}) ", dsEngineers.Tables(0).Rows.Count))
                iCounter = 0
                iTop = Console.CursorTop
                iLeft = Console.CursorLeft
                For Each orow As DataRow In dsEngineers.Tables(0).Rows
                    Dim xEngineer As Engineer = _session.FindObject(Of Engineer)(CriteriaOperator.Parse("EngineerNo= ?", orow.Item("engineerno")))
                    If xEngineer Is Nothing Then
                        xEngineer = New Engineer(_session)
                        xEngineer.EngineerNo = orow.Item("engineerno")
                        xEngineer.EngineerCode = GetValueorNull(orow, "engineer")
                        xEngineer.EngineerName = GetValueorNull(orow, "engineer_name")

                    Else
                        xEngineer.EngineerCode = GetValueorNull(orow, "engineer")
                        xEngineer.EngineerName = GetValueorNull(orow, "engineer_name")
                    End If
                    xEngineer.Save()
                    _session.CommitChanges()

                    iCounter = iCounter + 1
                    Console.SetCursorPosition(iLeft, iTop)
                    Console.Write("{0:D5}", iCounter)
                Next
            End If
            Console.WriteLine(" Done." & Microsoft.VisualBasic.Strings.StrDup(40, " "))
            SyncEngineers = True
        Else
            Console.WriteLine("Cannot Access User table")
            SyncEngineers = False
        End If
    End Function
    Private Function SyncAddresses() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork

        Dim iRecords As Integer = GetRecordCount("Address")

        Console.Write(String.Format("Addresses ({0:D5})", iRecords))

        _lastSync = _session.ExecuteScalar("SELECT max([lastupdatedtimestamp])  FROM [Willow].[dbo].[Address]")

        If _lastSync = DateTime.MinValue Or _ResetAll = True Or _ResetAddress = True Then
            _lastSync = Convert.ToDateTime("1980-1-1")
        End If

        Str = "SELECT [addrno],[address1],[address2],[address3],[address4],[postcode],lastupdatedtimestamp "
        Str = String.Concat(Str, "FROM [Address]")
        Str = String.Concat(Str, String.Format("where lastupdatedtimestamp > '{0:yyyy/MM/dd HH:mm}' order by lastupdatedtimestamp", _lastSync))

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
                xAddress.lastupdatedtimestamp = orow.Item("lastupdatedtimestamp")
                xAddress.Save()
                _session.CommitChanges()
                iCounter = iCounter + 1
                Console.SetCursorPosition(iLeft, iTop)
                Console.Write("{0:D5}", iCounter)
            Next
            SyncAddresses = True
        Else
            Console.WriteLine("Cannot Access Address Table")
            SyncAddresses = False
        End If
        Console.WriteLine(" Done." & Microsoft.VisualBasic.Strings.StrDup(40, " "))
    End Function

    Private Function SyncCompanies() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork

        Dim iRecords As Integer = GetRecordCount("company")

        Console.Write(String.Format("Companies ({0:D5})", iRecords))

        _lastSync = _session.ExecuteScalar("SELECT max([lastupdatedtimestamp])  FROM [Willow].[dbo].[Company]")

        If _lastSync = DateTime.MinValue Or _ResetAll = True Or _ResetCompany = True Then
            _lastSync = Convert.ToDateTime("1980-1-1")
        End If


        Str = "SELECT [compno],[compname],[comptypecd],[StatusFlag],[lastupdatedtimestamp]"
        Str = String.Concat(Str, "FROM [company] ")
        Str = String.Concat(Str, String.Format("where lastupdatedtimestamp > '{0:yyyy/MM/dd HH:mm}' order by lastupdatedtimestamp", _lastSync))

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

                Else
                    xCompany.Compname = GetValueorNull(orow, "compname")
                    xCompany.StatusFlag = GetValueorNull(orow, "StatusFlag")

                End If
                xCompany.lastupdatedtimestamp = orow.Item("lastupdatedtimestamp")
                xCompany.Save()
                _session.CommitChanges()
                iCounter = iCounter + 1
                Console.SetCursorPosition(iLeft, iTop)
                Console.Write("{0:D5}", iCounter)
            Next
            SyncCompanies = True
        Else
            Console.WriteLine("Cannot Access Company Table")
            SyncCompanies = False
        End If
        Console.WriteLine(" Done." & Microsoft.VisualBasic.Strings.StrDup(40, " "))
    End Function
    Private Function SyncDivisions() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork

        Dim iRecords As Integer = GetRecordCount("division")
        Console.Write(String.Format("Divisions ({0:D5}) ", iRecords))

        _lastSync = _session.ExecuteScalar("SELECT max([lastupdatedtimestamp])  FROM [Willow].[dbo].[Division]")

        If _lastSync = DateTime.MinValue Or _ResetAll = True Or _ResetDivision = True Then
            _lastSync = Convert.ToDateTime("1980-1-1")
        End If

        Str = "SELECT divno, compno, divname, addrno, division.oprano, phone, notepad, StatusFlag,lastupdatedtimestamp "
        Str = String.Concat(Str, "FROM [division]")
        Str = String.Concat(Str, String.Format("where lastupdatedtimestamp > '{0:yyyy/MM/dd HH:mm}' order by lastupdatedtimestamp", _lastSync))

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
                xDivision = _session.FindObject(Of Division)(CriteriaOperator.Parse("DivNo= ?", orow.Item("divNo")))
                If xDivision Is Nothing Then
                    xDivision = New Division(_session)
                    xDivision.DivNo = orow.Item("divno")
                    xDivision.CompNo = orow.Item("compno")
                End If
                'xDivision.a.address = _session.FindObject(Of Address)(CriteriaOperator.Parse("addrno= ?", GetValueorNull(orow, "addrno")))
                xDivision.Divname = orow.Item("divname").ToString
                xDivision.Phone = orow.Item("phone").ToString
                xDivision.oprano = orow.Item("oprano").ToString
                xDivision.Notepad = orow.Item("notepad").ToString
                xDivision.StatusFlag = orow.Item("StatusFlag")
                xDivision.lastupdatedtimestamp = orow.Item("lastupdatedtimestamp")
                xDivision.Save()
                _session.CommitChanges()
                iCounter = iCounter + 1
                Console.SetCursorPosition(iLeft, iTop)
                Console.Write("{0:D5}", iCounter)
            Next
            SyncDivisions = True
        Else
            Console.WriteLine("Cannot Access Division Table")
            SyncDivisions = False
        End If
        Console.WriteLine(" Done." & Microsoft.VisualBasic.Strings.StrDup(40, " "))
    End Function
    Private Function SyncContacts() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork

        Dim iRecords As Integer = GetRecordCount("Contact")
        Console.Write(String.Format("Contacts  ({0:D5}) ", iRecords))

        _lastSync = _session.ExecuteScalar("SELECT max([lastupdatedtimestamp])  FROM [Willow].[dbo].[Contact]")

        If _lastSync = DateTime.MinValue Or _ResetAll = True Or _ResetContact = True Then
            _lastSync = Convert.ToDateTime("1980-1-1")
        End If

        Str = "SELECT [contno],[divno],[surname],[forename],[title],[salutation],[addrno],[email],[notepad],[jobtitle],[primephone],[StatusFlag],[lastupdatedtimestamp] "
        Str = String.Concat(Str, "FROM [Contact]")
        Str = String.Concat(Str, String.Format("where lastupdatedtimestamp > '{0:yyyy/MM/dd HH:mm}' order by lastupdatedtimestamp", _lastSync))

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
                xContact = _session.FindObject(Of Contact)(CriteriaOperator.Parse("ContNo= ?", orow.Item("contno")))
                If xContact Is Nothing Then
                    xContact = New Contact(_session)
                End If
                xContact.ContNo = orow.Item("contno")
                xContact.DivNo = orow.Item("divno")
                xContact.Division = _session.FindObject(Of Division)(CriteriaOperator.Parse("DivNo= ?", xContact.DivNo))
                xContact.Surname = GetValueorNull(orow, "surname")
                xContact.Forename = GetValueorNull(orow, "forename")
                xContact.Title = GetValueorNull(orow, "title")
                xContact.Salutation = GetValueorNull(orow, "salutation")
                xContact.Address = _session.FindObject(Of Address)(CriteriaOperator.Parse("addrno= ?", GetValueorNull(orow, "addrno")))
                xContact.Email = GetValueorNull(orow, "email")
                xContact.JobTitle = GetValueorNull(orow, "jobtitle")
                xContact.Phone = GetValueorNull(orow, "primephone")
                xContact.Notepad = GetValueorNull(orow, "notepad")
                xContact.StatusFlag = GetValueorNull(orow, "StatusFlag")
                If xContact.ContNo = 0 Or xContact.DivNo = 0 Then
                    xContact.StatusFlag = "D"
                End If
                xContact.lastupdatedtimestamp = orow.Item("lastupdatedtimestamp")
                xContact.Save()
                _session.CommitChanges()
                iCounter = iCounter + 1
                Console.SetCursorPosition(iLeft, iTop)
                Console.Write("{0:D5}", iCounter)
            Next
            SyncContacts = True
        Else
            Console.WriteLine("Cannot Access Contacts Table")
            SyncContacts = False
        End If
        Console.WriteLine(" Done." & Microsoft.VisualBasic.Strings.StrDup(40, " "))
    End Function
    Private Function SyncDiary() As Boolean
        Dim Str As String = Nothing
        Dim _session As New UnitOfWork

        Dim iRecords As Integer = GetRecordCount("central_diary")
        Console.Write(String.Format("Diary     ({0:D5}) ", iRecords))

        _lastSync = _session.ExecuteScalar("SELECT max([lastupdatedtimestamp])  FROM [Willow].[dbo].[CentralDiary]")

        If _lastSync = DateTime.MinValue Or _ResetAll = True Or _ResetDiary = True Then
            _lastSync = Convert.ToDateTime("1980-1-1")
        End If
        Str = "SELECT central_diary.*,  lead.contno, contact.divno, lead_xtra.no_of_chairs as noChairs "
        Str = String.Concat(Str, "FROM central_diary INNER JOIN ")
        Str = String.Concat(Str, "lead ON central_diary.Leadno = lead.leadno INNER JOIN ")
        Str = String.Concat(Str, "lead_xtra ON central_diary.Leadno = lead_xtra.leadno INNER JOIN ")
        Str = String.Concat(Str, "contact ON lead.contno = contact.contno ")

        Str = String.Concat(Str, String.Format("where central_diary.lastupdatedtimestamp > '{0:yyyy/MM/dd HH:mm}' order by central_diary.lastupdatedtimestamp", _lastSync))

        Dim da As New OdbcDataAdapter(Str, cn)
        Dim dsDiary = New DataSet
        da.Fill(dsDiary, "Results")

        If dsDiary.Tables.Count > 0 Then
            Console.Write(String.Format("Changed ({0:D5}) ", dsDiary.Tables(0).Rows.Count))
            iCounter = 0
            iTop = Console.CursorTop
            iLeft = Console.CursorLeft
            Dim xDiary As CentralDiary
            For Each orow As DataRow In dsDiary.Tables(0).Rows
                xDiary = _session.FindObject(Of CentralDiary)(CriteriaOperator.Parse("CentralDiaryNo= ?", orow.Item("central_diaryno")))
                If xDiary Is Nothing Then
                    xDiary = New CentralDiary(_session)
                    xDiary.CentralDiaryNo = orow.Item("central_diaryno")
                End If
                xDiary.Division = _session.FindObject(Of Division)(CriteriaOperator.Parse("DivNo= ?", GetValueorNull(orow, "divno")))
                xDiary.Contact = _session.FindObject(Of Contact)(CriteriaOperator.Parse("ContNo= ?", GetValueorNull(orow, "contno")))

                xDiary.AllDay = GetValueorNull(orow, "AllDay")
                xDiary.AppDescription = GetValueorNull(orow, "AppDescription")
                xDiary.AppLocation = Left(GetValueorNull(orow, "AppLocation"), 8)
                xDiary.BookedDate = GetValueorNull(orow, "BookedDate")
                xDiary.EndDate = GetValueorNull(orow, "EndDate")
                xDiary.Label = GetValueorNull(orow, "Label")
                xDiary.Leadno = GetValueorNull(orow, "Leadno")
                xDiary.NoOfChairs = GetValueorNull(orow, "noChairs")
                xDiary.Note = GetValueorNull(orow, "Note")
                xDiary.OutlookEntryID = GetValueorNull(orow, "OutlookEntryID")
                xDiary.Subject = GetValueorNull(orow, "Subject")
                xDiary.UserId = GetValueorNull(orow, "UserId")
                xDiary.lastupdatedtimestamp = orow.Item("lastupdatedtimestamp")
                xDiary.Save()
                _session.CommitChanges()
                iCounter = iCounter + 1
                Console.SetCursorPosition(iLeft, iTop)
                Console.Write("{0:D5}", iCounter)
            Next
            SyncDiary = True
        Else
            Console.WriteLine("Cannot Access Diary Table")
            SyncDiary = False
        End If
        Console.WriteLine(" Done." & Microsoft.VisualBasic.Strings.StrDup(20, " "))
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

    Private Sub UpdateTimer(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iTop As Integer = Console.CursorTop
        Dim iLeft As Integer = Console.CursorLeft

        Console.SetCursorPosition(iTimerLeft, iTimerTop)
        Dim elapsed_time As TimeSpan
        elapsed_time = DateTime.Now.Subtract(_startTime)
        Console.Write(String.Format(" Taken ({0} Secs)                ", CInt(elapsed_time.TotalSeconds)))
        Console.SetCursorPosition(iLeft, iTop)
    End Sub
End Module
