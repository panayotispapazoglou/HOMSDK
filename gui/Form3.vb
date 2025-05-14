
'*******************************************
'GUI for developing And uploading
'program to physical memory unit
'a Visual Basic application
'********************************************
'HOMS version 1B
'Hardware-Oriented Microprocessor
'Simulator
'
'(C) Panayotis (Panos) Papazoglou
'https://panospapazoglou.gr/
'
'LICENSE: 
'Creative Commons
'CC BY NC SA
'International License
'********************************************/

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System
Imports System.IO.Ports
Imports System.IO
'Imports System.Reflection.Emit
'Imports System.Resources
'Imports System.Diagnostics.Eventing.Reader
'Imports System.Threading
'Imports System.Drawing

Public Class Form3


    '*******************
    '*** GLOBAL VARS ***
    '*******************
    Dim comPORT As String
    Dim count As Integer = 0
    Dim url As String = "https://panospapazoglou.gr"
    Private fn(20) As String
    Private iset(20) As String
    Private code(20) As Integer
    Private mem(100) As Integer
    Private opcode = 0, addr = 0, procounter = 0, a = 0, b = 0, TX = 0, RX = 0


    '****************************
    '*** AFTER APP FORM LOAD ***
    '****************************
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        iset(0) = "NOP (No Operation), BYTES:00 00 (code 00)"
        iset(1) = "MOV A, i => (A = Integer i), BYTES:04 XX (code 04)"
        iset(2) = "MOV B, i => (B = Integer i), BYTES:03 XX (code 03)"
        iset(3) = "INC A (A = A + 1), BYTES:10 00 (code 10)"
        iset(4) = "INC B (B = B + 1), BYTES:05 00 (code 05)"
        iset(5) = "DEC A => (A = A - 1), BYTES:06 00 (code 06)"
        iset(6) = "DEC B => (B = B - 1), BYTES:07 00 (code 07)"
        iset(7) = "ADD A, B => (A = A + B), BYTES:01 XX (code 01)"
        iset(8) = "HALT =>	Halt Program, BYTES:17 00 (code 17)"

        code(0) = 0     'NOP
        code(1) = 4     'MOV A,i
        code(2) = 3     'MOV B,i
        code(3) = 10    'INC A
        code(4) = 5     'INC B
        code(5) = 6     'DEC A
        code(6) = 7     'DEC B
        code(7) = 1     'ADD A,B
        code(8) = 17    'HALT

        fn(0) = "NOP (No Operation), BYTES:00 00 (code 00)"
        fn(4) = "MOV A, i => (A = Integer i), BYTES:04 XX (code 04)"
        fn(3) = "MOV B, i => (B = Integer i), BYTES:03 XX (code 03)"
        fn(10) = "INC A (A = A + 1), BYTES:10 00 (code 10)"
        fn(5) = "INC B (B = B + 1), BYTES:05 00 (code 05)"
        fn(6) = "DEC A => (A = A - 1), BYTES:06 00 (code 06)"
        fn(7) = "DEC B => (B = B - 1), BYTES:07 00 00 (code 07)"
        fn(1) = "ADD A, B => (A = A + B), BYTES:01 XX (code 01)"
        fn(17) = "HALT =>	Halt Program, BYTES:17 00 (code 17)"

        Setcolors(1)
        display_instructions_listbox1()

        For i = 0 To 100 Step 2
            mem_address_list.Items.Add(i)
        Next


    End Sub


    '*******************************
    'Set colors for all form objects
    '*******************************

    Private Sub Setcolors(mode As Integer)
        Dim bcolor As Color = Color.FromArgb(185, 209, 234)
        Dim fcolor As Color = Color.FromArgb(0, 0, 0)
        Dim wcolor As Color = Color.FromArgb(255, 255, 255)

        'Set default colors
        If (mode = 1) Then
            bcolor = Color.FromArgb(185, 209, 234)
            fcolor = Color.FromArgb(0, 0, 0)
            'overwrites back color for boxes within the app form
            wcolor = Color.FromArgb(255, 255, 255)
        End If

        'Set colors for high contrast theme (black on white)
        If (mode = 2) Then
            bcolor = Color.FromArgb(255, 255, 255)
            fcolor = Color.FromArgb(0, 0, 0)
            wcolor = bcolor
        End If

        'Set colors for high contrast theme (white on black)
        If (mode = 3) Then
            bcolor = Color.FromArgb(0, 0, 0)
            fcolor = Color.FromArgb(255, 255, 255)
            wcolor = bcolor
        End If

        'set the same back/fore colors for every form object
        clear_mem_button.BackColor = bcolor
        clear_mem_button.ForeColor = fcolor

        uploadbutton.BackColor = bcolor
        uploadbutton.ForeColor = fcolor


        demo_button.BackColor = bcolor
        demo_button.ForeColor = fcolor



        Insert_memory_button.BackColor = bcolor
        Insert_memory_button.ForeColor = fcolor

        Me.BackColor = bcolor

        Instruction_box_list.BackColor = wcolor
        Instruction_box_list.ForeColor = fcolor

        mem_address_list.BackColor = wcolor
        mem_address_list.ForeColor = fcolor

        memory.BackColor = wcolor
        memory.ForeColor = fcolor


        GroupBox3.BackColor = bcolor
        GroupBox3.ForeColor = fcolor




        'unlock datagridbox colors from default
        memory.EnableHeadersVisualStyles = False

        memory.BackgroundColor = wcolor
        memory.ForeColor = fcolor

        memory.DefaultCellStyle.BackColor = wcolor
        memory.DefaultCellStyle.ForeColor = fcolor

        memory.ColumnHeadersDefaultCellStyle.BackColor = wcolor
        memory.ColumnHeadersDefaultCellStyle.ForeColor = fcolor

        memory.DefaultCellStyle.ForeColor = fcolor

        memory.RowHeadersDefaultCellStyle.BackColor = wcolor
        memory.RowHeadersDefaultCellStyle.ForeColor = fcolor

    End Sub

    '*******************************
    'Select COM port from list
    '*******************************


    '*******************************
    'Clear Prog button operation
    '*******************************
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles clear_mem_button.Click
        clear_memory()
    End Sub

    '******************************************
    'Clear Prog array/set each location to zero
    '******************************************
    Private Sub clear_memory()
        memory.Rows.Clear()
        For i = 0 To 100
            mem(i) = 0

        Next
        display_memory()
    End Sub

    '*******************************
    'Display available instructions
    '*******************************
    Private Sub display_instructions_listbox1()
        Instruction_box_list.Items.Clear()
        For i = 0 To 8
            Instruction_box_list.Items.Add(iset(i))
        Next
    End Sub

    '*******************************************
    '*** Insert automatically a demo program ***
    '*******************************************
    Private Sub demobutton_Click(sender As Object, e As EventArgs) Handles demo_button.Click
        clear_memory()
        mem(0) = 4
        mem(1) = 4
        mem(2) = 10
        mem(3) = 0
        mem(4) = 3
        mem(5) = 7
        mem(6) = 7
        mem(7) = 0
        mem(8) = 17
        mem(9) = 0
        display_memory()
    End Sub

    '***************************
    '*** Open URL in browser ***
    '***************************
    Private Sub Button9_Click_1(sender As Object, e As EventArgs)
        Process.Start(url)
    End Sub

    '***********************************
    '*** Configure and open COM port ***
    '***********************************


    '**************************************
    '***    UPLOAD CODE TO ARDUINO      ***
    '*** enable transmitting in Timer 1 ***
    '**************************************



    '*************************************
    '*** button for default GUI colors ***
    '*************************************
    Private Sub Defbutton_Click(sender As Object, e As EventArgs)
        Setcolors(1)
    End Sub

    '*************************************************
    '*** button for GUI HC colors (black on white) ***
    '*************************************************
    Private Sub Whitebutton_Click(sender As Object, e As EventArgs)
        Setcolors(2)
    End Sub

    '*************************************************
    '*** button for GUI HC colors (white on black) ***
    '*************************************************
    Private Sub Blackbutton_Click(sender As Object, e As EventArgs)
        Setcolors(3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Me.Controls.Clear()
        Me.Close()
        Me.Show()


    End Sub

    '*********************************************
    '*** EVENT TIMER for Serial communicatinon ***
    '*********************************************


    '*********************************************
    '***     Wait after Arduino auto reset     ***
    '*********************************************
    Private Sub Waitfake()
        For x = 1 To 10000000
            mem(100) = Math.Floor(Math.Sqrt(x / 100000) * Rnd())
        Next
    End Sub

    '*******************************
    '*** Close com port and stop ***
    '*******************************


    '*******************************
    '*** DISPLAY MEMORY CONTENTS ***
    '*******************************
    Private Sub display_memory()

        'Clear RAM display area
        memory.Rows.Clear()

        For i = 0 To 100
            If (i Mod 2 = 0) Then
                memory.Rows.Add(i, mem(i), fn(mem(i)))
            Else
                memory.Rows.Add(i, mem(i), mem(i))
            End If
        Next
    End Sub


    '*****************************
    '*** INSERT CODE IN MEMORY ***
    '*****************************
    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles Insert_memory_button.Click

        Dim addrselect As Integer = mem_address_list.SelectedIndex * 2
        Dim insselect As Integer = Instruction_box_list.SelectedIndex

        If addrselect <> -1 Then
            addr = addrselect
        Else
            addr = 0

        End If

        If insselect <> -1 Then
            opcode = code(insselect)
        Else
            opcode = 0
        End If

        If addr < 0 Then
            addr = 0
        End If



        Dim intnum As Integer
        Select Case opcode
            Case 4
                intnum = read_int("MOV A,X //X=")
                mem(addr + 1) = intnum
            Case 33 'idle
                intnum = read_int("MOV B,X //B=")
                mem(addr + 1) = intnum
            Case 38 'idle
                intnum = read_int("JNZ (A), Address=")
                mem(addr + 1) = intnum
            Case 39 'idle
                intnum = read_int("JNZ (B), Address=")
                mem(addr + 1) = intnum
        End Select
        mem(addr) = opcode
        display_memory()
    End Sub

    '***********************************************
    '*** READ INT VALUE AS INSTRUCTION PARAMETER ***
    '***********************************************
    Function read_int(msg As String) As Integer
        Dim str = InputBox(msg)
        If (str = "") Then
            MsgBox("Value not selected, set to default=0")
            str = "0"
        End If
        Return Convert.ToInt32(str)
    End Function

    Private Sub uploadbutton_Click(sender As Object, e As EventArgs) Handles uploadbutton.Click
        Dim result As DialogResult = MessageBox.Show("The memory contents will be written inside MDK-MEMORY.INO (ovewrite old file)", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try

                Dim filenamepath = "mdk-memory\"
                Dim filename = "mdk-memory.ino"
                Dim fullname = filenamepath & filename
                Dim filecontent = File.ReadAllText(fullname)
                filecontent = filecontent.Substring(330)
                Dim memstr As String = ""
                Dim memstr0 As String = "int mem[100]={"
                Dim i As Integer
                For i = 0 To 99
                    If i < 99 Then
                        memstr = memstr & Str(mem(i)) & ","
                    Else
                        memstr = memstr & Str(mem(i))
                    End If
                Next
                Dim finalmem = memstr0 & memstr & "};"
                Dim finalfile = finalmem & vbCrLf & filecontent
                File.WriteAllText(fullname, finalfile)
                MessageBox.Show("Memory Unit updated!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Reset canceled!")
        End If
    End Sub
End Class
