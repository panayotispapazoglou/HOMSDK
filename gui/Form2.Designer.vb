<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        ComboBox1 = New ComboBox()
        Button6 = New Button()
        Button7 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(348, 355)
        ComboBox1.Margin = New Padding(2, 2, 2, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(89, 46)
        ComboBox1.TabIndex = 1
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.GradientInactiveCaption
        Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), Image)
        Button6.BackgroundImageLayout = ImageLayout.None
        Button6.Font = New Font("Arial", 14F, FontStyle.Bold)
        Button6.ImageAlign = ContentAlignment.TopLeft
        Button6.Location = New Point(12, 98)
        Button6.Name = "Button6"
        Button6.Size = New Size(321, 158)
        Button6.TabIndex = 10
        Button6.Text = "Compile .ino" & vbCrLf
        Button6.TextAlign = ContentAlignment.MiddleRight
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = SystemColors.GradientInactiveCaption
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.BackgroundImageLayout = ImageLayout.None
        Button7.Font = New Font("Arial", 14F, FontStyle.Bold)
        Button7.ImageAlign = ContentAlignment.TopLeft
        Button7.Location = New Point(12, 266)
        Button7.Name = "Button7"
        Button7.Size = New Size(321, 151)
        Button7.TabIndex = 11
        Button7.Text = "Upload .hex"
        Button7.TextAlign = ContentAlignment.MiddleRight
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(348, 277)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 76)
        Label1.TabIndex = 12
        Label1.Text = "Select" & vbCrLf & "COM Port"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkCyan
        Label2.Location = New Point(186, 22)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(413, 51)
        Label2.TabIndex = 13
        Label2.Text = "Compile or Upload"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(796, 510)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(ComboBox1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form2"
        Text = "MDK - Compile/Upload"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
