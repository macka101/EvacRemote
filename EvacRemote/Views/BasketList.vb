Imports System.Data.Odbc
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo

Imports EvacRemote.GlobalVariables

Public Class BasketList
    Private _Loaded As Boolean = False
    Private _Category As String = "Evac"
    Dim dsContacts As New DataSet

    Private _parent As frmMain = Nothing
    Public ReadOnly Property Loaded As Boolean
        Get
            Return _Loaded
        End Get
    End Property
    Public Sub InitData()
        FetchData()
    End Sub
    Public Property ParentFormMain() As frmMain
        Get
            Return _parent
        End Get
        Set(ByVal value As frmMain)
            If (Not Object.Equals(_parent, Nothing)) Then
                Return
            End If
            _parent = value
        End Set
    End Property
    Private Sub FetchData()
        GridControl1.BeginUpdate()
        GridControl1.DataSource = ThisBasket.Items
        GridControl1.EndUpdate()
        _Loaded = True
    End Sub

    Public Sub New(ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs)
        '  ParentFormMain.ViewContact("300")
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs)

        Dim oRow As DataRowView = GridView1.GetFocusedRow
        ParentFormMain.ViewContact(oRow.Item("contno"))

    End Sub

    Private Sub btnSetCurrent_Click(sender As Object, e As EventArgs)
        Dim oRow As DataRowView = GridView1.GetFocusedRow
        iCont = oRow.Item("contno")
        SIBasket.Text = String.Format("CONTACT <color=47, 81, 165>{0} {1} ", oRow.Item("divname"), oRow.Item("contact"))
        ParentFormMain.HtmlText = SIBasket.Text
    End Sub
End Class
