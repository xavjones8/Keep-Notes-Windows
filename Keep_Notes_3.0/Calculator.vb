Public Class Calculator

    Dim operand1 As Double = 0
    Dim operation As New Operation
    Public final As Double

    Public Sub lblOne_Click(sender As Object, e As EventArgs) Handles lblOne.Click, lblTwo.Click, lblThree.Click, lblFour.Click, lblFive.Click, lblSix.Click, lblSeven.Click, lblEight.Click, lblNine.Click, lblZero.Click, lblPlus.Click, lblMinus.Click, lblTimes.Click, lblDivide.Click, lblExponent.Click, lblSquareRoot.Click, lblDecimal.Click
        If operation.sign = "" And (sender.Equals(lblPlus) Or sender.Equals(lblMinus) Or sender.Equals(lblTimes) Or sender.Equals(lblDivide) Or sender.Equals(lblExponent) Or sender.Equals(lblSquareRoot)) Then
            operand1 = Convert.ToDouble(lblDisplayOutput.Text)
            operation.sign = sender.ToString()((sender.ToString().Length - 1))
            lblEquation.Text &= operation.sign
            lblDisplayOutput.Text = ""
            lblPlus.Enabled = False
            lblMinus.Enabled = False
            lblTimes.Enabled = False
            lblDivide.Enabled = False
            lblExponent.Enabled = False
            lblSquareRoot.Enabled = False

        ElseIf operation.sign = "" And (sender.Equals(lblPlus) = False Or sender.Equals(lblMinus) = False Or sender.Equals(lblTimes) = False Or sender.Equals(lblDivide) = False Or sender.Equals(lblExponent) = False Or sender.Equals(lblSquareRoot) = False And sender.Equals(lblEquals) = False) Then
            lblDisplayOutput.Text &= sender.ToString()((sender.ToString().Length - 1))
            lblEquation.Text = lblDisplayOutput.Text
        ElseIf operation.sign <> "" And (sender.Equals(lblPlus) = False Or sender.Equals(lblMinus) = False Or sender.Equals(lblTimes) = False Or sender.Equals(lblDivide) = False Or sender.Equals(lblExponent) = False Or sender.Equals(lblSquareRoot) = False And sender.Equals(lblEquals) = False) Then
            lblEquation.Text &= sender.ToString()((sender.ToString().Length - 1))
            lblDisplayOutput.Text &= sender.ToString()((sender.ToString().Length - 1))
        End If

    End Sub
    Public Function calculate(ByRef term1 As Double, ByVal sign As String) As Double
        If sign <> "" And lblDisplayOutput.Text <> "" Then
            If sign = "+" Then
                final = term1 + Val(lblDisplayOutput.Text)
            ElseIf sign = "-" Then
                final = term1 - Val(lblDisplayOutput.Text)
            ElseIf sign = "x" Then
                final = term1 * Val(lblDisplayOutput.Text)
            ElseIf sign = "÷" Then
                final = term1 / Val(lblDisplayOutput.Text)
            ElseIf sign = "^" Then
                final = term1 ^ Val(lblDisplayOutput.Text)
            ElseIf sign = "√" Then
                If term1 = 0 Then
                    final = Math.Sqrt(Val(lblDisplayOutput.Text))
                Else
                    final = term1 * Math.Sqrt(Val(lblDisplayOutput.Text))
                End If

            End If
        Else
            final = term1
        End If
        Return final
    End Function

    Public Sub lblEquals_Click(sender As Object, e As EventArgs) Handles lblEquals.Click
        lblDisplayOutput.Text = calculate(operand1, operation.sign).ToString()
        operand1 = Convert.ToDouble(lblDisplayOutput.Text)
        operation.sign = ""
        lblPlus.Enabled = True
        lblMinus.Enabled = True
        lblTimes.Enabled = True
        lblDivide.Enabled = True
        lblExponent.Enabled = True
        lblSquareRoot.Enabled = True
    End Sub

    Public Sub clearAll()
        lblEquation.Text = ""
        lblDisplayOutput.Text = ""
        operand1 = 0
        operation.sign = ""
        final = 0
    End Sub
    Private Sub LblClear_Click(sender As Object, e As EventArgs) Handles lblClear.Click
        clearAll()
    End Sub

    Private Sub Calculator_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim key As Keys = e.KeyCode
        Select Case key
            Case key.D1, key.NumPad1
                lblOne_Click(lblOne, New EventArgs())
            Case key.D2, key.NumPad2
                lblOne_Click(lblTwo, New EventArgs())
            Case key.D3, key.NumPad3
                lblOne_Click(lblThree, New EventArgs())
            Case key.D4, key.NumPad4
                lblOne_Click(lblFour, New EventArgs())
            Case key.D5, key.NumPad5
                lblOne_Click(lblFive, New EventArgs())
            Case key.D6, key.NumPad6
                lblOne_Click(lblSix, New EventArgs())
            Case key.D7, key.NumPad7
                lblOne_Click(lblSeven, New EventArgs())
            Case key.D8, key.NumPad8
                lblOne_Click(lblEight, New EventArgs())
            Case key.D9, key.NumPad9
                lblOne_Click(lblNine, New EventArgs())
            Case key.D0, key.NumPad0
                lblOne_Click(lblZero, New EventArgs())
            Case key.Add
                lblOne_Click(lblPlus, New EventArgs())
            Case key.Subtract
                lblOne_Click(lblMinus, New EventArgs())
            Case key.Multiply
                lblOne_Click(lblTimes, New EventArgs())
            Case key.Divide
                lblOne_Click(lblDivide, New EventArgs())
            Case key.E
                lblOne_Click(lblExponent, New EventArgs())
            Case key.R
                lblOne_Click(lblSquareRoot, New EventArgs())
            Case key.Enter
                lblEquals_Click(lblEquals, New EventArgs())
            Case key.Space, key.C
                clearAll()
            Case key.Decimal
                lblOne_Click(lblDecimal, New EventArgs())
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        clearAll()
        FormCreateNotes.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddToNote_Click(sender As Object, e As EventArgs) Handles btnAddToNote.Click
        FormCreateNotes.rtxNoteText.Text &= " " + lblDisplayOutput.Text
        btnExit_Click(btnExit, New EventArgs())
    End Sub

    Private Sub Calculator_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Form1.CheckForEverything()
    End Sub

    Private Sub Calculator_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        FormCreateNotes.Location = Me.Location
        Form1.Location = Me.Location
        ExpandedNote.Location = Me.Location
    End Sub

    Private Sub Calculator_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        clearAll()
        FormCreateNotes.Show()
    End Sub
End Class


Public Class Operation
    Public Property sign As String = ""

End Class