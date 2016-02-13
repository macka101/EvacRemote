Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports System.Globalization
Imports DevExpress.Utils
Imports DevExpress.Skins
Imports DevExpress.Skins.Info
Imports DevExpress.XtraBars.Docking2010.Customization
Imports System
Imports System.Linq
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Internal
Imports System.Reflection
Imports System.IO
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Xpo

Friend NotInheritable Class Program
    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    Private Sub New()
    End Sub

    <STAThread>
    Shared Sub Main()

        DevExpress.Skins.SkinManager.EnableFormSkins()
        UserLookAndFeel.Default.SetSkinStyle("Office 2013 Light Grey")

        Application.CurrentCulture = CultureInfo.GetCultureInfo("en-GB")
        WindowsFormsSettings.SetDPIAware()
        WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True
        DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
        DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch
        Dim touchScaleFactor As Single, fontSize As Single
        DeviceDetector.SuggestHybridDemoParameters(touchScaleFactor, fontSize)
        WindowsFormsSettings.DefaultFont = New Font("Segoe UI", fontSize)
        WindowsFormsSettings.DefaultMenuFont = New Font("Segoe UI", fontSize)
        WindowsFormsSettings.TouchScaleFactor = touchScaleFactor
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)


        If Environment.MachineName = "JOHN-PC" Then
            ConnectionHelper.ConnectionString = "XpoProvider=MSSqlServer;data source=EVAC2K8\SQL2012;integrated security=SSPI;initial catalog=evacremote"
            ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema)
        Else
            ConnectionHelper.ConnectionString = "XpoProvider=MSSqlServer;data source=JOHN-PC\SQLEXPRESS2008;integrated security=SSPI;initial catalog=evacremote"
            ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists)
        End If

        Application.Run(New frmMain())

    End Sub
   
End Class
