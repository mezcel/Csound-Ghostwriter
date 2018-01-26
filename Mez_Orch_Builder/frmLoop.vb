Public Class frmLoop

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim good2go As Boolean
        good2go = True

        If txtBeatNumber.Text > 0 And txtBeatNumber.Text < 100 Then
            loopScore = txtBeatNumber.Text
        Else
            good2go = False
            txtBeatNumber.Text = "0 > Value > 100"
        End If

        If txtBeatSpace.Text > 0 And txtBeatSpace.Text < 4 Then
            loopSpeed = txtBeatSpace.Text
        Else
            good2go = False
            txtBeatSpace.Text = "0 > Value > 4"
        End If

        If good2go = True Then
            Me.Hide()
        End If

        small_b = txtsmallb.Text
        big_B = txtBigb.Text

    End Sub

    Private Sub txtBeatNumber_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtBeatNumber.MouseClick
        txtBeatNumber.Text = ""
    End Sub

    Private Sub txtBeatSpace_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtBeatSpace.MouseClick
        txtBeatSpace.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("This grain button is more experimental than practical." & ControlChars.CrLf & "If you are a 'circuit bender', you'll love it though." & ControlChars.CrLf & "But you must trial by error on what numbers to enter." & ControlChars.CrLf & "Hint: A little goes a long way!" & ControlChars.CrLf & "" & ControlChars.CrLf & "See the 'Csound Background' in the 'Help' menu for a tip on using this." & ControlChars.CrLf & "" & ControlChars.CrLf & "Play with the sample rate to get different effects. Trust me... there is some cool funky DSP sampling fun here")
    End Sub
End Class