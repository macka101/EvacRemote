Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Xpo.Metadata
Imports System.IO

Public Class NonPersistedViews
    <Persistent("vw_SurveyProducts")>
    Public Class SurveyProducts
        Inherits XPLiteObject
        <Key, Persistent>
        Public Oid As Integer
        Public productCode As String
        Public Description As String
        Public Quantity As Integer
        Public UnitPrice As Double
        Public TotalPrice As Double
        Public Discount As Double
    End Class
End Class
