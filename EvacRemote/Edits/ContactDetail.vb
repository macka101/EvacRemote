Imports System.Devices.Geolocation
Imports Esso.Data
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors


Public Class ContactDetail
    Private _parent As frmMain = Nothing
    Private _session As UnitOfWork
    Private _contact As Contact
    Private _address As Address

    Private _binding As Boolean = False
    Private _changed As Boolean = False

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

    Public Sub Initdata(session As UnitOfWork, contact As Contact)
        _session = session

        If contact Is Nothing Then
            _contact = New Contact(_session)
        Else
            _contact = contact
            _address = contact.Address

        End If
        Initdata()
    End Sub

    Public Sub New(ByVal parent As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        If _changed = True Then
            Dim b_save As DialogResult = XtraMessageBox.Show("Save Changes", "Save", MessageBoxButtons.YesNoCancel)
            If b_save = DialogResult.Cancel Then
                Exit Sub
            End If
            If b_save = DialogResult.Yes Then
                SaveData()
            End If
        End If
        ParentFormMain.SelectPage(frmMain.ePage.ContactList)
    End Sub
    Private Sub InitData()
        _binding = True

        InitEditors()
        teForename.EditValue = _contact.Forename
        teSurname.EditValue = _contact.Surname
        tePhone.EditValue = _contact.Phone
        teEmail.EditValue = _contact.Email

        teAddress1.EditValue = _address.Address1
        teAddress2.EditValue = _address.Address2
        teAddress3.EditValue = _address.Address3
        teAddress4.EditValue = _address.Address4
        tePostCode.EditValue = _address.PostCode

        _binding = False
    End Sub
    Private Sub SaveData()
        _contact.Forename = CStr(teForename.EditValue)
        _contact.Surname = CStr(teSurname.EditValue)
        _contact.Phone = CStr(tePhone.EditValue)
        _contact.Email = CStr(teEmail.EditValue)
        _contact.Save()

        _address.Address1 = CStr(teAddress1.EditValue)
        _address.Address2 = CStr(teAddress2.EditValue)
        _address.Address3 = CStr(teAddress3.EditValue)
        _address.Address4 = CStr(teAddress4.EditValue)
        _address.PostCode = CStr(tePostCode.EditValue)
        _address.Save()
        _session.CommitChanges()

    End Sub
    Private Sub InitEditors()
        teForename.Properties.MaxLength = _contact.ClassInfo.GetMember("Forename").MappingFieldSize
        teSurname.Properties.MaxLength = _contact.ClassInfo.GetMember("Surname").MappingFieldSize
        teAddress1.Properties.MaxLength = _address.ClassInfo.GetMember("Address1").MappingFieldSize
        teAddress2.Properties.MaxLength = _address.ClassInfo.GetMember("Address2").MappingFieldSize
        teAddress3.Properties.MaxLength = _address.ClassInfo.GetMember("Address3").MappingFieldSize
        teAddress4.Properties.MaxLength = _address.ClassInfo.GetMember("Address4").MappingFieldSize
        tePostCode.Properties.MaxLength = _address.ClassInfo.GetMember("PostCode").MappingFieldSize
        tePhone.Properties.MaxLength = _contact.ClassInfo.GetMember("Phone").MappingFieldSize
        teEmail.Properties.MaxLength = _contact.ClassInfo.GetMember("Email").MappingFieldSize

        AddHandler teForename.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teSurname.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teAddress1.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teAddress2.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teAddress3.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tePostCode.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler tePhone.EditValueChanged, AddressOf edit_EditValueChanged
        AddHandler teEmail.EditValueChanged, AddressOf edit_EditValueChanged
    End Sub
    Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If _binding = False Then
            _changed = True
        End If
    End Sub
End Class
