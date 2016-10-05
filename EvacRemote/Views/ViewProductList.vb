Imports System.Data.Odbc
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo

Imports EvacRemote.GlobalVariables
Imports DevExpress.Xpo
Imports Esso.Data
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering

Public Class ViewProductList
    Private _Loaded As Boolean = False
    Private _session As UnitOfWork
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

        Dim current As Integer = vw_Products.FocusedRowHandle
        Dim _ProductView As XPView = New XPView(_session, GetType(Product))
        _ProductView.AddProperty("Oid", "Oid")
        _ProductView.AddProperty("ProductCode", "ProductCode")
        _ProductView.AddProperty("Description", "Description")

        Dim sortCollection As SortingCollection = New SortingCollection()
        sortCollection.Add(New SortProperty("ProductCode", SortingDirection.Ascending))

        _ProductView.Sorting = sortCollection
        grdProducts.DataSource = _ProductView
        If current >= 0 Then
            If current < vw_Products.RowCount Then
                vw_Products.FocusedRowHandle = current
            End If
        End If

        _Loaded = True
    End Sub

    Public Sub New(ByVal session As Session, ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = session
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub GridView1_Click(sender As Object, e As EventArgs)
        ViewProduct()
    End Sub
    Private Sub ViewProduct()
        If CurrentProduct IsNot Nothing Then
            Using frmProduct As New ProductDetail(CurrentProduct)
                Me.Hide()
                frmProduct.Parent = frmMain.MainPnl
                frmProduct.Dock = DockStyle.Fill
                frmProduct.Initdata()
                '  _Survey.Visible = False
                frmProduct.Visible = True
            End Using

            '            ParentFormMain.SelectPage(frmMain.ePage.ProductDetail)
        End If

    End Sub
    Private ReadOnly Property CurrentProduct() As Product
        Get
            If vw_Products.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            Return _session.FindObject(Of Product)(CriteriaOperator.Parse("Oid = ?", CurrentOid))
        End Get

    End Property
    Private ReadOnly Property CurrentOid() As Guid
        Get
            If vw_Products.FocusedRowHandle < 0 Then
                Return Nothing
            End If
            If vw_Products.Columns("OID") IsNot Nothing Then
                Return DirectCast(vw_Products.GetRowCellValue(vw_Products.FocusedRowHandle, "OID"), Guid)
            Else
                Return DirectCast(vw_Products.GetRowCellValue(vw_Products.FocusedRowHandle, "Oid"), Guid)
            End If
        End Get
    End Property

    Private Sub btnFind_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            FetchData()
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub


    Private Sub vw_Products_DoubleClick(sender As Object, e As EventArgs) Handles vw_Products.DoubleClick
        ViewProduct()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Using frmimport As New frmImportProducts(_session)
            frmimport.ShowDialog()
        End Using
    End Sub
End Class
