Imports System.IO
Imports System.IO.Compression
Imports System.Net.Http

Public Class adv




    Private Sub Adv_Load(sender As Object, e As EventArgs) Handles Me.Load


        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'MessageBox.Show("Το Form2 Load εκτελείται!")
        RichTextBox2.ReadOnly = True
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()

        ProgressBar1.Hide()
        TextBox1.Text = "https://downloads.arduino.cc/arduino-cli/nightly/arduino-cli_nightly-latest_Windows_64bit.zip"
        RichTextBox1.Text =
            "The Arduino-CLI tool is already installed on your system. If you want to install again the tool, press [Download Arduino-CLI] OR follow the instructions for manual installation"

        RichTextBox1.SelectAll()
        RichTextBox1.SelectionFont = New Font(RichTextBox2.Font.FontFamily, 14)
        RichTextBox1.DeselectAll()


        RichTextBox2.Text = "1. Open a browser and download the file arduino-cli_nightly-latest_Windows_64bit.zip from the URL bellow. If the link does not work, use google search to find Arduino-CLI tool." & vbCrLf & vbCrLf &
        "2. After download, unzip the file inside the tools\ folder of your installation." & vbCrLf & vbCrLf &
        "Now the GBLK software uses the latest Arduino-CLI version. The GBLK always uses the folder tools\ for executing the Arduino-CLI"
        RichTextBox2.SelectAll()
        RichTextBox2.SelectionFont = New Font(RichTextBox1.Font.FontFamily, 14)
        RichTextBox2.DeselectAll()

    End Sub


    Private Async Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        ProgressBar1.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        ProgressBar1.Value = 50

        Dim zipUrl As String = "https://downloads.arduino.cc/arduino-cli/nightly/arduino-cli_nightly-latest_Windows_64bit.zip"
        Dim toolsPath As String = Path.Combine(Application.StartupPath, "tools")
        Dim zipPath As String = Path.Combine(toolsPath, "arduino-cli.zip")

        If Not Directory.Exists(toolsPath) Then
            Directory.CreateDirectory(toolsPath)
        End If

        Try
            Using httpClient As New HttpClient()
                Using response As HttpResponseMessage = Await httpClient.GetAsync(zipUrl, HttpCompletionOption.ResponseHeadersRead)
                    response.EnsureSuccessStatusCode()

                    Using remoteStream As Stream = Await response.Content.ReadAsStreamAsync()
                        Using localStream As New FileStream(zipPath, FileMode.Create, FileAccess.Write, FileShare.None)
                            Await remoteStream.CopyToAsync(localStream)
                        End Using
                    End Using
                End Using
            End Using

            ProgressBar1.Value = 100
            MessageBox.Show("Download completed, the unzip process starts...")
            ProgressBar1.Hide()
            Label4.Hide()
            Label5.Hide()
            Label6.Hide()
            ' Αποσυμπίεση του zip
            ZipFile.ExtractToDirectory(zipPath, toolsPath, True)
            MessageBox.Show("Installation completed")

            File.Delete(zipPath)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox3.Text = "Please Wait..." & vbCrLf
        Dim ardupath = """tools\" & "Arduino-cli"""
        Dim psi = ardupath & " core install arduino:avr"
        RunCommand(psi)
    End Sub





    Private Async Sub RunCommand(ByVal command As String)
        Dim proc As New Process()
        proc.StartInfo.FileName = "cmd.exe"
        proc.StartInfo.Arguments = "/c " & command
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.RedirectStandardError = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.CreateNoWindow = True

        ' proc.StartInfo.StandardOutputEncoding = Encoding.Unicode
        'proc.StartInfo.StandardErrorEncoding = Encoding.Unicode


        AddHandler proc.OutputDataReceived, AddressOf OutputHandler
        AddHandler proc.ErrorDataReceived, AddressOf OutputHandler

        proc.Start()
        proc.BeginOutputReadLine()
        proc.BeginErrorReadLine()









        ' Χρησιμοποιούμε Task.Run για να περιμένουμε χωρίς να παγώνει το UI
        Await Task.Run(Sub() proc.WaitForExit())


    End Sub



    Private Sub OutputHandler(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        If e.Data IsNot Nothing Then
            Invoke(Sub()

                       RichTextBox3.AppendText(e.Data & vbCrLf)

                       RichTextBox3.SelectionStart = RichTextBox3.Text.Length
                       RichTextBox3.ScrollToCaret()
                   End Sub)

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox3.Text = "Please Wait..." & vbCrLf
        Dim ardupath = "tools\Arduino-cli"
        Dim psi = ardupath & " lib install ""Adafruit GFX Library"""
        RunCommand(psi)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox3.Text = "Please Wait..." & vbCrLf
        Dim ardupath = "tools\Arduino-cli"
        Dim psi = ardupath & " lib install ""Adafruit ST7735 and ST7789 Library"""
        RunCommand(psi)
    End Sub
End Class