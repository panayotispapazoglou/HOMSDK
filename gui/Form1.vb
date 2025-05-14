
'*******************************************
'GUI Software
'********************************************
'Low-Cost Plug-n-Play Educational Hardware-Oriented
'Microcomputer Simulator Development Kit (HOMSDK)


'(C) 2025 Panayotis (Panos) Papazoglou
'All rights reserved
'
' URL: panospapazoglou.gr/homsdk
'
'License: CC BY-NC-SA 4.0 
'********************************************/

Imports System.IO

Imports System.Runtime.Intrinsics.X86
Imports System.IO.Ports
Imports Windows.Win32.UI.Input
Imports System.Reflection
Public Class Form1
    Dim comPORT As String
    Dim bootselected As String = "arduino:avr:nano:cpu=atmega328"
    Dim WithEvents SerialPort1 As New SerialPort()

    Dim filePath As String
    Dim filename As String = ""
    Dim filenamepath As String = ""
    Dim fullname As String = ""
    Dim fullhexname = filenamepath & "output.hex"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(0, 0)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        For Each sp As String In System.IO.Ports.SerialPort.GetPortNames()
            ComboBox1.Items.Add(sp)
        Next

        SerialPort1.NewLine = vbLf
        SerialPort1.ReadTimeout = 1000
        SerialPort1.WriteTimeout = 1000

        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf ResolveAssembly

        Me.ControlBox = True

        Me.ShowInTaskbar = True
        Me.TopMost = False
        Me.Opacity = 1

        Me.TransparencyKey = Color.Empty
        Me.BackColor = Color.White

        Me.AutoScaleMode = AutoScaleMode.Dpi


        Dim dpiScale As Double = Me.DeviceDpi / 96.0

        If dpiScale <> 1.0 Then

            Me.Width = CInt(Me.Width * dpiScale)
            Me.Height = CInt(Me.Height * dpiScale)
            ScaleControlsRecursive(Me, dpiScale)
        End If

    End Sub


    Private Sub ScaleControlsRecursive(parent As Control, scaleFactor As Double)
        For Each ctrl As Control In parent.Controls

            ctrl.Font = New Font(ctrl.Font.FontFamily, ctrl.Font.Size * scaleFactor)

            ctrl.Width = CInt(ctrl.Width * scaleFactor)
            ctrl.Height = CInt(ctrl.Height * scaleFactor)
            ctrl.Left = CInt(ctrl.Left * scaleFactor)
            ctrl.Top = CInt(ctrl.Top * scaleFactor)


            If ctrl.HasChildren Then
                ScaleControlsRecursive(ctrl, scaleFactor)
            End If
        Next
    End Sub


    Private Sub vieweditSUB(sender As Object, e As EventArgs)
        MessageBox.Show("View/Edit...")
    End Sub

    Private Sub compileSUB(sender As Object, e As EventArgs)
        MessageBox.Show("Compile...")
    End Sub

    Private Sub uploadSUB(sender As Object, e As EventArgs)
        MessageBox.Show("Upload...")
    End Sub

    Private Sub fillmemorySUB(sender As Object, e As EventArgs)
        MessageBox.Show("Fill memory...")
    End Sub

    Private Sub setupbricksSUB(sender As Object, e As EventArgs)
        MessageBox.Show("Setup bricks...")
    End Sub



    Private Sub arduinocliSUB(sender As Object, e As EventArgs)
        MessageBox.Show("Arduino-CLI...")
    End Sub
    Private Sub cmdSUB(sender As Object, e As EventArgs)
        MessageBox.Show("CMD...")
    End Sub
    Private Sub powershellSUB(sender As Object, e As EventArgs)
        MessageBox.Show("Powershell...")
    End Sub





    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim fr As New Form3()
        Dim centerX As Integer = Me.Location.X + (Me.Width - fr.Width) \ 2
        Dim centerY As Integer = Me.Location.Y + (Me.Height - fr.Height) \ 2

        fr.StartPosition = FormStartPosition.Manual
        fr.Location = New Point(centerX, centerY)

        Me.Enabled = False

        AddHandler fr.FormClosed, Sub(sender2, e2)
                                      Me.Enabled = True
                                      Me.Activate()
                                  End Sub

        fr.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        Dim fr As New conform
        Dim centerX = Location.X + (Width - fr.Width) \ 2
        Dim centerY = Location.Y + (Height - fr.Height) \ 2

        fr.StartPosition = FormStartPosition.Manual
        fr.Location = New Point(centerX, centerY)

        Enabled = False

        AddHandler fr.FormClosed, Sub(sender2, e2)
                                      Enabled = True
                                      Activate()
                                  End Sub

        fr.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        If MessageBox.Show("The Arduino-CLI will be installed in your computer", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
            MessageBox.Show("Installation is canceled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        Dim psi As New ProcessStartInfo
        Dim command As String


        Dim installCommand = "winget install ArduinoSA.CLI -h"
        Dim pauseCommand = "Read-Host \" & "Πατήστε Enter για έξοδο\"


        command = "-NoProfile -ExecutionPolicy Bypass -Command " &
          """Start-Process powershell -Wait -NoNewWindow -ArgumentList '-NoProfile -ExecutionPolicy Bypass -Command & {" &
          installCommand & "; " & pauseCommand & "}'"""


        psi.FileName = "powershell.exe"
        psi.Arguments = command
        psi.UseShellExecute = True


        Process.Start(psi)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim psi As New ProcessStartInfo()
        psi.FileName = "cmd.exe"
        psi.Arguments = "/K"
        psi.UseShellExecute = True
        Process.Start(psi)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim psi As New ProcessStartInfo()
        psi.FileName = "powershell.exe"
        psi.Arguments = "-NoExit"
        psi.UseShellExecute = True
        Process.Start(psi)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)



        Dim fr As New Form2
        Dim centerX = Location.X + (Width - fr.Width) \ 2
        Dim centerY = Location.Y + (Height - fr.Height) \ 2

        fr.StartPosition = FormStartPosition.Manual
        fr.Location = New Point(centerX, centerY)

        Enabled = False

        AddHandler fr.FormClosed, Sub(sender2, e2)
                                      Enabled = True
                                      Activate()
                                  End Sub

        fr.Show()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Dim openFileDialog As New OpenFileDialog

        openFileDialog.Filter = "HEX Files (*.hex)|*.hex"
        openFileDialog.Title = "Επιλέξτε ένα αρχείο HEX"
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)


        If openFileDialog.ShowDialog = DialogResult.OK Then
            Dim selectedFilePath = openFileDialog.FileName

            printf()


            Dim ports = SerialPort.GetPortNames
            Dim portList = String.Join(", ", ports)

            If ports.Length = 0 Then
                MessageBox.Show("no COM ports available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim selectedPort = InputBox("Available ports: " & portList & vbCrLf & "Εισάγετε μια θύρα COM:", "Επιλογή Θύρας COM")
                If ports.Contains(selectedPort) Then
                    MessageBox.Show("Selected port: " & selectedPort)
                Else
                    MessageBox.Show("Not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If


            Dim ardupath = "/C ""C:\Program Files\Arduino CLI\" & "Arduino-cli"""

            Dim psi As New ProcessStartInfo
            psi.FileName = "cmd.exe"
            psi.Arguments = ardupath & " upload -p COM4 --fqbn arduino:avr:uno --input-file " & selectedFilePath & " --verbose & pause"
            Process.Start(psi)
            printf()


        End If




    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Hide()
        Dim f2 As New Form2
        f2.ShowDialog()
        Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click

        Dim fr As New helpform
        Dim centerX = Location.X + (Width - fr.Width) \ 2
        Dim centerY = Location.Y + (Height - fr.Height) \ 2

        fr.StartPosition = FormStartPosition.Manual
        fr.Location = New Point(centerX, centerY)

        Enabled = False

        AddHandler fr.FormClosed, Sub(sender2, e2)
                                      Enabled = True
                                      Activate()
                                  End Sub

        fr.Show()


    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        Hide()
        Dim fv As New viewform
        fv.ShowDialog()
        Show()
    End Sub


    Private Function ResolveAssembly(sender As Object, args As ResolveEventArgs) As Assembly
        Dim currentPath As String = AppDomain.CurrentDomain.BaseDirectory
        Dim assemblyPath As String = System.IO.Path.Combine(currentPath, "System.IO.Ports.dll")

        If System.IO.File.Exists(assemblyPath) Then
            Return Assembly.LoadFrom(assemblyPath)
        End If

        Return Nothing
    End Function

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click



        If filenamepath = "" And filename <> "" Then
            filenamepath = filename.Replace(".ino", "")

        End If
        If (filenamepath <> "" Or filename <> "") Then
            box2dark()
            RichTextBox2.Text = "Please wait..." & vbCrLf & vbCrLf

            Dim ardupath = "/C ""tools\" & "Arduino-cli"""
            Dim psi As String


            psi = "cmd" & ardupath & " compile --fqbn arduino:avr:uno " & filenamepath & "\ --output-dir " & filenamepath & " & pause" '"\output.hex & pause"
            RunCommand(psi)




        Else
            MessageBox.Show("Please select a file to compile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        printf()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        If filename <> "" And filenamepath <> "" And comPORT <> "COM1" Then
            printf()

            box2dark()

            RichTextBox2.Text = "Please wait..." & vbCrLf & vbCrLf
            Dim ardupath = """tools\" & "Arduino-cli"""

            Dim psi = ardupath & " upload -p " & comPORT & " --fqbn arduino:avr:uno --input-file " & filenamepath & filename & ".hex --verbose"

            RunCommand(psi)

            RichTextBox2.AppendText(vbCrLf & vbCrLf & psi)


        Else
            MessageBox.Show("No file to upload! (select file and Compile before uploading) OR COM port not valid (arduino not connected)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub printf()
        RichTextBox2.AppendText(vbCrLf & vbCrLf & "filename:" & filename & vbCrLf & "filenamepath:" & filenamepath & vbCrLf & vbCrLf)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem <> "" Then
            comPORT = ComboBox1.SelectedItem
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ComboBox1.Items.Clear()

        For Each sp As String In System.IO.Ports.SerialPort.GetPortNames()
            ComboBox1.Items.Add(sp)
        Next
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        Dim fr As New adv
        Dim centerX = Location.X + (Width - fr.Width) \ 2
        Dim centerY = Location.Y + (Height - fr.Height) \ 2

        fr.StartPosition = FormStartPosition.Manual
        fr.Location = New Point(centerX, centerY)

        Enabled = False

        AddHandler fr.FormClosed, Sub(sender2, e2)
                                      Enabled = True
                                      Activate()
                                  End Sub

        fr.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        RichTextBox1.BackColor = Color.FromArgb(220, 220, 220)
        RichTextBox1.ForeColor = Color.FromArgb(22, 22, 22)
        filenamepath = "mdk-register\"
        filename = "mdk-register.ino"
        fullhexname = filenamepath & "output.hex"
        fullname = filenamepath & filename
        RichTextBox1.Text = File.ReadAllText(fullname)
        RichTextBox1.ReadOnly = True

        RichTextBox2.Text = "What to change..." & vbCrLf & vbCrLf &
            "#define ADDRESS 1" & vbCrLf &
            "Defines the brick address" & vbCrLf & vbCrLf &
            "#define NAME Reg.A" & vbCrLf &
            "Defines the bricks' symbolic name"

        RichTextBox2.SelectionStart = RichTextBox2.Text.IndexOf("#define ADDRESS")
        RichTextBox2.SelectionLength = "#define ADDRESS".Length
        RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, FontStyle.Bold)
        RichTextBox2.SelectionColor = Color.DarkGreen


        RichTextBox2.SelectionStart = RichTextBox2.Text.IndexOf("#define NAME")
        RichTextBox2.SelectionLength = "#define NAME".Length
        RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, FontStyle.Bold)
        RichTextBox2.SelectionColor = Color.DarkGreen

        RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf("#define ADDRESS")
        RichTextBox1.SelectionLength = "#define ADDRESS".Length
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.SelectionColor = Color.DarkGreen


        RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf("#define NAME")
        RichTextBox1.SelectionLength = "#define NAME".Length
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.SelectionColor = Color.DarkGreen
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        RichTextBox1.BackColor = Color.FromArgb(220, 220, 220)
        RichTextBox1.ForeColor = Color.FromArgb(22, 22, 22)
        filenamepath = "mdk-cu\"
        filename = "mdk-cu.ino"
        fullhexname = filenamepath & "output.hex"
        fullname = filenamepath & filename
        RichTextBox1.Text = File.ReadAllText(fullname)
        RichTextBox1.ReadOnly = True


        RichTextBox2.Text = ""

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        RichTextBox1.BackColor = Color.FromArgb(220, 220, 220)
        RichTextBox1.ForeColor = Color.FromArgb(22, 22, 22)
        filenamepath = "mdk-alu-sr\"
        filename = "mdk-alu-sr.ino"
        fullhexname = filenamepath & "output.hex"
        fullname = filenamepath & filename
        RichTextBox1.Text = File.ReadAllText(fullname)
        RichTextBox1.ReadOnly = True
        RichTextBox2.Text = ""
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        RichTextBox1.BackColor = Color.FromArgb(220, 220, 220)
        RichTextBox1.ForeColor = Color.FromArgb(22, 22, 22)
        filenamepath = "mdk-memory\"
        filename = "mdk-memory.ino"
        fullhexname = filenamepath & "output.hex"
        fullname = filenamepath & filename
        RichTextBox1.Text = File.ReadAllText(fullname)
        RichTextBox1.ReadOnly = True
        RichTextBox2.Text = ""
    End Sub



    Private Async Sub RunCommand(ByVal command As String)
        Dim proc As New Process()
        proc.StartInfo.FileName = "cmd.exe"
        proc.StartInfo.Arguments = "/c " & command
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.RedirectStandardError = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.CreateNoWindow = True



        AddHandler proc.OutputDataReceived, AddressOf OutputHandler
        AddHandler proc.ErrorDataReceived, AddressOf OutputHandler

        proc.Start()
        proc.BeginOutputReadLine()
        proc.BeginErrorReadLine()


        Await Task.Run(Sub() proc.WaitForExit())


    End Sub



    Private Sub OutputHandler(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        If e.Data IsNot Nothing Then
            Invoke(Sub()


                       RichTextBox2.AppendText(e.Data & vbCrLf)


                       If (e.Data.IndexOf("compilation terminated") <> -1) Then

                           RichTextBox2.AppendText("==============================" & vbCrLf)


                       End If

                       If (RichTextBox2.Text.IndexOf("compilation terminated") <> -1) Then
                           RichTextBox2.SelectionStart = RichTextBox2.Text.IndexOf("compilation terminated")
                           RichTextBox2.SelectionLength = "compilation terminated".Length
                           RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, FontStyle.Bold)
                           RichTextBox2.SelectionColor = Color.Orange


                           RichTextBox2.SelectionStart = RichTextBox2.Text.IndexOf("compilation terminated") + RichTextBox2.SelectionLength
                           RichTextBox2.SelectionLength = RichTextBox2.Text.Length - RichTextBox2.SelectionStart
                           RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, FontStyle.Bold)
                           RichTextBox2.SelectionColor = Color.Gray



                       End If






                       RichTextBox2.SelectionStart = RichTextBox2.Text.Length
                       RichTextBox2.ScrollToCaret()
                   End Sub)

        End If
    End Sub


    Private Sub box2light()
        RichTextBox2.BackColor = Color.FromArgb(240, 240, 240)
        RichTextBox2.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub


    Private Sub box2dark()
        RichTextBox2.BackColor = Color.FromArgb(0, 0, 0)
        RichTextBox2.ForeColor = Color.FromArgb(0, 220, 0)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click


        Dim openFile As New OpenFileDialog With {
            .Filter = "Text & INO Files|*.txt;*.ino",
            .Title = "Select file"
        }

        If openFile.ShowDialog = DialogResult.OK Then
            Dim fullPath As String = openFile.FileName
            Dim folderPath As String = Path.GetDirectoryName(fullPath)
            Dim fileNameOnly As String = Path.GetFileName(fullPath)
            filenamepath = folderPath & "\"
            filename = fileNameOnly
            RichTextBox1.Text = File.ReadAllText(fullPath)

            printf()
        End If





        RichTextBox1.BackColor = Color.FromArgb(220, 220, 220)
        RichTextBox1.ForeColor = Color.FromArgb(0, 0, 0)

        RichTextBox1.ReadOnly = False
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

        If filenamepath <> "" And filename <> "" Then

            File.WriteAllText(filenamepath & filename, RichTextBox1.Text)
            MessageBox.Show("File saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        printf()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        filename = ""
        RichTextBox1.ReadOnly = False

        RichTextBox1.BackColor = Color.FromArgb(22, 22, 22)
        RichTextBox1.ForeColor = Color.FromArgb(220, 220, 220)

        RichTextBox1.Text = "void setup()" & vbCrLf &
            "{" & vbCrLf &
            vbTab & "// put your setup code here, to run once:" & vbCrLf &
            "}" & vbCrLf &
            vbCrLf &
            "void loop()" & vbCrLf &
            "{" & vbCrLf &
            vbTab & "// put your main code here, to run repeatedly:" & vbCrLf &
            "}" & vbCrLf



    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click



        Dim saveFile As New SaveFileDialog()
        saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFile.Title = "Save as"
        If saveFile.ShowDialog() = DialogResult.OK Then
            Dim fullFilePath As String = saveFile.FileName
            Dim folderPath As String = Path.Combine(
        Path.GetDirectoryName(fullFilePath),
        Path.GetFileNameWithoutExtension(fullFilePath)
    )


            Directory.CreateDirectory(folderPath)


            Dim newFilePath As String = Path.Combine(folderPath, Path.GetFileName(fullFilePath))


            File.WriteAllText(newFilePath, RichTextBox1.Text)
            filename = saveFile.FileName


            printf()
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim result As DialogResult = MessageBox.Show("This action will reset file MDK-REGISTER.INO to default!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                File.Copy("reset/mdk-register/mdk-register.ino", "mdk-register/mdk-register.ino", True)
                MessageBox.Show("Reset done!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Reset canceled!")
        End If
    End Sub

    Private Sub Button8_Click_2(sender As Object, e As EventArgs) Handles Button8.Click
        Dim result As DialogResult = MessageBox.Show("This action will reset MDK-CU.INO file to default!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                File.Copy("reset/mdk-cu/mdk-cu.ino", "mdk-cu/mdk-cu.ino", True)
                MessageBox.Show("Reset done!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Reset canceled!")
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim result As DialogResult = MessageBox.Show("This action will reset MDK-ALU-SR.INO file to default!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                File.Copy("reset/mdk-alu-sr/mdk-alu-sr.ino", "mdk-alu-sr/mdk-alu-sr.ino", True)
                MessageBox.Show("Reset done!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Reset canceled!")
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim result = MessageBox.Show("This action will reset MDK-MEMORY.INO file to default!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                File.Copy("reset/mdk-memory/mdk-memory.ino", "mdk-memory/mdk-memory.ino", True)
                MessageBox.Show("Reset done!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Reset canceled!")
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

        Try
            SerialPort1.PortName = comPORT
            SerialPort1.BaudRate = 9600
            SerialPort1.NewLine = vbLf
            SerialPort1.Open()
            Label5.Text = "ON"
            Label5.ForeColor = Color.LightGreen


        Catch ex As Exception
        End Try
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim line As String = SerialPort1.ReadLine()
            AppendTextToRichTextBoxSafe(line & vbCrLf)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AppendTextToRichTextBoxSafe(text As String)
        If RichTextBox2.InvokeRequired Then
            RichTextBox2.Invoke(New Action(Of String)(AddressOf AppendTextToRichTextBoxSafe), text)
        Else
            RichTextBox2.AppendText(text & vbCrLf & vbCrLf)
            RichTextBox2.SelectionStart = RichTextBox2.TextLength
            RichTextBox2.ScrollToCaret()
        End If
    End Sub


    Private Sub AppendTextToRichTextBox(text As String)
        If RichTextBox2.InvokeRequired Then
            RichTextBox2.Invoke(Sub() AppendTextToRichTextBox(text))
        Else
            RichTextBox2.AppendText(text & vbCrLf)
            RichTextBox2.SelectionStart = RichTextBox2.TextLength
            RichTextBox2.ScrollToCaret()
        End If
    End Sub






    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Try

            SerialPort1.Close()
            Label5.Text = "OFF"
            Label5.ForeColor = Color.Red
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        RichTextBox1.ReadOnly = False
        RichTextBox1.BackColor = Color.FromArgb(51, 51, 51)
        RichTextBox1.ForeColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        RichTextBox1.BackColor = Color.FromArgb(220, 220, 220)
        RichTextBox1.ForeColor = Color.FromArgb(22, 22, 22)
        filenamepath = "mdk-pc\"
        filename = "mdk-pc.ino"
        fullhexname = filenamepath & "output.hex"
        fullname = filenamepath & filename
        RichTextBox1.Text = File.ReadAllText(fullname)
        RichTextBox1.ReadOnly = True

        RichTextBox2.Text = "What to change..." & vbCrLf & vbCrLf &
            "#define ADDRESS 4" & vbCrLf &
            "Defines the brick address" & vbCrLf & vbCrLf &
            "#define NAME PC" & vbCrLf &
            "Defines the bricks' symbolic name"

        RichTextBox2.SelectionStart = RichTextBox2.Text.IndexOf("#define ADDRESS")
        RichTextBox2.SelectionLength = "#define ADDRESS".Length
        RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, FontStyle.Bold)
        RichTextBox2.SelectionColor = Color.DarkGreen


        RichTextBox2.SelectionStart = RichTextBox2.Text.IndexOf("#define NAME")
        RichTextBox2.SelectionLength = "#define NAME".Length
        RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, FontStyle.Bold)
        RichTextBox2.SelectionColor = Color.DarkGreen

        RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf("#define ADDRESS")
        RichTextBox1.SelectionLength = "#define ADDRESS".Length
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.SelectionColor = Color.DarkGreen


        RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf("#define NAME")
        RichTextBox1.SelectionLength = "#define NAME".Length
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.SelectionColor = Color.DarkGreen
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim result = MessageBox.Show("This action will reset MDK-PC.INO file to default!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                File.Copy("reset/mdk-pc/mdk-pc.ino", "mdk-pc/mdk-pc.ino", True)
                MessageBox.Show("Reset done!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Reset canceled!")
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        box2dark()
        RichTextBox2.Text = "Please wait..." & vbCrLf & vbCrLf
        Dim ardupath = """tools\" & "Arduino-cli"""
        Dim psi = ardupath & " upload -p " & comPORT & " --fqbn arduino:avr:uno --input-file empty\empty.ino.hex --verbose"
        RunCommand(psi)
    End Sub
End Class


