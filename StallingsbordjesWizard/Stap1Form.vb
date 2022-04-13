Imports System.IO
Public Class Stap1Form
    Private Sub SelectFileButton_Click(sender As Object, e As EventArgs) Handles SelectFileButton.Click
        If StallingsbordjesCsvOpenFileDialog.ShowDialog() = DialogResult.OK Then
            FileNameTextbox.Text = StallingsbordjesCsvOpenFileDialog.FileName
            PreviewRichtTextBox.Text = File.ReadAllText(StallingsbordjesCsvOpenFileDialog.FileName, System.Text.Encoding.GetEncoding("ISO-8859-1"))
        End If
    End Sub
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        My.Forms.Stap2Form.Top = Me.Top
        My.Forms.Stap2Form.Left = Me.Left
        My.Forms.Stap2Form.Show()
        Me.Hide()
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Application.Exit()
    End Sub
    Private Sub FileNameTextbox_TextChanged(sender As Object, e As EventArgs) Handles FileNameTextbox.TextChanged
        Me.NextButton.Enabled = (New FileInfo(FileNameTextbox.Text)).Exists
    End Sub
End Class
