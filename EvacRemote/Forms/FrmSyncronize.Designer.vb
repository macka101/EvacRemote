<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSyncronize
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSyncronize))
        Me.lblPublicationName = New System.Windows.Forms.Label()
        Me.lblSubscriptionName = New System.Windows.Forms.Label()
        Me.pictureBoxStatus = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblLastStatusMessage = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblPublication = New System.Windows.Forms.Label()
        Me.lblSubscription = New System.Windows.Forms.Label()
        Me.tbLastStatusMessage = New System.Windows.Forms.TextBox()
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.btnRemoveSubscription = New System.Windows.Forms.Button()
        CType(Me.pictureBoxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPublicationName
        '
        Me.lblPublicationName.AutoSize = True
        Me.lblPublicationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicationName.Location = New System.Drawing.Point(89, 34)
        Me.lblPublicationName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublicationName.Name = "lblPublicationName"
        Me.lblPublicationName.Size = New System.Drawing.Size(87, 13)
        Me.lblPublicationName.TabIndex = 42
        Me.lblPublicationName.Text = "publication name"
        '
        'lblSubscriptionName
        '
        Me.lblSubscriptionName.AutoSize = True
        Me.lblSubscriptionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubscriptionName.Location = New System.Drawing.Point(89, 11)
        Me.lblSubscriptionName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubscriptionName.Name = "lblSubscriptionName"
        Me.lblSubscriptionName.Size = New System.Drawing.Size(92, 13)
        Me.lblSubscriptionName.TabIndex = 41
        Me.lblSubscriptionName.Text = "subscription name"
        '
        'pictureBoxStatus
        '
        Me.pictureBoxStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBoxStatus.Enabled = False
        Me.pictureBoxStatus.Image = CType(resources.GetObject("pictureBoxStatus.Image"), System.Drawing.Image)
        Me.pictureBoxStatus.Location = New System.Drawing.Point(40, 70)
        Me.pictureBoxStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureBoxStatus.MaximumSize = New System.Drawing.Size(45, 32)
        Me.pictureBoxStatus.MinimumSize = New System.Drawing.Size(45, 32)
        Me.pictureBoxStatus.Name = "pictureBoxStatus"
        Me.pictureBoxStatus.Size = New System.Drawing.Size(45, 32)
        Me.pictureBoxStatus.TabIndex = 40
        Me.pictureBoxStatus.TabStop = False
        Me.pictureBoxStatus.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(441, 404)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 19)
        Me.btnClose.TabIndex = 39
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblLastStatusMessage
        '
        Me.lblLastStatusMessage.AutoSize = True
        Me.lblLastStatusMessage.Location = New System.Drawing.Point(90, 55)
        Me.lblLastStatusMessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastStatusMessage.Name = "lblLastStatusMessage"
        Me.lblLastStatusMessage.Size = New System.Drawing.Size(40, 13)
        Me.lblLastStatusMessage.TabIndex = 38
        Me.lblLastStatusMessage.Text = "Status:"
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Location = New System.Drawing.Point(360, 404)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(77, 19)
        Me.btnStart.TabIndex = 37
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblPublication
        '
        Me.lblPublication.AutoSize = True
        Me.lblPublication.Location = New System.Drawing.Point(18, 34)
        Me.lblPublication.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublication.Name = "lblPublication"
        Me.lblPublication.Size = New System.Drawing.Size(62, 13)
        Me.lblPublication.TabIndex = 36
        Me.lblPublication.Text = "Publication:"
        '
        'lblSubscription
        '
        Me.lblSubscription.AutoSize = True
        Me.lblSubscription.Location = New System.Drawing.Point(18, 11)
        Me.lblSubscription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubscription.Name = "lblSubscription"
        Me.lblSubscription.Size = New System.Drawing.Size(68, 13)
        Me.lblSubscription.TabIndex = 35
        Me.lblSubscription.Text = "Subscription:"
        '
        'tbLastStatusMessage
        '
        Me.tbLastStatusMessage.AcceptsReturn = True
        Me.tbLastStatusMessage.AcceptsTab = True
        Me.tbLastStatusMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLastStatusMessage.Location = New System.Drawing.Point(93, 70)
        Me.tbLastStatusMessage.Margin = New System.Windows.Forms.Padding(2)
        Me.tbLastStatusMessage.Multiline = True
        Me.tbLastStatusMessage.Name = "tbLastStatusMessage"
        Me.tbLastStatusMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbLastStatusMessage.Size = New System.Drawing.Size(426, 312)
        Me.tbLastStatusMessage.TabIndex = 34
        '
        'pbStatus
        '
        Me.pbStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbStatus.Location = New System.Drawing.Point(93, 159)
        Me.pbStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(425, 241)
        Me.pbStatus.TabIndex = 33
        '
        'btnRemoveSubscription
        '
        Me.btnRemoveSubscription.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveSubscription.Location = New System.Drawing.Point(40, 416)
        Me.btnRemoveSubscription.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemoveSubscription.Name = "btnRemoveSubscription"
        Me.btnRemoveSubscription.Size = New System.Drawing.Size(158, 19)
        Me.btnRemoveSubscription.TabIndex = 43
        Me.btnRemoveSubscription.Text = "Remove Subscription"
        Me.btnRemoveSubscription.UseVisualStyleBackColor = True
        '
        'FrmSyncronize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 446)
        Me.Controls.Add(Me.btnRemoveSubscription)
        Me.Controls.Add(Me.lblPublicationName)
        Me.Controls.Add(Me.lblSubscriptionName)
        Me.Controls.Add(Me.pictureBoxStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblLastStatusMessage)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblPublication)
        Me.Controls.Add(Me.lblSubscription)
        Me.Controls.Add(Me.tbLastStatusMessage)
        Me.Controls.Add(Me.pbStatus)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(490, 259)
        Me.Name = "FrmSyncronize"
        Me.Text = "Express Subscription Status"
        CType(Me.pictureBoxStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblPublicationName As System.Windows.Forms.Label
    Private WithEvents lblSubscriptionName As System.Windows.Forms.Label
    Private WithEvents pictureBoxStatus As System.Windows.Forms.PictureBox
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents lblLastStatusMessage As System.Windows.Forms.Label
    Private WithEvents btnStart As System.Windows.Forms.Button
    Private WithEvents lblPublication As System.Windows.Forms.Label
    Private WithEvents lblSubscription As System.Windows.Forms.Label
    Private WithEvents tbLastStatusMessage As System.Windows.Forms.TextBox
    Private WithEvents pbStatus As System.Windows.Forms.ProgressBar
    Private WithEvents btnRemoveSubscription As Button
End Class
