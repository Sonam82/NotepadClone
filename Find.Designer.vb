<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Find
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(216, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(206, 39)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(61, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 32)
        Label1.TabIndex = 1
        Label1.Text = "FInd Word : "
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(60, 94)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 37)
        Button1.TabIndex = 2
        Button1.Text = "Find"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(172, 94)
        Button2.Name = "Button2"
        Button2.Size = New Size(109, 37)
        Button2.TabIndex = 3
        Button2.Text = "Find All"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.Red
        Button3.Location = New Point(313, 94)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 37)
        Button3.TabIndex = 4
        Button3.Text = "Cancel"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Find
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        ClientSize = New Size(500, 160)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Find"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Find"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
