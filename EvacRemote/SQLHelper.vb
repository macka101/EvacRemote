Imports System
Imports System.ServiceProcess
Imports System.Data.SqlClient

Module SQLHelper

    Private _home As String = "data source=willow.evacchair.co.uk;initial catalog=willow;User Id=willow;Password=6A33%7rq;"
    Private _localConnection As String = "Data Source=.\SQLEXPRESS;Trusted_Connection=True;Connect Timeout=30"
    Private _local As String = "Data Source=.\SQLEXPRESS;initial catalog=Willow;Trusted_Connection=True;Connect Timeout=30"
    Public Function IsSQLExpressInstalled() As Boolean
        Dim myServiceName As String = "MSSQL$SQLEXPRESS" 'service name of SQL Server Express
        Dim status As String  'service status (For example, Running or Stopped)
        Dim mySC As ServiceController

        '  Console.WriteLine("Service: " & myServiceName)

        'display service status: For example, Running, Stopped, or Paused
        mySC = New ServiceController(myServiceName)
        Try
            status = mySC.Status.ToString
            IsSQLExpressInstalled = True
        Catch ex As Exception
            IsSQLExpressInstalled = False
            '   Console.WriteLine("Service not found. It is probably not installed. [exception=" & ex.Message & "]")
            '  Console.ReadLine()
            End
        End Try
        'Console.WriteLine("Service status : " & status)

        'if service is Stopped or StopPending, you can run it with the following code.
        If mySC.Status.Equals(ServiceControllerStatus.Stopped) Or mySC.Status.Equals(ServiceControllerStatus.StopPending) Then
            Try
                '     Console.WriteLine("Starting the service...")
                mySC.Start()
                mySC.WaitForStatus(ServiceControllerStatus.Running)
                '    Console.WriteLine("The service is now " & mySC.Status.ToString)

            Catch ex As Exception
                'Console.WriteLine("Error in starting the service: " & ex.Message)
                IsSQLExpressInstalled = False
            End Try
        End If

        'Console.WriteLine("Press a key to end the application...")
        'Console.ReadLine()
        End
        Return True
    End Function

    Public Function CreatePublication() As Boolean

        ExecuteCommand(_home, String.Format("exec sp_addmergesubscription @publication = N'WillowPub', @subscriber = N'{0}\SQLEXPRESS', @subscriber_db = N'Willow', @subscription_type = N'pull', @subscriber_type = N'local', @subscription_priority = 0, @sync_type = N'Automatic'", Environment.MachineName))

    End Function
    Public Function CreateSubscription() As Boolean

        ExecuteCommand(_local, "EXEC sp_addmergepullsubscription @publisher = 'EVACSERVER1\WILLOW', 	@publication = 'WillowPub', @publisher_db = 'Willow';")
        'ExecuteCommand(_local, "EXEC sp_addmergepullsubscription_agent 	@publisher = 'EVACSERVER1\WILLOW', 	@publisher_db = 'Willow', 	@publication = 'WillowPub', 	@distributor = 'EVACSERVER1\WILLOW', 	@job_login = 'EvacRemote', 	@job_password = '6A33%7rq',	@use_web_sync = 1,	@internet_security_mode = 0,	@internet_url = 'https://willow.evacchair.co.uk/SQLReplication',	@internet_login = 'EvacRemote',	@internet_password ='6A33%7rq';")
        ExecuteCommand(_local, "EXEC sp_addmergepullsubscription_agent 	@publisher = 'EVACSERVER1\WILLOW', 	@publisher_db = 'Willow', 	@publication = 'WillowPub', 	@distributor = 'EVACSERVER1\WILLOW', @subscriber_security_mode = 1,	@use_web_sync = 1,	@internet_security_mode = 0,	@internet_url = 'https://willow.evacchair.co.uk/SQLReplication',	@internet_login = 'EvacRemote',	@internet_password ='6A33%7rq';")
    End Function
    Public Function DBExists() As Integer
        Dim con As SqlConnection = New SqlConnection(_localConnection)
        Dim x As Integer = 0
        Try
            Dim cmd As SqlCommand = New SqlCommand("IF EXISTS (SELECT name FROM master.sys.databases WHERE name = N'Willow') Select 1 else select 0", con)
            con.Open()
            x = cmd.ExecuteScalar()
        Catch ex As Exception
            x = 0
        End Try

        con.Close()
        Return x
    End Function
    Public Function DBCreate() As Integer
        Dim con As SqlConnection = New SqlConnection(_localConnection)
        Dim x As Integer = 0
        Try
            Dim cmd As SqlCommand = New SqlCommand("CREATE DATABASE Willow;", con)
            con.Open()
            x = cmd.ExecuteScalar()
        Catch ex As Exception
            x = 0
        End Try

        con.Close()
        Return x
    End Function
    Public Sub ExecuteCommand(_connection As String, _command As String)
        Dim con As SqlConnection = New SqlConnection(_connection)
        Dim cmd As SqlCommand = New SqlCommand(_command, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
End Module
