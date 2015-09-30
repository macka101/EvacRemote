'-------------------------------------------------------------------------- 
' 
'  Copyright (c) Microsoft Corporation.  All rights reserved. 
' 
'  File: InkSecureSignature.vb
'
'  Description: User control for safely collecting an ink signature.
'
'-------------------------------------------------------------------------- 

Imports Microsoft.Ink
Imports System.Drawing
Imports System.Drawing.Drawing2D

''' <summary>
''' User control for safely collecting an ink signature.
''' </summary>
Public Class InkSecureSignature

    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    ''' <summary>
    ''' Initializes a new instance of the InkSecureSignature class.
    ''' </summary>
    Public Sub New()
        MyBase.New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Determine if we are in design time or runtime (based on the owning form).
        SetStyle(ControlStyles.ResizeRedraw, True)

    End Sub

    ''' <summary>
    ''' Releases resources used by the InkSecureSignature object.
    ''' </summary>
    ''' <param name="disposing">Set to true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)

    End Sub

    ' Required by the Windows Form Designer.
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer.
    ' It can be modified using the Windows Form Designer.
    ' Do not modify it using the code editor.
    Friend WithEvents signaturePanel As System.Windows.Forms.Panel
    Friend WithEvents signersNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents signersNameLabel As System.Windows.Forms.Label
    Friend WithEvents acceptButton As System.Windows.Forms.Button
    Friend WithEvents designModeLabel As System.Windows.Forms.Label
    Friend WithEvents clearButton As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.signaturePanel = New System.Windows.Forms.Panel
        Me.designModeLabel = New System.Windows.Forms.Label
        Me.clearButton = New System.Windows.Forms.Button
        Me.signersNameTextBox = New System.Windows.Forms.TextBox
        Me.signersNameLabel = New System.Windows.Forms.Label
        Me.acceptButton = New System.Windows.Forms.Button
        Me.signaturePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'signaturePanel
        '
        Me.signaturePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signaturePanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.signaturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.signaturePanel.Controls.Add(Me.designModeLabel)
        Me.signaturePanel.Controls.Add(Me.clearButton)
        Me.signaturePanel.Location = New System.Drawing.Point(0, 0)
        Me.signaturePanel.Name = "signaturePanel"
        Me.signaturePanel.Size = New System.Drawing.Size(326, 153)
        Me.signaturePanel.TabIndex = 0
        '
        'designModeLabel
        '
        Me.designModeLabel.AutoSize = True
        Me.designModeLabel.Location = New System.Drawing.Point(3, 3)
        Me.designModeLabel.Name = "designModeLabel"
        Me.designModeLabel.Size = New System.Drawing.Size(80, 16)
        Me.designModeLabel.TabIndex = 0
        Me.designModeLabel.Text = "In DesignMode"
        Me.designModeLabel.Visible = False
        '
        'clearButton
        '
        Me.clearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clearButton.Enabled = False
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.clearButton.Location = New System.Drawing.Point(276, 1)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(48, 22)
        Me.clearButton.TabIndex = 1
        Me.clearButton.Text = "&Clear"
        '
        'signersNameTextBox
        '
        Me.signersNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signersNameTextBox.Location = New System.Drawing.Point(82, 156)
        Me.signersNameTextBox.Name = "signersNameTextBox"
        Me.signersNameTextBox.Size = New System.Drawing.Size(190, 20)
        Me.signersNameTextBox.TabIndex = 2
        Me.signersNameTextBox.Text = ""
        '
        'signersNameLabel
        '
        Me.signersNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.signersNameLabel.AutoSize = True
        Me.signersNameLabel.Location = New System.Drawing.Point(2, 158)
        Me.signersNameLabel.Name = "signersNameLabel"
        Me.signersNameLabel.Size = New System.Drawing.Size(81, 16)
        Me.signersNameLabel.TabIndex = 1
        Me.signersNameLabel.Text = "Signer's Name:"
        '
        'acceptButton
        '
        Me.acceptButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.acceptButton.Enabled = False
        Me.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.acceptButton.Location = New System.Drawing.Point(275, 154)
        Me.acceptButton.Name = "acceptButton"
        Me.acceptButton.Size = New System.Drawing.Size(51, 22)
        Me.acceptButton.TabIndex = 3
        Me.acceptButton.Text = "&Accept"
        '
        'InkSecureSignature
        '
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.acceptButton)
        Me.Controls.Add(Me.signersNameTextBox)
        Me.Controls.Add(Me.signersNameLabel)
        Me.Controls.Add(Me.signaturePanel)
        Me.Name = "InkSecureSignature"
        Me.Size = New System.Drawing.Size(327, 180)
        Me.signaturePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' InkOverlay to collect Ink.
    Private WithEvents signatureInkOverlay As InkOverlay
    ' Storage of all Ink signature data.
    Private InkSecureSignatureDataObject As New InkSecureSignatureData
    ' Indicates if this control is in design mode or runtime mode.
    Private inDesignMode As Boolean = True
    ' Locks the signature.
    Private signatureReadOnly As Boolean
    ' The caption for the signer's name.
    Private signersNameCaptionValue As String = "Signer's Name: "

    ''' <summary>
    ''' Occurs when the signature has been fully signed.
    ''' </summary>
    ''' <param name="sender">The source InkSecureSignature object for this event.</param>
    ''' <param name="e">The EventArgs object that contains the event data.</param>
    Public Event Signed(ByVal sender As Object, ByVal e As EventArgs)

    ''' <summary>
    ''' Gets or sets an XML document string containing the entire state of the control.
    ''' </summary>
    Public Property Value() As String

        ' Serialize this object and return it as a string.
        Get
            Dim Serializer As New Xml.Serialization.XmlSerializer(GetType(InkSecureSignatureData))
            ' Create an in-memory stream to hold the serialization.
            Dim Stream As New IO.MemoryStream
            ' Create a StringBuilder object to hold the serialized string.
            Dim SB As New System.Text.StringBuilder
            ' Serialize the object.
            Serializer.Serialize(Stream, InkSecureSignatureDataObject)
            ' Reset the position of the stream back to the start.
            Stream.Position = 0
            ' Create a reader to read the stream.
            Dim Reader As New System.IO.StreamReader(Stream)
            ' Read the stream into the StringBuilder object.
            SB.Append(Reader.ReadToEnd)
            ' Clean up.
            Stream.Close()
            ' Return the serialized string.
            Return SB.ToString
        End Get

        ' Deserialize this object and restore its data.
        Set(ByVal Value As String)
            Try
                ' Create an in-memory stream.
                Dim Stream As New IO.MemoryStream
                ' Create a new writer for the in-memory stream.
                Dim Writer As New IO.StreamWriter(Stream)
                ' Write the passed-in value to the stream.
                Writer.Write(Value)
                ' Ensure that all data has been written.
                Writer.Flush()
                ' Go to the start of the stream.
                Stream.Position = 0

                ' Create a serialization object and deserialize the stream.
                Dim Serializer As New Xml.Serialization.XmlSerializer(GetType(InkSecureSignatureData))
                InkSecureSignatureDataObject = Serializer.Deserialize(Stream)

                ' Check to see if we are loading a signed/accepted signature, or an unaccepted signature.
                If Not InkSecureSignatureDataObject.EncryptedBiometricData Is Nothing AndAlso _
                        InkSecureSignatureDataObject.EncryptedBiometricData.Length > 0 Then
                    ' The signature has already been accepted because we have biometric data.
                    Me.SignatureComplete = True

                    ' Display the signature.
                    Call CreateNewInkOverlay()
                    Call SetDefaultDrawingAttributes(Color.Black)
                    signatureInkOverlay.Ink.Load(InkSecureSignatureDataObject.InkWashedSignature)
                    signaturePanel.Refresh()

                    ' Set the caption and name of the signer.
                    signersNameLabel.Text = signersNameCaptionValue & InkSecureSignatureDataObject.SignersName
                Else
                    ' This signature has NOT been accepted, so display the control in edit mode.
                    signatureReadOnly = False

                    ' Create an Ink region to capture a signature.
                    Call CreateNewInkOverlay()
                    Call SetDefaultDrawingAttributes(Color.Blue)

                    ' Do not collect Ink in design mode, but enable it at runtime.
                    signatureInkOverlay.Enabled = Not inDesignMode

                    ' If there is signature Ink, then load it up.
                    ' The control does not store Ink in the InkSecureSignature field
                    ' until the user clicks Accept, so there will probably
                    ' never be Ink in an unaccepted signature.

                    ' Show disabled command buttons by default.
                    clearButton.Visible = True
                    acceptButton.Visible = True
                    clearButton.Enabled = False
                    acceptButton.Enabled = False

                    If Not InkSecureSignatureDataObject.InkSecureSignature Is Nothing Then
                        signatureInkOverlay.Ink.Load(InkSecureSignatureDataObject.InkSecureSignature)
                        ' If there is at least one Stroke, then enable buttons.
                        clearButton.Enabled = (signatureInkOverlay.Ink.Strokes.Count > 0)
                        acceptButton.Enabled = clearButton.Enabled
                    End If

                    ' Refresh the signaturePanel and set signer fields.
                    signaturePanel.Refresh()

                    ' Set the "Signer's Name:" label and text box data.
                    signersNameLabel.Text = signersNameCaptionValue
                    signersNameTextBox.Text = InkSecureSignatureDataObject.SignersName

                    ' Make sure the text box with the signer's name is visible.
                    signersNameTextBox.Visible = True
                End If

            Catch ex As Exception
                Throw ex
            End Try

        End Set

    End Property

    ''' <summary>
    ''' Gets or sets the override to the default "Signer's Name:" label caption.
    ''' </summary>
    Public Property SignersNameCaption() As String

        Get
            Return signersNameCaptionValue
        End Get

        Set(ByVal Value As String)
            signersNameCaptionValue = Value
            signersNameLabel.Text = signersNameCaptionValue
        End Set

    End Property

    ''' <summary>
    ''' Gets or sets whether the signature has been completed.
    ''' </summary>
    ''' <remarks>
    ''' After the signature is accepted, this property is true, and
    ''' it cannot be changed back to false. This would enable the
    ''' modification of the signature after acceptance.
    ''' </remarks>
    Public Property SignatureComplete() As Boolean

        Get
            Return signatureReadOnly
        End Get

        Set(ByVal Value As Boolean)
            ' If the signature is already accepted, then exit.
            If (signatureReadOnly = True) Or (Value = signatureReadOnly) Then Exit Property

            ' Because we got this far, Value is True, 
            ' so lock all controls and disable Ink collection.
            clearButton.Visible = False
            acceptButton.Visible = False
            If Not signatureInkOverlay Is Nothing Then
                signatureInkOverlay.Enabled = False
            End If
            signersNameTextBox.Visible = False
            ' Set the signer's name label control to the current caption for 
            ' the signer's name plus the actual signer's name.
            signersNameLabel.Text = signersNameCaptionValue & InkSecureSignatureDataObject.SignersName

            ' Set the read-only property value.
            signatureReadOnly = Value
        End Set

    End Property

    '
    ' SignaturePanel_Paint
    '
    ' Occurs when the control is redrawn.
    '
    ' Parameters:
    '  sender - The source Panel object for this event.
    '  e - The PaintEventArgs object that contains the event data.
    '
    Private Sub SignaturePanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles signaturePanel.Paint

        ' Draw the lines and the label.
        Dim DashedLinePen As New Pen(New Drawing2D.HatchBrush(HatchStyle.DashedVertical, SystemColors.Control, SystemColors.ControlDark))
        Dim BottomLineY As Integer = signaturePanel.Height - 20
        Dim TopLineY As Integer = 10

        e.Graphics.DrawLine(DashedLinePen, 0, BottomLineY, signaturePanel.Width, BottomLineY)
        e.Graphics.DrawLine(DashedLinePen, 0, TopLineY, signaturePanel.Width, TopLineY)
        e.Graphics.DrawString("Signature", MyBase.Font, Brushes.Black, 3, BottomLineY + 4)

    End Sub

    '
    ' InkSecureSignature_Load
    '
    ' Occurs before the control becomes visible for the first time.
    '
    ' Parameters:
    '  sender - The source InkSecureSignature object for this event.
    '  e - The EventArgs object that contains the event data.
    '
    Private Sub InkSecureSignature_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Determine Runtime versus Design mode, which controls Ink collection.
        ' If this control is on a form and the Site is Nothing, then it may be runtime.
        ' The final determination is made by looking at Site.DesignMode.
        If Me.FindForm.Site Is Nothing Then
            inDesignMode = False
        Else
            inDesignMode = (Me.FindForm.Site.DesignMode)
        End If

        ' Show the "In Design Mode" label if we are in design mode.
        designModeLabel.Visible = inDesignMode

        ' Create a new InkOverlay.
        If signatureInkOverlay Is Nothing Then
            Call CreateNewInkOverlay()
            Call SetDefaultDrawingAttributes(Color.Blue)
        End If

        ' Enable Ink collection if we are not in design mode 
        ' and the signature is not complete.
        If Not inDesignMode AndAlso Not SignatureComplete Then
            signatureInkOverlay.Enabled = True
        Else
            signatureInkOverlay.Enabled = False
        End If

        ' Disable the buttons by default.
        clearButton.Enabled = False
        acceptButton.Enabled = False

    End Sub

    '
    ' SetDefaultDrawingAttributes
    '
    ' Set the default drawing attributes for ink collection.
    '
    ' Parameters:
    '  color - The desired ink color.
    '
    Private Sub SetDefaultDrawingAttributes(ByVal color As System.Drawing.Color)

        With signatureInkOverlay.DefaultDrawingAttributes
            .Color = color          ' Color.
            .AntiAliased = True     ' Smooth.
            .FitToCurve = False     ' Set to not round (modify) the Stroke.
            .PenTip = PenTip.Ball   ' Ball Point.
            .Width = 20             ' Size.
        End With

    End Sub

    '
    ' signatureInkOverlay_Stroke
    '
    ' On the first Stroke, set the timestamp and button state.
    '
    ' Parameters:
    '  sender - The source InkOverlay object for this event.
    '  e - The InkCollectorStrokeEventArgs object that contains the event data.
    ' 
    Private Sub signatureInkOverlay_Stroke(ByVal sender As Object, ByVal e As Ink.InkCollectorStrokeEventArgs) Handles signatureInkOverlay.Stroke

        ' First, check to ensure that this is the first Stroke, otherwise exit.
        If signatureInkOverlay.Ink.Strokes.Count > 1 Then Exit Sub

        ' Set the Acquired Signature Start On to Now.
        InkSecureSignatureDataObject.AcquiredSignatureStartOn = Now

        ' Enable the clear button.
        clearButton.Enabled = True

        ' Call ValidateData to see if all of the required
        ' criteria has been met to "accept" the signature.
        ValidateData()

    End Sub

    '
    ' signersNameTextBox_TextChanged
    '
    ' Occurs when the Text property value changes.
    '
    ' Parameters:
    '  sender - The source TextBox object for this event.
    '  e - The EventArgs object that contains the event data.
    ' 
    Private Sub signersNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signersNameTextBox.TextChanged

        ' Assign the signer's name from the text box to the underlying data object.
        InkSecureSignatureDataObject.SignersName = signersNameTextBox.Text

        ValidateData()

    End Sub

    '
    ' clearButton_Click
    '
    ' Occurs when the Button is clicked to clear the signature in process.
    '
    ' Parameters:
    '  sender - The source Button object for this event.
    '  e - The EventArgs object that contains the event data.
    ' 
    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        ' Delete the Strokes collection.
        signatureInkOverlay.Ink.DeleteStrokes(signatureInkOverlay.Ink.Strokes)
        ' Invalidating the panel forces a redraw.
        signaturePanel.Invalidate()
        ' Disable the clear button.
        clearButton.Enabled = False
        ' Revalidate the data.
        ValidateData()

    End Sub

    '
    ' CreateNewInkOverlay
    '
    ' Creates or resets the signature InkOverlay object.
    '
    Private Sub CreateNewInkOverlay()

        If Not signatureInkOverlay Is Nothing Then
            signatureInkOverlay.Enabled = False
            signatureInkOverlay.Ink.DeleteStrokes(signatureInkOverlay.Ink.Strokes)
            signatureInkOverlay.AttachedControl = Nothing
            signatureInkOverlay.Dispose()
            signatureInkOverlay = Nothing
        End If

        signatureInkOverlay = New InkOverlay
        signatureInkOverlay.AttachedControl = signaturePanel
        signatureInkOverlay.DefaultDrawingAttributes.AntiAliased = True
        signatureInkOverlay.DefaultDrawingAttributes.FitToCurve = True

    End Sub

    ''' <summary>
    ''' Prints the signature.
    ''' </summary>
    ''' <param name="graphics">The Graphics context to print to.</param>
    ''' <param name="topLeftPoint">The top left corner of the print area.</param>
    Public Sub Print(ByVal graphics As Graphics, ByVal topLeftPoint As Point)

        ' Starting locations.
        Dim Indentation As Integer = 5
        Dim BottomLineY As Integer = 17
        Dim VerticalLocation As Integer = topLeftPoint.Y

        ' Specify a bordered print area slightly smaller than the control.
        Dim ThisRect As New Rectangle(topLeftPoint.X, topLeftPoint.Y, Me.Width, Me.Height - 20)
        Dim BorderColor As Color = Color.FromArgb(255, 0, 45, 150)
        Dim Renderer As New Microsoft.Ink.Renderer

        With graphics
            .FillRectangle(Brushes.White, ThisRect)
            .DrawRectangle(New Pen(BorderColor), ThisRect)

            ' Draw the bottom line.
            .DrawLine(Pens.Black, _
                Indentation, _
                ThisRect.Height - BottomLineY, _
                ThisRect.Width - (2 * Indentation), _
                ThisRect.Height - BottomLineY)

            If SignatureComplete = False Then
                ' Draw a blank signature line.
                .DrawString("Signed: ", _
                    Me.Font, _
                    New SolidBrush(Color.Black), _
                    ThisRect.Left + Indentation, _
                    ThisRect.Height - BottomLineY + 1)
            Else
                ' Draw header text and washed Ink.
                .DrawString("RSA Encrypted Digital Biometric Signature", _
                    Me.Font, _
                    New SolidBrush(Color.Blue), _
                    ThisRect.Left + 3, _
                    VerticalLocation + 3)

                graphics.SmoothingMode = SmoothingMode.AntiAlias
                graphics.CompositingMode = CompositingMode.SourceOver
                graphics.CompositingQuality = CompositingQuality.HighQuality
                graphics.InterpolationMode = InterpolationMode.HighQualityBilinear

                Dim da As New DrawingAttributes(Color.Black)
                da.AntiAliased = True
                da.FitToCurve = True
                da.RasterOperation = RasterOperation.Black
                For Each Stroke As Stroke In signatureInkOverlay.Ink.Strokes
                    Renderer.Draw(graphics, Stroke, da)
                Next

                .DrawString("Signed By: " & _
                    InkSecureSignatureDataObject.SignersName & " on " & _
                    InkSecureSignatureDataObject.SignerAcceptedOn.ToShortDateString & " at " & _
                    InkSecureSignatureDataObject.SignerAcceptedOn.ToShortTimeString, _
                    Me.Font, _
                    New SolidBrush(Color.Blue), _
                    ThisRect.Left + Indentation, _
                    ThisRect.Height - BottomLineY + 1)
            End If
        End With

    End Sub

    ''' <summary>
    ''' Clears signature data to reset the control.
    ''' </summary>
    Public Sub Reset()

        Me.Value = "<InkSecureSignatureData/>"

    End Sub

    '
    ' acceptButton_Click
    '
    ' Occurs when the Button is clicked to lock the signature.
    '
    ' Parameters:
    '  sender - The source Button object for this event.
    '  e - The EventArgs object that contains the event data.
    ' 
    Private Sub acceptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acceptButton.Click

        With InkSecureSignatureDataObject
            ' Save the serialized Ink to the SignatureData.InkSecureSignature property
            ' for encryption by the Biometric Encryption Provider for Ink.
            .InkSecureSignature = signatureInkOverlay.Ink.Save(PersistenceFormat.InkSerializedFormat, CompressionMode.Default)
            .SignerAcceptedOn = Now
        End With

        Dim BiometricEncryptionProvider As New BiometricEncryptionProviderForInk

        Try
            ' Wash and encrypt the signature data.
            BiometricEncryptionProvider.Encrypt(InkSecureSignatureDataObject)

            ' Stop collecting Ink and show the washed Ink.
            Me.SignatureComplete = True
            Call CreateNewInkOverlay()
            Call SetDefaultDrawingAttributes(Color.Black)
            signatureInkOverlay.Ink.Load(InkSecureSignatureDataObject.InkWashedSignature)
            signaturePanel.Refresh()

            ' Tell the calling form that the control is done processing.
            RaiseEvent Signed(Me, New EventArgs)

        Catch ex As Exception
            MsgBox("Unable to encrypt ink signature.  The exception was " & ex.ToString, MsgBoxStyle.Critical, "Unable to Encrypt Biometric")
        End Try

    End Sub

    '
    ' ValidateData
    '
    ' Sets the Accept button's state depending on the presence of required inputs.
    '
    Private Sub ValidateData()

        acceptButton.Enabled = (signatureInkOverlay.Ink.Strokes.Count > 0) And (signersNameTextBox.Text.Length > 0)

    End Sub

    '
    ' signatureInkOverlay_CursorInRange
    '
    ' Occurs when a cursor enters the physical detection range (proximity) 
    ' of the tablet context.
    '
    ' Parameters:
    '  sender - The source InkOverlay object for this event.
    '  e - The InkCollectorCursorInRangeEventArgs object that contains the event data.
    ' 
    Private Sub signatureInkOverlay_CursorInRange(ByVal sender As Object, ByVal e As Ink.InkCollectorCursorInRangeEventArgs) Handles signatureInkOverlay.CursorInRange

        If signatureInkOverlay.Enabled Then
            If e.Cursor.Inverted = True Then
                signatureInkOverlay.EditingMode = InkOverlayEditingMode.Delete
            Else
                signatureInkOverlay.EditingMode = InkOverlayEditingMode.Ink
            End If
        End If

    End Sub

    '
    ' InkSecureSignature_Resize
    '
    ' Occurs when the control is resized.
    '
    ' Parameters:
    '  sender - The source InkSecureSignature object for this event.
    '  e - The EventArgs object that contains the event data.
    ' 
    Private Sub InkSecureSignature_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        signaturePanel.Invalidate()

    End Sub

End Class
