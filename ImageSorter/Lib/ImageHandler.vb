Imports System.IO

Public Class ImageHandler
    Dim display As New PictureBox
    Dim label As New Label
    Dim duplicateBox As New CheckBox

    Public path As String
    Public filename As String

    Public isDuplicate As Boolean

    Public ID As Integer

    Public Sub New(ByVal disp As PictureBox,
                   ByVal label As Label,
                   ByVal duplicateBox As CheckBox)

        Me.display = disp
        Me.label = label
        Me.duplicateBox = duplicateBox
    End Sub

    Public Sub ShowImage(ByVal path As String)
        Me.path = path
        Me.filename = path.Split("\\")(UBound(path.Split("\\")))

        Me.display.ImageLocation = path
        Util.CenterObjectInX(Me.display)

        Me.label.Text = Me.filename
        Util.CenterObjectInX(Me.label)

        Me.duplicateBox.Checked = Me.isDuplicate
    End Sub

    Public Sub Update()
        Me.isDuplicate = Me.duplicateBox.Checked
    End Sub

    Public Sub AssignID(ByVal ID As Integer)
        Me.ID = ID
    End Sub

    Public Shared Function CheckForExisting(ByVal dict As Dictionary(Of Integer, ImageHandler),
                                ByVal idToCheck As Integer,
                                            ByVal Optional pathToCheck As String = Nothing) As Boolean

        For Each kvp As KeyValuePair(Of Integer, ImageHandler) In dict
            If (idToCheck = kvp.Value.ID) Then
                Return True
            End If

            If (pathToCheck IsNot Nothing And kvp.Value.path = pathToCheck) Then
                Return True
            End If
        Next

        Return False
    End Function
End Class
