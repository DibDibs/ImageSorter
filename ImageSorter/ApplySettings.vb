Imports System.IO

Public Class ApplySettings
    Public filesWithDup As New Dictionary(Of Integer, String())
    Public filesWithHashes As New Dictionary(Of Integer, String())
    Dim originalImageFiles As New Dictionary(Of Integer, String())
    Public sortedFiles As New List(Of String)

    Private Sub ApplySettings_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        originalImageFiles = DirSelect.imageFiles

        Dim newFArray() As String
        Dim progress As Integer = 0
        Dim i As Integer = 0
        For Each kvp As KeyValuePair(Of Integer, String()) In originalImageFiles
            newFArray = {
                originalImageFiles(kvp.Key)(0),
                originalImageFiles(kvp.Key)(1),
                Util.getChecksum(originalImageFiles(kvp.Key)(1))
            }

            filesWithHashes(kvp.Key) = newFArray

            i += 1

            progress = (i / originalImageFiles.Count) * 50 'Using 50 because this is half of the process
            'Debug.WriteLine(progress)
            ApplicationProgress.Value = progress
        Next

        Dim hashes As New List(Of String)
        Dim newFArrayDuplicates As New List(Of String)
        i = 0

        For Each kvp As KeyValuePair(Of Integer, String()) In filesWithHashes
            newFArrayDuplicates.AddRange(kvp.Value)

            If (Settings.doChecksum = True) Then
                If (hashes.Contains(kvp.Value(2))) Then
                    If Not (My.Computer.FileSystem.DirectoryExists(DirSelect.dir & "/_duplicates")) Then
                        My.Computer.FileSystem.CreateDirectory(DirSelect.dir & "/_duplicates")
                    End If

                    My.Computer.FileSystem.MoveFile(kvp.Value(1), DirSelect.dir & "/_duplicates/" & kvp.Value(0))
                    newFArrayDuplicates.Add("1")

                Else
                    newFArrayDuplicates.Add("0")
                    hashes.Add(kvp.Value(2))
                End If
            End If

            i += 1

            progress = 50 + (i / originalImageFiles.Count) * 50 'Using 50 because this is half of the process
            ApplicationProgress.Value = progress
        Next

        If (Settings.doChecksum = True) Then

            For Each kvp As KeyValuePair(Of Integer, String()) In filesWithDup
                If (kvp.Value(3) = "1") Then
                    filesWithHashes.Remove(kvp.Key())
                End If
            Next
        End If

        For Each kvp As KeyValuePair(Of Integer, String()) In filesWithHashes
            sortedFiles.Add(kvp.Value(1))
        Next

        If (Settings.sortSettings = 0) Then
            'Sort Alphabetically
            sortedFiles.Sort()

        ElseIf (Settings.sortSettings = 1) Then
            'Sort By Date
            Dim filesWithDate As New Dictionary(Of DateTime, String)
            Dim fDate As Date
            Dim sortedByDate As New Dictionary(Of DateTime, String)
            Dim dates As New List(Of DateTime)

            For j As Integer = 0 To sortedFiles.Count - 1
                fDate = File.GetCreationTime(sortedFiles(j))
                filesWithDate.Add(fDate, sortedFiles(j))
            Next

            For Each kvp As KeyValuePair(Of Date, String) In filesWithDate
                dates.Add(kvp.Key)
            Next

            dates.Sort()

            Dim key As Date
            Dim val As String
            For j As Integer = 0 To dates.Count - 1
                key = dates(j)
                val = filesWithDate(key)

                sortedByDate.Add(key, val)
            Next

            For Each kvp As KeyValuePair(Of Date, String) In sortedByDate
                sortedFiles.Add(kvp.Value)
            Next
        End If
        Me.Hide()
        Sort.Show()
    End Sub
End Class