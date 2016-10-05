Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Esso.Data
    Public Class Product
        Inherits XPCustomObject
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        <Persistent("Oid"), Key(True), Browsable(False), MemberDesignTimeVisibility(False)>
        Private _Oid As Guid = Guid.Empty
        <PersistentAlias("_Oid"), Browsable(False)>
        Public ReadOnly Property Oid() As Guid
            Get
                Return _Oid
            End Get
        End Property
        Protected Overrides Sub OnSaving()
            MyBase.OnSaving()
            If Not (TypeOf Session Is NestedUnitOfWork) AndAlso Session.IsNewObject(Me) Then
                _Oid = XpoDefault.NewGuid()
            End If
        End Sub
        Private fproductCode As String
        <Size(15)>
        Public Property ProductCode() As String
            Get
                Return fproductCode
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("productCode", fproductCode, value)
            End Set
        End Property
        Private faccessory As Boolean
        Public Property accessory() As Boolean
            Get
                Return faccessory
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("accessory", faccessory, value)
            End Set
        End Property
        Private fshortDescription As String
        <Size(250)>
        Public Property ShortDescription() As String
            Get
                Return fshortDescription
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("shortDescription", fshortDescription, value)
            End Set
        End Property
        Private fdescription As String
        <Size(400)>
        Public Property Description() As String
            Get
                Return fdescription
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Description", fdescription, value)
            End Set
        End Property
        Private ffeatures As String
        <Size(2000)>
        Public Property Features() As String
            Get
                Return ffeatures
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Features", ffeatures, value)
            End Set
        End Property
        Private fincludes As String
        <Size(2000)>
        Public Property Includes() As String
            Get
                Return fincludes
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Includes", fincludes, value)
            End Set
        End Property
        Private fheight As String
        <Size(50)>
        Public Property Height() As String
            Get
                Return fheight
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Height", fheight, value)
            End Set
        End Property
        Private fwidth As String
        <Size(50)>
        Public Property Width() As String
            Get
                Return fwidth
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Width", fwidth, value)
            End Set
        End Property
        Private fdepth As String
        <Size(50)>
        Public Property Depth() As String
            Get
                Return fdepth
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Depth", fdepth, value)
            End Set
        End Property
        Private fweight As String
        <Size(50)>
        Public Property Weight() As String
            Get
                Return fweight
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Weight", fweight, value)
            End Set
        End Property
        Private floadCapacity As String
        <Size(50)>
        Public Property LoadCapacity() As String
            Get
                Return floadCapacity
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("LoadCapacity", floadCapacity, value)
            End Set
        End Property
        Private fvideo As String
        <Size(255)>
        Public Property Video() As String
            Get
                Return fvideo
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Video", fvideo, value)
            End Set
        End Property
        Private fcertificate As String
        <Size(255)>
        Public Property Certificate() As String
            Get
                Return fcertificate
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Certificate", fcertificate, value)
            End Set
        End Property
        Private fimage As String
        <Size(255)>
        Public Property Image() As String
            Get
                Return fimage
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Image", fimage, value)
            End Set
        End Property
        Private fvideoBase As String
        <Size(255)>
        Public Property VideoBase() As String
            Get
                Return fvideoBase
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("VideoBase", fvideoBase, value)
            End Set
        End Property
   
        Private fevacAid As Boolean
        Public Property EvacAid() As Boolean
            Get
                Return fevacAid
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("EvacAid", fevacAid, value)
            End Set
        End Property
        Private fdisplayOrder As Integer
        Public Property DisplayOrder() As Integer
            Get
                Return fdisplayOrder
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("DisplayOrder", fdisplayOrder, value)
            End Set
        End Property
        Private fvisible As Boolean
        Public Property Visible() As Boolean
            Get
                Return fvisible
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("Visible", fvisible, value)
            End Set
        End Property
        Private fstairclimber As Boolean
        Public Property StairClimber() As Boolean
            Get
                Return fstairclimber
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("StairClimber", fstairclimber, value)
            End Set
        End Property
        Private fbuildingmanagement As Boolean
        Public Property BuildingManagement() As Boolean
            Get
                Return fbuildingmanagement
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("BuildingManagement", fbuildingmanagement, value)
            End Set
        End Property
        Private fdatasheet As String
        <Size(50)>
        Public Property Datasheet() As String
            Get
                Return fdatasheet
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Datasheet", fdatasheet, value)
            End Set
        End Property
        Private _ratingDefault As Integer
        Public Property RatingDefault() As Integer
            Get
                Return _ratingDefault
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingDefault", _ratingDefault, value)
            End Set
        End Property
        Private _ratingHeritage As Integer
        Public Property RatingHeritage() As Integer
            Get
                Return _ratingHeritage
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingHeritage", _ratingHeritage, value)
            End Set
        End Property
        Private _ratingBedBound As Integer
        Public Property RatingBedBound() As Integer
            Get
                Return _ratingBedBound
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingBedBound", _ratingBedBound, value)
            End Set
        End Property
        Private _ratingPublic As Integer
        Public Property RatingPublic() As Integer
            Get
                Return _ratingPublic
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingPublic", _ratingPublic, value)
            End Set
        End Property
        Private _ratingBarriatric As Integer
        Public Property RatingBarriatric() As Integer
            Get
                Return _ratingBarriatric
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingBarriatric", _ratingBarriatric, value)
            End Set
        End Property
        Private _ratingNarrowStairs As Integer
        Public Property RatingNarrowStairs() As Integer
            Get
                Return _ratingNarrowStairs
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingNarrowStairs", _ratingNarrowStairs, value)
            End Set
        End Property
        Private _ratingSteepStairs As Integer
        Public Property RatingSteepStairs() As Integer
            Get
                Return _ratingSteepStairs
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingSteepStairs", _ratingSteepStairs, value)
            End Set
        End Property
        Private _ratingSchool As Integer
        Public Property RatingSchool() As Integer
            Get
                Return _ratingSchool
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingSchool", _ratingSchool, value)
            End Set
        End Property
        Private _ratingCollegeUniversity As Integer
        Public Property RatingCollegeUniversity() As Integer
            Get
                Return _ratingCollegeUniversity
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingCollegeUniversity", _ratingCollegeUniversity, value)
            End Set
        End Property
        Private _ratingShallowStairs As Integer
        Public Property RatingShallowStairs() As Integer
            Get
                Return _ratingShallowStairs
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingShallowStairs", _ratingShallowStairs, value)
            End Set
        End Property
        Private _ratingTightTurning As Integer
        Public Property RatingTightTurning() As Integer
            Get
                Return _ratingTightTurning
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingTightTurning", _ratingTightTurning, value)
            End Set
        End Property
        Private _ratingUnevenGround As Integer
        Public Property RatingUnevenGround() As Integer
            Get
                Return _ratingUnevenGround
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingUnevenGround", _ratingUnevenGround, value)
            End Set
        End Property
        Private _ratingComplexDisability As Integer
        Public Property RatingComplexDisability() As Integer
            Get
                Return _ratingComplexDisability
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingComplexDisability", _ratingComplexDisability, value)
            End Set
        End Property
        Private _ratingHorizontal As Integer
        Public Property RatingHorizontal() As Integer
            Get
                Return _ratingHorizontal
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingHorizontal", _ratingHorizontal, value)
            End Set
        End Property
        Private _ratingSmallStorage As Integer
        Public Property RatingSmallStorage() As Integer
            Get
                Return _ratingSmallStorage
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingSmallStorage", _ratingSmallStorage, value)
            End Set
        End Property
        Private _ratingBedAccess As Integer
        Public Property RatingBedAccess() As Integer
            Get
                Return _ratingBedAccess
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingBedAccess", _ratingBedAccess, value)
            End Set
        End Property
        Private _ratingMisuse As Integer
        Public Property RatingMisuse() As Integer
            Get
                Return _ratingMisuse
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingMisuse", _ratingMisuse, value)
            End Set
        End Property
        Private _ratingUpstairs As Integer
        Public Property RatingUpstairs() As Integer
            Get
                Return _ratingUpstairs
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingUpstairs", _ratingUpstairs, value)
            End Set
        End Property
        Private _ratingSpiral As Integer
        Public Property RatingSpiral() As Integer
            Get
                Return _ratingSpiral
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingSpiral", _ratingSpiral, value)
            End Set
        End Property
        Private _ratingPlastic As Integer
        Public Property RatingPlastic() As Integer
            Get
                Return _ratingPlastic
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingPlastic", _ratingPlastic, value)
            End Set
        End Property
        Private _ratingMovingHangling As Integer
        Public Property RatingMovingHangling() As Integer
            Get
                Return _ratingMovingHangling
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RatingMovingHangling", _ratingMovingHangling, value)
            End Set
        End Property
    End Class
End Namespace