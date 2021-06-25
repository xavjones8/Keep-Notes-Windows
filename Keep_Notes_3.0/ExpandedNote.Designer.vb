<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExpandedNote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExpandedNote))
        Me.lblExpandedNoteTitle = New System.Windows.Forms.Label()
        Me.lblExpandedNote = New System.Windows.Forms.Label()
        Me.btnToggleEditing = New System.Windows.Forms.PictureBox()
        Me.btnDeleteNote2 = New System.Windows.Forms.PictureBox()
        Me.lblDeleteNote = New System.Windows.Forms.Label()
        CType(Me.btnToggleEditing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteNote2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblExpandedNoteTitle
        '
        Me.lblExpandedNoteTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExpandedNoteTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblExpandedNoteTitle.Font = New System.Drawing.Font("Product Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpandedNoteTitle.Location = New System.Drawing.Point(8, -2)
        Me.lblExpandedNoteTitle.Name = "lblExpandedNoteTitle"
        Me.lblExpandedNoteTitle.Size = New System.Drawing.Size(677, 40)
        Me.lblExpandedNoteTitle.TabIndex = 0
        Me.lblExpandedNoteTitle.Text = "Test"
        Me.lblExpandedNoteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExpandedNote
        '
        Me.lblExpandedNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExpandedNote.BackColor = System.Drawing.Color.Transparent
        Me.lblExpandedNote.Font = New System.Drawing.Font("Product Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpandedNote.Location = New System.Drawing.Point(8, 70)
        Me.lblExpandedNote.Name = "lblExpandedNote"
        Me.lblExpandedNote.Size = New System.Drawing.Size(677, 280)
        Me.lblExpandedNote.TabIndex = 1
        Me.lblExpandedNote.Text = "Test"
        '
        'btnToggleEditing
        '
        Me.btnToggleEditing.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnToggleEditing.BackColor = System.Drawing.Color.Transparent
        Me.btnToggleEditing.Image = CType(resources.GetObject("btnToggleEditing.Image"), System.Drawing.Image)
        Me.btnToggleEditing.Location = New System.Drawing.Point(178, 703)
        Me.btnToggleEditing.Name = "btnToggleEditing"
        Me.btnToggleEditing.Size = New System.Drawing.Size(75, 55)
        Me.btnToggleEditing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnToggleEditing.TabIndex = 15
        Me.btnToggleEditing.TabStop = False
        '
        'btnDeleteNote2
        '
        Me.btnDeleteNote2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteNote2.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteNote2.Image = CType(resources.GetObject("btnDeleteNote2.Image"), System.Drawing.Image)
        Me.btnDeleteNote2.Location = New System.Drawing.Point(440, 703)
        Me.btnDeleteNote2.Name = "btnDeleteNote2"
        Me.btnDeleteNote2.Size = New System.Drawing.Size(75, 55)
        Me.btnDeleteNote2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDeleteNote2.TabIndex = 16
        Me.btnDeleteNote2.TabStop = False
        '
        'lblDeleteNote
        '
        Me.lblDeleteNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblDeleteNote.AutoSize = True
        Me.lblDeleteNote.BackColor = System.Drawing.Color.Transparent
        Me.lblDeleteNote.Font = New System.Drawing.Font("Product Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeleteNote.Location = New System.Drawing.Point(311, 721)
        Me.lblDeleteNote.Name = "lblDeleteNote"
        Me.lblDeleteNote.Size = New System.Drawing.Size(71, 26)
        Me.lblDeleteNote.TabIndex = 17
        Me.lblDeleteNote.Text = "Delete"
        Me.lblDeleteNote.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ExpandedNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Keep_Notes_3._0.My.Resources.Resources.Back2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(692, 770)
        Me.Controls.Add(Me.lblDeleteNote)
        Me.Controls.Add(Me.btnDeleteNote2)
        Me.Controls.Add(Me.btnToggleEditing)
        Me.Controls.Add(Me.lblExpandedNote)
        Me.Controls.Add(Me.lblExpandedNoteTitle)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(708, 809)
        Me.Name = "ExpandedNote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ExpandedNote"
        Me.TopMost = True
        CType(Me.btnToggleEditing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteNote2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblExpandedNoteTitle As Label
    Friend WithEvents lblExpandedNote As Label
    Friend WithEvents btnToggleEditing As PictureBox
    Friend WithEvents btnDeleteNote2 As PictureBox
    Friend WithEvents lblDeleteNote As Label
End Class
