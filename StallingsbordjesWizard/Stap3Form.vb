Public Class Stap3Form
    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        My.Forms.Stap2Form.Top = Me.Top
        My.Forms.Stap2Form.Left = Me.Left
        My.Forms.Stap2Form.Show()
        Me.Hide()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub Stap3Form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        FileNameLinkLabel.Text = My.Forms.Stap2Form.FileNameTextbox.Text
    End Sub

    Private Sub FileNameLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FileNameLinkLabel.LinkClicked
        Process.Start("explorer.exe", FileNameLinkLabel.Text)
    End Sub
End Class