Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Management
Imports System.Windows.Forms

Public Class DeviceDetector
    Public Enum ChassisTypes
        Other = 1
        Unknown
        Desktop
        LowProfileDesktop
        PizzaBox
        MiniTower
        Tower
        Portable
        Laptop
        Notebook
        Handheld
        DockingStation
        AllInOne
        SubNotebook
        SpaceSaving
        LunchBox
        MainSystemChassis
        ExpansionChassis
        SubChassis
        BusExpansionChassis
        PeripheralChassis
        StorageChassis
        RackMountChassis
        SealedCasePC
    End Enum
    Shared dellModel As String() = New String() {"Venue 8 Pro 5830"}
    Shared dellModelKind As KnonwnHardwareKind() = New KnonwnHardwareKind() {KnonwnHardwareKind.DellPro8}
    Private Shared Sub ParseKindDell(res As HardwareInfo)
        ParseKindCore(res, dellModel, dellModelKind)
    End Sub
    Private Shared Function ParseKindCore(res As HardwareInfo, model As String(), kind As KnonwnHardwareKind()) As Boolean
        Dim i As Integer = Array.IndexOf(Of String)(model, res.Model)
        If i < 0 Then
            Return False
        End If
        res.Kind = kind(i)
        Return True
    End Function
    Shared msModel As String() = New String() {"Surface with Windows 8 Pro", "Surface Pro 2", "Surface Pro 3"}
    Shared msModelKind As KnonwnHardwareKind() = New KnonwnHardwareKind() {KnonwnHardwareKind.SurfacePro, KnonwnHardwareKind.SurfacePro2, KnonwnHardwareKind.SurfacePro3}
    Private Shared Sub ParseKindMicrosoft(res As HardwareInfo)
        ParseKindCore(res, msModel, msModelKind)
    End Sub
    Public Enum KnonwnHardwareKind
        Unknown
        SurfacePro
        SurfacePro2
        SurfacePro3
        DellPro8
        DellPro10
    End Enum
    Public Class HardwareInfo
        Public Sub New()
            Kind = KnonwnHardwareKind.Unknown
            Manufacturer = ""
            Model = ""
        End Sub
        Public Property Kind() As KnonwnHardwareKind
            Get
                Return m_Kind
            End Get
            Set(value As KnonwnHardwareKind)
                m_Kind = value
            End Set
        End Property
        Private m_Kind As KnonwnHardwareKind
        Public Property Manufacturer() As String
            Get
                Return m_Manufacturer
            End Get
            Set(value As String)
                m_Manufacturer = value
            End Set
        End Property
        Private m_Manufacturer As String
        Public Property Model() As String
            Get
                Return m_Model
            End Get
            Set(value As String)
                m_Model = value
            End Set
        End Property
        Private m_Model As String
        Public Overrides Function ToString() As String
            If Kind = KnonwnHardwareKind.Unknown Then
                Return String.Format("Unknown: {0}/{1}", Manufacturer, Model)
            End If
            Return String.Format("{0}: {1}/{2}", Kind, Manufacturer, Model)
        End Function
    End Class
    Shared deviceHardwareInfo As HardwareInfo = Nothing
    Shared m_hasBattery As System.Nullable(Of Boolean) = Nothing
    Shared m_chassis As System.Nullable(Of ChassisTypes) = Nothing
    Shared m_hasTouchSupport As System.Nullable(Of Boolean) = Nothing
    Shared m_isWindows8 As System.Nullable(Of Boolean) = Nothing
    Public Shared ReadOnly Property IsWindows8() As Boolean
        Get
            If m_isWindows8 Is Nothing Then
                m_isWindows8 = DetectWindows8()
            End If
            Return m_isWindows8.Value
        End Get
    End Property

    Public Shared Function DetectHardwareInfo() As HardwareInfo
        If deviceHardwareInfo Is Nothing Then
            deviceHardwareInfo = ParseHardwareInfo()
        End If
        Return deviceHardwareInfo
    End Function
    Private Shared Function DetectWindows8() As Boolean
        Try
            Dim win8version = New Version(6, 2, 9200, 0)

            If Environment.OSVersion.Platform = PlatformID.Win32NT AndAlso Environment.OSVersion.Version >= win8version Then
                Return True
            End If
        Catch
        End Try
        Return False
    End Function
    Public Shared ReadOnly Property IsTablet() As Boolean
        Get
            If Not IsWindows8 Then
                Return False
            End If
            If Not HasTouchSupport Then
                Return False
            End If
            Return HasBattery
        End Get
    End Property
    Public Shared ReadOnly Property IsTabletChassis() As Boolean
        Get
            If Chassis = ChassisTypes.Handheld OrElse Chassis = ChassisTypes.Portable Then
                Return True
            End If
            Return False
        End Get
    End Property
    Public Shared ReadOnly Property HasTouchSupport() As Boolean
        Get
            If m_hasTouchSupport Is Nothing Then
                m_hasTouchSupport = CheckTouch()
            End If
            Return m_hasTouchSupport.Value
        End Get
    End Property
    Private Shared Function CheckTouch() As Boolean
        Dim device = System.Windows.Input.Tablet.TabletDevices.Cast(Of System.Windows.Input.TabletDevice)().FirstOrDefault(Function(dev) dev.Type = System.Windows.Input.TabletDeviceType.Touch)
        If device Is Nothing Then
            Return False
        End If
        Return True
    End Function
    Public Shared ReadOnly Property Chassis() As ChassisTypes
        Get
            If m_chassis Is Nothing Then
                m_chassis = GetCurrentChassisType()
            End If
            Return m_chassis.Value
        End Get
    End Property

    Public Shared Function GetCurrentChassisType() As ChassisTypes
        Try
            Dim systemEnclosures = New ManagementClass("Win32_SystemEnclosure")
            For Each obj As ManagementObject In systemEnclosures.GetInstances()
                For Each i As Integer In DirectCast(obj("ChassisTypes"), UInt16())
                    If i > 0 AndAlso i < 25 Then
                        Return CType(i, ChassisTypes)
                    End If
                Next
            Next
        Catch
        End Try
        Return ChassisTypes.Unknown
    End Function
    Public Shared ReadOnly Property HasBattery() As Boolean
        Get
            If m_hasBattery Is Nothing Then
                m_hasBattery = CheckHasBattery()
            End If
            Return m_hasBattery.Value
        End Get
    End Property

    Private Shared Function CheckHasBattery() As Boolean
        Try
            Dim query = New ObjectQuery("Select * FROM Win32_Battery")
            Dim searcher = New ManagementObjectSearcher(query)

            Dim collection = searcher.[Get]()
            Return collection.Count > 0
        Catch
        End Try
        Return False
    End Function
    Public Shared Function SuggestHybridDemoParameters(ByRef touchScale As Single, ByRef fontSize As Single) As Boolean
        touchScale = 2.0F
        fontSize = 11.0F
        Dim h = DetectHardwareInfo()
        Select Case h.Kind
            Case KnonwnHardwareKind.DellPro8
                touchScale = 1.5F
                fontSize = 10
                Return True
            Case KnonwnHardwareKind.DellPro10, KnonwnHardwareKind.SurfacePro, KnonwnHardwareKind.SurfacePro2, KnonwnHardwareKind.SurfacePro3
                touchScale = 2.5F
                fontSize = 8.2F
                Return True


        End Select
        If Screen.PrimaryScreen.WorkingArea.Width > 1500 OrElse Screen.PrimaryScreen.WorkingArea.Height < 800 Then
            touchScale = 1.5F
            fontSize = 10
        End If
        'Quick Hack for Tablet
        'touchScale = 2.5F
        'fontSize = 8.2F
        Return True

    End Function
    Private Shared Function ParseHardwareInfo() As HardwareInfo
        Dim res As New HardwareInfo()
        ParseHardwareInfoCore(res)
        Return res
    End Function
    Private Shared Function ParseHardwareInfoCore(res As HardwareInfo) As Boolean
        Try
            Dim query = New ObjectQuery("Select * FROM Win32_ComputerSystem")
            Dim searcher = New ManagementObjectSearcher(query)
            Dim collection = searcher.[Get]()
            For Each c As Object In collection
                res.Manufacturer = c("Manufacturer").ToString()
                res.Model = c("Model").ToString()
            Next
        Catch
            Return False
        End Try
        ParseKind(res)
        Return True

    End Function
    Private Shared Sub ParseKind(res As HardwareInfo)
        If res.Manufacturer = "Microsoft Corporation" Then
            ParseKindMicrosoft(res)
        End If
        If res.Manufacturer = "DellInc." Then
            ParseKindDell(res)
        End If
    End Sub
End Class


