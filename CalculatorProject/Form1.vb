Public Class Form1
    Dim red, green, blue, colorValue As Integer
    Dim result As Decimal
    Dim inputIsFloat As Boolean = False
    Dim resultDisplayed As Boolean = False
    Dim controlsVisible As Boolean = False
    Dim currentOperator As String = ""
    Dim incre As Integer = 1
    Dim i As Integer = 0

    'Core Functions-----------------------------------------------------------------------------

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        btnClear.PerformClick()
        btnToggle.Enabled = False

        If btnToggle.Text = "ON" Then
            btnToggle.Text = "OFF"
            controlsVisible = True
        Else
            btnToggle.Text = "ON"
        End If

        colorWaveTimer.Enabled = True

        For Each control In Me.Controls
            If control.GetType() = GetType(Button) Then
                control.BackColor = Color.Black
            End If
        Next

    End Sub

    Private Sub numericButton_Click(sender As Object, e As EventArgs) Handles btnZero.Click, btnOne.Click, btnTwo.Click, btnThree.Click, btnFour.Click, btnFive.Click, btnSix.Click, btnSeven.Click, btnEight.Click, btnNine.Click
        If sender.Equals(btnZero) Then
            appendNumber("0")
        ElseIf sender.Equals(btnOne) Then
            appendNumber("1")
        ElseIf sender.Equals(btnTwo) Then
            appendNumber("2")
        ElseIf sender.Equals(btnThree) Then
            appendNumber("3")
        ElseIf sender.Equals(btnFour) Then
            appendNumber("4")
        ElseIf sender.Equals(btnFive) Then
            appendNumber("5")
        ElseIf sender.Equals(btnSix) Then
            appendNumber("6")
        ElseIf sender.Equals(btnSeven) Then
            appendNumber("7")
        ElseIf sender.Equals(btnEight) Then
            appendNumber("8")
        Else
            appendNumber("9")
        End If
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If resultDisplayed Then
            txtOutput.Text = "0"
            resultDisplayed = False
        End If

        If Not inputIsFloat Then
            txtOutput.Text += "."
            inputIsFloat = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        inputIsFloat = False
        resultDisplayed = True
        currentOperator = ""
        txtEquation.Text = ""
        txtOutput.Text = "0"
        result = "0"
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim count As Integer = txtOutput.Text.Length

        If count > 1 Then
            txtOutput.Text = txtOutput.Text.Remove(count - 1)
        Else
            txtOutput.Text = 0
        End If
    End Sub

    Private Sub operator_click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSub.Click, btnMultiply.Click, btnDivide.Click, btnEquals.Click
        If sender.Equals(btnAdd) Then
            computeEquation("+")
        ElseIf sender.Equals(btnSub) Then
            computeEquation("-")
        ElseIf sender.Equals(btnMultiply) Then
            computeEquation("*")
        ElseIf sender.Equals(btnDivide) Then
            computeEquation("/")
        Else
            computeEquation("")
            txtEquation.Text = ""
        End If
    End Sub

    Private Sub computeEquation(x As String)
        If Not txtOutput.Text = "Infinity" Then
            inputIsFloat = False
            resultDisplayed = True
            txtEquation.Text += txtOutput.Text + " " + x + " "

            If currentOperator = "" Then
                result = txtOutput.Text
            Else
                Select Case currentOperator
                    Case "+"
                        result += txtOutput.Text
                        txtOutput.Text = result
                    Case "-"
                        result -= txtOutput.Text
                        txtOutput.Text = result
                    Case "*"
                        result *= txtOutput.Text
                        txtOutput.Text = result
                    Case "/"
                        If txtOutput.Text = "0" Then
                            txtOutput.Text = "Infinity"
                            txtEquation.Text = ""
                            currentOperator = ""
                            result = 0
                        Else
                            result /= txtOutput.Text
                            txtOutput.Text = result
                        End If
                End Select
            End If

            currentOperator = x
        End If
    End Sub

    Private Sub appendNumber(number As String)
        If resultDisplayed Then
            txtOutput.Text = "0"
            resultDisplayed = False
        End If

        If Not txtOutput.Text = "0" Then
            txtOutput.Text += number
        Else
            txtOutput.Text = number
        End If
    End Sub

    'Color Wave Effect-----------------------------------------------------------------------------

    Private Sub colorWaveEffect(sender As Object, e As EventArgs) Handles colorWaveTimer.Tick
        Dim colorWaveColors() As Color = {Color.Black, ColorTranslator.FromHtml("#dcecc9"), ColorTranslator.FromHtml("#b3ddcc"), ColorTranslator.FromHtml("#8acdce"), ColorTranslator.FromHtml("#62bed2"), ColorTranslator.FromHtml("#46aace"), ColorTranslator.FromHtml("#3d91be"), ColorTranslator.FromHtml("#3577ae"), ColorTranslator.FromHtml("#2d5e9e"), ColorTranslator.FromHtml("#24448e"), ColorTranslator.FromHtml("#1c2b7f"), ColorTranslator.FromHtml("#162065"), ColorTranslator.FromHtml("#11174b")}

        If i >= 0 Then
            If i >= 0 And i < colorWaveColors.Length Then
                btnToggle.BackColor = colorWaveColors(i)
            End If
            If i >= 1 And i < colorWaveColors.Length + 1 Then
                btnZero.BackColor = colorWaveColors(i - 1)
                btnOne.BackColor = colorWaveColors(i - 1)
                btnTwo.BackColor = colorWaveColors(i - 1)
                btnZero.Visible = controlsVisible
                btnOne.Visible = controlsVisible
                btnTwo.Visible = controlsVisible
            End If
            If i >= 2 And i < colorWaveColors.Length + 2 Then
                btnFour.BackColor = colorWaveColors(i - 2)
                btnFive.BackColor = colorWaveColors(i - 2)
                btnSix.BackColor = colorWaveColors(i - 2)
                btnThree.BackColor = colorWaveColors(i - 2)
                btnDecimal.BackColor = colorWaveColors(i - 2)
                btnFour.Visible = controlsVisible
                btnFive.Visible = controlsVisible
                btnSix.Visible = controlsVisible
                btnThree.Visible = controlsVisible
                btnDecimal.Visible = controlsVisible
            End If
            If i >= 3 And i < colorWaveColors.Length + 3 Then
                btnSeven.BackColor = colorWaveColors(i - 3)
                btnEight.BackColor = colorWaveColors(i - 3)
                btnNine.BackColor = colorWaveColors(i - 3)
                btnDivide.BackColor = colorWaveColors(i - 3)
                btnMultiply.BackColor = colorWaveColors(i - 3)
                btnSub.BackColor = colorWaveColors(i - 3)
                btnAdd.BackColor = colorWaveColors(i - 3)
                btnSeven.Visible = controlsVisible
                btnEight.Visible = controlsVisible
                btnNine.Visible = controlsVisible
                btnDivide.Visible = controlsVisible
                btnMultiply.Visible = controlsVisible
                btnSub.Visible = controlsVisible
                btnAdd.Visible = controlsVisible
            End If
            If i >= 4 And i < colorWaveColors.Length + 4 Then
                btnClear.BackColor = colorWaveColors(i - 4)
                btnDel.BackColor = colorWaveColors(i - 4)
                btnEquals.BackColor = colorWaveColors(i - 4)
                btnClear.Visible = controlsVisible
                btnDel.Visible = controlsVisible
                btnEquals.Visible = controlsVisible
            End If
            If i >= 5 And i < colorWaveColors.Length + 5 Then
                txtOutput.BackColor = colorWaveColors(i - 5)
                txtOutput.Visible = controlsVisible
            End If
            If i >= 6 And i < colorWaveColors.Length + 6 Then
                txtEquation.BackColor = colorWaveColors(i - 6)
                txtEquation.Visible = controlsVisible
                lblCalculator.Visible = controlsVisible
            End If

            i += incre
            If i = colorWaveColors.Length + 6 Then
                incre = -1
                If btnToggle.Text = "ON" Then
                    controlsVisible = False
                End If
            End If
        Else
            incre = 1
            i = 0
            colorWaveTimer.Enabled = False
            btnToggle.Enabled = True
        End If
    End Sub

End Class