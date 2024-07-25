<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.ForeColor = Color.White
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"hours", "days", "weeks", "months", "years"})
        ComboBox1.Location = New Point(68, 12)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(12, 12)
        TextBox1.MaxLength = 3
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(50, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 15)
        Label1.TabIndex = 2
        Label1.Text = "="
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(33, 38)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(139, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 4
        Label2.Text = "minutes"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FlatStyle = FlatStyle.Flat
        ComboBox2.ForeColor = Color.White
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"English", "Magyar", "Deutsch"})
        ComboBox2.Location = New Point(251, 12)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(12, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 35)
        Button1.TabIndex = 3
        Button1.Text = "Copy"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(384, 111)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "SLTimeConverter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button

End Class
