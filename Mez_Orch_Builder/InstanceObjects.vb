Module InstanceObjects

    'array( waveType)
    Public tabPage_array(5) As TabPage

    'array( waveType, component_id)
    Public trkbar_array(MAX_WAVE, MAX_WAVE_COMPONENTS) As TrackBar
    Public txtbox_array(MAX_WAVE, MAX_WAVE_COMPONENTS) As TextBox
    Public lblbox_array(MAX_WAVE, MAX_WAVE_COMPONENTS) As TextBox
    'Public rdobtn_array(MAX_WAVE, MAX_WAVE_COMPONENTS) As RadioButton
    Public oscili_array(MAX_WAVE) As Button

    Public instance_objectVar As Integer


    Public Sub pvsosc_objects(ByVal waveType As Integer)
        'p.1343
        'pvsosc
        'pvsosc -- PVS-based oscillator simulator.

        'Description
        'Generates periodic signal spectra in AMP-FREQ format, with the option of four wave types:
        '1. sawtooth-like (harmonic weight 1/n, where n is partial number)
        '2. square-like (similar to 1., but only odd partials)
        '3. pulse (all harmonics with same weight)
        '4: cosine

        'Complex waveforms (ie. all types except cosine) contain all harmonics up to the Nyquist. This
        'makes pvsosc an option for generation of band-limited periodic waves. In addition, types can be
        'changed using a k-rate variable.

        'Syntax
        'fsig pvsosc kamp, kfreq, ktype, isize[,iolap]

        'InStr 1
        '; a band-limited sawtooth-wave oscillator
        'fsig pvsosc 10000, 440, 1, 1024 ; generate wave spectral signal
        'asig pvsynth fsig ; resynthesise it
        '        out asig 
        '        endin

        wavMenuSelect(waveType) = "pvsosc"
        wavComponentCount(waveType) = 3
        waveGenerator(waveType, 4) = 0 'no f table
        waveGenerator_sString(waveType, 4) = "no ftable"


        For component_id As Integer = 0 To wavComponentCount(waveType) 'display track bars
            trkbar_array(waveType, component_id) = New TrackBar
            tabPage_array(waveType).Controls.Add(trkbar_array(waveType, component_id))

            trkbar_array(waveType, component_id).Location = New Point(20 + component_id * 75, 30)
            trkbar_array(waveType, component_id).Orientation = Orientation.Vertical
            trkbar_array(waveType, component_id).Size = New System.Drawing.Size(10, 90)
            trkbar_array(waveType, component_id).Maximum = 20000 'over produce just for crash safety
            trkbar_array(waveType, component_id).Minimum = 0
            trkbar_array(waveType, component_id).TickFrequency = 10
            trkbar_array(waveType, component_id).Cursor = Cursors.SizeNS

        Next

        For component_id As Integer = 0 To wavComponentCount(waveType) 'display textboxes for trackbars
            txtbox_array(waveType, component_id) = New TextBox
            tabPage_array(waveType).Controls.Add(txtbox_array(waveType, component_id))

            txtbox_array(waveType, component_id).Location = New Point(20 + component_id * 75, 7)
            txtbox_array(waveType, component_id).Size = New System.Drawing.Size(50, 20)
            txtbox_array(waveType, component_id).TextAlign = HorizontalAlignment.Center
        Next

        For component_id As Integer = 0 To wavComponentCount(waveType) 'display lable names for trackbars
            lblbox_array(waveType, component_id) = New TextBox
            tabPage_array(waveType).Controls.Add(lblbox_array(waveType, component_id))

            lblbox_array(waveType, component_id).Location = New Point(20 + component_id * 75, 120)
            lblbox_array(waveType, component_id).Size = New System.Drawing.Size(50, 20)
            lblbox_array(waveType, component_id).Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblbox_array(waveType, component_id).TextAlign = HorizontalAlignment.Center
            lblbox_array(waveType, component_id).BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))

            Select Case component_id

                Case 0
                    lblbox_array(waveType, component_id).Text = "Volume"
                    AddHandler trkbar_array(waveGenerator_index, component_id).Scroll, AddressOf pvsoscControl_ValueChanged '( waveType, component_id)
                    txtbox_array(waveType, component_id).Text = 0
                    AddHandler txtbox_array(waveGenerator_index, 0).TextChanged, AddressOf txtUpdateScrollBars_TextChanged
                    trkbar_array(waveType, component_id).Maximum = 20000
                    trkbar_array(waveType, component_id).Minimum = 0
                    trkbar_array(waveType, component_id).Value = 0
                    trkbar_array(waveType, component_id).TickFrequency = 1000
                    trkbar_array(waveType, component_id).SmallChange = 100

                Case 1
                    lblbox_array(waveType, component_id).Text = "Hz"
                    AddHandler trkbar_array(waveGenerator_index, component_id).Scroll, AddressOf pvsoscControl_ValueChanged '( waveType, component_id)
                    txtbox_array(waveType, component_id).Text = 300
                    AddHandler txtbox_array(waveGenerator_index, 1).TextChanged, AddressOf txtUpdateScrollBars_TextChanged
                    trkbar_array(waveType, component_id).Maximum = 1500
                    trkbar_array(waveType, component_id).Minimum = 20
                    trkbar_array(waveType, component_id).TickFrequency = 100
                    trkbar_array(waveType, component_id).SmallChange = 100

                Case 2
                    lblbox_array(waveType, component_id).Text = "Phasor"
                    AddHandler trkbar_array(waveGenerator_index, component_id).Scroll, AddressOf pvsoscControl_ValueChanged '( waveType, component_id)
                    txtbox_array(waveType, component_id).Text = 0
                    AddHandler txtbox_array(waveGenerator_index, 1).TextChanged, AddressOf txtUpdateScrollBars_TextChanged
                    trkbar_array(waveType, component_id).Maximum = 20
                    trkbar_array(waveType, component_id).Minimum = 0
                    trkbar_array(waveType, component_id).TickFrequency = 2
                    trkbar_array(waveType, component_id).SmallChange = 2

                Case 3
                    lblbox_array(waveType, component_id).Text = "Shape"
                    AddHandler trkbar_array(waveGenerator_index, component_id).Scroll, AddressOf pvsoscControl_ValueChanged '( waveType, component_id)
                    txtbox_array(waveType, component_id).Text = "Saw"
                    trkbar_array(waveType, component_id).Maximum = 4
                    trkbar_array(waveType, component_id).Minimum = 1
                    trkbar_array(waveType, component_id).TickFrequency = 1
                    trkbar_array(waveType, component_id).SmallChange = 1

            End Select
        Next

    End Sub

    Private Sub pvsoscControl_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtbox_array(waveGenerator_index, 0).Text = trkbar_array(waveGenerator_index, 0).Value
        txtbox_array(waveGenerator_index, 1).Text = trkbar_array(waveGenerator_index, 1).Value
        txtbox_array(waveGenerator_index, 2).Text = trkbar_array(waveGenerator_index, 2).Value

        If wavComponentCount(waveGenerator_index) = 3 Then
            Select Case trkbar_array(waveGenerator_index, 3).Value
                Case 1
                    txtbox_array(waveGenerator_index, 3).Text = "Saw"
                Case 2
                    txtbox_array(waveGenerator_index, 3).Text = "Square"
                Case 3
                    txtbox_array(waveGenerator_index, 3).Text = "Pulse"
                Case 4
                    txtbox_array(waveGenerator_index, 3).Text = "Cosine"
            End Select
        End If

    End Sub

    Private Sub txtUpdateScrollBars_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtbox_array(waveGenerator_index, 0).Text >= 0 And txtbox_array(waveGenerator_index, 0).Text <= 20000 Then
            trkbar_array(waveGenerator_index, 0).Value = txtbox_array(waveGenerator_index, 0).Text
        Else
            txtbox_array(waveGenerator_index, 0).Text = 0
        End If

        If txtbox_array(waveGenerator_index, 1).Text >= 20 And txtbox_array(waveGenerator_index, 1).Text <= 1500 Then
            trkbar_array(waveGenerator_index, 1).Value = txtbox_array(waveGenerator_index, 1).Text
        Else
            txtbox_array(waveGenerator_index, 1).Text = 300 + txtbox_array(waveGenerator_index, 1).Text * 10
        End If

        If txtbox_array(waveGenerator_index, 2).Text >= 0 And txtbox_array(waveGenerator_index, 2).Text <= 20 Then
            trkbar_array(waveGenerator_index, 2).Value = txtbox_array(waveGenerator_index, 2).Text
        Else
            txtbox_array(waveGenerator_index, 2).Text = txtbox_array(waveGenerator_index, 2).Text
        End If


    End Sub

    Public Sub pvsosc_shape2value(ByVal w_index As Integer)
        Select Case waveGenerator_sString(w_index, 3)
            Case "Saw"
                waveGenerator_sString(w_index, 3) = 1
                waveGenerator(w_index, 3) = 1
            Case "Square"
                waveGenerator_sString(w_index, 3) = 2
                waveGenerator(w_index, 3) = 2
            Case "Pulse"
                waveGenerator_sString(w_index, 3) = 3
                waveGenerator(w_index, 3) = 3
            Case "Cosine"
                waveGenerator_sString(w_index, 3) = 4
                waveGenerator(w_index, 3) = 4
        End Select

    End Sub

    Private Sub oscilFtable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFstatement.Show()
    End Sub

    Public Sub oscil_objects(ByVal waveType As Integer)

        wavMenuSelect(waveType) = "oscil"
        wavComponentCount(waveType) = 2
        waveGenerator(waveType, 4) = 1 'yes f-table
        waveGenerator_sString(waveType, 4) = "yes ftable"
        ftabl_array(waveType, 0) = waveType
        ftabl_array(waveType, 2) = 16

        frmFstatement.cbGENselect.Text = "GEN Routine"
        frmFstatement.txtSignalName.Text = waveTabName(waveType)

        oscili_array(waveType) = New Button
        tabPage_array(waveType).Controls.Add(oscili_array(waveType))
        oscili_array(waveType).Location = New Point(20 + 3 * 75, 20)
        oscili_array(waveType).Size = New System.Drawing.Size(220, 100)
        oscili_array(waveType).Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        oscili_array(waveType).Text = "Edit Waveform in f-table"
        AddHandler oscili_array(waveType).Click, AddressOf oscilFtable_Click


        For component_id As Integer = 0 To wavComponentCount(waveType) 'display track bars
            trkbar_array(waveType, component_id) = New TrackBar
            tabPage_array(waveType).Controls.Add(trkbar_array(waveType, component_id))

            trkbar_array(waveType, component_id).Location = New Point(20 + component_id * 75, 30)
            trkbar_array(waveType, component_id).Orientation = Orientation.Vertical
            trkbar_array(waveType, component_id).Size = New System.Drawing.Size(10, 90)
            trkbar_array(waveType, component_id).Maximum = 20000
            trkbar_array(waveType, component_id).Minimum = 0
            trkbar_array(waveType, component_id).TickFrequency = 10
            trkbar_array(waveType, component_id).Cursor = Cursors.SizeNS

        Next

        For component_id As Integer = 0 To wavComponentCount(waveType) 'display textboxes for trackbars
            txtbox_array(waveType, component_id) = New TextBox
            tabPage_array(waveType).Controls.Add(txtbox_array(waveType, component_id))

            txtbox_array(waveType, component_id).Location = New Point(20 + component_id * 75, 7)
            txtbox_array(waveType, component_id).Size = New System.Drawing.Size(50, 20)
            txtbox_array(waveType, component_id).TextAlign = HorizontalAlignment.Center
        Next

        For component_id As Integer = 0 To wavComponentCount(waveType) 'display lable names for trackbars
            lblbox_array(waveType, component_id) = New TextBox
            tabPage_array(waveType).Controls.Add(lblbox_array(waveType, component_id))

            lblbox_array(waveType, component_id).Location = New Point(20 + component_id * 75, 120)
            lblbox_array(waveType, component_id).Size = New System.Drawing.Size(50, 20)
            lblbox_array(waveType, component_id).Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblbox_array(waveType, component_id).TextAlign = HorizontalAlignment.Center
            lblbox_array(waveType, component_id).BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))

            Select Case component_id

                Case 0
                    lblbox_array(waveType, component_id).Text = "Volume"
                    AddHandler trkbar_array(waveGenerator_index, component_id).Scroll, AddressOf pvsoscControl_ValueChanged '( waveType, component_id)
                    txtbox_array(waveType, component_id).Text = 0
                    AddHandler txtbox_array(waveGenerator_index, 0).TextChanged, AddressOf txtUpdateScrollBars_TextChanged
                    trkbar_array(waveType, component_id).Maximum = 20000
                    trkbar_array(waveType, component_id).Minimum = 0
                    trkbar_array(waveType, component_id).Value = 0
                    trkbar_array(waveType, component_id).TickFrequency = 1000
                    trkbar_array(waveType, component_id).SmallChange = 100

                Case 1
                    lblbox_array(waveType, component_id).Text = "Hz"
                    AddHandler trkbar_array(waveGenerator_index, component_id).Scroll, AddressOf pvsoscControl_ValueChanged '( waveType, component_id)
                    txtbox_array(waveType, component_id).Text = 300
                    AddHandler txtbox_array(waveGenerator_index, 1).TextChanged, AddressOf txtUpdateScrollBars_TextChanged
                    trkbar_array(waveType, component_id).Maximum = 1500
                    trkbar_array(waveType, component_id).Minimum = 20
                    trkbar_array(waveType, component_id).TickFrequency = 100
                    trkbar_array(waveType, component_id).SmallChange = 100

                Case 2
                    lblbox_array(waveType, component_id).Text = "Phasor"
                    AddHandler trkbar_array(waveGenerator_index, component_id).Scroll, AddressOf pvsoscControl_ValueChanged '( waveType, component_id)
                    txtbox_array(waveType, component_id).Text = 0
                    AddHandler txtbox_array(waveGenerator_index, 1).TextChanged, AddressOf txtUpdateScrollBars_TextChanged
                    trkbar_array(waveType, component_id).Maximum = 20
                    trkbar_array(waveType, component_id).Minimum = 0
                    trkbar_array(waveType, component_id).TickFrequency = 10
                    trkbar_array(waveType, component_id).SmallChange = 10
            End Select
        Next


    End Sub

    Public Sub Wave_menu(ByVal waveType As Integer, ByVal menu As String)
        'reads the dropdown box and loads its coresponding function
        Select Case menu
            Case "pvsosc"
                pvsosc_objects(waveType)

            Case "oscil"
                oscil_objects(waveType)
                frmFstatement.Show()

            Case Else
                Debug.WriteLine("Not active yet :'(")
        End Select

    End Sub

End Module
