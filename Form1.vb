Imports System.IO

Public Class Notpad
    Dim zoom As Single = 1.0F
    Dim progress As Integer = 100

    Private Sub ZoomIn()
        If progress <= 900 Then
            zoom += 0.1F
            RichTextBox1.ZoomFactor = zoom
            progress += 10
            ToolStripProgressBar1.Value = progress
        End If
    End Sub
    Private Sub ZoomOut()
        If progress > 10 Then
            zoom -= 0.1F
            RichTextBox1.ZoomFactor = zoom
            progress -= 10
            ToolStripProgressBar1.Value = progress
        End If
    End Sub

    Dim OriginalText As String

    Private filepath = String.Empty
    Private Sub SaveContent(path As String)
        Try
            File.WriteAllText(path, RichTextBox1.Text)
            Dim srtnm() As String
            srtnm = path.Split("\")
            Text = srtnm(srtnm.Length - 1) & " - RapidBook"
            If Not recentFiles.Contains(filepath) Then
                recentFiles.Add(filepath)
            End If
            UpdateRecent()
        Catch ex As Exception
            MsgBox("Error in File Saving.")
        End Try
        OriginalText = RichTextBox1.Text
    End Sub

    Private Function SaveAs() As Boolean
        SaveFileDialog1.DefaultExt = ".txt"
        SaveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            filepath = SaveFileDialog1.FileName
            SaveContent(filepath)
            Return True
        End If
        Return False
    End Function

    Private Sub Open(Openfilepath As String)
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(Openfilepath)
        Dim name() As String
        name = Openfilepath.Split("\")
        Text = name(name.Length - 1) & " - RapidBook"
        If Not recentFiles.Contains(Openfilepath) Then
            recentFiles.Add(Openfilepath)
        End If
        UpdateRecent()
        filepath = Openfilepath
        OriginalText = RichTextBox1.Text
    End Sub

    Sub NewWindow()
        RichTextBox1.Text = " "
        Text = "Untitled-1 - RapidBook"
        filepath = String.Empty
    End Sub

    Dim tmp As MsgBoxResult

    Private Sub NewWindowTool_Click(sender As Object, e As EventArgs) Handles NewWindowTool.Click
        If RichTextBox1.Text <> OriginalText Then
            tmp = MessageBox.Show("Do you want to save changes...", "RapidBook", CType(MsgBoxStyle.YesNoCancel, MessageBoxButtons))
            If MsgBoxResult.Yes = tmp Then
                If String.IsNullOrEmpty(filepath) Then
                    If SaveAs() Then
                        NewWindow()
                    End If
                Else
                    SaveContent(filepath)
                    NewWindow()
                End If
            ElseIf MsgBoxResult.No = tmp Then
                NewWindow()
            End If
        Else
            NewWindow()
        End If
    End Sub


    Dim recentFiles As New List(Of String)

    Private Sub OpenTool_Click(sender As Object, e As EventArgs) Handles OpenTool.Click
        OpenFileDialog1.Filter = "TextFile|*.txt|AllFile|*.*"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Open(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveTool_Click(sender As Object, e As EventArgs) Handles SaveTool.Click
        SaveFileDialog1.Title = "Save"
        If String.IsNullOrEmpty(filepath) Then
            SaveAs()
        Else
            SaveContent(filepath)
        End If
    End Sub

    Private Sub SaveAsTool_Click(sender As Object, e As EventArgs) Handles SaveAsTool.Click
        SaveAs()
    End Sub


    Private Sub PrintTool_Click(sender As Object, e As EventArgs) Handles PrintTool.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintPreviewTool_Click(sender As Object, e As EventArgs) Handles PrintPreviewTool.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Document.DefaultPageSettings.Color = False
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub CloseWindow_Click(sender As Object, e As EventArgs) Handles CloseWindow.Click
        If RichTextBox1.Text <> OriginalText Then
            Dim tmp = MessageBox.Show("Do you want to save changes...", "RapidBook", CType(MsgBoxStyle.YesNoCancel, MessageBoxButtons))
            If MsgBoxResult.Yes = tmp Then
                If String.IsNullOrEmpty(filepath) Then
                    If SaveAs() Then
                        Close()
                    End If
                Else
                    SaveContent(filepath)
                    Close()
                End If
            ElseIf MsgBoxResult.No = tmp Then
                Close()
            End If
        Else
            Close()
        End If
    End Sub

    Shadows Sub UpdateRecent()
        RecentTool.DropDownItems.Clear()
        For Each filepath In recentFiles
            Dim Fname As String = Path.GetFileName(filepath)
            Dim RcntMnItm As New ToolStripMenuItem(Fname, Nothing, AddressOf RecentTool_Click)
            RecentTool.DropDownItems.Add(RcntMnItm)
        Next
    End Sub

    Private Sub RecentTool_Click(sender As Object, e As EventArgs) Handles RecentTool.Click
        Dim RcntMnItem As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        Dim Fname As String = RcntMnItem.Text
        Dim Fpath As String = recentFiles.Find(Function(fp) Path.GetFileName(fp) = Fname)
        If Not String.IsNullOrEmpty(Fpath) AndAlso File.Exists(Fpath) Then
            Open(Fpath)
        End If
    End Sub

    Private Sub UndoTool_Click(sender As Object, e As EventArgs) Handles UndoTool.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoTool_Click(sender As Object, e As EventArgs) Handles RedoTool.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutTool_Click(sender As Object, e As EventArgs) Handles CutTool.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyTool_Click(sender As Object, e As EventArgs) Handles CopyTool.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteTool_Click(sender As Object, e As EventArgs) Handles PasteTool.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllTool_Click(sender As Object, e As EventArgs) Handles SelectAllTool.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub DeleteTool_Click(sender As Object, e As EventArgs) Handles DeleteTool.Click
        RichTextBox1.SelectedText = ""
    End Sub

    Private Sub FontTool_Click(sender As Object, e As EventArgs) Handles FontTool.Click
        FontDialog1.ShowDialog()
        If Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font()
        End If
    End Sub

    Private Sub FontColor_Click(sender As Object, e As EventArgs) Handles FontColor.Click
        ColorDialog1.ShowDialog()
        If Windows.Forms.DialogResult.OK Then
            RichTextBox1.ForeColor = ColorDialog1.Color()
        End If
    End Sub

    Private Sub PageColor_Click(sender As Object, e As EventArgs) Handles PageColor.Click
        ColorDialog1.ShowDialog()
        If Windows.Forms.DialogResult.OK Then
            RichTextBox1.BackColor = ColorDialog1.Color()
        End If
    End Sub

    Private Sub ZoomInTool_Click(sender As Object, e As EventArgs) Handles ZoomInTool.Click
        ZoomIn()
    End Sub

    Private Sub ZoomOutTool_Click(sender As Object, e As EventArgs) Handles ZoomOutTool.Click
        ZoomOut()
    End Sub

    Private Sub ZoomOutIcon_Click(sender As Object, e As EventArgs) Handles ZoomOutIcon.Click
        ZoomIn()
    End Sub

    Private Sub ZoomInIcon_Click(sender As Object, e As EventArgs) Handles ZoomInIcon.Click
        ZoomOut()
    End Sub

    Private Sub DefaultZoom_Click(sender As Object, e As EventArgs) Handles DefaultZoom.Click
        RichTextBox1.ZoomFactor = 1.0F
        ToolStripProgressBar1.Value = 100
    End Sub

    Private Sub FindReplaceTool_Click(sender As Object, e As EventArgs) Handles FindReplaceTool.Click
        Find_Replace.Show()
    End Sub

    Private Sub FindTool_Click(sender As Object, e As EventArgs) Handles FindTool.Click
        Find.Show()
    End Sub

    Private Sub WordWrapTool_Click(sender As Object, e As EventArgs) Handles WordWrapTool.Click
        If WordWrapTool.Checked Then
            RichTextBox1.WordWrap = True
        Else
            RichTextBox1.WordWrap = False
        End If
    End Sub

    Private Sub StatusBarTool_CheckedChanged(sender As Object, e As EventArgs) Handles StatusBarTool.CheckedChanged
        If StatusBarTool.Checked Then
            StatusStrip1.Visible = True
        Else
            StatusStrip1.Visible = False
        End If
    End Sub

    Private Sub DisplayControl(tobe As Object)
        If RichTextBox1.Text.Length <= 0 Then
            tobe.Enabled = False
        Else
            tobe.Enabled = True
        End If
    End Sub

    Private Sub GoToTool_Click() Handles GoToTool.Click
        Dim line As Integer = InputBox("Enter the Line Number: ", "Find Line Number")
        Dim lineno As Integer
        If Integer.TryParse(line, lineno) Then
            If lineno >= 1 And lineno <= RichTextBox1.TextLength Then
                RichTextBox1.Select(RichTextBox1.GetFirstCharIndexFromLine(lineno - 1), 0)
                RichTextBox1.ScrollToCaret()
                RichTextBox1.Focus()
            Else
                MsgBox("Invalid Line Number...")
            End If
        Else
            MsgBox("Invalid Input, Please enter a valid line number...")
        End If
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click()
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim content As String = RichTextBox1.Text
        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)
        Dim marginBounds As RectangleF = e.MarginBounds
        e.Graphics.DrawString(content, font, brush, marginBounds)
    End Sub

    Sub Wrdcnt()
        Dim txt As String = RichTextBox1.Text
        Dim words() As String = txt.Split({" "c, ControlChars.Lf}, StringSplitOptions.RemoveEmptyEntries)
        ToolStripStatusLabel10.Text = words.Length
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        DisplayControl(FindReplaceTool)
        DisplayControl(FindTool)
        DisplayControl(CutTool)
        DisplayControl(CopyTool)
        Wrdcnt()
        ToolStripStatusLabel4.Text = RichTextBox1.Lines.Length
        ToolStripStatusLabel5.Text = RichTextBox1.SelectionStart - RichTextBox1.GetFirstCharIndexOfCurrentLine()
        ToolStripStatusLabel8.Text = RichTextBox1.Text.Length
    End Sub

    Private Sub Notpad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayControl(FindReplaceTool)
        DisplayControl(FindTool)
        DisplayControl(CutTool)
        DisplayControl(CopyTool)
        Timer1.Start()
        Timer1.Interval = 2600
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox2.Visible = True Then
            PictureBox2.Hide()
            Timer1.Stop()
            MainMenuStrip.Visible = True
            RichTextBox1.Visible = True
            StatusStrip1.Visible = True
            Text = "Untitled-1 - RapidBook"
        End If
    End Sub

    Private Sub RichTextBox1_MouseClick(sender As Object, e As EventArgs)
        ToolStripStatusLabel4.Text = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
        ToolStripStatusLabel5.Text = RichTextBox1.SelectionStart - RichTextBox1.GetFirstCharIndexOfCurrentLine() + 1
        ToolStripStatusLabel8.Text = RichTextBox1.Text.Length
        Wrdcnt()
    End Sub

    Private Sub RichTextBox1_KeyDown(sender As Object, e As EventArgs)
        ToolStripStatusLabel5.Text = RichTextBox1.SelectionStart - RichTextBox1.GetFirstCharIndexOfCurrentLine() + 1
        ToolStripStatusLabel4.Text = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
    End Sub

    Private Sub RichTextBox1_KeyUp(sender As Object, e As EventArgs)
        ToolStripStatusLabel5.Text = RichTextBox1.SelectionStart - RichTextBox1.GetFirstCharIndexOfCurrentLine() + 1
        ToolStripStatusLabel4.Text = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
    End Sub

    Private Sub Notepad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If RichTextBox1.Text <> OriginalText Then
            tmp = MessageBox.Show("Do you want to save changes...", "RapidBook", CType(MsgBoxStyle.YesNoCancel, MessageBoxButtons))
        End If
        If MsgBoxResult.Yes = tmp Then
            If String.IsNullOrEmpty(filepath) Then
                If SaveAs() Then
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            Else
                SaveContent(filepath)
                e.Cancel = False
            End If
        ElseIf MsgBoxResult.Cancel = tmp Then
            e.Cancel = True
        End If
    End Sub

    Private Sub LeftTool_Click(sender As Object, e As EventArgs) Handles LeftTool.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub CenterTool_Click(sender As Object, e As EventArgs) Handles CenterTool.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub RightTool_Click(sender As Object, e As EventArgs) Handles RightTool.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub AboutTool_Click(sender As Object, e As EventArgs) Handles AboutTool.Click
        MessageBox.Show("
                ### Developed by Sonam Rathour ###
______________________________________________________________________

Welcome to our Notepad Clone project! Our goal Is to pay homage to the classic digital notepad while adding our own unique twist. 
Get ready to relive the nostalgia of simple And straightforward note-taking, revamped for the modern era.

About Project :
Inspired by the iconic simplicity Of the original notepad application, our Notepad Clone project brings that familiar interface into the contemporary world.
We 've retained the essence of what made the classic notepad beloved by many while incorporating modern features that enhance usability and convenience.", "RapidBook - About Section")
    End Sub
End Class
