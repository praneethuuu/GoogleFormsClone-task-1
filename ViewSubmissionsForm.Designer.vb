<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        lblStopwatchTime = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(156, 68)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(156, 113)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.MaximumSize = New Size(1000, 10000)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(36, 15)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(156, 156)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(88, 15)
        lblPhone.TabIndex = 2
        lblPhone.Text = "Phone Number"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(156, 203)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(70, 15)
        lblGithubLink.TabIndex = 3
        lblGithubLink.Text = "GitHub Link"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(156, 250)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(92, 15)
        lblStopwatchTime.TabIndex = 4
        lblStopwatchTime.Text = "Stopwatch Time"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(154, 297)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(90, 46)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "Previous (Ctrl+P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(280, 297)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(89, 46)
        btnNext.TabIndex = 6
        btnNext.Text = "Next (Ctrl+N)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
