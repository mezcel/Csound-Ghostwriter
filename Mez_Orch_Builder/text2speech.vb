Imports SpeechLib
Public Class text2speech

    Private voice As SpVoice

    Private Sub btnTalk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTalk.Click
        voice = New SpVoice
        voice.Speak(txt2voice.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class