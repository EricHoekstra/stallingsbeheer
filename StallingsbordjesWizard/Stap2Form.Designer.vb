<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stap2Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stap2Form))
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExceptionsRichtTextBox = New System.Windows.Forms.RichTextBox()
        Me.FileNameTextbox = New System.Windows.Forms.TextBox()
        Me.SelectFileButton = New System.Windows.Forms.Button()
        Me.BordjesSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NextButton
        '
        Me.NextButton.Enabled = False
        Me.NextButton.Location = New System.Drawing.Point(697, 326)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 11
        Me.NextButton.Text = "Volgende"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.Location = New System.Drawing.Point(12, 326)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(75, 23)
        Me.PreviousButton.TabIndex = 10
        Me.PreviousButton.Text = "Vorige"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kies een bestand waarnaar de stallingsbordjes geschreven worden."
        '
        'ExceptionsRichtTextBox
        '
        Me.ExceptionsRichtTextBox.ForeColor = System.Drawing.Color.Red
        Me.ExceptionsRichtTextBox.Location = New System.Drawing.Point(12, 27)
        Me.ExceptionsRichtTextBox.Name = "ExceptionsRichtTextBox"
        Me.ExceptionsRichtTextBox.ReadOnly = True
        Me.ExceptionsRichtTextBox.Size = New System.Drawing.Size(760, 248)
        Me.ExceptionsRichtTextBox.TabIndex = 8
        Me.ExceptionsRichtTextBox.Text = ""
        '
        'FileNameTextbox
        '
        Me.FileNameTextbox.Location = New System.Drawing.Point(93, 297)
        Me.FileNameTextbox.Name = "FileNameTextbox"
        Me.FileNameTextbox.Size = New System.Drawing.Size(679, 23)
        Me.FileNameTextbox.TabIndex = 7
        '
        'SelectFileButton
        '
        Me.SelectFileButton.Location = New System.Drawing.Point(12, 296)
        Me.SelectFileButton.Name = "SelectFileButton"
        Me.SelectFileButton.Size = New System.Drawing.Size(75, 23)
        Me.SelectFileButton.TabIndex = 6
        Me.SelectFileButton.Text = "Bestand ..."
        Me.SelectFileButton.UseVisualStyleBackColor = True
        '
        'BordjesSaveFileDialog
        '
        Me.BordjesSaveFileDialog.Filter = "HTML-file|*.html"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(452, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "De volgende regels konden niet verwerkt worden. Ga terug en corrigeer of acceptee" &
    "r."
        '
        'Stap2Form
        '
        Me.AcceptButton = Me.NextButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.PreviousButton
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExceptionsRichtTextBox)
        Me.Controls.Add(Me.FileNameTextbox)
        Me.Controls.Add(Me.SelectFileButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Stap2Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Stap 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NextButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ExceptionsRichtTextBox As RichTextBox
    Friend WithEvents FileNameTextbox As TextBox
    Friend WithEvents SelectFileButton As Button
    Friend WithEvents BordjesSaveFileDialog As SaveFileDialog
    Friend WithEvents Label2 As Label
End Class
