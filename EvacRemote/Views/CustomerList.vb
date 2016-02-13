Imports System.Data.Odbc
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo

Imports EvacRemote.GlobalVariables
Imports DevExpress.Xpo

Public Class CustomerList
    Private _Loaded As Boolean = False
    Private _Category As String = "Evac"
    Private dsContacts As New DataSet
    Private _session As UnitOfWork
    Private _parent As frmMain = Nothing
    Public ReadOnly Property Loaded As Boolean
        Get
            Return _Loaded
        End Get
    End Property
    Public Sub InitData()
        teName.Focus()
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
        dsContacts.Clear()
        Dim sSql As String = "SELECT contno,division.divno, trim(contact.title || ' ' ||  contact.forename || ' ' ||  contact.surname) as contact,"
        sSql = sSql + "division.divname,division.oprano,address.address1,address.address2,address.address3,address.address4,address.postcode"
        sSql = sSql + " FROM ( contact JOIN division ON contact.divno = division.divno ) JOIN address ON division.addrno = address.addrno "

        Dim sWhere As String = String.Empty
        If Not teName.Text = String.Empty Then
            sWhere = sWhere + String.Format("where (contact.forename like '%{0}%' ", teName.Text.Trim)
            sWhere = sWhere + String.Format("or contact.surname like '%{0}%' ", teName.Text.Trim)
            sWhere = sWhere + String.Format("or division.divname like '%{0}%') ", teName.Text.Trim)
        End If
        If Not tePostCode.Text = String.Empty Then
            sWhere = sWhere + String.Format(" {0} PostCode Like '{1}%' ", IIf(sWhere = String.Empty, "where ", " and "), tePostCode.Text.Trim)
        End If

        If sWhere <> String.Empty Then
            sSql = sSql + sWhere
        End If

        Dim da As New OdbcDataAdapter(sSql, cn)
        da.Fill(dsContacts, "Contacts")
        GridControl1.DataSource = dsContacts.Tables("Contacts")
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Visible = False
        _Loaded = True
    End Sub

    Public Sub New(ByVal session As Session, ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _session = session
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs)
        ParentFormMain.ViewContact("300")
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs)

        Dim oRow As DataRowView = GridView1.GetFocusedRow
        ParentFormMain.ViewContact(oRow.Item("contno"))

    End Sub

    Private Sub btnSetCurrent_Click(sender As Object, e As EventArgs) Handles btnSetCurrent.Click
        Dim oRow As DataRowView = GridView1.GetFocusedRow
        If oRow IsNot Nothing Then
            iCont = oRow.Item("contno")
            iDivison = oRow.Item("divno")
            SIContact.Text = String.Format("CONTACT <color=47, 81, 165>{0} {1} ", oRow.Item("divname"), oRow.Item("contact"))
            ParentFormMain.HtmlText = SIContact.Text.Trim
            ThisBasket = New Basket(_session, ParentFormMain, oRow.Item("contno"))
            ParentFormMain.SurveyEnabled(True)
        End If
    End Sub

    
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            btnSetCurrent.Enabled = False
            FetchData()
            btnSetCurrent.Enabled = True
            btnSetCurrent.Visible = True
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub teName_KeyDown(sender As Object, e As KeyEventArgs) Handles teName.KeyDown
        If e.KeyCode = Keys.Return Then
            FetchData()
        End If

    End Sub
End Class
