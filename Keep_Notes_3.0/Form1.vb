Public Class Form1
    Dim blnGhostMode As Boolean = False
    'Shows Note Creation Menu
    Private Sub btnCreateNotes_Click_1(sender As Object, e As EventArgs) Handles btnCreateNotes.Click
        Me.Hide()
        FormCreateNotes.Show()
    End Sub

    'Handles Opening and Closing Settings Panel
    Private Sub btnOpenSettings_Click(sender As Object, e As EventArgs) Handles btnOpenSettings.Click
        OpenSettings()
    End Sub
    Private Sub btnSettingsDown_Click(sender As Object, e As EventArgs) Handles btnSettingsDown.Click
        CloseSettings()
    End Sub

    'Implements Dark Mode
    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        DarkModeOn()
    End Sub
    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        DarkModeOff()
    End Sub

    'Hides/Shows Editing Buttons
    'Paramter is the string "Show" or "Hide"
    Private Sub btnToggleEditing_Click(sender As Object, e As EventArgs) Handles btnToggleEditing.Click
        If btnDeleteNote1.Visible = False Then
            HideEditingButtons("Show")
        End If
    End Sub

    'Handles Note Deletion
    '1st parameter is the label for the text of the note, the second is for the label for the title, 3rd is the panel of the note.

    Private Sub btnDeleteNote1_Click(sender As Object, e As EventArgs) Handles btnDeleteNote1.Click
        DeleteANote(lblNote1, lblNote1Title, PnlNote1)
    End Sub
    Private Sub btnDeleteNote2_Click(sender As Object, e As EventArgs) Handles btnDeleteNote2.Click
        DeleteANote(lblNote2, lblNote2Title, PnlNote2)
    End Sub
    Private Sub btnDeleteNote3_Click(sender As Object, e As EventArgs) Handles btnDeleteNote3.Click
        DeleteANote(lblNote3, lblNote3Title, PnlNote3)
    End Sub
    Private Sub btnDeleteNote4_Click(sender As Object, e As EventArgs) Handles btnDeleteNote4.Click
        DeleteANote(lblNote4, lblNote4Title, PnlNote4)
    End Sub
    Private Sub btnDeleteNote5_Click(sender As Object, e As EventArgs) Handles btnDeleteNote5.Click
        DeleteANote(lblNote5, lblNote5Title, PnlNote5)
    End Sub
    Private Sub btnDeleteNote6_Click(sender As Object, e As EventArgs) Handles btnDeleteNote6.Click
        DeleteANote(lblNote6, lblNote6Title, PnlNote6)
    End Sub
    Private Sub btnDeleteNote7_Click(sender As Object, e As EventArgs) Handles btnDeleteNote7.Click
        DeleteANote(lblNote7, lblNote7Title, PnlNote7)
    End Sub
    Private Sub btnDeleteNote8_Click(sender As Object, e As EventArgs) Handles btnDeleteNote8.Click
        DeleteANote(lblNote8, lblNote8Title, PnlNote8)
    End Sub
    Private Sub btnDeleteNote9_Click(sender As Object, e As EventArgs) Handles btnDeleteNote9.Click
        DeleteANote(lblNote9, lblNote9Title, PnlNote9)
    End Sub

    'Implements Edit Note Function
    '1st parameter is the label for the text of the note, the second is for the label for the title.
    Private Sub lblNote1_DoubleClick(sender As Object, e As EventArgs) Handles lblNote1.DoubleClick
        EditNotes(lblNote1, lblNote1Title)
    End Sub
    Private Sub lblNote2_DoubleClick(sender As Object, e As EventArgs) Handles lblNote2.DoubleClick
        EditNotes(lblNote2, lblNote2Title)
    End Sub
    Private Sub lblNote3_DoubleClick(sender As Object, e As EventArgs) Handles lblNote3.DoubleClick
        EditNotes(lblNote3, lblNote3Title)
    End Sub
    Private Sub lblNote4_DoubleClick(sender As Object, e As EventArgs) Handles lblNote4.DoubleClick
        EditNotes(lblNote4, lblNote4Title)
    End Sub
    Private Sub lblNote5_DoubleClick(sender As Object, e As EventArgs) Handles lblNote5.DoubleClick
        EditNotes(lblNote5, lblNote5Title)
    End Sub
    Private Sub lblNote6_DoubleClick(sender As Object, e As EventArgs) Handles lblNote6.DoubleClick
        EditNotes(lblNote6, lblNote6Title)
    End Sub
    Private Sub lblNote7_DoubleClick(sender As Object, e As EventArgs) Handles lblNote7.DoubleClick
        EditNotes(lblNote7, lblNote7Title)
    End Sub
    Private Sub lblNote8_DoubleClick(sender As Object, e As EventArgs) Handles lblNote8.DoubleClick
        EditNotes(lblNote8, lblNote8Title)
    End Sub
    Private Sub lblNote9_DoubleClick(sender As Object, e As EventArgs) Handles lblNote9.DoubleClick
        EditNotes(lblNote9, lblNote9Title)
    End Sub

    'Implements Clear All Sub
    Private Sub lblClearAll_Click(sender As Object, e As EventArgs) Handles lblClearAll.Click
        ClearAll()
    End Sub

    'Handles Startup Stuff
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Calculator.Hide()
        'Hides Empty Notes and Settings
        CheckDarkMode()
        CheckForNotes()
        pnlSettings.Hide()
        RememberInfo()
        FixExpandedNoteLocationIssues()
    End Sub

    'Quick Note creation/Other features
    Private Sub flpMainInteractions_DoubleClick(sender As Object, e As EventArgs) Handles flpMainInteractions.DoubleClick
        FormCreateNotes.Show()
        Me.Hide()
    End Sub
    Private Sub pnlNoNotes_DoubleClick(sender As Object, e As EventArgs) Handles pnlNoNotes.DoubleClick
        FormCreateNotes.Show()
        Me.Hide()
    End Sub
    Private Sub pnlNoNotes_Click(sender As Object, e As EventArgs) Handles pnlNoNotes.Click
        CloseSettings()
    End Sub
    Private Sub flpMainInteractions_Click(sender As Object, e As EventArgs) Handles flpMainInteractions.Click
        CloseSettings()
        HideEditingButtons("Hide")
    End Sub
    Private Sub pnlSettings_Click(sender As Object, e As EventArgs) Handles pnlSettings.Click
        CloseSettings()
    End Sub
    Private Sub btnGhostModeOn_Click(sender As Object, e As EventArgs) Handles btnGhostModeOn.Click
        GhostModeOn()
    End Sub
    Private Sub btnGhostModeOff_Click(sender As Object, e As EventArgs) Handles btnGhostModeOff.Click
        GhostModeOff()
    End Sub
    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        CheckForNotes()
    End Sub
    'Expand Note Function
    '1st parameter is the label for the text of the note, the second is for the label for the title.
    Private Sub lblNote1Title_DoubleClick(sender As Object, e As EventArgs) Handles lblNote1Title.DoubleClick
        ExpandNotes(lblNote1, lblNote1Title)
    End Sub
    Private Sub lblNote2Title_DoubleClick(sender As Object, e As EventArgs) Handles lblNote2Title.DoubleClick
        ExpandNotes(lblNote2, lblNote2Title)

    End Sub
    Private Sub lblNote3Title_DoubleClick(sender As Object, e As EventArgs) Handles lblNote3Title.DoubleClick
        ExpandNotes(lblNote3, lblNote3Title)
    End Sub
    Private Sub lblNote4Title_DoubleClick(sender As Object, e As EventArgs) Handles lblNote4Title.DoubleClick
        ExpandNotes(lblNote4, lblNote4Title)
    End Sub
    Private Sub lblNote5Title_DoubleClick(sender As Object, e As EventArgs) Handles lblNote5Title.DoubleClick
        ExpandNotes(lblNote5, lblNote5Title)
    End Sub
    Private Sub lblNote6Title_DoubleClick(sender As Object, e As EventArgs) Handles lblNote6Title.DoubleClick
        ExpandNotes(lblNote6, lblNote6Title)
    End Sub
    Private Sub lblNote7Title_DoubleClick(sender As Object, e As EventArgs) Handles lblNote7Title.DoubleClick
        ExpandNotes(lblNote7, lblNote7Title)
    End Sub
    Private Sub lblNote8Title_DoubleClick(sender As Object, e As EventArgs) Handles lblNote8Title.DoubleClick
        ExpandNotes(lblNote8, lblNote8Title)
    End Sub
    Private Sub lblNote9Title_DoubleClick(sender As Object, e As EventArgs) Handles lblNote9Title.DoubleClick
        ExpandNotes(lblNote9, lblNote9Title)
    End Sub

    'Reinforces Darkmode when loading forms
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CheckDarkMode()
        CheckGhostMode()
        Calculator.Hide()
    End Sub

    'Maintains location continuity
    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ExpandedNote.Location = Me.Location
        FormCreateNotes.Location = Me.Location
        Calculator.Location = Me.Location

    End Sub

    'Functions 
    'Subroutines

    'Show/Hide Editing Buttons
    Public Sub HideEditingButtons(ByVal WhichOne As String)
        If WhichOne = "Show" Then
            btnDeleteNote1.Show()
            btnDeleteNote2.Show()
            btnDeleteNote3.Show()
            btnDeleteNote4.Show()
            btnDeleteNote5.Show()
            btnDeleteNote6.Show()
            btnDeleteNote7.Show()
            btnDeleteNote8.Show()
            btnDeleteNote9.Show()
        ElseIf WhichOne = "Hide" Then
            btnDeleteNote1.Hide()
            btnDeleteNote2.Hide()
            btnDeleteNote3.Hide()
            btnDeleteNote4.Hide()
            btnDeleteNote5.Hide()
            btnDeleteNote6.Hide()
            btnDeleteNote7.Hide()
            btnDeleteNote8.Hide()
            btnDeleteNote9.Hide()
        End If
    End Sub

    'Subroutine for Dark Modes

    Public Sub DarkModeOn()
        My.Settings.DarkMode = True
        btnOn.Hide()
        btnOff.Show()
        Me.BackgroundImage = My.Resources.DarkBack
        btnCreateNotes.Image = My.Resources.Dark_CreateButton1
        btnToggleEditing.Image = My.Resources.Dark_Edit_1
        btnOpenSettings.Image = My.Resources.Dark_Settings_1
        pnlSettings.BackgroundImage = My.Resources.DarkSettingsDrawer4
        btnGhostModeOn.Image = My.Resources.Dark_Button_OnCorrect1
        btnGhostModeOff.Image = My.Resources.Dark_Button_OffCorrect1
        btnOn.Image = My.Resources.Dark_Button_OnCorrect1
        btnOff.Image = My.Resources.Dark_Button_OffCorrect1
        ChangePanelColorsDark(PnlNote1, lblNote1, lblNote1Title)
        ChangePanelColorsDark(PnlNote2, lblNote2, lblNote2Title)
        ChangePanelColorsDark(PnlNote3, lblNote3, lblNote3Title)
        ChangePanelColorsDark(PnlNote4, lblNote4, lblNote4Title)
        ChangePanelColorsDark(PnlNote5, lblNote5, lblNote5Title)
        ChangePanelColorsDark(PnlNote6, lblNote6, lblNote6Title)
        ChangePanelColorsDark(PnlNote7, lblNote7, lblNote7Title)
        ChangePanelColorsDark(PnlNote8, lblNote8, lblNote8Title)
        ChangePanelColorsDark(PnlNote9, lblNote9, lblNote9Title)
        btnDeleteNote1.Image = My.Resources.Dark_CancelDelete_1
        btnDeleteNote2.Image = My.Resources.Dark_CancelDelete_1
        btnDeleteNote3.Image = My.Resources.Dark_CancelDelete_1
        btnDeleteNote4.Image = My.Resources.Dark_CancelDelete_1
        btnDeleteNote5.Image = My.Resources.Dark_CancelDelete_1
        btnDeleteNote6.Image = My.Resources.Dark_CancelDelete_1
        btnDeleteNote7.Image = My.Resources.Dark_CancelDelete_1
        btnDeleteNote8.Image = My.Resources.Dark_CancelDelete_1
        btnDeleteNote9.Image = My.Resources.Dark_CancelDelete_1
        lblAppTitle.ForeColor = Color.White
        lblNoNotes.ForeColor = Color.White
        lblSettingsTitle.ForeColor = Color.White
        lblClearAll.ForeColor = Color.White
        lblDarkMode.ForeColor = Color.White
        lblGhostMode.ForeColor = Color.White
        'ExpandedNote
        ExpandedNote.BackgroundImage = My.Resources.DarkBack
        ExpandedNote.lblDeleteNote.ForeColor = Color.White
        ExpandedNote.lblExpandedNote.ForeColor = Color.White
        ExpandedNote.lblExpandedNoteTitle.ForeColor = Color.White
        ExpandedNote.btnDeleteNote2.Image = My.Resources.Dark_CancelDelete_1
        ExpandedNote.btnToggleEditing.Image = My.Resources.Dark_Edit_1

        'FormCreateNotes 
        FormCreateNotes.btnGhostModeOn.Image = My.Resources.Dark_Button_OnCorrect1
        FormCreateNotes.btnGhostModeOff.Image = My.Resources.Dark_Button_OffCorrect1
        FormCreateNotes.btnOn.Image = My.Resources.Dark_Button_OnCorrect1
        FormCreateNotes.btnOff.Image = My.Resources.Dark_Button_OffCorrect1
        FormCreateNotes.btnOpenWheel.Image = My.Resources.NewOpenColorDark2
        FormCreateNotes.btnCloseWheel.Image = My.Resources.NewOpenColorDark2
        FormCreateNotes.pnlColorwheel.BackgroundImage = My.Resources.DarkSelectionBar3
        FormCreateNotes.BackColor = Color.FromArgb(55, 55, 55)
        FormCreateNotes.btnOpenSettings.Image = My.Resources.Dark_Settings_1
        FormCreateNotes.pnlSettings.BackgroundImage = My.Resources.DarkSettingsDrawer4
        FormCreateNotes.btnOn.Hide()
        FormCreateNotes.btnOff.Show()
        FormCreateNotes.BackgroundImage = My.Resources.NoteCreation2_0Dark
        FormCreateNotes.lblSettingsTitle.ForeColor = Color.White
        FormCreateNotes.lblDarkMode.ForeColor = Color.White
        FormCreateNotes.lblGhostMode.ForeColor = Color.White
        FormCreateNotes.BackgroundImage = My.Resources.NoteCreation2_0Dark
        FormCreateNotes.txtNoteTitle.BackColor = Color.FromArgb(68, 68, 68)
        FormCreateNotes.rtxNoteText.BackColor = Color.FromArgb(68, 68, 68)
        FormCreateNotes.txtNoteTitle.ForeColor = Color.White
        FormCreateNotes.rtxNoteText.ForeColor = Color.White
        FormCreateNotes.lblPromptNote.ForeColor = Color.White
        FormCreateNotes.btnCancel.Image = My.Resources.Dark_CancelDelete_1
        FormCreateNotes.btnSubmitNotes.Image = My.Resources.Dark_Submit
        FormCreateNotes.btnCalculator.Image = My.Resources.ButtonCalculatorDark
        'Calculator
        Calculator.lblOne.ForeColor = Color.White
        Calculator.lblTwo.ForeColor = Color.White
        Calculator.lblThree.ForeColor = Color.White
        Calculator.lblFour.ForeColor = Color.White
        Calculator.lblFive.ForeColor = Color.White
        Calculator.lblSix.ForeColor = Color.White
        Calculator.lblSeven.ForeColor = Color.White
        Calculator.lblEight.ForeColor = Color.White
        Calculator.lblNine.ForeColor = Color.White
        Calculator.lblZero.ForeColor = Color.White
        Calculator.lblDisplayOutput.ForeColor = Color.White
        Calculator.lblDisplayOutput.BackColor = Color.FromArgb(80, 80, 80)
        Calculator.lblEquation.ForeColor = Color.White
        Calculator.lblEquation.BackColor = Color.FromArgb(80, 80, 80)
        Calculator.lblDecimal.ForeColor = Color.White
        Calculator.lblEquals.ForeColor = Color.White
        Calculator.lblDivide.ForeColor = Color.White
        Calculator.lblTimes.ForeColor = Color.White
        Calculator.lblPlus.ForeColor = Color.White
        Calculator.lblMinus.ForeColor = Color.White
        Calculator.lblExponent.ForeColor = Color.White
        Calculator.lblSquareRoot.ForeColor = Color.White
        Calculator.BackgroundImage = My.Resources.CalculatorBackDark
        Calculator.pnlOne.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlTwo.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlThree.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlFour.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlFive.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlSix.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlSeven.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlEight.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlNine.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlZero.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlPlus.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlMinus.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlTImes.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlDivide.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlEquals.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlDecimal.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlAddToNote.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlDelete.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlAddToNote.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlSquareRoot.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlExponent.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.pnlDelete.BackgroundImage = My.Resources.CalculatorButtonDark
        Calculator.btnAddToNote.BackgroundImage = My.Resources.Dark_Edit_1
        Calculator.btnExit.BackgroundImage = My.Resources.Dark_CancelDelete_1
        Calculator.pnlDisplayOutput.Image = My.Resources.CalculatorBarDark
        Calculator.lblClear.ForeColor = Color.White
    End Sub
    Public Sub DarkModeOff()
        My.Settings.DarkMode = False
        btnOn.Show()
        btnOff.Hide()
        Me.BackgroundImage = My.Resources.Back2
        btnCreateNotes.Image = My.Resources.CreateButton
        btnToggleEditing.Image = My.Resources.Edit
        btnOpenSettings.Image = My.Resources.Settings
        pnlSettings.BackgroundImage = My.Resources.SettingsDrawer4
        btnGhostModeOff.Image = My.Resources.Button_OffCorrect
        btnGhostModeOn.Image = My.Resources.Button_OnCorrect
        btnOn.Image = My.Resources.Button_OnCorrect
        btnOff.Image = My.Resources.Button_OffCorrect
        ChangePanelColors(PnlNote1, lblNote1, lblNote1Title)
        ChangePanelColors(PnlNote2, lblNote2, lblNote2Title)
        ChangePanelColors(PnlNote3, lblNote3, lblNote3Title)
        ChangePanelColors(PnlNote4, lblNote4, lblNote4Title)
        ChangePanelColors(PnlNote5, lblNote5, lblNote5Title)
        ChangePanelColors(PnlNote6, lblNote6, lblNote6Title)
        ChangePanelColors(PnlNote7, lblNote7, lblNote7Title)
        ChangePanelColors(PnlNote8, lblNote8, lblNote8Title)
        ChangePanelColors(PnlNote9, lblNote9, lblNote9Title)
        btnDeleteNote1.Image = My.Resources.Cancel_Delete
        btnDeleteNote2.Image = My.Resources.Cancel_Delete
        btnDeleteNote3.Image = My.Resources.Cancel_Delete
        btnDeleteNote4.Image = My.Resources.Cancel_Delete
        btnDeleteNote5.Image = My.Resources.Cancel_Delete
        btnDeleteNote6.Image = My.Resources.Cancel_Delete
        btnDeleteNote7.Image = My.Resources.Cancel_Delete
        btnDeleteNote8.Image = My.Resources.Cancel_Delete
        btnDeleteNote9.Image = My.Resources.Cancel_Delete
        lblAppTitle.ForeColor = Color.Black
        lblNoNotes.ForeColor = Color.Black
        lblSettingsTitle.ForeColor = Color.Black
        lblClearAll.ForeColor = Color.Black
        lblDarkMode.ForeColor = Color.Black
        lblGhostMode.ForeColor = Color.Black

        'FormCreateNotes
        FormCreateNotes.btnGhostModeOff.Image = My.Resources.Button_OffCorrect
        FormCreateNotes.btnGhostModeOn.Image = My.Resources.Button_OnCorrect
        FormCreateNotes.btnOn.Image = My.Resources.Button_OnCorrect
        FormCreateNotes.btnOff.Image = My.Resources.Button_OffCorrect
        FormCreateNotes.btnOpenWheel.Image = My.Resources.NewOpenColorLight
        FormCreateNotes.btnCloseWheel.Image = My.Resources.NewOpenColorLight
        FormCreateNotes.pnlColorwheel.BackgroundImage = My.Resources.LightSelectionBar2
        FormCreateNotes.BackColor = Color.White
        FormCreateNotes.btnOpenSettings.Image = My.Resources.Settings
        FormCreateNotes.pnlSettings.BackgroundImage = My.Resources.SettingsDrawer4
        FormCreateNotes.btnOff.Hide()
        FormCreateNotes.btnOn.Show()
        FormCreateNotes.lblSettingsTitle.ForeColor = Color.Black
        FormCreateNotes.lblDarkMode.ForeColor = Color.Black
        FormCreateNotes.lblGhostMode.ForeColor = Color.Black
        FormCreateNotes.BackgroundImage = My.Resources.NoteCreation2_0
        FormCreateNotes.txtNoteTitle.BackColor = Color.White
        FormCreateNotes.rtxNoteText.BackColor = Color.White
        FormCreateNotes.txtNoteTitle.ForeColor = Color.Black
        FormCreateNotes.rtxNoteText.ForeColor = Color.Black
        FormCreateNotes.lblPromptNote.ForeColor = Color.Black
        FormCreateNotes.btnCancel.Image = My.Resources.Cancel_Delete
        FormCreateNotes.btnSubmitNotes.Image = My.Resources.Submit
        FormCreateNotes.btnCalculator.Image = My.Resources.CalculatorButton

        'Expanded Note
        ExpandedNote.BackgroundImage = My.Resources.Back2
        ExpandedNote.lblDeleteNote.ForeColor = Color.Black
        ExpandedNote.lblExpandedNote.ForeColor = Color.Black
        ExpandedNote.lblExpandedNoteTitle.ForeColor = Color.Black
        ExpandedNote.btnDeleteNote2.Image = My.Resources.Cancel_Delete
        ExpandedNote.btnToggleEditing.Image = My.Resources.Edit

        'Calculator
        Calculator.lblOne.ForeColor = Color.Black
        Calculator.lblTwo.ForeColor = Color.Black
        Calculator.lblThree.ForeColor = Color.Black
        Calculator.lblFour.ForeColor = Color.Black
        Calculator.lblFive.ForeColor = Color.Black
        Calculator.lblSix.ForeColor = Color.Black
        Calculator.lblSeven.ForeColor = Color.Black
        Calculator.lblEight.ForeColor = Color.Black
        Calculator.lblNine.ForeColor = Color.Black
        Calculator.lblZero.ForeColor = Color.Black
        Calculator.lblDisplayOutput.ForeColor = Color.Black
        Calculator.lblDisplayOutput.BackColor = Color.White
        Calculator.lblEquation.ForeColor = Color.Black
        Calculator.lblEquation.BackColor = Color.White
        Calculator.lblDecimal.ForeColor = Color.Black
        Calculator.lblEquals.ForeColor = Color.Black
        Calculator.lblDivide.ForeColor = Color.Black
        Calculator.lblTimes.ForeColor = Color.Black
        Calculator.lblPlus.ForeColor = Color.Black
        Calculator.lblMinus.ForeColor = Color.Black
        Calculator.lblExponent.ForeColor = Color.Black
        Calculator.lblSquareRoot.ForeColor = Color.Black
        Calculator.BackgroundImage = My.Resources.CalculatorBack
        Calculator.pnlOne.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlTwo.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlThree.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlFour.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlFive.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlSix.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlSeven.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlEight.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlNine.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlZero.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlPlus.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlMinus.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlTImes.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlDivide.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlEquals.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlDecimal.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlAddToNote.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlSquareRoot.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlExponent.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.pnlDelete.BackgroundImage = My.Resources.CalculatorButtonReal
        Calculator.btnAddToNote.BackgroundImage = My.Resources.Edit
        Calculator.btnExit.BackgroundImage = My.Resources.Cancel_Delete
        Calculator.pnlDisplayOutput.Image = My.Resources.CalculatorBar
        Calculator.lblClear.ForeColor = Color.Black
    End Sub
    Public Sub CheckDarkMode()
        If My.Settings.DarkMode = True Then
            DarkModeOn()
        Else
            DarkModeOff()
        End If
    End Sub
    'Rememeber User Info
    Public Sub RememberInfo()
        lblNote1.Text = My.Settings.Note1
        lblNote2.Text = My.Settings.Note2
        lblNote3.Text = My.Settings.Note3
        lblNote4.Text = My.Settings.Note4
        lblNote5.Text = My.Settings.Note5
        lblNote6.Text = My.Settings.Note6
        lblNote7.Text = My.Settings.Note7
        lblNote8.Text = My.Settings.Note8
        lblNote9.Text = My.Settings.Note9
        lblNote1Title.Text = My.Settings.Note1_Title
        lblNote2Title.Text = My.Settings.Note2_Title
        lblNote3Title.Text = My.Settings.Note3_Title
        lblNote4Title.Text = My.Settings.Note4_Title
        lblNote5Title.Text = My.Settings.Note5_Title
        lblNote6Title.Text = My.Settings.Note6_Title
        lblNote7Title.Text = My.Settings.Note7_Title
        lblNote8Title.Text = My.Settings.Note8_Title
        lblNote9Title.Text = My.Settings.Note9_Title
        FormCreateNotes.RememberColor(My.Settings.Note1Color, PnlNote1, lblNote1Title, lblNote1)
        FormCreateNotes.RememberColor(My.Settings.Note2Color, PnlNote2, lblNote2Title, lblNote2)
        FormCreateNotes.RememberColor(My.Settings.Note3Color, PnlNote3, lblNote3Title, lblNote3)
        FormCreateNotes.RememberColor(My.Settings.Note4Color, PnlNote4, lblNote4Title, lblNote4)
        FormCreateNotes.RememberColor(My.Settings.Note5Color, PnlNote5, lblNote5Title, lblNote5)
        FormCreateNotes.RememberColor(My.Settings.Note6Color, PnlNote6, lblNote6Title, lblNote6)
        FormCreateNotes.RememberColor(My.Settings.Note7Color, PnlNote7, lblNote7Title, lblNote7)
        FormCreateNotes.RememberColor(My.Settings.Note8Color, PnlNote8, lblNote8Title, lblNote8)
        FormCreateNotes.RememberColor(My.Settings.Note9Color, PnlNote9, lblNote9Title, lblNote9)
    End Sub

    'Subroutine for handling Editing
    Public Sub EditNotes(ByVal Label As Label, ByVal Title As Label)
        If My.Settings.DarkMode = False Then
            DarkModeOff()
        Else
            DarkModeOn()
        End If
        ExpandedNote.Location = Me.Location
        FormCreateNotes.Location = Me.Location
        FormCreateNotes.Show()
        FormCreateNotes.lblPromptNote.Text = ("Editing " + Title.Text)
        FormCreateNotes.rtxNoteText.Text = Label.Text
        FormCreateNotes.txtNoteTitle.Text = Title.Text
    End Sub

    'Implements Expanding notes
    Public Sub ExpandNotes(ByVal Label As Label, ByVal Title As Label)
        ExpandedNote.Show()
        Me.Hide()
        ExpandedNote.lblExpandedNote.Text = Label.Text
        ExpandedNote.lblExpandedNoteTitle.Text = Title.Text
    End Sub

    'Checks empty notes
    Public Sub CheckForNotes()
        If My.Settings.Note1 = "" Then
            PnlNote1.Hide()
        Else
            PnlNote1.Show()
        End If
        If My.Settings.Note2 = "" Then
            PnlNote2.Hide()
        Else
            PnlNote2.Show()
        End If
        If My.Settings.Note3 = "" Then
            PnlNote3.Hide()
        Else
            PnlNote3.Show()
        End If
        If My.Settings.Note4 = "" Then
            PnlNote4.Hide()
        Else
            PnlNote4.Show()
        End If
        If My.Settings.Note5 = "" Then
            PnlNote5.Hide()
        Else
            PnlNote5.Show()
        End If
        If My.Settings.Note6 = "" Then
            PnlNote6.Hide()
        Else
            PnlNote6.Show()
        End If
        If My.Settings.Note7 = "" Then
            PnlNote7.Hide()
        Else
            PnlNote7.Show()
        End If
        If My.Settings.Note8 = "" Then
            PnlNote8.Hide()
        Else
            PnlNote8.Show()
        End If
        If My.Settings.Note9 = "" Then
            PnlNote9.Hide()
        Else
            PnlNote9.Show()
        End If
        If My.Settings.Note1 = "" And My.Settings.Note2 = "" And My.Settings.Note3 = "" And My.Settings.Note4 = "" And My.Settings.Note5 = "" And My.Settings.Note6 = "" And My.Settings.Note7 = "" And My.Settings.Note8 = "" And My.Settings.Note9 = "" Then
            pnlNoNotes.Show()
            pnlNoNotes.BringToFront()
            pnlSettings.BringToFront()
            lblClearAll.Hide()
            btnCreateNotes.Location = New Point(btnToggleEditing.Location.X, btnToggleEditing.Location.Y)
        Else
            If Me.Size = New Size(708, 809) Then
                btnCreateNotes.Location = New Point(309, 693)
            End If
            pnlNoNotes.Hide()
            lblClearAll.Show()
            btnCreateNotes.Show()
        End If

    End Sub

    'Handles Deleting a Note
    Public Sub DeleteANote(ByVal Label As Label, ByVal Title As Label, ByVal Panel As Panel)
        Label.Text = ""
        Title.Text = ""
        Panel.Hide()
        Panel.BackgroundImage = My.Resources.White
        FormCreateNotes.SaveInfo()
        CheckForNotes()
    End Sub

    'Clears all notes
    Public Sub ClearAll()
        DeleteANote(lblNote1, lblNote1Title, PnlNote1)
        DeleteANote(lblNote2, lblNote2Title, PnlNote2)
        DeleteANote(lblNote3, lblNote3Title, PnlNote3)
        DeleteANote(lblNote4, lblNote4Title, PnlNote4)
        DeleteANote(lblNote5, lblNote5Title, PnlNote5)
        DeleteANote(lblNote6, lblNote6Title, PnlNote6)
        DeleteANote(lblNote7, lblNote7Title, PnlNote7)
        DeleteANote(lblNote8, lblNote8Title, PnlNote8)
        DeleteANote(lblNote9, lblNote9Title, PnlNote9)
    End Sub

    'Opens/Closes Settings Panel
    Public Sub OpenSettings()
        If Me.Size = New Size(708, 809) Then
            If pnlSettings.Location.Y <> 314 Then
                For intx As Integer = 1 To 400 Step 2

                    pnlSettings.Location = New Point(0, intx)

                Next

            End If
        Else
            For intx As Integer = 1 To 600 Step 2

            pnlSettings.Location = New Point(0, intx)

        Next

        End If
        pnlSettings.Show()
    End Sub
    Public Sub CloseSettings()
        For intx As Integer = 400 To 1 Step -100
            pnlSettings.Location = New Point(0, intx)

        Next
        pnlSettings.Hide()
    End Sub

    'Fixes Expanded/Formcreatenotes note location Issues
    Public Sub FixExpandedNoteLocationIssues()
        ExpandedNote.Show()
        FormCreateNotes.Show()
        Calculator.Show()
        ExpandedNote.Hide()
        FormCreateNotes.Hide()
        Calculator.Show()
    End Sub

    'Handles Ghost Mode
    Public Sub GhostModeOn()
        Me.Opacity = 0.75
        ExpandedNote.Opacity = 0.75
        FormCreateNotes.Opacity = 0.75
        Calculator.Opacity = 0.75
        btnGhostModeOn.Hide()
        btnGhostModeOff.Show()
        FormCreateNotes.btnGhostModeOn.Hide()
        FormCreateNotes.btnGhostModeOff.Show()
        blnGhostMode = True
    End Sub
    Public Sub GhostModeOff()
        Me.Opacity = 1
        ExpandedNote.Opacity = 1
        FormCreateNotes.Opacity = 1
        Calculator.Opacity = 1
        btnGhostModeOn.Show()
        btnGhostModeOff.Hide()
        FormCreateNotes.btnGhostModeOn.Show()
        FormCreateNotes.btnGhostModeOff.Hide()
        blnGhostMode = False
    End Sub
    Public Sub CheckGhostMode()
        If blnGhostMode Then
            GhostModeOn()
        Else
            GhostModeOff()
        End If
    End Sub

    'Just checks for everythig that ever needs to be checked(lazy, I know)
    Public Sub CheckForEverything()
        FormCreateNotes.Size = Me.Size
        ExpandedNote.Size = Me.Size
        CheckDarkMode()
        CheckGhostMode()
        CheckForNotes()
        FixExpandedNoteLocationIssues()
    End Sub

    'Shortcut for changing the colors for notes
    Public Sub ChangePanelColors(ByVal panel As Panel, ByVal label As Label, ByVal title As Label)
        RememberInfo()
        If panel.BackgroundImage.Equals(My.Resources.White) Then
            panel.BackgroundImage = My.Resources.White
            label.ForeColor = Color.Black
            title.ForeColor = Color.Black
        End If
    End Sub
    Public Sub ChangePanelColorsDark(ByVal panel As Panel, ByVal label As Label, ByVal title As Label)
        panel.BackgroundImage = My.Resources.Dark_Notes
        label.ForeColor = Color.White
        title.ForeColor = Color.White
    End Sub


End Class