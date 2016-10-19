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
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        If Debugger.IsAttached Then
            If XtraMessageBox.Show("Run in Touch Mode.", "Touch Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True
            Else
                WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False
            End If
        Else
            If DeviceDetector.CheckTouch = True Then
                WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True
            Else
                WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False
            End If
        End If

        DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
        DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch
        Dim touchScaleFactor As Single, fontSize As Single
        DeviceDetector.SuggestHybridDemoParameters(touchScaleFactor, fontSize)
        WindowsFormsSettings.DefaultFont = New Font("Segoe UI", fontSize)
        WindowsFormsSettings.DefaultMenuFont = New Font("Segoe UI", fontSize)
        WindowsFormsSettings.TouchScaleFactor = touchScaleFactor
       
        If SQLHelper.DBExists() = 0 Then
            MsgBox("No Database detected creating Local Database and Subscription", MsgBoxStyle.Critical)
            Using frmsysnc As New FrmSyncronize(True, False)
                frmsysnc.ShowDialog()
            End Using
        Else
            Dim result As DialogResult = XtraMessageBox.Show(New XtraMessageBoxArgs() With {.Owner = Form.ActiveForm, _
                .Text = "Syncronise Data First", _
                .Caption = "Syncronise", _
                .Buttons = {DialogResult.Yes, DialogResult.No}, _
                .Icon = My.Resources.evacremote})
            If result = DialogResult.Yes Then
                Using frmsysnc As New FrmSyncronize(False, True)
                    frmsysnc.ShowDialog()
                End Using
            End If
        End If

        Application.Run(New frmMain())

    End Sub
   
End Class
