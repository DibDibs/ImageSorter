Public Class Sort
    Dim files As New List(Of String)
    Public images As New Dictionary(Of Integer, ImageHandler)
    Dim img As ImageHandler
    Dim n As Integer = 0
    Public dups As Integer

    Private Sub Sort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imgDispXSize As Integer = CInt((2 / 3) * (Me.Size.Width))
        Dim imgDispYSize As Integer = CInt((2 / 3) * (Me.Size.Height))

        ImageDisplay.Size = New Size(imgDispXSize, imgDispYSize)
        Util.CenterObjectInX(ImageDisplay)
        Util.CenterObjectInX(PathLabel)
    End Sub

    Private Sub Sort_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        files = ApplySettings.sortedFiles

        'Load first image
        If (ImageHandler.CheckForExisting(images, n)) Then
            Debug.WriteLine(images(n).isDuplicate)
            img = images(n)

        Else
            img = New ImageHandler(ImageDisplay,
                                   PathLabel,
                                   DuplicateCheckBox)

            img.AssignID(n)
            images.Add(n, img)
        End If

        img.ShowImage(files(n))
    End Sub

    Private Sub Sort_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim imgDispXSize As Integer = CInt((2 / 3) * (Me.Size.Width))
        Dim imgDispYSize As Integer = CInt((2 / 3) * (Me.Size.Height))

        ImageDisplay.Size = New Size(imgDispXSize, imgDispYSize)
        Util.CenterObjectInX(ImageDisplay)
        Util.CenterObjectInX(PathLabel)
    End Sub

    Private Sub FwdBtn_Click(sender As Object, e As EventArgs) Handles FwdBtn.Click
        If (n < files.Count - 1) Then
            n += 1

            If (ImageHandler.CheckForExisting(images, n)) Then
                img = images(n)

            Else
                img = New ImageHandler(ImageDisplay,
                                   PathLabel,
                                   DuplicateCheckBox)

                img.AssignID(n)
                images.Add(n, img)
            End If

            img.ShowImage(files(n))

            BackBtn.Enabled = True

            If (n >= files.Count - 1) Then
                FwdBtn.Enabled = False
            End If
        End If
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        If (n > 0) Then
            n -= 1

            If (ImageHandler.CheckForExisting(images, n)) Then
                Debug.WriteLine(images(n).isDuplicate)
                img = images(n)

            Else
                img = New ImageHandler(ImageDisplay,
                                       PathLabel,
                                       DuplicateCheckBox)

                img.AssignID(n)
                images.Add(n, img)
            End If

            img.ShowImage(files(n))

            FwdBtn.Enabled = True

            If (n < 1) Then
                BackBtn.Enabled = False
            End If
        End If
    End Sub

    Private Sub DuplicateCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles DuplicateCheckBox.CheckedChanged
        img.Update()
    End Sub

    Private Sub Form_KeyPress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Debug.WriteLine(e.KeyCode)
        If (e.KeyCode = Keys.N Or e.KeyCode = Keys.OemPeriod) Then
            Me.FwdBtn_Click(420, EventArgs.Empty)

        ElseIf (e.KeyCode = Keys.B Or e.KeyCode = Keys.Oemcomma) Then
            Me.BackBtn_Click(420, EventArgs.Empty)

        ElseIf (e.KeyCode = Keys.D Or e.KeyCode = Keys.OemQuestion) Then
            DuplicateCheckBox.Checked = Not DuplicateCheckBox.Checked
            img.Update()
        End If
    End Sub

    Private Sub FinishBtn_Click(sender As Object, e As EventArgs) Handles FinishBtn.Click
        Dim total As Integer = files.Count
        dups = 0

        For Each kvp As KeyValuePair(Of Integer, ImageHandler) In images
            If (kvp.Value.isDuplicate = True) Then
                dups += 1
            End If
        Next

        Dim stats As Integer

        If Not (dups = 1) Then
            stats = MessageBox.Show("From " & total & " Images, you have marked " & dups & " as Duplicates." & vbCrLf & "Do you wish to Continue?", "Stats", MessageBoxButtons.OKCancel)

        Else
            stats = MessageBox.Show("From " & total & " Images, you have marked 1 as a Duplicate." & vbCrLf & "Do you wish to Continue?", "Stats", MessageBoxButtons.OKCancel)
        End If

        If (stats = MsgBoxResult.Ok) Then
            'OK pressed, go through images and remove duplicates
            Me.Hide()
            Processing.Show()
        End If
    End Sub
End Class