Module GraphicsControl
    '====================================================================================
    '================               Graphics Controll ADSR         ======================
    '====================================================================================

    Public Sub drawAttack()

        Dim objGraphics As Graphics
        Dim objMyPen As Pen
        Dim rectBounds As Rectangle

        If Form1.VSAttack.Value < Form1.VSDecay.Value Then
            Form1.VSDecay.Value = Form1.VSAttack.Value
        End If

        Form1.txtAttack.Text = 0 - Form1.VSAttack.Value

        objMyPen = New Pen(Drawing.Color.DarkBlue, 3)
        rectBounds = New Rectangle(0, 0, adsr.Width, adsr.Height)

        objGraphics = Graphics.FromImage(adsr)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawLine(objMyPen, -Form1.VSAttack.Value, 10, 0, 100)
        objGraphics.DrawLine(objMyPen, -Form1.VSAttack.Value, 10, -Form1.VSDecay.Value, 100 + Form1.VSSustain.Value)
        objGraphics.DrawLine(objMyPen, -Form1.VSDecay.Value, 100 + Form1.VSSustain.Value, 150, 100 + Form1.VSSustain.Value)
        objGraphics.DrawLine(objMyPen, 150, 100 + Form1.VSSustain.Value, 150 - Form1.VSRelease.Value, 100)

        objGraphics.Dispose()
        Form1.PictureBox1.Invalidate()
    End Sub


    Public Sub drawDecay()

        Dim objGraphics As Graphics
        Dim objMyPen As Pen
        Dim rectBounds As Rectangle
        Dim decayVal As Integer

        If Form1.VSDecay.Value > Form1.VSAttack.Value Then
            Form1.VSDecay.Value = Form1.VSAttack.Value
        End If

        Form1.txtDecay.Text = 0 - Form1.VSDecay.Value
        decayVal = 100 + Form1.VSDecay.Value

        objMyPen = New Pen(Drawing.Color.DarkBlue, 3)
        rectBounds = New Rectangle(0, 0, adsr.Width, adsr.Height)

        objGraphics = Graphics.FromImage(adsr)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawLine(objMyPen, -Form1.VSAttack.Value, 10, 0, 100)
        objGraphics.DrawLine(objMyPen, -Form1.VSAttack.Value, 10, -Form1.VSDecay.Value, 100 + Form1.VSSustain.Value)
        objGraphics.DrawLine(objMyPen, -Form1.VSDecay.Value, 100 + Form1.VSSustain.Value, 150, 100 + Form1.VSSustain.Value)
        objGraphics.DrawLine(objMyPen, 150, 100 + Form1.VSSustain.Value, 150 - Form1.VSRelease.Value, 100)

        objGraphics.Dispose()
        Form1.PictureBox1.Invalidate()
    End Sub



    Public Sub drawSustain()

        Dim objGraphics As Graphics
        Dim objMyPen As Pen
        Dim rectBounds As Rectangle

        Form1.txtSustain.Text = 0 - Form1.VSSustain.Value

        objMyPen = New Pen(Drawing.Color.DarkBlue, 3)
        rectBounds = New Rectangle(0, 0, adsr.Width, adsr.Height)

        objGraphics = Graphics.FromImage(adsr)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawLine(objMyPen, -Form1.VSAttack.Value, 10, 0, 100)
        objGraphics.DrawLine(objMyPen, -Form1.VSAttack.Value, 10, -Form1.VSDecay.Value, 100 + Form1.VSSustain.Value)
        objGraphics.DrawLine(objMyPen, -Form1.VSDecay.Value, 100 + Form1.VSSustain.Value, 150, 100 + Form1.VSSustain.Value)
        objGraphics.DrawLine(objMyPen, 150, 100 + Form1.VSSustain.Value, 150 - Form1.VSRelease.Value, 100)

        objGraphics.Dispose()
        Form1.PictureBox1.Invalidate()

    End Sub

    Public Sub drawRelease()

        Dim objGraphics As Graphics
        Dim objMyPen As Pen
        Dim rectBounds As Rectangle
        Dim releaseVar As Integer


        Form1.txtRelease.Text = -Form1.VSRelease.Value

        releaseVar = 150

        objMyPen = New Pen(Drawing.Color.DarkBlue, 3)
        rectBounds = New Rectangle(0, 0, adsr.Width, adsr.Height)

        objGraphics = Graphics.FromImage(adsr)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawLine(objMyPen, -Form1.VSAttack.Value, 10, 0, 100)
        objGraphics.DrawLine(objMyPen, -Form1.VSAttack.Value, 10, -Form1.VSDecay.Value, 100 + Form1.VSSustain.Value)
        objGraphics.DrawLine(objMyPen, -Form1.VSDecay.Value, 100 + Form1.VSSustain.Value, 150, 100 + Form1.VSSustain.Value)
        objGraphics.DrawLine(objMyPen, 150, 100 + Form1.VSSustain.Value, 150 - Form1.VSRelease.Value, 100)

        objGraphics.Dispose()
        Form1.PictureBox1.Invalidate()
    End Sub

    '==============================================================
    '=================   Filter ==================================
    '==============================================================

    Public Sub drawHiPassCut()

        Dim objGraphics As Graphics
        Dim objMyPen As Pen
        Dim rectBounds As Rectangle

        'txthpCut.Text = hipassCutoff.Value
        Form1.txthpCut.Text = hpData(waveGenerator_index, 0)
        Form1.hipassRes.Value = Form1.hipassCutoff.Value

        objMyPen = New Pen(Drawing.Color.DarkRed, 2)
        objMyPen.DashStyle = Drawing2D.DashStyle.Dash
        rectBounds = New Rectangle(0, 0, hipass.Width, hipass.Height)

        objGraphics = Graphics.FromImage(hipass)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawLine(objMyPen, Form1.hipassCutoff.Value, 10, 200, 10)
        objGraphics.DrawLine(objMyPen, Form1.hipassCutoff.Value, 50, Form1.hipassCutoff.Value, 10)

        objGraphics.Dispose()
        Form1.PictureBox2.Invalidate()
    End Sub

    Public Sub drawHiPassRes()

        Dim objGraphics As Graphics
        Dim objMyPen As Pen
        Dim rectBounds As Rectangle

        If Form1.hipassRes.Value > Form1.hipassCutoff.Value Then
            Form1.hipassRes.Value = Form1.hipassCutoff.Value
        End If

        'txthpRes.Text = hipassRes.Value
        Form1.txthpRes.Text = hpData(waveGenerator_index, 1)

        objMyPen = New Pen(Drawing.Color.DarkBlue, 3)
        rectBounds = New Rectangle(0, 0, hipass.Width, hipass.Height)

        objGraphics = Graphics.FromImage(hipass)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawLine(objMyPen, Form1.hipassCutoff.Value, 10, 200, 10)
        objGraphics.DrawLine(objMyPen, Form1.hipassCutoff.Value, 50, Form1.hipassCutoff.Value, 10)
        objGraphics.DrawLine(objMyPen, Form1.hipassCutoff.Value, 10, Form1.hipassRes.Value, 50)

        objGraphics.Dispose()
        Form1.PictureBox2.Invalidate()
    End Sub


    Public Sub drawLowPassCut()

        Dim objGraphics As Graphics
        Dim objMyPen As Pen
        Dim rectBounds As Rectangle

        'txtlpCut.Text = lowpassCutoff.Value
        Form1.txtlpCut.Text = lpData(waveGenerator_index, 0)
        Form1.lowpassRes.Value = Form1.lowpassCutoff.Value

        objMyPen = New Pen(Drawing.Color.DarkRed, 2)
        objMyPen.DashStyle = Drawing2D.DashStyle.Dash
        rectBounds = New Rectangle(0, 0, lowpass.Width, lowpass.Height)

        objGraphics = Graphics.FromImage(lowpass)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawLine(objMyPen, Form1.lowpassCutoff.Value, 10, 10, 10)
        objGraphics.DrawLine(objMyPen, Form1.lowpassCutoff.Value, 50, Form1.lowpassCutoff.Value, 10)

        objGraphics.Dispose()
        Form1.PictureBox3.Invalidate()
    End Sub

    Public Sub drawLowPassRes()

        Dim objGraphics As Graphics
        Dim objMyPen As Pen
        Dim rectBounds As Rectangle

        If Form1.lowpassRes.Value < Form1.lowpassCutoff.Value Then
            Form1.lowpassRes.Value = Form1.lowpassCutoff.Value
        End If

        Form1.txtlpRes.Text = Form1.lowpassRes.Value
        Form1.txtlpRes.Text = lpData(waveGenerator_index, 1)


        objMyPen = New Pen(Drawing.Color.DarkBlue, 3)
        rectBounds = New Rectangle(0, 0, lowpass.Width, lowpass.Height)

        objGraphics = Graphics.FromImage(lowpass)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawLine(objMyPen, Form1.lowpassCutoff.Value, 10, 10, 10)
        objGraphics.DrawLine(objMyPen, Form1.lowpassCutoff.Value, 50, Form1.lowpassCutoff.Value, 10)
        objGraphics.DrawLine(objMyPen, Form1.lowpassCutoff.Value, 10, Form1.lowpassRes.Value, 50)
        objGraphics.Dispose()
        Form1.PictureBox3.Invalidate()
    End Sub


    '===============================================================================
    '======================== Splash screen stuff ===========================
    '===============================================================================

    Public Sub spash_screen()

        opening_sound()

        Dim Minutes As Double = 0.05
        Form1.Timer1.Interval = Minutes * 60 * 1000
        Form1.Timer1.Enabled = True

        Form1.PictureBox4.Location = New Point(0, 0)
        Form1.PictureBox4.Size = New System.Drawing.Size(554, 710)
    End Sub

End Module
