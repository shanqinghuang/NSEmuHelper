Module NSEmuHelperModule
    'Public AppPath As String = Application.StartupPath
    Public AppPath As String = "C:\Users\yidaozhan\source\repos\NSEmuHelper"
    Public Config As New ConfigFilePattern
    Public FSO = My.Computer.FileSystem 'alias
    Public MainUILoaded As Boolean = False
    Public ConfigUILoaded As Boolean = False

    Public GitHubSources As New Newtonsoft.Json.Linq.JObject
    Public GitHubSourceUrl As String
End Module
