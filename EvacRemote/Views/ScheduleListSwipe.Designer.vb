<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleListSwipe
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleListSwipe))
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnToday = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMonth = New DevExpress.XtraEditors.SimpleButton()
        Me.btnWeek = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDay = New DevExpress.XtraEditors.SimpleButton()
        Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.SISchedule = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.lciSchedule = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciWeek = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDayView = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciMonth = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciToday = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DataSet1 = New EvacRemote.DataSet1()
        Me.Central_diaryTableAdapter1 = New EvacRemote.DataSet1TableAdapters.central_diaryTableAdapter()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CentraldiaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EngineerlocationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Engineer_locationsTableAdapter = New EvacRemote.DataSet1TableAdapters.engineer_locationsTableAdapter()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SISchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciWeek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDayView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciToday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CentraldiaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EngineerlocationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchedulerStorage1
        '
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("CentralDiaryno", "central_diaryno"))
        Me.SchedulerStorage1.Appointments.DataSource = Me.CentraldiaryBindingSource
        Me.SchedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerStorage1.Appointments.Mappings.Description = "AppDescription"
        Me.SchedulerStorage1.Appointments.Mappings.End = "EndDate"
        Me.SchedulerStorage1.Appointments.Mappings.Label = "Label"
        Me.SchedulerStorage1.Appointments.Mappings.Location = "AppLocation"
        Me.SchedulerStorage1.Appointments.Mappings.Start = "BookedDate"
        Me.SchedulerStorage1.Appointments.Mappings.Status = "AppStatus"
        Me.SchedulerStorage1.Appointments.Mappings.Subject = "Subject"
        Me.SchedulerStorage1.Appointments.Mappings.Type = "AppType"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnToday)
        Me.LayoutControl1.Controls.Add(Me.btnMonth)
        Me.LayoutControl1.Controls.Add(Me.btnWeek)
        Me.LayoutControl1.Controls.Add(Me.btnDay)
        Me.LayoutControl1.Controls.Add(Me.SchedulerControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(455, 190, 685, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(659, 419)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnToday
        '
        Me.btnToday.Image = CType(resources.GetObject("btnToday.Image"), System.Drawing.Image)
        Me.btnToday.Location = New System.Drawing.Point(467, 12)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(42, 38)
        Me.btnToday.StyleController = Me.LayoutControl1
        Me.btnToday.TabIndex = 8
        '
        'btnMonth
        '
        Me.btnMonth.Image = CType(resources.GetObject("btnMonth.Image"), System.Drawing.Image)
        Me.btnMonth.Location = New System.Drawing.Point(605, 12)
        Me.btnMonth.Name = "btnMonth"
        Me.btnMonth.Size = New System.Drawing.Size(42, 38)
        Me.btnMonth.StyleController = Me.LayoutControl1
        Me.btnMonth.TabIndex = 7
        '
        'btnWeek
        '
        Me.btnWeek.Image = CType(resources.GetObject("btnWeek.Image"), System.Drawing.Image)
        Me.btnWeek.Location = New System.Drawing.Point(559, 12)
        Me.btnWeek.Name = "btnWeek"
        Me.btnWeek.Size = New System.Drawing.Size(42, 38)
        Me.btnWeek.StyleController = Me.LayoutControl1
        Me.btnWeek.TabIndex = 6
        '
        'btnDay
        '
        Me.btnDay.Image = CType(resources.GetObject("btnDay.Image"), System.Drawing.Image)
        Me.btnDay.Location = New System.Drawing.Point(513, 12)
        Me.btnDay.Name = "btnDay"
        Me.btnDay.Size = New System.Drawing.Size(42, 38)
        Me.btnDay.StyleController = Me.LayoutControl1
        Me.btnDay.TabIndex = 5
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.Location = New System.Drawing.Point(12, 54)
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.Size = New System.Drawing.Size(635, 353)
        Me.SchedulerControl1.Start = New Date(2014, 9, 17, 0, 0, 0, 0)
        Me.SchedulerControl1.Storage = Me.SchedulerStorage1
        Me.SchedulerControl1.TabIndex = 4
        Me.SchedulerControl1.Text = "SchedulerControl1"
        Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.SISchedule, Me.lciSchedule, Me.lciWeek, Me.lciDayView, Me.lciMonth, Me.lciToday})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(659, 419)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'SISchedule
        '
        Me.SISchedule.AllowHotTrack = False
        Me.SISchedule.CustomizationFormText = "Today"
        Me.SISchedule.Location = New System.Drawing.Point(0, 0)
        Me.SISchedule.Name = "SISchedule"
        Me.SISchedule.Size = New System.Drawing.Size(455, 42)
        Me.SISchedule.Text = "Today"
        Me.SISchedule.TextSize = New System.Drawing.Size(30, 13)
        '
        'lciSchedule
        '
        Me.lciSchedule.Control = Me.SchedulerControl1
        Me.lciSchedule.CustomizationFormText = "lciSchedule"
        Me.lciSchedule.Location = New System.Drawing.Point(0, 42)
        Me.lciSchedule.Name = "lciSchedule"
        Me.lciSchedule.Size = New System.Drawing.Size(639, 357)
        Me.lciSchedule.Text = "lciSchedule"
        Me.lciSchedule.TextSize = New System.Drawing.Size(0, 0)
        Me.lciSchedule.TextToControlDistance = 0
        Me.lciSchedule.TextVisible = False
        '
        'lciWeek
        '
        Me.lciWeek.Control = Me.btnWeek
        Me.lciWeek.CustomizationFormText = "lciWeek"
        Me.lciWeek.Location = New System.Drawing.Point(547, 0)
        Me.lciWeek.Name = "lciWeek"
        Me.lciWeek.Size = New System.Drawing.Size(46, 42)
        Me.lciWeek.Text = "lciWeek"
        Me.lciWeek.TextSize = New System.Drawing.Size(0, 0)
        Me.lciWeek.TextToControlDistance = 0
        Me.lciWeek.TextVisible = False
        '
        'lciDayView
        '
        Me.lciDayView.Control = Me.btnDay
        Me.lciDayView.CustomizationFormText = "lciDayView"
        Me.lciDayView.Location = New System.Drawing.Point(501, 0)
        Me.lciDayView.Name = "lciDayView"
        Me.lciDayView.Size = New System.Drawing.Size(46, 42)
        Me.lciDayView.Text = "lciDayView"
        Me.lciDayView.TextSize = New System.Drawing.Size(0, 0)
        Me.lciDayView.TextToControlDistance = 0
        Me.lciDayView.TextVisible = False
        '
        'lciMonth
        '
        Me.lciMonth.Control = Me.btnMonth
        Me.lciMonth.CustomizationFormText = "lciMonth"
        Me.lciMonth.Location = New System.Drawing.Point(593, 0)
        Me.lciMonth.Name = "lciMonth"
        Me.lciMonth.Size = New System.Drawing.Size(46, 42)
        Me.lciMonth.Text = "lciMonth"
        Me.lciMonth.TextSize = New System.Drawing.Size(0, 0)
        Me.lciMonth.TextToControlDistance = 0
        Me.lciMonth.TextVisible = False
        '
        'lciToday
        '
        Me.lciToday.Control = Me.btnToday
        Me.lciToday.CustomizationFormText = "lciToday"
        Me.lciToday.Location = New System.Drawing.Point(455, 0)
        Me.lciToday.Name = "lciToday"
        Me.lciToday.Size = New System.Drawing.Size(46, 42)
        Me.lciToday.Text = "lciToday"
        Me.lciToday.TextSize = New System.Drawing.Size(0, 0)
        Me.lciToday.TextToControlDistance = 0
        Me.lciToday.TextVisible = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Central_diaryTableAdapter1
        '
        Me.Central_diaryTableAdapter1.ClearBeforeFill = True
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'CentraldiaryBindingSource
        '
        Me.CentraldiaryBindingSource.DataMember = "central_diary"
        Me.CentraldiaryBindingSource.DataSource = Me.DataSet1
        '
        'EngineerlocationsBindingSource
        '
        Me.EngineerlocationsBindingSource.DataMember = "engineer_locations"
        Me.EngineerlocationsBindingSource.DataSource = Me.DataSet1BindingSource
        '
        'Engineer_locationsTableAdapter
        '
        Me.Engineer_locationsTableAdapter.ClearBeforeFill = True
        '
        'ScheduleListSwipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ScheduleListSwipe"
        Me.Size = New System.Drawing.Size(659, 419)
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SISchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciWeek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDayView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciToday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CentraldiaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EngineerlocationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SISchedule As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lciSchedule As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnDay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lciDayView As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnToday As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMonth As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnWeek As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lciWeek As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciMonth As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciToday As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CentraldiaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As EvacRemote.DataSet1
    Friend WithEvents Central_diaryTableAdapter1 As EvacRemote.DataSet1TableAdapters.central_diaryTableAdapter
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EngineerlocationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Engineer_locationsTableAdapter As EvacRemote.DataSet1TableAdapters.engineer_locationsTableAdapter

End Class
