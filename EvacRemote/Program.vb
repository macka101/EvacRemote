Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports System.Globalization
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

        DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
        DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch

        WindowsFormsSettings.DefaultFont = New Font("Segoe UI", 10.0)
        WindowsFormsSettings.DefaultMenuFont = New Font("Segoe UI", 10.0)

        '    UserLookAndFeel.Default.TouchScaleFactor = 1.5

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        currentADUser = System.DirectoryServices.AccountManagement.UserPrincipal.Current

        ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly)

        Application.Run(New frmMain())
    End Sub
End Class
