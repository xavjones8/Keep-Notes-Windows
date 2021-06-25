Public Class FormCreateNotes
    'Handles note creation, editing
    Protected TheNote As Note = New Note

    'Makes the note
    Private Sub btnSubmitNotes_Click(sender As Object, e As EventArgs) Handles btnSubmitNotes.Click
        CreateTheNote()
        Form1.CheckDarkMode()
    End Sub

    'Handles Cancel button, sends the user back to form 1
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ResetNote()
    End Sub

    'Opens form1 if the form is force-closed
    Private Sub FormCreateNotes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ResetNote()
        Form1.Show()
        Form1.Opacity = 100
    End Sub

    'Subs for color changes
    Private Sub btnOpenWheel_Click(sender As Object, e As EventArgs) Handles btnOpenWheel.Click
        pnlColorwheel.Width = 529
        pnlColorwheel.Location = New Point(81, 680)
        pnlColorwheel.Show()
        btnCloseWheel.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        btnOpenWheel.Hide()
    End Sub
    Private Sub btnCloseWheel_Click(sender As Object, e As EventArgs) Handles btnCloseWheel.Click
        TimerColorBar.Enabled = True
        btnOpenWheel.Show()
    End Sub
    Private Sub btnDefaultColor_Click(sender As Object, e As EventArgs) Handles btnDefaultColor.Click
        btnOpenWheel.Image = My.Resources.DefaultSelection
        TheNote.Color = "White"
        TimerColorBar.Enabled = True
        btnOpenWheel.Show()
    End Sub
    Private Sub btnRedColor_Click(sender As Object, e As EventArgs) Handles btnRedColor.Click
        btnOpenWheel.Image = My.Resources.PinkSelection
        TheNote.Color = "Red"
        TimerColorBar.Enabled = True
        btnOpenWheel.Show()
    End Sub
    Private Sub btnYellowColor_Click(sender As Object, e As EventArgs) Handles btnYellowColor.Click
        btnOpenWheel.Image = My.Resources.YellowSelection
        TheNote.Color = "Yellow"
        TimerColorBar.Enabled = True
        btnOpenWheel.Show()
    End Sub
    Private Sub btnColorBlue_Click(sender As Object, e As EventArgs) Handles btnColorBlue.Click
        btnOpenWheel.Image = My.Resources.BlueSelection
        TheNote.Color = "Blue"
        TimerColorBar.Enabled = True
        btnOpenWheel.Show()
    End Sub
    Private Sub btnColorGreen_Click(sender As Object, e As EventArgs) Handles btnColorGreen.Click
        btnOpenWheel.Image = My.Resources.GreenSelection
        TheNote.Color = "Green"
        TimerColorBar.Enabled = True
        btnOpenWheel.Show()
    End Sub
    Private Sub btnPurple_Click(sender As Object, e As EventArgs) Handles btnPurple.Click
        btnOpenWheel.Image = My.Resources.PurpleSelection
        TheNote.Color = "Purple"
        TimerColorBar.Enabled = True
        btnOpenWheel.Show()
    End Sub

    'Handles all of the Settings stuff
    Private Sub btnOpenSettings_Click(sender As Object, e As EventArgs) Handles btnOpenSettings.Click
        pnlSettings.Show()
    End Sub
    Private Sub btnSettingsDown_Click(sender As Object, e As EventArgs) Handles btnSettingsDown.Click
        pnlSettings.Hide()
    End Sub
    Private Sub FormCreateNotes_Click(sender As Object, e As EventArgs) Handles Me.Click
        pnlSettings.Hide()
    End Sub
    Private Sub rtxNoteText_Click(sender As Object, e As EventArgs) Handles rtxNoteText.Click
        pnlSettings.Hide()
    End Sub
    Private Sub pnlSettings_Click(sender As Object, e As EventArgs) Handles pnlSettings.Click
        pnlSettings.Hide()
    End Sub
    Private Sub txtNoteTitle_Click(sender As Object, e As EventArgs) Handles txtNoteTitle.Click
        pnlSettings.Hide()
    End Sub
    Private Sub btnGhostModeOn_Click(sender As Object, e As EventArgs) Handles btnGhostModeOn.Click
        Form1.GhostModeOn()
    End Sub
    Private Sub btnGhostModeOff_Click(sender As Object, e As EventArgs) Handles btnGhostModeOff.Click
        Form1.GhostModeOff()
    End Sub
    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        Form1.DarkModeOn()
        btnOn.Hide()
        btnOff.Show()
    End Sub
    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        Form1.DarkModeOff()
        btnOff.Hide()
        btnOn.Show()
    End Sub

    ''Handles the timer animation for the color wheel
    Private Sub TimerColorBar_Tick(sender As Object, e As EventArgs) Handles TimerColorBar.Tick
        If btnOpenWheel.Visible Then
            btnCloseWheel.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            pnlColorwheel.Width -= 50
            Dim xa As Integer = pnlColorwheel.Location.X
            xa += 24
            pnlColorwheel.Location = New Point(xa, 680)
            If pnlColorwheel.Width < 0 Then
                pnlColorwheel.Hide()
            End If
        End If
    End Sub

    'Maintains Form Continuity
    Private Sub FormCreateNotes_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Form1.CheckDarkMode()
        Form1.CheckGhostMode()
        Form1.Hide()
        ResetNote()
        Form1.CloseSettings()
        pnlSettings.Hide()
        pnlColorwheel.Hide()
        TheNote.Color = "White"
    End Sub
    Public Sub fixLocationIssues()
        Me.Location = Me.Location
        Form1.Location = Me.Location
        ExpandedNote.Location = Me.Location
        Calculator.Location = Me.Location
    End Sub
    Private Sub FormCreateNotes_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        fixLocationIssues()
    End Sub

    'Subroutines for handling note creation
    Public Sub NoteCreation()
        Select Case lblPromptNote.Text
            Case "Creating a Note"
                If Form1.lblNote1.Text = "" Then
                    CreateOneNote(Form1.lblNote1, Form1.lblNote1Title, Form1.PnlNote1)
                ElseIf Form1.lblNote2.Text = "" Then
                    CreateOneNote(Form1.lblNote2, Form1.lblNote2Title, Form1.PnlNote2)
                ElseIf Form1.lblNote3.Text = "" Then
                    CreateOneNote(Form1.lblNote3, Form1.lblNote3Title, Form1.PnlNote3)
                ElseIf Form1.lblNote4.Text = "" Then
                    CreateOneNote(Form1.lblNote4, Form1.lblNote4Title, Form1.PnlNote4)
                ElseIf Form1.lblNote5.Text = "" Then
                    CreateOneNote(Form1.lblNote5, Form1.lblNote5Title, Form1.PnlNote5)
                ElseIf Form1.lblNote6.Text = "" Then
                    CreateOneNote(Form1.lblNote6, Form1.lblNote6Title, Form1.PnlNote6)
                ElseIf Form1.lblNote7.Text = "" Then
                    CreateOneNote(Form1.lblNote7, Form1.lblNote7Title, Form1.PnlNote7)
                ElseIf Form1.lblNote8.Text = "" Then
                    CreateOneNote(Form1.lblNote8, Form1.lblNote8Title, Form1.PnlNote8)
                ElseIf Form1.lblNote9.Text = "" Then
                    CreateOneNote(Form1.lblNote9, Form1.lblNote9Title, Form1.PnlNote9)
                End If
            Case ("Editing " + Form1.lblNote1Title.Text)
                CreateOneNote(Form1.lblNote1, Form1.lblNote1Title, Form1.PnlNote1)
                RememberColor(My.Settings.Note1Color, Form1.PnlNote1, Form1.lblNote1Title, Form1.lblNote1)
            Case ("Editing " + Form1.lblNote2Title.Text)
                CreateOneNote(Form1.lblNote2, Form1.lblNote2Title, Form1.PnlNote2)
                RememberColor(My.Settings.Note2Color, Form1.PnlNote2, Form1.lblNote2Title, Form1.lblNote2)
            Case ("Editing " + Form1.lblNote3Title.Text)
                CreateOneNote(Form1.lblNote3, Form1.lblNote3Title, Form1.PnlNote3)
                RememberColor(My.Settings.Note3Color, Form1.PnlNote3, Form1.lblNote3Title, Form1.lblNote3)
            Case ("Editing " + Form1.lblNote4Title.Text)
                CreateOneNote(Form1.lblNote4, Form1.lblNote4Title, Form1.PnlNote4)
                RememberColor(My.Settings.Note4Color, Form1.PnlNote4, Form1.lblNote4Title, Form1.lblNote4)
            Case ("Editing " + Form1.lblNote5Title.Text)
                CreateOneNote(Form1.lblNote5, Form1.lblNote5Title, Form1.PnlNote5)
                RememberColor(My.Settings.Note5Color, Form1.PnlNote5, Form1.lblNote5Title, Form1.lblNote5)
            Case ("Editing " + Form1.lblNote6Title.Text)
                CreateOneNote(Form1.lblNote6, Form1.lblNote6Title, Form1.PnlNote6)
                RememberColor(My.Settings.Note6Color, Form1.PnlNote6, Form1.lblNote6Title, Form1.lblNote6)
            Case ("Editing " + Form1.lblNote7Title.Text)
                CreateOneNote(Form1.lblNote7, Form1.lblNote7Title, Form1.PnlNote7)
                RememberColor(My.Settings.Note7Color, Form1.PnlNote7, Form1.lblNote7Title, Form1.lblNote7)
            Case ("Editing " + Form1.lblNote8Title.Text)
                CreateOneNote(Form1.lblNote8, Form1.lblNote8Title, Form1.PnlNote8)
                RememberColor(My.Settings.Note8Color, Form1.PnlNote8, Form1.lblNote8Title, Form1.lblNote8)
            Case ("Editing " + Form1.lblNote9Title.Text)
                CreateOneNote(Form1.lblNote9, Form1.lblNote9Title, Form1.PnlNote9)
                RememberColor(My.Settings.Note9Color, Form1.PnlNote9, Form1.lblNote9Title, Form1.lblNote9)
        End Select
    End Sub
    Public Sub RememberColor(ByVal colors As String, ByVal panel As Panel, ByVal title As Label, ByVal label As Label)
        If colors = "White" Then
            panel.BackgroundImage = My.Resources.White
            label.ForeColor = Color.Black
            title.ForeColor = Color.Black
        End If
        If colors = "Red" Then
            panel.BackgroundImage = My.Resources.Pink
            label.ForeColor = Color.White
            title.ForeColor = Color.White
        End If
        If colors = "Yellow" Then
            panel.BackgroundImage = My.Resources.Yellow
            label.ForeColor = Color.Black
            title.ForeColor = Color.Black
        End If
        If colors = "Blue" Then
            panel.BackgroundImage = My.Resources.Blue
            label.ForeColor = Color.White
            title.ForeColor = Color.White
        End If
        If colors = "Green" Then
            panel.BackgroundImage = My.Resources.Green
            label.ForeColor = Color.White
            title.ForeColor = Color.White
            checkPanelColor(panel, colors)
        End If
        If colors = "Purple" Then
            panel.BackgroundImage = My.Resources.Purple
            label.ForeColor = Color.White
            title.ForeColor = Color.White
            checkPanelColor(panel, colors)
        End If
    End Sub
    Public Sub CreateOneNote(ByVal label As Label, ByVal title As Label, ByVal panel As Panel)
        If rtxNoteText.Text <> "" Then

            Dim strNoteTitle As String = ""
            strNoteTitle = txtNoteTitle.Text

            If strNoteTitle = "" Then
                If label.Equals(Form1.lblNote1) Then
                    strNoteTitle = "Note 1"

                    My.Settings.Note1Color = TheNote.Color
                ElseIf label.Equals(Form1.lblNote2) Then
                    strNoteTitle = "Note 2"

                    My.Settings.Note2Color = TheNote.Color
                ElseIf label.Equals(Form1.lblNote3) Then
                    strNoteTitle = "Note 3"
                    My.Settings.Note3Color = TheNote.Color

                ElseIf label.Equals(Form1.lblNote4) Then
                    strNoteTitle = "Note 4"

                    My.Settings.Note4Color = TheNote.Color
                ElseIf label.Equals(Form1.lblNote5) Then
                    strNoteTitle = "Note 5"

                    My.Settings.Note5Color = TheNote.Color
                ElseIf label.Equals(Form1.lblNote6) Then
                    strNoteTitle = "Note 6"

                    My.Settings.Note6Color = TheNote.Color
                ElseIf label.Equals(Form1.lblNote7) Then
                    strNoteTitle = "Note 7"

                    My.Settings.Note7Color = TheNote.Color
                ElseIf label.Equals(Form1.lblNote8) Then
                    strNoteTitle = "Note 8"

                    My.Settings.Note8Color = TheNote.Color
                ElseIf label.Equals(Form1.lblNote9) Then
                    strNoteTitle = "Note 9"

                    My.Settings.Note9Color = TheNote.Color
                End If
            End If
            title.Text = strNoteTitle
            panel.Show()
            Dim strNote2 As String = rtxNoteText.Text
            label.Text = strNote2
            ChangeNote(panel, label, title)

        End If
    End Sub
    Public Sub SaveInfo()
        My.Settings.Note1 = Form1.lblNote1.Text
        My.Settings.Note2 = Form1.lblNote2.Text
        My.Settings.Note3 = Form1.lblNote3.Text
        My.Settings.Note4 = Form1.lblNote4.Text
        My.Settings.Note5 = Form1.lblNote5.Text
        My.Settings.Note6 = Form1.lblNote6.Text
        My.Settings.Note7 = Form1.lblNote7.Text
        My.Settings.Note8 = Form1.lblNote8.Text
        My.Settings.Note9 = Form1.lblNote9.Text
        My.Settings.Note1_Title = Form1.lblNote1Title.Text
        My.Settings.Note2_Title = Form1.lblNote2Title.Text
        My.Settings.Note3_Title = Form1.lblNote3Title.Text
        My.Settings.Note4_Title = Form1.lblNote4Title.Text
        My.Settings.Note5_Title = Form1.lblNote5Title.Text
        My.Settings.Note6_Title = Form1.lblNote6Title.Text
        My.Settings.Note7_Title = Form1.lblNote7Title.Text
        My.Settings.Note8_Title = Form1.lblNote8Title.Text
        My.Settings.Note9_Title = Form1.lblNote9Title.Text

    End Sub
    Public Sub CheckFull()
        If My.Settings.Note1 <> "" And My.Settings.Note2 <> "" And My.Settings.Note3 <> "" And My.Settings.Note4 <> "" And My.Settings.Note5 <> "" And My.Settings.Note6 <> "" And My.Settings.Note7 <> "" And My.Settings.Note8 <> "" And My.Settings.Note9 <> "" Then
            Form1.btnCreateNotes.Hide()
        Else
            Form1.btnCreateNotes.Show()
        End If
    End Sub
    Public Sub CloseCreationMenu()
        rtxNoteText.Text = ""
        txtNoteTitle.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub
    Public Sub MakeEditingAvailable()
        Form1.btnOpenSettings.Location = New Point(427, 697)
        Form1.btnCreateNotes.Location = New Point(307, 697)
        Form1.btnToggleEditing.Show()
        Form1.pnlNoNotes.Hide()
    End Sub
    Public Sub CreateTheNote()
        If rtxNoteText.Text <> "" Then
            NoteCreation()
            SaveInfo()
            CheckFull()
            MakeEditingAvailable()
            CloseCreationMenu()
            Form1.MaximizeBox = True
        Else
            MessageBox.Show("Write something to continue.")
        End If
    End Sub
    Public Sub ResetNote()
        rtxNoteText.Text = ""
        txtNoteTitle.Text = ""
        lblPromptNote.Text = "Creating a Note"
        Me.Hide()
        Form1.Show()
    End Sub

    'Subroutines for Colors
    Public Sub ChangeNote(ByVal panel As Panel, ByVal label As Label, ByVal title As Label)
        If TheNote.Color = "White" Then
            panel.BackgroundImage = My.Resources.White
            label.ForeColor = Color.Black
            title.ForeColor = Color.Black
            checkPanelColor(panel, TheNote.Color)
        End If
        If TheNote.Color = "Red" Then
            panel.BackgroundImage = My.Resources.Pink
            label.ForeColor = Color.White
            title.ForeColor = Color.White
            checkPanelColor(panel, TheNote.Color)
        End If
        If TheNote.Color = "Yellow" Then
            panel.BackgroundImage = My.Resources.Yellow
            label.ForeColor = Color.Black
            title.ForeColor = Color.Black
            checkPanelColor(panel, TheNote.Color)
        End If
        If TheNote.Color = "Blue" Then
            panel.BackgroundImage = My.Resources.Blue
            label.ForeColor = Color.White
            title.ForeColor = Color.White
            checkPanelColor(panel, TheNote.Color)
        End If
        If TheNote.Color = "Green" Then
            panel.BackgroundImage = My.Resources.Green
            label.ForeColor = Color.White
            title.ForeColor = Color.White
            checkPanelColor(panel, TheNote.Color)
        End If
        If TheNote.Color = "Purple" Then
            panel.BackgroundImage = My.Resources.Purple
            label.ForeColor = Color.White
            title.ForeColor = Color.White
            checkPanelColor(panel, TheNote.Color)
        End If
    End Sub

    Public Sub checkPanelColor(panel, colors)
        If panel.Equals(Form1.PnlNote1) Then
            My.Settings.Note1Color = colors
        ElseIf panel.Equals(Form1.PnlNote2) Then
            My.Settings.Note2Color = colors
        ElseIf panel.Equals(Form1.PnlNote3) Then
            My.Settings.Note3Color = colors
        ElseIf panel.Equals(Form1.PnlNote4) Then
            My.Settings.Note4Color = colors
        ElseIf panel.Equals(Form1.PnlNote5) Then
            My.Settings.Note5Color = colors
        ElseIf panel.Equals(Form1.PnlNote6) Then
            My.Settings.Note6Color = colors
        ElseIf panel.Equals(Form1.PnlNote7) Then
            My.Settings.Note7Color = colors
        ElseIf panel.Equals(Form1.PnlNote8) Then
            My.Settings.Note8Color = colors
        ElseIf panel.Equals(Form1.PnlNote9) Then
            My.Settings.Note9Color = colors
        End If
    End Sub

    Private Sub BtnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        Calculator.Show()
        Me.Hide()
    End Sub
End Class

''Perhaps a future method for creating notes using objects.
Public Class Note
    Public Property Color As String
    Public Property Note As String
    Public Property Title As String

End Class