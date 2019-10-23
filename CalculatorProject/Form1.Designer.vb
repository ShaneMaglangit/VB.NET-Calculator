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
        Me.components = New System.ComponentModel.Container()
        Me.lblCalculator = New System.Windows.Forms.Label()
        Me.txtEquation = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnToggle = New System.Windows.Forms.Button()
        Me.colorWaveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblCalculator
        '
        Me.lblCalculator.AutoSize = True
        Me.lblCalculator.Font = New System.Drawing.Font("Berlin Sans FB Demi", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculator.ForeColor = System.Drawing.Color.White
        Me.lblCalculator.Location = New System.Drawing.Point(10, 9)
        Me.lblCalculator.Name = "lblCalculator"
        Me.lblCalculator.Size = New System.Drawing.Size(257, 27)
        Me.lblCalculator.TabIndex = 0
        Me.lblCalculator.Text = "CALCULATOR PROJECT"
        Me.lblCalculator.Visible = False
        '
        'txtEquation
        '
        Me.txtEquation.BackColor = System.Drawing.Color.Black
        Me.txtEquation.ForeColor = System.Drawing.Color.White
        Me.txtEquation.Location = New System.Drawing.Point(13, 41)
        Me.txtEquation.Name = "txtEquation"
        Me.txtEquation.ReadOnly = True
        Me.txtEquation.Size = New System.Drawing.Size(252, 20)
        Me.txtEquation.TabIndex = 1
        Me.txtEquation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEquation.Visible = False
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.Black
        Me.txtOutput.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.ForeColor = System.Drawing.Color.White
        Me.txtOutput.Location = New System.Drawing.Point(13, 67)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(252, 48)
        Me.txtOutput.TabIndex = 2
        Me.txtOutput.Text = "0"
        Me.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOutput.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(13, 119)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 38)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Black
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(100, 119)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(81, 38)
        Me.btnDel.TabIndex = 4
        Me.btnDel.Text = "DEL"
        Me.btnDel.UseVisualStyleBackColor = False
        Me.btnDel.Visible = False
        '
        'btnEquals
        '
        Me.btnEquals.BackColor = System.Drawing.Color.Black
        Me.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEquals.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquals.ForeColor = System.Drawing.Color.White
        Me.btnEquals.Location = New System.Drawing.Point(184, 119)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(81, 38)
        Me.btnEquals.TabIndex = 5
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = False
        Me.btnEquals.Visible = False
        '
        'btnNine
        '
        Me.btnNine.BackColor = System.Drawing.Color.Black
        Me.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNine.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.ForeColor = System.Drawing.Color.White
        Me.btnNine.Location = New System.Drawing.Point(143, 163)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(59, 38)
        Me.btnNine.TabIndex = 8
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = False
        Me.btnNine.Visible = False
        '
        'btnEight
        '
        Me.btnEight.BackColor = System.Drawing.Color.Black
        Me.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEight.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.ForeColor = System.Drawing.Color.White
        Me.btnEight.Location = New System.Drawing.Point(78, 163)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(59, 38)
        Me.btnEight.TabIndex = 7
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = False
        Me.btnEight.Visible = False
        '
        'btnSeven
        '
        Me.btnSeven.BackColor = System.Drawing.Color.Black
        Me.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeven.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.ForeColor = System.Drawing.Color.White
        Me.btnSeven.Location = New System.Drawing.Point(13, 163)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(59, 38)
        Me.btnSeven.TabIndex = 6
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = False
        Me.btnSeven.Visible = False
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.Color.Black
        Me.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDivide.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.ForeColor = System.Drawing.Color.White
        Me.btnDivide.Location = New System.Drawing.Point(206, 163)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(59, 38)
        Me.btnDivide.TabIndex = 9
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = False
        Me.btnDivide.Visible = False
        '
        'btnMultiply
        '
        Me.btnMultiply.BackColor = System.Drawing.Color.Black
        Me.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultiply.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.ForeColor = System.Drawing.Color.White
        Me.btnMultiply.Location = New System.Drawing.Point(206, 207)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(59, 38)
        Me.btnMultiply.TabIndex = 13
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = False
        Me.btnMultiply.Visible = False
        '
        'btnSix
        '
        Me.btnSix.BackColor = System.Drawing.Color.Black
        Me.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSix.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.ForeColor = System.Drawing.Color.White
        Me.btnSix.Location = New System.Drawing.Point(143, 207)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(59, 38)
        Me.btnSix.TabIndex = 12
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = False
        Me.btnSix.Visible = False
        '
        'btnFive
        '
        Me.btnFive.BackColor = System.Drawing.Color.Black
        Me.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFive.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.ForeColor = System.Drawing.Color.White
        Me.btnFive.Location = New System.Drawing.Point(78, 207)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(59, 38)
        Me.btnFive.TabIndex = 11
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = False
        Me.btnFive.Visible = False
        '
        'btnFour
        '
        Me.btnFour.BackColor = System.Drawing.Color.Black
        Me.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFour.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.ForeColor = System.Drawing.Color.White
        Me.btnFour.Location = New System.Drawing.Point(13, 207)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(59, 38)
        Me.btnFour.TabIndex = 10
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = False
        Me.btnFour.Visible = False
        '
        'btnSub
        '
        Me.btnSub.BackColor = System.Drawing.Color.Black
        Me.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSub.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub.ForeColor = System.Drawing.Color.White
        Me.btnSub.Location = New System.Drawing.Point(206, 251)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(59, 38)
        Me.btnSub.TabIndex = 17
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = False
        Me.btnSub.Visible = False
        '
        'btnThree
        '
        Me.btnThree.BackColor = System.Drawing.Color.Black
        Me.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThree.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.ForeColor = System.Drawing.Color.White
        Me.btnThree.Location = New System.Drawing.Point(143, 251)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(59, 38)
        Me.btnThree.TabIndex = 16
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = False
        Me.btnThree.Visible = False
        '
        'btnTwo
        '
        Me.btnTwo.BackColor = System.Drawing.Color.Black
        Me.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTwo.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.ForeColor = System.Drawing.Color.White
        Me.btnTwo.Location = New System.Drawing.Point(78, 251)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(59, 38)
        Me.btnTwo.TabIndex = 15
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = False
        Me.btnTwo.Visible = False
        '
        'btnOne
        '
        Me.btnOne.BackColor = System.Drawing.Color.Black
        Me.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOne.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.ForeColor = System.Drawing.Color.White
        Me.btnOne.Location = New System.Drawing.Point(13, 251)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(59, 38)
        Me.btnOne.TabIndex = 14
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = False
        Me.btnOne.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Black
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(206, 295)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 38)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.btnAdd.Visible = False
        '
        'btnDecimal
        '
        Me.btnDecimal.BackColor = System.Drawing.Color.Black
        Me.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecimal.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimal.ForeColor = System.Drawing.Color.White
        Me.btnDecimal.Location = New System.Drawing.Point(143, 295)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(59, 38)
        Me.btnDecimal.TabIndex = 20
        Me.btnDecimal.Text = "."
        Me.btnDecimal.UseVisualStyleBackColor = False
        Me.btnDecimal.Visible = False
        '
        'btnZero
        '
        Me.btnZero.BackColor = System.Drawing.Color.Black
        Me.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZero.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.ForeColor = System.Drawing.Color.White
        Me.btnZero.Location = New System.Drawing.Point(78, 295)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(59, 38)
        Me.btnZero.TabIndex = 19
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = False
        Me.btnZero.Visible = False
        '
        'btnToggle
        '
        Me.btnToggle.BackColor = System.Drawing.Color.Black
        Me.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggle.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggle.ForeColor = System.Drawing.Color.White
        Me.btnToggle.Location = New System.Drawing.Point(13, 295)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.Size = New System.Drawing.Size(59, 38)
        Me.btnToggle.TabIndex = 18
        Me.btnToggle.Text = "ON"
        Me.btnToggle.UseVisualStyleBackColor = False
        '
        'colorWaveTimer
        '
        Me.colorWaveTimer.Interval = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(277, 343)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDecimal)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.btnToggle)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSix)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnNine)
        Me.Controls.Add(Me.btnEight)
        Me.Controls.Add(Me.btnSeven)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtEquation)
        Me.Controls.Add(Me.lblCalculator)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "By: Shane Francis Maglangit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCalculator As System.Windows.Forms.Label
    Friend WithEvents txtEquation As System.Windows.Forms.TextBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEquals As System.Windows.Forms.Button
    Friend WithEvents btnNine As System.Windows.Forms.Button
    Friend WithEvents btnEight As System.Windows.Forms.Button
    Friend WithEvents btnSeven As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnSix As System.Windows.Forms.Button
    Friend WithEvents btnFive As System.Windows.Forms.Button
    Friend WithEvents btnFour As System.Windows.Forms.Button
    Friend WithEvents btnSub As System.Windows.Forms.Button
    Friend WithEvents btnThree As System.Windows.Forms.Button
    Friend WithEvents btnTwo As System.Windows.Forms.Button
    Friend WithEvents btnOne As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDecimal As System.Windows.Forms.Button
    Friend WithEvents btnZero As System.Windows.Forms.Button
    Friend WithEvents btnToggle As System.Windows.Forms.Button
    Friend WithEvents colorWaveTimer As System.Windows.Forms.Timer

End Class
