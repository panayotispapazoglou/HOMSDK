
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System
Imports System.IO.Ports

Public Class Form2

    Dim comPORT As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MessageBox.Show("Το Form2 Load εκτελείται!")


        For Each sp As String In System.IO.Ports.SerialPort.GetPortNames()
            ComboBox1.Items.Add(sp)
        Next



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close

    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedItem <> "") Then
            comPORT = ComboBox1.SelectedItem
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim FP As String = ""
        Dim folderDialog As New FolderBrowserDialog()
        If folderDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedFolderPath As String = folderDialog.SelectedPath
            FP = selectedFolderPath
        End If

        Dim ardupath As String = "/C ""C:\Program Files\Arduino CLI\" & "Arduino-cli"""

        Dim psi As New ProcessStartInfo()
        psi.FileName = "cmd.exe"
        'psi.Arguments = ardupath & " compile --fqbn arduino:avr:uno E:\master-project5\panos-kit\homs3\homs3-software\funtest1\mdk-register-a\ --output-dir E:\master-project5\panos-kit\homs3\homs3-software\funtest1\mdk-register-a\output.hex --verbose & pause"
        psi.Arguments = ardupath & " compile --fqbn arduino:avr:uno " & FP & "\ --output-dir " & FP & "\output.hex & pause"
        Process.Start(psi)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'arduino-cli upload -p COM4 --fqbn arduino:avr:uno --input-file mdk-memory.ino.hex




        Dim openFileDialog As New OpenFileDialog()

        ' Ρύθμιση του διαλόγου επιλογής αρχείου
        openFileDialog.Filter = "HEX Files (*.hex)|*.hex" ' Φιλτράρισμα μόνο για .hex αρχεία
        openFileDialog.Title = "Επιλέξτε ένα αρχείο HEX"
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) ' Προεπιλεγμένος φάκελος

        ' Εμφάνιση του διαλόγου και λήψη του επιλεγμένου αρχείου
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = openFileDialog.FileName
            MessageBox.Show("Selected file : " & selectedFilePath)

            Dim ardupath As String = "/C ""C:\Program Files\Arduino CLI\" & "Arduino-cli"""

            Dim psi As New ProcessStartInfo()
            psi.FileName = "cmd.exe"
            psi.Arguments = ardupath & " upload -p " & comPORT & " --fqbn arduino:avr:uno --input-file " & selectedFilePath & " --verbose & pause"
            Process.Start(psi)
        End If
    End Sub

End Class