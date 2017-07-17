<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.DuplicateSettingsLabel = New System.Windows.Forms.Label()
        Me.DuplicateSetting = New System.Windows.Forms.ComboBox()
        Me.ChecksumLabel = New System.Windows.Forms.Label()
        Me.ChecksumCheck = New System.Windows.Forms.CheckBox()
        Me.ContinueBtn = New System.Windows.Forms.Button()
        Me.SortSetting = New System.Windows.Forms.ComboBox()
        Me.SortByLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DuplicateSettingsLabel
        '
        Me.DuplicateSettingsLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DuplicateSettingsLabel.AutoSize = True
        Me.DuplicateSettingsLabel.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.DuplicateSettingsLabel.Location = New System.Drawing.Point(23, 28)
        Me.DuplicateSettingsLabel.Name = "DuplicateSettingsLabel"
        Me.DuplicateSettingsLabel.Size = New System.Drawing.Size(162, 15)
        Me.DuplicateSettingsLabel.TabIndex = 0
        Me.DuplicateSettingsLabel.Text = "Duplicate Images should be"
        '
        'DuplicateSetting
        '
        Me.DuplicateSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DuplicateSetting.FormattingEnabled = True
        Me.DuplicateSetting.Items.AddRange(New Object() {"Preserved", "Compressed", "Deleted"})
        Me.DuplicateSetting.Location = New System.Drawing.Point(191, 26)
        Me.DuplicateSetting.Name = "DuplicateSetting"
        Me.DuplicateSetting.Size = New System.Drawing.Size(121, 21)
        Me.DuplicateSetting.TabIndex = 1
        Me.DuplicateSetting.Tag = ""
        '
        'ChecksumLabel
        '
        Me.ChecksumLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChecksumLabel.AutoSize = True
        Me.ChecksumLabel.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.ChecksumLabel.Location = New System.Drawing.Point(23, 86)
        Me.ChecksumLabel.Name = "ChecksumLabel"
        Me.ChecksumLabel.Size = New System.Drawing.Size(160, 15)
        Me.ChecksumLabel.TabIndex = 2
        Me.ChecksumLabel.Text = "Check for Exact Duplicates?"
        '
        'ChecksumCheck
        '
        Me.ChecksumCheck.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChecksumCheck.AutoSize = True
        Me.ChecksumCheck.Location = New System.Drawing.Point(191, 87)
        Me.ChecksumCheck.Name = "ChecksumCheck"
        Me.ChecksumCheck.Size = New System.Drawing.Size(15, 14)
        Me.ChecksumCheck.TabIndex = 3
        Me.ChecksumCheck.UseVisualStyleBackColor = True
        '
        'ContinueBtn
        '
        Me.ContinueBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContinueBtn.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.ContinueBtn.Location = New System.Drawing.Point(45, 202)
        Me.ContinueBtn.Name = "ContinueBtn"
        Me.ContinueBtn.Size = New System.Drawing.Size(110, 35)
        Me.ContinueBtn.TabIndex = 4
        Me.ContinueBtn.Text = "Continue"
        Me.ContinueBtn.UseVisualStyleBackColor = True
        '
        'SortSetting
        '
        Me.SortSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SortSetting.FormattingEnabled = True
        Me.SortSetting.Items.AddRange(New Object() {"Alphabet (A - Z)", "Date (Low - High)"})
        Me.SortSetting.Location = New System.Drawing.Point(191, 142)
        Me.SortSetting.Name = "SortSetting"
        Me.SortSetting.Size = New System.Drawing.Size(121, 21)
        Me.SortSetting.TabIndex = 6
        Me.SortSetting.Tag = ""
        '
        'SortByLabel
        '
        Me.SortByLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SortByLabel.AutoSize = True
        Me.SortByLabel.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.SortByLabel.Location = New System.Drawing.Point(23, 144)
        Me.SortByLabel.Name = "SortByLabel"
        Me.SortByLabel.Size = New System.Drawing.Size(89, 15)
        Me.SortByLabel.TabIndex = 5
        Me.SortByLabel.Text = "Sort Images by"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 355)
        Me.Controls.Add(Me.SortSetting)
        Me.Controls.Add(Me.SortByLabel)
        Me.Controls.Add(Me.ContinueBtn)
        Me.Controls.Add(Me.ChecksumCheck)
        Me.Controls.Add(Me.ChecksumLabel)
        Me.Controls.Add(Me.DuplicateSetting)
        Me.Controls.Add(Me.DuplicateSettingsLabel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(428, 394)
        Me.MinimumSize = New System.Drawing.Size(428, 394)
        Me.Name = "Settings"
        Me.Text = "ImageSorter - Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DuplicateSettingsLabel As Label
    Friend WithEvents ChecksumLabel As Label
    Friend WithEvents ChecksumCheck As CheckBox
    Friend WithEvents DuplicateSetting As ComboBox
    Friend WithEvents ContinueBtn As Button
    Friend WithEvents SortSetting As ComboBox
    Friend WithEvents SortByLabel As Label
End Class
