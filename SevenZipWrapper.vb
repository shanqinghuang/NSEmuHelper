
Imports SevenZip
Public Class SevenZipWrapper
    Public Property PercentDone As Integer = 0
    Public Property Finished As Boolean = False

    Public WithEvents Extractor As SevenZipExtractor

    Public Sub Extract(FilePath As String, OutputPath As String)
        SevenZipBase.SetLibraryPath(AppPath & "\Modules\7z.dll")
        Extractor = New SevenZipExtractor(FilePath)
        Extractor.BeginExtractArchive(OutputPath)
    End Sub

    Private Sub Extractor_Extracting(sender As Object, e As ProgressEventArgs) Handles Extractor.Extracting
        PercentDone = Int(e.PercentDone)
    End Sub

    Private Sub Extractor_ExtractionFinished(sender As Object, e As EventArgs) Handles Extractor.ExtractionFinished
        Finished = True
    End Sub
End Class
