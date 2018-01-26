Public Class frmMainMixer
    Public volMeter As Bitmap
    Dim rectBounds As Rectangle
    Dim vol, thresh, dheight As Integer
    Dim objGraphics As Graphics
    Dim objMyPen, objMyPen2, objMyPen3, objMyPen4, objMyPen5, objMyPen6, objMyPen7 As Pen


    Private Sub frmMainMixer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        volMeter = New Bitmap(PictureBox1.ClientRectangle.Width, PictureBox1.ClientRectangle.Height, Drawing.Imaging.PixelFormat.Format24bppRgb)
        rectBounds = New Rectangle(0, 0, volMeter.Width, volMeter.Height)

        dheight = 180
        vol = 79
        thresh = 49

        objMyPen = New Pen(Drawing.Color.LimeGreen, 10)
        objMyPen2 = New Pen(Drawing.Color.Red, 10)
        objMyPen3 = New Pen(Drawing.Color.LawnGreen, 10)
        objMyPen4 = New Pen(Drawing.Color.Orange, 10)
        objMyPen5 = New Pen(Drawing.Color.Crimson, 10)
        objMyPen6 = New Pen(Drawing.Color.Blue, 10)
        objMyPen7 = New Pen(Drawing.Color.Crimson, 10)

        trkbVol.Value = vol
        trkbThresh.Value = thresh

        'trkbReverbTime.Value = 1
        'trkbReverbDensity.Value = 1
        trkbVol.Value = 80
        trkbThresh.Value = 50
    End Sub

    Private Sub drawVol()
        If vol <= dheight - 5 Then
            vol = vol + 5
        End If

        meter()
        
    End Sub

    Private Sub drawThresh()
        If thresh <= dheight - 5 Then
            thresh = thresh + 5
        End If

        meter()

    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        Dim objGraphics As Graphics
        objGraphics = e.Graphics
        objGraphics.DrawImage(volMeter, 0, 0, volMeter.Width, volMeter.Height)

    End Sub

    Private Sub trkbVol_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkbVol.ValueChanged
        txtVol.Text = trkbVol.Value
        masterVolume = trkbVol.Value
        vol = dheight - (dheight * (trkbVol.Value / 100))
        drawVol()
    End Sub

    Private Sub trkbThresh_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkbThresh.ValueChanged
        txtThresh.Text = (trkbThresh.Value - 50) / 50
        masterThreshold = trkbThresh.Value
        thresh = dheight - (dheight * (trkbThresh.Value / 100))
        drawThresh()
    End Sub

    Private Sub meter()
        objGraphics = Graphics.FromImage(volMeter)
        objGraphics.Clear(System.Drawing.SystemColors.Control)
        If vol > dheight * 0.8 Then
            objGraphics.DrawLine(objMyPen6, 5, vol, 5, dheight) 'blue
        ElseIf vol > dheight * 0.2 Then
            objGraphics.DrawLine(objMyPen, 5, vol, 5, dheight) 'yellow
        ElseIf vol > dheight * 0.1 Then
            objGraphics.DrawLine(objMyPen4, 5, vol, 5, dheight) 'red
        Else
            objGraphics.DrawLine(objMyPen2, 5, vol, 5, dheight) 'green
        End If

        If thresh < (dheight / 2) Then
            objGraphics.DrawLine(objMyPen7, 15, thresh, 15, dheight)
        Else
            objGraphics.DrawLine(objMyPen3, 15, thresh, 15, dheight)
        End If

        objGraphics.Dispose()
        PictureBox1.Invalidate()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub ckbReverb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbReverb.CheckedChanged
        If ckbReverb.Checked = True Then
            trkbReverbTime.Value = 1
            trkbReverbDensity.Value = 1
        End If
        MsgBox("Keep the Density low")
    End Sub

    Private Sub trkbReverbDensity_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkbReverbDensity.ValueChanged
        txtReverbDensity.Text = trkbReverbDensity.Value
    End Sub

    Private Sub trkbReverbTime_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkbReverbTime.ValueChanged
        txtReverbTime.Text = trkbReverbTime.Value
    End Sub


End Class