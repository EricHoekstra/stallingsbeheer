Imports System.IO
Imports Stallingsbordjes

Public Class Stap2Form
    Private Bordjes As Bordjes
    Private Sub Stap2UitvoerForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim uitvoerbestand As String = Path.ChangeExtension(My.Forms.Stap1Form.FileNameTextbox.Text, "html")
        FileNameTextbox.Text = uitvoerbestand
        BordjesSaveFileDialog.FileName = uitvoerbestand
    End Sub
    Private Sub Stap2UitvoerForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim regels As String() = My.Forms.Stap1Form.PreviewRichtTextBox.Lines
        Bordjes = New Bordjes(regels)
        ExceptionsRichtTextBox.Lines = Bordjes.Bestand.OnverwerkteRegels.ToArray()
    End Sub
    Private Sub SelectFileButton_Click(sender As Object, e As EventArgs) Handles SelectFileButton.Click
        If BordjesSaveFileDialog.ShowDialog() = DialogResult.OK Then
            FileNameTextbox.Text = BordjesSaveFileDialog.FileName
        End If
    End Sub
    Private Sub FileNameTextbox_TextChanged(sender As Object, e As EventArgs) Handles FileNameTextbox.TextChanged
        NextButton.Enabled = FileNameTextbox.Text.Length > 0
    End Sub
    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        My.Forms.Stap1Form.Top = Me.Top
        My.Forms.Stap1Form.Left = Me.Left
        My.Forms.Stap1Form.Show()
        Me.Hide()
    End Sub
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        ' Bordjes opslaan
        System.IO.File.WriteAllText(FileNameTextbox.Text, Me.Bordjes.ToHtml())
        ' Venster 3 openen.
        My.Forms.Stap3Form.Top = Me.Top
        My.Forms.Stap3Form.Left = Me.Left
        My.Forms.Stap3Form.Show()
        Me.Hide()
    End Sub
End Class