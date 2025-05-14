<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class helpform
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
        txtHelp = New RichTextBox()
        SuspendLayout()
        ' 
        ' txtHelp
        ' 
        txtHelp.Location = New Point(6, 6)
        txtHelp.Margin = New Padding(2, 2, 2, 2)
        txtHelp.Name = "txtHelp"
        txtHelp.Size = New Size(1260, 515)
        txtHelp.TabIndex = 0
        txtHelp.Text = ""
        ' 
        ' helpform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1271, 527)
        Controls.Add(txtHelp)
        Margin = New Padding(2, 2, 2, 2)
        Name = "helpform"
        Text = "MDK - HELP - Panos Papazoglou"
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtHelp As RichTextBox
End Class
