Module Write

    Public Sub write2file() 'we must add dsp later

        Dim AMFM As String
        AMFM = " * " 'default setting
        If Form1.FMToolStripMenuItem.Checked = True Then
            AMFM = "AM" 'FM
        End If
        If Form1.AMToolStripMenuItem.Checked = True Then
            AMFM = "FM" 'AM
        End If

        saveWaveArray()
        CSD = AppFilePath & "\GhostWriter.txt"
        Dim objFile As New System.IO.StreamWriter(CSD)
        objFile.WriteLine("View/Save this text to trouble shoot any signal mixups")
        objFile.WriteLine(" ")
        objFile.WriteLine(" ")
        objFile.WriteLine("||================= Signal Rendering Output Settings =========================||")
        objFile.WriteLine("  Master Volume: " & masterVolume)
        objFile.WriteLine("  Master Threshold: " & masterThreshold)
        objFile.WriteLine("  Reverb: " & frmMainMixer.ckbReverb.Checked)
        objFile.WriteLine("  Stereo: " & frmMainMixer.rbStereo.Checked)
        objFile.WriteLine("  Sample Buffer Size: " & small_b)
        objFile.WriteLine("  Signal Layering: " & AMFM)
        objFile.WriteLine("||============================================================================||")
        objFile.WriteLine(" ")
        objFile.WriteLine("||============================================================================||")
        objFile.WriteLine("  Array ******** ( wave, component ) ***** Array_Values")
        objFile.WriteLine("||============================================================================||")

        For w As Integer = 0 To waveGenerator_Total             'counter shifts down all wave signal gnerators
            objFile.WriteLine("||============================================================================> Signal: " & w)
            For wc As Integer = 0 To 4                          'match all wave signal components
                objFile.Write("  wave (" & w & ", " & wc & " )")
                objFile.Write(" _/\_/\_/\_/\_ ")
                objFile.Write(waveTabName(w))
                objFile.Write(" _/\_/\_/\_/\_ ")
                objFile.Write(wavMenuSelect(w))
                objFile.Write(" _/\_/\_/\_/\_ ")

                pvsosc_shape2value(w)
                objFile.WriteLine(waveGenerator_sString(w, wc))
            Next
            objFile.WriteLine("==============================================================================||")
            If waveGenerator(w, 4) = 1 Then
                objFile.WriteLine(" ")
                objFile.WriteLine("Signal: " & w & " f-Table")
                objFile.WriteLine("GEN#: " & ftabl_array(w, 2))
                objFile.WriteLine("Point Size: " & ftabl_array(w, 1))
                objFile.WriteLine("table scale: 1")
                objFile.Write("  f" & (ftabl_array(w, 0) + 1) & " 0 " & ftabl_array(w, 2) & " " & ftabl_array(w, 1))
                For p As Integer = 0 To 15
                    objFile.Write(" " & fdata_array(w, p))
                Next
                objFile.WriteLine(" " & fdata_array(w, 16))
            End If
            objFile.WriteLine(" ")
            objFile.WriteLine("||============================================================================> Signal ADSR: " & w)
            objFile.WriteLine("  ADSR _/\_/\_/\_/\_  Signal: " & w)
            objFile.WriteLine("  attack = " & adsrData(w, 0))
            objFile.WriteLine("  decay = " & adsrData(w, 1))
            objFile.WriteLine("  sustain = " & adsrData(w, 2))
            objFile.WriteLine("  release = " & adsrData(w, 3))
            objFile.WriteLine("||============================================================================> Signal LFO: " & w)
            objFile.WriteLine("  LFO _/\_/\_/\_/\_  Signal: " & w)
            objFile.WriteLine("||~~~ HP LFO ~~~||")
            objFile.WriteLine("  Ammount = " & lfoData(w, 0))
            objFile.WriteLine("  Speed = " & lfoData(w, 1))
            objFile.WriteLine("  Shape = " & lfoData(w, 5))
            objFile.WriteLine("||~~~ LP LFO ~~~||")
            objFile.WriteLine("  Ammount = " & lfoData(w, 3))
            objFile.WriteLine("  Speed = " & lfoData(w, 4))
            objFile.WriteLine("  Shape = " & lfoData(w, 2))
            objFile.WriteLine("||============================================================================> Signal FILTERS: " & w)
            objFile.WriteLine("  HP Filter _/\_/\_/\_/\_  Signal: " & w)
            If hpData(w, 2) = 1 Then
                objFile.WriteLine("    Cuttoff Hz = " & hpData(w, 0))
                objFile.WriteLine("    Rez Hz = " & hpData(w, 1))
            Else
                objFile.WriteLine("    HP Filter = OFF")
            End If
            objFile.WriteLine("  LP Filter _/\_/\_/\_/\_  Signal: " & w)
            If lpData(w, 2) = 1 Then
                objFile.WriteLine("    Cuttoff Hz =  " & lpData(w, 0))
                objFile.WriteLine("    Rez Hz = " & lpData(w, 1))
            Else
                objFile.WriteLine("    LP Filter = OFF")
            End If
            objFile.WriteLine(" ")
            objFile.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=")
            objFile.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=")
            objFile.WriteLine(" ")
        Next
        
        objFile.WriteLine(" ")
        CSD = AppFilePath & "\GhostWriter.csd"
        'objFile.Write(CSD)
        objFile.WriteLine(";;; =========== Location of current .txt file directory ======================================== ")
        objFile.WriteLine(";;; " & CSD)
        objFile.WriteLine(";;; For questions or help: (mezcel@icqmail.com) or  (http://groups.google.com/group/mezcel_sound)")
        objFile.WriteLine(";;; ============================================================================================ ")


        objFile.Close()

    End Sub

    Public Sub write2file2(ByVal CSDName As String) 'we must add dsp later
        Dim Temp_scoSec As String
        Temp_scoSec = scoSec

        Dim outputString, first, second, AMFM As String
        Dim loopSpeedOriginal As Double
        'CSDName = "\GhostWriter.csd"
        saveWaveArray()

        AMFM = " * " 'default setting
        If Form1.FMToolStripMenuItem.Checked = True Then
            AMFM = " * " 'FM
        ElseIf Form1.AMToolStripMenuItem.Checked = True Then
            AMFM = " + " 'AM
        End If

        CSD = AppFilePath & CSDName
        Dim objFile1 As New System.IO.StreamWriter(CSD)

        objFile1.WriteLine("<CsoundSynthesizer>")
        objFile1.WriteLine("<CsOptions>")

        If Form1.MidiControlToolStripMenuItem.Checked = True Then
            objFile1.Write("-iadc -M0 ") 'midi output
            scoSec = "100"
        End If
        objFile1.Write(" -odac")
        objFile1.Write(" -b" & small_b)
        objFile1.WriteLine(" -B" & big_B)

        objFile1.WriteLine("</CsOptions>")
        objFile1.WriteLine(" ")
        objFile1.WriteLine("<CsInstruments>")
        objFile1.WriteLine("sr = 44100")
        objFile1.WriteLine("kr = 4410")
        objFile1.WriteLine("ksmps = 10")
        objFile1.WriteLine("nchnls = 1") 'mono sognal

        objFile1.WriteLine(" ")
        objFile1.WriteLine("instr 1")
        objFile1.WriteLine(" ")

        If Form1.MidiControlToolStripMenuItem.Checked = True Then
            objFile1.WriteLine("icps cpsmidi") 'midi output
        End If

        For w As Integer = 0 To waveGenerator_Total             'counter shifts down all wave signal gnerators

            If Form1.MidiControlToolStripMenuItem.Checked = True Then
                objFile1.WriteLine("icustPitch = icps") 'midi output
            Else
                objFile1.WriteLine("icustPitch = " & waveGenerator_sString(w, 1))
            End If

            If waveGenerator_sString(w, 2) > 0 Then
                objFile1.WriteLine("kphasor" & (w + 1) & " phasor " & waveGenerator_sString(w, 2))
            Else
                objFile1.WriteLine("kphasor" & (w + 1) & " = 1") 'hold state
            End If
            objFile1.WriteLine(" ")
            'define LFOs
            objFile1.WriteLine("klp" & (w + 1) & " lfo " & lfoData(w, 3) & ", " & lfoData(w, 4) & ", " & lfoData(w, 2))
            objFile1.WriteLine("khp" & (w + 1) & " lfo " & lfoData(w, 0) & ", " & lfoData(w, 1) & ", " & lfoData(w, 5))

            objFile1.WriteLine(" ")
            If wavMenuSelect(w) = "pvsosc" Then

                objFile1.WriteLine("kenv" & (w + 1) & " adsr" & " " & adsrData(w, 0) & " , " & adsrData(w, 1) & " , " & adsrData(w, 2) & " , " & adsrData(w, 3))
                objFile1.WriteLine("f" & waveTabName(w) & " " & wavMenuSelect(w) & " " & waveGenerator_sString(w, 0) & " * kenv" & (w + 1) & " * kphasor" & (w + 1) & " , " & "icustPitch" & " , " & waveGenerator_sString(w, 3) & " , 1024")
                objFile1.WriteLine("a" & waveTabName(w) & " pvsynth " & "f" & waveTabName(w))

                'filters
                If lpData(w, 2) = 1 Then
                    objFile1.WriteLine("alpres" & waveTabName(w) & " bqrez " & "a" & waveTabName(w) & " , " & lpData(w, 0) & " + klp" & (w + 1) & ", " & lpData(w, 1) & ", 0")
                Else
                    outputString = "alpres" & waveTabName(w) & " pvsynth " & "f" & waveTabName(w)
                    objFile1.WriteLine(outputString & " ;; same signal just no LP")
                End If

                If hpData(w, 2) = 1 Then
                    objFile1.WriteLine("ahpres" & waveTabName(w) & " bqrez " & "alpres" & waveTabName(w) & " , " & hpData(w, 0) & " + khp" & (w + 1) & " , " & hpData(w, 1) & ", 1")
                ElseIf hpData(w, 2) = 0 And lpData(w, 2) = 1 Then
                    outputString = "ahpres" & waveTabName(w) & " bqrez " & "a" & waveTabName(w) & " , " & lpData(w, 0) & " + klp" & (w + 1) & " , " & lpData(w, 1) & ", 0"
                    objFile1.WriteLine(outputString & " ;; same signal no HP")
                ElseIf hpData(w, 2) = 0 And lpData(w, 2) = 0 Then
                    outputString = "ahpres" & waveTabName(w) & " pvsynth " & "f" & waveTabName(w)
                    objFile1.WriteLine(outputString & " ;; same signal just no LP and no HP")
                End If

            End If

            If wavMenuSelect(w) = "oscil" Then
                objFile1.WriteLine("kenv" & (w + 1) & " adsr" & " " & adsrData(w, 0) & " , " & adsrData(w, 1) & " , " & adsrData(w, 2) & " , " & adsrData(w, 3))
                objFile1.WriteLine("a" & waveTabName(w) & " " & wavMenuSelect(w) & " " & waveGenerator_sString(w, 0) & " + kenv" & (w + 1) & " * kphasor" & (w + 1) & " , " & "icustPitch" & " , " & (ftabl_array(w, 0) + 1) & ", " & (waveGenerator_sString(w, 2) / 100))

                'filters
                If hpData(w, 2) = 1 Then
                    objFile1.WriteLine("alpres" & waveTabName(w) & " bqrez " & "a" & waveTabName(w) & " , " & lpData(w, 0) & " * klp" & (w + 1) & " , " & lpData(w, 1) & ", 0")
                Else
                    outputString = "alpres" & waveTabName(w) & " " & wavMenuSelect(w) & " " & waveGenerator_sString(w, 0) & " + kenv" & (w + 1) & " , " & "icustPitch" & " , " & (ftabl_array(w, 0) + 1) & ", " & (waveGenerator_sString(w, 2) / 100)
                    objFile1.WriteLine(outputString & " ;; same signal new name only")
                End If
                If lpData(w, 2) = 1 Then
                    objFile1.WriteLine("ahpres" & waveTabName(w) & " bqrez " & "alpres" & waveTabName(w) & " , " & hpData(w, 0) & " + khp" & (w + 1) & " , " & hpData(w, 1) & ", 1")
                Else
                    outputString = "ahpres" & waveTabName(w) & " " & wavMenuSelect(w) & " " & waveGenerator_sString(w, 0) & " + kenv" & (w + 1) & " , " & "icustPitch" & " , " & (ftabl_array(w, 0) + 1) & ", " & (waveGenerator_sString(w, 2) / 100)
                    objFile1.WriteLine(outputString & " ;; same signal new name only")
                End If
            End If

        Next
        objFile1.WriteLine("")

        outputString = "ahpres" & waveTabName(0)
        If waveGenerator_Total > 0 Then
            first = "ahpres" & waveTabName(0)
            For w As Integer = 1 To waveGenerator_Total             'counter shifts down all wave signal gnerators
                second = first & AMFM & "ahpres" & waveTabName(w)
                first = second
            Next
            outputString = first
        End If
        objFile1.WriteLine("anormalOut balance " & outputString & " , " & " a" & waveTabName(0))

        'reverb component from main mixer
        If Form1.MidiControlToolStripMenuItem.Checked = True Then

            'objFile1.WriteLine("out anormalOut")
          
            objFile1.WriteLine("out anormalOut * " & (masterVolume / 100) * (masterThreshold / 50)) 'masterVolume, masterThreshold

        Else
        'objFile1.WriteLine("out anormalOut")


        If frmMainMixer.ckbReverb.Checked = True Then
            objFile1.WriteLine("areb reverb anormalOut, " & frmMainMixer.trkbReverbTime.Value & " , " & frmMainMixer.trkbReverbDensity.Value / 10)
            'objFile1.WriteLine("areb vdelay anormalOut, " & frmMainMixer.trkbReverbTime.Value & " , " & frmMainMixer.trkbReverbDensity.Value / 10)

            objFile1.WriteLine("out areb")
        Else
            objFile1.WriteLine("out anormalOut * " & (masterVolume / 100) * (masterThreshold / 50)) 'masterVolume, masterThreshold
        End If
        End If
        objFile1.WriteLine(" ")
        objFile1.WriteLine("endin")
        objFile1.WriteLine("</CsInstruments>")
        objFile1.WriteLine("<CsScore>")

        For wcomp As Integer = 0 To 1 'waveGenerator_Total
            If waveGenerator(wcomp, 4) = 1 Then
                For w As Integer = 0 To waveGenerator_Total
                    objFile1.Write("f" & (ftabl_array(w, 0) + 1) & " 0 " & ftabl_array(w, 2) & " " & ftabl_array(w, 1))
                    For p As Integer = 0 To 16
                        objFile1.Write(" " & fdata_array(w, p))
                    Next
                    objFile1.WriteLine(" ")
                Next
            End If
        Next

        If Form1.MidiControlToolStripMenuItem.Checked = True Then
            objFile1.WriteLine("f 0 3600") 'midi dummy table output
            '================================
            objFile1.WriteLine(" ")
        Else
            objFile1.WriteLine(" ")

            loopSpeedOriginal = loopSpeed
            If loopScore > 0 Then
                For l As Integer = 0 To loopScore
                    loopSpeed = loopSpeedOriginal + loopSpeed
                    objFile1.WriteLine("i 1 " & loopSpeed & " " & scoSec)
                Next
            Else
                objFile1.WriteLine("i 1 0 " & scoSec)
                objFile1.WriteLine("e")
            End If
            loopSpeed = loopSpeedOriginal 'reset tempo
        End If



        objFile1.WriteLine("</CsScore>")
        objFile1.WriteLine(" ")
        objFile1.WriteLine(";;; =========== Location of current .csd file directory ======================================== ")
        objFile1.WriteLine(";;; " & CSD)
        objFile1.WriteLine(";;; For questions or help: (mezcel@icqmail.com) or  (http://groups.google.com/group/mezcel_sound)")
        objFile1.WriteLine(";;; ============================================================================================ ")
        objFile1.WriteLine("</CsoundSynthesizer>")
        objFile1.WriteLine(" ")

        objFile1.Close()

        'restore original sustain
        scoSec = Temp_scoSec

    End Sub

    Public Sub opening_sound()
        'Dim AppFilePath As String = My.Application.Info.DirectoryPath
        'Dim CSD As String

        
        CSD = AppFilePath & "\spashSound.csd"

        Dim objFile3 As New System.IO.StreamWriter(CSD)
        
        objFile3.WriteLine("<CsoundSynthesizer>")

        objFile3.WriteLine("<CsOptions>")
        objFile3.WriteLine("-b 10000 ;;;bufer size in sample frames")
        objFile3.WriteLine("-odac ;;;RT audio I/O")
        objFile3.WriteLine("</CsOptions>")

        objFile3.WriteLine("<CsInstruments>")

        objFile3.WriteLine("nchnls = 1")
        objFile3.WriteLine("instr 1")
        objFile3.WriteLine("aq barmodel 1, 1, p4, 0.001, 0.23, 5, p5, p6, p7")
        objFile3.WriteLine("out      aq")
        objFile3.WriteLine("endin")
        objFile3.WriteLine("</CsInstruments>")
        objFile3.WriteLine("<CsScore>")
        objFile3.WriteLine("i1 0 0.5 3 0.2 1000 0.05")
        objFile3.WriteLine("i1 0.5 0.5 -3 0.3 2000 0.05")
        objFile3.WriteLine("i1 1.0 0.5 -3 0.4 2000 0.1")
        objFile3.WriteLine("i1 1.5 4.0 -3 0.5 1600 0.05")
        objFile3.WriteLine("e")
        objFile3.WriteLine("</CsScore>")
        objFile3.WriteLine("</CsoundSynthesizer>")
        

        objFile3.Close()


        CSD = " " & CSD
        Shell("csound" & CSD)
    End Sub
End Module
