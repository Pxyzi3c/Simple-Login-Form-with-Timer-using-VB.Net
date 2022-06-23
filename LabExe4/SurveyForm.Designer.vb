<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SurveyForm
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
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblHr = New System.Windows.Forms.Label()
        Me.lblCol = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBG = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNameLbl = New System.Windows.Forms.Label()
        Me.pnlName = New System.Windows.Forms.Panel()
        Me.pnlGender = New System.Windows.Forms.Panel()
        Me.lblGenderLbl = New System.Windows.Forms.Label()
        Me.lblProgramLbl = New System.Windows.Forms.Label()
        Me.pnlProgram = New System.Windows.Forms.Panel()
        Me.pnlBG.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(44, 9)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(105, 28)
        Me.lblTimer.TabIndex = 0
        Me.lblTimer.Text = "T I M E R"
        '
        'lblHr
        '
        Me.lblHr.AutoSize = True
        Me.lblHr.BackColor = System.Drawing.Color.Transparent
        Me.lblHr.Font = New System.Drawing.Font("Agency FB", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHr.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblHr.Location = New System.Drawing.Point(6, 51)
        Me.lblHr.Name = "lblHr"
        Me.lblHr.Size = New System.Drawing.Size(89, 77)
        Me.lblHr.TabIndex = 1
        Me.lblHr.Text = "00"
        '
        'lblCol
        '
        Me.lblCol.AutoSize = True
        Me.lblCol.BackColor = System.Drawing.Color.Transparent
        Me.lblCol.Font = New System.Drawing.Font("Agency FB", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCol.ForeColor = System.Drawing.Color.White
        Me.lblCol.Location = New System.Drawing.Point(80, 42)
        Me.lblCol.Name = "lblCol"
        Me.lblCol.Size = New System.Drawing.Size(43, 77)
        Me.lblCol.TabIndex = 2
        Me.lblCol.Text = ":"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.Transparent
        Me.lblMin.Font = New System.Drawing.Font("Agency FB", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMin.ForeColor = System.Drawing.Color.Crimson
        Me.lblMin.Location = New System.Drawing.Point(106, 50)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(89, 77)
        Me.lblMin.TabIndex = 3
        Me.lblMin.Text = "00"
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.BackColor = System.Drawing.Color.Transparent
        Me.lblSec.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSec.ForeColor = System.Drawing.Color.White
        Me.lblSec.Location = New System.Drawing.Point(78, 119)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(36, 31)
        Me.lblSec.TabIndex = 5
        Me.lblSec.Text = "00"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(260, 76)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(84, 28)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGender.ForeColor = System.Drawing.Color.White
        Me.lblGender.Location = New System.Drawing.Point(260, 146)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(100, 28)
        Me.lblGender.TabIndex = 7
        Me.lblGender.Text = "Gender"
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.BackColor = System.Drawing.Color.Transparent
        Me.lblProgram.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProgram.ForeColor = System.Drawing.Color.White
        Me.lblProgram.Location = New System.Drawing.Point(260, 215)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(111, 28)
        Me.lblProgram.TabIndex = 8
        Me.lblProgram.Text = "Program"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.DarkBlue
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(13, 179)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(83, 45)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Crimson
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.Location = New System.Drawing.Point(104, 179)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(83, 45)
        Me.btnStop.TabIndex = 10
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'pnlBG
        '
        Me.pnlBG.Controls.Add(Me.Panel1)
        Me.pnlBG.Controls.Add(Me.lblTimer)
        Me.pnlBG.Controls.Add(Me.lblCol)
        Me.pnlBG.Controls.Add(Me.btnStop)
        Me.pnlBG.Controls.Add(Me.btnStart)
        Me.pnlBG.Controls.Add(Me.lblHr)
        Me.pnlBG.Controls.Add(Me.lblSec)
        Me.pnlBG.Controls.Add(Me.lblMin)
        Me.pnlBG.Location = New System.Drawing.Point(20, 24)
        Me.pnlBG.Name = "pnlBG"
        Me.pnlBG.Size = New System.Drawing.Size(202, 242)
        Me.pnlBG.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(25, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 1)
        Me.Panel1.TabIndex = 12
        '
        'lblNameLbl
        '
        Me.lblNameLbl.AutoSize = True
        Me.lblNameLbl.BackColor = System.Drawing.Color.Transparent
        Me.lblNameLbl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNameLbl.ForeColor = System.Drawing.Color.White
        Me.lblNameLbl.Location = New System.Drawing.Point(239, 48)
        Me.lblNameLbl.Name = "lblNameLbl"
        Me.lblNameLbl.Size = New System.Drawing.Size(58, 21)
        Me.lblNameLbl.TabIndex = 12
        Me.lblNameLbl.Text = "Name"
        '
        'pnlName
        '
        Me.pnlName.BackColor = System.Drawing.Color.White
        Me.pnlName.Location = New System.Drawing.Point(244, 72)
        Me.pnlName.Name = "pnlName"
        Me.pnlName.Size = New System.Drawing.Size(100, 1)
        Me.pnlName.TabIndex = 13
        '
        'pnlGender
        '
        Me.pnlGender.BackColor = System.Drawing.Color.White
        Me.pnlGender.Location = New System.Drawing.Point(244, 141)
        Me.pnlGender.Name = "pnlGender"
        Me.pnlGender.Size = New System.Drawing.Size(100, 1)
        Me.pnlGender.TabIndex = 16
        '
        'lblGenderLbl
        '
        Me.lblGenderLbl.AutoSize = True
        Me.lblGenderLbl.BackColor = System.Drawing.Color.Transparent
        Me.lblGenderLbl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGenderLbl.ForeColor = System.Drawing.Color.White
        Me.lblGenderLbl.Location = New System.Drawing.Point(239, 117)
        Me.lblGenderLbl.Name = "lblGenderLbl"
        Me.lblGenderLbl.Size = New System.Drawing.Size(70, 21)
        Me.lblGenderLbl.TabIndex = 15
        Me.lblGenderLbl.Text = "Gender"
        '
        'lblProgramLbl
        '
        Me.lblProgramLbl.AutoSize = True
        Me.lblProgramLbl.BackColor = System.Drawing.Color.Transparent
        Me.lblProgramLbl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProgramLbl.ForeColor = System.Drawing.Color.White
        Me.lblProgramLbl.Location = New System.Drawing.Point(239, 186)
        Me.lblProgramLbl.Name = "lblProgramLbl"
        Me.lblProgramLbl.Size = New System.Drawing.Size(76, 21)
        Me.lblProgramLbl.TabIndex = 17
        Me.lblProgramLbl.Text = "Program"
        '
        'pnlProgram
        '
        Me.pnlProgram.BackColor = System.Drawing.Color.White
        Me.pnlProgram.Location = New System.Drawing.Point(244, 210)
        Me.pnlProgram.Name = "pnlProgram"
        Me.pnlProgram.Size = New System.Drawing.Size(100, 1)
        Me.pnlProgram.TabIndex = 14
        '
        'SurveyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.LabExe4.My.Resources.Resources.imgBG4
        Me.ClientSize = New System.Drawing.Size(534, 283)
        Me.Controls.Add(Me.pnlProgram)
        Me.Controls.Add(Me.lblProgramLbl)
        Me.Controls.Add(Me.pnlGender)
        Me.Controls.Add(Me.lblGenderLbl)
        Me.Controls.Add(Me.pnlName)
        Me.Controls.Add(Me.lblNameLbl)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pnlBG)
        Me.Name = "SurveyForm"
        Me.Text = "SurveyForm"
        Me.pnlBG.ResumeLayout(False)
        Me.pnlBG.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTimer As Label
    Friend WithEvents lblHr As Label
    Friend WithEvents lblCol As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblSec As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblProgram As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlBG As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNameLbl As Label
    Friend WithEvents pnlName As Panel
    Friend WithEvents pnlGender As Panel
    Friend WithEvents lblGenderLbl As Label
    Friend WithEvents lblProgramLbl As Label
    Friend WithEvents pnlProgram As Panel
End Class
