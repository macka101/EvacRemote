Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

' These namespaces are required.
Imports Microsoft.SqlServer.Replication
Imports Microsoft.SqlServer.Management.Common
Imports System.IO

Partial Public Class FrmSyncronize
    Inherits Form
    ' Define the server, subscription, publication, and database names.
    Private subscriberName As String = Environment.MachineName + "\SQLEXPRESS"
    Private subscriptionDbName As String = "Willow"
    Private publisherName As String = "EVACSERVER1\WILLOW"
    Private publicationName As String = "WillowPub"
    Private publicationDbName As String = "Willow"

    ' Merge agent
    Private agent As MergeSynchronizationAgent

    ' Sync BackgroundWorker
    Private syncBackgroundWorker As BackgroundWorker
    Private _forced As Boolean = False

    Public Sub New(ByVal forced As Boolean)
        InitializeComponent()
        lblSubscriptionName.Text = "[" & subscriptionDbName & "] - [" & publisherName & "] - [" & publicationDbName & "]"
        lblPublicationName.Text = publicationName
        _forced = forced
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartSync()
    End Sub


    Private Sub StartSync()

        ' Instantiate a BackgroundWorker, subscribe to its events, and call RunWorkerAsync()
        syncBackgroundWorker = New BackgroundWorker()
        syncBackgroundWorker.WorkerReportsProgress = True
        AddHandler syncBackgroundWorker.DoWork, New DoWorkEventHandler(AddressOf syncBackgroundWorker_DoWork)
        AddHandler syncBackgroundWorker.ProgressChanged, New ProgressChangedEventHandler(AddressOf syncBackgroundWorker_ProgressChanged)
        AddHandler syncBackgroundWorker.RunWorkerCompleted, New RunWorkerCompletedEventHandler(AddressOf syncBackgroundWorker_RunWorkerCompleted)

        ' Disable the start button
        btnStart.Enabled = False

        ' Initialize the progress bar and status textbox
        pbStatus.Value = 0
        'tbLastStatusMessage.Text = [String].Empty

        pictureBoxStatus.Visible = True
        pictureBoxStatus.Enabled = True

        ' Kick off a background operation to synchronize
        syncBackgroundWorker.RunWorkerAsync()
    End Sub

    ' This event handler initiates the synchronization
    Private Sub syncBackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs)
        ' Connect to the Subscriber and synchronize
        SynchronizeMergePullSubscriptionViaRMO()
    End Sub

    ' Synchronize
    Public Sub SynchronizeMergePullSubscriptionViaRMO()
        ' Create a connection to the Subscriber.
        Dim conn As New ServerConnection(subscriberName)

        ' Merge pull subscription
        Dim subscription As MergePullSubscription

        Try
            ' Connect to the Subscriber.
            conn.Connect()

            ' Define the pull subscription.
            subscription = New MergePullSubscription()
            subscription.ConnectionContext = conn
            subscription.DatabaseName = subscriptionDbName
            subscription.PublisherName = publisherName
            subscription.PublicationDBName = publicationDbName
            subscription.PublicationName = publicationName

            ' If the pull subscription exists, then start the synchronization.
            If subscription.LoadProperties() Then
                ' Get the agent for the subscription.
                agent = subscription.SynchronizationAgent

                ' Set the required properties that could not be returned
                ' from the MSsubscription_properties table.

                '                agent.PublisherSecurityMode = SecurityMode.Integrated
                agent.PublisherSecurityMode = SecurityMode.Standard
                agent.PublisherLogin = "EvacRemote"
                agent.PublisherPassword = "6A33%7rq"

                '               agent.DistributorSecurityMode = SecurityMode.Integrated

                agent.DistributorSecurityMode = SecurityMode.Standard
                agent.DistributorLogin = "EvacRemote"
                agent.DistributorPassword = "6A33%7rq"

                agent.Distributor = publisherName

                agent.InternetSecurityMode = SecurityMode.Standard

                agent.InternetLogin ="EvacRemote"
                agent.InternetPassword = "6A33%7rq"
                agent.InternetUrl = "https://willow.evacchair.co.uk/SQLReplication/replisapi.dll"
                ' Enable verbose merge agent output to file.
                agent.OutputVerboseLevel = 4
                agent.Output = "C:\TEMP\mergeagent.log"

                ' Handle the Status event
                AddHandler agent.Status, AddressOf agent_Status

                ' Synchronously start the Merge Agent for the subscription.
                agent.Synchronize()
            Else
                ' Do something here if the pull subscription does not exist.
                Throw New ApplicationException([String].Format("A subscription to '{0}' does not exist on {1}", publicationName, subscriberName))
            End If
        Catch ex As Exception
            ' Implement appropriate error handling here.
            Throw New ApplicationException("The subscription could not be " & "synchronized. Verify that the subscription has " & "been defined correctly.", ex)
        Finally
            conn.Disconnect()
        End Try
    End Sub

    ' This event handler handles the Status event and reports the agent progress.
    Public Sub agent_Status(sender As Object, e As StatusEventArgs)
        syncBackgroundWorker.ReportProgress(Convert.ToInt32(e.PercentCompleted), e.Message.ToString())
    End Sub

    ' This event handler updates the form with agent progress.
    Private Sub syncBackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        ' Set the progress bar percent completed
        pbStatus.Value = e.ProgressPercentage

        ' Append the last agent message
        tbLastStatusMessage.Text += e.UserState.ToString() & Environment.NewLine

        ' Scroll to end
        ScrollToEnd()
    End Sub

    ' This event handler deals with the results of the background operation.
    Private Sub syncBackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        If e.Cancelled = True Then
            tbLastStatusMessage.Text += "Canceled!" & Environment.NewLine
            ScrollToEnd()
        ElseIf e.[Error] IsNot Nothing Then
            tbLastStatusMessage.Text += "Error: " & e.[Error].Message & Environment.NewLine
            ScrollToEnd()
        Else
            tbLastStatusMessage.Text += "Done!" & Environment.NewLine
            ScrollToEnd()
        End If

        btnStart.Enabled = True
        pictureBoxStatus.Enabled = False
    End Sub

    Private Sub ScrollToEnd()
        ' Scroll to end
        tbLastStatusMessage.SelectionStart = tbLastStatusMessage.TextLength
        tbLastStatusMessage.ScrollToCaret()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs)
        ' Dim publicationName As String = "AdvWorksSalesOrdersMerge"
        '  Dim subscriptionDbName As String = "AdventureWorks2012Replica"
        ' Dim publicationDbName As String = "AdventureWorks2012"
        'Dim hostname As String = "adventure-works\garrett1"

        'Create a connection to the Publisher.
        Dim conn As ServerConnection = New ServerConnection(subscriberName)

        ' Create the objects that we need.
        Dim publication As MergePublication
        Dim subscription As MergeSubscription

        Try
            ' Connect to the Publisher.
            conn.Connect()

            ' Ensure that the publication exists and that 
            ' it supports push subscriptions.
            publication = New MergePublication()
            publication.Name = publicationName
            publication.DatabaseName = publicationDbName
            publication.ConnectionContext = conn

            If publication.IsExistingObject Then
                If (publication.Attributes And PublicationAttributes.AllowPush) = 0 Then
                    publication.Attributes = publication.Attributes _
                    Or PublicationAttributes.AllowPush
                End If

                ' Define the push subscription.
                subscription = New MergeSubscription()
                subscription.ConnectionContext = conn
                subscription.SubscriberName = subscriberName
                subscription.PublicationName = publicationName
                subscription.DatabaseName = publicationDbName
                subscription.SubscriptionDBName = subscriptionDbName
                ' subscription.HostName = hostname

                ' Set a schedule to synchronize the subscription every 2 hours
                ' during weekdays from 6am to 10pm.
                subscription.AgentSchedule.FrequencyType = ScheduleFrequencyType.Weekly
                subscription.AgentSchedule.FrequencyInterval = Convert.ToInt32("0x003E", 16)
                subscription.AgentSchedule.FrequencyRecurrenceFactor = 1
                subscription.AgentSchedule.FrequencySubDay = ScheduleFrequencySubDay.Hour
                subscription.AgentSchedule.FrequencySubDayInterval = 2
                subscription.AgentSchedule.ActiveStartDate = 20051108
                subscription.AgentSchedule.ActiveEndDate = 20071231
                subscription.AgentSchedule.ActiveStartTime = 60000
                subscription.AgentSchedule.ActiveEndTime = 100000

                ' Specify the Windows login credentials for the Merge Agent job.
                subscription.SynchronizationAgentProcessSecurity.Login = "EvacRemote"
                subscription.SynchronizationAgentProcessSecurity.Password = "6A33%7rq"

                ' Create the push subscription.
                subscription.Create()
            Else

                ' Do something here if the publication does not exist.
                Throw New ApplicationException(String.Format( _
                 "The publication '{0}' does not exist on {1}.", _
                 publicationName, publisherName))
            End If
        Catch ex As Exception
            ' Implement the appropriate error handling here.
            Throw New ApplicationException(String.Format( _
            "The subscription to {0} could not be created.", publicationName), ex)
        Finally
            conn.Disconnect()
        End Try

    End Sub

    Private Sub FrmSyncronize_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If _forced = True Then
            tbLastStatusMessage.Text += "Creating Database "
            SQLHelper.DBCreate()
            tbLastStatusMessage.Text += "Done!" & Environment.NewLine
            ScrollToEnd()
            tbLastStatusMessage.Text += "Creating Publication "
            SQLHelper.CreatePublication()
            tbLastStatusMessage.Text += "Done!" & Environment.NewLine
            ScrollToEnd()
            tbLastStatusMessage.Text += "Creating Subscription "
            SQLHelper.CreateSubscription()
            tbLastStatusMessage.Text += "Done!" & Environment.NewLine
            ScrollToEnd()
            StartSync()
        End If
    End Sub
  
End Class