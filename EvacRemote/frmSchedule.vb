Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Runtime.Serialization
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Exchange
Imports DevExpress.XtraScheduler.Outlook
Imports DevExpress.XtraScheduler.Outlook.Interop
Imports OutlookInterop = Microsoft.Office.Interop.Outlook

Imports System.Data.Odbc
Imports System.Data.OleDb
Imports DevExpress.XtraEditors


Public Class frmSchedule
    Private Const OutlookEntryIDFieldName As String = "OutlookEntryID"
    Public Const CustomFieldPropertyName As String = "UserID"
    Public Const OutlookUserPropertyName As String = "UserID"
    Private count As Integer = 0

    Private resourceColorSchemas As Dictionary(Of Object, SchedulerColorSchema) = New Dictionary(Of Object, SchedulerColorSchema)()


    Private Sub frmSchedule_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        loaddata()
    End Sub

    Private Sub Schedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DataSet1.engineer_locations' table. You can move, or remove it, as needed.
        If _UserId = -1 Then
            Me.Engineer_locationsTableAdapter.Fill(Me.DataSet1.engineer_locations)
        Else
            Me.Engineer_locationsTableAdapter.FillBy(Me.DataSet1.engineer_locations, _UserId)
        End If


        SchedulerControl1.GroupType = SchedulerGroupType.Resource
        bbiProgress.AutoFillWidth = True

    End Sub

    Private Sub loaddata()


        If _UserId = -1 Then
            Me.Engineer_locationsTableAdapter.Fill(Me.DataSet1.engineer_locations)
        Else
            Me.Engineer_locationsTableAdapter.FillBy(Me.DataSet1.engineer_locations, _UserId)
        End If
        PrepareResourceColorSchemas()

        'TODO: This line of code loads data into the 'DataSet1.lead_xtra' table. You can move, or remove it, as needed.
        If _UserId = -1 Then
            Me.Central_diaryTableAdapter1.Fill(Me.DataSet1.central_diary)
        Else
            Me.Central_diaryTableAdapter1.FillBy(Me.DataSet1.central_diary, _UserId)
        End If

        'SchedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Week
    End Sub



    Private Sub PrepareResourceColorSchemas()
        'Me.resourceColorSchemas.Clear()
        'Dim count As Integer = Me.DataSet1.user.Count
        'Dim currentColorSchemas As SchedulerColorSchemaCollection = _
        '                           SchedulerControl1.GetResourceColorSchemasCopy()
        'Dim schemaCount As Integer = currentColorSchemas.Count
        'For i As Integer = 0 To count - 1
        '    Dim resource As Resource = SchedulerControl1.Storage.Resources(i)
        '    Me.resourceColorSchemas.Add(resource.Id, currentColorSchemas(i Mod schemaCount))
        'Next i
    End Sub

    Private Sub SchedulerControl1_AppointmentViewInfoCustomizing(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentViewInfoCustomizingEventArgs) Handles SchedulerControl1.AppointmentViewInfoCustomizing
        Dim apt As Appointment = e.ViewInfo.Appointment
        Dim res As Resource = SchedulerStorage1.Resources.GetResourceById(apt.ResourceId)

        'e.ViewInfo.Appearance.BackColor = res.Color
        Select Case CStr(apt.ResourceId)
            Case "AB"
                e.ViewInfo.Appearance.BackColor = Color.LightCoral
            Case "CB"
                e.ViewInfo.Appearance.BackColor = Color.LightBlue
            Case "VN"
                e.ViewInfo.Appearance.BackColor = Color.LightCyan
            Case "MH"
                e.ViewInfo.Appearance.BackColor = Color.LightGoldenrodYellow
            Case "PH"
                e.ViewInfo.Appearance.BackColor = Color.LightGreen
            Case "MC"
                e.ViewInfo.Appearance.BackColor = Color.LightPink
            Case "LB"
                e.ViewInfo.Appearance.BackColor = Color.LightSalmon
            Case "SW"
                e.ViewInfo.Appearance.BackColor = Color.LightSeaGreen
            Case "VM"
                e.ViewInfo.Appearance.BackColor = Color.LightSkyBlue
            Case "NE"
                e.ViewInfo.Appearance.BackColor = Color.LightSlateGray
            Case "MH"
                e.ViewInfo.Appearance.BackColor = Color.LightSteelBlue
            Case "DS"
                e.ViewInfo.Appearance.BackColor = Color.LightYellow
            Case "CB"
                e.ViewInfo.Appearance.BackColor = Color.PaleGreen
            Case Else
                '                e.ViewInfo.Appearance.BackColor = Color.PaleTurquoise
        End Select
    End Sub


    Private Sub SchedulerControl1_QueryResourceColorSchema(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.QueryResourceColorSchemaEventArgs) Handles SchedulerControl1.QueryResourceColorSchema
        Dim key As Object = e.Resource.Id
        If Me.resourceColorSchemas.ContainsKey(key) Then
            e.ResourceColorSchema = Me.resourceColorSchemas(key)
        End If
    End Sub


    Private Sub ImportSync()
        count = 0

        Dim synchronizer As AppointmentImportSynchronizer = SchedulerStorage1.CreateOutlookImportSynchronizer()
        AddHandler synchronizer.AppointmentSynchronizing, AddressOf synchronizer_AppointmentImportSynchronizing
        AddHandler synchronizer.AppointmentSynchronized, AddressOf synchronizer_AppointmentImportSynchronized
        synchronizer.ForeignIdFieldName = OutlookEntryIDFieldName

        Dim oldCur As Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
        BeforeSynchronization(synchronizer.SourceObjectCount)
        Try
            synchronizer.Synchronize()
        Finally
            AfterSynchronization()
            Cursor.Current = oldCur
        End Try

        MessageBox.Show(String.Format("Synchronized {0} appointment(s); source objects count: {1}", count, synchronizer.SourceObjectCount), "Import successful", MessageBoxButtons.OK)
    End Sub

    Private Sub ExportSync()

        count = 0

        Dim synchronizer As AppointmentExportSynchronizer = SchedulerStorage1.CreateOutlookExportSynchronizer()
        AddHandler synchronizer.AppointmentSynchronizing, AddressOf synchronizer_AppointmentExportSynchronizing
        AddHandler synchronizer.AppointmentSynchronized, AddressOf synchronizer_AppointmentExportSynchronized
        synchronizer.ForeignIdFieldName = OutlookEntryIDFieldName

        Dim oldCur As Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
        BeforeSynchronization(synchronizer.SourceObjectCount)
        Try
            synchronizer.Synchronize()
        Finally
            AfterSynchronization()
            Cursor.Current = oldCur
        End Try

        MessageBox.Show(String.Format("Synchronized {0} appointment(s); source objects count: {1}", count, synchronizer.SourceObjectCount), "Export successful", MessageBoxButtons.OK)

    End Sub

    Private Sub BeforeSynchronization(ByVal objectCount As Integer)
        bbiProgress.EditValue = 0
        RepositoryItemProgressBar1.Maximum = objectCount
        bbiProgress.Refresh()

    End Sub
    Private Sub AfterSynchronization()
        RepositoryItemProgressBar1.Maximum = 100
        bbiProgress.EditValue = 0
        bbiProgress.Refresh()

    End Sub


    Private Sub synchronizer_AppointmentExportSynchronizing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentSynchronizingEventArgs)
        Dim args As OutlookAppointmentSynchronizingEventArgs = CType(e, OutlookAppointmentSynchronizingEventArgs)
        ' Prevent appointments with other UserID from being deleted
        If e.Operation = SynchronizeOperation.Delete Then
            e.Cancel = True
            Return

            'If GetOutlookAppointmentUserId(args.OutlookAppointment) <> _UserId Then
            '    e.Cancel = True
            '    Return
            'End If
        End If
        ' Mark the new Outlook appoinment item with UserID
        If e.Operation = SynchronizeOperation.Create Then
            If e.Appointment.ResourceId <> _UserId Then
                e.Cancel = True
            Else
                Dim bBooked As Boolean = e.Appointment.CustomFields("Confirmed")
                Dim iLead As Integer = -1
                If Not IsDBNull(e.Appointment.CustomFields("Leadno")) Then
                    iLead = e.Appointment.CustomFields("Leadno")
                End If
                If iLead = 112116 Then
                    Beep()
                End If
                If bBooked = True Or iLead = 0 Then
                    SetOutlookAppointmentUserId(args.OutlookAppointment)
                Else

                    e.Cancel = True
                End If
            End If
        End If

        bbiProgress.EditValue += 1
        bbiProgress.Refresh()


    End Sub

    Private Sub synchronizer_AppointmentImportSynchronized(ByVal sender As Object, ByVal e As AppointmentSynchronizedEventArgs)
        count += 1
    End Sub

    Private Sub synchronizer_AppointmentExportSynchronized(ByVal sender As Object, ByVal e As AppointmentSynchronizedEventArgs)
        count += 1

        ' !!! Note: the following code isn't necessary when targeting XtraScheduler v2008 vol 1 and higher
        Dim args As OutlookAppointmentSynchronizedEventArgs = CType(e, OutlookAppointmentSynchronizedEventArgs)
        If args.Appointment IsNot Nothing AndAlso args.OutlookAppointment IsNot Nothing Then
            If e.Appointment.CustomFields(OutlookEntryIDFieldName) Is Nothing Then
                e.Appointment.CustomFields(OutlookEntryIDFieldName) = args.OutlookAppointment.EntryID
               
            End If
            Dim newId As Integer = CInt(e.Appointment.CustomFields("CentralDiaryno"))
            Dim str As String = "update [central_diary]"
            str = String.Concat(str, String.Format("SET OutlookEntryID= '{0}'", args.OutlookAppointment.EntryID))
            str = String.Concat(str, String.Format(" WHERE  central_diaryno = {0}", newId))
            Using comm As OdbcCommand = New OdbcCommand(str, cn)
                comm.ExecuteScalar()
            End Using

        End If
    End Sub

    Private Sub synchronizer_AppointmentImportSynchronizing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentSynchronizingEventArgs)
        If e.Operation = SynchronizeOperation.Delete Then
            Return
        End If

        ' prevent appointments with the other UserID from being created or updated
        Dim args As OutlookAppointmentSynchronizingEventArgs = CType(e, OutlookAppointmentSynchronizingEventArgs)
        If _UserId = -1 Then
            e.Cancel = True
        Else
            e.Cancel = GetOutlookAppointmentUserId(args.OutlookAppointment) <> _UserId
        End If
    End Sub

    Private Sub SetOutlookAppointmentUserId(ByVal aptItem As _AppointmentItem)
        Dim olApt As OutlookInterop.AppointmentItem = CType(aptItem, OutlookInterop.AppointmentItem)
        Dim prop As OutlookInterop.UserProperty = olApt.UserProperties.Add(OutlookUserPropertyName, OutlookInterop.OlUserPropertyType.olNumber, False, System.Reflection.Missing.Value)
        Try
            prop.Value = _UserId
        Finally
            Marshal.ReleaseComObject(prop)
        End Try
    End Sub
    Private Function GetOutlookAppointmentUserId(ByVal aptItem As _AppointmentItem) As Integer
        Dim olApt As OutlookInterop.AppointmentItem = CType(aptItem, OutlookInterop.AppointmentItem)
        Dim en As IEnumerator = olApt.UserProperties.GetEnumerator()
        en.Reset()
        Do While en.MoveNext()
            Dim prop As OutlookInterop.UserProperty = CType(en.Current, OutlookInterop.UserProperty)
            Try
                If prop.Name = OutlookUserPropertyName Then
                    Return Convert.ToInt32(prop.Value)
                End If
            Finally
                Marshal.ReleaseComObject(prop)
            End Try
        Loop
        Return -1
    End Function


    ' Update the newly inserted appointment with the current UserID 
    Private Sub schedulerControl1_InitNewAppointment(ByVal sender As Object, ByVal e As AppointmentEventArgs) Handles SchedulerControl1.InitNewAppointment
        'e.Appointment.ResourceId = ResourceID
        e.Appointment.CustomFields("Confirmed") = 0
    End Sub

    Private Sub schedulerStorage1_AppointmentChanging(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs) Handles SchedulerStorage1.AppointmentChanging
        Dim apt As Appointment = (CType(e.Object, Appointment))
        Dim newId As Integer = CInt(apt.CustomFields("CentralDiaryno"))

        Dim str As String = "update [central_diary]"
        str = String.Concat(str, String.Format(" set AppType = {0},", 0))
        str = String.Concat(str, String.Format("BookedDate = '{0:yyyy/MM/dd}',", apt.Start))
        str = String.Concat(str, String.Format("EndDate = '{0:yyyy/MM/dd}',", apt.Start))
        str = String.Concat(str, String.Format("AllDay = {0},", IIf(apt.AllDay = True, 1, 0)))
        str = String.Concat(str, String.Format("Subject = '{0}',", apt.Subject))
        If CBool(apt.CustomFields("Confirmed")) = True Then
            str = String.Concat(str, String.Format("Confirmed = {0},", 1))
        Else
            str = String.Concat(str, String.Format("Confirmed = {0},", 0))
        End If
        str = String.Concat(str, String.Format("AppLocation = '{0}',", apt.Location))
        str = String.Concat(str, String.Format("AppDescription = '{0}',", apt.Description))
        str = String.Concat(str, String.Format("AppStatus = '{0}',", apt.StatusId))
        str = String.Concat(str, String.Format("Label= {0}, ", apt.LabelId))
        If Not IsDBNull(apt.CustomFields("OutlookEntryID")) Then
            str = String.Concat(str, String.Format("OutlookEntryID= '{0}',", CStr(apt.CustomFields("OutlookEntryID"))))
        Else
            str = String.Concat(str, String.Format("OutlookEntryID= '{0}',", ""))
        End If

        str = String.Concat(str, String.Format("UserID = {0}", apt.ResourceId))
        str = String.Concat(str, String.Format("WHERE  central_diaryno = {0}", newId))
        Using comm As OdbcCommand = New OdbcCommand(str, cn)
            comm.ExecuteScalar()
        End Using

    End Sub


    ' Save changes to the underlying data source


    ' This event handler is necessary when creating appointments via code
    Private Sub schedulerStorage1_AppointmentInserting(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs) Handles SchedulerStorage1.AppointmentInserting

        Dim newId As Integer

        Dim apt As Appointment = (CType(e.Object, Appointment))

        Dim str As String = "insert into [central_diary]"
        str = String.Concat(str, " (AppType, BookedDate, EndDate, AllDay,Subject, AppLocation, AppDescription, AppStatus, Label,OutlookEntryID, UserID)")
        str = String.Concat(str, " Values (")
        str = String.Concat(str, String.Format("{0},", 0))
        str = String.Concat(str, String.Format("'{0:yyyy/MM/dd}',", apt.Start))
        str = String.Concat(str, String.Format("'{0:yyyy/MM/dd}',", apt.End))
        str = String.Concat(str, String.Format("{0},", IIf(apt.AllDay = True, 1, 0)))
        str = String.Concat(str, String.Format("'{0}',", apt.Location))
        str = String.Concat(str, String.Format("'{0}',", apt.Subject))
        str = String.Concat(str, String.Format("'{0}',", apt.Description))
        str = String.Concat(str, String.Format("'{0}',", apt.StatusId))
        str = String.Concat(str, String.Format("'{0}',", apt.LabelId))
        str = String.Concat(str, String.Format("'{0}',", CStr(apt.CustomFields("OutlookEntryID"))))
        str = String.Concat(str, String.Format("{0}", apt.ResourceId))

        str = String.Concat(str, ")")
        Using comm As OdbcCommand = New OdbcCommand(str, cn)
            comm.ExecuteScalar()
        End Using

        Using cmd As New OdbcCommand("SELECT @@IDENTITY", cn)
            newId = CInt(Fix(cmd.ExecuteScalar()))
        End Using
        apt.CustomFields("CentralDiaryno") = newId

    End Sub
    Private Sub bbiExportDiary_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportDiary.ItemClick
        Me.Cursor = Cursors.WaitCursor
        If _UserId = -1 Then
            XtraMessageBox.Show("Sychronize Disabled No Engineer Selected", "Sychronize", MessageBoxButtons.OK)
        Else
            Dim sStr As String = String.Format("Confirm you wish to Sychronize {0} Appointments with your Calendar", _EngineerName)
            If XtraMessageBox.Show(sStr, "Sychronize", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                '   ImportSync()
                ExportSync()
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '  AddHandler scheduleTableAdapter.Adapter.RowUpdated, AddressOf Adapter_RowUpdated

        ' Me.scheduleTableAdapter.FillBy(Me.DataSet1.Schedule, UserID)
        Me.SchedulerControl1.Start = DateTime.Today
    End Sub

    'Private Sub SchedulerStorage1_AppointmentsInserted(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles SchedulerStorage1.AppointmentsInserted
    '    Dim po As DevExpress.XtraScheduler.PersistentObject
    '    For Each po In e.Objects
    '        Dim apt As DevExpress.XtraScheduler.Appointment = CType(po, DevExpress.XtraScheduler.Appointment)
    '    Next po
    'End Sub

    Private Sub bbiConfirm_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConfirm.ItemClick

        For Each apt As Appointment In SchedulerControl1.SelectedAppointments
            Dim iDiaryNo As Integer = CInt(apt.CustomFields("CentralDiaryno"))
            If Not IsDBNull(apt.CustomFields("Leadno")) Then
                Dim iLeadno As Integer = CInt(apt.CustomFields("Leadno"))
                ' Change the field value.
                'Dim sStr As String = ""
                'sStr = "update [central_diary]"
                'sStr = String.Concat(sStr, String.Format(" set confirmed = 1,Label = 5 "))
                'sStr = String.Concat(sStr, String.Format(" where central_diaryno = {0}", iDiaryNo))

                'Using comm As OdbcCommand = New OdbcCommand(sStr, cn)
                '    comm.ExecuteScalar()
                'End Using
                apt.CustomFields("Confirmed") = 1
                apt.LabelId = 5
            End If
        Next

    End Sub
End Class