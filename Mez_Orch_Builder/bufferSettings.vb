Public Class bufferSettings

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Size = New System.Drawing.Size(351, 431)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Size = New System.Drawing.Size(351, 206)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        small_b = txtsmallb.Text
        big_B = txtBigb.Text
        Me.Close()

    End Sub

    Private Sub bufferSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(351, 206)
    End Sub
End Class