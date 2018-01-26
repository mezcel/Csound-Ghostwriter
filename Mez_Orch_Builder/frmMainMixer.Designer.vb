<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMixer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMixer))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.trkbThresh = New System.Windows.Forms.TrackBar
        Me.txtThresh = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.trkbVol = New System.Windows.Forms.TrackBar
        Me.txtVol = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ckbReverb = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbMono = New System.Windows.Forms.RadioButton
        Me.rbStereo = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtReverbDensity = New System.Windows.Forms.TextBox
        Me.txtReverbTime = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.trkbReverbDensity = New System.Windows.Forms.TrackBar
        Me.Label8 = New System.Windows.Forms.Label
        Me.trkbReverbTime = New System.Windows.Forms.TrackBar
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkbThresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkbVol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.trkbReverbDensity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkbReverbTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.trkbThresh)
        Me.GroupBox1.Controls.Add(Me.txtThresh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.trkbVol)
        Me.GroupBox1.Controls.Add(Me.txtVol)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 277)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Master"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "1x"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(193, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "0x"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(193, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "2x"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox1.Location = New System.Drawing.Point(95, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 188)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(90, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "MIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(87, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "MAX"
        '
        'trkbThresh
        '
        Me.trkbThresh.LargeChange = 10
        Me.trkbThresh.Location = New System.Drawing.Point(155, 47)
        Me.trkbThresh.Maximum = 100
        Me.trkbThresh.Name = "trkbThresh"
        Me.trkbThresh.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkbThresh.Size = New System.Drawing.Size(42, 190)
        Me.trkbThresh.TabIndex = 2
        Me.trkbThresh.TickFrequency = 20
        '
        'txtThresh
        '
        Me.txtThresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThresh.Location = New System.Drawing.Point(139, 241)
        Me.txtThresh.Name = "txtThresh"
        Me.txtThresh.Size = New System.Drawing.Size(59, 26)
        Me.txtThresh.TabIndex = 2
        Me.txtThresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Volume"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Threshold"
        '
        'trkbVol
        '
        Me.trkbVol.Location = New System.Drawing.Point(25, 47)
        Me.trkbVol.Maximum = 100
        Me.trkbVol.Name = "trkbVol"
        Me.trkbVol.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkbVol.Size = New System.Drawing.Size(42, 190)
        Me.trkbVol.TabIndex = 1
        Me.trkbVol.TickFrequency = 10
        '
        'txtVol
        '
        Me.txtVol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVol.Location = New System.Drawing.Point(11, 243)
        Me.txtVol.Name = "txtVol"
        Me.txtVol.Size = New System.Drawing.Size(59, 26)
        Me.txtVol.TabIndex = 0
        Me.txtVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(309, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ckbReverb
        '
        Me.ckbReverb.AutoSize = True
        Me.ckbReverb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbReverb.Location = New System.Drawing.Point(6, 19)
        Me.ckbReverb.Name = "ckbReverb"
        Me.ckbReverb.Size = New System.Drawing.Size(79, 24)
        Me.ckbReverb.TabIndex = 2
        Me.ckbReverb.Text = "Reverb"
        Me.ckbReverb.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbMono)
        Me.GroupBox2.Controls.Add(Me.rbStereo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(269, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 55)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "R/L"
        '
        'rbMono
        '
        Me.rbMono.AutoSize = True
        Me.rbMono.Checked = True
        Me.rbMono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMono.ForeColor = System.Drawing.Color.DimGray
        Me.rbMono.Location = New System.Drawing.Point(87, 21)
        Me.rbMono.Name = "rbMono"
        Me.rbMono.Size = New System.Drawing.Size(67, 24)
        Me.rbMono.TabIndex = 8
        Me.rbMono.TabStop = True
        Me.rbMono.Text = "Mono"
        Me.rbMono.UseVisualStyleBackColor = True
        '
        'rbStereo
        '
        Me.rbStereo.AutoSize = True
        Me.rbStereo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStereo.ForeColor = System.Drawing.Color.Maroon
        Me.rbStereo.Location = New System.Drawing.Point(6, 19)
        Me.rbStereo.Name = "rbStereo"
        Me.rbStereo.Size = New System.Drawing.Size(75, 24)
        Me.rbStereo.TabIndex = 7
        Me.rbStereo.Text = "Stereo"
        Me.rbStereo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtReverbDensity)
        Me.GroupBox3.Controls.Add(Me.txtReverbTime)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.trkbReverbDensity)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.trkbReverbTime)
        Me.GroupBox3.Controls.Add(Me.ckbReverb)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(269, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(157, 217)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FX"
        '
        'txtReverbDensity
        '
        Me.txtReverbDensity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReverbDensity.Location = New System.Drawing.Point(93, 181)
        Me.txtReverbDensity.Name = "txtReverbDensity"
        Me.txtReverbDensity.Size = New System.Drawing.Size(42, 26)
        Me.txtReverbDensity.TabIndex = 13
        Me.txtReverbDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtReverbTime
        '
        Me.txtReverbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReverbTime.Location = New System.Drawing.Point(22, 181)
        Me.txtReverbTime.Name = "txtReverbTime"
        Me.txtReverbTime.Size = New System.Drawing.Size(42, 26)
        Me.txtReverbTime.TabIndex = 12
        Me.txtReverbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(83, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Density"
        '
        'trkbReverbDensity
        '
        Me.trkbReverbDensity.Location = New System.Drawing.Point(101, 64)
        Me.trkbReverbDensity.Name = "trkbReverbDensity"
        Me.trkbReverbDensity.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkbReverbDensity.Size = New System.Drawing.Size(42, 113)
        Me.trkbReverbDensity.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Time"
        '
        'trkbReverbTime
        '
        Me.trkbReverbTime.Location = New System.Drawing.Point(29, 66)
        Me.trkbReverbTime.Name = "trkbReverbTime"
        Me.trkbReverbTime.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkbReverbTime.Size = New System.Drawing.Size(42, 111)
        Me.trkbReverbTime.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(12, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(263, 18)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Implemented yet (Under Development!)"
        '
        'frmMainMixer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(436, 330)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainMixer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Mixer"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkbThresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkbVol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.trkbReverbDensity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkbReverbTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVol As System.Windows.Forms.TextBox
    Friend WithEvents trkbVol As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents trkbThresh As System.Windows.Forms.TrackBar
    Friend WithEvents txtThresh As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ckbReverb As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbMono As System.Windows.Forms.RadioButton
    Friend WithEvents rbStereo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents trkbReverbTime As System.Windows.Forms.TrackBar
    Friend WithEvents txtReverbDensity As System.Windows.Forms.TextBox
    Friend WithEvents txtReverbTime As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents trkbReverbDensity As System.Windows.Forms.TrackBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
