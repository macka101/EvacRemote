﻿Imports System.Data.Odbc
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo

Imports EvacRemote.GlobalVariables
Imports DevExpress.XtraScheduler
Imports DevExpress.Xpo
Imports Esso.Data
Imports DevExpress.Data.Filtering


Public Class ViewDiarySchedule
    Private _Loaded As Boolean = False
    Private _session As UnitOfWork

    Private _parent As frmMain = Nothing
    Public ReadOnly Property Loaded As Boolean
        Get
            Return _Loaded
        End Get
    End Property
 
    Public Property ParentFormMain() As frmMain
        Get
            Return _parent
        End Get
        Set(ByVal value As frmMain)
            If (Not Object.Equals(_parent, Nothing)) Then
                Return
            End If
            _parent = value
        End Set
    End Property

    Public Sub New(ByVal session As UnitOfWork, ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = session
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub Initdata()
        SchedulerCompatibility.Base64XmlObjectSerialization = False
        Me.SchedulerStorage1.Appointments.ResourceSharing = False
        Me.SchedulerControl1.GroupType = SchedulerGroupType.None
        Me.SchedulerControl1.OptionsView.ShowOnlyResourceAppointments = True
        Me.SchedulerControl1.Start = DateTime.Today

        MapAppointmentData()
        MapResourceData()
        SchedulerControl1.GroupType = SchedulerGroupType.Resource

        Me.SchedulerStorage1.Appointments.DataSource = New XPCollection(Of CentralDiary)(_session, (CriteriaOperator.Parse("UserId = ? and BookedDate > ? and Label = 5", 8, DateTime.Today.AddDays(-8))), New DevExpress.Xpo.SortProperty("[BookedDate]", DevExpress.Xpo.DB.SortingDirection.Ascending))
        'Me.SchedulerStorage1.Appointments.DataMember = _ScheduleTable
        Me.SchedulerStorage1.Resources.DataSource = New XPCollection(Of Engineer)(_session, (CriteriaOperator.Parse("EngineerNo = ?", 8)))
        'Me.SchedulerStorage1.Resources.DataMember = _EngineerTable
    End Sub
    Private Sub MapAppointmentData()
        'Me.SchedulerStorage1.Appointments.Mappings.AppointmentId = "central_diaryno"
        Me.SchedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerStorage1.Appointments.Mappings.Description = "AppDescription"
        ' Required mapping.
        Me.SchedulerStorage1.Appointments.Mappings.End = "EndDate"
        Me.SchedulerStorage1.Appointments.Mappings.Label = "Label"
        Me.SchedulerStorage1.Appointments.Mappings.Location = "AppLocation"
        '       Me.SchedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
        '      Me.SchedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
        ' Required mapping.
        Me.SchedulerStorage1.Appointments.Mappings.Start = "BookedDate"
        Me.SchedulerStorage1.Appointments.Mappings.Status = "AppStatus"
        Me.SchedulerStorage1.Appointments.Mappings.Subject = "Subject"
        Me.SchedulerStorage1.Appointments.Mappings.Type = "AppType"
        Me.SchedulerStorage1.Appointments.Mappings.ResourceId = "UserId"
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("OutlookEntryID", "OutlookEntryID"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("CentralDiaryNo", "CentralDiaryNo"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("NoOfChairs", "NoOfChairs"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("Division", "Division"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("Contact", "Contact"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("LeadNo", "LeadNo"))

    End Sub

    Private Sub MapResourceData()
        Me.SchedulerStorage1.Resources.Mappings.Id = "EngineerNo"
        Me.SchedulerStorage1.Resources.Mappings.Caption = "EngineerName"
    End Sub

    Private Sub SchedulerControl1_EditAppointmentFormShowing(sender As Object, e As AppointmentFormEventArgs) Handles SchedulerControl1.EditAppointmentFormShowing
        Dim nBuilding As Building = Nothing
        Dim nEscapeRoute As EscapeRoute = Nothing

        Dim _diaryId As Integer = e.Appointment.CustomFields("CentralDiaryNo")

        Dim _diary As CentralDiary = _session.FindObject(Of CentralDiary)(CriteriaOperator.Parse("CentralDiaryNo= ?", _diaryId))
        If _diary IsNot Nothing Then
            _currentDivision = _diary.Division
            _currentContact = _diary.Contact
            Dim _chairs As Integer = e.Appointment.CustomFields("NoOfChairs")

            If _currentDivision.Buildings.Count = 0 Then
                nBuilding = New Building(_session)
                nBuilding.Division = _currentDivision
                nBuilding.Location = String.Format("Building {0}", 1)
                nBuilding.Heritage = "No"
                nBuilding.Access = "Private"
                nBuilding.Save()
                _session.CommitChanges()
                _currentDivision.Buildings.Add(nBuilding)

                nEscapeRoute = New EscapeRoute(_session)
                nEscapeRoute.Building = nBuilding
                nEscapeRoute.Location = "Escape Route 1"
                nEscapeRoute.Save()
                _session.CommitChanges()
                nBuilding.EscapeRoutes.Add(nEscapeRoute)
                nBuilding.Save()
                _session.CommitChanges()
            End If


            Dim _assetscount As Integer = 0
            If _currentDivision.Assets IsNot Nothing Then
                _assetscount = _currentDivision.Assets.Count
                If _assetscount = 0 Then
                    For i As Integer = 1 To _chairs
                        Dim nFloor As New Floor(_session)
                        nFloor.Building = nBuilding
                        nFloor.EscapeRoute = nEscapeRoute
                        nFloor.Location = String.Format("Floor {0}", i)
                        nFloor.Save()
                        _session.CommitChanges()
                        Dim _asset As New Asset(_session)
                        _asset.Division = _currentDivision
                        _asset.Building = nBuilding
                        _asset.EscapeRoute = nEscapeRoute
                        _asset.Floor = nFloor
                        _asset.BarCode = "Not Identified"
                        _asset.Save()
                        _session.CommitChanges()
                        _currentDivision.Assets.Add(_asset)

                    Next
                ElseIf _chairs > _assetscount Or _assetscount = 0 Then
                    For i As Integer = _assetscount + 1 To _chairs
                            Dim nFloor As New Floor(_session)
                            nFloor.Building = nBuilding
                            nFloor.EscapeRoute = nEscapeRoute
                            nFloor.Location = String.Format("Floor {0}", i)
                            nFloor.Save()
                            _session.CommitChanges()
                            Dim _asset As New Asset(_session)
                            _asset.Division = _currentDivision
                            _asset.Building = nBuilding
                            _asset.EscapeRoute = nEscapeRoute
                            _asset.Floor = nFloor
                            _asset.BarCode = "Not Identified"
                            _asset.Save()
                            _session.CommitChanges()
                            _currentDivision.Assets.Add(_asset)
                        Next
                    End If
                End If

            _currentService = _session.FindObject(Of EvacService)(CriteriaOperator.Parse("CentralDiaryNo = ?", _diaryId))
            If _currentService Is Nothing Then
                _currentService = New EvacService(_session)
                _currentService.CentralDiaryNo = _diaryId
                _currentService.Division = _currentDivision
                _currentService.Contact = _currentContact
                _currentService.ServiceDate = _diary.BookedDate
                _currentService.Save()
                _session.CommitChanges()
            End If
            Dim _xpchairs As New XPCollection(Of Asset)(_session, (CriteriaOperator.Parse("Division = ?", _currentDivision.Oid)))
            For Each _asset As Asset In _xpchairs
                Dim _nService As ChairService = _session.FindObject(Of ChairService)(CriteriaOperator.Parse("Asset = ? and EvacService = ?", _asset.Oid, _currentService.Oid))
                If _nService Is Nothing Then
                    _nService = New ChairService(_session)
                    _nService.EvacService = _currentService
                    _nService.ServiceDate = _diary.BookedDate
                    _nService.Asset = _asset
                    _nService.Save()
                    _session.CommitChanges()
                End If
            Next
        End If
        _session.CommitChanges()
        _currentDivision.Reload()
        e.Handled = True
        ParentFormMain.SelectPage(frmMain.ePage.ServiceDetail)
    End Sub
End Class
