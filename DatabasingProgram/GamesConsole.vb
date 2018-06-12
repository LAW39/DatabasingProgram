Public Class GamesConsole
    Public ConsoleName As String
    Public ConsoleSold As Long
    Public ConsoleMake As String
    Public ConsoleRelease As Date

    Public Overrides Function ToString() As String
        Dim ConsoleOutput As String
        ConsoleOutput = ConsoleName & " " & CStr(ConsoleMake)
        Return ConsoleOutput
    End Function


End Class
