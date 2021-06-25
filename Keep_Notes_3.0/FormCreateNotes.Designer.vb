<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCreateNotes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCreateNotes))
        Me.rtxNoteText = New System.Windows.Forms.RichTextBox()
        Me.txtNoteTitle = New System.Windows.Forms.TextBox()
        Me.lblPromptNote = New System.Windows.Forms.Label()
        Me.btnSubmitANote = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.PictureBox()
        Me.btnSubmitNotes = New System.Windows.Forms.PictureBox()
        Me.lblDateModified = New System.Windows.Forms.Label()
        Me.btnCloseWheel = New System.Windows.Forms.PictureBox()
        Me.pnlColorwheel = New System.Windows.Forms.Panel()
        Me.btnPurple = New System.Windows.Forms.PictureBox()
        Me.btnColorBlue = New System.Windows.Forms.PictureBox()
        Me.btnYellowColor = New System.Windows.Forms.PictureBox()
        Me.btnDefaultColor = New System.Windows.Forms.PictureBox()
        Me.btnRedColor = New System.Windows.Forms.PictureBox()
        Me.btnColorGreen = New System.Windows.Forms.PictureBox()
        Me.btnOpenWheel = New System.Windows.Forms.PictureBox()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.lblDarkMode = New System.Windows.Forms.Label()
        Me.lblGhostMode = New System.Windows.Forms.Label()
        Me.btnGhostModeOn = New System.Windows.Forms.PictureBox()
        Me.btnSettingsDown = New System.Windows.Forms.PictureBox()
        Me.btnOn = New System.Windows.Forms.PictureBox()
        Me.lblSettingsTitle = New System.Windows.Forms.Label()
        Me.btnGhostModeOff = New System.Windows.Forms.PictureBox()
        Me.btnOff = New System.Windows.Forms.PictureBox()
        Me.btnOpenSettings = New System.Windows.Forms.PictureBox()
        Me.TimerColorBar = New System.Windows.Forms.Timer(Me.components)
        Me.btnCalculator = New System.Windows.Forms.PictureBox()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSubmitNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlColorwheel.SuspendLayout()
        CType(Me.btnPurple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnColorBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnYellowColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDefaultColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRedColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnColorGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOpenWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSettings.SuspendLayout()
        CType(Me.btnGhostModeOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettingsDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGhostModeOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOpenSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCalculator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtxNoteText
        '
        Me.rtxNoteText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxNoteText.BackColor = System.Drawing.Color.White
        Me.rtxNoteText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxNoteText.Font = New System.Drawing.Font("Product Sans", 14.25!)
        Me.rtxNoteText.Location = New System.Drawing.Point(49, 230)
        Me.rtxNoteText.Name = "rtxNoteText"
        Me.rtxNoteText.Size = New System.Drawing.Size(595, 292)
        Me.rtxNoteText.TabIndex = 0
        Me.rtxNoteText.Text = ""
        '
        'txtNoteTitle
        '
        Me.txtNoteTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoteTitle.BackColor = System.Drawing.Color.White
        Me.txtNoteTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoteTitle.Font = New System.Drawing.Font("Product Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoteTitle.Location = New System.Drawing.Point(55, 143)
        Me.txtNoteTitle.Name = "txtNoteTitle"
        Me.txtNoteTitle.Size = New System.Drawing.Size(583, 24)
        Me.txtNoteTitle.TabIndex = 1
        '
        'lblPromptNote
        '
        Me.lblPromptNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblPromptNote.AutoSize = True
        Me.lblPromptNote.BackColor = System.Drawing.Color.Transparent
        Me.lblPromptNote.Font = New System.Drawing.Font("Product Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptNote.Location = New System.Drawing.Point(228, -2)
        Me.lblPromptNote.Name = "lblPromptNote"
        Me.lblPromptNote.Size = New System.Drawing.Size(236, 41)
        Me.lblPromptNote.TabIndex = 2
        Me.lblPromptNote.Text = "Creating a Note"
        Me.lblPromptNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmitANote
        '
        Me.btnSubmitANote.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmitANote.Location = New System.Drawing.Point(310, 783)
        Me.btnSubmitANote.Name = "btnSubmitANote"
        Me.btnSubmitANote.Size = New System.Drawing.Size(70, 16)
        Me.btnSubmitANote.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(0, 701)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 55)
        Me.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.TabStop = False
        '
        'btnSubmitNotes
        '
        Me.btnSubmitNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmitNotes.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmitNotes.Image = CType(resources.GetObject("btnSubmitNotes.Image"), System.Drawing.Image)
        Me.btnSubmitNotes.Location = New System.Drawing.Point(616, 701)
        Me.btnSubmitNotes.Name = "btnSubmitNotes"
        Me.btnSubmitNotes.Size = New System.Drawing.Size(75, 55)
        Me.btnSubmitNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnSubmitNotes.TabIndex = 5
        Me.btnSubmitNotes.TabStop = False
        '
        'lblDateModified
        '
        Me.lblDateModified.BackColor = System.Drawing.Color.Transparent
        Me.lblDateModified.Location = New System.Drawing.Point(564, 645)
        Me.lblDateModified.Name = "lblDateModified"
        Me.lblDateModified.Size = New System.Drawing.Size(100, 23)
        Me.lblDateModified.TabIndex = 6
        '
        'btnCloseWheel
        '
        Me.btnCloseWheel.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseWheel.Image = Global.Keep_Notes_3._0.My.Resources.Resources.NewOpenColorLight
        Me.btnCloseWheel.Location = New System.Drawing.Point(230, 15)
        Me.btnCloseWheel.Name = "btnCloseWheel"
        Me.btnCloseWheel.Size = New System.Drawing.Size(69, 67)
        Me.btnCloseWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCloseWheel.TabIndex = 9
        Me.btnCloseWheel.TabStop = False
        '
        'pnlColorwheel
        '
        Me.pnlColorwheel.BackgroundImage = Global.Keep_Notes_3._0.My.Resources.Resources.LightSelectionBar2
        Me.pnlColorwheel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlColorwheel.Controls.Add(Me.btnPurple)
        Me.pnlColorwheel.Controls.Add(Me.btnColorBlue)
        Me.pnlColorwheel.Controls.Add(Me.btnYellowColor)
        Me.pnlColorwheel.Controls.Add(Me.btnDefaultColor)
        Me.pnlColorwheel.Controls.Add(Me.btnRedColor)
        Me.pnlColorwheel.Controls.Add(Me.btnColorGreen)
        Me.pnlColorwheel.Controls.Add(Me.btnCloseWheel)
        Me.pnlColorwheel.Location = New System.Drawing.Point(81, 680)
        Me.pnlColorwheel.Name = "pnlColorwheel"
        Me.pnlColorwheel.Size = New System.Drawing.Size(529, 97)
        Me.pnlColorwheel.TabIndex = 10
        '
        'btnPurple
        '
        Me.btnPurple.BackColor = System.Drawing.Color.Transparent
        Me.btnPurple.Image = Global.Keep_Notes_3._0.My.Resources.Resources.PurpleSelection
        Me.btnPurple.Location = New System.Drawing.Point(12, 15)
        Me.btnPurple.Name = "btnPurple"
        Me.btnPurple.Size = New System.Drawing.Size(67, 66)
        Me.btnPurple.TabIndex = 15
        Me.btnPurple.TabStop = False
        '
        'btnColorBlue
        '
        Me.btnColorBlue.BackColor = System.Drawing.Color.Transparent
        Me.btnColorBlue.Image = Global.Keep_Notes_3._0.My.Resources.Resources.BlueSelection
        Me.btnColorBlue.Location = New System.Drawing.Point(377, 16)
        Me.btnColorBlue.Name = "btnColorBlue"
        Me.btnColorBlue.Size = New System.Drawing.Size(67, 66)
        Me.btnColorBlue.TabIndex = 14
        Me.btnColorBlue.TabStop = False
        '
        'btnYellowColor
        '
        Me.btnYellowColor.BackColor = System.Drawing.Color.Transparent
        Me.btnYellowColor.Image = Global.Keep_Notes_3._0.My.Resources.Resources.YellowSelection
        Me.btnYellowColor.Location = New System.Drawing.Point(304, 16)
        Me.btnYellowColor.Name = "btnYellowColor"
        Me.btnYellowColor.Size = New System.Drawing.Size(67, 66)
        Me.btnYellowColor.TabIndex = 13
        Me.btnYellowColor.TabStop = False
        '
        'btnDefaultColor
        '
        Me.btnDefaultColor.BackColor = System.Drawing.Color.Transparent
        Me.btnDefaultColor.Image = Global.Keep_Notes_3._0.My.Resources.Resources.DefaultSelection
        Me.btnDefaultColor.Location = New System.Drawing.Point(85, 15)
        Me.btnDefaultColor.Name = "btnDefaultColor"
        Me.btnDefaultColor.Size = New System.Drawing.Size(67, 66)
        Me.btnDefaultColor.TabIndex = 12
        Me.btnDefaultColor.TabStop = False
        '
        'btnRedColor
        '
        Me.btnRedColor.BackColor = System.Drawing.Color.Transparent
        Me.btnRedColor.Image = Global.Keep_Notes_3._0.My.Resources.Resources.PinkSelection
        Me.btnRedColor.Location = New System.Drawing.Point(158, 15)
        Me.btnRedColor.Name = "btnRedColor"
        Me.btnRedColor.Size = New System.Drawing.Size(67, 66)
        Me.btnRedColor.TabIndex = 11
        Me.btnRedColor.TabStop = False
        '
        'btnColorGreen
        '
        Me.btnColorGreen.BackColor = System.Drawing.Color.Transparent
        Me.btnColorGreen.Image = Global.Keep_Notes_3._0.My.Resources.Resources.GreenSelection
        Me.btnColorGreen.Location = New System.Drawing.Point(450, 16)
        Me.btnColorGreen.Name = "btnColorGreen"
        Me.btnColorGreen.Size = New System.Drawing.Size(67, 66)
        Me.btnColorGreen.TabIndex = 10
        Me.btnColorGreen.TabStop = False
        '
        'btnOpenWheel
        '
        Me.btnOpenWheel.BackColor = System.Drawing.Color.Transparent
        Me.btnOpenWheel.Image = Global.Keep_Notes_3._0.My.Resources.Resources.NewOpenColorLight
        Me.btnOpenWheel.Location = New System.Drawing.Point(311, 695)
        Me.btnOpenWheel.Name = "btnOpenWheel"
        Me.btnOpenWheel.Size = New System.Drawing.Size(69, 67)
        Me.btnOpenWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnOpenWheel.TabIndex = 11
        Me.btnOpenWheel.TabStop = False
        '
        'pnlSettings
        '
        Me.pnlSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSettings.BackColor = System.Drawing.Color.Transparent
        Me.pnlSettings.BackgroundImage = Global.Keep_Notes_3._0.My.Resources.Resources.SettingsDrawer4
        Me.pnlSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSettings.Controls.Add(Me.lblDarkMode)
        Me.pnlSettings.Controls.Add(Me.lblGhostMode)
        Me.pnlSettings.Controls.Add(Me.btnGhostModeOn)
        Me.pnlSettings.Controls.Add(Me.btnSettingsDown)
        Me.pnlSettings.Controls.Add(Me.btnOn)
        Me.pnlSettings.Controls.Add(Me.lblSettingsTitle)
        Me.pnlSettings.Controls.Add(Me.btnGhostModeOff)
        Me.pnlSettings.Controls.Add(Me.btnOff)
        Me.pnlSettings.Location = New System.Drawing.Point(0, 637)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(693, 137)
        Me.pnlSettings.TabIndex = 12
        '
        'lblDarkMode
        '
        Me.lblDarkMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDarkMode.BackColor = System.Drawing.Color.Transparent
        Me.lblDarkMode.Font = New System.Drawing.Font("Product Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDarkMode.Location = New System.Drawing.Point(436, 20)
        Me.lblDarkMode.Name = "lblDarkMode"
        Me.lblDarkMode.Size = New System.Drawing.Size(113, 26)
        Me.lblDarkMode.TabIndex = 3
        Me.lblDarkMode.Text = "Dark Mode"
        Me.lblDarkMode.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGhostMode
        '
        Me.lblGhostMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGhostMode.Font = New System.Drawing.Font("Product Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGhostMode.Location = New System.Drawing.Point(145, 20)
        Me.lblGhostMode.Name = "lblGhostMode"
        Me.lblGhostMode.Size = New System.Drawing.Size(133, 23)
        Me.lblGhostMode.TabIndex = 9
        Me.lblGhostMode.Text = "Ghost Mode"
        Me.lblGhostMode.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnGhostModeOn
        '
        Me.btnGhostModeOn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGhostModeOn.BackColor = System.Drawing.Color.Transparent
        Me.btnGhostModeOn.Image = CType(resources.GetObject("btnGhostModeOn.Image"), System.Drawing.Image)
        Me.btnGhostModeOn.Location = New System.Drawing.Point(170, 50)
        Me.btnGhostModeOn.Name = "btnGhostModeOn"
        Me.btnGhostModeOn.Size = New System.Drawing.Size(67, 65)
        Me.btnGhostModeOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnGhostModeOn.TabIndex = 11
        Me.btnGhostModeOn.TabStop = False
        '
        'btnSettingsDown
        '
        Me.btnSettingsDown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSettingsDown.BackColor = System.Drawing.Color.Transparent
        Me.btnSettingsDown.Image = CType(resources.GetObject("btnSettingsDown.Image"), System.Drawing.Image)
        Me.btnSettingsDown.Location = New System.Drawing.Point(317, 195)
        Me.btnSettingsDown.Name = "btnSettingsDown"
        Me.btnSettingsDown.Size = New System.Drawing.Size(58, 33)
        Me.btnSettingsDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnSettingsDown.TabIndex = 8
        Me.btnSettingsDown.TabStop = False
        '
        'btnOn
        '
        Me.btnOn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOn.BackColor = System.Drawing.Color.Transparent
        Me.btnOn.Image = CType(resources.GetObject("btnOn.Image"), System.Drawing.Image)
        Me.btnOn.Location = New System.Drawing.Point(461, 50)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(67, 65)
        Me.btnOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnOn.TabIndex = 4
        Me.btnOn.TabStop = False
        '
        'lblSettingsTitle
        '
        Me.lblSettingsTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSettingsTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSettingsTitle.Font = New System.Drawing.Font("Product Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsTitle.Location = New System.Drawing.Point(277, -79)
        Me.lblSettingsTitle.Name = "lblSettingsTitle"
        Me.lblSettingsTitle.Size = New System.Drawing.Size(138, 41)
        Me.lblSettingsTitle.TabIndex = 0
        Me.lblSettingsTitle.Text = "Settings"
        Me.lblSettingsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnGhostModeOff
        '
        Me.btnGhostModeOff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGhostModeOff.BackColor = System.Drawing.Color.Transparent
        Me.btnGhostModeOff.Image = CType(resources.GetObject("btnGhostModeOff.Image"), System.Drawing.Image)
        Me.btnGhostModeOff.Location = New System.Drawing.Point(170, 50)
        Me.btnGhostModeOff.Name = "btnGhostModeOff"
        Me.btnGhostModeOff.Size = New System.Drawing.Size(67, 65)
        Me.btnGhostModeOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnGhostModeOff.TabIndex = 10
        Me.btnGhostModeOff.TabStop = False
        '
        'btnOff
        '
        Me.btnOff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOff.BackColor = System.Drawing.Color.Transparent
        Me.btnOff.Image = CType(resources.GetObject("btnOff.Image"), System.Drawing.Image)
        Me.btnOff.Location = New System.Drawing.Point(461, 50)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(67, 65)
        Me.btnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnOff.TabIndex = 5
        Me.btnOff.TabStop = False
        '
        'btnOpenSettings
        '
        Me.btnOpenSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnOpenSettings.Image = CType(resources.GetObject("btnOpenSettings.Image"), System.Drawing.Image)
        Me.btnOpenSettings.Location = New System.Drawing.Point(49, 582)
        Me.btnOpenSettings.Name = "btnOpenSettings"
        Me.btnOpenSettings.Size = New System.Drawing.Size(43, 31)
        Me.btnOpenSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnOpenSettings.TabIndex = 13
        Me.btnOpenSettings.TabStop = False
        '
        'TimerColorBar
        '
        Me.TimerColorBar.Interval = 12
        '
        'btnCalculator
        '
        Me.btnCalculator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalculator.BackColor = System.Drawing.Color.Transparent
        Me.btnCalculator.Image = Global.Keep_Notes_3._0.My.Resources.Resources.CalculatorButton
        Me.btnCalculator.Location = New System.Drawing.Point(98, 582)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(43, 31)
        Me.btnCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCalculator.TabIndex = 14
        Me.btnCalculator.TabStop = False
        '
        'FormCreateNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Keep_Notes_3._0.My.Resources.Resources.NoteCreation2_0
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(692, 770)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.btnOpenSettings)
        Me.Controls.Add(Me.pnlColorwheel)
        Me.Controls.Add(Me.lblDateModified)
        Me.Controls.Add(Me.btnSubmitNotes)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmitANote)
        Me.Controls.Add(Me.lblPromptNote)
        Me.Controls.Add(Me.txtNoteTitle)
        Me.Controls.Add(Me.rtxNoteText)
        Me.Controls.Add(Me.btnOpenWheel)
        Me.Controls.Add(Me.btnCalculator)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(708, 809)
        Me.Name = "FormCreateNotes"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Keep Notes"
        Me.TopMost = True
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSubmitNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlColorwheel.ResumeLayout(False)
        CType(Me.btnPurple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnColorBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnYellowColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDefaultColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRedColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnColorGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOpenWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSettings.ResumeLayout(False)
        CType(Me.btnGhostModeOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettingsDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGhostModeOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOpenSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCalculator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtxNoteText As RichTextBox
    Friend WithEvents txtNoteTitle As TextBox
    Friend WithEvents lblPromptNote As Label
    Friend WithEvents btnSubmitANote As Label
    Friend WithEvents btnCancel As PictureBox
    Friend WithEvents btnSubmitNotes As PictureBox
    Friend WithEvents lblDateModified As Label
    Friend WithEvents btnCloseWheel As PictureBox
    Friend WithEvents pnlColorwheel As Panel
    Friend WithEvents btnColorGreen As PictureBox
    Friend WithEvents btnColorBlue As PictureBox
    Friend WithEvents btnYellowColor As PictureBox
    Friend WithEvents btnDefaultColor As PictureBox
    Friend WithEvents btnRedColor As PictureBox
    Friend WithEvents btnOpenWheel As PictureBox
    Friend WithEvents btnPurple As PictureBox
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents lblDarkMode As Label
    Friend WithEvents lblGhostMode As Label
    Friend WithEvents btnGhostModeOn As PictureBox
    Friend WithEvents btnSettingsDown As PictureBox
    Friend WithEvents btnOn As PictureBox
    Friend WithEvents lblSettingsTitle As Label
    Friend WithEvents btnGhostModeOff As PictureBox
    Friend WithEvents btnOff As PictureBox
    Friend WithEvents btnOpenSettings As PictureBox
    Friend WithEvents TimerColorBar As Timer
    Friend WithEvents btnCalculator As PictureBox
End Class
