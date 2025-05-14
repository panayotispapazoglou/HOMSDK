<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adv
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
        RichTextBox2 = New RichTextBox()
        Label3 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        ProgressBar1 = New ProgressBar()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        RichTextBox3 = New RichTextBox()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(45, 58)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(502, 296)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(553, 58)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(533, 296)
        RichTextBox2.TabIndex = 1
        RichTextBox2.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.Location = New Point(96, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(405, 28)
        Label3.TabIndex = 2
        Label3.Text = "Automatic Installation of the Arduino-CLI"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.Location = New Point(644, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 28)
        Label1.TabIndex = 3
        Label1.Text = "Instructions for manual Installation"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(37, 407)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(1049, 31)
        TextBox1.TabIndex = 4
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(37, 568)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(384, 34)
        ProgressBar1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 538)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 25)
        Label4.TabIndex = 6
        Label4.Text = "0%"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(203, 538)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 25)
        Label5.TabIndex = 7
        Label5.Text = "50%"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(389, 538)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 25)
        Label6.TabIndex = 8
        Label6.Text = "100%"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightBlue
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.Location = New Point(37, 459)
        Button1.Name = "Button1"
        Button1.Size = New Size(384, 51)
        Button1.TabIndex = 9
        Button1.Text = "Download Arduino-CLI"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button2.ForeColor = Color.DarkGreen
        Button2.Location = New Point(735, 465)
        Button2.Name = "Button2"
        Button2.Size = New Size(351, 40)
        Button2.TabIndex = 11
        Button2.Text = "Install core arduino:avr"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.BackColor = Color.Black
        RichTextBox3.ForeColor = Color.Silver
        RichTextBox3.Location = New Point(37, 642)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(1049, 144)
        RichTextBox3.TabIndex = 12
        RichTextBox3.Text = ""
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button3.ForeColor = Color.DarkGreen
        Button3.Location = New Point(735, 523)
        Button3.Name = "Button3"
        Button3.Size = New Size(351, 40)
        Button3.TabIndex = 13
        Button3.Text = "Install Adafruit GFX Library"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button4.ForeColor = Color.DarkGreen
        Button4.Location = New Point(735, 581)
        Button4.Name = "Button4"
        Button4.Size = New Size(351, 40)
        Button4.TabIndex = 14
        Button4.Text = "Install Adafruit ST7735"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' adv
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1127, 822)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(RichTextBox3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ProgressBar1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "adv"
        Text = "MDK-Advanced Users"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
