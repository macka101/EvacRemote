Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Registrator

Public Class SwipeGridViewInfoRegistrator
    Inherits GridInfoRegistrator
    Public Overrides ReadOnly Property ViewName() As String
        Get
            Return "SwipeGridView"
        End Get
    End Property
    Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
        Return New SwipeGridView(TryCast(grid, GridControl))
    End Function
    Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
        Return New SwipeGridViewInfo(TryCast(view, SwipeGridView))
    End Function
    Public Overrides Function CreateHandler(ByVal view As BaseView) As BaseViewHandler
        Return New SwipeGridHandler(TryCast(view, SwipeGridView))
    End Function
End Class

