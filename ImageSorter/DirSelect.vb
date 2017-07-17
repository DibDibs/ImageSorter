Imports System.IO
Imports System.Text.RegularExpressions

Public Class DirSelect
    Public dir As String
    Public filesInDir() As String
    Public imageFiles As New Dictionary(Of Integer, String())

    Private Sub DirSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.CenterObjectInX(WelcomeLabel)
        Util.CenterObjectInX(InfoLabel)
        Util.CenterObjectInX(BrowseBtn)
        Util.CenterObjectInX(SelectedFolderLabel)
        Util.CenterObjectInX(SubmitBtn)
    End Sub

    Private Sub DirSelect_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        Util.CenterObjectInX(WelcomeLabel)
        Util.CenterObjectInX(InfoLabel)
        Util.CenterObjectInX(BrowseBtn)
        Util.CenterObjectInX(SelectedFolderLabel)
        Util.CenterObjectInX(SubmitBtn)
    End Sub

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        Dim dirSelector As New FolderBrowserDialog
        dirSelector.ShowNewFolderButton = True

        imageFiles.Clear()

        If (dirSelector.ShowDialog() = DialogResult.OK) Then
            dir = dirSelector.SelectedPath()
            filesInDir = Directory.GetFiles(dir)

            Dim fname As String
            Dim i As Integer = 0
            For Each f In filesInDir
                fname = f.Split("\\")(UBound(f.Split("\\")))

                If (Util.imageRegex.IsMatch(fname)) Then
                    imageFiles.Add(i, {fname, f})
                    i += 1
                End If
            Next

            SelectedFolderLabel.Text = "Selected Folder: " & dir & " (" & imageFiles.Count & " Images Found)"
            Util.CenterObjectInX(SelectedFolderLabel)

            If (imageFiles.Count > 0) Then
                SelectedFolderLabel.ForeColor = Color.Green
                SubmitBtn.Enabled = True

            Else
                SelectedFolderLabel.ForeColor = Color.DarkRed
                SubmitBtn.Enabled = False
            End If

            dirSelector.Reset()
        End If
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Me.Hide()
        Settings.Show()
    End Sub
End Class