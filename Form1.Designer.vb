<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notpad
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
        components = New ComponentModel.Container()
        Dim MenuStrip1 As MenuStrip
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Notpad))
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewWindowTool = New ToolStripMenuItem()
        OpenTool = New ToolStripMenuItem()
        SaveTool = New ToolStripMenuItem()
        SaveAsTool = New ToolStripMenuItem()
        PrintTool = New ToolStripMenuItem()
        PrintPreviewTool = New ToolStripMenuItem()
        PageSetupTool = New ToolStripMenuItem()
        CloseWindow = New ToolStripMenuItem()
        RecentTool = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        UndoTool = New ToolStripMenuItem()
        RedoTool = New ToolStripMenuItem()
        CutTool = New ToolStripMenuItem()
        CopyTool = New ToolStripMenuItem()
        PasteTool = New ToolStripMenuItem()
        SelectAllTool = New ToolStripMenuItem()
        DeleteTool = New ToolStripMenuItem()
        FormatToolStripMenuItem = New ToolStripMenuItem()
        FontTool = New ToolStripMenuItem()
        FontColor = New ToolStripMenuItem()
        PageColor = New ToolStripMenuItem()
        AlignmentTool = New ToolStripMenuItem()
        LeftTool = New ToolStripMenuItem()
        CenterTool = New ToolStripMenuItem()
        RightTool = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        GoToTool = New ToolStripMenuItem()
        StatusBarTool = New ToolStripMenuItem()
        ZoomToolStripMenuItem1 = New ToolStripMenuItem()
        ZoomInTool = New ToolStripMenuItem()
        ZoomOutTool = New ToolStripMenuItem()
        DefaultZoom = New ToolStripMenuItem()
        FindReplaceTool = New ToolStripMenuItem()
        FindTool = New ToolStripMenuItem()
        WordWrapTool = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutTool = New ToolStripMenuItem()
        FontDialog1 = New FontDialog()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        PrintDialog1 = New PrintDialog()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        ColorDialog1 = New ColorDialog()
        StatusStrip1 = New StatusStrip()
        ZoomOutIcon = New ToolStripStatusLabel()
        ToolStripProgressBar1 = New ToolStripProgressBar()
        ZoomInIcon = New ToolStripStatusLabel()
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        ToolStripStatusLabel4 = New ToolStripStatusLabel()
        ToolStripStatusLabel6 = New ToolStripStatusLabel()
        ToolStripStatusLabel5 = New ToolStripStatusLabel()
        ToolStripStatusLabel7 = New ToolStripStatusLabel()
        ToolStripStatusLabel8 = New ToolStripStatusLabel()
        ToolStripStatusLabel9 = New ToolStripStatusLabel()
        ToolStripStatusLabel10 = New ToolStripStatusLabel()
        PageSetupDialog1 = New PageSetupDialog()
        Timer1 = New Timer(components)
        RichTextBox1 = New RichTextBox()
        PictureBox2 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.GradientInactiveCaption
        MenuStrip1.GripMargin = New Padding(2)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, FormatToolStripMenuItem, ViewToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1174, 29)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewWindowTool, OpenTool, SaveTool, SaveAsTool, PrintTool, PrintPreviewTool, PageSetupTool, CloseWindow, RecentTool})
        FileToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 25)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewWindowTool
        ' 
        NewWindowTool.Image = CType(resources.GetObject("NewWindowTool.Image"), Image)
        NewWindowTool.Name = "NewWindowTool"
        NewWindowTool.ShortcutKeys = Keys.Control Or Keys.N
        NewWindowTool.Size = New Size(270, 26)
        NewWindowTool.Text = "New Window"
        ' 
        ' OpenTool
        ' 
        OpenTool.Image = CType(resources.GetObject("OpenTool.Image"), Image)
        OpenTool.Name = "OpenTool"
        OpenTool.ShortcutKeys = Keys.Control Or Keys.O
        OpenTool.Size = New Size(270, 26)
        OpenTool.Text = "Open"
        ' 
        ' SaveTool
        ' 
        SaveTool.Image = CType(resources.GetObject("SaveTool.Image"), Image)
        SaveTool.Name = "SaveTool"
        SaveTool.ShortcutKeys = Keys.Control Or Keys.S
        SaveTool.Size = New Size(270, 26)
        SaveTool.Text = "Save"
        ' 
        ' SaveAsTool
        ' 
        SaveAsTool.Image = CType(resources.GetObject("SaveAsTool.Image"), Image)
        SaveAsTool.Name = "SaveAsTool"
        SaveAsTool.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.S
        SaveAsTool.Size = New Size(270, 26)
        SaveAsTool.Text = "Save As"
        ' 
        ' PrintTool
        ' 
        PrintTool.Image = CType(resources.GetObject("PrintTool.Image"), Image)
        PrintTool.Name = "PrintTool"
        PrintTool.ShortcutKeys = Keys.Control Or Keys.P
        PrintTool.Size = New Size(270, 26)
        PrintTool.Text = "Print"
        ' 
        ' PrintPreviewTool
        ' 
        PrintPreviewTool.Image = CType(resources.GetObject("PrintPreviewTool.Image"), Image)
        PrintPreviewTool.Name = "PrintPreviewTool"
        PrintPreviewTool.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.P
        PrintPreviewTool.Size = New Size(270, 26)
        PrintPreviewTool.Text = "Print Preview"
        ' 
        ' PageSetupTool
        ' 
        PageSetupTool.Image = CType(resources.GetObject("PageSetupTool.Image"), Image)
        PageSetupTool.Name = "PageSetupTool"
        PageSetupTool.ShortcutKeys = Keys.Control Or Keys.Alt Or Keys.P
        PageSetupTool.Size = New Size(270, 26)
        PageSetupTool.Text = "Page setup"
        ' 
        ' CloseWindow
        ' 
        CloseWindow.Image = CType(resources.GetObject("CloseWindow.Image"), Image)
        CloseWindow.Name = "CloseWindow"
        CloseWindow.ShortcutKeys = Keys.Control Or Keys.W
        CloseWindow.Size = New Size(270, 26)
        CloseWindow.Text = "Close Window"
        ' 
        ' RecentTool
        ' 
        RecentTool.Image = CType(resources.GetObject("RecentTool.Image"), Image)
        RecentTool.Name = "RecentTool"
        RecentTool.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.R
        RecentTool.Size = New Size(270, 26)
        RecentTool.Text = "Recent"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UndoTool, RedoTool, CutTool, CopyTool, PasteTool, SelectAllTool, DeleteTool})
        EditToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(48, 25)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' UndoTool
        ' 
        UndoTool.Image = CType(resources.GetObject("UndoTool.Image"), Image)
        UndoTool.Name = "UndoTool"
        UndoTool.ShortcutKeys = Keys.Control Or Keys.Z
        UndoTool.Size = New Size(199, 26)
        UndoTool.Text = "Undo"
        ' 
        ' RedoTool
        ' 
        RedoTool.Image = CType(resources.GetObject("RedoTool.Image"), Image)
        RedoTool.Name = "RedoTool"
        RedoTool.ShortcutKeys = Keys.Control Or Keys.Y
        RedoTool.Size = New Size(199, 26)
        RedoTool.Text = "Redo"
        ' 
        ' CutTool
        ' 
        CutTool.Image = CType(resources.GetObject("CutTool.Image"), Image)
        CutTool.Name = "CutTool"
        CutTool.ShortcutKeys = Keys.Control Or Keys.X
        CutTool.Size = New Size(199, 26)
        CutTool.Text = "Cut"
        ' 
        ' CopyTool
        ' 
        CopyTool.Image = CType(resources.GetObject("CopyTool.Image"), Image)
        CopyTool.Name = "CopyTool"
        CopyTool.ShortcutKeys = Keys.Control Or Keys.C
        CopyTool.Size = New Size(199, 26)
        CopyTool.Text = "Copy"
        ' 
        ' PasteTool
        ' 
        PasteTool.Image = CType(resources.GetObject("PasteTool.Image"), Image)
        PasteTool.Name = "PasteTool"
        PasteTool.ShortcutKeys = Keys.Control Or Keys.V
        PasteTool.Size = New Size(199, 26)
        PasteTool.Text = "Paste"
        ' 
        ' SelectAllTool
        ' 
        SelectAllTool.Image = CType(resources.GetObject("SelectAllTool.Image"), Image)
        SelectAllTool.Name = "SelectAllTool"
        SelectAllTool.ShortcutKeys = Keys.Control Or Keys.A
        SelectAllTool.Size = New Size(199, 26)
        SelectAllTool.Text = "Select All"
        ' 
        ' DeleteTool
        ' 
        DeleteTool.Image = CType(resources.GetObject("DeleteTool.Image"), Image)
        DeleteTool.Name = "DeleteTool"
        DeleteTool.ShortcutKeys = Keys.Delete
        DeleteTool.Size = New Size(199, 26)
        DeleteTool.Text = "Delete"
        ' 
        ' FormatToolStripMenuItem
        ' 
        FormatToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FontTool, FontColor, PageColor, AlignmentTool})
        FormatToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        FormatToolStripMenuItem.Size = New Size(72, 25)
        FormatToolStripMenuItem.Text = "Format"
        ' 
        ' FontTool
        ' 
        FontTool.Image = CType(resources.GetObject("FontTool.Image"), Image)
        FontTool.Name = "FontTool"
        FontTool.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.F
        FontTool.Size = New Size(252, 26)
        FontTool.Text = "Font"
        ' 
        ' FontColor
        ' 
        FontColor.Image = CType(resources.GetObject("FontColor.Image"), Image)
        FontColor.Name = "FontColor"
        FontColor.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.C
        FontColor.Size = New Size(252, 26)
        FontColor.Text = "Font Color"
        ' 
        ' PageColor
        ' 
        PageColor.Image = CType(resources.GetObject("PageColor.Image"), Image)
        PageColor.Name = "PageColor"
        PageColor.ShortcutKeys = Keys.Control Or Keys.Alt Or Keys.C
        PageColor.Size = New Size(252, 26)
        PageColor.Text = "Page Color"
        ' 
        ' AlignmentTool
        ' 
        AlignmentTool.DropDownItems.AddRange(New ToolStripItem() {LeftTool, CenterTool, RightTool})
        AlignmentTool.Image = CType(resources.GetObject("AlignmentTool.Image"), Image)
        AlignmentTool.Name = "AlignmentTool"
        AlignmentTool.Size = New Size(252, 26)
        AlignmentTool.Text = "Alignment"
        ' 
        ' LeftTool
        ' 
        LeftTool.Image = CType(resources.GetObject("LeftTool.Image"), Image)
        LeftTool.Name = "LeftTool"
        LeftTool.ShortcutKeys = Keys.Control Or Keys.L
        LeftTool.Size = New Size(180, 26)
        LeftTool.Text = "Left"
        ' 
        ' CenterTool
        ' 
        CenterTool.Image = CType(resources.GetObject("CenterTool.Image"), Image)
        CenterTool.Name = "CenterTool"
        CenterTool.ShortcutKeys = Keys.Control Or Keys.E
        CenterTool.Size = New Size(180, 26)
        CenterTool.Text = "Center"
        ' 
        ' RightTool
        ' 
        RightTool.Image = CType(resources.GetObject("RightTool.Image"), Image)
        RightTool.Name = "RightTool"
        RightTool.ShortcutKeys = Keys.Control Or Keys.R
        RightTool.Size = New Size(180, 26)
        RightTool.Text = "Right"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GoToTool, StatusBarTool, ZoomToolStripMenuItem1, FindReplaceTool, FindTool, WordWrapTool})
        ViewToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(56, 25)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' GoToTool
        ' 
        GoToTool.Image = CType(resources.GetObject("GoToTool.Image"), Image)
        GoToTool.Name = "GoToTool"
        GoToTool.Size = New Size(228, 26)
        GoToTool.Text = "Go to"
        ' 
        ' StatusBarTool
        ' 
        StatusBarTool.Checked = True
        StatusBarTool.CheckOnClick = True
        StatusBarTool.CheckState = CheckState.Checked
        StatusBarTool.Name = "StatusBarTool"
        StatusBarTool.ShowShortcutKeys = False
        StatusBarTool.Size = New Size(228, 26)
        StatusBarTool.Text = "Status bar"
        ' 
        ' ZoomToolStripMenuItem1
        ' 
        ZoomToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ZoomInTool, ZoomOutTool, DefaultZoom})
        ZoomToolStripMenuItem1.Image = CType(resources.GetObject("ZoomToolStripMenuItem1.Image"), Image)
        ZoomToolStripMenuItem1.Name = "ZoomToolStripMenuItem1"
        ZoomToolStripMenuItem1.Size = New Size(228, 26)
        ZoomToolStripMenuItem1.Text = "Zoom"
        ' 
        ' ZoomInTool
        ' 
        ZoomInTool.Name = "ZoomInTool"
        ZoomInTool.ShortcutKeys = Keys.Control Or Keys.Right
        ZoomInTool.Size = New Size(223, 26)
        ZoomInTool.Text = "Zoom In"
        ' 
        ' ZoomOutTool
        ' 
        ZoomOutTool.Name = "ZoomOutTool"
        ZoomOutTool.ShortcutKeys = Keys.Control Or Keys.Left
        ZoomOutTool.Size = New Size(223, 26)
        ZoomOutTool.Text = "Zoom Out"
        ' 
        ' DefaultZoom
        ' 
        DefaultZoom.Name = "DefaultZoom"
        DefaultZoom.ShortcutKeys = Keys.Control Or Keys.Space
        DefaultZoom.Size = New Size(223, 26)
        DefaultZoom.Text = "Default"
        ' 
        ' FindReplaceTool
        ' 
        FindReplaceTool.Image = CType(resources.GetObject("FindReplaceTool.Image"), Image)
        FindReplaceTool.Name = "FindReplaceTool"
        FindReplaceTool.ShortcutKeys = Keys.Control Or Keys.H
        FindReplaceTool.Size = New Size(228, 26)
        FindReplaceTool.Text = "Find_Replace"
        ' 
        ' FindTool
        ' 
        FindTool.Image = CType(resources.GetObject("FindTool.Image"), Image)
        FindTool.Name = "FindTool"
        FindTool.ShortcutKeys = Keys.Control Or Keys.F
        FindTool.Size = New Size(228, 26)
        FindTool.Text = "Find"
        ' 
        ' WordWrapTool
        ' 
        WordWrapTool.Checked = True
        WordWrapTool.CheckOnClick = True
        WordWrapTool.CheckState = CheckState.Checked
        WordWrapTool.Name = "WordWrapTool"
        WordWrapTool.Size = New Size(228, 26)
        WordWrapTool.Text = "Word Wrap"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutTool})
        HelpToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(54, 25)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutTool
        ' 
        AboutTool.Image = CType(resources.GetObject("AboutTool.Image"), Image)
        AboutTool.Name = "AboutTool"
        AboutTool.Size = New Size(122, 26)
        AboutTool.Text = "About"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = SystemColors.GradientInactiveCaption
        StatusStrip1.Items.AddRange(New ToolStripItem() {ZoomOutIcon, ToolStripProgressBar1, ZoomInIcon, ToolStripStatusLabel3, ToolStripStatusLabel4, ToolStripStatusLabel6, ToolStripStatusLabel5, ToolStripStatusLabel7, ToolStripStatusLabel8, ToolStripStatusLabel9, ToolStripStatusLabel10})
        StatusStrip1.Location = New Point(0, 625)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 12, 0)
        StatusStrip1.Size = New Size(1174, 26)
        StatusStrip1.TabIndex = 4
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ZoomOutIcon
        ' 
        ZoomOutIcon.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ZoomOutIcon.Image = CType(resources.GetObject("ZoomOutIcon.Image"), Image)
        ZoomOutIcon.Name = "ZoomOutIcon"
        ZoomOutIcon.Size = New Size(16, 21)
        ' 
        ' ToolStripProgressBar1
        ' 
        ToolStripProgressBar1.ForeColor = Color.Lime
        ToolStripProgressBar1.Maximum = 900
        ToolStripProgressBar1.Minimum = 10
        ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        ToolStripProgressBar1.Size = New Size(105, 20)
        ToolStripProgressBar1.Style = ProgressBarStyle.Continuous
        ToolStripProgressBar1.ToolTipText = vbCrLf & vbCrLf & vbCrLf
        ToolStripProgressBar1.Value = 10
        ' 
        ' ZoomInIcon
        ' 
        ZoomInIcon.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ZoomInIcon.Image = CType(resources.GetObject("ZoomInIcon.Image"), Image)
        ZoomInIcon.Name = "ZoomInIcon"
        ZoomInIcon.Size = New Size(16, 21)
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(73, 21)
        ToolStripStatusLabel3.Text = "    Lines : "
        ' 
        ' ToolStripStatusLabel4
        ' 
        ToolStripStatusLabel4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripStatusLabel4.LinkBehavior = LinkBehavior.AlwaysUnderline
        ToolStripStatusLabel4.Margin = New Padding(1, 1, 1, 0)
        ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        ToolStripStatusLabel4.Size = New Size(0, 25)
        ' 
        ' ToolStripStatusLabel6
        ' 
        ToolStripStatusLabel6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        ToolStripStatusLabel6.Size = New Size(59, 21)
        ToolStripStatusLabel6.Text = " Cols :  "
        ' 
        ' ToolStripStatusLabel5
        ' 
        ToolStripStatusLabel5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripStatusLabel5.LinkBehavior = LinkBehavior.AlwaysUnderline
        ToolStripStatusLabel5.Margin = New Padding(1, 1, 1, 0)
        ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        ToolStripStatusLabel5.Size = New Size(0, 25)
        ' 
        ' ToolStripStatusLabel7
        ' 
        ToolStripStatusLabel7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        ToolStripStatusLabel7.Size = New Size(99, 21)
        ToolStripStatusLabel7.Text = " Characters : "
        ' 
        ' ToolStripStatusLabel8
        ' 
        ToolStripStatusLabel8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripStatusLabel8.Margin = New Padding(1, 1, 1, 0)
        ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        ToolStripStatusLabel8.Size = New Size(0, 25)
        ' 
        ' ToolStripStatusLabel9
        ' 
        ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        ToolStripStatusLabel9.Size = New Size(53, 21)
        ToolStripStatusLabel9.Text = " Words : "
        ' 
        ' ToolStripStatusLabel10
        ' 
        ToolStripStatusLabel10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        ToolStripStatusLabel10.Size = New Size(0, 21)
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 3000
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.White
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Location = New Point(0, 29)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(1174, 596)
        RichTextBox1.TabIndex = 5
        RichTextBox1.Text = ""
        RichTextBox1.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 29)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1174, 596)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Notpad
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1174, 651)
        Controls.Add(PictureBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(MenuStrip1)
        Controls.Add(StatusStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        Name = "Notpad"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = " RapidBook"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoTool As ToolStripMenuItem
    Friend WithEvents RedoTool As ToolStripMenuItem
    Friend WithEvents CutTool As ToolStripMenuItem
    Friend WithEvents NewWindowTool As ToolStripMenuItem
    Friend WithEvents OpenTool As ToolStripMenuItem
    Friend WithEvents SaveTool As ToolStripMenuItem
    Friend WithEvents SaveAsTool As ToolStripMenuItem
    Friend WithEvents PrintTool As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintPreviewTool As ToolStripMenuItem
    Friend WithEvents CopyTool As ToolStripMenuItem
    Friend WithEvents PasteTool As ToolStripMenuItem
    Friend WithEvents SelectAllTool As ToolStripMenuItem
    Friend WithEvents DeleteTool As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontTool As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ZoomOutIcon As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ZoomInIcon As ToolStripStatusLabel
    Friend WithEvents FontColor As ToolStripMenuItem
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoToTool As ToolStripMenuItem
    Friend WithEvents StatusBarTool As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ZoomInTool As ToolStripMenuItem
    Friend WithEvents ZoomOutTool As ToolStripMenuItem
    Friend WithEvents DefaultZoom As ToolStripMenuItem
    Friend WithEvents PageColor As ToolStripMenuItem
    Friend WithEvents FindReplaceTool As ToolStripMenuItem
    Friend WithEvents FindTool As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTool As ToolStripMenuItem
    Friend WithEvents WordWrapTool As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PageSetupTool As ToolStripMenuItem
    Friend WithEvents CloseWindow As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As ToolStripStatusLabel
    Friend WithEvents RecentTool As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AlignmentTool As ToolStripMenuItem
    Friend WithEvents LeftTool As ToolStripMenuItem
    Friend WithEvents CenterTool As ToolStripMenuItem
    Friend WithEvents RightTool As ToolStripMenuItem
End Class
