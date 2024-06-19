<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtemail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(txtemail))
        txtName = New TextBox()
        txtgmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        lblStopwatch = New Label()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        resources.ApplyResources(txtName, "txtName")
        txtName.Name = "txtName"
        ' 
        ' txtgmail
        ' 
        resources.ApplyResources(txtgmail, "txtgmail")
        txtgmail.Name = "txtgmail"
        ' 
        ' txtPhone
        ' 
        resources.ApplyResources(txtPhone, "txtPhone")
        txtPhone.Name = "txtPhone"
        ' 
        ' txtGithubLink
        ' 
        resources.ApplyResources(txtGithubLink, "txtGithubLink")
        txtGithubLink.Name = "txtGithubLink"
        ' 
        ' lblStopwatch
        ' 
        resources.ApplyResources(lblStopwatch, "lblStopwatch")
        lblStopwatch.Name = "lblStopwatch"
        ' 
        ' btnToggleStopwatch
        ' 
        resources.ApplyResources(btnToggleStopwatch, "btnToggleStopwatch")
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        resources.ApplyResources(btnSubmit, "btnSubmit")
        btnSubmit.Name = "btnSubmit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' txtemail
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(lblStopwatch)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtgmail)
        Controls.Add(txtName)
        Name = "txtemail"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtgmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Submission successful!")
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
