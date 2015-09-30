Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Collections
Imports System.ComponentModel
Imports System.Reflection

' Contains information about a category
Public Class CategoryInfo
    Private name_Renamed As String
    Private imageIndex_Renamed As Integer
    Public Sub New(ByVal name_Renamed As String, ByVal imageIndex_Renamed As Integer)
        Me.name_Renamed = name_Renamed
        Me.imageIndex_Renamed = imageIndex_Renamed
    End Sub
    Public ReadOnly Property Name() As String
        Get
            Return name_Renamed
        End Get
    End Property
    Public ReadOnly Property ImageIndex() As Integer
        Get
            Return imageIndex_Renamed
        End Get
    End Property
    Public ReadOnly Property Index() As Integer
        Get
            For i As Integer = 0 To CategoriesInfo.Instance.Count - 1
                If CategoriesInfo.Instance(i) Is Me Then
                    Return i
                End If
            Next i
            Return -1
        End Get
    End Property
End Class
<ListBindable(False)> _
Public Class CategoriesInfo
    Inherits CollectionBase
    Private Shared instance_Renamed As CategoriesInfo
    ' create the static instance of the class
    Shared Sub New()
        instance_Renamed = New CategoriesInfo()
    End Sub
    Default Public ReadOnly Property Item(ByVal index As Integer) As CategoryInfo
        Get
            Return TryCast(List(index), CategoryInfo)
        End Get
    End Property
    Default Public ReadOnly Property Item(ByVal name As String) As CategoryInfo
        Get
            For i As Integer = 0 To Count - 1
                If name.ToUpper() = Me(i).Name.ToUpper() Then
                    Return Me(i)
                End If
            Next i
            Return Nothing
        End Get
    End Property
    ' Register the category in the system
    Public Shared Sub Add(ByVal name As String, ByVal imageIndex As Integer)
        Dim item As CategoryInfo = New CategoryInfo(name, imageIndex)
        instance_Renamed.List.Add(item)
    End Sub
    Public Shared Sub Add(ByVal name As String)
        CategoriesInfo.Add(name, -1)
    End Sub
    Public Shared ReadOnly Property Instance() As CategoriesInfo
        Get
            Return instance_Renamed
        End Get
    End Property
End Class

' Contains information about a module
Public Class ModuleInfo
    Private name_Renamed As String
    Private moduleType As Type
    Private _module As BaseModule
    Private category_Renamed As CategoryInfo
    Private imageIndex_Renamed As Integer
    Public Sub New(ByVal name_Renamed As String, ByVal moduleType As Type, ByVal category_Renamed As CategoryInfo, ByVal imageIndex_Renamed As Integer)
        ' throw exception if the module is not inherited from BaseModule class
        If (Not moduleType.IsSubclassOf(GetType(BaseModule))) Then
            Throw New ArgumentException("moduleClass has to be inherited from BaseModule")
        End If
        ' if there is no any category yet, create the default one
        If CategoriesInfo.Instance.Count = 0 Then
            CategoriesInfo.Add("Default")
        End If
        If category_Renamed Is Nothing Then
            category_Renamed = CategoriesInfo.Instance(0)
        End If
        Me.name_Renamed = name_Renamed
        Me.category_Renamed = category_Renamed
        Me.imageIndex_Renamed = imageIndex_Renamed
        Me.moduleType = moduleType
        Me._module = Nothing
    End Sub
    Public ReadOnly Property Category() As CategoryInfo
        Get
            Return category_Renamed
        End Get
    End Property
    Public ReadOnly Property ImageIndex() As Integer
        Get
            Return imageIndex_Renamed
        End Get
    End Property
    Public ReadOnly Property Name() As String
        Get
            Return Me.name_Renamed
        End Get
    End Property
    'Show the module on the particular control
    Public Sub Show(ByVal control As Control)
        CreateModule()
        _module.Visible = False
        _module.Parent = control
        _module.Dock = DockStyle.Fill
        _module.Visible = True
    End Sub
    'Make the module invisible
    Public Sub Hide()
        If Not _module Is Nothing Then
            _module.Visible = False
        End If
    End Sub
    ' Create the module instance
    Protected Sub CreateModule()
        If Me._module Is Nothing Then
            Dim constructorInfoObj As ConstructorInfo = moduleType.GetConstructor(Type.EmptyTypes)
            If constructorInfoObj Is Nothing Then
                Throw New ApplicationException(moduleType.FullName & " doesn't have public constructor with empty parameters")
            End If
            Me._module = TryCast(constructorInfoObj.Invoke(Nothing), BaseModule)
        End If
    End Sub
    ' Module instance
    Public ReadOnly Property GUIModule() As BaseModule
        Get
            Return Me._module
        End Get
    End Property
End Class

' The list of modules registered in the system
<ListBindable(False)> _
Public Class ModuleInfoCollection
    Inherits CollectionBase
    Private Shared instance_Renamed As ModuleInfoCollection
    Private currentModule As ModuleInfo
    ' create the static instance of the class
    Shared Sub New()
        instance_Renamed = New ModuleInfoCollection()
    End Sub
    Private Sub New()
        Me.currentModule = Nothing
    End Sub
    Default Public ReadOnly Property Item(ByVal index As Integer) As ModuleInfo
        Get
            Return TryCast(List(index), ModuleInfo)
        End Get
    End Property
    Default Public ReadOnly Property Item(ByVal name As String) As ModuleInfo
        Get
            For Each info As ModuleInfo In Me
                If info.Name.Equals(name) Then
                    Return info
                End If
            Next info
            Return Nothing
        End Get
    End Property
    ' Register the module in the system
    Public Shared Sub Add(ByVal name As String, ByVal moduleType As Type, ByVal category As CategoryInfo, ByVal imageIndex As Integer)
        Dim item As ModuleInfo = New ModuleInfo(name, moduleType, category, imageIndex)
        instance_Renamed.Add(item)
    End Sub
    Public Shared ReadOnly Property Instance() As ModuleInfoCollection
        Get
            Return instance_Renamed
        End Get
    End Property
    'Show the module on the particular control
    Public Shared Sub ShowModule(ByVal item As ModuleInfo, ByVal parent As Control)
        If item Is instance_Renamed.currentModule Then
            Return
        End If
        If Not instance_Renamed.currentModule Is Nothing Then
            instance_Renamed.currentModule.Hide()
        End If
        item.Show(parent)
        instance_Renamed.currentModule = item
        ' update UI action objects
        item.GUIModule.Actions.UpdateVisibility()
        item.GUIModule.UpdateActions()
    End Sub
    ' return the currently showing module
    Public Shared ReadOnly Property CurrentModuleInfo() As ModuleInfo
        Get
            Return instance_Renamed.currentModule
        End Get
    End Property
    Private Sub Add(ByVal value As ModuleInfo)
        If List.IndexOf(value) < 0 Then
            List.Add(value)
        End If
    End Sub
End Class
