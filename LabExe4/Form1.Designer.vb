<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lvlYearlevel = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cmbYearlevel = New System.Windows.Forms.ComboBox()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlBG = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlBG.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(148, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ABC SURVEY FORM"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(153, 26)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 19)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "NAME:"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(148, 124)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 29)
        Me.txtName.TabIndex = 3
        '
        'lvlYearlevel
        '
        Me.lvlYearlevel.AutoSize = True
        Me.lvlYearlevel.BackColor = System.Drawing.Color.Transparent
        Me.lvlYearlevel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lvlYearlevel.ForeColor = System.Drawing.Color.White
        Me.lvlYearlevel.Location = New System.Drawing.Point(132, 106)
        Me.lvlYearlevel.Name = "lvlYearlevel"
        Me.lvlYearlevel.Size = New System.Drawing.Size(97, 19)
        Me.lvlYearlevel.TabIndex = 4
        Me.lvlYearlevel.Text = "YEAR LEVEL:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGender.ForeColor = System.Drawing.Color.White
        Me.lblGender.Location = New System.Drawing.Point(144, 186)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(74, 19)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "GENDER:"
        '
        'cmbYearlevel
        '
        Me.cmbYearlevel.BackColor = System.Drawing.Color.White
        Me.cmbYearlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearlevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbYearlevel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbYearlevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbYearlevel.FormattingEnabled = True
        Me.cmbYearlevel.Items.AddRange(New Object() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR"})
        Me.cmbYearlevel.Location = New System.Drawing.Point(148, 203)
        Me.cmbYearlevel.Name = "cmbYearlevel"
        Me.cmbYearlevel.Size = New System.Drawing.Size(200, 29)
        Me.cmbYearlevel.TabIndex = 9
        '
        'rbtnMale
        '
        Me.rbtnMale.AutoSize = True
        Me.rbtnMale.BackColor = System.Drawing.Color.Transparent
        Me.rbtnMale.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbtnMale.ForeColor = System.Drawing.Color.White
        Me.rbtnMale.Location = New System.Drawing.Point(106, 213)
        Me.rbtnMale.Name = "rbtnMale"
        Me.rbtnMale.Size = New System.Drawing.Size(67, 25)
        Me.rbtnMale.TabIndex = 10
        Me.rbtnMale.TabStop = True
        Me.rbtnMale.Text = "Male"
        Me.rbtnMale.UseVisualStyleBackColor = False
        '
        'rbtnFemale
        '
        Me.rbtnFemale.AutoSize = True
        Me.rbtnFemale.BackColor = System.Drawing.Color.Transparent
        Me.rbtnFemale.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbtnFemale.ForeColor = System.Drawing.Color.White
        Me.rbtnFemale.Location = New System.Drawing.Point(179, 213)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(85, 25)
        Me.rbtnFemale.TabIndex = 11
        Me.rbtnFemale.TabStop = True
        Me.rbtnFemale.Text = "Female"
        Me.rbtnFemale.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStart.Location = New System.Drawing.Point(122, 301)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(135, 35)
        Me.btnStart.TabIndex = 12
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(49, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 1)
        Me.Panel1.TabIndex = 14
        '
        'pnlBG
        '
        Me.pnlBG.Controls.Add(Me.Panel3)
        Me.pnlBG.Controls.Add(Me.rbtnFemale)
        Me.pnlBG.Controls.Add(Me.btnStart)
        Me.pnlBG.Controls.Add(Me.rbtnMale)
        Me.pnlBG.Controls.Add(Me.lblName)
        Me.pnlBG.Controls.Add(Me.lvlYearlevel)
        Me.pnlBG.Controls.Add(Me.lblGender)
        Me.pnlBG.Location = New System.Drawing.Point(59, 74)
        Me.pnlBG.Name = "pnlBG"
        Me.pnlBG.Size = New System.Drawing.Size(378, 365)
        Me.pnlBG.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(39, 272)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 1)
        Me.Panel3.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.LabExe4.My.Resources.Resources.imgBG4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(501, 465)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbYearlevel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlBG)
        Me.Name = "Form1"
        Me.Text = "HARVY JONES PONTILLAS (DICT 2-2)"
        Me.pnlBG.ResumeLayout(False)
        Me.pnlBG.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lvlYearlevel As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents cmbYearlevel As ComboBox
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents btnStart As Button
    Friend WithEvents pnlBG As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
End Class
