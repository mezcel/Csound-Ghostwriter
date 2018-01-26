'Imports System
'Imports System.Windows.Forms
'Imports System.Security.Permissions

'<PermissionSet(SecurityAction.Demand, Name:="FullTrust")> <System.Runtime.InteropServices.ComVisibleAttribute(True)>


Public Class Form1
    Inherits Form
    Public waveInitSwitch_Array(MAX_WAVE) As Boolean
    Dim repeatbutton, singlebutton As Boolean
    Dim midiOn As Boolean
    Public webBrowser1 As WebBrowser


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        webBrowser1 = New WebBrowser()
        webBrowser1.Dock = DockStyle.Fill


        My.Computer.FileSystem.CreateDirectory(AppFilePath) 'make the dir folder
        small_b = "10000" '-b sample rate Mezcel Ghostwriter initial default
        big_B = "1024" '-B sample rate default

        adsr = New Bitmap(PictureBox1.ClientRectangle.Width, PictureBox1.ClientRectangle.Height, Drawing.Imaging.PixelFormat.Format24bppRgb)

        hipass = New Bitmap(PictureBox2.ClientRectangle.Width, PictureBox2.ClientRectangle.Height, Drawing.Imaging.PixelFormat.Format24bppRgb)
        lowpass = New Bitmap(PictureBox3.ClientRectangle.Width, PictureBox3.ClientRectangle.Height, Drawing.Imaging.PixelFormat.Format24bppRgb)

        lfoLP = New Bitmap(picBox_LPLFO.ClientRectangle.Width, picBox_LPLFO.ClientRectangle.Height, Drawing.Imaging.PixelFormat.Format24bppRgb)
        lfoHP = New Bitmap(picBox_HPLFO.ClientRectangle.Width, picBox_HPLFO.ClientRectangle.Height, Drawing.Imaging.PixelFormat.Format24bppRgb)

        loopScore = 0 'no loop

        initialize_filters(0)
        update_filters(0)
        initialize_ADSR(0)
        initializeLfoData(0) 'update is within the initialization

        waveInitSwitch_Array(MAX_WAVE) = False 'intial switch as off

        'initialize global array count
        waveGenerator_index = 0
        waveGenerator_component_index = 0

        waveGenerator_Total = 0
        waveGenerator_component_Total = 0

        txtWaveIndex.Text = 0
        txtWaveBase.Text = " of [" & waveGenerator_Total & "]"

        spash_screen()


        masterVolume = 80
        masterThreshold = 50

        'initially turn off filters
        rbLpOff.Checked = True
        rbHPOff.Checked = True

        repeatbutton = False
        singlebutton = False
        midiOn = False

        OpenToolStripMenuItem.Enabled = False
        SaveToolStripMenuItem.Enabled = False
        WritecsdToolStripMenuItem.Enabled = False
        WriteorcToolStripMenuItem.Enabled = False

        btnWaveFront.Enabled = False
        btnWavePrevious.Enabled = False
        btnWaveNext.Enabled = False
        btnWaveRear.Enabled = False

        SaveToolStripMenuItem.Enabled = False
        EditCurrentFTableToolStripMenuItem.Enabled = False
        RemoveInstrumentToolStripMenuItem.Enabled = False
        WritecsdToolStripMenuItem.Enabled = False
        WriteorcToolStripMenuItem.Enabled = False

        TopLevelMixerToolStripMenuItem.Enabled = False

        btnSample.BackColor = Color.LightBlue
        btnSample.ForeColor = Color.Red

        btnAbort.Enabled = False

    End Sub

    '====================================================================================
    '================     Wave Generator Toolbar Buttons           ======================
    '====================================================================================

    Private Sub btnWaveFront_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWaveFront.Click
        waveGenerator_index = 0
        txtWaveIndex.Text = waveGenerator_index
        txtWaveBase.Text = "of [" & waveGenerator_Total & "]"

        'sync index number with tab view
        If waveInitSwitch_Array(waveGenerator_index) = True Then
            TabControl1.SelectedTab = tabPage_array(waveGenerator_index)
        End If



    End Sub

    Private Sub btnWavePrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWavePrevious.Click
        If waveGenerator_index > 0 Then
            waveGenerator_index = waveGenerator_index - 1
            txtWaveIndex.Text = waveGenerator_index
            txtWaveBase.Text = "of [" & waveGenerator_Total & "]"
        End If

        'sync index number with tab view
        If waveInitSwitch_Array(waveGenerator_index) = True Then
            TabControl1.SelectedTab = tabPage_array(waveGenerator_index)
        End If

    End Sub

    Private Sub btnWaveNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWaveNext.Click
        If waveGenerator_index < waveGenerator_Total Then
            waveGenerator_index = waveGenerator_index + 1
            txtWaveIndex.Text = waveGenerator_index
            txtWaveBase.Text = "of [" & waveGenerator_Total & "]"
        End If

        'sync index number with tab view
        If waveInitSwitch_Array(waveGenerator_index) = True Then
            TabControl1.SelectedTab = tabPage_array(waveGenerator_index)
        End If

    End Sub

    Private Sub btnWaveRear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWaveRear.Click
        waveGenerator_index = waveGenerator_Total
        txtWaveIndex.Text = waveGenerator_index
        txtWaveBase.Text = "of [" & waveGenerator_Total & "]"

        'sync index number with tab view
        If waveInitSwitch_Array(waveGenerator_index) = True Then
            TabControl1.SelectedTab = tabPage_array(waveGenerator_index)
        End If

    End Sub

    Private Sub btnWaveAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWaveAdd.Click
        If cbSynthSelect.Text <> " Synth Select" Then
            If waveGenerator_index <= MAX_WAVE Then
                add_signal()
                AddHandler tabPage_array(waveGenerator_index).MouseEnter, AddressOf waveTabControl_MouseEnter
                AddHandler tabPage_array(waveGenerator_index).MouseClick, AddressOf TabControl1_MouseClick
                AddHandler tabPage_array(waveGenerator_index).MouseDoubleClick, AddressOf TabControl1_MouseDoubleClick
            Else
                MsgBox("Maximum Signal Layers have been reached. For cooler sounds modify the existing signals generated :)")
            End If
        End If


    End Sub

    Private Sub waveTabControl_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        waveGenerator_index = sender.name
        txtWaveIndex.Text = waveGenerator_index
        'sync index number with tab view
        If waveInitSwitch_Array(waveGenerator_index) = True Then
            TabControl1.SelectedTab = tabPage_array(waveGenerator_index)
        End If
    End Sub

    Private Sub btnWaveRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWaveRemove.Click
        If waveGenerator_Total > 0 Then

            saveWaveArray()
            wave_removeShift(waveGenerator_index) 'remove array data

            ''remove object tabs from project
            For wi As Integer = waveGenerator_index To waveGenerator_Total
                TabControl1.Controls.Remove(tabPage_array(wi))
            Next

            If waveGenerator_Total > 0 Then
                waveGenerator_Total = waveGenerator_Total - 1
                rebuildWavTabs(waveGenerator_index) 'rebuld tabs from the point of remove
                txtWaveIndex.Text = waveGenerator_index
                txtWaveBase.Text = " of [" & waveGenerator_Total & "]"

            ElseIf waveGenerator_Total = 0 Then
                waveGenerator_Total = waveGenerator_Total - 1
                txtWaveIndex.Text = "- - - -"
                txtWaveBase.Text = " Empty"

            End If

        End If

        Toggle_Dsp()
        update_adsr(waveGenerator_index)
        update_filters(waveGenerator_index)
        update_LFO(waveGenerator_index)

    End Sub

    Private Sub txtWaveIndex_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWaveIndex.TextChanged
        waveGenerator_index = txtWaveIndex.Text

        If txtWaveIndex.Text > 4 Then
            txtWaveIndex.Text = 0
        End If

        'sync index number with tab view
        If waveInitSwitch_Array(waveGenerator_index) = True Then
            TabControl1.SelectedTab = tabPage_array(waveGenerator_index)
        End If

        update_adsr(waveGenerator_index)
        update_filters(waveGenerator_index)
        update_LFO(waveGenerator_index)

    End Sub

    '====================================================================================
    '================              Filter Graphics Controll              ======================
    '====================================================================================

    Private Sub PictureBox2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox2.Paint
        Dim objGraphics As Graphics
        objGraphics = e.Graphics
        objGraphics.DrawImage(hipass, 0, 0, hipass.Width, hipass.Height)

    End Sub

    Private Sub hipassCutoff_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hipassCutoff.ValueChanged
        drawHiPassCut()
        hpData(waveGenerator_index, 0) = hipassCutoff.Value * (9 + (13 / 23)) + 200
    End Sub

    Private Sub hipassRes_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hipassRes.ValueChanged
        drawHiPassRes()
        hpData(waveGenerator_index, 1) = hipassRes.Value * (9 + (13 / 23)) + 200

    End Sub

    Private Sub PictureBox3_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox3.Paint
        Dim objGraphics As Graphics
        objGraphics = e.Graphics
        objGraphics.DrawImage(lowpass, 0, 0, lowpass.Width, lowpass.Height)
    End Sub

    Private Sub lowpassCutoff_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lowpassCutoff.ValueChanged
        drawLowPassCut()
        lpData(waveGenerator_index, 0) = lowpassCutoff.Value * (9 + (13 / 23)) + 200

    End Sub

    Private Sub lowpassRes_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lowpassRes.ValueChanged
        drawLowPassRes()
        lpData(waveGenerator_index, 1) = lowpassRes.Value * (9 + (13 / 23)) + 200

    End Sub

    ''====================================================================================
    ''================               Graphics Controll ADSR         ======================
    ''====================================================================================

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        Dim objGraphics As Graphics
        objGraphics = e.Graphics
        objGraphics.DrawImage(adsr, 0, 0, adsr.Width, adsr.Height)
    End Sub

    Private Sub VSAttack_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VSAttack.ValueChanged
        drawAttack()
    End Sub

    Private Sub VSDecay_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VSDecay.ValueChanged
        drawDecay()

    End Sub

    Private Sub VSSustain_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VSSustain.ValueChanged
        drawSustain()

    End Sub

    Private Sub VSRelease_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VSRelease.ValueChanged

        drawRelease()

    End Sub

    Private Sub rbHPOn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHPOn.CheckedChanged
        If rbHPOn.Checked = True Then
            hpData(waveGenerator_index, 2) = 1
        End If
    End Sub

    Private Sub rbLpOn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLpOn.CheckedChanged
        If rbLpOn.Checked = True Then
            lpData(waveGenerator_index, 2) = 1
        End If
    End Sub

    Private Sub rbAdsrON_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAdsrON.CheckedChanged
        If rbAdsrON.Checked = True Then

        End If
    End Sub

    Private Sub TabControl1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseClick

        For i As Integer = 0 To waveGenerator_Total
            If (TabControl1.SelectedTab Is tabPage_array(i)) Then
                waveGenerator_index = i
                txtWaveIndex.Text = waveGenerator_index
            End If
        Next

    End Sub

    Private Sub TabControl1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseDoubleClick

        For i As Integer = 0 To waveGenerator_Total
            If (TabControl1.SelectedTab Is tabPage_array(i)) Then
                waveGenerator_index = i
                txtWaveIndex.Text = waveGenerator_index

                'input the tab name
                waveTabName(waveGenerator_index) = InputBox("Change Name Signal Generator:", "Change Signal Generator Name", waveTabName(waveGenerator_index))
                tabPage_array(waveGenerator_index).Text = waveTabName(waveGenerator_index) & " (" & waveGenerator_index & ")"

            End If
        Next
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim customName As String
        customName = InputBox("Provide a name for your current sound:", "enter a recognizable name")
        customName = "\" & customName & ".csd"
        write2file2(customName)

        customName = AppFilePath & customName
        'Shell("notepad " & "C:\Users\mezcel\Documents\Mezcel_test.txt" & "", vbNormalFocus)
        Shell("notepad " & customName, vbNormalFocus)
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        saveWaveArray()
    End Sub

    Private Sub btnSample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSample.Click

        'Dim ProcID As Integer
        ChDir(AppFilePath)
        'ProcID = Shell("csound GhostWriter.csd")

        If MidiControlToolStripMenuItem.Checked = True Then
            midiOn = Not midiOn 'toggle on and off
            If midiOn = True Then

                CSD = " " & AppFilePath & "\GhostWriter.csd"

                write2file2("\GhostWriter.csd")       'just data

                'Shell("csound GhostWriter.csd")
                btnSample.Text = "DEactivate Midi Keys"
                btnSample.BackColor = Color.LightBlue
                btnSample.ForeColor = Color.Red


                CSoundAVCompiler(AppFilePath & "\GhostWriter.csd")


            Else

                btnSample.BackColor = Color.Black
                btnSample.ForeColor = Color.White
            End If
        End If

            If MidiControlToolStripMenuItem.Checked = False Then
                btnSample.BackColor = Color.LightBlue
                btnSample.ForeColor = Color.Red

                CSD = " " & AppFilePath & "\GhostWriter.csd"

                write2file2("\GhostWriter.csd")       'just data

            'prevent double clicking
            If cmdComplierFlag = False Then 'initial contition to play
                CSoundAVCompiler(AppFilePath & "\GhostWriter.csd")
                btnAbort.Enabled = True
            Else
                If midiProc.HasExited Then 'play the rest of the times
                    CSoundAVCompiler(AppFilePath & "\GhostWriter.csd")
                    btnAbort.Enabled = True
                End If
            End If


        End If



    End Sub

    Private Sub WritecsdToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WritecsdToolStripMenuItem.Click
        CSD = " " & AppFilePath & "\GhostWriter.csd"

        write2file2("\GhostWriter.csd")       'just data
        Shell("notepad " & CSD, vbNormalFocus)
    End Sub

    Private Sub WriteorcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WriteorcToolStripMenuItem.Click
        write2file()       'just data

        CSD = " " & AppFilePath & "\GhostWriter.txt"
        Shell("notepad" & CSD, vbNormalFocus)


    End Sub

    '====================================================================================
    '================     ADSR data           ======================
    '====================================================================================
    Private Sub VSAttack_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VSAttack.Scroll
        Dim rawValue, scaleValue As Double
       

        rawValue = VSAttack.Value
        rawValue = 0 - rawValue
        scaleValue = rawValue / 100

        adsrData(waveGenerator_index, 0) = scaleValue
        adsrScbData(waveGenerator_index, 0) = VSAttack.Value

    End Sub

    Private Sub VSDecay_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VSDecay.Scroll
        Dim rawValue, scaleValue As Double
        rawValue = VSDecay.Value
        rawValue = 0 - rawValue
        scaleValue = rawValue / 100

        adsrData(waveGenerator_index, 1) = scaleValue
        adsrScbData(waveGenerator_index, 1) = VSDecay.Value
    End Sub

    Private Sub VSSustain_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VSSustain.Scroll
        Dim rawValue, scaleValue As Double
        rawValue = VSSustain.Value
        rawValue = 0 - rawValue
        scaleValue = rawValue / 100

        adsrData(waveGenerator_index, 2) = scaleValue
        adsrScbData(waveGenerator_index, 2) = VSSustain.Value
    End Sub

    Private Sub VSRelease_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VSRelease.Scroll
        Dim rawValue, scaleValue As Double
        rawValue = VSRelease.Value
        rawValue = 0 - rawValue
        scaleValue = rawValue / 100

        adsrData(waveGenerator_index, 3) = scaleValue
        adsrScbData(waveGenerator_index, 3) = VSRelease.Value
    End Sub

    Private Sub txtSec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSec.TextChanged
        scoSec = txtSec.Text
    End Sub

    '===============================================================================
    '======================== Splash screen stuff ===========================
    '===============================================================================

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        'PictureBox4.Visible = False

        PictureBox4.Location = New Point(0, 320)
        PictureBox4.Size = New System.Drawing.Size(554, 380)
    End Sub


    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewInstrumentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewInstrumentToolStripMenuItem.Click
        If cbSynthSelect.Text <> " Synth Select" Then
            add_signal()

            AddHandler tabPage_array(waveGenerator_index).MouseEnter, AddressOf waveTabControl_MouseEnter
            AddHandler tabPage_array(waveGenerator_index).MouseClick, AddressOf TabControl1_MouseClick
            AddHandler tabPage_array(waveGenerator_index).MouseDoubleClick, AddressOf TabControl1_MouseDoubleClick
        End If

    End Sub

  
    Private Sub RemoveInstrumentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveInstrumentToolStripMenuItem.Click
        If waveGenerator_Total > 0 Then

            saveWaveArray()
            wave_removeShift(waveGenerator_index) 'remove array data

            ''remove object tabs from project
            For wi As Integer = waveGenerator_index To waveGenerator_Total
                TabControl1.Controls.Remove(tabPage_array(wi))
            Next

            If waveGenerator_Total > 0 Then
                waveGenerator_Total = waveGenerator_Total - 1
                rebuildWavTabs(waveGenerator_index) 'rebuld tabs from the point of remove
                txtWaveIndex.Text = waveGenerator_index
                txtWaveBase.Text = " of [" & waveGenerator_Total & "]"

            ElseIf waveGenerator_Total = 0 Then
                waveGenerator_Total = waveGenerator_Total - 1
                txtWaveIndex.Text = "- - - -"
                txtWaveBase.Text = " Empty"

            End If

        End If

        update_adsr(waveGenerator_index)
        update_filters(waveGenerator_index)
        update_LFO(waveGenerator_index)
    End Sub

    Private Sub rbAdsrOff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAdsrOff.CheckedChanged
        VSAttack.Enabled = Not VSAttack.Enabled
        VSDecay.Enabled = Not VSDecay.Enabled
        VSSustain.Enabled = Not VSSustain.Enabled
        VSRelease.Enabled = Not VSRelease.Enabled

        initialize_ADSR(waveGenerator_index)

        update_adsr(waveGenerator_index)

    End Sub

    Private Sub rbLpOff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLpOff.CheckedChanged
        If rbLpOff.Checked = True Then
            lowpassCutoff.Enabled = Not lowpassCutoff.Enabled
            lowpassRes.Enabled = Not lowpassRes.Enabled

            lowpassCutoff.Value = 220
            lpData(waveGenerator_index, 0) = 220 * (9 + (13 / 23)) + 200
            lowpassRes.Value = 220
            lpData(waveGenerator_index, 1) = 220 * (9 + (13 / 23)) + 200

            lpData(waveGenerator_index, 2) = 0

        End If

        If rbLpOff.Checked = False Then
            lowpassCutoff.Enabled = Not lowpassCutoff.Enabled
            lowpassRes.Enabled = Not lowpassRes.Enabled
        End If
        


    End Sub

    Private Sub rbHPOff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHPOff.CheckedChanged

        If rbHPOff.Checked = True Then
            hipassCutoff.Enabled = Not hipassCutoff.Enabled
            hipassRes.Enabled = Not hipassRes.Enabled

            hipassCutoff.Value = 1
            hpData(waveGenerator_index, 0) = 222
            hipassRes.Value = 1
            hpData(waveGenerator_index, 1) = 222

            hpData(waveGenerator_index, 2) = 0
        End If

        If rbHPOff.Checked = False Then
            hipassCutoff.Enabled = Not hipassCutoff.Enabled
            hipassRes.Enabled = Not hipassRes.Enabled
        End If


    End Sub

 
    Private Sub btnRepeat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepeat.Click
        'repeatbutton = Not repeatbutton

        'If repeatbutton = True Then
        '    singlebutton = False
        '    btnRepeat.BackColor = Color.Gray
        '    btnSingle.BackColor = Color.DarkGoldenrod
        'Else
        '    btnRepeat.BackColor = Color.DarkGoldenrod
        'End If

        frmLoop.Show()

        
    End Sub

    Private Sub btnSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSingle.Click

        singlebutton = Not singlebutton

        If singlebutton = True Then
            loopScore = 1 'yes loop
            btnSingle.BackColor = Color.GreenYellow
            Me.btnSingle.BackgroundImage = Global.Csound_Ghost_Writer.My.Resources.Resources.lightswitch_on_
        Else
            loopScore = 0 'no loop
            btnSingle.BackColor = Color.Red
            Me.btnSingle.BackgroundImage = Global.Csound_Ghost_Writer.My.Resources.Resources.lightswitch_off_
            MsgBox("Remember to reconfigure the -b buffer and sustain length." & ControlChars.CrLf & "" & ControlChars.CrLf & "Recomendations:" & ControlChars.CrLf & "-b: 10000" & ControlChars.CrLf & "sustain: 1")
        End If


    End Sub



    Private Sub PvsoscToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PvsoscToolStripMenuItem.Click
        cbSynthSelect.Text = "pvsosc"

        add_signal()

        AddHandler tabPage_array(waveGenerator_index).MouseEnter, AddressOf waveTabControl_MouseEnter
        AddHandler tabPage_array(waveGenerator_index).MouseClick, AddressOf TabControl1_MouseClick
        AddHandler tabPage_array(waveGenerator_index).MouseDoubleClick, AddressOf TabControl1_MouseDoubleClick
    End Sub

    Private Sub AMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AMToolStripMenuItem.Click
        AMToolStripMenuItem.Checked = Not AMToolStripMenuItem.Checked
        If AMToolStripMenuItem.Checked = True Then
            FMToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub FMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FMToolStripMenuItem.Click
        FMToolStripMenuItem.Checked = Not FMToolStripMenuItem.Checked
        If FMToolStripMenuItem.Checked = True Then
            AMToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub SampleRateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleRateToolStripMenuItem.Click
        'small_b = InputBox("Select the software buffer sample rate:" & ControlChars.CrLf & "(blank = default)" & ControlChars.CrLf & "(grainy < 4000)", "-b sample rate value")
        bufferSettings.Show()


    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim waveName As String
        waveName = InputBox("What is the name of your sound sample?:", "enter wave name")

        write2file2("\GhostWriter.csd")       'just data
        waitSeconds(0.25)   'allow write delay ISR processing time

        ChDir(AppFilePath)
        Shell("csound -o" & waveName & ".wav GhostWriter.csd")
    End Sub

    Private Sub OscilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OscilToolStripMenuItem.Click
        'frmFstatement.Show()
        cbSynthSelect.Text = "oscil"

        add_signal()

        AddHandler tabPage_array(waveGenerator_index).MouseEnter, AddressOf waveTabControl_MouseEnter
        AddHandler tabPage_array(waveGenerator_index).MouseClick, AddressOf TabControl1_MouseClick
        AddHandler tabPage_array(waveGenerator_index).MouseDoubleClick, AddressOf TabControl1_MouseDoubleClick

        'frmFstatement.Show()

    End Sub

    Private Sub EditCurrentFTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCurrentFTableToolStripMenuItem.Click
        frmFstatement.Show()
    End Sub

    Private Sub DeveloperCreidsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeveloperCreidsToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub NoMidiLinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoMidiLinkToolStripMenuItem.Click
        NoMidiLinkToolStripMenuItem.Checked = Not NoMidiLinkToolStripMenuItem.Checked
        If NoMidiLinkToolStripMenuItem.Checked = True Then
            MidiControlToolStripMenuItem.Checked = False
        End If
        btnSample.Text = "Play Sound Clip"
    End Sub

    Private Sub MidiControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MidiControlToolStripMenuItem.Click
        MidiControlToolStripMenuItem.Checked = Not MidiControlToolStripMenuItem.Checked
        If MidiControlToolStripMenuItem.Checked = True Then
            NoMidiLinkToolStripMenuItem.Checked = False
        End If
        btnSample.Text = "Activate Midi Keys"

        MsgBox("If your Midi is not pluged in, nothing is going happen.")
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundToolStripMenuItem.Click
        frmcsoundBackground.Show()
    End Sub

    Private Sub GWriterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GWriterToolStripMenuItem.Click
        frmGWdetails.Show()
    End Sub

    Private Sub TopLevelMixerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopLevelMixerToolStripMenuItem.Click
        frmMainMixer.Show()
    End Sub

    Private Sub btnInternet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInternet.Click
        Dim clsStartInfo As New System.Diagnostics.ProcessStartInfo
        clsStartInfo.FileName = "iexplore.exe"
        clsStartInfo.Arguments = "http://mezcel2008.googlepages.com"
        clsStartInfo.WindowStyle = ProcessWindowStyle.Minimized
        System.Diagnostics.Process.Start(clsStartInfo)


    End Sub


    '====================================================================================
    '======================== LFO Controls ==============================================
    '====================================================================================

    Private Sub picBox_LPLFO_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picBox_LPLFO.Paint
        Dim objGraphics As Graphics
        objGraphics = e.Graphics
        objGraphics.DrawImage(lfoLP, 0, 0, lfoLP.Width, lfoLP.Height)
    End Sub
    Private Sub picBox_HPLFO_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picBox_HPLFO.Paint
        Dim objGraphics As Graphics
        objGraphics = e.Graphics
        objGraphics.DrawImage(lfoHP, 0, 0, lfoHP.Width, lfoHP.Height)
    End Sub

    Private Sub tkbLFO_LP_level_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tkbLFO_LP_level.ValueChanged
        txtLFO_LP_Level.Text = tkbLFO_LP_level.Value
        txtLFO_LP_Hz.Text = tkbLFO_LP_Hz.Value
        'txtLFO_LP_Shape.Text = tkbLFO_LP_Shape.Value
        LFOShape_LPname(tkbLFO_LP_Shape.Value)

        lfo_Waveshapes(lfoLP)
        lfoData(waveGenerator_index, 3) = tkbLFO_LP_level.Value * 100
        'save_LFO(waveGenerator_index)

    End Sub

    Private Sub tkbLFO_LP_Hz_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tkbLFO_LP_Hz.ValueChanged
        txtLFO_LP_Level.Text = tkbLFO_LP_level.Value
        txtLFO_LP_Hz.Text = tkbLFO_LP_Hz.Value
        'txtLFO_LP_Shape.Text = tkbLFO_LP_Shape.Value
        LFOShape_LPname(tkbLFO_LP_Shape.Value)

        lfo_Waveshapes(lfoLP)
        lfoData(waveGenerator_index, 4) = tkbLFO_LP_Hz.Value * 2
        'save_LFO(waveGenerator_index)
    End Sub

  
    Private Sub tkbLFO_LP_Shape_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tkbLFO_LP_Shape.ValueChanged
        txtLFO_LP_Level.Text = tkbLFO_LP_level.Value
        txtLFO_LP_Hz.Text = tkbLFO_LP_Hz.Value
        'txtLFO_LP_Shape.Text = tkbLFO_LP_Shape.Value
        LFOShape_LPname(tkbLFO_LP_Shape.Value)

        lfo_Waveshapes(lfoLP)
        lfoData(waveGenerator_index, 2) = tkbLFO_LP_Shape.Value
        'save_LFO(waveGenerator_index)
    End Sub

    Private Sub LFOShape_LPname(ByVal lfoShape As Integer)

        Select Case lfoShape
            Case 0
                txtLFO_LP_Shape.Text = "sine"
            Case 1
                txtLFO_LP_Shape.Text = "tri"
            Case 2
                txtLFO_LP_Shape.Text = "square"
            Case 3
                txtLFO_LP_Shape.Text = "sqrDC"
            Case 4
                txtLFO_LP_Shape.Text = "sawUP"
            Case 5
                txtLFO_LP_Shape.Text = "sawDn"
        End Select
    End Sub


    Private Sub tkbLFO_HP_level_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tkbLFO_HP_level.ValueChanged
        txtLFO_HP_Level.Text = tkbLFO_HP_level.Value
        txtLFO_HP_Hz.Text = tkbLFO_HP_Hz.Value
        'txtLFO_HP_Shape.Text = tkbLFO_LP_Shape.Value
        LFOShape_HPname(tkbLFO_HP_Shape.Value)

        lfo_Waveshapes(lfoHP)
        lfoData(waveGenerator_index, 0) = tkbLFO_HP_level.Value * 100
        'save_LFO(waveGenerator_index)
    End Sub
    Private Sub tkbLFO_HP_Hz_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tkbLFO_HP_Hz.ValueChanged
        txtLFO_HP_Level.Text = tkbLFO_HP_level.Value
        txtLFO_HP_Hz.Text = tkbLFO_HP_Hz.Value
        'txtLFO_LP_Shape.Text = tkbLFO_LP_Shape.Value
        LFOShape_HPname(tkbLFO_HP_Shape.Value)

        lfo_Waveshapes(lfoHP)
        lfoData(waveGenerator_index, 1) = tkbLFO_HP_Hz.Value * 2
        'save_LFO(waveGenerator_index)
    End Sub
    Private Sub tkbLFO_HP_Shape_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tkbLFO_HP_Shape.ValueChanged
        txtLFO_HP_Level.Text = tkbLFO_HP_level.Value
        txtLFO_HP_Hz.Text = tkbLFO_HP_Hz.Value
        'txtLFO_LP_Shape.Text = tkbLFO_LP_Shape.Value
        LFOShape_HPname(tkbLFO_HP_Shape.Value)

        lfo_Waveshapes(lfoHP)
        lfoData(waveGenerator_index, 5) = tkbLFO_HP_Shape.Value
        'save_LFO(waveGenerator_index)

    End Sub

    Private Sub LFOShape_HPname(ByVal lfoShape As Integer)

        Select Case lfoShape
            Case 0
                txtLFO_HP_Shape.Text = "sine"
            Case 1
                txtLFO_HP_Shape.Text = "tri"
            Case 2
                txtLFO_HP_Shape.Text = "square"
            Case 3
                txtLFO_HP_Shape.Text = "sqrDC"
            Case 4
                txtLFO_HP_Shape.Text = "sawUP"
            Case 5
                txtLFO_HP_Shape.Text = "sawDn"
        End Select
    End Sub

    
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim clsStartInfo As New System.Diagnostics.ProcessStartInfo
        clsStartInfo.FileName = "iexplore.exe"
        clsStartInfo.Arguments = "http://mezcel.googlepages.com/csound_resource"
        clsStartInfo.WindowStyle = ProcessWindowStyle.Minimized
        System.Diagnostics.Process.Start(clsStartInfo)


    End Sub


    Private Sub btnAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbort.Click
        If Not midiProc.HasExited Then
            midiProc.Kill()
        End If
        btnAbort.Enabled = False
    End Sub

    Private Sub Python24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Python24.Click
        MsgBox("The Python24.dll warning doesn't mean anything. Its a Csound engine thing." & ControlChars.CrLf & "But... if you really want to remove it, just click on the drop down option." & ControlChars.CrLf & "You will be downloading the appropriate .exe file.")
    End Sub

    Private Sub InstallFromWebToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallFromWebToolStripMenuItem.Click
        Dim clsStartInfo As New System.Diagnostics.ProcessStartInfo
        clsStartInfo.FileName = "iexplore.exe"
        clsStartInfo.Arguments = "http://www.python.org/ftp/python/2.5.2/python-2.5.2.msi"
        clsStartInfo.WindowStyle = ProcessWindowStyle.Minimized
        System.Diagnostics.Process.Start(clsStartInfo)
    End Sub

    Private Sub Csound5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Csound5ToolStripMenuItem.Click
        Dim clsStartInfo As New System.Diagnostics.ProcessStartInfo
        clsStartInfo.FileName = "iexplore.exe"
        clsStartInfo.Arguments = "http://sourceforge.net/project/downloading.php?groupname=csound&filename=Csound5.07.2-win32-f.exe&use_mirror=superb-east"
        clsStartInfo.WindowStyle = ProcessWindowStyle.Minimized
        System.Diagnostics.Process.Start(clsStartInfo)
    End Sub

    Private Sub MidiInputsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MidiInputsToolStripMenuItem.Click
        MsgBox("The available MIDI in devices are:" & ControlChars.CrLf & "0: MIDI Yoke NT: 1 (MMSystem)" & ControlChars.CrLf & "1: MIDI Yoke NT: 2 (MMSystem)" & ControlChars.CrLf & "2: MIDI Yoke NT: 3 (MMSystem)" & ControlChars.CrLf & "3: MIDI Yoke NT: 4 (MMSystem)" & ControlChars.CrLf & "4: MIDI Yoke NT: 5 (MMSystem)" & ControlChars.CrLf & "5: MIDI Yoke NT: 6 (MMSystem)" & ControlChars.CrLf & "6: MIDI Yoke NT: 7 (MMSystem)" & ControlChars.CrLf & "7: MIDI Yoke NT: 8 (MMSystem)" & ControlChars.CrLf & "8: micro(lite) : Port(1(MMSystem))" & ControlChars.CrLf & "9: micro(lite) : Port(2(MMSystem))" & ControlChars.CrLf & "10: micro(lite) : Port(3(MMSystem))" & ControlChars.CrLf & "11: micro(lite) : Port(4(MMSystem))" & ControlChars.CrLf & "12: micro lite: Port 5 (MMSystem)" & ControlChars.CrLf & "" & ControlChars.CrLf & "More than likely you have it.")
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Shell("calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Csound5TextEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Csound5TextEditorToolStripMenuItem.Click
        Shell("csound5gui.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub VoiceToTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoiceToTextToolStripMenuItem.Click
        text2speech.Show()

    End Sub



End Class
