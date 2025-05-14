<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewform
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
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(8, 167)
        RichTextBox1.Margin = New Padding(2, 2, 2, 2)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(935, 594)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlLight
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.Location = New Point(8, 8)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 45)
        Button1.TabIndex = 1
        Button1.Text = "Open .INO file"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlLight
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.Location = New Point(117, 8)
        Button2.Margin = New Padding(2, 2, 2, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 45)
        Button2.TabIndex = 2
        Button2.Text = "Enable Edit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ControlLight
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button3.Location = New Point(237, 8)
        Button3.Margin = New Padding(2, 2, 2, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(84, 45)
        Button3.TabIndex = 3
        Button3.Text = "Save"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ControlLight
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button4.Location = New Point(334, 11)
        Button4.Margin = New Padding(2, 2, 2, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(107, 42)
        Button4.TabIndex = 4
        Button4.Text = "Create"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ControlLight
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button5.Location = New Point(445, 11)
        Button5.Margin = New Padding(2, 2, 2, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(111, 38)
        Button5.TabIndex = 5
        Button5.Text = "Save as"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' viewform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(954, 782)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "viewform"
        Text = "MDK - View/Edit .INO file"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
