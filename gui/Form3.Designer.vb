<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Insert_memory_button = New Button()
        memory = New DataGridView()
        Address = New DataGridViewTextBoxColumn()
        Content = New DataGridViewTextBoxColumn()
        Mnemonic = New DataGridViewTextBoxColumn()
        Label6 = New Label()
        Label5 = New Label()
        clear_mem_button = New Button()
        uploadbutton = New Button()
        Instruction_box_list = New ListBox()
        mem_address_list = New ListBox()
        demo_button = New Button()
        GroupBox3 = New GroupBox()
        CType(memory, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Insert_memory_button
        ' 
        Insert_memory_button.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Insert_memory_button.Location = New Point(645, 575)
        Insert_memory_button.Name = "Insert_memory_button"
        Insert_memory_button.Size = New Size(260, 77)
        Insert_memory_button.TabIndex = 15
        Insert_memory_button.Text = "Insert in Memory"
        Insert_memory_button.UseVisualStyleBackColor = True
        ' 
        ' memory
        ' 
        memory.ColumnHeadersHeight = 34
        memory.Columns.AddRange(New DataGridViewColumn() {Address, Content, Mnemonic})
        memory.Location = New Point(10, 40)
        memory.Name = "memory"
        memory.RowHeadersWidth = 62
        memory.RowTemplate.Height = 28
        memory.Size = New Size(755, 386)
        memory.TabIndex = 7
        ' 
        ' Address
        ' 
        Address.HeaderText = "Address"
        Address.MinimumWidth = 8
        Address.Name = "Address"
        Address.Width = 120
        ' 
        ' Content
        ' 
        Content.HeaderText = "OpCode"
        Content.MinimumWidth = 8
        Content.Name = "Content"
        Content.Width = 120
        ' 
        ' Mnemonic
        ' 
        Mnemonic.HeaderText = "Full Instruction"
        Mnemonic.MinimumWidth = 8
        Mnemonic.Name = "Mnemonic"
        Mnemonic.Width = 450
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(222, 433)
        Label6.Name = "Label6"
        Label6.Size = New Size(214, 29)
        Label6.TabIndex = 12
        Label6.Text = "Select Instruction"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(666, 433)
        Label5.Name = "Label5"
        Label5.Size = New Size(190, 29)
        Label5.TabIndex = 11
        Label5.Text = "Select Address"
        ' 
        ' clear_mem_button
        ' 
        clear_mem_button.BackColor = SystemColors.HotTrack
        clear_mem_button.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        clear_mem_button.ForeColor = SystemColors.ButtonHighlight
        clear_mem_button.Location = New Point(781, 245)
        clear_mem_button.Name = "clear_mem_button"
        clear_mem_button.Size = New Size(151, 72)
        clear_mem_button.TabIndex = 6
        clear_mem_button.Text = "Clear Prog"
        clear_mem_button.UseVisualStyleBackColor = False
        ' 
        ' uploadbutton
        ' 
        uploadbutton.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        uploadbutton.Location = New Point(781, 323)
        uploadbutton.Name = "uploadbutton"
        uploadbutton.Size = New Size(151, 107)
        uploadbutton.TabIndex = 22
        uploadbutton.Text = "Update Memory Unit"
        uploadbutton.UseVisualStyleBackColor = True
        ' 
        ' Instruction_box_list
        ' 
        Instruction_box_list.FormattingEnabled = True
        Instruction_box_list.Items.AddRange(New Object() {"NOP" & vbTab & vbTab & "No Operation" & vbTab & "00 00 00 00", "MOV A,i " & vbTab & vbTab & "(A = Integer i)  " & vbTab & "04 00 00 XX", "MOV B,i " & vbTab & vbTab & "(B = Integer i)" & vbTab & "05 00 00 XX", "MOV B,A " & vbTab & vbTab & "(B = A)" & vbTab & vbTab & "06 00 00 00", "ADD A,B " & vbTab & vbTab & "(A = A +B)" & vbTab & "14 00 00 00", "INC A " & vbTab & vbTab & "(A = A + 1)" & vbTab & "10 00 00 00", "INC B " & vbTab & vbTab & "(B = B + 1)" & vbTab & "11 00 00 00", "DEC A" & vbTab & vbTab & "(A=A-1)" & vbTab & vbTab & "12 00 00 00", "DEC B" & vbTab & vbTab & "(B=B-1)" & vbTab & vbTab & "13 00 00 00", "JNZ addr" & vbTab & vbTab & "(IF previous calculation<>0, then goto addr) 15 00 00 XX", "STOP" & vbTab & vbTab & "Halt Program " & vbTab & "17 00 00 00"})
        Instruction_box_list.Location = New Point(10, 466)
        Instruction_box_list.Name = "Instruction_box_list"
        Instruction_box_list.Size = New Size(629, 179)
        Instruction_box_list.TabIndex = 16
        ' 
        ' mem_address_list
        ' 
        mem_address_list.FormattingEnabled = True
        mem_address_list.Location = New Point(645, 465)
        mem_address_list.Name = "mem_address_list"
        mem_address_list.Size = New Size(261, 104)
        mem_address_list.TabIndex = 17
        ' 
        ' demo_button
        ' 
        demo_button.BackColor = SystemColors.GradientActiveCaption
        demo_button.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        demo_button.Location = New Point(781, 164)
        demo_button.Name = "demo_button"
        demo_button.Size = New Size(151, 75)
        demo_button.TabIndex = 16
        demo_button.Text = "Demo Prog"
        demo_button.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(demo_button)
        GroupBox3.Controls.Add(mem_address_list)
        GroupBox3.Controls.Add(Instruction_box_list)
        GroupBox3.Controls.Add(uploadbutton)
        GroupBox3.Controls.Add(clear_mem_button)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(memory)
        GroupBox3.Controls.Add(Insert_memory_button)
        GroupBox3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(12, 16)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(954, 656)
        GroupBox3.TabIndex = 20
        GroupBox3.TabStop = False
        GroupBox3.Text = "Program"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(17F, 36F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(978, 725)
        Controls.Add(GroupBox3)
        Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(7, 6, 7, 6)
        Name = "Form3"
        Text = "MDK - Program Uploader - panospapazoglou.gr"
        CType(memory, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Insert_memory_button As Button
    Friend WithEvents memory As DataGridView
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Content As DataGridViewTextBoxColumn
    Friend WithEvents Mnemonic As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents clear_mem_button As Button
    Friend WithEvents uploadbutton As Button
    Friend WithEvents Instruction_box_list As ListBox
    Friend WithEvents mem_address_list As ListBox
    Friend WithEvents demo_button As Button
    Friend WithEvents GroupBox3 As GroupBox
End Class
