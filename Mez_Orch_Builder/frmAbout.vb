Public Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbAuthor.Hide()
        Me.Size = New System.Drawing.Size(506, 672)
    End Sub

    Private Sub btnProgrammer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProgrammer.Click
        pbAuthor.Show()
        Me.Size = New System.Drawing.Size(991, 672)
    End Sub

    Private Sub btnShrink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShrink.Click
        pbAuthor.Hide()
        Me.Size = New System.Drawing.Size(506, 672)
    End Sub
End Class