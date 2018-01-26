<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class text2speech
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTalk = New System.Windows.Forms.Button
        Me.txt2voice = New System.Windows.Forms.TextBox
        Me.Process1 = New System.Diagnostics.Process
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnTalk
        '
        Me.btnTalk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTalk.Location = New System.Drawing.Point(345, 10)
        Me.btnTalk.Name = "btnTalk"
        Me.btnTalk.Size = New System.Drawing.Size(64, 23)
        Me.btnTalk.TabIndex = 5
        Me.btnTalk.Text = "Speak"
        '
        'txt2voice
        '
        Me.txt2voice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt2voice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2voice.Location = New System.Drawing.Point(9, 10)
        Me.txt2voice.Multiline = True
        Me.txt2voice.Name = "txt2voice"
        Me.txt2voice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt2voice.Size = New System.Drawing.Size(328, 121)
        Me.txt2voice.TabIndex = 4
        Me.txt2voice.Text = "Hello?! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I dont know why you would actually need this, but its here if you want " & _
            "to play with it."
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(345, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'text2speech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 141)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTalk)
        Me.Controls.Add(Me.txt2voice)
        Me.Name = "text2speech"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text to Voice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTalk As System.Windows.Forms.Button
    Friend WithEvents txt2voice As System.Windows.Forms.TextBox
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
