Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    ' Language selector dropdown thingy
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.SelectedIndex
            Case 0
                ComboBox1.Items.Clear()
                ComboBox1.Items.Add("hours")
                ComboBox1.Items.Add("days")
                ComboBox1.Items.Add("weeks")
                ComboBox1.Items.Add("months")
                ComboBox1.Items.Add("years")
                Button1.Text = "Copy"
                Label2.Text = "minutes"

            Case 1
                ComboBox1.Items.Clear()
                ComboBox1.Items.Add("óra")
                ComboBox1.Items.Add("nap")
                ComboBox1.Items.Add("hét")
                ComboBox1.Items.Add("hónap")
                ComboBox1.Items.Add("év")
                Button1.Text = "Másolás"
                Label2.Text = "perc"

            Case 2
                ComboBox1.Items.Clear()
                ComboBox1.Items.Add("Stunden")
                ComboBox1.Items.Add("Tage")
                ComboBox1.Items.Add("Wochen")
                ComboBox1.Items.Add("Monate")
                ComboBox1.Items.Add("Jahre")
                Button1.Text = "Kopieren"
                Label2.Text = "Minuten"
        End Select
    End Sub

    ' Copy button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text.Length = 0 Then Exit Sub
        My.Computer.Clipboard.SetText(TextBox2.Text)
    End Sub

    ' the lil text thingy
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = 0 Then Exit Sub
        Select Case ComboBox1.SelectedIndex
            Case 0 ' hours
                TextBox2.Text = (Convert.ToInt32(TextBox1.Text) * 60).ToString()
            Case 1 ' days
                TextBox2.Text = (Convert.ToInt32(TextBox1.Text) * 1440).ToString()
            Case 2 ' weeks
                TextBox2.Text = (Convert.ToInt32(TextBox1.Text) * 10080).ToString()
            Case 3 ' months
                TextBox2.Text = (Convert.ToInt32(TextBox1.Text) * 43200).ToString()
            Case 4 ' years
                TextBox2.Text = (Convert.ToInt32(TextBox1.Text) * 525600).ToString()
        End Select

        If Convert.ToInt32(TextBox2.Text) > 26297450 Then
            TextBox2.ForeColor = Color.OrangeRed
            TextBox2.Text = 26297450
        Else
            TextBox2.ForeColor = Color.White
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub
End Class
