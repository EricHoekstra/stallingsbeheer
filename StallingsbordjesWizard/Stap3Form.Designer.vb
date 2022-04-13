<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stap3Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stap3Form))
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.FileNameLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(697, 326)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 13
        Me.CloseButton.Text = "Klaar"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.Location = New System.Drawing.Point(12, 326)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(75, 23)
        Me.PreviousButton.TabIndex = 12
        Me.PreviousButton.Text = "Vorige"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'FileNameLinkLabel
        '
        Me.FileNameLinkLabel.AutoSize = True
        Me.FileNameLinkLabel.Location = New System.Drawing.Point(12, 159)
        Me.FileNameLinkLabel.MaximumSize = New System.Drawing.Size(760, 0)
        Me.FileNameLinkLabel.MinimumSize = New System.Drawing.Size(760, 0)
        Me.FileNameLinkLabel.Name = "FileNameLinkLabel"
        Me.FileNameLinkLabel.Size = New System.Drawing.Size(760, 15)
        Me.FileNameLinkLabel.TabIndex = 14
        Me.FileNameLinkLabel.TabStop = True
        Me.FileNameLinkLabel.Text = "(HTML-bordjesbestand openen in default browser)"
        Me.FileNameLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(673, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "De bordjes zijn klaar om afgedrukte te worden. U kunt hiervoor iedere moderne bro" &
    "wser gebruiken. Druk liggend enkelzijdig af."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Stap3Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FileNameLinkLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Stap3Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Stap 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents FileNameLinkLabel As LinkLabel
    Friend WithEvents Label1 As Label
End Class
