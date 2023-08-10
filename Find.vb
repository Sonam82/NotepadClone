Public Class Find

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Notpad.RichTextBox1.Find(TextBox1.Text, 0, RichTextBoxFinds.None)
        Notpad.RichTextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim start As Integer = 0
        Dim endtxt As Integer
        endtxt = Notpad.RichTextBox1.Text.LastIndexOf(TextBox1.Text)
        Notpad.RichTextBox1.SelectAll()
        While start < endtxt
            Notpad.RichTextBox1.Find(TextBox1.Text, start, Notpad.RichTextBox1.TextLength, RichTextBoxFinds.MatchCase)
            Notpad.RichTextBox1.SelectionBackColor = Color.Yellow
            start = Notpad.RichTextBox1.Text.IndexOf(TextBox1.Text, start) + 1
        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim start As Integer = 0
        Dim endtxt As Integer
        endtxt = Notpad.RichTextBox1.Text.LastIndexOf(TextBox1.Text)
        Notpad.RichTextBox1.SelectAll()
        While start < endtxt
            Notpad.RichTextBox1.Find(TextBox1.Text, start, Notpad.RichTextBox1.TextLength, RichTextBoxFinds.MatchCase)
            Notpad.RichTextBox1.SelectionBackColor = Color.White
            start = Notpad.RichTextBox1.Text.IndexOf(TextBox1.Text, start) + 1
        End While
        Close()
    End Sub
End Class