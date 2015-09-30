Imports System.Data.Odbc
Imports System.IO
Imports System.Collections

Public Class Buildings
    Inherits ArrayList
    Public Sub New()
        Me.Add(New Building(1, "Head Office", "Not due to open till Oct 2015"))
        Me.Add(New Building(2, "East Stand", "No Access on Last visit"))
        Me.Add(New Building(3, "West Stand", ""))
    End Sub
End Class
Public Class Assets
    Inherits ArrayList
    Public Sub New(ByVal building As Integer)
        If building = 1 Then
            Me.Add(New Asset(1, 1, "96774031279", "Evac+Chair 300H MK4", DateTime.Now, ""))
        ElseIf building = 2 Then
            Me.Add(New Asset(1, 1, "7499-23548", "Evac+Chair 700H ", DateTime.Now, ""))
            Me.Add(New Asset(1, 1, "30845878283", "Evac+Chair 300H MK2", DateTime.Now, ""))
        Else
            Me.Add(New Asset(1, 1, "80073537489", "Evac+Chair 300H", DateTime.Now, ""))
        End If
    End Sub
End Class

'Public Class Stairways
'    Inherits ArrayList
'    Public Sub New(ByVal building As Integer)
'        If building = 1 Then
'            Me.Add(New StairWell(1, 1, "GF Front", "Front Entrance", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'            Me.Add(New StairWell(2, 1, "1F Front", "Front Entrance", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'            Me.Add(New StairWell(3, 1, "1F Rear", "Rear", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'            Me.Add(New StairWell(4, 1, "2F Front", "Front Entrance", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'            Me.Add(New StairWell(5, 1, "2R Front", "Front Entrance", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'        ElseIf building = 2 Then
'            Me.Add(New StairWell(7, 2, "Front", "Vestibule", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'            Me.Add(New StairWell(8, 2, "GF Front", "Front Entrance", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'            Me.Add(New StairWell(9, 2, "GF Front", "Front Entrance", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'            Me.Add(New StairWell(10, 2, "GF Front", "Front Entrance", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'            Me.Add(New StairWell(11, 2, "GF Front", "Front Entrance", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'            Me.Add(New StairWell(12, 2, "GF Front", "Front Entrance", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'            Me.Add(New StairWell(13, 2, "GF Front", "Front Entrance", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'        Else
'            Me.Add(New StairWell(14, 3, "Front", "Vestibule", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'            Me.Add(New StairWell(15, 3, "GF Front", "Front Entrance", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'            Me.Add(New StairWell(16, 3, "GF Front", "Front Entrance", "Closed Riser", "None", "Glass", "32", "220", "", ""))
'        End If


'    End Sub
'End Class

