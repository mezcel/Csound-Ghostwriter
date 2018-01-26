
Module Global_Functions

    '====================================================================================
    '================                  Globals                     ======================
    '====================================================================================

    Public MAX_WAVE As Integer = 4
    Public MAX_WAVE_COMPONENTS As Integer = 4

    Public waveGenerator_index As Integer
    Public waveGenerator_Total As Integer
    Public waveGenerator_component_index As Integer
    Public waveGenerator_component_Total As Integer

    Public instrument_component_Name As String
    Public waveGenerator_component_Name As String

    Public waveGenerator(MAX_WAVE, MAX_WAVE_COMPONENTS) As Integer   'vol, hz, phase, shape#, table bool      '(gnerator id, component id)
    Public wavComponentCount(4) As Integer
    Public waveGenerator_sString(MAX_WAVE, MAX_WAVE_COMPONENTS) As String     '(generator name, component name)
    Public waveTabName(MAX_WAVE) As String
    Public wavMenuSelect(MAX_WAVE) As String 'stors the opcode name coresponding to menue selection for array data
    Public adsrData(MAX_WAVE, 3) As String      'a,d,s,r, on/off
    Public adsrScbData(MAX_WAVE, 3) As Integer
    Public hpData(MAX_WAVE, 2) As Integer       'cut, res, on/off
    Public lpData(MAX_WAVE, 2) As Integer       'cut, res, on/off
    Public lfoData(MAX_WAVE, 6) As Integer      'hp level, hp hz, hp shape, lp level, lp hz, lp shape
    Public fdata_array(MAX_WAVE, 16) As Double 'ftable 16 points
    Public ftabl_array(MAX_WAVE, 2) As Integer 'table#, gen#, point#

    Public scoSec As String

    Public adsr, hipass, lowpass, lfoLP, lfoHP, ftable As Bitmap

    Public CSD As String
    'Public AppFilePath As String = "C:\Users\Public\GhostWriterData"
    Public AppFilePath As String = "C:\GhostWriterData"

    Public small_b, big_B As String
    Public loopScore As Integer
    Public loopSpeed As Double

    Public masterVolume, masterThreshold As Integer

    Public midiProc As New Process

    Public cmdComplierFlag As Boolean = False

    '====================================================================================
    '================                  Objects                     ======================
    '====================================================================================

    Public Function String2Double(ByVal str As String) As Double
        Dim str2Double As Double
        str2Double = Double.Parse(str)
        Return str2Double

    End Function

    Public Sub waveGenerator_Number2Array(ByVal str As String)
        waveGenerator(waveGenerator_index, waveGenerator_component_index) = String2Double(str) 'send converted data to array
        'waveGenerator_sString(waveGenerator_index, waveGenerator_component_index) = waveGenerator(waveGenerator_index, waveGenerator_component_index) 'send string for display
    End Sub

    Public Sub waveGenerator_String2Array(ByVal str As String)
        'waveGenerator_sString(waveGenerator_index, waveGenerator_component_index) = str 'send string for display
    End Sub

    Public Sub wave_removeShift(ByVal inst_index As Integer)
        'shift wave information down from deleted index location

        For wi As Integer = inst_index To waveGenerator_Total                       'counter shifts down all wave signal gnerators
            For wc As Integer = 0 To wavComponentCount(wi + 1)
                'match all wave signal components
                waveGenerator_sString(wi, wc) = waveGenerator_sString(wi + 1, wc) 'shift comp data
                waveGenerator(wi, wc) = waveGenerator(wi + 1, wc)
            Next

            waveTabName(wi) = waveTabName(wi + 1)
            wavComponentCount(wi) = wavComponentCount(wi + 1) 'shift component count
            wavMenuSelect(wi) = wavMenuSelect(wi + 1) 'shift menue selection

            For adsrRem As Integer = 0 To 3
                adsrData(wi, adsrRem) = adsrData(wi + 1, adsrRem)
                adsrScbData(wi, adsrRem) = adsrScbData(wi + 1, adsrRem)
            Next

            For filterRem As Integer = 0 To 2
                hpData(wi, filterRem) = hpData(wi + 1, filterRem)
                lpData(wi, filterRem) = lpData(wi + 1, filterRem)
            Next

            For lfoRem As Integer = 0 To 6
                lfoData(wi, lfoRem) = lfoData(wi + 1, lfoRem)
            Next

            For fdatRem As Integer = 0 To 16
                fdata_array(wi, fdatRem) = fdata_array(wi + 1, fdatRem)
            Next

            For ftableRem As Integer = 0 To 2
                ftabl_array(wi, ftableRem) = ftabl_array(wi + 1, ftableRem)
            Next

        Next
    End Sub
    Public Sub rebuildWavTabs(ByVal inst_index As Integer)

        For wi As Integer = inst_index To waveGenerator_Total

            tabPage_array(wi) = New TabPage
            Form1.TabControl1.Controls.Add(tabPage_array(wi))
            tabPage_array(wi).Text = waveTabName(wi) & " (" & wi & ")"
            tabPage_array(wi).BorderStyle = BorderStyle.FixedSingle

            If wavMenuSelect(wi) = "pvsosc" Then
                pvsosc_objects(wi) 'buld objects
            ElseIf wavMenuSelect(wi) = "oscil" Then
                oscil_objects(wi)
            End If

            For wc As Integer = 0 To wavComponentCount(wi) 'wavComponentCount(wi + 1)
                trkbar_array(wi, wc).Value = waveGenerator(wi, wc) 'fill objects with data
                txtbox_array(wi, wc).Text = waveGenerator_sString(wi, wc)
            Next

        Next

    End Sub

    Public Sub saveWaveArray()
        Dim ftbl As Integer
        'save wave txtBoxes into array slots

        For wi As Integer = 0 To waveGenerator_Total             'counter shifts down all wave signal gnerators

            If waveGenerator(wi, 4) = 1 Then
                ftbl = 2 'length to exclude
            Else
                ftbl = 3 'length to include
            End If

            For wc As Integer = 0 To ftbl                          'match all wave signal components
                waveGenerator_sString(wi, wc) = txtbox_array(wi, wc).Text
                waveGenerator(wi, wc) = trkbar_array(wi, wc).Value
                pvsosc_shape2value(wi)
            Next

        Next

    End Sub

    Public Sub PlaySound(ByVal ProcID As Integer)
        CSD = " " & AppFilePath & "\GhostWriter.csd"

        write2file2("\GhostWriter.csd")       'just data
        waitSeconds(0.25)   'allow write delay ISR processing time

        'ChDir(AppFilePath)
        'ProcID = Shell("csound GhostWriter.csd")

        'AppActivate(ProcID)
        Shell("csound GhostWriter.csd")

        'My.Computer.Keyboard.SendKeys("csound GhostWriter.csd")

    End Sub
    Public Sub closeShell()
        'My.Computer.Keyboard.SendKeys("(^c)", True) 'ctrl+c
        'Shell(Environ("COMSPEC") & " /C " & AppFilePath)
        My.Computer.Keyboard.SendKeys("(^c)", True) 'ctrl+c
    End Sub

    Public Sub Toggle_Dsp()
        If hpData(waveGenerator_index, 2) = 1 Then
            Form1.rbLpOn.Checked = True
        Else
            Form1.rbLpOn.Checked = False
        End If

        If lpData(waveGenerator_index, 2) = 1 Then
            Form1.rbHPOn.Checked = True
        Else
            Form1.rbHPOn.Checked = False
        End If

    End Sub

    ''CSOUNDAV COMPILER
    Public Sub CSoundAVCompiler(ByVal FileName As String)

        'Dim mtProc As New Process
        midiProc.StartInfo.FileName = "csound.exe"
        midiProc.StartInfo.Arguments = FileName

        midiProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden

        midiProc.Start()
        cmdComplierFlag = True
    End Sub

End Module

