'----------------------------------------------------------------------------- 
' 
'  Copyright (c) Microsoft Corporation.  All rights reserved. 
' 
'  File: BiometricEncryptionProviderForInk.vb
'
'  Description: Encrypts the InkSecureSignatureData object and washes the Ink.
'
'----------------------------------------------------------------------------- 

Imports System.Security.Cryptography

''' <summary>
''' Encrypts the entire InkSecureSignatureData object, generates washed Ink, and blanks out the original Ink.
''' </summary>
''' <exclude/>
Public Class BiometricEncryptionProviderForInk

    ' Encryption Code used in part from:
    '  ms-help://MS.VSCC.2003/MS.MSDNQTR.2003FEB.1033/cpguide/html/cpconencryptingdata.htm
    ' Decryption code can be obtained here:
    '  ms-help://MS.VSCC.2003/MS.MSDNQTR.2003FEB.1033/cpguide/html/cpcondecryptingdata.htm

    ' Encrypt the signature data, which includes:
    '  1) Washing the Ink (remove all pressure information from the original Ink).
    '  2) Serializing the InkSecureSignatureDataObject object.
    '  3) Encrypting the serialized InkSecureSignatureDataObject object.
    '  4) Writing the encrypted data to SignatureData.EncryptedBiometricData.
    '  5) Destroying the original Ink.

    ''' <summary>
    ''' Encrypt the signature data.
    ''' </summary>
    ''' <param name="signatureData">An InkSecureSignatureData object containing 
    ''' a signature and its metadata.</param>
    Public Sub Encrypt(ByVal signatureData As InkSecureSignatureData)

        Try

            ' Block sizes and buffer for stream operations.
            Const SMALLEST As Integer = 86
            Const BLOCK As Integer = 128
            Dim Buffer(SMALLEST - 1) As Byte
            ' Variables for Ink data.
            Dim CopyOfSourceInk As New Microsoft.Ink.Ink
            Dim WashedInk As New Microsoft.Ink.Ink
            ' Serialized signature objects.
            Dim SourceStream As New System.IO.MemoryStream
            Dim EncryptedStream As New System.IO.MemoryStream

            signatureData.BiometricEncryptionSubmittedOn = Now

            ' Store the machine name in the HardwareInfo property.
            signatureData.HardwareInfo = Environment.MachineName

            ' Create a working copy of the SignatureData's ink.
            CopyOfSourceInk.Load(signatureData.InkSecureSignature)

            ' Wash each Stroke by using GetFlattenedBezierPoints
            ' to remove all pressure information.
            For Each Stroke As Microsoft.Ink.Stroke In CopyOfSourceInk.Strokes
                WashedInk.CreateStroke(Stroke.GetFlattenedBezierPoints(500))
            Next

            signatureData.InkWashedSignature = WashedInk.Save(Ink.PersistenceFormat.InkSerializedFormat, Ink.CompressionMode.Default)

            ' Create a key and establish RSAKeyInfo.
            Dim PublicKey As Byte() = {214, 46, 220, 83, 160, 73, 40, 39, 201, 155, _
                19, 202, 3, 11, 191, 178, 56, 74, 90, 36, 248, 103, 18, 144, 170, _
                163, 145, 87, 54, 61, 34, 220, 222, 207, 137, 149, 173, 14, 92, _
                120, 206, 222, 158, 28, 40, 24, 30, 16, 175, 108, 128, 35, 230, _
                118, 40, 121, 113, 125, 216, 130, 11, 24, 90, 48, 194, 240, 105, _
                44, 76, 34, 57, 249, 228, 125, 80, 38, 9, 136, 29, 117, 207, 139, _
                168, 181, 85, 137, 126, 10, 126, 242, 120, 247, 121, 8, 100, 12, _
                201, 171, 38, 226, 193, 180, 190, 117, 177, 87, 143, 242, 213, 11, _
                44, 180, 113, 93, 106, 99, 179, 68, 175, 211, 164, 116, 64, 148, _
                226, 254, 172, 147}
            Dim Exponent As Byte() = {1, 0, 1}
            Dim RSAKeyInfo As New RSAParameters
            RSAKeyInfo.Modulus = PublicKey
            RSAKeyInfo.Exponent = Exponent
            Dim RSA As New System.Security.Cryptography.RSACryptoServiceProvider
            RSA.ImportParameters(RSAKeyInfo)

            ' Serialize the signature.
            Dim Serializer As New System.Xml.Serialization.XmlSerializer(GetType(InkSecureSignatureData))
            Serializer.Serialize(SourceStream, signatureData)

            ' Cycle through the in-memory stream and encrypt it.
            SourceStream.Position = 0

            While (SourceStream.Read(Buffer, 0, SMALLEST) >= SMALLEST)
                If (SourceStream.Position < SourceStream.Length) Then
                    EncryptedStream.Write(RSA.Encrypt(Buffer, True), 0, BLOCK)
                End If
            End While

            ' Handle the remaining bytes in the stream.
            Dim Amount As Integer = SourceStream.Length Mod SMALLEST
            Dim Remaining(Amount - 1) As Byte
            Array.Copy(Buffer, Remaining, Amount)
            EncryptedStream.Write(RSA.Encrypt(Remaining, True), 0, BLOCK)

            ' Place the encrypted data in the InkSecureSignatureData object.
            signatureData.EncryptedBiometricData = EncryptedStream.ToArray()
            signatureData.BiometricEncryptionCompletedOn = Now

            ' Blank out the original signature to prevent expropriation.
            signatureData.InkSecureSignature = Nothing

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class