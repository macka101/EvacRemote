<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SignatureBox1 = New EvacRemote.SignatureBox()
        Me.SuspendLayout()
        '
        'SignatureBox1
        '
        Me.SignatureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SignatureBox1.Location = New System.Drawing.Point(0, 0)
        Me.SignatureBox1.Name = "SignatureBox1"
        Me.SignatureBox1.Size = New System.Drawing.Size(516, 252)
        Me.SignatureBox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 252)
        Me.Controls.Add(Me.SignatureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SignatureBox1 As EvacRemote.SignatureBox
End Class
