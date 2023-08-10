<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Find_Replace
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Find_Replace))
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' TextBox1
        ' 
        resources.ApplyResources(TextBox1, "TextBox1")
        TextBox1.Name = "TextBox1"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.ForeColor = Color.Navy
        Label1.Name = "Label1"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.ForeColor = Color.Navy
        Label2.Name = "Label2"
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.ForeColor = Color.Red
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        resources.ApplyResources(TextBox2, "TextBox2")
        TextBox2.Name = "TextBox2"
        ' 
        ' Button2
        ' 
        resources.ApplyResources(Button2, "Button2")
        Button2.ForeColor = Color.Red
        Button2.Name = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        resources.ApplyResources(Button3, "Button3")
        Button3.ForeColor = Color.Red
        Button3.Name = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Find_Replace
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        ControlBox = False
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Find_Replace"
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
