Imports System.IO

Public Class Form1
    Dim filePath As String = "sample.txt" ' File Location
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Try
            Dim number As Integer = txtInput.Text
            Using writer As New StreamWriter(filePath, True)
                writer.WriteLine(number)
            End Using
            txtInput.Clear()
            MessageBox.Show($"Number '{number}' saved to {filePath}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        lstSortedNumber.Items.Clear()

        Using reader As New StreamReader(filePath)
            Dim line As String
            line = reader.ReadLine()
            While (line IsNot Nothing)
                lstSortedNumber.Items.Add(line)
                line = reader.ReadLine()
            End While
        End Using

    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        lstSortedNumber.Items.Clear()

        Dim numbersList As New List(Of Double)

        Using sr As New StreamReader(filePath)
            Dim line As String
            While Not sr.EndOfStream
                line = sr.ReadLine()
                If Double.TryParse(line, Nothing) Then
                    numbersList.Add(Double.Parse(line))
                End If
            End While
        End Using
        Dim sortedNumbers = numbersList.OrderBy(Function(n) n) 
        For Each number As Double In sortedNumbers
            lstSortedNumber.Items.Add(number)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            Using writer As New StreamWriter(filePath, False)
            End Using
            lstSortedNumber.Items.Clear()
            MessageBox.Show($"Data in {filePath} has been cleared.", "File Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error clearing file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
