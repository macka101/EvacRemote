Imports DevExpress.XtraGrid.Views.Grid

Friend Class SwipeEnabledView
    Inherits GridView
    'Protected Overrides Function CheckAllowGestures(ByVal point As System.Drawing.Point) As DevExpress.Utils.Gesture.GestureAllowArgs()
    '    Return base.CheckAllowGestures(point)
    'End Function
    Protected Overrides Sub OnSwipeLeft(ByVal rowHandle As Integer)
        MessageBox.Show("SwipeLeft " + rowHandle.ToString())
    End Sub
    Protected Overrides Sub OnSwipeRight(ByVal rowHandle As Integer)
        MessageBox.Show("SwipeRight " + rowHandle.ToString())
    End Sub
    Protected Overrides ReadOnly Property AllowSwipeLeft() As Boolean
        Get
            Return True
        End Get
    End Property
    Protected Overrides ReadOnly Property AllowSwipeRight() As Boolean
        Get
            Return True
        End Get
    End Property
End Class
