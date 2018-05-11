Public Class frmStart

    Private Sub frmStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Me.Hide()
        frmGame.Show()
        If txtPlayer.Text <> "" Then
            frmGame.strPlayer = txtPlayer.Text
        End If

    End Sub

    Private Sub txtPlayer_TextChanged(sender As Object, e As EventArgs) Handles txtPlayer.TextChanged
        If txtPlayer.Text = "" Then
            frmGame.strPlayer = "Anonymous"
        End If
    End Sub
End Class