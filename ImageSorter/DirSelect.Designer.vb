<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DirSelect
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
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.BrowseBtn = New System.Windows.Forms.Button()
        Me.SelectedFolderLabel = New System.Windows.Forms.Label()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.Location = New System.Drawing.Point(134, 9)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(231, 23)
        Me.WelcomeLabel.TabIndex = 0
        Me.WelcomeLabel.Text = "Welcome to ImageSorter"
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.InfoLabel.Location = New System.Drawing.Point(113, 32)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(275, 15)
        Me.InfoLabel.TabIndex = 1
        Me.InfoLabel.Text = "Please Select the Folder Containing your Images"
        '
        'BrowseBtn
        '
        Me.BrowseBtn.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.BrowseBtn.Location = New System.Drawing.Point(186, 75)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(110, 35)
        Me.BrowseBtn.TabIndex = 2
        Me.BrowseBtn.Text = "Browse"
        Me.BrowseBtn.UseVisualStyleBackColor = True
        '
        'SelectedFolderLabel
        '
        Me.SelectedFolderLabel.AutoSize = True
        Me.SelectedFolderLabel.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.SelectedFolderLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.SelectedFolderLabel.Location = New System.Drawing.Point(183, 135)
        Me.SelectedFolderLabel.Name = "SelectedFolderLabel"
        Me.SelectedFolderLabel.Size = New System.Drawing.Size(134, 15)
        Me.SelectedFolderLabel.TabIndex = 3
        Me.SelectedFolderLabel.Text = "Selected Folder: NONE"
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Enabled = False
        Me.SubmitBtn.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.SubmitBtn.Location = New System.Drawing.Point(186, 179)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(110, 35)
        Me.SubmitBtn.TabIndex = 4
        Me.SubmitBtn.Text = "Sort"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'DirSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 286)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.SelectedFolderLabel)
        Me.Controls.Add(Me.BrowseBtn)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Name = "DirSelect"
        Me.Text = "ImageSorter - Select Folder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WelcomeLabel As Label
    Friend WithEvents InfoLabel As Label
    Friend WithEvents BrowseBtn As Button
    Friend WithEvents SelectedFolderLabel As Label
    Friend WithEvents SubmitBtn As Button
End Class
