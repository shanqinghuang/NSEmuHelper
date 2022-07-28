Public Class ConfigFilePattern
    Public YuzuPath As String = "D:\Yuzu"
    Public RyujinxPath As String = "D:\Ryujinx"

    Public YuzuVersion As String = ""
    Public RyujinxVersion As String = ""

    Public YuzuFirmwareVersion As String = ""
    Public RyujinxFirmwareVersion As String = ""

    Public YuzuBranch As String = ""
    Public RyujinxBranch As String = ""

    Public YuzuDataFolder As String = ""
    Public RyujinxDataFolder As String = ""

    Public DownloadSource As String = "OneDrive"

    Public ColorScheme As String = "IndigoLight"

    Public GitHubAPIProxy As Boolean = True

    '以下的配置不会在 GUI 中出现
    Public CloudflareProxyPrefix As String = "https://rp.ydz1.gq/"
    Public ModDownloadSource As String = "https://www.githubs.cn/raw-githubusercontent/wiki/yuzu-emu/yuzu/Switch-Mods.md"
    Public TitleListSource As String = "https://www.githubs.cn/raw-githubusercontent/amakvana/YuzuModDownloader/main/assets/GameTitleIDs.xml"
    Public SkipCheckMD5 As Boolean = False
End Class