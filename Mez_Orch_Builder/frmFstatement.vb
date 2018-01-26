Public Class frmFstatement
    Public radioBtn_array(16, 8) As RadioButton
    Public point_Array(16) As GroupBox
    Public drawpoint_array(16) As Integer
    'Public fdata_array(16) As Double

    Dim point_index, ampdraw_index As Integer



    Private Sub frmFstatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ftable = New Bitmap(PictureBox5.ClientRectangle.Width, PictureBox5.ClientRectangle.Height, Drawing.Imaging.PixelFormat.Format24bppRgb)
        draw_points() 'create objects

        For p As Integer = 0 To 16 'default initialization for drawing
            drawpoint_array(p) = 45
            fdata_array(waveGenerator_index, p) = 0
        Next

        draw_ftable()

        txtSignalName.Text = waveTabName(waveGenerator_index)
        txtTableNumber.Text = waveGenerator_index + 1


    End Sub

    Private Sub draw_points()

        Dim point_x, point_y As Integer
        point_x = 12
        point_y = 12


        For point As Integer = 0 To 16
            point_Array(point) = New GroupBox
            Me.Controls.Add(point_Array(point))

            'If point >= 8 Then
            '    point_x = -478
            '    point_y = 240
            'End If
            point_Array(point).Location = New Point(point_x + (70 * point), point_y)
            point_Array(point).Size = New System.Drawing.Size(65.5, 230)
            point_Array(point).Text = "Point " & point
            point_Array(point).BackColor = Color.White
            point_Array(point).Name = point
            AddHandler point_Array(point).MouseEnter, AddressOf pointUpdate_MouseEnter


            For amplitude As Integer = 0 To 8
                radioBtn_array(point, amplitude) = New RadioButton
                radioBtn_array(point, amplitude).BackColor = Color.White
                radioBtn_array(point, amplitude).Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

                point_Array(point).Controls.Add(radioBtn_array(point, amplitude))

                radioBtn_array(point, amplitude).Location = New Point(6, 19 + (23 * amplitude))
                radioBtn_array(point, amplitude).Size = New System.Drawing.Size(57.5, 17)
                radioBtn_array(point, amplitude).Cursor = Cursors.Hand
                radioBtn_array(point, amplitude).Name = amplitude
                AddHandler radioBtn_array(point, amplitude).CheckedChanged, AddressOf radio_Checked

                label_amp(point, amplitude)
            Next
        Next

    End Sub

    Private Sub pointUpdate_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        point_index = sender.name

    End Sub

    Private Sub radio_Checked(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ampdraw_index = sender.name

        If ampdraw_index <= 4 Then
            fdata_array(waveGenerator_index, point_index) = 1 - (ampdraw_index * 0.25)
        ElseIf ampdraw_index > 4 Then
            fdata_array(waveGenerator_index, point_index) = (1 - (ampdraw_index * 0.25))
        End If

        ampdraw_index = 5 + (ampdraw_index * 10)
        drawpoint_array(point_index) = ampdraw_index
        draw_ftable()

        TextBox9.Text = point_index
        TextBox8.Text = fdata_array(waveGenerator_index, point_index)


    End Sub

    Private Sub label_amp(ByVal Point, ByVal amplitude)
        Dim amplabel As String
        amplabel = "0.00"

        Select Case amplitude
            Case 0
                amplabel = "+100%"
            Case 1
                amplabel = "+75%"
            Case 2
                amplabel = "+50%"
            Case 3
                amplabel = "+25%"
            Case 4
                amplabel = "zero"
                radioBtn_array(Point, 4).Checked = True
            Case 5
                amplabel = "-25%"
            Case 6
                amplabel = "-50%"
            Case 7
                amplabel = "-75%"
            Case 8
                amplabel = "-100%"
        End Select

        radioBtn_array(Point, amplitude).Text = amplabel
    End Sub

    Private Sub draw_ftable()
        Dim objGraphics As Graphics
        Dim objMyPen, grid As Pen
        Dim rectBounds As Rectangle

        objMyPen = New Pen(Drawing.Color.Tomato, 4)
        grid = New Pen(Drawing.Color.SteelBlue, 1)
        grid.DashStyle = Drawing2D.DashStyle.Dash

        rectBounds = New Rectangle(0, 0, ftable.Width, ftable.Height)
        objGraphics = Graphics.FromImage(ftable)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        For p As Integer = 0 To 15
            objGraphics.DrawLine(objMyPen, 5 + (p * 35), drawpoint_array(p), 5 + ((p + 1) * 35), drawpoint_array(p + 1))
        Next

        For p As Integer = 0 To 16
            objGraphics.DrawLine(grid, 5 + (p * 35), 5, 5 + (p * 35), 85)
        Next
        For a As Integer = 0 To 8
            objGraphics.DrawLine(grid, 5, 5 + (a * 10), 565, 5 + (a * 10))
        Next

        objGraphics.Dispose()
        Me.PictureBox5.Invalidate()
    End Sub


    Private Sub PictureBox5_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox5.Paint
        Dim objGraphics As Graphics
        objGraphics = e.Graphics
        objGraphics.DrawImage(ftable, 0, 0, ftable.Width, ftable.Height)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If cbGENselect.Text <> "GEN Routine" Then
            Me.Close()
        Else
            MsgBox("Enter a Gen Number")
        End If
    End Sub

    Private Sub cbGENselect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGENselect.SelectedIndexChanged
        Dim GEN As Integer

        Select Case cbGENselect.Text
            Case "GEN1"
                GEN = 1
            Case "GEN2"
                GEN = 2
            Case "GEN3"
                GEN = 3
            Case "GEN4"
                GEN = 4
            Case "GEN5"
                GEN = 5
            Case "GEN6"
                GEN = 6
            Case "GEN7"
                GEN = 7
            Case "GEN8"
                GEN = 8
            Case "GEN9"
                GEN = 9
            Case "GEN110"
                GEN = 10
            Case "GEN11"
                GEN = 11
            Case "GEN12"
                GEN = 12
            Case "GEN13"
                GEN = 13
            Case "GEN14"
                GEN = 14
            Case "GEN15"
                GEN = 15
            Case "GEN16"
                GEN = 16
            Case "GEN17"
                GEN = 17
            Case "GEN18"
                GEN = 18
            Case "GEN19"
                GEN = 19
            Case "GEN20"
                GEN = 20
            Case Else
                Debug.WriteLine("Not active yet :'(")
        End Select

        ftabl_array(waveGenerator_index, 1) = GEN
    End Sub


End Class