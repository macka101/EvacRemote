Imports System
Imports System.ServiceProcess
Imports System.Data.SqlClient

Module SQLHelper

    Private _home As String = "Data Source=EVAC2K8;initial catalog=evacremote;User Id=EvacRemote;Password=fatbeam64;Connect Timeout=30"
    Private _localConnection As String = "Data Source=.\SQLEXPRESS;Trusted_Connection=True;Connect Timeout=30"
    Private _local As String = "Data Source=.\SQLEXPRESS;initial catalog=evacremote;Trusted_Connection=True;Connect Timeout=30"
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

        ExecuteCommand(_home, String.Format("exec sp_addmergesubscription @publication = N'EvacRemotePub', @subscriber = N'{0}\SQLEXPRESS', @subscriber_db = N'EvacRemote', @subscription_type = N'pull', @subscriber_type = N'local', @subscription_priority = 0, @sync_type = N'Automatic'", Environment.MachineName))

    End Function
    Public Function CreateSubscription() As Boolean

        ExecuteCommand(_local, "exec sp_addmergepullsubscription @publisher = N'EVAC2K8.evacchair.net', @publication = N'EvacRemotePub', @publisher_db = N'EvacRemote', @subscriber_type = N'Local', @subscription_priority = 0, @description = N'', @sync_type = N'Automatic'")
        ExecuteCommand(_local, "exec sp_addmergepullsubscription_agent @publisher = N'EVAC2K8.evacchair.net', @publisher_db = N'EvacRemote', @publication = N'EvacRemotePub', @distributor = N'EVAC2K8.evacchair.net', @distributor_security_mode = 0, @distributor_login = N'EvacRemote', @distributor_password = N'fatbeam64', @enabled_for_syncmgr = N'True', @frequency_type = 4, @frequency_interval = 1, @frequency_relative_interval = 1, @frequency_recurrence_factor = 0, @frequency_subday = 8, @frequency_subday_interval = 1, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 99991231, @alt_snapshot_folder = N'', @working_directory = N'', @use_ftp = N'False', @job_login = null, @job_password = null, @publisher_security_mode = 0, @publisher_login = N'EvacRemote', @publisher_password =  N'fatbeam64', @use_interactive_resolver = N'False', @dynamic_snapshot_location = null, @use_web_sync = 0")

    End Function
    Public Function DBExists() As Integer
        Dim con As SqlConnection = New SqlConnection(_localConnection)
        Dim x As Integer = 0
        Try
            Dim cmd As SqlCommand = New SqlCommand("IF EXISTS (SELECT name FROM master.sys.databases WHERE name = N'EvacRemote') Select 1 else select 0", con)
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
            Dim cmd As SqlCommand = New SqlCommand("CREATE DATABASE EvacRemote;", con)
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
