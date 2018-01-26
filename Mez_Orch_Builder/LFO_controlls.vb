Module LFO_controlls
    'Public lfoLP As Bitmap
    Dim rectBounds As Rectangle

    Dim objGraphics As Graphics
    Dim objMyPen, objMyPen2, objMyPen3, objMyPen4, objMyPen5 As Pen

    Public Sub lfo_Waveshapes(ByVal LFOScreen As Bitmap)

        Dim level, hz, shape, lscale As Integer
        lscale = 2
        'rectBounds = New Rectangle(0, 0, lfoLP.Width, lfoLP.Height)
        'loadPens()

        If LFOScreen Is lfoLP Then
            rectBounds = New Rectangle(0, 0, lfoLP.Width, lfoLP.Height)
            loadPens()
            level = lscale * Form1.tkbLFO_LP_level.Value
            hz = Form1.tkbLFO_LP_Hz.Value
            shape = Form1.tkbLFO_LP_Shape.Value

            Select Case shape
                Case 0
                    sineShape(level, hz, LFOScreen)
                Case 1
                    triangleShape(level, hz, LFOScreen)
                Case 2
                    squareShapeBipole(level, hz, LFOScreen)
                Case 3
                    squareShape(level, hz, LFOScreen)
                Case 4
                    sawShape(level, hz, LFOScreen)
                Case 5
                    sawShape_Down(level, hz, LFOScreen)
            End Select

        ElseIf LFOScreen Is lfoHP Then 'highpass
            rectBounds = New Rectangle(0, 0, lfoHP.Width, lfoHP.Height)
            loadPens()
            level = lscale * Form1.tkbLFO_HP_level.Value
            hz = Form1.tkbLFO_HP_Hz.Value
            shape = Form1.tkbLFO_HP_Shape.Value

            Select Case shape
                Case 0
                    sineShape(level, hz, LFOScreen)
                Case 1
                    triangleShape(level, hz, LFOScreen)
                Case 2
                    squareShapeBipole(level, hz, LFOScreen)
                Case 3
                    squareShape(level, hz, LFOScreen)
                Case 4
                    sawShape(level, hz, LFOScreen)
                Case 5
                    sawShape_Down(level, hz, LFOScreen)
            End Select
        End If

        'objGraphics.Dispose()
        Form1.picBox_LPLFO.Invalidate()
        Form1.picBox_HPLFO.Invalidate()

    End Sub

    Private Sub loadPens()
        objMyPen = New Pen(Drawing.Color.LimeGreen, 1)
        objMyPen2 = New Pen(Drawing.Color.Red, 3)
        objMyPen3 = New Pen(Drawing.Color.OliveDrab, 2)
        objMyPen4 = New Pen(Drawing.Color.Orange, 2)
        objMyPen5 = New Pen(Drawing.Color.Crimson, 1)
    End Sub

    Private Sub sineShape(ByVal level As Integer, ByVal hz As Integer, ByVal LFOScreen As Bitmap)
        Dim lfoPointLength, x, y, period As Integer

        objGraphics = Graphics.FromImage(LFOScreen)
        objGraphics.Clear(System.Drawing.SystemColors.Control)
        objGraphics.DrawLine(objMyPen3, 0, 20, 130, 20)
        lfoPointLength = 130 'max x function
        period = (6.28 / 2) * (1 / hz)

        For x_loop As Integer = 0 To lfoPointLength 'Step stepLength
            x = x_loop
            y = level * Math.Sin(hz * ((6.28 * x) / 130))
            y = y + 20

            objGraphics.DrawLine(objMyPen2, x, y, x, y + 1)
        Next

    End Sub

    Private Sub squareShapeBipole(ByVal level As Integer, ByVal hz As Integer, ByVal LFOScreen As Bitmap)
        Dim lfoPointLength, x, y, y_square, period As Integer
        Dim y_square_pole(130) As Integer
       
        objGraphics = Graphics.FromImage(LFOScreen)
        objGraphics.Clear(System.Drawing.SystemColors.Control)
        objGraphics.DrawLine(objMyPen3, 0, 20, 130, 20)
        lfoPointLength = 130 'max x function
        period = (6.28 / 2) * (1 / hz)


        For x_loop As Integer = 0 To lfoPointLength 'Step stepLength
            x = x_loop
            y = level * Math.Sin(hz * ((6.28 * x) / lfoPointLength))
            y = y + 20

            If y >= 20 Then
                y_square = 20 - level
                y_square_pole(x) = y_square
                objGraphics.DrawLine(objMyPen2, x, y_square, x, y_square + 1)
            Else
                y_square = level + 20
                objGraphics.DrawLine(objMyPen2, x, y_square, x, y_square + 1)
                y_square_pole(x) = y_square
            End If

            If x > 0 Then
                If y_square_pole(x - 1) > y_square_pole(x) Or y_square_pole(x - 1) < y_square_pole(x) Then
                    objGraphics.DrawLine(objMyPen2, x - 1, y_square_pole(x - 1), x, y_square_pole(x))
                End If
            End If
        Next

    End Sub
    Private Sub squareShape(ByVal level As Integer, ByVal hz As Integer, ByVal LFOScreen As Bitmap)
        Dim lfoPointLength, x, y, y_square, period As Integer
        Dim y_square_pole(130) As Integer
        objGraphics = Graphics.FromImage(LFOScreen)
        objGraphics.Clear(System.Drawing.SystemColors.Control)
        objGraphics.DrawLine(objMyPen3, 0, 20, 130, 20)
        lfoPointLength = 130 'max x function
        period = (6.28 / 2) * (1 / hz)


        For x_loop As Integer = 0 To lfoPointLength 'Step stepLength
            x = x_loop
            y = level * Math.Sin(hz * ((6.28 * x) / lfoPointLength))
            y = y + 20

            If y >= 20 Then
                y_square = 20 - level
                y_square_pole(x) = y_square
                objGraphics.DrawLine(objMyPen2, x, y_square, x, y_square + 1)
            Else
                y_square = 20
                objGraphics.DrawLine(objMyPen2, x, y_square, x, y_square + 1)
                y_square_pole(x) = y_square
            End If


            If x > 0 Then
                If y_square_pole(x - 1) > y_square_pole(x) Or y_square_pole(x - 1) < y_square_pole(x) Then
                    objGraphics.DrawLine(objMyPen2, x - 1, y_square_pole(x - 1), x, y_square_pole(x))
                End If
            End If

        Next
    End Sub
    Private Sub sawShape(ByVal level As Integer, ByVal hz As Integer, ByVal LFOScreen As Bitmap)
        objGraphics = Graphics.FromImage(LFOScreen)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        Dim x1, x2 As Integer
        objGraphics.DrawLine(objMyPen3, 0, 20, 130, 20)
        x1 = 0
        x2 = 130 / hz
        level = 20 - level
        For x As Integer = 0 To 130 Step x2
            x1 = x + x2
            objGraphics.DrawLine(objMyPen2, x, 20, x1, level)
            objGraphics.DrawLine(objMyPen2, x1, 20, x1, level)
        Next


    End Sub
    Private Sub sawShape_Down(ByVal level As Integer, ByVal hz As Integer, ByVal LFOScreen As Bitmap)
        objGraphics = Graphics.FromImage(LFOScreen)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        Dim x1, x2 As Integer
        objGraphics.DrawLine(objMyPen3, 0, 20, 130, 20)
        x1 = 0
        x2 = 130 / hz
        level = 20 - level
        For x As Integer = 0 To 130 Step x2
            x1 = x + x2
            objGraphics.DrawLine(objMyPen2, x1, 20, x, level)
            objGraphics.DrawLine(objMyPen2, x1, 20, x1, level)
        Next
    End Sub

    Private Sub triangleShape(ByVal level As Integer, ByVal hz As Integer, ByVal LFOScreen As Bitmap)
        objGraphics = Graphics.FromImage(LFOScreen)
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        Dim x1, x2, x_half, c As Integer
        objGraphics.DrawLine(objMyPen3, 0, 20, 130, 20)
        x1 = 0
        x2 = 130 / hz
        level = 20 - level
        c = 0
        For x As Integer = 0 To 130 Step x2
            c = c + 1
            x1 = x + x2
            x_half = (x + x1) / 2
            objGraphics.DrawLine(objMyPen2, x, 20, x_half, level)
            objGraphics.DrawLine(objMyPen2, x_half, level, x1, 20)
        Next
    End Sub


End Module
