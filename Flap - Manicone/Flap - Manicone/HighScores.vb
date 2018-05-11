Public Class HighScores
    Public intHScore As Integer
    Private Sub HighScores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intFile As Integer
        'File Management
        intFile = FreeFile()
        FileOpen(intFile, "HighScore.txt", OpenMode.Input)
        frmGame.strPlayer = LineInput(intFile)
        intHScore = LineInput(intFile)
        FileClose()
    End Sub
End Class