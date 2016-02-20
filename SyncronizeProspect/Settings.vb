Module Settings
    Public Function GetSetting(ByVal Key As String) As String
        Dim sReturn As String = String.Empty
        Dim dsSettings As New DataSet
        If System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "\Settings.xml") Then
            dsSettings.ReadXml(System.AppDomain.CurrentDomain.BaseDirectory & "\Settings.xml")
        Else
            dsSettings.Tables.Add("Settings")
            dsSettings.Tables(0).Columns.Add("Key", GetType(String))
            dsSettings.Tables(0).Columns.Add("Value", GetType(String))
        End If
        Dim dr() As DataRow = dsSettings.Tables("Settings").Select("Key = '" & Key & "'")
        If dr.Length = 1 Then sReturn = dr(0)("Value").ToString
        Return sReturn
    End Function
    Public Sub SetSetting(ByVal Key As String, ByVal Value As String)
        Dim dsSettings As New DataSet
        If System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "\Settings.xml") Then
            dsSettings.ReadXml(System.AppDomain.CurrentDomain.BaseDirectory & "\Settings.xml")
        Else
            dsSettings.Tables.Add("Settings")
            dsSettings.Tables(0).Columns.Add("Key", GetType(String))
            dsSettings.Tables(0).Columns.Add("Value", GetType(String))
        End If
        Dim dr() As DataRow = dsSettings.Tables(0).Select("Key = '" & Key & "'")
        If dr.Length = 1 Then
            dr(0)("Value") = Value
        Else
            Dim drSetting As DataRow = dsSettings.Tables("Settings").NewRow
            drSetting("Key") = Key
            drSetting("Value") = Value
            dsSettings.Tables("Settings").Rows.Add(drSetting)
        End If
        dsSettings.WriteXml(System.AppDomain.CurrentDomain.BaseDirectory & "\Settings.xml")
    End Sub
End Module
