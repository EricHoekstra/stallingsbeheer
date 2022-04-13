<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stap1Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stap1Form))
        Me.SelectFileButton = New System.Windows.Forms.Button()
        Me.FileNameTextbox = New System.Windows.Forms.TextBox()
        Me.PreviewRichtTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.StallingsbordjesCsvOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'SelectFileButton
        '
        Me.SelectFileButton.Location = New System.Drawing.Point(12, 12)
        Me.SelectFileButton.Name = "SelectFileButton"
        Me.SelectFileButton.Size = New System.Drawing.Size(75, 23)
        Me.SelectFileButton.TabIndex = 0
        Me.SelectFileButton.Text = "Bestand ..."
        Me.SelectFileButton.UseVisualStyleBackColor = True
        '
        'FileNameTextbox
        '
        Me.FileNameTextbox.Location = New System.Drawing.Point(93, 13)
        Me.FileNameTextbox.Name = "FileNameTextbox"
        Me.FileNameTextbox.Size = New System.Drawing.Size(679, 23)
        Me.FileNameTextbox.TabIndex = 1
        '
        'PreviewRichtTextBox
        '
        Me.PreviewRichtTextBox.Location = New System.Drawing.Point(12, 56)
        Me.PreviewRichtTextBox.Name = "PreviewRichtTextBox"
        Me.PreviewRichtTextBox.Size = New System.Drawing.Size(760, 264)
        Me.PreviewRichtTextBox.TabIndex = 2
        Me.PreviewRichtTextBox.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kies een bestand en controleer de opmaak van het bestand."
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(12, 326)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 4
        Me.CancelButton.Text = "Annuleren"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Enabled = False
        Me.NextButton.Location = New System.Drawing.Point(697, 326)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 5
        Me.NextButton.Text = "Volgende"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'StallingsbordjesCsvOpenFileDialog
        '
        Me.StallingsbordjesCsvOpenFileDialog.Filter = "CSV-files|*.csv"
        '
        'Stap1Form
        '
        Me.AcceptButton = Me.NextButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PreviewRichtTextBox)
        Me.Controls.Add(Me.FileNameTextbox)
        Me.Controls.Add(Me.SelectFileButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Stap1Form"
        Me.Text = "Stap 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SelectFileButton As Button
    Friend WithEvents FileNameTextbox As TextBox
    Friend WithEvents PreviewRichtTextBox As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents StallingsbordjesCsvOpenFileDialog As OpenFileDialog
End Class
