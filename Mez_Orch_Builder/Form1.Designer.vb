<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gboxWaveGen = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.btnWaveRemove = New System.Windows.Forms.Button
        Me.btnWaveAdd = New System.Windows.Forms.Button
        Me.btnWaveRear = New System.Windows.Forms.Button
        Me.btnWaveNext = New System.Windows.Forms.Button
        Me.txtWaveBase = New System.Windows.Forms.TextBox
        Me.txtWaveIndex = New System.Windows.Forms.TextBox
        Me.btnWavePrevious = New System.Windows.Forms.Button
        Me.btnWaveFront = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cbSynthSelect = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnRepeat = New System.Windows.Forms.Button
        Me.btnAbort = New System.Windows.Forms.Button
        Me.btnSingle = New System.Windows.Forms.Button
        Me.btnSample = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSec = New System.Windows.Forms.TextBox
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MidiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NoMidiLinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MidiControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MidiInputInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MidiInputsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewInstrumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PvsoscToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OscilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditCurrentFTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveInstrumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SampleRateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TopLevelMixerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.AMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WriteCSDFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WritecsdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WriteorcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GWriterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeveloperCreidsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.AditionalResourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Csound5TextEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VoiceToTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Python24 = New System.Windows.Forms.ToolStripMenuItem
        Me.InstallFromWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Csound5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnInternet = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.tabADSR = New System.Windows.Forms.TabPage
        Me.rbAdsrOff = New System.Windows.Forms.RadioButton
        Me.rbAdsrON = New System.Windows.Forms.RadioButton
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.HSDelay = New System.Windows.Forms.HScrollBar
        Me.txtRelease = New System.Windows.Forms.TextBox
        Me.VSSustain = New System.Windows.Forms.VScrollBar
        Me.txtSustain = New System.Windows.Forms.TextBox
        Me.VSRelease = New System.Windows.Forms.VScrollBar
        Me.txtDecay = New System.Windows.Forms.TextBox
        Me.VSDecay = New System.Windows.Forms.VScrollBar
        Me.txtAttack = New System.Windows.Forms.TextBox
        Me.VSAttack = New System.Windows.Forms.VScrollBar
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtDelay = New System.Windows.Forms.TextBox
        Me.tabFilter = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbHPOn = New System.Windows.Forms.RadioButton
        Me.rbHPOff = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbLpOn = New System.Windows.Forms.RadioButton
        Me.rbLpOff = New System.Windows.Forms.RadioButton
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.lowpassRes = New System.Windows.Forms.HScrollBar
        Me.lowpassCutoff = New System.Windows.Forms.HScrollBar
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TextBox29 = New System.Windows.Forms.TextBox
        Me.txtlpRes = New System.Windows.Forms.TextBox
        Me.txthpCut = New System.Windows.Forms.TextBox
        Me.TextBox21 = New System.Windows.Forms.TextBox
        Me.TextBox28 = New System.Windows.Forms.TextBox
        Me.TextBox22 = New System.Windows.Forms.TextBox
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.txtlpCut = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.hipassRes = New System.Windows.Forms.HScrollBar
        Me.hipassCutoff = New System.Windows.Forms.HScrollBar
        Me.txthpRes = New System.Windows.Forms.TextBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.picBox_HPLFO = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.picBox_LPLFO = New System.Windows.Forms.PictureBox
        Me.txtLFO_HP_Level = New System.Windows.Forms.TextBox
        Me.txtLFO_HP_Hz = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.tkbLFO_HP_Hz = New System.Windows.Forms.TrackBar
        Me.tkbLFO_HP_level = New System.Windows.Forms.TrackBar
        Me.txtLFO_HP_Shape = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.tkbLFO_HP_Shape = New System.Windows.Forms.TrackBar
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.txtLFO_LP_Level = New System.Windows.Forms.TextBox
        Me.txtLFO_LP_Hz = New System.Windows.Forms.TextBox
        Me.TextBox23 = New System.Windows.Forms.TextBox
        Me.TextBox24 = New System.Windows.Forms.TextBox
        Me.tkbLFO_LP_Hz = New System.Windows.Forms.TrackBar
        Me.tkbLFO_LP_level = New System.Windows.Forms.TrackBar
        Me.txtLFO_LP_Shape = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.tkbLFO_LP_Shape = New System.Windows.Forms.TrackBar
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ChangeBackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BlueBushToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MoonGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GreyCamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem24 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem25 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem26 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem27 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem28 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem29 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem30 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem31 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem32 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem33 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem34 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem35 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem36 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem37 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem38 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem39 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem40 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem41 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem42 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem43 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem44 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem45 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem46 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem47 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem48 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem49 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem50 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem51 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem52 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem53 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem54 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem55 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem56 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem57 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem58 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem59 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem60 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem61 = New System.Windows.Forms.ToolStripMenuItem
        Me.gboxWaveGen.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tabADSR.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFilter.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.picBox_HPLFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox_LPLFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbLFO_HP_Hz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbLFO_HP_level, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbLFO_HP_Shape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbLFO_LP_Hz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbLFO_LP_level, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbLFO_LP_Shape, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxWaveGen
        '
        Me.gboxWaveGen.BackColor = System.Drawing.Color.White
        Me.gboxWaveGen.Controls.Add(Me.TabControl1)
        Me.gboxWaveGen.Controls.Add(Me.btnWaveRemove)
        Me.gboxWaveGen.Controls.Add(Me.btnWaveAdd)
        Me.gboxWaveGen.Controls.Add(Me.btnWaveRear)
        Me.gboxWaveGen.Controls.Add(Me.btnWaveNext)
        Me.gboxWaveGen.Controls.Add(Me.txtWaveBase)
        Me.gboxWaveGen.Controls.Add(Me.txtWaveIndex)
        Me.gboxWaveGen.Controls.Add(Me.btnWavePrevious)
        Me.gboxWaveGen.Controls.Add(Me.btnWaveFront)
        Me.gboxWaveGen.Controls.Add(Me.Panel1)
        Me.gboxWaveGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxWaveGen.Font = New System.Drawing.Font("3x5", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxWaveGen.Location = New System.Drawing.Point(12, 62)
        Me.gboxWaveGen.Name = "gboxWaveGen"
        Me.gboxWaveGen.Size = New System.Drawing.Size(526, 260)
        Me.gboxWaveGen.TabIndex = 7
        Me.gboxWaveGen.TabStop = False
        Me.gboxWaveGen.Text = "Sound Wave Signal Generator"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(15, 69)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(497, 179)
        Me.TabControl1.TabIndex = 24
        '
        'btnWaveRemove
        '
        Me.btnWaveRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnWaveRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWaveRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWaveRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaveRemove.Location = New System.Drawing.Point(259, 31)
        Me.btnWaveRemove.Name = "btnWaveRemove"
        Me.btnWaveRemove.Size = New System.Drawing.Size(39, 21)
        Me.btnWaveRemove.TabIndex = 44
        Me.btnWaveRemove.Text = "Remove"
        Me.btnWaveRemove.UseVisualStyleBackColor = False
        '
        'btnWaveAdd
        '
        Me.btnWaveAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnWaveAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWaveAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWaveAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaveAdd.Location = New System.Drawing.Point(218, 31)
        Me.btnWaveAdd.Name = "btnWaveAdd"
        Me.btnWaveAdd.Size = New System.Drawing.Size(39, 21)
        Me.btnWaveAdd.TabIndex = 43
        Me.btnWaveAdd.Text = "Add"
        Me.btnWaveAdd.UseVisualStyleBackColor = False
        '
        'btnWaveRear
        '
        Me.btnWaveRear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnWaveRear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWaveRear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWaveRear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaveRear.Location = New System.Drawing.Point(186, 31)
        Me.btnWaveRear.Name = "btnWaveRear"
        Me.btnWaveRear.Size = New System.Drawing.Size(29, 21)
        Me.btnWaveRear.TabIndex = 40
        Me.btnWaveRear.Text = ">>"
        Me.btnWaveRear.UseVisualStyleBackColor = False
        '
        'btnWaveNext
        '
        Me.btnWaveNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnWaveNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWaveNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWaveNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaveNext.Location = New System.Drawing.Point(157, 31)
        Me.btnWaveNext.Name = "btnWaveNext"
        Me.btnWaveNext.Size = New System.Drawing.Size(29, 21)
        Me.btnWaveNext.TabIndex = 39
        Me.btnWaveNext.Text = ">"
        Me.btnWaveNext.UseVisualStyleBackColor = False
        '
        'txtWaveBase
        '
        Me.txtWaveBase.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtWaveBase.Cursor = System.Windows.Forms.Cursors.No
        Me.txtWaveBase.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaveBase.Location = New System.Drawing.Point(114, 31)
        Me.txtWaveBase.Name = "txtWaveBase"
        Me.txtWaveBase.ReadOnly = True
        Me.txtWaveBase.Size = New System.Drawing.Size(42, 21)
        Me.txtWaveBase.TabIndex = 42
        '
        'txtWaveIndex
        '
        Me.txtWaveIndex.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaveIndex.Location = New System.Drawing.Point(84, 31)
        Me.txtWaveIndex.Name = "txtWaveIndex"
        Me.txtWaveIndex.Size = New System.Drawing.Size(30, 21)
        Me.txtWaveIndex.TabIndex = 41
        Me.txtWaveIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnWavePrevious
        '
        Me.btnWavePrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnWavePrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWavePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWavePrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWavePrevious.Location = New System.Drawing.Point(54, 31)
        Me.btnWavePrevious.Name = "btnWavePrevious"
        Me.btnWavePrevious.Size = New System.Drawing.Size(29, 21)
        Me.btnWavePrevious.TabIndex = 38
        Me.btnWavePrevious.Text = "<"
        Me.btnWavePrevious.UseVisualStyleBackColor = False
        '
        'btnWaveFront
        '
        Me.btnWaveFront.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnWaveFront.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWaveFront.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWaveFront.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaveFront.Location = New System.Drawing.Point(25, 31)
        Me.btnWaveFront.Name = "btnWaveFront"
        Me.btnWaveFront.Size = New System.Drawing.Size(29, 21)
        Me.btnWaveFront.TabIndex = 37
        Me.btnWaveFront.Text = "<<"
        Me.btnWaveFront.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.cbSynthSelect)
        Me.Panel1.Location = New System.Drawing.Point(15, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 43)
        Me.Panel1.TabIndex = 46
        '
        'cbSynthSelect
        '
        Me.cbSynthSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbSynthSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.cbSynthSelect.BackColor = System.Drawing.Color.DimGray
        Me.cbSynthSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbSynthSelect.DropDownHeight = 200
        Me.cbSynthSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSynthSelect.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSynthSelect.ForeColor = System.Drawing.Color.MistyRose
        Me.cbSynthSelect.FormattingEnabled = True
        Me.cbSynthSelect.IntegralHeight = False
        Me.cbSynthSelect.Items.AddRange(New Object() {"pvsosc", "oscil"})
        Me.cbSynthSelect.Location = New System.Drawing.Point(289, 12)
        Me.cbSynthSelect.Name = "cbSynthSelect"
        Me.cbSynthSelect.Size = New System.Drawing.Size(201, 26)
        Me.cbSynthSelect.TabIndex = 45
        Me.cbSynthSelect.Text = " Synth Select"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnRepeat)
        Me.Panel2.Controls.Add(Me.btnAbort)
        Me.Panel2.Controls.Add(Me.btnSingle)
        Me.Panel2.Controls.Add(Me.btnSample)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtSec)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(15, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(497, 34)
        Me.Panel2.TabIndex = 26
        '
        'btnRepeat
        '
        Me.btnRepeat.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnRepeat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRepeat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRepeat.Location = New System.Drawing.Point(3, 4)
        Me.btnRepeat.Name = "btnRepeat"
        Me.btnRepeat.Size = New System.Drawing.Size(57, 25)
        Me.btnRepeat.TabIndex = 32
        Me.btnRepeat.Text = "Grain"
        Me.btnRepeat.UseVisualStyleBackColor = False
        '
        'btnAbort
        '
        Me.btnAbort.BackColor = System.Drawing.Color.Red
        Me.btnAbort.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAbort.Location = New System.Drawing.Point(275, 4)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(58, 25)
        Me.btnAbort.TabIndex = 34
        Me.btnAbort.Text = "Abort !"
        Me.btnAbort.UseVisualStyleBackColor = False
        '
        'btnSingle
        '
        Me.btnSingle.BackColor = System.Drawing.Color.Red
        Me.btnSingle.BackgroundImage = CType(resources.GetObject("btnSingle.BackgroundImage"), System.Drawing.Image)
        Me.btnSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSingle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSingle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSingle.Location = New System.Drawing.Point(54, 3)
        Me.btnSingle.Name = "btnSingle"
        Me.btnSingle.Size = New System.Drawing.Size(34, 27)
        Me.btnSingle.TabIndex = 33
        Me.btnSingle.UseVisualStyleBackColor = False
        '
        'btnSample
        '
        Me.btnSample.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnSample.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSample.ForeColor = System.Drawing.Color.Firebrick
        Me.btnSample.Location = New System.Drawing.Point(105, 4)
        Me.btnSample.Name = "btnSample"
        Me.btnSample.Size = New System.Drawing.Size(164, 25)
        Me.btnSample.TabIndex = 27
        Me.btnSample.Text = "Play Sound Clip"
        Me.btnSample.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Sustain Length:"
        '
        'txtSec
        '
        Me.txtSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec.Location = New System.Drawing.Point(458, 4)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(32, 24)
        Me.txtSec.TabIndex = 28
        Me.txtSec.Text = "1"
        Me.txtSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripSeparator4, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(36, 19)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.OpenToolStripMenuItem.Text = "&Export as .WAV"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SaveToolStripMenuItem.Text = "&Save .csd"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(147, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CloseToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'MidiToolStripMenuItem
        '
        Me.MidiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoMidiLinkToolStripMenuItem, Me.MidiControlToolStripMenuItem, Me.MidiInputInfoToolStripMenuItem})
        Me.MidiToolStripMenuItem.Name = "MidiToolStripMenuItem"
        Me.MidiToolStripMenuItem.Size = New System.Drawing.Size(39, 19)
        Me.MidiToolStripMenuItem.Text = "&Midi"
        '
        'NoMidiLinkToolStripMenuItem
        '
        Me.NoMidiLinkToolStripMenuItem.Checked = True
        Me.NoMidiLinkToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NoMidiLinkToolStripMenuItem.Name = "NoMidiLinkToolStripMenuItem"
        Me.NoMidiLinkToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.NoMidiLinkToolStripMenuItem.Text = "&No MIDI (Deactivate)"
        '
        'MidiControlToolStripMenuItem
        '
        Me.MidiControlToolStripMenuItem.Name = "MidiControlToolStripMenuItem"
        Me.MidiControlToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.MidiControlToolStripMenuItem.Text = "&Midi Control (Activate)"
        '
        'MidiInputInfoToolStripMenuItem
        '
        Me.MidiInputInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MidiInputsToolStripMenuItem})
        Me.MidiInputInfoToolStripMenuItem.Name = "MidiInputInfoToolStripMenuItem"
        Me.MidiInputInfoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.MidiInputInfoToolStripMenuItem.Text = "Notes on Midi Input"
        '
        'MidiInputsToolStripMenuItem
        '
        Me.MidiInputsToolStripMenuItem.Name = "MidiInputsToolStripMenuItem"
        Me.MidiInputsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.MidiInputsToolStripMenuItem.Text = "Midi Hardware Inputs"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewInstrumentToolStripMenuItem, Me.EditCurrentFTableToolStripMenuItem, Me.RemoveInstrumentToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(92, 19)
        Me.EditToolStripMenuItem.Text = "&Signal Source"
        '
        'NewInstrumentToolStripMenuItem
        '
        Me.NewInstrumentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PvsoscToolStripMenuItem, Me.OscilToolStripMenuItem})
        Me.NewInstrumentToolStripMenuItem.Image = CType(resources.GetObject("NewInstrumentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewInstrumentToolStripMenuItem.Name = "NewInstrumentToolStripMenuItem"
        Me.NewInstrumentToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.NewInstrumentToolStripMenuItem.Text = "&Add Additional Signal"
        '
        'PvsoscToolStripMenuItem
        '
        Me.PvsoscToolStripMenuItem.Name = "PvsoscToolStripMenuItem"
        Me.PvsoscToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.PvsoscToolStripMenuItem.Text = "&pvsosc"
        '
        'OscilToolStripMenuItem
        '
        Me.OscilToolStripMenuItem.Name = "OscilToolStripMenuItem"
        Me.OscilToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.OscilToolStripMenuItem.Text = "&oscil"
        '
        'EditCurrentFTableToolStripMenuItem
        '
        Me.EditCurrentFTableToolStripMenuItem.Name = "EditCurrentFTableToolStripMenuItem"
        Me.EditCurrentFTableToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.EditCurrentFTableToolStripMenuItem.Text = "&Edit current  f-Table"
        '
        'RemoveInstrumentToolStripMenuItem
        '
        Me.RemoveInstrumentToolStripMenuItem.Image = CType(resources.GetObject("RemoveInstrumentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveInstrumentToolStripMenuItem.Name = "RemoveInstrumentToolStripMenuItem"
        Me.RemoveInstrumentToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.RemoveInstrumentToolStripMenuItem.Text = "&Remove Selected Signal"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SampleRateToolStripMenuItem, Me.ToolStripSeparator2, Me.TopLevelMixerToolStripMenuItem, Me.ToolStripSeparator3, Me.AMToolStripMenuItem, Me.FMToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(107, 19)
        Me.ToolStripMenuItem1.Text = "&Render Settings"
        '
        'SampleRateToolStripMenuItem
        '
        Me.SampleRateToolStripMenuItem.Image = CType(resources.GetObject("SampleRateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SampleRateToolStripMenuItem.Name = "SampleRateToolStripMenuItem"
        Me.SampleRateToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SampleRateToolStripMenuItem.Text = "&Sample Rate"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(161, 6)
        '
        'TopLevelMixerToolStripMenuItem
        '
        Me.TopLevelMixerToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.TopLevelMixerToolStripMenuItem.Image = CType(resources.GetObject("TopLevelMixerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TopLevelMixerToolStripMenuItem.Name = "TopLevelMixerToolStripMenuItem"
        Me.TopLevelMixerToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TopLevelMixerToolStripMenuItem.Text = "&Top Level FX Mixer"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(161, 6)
        '
        'AMToolStripMenuItem
        '
        Me.AMToolStripMenuItem.Name = "AMToolStripMenuItem"
        Me.AMToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AMToolStripMenuItem.Text = "&AM Layering"
        '
        'FMToolStripMenuItem
        '
        Me.FMToolStripMenuItem.Checked = True
        Me.FMToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FMToolStripMenuItem.Name = "FMToolStripMenuItem"
        Me.FMToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FMToolStripMenuItem.Text = "&FM Layering"
        '
        'WriteCSDFileToolStripMenuItem
        '
        Me.WriteCSDFileToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen
        Me.WriteCSDFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WritecsdToolStripMenuItem, Me.WriteorcToolStripMenuItem})
        Me.WriteCSDFileToolStripMenuItem.Name = "WriteCSDFileToolStripMenuItem"
        Me.WriteCSDFileToolStripMenuItem.Size = New System.Drawing.Size(138, 19)
        Me.WriteCSDFileToolStripMenuItem.Text = "&View Embedded Data"
        '
        'WritecsdToolStripMenuItem
        '
        Me.WritecsdToolStripMenuItem.Image = CType(resources.GetObject("WritecsdToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WritecsdToolStripMenuItem.Name = "WritecsdToolStripMenuItem"
        Me.WritecsdToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.WritecsdToolStripMenuItem.Text = "View .csd file"
        '
        'WriteorcToolStripMenuItem
        '
        Me.WriteorcToolStripMenuItem.Image = CType(resources.GetObject("WriteorcToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WriteorcToolStripMenuItem.Name = "WriteorcToolStripMenuItem"
        Me.WriteorcToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.WriteorcToolStripMenuItem.Text = "View data array"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(43, 19)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.Image = CType(resources.GetObject("BackgroundToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.BackgroundToolStripMenuItem.Text = "Csound &Background (.txt)"
        '
        'GWriterToolStripMenuItem
        '
        Me.GWriterToolStripMenuItem.Image = CType(resources.GetObject("GWriterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GWriterToolStripMenuItem.Name = "GWriterToolStripMenuItem"
        Me.GWriterToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.GWriterToolStripMenuItem.Text = "&GhostWriter General Info (.txt)"
        '
        'DeveloperCreidsToolStripMenuItem
        '
        Me.DeveloperCreidsToolStripMenuItem.Image = CType(resources.GetObject("DeveloperCreidsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeveloperCreidsToolStripMenuItem.Name = "DeveloperCreidsToolStripMenuItem"
        Me.DeveloperCreidsToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.DeveloperCreidsToolStripMenuItem.Text = "&About"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(242, 6)
        '
        'AditionalResourcesToolStripMenuItem
        '
        Me.AditionalResourcesToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.AditionalResourcesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Csound5TextEditorToolStripMenuItem, Me.CalculatorToolStripMenuItem, Me.VoiceToTextToolStripMenuItem})
        Me.AditionalResourcesToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AditionalResourcesToolStripMenuItem.Name = "AditionalResourcesToolStripMenuItem"
        Me.AditionalResourcesToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.AditionalResourcesToolStripMenuItem.Text = "Aditional Resources"
        '
        'Csound5TextEditorToolStripMenuItem
        '
        Me.Csound5TextEditorToolStripMenuItem.Name = "Csound5TextEditorToolStripMenuItem"
        Me.Csound5TextEditorToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.Csound5TextEditorToolStripMenuItem.Text = "Csound5 Text Editor"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'VoiceToTextToolStripMenuItem
        '
        Me.VoiceToTextToolStripMenuItem.Name = "VoiceToTextToolStripMenuItem"
        Me.VoiceToTextToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.VoiceToTextToolStripMenuItem.Text = "Voice to Text"
        '
        'Python24
        '
        Me.Python24.BackColor = System.Drawing.Color.Gold
        Me.Python24.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstallFromWebToolStripMenuItem, Me.Csound5ToolStripMenuItem})
        Me.Python24.Name = "Python24"
        Me.Python24.Size = New System.Drawing.Size(72, 19)
        Me.Python24.Text = "Python24"
        '
        'InstallFromWebToolStripMenuItem
        '
        Me.InstallFromWebToolStripMenuItem.Name = "InstallFromWebToolStripMenuItem"
        Me.InstallFromWebToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.InstallFromWebToolStripMenuItem.Text = "install Python24  from web"
        '
        'Csound5ToolStripMenuItem
        '
        Me.Csound5ToolStripMenuItem.Name = "Csound5ToolStripMenuItem"
        Me.Csound5ToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.Csound5ToolStripMenuItem.Text = "if Csound5 is not installed, do it now"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnInternet
        '
        Me.btnInternet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnInternet.Image = CType(resources.GetObject("btnInternet.Image"), System.Drawing.Image)
        Me.btnInternet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInternet.Name = "btnInternet"
        Me.btnInternet.Size = New System.Drawing.Size(23, 22)
        Me.btnInternet.Text = "Michael Jerome Todd on the WEB"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Ghost_Writer and CSound Resources"
        '
        'TabControl2
        '
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl2.Controls.Add(Me.tabADSR)
        Me.TabControl2.Controls.Add(Me.tabFilter)
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(15, 21)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(497, 240)
        Me.TabControl2.TabIndex = 26
        '
        'tabADSR
        '
        Me.tabADSR.BackColor = System.Drawing.Color.Beige
        Me.tabADSR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabADSR.Controls.Add(Me.rbAdsrOff)
        Me.tabADSR.Controls.Add(Me.rbAdsrON)
        Me.tabADSR.Controls.Add(Me.TextBox15)
        Me.tabADSR.Controls.Add(Me.TextBox14)
        Me.tabADSR.Controls.Add(Me.TextBox13)
        Me.tabADSR.Controls.Add(Me.TextBox12)
        Me.tabADSR.Controls.Add(Me.TextBox10)
        Me.tabADSR.Controls.Add(Me.HSDelay)
        Me.tabADSR.Controls.Add(Me.txtRelease)
        Me.tabADSR.Controls.Add(Me.VSSustain)
        Me.tabADSR.Controls.Add(Me.txtSustain)
        Me.tabADSR.Controls.Add(Me.VSRelease)
        Me.tabADSR.Controls.Add(Me.txtDecay)
        Me.tabADSR.Controls.Add(Me.VSDecay)
        Me.tabADSR.Controls.Add(Me.txtAttack)
        Me.tabADSR.Controls.Add(Me.VSAttack)
        Me.tabADSR.Controls.Add(Me.PictureBox1)
        Me.tabADSR.Controls.Add(Me.txtDelay)
        Me.tabADSR.Location = New System.Drawing.Point(4, 30)
        Me.tabADSR.Name = "tabADSR"
        Me.tabADSR.Padding = New System.Windows.Forms.Padding(3)
        Me.tabADSR.Size = New System.Drawing.Size(489, 206)
        Me.tabADSR.TabIndex = 1
        Me.tabADSR.Text = "ADSR"
        '
        'rbAdsrOff
        '
        Me.rbAdsrOff.AutoSize = True
        Me.rbAdsrOff.BackColor = System.Drawing.Color.Beige
        Me.rbAdsrOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbAdsrOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbAdsrOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdsrOff.Location = New System.Drawing.Point(254, 9)
        Me.rbAdsrOff.Name = "rbAdsrOff"
        Me.rbAdsrOff.Size = New System.Drawing.Size(129, 24)
        Me.rbAdsrOff.TabIndex = 18
        Me.rbAdsrOff.Text = "ADSR Reset"
        Me.rbAdsrOff.UseVisualStyleBackColor = False
        '
        'rbAdsrON
        '
        Me.rbAdsrON.AutoSize = True
        Me.rbAdsrON.BackColor = System.Drawing.Color.Beige
        Me.rbAdsrON.Checked = True
        Me.rbAdsrON.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbAdsrON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbAdsrON.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdsrON.Location = New System.Drawing.Point(100, 9)
        Me.rbAdsrON.Name = "rbAdsrON"
        Me.rbAdsrON.Size = New System.Drawing.Size(142, 24)
        Me.rbAdsrON.TabIndex = 17
        Me.rbAdsrON.TabStop = True
        Me.rbAdsrON.Text = "ADSR Custom"
        Me.rbAdsrON.UseVisualStyleBackColor = False
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox15.Location = New System.Drawing.Point(129, 170)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(51, 26)
        Me.TextBox15.TabIndex = 16
        Me.TextBox15.Text = "Delay"
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.Beige
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(358, 39)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(58, 19)
        Me.TextBox14.TabIndex = 15
        Me.TextBox14.Text = "Sustain"
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.Beige
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(422, 39)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(63, 19)
        Me.TextBox13.TabIndex = 14
        Me.TextBox13.Text = "Release"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.Beige
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(62, 39)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(51, 19)
        Me.TextBox12.TabIndex = 13
        Me.TextBox12.Text = "Decay"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Beige
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(5, 39)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(51, 19)
        Me.TextBox10.TabIndex = 12
        Me.TextBox10.Text = "Attack"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HSDelay
        '
        Me.HSDelay.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.HSDelay.Location = New System.Drawing.Point(183, 170)
        Me.HSDelay.Name = "HSDelay"
        Me.HSDelay.Size = New System.Drawing.Size(137, 22)
        Me.HSDelay.TabIndex = 11
        '
        'txtRelease
        '
        Me.txtRelease.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRelease.Location = New System.Drawing.Point(440, 170)
        Me.txtRelease.Name = "txtRelease"
        Me.txtRelease.Size = New System.Drawing.Size(31, 24)
        Me.txtRelease.TabIndex = 10
        Me.txtRelease.Text = "0"
        Me.txtRelease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VSSustain
        '
        Me.VSSustain.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.VSSustain.LargeChange = 1
        Me.VSSustain.Location = New System.Drawing.Point(373, 64)
        Me.VSSustain.Maximum = 0
        Me.VSSustain.Minimum = -100
        Me.VSSustain.Name = "VSSustain"
        Me.VSSustain.Size = New System.Drawing.Size(31, 103)
        Me.VSSustain.TabIndex = 9
        '
        'txtSustain
        '
        Me.txtSustain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSustain.Location = New System.Drawing.Point(373, 170)
        Me.txtSustain.Name = "txtSustain"
        Me.txtSustain.Size = New System.Drawing.Size(31, 23)
        Me.txtSustain.TabIndex = 8
        Me.txtSustain.Text = "0"
        Me.txtSustain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VSRelease
        '
        Me.VSRelease.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.VSRelease.LargeChange = 1
        Me.VSRelease.Location = New System.Drawing.Point(440, 64)
        Me.VSRelease.Maximum = 0
        Me.VSRelease.Minimum = -75
        Me.VSRelease.Name = "VSRelease"
        Me.VSRelease.Size = New System.Drawing.Size(31, 103)
        Me.VSRelease.TabIndex = 7
        '
        'txtDecay
        '
        Me.txtDecay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecay.Location = New System.Drawing.Point(72, 170)
        Me.txtDecay.Name = "txtDecay"
        Me.txtDecay.Size = New System.Drawing.Size(31, 23)
        Me.txtDecay.TabIndex = 6
        Me.txtDecay.Text = "0"
        Me.txtDecay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VSDecay
        '
        Me.VSDecay.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.VSDecay.LargeChange = 1
        Me.VSDecay.Location = New System.Drawing.Point(72, 64)
        Me.VSDecay.Maximum = 0
        Me.VSDecay.Minimum = -150
        Me.VSDecay.Name = "VSDecay"
        Me.VSDecay.Size = New System.Drawing.Size(31, 100)
        Me.VSDecay.TabIndex = 5
        '
        'txtAttack
        '
        Me.txtAttack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttack.Location = New System.Drawing.Point(14, 170)
        Me.txtAttack.Name = "txtAttack"
        Me.txtAttack.Size = New System.Drawing.Size(31, 23)
        Me.txtAttack.TabIndex = 4
        Me.txtAttack.Text = "0"
        Me.txtAttack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VSAttack
        '
        Me.VSAttack.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.VSAttack.LargeChange = 1
        Me.VSAttack.Location = New System.Drawing.Point(14, 64)
        Me.VSAttack.Maximum = 0
        Me.VSAttack.Minimum = -100
        Me.VSAttack.Name = "VSAttack"
        Me.VSAttack.Size = New System.Drawing.Size(31, 100)
        Me.VSAttack.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(125, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txtDelay
        '
        Me.txtDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelay.Location = New System.Drawing.Point(323, 170)
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(31, 23)
        Me.txtDelay.TabIndex = 1
        Me.txtDelay.Text = "n/a"
        Me.txtDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tabFilter
        '
        Me.tabFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabFilter.Controls.Add(Me.GroupBox2)
        Me.tabFilter.Controls.Add(Me.GroupBox1)
        Me.tabFilter.Controls.Add(Me.PictureBox3)
        Me.tabFilter.Controls.Add(Me.lowpassRes)
        Me.tabFilter.Controls.Add(Me.lowpassCutoff)
        Me.tabFilter.Controls.Add(Me.PictureBox2)
        Me.tabFilter.Controls.Add(Me.TextBox29)
        Me.tabFilter.Controls.Add(Me.txtlpRes)
        Me.tabFilter.Controls.Add(Me.txthpCut)
        Me.tabFilter.Controls.Add(Me.TextBox21)
        Me.tabFilter.Controls.Add(Me.TextBox28)
        Me.tabFilter.Controls.Add(Me.TextBox22)
        Me.tabFilter.Controls.Add(Me.TextBox17)
        Me.tabFilter.Controls.Add(Me.txtlpCut)
        Me.tabFilter.Controls.Add(Me.TextBox16)
        Me.tabFilter.Controls.Add(Me.hipassRes)
        Me.tabFilter.Controls.Add(Me.hipassCutoff)
        Me.tabFilter.Controls.Add(Me.txthpRes)
        Me.tabFilter.Location = New System.Drawing.Point(4, 30)
        Me.tabFilter.Name = "tabFilter"
        Me.tabFilter.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFilter.Size = New System.Drawing.Size(489, 206)
        Me.tabFilter.TabIndex = 0
        Me.tabFilter.Text = "Reson Filter"
        Me.tabFilter.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbHPOn)
        Me.GroupBox2.Controls.Add(Me.rbHPOff)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(252, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 36)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Activate High Pass"
        '
        'rbHPOn
        '
        Me.rbHPOn.AutoSize = True
        Me.rbHPOn.BackColor = System.Drawing.SystemColors.Control
        Me.rbHPOn.Checked = True
        Me.rbHPOn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbHPOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHPOn.Location = New System.Drawing.Point(111, 15)
        Me.rbHPOn.Name = "rbHPOn"
        Me.rbHPOn.Size = New System.Drawing.Size(45, 19)
        Me.rbHPOn.TabIndex = 43
        Me.rbHPOn.TabStop = True
        Me.rbHPOn.Text = "ON"
        Me.rbHPOn.UseVisualStyleBackColor = False
        '
        'rbHPOff
        '
        Me.rbHPOff.AutoSize = True
        Me.rbHPOff.BackColor = System.Drawing.SystemColors.Control
        Me.rbHPOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbHPOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHPOff.Location = New System.Drawing.Point(163, 15)
        Me.rbHPOff.Name = "rbHPOff"
        Me.rbHPOff.Size = New System.Drawing.Size(51, 19)
        Me.rbHPOff.TabIndex = 44
        Me.rbHPOff.Text = "OFF"
        Me.rbHPOff.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbLpOn)
        Me.GroupBox1.Controls.Add(Me.rbLpOff)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 36)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Activate Low Pass"
        '
        'rbLpOn
        '
        Me.rbLpOn.AutoSize = True
        Me.rbLpOn.BackColor = System.Drawing.SystemColors.Control
        Me.rbLpOn.Checked = True
        Me.rbLpOn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbLpOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLpOn.Location = New System.Drawing.Point(113, 15)
        Me.rbLpOn.Name = "rbLpOn"
        Me.rbLpOn.Size = New System.Drawing.Size(45, 19)
        Me.rbLpOn.TabIndex = 43
        Me.rbLpOn.TabStop = True
        Me.rbLpOn.Text = "ON"
        Me.rbLpOn.UseVisualStyleBackColor = False
        '
        'rbLpOff
        '
        Me.rbLpOff.AutoSize = True
        Me.rbLpOff.BackColor = System.Drawing.SystemColors.Control
        Me.rbLpOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbLpOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLpOff.Location = New System.Drawing.Point(165, 15)
        Me.rbLpOff.Name = "rbLpOff"
        Me.rbLpOff.Size = New System.Drawing.Size(51, 19)
        Me.rbLpOff.TabIndex = 44
        Me.rbLpOff.Text = "OFF"
        Me.rbLpOff.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox3.Location = New System.Drawing.Point(8, 45)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(227, 64)
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'lowpassRes
        '
        Me.lowpassRes.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.lowpassRes.Location = New System.Drawing.Point(87, 175)
        Me.lowpassRes.Maximum = 230
        Me.lowpassRes.Name = "lowpassRes"
        Me.lowpassRes.Size = New System.Drawing.Size(95, 22)
        Me.lowpassRes.TabIndex = 38
        '
        'lowpassCutoff
        '
        Me.lowpassCutoff.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.lowpassCutoff.Location = New System.Drawing.Point(87, 143)
        Me.lowpassCutoff.Maximum = 230
        Me.lowpassCutoff.Name = "lowpassCutoff"
        Me.lowpassCutoff.Size = New System.Drawing.Size(95, 22)
        Me.lowpassCutoff.TabIndex = 37
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox2.Location = New System.Drawing.Point(252, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(227, 64)
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'TextBox29
        '
        Me.TextBox29.BackColor = System.Drawing.Color.Silver
        Me.TextBox29.Location = New System.Drawing.Point(8, 114)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(227, 26)
        Me.TextBox29.TabIndex = 36
        Me.TextBox29.Text = "Low Pass"
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlpRes
        '
        Me.txtlpRes.Location = New System.Drawing.Point(185, 175)
        Me.txtlpRes.Name = "txtlpRes"
        Me.txtlpRes.Size = New System.Drawing.Size(50, 26)
        Me.txtlpRes.TabIndex = 27
        Me.txtlpRes.Text = "0"
        Me.txtlpRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txthpCut
        '
        Me.txthpCut.Location = New System.Drawing.Point(430, 143)
        Me.txthpCut.Name = "txthpCut"
        Me.txthpCut.Size = New System.Drawing.Size(49, 26)
        Me.txthpCut.TabIndex = 15
        Me.txthpCut.Text = "0"
        Me.txthpCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.Location = New System.Drawing.Point(8, 175)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(76, 22)
        Me.TextBox21.TabIndex = 25
        Me.TextBox21.Text = "Resonance"
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox28
        '
        Me.TextBox28.BackColor = System.Drawing.Color.Silver
        Me.TextBox28.Location = New System.Drawing.Point(252, 114)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(227, 26)
        Me.TextBox28.TabIndex = 35
        Me.TextBox28.Text = "High Pass"
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.Location = New System.Drawing.Point(8, 143)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(76, 22)
        Me.TextBox22.TabIndex = 24
        Me.TextBox22.Text = "Cutoff"
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(252, 143)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(76, 22)
        Me.TextBox17.TabIndex = 18
        Me.TextBox17.Text = "Cutoff"
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlpCut
        '
        Me.txtlpCut.Location = New System.Drawing.Point(185, 143)
        Me.txtlpCut.Name = "txtlpCut"
        Me.txtlpCut.Size = New System.Drawing.Size(50, 26)
        Me.txtlpCut.TabIndex = 23
        Me.txtlpCut.Text = "0"
        Me.txtlpCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(252, 175)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(76, 22)
        Me.TextBox16.TabIndex = 19
        Me.TextBox16.Text = "Resonance"
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hipassRes
        '
        Me.hipassRes.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.hipassRes.Location = New System.Drawing.Point(332, 175)
        Me.hipassRes.Maximum = 230
        Me.hipassRes.Name = "hipassRes"
        Me.hipassRes.Size = New System.Drawing.Size(95, 22)
        Me.hipassRes.TabIndex = 22
        '
        'hipassCutoff
        '
        Me.hipassCutoff.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.hipassCutoff.Location = New System.Drawing.Point(332, 143)
        Me.hipassCutoff.Maximum = 230
        Me.hipassCutoff.Name = "hipassCutoff"
        Me.hipassCutoff.Size = New System.Drawing.Size(95, 22)
        Me.hipassCutoff.TabIndex = 20
        '
        'txthpRes
        '
        Me.txthpRes.Location = New System.Drawing.Point(430, 175)
        Me.txthpRes.Name = "txthpRes"
        Me.txthpRes.Size = New System.Drawing.Size(49, 26)
        Me.txthpRes.TabIndex = 21
        Me.txthpRes.Text = "0"
        Me.txthpRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.picBox_HPLFO)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.picBox_LPLFO)
        Me.TabPage1.Controls.Add(Me.txtLFO_HP_Level)
        Me.TabPage1.Controls.Add(Me.txtLFO_HP_Hz)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox4)
        Me.TabPage1.Controls.Add(Me.tkbLFO_HP_Hz)
        Me.TabPage1.Controls.Add(Me.tkbLFO_HP_level)
        Me.TabPage1.Controls.Add(Me.txtLFO_HP_Shape)
        Me.TabPage1.Controls.Add(Me.TextBox7)
        Me.TabPage1.Controls.Add(Me.tkbLFO_HP_Shape)
        Me.TabPage1.Controls.Add(Me.TextBox18)
        Me.TabPage1.Controls.Add(Me.txtLFO_LP_Level)
        Me.TabPage1.Controls.Add(Me.txtLFO_LP_Hz)
        Me.TabPage1.Controls.Add(Me.TextBox23)
        Me.TabPage1.Controls.Add(Me.TextBox24)
        Me.TabPage1.Controls.Add(Me.tkbLFO_LP_Hz)
        Me.TabPage1.Controls.Add(Me.tkbLFO_LP_level)
        Me.TabPage1.Controls.Add(Me.txtLFO_LP_Shape)
        Me.TabPage1.Controls.Add(Me.TextBox11)
        Me.TabPage1.Controls.Add(Me.tkbLFO_LP_Shape)
        Me.TabPage1.Controls.Add(Me.TextBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(489, 206)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Filter LFO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(175, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "HP: Shape"
        '
        'picBox_HPLFO
        '
        Me.picBox_HPLFO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBox_HPLFO.Location = New System.Drawing.Point(176, 123)
        Me.picBox_HPLFO.Name = "picBox_HPLFO"
        Me.picBox_HPLFO.Size = New System.Drawing.Size(137, 46)
        Me.picBox_HPLFO.TabIndex = 50
        Me.picBox_HPLFO.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(175, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "LP: Shape"
        '
        'picBox_LPLFO
        '
        Me.picBox_LPLFO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBox_LPLFO.Location = New System.Drawing.Point(176, 56)
        Me.picBox_LPLFO.Name = "picBox_LPLFO"
        Me.picBox_LPLFO.Size = New System.Drawing.Size(137, 46)
        Me.picBox_LPLFO.TabIndex = 47
        Me.picBox_LPLFO.TabStop = False
        '
        'txtLFO_HP_Level
        '
        Me.txtLFO_HP_Level.Location = New System.Drawing.Point(321, 44)
        Me.txtLFO_HP_Level.Name = "txtLFO_HP_Level"
        Me.txtLFO_HP_Level.Size = New System.Drawing.Size(50, 26)
        Me.txtLFO_HP_Level.TabIndex = 46
        Me.txtLFO_HP_Level.Text = "0"
        Me.txtLFO_HP_Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLFO_HP_Hz
        '
        Me.txtLFO_HP_Hz.Location = New System.Drawing.Point(378, 44)
        Me.txtLFO_HP_Hz.Name = "txtLFO_HP_Hz"
        Me.txtLFO_HP_Hz.Size = New System.Drawing.Size(50, 26)
        Me.txtLFO_HP_Hz.TabIndex = 45
        Me.txtLFO_HP_Hz.Text = "0"
        Me.txtLFO_HP_Hz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(321, 172)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(50, 25)
        Me.TextBox3.TabIndex = 44
        Me.TextBox3.Text = "Level"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(378, 172)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(50, 25)
        Me.TextBox4.TabIndex = 43
        Me.TextBox4.Text = "Speed"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tkbLFO_HP_Hz
        '
        Me.tkbLFO_HP_Hz.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.tkbLFO_HP_Hz.Location = New System.Drawing.Point(385, 65)
        Me.tkbLFO_HP_Hz.Minimum = 1
        Me.tkbLFO_HP_Hz.Name = "tkbLFO_HP_Hz"
        Me.tkbLFO_HP_Hz.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tkbLFO_HP_Hz.Size = New System.Drawing.Size(42, 104)
        Me.tkbLFO_HP_Hz.TabIndex = 42
        Me.tkbLFO_HP_Hz.Value = 1
        '
        'tkbLFO_HP_level
        '
        Me.tkbLFO_HP_level.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.tkbLFO_HP_level.Location = New System.Drawing.Point(330, 65)
        Me.tkbLFO_HP_level.Name = "tkbLFO_HP_level"
        Me.tkbLFO_HP_level.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tkbLFO_HP_level.Size = New System.Drawing.Size(42, 104)
        Me.tkbLFO_HP_level.TabIndex = 41
        '
        'txtLFO_HP_Shape
        '
        Me.txtLFO_HP_Shape.Location = New System.Drawing.Point(433, 44)
        Me.txtLFO_HP_Shape.Name = "txtLFO_HP_Shape"
        Me.txtLFO_HP_Shape.Size = New System.Drawing.Size(50, 26)
        Me.txtLFO_HP_Shape.TabIndex = 40
        Me.txtLFO_HP_Shape.Text = "0"
        Me.txtLFO_HP_Shape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(433, 172)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(50, 25)
        Me.TextBox7.TabIndex = 39
        Me.TextBox7.Text = "Shape"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tkbLFO_HP_Shape
        '
        Me.tkbLFO_HP_Shape.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.tkbLFO_HP_Shape.LargeChange = 1
        Me.tkbLFO_HP_Shape.Location = New System.Drawing.Point(440, 65)
        Me.tkbLFO_HP_Shape.Maximum = 5
        Me.tkbLFO_HP_Shape.Name = "tkbLFO_HP_Shape"
        Me.tkbLFO_HP_Shape.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tkbLFO_HP_Shape.Size = New System.Drawing.Size(42, 104)
        Me.tkbLFO_HP_Shape.TabIndex = 38
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox18.Location = New System.Drawing.Point(5, 13)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(162, 26)
        Me.TextBox18.TabIndex = 37
        Me.TextBox18.Text = "LP Filter"
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLFO_LP_Level
        '
        Me.txtLFO_LP_Level.Location = New System.Drawing.Point(5, 44)
        Me.txtLFO_LP_Level.Name = "txtLFO_LP_Level"
        Me.txtLFO_LP_Level.Size = New System.Drawing.Size(50, 26)
        Me.txtLFO_LP_Level.TabIndex = 36
        Me.txtLFO_LP_Level.Text = "0"
        Me.txtLFO_LP_Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLFO_LP_Hz
        '
        Me.txtLFO_LP_Hz.Location = New System.Drawing.Point(62, 44)
        Me.txtLFO_LP_Hz.Name = "txtLFO_LP_Hz"
        Me.txtLFO_LP_Hz.Size = New System.Drawing.Size(50, 26)
        Me.txtLFO_LP_Hz.TabIndex = 35
        Me.txtLFO_LP_Hz.Text = "0"
        Me.txtLFO_LP_Hz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox23
        '
        Me.TextBox23.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox23.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.Location = New System.Drawing.Point(5, 172)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(50, 25)
        Me.TextBox23.TabIndex = 34
        Me.TextBox23.Text = "Level"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox24
        '
        Me.TextBox24.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox24.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox24.Location = New System.Drawing.Point(62, 172)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(50, 25)
        Me.TextBox24.TabIndex = 33
        Me.TextBox24.Text = "Speed"
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tkbLFO_LP_Hz
        '
        Me.tkbLFO_LP_Hz.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.tkbLFO_LP_Hz.Location = New System.Drawing.Point(69, 65)
        Me.tkbLFO_LP_Hz.Minimum = 1
        Me.tkbLFO_LP_Hz.Name = "tkbLFO_LP_Hz"
        Me.tkbLFO_LP_Hz.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tkbLFO_LP_Hz.Size = New System.Drawing.Size(42, 104)
        Me.tkbLFO_LP_Hz.TabIndex = 32
        Me.tkbLFO_LP_Hz.Value = 1
        '
        'tkbLFO_LP_level
        '
        Me.tkbLFO_LP_level.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.tkbLFO_LP_level.Location = New System.Drawing.Point(14, 65)
        Me.tkbLFO_LP_level.Name = "tkbLFO_LP_level"
        Me.tkbLFO_LP_level.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tkbLFO_LP_level.Size = New System.Drawing.Size(42, 104)
        Me.tkbLFO_LP_level.TabIndex = 31
        '
        'txtLFO_LP_Shape
        '
        Me.txtLFO_LP_Shape.Location = New System.Drawing.Point(117, 44)
        Me.txtLFO_LP_Shape.Name = "txtLFO_LP_Shape"
        Me.txtLFO_LP_Shape.Size = New System.Drawing.Size(50, 26)
        Me.txtLFO_LP_Shape.TabIndex = 28
        Me.txtLFO_LP_Shape.Text = "0"
        Me.txtLFO_LP_Shape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(117, 172)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(50, 25)
        Me.TextBox11.TabIndex = 26
        Me.TextBox11.Text = "Shape"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tkbLFO_LP_Shape
        '
        Me.tkbLFO_LP_Shape.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.tkbLFO_LP_Shape.LargeChange = 1
        Me.tkbLFO_LP_Shape.Location = New System.Drawing.Point(124, 65)
        Me.tkbLFO_LP_Shape.Maximum = 5
        Me.tkbLFO_LP_Shape.Name = "tkbLFO_LP_Shape"
        Me.tkbLFO_LP_Shape.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tkbLFO_LP_Shape.Size = New System.Drawing.Size(42, 104)
        Me.tkbLFO_LP_Shape.TabIndex = 25
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox5.Location = New System.Drawing.Point(321, 13)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(163, 26)
        Me.TextBox5.TabIndex = 23
        Me.TextBox5.Text = "HP FIlter"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.TabControl2)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("1900.80.5", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.GroupBox4.Location = New System.Drawing.Point(12, 400)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(526, 273)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "/DSP/   Envelope - Filter - LFO"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.Panel2)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Font = New System.Drawing.Font("3x5", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 328)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(526, 66)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Rendering"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox4.Location = New System.Drawing.Point(544, 328)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(158, 345)
        Me.PictureBox4.TabIndex = 32
        Me.PictureBox4.TabStop = False
        '
        'Timer1
        '
        '
        'ChangeBackgroundToolStripMenuItem
        '
        Me.ChangeBackgroundToolStripMenuItem.Name = "ChangeBackgroundToolStripMenuItem"
        Me.ChangeBackgroundToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.ChangeBackgroundToolStripMenuItem.Text = "Change Background"
        '
        'BlueBushToolStripMenuItem
        '
        Me.BlueBushToolStripMenuItem.Name = "BlueBushToolStripMenuItem"
        Me.BlueBushToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BlueBushToolStripMenuItem.Text = "Blue Bush"
        '
        'MoonGridToolStripMenuItem
        '
        Me.MoonGridToolStripMenuItem.Name = "MoonGridToolStripMenuItem"
        Me.MoonGridToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MoonGridToolStripMenuItem.Text = "Moon Grid"
        '
        'GreyCamoToolStripMenuItem
        '
        Me.GreyCamoToolStripMenuItem.Name = "GreyCamoToolStripMenuItem"
        Me.GreyCamoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GreyCamoToolStripMenuItem.Text = "Grey Camo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripSeparator6, Me.ToolStripMenuItem5})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(36, 19)
        Me.ToolStripMenuItem2.Text = "&File"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItem3.Text = "&Export as .WAV"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItem4.Text = "&Save .csd"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(147, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItem5.Text = "&Close"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9})
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(39, 19)
        Me.ToolStripMenuItem6.Text = "&Midi"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Checked = True
        Me.ToolStripMenuItem7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem7.Text = "&No MIDI (Deactivate)"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem8.Text = "&Midi Control (Activate)"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem10})
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem9.Text = "Notes on Midi Input"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem10.Text = "Midi Hardware Inputs"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem12, Me.ToolStripMenuItem15, Me.ToolStripMenuItem16})
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(94, 19)
        Me.ToolStripMenuItem11.Text = "&Signal Setting"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem13, Me.ToolStripMenuItem14})
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItem12.Text = "&Add Additional Signal"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripMenuItem13.Text = "&pvsosc"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripMenuItem14.Text = "&oscil"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItem15.Text = "&Edit current  f-Table"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItem16.Text = "&Remove Selected Signal"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem18, Me.ToolStripSeparator7, Me.ToolStripMenuItem19, Me.ToolStripSeparator8, Me.ToolStripMenuItem20, Me.ToolStripMenuItem21})
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(107, 19)
        Me.ToolStripMenuItem17.Text = "&Render Settings"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem18.Text = "&Sample Rate"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(161, 6)
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem19.Text = "&Top Level FX Mixer"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(161, 6)
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem20.Text = "&AM Layering"
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.Checked = True
        Me.ToolStripMenuItem21.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem21.Text = "&FM Layering"
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.BackColor = System.Drawing.Color.PaleGreen
        Me.ToolStripMenuItem22.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem23, Me.ToolStripMenuItem24})
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(138, 19)
        Me.ToolStripMenuItem22.Text = "&View Embedded Data"
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItem23.Text = "View .csd file"
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItem24.Text = "View data array"
        '
        'ToolStripMenuItem25
        '
        Me.ToolStripMenuItem25.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem26, Me.ToolStripMenuItem27, Me.ToolStripMenuItem28})
        Me.ToolStripMenuItem25.Name = "ToolStripMenuItem25"
        Me.ToolStripMenuItem25.Size = New System.Drawing.Size(43, 19)
        Me.ToolStripMenuItem25.Text = "&Help"
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(224, 22)
        Me.ToolStripMenuItem26.Text = "Csound &Background (.txt)"
        '
        'ToolStripMenuItem27
        '
        Me.ToolStripMenuItem27.Name = "ToolStripMenuItem27"
        Me.ToolStripMenuItem27.Size = New System.Drawing.Size(224, 22)
        Me.ToolStripMenuItem27.Text = "&GhostWriter General Info (.txt)"
        '
        'ToolStripMenuItem28
        '
        Me.ToolStripMenuItem28.Name = "ToolStripMenuItem28"
        Me.ToolStripMenuItem28.Size = New System.Drawing.Size(224, 22)
        Me.ToolStripMenuItem28.Text = "&About"
        '
        'ToolStripMenuItem29
        '
        Me.ToolStripMenuItem29.BackColor = System.Drawing.Color.Gold
        Me.ToolStripMenuItem29.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem30, Me.ToolStripMenuItem31})
        Me.ToolStripMenuItem29.Name = "ToolStripMenuItem29"
        Me.ToolStripMenuItem29.Size = New System.Drawing.Size(72, 19)
        Me.ToolStripMenuItem29.Text = "Python24"
        '
        'ToolStripMenuItem30
        '
        Me.ToolStripMenuItem30.Name = "ToolStripMenuItem30"
        Me.ToolStripMenuItem30.Size = New System.Drawing.Size(247, 22)
        Me.ToolStripMenuItem30.Text = "install Python24  from web"
        '
        'ToolStripMenuItem31
        '
        Me.ToolStripMenuItem31.Name = "ToolStripMenuItem31"
        Me.ToolStripMenuItem31.Size = New System.Drawing.Size(247, 22)
        Me.ToolStripMenuItem31.Text = "if Csound5 is not installed, do it now"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Michael Jerome Todd on the WEB"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Ghost_Writer and CSound Resources"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImage = Global.Csound_Ghost_Writer.My.Resources.Resources.CsoundArt_1_2_ghostWriter_
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(548, 25)
        Me.ToolStrip1.TabIndex = 34
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Michael Jerome Todd on the WEB"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Ghost_Writer and CSound Resources"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Ivory
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(548, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem32
        '
        Me.ToolStripMenuItem32.Name = "ToolStripMenuItem32"
        Me.ToolStripMenuItem32.Size = New System.Drawing.Size(36, 18)
        Me.ToolStripMenuItem32.Text = "&File"
        '
        'ToolStripMenuItem33
        '
        Me.ToolStripMenuItem33.Name = "ToolStripMenuItem33"
        Me.ToolStripMenuItem33.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem33.Text = "&Export as .WAV"
        '
        'ToolStripMenuItem34
        '
        Me.ToolStripMenuItem34.Name = "ToolStripMenuItem34"
        Me.ToolStripMenuItem34.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem34.Text = "&Save .csd"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(158, 6)
        '
        'ToolStripMenuItem35
        '
        Me.ToolStripMenuItem35.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripMenuItem35.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem35.Name = "ToolStripMenuItem35"
        Me.ToolStripMenuItem35.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem35.Text = "&Close"
        '
        'ToolStripMenuItem36
        '
        Me.ToolStripMenuItem36.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem37, Me.ToolStripMenuItem38, Me.ToolStripMenuItem39})
        Me.ToolStripMenuItem36.Name = "ToolStripMenuItem36"
        Me.ToolStripMenuItem36.Size = New System.Drawing.Size(39, 18)
        Me.ToolStripMenuItem36.Text = "&Midi"
        '
        'ToolStripMenuItem37
        '
        Me.ToolStripMenuItem37.Checked = True
        Me.ToolStripMenuItem37.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem37.Name = "ToolStripMenuItem37"
        Me.ToolStripMenuItem37.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem37.Text = "&No MIDI (Deactivate)"
        '
        'ToolStripMenuItem38
        '
        Me.ToolStripMenuItem38.Name = "ToolStripMenuItem38"
        Me.ToolStripMenuItem38.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem38.Text = "&Midi Control (Activate)"
        '
        'ToolStripMenuItem39
        '
        Me.ToolStripMenuItem39.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem40})
        Me.ToolStripMenuItem39.Name = "ToolStripMenuItem39"
        Me.ToolStripMenuItem39.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem39.Text = "Notes on Midi Input"
        '
        'ToolStripMenuItem40
        '
        Me.ToolStripMenuItem40.Name = "ToolStripMenuItem40"
        Me.ToolStripMenuItem40.Size = New System.Drawing.Size(189, 22)
        Me.ToolStripMenuItem40.Text = "Midi Hardware Inputs"
        '
        'ToolStripMenuItem41
        '
        Me.ToolStripMenuItem41.BackColor = System.Drawing.Color.Turquoise
        Me.ToolStripMenuItem41.Name = "ToolStripMenuItem41"
        Me.ToolStripMenuItem41.Size = New System.Drawing.Size(94, 18)
        Me.ToolStripMenuItem41.Text = "&Signal Setting"
        '
        'ToolStripMenuItem42
        '
        Me.ToolStripMenuItem42.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem43, Me.ToolStripMenuItem44})
        Me.ToolStripMenuItem42.Name = "ToolStripMenuItem42"
        Me.ToolStripMenuItem42.Size = New System.Drawing.Size(205, 22)
        Me.ToolStripMenuItem42.Text = "&Add Additional Signal"
        '
        'ToolStripMenuItem43
        '
        Me.ToolStripMenuItem43.Name = "ToolStripMenuItem43"
        Me.ToolStripMenuItem43.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem43.Text = "&pvsosc"
        '
        'ToolStripMenuItem44
        '
        Me.ToolStripMenuItem44.Name = "ToolStripMenuItem44"
        Me.ToolStripMenuItem44.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem44.Text = "&oscil"
        '
        'ToolStripMenuItem45
        '
        Me.ToolStripMenuItem45.Name = "ToolStripMenuItem45"
        Me.ToolStripMenuItem45.Size = New System.Drawing.Size(205, 22)
        Me.ToolStripMenuItem45.Text = "&Edit current  f-Table"
        '
        'ToolStripMenuItem46
        '
        Me.ToolStripMenuItem46.Name = "ToolStripMenuItem46"
        Me.ToolStripMenuItem46.Size = New System.Drawing.Size(205, 22)
        Me.ToolStripMenuItem46.Text = "&Remove Selected Signal"
        '
        'ToolStripMenuItem47
        '
        Me.ToolStripMenuItem47.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem48, Me.ToolStripSeparator12, Me.ToolStripMenuItem49, Me.ToolStripSeparator13, Me.ToolStripMenuItem50, Me.ToolStripMenuItem51})
        Me.ToolStripMenuItem47.Name = "ToolStripMenuItem47"
        Me.ToolStripMenuItem47.Size = New System.Drawing.Size(107, 18)
        Me.ToolStripMenuItem47.Text = "&Render Settings"
        '
        'ToolStripMenuItem48
        '
        Me.ToolStripMenuItem48.Name = "ToolStripMenuItem48"
        Me.ToolStripMenuItem48.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripMenuItem48.Text = "&Sample Rate"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(174, 6)
        '
        'ToolStripMenuItem49
        '
        Me.ToolStripMenuItem49.Name = "ToolStripMenuItem49"
        Me.ToolStripMenuItem49.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripMenuItem49.Text = "&Top Level FX Mixer"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(174, 6)
        '
        'ToolStripMenuItem50
        '
        Me.ToolStripMenuItem50.Name = "ToolStripMenuItem50"
        Me.ToolStripMenuItem50.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripMenuItem50.Text = "&AM Layering"
        '
        'ToolStripMenuItem51
        '
        Me.ToolStripMenuItem51.Checked = True
        Me.ToolStripMenuItem51.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem51.Name = "ToolStripMenuItem51"
        Me.ToolStripMenuItem51.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripMenuItem51.Text = "&FM Layering"
        '
        'ToolStripMenuItem52
        '
        Me.ToolStripMenuItem52.BackColor = System.Drawing.Color.PaleGreen
        Me.ToolStripMenuItem52.Name = "ToolStripMenuItem52"
        Me.ToolStripMenuItem52.Size = New System.Drawing.Size(138, 19)
        Me.ToolStripMenuItem52.Text = "&View Embedded Data"
        '
        'ToolStripMenuItem53
        '
        Me.ToolStripMenuItem53.Name = "ToolStripMenuItem53"
        Me.ToolStripMenuItem53.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripMenuItem53.Text = "View .csd file"
        '
        'ToolStripMenuItem54
        '
        Me.ToolStripMenuItem54.Name = "ToolStripMenuItem54"
        Me.ToolStripMenuItem54.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripMenuItem54.Text = "View data array"
        '
        'ToolStripMenuItem55
        '
        Me.ToolStripMenuItem55.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem56, Me.ToolStripMenuItem57, Me.ToolStripMenuItem58})
        Me.ToolStripMenuItem55.Name = "ToolStripMenuItem55"
        Me.ToolStripMenuItem55.Size = New System.Drawing.Size(43, 18)
        Me.ToolStripMenuItem55.Text = "&Help"
        '
        'ToolStripMenuItem56
        '
        Me.ToolStripMenuItem56.Name = "ToolStripMenuItem56"
        Me.ToolStripMenuItem56.Size = New System.Drawing.Size(245, 22)
        Me.ToolStripMenuItem56.Text = "Csound &Background (.txt)"
        '
        'ToolStripMenuItem57
        '
        Me.ToolStripMenuItem57.Name = "ToolStripMenuItem57"
        Me.ToolStripMenuItem57.Size = New System.Drawing.Size(245, 22)
        Me.ToolStripMenuItem57.Text = "&GhostWriter General Info (.txt)"
        '
        'ToolStripMenuItem58
        '
        Me.ToolStripMenuItem58.Name = "ToolStripMenuItem58"
        Me.ToolStripMenuItem58.Size = New System.Drawing.Size(245, 22)
        Me.ToolStripMenuItem58.Text = "&About"
        '
        'ToolStripMenuItem59
        '
        Me.ToolStripMenuItem59.BackColor = System.Drawing.Color.Gold
        Me.ToolStripMenuItem59.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem60, Me.ToolStripMenuItem61})
        Me.ToolStripMenuItem59.Name = "ToolStripMenuItem59"
        Me.ToolStripMenuItem59.Size = New System.Drawing.Size(72, 18)
        Me.ToolStripMenuItem59.Text = "Python24"
        '
        'ToolStripMenuItem60
        '
        Me.ToolStripMenuItem60.Name = "ToolStripMenuItem60"
        Me.ToolStripMenuItem60.Size = New System.Drawing.Size(273, 22)
        Me.ToolStripMenuItem60.Text = "install Python24  from web"
        '
        'ToolStripMenuItem61
        '
        Me.ToolStripMenuItem61.Name = "ToolStripMenuItem61"
        Me.ToolStripMenuItem61.Size = New System.Drawing.Size(273, 22)
        Me.ToolStripMenuItem61.Text = "if Csound5 is not installed, do it now"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = Global.Csound_Ghost_Writer.My.Resources.Resources.t_1284
        Me.ClientSize = New System.Drawing.Size(548, 684)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gboxWaveGen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.9
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Csound Ghost_Writer - Orchestra Builder    -->   -->   -->  ( by: Mezcel )  <--  " & _
            "<--"
        Me.gboxWaveGen.ResumeLayout(False)
        Me.gboxWaveGen.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.tabADSR.ResumeLayout(False)
        Me.tabADSR.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFilter.ResumeLayout(False)
        Me.tabFilter.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.picBox_HPLFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox_LPLFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbLFO_HP_Hz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbLFO_HP_level, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbLFO_HP_Shape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbLFO_LP_Hz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbLFO_LP_level, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbLFO_LP_Shape, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gboxWaveGen As System.Windows.Forms.GroupBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnInternet As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WriteCSDFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewInstrumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveInstrumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WritecsdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WriteorcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GWriterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeveloperCreidsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnWaveRemove As System.Windows.Forms.Button
    Friend WithEvents btnWaveAdd As System.Windows.Forms.Button
    Friend WithEvents txtWaveBase As System.Windows.Forms.TextBox
    Friend WithEvents txtWaveIndex As System.Windows.Forms.TextBox
    Friend WithEvents btnWaveRear As System.Windows.Forms.Button
    Friend WithEvents btnWaveNext As System.Windows.Forms.Button
    Friend WithEvents btnWavePrevious As System.Windows.Forms.Button
    Friend WithEvents btnWaveFront As System.Windows.Forms.Button
    Friend WithEvents cbSynthSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents tabFilter As System.Windows.Forms.TabPage
    Friend WithEvents tabADSR As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtRelease As System.Windows.Forms.TextBox
    Friend WithEvents VSSustain As System.Windows.Forms.VScrollBar
    Friend WithEvents txtSustain As System.Windows.Forms.TextBox
    Friend WithEvents VSRelease As System.Windows.Forms.VScrollBar
    Friend WithEvents txtDecay As System.Windows.Forms.TextBox
    Friend WithEvents VSDecay As System.Windows.Forms.VScrollBar
    Friend WithEvents txtAttack As System.Windows.Forms.TextBox
    Friend WithEvents VSAttack As System.Windows.Forms.VScrollBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDelay As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents HSDelay As System.Windows.Forms.HScrollBar
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents rbAdsrOff As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdsrON As System.Windows.Forms.RadioButton
    Friend WithEvents hipassRes As System.Windows.Forms.HScrollBar
    Friend WithEvents txthpRes As System.Windows.Forms.TextBox
    Friend WithEvents hipassCutoff As System.Windows.Forms.HScrollBar
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents txthpCut As System.Windows.Forms.TextBox
    Friend WithEvents txtlpRes As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents txtlpCut As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents lowpassRes As System.Windows.Forms.HScrollBar
    Friend WithEvents lowpassCutoff As System.Windows.Forms.HScrollBar
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents rbLpOff As System.Windows.Forms.RadioButton
    Friend WithEvents rbLpOn As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbHPOn As System.Windows.Forms.RadioButton
    Friend WithEvents rbHPOff As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSample As System.Windows.Forms.Button
    Friend WithEvents txtSec As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSingle As System.Windows.Forms.Button
    Friend WithEvents btnRepeat As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents txtLFO_LP_Level As System.Windows.Forms.TextBox
    Friend WithEvents txtLFO_LP_Hz As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents tkbLFO_LP_Hz As System.Windows.Forms.TrackBar
    Friend WithEvents tkbLFO_LP_level As System.Windows.Forms.TrackBar
    Friend WithEvents txtLFO_LP_Shape As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SampleRateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PvsoscToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OscilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditCurrentFTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MidiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoMidiLinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MidiControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopLevelMixerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tkbLFO_LP_Shape As System.Windows.Forms.TrackBar
    Friend WithEvents txtLFO_HP_Level As System.Windows.Forms.TextBox
    Friend WithEvents txtLFO_HP_Hz As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents tkbLFO_HP_Hz As System.Windows.Forms.TrackBar
    Friend WithEvents tkbLFO_HP_level As System.Windows.Forms.TrackBar
    Friend WithEvents txtLFO_HP_Shape As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents tkbLFO_HP_Shape As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picBox_LPLFO As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picBox_HPLFO As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAbort As System.Windows.Forms.Button
    Friend WithEvents Python24 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstallFromWebToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Csound5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MidiInputInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MidiInputsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AditionalResourcesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Csound5TextEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VoiceToTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeBackgroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueBushToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoonGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreyCamoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem22 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem23 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem24 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem25 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem26 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem27 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem28 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem29 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem30 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem31 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem32 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem33 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem34 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem35 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem36 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem37 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem38 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem39 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem40 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem41 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem42 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem43 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem44 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem45 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem46 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem47 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem48 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem49 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem50 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem51 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem52 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem53 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem54 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem55 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem56 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem57 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem58 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem59 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem60 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem61 As System.Windows.Forms.ToolStripMenuItem


End Class
