<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regform
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        RichTextBox1 = New RichTextBox()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        RichTextBox2 = New RichTextBox()
        Label7 = New Label()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 37)
        Label1.TabIndex = 0
        Label1.Text = "Address"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(137, 97)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 43)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 37)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(137, 169)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(168, 43)
        TextBox2.TabIndex = 3
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(385, 95)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(232, 41)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "INC (reg=reg+1)"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(386, 142)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(231, 41)
        CheckBox2.TabIndex = 5
        CheckBox2.Text = "DEC (reg=reg-1)"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(386, 189)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(262, 41)
        CheckBox3.TabIndex = 6
        CheckBox3.Text = "Shift-R (Shift Right)"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(386, 236)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(240, 41)
        CheckBox4.TabIndex = 7
        CheckBox4.Text = "Shift-L (Shift Left)"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(386, 283)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(99, 41)
        CheckBox5.TabIndex = 8
        CheckBox5.Text = "Reset"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(366, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(297, 252)
        Panel2.TabIndex = 9
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(8, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(319, 147)
        Panel3.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label3.Location = New Point(364, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(312, 37)
        Label3.TabIndex = 11
        Label3.Text = "Additional Instructions"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label4.Location = New Point(8, 6)
        Label4.Name = "Label4"
        Label4.Size = New Size(281, 74)
        Label4.TabIndex = 12
        Label4.Text = "Set Register Address" & vbCrLf & "and Name"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(700, 83)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(459, 252)
        RichTextBox1.TabIndex = 13
        RichTextBox1.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label5.Location = New Point(700, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(288, 37)
        Label5.TabIndex = 14
        Label5.Text = "Auto generated code"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(700, 338)
        Label6.Name = "Label6"
        Label6.Size = New Size(447, 74)
        Label6.TabIndex = 15
        Label6.Text = "rV = received code from other bricks" & vbCrLf & "REG = register content"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlLight
        Button1.Location = New Point(8, 236)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 99)
        Button1.TabIndex = 16
        Button1.Text = "Set Address"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlLight
        Button2.Location = New Point(183, 236)
        Button2.Name = "Button2"
        Button2.Size = New Size(144, 99)
        Button2.TabIndex = 17
        Button2.Text = "Set Name"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(7, 362)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(416, 139)
        RichTextBox2.TabIndex = 18
        RichTextBox2.Text = ""
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label7.Location = New Point(429, 399)
        Label7.Name = "Label7"
        Label7.Size = New Size(219, 74)
        Label7.TabIndex = 19
        Label7.Text = "Auto generated" & vbCrLf & "code"
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ControlLight
        Button3.Location = New Point(710, 421)
        Button3.Name = "Button3"
        Button3.Size = New Size(437, 92)
        Button3.TabIndex = 20
        Button3.Text = "Generate Register .INO file" & vbCrLf & "using current generated code"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Regform
        ' 
        AutoScaleDimensions = New SizeF(15F, 37F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1249, 525)
        Controls.Add(Button3)
        Controls.Add(Label7)
        Controls.Add(RichTextBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(RichTextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Name = "Regform"
        Text = "MDK - Configure Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
End Class
