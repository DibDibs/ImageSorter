Imports System.IO
Imports System.IO.Packaging

Public Class Processing
    Private Sub Processing_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim images As Dictionary(Of Integer, ImageHandler) = Sort.images
        Dim img As ImageHandler

        Dim i As Integer = 0
        Dim pos As Integer = 0

        Util.WriteLineInTextBox(ProcessDetails, "Scanning for Duplicates...", False)

        For Each kvp As KeyValuePair(Of Integer, ImageHandler) In images
            img = kvp.Value

            If (img.isDuplicate = True) Then
                Util.WriteLineInTextBox(ProcessDetails, "Duplicate Found: " & img.filename & ".")

                If (My.Computer.FileSystem.DirectoryExists(DirSelect.dir)) Then
                    Util.WriteLineInTextBox(ProcessDetails, "No Duplicates Folder Found." & vbCrLf & "Creating ./_duplicates")
                    My.Computer.FileSystem.CreateDirectory(DirSelect.dir & "/_duplicates")
                End If

                Util.WriteLineInTextBox(ProcessDetails, "Moving Duplicate File " & img.filename & " to Duplicates Folder")
                My.Computer.FileSystem.MoveFile(img.path, DirSelect.dir & "/_duplicates/" & img.filename)
            End If

            pos = (i / images.Count) * 33
            ProcessProgress.Value = pos

            i += 1
        Next

        Dim operation As Integer = Settings.duplicateSettings
        Dim opText As String

        If (operation = 0) Then
            opText = "preserve"

        ElseIf (operation = 1) Then
            opText = "compress"

        ElseIf (operation = 2) Then
            opText = "delete"

        Else
            Throw New Exception("Unknown duplicate operation.")
        End If

        Dim continueOp As Integer = MessageBox.Show("You have chosen to " & Util.FirstLetterUpper(opText) & " Duplicate Files." & vbCrLf & "Continue with this Operation?", "Continue with Duplicate Operation?", MessageBoxButtons.YesNo)

        If (continueOp = MsgBoxResult.No) Then
            'If No
            operation = 0
            opText = "preserve"
        End If

        'Do Operations
        If (operation = 0) Then
            'If preserve
            Util.WriteLineInTextBox(ProcessDetails, "Moved All Duplicates to Duplicates Folder.")

        ElseIf (operation = 1) Then
            'If compress
            Dim duplicateDir As DirectoryInfo = New DirectoryInfo(DirSelect.dir & "/_duplicates")
            Dim files() As FileInfo = duplicateDir.GetFiles()

            If (My.Computer.FileSystem.FileExists(DirSelect.dir & "/_duplicates.zip")) Then
                Util.WriteLineInTextBox(ProcessDetails, "_duplicates.zip Found, Removing it...")
                My.Computer.FileSystem.DeleteFile(DirSelect.dir & "/_duplicates.zip")
            End If

            Dim zip As Package = ZipPackage.Open(DirSelect.dir & "/_duplicates.zip",
                                            IO.FileMode.OpenOrCreate,
                                            IO.FileAccess.ReadWrite)

            Util.WriteLineInTextBox(ProcessDetails, "Compression Started...")

            ProcessProgress.Value = 66

            Dim j As Integer = 0
            pos = 0
            For Each f In files
                Util.WriteLineInTextBox(ProcessDetails, "Compressing File: " & f.Name & ".")
                Dim uriFName As String = f.FullName.Replace(" ", "_")

                Dim zipUri As String = String.Concat("/", IO.Path.GetFileName(uriFName))

                Dim partUri As New Uri(zipUri, UriKind.Relative)

                Dim content As String = Net.Mime.MediaTypeNames.Application.Zip

                Dim pckPart As PackagePart = zip.CreatePart(partUri, content, CompressionOption.Maximum)

                Dim bytes() As Byte = File.ReadAllBytes(f.FullName)

                pckPart.GetStream().Write(bytes, 0, bytes.Length)

                j += 1
                pos = 66 + ((j / Sort.dups) * 33)
                ProcessProgress.Value = pos
            Next

            Util.WriteLineInTextBox(ProcessDetails, "Compression Complete.")
            zip.Close()
            Util.WriteLineInTextBox(ProcessDetails, "Compression Stream Closed." & vbCrLf & "Deleting '_duplicates' Directory.")

            My.Computer.FileSystem.DeleteDirectory(DirSelect.dir & "/_duplicates", FileIO.DeleteDirectoryOption.DeleteAllContents)
            Util.WriteLineInTextBox(ProcessDetails, "Duplicates Folder Deleted.")

        ElseIf (operation = 2) Then
            'If delete
            Util.WriteLineInTextBox(ProcessDetails, "Compression Stream Closed." & vbCrLf & "Deleting '_duplicates' Directory.")

            ProcessProgress.Value = 66

            My.Computer.FileSystem.DeleteDirectory(DirSelect.dir & "/_duplicates", FileIO.DeleteDirectoryOption.DeleteAllContents)
            Util.WriteLineInTextBox(ProcessDetails, "Duplicates Folder Deleted.")

            ProcessProgress.Value = 99
        End If

        ProcessProgress.Value = 100
        Util.WriteLineInTextBox(ProcessDetails, "Done.")

        Dim exitVal As Integer = MessageBox.Show("Operation Complete!", "Complete", MessageBoxButtons.OK)

        If (exitVal = MsgBoxResult.Ok) Then
            'If yes
            Me.Close()
            Application.Exit()
        End If
    End Sub
End Class