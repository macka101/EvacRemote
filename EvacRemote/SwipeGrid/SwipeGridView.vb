Imports Microsoft.VisualBasic
Imports System


Public Class SwipeGridView
    Inherits DevExpress.XtraGrid.Views.Grid.GridView
    Public Sub New()
        Me.New(Nothing)
    End Sub
    Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
        MyBase.New(grid)
        ' put your initialization code here
    End Sub
    Protected Overrides ReadOnly Property ViewName() As String
        Get
            Return "SwipeGridView"
        End Get
    End Property
End Class

