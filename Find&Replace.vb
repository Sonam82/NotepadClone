Public Class Find_Replace
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstIndex = Notpad.RichTextBox1.Text.IndexOf(TextBox1.Text)
        Notpad.RichTextBox1.Text = Replace(Notpad.RichTextBox1.Text, TextBox1.Text, TextBox2.Text,, 1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Notpad.RichTextBox1.Text = Replace(Notpad.RichTextBox1.Text, TextBox1.Text, TextBox2.Text)
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub
End Class