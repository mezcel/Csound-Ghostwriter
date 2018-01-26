Module Data

    Public Sub waitSeconds(ByVal sec As Double)

        Dim start, finish As Double

        start = Microsoft.VisualBasic.DateAndTime.Timer
        ' Set end time for 5-second duration.
        finish = start + sec
        Do While Microsoft.VisualBasic.DateAndTime.Timer < finish
            ' Do other processing while waiting for 5 seconds to elapse.
        Loop
    End Sub

    Public Sub initialize_filters(ByVal w As Integer)
        Form1.hipassCutoff.Value = 1
        hpData(w, 0) = 222
        Form1.hipassRes.Value = 1
        hpData(w, 1) = 222
        hpData(w, 2) = 1

        Form1.lowpassCutoff.Value = 0
        lpData(w, 0) = 300 '220 * (9 + (13 / 23)) + 200
        Form1.lowpassRes.Value = 0
        lpData(w, 1) = 300 '220 * (9 + (13 / 23)) + 200
        lpData(w, 2) = 1

        update_filters(w)
    End Sub

    Public Sub update_filters(ByVal w As Integer)
        If Int((hpData(w, 0) - 200) / (9 + (13 / 23))) <> (-21) Then 'used for shift delete (Form1.hipassCutoff.Value cant be = to -21)

            'match filter on/off switch state will saved array state
            If lpData(w, 2) = 1 Then
                Form1.rbLpOn.Checked = True
                Form1.rbLpOff.Checked = False
            Else
                Form1.rbLpOn.Checked = False
                Form1.rbLpOff.Checked = True
            End If

            If hpData(w, 2) = 1 Then
                Form1.rbHPOn.Checked = True
                Form1.rbHPOff.Checked = False
            Else
                Form1.rbHPOn.Checked = False
                Form1.rbHPOff.Checked = True
            End If

            'save filter on/off state to array value
            Form1.hipassCutoff.Value = (hpData(w, 0) - 200) / (9 + (13 / 23))
            Form1.hipassRes.Value = (hpData(w, 1) - 200) / (9 + (13 / 23))
            If Form1.rbHPOn.Checked = True Then
                hpData(w, 2) = 1
            Else
                hpData(w, 2) = 0
            End If

            Form1.lowpassCutoff.Value = (lpData(w, 0) - 200) / (9 + (13 / 23))
            Form1.lowpassRes.Value = (lpData(w, 1) - 200) / (9 + (13 / 23))
            If Form1.rbLpOn.Checked = True Then
                lpData(w, 2) = 1
            Else
                lpData(w, 2) = 0
            End If

        End If

    End Sub

    Public Sub initialize_ADSR(ByVal w As Integer)
        adsrScbData(w, 0) = -1
        adsrScbData(w, 1) = -90
        adsrScbData(w, 2) = -90
        adsrScbData(w, 3) = -70

        adsrData(w, 0) = 0.1
        adsrData(w, 1) = 0.9
        adsrData(w, 2) = 0.9
        adsrData(w, 3) = 0.7

    End Sub

    Public Sub initializeLfoData(ByVal w As Integer)

        Form1.tkbLFO_HP_level.Value = 1 'llevel
        Form1.tkbLFO_HP_Hz.Value = 1  'lhz
        Form1.tkbLFO_HP_Shape.Value = 1 'lshape

       
        Form1.tkbLFO_LP_level.Value = 1 'llevel
        Form1.tkbLFO_LP_Hz.Value = 1 'lhz
        Form1.tkbLFO_LP_Shape.Value = 1 'lshape

        lfoData(w, 0) = Form1.tkbLFO_HP_level.Value * 100 'hlevel
        lfoData(w, 1) = Form1.tkbLFO_HP_Hz.Value * 2 'hhz
        lfoData(w, 2) = Form1.tkbLFO_HP_Shape.Value 'hshape

        lfoData(w, 3) = Form1.tkbLFO_LP_level.Value * 100 'llevel
        lfoData(w, 4) = Form1.tkbLFO_LP_Hz.Value * 2 'lhz
        lfoData(w, 5) = Form1.tkbLFO_LP_Shape.Value 'lshape

        save_LFO(w)

    End Sub

    Public Sub update_LFO(ByVal w As Integer)
        If lfoData(w, 0) >= 100 Then
            Form1.tkbLFO_LP_level.Value = lfoData(w, 3) / 100 'llevel
        Else
            Form1.tkbLFO_LP_level.Value = 0
        End If

        If lfoData(w, 1) >= 2 Then
            Form1.tkbLFO_LP_Hz.Value = lfoData(w, 4) / 2
        Else
            Form1.tkbLFO_LP_Hz.Value = 1 'lhz
        End If

        Form1.tkbLFO_LP_Shape.Value = lfoData(w, 2) 'lshape

        '~~~~~~~~~~~~~~~~~~~~~~~

        If lfoData(w, 3) >= 100 Then
            Form1.tkbLFO_HP_level.Value = lfoData(w, 0) / 100 'llevel
        Else
            Form1.tkbLFO_HP_level.Value = 0
        End If

        If lfoData(w, 4) >= 2 Then
            Form1.tkbLFO_HP_Hz.Value = lfoData(w, 1) / 2
        Else
            Form1.tkbLFO_HP_Hz.Value = 1  'lhz
        End If

        Form1.tkbLFO_HP_Shape.Value = lfoData(w, 5) 'lshape

    End Sub

    Public Sub save_LFO(ByVal w As Integer)
        lfoData(w, 0) = Form1.tkbLFO_HP_level.Value * 100
        lfoData(w, 1) = Form1.tkbLFO_HP_Hz.Value * 2
        lfoData(w, 2) = Form1.tkbLFO_HP_Shape.Value

        lfoData(w, 3) = Form1.tkbLFO_LP_level.Value * 100
        lfoData(w, 4) = Form1.tkbLFO_LP_Hz.Value * 2
        lfoData(w, 5) = Form1.tkbLFO_LP_Shape.Value

    End Sub

    Public Sub update_adsr(ByVal w As Integer)
        Form1.VSAttack.Value = adsrScbData(w, 0)
        Form1.VSDecay.Value = adsrScbData(w, 1)
        Form1.VSSustain.Value = adsrScbData(w, 2)
        Form1.VSRelease.Value = adsrScbData(w, 3)

    End Sub

    Public Sub add_signal()

        If Form1.cbSynthSelect.Text <> " Synth Select" And waveGenerator_Total < MAX_WAVE Then
            Form1.OpenToolStripMenuItem.Enabled = True
            Form1.SaveToolStripMenuItem.Enabled = True
            Form1.WritecsdToolStripMenuItem.Enabled = True
            Form1.WriteorcToolStripMenuItem.Enabled = True

            'waveGenerator_Total = waveGenerator_index

            If Form1.waveInitSwitch_Array(waveGenerator_index) = True Then
                If waveGenerator_Total < MAX_WAVE Then

                    waveGenerator_Total = waveGenerator_Total + 1
                    waveGenerator_index = waveGenerator_Total

                    'update graphics
                    initialize_filters(waveGenerator_index)
                    initializeLfoData(waveGenerator_index)
                    update_filters(waveGenerator_index)
                    initialize_ADSR(waveGenerator_index)

                    Form1.txtWaveIndex.Text = waveGenerator_index
                    Form1.txtWaveBase.Text = "of [" & waveGenerator_Total & "]"

                End If
            End If

            'input the tab name
            waveTabName(waveGenerator_index) = InputBox("Name Signal Generator:", "Signal Generator Name")

            tabPage_array(waveGenerator_index) = New TabPage
            Form1.TabControl1.Controls.Add(tabPage_array(waveGenerator_index))

            tabPage_array(waveGenerator_index).Text = waveTabName(waveGenerator_index) & " (" & waveGenerator_index & ")"
            tabPage_array(waveGenerator_index).BorderStyle = BorderStyle.FixedSingle

            'sender name
            tabPage_array(waveGenerator_index).Name = waveGenerator_index
            
            Form1.PictureBox4.Visible = False
            Wave_menu(waveGenerator_index, Form1.cbSynthSelect.Text)

            Form1.waveInitSwitch_Array(waveGenerator_index) = True 'activate wave max growth on next add


        End If

        Form1.cbSynthSelect.Text = " Synth Select"

        'sync index number with tab view
        If Form1.waveInitSwitch_Array(waveGenerator_index) = True Then
            Form1.TabControl1.SelectedTab = tabPage_array(waveGenerator_index)
        End If

        update_adsr(waveGenerator_index)

        Form1.rbLpOff.Checked = True
        Form1.rbHPOff.Checked = True

        Form1.btnWaveFront.Enabled = True
        Form1.btnWavePrevious.Enabled = True
        Form1.btnWaveNext.Enabled = True
        Form1.btnWaveRear.Enabled = True

        Form1.SaveToolStripMenuItem.Enabled = True
        Form1.EditCurrentFTableToolStripMenuItem.Enabled = True
        Form1.RemoveInstrumentToolStripMenuItem.Enabled = True
        Form1.WritecsdToolStripMenuItem.Enabled = True
        Form1.WriteorcToolStripMenuItem.Enabled = True

        Form1.TopLevelMixerToolStripMenuItem.Enabled = True

    End Sub

End Module
