Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace ApplicationFramework
	Public Enum ExportType
		Html
		Xml
		Xls
		Txt
	End Enum

	' The base module class of the Application Framework
	Public Class BaseModule
		Inherits System.Windows.Forms.UserControl
		Private components As System.ComponentModel.Container = Nothing
		Private actions_Renamed As Actions

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()
			' Create actions instance
			Me.actions_Renamed = New Actions()
			' Create the hanler on 
			AddHandler Actions.OnPerformModuleAction, AddressOf DoActionModuleHandler
			' Register supported actions
			RegisterActions()
		End Sub
		Public ReadOnly Property Actions() As Actions
			Get
				Return actions_Renamed
			End Get
		End Property
		' This method has to be overrided in the successors classes
		' to update action states, like Enabled and IsDown property
		Public Overridable Sub UpdateActions()
			Actions(ActionKeys.Export_HTML).Enabled = IsExportTypeSupported(ExportType.Html)
			Actions(ActionKeys.Export_XML).Enabled = IsExportTypeSupported(ExportType.Xml)
			Actions(ActionKeys.Export_XLS).Enabled = IsExportTypeSupported(ExportType.Xls)
			Actions(ActionKeys.Export_Text).Enabled = IsExportTypeSupported(ExportType.Txt)
			Actions(ActionKeys.Print).Enabled = HasPrinting
			Actions(ActionKeys.Preview).Enabled = HasPrinting
		End Sub
		' This method has to be overrided in the successors classes 
		' Here you should register supported actions
		Protected Overridable Sub RegisterActions()
			Actions.AddSupportedAction(ActionKeys.Export_HTML, New ActionModuleHandler(AddressOf DoExport))
			Actions.AddSupportedAction(ActionKeys.Export_XML, New ActionModuleHandler(AddressOf DoExport))
			Actions.AddSupportedAction(ActionKeys.Export_XLS, New ActionModuleHandler(AddressOf DoExport))
			Actions.AddSupportedAction(ActionKeys.Export_Text, New ActionModuleHandler(AddressOf DoExport))
			Actions.AddSupportedAction(ActionKeys.Print, New ActionModuleHandler(AddressOf DoPrint))
			Actions.AddSupportedAction(ActionKeys.Preview, New ActionModuleHandler(AddressOf DoPreview))
		End Sub
		Protected Overridable Sub DoActionModuleHandler(ByVal key As Object, ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		' This method has to be overrided in the successors classes 
		'Returns true if the particular export type is supported by the modue
		Protected Overridable Function IsExportTypeSupported(ByVal exportType As ExportType) As Boolean
			Return False
		End Function
		' This method has to be overrided in the successors classes 
		Protected Overridable Sub DoExport(ByVal exportType As ExportType, ByVal AFileName As String)
			'Do nothing by default
		End Sub
		Protected Overridable ReadOnly Property HasPrinting() As Boolean
			Get
				Return False
			End Get
		End Property
		' This method has to be overrided in the successors classes 
'INSTANT VB NOTE: Embedded comments are not maintained by Instant VB
'ORIGINAL LINE: protected virtual void DoPrint() { /* Do nothing by default */ }
		Protected Overridable Sub DoPrint()
		End Sub
		' This method has to be overrided in the successors classes 
'INSTANT VB NOTE: Embedded comments are not maintained by Instant VB
'ORIGINAL LINE: protected virtual void DoPreview() { /* Do nothing by default */ }
		Protected Overridable Sub DoPreview()
		End Sub
		' Returns ExportType by action key
		Protected Function GetExportTypeByAction(ByVal key As Object) As ExportType
			If ActionKeys.Export_XML.Equals(key) Then
				Return ExportType.Xml
			End If
			If ActionKeys.Export_XLS.Equals(key) Then
				Return ExportType.Xls
			End If
			If ActionKeys.Export_Text.Equals(key) Then
				Return ExportType.Txt
			End If
			Return ExportType.Html
		End Function
		' Do exporting
		Private Sub DoExport(ByVal key As Object, ByVal sender As Object, ByVal e As EventArgs)
			'Get Export type
			Dim exportType As ExportType = GetExportTypeByAction(key)
			'Create the save dialog and setup it
			Dim saveDialog As SaveFileDialog = New SaveFileDialog()
			saveDialog.DefaultExt = GetExportDefaultExtenstions(exportType)
			saveDialog.Filter = GetExportFilters(exportType)
			saveDialog.FileName = "export." & saveDialog.DefaultExt
			'Do export if the end user presses OK
			If System.Windows.Forms.DialogResult.OK = saveDialog.ShowDialog() Then
				DoExport(exportType, saveDialog.FileName)
			End If
		End Sub
		' Do printing
		Private Sub DoPrint(ByVal key As Object, ByVal sender As Object, ByVal e As EventArgs)
			DoPrint()
		End Sub
		' Do preview
		Private Sub DoPreview(ByVal key As Object, ByVal sender As Object, ByVal e As EventArgs)
			DoPreview()
		End Sub
		Private Function GetExportDefaultExtenstions(ByVal exportType As ExportType) As String
			Select Case exportType
				Case ExportType.Html
					Return "html"
				Case ExportType.Xml
					Return "xml"
				Case ExportType.Xls
					Return "xls"
				Case ExportType.Txt
					Return "txt"
			End Select
			Return ""
		End Function
		Private Function GetExportFilters(ByVal exportType As ExportType) As String
			Select Case exportType
				Case ExportType.Html
					Return "HTML File (*.html)|*.html"
				Case ExportType.Xml
					Return "XML File (*.xml)|*.xml"
				Case ExportType.Xls
					Return "Microsoft Excel 4.0 Worksheet (*.xls)|*.xls"
				Case ExportType.Txt
					Return "Text file (*.txt)|*.txt"
			End Select
			Return ""
		End Function
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					RemoveHandler Actions.OnPerformModuleAction, AddressOf DoActionModuleHandler
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			' 
			' BaseModule
			' 
			Me.Name = "BaseModule"
			Me.Size = New System.Drawing.Size(224, 208)

		End Sub
		#End Region
	End Class
End Namespace
