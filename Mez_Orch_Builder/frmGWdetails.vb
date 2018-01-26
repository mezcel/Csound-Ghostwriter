Imports SpeechLib
Public Class frmGWdetails

#Region " Windows Form Designer generated code "
    Private voice As SpVoice
#End Region

    Dim picCounter As Integer = 1

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim clsStartInfo As New System.Diagnostics.ProcessStartInfo
        clsStartInfo.FileName = "iexplore.exe"
        clsStartInfo.Arguments = "http://mezcel2008.googlepages.com"
        clsStartInfo.WindowStyle = ProcessWindowStyle.Minimized
        System.Diagnostics.Process.Start(clsStartInfo)
        picStudio.Visible = False
        picStudio2.Visible = False
        picStudio3.Visible = False
        TextBox1.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim clsStartInfo As New System.Diagnostics.ProcessStartInfo
        clsStartInfo.FileName = "iexplore.exe"
        clsStartInfo.Arguments = "http://mezcel.googlepages.com/engineerart"
        clsStartInfo.WindowStyle = ProcessWindowStyle.Minimized
        System.Diagnostics.Process.Start(clsStartInfo)
        picStudio.Visible = False
        picStudio2.Visible = False
        picStudio3.Visible = False
        TextBox1.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim clsStartInfo As New System.Diagnostics.ProcessStartInfo
        clsStartInfo.FileName = "iexplore.exe"
        clsStartInfo.Arguments = "http://mezcel.googlepages.com/ghostwriter_developer"
        clsStartInfo.WindowStyle = ProcessWindowStyle.Minimized
        System.Diagnostics.Process.Start(clsStartInfo)
        picStudio.Visible = False
        picStudio2.Visible = False
        picStudio3.Visible = False
        TextBox1.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim clsStartInfo As New System.Diagnostics.ProcessStartInfo
        clsStartInfo.FileName = "iexplore.exe"
        clsStartInfo.Arguments = "http://www.soundclick.com/bands/default.cfm?bandID=344623"
        clsStartInfo.WindowStyle = ProcessWindowStyle.Minimized
        System.Diagnostics.Process.Start(clsStartInfo)
        picStudio.Visible = False
        picStudio2.Visible = False
        picStudio3.Visible = False
        TextBox1.Visible = True
    End Sub

    Private Sub frmGWdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        picStudio.Visible = False
        picStudio2.Visible = False
        picStudio3.Visible = False
        TextBox1.Visible = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        TextBox1.Visible = False

        If picCounter > 3 Then
            picCounter = 1
        End If

        Select Case picCounter
            Case 1
                picStudio.Visible = True
                picStudio2.Visible = False
                picStudio3.Visible = False
            Case 2
                picStudio.Visible = False
                picStudio2.Visible = True
                picStudio3.Visible = False
            Case 3
                picStudio.Visible = False
                picStudio2.Visible = False
                picStudio3.Visible = True
        End Select



        picCounter = picCounter + 1

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        voice = New SpVoice

        TextBox1.Visible = True
        picStudio.Visible = False
        picStudio2.Visible = False
        picStudio3.Visible = False


        voice.Speak("Hello application user! Thank you for evaluating my software! This project was a fun way to learn and play at the same time. My target audience is the IDM music community. Additional audiences include C sound, D S P and windoes developers. Known bugs are the following: The F Table works, but you must still monitor the below waveform to confirm its changes. The F Table resets itself upon every edit instance. In regards to the forced table reset, I was just too lazy to import a save array for each sample point. The grrain button is more experimental than practical. If you are a circuit bender, you will appreciate it. But you must perform trial by error to learn what numbers to enter. Take this hint: A little goes a long way! For anything else, just email me at M E Z C E L @ G mail dot com. Thank you.")


    End Sub
End Class