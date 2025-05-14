Imports System.Diagnostics.Eventing.Reader

Public Class Regform


    Private Sub Regform_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim color1 As Color = Color.LightBlue
        Dim color2 As Color = Color.Black

        Panel2.BorderStyle = BorderStyle.FixedSingle ' Το πλαίσιο είναι με γραμμή
        Panel3.BorderStyle = BorderStyle.FixedSingle ' Το πλαίσιο είναι με γραμμή

        Panel3.BackColor = Color.LightBlue

        Panel2.BackColor = color1
        Panel2.ForeColor = color2

        CheckBox1.BackColor = color1
        CheckBox2.BackColor = color1
        CheckBox3.BackColor = color1
        CheckBox4.BackColor = color1
        CheckBox5.BackColor = color1

        CheckBox1.ForeColor = color2
        CheckBox2.ForeColor = color2
        CheckBox3.ForeColor = color2
        CheckBox4.ForeColor = color2
        CheckBox5.ForeColor = color2


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        RichTextBox1.AppendText(vbCrLf & "if (rV == INC) REG++;")
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        RichTextBox1.AppendText(vbCrLf & "if (rV == DEC) REG--;")
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        RichTextBox1.AppendText(vbCrLf & "if (rV == SHIFT_R) REG = REG >> 1;")
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        RichTextBox1.AppendText(vbCrLf & "if (rV == SHIFT_L) REG = REG << 1;")
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        RichTextBox1.AppendText(vbCrLf & "if (rV == RESET) REG = 0;")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim intValue As Integer
        Try
            intValue = Integer.Parse(TextBox1.Text)

        Catch ex As FormatException
            MessageBox.Show("Number not valid")
        End Try

        If ((intValue < 1) Or (intValue > 127)) Then
            MessageBox.Show("Number out of range")
            TextBox1.Text = ""
        Else
            RichTextBox2.AppendText(vbCrLf & "#define ADDRESS " & intValue.ToString)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        RichTextBox2.AppendText(vbCrLf & "#define " & """" & TextBox2.Text & """")

    End Sub
End Class