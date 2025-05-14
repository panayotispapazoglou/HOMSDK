Imports System.IO
Public Class conform
    Dim comPORT As String
    Dim filename As String = ""
    Dim filenamepath As String = ""
    Dim fullname As String = ""
    Dim fullhexname = filenamepath & "output.hex"




    Private Sub Conform_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MessageBox.Show("Το Form2 Load εκτελείται!")
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = True


        For Each sp As String In System.IO.Ports.SerialPort.GetPortNames()
            ComboBox1.Items.Add(sp)
        Next



    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


        'Dim FP As String = ""
        'Dim folderDialog As New FolderBrowserDialog()
        'If folderDialog.ShowDialog() = DialogResult.OK Then
        ' Dim selectedFolderPath As String = folderDialog.SelectedPath
        ' FP = selectedFolderPath
        ' End If
        If (filenamepath = "") Then
            MessageBox.Show("Error: Load a Templete first!")
        Else

            Dim ardupath As String = "/C ""C:\Program Files\Arduino CLI\" & "Arduino-cli"""

            Dim psi As New ProcessStartInfo()
            psi.FileName = "cmd.exe"
            Dim filename1 As String = filename & "output.hex"
            'psi.Arguments = ardupath & " compile --fqbn arduino:avr:uno " & filenamepath & "\ --output-dir " & filenamepath & filename1 & " & pause"
            psi.Arguments = ardupath & " compile --fqbn arduino:avr:uno " & filenamepath & "\ --output-dir " & filenamepath & " & pause"
            Process.Start(psi)

        End If


        'Me.Hide() ' Κρύβει το Form1 αλλά δεν το κλείνει
        'Dim f2 As New Form2()
        'f2.StartPosition = FormStartPosition.Manual
        'f2.Location = New Point(Me.Right + 10, Me.Top) ' Ακριβώς δίπλα στην κύρια φόρμα
        'f2.ShowDialog() ' Εμφανίζει το Form2 ως modal
        'Me.Show() ' Όταν κλείσει το Form2, εμφανίζεται ξανά το Form1

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim ardupath As String = "/C ""C:\Program Files\Arduino CLI\" & "Arduino-cli"""

        Dim psi As New ProcessStartInfo()
        psi.FileName = "cmd.exe"
        psi.Arguments = ardupath & " upload -p " & comPORT & " --fqbn arduino:avr:uno --input-file " & filenamepath & filename & ".hex --verbose & pause"
        Process.Start(psi)
















        'Me.Hide() ' Κρύβει το Form1 αλλά δεν το κλείνει
        'Dim f2 As New Form2()
        'f2.StartPosition = FormStartPosition.Manual
        'f2.Location = New Point(Me.Right + 10, Me.Top) ' Ακριβώς δίπλα στην κύρια φόρμα
        'f2.ShowDialog() ' Εμφανίζει το Form2 ως modal
        'Me.Show() ' Όταν κλείσει το Form2, εμφανίζεται ξανά το Form1

    End Sub

    'register template
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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

    'enable edit
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RichTextBox1.BackColor = Color.FromArgb(22, 22, 22)
        RichTextBox1.ForeColor = Color.FromArgb(220, 220, 220)
        RichTextBox1.ReadOnly = False
    End Sub

    'save on template
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (filename <> "") Then
            File.WriteAllText(filenamepath & filename, RichTextBox1.Text) ' Αντικατάσταση αρχείου
            MessageBox.Show("File " & filename & " saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("File not specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim saveFile As New SaveFileDialog With {
      .Filter = "Text Files|*.txt|All Files|*.*",
      .Title = "Save as"
  }

        ' Εμφάνιση διαλόγου και αποθήκευση αν ο χρήστης πατήσει "OK"
        If saveFile.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(saveFile.FileName, RichTextBox1.Text)
            MessageBox.Show("File saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedItem <> "") Then
            comPORT = ComboBox1.SelectedItem
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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


End Class