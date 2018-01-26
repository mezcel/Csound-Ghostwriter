<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.btnProgrammer = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pbAbout = New System.Windows.Forms.PictureBox
        Me.pbGhost = New System.Windows.Forms.PictureBox
        Me.btnShrink = New System.Windows.Forms.Button
        Me.pbAuthor = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGhost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAuthor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProgrammer
        '
        Me.btnProgrammer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnProgrammer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProgrammer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgrammer.Location = New System.Drawing.Point(13, 602)
        Me.btnProgrammer.Name = "btnProgrammer"
        Me.btnProgrammer.Size = New System.Drawing.Size(464, 23)
        Me.btnProgrammer.TabIndex = 1
        Me.btnProgrammer.Text = "About the Programmer"
        Me.btnProgrammer.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pbAbout)
        Me.GroupBox1.Controls.Add(Me.pbGhost)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 389)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 207)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Csound Ghost_Writer"
        '
        'pbAbout
        '
        Me.pbAbout.BackgroundImage = CType(resources.GetObject("pbAbout.BackgroundImage"), System.Drawing.Image)
        Me.pbAbout.Location = New System.Drawing.Point(75, 22)
        Me.pbAbout.Name = "pbAbout"
        Me.pbAbout.Size = New System.Drawing.Size(383, 173)
        Me.pbAbout.TabIndex = 5
        Me.pbAbout.TabStop = False
        '
        'pbGhost
        '
        Me.pbGhost.BackColor = System.Drawing.Color.Transparent
        Me.pbGhost.BackgroundImage = CType(resources.GetObject("pbGhost.BackgroundImage"), System.Drawing.Image)
        Me.pbGhost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbGhost.Location = New System.Drawing.Point(6, 22)
        Me.pbGhost.Name = "pbGhost"
        Me.pbGhost.Size = New System.Drawing.Size(63, 57)
        Me.pbGhost.TabIndex = 3
        Me.pbGhost.TabStop = False
        '
        'btnShrink
        '
        Me.btnShrink.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnShrink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShrink.Location = New System.Drawing.Point(674, 602)
        Me.btnShrink.Name = "btnShrink"
        Me.btnShrink.Size = New System.Drawing.Size(141, 23)
        Me.btnShrink.TabIndex = 7
        Me.btnShrink.Text = "Shrink About"
        Me.btnShrink.UseVisualStyleBackColor = False
        '
        'pbAuthor
        '
        Me.pbAuthor.BackgroundImage = Global.Csound_Ghost_Writer.My.Resources.Resources.bio2
        Me.pbAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAuthor.Location = New System.Drawing.Point(481, 13)
        Me.pbAuthor.Name = "pbAuthor"
        Me.pbAuthor.Size = New System.Drawing.Size(490, 583)
        Me.pbAuthor.TabIndex = 4
        Me.pbAuthor.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(464, 366)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(975, 636)
        Me.Controls.Add(Me.btnShrink)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbAuthor)
        Me.Controls.Add(Me.btnProgrammer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Csound Ghost_Writer    (v 1.14.1)"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGhost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAuthor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnProgrammer As System.Windows.Forms.Button
    Friend WithEvents pbGhost As System.Windows.Forms.PictureBox
    Friend WithEvents pbAuthor As System.Windows.Forms.PictureBox
    Friend WithEvents pbAbout As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShrink As System.Windows.Forms.Button
End Class
