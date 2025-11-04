Imports System.IO

Public Class Form1
    Dim filePath As String = "sample.txt" ' File Location
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Try
            Using writer As New StreamWriter(filePath, True) ' True to append
                writer.WriteLine("Hello, this is a test file!")
                writer.WriteLine("Second line of the text.")
            End Using

            MessageBox.Show("Data written successfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
