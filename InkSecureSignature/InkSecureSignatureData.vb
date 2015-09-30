'-------------------------------------------------------------------------- 
' 
'  Copyright (c) Microsoft Corporation.  All rights reserved. 
' 
'  File: InkSecureSignatureData.vb
'
'  Description: Storage structure for InkSecureSignature data.
'
'-------------------------------------------------------------------------- 

''' <summary>
''' Provides storage for InkSecureSignature data.
''' </summary>
''' <exclude/>
<Serializable()> Public Class InkSecureSignatureData

    Private mAcquiredSignatureStartOn As Date
    Private mBiometricEncryptionSubmittedOn As Date
    Private mBiometricEncryptionCompletedOn As Date
    Private mEncryptedBiometricData As Byte()
    Private mHardwareInfo As String
    Private mInkWashedSignature As Byte()
    Private mInkSignature As Byte()
    Private mSignerAcceptedOn As Date
    Private mSignersName As String

    ''' <summary>
    ''' Gets or sets the timestamp when signature creation began.
    ''' </summary>
    Public Property AcquiredSignatureStartOn() As Date

        Get
            Return mAcquiredSignatureStartOn
        End Get

        Set(ByVal Value As Date)
            mAcquiredSignatureStartOn = Value
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets the timestamp when signature data was received back from the biometric encryption provider.
    ''' </summary>
    Public Property BiometricEncryptionCompletedOn() As Date

        Get
            Return mBiometricEncryptionCompletedOn
        End Get

        Set(ByVal Value As Date)
            mBiometricEncryptionCompletedOn = Value
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets the timestamp when signature data was submitted to the biometric encryption provider.
    ''' </summary>
    Public Property BiometricEncryptionSubmittedOn() As Date

        Get
            Return mBiometricEncryptionSubmittedOn
        End Get

        Set(ByVal Value As Date)
            mBiometricEncryptionSubmittedOn = Value
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets the encrypted biometric data.
    ''' </summary>
    Public Property EncryptedBiometricData() As Byte()

        Get
            Return mEncryptedBiometricData
        End Get

        Set(ByVal Value As Byte())
            mEncryptedBiometricData = Value
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets hardware information for the computer that created the signature.
    ''' </summary>
    Public Property HardwareInfo() As String

        Get
            Return mHardwareInfo
        End Get

        Set(ByVal Value As String)
            mHardwareInfo = Value
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets serialized Strokes for the signature that have been altered to strip pressure information.
    ''' </summary>
    Public Property InkWashedSignature() As Byte()

        Get
            Return mInkWashedSignature
        End Get

        Set(ByVal Value As Byte())
            mInkWashedSignature = Value
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets the original Strokes for the signature.
    ''' </summary>
    Protected Friend Property InkSecureSignature() As Byte()

        Get
            Return mInkSignature
        End Get

        Set(ByVal Value As Byte())
            mInkSignature = Value
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets the timestamp for the Accept button click.
    ''' </summary>
    Public Property SignerAcceptedOn() As Date

        Get
            Return mSignerAcceptedOn
        End Get

        Set(ByVal Value As Date)
            mSignerAcceptedOn = Value
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets the text name of the signer.
    ''' </summary>
    Public Property SignersName() As String

        Get
            Return mSignersName
        End Get

        Set(ByVal Value As String)
            mSignersName = Value
        End Set

    End Property

End Class
