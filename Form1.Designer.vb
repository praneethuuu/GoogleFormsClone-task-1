﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.Location = New Point(117, 77)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(219, 31)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submissions (Ctrl+V)"
        btnViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.Location = New Point(117, 125)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(219, 30)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "Create New Submission (Ctrl+N)"
        btnCreateSubmission.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1096, 496)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        Name = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button

End Class
