Public Class helpform
    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHelp.Multiline = True
        txtHelp.ScrollBars = ScrollBars.Vertical
        txtHelp.ReadOnly = True
        txtHelp.Text =
        "Compile/Upload" & vbCrLf &
        "--------------" & vbCrLf &
        "Compile source: Compile loaded source-code" & vbCrLf &
        "Upload hex: Upload executable file (.hex) to Arduino" & vbCrLf & vbCrLf &
        "Configure Bricks" & vbCrLf &
        "----------------" & vbCrLf &
        "Register Unit: Load source-code for Register Unit" & vbCrLf &
        "Control Unit: Load source-code for Control Unit" & vbCrLf &
        "ALU Unit: Load source - code for ALU Unit" & vbCrLf &
        "Memory Unit: Load source-code for Memory Unit" & vbCrLf &
        "Prog. Counter: Load source-code for Program Counter" & vbCrLf & vbCrLf &
        "Other" & vbCrLf &
        "-----" & vbCrLf &
        "Help: display this window" & vbCrLf &
        "CMD: Open command prompt" & vbCrLf &
        "PowerShell: Open PowerShell" & vbCrLf &
        "Advanced Users: Download tools & libraries" & vbCrLf & vbCrLf &
        "Auto Develop Program: Open memory manipulation window" & vbCrLf & vbCrLf &
         "Files" & vbCrLf &
        "-----" & vbCrLf &
        "Open: Open a file" & vbCrLf &
        "Save: Save a file" & vbCrLf &
        "Create: Create a new file" & vbCrLf &
        "Save as: Save in a new file" & vbCrLf & vbCrLf &
        "Serial Communication" & vbCrLf &
        "--------------------" & vbCrLf &
        "USB port: set COM port for Arduino communication" & vbCrLf &
        "Refresh Port: refresh port list (Detect connected Arduino and update port list)" & vbCrLf & vbCrLf &
        "Reset" & vbCrLf &
        "-----" & vbCrLf &
        "Reset predeveloped programs to their default state (version)" & vbCrLf & vbCrLf &
        "Serial ON/OFF: activate serial port for receiving data from Arduino" & vbCrLf & vbCrLf &
        "ver.22APR25-22.46"


        txtHelp.Font = New Font(txtHelp.Font.FontFamily, 14)






        txtHelp.SelectionStart = txtHelp.Text.IndexOf("Compile/Upload")
        txtHelp.SelectionLength = "Compile/Upload".Length
        txtHelp.SelectionFont = New Font(txtHelp.Font, FontStyle.Bold)
        'txtHelp.SelectionColor = Color.Red

        txtHelp.SelectionStart = txtHelp.Text.IndexOf("Configure Bricks")
        txtHelp.SelectionLength = "Configure Bricks".Length
        txtHelp.SelectionFont = New Font(txtHelp.Font, FontStyle.Bold)
        'txtHelp.SelectionColor = Color.Red

        txtHelp.SelectionStart = txtHelp.Text.IndexOf("Other")
        txtHelp.SelectionLength = "Other".Length
        txtHelp.SelectionFont = New Font(txtHelp.Font, FontStyle.Bold)
        'txtHelp.SelectionColor = Color.Red

        txtHelp.SelectionStart = txtHelp.Text.IndexOf("Files")
        txtHelp.SelectionLength = "Files".Length
        txtHelp.SelectionFont = New Font(txtHelp.Font, FontStyle.Bold)
        'txtHelp.SelectionColor = Color.Red


        txtHelp.SelectionStart = txtHelp.Text.IndexOf("Serial Communication")
        txtHelp.SelectionLength = "Serial Communication".Length
        txtHelp.SelectionFont = New Font(txtHelp.Font, FontStyle.Bold)


        txtHelp.SelectionStart = txtHelp.Text.IndexOf("Reset")
        txtHelp.SelectionLength = "Reset".Length
        txtHelp.SelectionFont = New Font(txtHelp.Font, FontStyle.Bold)


        txtHelp.SelectionStart = txtHelp.Text.IndexOf("Serial ON/OFF")
        txtHelp.SelectionLength = "Serial ON/OFF".Length
        txtHelp.SelectionFont = New Font(txtHelp.Font, FontStyle.Bold)



        txtHelp.SelectionStart = txtHelp.Text.IndexOf("Auto Develop Program")
        txtHelp.SelectionLength = "Auto Develop Program".Length
        txtHelp.SelectionFont = New Font(txtHelp.Font, FontStyle.Bold)

        txtHelp.SelectionStart = 0  ' Μετακινεί τον κέρσορα στην αρχή
        txtHelp.SelectionLength = 0 ' Αφαιρεί την επιλογή κειμένου
        txtHelp.BackColor = Color.FromArgb(240, 240, 200)


    End Sub
End Class