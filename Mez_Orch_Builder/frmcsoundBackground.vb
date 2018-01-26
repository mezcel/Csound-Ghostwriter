Public Class frmcsoundBackground

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmcsoundBackground_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtGen.Visible = False
        txtoscil.Visible = False
        txtpvsosc.Visible = False
        txtGrain.Visible = False
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtGen.Visible = True
        txtGen.Location = New Point(12, 12)

        txtoscil.Visible = False
        txtpvsosc.Visible = False
        txtCsound.Visible = False
        txtGrain.Visible = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtoscil.Visible = True
        txtoscil.Location = New Point(12, 12)

        txtGen.Visible = False
        txtCsound.Visible = False
        txtpvsosc.Visible = False
        txtGrain.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtpvsosc.Visible = True
        txtpvsosc.Location = New Point(12, 12)

        txtGen.Visible = False
        txtoscil.Visible = False
        txtCsound.Visible = False
        txtGrain.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtGrain.Visible = True
        txtGrain.Location = New Point(12, 12)

        txtGen.Visible = False
        txtoscil.Visible = False
        txtCsound.Visible = False
        txtpvsosc.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtGen.Visible = False
        txtoscil.Visible = False
        txtCsound.Visible = True
        txtpvsosc.Visible = False
        txtGrain.Visible = False
    End Sub
End Class