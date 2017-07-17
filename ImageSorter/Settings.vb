Public Class Settings
    Public doChecksum As Boolean
    Public duplicateSettings As Integer '0 = Preserve, 1 = Compress, 2 = Delete
    Public sortSettings As Integer '0 = Alphabet (A-Z), 1 = Alphabet (Z-A), 2 = Date (Low - High), 3 = Date (High - Low)

    Private Sub ContinueBtn_Click(sender As Object, e As EventArgs) Handles ContinueBtn.Click
        doChecksum = ChecksumCheck.Checked

        duplicateSettings = DuplicateSetting.SelectedIndex

        If (ChecksumCheck.Checked = True) Then
            doChecksum = True

        Else
            doChecksum = False
        End If

        sortSettings = SortSetting.SelectedIndex

        Me.Hide()
        ApplySettings.Show()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DuplicateSetting.SelectedIndex = 1
        SortSetting.SelectedIndex = 0
    End Sub
End Class