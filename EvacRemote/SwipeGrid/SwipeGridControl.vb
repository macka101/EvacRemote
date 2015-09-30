Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Registrator
Imports System.ComponentModel

<ToolboxItem(True)> _
Public Class SwipeGridControl
    Inherits GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Protected Overrides Function CreateDefaultView() As BaseView
        Return CreateView("SwipeGridView")
    End Function
    Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
        MyBase.RegisterAvailableViewsCore(collection)
        collection.Add(New SwipeGridViewInfoRegistrator())
    End Sub

    Private Sub InitializeComponent()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me
        Me.GridView1.Name = "GridView1"
        '
        'SwipeGridControl
        '
        Me.MainView = Me.GridView1
        Me.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
