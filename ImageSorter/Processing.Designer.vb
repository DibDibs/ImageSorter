<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Processing
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
        Me.ProcessProgress = New System.Windows.Forms.ProgressBar()
        Me.ProcessDetails = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ProcessProgress
        '
        Me.ProcessProgress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProcessProgress.Location = New System.Drawing.Point(12, 12)
        Me.ProcessProgress.Name = "ProcessProgress"
        Me.ProcessProgress.Size = New System.Drawing.Size(360, 23)
        Me.ProcessProgress.TabIndex = 0
        '
        'ProcessDetails
        '
        Me.ProcessDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProcessDetails.Enabled = False
        Me.ProcessDetails.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.ProcessDetails.Location = New System.Drawing.Point(12, 50)
        Me.ProcessDetails.Name = "ProcessDetails"
        Me.ProcessDetails.Size = New System.Drawing.Size(360, 399)
        Me.ProcessDetails.TabIndex = 1
        Me.ProcessDetails.Text = ""
        '
        'Processing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.ProcessDetails)
        Me.Controls.Add(Me.ProcessProgress)
        Me.MaximumSize = New System.Drawing.Size(400, 500)
        Me.MinimumSize = New System.Drawing.Size(400, 500)
        Me.Name = "Processing"
        Me.Text = "ImageSorter - Processing..."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProcessProgress As ProgressBar
    Friend WithEvents ProcessDetails As RichTextBox
End Class
