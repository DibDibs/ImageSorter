Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Module Util
    Public imageRegex As New Regex("(.JPG|.PNG|.GIF)$", RegexOptions.IgnoreCase)
    Public Sub CenterObjectInX(ByVal obj As Object)
        'Define Procedure to Center an Object in the X axis.
        Try
            'Start a Try-Catch block, in case the object provided is not compatible.
            Dim parent As New Form
            'Set parent variable, which will act as the top-level parent (the form) for the object provided.

            While True
                'Start a while loop to ensure the top parent is selected.
                Try
                    parent = obj.Parent
                    GoTo GotForm
                Catch ex As Exception
                    Debug.WriteLine(ex)
                End Try
            End While

GotForm:
            Dim formWidth As Integer = parent.Width()
            Dim objWidth As Integer = obj.Width()
            Dim newObjPos As Integer = CInt((formWidth / 2) - (objWidth / 2))

            obj.Location = New Point(newObjPos, obj.Location.Y)
            'Calculate new position for object.

        Catch ex As Exception
            Debug.WriteLine(ex)
        End Try
    End Sub

    Public Function getChecksum(ByVal path) As String
        Dim fileBytes() As Byte = File.ReadAllBytes(path)
        Dim hashBytes() As Byte
        Dim hashStr As String
        Dim hashBuilder As New StringBuilder()
        Dim shaHash As New SHA512Managed

        hashBytes = shaHash.ComputeHash(fileBytes)

        For i As Integer = 0 To hashBytes.Length - 1
            hashBuilder.Append(hashBytes(i).ToString("X2"))
        Next

        hashStr = hashBuilder.ToString()

        Return hashStr
    End Function

    Public Sub WriteLineInTextBox(ByVal textBox As RichTextBox, ByVal text As String, Optional ByVal newLine As Boolean = True)
        If (newLine = True) Then
            textBox.Text = textBox.Text & vbCrLf & text

        Else
            textBox.Text = textBox.Text & text
        End If
    End Sub

    Public Function FirstLetterUpper(ByVal str As String) As String
        Dim chars() As Char = str.ToCharArray()

        chars(0) = Char.ToUpper(chars(0))

        str = New String(chars)

        Return str
    End Function
End Module
