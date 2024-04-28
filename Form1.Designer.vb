<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        OkButton = New Button()
        EndButton = New Button()
        NumTextBox = New TextBox()
        OutputLabel = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' OkButton
        ' 
        OkButton.BackColor = Color.LimeGreen
        OkButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        OkButton.Location = New Point(100, 102)
        OkButton.Name = "OkButton"
        OkButton.Size = New Size(100, 30)
        OkButton.TabIndex = 0
        OkButton.Text = "OK"
        OkButton.UseVisualStyleBackColor = False
        ' 
        ' EndButton
        ' 
        EndButton.BackColor = Color.IndianRed
        EndButton.Location = New Point(266, 140)
        EndButton.Name = "EndButton"
        EndButton.Size = New Size(77, 29)
        EndButton.TabIndex = 1
        EndButton.Text = "End"
        EndButton.UseVisualStyleBackColor = False
        ' 
        ' NumTextBox
        ' 
        NumTextBox.Location = New Point(100, 63)
        NumTextBox.Multiline = True
        NumTextBox.Name = "NumTextBox"
        NumTextBox.Size = New Size(100, 33)
        NumTextBox.TabIndex = 2
        ' 
        ' OutputLabel
        ' 
        OutputLabel.AutoSize = True
        OutputLabel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        OutputLabel.Location = New Point(242, 65)
        OutputLabel.Name = "OutputLabel"
        OutputLabel.Size = New Size(0, 17)
        OutputLabel.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(5, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 21)
        Label2.TabIndex = 4
        Label2.Text = "Number   :"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(488, 268)
        Controls.Add(Label2)
        Controls.Add(OutputLabel)
        Controls.Add(NumTextBox)
        Controls.Add(EndButton)
        Controls.Add(OkButton)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OkButton As Button
    Friend WithEvents EndButton As Button
    Friend WithEvents NumTextBox As TextBox
    Friend WithEvents OutputLabel As Label
    Friend WithEvents Label2 As Label
End Class
