Public Class HighScores
    Public intHScore As Integer
    Private Sub HighScores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intFile As Integer
        Dim strHPlayer As String
        'File Management
        intFile = FreeFile()
        FileOpen(intFile, "HighScore.txt", OpenMode.Input)
        strHPlayer = LineInput(intFile)
        intHScore = LineInput(intFile)
        FileClose()
        'display
        lblScore.Text = "Player: " & strHPlayer & ", Score: " & intHScore
    End Sub

End Class