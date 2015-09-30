<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignature
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSigner = New DevExpress.XtraEditors.TextEdit()
        Me.SignatureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.txtSigner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignatureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(408, 22)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(408, 65)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 2
        Me.btCancel.Text = "Cancel"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(408, 113)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 3
        Me.btnConfirm.Text = "Confirm"
        '
        'txtSigner
        '
        Me.txtSigner.Location = New System.Drawing.Point(12, 241)
        Me.txtSigner.Name = "txtSigner"
        Me.txtSigner.Size = New System.Drawing.Size(362, 20)
        Me.txtSigner.TabIndex = 4
        '
        'SignatureBox1
        '
        Me.SignatureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SignatureBox1.Location = New System.Drawing.Point(8, 8)
        Me.SignatureBox1.Name = "SignatureBox1"
        Me.SignatureBox1.Size = New System.Drawing.Size(366, 213)
        Me.SignatureBox1.TabIndex = 5
        Me.SignatureBox1.TabStop = False
        '
        'frmSignature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 287)
        Me.Controls.Add(Me.SignatureBox1)
        Me.Controls.Add(Me.txtSigner)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "frmSignature"
        Me.Text = "Confirmation"
        CType(Me.txtSigner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignatureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSigner As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SignatureBox1 As System.Windows.Forms.PictureBox
End Class
