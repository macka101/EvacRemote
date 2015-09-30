'-------------------------------------------------------------------------- 
' 
'  Copyright (c) Microsoft Corporation.  All rights reserved. 
' 
'  File: InkSecureSignatureSample.vb
'
'  Description: Demonstration and test form for InkSecureSignature.
'
'-------------------------------------------------------------------------- 

Public Class InkSecureSignatureSample
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    ''' <summary>
    ''' Initialize a new instance of the InkSecureSignatureSample form.
    ''' </summary>
    Public Sub New()
        MyBase.New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    ' Form overrides dispose to clean up the component list.
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
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents setValueButton As System.Windows.Forms.Button
    Friend WithEvents printTipLabel As System.Windows.Forms.Label
    Friend WithEvents printPanel As System.Windows.Forms.Panel
    Friend WithEvents valueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents printGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents dataGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents signatureGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents InkSecureSignature As Microsoft.TabletPC.InkSecureSignature.InkSecureSignature
    Friend WithEvents resetButton As System.Windows.Forms.Button
    Friend WithEvents DataTipLabel As System.Windows.Forms.Label
    Friend WithEvents signatureTipLabel As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(InkSecureSignatureSample))
        Me.printPanel = New System.Windows.Forms.Panel
        Me.printButton = New System.Windows.Forms.Button
        Me.valueTextBox = New System.Windows.Forms.TextBox
        Me.setValueButton = New System.Windows.Forms.Button
        Me.printGroupBox = New System.Windows.Forms.GroupBox
        Me.printTipLabel = New System.Windows.Forms.Label
        Me.dataGroupBox = New System.Windows.Forms.GroupBox
        Me.DataTipLabel = New System.Windows.Forms.Label
        Me.signatureGroupBox = New System.Windows.Forms.GroupBox
        Me.signatureTipLabel = New System.Windows.Forms.Label
        Me.resetButton = New System.Windows.Forms.Button
        Me.InkSecureSignature = New Microsoft.TabletPC.InkSecureSignature.InkSecureSignature
        Me.printGroupBox.SuspendLayout()
        Me.dataGroupBox.SuspendLayout()
        Me.signatureGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'printPanel
        '
        Me.printPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.printPanel.Location = New System.Drawing.Point(17, 69)
        Me.printPanel.Name = "printPanel"
        Me.printPanel.Size = New System.Drawing.Size(308, 175)
        Me.printPanel.TabIndex = 2
        '
        'printButton
        '
        Me.printButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.printButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printButton.Location = New System.Drawing.Point(261, 27)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(61, 23)
        Me.printButton.TabIndex = 1
        Me.printButton.Text = "Print"
        '
        'valueTextBox
        '
        Me.valueTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueTextBox.Location = New System.Drawing.Point(8, 51)
        Me.valueTextBox.Multiline = True
        Me.valueTextBox.Name = "valueTextBox"
        Me.valueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.valueTextBox.Size = New System.Drawing.Size(706, 210)
        Me.valueTextBox.TabIndex = 2
        Me.valueTextBox.Text = ""
        '
        'setValueButton
        '
        Me.setValueButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.setValueButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setValueButton.Location = New System.Drawing.Point(633, 18)
        Me.setValueButton.Name = "setValueButton"
        Me.setValueButton.Size = New System.Drawing.Size(74, 23)
        Me.setValueButton.TabIndex = 1
        Me.setValueButton.Text = "Set Value"
        '
        'printGroupBox
        '
        Me.printGroupBox.Controls.Add(Me.printTipLabel)
        Me.printGroupBox.Controls.Add(Me.printButton)
        Me.printGroupBox.Controls.Add(Me.printPanel)
        Me.printGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.printGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printGroupBox.Location = New System.Drawing.Point(394, 14)
        Me.printGroupBox.Name = "printGroupBox"
        Me.printGroupBox.Size = New System.Drawing.Size(341, 261)
        Me.printGroupBox.TabIndex = 1
        Me.printGroupBox.TabStop = False
        Me.printGroupBox.Text = "Printing Feature"
        '
        'printTipLabel
        '
        Me.printTipLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.printTipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printTipLabel.Location = New System.Drawing.Point(19, 23)
        Me.printTipLabel.Name = "printTipLabel"
        Me.printTipLabel.Size = New System.Drawing.Size(222, 30)
        Me.printTipLabel.TabIndex = 0
        Me.printTipLabel.Text = "Tap ""Print"" to call the control's Print method and print the signature below."
        '
        'dataGroupBox
        '
        Me.dataGroupBox.Controls.Add(Me.DataTipLabel)
        Me.dataGroupBox.Controls.Add(Me.valueTextBox)
        Me.dataGroupBox.Controls.Add(Me.setValueButton)
        Me.dataGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dataGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataGroupBox.Location = New System.Drawing.Point(14, 280)
        Me.dataGroupBox.Name = "dataGroupBox"
        Me.dataGroupBox.Size = New System.Drawing.Size(721, 270)
        Me.dataGroupBox.TabIndex = 2
        Me.dataGroupBox.TabStop = False
        Me.dataGroupBox.Text = "Data Feature"
        '
        'DataTipLabel
        '
        Me.DataTipLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DataTipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataTipLabel.Location = New System.Drawing.Point(16, 21)
        Me.DataTipLabel.Name = "DataTipLabel"
        Me.DataTipLabel.Size = New System.Drawing.Size(604, 16)
        Me.DataTipLabel.TabIndex = 0
        Me.DataTipLabel.Text = "This textbox shows the Value property of the control.  To use a saved value, past" & _
        "e it in the textbox below and tap ""Set Value""."
        '
        'signatureGroupBox
        '
        Me.signatureGroupBox.Controls.Add(Me.signatureTipLabel)
        Me.signatureGroupBox.Controls.Add(Me.resetButton)
        Me.signatureGroupBox.Controls.Add(Me.InkSecureSignature)
        Me.signatureGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signatureGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signatureGroupBox.Location = New System.Drawing.Point(14, 14)
        Me.signatureGroupBox.Name = "signatureGroupBox"
        Me.signatureGroupBox.Size = New System.Drawing.Size(366, 261)
        Me.signatureGroupBox.TabIndex = 0
        Me.signatureGroupBox.TabStop = False
        Me.signatureGroupBox.Text = "Signature Control"
        '
        'signatureTipLabel
        '
        Me.signatureTipLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signatureTipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signatureTipLabel.Location = New System.Drawing.Point(15, 23)
        Me.signatureTipLabel.Name = "signatureTipLabel"
        Me.signatureTipLabel.Size = New System.Drawing.Size(265, 33)
        Me.signatureTipLabel.TabIndex = 0
        Me.signatureTipLabel.Text = "Sign the panel below, enter the signer's name, and tap ""Accept"".  Tap ""Reset"" to " & _
        "reset the sample."
        '
        'resetButton
        '
        Me.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.resetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetButton.Location = New System.Drawing.Point(290, 27)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(61, 23)
        Me.resetButton.TabIndex = 1
        Me.resetButton.Text = "Reset"
        '
        'InkSecureSignature
        '
        Me.InkSecureSignature.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.InkSecureSignature.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InkSecureSignature.Location = New System.Drawing.Point(9, 69)
        Me.InkSecureSignature.Name = "InkSecureSignature"
        Me.InkSecureSignature.SignatureComplete = False
        Me.InkSecureSignature.SignersNameCaption = "Signer: "
        Me.InkSecureSignature.Size = New System.Drawing.Size(350, 175)
        Me.InkSecureSignature.TabIndex = 2
        Me.InkSecureSignature.Value = "<?xml version=""1.0""?>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "<InkSecureSignatureData xmlns:xsd=""http://www.w3.org/2001/XMLSch" & _
        "ema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "  <AcquiredSignatur" & _
        "eStartOn>2005-05-04T14:37:21.7183701-07:00</AcquiredSignatureStartOn>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "  <Biomet" & _
        "ricEncryptionCompletedOn>0001-01-01T00:00:00.0000000-08:00</BiometricEncryptionC" & _
        "ompletedOn>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "  <BiometricEncryptionSubmittedOn>0001-01-01T00:00:00.0000000-08:00" & _
        "</BiometricEncryptionSubmittedOn>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "  <SignerAcceptedOn>0001-01-01T00:00:00.00000" & _
        "00-08:00</SignerAcceptedOn>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "</InkSecureSignatureData>"
        '
        'InkSecureSignatureSample
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(748, 559)
        Me.Controls.Add(Me.signatureGroupBox)
        Me.Controls.Add(Me.dataGroupBox)
        Me.Controls.Add(Me.printGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "InkSecureSignatureSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InkSecureSignature Sample"
        Me.printGroupBox.ResumeLayout(False)
        Me.dataGroupBox.ResumeLayout(False)
        Me.signatureGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' Bitmap to persist the Print Preview output.
    Private mPrintBitmap As Bitmap

    '
    ' printButton_Click
    '
    ' Occurs when the Button is clicked to create a printable signature.
    '
    ' Parameters:
    '  sender - The source Button object for this event.
    '  e - The EventArgs object that contains the event data.
    ' 
    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printButton.Click

        ' Create a new bitmap the size of the print output window.
        mPrintBitmap = New Bitmap(printPanel.Width, printPanel.Height, Imaging.PixelFormat.Format32bppPArgb)

        ' Create a graphics context from that bitmap image.
        Dim graphics As Graphics = System.Drawing.Graphics.FromImage(mPrintBitmap)

        ' Print the InkSecureSignature to the bitmap.
        InkSecureSignature.Print(graphics, New Point(1, 1))

        ' Clean up.
        graphics.Dispose()

        ' Put the bitmap in the print preview window.
        printPanel.BackgroundImage = mPrintBitmap

    End Sub

    '
    ' setValueButton_Click
    '
    ' Occurs when the Button is clicked to set the signature control's Value property.
    '
    ' Parameters:
    '  sender - The source Button object for this event.
    '  e - The EventArgs object that contains the event data.
    ' 
    Private Sub setValueButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setValueButton.Click

        If valueTextBox.Text <> "" Then
            InkSecureSignature.Value = valueTextBox.Text
        End If

    End Sub

    '
    ' resetButton_Click
    '
    ' Occurs when the Button is clicked to reset the sample form.
    '
    ' Parameters:
    '  sender - The source Button object for this event.
    '  e - The EventArgs object that contains the event data.
    ' 
    Private Sub resetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetButton.Click

        InkSecureSignature.Reset()
        printPanel.CreateGraphics.Clear(printPanel.BackColor)
        printPanel.BackgroundImage = Nothing
        valueTextBox.Text = ""

    End Sub

    '
    ' InkSecureSignature_Signed
    '
    ' Occurs when the signature has been fully signed.
    '
    ' Parameters:
    '  sender - The source InkSecureSignature object for this event.
    '  e - The EventArgs object that contains the event data.
    ' 
    Private Sub InkSecureSignature_Signed(ByVal sender As Object, ByVal e As EventArgs) Handles InkSecureSignature.Signed

        valueTextBox.Text = CType(sender, Microsoft.TabletPC.InkSecureSignature.InkSecureSignature).Value

    End Sub

End Class
