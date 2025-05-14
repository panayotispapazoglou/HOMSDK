Imports System.IO
Public Class viewform

    Dim filePath As String


    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.BackColor = Color.FromArgb(220, 220, 220)
        RichTextBox1.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim openFile As New OpenFileDialog With {
            .Filter = "Text & INO Files|*.txt;*.ino",
            .Title = "Select file"
        }

        If openFile.ShowDialog() = DialogResult.OK Then
            filePath = openFile.FileName
            RichTextBox1.Text = File.ReadAllText(filePath)
        End If

        RichTextBox1.BackColor = Color.FromArgb(220, 220, 220)
        RichTextBox1.ForeColor = Color.FromArgb(0, 0, 0)

        RichTextBox1.ReadOnly = True

    End Sub


    Private Sub viewform_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        RichTextBox1.Width = Me.ClientSize.Width - 20 ' 10px περιθώριο αριστερά-δεξιά
        RichTextBox1.Height = Me.ClientSize.Height - 50 ' 25px πάνω-κάτω
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.ReadOnly = False
        RichTextBox1.BackColor = Color.FromArgb(22, 22, 22)
        RichTextBox1.ForeColor = Color.FromArgb(220, 220, 220)

        RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf("void setup()")
        If RichTextBox1.SelectionStart <> -1 Then
            RichTextBox1.SelectionLength = "void setup()".Length
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
            RichTextBox1.SelectionColor = Color.Orange


        End If

        RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf("void loop()")
        If RichTextBox1.SelectionStart <> -1 Then
            RichTextBox1.SelectionLength = "void loop()".Length
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
            RichTextBox1.SelectionColor = Color.Orange
        End If


        'void setup()
        Dim searchText As String = "//"
        Dim startIndex As Integer = 0

        While startIndex < RichTextBox1.TextLength
            ' Εύρεση του "#define" από το σημείο startIndex και μετά
            startIndex = RichTextBox1.Text.IndexOf(searchText, startIndex)

            ' Αν δεν βρεθεί άλλο, σταμάτα τη διαδικασία
            If startIndex = -1 Then Exit While

            ' Εφαρμογή μορφοποίησης
            RichTextBox1.SelectionStart = startIndex
            RichTextBox1.SelectionLength = searchText.Length
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
            RichTextBox1.SelectionColor = Color.LightBlue

            ' Μετακίνηση του startIndex για να συνεχίσει την αναζήτηση
            startIndex += searchText.Length
        End While



        'DEFINE
        searchText = "#define"
        startIndex = 0

        While startIndex < RichTextBox1.TextLength
            ' Εύρεση του "#define" από το σημείο startIndex και μετά
            startIndex = RichTextBox1.Text.IndexOf(searchText, startIndex)

            ' Αν δεν βρεθεί άλλο, σταμάτα τη διαδικασία
            If startIndex = -1 Then Exit While

            ' Εφαρμογή μορφοποίησης
            RichTextBox1.SelectionStart = startIndex
            RichTextBox1.SelectionLength = searchText.Length
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
            RichTextBox1.SelectionColor = Color.LightGreen

            ' Μετακίνηση του startIndex για να συνεχίσει την αναζήτηση
            startIndex += searchText.Length
        End While


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If filePath <> "" Then
            File.WriteAllText(filePath, RichTextBox1.Text) ' Αντικατάσταση αρχείου
            MessageBox.Show("File saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.ReadOnly = False
        RichTextBox1.Text = ""
        RichTextBox1.BackColor = Color.FromArgb(22, 22, 22)
        RichTextBox1.ForeColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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
End Class