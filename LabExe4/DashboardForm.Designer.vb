<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolstripAnswer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolstripResponse = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolstripExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(607, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripFile
        '
        Me.ToolStripFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolstripAnswer, Me.ToolstripResponse, Me.ToolstripExit})
        Me.ToolStripFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripFile.Name = "ToolStripFile"
        Me.ToolStripFile.Size = New System.Drawing.Size(47, 23)
        Me.ToolStripFile.Text = "File"
        '
        'ToolstripAnswer
        '
        Me.ToolstripAnswer.Name = "ToolstripAnswer"
        Me.ToolstripAnswer.Size = New System.Drawing.Size(274, 24)
        Me.ToolstripAnswer.Text = "Answer Survey Question"
        '
        'ToolstripResponse
        '
        Me.ToolstripResponse.Name = "ToolstripResponse"
        Me.ToolstripResponse.Size = New System.Drawing.Size(274, 24)
        Me.ToolstripResponse.Text = "Show Summary Response"
        '
        'ToolstripExit
        '
        Me.ToolstripExit.Name = "ToolstripExit"
        Me.ToolstripExit.Size = New System.Drawing.Size(274, 24)
        Me.ToolstripExit.Text = "Exit"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.LabExe4.My.Resources.Resources.imgBG4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(607, 341)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripFile As ToolStripMenuItem
    Friend WithEvents ToolstripAnswer As ToolStripMenuItem
    Friend WithEvents ToolstripResponse As ToolStripMenuItem
    Friend WithEvents ToolstripExit As ToolStripMenuItem
End Class
