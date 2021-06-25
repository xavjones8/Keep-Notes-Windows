Public Class ExpandedNote

    'Opens form1 if form is closed
    Private Sub ExpandedNote_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    'Opens editing menu
    Private Sub btnToggleEditing_Click(sender As Object, e As EventArgs) Handles btnToggleEditing.Click
        FormCreateNotes.Show()
        Me.Hide()
        If lblExpandedNoteTitle.Text = Form1.lblNote1Title.Text Then
            Form1.EditNotes(Form1.lblNote1, Form1.lblNote1Title)

        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote2Title.Text Then
            Form1.EditNotes(Form1.lblNote2, Form1.lblNote2Title)

        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote3Title.Text Then
            Form1.EditNotes(Form1.lblNote3, Form1.lblNote3Title)

        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote4Title.Text Then
            Form1.EditNotes(Form1.lblNote4, Form1.lblNote4Title)

        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote5Title.Text Then
            Form1.EditNotes(Form1.lblNote5, Form1.lblNote5Title)

        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote6Title.Text Then
            Form1.EditNotes(Form1.lblNote6, Form1.lblNote6Title)

        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote7Title.Text Then
            Form1.EditNotes(Form1.lblNote7, Form1.lblNote7Title)

        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote8Title.Text Then
            Form1.EditNotes(Form1.lblNote8, Form1.lblNote8Title)

        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote9Title.Text Then
            Form1.EditNotes(Form1.lblNote9, Form1.lblNote9Title)
        End If
    End Sub

    'Deletes notes
    Private Sub lblDeleteNote_Click(sender As Object, e As EventArgs) Handles lblDeleteNote.Click
        If lblExpandedNoteTitle.Text = Form1.lblNote1Title.Text Then
            Form1.DeleteANote(Form1.lblNote1, Form1.lblNote1Title, Form1.PnlNote1)
        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote2Title.Text Then
            Form1.DeleteANote(Form1.lblNote2, Form1.lblNote2Title, Form1.PnlNote2)
        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote3Title.Text Then
            Form1.DeleteANote(Form1.lblNote3, Form1.lblNote3Title, Form1.PnlNote3)
        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote4Title.Text Then
            Form1.DeleteANote(Form1.lblNote4, Form1.lblNote4Title, Form1.PnlNote4)
        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote5Title.Text Then
            Form1.DeleteANote(Form1.lblNote5, Form1.lblNote5Title, Form1.PnlNote5)
        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote6Title.Text Then
            Form1.DeleteANote(Form1.lblNote6, Form1.lblNote6Title, Form1.PnlNote6)
        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote7Title.Text Then
            Form1.DeleteANote(Form1.lblNote7, Form1.lblNote7Title, Form1.PnlNote7)
        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote8Title.Text Then
            Form1.DeleteANote(Form1.lblNote8, Form1.lblNote8Title, Form1.PnlNote8)
        ElseIf lblExpandedNoteTitle.Text = Form1.lblNote9Title.Text Then
            Form1.DeleteANote(Form1.lblNote9, Form1.lblNote9Title, Form1.PnlNote9)
        End If
        Form1.CheckForEverything()
        Me.Close()
        Form1.Show()
    End Sub

    'Closes form
    Private Sub btnDeleteNote2_Click(sender As Object, e As EventArgs) Handles btnDeleteNote2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    'Reinforces Dark Mode
    Private Sub ExpandedNote_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Form1.CheckDarkMode()
        Form1.CheckGhostMode()
        Me.Location = Form1.Location
    End Sub


End Class