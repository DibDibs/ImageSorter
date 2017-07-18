<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sort
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
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.FwdBtn = New System.Windows.Forms.Button()
        Me.PathLabel = New System.Windows.Forms.Label()
        Me.ImageDisplay = New System.Windows.Forms.PictureBox()
        Me.DuplicateCheckBox = New System.Windows.Forms.CheckBox()
        Me.FinishBtn = New System.Windows.Forms.Button()
        Me.ImageNumberLabel = New System.Windows.Forms.Label()
        CType(Me.ImageDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackBtn.Enabled = False
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BackBtn.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.BackBtn.Location = New System.Drawing.Point(12, 12)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(184, 480)
        Me.BackBtn.TabIndex = 1
        Me.BackBtn.TabStop = False
        Me.BackBtn.Text = "<<"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'FwdBtn
        '
        Me.FwdBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FwdBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FwdBtn.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.FwdBtn.Location = New System.Drawing.Point(1068, 12)
        Me.FwdBtn.Name = "FwdBtn"
        Me.FwdBtn.Size = New System.Drawing.Size(184, 480)
        Me.FwdBtn.TabIndex = 2
        Me.FwdBtn.TabStop = False
        Me.FwdBtn.Text = ">>"
        Me.FwdBtn.UseVisualStyleBackColor = True
        '
        'PathLabel
        '
        Me.PathLabel.AutoSize = True
        Me.PathLabel.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.PathLabel.Location = New System.Drawing.Point(595, 495)
        Me.PathLabel.Name = "PathLabel"
        Me.PathLabel.Size = New System.Drawing.Size(36, 15)
        Me.PathLabel.TabIndex = 3
        Me.PathLabel.Text = "PATH"
        '
        'ImageDisplay
        '
        Me.ImageDisplay.ImageLocation = ""
        Me.ImageDisplay.InitialImage = Nothing
        Me.ImageDisplay.Location = New System.Drawing.Point(206, 12)
        Me.ImageDisplay.Name = "ImageDisplay"
        Me.ImageDisplay.Size = New System.Drawing.Size(853, 480)
        Me.ImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageDisplay.TabIndex = 4
        Me.ImageDisplay.TabStop = False
        '
        'DuplicateCheckBox
        '
        Me.DuplicateCheckBox.AutoSize = True
        Me.DuplicateCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DuplicateCheckBox.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.DuplicateCheckBox.Location = New System.Drawing.Point(27, 525)
        Me.DuplicateCheckBox.Name = "DuplicateCheckBox"
        Me.DuplicateCheckBox.Size = New System.Drawing.Size(169, 19)
        Me.DuplicateCheckBox.TabIndex = 5
        Me.DuplicateCheckBox.TabStop = False
        Me.DuplicateCheckBox.Text = "Is this Image a Duplicate?"
        Me.DuplicateCheckBox.UseVisualStyleBackColor = True
        '
        'FinishBtn
        '
        Me.FinishBtn.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.FinishBtn.Location = New System.Drawing.Point(1068, 498)
        Me.FinishBtn.Name = "FinishBtn"
        Me.FinishBtn.Size = New System.Drawing.Size(184, 70)
        Me.FinishBtn.TabIndex = 6
        Me.FinishBtn.TabStop = False
        Me.FinishBtn.Text = "Finish"
        Me.FinishBtn.UseVisualStyleBackColor = True
        '
        'ImageNumberLabel
        '
        Me.ImageNumberLabel.AutoSize = True
        Me.ImageNumberLabel.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.ImageNumberLabel.Location = New System.Drawing.Point(579, 525)
        Me.ImageNumberLabel.Name = "ImageNumberLabel"
        Me.ImageNumberLabel.Size = New System.Drawing.Size(68, 15)
        Me.ImageNumberLabel.TabIndex = 7
        Me.ImageNumberLabel.Text = "Image 0 / 0"
        '
        'Sort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.ImageNumberLabel)
        Me.Controls.Add(Me.FinishBtn)
        Me.Controls.Add(Me.DuplicateCheckBox)
        Me.Controls.Add(Me.ImageDisplay)
        Me.Controls.Add(Me.PathLabel)
        Me.Controls.Add(Me.FwdBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.KeyPreview = True
        Me.Name = "Sort"
        Me.Text = "ImageSorter - Sort"
        CType(Me.ImageDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackBtn As Button
    Friend WithEvents FwdBtn As Button
    Friend WithEvents PathLabel As Label
    Friend WithEvents ImageDisplay As PictureBox
    Friend WithEvents DuplicateCheckBox As CheckBox
    Friend WithEvents FinishBtn As Button
    Friend WithEvents ImageNumberLabel As Label
End Class
